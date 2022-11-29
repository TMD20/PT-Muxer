import subprocess
import re
import os
import datetime as dt
import itertools
import shutil

import tools.general as utils
import tools.commands as commands
import tools.paths as paths


class Bdinfo():
    def __init__(self):
        self._playlistDict={}
        self._playlistKeys=None
        self._mediaDir = None

    '''
    Public Functions
    '''

    def setup(self, subfolder):
        self._mediaDir = re.sub("/BDMV/STREAM", "", subfolder)
        self._generatePlaylistsNames()
    
    def validate(self,bdObjs):
        if len(bdObjs)!=len(list(filter(lambda x:x.keys==bdObjs[0].keys,bdObjs
        ))) :
                message = \
                    """
            One or more sources has the a incorrect amount of playlist
            Make sure every playlist is in sync
            """
                print(message)
                quit()        
    def generateData(self,i):
        key=self._playlistKeys[i]
        playlistNum = key
        print(f"Generating Data for {self._mediaDir}\nPlaylist:{playlistNum}\n")  
        self.setBdInfo(playlistNum)
        self.setQuickSum(playlistNum)
        self.setStreams(playlistNum)     
    def setBdInfo(self, playlistNum):
        selection = self._playlistDict[playlistNum]["playlistFile"]
       
        tempDir = paths.createTempDir()
        command = list(itertools.chain.from_iterable(
        [commands.bdinfo(), ["-m", selection, self._mediaDir, tempDir]]))
        subprocess.run(command)
        file = open(utils.convertPathType(os.path.join(
        tempDir, os.listdir(tempDir)[0]), "Linux"), "r")
        self._playlistDict[playlistNum]["bdinfo"] = file.read()
        shutil.rmtree(tempDir)
        file.close()

    def setQuickSum(self,playlistNum):
        lines = self._playlistDict[playlistNum]["bdinfo"].split("\n")
        output=[]
        for line in lines:
            if re.search("(Video|Audio|Subtitle): ", line,re.IGNORECASE) != None:
                output.append(line)
        self._playlistDict[playlistNum]["quickSum"] = output

    def setStreams(self,playlistNum):
        lines = self._playlistDict[playlistNum]["bdinfo"].splitlines()
        lines = lines[lines.index("FILES:"):len(lines)-1]
        start = 0
        end = lines.index("CHAPTERS:")-1

        for i in range(len(lines)):
            if re.search("Name", lines[i]) != None:
                start = i+2
                break
        time_zero = dt.datetime.strptime('00:00:00.0', '%H:%M:%S.%f')
        streams=[]
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

            streams.append(
                {"name": name, "start": startTime, "end": endTime})
        self._playlistDict[playlistNum]["playlistStreams"] = streams

    def setChapters(self,playlistNum):
        out = []
        lines = self._playlistDict[playlistNum]["bdinfo"].splitlines()
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
        self._playlistDict[playlistNum]["chapters"] = out

    def writeBdinfo(self, path):
        paths.mkdirSafe(path)
        file = open(path, "w")
        file.write(self._bdinfo)

    def playListSelect(self):
        self._playlistKeys = [self._getIndex()]
        self.playListFileHelper()
    

    def playListRangeSelect(self):
        self._playlistKeys=self._getRange()
        self.playListFileHelper()
    
       
    def playListFileHelper(self):
        for num in self._playlistKeys:
            self._playlistDict[num]={}
            self._playlistDict[num]["playlistFile"]=self._getplaylistFile(num)
    '''
    Getter Functions
    '''

    """
    Working Directory with Current BDMV Files
    """
    @property
    def mediaDir(self):
        return self._mediaDir

    """
    Keys For Playlist Dict
    Corresponds to Playlist Nums
    """
    @property
    def keys(self):
        return self._playlistKeys

    """
    playlistdict
    """
    @property
    def Dict(self):
        return self._playlistDict   
    #convert object dict into a list in order of user playlist selection
    @property
    def DictList(self):
        output=[]
        for key in self._playlistKeys:
            output.append(self._playlistDict[key])
        return output
    @property
    def playlistDir(self):
        return self._getPlaylistDir()

    '''
    Setter Functions
    '''
    @mediaDir.setter
    def mediaDir(self, ele):
        self._mediaDir = re.sub("/BDMV/STREAM", "", ele)
    



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

        return  list(
            map(lambda x:  selection.index(x)+1, playlistNumList))

    def _getplaylistFile(self, num):
        playlistNames = re.findall(
            "[0-9]+\.MPLS", self._playlist)
        if int(num)-1 > len(playlistNames):
            print("Number is out of Range")
            quit()
        #match bdinfo track name with what appears in file directory
        playListFiles=os.listdir(self._getPlaylistDir())
        playlistName=playlistNames[int(num)-1]
        return list(filter(lambda x:re.search(playlistName,x,re.IGNORECASE)!=None,playListFiles))[0]
    def _getPlaylistDir(self):
        return paths.search(self._mediaDir,"PLAYLIST",dir=True)[0]

    @utils.requiredClassAttribute("_mediaDir")
    def _generatePlaylistsNames(self):
        BDMV=paths.search(self._mediaDir,"BDMV",dir=True)[0]

        if utils.getSystem() == "Linux":
            command = list(itertools.chain.from_iterable([commands.bdinfo(), [
                "-l", BDMV, "."]]))
        else:
            command = list(itertools.chain.from_iterable([commands.bdinfo(), [
                "-l", utils.convertPathType(BDMV, "Linux"), "."]]))

        self._playlist = subprocess.run(
            command, stdout=subprocess.PIPE, stderr=subprocess.PIPE).stdout.decode('utf8', 'strict')


