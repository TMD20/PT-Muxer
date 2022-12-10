#!/usr/bin/env python3.8
import args as parseargs

def main():
    args = parseargs.setParser()
    args.func(args)


if __name__ == "__main__":   
    main()

 
