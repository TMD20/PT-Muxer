---
description: Customize the final MKV
---

# JSON Customization





### Overview

The JSON is output when you use the "demux" argument. This Provides lots of details on all the tracks and sources used during the run of the program. Some of the information is auto-filled, and the user can change the values if desired. Depending on what you change the settings to that will affect the final mkv produce

### Examples

#### Movie

https://0.xwem.com/?b3791a91929e6b38#He4TbTYS4a4yVAik6fkBtNfNviXb1NBC2BC86Bd7EwFi

#### TV

https://0.xwem.com/?be82537624a327c6#8aW8WEmFUYbxxjR4Pknf7s52GqpzAe6xcyMPdsw3LaTv

### Sections

#### 1. Movie

Data about the movie or TV show For TV shows use OCR/ subimages to confirm episode number

Changing any of these settings, other than langs will have an effect on "remux" mode langs data is present only for convenience

**Keys**

* imdb: \[string] imdb ID for Movie/TV show
* tmdb: \[string] themoviedb ID for Movie/TV show
* languages:  \[list of string] Official Languages for movie or TV show
* season:  \[int]  the season, for TV shows only
* episode:  \[int] the episode number, for TV shows only
* title:  \[string] The title of the show
* type: \[string]  Whether this is a TV or Movie. Based on data from IMDB or MAL
* mal\_id: \[int] myanimelist id for the show, only applies to anime
* enTitle: \[string]  only applies to anime, the english title of show
* japTitle: \[string] only applies to anime, the japanese title of the show
* anisearch: \[int]  only applies to anime, animesesarch for the show
* anidb: \[int] only applies to anime, animedb id for the show
* kitsu: \[int]  only applies to anime, kitsu id for the show

#### 2. Sources

Basic data about the sources the user has utilized during the demuxing process. Each source has its own key with data inside of it

Note:Most of these values should not be changed.

As changing values here could cause "remux" mode to crash if they don't match

**Source subsections keys**

* outputDir:  \[filepath] the location of the output files for the source
* sourceDir: \[filepath]The location of where the source is found
* playlistNum: \[int] What Number was entered as a response to the question "What playlist" during the demux process
* playlistFile: \[string] The playlist file the playlist number corresponds with
* streamFiles: \[list of strings] All the mt2s streams the JSON matches with. Will either match with BDINFO, or be one stream if --splitplaylist is on
* length: \[string] The Length of all the streamFiles combined

#### 3. ChapterData

This section has information about the different chapters.

Changing the values here will affect the chapters in the final mkv in "remux" mode

* time:  \[string] When the chapter starts
* name:  \[string] What name to give the chapter

#### 4. Enabled Tracks

Displays which Tracks will be added during the mkvmerge Process.

&#x20;To see more details about a track match the string here or key to the Track Details Sections.&#x20;

The demux Process will auto-add tracks to this section, but you can also add or remove appropriate tracks as well.

**Enabled Tracks subsections**

* Video: \[list of strings] keys for all the video Tracks to enable
* Sub:  \[list of strings]  keys for all the subtitle Tracks to enable
* Audio: \[list of strings] keys for all the audio Tracks to enable

#### 5. Track Details

This section holds some Details about Each Track

The track has a hashed key. The hash is made using the source information and track title, and just in case the track index. It should be unique to each track and will stay the same. If you use the same source again.

Changing some values will have "no effect" on the final mkv produced in "remux" mode.

&#x20;**Track Detail subsections**

This section is split into 3 subsection for the different track types. Video, Subtitle, Audio.&#x20;

**Keys**

* langcode: \[string:2 char] used by mkvmerge to set track language. This is used to set the track language in "remux" mode
* lang: \[string] Translation of langcode to the actual language. This is for convenience, and has no effect on "remux" mode
* site\_title: \[string] used to set title for mediainfo, set to None for no title. This will affect "remux" mode
* bdinfo\_title: \[string] just the title from bdinfo, changing this value has no effect
* index: \[number] the track number. Video is usually 1. Next audio tracks, lastly subs. Changing this value has no effect
* filename: \[string] name of filename used when extracting track.                                                                       This value should not be changed without changed the filename in the output folder as well                                                                     &#x20;
* compat: \[bool] u Used for embedded tracks i.e dolby digital inside true hd These are extracted automatically. Changing this value has no effect
* parent: \[string] title of track an embedded track was extracted from. changing this value has no effect
* child: \[string] embedded track title if present. changing this value has no effect
* parentKey: \[string] The key of the parent track. changing this value has no effect
* childKey: \[string] The key of the child track.                       changing this value has no effect
* machine\_parse: \[list] if using ocr or voice rec. The gathered values will be here. See machine\_parse or demux sections for more details
* length: \[number] will display how long, and how many subs a track has. Changing this value has no effect
* default: \[bool] whether to set the default flag in mkv.
* forced: \[bool] whether to set the forced flag. Also can be set by changing the site\_title to include "forced"
* sourceDir: \[filepath] The original location of the bdmv used to extract track, This should not be changed as it is used during the "remux" process
* sourceKey: \[string] the key of the source in the JSON that the track is tied to, This should not be changed as it is used during the "remux" process
* type: \[string] whether this is an audio, video, sub-track. This value should not be changed as it is used during the "remux" process
* commentary: \[bool] Sets the Commentary flag to yes. Should be used for all audio and subtitle tracks that are commentary
* auditorydesc:\[bool] Turn on for tracks that include auditory descriptions, sets the Visual impaired flag. Applies only to audio tracks
* original: \[bool] Turn on for tracks in the movies original language,set the Original language flag. Applies only to audio tracks
* sdh:\[bool] Turns on the Hearing impaired flag. Applies only to sub tracks
* textdesc: \[bool] For subtitle tracks with text-based descriptions for the visually impaired that can be read via a screen reader. Applies only to sub tracks
