import os
import re
import itertools
import subprocess

import config
import tools.general as utils


def process(source, output, outputs_list,playlistLocation):
    start = os.getcwd()
    show = utils.getShowName(source)
    eac3toPath = set_eac3toPath(output, show)

    utils.mkdirSafe(eac3toPath)

    os.chdir(output)
    extract_files( playlistLocation,outputs_list, eac3toPath)
    cleanFiles(outputs_list)
    os.chdir(start)

def extract_files(playlistLocation, outputs_list, eac3toPath):
    success = False
    eactoBin = config.eac3toLinuxPath
    if not os.path.isfile(eactoBin):
        eactoBin = config.eac3toProjectPath

    wineBin = config.wineLinuxPath
    if not os.path.isfile(wineBin):
        wineBin = config.wineProjectPath

    #get list of files
    eac3toWChapters = ["1:chapters.txt"]
    eac3toWChapters.extend([f"{ele[0]}:{ele[1]}"for ele in outputs_list if ele != "-keepDialnorm"])
    eac3toWoChapters = [
        f"{ele[0]-1}:{ele[1]}"for ele in outputs_list if ele != "-keepDialnorm"]

    
    command1 = [[wineBin, eactoBin, utils.getwinepath(playlistLocation)],  eac3toWChapters,[
        "-progressnumbers", f"-log={eac3toPath}"]]
    
    command2 = [[wineBin, eactoBin, utils.getwinepath(playlistLocation)], eac3toWoChapters,[
        "-progressnumbers", f"-log={eac3toPath}"]]

    command3 = [[wineBin, eactoBin, utils.getwinepath(playlistLocation)],  eac3toWChapters , [
        "-progressnumbers", "-demux", f"-log={eac3toPath}"]]

    command4 = [[wineBin, eactoBin, utils.getwinepath(playlistLocation), ], eac3toWoChapters, [
        "-progressnumbers", "-demux", f"-log={eac3toPath}"]]
    commandslist=[command1,command2,command3,command4]
    status=1
    for command in commandslist:
        with subprocess.Popen(list(itertools.chain.from_iterable(
                command)), stdout=subprocess.PIPE, stderr=subprocess.PIPE, universal_newlines=True, bufsize=1) as p:
            for line in p.stdout:
                print(line, end='')
            for line in p.stderr:
                print(line, end='')
            p.wait()
            status=p.returncode
            if status==0:
                break

   

def set_eac3toPath(output, show):
    return os.path.join(output, "output_logs", f"Eac3to.{show}.txt")


def cleanFiles(outputs_list):
    outputs_list = [f"{ele[1]}"for ele in outputs_list]
    for file in os.listdir("."):
        if os.path.isfile(file) and file not in outputs_list:
            os.remove(file)


def getVideoFileName(line, index):
    if re.search("AVC", line) != None:
        return f"{index}:00{index}.h264"
    if re.search("HEVC", line) != None:
        return f"{index}:00{index}.h265"
    if re.search("VC-1", line) != None:
        return f"{index}:00{index}.vc1"
    if re.search("MPEG-2", line) != None:
        return f"{index}:00{index}.mpeg2"


def getAudioFileName(line, langcode, index):
    # Lossless audio
    if re.search("flac", line, re.IGNORECASE) != None:
        codec = "flac"

    elif re.search("lpcm", line, re.IGNORECASE) != None:
        codec = "pcm"
    elif re.search("Master Audio", line, re.IGNORECASE) != None:
        codec = "dtsma"

    elif re.search("TrueHD", line, re.IGNORECASE) != None:
        codec = "thd"

    elif re.search("Dolby Digital", line, re.IGNORECASE) != None:
        codec = "ac3"
    elif re.search("AC3 Embedded", line, re.IGNORECASE) != None:
        codec = "ac3"

    elif re.search("DTS Audio", line, re.IGNORECASE) != None:
        codec = "dts"
    elif re.search("dts", line, re.IGNORECASE) != None:
        codec = "dts"

    return f"{index}:00{index}-{langcode}.{codec}"


def getSubFileName(langcode, index):
    # remove special characters
    return f"{index}:00{index}-{langcode}.sup"
