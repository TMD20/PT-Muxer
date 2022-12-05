import os
import itertools
import subprocess
import re

import tools.commands as commands
import tools.paths as paths
import tools.directory as dir
import tools.general as utils






def process(tracks,source, playlistFile):
    playlistLocation=getPlaylistLocation(source,playlistFile)
    run(playlistLocation, tracks)

def getPlaylistLocation(source,playlistFile):
    playlistFiles=paths.search(source,playlistFile,ignore=["BACKUP"])
    if len(playlistFiles)>0:
        return playlistFiles[0]
    return ""
def getTracks(playlistLocation):
    output=""
    command = (list(itertools.chain.from_iterable([commands.dgdemux(), ["-i",
                        playlistLocation]])))
    status = 1
    with subprocess.Popen(command, stdout=subprocess.PIPE, stderr=subprocess.STDOUT, universal_newlines=True, bufsize=1) as p:
        for line in p.stdout or []:
            output=f"{output}\n{line}"
        p.wait()
        status = p.returncode
        if status !=0:
            raise RuntimeError("dgdemux had an Error")       
    outputList=output.split("\n")
    outputList=list(filter(lambda x: re.search("([0-9]{4}:|Chapters)",x),outputList))
    outputList=list(map(lambda x:re.sub(":.*","",x),outputList))
    return outputList







def run(playlistLocation, tracks):
    tempDir=paths.createTempDir()
    dgDemuxTracks=getTracks(playlistLocation)
    if abs(len(dgDemuxTracks)-len(tracks))>1:
        raise RuntimeError("Track Lengths are Missmatched")
    dgDex=0
    trackDex=0
    while dgDex<len(dgDemuxTracks) and trackDex<len(tracks):
        ele=dgDemuxTracks[dgDex]
        
        if re.search("Chapter",ele):
            _handleChapter(ele,playlistLocation)
            dgDex=dgDex+1
            continue
        normalTrack=tracks[trackDex]["filename"]
        if re.search("(\.dts$)",normalTrack,re.IGNORECASE):
            trackDex=trackDex+1
        elif re.search("(\.thd$)",normalTrack,re.IGNORECASE):
            compatTrack=normalTrack=tracks[trackDex+1]["filename"]
            _handleCompat(ele,normalTrack,compatTrack,playlistLocation)
            dgDex=dgDex+1 
            trackDex=trackDex+2 
        else:
            _handleNormal(ele,normalTrack,playlistLocation)
            dgDex=dgDex+1
            trackDex=trackDex+1
def _handleChapter(ele,playlistLocation):
    tempDir=paths.createTempDir()
    print(f"Processing {os.path.abspath('chapter.txt')}\n")

    with dir.cwd(tempDir):
        command = (list(itertools.chain.from_iterable([commands.dgdemux(), ["-i",
                        playlistLocation,"-o",".","-demux",ele]])))
        status = 1
        with subprocess.Popen(command, stdout=subprocess.PIPE, stderr=subprocess.STDOUT, universal_newlines=True, bufsize=1) as p:
            for line in p.stdout or []:
                print(line, end='')
            p.wait()
            status = p.returncode
            if status !=0:
                raise RuntimeError("dgdemux had an Error")
    os.replace(paths.listdir(tempDir)[0],"chapter.txt")

def _handleNormal(ele,newFileName,playlistLocation):
    tempDir=paths.createTempDir()
    print(f"Processing {os.path.abspath(newFileName)}\n")
    with dir.cwd(tempDir):
        command = (list(itertools.chain.from_iterable([commands.dgdemux(), ["-i",
                        playlistLocation,"-o",".","-demux",ele]])))
        status = 1
        with subprocess.Popen(command, stdout=subprocess.PIPE, stderr=subprocess.STDOUT, universal_newlines=True, bufsize=1) as p:
            for line in p.stdout or []:
                print(line, end='')
            p.wait()
            status = p.returncode
            if status !=0:
                raise RuntimeError("dgdemux had an Error")
    os.replace(paths.listdir(tempDir)[0],newFileName)    

def _handleCompat(ele,newNormalFileName,newCompatFileName,playlistLocation):
    tempDir=paths.createTempDir()
    print(f"Processing {os.path.abspath(newNormalFileName)} and {os.path.abspath(newCompatFileName)}\n")
    with dir.cwd(tempDir):
        command = (list(itertools.chain.from_iterable([commands.dgdemux(), ["-i",
                        playlistLocation,"-o",".","-demux",ele]])))
        status = 1
        with subprocess.Popen(command, stdout=subprocess.PIPE, stderr=subprocess.STDOUT, universal_newlines=True, bufsize=1) as p:
            for line in p.stdout or []:
                print(line, end='')
            p.wait()
            status = p.returncode
            if status !=0:
                raise RuntimeError("dgdemux had an Error")
    files=list(sorted(paths.listdir(),key=os.path.getsize))
    os.replace(files[0],newNormalFileName)    
    os.replace(files[1],newCompatFileName)  



   
    
    


  




# def cleanFiles(outputs_list):
#     outputs_list.append("chapters.txt")
#     for file in os.listdir("."):
#         if os.path.isfile(file) and file not in outputs_list:
#             os.remove(file)
