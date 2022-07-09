import pprint
import os
import json
import re


import mediatools.bdinfo as bdinfo
import mediatools.eac3to as eac3to
import tools.muxHelpers as demuxHelper
import sites.pickers.sitedataPicker as siteDataPicker
import sites.pickers.siteSortPicker as siteSortPicker


def Demux(args):
    # Create Necessary Params/Objects
    options = demuxHelper.getFiles(args.inpath)
    demuxData = siteDataPicker.pickSite(args.site)
    muxSorter = siteSortPicker.pickSite(args.site)

    sources = demuxHelper.addSources(options)
    for i in range(0, len(sources)):
        if re.search(".iso", sources[i]):
            sources[i] = demuxHelper.Extract(sources[i], args.inpath)

    print("Creating Demux Folder\n")
    os.chdir(demuxHelper.createParentDemuxFolder(sources, args.outpath))
    
    # Generate Bdinfo/TrackInfo for Each Source
    for source in sources:
        output = demuxHelper.createChildDemuxFolder(os.getcwd(), source)
        os.chdir(output)

        bdObj = bdinfo.Bdinfo()
        quickSum = bdObj.process(output, source)

        demuxData.addTracks(quickSum, bdObj.playlistNum, source, output)
        demuxData.addSource(source)

        os.chdir("..")

    # Extract Using eac3to
    print("Extract Tracks using Eac3to")
    for key in demuxData.sources:
        trackDict = demuxData.filterBySource(key)
        eac3to_list = []
        for track in trackDict["tracks"]:
            eac3to_list.append(track["eac3to"])
            if track.get("eac3to_extras"):
                eac3to_list.extend(track["eac3to_extras"])

        eac3to.process(trackDict["sourceDir"], trackDict["outputDir"],
                       eac3to_list, trackDict["playlistNum"])

    # Sort/enable Tracks Based on Site
    muxSorter.tracksDataObj = demuxData
    muxSorter.sortTracks(args.pref)

    # Export
    dict = {}
    dict["sources"] = {}
    for key in demuxData.sources:
        trackObj = demuxData.filterBySource(key)
        dict["sources"][key] = {}

        dict["sources"][key]["outputDir"] = trackObj["outputDir"]
        dict["sources"][key]["sourceDir"] = trackObj["sourceDir"]
        dict["sources"][key]["playlistNum"] = trackObj["playlistNum"]
    for key in demuxData.sources:
        dict["Enabled_Tracks"] = {}
        dict["Enabled_Tracks"]["Video"] = list(
            map(lambda x: x["key"], muxSorter.enabledVideo))
        dict["Enabled_Tracks"]["Audio"] = list(
            map(lambda x: x["key"], muxSorter.enabledAudio))
        dict["Enabled_Tracks"]["Sub"] = list(
            map(lambda x: x["key"], muxSorter.enabledSub))

    for key in demuxData.sources:
        dict["Tracks_Details"] = {}
        dict["Tracks_Details"]["Audio"] = {}
        dict["Tracks_Details"]["Sub"] = {}
        dict["Tracks_Details"]["Video"] = {}
    for track in muxSorter.unSortedAudio:
        key = track["key"]
        track.pop("key")
        dict["Tracks_Details"]["Audio"][key] = track
    for track in muxSorter.unSortedSub:
        key = track["key"]
        track.pop("key")
        dict["Tracks_Details"]["Sub"][key] = track
    for track in muxSorter.unSortedVideo:
        key = track["key"]
        track.pop("key")
        dict["Tracks_Details"]["Video"][key] = track

    with open(os.path.join(".", "output.txt"), "w") as p:
        p.write(json.dumps(dict, indent=4))
