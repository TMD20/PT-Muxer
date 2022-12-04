import signal
import re
import os

import tools.general as utils
import demux.demuxMovies as demuxMovies
import demux.demuxTV as demuxTV
import tools.general as utils
import config as config
import tools.paths as paths
import tools.exit as exit



def endProcess():
    paths.deleteTempDirs()
    if demuxObj==None:
        None
    elif demuxObj.demuxFolder!=None and demuxObj.success==False:
        if utils.singleSelectMenu(["Yes","No"],f"Do you want to delete the current Mux Folder\n{demuxObj.demuxFolder}?")=="Yes":
                utils.rmDir(demuxObj.demuxFolder)
    print("Good Bye")
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
                demuxObj()
            else:   
                demuxObj=demuxTV.Demux(args)
                demuxObj()
        except Exception as E:
            print(E)

