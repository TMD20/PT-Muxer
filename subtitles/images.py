import subprocess
import os
import shutil

import config


def getSubImages(supFile, dir):
    supBin = config.supripLinuxPath
    wineBin = config.wineLinuxPath

    if not os.path.isfile(supBin):
        supBin = config.supripProjectPath
    if not os.path.isfile(wineBin):
        wineBin = config.wineProjectPath

    # suprip outputs to same directory sup file is in always
    movedSup = os.path.join(dir, "temp.sup")
    shutil.copy2(supFile,movedSup)
    subprocess.run([wineBin, supBin, movedSup, "1"])
    os.remove(movedSup)
