---
description: Overview of some terminology of Tracks
---

# Tracks

## Types

Tracks are split into 3 types: Audio, Subtitle, and Video.

### Audio

.thd,.dts, or similar Tracks

### Subtitles

.for the most part .sup

### Video

.h264 ,.h265





## Tracks in JSON

### Track Details Section

The Track Details sections shows details for every track within each source. Within this section is a  key value. A track's key must be added to the appropriate Enabled Track Section for it to be added during the remuxing step.





### Track Key

To make added and remove tracks easier. Each Track is ID by a unique ID. This is hashed based on information from each Track. So multiple runs of the same source will generate the same key. This allows for backing up the JSON without having to keep the tracks that are tied to it.&#x20;

### Enabled Tracks Section

When Remuxing only tracks in this section will be added to the generated mkv file.

Secondly, the order of the Tracks matter as that is the order that the tracks will appear.

With

1. Video Tracks Being First
2. Audio Tracks After
3. Lastly Subtitle Tracks#

#### Adding /Removing Tracks

1. Tracks are added automatically during the demuxing process

For more information read the individual track type pages

1. Tracks can be added/removed manually by editing the JSON File.

