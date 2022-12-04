import re
import os

from num2words import num2words

import tools.general as utils
from demux.base import Demux
import mediadata.movieData as movieData
import tools.paths as paths
import remux.helpers as remuxHelper
import tools.directory as dir




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
                # playlistObj=playlist.playlist(bdObjs,self._args)
                # playlistObj()
                # trackObjs=playlistObj.trackObjs
                # # offset=len(os.listdir(self.demuxFolder))
                # for i,trackObj in enumerate(trackObjs):
                #     newFolder=os.path.join(self.demuxFolder,str(i+offset+1))
                #     paths.mkdirSafe(newFolder)
                #     for source in trackObj.sources:
                #         sourceData=trackObj.filterBySource(source)
                #         extract.extractTracks(source,newFolder,sourceData["tracks"],trackObj.getPlaylistLocation(source,self._args.splitplaylist),self._args.extractprogram)
                if self._args.splitplaylist:
                    None
                else:
                    self.demuxPlaylist(bdObjs)

                    


                


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
        self.sources = self.getSources(options,self._args.inpath,self._args.sortpref, self._args.splitplaylist == None)

    def getSources(self,options,inpath, sortpref,multi):
        if len(options) == 0:
            print("No Valid Source Directories Found")
            quit()
        sources = None
        if multi:
            sources = self._addMultiSource(options, sortpref)
        else:
            sources = [self._addSingleSource(options)]
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
                folders = remuxHelper.getTVMuxFolders(outpath, config.demuxPrefix)
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
            print("No Valid Source Directories Found")
            quit()
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
            print("No Valid Source Directories Found")
            quit()
        msg = \
            """
            Click on the Source You Want for this Demux

            TV Mode will run multiple times
            for more advanced source selection

            Press Enter to confirm when Done
            """
        return utils.singleSelectMenu(paths, msg)




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
#         streams = bdObj.setStreams()
#         chapters = bdObj.setChapters()
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
#             chaptersFiltered = list(
#                 filter(lambda x: x["start"] >= stream["start"], chapters))
#             chaptersFiltered = list(
#                 filter(lambda x: x["start"] < stream["end"], chaptersFiltered))
#             outdict = {}
#             outdict["Sources"] = tools.addSourceData(demuxData)
#             outdict["ChapterData"] = tools.ConvertChapterList(chaptersFiltered)
#             movieDict = movieObj.movieObj
#             movieDict["episode"] = ep
#             movieDict["season"] = season
#             outdict["Movie"] = movieDict

#             tools.addEnabledData(outdict, muxSorter)
#             tools.addTrackData(outdict, muxSorter)

#             os.chdir(newFolder)
#             tools.writeFinalJSON(outdict)
#             # change pack to parent
#             os.chdir(demuxFolder)
#             ep = ep+1



    
