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
using IKVM.Reflection.Reader;
using Type = IKVM.Reflection.Type;

namespace Ildasm
{
    partial class Disassembler
    {
        bool DecodeDeclSecurity(StringBuilder sb, IList<CustomAttributeData> list, int level)
        {
            try
            {
                sb.Append("           = {");
                bool first = true;
                foreach (var sec in list)
                {
                    if (!first)
                    {
                        sb.Append(',');
                        sb.AppendLine();
                        sb.Append(' ', level + 14);
                    }
                    first = false;
                    string typeName = sec.Constructor.DeclaringType.AssemblyQualifiedName;
                    if (typeName.EndsWith(", mscorlib", StringComparison.Ordinal))
                    {
                        typeName = typeName.Substring(0, typeName.Length - 10);
                    }
                    AppendTypeName(sb, sec.Constructor.DeclaringType, typeName, compat != CompatLevel.None);
                    sb.Append(" = {");
                    byte[] blob = sec.__GetBlob();
                    // LAMESPEC the count of named arguments is a compressed integer (instead of UInt16 as NumNamed in custom attributes)
                    var br = new ByteReader(blob, 0, blob.Length);
                    int count = br.ReadCompressedInt();
                    ReadNamedArguments(sb, br, count, 0, compat != CompatLevel.None && count > 1);
                    sb.Append('}');
                }
                sb.Append('}');
                return true;
            }
            catch (IKVM.Reflection.BadImageFormatException)
            {
                return false;
            }
        }

        void AppendTypeName(StringBuilder sb, Type type)
        {
            if (type.IsNested)
            {
                AppendTypeName(sb, type.DeclaringType);
                sb.Append('/');
            }
            AppendTypeNameNoOuter(sb, type);
        }

        void AppendTypeNameNoOuter(StringBuilder sb, Type type)
        {
            if (type.__Namespace != null)
            {
                sb.Append(QuoteIdentifier(type.__Namespace));
                sb.Append('.');
            }
            sb.Append(QuoteIdentifier(type.__Name));
        }
        
        void AppendTypeName(StringBuilder sb, Type type, string typeName, bool noself = false, bool securityCompatHack = false)
        {
            if (type.Assembly == assembly && !type.__IsMissing && !noself && (!type.IsGenericType || type.IsGenericTypeDefinition) && !type.HasElementType)
            {
                AppendTypeName(sb, type);
            }
            else if (typerefs.Contains(type))
            {
                sb.Append('[').Append(QuoteIdentifier(FindReferencedAssembly(type.Assembly))).Append(']');
                AppendTypeName(sb, type);
            }
            else
            {
                if (securityCompatHack)
                {
                    throw new IKVM.Reflection.BadImageFormatException();
                }
                sb.Append("class ").Append(QuoteIdentifier(typeName, true));
            }
        }

        bool DecodeCABlob(StringBuilder sb, ConstructorInfo constructor, byte[] blob, int level)
        {
            try
            {
                // CustomAttribute
                var br = new ByteReader(blob, 2, blob.Length - 4);
                ReadConstructorArguments(sb, br, constructor, level);
                br = new ByteReader(blob, blob.Length - (br.Length + 2), br.Length + 2);
                int named = br.ReadUInt16();
                if (constructor.GetParameters().Length != 0 && named != 0)
                {
                    AppendNewLine(sb, level);
                }
                ReadNamedArguments(sb, br, named, level, false);
                return true;
            }
            catch (IKVM.Reflection.BadImageFormatException) { }
            catch (ArgumentOutOfRangeException) { }
            return false;
        }

        void AppendNewLine(StringBuilder sb, int level)
        {
            sb.AppendLine();
            if (level < 0)
            {
                sb.Append("  //");
                sb.Append(' ', -level - 4);
            }
            else
            {
                sb.Append(' ', level);
            }
        }

        void ReadConstructorArguments(StringBuilder sb, ByteReader br, ConstructorInfo constructor, int level)
        {
            bool first = true;
            foreach (var parameter in constructor.GetParameters())
            {
                if (!first)
                {
                    AppendNewLine(sb, level);
                }
                first = false;
                ReadFixedArg(sb, br, parameter.ParameterType);
            }
        }

