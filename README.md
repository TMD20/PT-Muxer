<!-- START doctoc generated TOC please keep comment here to allow auto update -->
<!-- DON'T EDIT THIS SECTION, INSTEAD RE-RUN doctoc TO UPDATE -->
**Table of Contents**  *generated with [DocToc](https://github.com/thlorenz/doctoc)*

- [**How to Install/Get Started**](#how-to-installget-started)
  - [Install](#install)
    - [Linux:](#linux)
    - [Windows](#windows)
  - [Optional Binaries](#optional-binaries)
    - [mkvmerge:](#mkvmerge)
    - [wine](#wine)
    - [eac3to](#eac3to)
    - [suprip](#suprip)
  - [bdinfo](#bdinfo)
  - [BDSup2Sub](#bdsup2sub)
  - [Recommended](#recommended)
    - [udevil](#udevil)
    - [Installing Tesseract](#installing-tesseract)
- [Modes:](#modes)
  - [Demux Mode](#demux-mode)
  - [Remux Mode:](#remux-mode)
- [JSON](#json)
  - [Overview](#overview)
  - [Examples](#examples)
    - [Movie](#movie)
    - [TV](#tv)
  - [Sections](#sections)
    - [1. Movie](#1-movie)
    - [2. Sources](#2-sources)
    - [3. ChapterData](#3-chapterdata)
    - [4. Enabled Tracks](#4-enabled-tracks)
    - [5. Track Details](#5-track-details)
- [Commands:](#commands)
  - [Demux Mode](#demux-mode-1)
    - [Required](#required-1)
    - [Optional](#optional)
    - [TV Mode](#tv-mode)
      - [Restore Data](#restore-data)
    - [Movie Mode](#movie-mode)
  - [Remux Mode](#remux-mode)
    - [Required](#required-2)
    - [Optional](#optional-1)
    - [Selecting Tracks](#selecting-tracks)
- [Machine Parse](#machine-parse)
  - [Subtitles](#subtitles)
  - [Video](#video)
  - [Optional:Disabling Tesseract (Non Sudo)](#optionaldisabling-tesseract-non-sudo)
- [Enabled Tracks Sorting/Filtering](#enabled-tracks-sortingfiltering)
  - [Normal Audio Track](#normal-audio-track)
  - [Compatablitly Track](#compatablitly-track)
  - [Subs](#subs)
  - [Embedded Forced Subs](#embedded-forced-subs)
  - [Video Track](#video-track)
- [Sites](#sites)
  - [Blutopia](#blutopia-1)
- [**Note**](#note)

<!-- END doctoc generated TOC please keep comment here to allow auto update -->

# **How to Install/Get Started** 
Instructions are provided for Linux and Windows

However windows is not fully supported at the moment. 
Modification to the code are required to get it to work on that platform

## Install
### Linux: 
#### Required
  * python
  * mono

python3 -m pip install --user virtualenv
python3 -m venv env
source env/bin/activate
which python -> should be the virtualenv
pip3 install-r requirements.txt
deactivate -> Do this after installing the requirements

### Windows
#### Required
  * python
py -m pip install --user virtualenv
py -m venv env
.\env\Scripts\activate
which python -> should be the virtualenv
py -m pip install -r requirements.txt
deactivate -> Do this after install the requirements

## General virtualenv Guide

General Guide: https://packaging.python.org/en/latest/guides/installing-using-pip-and-virtual-environments/



## Optional Binaries

These binaries are included but you are free to use newer versions if desired

see config.py "*LinuxPath"for filepaths. 

### mkvmerge:

* https://mkvtoolnix.download/downloads.html#ubuntu - Provides multiple ways to install mkvmerge: including via building yourself or package manager
### wine

* https://github.com/Kron4ek/Wine-Builds - install wine without sudo
* https://wiki.winehq.org/Download -build wine yourself, or install using package manager
### eac3to
* https://www.videohelp.com/software/eac3to - You can find updates here or use custom versions made by users

### suprip
* https://www.videohelp.com/software/SupRip - Updates are here, has not been updated in a while

## bdinfo 
* https://github.com/zoffline/BDInfoCLI-ng - Update here, has not be updated in a while

## BDSup2Sub
* https://www.videohelp.com/software/BDSup2Sub - Updates here, has not be updated in a while




## Recommended

### Udevil
Typically mounting provides the best results when trying to extract an ISO. However it usually requires sudo access. udevil will allow files to be "mounted" without the need for sudo access
https://github.com/IgnorantGuru/spacefm/wiki/Distros - it mixed in with spacefm, make sure to only get udevil

### Installing Tesseract
Tesseract allows for many more languages to be ocr, but it does require sudo
and requires packages on the system
The easiest way would just be to follow the instructions in this repo

https://github.com/sirfz/tesserocr
This will require sudo

# Modes: 

## Demux Mode

Creates a mux folder with everything generated during the programs run
* Including all tracks from all sources, Extracted via eac3to
* BDINFO File for all Sources
* Eac3to Log for all Sources
* General Output.txt JSON file with Configurable Options

## Remux Mode: 

* Reads JSON file. Uses the data to create a remix based on data extracted from file. User can change the title of the final mkv by passing the --site argument.

# JSON

## Overview

The JSON is outputed when you use the --demux argument. This Provides lots of details on all the tracks and sources used during the run of the program. Some of the information is autofilled, and the user can change the values if desired. Depending on what you change the settings to that will effect the final mkv produce


## Examples

### Movie
https://0.xwem.com/?b3791a91929e6b38#He4TbTYS4a4yVAik6fkBtNfNviXb1NBC2BC86Bd7EwFi


### TV
https://0.xwem.com/?be82537624a327c6#8aW8WEmFUYbxxjR4Pknf7s52GqpzAe6xcyMPdsw3LaTv


## Sections
### 1. Movie
Data about the movie or TV show
For TV show or Movie use OCR/ subimages to confirm episode number

* imdb: ID for Movie/TV show
* tmdb: ID for Movie/TV show
* langs: Offical Languages for movie or TV show
* Season: if TV show the season
* Episode: If TV show the episode number
*

### 2. Sources

Just Basic Data data about the sources the user has utilize during the demuxing process. Most Likely shouldn’t be change
Each source has its own key here with some data inside of it

#### Keys

#### Source Dictionary
* Each Source has it own dictionary
* The section is marked by a  source directory base path key /home/main/test would have a key of test
  
 ##### Source Dictionary Key
* outputDir: the location of the output files for the source i.e the mux folder location
* sourceDir: The location of where the source is found
* playlistNum: What Number was entered as a response to the question "What playlist" during the demux process


### 3. ChapterData

This section has information about when the chapters

* time: when the chapter occurs
* name: What name to give the Chapter


### 4. Enabled Tracks

Displays which Tracks will be added during the mkvmerge Process. To See more details about a track match the number to the here to the Track Details Sections.
The demux Process will auto add tracks to this section

#### Keys
Each Key has a list of Ids
* Video: All the video Tracks to enable 
* Sub: All the subtitle Tracks to enable 
* Audio: All the audio Tracks to enable 

#### Changing order of Tracks
Just change the order of the track in the list

#### Disable Track
Just remove a track from the list


### 5. Track Details


Some Details about Each Track
Including Language. 

Each track has a hashed key. The hash is made using the source information and track title, and just in case the track index. It should be unique to each track and will stay the same 

If you use the same source again. Inside each track key you'll see some more data, that I will explain below.

#### Keys
* langcode: used by mkvmerge to set track language
* lang: Translation of langcode to the actual language
* site_title: used to set title for mediainfo, set to None for no title
* bdinfo_title: just the title from bdinfo
* index: the track number. Video is usually 1. Next audio tracks, lastly subs
* eac30: just some info about the file extract by eacto
* file: location of the file on the system
* compat: Used for embedded tracks i.e dolby digital inside true hd
These are extracted automatically.
* parent: what track a embedded track was extracted from
* child: embedded track if present
* machine_parse: if using ocr or voice rec. The gathered values will be here. See machine_parse or demux sections for more details
* length: will display how long, how many subs a track has
* default: whether to set the default flag in mkv
* forced: whether to set the forced flag. Also can be set by changing the site_title to including "forced" 
* sourceDir: The original location of the bdmv used to extract track
* sourceKey: the key of the source in the json that the track is tied to
* type: whether this is a audio, video, sub track
   

# Commands:

## Demux Mode
python3 /path/to/app.py -demux sourcepath outputpath [optional args]

### Required

```
 sourcepath 
 
 where you keep all your bdmv and or iso files.
 You can pick multiple sources if you desire, just make sure they are all for the same movie
```


```
  outputpath
 
  Where you want the mux folder to be outputed to. A Folder with the following struture will be created
  Mux.randomstring.showName
```


### Optional
--site blutopia/blu/bhd/beyondhd [default=blu]
```
Example: python3 /path/to/app.py -demux sourcepath outputpath --site blu

This will Effect
* Order of Tracks
* Track Names
* Which Tracks are Included by default
* ETC
For More Details on Different Sites and their effects on The final Output Please Read the Site Section
see Filtering Tracks section
```
 --sortpref  [default=size]
```
Example: python3 /path/to/app.py -demux sourcepath outputpath --sortpref size
 options: size or order
size: sort tracks by which track is largest. Give highest priority to largest track
order: sort tracks by which comes first, give highest priority to first tracks

```
 --audiolang
```
 Example:python3 /path/to/app.py -demux sourcepath outputpath --audiolang english japanese
 
 Which Track Language(s) you want to enable for the current demux
 Note all tracks are extracted and saved. This will remove non-matching tracks from the enabled audio   tracks list
 
 This will overwrite any site configuraton in terms of audio prefernece 
```
  --sublang 
 ```

 Example:python3 /path/to/app.py sourcepath outputpath -demux --sublang english japanese
 
 Which Track Language(s) you want to enable for the current demux
 Note all tracks are extracted and saved. This will remove non-matching tracks from the enabled sub  tracks list
 
 This will overwrite any site configuraton in terms of sub prefernece 
```

 --ocr 
```
    Example: python3 /path/to/app.py -demux sourcepath outputpath --ocr enabled
   Generates machine readable text of the sup files. 
   
  choices ->  enabled, sublang,default,all,disabled,english
  
  enabled: Just ocr enabled tracks i.e tracks that autoenabled during demux process. See filtering for more details
  sublangs: OCR the same languages you set for sublangs
  default: OCR using the languages from imdb
  all: OCR every single language
  english: OCR english only
```


 --voicerec 
```
    Example: python3 /path/to/app.py -demux sourcepath outputpath --voicerec enabled
   Generates machine readable text of the audio files. 
   
  choices ->  enabled, audiolang,default,all,disabled,english
  
  enabled: Just use voicerec enabled tracks i.e tracks that autoenabled during demux process. See filtering for more details 
  sublangs:Use voice rec on the same languages you set for audiolangs
  default: Use voice rec on the languages from imdb
  all: Use voice rec on every single language
  english: voice rec english only
```


 --keepocr
```
    Example: python3 /path/to/app.py -demux sourcepath outputpath --ocr enabled --keepocr
    During ocr images are saved to a temporory drive, this option moves the files to a permanant location in the output Mux folder.

```


### TV Mode

Selected during demux via questionarre

Specifically the  "What Type of Media are you Demuxing? Question

#### Episode Data
* Season number is entered once at the the beginning of the program
* Episode Number, this is assumed by the number if folders in the home directory, see... folder struture to see more details
* imdb data: This can be entered manually or by clicking on one of the options that appear 
* tmdb: converted via imdb number

#### Sources
You can utilize one or more sources per episode

After a episode finishes extracting, you can utilize the same or different sources for the next episode i.e for example a Season can be split across many disk

#### Folder Struture
##### Home Folder

<img src=https://user-images.githubusercontent.com/80348218/180505703-19666c95-235a-451f-a746-139f0459749c.png width=500><img/>

##### Inside Directory 1

<img src=https://user-images.githubusercontent.com/80348218/180505738-3098aae2-98f1-4bff-b6c1-535be0995b63.png width=500><img/>

##### Inside ahmybudda folder

<img src=https://user-images.githubusercontent.com/80348218/180505781-c7ebb2ae-a278-435f-a470-c5031a6593eb.png width=500><img/>

##### Output_logs

<img src=https://user-images.githubusercontent.com/80348218/180505811-44195aaf-325a-4bfb-ba22-dd650fba60c8.png width=500><img/>

##### SubImages folder

<img src=https://user-images.githubusercontent.com/80348218/180524253-4f522b0f-81cb-48e4-af8c-bf36ecb420a4.png width=500><img/>


#### Restore Data

For a TV mode demux that is partially stopped you can restore the data during the run of the program

Be careful as movie and TV mode folders will be selectable, and selecting a movie mode folder may lead to undesirable outcomes 


### Movie Mode

Selected during demux via questionarre

Specifically the  "What Type of Media are you Demuxing? Question

#### Sources
You can utilize one or more sources for a movie


#### Folder Struture
Similar to the TV mode Struture save for the numbered folders

##### Home Folder

<img src=https://user-images.githubusercontent.com/80348218/180505738-3098aae2-98f1-4bff-b6c1-535be0995b63.png width=500><img/>

##### Inside ahmybudda folder

<img src=https://user-images.githubusercontent.com/80348218/180505781-c7ebb2ae-a278-435f-a470-c5031a6593eb.png width=500><img/>

##### Output_logs

<img src=https://user-images.githubusercontent.com/80348218/180505811-44195aaf-325a-4bfb-ba22-dd650fba60c8.png width=500><img/>

##### SubImages folder

<img src=https://user-images.githubusercontent.com/80348218/180524253-4f522b0f-81cb-48e4-af8c-bf36ecb420a4.png width=500><img/>


## Remux Mode

* python3 /path/to/app.py -demux sourcepath output [optional args]

### Required
```
  sourcepath 
 
 The mux folder created during the demux process
 This holds all your configurations, and is what will be used to generate the mkv file
```


```
  outputpath
  
  The folder you want the final MKV to be outputted to
```
### Optional
--site blutopia/blu/bhd/beyondhd [default=blu]
```
Example:python3 /path/to/app.py --remux --site blutopia

This will Effect mainly effect the final track name
See Sites Section for more detail
```

--group [default=Unknown]
```
Example:python3 /path/to/app.py --remux --group superduperremuxing

This will change the group tag of the final MKV
```


### Selecting Tracks

```
Note the same imdb id will be used for all files during the muxing process
Episode IDs will also be generated from this ID if needed.

This is put in a metadata file that is utilize to put information about the current show into the final mkv. You can see this information via medainfo. 

Therefore you should only do 
1 Movie Per run
or 1 TV show per run.

Selecting Multiple Season of a TV show is fine

If you want to do a batch you'll need to write a seperate script
```


# Machine Parse

## Subtitles

Subtitles can be ocr with the --ocr command
This will run one of two ocr. The first is better but has fewer languages. 
The second is faster has lots of languages, but in my 
Experience does no ocr as well.

You can utilize this to identify what kind of track the sub is from for. It should work for foreign tracks as a well.


To save the images retrieved for the ocr use the 
--keepocr command 
Every line on the sub will be saved.
However only 50 lines are ocr to save time.

This is very useful for identifing episode as sometimes the last sub image my give a good clue. 
You can also identify dialecs if you want to specificy for the langauge. 
i.e spanish, french etc

## Video
Videorec is not as good as ocr. But it can still kind of be used to ID tracks.
Use the --videorec command to use this feature. 
To save time it will only record about 50 lines worth of the track.

## Optional:Disabling Tesseract for Non Sudo ocr
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
now only easyocr will be used.


# Enabled Tracks Sorting/Filtering
## Normal Audio Track
Here I will explain how tracks are added to th enabled audio tracks section in the Final JSON
- A track is added if the language is enabled with --audiolang. If that argument is not passed then only the tracks that match imdb languages will be added.
With this a exception is also made for English track. This will be in the order in IMDb. Or if not presented, be the last language to be checked.
- Every English Track will be added if that language is enabled. They will be added partly based on sortpref.
- For Non-English Track only the first track based on --sortpref will be added to enabled audio section
- When all the enabled tracks are gathered, and sorted. The first enabled audio track will be set to default. 

- Every lossless mono or stereo Track will be converted to FLAC

### AnimeBytes
Currently the main difference is that japanese and english are default audio languages, even if imdb only list japanese as the language of the TV/Movie

### BeyondHD
Every lossless mono or stereo Track will be converted to FLAC

### Blutopia

Blutopia will check for padding using conversion to flac. If padding is found then the flac audio will be used in replacement of the original codec. This only applies to 24bit tracks

Every lossless mono or stereo Track will be converted to FLAC
## Compatablitly Track

- A secondary Search for compatiblity audio tracks will be done. If a enabled audio track has one, then that will be inserted after that track.
This only applies to true HD tracks currently 
.


## Subs
Here I will explain how subs are added to the enabled sub section in the final JSON
- Within a language subs are given priority based on the order of the sub in provided sources.
- Every English Subtitle will be added to enabled sub section. If the language is enabled.
- Only the first subtitle of every other langauge, based on sortpref will be added
- If the films primary language is not english then the first english sub will have it default flag turned on

- Order of subtitles can either be based on --sublang argument
 alternative it will be a-z with the first subtitles being the english ones.

### AnimeBytes
If no embedded force English track is found, a secondary search for forced track is will be done.
The first and second english sub tracks will be compared. The smallest one is assumed to be forced, and this track will be set to default with the forced flag on.

## Embedded Forced Subs
This only applies to forced subs that need to be extracted from another track

Only a max of two languages will be checked.
If the first language passed via --audiolang or in the imdb is english then only english subtitles will be checked. 

If any other language is the first language, then that language and english will be check. 
Anyother language whether passed through imdb or --audiolang will be ignored.

The goal is to have force subs for any non English primary language, along with English.


All the data from the old track will be copied to the forced sub data.
- The title will be change
- The Track key will be changed
- The Track eac3to will be changed
- The Track File will be changed
- default flag turned on
- forced flag turned on 
If a forced track is found for the first audio, it is added as the first enabled audio tracks
if a forced track is found for the second language, then it is added to the end of the enabled sub list.

## Video Track
Only 1 video track is ever added and the one that is picked depends on --sortpref argument
If no argument is passed the default is to just take the largest video file from multiple sources if present.

This probably isn't the right tool if you want to do some complex hybrid remux.
So only 1 video source should be applied


# Sites 
General speaking other then track sorting sites will be similar. One difference is typically in the final name of the mkv

## Blutopia
Blutopia has a decent validator for checking if a remux is valid. It not 100 percent but gives a general Idea


# **Note**

Windows Support is planned but it might take me a while, and would be done when I feel like the main program is stable
