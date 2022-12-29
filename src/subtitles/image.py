import os
import subprocess
import os
import shutil
import itertools

import src.tools.install as install
import src.tools.directory as dir
import src.subtitles.nativeimage as nativeimage
import src.tools.commands as commands


def supRipSaver(supFile, outputDir):
    # suprip image to same directory as .sup file
    with dir.cwd(outputDir):
        movedSup = "temp.sup"
        shutil.copy2(supFile,movedSup)
        command=list(itertools.chain.from_iterable([commands.suprip(),[movedSup, "1"]]))
        subprocess.run(command)
        os.remove(movedSup)



def getSubImages(supFile):
    outputDir= os.path.join(os.path.abspath(f"./subImages"),f"{os.path.basename(supFile)}/")
    if install.contyInstallCheckWine(): 
        supRipSaver(supFile,outputDir)
    else:
        nativeimage.getSubImages(supFile)
    return outputDir
        







        