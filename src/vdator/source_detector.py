import os, re

# 'mediainfo' to use mediainfo fields
# 'nobdinfo' to assume DVD if no bdinfo given
DVD_CHECK_MODE = os.environ.get("DVD_CHECK_MODE").strip()

# detect if DVD, 1080p BluRay or UHD BluRay
class SourceDetector(object):
    """
    Define ways to detect source
    """

    def setup(self, bdinfo, mediainfo):
        """
        Parameters
        ----------
        bdinfo : dict
            bdinfo

        mediainfo : dict
            mediainfo
        """
        self.bdinfo = bdinfo
        self.mediainfo = mediainfo

    def is_dvd(self):
        """
        Is this source a DVD?

        Returns
        -------
        boolean True if DVD, False otherwise
        """
        is_dvd = False

        if DVD_CHECK_MODE == "nobdinfo":
            if not self._has_bdinfo():
                # no bdinfo given, assume dvds
                is_dvd = True
        elif DVD_CHECK_MODE == "mediainfo":
            if (
                "video" in self.mediainfo
                and len(self.mediainfo["video"]) >= 1
                and "height" in self.mediainfo["video"][0]
            ):
                height = int(
                    "".join(re.findall(r"[\d]+", self.mediainfo["video"][0]["height"]))
                )
                if height <= 576:
                    # height is 480p or 576p for dvds
                    # Note: checking standard is NTSC or PAL won't work, as some BDs are NTSC
                    is_dvd = True

        return is_dvd

    def is_ntsc_dvd(self):
        """
        Is this source an NTSC DVD?

        Returns
        -------
        boolean True if NTSC DVD, False otherwise
        """
        is_ntsc = False

        if self.is_dvd():
            if (
                "video" in self.mediainfo
                and len(self.mediainfo["video"]) >= 1
                and "standard" in self.mediainfo["video"][0]
            ):
                if self.mediainfo["video"][0]["standard"].upper() == "NTSC":
                    is_ntsc = True

        return is_ntsc

    def is_pal_dvd(self):
        """
        Is this source a PAL DVD?

        Returns
        -------
        boolean True if PAL DVD, False otherwise
        """
        is_pal = False

        if self.is_dvd():
            if (
                "video" in self.mediainfo
                and len(self.mediainfo["video"]) >= 1
                and "standard" in self.mediainfo["video"][0]
            ):
                if self.mediainfo["video"][0]["standard"].upper() == "PAL":
                    is_pal = True

        return is_pal

    def is_uhd(self):
        """
        Is this source a UHD BluRay?

        Returns
        -------
        boolean True if UHD, False otherwise
        """
        is_uhd = False

        if (
            "video" in self.mediainfo
            and len(self.mediainfo["video"]) >= 1
            and "height" in self.mediainfo["video"][0]
        ):
            height = int(
                "".join(re.findall(r"[\d]+", self.mediainfo["video"][0]["height"]))
            )
            if height == 2160:
                is_uhd = True

        return is_uhd

    def is_dv(self):
        """
        Does this source have dolby vision?

        Returns
        -------
        boolean True if DV, False otherwise
        """
        is_dv = False

        if (
            "video" in self.mediainfo
            and len(self.mediainfo["video"]) >= 1
            and "hdr_format" in self.mediainfo["video"][0]
        ):
            if "Dolby Vision" in self.mediainfo["video"][0]["hdr_format"]:
                is_dv = True

        return is_dv

    def _has_bdinfo(self):
        """
        Does the paste include bdinfo?

        Returns
        -------
        boolean True if has bdinfo, False otherwise
        """
        has_bdinfo = False

        if (
            len(self.bdinfo["video"]) == 0
            and len(self.bdinfo["audio"]) == 0
            and len(self.bdinfo["subtitle"]) == 0
        ):
            has_bdinfo = False
        else:
            has_bdinfo = True

        return has_bdinfo
