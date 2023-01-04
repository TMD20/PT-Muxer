from typing import  List, Union
import os

from src.sites.base.siteMuxData import MuxOBj



class BeyondHD(MuxOBj):
    """
    This class is for generating remuxes
    for beyondhd

    Args:
        MuxOBj (class): This is the base class for all remux classes
    """

    def __init__(self) -> None:
        super().__init__()

    def getFileName(self, remuxConfig: List[dict], group: str, title: Union[str, bytes, os.PathLike], episodeTitle: Union[Union[str, bytes, os.PathLike], None] = None) -> str:
        episodeTitle = episodeTitle or self._placeholder
        videoCodec = self._getVideo(
            remuxConfig["Enabled_Tracks"]["Video"], remuxConfig["Tracks_Details"]["Video"])
        mediaType = self._getMediaType(
            remuxConfig["Enabled_Tracks"]["Video"], remuxConfig["Tracks_Details"]["Video"])
        videoRes = self._getVideoResolution(
            remuxConfig["Enabled_Tracks"]["Video"], remuxConfig["Tracks_Details"]["Video"])

        audioCodec = self._getAudio(
            remuxConfig["Enabled_Tracks"]["Audio"], remuxConfig["Tracks_Details"]["Audio"])
        audioChannel = self._getAudioChannel(
            remuxConfig["Enabled_Tracks"]["Audio"], remuxConfig["Tracks_Details"]["Audio"])
        year = remuxConfig['Movie']['year']
        season = remuxConfig["Movie"].get("season")
        episode = remuxConfig["Movie"].get("episode")

        movieName = f"{title} {year}"
        if season and episode:
            fileName = f"{movieName}.S{season//10}{season%10}E{episode//10}{episode%10}.{episodeTitle}.{videoRes}.{mediaType}.REMUX.{videoCodec}.{audioCodec}.{audioChannel}-{group}.mkv"
            return os.path.join(self._getTVDir(remuxConfig,group,title),self._fileNameCleaner(fileName))

        else:
            fileName = f"{movieName}.{videoRes}.{mediaType}.REMUX.{videoCodec}.{audioCodec}.{audioChannel}-{group}.mkv"
            return self._fileNameCleaner(fileName)

    def _getTVDir(self, remuxConfig: List[dict], group: str, title: str) -> str:
        videoCodec = self._getVideo(
            remuxConfig["Enabled_Tracks"]["Video"], remuxConfig["Tracks_Details"]["Video"])
        mediaType = self._getMediaType(
            remuxConfig["Enabled_Tracks"]["Video"], remuxConfig["Tracks_Details"]["Video"])
        videoRes = self._getVideoResolution(
            remuxConfig["Enabled_Tracks"]["Video"], remuxConfig["Tracks_Details"]["Video"])

        audioCodec = self._getAudio(
            remuxConfig["Enabled_Tracks"]["Audio"], remuxConfig["Tracks_Details"]["Audio"])
        audioChannel = self._getAudioChannel(
            remuxConfig["Enabled_Tracks"]["Audio"], remuxConfig["Tracks_Details"]["Audio"])
        year = remuxConfig['Movie']['year']
        season = remuxConfig["Movie"]["season"]

        movieName = f"{title} {year}"
        dirName = f"{movieName}.S{season:02d}.{videoRes}.{mediaType}.REMUX.{videoCodec}.{audioCodec}.{audioChannel}-{group}"
        # Normalize
        return self._fileNameCleaner(dirName)
