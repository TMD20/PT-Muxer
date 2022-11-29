import os
import re

from num2words import num2words

import tools.general as utils
import tools.paths as paths
import mediatools.bdinfo as bdinfo
import remux.helpers as remuxHelper
import config as config
import sites.pickers.siteDataPicker as siteDataPicker
import mediatools.extract.extract as extract



class Demux():
    def __init__( self,args):
        self._args=args
        self.demuxFolder=None
        self._name=None
        self._type=None
    def __call__(self):
        self.setSource()
        self._fixArgs()
        self.getDemuxFolder()
        self.callFunction()

    def callFunction(self):
        None
    
    def demuxPlaylist(self,bdObjs):
        for bdObJ in bdObjs:
            bdObJ.playListRangeSelect()
        bdObjs[0].validate(bdObjs)       
        for i in range(len(bdObjs[0].keys)):
            trackerObjs=[]
            newFolder=os.path.join(self.demuxFolder,str(i+1))
            paths.mkdirSafe(newFolder)
            for bdObj in bdObjs:
                bdObj.generateData(i)
                demuxData=siteDataPicker.pickSite(self._args.site)
                currentTracks=demuxData.addTracks(bdObj,bdObj.keys[i],newFolder)
                trackerObjs.append(demuxData)

                extract.extractTracks(currentTracks,newFolder,bdObj.mediaDir,self._args.extractprogram,os.path.join(bdObj.playlistDir,bdObj.DictList[i]["playlistFile"]))
                quit()
        
          

        
    def getDemuxFolderHelper(self,sources, outpath):
        if utils.singleSelectMenu(["Yes", "No"], "Restore Folder Old MuxFolder Data") == "Yes":
            print("Searching for Prior TV Mode Folders")
            folders = remuxHelper.getTVMuxFolders(outpath, config.demuxPrefix)
            if len(folders) == 0:
                print("No TV Mode Folders Found To Restore")
                print("Creating a new Mux Folder")
                return self.createParentDemuxFolder(
                    sources, outpath)
            else:
                folder = utils.singleSelectMenu(
                    folders, "Which Folder Do you want to Restore")

                return folder
        else:
            return paths.createParentDemuxFolder(sources, outpath)
    
    def getDemuxFolder(self):
        paths.mkdirSafe(self._args.outpath)
        os.chdir(self._args.outpath)
        self.demuxFolder=self.getDemuxFolderHelper(self.sources, self._args.outpath)




    
    

    #################
    # Helper Functions
    ############
    def setSource(self):
        options = self._getBDMVs(self._args.inpath)
        self.sources = self.getSources(options,self._args.inpath,self._args.sortpref, self._args.splitplaylist == None,extract=True)

    def setBdInfoData(self):
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
        currpath = os.getcwd()
        os.chdir(path)
        list1 = paths.search(path, "STREAM",dir=True)
        list2 = paths.search(path, ".iso")
        list1.extend(list2)
        list1 = list(map(lambda x: utils.convertPathType(x, "Linux"), list1))
        os.chdir(currpath)
        return sorted(list1)

    def createParentDemuxFolder(self,sources, outpath):
        title = utils.getTitle(sources[0])
        folder = f"{config.demuxPrefix}.{utils.getFormated('YY.MM.DD_HH:mm.ss')}.{title}"
        parentDemux = os.path.join(outpath, folder)
        parentDemux = re.sub(" +", " ", parentDemux)
        parentDemux = re.sub(" ", ".", parentDemux)
        parentDemux = utils.convertPathType(parentDemux, "Linux")
        print(f"Creating a new Parent Directory for {self._name} ->{parentDemux}")
        os.mkdir(parentDemux)
        return parentDemux
    #Select
    def addMultiSource(self,paths,sortpref):
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

def addSingleSource(self,paths):
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



    
