import os

from pymediainfo import MediaInfo
import orjson


import remux.helpers as remuxHelper
import sites.pickers.siteMuxPicker as muxPicker
import tools.general as utils
import config

def ProcessBatch(fileName, remuxConfig, muxGenerator, outargs):
    # Variables
    chaptersTemp = remuxHelper.chapterListParser(remuxConfig["ChapterData"])
    xmlTemp = remuxHelper.writeXMLMovie(
        remuxConfig["Movie"]["imdb"], remuxConfig["Movie"]["tmdb"])

    muxGenerator.generateMuxData(remuxConfig, outargs)
    title = remuxConfig['Movie'].get(
        'title') or remuxConfig['Movie'].get('engTitle')
    year = remuxConfig['Movie']['year']
    movieTitle = f"{title} ({year})"
    if chaptersTemp:
        muxGenerator.createMKV(fileName, movieTitle,
                               chaptersTemp[1], xmlTemp[1],  utils.setBdInfo(remuxConfig), utils.getEac3to(remuxConfig))

        os.close(chaptersTemp[0])
    else:
        muxGenerator.createMKV(fileName, title, year,
                               None, xmlTemp[1],  utils.setBdInfo(remuxConfig), utils.getEac3to(remuxConfig))
    os.close(xmlTemp[0])
