import re
import os

from sites.base.siteTrackSorter import siteTrackSorter
import tools.paths as paths


class Blu(siteTrackSorter):
    def __init__(self):
        super().__init__()

    def sortTracks(self, movieLangs, audioPrefs, subPrefs, sortPrefs):
        super().sortTracks(movieLangs, audioPrefs, subPrefs, sortPrefs)
        i = 1
        ####
        # Check to see if we should go with a FLAC converted Track/ Or the original
        #####
        remove = []
        while i < len(self._unSortedAudio):

            track = self._unSortedAudio[i]
            prevTrack = self._unSortedAudio[i-1]
            source = track["sourceKey"]
            prevSource = prevTrack["sourceKey"]

            filename = track.getTrackLocation()

            t = None
            # guard cases
            if source != prevSource:
                i = i+1
                continue
            if track["site_title"] == None:
                i = i+1
                continue
            if not re.search("\.flac$", track["filename"], re.IGNORECASE):
                i = i+1
                continue


           

            with open( paths.search(track["outputDir"],"Eac3to",dir=False)[0] ,"r") as p:
                t = p.read()
                group = re.search(
                    f"(\[.*\]) Creating file \"{filename}\"", t).group(1)
                match1 = re.search(f"{group}.*Superfluous zero bytes", t)
                match2 = re.search(f"{group}.*average", t)

                if match1 or match2:
                    remove.append(prevTrack["key"])
                else:
                    remove.append(track["key"])
                i = i+1
            i = 0
            while i < len(self._enabledAudio):
                track = self._enabledAudio[i]
                if track["key"] in remove:
                    self._enabledAudio.pop(i)
                else:
                    i = i+1
