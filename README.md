<!-- START doctoc generated TOC please keep comment here to allow auto update -->
<!-- DON'T EDIT THIS SECTION, INSTEAD RE-RUN doctoc TO UPDATE -->
**Table of Contents**  *generated with [DocToc](https://github.com/thlorenz/doctoc)*

- [**How to Install/Get Started**](#how-to-installget-started)
  - [Linux:](#linux)
    - [Required](#required)
    - [Install](#install)
  - [Windows](#windows)
    - [Required](#required-1)
    - [Install](#install-1)
  - [General virtualenv Guide](#general-virtualenv-guide)
  - [Optional Upgrades](#optional-upgrades)
    - [mkvmerge:](#mkvmerge)
    - [wine](#wine)
    - [eac3to](#eac3to)
    - [suprip](#suprip)
    - [bdinfo](#bdinfo)
    - [BDSup2Sub](#bdsup2sub)
  - [Recommended Software](#recommended-software)
    - [Udevil](#udevil)
    - [Installing Tesseract](#installing-tesseract)
- [Before Running The Program](#before-running-the-program)
  - [Activating Virtual Env](#activating-virtual-env)
    - [Windows](#windows-1)
    - [Linux](#linux)
- [Demuxing Files](#demuxing-files)
  - [Commands](#commands)
    - [Required](#required-2)
    - [Optional](#optional)
  - [TV Option](#tv-option)
    - [Running Structure](#running-structure)
    - [Picking Playlist/Batches](#picking-playlistbatches)
    - [Restoring Data](#restoring-data)
    - [Folder Struture](#folder-struture)
      - [Home Folder](#home-folder)
    - [Inside Directory 1](#inside-directory-1)
    - [Inside ahmybudda folder](#inside-ahmybudda-folder)
    - [Output_logs](#output_logs)
    - [SubImages folder](#subimages-folder)
  - [Movies Option](#movies-option)
    - [Running Structure](#running-structure-1)
    - [Folder Structure](#folder-structure)
      - [Home Folder](#home-folder-1)
      - [Inside ahmybudda folder](#inside-ahmybudda-folder-1)
      - [Output_logs](#output_logs-1)
      - [SubImages folder](#subimages-folder-1)
- [Remuxing MKV](#remuxing-mkv)
  - [commands](#commands)
    - [Required](#required-3)
    - [Optional](#optional-1)
  - [TV Option](#tv-option-1)
  - [Movie Option](#movie-option)
- [JSON](#json)
  - [Overview](#overview)
  - [Examples](#examples)
    - [Movie](#movie)
    - [TV](#tv)
  - [Sections](#sections)
    - [1. Movie](#1-movie)
    - [2. Sources](#2-sources)
        - [Source subsections](#source-subsections)
    - [3. ChapterData](#3-chapterdata)
    - [4. Enabled Tracks](#4-enabled-tracks)
      - [Enabled Tracks subsection](#enabled-tracks-subsection)
    - [5. Track Details](#5-track-details)
      - [Keys](#keys)
        - [Audio Keys](#audio-keys)
        - [Sub Keys](#sub-keys)
- [Default Enabled Tracks](#default-enabled-tracks)
  - [Normal Audio Track](#normal-audio-track)
    - [The first thing you must know is that tracks are enabled based on either](#the-first-thing-you-must-know-is-that-tracks-are-enabled-based-on-either)
    - [Priority of Tracks](#priority-of-tracks)
    - [How many Tracks for each language are added?](#how-many-tracks-for-each-language-are-added)
    - [In What order are valid Tracks added?](#in-what-order-are-valid-tracks-added)
    - [Special cases](#special-cases)
    - [AnimeBytes](#animebytes)
    - [BeyondHD](#beyondhd)
    - [Blutopia](#blutopia)
  - [Compatablitly Track](#compatablitly-track)
    - [What Tracks are Checked](#what-tracks-are-checked)
    - [Insertion Order](#insertion-order)
  - [Subs](#subs)
    - [The first thing you must know is that tracks are enabled based on either](#the-first-thing-you-must-know-is-that-tracks-are-enabled-based-on-either-1)
    - [Priority of Tracks](#priority-of-tracks-1)
    - [How many Tracks for each language are added?](#how-many-tracks-for-each-language-are-added-1)
    - [In What order are Valid Tracks added?](#in-what-order-are-valid-tracks-added)
    - [Foreign Films](#foreign-films)
    - [AnimeBytes](#animebytes-1)
  - [Embedded Forced Subs](#embedded-forced-subs)
    - [What languages are check](#what-languages-are-check)
    - [If a forced Track is found embedded](#if-a-forced-track-is-found-embedded)
  - [Video Track](#video-track)
    - [What Track is added](#what-track-is-added)
- [Updating Tracks For final mkv](#updating-tracks-for-final-mkv)
  - [Changing order of Tracks](#changing-order-of-tracks)
  - [Disabling Track](#disabling-track)
- [FileNames](#filenames)
  - [Animebytes](#animebytes)
  - [BeyondHD](#beyondhd-1)
  - [Blutopia](#blutopia-1)
- [Vdator](#vdator)
- [Machine Parse](#machine-parse)
  - [Subtitles](#subtitles)
  - [Video](#video)
  - [Optional: Disabling Tesseract for Non-Sudo OCR](#optional-disabling-tesseract-for-non-sudo-ocr)
- [Acknowledgement](#acknowledgement)

<!-- END doctoc generated TOC please keep comment here to allow auto update -->


# **How to Install/Get Started** 
Instructions are provided for Linux and Windows

Note: Windows is not fully supported at the moment
Modifications to the code are required to get it to work on that platform

## Linux: 
### Required
  * python
  * mono
### Install
* python3 -m pip install --user virtualenv
* python3 -m venv env
* source env/bin/activate
* which python -> should be the virtualenv
* pip3 install -r requirements.txt
* deactivate -> Do this after installing the requirements

## Windows
Note: Windows is not yet ready. However, I think the programs maybe 95 percent of the way ready for windows. You could possible make the modifications needed. Alternatively wait until I am able to do it myself
### Required
  * python
### Install
* py -m pip install --user virtualenv
* py -m venv env
* .\env\Scripts\activate
* which python -> should be the virtualenv
* py -m pip install -r requirements.txt
* deactivate -> Do this after installing the requirements

## General virtualenv Guide

General Guide: https://packaging.python.org/en/latest/guides/installing-using-pip-and-virtual-environments/


## Optional Upgrades

These binaries are included but you are free to use newer versions/your own if desired

see config.py "*LinuxPath" for file paths. 

### mkvmerge:

* https://mkvtoolnix.download/downloads.html#ubuntu * Provides multiple ways to install mkvmerge: including via building yourself or package manager
### wine

* https://github.com/Kron4ek/Wine-Builds * install wine without sudo
* https://wiki.winehq.org/Download -build wine yourself, or install using a package manager
### eac3to
* https://www.videohelp.com/software/eac3to -You can find updates here

### suprip
* https://www.videohelp.com/software/SupRip * Updates are here, has not been updated in a while

### bdinfo 
* https://github.com/zoffline/BDInfoCLI-ng * Update here, has not been updated in a while

### BDSup2Sub
* https://www.videohelp.com/software/BDSup2Sub * Updates here, has not been updated in a while




## Recommended Software

### Udevil
Typically mounting provides the best results when trying to extract an ISO. However, it usually requires sudo access. udevil will allow files to be "mounted" without the need for sudo access
https://github.com/IgnorantGuru/spacefm/wiki/Distros * it is mixed in with spacefm, make sure to only get udevil

### Installing Tesseract
Tesseract allows for many more languages to be ocr, but it does require sudo
and requires packages on the system
The easiest way would just be to follow the instructions in this repo

https://github.com/sirfz/tesserocr * requires sudo to install



# Before Running The Program

## Activating Virtual Env
### Windows
* source env/bin/activate
### Linux
* .\env\Scripts\activate



# Demuxing Files
This mode allows the user to pick multiple BDMV/ISO(with udevil).
For each source, it will do the following
* Extract every track for that source
* Search and extract any embedded forced subs for main, and secondary movie language
* Search and extract compatibility tracks 
* Generate and save the bdinfo log
* Save eac3to log

When all sources are extracted. The data is then saved to a file called output.json. The user can then update the JSON before running remux mode
## Commands
python3 /path/to/app.py -demux sourcepath outputpath [optional args]

### Required


sourcepath 
``` 
 where you keep all your bdmv and or iso files.
 You can pick multiple sources if you desire, just make sure they are all for the same movie/TV Episode
```

 outputpath [default=current dir]
```
  Where you want the mux folder to be output to. A Folder with the following structure will be created
  Mux.randomstring.showName
```


### Optional
--site [default=blu]
```
Example: python3 /path/to/app.py -demux sourcepath outputpath --site blu

This argument makes small changes in potentially any area of the demux process. The goal is to better account for differences in site rules when it comes to demuxes.
Some differences could be
* Order of Tracks
* Track Names
* Which Tracks or languages are Included by default
For More Details on Different Sites and their effects on The final Output Please Read the Site Section
see  Enabled Tracks Sorting/Filtering and sites sections
```
 --sortpref  [default=size]
```
Example: python3 /path/to/app.py -demux sourcepath outputpath --sortpref size
 options: size or order
size: sort tracks by which track is largest. Give the highest priority to largest track
order: sort tracks by which comes first, give the highest priority to first tracks

```
 --audiolang
```
 Example:python3 /path/to/app.py -demux sourcepath outputpath --audiolang english japanese
 
 Which Track Language(s) you want to enable for the current demux.
 This only affects what tracks will be added in the enabled audio tracks section. When creating the JSON file. Every track is extracted 
 regardless of this setting
 ```
  --sublang 
 ```

 Example:python3 /path/to/app.py sourcepath outputpath -demux --sublang english japanese

 Which Track Language(s) you want to enable for the current demux.
 This only affects what tracks will be added in the enabled sub-tracks section. When creating the JSON file. Every track is extracted 
 regardless of this setting
```

 --ocr 
```
    Example: python3 /path/to/app.py -demux sourcepath outputpath --ocr enabled

   Generates human-readable text of the sup files. 
   Not all tracks have to be ocr, which ones depend on the argument you pass to this command
   
  choices ->  enabled, sublang,default,all,disabled,english
  
  enabled: OCR enabled tracks i.e tracks that auto-enabled during demux process. See filtering for more details
  sublangs: OCR the same languages you set for sublangs
  default: OCR using the languages from IMDB
  all: OCR every single language
  english: OCR english only
```


 --voicerec 
```
    Example: python3 /path/to/app.py -demux sourcepath outputpath --voicerec enabled

   Generates human-readable text of the audio files. Not all tracks have to be transcribed, which ones depend on the argument you pass to the command. 
   
  choices ->  enabled, audiolang,default,all,disabled,english
  
  enabled: Use Voice rec on enabled records i.e tracks that are auto-enabled during demux process. See filtering for more details 
  sublangs: Use voice rec on the same languages you set for audiolangs
  default: Use voice rec on the languages from IMDB
  all: Use voice rec on every single language
  english: voice rec english only
```


 --keepocr
```
    Example: python3 /path/to/app.py -demux sourcepath outputpath --ocr enabled --keepocr

    During ocr process images are saved to a temporary folder. Then the images are processed using one of the ocr engines. This option moves the files to a permanent location in the output Mux folder. You can keep the images and skip the ocr step, by passing --keepocr without the --ocr argument 


```

 --splitplaylist
 
 ```
    Example: python3 /path/to/app.py -demux sourcepath outputpath --splitplaylist inf

   This Mode only has an effect in TV option, during demuxing. 
   Instead of sending a playlist to eac3to. This will split a playlist into its individual streams, and send those to eac3to.
   So each stream will be it's on episode or folder in the final Mux Folder.
   
   For example BDINFO might show a playlist 0001.mpls with these Files 0002.mt2s 0004.mt2s 0008.mt2s
   Normally this would be one folder represented by the playlist, with splitplaylist now each of those streams would be represented by one 
   folder
   Note you must provide a minumimum length for playlist
   If you set the value to zero or inf, then all streams will be accepted regardless of length
   Note: This mode only accepts one source currently
```

 --dontconvert
 
 ```
    Example: python3 /path/to/app.py -demux sourcepath outputpath --donconvert

   Skips all lossless conversions
```


## TV Option
During the demux process you will be asked "What Type of Media are you Demuxing?". 
To Demux a TV show select TV here

This option will prompt the user once to gather media ids from mal,tmdb,imdb,etc.
Then it will utilize that information to create multiple JSON. Each JSON corresponds to a different playlist, and a different episode with a TV show.

If you are demuxing TV shows it is recommended to add the --keepocr command, as that can make it easier to identifiy episodes. It is common for the playlist order not to match exactly with the actual episode order

### Running Structure
1. Pick Sources
2. Pick Playlist
3. Extract Files into subfolders
4. Multiple Options
    * Continue Program 
      * Pick New Sources/Keep Same Sources as before
      * Go Back to Step 2
    * Quit

### Picking Playlist/Batches
Each Time you are prompted to pick playlist. All sources must have the same number of playlist.

For example if I have two source I can pick  
```
First Iteration

Source1 Playlist: 1-3,10
Source2  Playlist: 5-8,12
```
Not

```
First Iteration

Source1 Playlist: 1-5,10
Source2  Playlist: 5-8,12
```

It is possible to take advantage of the program running multiple times to create more advance use of multiple sources 

```
First Iteration

Source1 Playlist: 1-3
Source2  Playlist: 5-8

Second Iteration
Source 1 Playlist:4-5

Third iteration
Source 1 Playlist:10
Source 2 Playlist:12

```
### Restoring Data
If you want to continue a past Demux Process 
Selecting the TV option provides a prompt to restore old data

If no valid folders are found, the program will create a new one.


### Folder Struture
#### Home Folder

<img src=https://user-images.githubusercontent.com/80348218/180505703-19666c95-235a-451f-a746-139f0459749c.png width=500><img/>

### Inside Directory 1

<img src=https://user-images.githubusercontent.com/80348218/180505738-3098aae2-98f1-4bff-b6c1-535be0995b63.png width=500><img/>

### Inside ahmybudda folder

<img src=https://user-images.githubusercontent.com/80348218/180505781-c7ebb2ae-a278-435f-a470-c5031a6593eb.png width=500><img/>

### Output_logs

<img src=https://user-images.githubusercontent.com/80348218/180505811-44195aaf-325a-4bfb-ba22-dd650fba60c8.png width=500><img/>

### SubImages folder

<img src=https://user-images.githubusercontent.com/80348218/180524253-4f522b0f-81cb-48e4-af8c-bf36ecb420a4.png width=500><img/>




## Movies Option

During the demux process you will be asked "What Type of Media are you Demuxing?". 
To Demux a Movie select Movie here

### Running Structure
1. Pick Sources
2. Pick PlayList
3. Extract Tracks
4. Program Quits

### Folder Structure
Similar to the TV option folder Structure
However, the numbered subfolders are not present

#### Home Folder

<img src=https://user-images.githubusercontent.com/80348218/180505738-3098aae2-98f1-4bff-b6c1-535be0995b63.png width=500><img/>

#### Inside ahmybudda folder

<img src=https://user-images.githubusercontent.com/80348218/180505781-c7ebb2ae-a278-435f-a470-c5031a6593eb.png width=500><img/>

#### Output_logs

<img src=https://user-images.githubusercontent.com/80348218/180505811-44195aaf-325a-4bfb-ba22-dd650fba60c8.png width=500><img/>

#### SubImages folder

<img src=https://user-images.githubusercontent.com/80348218/180524253-4f522b0f-81cb-48e4-af8c-bf36ecb420a4.png width=500><img/>


# Remuxing MKV

This mode creates an mkv file via mkvmerge by utilizing the tracks extracted in demux mode.
It then reads the JSON file to figure out
* What Tracks to pass to mkvmerge
* Flags to add to those tracks
* What language to set tracks to
* The title that the tracks should have, if at all
* Reads JSON file. Uses the data to create a remux based on data extracted from the file.

The final .mkv filename is determined by the status of the --site argument



## commands

* python3 /path/to/app.py demux sourcepath output [optional args]



### Required
```

sourcepath 
 The mux folder created during the demux process
 This holds all your configurations and is what will be used to generate the mkv file
```

outputpath [default=current dir]
``` 
  The folder you want the final MKV to be outputted to
```
### Optional
--site blutopia/blu/bhd/beyondhd [default=blu]
```
Example:python3 /path/to/app.py "remux" --site blutopia

This will Effect mainly affect the final track name
See Sites Section for more detail
```

--group [default=Unknown]
```
Example:python3 /path/to/app.py remux --group superduperremuxing

This will change the group tag of the final MKV
```

--forcemovie
```
Example:python3 /path/to/app.py remux --forcemovie

overwrites TV Movies by treating them as a movie, instead of a TV show
```




--outargs
```
Example:python3 /path/to/app.py remux --outargs "--split chapters:13,22,33,45,54"

Passes mkvtoolnix global options to the final mkvtoolnix command
Read the global option section here: https://mkvtoolnix.download/doc/mkvmerge.html#mkvmerge.description
```
--skipnamecheck
```
Example:python3 /path/to/app.py remux --skipnamecheck

Skip confirmation of filenames
```

## TV Option
During the remux process you will be asked "What Type of Media are you Remuxing?". 
To Remux a TV show select TV here

* This Will select all Mux Folders that contain data for TV shows
* You will be able to select which JSONs you want to create a MKV for. Inside of your Mux Folder selection
* Each JSON will output to the same directory
* Program will create MVK using JSON, After Confirming the final name of every f

## Movie Option
During the remux process you will be asked "What Type of Media are you Remuxing?". 
To Remux a Movie select Movie here

* This will select all Mux Folders that contain data for movies
* Program will then create MKV using JSON, afer confirming the final file name
ile




# JSON
## Overview

The JSON is output when you use the "demux" argument. This Provides lots of details on all the tracks and sources used during the run of the program. Some of the information is auto-filled, and the user can change the values if desired. Depending on what you change the settings to that will affect the final mkv produce


## Examples

### Movie
https://0.xwem.com/?b3791a91929e6b38#He4TbTYS4a4yVAik6fkBtNfNviXb1NBC2BC86Bd7EwFi


### TV
https://0.xwem.com/?be82537624a327c6#8aW8WEmFUYbxxjR4Pknf7s52GqpzAe6xcyMPdsw3LaTv


## Sections
### 1. Movie
Data about the movie or TV show
For TV shows use OCR/ subimages to confirm episode number

Changing any of these settings, other than langs will have an effect on "remux" mode
langs data is present only for convenience

#### Keys

* imdb: imdb ID for Movie/TV show
* tmdb: themoviedb ID for Movie/TV show
* langs: Offical Languages for movie or TV show
* season: if TV show the season
* episode: If TV show the episode number
* title: The title of the show
* mal_id: myanimelist id for the show, only applies to anime
* enTitle: only applies to anime, the english title of show
* japTitle: only applies to anime, the japanese title of the show
* anisearch: only applies to anime, animesesarch for the show
* anidb: only applies to anime, animedb id for the show
* kitsu: only applies to anime, kitsu id for the show


### 2. Sources

Basic data about the sources the user has utilized during the demuxing process.
Each source has its own key with data inside of it

Most of these values should not be changed 
As Changing values could cause "remux" mode to crash if they don't match

 ##### Source subsections
* outputDir: the location of the output files for the source i.e the mux folder location
* sourceDir: The location of where the source is found
* playlistNum: What Number was entered as a response to the question "What playlist" during the demux process
* playlistFile: The playlist file the playlist number corresponds with
* streamFiles: All the mt2s streams the JSON matches with. Will either match with BDINFO, or be one stream if --splitplaylist is on
* length: The Length of all the streamFiles combined

### 3. ChapterData

This section has information about when the chapters
Changing Value here will affect the chapters in the final mkv in "remux" mode

* time: when the chapter occurs
* name: What name to give the Chapter


### 4. Enabled Tracks

Displays which Tracks will be added during the mkvmerge Process. To see more details about a track match the string here to the Track Details Sections.
The demux Process will auto-add tracks to this section

#### Enabled Tracks subsections
* Video: All the video Tracks to enable 
* Sub: All the subtitle Tracks to enable 
* Audio: All the audio Tracks to enable 



### 5. Track Details


This section holds some Details about Each Track

The track has a hashed key. The hash is made using the source information and track title, and just in case the track index. It should be unique to each track and will stay the same. If you use the same source again.

Changing some values will have "no effect" on the final mkv produced in "remux" mode.

#### Keys
* langcode: [string:2 char] used by mkvmerge to set track language. This is used to set the track language in "remux" mode
* lang:  [string] Translation of langcode to the actual language. This is for convenience, and has no effect on "remux" mode
* site_title: [string] used to set title for mediainfo, set to None for no title. This will affect "remux" mode
* bdinfo_title: [string] just the title from bdinfo, changing this value has no effect
* index: [number] the track number. Video is usually 1. Next audio tracks, lastly subs. Changing this value has no effect
* eac30: [special syntax string] u just some info about the file extract by eac3to. Changing this value has no effect
* file: [filepath] location of the file on the system. This is the relative path, from the MuxFolder. This way you can change the folders location
* compat: [bool] u Used for embedded tracks i.e dolby digital inside true hd
These are extracted automatically. Changing this value has no effect
* parent: [string] what track an embedded track was extracted from. changing this value has no effect
* child: [string] embedded track if present. changing this value has no effect
* machine_parse: [list] if using ocr or voice rec. The gathered values will be here. See machine_parse or demux sections for more details
* length: [number] will display how long, and how many subs a track has. Changing this value has no effect
* default: [bool] whether to set the default flag in mkv.
* forced: [bool] whether to set the forced flag. Also can be set by changing the site_title to include "forced" 
* sourceDir: [filepath] The original location of the bdmv used to extract track, This should not be changed as it is used during the "remux" process
* sourceKey: [string] the key of the source in the JSON that the track is tied to, This should not be changed as it is used during the "remux" process
* type: [string] whether this is an audio, video, sub-track. This value should not be changed as it is used during the "remux" process
*  commentary: [bool]  Sets the Commentary flag to yes. Should be used for all audio and subtitle tracks that are commentary
* auditorydesc:[bool]  Turn on for tracks that include auditory descriptions, sets the Visual impaired flag. Applies only to audio tracks
* original: [bool]  Turn on for tracks in the movies original language,set the Original language flag. Applies only to audio tracks
* sdh:[bool]  Turns on the Hearing impaired flag. Applies only to sub tracks
* textdesc: [bool] For subtitle tracks with text-based descriptions for the visually impaired that can be read via a screen reader.  Applies only to sub tracks

# Default Enabled Tracks
## Normal Audio Track
Here I will explain how audio tracks are added to the enabled audio tracks section in the Final JSON

### The first thing you must know is that tracks are enabled based on either
* The --audiolang argument
* If that is not passed then the lang of the movie, this is retrieved through IMDB data
* If English is not part of the IMDB data, then it will be appended as the last language
* To completely disable English, you will need to pass --audiolang argument

### Priority of Tracks
* Tracks are either given priority by size(default) or by order in the sources
* to change sorting/priority you can use --sortpref argument during demux

### How many Tracks for each language are added?
* Currently only the first track for each language will be added. This is the track with the highest priority.
* An exception is made for English Tracks, every English track is added. They are however, added in order of priority

### In What order are valid Tracks added?
* They are added in the order produced by IMDB if --audiolang argument is not passed
* Alternatively they are added in the order provided by --audiolang argument
### Special cases
* Every lossless mono or stereo track is converted into FLAC


### AnimeBytes
Currently, the main difference is that Japanese and English are default audio languages, even if IMDB only list Japanese as the language of the TV/Movie

This is to ensure the production of Dual Audio 

### BeyondHD
Every lossless mono or stereo Track will be converted to FLAC

### Blutopia

Blutopia will check for padding using conversion to FLAC. If padding is found then the FLAC audio will be used in replacement of the original codec. This only applies to 24bit tracks

Every lossless mono or stereo Track will be converted to FLAC
## Compatibility Track
This will extract embedded Tracks from TrueHD tracks
### What Tracks are Checked
* Audio tracks that were added to the enabled audio list, and that are TrueHD Tracks

###  Insertion Order
* The new Track is inserted right after the track it was extracted from


## Subs
Here I will explain how subs are added to the enabled sub section in the final JSON
### The first thing you must know is that tracks are enabled based on either
* The --sublang argument
* If that argument is not passed then every language will be added
### Priority of Tracks
* Tracks are either given priority based on the order of the Subtitle in sources

### How many Tracks for each language are added?
* Currently only the first track for each language will be added. This is the track with the highest priority.
* An exception is made for English Tracks, every English track is added. They are, however, added in order of priority

### In What order are Valid Tracks added?
* The order provided by the --sublang argument
* If that argument is not passed. First is all the  English subtitles,  then all other languages sorted a-z

### Foreign Films
* If the first audio Track is not English, i.e the movie is foreign
* Then the first English subtitle will be set as the default

### AnimeBytes
If no embedded force English track is found, a secondary search for a forced track will be done.

The first and second English sub-tracks will be compared. The smallest one is assumed to be forced, and this track will be set to default with the forced flag on.

## Embedded Forced Subs
This only applies to forced subs that need to be extracted from another track


### What languages are check
* Only a max of two languages will be checked.
* If the first language passed via --audiolang or in the IMDB is English then only English subtitles will be checked. 
* If the first language is not English via --audiolangs or IMDB, then that language will be checked  along with English
* All other languages will be ignored

### If a forced Track is found embedded

All the data from the old track will be copied to the forced sub-data.
* The title will be change
* The Track key will be changed
* The Track eac3to will be changed
* The Track File will be changed
* default flag turned on
* forced flag turned on 





If a forced track is found for the first language, 
* it is added as the first enabled audio tracks

if a forced track is found for the second language
* it is added to the end of the enabled sub list.

## Video Track

### What Track is added
* Only 1 video track is ever added and the one that is picked depends on --sortpref argument
* Either the largest or first video track will be added, default is adding the largest video file

# Updating Tracks for final mkv
Video Tracks always come first, next audio Tracks, lastly subtitle tracks
You change the order of the tracks within these three types
## Changing order of Tracks
* Go to the Track Details Section
* Go to the subsection that has the track your intersted in
* Find the Track, and copy its key 
* Go to the Enabled Tracks Section
* Go to the subsection for that contains the type of track you are interested in
* Put the Track's key in the order that you want it to appear


## Disabling Track
* Go to the Track Details Section
* Go to the subsection that has the track your intersted in
* Find the Track, and copy its key 
* Go to the Enabled Tracks Section
* Go to the subsection for that contains the type of track you are interested in
* Remove that Track's Key from the list

# MKV FileName(s)
During the remux process if you don't pass a site the filename will be
For TV shows
TV.Show.year.S0#.E0#.episode.title.resolution.BluRay.REMUX.AVC.TrueHD.audiochannels-group.mkv
For Movies
movie.year.resolution.BluRay.REMUX.AVC.TrueHD.audiochannels-group.mkv

## Animebytes
This will just follow the default naming for it's files

## BeyondHD
The output filename is based on beyondHD naming rules

## Blutopia
The output filename is based on Blutopia naming rules

# Vdator
To help with double checking that your torrent mets their requirements
A developer on blutopia has provided a validtor to check the final mkv. I have embedded this validator into the code, so if you pass the --blutopia site during the remux process the validator will be called.
It will provide feedback 


# Machine Parse

## Subtitles

Subtitles can be ocr with the --ocr command
This will run one of two ocr. The first is better but has fewer languages. 
The second is faster has lots of languages, but in my 
Experience does no ocr as well.

You can utilize this to identify what kind of track the sub is tied to. It should work for foreign tracks as well.

The program will generate temp images for every line in filtered subs.
Which subs are filtered to be processed depends on the --ocr command. By default it is set to None.
These images are then processed by one of the ocr engines 
Images are created for the entire subtitle

 
However,only the first 50 and last line will be ocr

To save the images retrieved to a permanent location use
--keepocr command 
The keepocr command does not require ocr command to work. The keepocr command by itself will skip the ocr step, and just take the images



This is very useful for identifying episode as sometimes the last sub-image may give a good clue. 

You can also use the output to identify dialects for specific languages i.e Spanish, French,etc

## Video
Video rec is not as good as ocr. But it can still kind of be used to ID tracks.
Use the --videorec command to use this feature. 
To save time it will only record about 50 lines worth of the track.

## Optional: Disabling Tesseract for Non-Sudo OCR
If you can't install tesseract and still want to ocr

* Go the project folder
* cd ./subtitles/
* open ocr.py 
* ctrl f "getocr_obj" 
* comment out
```
  try:
        return tesserocr.PyTessBaseAPI(path="/usr/share/tesseract-ocr/5/tessdata", lang=langcodes.Language.get(langcode).to_alpha3())
    except:
        None
    return None
```
* go to requirements.txt
* ctrl
* tesserocr
* Comment out that line entire line
now only easyocr will be used.



# Acknowledgement
https://github.com/werrpy/vdator: For blutopia validation code

