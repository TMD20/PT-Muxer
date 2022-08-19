
import json
import os

from pymediainfo import MediaInfo

import remux.helper as remuxHelper
import sites.pickers.siteMuxPicker as muxPicker
import tools.general as utils
import config


def Remux(args):
    # Variables
    muxGenerator = muxPicker.pickSite(args.site)
    folders = remuxHelper.getMovieMuxFolders(args.inpath, config.demuxPrefix)
    if len(folders) == 0:
        print("You need to demux a folder with Movie Mode first")
        quit()
    remuxConfigPath = os.path.join(utils.singleSelectMenu(
        folders, "Pick the folder with the files you want to remux"), "output.json")
#     # double check to make sure every path is current
    if not remuxConfigPath:
        print("You Must Pick at list one Config")
        quit()
    utils.mkdirSafe(os.path.join(args.outpath, ""))
    os.chdir(args.outpath)
    print(f"\nPreparing Data for {remuxConfigPath}\n")
    remuxConfig = None

    with open(remuxConfigPath, "r") as p:
        remuxConfig = json.loads(p.read())
    remuxHelper.getFullPaths(remuxConfig, os.path.dirname(remuxConfigPath))

    if remuxHelper.checkMissing(remuxConfig) == True:
        return
    title = remuxConfig['Movie'].get(
        'title') or remuxConfig['Movie'].get('engTitle')
    year = remuxConfig['Movie']['year']

    fileName = muxGenerator.getFileName(
        remuxConfig, args.group, title, year, args.skipnamecheck)
    

    ProcessBatch(fileName, remuxConfig, muxGenerator, args.outargs)
    message = """If the Program made it this far the Movie MKV...
    Should be in the output directory picked \
    # Before Closing We will now print off file location and mediainfo"""
    print(message)
    mediainfo = MediaInfo.parse(fileName, output="", full=False)
    print(f"\n\n{mediainfo}\n\n")
    print(f"As a Reminder the output Directory is: {args.outpath}")


def ProcessBatch(fileName, remuxConfig, muxGenerator, outargs):
    # Variables
    chaptersTemp = remuxHelper.chapterListParser(remuxConfig["ChapterData"])
    xmlTemp = remuxHelper.writeXMLMovie(
        remuxConfig["Movie"]["imdb"], remuxConfig["Movie"]["tmdb"])

    muxGenerator.generateMuxData(remuxConfig, outargs)
    title = remuxConfig['Movie'].get(
        'title') or remuxConfig['Movie'].get('engTitle')
    year = remuxConfig['Movie']['year']
    movieTitle = f"{title} ({year})"
    if chaptersTemp:
        muxGenerator.createMKV(fileName, movieTitle,
                               chaptersTemp[1], xmlTemp[1],  utils.getBdinfo(remuxConfig), utils.getEac3to(remuxConfig))

        os.close(chaptersTemp[0])
    else:
        muxGenerator.createMKV(fileName, title, year,
                               None, xmlTemp[1],  utils.getBdinfo(remuxConfig), utils.getEac3to(remuxConfig))
    os.close(xmlTemp[0])
