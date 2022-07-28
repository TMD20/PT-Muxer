import os
import subprocess
import tempfile

from pymediainfo import MediaInfo

from sites.base.siteMuxData import MuxOBj
import tools.general as utils


class Blu(MuxOBj):
    def __init__(self):
        super().__init__()

    def createMKV(self, fileName, movieTitle, chapters, xml,  bdinfo, eac3to):
        super().createMKV(fileName, movieTitle, chapters, xml,  bdinfo, eac3to)
        tempdir = tempfile.TemporaryDirectory()
        mediainfoPath = os.path.join(tempdir.name, "media.txt")
        mediainfo = MediaInfo.parse(fileName, output="", full=False)

        with open(mediainfoPath, "w") as p:
            p.write(mediainfo)
        print("\n\nRunning Blutopia Validator\n\n")
        command = ["/usr/local/bin/mine/remux/bin/python3", os.path.join(utils.getRootDir(), "vdator/vdator/main.py"),
                   mediainfoPath, bdinfo, eac3to]

        with subprocess.Popen(command, stdout=subprocess.PIPE, stderr=subprocess.PIPE, universal_newlines=True, bufsize=1) as p:
            for line in p.stdout:
                print(line, end='')
            for line in p.stderr:
                print(line, end='')
