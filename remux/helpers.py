# import os
# import tempfile
# from string import Template
# import re

# from InquirerPy import inquirer

# import mediadata.movieData as movieData
# import tools.general as utils
# import config
# import tools.paths as paths
# import tools.logger as logger



# def getRemuxConfigs(path):
#     demuxList = []
#     folders = paths.search(path, "Mux",dir=True)

#     if len(demuxList) == 0:
#         raise RuntimeError("Deep Search of Directory Could Not Find any output.json Files")


#     demuxList = sorted(demuxList)
#     message = \
#         """
#     Select One or more Files to Remux
    
#     These should be either one Movie or one Show
#     Batching of Multiple shows or Movies Not supported
#     """

#     return utils.multiSelectMenu(message=message, items=demuxList)


# def chapterListParser(chapterList):
#     if chapterList == None:
#         return
#     tempData = tempfile.mkstemp()
#     file = tempData[1]

#     with open(file, "w") as p:
#         for dict in chapterList:
#             p.write(dict["time"])
#             p.write("\n")
#             p.write(dict["name"])
#             p.write("\n")
#     return tempData


# def writeXMLMovie(imdb, tmdb):
#     infile = os.path.join(config.root_dir,  f"xml/movie")

#     tempData = tempfile.mkstemp()
#     outfile = tempData[1]
#     result = None
#     with open(infile, 'r') as f:
#         src = Template(f.read())
#         result = src.substitute({"imdb": imdb, "tmdb": tmdb})
#     with open(outfile, "w") as p:
#         p.writelines(result)
#     return tempData


# def writeXMLTV(imdb, tmdb, title, year, season, episode):
#     movieObj = movieData.MovieData()
#     infile = os.path.join(config.root_dir, f"xml/movie")
#     tempData = tempfile.mkstemp()
#     outfile = tempData[1]
#     result = None
#     epIMDB=movieObj.retriveEpisodeIMDB(imdb,tmdb, season, episode, title, year)

#     epCount = movieObj.retriveNumberofEpisodes(season,  title, year, tmdb)




#     with open(infile, 'r') as f:
#         src = Template(f.read())
#         result = src.substitute(
#             {"imdb": imdb, "tmdb": tmdb, "imdbEP": epIMDB, "totalEP": epCount, "Season": season, "Episode": episode})
#     with open(outfile, "w") as p:
#         p.writelines(result)
#     return tempData


# def checkMissing(remuxConfig):
#     if utils.validateFiles([remuxConfig["Tracks_Details"]["Sub"][x]["filename"] for x in remuxConfig["Enabled_Tracks"]["Sub"]]) != None:
#         logger.print("At Least one subtitle file is missing\nCheck file key for all enabled subs tracks\nSkipping to Next Item",style="bold red")
#         return True
#     if utils.validateFiles([remuxConfig["Tracks_Details"]["Audio"][x]["filename"] for x in remuxConfig["Enabled_Tracks"]["Audio"]]) != None:
#         logger.print("At Least one audio file is missing\nCheck file key for all enabled audio tracks\nSkipping to Next Item",style="bold red")
#         return True
#     if utils.validateFiles([remuxConfig["Tracks_Details"]["Video"][x]["filename"] for x in remuxConfig["Enabled_Tracks"]["Video"]]) != None:
#         logger.print("At Least one video file is missing\nCheck file key for all enabled video tracks\nSkipping to Next Item",style="bold red")
#         return True
#     if len([key for key in remuxConfig["Sources"]]) == 0:
#         logger.print("No Sources Found For this item\nSkipping to Next Item")
#         return True
#     return False


# def getFullPaths(remuxConfig, parentDir):
#     audioTrackKeys=remuxConfig["Enabled_Tracks"]["Audio"]
#     videoTrackKeys=remuxConfig["Enabled_Tracks"]["Video"]
#     subTrackKeys=remuxConfig["Enabled_Tracks"]["Sub"]
#     for key in audioTrackKeys:
#         remuxConfig["Tracks_Details"]["Audio"][key]["filename"] = os.path.join(parentDir, remuxConfig["Tracks_Details"]["Audio"][key]["filename"])
#     for key in videoTrackKeys:
#         remuxConfig["Tracks_Details"]["Video"][key]["filename"] = os.path.join(
#             parentDir, remuxConfig["Tracks_Details"]["Video"][key]["filename"])
#     for key in subTrackKeys:
#         remuxConfig["Tracks_Details"]["Sub"][key]["filename"] = os.path.join(
#             parentDir, remuxConfig["Tracks_Details"]["Sub"][key]["filename"])


# def getTVMuxFolders(inpath):
#     folders = paths.search(inpath, f"{config.demuxPrefix}[.]",dir=True,recursive=False)
#     folders=list(filter(lambda x: os.path.isdir(x),folders))
#     folders = list(filter(lambda x: len(os.listdir(x)) > 0, folders))
#     folders = list(filter(lambda x: re.search(
#         "^[0-9]+$", os.listdir(x)[0]) != None, folders))

#     return folders


# def getMovieMuxFolders(inpath):
    
#     return folders
# def overwriteIfExists(*args):
  
