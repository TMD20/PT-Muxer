from .check import *

import re


class CheckPrintChapters(Check):
    def __init__(self, reporter, mediainfo):
        super().__init__(reporter, mediainfo, "Error printing chapters")

    # overriding abstract method
    def get_reply(self):
        reply = ""

        if len(self.mediainfo["menu"]) > 0:
            for i, menu in enumerate(self.mediainfo["menu"]):
                reply += f"> **Chapters {i + 1}**\n"
                numbered_chapters = True
                for ch in menu:
                    for title in ch["titles"]:
                        if not re.search(
                            r"^chapter\s\d+", title["title"], re.IGNORECASE
                        ):
                            numbered_chapters = False

                if not numbered_chapters:
                    reply += "```"
                    for ch in menu:
                        if ch["time"]:
                            reply += ch["time"] + " :"
                        for title in ch["titles"]:
                            if title["language"]:
                                reply += " lang: " + title["language"]
                            if title["title"]:
                                reply += " title: " + title["title"]
                        reply += "\n"
                    reply += "```"
                else:
                    reply += self.reporter.print_report("info", "Chapters are numbered")
                if len(menu[0]["languages"]) > 0:
                    reply += (
                        "Chapter languages: `" + ", ".join(menu[0]["languages"]) + "`\n"
                    )
        else:
            reply += self.reporter.print_report("info", "No chapters")

        return reply
