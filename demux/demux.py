import tools.general as utils
import demux.Movie.demuxMovie as demuxMovie
import demux.TV.demuxTV as demuxTV


def demux(args):
    options = ["Movie", "TV"]
    if utils.singleSelectMenu(options, "What Type of Media are you Demuxing?") == "Movie":
        demuxMovie.demux(args)
    else:
        demuxTV.demux(args)
