import json
import os

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
    Process(remuxConfig, muxGenerator, args.outpath, args.group)


def getRemuxConfig(inpath):
    remuxConfig = None

    remuxConfigPath = remuxHelper.pickOutput(
        remuxHelper.getOutputList(inpath))

    with open(remuxConfigPath, "r") as p:
        remuxConfig = json.loads(p.read())
    return remuxConfig


def Process(remuxConfig, muxGenerator, outpath, group):
    chaptersTemp = remuxHelper.chapterListParser(remuxConfig["ChapterData"])
    chapters=chaptersTemp[1]
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

    xmlTemp = remuxHelper.writeXML(
        remuxConfig["Movie"]["imdb"], remuxConfig["Movie"]["tmdb"], kind)
    xml=xmlTemp[1]
    fileName = muxGenerator.getFileName(
        kind, mediatype, hdr, outpath, movieName, movieYear, videoRes, videoCodec, audioCodec, audioChannel, group)
    muxGenerator.generateMuxData(remuxConfig)

    muxGenerator.createMKV(fileName, movieTitle,
                           chapters, xml,  remuxHelper.getBdinfo(remuxConfig), remuxHelper.getEac3to(remuxConfig))
    os.close(chaptersTemp[0])
    os.close(xmlTemp[0])
    print(f"New File Finished at: {fileName}")
