import os

from num2words import num2words

import mediadata.movieData as movieData
import tools.general as utils
import demux.paths as paths
import demux.tools as tools
import demux.TV.helper as demuxHelper
import demux.shared.playlist as playlist


def demux(args):
    demuxFolder=None
    #Protection From Deleting Restored Folder
    currentFolders=os.listdir(args.inpath)
    try:
        args.audiolang = list(map(lambda x: x.lower(),  args.audiolang))
        args.sublang = list(map(lambda x: x.lower(),  args.sublang))

        # make the output directory if needed
        utils.mkdirSafe(args.outpath)
        os.chdir(args.outpath)

        options = paths.getBDMVs(args.inpath)
        sources = demuxHelper.getSources(options,args.inpath,args.sortpref, args.splitplaylist == None,extract=True)

        demuxFolder = demuxHelper.getDemuxFolder(sources, args.outpath)
       

        movieObj = movieData.MovieData()
        movieObj.setData("TV",utils.getTitle(sources[0]))
     
    
        while True:
            bdObjs = demuxHelper.getBdinfoData(sources)
            tools.validateBdinfo(bdObjs)
            offset = len(os.listdir(demuxFolder))
            message =\
                f"""
            Current Iterations:{num2words(offset)}
            """
            if not args.splitplaylist:
                playlist.batchPlayList(bdObjs[0], sources[0], args, demuxFolder,
                            movieObj)
            else:
                playlist.batchPlayList(bdObjs[0], sources[0], args, demuxFolder,
                            movieObj)

            if utils.singleSelectMenu(["Yes", "No"], "Extract more playlist") == "No":
                print("Thank You, make sure to double check episode numbers")

                break
            if utils.singleSelectMenu(["Yes", "No"], "Change Sources") == "Yes":
                sources = demuxHelper.getSources(
                    options, args.inpath, args.sortpref, args.splitplaylist == None,extract=False)
            offset = len(os.listdir(demuxFolder))
            message =\
                f"""
            Total Iterations:{num2words(offset)}
            Next Iteration: {num2words(offset+1)}

            The previous playlist selection for every source will be reset
            """
            print(message)  
    except Exception as e:
        print(e)
        if demuxFolder not in currentFolders:
            if utils.singleSelectMenu(["Yes","No"],"Do you want to delete the inprogress folder?")=="Yes":
                utils.rmDir(demuxFolder)


# def batchStreams(bdObj, source, args, demuxFolder, movieObj, season):
#     # outter loop through every playlist
#     for i in range(len(bdObj.playlistNumList)):
#         playlistNum = bdObj.playlistNumList[i]
#         playlistFile = bdObj.playlistFileList[i]

#         print(
#             f"Processing all streams from playlist number {num2words(playlistNum)}\n")

#         # get quick summary and bdinfo data
#         bdObj.runbdinfo(playlistNum)
#         quickSums = bdObj.getQuickSum()
#         streams = bdObj.getStreams()
#         chapters = bdObj.getChapters()
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
#                 if demuxHelper.getStreamsLength([stream]) < args.splitplaylist:
#                     message = \
#                         f"""
#                     The length of the stream: {stream}
#                     is less then the min that you picked
#                     """
#                     print(message)
#                     os.chdir(demuxFolder)
#                     continue

#             newFolder = os.path.join(demuxFolder, str(ep))
#             utils.mkdirSafe(newFolder)
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



    
