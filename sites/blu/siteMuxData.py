import os
import subprocess
import tempfile

from pymediainfo import MediaInfo

from sites.base.siteMuxData import MuxOBj
import tools.general as utils
import mediatools.mkvtoolnix as mkvTool


class Blu(MuxOBj):
    def __init__(self):
        super().__init__()

    def createMKV(self, fileName, movieTitle, chapters, xml,  bdinfo, eac3to):
        super().createMKV(fileName, movieTitle, chapters, xml,  bdinfo, eac3to)
        tempdir = tempfile.TemporaryDirectory()
        mediainfoPath = os.path.join(tempdir.name, "media.txt")
        mediainfo = MediaInfo.parse(fileName, output="", full=False)

        with open(mediainfoPath, "w") as p:
            p.write(mediainfo)
        print("\n\nRunning Blutopia Validator\n\n")
        command = ["/usr/local/bin/mine/remux/bin/python3", os.path.join(utils.getRootDir(), "vdator/vdator/main.py"),
                   mediainfoPath, bdinfo, eac3to]

        with subprocess.Popen(command, stdout=subprocess.PIPE, stderr=subprocess.PIPE, universal_newlines=True, bufsize=1) as p:
            for line in p.stdout:
                print(line, end='')
            for line in p.stderr:
                print(line, end='')

    def getFileName(self, remuxConfig, group, title, year, skipNameCheck, season=None, episode=None, episodeTitle=None):
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
        movieName = f"{title} {year}"

        if not season and not episode and not episodeTitle:
            fileName = f"{movieName}.{videoRes}.{mediaType}.REMUX.{videoCodec}.{audioCodec}.{audioChannel}-{group}.mkv"
            fileName = self._fileNameCleaner(fileName)
            fileName = os.path.abspath(os.path.join(".", fileName))

        else:
            fileName = f"{movieName}.S{season:02d}.E{episode:02d}.{videoRes}.{mediaType}.REMUX.{videoCodec}.{audioCodec}.{audioChannel}-{group}.mkv"
            # Normalize
            fileName = self._fileNameCleaner(fileName)
            fileName = os.path.abspath(os.path.join(".", self._getTVDir(remuxConfig, group, title, year, season), fileName))
        return self._confirmName(fileName,skipNameCheck)

 
    def _getTVDir(self, remuxConfig, group, title, year, season):
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
        movieName = f"{title} {year}"
        dirName = f"{movieName}.S{season:02d}.{videoRes}.{mediaType}.REMUX.{videoCodec}.{audioCodec}.{audioChannel}-{group}"
        # Normalize
        return self._fileNameCleaner(dirName)
