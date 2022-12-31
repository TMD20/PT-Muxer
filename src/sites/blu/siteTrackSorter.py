import re

from src.sites.base.siteTrackSorter import siteTrackSorter
import src.tools.paths as paths


class Blu(siteTrackSorter):
    """
    This class is for sorting tracks based on blutopia sorting rules

    Args:
        siteTrackSorter (class): The base track sorter class
    """
    def __init__(self):
        super().__init__()

    def sortTracks(self, movieLangs, audioPrefs, subPrefs, sortPrefs):
        """
        Sorts tracks based on user prefrence and site rules on blutopia
        adds sortred tracks into internal class arrays

        Args:
            movieLangs (array): list of languages in movie
            audioPrefs (array):  list of users language preference
            subPrefs (array): list of user subtitle langauge preference
            sortPrefs (str): users prefence for which track should get higher priority
        """
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

            filename = track["filename"]

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
