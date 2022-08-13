import re
import os
import json
import string
import requests
import time

from guessit import guessit
from jikanpy import Jikan
import jellyfish
from bs4 import BeautifulSoup


import tools.general as utils
import config
import mediadata.movieData as movieData

jikan = Jikan()
animeJSON = os.path.join(
    config.root_dir, "anime-offline-database", "anime-offline-database.json")

#Anime Functions
def matchMovieAnime(sources):
    movieObj={}
    data=getSearchData(sources)
    titles=list(map(lambda x:x["title_english"],data))
    japTitles= list(map(lambda x: x["title_japanese"], data))
    ids=list(map(lambda x: x["mal_id"], data))
    title=utils.singleSelectMenu(titles,"Which Anime are you Demuxing")
    index=titles.index(title)
    mal=ids[index]
    japTitle=japTitles[index]
    movieObj["mal"]=mal
    movieObj["engTitle"] = title
    movie0bj["japTitle"]=japTitle
    with open(animeJSON, "r") as p:
            data = json.loads(p.read())["data"]
            reduce = [{"index": i, "title": data[i]["title"], "match":jellyfish.jaro_distance(
                title, data[i]["title"])} for i in range(len(data))]
            reduce = list(filter(lambda x: x["match"] > .9, reduce))
            reduce = list(sorted(reduce, key=lambda x: x["match"], reverse=True))
            title = list(map(lambda x: x["title"], reduce))[0]
            dataIndex = list(filter(lambda x: x["title"] == title, reduce))[
                0]["index"]
            matchObj = data[dataIndex]
    movieObj = _addAnimeSourcesHelper(movieObj, matchObj["sources"])
    malData = getAnimeData(mal)
    movieObj['year']=malData['aired']['prop']['from']['year']
    if malData["type"]== "TV":
        movieObj["offset"] = findOffset(movieObj)
    
    
    movieObj["imdb"] = getMovieImdb(mal)
    return movieObj
    
            

def getTitles(sources):
    title=guessit(sources[0])["title"]
    url = f"https://api.jikan.moe/v4/anime?q={title}"
    req = requests.get(url)
    data = req.json()["data"]
    titles=list(map(lambda x:x["title_english"],data))
    titles=list(filter(lambda x:x!=None,titles))
    return titles
def getIDs(sources):
    title = guessit(sources[0])["title"]
    url = f"https://api.jikan.moe/v4/anime?q={title}"
    req = requests.get(url)
    data = req.json()["data"]
    id=list(map(lambda x:x["mal_id"],data))
    return id


def getAnimeData(id):
    url = f"https://api.jikan.moe/v4/{id}"
    req = requests.get(url)
    data = req.json()["data"]
    return data
def _addAnimeSourcesHelper(movieObj,sources):
    for source in sources:
        if re.search("https://anisearch.com/anime/", source):
            movieObj["anisearch"] = re.sub(
                "https://anisearch.com/anime/", "", source)

        elif re.search("https://myanimelist.net/anime/", source):
            movieObj["mal"] = re.sub(
                "https://myanimelist.net/anime/", "", source)

        elif re.search("https://anidb.net/anime/", source):
            movieObj["anidb"] = re.sub(
                "https://anidb.net/anime/", "", source)

        elif re.search("https://kitsu.io/anime/", source):
            movieObj["kitsu"] = re.sub(
                "https://kitsu.io/anime/", "", source)
    return movieObj


def findOffset(movieObj):
    if movieObj.get("mal"):
        return findOffsetMal(movieObj.get("mal"))

def findOffsetAniSearch(id):
    msg =\
        """
    Verify that the first episode, of the current season you are processing.
    With Luck it will be the first option in the selection menu

    """
    urlTemplate = string.Template(
        "https://www.anisearch.com/anime/$id/episodes/")
    url = urlTemplate.substitute(id=id)
    headers = {
        'User-Agent': 'Mozilla/5.0 (Macintosh; Intel Mac OS X 10_11_5) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/50.0.2661.102 Safari/537.36',
        "content-type": "text/html",
        "domain": ".anisearch.com",

    }
    req = requests.get(url, headers=headers)
    soup = BeautifulSoup(req.text, 'html.parser')
    data = soup.find_all("span", itemprop="name", lang="en")
    options = [f"{i+1}) {data[i].contents[0]}" for i in range(len(data))]
    selection = utils.singleSelectMenu(options, msg)
    return ["anisearch", int(selection.split(")")[0])]


