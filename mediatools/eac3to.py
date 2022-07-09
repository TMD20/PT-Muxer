from asyncio import subprocess
import os
import re


import itertools
import subprocess
import tools.general as util



def process(source, output,outputs_list, playlistNum):
    start=os.getcwd()
    show = util.getShowName(source)
    eac3toPath = set_eac3toPath(output,show)
    
    util.mkdirSafe(eac3toPath)
   

    
    os.chdir(output)
    extract_files(source, playlistNum, outputs_list, eac3toPath)
    cleanFiles(outputs_list)
    os.chdir(start)


def extract_files(source, playlistNum, outputs_list, eac3toPath):
    success = False
    command1 = [["/usr/bin/wine", "/usr/local/bin/eac3to/eac3to.exe",
                getwinepath(source), f"{playlistNum})", "1:chapters.txt"], outputs_list, ["-progressnumbers", f"-log={eac3toPath}"]]
    command2 = [["/usr/bin/wine", "/usr/local/bin/eac3to/eac3to.exe",
                getwinepath(source), f"{playlistNum})", "1:chapters.txt"], outputs_list, ["-progressnumbers", "-demux", f"-log={eac3toPath}"]]
  
    with subprocess.Popen(list(itertools.chain.from_iterable(
            command1)), stdout=subprocess.PIPE, stderr=subprocess.PIPE, universal_newlines=True, bufsize=1) as p:
        for line in p.stdout:
            print(line, end='')
        for line in p.stderr:
            print(line, end='')
        success = True
    

    if success == False:
        print("Trying with --demux arg")
        with subprocess.Popen(list(itertools.chain.from_iterable(
                command2)), stdout=subprocess.PIPE, stderr=subprocess.PIPE, universal_newlines=True, bufsize=1) as p:
            for line in p.stderr:
                print(line, end='')
            for line in p.stdout:
                print(line, end='')
           


def getwinepath(folder):
    return subprocess.run(["/usr/bin/winepath", "-w", folder], cwd="/", stdout=subprocess.PIPE).stdout.decode('utf8', 'strict').replace('\n', '')


def set_eac3toPath(output,show):
    return os.path.join(output, "output_logs", f"Eac3to.{show}.txt")


def cleanFiles(outputs_list):
    valid_list = [item.split(":")[1]
                  for item in outputs_list if len(item.split(":"))>1]
    for file in os.listdir("."):
        if os.path.isfile(file) and file not in valid_list and file != "chapters.txt":
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
    ##Lossless audio
    if re.search("flac", line,re.IGNORECASE) != None:
        codec = "flac"

    elif re.search("lpcm",line,re.IGNORECASE)!=None:
        codec="pcm"
    elif re.search("Master Audio", line,re.IGNORECASE) != None:
        codec = "dtsma"
    
    elif re.search("TrueHD", line,re.IGNORECASE) != None:
        codec = "thd"
    
    elif re.search("Dolby Digital", line,re.IGNORECASE) != None:
        codec = "ac3"
    elif re.search("AC3 Embedded", line,re.IGNORECASE) != None:
        codec = "ac3"

    elif re.search("DTS Audio", line, re.IGNORECASE) != None:
        codec = "dts"
    elif re.search("dts", line, re.IGNORECASE) != None:
        codec="dts"

    return f"{index}:00{index}-{langcode}.{codec}"


def getSubFileName(langcode, index):
    # remove special characters
    return f"{index}:00{index}-{langcode}.sup"

