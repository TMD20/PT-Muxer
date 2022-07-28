class IsCommentaryTrack(object):
    def _is_commentary_track(self, title):
        return "commentary" in title.lower().split()
