import io, os, itertools
import numpy as np
from enum import Enum
from PIL import Image
from bufferedrandomplus import BufferedRandomPlus

class InvalidSegmentError(Exception):
    pass

class SEGMENT_TYPE(Enum):

    PDS = b'\x14'
    ODS = b'\x15'
    PCS = b'\x16'
    WDS = b'\x17'
    END = b'\x80'

class COMPOSITION_STATE(Enum):

    NORMAL = b'\x00'
    ACQUISITION_POINT = b'\x40'
    EPOCH_START = b'\x80'
    EPOCH_CONTINUE = b'\xC0'
    
class SEQUENCE(Enum):

    FIRST = b'\x40'
    LAST = b'\x80'
    FIRST_LAST = b'\xC0'

class BDSupReader:
    
    def __init__(self, filePath, bufferSize=1024*1024, verbose=False):
        self.filePath = filePath
        self.bufferSize = bufferSize
        self.verbose = verbose
        self._segments = None

    def iterSegments(self):
        if self._segments is None:
            segments = []
            with open(self.filePath, 'r+b', buffering = self.bufferSize) as _:
                if not hasattr(self, '_size'):
                    self._size = os.fstat(_.fileno()).st_size
                self._stream = BufferedRandomPlus(_)
                stream = self._stream
                while stream.offset < self._size:
                    segment = Segment(stream)
                    segments.append(segment)
                    yield segment
            self._segments = segments
        else:
            for segment in self._segments:
                yield segment

    def iterDisplaySets(self):
        ds = []
        dsObj = None
        prevDsObj = None
        for segment in self.iterSegments():
            ds.append(segment)
            if segment.type == SEGMENT_TYPE.END:
                prevDsObj = dsObj
                dsObj = DisplaySet(ds)
                dsObj.prev = prevDsObj
                if prevDsObj is not None:
                    prevDsObj.next = dsObj
                yield dsObj
                ds = []
        if ds:
            print('Warning: [Read Stream] The last display set lacks END segment')
            prevDsObj = dsObj
            dsObj = DisplaySet(ds)
            dsObj.prev = prevDsObj
            if prevDsObj is not None:
                prevDsObj.next = dsObj
            yield dsObj

    def iterEpochs(self):
        ep = []
        for displaySet in self.iterDisplaySets():
            if ep and displaySet.pcsSegment.data.compositionState == COMPOSITION_STATE.EPOCH_START:
                yield Epoch(ep)
                ep = []
            ep.append(displaySet)
        yield Epoch(ep)

    def iterSubPictures(self):
        subPicture = None
        for displaySet in self.iterDisplaySets():
            if displaySet.pcsSegment.data.numberOfCompositionObjects > 0:
                if subPicture is not None:
                    yield subPicture
                subPicture = SubPicture(displaySet)
            else:
                if subPicture is not None:
                    yield subPicture
                    subPicture = None
        if subPicture:
            print('Warning: [Read Stream] The last sub picture lacks end time')
            yield subPicture

    @property
    def segments(self):
        if self._segments is None:
            return list(self.iterSegments())
        return self._segments

    @property
    def displaySets(self):
        return list(self.iterDisplaySets())

    @property
    def epochs(self):
        return list(self.iterEpochs())

    @property
    def subPictures(self):
        return list(self.iterSubPictures())
    
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
            print('Warning: [PCS] Number of composition objects asserted ({:d}) '
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
            print('Warning: [WDS] Number of windows asserted ({:d}) '
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

    xForm = np.array([[255/219, 255/224*1.402, 0],
        [255/219, -255/224*1.402*0.299/0.587, -255/224*1.772*0.114/0.587], 
        [255/219, 0, 255/224*1.772]], dtype = np.float)
    
    def __init__(self, stream, parent):
        self._parent = parent
        self.paletteID = stream.readUChar()
        self.version = stream.readUChar()
        self.paletteTable = np.asarray(list(stream.readBytes(len(self.parent) - 2)), dtype = np.uint8).reshape((-1, 5))

    @property
    def palette(self):
        # (Y, Cr, Cb) = (235, 128, 128) is white
        p = np.array([[235, 128, 128, 0]], dtype = np.uint8).repeat(256, axis = 0)
        for row in self.paletteTable:
            p[row[0]] = row[1:]
        return p
    @palette.setter
    def palette(self, value):
        for entry, p in enumerate(value):
            rowIndices = np.where(self.paletteTable[:, 0] == entry)
            count = len(rowIndices[0])
            if count:
                self.paletteTable[rowIndices, 1:] = p
            else:
                self.paletteTable = np.vstack((self.paletteTable, [entry, *p]))

    def YCrCb2RGB(self, YCrCb):
        RGB = np.asarray(YCrCb, dtype = np.float)
        RGB -= [16, 128, 128]
        RGB = RGB.dot(self.xForm.T)
        np.putmask(RGB, RGB > 255, 255)
        np.putmask(RGB, RGB < 0, 0)
        return np.uint8(RGB)
    
    def RGB2YCrCb(self, RGB):
        YCrCb = np.asarray(RGB, dtype = np.float)
        YCrCb = np.linalg.solve(self.xForm.T, YCrCb)
        YCrCb += [16, 128, 128]
        np.putmask(YCrCb, YCrCb < 16, 16)
        np.putmask(YCrCb[:, 0], YCrCb[:, 0] > 235, 235)
        np.putmask(YCrCb[:, 1:3], YCrCb[:, 1:3] > 240, 240)
        return np.uint8(YCrCb)

    @property
    def raw(self):
        result = bytes([self.paletteID, self.version]) + \
                self.paletteTable.tobytes()
        return result
    
    @property
    def YCrCb(self):
        return self.palette[:, 0:3]
    @YCrCb.setter
    def YCrCb(self, value):
        for entry, c in enumerate(value):
            rowIndices = np.where(self.paletteTable[:, 0] == entry)
            count = len(rowIndices[0])
            if count:
                self.paletteTable[rowIndices, 1:4] = c
            else:
                self.paletteTable = np.vstack((self.paletteTable, [entry, *c, 0]))

    @property
    def alpha(self):
        return self.palette[:, 3]
    @alpha.setter
    def alpha(self, value):
        for entry, a in enumerate(value):
            rowIndices = np.where(self.paletteTable[:, 0] == entry)
            count = len(rowIndices[0])
            if count:
                self.paletteTable[rowIndices, 4] = a
            else:
                self.paletteTable = np.vstack((self.paletteTable, [entry, 235, 128, 128, a]))

    @property
    def RGB(self):
        return self.YCrCb2RGB(self.YCrCb)
    @RGB.setter
    def RGB(self, value):
        self.YCrCb = self.RGB2YCrCb(value)

    @property
    def parent(self):
        return self._parent

class ObjectDefinitionSegment:

    def __init__(self, stream, parent):
        self._parent = parent
        self.objectID = stream.readUShort()
        self.version = stream.readUChar()
        self.sequence = stream.readByte()
        
        # First Fragment: has data Length, width and height fields
        if self.first:
            self.dataLength = int.from_bytes(stream.readBytes(3), byteorder = 'big')
            self.width = stream.readUShort()
            self.height = stream.readUShort()
            # Data length includes width and height (2 bytes each, 4 bytes total)
            dataLength = len(self.parent) - 7
            self.imgData = stream.readBytes(dataLength - 4)
        # Consequent Fragments: no data Length, width or height field
        else:
            # Data Length uses 3 bytes, so we need to minus 4 not 7
            dataLength = len(self.parent) - 4
            self.dataLength = dataLength
            # No width or height, so we don't need to minus 4
            self.width = None
            self.height = None
            self.imgData = stream.readBytes(dataLength)
        
        # Single Fragment Correction
        if self.first and self.last and dataLength != self.dataLength:
            print('Warning: [ODS] Length of image data asserted ({:d}) '
                    'does not match the amount found ({:d}). '
                    'The attribute will be reassigned'
                    .format(self.dataLength, dataLength))
            self.dataLength = dataLength
    
    @property
    def raw(self):
        result = self.objectID.to_bytes(2, byteorder = 'big') + \
                bytes([self.version]) + \
                self.sequence
        if self.first:
            result += self.dataLength.to_bytes(3, byteorder = 'big') + \
                    self.width.to_bytes(2, byteorder = 'big') + \
                    self.height.to_bytes(2, byteorder = 'big')
        result += self.imgData
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

    def __init__(self, stream):
        if stream.readWord() != b'PG':
            raise InvalidSegmentError
        self._pts = stream.readUInt()
        self._dts = stream.readUInt()
        self.type = SEGMENT_TYPE(stream.readByte())
        self.size = stream.readUShort()
        self.data = self.OPTION[self.type](stream, self)

    def __len__(self):
        return self.size

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
            print('Warning: [Set PTS] Time is larger than 4 bytes, 2^32 - 1 is used')
            value = 4294967295
        elif value < 0:
            print('Warning: [Set PTS] Time cannot be negative, 0 is used')
            value = 0
        self._pts = value
    
    @property
    def dts(self):
        return self._dts
    @pts.setter
    def dts(self, value):
        if value > 4294967295:
            print('Warning: [Set DTS] Time is larger than 4 bytes, 2^32 - 1 is used')
            value = 4294967295
        elif value < 0:
            print('Warning: [Set DTS] Time cannot be negative, 0 is used')
            value = 0
        self._dts = value

    @property
    def ptsms(self):
        return self.pts / 90
    @ptsms.setter
    def ptsms(self, value):
        self.pts = round(value * 90)

    @property
    def dtsms(self):
        return self.dts / 90
    @dtsms.setter
    def dtsms(self, value):
        self.dts = round(value * 90)

class DisplaySet:

    def __init__(self, segments):
        self.segments = segments
        self.prev = self
        self.next = self

    @property
    def raw(self):
        return b''.join(s.raw for s in self.segments)

    @property
    def pcsSegment(self):
        if not hasattr(self, '_pcsSegment'):
            pcs = next((s for s in self.getType(SEGMENT_TYPE.PCS)), None)
            self._pcsSegment = pcs
            if pcs is not self.segments[0]:
                print('Warning: [Display Set] PCS is not the first segment')
        return self._pcsSegment

    @property
    def RLE(self):
        if not hasattr(self, '_RLE'):
            RLE = []
            seed = b''
            prevID = -1
            for ods in self.getType(SEGMENT_TYPE.ODS):
                data = ods.data
                currID = data.objectID
                # Different object ID, so there're two different objects
                if currID != prevID and prevID != -1:
                    RLE.append({'id': prevID, 'data': seed})
                    seed = b''
                # Same object ID, so we have to combine the image data together
                prevID = currID
                seed += data.imgData
            # One display set may have more than one objects, they have different object IDs
            # The number of objects is also indicated at PCS segment's number of composition objects field
            if prevID != -1:
                RLE.append({'id': prevID, 'data': seed})
            
            if self.pcsSegment.data.compositionState == COMPOSITION_STATE.NORMAL and self.prev is not self:
                prevRLE = self.prev.RLE
                ids = [r['id'] for r in RLE]
                RLE.extend(r for r in prevRLE if r['id'] not in ids)
            
            self._RLE = sorted(RLE, key = lambda k: k['id'])

        return self._RLE

    @property
    def pix(self):
        if not hasattr(self, '_pix'):
            self._pix = [{'id': RLE['id'], 'data': RLEDecode(RLE['data'])} for RLE in self.RLE]
        return self._pix
    
    @property
    def image(self):
        if not hasattr(self, '_image'):
            self._image = [{'id': pix['id'], 'data': self.makeImage(pix['data'])} for pix in self.pix]
        return self._image

    @property
    def pds(self):
        if not hasattr(self, '_pds'):
            self._pds = next((p.data for p in self.getType(SEGMENT_TYPE.PDS)
                if p.data.paletteID == self.getType(SEGMENT_TYPE.PCS)[0].data.paletteID), None)
            if self._pds is None and self.pcsSegment.data.compositionState == COMPOSITION_STATE.NORMAL and self.prev is not self:
                self._pds = self.prev.pds
        return self._pds
    
    @property
    def RGB(self):
        if not hasattr(self, '_RGB'):
            self._RGB = self.pds.RGB
        return self._RGB
    
    @property
    def alpha(self):
        if not hasattr(self, '_alpha'):
            self._alpha = self.pds.alpha
        return self._alpha
    
    @property
    def screenImage(self):
        if not hasattr(self, '_screenImage'):
            if self.pcsSegment.data.numberOfCompositionObjects > 0:
                transparentEntryPoint = next(i for i, a in enumerate(self.alpha) if a == 0)
                background = np.full((self.pcsSegment.data.height, self.pcsSegment.data.width), transparentEntryPoint, dtype = np.uint8)
                for obj in self.pcsSegment.data.compositionObjects:
                    pix = next(p['data'] for p in self.pix if p['id'] == obj.objectID)
                    windowID = next(c.windowID for c in self.pcsSegment.data.compositionObjects if c.objectID == obj.objectID)
                    wobj = next(w for w in self.getType(SEGMENT_TYPE.WDS)[0].data.windowObjects if w.windowID == windowID)
                    xPos, yPos, (height, width) = obj.xPos, obj.yPos, pix.shape
                    windowXPos, windowYPos, windowWidth, windowHeight = wobj.xPos, wobj.yPos, wobj.width, wobj.height
                    cropXPos, cropYPos, cropWidth, cropHeight = obj.cropXPos or 0, obj.cropYPos or 0, obj.cropWidth or width, obj.cropHeight or height

                    xStart = max(cropXPos, 0)
                    yStart = max(cropYPos, 0)
                    xEnd = min(cropXPos + cropWidth, width)
                    yEnd = min(cropYPos + cropHeight, height)
                    height = yEnd - yStart
                    width = xEnd - xStart
                    croppedPix = pix[yStart:yEnd, xStart:xEnd]
                    background[yPos:(yPos + height), xPos:(xPos + width)] = croppedPix
                    background[yPos:windowYPos, xPos:windowXPos] = transparentEntryPoint
                    background[(windowYPos + windowHeight):(yPos + height), (windowXPos + windowWidth):(xPos + width)] = transparentEntryPoint
                self._screenImage = self.makeImage(background)
            else:
                self._screenImage = None
        return self._screenImage

    def makeImage(self, pixelLayer):
        alphaLayer = self.alpha[pixelLayer]
        RGBPalette = self.RGB
        alphaImage = Image.fromarray(alphaLayer, mode='L')
        pixelImage = Image.fromarray(pixelLayer, mode='P')
        pixelImage.putpalette(RGBPalette)
        RGBAImage = pixelImage.convert('RGB')
        RGBAImage.putalpha(alphaImage)
        return RGBAImage

    def hasType(self, sType):
        return sType in self.segmentTypes
    
    def getType(self, sType):
        return [s for s in self.segments if s.type == sType]

class Epoch:

    def __init__(self, displaySets):
        self.displaySets = displaySets
    
    @property
    def raw(self):
        return b''.join(ds.raw for ds in self.displaySets)

    @property
    def segments(self):
        if not hasattr(self, '_segments'):
            self._segments = list(itertools.chain(*[ds.segments for ds in self.displaySets]))
        return self._segments

class SubPicture:

    def __init__(self, displaySet):
        self.displaySet = displaySet

    @property
    def raw(self):
        return self.displaySet.raw

    @property
    def segments(self):
        if not hasattr(self, '_segments'):
            self._segments = self.displaySet.segments
        return self._segments

    @property
    def startTime(self):
        return self.displaySet.pcsSegment.pts
    @startTime.setter
    def startTime(self, value):
        for s in self.displaySet.segments:
            s.pts = value
            s.dts = 0

    @property
    def startTimems(self):
        return self.displaySet.pcsSegment.ptsms
    @startTimems.setter
    def startTimems(self, value):
        for s in self.displaySet.segments:
            s.ptsms = value
            s.dts = 0

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
        return self.displaySet.next.pcsSegment.pts
    @endTime.setter
    def endTime(self, value):
        for s in self.displaySet.next.segments:
            s.pts = value
            s.dts = 0

    @property
    def endTimems(self):
        return self.displaySet.next.pcsSegment.ptsms
    @endTimems.setter
    def endTimems(self, value):
        for s in self.displaySet.next.segments:
            s.ptsms = value
            s.dts = 0

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
        return max(self.displaySet.alpha)

    @property
    def image(self):
        return self.displaySet.image

    @property
    def screenImage(self):
        return self.displaySet.screenImage

def ms2Str(ms):
    return hmsx2Str(*ms2hmsxInt(ms))

def str2ms(string):
    return hmsx2ms(*str2hmsx(string))

def hmsx2Str(h, m, s, x):
    return '{:02.0f}:{:02.0f}:{:02.0f}.{:03.0f}'.format(h, m, s, x)

def str2hmsx(string):
    return tuple(float(n) for n in string.replace(',', ':').replace('.', ':').split(':'))

def ms2hmsx(ms):
    x = ms % 1000
    s = (ms // 1000) % 60
    m = (ms // 60000) % 60
    h = ms // 3600000
    return h, m ,s, x

def hmsx2ms(h, m, s, x):
    return x + s * 1000 + m * 60 * 1000 + h * 3600 * 1000

def ms2hmsxInt(ms):
    return ms2hmsx(round(ms))

def RLEDecode(RLEData):
    lineBuilder = []
    pixels = []
    offset = 0
    length = len(RLEData)

    while offset < length:
        first = RLEData[offset]
        if first:
            entry = first
            repeat = 1
            skip = 1
        else:
            second = RLEData[offset + 1]
            if second == 0:
                entry = 0
                repeat = 0
                pixels.append(lineBuilder)
                lineBuilder = []
                skip = 2
            elif second < 64:
                entry = 0
                repeat = second
                skip = 2
            elif second < 128:
                entry = 0
                repeat = ((second - 64) << 8) + RLEData[offset + 2]
                skip = 3
            elif second < 192:
                entry = RLEData[offset + 2]
                repeat = second - 128
                skip = 3
            else:
                entry = RLEData[offset + 3]
                repeat = ((second - 192) << 8) + RLEData[offset + 2]
                skip = 4
        lineBuilder.extend([entry] * repeat)
        offset += skip

    if lineBuilder:
        print(f'Warning: [RLE] Hanging pixels without line ending: {lineBuilder}')

    return np.asarray(pixels, dtype = np.uint8)
