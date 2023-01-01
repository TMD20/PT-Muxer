import os
from typing import Any,List,Union

class TrackObJ(dict):
    def __init__(self)->None:
        super().__init__()
        self._allowedKeys={"filename","site_title","bdinfo_title",
        "type","index","compat","forced","default","lang","auditorydesc"
        ,"original","commentary","textdesc","langcode","machine_parse","length",
        "key","parent","child","sdh","sourceDir","sourceKey","outputDir","notes"
        ,"machine_parse_endlines","parentKey","childKey"}
    #prevent 
    def __setitem__(self, key:str, value:Any)->str:
        """
        built in dict method 
        modified to only accept certain keys

        Args:
        key (str): key to set
        value (any): value to set key to
        """
        if key not in self._allowedKeys:
            raise AttributeError(f"TrackObj does not accept {key}")
        super().__setitem__(key, value)
        
    def getTrackLocation(self)->str:
        """
        Helper function to get the output for track given requried values set
        If values not set returns empty str

        Returns:
            str: output files path
        """
        if (self.get("outputDir")==None or self.get("filename")==None):
            return ""
        return os.path.join(self.get("outputDir"),self.get("filename"))
