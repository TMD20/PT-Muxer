"""
Experimental REST API

> python3 api.py
POST http://127.0.0.1:5000/text
    Body, raw
    [INSERT TEXT HERE]
    
{"discord_reply":"...", "html_reply":"..."}
"""

import json, os, traceback
from flask import Flask, jsonify, request

from discord_markdown.discord_markdown import (
    Compiler,
    convert_to_html as discord_markdown_convert_to_html,
)

# Override discord_markdown.discord_markdown.Compiler.compile method to disable printing
# https://github.com/bitjockey42/discord-markdown/blob/9b8d267e3bf1b333bccaae5619a3f2af0a5a54a1/discord_markdown/compiler.py#L29-L37
def compile(self, markdown=False):
    if not self._parser.tree:
        self._parser.parse()
    self._code = ""
    for node in self._parser.tree:
        self._code = self._code + node.eval(markdown=markdown)
    self._code = self._code.strip()
    return self._code


Compiler.compile = compile

# parsers
from parsers import *
from source_detector import SourceDetector
from reporter import Reporter
from checker import Checker

# script location
__location__ = os.path.realpath(os.path.join(os.getcwd(), os.path.dirname(__file__)))

# initialize parsers
bdinfo_parser = BDInfoParser()
paste_parser = PasteParser(bdinfo_parser)
mediainfo_parser = MediaInfoParser()

with open(os.path.join(__location__, "data/codecs.json")) as f:
    codecs = json.load(f)
    codecs_parser = CodecsParser(codecs)

source_detector = SourceDetector()
reporter = Reporter()
checker = Checker(codecs_parser, source_detector, reporter)

app = Flask(__name__)


@app.route("/text", methods=["POST"])
def parse_text():
    """
    POST http://127.0.0.1:5000/text
    Body, raw
    [INSERT TEXT HERE]
    """

    reply = ""

    try:
        # setup/reset reporter
        reporter.setup()
        text = request.get_data().decode("utf-8")
        bdinfo, mediainfo, eac3to = paste_parser.parse(text)
    except:
        traceback.print_exc()
        reply += reporter.print_report("fail", "Failed to get paste")
    else:
        if mediainfo:
            try:
                # parse mediainfo
                mediainfo = mediainfo_parser.parse(mediainfo)
            except:
                traceback.print_exc()
                reply += reporter.print_report("fail", "Mediainfo parser failed")
            else:
                try:
                    # setup checker
                    checker.setup(bdinfo, mediainfo, eac3to, "remux-bot")
                except:
                    traceback.print_exc()
                    reply += reporter.print_report(
                        "fail", "vdator failed to setup checker"
                    )
                else:
                    try:
                        reply += checker.run_checks()
                    except:
                        traceback.print_exc()
                        reply += reporter.print_report("fail", "vdator failed to parse")
        else:
            reply += reporter.print_report(
                "error", "No mediainfo. Are you missing the `General` heading?"
            )

    # report
    reply += "> **Report**\n"
    reply += reporter.display_report()

    # prevent infinite loop with 2 multi-line code blocks
    # https://github.com/bitjockey42/discord-markdown/issues/6
    reply_to_convert = reply.replace("```", "===")
    # remove quotes around sections
    reply_to_convert = reply_to_convert.replace("> **", "**")

    # convert to html
    reply_html = discord_markdown_convert_to_html(reply_to_convert)

    # format html
    reply_html = reply_html.replace("===", "<br>")
    # emojis
    reply_html = reply_html.replace(
        "☑",
        "<img src='http://discord.com//assets/86c16c39d96283551fd4ca7392e22681.svg' height='16'>",
    )
    reply_html = reply_html.replace(
        "⚠",
        "<img src='https://discord.com/assets/289673858e06dfa2e0e3a7ee610c3a30.svg' height='16'>",
    )
    reply_html = reply_html.replace(
        "❌",
        "<img src='https://discord.com/assets/8becd37ab9d13cdfe37c08c496a9def3.svg' height='16'>",
    )

    data = {"discord_reply": reply, "html_reply": reply_html}

    return jsonify(data)


PORT = os.environ.get("PORT", "5000")
app.run(port=PORT)
