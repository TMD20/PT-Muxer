import src.sites.base.siteSourceData as base
import src.sites.beyondHD.siteSourceData as beyondHD
import src.sites.blu.siteSourceData as blu
import src.sites.animebytes.siteSourceData as anime


def pickSite(site):
    if site==None:
        return base.siteSourceData()
    elif site.lower() in ["beyondhd","bhd"]:
        return beyondHD.BeyondHD()
    elif site.lower() in ["blu","blutopia"]:
        return blu.Blu()
    elif site.lower() in ["ab","animebytes","animebyte"]:
        return anime.AnimeBytes()
    else:
        return base.siteSourceData()
