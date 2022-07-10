import itertools
import re
import os
import subprocess


from prompt_toolkit import prompt as input

class MuxHelper():
    def __init__(self):
        self._audio=[]
        self._video=[]
        self._sub=[]
        self._out=None

    def generateMuxData(self,remuxConfig):
        self._addAudioTracks(remuxConfig)
        self._addVideoTracks(remuxConfig)
        self._addSubTracks(remuxConfig)
        self._out =  list(itertools.chain.from_iterable([self._video,self._audio,self._sub]))



    @property
    def out(self):
        return self._out

    def _addVideoTracks(self,remuxConfig):
        out=[]
        langcodeKey = str(remuxConfig["Enabled_Tracks"]["Audio"][0])
        langcode = remuxConfig["Tracks_Details"]["Audio"][langcodeKey]["langcode"]
        for i in range(len(remuxConfig["Enabled_Tracks"]["Video"])):
            key = remuxConfig["Enabled_Tracks"]["Video"][i]
            key = str(key)
            trackjson = remuxConfig["Tracks_Details"]["Video"][key]
            name = trackjson["site_title"]
            file = trackjson["file"]


            temp = ["--language", f"0:{langcode}", "--compression", f"0:None"]
            if name:
                temp.extend(["--track-name", f"0:{name}"])
            default=["--default-track-flag", "0:0"]
            if i==0:
                default = ["--default-track-flag", "0:1"]  
            if trackjson.get("default") == True:
                default = ["--default-track-flag", "0:1"]
            temp.extend(default)
            temp.append(file)
            out.append(temp)
        self._video=list(itertools.chain.from_iterable(out))


    def _addAudioTracks(self,remuxConfig):
        out = []
        for i in range(len(remuxConfig["Enabled_Tracks"]["Audio"])):
            key =remuxConfig["Enabled_Tracks"]["Audio"][i]
            key = str(key)
            trackjson = remuxConfig["Tracks_Details"]["Audio"][key]
            langcode = trackjson["langcode"]
            name = trackjson["site_title"]
            file = trackjson["file"]
            temp = ["--language", f"0:{langcode}", "--compression", f"0:None"]
            if name:
                temp.extend(["--track-name", f"0:{name}"])
            default = ["--default-track-flag", "0:0"]
            if i == 0:
                default = ["--default-track-flag", "0:1"]
            if trackjson.get("default")==True:
                default = ["--default-track-flag", "0:1"]
            temp.extend(default)
            if re.search("commentary", name, re.IGNORECASE):
                temp.extend(["--commentary-flag", "0"])
            
            temp.append(file)
            out.append(temp)
     
        self._audio=list(itertools.chain.from_iterable(out))
        

    def _addSubTracks(self,remuxConfig):
        audiocodeKey = str(remuxConfig["Enabled_Tracks"]["Audio"][0])
        audiocode = remuxConfig["Tracks_Details"]["Audio"][audiocodeKey]["langcode"]
        out=[]
        for i in range(len(remuxConfig["Enabled_Tracks"]["Sub"])):
            key =remuxConfig["Enabled_Tracks"]["Sub"][i]
            key = str(key)
            

            trackjson = remuxConfig["Tracks_Details"]["Sub"][key]
            langcode = trackjson["langcode"]
            file = trackjson["file"]
            name = trackjson.get("site_title")

            temp = ["--language", f"0:{langcode}", "--compression", f"0:None"]
            default = ["--default-track-flag", "0:0"]
            
            if langcode != audiocode and langcode == "en":
                default=["--default-track-flag", "0:1"]
            if name and re.search("forced", name, re.IGNORECASE):
                default = ["--default-track-flag", "0:1"]
            if trackjson.get("default")==True:
                default = ["--default-track-flag", "0:1"]
            temp.extend(default)
            
    

            if name:
                temp.extend(["--track-name", f"0:{name}"])
                if re.search("sdh", name, re.IGNORECASE):
                    temp.extend(["--hearing-impaired-flag", f"0:{name}"])
                if re.search("commentary", name, re.IGNORECASE):
                    temp.extend(["--commentary-flag", "0"])

            temp.append(file)
            out.append(temp)
        self._sub=(list(itertools.chain.from_iterable(out)))
       

    def getFileName(self,kind, mediatype, hdr, output, movieName, year, videoRes, videoCodec, audioCodec, audioChannel):
        validinputs = ["yes", "y", "Y", "YES", True]

        if kind == "movie":
            fileName = f"{movieName}.{year}.{videoRes}.{mediatype}.REMUX.{hdr}.{videoCodec}.{audioCodec}.{audioChannel}-TMS.mkv"
            fileName = re.sub(" +", ".", fileName)
        check = input(f"Is this FileName Correct: {fileName} ")
        while check not in validinputs:
            fileName = input("Enter New Name: ", default=fileName)
            check = input(f"Is this FileName Correct: {fileName} ")
        return os.path.join(output, fileName)

    def createMKV(self, movieTitle, chapters, fileName, remuxConfig):

        command = list(itertools.chain.from_iterable(
            [["/usr/bin/mkvmerge", "--title", movieTitle, "--chapters", chapters, "--output", fileName], self._out]))
  
        with subprocess.Popen(command, universal_newlines=True, stdout=subprocess.PIPE, bufsize=1) as p:
            for line in p.stdout:
                print(line, end='')
