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
        self._callFunction()
        self._success=True
     

    def _callFunction(self):
        None


    @property
    def success(self):
        return self._success
    
    def demuxPlaylist(self,bdObjs):
        #setup bdobj
        for bdObJ in bdObjs:
            bdObJ.playListRangeSelect()
        bdObjs[0].validate(bdObjs)
        #process bdobj       
        for i in range(len(bdObjs[0].keys)):
            self._index=i
            trackerObjs=[]
            newFolder=os.path.join(self.demuxFolder,str(i+1))
            with dir.cwd(newFolder):
                for bdObj in bdObjs:
                    bdObj.generateData(i)
                    os.path.join(bdObj.playlistDir,bdObj.DictList[i]["playlistFile"])
                    demuxData=siteDataPicker.pickSite(self._args.site)
                    currentTracks=demuxData.addTracks(bdObj,bdObj.keys[i],newFolder)
                    trackerObjs.append(demuxData)
                    if self._args.extractprogram=="eac3to":
                        eac3to.process(currentTracks,demuxData["outputDir"],demuxData["sourceDir"],demuxData["playlistFile"])
                    else:
                        None
                muxSorter=self._getMuxSorter(trackerObjs)
                self._subParse(muxSorter)
                self._voiceRec(muxSorter)
                self._saveOutput(bdObjs,trackerObjs,muxSorter)
        

            
          
            
                    
            #safe outputlogs

    def _saveOutput(self,bdObjs,trackerObjs,muxSorter):
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
        print(f"Writing to {outputPath}")
        with open(outputPath, "wb") as p:
            data=orjson.dumps(outdict, option=orjson.OPT_INDENT_2)
            p.write(data)

   
    def _getChapterMedia(self,bdObjs):
        match = bdObjs[0].mediaDir
        if len(bdObjs) > 1:
            match = utils.singleSelectMenu(
                list(map(lambda x: x.mediaDir, bdObjs)), "Which Source Has The proper Chapter File")
        return list(filter(lambda x: x.mediaDir == match, bdObjs))[0].DictList[self._index]["chapters"]
        

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
   
    def _addSourceData(self,trackObjs):
        outdict = {}
        outdict["Sources"]={}
        for trackerObj in trackObjs:
            key=trackerObj.showname
        

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
        numoffset = int(chapters[0]["number"])-1
        timeoffset = utils.convertArrow(chapters[0]["start"], "HH:mm:ss.SSS")
        for i in range(len(chapters)):
            chapter = chapters[i]
            timeVar = chapter["start"]
            timeVar = utils.convertArrow(timeVar, "HH:mm:ss.SSS")
            timeVar = utils.subArrowTime(timeVar, timeoffset)
            timeVar = timeVar.format("HH:mm:ss.SSS")
            numVar = int(chapter["number"])-numoffset
            nameString = f"CHAPTER{numVar:02d}NAME=Chapter {numVar:02d}"
            timeString = f"CHAPTER{numVar:02d}={timeVar}"
            output.append({"time": timeString, "name": nameString})
        return output    
    def _setBdInfoData(self):
        bdObjs = []
        for source in self.sources:
            print(f"\n{source}\n")
            print(f"Setting BDINFO Object for {source}...\n")
            bdObj = bdinfo.Bdinfo()
            bdObj.setup(source)
            bdObjs.append(bdObj)
        return bdObjs

    def _fixArgs(self):
        self._args.audiolang = list(map(lambda x: x.lower(),  self._args.audiolang))
        self._args.sublang = list(map(lambda x: x.lower(),  self._args.sublang))
    
    ##Folder Stuff
    def _getBDMVs(self,path):
        with dir.cwd(path):
            list1 = paths.search(path, "STREAM",dir=True)
            list2 = paths.search(path, ".iso")
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
        print(f"Creating a new Parent Directory for {self._name} ->{parentDemux}")
        os.mkdir(parentDemux)
        return parentDemux

    def _createChildDemuxFolder(self,parentDir, show):
        with dir.cwd(parentDir):
            show = utils.sourcetoShowName(show)
            os.mkdir(show)
            return paths.convertPathType(os.path.join(parentDir, show), "Linux")
        






# def batchStreams(bdObj, source, args, demuxFolder, movieObj, season):
#     # outter loop through every playlist
#     for i in range(len(bdObj.playlistNumList)):
#         playlistNum = bdObj.playlistNumList[i]
#         playlistFile = bdObj.playlistFileList[i]

#         print(
#             f"Processing all streams from playlist number {num2words(playlistNum)}\n")

#         # get quick summary and bdinfo data
#         bdObj.runbdinfo(playlistNum)
#         quickSums = bdObj.setQuickSum()

#         # what should we offset the time by based on previous streams lengths
#         # create a episode folder
#         offset = len(os.listdir(demuxFolder))
#         ep = offset+1
#         for j in range(len(streams)):
#             demuxData = siteDataPicker.pickSite(args.site)
#             muxSorter = siteSortPicker.pickSite(args.site)
#             stream = streams[j]
#             # remove the folder if the source folder
#             if args.splitplaylist < float("inf"):
#                 if demuxHelper.setStreamsLength([stream]) < args.splitplaylist:
#                     message = \
#                         f"""
#                     The length of the stream: {stream}
#                     is less then the min that you picked
#                     """
#                     print(message)
#                     os.chdir(demuxFolder)
#                     continue

#             newFolder = os.path.join(demuxFolder, str(ep))
#             paths.mkdirSafe(newFolder)
#             os.chdir(newFolder)
#             print(f"Creating a new episode folder at {newFolder}\n")

#             # create a source folder
#             output = paths.createChildDemuxFolder(os.getcwd(), source)
#             print(f"\nCreating a new source folder at {output}")
#             os.chdir(output)
#             show = utils.sourcetoShowName(source)
#             path = os.path.join(output, "output_logs", f"BDINFO.{show}.txt")

#             # copy bdinfo to folder
#             print(f"\nParsing STREAM: {stream}")
#             bdObj.writeBdinfo(path)

#             currentTracks = demuxData.addTracks(quickSums, playlistNum, playlistFile,
#                                                 [stream], source, output)
#             if not args.dontconvert:
#                 demuxData.convertFlac(currentTracks, output)

#             tools.extractTracks(demuxData, stream=True)
#             tools.sortTracks(muxSorter, demuxData, movieObj.movieObj, args)
#             tools.machineReader(muxSorter, args, movieObj.movieObj)
#             



    
