import os

from pymediainfo import MediaInfo
import orjson


import remux.helpers as remuxHelper
import sites.pickers.siteMuxPicker as muxPicker
import tools.general as utils
import tools.paths as paths
import config
import remux.Movie.helpers as MovieHelper


def Remux(args):
    # Variables
    muxGenerator = muxPicker.pickSite(args.site)
    folders = remuxHelper.getMovieMuxFolders(args.inpath, config.demuxPrefix)
    if len(folders) == 0:
        print("You need to demux a folder with Movie Mode first")
        quit()
    remuxConfigPath = os.path.join(utils.singleSelectMenu(folders, "Pick the folder with the files you want to remux"), "output.json")
#     # double check to make sure every path is current
    if not remuxConfigPath:
        print("You Must Pick at list one Config")
        quit()
    paths.mkdirSafe(os.path.join(args.outpath, ""))
    os.chdir(args.outpath)
    print(f"\nPreparing Data for {remuxConfigPath}\n")
    remuxConfig = None

    with open(remuxConfigPath, "r") as p:
        remuxConfig = orjson.loads(p.read())
    remuxHelper.getFullPaths(remuxConfig, os.path.dirname(remuxConfigPath))

    if remuxHelper.checkMissing(remuxConfig) == True:
        return
    title = remuxConfig['Movie'].get(
        'title') or remuxConfig['Movie'].get('engTitle')
    year = remuxConfig['Movie']['year']

    fileName = muxGenerator.getFileName(
        remuxConfig, args.group, title, year, args.skipnamecheck)
    if remuxHelper.overwriteIfExists(fileName) == False:
        quit()

    MovieHelper.ProcessBatch(fileName, remuxConfig, muxGenerator, args.outargs)
    message = """If the Program made it this far the Movie MKV...
    Should be in the output directory picked \
    # Before Closing We will now print off file location and mediainfo"""
    print(message)
    mediainfo = MediaInfo.parse(fileName, output="", full=False)
    print(f"\n\n{mediainfo}\n\n")
    print(f"As a Reminder the output location: {fileName}")



