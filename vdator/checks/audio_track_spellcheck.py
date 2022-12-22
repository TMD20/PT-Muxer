from .check import *
from .mixins import SectionId

from dotenv import load_dotenv
import nltk
from nltk_people import extract_names
import hunspell, os, string

# load environment variables
load_dotenv()

HUNSPELL_LANG = [x.strip() for x in os.environ.get("HUNSPELL_LANG").split(",")]
MISSPELLED_IGNORE_LIST = [
    x.strip() for x in os.environ.get("MISSPELLED_IGNORE_LIST").split(",")
]


class CheckAudioTrackSpellCheck(Check, SectionId):
    def __init__(self, reporter, remove_until_first_codec, mediainfo):
        super().__init__(reporter, mediainfo, "Error spell checking audio track names")
        self.hobj = hunspell.HunSpell(HUNSPELL_LANG[0], HUNSPELL_LANG[1])
        self.remove_until_first_codec = remove_until_first_codec

    # overriding abstract method
    def get_reply(self):
        reply = ""

        # spellcheck audio track names
        for i, _ in enumerate(self.mediainfo["audio"]):
            if "title" in self.mediainfo["audio"][i]:
                title, title_parts, found_codec = self.remove_until_first_codec.remove(
                    self.mediainfo["audio"][i]["title"]
                )

                # spellcheck title parts before codec or entire audio title
                spellcheck_text = " ".join(title_parts) if found_codec else title
                if spellcheck_text:
                    # map punctuation to space
                    translator = str.maketrans(
                        string.punctuation, " " * len(string.punctuation)
                    )
                    spellcheck_text = spellcheck_text.translate(translator)

                    # ignore names
                    ignore_list = extract_names(spellcheck_text)
                    ignore_list = [a for b in ignore_list for a in b.split()]

                    # tokenize
                    tokens = nltk.word_tokenize(spellcheck_text)
                    tokens = [t for t in tokens if t not in ignore_list]

                    misspelled_words = list()
                    for t in tokens:
                        if not self.hobj.spell(t):
                            # t is misspelled
                            misspelled_words.append(t)

                    misspelled_words = set(misspelled_words)
                    misspelled_words = [
                        word
                        for word in misspelled_words
                        if word.lower() not in MISSPELLED_IGNORE_LIST
                    ]
                    if len(misspelled_words) > 0:
                        reply += self.reporter.print_report(
                            "error",
                            "Audio "
                            + self._section_id("audio", i)
                            + " Misspelled: `"
                            + ", ".join(misspelled_words)
                            + "`",
                        )

        return reply
