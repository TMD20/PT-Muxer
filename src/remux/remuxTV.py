import os
import re
from string import Template
import traceback
from typing import Union,List



import orjson

from src.remux.base import Remux
import src.tools.logger as logger
import src.tools.general as utils
import src.tools.paths as paths
import config as config
import src.tools.directory as dir
import src.mediadata.movieData as movieData


class Remux(Remux):
    """
    Remux Class for TV Remux
    Extension of base Remux class

    Args:
        Remux (class): base Remux Class
    """
    def __init__(self, args)->None:
        super().__init__(args)
        self._movieObj = movieData.MovieData("TV")
        self._fileNames = []

    def _callFunction(self)->None:
        """
        Function used by internal __call__ function
        """
        jsons = paths.search(self._getRemuxConfig(),
                             "output.json", recursive=True)
        jsonsFiltered = self._getFilteredJSONs(jsons)
        for file in jsonsFiltered:
            logger.logger.info(f"Processing {file}")
            self._remuxConfigHelper(file)
            try:
                self._checkMissing()
            except Exception as E:
                # logger.logger.warn(E)
                logger.print(traceback.format_exc(), style="white")
                logger.print("Skipping", style="white")
                continue

            self._fileName = self._getfilename()
            if self._args.skipnamecheck == False:
                self._muxGenerator.confirmName(self._fileName)
            if self._overwriteexists() == False:
                self._success = True
                continue

            self._fileNames.append(self._fileName)
        for fileName in self._fileNames:
            self._fileName = fileName
            self._processRemux()

    def _getRemuxFolders(self)->None:
        """
        Retrives demux folders from demux TV Mode

        Returns:
            array: an array of filepaths to demux folders
        """
        folders = paths.search(
            self._args.inpath, f"/{config.demuxPrefix}[.]", dir=True, recursive=False)
        folders = list(filter(lambda x: os.path.isdir(x), folders))
        folders = list(filter(lambda x: len(os.listdir(x)) > 0, folders))
        folders = list(filter(lambda x: re.search(
            "^[0-9]+$", os.listdir(x)[0]) != None, folders))
        return folders

    def _getRemuxConfig(self)->None:
        """
        Returns user selected demuxFolder

        Raises:
            RuntimeError: Error if no folders to pick from
        Returns:
            str: user selected demuxFolder
        """
        folders = self._getRemuxFolders()
        if len(folders) == 0:
            raise RuntimeError(
                "You need to demux a folder with Movie Mode first")
        return utils.singleSelectMenu(folders, "Pick the folder with the files you want to remux")

    def _remuxConfigHelper(self, remuxConfigPath:Union[str, bytes, os.PathLike]=None)->None:
        """
        converts remuxConfig json into python dict
        Retrives fullpaths to file pased on remuxConfig json location


        Args:
            remuxConfigPath (str): path to remuxConfig Json
        """
        with open(remuxConfigPath, "r") as p:
            self._remuxConfig = orjson.loads(p.read())
        logger.logger.debug(f"Remux Config: {self._remuxConfig}")
        self._getFullPaths()

    

    


    def _getFilteredJSONs(self, jsons:List[Union[str, bytes, os.PathLike]])->List[str]:
        """
        Filters jsons based on user input
        Args:
            json (array):an array of paths to json
        Returns
            array: returns filtered array of jsons
        """
        msg =\
            """
        Confirm Which JSON(s) You would like to process remux(s) for

        """
        return utils.multiSelectMenu(jsons, msg)
