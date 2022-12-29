
import re
import os

import xxhash
import langcodes

import src.tools.general as utils
import src.tools.paths as paths
import src.mediadata.trackObj as trackObj


class sourceData(dict):
    """
    Stores info from a playlist or stream for one source
    including Parsing bdinfo track names into objects

    Args:
        dict (class): python built in dict class
    """

    def __init__(self):
        super().__init__()
        self._allowedKeys = {"tracks", "source", "outputDir", "sourceDir",
                             "playlistNum", "playlistFile", "length", "streamFiles", "chapters"}
        self["tracks"] = {}
        self._source = None

    def __setitem__(self, key, value):
        """
        built in dict method 
        modified to only accept certain keys

        Args:
        key (str): key to set
        value (any): value to set key to
        """
        if key not in self._allowedKeys:
            raise AttributeError(f"sourceData does not accept {key}")
        super().__setitem__(key, value)

    """
    Public Functions
    """

    ################################################################################################################
    ###### These Function adds every track from bdinfo list of tracks to a dictionary                              #
    # It also adds data about the source of the information, and where to output it                                 #
    ################################################################################################################

    def updateRawTracksDict(self, trackStrs):
        """
        Parses bdinfo quickinfo string into objects
        Args:
            trackStrs (str): list of track strings from bdinfo quickinfo
        """
        source = self._source
        offset = 1
        for index, currline in enumerate(trackStrs):
            self._appendTrack(currline, index+offset, source)
        self._setSourceDict()

    def setOutPutDir(self, output,sourceDir=None):
        """
        Helper Function to set outputdir
        Args:
            output (str): parent output path
            sourceDir(str,optional): full directory to source
        Returns:
            str: path to sources outputdir in demuxFolder
            
        """
        source = self._source or sourceDir
        for track in self.tracks:
            track["outputDir"] = os.path.join(
                output, utils.sourcetoShowName(source))
        self["outputDir"] = os.path.join(
            output, utils.sourcetoShowName(source))

    def getVideoFileName(line, index):
        """
        Gets video filename base on parsed video type

        Args:
            line (str): line from bdinfo quickinfo
            index (index): track index or line count

        Returns:
            str: str for filename
        """
        if re.search("AVC", line) != None:
            return f"00{index}.h264"
        if re.search("HEVC", line) != None:
            return f"00{index}.h265"
        if re.search("VC-1", line) != None:
            return f"00{index}.vc1"
        if re.search("MPEG-2", line) != None:
            return f"00{index}.mpeg2"

    def getAudioFileName(line, langcode, index):
        """
        Gets audio filename base on parsed video type

        Args:
            line (str): line from bdinfo quickinfo
            index (index): track index or line count

        Returns:
            str: str for filename
        """
        # Lossless audio
        if re.search("flac", line, re.IGNORECASE) != None:
            codec = "flac"

        elif re.search("lpcm", line, re.IGNORECASE) != None:
            codec = "pcm"
        elif re.search("Master Audio", line, re.IGNORECASE) != None:
            codec = "dtsma"

        elif re.search("TrueHD", line, re.IGNORECASE) != None:
            codec = "thd"

        elif re.search("Dolby Digital", line, re.IGNORECASE) != None:
            codec = "ac3"
        elif re.search("AC3 Embedded", line, re.IGNORECASE) != None:
            codec = "ac3"

        elif re.search("DTS Audio", line, re.IGNORECASE) != None:
            codec = "dts"
        elif re.search("dts", line, re.IGNORECASE) != None:
            codec = "dts"

        return f"00{index}-{langcode}.{codec}"

    def getSubFileName(langcode, index):
        """
        Gets audio filename base on parsed video type

        Args:
            line (str): line from bdinfo quickinfo
            index (index): track index or line count

        Returns:
            str: str for filename
        """    
        return f"00{index}-{langcode}.sup"

    ################################################################################################################
    #   Getter/Setter Functions
    ################################################################################################################

    def getPlaylistLocation(self, split=False):
        """
        Gets the full path to the  STREAM or PLAYLIST dir for a source

        Args:
            split (bool, optional): Whether or not to look in playlist or stream
            true means to look in stream

        Returns:
            str: full path to directory
        """
        sourceData = self
        if split:
            return paths.search(sourceData["sourceDir"], "STREAMS", dir=True)[0]
        else:
            return paths.search(sourceData["sourceDir"], "PLAYLIST", dir=True)[0]

    @property
    def tracks(self):
        """
        getter function for tracks dict

        Returns:
            array: returns the values from the tracks dict
        """
        return list(self["tracks"].values())

    def _getfilteredvalues(self, type):
        """
        getter function for tracks dict filtered by type

        Returns:
            array: returns the values from the tracks dict filtered by type
        """
        values = self["tracks"].values()
        return list(filter(lambda x: x["type"] == type, values))

    @property
    def video(self):
        """
        getter function for tracks dict filtered by type

        Returns:
            array: returns the values from the tracks dict filtered by video type
        """        
        return self._getfilteredvalues("video")

    @property
    def subtitle(self):
        """
        getter function for tracks dict filtered by type

        Returns:
            array: returns the values from the tracks dict filtered by subtitle type
        """        
        return self._getfilteredvalues("subtitle")

    @property
    def audio(self):
        """
        getter function for tracks dict filtered by type

        Returns:
            array: returns the values from the tracks dict filtered by audio type
        """        
        return self._getfilteredvalues("audio")

    @property
    def compat(self):
        """
        getter function for tracks dict filtered by type

        Returns:
            array: returns the values from the tracks dict filtered by compat audio type
        """        
        values = self._getfilteredvalues("audio")
        return list(filter(lambda x: x["compat"] == "true", values))

    @property
    def trackkey(self):
        """
        getter function for tracks dict

        Returns:
            array: returns the keys from the tracks dict
        """        
        return list(self["tracks"].keys())

    def _getfilteredkey(self, type):
        """
        getter function for tracks dict

        Returns:
            array: returns the keys from the tracks dict filtered by type
        """
        keys = self["tracks"].keys()
        return list(filter(lambda x: self["tracks"][x]["type"] == type, keys))

    @property
    def videokeys(self):
        """
        getter function for tracks dict

        Returns:
            array: returns the keys from the tracks dict filtered by video type
        """
        return self._getfilteredkey("video")

    @property
    def subtitlekeys(self):
        """
        getter function for tracks dict

        Returns:
            array: returns the keys from the tracks dict filtered by subtitle type
        """
        return self._getfilteredkey("subtitle")

    @property
    def audiokeys(self):
        """
        getter function for tracks dict

        Returns:
            array: returns the keys from the tracks dict filtered by audio type
        """        
        return self._getfilteredkey("audio")

    @property
    def compatkeys(self):
        """
        getter function for tracks dict

        Returns:
            array: returns the keys from the tracks dict filtered by compat type
        """        
        keys = self._getfilteredkey("audio")
        return list(filter(lambda x: self["tracks"][x]["compat"] == True, keys))

    @property
    def trackitems(self):
        """
        getter function for tracks dict

        Returns:
            array: returns keys,value tuples from the tracks dict
        """        
        return list(self["tracks"].items())

    def _getfiltereditems(self, type):
        """
        getter function for tracks dict

        Returns:
            array: returns keys,value tuples from the tracks dict filtered by type
        """          
        items = self["tracks"].items()
        return list(filter(lambda x: x[1]["type"] == type, items))

    @property
    def videoitems(self):
        """
        getter function for tracks dict

        Returns:
            array: returns keys,value tuples from the tracks dict filered by video type 
        """          
        return self._getfiltereditems("video")

    @property
    def subtitleitems(self):
        """
        getter function for tracks dict

        Returns:
            array: returns keys,value tuples from the tracks dict filered by subtitle type 
        """           
        return self._getfiltereditems("subtitle")

    @property
    def audioitems(self):
        """
        getter function for tracks dict

        Returns:
            array: returns keys,value tuples from the tracks dict filered by audio type 
        """            
        return self._getfiltereditems("audio")

    @property
    def compatitems(self):
        """
        getter function for tracks dict

        Returns:
            array: returns keys,value tuples from the tracks dict filered by compat audio type 
        """      
        items = self._getfiltereditems("audio")
        return list(filter(lambda x: x[1]["compat"] == True, items))
 
    """
   Private
    """

    def _setUp(self, playlistNum, bdObj, streams):
        """
        Helper function to setup some required attributes

        Args:
            playlistNum (int): which playlist from the bdObj we are using
            bdObj (obj): bdOJ instance
            streams (array): array of streams dicts
        """
        self._playlistNum = playlistNum
        self._bdObj = bdObj
        self._playlistFile = bdObj.Dict[playlistNum]["playlistFile"]
        self._source = bdObj.mediaDir
        self._streams = streams

    def _setSourceDict(self):
        """
        sets some values for the main root dict of class
        """
        self["sourceDir"] = self._source
        self["playlistNum"] = self._playlistNum
        self["playlistFile"] = self._playlistFile
        self["streamFiles"] = self._getStreamNames(self._streams)
        self["length"] = self._getStreamLength(self._streams)
        self["chapters"] = self._bdObj.getStreamChapters(
            self._streams, self._playlistNum)

    ################################################################################################################
    ###### These Functions are used to parse Data from String for the corresponding Track Type i.e Video, Audio,etc#
    ################################################################################################################

    def _videoParser(self, currline, source):
        """
        creates a track dict for video bdinfo lines

        Args:
            currline (str): bdinfo quick info line
            source (str): path to source

        Returns:
            str: trackdict
        """
        tempdict = trackObj.TrackObJ()
        bdinfo = re.search(
            "(?:.*?: (.*))", currline).group(1)
        tempdict = self._defaultMediaDict(bdinfo, source)
        tempdict["type"] = "video"
        return tempdict

    def _audioParser(self, currline, source):
        """
        creates a track dict for audio bdinfo lines

        Args:
            currline (str): bdinfo quick info line
            source (str): path to source

        Returns:
            str: trackdict
        """
        lang = self._medialang(currline)
        langcode = self._mediacode(lang)
        bdinfo = list(filter(lambda x: x != None, list(
            re.search("(?:.*?/ )(?:(.*?) \(.*)?(.*)?", currline).groups())))[0]
        tempdict = self._defaultMediaDict(bdinfo, source, langcode, lang)
        tempdict["type"] = "audio"
        tempdict["auditorydesc"] = False
        tempdict["original"] = False
        tempdict["commentary"] = False

        return tempdict

    def _audioCompatParser(self, currline, source):
        """
        creates a track dict for compat audio bdinfo lines

        Args:
            currline (str): bdinfo quick info line
            source (str): path to source

        Returns:
            str: trackdict
        """        
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
        if re.search("(DTS Core)", bdinfo, re.IGNORECASE):
            return
        tempdict = self._defaultMediaDict(bdinfo, source, langcode, lang)
        tempdict["type"] = "audio"
        tempdict["compat"] = True
        tempdict["auditorydesc"] = False
        tempdict["original"] = False
        tempdict["commentary"] = False
        return tempdict

    def _subParser(self, currline, source):
        """
        creates a track dict for subtitle audio bdinfo lines

        Args:
            currline (str): bdinfo quick info line
            source (str): path to source

        Returns:
            str: trackdict
        """           
        lang = self._medialang(currline)
        bdinfo = currline
        langcode = self._mediacode(lang)
        tempdict = self._defaultMediaDict(bdinfo, source, langcode, lang)
        tempdict["type"] = "subtitle"
        tempdict["sdh"] = False
        tempdict["textdesc"] = False
        tempdict["commentary"] = False
        return tempdict

    # Standard Track Data Helper
    def _defaultMediaDict(self, bdinfo, source, langcode=None, lang=None):
        """
        Helper function for shared values amount all trackdict types

        Args:
            bdinfo (str): bdinfo quick info line
            source (str): path to source
            langcode (str,optional): 2 digit langcode
            lang (str,optional): full lang string
        """           
        tempdict = trackObj.TrackObJ()
        tempdict["bdinfo_title"] = bdinfo
        tempdict["langcode"] = langcode
        tempdict["lang"] = lang
        tempdict["compat"] = False
        tempdict["default"] = False
        tempdict["forced"] = False
        tempdict["machine_parse"] = []
        tempdict["machine_parse_endlines"] = []
        tempdict["length"] = None
        tempdict["sourceDir"] = source
        tempdict["sourceKey"] = utils.sourcetoShowName(source)
        tempdict["notes"] = "Add Your Own if You want"
        tempdict["child"] = None
        tempdict["parent"] = None
        tempdict["parentKey"] = None
        tempdict["childKey"] = None

        return tempdict

        ################################################################################################################
        ###### These Functions are Used to get the Language/Code of a Track                                            #
        ################################################################################################################

    def _medialang(self, currline):
        """
        Parses bdinfo quickinfo line for language information_

        Args:
            currline (str): bdinfo quickinfo ling

        Returns:
            str: returns language
        """
        return re.search("(?:.*?: )(.*?)(?: /.*)", currline).group(1)

    def _mediacode(self, lang):
        """
        converts language str to 2 digit langcode

        Args:
            lang (str): language str

        Returns:
            str: returns 2 digit langcode
        """    
        try:
            return langcodes.standardize_tag(langcodes.find(lang))
        except:
            return

        ################################################################################################################
        ###### Adds Track to List                                                                                     #
        ################################################################################################################

    def _appendTrack(self, currline, index, source):
        """
        Helper function to add quickinfo line as a dict within parent tracks dict

        Args:
            currline (str): bdinfo quick info line
            index (int): track index
            source: source that track is from

        Returns:
            str: returns 2 digit langcode
        """  
        tempdict = None
        tempdict2 = None
        match = re.search("([a-z|A-Z]*?):", currline, re.IGNORECASE).group(1)
        if match == "Video":
            tempdict = self._videoParser(currline, source)
        elif match == "Audio":
            tempdict = self._audioParser(currline, source)
            tempdict2 = self._audioCompatParser(currline, source)
        elif match == "Subtitle":
            tempdict = self._subParser(currline, source)

    # Try to Get Unique Key Values
        tempdict["index"] = index
        value = tempdict["bdinfo_title"] + \
            utils.sourcetoShowName(source) + str(tempdict["index"])
        key = xxhash.xxh32_hexdigest(value)
        post = tempdict["langcode"] or "vid"
        tempdict["key"] = f"{key}_{post}"
        tempdict["parent"] = None
        tempdict["child"] = None
        key = tempdict["key"]
        self["tracks"][key] = tempdict

        if tempdict2 != None:
            tempdict2["index"] = index

            # Try to Get Unique Key Values
            value = tempdict2["bdinfo_title"] + \
                utils.sourcetoShowName(source) + str(tempdict2["index"])
            key = xxhash.xxh32_hexdigest(value)
            post = tempdict2["langcode"] or "vid"
            tempdict2["key"] = f"{key}_{post}"

            tempdict["child"] = tempdict2["bdinfo_title"]
            tempdict["childKey"] = tempdict2["key"]

            tempdict2["parent"] = tempdict["bdinfo_title"]
            tempdict2["parentKey"] = tempdict["key"]

            key = tempdict2["key"]
            self["tracks"][key] = tempdict2

    #####################################################################################################################
    #       Additional Function
    ################################################################################################################

    def _getStreamNames(self, streams):
        """
        get the stream files from streamdict

        Args:
            streams (array): array of streams from playlist or stream

        Returns:
            array: an array of stream names
        """
        return list(map(lambda x: x["name"], streams))

    def _getStreamLength(self, streams):
        """
        caluculates the full length of all streams passed

        Args:
            streams (array): array of streams from playlist or stream

        Returns:
            int: length of all streams
        """
        return utils.subArrowTime(utils.convertArrow(streams[-1]["end"], "HH:mm:ss.SSS"),
                                  utils.convertArrow(streams[0]["start"], "HH:mm:ss.SSS")).format("HH [hour] mm [Minutes] ss [Seconds] SSS [MicroSeconds]")
