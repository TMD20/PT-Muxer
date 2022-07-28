import os

from sites.base.siteTrackSorter import siteTrackSorter
import tools.general as utils


class AnimeBytes(siteTrackSorter):
    def __init__(self):
        super().__init__()
    def addForcedSubs(self, movieLang, audioPref):
        super().addForcedSubs(movieLang, audioPref)
        # Check if a force english track has been found
        for track in self._enabledSub:
            if track["forced"] == True and track["lang"].lower() == "english":
                return
        for key in list(self._tracksDataObj.rawMediaTracksData.keys()):
            keyTracks = list(
                filter(lambda x: x["sourceKey"] == key, self._unSortedSub))
            keyTracks = list(
                filter(lambda x: x["lang"].lower() == "english", keyTracks))
            forcedTrack = keyTracks[0]
            if len(keyTracks) == 1:
                return
            elif os.path.getsize(keyTracks[1]["file"]) < os.path.getsize(keyTracks[0]["file"]):
                forcedTrack = keyTracks[1]
            forcedTrack["default"] = True
            forcedTrack["forced"] = True



    def _getAudioPrefs(self, movieLang, audioPrefs):
        if len(audioPrefs) == 0:
            otherLangs = list(filter(lambda x: x.lower() !=
                                     "english" and x.lower() != "japanese", movieLang))
            # Prioritize japanese and english
            langs = ["English","Japanese"]
            langs.extend(otherLangs)
            return list(map(lambda x: x.lower(), langs))

        return utils.removeDupesList(audioPrefs)
    
    def _sortAudio(self, audioTracks, audioLang, sortPref):
        super()._sortAudio(audioTracks, audioLang, sortPref)
        #Change Original Audio to Japanese
        #set original language flag
        newTracks = [ele for ele in audioTracks if ele["lang"].lower()
                     == "japanese" and ele["compat"] == False]
        for track in newTracks: track["original"]=True
        newTracks = [ele for ele in audioTracks if ele["lang"].lower()
                     == "english" and ele["compat"] == False]
        for track in newTracks: track["original"]=False