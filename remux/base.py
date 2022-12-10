import os
import re
from string import Template

import orjson

import tools.logger as logger
import tools.general as utils
import tools.paths as paths
import config as config
import tools.directory as dir
import sites.pickers.siteMuxPicker as muxPicker


class Remux():
    def __init__(self,args):
        self._args=args
        self._remuxConfig=None
        self._filename=None
        self._muxGenerator=muxPicker.pickSite(self._args.site)

   
    def __call__(self):
        logger.setUpLogging(self._args.loglevel)
        self._callFunction()
        self._success=True
    
    ##########
    #
    #Private
    ##########
    def _callFunction(self):
        self._getRemuxConfig()
        self._getfilename()
        if self._overwriteexists==False:
            self._success=True
            return
        self._processRemux()


    def _processRemux(self):
        # Variables
        chaptersTemp = self._chapterListParser(self._remuxConfig["Chapters"])
        xmlTemp = self._writeXML()

        self._muxGenerator.generateMuxData(self._remuxConfig, self._args.outargs)
        title = self._getTitle()
        year = self._getYear()
        movieTitle = f"{title} ({year})"
        if chaptersTemp:
            self._muxGenerator.createMKV(self._filename, movieTitle,
                                chaptersTemp, xmlTemp, self._getPrimaryBDInfo(), self._getPrimaryEac3to())
        else:
            self._muxGenerator.createMKV(self._filename, title, year,
                                None, xmlTemp, self._getPrimaryBDInfo(), self._getPrimaryEac3to())
    
    def _getRemuxConfig(self):
        folders = self._getRemuxFolder()
        if len(folders) == 0:
            raise RuntimeError("You need to demux a folder with Movie Mode first")
        remuxConfigPath = os.path.join(utils.singleSelectMenu(folders, "Pick the folder with the files you want to remux"), "output.json")
        with open(remuxConfigPath, "r") as p:
            self._remuxConfig = orjson.loads(p.read()) 
        logger.logger.debug(f"Remux Config: {self._remuxConfig}")
        self._getFullPaths()
        self._checkMissing()    
    def _getfilename(self):
         with dir.cwd(self._args.outpath):
            self._filename = self._muxGenerator.getFileName(
                self._remuxConfig, self._args.group, self._getTitle(), self._getYear(), self._args.skipnamecheck)
    def _getTitle(self):
        return self._remuxConfig['Movie'].get(
            'title') or self._remuxConfig['Movie'].get('engTitle')
    def _getYear(self):
        return self._remuxConfig['Movie']['year']
    def _getRemuxFolder(self):
        folders = paths.search(self._args.inpath, f"/{config.demuxPrefix}[.]",dir=True,recursive=False)
        folders=list(filter(lambda x: os.path.isdir(x),folders))
        folders = list(filter(lambda x: len(os.listdir(x)) > 0, folders))
        folders = list(filter(lambda x: re.search(
            "^[0-9]+$", os.listdir(x)[0]) == None, folders))
        return folders
    def _getFullPaths(self):
        audioTrackKeys=self._remuxConfig["Enabled_Tracks"]["Audio"]
        videoTrackKeys=self._remuxConfig["Enabled_Tracks"]["Video"]
        subTrackKeys=self._remuxConfig["Enabled_Tracks"]["Sub"]
        for key in audioTrackKeys:
            self._remuxConfig["Tracks_Details"]["Audio"][key]["filename"]=self._getPathHelper(self._remuxConfig["Tracks_Details"]["Audio"][key])
        for key in videoTrackKeys:
            self._remuxConfig["Tracks_Details"]["Video"][key]["filename"] =self._getPathHelper(self._remuxConfig["Tracks_Details"]["Video"][key])
        for key in subTrackKeys:
            self._remuxConfig["Tracks_Details"]["Sub"][key]["filename"] =self._getPathHelper(self._remuxConfig["Tracks_Details"]["Sub"][key])
    def _getPathHelper(self,track):
        outputDir=self._remuxConfig["Sources"][track["sourceKey"]]["outputDir"]
        return os.path.abspath(os.path.join(outputDir,track["filename"]))

    def _checkMissing(self):
        self._validateFilesExists([self._remuxConfig["Tracks_Details"]["Sub"][x]["filename"] for x in self._remuxConfig["Enabled_Tracks"]["Sub"]])
        self._validateFilesExists([self._remuxConfig["Tracks_Details"]["Audio"][x]["filename"] for x in self._remuxConfig["Enabled_Tracks"]["Audio"]])
        self._validateFilesExists([self._remuxConfig["Tracks_Details"]["Video"][x]["filename"] for x in self._remuxConfig["Enabled_Tracks"]["Video"]])
        if len([key for key in self._remuxConfig["Sources"]]) == 0:
            logger.print("No Sources Found For this item\nSkipping to Next Item")
            return
    def _validateFilesExists(self,fileList):
        for file in fileList:
            if not os.path.exists(file):
                raise Exception(f"Remuxing File Missing {file}")

    def _overwriteexists(self):
        if os.path.exists(self._filename):
            if utils.singleSelectMenu(["Yes","No"],"Some files already exist\nDo you want overwrite the file(s), and continue the remux process")=="No":
                return False
            else:
                return True
    def _chapterListParser(self,chapterList):
        if chapterList == None:
            return
        tempData = paths.createTempDir()
        chapterPath=os.path.join(tempData,"chapter.txt")
        
        with open(chapterPath, "w") as p:
            for dict in chapterList:
                p.write(dict["time"])
                p.write("\n")
                p.write(dict["name"])
                p.write("\n")
        return chapterPath
    def _writeXML(self):
        infile = os.path.join(config.root_dir,  f"xml/movie")
        imdb=self._remuxConfig["Movie"]["imdb"]
        tmdb= self._remuxConfig["Movie"]["tmdb"]
        tempData = paths.createTempDir()
        xmlPath=os.path.join(tempData,"xml.txt")
        with open(infile, 'r') as f:
            src = Template(f.read())
            result = src.substitute({"imdb": imdb, "tmdb": tmdb})
        with open(xmlPath, "w") as p:
            p.writelines(result)
        return xmlPath
    def _getPrimaryBDInfo(self):
        key = str(self._remuxConfig["Enabled_Tracks"]["Video"][0])
        outputDir=self._remuxConfig["Tracks_Details"]["Video"][key]["outputDir"]
        bdinfoList=paths.search(outputDir, "BDINFO")
        if len(bdinfoList)==0:
            return
        return bdinfoList[0]
    def _getPrimaryEac3to(self):
        key = str(self._remuxConfig["Enabled_Tracks"]["Video"][0])
        outputDir=self._remuxConfig["Tracks_Details"]["Video"][key]["outputDir"]
        eac3toList=paths.search(outputDir, "Eac3to*") 
        if len(eac3toList)==0:
            return
        return eac3toList[0]