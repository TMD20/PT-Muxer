import os
import functools
from webbrowser import get

import orjson

from pymediainfo import MediaInfo
import natsort

import remux.helpers as remuxHelper
import sites.pickers.siteMuxPicker as muxPicker
import tools.general as utils
import tools.paths as paths

import config
import remux.TV.helpers as TVHelper
import tools.directory as dir
import tools.logger as logger




def Remux(args):
    # Variables
    fileNameList = []
    folders = remuxHelper.getTVMuxFolders(args.inpath, config.demuxPrefix)
    if len(folders) == 0:
        raise RuntimeError("You need to demux a folder with TV Mode first")
    folder = utils.singleSelectMenu(
        folders, "Pick the folder with the files you want to remux")

    remuxConfigPaths = TVHelper.getRemuxConfigPaths(folder)
    remuxConfigs = TVHelper.getRemuxConfigs(remuxConfigPaths)
    fileNameFuncts= TVHelper.getFileNameFuncts(remuxConfigs,args)
    paths.mkdirSafe(os.path.join(args.outpath, ""))
    with dir.cwd(args.outpath):
        if(len(fileNameFuncts) == 0):
            raise RuntimeError("No Files to Process")
        for i in range(len(fileNameFuncts)):
            funct = fileNameFuncts[i]
            fileNameList.append(funct())
        if remuxHelper.overwriteIfExists(*fileNameList)==False:
            logger.print("Keeping Current Files\nGood Bye")
            quit()
        logger.print("\nAll Data is Prepared\nNext Step is Creating the MKV(s)")
        for i in range(len(fileNameList)):
            fileName = fileNameList[i]
            logger.logger.info(f"Creating this File\n{fileName}")
            muxGenerator = muxPicker.pickSite(args.site)
            remuxConfig = remuxConfigs[i]
            TVHelper.ProcessBatch(fileName,
                            remuxConfig, muxGenerator, args.outargs,args.special)
        message = """If the Program made it this far all MKV(s)...
        Should be in the output directory picked \
        Before Closing We will now print off file locations and mediainfo"""
        logger.print(message)
        for ele in fileNameList:
            logger.logger.info(f"New File at {ele}\n")
            mediainfo = MediaInfo.parse(ele, output="", full=False)
            logger.print(f"\n\n{mediainfo}\n\n")
        logger.logger.info(f"As a Reminder the output location is: {os.path.dirname(fileNameList[0])}")


