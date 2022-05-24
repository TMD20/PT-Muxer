from asyncio import subprocess
import os
import re


import itertools
import subprocess


def process(source, output, outputs_list, playlistnum, eac3toPath):
    os.chdir(output)
    playlistnum = f"{playlistnum})"
    extract_files(source, playlistnum, outputs_list, eac3toPath)
    cleanFiles(outputs_list)



def extract_files(source, playlistnum, outputs_list,eac3toPath):
    success = False

    command1 = [["/usr/bin/wine", "/usr/local/bin/eac3to/eac3to.exe",
                getwinepath(source), playlistnum, "1:chapters.txt"], outputs_list, ["-demux", f"-log={eac3toPath}"]]
    command2 = [["/usr/bin/wine", "/usr/local/bin/eac3to/eac3to.exe",
                getwinepath(source), playlistnum, "1:chapter.txt"], outputs_list, ["-progressnumbers", f"-log={eac3toPath}"]]
    with subprocess.Popen(list(itertools.chain.from_iterable(
            command1)), stdout=subprocess.PIPE, stderr=subprocess.PIPE, universal_newlines=True, bufsize=1) as p:
        for line in p.stdout:
            print(line, end='')
        success = True

    if success == False:
        with subprocess.Popen(list(itertools.chain.from_iterable(
                command2)), stdout=subprocess.PIPE, stderr=subprocess.PIPE, bufsize=1, universal_newlines=True) as p:
            for line in p.stdout:
                print(line, end='')
            success = True

def getwinepath(path):
    return subprocess.run(["/usr/bin/winepath", "-w", path], stdout=subprocess.PIPE).stdout.decode('utf8', 'strict')

def get_eac3toPath(dir, show):
    return os.path.join(
        dir, show, "output_logs", f"Eac3to.{show}.txt")

def cleanFiles(outputs_list):
    valid_list = [item.split(":")[1] for item in outputs_list]
    for file in os.listdir("."):
        if os.path.isfile(file) and file not in valid_list and file != "chapters.txt":
            os.remove(file)

def getVideoFileName( line, index):
    if re.search("AVC", line) != None:
        return f"{index}:00{index}.h264"
    if re.search("HEVC", line) != None:
        return f"{index}:00{index}.h265"
    if re.search("VC-1", line) != None:
        return f"{index}:00{index}.vc1"
    if re.search("MPEG-2", line) != None:
        return f"{index}:00{index}.mpeg2"

def getAudioFileName(line, langcode, index):
    if re.search("DTS Core", line) != None:
        codec = "dts"
    elif re.search("LPCM", line) != None:
        codec = "flac"
    elif re.search("Master Audio", line) != None:
        codec = "dtsma"
    elif re.search("Dolby Digital", line) != None:
        codec = "ac3"
    elif re.search("DTS Audio", line) != None:
        codec = "dts"
    elif re.search("Dolby TrueHD Audio", line) != None:
        codec = "thd"
    return f"{index}:00{index}-{langcode}.{codec}"

def getSubFileName(langcode, index):
    # remove special characters
    return f"{index}:00{index}-{langcode}.sup"
