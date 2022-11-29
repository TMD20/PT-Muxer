
import os
import functools

import orjson

from pymediainfo import MediaInfo
import natsort

import remux.helpers as remuxHelper
import mediadata.movieData as movieData
import sites.pickers.siteMuxPicker as muxPicker
import tools.general as utils
import config

def ProcessBatch(fileName, remuxConfig, muxGenerator, outargs,special):
    # Variables
    chaptersTemp = remuxHelper.chapterListParser(remuxConfig["ChapterData"])
    xmlTemp = None

    season = remuxConfig["Movie"]["season"]
    episode = remuxConfig["Movie"]["episode"]
    title = remuxConfig['Movie'].get(
        'title') or remuxConfig['Movie'].get('engTitle')
    year = remuxConfig['Movie']['year']
    movieTitle = f"{title} ({year})"
  

    if not special:
        xmlTemp=remuxHelper.writeXMLTV(
            # imdb,tmdb,season,episode
            remuxConfig["Movie"]["imdb"], remuxConfig["Movie"]["tmdb"], title, year, season, episode)
    else:
        xmlTemp=remuxHelper.writeXMLMovie(
            remuxConfig["Movie"]["imdb"], remuxConfig["Movie"]["tmdb"])


    muxGenerator.generateMuxData(remuxConfig, outargs)
 

    if chaptersTemp:
        muxGenerator.createMKV(fileName, movieTitle,
                               chaptersTemp[1], xmlTemp[1],  utils.setBdInfo(remuxConfig), utils.getEac3to(remuxConfig))

        os.close(chaptersTemp[0])
    else:
        muxGenerator.createMKV(fileName, movieTitle,
                               None, xmlTemp[1],  utils.setBdInfo(remuxConfig), utils.getEac3to(remuxConfig))
    os.close(xmlTemp[0])

def getRemuxConfigPaths(folder):
    remuxConfigPaths=[]
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
    return remuxConfigPaths


def getRemuxConfigs(remuxConfigPaths):
    remuxConfigs=[]
    for remuxConfigPath in remuxConfigPaths:
        remuxConfig = None
        print(f"\nPreparing Data for {remuxConfigPath}\n")

        remuxConfig = None

        with open(remuxConfigPath, "r") as p:
            remuxConfig = orjson.loads(p.read())
        remuxHelper.getFullPaths(remuxConfig, os.path.dirname(remuxConfigPath))

        if remuxHelper.checkMissing(remuxConfig) == True:
            continue
        remuxConfigs.append(remuxConfig)
    return remuxConfigs


def getFileNameFuncts(remuxConfigs, args):
    fileNameFuncts=[]
    muxGenerator = muxPicker.pickSite(args.site)
    movieObj = movieData.MovieData()

    for remuxConfig in remuxConfigs:
        enTitle = remuxConfig['Movie'].get(
            'title') or remuxConfig['Movie'].get('engTitle')
        japTitle = remuxConfig['Movie'].get('japTitle')

        year = remuxConfig['Movie']['year']
        season = remuxConfig["Movie"]["season"]
        episode = remuxConfig["Movie"]["episode"]
        tmdb = remuxConfig["Movie"]["tmdb"]

        episodeTitle = movieObj.retriveEpisodeTitle(
            season, episode, enTitle, year, tmdb)
        if episodeTitle == "PlaceHolder Title" and japTitle:
            episodeTitle = movieObj.retriveEpisodeTitle(
                season, episode, japTitle, year, tmdb)

        if not args.special:
            fileNameFuncts.append(functools.partial(
                muxGenerator.getFileName, remuxConfig, args.group, enTitle, year, args.skipnamecheck, int(season), int(episode), episodeTitle))
        elif args.special:
            fileNameFuncts.append(functools.partial(
                muxGenerator.getFileName, remuxConfig, args.group, enTitle, year, args.skipnamecheck, episodeTitle=f"Special.{episode}", directory=f"{enTitle}.Specials"))
    return fileNameFuncts
