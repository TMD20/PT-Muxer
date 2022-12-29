import os, logging
import numpy as np
from .bufferedrandomplus import BufferedRandomPlus
from .imageutil import *
from .timeutil import *
from .enumerations import *

class InvalidSegmentError(Exception):
    pass

class BDSupReader:
    
    def __init__(self, filePath, bufferSize=1024*1024, verbose=False):
        self.filePath = filePath
        self.bufferSize = bufferSize
        self.startSegment = None
        self.endSegment = None
        self.verbose = verbose

    @property
    def segments(self):
        if self.startSegment is None:
            with open(self.filePath, 'r+b', buffering = self.bufferSize) as _:
                if not hasattr(self, '_size'):
                    self._size = os.fstat(_.fileno()).st_size
                self._stream = BufferedRandomPlus(_)
                stream = self._stream
                # Get start segment
                segment = Segment(stream)
                self.startSegment = segment
                while stream.offset < self._size:
                    prevSegment = segment
                    segment = Segment(stream)
                    prevSegment.next = segment
                    segment.prev = prevSegment
                    yield prevSegment
                self.endSegment = segment
                yield segment
        else:
            segment = self.startSegment
            while segment is not self.endSegment:
                yield segment
                segment = segment.next
            yield segment
    
    @property
    def displaySets(self):
        segments = self.segments
        startSegment = next(segments)
        for segment in segments:
            if segment.type == SEGMENT_TYPE.END:
                yield DisplaySet(startSegment, segment)
                startSegment = segment.next
        if segment is not startSegment:
            logger.warning('[Read Stream] The last display set lacks END segment')
            yield DisplaySet(startSegment, segment)
 
    @property
    def epochs(self):
        displaySets = self.displaySets
        startDisplaySet = next(displaySets)
        for displaySet in displaySets:
            if displaySet.PCSegment.data.compositionState == COMPOSITION_STATE.EPOCH_START:
                yield Epoch(startDisplaySet, displaySet.prev)
                startDisplaySet = displaySet
        yield Epoch(startDisplaySet, displaySet)

    @property
    def subPictures(self):
        displaySets = self.displaySets
        startDisplaySet = None
        for displaySet in displaySets:
            if displaySet.PCSegment.data.numberOfCompositionObjects > 0:
                if startDisplaySet is not None:
                    yield SubPicture(startDisplaySet, startDisplaySet)
                startDisplaySet = displaySet
            else:
                if startDisplaySet is not None:
                    yield SubPicture(startDisplaySet, displaySet)
                    startDisplaySet = None
        if startDisplaySet:
            logger.warning('[Read Stream] The last sub picture lacks end time')
            yield SubPicture(startDisplaySet, startDisplaySet)
    
    def getVector(self, frequency = 100, alpha = False):

        def sample(t):
            return round(t * frequency / 90000)

        vector = []
        end = 0
        for subPicture in self.subPictures:
            start = sample(subPicture.startTime)
            vector.extend([0] * (start - end))
            end = sample(subPicture.endTime)
            if alpha:
                vector.extend([subPicture.maxAlpha] * (end - start))
            else:
                vector.extend([255] * (end - start))
        return np.array(vector, dtype = np.uint8)
    
    def imageFilter(self, ft):
        for ep in self.epochs:
            ep.imageFilter(ft)
        return self

    def shift(self, value):
        for segment in self.segments:
            segment.pts += value
            segment.dts += value
        return self

    def shiftms(self, value):
        for segment in self.segments:
            segment.ptsms += value
            segment.dtsms += value
        return self

    def scale(self, value):
        for segment in self.segments:
            segment.pts *= value
            segment.dts *= value
        return self

    def transform(self, function):
        for ind, segment in enumerate(self.segments):
            segment.pts = function(ind, segment.pts)
            segment.dts = function(ind, segment.dts)
        return self

    def transformms(self, function):
        for ind, segment in enumerate(self.segments):
            segment.ptsms = function(ind, segment.ptsms)
            segment.dtsms = function(ind, segment.dtsms)
        return self

    def poly(self, coef):
        for segment in self.segments:
            segment.pts = np.polyval(coef, segment.pts)
            segment.dts = np.polyval(coef, segment.dts)
        return self

    def polyms(self, coef):
        for segment in self.segments:
            segment.ptsms = np.polyval(coef, segment.ptsms)
            segment.dtsms = np.polyval(coef, segment.dtsms)
        return self

