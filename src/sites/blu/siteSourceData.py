from __future__ import annotations 
import re
import copy
from typing import TYPE_CHECKING, List,Union

import xxhash

from src.sites.base.siteSourceData import siteSourceData
if TYPE_CHECKING:
    import mediatools.bdinfo as bdinfo
    import mediadata.trackObj as trackObj
 

class Blu(siteSourceData):
    """
    This is an extension of the siteSourceData class with modifications made to fit 
    blutopia rules

    Args:
        siteSourceData (class): base class for all siteSource classes
    """
    def __init__(self)->None:
        super().__init__()

    
    def addTracks(self, bdinfo:bdinfo.Bdinfo,playlistNum:int,streams:Union[List[dict],None]=None)->List[trackObj.TrackObJ]:
        """
        This function handles adding tracks/sources to internal dictionaries

        Args:
            bdinfo (obj): bdinfo object
            playlistNum (int): playlist number for tracks
            streams (array, optional): This is the list of streams tracks are from. Defaults to None.

        Returns:
            dict: The return value is an dictionary generated from tracks
        """
        current_tracks = super().addTracks(bdinfo,playlistNum,streams=None)
        
        self._checkPadding(current_tracks)
        return current_tracks

    def _checkPadding(self, current_tracks:List[trackObj.TrackObJ])->None:
        """
        This is a helper function to check padding on 24bit audio


        Args:
            current_tracks (array): list of trackObjs from addtracks function
        """
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
