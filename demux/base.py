import os
import re
import orjson


from num2words import num2words

import tools.general as utils
import tools.paths as paths
import mediatools.bdinfo as bdinfo
import config as config
import sites.pickers.siteDataPicker as siteDataPicker
import mediatools.eac3to as eac3to
import mediatools.dgdemux as dgdemux
import tools.paths as paths
import sites.pickers.siteSortPicker as siteSortPicker
import subtitles.subreader as subreader
import transcription.voiceRecord as voiceRec
import tools.directory as dir
import tools.logger as logger


class Demux():
    def __init__( self,args):
        self._args=args
        self.demuxFolder=None
        self._name=None
        self._type=None
        self.movieObj=None
        self._index=0
        self._success=False
    def __call__(self):
        logger.setUpLogging(self._args.loglevel)
        self._callFunction()
        self._success=True
     

    def _callFunction(self):
        None


    @property
    def success(self):
        return self._success
    
    def demuxPlaylist(self,bdObjs,multiSelect=False):
        #setup bdobj
        for bdObj in bdObjs:
            if multiSelect==True:
                bdObj.playListRangeSelect()
            else:
                bdObj.playListSelect()
        bdObjs[0].validate(bdObjs) 
        for i in range(len(bdObjs[0].keys)):
            self._index=i
            trackerObjs=[]
            newFolder=self._getNewFolder(len(os.listdir(self.demuxFolder)))
            with dir.cwd(newFolder):
                for bdObj in bdObjs:
                    bdObj.generateData(i)
                    demuxData=siteDataPicker.pickSite(self._args.site)
                    currentTracks=demuxData.addTracks(bdObj,bdObj.keys[i])
                    demuxData.addOutput(newFolder)
                    trackerObjs.append(demuxData)
                    with dir.cwd(demuxData["outputDir"]):
                        if self._args.extractprogram=="eac3to":
                            eac3to.process(currentTracks,demuxData["sourceDir"],demuxData["playlistFile"])
                        else:
                            dgdemux.run(currentTracks,demuxData["sourceDir"],demuxData["playlistFile"])
                        bdObj.writeBDInfo(0)

                        muxSorter=self._getMuxSorter(trackerObjs)
                        self._subParse(muxSorter)
                        self._voiceRec(muxSorter)
                        self._saveOutput(trackerObjs,muxSorter)
        

            
          
            
                    

    def _saveOutput(self,trackerObjs,muxSorter):
        outdict = {}
        outdict.update(self._addSourceData(trackerObjs)) 
        outdict.update(self._ConvertChapterList(self._getChapterMedia(trackerObjs))) 
        outdict["Movie"] = self._movieObj.movieObj
        outdict.update(self._addEnabledData(muxSorter))
        outdict.update(self._addTrackData(muxSorter))
        self._writeFinalJSON(outdict)

    def _saveOutputStream(self,bdObjs,trackerObjs,muxSorter):
        outdict = {}
        outdict.update(self._addSourceData(trackerObjs)) 
        outdict.update(self._ConvertChapterList(self._getChapterMedia(bdObjs))) 
        outdict["Movie"] = self._movieObj.movieObj
        outdict.update(self._addEnabledData(muxSorter))
        outdict.update(self._addTrackData(muxSorter))
        self._writeFinalJSON(outdict)
    
    



    
    

    #################
    # Helper Functions
    ############
    def _getNewFolder(self,i=None):
        return os.path.join(self.demuxFolder,str(i+1))
 



    def _addTrackData(self,muxSorter):
        outdict={}
        outdict["Tracks_Details"] = {}
        outdict["Tracks_Details"]["Audio"] = {}
        outdict["Tracks_Details"]["Sub"] = {}
        outdict["Tracks_Details"]["Video"] = {}

        for track in muxSorter.unSortedAudio:
            key = track["key"]
            track.pop("key")
            outdict["Tracks_Details"]["Audio"][key] = track
        for track in muxSorter.unSortedSub:
            key = track["key"]
            track.pop("key")
            outdict["Tracks_Details"]["Sub"][key] = track

        for track in muxSorter.unSortedVideo:
            key = track["key"]
            track.pop("key")
            outdict["Tracks_Details"]["Video"][key] = track

        return outdict
    def _writeFinalJSON(self,outdict):
        outputPath = os.path.abspath(os.path.join(".", "output.json"))
        logger.logger.info(f"Writing to {outputPath}")
        with open(outputPath, "wb") as p:
            data=orjson.dumps(outdict, option=orjson.OPT_INDENT_2)
            p.write(data)

   
    def _getChapterMedia(self,trackerObjs):
        match = trackerObjs[0]["sourceDir"]
        if len(trackerObjs) > 1:
            match = utils.singleSelectMenu(
                list(map(lambda x: x["sourceDir"], trackerObjs)), "Which Source Has The proper Chapter File")
        return list(filter(lambda x: x["sourceDir"] == match, trackerObjs))[0]["chapters"]
        

    def _subParse(self,muxSorter):
        # Add OCR for Subtitles

        if self._args.ocr == "enabled":
            subreader.subreader(muxSorter.enabledSub, keep=self._args.keepocr)
        elif self._args.ocr == "default":
            subreader.subreader(muxSorter.unSortedSub,
                                langs=self._movieObj.get("languages",[ ]), keep=self._args.keepocr)
        elif self._args.ocr == "sublang":
            subreader.subreader(muxSorter.unSortedSub,
                                langs=self._args.sublang, keep=self._args.keepocr)
        elif self._args.ocr == "english":
            subreader.subreader(muxSorter.unSortedSub, langs=[
                                "English"], keep=self._args.keepocr)
        elif self._args.ocr == "all":
            subreader.subreader(muxSorter.unSortedSub, keep=self._args.keepocr)
        elif self._args.keepocr:
            subreader.imagesOnly(muxSorter.enabledSub)

    # Voice Recorder
    def _voiceRec(self,muxSorter):
        if self._args.voicerec == "enabled":
            voiceRec.main(muxSorter.enabledAudio)
        elif self._args.voicerec == "default":
            voiceRec.main(muxSorter.unSortedAudio, self._movieObj.movieObj.get("languages", []))
        elif self._args.voicerec == "audiolang":
            voiceRec.main(muxSorter.unSortedAudio, self._args.audiola0ng)
        elif self._args.voicerec == "english":
            voiceRec.main(muxSorter.unSortedAudio, ["English"])
        elif self._args.voicerec == "all":
            voiceRec.main(muxSorter.unSortedAudio)   
    def _getMuxSorter(self,trackerObjs):
        muxSorter = siteSortPicker.pickSite(self._args.site)
        for trackerObJ in trackerObjs:    
            muxSorter.addTracks(trackerObJ["tracks"])
        languages=self._movieObj.movieObj.get("languages", [])
        muxSorter.sortTracks(languages,
                            self._args.audiolang, self._args.sublang, self._args.sortpref)
        muxSorter.addForcedSubs(languages, self._args.audiolang)
        return muxSorter
   
    def _addSourceData(self,trackerObjs):
        outdict = {}
        outdict["Sources"]={}
        for trackerObj in trackerObjs:
            key=utils.sourcetoShowName(trackerObj["sourceDir"])
            outdict["Sources"][key] = {}
            outdict["Sources"][key]["outputDir"] = trackerObj["outputDir"]
            outdict["Sources"][key]["sourceDir"] = trackerObj["sourceDir"]
            outdict["Sources"][key]["playlistNum"] = trackerObj["playlistNum"]
            outdict["Sources"][key]["playlistFile"] = trackerObj["playlistFile"]
            outdict["Sources"][key]["streamFiles"] = trackerObj["streamFiles"]
            outdict["Sources"][key]["length"] = trackerObj["length"]

        return outdict

    def _addEnabledData(self,muxSorter):
        outdict={}
        # Enabled Track Section
        outdict["Enabled_Tracks"] = {}
        outdict["Enabled_Tracks"]["Video"] = list(
            map(lambda x: x["key"], muxSorter.enabledVideo))
        outdict["Enabled_Tracks"]["Audio"] = list(
            map(lambda x: x["key"], muxSorter.enabledAudio))
        outdict["Enabled_Tracks"]["Sub"] = list(
            map(lambda x: x["key"], muxSorter.enabledSub))   
        return outdict 
    def _ConvertChapterList(self,chapters):
        output = []
        if len(chapters) == 0:
            return output
        for chapter in chapters:
            nameString = f"CHAPTER{chapter['number']:02d}NAME=Chapter {chapter['number']:02d}"
            timeString = f"CHAPTER{chapter['number']:02d}={chapter['start']}"
            output.append({"time": timeString, "name": nameString})
        return output    
    def _setBdInfoData(self):
        bdObjs = []
        for source in self.sources:
            logger.logger.info(f"\n{source}\n")
            logger.logger.info(f"Setting BDINFO Object for {source}...\n")
            bdObj = bdinfo.Bdinfo()
            bdObj.setup(source)
            bdObjs.append(bdObj)
        return bdObjs

    def _fixArgs(self):
        logger.print("Normalize audiolang and sublang args")
        self._args.audiolang = list(map(lambda x: x.lower(),  self._args.audiolang))
        self._args.sublang = list(map(lambda x: x.lower(),  self._args.sublang))
        if self._args.extractprogram=="dgdemux":
            logger.print("dgdemux does not support track converting\nSetting dontconvert arg to True\n")
            self._args.dontconvert=True
        logger.logger.debug(str(self._args))
    ##Folder Stuff
    def _getBDMVs(self,path):
        with dir.cwd(path):
            list1 = paths.search(path, "/STREAM",dir=True,ignore=["BACKUP"])
            list2 = paths.search(path, "\.iso$")
            list1.extend(list2)
            list1 = list(map(lambda x: paths.convertPathType(x, "Linux"), list1))
            return sorted(list1)

    def _createParentDemuxFolder(self,sources, outpath):
        title = utils.getTitle(sources[0])
        folder = f"{config.demuxPrefix}.{utils.getFormated('YY.MM.DD_HH:mm.ss')}.{title}"
        parentDemux = os.path.join(outpath, folder)
        parentDemux = re.sub(" +", " ", parentDemux)
        parentDemux = re.sub(" ", ".", parentDemux)
        parentDemux = paths.convertPathType(parentDemux, "Linux")
        logger.logger.info(f"Creating a new Parent Directory for {self._name} ->{parentDemux}")
        os.mkdir(parentDemux)
        return parentDemux

    def _createChildDemuxFolder(self,parentDir, show):
        with dir.cwd(parentDir):
            show = utils.sourcetoShowName(show)
            os.mkdir(show)
            return paths.convertPathType(os.path.join(parentDir, show), "Linux")




    
