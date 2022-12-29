import re

# APIs
import emoji
from helpers import num_to_emoji


class Reporter(object):
    """
    Keep track of types of responses
    """

    def __init__(self):
        self.setup()

    def setup(self):
        """
        Setup/Reset the reporter
        """
        self.report = {"correct": 0, "warning": 0, "error": 0, "info": 0, "fail": 0}

    def print_report(self, type, message, record=True, new_line=True):
        """
        Display report

        Parameters
        ----------
        type : ReportType
            type of report: 'correct', 'warning', 'error', or 'info'

        message : str
            reply message

        record : bool
            should this report be kept track of in total

        new_line : bool
            print a new line after message
            default: True
        """
        if record:
            self.report[type.lower()] += 1

        msg_type = {
            "correct": emoji.emojize(":ballot_box_with_check:", language="alias"),
            "warning": emoji.emojize(":warning:", language="alias"),
            "error": emoji.emojize(":x:", language="alias"),
            "info": emoji.emojize(":information_source:", language="alias"),
            "fail": emoji.emojize(":interrobang:", language="alias"),
        }

        if type.lower() in msg_type:
            type = msg_type[type.lower()] + " "
        else:
            type = "[" + type.upper() + "] "

        return type + message + ("\n" if new_line else "")

    def get_report(self):
        """
        Get the report results

        Returns
        -------
        report dict: {'correct' : int, 'warning' : int, 'error' : int, 'info' : int, 'fail' : int}
        """
        return self.report

    def display_report(self):
        """
        Get the report reply

        Returns
        -------
        str reply
        """
        reply = str(self.report["correct"]) + " correct, "

        reply += str(self.report["warning"]) + " warning"
        reply += "" if self.report["warning"] == 1 else "s"

        reply += ", " + str(self.report["error"]) + " error"
        reply += "" if self.report["error"] == 1 else "s"

        reply += ", " + str(self.report["fail"]) + " failure"
        reply += "" if self.report["fail"] == 1 else "s"

        reply += ", and " + str(self.report["info"]) + " info"
        return reply


async def react_num_errors(message, num_errors):
    """
    Add status reactions to discord message with number of errors
    Adds a plus sign if more than 10 errors

    Parameters
    ----------
    message : discord.Message
        discord message to react to

    num_errors : int
        number of errors
    """
    if num_errors in range(1, 11):
        # errors between 1 and 10
        em = num_to_emoji(num_errors)
        if em:
            await message.add_reaction(emoji.emojize(em, language="alias"))
    elif num_errors > 10:
        # more than 10 errors
        await message.add_reaction(emoji.emojize(num_to_emoji(10), language="alias"))
        await message.add_reaction(emoji.emojize(":heavy_plus_sign:", language="alias"))


async def add_status_reactions(message, content):
    """
    Add status reactions to discord message

    Parameters
    ----------
    message : discord.Message
        discord message to react to

    content : str
        content to parse to determine reactions
    """
    # add status reactions to message based on content
    report_re = re.search(
        r"(\d+)\scorrect,\s(\d+)\swarnings?,\s(\d+)\serrors?,\s(\d+)\sfailures?,\sand\s(\d+)\sinfo",
        content,
    )
    if report_re:
        report = {
            "correct": int(report_re.group(1)),
            "warning": int(report_re.group(2)),
            "error": int(report_re.group(3)),
            "fail": int(report_re.group(4)),
            "info": int(report_re.group(5)),
        }

        if report["warning"] == 0 and report["error"] == 0 and report["fail"] == 0:
            await message.add_reaction(
                emoji.emojize(":ballot_box_with_check:", language="alias")
            )
        else:
            if report["warning"] > 0:
                await message.add_reaction(emoji.emojize(":warning:", language="alias"))
            if report["error"] > 0:
                await message.add_reaction(emoji.emojize(":x:", language="alias"))

            num_errors = report["warning"] + report["error"]
            if num_errors > 0:
                await react_num_errors(message, num_errors)

            if report["fail"] > 0:
                await message.add_reaction(
                    emoji.emojize(":interrobang:", language="alias")
                )
                await react_num_errors(message, report["fail"])
