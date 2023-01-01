from __future__ import annotations 
import copy
import os
import re
import subprocess
import itertools
from typing import TYPE_CHECKING, List,Union



import xxhash


import src.tools.general as utils
import src.tools.commands as commands
import src.tools.install as install
if TYPE_CHECKING:
    import mediadata.trackObj as trackObj


class siteTrackSorter():
    """
    Base class for sorting tracks
    """    
    def __init__(self):
        self._unSortedAudio = []
        self._unSortedVideo = []
        self._unSortedSub = []
        self._enabledAudio = []
        self._enabledSub = []
        self._enabledVideo = []
        self._tracks = []
    """
    Public Functions
    """
    def addTracks(self,tracks:List[trackObj.TrackObJ])->None:
        self._tracks.extend(tracks)
        """
        Extends internal tracks list with new Tracks

        Args:
            tracks (array): An array of trackObjs
        """ 
    
    def sortTracks(self, movieLangs:List[str], audioPrefs:List[str], subPrefs:List[str], sortPref:str)->None:
        """
        Sorts tracks based on user prefrence
        adds sortred tracks into internal class arrays

        Args:
            movieLangs (array): list of languages in movie
            audioPrefs (array):  list of users language preference
            subPrefs (array): list of user subtitle langauge preference
            sortPrefs (str): users prefence for which track should get higher priority
        """        
        self._groupTracks()
        self._sortTracksHelper(movieLangs, audioPrefs, subPrefs, sortPref)

    # Get Forced Subs Based on Audio Preference

    def addForcedSubs(self, movieLang:List[str], audioPref:List[str])->None:
        """
        Extends tracks list with forced subs

        Args:
            movieLangs (array): list of languages in movie
            audioPrefs (array):  list of users language preference
        """    
            
        audioLangs = self._getAudioPrefs(movieLang, audioPref)[0]
        if len(audioLangs)>=2:forcedSubLangs=audioLangs[0:2]
        else:forcedSubLangs=audioLangs[0:1]
        primary = []
        all = []
        # Get Forced Subtitles
        if install.javaInstallCheck()==False:
            print("Could Not Get Java\nSkipping Extraction of embedded forced subs")
        for oldTrack in self._unSortedSub:
            if oldTrack["lang"].lower() not in forcedSubLangs:
                continue
            oldFile = oldTrack.getTrackLocation()
            newFileName = re.sub("\.sup", ".forced.sup", oldFile)
            command = list(itertools.chain.from_iterable(
                [commands.bdSup2Sub(), [oldFile, "-o", newFileName, "--forced-only"]]))
            output = ""
            with subprocess.Popen(command, stdout=subprocess.PIPE, stderr=subprocess.STDOUT, universal_newlines=True, bufsize=1) as p:
                for line in p.stdout:
                    print(line, end='')
                    output = output+line
    
                p.wait()

                # Forced Sub Not Even made
                if re.search("Detected 0 forced captions", output):
                    continue

                self._insertForcedSubHelper(oldTrack,forcedSubLangs,newFileName)
    """
    Setters/Getters
    """
    @property
    def tracks(self)->List[trackObj.TrackObJ]:
        """
        returns all tracks added to object
        Returns:
            array: An array of trackObjs
        """
        return self._tracks


    @property
    def unSortedAudio(self)->List[trackObj.TrackObJ]:
        """
        returns all audio tracks added to object
        Returns:
            array: An array of audio trackObjs
        """    
        return self._unSortedAudio

    @property
    def unSortedVideo(self)->List[trackObj.TrackObJ]:
        """
        returns all video tracks added to object
        Returns:
            array: An array of video trackObjs
        """   
        return self._unSortedVideo

    @property
    def unSortedSub(self)->List[trackObj.TrackObJ]:
        """
        returns all sub tracks added to object
        Returns:
            array: An array of sub trackObjs
        """ 
        return self._unSortedSub

    @property
    def enabledAudio(self)->List[trackObj.TrackObJ]:
        """
        returns sorted and filtered audio tracks
        Returns:
            array: An array of sorted and filtered audio tracks
        """         
        return self._enabledAudio

    @property
    def enabledVideo(self)->List[trackObj.TrackObJ]:
        """
        returns sorted and filtered video tracks
        Returns:
            array: An array of sorted and filtered video tracks
        """                
        return self._enabledVideo

    @property
    def enabledSub(self)->List[trackObj.TrackObJ]:
        """
        returns sorted and filtered sub tracks
        Returns:
            array: An array of sorted and filtered sub tracks
        """         
        return self._enabledSub

    """
    Private Functions
    """

    #####################################################################################################################
    #       Adds Tracks to Unsorted List based on Type
    ################################################################################################################

    def _groupTracks(self)->None:
        """
        Adds tracks into arrays based on type
        """
        for track in self._tracks:
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

    def _sortTracksHelper(self, movieLangs:List[str], audioPrefs:List[str], subPrefs:List[str], sortPref:str)->None:
        """
        Sort tracks and filter tracks into arrays based on type

        Args:
            movieLangs (array): list of languages in movie
            audioPrefs (array):  list of users language preference
            subPrefs (array): list of user subtitle langauge preference
            sortPrefs (str): users prefence for which track should get higher priority
        """
        audioTracks = self._removeDupes(self._unSortedAudio)
        vidTracks = self._removeDupes(self._unSortedVideo)
        subTracks = self._removeDupes(self._unSortedSub)
        # sanitize prefs
        audioLang = self._getAudioPrefs(movieLangs, audioPrefs)
        subPrefs = utils.removeDupesList(subPrefs)
        # set default track

        self._sortAudio(audioTracks, audioLang, sortPref)
        self._sortCompatAudio(audioTracks)
        self._sortSub(subTracks, subPrefs, audioLang)
        self._sortVideo(vidTracks, sortPref)

    def _removeDupes(self, tracks:List[trackObj.TrackObJ])->List[trackObj.TrackObJ]:
        """
        Removes tracks that are found to have enough similar attributes (Dupes)

        Args:
            tracks (array): An array of trackObjs

        Returns:
            array: Filtered array of trackObjs

        """
        output = []
        for track in tracks:
            dupe = False
            for match in output:
                if match["langcode"] != track["langcode"]:
                    continue
                if match["site_title"] != track["site_title"]:
                    continue
                if match["bdinfo_title"] != track["bdinfo_title"]:
                    continue
                # Greater then 10MB difference in size
                if os.path.getsize(match.getTrackLocation())-os.path.getsize(track.getTrackLocation()) > 10000000:
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

    def _sortAudio(self, audioTracks:List[trackObj.TrackObJ], audioLang:List[str], sortPref:str)->None:
        """
        Sorts and filters audio tracks

        Args:
            audoTracks (array): array of audio trackObj
            audioLang (array):  list of languages
            sortPrefs (str): users prefence for which track should get higher priority
        """
        mainTracks = []
        for lang in audioLang:
            # Get All Tracks That Match This Language
            newTracks = [ele for ele in audioTracks if ele["lang"].lower()
                         == lang and ele["compat"] == False]
            # set original language flag
            if lang == audioLang[0]:
                for track in newTracks:
                    track["original"] = True
            if len(newTracks) == 0:
                continue
            if sortPref == "size":
                newTracks = sorted(
                    newTracks, key=self._AudioRankingSize, reverse=True)
            # Add First Track of Every Language
            if lang != "English":
                mainTracks.append(newTracks[0])
            # Add Every English Track
            else:
                mainTracks.extend(newTracks)
        # Make Main Audio Default
        if len(mainTracks) > 0:
            mainTracks[0]["default"] = True
        self._enabledAudio.extend(mainTracks)

    def _sortCompatAudio(self, audioTracks:List[trackObj.TrackObJ])->None:
        """
        Sorts and filters compat audio tracks

        Args:
            audoTracks (array): array of compat audio trackObjs
        """        
        # Get all compat tracks
        tracks = list(
            filter(lambda x: x["compat"] == True, audioTracks))
        # Filter out things like DTS Core
        tracks = list(
            filter(lambda x: x["parent"] != None, tracks))
        tracks = list(
            filter(lambda x: re.search("True", x["parent"], re.IGNORECASE) != None, tracks))
        # Add Every Compat Track with Matching Parent

        for track in tracks:
            for i in range(len(self._enabledAudio)):
                match = self._enabledAudio[i]
                if match["bdinfo_title"] == track["parent"]:
                    # insert Right After current matching track
                    self._enabledAudio.insert(i+1, track)

                    break

    def _sortSub(self, subTracks:List[trackObj.TrackObJ], subPrefs:List[str], audioLang:List[str])->None:
        # tempdict for tracks to add
        """
        Sorts and filters sub tracks

        Args:
            subTracks (array): array of trackObj with subtitle type
            subPrefs (array): list of user subtitle langauge preference

            audioLang (array):  list of languages
        """        
        mainTracks = []
        if subPrefs:
            for lang in subPrefs:
                newTracks = [ele for ele in subTracks if ele["lang"].lower()
                             == lang and ele["compat"] == False]
                if len(newTracks) == 0:
                    continue
                 # Add All English Tracks
                if lang == "english":
                    # Special Rule for Foriegn Films
                    if audioLang[0] != "english":
                        newTracks[0]["default"] = True
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
            # Sort Alphabetically
            mainTracks = sorted(mainTracks, key=self._subAlphaOrder)
            # Add English Tracks
            newTracks = [ele for ele in subTracks if ele["lang"]
                         == "English" and ele["compat"] == False]
            # No English Subtitles Check
            if len(newTracks) > 0:
                # Special Rule for Foriegn Films
                if audioLang[0] != "english":
                    newTracks[0]["default"] = True

                newTracks.extend(mainTracks)
                self._enabledSub.extend(newTracks)

    def _sortVideo(self, vidTracks:List[trackObj.TrackObJ], sortPref:List[str])->None:
        """
        Sorts and filters video tracks

        Args:
            vidTracks (array): list of video trackObjs
            sortPrefs (str): users prefence for which track should get higher priority
        """        
        newTracks = copy.deepcopy(vidTracks)
        if sortPref == "size":
            newTracks = sorted(newTracks,
                               key=self._VideoRankingSize, reverse=True)
        if len(newTracks)>0:
            newTracks[0]["default"] = True
            self._enabledVideo.append(newTracks[0])

    #########################################################################################
    # Helper Functions to Rank Tracks
    #
    ##########################################################################################

    def _AudioRankingSize(self, track:trackObj.TrackObJ)->int:
        """
        returns audio track size

        Args:
            track (obj): audio track
        Returns:
             int: int for track size
        """     
        title = track["bdinfo_title"]
        size = os.path.getsize(track.getTrackLocation())
        # lossless
        if re.search("LPCM|TrueHD|DTS-HD MA|DTS:.*?X|FLAC", title, re.IGNORECASE) != None:
            return 1+(size/100*100000000)
        # lossly
        else:
            return 10+(size/100*100000000)

    def _VideoRankingSize(self, track:trackObj.TrackObJ)->int:
        """
        returns video track size

        Args:
            track (obj): video track
        Returns:
             int: int for track size
        """          
        size = os.path.getsize(track.getTrackLocation())
        return size

    def _subAlphaOrder(self, track:trackObj.TrackObJ)->str:
        """
        returns sub track language 

        Args:
            track (obj): video track
        Returns:
             str: language for subtitle track
        """              
        return track["lang"]


