import traceback

import tools.general as utils
import remux.remuxMovies as remuxMovies
import remux.remuxTV as remuxTV
import tools.general as utils
import config as config
import tools.paths as paths
import tools.exit as exit
import tools.logger as logger



def endProcess():
    logger.print("Good Bye")
    paths.deleteTempDirs()
    quit()

    
def remux(args):
    #Help user out delete all temp directories
    paths.deleteTempDirs()
    global remuxObj
    remuxObj=None
    with exit.GracefulExit(endProcess):
        try:
            # Variables
            if args.forcemovie:
                remuxObj=remuxMovies.Remux(args)

            elif utils.singleSelectMenu(["Movie", "TV"], "What Type of Media do you want to Remux?") == "Movie":
                remuxObj=remuxMovies.Remux(args)
            else:
                remuxObj=remuxTV.Remux(args)
            remuxObj()
        except Exception as E:
            logger.print(traceback.format_exc(),style="white")
            logger.print(E,style="white")

