from .check import *

import re


class CheckChapterPadding(Check):
    def __init__(self, reporter, mediainfo):
        super().__init__(reporter, mediainfo, "Error checking chapter padding")

    # overriding abstract method
    def get_reply(self):
        reply, padded_correctly = "", True

        if "menu" in self.mediainfo and len(self.mediainfo["menu"]) > 0:
            if len(self.mediainfo["menu"]) >= 1:
                for i, menu in enumerate(self.mediainfo["menu"]):
                    padded_correctly = True
                    num_chapters = len(menu)
                    for ch in menu:
                        for title in ch["titles"]:
                            if re.search(
                                r"^chapter\s\d+", title["title"], re.IGNORECASE
                            ):
                                # numbered chapter
                                ch_num = "".join(re.findall(r"[\d]+", title["title"]))
                                if ch_num != ch_num.zfill(len(str(num_chapters))):
                                    padded_correctly = False
                                    break
                    if padded_correctly:
                        reply += self.reporter.print_report(
                            "correct", f"Chapters {i + 1}: Properly padded"
                        )
                    else:
                        reply += self.reporter.print_report(
                            "error", f"Chapters {i + 1}: Incorrect padding"
                        )

        return reply
