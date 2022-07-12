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

    parser.add_argument('-sl', '--sublang', nargs='?',default=[])
    parser.add_argument('-al', '--audiolang', nargs='?',default=[])
    parser.add_argument('-s', '--site', default="blu")
    parser.add_argument('-p', '--sortpref', default="size")
    args = parser.parse_args()
   
    if args.demux:
        os.chdir(args.outpath)
        demuxAction.Demux(args)

    if args.remux:
        remuxAction.Remux(args)

   
if __name__ == "__main__":
    main()


