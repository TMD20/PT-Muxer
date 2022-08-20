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
            fileName = self._fileNameCleaner(fileName)
            fileName = os.path.abspath(os.path.join(".", fileName))
        else:
            fileName = f"{movieName}.S{season//10}{season%10}E{episode//10}{episode%10}.{episodeTitle}.{videoRes}.{mediaType}.REMUX.{videoCodec}.{audioCodec}.{audioChannel}-{group}.mkv"
            fileName = self._fileNameCleaner(fileName)
            fileName = os.path.abspath(os.path.join(".", self._getTVDir(remuxConfig, group, title, year, season), fileName))

        # Normalize FileName
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
