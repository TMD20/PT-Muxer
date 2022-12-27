
import re
import os

import xxhash
import langcodes

import tools.general as utils
import tools.paths as paths
import mediatools.eac3to as eac3to
import mediadata.trackObj as trackObj



class sourceData(dict):

    def __init__(self):
        super().__init__()
        self._allowedKeys={"tracks","source","outputDir","sourceDir","playlistNum","playlistFile","length","streamFiles","chapters"}
        self["tracks"]={}
        self._source=None
    def __setitem__(self, key, value):
        if key not in self._allowedKeys:
            raise AttributeError(f"sourceData does not accept {key}")
        super().__setitem__(key, value)

    """
    Public Functions
    """

    ################################################################################################################
    ###### These Function adds every track from bdinfo list of tracks to a dictionary                              #
    #It also adds data about the source of the information, and where to output it                                 #
    ################################################################################################################

    
    def updateRawTracksDict(self,trackStrs):
        source=self._source
        offset=1
        for index, currline in enumerate(trackStrs):
            self._appendTrack(currline, index+offset, source)
        self._setSourceDict()

        

    def setOutput(self,output,source=None):
        source=source or self._source
        self._output=output
        for track in self.tracks:
            track["outputDir"]=os.path.join(output,utils.sourcetoShowName(source))
        self["outputDir"] = os.path.join(output,utils.sourcetoShowName(self._source))



    
    def getVideoFileName(line, index):
        if re.search("AVC", line) != None:
            return f"00{index}.h264"
        if re.search("HEVC", line) != None:
            return f"00{index}.h265"
        if re.search("VC-1", line) != None:
            return f"00{index}.vc1"
        if re.search("MPEG-2", line) != None:
            return f"00{index}.mpeg2"


    def getAudioFileName(line, langcode, index):
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
        # remove special characters
        return f"00{index}-{langcode}.sup"

    ################################################################################################################
    #   Getter Functions
    ################################################################################################################


    def getPlaylistLocation(self,split=False):
        sourceData=self
        if split:
            return paths.search(sourceData["sourceDir"],"STREAMS",dir=True)[0]
        else:
            return paths.search(sourceData["sourceDir"],"PLAYLIST",dir=True)[0]

  

    @property
    def tracks(self):
        return list(self["tracks"].values())
        
    def _getfilteredvalues(self,type):
        values=self["tracks"].values()
        return list(filter(lambda x:x["type"]==type,values))
    
    @property
    def video(self):
        return self._getfilteredvalues("video")
        
    @property
    def subtitle(self):
        return self._getfilteredvalues("subtitle")
    @property
    def audio(self):
        return self._getfilteredvalues("audio")
    @property
    def compat(self):
        values=self._getfilteredvalues("audio")
        return list(filter(lambda x:x["compat"]=="true",values))
    @property
    def trackkey(self):
        return list(self["tracks"].keys())
    def _getfilteredkey(self,type):
        keys=self["tracks"].keys()
        return list(filter(lambda x:self["tracks"][x]["type"]==type,keys))
    
    @property
    def videokeys(self):
        return self._getfilteredkey("video")
        
    @property
    def subtitlekeys(self):
        return self._getfilteredkey("subtitle")
    @property
    def audiokeys(self):
        return self._getfilteredkey("audio")
    @property
    def compatkeys(self):
        keys=self._getfilteredkey("audio")
        return list(filter(lambda x:self["tracks"][x]["compat"]==True,keys))
     
  
    @property
    def trackitems(self):
        return list(self["tracks"].items())
    def _getfiltereditems(self,type):
        items=self["tracks"].items()
        return list(filter(lambda x:x[1]["type"]==type,items))
    
    @property
    def videoitems(self):
        return self._getfiltereditems("video")
        
    @property
    def subtitleitems(self):
        return self._getfiltereditems("subtitle")
    @property
    def audioitems(self):
        return self._getfiltereditems("audio")
    @property
    def compatitems(self):
        items=self._getfiltereditems("audio")
        return list(filter(lambda x:x[1]["compat"]==True,items))      
                  
    """
   Private
    """
    def _setUp(self,playlistNum,bdObj,streams):
        self._playlistNum=playlistNum
        self._bdObj=bdObj
        self._playlistFile=bdObj.Dict[playlistNum]["playlistFile"]
        self._source=bdObj.mediaDir
        self._streams=streams

    def _setSourceDict(self):
        self["sourceDir"] = self._source
        self["playlistNum"] = self._playlistNum
        self["playlistFile"] = self._playlistFile
        self["streamFiles"] = self._getStreamNames(self._streams)
        self["length"] = self._getStreamLength(self._streams)
        self["chapters"]=self._bdObj.getStreamChapters(self._streams,self._playlistNum)

    ################################################################################################################
    ###### These Functions are used to parse Data from String for the corresponding Track Type i.e Video, Audio,etc#
    ################################################################################################################

    def _videoParser(self, currline,source):
        tempdict = trackObj.TrackObJ()
        bdinfo = re.search(
            "(?:.*?: (.*))", currline).group(1)
        tempdict = self._defaultMediaDict(bdinfo,source)
        tempdict["type"] = "video"
        return tempdict

    def _audioParser(self, currline,source):
        lang = self._medialang(currline)
        langcode = self._mediacode(lang)
        bdinfo = list(filter(lambda x: x != None, list(
            re.search("(?:.*?/ )(?:(.*?) \(.*)?(.*)?", currline).groups())))[0]
        tempdict = self._defaultMediaDict(bdinfo,source, langcode, lang)
        tempdict["type"] = "audio"
        tempdict["auditorydesc"] = False
        tempdict["original"] = False
        tempdict["commentary"] = False

        return tempdict

    def _audioCompatParser(self, currline,source):
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
        tempdict = self._defaultMediaDict(bdinfo,source ,langcode, lang)
        tempdict["type"] = "audio"
        tempdict["compat"] = True
        tempdict["auditorydesc"] = False
        tempdict["original"] = False
        tempdict["commentary"] = False
        return tempdict

    def _subParser(self, currline,source):
        lang = self._medialang(currline)
        bdinfo = currline
        langcode = self._mediacode(lang)
        tempdict = self._defaultMediaDict(bdinfo,source, langcode, lang)
        tempdict["type"] = "subtitle"
        tempdict["sdh"] = False
        tempdict["textdesc"] = False
        tempdict["commentary"] = False
        return tempdict

    # Standard Track Data Helper
    def _defaultMediaDict(self, bdinfo, source,langcode=None, lang=None):
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
        tempdict["sourceKey"]=utils.sourcetoShowName(source)
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
        return re.search("(?:.*?: )(.*?)(?: /.*)", currline).group(1)

    def _mediacode(self, lang):
        try:
            return langcodes.standardize_tag(langcodes.find(lang))
        except:
            return

        ################################################################################################################
        ###### Adds Track to List                                                                                     #
        ################################################################################################################

    def _appendTrack(self, currline, index, source):
        tempdict = None
        tempdict2 = None
        match = re.search("([a-z|A-Z]*?):", currline, re.IGNORECASE).group(1)
        if match == "Video":
            tempdict = self._videoParser(currline,source)
        elif match == "Audio":
            tempdict = self._audioParser(currline,source)
            tempdict2 = self._audioCompatParser(currline,source)
        elif match == "Subtitle":
            tempdict = self._subParser(currline,source)
    
    # Try to Get Unique Key Values
        tempdict["index"] = index
        value = tempdict["bdinfo_title"] + \
            utils.sourcetoShowName(source) + str(tempdict["index"])
        key = xxhash.xxh32_hexdigest(value)
        post = tempdict["langcode"] or "vid"
        tempdict["key"] = f"{key}_{post}"
        tempdict["parent"] = None
        tempdict["child"] = None
        key=tempdict["key"]
        self["tracks"][key]=tempdict
        

        if tempdict2 != None:
            tempdict2["index"] = index

            # Try to Get Unique Key Values
            value = tempdict2["bdinfo_title"] + \
                utils.sourcetoShowName(source) + str(tempdict2["index"])
            key = xxhash.xxh32_hexdigest(value)
            post = tempdict2["langcode"] or "vid"
            tempdict2["key"] = f"{key}_{post}"

            tempdict["child"] = tempdict2["bdinfo_title"]
            tempdict["childKey"] =tempdict2["key"]

            tempdict2["parent"] = tempdict["bdinfo_title"]
            tempdict2["parentKey"] =tempdict["key"]

          

            key=tempdict2["key"]
            self["tracks"][key]=tempdict2
        


  

    #####################################################################################################################
    #       These Functions add Addition Data to Tracks Obj
    ################################################################################################################


            
   

      ################################################################################################################
      ###### get data from streams
      ################################################################################################################
    def _getStreamNames(self, streams):
       return list(map(lambda x: x["name"], streams))

    def _getStreamLength(self, streams):
        return utils.subArrowTime(utils.convertArrow(streams[-1]["end"], "HH:mm:ss.SSS"),
                                  utils.convertArrow(streams[0]["start"], "HH:mm:ss.SSS")).format("HH [hour] mm [Minutes] ss [Seconds] SSS [MicroSeconds]")

   