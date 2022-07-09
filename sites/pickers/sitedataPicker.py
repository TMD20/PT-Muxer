import sites.beyondHD.sitetrackData as beyondHD
import sites.blu.sitetrackData as blu

def pickSite(site):
    if site.lower()=="beyondhd" or site.lower()=="bhd":
        return beyondHD.BeyondHD()

    elif site.lower()=="blu":
        return blu.Blu()