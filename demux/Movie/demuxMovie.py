import os

import sites.pickers.siteDataPicker as siteDataPicker
import sites.pickers.siteSortPicker as siteSortPicker
import mediadata.movieData as movieData
import tools.general as utils
import demux.paths as paths
import demux.select as select
import demux.tools as tools
import demux.Movie.helper as demuxHelper




def demux(args):
    args.audiolang = list(map(lambda x: x.lower(),  args.audiolang))
    args.sublang = list(map(lambda x: x.lower(),  args.sublang))

    # make the output directory if needed
    utils.mkdirSafe(args.outpath)
    os.chdir(args.outpath)

    options = paths.getBDMVs(args.inpath)
    demuxData = siteDataPicker.pickSite(args.site)
    muxSorter = siteSortPicker.pickSite(args.site)
    print("Getting Source(s) For Movie Demux\n")

    sources = select.getSources(options, args.inpath, args.sortpref)
    print("What Movie?\n\n")
    movie = movieData.matchMovie(sources)
    print("Creating Demux Folder at\n")
    os.chdir(paths.createParentDemuxFolder(sources, args.outpath))
    print(os.path.abspath("."))

    bdObjs = demuxHelper.getBdinfoData(sources)
    tools.validateBdinfo(bdObjs)
    demuxHelper.processBdinfo(sources, bdObjs, demuxData, args.dontconvert)
    
    
    tools.extractTracks(demuxData)
    tools.sortTracks(muxSorter, demuxData, movie, args)
    tools.machineReader(muxSorter, args, movie)

    match = bdObjs[0].mediaDir
    if len(bdObjs) > 1:
            match = utils.singleSelectMenu(
                list(map(lambda x: x.mediaDir, bdObjs)), "Which Source Has The proper Chapter File")
    chapters = list(filter(lambda x: x.mediaDir == match, bdObjs))[0].chapters

    outdict = {}
    tools.addMovieData(outdict,movie)
    outdict["Sources"] = tools.addSourceData(demuxData)
    outdict["ChapterData"] = tools.ConvertChapterList(chapters)
    tools.addEnabledData(outdict,muxSorter)
    tools.addTrackData(outdict,muxSorter)
    tools.writeFinalJSON(outdict)
           
 


















