---
description: config.py
---

# Advanced Config Options

## What it is

This file holds some universal configuration files. Unlike command args these settings don't have to, and mostly should not be change.

However their are some cases where you might want to change them for example preference, or if your /tmp folder can't hold large files

## Values

root\_dir  => Holds where the location of app.py. Changing will likely break code&#x20;

eac3toPath =>   path to eac3to. Can be change if you want to use your own eac3to binary

dgDemuxLinux=> Path to dgdemux on linux. Can be change if you want to use your own dgdemux binary&#x20;

dgDemuxWindow=> Path to dgdemux on Windows. Can be change if you want to use your own dgdemux binary&#x20;

winePath => Path to wine on linux. Can be change if you want to use your own wine binary&#x20;

javaPath => Path to java on linux. Can be change if you want to use your own java binary&#x20;

mkvMergeLinux => Path to mkvmerge on Linux, can be changed if using own binary

mkvMergeWindows => Path to mkvmerge on Windows, can be changed if using own binary

bdSupWindows => Path to bdsup2sub on Windows, can be changed if using own bdsup2sub binary

bdSupLinux => Path to bdsup2sub on Linux, can be changed if using own bdsup2sub binary

bdinfoLinux =>  Path to bdinfo on Linux, can be changed if using on bdinfo binary

bdinfoWindows =>  Path to bdinfo on Windows, can be changed if using on bdinfo binary

isoExtractLinux=Path to 7z onLinux, can be changed if using on 7z binary

isoExtractWindows => Path to 7z on Windows, can be changed if using on 7z binary

contyPath => path to conty, can be changed if using your own conty release

monoPath => path to mono, can be changed if using your own mono binary

subripPath=>path to SupRip.exe, can be changed if using own SupRip binary





DemuxPrefix=> String Used to identify demuxFolder

cacheDir =>  location of cache files; Mostly used for web request&#x20;

session =>  Uses Cachedir; should not be change&#x20;

tempFolder=> tempFolder for all temp processes; Default is system tempfolder&#x20;

tempPrefix=> Unique key used to id temp folders; Mainly used to filtter out which files to clean up

tempFolderCleanUpTime=>&#x20;

Prevents deletion of needed tempfolders, while also cleanup hanging tempfolders.&#x20;

i.e hard close event preventing proper deletion of temp folders for a run

Value is minimum age of folder in minutes

pythonPath =>  Path to python binary; defaults to binary used to run program; &#x20;

maxOCRLineCount => Max number of lines to OCR

maxVoiceLineCount => Max number of lines to generate with voicerec

