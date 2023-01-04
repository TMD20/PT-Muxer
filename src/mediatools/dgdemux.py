from __future__ import annotations 
from typing import TYPE_CHECKING, List,Union,Callable
import os
import itertools
import subprocess
import re

import langcodes

import src.tools.commands as commands
import src.tools.paths as paths
import src.tools.directory as dir
import src.tools.logger as logger
import src.tools.general as utils
if TYPE_CHECKING:
    import mediadata.trackObj as trackObj



####################################################
# This file handles passing the right arguments to extract a 
# Blu-ray with dgdemux 
# Because of limitations with the current dgdemux binary
#We force extraction of one file per dgdemux subprocess run
# Additionally file names can not be changed  via dgdemux directly
###############################################################33
def run(tracks:List[trackObj.TrackObJ],source:Union[str, bytes, os.PathLike], playlistFile:str,ep=False,directory:Union[str, bytes, os.PathLike]=".")->None:
    """
    This runner
    Extracts tracks via dgdemux for a single plalylist or split a playlist into
    individual streams


    Args:
        tracks (array): A array of trackobjs
        source (str): path to source to extract from
        playlistFile (str): playlist for source to extract
        ep (bool, optional):  Toggle dgdemux ep flag. Defaults to False.
        directory (str, optional): Directory to store extracted files. Defaults to ".".
    """
    tracks=_filterBDInfo(tracks)
    if ep==False:
        _runNormal(tracks,source, playlistFile,directory=directory)
    else:
        _runEP(tracks,source, playlistFile,directory=directory)



def _runNormal(tracks:List[trackObj.TrackObJ],source:Union[str, bytes, os.PathLike], playlistFile:str,directory:Union[str, bytes, os.PathLike]=".")->None:
    """
    Helper Function for _run to process single playlist

    
    Args:
        tracks (array): A array of trackobjs
        source (str): path to source to extract from
        playlistFile (str): playlist for source to extract
        directory (str, optional): Directory to store extracted files. Defaults to ".".
    """
    playlistLocation=_getPlaylistLocation(source,playlistFile)
    dgDemuxTrackOutPut=_getDgDemuxTrackInfo(playlistLocation)
    dgDemuxTracks=_getFilterOutput(_getTrackInfo(dgDemuxTrackOutPut))
    dgDemuxChapters=_getFilterOutput(_getChapterTrackInfo(dgDemuxTrackOutPut))

    normalTracks=list(filter(lambda x:x["compat"]==False,tracks))
    compatTracks=list(filter(lambda x:x["compat"]==True,tracks))
    _logHelper(normalTracks,compatTracks,dgDemuxTracks,_getChapterTrackInfo(dgDemuxTrackOutPut))
    _verifyTracksCodec(normalTracks,_getTrackInfo(dgDemuxTrackOutPut))
    _verifyTracksLang(normalTracks,_getTrackInfo(dgDemuxTrackOutPut))
    _verifyTracksLength(normalTracks,compatTracks,_getTrackInfo(dgDemuxTrackOutPut))
    dgDemuxTracks=_getFilterOutput(_getTrackInfo(dgDemuxTrackOutPut))
    dgDemuxChapters=_getFilterOutput(_getChapterTrackInfo(dgDemuxTrackOutPut))
    trackDex=0 
    compatDex=0 
    with dir.cwd(directory):     
        while trackDex<len(dgDemuxTracks):
            if re.search("(\.thd$)",normalTracks[trackDex]["filename"],re.IGNORECASE):
                _handleCompat(dgDemuxTracks[trackDex],normalTracks[trackDex]["filename"],compatTracks[compatDex]["filename"],playlistLocation)
                trackDex=trackDex+1
                compatDex=compatDex+1
            else:
                _handleNormal(dgDemuxTracks[trackDex],normalTracks[trackDex]["filename"],playlistLocation)
                trackDex=trackDex+1

        for index,track in enumerate(dgDemuxChapters):
            _handleChapter(track,playlistLocation)    
    



       
