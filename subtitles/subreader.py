import os
import tempfile
import re
import shutil

import subtitles.images as subimages
import subtitles.ocr as subocr
import tools.paths as paths
def subreader(tracks, maxLines=None, langs=None, keep=False):
    maxLines = maxLines or 51
    if keep:
        os.mkdir("subImages")
    for track in tracks:
        print("\n\nAttempting to OCR: ", track["file"])
        if langs and (track["lang"].lower() not in langs):
            continue
        with tempfile.TemporaryDirectory() as tmpdirname:
            subimages.getSubImages(track["file"], tmpdirname)
            files = os.listdir(tmpdirname)
            # if for some reason no images created for OCR
            if len(files) == 0:
                print("Could Not Generate Images for OCR")
                continue
            files = list(
                sorted(files, key=lambda x: int(re.findall(r'\d+', x)[0])))
            files = list(map(lambda x: os.path.join(
                tmpdirname, x), files))
            # typical set to 10 at 5 per image, but sometimes might be set to less if not enough lines
            maxLines = min(maxLines, len(files))-1

            lines = subocr.subocr(files[0:maxLines], track["langcode"])
            lastlines = subocr.subocr(files[-1*(min(10,len(files))):], track["langcode"])

            track["machine_parse_start"] = lines
            track["machine_parse_final"] = lastlines
            track["length"] = len(files)
            if keep:
                file = track["eac3to"].split(":")[1]
                newDir = f"./subImages/{file}"
                os.mkdir(newDir)
                for file in os.listdir(tmpdirname):
                    shutil.move(os.path.join(tmpdirname, file), newDir)
def imagesOnly(tracks):
    print("Generating Subtitle Images\n\n")
    for track in tracks:
        file=track["file"]
        print(f'Working on: {file}\n\n')
        file = track["eac3to"].split(":")[1]
        newDir = os.path.join(os.path.abspath(f"./subImages"),f"{file}/")
        paths.mkdirSafe(newDir)
        
        subimages.getSubImages(track["file"], newDir)
        files = os.listdir(newDir)
        # if for some reason no images created
        if len(files) == 0:
            print("Could Not Generate Images for OCR")
            continue
       