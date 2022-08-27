import re
import os
import copy
import random

from sites.base.siteTrackData import siteTrackData
import xxhash



class Blu(siteTrackData):
    def __init__(self):
        super().__init__()

    
    def addTracks(self, quicksum, playlistNum,playlistFile,streams, source, output):
        current_tracks = super().addTracks(quicksum, playlistNum, playlistFile,streams,source, output)
        self._checkPadding(current_tracks ,output)
        return current_tracks

    def _checkPadding(self, current_tracks, output):
        start = os.getcwd()
        os.chdir(output)
        insertDict = []
        for i in range(len(current_tracks)):
            track = current_tracks[i]
            title = track["bdinfo_title"]

            if re.search("24-bit", title, re.IGNORECASE) and re.search("LPCM|DTS-HD MA|DTS:.*?X", title, re.IGNORECASE):
                newTrack = copy.deepcopy(track)
                newTrack["notes"] = "Check Log to see if this Track has padding"
                match = re.search(".*([0-9]\.[0-9].*)", title).group(1)
                newTitle= f"FLAC Audio / {match}"
                newTitle=re.sub(" +"," ",newTitle)
                newTrack["site_title"] =newTitle
                newTrack["eac3to"] = re.sub("\..*", ".flac", track["eac3to"])
                newTrack["file"] = os.path.join(
                    output, newTrack["eac3to"].split(":")[1])
                newTrack["child"] = None
                value = newTrack["bdinfo_title"] + \
                    newTrack["sourceKey"] + str(newTrack["index"])
                key = xxhash.xxh32_hexdigest(value)
                post = newTrack["langcode"] or "vid"
                newTrack["key"] = f"{key}_forced_{post}"
                insertDict.append((i+1, newTrack))
        for tup in insertDict:
            current_tracks.insert(tup[0], tup[1])
        os.chdir(start)
