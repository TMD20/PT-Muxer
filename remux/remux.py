

import json
import subprocess
import os
import tempfile

import tools.muxHelpers as remuxHelper
import mediadata.movieData as movieData
import mediatools.mkvtoolnix as mkvTool
import sites.pickers.siteMuxPicker as muxPicker


def Remux(args):
    muxGenerator = muxPicker.pickSite(args.site)
    remuxConfig = getRemuxConfig(args.inpath)
    
    sources = remuxHelper.getSources(remuxConfig)
    if len(sources) == 0:
        print("No Sources")
        quit()
    chapters = remuxHelper.getChapterFile(remuxConfig)
    Process(remuxConfig,muxGenerator,chapters,args.outpath,args.group)

def getRemuxConfig(inpath):
    remuxConfig = None
    
    remuxConfigPath = remuxHelper.pickOutput(
        remuxHelper.getOutputList(inpath))

    with open(remuxConfigPath, "r") as p:
        remuxConfig = json.loads(p.read())
    return remuxConfig
   
def Process(remuxConfig,muxGenerator,chapters,outpath,group):
    movie = movieData.getByID(remuxConfig["Movie"]["imdb"])

    movieName = movieData.getMovieName(movie)

    movieYear = movieData.getMovieYear(movie)
    movieTitle = f"{movieName} ({movieYear})"
    kind = movieData.getKind(movie)
    mediatype = mkvTool.getMediaType(remuxConfig)
    hdr = mkvTool.getHDR(remuxConfig)
    videoCodec = mkvTool.getVideo(remuxConfig)
    audioCodec = mkvTool.getAudio(remuxConfig)
    audioChannel = mkvTool.getAudioChannel(remuxConfig)
    videoRes = mkvTool.getVideoResolution(remuxConfig)
    fileName = muxGenerator.getFileName(
        kind, mediatype, hdr, outpath, movieName, movieYear, videoRes, videoCodec, audioCodec, audioChannel,group)
    muxGenerator.generateMuxData(remuxConfig)

    muxGenerator.createMKV(movieTitle, chapters, fileName, remuxConfig)
    print(f"New File Finished at: {fileName}")