class PresentationCompositionSegment:
    
    class CompositionObject:

        def __init__(self, stream, parent):
            self._parent = parent
            self.objectID = stream.readUShort()
            self.windowID = stream.readUChar()
            self.croppedFlag = stream.readByte()
            self.xPos = stream.readUShort()
            self.yPos = stream.readUShort()
            if self.cropped:
                self.cropXPos = stream.readUShort()
                self.cropYPos = stream.readUShort()
                self.cropWidth = stream.readUShort()
                self.cropHeight = stream.readUShort()
            else:
                self.cropXPos = None
                self.cropYPos = None
                self.cropWidth = None
                self.cropHeight = None

        @property
        def raw(self):
            result = self.objectID.to_bytes(2, byteorder = 'big') + \
                    bytes([self.windowID]) + \
                    self.croppedFlag + \
                    self.xPos.to_bytes(2, byteorder = 'big') + \
                    self.yPos.to_bytes(2, byteorder = 'big')
            if self.cropped:
                result += self.cropXPos.to_bytes(2, byteorder = 'big') + \
                        self.cropYPos.to_bytes(2, byteorder = 'big') + \
                        self.cropWidth.to_bytes(2, byteorder = 'big') + \
                        self.cropHeight.to_bytes(2, byteorder = 'big')
            return result

        @property
        def cropped(self):
            return self.croppedFlag[0] & 64 == 64
        @cropped.setter
        def cropped(self, value):
            if value:
                self.croppedFlag = bytes([self.croppedFlag[0] | 64])
            else:
                self.croppedFlag = bytes([self.croppedFlag[0] & 191])

        @property
        def parent(self):
            return self._parent

    def __init__(self, stream, parent):
        self._parent = parent
        self.width = stream.readUShort()
        self.height = stream.readUShort()
        self.frameRate = stream.readByte()
        self.compositionNumber = stream.readUShort()
        self.compositionState = COMPOSITION_STATE(stream.readByte())
        self.paletteUpdateFlag = stream.readByte()
        self.paletteID = stream.readUChar()
        self.numberOfCompositionObjects = stream.readUChar()
        self.compositionObjects = self.getCompositionObjects(stream)

    def getCompositionObjects(self, stream):
        comps = []
        stop = stream.offset + len(self.parent) - 11
        while stream.offset < stop:
            comps.append(self.CompositionObject(stream, self))
        numberOfCompositionObjects = len(comps)
        if numberOfCompositionObjects != self.numberOfCompositionObjects:
            logger.warning('[PCS] Number of composition objects asserted ({:d}) '
                    'does not match the amount found ({:d}). '
                    'The attribute will be reassigned'
                    .format(self.numberOfCompositionObjects, numberOfCompositionObjects))
            self.numberOfCompositionObjects = numberOfCompositionObjects
        return comps
    
    @property
    def raw(self):
        result = self.width.to_bytes(2, byteorder = 'big') + \
                self.height.to_bytes(2, byteorder = 'big') + \
                self.frameRate + \
                self.compositionNumber.to_bytes(2, byteorder = 'big') + \
                self.compositionState.value + \
                self.paletteUpdateFlag + \
                bytes([self.paletteID, self.numberOfCompositionObjects]) + \
                b''.join(o.raw for o in self.compositionObjects)
        return result

    @property
    def paletteUpdate(self):
        return self.paletteUpdateFlag[0] & 128 == 128
    @paletteUpdate.setter
    def paletteUpdate(self, value):
        if value:
            self.paletteUpdateFlag = bytes([self.paletteUpdateFlag[0] | 128])
        else:
            self.paletteUpdateFlag = bytes([self.paletteUpdateFlag[0] & 127])

    @property
    def parent(self):
        return self._parent

