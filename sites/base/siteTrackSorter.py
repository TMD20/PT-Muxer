
import os
import re


class siteSorter():
    def __init__(self):
        self._unSortedAudio = []
        self._unSortedVideo = []
        self._unSortedSub = []
        self._enabledAudio = []
        self._enabledSub = []
        self._enabledVideo = []
        self._tracksDataObj = None
    """
    Public Functions
    """

    def sortTracks(self, pref):
        self._groupTracks()
        self._sortTracksHelper(pref)

    """
    Setters/Getters
    """
    @property
    def tracksDataObj(self):
        return self._tracksDataObj

    @tracksDataObj.setter
    def tracksDataObj(self, a):
        self._tracksDataObj = a

    @property
    def unSortedAudio(self):
        return self._unSortedAudio

    @property
    def unSortedVideo(self):
        return self._unSortedVideo

    @property
    def unSortedSub(self):
        return self._unSortedSub

    @property
    def enabledAudio(self):
        return self._enabledAudio

    @property
    def enabledVideo(self):
        return self._enabledVideo

    @property
    def enabledSub(self):
        return self._enabledSub

    """
    Private Functions
    """

    #####################################################################################################################
    #       Adds Tracks to Unsorted List based on Type
    ################################################################################################################

    def _groupTracks(self):
        sources = list(self._tracksDataObj.rawMediaTracksData.keys())
        for key in sources:
            tracks = self._tracksDataObj.rawMediaTracksData[key]["tracks"]
            for track in tracks:
                type = track["type"]
                if type == "audio":
                    self._unSortedAudio.append(track)
                elif type == "video":
                    self._unSortedVideo.append(track)
                elif type == "subtitle":
                    self._unSortedSub.append(track)

    #####################################################################################################################
    #       Sort Track Helper
    ################################################################################################################

    def _sortTracksHelper(self, pref):
        self._sortAudio(pref)
        self._sortCompatAudio()
        self._sortSub()
        self._sortVideo(pref)

    ################################################################################################################
    #       These Functions Will make a best effort to sort Tracks in a way that fits within site rules
    #        Because Every Site has different Rules about What Track to Put First, and which ones not to include this
    #        will have to be overwritten based on Site.
    ############################################
    def _sortAudio(self, pref):
        # Sort/Filter
        # Based on Prioritizing English/ 
        # Secondly the Main Track Language if English Not availbile
        # Either Order or Size of Track
        # Include All English Tracks
        mainTracks = [ele for ele in self._unSortedAudio if ele["lang"]
                      == "English" and ele["compat"] == False]
        if len(mainTracks) == 0:
            mainTracks = [ele for ele in self._unSortedAudio if ele["lang"]
                          == self._unSortedAudio[0]["lang"] and ele["compat"] == False]
        if pref == "largest":
            self._enabledAudio.extend(
                sorted(mainTracks, key=self._AudioRankingSize, reverse=True))
        else:
            self._enabledAudio.extend(mainTracks)

    def _sortCompatAudio(self):
        tracks = list(
            filter(lambda x: x["compat"] == True, self._unSortedAudio))
        # Filter out things like DTS Core which will have no title
        tracks = list(
            filter(lambda x: x["site_title"] != None == True, tracks))

        indexes = list(map(lambda x: x["index"], self._enabledAudio))
        sources = list(map(lambda x: x["sourceDir"], self._enabledAudio))
        for i in range(0, len(indexes)):
            tracksData = list(map(lambda x: x["index"] == indexes[i], tracks))
            tracksData = list(
                map(lambda x: x["sourceDir"] == sources[i], tracksData))
            self._enabledAudio.extend(tracksData)

    def _sortSub(self):
        # Sort Subs By Language
        #Special Tracks Will have to be added later
        #Add First and Only First Subtrack for each language
        langSet = set()
        for track in self._unSortedSub:
            if track["lang"] not in langSet:
                self._enabledSub.append(track)
                langSet.add(track["lang"])
        self._enabledSub = sorted(self._enabledSub, key=self._SubBdinfoOrder)

    def _sortVideo(self, pref):
        langSet = set()
        if pref == "first":
            self._enabledVideo.append(self._unSortedVideo[0])
        elif pref == "largest":
            self._enabledVideo.append(sorted(self._unSortedVideo,
                                             key=self._VideoRankingSize, reverse=True)[0])
    #########################################################################################
    # Helper Functions to Rank Tracks
    #
    ##########################################################################################

    def _AudioRankingSize(self, track):
        title = track["bdinfo_title"]
        size = os.path.getsize(track["file"])
        # lossless
        if re.search("LPCM|TrueHD|DTS-HD MA|DTS:.*?X|FLAC", title, re.IGNORECASE) != None:
            return 1+(size/100*100000000)
        # lossly
        else:
            return 10+(size/100*100000000)

    def _VideoRankingSize(self, track):
        size = os.path.getsize(track["file"])
        return size

    def _SubBdinfoOrder(self, track):
        ranking=track["lang"]
        if track["lang"]=="English":
            ranking=10000000
