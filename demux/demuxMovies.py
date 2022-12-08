import re
import textwrap
import os

from num2words import num2words

import tools.general as utils
from demux.base import Demux
import mediadata.movieData as movieData
import tools.paths as paths
import tools.directory as dir
import tools.logger as logger





class Demux(Demux):
    def __init__(self,args):
        super().__init__(args)
        self._name="Movies"
        self._type="Movies"


    def demux(self):
        with dir.cwd(self.demuxFolder):
            self._movieObj = movieData.MovieData("Movies")
            self._movieObj.setData(self._type,utils.getTitle(self.sources[0]))
            while True:
                bdObjs = self._setBdInfoData() 
                self.demuxPlaylist(bdObjs)
                if utils.singleSelectMenu(["Yes", "No"], "Extract more Movies") == "No":
                    break
                self.setSource()


    ####
    # Helper Functions
    ####
    def _getNewFolder(self,i=None):
        return os.path.join(self.demuxFolder)
    def _callFunction(self):
        if self._args.splitplaylist and self._args.splitplaylist>0:
            raise RuntimeError("splitplaylist Not allowed for Movie Mode")
        self.setSource()
        self._fixArgs()
        self.getDemuxFolder()
        self.demux()   
    def setSource(self):
        options = self._getBDMVs(self._args.inpath)
        self.sources = self.getSources(options,self._args.inpath,self._args.sortpref)

    def getSources(self,options, inpath, sortpref):
        if len(options) == 0:
            logger.info("No Valid Source Directories Found")
            raise RuntimeError("No Sources Directories Found")
        sources = self._addMultiSource(options, sortpref)     
        for i in range(0, len(sources)):
            if re.search(".iso", sources[i]):
                sources[i] = paths.extractISO(sources[i], inpath)
        return sources
    def getDemuxFolder(self):
        paths.mkdirSafe(self._args.outpath)
        self.demuxFolder=self.getDemuxFolderHelper(self.sources, self._args.outpath)        
    def getDemuxFolderHelper(self,sources, outpath):
        return self._createParentDemuxFolder(sources, outpath)

###
# Select
##


    def _addMultiSource(self,paths, sortpref):
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
            logger.logger.print(msg)
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

        


    
