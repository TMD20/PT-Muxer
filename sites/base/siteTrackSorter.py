
import copy
import os
import re

from app import main


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

    def sortTracks(self, movieLangs, audioPrefs, subPrefs, sortPrefs):
        self._groupTracks()
        self._sortTracksHelper(movieLangs, audioPrefs, subPrefs, sortPrefs)

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
    #       Sort Track Helpers
    ################################################################################################################

    def _sortTracksHelper(self, movieLangs, audioPrefs, subPrefs, sortPrefs):


        audioTracks = self._removeDupes(self._unSortedAudio)
        vidTracks = self._removeDupes(self._unSortedVideo)
        subTracks = self._removeDupes(self._unSortedSub)


        self._sortAudio(audioTracks,movieLangs, audioPrefs, sortPrefs)
        self._sortCompatAudio(audioTracks)
        self._sortSub(subTracks,subPrefs)
        self._sortVideo(vidTracks,sortPrefs)

    def _removeDupes(self, tracks):
        output = []
        for track in tracks:
            dupe = False
            for match in output:
                if match["langcode"]!=track["langcode"]:
                    continue
                if match["site_title"] != track["site_title"]:
                    continue
                if match["bdinfo_title"] != track["bdinfo_title"]:
                    continue
                # Greater then 10MB difference in size
                if os.path.getsize(match["file"])-os.path.getsize(track["file"]) > 10000000:
                    continue
                dupe = True
            if dupe == False:
                output.append(track)
        return output

    ################################################################################################################
    #       These Functions Will make a best effort to sort Tracks in a way that fits within site rules
    #        Because Every Site has different Rules about What Track to Put First, and which ones not to include this
    #        will have to be overwritten based on Site.
    ############################################

    def _sortAudio(self,audioTracks, movieLangs, audioPrefs, sortPref):
        mainTracks = []
        if len(audioPrefs) != 0:
            for lang in audioPrefs:
                # Get All Tracks That Match This Language
                newTracks = [ele for ele in audioTracks if ele["lang"]
                             == lang and ele["compat"] == False]
                if len(newTracks) == 0:
                    continue
                if sortPref == "size":
                    newTracks = sorted(
                        newTracks, key=self._AudioRankingSize, reverse=True)
                # Add Every English Track
                if lang == "English":
                    mainTracks.extend(newTracks)
                    continue
                # Add only First Track of Other Lang
                mainTracks.append(newTracks[0])

        else:
            # Priotize Main Movie Languages
            for lang in movieLangs:
                # Get All Tracks That Match This Language
                newTracks = [ele for ele in audioTracks if ele["lang"]
                             == lang and ele["compat"] == False]
                if len(newTracks) == 0:
                    continue
                if lang == "English":
                    continue
                if sortPref == "size":
                    newTracks = sorted(
                        newTracks, key=self._AudioRankingSize, reverse=True)
                # Add First Track of Every Language
                mainTracks.append(newTracks[0])

            # Add Every English Track
            newTracks = [ele for ele in audioTracks if ele["lang"]
                         == "English" and ele["compat"] == False]
            if sortPref == "size":
                newTracks = sorted(
                    newTracks, key=self._AudioRankingSize, reverse=True)
            mainTracks.extend(newTracks)
        self._enabledAudio.extend(mainTracks)

    def _sortCompatAudio(self, audioTracks):
        # Get all compat tracks
        tracks = list(
            filter(lambda x: x["compat"] == True, audioTracks))
        # Filter out things like DTS Core which will have no title
        
               

        tracks = list(
            filter(lambda x: x["site_title"] != None, tracks))
        # Add Every Compat Track with Matching Parent
    
        for track in tracks:
            for i in range(len(self._enabledAudio)):
                match = self._enabledAudio[i]
                if match["bdinfo_title"] == track["parent"]:
                    # insert Right After current matching track
                    self._enabledAudio.insert(i+1,track)
                  
                    break

    def _sortSub(self, subTracks,subPrefs):
        # User Passed language prefs
        mainTracks=[]
        if subPrefs:
            for lang in subPrefs:
                newTracks = [ele for ele in subTracks if ele["lang"]
                     == lang and ele["compat"] == False]
                if len(newTracks)==0:
                    continue
                 #Add All English Tracks
                if lang=="English":
                    mainTracks.extend(newTracks)
                else:
                    mainTracks.append(newTracks[0])
            self._enabledSub.extend(mainTracks)    

        # AutoGenerate Order
        else:
            langSet = set()
            # Add First Track For everyother Language
            for track in subTracks:
                if track["lang"] in langSet:
                    continue
                if track["lang"] == "English":
                    continue
                langSet.add(track["lang"])
                mainTracks.append(track)
            # Sort Semi Alphabetically with English Track First
            mainTracks = sorted(mainTracks, key=self._subAlphaOrder)
            #Add English Tracks
            newTracks = [ele for ele in subTracks if ele["lang"]
                         == "English" and ele["compat"] == False]
            newTracks.extend(mainTracks)
            self._enabledSub.extend(newTracks)    

    def _sortVideo(self, vidTracks,sortPref):
        newTracks = copy.deepcopy(vidTracks)
        if sortPref == "size":
            newTracks = sorted(newTracks,
                               key=self._VideoRankingSize, reverse=True)
        self._enabledVideo.append(newTracks[0])

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

    def _subAlphaOrder(self, track):
        return track["lang"]
       
