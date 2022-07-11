from .check import *

from dotenv import load_dotenv
import os, re, requests

# load environment variables
load_dotenv()

MKVMERGE_VERSION = os.environ.get("MKVMERGE_VERSION")


class CheckMKVMerge(Check):
    def __init__(self, reporter, mediainfo):
        super().__init__(
            reporter,
            mediainfo,
            "Error checking mkvtoolnix version",
        )

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
            reply += self.get_reply(MKVMERGE_VERSION)
        except:
            traceback.print_exc()
            reply += self.reporter.print_report("fail", self.run_fail_msg)
        return reply

    # overriding abstract method
    # force_version = "Version 57.0.0 \"Till The End\" 2021-05-22"
    def get_reply(self, force_version=None):
        reply = ""

        version_name_regex_mkvtoolnix = r'"(.*)"'
        version_name_regex_mediainfo = r"\'(.*)\'"
        version_num_regex = r"(\d+\.\d+\.\d+)"

        if not has(self.mediainfo, "general.0.writing_application"):
            reply += self.reporter.print_report("info", "Not using mkvtoolnix")
            return reply

        mediainfo_version_num = re.search(
            version_num_regex, self.mediainfo["general"][0]["writing_application"]
        )
        if mediainfo_version_num:
            mediainfo_version_num = mediainfo_version_num.group(1)

        mediainfo_version_name = re.search(
            version_name_regex_mediainfo,
            self.mediainfo["general"][0]["writing_application"],
        )
        if mediainfo_version_name:
            mediainfo_version_name = mediainfo_version_name.group(1)

        if not mediainfo_version_num or not mediainfo_version_name:
            reply += self.reporter.print_report("info", "Not using mkvtoolnix")
            return reply

        try:
            r = requests.get(os.environ.get("MKVTOOLNIX_NEWS"))
            if r.status_code == 200:
                ## Version 32.0.0 "Astral Progressions" 2019-03-12
                mkvtoolnix_version_line = r.text.splitlines()[0]
                if force_version:
                    mkvtoolnix_version_line = force_version

                mkvtoolnix_version_num = re.search(
                    version_num_regex, mkvtoolnix_version_line
                )
                if mkvtoolnix_version_num:
                    mkvtoolnix_version_num = mkvtoolnix_version_num.group(1)

                mkvtoolnix_version_name = re.search(
                    version_name_regex_mkvtoolnix, mkvtoolnix_version_line
                )
                if mkvtoolnix_version_name:
                    mkvtoolnix_version_name = mkvtoolnix_version_name.group(1)

                if (
                    mkvtoolnix_version_num == mediainfo_version_num
                    and mkvtoolnix_version_name == mediainfo_version_name
                ):
                    reply += self.reporter.print_report(
                        "correct",
                        "Uses latest mkvtoolnix: `"
                        + mediainfo_version_num
                        + ' "'
                        + mediainfo_version_name
                        + '"`',
                    )
                else:
                    reply += self.reporter.print_report(
                        "warning",
                        "Not using latest mkvtoolnix: `"
                        + mediainfo_version_num
                        + ' "'
                        + mediainfo_version_name
                        + '"` latest is: `'
                        + mkvtoolnix_version_num
                        + ' "'
                        + mkvtoolnix_version_name
                        + '"`',
                    )
        except:
            reply += self.reporter.print_report(
                "info", "Could not fetch latest mkvtoolnix version"
            )
            return reply

        return reply
