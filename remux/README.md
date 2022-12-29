---
description: Merge raw files into mkv(s)
---

# Remux



## Before Running The Program

### Activating Virtual Env

#### Windows

* source env/bin/activate

#### Linux

* .\env\Scripts\activate

## Remuxing

This mode creates an mkv file via mkvmerge by utilizing the tracks extracted in demux mode. It then reads the JSON file to figure out

* What Tracks to pass to mkvmerge
* Flags to add to those tracks
* What language to set tracks to
* The title that the tracks should have, if at all
* Reads JSON file. Uses the data to create a remux based on data extracted from the file.

The final .mkv filename is determined by the status of the --site argument

### commands

* python3 /path/to/app.py demux sourcepath output \[optional args]

#### Required

```
sourcepath 
 The mux folder created during the demux process
 This holds all your configurations and is what will be used to generate the mkv file
```

outputpath \[default=current dir]

```
  The folder you want the final MKV to be outputted to
```

#### Optional

\--site blutopia/blu/bhd/beyondhd \[default=None]

```
Example:python3 /path/to/app.py "remux" --site blutopia

This will mainly affect the final filename
```

\--group \[default=Unknown]

```
Example:python3 /path/to/app.py remux --group superduperremuxing

This will change the group tag of the final MKV
```

\--forcemovie

```
Example:python3 /path/to/app.py remux --forcemovie

overwrites TV Movies by treating them as a movie, instead of a TV show
```

\--outargs

```
Example:python3 /path/to/app.py remux --outargs "--split chapters:13,22,33,45,54"

Passes mkvtoolnix global options to the final mkvtoolnix command
Read the global option section here: https://mkvtoolnix.download/doc/mkvmerge.html#mkvmerge.description
```

\--skipnamecheck

```
Example:python3 /path/to/app.py remux --skipnamecheck

Skip confirmation of filenames
```

\--episodename

```
Example:python3 /path/to/app.py remux --episodename

Searches Wiki or TMDB for episode titles, adds to filename
```



###