class WindowDefinitionSegment:
    
    class WindowObject:
        
        def __init__(self, stream, parent):
            self._parent = parent
            self.windowID = stream.readUChar()
            self.xPos = stream.readUShort()
            self.yPos = stream.readUShort()
            self.width = stream.readUShort()
            self.height = stream.readUShort()
        
        @property
        def parent(self):
            return self._parent

        @property
        def raw(self):
            result = bytes([self.windowID]) + \
                    self.xPos.to_bytes(2, byteorder = 'big') + \
                    self.yPos.to_bytes(2, byteorder = 'big') + \
                    self.width.to_bytes(2, byteorder = 'big') + \
                    self.height.to_bytes(2, byteorder = 'big')
            return result

    def __init__(self, stream, parent):
        self._parent = parent
        self.numberOfWindows = stream.readUChar()
        self.windowObjects = self.getWindowObjects(stream)

    def getWindowObjects(self, stream):
        windows = []
        stop = stream.offset + len(self.parent) - 1
        while stream.offset < stop:
            windows.append(self.WindowObject(stream, self))
        numberOfWindows = len(windows)
        if numberOfWindows != self.numberOfWindows:
            logger.warning('[WDS] Number of windows asserted ({:d}) '
                    'does not match the amount found ({:d}). '
                    'The attribute will be reassigned'
                    .format(self.numberOfWindows, numberOfWindows))
            self.numberOfWindows = numberOfWindows
        return windows
    
    @property
    def raw(self):
        result = bytes([self.numberOfWindows]) + \
                b''.join(o.raw for o in self.windowObjects)
        return result

    @property
    def parent(self):
        return self._parent

class PaletteDefinitionSegment:

    def __init__(self, stream, parent):
        self._parent = parent
        self.paletteID = stream.readUChar()
        self.version = stream.readUChar()
        self.paletteTable = np.asarray(list(stream.readBytes(len(self.parent) - 2)), dtype = np.uint8).reshape((-1, 5))

    @property
    def raw(self):
        result = bytes([self.paletteID, self.version]) + \
                self.paletteTable.tobytes()
        return result
    
    @property
    def YCrCbAPalette(self):
        # (Y, Cr, Cb) = (235, 128, 128) is white
        p = np.array([[235, 128, 128, 0]], dtype = np.uint8).repeat(256, axis = 0)
        for row in self.paletteTable:
            p[row[0]] = row[1:]
        return p
    @YCrCbAPalette.setter
    def YCrCbAPalette(self, value):
        self.paletteTable = np.column_stack((range(len(value)), value)).astype(np.uint8, copy = False)
    
    @property
    def RGBAPalette(self):
        return YCrCbA2RGBA(self.YCrCbAPalette)
    @RGBAPalette.setter
    def RGBAPalette(self, value):
        self.YCrCbAPalette = RGBA2YCrCbA(value)

    @property
    def parent(self):
        return self._parent

