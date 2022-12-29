from .check import *

import re


class CheckVideoTrack(Check):
    def __init__(self, reporter, source_detector, codecs, mediainfo, bdinfo):
        super().__init__(reporter, mediainfo, "Error checking video track name")
        self.source_detector = source_detector
        self.codecs = codecs
        self.bdinfo = bdinfo

    # overriding abstract method
    def get_reply(self):
        reply = ""

        if (
            has_many(
                self.mediainfo,
                "video.0",
                [
                    "format",
                    "format_version",
                    "bit_rate",
                    "height",
                    "scan_type",
                    "frame_rate",
                    "display_aspect_ratio",
                    "title",
                ],
            )
            and self.source_detector.is_dvd()
        ):
            # dvd video title from mediainfo
            video_title = self._dvd_video_title_from_mediainfo()
            mediainfo_title = self.mediainfo["video"][0]["title"]

            if mediainfo_title == video_title:
                reply += self.reporter.print_report(
                    "correct",
                    "Video track names match: ```" + mediainfo_title + "```",
                    new_line=False,
                )
            else:
                reply += self.reporter.print_report(
                    "error",
                    "Video track names missmatch:\n```fix\nExpected: "
                    + video_title
                    + "\nMediaInfo: "
                    + mediainfo_title
                    + "```",
                    new_line=False,
                )
                reply += show_diff(mediainfo_title, video_title)

        elif has(self.bdinfo, "video") and has(self.mediainfo, "video"):
            if len(self.bdinfo["video"]) < 1:
                reply += self.reporter.print_report(
                    "error", "Missing bdinfo video track"
                )
                return reply
            elif len(self.mediainfo["video"]) < 1:
                reply += self.reporter.print_report(
                    "error", "Missing mediainfo video track"
                )
                return reply

            if has(self.mediainfo, "video.0.title") and has(self.bdinfo, "video.0"):
                mediainfo_video_title = self.mediainfo["video"][0]["title"]
                bdinfo_video_title = self.bdinfo["video"][0]

                # 1080i @ 25fps is actually progressive
                reply += self._actually_progressive()

                bitrate_search = re.search(r"(\d+\.\d+)\skbps", mediainfo_video_title)
                if bitrate_search:
                    # if mediainfo has a decimal kbps bitrate, use it in the bdinfo for comparison
                    percise_bitrate = bitrate_search.group(1)
                    percise_kbps = percise_bitrate + " kbps"
                    bdinfo_video_title = re.sub(
                        r"(\d+)\skbps", percise_kbps, bdinfo_video_title
                    )
                if self.source_detector.is_dv() and mediainfo_video_title.startswith(
                    bdinfo_video_title
                ):
                    # if source is dolby vision, only check that the first part of mediainfo video title
                    # matches bdinfo video title. Up to BT.2020, i.e. Dolby Vision FEL is not checked
                    reply += self.reporter.print_report(
                        "correct",
                        "Video track names match: ```" + mediainfo_video_title + "```",
                        new_line=False,
                    )
                elif bdinfo_video_title == mediainfo_video_title:
                    reply += self.reporter.print_report(
                        "correct",
                        "Video track names match: ```" + bdinfo_video_title + "```",
                        new_line=False,
                    )
                else:
                    reply += self.reporter.print_report(
                        "error",
                        "Video track names missmatch:\n```fix\nBDInfo: "
                        + bdinfo_video_title
                        + "\nMediaInfo: "
                        + mediainfo_video_title
                        + "```",
                        new_line=False,
                    )
                    reply += show_diff(mediainfo_video_title, bdinfo_video_title)
            else:
                reply += self.reporter.print_report(
                    "error", "Missing mediainfo video track"
                )
                return reply
        else:
            reply += self.reporter.print_report("error", "Could not verify video track")

        return reply

    def _dvd_video_title_from_mediainfo(self):
        # dictionary existence already checked

        video_title = ""
        # MPEG-
        video_title += self.mediainfo["video"][0]["format"].split()[0] + "-"

        # 1
        video_title += "".join(
            re.findall(r"[\d]+", self.mediainfo["video"][0]["format_version"])
        )
        video_title += " Video / "

        # bitrate
        video_title += (
            "".join(re.findall(r"[\d]+", self.mediainfo["video"][0]["bit_rate"]))
            + " kbps"
        )
        video_title += " / "

        # height
        video_title += "".join(
            re.findall(r"[\d]+", self.mediainfo["video"][0]["height"])
        )

        # scan type
        (scan_type, _) = self.codecs.get_scan_type_title_name(
            self.mediainfo["video"][0]["scan_type"].lower(), 0
        )
        video_title += scan_type
        video_title += " / "

        # fps
        video_fps = float(
            "".join(re.findall(r"\d+\.\d+", self.mediainfo["video"][0]["frame_rate"]))
        )
        if video_fps.is_integer():
            video_fps = int(video_fps)
        video_title += str(video_fps) + " fps / "

        # aspect ratio
        video_title += self.mediainfo["video"][0]["display_aspect_ratio"]

        return video_title

    def _actually_progressive(self):
        # dictionary existence already checked

        reply = ""

        bdinfo_video_title = self.bdinfo["video"][0]
        bdinfo_video_parts = bdinfo_video_title.split(" / ")

        if len(bdinfo_video_parts) >= 3:
            scan_type = bdinfo_video_parts[2].strip()[-1].lower()
            video_fps = float(
                "".join(
                    re.findall(r"\d*\.\d+|\d+", bdinfo_video_parts[3].strip().lower())
                )
            )
            (_, actually_progressive) = self.codecs.get_scan_type_title_name(
                scan_type, video_fps
            )
            if actually_progressive:
                reply += self.reporter.print_report(
                    "info", "Note: 1080i @ 25fps is actually progressive"
                )

        return reply
