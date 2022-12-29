import src.sites.base.siteTrackSorter as base
import src.sites.beyondHD.siteTrackSorter as beyondHD
import src.sites.blu.siteTrackSorter as blu
import src.sites.animebytes.siteTrackSorter as anime


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
