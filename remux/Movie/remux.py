
import json
import os
import functools

from pymediainfo import MediaInfo

import remux.helper as remuxHelper
import mediadata.movieData as movieData
import sites.pickers.siteMuxPicker as muxPicker
import tools.general as utils
import config
import remux.Movie.anime as animeHelper


def Remux(args):
    # Variables
    remuxConfigPaths = []
    remuxConfigs = []
    movie = None

    folders = utils.getMovieMuxFolders(args.inpath, config.demuxPrefix)
    if len(folders) == 0:
        print("You need to demux a folder with Movie Mode first")
        quit()
    remuxConfigPaths.append(os.path.join(utils.singleSelectMenu(
        folders, "Pick a folder to demux"), "output.json"))
    # double check to make sure every path is current
    remuxConfigPaths = list(
        filter(lambda x: os.path.isfile(x), remuxConfigPaths))
    if not remuxConfigPaths or len(remuxConfigPaths) == 0:
        print("You Must Pick at list one Config")
        quit()

    fileNameList = []
    movieTitleList = []
    fileNameFuncts = []
    utils.mkdirSafe(os.path.join(args.outpath, ""))
    for remuxConfigPath in remuxConfigPaths:
        print(f"\nPreparing Data for {remuxConfigPath}\n")
        imdb = remuxConfig["Movie"].get("imdb")
        anisearch = remuxConfig["Movie"].get("anisearch")
        anidb = remuxConfig["Movie"].get("anidb")
        mal = remuxConfig["Movie"].get("mal")
        kitsu = remuxConfig["Movie"].get("kitsu")
        offset = remuxConfig["Movie"].get("offset")

        remuxConfig = None
        muxGenerator = muxPicker.pickSite(args.site)

        with open(remuxConfigPath, "r") as p:
            remuxConfig = json.loads(p.read())

        if remuxHelper.checkMissing(remuxConfig) == False:
            continue
        remuxConfigs.append(remuxConfig)
        if not imdb:
            animeHelper.getMovie(anisearch, anidb, mal, kitsu, offset)

        if movie == None:
            movie = movieData.getByID()
        kind = args.forcemovie or movieData.getKind(movie)
        os.chdir(args.outpath)

        fileNameFuncts.append(functools.partial(
            muxGenerator.getFileName, kind, remuxConfig, movie, args.group, args.skipnamecheck))
        movieTitleList.append(movieData.getMovieTitle(movie))
    for i in range(len(fileNameFuncts)):
        funct = fileNameFuncts[i]
        fileNameList.append(funct())
    print("\nAll Data is Prepared\nNext Step is Creating the MKV(s)")
    for i in range(len(fileNameList)):
        fileName = fileNameList[i]
        print(f"Creating this File\n{fileName}")
        movieTitle = movieTitleList[i]
        muxGenerator = muxPicker.pickSite(args.site)
        remuxConfig = remuxConfigs[i]
        ProcessBatch(fileName, movieTitle, kind,
                     remuxConfig, muxGenerator, args.outargs)
    message = """If the Program made it this far all MKV(s)...
    Should be in the output directory picked \
    Before Closing We will now print off file locations and mediainfo"""
    print(message)
    for ele in fileNameList:
        print(f"New Files at {ele}\n")
        mediainfo = MediaInfo.parse(ele, output="", full=False)
        print(f"\n\n{mediainfo}\n\n")
    print(f"As a Reminder the output Directory is: {args.outpath}")


def ProcessBatch(fileName, movieTitle, kind, remuxConfig, muxGenerator, outargs):
    # Variables
    chaptersTemp = remuxHelper.chapterListParser(remuxConfig["ChapterData"])

    xmlTemp = None
    if kind == "Movie":
        xmlTemp = remuxHelper.writeXMLMovie(
            remuxConfig["Movie"]["imdb"], remuxConfig["Movie"]["tmdb"])
    else:
        season = remuxConfig["Season"]
        episode = remuxConfig["Episode"]
        xmlTemp = remuxHelper.writeXMLTV(
            # imdb,tmdb,season,episode
            remuxConfig["Movie"]["imdb"], remuxConfig["Movie"]["tmdb"], season, episode)

    muxGenerator.generateMuxData(remuxConfig, outargs)
    if chaptersTemp:
        muxGenerator.createMKV(fileName, movieTitle,
                               chaptersTemp[1], xmlTemp[1],  utils.getBdinfo(remuxConfig), utils.getEac3to(remuxConfig))

        os.close(chaptersTemp[0])
    else:
        muxGenerator.createMKV(fileName, movieTitle,
                               None, xmlTemp[1],  utils.getBdinfo(remuxConfig), utils.getEac3to(remuxConfig))
    os.close(xmlTemp[0])
