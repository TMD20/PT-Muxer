import os
import re

from prompt_toolkit import prompt as input


from sites.base.siteMuxData import MuxOBj
import tools.muxHelpers as demuxHelper


class BeyondHD(MuxOBj):
    def __init__(self):
        super().__init__()
    #Overwrite Filename

    def getFileName(self, kind, mediatype, hdr, output, movieName, year, videoRes, videoCodec, audioCodec, audioChannel, group,season=None, episode=None):
        inputs = ["YES", "NO"]

        if kind == "movie":
            fileName = f"{movieName}.{year}.{mediatype}.{videoRes}.{audioCodec}.{audioChannel}.{videoCodec}.{hdr}.REMUX-{group}.mkv"
            fileName = re.sub(" +", ".", fileName)
        else:
            fileName = f"{movieName}.{year}.S{season//10}{season&10}.E0{episode}.{videoRes}.{mediatype}.REMUX.{videoCodec}.{audioCodec}.{audioChannel}-{group}.mkv"
            fileName = re.sub(" +", " ", fileName)
            fileName = re.sub(" +", ".", fileName)
        print(f"Is this FileName Correct: {fileName}\n")
        choice =  inputs[demuxHelper.Menu(inputs)]

        while choice !="YES":
            fileName = input("Enter New Name: ", default=fileName)
            print("Is the File Correct Now\n")
            choice = inputs[demuxHelper.Menu(inputs)]
        return os.path.join(output, fileName)
    

