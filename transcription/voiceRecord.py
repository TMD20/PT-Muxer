#!/usr/bin/env python3
from pathlib import Path
import traceback

import transcription.transcriper as transcriberClass
import tools.logger as logger
import config as config





def main(tracks,maxLines=None,langs=None,model=None,model_name=None):
    maxLines = maxLines or config.maxVoiceLineCount +1
 

    for track in tracks:
        logger.logger.info("\n\nAttempting Transcription of: ", track["filename"])
        if langs and (track["lang"].lower() not in langs):
            continue
        langcode={
        "en":"en-us",
        "zh":"cn",
        "el":"el-gr",
        "vi":"vn",
        "fil":"tl-ph",
        "kk":"kz"
        }.get(track["langcode"], track["langcode"])
        transcriber=None

    

        try:
            transcriber = transcriberClass.Transcriber(model,model_name,langcode)
        except Exception as E:
            logger.print(traceback.format_exc(),style="white")
            logger.print(E)
            continue
        
        task_list = [Path(track.getTrackLocation())]
    
        
        

        result=transcriber.process_task_list(task_list,maxLines)
        track["machine_parse"] = result



