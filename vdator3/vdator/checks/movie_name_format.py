from .check import *
from .mixins import IsMovie

import re


class CheckMovieNameFormat(Check, IsMovie):
    def __init__(self, reporter, mediainfo):
        super().__init__(reporter, mediainfo, "Error parsing movie name")

    # overriding abstract method
    def get_reply(self):
        reply = ""

        # is it a movie or tv show?
        is_movie = self._is_movie()

        if has(self.mediainfo, "general.0.movie_name"):
            if is_movie:
                # movie name in format "Name (Year)"
                if re.search(
                    r"^.+\(\d{4}\)$", self.mediainfo["general"][0]["movie_name"]
                ):
                    reply += self.reporter.print_report(
                        "correct",
                        "Movie name format `Name (Year)`: `"
                        + self.mediainfo["general"][0]["movie_name"]
                        + "`",
                    )
                else:
                    reply += self.reporter.print_report(
                        "error",
                        "Movie name does not match format `Name (Year)`: `"
                        + self.mediainfo["general"][0]["movie_name"]
                        + "`",
                    )
                    reply += self._movie_name_extra_space(
                        self.mediainfo["general"][0]["movie_name"]
                    )
            else:
                # tv show name in format "Name - S01E01" or "Name - S01E01E02"
                if re.search(
                    r"^.+\s-\sS\d{2}(E\d{2})+.*$",
                    self.mediainfo["general"][0]["movie_name"],
                ):
                    reply += self.reporter.print_report(
                        "correct",
                        "TV show name format `Name - S01E01`: `"
                        + self.mediainfo["general"][0]["movie_name"]
                        + "`",
                    )
                else:
                    reply += self.reporter.print_report(
                        "error",
                        "TV show name does not match format `Name - S01E01`: `"
                        + self.mediainfo["general"][0]["movie_name"]
                        + "`",
                    )
                    reply += self._movie_name_extra_space(
                        self.mediainfo["general"][0]["movie_name"]
                    )
        else:
            reply += self.reporter.print_report("error", "Missing movie name")

        return reply

    def _movie_name_extra_space(self, movie_name):
        reply = ""

        if movie_name.startswith(" "):
            reply += self.reporter.print_report(
                "error", "Movie name starts with an extra space!"
            )

        if movie_name.endswith(" "):
            reply += self.reporter.print_report(
                "error", "Movie name ends with an extra space!"
            )

        return reply
