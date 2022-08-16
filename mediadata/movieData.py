import string
import requests
import re
import json
import os

import tools.general as utils
from bs4 import BeautifulSoup
import jellyfish
from imdb import Cinemagoer as imdb
from tmdbv3api import Find, TMDb

import config
# Globals
ia = imdb()
tmdb = TMDb()
tmdb.api_key = os.environ.get("TMDB") or "e7f961054134e132e994eb5e611e454c"
find = Find()


class MovieData():
    def __init__(self):
        self._type = None
        self._episodesURL = ""
        self._showURL = ""
        self._movieObj = {}
        self._seasonsHTMLDict = {}
        self._imdbObjDict = {}

    ##########################################################################
    # Public Function
    ########################################################################################

    def setData(self, type, title):
        self._type = type
        self._getShowURLWiki(title)
        if self._showURL != "" and self._getIsAnime() == True:
            return self._getAnimeInfo(title)
        else:
            return self._getIMDBInfo(title)

    def retriveEpisodeTitle(self, seasonNum, epNum, title, year, lang="English"):
        seasonNum = int(seasonNum)
        epNum = int(epNum)
        return utils.smart_truncate(self._getEpisodeName(seasonNum, epNum, title, year, lang),95)

    def retriveEpisodeIMDB(self, imdb, seasonNum, epNum, title, year):
        seasonNum = int(seasonNum)
        epNum = int(epNum)
        return self._getEpisodeIMDB(imdb, seasonNum, epNum, title, year)

    def retriveNumberofEpisodes(self, seasonNum, epNum, title, year):
        return self._getNumberofEpisodes(seasonNum, epNum, title, year)

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

    #helpers

    def _getEpisodeName(self,  seasonNum, epNum, title, year, lang):
        seasonNum = int(seasonNum)
        epNum = int(epNum)
        self._getEpisodesURLWiki(title, year)
        self._getSeasonSectionsWiki()
        self._getSeasonHTMLDictWiki(seasonNum)
        name = None
        if lang == "English":
            name = self._getEnglishNameWiki(
                self._seasonsHTMLDict[seasonNum][epNum])
        maxWordLength = 85
        if len(name) > maxWordLength:
            name = f"{name[:75]}......"
        return re.sub('"', '', name)

    def _getEpisodeIMDB(self, imdb, seasonNum, epNum, title, year):
        seasonNum = int(seasonNum)
        epNum = int(epNum)
        self._getEpisodesURLWiki(title, year)
        self._getSeasonSectionsWiki()
        return self._getIMDBWiki(imdb, seasonNum, epNum)

    def _getNumberofEpisodes(self, seasonNum, epNum, title, year):
        seasonNum = int(seasonNum)
        epNum = int(epNum)
        self._getEpisodesURLWiki(title, year)
        self._getSeasonSectionsWiki()
        return self._getTotalEPWiki()

    def _getIMDBWiki(self, imdb, seasonNum, epNum):
        airdate = self._getEpisodeAirDateWiki(seasonNum, epNum)
        overallEP = self._getOverallEpNumWiki(seasonNum, epNum)
        enTitle = self._getEnglishNameWiki(
            self._seasonsHTMLDict[seasonNum][epNum])
        japTitle = self._getJapaneseNameWiki(
            self._seasonsHTMLDict[seasonNum][epNum])
        compare = utils.convertArrow(airdate, "MMMM D, YYYY")
        series = self._imdbObjDict.get(imdb) or ia.get_movie(imdb)
        self._imdbObjDict[imdb] = series
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
        offset = 5
        startEP = (max(1, epNum-offset))
        if overallEP < totalEP:
            startEP = (max(1, overallEP - offset))
        matchObj = None
        for i in range(startEP, totalEP+1):
            curr = series["episodes"][matchSeason][i]
            releaseDate = self._getReleaseDatesWiki(curr)[0]
            date = utils.convertArrow(releaseDate, "D MMMM YYYY")
            if abs((date-compare).total_seconds()) < 90000:
                matchObj = curr
                break
            elif jellyfish.jaro_distance(curr["title"], enTitle) > .9:
                matchObj = curr
                break
            elif jellyfish.jaro_distance(curr["title"], japTitle) > .9:
                matchObj = curr
                break
        if matchObj == None:
            return
        ia.update(matchObj, info=["main"])
        return matchObj["imdbID"]
    #url grabbers

    def _getShowURLWiki(self, title):
        url = "https://en.wikipedia.org/w/api.php"
        pageList = [string.Template("$title")]

        for ele in pageList:
            PARAMS = {
                "prop": "sections",
                "format": "json",
                "page": ele.substitute(title=title),
                "action": "parse",
                "redirects": "1"
            }
            req = config.session.get(url, params=PARAMS)
            if req.json().get("error"):
                continue

            self._showURL = f"{url}?page={req.json()['parse']['title']}"
            break

    def _getEpisodesURLWiki(self, title, year):
        url = "https://en.wikipedia.org/w/api.php"
        pageList = [string.Template(
            "List of $title episodes"), string.Template("$title")]

        for ele in pageList:

            PARAMS = {
                "prop": "sections",
                "format": "json",
                "page": ele.substitute(title=title),
                "action": "parse",
                "redirects": "1"
            }
            searches = [f"^Season", f"{title}.*{year}", f"{title}"]
            self._episodesURL = None
            for search in searches:
                req = config.session.get(url, params=PARAMS)
                sections = req.json()["parse"]["sections"]
                if req.json().get("error"):
                    continue
                section = len(list(filter(lambda x: re.search(
                    search, x["line"], re.IGNORECASE), sections)))
                if section == 0:
                    continue
                self._filterWord = search
                self._episodesURL = f"{url}?page={req.json()['parse']['title']}"
                break
            if self._episodesURL:
                break
        #data

    def _getSeasonSectionsWiki(self):
        url = self._episodesURL
        PARAMS = {
            "prop": "sections",
            "format": "json",
            "action": "parse"
        }
        req = requests.get(url, params=PARAMS)
        sections = req.json()["parse"]["sections"]
        seasons = list(filter(lambda x: re.search(
            self._filterWord, x["line"], re.IGNORECASE), sections))
        self._seasonSectionDicts = seasons
        return seasons

    def _getSeasonHTMLDictWiki(self, seasonNum):
        #data has already been set
        if self._seasonsHTMLDict.get(seasonNum) != None:
            return self._seasonsHTMLDict.get(seasonNum)
        outdict = {}
        section = self._seasonSectionDicts[seasonNum-1]
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
        count = 1
        for ele in output:
            numColumn = ele.find(["th", "td"], attrs={
                                 "id": re.compile("ep[0-9]+")})
            if numColumn == None:
                continue
            nums = re.findall("[0-9]+", numColumn.get_text())
            for num in nums:
                outdict[count] = ele
                count = count+1
        self._seasonsHTMLDict[seasonNum] = outdict
        return outdict

    #dates

    def _getOriginalAirDateWiki(self):
        seasonData = self._getSeasonHTMLDictWiki(1)
        epData = seasonData[1]
        sections = epData.find_all("td")
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

    def _getEpisodeAirDateWiki(self, seasonNum, epNum):
        seasonData = self._getSeasonHTMLDictWiki(seasonNum)
        epData = seasonData[epNum]
        sections = epData.find_all("td")
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

    def _getReleaseDatesWiki(self, epNum):
        ia.update(epNum, info=['release dates'])
        data = epNum["release dates"]
        out = []
        for ele in data:
            date = re.search("[0-9]{2} [a-z]* [0-9]{4}", ele, re.IGNORECASE) or re.search(
                "[0-9]{1} [a-z]* [0-9]{4}", ele, re.IGNORECASE)
            if date != None:
                out.append(date.group(0))
        return list(sorted(out, key=lambda x: utils.convertArrow(x, "D MMMM YYYY")))

    #names
    def _getEnglishNameWiki(self, epNum):
        fulltitle = epNum.find("td", attrs={"class": "summary"}).get_text()
        name = re.sub("Transcription.*", "", fulltitle)
        return name

    def _getJapaneseNameWiki(self, epNum):
        fulltitle = epNum.find("td", attrs={"class": "summary"}).get_text()
        section = re.search("Transcription.*:(.*)\(Jap",
                            fulltitle) or re.search("Transcription.*:(.*)", fulltitle)
        if section == None:
            return ""
        name = section.group(1)
        return name

    #episode count
    def _getTotalEPWiki(self):
        total = 0
        for i in range(len(self._seasonSectionDicts)):
            seasonData = self._getSeasonHTMLDictWiki(i+1)
            total = total+len(seasonData.keys())
        return total

    def _getOverallEpNumWiki(self, sea, ep):
        total = 0
        for i in range(sea-1):
            seasonData = self._getSeasonHTMLDictWiki(i+1)
            total = total+len(seasonData.keys())
        total = total+ep
        return total

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

    def _getAnimeInfo(self, title):
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
        self._movieObj["imdb"] = self._maltoIMDB(malData)
        self._movieObj["tmdb"] = self._convertIMDBtoTMDB(
            f"tt{self._maltoIMDB(malData)}")

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
        self._movieObj["engTitle"] = malData["title_english"]
        self._movieObj["japTitle"] = malData["title_japanese"]
        self._movieObj["type"] = malData["type"]
        self._movieObj["languages"] = ["English", "Japanese"]
        self._movieObj['year'] = malData['aired']['prop']['from']['year']

        return self._movieObj

    def _getAnimeSearchData(self, title):
        url = f"https://api.jikan.moe/v4/anime?q={title}"
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

# imdb/tmdb functions

    def _getMovieList(self, title):
        return ia.search_movie(title)

    def _updateIMDB(self, obj, set):
        ia.update(obj, info=[set])
        return obj

    def _getIMDBInfo(self, title):
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
        self._movieObj["imdb"] = result["imdbID"]
        self._movieObj["tmdb"] = self._convertIMDBtoTMDB(
            f"tt{result['imdbID']}")

        self._movieObj["title"] = result["title"]
        self._movieObj["type"] = self._getKind(result)
        self._movieObj["languages"] = result["languages"]
        self._movieObj["year"] = result["year"]
        return self._movieObj

    def _getKind(self, movie):
        kind = movie["kind"]
        if kind == "Movie" or kind == "tv movie" or kind == "video movie":
            return "Movie"
        else:
            return "TV"

    def _convertIMDBtoTMDB(self, id):
        data = find.find_by_imdb_id(id)
        results = []
        results.extend(data["movie_results"])
        results.extend(data["tv_results"])

        if len(results) > 0:
            return results[0]["id"]
