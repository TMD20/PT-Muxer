import os
import re
import textwrap

import mediatools.bdinfo as bdinfo
import demux.paths as paths
import tools.general as utils
import mediatools.extract as Extract



def getBdinfoData(sources):
    # Generate Bdinfo/TrackInfo for Each Source
    bdObjs = []
    for source in sources:
        print("Loading Playlists...\n")
        print(f"\n{source}\n")

        bdObj = bdinfo.Bdinfo()
        bdObj.setup(source)
        bdObj.playListSelect()
        bdObj.runbdinfo()
        bdObjs.append(bdObj)
    return bdObjs


def processBdinfo(sources, bdObjs, demuxData, dontConvert):
    for i in range(len(sources)):
        source = sources[i]
        bdObj = bdObjs[i]
        output = paths.createChildDemuxFolder(os.getcwd(), source)
        os.chdir(output)
        show = utils.sourcetoShowName(source)
        path = os.path.join(
            output, "output_logs", f"BDINFO.{show}.txt")
        print(f"Extracting BDINFO from {source}")
        bdObj.writeBdinfo(path)
        quickSums = bdObj.getQuickSum()
        streams = bdObj.getStreams()
        bdObj.getChapters()
        currentTracks = demuxData.addTracks(
            quickSums, bdObj.playlistNum, bdObj.playlistFile, streams, source, output)
        if not dontConvert:
            demuxData.convertFlac(currentTracks, output)
        os.chdir("..")


def getSources(options, inpath, sortpref):
    if len(options) == 0:
        print("No Valid Source Directories Found")
        quit()
    sources = addMultiSource(options, sortpref)
    if sources == None or len(sources) == 0:
        print("No sources Selected")
        quit()
    for i in range(0, len(sources)):
        if re.search(".iso", sources[i]):
            sources[i] = Extract(sources[i], inpath)
    return sources


def addMultiSource(paths, sortpref):
    msg = None

    if sortpref == "size":
        msg = \
            """

    Pick one or more Sources to Extract Files From

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


