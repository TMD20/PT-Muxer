import os
import traceback

import tools.paths as paths
import tools.logger as logger
import tools.general as utils
if utils.getSystem()=="Linux":
    import mediatools.BDSupReader.bdsupreader as BDSup
else:
    import mediatools.PGSReader.imagemaker as imagemaker
    import mediatools.PGSReader.pgsreader as pgsreader


    

  

def PGSFunc(supFile):
    None
    

    # outputDir= os.path.join(os.path.abspath(f"./subImages"),f"{os.path.basename(supFile)}/")
    # paths.mkdirSafe(outputDir)
    # t=BDSupReader.BDSupReader(supFile)
    # i=0
    # try:
    #     for r in t.subPictures:
    #         for image in r.imageList:
    #             i=i+1
    #             newImage=os.path.join(outputDir,f"image{i}.png")
    #             logger.logger.debug(f"Saving {newImage}\n")
    #             image["data"].save(newImage)
    # except Exception as E:
    #     logger.logger.debug(traceback.format_exc())
    #     logger.logger.debug(str(E))
    #     logger.print("Ignoring SubImage Error Contining")
    # return outputDir



def BDSupFunc(supFile):
    

    outputDir= os.path.join(os.path.abspath(f"./subImages"),f"{os.path.basename(supFile)}/")
    paths.mkdirSafe(outputDir)
    t=BDSup.BDSupReader(supFile)
    i=0
    try:
        for r in t.subPictures:
            for image in r.imageList:
                i=i+1
                newImage=os.path.join(outputDir,f"image{i}.png")
                logger.logger.debug(f"Saving {newImage}\n")
                image["data"].save(newImage)
    except Exception as E:
        logger.logger.debug(traceback.format_exc())
        logger.logger.debug(str(E))
        logger.print("Ignoring SubImage Error Contining")
    return outputDir


def getSubImages(supFile):
    if utils.getSystem()=="Linux":
        return BDSupFunc()
    else:
        return PGSFunc()





        