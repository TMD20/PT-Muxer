from .check import *
from .mixins import IsMovie

from dotenv import load_dotenv
import datetime, os, re
import imdb

# load environment variables
load_dotenv()

# how many years off the movie year can be. (default: 1)
MOVIE_YEAR_OFFSET = int(os.environ.get("MOVIE_YEAR_OFFSET", "1").strip())


class CheckMetadataIds(Check, IsMovie):
    def __init__(self, reporter, mediainfo, tmdb, ia):
        super().__init__(reporter, mediainfo, "Error parsing IMDb/TMDb ids")
        self.tmdb = tmdb
        self.ia = ia

    # overriding abstract method
    def get_reply(self):
        reply = ""

        imdb_movie, tmdb_info, tmdb_year = None, None, None

        movie_data = {"name": None, "year": None}

        matched = {
            "imdb_title": False,
            "imdb_year": False,
            "tmdb_title": False,
            "tmdb_year": False,
            # matched movie title/year with either imdb or tmdb
            "title": False,
            "year": False,
            "title_replied": False,
            "year_replied": False,
        }

        # is it a movie or tv show?
        is_movie = self._is_movie()

        # extract movie name and year or tv show name
        if has(self.mediainfo, "general.0.movie_name"):
            if is_movie:
                # movie
                movie_name = re.search(
                    r"^(.+)\((\d{4})\)", self.mediainfo["general"][0]["movie_name"]
                )
                if movie_name:
                    movie_data["name"] = movie_name.group(1).strip()
                    movie_data["year"] = movie_name.group(2).strip()
            else:
                # tv show
                tv_show_name = re.search(
                    r"^(.+)\s-\s.+\s-\s.+", self.mediainfo["general"][0]["movie_name"]
                )
                if tv_show_name:
                    movie_data["name"] = tv_show_name.group(1).strip()

        if has(self.mediainfo, "general.0.imdb"):
            imdb_id = "".join(
                re.findall(r"[\d]+", self.mediainfo["general"][0]["imdb"])
            )
            try:
                imdb_movie = self.ia.get_movie(imdb_id)
            except imdb._exceptions.IMDbParserError:
                reply += self.reporter.print_report(
                    "error",
                    "Invalid IMDb id: `" + self.mediainfo["general"][0]["imdb"] + "`",
                )
            except:
                # imdb._exceptions.IMDbDataAccessError
                reply += self.reporter.print_report(
                    "info",
                    "Failed to get IMDb movie data for id: `"
                    + self.mediainfo["general"][0]["imdb"]
                    + "`",
                )
            else:
                # force single space in movie name
                imdb_movie["title"] = re.sub(r"\s+", " ", imdb_movie["title"])
                matched["imdb_title"] = movie_data["name"] == imdb_movie["title"]
                if is_movie:
                    matched["imdb_year"] = self._year_range(
                        imdb_movie["year"], movie_data["year"]
                    )

        if has(self.mediainfo, "general.0.tmdb"):
            tmdb_id = "".join(
                re.findall(r"[\d]+", self.mediainfo["general"][0]["tmdb"])
            )
            # movie or tv show
            tmdb_data = self.tmdb.Movies(tmdb_id) if is_movie else self.tmdb.TV(tmdb_id)

            try:
                tmdb_info = tmdb_data.info()
                # force single space in movie name
                if "title" in tmdb_info:
                    tmdb_info["title"] = re.sub(r"\s+", " ", tmdb_info["title"])
            except:
                reply += self.reporter.print_report(
                    "info",
                    "Failed to get TMDb data for id: `"
                    + self.mediainfo["general"][0]["tmdb"]
                    + "`",
                )
            else:
                if is_movie:
                    # movie
                    if "release_date" in tmdb_info and tmdb_info["release_date"]:
                        datetime_obj = datetime.datetime.strptime(
                            tmdb_info["release_date"], "%Y-%m-%d"
                        )
                        tmdb_year = str(datetime_obj.year)
                    # tmdb_info["original_title"] is original title
                    # tmdb_info["title"] is the translated title in whatever language you're requesting
                    matched["tmdb_title"] = (
                        "title" in tmdb_info
                        and movie_data["name"] == tmdb_info["title"]
                    )
                    matched["tmdb_year"] = tmdb_year and self._year_range(
                        tmdb_year, movie_data["year"]
                    )
                else:
                    # tv show
                    matched["tmdb_title"] = (
                        "title" in tmdb_info
                        and movie_data["name"] == tmdb_info["title"]
                    )

        # matched title/year with either imdb or tmdb
        matched["title"] = matched["imdb_title"] or matched["tmdb_title"]
        matched["year"] = matched["imdb_year"] or matched["tmdb_year"]

        if has(self.mediainfo, "general.0.imdb") or has(
            self.mediainfo, "general.0.tmdb"
        ):
            if is_movie:
                # movie
                if matched["title"] and matched["year"]:
                    reply += self.reporter.print_report(
                        "correct", "Matched movie name and year with IMDb/TMDb"
                    )
                else:
                    if matched["title"]:
                        reply += self.reporter.print_report(
                            "correct", "Matched movie name with IMDb/TMDb"
                        )
                    else:
                        if imdb_movie and "title" in imdb_movie and imdb_movie["title"]:
                            reply += self.reporter.print_report(
                                "error", "IMDb: Name: `" + imdb_movie["title"] + "`"
                            )
                            if movie_data["name"]:
                                reply += show_diff(
                                    movie_data["name"], imdb_movie["title"]
                                )
                            matched["title_replied"] = True
                        # tmdb_info["original_title"] is original title
                        # tmdb_info["title"] is the translated title in whatever language you're requesting
                        if tmdb_info and "title" in tmdb_info and tmdb_info["title"]:
                            reply += self.reporter.print_report(
                                "error", "TMDb: Name: `" + tmdb_info["title"] + "`"
                            )
                            if movie_data["name"]:
                                reply += show_diff(
                                    movie_data["name"], tmdb_info["title"]
                                )
                            matched["title_replied"] = True
                        if not matched["title_replied"]:
                            reply += self.reporter.print_report(
                                "error", "Failed to match movie name with IMDb/TMDb"
                            )

                    if matched["year"]:
                        reply += self.reporter.print_report(
                            "correct", "Matched movie year with IMDb/TMDb"
                        )
                    else:
                        if imdb_movie and "year" in imdb_movie:
                            reply += self.reporter.print_report(
                                "error", "IMDb: Year: `" + str(imdb_movie["year"]) + "`"
                            )
                            matched["year_replied"] = True
                        if tmdb_year:
                            reply += self.reporter.print_report(
                                "error", "TMDb: Year: `" + str(tmdb_year) + "`"
                            )
                            matched["year_replied"] = True
                        if not matched["year_replied"]:
                            reply += self.reporter.print_report(
                                "error", "Failed to match movie year with IMDb/TMDb"
                            )
            else:
                # tv show
                if matched["title"]:
                    reply += self.reporter.print_report(
                        "correct", "Matched tv show name with IMDb/TMDb"
                    )
                else:
                    if imdb_movie and "title" in imdb_movie:
                        reply += self.reporter.print_report(
                            "error", "IMDb: Name: `" + imdb_movie["title"] + "`"
                        )
                        matched["title_replied"] = True
                    if tmdb_info and "name" in tmdb_info:
                        reply += self.reporter.print_report(
                            "error", "TMDb: Name: `" + tmdb_info["name"] + "`"
                        )
                        matched["title_replied"] = True
                    if not matched["title_replied"]:
                        reply += self.reporter.print_report(
                            "error", "Failed to match tv show name with IMDb/TMDb"
                        )

        return reply

    def _year_range(self, year, test_year, offset=MOVIE_YEAR_OFFSET):
        # self._year_range(year, test_year)
        # example: with offset = 1, and year = 2004, test_year can be between 2003 and 2005 inclusive
        # 2002 in range(2004 - 1, (2004 + 1) + 1) False
        # 2003 in range(2004 - 1, (2004 + 1) + 1) True
        # 2004 in range(2004 - 1, (2004 + 1) + 1) True
        # 2005 in range(2004 - 1, (2004 + 1) + 1) True
        # 2006 in range(2004 - 1, (2004 + 1) + 1) False
        year = int(year)
        test_year = int(test_year)
        return test_year in range(year - offset, (year + offset) + 1)
