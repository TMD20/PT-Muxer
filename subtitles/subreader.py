import subtitles.images as subimages
import subtitles.ocr as subocr

import os
import tempfile
import re

import time

def subreader(tracks,maxLines=None,langs=None):

    
    
        maxLines=maxLines or 51
        for track in tracks:
            if langs!=None and (track["lang"] not in langs ):
                continue
            
            with tempfile.TemporaryDirectory() as tmpdirname:
                subimages.getSubImages(track["file"],tmpdirname)

                files = os.listdir(tmpdirname)
                files = list(sorted(files, key=lambda x: int(re.findall(r'\d+', x)[0])))
                files = list(map(lambda x: os.path.join(
                    tmpdirname, x), files))
                #typical set to 50, but sometimes might be set to less if not enough lines
                maxLines = max(maxLines,len(files))-1
                lines = subocr.subocr(files[0:maxLines])
                lastline = subocr.subocr([files[-1]])[0]
                lines.append(
                    f"SUBPARSER_LAST_LINE = {lastline}")
                #Add Special Message about last line since that can contain the track dialetic
                track["machine_parse"] = lines
                

      





       
      
       

