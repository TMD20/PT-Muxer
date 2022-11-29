import os

import sites.pickers.siteDataPicker as siteDataPicker
import sites.pickers.siteSortPicker as siteSortPicker
import mediadata.movieData as movieData
import tools.general as utils
import demux.tools as tools
import demux.Movie.helper as demuxHelper
import tools.paths as paths

def demux(args):
    parentDir=None
    try:
        args.audiolang = list(map(lambda x: x.lower(),  args.audiolang))
        args.sublang = list(map(lambda x: x.lower(),  args.sublang))
    

        # make the output directory if needed
        paths.mkdirSafe(args.outpath)
        os.chdir(args.outpath)

        options = paths.getBDMVs(args.inpath)
        demuxData = siteDataPicker.pickSite(args.site)
        muxSorter = siteSortPicker.pickSite(args.site)
        print("Getting Source(s) For Movie Demux\n")

        sources = demuxHelper.getSources(options, args.inpath, args.sortpref)

        movieObj = movieData.MovieData()

        movieObj.setData("Movie",utils.getTitle(sources[0]))
        print("Creating Demux Folder at\n")
        parentDir = paths.createParentDemuxFolder(sources, args.outpath)
        os.chdir(parentDir)
        print(os.path.abspath("."))

        bdObjs = demuxHelper.setBdInfoData(sources)
        tools.validateBdinfo(bdObjs)
        demuxHelper.processBdinfo(sources, bdObjs, demuxData, args.dontconvert)

        tools.extractTracks(demuxData)
        tools.sortTracks(muxSorter, demuxData, movieObj.movieObj, args)
        tools.machineReader(muxSorter, args, movieObj.movieObj)

        match = bdObjs[0].mediaDir
        if len(bdObjs) > 1:
            match = utils.singleSelectMenu(
                list(map(lambda x: x.mediaDir, bdObjs)), "Which Source Has The proper Chapter File")
        chapters = list(filter(lambda x: x.mediaDir == match, bdObjs))[0].chapters

        outdict = {}
        outdict["Sources"] = tools.addSourceData(demuxData)
        outdict["ChapterData"] = tools.ConvertChapterList(chapters)
        outdict["Movie"] = movieObj.movieObj
        tools.addEnabledData(outdict, muxSorter)
        tools.addTrackData(outdict, muxSorter)
        tools.writeFinalJSON(outdict)
    except Exception as e:
        print(e)
        if os.path.exists(parentDir):
            utils.rmDir(parentDir)
