from .check import *


class CheckTextDefaultFlag(Check):
    def __init__(self, reporter, mediainfo):
        super().__init__(reporter, mediainfo, "Error checking text track default flag")

    # overriding abstract method
    def get_reply(self):
        # english subs for foreign films should be default=yes
        reply = ""

        if len(self.mediainfo["text"]) > 0:
            first_audio_language, has_english_subs, english_subs_default_yes = (
                False,
                False,
                False,
            )

            if has(self.mediainfo, "audio.0.language"):
                first_audio_language = self.mediainfo["audio"][0]["language"].lower()

            if first_audio_language != "english":
                # text tracks with language and default keys
                text_with_properties = [
                    item
                    for item in self.mediainfo["text"]
                    if ("language" in item and "default" in item)
                ]
                for item in text_with_properties:
                    if item["language"].lower() == "english":
                        has_english_subs = True
                    if item["default"].lower() == "yes":
                        english_subs_default_yes = True
                    if has_english_subs and english_subs_default_yes:
                        break

                if has_english_subs:
                    # foreign audio and has english subs. english subs should be default=yes
                    if english_subs_default_yes:
                        reply += self.reporter.print_report(
                            "correct",
                            "Foreign film, one of the English subtitles are `default=yes`",
                        )
                    else:
                        reply += self.reporter.print_report(
                            "error",
                            "Foreign film, one of the English subtitles should be `default=yes`",
                        )

        return reply
