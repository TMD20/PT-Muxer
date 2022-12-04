import os
import itertools
import subprocess
import re

import tools.commands as commands
import tools.general as utils
import tools.paths as paths
import tools.directory as dir
    
def eac3toTrack(index,name,bdinfo,type):
    output = []
    output.append((f"{index}:{name}"))
    if re.search("LPCM|TrueHD|DTS-HD MA|DTS:.*?X", bdinfo, re.IGNORECASE) == None and type== "audio":
        output.append("-keepDialnorm")
    return output





def process(tracks,source, playlistFile):
    output=os.path.abspath(".") 
    eac3toPath = get_eac3toPath(output, source)
    playlistLocation=getPlaylistLocation(source,playlistFile)
    run(playlistLocation, tracks,eac3toPath)

def getPlaylistLocation(source,playlistFile):
    playlistFiles=paths.search(source,playlistFile)
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
    trackArgs =  trackArgs=["1:chapters.txt"]; [trackArgs.extend(eac3toTrack(track["index"],track["filename"],track["bdinfo_title"],track["type"])) for track in tracks]
    if getChaptersBool(playlistLocation)==False:   
        trackArgs = []; [trackArgs.extend(eac3toTrack(track["index"],track["filename"],track["bdinfo_title"],track["type"])) for track in tracks]
    playlistlocationFinal = paths.switchPathType(playlistLocation)  
    command1 = list(itertools.chain.from_iterable([commands.eac3to(), [
                    playlistlocationFinal], trackArgs, ["-progressnumbers", f"-log={eac3toPath}"]]))
    command2 = list(itertools.chain.from_iterable([commands.eac3to(), [
                    playlistlocationFinal], trackArgs, ["-progressnumbers", f"-log={eac3toPath}"]]))
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
