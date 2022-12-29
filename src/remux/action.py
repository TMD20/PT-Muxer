import traceback

import src.tools.general as utils
import src.remux.remuxMovies as remuxMovies
import src.remux.remuxTV as remuxTV
import src.tools.general as utils
import config as config
import src.tools.paths as paths
import src.tools.exit as exit
import src.tools.logger as logger


def endProcess():
    if remuxObj != None and remuxObj.success == True:
        logger.print("Remuxing Complete")
        paths.deleteTempDirs()
    else:
        quit()


def remux(args):
    # Help user out delete all temp directories
    paths.deleteTempDirs()
    global remuxObj
    remuxObj = None
    with exit.GracefulExit(endProcess):
        try:
            # Variables
            if args.forcemovie:
                remuxObj = remuxMovies.Remux(args)

            elif utils.singleSelectMenu(["Movie", "TV"], "What Type of Media do you want to Remux?") == "Movie":
                remuxObj = remuxMovies.Remux(args)
            else:
                remuxObj = remuxTV.Remux(args)
            remuxObj()
        except Exception as E:
            logger.print(traceback.format_exc(), style="white")
            logger.print(E, style="white")
        quit()
        # argStr='\n'.join(list(map(lambda x:f"Argument {x[0]}: {x[1]}",vars(args).items())))
        # if utils.singleSelectMenu(["Yes", "No"], f"{argStr}\n\nRemux more Media with same commandline args") == "No":
        #          break
