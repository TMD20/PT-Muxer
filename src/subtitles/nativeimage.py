import os
import traceback

import src.tools.logger as logger
import src.tools.directory as dir
import src.tools.general as utils

try:
    import src.mediatools.BDSupReader.bdsupreader as BDSup
except ModuleNotFoundError as E:
    BDSup=None
    utils.tracebackhelper(traceback.format_exc(),E,"Missing Module Not Using BDSupReader")
except Exception as E:
    BDSup=None
    utils.tracebackhelper(traceback.format_exc(),E,"Error Not using BDSupReader")



    
try:
    import src.mediatools.PGSReader.imagemaker as imagemaker
    import src.mediatools.PGSReader.pgsreader as PGSReader
except ModuleNotFoundError:
    imagemaker=None
    PGSreader=None
    utils.tracebackhelper(traceback.format_exc(),E,"Missing Module Not Using PGSReader")


except Exception as E:
    imagemaker=None
    PGSreader=None
    utils.tracebackhelper(traceback.format_exc(),E,"Error Not using PGSReader")

BDSUPBool= (BDSup!=None)
PGSBool=(imagemaker!=None and PGSReader!=None)

def PGSFunc(supFile):
    """
    Uses 
    https://github.com/EzraBC/pgsreader
    to process sub images


    Args:
        supFile (str): .sup file to process
    """
   
    t = PGSReader.PGSReader(supFile)
    i=0
    try:
        for i,ds in enumerate(t.iter_displaysets()):
            if ds.has_image==False:
                continue
            newImage=f"image{i}.png"
            pds = ds.pds[0]
            ods = ds.ods[0]
            img = imagemaker.make_image(ods, pds)
            img.convert('L').save(newImage)
            logger.logger.debug(f"Saving {newImage}\n")



    except Exception as E:
        utils.tracebackhelper(traceback.format_exc(),E,"Ignoring PGSReader Error Contining")





def BDSupFunc(supFile):
    """
    Uses 
    https://github.com/Sec-ant/BDSupReader
    to process sub images


    Args:
        supFile (str): .sup file to process
    """
    t=BDSup.BDSupReader(supFile)
    i=0
    try:
        for r in t.subPictures:
            for image in r.imageList:
                i=i+1
                newImage=f"image{i}.png"
                image["data"].save(newImage)
                logger.logger.debug(f"Saving {newImage}\n")

    except Exception as E:
        utils.tracebackhelper(traceback.format_exc(),E,"Ignoring BDSup Error Contining")

  








def getSubImages(supFile):
    """
    Attempts to process try excepts supFile with up to two processor 
    in cases where one processor errors out

    Args:
        supFile (str): .sup file to process

    Returns:
        str: directory with subtitle images
    """
    outputDir=os.path.join(os.path.abspath(f"./subImages"),f"{os.path.basename(supFile)}/")
    with dir.cwd(outputDir):
        if BDSUPBool:
            BDSupFunc(supFile)
        if PGSBool and len(os.listdir(outputDir))==0:
            PGSFunc(supFile)
        return outputDir
    





        