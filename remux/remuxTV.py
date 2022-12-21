from remux.base import Remux
import os
import re
from string import Template
import traceback

import orjson

import tools.logger as logger
import tools.general as utils
import tools.paths as paths
import config as config
import tools.directory as dir
import sites.pickers.siteMuxPicker as muxPicker
import mediadata.movieData as movieData


class Remux(Remux):
    def __init__(self, args):
        super().__init__(args)
        self._movieObj = movieData.MovieData("TV")
        self._fileNames = []

    def _callFunction(self):
        for file in paths.search(self._getRemuxConfig(), "output.json", recursive=True):
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

    def _getRemuxFolders(self):
        folders = paths.search(
            self._args.inpath, f"/{config.demuxPrefix}[.]", dir=True, recursive=False)
        folders = list(filter(lambda x: os.path.isdir(x), folders))
        folders = list(filter(lambda x: len(os.listdir(x)) > 0, folders))
        folders = list(filter(lambda x: re.search(
            "^[0-9]+$", os.listdir(x)[0]) != None, folders))
        return folders

    def _getRemuxConfig(self):
        folders = self._getRemuxFolders()
        if len(folders) == 0:
            raise RuntimeError(
                "You need to demux a folder with Movie Mode first")
        return utils.singleSelectMenu(folders, "Pick the folder with the files you want to remux")

    def _remuxConfigHelper(self, remuxConfigPath):
        with open(remuxConfigPath, "r") as p:
            self._remuxConfig = orjson.loads(p.read())
        logger.logger.debug(f"Remux Config: {self._remuxConfig}")
        self._getFullPaths()

    def _writeXML(self):

        imdb = self._remuxConfig["Movie"]["imdb"]
        tmdb = self._remuxConfig["Movie"]["tmdb"]
        season = self._remuxConfig["Movie"]["season"]
        episode = self._remuxConfig["Movie"]["episode"]
        year = self._getYear()
        title = self._getTitle()
        epIMDB = self._movieObj.retriveEpisodeIMDB(
            imdb, tmdb, season, episode, title, year)
        epCount = self._movieObj.retriveNumberofEpisodes(
            season,  title, year, tmdb)

        tempData = paths.createTempDir()
        infile = os.path.join(config.root_dir,  f"xml/tv")
        xmlPath = os.path.join(tempData, "xml.txt")
        with open(infile, 'r') as f:
            src = Template(f.read())
            result = src.substitute(
                {"imdb": imdb, "tmdb": tmdb, "imdbEP": epIMDB, "totalEP": epCount, "season": season, "episode": episode})
        with open(xmlPath, "w") as p:
            p.writelines(result)
        return xmlPath

    def _getfilename(self):
        with dir.cwd(self._args.outpath):
            title = self._getTitle()
            year = self._remuxConfig['Movie']['year']
            season = self._remuxConfig["Movie"]["season"]
            episode = self._remuxConfig["Movie"]["episode"]
            tmdb = self._remuxConfig["Movie"]["tmdb"]
            if not self._args.special:
                with dir.cwd(os.path.join(".", self._muxGenerator.getTVDir(self._remuxConfig, self._args.group, title))):
                    self._movieObj.type = self._remuxConfig['Movie']["type"]
                    episodeTitle = None
                    if self._args.episodetitle:
                        episodeTitle = self._movieObj.retriveEpisodeTitle(
                            season, episode, title, year, tmdb)
                    return os.path.abspath(self._muxGenerator.getFileName(self._remuxConfig, self._args.group, title, episodeTitle))
            else:
                return os.path.abspath(self._muxGenerator.getFileName(self._remuxConfig, self._args.group, title, episodeTitle=f"Special.{episode}"))

    def _getJapTitle(self):
        return self._remuxConfig['Movie'].get('japTitle')
