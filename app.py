#!/usr/bin/env python3.8
import argparse
import os




from tmdbv3api import TMDb, Movie, TV
from pymediainfo import MediaInfo
from pymediainfo import MediaInfo
import imdb



from simple_term_menu import TerminalMenu
from nested_lookup import nested_lookup
from prompt_toolkit import prompt as input
from prompt_toolkit.completion import WordCompleter
import humanize
import xmltodict

import demux.demux as demuxAction
import remux.remux as remuxAction





# ia = imdb.IMDb()
# movie = Movie()
# tv = TV()
# tmdb = TMDb()
# tmdb.api_key = 'f400773075f3800bb1c601f7f81f4b5e'


def main():
    parser = argparse.ArgumentParser()
    group = parser.add_argument_group("group")
    group.add_argument('path')
    group.add_argument('outpath', default=os.getcwd())

    mux = parser.add_mutually_exclusive_group()
    mux.add_argument('-d', '--demux', action='store_true')
    mux.add_argument('-r', '--remux', action='store_true')

    parser.add_argument('-sl', '--sublang', nargs='?')
    parser.add_argument('-al', '--audiolang', nargs='?')
    parser.add_argument('-s', '--site', default="beyondhd")
    parser.add_argument('-p', '--pref', default="largest")

    parser.add_argument('-u', '--useorder', action='store_true')
    args = parser.parse_args()
   
    if args.demux:
        demuxAction.Demux(args)

    if args.remux:
        remuxAction.Remux(args)

   
if __name__ == "__main__":
    main()


