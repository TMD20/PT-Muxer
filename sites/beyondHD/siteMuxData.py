import os
import re

from simple_term_menu import TerminalMenu
from prompt_toolkit import prompt as input


import tools.muxHelpers as remuxHelper
from sites.base.siteMuxData import MuxHelper


class BeyondHD(MuxHelper):
    def __init__(self):
        super().__init__()
    #Overwrite Filename
    def getFileName(self,kind, mediatype, hdr, output, movieName, year, videoRes, videoCodec, audioCodec, audioChannel,group):
        inputs = ["YES", "NO"]

        if kind == "movie":
            fileName = f"{movieName}.{year}.{mediatype}.{videoRes}.{audioCodec}.{audioChannel}.{videoCodec}.{hdr}.REMUX-{group}.mkv"
            fileName = re.sub(" +", ".", fileName)
        print(f"Is this FileName Correct: {fileName}\n")
        menu = TerminalMenu(inputs)
        choice = inputs[menu.show()]
        while choice !="YES":
            fileName = input("Enter New Name: ", default=fileName)
            print("Is the File Correct Now\n")
            choice = inputs[menu.show()]
        return os.path.join(output, fileName)
    
    def createMKV(self, fileName, movieTitle, chapters, xml,  bdinfo, eac3to):
        super().createMKV(fileName, movieTitle, chapters, xml,  bdinfo, eac3to)
        mediainfo = remuxHelper.getMediaInfo(fileName)
        print(f"\n\n{mediainfo}\n\n")
