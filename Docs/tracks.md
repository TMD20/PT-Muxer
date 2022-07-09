
Audio
    Find best audio track
        Largest:
            For each language
                - Given higher priority to lossless tracks

                - Compare lossless tracks from different sources by given larger files higher priority

                - Only 1 track per language

                - compatiblity tracks that corresispond to main tracks.  Added after all main tracks

            
        First:
            For each language
                - Go for the track that appears first

                - only 1 track per language

                - Order is dependt on how user picks tracks

    Multiple Languages
        All Languages are added by default 

    Track Name:
        Usually same as bdinfo

        Special Cases
            - Lossless converted to flac
            FLAC Audio /.....

            - Comptability Tracks
            Compatibility Track /.......

            Commentary Tracks
            - Need to be done manually

            Dolby Surround

            -Will need to see an example of this



    Commentary/Special tracks
        This will have to be manually picked

        Most likely they will be in the Tracks_Details in the output.txt, but not enabled by default

    Syncing
        This will have to be done manually

Video

    Find best video track
        largest: 
            Returns the largest file from multiple Blu-Ray Files
        
        first:
            Order is dependt on how user picks tracks

            Pick the first video Track that appears

    Track Name:
        Same as in bdinfo

        Currently no concerderation for dolby vision MEL or FEL
        


Subtitle

    Syncing
        This will have to be done manually

    Subtitle List
        Order is always dependt on  which order user picks sources

        For each language one subtitle will be picked for that language

        Each source will be checked to see if a new langauge not present in the previous source appears
    Track Name
        None by default

    Determine the subtitles language
        This is currently based on what the bdinfo file says

        So it may or may not be accurate

    Special Tracks
        Commentary subtitles and other special subtitles will most likely be missed

        These will have to be added manually

    Convert text-based subtitles
        If the format is .VTT or another simple text-based format
      
        This is not accomplished yet
    
    Convert image-based subtitles (aka OCR)

        This is not accompished yet
    Tonemap HDR subtitles
        This is not acocmpished 
        yet
    Default Flag

        Regular English-translated subtitles when the official audio is not English.

        Still Needs Work
        All subtitles with the forced flag
        1. Need to Figure out when to use force flag
        2. Would this result in multiple default tracks?
        3. What is the Naming on Forced Tracks


    

        
    
        


