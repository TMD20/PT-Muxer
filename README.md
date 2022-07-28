<!-* START doctoc generated TOC please keep comment here to allow auto update -->
<!-* DON'T EDIT THIS SECTION, INSTEAD RE-RUN doctoc TO UPDATE -->
**Table of Contents**  *generated with [DocToc](https://github.com/thlorenz/doctoc)*

* [**How to Install/Get Started**](#how-to-installget-started)
  * [Install](#install)
    * [Linux:](#linux)
    * [Windows](#windows)
  * [General virtualenv Guide](#general-virtualenv-guide)
  * [Optional Upgrades](#optional-upgrades)
    * [mkvmerge:](#mkvmerge)
    * [wine](#wine)
    * [eac3to](#eac3to)
    * [suprip](#suprip)
    * [bdinfo](#bdinfo)
    * [BDSup2Sub](#bdsup2sub)
  * [Recommended Software](#recommended-software)
    * [Udevil](#udevil)
    * [Installing Tesseract](#installing-tesseract)
* [Modes:](#modes)
  * [Demux Mode](#demux-mode)
  * [Remux Mode](#remux-mode)
* [JSON](#json)
  * [Overview](#overview)
  * [Examples](#examples)
    * [Movie](#movie)
    * [TV](#tv)
  * [Sections](#sections)
    * [1. Movie](#1-movie)
    * [2. Sources](#2-sources)
    * [3. ChapterData](#3-chapterdata)
    * [4. Enabled Tracks](#4-enabled-tracks)
    * [5. Track Details](#5-track-details)
* [Commands:](#commands)
  * [Demux Mode](#demux-mode-1)
    * [Required](#required-2)
    * [Optional](#optional)
    * [TV Mode](#tv-mode)
      * [Data](#data)
      * [Sources](#sources)
      * [Folder Struture](#folder-struture)
      * [Restore Data](#restore-data)
    * [Movie Mode](#movie-mode)
      * [Sources](#sources-1)
      * [Folder Struture](#folder-struture-1)
  * [Remux Mode](#remux-mode-1)
    * [Required](#required-3)
    * [Optional](#optional-1)
    * [Movie Mode](#movie-mode-1)
    * [TV Mode](#tv-mode-1)
* [Machine Parse](#machine-parse)
  * [Subtitles](#subtitles)
  * [Video](#video)
  * [Optional:Disabling Tesseract for Non Sudo OCR](#optionaldisabling-tesseract-for-non-sudo-ocr)
* [Enabled Tracks Sorting/Filtering](#enabled-tracks-sortingfiltering)
  * [Normal Audio Track](#normal-audio-track)
  * [Compatablitly Track](#compatablitly-track)
  * [Subs](#subs)
  * [Embedded Forced Subs](#embedded-forced-subs)
  * [Video Track](#video-track)
* [Sites](#sites)
  * [Blutopia](#blutopia-1)

<!-* END doctoc generated TOC please keep comment here to allow auto update -->

# **How to Install/Get Started** 
Instructions are provided for Linux and Windows

Note: Windows is not fully supported at the moment
Modifications to the code are required to get it to work on that platform

## Install
### Linux: 
#### Required
  * python
  * mono
#### Install
* python3 -m pip install --user virtualenv
* python3 -m venv env
* source env/bin/activate
* which python -> should be the virtualenv
* pip3 install-r requirements.txt
* deactivate -> Do this after installing the requirements

### Windows
Note: Windows is not yet ready. However, I think the programs maybe 95 percent of the way ready for windows. You could possible make the modifications needed. Alternatively wait until I am able to do it myself
#### Required
  * python
#### Install
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

# Modes: 

## Demux Mode
This mode allows the user to pick multiple BDMV/ISO(with udevil).
For each source, it will do the following
* Extract every track for that source
* Search and extract any embedded forced subs for main, and secondary movie language
* Search and extract compatibility tracks 
* Generate and save the bdinfo log
* Save eac3to log

When all sources are extracted. The data is then saved to a file called output.json. The user can then update the JSON before running remux mode
## Remux Mode

This mode creates an mkv file via mkvmerge by utilizing the tracks extracted in demux mode.
It then reads the JSON file to figure out
* What Tracks to pass to mkvmerge
* Flags to add to those tracks
* What language to set tracks to
* The title that the tracks should have, if at all
* Reads JSON file. Uses the data to create a remux based on data extracted from the file.

The final .mkv filename is determined by the status of the --site argument


# JSON
## Overview

The JSON is output when you use the --demux argument. This Provides lots of details on all the tracks and sources used during the run of the program. Some of the information is auto-filled, and the user can change the values if desired. Depending on what you change the settings to that will affect the final mkv produce


## Examples

### Movie
https://0.xwem.com/?b3791a91929e6b38#He4TbTYS4a4yVAik6fkBtNfNviXb1NBC2BC86Bd7EwFi


### TV
https://0.xwem.com/?be82537624a327c6#8aW8WEmFUYbxxjR4Pknf7s52GqpzAe6xcyMPdsw3LaTv


## Sections
### 1. Movie
Data about the movie or TV show
For TV shows use OCR/ subimages to confirm episode number

Changing any of these settings, other than langs will have an effect on --remux mode
langs data is present only for convenience

* IMDB: ID for Movie/TV show
* tmdb: ID for Movie/TV show
* langs: Offical Languages for movie or TV show
* Season: if TV show the season
* Episode: If TV show the episode number


### 2. Sources

Just Basic Data data about the sources the user has utilized during the demuxing process. Most Likely shouldn’t be changed
Each source has its own key here with some data inside of it

Most of these values should not be changed 
As Changing values could cause --remux mode to crash if they don't match

 ##### Source Dictionary Keys
* outputDir: the location of the output files for the source i.e the mux folder location
* sourceDir: The location of where the source is found
* playlistNum: What Number was entered as a response to the question "What playlist" during the demux process


### 3. ChapterData

This section has information about when the chapters
Changing Value here will affect the chapters in the final mkv in --remux mode

* time: when the chapter occurs
* name: What name to give the Chapter


### 4. Enabled Tracks

Displays which Tracks will be added during the mkvmerge Process. To see more details about a track match the string here to the Track Details Sections.
The demux Process will auto-add tracks to this section

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


This section holds some Details about Each Track

The track has a hashed key. The hash is made using the source information and track title, and just in case the track index. It should be unique to each track and will stay the same. If you use the same source again.

Changing some values will have "no effect" on the final mkv produced in --remux mode.

#### Keys
* langcode: [string:2 char] used by mkvmerge to set track language. This is used to set the track language in --remux mode
* lang:  [string] Translation of langcode to the actual language. This is for convenience, and has no effect on --remux mode
* site_title: [string] used to set title for mediainfo, set to None for no title. This will affect --remux mode
* bdinfo_title: [string] just the title from bdinfo, changing this value has no effect
* index: [number] the track number. Video is usually 1. Next audio tracks, lastly subs. Changing this value has no effect
* eac30: [special syntax string] u just some info about the file extract by eac3to. Changing this value has no effect
* file: [filepath] location of the file on the system. Should only be changed if you move the output.json to a new folder
* compat: [bool] u Used for embedded tracks i.e dolby digital inside true hd
These are extracted automatically. Changing this value has no effect
* parent: [string] what track an embedded track was extracted from. changing this value has no effect
* child: [string] embedded track if present. changing this value has no effect
* machine_parse: [list] if using ocr or voice rec. The gathered values will be here. See machine_parse or demux sections for more details
* length: [number] will display how long, and how many subs a track has. Changing this value has no effect
* default: [bool] whether to set the default flag in mkv.
* forced: [bool] whether to set the forced flag. Also can be set by changing the site_title to include "forced" 
* sourceDir: [filepath] The original location of the bdmv used to extract track, This should not be changed as it is used during the --remux process
* sourceKey: [string] the key of the source in the JSON that the track is tied to, This should not be changed as it is used during the --remux process
* type: [string] whether this is an audio, video, sub-track. This value should not be changed as it is used during the --remux process
*  commentary: [bool]  Sets the Commentary flag to yes. Should be used for all audio and subtitle tracks that are commentary
*  


##### Audio Keys
These keys apply to audio tracks only, and are used to set flags in the final mkv, via mkvmerge.
Turning these on is mostly optional, but can increase the quality of your remux. Some sights like blutopia require them
* auditorydesc:[bool]  Turn on for tracks that include auditory descriptions, sets the Visual impaired flag
* original:[bool]  Turn on for tracks in the movies original language,set the Original language flag
##### Sub Keys
These keys apply to sub tracks only, and are used to set flags in the final mkv, via mkvmerge.
Turning these on is mostly optional, but can increase the quality of your remux. Some sights like blutopia require them
* sdh:[bool]  Turns on the Hearing impaired flag
* textdesc: [bool] For subtitle tracks with text-based descriptions for the visually impaired that can be read via a screen reader

# Commands:

## Demux Mode
python3 /path/to/app.py -demux sourcepath outputpath [optional args]

### Required

```
 sourcepath 
 
 where you keep all your bdmv and or iso files.
 You can pick multiple sources if you desire, just make sure they are all for the same movie/TV Episode
```


```
  outputpath
 
  Where you want the mux folder to be output to. A Folder with the following structure will be created
  Mux.randomstring.showName
```


### Optional
--site blutopia/blu/bhd/beyondhd [default=blu]
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

    During ocr images are saved to a temporary drive, this option moves the files to a permanent location in the output Mux folder. You need to pass the --ocr command for this to have any effect. 

```


### TV Mode

TV mode can be selected when using the --demux argument.
During Demux mode you will be asked  "What Type of Media are you Demuxing? 
Select TV

This mode will allow the program to execute once and then run multiple times using the same IMDB and season information for each run. However, the episode number will increment each time you go through a run.

Note: I would recommend using the arguments --keepocr --ocr enabled at a minimum. 

This will make identifying episodes much easier. As sometimes the order will be random.
This will also help in identifying tracks within each episode.


#### Data
* Season number is entered once at the beginning of the program
* Episode Number, this is assumed by the number of folders in the home directory, see... folder structure to see more details
* IMDB data: This can be entered manually or by clicking on one of the options that appear 
* tmdb: converted via IMDB number

#### Sources
You can utilize one or more sources per episode

After an episode finishes extracting, you can utilize the same or different sources for the next episode i.e for example a Season can be split across many disks

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

For a TV mode demux that is partially stopped, you can restore the data during the run of the program.
It will not consider Movie Mode Folders to be valid. 

If no valid folders are found, the program will create a new one.


### Movie Mode

Movie mode can be selected when using the --demux argument.
During Demux mode you will be asked  "What Type of Media are you Demuxing? 
Select Movie

This Mode only runs once

Note: I would recommend using the arguments --keepocr --ocr enabled at a minimum. 
This will make identifying tracks much easier. OCR should do a decent job of helping, but if it fails to give the data required. Then having images from the subtitles can help a lot
#### Sources
You can utilize one or more sources for a movie.


#### Folder Structure
Similar to the TV mode Structure
However, the numbered subfolders are not present

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
 This holds all your configurations and is what will be used to generate the mkv file
```


```
  output path
  
  The folder you want the final MKV to be outputted to
```
### Optional
--site blutopia/blu/bhd/beyondhd [default=blu]
```
Example:python3 /path/to/app.py --remux --site blutopia

This will Effect mainly affect the final track name
See Sites Section for more detail
```

--group [default=Unknown]
```
Example:python3 /path/to/app.py --remux --group superduperremuxing

This will change the group tag of the final MKV
```

### Movie Mode

Movie mode can be selected when using --remux argument.
During remux mode, you will be asked  "What Type of Media are you remuxing? 
Select Movie

This mode will find all valid Mux folders and allow you to select one for muxing



### TV Mode

TV mode can be selected when using --remux argument.
During remux mode, you will be asked  "What Type of Media are you remuxing? 
Select TV

This mode will find all valid Mux folders and allow you to select one for muxing.
Unlike Movie mode, TV mode will mux multiple mkvs all into the output directory.

The episode Number, and the title for each file depend on your JSON settings
# Machine Parse

## Subtitles

Subtitles can be ocr with the --ocr command
This will run one of two ocr. The first is better but has fewer languages. 
The second is faster has lots of languages, but in my 
Experience does no ocr as well.

You can utilize this to identify what kind of track the sub is tied to. It should work for foreign tracks as well.

The program will generate temp images for every line in checked subs

However, only the first 50 and last line will be ocr

To save the images retrieved to a permanent location use
--keepocr command 



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
now only easyocr will be used.


# Enabled Tracks Sorting/Filtering
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
## Compatablitly Track
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


# Sites 
Generally speaking other than track sorting sites will be similar. One difference is typically in the final name of the mkv

## Blutopia
During remux if you set the site too --blutopia, that will have an effect on the final file name.
It will also provide use of their validator, which provides details on if your remux will be approved.

It is not 100 percent, but it provides a general idea.



