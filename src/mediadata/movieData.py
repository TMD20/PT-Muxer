import string
import re
import os
import functools
import traceback

from bs4 import BeautifulSoup
import tmdbsimple as tmdb
import jellyfish
from imdb import Cinemagoer as imdb

import config as config
import src.tools.logger as logger
import src.tools.general as utils


# Globals
ia = imdb()
tmdb.API_KEY = os.environ.get("TMDB") or "e7f961054134e132e994eb5e611e454c"
tmdb.REQUESTS_SESSION = config.session


class MovieData():
    def __init__(self, type):
        self._type = type
        self._episodesURL = ""
        self._showURL = ""
        self._movieObj = {}
        self._seasonsHTMLDictWiki = {}
        self._showObjDictIMDB = {}
        self._epiDictTMDB = {}


########################################################################################
# Public Function
########################################################################################

    def setData(self, type, title):
        """
        Sets MovieData Dict with data, movie is picked by user
        Parameters
        ----------
        type : str
            Whether we are looking for a Movie or TV show
        title : str
            The title to search for

        Returns
        -------
        dict
            returns MovieData Dict with data about matches show
        """

        if type == "TV":
            self._movieObj["season"] = utils.getIntInput(
                "What Season are you demuxing")
        self._getShowURLWiki(title)
        data = None
        anime = self._getIsAnimeWiki()

        logger.logger.debug(f"Movie Data")
        logger.logger.debug(f"type: {type}")
        logger.logger.debug(f"title: {title}")
        logger.logger.debug(f"show wikiurl:{self._showURL}")
        logger.logger.debug(f"Anime:{anime}")
        if anime:
            id = self._getMalID(title)
            if id:
                data = self._getAnimeInfo(id)

        else:
            id = self._getIMDBHelper(title)
            if id:
                data = self._getMovieInfo(id)
        logger.logger.debug(f"Automatic Data: {data}")

        data = self._verifyData(data)
        logger.logger.debug(f"Verified Data: {data}")

    def retriveEpisodeTitle(self, seasonNum, epNum, title, year, tmdbID, lang="English"):
        """
        get Episode Title Via Wikepedia or TMDB

        Parameters
        ----------
        seasonNum : int or str
            The Number of the Season
        epNum : int or str
            The Number of the episode in Current Season
        title:  str
            Title of the show
        year:   str
            Year the title came out
        tmdbID: str
            TMDBID of the Series
        lang: str [option]
            Language of the Title to return

        Returns
        -------
        str
            title of the episode
        """
        seasonNum = int(seasonNum)
        epNum = int(epNum)

        ogTitle = self._getEpisodeName(
            seasonNum, epNum, title, year, tmdbID, lang)
        return utils.smart_truncate(ogTitle, 95)

    def retriveEpisodeIMDB(self, imdbID, tmdbID, seasonNum, epNum, title, year):
        """
        get Episode IMDB Via Wikepedia or TMDB

        Parameters
        ----------

        tmdbID: str
            TMDBID of the Series

        imdbbID: str
            imdbID of the Series
        seasonNum : int or str
            The Number of the Season
        epNum : int or str
            The Number of the episode in Current Season
        title:  str
            Title of the show
        year:   str
            Year the title came out

        Returns
        -------

        str
            imdb string for the episode
        """
        seasonNum = int(seasonNum)
        epNum = int(epNum)
        return self._getEpisodeIMDB(imdbID, tmdbID, seasonNum, epNum, title, year)

    def retriveNumberofEpisodes(self, seasonNum, title, year, tmdbID):
        """
        Gets the total Number of Episodes in the current Season

        Parameters
        ----------

        seasonNum : int or str
            The Number of the Season
        title:  str
            Title of the show
        year:   str
            Year the title came out

        Returns
        -------

        int
            the number of episodes in the correct season
        """
        return self._getNumberofEpisodes(seasonNum, title, year, tmdbID)

    ########################################################################################
    # Getters/Setters
    ########################################################################################

    @property
    def movieObj(self):
        return self._movieObj

