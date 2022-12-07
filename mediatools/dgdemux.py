import os
import itertools
import subprocess
import re

import tools.commands as commands
import tools.paths as paths
import tools.directory as dir
import tools.general as utils







def run(tracks,source, playlistFile,ep=False):
    if ep==False:
        _runNormal(tracks,source, playlistFile)
    else:
        _runEP(tracks,source, playlistFile)



def _runEP(tracks,source, playlistFile):
    playlistLocation=getPlaylistLocation(source,playlistFile)
    dgDemuxTracks=getTracks(playlistLocation)
    if abs(len(dgDemuxTracks)-len(tracks))>1:
        raise RuntimeError("Track Lengths are Missmatched")
    dgDex=0
    trackDex=0
    while dgDex<len(dgDemuxTracks) and trackDex<len(tracks):
        ele=dgDemuxTracks[dgDex]

        if re.search("Chapter",ele):
            _handleChapterEP(ele,playlistLocation)
            dgDex=dgDex+1
            continue
        normalTrack=tracks[trackDex]["filename"]
        if re.search("(\.dts$)",normalTrack,re.IGNORECASE):
            trackDex=trackDex+1
        elif re.search("(\.thd$)",normalTrack,re.IGNORECASE):
            compatTrack=tracks[trackDex+1]["filename"]
            _handleCompatEP(ele,normalTrack,compatTrack,playlistLocation)
            dgDex=dgDex+1 
            trackDex=trackDex+2 
        else:
            _handleNormalEP(ele,normalTrack,playlistLocation)
            dgDex=dgDex+1
            trackDex=trackDex+1
def _runNormal(tracks,source, playlistFile):
    playlistLocation=getPlaylistLocation(source,playlistFile)
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
def _handleChapterEP(ele,playlistLocation):
    tempDir=paths.createTempDir()
    print(f"batching chapter.txt")

    with dir.cwd(tempDir):
        command = (list(itertools.chain.from_iterable([commands.dgdemux(), ["-i",
                        playlistLocation,"-o",".","-demux",ele,"-ep"]])))
        status = 1
        with subprocess.Popen(command, stdout=subprocess.PIPE, stderr=subprocess.STDOUT, universal_newlines=True, bufsize=1) as p:
            for line in p.stdout or []:
                print(line, end='')
            p.wait()
            status = p.returncode
            if status !=0:
                raise RuntimeError("dgdemux had an Error")
    for index,ele in enumerate(paths.listdir(tempDir)):
        #create newpath with index
        with dir.cwd(os.path.join(".",str(index))):
            os.replace(paths.listdir(tempDir)[index],"chapter.txt")
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
def _handleNormalEP(ele,newFileName,playlistLocation):
    tempDir=paths.createTempDir()
    print(f"Batching {newFileName}")
    with dir.cwd(tempDir):
        command = (list(itertools.chain.from_iterable([commands.dgdemux(), ["-i",
                        playlistLocation,"-o",".","-demux",ele,"-ep"]])))
        status = 1
        with subprocess.Popen(command, stdout=subprocess.PIPE, stderr=subprocess.STDOUT, universal_newlines=True, bufsize=1) as p:
            for line in p.stdout or []:
                print(line, end='')
            p.wait()
            status = p.returncode
            if status !=0:
                raise RuntimeError("dgdemux had an Error")
    for index,ele in enumerate(paths.listdir(tempDir)):
        #create newpath with index
        with dir.cwd(os.path.join(".",str(index))):
            os.replace(ele,newFileName)       
   
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

def _handleCompatEP(ele,newNormalFileName,newCompatFileName,playlistLocation):
    tempDir=paths.createTempDir()
    print(f"Batching {newNormalFileName} and {newCompatFileName}")
    with dir.cwd(tempDir):
        command = (list(itertools.chain.from_iterable([commands.dgdemux(), ["-i",
                        playlistLocation,"-o",".","-demux",ele,"-ep"]])))
        status = 1
        with subprocess.Popen(command, stdout=subprocess.PIPE, stderr=subprocess.STDOUT, universal_newlines=True, bufsize=1) as p:
            for line in p.stdout or []:
                print(line, end='')
            p.wait()
            status = p.returncode
            if status !=0:
                raise RuntimeError("dgdemux had an Error")
    thd=paths.search(tempDir,"(\.thd)")
    compat=paths.search(tempDir,"",ignore=["\.thd"])
    

    for index in range(len(thd)):
        #create newpath with index
        with dir.cwd(os.path.join(".",str(index))):
            os.replace(thd[index],newNormalFileName)    
            os.replace(compat[index],newCompatFileName)    



   
    
    


  



