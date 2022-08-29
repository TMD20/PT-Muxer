import itertools
import re
import os
import subprocess

import langcodes

import tools.general as utils
import mediatools.mkvtoolnix as mkvTool
import tools.commands as commands


class MuxOBj():
    def __init__(self):
        self._audio = []
        self._video = []
        self._sub = []
        self._out = None
        self._outputargs = []

    def generateMuxData(self, remuxConfig, outargs):
        self._addAudioTracks(remuxConfig)
        self._addVideoTracks(remuxConfig)
        self._addSubTracks(remuxConfig)
        self._addOutPutArgs(outargs)
        self._out = list(itertools.chain.from_iterable(
            [self._video, self._audio, self._sub, self._outputargs]))

    @property
    def out(self):
        return self._out

    def _addVideoTracks(self, remuxConfig):
        out = []
        langcode = None
        try:
            langcodeKey = str(remuxConfig["Enabled_Tracks"]["Audio"][0])
            langcode = remuxConfig["Tracks_Details"]["Audio"][langcodeKey]["langcode"]
        except:
            langcode = langcodes.standardize_tag(
                langcodes.find(remuxConfig["Movie"]["languages"][0]))
        for i in range(len(remuxConfig["Enabled_Tracks"]["Video"])):
            key = remuxConfig["Enabled_Tracks"]["Video"][i]
            key = str(key)
            trackjson = remuxConfig["Tracks_Details"]["Video"][key]
            name = trackjson["site_title"]
            file = trackjson["file"]

            temp = ["--language", f"0:{langcode}", "--compression", f"0:None"]
            if name:
                temp.extend(["--track-name", f"0:{name}"])

            default = ["--default-track-flag", "0:0"]
            if trackjson.get("default") == True:
                default = ["--default-track-flag", "0:1"]
            temp.extend(default)
            temp.append(file)
            out.append(temp)
        self._video = list(itertools.chain.from_iterable(out))

    def _addAudioTracks(self, remuxConfig):
        out = []
        for i in range(len(remuxConfig["Enabled_Tracks"]["Audio"])):
            key = remuxConfig["Enabled_Tracks"]["Audio"][i]
            key = str(key)
            trackjson = remuxConfig["Tracks_Details"]["Audio"][key]
            langcode = trackjson["langcode"]
            name = trackjson["site_title"]
            file = trackjson["file"]
            temp = ["--language", f"0:{langcode}", "--compression", f"0:None"]
            if name:
                temp.extend(["--track-name", f"0:{name}"])

         # additional flags
            default = ["--default-track-flag", "0:0"]
            forced = ["--forced-display-flag", "0:0"]
            auditorydesc = ["--visual-impaired-flag", "0:0"]
            commentary = ["--commentary-flag", "0:0"]
            # reset flag values as needed

            if trackjson.get("default") == True:
                default = ["--default-track-flag", "0:1"]
            if trackjson.get("forced") == True:
                forced = ["--forced-display-flag", "0:1"]
            if trackjson.get("commentary") == True \
                    or re.search("commentary", name or "", re.IGNORECASE):
                commentary = ["--commentary-flag", "0:1"]
            if trackjson.get("auditorydesc") == True:
                auditorydesc = ["--visual-impaired-flag", "0:1"]
            temp.extend(default)
            temp.extend(forced)
            temp.extend(auditorydesc)
            temp.extend(commentary)
            temp.append(file)
            out.append(temp)
        self._audio = list(itertools.chain.from_iterable(out))

    def _addSubTracks(self, remuxConfig):
        out = []
        for i in range(len(remuxConfig["Enabled_Tracks"]["Sub"])):
            key = remuxConfig["Enabled_Tracks"]["Sub"][i]
            key = str(key)

            # get base data
            trackjson = remuxConfig["Tracks_Details"]["Sub"][key]
            langcode = trackjson["langcode"]
            file = trackjson["file"]
            name = trackjson.get("site_title")
            temp = ["--language", f"0:{langcode}", "--compression", f"0:None"]
            if name:
                temp.extend(["--track-name", f"0:{name}"])
            # additional flags
            default = ["--default-track-flag", "0:0"]
            forced = ["--forced-display-flag", "0:0"]
            sdh = ["--hearing-impaired-flag", "0:0"]
            commentary = ["--commentary-flag", "0:0"]
            textdesc = ["--text-descriptions-flag", "0:0"]
            # flags values if needed
            if trackjson.get("default") == True:
                default = ["--default-track-flag", "0:1"]
            if trackjson.get("forced") == True:
                forced = ["--forced-display-flag", "0:1"]
            if trackjson.get("commentary") == True \
                    or re.search("commentary", name or "", re.IGNORECASE):
                commentary = ["--commentary-flag", "0:1"]
            if trackjson.get("sdh") == True \
                    or re.search("sdh", name or "", re.IGNORECASE):
                sdh = ["--hearing-impaired-flag", "0:1"]
            if trackjson.get("textdesc") == True \
                    or re.search("sdh", name or "", re.IGNORECASE):
                textdesc = ["--text-descriptions-flag", "0:1"]
            temp.extend(default)
            temp.extend(forced)
            temp.extend(sdh)
            temp.extend(commentary)
            temp.extend(textdesc)
            temp.append(file)
            out.append(temp)
        self._sub = (list(itertools.chain.from_iterable(out)))

    def getFileName(self,
                    remuxConfig, group, title, year, skipNameCheck, season=None, episode=None, episodeTitle=None, directory=None):
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

        if episodeTitle and season and episode:
            fileName = f"{movieName}.S{season//10}{season%10}E{episode//10}{episode%10}.{episodeTitle}.{videoRes}.{mediaType}.REMUX.{videoCodec}.{audioCodec}.{audioChannel}-{group}.mkv"
            fileName = self._fileNameCleaner(fileName)

            fileName = os.path.abspath(os.path.join(".", directory or self._getTVDir(
                remuxConfig, group, title, year, season), fileName))
        elif episodeTitle:
            fileName = f"{movieName}.{episodeTitle}.{videoRes}.{mediaType}.REMUX.{videoCodec}.{audioCodec}.{audioChannel}-{group}.mkv"
            fileName = self._fileNameCleaner(fileName)
            fileName = os.path.abspath(os.path.join(".", directory or self._getTVDir(
                remuxConfig, group, title, year, season), fileName))
        else:
            fileName = f"{movieName}.{videoRes}.{mediaType}.REMUX.{videoCodec}.{audioCodec}.{audioChannel}-{group}.mkv"
            fileName = self._fileNameCleaner(fileName)
            fileName = os.path.abspath(os.path.join(
                ".", directory or self._getMovieDir(remuxConfig, group, title, year), fileName))

        return self._confirmName(fileName, skipNameCheck)

    def _fileNameCleaner(self, fileName):
        fileName = re.sub(" +", " ", fileName)
        fileName = re.sub(" ", ".", fileName)
        fileName = re.sub("\.+", ".", fileName)
        fileName = re.sub("[@_!#$%^&*()<>?/\|}{~:]", "", fileName)
        fileName = re.sub("([^a-zA-Z\d])\.", ".", fileName)
        fileName = re.sub("\.([^a-zA-Z\d])", ".", fileName)
        Noquotes=re.search('^"(.*)"$',fileName)
        if Noquotes:
            fileName=Noquotes.group(0)
        return fileName

    def _addOutPutArgs(self, outargs):
        self._outputargs = outargs.split()

    def createMKV(self, fileName, movieTitle, chapters, xml,  bdinfo, eac3to):

        command = list(itertools.chain.from_iterable(
            [commands.mkvmerge(), ["--title", movieTitle, "--chapters", chapters, "--output", fileName, "--global-tags", xml], self._out]))
        if chapters == None:
            command = list(itertools.chain.from_iterable(
                [commands.mkvmerge(), ["--title", movieTitle, "--output", fileName, "--global-tags", xml], self._out]))
        commandStr = " ".join(command)
        print(f"Running This Command\n{commandStr}")
        with subprocess.Popen(command, universal_newlines=True, stdout=subprocess.PIPE, bufsize=1) as p:
            for line in p.stdout:
                print(line, end='')

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

        fileName = f"{movieName}.S{season//10}{season%10}.{videoRes}.{mediaType}.REMUX.{videoCodec}.{audioCodec}.{audioChannel}-{group}"
        # Normalize FileName
        return self._fileNameCleaner(fileName)

    def _getMovieDir(self, remuxConfig, group, title, year):
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

        fileName = f"{movieName}.{videoRes}.{mediaType}.REMUX.{videoCodec}.{audioCodec}.{audioChannel}-{group}"
        # Normalize FileName
        return self._fileNameCleaner(fileName)

    def _confirmName(self, fileName, skipNameCheck):
        if not skipNameCheck:
            inputs = ["YES", "NO"]
            choice = utils.singleSelectMenu(
                inputs, f"Is this FilePath Correct: {fileName}\n")
            while choice != "YES":
                message = "Enter New FilePath: "
                fileName = utils.textEnter(message, fileName)
                choice = utils.singleSelectMenu(
                    inputs, "Is the File Correct Now\n")
        return fileName
