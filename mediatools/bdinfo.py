import subprocess
import re
import os
import tempfile
import datetime as dt
import itertools

import tools.general as utils
import tools.commands as commands


class Bdinfo():
    def __init__(self):
        self._playlistNum = 0
        self._playlistNumList = []
        self._playlistFileList = []
        self._streams = []
        self._chapters = []
        self._mediaDir = None

    '''
    Public Functions
    '''

    def setup(self, subfolder):
        self._mediaDir = re.sub("/BDMV/STREAM", "", subfolder)
        self._generate_playlists()


    def runbdinfo(self, playlistNum=None):
        playlistNum = playlistNum or self._playlistNum
        selection = self._playlist.splitlines()[2+int(playlistNum)]
        match = re.search("[0-9]+.MPLS", selection)
        if match != None:
            selection = selection[match.start():match.end()]
            temp = tempfile.TemporaryDirectory()
            command = list(itertools.chain.from_iterable(
                [commands.bdinfo(), ["-m", selection, self._mediaDir, temp.name]]))
            subprocess.run(command)
            file = open(utils.convertPathType(os.path.join(
                temp.name, os.listdir(temp.name)[0]), "Linux"), "r")
            self._bdinfo = file.read()
            file.close()

    def getQuickSum(self):
        lines = self._bdinfo.splitlines()
        lines = lines[lines.index("QUICK SUMMARY:"):len(lines)-1]
        for i in range(len(lines)):
            if re.search("Video: ", lines[i]) != None:
                lines = lines[i:len(lines)]
                break
        return lines

    def getStreams(self):
        lines = self._bdinfo.splitlines()
        lines = lines[lines.index("FILES:"):len(lines)-1]
        start = 0
        end = lines.index("CHAPTERS:")-1
        for i in range(len(lines)):
            if re.search("Name", lines[i]) != None:
                start = i+2
                break
        time_zero = dt.datetime.strptime('00:00:00.0', '%H:%M:%S.%f')

        for line in lines[start:end]:
            data = line.split()

            startTime = data[1]
            length = data[2]
            name = data[0]

            t1 = dt.datetime.strptime(startTime, '%H:%M:%S.%f')
            t2 = dt.datetime.strptime(length, '%H:%M:%S.%f')
            endTime = str((t1 - time_zero + t2).time())[:-3]

            startTime = '{:0>2}:{:0<2}:{:0<2}.{:0<3}'.format(
                *startTime.split(":")[:2], *startTime.split(":")[2].split("."))

            self._streams.append(
                {"name": name, "start": startTime, "end": endTime})
        return self._streams

    def getChapters(self):
        out = []
        lines = self._bdinfo.splitlines()
        lines = lines[lines.index("CHAPTERS:"):len(lines)-1]
        start = 0
        end = lines.index("STREAM DIAGNOSTICS:")-1
        for i in range(len(lines)):
            if re.search("Number ", lines[i]) != None:
                start = i+2
                break
        time_zero = dt.datetime.strptime('00:00:00.0', '%H:%M:%S.%f')
        for line in lines[start:end]:
            data = line.split()

            startTime = data[1]
            length = data[2]
            number = data[0]

            t1 = dt.datetime.strptime(startTime, '%H:%M:%S.%f')
            t2 = dt.datetime.strptime(length, '%H:%M:%S.%f')
            endTime = str((t1 - time_zero + t2).time())[:-3]

            startTime = '{:0>2}:{:0<2}:{:0<2}.{:0<3}'.format(
                *startTime.split(":")[:2], *startTime.split(":")[2].split("."))

            out.append(
                {"number": number, "start": startTime, "end": endTime})
        self._chapters = out
        return self._chapters

    def writeBdinfo(self, path):
        utils.mkdirSafe(path)
        file = open(path, "w")
        file.write(self._bdinfo)

    def playListSelect(self):
        num = self._getIndex()
        self._playlistNum = num
        self._getplaylistFile(num)

    def playListRangeSelect(self):
        self._playlistFileList = []
        self._getRange()
        for num in self._playlistNumList:
            self._getplaylistFile(num)
            self._playlistFileList.append(self._playlistFile)

    '''
    Getter Functions
    '''

    """
    playlistNum of Playlist picked by User
    """
    @property
    def playlistNum(self):
        return self._playlistNum

    """
    list of playlists picked by User
    """
    @property
    def playlistNumList(self):
        return self._playlistNumList

    """
    Working Directory with Current BDMV Files
    """
    @property
    def mediaDir(self):
        return self._mediaDir
    """
    Path to the Full bdinfo Path
    """

    @property
    def bdinfoPath(self):
        return self._bdinfoPath

    """
    playlist file name
    """
    @property
    def playlistFile(self):
        return self._playlistFile

    """
    List of playlist file names
    """
    @property
    def playlistFileList(self):
        return self._playlistFileList

    """
    Chapters
    """
    @property
    def chapters(self):

        return self._chapters

    '''
    Setter Functions
    '''
    @mediaDir.setter
    def mediaDir(self, ele):
        self._mediaDir = re.sub("/BDMV/STREAM", "", ele)

    @playlistNum.setter
    def playlistNum(self, num):
        self._playlistNum = num

    '''
    Private Functions
    '''

    def _getIndex(self):
        selection = self._playlist.splitlines()[3:]
        playlistNum = utils.singleSelectMenu(selection, "Select Playlist: ")
        selection.index(playlistNum)

        return selection.index(playlistNum)+1

    def _getRange(self):
        message = \
        """
        Select PlayList

        Multiple sources must have the same number of playlist per run
        """
        selection = self._playlist.splitlines()[3:]
        playlistNumList = utils.multiSelectMenu(
            selection, message)

        self._playlistNumList = list(
            map(lambda x:  selection.index(x)+1, playlistNumList))

    def _getplaylistFile(self, num):
        playlistFiles = re.findall(
            "[0-9]+\.MPLS", self._playlist)
        if int(num)-1 > len(playlistFiles):
            print("Number is out of Range")
            quit()

        self._playlistFile = playlistFiles[int(num)-1]

    @utils.requiredClassAttribute("_mediaDir")
    def _generate_playlists(self):
        if utils.getSystem() == "Linux":
            command = list(itertools.chain.from_iterable([commands.bdinfo(), [
                "-l", self._mediaDir, "."]]))
        else:
            command = list(itertools.chain.from_iterable([commands.bdinfo(), [
                "-l", utils.convertPathType(self._mediaDir, "Linux"), "."]]))

        self._playlist = subprocess.run(
            command, stdout=subprocess.PIPE, stderr=subprocess.PIPE).stdout.decode('utf8', 'strict')
