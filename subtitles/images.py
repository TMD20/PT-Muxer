import os
import traceback

import tools.paths as paths
import tools.logger as logger
import tools.general as utils

try:
    import mediatools.BDSupReader.bdsupreader22 as BDSup
except ModuleNotFoundError as E:
    BDSup=None
    logger.print(E)
    logger.print(traceback.format_exc(),style="white")
    logger.print("Missing Module Not Using BDSupReader")
except Exception as E:
    BDSup=None
    logger.print(E)
    logger.print(traceback.format_exc(),style="white")
    logger.print("Error Not using BDSupReader")


    
try:
    import mediatools.PGSReader.imagemaker as imagemaker
    import mediatools.PGSReader.pgsreader as PGSReader
except ModuleNotFoundError:
    imagemaker=None
    PGSreader=None
    logger.print(E)
    logger.print(traceback.format_exc(),style="white")
    logger.print("Missing Module Not Using PGSReader")

except Exception as E:
    imagemaker=None
    PGSreader=None
    logger.print(E)
    logger.print(traceback.format_exc(),style="white")
    logger.print("Error Not using PGSReader")

BDSUPBool= (BDSup!=None)
PGSBool=(imagemaker!=None and PGSReader!=None)

def PGSFunc(supFile,outputDir):
    outputDir= os.path.join(os.path.abspath(f"./subImages"),f"{os.path.basename(supFile)}/")
    paths.mkdirSafe(outputDir)
    t = PGSReader.PGSReader(supFile)
    i=0
    try:
        for i,ds in enumerate(t.iter_displaysets()):
            if ds.has_image==False:
                continue
            newImage=os.path.join(outputDir,f"image{i}.png")
            pds = ds.pds[0]
            ods = ds.ods[0]
            img = imagemaker.make_image(ods, pds)
            img.convert('RGB').save(newImage)
            logger.logger.debug(f"Saving {newImage}\n")



    except Exception as E:
        logger.logger.debug(traceback.format_exc())
        logger.logger.debug(str(E))
        logger.print("Ignoring PGSReader Error Contining")
    return outputDir



def BDSupFunc(supFile,outputDir):
    t=BDSup.BDSupReader(supFile)
    i=0
    try:
        for r in t.subPictures:
            for image in r.imageList:
                i=i+1
                newImage=os.path.join(outputDir,f"image{i}.png")
                image["data"].save(newImage)
                logger.logger.debug(f"Saving {newImage}\n")

    except Exception as E:
        logger.logger.debug(traceback.format_exc())
        logger.logger.debug(str(E))
        logger.print("Ignoring BDSup Error Contining")
    return outputDir


def getSubImages(supFile):
    outputDir= os.path.join(os.path.abspath(f"./subImages"),f"{os.path.basename(supFile)}/")
    paths.mkdirSafe(outputDir)
    if BDSUPBool:
        BDSupFunc(supFile,outputDir)
    if PGSBool and len(os.listdir(outputDir))==0:
        PGSFunc(supFile,outputDir)
    return outputDir





        