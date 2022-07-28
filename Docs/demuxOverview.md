Demux Method
    1. Use BDInfo to generate all playlists:

    2. demux specific playlists and tracks, specify via the command line using eac3to



Lossy audio tracks

        Include -keepDialnorm immediately after the track in the eac3to command line when demuxing lossy tracks (excluding DTS-HD HRA).
        The dialog normalization value is calculated based on the dynamic statistics of the track and is used for improved lossy surround playback on modest systems, helping with dialog intelligibility.  


        """""
        Currently any track that does not contain

        LPCM, TrueHD, DTS-HD MA, DTS:X

        is concered lossly

Lossless Audio
    convert 24bit
        All 24-bit audio (regardless of channels) except for TrueHD must be demuxed as .PCM/.WAVS/.FLAC using eac3to to check if it is padded with zeroes or not.

        ###
        This is accomplished during the picking of the eac3to filename
        No conceration for correct endianness or -little/-big flag.

    convert 2.0< Tracks
        best audio track has 2 channels or less and is encoded with a lossless codec (e.g. DTS-HD MA 2.0 or LPCM):

        It must be converted to FLAC

        ###
        This is accomplished during the picking of the eac3to filename
        No conceration for correct endianness or -little/-big flag.
    convert 2.0>

        if the best audio track has more than 2 channels and is encoded with a lossless uncompressed codec (e.g. LPCM or WAVs from a previous step):

        It must be converted to either DTS-HD MA or TrueHD using DTS Master Audio Suite or Dolby Media Producer Suite.

        ###
        This most be done manually and not part of the program yet


    TrueHD
        If demuxing the TrueHD track separately rather than with the -demux flag, use either .thd+ac3 or .* to ensure BD-compliance.

        #########
        This is accomplish by having each track have a predetermined filename set by the program


Dual Mono Tracks
    This is not accomplished and must be done manually


    
Demux UHDBDs
    Eac3to does not support UHDBDs with seamless branching (See: http://bugs.madshi.net/view.php?id=542).
    In most cases, MakeMKV can be used instead if eac3to does not work.
    In some cases, DGDemux must be used for the most accurate demux.
    MakeMKV is currently the only program that supports Dolby Vision (as of April 2021).

    """
    This Feature is not supported Yet