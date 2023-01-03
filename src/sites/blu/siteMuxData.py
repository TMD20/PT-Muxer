import os
import traceback
from typing import Union


from pymediainfo import MediaInfo

from src.sites.base.siteMuxData import MuxOBj
import src.mediatools.mkvtoolnix as mkvTool
import src.tools.logger as logger
import config as config
import src.tools.directory as dir
import src.tools.paths as paths


class Blu(MuxOBj):
    """
    This class is for generating remuxes
    for blutopia

    Args:
        MuxOBj (class): This is the base class for all remux classes
    """
    def __init__(self)->None:
        super().__init__()

    def createMKV(self, fileName:Union[str, bytes, os.PathLike], movieTitle:str, chapters:Union[str, bytes, os.PathLike], xml:Union[str, bytes, os.PathLike],  bdinfo:Union[str, bytes, os.PathLike], eac3to:Union[str, bytes, os.PathLike])->None:
        """
        Generates a MKV using mkvmerge in subprocess
        Additionally runs vdator to validate remux

        Args:
            fileName (str): file name to pass to mkvmerge
            movieTitle (str): movietitle to pass to mkvmerge
            chapters (str): path to chapters file to pass to mkvmerge
            xml (str): path to xml file to pass to mkvmerge
            bdinfo (str):path to bdinfo file passed to vdator
            eac3to (str): path to eac3t0 file passed to vdator
        """
        super().createMKV(fileName, movieTitle, chapters, xml)
        with dir.cwd(paths.createTempDir()):
            mediainfo = MediaInfo.parse(fileName, output="", full=False)
            mediainfoPath = "media.txt"

            with open(mediainfoPath, "w") as p:
                p.write(mediainfo)
            try:
                self.validation(mediainfoPath, eac3to, bdinfo)
            except Exception as E:
                logger.logger.debug(traceback.format_exc())
                logger.logger.debug(str(E))
                logger.print("Vdator Failed")

    def getFileName(self,
                    remuxConfig:dict, group:str, title, episodeTitle:Union[str,None]=None)->str:
        """
        Generates a filename based on blutopia naming rules and demux data

        Args:
            remuxConfig (dict):dictionary generated my PTMuxer
            group (str): group remux is being generated for
            title (str): Movie title
            episodeTitle (str, optional):Episode title. Defaults to None.

        Returns:
            str: Blutopia filename for remux
        """
        episodeTitle = episodeTitle or self._placeholder
        videoCodec = mkvTool.getVideo(
            remuxConfig["Enabled_Tracks"]["Video"], remuxConfig["Tracks_Details"]["Video"])
        mediaType = mkvTool.getMediaType(
            remuxConfig["Enabled_Tracks"]["Video"], remuxConfig["Tracks_Details"]["Video"])
        videoRes = mkvTool.getVideoResolution(
            remuxConfig["Enabled_Tracks"]["Video"], remuxConfig["Tracks_Details"]["Video"])

        audioCodec = mkvTool.getAudio(
            remuxConfig["Enabled_Tracks"]["Audio"], remuxConfig["Tracks_Details"]["Audio"])
        audioChannel = mkvTool.getAudioChannel(
            remuxConfig["Enabled_Tracks"]["Audio"], remuxConfig["Tracks_Details"]["Audio"])
        year = remuxConfig['Movie']['year']
        season = remuxConfig["Movie"].get("season")
        episode = remuxConfig["Movie"].get("episode")
        movieName = f"{title} {year}"

        if season and episode:
            fileName = f"{movieName}.S{season:02d}.E{episode:02d}.{videoRes}.{mediaType}.REMUX.{videoCodec}.{audioCodec}.{audioChannel}-{group}.mkv"
            return self._fileNameCleaner(fileName)

        else:
            fileName = f"{movieName}.{episodeTitle}.{videoRes}.{mediaType}.REMUX.{videoCodec}.{audioCodec}.{audioChannel}-{group}.mkv"
            return self._fileNameCleaner(fileName)

    def getTVDir(self, remuxConfig:dict, group:str, title:str)->str:
        """
        Generates a folder name for TV remux based on blutopia naming rules and demux Data

        Args:
            remuxConfig (dict):dictionary generated my PTMuxer
            group (str): group remux is being generated for
            title (str):Movie title

        Returns:
            str: folder name based on blutopia rules
        """
        videoCodec = mkvTool.getVideo(
            remuxConfig["Enabled_Tracks"]["Video"], remuxConfig["Tracks_Details"]["Video"])
        mediaType = mkvTool.getMediaType(
            remuxConfig["Enabled_Tracks"]["Video"], remuxConfig["Tracks_Details"]["Video"])
        videoRes = mkvTool.getVideoResolution(
            remuxConfig["Enabled_Tracks"]["Video"], remuxConfig["Tracks_Details"]["Video"])

        audioCodec = mkvTool.getAudio(
            remuxConfig["Enabled_Tracks"]["Audio"], remuxConfig["Tracks_Details"]["Audio"])
        audioChannel = mkvTool.getAudioChannel(
            remuxConfig["Enabled_Tracks"]["Audio"], remuxConfig["Tracks_Details"]["Audio"])
        year = remuxConfig['Movie']['year']
        season = remuxConfig["Movie"]["season"]
        movieName = f"{title} {year}"
        dirName = f"{movieName}.S{season:02d}.{videoRes}.{mediaType}.REMUX.{videoCodec}.{audioCodec}.{audioChannel}-{group}"
        # Normalize
        return self._fileNameCleaner(dirName)

    def validation(self, mediainfo:Union[str, bytes, os.PathLike], eac3to:Union[str, bytes, os.PathLike]=None, bdinfo:Union[str, bytes, os.PathLike]=None)->None:
        """
        This function runs vdator on remux after


        Args:
            mediainfo (str): path to mediainfo 
            eac3to (str): path to eac3to
            bdinfo (str): path to bdinfo
        """
        # Validation Specific
        import json
        import sys

        import src.args as args

        os.environ["IGNORE_AFTER_LINE"] = "%%%"
        os.environ["IGNORE_AFTER_LINE_METHOD"] = "contains"
        os.environ["IGNORE_UNTIL_BLANK_LINE_PREFIXES"] = ""
        os.environ["DVD_CHECK_MODE"] = "nobdinfo"
        os.environ["FILENAME_CUTS"] = "Directors.Cut, Extended.Cut, Final.Cut, Theatrical, Uncut, Unrated"
        os.environ["RELEASE_GROUP"] = args.setParser().group or ""
        os.environ["TRAINEE_CHANNELS"] = "upload-review"
        os.environ["INTERNAL_CHANNELS"] = "remux"
        os.environ["HUNSPELL_LANG"] = "/usr/share/hunspell/en_US.dic, /usr/share/hunspell/en_US.aff"
        os.environ["MISSPELLED_IGNORE_LIST"] = "upmix"
        sys.path.append(os.path.join(config.root_dir, "src/vdator"))

        import src.vdator.parsers.codecs_parser as CodecsParser
        import src.vdator.checker as Checker
        import src.vdator.reporter as Reporter
        import src.vdator.source_detector as SourceDetector
        import src.vdator.parsers.codecs_parser as CodecsParser
        import src.vdator.parsers.bdinfo_parser as BDInfoParser
        import src.vdator.parsers.paste_parser as PasteParser
        import src.vdator.parsers.media_info_parser as MediaInfoParser

        with open(os.path.join(config.root_dir, "src/vdator/data/codecs.json")) as f:
            codecs = json.load(f)
            codecs_parser = CodecsParser.CodecsParser(codecs)
        paste = ""
        with open(bdinfo, "r") as p:
            paste = paste+p.read()
        with open(mediainfo, "r") as p:
            paste = paste+p.read()
        with open(eac3to, "r") as p:
            paste = paste+p.read()

        with dir.cwd(paths.createTempDir()):
            with open("temp.txt", "w") as p:
                p.write(paste)
            paste_parser = PasteParser.PasteParser(BDInfoParser.BDInfoParser())
            (bdinfoData, mediainfoData, eac3to) = paste_parser.parse(paste)
            mediainfoData = MediaInfoParser.MediaInfoParser().parse(mediainfoData)
            source_detector = SourceDetector.SourceDetector()
            reporter = Reporter.Reporter()
            checker = Checker.Checker(codecs_parser, source_detector, reporter)
            checker.setup(bdinfoData, mediainfoData, eac3to, "")
            reply = checker.run_checks()
            reply += reporter.display_report()
            print(reply)