class ObjectDefinitionSegment:

    def __init__(self, stream = None, parent = None):
        self._parent = parent
        if stream is not None:
            self.objectID = stream.readUShort()
            self.version = stream.readUChar()
            self.sequence = stream.readByte()
            self.remains = stream.readBytes(len(self.parent) - 4)
        else:
            self.objectID = None
            self.version = 0
            self.sequence = b'\x00'
            self.remains = None

    @property
    def dataLength(self):
        if self.first:
            return int.from_bytes(self.remains[:3], byteorder = 'big')
        else:
            if self.parent.prev is not self.parent:
                return self.parent.prev.data.dataLength
    @dataLength.setter
    def dataLength(self, value):
        if self.first:
            self.remains = value.to_bytes(3, byteorder = 'big') + self.remains[3:]
        else:
            if self.parent.prev is not self.parent:
                self.parent.prev.data.dataLength = value

    @property
    def width(self):
        if self.first:
            return int.from_bytes(self.remains[3:5], byteorder = 'big')
        else:
            if self.parent.prev is not self.parent:
                return self.parent.prev.data.width
    @width.setter
    def width(self, value):
        if self.first:
            self.remains = self.remains[:3] + value.to_bytes(2, byteorder = 'big') + self.remains[5:]
        else:
            if self.parent.prev is not self.parent:
                self.parent.prev.data.width = value
            
    @property
    def height(self):
        if self.first:
            return int.from_bytes(self.remains[5:7], byteorder = 'big')
        else:
            if self.parent.prev is not self.parent:
                return self.parent.prev.data.height
    @height.setter
    def height(self, value):
        if self.first:
            self.remains = self.remains[:5] + value.to_bytes(2, byteorder = 'big') + self.remains[7:]
        else:
            if self.parent.prev is not self.parent:
                self.parent.prev.data.height = value

    @property
    def RLDataFragment(self):
        if self.first:
            return self.remains[3:]
        else:
            return self.remains
    @RLDataFragment.setter
    def RLDataFragment(self, value):
        if self.first:
            dataLength = len(value)
            self.remains = self.remains[:3] + value
            if self.dataLength != dataLength:
                self.dataLength = dataLength
        else:
            self.remains = value

    @property
    def raw(self):
        result = self.objectID.to_bytes(2, byteorder = 'big') + \
                bytes([self.version]) + \
                self.sequence + \
                self.remains
        return result

    @property
    def parent(self):
        return self._parent
 
    @property
    def first(self):
        return self.sequence[0] & 128 == 128
    @first.setter
    def first(self, value):
        if value:
            self.sequence = bytes([self.sequence[0] | 128])
        else:
            self.sequence = bytes([self.sequence[0] & 127])

    @property
    def last(self):
        return self.sequence[0] & 64 == 64
    @last.setter
    def last(self, value):
        if value:
            self.sequence = bytes([self.sequence[0] | 64])
        else:
            self.sequence = bytes([self.sequence[0] & 191]) 

class EndSegment:
    
    def __init__(self, stream, parent):
        self._parent = parent

    @property
    def raw(self):
        return b''

    @property
    def parent(self):
        return self._parent

class Segment:

    OPTION = {
        SEGMENT_TYPE.PCS: PresentationCompositionSegment,
        SEGMENT_TYPE.WDS: WindowDefinitionSegment,
        SEGMENT_TYPE.PDS: PaletteDefinitionSegment,
        SEGMENT_TYPE.ODS: ObjectDefinitionSegment,
        SEGMENT_TYPE.END: EndSegment
    }

    def __init__(self, stream = None):
        if stream is None:
            self._pts = None
            self._dts = None
            self.type = None
            self.size = None
            self.data = None
        else:
            if stream.readWord() != b'PG':
                raise InvalidSegmentError
            self._pts = stream.readUInt()
            self._dts = stream.readUInt()
            self.type = SEGMENT_TYPE(stream.readByte())
            self.size = stream.readUShort()
            self.data = self.OPTION[self.type](stream, self)
        
        self.prev = self
        self.next = self
        self._displaySet = None

    def __len__(self):
        return self.size

    def getDisplaySet(self, forward):
        if self._displaySet is None:
            if forward and self.next is not self:
                return self.next.getDisplaySet(True)
            elif not forward and self.prev is not self:
                return self.prev.getDisplaySet(False)
        return self._displaySet

    @property
    def displaySet(self):
        h = self.getDisplaySet(True)
        t = self.getDisplaySet(False)
        if h is t:
            if h is None:
                logger.warning('[Segment Display Set] First and last segments lack display set parents')
        else:
            logger.warning('[Segment Display Set] Start and stop segments have different display set parents')
            return None
        return h
    @displaySet.setter
    def displaySet(self, value):
        self._displaySet = value

    @property
    def raw(self):
        dataRaw = self.data.raw
        result = b'PG' + \
                self.pts.to_bytes(4, byteorder = 'big') + \
                self.dts.to_bytes(4, byteorder = 'big') + \
                self.type.value + \
                len(dataRaw).to_bytes(2, byteorder = 'big') + \
                dataRaw
        return result
    
    @property
    def pts(self):
        return self._pts
    @pts.setter
    def pts(self, value):
        if value > 4294967295:
            logger.warning(f'[Set PTS] Time ({value}) is larger than 4 bytes, 2^32 - 1 is used')
            value = 4294967295
        elif value < 0:
            logger.warning(f'[Set PTS] Time ({value}) cannot be negative, 0 is used')
            value = 0
        self._pts = int(round(value))
    
    @property
    def dts(self):
        return self._dts
    @dts.setter
    def dts(self, value):
        if value > 4294967295:
            logger.warning(f'[Set DTS] Time ({value}) is larger than 4 bytes, 2^32 - 1 is used')
            value = 4294967295
        elif value < 0:
            logger.warning(f'[Set DTS] Time ({value}) cannot be negative, 0 is used')
            value = 0
        self._dts = int(round(value))

    @property
    def ptsms(self):
        return self.pts / 90
    @ptsms.setter
    def ptsms(self, value):
        self.pts = value * 90

    @property
    def dtsms(self):
        return self.dts / 90
    @dtsms.setter
    def dtsms(self, value):
        self.dts = value * 90

