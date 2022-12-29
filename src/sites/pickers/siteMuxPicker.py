import sites.base.siteMuxData as base
import sites.beyondHD.siteMuxData as beyondHD
import sites.blu.siteMuxData as blu
import sites.animebytes.siteMuxData as anime


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
        
    
