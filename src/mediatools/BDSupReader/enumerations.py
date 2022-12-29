from enum import Enum

class SEGMENT_TYPE(Enum):
    PDS = b'\x14'
    ODS = b'\x15'
    PCS = b'\x16'
    WDS = b'\x17'
    END = b'\x80'

class COMPOSITION_STATE(Enum):
    NORMAL = b'\x00'
    ACQUISITION_POINT = b'\x40'
    EPOCH_START = b'\x80'
    EPOCH_CONTINUE = b'\xC0'
    
class SEQUENCE(Enum):
    FIRST = b'\x40'
    LAST = b'\x80'
    FIRST_LAST = b'\xC0'
