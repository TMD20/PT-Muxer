import os
class TrackObJ(dict):
    def __init__(self):
        super().__init__()
        self._allowedKeys={"filename","site_title","bdinfo_title",
        "type","index","compat","forced","default","lang","auditorydesc"
        ,"original","commentary","textdesc","langcode","machine_parse","length",
        "key","parent","child","sdh","sourceDir","sourceKey","outputDir","notes"
        ,"machine_parse_endlines","parentKey","childKey"}
    #prevent 
    def __setitem__(self, key, value):
        if key not in self._allowedKeys:
            raise AttributeError(f"TrackObj does not accept {key}")
        super().__setitem__(key, value)
        
    def getTrackLocation(self):
        if (self.get("outputDir")==None or self.get("filename")==None):
            return ""
        return os.path.join(self.get("outputDir"),self.get("filename"))
