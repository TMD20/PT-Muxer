
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
        self._allowedKeys={"tracks","source","outputDir","sourceDir","playlistNum","playlistFile","streamFile","length","streamFiles"}
    #prevent 
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

    def updateRawTracksDict(self,source, trackStrs, playlistNum, playlistFile, streams, output):
        tracks = []
        #verify if chapter file is present
        offset=1
        if eac3to.getChaptersBool(os.path.join(paths.search(source,"PLAYLIST",dir=True)[0],playlistFile)):
                offset = offset+1
        for index, currline in enumerate(trackStrs):
            tracks.extend(self._appendTrack(currline, index+offset, source))
        for track in tracks:
            track["sourceDir"] = source
            track["sourceKey"] = utils.sourcetoShowName(source)
            track["outputDir"] = os.path.join(output,utils.sourcetoShowName(source))
        self._updateTrackDictNotes(tracks)
        self._setSourceDict(
            tracks, playlistNum, playlistFile, streams, source, output)
        


    
    def getVideoFileName(line, index):
        if re.search("AVC", line) != None:
            return f"00{index}.h264"
        if re.search("HEVC", line) != None:
            return f"{index}:00{index}.h265"
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
            return paths.search(sourceData["sourceDir"],"STREANS",dir=True)[0]
        else:
            return paths.search(sourceData["sourceDir"],"PLAYLIST",dir=True)[0]



    """
   Private
    """

    ################################################################################################################
    ###### These Functions are used to parse Data from String for the corresponding Track Type i.e Video, Audio,etc#
    ################################################################################################################

    def _videoParser(self, currline):
        tempdict = trackObj.TrackObJ()
        bdinfo = re.search(
            "(?:.*?: (.*))", currline).group(1)
        tempdict = self._defaultMediaDict(bdinfo)
        tempdict["type"] = "video"
        return tempdict

    def _audioParser(self, currline):
        lang = self._medialang(currline)
        langcode = self._mediacode(lang)
        bdinfo = list(filter(lambda x: x != None, list(
            re.search("(?:.*?/ )(?:(.*?) \(.*)?(.*)?", currline).groups())))[0]
        tempdict = self._defaultMediaDict(bdinfo, langcode, lang)
        tempdict["type"] = "audio"
        tempdict["auditorydesc"] = False
        tempdict["original"] = False
        tempdict["commentary"] = False

        return tempdict

    def _audioCompatParser(self, currline):
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
        tempdict["auditorydesc"] = False
        tempdict["original"] = False
        tempdict["commentary"] = False
        return tempdict

    def _subParser(self, currline):
        lang = self._medialang(currline)
        bdinfo = currline
        langcode = self._mediacode(lang)
        tempdict = self._defaultMediaDict(bdinfo, langcode, lang)
        tempdict["type"] = "subtitle"
        tempdict["sdh"] = False
        tempdict["textdesc"] = False
        tempdict["commentary"] = False
        return tempdict

    # Standard Track Data Helper
    def _defaultMediaDict(self, bdinfo, langcode=None, lang=None):
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
        tempList=[]
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
    # Try to Get Unique Key Values
        tempdict["index"] = index
        value = tempdict["bdinfo_title"] + \
            utils.sourcetoShowName(source) + str(tempdict["index"])
        key = xxhash.xxh32_hexdigest(value)
        post = tempdict["langcode"] or "vid"
        tempdict["key"] = f"{key}_{post}"
        tempdict["parent"] = None
        tempdict["child"] = None
        tempList.append(tempdict)
        if tempdict2 != None:
            tempdict2["index"] = index

            # Try to Get Unique Key Values
            value = tempdict2["bdinfo_title"] + \
                utils.sourcetoShowName(source) + str(tempdict2["index"])
            key = xxhash.xxh32_hexdigest(value)
            post = tempdict2["langcode"] or "vid"
            tempdict2["key"] = f"{key}_{post}"
            tempdict2["child"] = None
            tempdict2["parent"] = tempdict["bdinfo_title"]
            tempdict["child"] = tempdict2["bdinfo_title"]
            tempdict["parent"] = None
            tempList.append(tempdict2)
        return tempList


    def _setSourceDict(self, tracks, playlistNum, playlistFile, streams, source, output):
        self["tracks"] = tracks
        self["outputDir"] = os.path.join(output,utils.sourcetoShowName(source))
        self["sourceDir"] = source
        self["playlistNum"] = playlistNum
        self["playlistFile"] = playlistFile
        self["streamFiles"] = self._getStreamNames(streams)
        self["length"] = self._getStreamLength(streams)

    #####################################################################################################################
    #       These Functions add Addition Data to Tracks Obj
    ################################################################################################################

    def _updateTrackDictNotes(self, tracks):
        for track in tracks:
            track["notes"] = "Add Your Own if You want"
   

      ################################################################################################################
      ###### get data from streams
      ################################################################################################################
    def _getStreamNames(self, streams):
       return list(map(lambda x: x["name"], streams))

    def _getStreamLength(self, streams):
        return utils.subArrowTime(utils.convertArrow(streams[-1]["end"], "HH:mm:ss.SSS"),
                                  utils.convertArrow(streams[0]["start"], "HH:mm:ss.SSS")).format("HH [hour] mm [Minutes] ss [Seconds] SSS [MicroSeconds]")

   