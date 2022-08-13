import string
import requests_cache
import requests
import re
import json
import os

import tools.general as utils
from bs4 import BeautifulSoup
import jellyfish
from imdb import Cinemagoer as imdb

import config
# Globals
ia = imdb()
requests_cache.install_cache('cache')
# epNum=10
# season=2
# url = getURL(show)
# # get all seasons
# t = getWikepediaSections(url)
# # get episodes for one season
# r = getEpisodesHTML(t[season], url)
# # get total episodes for one season
# x = getTotalEpisodesSeason(r)
# p = getJapaneseName(r[epNum])
# p = getEnglishName(r[epNum])
# print(getSeasonStartAirDate(r))
# l = getOriginalAirDate(r[epNum])
# print(l)
# o = getOverallPlace(t, season, epNum, url)

# print(getIMdb(l, epNum,season))
# print(getIsAnime(url))


class MovieData():
    def __init__(self, title, type):
        self._type = type
        self._title = title
        self._episodesURL = ""
        self._showURL = ""
        self._movieObj = {}
        self._seasonsHTML = []

    ##########################################################################
    # Public Function
    ########################################################################################

    def setData(self):
        self._getShowURL()
        if self._showURL != "" and self._getIsAnime() == True:
            self._getAnimeInfo()
        else:
            self._getIMDBInfo()

    def retriveTitle(self, season=None, episode=None):
        if self._type == "Movie":
            return self._title
        else:
            try:
                return self.getEpisodeName(season, episode)
            except:
                None
            # add another function from tmdb

    def retriveIMDB(self, imdb, season=None, episode=None):
        if self._type == "Movie":
            return imdb
        else:
            try:
                return self.getEpisodeIMDB(imdb, season, episode)
            except:
                None
            # add another function from tmdb

    def getEpisodeName(self, season, episode):
        self._getEpisodesURLWiki()
        self._getWikepediaSeasons()
        seasonData = self._getEpisodesHTMLWiki()
        return self._getEnglishNameWiki(seasonData[episode])

    def getEpisodeIMDB(self, imdb, season, episode):
        self._getEpisodesURLWiki()
        self._getWikepediaSeasons()
        seasonData = self._getEpisodesHTMLWiki(season)

        return self._getIMDBWiki(imdb, season, episode)
        # imdb=getIMDB()

    """
    Getters/Setters
    """

    @property
    def movieObj(self):
        return self._movieObj

