import os
import json
import re


import mediatools.bdinfo as bdinfo
import mediatools.eac3to as eac3to
import sites.pickers.siteDataPicker as siteDataPicker
import sites.pickers.siteSortPicker as siteSortPicker
import mediadata.movieData as movieData
import subtitles.subreader as subreader
import transcription.voiceRecord as voiceRec
import tools.general as utils
import demux.helper as demuxHelper
import config


def demux(args):
    args.audiolang = list(map(lambda x: x.lower(),  args.audiolang))
    args.sublang = list(map(lambda x: x.lower(),  args.sublang))

    #make the output directory if needed
    utils.mkdirSafe(args.outpath)
    os.chdir(args.outpath)

    options = demuxHelper.getBDMVs(args.inpath)
    demuxData = siteDataPicker.pickSite(args.site)
    muxSorter = siteSortPicker.pickSite(args.site)
    sources = getSources(options, args.inpath, args.sortpref)
    print("What Movie?\n\n")
    movie = movieData.matchMovie(sources)
    print("Creating Demux Folder at\n")
    os.chdir(demuxHelper.createParentDemuxFolder(sources, args.outpath))
    print(os.path.abspath("."))

    bdObjs=getBdinfoData(sources)
    processBdinfo(sources,bdObjs,demuxData,args.donconvert)
    extractTracks(demuxData)
    sortTracks(muxSorter, demuxData, movie, args)
    machineReader(muxSorter, args, movie)
    finalizeOutput(muxSorter, demuxData, movie)


def getSources(options, inpath, sortpref):
    print("Add Sources For Movie Demux\n")
    sources = demuxHelper.addSource(options, sortpref)
    if sources == None or len(sources) == 0:
        print("No sources Selected")
        quit()
    for i in range(0, len(sources)):
        if re.search(".iso", sources[i]):
            sources[i] = demuxHelper.Extract(sources[i], inpath)
    return sources


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
    
        
def processBdinfo(sources, bdObjs, demuxData,dontConvert):
    for i in range(len(sources)):
        source=sources[i]
        bdObj=bdObjs[i]
        output = demuxHelper.createChildDemuxFolder(os.getcwd(), source)
        os.chdir(output)
        show=utils.getShowName(source)
        path = os.path.join(
            output, "output_logs", f"BDINFO.{show}.txt")
        print(f"Extracting BDINFO from {source}")
        bdObj.writeBdinfo(path)
        quickSums = bdObj.getQuickSum()
        currentTracks=demuxData.addTracks(
            quickSums, bdObj.playlistNum, bdObj.playlistFile, source, output)
        if not dontConvert:
            demuxData.convertFlac(currentTracks, output)

        os.chdir("..")



def extractTracks(demuxData):

    # Extract Using eac3to
    print("Running Eac3to on all sources")
    for key in demuxData.sources:
        trackoutdict = demuxData.filterBySource(key)
        eac3to_list = []
        for track in trackoutdict["tracks"]:
            eac3to_list.append((track["index"], track["eac3to"].split(":")[1]))
            if track.get("eac3to_extras"):
                eac3to_list.extend(track["eac3to_extras"])
        print(f"Extracting Files From {key}")
        # get playlist location
        playlistLocation = os.path.join(os.path.dirname(
            trackoutdict["sourceDir"]), "PLAYLIST", trackoutdict["playlistFile"])

        eac3to.process(trackoutdict["sourceDir"], trackoutdict["outputDir"],
                       eac3to_list, playlistLocation)


def sortTracks(muxSorter, demuxData, movie, args):
    # Sort/enable Tracks Based on Site
    muxSorter.tracksDataObj = demuxData
    muxSorter.sortTracks(movie["languages"],
                         args.audiolang, args.sublang, args.sortpref)
    muxSorter.addForcedSubs(movie["languages"], args.audiolang)


