# BDSupReader
Original File | Images (converted to APNG) | Screen Images (converted to APNG)
:-----------: | :------------------------: | :-------------------------------:
[:clapper:](https://github.com/Sec-ant/BDSupReader/blob/master/dataset/test_04.sup?raw=true) | <img src="https://github.com/Sec-ant/BDSupReader/raw/master/assets/Image%20Example.png?raw=true" alt="Image Example.png"> | <img src="https://github.com/Sec-ant/BDSupReader/raw/master/assets/Screen%20Image%20Example.png?raw=true" alt="Screen Image Example.png">

## Intro
A BluRay PGS subtitle (.sup) parser, which is developed as a helper CLI tool to sync PGS subtitles timewise. More features will be considered when the basic requirements are met.

This project is still under development, comments and advices are always appreciated!

## Features
* Acquire all the information that the subtitle carries, please refer to [US Patent US 20090185789 A1](https://encrypted.google.com/patents/US20090185789?cl=da) for details;
* Acquire the start and end timestamp for each caption;
* Acquire and save images of each caption;
* Acquire and save the screen image, which means not only the images themselves, but also their placements on the screen, of each caption;
* Convert to a 1D vector based on a certain sample frequency;
* Shift, scale or transform timestamps;
* Apply a filter on caption images.

## Future Work
* Convert text format strings to RGBA image;
* Convert subrip or ASS/SSA subtitles to PGS subtitles;
* OCR. (Maybe not, for this feature is too heavy)

## Known Issues
Please refer to the [Open Issues Page](https://github.com/Sec-ant/BDSupReader/issues?q=is%3Aopen).

## Reference
* [BDSup2Sub](https://github.com/mjuhasz/BDSup2Sub) by @EzraBC
* [pgsreader](https://github.com/EzraBC/pgsreader) by @mjuhasz
* [Presentation Graphic Stream (SUP files) BluRay Subtitle Format](http://blog.thescorpius.com/index.php/2017/07/15/presentation-graphic-stream-sup-files-bluray-subtitle-format/)
* [US Patent US 20090185789 A1](https://encrypted.google.com/patents/US20090185789?cl=da)
* [US 7912305 B1 patent](https://www.google.com/patents/US7912305)
* [YCbCr - Wikipedia](https://en.wikipedia.org/wiki/YCbCr)
