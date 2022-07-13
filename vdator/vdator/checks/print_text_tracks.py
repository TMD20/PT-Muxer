from .check import *
from .mixins import SectionId


class CheckPrintTextTracks(Check, SectionId):
    def __init__(self, reporter, mediainfo):
        super().__init__(reporter, mediainfo, "Error printing text tracks")

    # overriding abstract method
    def get_reply(self):
        reply = ""
        if len(self.mediainfo["text"]) > 0:
            reply += "```"
            for i, _ in enumerate(self.mediainfo["text"]):
                reply += self._section_id("text", i) + ":"
                if "default" in self.mediainfo["text"][i]:
                    reply += " default:" + self.mediainfo["text"][i]["default"]
                if "forced" in self.mediainfo["text"][i]:
                    reply += " forced:" + self.mediainfo["text"][i]["forced"]
                if "language" in self.mediainfo["text"][i]:
                    reply += " language:" + self.mediainfo["text"][i]["language"]
                if "title" in self.mediainfo["text"][i]:
                    reply += " title: " + self.mediainfo["text"][i]["title"]
                reply += "\n"
            reply += "```"
        else:
            reply += self.reporter.print_report("info", "No text tracks")
        return reply
