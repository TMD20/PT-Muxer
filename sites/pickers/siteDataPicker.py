import sites.beyondHD.siteTrackData as beyondHD
import sites.blu.siteTrackData as blu
import sites.base.siteTrackData as base

def pickSite(site):
    if site==None:
        return base.siteTrackData()
    elif site.lower() == "beyondhd" or site.lower() == "bhd":
        return beyondHD.BeyondHD()

    elif site.lower() == "blu":
        return blu.Blu()
