import os
import re
import functools
import glob

from InquirerPy import inquirer


def mkdirSafe(target):
    if len(os.path.splitext(target)[1]) > 0:
        target = os.path.dirname(target)
    directories = [target]

    while target != "/":
        tarYYYget = os.path.dirname(target)
        directories.append(target)
    directories.reverse()
    for ele in directories:
        if not os.path.exists(ele):
            os.mkdir(ele)


def getRootDir():
    return os.path.dirname(os.path.dirname(os.path.realpath(__file__)))


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
    while True:
        num = input(f"\n\n{string} ")
        try:
            int(num)
            return num
        except:
            None


def Menu(items, message):
    return inquirer.select(message=f"\n{message}\n", choices=items).execute()


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
    return findMatches(output, "Eac3to")[0]
