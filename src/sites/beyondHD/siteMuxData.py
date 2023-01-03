from __future__ import annotations
from typing import TYPE_CHECKING, List, Union

from src.sites.base.siteMuxData import MuxOBj
if TYPE_CHECKING:
    import os


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
        videoCodec = self.getVideo(
            remuxConfig["Enabled_Tracks"]["Video"], remuxConfig["Tracks_Details"]["Video"])
        mediaType = self.getMediaType(
            remuxConfig["Enabled_Tracks"]["Video"], remuxConfig["Tracks_Details"]["Video"])
        videoRes = self.getVideoResolution(
            remuxConfig["Enabled_Tracks"]["Video"], remuxConfig["Tracks_Details"]["Video"])

        audioCodec = self.getAudio(
            remuxConfig["Enabled_Tracks"]["Audio"], remuxConfig["Tracks_Details"]["Audio"])
        audioChannel = self.getAudioChannel(
            remuxConfig["Enabled_Tracks"]["Audio"], remuxConfig["Tracks_Details"]["Audio"])
        year = self._remuxConfig['Movie']['year']
        season = self._remuxConfig["Movie"]["season"]
        episode = self._remuxConfig["Movie"]["episode"]

        movieName = f"{title} {year}"
        if season and episode:
            fileName = f"{movieName}.S{season//10}{season%10}E{episode//10}{episode%10}.{episodeTitle}.{videoRes}.{mediaType}.REMUX.{videoCodec}.{audioCodec}.{audioChannel}-{group}.mkv"
            return self._fileNameCleaner(fileName)

        else:
            fileName = f"{movieName}.{episodeTitle}.{videoRes}.{mediaType}.REMUX.{videoCodec}.{audioCodec}.{audioChannel}-{group}.mkv"
            return self._fileNameCleaner(fileName)

    def getTVDir(self, remuxConfig: List[dict], group: str, title: str) -> str:
        videoCodec = self.getVideo(
            remuxConfig["Enabled_Tracks"]["Video"], remuxConfig["Tracks_Details"]["Video"])
        mediaType = self.getMediaType(
            remuxConfig["Enabled_Tracks"]["Video"], remuxConfig["Tracks_Details"]["Video"])
        videoRes = self.getVideoResolution(
            remuxConfig["Enabled_Tracks"]["Video"], remuxConfig["Tracks_Details"]["Video"])

        audioCodec = self.getAudio(
            remuxConfig["Enabled_Tracks"]["Audio"], remuxConfig["Tracks_Details"]["Audio"])
        audioChannel = self.getAudioChannel(
            remuxConfig["Enabled_Tracks"]["Audio"], remuxConfig["Tracks_Details"]["Audio"])
        year = remuxConfig['Movie']['year']
        season = remuxConfig["Movie"]["season"]

        movieName = f"{title} {year}"
        dirName = f"{movieName}.S{season:02d}.{videoRes}.{mediaType}.REMUX.{videoCodec}.{audioCodec}.{audioChannel}-{group}"
        # Normalize
        return self._fileNameCleaner(dirName)
