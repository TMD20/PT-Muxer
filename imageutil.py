from PIL import Image
import numpy as np
import logging

logging.basicConfig(level = logging.INFO)
logger = logging.getLogger(__name__)

YCrCb2RGBXForm = np.array([[255/219, 255/224*1.402, 0],
    [255/219, -255/224*1.402*0.299/0.587, -255/224*1.772*0.114/0.587], 
    [255/219, 0, 255/224*1.772]], dtype = np.float)

def YCrCb2RGB(YCrCb):
    RGB = np.asarray(YCrCb, dtype = np.float)
    RGB -= [16, 128, 128]
    RGB = RGB.dot(YCrCb2RGBXForm.T)
    np.putmask(RGB, RGB > 255, 255)
    np.putmask(RGB, RGB < 0, 0)
    return np.uint8(RGB)

def RGB2YCrCb(RGB):
    YCrCb = np.asarray(RGB, dtype = np.float)
    YCrCb = np.linalg.solve(YCrCb2RGBXForm.T, YCrCb)
    YCrCb += [16, 128, 128]
    np.putmask(YCrCb, YCrCb < 16, 16)
    np.putmask(YCrCb[:, 0], YCrCb[:, 0] > 235, 235)
    np.putmask(YCrCb[:, 1:3], YCrCb[:, 1:3] > 240, 240)
    return np.uint8(YCrCb)

def makeImage(pixelLayer, rgb, alpha):
    alphaLayer = alpha[pixelLayer]
    alphaImage = Image.fromarray(alphaLayer, mode = 'L')
    pixelImage = Image.fromarray(pixelLayer, mode = 'P')
    pixelImage.putpalette(rgb)
    RGBAImage = pixelImage.convert('RGB')
    RGBAImage.putalpha(alphaImage)
    return RGBAImage

def RLEDecode(RLEData):
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
