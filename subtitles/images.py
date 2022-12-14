import os
import traceback

from mediatools.BDSupReader.src.bdsupreader import *
import tools.paths as paths
import tools.logger as logger






def getSubImages(supFile):
    outputDir= os.path.join(os.path.abspath(f"./subImages"),f"{os.path.basename(supFile)}/")
    paths.mkdirSafe(outputDir)
    t=BDSupReader(supFile)
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

        