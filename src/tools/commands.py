import shutil
import os
import config as config
import src.tools.general as utils
import src.tools.paths as paths
from typing import List




def bdSup2Sub()->List[str]:
    """
    generates a command array for subprocess module to run bdsup2sub 
    based on current OS

    Returns:
        array: command array for subprocess
    """
    if utils.getSystem() == "Linux":
        return [config.JAVAPATH, "-jar", config.BDSUPLINUX]
    else:
        return [config.BDSUPWINDOWS]


def eac3to()->List[str]:
    """
    generates a command array for subprocess module to run eac3to
    based on current OS

    Returns:
        array: command array for subprocess
    """
    if utils.getSystem() == "Linux":
        if shutil.which("wine"):
            return [config.WINEPATH, config.EACTOPATH]
        return [config.CONTYPATH, "wine", config.EACTOPATH]
    else:
        return [config.EACTOPATH]


def bdinfo()->List[str]:
    """
    generates a command array for subprocess module to run bdinfo
    based on current OS

    Returns:
        array: command array for subprocess
    """    
    if utils.getSystem() == "Linux":
        if shutil.which("mono"):
            return [config.MONOPATH, config.BDINFOLINUXPATH]
        return [config.CONTYPATH, "wine", config.BDINFOLINUXPATH]
    else:
        return [config.BDINFOWINDOWSPATH]


def mkvmerge()->List[str]:
    """
    generates a command array for subprocess module to run mkvmerge
    based on current OS

    Returns:
        array: command array for subprocess
    """        
    if utils.getSystem() == "Linux":
        return [config.MKVMERGELINUX]
    else:
        return [config.MKVMERGEWINDOWS]


def isoBinary()->List[str]:
    """
    generates a command array for subprocess module to run iso programs
    based on current OS

    Returns:
        array: command array for subprocess
    """         
    if utils.getSystem() == "Linux":
        return [config.ISOEXTRACTLINUX]
    else:
        return [config.ISOEXTRACTWINDOWS]


def dgdemux()->List[str]:
    """
    generates a command array for subprocess module to run dgdemux
    based on current OS

    Returns:
        array: command array for subprocess
    """    
    if utils.getSystem() == "Linux":
        return [config.DGDEMUXLINUX]
    else:
        return [config.DGDEMUXWINDOW]


def suprip()->List[str]:
    """
    generates a command array for subprocess module to run suprip
    based on current OS

    Returns:
        array: command array for subprocess
    """      
    supBin = config.SUPRIPPATH
    wineBin = config.WINEPATH
    if utils.getSystem() == "Linux":
        return [wineBin, supBin]
    else:
        return [supBin]

def avisynth(video)->List[str]:
    """
    generates a command array for subprocess module to run avisynthcommand
    based on current OS
    Args:
        video (str): Path to video file to input to ffmpeg
    Returns:
        array: command array for subprocess
    """ 
    with open(os.path.join(paths.createTempDir(),"chapter.avs"),"w") as p:
        if utils.getSystem()=="Linux":
            my_env = os.environ.copy()
            my_env["LD_LIBRARY_PATH"]=config.AVISYNTH_LINUX_LIB
            p.writelines([f'import("{config.FFMS2}")',f'LoadPlugin("{config.FFMS2_LINUX_LIB}")',
            f'FFVideoSource("{video}")','FFInfo(framenum=true,frametype=true,cfrtime=true,vfrtime=false, \
            version=false,cropping=false,colorrange=false,colorspace=false,sar=false)'])
            return [config.FFMPEG_LINUX,"-i",p.name,"-y",video.replace("mkv","AVS_CHAPTER.mkv")]
def scale(video)->List[str]:
    """
    generates a command array for subprocess module to run ffmpeg scaled video
    based on current OS
    Args:
        video (str): Path to video file to input to ffmpeg
    Returns:
        array: command array for subprocess
    """ 
    return [config.FFMPEG_LINUX,"-i",video,"-vf","scale=iw/2:ih/2","-y",video.replace("mkv","AVS_SCALED.mkv")]
