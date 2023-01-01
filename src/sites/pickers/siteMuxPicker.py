from typing import Union

import src.sites.base.siteMuxData as base
import src.sites.beyondHD.siteMuxData as beyondHD
import src.sites.blu.siteMuxData as blu
import src.sites.animebytes.siteMuxData as anime


def pickSite(site:Union[str,None]=None)->base.MuxOBj:
    """
    This is a helper function to output a object pass on the site passed as an argumented



    Args:
        site (str, optional): Which site to generate an object from. Defaults to None.

    Returns:
        obj: object pass on site being pass
    """

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
        
    
