import json
import os
import functools

from pymediainfo import MediaInfo
import natsort

import remux.helper as remuxHelper
import mediadata.movieData as movieData
import sites.pickers.siteMuxPicker as muxPicker
import tools.general as utils
import config


def Remux(args):
    # Variables
    remuxConfigPaths = []
    remuxConfigs = []
    fileNameList = []
    fileNameFuncts = []
    muxGenerator = muxPicker.pickSite(args.site)
    movieObj = movieData.MovieData()

    folders = utils.getTVMuxFolders(args.inpath, config.demuxPrefix)
    if len(folders) == 0:
        print("You need to demux a folder with TV Mode first")
        quit()
    folder = utils.singleSelectMenu(folders, "Pick a folder to demux")
    remuxConfigPaths.extend(
        list(map(lambda x: os.path.join(folder, x, "output.json"), os.listdir(folder))))
    remuxConfigPaths = natsort.natsorted(remuxConfigPaths)
    msg =\
        """
    Pick one or more files to create a remux for
    Controls
    Space: Select
    Enter: Submit Selection
    Ctrl-R or Alt-R: Toggle All
    
    """
    remuxConfigPaths = utils.multiSelectMenu(remuxConfigPaths, msg)
#     # double check to make sure every path is current
    remuxConfigPaths = list(
        filter(lambda x: os.path.isfile(x), remuxConfigPaths))

    if not remuxConfigPaths or len(remuxConfigPaths) == 0:
        print("Their must be at least one output.json in the path")
        quit()

    utils.mkdirSafe(os.path.join(args.outpath, ""))
    os.chdir(args.outpath)
    for remuxConfigPath in remuxConfigPaths:
        print(f"\nPreparing Data for {remuxConfigPath}\n")

        remuxConfig = None

        with open(remuxConfigPath, "r") as p:
            remuxConfig = json.loads(p.read())

        if remuxHelper.checkMissing(remuxConfig) == True:
            continue
        remuxConfigs.append(remuxConfig)

        title = remuxConfig['Movie'].get(
            'title') or remuxConfig['Movie'].get('engTitle')
        year = remuxConfig['Movie']['year']
        season = remuxConfig["Movie"]["season"]
        episode = remuxConfig["Movie"]["episode"]
        episodeTitle = movieObj.retriveEpisodeTitle(
            season, episode, title, year)

        if args.forcemovie:
            fileNameFuncts.append(functools.partial(
                muxGenerator.getFileName, remuxConfig, args.group, title, year, args.skipnamecheck))
        else:
            fileNameFuncts.append(functools.partial(
                muxGenerator.getFileName, remuxConfig, args.group, title, year, args.skipnamecheck, int(season), int(episode), episodeTitle))

    for i in range(len(fileNameFuncts)):
        funct = fileNameFuncts[i]
        fileNameList.append(funct())
    print("\nAll Data is Prepared\nNext Step is Creating the MKV(s)")
    for i in range(len(fileNameList)):
        fileName = fileNameList[i]
        print(f"Creating this File\n{fileName}")
        muxGenerator = muxPicker.pickSite(args.site)
        remuxConfig = remuxConfigs[i]
        ProcessBatch(fileName,
                     remuxConfig, muxGenerator, movieObj, args.outargs)
    message = """If the Program made it this far all MKV(s)...
    Should be in the output directory picked \
    Before Closing We will now print off file locations and mediainfo"""
    print(message)
    for ele in fileNameList:
        print(f"New Files at {ele}\n")
        mediainfo = MediaInfo.parse(ele, output="", full=False)
        print(f"\n\n{mediainfo}\n\n")
    print(f"As a Reminder the output Directory is: {args.outpath}")


def ProcessBatch(fileName, remuxConfig, muxGenerator, movieObj, outargs):
    # Variables
    chaptersTemp = remuxHelper.chapterListParser(remuxConfig["ChapterData"])

    xmlTemp = None

    season = remuxConfig["Movie"]["season"]
    episode = remuxConfig["Movie"]["episode"]
    title = remuxConfig['Movie'].get(
        'title') or remuxConfig['Movie'].get('engTitle')
    year = remuxConfig['Movie']['year']
    movieTitle = f"{title} ({year})"

    xmlTemp = remuxHelper.writeXMLTV(
        # imdb,tmdb,season,episode
        remuxConfig["Movie"]["imdb"], remuxConfig["Movie"]["tmdb"], title, year, movieObj, season, episode)

    muxGenerator.generateMuxData(remuxConfig, outargs)

    if chaptersTemp:
        muxGenerator.createMKV(fileName, movieTitle,
                               chaptersTemp[1], xmlTemp[1],  utils.getBdinfo(remuxConfig), utils.getEac3to(remuxConfig))

        os.close(chaptersTemp[0])
    else:
        muxGenerator.createMKV(fileName, movieTitle,
                               None, xmlTemp[1],  utils.getBdinfo(remuxConfig), utils.getEac3to(remuxConfig))
    os.close(xmlTemp[0])
