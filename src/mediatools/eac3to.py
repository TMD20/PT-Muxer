from __future__ import annotations 
from typing import TYPE_CHECKING, List,Union,Callable

import os
import itertools
import subprocess
import re


import src.tools.commands as commands
import src.tools.general as utils
import src.tools.paths as paths
import src.tools.directory as dir
import src.tools.logger as logger
import src.tools.install as install
if TYPE_CHECKING:
    import mediadata.trackObj as trackObj

    
def process(tracks:List[trackObj.TrackObJ],source:Union[str, bytes, os.PathLike], playlistfile:Union[str, bytes, os.PathLike])->None:
    """
    Runner to extract tracks with eac3to

    Args:
        tracks (array): A list of trackerobjs
        source (str): bdmv source
        playlistfile (str): location of playlist file

    Raises:
        Exception: Exception raised if wine or conky can't be found on Linux systems
    """
    if install.contyInstallCheckWine()==False:
        raise Exception("Wine or Conky Required for eac3to on Linux")
    output=os.path.abspath(".") 
    eac3toPath = get_eac3toPath(output, source)
    playlistLocation=_getFileHelper(source,playlistfile)
    run(playlistLocation, tracks,eac3toPath)


def eac3toTrack(index:int,name:str,bdinfotitle:str,type:List[str])->str:
    """
    Generates track name argument to be passed to eac3to
    Adds additional arguments for an individual track if required

    Args:
        index (int): index of track as required by eac3to
        name (str): name of track with correct ext as required by eac3to
        bdinfotitle (str): A title of track based on bdinfo
        type (str): type of track 

    Returns:
       array: array of strings with including eac3to compatible file name
    """
    output = []
    output.append((f"{index}:{name}"))
    if re.search("LPCM|TrueHD|DTS-HD MA|DTS:.*?X", bdinfotitle, re.IGNORECASE) == None and type== "audio":
        output.append("-keepDialnorm")
    return output







def _getFileHelper(source:Union[str, bytes, os.PathLike],file:str)->Callable[..., str]:
    """
    Helper to get playlist or stream location based on source location and playlistname

    Args:
        source (str): bdmv source
        file (str): name of file for playlist or stream

    Returns:
        function: Returns a function based on filename
    """
    if re.search("\.mpls",file,re.IGNORECASE):
        return _getPlaylistLocation(source,file)
    return _getStreamLocation(source,file)

def _getPlaylistLocation(source:Union[str, bytes, os.PathLike],playlistFile:str)->str:
    """
    Searches source directory recursively for matching playlist file

    Args:
        source (str): bdmv directory
        playlistFile (str): name of a playlist mpls file

    Returns:
        str: full path to playlist file
    """
    playlistFiles=paths.search(source,playlistFile,ignore=["BACKUP"])
    if len(playlistFiles)==0:
        return ""
    playlistFile=playlistFiles[0]
    return paths.convertPathType(playlistFile,type="Windows")
def _getStreamLocation(source:Union[str, bytes, os.PathLike],playlistFile:str):
    """
     Searches source directory recursively for matching stream file

    Args:
        source (str): bdmv directory
        playlistFile (str): name of a stream mt2s
    Returns:
        str: full path to stream file
    """    
    playlistFiles=paths.search(source,playlistFile,ignore=["BACKUP"])
    if len(playlistFiles)==0:
        return ""
    playlistFile=playlistFiles[0]
    return paths.convertPathType(playlistFile,type="Windows")
def getChaptersBool(playlistLocation:Union[str, bytes, os.PathLike])->bool:
    """
    Checks for the existence of chapters on a playlist, based on eac3to output of the playlist

    Args:
        playlistLocation (str): playlist to asses 
    Returns:
        bool: returns True if chapter file is found based on eac3to output
    """
    with dir.cwd(paths.createTempDir()):
        command= list(itertools.chain.from_iterable([commands.eac3to(), [
                        playlistLocation]]))
        out=""
        with subprocess.Popen(command, stdout=subprocess.PIPE, stderr=subprocess.STDOUT, universal_newlines=True, bufsize=1) as p:
            for line in p.stdout:
                out=f"{out} {line}"
            p.wait()
        return re.search("chapter",out,re.IGNORECASE)!=None
  



def run(playlistLocation:Union[str, bytes, os.PathLike], tracks:List[trackObj.TrackObJ],eac3toPath:Union[str, bytes, os.PathLike])->None:
    """
    Generates eac3to commands and runs in subprocess

    Args:
        playlistLocation (str): location of playlist to pass to eac3to must match tracks
        tracks (array): list of tracksObjs to pass to eac3to
        eac3toPath (str): path for eac3to log file
    """

    # get list of files
    normalTracks=list(filter(lambda x:x["compat"]==False,tracks))
    compatTracks=list(filter(lambda x:x["compat"],tracks
    ))
    trackArgs=_addTracks(normalTracks,compatTracks,playlistLocation)
    logger.logger.debug(str(trackArgs))
    command1 = list(itertools.chain.from_iterable([commands.eac3to(), [
                    playlistLocation], trackArgs, ["-progressnumbers", f"-log={eac3toPath}"]]))
    command2 = list(itertools.chain.from_iterable([commands.eac3to(), [
                    playlistLocation], trackArgs, ["-progressnumbers", "-demux",f"-log={eac3toPath}"]]))
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
    
def _addTracks(normalTracks:List[trackObj.TrackObJ],compatTracks:List[trackObj.TrackObJ],playlistLocation:Union[str, bytes, os.PathLike])->List[str]:
    """
    Generates eac3to compatible list of track extraction arguments into an array

    Args:
        normalTracks (array): video,sub, and audio tracks marked as normal
        compatTracks (array): audio tracks marked as compat
        playlistLocation (str): playlist location must match tracks

    Returns
        array: list of eac3to track extraction arguments to be passed to subprocess
    """
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


  



def get_eac3toPath(output:Union[str, bytes, os.PathLike], source:Union[str, bytes, os.PathLike])->str:
    """
    Gets an path within output folder to store eac3to log

    Args:
        output (str): output folder path
        source (str): path to source
    Returns:
        str: full path for eac3to log
    """
    show=utils.sourcetoShowName(source)
    txtPath= os.path.join(output, "output_logs", f"Eac3to.{show}.txt")
    paths.mkdirSafe(os.path.dirname(txtPath))
    return txtPath


def cleanFiles(outputs_list:List[str])->None:
    """
    Cleans any file not within outputs_list that is in current directory

    Args:
        outputs_list (array): List of files to keep
    """
    outputs_list.append("chapters.txt")
    for file in os.listdir("."):
        if os.path.isfile(file) and file not in outputs_list:
            os.remove(file)
