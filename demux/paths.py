import os
import re
import subprocess
import shutil

import mediatools.extract as extract
import tools.general as utils
import config


def getBDMVs(path):
    currpath = os.getcwd()
    os.chdir(path)
    list1 = utils.findMatches(path, "STREAM")
    list2 = utils.findMatches(path, "*.iso$")
    list1.extend(list2)
    list1=list(map(lambda x:utils.getPathType(x,"Linux"),list1))
    os.chdir(currpath)
    return sorted(list1)


def createParentDemuxFolder(sources, outpath):

    title = utils.getTitle(sources[0])
    folder = f"{config.demuxPrefix}.{os.urandom(7).hex()}.{title}"
    parentDemux = os.path.join(outpath, folder)
    parentDemux = re.sub(" +", " ", parentDemux)
    parentDemux = re.sub(" ", ".", parentDemux)
    parentDemux=utils.getPathType(parentDemux,"Linux")
    os.mkdir(parentDemux)
    return parentDemux



def createChildDemuxFolder(parentDir, show):
    os.chdir(parentDir)
    show = utils.sourcetoShowName(show)
    os.mkdir(show)
    return utils.getPathType( os.path.join(parentDir, show),"Linux")


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
                remove = utils.singleSelectMenu(
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



