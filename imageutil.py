from PIL import Image
import numpy as np
import logging
import ctypes
import os
from itertools import groupby
path = os.path.dirname(os.path.realpath(__file__))
libRL = ctypes.CDLL(f'{path}/RunLength.so')

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
    return np.uint8(np.around(RGBA))

def RGBA2YCrCbA(RGBA):
    YCrCbA = np.asarray(RGBA, dtype = np.float)
    YCrCbA = np.linalg.solve(YCrCbA2RGBAxForm, YCrCbA.T).T
    YCrCbA += [16, 128, 128, 0]
    np.putmask(YCrCbA[:, :3], YCrCbA[:, :3] < 16, 16)
    np.putmask(YCrCbA[:, 0], YCrCbA[:, 0] > 235, 235)
    np.putmask(YCrCbA[:, 1:3], YCrCbA[:, 1:3] > 240, 240)
    np.putmask(YCrCbA[:, -1], YCrCbA[:, -1] > 255, 255)
    np.putmask(YCrCbA[:, -1], YCrCbA[:, -1] < 0, 0)
    return np.uint8(np.around(YCrCbA))

def makeImage(pixelLayer, RGBAPalette):
    alphaLayer = RGBAPalette[pixelLayer, -1]
    alphaImage = Image.fromarray(alphaLayer, mode = 'L')
    pixelImage = Image.fromarray(pixelLayer, mode = 'P')
    pixelImage.putpalette(RGBAPalette[:, :3])
    RGBAImage = pixelImage.convert('RGB')
    RGBAImage.putalpha(alphaImage)
    return RGBAImage

def splitImages(pillowImages):
    widthsAndHeights = list(zip(*[image.size for image in pillowImages]))
    maxWidth = max(widthsAndHeights[0])
    maxHeight = sum(widthsAndHeights[1])
    background = Image.new('RGBA', (maxWidth, maxHeight), color = (255, 255, 255, 0))
    splitPositions = np.cumsum(([0] + list(widthsAndHeights[1]))[:-1])
    for i, h in enumerate(splitPositions):
        background.paste(pillowImages[i], box = (0, h))
    pixels, RGBAPalette = splitImage(background)
    pixelsList = []
    for i, h in enumerate(splitPositions):
        pixelsList.append(pixels[h:(h + widthsAndHeights[1][i]), :widthsAndHeights[0][i]])
    return pixelsList, RGBAPalette

def splitImage(pillowImage):
    try:
        RGBAImage = pillowImage.convert('RGBA').quantize(method = 3, dither = 1)
    except Exception as e:
        RGBAImage = pillowImage.convert('RGBA').quantize(method = 2, dither = 1)
    width, height = RGBAImage.size 
    pixelLayer = np.array(RGBAImage.getdata(), dtype = np.uint8).reshape(height, width)
    RGBAPalette = np.frombuffer(RGBAImage.palette.palette, dtype = np.uint8).reshape(-1, 4)
    return pixelLayer, RGBAPalette

def RLEncode(pixels, cLib = True):
    def RLEncodeHelper(pix, repeat):
        if repeat == 1 and pix != 0:
            return bytes([pix])
        elif repeat == 2 and pix != 0:
            return bytes([pix, pix])
        elif repeat < 64:
            if pix == 0:
                return bytes([0, repeat])
            else:
                return bytes([0, repeat + 128, pix])
        elif repeat < 16384:
            if pix == 0:
                return bytes([0, (repeat >> 8) + 64, repeat & 0xFF])
            else:
                return bytes([0, (repeat >> 8) + 192, repeat & 0xFF, pix])
        else:
            return RLEncodeHelper(pix, 16383) + RLEncodeHelper(pix, repeat - 16383)
    
    height, width = np.shape(pixels)
    if cLib:
        RLData = (ctypes.c_uint8 * (4 + height * round(1.5 * width + 2)))()
        pixels = (ctypes.c_uint8 * (width * height))(*np.ravel(pixels))
        length = libRL.RLEncode(pixels, width, height, RLData)
        return bytes(RLData[:length])
    else:
        return width.to_bytes(2, byteorder = 'big') + \
                height.to_bytes(2, byteorder = 'big') + \
                b''.join([b''.join([RLEncodeHelper(k, len(list(g))) \
                for k, g in groupby(row)]) + \
                b'\x00\x00' \
                for row in pixels])

def RLDecode(RLData, cLib = True):
    width, height = int.from_bytes(RLData[:2], byteorder = 'big'), int.from_bytes(RLData[2:4], byteorder = 'big')
    if cLib:
        pix = (ctypes.c_byte * width * height)()
        libRL.RLDecode(RLData, len(RLData), pix)
        return np.array(pix, dtype = np.uint8).reshape(height, width)
    else:
        lineBuilder = []
        pixels = []
        offset = 4
        length = len(RLData)
 
        while offset < length:
            first = RLData[offset]
            if first:
                entry = first
                repeat = 1
                offset += 1
            else:
                second = RLData[offset + 1]
                if second == 0:
                    entry = 0
                    repeat = 0
                    pixels.append(lineBuilder)
                    lineBuilder = []
                    offset += 2
                elif second < 64:
                    entry = 0
                    repeat = second
                    offset += 2
                elif second < 128:
                    entry = 0
                    repeat = ((second - 64) << 8) + RLData[offset + 2]
                    offset += 3
                elif second < 192:
                    entry = RLData[offset + 2]
                    repeat = second - 128
                    offset += 3
                else:
                    entry = RLData[offset + 3]
                    repeat = ((second - 192) << 8) + RLData[offset + 2]
                    offset += 4
            lineBuilder.extend([entry] * repeat)
 
        if lineBuilder:
            logger.warning(f'[RLDecode] Hanging pixels without line ending: {lineBuilder}')
 
        return np.array(pixels, dtype = np.uint8)
