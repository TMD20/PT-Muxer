import os
import json

import mediatools.eac3to as eac3to
import mediadata.movieData as movieData
import subtitles.subreader as subreader
import transcription.voiceRecord as voiceRec
import tools.general as utils


def ConvertChapterList(chapters):
    output = []
    if len(chapters) == 0:
        return output
    numoffset = int(chapters[0]["number"])-1
    timeoffset = utils.convertArrow(chapters[0]["start"], "HH:mm:ss.SSS")
    for i in range(len(chapters)):
        chapter = chapters[i]
        timeVar = chapter["start"]
        timeVar = utils.convertArrow(timeVar, "HH:mm:ss.SSS")
        timeVar = utils.subArrowTime(timeVar, timeoffset)
        timeVar = timeVar.format("HH:mm:ss.SSS")
        numVar = int(chapter["number"])-numoffset
        nameString = f"CHAPTER{numVar:02d}NAME=Chapter {numVar:02d}"
        timeString = f"CHAPTER{numVar:02d}={timeVar}"
        output.append({"time": timeString, "name": nameString})
    return output



    return outdict
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


def extractTracks(demuxData, stream=False):

    # Extract Using eac3to
    print("\nRunning Eac3to on all sources")
    for key in demuxData.sources:
        trackoutdict = demuxData.filterBySource(key)
        eac3to_list = []
        for track in trackoutdict["tracks"]:
            eac3to_list.append((track["index"], track["eac3to"].split(":")[1]))
            if track.get("eac3to_extras"):
                eac3to_list.extend(track["eac3to_extras"])
        if stream == False:
            # get playlist location
            playlistfile = trackoutdict["playlistFile"]
            playlistLocation = os.path.join(os.path.dirname(
                trackoutdict["sourceDir"]), "PLAYLIST", playlistfile)
            print(
                f"\nExtracting Files From playlist:{playlistfile} from {key}")
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


def addEnabledData(outdict, muxSorter):
    # Enabled Track Section
    outdict["Enabled_Tracks"] = {}
    outdict["Enabled_Tracks"]["Video"] = list(
        map(lambda x: x["key"], muxSorter.enabledVideo))
    outdict["Enabled_Tracks"]["Audio"] = list(
        map(lambda x: x["key"], muxSorter.enabledAudio))
    outdict["Enabled_Tracks"]["Sub"] = list(
        map(lambda x: x["key"], muxSorter.enabledSub))


def addSourceData(demuxData):
    outdict = {}
    for key in demuxData.sources:
       trackObj = demuxData.filterBySource(key)
       #get length

       outdict[key] = {}
       outdict[key]["outputDir"] = trackObj["outputDir"]
       outdict[key]["sourceDir"] = trackObj["sourceDir"]
       outdict[key]["playlistNum"] = trackObj["playlistNum"]
       outdict[key]["playlistFile"] = trackObj["playlistFile"]
       outdict[key]["streamFiles"] = trackObj["streamFiles"]
       outdict[key]["length"] = trackObj["length"]

    return outdict


def addTrackData(outdict, muxSorter):
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


def writeFinalJSON(outdict):
    outputPath = os.path.abspath(os.path.join(".", "output.json"))
    print(f"Writing to {outputPath}")
    with open(outputPath, "w") as p:
        p.write(json.dumps(outdict, indent=4, ensure_ascii=False))


def sortTracks(muxSorter, demuxData, movie, args):
    # Sort/enable Tracks Based on Site
    muxSorter.tracksDataObj = demuxData
    languages=movie.get("languages", [])
    muxSorter.sortTracks(languages,
                         args.audiolang, args.sublang, args.sortpref)
    muxSorter.addForcedSubs(languages, args.audiolang)


def machineReader(muxSorter, args, movie):
    # Add OCR for Subtitles

    if args.ocr == "enabled":
        subreader.subreader(muxSorter.enabledSub, keep=args.keepocr)
    elif args.ocr == "default":
        subreader.subreader(muxSorter.unSortedSub,
                            langs=movie.get("languages",[]), keep=args.keepocr)
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
