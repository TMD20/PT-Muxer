import sites.base.siteTrackData as base
import sites.beyondHD.siteTrackData as beyondHD
import sites.blu.siteTrackData as blu
import sites.animebytes.siteTrackData as anime


def pickSite(site):
    if site==None:
        return base.siteTrackData()
    elif site.lower() == "beyondhd" or site.lower() == "bhd":
        return beyondHD.BeyondHD()
    elif site.lower() == "blu":
        return blu.Blu()
    elif site.lower() == "ab" or site.lower() == "animebytes":
        return anime.AnimeBytes()
