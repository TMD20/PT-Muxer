import os
import itertools
import subprocess
import re

import tools.commands as commands
import tools.general as utils
import tools.paths as paths
import tools.directory as dir
import tools.logger as logger
import tools.install as install
    
def process(tracks,source, file):
    if install.contyInstallCheckWine()==False:
        raise Exception("Wine or Conky Required for eac3to on Linux")
    output=os.path.abspath(".") 
    eac3toPath = get_eac3toPath(output, source)
    playlistLocation=_getFileHelper(source,file)
    run(playlistLocation, tracks,eac3toPath)


def eac3toTrack(index,name,bdinfotitle,type):
    output = []
    output.append((f"{index}:{name}"))
    if re.search("LPCM|TrueHD|DTS-HD MA|DTS:.*?X", bdinfotitle, re.IGNORECASE) == None and type== "audio":
        output.append("-keepDialnorm")
    return output







def _getFileHelper(source,file):
    if re.search("\.mpls",file,re.IGNORECASE):
        return _getPlaylistLocation(source,file)
    return _getStreamLocation(source,file)

def _getPlaylistLocation(source,playlistFile):
    playlistFiles=paths.search(source,playlistFile,ignore=["BACKUP"])
    if len(playlistFiles)>0:
        return playlistFiles[0]
    return ""
def _getStreamLocation(source,playlistFile):
    playlistFiles=paths.search(source,playlistFile,ignore=["BACKUP"])
    if len(playlistFiles)>0:
        return playlistFiles[0]
    return ""
def getChaptersBool(playlistLocation):
    with dir.cwd(paths.createTempDir()):
        playlistLocationFinal=paths.switchPathType(playlistLocation)
        command= list(itertools.chain.from_iterable([commands.eac3to(), [
                        playlistLocationFinal]]))
        out=""
        with subprocess.Popen(command, stdout=subprocess.PIPE, stderr=subprocess.STDOUT, universal_newlines=True, bufsize=1) as p:
            for line in p.stdout:
                out=f"{out} {line}"
            p.wait()
        return re.search("chapter",out,re.IGNORECASE)!=None
  



def run(playlistLocation, tracks,eac3toPath):

    # get list of files
    normalTracks=list(filter(lambda x:x["compat"]==False,tracks))
    compatTracks=list(filter(lambda x:x["compat"],tracks
    ))
    trackArgs=addTracks(normalTracks,compatTracks,playlistLocation)
    logger.logger.debug(str(trackArgs))
    playlistLocationFinal = paths.switchPathType(playlistLocation)  
    command1 = list(itertools.chain.from_iterable([commands.eac3to(), [
                    playlistLocationFinal], trackArgs, ["-progressnumbers", f"-log={eac3toPath}"]]))
    command2 = list(itertools.chain.from_iterable([commands.eac3to(), [
                    playlistLocationFinal], trackArgs, ["-progressnumbers", f"-log={eac3toPath}"]]))
    commandslist = [command1, command2]               
    status = 1
    for command in commandslist:
        with subprocess.Popen(command, stdout=subprocess.PIPE, stderr=subprocess.STDOUT, universal_newlines=True, bufsize=1) as p:
            for line in p.stdout:
                print(line, end='')
            p.wait()
            status = p.returncode
        if status == 0:
            cleanFiles(list(map(lambda x:x["filename"],tracks)))
            return
    
def addTracks(normalTracks,compatTracks,playlistLocation):
    index=1
    trackArgs=[]
    if getChaptersBool(playlistLocation)==True:
        index=2
        trackArgs.append("1:chapters.txt")
    for normalTrack in normalTracks:
        trackArgs.extend(eac3toTrack(index,normalTrack["filename"],normalTrack["bdinfo_title"],normalTrack["type"]))
        if normalTrack["childKey"]:
            compatTrack=list(filter(lambda x:x["key"]==normalTrack["childKey"],compatTracks))
            if compatTrack:
                compatTrack=compatTrack[0]
                trackArgs.extend(eac3toTrack(index,compatTrack["filename"],compatTrack["bdinfo_title"],compatTrack["type"]))
        index=index+1
    return trackArgs


  



def get_eac3toPath(output, source):
    show=utils.sourcetoShowName(source)
    txtPath= os.path.join(output, "output_logs", f"Eac3to.{show}.txt")
    paths.mkdirSafe(txtPath)
    return txtPath


def cleanFiles(outputs_list):
    outputs_list.append("chapters.txt")
    for file in os.listdir("."):
        if os.path.isfile(file) and file not in outputs_list:
            os.remove(file)
