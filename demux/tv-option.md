# TV Option

This option can be selected while running the demux command.&#x20;

The script will prompt the user once to gather media ids from mal,tmdb,imdb,etc. Then it will utilize that information to create multiple JSON. Each JSON corresponds to a different playlist or stream, and a different episode within a TV show.



### Running Structure

1. Pick sources
2. Pick playlist => multiple possible per source
3. Extract files into subfolders
4. Program quits

### Picking Playlist

Each Time you are prompted to pick playlist. All sources must have the same number of playlist

```
First Iteration

Source1 Playlist: 1-3,10
Source2  Playlist: 5-8,12
```

Not

```
First Iteration

Source1 Playlist: 1-5,10
Source2  Playlist: 5-8,12
```

It is possible to take advantage of running the program multiple times to create more advance use of multiple sources

```
First Iteration

Source1 Playlist: 1-3
Source2  Playlist: 5-8

Second Iteration
Source 1 Playlist:4-5

Third iteration
Source 1 Playlist:10
Source 2 Playlist:12
```

### splitplaylist argument

splitplaylist argument will process every stream longer then a selected minimum from every playlist selected, as a individual episode.

For a selection to be valid with the splitplaylist argument, the total count of streams must be the same for all sources.

Additionally the playlist streams will be sorted based on playlist number, and each stream must match in length



#### Example 1: Stream Count Validation

This passes the length test since both sources have the same number of streams

```
source1: 
selected playlist
0011MPLS => 00011MT2S, 00012MT2S, 00013MT2S, 00014MT2S
0012MPLS => 00016MT2S, 00017MT2S, 00018MT2S, 00019MT2S

source2: 
selected playlist
0011MPLS => 00011MT2S, 00012MT2S, 00013MT2S, 00014MT2S
0012MPLS => 00016MT2S, 00017MT2S, 00018MT2S, 00019MT2S
```

#### Example 2: Stream Count Validation

This fails the length test since both sources do not have the same number of streams

```
source1: 
selected playlist
0011MPLS => 00011MT2S, 00012MT2S, 00013MT2S, 00014MT2S
0012MPLS => 00016MT2S, 00017MT2S, 00018MT2S

source2: 
selected playlist
0011MPLS => 00011MT2S, 00012MT2S, 00013MT2S, 00014MT2S
0012MPLS => 00016MT2S, 00017MT2S, 00018MT2S, 00019MT2S

```

#### Example 3:  Stream Length Validation

Expanding on Example 1

```
source1: 
selected playlist
0011MPLS => 00011MT2S, 00012MT2S, 00013MT2S, 00014MT2S
0012MPLS => 00016MT2S, 00017MT2S, 00018MT2S, 00019MT2S

source2: 
selected playlist
0011MPLS => 00011MT2S, 00012MT2S, 00013MT2S, 00014MT2S
0012MPLS => 00016MT2S, 00017MT2S, 00018MT2S, 00019MT2S

source1 00011MT2S [30min ]  
source2 00011MT2S [30min ]


source1 00012MT2S [28min ]  
source2 00012MT2S [28min ]

source1 00019MT2S [28min ]  
source2 00019MT2S [28min ]
```

Here the first and second streams have the same length, along with the final streams assuming all the streams in between also have the same length then this selection will be valid.

If not it will fail



#### Complex Selections

Multiple sources can be selected with this argument. However depending on how complex your desired selection of sources it may be required to run the program multiple times.  You can always restore,and continue from a previous run in TV mode



### Tips on sorting Episodes

Ideally the source will have a single playlist with every stream, this is very common with anime.&#x20;

\--splitplaylist argument can be used in those cases



the --keepocr argument can also help with sorting episodes, as sometimes the last image for a subtitle will have information about the current episode

### Restoring Data

If you want to continue a past Demux Process Selecting the TV option provides a prompt to restore old data

If no valid folders are found, the program will create a new one.

### Folder Structure

**Home Folder**

![](https://user-images.githubusercontent.com/80348218/180505703-19666c95-235a-451f-a746-139f0459749c.png)

#### Inside Directory 1

![](https://user-images.githubusercontent.com/80348218/180505738-3098aae2-98f1-4bff-b6c1-535be0995b63.png)

#### Inside ahmybudda folder

![](https://user-images.githubusercontent.com/80348218/180505781-c7ebb2ae-a278-435f-a470-c5031a6593eb.png)

#### Output\_logs

![](https://user-images.githubusercontent.com/80348218/180505811-44195aaf-325a-4bfb-ba22-dd650fba60c8.png)

#### SubImages folder

![](https://user-images.githubusercontent.com/80348218/180524253-4f522b0f-81cb-48e4-af8c-bf36ecb420a4.png)
