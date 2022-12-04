import os
import re

from mediadata.sourceData import sourceData
import tools.general as utils



class siteTrackData(sourceData):
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

    def addTracks(self,bdObj,playlistNum,output):
        bdObjDict=bdObj.Dict[playlistNum]
        quicksum=bdObjDict["quickSum"]
        playlistFile=bdObjDict["playlistFile"]
        streams=bdObjDict["playlistStreams"]
        source=bdObj.mediaDir
        self["source"]=source

        self.updateRawTracksDict(source,
            quicksum, playlistNum, playlistFile, streams,output)
        current_tracks = self["tracks"]
        self._updateTrackDictFileNames(current_tracks)
        self._updateTrackDictNames(current_tracks)

        return current_tracks
     #######################################################################
    #  This Function will convert certain lossless Tracks to flac
    ########################################################################

    def convertFlac(self, current_tracks, output):
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
    def source(self):
        return self.get("source")
    @property 
    def showname(self):
        if self.get("source"):
            return utils.sourcetoShowName(self.get("source"))
        return

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

   
    def _updateTrackDictFileNames(self, tracks):
        for track in tracks:
            type = track["type"]
            line = track.get("site_title") or track.get("bdinfo_title")

            langcode = track["langcode"]
            index = track["index"]
            if type == "audio":
                track["filename"] = sourceData.getAudioFileName(
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


