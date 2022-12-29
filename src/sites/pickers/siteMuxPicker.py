import src.sites.base.siteMuxData as base
import src.sites.beyondHD.siteMuxData as beyondHD
import src.sites.blu.siteMuxData as blu
import src.sites.animebytes.siteMuxData as anime


def pickSite(site):
    if site==None:
        return base.MuxOBj()
    elif site.lower() ==  ["beyondhd","bhd"]:
        return beyondHD.BeyondHD()

    elif site.lower() in ["blu","blutopia"]:
        return blu.Blu()
    elif site.lower() in ["ab","animebytes","animebyte"]:
        return anime.AnimeBytes()
    else:
        return base.MuxOBj()
        
    
