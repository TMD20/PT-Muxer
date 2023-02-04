from src.sites.base.siteTrackSorter import siteTrackSorter


class PTP(siteTrackSorter):
   
    """
    This class is for sorting tracks based on beyondhd sorting rules

    Args:
        siteTrackSorter (class): The base track sorter class
    """ 
    def __init__(self)->None:
        super().__init__()
   
    