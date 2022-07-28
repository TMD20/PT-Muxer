from .check import *
from .mixins import SectionId


class CheckTracksHaveLanguage(Check, SectionId):
    def __init__(self, reporter, mediainfo):
        super().__init__(reporter, mediainfo, "Error checking if tracks have language")

    # overriding abstract method
    def get_reply(self):
        reply, is_valid = "", True

        for section in ["video", "audio", "text"]:
            for i, _ in enumerate(self.mediainfo[section]):
                if "language" not in self.mediainfo[section][i]:
                    reply += self.reporter.print_report(
                        "error",
                        section.capitalize()
                        + " "
                        + self._section_id(section, i)
                        + ": Does not have a language chosen",
                    )
                    is_valid = False

        if is_valid:
            reply += self.reporter.print_report(
                "correct", "All tracks have a language chosen"
            )

        return reply
