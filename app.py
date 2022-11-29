#!/usr/bin/env python3.8
import argparse
import os

import demux.action as demuxAction
import remux.remux as remuxAction



def demux(args):
    demuxAction.demux(args)


def remux(args):
    remuxAction.Remux(args)





def main():
    parser = argparse.ArgumentParser(prog='app.py', add_help=False)

    subparsers = parser.add_subparsers(help='main positional commands')
    subparsers.required=True
    subparsers.dest="Demux or Remux"


    parser_d = subparsers.add_parser(
        'demux', help='Demux BDMV/ISO to Raw Files')
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
    parser_d.add_argument('-sp', '--splitplaylist', type=float,
                          help="During TV Mode extract each mt2s as seperate episode")
    parser_d.add_argument('-ep', '--extractprogram',choices=["eac3to","dgdemux"],default="eac3to",required=False,
                          help="Which Program for extracting raw files")
    parser_d.set_defaults(func=demux)

    parser_r = subparsers.add_parser(
        'remux', help='Remux Raw files into mkv(s)')
    parser_r.add_argument('inpath', help="Location of RawFiles and JSON File")
    parser_r.add_argument('outpath', default=os.getcwd(),
                          help="Location mkv(s) should be created")
    parser_r.add_argument('-sn', '--skipnamecheck',
                          action='store_true', help="Skip Verification of Filenames")
    parser_r.add_argument('-g', '--group', default="Unknown",
                          help="Change the Group Tag For Final mkv(s")
    parser_r.add_argument('-fm', '--forcemovie',  action='store_true',
                          help="Force the output mkv to use movie syntax")
    parser_r.add_argument('-sp', '--special',  action='store_true',
                          help="TV Folder contains special-features")                          
    parser_r.add_argument('-oa', '--outargs', default="",
                          help="Pass mkvmerge global options")
    parser_r.set_defaults(func=remux)

    #This seems to be the only way to
    # A have positional arguments
    #Easily Apply some argumetns to all subgroups
    for pars in [parser_d, parser_r]:
        pars.add_argument('-s', '--site', required=False, default=None,
                          help="Customize Output based on this sites rules, and general content")
        pars.add_argument(
            '--log-level', default='INFO',
            help='logging level')

    args = parser.parse_args()
    args.func(args)


if __name__ == "__main__":
        main()