########################################################################################
# Private Functions
########################################################################################

    ########################################################################################
    # helpers
    ########################################################################################
    def _getIMDBHelper(self,title):
        # try:
        #     return self._getIMDBID(title)
        # except Exception as E:
        #     utils.tracebackhelper(traceback.format_exc(),E,"imdb module failed\nTrying alt method")
        return self._retriveimdbtmdb(title)
    
    def _retriveimdbtmdb(self,title):
        if self._type == "TV":
            msg = 'What TV Show'
        else:
            msg = "What Movie"
        noMatch = "None of These Titles Match"
        titles = [noMatch]
        results=self._searchByStringTMDB(title, self._type)
        if len(results)==0:
            return
        options=list(map(lambda x:(f"{x[0]+1}.{x[1].get('original_title') or x[1].get('title') or x[1].get('name')}\n{utils.wraptext(utils.smart_truncate(x[1]['overview'],length=150))}"),enumerate(results)))
        titles.extend(options)
        selection=utils.singleSelectMenu(titles,msg,default=titles[1])
        if selection==noMatch:
            return
        result = results[options.index(selection)-1]
        id=self._tmdbexternalID(self._getTMDBOBj(result["id"]),"imdb_id")
        if id:
            return re.sub("tt", "", id)
        return
    
    def _verifyData(self, data):
        if data == None:
            data = self._userInputMovie()
        return data

    def _getEpisodeName(self,  seasonNum, epNum, title, year, tmdbID, lang):
        """
        Helper Function to get Episode Title Via Wikepedia or TMDB

        Parameters
        ----------
        seasonNum : int or str
            The Number of the Season
        epNum : int or str
            The Number of the episode in Current Season
        title:  str
            Title of the show
        year:   str
            Year the title came out
        tmdbID: str
            TMDBID of the Series
        lang: str [option]
            Language of the Title to return


        Returns
        -------
        str
            title of the episode
        """
        name = "PlaceHolder Title"
        if lang == "English":
            success = False
            try:
                data = self._seasonSelectionTMDB(seasonNum, title, tmdbID)
                name = self._getEnglishNameTMDB(data, epNum)
                success = True

            except:
                logger.print("TMDB Episode Name Finder Failed",
                             style="bold red")
            if not success:
                try:
                    self._getEpisodesURLWiki(title, year)
                    self._getSeasonSectionsWiki()
                    self._getSeasonHTMLDictWiki(seasonNum)
                    if lang == "English":
                        name = self._getEnglishNameWiki(
                            self._seasonsHTMLDictWiki[seasonNum][epNum])
                except:
                    logger.print("Wiki Episode Name Finder Failed",
                                 style="bold red")
            return re.sub('"', '', name)

    def _getEpisodeIMDB(self, imdbID, tmdbID, seasonNum, epNum, title, year):
        """Helper Function to get Episode IMDB Via Wikepedia by TMDB matches data to IMDB
        Parameters
        ----------

        tmdbID: str
            TMDBID of the Series

        imdbbID: str
            imdbID of the Series
        seasonNum : int or str
            The Number of the Season
        epNum : int or str
            The Number of the episode in Current Season
        title:  str
            Title of the show
        year:   str
            Year the title came out
        Returns
        -------
        str
            imdb string for the episode
        """

        try:
            seasonIDList = self._seasonSearchTMDB(title, tmdbID)
            return self._episodeIMDBMatcherTMDB(seasonIDList, tmdbID, imdbID, seasonNum, epNum)

        except:
            logger.print("TMDB Episode IMDB Matcher Failed", style="bold red")
        try:
            self._getEpisodesURLWiki(title, year)
            self._getSeasonSectionsWiki()
            return self._episodeIMDBMatcherWiki(imdbID, seasonNum, epNum)
        except:
            logger.print("Wiki Episode IMDB Matcher Failed", style="bold red")

    def _getNumberofEpisodes(self, seasonNum, title, year, tmdbID):
        """
        Helper Function to get the total Number of Episodes in the current Season

        Parameters
        ----------

        seasonNum : int or str
            The Number of the Season
        title:  str
            Title of the show
        year:   str
            Year the title came out

        Returns
        -------

        int
            the number of episodes in the correct season
        # """
        try:
            return self._getTotalEPSeasonTMDB(seasonNum, title, tmdbID)
        except:
            logger.print("TMDB Episode Counter Failed", style="bold red")
        try:
            self._getEpisodesURLWiki(title, year)
            self._getSeasonSectionsWiki()
            return self. getSeasonEPCountWiki(seasonNum)
        except:
            logger.print("Wiki Episode Counter Failed", style="bold red")

    def _userInputMovie(self):
        if utils.singleSelectMenu(["Yes", "No"], "Is this a Anime?", default="No") == "Yes":
            return self._getAnimeInfo(utils.getIntInput("Enter the mal ID"))
        else:
           return self._imdbIDInput()
    ########################################################################################
    # Wikipedia Functions
    ########################################################################################

    def _episodeIMDBMatcherWiki(self, imdbID, seasonNum, epNum):
        """
        Retrives Episode Data from Wiki, Matches With IMDB Data
        to Retrive IMDB for Episode

        Parameters
        ----------

        imdbID : str
            ID of the show
        seasonNum : int or str
            The Number of the Season
        epNum : int or str
            The Number of the episode in Current Season
        title:  str
            Title of the show

        Returns
        -------

        imdbID
            The ID of the specific episode
        """
        airdate = self._getEpisodeAirDateWiki(seasonNum, epNum)
        overallEP = self._getOverallepNumWiki(seasonNum, epNum)
        enTitle = self._getEnglishNameWiki(
            self._seasonsHTMLDictWiki[seasonNum][epNum])
        japTitle = self._getJapaneseNameWiki(
            self._seasonsHTMLDictWiki[seasonNum][epNum])
        compare = utils.convertArrow(airdate, "MMMM D, YYYY")
        series = self._getByIDWithSetsIMDB(imdbID, "episodes")
        matchSeason = None
        for i in range(series["seasons"]):
            k = i+1
            matchSeason = k
            totalEPIMDBSeason = len(series["episodes"][k])
            curr = series["episodes"][k][totalEPIMDBSeason]
            releaseDate = self._getEpisodeReleaseDateIMDB(curr.movieID)[0]
            date = utils.convertArrow(releaseDate, "D MMMM YYYY")
            if (date-compare).total_seconds() > 90000:
                break

        totalEPIMDBSeason = len(series["episodes"][matchSeason])
        offset = 5
        startEP = (max(1, epNum-offset))
        if overallEP < totalEPIMDBSeason:
            startEP = (max(1, overallEP - offset))
        matchObj = None
        logger.print(
            "Searching for Matching Episode\nThis may take a while...", style="bold red")
        for i in range(startEP, totalEPIMDBSeason+1):
            curr = series["episodes"][matchSeason][i]
            releaseDate = self._getEpisodeReleaseDateIMDB(curr.movieID)[0]
            date = utils.convertArrow(releaseDate, "D MMMM YYYY")
            if abs((date-compare).total_seconds()) < 90000:
                matchObj = curr
                break
            elif re.sub(" +", "", curr["title"]) == re.sub(" +", "", enTitle):
                matchObj = curr
                break
            elif re.sub(" +", "", curr["title"]) == re.sub(" +", "", japTitle):
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
    ##################################################################################
    # URL Grabbers
    ##################################################################################

    def _getShowURLWiki(self, title):
        """
        Gets the URL from wikepedia that corresponds to the title

        Parameters
        ----------

        title : str
            The title to search for
            Handles redirects

        Returns
        -------

        str
                the main url for the show
        """
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
        """
        Gets the URL from wikepedia that corresponds to the list of episodes for a show

        Parameters
        ----------

        title : str
            The title to search for
            Handles redirects
        year : str
            The year the show came out
        Returns
        -------

        str
            The main url for all episodes of the show
        """
        if self._episodesURL and self._filterWord:
            return
        pageList = [f"List of {title} episodes", f"{title}"]
        self._getEpisodeURLSectionSearchHelper(title, year, pageList)
        if len(self._episodesURL) == 0:
            pageList = self._getEpisodeURL_LinkHelper(title)
            self._getEpisodeURLSectionSearchHelper(title, year, pageList)

    def _getEpisodeURLSectionSearchHelper(self, title, year, pageList):
        """
        function To search through a list of pages
        Sets values to be used by other functions

        Parameters
        ----------

        title : str
            The title to search for
            Handles redirects
        year : str
            The year the show came out
        pageList: list
            titles of pages to search for in list format
        Returns
        -------

        str
            The main url for all episodes of the show
        """
        url = "https://en.wikipedia.org/w/api.php"
        searches1 = [f"(<[a-z]+>)+{title}(</[a-z]+>)+.*{year}",
                     f"{title} ", f"{title}.*{year}", f"^{title}$"]
        searches2 = [f"^Season", f"(<[a-z]+>)+{title}(</[a-z]+>)+.*{year}",
                     f"{title} ", f"{title}.*{year}", f"^{title}$"]
        for ele in pageList:
            PARAMS = {
                "prop": "sections",
                "format": "json",
                "page": ele,
                "action": "parse",
                "redirects": "1"
            }
            req = config.session.get(url, params=PARAMS)
            if req.json().get("error"):
                continue
            sections = req.json()["parse"]["sections"]
            searches = searches1
            if re.search(f"{title}", req.json()["parse"]["title"]):
                searches = searches2
            for search in searches:
                section = len(list(filter(lambda x: re.search(
                    search, x["line"], re.IGNORECASE), sections)))
                if section == 0:
                    continue
                self._filterWord = search
                self._episodesURL = f"{url}?page={req.json()['parse']['title']}"
                return
            # Additional matches based on section names being close to title
            section1 = list(filter(lambda x: re.sub(
                " +", "", x["line"]) == re.sub(" +", "", title), sections))
            section2 = list(filter(lambda x: jellyfish.jaro_distance(
                title, x["line"]) > .92, sections))
            if len(section1) != 0:
                self._filterWord = section1[0]["line"]
                self._episodesURL = f"{url}?page={req.json()['parse']['title']}"
                return

            elif len(section2) != 0:
                self._filterWord = section2[0]["line"]
                self._episodesURL = f"{url}?page={req.json()['parse']['title']}"
                return
            # reset sections
            sections = []

    def _getEpisodeURL_LinkHelper(self, title):
        """
        Searches wikepedia page for internal link to episode page

        Parameters
        ----------

        title : str
            The title to search for
            Handles redirects

        Returns
        -------

        list
            List of interal pages that may be the list of episodes page
        """
        url = "https://en.wikipedia.org/w/api.php"
        pageList = [string.Template("$title")]
        data = []
        for ele in pageList:
            PARAMS = {
                "prop": "links",
                "format": "json",
                "page": ele.substitute(title=title),
                "action": "parse",
                "redirects": "1"
            }
            req = config.session.get(url, params=PARAMS)
            if req.json().get("error"):
                continue
            data.extend(list(filter(lambda x: re.search(
                "List of {title} episodes", x["*"], re.IGNORECASE), req.json()["parse"]["links"])))
            data.extend(list(filter(lambda x: re.search(
                "List of .* episodes", x["*"], re.IGNORECASE), req.json()["parse"]["links"])))
            data = list(map(lambda x: x["*"], data))

        return data

    def _getSeasonSectionsWiki(self):
        """ 
        Parses List of Episode Page
        Creates a List with each element being a season

        Parameters
        ----------
        Returns
        -------

        list
            A List with each elemement being the session Name, as returned by the Wikepedia API
        """
        url = self._episodesURL
        PARAMS = {
            "prop": "sections",
            "format": "json",
            "action": "parse"
        }
        req = config.session.get(url, params=PARAMS)
        sections = req.json()["parse"]["sections"]
        seasons = list(filter(lambda x: re.search(
            self._filterWord, x["line"], re.IGNORECASE), sections))
        self._seasonSectionDicts = seasons
        return seasons

    def _getSeasonHTMLDictWiki(self, seasonNum):
        """ 
        Creates a dictionary of Episode Data for selected Season

        Parameter
        ----------

        seasonNum : int or str
            The Number of the Season 

        Returns
        -------

        dict
            returns dictionary with Keys set as episode Number, Data episode HTML elements
        """
        # data has already been set
        if self._seasonsHTMLDictWiki.get(seasonNum) != None:
            return self._seasonsHTMLDictWiki.get(seasonNum)
        outdict = {}
        section = self._seasonSectionDicts[seasonNum-1]
        index = section["index"]
        PARAMS = {
            "prop": "text",
            "section": index,
            "format": "json",
            "action": "parse"
        }
        req = config.session.get(self._episodesURL, params=PARAMS)
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
        self._seasonsHTMLDictWiki[seasonNum] = outdict
        return outdict

    def _getOriginalAirDateWiki(self):
        """ 
        Gets the original Airdate From the first episode of first season HTML 
        or the earliest airdate if multiple present

        Parameter
        ----------
        Returns
        -------

        str
            The Original Airdate for first episode 
        """
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
        """ 
        Gets the original Airdate for a particular Episode 
        or the earliest airdate if multiple present

        Parameter
        ----------
        Returns
        -------

        str
            The Original Airdate for episode 
        """
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

    def _getEnglishNameWiki(self, epNum):
        """ 
        Gets English Name from wikepedia HTML Episode Section

        Parameter
        ----------

        epNum : int or str
        The Number of the episode in Current Season           
        Returns
        -------

        str
            English Title of Episode
        """
        fulltitle = epNum.find("td", attrs={"class": "summary"}).get_text()
        name = re.sub("Transcription.*", "", fulltitle)
        return name

    def _getJapaneseNameWiki(self, epNum):
        """ 
        Gets japanese Name from wikepedia HTML Episode Section
        If preent

        Parameter
        ----------

        epNum : int or str
        The Number of the episode in Current Season           
        Returns
        -------

        str
        japanese Title of Episode
        """

        fulltitle = epNum.find("td", attrs={"class": "summary"}).get_text()
        section = re.search("Transcription.*:(.*)\(Jap",
                            fulltitle) or re.search("Transcription.*:(.*)", fulltitle)
        if section == None:
            return ""
        name = section.group(1)
        return name

    # episode count
    def _gettotalEPIMDBSeasonWiki(self):
        """ 
        Gets the total Episode Count For all Season Using Wikepedia

        Parameter
        ----------
        Returns
        -------

        int
            total number of episode present on the List of Episode Page
        """
        total = 0
        for i in range(len(self._seasonSectionDicts)):
            seasonData = self._getSeasonHTMLDictWiki(i+1)
            total = total+len(seasonData.keys())
        return total

    def getSeasonEPCountWiki(self, seasonNum):
        """ 
        Gets the total Count of Episode According to WIkepedia
        For a particular Season

        Parameter
        ----------

        seasonNum : int or str
            The Number of the Season 

        Returns
        -------

        int
             total number of episode for that particular season
        """
        seasonData = self._getSeasonHTMLDictWiki(seasonNum)
        return len(seasonData.keys())

    def _getOverallepNumWiki(self, seasonNum, epNum):
        """ 
        Gets the overall Episode Number for a episode according to Wikepedia
        I.e All previous Season Episodes adding together + the EP number for current Season

        Parameter
        ----------

        seasonNum : int or str
            The Number of the Season 
        epNum : int or str
            The Number of the episode in Current Season        
        Returns
        -------

        int
             the oveall episode Number
        """
        total = 0
        for i in range(seasonNum-1):
            seasonData = self._getSeasonHTMLDictWiki(i+1)
            total = total+len(seasonData.keys())
        total = total+epNum
        return total

    #########################################################################
    # Anime Functions
    #########################################################################

    def _getIsAnimeWiki(self):
        """Checks with the Wikepedia Article indicates this is an anme
        Parameters
        ----------
        Returns
        -------
        bool
            Whether or not this is an anime
        """
        if self._showURL == "":
            return

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

    def _getAnimeProjectData(self):
        url = "https://github.com/manami-project/anime-offline-database/raw/master/anime-offline-database-minified.json"
        req = config.session.get(url)
        try:
            return req.json()["data"]
        except Exception as e:
            utils.tracebackhelper(traceback.format_exc(),E)
            return e

    def _getMalID(self, title):
        """
        ** This function needs to be updaterd
        Sets MovieData Dict with data, movie is picked by user
         Specifically for Anime Movie/TV Shows
        Parameters
        ----------
        type : str
            Whether we are looking for a Movie or TV show
        title : str
            The title to search for

        Returns
        -------
        dict
            returns MovieData Dict with data about matches show
        """

        data = self._getAnimeSearchDataMAL(title)
        noMatch = "None of These Titles Match"
        options = [noMatch]
        options.extend(self._getOptions(data))

        select = utils.singleSelectMenu(
            options, "Which Anime are you Demuxing")
        if select == noMatch:
            return
        else:
            return self._getmalIds(data)[options.index(select)-1]

    def _getAnimeInfo(self, malID):
        self._movieObj["mal"] = int(malID)
        malData = self._getAnimeDataByIDMAL(self._movieObj["mal"])
        imdbID= self._maltoIMDB(malData)
        self._movieObj["imdb"] =imdbID
        tmdbID = self._convertIMDBtoTMDB(
            f"tt{re.sub('tt','',imdbID)}", self._type)
        if tmdbID == None:
            moviesList = self._searchByStringTMDB(
                malData["title_english"], self._type)
            malYear = str(malData['aired']['prop']['from']['year'])
            data = list(filter(lambda x: re.search(malYear, str(
                x.get("first_air_date") or x.get("release_date"))), moviesList))
            if len(data) > 0:
                tmdbID = data[0]["id"]
        self._movieObj["tmdb"] = tmdbID

        animeJSON = self._getAnimeProjectData()
        if not animeJSON:
            return self._movieObj
        # create a dictionary
        reduce = [{"index": i, "title": animeJSON[i]["title"], "match":jellyfish.jaro_distance(
            malData["title_english"], animeJSON[i]["title"])} for i in range(len(animeJSON))]
        reduce = list(filter(lambda x: x["match"] > .9, reduce))
        reduce = list(
            sorted(reduce, key=lambda x: x["match"], reverse=True))
        if len(reduce) > 0:
            title = list(map(lambda x: x["title"], reduce))[0]
            dataIndex = list(filter(lambda x: x["title"] == title, reduce))[
                0]["index"]
            matchObj = animeJSON[dataIndex]
            self._addAnimeSourcesHelper(matchObj["sources"])
        self._movieObj["engTitle"] = malData["title_english"]
        self._movieObj["japTitle"] = malData["title_japanese"]
        self._movieObj["type"] = malData["type"]
        self._movieObj["languages"] = ["English", "Japanese"]
        self._movieObj['year'] = malData['aired']['prop']['from']['year']
        return self._movieObj

    def _getAnimeSearchDataMAL(self, title):
        """
        Searces myanimelist unofficial API for title
        Returns Results as dictionary

        Parameters
        ----------

        title : str
            The title to search for

        Returns
        -------
        dict
            Dictionary of Result matches search
        """
        url = f"https://api.jikan.moe/v4/anime?q={title}"
        req = config.session.get(url)
        data = req.json()["data"]
        return data

    def _getEngTitle(self, data):
        """
        Filters myanimelist results for english titles

        Parameters
        ----------

        data : dict
            data retrive from unoffical myanimelist API

        Returns
        -------

        list
            list of english Titles
        """
        titles = list(map(lambda x: x["title_english"], data))
        titles = list(filter(lambda x: x != None, titles))
        return titles

    def _getOptions(self, data):
        return list(map(lambda x: f"{x.get('title_english') or x.get('title_japanese')} {x['aired']['prop']['from']['year']}", data))

    def _getJapTitle(self, data):
        """
        Filters myanimelist results for japanese titles

        Parameters
        ----------

        data : dict
            data retrive from unoffical myanimelist API

        Returns
        -------

        list
            list of japanese Titles
        """
        titles = list(map(lambda x: x["title_japanese"], data))
        titles = list(filter(lambda x: x != None, titles))
        return titles

    def _getmalIds(self, data):
        """
        Filters myanimelist results for mal IDs

        Parameters
        ----------

        data : dict
            data retrive from unoffical myanimelist API

        Returns
        -------

        list
            list of mal IDs
        """
        id = list(map(lambda x: x["mal_id"], data))
        id = list(filter(lambda x: x != None, id))
        return id

    def _getTypes(self, data):
        """
        Filters myanimelist results for media type

        Parameters
        ----------

        data : dict
            data retrive from unoffical myanimelist API

        Returns
        -------

        list
            list of mediatypes
        """
        type = list(map(lambda x: x["type"], data))
        type = list(filter(lambda x: x != None, type))
        return type

    def _addAnimeSourcesHelper(self, sources):
        """
        Takes a dictionary of sources and Creates keys via the URLS
        Updates class MovieOBj

        Parameters
        ----------

        sources : dict
            This is data retrived from a XML file that corrisponds to a certain Anime

        Returns
        -------

        """
        for source in sources:
            if re.search("https://anisearch.com/anime/", source):
                self._movieObj["anisearch"] = int(re.sub(
                    "https://anisearch.com/anime/", "", source))

            elif re.search("https://myanimelist.net/anime/", source):
                self._movieObj["mal"] = int(re.sub(
                    "https://myanimelist.net/anime/", "", source))

            elif re.search("https://anidb.net/anime/", source):
                self._movieObj["anidb"] = int(re.sub(
                    "https://anidb.net/anime/", "", source))

            elif re.search("https://kitsu.io/anime/", source):
                self._movieObj["kitsu"] = int(re.sub(
                    "https://kitsu.io/anime/", "", source))
        return self._movieObj

    def _maltoIMDB(self, data):
        """
        Reads Mal Data from ID search via unoffical API
        Matches Information to IMDB

        Parameters
        ----------

        data : dict
            dict return for a picked selection from MAL API

        Returns
        -------

        str
            imdbID for the Movie/Show

        """
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
        if engTitle == None:
            return None
        return re.sub("tt","",self._autoMatchIMDB(engTitle, year, runtime) or self._autoMatchIMDBvTMDB(engTitle,year) or self._imdbIDInput())
    
    def _autoMatchIMDBvTMDB(self, title, year):
        results=self._searchByStringTMDB(title,self._type)
        results=list(filter(lambda x:utils.convertArrow(x.get("release_date") or x.get("first_air_date")).year==year,results))
        if len(results)==0:
            return None
        return self._tmdbexternalID(self._getTMDBObj(results[0]["id"],self._type),"imdb_id")
       

    def _autoMatchIMDB(self, title, year, runtime): 
        return None
        """
        Tries to Find Show or Movie Based on Different criteria

        Parameters
        ----------

        title:  str
            Title of the show
        year:   str
            Year the title came out
        runtime: str
            str to be parsed by arrow 

        Returns
        -------

        str
            imdbID for the Movie/Show

        """
        imdbObjs = self._getMovieList(title)
        for obj in imdbObjs:
            obj = self._getByIDIMDB(obj.movieID)

            if obj.get("year") and int(obj["year"]) != int(year):
                continue
            match1 = jellyfish.jaro_similarity(obj.get("title", ""), title)
            match2 = jellyfish.jaro_similarity(
                obj.get("localized title", ""), title)
            match3 = jellyfish.jaro_similarity(
                obj.get("original title", ""), title)
            # compare titles
            if max(match1, match2, match3) < .9:
                continue
            # compare time
            if obj.get("runtimes"):
                time1 = utils.dehumanizeArrow(
                    f"in {obj['runtimes'][0]} minutes")
                time2 = utils.dehumanizeArrow(runtime)
                maxTime = max(time1, time2)
                minTime = min(time1, time2)
                dif = utils.subArrowTime(maxTime, minTime)
                if dif.hour > 0:
                    continue
                if dif.minute > 5:
                    continue
            return int(obj["imdbID"])

    def _getAnimeDataByIDMAL(self, id):
        """
        Retrives Anime from unoffical myanimelist API 
        Using mal id

        Parameters
        ----------

        id: str
           The ID of the show

        Returns
        -------

        dict
            dictionary returned from API

        """
        url = f"https://api.jikan.moe/v4/anime/{id}"
        req = config.session.get(url)
        data = req.json()["data"]
        return data

    ########################################################################################
    # IMDB Functions
    ########################################################################################

    @functools.lru_cache
    def _getMovieList(self, title):
        """
        Retrives a list of Possible Matches via title search

        Parameters
        ----------
        title:  str
            Title of the show

        Returns
        -------

        list
            List of imdbPY Search Object 

        """
        try:
            return ia.search_movie(title)
        except Exception as E:
            utils.tracebackhelper(traceback.format_exc(),E,"Skipping IMDB Search")

            return []

    @functools.lru_cache
    def _getByIDWithSetsIMDB(self, imdbID, *args):
        """
        Retrives a a movie that matches with ID

        Parameters
        ----------
        imdbID: str
            imdbID of the Series

        *args : str
            Zero or More parameters Indicating what information sets to retrive


        Returns
        -------

        imdbPY Object
            imdb object matching with ID

        """
        series = ia.get_movie(imdbID)
        for arg in args:
            try:
                ia.update(series, info=[arg])
            except:
                continue
        return series

    @functools.lru_cache
    def _getByIDIMDB(self, imdbID):
        """
        Retrives a a movie that matches with ID

        Parameters
        ----------

        imdbID: str
            imdbID of the Series

        Returns
        -------

        imdbPY Object
            imdb object matching with ID
        """

        series = ia.get_movie(imdbID)
        self._showObjDictIMDB[imdbID] = series
        return series

    def _getIMDBID(self, title):
        """
        Allows user to pick title that best matches the input title sent

        Parameters
        ----------

        title:  str
            Title of the show

        Returns
        -------

        imdbPY Object
            imdb object for user picked
        """
        results = self._getMovieList(title)
        logger.logger.debug(
            f"IMDB Title Results {list(map(lambda x: x['long imdb title'], results))}")
        msg = None

        if self._type == "TV":
            msg = 'What TV Show'
        else:
            msg = "What Movie"
        if len(results) == 0:
            return
        else:
            titles = list(
                map(lambda x: f"{x['long imdb title']}:::{x.movieID}", results))
            titles.insert(0, "None of these Titles Match")
            match = utils.singleSelectMenu(titles, msg, default=titles[1])
            if match == "None of these Titles Match":
                return
            else:
                result = results[titles.index(match)-1]
        result = self._getByIDIMDB(result.movieID)
        return result["imdbID"]

    def _getMovieInfo(self, imdbID):
        result = self._getByIDIMDB(imdbID)
        self._movieObj["imdb"] = int(imdbID)
        self._movieObj["tmdb"] = self._convertIMDBtoTMDB(
            f"tt{imdbID}", self._type)
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

    @functools.lru_cache
    def _getEpisodeReleaseDateIMDB(self, episodeID):
        """
        Returns Sorted list of episode Release Dates

        Parameters
        ----------

        episodeID:  str
            imdb episode ID

        Returns
        -------

        list
            The sorted list of release dates with the earliest
        """
        episode = self._getByIDWithSetsIMDB(episodeID, "release dates")
        data = episode["release dates"]
        out = []
        for ele in data:
            date = re.search("[0-9]{2} [a-z]* [0-9]{4}", ele, re.IGNORECASE) or re.search(
                "[0-9]{1} [a-z]* [0-9]{4}", ele, re.IGNORECASE)
            if date != None:
                out.append(date.group(0))
        return list(sorted(out, key=lambda x: utils.convertArrow(x, "D MMMM YYYY")))
    def _imdbIDInput(self):
        message = \
        """
        Enter imdb id
        """
        id = utils.textEnter(message)
        try:
            result = ia.get_movie(re.sub("tt", "", id))
            return self._getMovieInfo(result["imdbID"])
        except:
            raise RuntimeError("Error with IMDBID")

