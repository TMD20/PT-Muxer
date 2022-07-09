import re


from guessit import guessit
from imdb import Cinemagoer as imdb
from simple_term_menu import TerminalMenu


ia = imdb()

def getMovieName(movie):
    return guessit(movie["title"])["title"]


def getMovieYear(movie):
    return movie["year"]
def matchMovie(sources):
    details = guessit(sources[0])
    title = details.get("title")
    results = ia.search_movie(title)
    if len(results) == 0:
        print("Unable to find imdb")
        id = input("Enter imdb: ")
        return ia.get_movie(re.sub("tt", "", id))
    else:
        titles = list(map(lambda x: x["long imdb title"], results))
        menu = TerminalMenu(titles)
        index = None
        while index == None:
            index = menu.show()
        return results[index]


def getKind(movie):
    kind = movie["kind"]
    if kind == "movie" or kind == "tv movie" or kind == "video movie":
        return "movie"
    else:
        return "tv"

