class CodecsParser(object):
    """
    Define codecs
    """

    def __init__(self, codecs):
        """
        Define codecs

        Parameters
        ----------
        codecs : dict
          codec definitions
        """

        """
        {
          "codecs": {
            "video": {...},
            "audio": {...},
            "subtitles": {...},
            "chapters": {...}
          },
          "track_titles": {
            "video": {...},
            "audio": {...}
          },
          "scan_types": {...}
        }
        """
        self.codecs = codecs

        # map of all codec names to extensions
        self.codec_ext = {
            **self.codecs["codecs"]["video"],
            **self.codecs["codecs"]["audio"],
            **self.codecs["codecs"]["subtitles"],
            **self.codecs["codecs"]["chapters"],
        }

    def is_video(self, codec):
        """
        Is this a video codec?

        Parameters
        ----------
        codec : str
          codec

        Returns
        -------
        True if codec is a video codec, False otherwise.
        """
        if codec in self.codecs["codecs"]["video"]:
            return True
        return False

    def is_video_title(self, codec):
        """
        Is this a video title codec?

        Parameters
        ----------
        codec : str
          codec

        Returns
        -------
        True if codec is a video title codec, False otherwise.
        """
        if codec in self.codecs["track_titles"]["video"]:
            return True
        return False

    def is_video_3d(self, codec):
        """
        Is this a 3d video codec?

        Parameters
        ----------
        codec : str
          codec

        Returns
        -------
        True if codec is a 3d video, False otherwise.
        """
        if codec in self.codecs["codecs"]["video_3d"]:
            return True
        return False

    def is_audio(self, codec):
        """
        Is this an audio codec?

        Parameters
        ----------
        codec : str
          codec

        Returns
        -------
        True if codec is an audio codec, False otherwise.
        """
        if codec in self.codecs["codecs"]["audio"]:
            return True
        return False

    def is_audio_title(self, codec):
        """
        Is this an audio title codec?

        Parameters
        ----------
        codec : str
          codec

        Returns
        -------
        True if codec is an audio title codec, False otherwise.
        """
        if codec in self.codecs["track_titles"]["audio"]:
            return True
        return False

    def is_sub(self, codec):
        """
        Is this a subtitle codec?

        Parameters
        ----------
        codec : str
          codec

        Returns
        -------
        True if codec is a subtitle codec, False otherwise.
        """
        if codec in self.codecs["codecs"]["subtitles"]:
            return True
        return False

    def is_chapter(self, codec):
        """
        Is this a chapter codec?

        Parameters
        ----------
        codec : str
          codec

        Returns
        -------
        True if codec is a chapter codec, False otherwise.
        """
        if codec in self.codecs["codecs"]["chapters"]:
            return True
        return False

    def is_codec(self, codec):
        """
        Is this a valid codec?

        Parameters
        ----------
        codec : str
          codec

        Returns
        -------
        True if valid codec, False otherwise.
        """
        return codec in self.codec_ext

    def get_codec_ext(self, codec):
        """
        Get codec extension. Checks if codec is valid.

        Parameters
        ----------
        codec : str
          codec

        Returns
        -------
        str codec extension
        """
        if codec not in self.codec_ext:
            return ""
        return self.codec_ext[codec]

    def get_video_codec_title_name(self, codec):
        """
        Get name of video codec for title. Checks if video codec is valid.

        Parameters
        ----------
        codec : str
          codec

        Returns
        -------
        str codec title name
        """
        if codec not in self.codecs["track_titles"]["video"]:
            return ""
        return self.codecs["track_titles"]["video"][codec]

    def get_audio_codec_title_name(self, codec):
        """
        Get name of audio codec for title. Checks if audio codec is valid.

        Parameters
        ----------
        codec : str
          codec

        Returns
        -------
        str codec title name
        """
        if codec not in self.codecs["track_titles"]["audio"]:
            return ""
        return self.codecs["track_titles"]["audio"][codec]

    def get_scan_type_title_name(self, scan_type, video_fps):
        """
        Get name of video scan type for title. Checks if scan type is valid.

        Parameters
        ----------
        scan_type : str
          scan type

        video_fps : str
          frame rate

        Returns
        -------
        str scan type title name, boolean if actually progressive
        """
        actually_progressive = False
        scan_type = scan_type.strip().lower()

        if len(scan_type) >= 1:
            scan_type = "progressive" if scan_type[0] == "p" else "interlaced"

        # interlaced @ 25fps is actually progressive
        # but it's still called interlaced
        if scan_type == "interlaced" and int(video_fps) == 25:
            actually_progressive = True

        if scan_type not in self.codecs["scan_types"]:
            return "", actually_progressive
        return self.codecs["scan_types"][scan_type], actually_progressive
