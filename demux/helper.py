import os
import re
import subprocess
import shutil

from guessit import guessit
from InquirerPy import inquirer

import mediatools.extract as extract
import tools.general as utils
import config


def getBDMVs(path):
    currpath = os.getcwd()
    os.chdir(path)
    list1 = utils.findMatches(path, "STREAM")
    list2 = utils.findMatches(path, "*.iso$")
    list1.extend(list2)
    os.chdir(currpath)
    return sorted(list1)


def createParentDemuxFolder(sources, outpath):
    title = guessit(sources[0])["title"]
    if len(sources) > 0:
        folder = f"{config.demuxPrefix}.{os.urandom(7).hex()}.{title}"
        parentDemux = os.path.join(outpath, folder)
        parentDemux = re.sub(" +", " ", parentDemux)
        parentDemux = re.sub(" ", ".", parentDemux)
        os.mkdir(parentDemux)
        return parentDemux
    else:
        print("You need to set Sources First")


def createChildDemuxFolder(parentDir, show):
    os.chdir(parentDir)
    show = utils.getShowName(show)

    show = re.sub(" ", ".", show)
    os.mkdir(show)
    return os.path.join(parentDir, show)


def addSource(paths,sortpref):
    if len(paths) == 0:
        print("No Valid Source Directories Found")
        quit()
    if sortpref=="size":
        msg = \
        """
        Click on the Source(s) You Want for this Demux 
        
        TV Mode will run multiple times 
        for more advanced source selection

        Press Space to add/remove selection
        Press Enter when Done
        """
        return utils.multiSelectMenu(paths, msg)
    else:
        msg = \
        """
        Since you selected --sortpref order 
        You will be prompted multiple times to make a selection
        Pay attention to the order of the list printed out, as this will effect enabled tracks

        Click on the Source You Want for this Demux
        For TV Shows you can change the Source(s) Per Episode

        When Finish Click 'I'm Done Selecting Sources'
        """
        list=["I'm done selecting sources","I want to reset my list"]
        list.extend(paths)
        selection=[]
        while True:
            print(f"Your list thus far\n\n")
            print("\n".join(selection))
            curr_select = utils.singleSelectMenu(list, msg)
            selection.append(curr_select)
            if curr_select == "I want to reset my list":
                selection=[]
            if curr_select=="I'm done selecting sources":
                break
        selection=list(filter(lambda x:x!="done" and x!=None))
        selection=utils.removeDupesList(selection)
        return selection
            



def getStartingPoint():
    return utils.getIntInput("You should select each playlist in order\nWhat Episode is the Starting point")


def CreateChapterList(*sources):
    path = None
    if len(sources) > 1:
        dir = utils.singleSelectMenu(
            sources, "Which Source Has The proper Chapter File")
        path = os.path.join(dir, "chapters.txt")
    else:
        path = os.path.join(sources[0], "chapters.txt")
    if not os.path.exists(path):
        return None
    with open(path, "r") as p:
        lines = p.readlines()
        i = 0
        output = []
        while i < len(lines):
            time = lines[i]
            name = lines[i+1]
            time = time.strip()
            name = name.strip()
            # Default chapter name
            numChapter = re.search("\d+", lines[i+1]).group(0)
            name = re.sub("NAME=", f"NAME=Chapter {numChapter}", name)
            output.append({"time": time, "name": name})
            i = i+2
        return output


def Extract(source, inpath):

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
            utils.mkdirSafe(f"/media/{os.getlogin()}")
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
                opts = ["Yes", "No"]
                remove = Menu(
                    opts, "Do you want to delete the folder:\n {newfolder} ")
                if remove == "Yes":
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
