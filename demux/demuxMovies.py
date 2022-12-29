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
    """
    This class is for demuxing Movies

    Args:
        Demux (class): demuxBase class
    """
    def __init__(self, args):
        super().__init__(args)
        self._name = "Movies"
        self._type = "Movies"

    def demux(self):
        """
        Gathers Information from a selected movie Title
        Generates BDINFO Data for all soruces 
        Demuxes Movie based on args and selected playlist
        """
        with dir.cwd(self.demuxFolder):
            self._movieObj = movieData.MovieData("Movies")
            self._movieObj.setData(
                self._type, (self._args.title or utils.getTitle(self.sources[0])))
            bdObjs = self._setBdInfoData()
            self.demuxPlaylist(bdObjs)

    def _callFunction(self):
        """
        Helper main function called by internal __call__ function 
        Raises:
            RuntimeError:Error raise if splitplaylist arg is true
        """
        if self._args.splitplaylist:
            raise RuntimeError("splitplaylist Not allowed for Movie Mode")
        self.setSource()
        self._fixArgs()
        self.setDemuxFolder()
        self.demux()

    def setSource(self):
        """
        Filters sources in input directories based on user selection
        """
        options = self._getBDMVs(self._args.inpath)
        self.sources = self.getSources(
            options, self._args.inpath, self._args.sortpref)

    def getSources(self, options, inpath, sortpref):
        """
        Returns array of selected paths, based on user input

        Args:
            options (array): compatible paths from input folder
            inpath (str): inpath used to generate options
            sortpref (str): How tracks should be sorted
        Raises:
            RuntimeError: Error raised if no valid source is found

        Returns:
            array: Array of selected sources, and extracted ISO
        """
        if len(options) == 0:
            raise RuntimeError("No Sources Found")
        sources = self._addMultiSource(options, sortpref)
        for i in range(0, len(sources)):
            if re.search(".iso", sources[i]):
                sources[i] = paths.extractISO(sources[i], inpath)
        return list(map(lambda x: paths.convertPathType(x, type="Linux"), sources))

    def setDemuxFolder(self):
        """
        Ensures outpath from args exists

        sets demuxfolder property of demuxObJ
        """
        paths.mkdirSafe(self._args.outpath)
        self.demuxFolder = self.setDemuxFolderHelper(
            self.sources, self._args.outpath)

    def setDemuxFolderHelper(self, sources, outpath):
        """
        Returns parent demux folder path based on source and outputpath

        Args:
            sources (aarray): array of sources
            outpath (str): outpath from args

        Returns:
            str : path to generated parent demux Folder
        """
        return self._createParentDemuxFolder(sources, outpath)

###
# Select
##

    def _addMultiSource(self, paths, sortpref):
        """
        Takes a list of source paths, and allows users to filter list based on input

        Args:
            sources (array): List of potential sources
            sortpref (str): user prefrences for sorting tracks/sources

        Returns:
            str: list of selected sources

        """

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
            You will be prompted multiple times to make a 
            selection
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
