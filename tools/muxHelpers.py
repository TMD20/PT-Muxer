import os
import shutil
import re
import subprocess

from prompt_toolkit import prompt as input
from simple_term_menu import TerminalMenu
from pymediainfo import MediaInfo

import mediatools.extract as extract
import tools.general as util


def getFiles(path):
    currpath = os.getcwd()
    os.chdir(path)
    list1 = util.findFolders(path, "STREAM")
    list2 = util.findFiles(path, "\.iso$")
    list1.extend(list2)
    return list1


def addSources(paths):
    # duple check this works
    sources = []
    menu = TerminalMenu(paths)
    addsource = True
    validinputs = ["yes", "y", "Y", "YES", True]
    while addsource in validinputs:
        menu_index = menu.show()
        dir = paths[menu_index]
        sources.append(dir)
        addsource = input("Add Another Sources for this Release?: ")
    res = []
    [res.append(x) for x in sources if x not in res]
    return res


def createParentDemuxFolder(sources, outpath):
    if len(sources) > 0:
        folder = f"Mux.{os.urandom(7).hex()}.{util.getShowName(list(dict.fromkeys(sources))[0])}"

        parentDemux = os.path.join(outpath, folder)
        os.mkdir(parentDemux)
        return parentDemux
    else:
        print("You need to set Sources First")


def createChildDemuxFolder(parentDir, show):
    os.chdir(parentDir)
    show = util.getShowName(show)
    show = re.sub(" ", ".", show)
    os.mkdir(show)
    return os.path.join(parentDir, show)


def Extract(source, inpath):

    validinputs = ["yes", "y", "Y", "YES", True]

    basename = f"{os.path.basename(os.path.dirname(source))}_Extracted"
    outpath = os.path.join(inpath, basename)

    if re.search("iso", source):
        print("\nTrying Extraction Module")
        try:
            extract.main(source)
            return
        except:
            None

        ##
        # Extraction Module Fails Extract with Sudo
        #
        try:
            print("\nTrying Mounting ISO\nThen Extracting")
            mountpoint = f"/media/{os.getlogin()}/custom"
            util.mkdirSafe(f"/media/{os.getlogin()}")
            if os.path.exists(mountpoint):
                subprocess.run(
                    ["udevil", "umount", mountpoint], subprocess.PIPE)
            subprocess.run(
                ["udevil", "mount", source, mountpoint], stdout=subprocess.PIPE)
        except Exception as e:
            print(e)

        ##
        # Move Files From Mounted But to folder
        #

        try:
            newfolder = os.path.join(inpath, basename)
            if os.path.exists(newfolder):
                remove = input(
                    f"Do you want to delete the folder:\n {newfolder} ")
                if remove in validinputs:
                    shutil.rmtree(newfolder)
                else:
                    return
            shutil.copytree(mountpoint, os.path.join(inpath, basename))

        except Exception as e:
            print(e)

        ##
        #  Unmount directory
        #

        try:
            subprocess.run(
                ["udevil", "umount", mountpoint], subprocess.PIPE)
        except Exception as e:
            print(e)

    return outpath


def getOutputList(path):
    demuxList = []
    for tuple in os.walk(path):
        dir = tuple[0]
        files = tuple[2]
        for file in files:
            if file == "output.txt":
                demuxList.append(os.path.join(dir, file))
    return demuxList


def pickOutput(demuxList):
    if len(demuxList) == 0:
        print("Deep Search of Directory Could Not Find any output.txt Files")
        quit()
    return demuxList[TerminalMenu(demuxList).show()]


def getSources(remuxConfig):
    list = [key for key in remuxConfig["sources"]]
    return list


def getChapterFile(remuxConfig):
    keys = list(remuxConfig["sources"].keys())
    print("Which Source Has The proper Chapter File")
    key = keys[TerminalMenu(keys).show()]
    return os.path.join(remuxConfig["sources"][key]["outputDir"], "chapters.txt")


def getBdinfo(remuxConfig):
    key = str(remuxConfig["Enabled_Tracks"]["Video"][0])
    output = os.path.dirname(
        remuxConfig["Tracks_Details"]["Video"][key]["file"])
    for file in os.listdir(os.path.join(output, "output_logs")):
        if re.search("bdinfo", file, re.IGNORECASE):
            return os.path.join(output, "output_logs", file)


def getEac3to(remuxConfig):
    key = str(remuxConfig["Enabled_Tracks"]["Video"][0])
    output = os.path.dirname(
        remuxConfig["Tracks_Details"]["Video"][key]["file"])
    for file in os.listdir(os.path.join(output, "output_logs")):
        if re.search("eac3to", file, re.IGNORECASE):
            return os.path.join(output, "output_logs", file)


def getMediaInfo(mkv):
    return MediaInfo.parse(mkv, output="", full=False)
