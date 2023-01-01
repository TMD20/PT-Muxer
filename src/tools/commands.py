import shutil

import config as config
import src.tools.general as utils
from typing import List



def bdSup2Sub()->List[str]:
    """
    generates a command array for subprocess module to run bdsup2sub 
    based on current OS

    Returns:
        array: command array for subprocess
    """
    if utils.getSystem() == "Linux":
        return [config.javaPath, "-jar", config.bdSupLinux]
    else:
        return [config.bdSupWindows]


def eac3to()->List[str]:
    """
    generates a command array for subprocess module to run eac3to
    based on current OS

    Returns:
        array: command array for subprocess
    """
    if utils.getSystem() == "Linux":
        if shutil.which("wine"):
            return [config.winePath, config.eac3toPath]
        return [config.contyPath, "wine", config.eac3toPath]
    else:
        return [config.eac3toPath]


def bdinfo()->List[str]:
    """
    generates a command array for subprocess module to run bdinfo
    based on current OS

    Returns:
        array: command array for subprocess
    """    
    if utils.getSystem() == "Linux":
        if shutil.which("mono"):
            return [config.monoPath, config.bdinfoLinuxPath]
        return [config.contyPath, "wine", config.bdinfoLinuxPath]
    else:
        return [config.bdinfoWindowsPath]


def mkvmerge()->List[str]:
    """
    generates a command array for subprocess module to run mkvmerge
    based on current OS

    Returns:
        array: command array for subprocess
    """        
    if utils.getSystem() == "Linux":
        return [config.mkvMergeLinux]
    else:
        return [config.mkvMergeWindows]


def isoBinary()->List[str]:
    """
    generates a command array for subprocess module to run iso programs
    based on current OS

    Returns:
        array: command array for subprocess
    """         
    if utils.getSystem() == "Linux":
        return [config.isoExtractLinux]
    else:
        return [config.isoExtractWindows]


def dgdemux()->List[str]:
    """
    generates a command array for subprocess module to run dgdemux
    based on current OS

    Returns:
        array: command array for subprocess
    """    
    if utils.getSystem() == "Linux":
        return [config.dgDemuxLinux]
    else:
        return [config.dgDemuxWindow]


def suprip()->List[str]:
    """
    generates a command array for subprocess module to run suprip
    based on current OS

    Returns:
        array: command array for subprocess
    """      
    supBin = config.supripPath
    wineBin = config.winePath
    if utils.getSystem() == "Linux":
        return [wineBin, supBin]
    else:
        return [supBin]
