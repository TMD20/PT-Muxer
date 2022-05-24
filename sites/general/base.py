
import os
import re
import general.util as util

import mediadata.tracksData as tracksData
import mediatools.eac3to as eac3to


class siteBaseClass():
    """"
    Rules
    Titling:
        Title:Movie Name / Movie Year / Edition / Relevant Information / Group Tag (If Applicable)
        Series Name / Series Year (If applicable) / Season Number(+Episode Number for Single Episodes) / Edition (If Applicable) / Relevant Information / Group Tag (If Applicable)

        - 3.3.1 Movie Name: The Official English name of the movie according to IMDB or TMDB, use AKA to include the Original title if applicable
        - 3.3.2 Movie Year: The year the movie was released according to IMDB or TMDB
        - 3.3.3 Series Name: The Official English name of the Series according to IMDB, TMDB or TVDB, use AKA to include the Original title if applicable
        - 3.3.4 Series Year: The year in which the Series (not the season) was officially released, only to be included if there is more than one Series with the same name (Check TVDB Naming)
        - 3.3.5 Season Number: The Number of the Season formatted as Sxx, with xx being the corresponding season number (Always use 2 numbers, so for Season 1 this will be S01)
        - 3.3.6 Episode Number: The number of the Episode of that Season formatted as Exx, with xx being the corresponding episode number (Always use 2 numbers, so for Episode 1 this will be E01)
        - 3.3.7 Edition: The edition of a release, this can be Extended, Theatrical, Uncut, Unrated, etc
        - 3.3.8 Group Tag: DVD + Blurays shouldn't have NOGRP or NOGROUP unless its in the folder of the disc. just leave it tagless
        - 3.3.9 Group Tag: Remux/encodes/web-dl .. if no tag.. should have -NOGROUP (not NoGroup or N


        Relevent Info
        Source (Not applicable for discs): The source of the content, this can be BluRay/....
        - 3.4.3 Video Resolution: The resolution of the video, this can be 2160p, 1080p, 1080i, 720p, 576p or 480p
        - 3.4.4 Audio Codec + Audio Channels: The codec of the main audio track including the channels separated by a space, for example: TrueHD Atmos 7.1, TrueHD 5.1 DTS:X 7.1, DTS-HD MA 5.1, DD+ Atmos 5.1, AAC 2.0, FLAC 1.0, etc - The only exception to this is for DD, where its DD2.0 or DD5.1, etc.
        - 3.4.5 Video Codec: For encodes this is either x264 or x265, for WEB this can be H.264 or HEVC and for discs this can be HEVC, AVC, VC-1 or MPEG-2. HEVC discs and remuxes are HDR by default, if this is not the case also include SDR in the title. For other HEVC, x265 content SDR is the default, if this is not the case include HDR in the title.
        - 3.4.6 Remux Tag (Only for Remuxes): If a release is a remux, put REMUX in the title. If the main audio and video track come from different sources use HYBRID REMUX instead.

 TrackRules
    - 2.5.5 English subtitles for foreign parts should be included as a separate subtitle track and set to Forced.
    - 2.5.4 The audio codec must be either AAC, AC3, DTS, DTS-ES, DTS-HD, TrueHD, Opus or FLAC.
    - 2.5.1 The main audio track must be the original lang.

 TrackNaming
   Note: Beyond Doesn't seem to have any default to quick summary
   From Blu
   Audio track title naming exceptions:

Prepend details of alternative audio mixes if applicable:
E.g. Surround Upmix / DTS-HD Master Audio / 5.1 / 48 kHz / 3611 kbps / 24-bit
E.g. Original Mix / DTS-HD Master Audio / 4.0 / 48 kHz / 2947 kbps / 24-bit
E.g. Stereo Mix / FLAC Audio / 2.0 / 48 kHz / 1352 kbps / 16-bit
E.g. Stereoized Mono / FLAC Audio / 2.0 / 48 kHz / 387 kbps / 16-bit
Lossless tracks converted to FLAC should be labelled as follows:
E.g. FLAC Audio / 2.0 / 48 kHz / 752 kbps / 16-bit
The compatibility track embedded in TrueHD tracks should be labelled as follows:
E.g. Compatibility Track / Dolby Digital Audio / 5.1 / 48 kHz / 640 kbps
English dubs should be labelled as follows:
E.g. Dub / Dolby TrueHD Audio / 5.1 / 48 kHz / 2342 kbps / 24-bit



           tempdict["useFile"]="True"
            tempdict["useTitle"]="True"
            tempdict["default"]="False"
            tempdict["Comment"]="No Comment"
    """

    def __init__(self):
        self._unSortedAudio = []
        self._unSortedVideo = []
        self._unSortedSub = []
        self._enabledAudio = []
        self._enabledSub = []
        self._enabledVideo = []
        self._sources = []
        self._tracksDataObj = tracksData.TracksData()


    """
    Public Functions
    """

    ################################################################################################################
    ###### This Function use the Tracksdata class to create a TracksData Object Filled with                        #
    #       Raw Tracks Data filled with Data from BDINFO Tracks                                                    #
    #       Additionally it adds Data about the trackname                                                          #
    ################################################################################################################

    def addTracks(self, quicksum, playlistNum, source, output):
        self._tracksDataObj.createRawTracksList(
            quicksum, playlistNum, source, output)
        current_tracks = self._tracksDataObj.getSourcesTracks(source)
        self._addTrackNames(current_tracks)
        self._addTrackEac3to(current_tracks)
        self._addTrackFileOutput(current_tracks, output)
        self._sources.append(util.getShowName(source))

    ################################################################################################################
    #       Sort  Tracks Based on
    #           - Type
    #           - User Pref
    #           - Specific Site Rules
    #       Use Sort Helper Functions
    #       See Overwritable Section
    #
    ################################################################################################################

    def sortTracks(self, pref):
        self._groupTracks()
        self._sortTracksHelper(pref)
    ######################################################################################
    # Creates a Information Dictionary to be Outputted into txt file
    # Used by Remux arg to create the final mkv.
    ########################################################################################

    def getTracksDict(self):
        dict = {}
        dict["Sources"] = {}
        for key in self._sources:
            trackObj = self._tracksDataObj.rawMediaTracksData[key]
            dict["Sources"][key] = {}
            dict["Sources"][key]["Output"] = trackObj["output"]
            dict["Sources"][key]["Location"] = trackObj["source"]
        dict["Enabled_Tracks"] = {}
        dict["Enabled_Tracks"]["Video"] = list(
            map(lambda x: x["key"], self._enabledVideo))
        dict["Enabled_Tracks"]["Audio"] = list(
            map(lambda x: x["key"], self._enabledAudio))
        dict["Enabled_Tracks"]["Sub"] = list(
            map(lambda x: x["key"], self._enabledSub))
        dict["Tracks_Details"] = {}
        dict["Tracks_Details"]["Audio"] = {}
        dict["Tracks_Details"]["Sub"] = {}
        dict["Tracks_Details"]["Video"] = {}
        for track in self._unSortedAudio:
            key = track["key"]
            track.pop("key")
            dict["Tracks_Details"]["Audio"][key] = track
        for track in self._unSortedSub:
            key = track["key"]
            track.pop("key")
            dict["Tracks_Details"]["Sub"][key] = track
        for track in self._unSortedVideo:
            key = track["key"]
            track.pop("key")
            dict["Tracks_Details"]["Video"][key] = track

        return dict

    ################################################################################################################
    #   Getter Functions
    ################################################################################################################

    @property
    def sources(self):
        return self._sources

    @property
    def tracksDataObj(self):
        return self._tracksDataObj

    """
    Private Functions
    """

    def _sortTracksHelper(self, pref):
        self._sortAudio(pref)
        self._sortCompatAudio()
        self._sortSub()
        self._sortVideo(pref)

    """
    OverWritable Private
    """

    ################################################################################################################
    #       These Functions Will make a best effort to sort Tracks in a way that fits within site rules
    #        Because Every Site has different Rules about What Track to Put First, and which ones not to include this
    #        will have to be overwritten based on Site.
    ################################################################################################################

    def _sortAudio(self, pref):
        # Figure out MainTrack Contendors.
        # Based on Order, and other factors

        mainLang = self._unSortedAudio[0]["lang"]
        mainTracks = mainTracks = list(
            filter(lambda x: x["lang"] == mainLang, self._unSortedAudio))
        mainTracks = mainTracks = list(
            filter(lambda x: x["compat"] == False, mainTracks))

        if pref == "largest":
            largest = 0
            data = None
            for track in mainTracks:
                if os.path.getsize(track["file"]) > largest:
                    largest = os.path.getsize(track["file"])
                    data = track
            self._enabledAudio.append(data)

        elif pref == "first":
            largest = 0
            self._enabledAudio.append(mainTracks[0])

    def _sortCompatAudio(self):
        tracks = list(
            filter(lambda x: x["compat"] == True, self._unSortedAudio))
        indexes = list(map(lambda x: x["index"], self._enabledAudio))
        sources = list(map(lambda x: x["source"], self._enabledAudio))
        for track in tracks:
            if track["index"] in indexes and track["source"] in sources:
                self._enabledAudio.append(track)

    def _sortSub(self):
        # Figure out MainTrack Contendors.
        # Based on Order, and other factors
        langSet = set()
        for track in self._unSortedSub:
            if track["lang"] not in langSet:
                self._enabledSub.append(track)
                langSet.add(track["lang"])

    def _sortVideo(self, pref):
        # Figure out MainTrack Contendors.
        # Based on Order, and other factors
        langSet = set()
        if pref == "first":
            self._enabledVideo.append(self._unSortedVideo[0])
        elif pref == "largest":
            largest = 0
            data = None
            for track in self._unSortedVideo:
                if os.path.getsize(track["file"]) > largest:
                    largest = os.path.getsize(track["file"])
                    data = track
            self._enabledVideo.append(data)

    #####################################################################################################################
    #       These Functions Will make a best effort to Give the Track the Proper Name.
    #       Like Sorting Functions These May have to be overwritten based on Specific Site Ruels
    ################################################################################################################

    def _getAudioName(self, bdinfo):
        if re.search("LPCM", bdinfo):
            return "FLAC Audio /${bdinfo}"
        if re.search("Dolby Digital", bdinfo):
            return "Compatibility Track /${bdinfo}"
        return bdinfo

    def _getSubName(self, bdinfo):
        return None

    def _getVideoName(self, bdinfo):
        return bdinfo

    """
    Static Private Functions
    """

    #####################################################################################################################
    #       Adds Tracks to Unsorted List based on Type
    ################################################################################################################

    def _groupTracks(self):
        for key in self._sources:
            tracks = self._tracksDataObj.getSourcesTracks(key)
            for track in tracks:
                type = track["type"]
                bdinfo = track["bdinfo"]
                if type == "audio":
                    self._unSortedAudio.append(track)
                elif type == "video":
                    self._unSortedVideo.append(track)
                elif type == "subtitle":
                    self._unSortedSub.append(track)
    #####################################################################################################################
    #       These Functions add Addition Data to Tracks Obj
    ################################################################################################################

    def _addTrackNames(self, tracks):
        for track in tracks:
            type = track["type"]
            bdinfo = track["bdinfo"]
            if type == "audio":
                track["title"] = self._getAudioName(bdinfo)
            elif type == "video":
                track["title"] = self._getVideoName(bdinfo)
            elif type == "subtitle":
                track["title"] = self._getSubName(bdinfo)

    def _addTrackEac3to(self, tracks):
        for track in tracks:
            type = track["type"]
            line = track["bdinfo"]
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

    def _addTrackFileOutput(self, tracks, output):
        for track in tracks:
            track["file"] = os.path.join(output, track["eac3to"].split(":")[1])
