# **How to Install/Get Started** 
Note I have not had time to test this on windows.
Wine is part of the code, but that is just to run windows software on linux. 

This should run fine on windows with minor changes, but It will require some tecnical know how. 
If you need help I can provide some support until I have time to refactor all the changes required for windows

## Required
  * python modules via requirements.txt 
  * Linux

## Optional Binaries
  These binaries are included but you are free to use newer versions if desired
   see config.py "*LinuxPath"for filepaths. 
  * mkvmerge
  * wine
  * Linux
  * mediainfo



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

# 3 Main JSON Sections


## 1. Movie
Data about the movie or TV show
For TV show or Movie use OCR/ subimages to confirm episode number

* imdb: ID for Movie/TV show
* tmdb: ID for Movie/TV show
* langs: Offical Languages for movie or TV show
* Season: if TV show the season
* Episode: If TV show the episode number
*

## 2. Sources

Just Basic Data data about the sources the user has utilize during the demuxing process. Most Likely shouldn’t be change
Each source has its own key here with some data inside of it

### Keys

#### Sections
* Each Source has it own dictionary or section
* The section is marked by a  source directory base path key /home/main/test would have a key of test
  
 ##### Inside Sections 
* outputDir: the location of the output files for the source i.e the mux folder location
* sourceDir: The location of where the source is found
* playlistNum: What Number was entered as a response to the question "What playlist" during the demux process


## 3. ChapterData

This section has information about when the chapters

* time: when the chapter occurs
* name: What name to give the Chapter







## 4. Enabled Tracks

Displays which Tracks will be added during the mkvmerge Process. To See more details about a track match the number to the here to the Track Details Sections.

### Keys
Each Key has a list of Ids
* Video: All the video Tracks to enable 
* Sub: All the subtitle Tracks to enable 
* Audio: All the audio Tracks to enable 

### Changing order of Tracks
Just change the order of the track in the list

### Disable Track
Just remove a track from the list


## 5. Track Details


Some Details about Each Track
Including Language

### Keys
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
  outpath
 
  Where you want the mux folder to be outputed to. A Folder with the following struture will be created
  mux.randomstring.basenamefirstfolder
```


### Optional

```
--site blutopia/blu/bhd/beyondhd [default=blu]

This will Effect
* Order of Tracks
* Track Names
* Which Tracks are Included by default
* ETC
For More Details on Different Sites and their effects on The final Output Please Read the Site Section
Track Order and Tracks Picked can be overwritten see Filtering Tracks section
```

```
 --pref size/order [default=size]
 
Whether tracks should be sorted by size or Large
This will effect which Tracks are picked see Filtering Tracks section
```


```
 --pref audiolang 
 
 Which Track Language you want to enable for the current demux
 This will overwrite any site configuraton. You can call this argument multiple times, note the order of the calls 
 is the order you want the tracks toappear
 see Filtering Tracks section
```
 
 ```
 --pref sublang 
 
 Which Track Language you want to enable for the current demux
 This will overwrite any site configuraton. You can call this argument multiple times, note the order of the calls is the 
 order you want the tracks to    appear
see Filtering Tracks section
```

### TV Mode

Selected during demux via questionarre

Specifically the  "What Type of Media are you Demuxing? Question

#### Episode Data
* Season number is entered once at the the beginning of the program
* Episode Number, this is assumed by the number if folders in the home directory, see... folder struture to see more details
* imdb data: This can be entered manually or by clicking on one of the options that appear 
* tmdb: converted via imdb number
* tvdb: converted via imdb number

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

* python3 /path/to/app.py -demux sourcepath outputpathhttps://user-images.githubusercontent.com/80348218/180505811-44195aaf-325a-4bfb-ba22-dd650fba60c8.png

### Required
```
  sourcepath 
 
 The mux folder created during the demux process
 This holds all your configurations, and is what will be used to generate the mkv file
```


```
  outpath
  
  The folder you want the final MKV to be outputted to
```
### Optional

```
--site blutopia/blu/bhd/beyondhd [default=blu]

This will Effect mainly effect the final track name
See Sites Section for more detail
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
Coming Soon

# Filtering Tracks
Coming Soon



## **Note**

I will be provided better details in the future on how to install and run
basically you should make a virtual env, and install all the required modules with the requirements.txt

Windows Support is planned but it might take me a while, and would be done when I feel like the main program is supported

Subtitles will be forced if they have forced anywhere in the site title




















