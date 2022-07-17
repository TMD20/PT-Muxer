import subprocess
import os

import tools.general as util

def getSubImages(supFile,dir):
    supBin = "/usr/local/bin/Suprip.exe"
    wineBin= "/usr/bin/wine"

    if not os.path.isfile(supBin):
        supBin= os.path.join(
            util.getRootDir(), "binaries/suprip-1.16/SupRip.exe")
 

    #suprip outputs to same directory sup file is in always
    movedSup=os.path.join(dir,"temp.sup")
    os.popen(f"cp {supFile} {movedSup}")
    subprocess.run([wineBin, supBin, movedSup,"1"])
    os.remove(movedSup)


        

   


    