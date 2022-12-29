import sys
class BufferedRandomPlus:

    def __init__(self, buffered_random):
        self._wrapped_obj = buffered_random
        self._offset = buffered_random.tell()

    def __getattr__(self, attr):
        if attr in self.__dict__:
            return getattr(self, attr)
        return getattr(self._wrapped_obj, attr)
    
    def _offsetAdapter(self, offset, absolute):
        if not offset:
            return None
        elif absolute:
            if offset == self.offset:
                return None
            return offset
        else:
            if offset == 0:
                return None
            return self.offset + offset

    def peekBytes(self, num, offset=None, absolute=True, byteorder=None):
        if byteorder is None:
            byteorder = 'big'
        offset = self._offsetAdapter(offset, absolute)
        if not offset:
            result = self.peek(num)[:num]
        else:
            self.seek(offset)
            try:
                result = self.peek(num)[:num]
            finally:
                self.seek(self.offset)
        if not result:
            return result
        if len(result) < num:
            raise EOFError('cannot peek enough bytes before hitting EOF')
        if num == 1 or byteorder == 'big':
            return result
        elif byteorder == 'little':
            return result[::-1]
        else:
            raise ValueError('wrong byteorder type')

    def readBytes(self, num, offset=None, absolute=True, byteorder=None):
        if byteorder is None:
            byteorder = 'big'
        offset = self._offsetAdapter(offset, absolute)
        if offset is not None:
            self.seek(offset)
            self._offset = offset
        result = self.read(num)
        if not result: #return an empty bytes object
            return result
        if len(result) < num:
            self._offset += len(result)
            raise EOFError('cannot read enough bytes before hitting EOF')
        self._offset += num
        if num == 1 or byteorder == 'big':
            return result
        elif byteorder == 'little':
            return result[::-1]
        else:
            raise ValueError('wrong byteorder type')
   
    def readWords(self, num, offset=None, absolute=True, byteorder=None):
        if byteorder is None:
            byteorder = 'big'
        offset = self._offsetAdapter(offset, absolute)
        if offset is not None:
            self.seek(offset)
            self._offset = offset
        result = b''
        if byteorder == 'big':
            for i in range(num):
                result += self.readWord()
        elif byteorder == 'little':
            for i in range(num):
                result += self.readWordLE()
        else:
            raise ValueError('wrong byteorder type')
        if not result:
            return result
        if len(result) * 2 < num:
            raise EOFError('cannot read enough words before hitting EOF')
        return result

    def readDWords(self, num, offset=None, absolute=True, byteorder=None):
        if byteorder is None:
            byteorder = 'big'
        offset = _offsetAdapter(offset, absolute)
        if offset is not None:
            self.seek(offset)
            self._offset = offset
        result = b''
        if byteorder == 'big':
            for i in range(num):
                result += self.readDWord()
        elif byteorder == 'little':
            for i in range(num):
                result += self.readDWordLE()
        else:
            raise ValueError('wrong byteorder type')
        if not result:
            return result
        if len(result) * 4 < num:
            raise EOFError('cannot read enough dwords before hitting EOF')
        return result

    def readByte(self, offset=None, absolute=True):
        return self.readBytes(1, offset, absolute)

    def readWord(self, offset=None, absolute=True):
        return self.readBytes(2, offset, absolute)

    def readWordLE(self, offset=None, absolute=True):
        return self.readBytes(2, offset, absolute, 'little')

    def readDWord(self, offset=None, absolute=True):
        return self.readBytes(4, offset, absolute)

    def readDWordLE(self, offset=None, absolute=True):
        return self.readBytes(4, offset, absolute, 'little')
    
    def readQWord(self, offset=None, absolute=True):
        return self.readBytes(8, offset, absolute)

    def readQWordLE(self, offset=None, absolute=True):
        return self.readBytes(8, offset, absolute, 'little')

    def readUInt8(self, offset=None, absolute=True):
        return int.from_bytes(self.readByte(offset, absolute), byteorder = 'big')

    def readUChar(self, offset=None, absolute=True):
        return self.readUInt8(offset, absolute)

    def readInt8(self, offset=None, absolute=True):
        return int.from_bytes(self.readByte(offset, absolute), byteorder = 'big', signed = True)
    
    def readChar(self, offset=None, absolute=True):
        return self.readInt8(offset, absolute)
    
    def readUInt16(self, offset=None, absolute=True):
        return int.from_bytes(self.readWord(offset, absolute), byteorder = 'big')
    
    def readUShort(self, offset=None, absolute=True):
        return self.readUInt16(offset, absolute)
    
    def readUInt16LE(self, offset=None, absolute=True):
        return int.from_bytes(self.readWord(offset, absolute), byteorder = 'little')

    def readUShortLE(self, offset=None, absolute=True):
        return self.readUInt16LE(offset, absolute)

    def readInt16(self, offset=None, absolute=True):
        return int.from_bytes(self.readWord(offset, absolute), byteorder = 'big', signed = True)
    
    def readShort(self, offset=None, absolute=True):
        return self.readInt16(offset, absolute)

    def readInt16LE(self, offset=None, absolute=True):
        return int.from_bytes(self.readWord(offset, absolute), byteorder = 'little', signed = True)

    def readShortLE(self, offset=None, absolute=True):
        return self.readInt16LE(offset, absolute) 

    def readUInt32(self, offset=None, absolute=True):
        return int.from_bytes(self.readDWord(offset, absolute), byteorder = 'big')

    def readUInt(self, offset=None, absolute=True):
        return self.readUInt32(offset, absolute)

    def readUInt32LE(self, offset=None, absolute=True):
        return int.from_bytes(self.readDWord(offset, absolute), byteorder = 'little')

    def readUIntLE(self, offset=None, absolute=True):
        return self.readUInt32LE(offset, absolute)

    def readInt32(self, offset=None, absolute=True):
        return int.from_bytes(self.readDWord(offset, absolute), byteorder = 'big', signed = True)

    def readInt(self, offset=None, absolute=True):
        return self.readInt32(offset, absolute)
    
    def readInt32LE(self, offset=None, absolute=True):
        return int.from_bytes(self.readDWord(offset, absolute), byteorder = 'little', signed = True)
    
    def readIntLE(self, offset=None, absolute=True):
        return self.readInt32LE(offset, absolute)

    def readUInt64(self, offset=None, absolute=True):
        return int.from_bytes(self.readQWord(offset, absolute), byteorder = 'big')
    
    def readULong(self, offset=None, absolute=True):
        return self.readUInt64(offset, absolute)

    def readUInt64LE(self, offset=None, absolute=True):
        return int.from_bytes(self.readQWord(offset, absolute), byteorder = 'little')

    def readULongLE(self, offset=None, absolute=True):
        return self.readUInt64LE(offset, absolute)

    def readInt64(self, offset=None, absolute=True):
        return int.from_bytes(self.readQWord(offset, absolute), byteorder = 'big', signed = True)

    def readLong(self, offset=None, absolute=True):
        return self.readInt64(offset, absolute)

    def readInt64LE(self, offset=None, absolute=True):
        return int.from_bytes(self.readQWord(offset, absolute), byteorder = 'little', signed = True)

    def readLongLE(self, offset=None, absolute=True):
        return self.readInt64LE(offset, absolute)

    def peekByte(self, offset=None, absolute=True):
        return self.peekBytes(1, offset, absolute)

    def peekWord(self, offset=None, absolute=True):
        return self.peekBytes(2, offset, absolute)

    def peekWordLE(self, offset=None, absolute=True):
        return self.peekBytes(2, offset, absolute, 'little')

    def peekDWord(self, offset=None, absolute=True):
        return self.peekBytes(4, offset, absolute)

    def peekDWordLE(self, offset=None, absolute=True):
        return self.peekBytes(4, offset, absolute, 'little')

    def peekQWord(self, offset=None, absolute=True):
        return self.peekBytes(8, offset, absolute)

    def peekQWordLE(self, offset=None, absolute=True):
        return self.peekBytes(8, offset, absolute, 'little')

    def peekUInt8(self, offset=None, absolute=True):
        return int.from_bytes(self.peekByte(offset, absolute), byteorder = 'big')

    def peekUChar(self, offset=None, absolute=True):
        return self.peekUInt8(offset, absolute)

    def peekInt8(self, offset=None, absolute=True):
        return int.from_bytes(self.peekByte(offset, absolute), byteorder = 'big', signed = True)
    
    def peekChar(self, offset=None, absolute=True):
        return self.peekInt8(offset, absolute)
    
    def peekUInt16(self, offset=None, absolute=True):
        return int.from_bytes(self.peekWord(offset, absolute), byteorder = 'big')
    
    def peekUShort(self, offset=None, absolute=True):
        return self.peekUInt16(offset, absolute)
    
    def peekUInt16LE(self, offset=None, absolute=True):
        return int.from_bytes(self.peekWord(offset, absolute), byteorder = 'little')

    def peekUShortLE(self, offset=None, absolute=True):
        return self.peekUInt16LE(offset, absolute)

    def peekInt16(self, offset=None, absolute=True):
        return int.from_bytes(self.peekWord(offset, absolute), byteorder = 'big', signed = True)
    
    def peekShort(self, offset=None, absolute=True):
        return self.peekInt16(offset, absolute)

    def peekInt16LE(self, offset=None, absolute=True):
        return int.from_bytes(self.peekWord(offset, absolute), byteorder = 'little', signed = True)

    def peekShortLE(self, offset=None, absolute=True):
        return self.peekInt16LE(offset, absolute) 

    def peekUInt32(self, offset=None, absolute=True):
        return int.from_bytes(self.peekDWord(offset, absolute), byteorder = 'big')

    def peekUInt(self, offset=None, absolute=True):
        return self.peekUInt32(offset, absolute)

    def peekUInt32LE(self, offset=None, absolute=True):
        return int.from_bytes(self.peekDWord(offset, absolute), byteorder = 'little')

    def peekUIntLE(self, offset=None, absolute=True):
        return self.peekUInt32LE(offset, absolute)

    def peekInt32(self, offset=None, absolute=True):
        return int.from_bytes(self.peekDWord(offset, absolute), byteorder = 'big', signed = True)

    def peekInt(self, offset=None, absolute=True):
        return self.peekInt32(offset, absolute)
    
    def peekInt32LE(self, offset=None, absolute=True):
        return int.from_bytes(self.peekDWord(offset, absolute), byteorder = 'little', signed = True)
    
    def peekIntLE(self, offset=None, absolute=True):
        return self.peekInt32LE(offset, absolute)

    def peekUInt64(self, offset=None, absolute=True):
        return int.from_bytes(self.peekQWord(offset, absolute), byteorder = 'big')
    
    def peekULong(self, offset=None, absolute=True):
        return self.peekUInt64(offset, absolute)

    def peekUInt64LE(self, offset=None, absolute=True):
        return int.from_bytes(self.peekQWord(offset, absolute), byteorder = 'little')

    def peekULongLE(self, offset=None, absolute=True):
        return self.peekUInt64LE(offset, absolute)

    def peekInt64(self, offset=None, absolute=True):
        return int.from_bytes(self.peekQWord(offset, absolute), byteorder = 'big', signed = True)

    def peekLong(self, offset=None, absolute=True):
        return self.peekInt64(offset, absolute)

    def peekInt64LE(self, offset=None, absolute=True):
        return int.from_bytes(self.peekQWord(offset, absolute), byteorder = 'little', signed = True)

    def peekLongLE(self, offset=None, absolute=True):
        return self.peekInt64LE(offset, absolute)

    @property
    def offset(self):
        return self._offset
