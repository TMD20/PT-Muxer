

import json
import re
import itertools

import remux.helper as remuxHelper
import mediadata.movieData as movieData
import mediatools.mkvtoolnix as mkvTool


def Remux(args):
    remuxConfig = None
    demuxList = remuxHelper.getOutputList(args.path)
    remuxConfigPath=remuxHelper.pickOutput(demuxList)
    with open(remuxConfigPath, "r") as p:
        remuxConfig = json.loads(p.read())
    sources=remuxHelper.getSources(remuxConfig)
    if len(sources) == 0:
        print("No Sources")
    movieName = movieData.getMovieName(sources)
    year = movieData.getYear(sources)
    movieTitle = f"{movieName} ({year})"
    chapters = remuxHelper.getChapterFile(remuxConfig)
    print(movieTitle)
    kind = movieData.getKind(movieTitle)
    videoCodec = mkvTool.getVideo(remuxConfig)
    audioCodec = mkvTool.getAudio(remuxConfig)
    audioChannel = mkvTool.getAudioChannel(remuxConfig)
    videoRes =  mkvTool.getVideoResolution(remuxConfig)
    fileName = None
    if kind == "movie":
        fileName = f"{movieName}.{year}.{videoRes}.REMUX.{videoCodec}.{audioCodec}.{audioChannel}-TMS.mkv"
        fileName = re.sub(" +", ".", fileName)

    tracks = [None,None,None]
    tracks[1] = mkvTool.addAudioTracks(remuxConfig)
    tracks[0] = mkvTool.addVideoTracks(remuxConfig)
    tracks[2]=mkvTool.addSubTracks(remuxConfig)
    tracks=list(itertools.chain.from_iterable(tracks))
    mkvTool.createMKV(movieTitle, chapters, fileName, tracks)


  











