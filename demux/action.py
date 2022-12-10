import traceback

import tools.general as utils
import demux.demuxMovies as demuxMovies
import demux.demuxTV as demuxTV
import tools.general as utils
import config as config
import tools.paths as paths
import tools.exit as exit
import tools.logger as logger




def endProcess():
    paths.deleteTempDirs()
    if demuxObj==None:
        None
    elif demuxObj.demuxFolder!=None and demuxObj.success==False:
        logger.logger.info("Program Forced to stop\n")
        if utils.singleSelectMenu(["Yes","No"],f"Do you want to delete the current Mux Folder\n{demuxObj.demuxFolder}?")=="Yes":
                utils.rmDir(demuxObj.demuxFolder)
    logger.logger.info("Good Bye\n")
    quit()


    
def demux(args):
    #Help user out delete all temp directories
    paths.deleteTempDirs()
    global demuxObj
    demuxObj=None
    with exit.GracefulExit(endProcess):
        options = ["Movie", "TV"]
        try:
            if utils.singleSelectMenu(options, "What Type of Media are you Demuxing?") == "Movie":
                demuxObj=demuxMovies.Demux(args)
            else:   
                demuxObj=demuxTV.Demux(args)
            demuxObj()
        except Exception as E:
            logger.print(traceback.format_exc(),style="white")
            logger.print(E,style="bold red")

