import os
from num2words import num2words

import sites.pickers.siteDataPicker as siteDataPicker
import sites.pickers.siteSortPicker as siteSortPicker
import tools.general as utils
import demux.paths as paths
import demux.tools as tools



def batchPlayList(bdObjs, sources, args, demuxFolder, movieObj):
    print("What TV Show?")
    print(movieObj)
    quit()
    # outter loop is for each episdoe
    for i in range(len(bdObjs[0].playlistNumList)):
        offset = len(os.listdir(demuxFolder))
        ep = offset+1
        print(f"Processing Episode Number {num2words(ep)}\n")
        newFolder = os.path.join(demuxFolder, str(ep))
        print(f"Creating a new episode folder at {newFolder}")
        demuxData = siteDataPicker.pickSite(args.site)
        muxSorter = siteSortPicker.pickSite(args.site)
        utils.mkdirSafe(newFolder)
        os.chdir(newFolder)
        # inner loop is for each source
        for j in range(len(sources)):
            source = sources[j]
            bdObj = bdObjs[j]
            playlistNum = bdObj.playlistNumList[i]
            playlistFile = bdObj.playlistFileList[i]
            print(f"Processing Playlist Number {num2words(playlistNum)}\n")

            # get the current playlist/Write bdinfo

            bdObj.runbdinfo(playlistNum)
            output = paths.createChildDemuxFolder(os.getcwd(), source)
            print(f"\nCreating a new source folder at {output}")
            os.chdir(output)
            show = utils.sourcetoShowName(source)
            path = os.path.join(output, "output_logs", f"BDINFO.{show}.txt")
            print(f"\nParsing BDINFO:{playlistFile}")
            bdObj.writeBdinfo(path)
            quickSums = bdObj.getQuickSum()
            streams = bdObj.getStreams()

            bdObj.getChapters()

            currentTracks = demuxData.addTracks(quickSums, playlistNum,
                                                playlistFile, streams, source, output)
            if not args.dontconvert:
                demuxData.convertFlac(currentTracks, output)
            # parse data
        match = bdObjs[0].mediaDir
        if len(bdObjs) > 1:
            match = utils.singleSelectMenu(
                list(map(lambda x: x.mediaDir, bdObjs)), "Which Source Has The proper Chapter File")
        chapters = list(filter(lambda x: x.mediaDir == match, bdObjs))[
            0].chapters

        tools.extractTracks(demuxData)
        tools.sortTracks(muxSorter, demuxData, movieObj.movieObj, args)
        tools.machineReader(muxSorter, args, movieObj.movieObj)
        outdict = {}

        outdict["Sources"] = tools.addSourceData(demuxData)
        outdict["ChapterData"] = tools.ConvertChapterList(chapters)
        outdict = {}
        outdict["Sources"] = tools.addSourceData(demuxData)
        outdict["ChapterData"] = tools.ConvertChapterList(chapters)
        movieDict = movieObj.movieObj
        movieDict["episode"] = ep
        movieDict["season"] = season
        outdict["Movie"] = movieDict

        tools.addEnabledData(outdict, muxSorter)
        tools.addTrackData(outdict, muxSorter)
        os.chdir(newFolder)
        tools.writeFinalJSON(outdict)
    # change pack to parent
    os.chdir(demuxFolder)