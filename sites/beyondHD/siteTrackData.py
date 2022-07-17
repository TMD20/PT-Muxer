import re
import os

from sites.base.siteTrackData import siteTrackData


class BeyondHD(siteTrackData):
    def __init__(self):
        super().__init__()

    def addTracks(self, quicksum, playlistNum, source, output):
        current_tracks = super().addTracks(quicksum, playlistNum, source, output)
        self._convertFlac(current_tracks, output)

    def _convertFlac(self, current_tracks, output):
        for i in range(len(current_tracks)):
            track = current_tracks[i]
            title = track["bdinfo_title"]
            channels = re.search("\d.\d", title)
            if channels == None:
                continue
            channels = float(channels.group(0))

            trackType = track["type"]
            eac3to = track["eac3to"]
            file = track["file"]
            if re.search("LPCM|TrueHD|DTS-HD MA|DTS:.*?X", title, re.IGNORECASE) and trackType == "audio" \
                    and channels < 3.0:
                eac3to = re.sub("\..*", ".flac", eac3to)
                file = os.path.join(
                    output, eac3to.split(":")[1])
                match = re.search(".*([0-9]\.[0-9].*)", title).group(1)
                title = f"FLAC Audio / {match}"
            track["site_title"] = title
            track["file"] = file
            track["eac3to"] = eac3to
