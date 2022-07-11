class MediaInfoParser(object):
    """
    Parse MediaInfo
    """

    def parse(self, text):
        """
        Parse mediainfo

        Parameters
        ----------
        text : list
            list of mediainfo lines

        Returns
        -------
        dict mediainfo with 'general', 'video', 'audio', 'text', and 'menu' keys
        """
        mediainfo_sections = ["general", "video", "audio", "text", "menu"]
        # dictionary of lists for mediainfo data
        mediainfo = dict((k, list()) for k in mediainfo_sections)
        # starts at 0 on first loop
        section_index = dict((k, -1) for k in mediainfo_sections)
        # current mediainfo section
        curr_sect = None

        # skip blank lines
        text_list = list(filter(None, text))

        for l in text_list:
            # new section of mediainfo
            section_word = l.strip().split()[0].strip().lower()
            if section_word in mediainfo_sections:
                # track current section
                curr_sect = section_word
                # increment index
                section_index[section_word] += 1
                # store new list for chapters, and new dictionary for other sections
                mediainfo[section_word].append(
                    list() if section_word == "menu" else dict()
                )
                continue

            # split mediainfo data line
            curr = l.split(" : ", 1)

            if curr_sect in ["general", "video", "audio", "text"] and len(curr) >= 2:
                # assign section to dictionary
                mediainfo[curr_sect][section_index[curr_sect]][
                    self.format_key(curr[0])
                ] = curr[1]
            elif curr_sect == "menu":
                mediainfo["menu"][section_index[curr_sect]].append(
                    self.parse_chapter(curr)
                )

        return mediainfo

    def format_key(self, key):
        """
        Format keys into abc_def_ghi

        Parameters
        ----------
        key : str
            mediainfo key

        Returns
        -------
        str formatted mediainfo key
        """
        return (
            key.strip()
            .replace(" ", "_")
            .replace("/", "_")
            .replace("(", "")
            .replace(")", "")
            .replace("*", "_")
            .replace(",", "")
            .lower()
        )

    def parse_chapter(self, curr):
        """
        Parse a single chapter

        Parameters
        ----------
        curr : list
            current line

        Returns
        -------
        dict chapter
        {"time": "...", "titles": [...], "languages": [...]}
        languages list has unique elements
        """
        chapter = {"time": None, "titles": list(), "languages": set()}
        if len(curr) >= 1:
            chapter["time"] = curr[0].strip()
        if len(curr) >= 2:
            chapter_title = {
                "language": None,
                "title": None,
            }
            if " - " in curr[1]:
                langs = curr[1].split(" - ")
                for lang in langs:
                    if ":" in lang:
                        # chapter has a language
                        ch = self.format_chapter(lang)
                        chapter["titles"].append(ch)
                        chapter["languages"].add(ch["language"])
            elif ":" in curr[1]:
                # chapter has a language
                ch = self.format_chapter(curr[1])
                chapter["titles"].append(ch)
                chapter["languages"].add(ch["language"])
            else:
                # no language, just store title
                chapter_title["title"] = curr[1]
                chapter["titles"].append(chapter_title)
        chapter["languages"] = list(chapter["languages"])
        return chapter

    def format_chapter(self, text):
        """
        Format chapter language and title

        Parameters
        ----------
        text : str
            chapter text

        Returns
        -------
        dict chapter with 'language', 'title' keys
        """
        l = text.split(":", 1)
        chapter = {"language": l[0].strip(), "title": l[1]}
        return chapter
