

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
    remuxConfig = None
    tempdir = tempfile.TemporaryDirectory()
    mediainfo = os.path.join(tempdir.name,"media.txt")

 


    remuxConfigPath = remuxHelper.pickOutput(
        remuxHelper.getOutputList(args.inpath))
   

    with open(remuxConfigPath, "r") as p:
        remuxConfig = json.loads(p.read())
  
    sources = remuxHelper.getSources(remuxConfig)
    if len(sources) == 0:
        print("No Sources")
        quit()
    movie = movieData.matchMovie(sources)
  
  

    
    movieName = movieData.getMovieName(movie)
   
    movieYear = movieData.getMovieYear(movie)
    movieTitle = f"{movieName} ({movieYear})"
    chapters = remuxHelper.getChapterFile(remuxConfig)
    kind = movieData.getKind(movie)
    mediatype=mkvTool.getMediaType(remuxConfig)
    hdr = mkvTool.getHDR(remuxConfig)
    videoCodec = mkvTool.getVideo(remuxConfig)
    audioCodec = mkvTool.getAudio(remuxConfig)
    audioChannel = mkvTool.getAudioChannel(remuxConfig)
    videoRes = mkvTool.getVideoResolution(remuxConfig)
    fileName = muxGenerator.getFileName(
        kind,mediatype,hdr, args.outpath, movieName, movieYear, videoRes, videoCodec, audioCodec, audioChannel)
    muxGenerator.generateMuxData(remuxConfig)
 
    muxGenerator.createMKV(movieTitle, chapters, fileName, remuxConfig)
  
    
            

            
 
   



