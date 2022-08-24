import re
import textwrap

import mediatools.bdinfo as bdinfo
import tools.general as utils
import mediatools.extract as Extract
import config
import demux.paths as paths
import remux.helper as remuxHelper



def getBdinfoData(sources):
    bdObjs = []
    for source in sources:
        print(f"\n{source}\n")
        print("Loading Playlists...\n")
        bdObj = bdinfo.Bdinfo()
        bdObj.setup(source)
        bdObj.playListRangeSelect()
        bdObjs.append(bdObj)
    return bdObjs


def getStreamsLength(streams):
    duration = 0
    start = utils.convertArrow(streams[0]["start"], "hh:mm:ss.SSS")
    end = utils.convertArrow(streams[-1]["end"], "hh:mm:ss.SSS")
    dif = utils.subArrowTime(end, start)
    duration = (duration+dif.hour*60)
    duration = (duration+dif.minute)
    duration = (duration+(dif.second/60))
    return duration


def getNewStartTime(startTime, streams):
    start = utils.convertArrow(streams[0]["start"], "hh:mm:ss.SSS")
    end = utils.convertArrow(streams[-1]["end"], "hh:mm:ss.SSS")
    dif = utils.subArrowTime(end, start)
    startTime = utils.addArrowTime(startTime, dif)
    return startTime


def getSources(options,inpath, sortpref,multi):
    if len(options) == 0:
        print("No Valid Source Directories Found")
        quit()
    sources = None
    if multi:
        sources = addMultiSource(options, sortpref)
    else:
        sources = [addSingleSource(options)]
    for i in range(0, len(sources)):
        if re.search(".iso", sources[i]):
            sources[i] = paths.Extract(sources[i], inpath)
    return sources


def addMultiSource(paths, sortpref):
    msg = None

    if sortpref == "size":
        msg = \
            """

    Pick one or more Sources to Extract Files From
    Note: This is For a single episode
    Program Will run Multiple Times

    Controls
    Space: Select
    Enter: Submit Selection
    Ctrl-R or Alt-R: Toggle All
    """
        return utils.multiSelectMenu(paths, msg)
    else:
        msg = textwrap.dedent(
        """
        Since you selected --sortpref order
        You will be prompted multiple times to make a selection
        """)
        print(msg)
        list = ["I'm done selecting sources", "I want to reset my list"]
        list.extend(paths)
        selection = []
        while True:
            msg = \
            f"""
            Add a source to extract files from
            Current Sources: {selection}
            For TV Shows you can change the Source(s) Per Episode

            Controls
            Enter: Submit Selection
            """
            curr_select = utils.singleSelectMenu(list, msg)
            selection.append(curr_select)
            if curr_select == "I want to reset my list":
                selection = []
            if curr_select == "I'm done selecting sources":
                break
        selection = list(filter(lambda x: x != "done" and x != None))
        selection = utils.removeDupesList(selection)
        return selection


def addSingleSource(paths):
    msg = \
        """
        Pick a source to extract files from

        Controls
        Enter: Submit Selection
        """
    return utils.singleSelectMenu(paths, msg)


def getDemuxFolder(sources, outpath):
    if utils.singleSelectMenu(["Yes", "No"], "Restore Folder Old MuxFolder Data") == "Yes":
        print("Searching for Prior TV Mode Folders")
        folders = remuxHelper.getTVMuxFolders(outpath, config.demuxPrefix)
        if len(folders) == 0:
            print("No TV Mode Folders Found To Restore")
            print("Creating a new Mux Folder")
            return paths.createParentDemuxFolder(
                sources, outpath)
        else:
            folder = utils.singleSelectMenu(
                folders, "Which Folder Do you want to Restore")

            return folder
    else:
        return paths.createParentDemuxFolder(sources, outpath)