class DisplaySet:

    def __init__(self, startSegment, stopSegment):
        self.startSegment = startSegment
        self.stopSegment = stopSegment
        self.startSegment.displaySet = self.stopSegment.displaySet = self
    
        self._epoch = None
        self.subPicture = None
        
    def getEpoch(self, forward):
        if self._epoch is None:
            if forward and self.next is not self:
                return self.getEpoch(True)
            elif not forward and self.prev is not self:
                return self.getEpoch(False)
        return self._epoch
    
    @property
    def epoch(self):
        h = self.getEpoch(True)
        t = self.getEpoch(False)
        if h is t:
            if h is None:
                logger.warning('[Display Set Epoch] First and last display sets lack epoch parents')
        else:
            logger.warning('[Display Set Epoch] Start and stop display sets have different epoch parents')
            return None
        return h
    @epoch.setter
    def epoch(self, value):
        self._epoch = value

    @property
    def prev(self):
        return self.startSegment.prev.displaySet

    @property
    def next(self):
        return self.stopSegment.next.displaySet

    @property
    def segments(self):
        segment = self.startSegment
        while segment is not self.stopSegment:
            yield segment
            segment = segment.next
        yield segment

    @property
    def raw(self):
        return b''.join(s.raw for s in self.segments)

    @property
    def PCSegment(self):
        PCS = self.startSegment
        if PCS.type is not SEGMENT_TYPE.PCS:
            logger.warning('[Display Set] PCS is not the first segment')
            PCS = next((s for s in self.getType(SEGMENT_TYPE.PCS)), None)
            # May need to handle segments !!!
        return PCS
    
    def getPDSByID(self, paletteID, strict=False):
        PDS = next((p for p in self.getType(SEGMENT_TYPE.PDS) if p.data.paletteID == paletteID), None)
        if strict and PDS is None and self.PCSegment.data.compositionState == COMPOSITION_STATE.NORMAL \
        and self.prev is not self:
            PDS = self.prev.getPDSByID(paletteID)
        return PDS

    @property
    def PDSegment(self):
        paletteID = self.PCSegment.data.paletteID
        return self.getPDSByID(paletteID)

    @property
    def selfPDSegment(self):
        paletteID = self.PCSegment.data.paletteID
        return self.getPDSByID(paletteID, True)
    
    def getODSByID(self, objectID, strict=False):
        ODS = next((o for o in self.getType(SEGMENT_TYPE.ODS) if o.data.objectID == objectID), None)
        if strict and ODS is None and self.PCSegment.data.compositionState == COMPOSITION_STATE.NORMAL \
        and self.prev is not self:
            ODS = self.prev.getODSByID(objectID, strict)
        return ODS

    def getRLDataByODS(self, ODS):
        RLData = ODS.data.RLDataFragment
        objectID = ODS.data.objectID
        prevSegment = ODS.prev
        nextSegment = ODS.next
        if prevSegment is not ODS:
            while prevSegment.type is SEGMENT_TYPE.ODS and prevSegment.data.objectID == objectID:
                RLData = prevSegment.data.RLDataFragment + RLData
                if prevSegment.prev is not prevSegment:
                    prevSegment = prevSegment.prev
                else:
                    break
        if nextSegment is not ODS:
            while nextSegment.type is SEGMENT_TYPE.ODS and nextSegment.data.objectID == objectID:
                RLData += nextSegment.data.RLDataFragment
                if nextSegment.next is not nextSegment:
                    nextSegment = nextSegment.next
                else:
                    break
        return RLData, prevSegment, nextSegment

    def getRLDataByID(self, objectID, strict=False):
        RLData = b''
        ODS = self.getODSByID(objectID, strict)
        if ODS is None:
            return None, None, None
        prevSegment = ODS.prev
        while ODS.type is SEGMENT_TYPE.ODS and ODS.data.objectID == objectID:
            RLData += ODS.data.RLDataFragment
            if ODS.next is not ODS:
                ODS = ODS.next
            else:
                break
        nextSegment = ODS
        return RLData, prevSegment, nextSegment
    
    def setRLDataByBoundary(self, RLData, prevSegment, nextSegment):
        pts = prevSegment.next.pts
        dts = prevSegment.next.dts
        objectID = prevSegment.next.data.objectID 
        dataLength = len(RLData)
        RLDataFragments = [RLData[:65528]]
        if dataLength > 65528:
            RLDataFragments.extend([RLData[i:i + 65531] for i in range(65528, dataLength, 65531)])
        for i, f in enumerate(RLDataFragments):
            segment = Segment()
            prevSegment.next = segment
            segment.prev = prevSegment
            segment.displaySet = self
            ODSData = ObjectDefinitionSegment(parent = segment)
            ODSData.objectID = objectID
            if i == 0:
                ODSData.first = True
                ODSData.remains = dataLength.to_bytes(3, byteorder = 'big') + f
            else:
                ODSData.remains = f
            segment.pts = pts
            segment.dts = dts
            segment.type = SEGMENT_TYPE.ODS
            segment.data = ODSData
            segment.size = len(segment.data.raw)
            prevSegment = segment
        ODSData.last = True
        segment.next = nextSegment
        nextSegment.prev = segment
        return prevSegment.next, segment

    @property
    def RLDataList(self):
        RLDataList = []
        for o in self.PCSegment.data.compositionObjects:
            objectID = o.objectID
            RLData, prevSegment, nextSegment = self.getRLDataByID(objectID)
            RLDataList.append({
                'id': objectID,
                'data': RLData,
                'prev': prevSegment,
                'next': nextSegment
            })
        return RLDataList

    def getPixByID(self, objectID):
        RLData, prevSegment, nextSegment = self.getRLDataByID(objectID)
        return RLDecode(RLData), prevSegment, nextSegment
    
    def getPixByODS(self, ODS):
        RLData, prevSegment, nextSegment = self.getRLDataByODS(ODS)
        return RLDecode(RLData), prevSegment, nextSegment

    def setPixByBoundary(self, pix, prevSegment, nextSegment):
        return self.setRLDataByBoundary(RLEncode(pix), prevSegment, nextSegment)

    @property
    def pixList(self):
        return [{
            'id': r['id'],
            'data': RLDecode(r['data']), 
            'prev': r['prev'], 
            'next': r['next']
        } for r in self.RLDataList]

    def getImageByID(self, objectID):
        pix, prevSegment, nextSegment = self.getPixByID(objectID)
        return makeImage(pix, self.RGBAPalette), prevSegment, nextSegment

    def getImageByODS(self, ODS):
        pix, prevSegment, nextSegment = self.getPixByODS(ODS)
        return makeImage(pix, self.RGBAPalette), prevSegment, nextSegment

    @property
    def imageList(self):
        return [{
            'id': p['id'],
            'data': makeImage(p['data'], self.RGBAPalette),
            'prev': p['prev'],
            'next': p['next']
        } for p in self.pixList]

    @property
    def RGBAPalette(self):
        return self.PDSegment.data.RGBAPalette

    @property
    def YCrCbAPalette(self):
        return self.PDSegment.data.YCrCbAPalette
    
    @property
    def screenImage(self):
        if self.PCSegment.data.numberOfCompositionObjects > 0:
            canvasHeight, canvasWidth = self.PCSegment.data.height, self.PCSegment.data.width
            background = Image.new('RGBA', (canvasWidth, canvasHeight), color = (255, 255, 255, 0))
            for obj in self.PCSegment.data.compositionObjects:
                pix, _, _ = self.getPixByID(obj.objectID)
                windowID = next(c.windowID for c in self.PCSegment.data.compositionObjects if c.objectID == obj.objectID)
                wobj = next(w for w in next(self.getType(SEGMENT_TYPE.WDS)).data.windowObjects if w.windowID == windowID)
                xPos, yPos, (height, width) = obj.xPos, obj.yPos, pix.shape
                windowXPos, windowYPos, windowWidth, windowHeight = wobj.xPos, wobj.yPos, wobj.width, wobj.height
                cropXPos, cropYPos, cropWidth, cropHeight = obj.cropXPos or 0, obj.cropYPos or 0, obj.cropWidth or width, obj.cropHeight or height
                xStart = max(cropXPos, 0)
                yStart = max(cropYPos, 0)
                xEnd = min(cropXPos + cropWidth, width)
                yEnd = min(cropYPos + cropHeight, height)
                croppedPix = pix[yStart:yEnd, xStart:xEnd]
                width = xEnd - xStart
                height = yEnd - yStart
                pasteXStart = max(windowXPos, xPos)
                pasteYStart = max(windowYPos, yPos)
                pasteXStop = min(windowXPos + windowWidth, xPos + width)
                pasteYStop = min(windowYPos + windowHeight, yPos + height)
                croppedPixNew = croppedPix[(pasteYStart - yPos):(pasteYStop - yPos), (pasteXStart - xPos):(pasteXStop - xPos)]
                background.paste(makeImage(croppedPixNew, self.RGBAPalette), box = (pasteXStart, pasteYStart)) 
            return background
        else:
            return None

    @property
    def pts(self):
        return self.PCSegment.pts
    @pts.setter
    def pts(self, value):
        for s in self.segments:
            s.pts = value
    
    @property
    def dts(self):
        return self.PCSegment.dts
    @dts.setter
    def dts(self, value):
        for s in self.segments:
            s.dts = value

    @property
    def ptsms(self):
        return self.PCSegment.ptsms
    @ptsms.setter
    def ptsms(self, value):
        for s in self.segments:
            s.ptsms = value
    
    @property
    def dtsms(self):
        return self.PCSegment.dtsms
    @dtsms.setter
    def dtsms(self, value):
        for s in self.segments:
            s.dtsms = value

    def getType(self, sType):
        return (s for s in self.segments if s.type == sType)

