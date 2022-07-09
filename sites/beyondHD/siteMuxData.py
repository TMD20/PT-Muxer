from sites.base.siteMuxData import MuxHelper
import os
import re
from prompt_toolkit import prompt as input


class BeyondHD(MuxHelper):
    def __init__(self):
        super().__init__()
    #Overwrite Filename
    def getFileName(self,kind, mediatype, hdr, output, movieName, year, videoRes, videoCodec, audioCodec, audioChannel):
        validinputs = ["yes", "y", "Y", "YES", True]

        if kind == "movie":
            fileName = f"{movieName}.{year}.{mediatype}.{videoRes}.{audioCodec}.{audioChannel}.{videoCodec}.{hdr}.REMUX-TMS.mkv"
            fileName = re.sub(" +", ".", fileName)
        check = input(f"Is this FileName Correct: {fileName} ")
        while check not in validinputs:
            fileName = input("Enter New Name: ",default=fileName)
            check = input(f"Is this FileName Correct: {fileName} ")
        return os.path.join(output, fileName)
