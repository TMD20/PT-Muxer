import re
import tools.general as utils
import mediatools.extract as Extract



def addMultiSource(paths,sortpref,type):
    if len(paths) == 0:
        print("No Valid Source Directories Found")
        quit()
    msg=None
    if sortpref=="size":
        msg = \
        """
        Click on the Source(s) You Want for this Demux

        TV Mode will run multiple times
        for more advanced source selection

        Press Space to add/remove selection
        Press Enter when Done
        """
        return utils.multiSelectMenu(paths, msg)
    else:
        msg = \
        """
Since you selected --sortpref order
You will be prompted multiple times to make a selection
Pay attention to the order of the list printed out, as this will effect enabled tracks

Click on the Source You Want for this Demux
For TV Shows you can change the Source(s) Per Episode

When Finish Click 'I'm Done Selecting Sources'
        """
        list=["I'm done selecting sources","I want to reset my list"]
        list.extend(paths)
        selection=[]
        while True:
            print(f"Your list thus far\n\n")
            print("\n".join(selection))
            curr_select = utils.singleSelectMenu(list, msg)
            selection.append(curr_select)
            if curr_select == "I want to reset my list":
                selection=[]
            if curr_select=="I'm done selecting sources":
                break
        selection=list(filter(lambda x:x!="done" and x!=None))
        selection=utils.removeDupesList(selection)
        return selection

def addSingleSource(paths):
    if len(paths) == 0:
        print("No Valid Source Directories Found")
        quit()
    msg = \
        """
        Click on the Source You Want for this Demux

        TV Mode will run multiple times
        for more advanced source selection

        Press Enter to confirm when Done
        """
    return utils.singleSelectMenu(paths, msg)




def getSources(options, inpath, sortpref, multi=True):
    sources = None
    if multi:
        sources = addMultiSource(options, sortpref,type)
    else:
        sources = [addSingleSource(options)]
    for i in range(0, len(sources)):
        if re.search(".iso", sources[i]):
            sources[i] = Extract(sources[i], inpath)
    return sources


