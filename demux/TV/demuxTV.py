import os

from num2words import num2words

import sites.pickers.siteDataPicker as siteDataPicker
import sites.pickers.siteSortPicker as siteSortPicker
import mediadata.movieData as movieData
import tools.general as utils
import demux.paths as paths
import demux.select as select
import demux.tools as tools
import demux.TV.helper as demuxHelper


def demux(args):
    options = paths.getBDMVs(args.inpath)

    # make the output directory if needed
    utils.mkdirSafe(args.outpath)
    os.chdir(args.outpath)
    print("Getting Source(s) For TV Demux\n")

    sources = select.getSources(options, args.inpath,
                                args.sortpref, args.splitplaylist == False)
    demuxFolder = paths.getDemuxFolder(sources, args.inpath, args.outpath)
    movie = movieData.matchMovie(sources)
    season = int(utils.getIntInput("Enter Season Number: "))
    while True:
        bdObjs = demuxHelper.getBdinfoData(sources)
        tools.validateBdinfo(bdObjs)
        offset = len(os.listdir(demuxFolder))
        if not args.splitplaylist:
            batchSources(bdObjs, sources, args, demuxFolder,
                         movie, season, offset=offset)
        else:
            batchStreams(bdObjs[0], sources[0], args, demuxFolder,
                         movie, season, offset=offset)

        if utils.singleSelectMenu(["Yes", "No"], "Extract more playlist") == "No":
            break
        if utils.singleSelectMenu(["Yes", "No"], "Change Sources") == "Yes":
            sources = select.getSources(options, args.inpath, args.sortpref)
        offset = len(os.listdir(demuxFolder))
        message =\
            f"""
        Total Iterations:{num2words(offset)}
        Next Iteration: {offset+1}

        The previous playlist selection for every source will be reset
        """
        print(message)


def batchStreams(bdObj, source, args, demuxFolder, movie, season, offset=0):
    # outter loop through every playlist
    for i in range(len(bdObj.playlistNumList)):
        playlistNum = bdObj.playlistNumList[i]
        playlistFile = bdObj.playlistFileList[i]

        print(
            f"Processing all streams from playlist number {num2words(playlistNum)}\n")

        # get quick summary and bdinfo data
        bdObj.runbdinfo(playlistNum)
        quickSums = bdObj.getQuickSum()
        streams = bdObj.getStreams()
        chapters = bdObj.getChapters()

        for j in range(len(streams)):
            demuxData = siteDataPicker.pickSite(args.site)
            muxSorter = siteSortPicker.pickSite(args.site)
            stream = streams[j]
            # create a episode folder
            ep = i+j+offset+1
            newFolder = os.path.join(demuxFolder, str(ep))
            utils.mkdirSafe(newFolder)
            os.chdir(newFolder)
            print(f"Creating a new episode folder at {newFolder}\n")

            # create a source folder
            output = paths.createChildDemuxFolder(os.getcwd(), source)
            print(f"\nCreating a new source folder at {output}")
            os.chdir(output)
            show = utils.getShowName(source)
            path = os.path.join(output, "output_logs", f"BDINFO.{show}.txt")

            # copy bdinfo to folder
            print(f"\nParsing BDINFO from {source}")
            bdObj.writeBdinfo(path)

            currentTracks = demuxData.addTracks(quickSums, playlistNum, playlistFile,
                                                [stream], source, output)
            if not args.dontconvert:
                demuxData.convertFlac(currentTracks, output)

            tools.extractTracks(demuxData, stream=True)
            tools.sortTracks(muxSorter, demuxData, movie, args)
            tools.machineReader(muxSorter, args, movie)
            chaptersFiltered = list(
                filter(lambda x: x["start"] >= stream["start"], chapters))
            chaptersFiltered = list(
                filter(lambda x: x["start"] < stream["end"], chaptersFiltered))
            outdict = {}
            tools.addMovieData(outdict, movie, season, ep,)
            outdict["Sources"] = tools.addSourceData(demuxData)
            outdict["ChapterData"] = tools.ConvertChapterList(chaptersFiltered)
            tools.addEnabledData(outdict, muxSorter)
            tools.addTrackData(outdict, muxSorter)

            os.chdir(newFolder)
            tools.writeFinalJSON(outdict)
            # change pack to parent
            os.chdir(demuxFolder)


def batchSources(bdObjs, sources, args, demuxFolder, movie, season, offset=1):
    print("What TV Show?")
    # outter loop is for each episdoe
    for i in range(len(bdObjs[0].playlistNumList)):
        ep = i+offset+1
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
            show = utils.getShowName(source)
            path = os.path.join(output, "output_logs", f"BDINFO.{show}.txt")
            print(f"\nParsing BDINFO from {source}")
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
        tools.sortTracks(muxSorter, demuxData, movie, args)
        tools.machineReader(muxSorter, args, movie)
        outdict = {}
        tools.addMovieData(outdict, movie, season, ep)
        outdict["Sources"] = tools.addSourceData(demuxData)
        outdict["ChapterData"] = tools.ConvertChapterList(chapters)
        tools.addEnabledData(outdict, muxSorter)
        tools.addTrackData(outdict, muxSorter)
        os.chdir(newFolder)
        tools.writeFinalJSON(outdict)
    # change pack to parent
    os.chdir(demuxFolder)
