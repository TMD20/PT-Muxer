from .check import *
from .mixins import IsCommentaryTrack, SectionId

from collections import OrderedDict


class CheckTextOrder(Check, IsCommentaryTrack, SectionId):
    """
    Checks text track order:
    Languages are in alphabetical order with English first
    Within language: No title, SDH, alphabetical
    Commentary subtitles after regular subtitles
    """

    def __init__(self, reporter, mediainfo):
        super().__init__(
            reporter,
            mediainfo,
            "Error checking text track order",
        )

    # overriding abstract method
    def get_reply(self):
        reply = ""

        if len(self.mediainfo["text"]) == 0:
            return reply

        # text_langs = ['German', 'English', ...]
        text_langs = [text["language"] for text in self.mediainfo["text"]]
        # remove duplicates from list and preserve order
        text_langs = list(dict.fromkeys(text_langs))

        # list of text tracks by language
        #
        # OrderedDict([
        #   ('English', [{}, ...]), ('German', [{}, ...])
        # ])
        #
        text_tracks_by_lang = OrderedDict((k, list()) for k in text_langs)
        commentary_tracks_by_lang = OrderedDict((k, list()) for k in text_langs)
        has_commentary = False

        # get tracks by language, and separate commentary tracks
        for i, text in enumerate(self.mediainfo["text"]):
            text["title"] = text["title"] if "title" in text else ""
            if self._is_commentary_track(text["title"]):
                commentary_tracks_by_lang[text["language"]].append(text)
                has_commentary = True
            else:
                text_tracks_by_lang[text["language"]].append(text)
            # forced english track should be first
            reply += self._forced_english_track_first(i, text)

        # languages should be in alphabetical order with English first
        reply += self._languages_in_order(text_tracks_by_lang, "Regular subs: ")
        if has_commentary:
            reply += self._languages_in_order(
                commentary_tracks_by_lang, "Commentary subs: "
            )

        # subtitles in order within language: no title, SDH, rest in alphabetical order
        reply += "**Expected order within language:** No title, SDH, alphabetical\n"
        reply += self._subs_in_order_within_language(
            text_tracks_by_lang, "Regular subs: "
        )
        if has_commentary:
            reply += self._subs_in_order_within_language(
                commentary_tracks_by_lang, "Commentary subs: "
            )

        # commentary tracks should be after regular subs
        if has_commentary:
            reply += self._commentary_last(
                text_tracks_by_lang, commentary_tracks_by_lang
            )

        return reply

    def _forced_english_track_first(self, i, text_track):
        """
        Forced english track should be first
        Only checks tracks without titles, since titles have a predefined order: No title, SDH, alphabetical
        """
        reply = ""

        is_forced_track = (
            text_track["forced"].lower() == "yes" if "forced" in text_track else False
        )
        is_english_track = text_track["language"].lower() == "english"
        # only checks tracks without titles
        title_is_blank = text_track["title"] == ""
        is_first_track = i == 0

        if (
            is_forced_track
            and is_english_track
            and title_is_blank
            and not is_first_track
        ):
            # forced english track should be first
            reply += self.reporter.print_report(
                "error",
                "Text {} is a forced English track, it should be first".format(
                    self._section_id("text", i)
                ),
            )

        return reply

    def _languages_in_order(self, text_tracks_by_lang, prefix=""):
        """Languages should be in alphabetical order with English first"""
        reply = ""
        text_track_langs_order = list(text_tracks_by_lang.keys())
        text_track_langs_expected_order = self._sort_sub_langs(text_track_langs_order)

        if text_track_langs_expected_order == text_track_langs_order:
            reply += self.reporter.print_report(
                "correct",
                prefix + "Languages are in alphabetical order with English first",
            )
        else:
            reply += self.reporter.print_report(
                "error",
                prefix
                + "Languages should be in alphabetical order with English first. Expected: `"
                + ", ".join(text_track_langs_expected_order)
                + "`",
            )

        return reply

    def _commentary_last(self, text_tracks_by_lang, commentary_tracks_by_lang):
        """Commentary tracks should be last"""
        reply = ""

        if len(commentary_tracks_by_lang) > 0:
            last_text_id = self._get_last_text_id(text_tracks_by_lang)
            if last_text_id != -1:
                try:
                    first_commentary = next(iter(commentary_tracks_by_lang.values()))
                    if first_commentary and has(first_commentary, "0.id"):
                        try:
                            if last_text_id > int(first_commentary[0]["id"]):
                                # commentary tracks should be after regular subs
                                reply += self.reporter.print_report(
                                    "error",
                                    "Commentary subs should be after regular subs",
                                )
                            else:
                                # commentary tracks are after regular subs
                                reply += self.reporter.print_report(
                                    "correct",
                                    "Commentary subs are after regular subs",
                                )
                        except ValueError:
                            pass
                except StopIteration:
                    pass

        return reply

    def _subs_in_order_within_language(self, text_tracks_by_lang, prefix=""):
        """
        Subtitles in order within language
        No title, SDH, rest in alphabetical order
        """
        reply = ""
        for k, v in text_tracks_by_lang.items():
            # k = 'English'
            # v = tracks list [{}, ...]

            v_ids = [track["id"] for track in v]
            expected_order = self._sort_subs_within_lang(v)
            expected_order_ids = [track["id"] for track in expected_order]

            if v_ids != expected_order_ids:
                # subs for language are out of order
                reply += self.reporter.print_report(
                    "warning",
                    prefix
                    + "Language: `{}`: Subtitles should be in order: `{}`".format(
                        k, ", ".join(expected_order_ids)
                    ),
                )

        return reply

    def _get_last_text_id(self, text_tracks_by_lang):
        """Get track id of last subtitle"""
        last_text_id = -1
        for _, tracks in text_tracks_by_lang.items():
            for track in tracks:
                try:
                    curr_text_id = int(track["id"])
                    if curr_text_id > last_text_id:
                        last_text_id = curr_text_id
                except ValueError:
                    continue
        return last_text_id

    def _sort_sub_langs(self, languages):
        """
        Sort subs by language
        English first, rest in alphabetical order
        """
        # English tracks first
        tracks = [lang for lang in languages if lang.lower() == "english"]
        # rest of the tracks by language in alphabetical order
        rest = sorted([lang for lang in languages if lang.lower() != "english"])

        # add the rest of the tracks
        if rest:
            tracks.extend(rest)

        return tracks

    def _sort_subs_within_lang(self, text_tracks):
        """
        Sort subtitles within languages
        No title, SDH, rest in alphabetical order
        """
        # ['', 'SDH', '...']
        unparsed = text_tracks.copy()
        parsed = []

        # add tracks with no title
        for track in unparsed:
            if track["title"] == "":
                parsed.append(track)
        unparsed = [track for track in unparsed if track["title"] != ""]

        # add tracks with SDH
        tracks_with_SDH = []
        for track in unparsed:
            if "SDH" in track["title"].split():
                tracks_with_SDH.append(track)
        tracks_with_SDH = sorted(tracks_with_SDH, key=lambda track: track["title"])
        if tracks_with_SDH:
            parsed.extend(tracks_with_SDH)
            unparsed = [
                track for track in unparsed if ("SDH" not in track["title"].split())
            ]

        # sort rest of the tracks in alphabetical order
        unparsed = sorted(unparsed, key=lambda track: track["title"])

        # add the rest of the tracks
        if unparsed:
            parsed.extend(unparsed)

        return parsed
