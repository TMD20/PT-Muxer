/*
  Copyright (C) 2012 Jeroen Frijters

  This software is provided 'as-is', without any express or implied
  warranty.  In no event will the authors be held liable for any damages
  arising from the use of this software.

  Permission is granted to anyone to use this software for any purpose,
  including commercial applications, and to alter it and redistribute it
  freely, subject to the following restrictions:

  1. The origin of this software must not be misrepresented; you must not
     claim that you wrote the original software. If you use this software
     in a product, an acknowledgment in the product documentation would be
     appreciated but is not required.
  2. Altered source versions must be plainly marked as such, and must not be
     misrepresented as being the original software.
  3. This notice may not be removed or altered from any source distribution.

  Jeroen Frijters
  jeroen@frijters.net
  
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using IKVM.Reflection;

namespace Ildasm
{
    partial class Disassembler
    {
        struct ExportDirectoryTable
        {
            internal uint Flags;
            internal uint DateTimeStamp;
            internal ushort MajorVersion;
            internal ushort MinorVersion;
            internal uint NameRVA;
            internal uint OrdinalBase;
            internal uint AddressTableEntries;
            internal uint NumberOfNamePointers;
            internal uint ExportAddressTableRVA;
            internal uint NamePointerRVA;
            internal uint OrdinalTableRVA;

            internal void Read(BinaryReader br)
            {
                Flags = br.ReadUInt32();
                DateTimeStamp = br.ReadUInt32();
                MajorVersion = br.ReadUInt16();
                MinorVersion = br.ReadUInt16();
                NameRVA = br.ReadUInt32();
                OrdinalBase = br.ReadUInt32();
                AddressTableEntries = br.ReadUInt32();
                NumberOfNamePointers = br.ReadUInt32();
                ExportAddressTableRVA = br.ReadUInt32();
                NamePointerRVA = br.ReadUInt32();
                OrdinalTableRVA = br.ReadUInt32();
            }
        }

        struct ExportedMethod
        {
            internal int ordinal;
            internal string name;
        }

        static Dictionary<int, List<ExportedMethod>> GetExportedMethods(Module module)
        {
            int rva;
            int length;
            module.__GetDataDirectoryEntry(0, out rva, out length);

            if (rva == 0 || length < 40)
            {
                return new Dictionary<int, List<ExportedMethod>>();
            }

            ExportDirectoryTable edt = new ExportDirectoryTable();
            byte[] buf = new byte[512];
            module.__ReadDataFromRVA(rva, buf, 0, 40);
            edt.Read(new BinaryReader(new MemoryStream(buf)));

            var methods = new Dictionary<int, List<ExportedMethod>>();
            for (int i = 0; i < edt.NumberOfNamePointers; i++)
            {
                module.__ReadDataFromRVA((int)edt.OrdinalTableRVA + i * 2, buf, 0, 2);
                int ordinal = BitConverter.ToInt16(buf, 0) + (int)edt.OrdinalBase;
                string name = null;
                if (edt.NamePointerRVA != 0)
                {
                    module.__ReadDataFromRVA((int)edt.NamePointerRVA + i * 4, buf, 0, 4);
                    module.__ReadDataFromRVA(BitConverter.ToInt32(buf, 0), buf, 0, buf.Length);
                    int len = 0;
                    while (buf[len] != 0) len++;
                    name = Encoding.ASCII.GetString(buf, 0, len);
                }
                int token = GetTokenFromExportOrdinal(module, edt, ordinal);
                if (token == -1)
                {
                    continue;
                }
                List<ExportedMethod> list;
                if (!methods.TryGetValue(token, out list))
                {
                    list = new List<ExportedMethod>();
                    methods.Add(token, list);
                }
                ExportedMethod method;
                method.name = name;
                method.ordinal = ordinal;
                list.Add(method);
            }
            return methods;
        }

        static int GetTokenFromExportOrdinal(Module module, ExportDirectoryTable edt, int ordinal)
        {
            PortableExecutableKinds peKind;
            ImageFileMachine machine;
            module.GetPEKind(out peKind, out machine);
            byte[] buf = new byte[16];
            module.__ReadDataFromRVA((int)edt.ExportAddressTableRVA + (int)(ordinal - edt.OrdinalBase) * 4, buf, 0, 4);
            int exportRVA = BitConverter.ToInt32(buf, 0);
            if (machine == ImageFileMachine.ARM)
            {
                // mask out the instruction set selection flag
                exportRVA &= ~1;
            }
            module.__ReadDataFromRVA(exportRVA, buf, 0, 16);
            int offset;
            if (machine == ImageFileMachine.I386 && buf[0] == 0xFF && buf[1] == 0x25)
            {
                // for x86 the code here is:
                //   FF 25 00 40 40 00               jmp         dword ptr ds:[00404000h]
                offset = 2;
            }
            else if (machine == ImageFileMachine.AMD64 && buf[0] == 0x48 && buf[1] == 0xA1)
            {
                // for x64 the code here is:
                //   48 A1 00 40 40 00 00 00 00 00   mov         rax,qword ptr [0000000000404000h]
                //   FF E0                           jmp         rax
                offset = 2;
            }
            else if (machine == ImageFileMachine.ARM && buf[0] == 0xDF && buf[1] == 0xF8 && buf[2] == 0x08 && buf[3] == 0xC0)
            {
                // for arm the code here is:
                // F8DF C008 ldr         r12,0040145C
                // F8DC C000 ldr         r12,[r12]
                // 4760      bx          r12
                // DEFE      __debugbreak
                // here is the RVA
                offset = 12;
            }
            else
            {
                return -1;
            }
            int vtableRVA = BitConverter.ToInt32(buf, offset) - (int)module.__ImageBase;
            module.__ReadDataFromRVA(vtableRVA, buf, 0, 4);
            return BitConverter.ToInt32(buf, 0);
        }
    }
}
