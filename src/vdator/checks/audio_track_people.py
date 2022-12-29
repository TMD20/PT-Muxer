from .check import *
from .mixins import SectionId

from nltk_people import extract_names


class CheckAudioTrackPeople(Check, SectionId):
    def __init__(self, reporter, remove_until_first_codec, mediainfo, tmdb, ia):
        super().__init__(reporter, mediainfo, "Error checking IMDb/TMDb people")
        self.remove_until_first_codec = remove_until_first_codec
        self.tmdb = tmdb
        self.ia = ia

    # overriding abstract method
    def get_reply(self):
        reply = ""

        # check people in audio track names
        for i, _ in enumerate(self.mediainfo["audio"]):
            if "title" in self.mediainfo["audio"][i]:
                title = self.mediainfo["audio"][i]["title"]

                # skip if has an audio codec
                _, _, found_codec = self.remove_until_first_codec.remove(title)
                if found_codec:
                    continue

                # try to match names
                matched_names = list()
                names = extract_names(title)
                search = self.tmdb.Search()
                for n in names:
                    # TMDb API
                    try:
                        search.person(query=n)
                        for s in search.results:
                            if n == s["name"]:
                                matched_names.append(n)
                    except:
                        reply += self.reporter.print_report(
                            "info",
                            "Audio "
                            + self._section_id("audio", i)
                            + ": Failed to get TMDb people data",
                        )
                    # IMDb API
                    try:
                        for person in self.ia.search_person(n):
                            if n == person["name"]:
                                matched_names.append(n)
                    except:
                        reply += self.reporter.print_report(
                            "info",
                            "Audio "
                            + self._section_id("audio", i)
                            + ": Failed to get IMDb people data",
                        )
                matched_names = set(matched_names)
                if len(matched_names) > 0:
                    reply += self.reporter.print_report(
                        "correct",
                        "Audio "
                        + self._section_id("audio", i)
                        + " People Matched: `"
                        + ", ".join(matched_names)
                        + "`",
                    )
                unmatched_names = set(names) - set(matched_names)
                if len(unmatched_names) > 0:
                    reply += self.reporter.print_report(
                        "warning",
                        "Audio "
                        + self._section_id("audio", i)
                        + " People Unmatched: `"
                        + ", ".join(unmatched_names)
                        + "`",
                    )

        return reply
