
import mediatools.extract.eac3to as eac3to

import re


def generateTrackArgs(program,index,bdinfo,eac3to,type):
    if program=="eac3to":
        return eac3toTrack(index,bdinfo,eac3to,type)
    else:
        return dgdemuxTrack(eac3to)


def eac3toTrack(index,bdinfo,eac3to,type):
    output = []
    output.append((eac3to))
    if re.search("LPCM|TrueHD|DTS-HD MA|DTS:.*?X", bdinfo, re.IGNORECASE) == None and type== "audio":
        output.append("-keepDialnorm")
    return output

def dgdemuxTrack(eac3to):
    output=[eac3to]



def extractTracks(tracks,source,output,program,playlistLocation):
    trackArgs=[]

    [trackArgs.extend(generateTrackArgs(program,track["index"],track["bdinfo_title"],track["eac3to"],track["type"])) for track in tracks]
    if program=="eac3to":
        eac3to.process(source,output,trackArgs, playlistLocation)
    else:
        #dgdemux here
        None






