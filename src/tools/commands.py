import shutil

import config as config
import src.tools.general as utils


def bdSup2Sub():
    if utils.getSystem() == "Linux":
        return [config.javaPath, "-jar", config.bdSupLinux]
    else:
        return [config.bdSupWindows]


def eac3to():
    if utils.getSystem() == "Linux":
        if shutil.which("wine"):
            return [config.winePath, config.eac3toPath]
        return [config.contyPath, "wine", config.eac3toPath]
    else:
        return [config.eac3toPath]


def bdinfo():
    if utils.getSystem() == "Linux":
        if shutil.which("mono"):
            return [config.monoPath, config.bdinfoLinuxPath]
        return [config.contyPath, "wine", config.bdinfoLinuxPath]
    else:
        return [config.bdinfoWindowsPath]


def mkvmerge():
    if utils.getSystem() == "Linux":
        return [config.mkvMergeLinux]
    else:
        return [config.mkvMergeWindows]


def isoBinary():
    if utils.getSystem() == "Linux":
        return [config.isoExtractLinux]
    else:
        return [config.isoExtractWindows]


def dgdemux():
    if utils.getSystem() == "Linux":
        return [config.dgDemuxLinux]
    else:
        return [config.dgDemuxWindow]


def suprip():
    supBin = config.supripPath
    wineBin = config.winePath
    if utils.getSystem() == "Linux":
        return [wineBin, supBin]
    else:
        return [supBin]