        void ReadNamedArguments(StringBuilder sb, ByteReader br, int named, int level, bool securityCompatHack)
        {
            for (int i = 0; i < named; i++)
            {
                if (i != 0)
                {
                    AppendNewLine(sb, level);
                }
                byte fieldOrProperty = br.ReadByte();
                switch (fieldOrProperty)
                {
                    case 0x53:
                        sb.Append("field ");
                        break;
                    case 0x54:
                        sb.Append("property ");
                        break;
                    default:
                        throw new IKVM.Reflection.BadImageFormatException();
                }
                string typeName;
                Type fieldOrPropertyType = ReadFieldOrPropType(sb, br, out typeName);
                AppendCATypeName(sb, fieldOrPropertyType, typeName, securityCompatHack);
                sb.Append(' ').Append(QuoteIdentifier(br.ReadString(), true)).Append(" = ");
                ReadFixedArg(sb, br, fieldOrPropertyType);
            }
        }

        void ReadFixedArg(StringBuilder sb, ByteReader br, Type type, bool arrayElement = false)
        {
            if (type.IsArray)
            {
                int length = br.ReadInt32();
                if (length == -1 && compat == CompatLevel.None)
                {
                    sb.Append("nullref");
                }
                else if (length == 0 && compat != CompatLevel.None)
                {
                    throw new IKVM.Reflection.BadImageFormatException();
                }
                else
                {
                    Type elementType = type.GetElementType();
                    AppendCATypeName(sb, elementType, null);
                    sb.AppendFormat("[{0}](", length);
                    for (int i = 0; i < length; i++)
                    {
                        if (i != 0)
                        {
                            sb.Append(' ');
                        }
                        if (elementType == typeofSystemObject)
                        {
                            string typeName;
                            ReadFixedArg(sb, br, ReadFieldOrPropType(sb, br, out typeName), false);
                        }
                        else
                        {
                            ReadFixedArg(sb, br, elementType, true);
                        }
                    }
                    sb.Append(')');
                }
            }
            else if (type.FullName == "System.Type" && type.Assembly.GetName().Name == "mscorlib")
            {
                if (!arrayElement)
                {
                    AppendCATypeName(sb, type, null);
                    sb.Append('(');
                }
                string typeName;
                var type1 = ReadType(br, out typeName);
                if (type1 == null)
                {
                    if (typeName == null)
                    {
                        sb.Append("nullref");
                    }
                    else
                    {
                        sb.Append("class ").Append(QuoteIdentifier(typeName, true));
                    }
                }
                else
                {
                    AppendTypeName(sb, type1, typeName, compat != CompatLevel.None && IsNestedTypeWithNamespace(type1));
                }
                if (!arrayElement)
                {
                    sb.Append(')');
                }
            }
            else if (type.Assembly == mscorlib)
            {
                if (!arrayElement)
                {
                    AppendCATypeName(sb, type, null);
                    sb.Append('(');
                }
                if (type == typeofSystemBoolean)
                {
                    sb.Append(br.ReadByte() == 0 ? "false" : "true");
                }
                else if (type == typeofSystemByte)
                {
                    sb.Append(br.ReadByte());
                }
                else if (type == typeofSystemSByte)
                {
                    sb.Append(br.ReadSByte());
                }
                else if (type == typeofSystemChar)
                {
                    sb.AppendFormat("0x{0:X4}", (int)br.ReadChar());
                }
                else if (type == typeofSystemInt16)
                {
                    sb.Append(br.ReadInt16());
                }
                else if (type == typeofSystemUInt16)
                {
                    sb.Append(br.ReadUInt16());
                }
                else if (type == typeofSystemInt32)
                {
                    sb.Append(br.ReadInt32());
                }
                else if (type == typeofSystemUInt32)
                {
                    sb.Append(br.ReadInt32());
                }
                else if (type == typeofSystemInt64)
                {
                    sb.Append(br.ReadInt64());
                }
                else if (type == typeofSystemUInt64)
                {
                    sb.Append(br.ReadInt64());
                }
                else if (type == typeofSystemSingle)
                {
                    sb.Append(ToString(br.ReadSingle(), true));
                }
                else if (type == typeofSystemDouble)
                {
                    sb.Append(ToString(br.ReadDouble(), true));
                }
                else if (type == typeofSystemString)
                {
                    var str = br.ReadString();
                    if (str == null)
                    {
                        sb.Append("nullref");
                    }
                    else
                    {
                        if (compat != CompatLevel.None)
                        {
                            int pos = str.IndexOf((char)0);
                            if (pos != -1)
                            {
                                str = str.Substring(0, pos);
                            }
                        }
                        sb.Append(QuoteIdentifier(str, true));
                    }
                }
                else if (type == typeofSystemObject)
                {
                    string typeName;
                    ReadFixedArg(sb, br, ReadFieldOrPropType(sb, br, out typeName));
                }
                else
                {
                    throw new NotImplementedException(type.FullName);
                }
                if (!arrayElement)
                {
                    sb.Append(')');
                }
            }
            else if (type.__IsMissing || (compat != CompatLevel.None && typerefs.Contains(type)))
            {
                // ildasm actually tries to load the assembly, but we can't do that, so we cheat by having
                // a list of 'known' enum types
                if (type.Assembly.GetName().Name == "mscorlib")
                {
                    switch (type.FullName)
                    {
                        case "System.AttributeTargets":
                        case "System.Runtime.ConstrainedExecution.Consistency":
                        case "System.Runtime.ConstrainedExecution.Cer":
                        case "System.Security.Permissions.SecurityAction":
                        case "System.Security.Permissions.SecurityPermissionFlag":
                        case "System.Runtime.Versioning.ResourceScope":
                        case "System.Runtime.InteropServices.CallingConvention":
                        case "System.Runtime.InteropServices.CharSet":
                            ReadFixedArg(sb, br, typeofSystemInt32);
                            return;
                        case "System.Security.SecurityRuleSet":
                            if (compat != CompatLevel.V20)
                            {
                                ReadFixedArg(sb, br, typeofSystemByte);
                                return;
                            }
                            break;
                        case "System.Diagnostics.Tracing.EventLevel":
                        case "System.Diagnostics.Tracing.EventTask":
                        case "System.Diagnostics.Tracing.EventOpcode":
                            if (compat != CompatLevel.V20 && compat != CompatLevel.V40)
                            {
                                ReadFixedArg(sb, br, typeofSystemInt32);
                                return;
                            }
                            break;
                        case "System.Type":
                            sb.Append("type(");
                            string typeName;
                            AppendTypeName(sb, ReadType(br, out typeName), typeName);
                            sb.Append(")");
                            return;
                    }
                }
                switch (br.Length)
                {
                    case 1:
                        if (compat != CompatLevel.None)
                        {
                            // ildasm uses bool (???) as the underlying type in this case
                            sb.AppendFormat("bool({0})", br.ReadByte() == 0 ? "false" : "true");
                        }
                        else
                        {
                            // just guess that the enum has int8 as the underlying type
                            sb.AppendFormat("int8({0})", br.ReadSByte());
                        }
                        break;
                    case 2:
                        // just guess that the enum has int16 as the underlying type
                        sb.AppendFormat("int16({0})", br.ReadInt16());
                        break;
                    case 4:
                        // just guess that the enum has int32 as the underlying type
                        sb.AppendFormat("int32({0})", br.ReadInt32());
                        break;
                    case 8:
                        // just guess that the enum has int64 as the underlying type
                        sb.AppendFormat("int64({0})", br.ReadInt64());
                        break;
                    default:
                        throw new IKVM.Reflection.BadImageFormatException();
                }
            }
            else if (type.IsEnum)
            {
                ReadFixedArg(sb, br, type.GetEnumUnderlyingType(), arrayElement);
            }
            else
            {
                throw new NotImplementedException(type.FullName);
            }
        }

