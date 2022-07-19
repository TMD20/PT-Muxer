 
import queue
import itertools
import concurrent
import concurrent.futures
from timeit import default_timer as timer

import tesserocr
import easyocr
from PIL import Image
import langcodes



NUM_THREADS = 4
ocr_queue = queue.Queue()


def perform_ocr(img):

    ocr_obj = ocr_queue.get(block=True, timeout=300)
    if isinstance(ocr_obj, easyocr.easyocr.Reader):
        try:
            return ocr_obj.readtext(img, detail=0)
         
        except queue.Empty:
            print('Empty exception caught!')
            return None
        finally:
            if ocr_obj is not None:
                ocr_queue.put(ocr_obj)

    else:
        try:
            img = Image.open(img)
            ocr_obj.SetImage(img)
            return [ocr_obj.GetUTF8Text()]
        except queue.Empty:
                print('Empty exception caught!')
                return None
        finally:
            if ocr_obj is not None:
                ocr_queue.put(ocr_obj)
    
 
 
def subocr(files,langcode):
        start_time = timer()
        for _ in range(NUM_THREADS):
            ocr_queue.put(getocr_obj(langcode)) 
        if ocr_queue.queue[0]==None:
            return ["Language Not Supported"]
        with concurrent.futures.ThreadPoolExecutor(max_workers=4) as executor:
            res=executor.map(perform_ocr, files)
            
 
        output=[]
        for r in res:
            output.append(r)
        ocr_queue.queue.clear()
        elapsed = timer() - start_time
        print(f"Execution Time {elapsed } seconds")
        return list(list(itertools.chain.from_iterable(output)))
def getocr_obj(langcode):

    try:
        return easyocr.Reader([langcode],gpu=False)
    except:
        None
    try:
        return tesserocr.PyTessBaseAPI(path="/usr/share/tesseract-ocr/5/tessdata", lang=langcodes.Language.get(langcode).to_alpha3())
    except:
        None
    return None