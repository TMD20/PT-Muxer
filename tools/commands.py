import os

import config
import tools.general as utils

def bdSup():
    if utils.getSystem()=="Linux":

        return [config.javaPath,"-jar",config.bdSupLinux]
    else:
        return [config.bdSupWindows]
def eac3to():
    if utils.getSystem()=="Linux":
        return [config.winePath, config.eac3toPath]
        
    else:
        return [config.eac3toPath]

def bdinfo():
    if utils.getSystem()=="Linux":
        return [config.winePath, config.bdinfoLinuxPath]
    else:
        return [config.bdinfoWindowsPath]

def mkvmerge():
    if utils.getSystem()=="Linux":
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