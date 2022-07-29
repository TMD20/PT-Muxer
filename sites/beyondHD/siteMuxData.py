import os
import re

from InquirerPy import inquirer

from sites.base.siteMuxData import MuxOBj
import mediatools.mkvtoolnix as mkvTool
import mediadata.movieData as movieData
import tools.general as utils


class BeyondHD(MuxOBj):
    def __init__(self):
        super().__init__()
    # Overwrite Filename

    def getFileName(self, kind, remuxConfig, movie, group):
        hdr = mkvTool.getHDR(
            remuxConfig["Enabled_Tracks"]["Video"], remuxConfig["Tracks_Details"]["Video"])
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

        movieName = movieData.getMovieName(movie)
        movieYear = movieData.getMovieYear(movie)

        season = remuxConfig.get("Season")
        episode = remuxConfig.get("Episode")

        if kind == "movie":
            fileName = f"{movieName}.{movieYear}.{mediaType}.{videoRes}.{audioCodec}.{audioChannel}.{videoCodec}.{hdr}.REMUX-{group}.mkv"
        else:
            fileName = f"{movieName}.{movieYear}.S{season//10}{season&10}.E0{episode}.{videoRes}.{mediaType}.REMUX.{videoCodec}.{audioCodec}.{audioChannel}-{group}.mkv"

        # normalize
        fileName = re.sub(" +", " ", fileName)
        fileName = re.sub(" ", ".", fileName)
        fileName = re.sub("\.+", ".", fileName)
        fileName = re.sub("[@_!#$%^&*()<>?/\|}{~:]", "", fileName)

        inputs = ["YES", "NO"]
        choice = utils.singleSelectMenu(
            inputs, f"Is this FileName Correct: {fileName}\n")

        while choice != "YES":
            message = "Enter New FileName: "
            utils.textEnter(message, fileName)
            choice = utils.singleSelectMenu(
                inputs, "Is the File Correct Now\n")
        return os.path.abspath(os.path.join(".", fileName))
