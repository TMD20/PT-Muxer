# Audio



## Enabled Tracks

Tracks are enabled based on three parameters

```
--site argument
--audiolang argument
--sortpref argument
```



### Language

Selected language is used to control&#x20;

1. Which tracks should be completely filter out&#x20;
2. It also controls the order of the Audio Tracks within the enabled tracks section&#x20;

If a language is not added, then any track that matches that language will not be automatically added in the enabled section tracks section

### Automatic Language Selection&#x20;

If the  --audiolang argument is  not passed then IMDB language data is used for the title

**English**

* Additionally automatic language selection will always add English
* If English is not part of the IMDB data, then it will be appended as the last language
* To completely disable English, you will need to pass --audiolang argument



### Manually Language Selection

This is done through the &#x20;

```
--audiolang argument
```

1. The language parser uses standardize names for example ISO-2 standard
2. You must enter the full English name
3. Additionally you should not enter any regional information

[https://www.loc.gov/standards/iso639-2/php/code\_list.php](https://www.loc.gov/standards/iso639-2/php/code\_list.php)

####

### Priority of Tracks

A track is given priority based on &#x20;

1. Primary priority is based on the order of selected languages for a source. With languages earlier on the list given higher priority then languages later on the list. It's possible a language selected is not actually on the disk, in that case that language will be skipped.
2. Secondarily, If multiple tracks match a language then priority is then based on the sortpref argument

```
--sortpref [size or order]
default size
size: size of tracks amoung all sources
order: order of track within sources, with first source selected given priority
```



### Number of Tracks

Not all tracks matching a selected languages will be added to the JSON within the enabled section

* Currently only the highest priority track is added for most languages
* For english all tracks will be added
* If a track is detected as a duplicate then it will be filtered out

If more then one track is added for a language, then the order of the tracks within the enabled section depends on the priority of that track



## Compatibility Track

These are embedded Tracks extracted from TrueHD tracks

### What Tracks are Checked

* Every Track that matches the file type above

### Track is found

Track data from parent will be copied for JSON

* The title will be change
* The Track key will be changed
* The Track filename will be changed
* The Track File will be changed
* A compat flag will be set to mark this as compatibility track
* parent flag will be set to tie which parent matches this track
* parentKey flag will match the key of the parent



### Insertion Order

* You will be able to find all compatibility Tracks within the Track Details Sections
* Whether or not a Compatibility Track Appears in the Enabled Track Section depends on it's parent track
* If a parent track is in the Enabled Track Section, then the compatibility track will appear right after



## Site Overrides

### AnimeBytes

Default languages are Japanese and English for all sources. This is to ensure the production of Dual Audio Sources if Possible

### BeyondHD

Every lossless mono or stereo Track will be converted to FLAC

### Blutopia

Blutopia will check for padding using conversion to FLAC. If padding is found then the FLAC audio will be used in replacement of the original codec. This only applies to 24bit tracks

Every lossless mono or stereo Track will be converted to FLAC
