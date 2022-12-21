import os
import subprocess
import tempfile
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
                logger.print("\n\nRunning Blutopia Validator\n\n")
                command = [config.pythonPath, os.path.join(config.root_dir, "vdator/vdator/main.py"),
                           mediainfoPath, bdinfo, eac3to]

                with subprocess.Popen(command, stdout=subprocess.PIPE, stderr=subprocess.STDOUT, universal_newlines=True, bufsize=1) as p:
                    for line in p.stdout:
                        print(line, end='')
                    for line in p.stderr:
                        print(line, end='')
            except Exception as E:
                logger.logger.debug(traceback.format_exc())
                logger.logger.debug(str(E))

                logger.print("Ignoring Vdator Error")

    def getFileName(self,
                    remuxConfig, group, title, episodeTitle=None):
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
