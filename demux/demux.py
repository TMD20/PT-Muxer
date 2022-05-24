import pprint
import os
import json


import mediatools.bdinfo as bdinfo
import mediatools.eac3to as eac3to
import demux.helper as demuxHelper
import sites.general.sitePicker as sitePicker
import general.util as util


def Demux(args):
    options = demuxHelper.getFiles(args.path)
    os.chdir(args.outpath)
    sources = demuxHelper.addSources(options)
    sources = demuxHelper.Extract(sources, args.path)
    print("Creating Demux Folder\n")
    parentDir = demuxHelper.createParentDemuxFolder(sources, args.outpath)
    os.chdir(parentDir)
    muxData = sitePicker.pickSite(args.site)
    for source in sources:
        output = demuxHelper.createChildDemuxFolder(parentDir, source)
        os.chdir(output)
        os.mkdir("output_logs")
        bdObj = bdinfo.Bdinfo()
        quickSum = bdObj.process(parentDir, source)
        muxData.addTracks(quickSum, bdObj.playlistNum, source, output)
        os.chdir(parentDir)
    trackDataObj = muxData.tracksDataObj
    for key in muxData.sources:
        outputs_list = [trackDataObj.rawMediaTracksData[key]["tracks"][i]["eac3to"]
                        for i in range(len(trackDataObj.rawMediaTracksData[key]["tracks"]))]
        output = trackDataObj.rawMediaTracksData[key]["output"]
        source = trackDataObj.rawMediaTracksData[key]["source"]
        playlistNum = trackDataObj.rawMediaTracksData[key]["playlistNum"]
        eac3to.process(source, output, outputs_list, playlistNum,
                       eac3to.get_eac3toPath(parentDir,util.getShowName(source)))
    muxData.sortTracks(args.pref)
    with open(os.path.join(parentDir, "output.txt"), "w") as p:
        p.write(json.dumps(muxData.getTracksDict(), indent=4))
