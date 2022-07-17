import re

from guessit import guessit


def getVideo(data):
    key = str(data["Enabled_Tracks"]["Video"][0])
    codec = data["Tracks_Details"]["Video"][key]["bdinfo_title"]
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
    codec = data["Tracks_Details"]["Audio"][key]["site_title"]
    if re.search("FLAC", codec) != None:
        return "FLAC"
    elif re.search("ATMOS", codec) != None:
        return "ATMOS"
    elif re.search("DTS-HD Master", codec) != None or re.search("Dolby Digital", codec) != None:
        return "DTS-HD.MA"
    elif re.search("TrueHD", codec) != None:
        return "TrueHD"


def getAudioChannel(data):
    key = str(data["Enabled_Tracks"]["Audio"][0])
    trackinfo = data["Tracks_Details"]["Audio"][key]["bdinfo_title"]
    return re.search("/ (.*?) /", trackinfo).group(1)


def getVideoResolution(data):
    key = str(data["Enabled_Tracks"]["Video"][0])
    trackinfo = data["Tracks_Details"]["Video"][key]["bdinfo_title"]
    return re.search("[0-9]{3,4}p", trackinfo).group(0)


def getMediaType(data):
    key = str(data["Enabled_Tracks"]["Video"][0])
    trackinfo = data["Tracks_Details"]["Video"][key]["sourceDir"]
    if guessit(trackinfo).get("source") == "Ultra HD Blu-ray":
        return "UHD.BluRay"
    else:
        return "BluRay"


def getHDR(data):
    key = str(data["Enabled_Tracks"]["Video"][0])
    title = data["Tracks_Details"]["Video"][key]["bdinfo_title"]
    if re.search("BT.2020", title):
        return "HDR"
    else:
        return "SDR"


