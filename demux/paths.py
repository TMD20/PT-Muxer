

import os
import re
import subprocess
import shutil
import functools
import itertools

import tools.general as utils
import config
import tools.commands as commands


def getBDMVs(path):
    currpath = os.getcwd()
    os.chdir(path)
    list1 = utils.findMatches(path, "STREAM")
    list2 = utils.findMatches(path, "*.iso")
    list1.extend(list2)
    list1 = list(map(lambda x: utils.convertPathType(x, "Linux"), list1))
    os.chdir(currpath)
    return sorted(list1)


def createParentDemuxFolder(sources, outpath):

    title = utils.getTitle(sources[0])
    folder = f"{config.demuxPrefix}.{utils.getFormated('YY.MM.DD_HH:mm.ss')}.{title}"
    parentDemux = os.path.join(outpath, folder)
    parentDemux = re.sub(" +", " ", parentDemux)
    parentDemux = re.sub(" ", ".", parentDemux)
    parentDemux = utils.convertPathType(parentDemux, "Linux")
    print(f"Creating a new Parent Directory for TV Show ->{parentDemux}")
    os.mkdir(parentDemux)
    return parentDemux


def createChildDemuxFolder(parentDir, show):
    os.chdir(parentDir)
    show = utils.sourcetoShowName(show)
    os.mkdir(show)
    return utils.convertPathType(os.path.join(parentDir, show), "Linux")


def extractISO(source, inpath):
    basename = f"{os.path.basename(os.path.dirname(source))}_Extracted"
    outpath = os.path.join(inpath, basename)
    if os.path.exists(outpath):
        opts = ["Yes", "No"]
        remove = utils.singleSelectMenu(
            opts, f"Files already extraced\nDo you want to delete the folder:\n {outpath} ")
        if remove == "Yes":
            utils.rmDir(outpath)
        else:
            return utils.findMatches(outpath, "STREAM")[0]
    commandlist = [functools.partial(
        ISOBinaryExtractHelper, source, outpath), functools.partial(udevilExtractHelper, source, outpath)]

    for command in commandlist:
        try:
            command()
            break
        except Exception as e:
            print(e)
            continue
    if os.listdir(outpath) == 0:
        print("Issue Extracting Files")
        quit()
    return utils.findMatches(outpath, "STREAM")[0]


def ISOBinaryExtractHelper(source, outpath):
    command = list(itertools.chain.from_iterable([commands.isoBinary(), [
                   "x", utils.convertPathType(source, "Linux"),  "-bsp1","-y" ,f"-o{outpath}", ]]))
    with subprocess.Popen(command) as p:
        if p.returncode!=0:
            raise Exception("7z Extraction Error")

def udevilExtractHelper(source, outpath):
    print("\nTrying Mounting ISO\nThen Extracting")
    mountpoint = f"/media/{os.getlogin()}/custom"
    utils.mkdirSafe(f"/media/{os.getlogin()}")
    if os.path.exists(mountpoint):
        subprocess.run(
            ["udevil", "umount", mountpoint], subprocess.PIPE)
    subprocess.run(
        ["udevil", "mount", source, mountpoint], stdout=subprocess.PIPE)

    shutil.copytree(mountpoint, os.path.join(outpath))
    subprocess.run(
        ["udevil", "umount", mountpoint], subprocess.PIPE)
