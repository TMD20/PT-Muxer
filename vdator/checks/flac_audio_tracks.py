from .check import *
from .mixins import SectionId

import re


class CheckFLACAudioTracks(Check, SectionId):
    def __init__(self, reporter, remove_until_first_codec, mediainfo):
        super().__init__(reporter, mediainfo, "Error checking FLAC audio tracks")
        self.remove_until_first_codec = remove_until_first_codec

    # overriding abstract method
    def get_reply(self):
        # check FLAC Audio tracks using mediainfo
        reply = ""

        if len(self.mediainfo["audio"]) > 0:
            for i, audio_track in enumerate(self.mediainfo["audio"]):
                # skip if no title
                if "title" not in audio_track:
                    continue

                # skip if no codec info
                audio_title, _, found_codec = self.remove_until_first_codec.remove(
                    audio_track["title"]
                )
                if not found_codec:
                    continue

                if "format" in audio_track and audio_track["format"] == "FLAC":
                    channels = float(
                        "".join(
                            re.findall(
                                r"\d*\.\d+|\d+", audio_track["channels"].strip().lower()
                            )
                        )
                    )
                    sampling_rate = int(
                        float(
                            "".join(
                                re.findall(
                                    r"\d*\.\d+|\d+",
                                    audio_track["sampling_rate"].strip().lower(),
                                )
                            )
                        )
                    )
                    bit_rate = int(
                        "".join(
                            re.findall(r"\d+", audio_track["bit_rate"].strip().lower())
                        )
                    )
                    bit_depth = (
                        audio_track["bit_depth"]
                        .strip()
                        .lower()
                        .replace(" bits", "-bit")
                    )
                    test_title = (
                        "FLAC Audio / "
                        + "{:.1f}".format(channels)
                        + " / "
                        + str(sampling_rate)
                        + " kHz / "
                        + str(bit_rate)
                        + " kbps / "
                        + bit_depth
                    )

                    if test_title == audio_title:
                        reply += self.reporter.print_report(
                            "correct",
                            "Audio "
                            + self._section_id("audio", i)
                            + ": FLAC Good track name (from MediaInfo)",
                        )
                    else:
                        reply += self.reporter.print_report(
                            "error",
                            "Audio "
                            + self._section_id("audio", i)
                            + ": FLAC Bad track name (from MediaInfo):\n```fix\nActual: "
                            + audio_title
                            + "\nExpected: "
                            + test_title
                            + "```",
                            new_line=False,
                        )

        return reply
