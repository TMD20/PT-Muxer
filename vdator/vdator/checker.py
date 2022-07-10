from dotenv import load_dotenv
import logging, os

# # load environment variables
# load environment variables
load_dotenv()
# TMDb API
import tmdbsimple as tmdb

tmdb.API_KEY = os.environ.get("TMDB_API_KEY")

# IMDb API
from imdb import IMDb

ia = IMDb()
logger = logging.getLogger("imdbpy")
logger.disabled = True

# # checks
from checks.mixins import PrintHeader, SectionId, IsCommentaryTrack
from checks.remove_until_first_codec import RemoveUntilFirstCodec
from checks import *

# nltk data
from nltk_people import download_nltk_data

download_nltk_data()


class Checker(PrintHeader, SectionId, IsCommentaryTrack):
    def __init__(self, codecs_parser, source_detector, reporter):
        self.codecs = codecs_parser
        self.remove_until_first_codec = RemoveUntilFirstCodec(codecs_parser)
        self.source_detector = source_detector
        self.reporter = reporter

    def setup(self, bdinfo, mediainfo, eac3to):
        self.bdinfo = bdinfo
        self.mediainfo = mediainfo
        self.eac3to = eac3to
        self.source_detector.setup(bdinfo, mediainfo)

    def run_checks(self):
        reply = ""

        
    

    #     # check metadata
        reply += self._print_header("Metadata")
        reply += CheckMovieNameFormat(self.reporter, self.mediainfo).run()
        reply += CheckMetadataIds(self.reporter, self.mediainfo, tmdb, ia).run()
        reply += CheckFilename(
            self.reporter,
            self.source_detector,
            self.codecs,
            self.remove_until_first_codec,
            self.mediainfo,
            self.bdinfo,
        ).run()

        reply += CheckTracksHaveLanguage(self.reporter, self.mediainfo).run()
        reply += CheckVideoLanguageMatchesFirstAudioLanguage(
            self.reporter, self.mediainfo
        ).run()
        reply += CheckMuxingMode(self.reporter, self.mediainfo).run()
        reply += CheckMKVMerge(self.reporter, self.mediainfo).run()
        reply += CheckMetadataDefaultFlag(self.reporter, self.mediainfo).run()

        # check video
        reply += self._print_header("Video & Audio Tracks")
        reply += CheckVideoTrack(
            self.reporter,
            self.source_detector,
            self.codecs,
            self.mediainfo,
            self.bdinfo,
        ).run()

        # check audio
        reply += CheckPrintAudioTrackNames(self.reporter, self.mediainfo).run()
        reply += CheckAudioTrackConversions(
            self.reporter,
            self.source_detector,
            self.remove_until_first_codec,
            self.mediainfo,
            self.bdinfo,
            self.eac3to,
        ).run()
        # check FLAC audio using mediainfo
        reply += CheckFLACAudioTracks(
            self.reporter, self.remove_until_first_codec, self.mediainfo
        ).run()

        # TMDb and IMDb People API
        reply += CheckAudioTrackPeople(
            self.reporter, self.remove_until_first_codec, self.mediainfo, tmdb, ia
        ).run()
        reply += CheckAudioTrackSpellCheck(
            self.reporter, self.remove_until_first_codec, self.mediainfo
        ).run()

        # check text
        reply += self._print_header("Text Tracks")
        reply += CheckPrintTextTracks(self.reporter, self.mediainfo).run()
        reply += CheckTextOrder(self.reporter, self.mediainfo).run()
        reply += CheckTextDefaultFlag(self.reporter, self.mediainfo).run()

        # check chapters
        reply += CheckPrintChapters(self.reporter, self.mediainfo).run()
        reply += CheckHasChapters(self.reporter, self.mediainfo, self.eac3to).run()
        reply += CheckChapterLanguage(self.reporter, self.mediainfo).run()
        reply += CheckChapterPadding(self.reporter, self.mediainfo).run()

        return reply
