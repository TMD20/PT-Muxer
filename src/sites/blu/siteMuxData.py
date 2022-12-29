import os
import traceback

from pymediainfo import MediaInfo

from sites.base.siteMuxData import MuxOBj
import tools.general as utils
import mediatools.mkvtoolnix as mkvTool
import tools.logger as logger
import config
import tools.directory as dir
import tools.paths as paths







class Blu(MuxOBj):
    def __init__(self):
        super().__init__()

    def createMKV(self, fileName, movieTitle, chapters, xml,  bdinfo, eac3to):
        super().createMKV(fileName, movieTitle, chapters, xml,  bdinfo, eac3to)
        with dir.cwd(paths.createTempDir()):
            mediainfo = MediaInfo.parse(fileName, output="", full=False)
            mediainfoPath = "media.txt"

            with open(mediainfoPath, "w") as p:
                p.write(mediainfo)
            try:
                self.validation(mediainfoPath,eac3to,bdinfo)
            except Exception as E:
                logger.logger.debug(traceback.format_exc())
                logger.logger.debug(str(E))
                logger.print("Vdator Failed")

            
    def getFileName(self,
                    remuxConfig, group, title, episodeTitle=None):
        episodeTitle=episodeTitle or self._placeholder
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
            

    def getTVDir(self, remuxConfig, group, title):
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

    def validation(self, mediainfo, eac3to, bdinfo):
        # Validation Specific
        import json
        import sys

        import args as args
     
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
        sys.path.append(os.path.join(config.root_dir, "vdator"))

        import vdator.parsers.codecs_parser as CodecsParser
        import vdator.checker as Checker
        import vdator.reporter as Reporter
        import vdator.source_detector as SourceDetector
        import vdator.parsers.codecs_parser as CodecsParser
        import vdator.parsers.bdinfo_parser as BDInfoParser
        import vdator.parsers.paste_parser as PasteParser
        import vdator.parsers.media_info_parser as MediaInfoParser


    
        with open(os.path.join(config.root_dir, "vdator/data/codecs.json")) as f:
            codecs = json.load(f)
            codecs_parser = CodecsParser.CodecsParser(codecs)
        paste=""
        with open(bdinfo, "r") as p:
                paste=paste+p.read()
        with open(mediainfo, "r") as p:
                paste=paste+p.read()
        with open(eac3to, "r") as p:
                paste=paste+p.read()

        with dir.cwd(paths.createTempDir()):
            with open("temp.txt", "w") as p:
                p.write(paste)
            paste_parser=  PasteParser.PasteParser(BDInfoParser.BDInfoParser())
            (bdinfoData, mediainfoData, eac3to) = paste_parser.parse(paste)
            mediainfoData = MediaInfoParser.MediaInfoParser().parse(mediainfoData)
            source_detector = SourceDetector.SourceDetector()
            reporter = Reporter.Reporter()
            checker = Checker.Checker(codecs_parser, source_detector, reporter)
            checker.setup(bdinfoData, mediainfoData, eac3to, "")
            reply = checker.run_checks()
            reply += reporter.display_report()
            print(reply)
