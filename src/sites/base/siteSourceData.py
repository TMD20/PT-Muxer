from __future__ import annotations

import re
from typing import TYPE_CHECKING, List, Union


from src.mediadata.sourceData import sourceData
import src.tools.general as utils
if TYPE_CHECKING:
    import mediatools.bdinfo as bdinfo
    import mediadata.trackObj as trackObj


class siteSourceData(sourceData):
    """attributes
    Base class sitesourceData
    extended from sourceData class with modifications that are
    made for private trackers

    Args:
        sourceData (class): source and track data class
    """

    def __init__(self) -> None:
        super().__init__()

    """
    Public Functions
    """

    ################################################################################################################
    ###### This Function use the Tracksdata class to create a TracksData Object Filled with                        #
    #       Raw Tracks Data filled with Data from BDINFO Tracks                                                    #
    #       Additionally it adds Data about the trackname

    #       Tracksdata Dict is split by source
    ################################################################################################################

    def addTracks(self, bdinfo: bdinfo.Bdinfo, playlistNum: int, streams: Union[List[dict], None] = None) -> List[trackObj.TrackObJ]:
        """
        This function handles adding tracks/sources to internal dictionaries

        Args:
            bdinfo (obj): bdinfo object
            playlistNum (int): playlist number for tracks
            streams (array, optional): This is the list of streams tracks are from. Defaults to None.

        Returns:
            dict: The return value is an dictionary generated from tracks
        """
        bdObjDict = bdinfo.Dict[playlistNum]
        if streams == None:
            streams = bdObjDict["playlistStreams"]
        self._setUp(playlistNum, bdinfo, streams)

        quicksum = bdObjDict["quickSum"]

        self.updateRawTracksDict(quicksum)
        self._updateTrackDictFileNames()
        self._updateTrackDictNames()
        return self.tracks

     #######################################################################
    #  This Function will convert certain lossless Tracks to flac
    ########################################################################

    def convertFlac(self) -> None:
        """
        Converts certain lossless tracks to FLAC
        based on common tracker rules
        """
        current_tracks = self.tracks
        for i in range(len(current_tracks)):
            track = current_tracks[i]
            if track["type"] != "audio":
                continue
            title = track["bdinfo_title"]
            channels = re.search("\d.\d", title)
            if channels == None:
                continue
            channels = float(channels.group(0))
            file = track["filename"]
            if re.search("LPCM|TrueHD|DTS-HD MA|DTS:.*?X", title, re.IGNORECASE)\
                    and channels < 3.0:
                match = re.search(".*([0-9]\.[0-9].*)", title).group(1)
                title = f"FLAC Audio / {match}"
                title = re.sub(" +", " ", title)
                track["site_title"] = title
                track["filename"] = re.sub("\..*", ".flac", file)

    ################################################################################################################
    #   Getter Functions
    ################################################################################################################

    @property
    def source(self) -> str:
        """
        returns path to source used to generate object

        Returns:
            str: path to source
        """
        return self.get("source")

    @property
    def showname(self) -> Union[str, None]:
        """
        returns showname or modifified basename of source
        Returns:
            str,None: showname/modifified basename or None if source not set
        """
        if self.get("source"):
            return utils.sourcetoShowName(self.get("source"))
        return

    """
    Private Functions
    """

    #####################################################################################################################
    #       These Functions add Addition Data to Tracks Obj
    ################################################################################################################

    def _updateTrackDictNames(self) -> None:
        """
        Updates tracks with site Names or title that should appear on final mkv
        """
        tracks = self.tracks
        for track in tracks:
            type = track["type"]
            bdinfo = track["bdinfo_title"]
            compat = track.get("compat")
            parent = track.get("parent")
            if type == "audio":
                track["site_title"] = self._getAudioName(
                    bdinfo, compat, parent)
            elif type == "video":
                track["site_title"] = self._getVideoName(bdinfo)
            elif type == "subtitle":
                track["site_title"] = self._getSubName(bdinfo)

    def _updateTrackDictFileNames(self) -> None:
        """
        Generates filenames for tracks
        """
        tracks = self.tracks
        for track in tracks:
            type = track["type"]
            line = track.get("site_title") or track.get("bdinfo_title")

            langcode = track["langcode"]
            index = track["index"]
            if type == "audio":
                track["filename"] = sourceData._getAudioFileName(
                    line, langcode, index)
            elif type == "video":
                track["filename"] = sourceData.getVideoFileName(line, index)
            elif type == "subtitle":
                track["filename"] = sourceData.getSubFileName(
                    langcode, index)

    #####################################################################################################################
    #       These Functions Will make a best effort to Give the Track the Proper Name.
    #       Like Sorting Functions These May have to be overwritten based on Specific Site Rules
    ################################################################################################################

    def _getAudioName(self, bdinfo: str, compat: bool, parent: str) -> str:
        """
        Helper function to genreate audio track site Name

        Args:
            bdinfo (str): original bdinfo line for track
            compat (bool): whether or not this is compat track
            parent (str): original bdinfo line of parent track

        Returns:
            str: modified title based on general private tracker rules
        """
        if compat:
            return self._getCompatTrack(bdinfo, parent)
        else:
            return self._getNormalTrack(bdinfo)

    def _getSubName(self, bdinfo: str) -> None:
        """
        Generates subtitle track site Name

        Args:
            bdinfo (str): original bdinfo line for track
        """
        return

    def _getVideoName(self, bdinfo: str) -> None:
        codec = re.search(".*?(?= /)", bdinfo).group(0)
        other = re.search("(?<=/ )[0-9].*", bdinfo).group(0)
        return re.sub(" +", " ", f"{codec} / {other}")
