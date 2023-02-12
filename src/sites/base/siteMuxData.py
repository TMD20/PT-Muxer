import itertools
import re
import os
import subprocess
from typing import List, Union


import langcodes
from pymediainfo import MediaInfo
from guessit import guessit


import src.tools.general as utils
import src.tools.commands as commands
import src.tools.logger as logger
import src.tools.directory as dir
import src.tools.paths as paths


class MuxOBj():
    """
    Base class for generating mkvmerge
    """

    def __init__(self) -> None:
        self._audio = []
        self._video = []
        self._sub = []
        self._out = None
        self._outputargs = []
        self._placeholder = "PlaceHolderTitleRemux"

    def generateMuxData(self, remuxConfig: dict, outargs: List[str]) -> None:
        """
        Generates mkvmerge command


        Args:
            remuxConfig (dict): remuxConfig dict from demux
            outargs (array): an array of global arguments passed to mkvmerge
        """
        self._addAudioTracks(remuxConfig)
        self._addVideoTracks(remuxConfig)
        self._addSubTracks(remuxConfig)
        self._addOutPutArgs(outargs)
        self._out = list(itertools.chain.from_iterable(
            [self._video, self._audio, self._sub, self._outputargs]))

    @property
    def out(self) -> List[str]:
        """
        Helper function to get out parameter
        Returns:
            array: array of outargs
        """
        return self._out
    def createMKV(self, fileName: str, movieTitle: str, chapters: Union[str, bytes, os.PathLike], xml: Union[str, bytes, os.PathLike],**kwargs) -> None:
        """
        Generates a MKV using mkvmerge in subprocess
        Additionally runs vdator to validate remux

        Args:
            fileName (str): file name to pass to mkvmerge
            movieTitle (str): movietitle to pass to mkvmerge
            chapters (str): path to chapters file to pass to mkvmerge
            xml (str): path to xml file to pass to mkvmerge
        """
        if os.path.exists(fileName):
            os.remove(fileName)
        command = list(itertools.chain.from_iterable(
            [commands.mkvmerge(), ["--title", movieTitle, "--chapters", chapters, "--output", fileName, "--global-tags", xml], self._out]))
        if chapters == None:
            command = list(itertools.chain.from_iterable(
                [commands.mkvmerge(), ["--title", movieTitle, "--output", fileName, "--global-tags", xml], self._out]))
        logger.logger.debug(f"Running This Command: \n{command}")
        logger.logger.debug(
            f"Running This CommandString :\n{' '.join(command)}")
        with subprocess.Popen(command, universal_newlines=True, stdout=subprocess.PIPE, bufsize=1) as p:
            for line in p.stdout:
                print(line, end='')
    def getFileName(self,
                        remuxConfig: dict, group: str, title: str, episodeTitle: Union[str, None] = None) -> str:
            """
            Generates a filename based on demux data

            Args:
                remuxConfig (dict):dictionary generated my PTMuxer
                group (str): group remux is being generated for
                title (str): Movie title
                episodeTitle (str, optional):Episode title. Defaults to None.

            Returns:
                str: filename for remux
            """

            episodeTitle = episodeTitle or self._placeholder
            videoCodec = self._getVideo(
                remuxConfig["Enabled_Tracks"]["Video"], remuxConfig["Tracks_Details"]["Video"])
            mediaType = self._getMediaType(
                remuxConfig["Enabled_Tracks"]["Video"], remuxConfig["Tracks_Details"]["Video"])
            videoRes = self._getVideoResolution(
                remuxConfig["Enabled_Tracks"]["Video"], remuxConfig["Tracks_Details"]["Video"])

            audioCodec = self._getAudio(
                remuxConfig["Enabled_Tracks"]["Audio"], remuxConfig["Tracks_Details"]["Audio"])
            audioChannel = self._getAudioChannel(
                remuxConfig["Enabled_Tracks"]["Audio"], remuxConfig["Tracks_Details"]["Audio"])
            year = remuxConfig['Movie']['year']
            season = remuxConfig["Movie"].get("season")
            episode = remuxConfig["Movie"].get("episode")
            movieName = f"{title} {year}"
            if season and episode:
                fileName = f"{movieName}.S{season//10}{season%10}E{episode//10}{episode%10}.{episodeTitle}.{videoRes}.{mediaType}.REMUX.{videoCodec}.{audioCodec}.{audioChannel}-{group}.mkv"
                return os.path.join(self._getTVDir(remuxConfig,group,title),self._fileNameCleaner(fileName))


            else:
                fileName = f"{movieName}.{episodeTitle}.{videoRes}.{mediaType}.REMUX.{videoCodec}.{audioCodec}.{audioChannel}-{group}.mkv"
                return os.path.join(self._getMovieDir(remuxConfig,group,title,year),self._fileNameCleaner(fileName))

    def printMediaInfo(self, fileName: str) -> None:
        """
        Takes fileName and prints mediainfo 
        Args:
            fileName (str): fileName to process and pass to mediainfo
        """
        with dir.cwd(paths.createTempDir()):
            print(MediaInfo.parse(fileName, output="", full=False))
    def confirmName(self, fileName: str) -> str:
        """
        Provides prompt to confirm or fileName change attribute

        Args:
            fileName (str): initial fileName

        Returns:
            str: confirmed fileName
        """
        inputs = ["YES", "NO"]
        choice = utils.singleSelectMenu(
            inputs, f"Is this FilePath Correct: {fileName}\n")
        while choice != "YES":
            message = "Enter New FilePath: "
            fileName = utils.textEnter(message, fileName)
            choice = utils.singleSelectMenu(
                inputs, "Is the File Correct Now\n")
        return fileName
         
                             
    ######################################################
    # Private Functions
    #
    #####################################################
    
    
    def _addVideoTracks(self, remuxConfig: dict) -> None:
        """
        Generates video tracks arguments for mkvmerge

        Args:
            remuxConfig (dict): remuxConfig dict from demux
        """
        out = []
        langcode = None
        trackjsons=[]
        try:
            langcodeKey = str(remuxConfig["Enabled_Tracks"]["Audio"][0])
            langcode = remuxConfig["Tracks_Details"]["Audio"][langcodeKey]["langcode"]
        except:
            langcode = langcodes.standardize_tag(
                langcodes.find(remuxConfig["Movie"]["languages"][0]))
        for i in range(len(remuxConfig["Enabled_Tracks"]["Video"])):
            key = remuxConfig["Enabled_Tracks"]["Video"][i]
            key = str(key)
            trackjsons.append(remuxConfig["Tracks_Details"]["Video"][key]) 
        trackjsons.extend(list(filter(lambda x: x["enabled"]==True and x["type"]=="video",remuxConfig.get("extra_tracks",[]))))    
        for trackjson in trackjsons:
            name = trackjson["site_title"]
            file = trackjson["filename"]

            temp = ["--language", f"0:{langcode}", "--compression", f"0:None"]
            if name:
                temp.extend(["--track-name", f"0:{name}"])
            default = ["--default-track-flag", "0:0"]
            if trackjson.get("default") == True:
                default = ["--default-track-flag", "0:1"]
            temp.extend(default)
            if trackjson.get("extra_options")!=None and trackjson.get("extra_options")!="":
                temp.extend(trackjson.get("extra_options").split(" "))
            temp.append(file)
            out.append(temp)
        self._video = list(itertools.chain.from_iterable(out))
   
    def _addAudioTracks(self, remuxConfig: dict) -> None:
        """
        Generates audio track arguments for mkvmerge

        Args:
            remuxConfig (dict): remuxConfig dict from demux
        """
        out = []
        trackjsons=[]
        for i in range(len(remuxConfig["Enabled_Tracks"]["Audio"])):
            key = remuxConfig["Enabled_Tracks"]["Audio"][i]
            key = str(key)
            trackjsons.append(remuxConfig["Tracks_Details"]["Audio"][key])
        # get extra tracks
        trackjsons.extend(list(filter(lambda x: x["enabled"]==True and x["type"]=="audio",remuxConfig.get("extra_tracks",[]))))    
        for trackjson in trackjsons:  
            langcode = trackjson["langcode"] or langcodes.standardize_tag(langcodes.find(trackjson["lang"]))
            name = trackjson["site_title"]
            file = trackjson["filename"]
            temp = ["--language", f"0:{langcode}", "--compression", f"0:None"]
            if name:
                temp.extend(["--track-name", f"0:{name}"])

         # additional flags
            default = ["--default-track-flag", "0:0"]
            forced = ["--forced-display-flag", "0:0"]
            auditorydesc = ["--visual-impaired-flag", "0:0"]
            commentary = ["--commentary-flag", "0:0"]
            # reset flag values as needed

            if trackjson.get("default") == True:
                default = ["--default-track-flag", "0:1"]
            if trackjson.get("forced") == True:
                forced = ["--forced-display-flag", "0:1"]
            if trackjson.get("commentary") == True \
                    or re.search("commentary", name or "", re.IGNORECASE):
                commentary = ["--commentary-flag", "0:1"]
            if trackjson.get("auditorydesc") == True:
                auditorydesc = ["--visual-impaired-flag", "0:1"]
            temp.extend(default)
            temp.extend(forced)
            temp.extend(auditorydesc)
            temp.extend(commentary)
            if trackjson.get("extra_options")!=None and trackjson.get("extra_options")!="":
                temp.extend(trackjson.get("extra_options").split(" "))
            temp.append(file)
            out.append(temp)
        self._audio = list(itertools.chain.from_iterable(out))

    def _addSubTracks(self, remuxConfig: dict) -> None:
        """
        Generates sub track arguments for mkvmerge

        Args:
            remuxConfig (dict): remuxConfig dict from demux
        """
        out = []
        trackjsons=[]
        for i in range(len(remuxConfig["Enabled_Tracks"]["Sub"])):
            key = remuxConfig["Enabled_Tracks"]["Sub"][i]
            key = str(key)
            trackjsons.append(remuxConfig["Tracks_Details"]["Sub"][key]) 
        trackjsons.extend(list(filter(lambda x: x["enabled"]==True and x["type"]=="sub",remuxConfig.get("extra_tracks",[]))))    
        for trackjson in trackjsons:
            langcode = trackjson.get("langcode") or langcodes.standardize_tag(langcodes.find(trackjson["lang"]))
            file = trackjson["filename"]
            name = trackjson.get("site_title")
            temp = ["--language", f"0:{langcode}", "--compression", f"0:None"]
            if name:
                temp.extend(["--track-name", f"0:{name}"])
            # additional flags
            default = ["--default-track-flag", "0:0"]
            forced = ["--forced-display-flag", "0:0"]
            sdh = ["--hearing-impaired-flag", "0:0"]
            commentary = ["--commentary-flag", "0:0"]
            textdesc = ["--text-descriptions-flag", "0:0"]
            # flags values if needed
            if trackjson.get("default") == True:
                default = ["--default-track-flag", "0:1"]
            if trackjson.get("forced") == True:
                forced = ["--forced-display-flag", "0:1"]
            if trackjson.get("commentary") == True \
                    or re.search("commentary", name or "", re.IGNORECASE):
                commentary = ["--commentary-flag", "0:1"]
            if trackjson.get("sdh") == True \
                    or re.search("sdh", name or "", re.IGNORECASE):
                sdh = ["--hearing-impaired-flag", "0:1"]
            if trackjson.get("textdesc") == True \
                    or re.search("sdh", name or "", re.IGNORECASE):
                textdesc = ["--text-descriptions-flag", "0:1"]
            temp.extend(default)
            temp.extend(forced)
            temp.extend(sdh)
            temp.extend(commentary)
            temp.extend(textdesc)
            if trackjson.get("extra_options")!=None and trackjson.get("extra_options")!="":
                temp.extend(trackjson.get("extra_options").split(" "))
            temp.append(file)
            out.append(temp)
        self._sub = (list(itertools.chain.from_iterable(out)))

    

    def _fileNameCleaner(self, fileName: str) -> str:
        """
        This function removes extraniosu characters from filenames
        Args:
            fileName (str): filename to clean
        Returns:
            str: cleaned filename
        """
        fileName = re.sub(" +", " ", fileName)
        fileName = re.sub(" ", ".", fileName)
        fileName = re.sub("\.+", ".", fileName)
        fileName = re.sub("[@_!#$%^&*()<>?/\|}{~:]", "", fileName)
        fileName = re.sub("([^a-zA-Z\d])\.", ".", fileName)
        fileName = re.sub("\.([^a-zA-Z\d])", ".", fileName)
        fileName = re.sub(f"{self._placeholder}.", "", fileName)
        Noquotes = re.search('^"(.*)"$', fileName)
        if Noquotes:
            fileName = Noquotes.group(0)
        return fileName

    def _addOutPutArgs(self, outargs: str) -> List[str]:
        """
        splits a string of mkvmerge global output args into an array

        Args:
            outargs (str): string of mkvmerge output args

        Returns:
            array: output args split into an array
        """
        self._outputargs = outargs.split()



    def _getTVDir(self, remuxConfig: dict, group: str, title: str) -> str:
        """
        Generates a folder name for TV remux based on demux Data

        Args:
            remuxConfig (dict):dictionary generated my PTMuxer
            group (str): group remux is being generated for
            title (str):Movie title

        Returns:
            str: folder name
        """
        videoCodec = self._getVideo(
            remuxConfig["Enabled_Tracks"]["Video"], remuxConfig["Tracks_Details"]["Video"])
        mediaType = self._getMediaType(
            remuxConfig["Enabled_Tracks"]["Video"], remuxConfig["Tracks_Details"]["Video"])
        videoRes = self._getVideoResolution(
            remuxConfig["Enabled_Tracks"]["Video"], remuxConfig["Tracks_Details"]["Video"])

        audioCodec = self._getAudio(
            remuxConfig["Enabled_Tracks"]["Audio"], remuxConfig["Tracks_Details"]["Audio"])
        audioChannel = self._getAudioChannel(
            remuxConfig["Enabled_Tracks"]["Audio"], remuxConfig["Tracks_Details"]["Audio"])
        year = remuxConfig['Movie']['year']
        season = remuxConfig["Movie"]["season"]
        movieName = f"{title} {year}"

        fileName = f"{movieName}.S{season//10}{season%10}.{videoRes}.{mediaType}.REMUX.{videoCodec}.{audioCodec}.{audioChannel}-{group}"
        # Normalize FileName
        return self._fileNameCleaner(fileName)

    def _getMovieDir(self, remuxConfig: dict, group: str, title: str, year: int) -> str:
        """
        Generates a folder name for movie remux based on demux Data

        Args:
            remuxConfig (dict):dictionary generated my PTMuxer
            group (str): group remux is being generated for
            title (str):Movie title
            year (int) : Movie release yar

        Returns:
            str: folder name
        """
        videoCodec = self._getVideo(
            remuxConfig["Enabled_Tracks"]["Video"], remuxConfig["Tracks_Details"]["Video"])
        mediaType = self._getMediaType(
            remuxConfig["Enabled_Tracks"]["Video"], remuxConfig["Tracks_Details"]["Video"])
        videoRes = self._getVideoResolution(
            remuxConfig["Enabled_Tracks"]["Video"], remuxConfig["Tracks_Details"]["Video"])

        audioCodec = self._getAudio(
            remuxConfig["Enabled_Tracks"]["Audio"], remuxConfig["Tracks_Details"]["Audio"])
        audioChannel = self._getAudioChannel(
            remuxConfig["Enabled_Tracks"]["Audio"], remuxConfig["Tracks_Details"]["Audio"])
        movieName = f"{title} {year}"

        fileName = f"{movieName}.{videoRes}.{mediaType}.REMUX.{videoCodec}.{audioCodec}.{audioChannel}-{group}"
        # Normalize FileName
        return self._fileNameCleaner(fileName)



    """
    Title Helpers
    """

    def _getVideo(self, enabledTracks: List[dict], trackDetails: dict) -> str:
        """
        Returns video codec information on matched video 
        track(first enabled video)

        Args:
            enabledTracks (array): List of video tracks enabled
            trackDetails (dict): Track details for all video tracks

        Returns:
            str: codec information for matched video track
        """
        if len(enabledTracks) == 0:
            return ""
        key = str(enabledTracks[0])
        trackinfo = trackDetails[key]["bdinfo_title"]
        if re.search("AVC", trackinfo) != None:
            return "AVC"
        elif re.search("VC-1", trackinfo) != None:
            return "VC-1"
        elif re.search("HEVC", trackinfo) != None:
            return "HEVC"
        elif re.search("MPEG-2", trackinfo) != None:
            return "MPEG-2"

    def _getAudio(self, enabledTracks: List[dict], trackDetails: dict) -> str:
        """
        Returns audio codec information on matched audio
        track(first enabled audio)

        Args:
            enabledTracks (array): List of audio tracks enabled
            trackDetails (dict): Track details for all audio tracks

        Returns:
            str: codec information for matched audio track
        """
        if len(enabledTracks) == 0:
            return ""
        key = str(enabledTracks[0])
        trackinfo = trackDetails[key]["site_title"]

        if re.search("FLAC", trackinfo):
            return "FLAC"
        elif re.search("ATMOS", trackinfo):
            return "ATMOS"
        elif re.search("DTS-HD Master", trackinfo) or re.search("Dolby Digital", trackinfo):
            return "DTS-HD.MA"
        elif re.search("TrueHD", trackinfo):
            return "TrueHD"
        elif re.search("PCM", trackinfo):
            return "PCM"

    def _getAudioChannel(self, enabledTracks: List[dict], trackDetails: dict) -> str:
        """
        Returns audio channel information on matched audio
        track(first enabled audio)

        Args:
            enabledTracks (array): List of audio tracks enabled
            trackDetails (dict): Track details for all audio tracks

        Returns:
            str: channel information for matched audio track
        """
        if len(enabledTracks) == 0:
            return ""
        key = str(enabledTracks[0])
        trackinfo = trackDetails[key]["site_title"]
        return re.search("/ (.*?) /", trackinfo).group(1)

    def _getVideoResolution(self, enabledTracks: List[dict], trackDetails: dict) -> str:
        """
        Returns video res information on matched video
        track(first enabled video)

        Args:
            enabledTracks (array): List of video tracks enabled
            trackDetails (dict): Track details for all video tracks

        Returns:
            str: codec information for matched video track
        """
        key = str(enabledTracks[0])
        trackinfo = trackDetails[key]["bdinfo_title"]
        return re.search("[0-9]{3,4}[p|i]", trackinfo).group(0)

    def _getMediaType(self, enabledTracks: List[dict], trackDetails: dict) -> str:
        """
        Returns the disk type based on video track information from matched
        track(first enabled video)

        Args:
            enabledTracks (array): List of video tracks enabled
            trackDetails (dict): Track details for all video tracks

        Returns:
            str: disk type
        """
        key = str(enabledTracks[0])
        trackinfo = trackDetails[key]["bdinfo_title"]
        if guessit(trackinfo).get("source") == "Ultra HD Blu-ray":
            return "UHD.BluRay"
        else:
            return "BluRay"

    def _getHDR(self, enabledTracks: List[dict], trackDetails: dict) -> str:
        """
        Returns HDR|SDR based on video track information from matched
        track(first enabled video)

        Args:
            enabledTracks (array): List of video tracks enabled
            trackDetails (dict): Track details for all video tracks

        Returns:
            str: HDR|SDR information
        """
        key = str(enabledTracks[0])
        trackinfo = trackDetails[key]["bdinfo_title"]
        if re.search("BT.2020", trackinfo):
            return "HDR"
        else:
            return "SDR"
