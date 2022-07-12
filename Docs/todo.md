This todo is based on the Blutopia remux
Not every thing in the list will be possible to accomplish in a automated way

Change bdinfo to select for each track, then extract after
Add Mkvmerge commands to JSON
1. xml file
2. Find way to filter similar tracks bluray.com/or track properties
2. imdb and tmdb in mediainfo
3. Speech reconition
3. Add Ability To Add mkvmerge extra commands
3. ALlow passing addition mkvmerge track arguments
4. Allow mkvmerge command output
5. Configure other options like language
6. Documentation on Track Naming Etc
7. Video Original Source ID, not sure how common this is
8. Video Original Source medium
9. Embedded forced subtitles
   If the eac3to log mentions that the English subtitle track contains forced portions, these must be extracted with BDSup2Sub and provided as a separate track.
   Import the subtitle into BDSup2Sub.
   Set the Target FPS to the desired FPS to correctly align the timestamps.
   File → Export → Export only forced → Save
   E.g. Subtitle track 7 contains 959 normal and 170 forced captions.

Not sure if this can be done via commandline
7.DGDemux for UHD Disk Seamless Branching; how to detect 8. Makemkv for demux dolby vision disk 9. Title Forced Subtitles Forced for foreign parts 10. 3rd priority: an object-based layer (DTS:X, Atmos) is better than none. Should this be consider above a regular loseless track? 11. Support upmixes and downmixes

- Naming
- Enabling etc

12. Commentary Tracks
    Might be hard to automate
13. Exclude non-English forced subtitles unless they are in the production's primary language.
14. Scraping info from website; sites probably doesn't have an API
    re preparing:
    Wikipedia
    IMDB
    Shot On What
    Blu-ray Forum
    DVDBeaver
15. Convert Dual mono; probably can't be automated
16. Convert text-based subtitles vtt to srt use subedit
17. Tonemape HDR subtitles
18. Some type of chapter automation Section 7 in Remux Guide
19. Syncing audio to video method 1 maybe able to be automated
20. Syncing Chapters to Video; Probably needs to be done manually
21. Sync subtitles
22. Kino Larber BD; Not sure how this would be done
23. MultiDisk Support
24. Order the audio include non standard tracks like commentary tracks
25. Sort Subtitles
26. Video Track name; MEl and Fel 
27. Convert lossless audio little big flag; not sure if can be automated
28. Account for audio track rename expections
- upmix
- dubs
- Commentary tracks
29. Name older audio formats
30. Naming subtitles
31. Support no dialog audio tracks zxx
32. support specialized track flags
33. TV Show support
3