def _runEP(tracks:List[trackObj.TrackObJ],source:Union[str, bytes, os.PathLike], playlistFile:str,directory:Union[str, bytes, os.PathLike]=".")->None:
    """
    Helper Function for _run to process single playlist
    split into streams 
    via the dgdemux ep flag

    
    Args:
        tracks (array): A array of trackobjs
        source (str): path to source to extract from
        playlistFile (str): playlist for source to extract
        directory (str, optional): Directory to store extracted files. Defaults to ".".
    """
    playlistLocation=_getPlaylistLocation(source,playlistFile)
    dgDemuxTrackOutPut=_getDgDemuxTrackInfo(playlistLocation)
    dgDemuxTracks=_getFilterOutput(_getTrackInfo(dgDemuxTrackOutPut))
    dgDemuxChapters=_getFilterOutput(_getChapterTrackInfo(dgDemuxTrackOutPut))

    normalTracks=list(filter(lambda x:x["compat"]==False,tracks))
    compatTracks=list(filter(lambda x:x["compat"]==True,tracks))
    _logHelper(normalTracks,compatTracks,dgDemuxTracks,_getChapterTrackInfo(dgDemuxTrackOutPut))
    _verifyTracksCodec(normalTracks,_getTrackInfo(dgDemuxTrackOutPut))
    _verifyTracksLang(normalTracks,_getTrackInfo(dgDemuxTrackOutPut))
    _verifyTracksLength(normalTracks,compatTracks,_getTrackInfo(dgDemuxTrackOutPut))
    dgDemuxTracks=_getFilterOutput(_getTrackInfo(dgDemuxTrackOutPut))
    dgDemuxChapters=_getFilterOutput(_getChapterTrackInfo(dgDemuxTrackOutPut))
    trackDex=0 
    compatDex=0 
    with dir.cwd(directory):  
        while trackDex<len(dgDemuxTracks):
            if re.search("(\.thd$)",normalTracks[trackDex]["filename"],re.IGNORECASE):
                _handleCompatEP(dgDemuxTracks[trackDex],normalTracks[trackDex]["filename"],compatTracks[compatDex]["filename"],playlistLocation)
                trackDex=trackDex+1
                compatDex=compatDex+1
            else:
                _handleNormalEP(dgDemuxTracks[trackDex],normalTracks[trackDex]["filename"],playlistLocation)
                trackDex=trackDex+1

        for index,track in enumerate(dgDemuxChapters):
            _handleChapterEP(track,playlistLocation)    
    

def _getPlaylistLocation(source:Union[str, bytes, os.PathLike],playlistFile:str)->str:
    """
    Retrives the full path to a playlist

    Args:
        source (str): BDMV source
        playlistFile (str): name of playlist
    Returns:
        str: full path to playlist within source
    """
    playlistFiles=paths.search(source,playlistFile,ignore=["BACKUP"])
    if len(playlistFiles)==0:
        return ""
    playlistFile=playlistFiles[0]
    if utils.getSystem()=="Linux":
        return playlistFile
    return paths.convertPathType(playlistFile,type="Windows")
def _getDgDemuxTrackInfo(playlistLocation:str)->str:
    """
    Retrives a string of available tracks from dgdemux
    Args:
        playlistLocation (str): fullpath to playlist

    Raises:
        RuntimeError: Raise error to python if dgdemux errors 

    Returns:
        str: raw output
    """
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
    return output
def _getChapterTrackInfo(output:str)->List[str]:
    """
    parses dgdemux output into array of strs with chapter keys
    Args:
        output (str): dgdemux raw output

    Returns:
        array: list of dgdemux chapter track keys
    """
    outputList=output.split("\n")
    logger.logger.debug(f"outputList: {outputList}")
    filtered=list(filter(lambda x: re.search("Chapters",x,re.IGNORECASE),outputList))
    logger.logger.debug(f"Filtered Chapters List: {filtered}")
    return filtered


def _getTrackInfo(output:str)->List[str]:
    """
    parses dgdemux output into array of strs with track keys 
    Args:
        output (str): dgdemux raw output

    Returns:
        array: list of dgdemux non-chapter track keys
    """
    outputList=output.split("\n")
    logger.logger.debug(f"outputList: {outputList}")
    filtered=list(filter(lambda x: re.search("[0-9]{2}[0-9a-z]{2}:",x,re.IGNORECASE),outputList))
    logger.logger.debug(f"Filtered Track List: {filtered}")
    return filtered
