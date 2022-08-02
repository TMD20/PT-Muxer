import os
import json
import re
import tempfile


from num2words import num2words

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
    options = demuxHelper.getBDMVs(args.inpath)

    # make the output directory if needed
    utils.mkdirSafe(args.outpath)
    os.chdir(args.outpath)

    sources = getSources(options, args.inpath, args.sortpref)
    demuxFolder = getDemuxFolder(sources, args.inpath, args.outpath)
    movie = movieData.matchMovie(sources)
    season = int(utils.getIntInput("Enter Season Number: "))
    while True:
        bdObjs = getBdinfoData(sources)
        validateBdinfo(bdObjs)
        offset = len(os.listdir(demuxFolder))
        if not args.splitplaylist:
            batchSources(bdObjs, sources, args, demuxFolder,
                       movie, season, offset=offset)
        elif args.splitplaylist and len(bdObjs) > 1:
            print("You may only pick one playlist if splitplaylist is on")
        else:
            batchStreams(bdObjs[0], sources[0], args, demuxFolder,
                         movie, season, offset=offset)

        if utils.singleSelectMenu(["Yes", "No"], "Extract more playlist") == "No":
            break
        if utils.singleSelectMenu(["Yes", "No"], "Change Sources") == "Yes":
            sources = getSources(options, args.inpath, args.sortpref)
        offset = len(os.listdir(demuxFolder))
        message =\
            f"""
        You have extracted  {nums2words(offset)} playlist(s) Thus Far
        The bext set of playlist will start from {offset+1}

        The playlist for every source will be reset
        You may pick a new set of playlist
        """
        print(message)


def batchStreams(bdObj, source, args, demuxFolder, movie, season, offset=0):
    # outter loop through every playlist
    for i in range(len(bdObj.playlistNumList)):
        playlistNum = bdObj.playlistNumList[i]
        playlistFile = bdObj.playlistFileList[i]

        print(
            f"Processing all streams from playlist number {num2words(playlistNum)}\n")

        # get quick summary and bdinfo data
        bdObj.runbdinfo(playlistNum)
        quickSums = bdObj.getQuickSum()
        streams = bdObj.getStreams()

        for j in range(len(streams)):
            demuxData = siteDataPicker.pickSite(args.site)
            muxSorter = siteSortPicker.pickSite(args.site)
            stream = streams[j]
            # create a episode folder
            ep = i+j+offset+1
            newFolder = os.path.join(demuxFolder, str(ep))
            utils.mkdirSafe(newFolder)
            os.chdir(newFolder)
            print(f"Creating a new episode folder at {newFolder}\n")

            # create a source folder
            output = demuxHelper.createChildDemuxFolder(os.getcwd(), source)
            print(f"\nCreating a new source folder at {output}")
            os.chdir(output)
            show = utils.getShowName(source)
            path = os.path.join(output, "output_logs", f"BDINFO.{show}.txt")

            # copy bdinfo to folder
            print(f"\nParsing BDINFO from {source}")
            bdObj.writeBdinfo(path)



            currentTracks = demuxData.addTracks(quickSums, playlistNum,playlistFile,
                                                 [stream["name"]], source, output)
            if not args.dontconvert:
                        demuxData.convertFlac(currentTracks, output)

            extractTracks(demuxData, stream=True)
            sortTracks(muxSorter, demuxData, movie, args)
            machineReader(muxSorter, args, movie)
            finalizeOutput(muxSorter, demuxData, movie, season, ep)
    # change pack to parent
    os.chdir(demuxFolder)




       
            


       


