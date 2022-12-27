import os
import re
import orjson


from num2words import num2words
import natsort

import tools.general as utils
import tools.paths as paths
import mediatools.bdinfo as bdinfo
import config as config
import sites.pickers.siteSourcePicker as siteSourcePicker
import mediatools.eac3to as eac3to
import mediatools.dgdemux as dgdemux
import tools.paths as paths
import sites.pickers.siteSortPicker as siteSortPicker
import subtitles.subreader as subreader
import transcription.voiceRecord as voiceRec
import tools.directory as dir
import tools.logger as logger


class Demux():
    """
    This is the base class for the demux Classes
    Provides some basic functionality meant 
    to be inherited by other class
    """

    def __init__(self, args):
        self._args = args
        self.demuxFolder = None
        self._name = None
        self._type = None
        self.movieObj = None
        self._index = 0
        self._success = False

    def __call__(self):
        """
        Main Function For Class
        """
        logger.setUpLogging(self._args.loglevel)
        self._callFunction()
        self._success = True

    def _callFunction(self):
        """
        Overwriten by Inheriting class
        Runs "main" function for instances of class
        """
        None

    @property
    def success(self):
        """
        Provides Detail on whether demuxing was finished succesfully

        Returns:
            bool: a bool based on if _call_ finishes
        """
        return self._success

    def demuxPlaylist(self, bdObjs, multiSelect=False):
        """
        Main Function for processes Demuxing of playlist


        Args:
            bdObjs (array): An array of bdObjs, one for each source
            multiSelect (bool, optional): Whether or not each source should 
            allow for more than one playlist. Defaults to False.
        """
        # setup bdobj
        for bdObj in bdObjs:
            logger.print(bdObj.mediaDir, style="white")
            if multiSelect == True:
                bdObj.playListRangeSelect()
            else:
                bdObj.playListSelect()
        bdObjs[0].validate(bdObjs)
        for i in range(len(bdObjs[0].keys)):
            self._index = i
            siteSourceObjs = []
            newFolder = self._getNewFolder(len(os.listdir(self.demuxFolder)))
            with dir.cwd(newFolder):
                for bdObj in bdObjs:
                    bdObj.generateData(i)
                    demuxData = siteSourcePicker.pickSite(self._args.site)
                    demuxData.addTracks(bdObj, bdObj.keys[i])
                    self._filterTracks(demuxData)
                    demuxData.setOutput(newFolder)
                    siteSourceObjs.append(demuxData)
                    with dir.cwd(demuxData["outputDir"]):
                        if not self._args.dontconvert:
                            demuxData.convertFlac()
                        if self._args.extractprogram == "eac3to":

                            eac3to.process(
                                demuxData.tracks, demuxData["sourceDir"], demuxData["playlistFile"])
                        else:
                            dgdemux.run(
                                demuxData.tracks, demuxData["sourceDir"], demuxData["playlistFile"])
                        bdObj.writeBDInfo(0)
                with dir.cwd(demuxData["outputDir"]):
                    muxSorter = self._getMuxSorter(siteSourceObjs)
                    self._subParse(muxSorter)
                    self._voiceRec(muxSorter)
                self._writeFinalJSON(
                    self._saveOutput(siteSourceObjs, muxSorter))

    def _saveOutput(self, siteSourceObjs, muxSorter):
        """
        Generates a dictionary filled with data from demuxing process

        Args:
            siteSourceObjs (array): array of siteTrackData, with sources added 
            muxSorter (obj): siteTrackSorter filled with unsorted and sorted tracks
        Returns:
            dict: dictionary filled data from source/generated
        """
        outdict = {}
        outdict.update(self._addSourceData(siteSourceObjs))
        outdict.update(self._ConvertChapterList(
            self._getChapterMedia(siteSourceObjs)))
        outdict["Movie"] = self._movieObj.movieObj
        outdict.update(self._addEnabledData(muxSorter))
        outdict.update(self._addTrackData(muxSorter))
        return outdict

    #################
    # Helper Functions
    ############

    def _getNewFolder(self,i=None):
        """
        Generates parentfolder inside muxFolder 
        for each selected playlist/stream 

        Returns:
            path: generated path for folder
        """
        return os.path.join(self.demuxFolder)

    def _addTrackData(self, muxSorter):
        """
        Helper function for added details from each sources tracks parsed
        during the demux class

        Args:
            muxSorter (obj):siteTrackSorter filled with unsorted and sorted tracks


        Returns:
            dict: Dictionary with track detail information
        """
        outdict = {}
        outdict["Tracks_Details"] = {}
        outdict["Tracks_Details"]["Audio"] = {}
        outdict["Tracks_Details"]["Sub"] = {}
        outdict["Tracks_Details"]["Video"] = {}

        for track in muxSorter.unSortedAudio:
            key = track["key"]
            track.pop("key")
            outdict["Tracks_Details"]["Audio"][key] = track
        for track in muxSorter.unSortedSub:
            key = track["key"]
            track.pop("key")
            outdict["Tracks_Details"]["Sub"][key] = track

        for track in muxSorter.unSortedVideo:
            key = track["key"]
            track.pop("key")
            outdict["Tracks_Details"]["Video"][key] = track

        return outdict

    def _writeFinalJSON(self, outdict):
        """
        Takes a dictionary as input
        Writes to file based on current path

        Args:
            outdict (dictionary): Dictionary with data to be dumped JSON
        """
        outputPath = os.path.abspath(os.path.join(".", "output.json"))
        logger.logger.info(f"Writing to {outputPath}")
        with open(outputPath, "wb") as p:
            data = orjson.dumps(outdict, option=orjson.OPT_INDENT_2)
            p.write(data)

    def _getChapterMedia(self, siteSourceObjs):
        """
        Helper Function to get which source to use as the basis for generating chapter data


        Args:
            siteSourceObjs (obj): array of siteSourceObj

        Returns:
            obj: returns the chapters from the matching siteSourceObj
        """
        match = siteSourceObjs[0]["sourceDir"]
        if len(siteSourceObjs) > 1:
            match = utils.singleSelectMenu(
                list(map(lambda x: x["sourceDir"], siteSourceObjs)), "Which Source Has The proper Chapter File")
        return list(filter(lambda x: x["sourceDir"] == match, siteSourceObjs))[0]["chapters"]

    def _subParse(self, muxSorter):
        """
        Takes the tracks from muxSorter obj, and applies OCR/Image Generation to certain subtitle tracks based on passed args


        Args:
            muxSorter (obj): siteMuxSorter  obj filled with unsorted and sorted tracks
        """
        # Add OCR for Subtitles
        tracks = None
        keep = self._args.keepocr
        langs = None
        if self._args.ocr != None:
            if self._args.ocr == "enabled":
                tracks = muxSorter.enabledSub
                keep = self._args.keepocr
            elif self._args.ocr == "default":
                tracks = muxSorter.unSortedSub
                langs = self._movieObj.get("languages", [])

            elif self._args.ocr == "sublang":
                tracks = muxSorter.unSortedSub
                langs = self._args.sublang,

            elif self._args.ocr == "english":
                tracks = muxSorter.unSortedSub
                langs = ["English"]

            elif self._args.ocr == "all":
                keep = muxSorter.unSortedSub
            for track in tracks:
                with dir.cwd(track["outputDir"]):
                    subreader.subreader([track], keep=keep, langs=langs)

        elif self._args.keepocr:
            tracks = muxSorter.enabledSub or []
            for track in tracks:
                with dir.cwd(track["outputDir"]):
                    subreader.imagesOnly([track])

    # Voice Recorder
    def _voiceRec(self, muxSorter):
        """
        Takes the tracks from muxSorter obj, and applies OCR to certain audio tracks based on passed args


        Args:
           muxSorter (obj): siteMuxSorter obj filled with unsorted and sorted tracks
        """
        tracks = None
        langs = None
        if self._args.voicerec != None:
            if self._args.voicerec == "enabled":
                tracks = muxSorter.enabledAudio
            elif self._args.voicerec == "default":
                tracks = muxSorter.unSortedAudio
                langs = self._movieObj.movieObj.get("languages", [])
            elif self._args.voicerec == "audiolang":
                tracks = muxSorter.unSortedAudio
                langs = self._args.audiolang
            elif self._args.voicerec == "english":
                tracks = muxSorter.unSortedAudio
                langs = ["English"]

            elif self._args.voicerec == "all":
                tracks = muxSorter.unSortedAudio
            for track in tracks:
                with dir.cwd(track["outputDir"]):
                    voiceRec.main([track], langs=langs)

    def _getMuxSorter(self, siteSourceObjs):
        """
        Creates and uses siteMuxSorter obj
        To flatten all tracks from multiple source into list by track types
        Filters and sorts tracks into enabled track lists by type

        Args:
             siteSourceObjs (array): array of siteSourceObj

        Returns:
            obj: returns muxSorter
        """
        muxSorter = siteSortPicker.pickSite(self._args.site)
        for siteSourceObj in siteSourceObjs:
            muxSorter.addTracks(siteSourceObj.tracks)
        languages = self._movieObj.movieObj.get("languages", [])
        muxSorter.sortTracks(languages,
                             self._args.audiolang, self._args.sublang, self._args.sortpref)
        if not self._args.skipforced:
            muxSorter.addForcedSubs(languages, self._args.audiolang)
        return muxSorter

    def _addSourceData(self, siteSourceObjs):
        """
        Generates a dictionary with data from sources

        Args:
        siteSourceObjs (array): array of  siteSourceObj

        Returns:
            dict: dictionary with sourceData
        """
        outdict = {}
        outdict["Sources"] = {}
        for siteSourceObj in siteSourceObjs:
            key = utils.sourcetoShowName(siteSourceObj["sourceDir"])
            outdict["Sources"][key] = {}
            outdict["Sources"][key]["outputDir"] = siteSourceObj["outputDir"]
            outdict["Sources"][key]["sourceDir"] = siteSourceObj["sourceDir"]
            outdict["Sources"][key]["playlistNum"] = siteSourceObj["playlistNum"]
            outdict["Sources"][key]["playlistFile"] = siteSourceObj["playlistFile"]
            outdict["Sources"][key]["streamFiles"] = siteSourceObj["streamFiles"]
            outdict["Sources"][key]["length"] = siteSourceObj["length"]

        return outdict

    def _addEnabledData(self, muxSorter):
        """
        Finds the key from all enabled tracks and outputs that to list seperated by track type

        Args:
        muxSorter (obj):siteMuxSorter obj filled with sorted and unsorted trackdata

        Returns:
            Dict: Dictionary of Lists, filled with track keys from enabled tracks
        """
        outdict = {}
        # Enabled Track Section
        outdict["Enabled_Tracks"] = {}
        outdict["Enabled_Tracks"]["Video"] = list(
            map(lambda x: x["key"], muxSorter.enabledVideo))
        outdict["Enabled_Tracks"]["Audio"] = list(
            map(lambda x: x["key"], muxSorter.enabledAudio))
        outdict["Enabled_Tracks"]["Sub"] = list(
            map(lambda x: x["key"], muxSorter.enabledSub))
        return outdict

    def _ConvertChapterList(self, chapters):
        """
        Takes chapter obj and modifies output
        into mkvmerge syntax

        Args:
            chapters (obj): chapters obj filled with chapter data

        Returns:
            _type_: _description_
        """
        outdict = {}
        output = []
        if len(chapters) == 0:
            return output
        for chapter in chapters:
            nameString = f"CHAPTER{chapter['number']:02d}NAME=Chapter {chapter['number']:02d}"
            timeString = f"CHAPTER{chapter['number']:02d}={chapter['start']}"
            output.append({"time": timeString, "name": nameString})
        outdict["Chapters"] = output
        return outdict

    def _setBdInfoData(self):
        """
        Creates bdObjs from selected sources
        Prompts User for playlist info, generates data from selected playlist

        Returns:
            array: returns an array of processed bdobjs
        """
        bdObjs = []
        for source in self.sources:
            logger.logger.info(f"\n{source}\n")
            logger.logger.info(f"Setting BDINFO Object for {source}...\n")
            bdObj = bdinfo.Bdinfo()
            bdObj.setup(source)
            bdObjs.append(bdObj)
        return bdObjs

    def _fixArgs(self):
        """
        Helps function to normalize arguments
        i.e convert languages to all lower cases

        Additonaly helps with converting noncompatible combinations of arguments
        """

        logger.print("Normalize audiolang and sublang args")
        self._args.audiolang = list(
            map(lambda x: x.lower(),  self._args.audiolang))
        self._args.sublang = list(
            map(lambda x: x.lower(),  self._args.sublang))
        if self._args.extractprogram == "dgdemux":
            logger.print(
                "dgdemux does not support track converting\nSetting dontconvert arg to True\n")
            self._args.dontconvert = True
        logger.logger.debug(str(self._args))
    # Folder Stuff

    def _getBDMVs(self, path):
        """
        Takes a input path and searches for all BDMVs, and ISO

        Args:
            path (str): Path to search for matching files
        Returns:
            array: array of all matching paths
        """
        with dir.cwd(path):
            list1 = paths.search(path, "/STREAM", dir=True, ignore=["BACKUP"])
            list2 = paths.search(path, "\.iso$")
            list1.extend(list2)
            list1 = list(
                map(lambda x: paths.convertPathType(x, "Linux"), list1))
            return natsort.natsorted(list1)

    def _createParentDemuxFolder(self, sources, outpath):
        """
        Takes output folder from args, and generates a demuxfolder based on correct time, and first source selected
        This folder is the basis for all generated and saved outputs during the programs run.

        Args:
            sources (array): List of sources selected
            outpath (str): path to output folder

        Returns:
            str: full path to demuxing Folder
        """
        with dir.cwd(outpath):
            title = utils.getTitle(sources[0])
            folder = f"{config.demuxPrefix}.{utils.getFormated('YY.MM.DD_HH.mm.ss')}.{title}"
            parentDemux = os.path.join(outpath, folder)
            parentDemux = re.sub(" +", " ", parentDemux)
            parentDemux = re.sub(" ", ".", parentDemux)
            parentDemux = paths.convertPathType(parentDemux, "Linux")
            logger.logger.info(
                f"Creating a new Parent Directory for {self._name} ->{parentDemux}")
            os.mkdir(parentDemux)
            return parentDemux

    def _createChildDemuxFolder(self, parentDir, show):
        """
        Takes a parent demux folder, generates a child folder base on the path to the source being passed

        Args:
            parentDir (str): path to parent demux folder
            show (str):modified basename generated from path
        Returns:
            str: path to child demux folder inside parent demux folder
        """
        with dir.cwd(parentDir):
            show = utils.sourcetoShowName(show)
            os.mkdir(show)
            return paths.convertPathType(os.path.join(parentDir, show), "Linux")
