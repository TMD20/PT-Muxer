#!/usr/bin/env python3
from pathlib import Path
import os
import traceback
from typing import Any,List,Union

import src.transcription.transcriper as transcriberClass
import src.tools.logger as logger
import config as config


def main(tracks:List[dict], maxLines:int=None, langs:str=None, model:Union[str, bytes, os.PathLike]=None, model_name:str=None):
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
            logger.print(traceback.format_exc(), style="white")
            logger.print(E)
            continue

        task_list = [Path(track.getTrackLocation())]

        result = transcriber.process_task_list(task_list, maxLines)
        track["machine_parse"] = result
