#!/usr/bin/env python3

from dotenv import load_dotenv
import json, os, requests, traceback

# APIs
import discord
from discord.utils import get

# parsers
from helpers import balanced_blockquotes, split_string
from parsers import *
from source_detector import SourceDetector
from reporter import Reporter, add_status_reactions
from checker import Checker

# script location
__location__ = os.path.realpath(os.path.join(os.getcwd(), os.path.dirname(__file__)))

# initialize parsers
with open(os.path.join(__location__, "data/urls.json")) as f:
    urls = json.load(f)["urls"]
    url_parser = URLParser(urls)

bdinfo_parser = BDInfoParser()
paste_parser = PasteParser(bdinfo_parser)
mediainfo_parser = MediaInfoParser()

with open(os.path.join(__location__, "data/codecs.json")) as f:
    codecs = json.load(f)
    codecs_parser = CodecsParser(codecs)

source_detector = SourceDetector()
reporter = Reporter()
checker = Checker(codecs_parser, source_detector, reporter)

# load environment variables
load_dotenv()

# environment variables
IN_GAME = os.environ.get("IN_GAME").strip()
IGNORE_AFTER_LINE = os.environ.get("IGNORE_AFTER_LINE").strip()

# channels to listen in and add reactions
REVIEW_CHANNELS = [x.strip() for x in os.environ.get("REVIEW_CHANNELS").split(",")]

# channels to send full summary to if from review channel
REVIEW_REPLY_CHANNELS = [
    x.strip() for x in os.environ.get("REVIEW_REPLY_CHANNELS").split(",")
]

# channels to listen in and post full summaries
BOT_CHANNELS = [x.strip() for x in os.environ.get("BOT_CHANNELS").split(",")]

VERSION = "1.4.0"


def print_help():
    return (
        "vdator " + VERSION + " help: "
        "I take a Pastebin link with BDInfo and MediaInfo dump."
        " I ignore all input after the line `" + IGNORE_AFTER_LINE + "`."
        " I add reactions in the following review channels: `"
        + ", ".join(REVIEW_CHANNELS)
        + "`,"
        + " I reply with full summary from review channels to: `"
        + ", ".join(REVIEW_REPLY_CHANNELS)
        + "`"
        + " and post full summaries in: `"
        + ", ".join(BOT_CHANNELS)
        + "`."
        " Add a minus (-) sign in front of unused audio tracks in BDInfo."
        " I check:```"
        "Movie/TV name format\n"
        "IMDB/TMDB ids\n"
        "Filename\n"
        "Video language matches first audio language\n"
        "No muxing mode\n"
        "Uses latest mkvtoolnix\n"
        "Video and audio track names match\n"
        "DTS-HD MA 1.0/2.0 optionally to FLAC, LPCM 1.0/2.0 to FLAC, LPCM > 2.0 to DTS-HD MA\n"
        "Commentary to AC-3 @ 224 kbps\n"
        "Commentary track people and spellcheck\n"
        "Subtitle order\n"
        "Subtitle default flag\n"
        "Should have chapters\n"
        "Chapter languages\n"
        "Chapter padding```"
        "**Commands:** !help, !version"
    )


def print_version():
    return "vdator " + VERSION


intents = discord.Intents.default()
intents.message_content = True
client = discord.Client(intents=intents)


@client.event
async def on_ready():
    """
    Discord client is ready
    """
    print("I'm in")
    print(client.user)
    await client.change_presence(activity=discord.Game(name=IN_GAME))


@client.event
async def on_message(message):
    """
    Discord message event

    Parameters
    ----------
    message : discord.Message class
        discord message
    """
    # get name of channel message was sent in
    # if message is in a thread, the channel name is in message.channel.parent, otherwise its in message.channel.name
    channel_name = (
        str(message.channel.parent)
        if hasattr(message.channel, "parent")
        else str(message.channel.name)
    )
    channel = get(
        message.guild.channels,
        name=channel_name,
        type=discord.ChannelType.text,
    )

    # only listens in bot and review channels
    if not (channel_name in BOT_CHANNELS or channel_name in REVIEW_CHANNELS):
        return

    # help command
    if message.content == "!help":
        reply = print_help()
        await channel.send(reply)
        return

    # version command
    if message.content == "!version":
        reply = print_version()
        await channel.send(reply)
        return

    # self
    if message.author == client.user:
        # add status reactions to own messages
        await add_status_reactions(message, message.content)
        return

    supported_urls = url_parser.extract_supported_urls(message.content)

    for url in supported_urls:
        reply = "<" + url + ">" + "\n"

        try:
            # setup/reset reporter
            reporter.setup()
            # get paste
            r = requests.get(url)
            r.raise_for_status()
            paste = r.text
        except:
            traceback.print_exc()
            reply += reporter.print_report("fail", "Failed to get paste")
        else:
            try:
                (bdinfo, mediainfo, eac3to) = paste_parser.parse(paste)
            except:
                traceback.print_exc()
                reply += reporter.print_report("fail", "Paste parser failed")
            else:
                if mediainfo:
                    try:
                        # parse mediainfo
                        mediainfo = mediainfo_parser.parse(mediainfo)
                    except:
                        traceback.print_exc()
                        reply += reporter.print_report(
                            "fail", "Mediainfo parser failed"
                        )
                    else:
                        try:
                            # setup checker
                            checker.setup(bdinfo, mediainfo, eac3to, channel_name)
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
                                reply += reporter.print_report(
                                    "fail", "vdator failed to parse"
                                )
                else:
                    reply += reporter.print_report(
                        "error", "No mediainfo. Are you missing the `General` heading?"
                    )

        # report
        reply += "> **Report**\n"
        reply += reporter.display_report()

        # split into multiple messages based on reply length
        BLOCK_QUOTES = "```"
        len_limit = (
            int(os.environ.get("DISCORD_MSG_CHAR_LIMIT")) - len(BLOCK_QUOTES) * 2
        )
        replies = split_string(reply, len_limit, "\n")

        # preserve blockquotes
        for i, r in enumerate(replies):
            if i == len(replies) - 1:
                break
            if not balanced_blockquotes(r):
                replies[i] += BLOCK_QUOTES
                replies[i + 1] = BLOCK_QUOTES + replies[i + 1]

        # fix blockquotes
        for i, r in enumerate(replies):
            replies[i] = replies[i].replace("``````", "```")

        if channel_name in BOT_CHANNELS:
            # reply in bot channel
            for reply in replies:
                await channel.send(reply)
        elif channel_name in REVIEW_CHANNELS:
            # add reactions in review channel
            await add_status_reactions(message, reply)

            # and send reply to
            for ch in REVIEW_REPLY_CHANNELS:
                review_reply_channel = get(
                    message.guild.channels, name=ch, type=discord.ChannelType.text
                )
                for reply in replies:
                    await review_reply_channel.send(reply)


token = os.environ.get("DISCORD_BOT_SECRET")
client.run(token)
