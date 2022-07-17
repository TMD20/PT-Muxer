import sites.beyondHD.siteTrackSorter as beyondHD
import sites.blu.siteTrackSorter as blu
import sites.base.siteTrackSorter as base

def pickSite(site):
    if site == None:
        return base.siteTrackSorter()
    elif site.lower() == "beyondhd" or site.lower() == "bhd":
        return beyondHD.BeyondHD()
    elif site.lower() == "blu":
        return blu.Blu()
    