########################################################################################
    # TMDB Functions
    ########################################################################################

    def _convertIMDBtoTMDB(self, id, kind):
        """
        converts imdb to tmdb


        Parameters
        ----------

        id: str
            imdb ID for Movie/Show
        kind: str
            whether this is a movie or tv

        Returns
        -------

        str
            tmdb id 
        """
        data = tmdb.Find(id).info(external_source="imdb_id")
        results = []
        if kind == "TV":
            results.extend(data["tv_results"])

        if kind == "Movie":
            results.extend(data["movie_results"])
        if len(results) > 0:
            return results[0]["id"]

    def _seasonSelectionTMDB(self, seasonNum, title, tmdbID):
        """
        Return season object
        Based on input 

        Parameters
        ----------

        seasonNum : int or str
            The Number of the Season 
        title:  str
            Title of the show
        tmdbID: str
            TMDBID of the Series

        Returns
        -------

        tmdbv3Api Season Obj
            object filled with season Data from API
        """
        data = self._seasonSearchTMDB(title, tmdbID)
        select = data[seasonNum-1]
        return tmdb.TV_Seasons(tmdbID, select["season_number"]).info()

    def _seasonSearchTMDB(self, title, tmdbID):
        """
        Return a list of season, based on the title and tmdbID
        Note: Multiple "Shows" may be combined on one entry

        This will filter out those combined entries


        Parameters
        ----------

        title:  str
            Title of the show
        tmdbID: str
            TMDBID of the Series

        Returns
        -------

        List 
            Season Numbers that correspond to the found seasons from the tmdbID
        """
        series = tmdb.TV(tmdbID).info()
        data = None
        data1 = list(filter(lambda x: x["name"] == title, series["seasons"]))
        data2 = list(filter(lambda x: re.sub(
            " +", "", x["name"]) == re.sub(" +", "", title), series["seasons"]))
        data3 = list(filter(lambda x: re.search(
            "season", x["name"], re.IGNORECASE), series["seasons"]))
        if len(data1) > 0:
            data = data1
        elif len(data2) > 0:
            data = data2
        elif len(data3) > 0:
            data = data3
        return data

    def _getEnglishNameTMDB(self, seasonData, epNum):
        """
        Returns list of Season Matching with input
        Note: Multiple "Shows" may be combined on one entry


        Parameters
        ----------

        seasonData : tmdbv3Api Season Obj
            data object for season
        epNum : int or str
            The Number of the episode in Current Season

        Returns
        -------

        str
            English Name for Episode
        """
        return seasonData["episodes"][epNum-1]["name"]

    def _getOverallEPNumTMDB(self, tmdbID, seasonIDList, seasonNum, epNum):
        """ 
        Gets the overall Episode Number for a episode according to TMDB
        I.e All previous Season Episodes adding together + the EP number for current Season

        Parameter
        ----------

        tmdbID: str
            TMDBID of the Series
        seasonIDList : list
            list of season IDs
        seasonNum : int or str
            The Number of the Seaso            
        epNum : int or str
            The Number of the episode in Current Season        

        Returns
        -------

        int
             the oveall episode Number
        """
        total = 0
        for i in range(seasonNum-1):
            select = seasonIDList[i]
            total = total+len(select["episode_count"])
        return total+epNum

    def _getTotalEPSeasonTMDB(self, seasonNum, title, tmdbID):
        data = self._seasonSelectionTMDB(seasonNum, title, tmdbID)
        return len(data["episodes"])

    def _searchByStringTMDB(self, title, mediatype):
        if mediatype == "TV":
            return tmdb.Search().tv(query=title)["results"]
        else:
            return tmdb.Search().movie(query=title)["results"]

    def _episodeIMDBMatcherTMDB(self, seasonIDList, tmdbID, imdbID, seasonNum, epNum):
        """
        Returns IMDB that matches with Episode From TMDB


        Parameters
        ----------

        seasonIDList : list
            list of season IDs
        tmdbID: str
            TMDBID of the Series

        imdbID: str
            imdbID of the Series 

        seasonNum : int or str
            The Number of the Season                              
        epNum : int or str
            The Number of the episode in Current Season


        Returns
        -------

        str
            imdbID for episode
        """
        seasonData = tmdb.TV_Seasons(
            tmdbID,  seasonIDList[seasonNum-1]["season_number"]).info()
        epimdbID = tmdb.TV_Episodes(
            tmdbID,  seasonData["season_number"], epNum).external_ids()["imdb_id"]
        if epimdbID:
            return re.sub("tt", "", epimdbID)
        # Do things the hard way
        series = self._getByIDWithSetsIMDB(imdbID, "episodes")
        compare = utils.convertArrow(
            seasonData["episodes"][epNum]["air_date"], "YYYY-MM-DD")
        matchSeason = None

        for i in range(series["seasons"]):
            k = i+1
            matchSeason = k
            totalEPIMDBSeason = len(series["episodes"][k])
            curr = series["episodes"][k][totalEPIMDBSeason]
            releaseDate = self._getEpisodeReleaseDateIMDB(curr.movieID)[0]
            date = utils.convertArrow(releaseDate, "D MMMM YYYY")
            if (date-compare).total_seconds() > 90000:
                break

        title = seasonData["episodes"][epNum]["name"]
        overallEP = self._getOverallEPNumTMDB(
            tmdbID, seasonIDList, seasonNum, epNum)

        totalEPIMDBSeason = len(series["episodes"][matchSeason])
        offset = 5
        startEP = (max(1, epNum-offset))

        if overallEP < totalEPIMDBSeason:
            startEP = (max(1, overallEP - offset))
        matchObj = None
        logger.print(
            "Searching for Matching Episode\nThis may take a while...")
        for i in range(startEP, totalEPIMDBSeason+1):
            curr = series["episodes"][matchSeason][i]
            releaseDate = self._getEpisodeReleaseDateIMDB(curr.movieID)[0]
            date = utils.convertArrow(releaseDate, "D MMMM YYYY")
            if abs((date-compare).total_seconds()) < 90000:
                matchObj = curr
                break
            elif re.sub(" +", "", curr["title"]) == re.sub(" +", "", title):
                matchObj = curr
            elif jellyfish.jaro_distance(curr["title"], title) > .9:
                matchObj = curr
                break
        if matchObj == None:
            return
        return self._getByIDIMDB(matchObj.movieID)["imdbID"]
    def _tmdbexternalID(self,tmdbObj,type):

        return tmdbObj.external_ids().get(type)
    def _getTMDBObj(self,id,type=None):
        type =type or self._type
        if type=="TV":
            return tmdb.TV(id)
        return tmdb.Movies(id)
