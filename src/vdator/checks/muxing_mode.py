from .check import *


class CheckMuxingMode(Check):
    def __init__(self, reporter, mediainfo):
        super().__init__(
            reporter,
            mediainfo,
            "Error checking muxing mode",
        )

    # overriding abstract method
    def get_reply(self):
        reply, is_valid = "", True

        for section in ["general", "video", "audio", "text"]:
            for i, _ in enumerate(self.mediainfo[section]):
                if "muxing_mode" in self.mediainfo[section][i]:
                    reply += self.reporter.print_report(
                        "error",
                        section.capitalize()
                        + " #"
                        + self.mediainfo[section][i]["id"]
                        + " has muxing mode: `"
                        + self.mediainfo[section][i]["muxing_mode"]
                        + "`",
                    )
                    is_valid = False

        if is_valid:
            reply += self.reporter.print_report(
                "correct", "All tracks do not have a muxing mode"
            )

        return reply
