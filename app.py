#!/usr/bin/env python3.8
import src.args as parseargs
import src.demux.action as demuxAction
import src.remux.action as remuxAction

def main()->None:
    args = parseargs.setParser()
    if args.command=="demux":
        demuxAction.demux(args)
    else:
        remuxAction.remux(args)
    


if __name__ == "__main__":   
    main()





