import os
import re
import functools
import glob
from pathlib import PureWindowsPath, PurePosixPath
import textwrap

import pynumparser
from InquirerPy import inquirer
import arrow
from guessit import guessit

def convertArrow(input,parse):
    return arrow.get(input,parse)
def subArrowTime(large,small):
    large=large.shift(hours=-small.hour)
    large=large.shift(minutes=-small.minute)
    large=large.shift(seconds=-small.second)
    large=large.shift(microseconds=-small.microsecond)
    return large
def addArrowTime(large,small):
    large=large.shift(hours=+small.hour)
    large=large.shift(minutes=+small.minute)
    large=large.shift(seconds=+small.second)
    large=large.shift(microseconds=+small.microsecond)
    return large
def dehumanizeArrow(input):
    now = arrow.utcnow()
    return now.dehumanize(input)


def mkdirSafe(target):
    if len(os.path.splitext(target)[1]) > 0:
        target = os.path.dirname(target)
    directories = [target]

    while target != "/":
        target = os.path.dirname(target)
        directories.append(target)
    directories.reverse()
    for ele in directories:
        if not os.path.exists(ele):
            os.mkdir(ele)


def getShowName(path):
    show = re.sub("/BDMV/STREAM", "", path)
    show = os.path.basename(show)
    show = re.sub(" +", " ", show)
    show = re.sub(" ", ".", show)
    return show


def findMatches(path, string):
    return glob.glob(os.path.join(path, "**", string), recursive=True)


def requiredClassAttribute(*required):
    # outter decorator takes in args which is scoped to inner decorator
    # Decorator requires we return a function that expects a function argument
    def requiredAttributeHelper(func):
        @functools.wraps(func)
        def wrapper(self, *args, **kwargs):
            for ele in required:
                if getattr(self, ele, None) == None:
                    raise RuntimeError(f"Required Parameter{ele} not set")
                return func(self, *args, **kwargs)
        return wrapper
    return requiredAttributeHelper


def removeDupesList(list):
    dupe = set()
    res = []
    for ele in list:
        if ele not in dupe:
            res.append(ele)
            dupe.add(ele)
    return res


def getIntInput(string):
    return inquirer.number(
        min_allowed=1,
        message=string,
    ).execute()


def singleSelectMenu(items, message):
    return inquirer.select(mandatory=True, message=textwrap.dedent(f"\n{message}\n"), choices=items).execute()


def rawSelectMenu(items, message):
    return inquirer.rawlist(mandatory=True, message=textwrap.dedent(f"\n{message}\n"), choices=items).execute()

def multiSelectMenu(items, message):
    return inquirer.checkbox(mandatory=True, message=textwrap.dedent(f"\n{message}\n"), choices=items).execute()


def textEnter(message, default=None):
    if default != None:
        return inquirer.text(mandatory=True, message=textwrap.dedent(f"\n{message}\n"), default=default).execute()
    return inquirer.text(mandatory=True, message=textwrap.dedent(f"\n{message}\n")).execute()


def getRangeOfNumbers(message, default=None):
    text = textEnter(message, default)
    parser = pynumparser.NumberSequence(numtype=int)
    try:
        return list(parser.parse(text))
    except:
        return


def validateFiles(fileList):
    for file in fileList:
        if not os.path.exists(file):
            return file


def getBdinfo(remuxConfig):
    key = str(remuxConfig["Enabled_Tracks"]["Video"][0])
    output = os.path.dirname(
        remuxConfig["Tracks_Details"]["Video"][key]["file"])
    return findMatches(output, "BDINFO*")[0]


def getEac3to(remuxConfig):
    key = str(remuxConfig["Enabled_Tracks"]["Video"][0])
    output = os.path.dirname(
        remuxConfig["Tracks_Details"]["Video"][key]["file"])
    return findMatches(output, "Eac3to*")[0]


def getwinepath(folder):
    return str(PureWindowsPath(PurePosixPath(folder)))


def getTVMuxFolders(inpath, demuxPrefix):
    folders = findMatches(inpath, f"{demuxPrefix}*")
    # only get root directories

    folders = list(filter(lambda x: len(os.listdir(x)) != 0, folders))


    folders = list(filter(lambda x: re.search(
        "^[0-9]+$", os.listdir(x)[0]) != None, folders))

    return folders


def getMovieMuxFolders(inpath, demuxPrefix):
    folders = findMatches(inpath, f"{demuxPrefix}*")
    # only get root directories

    folders = list(filter(lambda x: os.path.realpath(
        os.path.dirname(x)) == os.path.realpath(inpath), folders))
    folders = list(filter(lambda x: re.search(
        "^[0-9]+$", os.listdir(x)[0]) == None, folders))
    return folders
def getTitle(source):
    return guessit(source)["title"]


def cleanString(val):
    import unicodedata
    clean_text = unicodedata.normalize("NFKD", val)
    return clean_text
