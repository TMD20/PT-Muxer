import os
import re
from string import Template
from typing import Union,List


import orjson

import src.tools.logger as logger
import src.tools.general as utils
import src.tools.paths as paths
import config as config
import src.tools.directory as dir
import src.sites.pickers.siteMuxPicker as muxPicker


class Remux():
    """
    Base Remux Class
    For processing remuxes
    """
    def __init__(self, args)->None:
        self._args = args
        self._remuxConfig = None
        self._fileName = None
        self._muxGenerator = muxPicker.pickSite(self._args.site)
        self._success = False

    def __call__(self)->None:
        """
        Internal function for python object
        """
        logger.setUpLogging(self._args.loglevel)
        self._callFunction()
        self._success = True

    @property
    def success(self)->bool:
        """
        Returns bool based on succesful call

        Returns:
            bool: Whether or not call completed succesfully
        """
        return self._success

    ##########
    #
    # Private
    ##########
    def _callFunction(self)->None:
        """
        Function used by internal call function to process remux
        """
        self._getRemuxConfig()
        self._fileName = self._getfilename()
        if not self._args.skipnamecheck:
            self._muxGenerator.confirmName(self._fileName)
        if self._overwriteexists() == False:
            self._success = True
            return
        self._processRemux()

    def _processRemux(self)->None:
        """
        Gathers information to send to muxGenerator 
        for final mkvmerge processing
        """
        # Variables
        chaptersTemp = self._chapterListParser(self._remuxConfig["Chapters"])
        xmlTemp = self._createXML()

        self._muxGenerator.generateMuxData(
            self._remuxConfig, self._args.outargs)
        title = self._getTitle()
        year = self._getYear()
        movieTitle = f"{title} ({year})"
        if chaptersTemp:
            self._muxGenerator.createMKV(self._fileName, movieTitle,
                                         chaptersTemp, xmlTemp, self._getPrimaryBDInfo(), self._getPrimaryEac3to())
        else:
            self._muxGenerator.createMKV(self._fileName, title, year,
                                         None, xmlTemp, self._getPrimaryBDInfo(), self._getPrimaryEac3to())
        self._muxGenerator.printMediaInfo(self._fileName)

    def _getRemuxConfig(self)->None:
        """
        Retrives remux json based on user input

        Raises:
            RuntimeError: Error if no remux jsons to pick from
        """
        folders = self._getRemuxFolders()
        if len(folders) == 0:
            raise RuntimeError(
                "You need to demux a folder with Movie Mode first")
        remuxConfigPath = os.path.join(utils.singleSelectMenu(
            folders, "Pick the folder with the files you want to remux"), "output.json")
        with open(remuxConfigPath, "r") as p:
            self._remuxConfig = orjson.loads(p.read())
        logger.logger.debug(f"Remux Config: {self._remuxConfig}")
        self._getFullPaths()
        self._checkMissing()

    def _getfilename(self):
        """
        returns final location for mkv

        Returns:
            str: path to mkv
        """
        with dir.cwd(self._args.outpath):
            return os.path.abspath(self._muxGenerator.getFileName(
                self._remuxConfig, self._args.group, self._getTitle()))
    def _getTitle(self)->str:
        """
        Retrives title with priority on english title

        Returns:
            str: title of movie
        """
        return self._remuxConfig['Movie'].get(
            'title') or self._remuxConfig['Movie'].get('engTitle')

    def _getYear(self)->int:
        """
        Retrieves release year of movie

        Returns:
            int: release year
        """
        return self._remuxConfig['Movie']['year']

    def _getRemuxFolders(self)->str:
        """
        Retrieves all output folders from demux Movie Mode

        Returns:
            array: array of demux Movie Mode output folders
        """
        folders = paths.search(
            self._args.inpath, f"/{config.demuxPrefix}[.]", dir=True, recursive=False)
        folders = list(filter(lambda x: os.path.isdir(x), folders))
        folders = list(filter(lambda x: len(os.listdir(x)) > 0, folders))
        folders = list(filter(lambda x: re.search(
            "^[0-9]+$", os.listdir(x)[0]) == None, folders))
        return folders

    def _getFullPaths(self)->None:
        """
        Updates filepaths in remuxConfig dict with full filepath, based on outputdir key
        of source json file
        """
        audioTrackKeys = self._remuxConfig["Enabled_Tracks"]["Audio"]
        videoTrackKeys = self._remuxConfig["Enabled_Tracks"]["Video"]
        subTrackKeys = self._remuxConfig["Enabled_Tracks"]["Sub"]
        for key in audioTrackKeys:
            self._remuxConfig["Tracks_Details"]["Audio"][key]["filename"] = self._getPathHelper(
                self._remuxConfig["Tracks_Details"]["Audio"][key])
        for key in videoTrackKeys:
            self._remuxConfig["Tracks_Details"]["Video"][key]["filename"] = self._getPathHelper(
                self._remuxConfig["Tracks_Details"]["Video"][key])
        for key in subTrackKeys:
            self._remuxConfig["Tracks_Details"]["Sub"][key]["filename"] = self._getPathHelper(
                self._remuxConfig["Tracks_Details"]["Sub"][key])

    def _getPathHelper(self, track:dict)->str:
        """
        Uses outputdir key to get final location of file

        Args:
            track (dict): trackobj to retrive info for
        Returns:
            str: returns final location of file
        """
        outputDir = self._remuxConfig["Sources"][track["sourceKey"]]["outputDir"]
        return os.path.abspath(os.path.join(outputDir, track["filename"]))

    def _checkMissing(self)->None:
        """
        Validates that output directory is correct for all files
        by checking if the files exist
        """
        self._validateFilesExists([self._remuxConfig["Tracks_Details"]["Sub"][x]["filename"]
                                  for x in self._remuxConfig["Enabled_Tracks"]["Sub"]])
        self._validateFilesExists([self._remuxConfig["Tracks_Details"]["Audio"][x]["filename"]
                                  for x in self._remuxConfig["Enabled_Tracks"]["Audio"]])
        self._validateFilesExists([self._remuxConfig["Tracks_Details"]["Video"][x]["filename"]
                                  for x in self._remuxConfig["Enabled_Tracks"]["Video"]])
        if len([key for key in self._remuxConfig["Sources"]]) == 0:
            logger.print(
                "No Sources Found For this item\nSkipping to Next Item")
            return

    def _validateFilesExists(self, fileList:List[Union[str, bytes, os.PathLike]])->None:
        """
        Helper function to check existance of each file within a list

        Args:
            fileList (array): list of file to check

        Raises:
            Exception: Error if file is found missing
        """
        for file in fileList:
            if not os.path.exists(file):
                raise Exception(f"Remuxing File Missing {file}")

    def _overwriteexists(self)->None:
        """
        Provides prompt to overwrite file or quit program
        """

        if os.path.exists(self._fileName):
            if utils.singleSelectMenu(["Yes", "No"], f"{self._fileName} already exist\nDo you want overwrite the file, and continue the remux process") == "No":
                return False
            else:
                return True

    def _chapterListParser(self, chapterList)->str:
        """
        Parses remuxConfig chapter list array into mkvmerge compatabile file 

        Args:
            chapterList (array): chapter list array

        Returns:
            str: final path to chapter.txt file
        """
        if chapterList == None:
            return
        tempData = paths.createTempDir()
        chapterPath = os.path.join(tempData, "chapter.txt")

        with open(chapterPath, "w") as p:
            for dict in chapterList:
                p.write(dict["time"])
                p.write("\n")
                p.write(dict["name"])
                p.write("\n")
        return chapterPath

    def _createXML(self)->None:
        """
        Uses xml template and data from remuxConfig to write xml to temp location

        Returns:
            str: path to xml file
        """
        infile = os.path.join(config.root_dir,  f"xml/movie")
        imdb = self._remuxConfig["Movie"]["imdb"]
        tmdb = self._remuxConfig["Movie"]["tmdb"]
        tempData = paths.createTempDir()
        xmlPath = os.path.join(tempData, "xml.txt")
        with open(infile, 'r') as f:
            src = Template(f.read())
            result = src.substitute({"imdb": imdb, "tmdb": tmdb})
        with open(xmlPath, "w") as p:
            p.writelines(result)
        return xmlPath

    def _getPrimaryBDInfo(self)->str:
        """
        Helper function to get bdinfo file for main source of remux
        based on first video track enabled


        Returns:
            str: returns path to bdinfo for source
        """
        key = str(self._remuxConfig["Enabled_Tracks"]["Video"][0])
        outputDir = self._remuxConfig["Tracks_Details"]["Video"][key]["outputDir"]
        bdinfoList = paths.search(outputDir, "BDINFO")
        if len(bdinfoList) == 0:
            return
        return bdinfoList[0]

    def _getPrimaryEac3to(self)->str:
        """
        Helper function to get eac3to file for main source of remux
        based on first video track enabled


        Returns:
            str: returns path to eac3to for source
        """        
        key = str(self._remuxConfig["Enabled_Tracks"]["Video"][0])
        outputDir = self._remuxConfig["Tracks_Details"]["Video"][key]["outputDir"]
        eac3toList = paths.search(outputDir, "Eac3to*")
        if len(eac3toList) == 0:
            return
        return eac3toList[0]
