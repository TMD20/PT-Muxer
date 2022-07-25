import os

from sites.base.siteTrackSorter import siteTrackSorter
import tools.general as utils


class AnimeBytes(siteTrackSorter):
    def __init__(self):
        super().__init__()

    #Set English Track as forced if no embedded english Track is foudn
    def _sortSub(self, subTracks, subPrefs, audioLang):
        super()._sortSub(subTracks, subPrefs, audioLang)
        # Check if a force english track has been found
        for track in self.enabledSub:
            if track["force"]==True and track["lang"].lower()=="english":
                return
        for key in list(self._tracksDataObj.rawMediaTracksData.keys()):
            keyTracks = list(
                filter(lambda x: x["sourceKey"] == key, self.unSortedSub))
            keyTracks = list(
                filter(lambda x: x["lang"].lower() == "english", keyTracks))
            track = keyTracks[0]
            if len(keyTracks) == 1:
                return
            elif os.path.getsize(keyTracks[1]["file"]) < os.path.getsize(keyTracks[0]["file"]):
                track = keyTracks[0]
            track["default"] = True
            track["forced"] = True

    # Assume Movie has Japenese and English
    # Prioritze Japanese as first language

    def _getAudioPrefs(self, movieLang, audioPrefs):
        if len(audioPrefs) == 0:
            otherLangs = list(filter(lambda x: x.lower() !=
                                     "english" and x.lower() != "japanese", movieLang))
            # Prioritize japanese and english
            langs = ["japanese", "english"].extend(otherLangs)
            return list(map(lambda x: x.lower(), langs))

        return utils.removeDupesList(audioPrefs)
