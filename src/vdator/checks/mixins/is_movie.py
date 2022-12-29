from pydash import has
import re


class IsMovie(object):

    # returns True if its a movie, False if tv show
    def _is_movie(self):
        # is it a movie or tv show? assume movie
        is_movie = True
        determined_movie_or_tv = False

        if has(self.mediainfo, "general.0.tmdb"):
            if self.mediainfo["general"][0]["tmdb"].startswith("movie/"):
                is_movie = True
                determined_movie_or_tv = True
            elif self.mediainfo["general"][0]["tmdb"].startswith("tv/"):
                is_movie = False
                determined_movie_or_tv = True

        if not determined_movie_or_tv:
            if has(self.mediainfo, "general.0.movie_name"):
                # tv show name in format "Name - S01E01" or "Name - S01E01E02"
                is_tv = re.search(
                    r"^.+\s-\sS\d{2}(E\d{2})+.*$",
                    self.mediainfo["general"][0]["movie_name"],
                )
                if is_tv:
                    is_movie = not (is_tv)
        return is_movie
