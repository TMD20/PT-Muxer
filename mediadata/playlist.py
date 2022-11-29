import os
from num2words import num2words

import sites.pickers.siteDataPicker as siteDataPicker




class playlist():
    def __init__(self,bdObjs,args):
        self._bdObjs=bdObjs
        self._args=args
        self._trackObjList=[]
    def __call__(self):
        self._processBdinfo()
        self._batchProcess()
    

    
    
    def _batchProcess(self):
        if self._args.splitplaylist:
            for i in range(len(self._bdObjs[0].keys)):
                demuxData= siteDataPicker.pickSite(self._args.site)
                self._trackObjList.append(demuxData)    
                self.processDemuxData(demuxData, i)
        else:
            None
            

                        

    def processDemuxData(self,demuxData,i):
        for bdObj in self._bdObjs:
            # create bdinfo quicksum for all source 
            key=bdObj.keys[i]
            playlistNum = key
            playlistDict=bdObj.Dict[key]
            #add tracks to demuxdata
            demuxData.addTracks(playlistDict["quickSum"], playlistNum,playlistDict["playlistFile"],playlistDict["playlistStreams"],bdObj.mediaDir,self._args.outpath)
        
    @property
    def trackObjs(self):
        return self._trackObjList



# def batchPlayList(bdObjs, args, demuxFolder, movieObj): 
#     processBdinfo(bdObjs)
#     extractTracks(bdObjs, args, demuxFolder)
#     for i in range(len(bdObjs[0].keys)):
#         ep = len(os.listdir(demuxFolder))+1
#         newFolder = os.path.join(demuxFolder, str(ep))

#         print(f"Processing Episode Number {num2words(ep)} \
#         \nCreating a new episode folder at {newFolder}\n")
#         demuxData = siteDataPicker.pickSite(args.site)
#         muxSorter = siteSortPicker.pickSite(args.site)
#         paths.mkdirSafe(newFolder)
#         os.chdir(newFolder)



        

            
            
            
            
            
            
            
            
            # #extract files

            

            # 
            # output = 
            # print(f"\nCreating a new source folder at {output}")
            # os.chdir(output)
            # show = utils.sourcetoShowName(source)
            # path = os.path.join(output, "output_logs", f"BDINFO.{show}.txt")
            # print(f"\nParsing BDINFO:{playlistFile}")
            # bdObj.writeBdinfo(path)
            # quickSums = bdObj.setQuickSum()
            # streams = bdObj.setStreams()

            # bdObj.setChapters()

            # currentTracks = 
    #         if not args.dontconvert:
    #             demuxData.convertFlac(currentTracks, output)
    #         # parse data
    #     match = bdObjs[0].mediaDir
    #     if len(bdObjs) > 1:
    #         match = utils.singleSelectMenu(
    #             list(map(lambda x: x.mediaDir, bdObjs)), "Which Source Has The proper Chapter File")
    #     chapters = list(filter(lambda x: x.mediaDir == match, bdObjs))[
    #         0].chapters

    #     tools.extractTracks(demuxData)
    #     tools.sortTracks(muxSorter, demuxData, movieObj.movieObj, args)
    #     tools.machineReader(muxSorter, args, movieObj.movieObj)
    #     outdict = {}

    #     outdict["Sources"] = tools.addSourceData(demuxData)
    #     outdict["ChapterData"] = tools.ConvertChapterList(chapters)
    #     outdict = {}
    #     outdict["Sources"] = tools.addSourceData(demuxData)
    #     outdict["ChapterData"] = tools.ConvertChapterList(chapters)
    #     movieDict = movieObj.movieObj
    #     movieDict["episode"] = ep
    #     movieDict["season"] = season
    #     outdict["Movie"] = movieDict

    #     tools.addEnabledData(outdict, muxSorter)
    #     tools.addTrackData(outdict, muxSorter)
    #     os.chdir(newFolder)
    #     tools.writeFinalJSON(outdict)
    # # change pack to parent
    # os.chdir(demuxFolder)