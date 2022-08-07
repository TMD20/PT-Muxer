import mediatools.bdinfo as bdinfo

import tools.general as utils


def getBdinfoData(sources):
    bdObjs = []
    for source in sources:
        print(f"\n{source}\n")
        print("Loading Playlists...\n")
        bdObj = bdinfo.Bdinfo()
        bdObj.setup(source)
        bdObj.playListRangeSelect()
        bdObjs.append(bdObj)
    return bdObjs


def getStreamsLength(streams):
    duration = 0
    start = utils.convertArrow(streams[0]["start"], "hh:mm:ss.SSS")
    end = utils.convertArrow(streams[-1]["end"], "hh:mm:ss.SSS")
    dif = utils.subArrowTime(end, start)
    duration = (duration+dif.hour*60)
    duration = (duration+dif.minute)
    duration = (duration+(dif.second/60))
    return duration


def getNewStartTime(startTime, streams):
    start = utils.convertArrow(streams[0]["start"], "hh:mm:ss.SSS")
    end = utils.convertArrow(streams[-1]["end"], "hh:mm:ss.SSS")
    dif = utils.subArrowTime(end, start)
    startTime = utils.addArrowTime(startTime, dif)
    return startTime
