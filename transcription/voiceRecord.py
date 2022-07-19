#!/usr/bin/env python3

import logging
from pathlib import Path

import transcription.transcriper as transcriberClass



def main(tracks,maxLines=None,langs=None,model=None,model_name=None):
    logging.getLogger().setLevel("INFO")
    maxLines=maxLines or 51
 

    for track in tracks:
        print("\n\nAttempting to Transcription of: ", track["file"])
        if langs!=None and (track["lang"] not in langs):
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
        except:
            continue
        
        task_list = [Path(track["file"])]
    
        
        

        result=transcriber.process_task_list(task_list,maxLines)
        track["machine_parse"] = result



