import re
import os

from num2words import num2words

import tools.general as utils
from demux.base import Demux
import mediadata.movieData as movieData
import tools.paths as paths
import tools.directory as dir
import sites.pickers.siteSortPicker as siteSortPicker
import sites.pickers.siteDataPicker as siteDataPicker
import mediatools.dgdemux as dgdemux

import mediatools.eac3to as eac3to
import config




class Demux(Demux):
    def __init__(self,args):
        super().__init__(args)
        self._name="TV Shows"
        self._type="TV"

    def demux(self):
        with dir.cwd(self.demuxFolder):
            self._movieObj = movieData.MovieData()
            self._movieObj.setData(self._type,utils.getTitle(self.sources[0]))
            while True:
                bdObjs = self._setBdInfoData() 
                if self._args.splitplaylist and self._args.splitplaylist>0:
                    self.demuxSplitPlayList(bdObjs)
                else:
                    self.demuxPlaylist(bdObjs,multiSelect=True)

                if utils.singleSelectMenu(["Yes", "No"], "Extract more playlist") == "No":
                    print("Thank You, make sure to double check episode numbers")

                    break
                if utils.singleSelectMenu(["Yes", "No"], "Change Sources") == "Yes":
                    self.setSource()

                offset = len(os.listdir(self.demuxFolder))
                message =\
                    f"""
                Total Iterations:{num2words(offset)}
                Next Iteration: {num2words(offset+1)}

                The previous playlist selection for every source will be reset
                """
                print(message)  
        
    def demuxSplitPlayList(self,bdObjs):
        for bdObj in bdObjs:
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
            [trackerObjDict.update({m:{"folder":self._getNewFolder(startdex+m),"list":[]}}) for m in range(len(bdObjs[0].DictList[i]["playlistStreams"]))]
            for bdObj in bdObjs:
                    print(f"Processing all streams for {bdObj.mediaDir} Playlist: {bdObj.DictList[i]['playlistFile']}")
                    streams=bdObj.filterStreams(i,self._args.splitplaylist)
                    for j,stream in enumerate(streams):
                        newFolder = self._getNewFolder(startdex+j)
                        with dir.cwd(newFolder):
                            demuxData = siteDataPicker.pickSite(self._args.site)
                            currentTracks=demuxData.addTracks(bdObj,bdObj.keys[i],streams=[stream])
                            demuxData.addOutput(newFolder)
                            with dir.cwd(demuxData["outputDir"]):
                                if not self._args.dontconvert:
                                    demuxData.convertFlac(currentTracks)
                                bdObj.writeBDInfo(i)
                                print( f"\nExtracting Files From stream:{stream['name']}")
                                eac3to.process(currentTracks,demuxData["sourceDir"],demuxData["streamFiles"][0])
                                trackerObjDict[j]["list"].append(demuxData)

            #Take combined data struture process each stream index
            for key in trackerObjDict.keys():
                trackerObjs=trackerObjDict[key]["list"]
                newFolder=trackerObjDict[key]["folder"]
                with dir.cwd(newFolder):
                    muxSorter=self._getMuxSorter(trackerObjs)
                    self._subParse(muxSorter)
                    self._voiceRec(muxSorter)
                    self._saveOutput(trackerObjs,muxSorter)
      

             
                


           
                # outdict["ChapterData"] = tools.ConvertChapterList(chaptersFiltered)
                # movieDict = movieObj.movieObj
                # movieDict["episode"] = ep
                # movieDict["season"] = season
                # outdict["Movie"] = movieDict

                # tools.addEnabledData(outdict, muxSorter)
                # tools.addTrackData(outdict, muxSorter)

                # os.chdir(newFolder)
                # tools.writeFinalJSON(outdict)
                # # change pack to parent
                # os.chdir(demuxFolder)
                # ep = ep+1        

    
    
    
    
    def _dgdemuxSplitPlaylistHelper(self,bdObjs):
        print("Note in dgdemux Mode all streams will be outputted\n You will have to manually remove any short streams")     
        #i represent each playlist
        for i in range(len(bdObjs[0].keys)):
            startdex=len(os.listdir(self.demuxFolder))
            trackerObjDict={}
            [trackerObjDict.update({m:{"folder":self._getNewFolder(startdex+m),"list":[]}}) for m in range(len(bdObjs[0].DictList[i]["playlistStreams"]))]
            #dgdemux won't allow individual mt2s processing
            # Each playlist must be processed in batches
            for bdObj in bdObjs:
                print(f"Processing all streams for {bdObj.mediaDir} Playlist: {bdObj.DictList[i]}")
                tempdir=paths.createTempDir()
                with dir.cwd(tempdir):
                        newFolder=""
                        demuxData=siteDataPicker.pickSite(self._args.site)
                        currentTracks=demuxData.addTracks(bdObj,bdObj.keys[i])
                        dgdemux.run(currentTracks,demuxData["sourceDir"],demuxData["playlistFile"],ep=True)
                
                #Process each stream index with data from one source
                # Save in combined data struture, organized by stream index
                for j,stream in enumerate(bdObj.DictList[i]["playlistStreams"]):
                    newFolder=self._getNewFolder(startdex+j)
                    with dir.cwd(newFolder):
                        demuxData=siteDataPicker.pickSite(self._args.site)
                        currentTracks=demuxData.addTracks(bdObj,bdObj.keys[i],streams=[stream])
                        demuxData.addOutput(newFolder)
                        #copy files to new outputdir
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
                    self._saveOutput(trackerObjs,muxSorter)
    
                


                





                
            
      
                    
        
    ####
    # Helper Functions
    ####
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
            if utils.singleSelectMenu(["Yes", "No"], "Restore Folder Old MuxFolder Data") == "Yes":
                print("Searching for Prior TV Mode Folders")
                folders = self._getTVMuxFolders(outpath)
                if len(folders) == 0:
                    print("No TV Mode Folders Found To Restore")
                    print("Creating a new Mux Folder")
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

            Press Space to add/remove selection
            Press Enter when Done
            """
            return utils.multiSelectMenu(paths, msg)
        else:
            msg = \
            """
    Since you selected --sortpref order
    You will be prompted multiple times to make a selection
    Pay attention to the order of the list printed out, as this will effect enabled tracks

    Click on the Source You Want for this Demux
    For TV Shows you can change the Source(s) Per Episode

    When Finish Click 'I'm Done Selecting Sources'
            """
            list=["I'm done selecting sources","I want to reset my list"]
            list.extend(paths)
            selection=[]
            while True:
                print(f"Your list thus far\n\n")
                print("\n".join(selection))
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






    
