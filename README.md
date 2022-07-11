# **How to Use** 

## Required
  * python modules via requirements.txt 
  * mkvmerge
  * eac3to
  * wine
  * Linux
  * mediainfo

## Recommended

* Installing modules and running python3 via virtualenv
* udevil for non-sudo ISO extractions

## Modes: 

### Demux Mode

Creates a mux folder with everything generated during the programs run
* Including all tracks from all sources, Extracted via eac3to
* BDINFO File for all Sources
* Eac3to Log for all Sources
* General Output.txt JSON file with Configurable Options

### Remux Mode: 

* Reads JSON file runs mkvmerge based on data extracted from file, and the site the remux is intented for

JSON Example: 
*  https://0.xwem.com/?aba290d66884edb3#Aah9T8RyTPR9aeASUMCjqtQ1SequUajHhNUvECxP51Jk

## 3 Main JSON Sections

### 1. Sources

Just Basic Data data about the sources the user has utilize during the demuxing process. Most Likely shouldn’t be change

### 2. Enabled Tracks

Displays which Tracks will be added during the mkvmerge Process. To See more details about a track match the number to the here to the Track Details Sections.

Changes that can be made with effect
* Remove Tracks to remove them from final mkvmerge
* Reorder Tracks to change how they appear in mkvmerge, and in the final mkv file

### 3. Track Details

Some Details about Each Track
Including Language

Changes that can be made with effect
* Changing the language code to change the language of the track
* Changing the title to change the title of the track


## Commands:

### Demux Mode
python3 /path/to/app.py -demux sourcepath outputpath [optional args]

#### Required

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


#### Optional

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
 



### Remux Mode

* python3 /path/to/app.py -demux sourcepath outputpath

#### Required
```
  sourcepath 
 
 The mux folder created during the demux process
 This holds all your configurations, and is what will be used to generate the mkv file
```


```
  outpath
  
  The folder you want the final MKV to be outputted to
```
#### Optional

```
--site blutopia/blu/bhd/beyondhd [default=blu]

This will Effect mainly effect the final track name
See Sites Section for more detail
```



# Sites
Coming Soon

# Filtering Tracks
Coming Soon



## **Note**

I will be provided better details in the future on how to install and run
basically you should make a virtual env, and install all the required modules with the requirements.txt

Windows Support is planned but it might take me a while, and would be done when I feel like the main program is supported

Subtitles will be forced if they have forced anywhere in the site title




















