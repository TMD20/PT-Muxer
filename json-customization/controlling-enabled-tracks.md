# Controlling Enabled Tracks

## Adding Track&#x20;

Video Tracks always come first, next audio Tracks, lastly subtitle tracks You can change the order of the tracks within these three types

### Track key

&#x20;example below "be397184\_en" is the track key

```

"Tracks_Details": {
    "Audio": {
"be397184_en": {
        "bdinfo_title": "Dolby Digital Audio / 2.0 / 48 kHz /   192 kbps / DN -21dB",
        "langcode": "en",
        "lang": "English",
        .......
}

```

If we want this track to be included in the final remux it must be added to the appropriate section within Enabled\_Tracks.

For example be397184\_en must be added to the Audio Section



```json
"Enabled_Tracks": {
    "Video": [
      "e44f315f_vid"
    ],
    "Audio": [
      "a1d1f393_en",
      "db97f756_en",
      "be397184_en"
    ],
    "Sub": [
      "2469baec_en"
    ]
  },
  
```





### Changing order of Track

In the Track Details Section. Each Track is sorted with in 3 types audio, video, subtitle

* Find the track, and copy its key
* Go to the Enabled Tracks Section, you must find the list that that matches the tracks type
* Put the track's key in the order that you want it to appear

```
"Audio": [
  "a1d1f393_en",

  "db97f756_en",
dd

  "be397184_en"
],
```

### Disabling Track

* Find the track that you want to remove in the matching enabled tracks list
* &#x20;you can verify it's data in the matching Track Details subsection
* To disable or remove from final mkv. Remove that track's key from the list

##
