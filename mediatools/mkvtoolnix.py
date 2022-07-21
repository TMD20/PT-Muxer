import re

from guessit import guessit

import mediadata.movieData as movieData


def getVideo(enabledTracks, trackDetails):
    key = str(enabledTracks[0])
    trackinfo = trackDetails[key]["bdinfo_title"]
    if re.search("AVC", trackinfo) != None:
        return "AVC"
    elif re.search("VC-1", trackinfo) != None:
        return "VC-1"
    elif re.search("HEVC", trackinfo) != None:
        return "HEVC"
    elif re.search("MPEG-2", trackinfo) != None:
        return "MPEG-2"


def getAudio(enabledTracks, trackDetails):
    key = str(enabledTracks[0])
    trackinfo = trackDetails[key]["site_title"]
    
    
    if re.search("FLAC", trackinfo):
        return "FLAC"
    elif re.search("ATMOS", trackinfo):
        return "ATMOS"
    elif re.search("DTS-HD Master", trackinfo) or re.search("Dolby Digital", trackinfo):
        return "DTS-HD.MA"
    elif re.search("TrueHD", trackinfo):
        return "TrueHD"
    elif re.search("PCM", trackinfo):
        return "PCM"


def getAudioChannel(enabledTracks, trackDetails):
    key = str(enabledTracks[0])
    trackinfo = trackDetails[key]["site_title"]
    return re.search("/ (.*?) /", trackinfo).group(1)


def getVideoResolution(enabledTracks,trackDetails):
    key = str(enabledTracks[0])
    trackinfo = trackDetails[key]["bdinfo_title"]
    return re.search("[0-9]{3,4}p", trackinfo).group(0)


def getMediaType(enabledTracks, trackDetails):

    key = str(enabledTracks[0])
    trackinfo = trackDetails[key]["bdinfo_title"]
    if guessit(trackinfo).get("source") == "Ultra HD Blu-ray":
        return "UHD.BluRay"
    else:
        return "BluRay"


def getHDR(enabledTracks, trackDetails):
    key = str(enabledTracks[0])
    trackinfo = trackDetails[key]["bdinfo_title"]
    if re.search("BT.2020", trackinfo):
        return "HDR"
    else:
        return "SDR"



