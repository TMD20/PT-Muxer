import sites.beyondHD.siteTrackSorter as beyondHD
import sites.blu.siteTrackSorter as blu


def pickSite(site):
    if site.lower() == "beyondhd" or site.lower() == "bhd":
        return beyondHD.BeyondHD()
    elif site.lower() == "blu":
        return blu.Blu()