def machineReader(muxSorter, args, movie):
    # Add OCR for Subtitles

    if args.ocr == "enabled":
        subreader.subreader(muxSorter.enabledSub, keep=args.keepocr)
    elif args.ocr == "default":
        subreader.subreader(muxSorter.unSortedSub,
                            langs=movie["languages"], keep=args.keepocr)
    elif args.ocr == "sublang":
        subreader.subreader(muxSorter.unSortedSub,
                            langs=args.sublang, keep=args.keepocr)
    elif args.ocr == "english":
        subreader.subreader(muxSorter.unSortedSub, langs=[
                            "English"], keep=args.keepocr)
    elif args.ocr == "all":
        subreader.subreader(muxSorter.unSortedSub, keep=args.keepocr)
    elif args.keepocr:
        subreader.imagesOnly(muxSorter.enabledSub)

   # Voice Recorder

    if args.voicerec == "enabled":
        voiceRec.main(muxSorter.enabledAudio)
    elif args.voicerec == "default":
        voiceRec.main(muxSorter.unSortedAudio, movie["languages"])
    elif args.voicerec == "audiolang":
        voiceRec.main(muxSorter.unSortedAudio, args.audiolang)
    elif args.voicerec == "english":
        voiceRec.main(muxSorter.unSortedAudio, ["English"])
    elif args.voicerec == "all":
        voiceRec.main(muxSorter.unSortedAudio)


def finalizeOutput(muxSorter, demuxData, movie, season=None, episode=None):
    # Export
    # Movie Info Section

    outdict = {}
    outdict["Movie"] = {}
    outdict["Movie"]["year"] = movie["year"]
    outdict["Movie"]["imdb"] = movie["imdbID"]
    outdict["Movie"]["tmdb"] = movieData.convertIMDBtoTMDB(movie["imdbID"])
    outdict["Movie"]["langs"] = movie["languages"]
    if episode:
        outdict["Season"] = season
        outdict["Episode"] = episode

    # Sources Section
    outdict["Sources"] = {}
    for key in demuxData.sources:
        trackObj = demuxData.filterBySource(key)
        outdict["Sources"][key] = {}
        outdict["Sources"][key]["outputDir"] = trackObj["outputDir"]
        outdict["Sources"][key]["sourceDir"] = trackObj["sourceDir"]
        outdict["Sources"][key]["playlistNum"] = trackObj["playlistNum"]
    # Chapters
    outdict["ChapterData"] = demuxHelper.CreateChapterList(
        *[demuxData.filterBySource(key)["outputDir"] for key in demuxData.sources])

    # Enabled Track Section
    outdict["Enabled_Tracks"] = {}
    outdict["Enabled_Tracks"]["Video"] = list(
        map(lambda x: x["key"], muxSorter.enabledVideo))
    outdict["Enabled_Tracks"]["Audio"] = list(
        map(lambda x: x["key"], muxSorter.enabledAudio))
    outdict["Enabled_Tracks"]["Sub"] = list(
        map(lambda x: x["key"], muxSorter.enabledSub))

    # Track List Section
    outdict["Tracks_Details"] = {}
    outdict["Tracks_Details"]["Audio"] = {}
    outdict["Tracks_Details"]["Sub"] = {}
    outdict["Tracks_Details"]["Video"] = {}

    for track in muxSorter.unSortedAudio:
        key = track["key"]
        track.pop("key")
        outdict["Tracks_Details"]["Audio"][key] = track
    for track in muxSorter.unSortedSub:
        key = track["key"]
        track.pop("key")
        outdict["Tracks_Details"]["Sub"][key] = track

    for track in muxSorter.unSortedVideo:
        key = track["key"]
        track.pop("key")
        outdict["Tracks_Details"]["Video"][key] = track
    outputPath = os.path.abspath(os.path.join(".", "output.json"))
    print(f"Writing to {outputPath}")
    print("If this is a TV show double check episode in json")
    with open(outputPath, "w") as p:
        p.write(json.dumps(outdict, indent=4, ensure_ascii=False))
