from typing import Union

import src.sites.base.siteSourceData as base
import src.sites.beyondHD.siteSourceData as beyondHD
import src.sites.blu.siteSourceData as blu
import src.sites.animebytes.siteSourceData as anime
import src.sites.ptp.siteSourceData as ptp


def pickSite(site:Union[str,None]=None)->base.siteSourceData:
    """
    This is a helper function to output a object pass on the site passed as an argumented
    Args:
        site (str, optional): Which site to generate an object from. Defaults to None.

    Returns:
        obj: object pass on site being pass
    """    
    if site==None:
        return base.siteSourceData()
    elif site.lower() in ["beyondhd","bhd"]:
        return beyondHD.BeyondHD()
    elif site.lower() in ["blu","blutopia"]:
        return blu.Blu()
    elif site.lower() in ["ptp","passthepopcorn"]:
        return ptp.PTP()
    elif site.lower() in ["ab","animebytes","animebyte"]:
        return anime.AnimeBytes()
    else:
        return base.siteSourceData()
