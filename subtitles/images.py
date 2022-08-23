import subprocess
import os
import shutil
import itertools

import tools.commands as commands



def getSubImages(supFile, dir):
    # suprip outputs to same directory sup file is in always
    movedSup = os.path.join(dir, "temp.sup")
    shutil.copy2(supFile,movedSup)
    command=list(itertools.chain.from_iterable([commands.suprip(),[movedSup, "1"]]))
    subprocess.run(command)
    os.remove(movedSup)
