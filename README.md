# About

PTMuxer is a tool built for supporting the user in the creation of quality remuxes for various private trackers. Automation is provided for many aspects of the the demuxing and remuxing process. When automation is not possible features like subimage generation or OCR can support the user in identify tracks.

## Features

* Extract Tracks with eac3to or dgdemux
* Supports multiple sources per remux
* Gather disk info with BDINFO&#x20;
* Extract forced Subs with bdsuptosub **\[primary language,secondary language]**
* Support for subtitle image generation
* Some support for matching DVD Order to IMDB  _example: Gintanma_
* Extract compatibility track from TrueHD
* AutoGenerate filenames during remux
* Generates track titles based on BDInfo
* Gather basic language Information for tracks
* Supports splitting single playlist into streams w/th chapters
* Gathers data from IMDB,TMDB, and MAL
* Advanced configuration through JSON
* Hashed track IDs for portability
* Additional support for anime Series
* Embeds XML data
* Support For ISO extraction
* Can generate subtitle images
* Optional Episode Name Search for filename  **\[remuxing TV Shows only]**
* Optional OCR of Subtitles for Identification: Compatibility with over 100 languages
* Optional Validatidation MKV with modified https://github.com/werrpy/vdator/ **\[blutopia only]**