class Epoch:

    def __init__(self, startDisplaySet, stopDisplaySet):
        self.startDisplaySet = startDisplaySet
        self.stopDisplaySet = stopDisplaySet
        self.startDisplaySet.epoch = self.stopDisplaySet.epoch = self
    
    @property
    def raw(self):
        return b''.join(ds.raw for ds in self.displaySets)
    
    @property
    def displaySets(self):
        displaySet = self.startDisplaySet
        while displaySet is not self.stopDisplaySet:
            yield displaySet
            displaySet = displaySet.next
        yield displaySet
    
    @property
    def next(self):
        return self.stopDisplaySet.next.epoch
    
    @property
    def prev(self):
        return self.startDisplaySet.prev.epoch

    @property
    def segments(self):
        for ds in self.displaySets:
            yield from ds.segments

    def imageFilter(self, ft):

        def processImage(PDS, ODSList):
            imageList = []
            prevList = []
            nextList = []
            prevObjectID = -1
            for ODS in ODSList:
                currObjectID = ODS.data.objectID
                if currObjectID != prevObjectID:
                    pix, prevSegment, nextSegment = ODS.displaySet.getPixByODS(ODS)
                    imageList.append(makeImage(pix, PDS.data.RGBAPalette).filter(ft))
                    prevList.append(prevSegment)
                    nextList.append(nextSegment)
                prevObjectID = currObjectID
            pixList, PDS.data.RGBAPalette = splitImages(imageList)
            for ind, pix in enumerate(pixList):
                ODS = ODSList[ind]
                prevInds = [i for i, o in enumerate(prevList) if ODS is o]
                nextInds = [i for i, o in enumerate(nextList) if ODS is o]
                start, end = ODSList[ind].displaySet.setPixByBoundary(pix, prevList[ind], nextList[ind])
                for i in prevInds:
                    prevList[i] = end
                for i in nextInds:
                    nextList[i] = start
        
        def transformPDS(PDS):
            # Transform PDS (Interpolant)
            pass

        ODSList = []
        PDS = None
        for s in self.segments:
            if s.type is SEGMENT_TYPE.PDS:
                if PDS:
                    if len(ODSList) > 0:
                        processImage(PDS, ODSList)
                        PDS = None
                        ODSList = []
                    else:
                        transformPDS(PDS)
                        PDS = None
                PDS = s
            elif s.type is SEGMENT_TYPE.ODS:
                ODSList.append(s)
        if PDS:
            if len(ODSList) > 0:
                processImage(PDS, ODSList)
            else:
                transformPDS(PDS)

