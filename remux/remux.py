import tools.general as utils
import remux.Movie.remuxMovie as movieRemux
import remux.TV.remuxTV as tvRemux


def Remux(args):
    # Variables
    remuxConfigPaths = []
    remuxConfigs = []
    movie = None
    if args.forcemovie:
        movieRemux.Remux(args)



    elif utils.singleSelectMenu(["Movie", "TV"], "What Type of Media do you want to Remux?") == "Movie":
        movieRemux.Remux(args)
    else:
        tvRemux.Remux(args)

#         folders = utils.getMovieMuxFolders(args.inpath, config.demuxPrefix)
#         if len(folders) == 0:
#             print("You need to demux a folder with Movie Mode first")
#             quit()
#         remuxConfigPaths.append(os.path.join(utils.singleSelectMenu(
#             folders, "Pick a folder to demux"), "output.json"))

#     else:
#         folders = utils.getTVMuxFolders(args.inpath, config.demuxPrefix)
#         if len(folders) == 0:
#             print("You need to demux a folder with TV Mode first")
#             quit()
#         folder = utils.singleSelectMenu(folders, "Pick a folder to demux")
#         remuxConfigPaths.extend(
#             list(map(lambda x: os.path.join(folder, x, "output.json"), os.listdir(folder))))
#     # double check to make sure every path is current
#     remuxConfigPaths = list(
#         filter(lambda x: os.path.isfile(x), remuxConfigPaths))

#     if not remuxConfigPaths or len(remuxConfigPaths) == 0:
#         print("You Must Pick at list one Config")
#         quit()

#     fileNameList = []
#     movieTitleList = []
#     fileNameFuncts=[]
#     utils.mkdirSafe(os.path.join(args.outpath, ""))
#     for remuxConfigPath in remuxConfigPaths:
#         print(f"\nPreparing Data for {remuxConfigPath}\n")

#         remuxConfig = None
#         muxGenerator = muxPicker.pickSite(args.site)

#         with open(remuxConfigPath, "r") as p:
#             remuxConfig = json.loads(p.read())

#         if remuxHelper.checkMissing(remuxConfig) == False:
#             continue
#         remuxConfigs.append(remuxConfig)
#         if movie == None:
#             movie = movieData.getByID(remuxConfig["Movie"]["imdb"])
#         kind = args.forcemovie or movieData.getKind(movie)
#         os.chdir(args.outpath)

#         fileNameFuncts.append(functools.partial( muxGenerator.getFileName,kind, remuxConfig, movie, args.group,args.skipnamecheck))
#         movieTitleList.append(movieData.getMovieTitle(movie))
#     for i in range(len(fileNameFuncts)):
#         funct=fileNameFuncts[i]
#         fileNameList.append(funct())
#     print("\nAll Data is Prepared\nNext Step is Creating the MKV(s)")
#     for i in range(len(fileNameList)):
#         fileName = fileNameList[i]
#         print(f"Creating this File\n{fileName}")
#         movieTitle = movieTitleList[i]
#         muxGenerator = muxPicker.pickSite(args.site)
#         remuxConfig = remuxConfigs[i]
#         ProcessBatch(fileName, movieTitle, kind,
#                      remuxConfig, muxGenerator, args.outargs)
#     message = """If the Program made it this far all MKV(s)...
#     Should be in the output directory picked \
#     Before Closing We will now print off file locations and mediainfo"""
#     print(message)
#     for ele in fileNameList:
#         print(f"New Files at {ele}\n")
#         mediainfo = MediaInfo.parse(ele, output="", full=False)
#         print(f"\n\n{mediainfo}\n\n")
#     print(f"As a Reminder the output Directory is: {args.outpath}")


# def ProcessBatch(fileName, movieTitle, kind, remuxConfig, muxGenerator, outargs):
#     # Variables
#     chaptersTemp = remuxHelper.chapterListParser(remuxConfig["ChapterData"])

#     xmlTemp = None
#     if kind == "Movie":
#         xmlTemp = remuxHelper.writeXMLMovie(
#             remuxConfig["Movie"]["imdb"], remuxConfig["Movie"]["tmdb"])
#     else:
#         season = remuxConfig["Season"]
#         episode = remuxConfig["Episode"]
#         xmlTemp = remuxHelper.writeXMLTV(
#             # imdb,tmdb,season,episode
#             remuxConfig["Movie"]["imdb"], remuxConfig["Movie"]["tmdb"], season, episode)

#     muxGenerator.generateMuxData(remuxConfig, outargs)
#     if chaptersTemp:
#         muxGenerator.createMKV(fileName, movieTitle,
#                                chaptersTemp[1], xmlTemp[1],  utils.getBdinfo(remuxConfig), utils.getEac3to(remuxConfig))

#         os.close(chaptersTemp[0])
#     else:
#         muxGenerator.createMKV(fileName, movieTitle,
#                                None, xmlTemp[1],  utils.getBdinfo(remuxConfig), utils.getEac3to(remuxConfig))
#     os.close(xmlTemp[0])
