import mediatools.bdinfo as bdinfo

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
