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
using IKVM.Reflection;

namespace Ildasm
{
    partial class Disassembler
    {
        const ushort COR_VTABLE_32BIT = 0x01;
        const ushort COR_VTABLE_64BIT = 0x02;
        const ushort COR_VTABLE_FROM_UNMANAGED = 0x04;
        const ushort COR_VTABLE_FROM_UNMANAGED_RETAIN_APPDOMAIN = 0x08;
        Dictionary<MethodBase, List<KeyValuePair<int, int>>> vtentryMap = new Dictionary<MethodBase, List<KeyValuePair<int, int>>>();

        void WriteVTableFixupComment(LineWriter lw)
        {
            int ptrsize = GetPointerSize();
            VTableFixups[] fixups = GetVTableFixups();
            if (fixups.Length != 0)
            {
                lw.WriteLine("// VTableFixup Directory:");
                for (int i = 0; i < fixups.Length; i++)
                {
                    lw.WriteLine("//   IMAGE_COR_VTABLEFIXUP[{0}]:", i);
                    lw.WriteLine("//       RVA:               0x{0:x8}", fixups[i].RVA);
                    lw.WriteLine("//       Count:             0x{0:x4}", fixups[i].Count);
                    lw.WriteLine("//       Type:              0x{0:x4}", fixups[i].Type);
                    var methods = GetVTableMethods(fixups[i]);
                    for (int j = 0; j < methods.Length; j++)
                    {
                        var method = methods[j];
                        List<KeyValuePair<int,int>> list;
                        if (!vtentryMap.TryGetValue(method, out list))
                        {
                            list = new List<KeyValuePair<int, int>>();
                            vtentryMap.Add(method, list);
                        }
                        list.Add(new KeyValuePair<int,int>(i + 1, j + 1));
                        if (ptrsize == 4)
                        {
                            lw.WriteLine("//         [0x{0:x4}]            (0x{1:x8})", j, method.MetadataToken);
                        }
                        else
                        {
                            lw.WriteLine("//         [0x{0:x4}]            (0x         {1:x})", j, method.MetadataToken);
                        }
                    }
                }
                lw.WriteLine();
            }
            lw.WriteLine();
        }

        void WriteVTableFixups(LineWriter lw)
        {
            int ptrsize = GetPointerSize();
            VTableFixups[] fixups = GetVTableFixups();
            if (fixups.Length != 0)
            {
                for (int i = 0; i < fixups.Length; i++)
                {
                    lw.Write(".vtfixup [{0}] {1}{2} at D_{3:X8} //",
                        fixups[i].Count,
                        (fixups[i].Type & COR_VTABLE_32BIT) != 0 ? "int32" : "int64",
                        (fixups[i].Type & COR_VTABLE_FROM_UNMANAGED_RETAIN_APPDOMAIN) != 0
                            ? " retainappdomain"
                            : (fixups[i].Type & COR_VTABLE_FROM_UNMANAGED) != 0
                                ? " fromunmanaged"
                                : "",
                        fixups[i].RVA);
                    foreach (var method in GetVTableMethods(fixups[i]))
                    {
                        if (ptrsize == 4)
                        {
                            lw.Write(" {0:X8}", method.MetadataToken);
                        }
                        else
                        {
                            lw.Write(" {0:X16}", method.MetadataToken);
                        }
                    }
                    lw.WriteLine();
                }
            }
        }

        struct VTableFixups
        {
            internal int RVA;
            internal short Count;
            internal short Type;
        }

        VTableFixups[] GetVTableFixups()
        {
            int rva;
            int length;
            module.__GetDataDirectoryEntry(14, out rva, out length);
            byte[] buf = new byte[8];
            module.__ReadDataFromRVA(rva + 48, buf, 0, 8);
            rva = BitConverter.ToInt32(buf, 0);
            if (rva == 0)
            {
                return new VTableFixups[0];
            }
            VTableFixups[] entries = new VTableFixups[BitConverter.ToInt32(buf, 4) / 8];
            for (int i = 0; i < entries.Length; i++)
            {
                module.__ReadDataFromRVA(rva + i * 8, buf, 0, 8);
                entries[i].RVA = BitConverter.ToInt32(buf, 0);
                entries[i].Count = BitConverter.ToInt16(buf, 4);
                entries[i].Type = BitConverter.ToInt16(buf, 6);
            }
            return entries;
        }

        MethodBase[] GetVTableMethods(VTableFixups fixups)
        {
            var methods = new MethodBase[fixups.Count];
            byte[] buf = new byte[8];
            int fixuprva = fixups.RVA;
            for (int i = 0; i < fixups.Count; i++)
            {
                module.__ReadDataFromRVA(fixuprva, buf, 0, 4);
                methods[i] = module.ResolveMethod(BitConverter.ToInt32(buf, 0));
                if ((fixups.Type & COR_VTABLE_32BIT) != 0)
                {
                    fixuprva += 4;
                }
                if ((fixups.Type & COR_VTABLE_64BIT) != 0)
                {
                    fixuprva += 8;
                }
            }
            return methods;
        }
    }
}
