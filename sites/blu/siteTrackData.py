import re
import os
import copy
import random

from sites.base.siteTrackData import siteTrackData



class Blu(siteTrackData):
    def __init__(self):
        super().__init__()

    def addTracks(self, quicksum, playlistNum, source, output):
        current_tracks = super().addTracks(quicksum, playlistNum, source, output)
        self._checkPadding(current_tracks, playlistNum, source, output)

    def _checkPadding(self, current_tracks, playlistNum, source, output):
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
                newTrack["site_title"] = f"FLAC Audio / {match}"
                newTrack["eac3to"] = re.sub("\..*", ".flac", track["eac3to"])
                newTrack["file"] = os.path.join(
                    output, newTrack["eac3to"].split(":")[1])
                newTrack["child"] = None
                key = random.randint(100000, 999999)
                newTrack["key"] = key
                insertDict.append((i+1, newTrack))
        for tup in insertDict:
            current_tracks.insert(tup[0], tup[1])
        os.chdir(start)
