#!/usr/bin/env python3.8
import args as parseargs
import demux.action as demuxAction
import remux.action as remuxAction

def main():
    args = parseargs.setParser()
    if args.command=="demux":
        demuxAction.demux(args)
    else:
        remuxAction.remux(args)
    


if __name__ == "__main__":   
    main()





