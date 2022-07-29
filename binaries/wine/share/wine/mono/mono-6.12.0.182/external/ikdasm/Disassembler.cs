/*
  Copyright (C) 2013 Jeroen Frijters

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
using Type = IKVM.Reflection.Type;

namespace Ildasm
{
    enum CompatLevel
    {
        None,
        V20,
        V40,
        V45,
    }

    [Flags]
    enum Flags
    {
        None = 0,
        DiffMode = 1,
        Caverbal = 2,
        Project = 4,
    }

    sealed partial class Disassembler
    {
        const int IMAGE_SCN_CNT_CODE = 0x00000020;
        const int IMAGE_SCN_CNT_INITIALIZED_DATA = 0x00000040;
        const int IMAGE_SCN_CNT_UNINITIALIZED_DATA = 0x00000080;
        const int IMAGE_SCN_MEM_READ = 0x40000000;
        const int IMAGE_SCN_MEM_WRITE = unchecked((int)0x80000000);
        const int COMIMAGE_FLAGS_ILONLY = 0x00000001;
        const int COMIMAGE_FLAGS_32BITREQUIRED = 0x00000002;
        const int COMIMAGE_FLAGS_IL_LIBRARY = 0x00000004;
        const int COMIMAGE_FLAGS_STRONGNAMESIGNED = 0x00000008;
        const int COMIMAGE_FLAGS_NATIVE_ENTRYPOINT = 0x00000010;
        const int COMIMAGE_FLAGS_32BITPREFERRED = 0x00020000;
        readonly Universe universe;
        readonly Assembly mscorlib;
        readonly Type typeofSystemBoolean;
        readonly Type typeofSystemSByte;
        readonly Type typeofSystemByte;
        readonly Type typeofSystemChar;
        readonly Type typeofSystemInt16;
        readonly Type typeofSystemUInt16;
        readonly Type typeofSystemInt32;
        readonly Type typeofSystemUInt32;
        readonly Type typeofSystemInt64;
        readonly Type typeofSystemUInt64;
        readonly Type typeofSystemSingle;
        readonly Type typeofSystemDouble;
        readonly Type typeofSystemVoid;
        readonly Type typeofSystemIntPtr;
        readonly Type typeofSystemUIntPtr;
        readonly Type typeofSystemTypedReference;
        readonly Type typeofSystemObject;
        readonly Type typeofSystemString;
        readonly Type typeofSystemType;
        readonly Assembly assembly;
        readonly Module module;
        readonly Dictionary<string, string> referencedAssemblies = new Dictionary<string, string>();
        readonly Assembly[] resolvedAssemblies;
        readonly HashSet<Type> typerefs;
        readonly List<FieldInfo> dataFields = new List<FieldInfo>();
        readonly Dictionary<int, List<ExportedMethod>> exportedMethods;
        readonly string[] methodNames;
        readonly string[] fieldNames;
        readonly CompatLevel compat;
        readonly string outputFile;
        readonly bool diffMode;
        readonly Flags flags;

        internal Disassembler(string inputFile, string outputFile, CompatLevel compat, Flags flags)
        {
            this.outputFile = outputFile;
            this.compat = compat;
            this.diffMode = (flags & Flags.DiffMode) != 0;
            this.flags = flags;
            UniverseOptions options = UniverseOptions.EnableFunctionPointers | UniverseOptions.ResolveMissingMembers | UniverseOptions.DisablePseudoCustomAttributeRetrieval;
            if ((flags & Flags.Project) == 0)
            {
                options |= UniverseOptions.DisableWindowsRuntimeProjection;
            }
            universe = new Universe(options);
            universe.AssemblyResolve += new IKVM.Reflection.ResolveEventHandler(universe_AssemblyResolve);
            mscorlib = universe.Import(typeof(object)).Assembly;
            typeofSystemBoolean = universe.Import(typeof(bool));
            typeofSystemSByte = universe.Import(typeof(sbyte));
            typeofSystemByte = universe.Import(typeof(byte));
            typeofSystemChar = universe.Import(typeof(char));
            typeofSystemInt16 = universe.Import(typeof(short));
            typeofSystemUInt16 = universe.Import(typeof(ushort));
            typeofSystemInt32 = universe.Import(typeof(int));
            typeofSystemUInt32 = universe.Import(typeof(uint));
            typeofSystemInt64 = universe.Import(typeof(long));
            typeofSystemUInt64 = universe.Import(typeof(ulong));
            typeofSystemSingle = universe.Import(typeof(float));
            typeofSystemDouble = universe.Import(typeof(double));
            typeofSystemVoid = universe.Import(typeof(void));
            typeofSystemIntPtr = universe.Import(typeof(IntPtr));
            typeofSystemUIntPtr = universe.Import(typeof(UIntPtr));
            typeofSystemTypedReference = universe.Import(typeof(TypedReference));
            typeofSystemObject = universe.Import(typeof(object));
            typeofSystemString = universe.Import(typeof(string));
            typeofSystemType = universe.Import(typeof(System.Type));
            // HACK we specify a bogus location to prevent IKVM.Reflection from loading external modules
            // TODO IKVM.Reflection really should have a way to avoid it trying to load external modules (e.g. a UniverseOption to always use the ModuleResolve event)
            var raw = universe.OpenRawModule(System.IO.File.OpenRead(inputFile), System.IO.Path.GetTempPath() + "/Dummy");
            if (raw.IsManifestModule)
            {
                assembly = universe.LoadAssembly(raw);
                module = assembly.ManifestModule;
            }
            else
            {
                var ab = universe.DefineDynamicAssembly(new AssemblyName("<ModuleContainer>"), IKVM.Reflection.Emit.AssemblyBuilderAccess.ReflectionOnly);
                assembly = ab;
                module = ab.__AddModule(raw);
            }
            exportedMethods = GetExportedMethods(module);

            var names = new HashSet<string>();
            AssemblyName[] assemblyRefs = module.__GetReferencedAssemblies();
            resolvedAssemblies = new Assembly[assemblyRefs.Length];
            for (int i = 0; i < resolvedAssemblies.Length; i++)
            {
                string name = assemblyRefs[i].Name;
                while (names.Contains(name))
                {
                    name = name + "_" + i;
                }
                names.Add(name);
                resolvedAssemblies[i] = universe.CreateMissingAssembly(assemblyRefs[i].FullName);

                // Bug #53272: Some .net assemblers will produce references that only use the
                //  short name of the assembly instead of the full name. We populate the lookup
                //  table with short names so that everything will still work as intended.
                // FIXME: What do we do if two versions of the same assembly are referenced?
                if (!referencedAssemblies.ContainsKey(resolvedAssemblies[i].GetName().Name))
                    referencedAssemblies.Add(resolvedAssemblies[i].GetName().Name, name);

                referencedAssemblies.Add(resolvedAssemblies[i].FullName, name);
            }
            module.__ResolveReferencedAssemblies(resolvedAssemblies);
            typerefs = new HashSet<Type>(module.__GetReferencedTypes());
            methodNames = GetMethodNames();
            fieldNames = GetFieldNames();
        }

        Assembly universe_AssemblyResolve(object sender, IKVM.Reflection.ResolveEventArgs args)
        {
            if (resolvedAssemblies != null)
            {
                foreach (var asm in resolvedAssemblies)
                {
                    AssemblyComparisonResult result;
                    if (universe.CompareAssemblyIdentity(args.Name, false, asm.FullName, false, out result))
                    {
                        return asm;
                    }
                }
            }
            return universe.CreateMissingAssembly(args.Name);
        }

        internal string FindReferencedAssembly(Assembly assembly)
        {
            string result;
            if (!referencedAssemblies.TryGetValue(assembly.FullName, out result))
            {
                if (!referencedAssemblies.TryGetValue(assembly.GetName().Name, out result))
                {
                    var msg = string.Format("Referenced assembly '{0}' not found", assembly.FullName);
                    throw new KeyNotFoundException(msg);
                }
                else
                {
                    // TODO: What do we do here? 
                    var msg = string.Format(
                        "Referenced assembly '{0}' not found, but an assembly named '{1}' does exist", 
                        assembly.FullName, assembly.GetName().Name
                    );
                    throw new KeyNotFoundException(msg);
                }
            }
            return result;
        }

        internal void Save(System.IO.TextWriter writer)
        {
            LineWriter lw = new LineWriter(writer);
            WriteCopyrightHeader(lw);
            WriteVTableFixupComment(lw);
            if (!(assembly is IKVM.Reflection.Emit.AssemblyBuilder))
            {
                WriteMscorlibDirective(lw);
            }
            WriteModuleManifest(lw);
            if (!(assembly is IKVM.Reflection.Emit.AssemblyBuilder))
            {
                WriteAssemblyManifest(lw);
            }
            WriteExportedTypes(lw);
            if (!(assembly is IKVM.Reflection.Emit.AssemblyBuilder))
            {
                WriteModules(lw);
                WriteResources(lw);
            }
            WriteModuleHeader(lw);
            WriteVTableFixups(lw);
            WriteGlobalFields(lw);
            WriteGlobalMethods(lw);
            WriteTypes(lw);
            WriteUnhandledCustomAttributes(lw);
            WriteData(lw);
            lw.WriteLine("// *********** DISASSEMBLY COMPLETE ***********************");
            WriteNativeResources(lw);
        }

        string[] GetMethodNames()
        {
            var methods = new HashSet<MethodBase>(new MethodSignatureComparer());
            var names = new List<string>();
            try
            {
                for (int i = 0x06000001; i <= 0x06FFFFFF; i++)
                {
                    string name;
                    var method = module.ResolveMethod(i);
                    if (methods.Contains(method))
                    {
                        name = String.Format("$MD${0:X}", i - 0x06000000);
                    }
                    else
                    {
                        name = method.Name;
                        methods.Add(method);
                    }
                    if ((method.Attributes & MethodAttributes.MemberAccessMask) == MethodAttributes.PrivateScope)
                    {
                        names.Add(String.Format("{0}$PST{1:X8}", name, method.MetadataToken));
                    }
                    else
                    {
                        names.Add(name);
                    }
                }
            }
            catch (ArgumentOutOfRangeException) { }
            return names.ToArray();
        }

        sealed class MethodSignatureComparer : IEqualityComparer<MethodBase>
        {
            public bool Equals(MethodBase x, MethodBase y)
            {
                return x.DeclaringType == y.DeclaringType
                    && x.Name == y.Name
                    && x.CallingConvention == y.CallingConvention
                    && Equals(GetReturnParameter(x), GetReturnParameter(y))
                    && Equals(x.GetParameters(), y.GetParameters())
                    && x.IsGenericMethodDefinition == y.IsGenericMethodDefinition
                    && (!x.IsGenericMethodDefinition || x.GetGenericArguments().Length == y.GetGenericArguments().Length)
                    ;
            }

            static bool Equals(ParameterInfo p1, ParameterInfo p2)
            {
                return p1.ParameterType == p2.ParameterType
                    && p1.__GetCustomModifiers().Equals(p2.__GetCustomModifiers());
            }

            static bool Equals(ParameterInfo[] p1, ParameterInfo[] p2)
            {
                if (p1.Length != p2.Length)
                {
                    return false;
                }
                for (int i = 0; i < p1.Length; i++)
                {
                    if (!Equals(p1[i], p2[i]))
                    {
                        return false;
                    }
                }
                return true;
            }

            static ParameterInfo GetReturnParameter(MethodBase mb)
            {
                ConstructorInfo ci = mb as ConstructorInfo;
                return ci != null ? ci.__ReturnParameter : ((MethodInfo)mb).ReturnParameter;
            }

            public int GetHashCode(MethodBase mb)
            {
                Type decl = mb.DeclaringType;
                return mb.Name.GetHashCode() ^ (decl == null ? 0 : decl.GetHashCode());
            }
        }

        string[] GetFieldNames()
        {
            var fields = new HashSet<FieldInfo>(new FieldSignatureComparer());
            var names = new List<string>();
            try
            {
                for (int i = 0x04000001; i <= 0x04FFFFFF; i++)
                {
                    string name;
                    var field = module.ResolveField(i);
                    if (fields.Contains(field))
                    {
                        name = String.Format("$FD${0:X}", i - 0x04000000);
                    }
                    else
                    {
                        name = field.Name;
                        fields.Add(field);
                    }
                    if ((field.Attributes & FieldAttributes.FieldAccessMask) == FieldAttributes.PrivateScope)
                    {
                        names.Add(String.Format("{0}$PST{1:X8}", name, field.MetadataToken));
                    }
                    else
                    {
                        names.Add(name);
                    }
                }
            }
            catch (ArgumentOutOfRangeException) { }
            return names.ToArray();
        }

        sealed class FieldSignatureComparer : IEqualityComparer<FieldInfo>
        {
            public bool Equals(FieldInfo x, FieldInfo y)
            {
                return x.DeclaringType == y.DeclaringType
                    && x.Name == y.Name
                    && x.FieldType == y.FieldType
                    && x.__GetCustomModifiers().Equals(y.__GetCustomModifiers());
            }

            public int GetHashCode(FieldInfo field)
            {
                Type decl = field.DeclaringType;
                return field.Name.GetHashCode() ^ (decl == null ? 0 : decl.GetHashCode());
            }
        }

        void WriteExportedTypes(LineWriter lw)
        {
            Type[] exported = module.__GetExportedTypes();
            for (int i = 0; i < exported.Length; i++)
            {
                lw.Write(".class extern ");
                if (!exported[i].IsNested)
                {
                    lw.Write("forwarder ");
                }
                WriteTypeNameNoOuter(lw, exported[i]);
                lw.WriteLine();
                lw.WriteLine("{");
                if (exported[i].IsNested)
                {
                    lw.Write("  .class extern ");
                    WriteTypeName(lw, exported[i].DeclaringType);
                    lw.WriteLine();
                }
                else
                {
                    lw.WriteLine("  .assembly extern {0}", QuoteIdentifier(FindReferencedAssembly(exported[i].Assembly)));
                }
                if (exported[i].MetadataToken != 0)
                {
                    lw.WriteLine("  .class 0x{0:X8}", exported[i].MetadataToken);
                }
                lw.WriteLine("}");
            }
        }

        void WriteGlobalMethods(LineWriter lw)
        {
            MethodInfo[] methods = module.GetMethods(BindingFlags.NonPublic | BindingFlags.Public | BindingFlags.Static);
            ConstructorInfo cctor = module.__ModuleInitializer;
            if (methods.Length != 0 || cctor != null)
            {
                lw.WriteLine();
                lw.WriteLine("// ================== GLOBAL METHODS =========================");
                lw.WriteLine();
                foreach (var method in methods)
                {
                    if (cctor != null && method.MetadataToken > cctor.MetadataToken)
                    {
                        WriteMethod(lw, cctor);
                        cctor = null;
                    }
                    WriteMethod(lw, method);
                }
                if (cctor != null)
                {
                    WriteMethod(lw, cctor);
                }
                lw.WriteLine();
                lw.WriteLine("// =============================================================");
                lw.WriteLine();
            }
        }

        void WriteUnhandledCustomAttributes(LineWriter lw)
        {
            foreach (var ca in module.__EnumerateCustomAttributeTable())
            {
                int parent = ca.__Parent;
                switch (parent >> 24)
                {
                    case 0x00:  // Module
                    case 0x02:  // TypeDef
                    case 0x04:  // Field
                    case 0x06:  // MethodDef
                    case 0x08:  // Param
                    case 0x14:  // Event
                    case 0x17:  // Property
                    case 0x20:  // Assembly
                    case 0x2a:  // GenericParam
                        break;
                    case 0x01:  // TypeRef
                        lw.Write(".custom (");
                        int level = lw.Column - 1;
                        WriteTypeDefOrRef(lw, module.ResolveType(parent));
                        lw.Write(") ");
                        WriteCustomAttributeImpl(lw, ca, false, level);
                        break;
                    default:
                        if (compat == CompatLevel.V20 || compat == CompatLevel.V40 || (parent >> 24) != 0x09)
                        {
                            lw.Write(".custom (UNKNOWN_OWNER) ");
                            WriteCustomAttributeImpl(lw, ca, false, lw.Column - 16);
                        }
                        break;
                }
            }
        }

        void WriteGlobalFields(LineWriter lw)
        {
            FieldInfo[] fields = module.GetFields(BindingFlags.NonPublic | BindingFlags.Public | BindingFlags.Static);
            if (fields.Length != 0)
            {
                lw.WriteLine();
                lw.WriteLine();
                lw.WriteLine("// ================== GLOBAL FIELDS ==========================");
                lw.WriteLine();
                foreach (var field in fields)
                {
                    WriteField(lw, field);
                }
                lw.WriteLine();
                lw.WriteLine("// =============================================================");
            }
            lw.WriteLine();
        }

        void WriteModules(LineWriter lw)
        {
            foreach (var module in assembly.GetModules(true))
            {
                if (module != this.module)
                {
                    lw.WriteLine(module.IsResource() ? ".file nometadata {0}" : ".file {0}", QuoteIdentifier(module.Name));
                    byte[] hash = module.__ModuleHash;
                    if (hash != null)
                    {
                        lw.Write("    .hash = (");
                        WriteBytes(lw, hash, false);
                        lw.WriteLine();
                    }
                }
            }
        }

        void WriteMscorlibDirective(LineWriter lw)
        {
            Type obj = assembly.GetType("System.Object");
            if (obj != null && !obj.__IsMissing && obj.BaseType == null && obj.IsClass)
            {
                lw.WriteLine();
                lw.WriteLine(".mscorlib ");
                lw.WriteLine();
            }
        }

        int GetPointerSize()
        {
            PortableExecutableKinds peKind;
            ImageFileMachine machine;
            module.GetPEKind(out peKind, out machine);
            if ((peKind & PortableExecutableKinds.PE32Plus) != 0)
            {
                return 8;
            }
            else
            {
                return 4;
            }
        }

        int GetTypeSize(Type type)
        {
            int packingSize;
            int typeSize;
            if (!type.__IsMissing && type.IsEnum)
            {
                type = type.GetEnumUnderlyingType();
            }
            if (type.__IsFunctionPointer || type.IsPointer || type == typeofSystemIntPtr || type == typeofSystemUIntPtr)
            {
                typeSize = GetPointerSize();
            }
            else if (type.__IsMissing || !type.__GetLayout(out packingSize, out typeSize))
            {
                if (type == typeofSystemSByte
                    || type == typeofSystemByte
                    || type == typeofSystemBoolean)
                {
                    typeSize = 1;
                }
                else if (type == typeofSystemInt16
                    || type == typeofSystemUInt16
                    || type == typeofSystemChar)
                {
                    typeSize = 2;
                }
                else if (type == typeofSystemInt32
                    || type == typeofSystemUInt32
                    || type == typeofSystemSingle)
                {
                    typeSize = 4;
                }
                else if (type == typeofSystemInt64
                    || type == typeofSystemUInt64
                    || type == typeofSystemDouble)
                {
                    typeSize = 8;
                }
                else
                {
                    // unknown
                    typeSize = 0;
                }
            }
            return typeSize;
        }

        struct DataPointer : IComparable<DataPointer>
        {
            internal readonly int RVA;
            internal readonly int Size;

            internal DataPointer(int rva, int size)
            {
                this.RVA = rva;
                this.Size = size;
            }

            public int CompareTo(DataPointer other)
            {
                return RVA.CompareTo(other.RVA);
            }
        }

        void WriteData(LineWriter lw)
        {
            List<DataPointer> ptrs = new List<DataPointer>();
            foreach (VTableFixups fixup in GetVTableFixups())
            {
                ptrs.Add(new DataPointer(fixup.RVA, fixup.Count * ((fixup.Type & COR_VTABLE_32BIT) != 0 ? 4 : 8)));
            }
            foreach (FieldInfo field in dataFields)
            {
                ptrs.Add(new DataPointer(field.__FieldRVA, GetTypeSize(field.FieldType)));
            }
            ptrs.Sort();
            for (int i = 0; i < ptrs.Count - 1; i++)
            {
                if (ptrs[i].RVA == ptrs[i + 1].RVA)
                {
                    ptrs.RemoveAt(i + 1);
                    i--;
                }
            }
            for (int i = 0; i < ptrs.Count; i++)
            {
                int rva = ptrs[i].RVA;
                string name;
                int characteristics;
                int virtualAddress;
                int virtualSize;
                int pointerToRawData;
                int sizeOfRawData;
                if (!module.__GetSectionInfo(rva, out name, out characteristics, out virtualAddress, out virtualSize, out pointerToRawData, out sizeOfRawData))
                {
                    continue;
                }
                int alignment = 0;
                int size = ptrs[i].Size;
                if (rva + size >= virtualAddress + virtualSize)
                {
                    size = virtualAddress + virtualSize - rva;
                }
                else if (i == ptrs.Count - 1)
                {
                    // we're at the last pointer
                }
                else if (rva + size >= ptrs[i + 1].RVA)
                {
                    size = ptrs[i + 1].RVA - rva;
                }
                else if (rva + size < virtualAddress + sizeOfRawData)
                {
                    int next = ptrs[i + 1].RVA;
                    int align = (next & (~next + 1)) - 1;
                    alignment = ((rva + size + align) & ~align) - (rva + size);
                }
                WriteData(lw, name, rva, size, rva >= virtualAddress + sizeOfRawData);
                if (alignment != 0)
                {
                    WriteData(lw, name, rva + size, alignment, true);
                }
            }
        }

        void WriteData(LineWriter lw, string section, int rva, int size, bool uninitialized)
        {
            lw.Write(".data ");
            switch (section)
            {
                case ".text":
                    lw.Write("cil I_");
                    break;
                case ".tls":
                    lw.Write("tls T_");
                    break;
                default:
                    lw.Write("D_");
                    break;
            }
            if (diffMode)
            {
                lw.Write("xxxxxxxx = ");
            }
            else
            {
                lw.Write("{0:X8} = ", rva);
            }
            if (uninitialized)
            {
                lw.WriteLine("int8[{0}]", size);
            }
            else
            {
                lw.WriteLine("bytearray (");
                lw.GoToColumn(17);
                byte[] buf = new byte[size];
                module.__ReadDataFromRVA(rva, buf, 0, buf.Length);
                WriteBytes(lw, buf, true);
                lw.WriteLine();
            }
        }

        void WriteNativeResources(LineWriter lw)
        {
            int rva;
            int length;
            module.__GetDataDirectoryEntry(2, out rva, out length);
            if (rva != 0 && outputFile != null && !diffMode)
            {
                lw.WriteLine("// WARNING: Created Win32 resource file {0}", System.IO.Path.ChangeExtension(outputFile, "res"));
            }
        }

        void WriteCopyrightHeader(LineWriter lw)
        {
            if (compat == CompatLevel.V20)
            {
                lw.WriteLine();
                lw.WriteLine("//  Microsoft (R) .NET Framework IL Disassembler.  Version 2.0.50727.42");
                lw.WriteLine("//  Copyright (c) Microsoft Corporation.  All rights reserved.");
                lw.WriteLine();
                lw.WriteLine();
            }
            else if (compat == CompatLevel.V40)
            {
                lw.WriteLine();
                lw.WriteLine("//  Microsoft (R) .NET Framework IL Disassembler.  Version 4.0.30319.1");
                lw.WriteLine("//  Copyright (c) Microsoft Corporation.  All rights reserved.");
                lw.WriteLine();
                lw.WriteLine();
            }
            else if (compat == CompatLevel.V45)
            {
                lw.WriteLine();
                lw.WriteLine("//  Microsoft (R) .NET Framework IL Disassembler.  Version 4.0.30319.18020");
                lw.WriteLine("//  Copyright (c) Microsoft Corporation.  All rights reserved.");
                lw.WriteLine();
                lw.WriteLine();
            }
        }

        void WriteTypes(LineWriter lw)
        {
            Type[] types = module.GetTypes();
            if (types.Length != 0)
            {
                lw.WriteLine();
                lw.WriteLine("// =============== CLASS MEMBERS DECLARATION ===================");
                lw.WriteLine();
                foreach (var type in types)
                {
                    if (!type.IsNested)
                    {
                        WriteType(lw, type);
                    }
                }
                lw.WriteLine();
                lw.WriteLine("// =============================================================");
                lw.WriteLine();
            }
        }

        void WriteType(LineWriter lw, IKVM.Reflection.Type type)
        {
            int level = lw.Column;
            lw.Write(".class ");
            if (type.IsInterface)
            {
                lw.Write("interface ");
            }
            if (type.IsPublic)
            {
                lw.Write("public ");
            }
            else if (!type.IsNested)
            {
                lw.Write("private ");
            }
            if (type.IsAbstract)
            {
                lw.Write("abstract ");
            }
            switch (type.StructLayoutAttribute.Value)
            {
                case System.Runtime.InteropServices.LayoutKind.Auto:
                    lw.Write("auto ");
                    break;
                case System.Runtime.InteropServices.LayoutKind.Sequential:
                    lw.Write("sequential ");
                    break;
                case System.Runtime.InteropServices.LayoutKind.Explicit:
                    lw.Write("explicit ");
                    break;
            }
            switch (type.Attributes & TypeAttributes.StringFormatMask)
            {
                case TypeAttributes.AnsiClass:
                    lw.Write("ansi ");
                    break;
                case TypeAttributes.UnicodeClass:
                    lw.Write("unicode ");
                    break;
                case TypeAttributes.AutoClass:
                    lw.Write("autochar ");
                    break;
            }
            if ((type.Attributes & TypeAttributes.Import) != 0)
            {
                lw.Write("import ");
            }
            if ((type.Attributes & TypeAttributes.Serializable) != 0)
            {
                lw.Write("serializable ");
            }
            if ((type.Attributes & TypeAttributes.WindowsRuntime) != 0 && (compat == CompatLevel.None || compat >= CompatLevel.V45))
            {
                lw.Write("windowsruntime ");
            }
            if (type.IsSealed)
            {
                lw.Write("sealed ");
            }
            switch (type.Attributes & TypeAttributes.VisibilityMask)
            {
                case TypeAttributes.NestedPublic:
                    lw.Write("nested public ");
                    break;
                case TypeAttributes.NestedPrivate:
                    lw.Write("nested private ");
                    break;
                case TypeAttributes.NestedAssembly:
                    lw.Write("nested assembly ");
                    break;
                case TypeAttributes.NestedFamily:
                    lw.Write("nested family ");
                    break;
                case TypeAttributes.NestedFamORAssem:
                    lw.Write("nested famorassem ");
                    break;
                case TypeAttributes.NestedFamANDAssem:
                    lw.Write("nested famandassem ");
                    break;
            }
            if ((type.Attributes & TypeAttributes.BeforeFieldInit) != 0)
            {
                lw.Write("beforefieldinit ");
            }
            if ((type.Attributes & TypeAttributes.SpecialName) != 0)
            {
                lw.Write("specialname ");
            }
            WriteTypeNameNoOuter(lw, type);
            if (type.IsGenericTypeDefinition)
            {
                WriteGenericParameterDef(lw, type.GetGenericArguments(), true);
            }
            lw.WriteLine();
            lw.GoToColumn(level);
            if (type.BaseType != null)
            {
                lw.Write("       extends ");
                WriteInterfaceOrBaseType(lw, type.BaseType);
                lw.WriteLine();
                lw.GoToColumn(level);
            }
            Type[] interfaces = type.__GetDeclaredInterfaces();
            if (interfaces.Length != 0)
            {
                lw.Write("       implements ");
                bool first = true;
                foreach (var iface in interfaces)
                {
                    if (!first)
                    {
                        lw.WriteLine(",");
                        lw.GoToColumn(level + 18);
                    }
                    first = false;
                    WriteInterfaceOrBaseType(lw, iface);
                }
                lw.WriteLine();
                lw.GoToColumn(level);
            }
            lw.WriteLine("{");
            int packingSize;
            int typeSize;
            if (type.__GetLayout(out packingSize, out typeSize))
            {
                lw.GoToColumn(level + 2);
                lw.WriteLine(".pack {0}", packingSize);
                lw.GoToColumn(level + 2);
                lw.WriteLine(".size {0}", typeSize);
            }
            WriteCustomAttributes(lw, level + 2, type.__GetCustomAttributes(null, false));
            WriteDeclarativeSecurity(lw, level + 2, CustomAttributeData.__GetDeclarativeSecurity(type), type.MetadataToken);
            WriteGenericParameterCustomAttributes(lw, level + 2, type.GetGenericArguments());
            if (compat == CompatLevel.None || compat >= CompatLevel.V45)
            {
                foreach (var iface in type.__GetDeclaredInterfaces())
                {
                    var cas = CustomAttributeData.__GetCustomAttributes(type, iface, null, false);
                    if (cas.Count != 0)
                    {
                        lw.GoToColumn(level + 2);
                        lw.Write(".interfaceimpl type ");
                        WriteInterfaceOrBaseType(lw, iface);
                        lw.WriteLine();
                        WriteCustomAttributes(lw, level + 2, cas);
                    }
                }
            }
            foreach (var nested in type.__GetDeclaredTypes())
            {
                lw.GoToColumn(level + 2);
                WriteType(lw, nested);
            }
            IEnumerable<FieldInfo> fields = type.__GetDeclaredFields();
            if (diffMode)
            {
                fields = fields.OrderBy(x => x.Name);
            }
            foreach (var field in fields)
            {
                lw.GoToColumn(level + 2);
                WriteField(lw, field);
            }
            foreach (var method in type.__GetDeclaredMethods())
            {
                lw.GoToColumn(level + 2);
                WriteMethod(lw, method);
            }
            foreach (var evt in type.__GetDeclaredEvents())
            {
                lw.GoToColumn(level + 2);
                WriteEvent(lw, evt);
            }
            foreach (var prop in type.__GetDeclaredProperties())
            {
                lw.GoToColumn(level + 2);
                WriteProperty(lw, prop);
            }
            lw.GoToColumn(level);
            lw.Write("} // end of class ");
            WriteTypeNameNoOuter(lw, type);
            lw.WriteLine();
            lw.WriteLine();
        }

        void WriteInterfaceOrBaseType(LineWriter lw, Type type)
        {
            if (type.__IsMissing || !type.IsGenericType)
            {
                WriteTypeDefOrRef(lw, type);
            }
            else
            {
                WriteSignatureType(lw, type, TypeLocation.General);
            }
        }

        void WriteGenericParameterCustomAttributes(LineWriter lw, int level, Type[] args)
        {
            foreach (var typeParam in args)
            {
                IList<CustomAttributeData> cas = CustomAttributeData.__GetCustomAttributes(typeParam, null, false);
                if (cas.Count != 0)
                {
                    lw.GoToColumn(level);
                    lw.WriteLine(".param type {0} ", QuoteIdentifier(typeParam.Name));
                    WriteCustomAttributes(lw, level, cas);
                }
            }
        }

        void WriteGenericParameterDef(LineWriter lw, Type[] parameters, bool wrap)
        {
            lw.Write("<");
            int level = lw.Column;
            string sep = "";
            for (int i = 0; i < parameters.Length; i++)
            {
                Type par = parameters[i];
                lw.Write(sep);
                if (wrap && i != 0 && i % 4 == 0)
                {
                    lw.WriteLine();
                    lw.GoToColumn(level);
                }
                if ((par.GenericParameterAttributes & GenericParameterAttributes.Contravariant) != 0)
                {
                    lw.Write("- ");
                }
                if ((par.GenericParameterAttributes & GenericParameterAttributes.Covariant) != 0)
                {
                    lw.Write("+ ");
                }
                if ((par.GenericParameterAttributes & GenericParameterAttributes.ReferenceTypeConstraint) != 0)
                {
                    lw.Write("class ");
                }
                if ((par.GenericParameterAttributes & GenericParameterAttributes.NotNullableValueTypeConstraint) != 0)
                {
                    lw.Write("valuetype ");
                }
                if ((par.GenericParameterAttributes & GenericParameterAttributes.DefaultConstructorConstraint) != 0)
                {
                    lw.Write(".ctor ");
                }
                string sep2 = "(";
                Type[] constraints = par.GetGenericParameterConstraints();
                CustomModifiers[] customModifiers = par.__GetGenericParameterConstraintCustomModifiers();
                for (int j = 0; j < constraints.Length; j++)
                {
                    Type constraint = constraints[j];
                    lw.Write(sep2);
                    sep2 = ", ";
                    if (constraint.__IsMissing || !constraint.IsGenericType)
                    {
                        if (!customModifiers[j].IsEmpty && !constraint.IsGenericParameter)
                        {
                            lw.Write(constraint.IsValueType ? "valuetype " : "class ");
                        }
                        WriteTypeDefOrRef(lw, constraint);
                    }
                    else
                    {
                        WriteSignatureType(lw, constraint);
                    }
                    WriteCustomModifiers(lw, customModifiers[j]);
                }
                if (sep2 != "(")
                {
                    lw.Write(") ");
                }
                lw.Write("{0}", QuoteIdentifier(par.Name));
                sep = ",";
            }
            lw.Write(">");
        }

        void WriteEvent(LineWriter lw, EventInfo evt)
        {
            int level = lw.Column;
            lw.Write(".event ");
            if (evt.IsSpecialName)
            {
                lw.Write("specialname ");
            }
            if (!evt.EventHandlerType.__IsMissing && evt.EventHandlerType.IsGenericType && !evt.EventHandlerType.IsGenericTypeDefinition)
            {
                WriteSignatureType(lw, evt.EventHandlerType, TypeLocation.General);
            }
            else
            {
                WriteTypeDefOrRef(lw, evt.EventHandlerType);
            }
            lw.WriteLine(" {0}", QuoteIdentifier(evt.Name));
            lw.GoToColumn(level);
            lw.WriteLine("{");
            WriteCustomAttributes(lw, level + 2, evt.__GetCustomAttributes(null, false));
            IEnumerable<MethodInfo> accessors = evt.__GetMethods();
            if (diffMode)
            {
                accessors = accessors.OrderBy(x => x.Name);
            }
            foreach (var acc in accessors)
            {
                lw.GoToColumn(level + 2);
                if (acc == evt.GetAddMethod(true))
                {
                    lw.Write(".addon ");
                }
                else if (acc == evt.GetRemoveMethod(true))
                {
                    lw.Write(".removeon ");
                }
                else if (acc == evt.GetRaiseMethod(true))
                {
                    lw.Write(".fire ");
                }
                else
                {
                    lw.Write(".other ");
                }
                WriteCallingConvention(lw, acc.CallingConvention);
                WriteSignatureType(lw, acc.ReturnType);
                lw.Write(" ");
                WriteTypeDefOrRef(lw, acc.DeclaringType);
                lw.Write("::{0}(", QuoteIdentifier(GetMethodName(acc)));
                WriteParameters(lw, acc.GetParameters());
                lw.WriteLine(")");
            }
            lw.GoToColumn(level);
            lw.WriteLine("}} // end of event {0}::{1}", QuoteIdentifier(evt.DeclaringType.__Name), QuoteIdentifier(evt.Name));
        }

        void WriteProperty(LineWriter lw, PropertyInfo prop)
        {
            int level = lw.Column;
            lw.Write(".property ");
            if ((prop.Attributes & PropertyAttributes.SpecialName) != 0)
            {
                lw.Write("specialname ");
            }
            if ((prop.Attributes & PropertyAttributes.RTSpecialName) != 0)
            {
                lw.Write("rtspecialname ");
            }
            if (lw.Column > 40)
            {
                lw.WriteLine();
                lw.GoToColumn(level + 8);
            }
            WriteCallingConvention(lw, prop.__CallingConvention);
            WriteSignatureType(lw, prop.PropertyType);
            WriteCustomModifiers(lw, prop.__GetCustomModifiers());
            if (lw.Column > 40)
            {
                lw.WriteLine();
                lw.GoToColumn(level + 7);
            }
            lw.Write(" {0}(", QuoteIdentifier(prop.Name));
            WriteParameters(lw, prop.GetIndexParameters());
            lw.WriteLine(")");
            lw.GoToColumn(level);
            lw.WriteLine("{");
            WriteCustomAttributes(lw, level + 2, prop.__GetCustomAttributes(null, false));
            IEnumerable<MethodInfo> accessors = prop.GetAccessors(true);
            if (diffMode)
            {
                accessors = accessors.OrderBy(x => x.Name);
            }
            foreach (var acc in accessors)
            {
                lw.GoToColumn(level + 2);
                if (acc == prop.GetGetMethod(true))
                {
                    lw.Write(".get ");
                }
                else if (acc == prop.GetSetMethod(true))
                {
                    lw.Write(".set ");
                }
                else
                {
                    lw.Write(".other ");
                }
                WriteCallingConvention(lw, acc.CallingConvention);
                WriteSignatureType(lw, acc.ReturnType);
                WriteCustomModifiers(lw, acc.ReturnParameter.__GetCustomModifiers());
                lw.Write(" ");
                WriteTypeDefOrRef(lw, acc.DeclaringType);
                lw.Write("::{0}(", QuoteIdentifier(GetMethodName(acc)));
                WriteParameters(lw, acc.GetParameters());
                lw.WriteLine(")");
            }
            lw.GoToColumn(level);
            lw.WriteLine("}} // end of property {0}::{1}", QuoteIdentifier(prop.DeclaringType.Name), QuoteIdentifier(prop.Name));
        }

        void WriteParameters(LineWriter lw, ParameterInfo[] parameters)
        {
            int level = lw.Column;
            bool first = true;
            foreach (var parameter in parameters)
            {
                if (!first)
                {
                    lw.WriteLine(",");
                    lw.GoToColumn(level);
                }
                first = false;
                WriteSignatureType(lw, parameter.ParameterType);
                WriteCustomModifiers(lw, parameter.__GetCustomModifiers());
            }
        }

        void WriteMethod(LineWriter lw, MethodBase method)
        {
            int level0 = lw.Column;
            lw.Write(".method ");
            int level1 = lw.Column;
            switch (method.Attributes & MethodAttributes.MemberAccessMask)
            {
                case MethodAttributes.Public:
                    lw.Write("public ");
                    break;
                case MethodAttributes.Private:
                    lw.Write("private ");
                    break;
                case MethodAttributes.Assembly:
                    lw.Write("assembly ");
                    break;
                case MethodAttributes.Family:
                    lw.Write("family ");
                    break;
                case MethodAttributes.FamORAssem:
                    lw.Write("famorassem ");
                    break;
                case MethodAttributes.FamANDAssem:
                    lw.Write("famandassem ");
                    break;
                case MethodAttributes.PrivateScope:
                    lw.Write("privatescope ");
                    break;
            }
            if ((method.Attributes & MethodAttributes.HideBySig) != 0)
            {
                lw.Write("hidebysig ");
            }
            if ((method.Attributes & MethodAttributes.NewSlot) != 0)
            {
                lw.Write("newslot ");
            }
            if ((method.Attributes & MethodAttributes.SpecialName) != 0)
            {
                lw.Write("specialname ");
            }
            if ((method.Attributes & MethodAttributes.RTSpecialName) != 0)
            {
                lw.Write("rtspecialname ");
            }
            if ((method.Attributes & MethodAttributes.Abstract) != 0)
            {
                lw.Write("abstract ");
            }
            if ((method.Attributes & MethodAttributes.CheckAccessOnOverride) != 0)
            {
                lw.Write("strict ");
            }
            if ((method.Attributes & MethodAttributes.Virtual) != 0)
            {
                lw.Write("virtual ");
            }
            if ((method.Attributes & MethodAttributes.Final) != 0)
            {
                lw.Write("final ");
            }
            if ((method.Attributes & MethodAttributes.Static) != 0)
            {
                lw.Write("static ");
            }
            if ((method.Attributes & MethodAttributes.RequireSecObject) != 0)
            {
                lw.Write("reqsecobj ");
            }
            if ((method.Attributes & MethodAttributes.PinvokeImpl) != 0)
            {
                WritePInvokeImpl(lw, method);
            }
            if (lw.Column > 40)
            {
                lw.WriteLine();
                lw.GoToColumn(level1);
            }
            WriteCallingConvention(lw, method.CallingConvention);
            ParameterInfo returnParameter = method is ConstructorInfo ? ((ConstructorInfo)method).__ReturnParameter : ((MethodInfo)method).ReturnParameter;
            WriteInOutOpt(lw, returnParameter);
            WriteSignatureType(lw, returnParameter.ParameterType);
            WriteCustomModifiers(lw, returnParameter.__GetCustomModifiers());
            lw.Write(" ");
            if ((returnParameter.Attributes & ParameterAttributes.HasFieldMarshal) != 0)
            {
                var sb = new StringBuilder();
                FieldMarshal marshal;
                WriteMarshalAs(sb, level1 - 1, returnParameter.__TryGetFieldMarshal(out marshal), marshal, false);
                bool wrap = lw.Column + sb.Length > 40;
                if (wrap)
                {
                    lw.WriteLine();
                    lw.GoToColumn(level1 - 1);
                }
                lw.Write("{0}", sb);
                if (wrap)
                {
                    lw.WriteLine();
                    lw.GoToColumn(level1 - 1);
                }
            }
            if (lw.Column > 40)
            {
                lw.WriteLine();
                lw.GoToColumn(level1 - 1);
            }
            lw.Write(" {0}", QuoteIdentifier(GetMethodName(method)));
            if (method.IsGenericMethodDefinition)
            {
                WriteGenericParameterDef(lw, method.GetGenericArguments(), false);
            }
            lw.Write("(");
            int level2 = lw.Column;
            bool first = true;
            foreach (var parameter in method.GetParameters())
            {
                if (!first)
                {
                    lw.WriteLine(",");
                    lw.GoToColumn(level2);
                }
                first = false;
                WriteInOutOpt(lw, parameter);
                WriteSignatureType(lw, parameter.ParameterType, TypeLocation.Parameter);
                WriteCustomModifiers(lw, parameter.__GetCustomModifiers());
                lw.Write(" ");
                if ((parameter.Attributes & ParameterAttributes.HasFieldMarshal) != 0)
                {
                    FieldMarshal marshal;
                    WriteMarshalAs(lw, level2, parameter.__TryGetFieldMarshal(out marshal), marshal, true);
                }
                if (parameter.Name == null)
                {
                    lw.Write("A_{0}", parameter.Position + (method.IsStatic ? 0 : 1));
                }
                else
                {
                    lw.Write("{0}", QuoteIdentifier(parameter.Name));
                }
            }
            lw.Write(")");
            MethodImplAttributes implflags = method.GetMethodImplementationFlags();
            switch (implflags & MethodImplAttributes.CodeTypeMask)
            {
                case MethodImplAttributes.IL:
                    lw.Write(" cil");
                    break;
                case MethodImplAttributes.Native:
                    lw.Write(" native");
                    break;
                case MethodImplAttributes.OPTIL:
                    lw.Write(" optil");
                    break;
                case MethodImplAttributes.Runtime:
                    lw.Write(" runtime");
                    break;
            }
            if ((implflags & MethodImplAttributes.ManagedMask) == MethodImplAttributes.Managed)
            {
                lw.Write(" managed");
            }
            else
            {
                lw.Write(" unmanaged");
            }
            if ((implflags & MethodImplAttributes.Synchronized) != 0)
            {
                lw.Write(" synchronized");
            }
            if ((implflags & MethodImplAttributes.NoInlining) != 0)
            {
                lw.Write(" noinlining");
            }
            if ((implflags & MethodImplAttributes.PreserveSig) != 0)
            {
                lw.Write(" preservesig");
            }
            if ((implflags & MethodImplAttributes.InternalCall) != 0)
            {
                lw.Write(" internalcall");
            }
            if ((implflags & MethodImplAttributes.ForwardRef) != 0)
            {
                lw.Write(" forwardref");
            }
            if ((implflags & MethodImplAttributes.NoOptimization) != 0 && compat != CompatLevel.V20)
            {
                lw.Write(" nooptimization");
            }
            if ((implflags & MethodImplAttributes.AggressiveInlining) != 0 && compat != CompatLevel.V20 && compat != CompatLevel.V40)
            {
                lw.Write(" aggressiveinlining");
            }
            lw.WriteLine();
            lw.GoToColumn(level0);
            lw.WriteLine("{");
            if (method.MetadataToken == module.__EntryPointToken)
            {
                lw.GoToColumn(level0 + 2);
                lw.WriteLine(".entrypoint");
            }
            WriteCustomAttributes(lw, level0 + 2, method.__GetCustomAttributes(null, false));
            WriteGenericParameterCustomAttributes(lw, level0 + 2, method.GetGenericArguments());
            WriteParam(lw, level0 + 2, method is ConstructorInfo ? ((ConstructorInfo)method).__ReturnParameter : ((MethodInfo)method).ReturnParameter);
            foreach (var parameter in method.GetParameters())
            {
                WriteParam(lw, level0 + 2, parameter);
            }
            WriteDeclarativeSecurity(lw, level0 + 2, CustomAttributeData.__GetDeclarativeSecurity(method), method.MetadataToken);
            List<KeyValuePair<int, int>> vtentries;
            if (vtentryMap.TryGetValue(method, out vtentries))
            {
                foreach (var vtentry in vtentries)
                {
                    lw.GoToColumn(level0 + 2);
                    lw.WriteLine(".vtentry {0} : {1}", vtentry.Key, vtentry.Value);
                }
            }
            List<ExportedMethod> exports;
            if (exportedMethods.TryGetValue(method.MetadataToken, out exports))
            {
                foreach (var export in exports)
                {
                    lw.GoToColumn(level0 + 2);
                    lw.WriteLine(".export [{0}] as {1}", export.ordinal, QuoteIdentifier(export.name));
                }
            }
            if (method.DeclaringType != null && method is MethodInfo)
            {
                foreach (var impl in ((MethodInfo)method).__GetMethodImpls())
                {
                    lw.GoToColumn(level0 + 2);
                    lw.Write(".override ");
                    if (!impl.DeclaringType.__IsMissing && impl.DeclaringType.IsGenericType)
                    {
                        lw.Write(" method ");
                        WriteInlineMethod(lw, impl, Type.EmptyTypes, null, (MethodInfo)method);
                        lw.WriteLine();
                    }
                    else
                    {
                        WriteTypeDefOrRef(lw, impl.DeclaringType);
                        lw.Write("::");
                        lw.WriteLine("{0}", QuoteIdentifier(GetMethodName(impl)));
                    }
                }
            }
            MethodBody body = method.GetMethodBody();
            if (body != null)
            {
                lw.GoToColumn(level0 + 2);
                WriteIL(lw, method, body, method.DeclaringType == null ? null : method.DeclaringType.GetGenericArguments(), method.GetGenericArguments());
            }
            else if ((implflags & MethodImplAttributes.CodeTypeMask) == MethodImplAttributes.Native)
            {
                lw.GoToColumn(level0 + 2);
                lw.WriteLine("// Embedded native code");
                lw.GoToColumn(level0 + 2);
                lw.WriteLine("// Disassembly of native methods is not supported.");
                lw.GoToColumn(level0 + 2);
                lw.WriteLine("//  Managed TargetRVA = 0x{0:X8}", method.__MethodRVA);
            }
            lw.GoToColumn(level0);
            if ((method.Attributes & MethodAttributes.PinvokeImpl) != 0 && (implflags & MethodImplAttributes.CodeTypeMask) != MethodImplAttributes.Native)
            {
                lw.WriteLine("}");
            }
            else
            {
                string methodName = GetMethodName(method);
                if ((method.Attributes & MethodAttributes.MemberAccessMask) == MethodAttributes.PrivateScope)
                {
                    methodName = methodName.Substring(0, methodName.Length - 12);
                }
                if (method.DeclaringType == null)
                {
                    lw.WriteLine("}} // end of global method {0}", QuoteIdentifier(methodName));
                }
                else
                {
                    lw.WriteLine("}} // end of method {0}::{1}", QuoteIdentifier(method.DeclaringType.__Name), QuoteIdentifier(methodName));
                }
                lw.WriteLine();
            }
        }

        string GetMethodName(MethodBase method)
        {
            if (method.Module == module && (method.DeclaringType == null || !method.DeclaringType.IsArray))
            {
                return methodNames[method.__GetMethodOnTypeDefinition().MetadataToken - 0x06000001];
            }
            else
            {
                return method.Name;
            }
        }

        static void WriteInOutOpt(LineWriter lw, ParameterInfo parameter)
        {
            if (parameter.IsIn || parameter.IsOut || parameter.IsOptional)
            {
                if (parameter.IsIn)
                {
                    lw.Write("[in]");
                }
                if (parameter.IsOut)
                {
                    lw.Write("[out]");
                }
                if (parameter.IsOptional)
                {
                    lw.Write("[opt]");
                }
                lw.Write(" ");
            }
        }

        void WriteParam(LineWriter lw, int level, ParameterInfo parameter)
        {
            IList<CustomAttributeData> ca = parameter.__GetCustomAttributes(null, false);
            if (ca.Count != 0 || (parameter.Attributes & ParameterAttributes.HasDefault) != 0)
            {
                lw.GoToColumn(level);
                lw.Write(".param [{0}]", parameter.Position + 1);
                if ((parameter.Attributes & ParameterAttributes.HasDefault) != 0)
                {
                    lw.Write(" = ");
                    WriteConstant(lw, parameter.RawDefaultValue, level);
                }
                lw.WriteLine();
                WriteCustomAttributes(lw, level, ca);
            }
        }

        static string EscapePInvoke(string str)
        {
            return str
                .Replace("\\", "\\\\")
                .Replace("?", "\\?")
                .Replace("\n", "\\n")
                .Replace("\r", "\\r")
                .Replace("\t", "\\t")
                .Replace("\b", "\\b")
                .Replace("\f", "\\f")
                .Replace("\v", "\\v")
                .Replace("\a", "\\a")
                .Replace("\"", "\\\"")
                ;
        }

        void WritePInvokeImpl(LineWriter lw, MemberInfo member)
        {
            lw.Write("pinvokeimpl(");
            ImplMapFlags flags;
            string importName;
            string importScope;
            if (member.Module.__TryGetImplMap(member.MetadataToken, out flags, out importName, out importScope))
            {
                if (importScope != null)
                {
                    lw.Write("\"{0}\"", EscapePInvoke(importScope));
                }
                if (importName != null && importName != member.Name)
                {
                    lw.Write(" as \"{0}\"", EscapePInvoke(importName));
                }
                if ((flags & ImplMapFlags.NoMangle) != 0)
                {
                    lw.Write(" nomangle");
                }
                switch (flags & ImplMapFlags.CharSetMask)
                {
                    case ImplMapFlags.CharSetAnsi:
                        lw.Write(" ansi");
                        break;
                    case ImplMapFlags.CharSetAuto:
                        lw.Write(" autochar");
                        break;
                    case ImplMapFlags.CharSetUnicode:
                        lw.Write(" unicode");
                        break;
                }
                if ((flags & ImplMapFlags.SupportsLastError) != 0)
                {
                    lw.Write(" lasterr");
                }
                switch (flags & ImplMapFlags.CallConvMask)
                {
                    case ImplMapFlags.CallConvWinapi:
                        lw.Write(" winapi");
                        break;
                    case ImplMapFlags.CallConvStdcall:
                        lw.Write(" stdcall");
                        break;
                    case ImplMapFlags.CallConvCdecl:
                        lw.Write(" cdecl");
                        break;
                    case ImplMapFlags.CallConvThiscall:
                        lw.Write(" thiscall");
                        break;
                }
                switch (flags & (ImplMapFlags.BestFitOff | ImplMapFlags.BestFitOn))
                {
                    case ImplMapFlags.BestFitOn:
                        lw.Write(" bestfit:on");
                        break;
                    case ImplMapFlags.BestFitOff:
                        lw.Write(" bestfit:off");
                        break;
                }
                switch (flags & (ImplMapFlags.CharMapErrorOff | ImplMapFlags.CharMapErrorOn))
                {
                    case ImplMapFlags.CharMapErrorOn:
                        lw.Write(" charmaperror:on");
                        break;
                    case ImplMapFlags.CharMapErrorOff:
                        lw.Write(" charmaperror:off");
                        break;
                }
                lw.Write(") ");
            }
            else
            {
                lw.Write("/* No map */) ");
            }
        }

        void WriteMarshalAs(LineWriter lw, int level, bool hasFieldMarshalRecord, FieldMarshal marshal, bool wrap)
        {
            var sb = new StringBuilder();
            WriteMarshalAs(sb, level, hasFieldMarshalRecord, marshal, wrap);
            lw.Write(sb.ToString());
        }

        void WriteMarshalAs(StringBuilder sb, int level, bool hasFieldMarshalRecord, FieldMarshal marshal, bool wrap)
        {
            if (!hasFieldMarshalRecord)
            {
                if (compat == CompatLevel.None)
                {
                    sb.Append(" /*HasFieldMarshal*/ ");
                }
                return;
            }
            sb.Append(" marshal(");
            short? sizeParamIndex = marshal.SizeParamIndex;
            if (marshal.ArraySubType != null && marshal.UnmanagedType != System.Runtime.InteropServices.UnmanagedType.ByValArray)
            {
                sb.Append(UnmanagedTypeToString(marshal.ArraySubType.Value));
                switch (marshal.ArraySubType.Value)
                {
                    case System.Runtime.InteropServices.UnmanagedType.IUnknown:
                    case System.Runtime.InteropServices.UnmanagedType.Interface:
                        if (marshal.SizeParamIndex == null)
                        {
                            sb.Append(" ");
                        }
                        else
                        {
                            sb.AppendFormat("(iidparam = {0}) ", marshal.SizeParamIndex.Value);
                            sizeParamIndex = null;
                        }
                        break;
                }
            }
            if (marshal.SafeArraySubType != null && marshal.UnmanagedType == System.Runtime.InteropServices.UnmanagedType.SafeArray)
            {
                sb.Append(VarEnumToString(marshal.SafeArraySubType.Value));
            }
            else if (marshal.UnmanagedType == System.Runtime.InteropServices.UnmanagedType.LPArray
                && (marshal.SizeConst != null || sizeParamIndex != null))
            {
                // don't write [] it's implied by the following sizeConst or sizeParamIndex
            }
            else
            {
                sb.Append(UnmanagedTypeToString(marshal.UnmanagedType));
                if (marshal.IidParameterIndex == null
                    && (marshal.UnmanagedType == System.Runtime.InteropServices.UnmanagedType.Interface
                    || marshal.UnmanagedType == System.Runtime.InteropServices.UnmanagedType.IUnknown))
                {
                    sb.Append(" ");
                }
            }
            if (marshal.SizeConst != null)
            {
                if (marshal.UnmanagedType != System.Runtime.InteropServices.UnmanagedType.LPArray)
                {
                    sb.Append(" ");
                }
                if (sizeParamIndex != null || (compat != CompatLevel.None && !IsFixed(marshal.UnmanagedType)))
                {
                    sb.AppendFormat("[{0} + {1}]", marshal.SizeConst.Value, sizeParamIndex.GetValueOrDefault());
                }
                else
                {
                    sb.AppendFormat("[{0}]", marshal.SizeConst.Value);
                }
            }
            else if (sizeParamIndex != null)
            {
                sb.AppendFormat("[ + {0}]", sizeParamIndex.Value);
            }
            if (marshal.SafeArrayUserDefinedSubType != null)
            {
                sb.AppendFormat(", \"{0}\"", marshal.SafeArrayUserDefinedSubType);
            }
            if (marshal.IidParameterIndex != null)
            {
                sb.AppendFormat("(iidparam = {0}) ", marshal.IidParameterIndex.Value);
            }
            if (marshal.MarshalType != null || marshal.MarshalCookie != null)
            {
                sb.AppendFormat("(\"{0}\",", marshal.MarshalType);
                if (wrap)
                {
                    sb.AppendLine();
                    sb.Append(' ', level);
                }
                sb.AppendFormat("\"{0}\")", marshal.MarshalCookie);
            }
            if (marshal.ArraySubType != null && marshal.UnmanagedType == System.Runtime.InteropServices.UnmanagedType.ByValArray)
            {
                sb.Append(UnmanagedTypeToString(marshal.ArraySubType.Value));
            }
            sb.Append(") ");
        }

        static string VarEnumToString(System.Runtime.InteropServices.VarEnum value)
        {
            switch (value)
            {
                case System.Runtime.InteropServices.VarEnum.VT_VARIANT:
                    return " safearray variant";
                case System.Runtime.InteropServices.VarEnum.VT_I1:
                    return " safearray int8";
                case System.Runtime.InteropServices.VarEnum.VT_I2:
                    return " safearray int16";
                case System.Runtime.InteropServices.VarEnum.VT_I4:
                    return " safearray int32";
                case System.Runtime.InteropServices.VarEnum.VT_I8:
                    return " safearray int64";
                case System.Runtime.InteropServices.VarEnum.VT_UI1:
                    return " safearray unsigned int8";
                case System.Runtime.InteropServices.VarEnum.VT_UI2:
                    return " safearray unsigned int16";
                case System.Runtime.InteropServices.VarEnum.VT_UI4:
                    return " safearray unsigned int32";
                case System.Runtime.InteropServices.VarEnum.VT_UI8:
                    return " safearray unsigned int64";
                case System.Runtime.InteropServices.VarEnum.VT_R4:
                    return " safearray float32";
                case System.Runtime.InteropServices.VarEnum.VT_R8:
                    return " safearray float64";
                case System.Runtime.InteropServices.VarEnum.VT_BSTR:
                    return " safearray bstr";
                case System.Runtime.InteropServices.VarEnum.VT_BOOL:
                    return " safearray bool";
                case System.Runtime.InteropServices.VarEnum.VT_UNKNOWN:
                    return " safearray iunknown";
                case System.Runtime.InteropServices.VarEnum.VT_RECORD:
                    return " safearray record";
                case System.Runtime.InteropServices.VarEnum.VT_DISPATCH:
                    return " safearray idispatch";
                case System.Runtime.InteropServices.VarEnum.VT_EMPTY:
                    return " safearray";
                default:
                    Console.WriteLine(value);
                    return "";
            }
        }

        static bool IsFixed(System.Runtime.InteropServices.UnmanagedType unmanagedType)
        {
            switch (unmanagedType)
            {
                case System.Runtime.InteropServices.UnmanagedType.ByValArray:
                case System.Runtime.InteropServices.UnmanagedType.ByValTStr:
                    return true;
                default:
                    return false;
            }
        }

        string UnmanagedTypeToString(System.Runtime.InteropServices.UnmanagedType unmanagedType)
        {
            switch (unmanagedType)
            {
                case System.Runtime.InteropServices.UnmanagedType.Bool:
                    return " bool";
                case System.Runtime.InteropServices.UnmanagedType.SysInt:
                    return " int";
                case System.Runtime.InteropServices.UnmanagedType.SysUInt:
                    return " uint";
                case System.Runtime.InteropServices.UnmanagedType.I1:
                    return " int8";
                case System.Runtime.InteropServices.UnmanagedType.I2:
                    return " int16";
                case System.Runtime.InteropServices.UnmanagedType.I4:
                    return " int32";
                case System.Runtime.InteropServices.UnmanagedType.I8:
                    return " int64";
                case System.Runtime.InteropServices.UnmanagedType.U1:
                    return " unsigned int8";
                case System.Runtime.InteropServices.UnmanagedType.U2:
                    return " unsigned int16";
                case System.Runtime.InteropServices.UnmanagedType.U4:
                    return " unsigned int32";
                case System.Runtime.InteropServices.UnmanagedType.U8:
                    return " unsigned int64";
                case System.Runtime.InteropServices.UnmanagedType.R4:
                    return " float32";
                case System.Runtime.InteropServices.UnmanagedType.R8:
                    return " float64";
                case System.Runtime.InteropServices.UnmanagedType.BStr:
                    return " bstr";
                case System.Runtime.InteropServices.UnmanagedType.LPWStr:
                    return " lpwstr";
                case System.Runtime.InteropServices.UnmanagedType.SafeArray:
                    return " safearray";
                case System.Runtime.InteropServices.UnmanagedType.ByValArray:
                    return " fixed array";
                case System.Runtime.InteropServices.UnmanagedType.ByValTStr:
                    return " fixed sysstring";
                case System.Runtime.InteropServices.UnmanagedType.IUnknown:
                    return " iunknown";
                case System.Runtime.InteropServices.UnmanagedType.Interface:
                    return " interface";
                case System.Runtime.InteropServices.UnmanagedType.CustomMarshaler:
                    return " custom ";
                case System.Runtime.InteropServices.UnmanagedType.LPArray:
                    return "[]";
                case System.Runtime.InteropServices.UnmanagedType.AsAny:
                    return " as any";
                case System.Runtime.InteropServices.UnmanagedType.LPStruct:
                    return " lpstruct";
                case System.Runtime.InteropServices.UnmanagedType.IDispatch:
                    return " idispatch ";
                case System.Runtime.InteropServices.UnmanagedType.Struct:
                    return " struct";
                case System.Runtime.InteropServices.UnmanagedType.FunctionPtr:
                    return " method";
                case System.Runtime.InteropServices.UnmanagedType.LPStr:
                    return " lpstr";
                case System.Runtime.InteropServices.UnmanagedType.Error:
                    return " error";
                case System.Runtime.InteropServices.UnmanagedType.LPTStr:
                    return " lptstr";
                case System.Runtime.InteropServices.UnmanagedType.VBByRefStr:
                    return " byvalstr";
                case System.Runtime.InteropServices.UnmanagedType.Currency:
                    return " currency";
                case System.Runtime.InteropServices.UnmanagedType.VariantBool:
                    return " variant bool";
                case (System.Runtime.InteropServices.UnmanagedType)80:
                    return "";  // Microsoft.SqlServer.DTSRuntimeWrap.dll (9.0.242.0) has this bogus value
                case (System.Runtime.InteropServices.UnmanagedType)46:
                    return compat == CompatLevel.None ? " iinspectable" : compat == CompatLevel.V45 ? "{ 2E }" : "";
                case (System.Runtime.InteropServices.UnmanagedType)47:
                    return compat == CompatLevel.None ? " hstring" : compat == CompatLevel.V45 ? "{ 2F }" : "";
                default:
                    Console.WriteLine("unsupported unmanagedType in marshal blob: {0}", unmanagedType);
                    return "";
            }
        }

        string QuoteIdentifier(string str, bool quote = false)
        {
            if (diffMode)
            {
                if (str.StartsWith("$$method0x", StringComparison.Ordinal))
                {
                    return "'$$method0x...'";
                }
                else if (str.Length == 68 && str.StartsWith("<PrivateImplementationDetails>{", StringComparison.Ordinal) && str.EndsWith("}", StringComparison.Ordinal))
                {
                    return "'<PrivateImplementationDetails>{nnnnnnnn-nnnn-nnnn-nnnn-nnnnnnnnnnnn}'";
                }
                for (int pos, cur = 0; (pos = str.IndexOf("?A0x", cur)) != -1; cur = pos + 4)
                {
                    str = str.Substring(0, pos + 4) + "________" + str.Substring(pos + 12);
                }
            }
            quote |= str.Length > 0 && "0123456789".IndexOf(str[0]) != -1;
            for (int i = str.IndexOf('.'); i != -1 && i < str.Length - 1; i = str.IndexOf('.', i + 1))
            {
                if ("0123456789".IndexOf(str[i + 1]) != -1)
                {
                    quote = true;
                    break;
                }
            }
            foreach (char c in str)
            {
                if (c <= 32 || c >= 127)
                {
                    quote = true;
                    break;
                }
            }
            Escape(ref str, ref quote, "\\", "\\\\");
            Escape(ref str, ref quote, "'", "\\'");
            Escape(ref str, ref quote, "\"", "\\\"");
            Escape(ref str, ref quote, "\t", "\\t");
            Escape(ref str, ref quote, "\r", "\\r");
            Escape(ref str, ref quote, "\n", "\\n");
            Escape(ref str, ref quote, "\a", "\\a");
            Escape(ref str, ref quote, "\b", "\\b");
            Escape(ref str, ref quote, "\u0000", "\\u0000");
            if (compat == CompatLevel.V20 || compat == CompatLevel.V40)
            {
                StringBuilder sb = null;
                for (int i = 0; i < str.Length; i++)
                {
                    if (str[i] >= 128)
                    {
                        if (sb == null)
                        {
                            sb = new StringBuilder(str);
                        }
                        sb[i] = '\uFFFD';
                    }
                }
                if (sb != null)
                {
                    str = sb.ToString();
                }
            }
            if (keywords.Contains(str))
            {
                return "'" + str + "'";
            }
            else if (quote
                || str.IndexOf('<') != -1
                || str.IndexOf('>') != -1
                || str.StartsWith("?")
                || (str.StartsWith(".") && str != ".ctor" && str != ".cctor")
                || str.Contains(".?")
                || str.Contains("..")
                || str.IndexOf('{') != -1
                || str.IndexOf('}') != -1
                || str.IndexOf('[') != -1
                || str.IndexOf(']') != -1
                || str.IndexOf('!') != -1
                || str.IndexOf('/') != -1
                || str.IndexOf('=') != -1
                || str.IndexOf('+') != -1
                || str.IndexOf(':') != -1
                || str.IndexOf('|') != -1
                || str.IndexOf('~') != -1
                || str.IndexOf('^') != -1
                || str.IndexOf('-') != -1)
            {
                return "'" + str + "'";
            }
            else
            {
                return str;
            }
        }

        static void Escape(ref string str, ref bool quote, string ch, string esc)
        {
            if (str.IndexOf(ch) != -1)
            {
                quote = true;
                str = str.Replace(ch, esc);
            }
        }

        void WriteField(LineWriter lw, FieldInfo field)
        {
            int level = lw.Column;
            lw.Write(".field ");
            int offset;
            if (field.__TryGetFieldOffset(out offset))
            {
                lw.Write("[{0}] ", offset);
            }
            switch (field.Attributes & FieldAttributes.FieldAccessMask)
            {
                case FieldAttributes.Public:
                    lw.Write("public ");
                    break;
                case FieldAttributes.Private:
                    lw.Write("private ");
                    break;
            }
            if ((field.Attributes & FieldAttributes.Static) != 0)
            {
                lw.Write("static ");
            }
            switch (field.Attributes & FieldAttributes.FieldAccessMask)
            {
                case FieldAttributes.Family:
                    lw.Write("family ");
                    break;
                case FieldAttributes.Assembly:
                    lw.Write("assembly ");
                    break;
                case FieldAttributes.FamORAssem:
                    lw.Write("famorassem ");
                    break;
                case FieldAttributes.PrivateScope:
                    lw.Write("privatescope ");
                    break;
            }
            if ((field.Attributes & FieldAttributes.InitOnly) != 0)
            {
                lw.Write("initonly ");
            }
            if ((field.Attributes & FieldAttributes.Literal) != 0)
            {
                lw.Write("literal ");
            }
            if ((field.Attributes & FieldAttributes.SpecialName) != 0)
            {
                lw.Write("specialname ");
            }
            if ((field.Attributes & FieldAttributes.RTSpecialName) != 0)
            {
                lw.Write("rtspecialname ");
            }
            if ((field.Attributes & FieldAttributes.NotSerialized) != 0)
            {
                lw.Write("notserialized ");
            }
            if ((field.Attributes & FieldAttributes.PinvokeImpl) != 0)
            {
                WritePInvokeImpl(lw, field);
            }
            if ((field.Attributes & FieldAttributes.HasFieldMarshal) != 0)
            {
                FieldMarshal marshal;
                WriteMarshalAs(lw, level, field.__TryGetFieldMarshal(out marshal), marshal, false);
            }
            WriteSignatureType(lw, field.FieldType);
            WriteCustomModifiers(lw, field.__GetCustomModifiers());
            lw.Write(" {0}", QuoteIdentifier(GetFieldName(field)));
            if ((field.Attributes & FieldAttributes.HasDefault) != 0)
            {
                lw.Write(" = ");
                WriteConstant(lw, field.GetRawConstantValue(), level);
            }
            if ((field.Attributes & FieldAttributes.HasFieldRVA) != 0)
            {
                dataFields.Add(field);
                string name;
                int characteristics;
                if (module.__GetSectionInfo(field.__FieldRVA, out name, out characteristics))
                {
                    switch (name)
                    {
                        case ".text":
                            lw.Write(" at I_");
                            break;
                        case ".tls":
                            lw.Write(" at T_");
                            break;
                        default:
                            lw.Write(" at D_");
                            break;
                    }
                    if (diffMode)
                    {
                        lw.Write("xxxxxxxx");
                    }
                    else
                    {
                        lw.Write("{0:X8}", field.__FieldRVA);
                    }
                }
                else
                {
                    lw.Write(" at 0x{0:X8} /* WARNING: rogue pointer! (size 0x{1:X8}) */", field.__FieldRVA, GetTypeSize(field.FieldType));
                }
            }
            lw.WriteLine();
            WriteCustomAttributes(lw, level, field.__GetCustomAttributes(null, false));
        }

        string GetFieldName(FieldInfo field)
        {
            if (field.Module == module)
            {
                return fieldNames[field.__GetFieldOnTypeDefinition().MetadataToken - 0x04000001];
            }
            else
            {
                return field.Name;
            }
        }

        void WriteCustomModifiers(LineWriter lw, CustomModifiers mods)
        {
            foreach (var mod in mods)
            {
                lw.Write(" {0}(", mod.IsRequired ? "modreq" : "modopt");
                if (mod.Type.__IsBuiltIn)
                {
                    WriteSignatureType(lw, mod.Type);
                }
                else
                {
                    WriteTypeDefOrRef(lw, mod.Type);
                }
                lw.Write(")");
            }
        }

        void WriteModuleManifest(LineWriter lw)
        {
            lw.WriteLine("// Metadata version: {0}", module.__ImageRuntimeVersion);
            foreach (var refmodule in module.__GetReferencedModules())
            {
                if (!String.IsNullOrEmpty(refmodule))
                {
                    lw.WriteLine(".module extern {0}", QuoteIdentifier(refmodule));
                }
            }
            AssemblyName[] referencedAssemblies = module.__GetReferencedAssemblies();
            for (int i = 0; i < referencedAssemblies.Length; i++)
            {
                AssemblyName asm = referencedAssemblies[i];
                lw.Write(".assembly extern ");
                if ((asm.Flags & AssemblyNameFlags.Retargetable) != 0)
                {
                    lw.Write("retargetable ");
                }
                if (asm.ContentType == AssemblyContentType.WindowsRuntime && (compat == CompatLevel.None || compat >= CompatLevel.V45))
                {
                    lw.Write("windowsruntime ");
                }
                switch (asm.ProcessorArchitecture)
                {
                    case ProcessorArchitecture.MSIL:
                        lw.Write("cil ");
                        break;
                    case ProcessorArchitecture.X86:
                        lw.Write("x86 ");
                        break;
                    case ProcessorArchitecture.IA64:
                        lw.Write("ia64 ");
                        break;
                    case ProcessorArchitecture.Amd64:
                        lw.Write("amd64 ");
                        break;
                    case ProcessorArchitecture.Arm:
                        if (compat == CompatLevel.None)
                        {
                            lw.Write("/*arm*/ ");
                        }
                        break;
                }
                lw.Write(QuoteIdentifier(asm.Name));
                if (asm.Name != this.FindReferencedAssembly(resolvedAssemblies[i]))
                {
                    lw.Write(" as {0}", QuoteIdentifier(this.FindReferencedAssembly(resolvedAssemblies[i])));
                }
                lw.WriteLine();
                lw.WriteLine("{");
                byte[] token = asm.GetPublicKeyToken();
                if (token != null && token.Length != 0)
                {
                    lw.Write("  .publickeytoken = (");
                    WriteBytes(lw, token, false);
                    lw.WriteLine();
                }
                if (asm.__Hash != null)
                {
                    lw.Write("  .hash = (");
                    WriteBytes(lw, asm.__Hash, false);
                    lw.WriteLine();
                }
                lw.WriteLine("  .ver {0}:{1}:{2}:{3}", asm.Version.Major, asm.Version.Minor, asm.Version.Build, asm.Version.Revision);
                lw.WriteLine("}");
            }
        }

        void WriteAssemblyManifest(LineWriter lw)
        {
            lw.WriteLine(".assembly {0}{1}{2}",
                ((int)assembly.__AssemblyFlags & 16) != 0 ? "cil " : "",
                ((int)assembly.__AssemblyFlags & 512) != 0 && (compat == CompatLevel.None || compat >= CompatLevel.V45) ? "windowsruntime " : "",
                QuoteIdentifier(assembly.GetName().Name));
            lw.WriteLine("{");
            IEnumerable<CustomAttributeData> cas = assembly.__GetCustomAttributes(null, false);
            if (diffMode)
            {
                cas = cas.OrderBy(x => x.Constructor.DeclaringType.FullName);
            }
            foreach (var ca in cas)
            {
                if (compat != CompatLevel.None && IsDebuggableAttribute(ca.AttributeType))
                {
                    lw.WriteLine();
                    lw.WriteLine("  // --- The following custom attribute is added automatically, do not uncomment -------");
                    lw.Write("  //  .custom ");
                    WriteCustomAttributeImpl(lw, ca, true, lw.Column);
                    lw.WriteLine();
                }
                else
                {
                    lw.Write("  ");
                    WriteCustomAttribute(lw, ca);
                }
            }
            WriteDeclarativeSecurity(lw, 2, CustomAttributeData.__GetDeclarativeSecurity(assembly), 0x20000001);
            byte[] publicKey = assembly.GetName().GetPublicKey();
            if (publicKey != null && publicKey.Length != 0)
            {
                lw.Write("  .publickey = (");
                WriteBytes(lw, publicKey, false);
                lw.WriteLine();
            }
            if (assembly.GetName().HashAlgorithm != 0)
            {
                lw.WriteLine("  .hash algorithm 0x{0:X8}", (int)assembly.GetName().HashAlgorithm);
            }
            lw.WriteLine("  .ver {0}:{1}:{2}:{3}", assembly.GetName().Version.Major, assembly.GetName().Version.Minor, assembly.GetName().Version.Build, assembly.GetName().Version.Revision);
            if (assembly.GetName().CultureInfo != null)
            {
                string culture = assembly.GetName().CultureInfo.Name;
                if (culture != "")
                {
                    lw.Write("  .locale = (");
                    byte[] buf = new byte[culture.Length * 2 + 2];
                    for (int i = 0; i < culture.Length; i++)
                    {
                        buf[i * 2 + 0] = (byte)(culture[i] >> 0);
                        buf[i * 2 + 1] = (byte)(culture[i] >> 8);
                    }
                    WriteBytes(lw, buf, false);
                    lw.WriteLine();
                }
            }
            lw.WriteLine("}");
        }

        static bool IsDebuggableAttribute(Type type)
        {
            return !type.IsNested
                && (type.__IsMissing || !type.IsGenericType)
                && !type.HasElementType
                && !type.__IsFunctionPointer
                && type.__Name == "DebuggableAttribute"
                && type.__Namespace == "System.Diagnostics";
        }

        void WriteDeclarativeSecurity(LineWriter lw, int level, IEnumerable<CustomAttributeData> list, int metadataToken)
        {
            if (diffMode)
            {
                list = list.OrderBy(cad => cad.ConstructorArguments[0].Value);
            }
            var action = (System.Security.Permissions.SecurityAction)(- 1);
            var curr = new List<CustomAttributeData>();
            foreach (var sec in list)
            {
                if (action == (System.Security.Permissions.SecurityAction)sec.ConstructorArguments[0].Value)
                {
                    curr.Add(sec);
                }
                else
                {
                    WritePermissionSet(lw, level, action, curr, metadataToken);
                    curr.Clear();
                    curr.Add(sec);
                    action = (System.Security.Permissions.SecurityAction)sec.ConstructorArguments[0].Value;
                }
            }
            WritePermissionSet(lw, level, action, curr, metadataToken);
        }

        void WritePermissionSet(LineWriter lw, int level, System.Security.Permissions.SecurityAction action, List<CustomAttributeData> list, int metadataToken)
        {
            if (list.Count != 0)
            {
                lw.GoToColumn(level);
                lw.Write(".permissionset ");
                switch (action)
                {
                    case System.Security.Permissions.SecurityAction.Assert:
                        lw.Write("assert");
                        break;
                    case System.Security.Permissions.SecurityAction.RequestMinimum:
                        lw.Write("reqmin");
                        break;
                    case System.Security.Permissions.SecurityAction.RequestRefuse:
                        lw.Write("reqrefuse");
                        break;
                    case System.Security.Permissions.SecurityAction.RequestOptional:
                        lw.Write("reqopt");
                        break;
                    case System.Security.Permissions.SecurityAction.Demand:
                        lw.Write("demand");
                        break;
                    case System.Security.Permissions.SecurityAction.LinkDemand:
                        lw.Write("linkcheck");
                        break;
                    case System.Security.Permissions.SecurityAction.InheritanceDemand:
                        lw.Write("inheritcheck");
                        break;
                }
                lw.WriteLine();
                lw.GoToColumn(level);
                var sb = new StringBuilder();
                if (list.Count == 1)
                {
                    try
                    {
                        var args = list[0].NamedArguments;
                        if (args.Count == 1 && args[0].MemberInfo.Name == "XML")
                        {
                            if (compat >= CompatLevel.V45)
                            {
                                // starting with 4.5 ildasm no longer supports the 1.1 format
                                lw.Write("          bytearray (");
                                WriteBytes(lw, Encoding.Unicode.GetBytes((string)args[0].TypedValue.Value), false);
                                lw.WriteLine();
                                return;
                            }
                            lw.Write("          ");
                            WriteInlineString(lw, (string)args[0].TypedValue.Value, level);
                            lw.WriteLine();
                            return;
                        }
                    }
                    catch (IKVM.Reflection.MissingMemberException) { }
                }
                if (DecodeDeclSecurity(sb, list, level))
                {
                    lw.WriteLine("{0}", sb);
                }
                else
                {
                    var mem = new System.IO.MemoryStream();
                    mem.WriteByte((byte)'.');
                    WriteCompressedInt(mem, list.Count);
                    foreach (var sec in list)
                    {
                        Write(mem, sec.Constructor.DeclaringType.AssemblyQualifiedName.Replace(", PublicKeyToken=null", ""));
                        byte[] buf = sec.__GetBlob();
                        WriteCompressedInt(mem, buf.Length);
                        mem.Write(buf, 0, buf.Length);
                    }
                    byte[] blob = mem.ToArray();
                    if ((compat == CompatLevel.V20 || compat == CompatLevel.V40) && (blob.Length & 1) == 1)
                    {
                        // ildasm bug http://connect.microsoft.com/VisualStudio/feedback/details/652653/
                        Array.Resize(ref blob, blob.Length - 1);
                    }
                    lw.Write("          bytearray (");
                    WriteBytes(lw, blob, false);
                    lw.WriteLine();
                }
            }
        }

        void Write(System.IO.MemoryStream mem, string str)
        {
            if (str == null)
            {
                mem.WriteByte((byte)0xFF);
            }
            else
            {
                byte[] buf = Encoding.UTF8.GetBytes(str);
                WriteCompressedInt(mem, buf.Length);
                mem.Write(buf, 0, buf.Length);
            }
        }

        void WriteCompressedInt(System.IO.MemoryStream mem, int value)
        {
            if (value <= 0x7F)
            {
                mem.WriteByte((byte)value);
            }
            else if (value <= 0x3FFF)
            {
                mem.WriteByte((byte)(0x80 | (value >> 8)));
                mem.WriteByte((byte)value);
            }
            else
            {
                mem.WriteByte((byte)(0xC0 | (value >> 24)));
                mem.WriteByte((byte)(value >> 16));
                mem.WriteByte((byte)(value >> 8));
                mem.WriteByte((byte)value);
            }
        }

        void WriteDeclarativeSecurity(LineWriter lw, int level, CustomAttributeData sec)
        {
            if (!typerefs.Contains(sec.Constructor.DeclaringType))
            {
                lw.Write("class '{0}'", sec.Constructor.DeclaringType.AssemblyQualifiedName.Replace(", PublicKeyToken=null", ""));
            }
            else
            {
                WriteTypeDefOrRef(lw, sec.Constructor.DeclaringType);
            }
            lw.Write(" = {");
            bool first = true;
            foreach (var arg in sec.NamedArguments)
            {
                if (!first)
                {
                    lw.WriteLine();
                }
                first = false;
                lw.Write(arg.MemberInfo is PropertyInfo ? "property " : "field ");
                if (!arg.TypedValue.ArgumentType.__IsMissing && arg.TypedValue.ArgumentType.IsEnum)
                {
                    lw.Write("enum ");
                    WriteTypeDefOrRef(lw, arg.TypedValue.ArgumentType);
                }
                else
                {
                    WriteSignatureType(lw, arg.TypedValue.ArgumentType);
                }
                lw.Write(" {0} = ", QuoteIdentifier(arg.MemberInfo.Name, true));
                WriteAttributeValue(lw, arg.TypedValue.Value);
            }
            lw.Write("}");
        }

        void WriteAttributeValue(LineWriter lw, object obj)
        {
            if (obj is byte)
            {
                lw.Write("uint8({0})", obj);
            }
            else if (obj is sbyte)
            {
                lw.Write("int8({0})", obj);
            }
            else if (obj is bool)
            {
                lw.Write("bool({0})", ((bool)obj) ? "true" : "false");
            }
            else if (obj is char)
            {
                lw.Write("char(0x{0:X4})", (int)(char)obj);
            }
            else if (obj is short)
            {
                lw.Write("int16({0})", obj);
            }
            else if (obj is ushort)
            {
                lw.Write("uint16({0})", obj);
            }
            else if (obj is int)
            {
                lw.Write("int32({0})", obj);
            }
            else if (obj is uint)
            {
                lw.Write("uint32({0})", obj);
            }
            else if (obj is long)
            {
                lw.Write("int64({0})", obj);
            }
            else if (obj is ulong)
            {
                lw.Write("uint64({0})", obj);
            }
            else if (obj is float)
            {
                lw.Write("float32(");
                WriteShortInlineR(lw, (float)obj, true);
                lw.Write(")");
            }
            else if (obj is double)
            {
                lw.Write("float64(");
                WriteInlineR(lw, (double)obj, true);
                lw.Write(")");
            }
            else if (obj is string)
            {
                lw.Write("string({0})", QuoteIdentifier((string)obj, true));
            }
            else if (obj == null)
            {
                lw.Write("nullref");
            }
        }

        void WriteConstant(LineWriter lw, object obj, int level)
        {
            if (obj is byte)
            {
                lw.Write("uint8(0x{0:X2})", obj);
            }
            else if (obj is sbyte)
            {
                lw.Write("int8(0x{0:X2})", obj);
            }
            else if (obj is bool)
            {
                lw.Write("bool({0})", ((bool)obj) ? "true" : "false");
            }
            else if (obj is char)
            {
                lw.Write("char(0x{0:X4})", (int)(char)obj);
            }
            else if (obj is short)
            {
                lw.Write("int16(0x{0:X4})", obj);
            }
            else if (obj is ushort)
            {
                lw.Write("uint16(0x{0:X4})", obj);
            }
            else if (obj is int)
            {
                lw.Write("int32(0x{0:X8})", obj);
            }
            else if (obj is uint)
            {
                lw.Write("uint32(0x{0:X8})", obj);
            }
            else if (obj is long)
            {
                lw.Write("int64(0x{0:X})", obj);
            }
            else if (obj is ulong)
            {
                lw.Write("uint64(0x{0:X})", obj);
            }
            else if (obj is float)
            {
                lw.Write("float32(");
                WriteShortInlineR(lw, (float)obj, true);
                lw.Write(")");
            }
            else if (obj is double)
            {
                double v = (double)obj;
                lw.Write("float64(");
                WriteInlineR(lw, v, true);
                lw.Write(")");
                if (Double.IsNegativeInfinity(v))
                {
                    lw.Write(" // -1.#INF");
                }
                else if (Double.IsPositiveInfinity(v))
                {
                    lw.Write(" // 1.#INF");
                }
                else if (Double.IsNaN(v))
                {
                    if (BitConverter.DoubleToInt64Bits(v) == 0x7FF8000000000000L)
                    {
                        lw.Write(" // 1.#QNAN");
                    }
                    else
                    {
                        lw.Write(" // -1.#IND");
                    }
                }
            }
            else if (obj is string)
            {
                WriteInlineString(lw, (string)obj, level);
            }
            else if (obj == null)
            {
                lw.Write("nullref");
            }
        }

        void WriteResources(LineWriter lw)
        {
            foreach (var resourceName in assembly.GetManifestResourceNames())
            {
                ManifestResourceInfo mres = assembly.GetManifestResourceInfo(resourceName);
                string access;
                switch (mres.__ResourceAttributes)
                {
                    case ResourceAttributes.Public:
                        access = "public ";
                        break;
                    case ResourceAttributes.Private:
                        access = "private ";
                        break;
                    default:
                        access = "";
                        break;
                }
                lw.WriteLine(".mresource {0}{1}", access, QuoteIdentifier(resourceName));
                lw.WriteLine("{");
                if (mres.FileName != null)
                {
                    lw.WriteLine("  .file {0} at 0x{1:x8}", QuoteIdentifier(mres.FileName), mres.__Offset);
                }
                else if (mres.ReferencedAssembly != null)
                {
                    lw.WriteLine("  .assembly extern {0}", QuoteIdentifier(FindReferencedAssembly(mres.ReferencedAssembly)));
                }
                else
                {
                    lw.WriteLine("  // Offset: 0x{0:X8} Length: 0x{1:X8}", mres.__Offset, assembly.GetManifestResourceStream(resourceName).Length);
                    lw.WriteLine("  // WARNING: managed resource file {0} created", QuoteIdentifier(resourceName));
                }
                lw.WriteLine("}");
            }
        }

        void WriteModuleHeader(LineWriter lw)
        {
            lw.WriteLine(".module {0}", QuoteIdentifier(module.ScopeName));
            if (!diffMode)
            {
                lw.WriteLine("// MVID: {0}", module.ModuleVersionId.ToString("B").ToUpperInvariant());
            }
            WriteCustomAttributes(lw, 0, module.__GetCustomAttributes(null, false));
            if (compat == CompatLevel.V20 || GetPointerSize() == 4)
            {
                lw.WriteLine(".imagebase 0x{0:x8}", module.__ImageBase);
            }
            else
            {
                lw.WriteLine(".imagebase 0x{0:x16}", module.__ImageBase);
            }
            lw.WriteLine(".file alignment 0x{0:x8}", module.__FileAlignment);
            if (GetPointerSize() == 4)
            {
                lw.WriteLine(".stackreserve 0x{0:x8}", module.__StackReserve);
            }
            else
            {
                lw.WriteLine(".stackreserve 0x{0:x16}", module.__StackReserve);
            }
            lw.WriteLine(".subsystem 0x{0:x4}       // {1}", module.__Subsystem, SubsystemToString(module.__Subsystem));
            int corflags = GetCorFlags();
            lw.WriteLine(".corflags 0x{0:x8}{1}", corflags, CorFlagsToString(corflags));
        }

        static string CorFlagsToString(int flags)
        {
            StringBuilder sb = new StringBuilder();
            if (flags != 0)
            {
                sb.Append("    // ");
            }
            if ((flags & COMIMAGE_FLAGS_ILONLY) != 0)
            {
                sb.Append(" ILONLY");
            }
            if ((flags & COMIMAGE_FLAGS_IL_LIBRARY) != 0)
            {
                sb.Append(" IL_LIBRARY");
            }
            if ((flags & COMIMAGE_FLAGS_32BITREQUIRED) != 0)
            {
                sb.Append(" 32BITREQUIRED");
            }
            return sb.ToString();
        }

        int GetCorFlags()
        {
            int rva;
            int length;
            module.__GetDataDirectoryEntry(14, out rva, out length);
            var buf = new byte[4];
            module.__ReadDataFromRVA(rva + 16, buf, 0, 4);
            return BitConverter.ToInt32(buf, 0);
        }

        static string SubsystemToString(int subsystem)
        {
            switch (subsystem)
            {
                case 2:
                    return "WINDOWS_GUI";
                case 3:
                    return "WINDOWS_CUI";
                default:
                    throw new NotImplementedException();
            }
        }

        void WriteCustomAttributes(LineWriter lw, int level, IEnumerable<CustomAttributeData> cas)
        {
            if (diffMode)
            {
                cas = cas.OrderBy(ca => ca.Constructor.DeclaringType.FullName);
            }
            foreach (var ca in cas)
            {
                lw.GoToColumn(level);
                WriteCustomAttribute(lw, ca);
            }
        }

        void WriteCustomAttribute(LineWriter lw, CustomAttributeData ca)
        {
            lw.Write(".custom ");
            WriteCustomAttributeImpl(lw, ca, false, lw.Column);
        }

        void WriteCustomAttributeImpl(LineWriter lw, CustomAttributeData ca, bool comment, int level0)
        {
            lw.Write("instance ");
            WriteSignatureType(lw, ca.Constructor.__ReturnParameter.ParameterType);
            WriteCustomModifiers(lw, ca.Constructor.__ReturnParameter.__GetCustomModifiers());
            lw.Write(" ");
            WriteTypeDefOrRef(lw, ca.Constructor.DeclaringType);
            lw.Write("::.ctor(");
            int level = lw.Column;
            bool first = true;
            foreach (var parameter in ca.Constructor.GetParameters())
            {
                if (!first)
                {
                    lw.WriteLine(",");
                    if (comment)
                    {
                        lw.Write("  //");
                    }
                    lw.GoToColumn(level);
                }
                first = false;
                WriteSignatureType(lw, parameter.ParameterType);
                WriteCustomModifiers(lw, parameter.__GetCustomModifiers());
            }
            byte[] blob = ca.__GetBlob();
            if (blob.Length == 0)
            {
                lw.WriteLine(")");
            }
            else
            {
                var wrap = lw.Column >= 80;
                StringBuilder sb;
                if ((flags & Flags.Caverbal) != 0 && DecodeCABlob(sb = new StringBuilder(), ca.Constructor, blob, wrap ? (level0 + 4) * (comment ? -1 : 1) : lw.Column + 5))
                {
                    lw.Write(")");
                    if (wrap)
                    {
                        lw.WriteLine();
                        if (comment)
                        {
                            lw.Write("  //");
                        }
                        lw.GoToColumn(level0);
                    }
                    lw.Write(" = {{{0}", sb);
                    lw.WriteLine("}");
                }
                else
                {
                    lw.Write(") = ( ");
                    WriteBytes(lw, blob, false);
                    lw.WriteLine();
                }
            }
        }

        void WriteModuleOrAssemblyRef(LineWriter lw, Module mod)
        {
            if (mod.Assembly != assembly)
            {
                lw.Write("[{0}]", QuoteIdentifier(FindReferencedAssembly(mod.Assembly)));
            }
            else if (mod != this.module)
            {
                lw.Write("[.module {0}]", QuoteIdentifier(mod.Name));
            }
        }

        void WriteSignatureType(LineWriter lw, Type type)
        {
            WriteSignatureType(lw, type, TypeLocation.General);
        }

        enum TypeLocation
        {
            General,
            MemberRef,
            MemberRefNoWrap,
            DeclaringType,
            MethodGenericParameter,
            Local,
            Parameter,
            GenericMethodImpl,
        }

        void WriteSignatureType(LineWriter lw, Type type, TypeLocation loc)
        {
            WriteSignatureType(lw, type, loc, false, false);
        }

        void WriteSignatureType(LineWriter lw, Type type, TypeLocation loc, bool skipGenArgs, bool skipClass)
        {
            if (type.__IsVector)
            {
                WriteSignatureType(lw, type.GetElementType(), loc);
                WriteCustomModifiers(lw, type.__GetCustomModifiers());
                lw.Write("[]");
            }
            else if (type.IsArray)
            {
                WriteSignatureType(lw, type.GetElementType(), loc);
                WriteCustomModifiers(lw, type.__GetCustomModifiers());
                lw.Write("[");
                string sep = "";
                int[] lower = type.__GetArrayLowerBounds();
                foreach (var lb in lower)
                {
                    lw.Write(sep);
                    sep = ",";
                    lw.Write("{0}...", lb);
                }
                for (int i = lower.Length + 1, rank = type.GetArrayRank(); i < rank; i++)
                {
                    lw.Write(",");
                }
                lw.Write("]");
            }
            else if (type.IsByRef)
            {
                WriteSignatureType(lw, type.GetElementType(), loc);
                WriteCustomModifiers(lw, type.__GetCustomModifiers());
                lw.Write("&");
            }
            else if (type.IsPointer)
            {
                WriteSignatureType(lw, type.GetElementType(), loc);
                WriteCustomModifiers(lw, type.__GetCustomModifiers());
                lw.Write("*");
            }
            else if (type.__IsFunctionPointer)
            {
                WriteStandAloneMethodSig(lw, type.__MethodSignature, true, loc == TypeLocation.Local || loc == TypeLocation.Parameter || loc == TypeLocation.MemberRef);
            }
            else if (!type.__IsMissing && type.IsGenericType && !type.IsGenericTypeDefinition)
            {
                WriteSignatureType(lw, type.GetGenericTypeDefinition(), loc, true, false);
                lw.Write("<");
                string sep = "";
                Type[] args = type.GetGenericArguments();
                CustomModifiers[] mods = type.__GetGenericArgumentsCustomModifiers();
                for (int i = 0; i < args.Length; i++)
                {
                    lw.Write(sep);
                    WriteSignatureType(lw, args[i], loc);
                    WriteCustomModifiers(lw, mods[i]);
                    sep = ",";
                }
                lw.Write(">");
            }
            else if (type.IsGenericParameter)
            {
                if (type.DeclaringMethod != null)
                {
                    lw.Write("!!{0}",
                        loc == TypeLocation.MemberRef || loc == TypeLocation.MemberRefNoWrap || loc == TypeLocation.DeclaringType || loc == TypeLocation.MethodGenericParameter || type.Name == null
                        ? (object)type.GenericParameterPosition
                        : QuoteIdentifier(type.Name));
                }
                else
                {
                    lw.Write("!{0}",
                        loc == TypeLocation.MemberRef || loc == TypeLocation.MemberRefNoWrap || loc == TypeLocation.GenericMethodImpl || type.Name == null
                        ? (object)type.GenericParameterPosition
                        : QuoteIdentifier(type.Name));
                }
            }
            else if (type == typeofSystemBoolean)
            {
                lw.Write("bool");
            }
            else if (type == typeofSystemSByte)
            {
                lw.Write("int8");
            }
            else if (type == typeofSystemByte)
            {
                lw.Write("uint8");
            }
            else if (type == typeofSystemChar)
            {
                lw.Write("char");
            }
            else if (type == typeofSystemInt16)
            {
                lw.Write("int16");
            }
            else if (type == typeofSystemUInt16)
            {
                lw.Write("uint16");
            }
            else if (type == typeofSystemInt32)
            {
                lw.Write("int32");
            }
            else if (type == typeofSystemUInt32)
            {
                lw.Write("uint32");
            }
            else if (type == typeofSystemInt64)
            {
                lw.Write("int64");
            }
            else if (type == typeofSystemUInt64)
            {
                lw.Write("uint64");
            }
            else if (type == typeofSystemSingle)
            {
                lw.Write("float32");
            }
            else if (type == typeofSystemDouble)
            {
                lw.Write("float64");
            }
            else if (type == typeofSystemString)
            {
                lw.Write("string");
            }
            else if (type == typeofSystemObject)
            {
                lw.Write("object");
            }
            else if (type == typeofSystemVoid)
            {
                lw.Write("void");
            }
            else if (type == typeofSystemIntPtr)
            {
                lw.Write("native int");
            }
            else if (type == typeofSystemUIntPtr)
            {
                lw.Write("native uint");
            }
            else if (type == typeofSystemTypedReference)
            {
                lw.Write("typedref");
            }
            else
            {
                if (!type.__IsMissing && !skipClass)
                {
                    lw.Write(type.IsValueType ? "valuetype " : "class ");
                }
                WriteModuleOrAssemblyRef(lw, type.Module);
                WriteTypeName(lw, type);
                if (!skipGenArgs && !type.__IsMissing && type.IsGenericTypeDefinition)
                {
                    lw.Write("<");
                    string sep = "";
                    Type[] args = type.GetGenericArguments();
                    CustomModifiers[] mods = type.__GetGenericArgumentsCustomModifiers();
                    for (int i = 0; i < args.Length; i++)
                    {
                        lw.Write(sep);
                        WriteSignatureType(lw, args[i], loc);
                        WriteCustomModifiers(lw, mods[i]);
                        sep = ",";
                    }
                    lw.Write(">");
                }
            }
        }

        void WriteStandAloneMethodSig(LineWriter lw, __StandAloneMethodSig sig, bool type, bool wrap)
        {
            int level = lw.Column;
            if (type)
            {
                lw.Write("method ");
            }
            if (sig.IsUnmanaged)
            {
                lw.Write("unmanaged ");
                switch (sig.UnmanagedCallingConvention)
                {
                    case System.Runtime.InteropServices.CallingConvention.Cdecl:
                        lw.Write("cdecl ");
                        break;
                    case System.Runtime.InteropServices.CallingConvention.StdCall:
                        lw.Write("stdcall ");
                        break;
                    case System.Runtime.InteropServices.CallingConvention.ThisCall:
                        lw.Write("thiscall ");
                        break;
                }
            }
            else
            {
                WriteCallingConvention(lw, sig.CallingConvention);
            }
            WriteSignatureType(lw, sig.ReturnType);
            WriteCustomModifiers(lw, sig.GetReturnTypeCustomModifiers());
            lw.Write(type ? " *(" : "(");
            Type[] parameters = sig.ParameterTypes;
            for (int i = 0; i < parameters.Length; i++)
            {
                if (i != 0)
                {
                    if (wrap)
                    {
                        lw.WriteLine(",");
                        lw.GoToColumn(level);
                    }
                    else
                    {
                        lw.Write(",");
                    }
                }
                WriteSignatureType(lw, parameters[i]);
                WriteCustomModifiers(lw, sig.GetParameterCustomModifiers(i));
            }
            lw.Write(")");
        }

        private void WriteCallingConvention(LineWriter lw, CallingConventions callingConvention)
        {
            if ((callingConvention & CallingConventions.HasThis) != 0)
            {
                lw.Write("instance ");
            }
            if ((callingConvention & CallingConventions.VarArgs) != 0)
            {
                lw.Write("vararg ");
            }
        }

        void WriteTypeName(LineWriter lw, Type type)
        {
            if (type.IsNested)
            {
                WriteTypeName(lw, type.DeclaringType);
                lw.Write("/");
            }
            WriteTypeNameNoOuter(lw, type);
        }

        void WriteTypeNameNoOuter(LineWriter lw, Type type)
        {
            if (type.__Namespace != null)
            {
                lw.Write("{0}.", QuoteIdentifier(type.__Namespace));
            }
            lw.Write("{0}", QuoteIdentifier(type.__Name));
        }

        void WriteTypeDefOrRef(LineWriter lw, Type type)
        {
             WriteSignatureType(lw, type, TypeLocation.General, true, true);
        }

        static void WriteBytes(LineWriter lw, byte[] buf, bool data)
        {
            bool hasText = false;
            int column = lw.Column;
            for (int i = 0; i < buf.Length; i++)
            {
                if (i != 0)
                {
                    if (i % 16 == 0)
                    {
                        if (hasText)
                        {
                            hasText = false;
                            lw.Write(data ? "  // " : "   // ");
                            for (int j = i - 16; j < i; j++)
                            {
                                lw.Write("{0}", IsText(buf[j]) ? (char)buf[j] : '.');
                            }
                        }
                        else if (!data)
                        {
                            lw.Write(" ");
                        }
                        lw.WriteLine();
                        lw.GoToColumn(column);
                    }
                    else
                    {
                        lw.Write(" ");
                    }
                }
                lw.Write("{0:X2}", buf[i]);
                hasText |= IsText(buf[i]);
            }
            if (!data)
            {
                lw.Write(" ");
            }
            lw.Write(") ");
            if (hasText)
            {
                lw.GoToColumn(column + 16 * 3 + (data ? 1 : 2));
                lw.Write("// ");
                for (int j = (buf.Length + 15 & ~15) - 16; j < buf.Length; j++)
                {
                    lw.Write("{0}", IsText(buf[j]) ? (char)buf[j] : '.');
                }
            }
        }

        static bool IsText(byte b)
        {
            return b >= 32 && b < 127;
        }
    }
}
