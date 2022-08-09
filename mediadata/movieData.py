from lzma import MODE_FAST
import re
import os
import json

from dotenv import load_dotenv
from guessit import guessit
from imdb import Cinemagoer as imdb
from tmdbv3api import TMDb, Find, TV, Movie
from mal import AnimeSearch

import tools.general as utils
import config


load_dotenv()
tmdb = TMDb()
tmdb.api_key = os.environ.get("TMDB") or "e7f961054134e132e994eb5e611e454c"
find = Find()
movie = Movie()
tv = TV()
ia = imdb()
animeJson = os.path.join(
    config.root_dir, "anime-lists", "anime-list-full.json")


def getMovieName(movie):
    return guessit(movie["title"])["title"]


def getByID(id):
    return ia.get_movie(id)


def getMovieYear(movie):
    return movie["year"]


def matchMovie(sources):
    if utils.singleSelectMenu(["Yes", "No"], "Is this an anime?") == "Yes":
        matchMovieAnime(sources)
    else:
        matchMovieNormal(sources)


def matchMovieAnime(sources):
    details = guessit(sources[0])
    title = details.get("title")
    search = AnimeSearch(title)
    data = search.results
    results = [ele.title for ele in data]
    match = utils.singleSelectMenu(results, "Which Anime")
    malObj = list(filter(lambda x: x.title == match, data))[0]
    # create a new object
    movieObj = {}
    movieObj["mal"] = malObj.mal_id
    movieObj["anidb"] = None
    movieObj["tvdb"] = None
    movieObj = animeMatchData(movieObj, malObj, sources)


def animeMatchData(movieObj, malObj, sources):
    match = None
    with open(animeJson, "r") as p:
        data = json.loads(p.read())
        match = list(filter(lambda x: x.get("mal_id") == malObj.mal_id, data))
        if len(match) == 0:
            print(
                "Sorry we could not find a match in our list\nDoing a manual search for IMDB data")
            newMovie = matchMovieNormal(sources)
            movie["imdbID"] = newMovie["imdbID"]
            return movie
        match = match[0]
        movieObj["anidb"] = match["anidb_id"]
        # external tmdb only works with TV shows
        if match.get("thetvdb_id") and match.get("type") == "TV":
            movieObj["tvdb"] = match.get("thetvdb_id")
        if match.get("themoviedb_id"):
            movieObj["moviedb"] = match.get("themoviedb_id")
# We can gather imdb and tmdb via tvdb
    # check if we need to get tmdb
    if movieObj.get("tvdb") and not movieObj.get("tmdb"):
        data = find.find_by_tvdb_id(str(movieObj.get("tvdb")))
        results = []
        results.extend(data["movie_results"])
        results.extend(data["tv_results"])
        if len(results) > 0:
            movieObj["tmdb"] = results[0]["id"]

    # if we still don't have the ID
    # Search by title
    if not movieObj.get("tmdb"):
        if match.get("type") == "TV":
            movieObj["tmdb"] = tv.search(malObj.title)[0]["id"]
        elif match.get("type") == "MOVIE":
            movieObj["tmdb"] = movie.search(malObj.title)[0]["id"]
    if match.get("type") == "TV":
        movieObj["imdbID"] = re.sub("tt","",tv.external_ids(movieObj["tmdb"])["imdb_id"])
    else:
        movieObj["imdbID"] = re.sub(
            "tt", "", movie.external_ids(movieObj["tmdb"])["imdb_id"])
    return movieObj



def matchMovieNormal(sources):
    details = guessit(sources[0])
    title = details.get("title")
    results = ia.search_movie(title)
    if len(results) == 0:
        message =\
            """
        Unable to find movie
        Enter imdb id:
        """
        id = utils.textEnter(message)
        result = ia.get_movie(re.sub("tt", "", id))
    else:
        titles = list(map(lambda x: x["long imdb title"], results))
        titles.insert(0, "None of these Titles Match")
        match = utils.singleSelectMenu(titles, 'What Movie/TV Show')
        if match == "None of these Titles Match":
            message = \
                """
            Unable to find movie ID
            Enter imdb id
            """
            id = None
            try:
                id = utils.textEnter(message)
            except:
                print("id is invalid\n")

            result = ia.get_movie(re.sub("tt", "", id))
        else:
            result = results[titles.index(match)-1]

    ia.update(result, info=['main'])
    return result


def getKind(movie):
    kind = movie["kind"]
    if kind == "Movie" or kind == "tv movie" or kind == "video movie":
        return "Movie"
    else:
        return "tv"


def convertIMDBtoTMDB(id):
    if re.search("tt", id) == None:
        id = f"tt{id}"
    data = find.find_by_imdb_id(id)
    results = []
    results.extend(data["movie_results"])
    results.extend(data["tv_results"])

    if len(results) > 0:
        return results[0]["id"]


def getSeason(sources):
    details = guessit(sources[0])
    season = details.get("Season")
    return season


def getTotalEpisodes(episodes):
    return len(episodes.keys())


def getEpisodes(movie, season):
    ia.update(movie, 'episodes')
    return movie["episodes"][season]


def getEpisodeData(episodes, num):
    episode = episodes[num]
    ia.update(episode, info=['main'])
    return episode


def getEpisodeTitle(movie, season, episode):
    ia.update(movie, 'episodes')
    episode = movie["episodes"][season][episode]
    ia.update(episode, info=['main'])
    return episode


def getMovieTitle(movie):
    movieName = getMovieName(movie)
    movieYear = getMovieYear(movie)
    return f"{movieName} ({movieYear})"
