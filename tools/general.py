import os
import re
import functools
import glob
import pathlib
import sys
import textwrap

import pynumparser
from InquirerPy import inquirer
import arrow
from guessit import guessit


def convertArrow(input, parse):
    return arrow.get(input, parse)


def subArrowTime(large, small):
    large = large.shift(hours=-small.hour)
    large = large.shift(minutes=-small.minute)
    large = large.shift(seconds=-small.second)
    large = large.shift(microseconds=-small.microsecond)
    return large


def addArrowTime(large, small):
    large = large.shift(hours=+small.hour)
    large = large.shift(minutes=+small.minute)
    large = large.shift(seconds=+small.second)
    large = large.shift(microseconds=+small.microsecond)
    return large


def dehumanizeArrow(input):
    now = arrow.utcnow()
    return now.dehumanize(input)


def mkdirSafe(target):
    directories = list(reversed(pathlib.Path(target).parents))
    if len(os.path.splitext(target)[1]) == 0:
        directories.append(target)
    for ele in directories:
        if not os.path.exists(ele):
            os.mkdir(ele)


def sourcetoShowName(path):
    path = convertPathType(path, "Linux")
    show = str(pathlib.Path(path).parents[1])
    show = os.path.basename(show)
    show = re.sub(" +", " ", show)
    show = re.sub(" ", ".", show)

    return show


def findMatches(path, string, ext=None):
    paths = glob.glob(os.path.join(path, "**", string), recursive=True)
    if ext != None:
        paths = list(filter(lambda x: os.path.splitext(x), paths))
    return paths


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


def getIntInput(string, maxVal=float("inf")):
    return int(inquirer.number(
        min_allowed=1,
        max_allowed=maxVal,
        message=string,
        mandatory=True
    ).execute())


def singleSelectMenu(items, message):
    return inquirer.select(mandatory=True, message=textwrap.dedent(f"\n{message}\n"), choices=items).execute()


def rawSelectMenu(items, message):
    return inquirer.rawlist(mandatory=True, message=textwrap.dedent(f"\n{message}\n"), choices=items).execute()


def multiSelectMenu(items, message):
    return inquirer.checkbox(validate=lambda x: len(x) > 0, invalid_message="Must Select at Least One item", mandatory=True, message=textwrap.dedent(f"\n{message}\n"), choices=items).execute()


def textEnter(message, default=None):
    if default != None:
        return inquirer.text(mandatory=True, validate=lambda x: len(x) > 0, invalid_message="Input can not be empty", message=textwrap.dedent(f"\n{message}\n"), default=default).execute()
    return inquirer.text(mandatory=True, validate=lambda x: len(x) > 0, invalid_message="Input can not be empty", message=textwrap.dedent(f"\n{message}\n")).execute()


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


def convertPathType(folder, type):
    if type == "Linux":
        return str(pathlib.PurePosixPath(folder))
    return str(pathlib.PureWindowsPath(pathlib.PurePosixPath(folder)))


def getTitle(source):

    parent = str(pathlib.Path(source).parents[1])
    if re.search("(BD25|BD50)", parent, re.IGNORECASE):
        None
    elif re.search("D[0-9]", source, re.IGNORECASE) or re.search("Disk [0-9]", parent, re.IGNORECASE):
        source = str(pathlib.Path(source).parents[0])
    return guessit(source)["title"]


def cleanString(val):
    import unicodedata
    clean_text = unicodedata.normalize("NFKD", val)
    return clean_text


def smart_truncate(content, length=100, suffix='...'):
    if len(content) <= length:
        return content
    else:
        return content[:length].rsplit(' ', 1)[0]+suffix


def getRelativeTo(track, levelUp):
    """
    Returns the relative Path of a file/folder from one of it's parents


    Parameters
    ----------

    track : str
        Track whose relative path you want
    levelup: int
        How many levels up the parent tree


    Returns
    -------

    str
        Relative path to file from one of the parents
    """

    return str(pathlib.Path(track).relative_to(pathlib.Path(track).parents[levelUp-1]))


def getSystem():
    if sys.platform == "linux":
        return "Linux"
    else:
        return "Windows"
