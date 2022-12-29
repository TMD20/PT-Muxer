---
description: Extract Raw Files From Blu-ray
---

# Demux



## Before Running The Program

### Activating Virtual Env

#### Windows

* .\env\Scripts\activate



#### Linux

* source env/bin/activate



## Demuxing Files

This mode allows the user to pick multiple BDMV/ISO. For each source, it will do the following

* Extract every track for that source
* Search and extract any embedded forced subs for main, and secondary movie language
* Search and extract compatibility tracks
* Generate and save the bdinfo log
* Save eac3to log
* Extracts ISO with 7zip or udevil as backup

When all sources are extracted. The data is then saved to a file called output.json. The user can then update the JSON before running remux mode

### Commands

python3 /path/to/app.py -demux sourcepath outputpath \[optional args]

#### Required

sourcepath

```
 where you keep all your bdmv and or iso files.
 You can pick multiple sources if you desire, just make sure they are all for the same movie/TV Episode
```

outputpath \[default=current dir]

```
  Where you want the mux folder to be output to. A Folder with the following structure will be created
  Mux.randomstring.showName
```

#### Optional

\--site \[default=None]

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

\--sortpref \[default=size]

```
Example: python3 /path/to/app.py -demux sourcepath outputpath --sortpref size
 options: size or order
size: sort tracks by which track is largest. Give the highest priority to largest track
order: sort tracks by which comes first, give the highest priority to first tracks
```

\--audiolang \[default=\[]]

```
 Example:python3 /path/to/app.py -demux sourcepath outputpath --audiolang english japanese
 
 Which Track Language(s) you want to enable for the current demux.
 This only affects what tracks will be added in the enabled audio tracks section. When creating the JSON file. Every track is extracted 
 regardless of this setting
```

\--sublang\[default=\[]]

```
Example:python3 /path/to/app.py sourcepath outputpath -demux --sublang english japanese

Which Track Language(s) you want to enable for the current demux.
This only affects what tracks will be added in the enabled sub-tracks section. When creating the JSON file. Every track is extracted 
regardless of this setting
```

\--ocr \[default=None]

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

\--voicerec \[default=None]

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

\--keepocr&#x20;

```
    Example: python3 /path/to/app.py -demux sourcepath outputpath --ocr enabled --keepocr
    
    During ocr process images are saved to a temporary folder. Then the images are processed using one of the ocr engines. This option moves the files to a permanent location in the output Mux folder. You can keep the images and skip the ocr step, by passing --keepocr without the --ocr argument 
    
```

\--splitplaylist

```
   Example: python3 /path/to/app.py -demux sourcepath outputpath --splitplaylist inf

  This argument only has an effect in TV option, during demuxing. 
  Instead of sending a playlist to eac3to. This will split a playlist into its individual streams, and send those to eac3to.
  So each stream will be it's on episode or folder in the final Mux Folder.
  
  For example BDINFO might show a playlist 0001.mpls with these Files 0002.mt2s 0004.mt2s 0008.mt2s
  Normally this would be one folder represented by the playlist, with splitplaylist now each of those streams would be represented by one 
  folder
  Note you must provide a minumimum length for playlist
  If you set the value to zero or inf, then all streams will be accepted regardless of length

```

\--dontconvert

```
   Example: python3 /path/to/app.py -demux sourcepath outputpath --donconvert

  Skips all lossless conversions
  example: disables converting certain tracks to .flac
```

\-- extractprogram \[default=eac3to]

```
 Example: python3 /path/to/app.py -demux sourcepath outputpath --extraprogram dgdemux
  
 Select which program you want for extraction of tracks
 choices ->  eac3to or dgdemux
 
 eac3to: use eac3to to extract tracks
 dgdemux: use dgdemux to extract tracks
 
```

\--loglevel \[default=INFO]

```
Example: python3 /path/to/app.py -demux sourcepath outputpath --loglevel debug

Controls the level of output for the program
WARNING: Prints very little to console
INFO: Default Prints Good balance of information
DEBUG: Should be used if having issues
```

\--title

```
Example: python3 /path/to/app.py -demux sourcepath outputpath --title Avengers

Manually enter the title of the source being demuxed
```

