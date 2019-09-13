#include <stdio.h>
#include <stdlib.h>
#include "RLE.h"

void RLEDecode(unsigned char * RLEData, unsigned int length, unsigned char * pixels, unsigned int height){
    unsigned int offset = 0;
    unsigned char entry, skip, first, second;
    unsigned int repeat;
    unsigned int i = 0, j = 0, k;
    while (offset < length) {
        first = RLEData[offset];
        if (first > 0) {
            entry = first;
            repeat = 1;
            skip = 1;
        }
        else{
            second = RLEData[offset + 1];
            if (second == 0) {
                entry = 0;
                repeat = 0;
                skip = 2;
                if (++i == height) {
                    break;
                }
            }
            else if (second < 64) {
                entry = 0;
                repeat = second;
                skip = 2;
            }
            else if (second < 128) {
                entry = 0;
                repeat = ((second - 64) << 8) + RLEData[offset + 2];
                skip = 3;
            }
            else if (second < 192) {
                entry = RLEData[offset + 2];
                repeat = second - 128;
                skip = 3;
            }
            else{
                entry = RLEData[offset + 3];
                repeat = ((second - 192) << 8) + RLEData[offset + 2];
                skip = 4;
            }
        }
        for (k = j; k < j + repeat; ++k){
            pixels[k] = entry;
        }
        j = k;
        offset += skip;
    }
    if (i < height) {
        fprintf(stderr, "Warning: [RLE] Hanging pixels without line ending\n");
    }
}
