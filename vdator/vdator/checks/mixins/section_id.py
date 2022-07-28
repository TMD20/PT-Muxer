class SectionId(object):
    def _section_id(self, section, i):
        reply = ""
        if "id" in self.mediainfo[section.lower()][i]:
            reply += "#" + self.mediainfo[section.lower()][i]["id"]
        else:
            reply += str(i)
        return reply
