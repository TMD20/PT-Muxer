import sites.base.siteTrackData as base
import sites.beyondHD.siteTrackData as beyondHD
import sites.blu.siteTrackData as blu
import sites.animebytes.siteTrackData as anime


def pickSite(site):
    if site==None:
        return base.siteTrackData()
    elif site.lower() in ["beyondhd","bhd"]:
        return beyondHD.BeyondHD()
    elif site.lower() in ["blu","blutopia"]:
        return blu.Blu()
    elif site.lower() in ["ab","animebytes","animebyte"]:
        return anime.AnimeBytes()
    else:
        return base.siteTrackData()