##################################################################################
# Additional helper functions
#
##################################################################################

    def _getAudioPrefs(self, movieLang:List[str], audioPrefs:List[str])->List[str]:
        """
        Generates audio preferences based on user args and movie language

        Args:
            movieLang (array): Array of languages found for movie
            audioPrefs (array): User preferences for langauges

        Returns:
            array: Finalized array of languages
        """
        if len(audioPrefs) == 0:
            if "English" not in movieLang:
                movieLang.insert(0,"English")
            return list(map(lambda x: x.lower(), movieLang))
        return utils.removeDupesList(audioPrefs)
   
    ###
    # Insert Primary Language into correct place
    ###
    def _insertForcedSubHelper(self,oldTrack:trackObj.TrackObJ,forcedSubLangs:List[str],newFileName:Union[str, bytes, os.PathLike])->None:
        """
        Inserts extracted force subs into sorted and unsorted arrays

        Args:
            oldTrack (trackObj.TrackObJ): Original subtitle track force sub Originates
            forcedSubLangs (array():  List of audio languages for enabled trcks
            newFileName (str): FileName for forced subs
        """
        primary=[]
        newTrack = copy.deepcopy(oldTrack)
        newTrack["filename"] = newFileName
        value = newTrack["bdinfo_title"] + \
        newTrack["sourceKey"] + str(newTrack["index"])+"forced"
        key = xxhash.xxh32_hexdigest(value)
        post = newTrack["langcode"] or "vid"
        newTrack["key"] = f"{key}_forced_{post}"

        # Force Track For Primary Langauge Comes First
        if newTrack["lang"].lower() == forcedSubLangs[0]:
            newTrack["default"] = True
            newTrack["forced"] = True
            newTrack["site_title"] = "For Non English Parts"
            templist=[newTrack]
            templist.extend()
            primary.append(newTrack)

            # Just add to the end of the list
        else:
            newTrack["default"] = True
            newTrack["forced"] = True
            newTrack["site_title"] = "For Non English Parts"

            self._enabledSub.append(newTrack)
        self._unSortedSub.append(newTrack)
        primary.extend(self._enabledSub)
        self._enabledSub = primary