        static bool IsNestedTypeWithNamespace(Type type)
        {
            if (!type.IsNested)
            {
                return false;
            }
            if (type.IsConstructedGenericType)
            {
                type = type.GetGenericTypeDefinition();
            }
            return type.__Namespace != null;
        }

        void AppendCATypeName(StringBuilder sb, Type type, string typeName, bool securityCompatHack = false)
        {
            if (type.IsArray)
            {
                AppendCATypeName(sb, type.GetElementType(), null);
                sb.Append("[]");
            }
            else if (type == typeofSystemBoolean)
            {
                sb.Append("bool");
            }
            else if (type == typeofSystemSByte)
            {
                sb.Append("int8");
            }
            else if (type == typeofSystemByte)
            {
                sb.Append("uint8");
            }
            else if (type == typeofSystemChar)
            {
                sb.Append("char");
            }
            else if (type == typeofSystemInt16)
            {
                sb.Append("int16");
            }
            else if (type == typeofSystemUInt16)
            {
                sb.Append("uint16");
            }
            else if (type == typeofSystemInt32)
            {
                sb.Append("int32");
            }
            else if (type == typeofSystemUInt32)
            {
                sb.Append("uint32");
            }
            else if (type == typeofSystemInt64)
            {
                sb.Append("int64");
            }
            else if (type == typeofSystemUInt64)
            {
                sb.Append("uint64");
            }
            else if (type == typeofSystemSingle)
            {
                sb.Append("float32");
            }
            else if (type == typeofSystemDouble)
            {
                sb.Append("float64");
            }
            else if (type == typeofSystemString)
            {
                sb.Append("string");
            }
            else if (type == typeofSystemObject)
            {
                sb.Append("object");
            }
            else if (type.FullName == "System.Type" && type.Assembly.GetName().Name == "mscorlib")
            {
                sb.Append("type");
            }
            else
            {
                sb.Append("enum ");
                AppendTypeName(sb, type, typeName, false, securityCompatHack);
            }
        }

