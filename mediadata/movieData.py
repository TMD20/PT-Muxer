import re
import os

from dotenv import load_dotenv
from guessit import guessit
from imdb import Cinemagoer as imdb
from tmdbv3api import TMDb, Find

import tools.general as util


load_dotenv()
tmdb = TMDb()
tmdb.api_key = os.environ.get("TMDB") or "e7f961054134e132e994eb5e611e454c"
find = Find()
ia = imdb()

def getMovieName(movie):
    return guessit(movie["title"])["title"]

def getByID(id):
    return ia.get_movie(id)

def getMovieYear(movie):
    return movie["year"]
def matchMovie(sources):
    details = guessit(sources[0])
    title = details.get("title")
    results = ia.search_movie(title)
    if len(results) == 0:
        print("Unable to find imdb")
        id = input("Enter imdb: ")
        result=ia.get_movie(re.sub("tt", "", id))
    else:
        titles = list(map(lambda x: x["long imdb title"], results))
        match = None
        while match == None:
            match= util.Menu(titles,'What Movie/TV Show')
        result=results[titles.index(match)]
        
    ia.update(result, info=['main'])
    return result



def getKind(movie):
    kind = movie["kind"]
    if kind == "movie" or kind == "tv movie" or kind == "video movie":
        return "movie"
    else:
        return "tv"

def convertIMDBtoTMDB(id):
    if re.search("tt",id)==None:
        id=f"tt{id}"
    results = find.find_by_imdb_id(id)["movie_results"]
    if len(results)>0:
        return results[0]["id"]
def getSeason(sources):
    details = guessit(sources[0])
    season = details.get("season")
    return season
def getTotalEpisodes(movie,season):
    ia.update(movie, 'episodes')
    return len(movie["episodes"][season].keys())


def getEpisode(movie, season,episode):
    ia.update(movie, 'episodes')
    episode = movie["episodes"][season][episode]
    ia.update(episode, info=['main'])
    return episode


def getMovieTitle(movie):
    movieName = getMovieName(movie)
    movieYear = getMovieYear(movie)
    return f"{movieName} ({movieYear})"

  
