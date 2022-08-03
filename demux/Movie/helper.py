import os

import mediatools.bdinfo as bdinfo
import demux.paths as paths
import tools.general as utils

def getBdinfoData(sources):
    # Generate Bdinfo/TrackInfo for Each Source
    bdObjs = []
    for source in sources:
        print("Loading Playlists...\n")
        print(f"\n{source}\n")

        bdObj = bdinfo.Bdinfo()
        bdObj.setup(source)
        bdObj.playListSelect()
        bdObj.runbdinfo()
        bdObjs.append(bdObj)
    return bdObjs


def processBdinfo(sources, bdObjs, demuxData, dontConvert):
    for i in range(len(sources)):
        source = sources[i]
        bdObj = bdObjs[i]
        output = paths.createChildDemuxFolder(os.getcwd(), source)
        os.chdir(output)
        show = utils.getShowName(source)
        path = os.path.join(
            output, "output_logs", f"BDINFO.{show}.txt")
        print(f"Extracting BDINFO from {source}")
        bdObj.writeBdinfo(path)
        quickSums = bdObj.getQuickSum()
        streams = bdObj.getStreams()
        streams = list(map(lambda x: x["name"], streams))
        bdObj.getChapters()
        currentTracks = demuxData.addTracks(
            quickSums, bdObj.playlistNum, bdObj.playlistFile,streams, source, output)
        if not dontConvert:
            demuxData.convertFlac(currentTracks, output)
        os.chdir("..")