def _getFilterOutput(output:str)->List[str]:
    """
    parses out dgdemux track keys

    Args:
        output (str): dgdemux raw output split into array

    Returns:
        array: an array of track keys
    """
    filtered=list(map(lambda x:re.sub(":.*","",x),output))
    logger.logger.debug(f"output Codes: {filtered}")
    return filtered

def _handleChapter(ele:Union[str,int],playlistLocation:str)->None:
    """
    Extracts chapter track using key for dgdemux into current directory

    Args:
        ele (str): track key
        playlistLocation (str): full path to playlist

    Raises:
        RuntimeError: Raise error to python if dgdemux errors 
    """
    tempDir=paths.createTempDir()
    logger.logger.debug(f"Processing {os.path.abspath('chapter.txt')}\n into tempdir")

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
    logger.logger.debug(f"dgdemux tempdir files:{paths.listdir(tempDir)}")
    os.replace(paths.listdir(tempDir)[0],"chapter.txt")
def _handleChapterEP(ele:Union[str,int],playlistLocation:str)->None:
    """
    Extracts chapter track using key for dgdemux into parsed index folder within current directory

    Args:
        ele (str): track key
        playlistLocation (str): full path to playlist

    Raises:
        RuntimeError: Raise error to python if dgdemux errors 
    """
    tempDir=paths.createTempDir()
    logger.logger.debug(f"batching chapter.txt into tempdir")

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
    chapterFiles=paths.search(tempDir,'chapters.txt',dir=False)
    
    for ele in chapterFiles:
        index=_getIndexDgdemuxHelper(ele)
        logger.logger.debug(str(chapterFiles))
        #create newpath with index
        with dir.cwd(os.path.join(".",str(index))):
            os.replace(ele,"chapter.txt")
def _handleNormal(ele:Union[str,int],newFileName:Union[str, bytes, os.PathLike],playlistLocation:str)->None:
    """
    Extracts non-chapter track using key for dgdemux into current directory

    Args:
        ele (str): track key
        newFileName (str): filename to replace dgdemux default with
        playlistLocation (str): full path to playlist

    Raises:
        RuntimeError: Raise error to python if dgdemux errors 
    """    
    tempDir=paths.createTempDir()
    logger.logger.debug(f"Processing {os.path.abspath(newFileName)}\n into tempdir")
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
    logger.logger.debug(f"dgdemux tempdir files:{paths.listdir(tempDir)}")

    os.replace(paths.listdir(tempDir)[0],newFileName)    
def _handleNormalEP(ele:Union[str,int],newFileName:Union[str, bytes, os.PathLike],playlistLocation:str)->None:
    """
    Extracts non-chapter track using key for dgdemux into parsed index folder within current directory

    Args:
        ele (str): track key
        newFileName (str): filename to replace dgdemux default with
        playlistLocation (str): full path to playlist

    Raises:
        RuntimeError: Raise error to python if dgdemux errors 
    """        
    
    tempDir=paths.createTempDir()
    logger.logger.debug(f"Batching {newFileName} into tempdir")
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
    for ele in paths.listdir(tempDir):
        #create newpath with index
        index=index=_getIndexDgdemuxHelper(ele)
        logger.logger.debug(f"dgdemux tempdir files:{paths.listdir(tempDir)}")
        with dir.cwd(os.path.join(".",str(index))):
            os.replace(ele,newFileName)       
   
def _handleCompat(ele:Union[str,int],newNormalFileName:Union[str, bytes, os.PathLike],newCompatFileName:Union[str, bytes, os.PathLike],playlistLocation:str)->None:
    """
    Extracts audio track with embedded compatability track using key for dgdemux into current directory

    Args:
        ele (str): track key
        newFileName (str): filename to replace  dgdemux normal audio track default with
        newCompatFileName (str): filename to replace dgdemux compatability audio track default with
        playlistLocation (str): full path to playlist

    Raises:
        RuntimeError: Raise error to python if dgdemux errors 
    """    
    tempDir=paths.createTempDir()
    logger.logger.debug(f"Processing {os.path.abspath(newNormalFileName)} and {os.path.abspath(newCompatFileName)}\n into tempdir")
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
    files=list(sorted(paths.listdir(tempDir),key=os.path.getsize,reverse=True))
    logger.logger.debug(f"dgdemux tempdir files:{files}")
    os.replace(files[0],newNormalFileName)    
    os.replace(files[1],newCompatFileName)  

