#!/usr/bin/env python3.8
import argparse
import os

import demux.demux as demuxAction
import remux.remux as remuxAction


def main():
    parser = argparse.ArgumentParser(prog='Remuxer', add_help=False)
    parser.add_argument('-s', '--site', required=False, default=None,
                        help="Customize Output based on this sites rules, and general content")
    parser.add_argument(
        '--log-level', default='INFO',
        help='logging level')
    subparsers = parser.add_subparsers(help='main positional commands')

    parser_d = subparsers.add_parser(
        'demux', help='Demux BDMV/ISO to Raw Files', parents=[parser])
    parser_d.add_argument('inpath', help="Location of BDMV/ISO Files")
    parser_d.add_argument('outpath', default=os.getcwd(),
                          help="Location Raw Files Folder Should be Created")
    parser_d.add_argument('-p', '--sortpref', default="size",
                          choices=["size", "order"], help="What Order to use to Rank Tracks")
    parser_d.add_argument('-sl', '--sublang', nargs='*',
                          default=[], help="Matches subtitles with these languages")
    parser_d.add_argument('-al', '--audiolang', nargs='*',
                          default=[], help="Matches audio with these languages")
    parser_d.add_argument(
        '-o', '--ocr', choices=['enabled', 'sublang', 'default', "all", "english"], help="OCR gracks outputs to JSON")
    parser_d.add_argument(
        '-v', '--voicerec', choices=['enabled', 'audiolang', 'default', "all", "english"], help="Transcribe tracks outputs to JSON")
    parser_d.add_argument('-k', '--keepocr', action='store_true', help="Take Screen Shot of specific Tracks\ndefaults to enabled tracks, \
    can be changed with --ocr")
    parser_d.add_argument('-dc', '--dontconvert',  action='store_true',
                          help="Don't convert any lossless track to FLAC")
    parser_d.add_argument('-sp', '--splitplaylist', action='store_true',
                          help="During TV Mode extract each mt2s as seperate episode")

    parser_r = subparsers.add_parser(
        'remux', help='Remux Raw files into mkv(s)', parents=[parser])
    parser_r.add_argument('inpath', help="Location of RawFiles and JSON File")
    parser_r.add_argument('outpath', default=os.getcwd(),
                          help="Location mkv(s) should be created")
    parser_r.add_argument('-sn', '--skipnamecheck',
                          action='store_true', help="Skip Verification of Filenames")
    parser_r.add_argument('-g', '--group', default="Unknown",
                          help="Change the Group Tag For Final mkv(s")
    parser_r.add_argument('-fm', '--forcemovie',  action='store_true',
                          help="Force the output mkv to use movie syntax")
    parser_r.add_argument('-oa', '--outargs', default="",
                          help="Pass mkvmerge global options")

    args = parser.parse_args()

    args = parser.parse_args()

    if args.demux:
        demuxAction.demux(args)

    elif args.remux:
        remuxAction.Remux(args)


if __name__ == "__main__":
    main()
