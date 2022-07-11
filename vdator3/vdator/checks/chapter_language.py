from .check import *

from iso639 import languages as iso639_languages
from langdetect import detect as langdetect_detect, DetectorFactory

# make language detection deterministic
DetectorFactory.seed = 0


class CheckChapterLanguage(Check):
    def __init__(self, reporter, mediainfo):
        super().__init__(reporter, mediainfo, "Error checking chapter language")

    # overriding abstract method
    def get_reply(self):
        reply = ""

        if "menu" in self.mediainfo and len(self.mediainfo["menu"]) > 0:
            if len(self.mediainfo["menu"]) >= 1:
                for i, chapters in enumerate(self.mediainfo["menu"]):
                    if len(chapters) >= 1:
                        # chapter numbers that have an invalid language
                        invalid_ch_lang_nums = list()
                        # chapters = list of chapters
                        # [{'time': '...', 'titles': [{'language': '...', 'title': '...'}, ...], 'languages': ['...', '...']}]
                        # {'time': '...', 'titles': [{'language': '...', 'title': '...'}, ...], 'languages': ['...', '...']}
                        ch_0 = chapters[0]
                        # concatenate all chapter titles into phrases
                        # ch_0["languages"] = ['...', '...']
                        # chapter_phrases = {'de': '...', 'en': '...'}
                        chapter_phrases = {k: "" for k in ch_0["languages"]}
                        # list of detected languages with chapter languages as keys
                        # chapter_langs = {'de': [...], 'en': [...]}
                        chapter_langs = {k: list() for k in ch_0["languages"]}

                        for ch in chapters:
                            for j, lang in enumerate(ch["languages"]):
                                if lang:
                                    try:
                                        ch_lang = iso639_languages.get(part1=lang)
                                        # store chapter language
                                        chapter_langs[lang].append(ch_lang)
                                    except KeyError:
                                        # store invalid chapter number
                                        invalid_ch_lang_nums.append(str(j + 1))
                                else:
                                    # store invalid chapter number
                                    invalid_ch_lang_nums.append(str(j + 1))

                            for title in ch["titles"]:
                                # store as key "NA" if there is no chapter language set
                                if title["language"] is None:
                                    title["language"] = "NA"
                                if title["language"] not in chapter_phrases:
                                    chapter_phrases[title["language"]] = ""
                                chapter_phrases[title["language"]] += (
                                    title["title"] + "\n"
                                )

                        if len(invalid_ch_lang_nums) > 0:
                            if len(invalid_ch_lang_nums) == len(chapters):
                                reply += self.reporter.print_report(
                                    "error",
                                    f"Chapters {i + 1}: All chapters do not have a language set",
                                )
                            elif len(invalid_ch_lang_nums) > 0:
                                reply += self.reporter.print_report(
                                    "error",
                                    f"Chapters {i + 1}: The following chapters do not have a language set: `"
                                    + ", ".join(invalid_ch_lang_nums)
                                    + "`",
                                )
                            else:
                                reply += self.reporter.print_report(
                                    "correct",
                                    f"Chapters {i + 1}: All chapters have a language set",
                                )

                        for k, chapter_phrase in chapter_phrases.items():
                            if k == "NA":
                                reply += self.reporter.print_report(
                                    "error",
                                    f"Chapters {i + 1}: No chapter language set",
                                )
                                continue
                            if chapter_phrase:
                                chapter_langs[k] = list(set(chapter_langs[k]))
                                try:
                                    detected_lang = langdetect_detect(chapter_phrase)
                                    ch_detected_lang = iso639_languages.get(
                                        part1=detected_lang
                                    )
                                    if ch_detected_lang in chapter_langs[k]:
                                        reply += self.reporter.print_report(
                                            "correct",
                                            f"Chapters {i + 1}: Language matches detected language: `"
                                            + ch_detected_lang.name
                                            + "`",
                                        )
                                    else:
                                        chapter_langs_names = ", ".join(
                                            list(
                                                set(
                                                    [
                                                        detected_lang.name
                                                        for detected_lang in chapter_langs[
                                                            k
                                                        ]
                                                    ]
                                                )
                                            )
                                        )
                                        if chapter_langs_names:
                                            reply += self.reporter.print_report(
                                                "error",
                                                f"Chapters {i + 1}: Languages: `"
                                                + chapter_langs_names
                                                + "` do not match detected language: `"
                                                + ch_detected_lang.name
                                                + "`",
                                            )
                                        else:
                                            reply += self.reporter.print_report(
                                                "error",
                                                f"Chapters {i + 1}: No chapter languages. Detected language: `"
                                                + ch_detected_lang.name
                                                + "`",
                                            )
                                except KeyError:
                                    reply += self.reporter.print_report(
                                        "warning", "Could not detect chapters language"
                                    )
            else:
                reply += self.reporter.print_report(
                    "error", "Must have at least 1 chapter menu"
                )

        return reply