def _handleCompatEP(ele:Union[str,int],newNormalFileName:Union[str, bytes, os.PathLike],newCompatFileName:Union[str, bytes, os.PathLike],playlistLocation:str)->None:
    """
    Extracts audio track with embedded compatability track using key for dgdemux into parsed index folder 
    within current directory

    Args:
        ele (str): track key
        newFileName (str): filename to replace  dgdemux normal audio track default with
        newCompatFileName (str): filename to replace dgdemux compatability audio track default with
        playlistLocation (str): full path to playlist

    Raises:
        RuntimeError: Raise error to python if dgdemux errors 
    """    
   
    tempDir=paths.createTempDir()
    logger.logger.debug(f"Batching {newNormalFileName} and {newCompatFileName} into tempdir")
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
    logger.logger.debug(f"dgdemux tempdir files:{paths.listdir(tempDir)}")

    for ele in thd:
        #create newpath with index
        index=_getIndexDgdemuxHelper(ele)
        with dir.cwd(os.path.join(".",str(index))):
            os.replace(ele,newNormalFileName)    
    for ele in compat:
        #create newpath with index
        index=_getIndexDgdemuxHelper(ele)
        with dir.cwd(os.path.join(".",str(index))):
            os.replace(ele,newCompatFileName)    


def _verifyTracksLength(normalTracks:List[trackObj.TrackObJ],compatTracks:List[trackObj.TrackObJ],dgDemuxTracks:List[:Union[str,int]])->None:
    """
    verifiy the number of trackObjs with the number of tracks from dgdemux output
    Args:
        normalTracks (array): Non compat audio,video, and sub tracks
        compatTracks (array(): array of compat audio tracks
        dgDemuxTracks (array): array of dgdemux -i raw output for audio,video,subtitle tracks
    Raises:
        Exception: Raise error to python if dgdemux errors  on missmatched compatiblilty track count
        Exception: Raise error to python if dgdemux errors  on missmatched normal track count
    """
    if len(list(filter(lambda x:re.search("thd",x,re.IGNORECASE),dgDemuxTracks)))!=len(compatTracks):
        raise Exception("dgdemux compatability track count verification Error")
    if len(dgDemuxTracks)!=len(normalTracks):
        raise Exception("dgdemux track count verification Error")

def _verifyTracksCodec(normalTracks:List[trackObj.TrackObJ],dgDemuxTracks:List[:Union[str,int]])->None:
    """
    Verifiy that the trackObj codec matches with the corresponding dgdemux track codec
    Args:
        normalTracks (array): Non compat audio,video, and sub tracks
        dgDemuxTracks (array): dgdemux -i raw output for audio,video,subtitle tracks split into array
    Raises:
        Exception: Raise error to python if dgdemux parsed codec and corresponding trackobj codec missmatch
    """    
   

    
    for i in range(len(dgDemuxTracks)):
        dgDemuxTrack=dgDemuxTracks[i]
        bdTrack=normalTracks[i]["bdinfo_title"]
        if re.search("hevc",dgDemuxTrack,re.IGNORECASE) and re.search("hevc",bdTrack,re.IGNORECASE):
            continue
        elif re.search("avc",dgDemuxTrack,re.IGNORECASE) and re.search("avc",bdTrack,re.IGNORECASE):
            continue
        elif re.search("thd",dgDemuxTrack,re.IGNORECASE) and re.search("truehd",bdTrack,re.IGNORECASE):
            continue
        elif re.search("ac3",dgDemuxTrack,re.IGNORECASE) and re.search("dolby digital audio",bdTrack,re.IGNORECASE):
            continue
        elif re.search("dts hdma",dgDemuxTrack,re.IGNORECASE) and re.search("dts-hd master audio",bdTrack,re.IGNORECASE):
            continue  
        elif re.search("pgs",dgDemuxTrack,re.IGNORECASE) and re.search("subtitle",bdTrack,re.IGNORECASE):
            continue       
        else:
            message=\
           f"""
            Track codec error
            dgdemux Track:{dgDemuxTrack}
            bdInfo Track:{bdTrack}
            """
            raise Exception(message)