##########################################################################
# Private Functions
#
########################################################################################

    # Wikepedia functions

    def _getShowURL(self):
        url = "https://en.wikipedia.org/w/api.php"
        pageList = [string.Template("$title")]

        for ele in pageList:
            PARAMS = {
                "prop": "sections",
                "format": "json",
                "page": ele.substitute(title=self._title),
                "action": "parse",
                "redirects": "1"
            }
            req = config.session.get(url, params=PARAMS)
            if req.json().get("error"):
                continue

            self._showURL = f"{url}?page={req.json()['parse']['title']}"
            break

    def _getEpisodesURLWiki(self):
        url = "https://en.wikipedia.org/w/api.php"
        pageList = [string.Template(
            "List of $title episodes"), string.Template("$title")]

        for ele in pageList:

            PARAMS = {
                "prop": "sections",
                "format": "json",
                "page": ele.substitute(title=self._title),
                "action": "parse",
                "redirects": "1"
            }
            req = config.session.get(url, params=PARAMS)
            sections = req.json()["parse"]["sections"]
            if req.json().get("error"):
                continue
            if len(list(filter(lambda x: re.search(
                    "Episode", x["line"], re.IGNORECASE), sections))) == 0:
                continue
            self._episodesURL = f"{url}?page={req.json()['parse']['title']}"
            break

    def _getWikepediaSeasons(self):
        url = self._episodesURL
        PARAMS = {
            "prop": "sections",
            "format": "json",
            "action": "parse"
        }
        req = requests.get(url, params=PARAMS)
        sections = req.json()["parse"]["sections"]
        epLvl = list(filter(lambda x: re.search(
            "Episode", x["line"], re.IGNORECASE), sections))[0]["level"]
        # Get the season subsections
        allSeasons = list(
            filter(lambda x: x["level"] == str(int(epLvl)+1), sections))
        # if no season subsections
        if len(allSeasons) == 0:
            return [list(
                filter(lambda x: x["level"] == str(int(epLvl)), sections))[0]]
        seasons = allSeasons = list(
            filter(lambda x: re.search("Season", x["line"], re.IGNORECASE), allSeasons))
        if len(seasons) == 0:
            seasons = allSeasons
        self._seasonsHTML = seasons

    def _getTotalEpisodesWiki(self, episodes):
        return len(episodes)

    def _getOverallEpNumWiki(self, sea, ep):
        total = 0
        for i in range(sea-1):
            total = total+len(self._getEpisodesHTMLWiki(sea))
        total = total+ep
        return total

    def _getEpisodesHTMLWiki(self, season):
        section = self._seasonsHTML(season)

        index = section["index"]
        PARAMS = {
            "prop": "text",
            "section": index,
            "format": "json",
            "action": "parse"
        }
        req = requests.get(self._episodesURL, params=PARAMS)
        episodesHTML = req.json()["parse"]["text"]["*"]
        soup = BeautifulSoup(episodesHTML, "html.parser")
        output = soup.find_all("tr", attrs={"class": "summary"})
        if len(output) == 0:
            output = soup.find_all("tr", attrs={"class": "vevent"})
        return output

    def _getIMDBWiki(self, imdb, season, epNum):
        airdate = self._getOriginalAirDateWiki(epNum)
        overallEP = self._getOverallEpNumWiki(season, epNum)
        compare = utils.convertArrow(airdate, "MMMM D, YYYY")

        series = ia.get_movie(imdb)
        ia.update(series, "episodes")
        matchSeason = None
        for i in range(series["seasons"]):
            k = i+1
            matchSeason = k
            totalEP = len(series["episodes"][k])
            curr = series["episodes"][k][totalEP]
            releaseDate = self._getReleaseDatesWiki(curr)[0]
            date = utils.convertArrow(releaseDate, "D MMMM YYYY")
            if (date-compare).total_seconds() > 90000:
                break

        totalEP = len(series["episodes"][matchSeason])
        startEP = (max(0, epNum-2))
        if overallEP < totalEP:
            startEP = (max(0, o-2))
        matchObj = None
        for i in range(startEP, totalEP+1):
            curr = series["episodes"][matchSeason][i]
            releaseDate = self._getReleaseDatesWiki(curr)[0]
            date = utils.convertArrow(releaseDate, "D MMMM YYYY")
            if abs((date-compare).total_seconds()) < 90000:
                matchObj = curr
                break
        ia.update(matchObj, info=["main"])
        return matchObj["imdbID"]

    def _getOriginalAirDateWiki(episode):
        sections = episode.find_all("td")
        date = None
        dateObj = None
        for sect in sections:
            try:
                newDate = utils.cleanString(sect.find(text=True))
                newObj = utils.convertArrow(newDate, "MMMM D, YYYY")

                if dateObj == None:
                    dateObj = newObj
                    date = newDate
                elif newObj < dateObj:
                    dateObj = newObj
                    date = newDate
                break
            except:
                continue

        return date

    def _getEnglishNameWiki(episode):
        fulltitle = episode.find("td", attrs={"class": "summary"}).get_text()
        name = re.sub("Transcription.*", "", fulltitle)
        return name

    def _getJapaneseNameWiki(episode):
        fulltitle = episode.find("td", attrs={"class": "summary"}).get_text()
        section = re.search("Transcription.*:(.*)\(Jap",
                            fulltitle) or re.search("Transcription.*:(.*)", fulltitle)
        if section == None:
            return ""
        name = section.group(1)
        return name

    def _getReleaseDatesWiki(self, episode):
        ia.update(episode, info=['release dates'])
        data = episode["release dates"]
        out = []
        for ele in data:
            date = re.search("[0-9]{2} [a-z]* [0-9]{4}", ele, re.IGNORECASE) or re.search(
                "[0-9]{1} [a-z]* [0-9]{4}", ele, re.IGNORECASE)
            if date != None:
                out.append(date.group(0))
        return list(sorted(out, key=lambda x: utils.get(x, "D MMMM YYYY")))


    def _getTotalEPWiki(self):
        total = 0
        for ele in self._seasonsHTML:
            total = total+len(self._getEpisodesHTMLWiki(ele))
        return total
    def getShowStartWiki(self,episodes):
        sections = episodes[0].find_all("td")
        date = None
        dateObj = None
        for sect in sections:
            try:
                newDate = utils.cleanString(sect.find(text=True))
                newObj = utils.convertArrow(newDate, "MMMM D, YYYY")
                if dateObj == None:
                    dateObj = newObj
                    date = newDate
                elif newObj < dateObj:
                    dateObj = newObj
                    date = newDate
                break
            except:
                continue
        return date

        """
    Anime Functions
    """

    def _getIsAnime(self):
        PARAMS = {
            "prop": "text",
            "format": "json",
            "action": "parse",
        }
        req = config.session.get(self._showURL, params=PARAMS)
        episodesHTML = req.json()["parse"]["text"]["*"]

        if episodesHTML.find(
                "anime") == -1:
            return False
        return True

    def _getAnimeInfo(self):
        animeJSON = os.path.join(
            config.root_dir, "anime-offline-database", "anime-offline-database.json")

        data = self._getAnimeSearchData()
        titles = ["None of These"]
        titles.extend(self._getEngTitle(data))
        title = utils.singleSelectMenu(titles, "Which Anime are you Demuxing")

        if title == "None of These":
            self._movieObj["mal"] = utils.getIntInput("Enter the mal ID")
        else:

            index = titles.index(title)
            self._movieObj["mal"] = self._getmalIds(data)[index]

        malData = self._getAnimeData(self._movieObj["mal"])
        self._movieObj["engTitle"] = malData["title_english"]
        self._movieObj["japTitle"] = malData["title_japanese"]
        self._movieObj["type"] = malData["type"]
        self._movieObj["languages"] = ["English", "Japanese"]

        with open(animeJSON, "r") as p:
            data = json.loads(p.read())["data"]
            reduce = [{"index": i, "title": data[i]["title"], "match":jellyfish.jaro_distance(
                title, data[i]["title"])} for i in range(len(data))]
            reduce = list(filter(lambda x: x["match"] > .9, reduce))
            reduce = list(
                sorted(reduce, key=lambda x: x["match"], reverse=True))
            if len(reduce) > 0:
                title = list(map(lambda x: x["title"], reduce))[0]
                dataIndex = list(filter(lambda x: x["title"] == title, reduce))[
                    0]["index"]
                matchObj = data[dataIndex]
                self._addAnimeSourcesHelper(matchObj["sources"])

        self._movieObj['year'] = malData['aired']['prop']['from']['year']
        self._movieObj["imdb"] = self._maltoIMDB(malData)

    def _getAnimeSearchData(self):
        url = f"https://api.jikan.moe/v4/anime?q={self._title}"
        req = config.session.get(url)
        data = req.json()["data"]
        return data

    def _getEngTitle(self, data):
        titles = list(map(lambda x: x["title_english"], data))
        titles = list(filter(lambda x: x != None, titles))
        return titles

    def _getJapTitle(self, data):
        titles = list(map(lambda x: x["title_japanese"], data))
        titles = list(filter(lambda x: x != None, titles))
        return titles

    def _getmalIds(self, data):
        id = list(map(lambda x: x["mal_id"], data))
        id = list(filter(lambda x: x != None, id))
        return id

    def _getTypes(self, data):
        type = list(map(lambda x: x["type"], data))
        type = list(filter(lambda x: x != None, type))
        return type

    def _addAnimeSourcesHelper(self, sources):
        for source in sources:
            if re.search("https://anisearch.com/anime/", source):
                self._movieObj["anisearch"] = re.sub(
                    "https://anisearch.com/anime/", "", source)

            elif re.search("https://myanimelist.net/anime/", source):
                self._movieObj["mal"] = re.sub(
                    "https://myanimelist.net/anime/", "", source)

            elif re.search("https://anidb.net/anime/", source):
                self._movieObj["anidb"] = re.sub(
                    "https://anidb.net/anime/", "", source)

            elif re.search("https://kitsu.io/anime/", source):
                self._movieObj["kitsu"] = re.sub(
                    "https://kitsu.io/anime/", "", source)
        return self._movieObj

    def _maltoIMDB(self, data):
        minutes = 0
        hours = 0

        times = data["duration"]
        try:
            hours = re.search("([0-9]+).*(hours|hrs|hour|hr)", times).group(1)
        except:
            None
        try:
            minutes = re.search(
                "([0-9]+).*(min|minutes|mins|minute)", times).group(1)
        except:
            None
        runtime = f"in {hours} hours and {minutes} minutes"
        engTitle = data["title_english"]
        year = data["aired"]["prop"]["from"]["year"]
        return self._matchIMDB(engTitle, year, runtime)

    def _matchIMDB(self, title, year, runtime):
        imdbObjs = self._getMovieList(title)
        for obj in imdbObjs:
            obj = self._updateIMDB(obj, "main")
            if int(obj["year"]) != int(year):
                continue
            match1 = jellyfish.jaro_similarity(obj.get("title", ""), title)
            match2 = jellyfish.jaro_similarity(
                obj.get("localized title", ""), title)
            match3 = jellyfish.jaro_similarity(
                obj.get("original title", ""), title)
            if max(match1, match2, match3) < .9:
                continue
            # compare time

            time1 = utils.dehumanizeArrow(f"in {obj['runtimes'][0]} minutes")
            time2 = utils.dehumanizeArrow(runtime)
            maxTime = max(time1, time2)
            minTime = min(time1, time2)
            dif = utils.subArrowTime(maxTime, minTime)
            if dif.hour > 0:
                continue
            if dif.minute > 5:
                continue
            return obj["imdbID"]

    def _getAnimeData(self, id):
        url = f"https://api.jikan.moe/v4/anime/{id}"
        req = config.session.get(url)
        data = req.json()["data"]
        return data

