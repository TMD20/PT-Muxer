import signal

import tools.general as utils
import demux.Movie.demuxMovie as demuxMovie
import demux.TV.demuxTV as demuxTV
def signal_handler(sig, frame):
    print('You pressed Ctrl+C!')
    quit()


signal.signal(signal.SIGINT, signal_handler)

def demux(args):
    import time
    time.sleep(5000)
    options = ["Movie", "TV"]
    try:
        if utils.singleSelectMenu(options, "What Type of Media are you Demuxing?") == "Movie":
            demuxMovie.demux(args)
        else:
            demuxTV.demux(args)
    except Exception as E:
        print(E)
