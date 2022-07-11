from .check import *


class CheckVideoLanguageMatchesFirstAudioLanguage(Check):
    def __init__(self, reporter, mediainfo):
        super().__init__(
            reporter,
            mediainfo,
            "Error checking that video language matches first audio language",
        )

    # overriding abstract method
    def get_reply(self):
        reply = ""

        if not has(self.mediainfo, "video.0.language"):
            reply += self.reporter.print_report("error", "Video language not set")
            return reply
        if not has(self.mediainfo, "audio.0.language"):
            reply += self.reporter.print_report("error", "First audio language not set")
            return reply
        if (
            self.mediainfo["video"][0]["language"]
            == self.mediainfo["audio"][0]["language"]
        ):
            reply += self.reporter.print_report(
                "correct",
                "Video language matches first audio language: `"
                + self.mediainfo["video"][0]["language"]
                + "`",
            )
        else:
            reply += self.reporter.print_report(
                "error",
                "Video language does not match first audio language: `"
                + self.mediainfo["video"][0]["language"]
                + "` vs `"
                + self.mediainfo["audio"][0]["language"]
                + "`",
            )
        return reply
