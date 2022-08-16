import re
import os


import tools.general as utils
from sites.base.siteMuxData import MuxOBj
import mediatools.mkvtoolnix as mkvTool
import mediadata.movieData as movieData


class AnimeBytes(MuxOBj):
    def __init__(self):
        super().__init__()

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
        else:
            fileName = f"{movieName}.S{season//10}{season%10}E{episode//10}{episode%10}.{episodeTitle}.{videoRes}.{mediaType}.REMUX.{videoCodec}.{audioCodec}.{audioChannel}-{group}.mkv"
        # Normalize FileName
        fileName = self._fileNameCleaner(fileName)

        if not skipNameCheck:
            inputs = ["YES", "NO"]
            choice = utils.singleSelectMenu(
                inputs, f"Is this FileName Correct: {fileName}\n")
            while choice != "YES":
                message = "Enter New FileName: "
                fileName = utils.textEnter(message, fileName)
                choice = utils.singleSelectMenu(
                    inputs, "Is the File Correct Now\n")
        return os.path.abspath(os.path.join(".", fileName))
