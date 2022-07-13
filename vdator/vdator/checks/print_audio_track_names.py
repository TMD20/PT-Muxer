from .check import *
from .mixins import SectionId


class CheckPrintAudioTrackNames(Check, SectionId):
    def __init__(self, reporter, mediainfo):
        super().__init__(reporter, mediainfo, "Error printing audio track names")

    # overriding abstract method
    def get_reply(self):
        reply = ""

        if len(self.mediainfo["audio"]) > 0:
            reply += "Audio Track Names:\n"
            reply += "```"
            for i, _ in enumerate(self.mediainfo["audio"]):
                reply += self._section_id("audio", i) + ": "
                if "title" in self.mediainfo["audio"][i]:
                    reply += self.mediainfo["audio"][i]["title"] + "\n"
            reply += "```"
        else:
            reply = self.reporter.print_report("error", "No audio tracks")

        return reply