class SubPicture:

    def __init__(self, startDisplaySet, stopDisplaySet):
        self.startDisplaySet = startDisplaySet
        self.stopDisplaySet = stopDisplaySet
        self.startDisplaySet.subPicture = self.stopDisplaySet.subPicture = self

    @property
    def raw(self):
        return b''.join(ds.raw for ds in self.displaySets)
 
    @property
    def displaySets(self):
        displaySet = self.startDisplaySet
        while displaySet is not self.stopDisplaySet:
            yield displaySet
            displaySet = displaySet.next
        yield displaySet

    @property
    def next(self):
        return self.stopDisplaySet.next.subPicture
    
    @property
    def prev(self):
        return self.startDisplaySet.prev.subPicture

    @property
    def segments(self):
        for ds in self.displaySets:
            yield from ds.segments

    @property
    def startTime(self):
        return self.startDisplaySet.pts
    @startTime.setter
    def startTime(self, value):
        self.startDisplaySet.pts = value
        self.startDisplaySet.dts = 0

    @property
    def startTimems(self):
        return self.startDisplaySet.ptsms
    @startTimems.setter
    def startTimems(self, value):
        self.startDisplaySet.ptsms = value
        self.startDisplaySet.dts = 0

    @property
    def startTimehmsx(self):
        return ms2hmsx(self.startTimems)
    @startTimehmsx.setter
    def startTimehmsx(self, value):
        self.startTimems = hmsx2ms(*value)
    
    @property
    def startTimeStr(self):
        return ms2Str(self.startTimems)
    @startTimeStr.setter
    def startTimeStr(self, value):
        self.startTimems = str2ms(value)

    @property
    def endTime(self):
        return self.startDisplaySet.next.pts
    @endTime.setter
    def endTime(self, value):
        self.startDisplaySet.next.pts = value
        self.startDisplaySet.next.dts = 0

    @property
    def endTimems(self):
        return self.startDisplaySet.next.ptsms
    @endTimems.setter
    def endTimems(self, value):
        self.startDisplaySet.next.ptsms = value
        self.startDisplaySet.next.dts = 0

    @property
    def endTimehmsx(self):
        return ms2hmsx(self.endTimems)
    @endTimehmsx.setter
    def endTimehmsx(self, value):
        self.endTimems = hmsx2ms(*value)
    
    @property
    def endTimeStr(self):
        return ms2Str(self.endTimems)
    @endTimeStr.setter
    def endTimeStr(self, value):
        self.endTimems = str2ms(value)

    @property
    def duration(self):
        return self.endTime - self.startTime
    @duration.setter
    def duration(self, value):
        self.endTime = self.startTime + value

    @property
    def durationms(self):
        return self.endTimems - self.startTimems
    @durationms.setter
    def durationms(self, value):
        self.endTimems = self.startTimems + value
  
    @property
    def durationhmsx(self):
        return ms2hmsx(self.durationms)
    @durationhmsx.setter
    def durationhmsx(self, value):
        self.durationms = hmsx2ms(*value)

    @property
    def durationStr(self):
        return ms2Str(self.durationms)
    @durationStr.setter
    def durationStr(self, value):
        self.durationms = str2ms(value)

    @property
    def maxAlpha(self):
        return max(self.startDisplaySet.YCrCbAPalette[:, -1])

    @property
    def imageList(self):
        return self.startDisplaySet.imageList

    @property
    def screenImage(self):
        return self.startDisplaySet.screenImage
