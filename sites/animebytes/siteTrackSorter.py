import os

from sites.base.siteTrackSorter import siteTrackSorter
import tools.general as utils


class AnimeBytes(siteTrackSorter):
    def __init__(self):
        super().__init__()
    def _sortSub(self, subTracks, subPrefs, audioLang):
        super()._sortSub(subTracks, subPrefs, audioLang)
        #remove any forced/default tracks
        for track in self.enabledSub:
            track["default"]=False
            track["forced"]=False
        for key in list(self._tracksDataObj.rawMediaTracksData.keys()):
            keyTracks = list(
                filter(lambda x: x["sourceKey"] == key, self.unSortedSub))
            keyTracks = list(
                filter(lambda x: x["lang"].lower() == "english", keyTracks))
            track = keyTracks[0]
            if len(keyTracks) == 1:
                return
            elif os.path.getsize(keyTracks[1]["file"]) <os.path.getsize(keyTracks[0]["file"]):
                track = keyTracks[0]
            track["default"] = True
            track["forced"] = True
     
        

    #Assume Movie has Japenese and English
    #Prioritze Japanese as first language
    def _getAudioPrefs(self, movieLang, audioPrefs):
        if len(audioPrefs) == 0:
            otherLangs = list(filter(lambda x: x.lower() !=
                                "english" and x.lower() != "japanese",movieLang))
            #Prioritize japanese and english
            langs=["japanese","english"].extend(otherLangs)
            return list(map(lambda x: x.lower(), langs))

        return utils.removeDupesList(audioPrefs)
     
    
            
       

    


   
    