def _verifyTracksLang(normalTracks:List[trackObj.TrackObJ],dgDemuxTracks:List[:Union[str,int]])->None:
    """
    Verifiy that the trackObj langcode matches with the corresponding dgdemux track langcode
    Args:
        normalTracks (array): Non compat audio,video, and sub tracks
        dgDemuxTracks (array): dgdemux -i raw output for audio,video,subtitle tracks split into array
    Raises:
        Exception: Raise error to python if dgdemux parsed language and corresponding trackobj langcode missmatch
    """  
    dgFilteredTracks=list(filter
    (lambda x:re.search("video",x,re.IGNORECASE)==None,dgDemuxTracks))
    normalTrackFiltered=list(filter(lambda x:re.search("video",x["bdinfo_title"],re.IGNORECASE)==None,normalTracks))
    for i in range(len(dgFilteredTracks)):
        dgDemuxTrack=re.search("\[([a-z]{3})\]", dgFilteredTracks[i],re.IGNORECASE)
        bdTrack=normalTrackFiltered[i]["langcode"]
        if langcodes.standardize_tag(dgDemuxTrack.group(1))!=langcodes.standardize_tag(bdTrack):
            message=\
           f"""
            Track lang code error

            dgdemux Track:{dgFilteredTracks[i]}
            dgdemux Track Code:{langcodes.standardize_tag(dgDemuxTrack.group(1))}
            bdInfo Track:{normalTrackFiltered[i]["langcode"]}
            bdInfo Track Code:{langcodes.standardize_tag(bdTrack)}
            """
            raise Exception(message)

                       
    
def _logHelper(normalTracks:List[trackObj.TrackObJ],compatTracks:List[trackObj.TrackObJ],dgDemuxTracks:List[:Union[str,int]],dgDemuxChapters:List[str])->None:
    """
    Prints logs
    Args:
        normalTracks (array): Non compat audio,video, and sub tracks
        dgDemuxTracks (array): dgdemux filtered raw output lines for audio,video,subtitle tracks split into array
        compatTracks (array(): array of compat audio tracks
    """  
    logger.logger.debug(f"Checking dgdemux track info")
    logger.logger.debug(f"dgDemux Tracks:{dgDemuxTracks}")
    logger.logger.debug(f"dgDemux Tracks Length:{len(dgDemuxTracks)}")
    logger.logger.debug(f"bdinfo Tracks:{normalTracks}")
    logger.logger.debug(f"bdinfo Tracks Length:{len(normalTracks)}")
    logger.logger.debug(f"Absolute Value Dif:{abs(len(dgDemuxTracks)-len(normalTracks))}")
    logger.logger.debug(f"dgDemux Chapter Tracks:{dgDemuxChapters}")
    logger.logger.debug(f"dgDemux Chapter Tracks Length:{len(dgDemuxChapters)}")
    logger.logger.debug(f"bdinfo Compatibility Tracks:{compatTracks}")
    logger.logger.debug(f"dgDemux Compatibility Tracks Length:{len(compatTracks)}")

def _getIndexDgdemuxHelper(track:str)->str:
    """
    Parse index from dgdemux line raw output line

    Args:
        track (str): raw output line

    Returns:
        str: returns parsed index
    """
    return re.search("\[([0-9]+)\]",track).group(1)
def _filterBDInfo(tracks:List[trackObj.TrackObJ])->List[trackObj.TrackObJ]:
    """
    Filter tracks not compatible with dgdemux extraction

    Args:
        tracks (array): trackObjs

    Returns:
        array: returns array of  trackObjs compatible with dgdemux
    """
    return list(filter(lambda x:re.search("(DTS Core)",x["bdinfo_title"],re.IGNORECASE)==None,tracks)) 

        


  



