import os
import itertools
import subprocess
import re

import langcodes

import tools.commands as commands
import tools.paths as paths
import tools.directory as dir
import tools.logger as logger








def run(tracks,source, playlistFile,ep=False):
    if ep==False:
        _runNormal(tracks,source, playlistFile)
    else:
        _runEP(tracks,source, playlistFile)



def _runNormal(tracks,source, playlistFile):
    playlistLocation=_getPlaylistLocation(source,playlistFile)
    dgDemuxTrackOutPut=_getDgDemuxTrackInfo(playlistLocation)
    dgDemuxTracks=_getFilterOutput(_getTrackInfo(dgDemuxTrackOutPut))
    dgDemuxChapters=_getFilterOutput(_getChapterTrackInfo(dgDemuxTrackOutPut))

    filteredBDInfo=list(filter(lambda x:re.search("(DTS Core)",x["bdinfo_title"],re.IGNORECASE)==None,tracks)) 
    normalTracks=list(filter(lambda x:x["compat"]==False,filteredBDInfo))
    compatTracks=list(filter(lambda x:x["compat"]==True,filteredBDInfo))
    _logHelper(normalTracks,compatTracks,dgDemuxTracks,_getChapterTrackInfo(dgDemuxTrackOutPut))
    _verifyTracksCodec(normalTracks,compatTracks,_getTrackInfo(dgDemuxTrackOutPut))
    _verifyTracksLang(normalTracks,_getTrackInfo(dgDemuxTrackOutPut))
    _verifyTracksLength(normalTracks,compatTracks,_getTrackInfo(dgDemuxTrackOutPut))
    dgDemuxTracks=_getFilterOutput(_getTrackInfo(dgDemuxTrackOutPut))
    dgDemuxChapters=_getFilterOutput(_getChapterTrackInfo(dgDemuxTrackOutPut))
    if len(dgDemuxTracks)-len(normalTracks)>0:
        raise RuntimeError("Track Lengths are Missmatched")
    trackDex=0 
    compatDex=0    
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
    



       
def _runEP(tracks,source, playlistFile):
    playlistLocation=_getPlaylistLocation(source,playlistFile)
    dgDemuxTrackOutPut=_getDgDemuxTrackInfo(playlistLocation)
    dgDemuxTracks=_getFilterOutput(_getTrackInfo(dgDemuxTrackOutPut))
    dgDemuxChapters=_getFilterOutput(_getChapterTrackInfo(dgDemuxTrackOutPut))

    filteredBDInfo=list(filter(lambda x:re.search("(DTS Core)",x["bdinfo_title"],re.IGNORECASE)==None,tracks)) 
    normalTracks=list(filter(lambda x:x["compat"]==False,filteredBDInfo))
    compatTracks=list(filter(lambda x:x["compat"]==True,filteredBDInfo))
    _logHelper(normalTracks,compatTracks,dgDemuxTracks,_getChapterTrackInfo(dgDemuxTrackOutPut))
    _verifyTracksCodec(normalTracks,compatTracks,_getTrackInfo(dgDemuxTrackOutPut))
    _verifyTracksLang(normalTracks,_getTrackInfo(dgDemuxTrackOutPut))
    _verifyTracksLength(normalTracks,compatTracks,_getTrackInfo(dgDemuxTrackOutPut))

    dgDemuxTracks=_getFilterOutput(_getTrackInfo(dgDemuxTrackOutPut))
    dgDemuxChapters=_getFilterOutput(_getChapterTrackInfo(dgDemuxTrackOutPut))
    if len(dgDemuxTracks)-len(normalTracks)>0:
        raise RuntimeError("Track Lengths are Missmatched")
    trackDex=0 
    compatDex=0    
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
    

def _getPlaylistLocation(source,playlistFile):
    playlistFiles=paths.search(source,playlistFile,ignore=["BACKUP"])
    if len(playlistFiles)>0:
        return playlistFiles[0]
    return ""
def _getDgDemuxTrackInfo(playlistLocation):
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
def _getChapterTrackInfo(output):
    outputList=output.split("\n")
    logger.logger.debug(f"outputList: {outputList}")
    filtered=list(filter(lambda x: re.search("Chapters",x,re.IGNORECASE),outputList))
    logger.logger.debug(f"Filtered Chapters List: {filtered}")
    return filtered


def _getTrackInfo(output):
    outputList=output.split("\n")
    logger.logger.debug(f"outputList: {outputList}")
    filtered=list(filter(lambda x: re.search("[0-9]{2}[0-9a-z]{2}:",x,re.IGNORECASE),outputList))
    logger.logger.debug(f"Filtered Track List: {filtered}")
    return filtered
def _getFilterOutput(output):
    filtered=list(map(lambda x:re.sub(":.*","",x),output))
    logger.logger.debug(f"output Codes: {filtered}")
    return filtered

def _handleChapter(ele,playlistLocation):
    tempDir=paths.createTempDir()
    logger.logger.debug(f"Processing {os.path.abspath('chapter.txt')}\n")

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
def _handleChapterEP(ele,playlistLocation):
    tempDir=paths.createTempDir()
    logger.logger.debug(f"batching chapter.txt")

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
            os.replace(chapterFiles[0],"chapter.txt")
def _handleNormal(ele,newFileName,playlistLocation):
    tempDir=paths.createTempDir()
    logger.logger.debug(f"Processing {os.path.abspath(newFileName)}\n")
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
def _handleNormalEP(ele,newFileName,playlistLocation):
    tempDir=paths.createTempDir()
    logger.logger.debug(f"Batching {newFileName}")
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
   
def _handleCompat(ele,newNormalFileName,newCompatFileName,playlistLocation):
    tempDir=paths.createTempDir()
    logger.logger.debug(f"Processing {os.path.abspath(newNormalFileName)} and {os.path.abspath(newCompatFileName)}\n")
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

def _handleCompatEP(ele,newNormalFileName,newCompatFileName,playlistLocation):
    tempDir=paths.createTempDir()
    logger.logger.debug(f"Batching {newNormalFileName} and {newCompatFileName}")
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


def _verifyTracksLength(normalTracks,compatTracks,dgDemuxTracks):
    if len(list(filter(lambda x:re.search("thd",x,re.IGNORECASE),dgDemuxTracks)))!=len(compatTracks):
        raise Exception("dgdemux compatability track count verification Error")
    if len(dgDemuxTracks)!=len(normalTracks):
        raise Exception("dgdemux track count verification Error")

def _verifyTracksCodec(normalTracks,compatTracks,dgDemuxTracks):
    if len(list(filter(lambda x:re.search("thd",x,re.IGNORECASE),dgDemuxTracks)))!=len(compatTracks):
        raise Exception("dgdemux compatability track count verification Error")
    if len(dgDemuxTracks)!=len(normalTracks):
        raise Exception("dgdemux track count verification Error")
    
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


def _verifyTracksLang(normalTracks,dgDemuxTracks):
    dgFilteredTracks=list(filter(lambda x:re.search("video",x,re.IGNORECASE)==None,dgDemuxTracks))
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

                       
    
def _logHelper(normalTracks,compatTracks,dgDemuxTracks,dgDemuxChapters):
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

def _getIndexDgdemuxHelper(track):
    return re.search("\[([0-9]+)\]",track).group(1)
        


  



