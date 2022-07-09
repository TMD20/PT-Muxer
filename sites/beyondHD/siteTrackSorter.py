from sites.base.siteTrackSorter import siteSorter


class BeyondHD(siteSorter):
    def __init__(self):
        super().__init__()
    # Overwrite Base Audio Sort

    def sortAudio(self, pref):
        mainLang = self._unSortedAudio[0]["lang"]
        mainTracks = [ele for ele in self._unSortedAudio if ele["lang"]
                      == self._unSortedAudio[0]["lang"] and ele["compat"] == False]
        engTracks = [ele for ele in self._unSortedAudio if ele["lang"]
                      == "English"]
        #Only Include English Track
        if mainLang == "English":
                      sorted(mainTracks, key=self._AudioRankingSize, reverse=True)
        #MainTracks Firt
        # Dubs Commentary in English Second
        else:
            sorted(mainTracks, key=self._AudioRankingSize, reverse=True)
            sorted(engTracks,key=self._AudioRankingSize, reverse=True)
            [mainTracks[0]].extend(engTracks)
        self._enabledAudio.extend(mainTracks)
        
