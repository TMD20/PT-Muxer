import os
import subprocess
import os
import shutil
import itertools
from typing import List,Union


import src.tools.install as install
import src.tools.directory as dir
import src.subtitles.nativeimage as nativeimage
import src.tools.commands as commands


def supRipSaver(supFile:Union[str, bytes, os.PathLike], outputDir:Union[str, bytes, os.PathLike])->None:
    """
    Uses bdsup2sub to generate subtitle images to ouput dir

    Args:
        supFile (str): .sup file to process
        outputDir (str): output directory for subtitle imags
    """
    # suprip image to same directory as .sup file
    with dir.cwd(outputDir):
        movedSup = "temp.sup"
        shutil.copy2(supFile,movedSup)
        command=list(itertools.chain.from_iterable([commands.suprip(),[movedSup, "1"]]))
        subprocess.run(command)
        os.remove(movedSup)



def getSubImages(supFile:Union[str, bytes, os.PathLike])->str:
    """
    Checks if bdsup2sup can process sup file 
    else uses native suptitle ripers to try to process

    Args:
        supFile (str): .sup file to process

    Returns:
        str: directory with subtitle images
    """
    outputDir= os.path.join(os.path.abspath(f"./subImages"),f"{os.path.basename(supFile)}/")
    if install.contyInstallCheckWine(): 
        supRipSaver(supFile,outputDir)
    else:
        nativeimage.getSubImages(supFile)
    return outputDir
        







        