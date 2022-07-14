
import subprocess
import os

def getSubImages(supFile,dir):
    supBin = "/usr/local/bin/Suprip.exe"
    wineBin= "/usr/bin/wine"

    if not os.path.isfile(supBin):
        currentdir = os.path.abspath(".")
        os.chdir(os.path.dirname(os.path.realpath(__file__)))
        supBin = os.path.abspath("../binaries/suprip-1.16/SupRip.exe")
        os.chdir(currentdir)


    #suprip outputs to same directory sup file is in always
    movedSup=os.path.join(dir,"temp.sup")
    os.popen(f"cp {supFile} {movedSup}")
    subprocess.run([wineBin, supBin, movedSup,"1"])
    os.remove(movedSup)


        

   


    