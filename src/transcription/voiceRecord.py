#!/usr/bin/env python3
from pathlib import Path
import traceback

import src.transcription.transcriper as transcriberClass
import src.tools.logger as logger
import src.tools.general as utils
import config as config


def main(tracks, maxLines=None, langs=None, model=None, model_name=None):
    """
    Uses transcriper to add transcription to tracks dictionary 
    optionally

    Args:
        tracks (array): list of track dicts
        maxLines (int, optional):Number of lines to transcribe. Defaults to None
        langs (array, optional): list of languages to enavble transcripition on 
        model (str, optional): vosk variable for which model to use. Defaults to None.
        model_name (_type_, optional):vosk variable for name of which mode use. Defaults to None.
    """
    maxLines = maxLines or config.maxVoiceLineCount + 1

    for track in tracks:
        logger.logger.info(
            "\n\nAttempting Transcription of: ", track["filename"])
        if langs and (track["lang"].lower() not in langs):
            continue
        langcode = {
            "en": "en-us",
            "zh": "cn",
            "el": "el-gr",
            "vi": "vn",
            "fil": "tl-ph",
            "kk": "kz"
        }.get(track["langcode"], track["langcode"])
        transcriber = None

        try:
            transcriber = transcriberClass.Transcriber(
                model, model_name, langcode)
        except Exception as E:
            utils.tracebackhelper(traceback.format_exc(),E)
            continue

        task_list = [Path(track.getTrackLocation())]

        result = transcriber.process_task_list(task_list, maxLines)
        track["machine_parse"] = result
