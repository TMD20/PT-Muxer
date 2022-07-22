import json
import os

from pymediainfo import MediaInfo

import remux.helper as remuxHelper
import mediadata.movieData as movieData
import sites.pickers.siteMuxPicker as muxPicker
import tools.general as util


def Remux(args):
    #Variables
    remuxConfigPaths = remuxHelper.getRemuxConfigs(args.inpath)
    movie=None
    if not remuxConfigPaths or len(remuxConfigPaths)==0:
        print("You Must Pick at list one Config")
        quit()

    fileNameList = []
    movieTitleList=[]
    util.mkdirSafe(os.path.join(args.outpath, ""))
    for remuxConfigPath in remuxConfigPaths:
        print(f"\nPreparing Data for {remuxConfigPath}\n")

        remuxConfig = None
        muxGenerator = muxPicker.pickSite(args.site)

        with open(remuxConfigPath, "r") as p:
            remuxConfig = json.loads(p.read())
            
        if remuxHelper.checkMissing(remuxConfig) == False:
            continue
        if movie==None:
            movie = movieData.getByID(remuxConfig["Movie"]["imdb"])
        kind = movieData.getKind(movie)
        os.chdir(args.outpath)
        fileName = muxGenerator.getFileName(kind, remuxConfig, movie, args.group)
        fileNameList.append(fileName)
        movieTitleList.append(movieData.getMovieTitle(movie))
    print("\nAll Data is Prepared\nNext Step is Creating the MKV(s)")
    for i in range(len(fileNameList)):
        fileName=fileNameList[i]
        movieTitle=movieTitleList[i]
        muxGenerator = muxPicker.pickSite(args.site) 
        ProcessBatch(fileName, movieTitle, kind, remuxConfig, muxGenerator)
    print("\nIf the Program made it this far all MKV(s)...\nShould be in the output directory picked \
    \nBefore Closing We will now print off filelocations and mediainfo")
    for ele in fileNameList:
         print(f"New Files at {ele}\n")
         mediainfo = MediaInfo.parse(ele, output="", full=False)
         print(f"\n\n{mediainfo}\n\n")
    print(f"As a Reminder the output Directory is: {args.output}" )
    
    



def ProcessBatch(fileName,movieTitle,kind,remuxConfig,muxGenerator):
    #Variables
    chaptersTemp = remuxHelper.chapterListParser(remuxConfig["ChapterData"])

    xmlTemp = None
    if kind=="movie":
        xmlTemp = remuxHelper.writeXMLMovie(
            remuxConfig["Movie"]["imdb"], remuxConfig["Movie"]["tmdb"])
    else:
        season=remuxConfig["Season"]
        episode=remuxConfig["Episode"]
        xmlTemp = remuxHelper.writeXMLTV(
            #imdb,tmdb,season,episode
            remuxConfig["Movie"]["imdb"], remuxConfig["Movie"]["tmdb"], season,episode) 

    muxGenerator.generateMuxData(remuxConfig)

    muxGenerator.createMKV(fileName, movieTitle,
                           chaptersTemp[1], xmlTemp[1],  util.getBdinfo(remuxConfig), util.getEac3to(remuxConfig))

    os.close(chaptersTemp[0])
    os.close(xmlTemp[0])
   

    



    




   
   
   
   
   
  
  