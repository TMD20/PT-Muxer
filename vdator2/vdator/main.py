#!/usr/bin/env python3

import json, os
from dotenv import load_dotenv
import sys

# parsers
from helpers import balanced_blockquotes, split_string
from parsers import *
from source_detector import SourceDetector

from reporter import Reporter, add_status_reactions
from checker import Checker

# script location
__location__ = os.path.realpath(os.path.join(os.getcwd(), os.path.dirname(__file__)))

if len(sys.argv)<4:
    print("Not Enough args")
    quit()
media=sys.argv[1]
bdinfo=sys.argv[2]
eac3to=sys.argv[3]




bdinfo_parser = BDInfoParser()
paste_parser = PasteParser(bdinfo_parser)
mediainfo_parser = MediaInfoParser()

with open(os.path.join(__location__, "data/codecs.json")) as f:
    codecs = json.load(f)
    codecs_parser = CodecsParser(codecs)

source_detector = SourceDetector()
reporter = Reporter()
checker = Checker(codecs_parser, source_detector, reporter)

bdinfo, mediainfo, eac3to = paste_parser.parse(bdinfo, media, eac3to)

mediainfo = mediainfo_parser.parse(mediainfo)
reporter.setup()
checker.setup(bdinfo, mediainfo, eac3to)
print(checker.run_checks())







































