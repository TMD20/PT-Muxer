import copy
import os
import re
import subprocess
import itertools


import xxhash


import src.tools.general as utils
import src.tools.commands as commands
import src.tools.install as install


class siteTrackSorter():
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
    def addTracks(self,tracks):
        self._tracks.extend(tracks)
    
    def sortTracks(self, movieLangs, audioPrefs, subPrefs, sortPref):
        self._groupTracks()
        self._sortTracksHelper(movieLangs, audioPrefs, subPrefs, sortPref)

    # Get Forced Subs Based on Audio Preference

    def addForcedSubs(self, movieLang, audioPref):
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
    def tracks(self):
        return self._tracks


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

    def _sortTracksHelper(self, movieLangs, audioPrefs, subPrefs, sortPref):

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

    def _removeDupes(self, tracks):
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

    def _sortAudio(self, audioTracks, audioLang, sortPref):
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

    def _sortCompatAudio(self, audioTracks):
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

    def _sortSub(self, subTracks, subPrefs, audioLang):
        # tempdict for tracks to add
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

    def _sortVideo(self, vidTracks, sortPref):
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

    def _AudioRankingSize(self, track):
        title = track["bdinfo_title"]
        size = os.path.getsize(track.getTrackLocation())
        # lossless
        if re.search("LPCM|TrueHD|DTS-HD MA|DTS:.*?X|FLAC", title, re.IGNORECASE) != None:
            return 1+(size/100*100000000)
        # lossly
        else:
            return 10+(size/100*100000000)

    def _VideoRankingSize(self, track):
        size = os.path.getsize(track.getTrackLocation())
        return size

    def _subAlphaOrder(self, track):
        return track["lang"]


##################################################################################
# Additional helper functions
#
##################################################################################

    def _getAudioPrefs(self, movieLang, audioPrefs):
        if len(audioPrefs) == 0:
            if "English" not in movieLang:
                movieLang.insert(0,"English")
            return list(map(lambda x: x.lower(), movieLang))
        return utils.removeDupesList(audioPrefs)
   
    ###
    # Insert Primary Language into correct place
    ###
    def _insertForcedSubHelper(self,oldTrack,forcedSubLangs,newFileName):
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




