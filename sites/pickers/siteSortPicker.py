import sites.base.siteTrackSorter as base
import sites.beyondHD.siteTrackSorter as beyondHD
import sites.blu.siteTrackSorter as blu
import sites.animebytes.siteTrackSorter as anime


def pickSite(site):
    if site == None:
        return base.siteTrackSorter()
    elif site.lower() in ["beyondhd","bhd"]:
        return beyondHD.BeyondHD()
    elif site.lower() in ["blu","blutopia"]:
        return blu.Blu()
    
    elif site.lower() in ["ab","animebytes","animebyte"]:
        return anime.AnimeBytes()
    else:
        return base.siteTrackSorter()
