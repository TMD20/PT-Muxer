from .check import *


class CheckHasChapters(Check):
    def __init__(self, reporter, mediainfo, eac3to):
        super().__init__(reporter, mediainfo, "Error checking if should have chapters")
        self.eac3to = eac3to

    # overriding abstract method
    def get_reply(self):
        reply, should_have_chapters = "", False
        for log in self.eac3to:
            for l in log:
                if "chapters" in l:
                    should_have_chapters = True
        if should_have_chapters:
            if len(self.mediainfo["menu"]) > 0:
                reply += self.reporter.print_report(
                    "correct", "Has chapters (from eac3to log)"
                )
            else:
                reply += self.reporter.print_report(
                    "error", "Should have chapters (from eac3to log)"
                )
        return reply
