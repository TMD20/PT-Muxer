import os
import tempfile
import re
import shutil

import subtitles.images as subimages
import subtitles.ocr as subocr
import tools.paths as paths
import tools.directory as dir
import tools.logger as logger

def subreader(tracks, maxLines=None, langs=None, keep=False):
    maxLines = maxLines or 51
    if keep:
        ocrHelper(tracks, maxLines, langs)
    else:
        tmpdir=paths.createTempDir() 
        with dir.cwd(tmpdir):
            ocrHelper(tracks, maxLines, langs)

def ocrHelper(tracks, maxLines=None, langs=None, keep=False):
    for track in tracks:
        subLocation=track.getTrackLocation()
        logger.logger.info("\n\nAttempting to OCR: ", subLocation)
        if langs and (track["lang"].lower() not in langs):
            continue
        tmpdir=subimages.getSubImages(subLocation)
        files = os.listdir(tmpdir)
        # if for some reason no images created for OCR
        if len(files) == 0:
            logger.logger.info("Could Not Generate Images for OCR",style="bold red")
            continue
        files = list(
            sorted(files, key=lambda x: int(re.findall(r'\d+', x)[0])))
        files = list(map(lambda x: os.path.join(
            tmpdir, x), files))
        # typical set to 10 at 5 per image, but sometimes might be set to less if not enough lines
        maxLines = min(maxLines, len(files))-1

        lines = subocr.subocr(files[0:maxLines], track["langcode"])
        lastlines = subocr.subocr(files[-1*(min(10,len(files))):], track["langcode"])

        track["machine_parse"] = lines
        track["machine_parse_endlines"] = lastlines
        track["length"] = len(files)


def imagesOnly(tracks):
    logger.logger.info("Generating Subtitle Images\n\n")
    for track in tracks:
        file=track["filename"]
        logger.logger.info(f'Working on: {file}\n\n')

        newDir=subimages.getSubImages(track.getTrackLocation())
        files = os.listdir(newDir)
        # if for some reason no images created
        if len(files) == 0:
            logger.logger.info("Could Not Generate Images for OCR")
            continue
       