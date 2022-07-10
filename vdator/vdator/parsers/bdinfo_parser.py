import re


class BDInfoParser(object):
    """
    Parse BDInfo
    """

    def __init__(self):
        self.embedded_track_types = ["ac3 core", "ac3 embedded"]
        # ['-ac3 core', '-ac3 embedded']
        self.embedded_track_types_excluded = [
            "-" + t for t in self.embedded_track_types
        ]
        # ['\\(ac3 core:', '\\(ac3 embedded:']
        self.embedded_track_types_regex = [
            r"\(" + a + ":" for a in self.embedded_track_types
        ]
        # ['\\(-ac3 core:', '\\(-ac3 embedded:']
        self.embedded_track_types_excluded_regex = [
            r"\(-" + a + ":.*\)" for a in self.embedded_track_types
        ]

    def format_track_name(self, name):
        """
        Format track name

        Parameters
        ----------
        name : str
            track name

        Returns
        -------
        str formatted track name
        """
        # remove multiple and trailing spaces
        name = " ".join(name.split()).strip()
        return name

    def format_video_track_name(self, name):
        """
        Format video track name

        Parameters
        ----------
        name : str
            track name

        Returns
        -------
        str formatted video track name
        """
        name = self.format_track_name(name)

        # remove 3d
        name = name.replace(" / Left Eye", "")
        name = name.replace(" / Right Eye", "")

        # force decimal instead of comma in fps
        name2 = name.split("/")
        if len(name2) >= 4:
            name2[3] = name2[3].replace(",", ".")
        name = "/".join(name2)

        return name

    def format_audio_track_name(self, name):
        """
        Format track name

        Parameters
        ----------
        name : str
            track name

        Returns
        -------
        str formatted audio track name
        """
        # remove (DTS Core:...)
        name = re.sub(r"\(DTS Core:.*\)", "", name).strip()

        # remove excluded (-AC3 Core...) and (-AC3 Embedded...)
        for ending in self.embedded_track_types_excluded_regex:
            name = re.sub(ending, "", name, flags=re.IGNORECASE).strip()

        # remove dialog normalization
        # needs to be after removing (DTS Core:...)
        # since the dts core track can have dialog normalization which will break its regex
        if "DN" in name.upper() and " / " in name:
            name = name.rpartition(" / ")[0]

        name = self.format_track_name(name)

        return name

    def has_compat_track(self, audio_track_name):
        audio_track_name = audio_track_name.lower()
        for track_type in self.embedded_track_types:
            if track_type in audio_track_name:
                return True
        return False

    def format_audio_compatibility_track(self, audio_track):
        """
        Format audio compatibility track

        Parameters
        ----------
        audio_track : dict
            audio track
            dict{'name':'...', 'language':'...'}

        Returns
        -------
        audio track, compatibility track
        [dict{'name':'...', 'language':'...'}, dict{'name':'...', 'language':'...'}]
        """
        audio_track_name_lower = audio_track["name"].lower()
        for i, track_type in enumerate(self.embedded_track_types):
            if track_type in audio_track_name_lower:
                embedded_track_type_index = i
                break

        audio_parts = re.split(
            self.embedded_track_types_regex[embedded_track_type_index],
            audio_track["name"],
            flags=re.IGNORECASE,
        )
        audio_track["name"] = self.format_track_name(audio_parts[0])

        compat_track = {
            "name": self.format_track_name(
                "Compatibility Track / Dolby Digital Audio / "
                + audio_parts[1].strip().rstrip(")")
            ),
            "language": audio_track["language"],
        }
        return audio_track, compat_track

    def format_audio_track(self, name):
        """
        Split audio track with name and language

        Parameters
        ----------
        name : str
            track name

        Returns
        -------
        dict{'name':'...', 'language':'...'}
        """
        track = {"name": None, "language": None}
        name = name.strip()
        if " / " in name:
            name_parts = name.split(" / ", 1)
            track["name"] = self.format_audio_track_name(name_parts[1])
            track["language"] = name_parts[0]
        return track

    def format_subtitle_track(self, name):
        """
        Format subtitle track with language and bitrate

        Parameters
        ----------
        name : str
            track name

        Returns
        -------
        dict{'language':'...', 'bitrate':'...'}
        """
        track = {"language": None, "bitrate": None}
        name = name.strip()
        if " / " in name:
            name_parts = name.split(" / ", 1)
            track["language"] = name_parts[0].strip()
            track["bitrate"] = name_parts[1].strip()
        return track

    def playlist_report_format_video_track_name(self, name):
        """
        Format playlist report video track name

        Parameters
        ----------
        name : str
            track name

        Returns
        -------
        str formatted track name
        """
        try:
            parts = name.split()
            kbps_i = parts.index("kbps")
            before = " ".join(parts[: kbps_i - 1]).strip()
            after = " ".join(parts[kbps_i + 1 :]).strip()
            track_name = (
                before + " / " + parts[kbps_i - 1] + " " + parts[kbps_i] + " / " + after
            )
            track_name = self.format_video_track_name(track_name)
            return track_name
        except ValueError:
            return False

    def playlist_report_format_audio_track(self, name):
        """
        Format playlist report audio track

        Parameters
        ----------
        name : str
            track name

        Returns
        -------
        dict{'name':'...', 'language':'...'}
        """
        track = {"name": None, "language": None}
        try:
            name = name.strip()
            name_parts = name.split(" / ")
            name_parts0 = name_parts[0].strip().split()
            name = (
                " ".join(name_parts0[:-4])
                + " / "
                + name_parts0[-1]
                + " / "
                + " / ".join(name_parts[1:]).strip()
            )
            track["name"] = self.format_audio_track_name(name)
            track["language"] = name_parts0[3]
            return track
        except ValueError:
            return False

    def parse_quick_summary_line(self, bdinfo, l):
        """
        Parse quick summary line

        Parameters
        ----------
        bdinfo : dict
            bdinfo dict
        l : str
            quick summary line

        Returns
        -------
        bdinfo dict
        """
        l2 = l.strip().lower()
        # parse hidden tracks
        l2 = l2.lstrip("* ")
        if (
            l2.startswith("video:")
            or l2.startswith("audio:")
            or l2.startswith("subtitle:")
        ):
            track_name = l.split(":", 1)[1].strip()
        if l2.startswith("video:"):
            track_name = self.format_video_track_name(track_name)
            bdinfo["video"].append(track_name)
        elif l2.startswith("audio:"):
            audio_track = self.format_audio_track(track_name)
            if self.has_compat_track(audio_track["name"]):
                (
                    audio_track,
                    compat_track,
                ) = self.format_audio_compatibility_track(audio_track)
                bdinfo["audio"].append(audio_track)
                bdinfo["audio"].append(compat_track)
            else:
                bdinfo["audio"].append(audio_track)
        elif l2.startswith("subtitle:"):
            bdinfo["subtitle"].append(self.format_subtitle_track(track_name))
        else:
            # get all other bdinfo entries
            l = l.split(":", 1)
            if len(l) >= 2:
                bdinfo[l[0].strip().lower()] = l[1].strip()
        return bdinfo
