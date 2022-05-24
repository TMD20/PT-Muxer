import re


from guessit import guessit
from imdb import Cinemagoer as imdb
from simple_term_menu import TerminalMenu


ia = imdb()

def getMovieName(sources):
    for source in sources:
        try:
            return guessit(source)["title"]
        except:
            continue
def getYear(sources):
    year=None
    for source in sources:
        details = guessit(source)
        year = details.get("year")
        if year!=None:
            return str(year)
    details = guessit(sources[0])
    title = details.get("title")
    results = ia.search_movie(title)
    if len(results) == 0:
        print("Unable to find imdb")
        id = input("Enter imdb: ")
        year = ia.get_movie(re.sub("tt", "", id))["year"]
    else:
        titles = list(map(lambda x: x["long imdb title"], results))
        menu = TerminalMenu(titles)
        index = None
        while index == None:
            index = menu.show()
        year = guessit(titles[index])["year"]
    return str(year)

def getKind(title):

    results = list(
        filter(lambda x: x["long imdb title"].lower() == title.lower(), ia.search_movie(title)))

    kind = results[0]["kind"]
    if kind == "movie" or kind == "tv movie" or kind == "video movie":
        return "movie"
    else:
        return "tv"
