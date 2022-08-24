
import os
import re
import subprocess
import shutil
import functools
import itertools

import mediatools.extract as extract
import tools.general as utils
import config
import tools.commands as commands



def getBDMVs(path):
    currpath = os.getcwd()
    os.chdir(path)
    list1 = utils.findMatches(path, "STREAM")
    list2 = utils.findMatches(path, "*.iso")
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
    if os.path.exists(outpath):
        opts = ["Yes", "No"]
        remove = utils.singleSelectMenu(
            opts, f"Files already extraced\nDo you want to delete the folder:\n {outpath} ")
        if remove == "Yes":
            shutil.rmtree(outpath)
        else:
            return utils.findMatches(outpath, "STREAM")[0]
    commandlist = [functools.partial(extract.main, source, extract_to=outpath), functools.partial(powerISOExtractHelper, source, outpath), functools.partial(udevilExtractHelper, source, outpath)]
    for command in commandlist:
        try:
            command()
            break
        except Exception as e:
            print(e)
            continue
    if os.listdir(outpath)==0:
        print("Issue Extracting Files")
        quit()
    return utils.findMatches(outpath, "STREAM")[0]
def powerISOExtractHelper(source,outpath):
    command = list(itertools.chain.from_iterable([commands.poweriso(), ["extract",source, "/", "-od", outpath]]))
    with subprocess.Popen(command, stdout=subprocess.PIPE, stderr=subprocess.PIPE, universal_newlines=True, bufsize=1) as p:
            error=""
            msg=""
            for line in p.stdout:
                print(line, end='')
                msg=msg+line
            for line in p.stderr:
                print(line, end='')
                error=error+"line"
            p.wait()
            if len(error)>0:
               raise Exception(error)
            if re.search("Error occured",msg):
                raise Exception(msg)
          

        
    


def udevilExtractHelper(source,outpath):
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


