
import os


class Blu():
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


class BeyondHD():
    def __init__(self):
        self._unSortedAudio = []
        self._unSortedVideo = []
        self._unSortedSub = []
        self._enabledAudio = []

    """
   Public Functions
    """

    def addTrack(self, type, title, file, code=None, lang=None, combat=None):
        if type == "audio":
            data = {"title": title, "file": file,
                    "code": code, "lang": lang, "combat": combat}
            self._unSortedAudio.append(data)
        elif type == "video":
            data = {"title": title, "file": file}
            self._unSortedVideo.append(data)
        elif type == "subtitle":
            data = {"title": title, "file": file, "code": code, "lang": lang}
            self._unSortedSub.append(data)

    def createTracksDict(self, args):
        self._sortAudio(args.audioRule)

    """
   Private Functions
    """

    def sortAudio(self, rule):
        # Figure out MainTrack Contendors.
        # Based on Order, and other factors

        mainLang = self._unSortedAudio[0]["lang"]
        mainTracks = mainTracks = list(filter(
            lambda x: x["lang"] == mainLang, self._unSortedAudio))
        otherTracks = list(filter(
            lambda x: x["lang"] != mainLang, self._unSortedAudio))

        if rule == "largest":
            largest = 0
            data = mainTracks[0]
            for track in mainTracks:
                if os.path.getsize(track["file"]) > largest:
                    largest = os.path.getsize(track["file"])
                    data = track
            self._enabledAudio.append(data)

            largest = 0
            sizeDict = {}
            dataDict = {}
            for track in otherTracks:
                currLang = track["lang"]
                largest = sizeDict.get(currLang) or 0
                if os.path.getsize(track["file"]) > largest:
                    dataDict[currLang] = track
                    sizeDict[currLang] = os.path.getsize(track["file"])
            for key in dataDict:
                self._enabledAudio.append(dataDict[key])

        if rule == "first":
            largest = 0
            dataDict = {}
            self._enabledAudio.append(mainTracks[0])
            for track in otherTracks:
                currLang = track["lang"]
                if dataDict.get(currLang) == None:
                    dataDict[currLang] = track
                    self._enabledAudio.append(track)
