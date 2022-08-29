import os
import functools
from webbrowser import get

import orjson

from pymediainfo import MediaInfo
import natsort

import remux.helpers as remuxHelper
import mediadata.movieData as movieData
import sites.pickers.siteMuxPicker as muxPicker
import tools.general as utils
import config
import remux.TV.helpers as TVHelper


def Remux(args):
    # Variables
    fileNameList = []
    folders = remuxHelper.getTVMuxFolders(args.inpath, config.demuxPrefix)
    if len(folders) == 0:
        print("You need to demux a folder with TV Mode first")
        quit()
    folder = utils.singleSelectMenu(
        folders, "Pick the folder with the files you want to remux")

    remuxConfigPaths = TVHelper.getRemuxConfigPaths(folder)
    remuxConfigs = TVHelper.getRemuxConfigs(remuxConfigPaths)
    fileNameFuncts= TVHelper.getFileNameFuncts(remuxConfigs,args)
    utils.mkdirSafe(os.path.join(args.outpath, ""))
    os.chdir(args.outpath)
    if(len(fileNameFuncts) == 0):
        print("No Files to Process")
        quit()
    for i in range(len(fileNameFuncts)):
        funct = fileNameFuncts[i]
        fileNameList.append(funct())
    if remuxHelper.overwriteIfExists(*fileNameList)==False:
        quit()
    print("\nAll Data is Prepared\nNext Step is Creating the MKV(s)")
    for i in range(len(fileNameList)):
        fileName = fileNameList[i]
        print(f"Creating this File\n{fileName}")
        muxGenerator = muxPicker.pickSite(args.site)
        remuxConfig = remuxConfigs[i]
        TVHelper.ProcessBatch(fileName,
                        remuxConfig, muxGenerator, args.outargs,args.special)
    message = """If the Program made it this far all MKV(s)...
    Should be in the output directory picked \
    Before Closing We will now print off file locations and mediainfo"""
    print(message)
    for ele in fileNameList:
        print(f"New File at {ele}\n")
        mediainfo = MediaInfo.parse(ele, output="", full=False)
        print(f"\n\n{mediainfo}\n\n")
    print(f"As a Reminder the output location is: {os.path.dirname(fileNameList[0])}")


