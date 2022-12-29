import re
import os


import tools.general as utils
from sites.base.siteMuxData import MuxOBj
import mediatools.mkvtoolnix as mkvTool
import mediadata.movieData as movieData


class AnimeBytes(MuxOBj):
    def __init__(self):
        super().__init__()
