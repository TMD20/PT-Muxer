import sites.base.siteMuxData as base
import sites.beyondHD.siteMuxData as beyondHD
import sites.blu.siteMuxData as blu
import sites.animebytes.siteMuxData as anime


def pickSite(site):
    if site==None:
        return base.MuxOBj()
    elif site.lower() == "beyondhd" or site.lower() == "bhd":
        return beyondHD.BeyondHD()

    elif site.lower() == "blu":
        return blu.Blu()
    elif site.lower() == "ab" or site.lower() == "animebytes":
        return anime.AnimeBytes()
        
    
