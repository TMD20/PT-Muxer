import sys, traceback

# allow imports from parent directory
sys.path.append("../")

from abc import abstractmethod
from pydash import has
from helpers import has_many, show_diff, is_float


class Check(object):
    def __init__(self, reporter, mediainfo, run_fail_msg):
        self.reporter = reporter
        self.mediainfo = mediainfo
        self.run_fail_msg = run_fail_msg

    def run(self):
        """
        Runs the check and returns reply.
        Wraps check in try...except to prevent crashes

        Returns
        -------
        reply string
        """
        reply = ""
        try:
            reply += self.get_reply()
        except:
            traceback.print_exc()
            reply += self.reporter.print_report("fail", self.run_fail_msg)
        return reply

    @abstractmethod
    def get_reply(self):
        """
        Gets reply from this check

        Returns
        -------
        reply string
        """
        pass
