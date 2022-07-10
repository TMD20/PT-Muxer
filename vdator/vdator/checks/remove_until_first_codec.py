class RemoveUntilFirstCodec(object):
    def __init__(self, codecs):
        self.codecs = codecs

    def remove(self, title):
        title2, title_parts, found = title, list(), False
        if " / " in title:
            for part in title.split(" / "):
                if self.codecs.is_audio_title(part):
                    # stop when we get first codec
                    found = True
                    break
                else:
                    title2_split = title2.split(" / ")
                    # remove part since its not a codec
                    title2 = " / ".join(title2_split[1:]).strip()
                    # save part in list
                    title_parts.append(title2_split[0])
            
        return title2, title_parts, found