def batchSources(bdObjs, sources, args, demuxFolder,movie,season, offset=1):
    print("What TV Show?")
    # outter loop is for each episdoe
    for i in range(len(bdObjs[0].playlistNumList)):  
        ep=i+offset+1
        print(f"Processing Episode Number {num2words(ep)}\n")
        newFolder = os.path.join(demuxFolder, str(ep))
        print(f"Creating a new episode folder at {newFolder}")
        demuxData = siteDataPicker.pickSite(args.site)
        muxSorter = siteSortPicker.pickSite(args.site)
        utils.mkdirSafe(newFolder)
        os.chdir(newFolder)
        # inner loop is for each source
        for j in range(len(sources)):
            source = sources[j]   
            bdObj = bdObjs[j]
            playlistNum = bdObj.playlistNumList[i]
            playlistFile = bdObj.playlistFileList[i]
            print(f"Processing Playlist Number {num2words(playlistNum)}\n")

            

            # get the current playlist/Write bdinfo
           
            bdObj.runbdinfo(playlistNum)
            output = demuxHelper.createChildDemuxFolder(os.getcwd(), source)
            print(f"\nCreating a new source folder at {output}")
            os.chdir(output)
            show = utils.getShowName(source)
            path = os.path.join(output, "output_logs", f"BDINFO.{show}.txt")
            print(f"\nParsing BDINFO from {source}")
            bdObj.writeBdinfo(path)
            quickSums = bdObj.getQuickSum()
            streams=bdObj.getStreams()
            streams=list(map(lambda x:x["name"],streams))

            # parse data
            
            
            currentTracks=demuxData.addTracks(quickSums, playlistNum,
                                playlistFile,streams ,source, output)
            if not args.dontconvert:
                demuxData.convertFlac(currentTracks, output)
            os.chdir(newFolder)

        extractTracks(demuxData)
        sortTracks(muxSorter, demuxData, movie, args)
        machineReader(muxSorter, args, movie)
        finalizeOutput(muxSorter, demuxData, movie, season, ep)
    # change pack to parent
    os.chdir(demuxFolder)


def getDemuxFolder(sources, inpath, outpath):
    if utils.singleSelectMenu(["Yes", "No"], "Restore Folder Old MuxFolder Data") == "Yes":
        print("Searching for Prior TV Mode Folders")
        folders = utils.getTVMuxFolders(inpath, config.demuxPrefix)
        if len(folders) == 0:
            print("No TV Mode Folders Found To Restore")
            print("Creating a new Mux Folder")
            return demuxHelper.createParentDemuxFolder(
                sources, outpath)
        else:
            folder = utils.singleSelectMenu(
                folders, "Which Folder Do you want to Restore")

            return folder
    else:
        return demuxHelper.createParentDemuxFolder(sources, outpath)


def getSources(options, inpath, sortpref):
    sources = demuxHelper.addSource(options, sortpref)
    if sources == None or len(sources) == 0:
        print("No sources Selected")
        quit()
    for i in range(0, len(sources)):
        if re.search(".iso", sources[i]):
            sources[i] = demuxHelper.Extract(sources[i], inpath)
    return sources


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


def validateBdinfo(bdObjs):
    num = len(bdObjs[0].playlistNumList)
    if num == 0:
        print("A list has no playlist entered")
    for bdObj in bdObjs:
        if len(bdObj.playlistNumList) != num:
            message = \
                """
           One or more sources has an additional playlist
           Make sure every playlist is in sync 
           """
            print(message)
            quit()




def extractTracks(demuxData,stream=False):

    # Extract Using eac3to
    print("\nRunning Eac3to on all sources")
    for key in demuxData.sources:
        trackoutdict = demuxData.filterBySource(key)
        eac3to_list = []
        for track in trackoutdict["tracks"]:
            eac3to_list.append((track["index"], track["eac3to"].split(":")[1]))
            if track.get("eac3to_extras"):
                eac3to_list.extend(track["eac3to_extras"])
        if stream==False:
            # get playlist location
            playlistfile=trackoutdict["playlistFile"]
            playlistLocation = os.path.join(os.path.dirname(
                trackoutdict["sourceDir"]), "PLAYLIST", playlistfile)
            print(f"\nExtracting Files From playlist:{playlistfile} from {key}")
            eac3to.process(trackoutdict["sourceDir"], trackoutdict["outputDir"],
                        eac3to_list, playlistLocation)
        else:
            stream = trackoutdict["streamFiles"][0].lower()
            streamLocation = os.path.join(os.path.dirname(
                trackoutdict["sourceDir"]), "STREAM", stream)
            print(
                f"\nExtracting Files From stream:{stream} from {key}")
            eac3to.process(trackoutdict["sourceDir"], trackoutdict["outputDir"],
                        eac3to_list, streamLocation)


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
