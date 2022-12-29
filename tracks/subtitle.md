# Subtitle

## Enabled Tracks

Tracks are enabled based on three parameters

```
--site argument
--sublang argument
```

### Automatic Language Selection

For subtitles all languages are selected by default

#### Automatic Language Order

* With automatic language detection subtitle tracks will be sorted A-Z within enabled track section
* English is an exception to language ordering, English tracks will appear first

### Manual Language Selection

The --sublang argument can be used to change the which subtitles to add or which order they should appear

### Priority of Tracks

* Primary priority of subtitile tracks is based on language selection
* If multiple tracks match a language, priority is then based on order of sources, and then order of matching tracks within that source



### Number of Tracks Per Language

* Currently only the first track for each language will be added.&#x20;
* If a language does not have a matching track, then the next language available language within the selected source(s) will be processed
* An exception is made for English tracks, every English track is added.&#x20;

### Foreign Films

Please read the audio page for how languages are selected.&#x20;

If the first language is not english, then the first english subtitle will have it default flag turned on



## Embedded Forced Subs

This only applies to forced subs that are extracted from another track

### What languages are check

Only a max of two languages will be checked. All other languages will be ignored

* If the first language passed via --audiolang or in the IMDB is English then only English subtitles will be checked.
* If the first language is not English via --audiolangs or IMDB, then that language will be checked along with English



#### Embedded force track is found

Data from the parent track will be copied for JSON

* The title will be change
* The Track key will be changed
* The Track filename will be changed
* The Track File will be changed
* default flag turned on
* forced flag turned on

If a forced track is found for the first language,

* it is added as the to the beginning of the enabled subtitle track list

if a forced track is found for the second language

* it is added to the end of the enabled subtitle track list



## Site Overrides&#x20;

#### AnimeBytes

If no embedded force English track is found, a secondary search for a forced track will be done.

The first and second English sub-tracks will be compared. The smallest one is assumed to be forced, and this track will be set to default with the forced flag on.
