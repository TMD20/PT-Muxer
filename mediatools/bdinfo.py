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
                raise RuntimeError(message)
 
   
    def validateStreams(self,bdObjs):
        validateStreams=self._flattenStreams()
        for bdObj in bdObjs:
            compareStreams=bdObj._flattenStreams()
            if len(compareStreams)!=len(validateStreams):
                message = \
                    """
            Their is an issue with the playlist that you picked.

            For each source the sum of all the streams for all the playlist for that source is calculated, and compared
            Example: 
            Playlist 00001.mpls may have 8 streams in it
            Playlist 00002.mpls may have 4 streams
            12 total streams

            This sum does not match

            Tip:
            -For non-advance users user make sure all sources are for the same movie. The only differences
            should be the language at most.
            - Pick the same playlist for all sources
            - If you want to use a source for one set of episodes, and not the next. You will need to run the program
            multiple times
            """
                raise RuntimeError(message)
            for index in range(len(validateStreams)):
                compareLength=self._getStreamLengthHelper(compareStreams[index])
                validatorLength=self._getStreamLengthHelper(validateStreams[index])
                if compareLength!=validatorLength:
                    message = \
                    f"""
                    Their is an issue with the playlist that you picked.
                    {bdObj.mediaDir} and {self.mediaDir} have a unmatch stream
                    at stream number {index+1}.

                    This is {validateStreams[index]["name"]} and {compareStreams[index]["name"]} respectively
                    Please check the length of all streams
                    """
                    raise RuntimeError(message)
    
    

  

    def generateData(self,i):
        key=self._playlistKeys[i]
        playlistNum = key
        print(f"Generating Data for {self._mediaDir}\nPlaylist:{playlistNum}\n")  
        self._setBdInfo(playlistNum)
        self._setQuickSum(playlistNum)
        self._setStreams(playlistNum) 
        self._setChapters(playlistNum)    

    
    
    def writeBDInfo(self, index,path=None):
        if path==None:
            path=os.path.join(".","output_logs",utils.sourcetoShowName(self._mediaDir))
        paths.mkdirSafe(path)
        file = open(path, "w")
        file.write(self.DictList[index]["bdinfo"])
        

    
    def getStreamChapter(self,streamDataList,playlistKey):
        chapters=[]
        parseString="HH:mm:ss.SSS"
        if isinstance(streamDataList, list)==False:
            streamDataList=[streamDataList]
        for streamData in streamDataList:
            start = utils.convertArrow(streamData["start"],parseString )
            end = utils.convertArrow(streamData["end"], parseString)
        
            for time in self.Dict[playlistKey]["chapters"]:
                if utils.convertArrow(time["start"],parseString)<start:
                    continue
                elif utils.convertArrow(time["start"],parseString)>end:
                    break
                chapters.append(time)
        return self._chapterOffsetHelper(chapters)

    def playListSelect(self):
        self._playlistKeys = [self._getIndex()]
        self._playListFileHelper()
    

    def playListRangeSelect(self):
        self._playlistKeys=self._getRange()
        self._playListFileHelper()
    
    
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
            raise RuntimeError("playlist Number is out of range")
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
                "-l", BDMV]]))
        else:
            command = list(itertools.chain.from_iterable([commands.bdinfo(), [
                "-l", paths.convertPathType(BDMV, "Linux")]]))

        self._playlist = subprocess.run(
            command, stdout=subprocess.PIPE, stderr=subprocess.PIPE).stdout.decode('utf8', 'strict')
    def _setBdInfo(self, playlistNum):
        selection = self._playlistDict[playlistNum]["playlistFile"]
       
        tempDir = paths.createTempDir()
        command = list(itertools.chain.from_iterable(
        [commands.bdinfo(), ["-m", selection, self._mediaDir, tempDir]]))
        subprocess.run(command)
        file = open(paths.convertPathType(os.path.join(
        tempDir, os.listdir(tempDir)[0]), "Linux"), "r")
        self._playlistDict[playlistNum]["bdinfo"] = file.read()
        shutil.rmtree(tempDir)
        file.close()

    def _setQuickSum(self,playlistNum):
        lines = self._playlistDict[playlistNum]["bdinfo"].split("\n")
        output=[]
        for line in lines:
            if re.search("(Video|Audio|Subtitle): ", line,re.IGNORECASE) != None:
                output.append(line)
        self._playlistDict[playlistNum]["quickSum"] = output

    def _setStreams(self,playlistNum):
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

    def _setChapters(self,playlistNum):
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
            number = int(data[0])

            t1 = dt.datetime.strptime(startTime, '%H:%M:%S.%f')
            t2 = dt.datetime.strptime(length, '%H:%M:%S.%f')
            endTime = str((t1 - time_zero + t2).time())[:-3]

            startTime = '{:0>2}:{:0<2}:{:0<2}.{:0<3}'.format(
                *startTime.split(":")[:2], *startTime.split(":")[2].split("."))

            out.append(
                {"number": number, "start": startTime, "end": endTime})
        self._playlistDict[playlistNum]["chapters"] = out

    ##################################
    #  Stream Functions
    #
    ##################################################
    def filterStreams(self,i,time):
        time=float(time)
        if time==float("inf") or time==0:
            return self.DictList[i]["playlistStreams"]
        return list(filter(lambda x: (self._getStreamLengthHelper(x).hour*60)+(self._getStreamLengthHelper(x).minute)+(self._getStreamLengthHelper(x).second/60)>=time,self.DictList[i]["playlistStreams"]))

    def _flattenStreams(self):
        output=[]
        for key in self._playlistKeys:
            for stream in self._playlistDict[key]["playlistStreams"]:
                output.append(stream)
        return output
    
    def _getStreamLengthHelper(self,stream):
        return utils.subArrowTime(utils.convertArrow(stream["end"],"HH:mm:ss.SSS"),utils.convertArrow(stream["start"],"HH:mm:ss.SSS"))
                
    ####################################
    # Helper Functions
    ######################################
    def _chapterOffsetHelper(self,chapters):
        parseString="HH:mm:ss.SSS"
        if utils.convertArrow(chapters[0]["start"],parseString)==utils.convertArrow("00","mm"):
            return chapters
        timeOffset=utils.convertArrow(chapters[0]["start"],parseString)
        numOffset=chapters[0]["number"]-1
        for chapter in chapters:
            chapter["start"]=utils.subArrowTime(utils.convertArrow(chapter["start"],parseString),timeOffset).format(parseString)
            chapter["end"]=utils.subArrowTime(utils.convertArrow(chapter["end"],parseString),timeOffset).format(parseString)
            chapter["number"]=chapters[0]["number"]-numOffset
        return chapters    
    def _playListFileHelper(self):
        for num in self._playlistKeys:
            self._playlistDict[num]={}
            self._playlistDict[num]["playlistFile"]=self._getplaylistFile(num)        