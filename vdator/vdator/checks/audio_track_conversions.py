from .check import *
from .mixins import SectionId, IsCommentaryTrack

import re


class CheckAudioTrackConversions(Check, SectionId, IsCommentaryTrack):
    def __init__(
        self,
        reporter,
        source_detector,
        remove_until_first_codec,
        mediainfo,
        bdinfo,
        eac3to,
    ):
        super().__init__(reporter, mediainfo, "Error checking audio track conversions")
        self.source_detector = source_detector
        self.remove_until_first_codec = remove_until_first_codec
        self.bdinfo = bdinfo
        self.eac3to = eac3to

    # overriding abstract method
    def get_reply(self):
        reply = ""
  

        if self.source_detector.is_dvd():
            # no audio track conversions for dvds
            reply += self.reporter.print_report(
                "info", "No audio track conversions to check for DVDs"
            )
            return reply
        else:
            len_bdinfo = len(self.bdinfo["audio"])
            len_mediainfo = len(self.mediainfo["audio"])
            min_len = min(len_bdinfo, len_mediainfo)
            max_len = max(len_bdinfo, len_mediainfo)
            diff_len = abs(max_len - min_len)
          

            for i in range(0, min_len):
                # audio = dict{'name':'...', 'language':'...'}
                bdinfo_audio_title = re.sub(
                    r"\s+", " ", self.bdinfo["audio"][i]["name"]
                )
               
                bdinfo_audio_parts = bdinfo_audio_title.split(" / ")
                bdinfo_audio_parts_converted = bdinfo_audio_parts.copy()
     
              

                # check audio commentary
                (is_commentary, commentary_reply) = self._check_commentary(i)

                if is_commentary:
                    reply += commentary_reply
                elif len(bdinfo_audio_parts) >= 1:
                    optionally_flac = False
                    # check audio conversions
                    if bdinfo_audio_parts[0] == "DTS-HD Master Audio":
                        # DTS-HD MA
                        channels = float(bdinfo_audio_parts[1])
                       
    
                        if is_float(bdinfo_audio_parts[1]):
                            if channels < 3:
                                # can be DTS-HD MA 1.0, DTS-HD MA 2.0, FLAC 1.0, and FLAC 2.0
                                optionally_flac = True

                            reply += self._check_audio_conversion(
                                i, "DTS-HD Master Audio", "FLAC Audio", optionally_flac
                            )

                    elif bdinfo_audio_parts[0] == "LPCM Audio":
                        if (
                            is_float(bdinfo_audio_parts[1])
                            and float(bdinfo_audio_parts[1]) < 3
                        ):
                            # LPCM 1.0 or 2.0 to FLAC
                            reply += self._check_audio_conversion(
                                i, "LPCM Audio", "FLAC Audio", False
                            )
                            bdinfo_audio_parts_converted[0] = "FLAC Audio"
                        else:
                            # LPCM > 2.0 to DTS-HD MA
                            reply += self._check_audio_conversion(
                                i, "LPCM Audio", "DTS-HD Master Audio", False
                            )
                            bdinfo_audio_parts_converted[0] = "DTS-HD Master Audio"

                    # check track names match
                    if "title" in self.mediainfo["audio"][i]:

                        mediainfo_audio_title = self.mediainfo["audio"][i][
                            "title"
                        ].strip()
                        print(mediainfo_audio_title)


                        (
                            mediainfo_audio_title,
                            _,
                            _,
                        ) = self.remove_until_first_codec.remove(mediainfo_audio_title)
                        print(mediainfo_audio_title)
                        bdinfo_audio_title = " / ".join(bdinfo_audio_parts_converted)
                        bdinfo_audio_titles = [bdinfo_audio_title]
                        if optionally_flac:
                            # May be converted to FLAC
                            # Add DTS-HD MA 1.0/2.0/2.1 and FLAC 1.0/2.0/2.1 as options
                            old_bdinfo_audio_parts_converted = (
                                bdinfo_audio_parts_converted.copy()
                            )

                            bdinfo_audio_parts_converted[0] = "FLAC Audio"
                            # FLAC 2.0/2.1
                            bdinfo_audio_titles.append(
                                " / ".join(bdinfo_audio_parts_converted)
                            )
                            bdinfo_audio_parts_converted[1] = "1.0"
                            # FLAC 1.0
                            bdinfo_audio_titles.append(
                                " / ".join(bdinfo_audio_parts_converted)
                            )

                            # DTS-HD MA 2.0/2.1
                            bdinfo_audio_titles.append(
                                " / ".join(old_bdinfo_audio_parts_converted)
                            )
                            old_bdinfo_audio_parts_converted[1] = "1.0"
                            # DTS-HD MA 1.0
                            bdinfo_audio_titles.append(
                                " / ".join(old_bdinfo_audio_parts_converted)
                            )

                        if self.mediainfo["audio"][i]["title"] in bdinfo_audio_titles:
                            reply += self.reporter.print_report(
                                "correct",
                                "Audio "
                                + self._section_id("audio", i)
                                + ": Track names match",
                            )
                        else:
                            is_bad_audio_format = False
                            print(re.search(r"(\d+)\skbps", mediainfo_audio_title),"dd")
                            print(self.bdinfo["audio"][i],"dddd")
                            print(self.mediainfo["audio"][i],"sd")
                            print(mediainfo_audio_title,"dss")
                            print("\n\n")
                          

                            # use bitrate from mediainfo audio title
                            m_bit_rate = re.search(r"(\d+)\skbps", mediainfo_audio_title).group(1)
                          
                            for j, title in enumerate(bdinfo_audio_titles):
                                bdinfo_audio_titles[j] = re.sub(
                                    r"(.*\s)\d+(\skbps.*)",
                                    r"\g<1>{}\g<2>".format(m_bit_rate),
                                    title,
                                )

                            # if it has TrueHD objects, add them to the audio channel
                            if (
                                "number_of_dynamic_objects"
                                in self.mediainfo["audio"][i]
                            ):
                                bdinfo_audio_title = re.sub(
                                    r"(.*\d\.\d)(.*)",
                                    r"\g<1>+{} objects\g<2>".format(
                                        self.mediainfo["audio"][i][
                                            "number_of_dynamic_objects"
                                        ]
                                    ),
                                    bdinfo_audio_title,
                                )
                                bdinfo_audio_titles.append(bdinfo_audio_title)

                            # bdinfo_audio_titles has list of possible titles
                            if mediainfo_audio_title not in bdinfo_audio_titles:
                                is_bad_audio_format = True

                            if is_bad_audio_format:
                                reply += self.reporter.print_report(
                                    "error",
                                    "Audio "
                                    + self._section_id("audio", i)
                                    + ": Bad conversion:\n```fix\nBDInfo: "
                                    + bdinfo_audio_title
                                    + "\nMediaInfo: "
                                    + self.mediainfo["audio"][i]["title"]
                                    + "```",
                                    new_line=False,
                                )
                                reply += show_diff(
                                    self.mediainfo["audio"][i]["title"],
                                    bdinfo_audio_title,
                                )
                            else:
                                reply += self.reporter.print_report(
                                    "correct",
                                    "Audio "
                                    + self._section_id("audio", i)
                                    + ": Track names match",
                                )
                    else:
                        reply += self.reporter.print_report(
                            "error",
                            "Audio "
                            + self._section_id("audio", i)
                            + ": Missing track name",
                        )

            if diff_len > 0:
                reply += self.reporter.print_report(
                    "warning",
                    "Checked first `{}/{}` audio tracks".format(min_len, max_len),
                )
                if len_bdinfo > len_mediainfo:
                    reply += "Did you forget to add a minus (-) sign in front of unused audio tracks in bdinfo?\n"

        return reply

    def _check_commentary(self, i):
        reply, is_commentary = "", False

        if self._is_commentary_track(self.mediainfo["audio"][i]["title"]):
            is_commentary = True
            # audio = dict{'name':'...', 'language':'...'}
            if self.bdinfo["audio"][i]["name"].count("/") >= 1:
                bdinfo_audio_format = (
                    self.bdinfo["audio"][i]["name"].split("/")[0].strip()
                )

                if bdinfo_audio_format == "Dolby Digital Audio":
                    if "format" in self.mediainfo["audio"][i]:
                        if self.mediainfo["audio"][i]["format"] == "AC-3":
                            reply += self.reporter.print_report(
                                "correct",
                                "Audio "
                                + self._section_id("audio", i)
                                + ": Commentary already AC-3",
                            )
                        else:
                            reply += self.reporter.print_report(
                                "error",
                                "Audio "
                                + self._section_id("audio", i)
                                + ": Commentary should be AC-3 instead of "
                                + self.mediainfo["audio"][i]["format"],
                            )
                    else:
                        reply += self.reporter.print_report(
                            "error",
                            "Audio "
                            + self._section_id("audio", i)
                            + ": Commentary does not have a format",
                        )

                    return is_commentary, reply
            else:
                reply += self.reporter.print_report(
                    "warning",
                    "Audio #"
                    + self._section_id("audio", i)
                    + ": Cannot verify commentary audio conversion",
                )
                return is_commentary, reply

            if (
                "format" in self.mediainfo["audio"][i]
                and self.mediainfo["audio"][i]["format"] == "AC-3"
            ):
                if "bit_rate" in self.mediainfo["audio"][i]:
                    bit_rate = "".join(
                        re.findall(r"[\d]+", self.mediainfo["audio"][i]["bit_rate"])
                    )
                    if bit_rate == "224":
                        reply += self.reporter.print_report(
                            "correct",
                            "Audio "
                            + self._section_id("audio", i)
                            + ": Commentary converted to `AC-3 @ 224 kbps`",
                        )
                    else:
                        reply += self.reporter.print_report(
                            "error",
                            "Audio "
                            + self._section_id("audio", i)
                            + ": Commentary AC-3 bitrate should be `224 kbps` instead of `"
                            + self.mediainfo["audio"][i]["bit_rate"]
                            + "`",
                        )
                else:
                    reply += self.reporter.print_report(
                        "error",
                        "Audio "
                        + self._section_id("audio", i)
                        + ": Commentary AC-3 does not have a bitrate",
                    )
            else:
                reply += self.reporter.print_report(
                    "info",
                    "Audio "
                    + self._section_id("audio", i)
                    + ": Commentary may be converted to AC-3",
                )

        return is_commentary, reply

    def _check_audio_conversion(self, i, audio_from, audio_to, optional):
        reply = ""

        # verify audio track titles
        if (
            " / " not in self.bdinfo["audio"][i]["name"]
            or "title" not in self.mediainfo["audio"][i]
            or " / " not in self.mediainfo["audio"][i]["title"]
        ):
            reply += self.reporter.print_report(
                "warning", "Could not verify audio " + self._section_id("audio", i)
            )
            return reply

        # [codec, channel, sampling rate, bit rate, bit depth]
        bdinfo_audio_parts = self.bdinfo["audio"][i]["name"].split(" / ")
        if len(bdinfo_audio_parts) <= 4:
            reply += self.reporter.print_report(
                "warning", "Could not verify audio " + self._section_id("audio", i)
            )
            return reply

        mediainfo_audio_title = self.mediainfo["audio"][i]["title"]
      
        (mediainfo_audio_title, _, _) = self.remove_until_first_codec.remove(
            mediainfo_audio_title
        )

        # [codec, channel, sampling rate, bit rate, bit depth]
        mediainfo_parts = mediainfo_audio_title.split(" / ")
        if len(mediainfo_parts) <= 4:
            reply += self.reporter.print_report(
                "warning", "Could not verify audio " + self._section_id("audio", i)
            )
            return reply

        # verify audio conversions
        if mediainfo_parts[0] == audio_to:
            disable_channels_check = self._eac3to_log_has_mono()

            if (
                not disable_channels_check
                and mediainfo_parts[1] != bdinfo_audio_parts[1]
            ):
                reply += self.reporter.print_report(
                    "error",
                    "Audio "
                    + self._section_id("audio", i)
                    + ": Channels should be `"
                    + bdinfo_audio_parts[1]
                    + "` instead of `"
                    + mediainfo_parts[1]
                    + "`",
                )

            # mediainfo bitrate should be less than bdinfo bitrate
            try:
                m_bit_rate = int(
                    "".join(re.findall(r"\d+", mediainfo_parts[3].strip()))
                )

                bd_bit_rate = int(
                    "".join(re.findall(r"\d+", bdinfo_audio_parts[3].strip()))
                )

                if m_bit_rate > bd_bit_rate:
                    reply += self.reporter.print_report(
                        "error",
                        "Audio "
                        + self._section_id("audio", i)
                        + ": MediaInfo bitrate is greater than BDInfo bitrate: `"
                        + str(m_bit_rate)
                        + " kbps > "
                        + str(bd_bit_rate)
                        + " kbps`",
                    )
            except ValueError:
                pass
        elif not optional:
            reply += self.reporter.print_report(
                "error",
                "Audio "
                + self._section_id("audio", i)
                + " should be converted to "
                + audio_to,
            )

        return reply

    def _eac3to_log_has_mono(self):
        # get command-lines

        cmd_lines_mono = list()
        for log in self.eac3to:
            cmd_lines_mono.extend(
                [
                    l.lower()
                    for l in log
                    if l.lower().startswith("command line:")
                    and "-mono" in l.lower().split()
                ]
            )

        return len(cmd_lines_mono) > 0
