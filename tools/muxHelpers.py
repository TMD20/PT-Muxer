import os
import shutil
import re
import subprocess
import tempfile
from string import Template

from prompt_toolkit import prompt as input
from simple_term_menu import TerminalMenu
from pymediainfo import MediaInfo
from guessit import guessit


import mediatools.extract as extract
import tools.general as util
import mediadata.movieData as movieData

def getFiles(path):
    currpath = os.getcwd()
    os.chdir(path)
    list1 = util.findFolders(path, "STREAM")
    list2 = util.findFiles(path, "\.iso$")
    list1.extend(list2)
    os.chdir(currpath)
    return list1


 



def addSources(paths):
    # duple check this works
    sources = []
    user_options=["YES","NO"]


    addsource = "YES"
    while addsource=="YES":
        dir =paths[Menu(paths)]
        sources.append(dir)
        print("Add Another Source?\n")
        addsource = user_options[Menu(user_options)]
    res = []
    [res.append(x) for x in sources if x not in res]
    return res


def createParentDemuxFolder(sources, outpath):
    title = guessit(sources[0])["title"]
    if len(sources) > 0:
        folder = f"Mux.{os.urandom(7).hex()}.{title}"
        parentDemux = os.path.join(outpath, folder)
        parentDemux=re.sub(" +"," ",parentDemux)
        parentDemux=re.sub(" ",".",parentDemux)
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
            if file == "output.json":
                demuxList.append(os.path.join(dir, file))
    return demuxList


def pickOutput(demuxList):
    if len(demuxList) == 0:
        print("Deep Search of Directory Could Not Find any output.json Files")
        quit()
    return demuxList[Menu(demuxList)]


def getSources(remuxConfig):
    list = [key for key in remuxConfig["Sources"]]
    return list


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


def CreateChapterList(*sources):
    path=None
    if len(sources)>1:
        print("Which Source Has The proper Chapter File")
        dir=sources[Menu(sources)]
        path = os.path.join(dir,"chapters.txt")
    else:
        path = os.path.join(sources[0], "chapters.txt")
    with open(path, "r") as p:
        lines = p.readlines()
        i = 0
        output = []
        while i < len(lines):
            time= lines[i]
            name = lines[i+1]
            time = time.strip()
            name= name.strip()
            #Default chapter name
            numChapter = re.search("\d+", lines[i+1]).group(0)
            name=re.sub("NAME=",f"NAME=Chapter {numChapter}",name)
            output.append({"time": time, "name": name})
            i = i+2
        return output


def chapterListParser(chapterList):
    tempData = tempfile.mkstemp()
    file=tempData[1]
    with open(file,"w") as p:
        for dict in chapterList:
            p.write(dict["time"])
            p.write("\n")
            p.write(dict["name"])
            p.write("\n")
    return tempData

def writeXMLMovie(imdb,tmdb):
    infile=os.path.join(util.getRootDir(),f"xml/movie")
    
    tempData= tempfile.mkstemp()
    outfile=tempData[1]
    result=None
    with open(infile, 'r') as f:
        src = Template(f.read())
        result = src.substitute({"imdb":imdb,"tmdb":tmdb})
    with open(outfile, "w") as p:
        p.writelines(result)
    return tempData

def writeXMLTV(imdb,tmdb,season,episode):
    infile=os.path.join(util.getRootDir(),f"xml/movie")
    tempData= tempfile.mkstemp()
    outfile=tempData[1]
    result=None

    imdbEP=movieData.getEpisode(movieData.getByID(imdb),season,episode)["imdbID"]
    totalEP=movieData.getTotalEpisodes(movieData.getByID(imdb), season)


    with open(infile, 'r') as f:
        src = Template(f.read())
        result = src.substitute({"imdb":imdb,"tmdb":tmdb,"imdbEP":imdbEP,"totalEP":totalEP})
    with open(outfile, "w") as p:
        p.writelines(result)
    return tempData
def Menu(items):
    menu = TerminalMenu(items)
    return menu.show()
  


    

