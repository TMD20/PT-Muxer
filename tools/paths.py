import tempfile
import re
import os
import glob
import pathlib
import subprocess
import functools
import shutil
import itertools

import config as config
import tools.general as utils
import tools.commands as commands
def createTempDir():
    return tempfile.mkdtemp(prefix=config.tempPrefix, dir=config.tempFolder)
def getTempDirs():
    tmpHome=tempfile.gettempdir()
    tmpFiles=list(map(lambda x:os.path.join(tmpHome,x),os.listdir(tmpHome)))
    return list(filter(lambda x: re.search(x,config.tempPrefix) and os.path.isdir(x),tmpFiles))
def search(path,query,case=False,dir=False):
    paths = glob.glob(os.path.join(path, "**", "*"), recursive=True)
    paths=list(filter(lambda x:os.path.isdir(x)==dir,paths))
    if case:
        return list(filter(lambda x:re.search(query,x,re.IGNORECASE),paths))
    else:
        return list(filter(lambda x:re.search(query,x),paths))
def mkdirSafe(target):
    directories = list(reversed(pathlib.Path(target).parents))
    if len(os.path.splitext(target)[1]) == 0:
        directories.append(target)
    for ele in directories:
        if not os.path.exists(ele):
            os.mkdir(ele)
def rmSafe(path):
    if not os.path.exists(path):
        return
    if os.path.isfile(path):
        os.remove(path)
    else:
        shutil.rmtree(path)


def extractISO(source, inpath):
    basename = f"{os.path.basename(os.path.dirname(source))}_Extracted"
    outPath = os.path.join(inpath, basename)
    if os.path.exists(outPath):
        opts = ["Yes", "No"]
        remove = utils.singleSelectMenu(
            opts, f"Files already extraced\nDo you want to delete the folder:\n {outPath} ")
        if remove == "Yes":
            rmSafe(outPath)
        else:
            return search(outPath, "STREAM",dir=True)[0]
    mkdirSafe(outPath)
    commandlist = [functools.partial(
        ISOBinaryExtractHelper, source, outPath), functools.partial(udevilExtractHelper, source, outPath)]

    for command in commandlist:
        try:
            command()
            break
        except Exception as e:
            print(e)
            rmSafe(outPath)
            continue
    if os.listdir(outPath) == 0:
        print("Issue Extracting Files")
        quit()
    return utils.findMatches(outPath, "STREAM")[0]


def ISOBinaryExtractHelper(source, outPath):
    command = list(itertools.chain.from_iterable([commands.isoBinary(), [
                   "x", utils.convertPathType(source, "Linux"),  "-bsp1","-y" ,f"-o{outPath}", ]]))
    with subprocess.Popen(command) as p:
        p.wait()
        if p.returncode!=0:
            raise Exception("7z Extraction Error")

def udevilExtractHelper(source, outPath):
    print("\nTrying Mounting ISO\nThen Extracting")
    mountpoint = f"/media/{os.getlogin()}/custom"
    mkdirSafe(f"/media/{os.getlogin()}")
    if os.path.exists(mountpoint):
        subprocess.run(
            ["udevil", "umount", mountpoint], subprocess.PIPE)
    subprocess.run(
        ["udevil", "mount", source, mountpoint], stdout=subprocess.PIPE)

    shutil.copytree(mountpoint, os.path.join(outPath))
    subprocess.run(
        ["udevil", "umount", mountpoint], subprocess.PIPE)

