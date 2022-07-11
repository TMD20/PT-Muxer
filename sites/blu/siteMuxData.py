from sites.base.siteMuxData import MuxHelper
import tools.muxHelpers as remuxHelper
import os
import subprocess
import tempfile



class Blu(MuxHelper):
    def __init__(self):
        super().__init__()

    def createMKV(self, movieTitle, chapters, fileName, remuxConfig):
        super().createMKV(movieTitle, chapters, fileName,remuxConfig)
        os.chdir(os.path.dirname(os.path.realpath(__file__)))
        tempdir = tempfile.TemporaryDirectory()
        mediainfo = os.path.join(tempdir.name,"media.txt")
        with open(mediainfo,"w") as p:
            p.write(remuxHelper.getMediaInfo(fileName))
        
        command = ["/usr/local/bin/mine/remux/bin/python3", "../.vdator/vdator/main.py",
                mediainfo, remuxHelper.getBdinfo(remuxConfig), remuxHelper.getEac3to(remuxConfig)]
        with subprocess.Popen(command, stdout=subprocess.PIPE, stderr=subprocess.PIPE, universal_newlines=True, bufsize=1) as p:
            for line in p.stdout:
                print(line, end='')
            for line in p.stderr:
                print(line, end='')