        Type ReadFieldOrPropType(StringBuilder sb, ByteReader br, out string typeName)
        {
		    const byte ELEMENT_TYPE_BOOLEAN = 0x02;
		    const byte ELEMENT_TYPE_CHAR = 0x03;
		    const byte ELEMENT_TYPE_I1 = 0x04;
		    const byte ELEMENT_TYPE_U1 = 0x05;
		    const byte ELEMENT_TYPE_I2 = 0x06;
		    const byte ELEMENT_TYPE_U2 = 0x07;
		    const byte ELEMENT_TYPE_I4 = 0x08;
		    const byte ELEMENT_TYPE_U4 = 0x09;
		    const byte ELEMENT_TYPE_I8 = 0x0a;
		    const byte ELEMENT_TYPE_U8 = 0x0b;
		    const byte ELEMENT_TYPE_R4 = 0x0c;
		    const byte ELEMENT_TYPE_R8 = 0x0d;
		    const byte ELEMENT_TYPE_STRING = 0x0e;
            const byte ELEMENT_TYPE_SZARRAY = 0x1d;

            typeName = null;

            switch (br.ReadByte())
            {
                case ELEMENT_TYPE_BOOLEAN:
                    return typeofSystemBoolean;
                case ELEMENT_TYPE_CHAR:
                    return typeofSystemChar;
                case ELEMENT_TYPE_I1:
                    return typeofSystemSByte;
                case ELEMENT_TYPE_U1:
                    return typeofSystemByte;
                case ELEMENT_TYPE_I2:
                    return typeofSystemInt16;
                case ELEMENT_TYPE_U2:
                    return typeofSystemUInt16;
                case ELEMENT_TYPE_I4:
                    return typeofSystemInt32;
                case ELEMENT_TYPE_U4:
                    return typeofSystemUInt32;
                case ELEMENT_TYPE_I8:
                    return typeofSystemInt64;
                case ELEMENT_TYPE_U8:
                    return typeofSystemUInt64;
                case ELEMENT_TYPE_R4:
                    return typeofSystemSingle;
                case ELEMENT_TYPE_R8:
                    return typeofSystemDouble;
                case ELEMENT_TYPE_STRING:
                    return typeofSystemString;
                case ELEMENT_TYPE_SZARRAY:
                    return ReadFieldOrPropType(sb, br, out typeName).MakeArrayType();
                case 0x55:
                    return ReadType(br, out typeName);
                case 0x50:
                    return typeofSystemType;
                case 0x51:
                    return typeofSystemObject;
                default:
                    throw new IKVM.Reflection.BadImageFormatException();
            }
        }

        Type ReadType(ByteReader br, out string typeName)
        {
            typeName = br.ReadString();
            if (typeName == null)
            {
                return null;
            }
            if (typeName.Length > 0 && typeName[typeName.Length - 1] == 0)
            {
                // there are broken compilers that emit an extra NUL character after the type name
                typeName = typeName.Substring(0, typeName.Length - 1);
            }
            var type = universe.ResolveType(assembly, typeName);
            if (type != null && type.Assembly == mscorlib)
            {
                // we don't want that!
                type = universe.ResolveType(assembly, type.FullName + ", mscorlib, Version=0.0.0.0");
            }
            return type;
        }
    }
}
