from sites.base.siteMuxData import MuxHelper
import tools.muxHelpers as remuxHelper
import os
import subprocess
import tempfile
import tools.general as util



class Blu(MuxHelper):
    def __init__(self):
        super().__init__()

    def createMKV(self, fileName, movieTitle, chapters, xml,  bdinfo, eac3to):
        super().createMKV(fileName,movieTitle, chapters,xml,  bdinfo,eac3to)
        tempdir = tempfile.TemporaryDirectory()
        mediainfoPath = os.path.join(tempdir.name,"media.txt")
        mediainfo = remuxHelper.getMediaInfo(fileName)
        print(f"\n\n{mediainfo}\n\n")

        with open(mediainfoPath,"w") as p:
            p.write(mediainfo)
        print("\n\nRunning Blutopia Validator\n\n")
        command = ["/usr/local/bin/mine/remux/bin/python3", os.path.join(util.getRootDir(), "vdator/vdator/main.py"),
                mediainfoPath, bdinfo, eac3to]
        with subprocess.Popen(command, stdout=subprocess.PIPE, stderr=subprocess.PIPE, universal_newlines=True, bufsize=1) as p:
            for line in p.stdout:
                print(line, end='')
            for line in p.stderr:
                print(line, end='')
