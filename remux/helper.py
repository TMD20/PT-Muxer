import os
import tempfile
from string import Template

from InquirerPy import inquirer

import mediadata.movieData as movieData
import tools.general as utils
import config


def getRemuxConfigs(path):
    demuxList = []
    folders=utils.findMatches(path,"Mux.*")


    if len(demuxList) == 0:
        print("Deep Search of Directory Could Not Find any output.json Files")
        quit()
    demuxList = sorted(demuxList)
    message= \
    """
    Select One or more Files to Remux
    
    These should be either one Movie or one Show
    Batching of Multiple shows or Movies Not supported

    Press Space to add/remove selection
    When Done Press Enter
    """

    return utils.multiSelectMenu(message=message, items=demuxList)


def chapterListParser(chapterList):
    tempData = tempfile.mkstemp()
    file = tempData[1]
    with open(file, "w") as p:
        for dict in chapterList:
            p.write(dict["time"])
            p.write("\n")
            p.write(dict["name"])
            p.write("\n")
    return tempData


def writeXMLMovie(imdb, tmdb):
    infile = os.path.join(config.root_dir,  f"xml/movie")

    tempData = tempfile.mkstemp()
    outfile = tempData[1]
    result = None
    with open(infile, 'r') as f:
        src = Template(f.read())
        result = src.substitute({"imdb": imdb, "tmdb": tmdb})
    with open(outfile, "w") as p:
        p.writelines(result)
    return tempData


def writeXMLTV(imdb, tmdb, season, episode):
    infile = os.path.join(config.root_dir, f"xml/movie")
    tempData = tempfile.mkstemp()
    outfile = tempData[1]
    result = None

    imdbEP = movieData.getEpisode(
        movieData.getByID(imdb), season, episode)["imdbID"]
    totalEP = movieData.getTotalEpisodes(movieData.getByID(imdb), season)

    with open(infile, 'r') as f:
        src = Template(f.read())
        result = src.substitute(
            {"imdb": imdb, "tmdb": tmdb, "imdbEP": imdbEP, "totalEP": totalEP})
    with open(outfile, "w") as p:
        p.writelines(result)
    return tempData


def checkMissing(remuxConfig):
    if utils.validateFiles([remuxConfig["Tracks_Details"]["Sub"][x]["file"] for x in remuxConfig["Enabled_Tracks"]["Sub"]]) != None:
        print("At Least one subtitle file is missing\nCheck file key for all enabled subs tracks\nSkipping to Next Item")
        return False
    if utils.validateFiles([remuxConfig["Tracks_Details"]["Audio"][x]["file"] for x in remuxConfig["Enabled_Tracks"]["Audio"]]) != None:
        print("At Least one audio file is missing\nCheck file key for all enabled audio tracks\nSkipping to Next Item")
        return False
    if utils.validateFiles([remuxConfig["Tracks_Details"]["Video"][x]["file"] for x in remuxConfig["Enabled_Tracks"]["Video"]]) != None:
        print("At Least one video file is missing\nCheck file key for all enabled video tracks\nSkipping to Next Item")
        return False
    if len([key for key in remuxConfig["Sources"]]) == 0:
        print("No Sources Found For this item\nSkipping to Next Item")
        return False
    return True
