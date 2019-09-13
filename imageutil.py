from PIL import Image
import numpy as np
import logging
import ctypes
import os
path = os.path.dirname(os.path.realpath(__file__))
libRLE = ctypes.CDLL(f'{path}/RLE.so')

logging.basicConfig(level = logging.INFO)
logger = logging.getLogger(__name__)

YCrCbA2RGBAxForm = np.array([[255/219, 255/224*1.402, 0, 0],
    [255/219, -255/224*1.402*0.299/0.587, -255/224*1.772*0.114/0.587, 0], 
    [255/219, 0, 255/224*1.772, 0],
    [0, 0, 0, 1]], dtype = np.float)

def YCrCbA2RGBA(YCrCbA):
    RGBA = np.asarray(YCrCbA, dtype = np.float)
    RGBA -= [16, 128, 128, 0]
    RGBA = RGBA.dot(YCrCbA2RGBAxForm.T)
    np.putmask(RGBA, RGBA > 255, 255)
    np.putmask(RGBA, RGBA < 0, 0)
    return np.uint8(RGBA)

def RGBA2YCrCbA(RGBA):
    YCrCbA = np.asarray(RGBA, dtype = np.float)
    YCrCbA = np.linalg.solve(YCrCbA2RGBAxForm.T, YCrCbA)
    YCrCbA += [16, 128, 128, 0]
    np.putmask(YCrCbA[:, :3], YCrCbA < 16, 16)
    np.putmask(YCrCbA[:, 0], YCrCbA[:, 0] > 235, 235)
    np.putmask(YCrCbA[:, 1:3], YCrCbA[:, 1:3] > 240, 240)
    np.putmask(YCrCbA[:, -1] > 255, 255)
    np.putmask(YCrCbA[:, -1] < 0, 0)
    return np.uint8(YCrCbA)

def makeImage(pixelLayer, RGBAPalette):
    alphaLayer = RGBAPalette[pixelLayer, -1]
    alphaImage = Image.fromarray(alphaLayer, mode = 'L')
    pixelImage = Image.fromarray(pixelLayer, mode = 'P')
    pixelImage.putpalette(RGBAPalette[:, :3])
    RGBAImage = pixelImage.convert('RGB')
    RGBAImage.putalpha(alphaImage)
    return RGBAImage

def splitImage(pillowImage):
    RGBAImage = pillowImage.convert('RGBA').quantize(dither = 0)
    width, height = img.size
    pixelLayer = np.array(RGBAImage.getdata(), dtype = np.uint8).reshape(height, width)
    RGBAPalette = np.frombuffer(RGBAImage.palette.palette, dtype = np.uint8).reshape(-1, 4)
    return (pixelLayer, RGBAPalette)

def RLEDecode(RLEData, width = None, height = None):
    if width is not None and height is not None:
        pix = (ctypes.c_byte * width * height)()
        libRLE.RLEDecode(RLEData, len(RLEData), pix, height)
        return np.array(pix, dtype = np.uint8).reshape(height, width)
    else:
        lineBuilder = []
        pixels = []
        offset = 0
        length = len(RLEData)
 
        while offset < length:
            first = RLEData[offset]
            if first:
                entry = first
                repeat = 1
                skip = 1
            else:
                second = RLEData[offset + 1]
                if second == 0:
                    entry = 0
                    repeat = 0
                    pixels.append(lineBuilder)
                    lineBuilder = []
                    skip = 2
                elif second < 64:
                    entry = 0
                    repeat = second
                    skip = 2
                elif second < 128:
                    entry = 0
                    repeat = ((second - 64) << 8) + RLEData[offset + 2]
                    skip = 3
                elif second < 192:
                    entry = RLEData[offset + 2]
                    repeat = second - 128
                    skip = 3
                else:
                    entry = RLEData[offset + 3]
                    repeat = ((second - 192) << 8) + RLEData[offset + 2]
                    skip = 4
            lineBuilder.extend([entry] * repeat)
            offset += skip
 
        if lineBuilder:
            logger.warning(f'[RLE] Hanging pixels without line ending: {lineBuilder}')
 
        return np.array(pixels, dtype = np.uint8)