#####################################################################################################################
  #     Track Name Helpers
  ################################################################################################################

    def _getCompatTrack(self, bdinfo: str, parent: str) -> str:
        """
        Helper function to get compat track site Name

        Args:
            bdinfo (str):original bdinfo line for embedded compat track
            parent (str): original bdinfo line for parent track

        Returns:
            str: modified site track Name 
        """
        bdinfo = bdinfo.rstrip().lstrip()
        bdinfo = re.sub("/ *", "/ ", bdinfo)
        site_title = None
        if re.search("DTS Core", bdinfo):
            match = re.search(".*?:.*?([0-9].*(bit|kbps))", bdinfo).group(1)
            site_title = f"Compatibility Track / DTS Core/ {match}"
        elif not re.search("True", parent, re.IGNORECASE):
            return
        elif re.search("Dolby Digital", bdinfo):
            site_title = f"Compatibility Track / {bdinfo}"
        elif re.search("AC3 Embedded:", bdinfo):
            match = re.search(".*?:.*?([0-9].*(bit|kbps))", bdinfo).group(1)
            site_title = f"Compatibility Track / Dolby Digital Audio / {match}"
        site_title = re.sub("\/.*DN", "", site_title)

        return re.sub(" +", " ", site_title).strip()

    def _getNormalTrack(self, bdinfo: str) -> str:
        """
        Function to get site Name for normal Tracks

        Args:
            bdinfo (str): original bdinfo line for track

        Returns:
            str: modified site track name for normal tracks
        """
        bdinfo = bdinfo.strip()
        site_title = None

        # Dolby Surrond
        if re.search("Dolby Digital.*Dolby Surround", bdinfo, re.IGNORECASE):
            match = re.search(".*(?=/ Dolby Surround)", bdinfo).group(0)
            site_title = f"Dolby Surround / {match}"
        # Catch all
        else:
            codec = re.search(".*?(?= /)", bdinfo).group(0)
            other = re.search(".*([0-9]\.[0-9].*)", bdinfo).group(1)
            site_title = f"{codec} / {other}"
        site_title = re.sub("/ DN.*dB", "", site_title)
        return re.sub(" +", " ", site_title).strip()
