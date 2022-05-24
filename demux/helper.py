import os
import shutil
import re
import subprocess
from prompt_toolkit import prompt as input
from simple_term_menu import TerminalMenu

import mediatools.extract as extract
import general.util as util


def getFiles(path):
    currpath = os.getcwd()
    os.chdir(path)
    list1 = util.findFolders(path, "STREAM")
    list2 = util.findFiles(path, "\.iso")
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


def Extract(sources, inpath):
    temp = []
    validinputs = ["yes", "y", "Y", "YES", True]

    for file in sources:
        basename, ext = os.path.splitext(file)
        if ext == ".iso":
            print("Trying Extraction Module")
            try:
                extract.main(file)
                return
            except:
                None
            ##
            # Extraction Module Fails Extract with Sudo
            #
            try:
                print("Trying Mounting ISO\nThen Extracting")
                if not os.path.isdir("/mnt/iso"):
                    os.mkdir("/mnt/iso")
                if len(os.listdir("/mnt/iso")) > 0:
                    subprocess.run(
                        ["/usr/bin/sudo", "umount", "/mnt/iso"], subprocess.PIPE)
                subprocess.run(
                    ["/usr/bin/sudo", "mount", "/mnt/iso", file], stdout=subprocess.PIPE)
            except Exception as e:
                print(e)

            ##
            # Move Files From Mounted But to folder
            #

            try:
                newfolder = os.path.join(inpath, basename)
                if os.path.exists(newfolder):
                    remove = input("Do you want to delete the folder: ")
                    if remove in validinputs:
                        shutil.rmtree(newfolder)
                    else:
                        return
                shutil.copytree("/mnt/iso", os.path.join(inpath, basename))
            except Exception as e:
                print(e)

            ##
             #  Unmount directory
             #

            try:
                subprocess.run(
                    ["/usr/bin/sudo", "umount", "/mnt/iso"], subprocess.PIPE)
            except Exception as e:
                print(e)
            temp.append(os.path.join(inpath, basename))
        else:
            temp.append(file)
    return temp
