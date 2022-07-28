from .check import *


class CheckMetadataDefaultFlag(Check):
    def __init__(self, reporter, mediainfo):
        super().__init__(reporter, mediainfo, "Error checking metadata default flag")

    # overriding abstract method
    def get_reply(self):
        # only one track of each type should be default=yes
        reply, default_yes_error = "", False
        track_types = ["audio", "text"]

        for track_type in track_types:
            default_yes_count = 0
            for track in self.mediainfo[track_type]:
                if "default" in track and track["default"].lower() == "yes":
                    default_yes_count += 1
            if default_yes_count > 1:
                reply += self.reporter.print_report(
                    "error",
                    "Only 1 {} track should be `default=yes`".format(track_type),
                )
                default_yes_error = True

        if not default_yes_error:
            reply += self.reporter.print_report(
                "correct",
                "Only 1 track of each type is `default=yes`",
            )
        return reply
