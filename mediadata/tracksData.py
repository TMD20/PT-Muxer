import random
import os
import re

import langcodes

import general.util as util


class TracksData():
    def __init__(self):
        self._rawMediaTracksData = {}

    """
    Public Functions
    """

    ################################################################################################################
    ###### These Function adds every track from bdinfo list of tracks to a dictionary                              #
    #It also adds data about the source of the information, and where to output it                                 #
    ################################################################################################################

    def createRawTracksList(self, trackStrs, playlistNum, source, output):
        tracks = []
        for index, currline in enumerate(trackStrs):
            index = index+2
            self._appendTrack(currline, index, tracks)
        for track in tracks:
            track["source"] = source
        self._expandRawTracksData(tracks, playlistNum, source, output)
    

    
    ################################################################################################################
    #   Getter Functions
    ################################################################################################################

    @property
    def rawMediaTracksData(self):
        return self._rawMediaTracksData

    def getSourcesTracks(self, source):
        return self._rawMediaTracksData.get(util.getShowName(source))["tracks"]

    """
   Private
    """

    ################################################################################################################
    ###### These Functions are used to parse Data from String for the corresponding Track Type i.e Video, Audio,etc#
    ################################################################################################################

    def _videoParser(self, currline, index):
        tempdict={}
        bdinfo = re.search(
            "(?:.*?: (.*))", currline).group(1)
        tempdict = self._defaultMediaDict(bdinfo)
        tempdict["type"] = "video"
        return tempdict

    def _audioParser(self, currline, index):
        # set default
        tempdict = {}
        lang = self._medialang(currline)
        langcode = self._mediacode(lang)
        bdinfo = re.search("(?:.*?/ )(?:(.*?) \(.*)?(.*)?", currline).group(1)
        tempdict = self._defaultMediaDict(bdinfo, langcode, lang)
        tempdict["type"] = "audio"
        return tempdict

    def _audioCompatParser(self, currline, index):
        tempdict = {}
        lang = self._medialang(currline)
        langcode = self._mediacode(lang)
        bdinfo = re.search("(?:.*?)(?:\((.*?)\))", currline).group(1)
        tempdict = self._defaultMediaDict(bdinfo, langcode, lang)
        tempdict["type"] = "audio"
        tempdict["compat"] = True
        return tempdict

    def _subParser(self, currline, index):
        tempdict = {}
        lang = self._medialang(currline)
        bdinfo = currline
        langcode = self._mediacode(lang)
        tempdict = self._defaultMediaDict(bdinfo, langcode, lang)
        tempdict["type"] = "subtitle"
        return tempdict

    # Standard Track Data Helper
    def _defaultMediaDict(self, bdinfo, langcode=None, lang=None):
        tempdict = {}
        tempdict["bdinfo"] = bdinfo
        tempdict["langcode"] = langcode
        tempdict["lang"] = lang
        tempdict["compat"] = False
        return tempdict

        ################################################################################################################
        ###### These Functions are Used to get the Language/Code of a Track                                            #
        ################################################################################################################

    def _medialang(self, currline):
        return re.search("(?:.*?: )(.*?)(?: /.*)", currline).group(1)

        return tempdict

    def _mediacode(self, lang):
        try:
            return langcodes.standardize_tag(langcodes.find(lang))
        except:
            return

        ################################################################################################################
        ###### Adds Track to List                                                                                     #
        ################################################################################################################

    def _appendTrack(self, currline, index, tracks):
        tempdict = None
        tempdict2 = None
        match = re.search("(.*?):", currline).group(1)
        if match == "Video":
            tempdict = self._videoParser(currline, index)
        elif match == "Audio":
            tempdict = self._audioParser(currline, index)
            tempdict2 = self._audioCompatParser(currline, index)
        elif match == "Subtitle":
            tempdict = self._subParser(currline, index)

        key = random.randint(100000, 999999)
        tempdict["key"] = key
        tempdict["index"] = index
        tracks.append(tempdict)
        if tempdict2 != None:
            key = random.randint(100000, 999999)
            tempdict2["key"] = key
            tempdict2["index"] = index
            tracks.append(tempdict2)

    def _expandRawTracksData(self, tracks, playlistNum, source, output):
        self._rawMediaTracksData[util.getShowName(source)] = {}
        self._rawMediaTracksData[util.getShowName(source)]["tracks"] = tracks
        self._rawMediaTracksData[util.getShowName(source)]["output"] = output
        self._rawMediaTracksData[util.getShowName(source)]["source"] = source
        self._rawMediaTracksData[util.getShowName(
            source)]["playlistNum"] = playlistNum

            ################################################################################################################
        ###### Gets eac3t                                                                                   #
        ################################################################################################################

    
    
    
