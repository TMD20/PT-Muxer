import re
import os

from num2words import num2words
import langcodes

import tools.general as utils
from demux.base import Demux
import mediadata.movieData as movieData
import tools.paths as paths
import tools.directory as dir
import sites.pickers.siteSourcePicker as siteSourcePicker
import mediatools.dgdemux as dgdemux
import mediatools.eac3to as eac3to
import config
import tools.logger as logger


class Demux(Demux):
    """
    This class is for demuxing TV Shows

    Args:
        Demux (class): demuxBase class
    """

    def __init__(self, args):
        super().__init__(args)
        self._name = "TV Shows"
        self._type = "TV"

    def _callFunction(self):
        """
        Helper main function called by internal __call__ function 
        """
        self.setSource()
        self._fixArgs()
        self.setDemuxFolder()
        self.demux()

    def demux(self):
        """
        Gathers Information from a selected movie Title
        Generates BDINFO Data for all soruces 
        Demuxes Movie based on args and selected playlist
        """
        with dir.cwd(self.demuxFolder):
            self._movieObj = movieData.MovieData("TV")
            self._movieObj.setData(
                self._type, (self._args.title or utils.getTitle(self.sources[0])))
            bdObjs = self._setBdInfoData()
            if self._args.splitplaylist:
                self.demuxSplitPlayList(bdObjs)
            else:
                self.demuxPlaylist(bdObjs, multiSelect=True)

    def demuxSplitPlayList(self, bdObjs):
        """
        Performs demuxing based on splitting playlist into individual streams

        Args:
            bdObjs (array): array of bdObjs
        """
        for bdObj in bdObjs:
            logger.print(bdObj.mediaDir, style="white")
            bdObj.playListRangeSelect()
        for i in range(len(bdObjs[0].keys)):
            self._index = i
            for bdObj in bdObjs:
                bdObj.generateData(i)
                demuxData = siteSourcePicker.pickSite(self._args.site)
        bdObjs[0].validateStreams(bdObjs)

        if self._args.extractprogram == "eac3to":
            self._eac3toSplitPlaylistHelper(bdObjs)

        else:
            self._dgdemuxSplitPlaylistHelper(bdObjs)

    def _eac3toSplitPlaylistHelper(self, bdObjs):
        """
        Helper Function to perform splitplaylist process with eac3to

        Args:
            bdObjs (array): array of bdObjs
        """
        # outter loop through every playlist
        for i in range(len(bdObjs[0].DictList)):
            startdex = len(os.listdir(self.demuxFolder))
            siteSourceObjDict = {}
            maxLength = max(
                list(map(lambda x: len(x.streamTracks(i, self._args.splitplaylist)), bdObjs)))
            [siteSourceObjDict.update({m: {"folder": self._getNewFolder(
                startdex+m), "list": []}}) for m in range(maxLength)]
            for bdObj in bdObjs:
                logger.logger.info(
                    f"Processing all streams for {bdObj.mediaDir} Playlist: {bdObj.DictList[i]['playlistFile']}")
                streams = bdObj.streamTracks(i, self._args.splitplaylist)
                for j, stream in enumerate(streams):
                    newFolder = self._getNewFolder(startdex+j)
                    with dir.cwd(newFolder):
                        demuxData = siteSourcePicker.pickSite(self._args.site)
                        demuxData.addTracks(
                            bdObj, bdObj.keys[i], streams=[stream])
                        self._filterStreamMedia(
                            demuxData, bdObj.DictList[i]["streamTracks"][stream["name"]])
                        demuxData.output=newFolder
                        demuxData.setOutPutDir(newFolder)
                        with dir.cwd(demuxData["outputDir"]):
                            if not self._args.dontconvert:
                                demuxData.convertFlac()
                            bdObj.writeBDInfo(i)
                            logger.logger.info(
                                f"\nExtracting Files From stream:{stream['name']}")
                            eac3to.process(
                                demuxData.tracks, demuxData["sourceDir"], demuxData["streamFiles"][0])
                            siteSourceObjDict[j]["list"].append(demuxData)

            # Take combined data struture process each stream index
            for key in siteSourceObjDict.keys():
                siteSourceObjs = siteSourceObjDict[key]["list"]
                newFolder = siteSourceObjDict[key]["folder"]
                with dir.cwd(newFolder):
                    muxSorter = self._getMuxSorter(siteSourceObjs)
                    self._subParse(muxSorter)
                    self._voiceRec(muxSorter)
                    self._writeFinalJSON(
                        self._saveOutput(siteSourceObjs, muxSorter))

    def _dgdemuxSplitPlaylistHelper(self, bdObjs):
        """
        Helper Function to perform splitplaylist process with dgdemux

        Args:
            bdObjs (array): array of bdObjs
        """
        logger.print(
            "Note in dgdemux Mode all streams will be outputted\n You will have to manually remove any short streams")
        # i represent each playlist
        for i in range(len(bdObjs[0].keys)):
            startdex = len(os.listdir(self.demuxFolder))
            siteSourceObjDict = {}
            maxLength = max(
                list(map(lambda x: len(x.streamTracks(i, self._args.splitplaylist)), bdObjs)))
            [siteSourceObjDict.update({m: {"folder": self._getNewFolder(
                startdex+m), "list": []}}) for m in range(maxLength)]
            for bdObj in bdObjs:
                logger.logger.info(
                    f"Processing all streams for {bdObj.mediaDir} Playlist: {bdObj.DictList[i]['playlistFile']}")
                tempdir = paths.createTempDir()
                # This sectiom Extracts all tracks for all sources into tempdir
                with dir.cwd(tempdir):
                    newFolder = ""
                    demuxData = siteSourcePicker.pickSite(self._args.site)
                    # Send every track
                    # dgdemux will filter via indexes
                    demuxData.addTracks(bdObj, bdObj.keys[i])
                    currentTracks = demuxData.tracks
                    dgdemux.run(
                        currentTracks, demuxData["sourceDir"], demuxData["playlistFile"], ep=True)

                # Processes the previous tempdirFiles
                # Each stream gets subfolder in tempdir
                streams = bdObj.streamTracks(i, self._args.splitplaylist)
                for j, stream in enumerate(streams):
                    newFolder = self._getNewFolder(startdex+j)
                    # prepare info
                    with dir.cwd(newFolder):
                        demuxData = siteSourcePicker.pickSite(self._args.site)
                        # filter hidden tracks here
                        demuxData.addTracks(
                            bdObj, bdObj.keys[i], streams=[stream])
                        currentTracks = self._filterStreamMedia(
                            demuxData, bdObj.DictList[i]["streamTracks"][stream["name"]])
                        demuxData.setOutPutDir(newFolder)
                        # processs info into outputdir subfolder
                        with dir.cwd(demuxData["outputDir"]):
                            paths.copytree(paths.listdir(tempdir)[j], ".")
                            bdObj.writeBDInfo(i)
                            siteSourceObjDict[j]["list"].append(demuxData)

            # Take combined data struture process each stream index
            for key in siteSourceObjDict.keys():
                siteSourceObjs = siteSourceObjDict[key]["list"]
                newFolder = siteSourceObjDict[key]["folder"]
                with dir.cwd(newFolder):
                    muxSorter = self._getMuxSorter(siteSourceObjs)
                    self._subParse(muxSorter)
                    self._voiceRec(muxSorter)
                    self._writeFinalJSON(
                        self._saveOutput(siteSourceObjs, muxSorter))

    def _saveOutput(self, siteSourceObjs, muxSorter):
        """
        Generates a dictionary filled with data from demuxing process

        Args:
            siteSourceObjs (array): array of siteSourceobj
            muxSorter (obj): siteMuxSorter Obj

        Returns:
            dictionary: outdict dictionary
        """
        outdict = super()._saveOutput(siteSourceObjs, muxSorter)
        currentFolders = list(map(lambda x: re.search(
            "[0-9]+$", x).group(0), paths.listdir(self.demuxFolder)))
        folderNum = re.search("[0-9]+$", os.path.abspath(".")).group(0)
        outdict["Movie"]["episode"] = currentFolders.index(folderNum)+1
        return outdict

    ####
    # Helper Functions
    ####

    def _getNewFolder(self, i):
        """
        Generates the next incremental folder inside parent demux folder based on number of sibling folders previosuly geneated

        Args:
            i (int): Number of sibling folders
        Returns:
            str: path to new folder
        """

        return os.path.join(self.demuxFolder, str(i+1))

    def _filterStreamMedia(self, demuxData, streamTracks):
        """
        Helper Function to filter out tracks in demuxData. Tracks that appear in the parent playlist, but are not within a
        specicic stream
        Args:
             demuxData (obj):siteSourceData Object with data parsed from bdinfo
            streamTracks (array): List of all tracks within the specific stream
        """
        self._videoTrackHelper(demuxData, streamTracks)
        self._audioTrackHelper(demuxData, streamTracks)
        self._subTrackHelper(demuxData, streamTracks)

    def _audioTrackHelper(self, demuxData, streamTracks):
        """
        Helper Function to help filter tracks for filterStreamTracks
        Args:
        demuxData (obj):siteSourceData Object with data parsed from bdinfo
            streamTracks (array): List of all tracks within the specific stream
        """
        i = 0
        streamTracks = list(
            filter(lambda x: x["type"] == "audio", streamTracks))
        demuxDataTracks = list(
            filter(lambda x: x[1]["compat"] == False, demuxData.audioitems))

        for key, value in demuxDataTracks:
            if i >= len(streamTracks):
                demuxData["tracks"].pop(key)
                continue
            streamTrack = streamTracks[i]
            if re.search(streamTrack["codec"], value["bdinfo_title"]) == None:
                demuxData["tracks"].pop(key)
                continue
            if langcodes.standardize_tag(value["langcode"]) != langcodes.standardize_tag(streamTrack["lang"]):
                demuxData["tracks"].pop(key)
                continue
            i = i+1
        compatItems = demuxData.compatitems
        for key, value in compatItems:
            if demuxData["tracks"].get(value["parentKey"]) == None:
                demuxData["tracks"].pop(key)

    def _videoTrackHelper(self, demuxData, streamTracks):
        """
        Helper Function to help filter tracks for filterStreamTracks
        Args:
        demuxData (obj):siteSourceData Object with data parsed from bdinfo
            streamTracks (array): List of all tracks within the specific stream
        """
        i = 0
        streamTracks = list(
            filter(lambda x: x["type"] == "video", streamTracks))
        demuxDataTracks = demuxData.videoitems

        for key, value in demuxDataTracks:
            if i >= len(streamTracks):
                demuxData["tracks"].pop(key)
                continue
            streamTrack = streamTracks[i]
            if re.search(streamTrack["codec"], value["bdinfo_title"]) == None:
                demuxData["tracks"].pop(key)
                continue
            i = i+1

    def _subTrackHelper(self, demuxData, streamTracks):
        """
        Helper Function to help filter tracks for filterStreamTracks
        Args:
        demuxData (obj):siteSourceData Object with data parsed from bdinfo
            streamTracks (array): List of all tracks within the specific stream
        """
        i = 0
        streamTracks = list(
            filter(lambda x: x["type"] == "subtitle", streamTracks))
        demuxDataTracks = demuxData.subtitleitems

        for key, value in demuxDataTracks:
            if i >= len(streamTracks):
                demuxData["tracks"].pop(key)
                continue
            streamTrack = streamTracks[i]
            if langcodes.standardize_tag(value["langcode"]) != langcodes.standardize_tag(streamTrack["lang"]):
                demuxData["tracks"].pop(key)
                continue
            i = i+1

    def setSource(self):
        """
        Filters sources in input directories based on user selection
        """
        options = self._getBDMVs(self._args.inpath)
        self.sources = self.getSources(
            options, self._args.inpath, self._args.sortpref)

    def getSources(self, options, inpath, sortpref):
        """
        Returns array of selected paths, based on user input

        Args:
            options (array): compatible paths from input folder
            inpath (str): inpath used to generate options
            sortpref (str): How tracks should be sorted
        Raises:
            RuntimeError: Error raised if no valid source is found

        Returns:
            array: Array of selected source, and extracted ISO
        """
        if len(options) == 0:
            raise RuntimeError("No Sources Directories Found")
        sources = None
        sources = self._addMultiSource(options, sortpref)
        for i in range(0, len(sources)):
            if re.search(".iso", sources[i]):
                sources[i] = paths.extractISO(sources[i], inpath)
        return sources

    def setDemuxFolderHelper(self, sources, outpath):
        """
        Returns parent demux folder path based on source and outputpath

        Args:
            sources (array): array of sources
            outpath (str): outpath from args

        Returns:
            str : path to generated parent demux Folder
        """
        if utils.singleSelectMenu(["Yes", "No"], "Continue with Previous MuxFolder", default="No") == "Yes":
            logger.print("Searching for Prior TV Mode Folders")
            folders = self._getTVMuxFolders(outpath)
            if len(folders) == 0:
                logger.print("No TV Mode Folders Found To Restore")
                logger.print("Creating a new Mux Folder")
                return self._createParentDemuxFolder(
                    sources, outpath)
            else:
                folder = utils.singleSelectMenu(
                    folders, "Which Folder Do you want to Restore")

                return folder
        else:
            return self._createParentDemuxFolder(sources, outpath)

    def setDemuxFolder(self):
        """
        Ensures outpath from args exists

        sets demuxfolder property of demuxObJ
        """
        paths.mkdirSafe(self._args.outpath)
        self.demuxFolder = self.setDemuxFolderHelper(
            self.sources, self._args.outpath)

    # Select
    def _addMultiSource(self, paths, sortpref):
        """
        Takes a list of source paths, and allows users to filter list based on input

        Args:
            sources (array): List of potential sources
            sortpref (str): user prefrences for sorting tracks/sources

        Returns:
            str: list of selected sources

        """
        if len(paths) == 0:
            raise RuntimeError("No Sources Directories Found")
        msg = None
        if sortpref == "size":
            msg = \
                """
            Click on the Source(s) You Want for this Demux

            TV Mode will run multiple times
            for more advanced source selection
            """
            return utils.multiSelectMenu(paths, msg)
        else:
            msg = \
                """
            Since you selected --sortpref order
            You will be prompted multiple times to make a selection
            Pay attention to the order of the list printed out, as this will effect enabled tracks

            Source You Want for this Demux
            For TV Shows you can change the Source(s) Per Episode

            When Finish Click 'I'm Done Selecting Sources'
            """
            list = ["I'm done selecting sources", "I want to reset my list"]
            list.extend(paths)
            selection = []
            while True:
                logger.print(f"Your list thus far\n\n")
                logger.print("\n".join(selection))
                curr_select = utils.singleSelectMenu(list, msg)
                selection.append(curr_select)
                if curr_select == "I want to reset my list":
                    selection = []
                if curr_select == "I'm done selecting sources":
                    break
            selection = list(filter(lambda x: x != "done" and x != None))
            selection = utils.removeDupesList(selection)
            return selection

    def _getTVMuxFolders(self, outpath):
        """
        Helper Function to get demuxFolders from prior runs

        Args:
            outpath (string): outpath which holds demux Folders
        Returns:
            array:  array of demuxFolders with TV Mode Structure
        """
        folders = paths.search(
            outpath, f"{config.demuxPrefix}[.]", dir=True, recursive=False)
        emptyFolders = list(filter(lambda x: len(os.listdir(x)) == 0, folders))
        tvFolders = list(filter(lambda x: len(os.listdir(x)) > 0, folders))
        tvFolders = list(filter(lambda x: re.search(
            "^[0-9]+$", os.listdir(x)[0]) != None, tvFolders))
        tvFolders.extend(emptyFolders)
        return tvFolders
