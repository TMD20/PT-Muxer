import os

from simple_term_menu import TerminalMenu


def getOutputList(path):
    demuxList = []
    for tuple in os.walk(path):
        dir = tuple[0]
        files = tuple[2]
        for file in files:
            if file == "output.txt":
                demuxList.append(os.path.join(dir, file))
    return demuxList


def pickOutput(demuxList):
    if len(demuxList) == 0:
        print("Deep Search of Directory Could Not Find any output.txt Files")
        quit()
    return demuxList[TerminalMenu(demuxList).show()]


def getSources(remuxConfig):
    list = [key for key in remuxConfig["Sources"]]
    return list


def getChapterFile(remuxConfig):
    key = list(remuxConfig["Sources"].keys())[0]
    return os.path.join(remuxConfig["Sources"][key]["Output"], "chapters.txt")



