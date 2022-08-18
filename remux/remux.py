import tools.general as utils
import remux.Movie.remuxMovie as movieRemux
import remux.TV.remuxTV as tvRemux


def Remux(args):
    # Variables
    if args.forcemovie:
        movieRemux.Remux(args)

    elif utils.singleSelectMenu(["Movie", "TV"], "What Type of Media do you want to Remux?") == "Movie":
        movieRemux.Remux(args)
    else:
        tvRemux.Remux(args)