# imdb functions

    def _getMovieList(self, title):
        return ia.search_movie(title)

    def _updateIMDB(self, obj, set):
        ia.update(obj, info=[set])
        return obj


# import re
# import os

# from dotenv import load_dotenv
# from guessit import guessit

# from tmdbv3api import TMDb, Find, TV, Movie,Season
# from jikanpy import Jikan

# import tools.general as utils
# import config
# import mediadata.animeMovieData as animeData

# load_dotenv()
# tmdb = TMDb()
# tmdb.api_key = os.environ.get("TMDB") or "e7f961054134e132e994eb5e611e454c"
# find = Find()
# movie = Movie()
# season=Season()
# tv = TV()


# def getMovieName(movie):
#     return guessit(movie["title"])["title"]


# def getByID(id):
#     return ia.get_movie(id)


# def getMovieYear(movie):
#     return movie["year"]

    def _getIMDBInfo(self):
        title = self._title
        results = ia.search_movie(title)
        result = None
        msg = None

        if self._type == "TV":
            msg = 'What TV Show'
        else:
            msg = "What Movie"
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
            match = utils.singleSelectMenu(titles, msg)
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
        self._updateIMDB(result, "main")
        self._movieObj["imdbID"] = result["imdbID"]
        self._movieObj["title"] = result["title"]
        self._movieObj["type"] = self._getKind(result)
        self._movieObj["languages"] = result["languages"]
        self._movieObj["year"] = result["year"]

    def _getKind(self, movie):
        kind = movie["kind"]
        if kind == "Movie" or kind == "tv movie" or kind == "video movie":
            return "Movie"
        else:
            return "TV"


# def update(obj,set):
#     ia.update(obj, info=[set])
#     return obj


# def convertIMDBtoTMDB(id):
#     if re.search("tt", id) == None:
#         id = f"tt{id}"
#     data = find.find_by_imdb_id(id)
#     results = []
#     results.extend(data["movie_results"])
#     results.extend(data["tv_results"])

#     if len(results) > 0:
#         return results[0]["id"]


# def getSeason(sources):
#     details = guessit(sources[0])
#     season = details.get("Season")
#     return season


# def getTotalEpisodes(episodes):
#     return len(episodes.keys())


# def getEpisodes(movie, season):
#     ia.update(movie, 'episodes')
#     return movie["episodes"][season]


# def getEpisodeData(episodes, num):
#     episode = episodes[num]
#     ia.update(episode, info=['main'])
#     return episode


# def getEpisodeTitle(movie, season, episode):
#     ia.update(movie, 'episodes')
#     episode = movie["episodes"][season][episode]
#     ia.update(episode, info=['main'])
#     return episode["title"]


# def getMovieTitle(movie):
#     movieName = getMovieName(movie)
#     movieYear = getMovieYear(movie)
#     return f"{movieName} ({movieYear})"
