import re
import os

from num2words import num2words
import langcodes

import tools.general as utils
from demux.base import Demux
import mediadata.movieData as movieData
import tools.paths as paths
import tools.directory as dir
import sites.pickers.siteDataPicker as siteDataPicker
import mediatools.dgdemux as dgdemux
import mediatools.eac3to as eac3to
import config
import tools.logger as logger





class Demux(Demux):
    def __init__(self,args):
        super().__init__(args)
        self._name="TV Shows"
        self._type="TV"

    def demux(self):
        with dir.cwd(self.demuxFolder):
            self._movieObj = movieData.MovieData("TV")
            self._movieObj.setData(self._type,utils.getTitle(self.sources[0]))
            bdObjs = self._setBdInfoData() 
            if self._args.splitplaylist and self._args.splitplaylist>0:
                self.demuxSplitPlayList(bdObjs)
            else:
                self.demuxPlaylist(bdObjs,multiSelect=True)

    def demuxSplitPlayList(self,bdObjs):
        for bdObj in bdObjs:
            logger.print(bdObj.mediaDir,style="white")
            bdObj.playListRangeSelect()
        for i in range(len(bdObjs[0].keys)):
            self._index=i
            for bdObj in bdObjs:
                    bdObj.generateData(i)
                    demuxData=siteDataPicker.pickSite(self._args.site)
        bdObjs[0].validateStreams(bdObjs) 

        
        if self._args.extractprogram=="eac3to":
            self._eac3toSplitPlaylistHelper(bdObjs)
               
        else:
           self._dgdemuxSplitPlaylistHelper(bdObjs)
      
    


    def _eac3toSplitPlaylistHelper(self,bdObjs):
    # outter loop through every playlist
        for i in range(len(bdObjs[0].DictList)):
            startdex = len(os.listdir(self.demuxFolder))
            trackerObjDict={}
            maxLength=max(list(map(lambda x:len(x.streamTracks(i,self._args.splitplaylist)),bdObjs)))
            [trackerObjDict.update({m:{"folder":self._getNewFolder(startdex+m),"list":[]}}) for m in range(maxLength)]
            for bdObj in bdObjs:
                    logger.logger.info(f"Processing all streams for {bdObj.mediaDir} Playlist: {bdObj.DictList[i]['playlistFile']}")
                    streams=bdObj.streamTracks(i,self._args.splitplaylist)
                    for j,stream in enumerate(streams):
                        newFolder = self._getNewFolder(startdex+j)
                        with dir.cwd(newFolder):
                            demuxData = siteDataPicker.pickSite(self._args.site)
                            demuxData.addTracks(bdObj,bdObj.keys[i],streams=[stream])
                            self._filterStreamMedia(demuxData,bdObj.DictList[i]["streamTracks"][stream["name"]])
                            demuxData.setOutput(newFolder)
                            with dir.cwd(demuxData["outputDir"]):
                                if not self._args.dontconvert:
                                    demuxData.convertFlac()
                                bdObj.writeBDInfo(i)
                                logger.logger.info( f"\nExtracting Files From stream:{stream['name']}")
                                eac3to.process(demuxData.tracks,demuxData["sourceDir"],demuxData["streamFiles"][0])
                                trackerObjDict[j]["list"].append(demuxData)

            #Take combined data struture process each stream index
            for key in trackerObjDict.keys():
                trackerObjs=trackerObjDict[key]["list"]
                newFolder=trackerObjDict[key]["folder"]
                with dir.cwd(newFolder):
                    muxSorter=self._getMuxSorter(trackerObjs)
                    self._subParse(muxSorter)
                    self._voiceRec(muxSorter)
                    self._writeFinalJSON(self._saveOutput(trackerObjs,muxSorter))

      

             
                

    
    
    
    
    
    
    def _dgdemuxSplitPlaylistHelper(self,bdObjs):
        logger.print("Note in dgdemux Mode all streams will be outputted\n You will have to manually remove any short streams")     
        #i represent each playlist
        for i in range(len(bdObjs[0].keys)):
            startdex=len(os.listdir(self.demuxFolder))
            trackerObjDict={}
            maxLength=max(list(map(lambda x:len(x.streamTracks(i,self._args.splitplaylist)),bdObjs)))
            [trackerObjDict.update({m:{"folder":self._getNewFolder(startdex+m),"list":[]}}) for m in range(maxLength)]
            for bdObj in bdObjs:
                logger.logger.info(f"Processing all streams for {bdObj.mediaDir} Playlist: {bdObj.DictList[i]['playlistFile']}")
                tempdir=paths.createTempDir()
                #This sectiom Extracts all tracks for all sources into tempdir
                with dir.cwd(tempdir):
                        newFolder=""
                        demuxData=siteDataPicker.pickSite(self._args.site)
                        #Send every track
                        #dgdemux will filter via indexes
                        demuxData.addTracks(bdObj,bdObj.keys[i])
                        currentTracks=demuxData.tracks
                        dgdemux.run(currentTracks,demuxData["sourceDir"],demuxData["playlistFile"],ep=True)
                
                #Processes the previous tempdirFiles
                # Each stream gets subfolder in tempdir
                streams=bdObj.streamTracks(i,self._args.splitplaylist)
                for j,stream in enumerate(streams):
                    newFolder=self._getNewFolder(startdex+j)
                    #prepare info
                    with dir.cwd(newFolder):
                        demuxData=siteDataPicker.pickSite(self._args.site)
                        #filter hidden tracks here 
                        demuxData.addTracks(bdObj,bdObj.keys[i],streams=[stream])
                        currentTracks=self._filterStreamMedia(demuxData,bdObj.DictList[i]["streamTracks"][stream["name"]])
                        demuxData.setOutput(newFolder)
                        #processs info into outputdir subfolder
                        with dir.cwd(demuxData["outputDir"]):
                            paths.copytree(paths.listdir(tempdir)[j],".")
                            bdObj.writeBDInfo(i)
                            trackerObjDict[j]["list"].append(demuxData)
            
            #Take combined data struture process each stream index
            for key in trackerObjDict.keys():
                trackerObjs=trackerObjDict[key]["list"]
                newFolder=trackerObjDict[key]["folder"]
                with dir.cwd(newFolder):
                    muxSorter=self._getMuxSorter(trackerObjs)
                    self._subParse(muxSorter)
                    self._voiceRec(muxSorter)
                    self._writeFinalJSON(self._saveOutput(trackerObjs,muxSorter))

    
                


                




    def _saveOutput(self, trackerObjs, muxSorter):
        outdict=super()._saveOutput(trackerObjs, muxSorter)
        outdict["Movie"]["episode"]= paths.listdir(self.demuxFolder).index(os.path.abspath("."))+1
        return outdict


    
                
            
      
                    
        
    ####
    # Helper Functions
    ####
    def _filterStreamMedia(self,demuxData,streamTracks):
        self._videoTrackHelper(demuxData,streamTracks)
        self._audioTrackHelper(demuxData,streamTracks)
        self._subTrackHelper(demuxData,streamTracks)
        
 
          
        

    def _audioTrackHelper(self,demuxData,streamTracks):
        i=0
        streamTracks=list(filter(lambda x:x["type"]=="audio",streamTracks))
        demuxDataTracks=list(filter(lambda x:x[1]["compat"]==False ,demuxData.audioitems))

    
    
        for key,value in demuxDataTracks:
            if i>=len(streamTracks):
                demuxData["tracks"].pop(key)
                continue
            streamTrack=streamTracks[i]
            if re.search(streamTrack["codec"],value["bdinfo_title"])==None:
                demuxData["tracks"].pop(key)
                continue
            if langcodes.standardize_tag(value["langcode"])!=langcodes.standardize_tag(streamTrack["lang"]):
                demuxData["tracks"].pop(key)
                continue
            i=i+1
        compatItems=demuxData.compatitems
        for key,value in compatItems:
            if demuxData["tracks"].get(value["parentKey"])==None:
                demuxData["tracks"].pop(key)
            
            
            
          
           
            
    def _videoTrackHelper(self,demuxData,streamTracks):
        i=0
        streamTracks=list(filter(lambda x:x["type"]=="video",streamTracks))
        demuxDataTracks=demuxData.videoitems

        for key,value in demuxDataTracks:
            if i>=len(streamTracks):
                demuxData["tracks"].pop(key)
                continue
            streamTrack=streamTracks[i]
            if re.search(streamTrack["codec"],value["bdinfo_title"])==None:
                demuxData["tracks"].pop(key)
                continue
            i=i+1
  

            
    def _subTrackHelper(self,demuxData,streamTracks):
        i=0
        streamTracks=list(filter(lambda x:x["type"]=="subtitle",streamTracks))
        demuxDataTracks=demuxData.subtitleitems

        for key,value in demuxDataTracks:
            if i>=len(streamTracks):
                demuxData["tracks"].pop(key)
                continue
            streamTrack=streamTracks[i]
            if langcodes.standardize_tag(value["langcode"])!=langcodes.standardize_tag(streamTrack["lang"]):
                demuxData["tracks"].pop(key)
                continue
            i=i+1

        
      


   





            

      
    def _callFunction(self):
        self.setSource()
        self._fixArgs()
        self.getDemuxFolder()
        self.demux()

    def setSource(self):
        options = self._getBDMVs(self._args.inpath)
        self.sources = self.getSources(options,self._args.inpath,self._args.sortpref)


    def getSources(self,options,inpath, sortpref):
        if len(options) == 0:
            raise RuntimeError("No Sources Directories Found")
        sources = None
        sources = self._addMultiSource(options, sortpref)
        for i in range(0, len(sources)):
                    if re.search(".iso", sources[i]):
                        sources[i] = paths.extractISO(sources[i], inpath)
        return sources
       
    def setStreamsLength(self,streams):
        duration = 0
        start = utils.convertArrow(streams[0]["start"], "hh:mm:ss.SSS")
        end = utils.convertArrow(streams[-1]["end"], "hh:mm:ss.SSS")
        dif = utils.subArrowTime(end, start)
        duration = (duration+dif.hour*60)
        duration = (duration+dif.minute)
        duration = (duration+(dif.second/60))
        return duration

    def getNewStartTime(self,startTime, streams):
        start = utils.convertArrow(streams[0]["start"], "hh:mm:ss.SSS")
        end = utils.convertArrow(streams[-1]["end"], "hh:mm:ss.SSS")
        dif = utils.subArrowTime(end, start)
        startTime = utils.addArrowTime(startTime, dif)
        return startTime
    def getDemuxFolderHelper(self,sources, outpath):
            if utils.singleSelectMenu(["Yes", "No"], "Continue with Previous MuxFolder",default="No") == "Yes":
                logger.print("Searching for Prior TV Mode Folders")
                folders = self._getTVMuxFolders(outpath)
                if len(folders) == 0:
                    logger.print("No TV Mode Folders Found To Restore")
                    logger.print("Creating a new Mux Folder")
                    return self._createParentDemuxFolder(
                        sources, outpath)
                else:
                    folder = utils.singleSelectMenu(
                        folders, "Which Folder Do you want to Restore")

                    return folder
            else:
                return self._createParentDemuxFolder(sources, outpath)
        
    def getDemuxFolder(self):
        paths.mkdirSafe(self._args.outpath)
        self.demuxFolder=self.getDemuxFolderHelper(self.sources, self._args.outpath)


    #Select
    def _addMultiSource(self,paths,sortpref):
        if len(paths) == 0:
            raise RuntimeError("No Sources Directories Found")
        msg=None
        if sortpref=="size":
            msg = \
            """
            Click on the Source(s) You Want for this Demux

            TV Mode will run multiple times
            for more advanced source selection
            """
            return utils.multiSelectMenu(paths, msg)
        else:
            msg = \
            """
            Since you selected --sortpref order
            You will be prompted multiple times to make a selection
            Pay attention to the order of the list printed out, as this will effect enabled tracks

            Source You Want for this Demux
            For TV Shows you can change the Source(s) Per Episode

            When Finish Click 'I'm Done Selecting Sources'
            """
            list=["I'm done selecting sources","I want to reset my list"]
            list.extend(paths)
            selection=[]
            while True:
                logger.print(f"Your list thus far\n\n")
                logger.print("\n".join(selection))
                curr_select = utils.singleSelectMenu(list, msg)
                selection.append(curr_select)
                if curr_select == "I want to reset my list":
                    selection=[]
                if curr_select=="I'm done selecting sources":
                    break
            selection=list(filter(lambda x:x!="done" and x!=None))
            selection=utils.removeDupesList(selection)
            return selection

    def _addSingleSource(self,paths):
        if len(paths) == 0:
            raise RuntimeError("No Sources Directories Found")
        msg = \
        """
        Click on the Source You Want for this Demux

        TV Mode will run multiple times
        for more advanced source selection

        Press Enter to confirm when Done
            """
        return utils.singleSelectMenu(paths, msg)

    def _getTVMuxFolders(self,inpath):
        folders = paths.search(inpath, f"{config.demuxPrefix}[.]",dir=True,recursive=False)
        emptyFolders =  list(filter(lambda x: len(os.listdir(x)) ==0, folders))       
        tvFolders= list(filter(lambda x: len(os.listdir(x)) > 0, folders))
        tvFolders = list(filter(lambda x: re.search(
            "^[0-9]+$", os.listdir(x)[0]) != None, tvFolders))
        tvFolders.extend(emptyFolders)
        return tvFolders






    
