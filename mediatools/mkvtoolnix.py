import itertools
import re
import subprocess


def getVideo(data):
    key = str(data["Enabled_Tracks"]["Video"][0])
    codec = data["Tracks_Details"]["Video"][key]["bdinfo"]
    if re.search("AVC", codec) != None:
        return "AVC"
    elif re.search("VC-1", codec) != None:
        return "VC-1"
    elif re.search("HEVC", codec) != None:
        return "HEVC"
    elif re.search("MPEG-2", codec) != None:
        return "MPEG-2"


def getAudio(data):
    key = str(data["Enabled_Tracks"]["Audio"][0])
    codec = data["Tracks_Details"]["Audio"][key]["bdinfo"]
    if re.search("LPCM", codec) != None:
        return "FLAC"
    elif re.search("ATMOS", codec) != None:
        return "ATMOS"
    elif re.search("DTS-HD Master", codec) != None or re.search("Dolby Digital", codec) != None:
        return "DTS-HD.MA"
    elif re.search("TrueHD", codec) != None:
        return "TrueHD"

def getAudioChannel(data):
    key = str(data["Enabled_Tracks"]["Audio"][0])
    trackinfo = data["Tracks_Details"]["Audio"][key]["bdinfo"]
    return re.search("/ (.*?) /", trackinfo).group(1)


def getVideoResolution(data):
    key = str(data["Enabled_Tracks"]["Video"][0])
    trackinfo = data["Tracks_Details"]["Video"][key]["bdinfo"]
    return re.search("[0-9]{3,4}p", trackinfo).group(0)


def addVideoTracks(remuxConfig):
    out = []
    langcodeKey = str(remuxConfig["Enabled_Tracks"]["Audio"][0])
    langcode=remuxConfig["Tracks_Details"]["Audio"][langcodeKey]["langcode"]
    for key in remuxConfig["Enabled_Tracks"]["Video"]:
        key=str(key)
        trackjson = remuxConfig["Tracks_Details"]["Video"][key]
        name = trackjson["title"]
        file = trackjson["file"]
        temp = ["--language", f"0:{langcode}",
                "--track-name", f"0:{name}", file]
        out.append(temp)
    return list(itertools.chain.from_iterable(out))


def addAudioTracks(remuxConfig):
    out = []
    for key in remuxConfig["Enabled_Tracks"]["Audio"]:
        key=str(key)
        trackjson = remuxConfig["Tracks_Details"]["Audio"][key]
        langcode = trackjson["langcode"]
        name = trackjson["title"]
        file = trackjson["file"]
        temp = ["--language", f"0:{langcode}", "--track-name", f"0:{name}", file]
        out.append(temp)
    return list(itertools.chain.from_iterable(out))


def addSubTracks(remuxConfig):
    out = []
    for key in remuxConfig["Enabled_Tracks"]["Sub"]:
        key=str(key)

        trackjson = remuxConfig["Tracks_Details"]["Sub"][key]
        langcode = trackjson["langcode"]
        file = trackjson["file"]
        temp = ["--language", f"0:{langcode}", file]
        out.append(temp)
    return list(itertools.chain.from_iterable(out))

def createMKV(movieTitle,chapters,fileName,tracks):
    command = list(itertools.chain.from_iterable(
    [["/usr/bin/mkvmerge", "--title", movieTitle, "--chapters", chapters, "--output", fileName], tracks]))
    with subprocess.Popen(command, universal_newlines=True,stdout=subprocess.PIPE,bufsize=1) as p:
        for line in p.stdout:
            print(line, end='')
  