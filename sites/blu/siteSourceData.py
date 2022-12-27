import re
import os
import copy
import random

import xxhash

from sites.base.siteSourceData import siteSourceData
import tools.directory as dir



class Blu(siteSourceData):
    def __init__(self):
        super().__init__()

    
    def addTracks(self, bdinfo,playlistNum,streams=None):
        current_tracks = super().addTracks(bdinfo,playlistNum,streams=None)
        
        self._checkPadding(current_tracks)
        return current_tracks

    def _checkPadding(self, current_tracks):
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
                newTrack["filename"] = re.sub("\..*", ".flac", track["filename"])
                newTrack["child"] = None
                value = newTrack["bdinfo_title"] + \
                    newTrack["sourceKey"] + str(newTrack["index"])
                key = xxhash.xxh32_hexdigest(value)
                post = newTrack["langcode"] or "vid"
                newTrack["key"] = f"{key}_forced_{post}"
                insertDict.append((i+1, newTrack))
        for tup in insertDict:
            current_tracks.insert(tup[0], tup[1])