def findOffsetMal(id):
    #try to get offset
    urlTemplate = string.Template(
        "https://api.jikan.moe/v4/anime/$id/episodes?page=$pagenum")
    msg =\
        """
    Verify that the first episode, of the current season you are processing.
    With Luck it will be the first option in the selection menu
    
    """
    options = []
    k = 0
    for i in range(1, 100):
        if k == 3:
            time.sleep(3)
            k = 0
        url = urlTemplate.substitute(id=id, pagenum=i)
        req = requests.get(url)
        data = req.json()["data"]
        if len(data) == 0:
            break
        offset = (i-1)*100
        options.extend(
            [f"{l+1+offset}) {data[l]['title']}" for l in range(len(data))])
        k = k+1
    selection = utils.singleSelectMenu(options, msg)
    return ["mal", int(selection.split(")")[0])]


def findOffsetAniDB(id):
    msg =\
        """
    Verify that the first episode, of the current season you are processing.
    With Luck it will be the first option in the selection menu

    """
    headers = {
        'User-Agent': 'Mozilla/5.0 (Macintosh; Intel Mac OS X 10_11_5) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/50.0.2661.102 Safari/537.36',
        "content-type": "text/html",

    }
    urlTemplate = string.Template(
        "https://anidb.net/anime/$id")
    url = urlTemplate.substitute(id=id)
    req = requests.get(url, headers=headers)
    soup = BeautifulSoup(req.text, 'html.parser')
    data = soup.find_all("td", attrs={"class": "title name episode"})
    options = [
        f"{i+1}) {data[i].find('label').contents[0]}" for i in range(len(data))]
    options = [
        ele.strip() for ele in options]
    selection = utils.singleSelectMenu(options, msg)
    return ["anidb", int(selection.split(")")[0])]


def getMovieImdb(mal):
    data = None
    if mal:
        data = getMalInfo(mal)
    engTitle = data[0]
    year = data[1]
    runtime = data[2]
    imbdb = matchImdb(engTitle, year, runtime)


def getMalInfo(id):
    urlTemplate = string.Template(
        "https://api.jikan.moe/v4/anime/$id")
    msg =\
        """
    Verify that the first episode, of the current season you are processing.
    With Luck it will be the first option in the selection menu
    """
    url = urlTemplate.substitute(id=id)
    req = requests.get(url)
    data = req.json()["data"]
    duration = data["duration"]
    duration = re.sub("hr", "hours", duration)
    duration = re.sub("min", "minutes", duration)
    duration = f"in {duration}"
    return data["title_english"], data["aired"]["prop"]["from"]["year"], duration
# def getAniSearch():


#Too easy to get banned
# def getanidbInfo(id):
#     urlTemplate = string.Template(
#     "https://anidb.net/anime/$id")
#     headers = {
#         'User-Agent': 'Mozilla/5.0 (Macintosh; Intel Mac OS X 10_11_5) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/50.0.2661.102 Safari/537.36',
#         "content-type": "text/html",

#     }
#     url = urlTemplate.substitute(id=id)
#     req = requests.get(url,headers=headers)
#     soup = BeautifulSoup(req.text, 'html.parser')
#     print(soup)
#     engTitle = soup.find("span", attrs={"title": "language: english"}).parent.parent.contents[3].get_text()
#     duration = soup.find(attrs={"class": "g_bubble duration"}).find(attrs={"class":"val"}).get_text()
#     duration=re.sub("approx\. +","",duration)
#     duration=re.sub("h"," hour",duration)
#     duration=re.sub("m"," minutes",duration)
#     duration=f"in {duration}"
#     release = soup.find(attrs={"title": "Complete Movie"})
#     print(release)


# # document.querySelectorAll("[title='Complete Movie']")[
# #     0].parentElement.parentElement.getElementsByClassName("date airdate")[0].textContent.split(".")


def matchImdb(title, year, runtime):
    imdbObjs = movieData.getMovieList(title)
    print(title)
    for obj in imdbObjs:
        obj = movieData.update(obj, "main")
        print(obj["original title"])
        if int(obj["year"]) != int(year):
            continue
        print(title)
        match1 = jellyfish.jaro_similarity(obj.get("title", ""), title)
        match2 = jellyfish.jaro_similarity(
            obj.get("localized title", ""), title)
        match3 = jellyfish.jaro_similarity(
            obj.get("original title", ""), title)
        print(max(match1, match2, match3))
        if max(match1, match2, match3) < .9:
            continue
        #compare time

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
