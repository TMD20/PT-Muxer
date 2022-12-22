from .check import *

from dotenv import load_dotenv
import os, re, string, unidecode

# load environment variables
load_dotenv()

CUTS = [None] + [x.strip() for x in os.environ.get("FILENAME_CUTS").split(",")]
RELEASE_GROUP = os.environ.get("RELEASE_GROUP").strip()
TRAINEE_CHANNELS = [x.strip() for x in os.environ.get("TRAINEE_CHANNELS").split(",")]
INTERNAL_CHANNELS = [x.strip() for x in os.environ.get("INTERNAL_CHANNELS").split(",")]


class CheckFilename(Check):
    def __init__(
        self,
        reporter,
        source_detector,
        codecs,
        remove_until_first_codec,
        mediainfo,
        bdinfo,
        channel_name,
    ):
        super().__init__(reporter, mediainfo, "Error checking filename")
        self.source_detector = source_detector
        self.codecs = codecs
        self.remove_until_first_codec = remove_until_first_codec
        self.bdinfo = bdinfo
        self.channel_name = channel_name

    # overriding abstract method
    def get_reply(self):
        reply = ""

        if has_many(self.mediainfo, "general.0", ["movie_name", "complete_name"]):
            complete_name = self.mediainfo["general"][0]["complete_name"]
            if "\\" in complete_name:
                complete_name = complete_name.split("\\")[-1]
            elif "/" in complete_name:
                complete_name = complete_name.split("/")[-1]

            # possible release names
            complete_name_lc = complete_name.lower()
            possible_release_names = [
                self._construct_release_name(
                    cut,
                    hybird=("hybrid" in complete_name_lc),
                    repack=("repack" in complete_name_lc),
                )
                for cut in CUTS
            ]

            if (
                self.channel_name in INTERNAL_CHANNELS
                and complete_name in possible_release_names
            ):
                reply += self.reporter.print_report(
                    "correct", "Filename: `" + complete_name + "`"
                )
            elif self._partial_match(possible_release_names, complete_name):
                reply += self.reporter.print_report(
                    "correct", "Filename: `" + complete_name + "`"
                )
            else:
                expected_release_name = possible_release_names[0]

                # pick the expected release name with the proper cut
                for i, cut in enumerate(CUTS[1:]):
                    if cut in complete_name:
                        expected_release_name = possible_release_names[i + 1]

                if self.channel_name not in INTERNAL_CHANNELS:
                    expected_release_name += "GRouP.mkv"

                reply += self.reporter.print_report(
                    "error",
                    "Filename missmatch:\n```fix\nFilename: "
                    + complete_name
                    + "\nExpected: "
                    + expected_release_name
                    + "```",
                    new_line=False,
                )
                reply += show_diff(complete_name, expected_release_name)
        else:
            reply += self.reporter.print_report("error", "Cannot validate filename")

        return reply

    def _construct_release_name(self, cut=None, hybird=False, repack=False):
        release_name = ""

        if not self.source_detector.is_dvd():
            # scan type must come from bdinfo
            bdinfo_video_parts = self.bdinfo["video"][0].split(" / ")
            scan_type = bdinfo_video_parts[2].strip()[-1].lower()

        if has_many(self.mediainfo, "video.0", ["height", "title"]) and has(
            self.mediainfo, "audio.0.title"
        ):
            # Name.S01E01 or Name.S01E01E02
            tv_show_name_search = re.search(
                r"(.+)\s-\s(S\d{2}(E\d{2})+)",
                self.mediainfo["general"][0]["movie_name"],
            )
            # Name.Year
            movie_name_search = re.search(
                r"(.+)\s\((\d{4})\)", self.mediainfo["general"][0]["movie_name"]
            )
            if tv_show_name_search:
                title = self._format_filename_title(tv_show_name_search.group(1))
                season_episode = tv_show_name_search.group(2).strip()
                release_name += title + "." + season_episode
            elif movie_name_search:
                title = self._format_filename_title(movie_name_search.group(1))
                year = movie_name_search.group(2).strip()
                release_name += title + "." + year
            else:
                release_name += self._format_filename_title(
                    self.mediainfo["general"][0]["movie_name"]
                )

            # with or without hybrid
            if hybird:
                release_name += ".Hybrid"

            # with or without repack
            if repack:
                release_name += ".REPACK"

            # check cuts here
            if cut is not None:
                release_name += "." + cut

            # resolution (ex. 1080p)
            height = "".join(re.findall(r"[\d]+", self.mediainfo["video"][0]["height"]))

            if self.source_detector.is_dvd():
                # source DVD
                if "standard" in self.mediainfo["video"][0]:
                    release_name += "." + self.mediainfo["video"][0]["standard"]
                release_name += ".DVD.REMUX"
            elif self.source_detector.is_uhd():
                # source UHD BluRay
                release_name += "." + height
                release_name += scan_type
                release_name += ".UHD.BluRay.REMUX"
                # Dolby Vision (DV)
                if self.source_detector.is_dv():
                    release_name += ".DV"
                # SDR/HDR
                if self.mediainfo["video"][0]["color_primaries"] == "BT.2020":
                    release_name += ".HDR"
                else:
                    release_name += ".SDR"
            else:
                # source HD BluRay
                release_name += "." + height
                release_name += scan_type
                release_name += ".BluRay.REMUX"

            # video format (ex. AVC)
            main_video_title = self.mediainfo["video"][0]["title"].split(" / ")
            if len(main_video_title) >= 1:
                release_name += "." + self.codecs.get_video_codec_title_name(
                    main_video_title[0].strip()
                )

            main_audio_title = self.mediainfo["audio"][0]["title"]
            (
                main_audio_title,
                _,
                _,
            ) = self.remove_until_first_codec.remove(main_audio_title)
            main_audio_title_parts = main_audio_title.split(" / ")

            audio_codec_title, main_audio_channels = None, None

            # get main audio codec
            if len(main_audio_title) > 0:
                main_audio_codec = main_audio_title_parts[0]
                if self.codecs.is_audio_title(main_audio_codec):
                    audio_codec_title = self.codecs.get_audio_codec_title_name(
                        main_audio_codec
                    )

            # get main audio channels
            if len(main_audio_title) > 1:
                main_audio_channels = main_audio_title_parts[1]
                search_channel_atmos = re.search(
                    r"(\d.\d)\+\d+\sobjects", main_audio_channels
                )
                if search_channel_atmos:
                    main_audio_channels = search_channel_atmos.group(1)

            if (
                audio_codec_title
                and main_audio_channels
                and is_float(main_audio_channels)
            ):
                # have main audio codec and channels
                if audio_codec_title == "TrueHD.Atmos":
                    # atmos channel
                    release_name += ".TrueHD." + main_audio_channels + ".Atmos"
                else:
                    release_name += "." + audio_codec_title + "." + main_audio_channels

            # release group
            release_name += "-"
            if self.channel_name in INTERNAL_CHANNELS:
                release_name += RELEASE_GROUP + ".mkv"

        # replace multiple dots with one
        release_name = re.sub("\.+", ".", release_name)

        return release_name

    def _format_filename_title(self, title):
        title = title.strip()
        # remove accents
        title = unidecode.unidecode(title)
        # remove punctuation
        title = title.replace("&", "and")
        title = "".join([i for i in title if not i in string.punctuation or i == "."])
        title = title.replace(":", ".")
        # replace spaces with dots
        title = title.replace(" ", ".")
        # force single dots
        title = re.sub(r"\.+", ".", title)
        return title

    def _partial_match(self, possible_names, name):
        for n in possible_names:
            if n in name:
                return True
        return False
