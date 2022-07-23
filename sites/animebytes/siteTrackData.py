import re
import os

from sites.base.siteTrackData import siteTrackData


class AnimeBytes(siteTrackData):
    def __init__(self):
        super().__init__()

    def _convertFlac(self, current_tracks, output):
        for i in range(len(current_tracks)):
            track = current_tracks[i]
            if track["type"] != "audio":
                continue
            title = track["bdinfo_title"]
            eac3to = track["eac3to"]
            file = track["file"]
            if re.search("LPCM|TrueHD|DTS-HD MA|DTS:.*?X", title, re.IGNORECASE):
                eac3to = re.sub("\..*", ".flac", eac3to)
                file = os.path.join(
                    output, eac3to.split(":")[1])
                match = re.search(".*([0-9]\.[0-9].*)", title).group(1)
                title = f"FLAC Audio / {match}"
                title=re.sub(" +"," ",title)
            track["site_title"] = title
            track["file"] = file
            track["eac3to"] = eac3to
