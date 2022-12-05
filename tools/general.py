import os
import re
import functools
import glob
import pathlib
import sys
import textwrap
import shutil
import sys


import pynumparser
from InquirerPy import inquirer
import arrow
from guessit import guessit

import tools.paths as paths

def convertArrow(input, parse):
    return arrow.get(input, parse)
def signal_handler(sig, frame):
    print('You pressed Ctrl+C!')
    sys.exit(0)

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
def getFormated(format,time=None):
    if time==None:
        return arrow.get().format(format)
    return arrow.get(time).format(format)




def sourcetoShowName(path):
    path = paths.convertPathType(path, "Linux")
    show=path
    if re.search(path,"D[0-9]|Disc"):
        show = str(pathlib.Path(path).parents[0])
    show = os.path.basename(show)
    show = re.sub(" +", " ", show)
    show = re.sub(" ", ".", show)

    return show


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





def getTitle(source):

    parent = str(pathlib.Path(source).parents[1])
    if re.search("(BD25|BD50)", parent, re.IGNORECASE):
        None
    elif re.search("D[0-9]", source, re.IGNORECASE) or re.search("Disk [0-9]", parent, re.IGNORECASE):
        parent = str(pathlib.Path(parent).parents[0])
    return guessit(parent)["title"]


def cleanString(val):
    import unicodedata
    clean_text = unicodedata.normalize("NFKD", val)
    return clean_text


def smart_truncate(content, length=100, suffix='...'):
    if len(content) <= length:
        return content
    else:
        return content[:length].rsplit(' ', 1)[0]+suffix



def getSystem():
    if sys.platform == "linux":
        return "Linux"
    else:
        return "Windows"
def getShell():
    if sys.platform=="linux":
        return "bash"
    else:
        return None
def rmDir(path):
    shutil.rmtree(path)
