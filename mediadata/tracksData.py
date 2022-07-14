import random
import os
import re

import langcodes

import tools.general as util


class TracksData():
    def __init__(self):
        self._rawMediaTracksData = {}
        self._sources=[]

    """
    Public Functions
    """

    ################################################################################################################
    ###### These Function adds every track from bdinfo list of tracks to a dictionary                              #
    #It also adds data about the source of the information, and where to output it                                 #
    ################################################################################################################

    def updateRawTracksDict(self, trackStrs, playlistNum, source, output):
        tracks = []
        for index, currline in enumerate(trackStrs):
            index = index+2
            self._appendTrack(currline, index, tracks)
        for track in tracks:
            track["sourceDir"] = source
            track["sourceKey"] = util.getShowName(source)
        self._expandRawTracksData(tracks, playlistNum, source, output)
        self.addSource(source)
    
  
   
    
    def addSource(self, source):
        self._sources.append(util.getShowName(source))

    ################################################################################################################
    #   Getter Functions
    ################################################################################################################

    
    
    @property
    def rawMediaTracksData(self):
        return self._rawMediaTracksData

    def filterBySource(self, source):
        return self._rawMediaTracksData.get(util.getShowName(source))

    """
   Private
    """

    ################################################################################################################
    ###### These Functions are used to parse Data from String for the corresponding Track Type i.e Video, Audio,etc#
    ################################################################################################################

    def _videoParser(self, currline):
        tempdict = {}
        bdinfo = re.search(
            "(?:.*?: (.*))", currline).group(1)
        tempdict = self._defaultMediaDict(bdinfo)
        tempdict["type"] = "video"
        return tempdict

    def _audioParser(self, currline):
        tempdict = {}
        lang = self._medialang(currline)
        langcode = self._mediacode(lang)
        bdinfo = list(filter(lambda x: x != None, list(
            re.search("(?:.*?/ )(?:(.*?) \(.*)?(.*)?", currline).groups())))[0]
        tempdict = self._defaultMediaDict(bdinfo, langcode, lang)
        tempdict["type"] = "audio"
        return tempdict

    def _audioCompatParser(self, currline):
        tempdict = {}
        lang = self._medialang(currline)
        langcode = self._mediacode(lang)
        bdinfo = re.search("(?:.*?)(?:\((.*?)\))", currline)
        if bdinfo == None:
            return
        bdinfo = list(filter(lambda x: x != None, list(bdinfo.groups()
                                                       )))
        if len(bdinfo) == 0:
            return
        bdinfo = bdinfo[0]
        tempdict = self._defaultMediaDict(bdinfo, langcode, lang)
        tempdict["type"] = "audio"
        tempdict["compat"] = True
        return tempdict

    def _subParser(self, currline):
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
        tempdict["bdinfo_title"] = bdinfo
        tempdict["langcode"] = langcode
        tempdict["lang"] = lang
        tempdict["compat"] = False
        tempdict["default"] = False
        tempdict["machine_parse"] = []
        tempdict["length"] = None
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
        match = re.search("([a-z|A-Z]*?):", currline, re.IGNORECASE).group(1)
        if match == "Video":
            tempdict = self._videoParser(currline)
        elif match == "Audio":
            tempdict = self._audioParser(currline)
            tempdict2 = self._audioCompatParser(currline)
        elif match == "Subtitle":
            tempdict = self._subParser(currline)

        key = random.randint(100000, 999999)
        tempdict["key"] = key
        tempdict["index"] = index
        tempdict["parent"]=None
        tempdict["child"]=None
        tracks.append(tempdict)
        if tempdict2 != None:
            key = random.randint(100000, 999999)
            tempdict2["key"] = key
            tempdict2["index"] = index
            tempdict2["child"] =None
            tempdict2["parent"]=tempdict["bdinfo_title"]
            tempdict["child"] =tempdict2["bdinfo_title"]
            tempdict["parent"]=None
            tracks.append(tempdict2)

    #Primary Key are Basename Source
    # Tracks are Objects
    # Output is a a string
    def _expandRawTracksData(self, tracks, playlistNum, source, output):
        self._rawMediaTracksData[util.getShowName(source)] = {}
        self._rawMediaTracksData[util.getShowName(source)]["tracks"] = tracks
        self._rawMediaTracksData[util.getShowName(source)]["outputDir"] = output
        self._rawMediaTracksData[util.getShowName(
            source)]["sourceDir"] = source
        self._rawMediaTracksData[util.getShowName(
            source)]["playlistNum"] = playlistNum
