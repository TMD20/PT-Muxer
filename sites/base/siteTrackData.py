import os
import re

from mediadata.tracksData import TracksData
import mediatools.eac3to as eac3to


class siteTrackData(TracksData):
    def __init__(self):
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

    def addTracks(self, quicksum, playlistNum, source, output):
        self.updateRawTracksDict(
            quicksum, playlistNum, source, output)
        current_tracks = self.filterBySource(source)["tracks"]
        self._updateTrackDictNames(current_tracks)
        self._updateTrackDictEac3to(current_tracks)
        self._updateTrackDictFileOutput(current_tracks, output)
        self._updateTrackDictNotes(current_tracks)
        self._updateTrackEac3toExtra(current_tracks)

        return current_tracks

    ################################################################################################################
    #   Getter Functions
    ################################################################################################################

    @property
    def sources(self):
        return self._sources

    """
    Private Functions
    """

    #####################################################################################################################
    #       These Functions add Addition Data to Tracks Obj
    ################################################################################################################

    def _updateTrackDictNames(self, tracks):
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

    def _updateTrackDictEac3to(self, tracks):
        for track in tracks:
            type = track["type"]
            line = track["site_title"] or track["bdinfo_title"]

            langcode = track["langcode"]
            index = track["index"]
            if type == "audio":
                track["eac3to"] = eac3to.getAudioFileName(
                    line, langcode, index)
            elif type == "video":
                track["eac3to"] = eac3to.getVideoFileName(line, index)
            elif type == "subtitle":
                track["eac3to"] = eac3to.getSubFileName(
                    langcode, index)

    def _updateTrackDictFileOutput(self, tracks, output):
        for track in tracks:
            track["file"] = os.path.join(output, track["eac3to"].split(":")[1])

    def _updateTrackDictNotes(self, tracks):
        for track in tracks:
            track["notes"] = "Add Your Own if You want"

    def _updateTrackEac3toExtra(self, tracks):
        for track in tracks:
            if re.search("LPCM|TrueHD|DTS-HD MA|DTS:.*?X", track["bdinfo_title"], re.IGNORECASE) == None and track["type"] == "audio":
                track["eac3to_extras"] = track.get("eac3to_extras") or []
                track["eac3to_extras"].append("-keepDialnorm")

    #####################################################################################################################
    #       These Functions Will make a best effort to Give the Track the Proper Name.
    #       Like Sorting Functions These May have to be overwritten based on Specific Site Rules
    ################################################################################################################

    def _getAudioName(self, bdinfo, compat, parent):
        if compat:
            return self._getCompatTrack(bdinfo, parent)
        else:
            return self._getNormalTrack(bdinfo)

    def _getSubName(self, bdinfo):
        return

    def _getVideoName(self, bdinfo):
        codec = re.search(".*?(?= /)", bdinfo).group(0)
        other = re.search("(?<=/ )[0-9].*", bdinfo).group(0)
        return re.sub(" +", " ", f"{codec} / {other}")
#####################################################################################################################
  #     Track Name Helpers
  ################################################################################################################

    def _getCompatTrack(self, bdinfo, parent):
        bdinfo = bdinfo.rstrip().lstrip()
        bdinfo = re.sub("/ *", "/ ", bdinfo)
        site_title = None
        if re.search("DTS Core", bdinfo):
            return
        elif not re.search("True", parent, re.IGNORECASE):
            return
        elif re.search("Dolby Digital", bdinfo):
            site_title = f"Compatibility Track / {bdinfo}"
        elif re.search("AC3 Embedded:", bdinfo):
            match = re.search(".*?:.*?([0-9].*(bit|kbps))", bdinfo).group(1)
            site_title = f"Compatibility Track / Dolby Digital Audio / {match}"
        site_title = re.sub("\/.*DN", "", site_title)
        return re.sub("  .*", " ", site_title).strip()

    def _getNormalTrack(self, bdinfo):
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
