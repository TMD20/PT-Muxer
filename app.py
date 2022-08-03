#!/usr/bin/env python3.8
import argparse
import os

import demux.demux as demuxAction
import remux.remux as remuxAction


def main():
    parser = argparse.ArgumentParser()
    group = parser.add_argument_group("group")
    group.add_argument('inpath')
    group.add_argument('outpath', default=os.getcwd())

    mux = parser.add_mutually_exclusive_group()
    mux.add_argument('-d', '--demux', action='store_true')
    mux.add_argument('-r', '--remux', action='store_true')

    parser.add_argument('-sl', '--sublang', nargs='*', default=[])
    parser.add_argument('-al', '--audiolang', nargs='*', default=[])
    parser.add_argument('-s', '--site', default=None)
    parser.add_argument('-p', '--sortpref', default="size",
                        choices=["size", "order"])

    parser.add_argument(
        '-o', '--ocr', choices=['enabled', 'sublang', 'default', "all", "english"])
    parser.add_argument(
        '-v', '--voicerec', choices=['enabled', 'audiolang', 'default', "all", "english"])
    parser.add_argument('-k', '--keepocr', action='store_true')

    parser.add_argument('-g', '--group', default="Unknown")
    parser.add_argument('-kd', '--kind', choices=["Movie", "tv"])
    parser.add_argument('-dc', '--dontconvert',  action='store_true')
    parser.add_argument('-oa', '--outargs', default="")
    parser.add_argument('-sp', '--splitplaylist', action='store_true')

    parser.add_argument(
        '--log-level', default='INFO',
        help='logging level')

    args = parser.parse_args()

    if args.demux:
        demuxAction.demux(args)

    elif args.remux:
        remuxAction.Remux(args)


if __name__ == "__main__":
    main()
