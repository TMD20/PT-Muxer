
# **How to Install/Get Started** 
Note I have not had time to test this on windows.
Wine is part of the code, but that is just to run windows software on linux. 

This should run fine on windows with minor changes, but It will require some tecnical know how. 
If you need help I can provide some support until I have time to refactor all the changes required for windows

## Required
  * python modules via requirements.txt 
  * Linux
  * mono


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

* Installing modules and running python3 via virtualenv
* udevil for non-sudo ISO extractions

### Installing Tesseract
Tesseract allows for many more languages to be ocr, but it does require sudo
and requires packages on the system
The easiest way would just be to follow the instructions in this repo

https://github.com/sirfz/tesserocr
This will require sudo

#### Disable tesseract
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


# Modes: 

## Demux Mode

Creates a mux folder with everything generated during the programs run
* Including all tracks from all sources, Extracted via eac3to
* BDINFO File for all Sources
* Eac3to Log for all Sources
* General Output.txt JSON file with Configurable Options

## Remux Mode: 

* Reads JSON file runs mkvmerge based on data extracted from file, and the site the remux is intented for

JSON Example: 
*  https://0.xwem.com/?aba290d66884edb3#Aah9T8RyTPR9aeASUMCjqtQ1SequUajHhNUvECxP51Jk

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
Including Language

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





# Sites
## AnimeBytes
Currently the main difference is that japanese and english are default audio languages, even if imdb only list japanese as the language of the TV/Movie

## BeyondHD
This has it own script for the final filename

Every lossless mono or stereo Track will be converted to FLAC

## Blutopia
This has it own script for the final filename

Blutopia will check for padding using conversion to flac. If padding is found then the flac audio will be used in replacement of the original codec. This only applies to 24bit tracks

Every lossless mono or stereo Track will be converted to FLAC


Blutopia has a decent validator for checking if a remux is valid. It not 100 percent but gives a general Idea

## AnimeBytes

Default Language is english and japanese

Every lossless track will be converted to flac

The first and second english sub tracks will be compared. The smallest one is assumed to be forced, and this track will be set to default with the forced flag on


# Forced Subs
This only applies to forced subs that need to be extracted from another track

Before checking if forced subs exist. Only the audio languages enabled via imdb or --audiolang argument will be checked

If english is the primary language or first language via the audio prefences only that track language will be checked for forced subs

All the data from the old track will be copied to the forced sub data.
- The title will be change
- The Track key will be changed
- The Track eac3to will be changed
- The Track File will be changed


If a forced sub is found for the first audio language, then that track will be set to forced and enabled. This Track will be added at the top of the enabled sub section in the json

Other forced subs for secondary and further languages will be added at the end of the enabled sub section in the json.

Every forced sub found will be added to the sub track details section







# Filtering Tracks
Note Every Track is extracted these are the rules for tracks that are enabled for remuxing, automatically. You can always change these settings
## Video
Video can be choosen by size or order using the --sortpref argument

## Audio
You can decide the general order of the languages using the --audiolang argument

If --audiolang argument is not passed languages will be generally come from the imdb page. Note some sites like animebytes may have slight change to this

This may change base on the site specific but some general rules are

- Every English Track will be added, and will always come first in the enabled audio section in the json. If enabled via args or imdb
- Other Tracks will appear in the enabled audio section based on the imdb order or the --audiolang order you passed
- For other Languages only the first track found will be added to the enabled audio section
-  First Track Depends on --sortpref along with order of languages via args or imdb. So if set to largest. The largest audio track for every langauge will be the one that is enabled. If set to order the first track in the first source will be added
- The First Audio Track That is enabled will be set to default
- For any enabled Track that also has a Compatiblity Track. The Compatiblity Track will come right after their parent Track in the enabled audio section in the json 



## Sub
You can decide the general order of the languages using the --sublang argument

If --sublang argument is not passed languages will be generally be in alphabetical order

This may change base on the site specific but some general rules are

- If you pass --sublang as a argument languages will be looked at in the order that you write. Meaning English may not be the first Track language.
- If --sublang argument is not passed then tracks will be looked at in alphabetical order, the imdb langauges have no effect. English will also be the first language in the enabled sub section.
- Given the order subs will be added to the enabled sub section, based on either order that you pass or alphabetically order. 
- Every English Subtitle will be added to the enabled sub section
- For other Languages only the first track will be added. --sortpref has no effect, this is only based on the order of the track





# **Note**

Windows Support is planned but it might take me a while, and would be done when I feel like the main program is stable
