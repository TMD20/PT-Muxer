import os
from typing import List

from src.sites.base.siteTrackSorter import siteTrackSorter
import src.tools.general as utils


class AnimeBytes(siteTrackSorter):
    """
    This class is for sorting tracks for animebyes

    Args:
        siteTrackSorter (class): The base track sorter class
    """

    def __init__(self) -> None:
        super().__init__()

    def addForcedSubs(self, movieLang: List[str], audioPref: List[str]) -> None:
        """
        This function sets forced subs by extracting or setting the flag on 
        a detected track

        Args:
            movieLang (array): list of movie languages
            audioPref (array): list of user preference for language
        """
        super().addForcedSubs(movieLang, audioPref)
        # set force track
        forceDict = {}
        for track in self._unSortedSub:
            key = track["sourceKey"]
            if forceDict.get(key) == None:
                forceDict[key] = [track]
            else:
                forceDict[key].append(track)
        for key in list(forceDict.keys()):
            keyTracks = list(
                filter(lambda x: (x["sourceKey"] == key and x["lang"].lower() == "english"), self._unSortedSub))
            # Check if a source already has forced subs
            if len(list(
                    filter(lambda x: (x["forced"] == True), keyTracks))) > 0:
                continue
            # Try to find force track
            if len(keyTracks) < 2:
                continue
            forcedTrack = keyTracks[0]
            if os.path.getsize(keyTracks[1].getTrackLocation()) < os.path.getsize(keyTracks[0].getTrackLocation()):
                forcedTrack = keyTracks[1]
            forcedTrack["default"] = True
            forcedTrack["forced"] = True
            forcedTrack["site_title"] = "For Non English Parts"

    def _getAudioPrefs(self, movieLang: List[str], audioPrefs: List[str]) -> List[str]:
        """
        Gets audio prefrence
        If no langauges are supply animebyes will return English and Japanese 

        Args:
            movieLang (array): movie language data from source like imdb
            audioPrefs (array): users audio preference data

        Returns:
            _array: Finalized list of languages
        """
        if len(audioPrefs) > 0:
            return utils.removeDupesList(audioPrefs)
        otherLangs = list(filter(lambda x: x.lower() !=
                                 "english" and x.lower() != "japanese", movieLang))
        # Prioritize japanese and english
        langs = ["English", "Japanese"]
        langs.extend(otherLangs)
        return list(map(lambda x: x.lower(), langs))

    def _sortAudio(self, audioTracks: List[str], audioLang: List[str], sortPref: str) -> None:
        """
        Function to sort audio tracks
        Preference is given to English and Japanese tracks

        Args:
            audioTracks (array): list of tracks dictionary
            audioLang (array): list of track language preference
            sortPref (str): users preference for track sorting
        """
        super()._sortAudio(audioTracks, audioLang, sortPref)
        # Change Original Audio to Japanese
        # set original language flag
        newTracks = [ele for ele in audioTracks if ele["lang"].lower()
                     == "japanese" and ele["compat"] == False]
        for track in newTracks:
            track["original"] = True
        newTracks = [ele for ele in audioTracks if ele["lang"].lower()
                     == "english" and ele["compat"] == False]
        for track in newTracks:
            track["original"] = False
