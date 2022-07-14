 
import queue
import tesserocr
import concurrent
import concurrent.futures
from PIL import Image

NUM_THREADS = 4

tesserocr_queue = queue.Queue()


def perform_ocr(img):
    tess_api = None
    try:
        tess_api = tesserocr_queue.get(block=True, timeout=300)
        img = Image.open(img)
        tess_api.SetImage(img)
        text = tess_api.GetUTF8Text()
        text = text.replace("\n","")
        return text
    except queue.Empty:
        print('Empty exception caught!')
        return None
    finally:
        if tess_api is not None:
            tesserocr_queue.put(tess_api)

 
 
 
 
 
def subocr(files):
        for _ in range(NUM_THREADS):
            tesserocr_queue.put(tesserocr.PyTessBaseAPI())
        with concurrent.futures.ThreadPoolExecutor(max_workers=4) as executor:
            res=executor.map(perform_ocr, files[0:50])
        #   return  
        output=[]
        for r in res:
            output.append(r)
        return output
       
