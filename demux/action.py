import signal
import re
import os

import tools.general as utils
# import demux.demuxMovie as demuxMovie
import demux.demuxTV as demuxTV
import tools.general as utils
import config as config
import tools.paths as paths
import tools.exit as exit



def endProcess():
    folders=paths.getTempDirs()
    for folder in folders:
        os.remove(folder)
    if demuxObj!=None and demuxObj.demuxFolder!=None:
        if utils.singleSelectMenu(["Yes","No"],f"Do you want to delete the current Mux Folder\n{demuxObj.demuxFolder}?")=="Yes":
                utils.rmDir(demuxObj.demuxFolder)
    print("Good Bye")
    quit()


    
def demux(args):
    global demuxObj
    demuxObj=None
    with exit.GracefulExit(endProcess):
        options = ["Movie", "TV"]
        try:
            if utils.singleSelectMenu(options, "What Type of Media are you Demuxing?") == "Movie":
                None
                # demuxObj=demuxMovies.Demux(args)
                # demuxMovie.getDemuxFolder(args)
            else:
               
                demuxObj=demuxTV.Demux(args)
                demuxObj()
        except Exception as E:
            print(E)
