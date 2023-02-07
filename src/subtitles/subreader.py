import os
import re

import src.subtitles.image as subimages
import src.subtitles.ocr as subocr
import src.tools.paths as paths
import src.tools.directory as dir
import src.tools.logger as logger
import config as config


def subreader(tracks, maxLines=None, langs=None, keep=None):
    """
    Function for keeping subtitle images if needed
    actual processing handled by ocrhelper
   

    Args:
        tracks (str): list of tracks
        maxLines (int, optional): max number of lines to perfrom ocr. Defaults to None.
        langs (array, optional): array of languages to enable for ocr. Defaults to None.
        keep (bool, optional): whether to keep generated subtitle images. Defaults to None.
    """
    maxLines = maxLines or config.MAXOCRLINECOUNT + 1
    if keep:
        _ocrHelper(tracks, maxLines, langs)
    else:
        with dir.cwd(paths.createTempDir()):
            _ocrHelper(tracks, maxLines, langs)


def _ocrHelper(tracks, maxLines, langs):
    """
    Takes a list of tracks generates subtitle images
    performs ocr on images if applicable 

    Args:
        tracks (str): list of tracks
        maxLines (int): max number of lines to perfrom ocr on
        langs (array): list of languages to enable for ocr
    """
    for track in tracks:
        subLocation = track.getTrackLocation()
        logger.logger.info("\n\nAttempting to OCR: ", subLocation)
        if langs and (track["lang"].lower() not in langs):
            continue
        tmpdir = subimages.getSubImages(subLocation)
        files = os.listdir(tmpdir)
        # if for some reason no images created for OCR
        if len(files) == 0:
            logger.logger.info(
                "Could Not Generate Images for OCR", style="bold red")
            continue
        files = list(
            sorted(files, key=lambda x: int(re.findall(r'\d+', x)[0])))
        files = list(map(lambda x: os.path.join(
            tmpdir, x), files))
        # typical set to 10 at 5 per image, but sometimes might be set to less if not enough lines
        maxLines = min(maxLines, len(files))-1

        lines = subocr.subocr(files[0:maxLines], track["langcode"])
        lastlines = subocr.subocr(
            files[-1*(min(10, len(files))):], track["langcode"])

        track["machine_parse"] = lines
        track["machine_parse_endlines"] = lastlines
        track["length"] = len(files)


def imagesOnly(tracks):
    """
    Function to only generate subtitle images without any ocr

    Args:
        tracks (array): list of tracks to generate images for
    """
    logger.logger.info("Generating Subtitle Images\n\n")
    for track in tracks:
        file = track["filename"]
        logger.logger.info(f'Working on: {file}\n\n')

        newDir = subimages.getSubImages(track.getTrackLocation())
        files = os.listdir(newDir)
        # if for some reason no images created
        if len(files) == 0:
            logger.logger.info("Could Not Generate Images for OCR")
            continue
