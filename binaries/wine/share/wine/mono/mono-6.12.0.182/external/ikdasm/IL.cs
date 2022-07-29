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
using IKVM.Reflection.Emit;
using Type = IKVM.Reflection.Type;
using System.Diagnostics;

namespace Ildasm
{
    sealed partial class Disassembler : IComparer<ExceptionHandlingClause>
    {
        static readonly OpCode[] opcodes = GetOpCodes();

        static OpCode[] GetOpCodes()
        {
            OpCode[] opcodes = new OpCode[768];
            foreach (System.Reflection.FieldInfo field in typeof(OpCodes).GetFields())
            {
                OpCode opc = (OpCode)field.GetValue(null);
                opcodes[opc.Value + 512] = opc;
            }
            return opcodes;
        }

        void WriteIL(LineWriter lw, MethodBase mb, MethodBody body, Type[] genericTypeArguments, Type[] genericMethodArguments)
        {
            ParameterInfo[] parameters = mb.GetParameters();
            int level = lw.Column;
            byte[] code = body.GetILAsByteArray();
            lw.GoToColumn(level);
            lw.WriteLine("// Code size       {0} (0x{0:x})", code.Length);
            lw.GoToColumn(level);
            lw.WriteLine(".maxstack  {0}", body.MaxStackSize);

            IList<LocalVariableInfo> locals = body.LocalVariables;
            if (locals.Count != 0)
            {
                lw.GoToColumn(level);
                lw.Write(".locals ");
                if (body.InitLocals)
                {
                    lw.Write("init ");
                }
                lw.Write("(");
                bool first = true;
                foreach (var local in locals)
                {
                    if (!first)
                    {
                        lw.WriteLine(",");
                        lw.GoToColumn(level + 9);
                    }
                    first = false;
                    WriteSignatureType(lw, local.LocalType, TypeLocation.Local);
                    if (local.IsPinned)
                    {
                        lw.Write(" pinned");
                    }
                    WriteCustomModifiers(lw, local.__GetCustomModifiers());
                    lw.Write(" V_{0}", local.LocalIndex);
                }
                lw.WriteLine(")");
            }

            var exceptions = new List<ExceptionHandlingClause>();
            var exceptions2 = new List<ExceptionHandlingClause>();
            SortExceptions(body.ExceptionHandlingClauses, exceptions, exceptions2);

            Stack<ExceptionHandlingClause> activeExceptions = new Stack<ExceptionHandlingClause>();
            ExceptionHandlingClause currentException = null;
            bool extraNewLine = false;
            int nextFlatException = 0;
            int nextException = 0;
            bool handler = false;
            int pos = 0;
            while (pos < code.Length)
            {
                if (extraNewLine)
                {
                    lw.WriteLine();
                    extraNewLine = false;
                }
                if (currentException != null)
                {
                    if (currentException.HandlerOffset == pos)
                    {
                        switch (currentException.Flags)
                        {
                            case ExceptionHandlingClauseOptions.Clause:
                                lw.GoToColumn(level - 2);
                                if (currentException.TryOffset + currentException.TryLength == pos)
                                {
                                    lw.WriteLine("}  // end .try");
                                }
                                else
                                {
                                    lw.WriteLine("}  // end handler");
                                }
                                lw.GoToColumn(level - 2);
                                lw.Write("catch ");
                                if (currentException.CatchType.__IsMissing || !currentException.CatchType.IsGenericType)
                                {
                                    WriteTypeDefOrRef(lw, currentException.CatchType);
                                }
                                else
                                {
                                    WriteSignatureType(lw, currentException.CatchType);
                                }
                                lw.WriteLine(" ");
                                lw.GoToColumn(level - 2);
                                lw.WriteLine("{");
                                handler = true;
                                break;
                            case ExceptionHandlingClauseOptions.Finally:
                                lw.GoToColumn(level - 2);
                                lw.WriteLine("}  // end .try");
                                lw.GoToColumn(level - 2);
                                lw.WriteLine("finally");
                                lw.GoToColumn(level - 2);
                                lw.WriteLine("{");
                                break;
                            case ExceptionHandlingClauseOptions.Fault:
                                lw.GoToColumn(level - 2);
                                lw.WriteLine("}  // end .try");
                                lw.GoToColumn(level - 2);
                                lw.WriteLine("fault");
                                lw.GoToColumn(level - 2);
                                lw.WriteLine("{");
                                break;
                            case ExceptionHandlingClauseOptions.Filter:
                                lw.GoToColumn(level - 2);
                                lw.WriteLine("}  // end filter");
                                lw.GoToColumn(level - 2);
                                lw.WriteLine("{  // handler");
                                handler = true;
                                break;
                            default:
                                throw new IKVM.Reflection.BadImageFormatException();
                        }
                    }
                    else if (currentException.FilterOffset == pos && pos != 0)
                    {
                        lw.GoToColumn(level - 2);
                        if (handler)
                        {
                            lw.WriteLine("}  // end handler");
                        }
                        else
                        {
                            lw.WriteLine("}  // end .try");
                        }
                        lw.GoToColumn(level - 2);
                        lw.WriteLine("filter");
                        lw.GoToColumn(level - 2);
                        lw.WriteLine("{");
                    }
                }
                while (nextException < exceptions.Count
                    && exceptions[nextException].TryOffset == pos)
                {
                    activeExceptions.Push(currentException);
                    ExceptionHandlingClause prevException = currentException;
                    currentException = exceptions[nextException++];
                    if (prevException != null && currentException.TryOffset == prevException.TryOffset && currentException.TryLength == prevException.TryLength)
                    {
                        // another handler for the same block
                        continue;
                    }
                    handler = false;
                    lw.GoToColumn(level);
                    lw.WriteLine(".try");
                    lw.GoToColumn(level);
                    lw.WriteLine("{");
                    level += 2;
                }
                lw.GoToColumn(level);
                int currPos = pos;
                lw.Write("IL_{0:x4}:  ", pos);
                int level1 = lw.Column;
                short opcodeValue = code[pos++];
                if (opcodeValue == 0xFE)
                {
                    opcodeValue = (short)(0xFE00 + code[pos++]);
                }
                OpCode opcode = opcodes[opcodeValue + 512];
                lw.Write("{0}", opcode.Name);
                switch (opcode.OperandType)
                {
                    case OperandType.InlineNone:
                        break;
                    case OperandType.InlineBrTarget:
                        lw.GoToColumn(level1 + 11);
                        lw.Write("IL_{0:x4}", ReadInt32(code, ref pos) + pos);
                        break;
                    case OperandType.ShortInlineBrTarget:
                        lw.GoToColumn(level1 + 11);
                        lw.Write("IL_{0:x4}", (sbyte)code[pos++] + pos);
                        break;
                    case OperandType.InlineMethod:
                        {
                            lw.GoToColumn(level1 + 11);
                            int token = ReadInt32(code, ref pos);
                            MethodBase methodOrConstructor = ResolveMethod(token, genericTypeArguments, genericMethodArguments);
                            if ((methodOrConstructor.CallingConvention & CallingConventions.Any) == CallingConventions.VarArgs)
                            {
                                CustomModifiers[] customModifiers;
                                Type[] optionalParameterTypes = ResolveOptionalParameterTypes(token, genericTypeArguments, genericMethodArguments, out customModifiers);
                                WriteInlineMethod(lw, methodOrConstructor, optionalParameterTypes, customModifiers);
                            }
                            else
                            {
                                WriteInlineMethod(lw, methodOrConstructor, Type.EmptyTypes, null);
                            }
                        }
                        break;
                    case OperandType.InlineField:
                        lw.GoToColumn(level1 + 11);
                        WriteInlineField(lw, ResolveField(ReadInt32(code, ref pos), genericTypeArguments, genericMethodArguments));
                        break;
                    case OperandType.InlineI:
                        lw.GoToColumn(level1 + 11);
                        WriteInlineI(lw, ReadInt32(code, ref pos)); 
                        break;
                    case OperandType.InlineI8:
                        lw.GoToColumn(level1 + 11);
                        WriteInlineI8(lw, ReadInt64(code, ref pos));
                        break;
                    case OperandType.ShortInlineI:
                        lw.GoToColumn(level1 + 11);
                        lw.Write("{0}", (sbyte)code[pos++]);
                        break;
                    case OperandType.InlineR:
                        lw.GoToColumn(level1 + 11);
                        WriteInlineR(lw, ReadDouble(code, ref pos), false);
                        break;
                    case OperandType.ShortInlineR:
                        lw.GoToColumn(level1 + 11);
                        WriteShortInlineR(lw, ReadSingle(code, ref pos), false);
                        break;
                    case OperandType.InlineType:
                        if (opcode == OpCodes.Constrained)
                        {
                            // "constrained." is too long to fit in the opcode column
                            lw.Write(" ");
                        }
                        else
                        {
                            lw.GoToColumn(level1 + 11);
                        }
                        WriteInlineType(lw, ReadInt32(code, ref pos), genericTypeArguments, genericMethodArguments);
                        break;
                    case OperandType.InlineTok:
                        {
                            int token = ReadInt32(code, ref pos);
                            switch (token >> 24)
                            {
                                case 0x01:
                                case 0x02:
                                    lw.GoToColumn(level1 + 11);
                                    WriteTypeDefOrRef(lw, ResolveType(token, genericTypeArguments, genericMethodArguments));
                                    break;
                                case 0x1B:
                                    {
                                        Type type = ResolveType(token, genericTypeArguments, genericMethodArguments);
                                        if (type.IsGenericTypeDefinition)
                                        {
                                            // HACK because typeof(Foo<>).MakeGenericType(typeof(Foo<>).GetGenericArguments()) == typeof(Foo<>)
                                            // we need to inflate the builder here
                                            type = type.MakeGenericType(type.GetGenericArguments());
                                        }
                                        lw.GoToColumn(level1 + 11);
                                        WriteSignatureType(lw, type);
                                        break;
                                    }
                                case 0x04:
                                case 0x06:
                                case 0x0A:
                                case 0x2B:
                                    {
                                        MemberInfo member = ResolveMember(token, genericTypeArguments, genericMethodArguments);
                                        if (member is FieldInfo)
                                        {
                                            lw.GoToColumn(level1 + 11);
                                            lw.Write("field ");
                                            WriteInlineField(lw, (FieldInfo)member);
                                        }
                                        else
                                        {
                                            var mb1 = (MethodBase)member;
                                            lw.GoToColumn(level1 + 11);
                                            if (mb1.__IsMissing || !mb1.IsGenericMethod || compat != CompatLevel.V20)
                                            {
                                                lw.Write("method ");
                                            }
                                            WriteInlineMethod(lw, mb1, Type.EmptyTypes, null);
                                        }
                                        break;
                                    }
                                default:
                                    throw new NotImplementedException("token type = " + (token >> 24));
                            }
                        }
                        break;
                    case OperandType.InlineVar:
                        lw.GoToColumn(level1 + 11);
                        WriteInlineVar(lw, mb, opcode, parameters, ReadInt16(code, ref pos));
                        break;
                    case OperandType.ShortInlineVar:
                        lw.GoToColumn(level1 + 11);
                        WriteInlineVar(lw, mb, opcode, parameters, code[pos++]);
                        break;
                    case OperandType.InlineString:
                        lw.GoToColumn(level1 + 11);
                        WriteInlineString(lw, module.ResolveString(ReadInt32(code, ref pos)), level);
                        break;
                    case OperandType.InlineSwitch:
                        {
                            lw.GoToColumn(level1 + 11);
                            lw.WriteLine("( ");
                            int count = ReadInt32(code, ref pos);
                            int offset = pos + 4 * count;
                            for (int i = 0; i < count - 1; i++)
                            {
                                lw.GoToColumn(level + 22);
                                lw.WriteLine("IL_{0:x4},", offset + ReadInt32(code, ref pos));
                            }
                            lw.GoToColumn(level + 22);
                            lw.Write("IL_{0:x4})", offset + ReadInt32(code, ref pos));
                        }
                        break;
                    case OperandType.InlineSig:
                        lw.GoToColumn(level1 + 11);
                        WriteStandAloneMethodSig(lw, module.__ResolveStandAloneMethodSig(ReadInt32(code, ref pos), genericTypeArguments, genericMethodArguments), false, false);
                        break;
                    default:
                        throw new InvalidOperationException();
                }
                lw.WriteLine();

                if (opcode == OpCodes.Leave || opcode == OpCodes.Leave_S)
                {
                    if (pos < code.Length)
                    {
                        lw.WriteLine();
                    }
                }
                else if (opcode != OpCodes.Switch && opcode != OpCodes.Rethrow && opcode != OpCodes.Endfilter && opcode != OpCodes.Endfinally)
                {
                    switch (opcode.FlowControl)
                    {
                        case FlowControl.Branch:
                        case FlowControl.Cond_Branch:
                        case FlowControl.Throw:
                        case FlowControl.Return:
                            extraNewLine = true;
                            break;
                    }
                }
                if (nextFlatException < exceptions2.Count && exceptions2[nextFlatException].HandlerOffset + exceptions2[nextFlatException].HandlerLength == currPos)
                {
                    if (extraNewLine && pos < code.Length)
                    {
                        extraNewLine = false;
                        lw.WriteLine();
                    }
                    lw.GoToColumn(level);
                    if (exceptions2[nextFlatException].FilterOffset == 0)
                    {
                        lw.Write(".try IL_{0:x4} to IL_{1:x4} catch ", exceptions2[nextFlatException].TryOffset, exceptions2[nextFlatException].TryOffset + exceptions2[nextFlatException].TryLength);
                        if (exceptions2[nextFlatException].CatchType.__IsMissing || !exceptions2[nextFlatException].CatchType.IsGenericType)
                        {
                            WriteTypeDefOrRef(lw, exceptions2[nextFlatException].CatchType);
                        }
                        else
                        {
                            WriteSignatureType(lw, exceptions2[nextFlatException].CatchType);
                        }
                        lw.WriteLine(" handler IL_{0:x4} to IL_{1:x4}", exceptions2[nextFlatException].HandlerOffset, exceptions2[nextFlatException].HandlerOffset + exceptions2[nextFlatException].HandlerLength);
                    }
                    else
                    {
                        lw.WriteLine(".try IL_{0:x4} to IL_{1:x4} filter IL_{2:x4} handler IL_{3:x4} to IL_{4:x4}",
                            exceptions2[nextFlatException].TryOffset, exceptions2[nextFlatException].TryOffset + exceptions2[nextFlatException].TryLength,
                            exceptions2[nextFlatException].FilterOffset,
                            exceptions2[nextFlatException].HandlerOffset, exceptions2[nextFlatException].HandlerOffset + exceptions2[nextFlatException].HandlerLength);
                    }
                    nextFlatException++;
                }

                while (currentException != null && currentException.HandlerOffset + currentException.HandlerLength == pos)
                {
                    ExceptionHandlingClause prevException = currentException;
                    currentException = activeExceptions.Pop();
                    if (currentException == null || currentException.TryOffset != prevException.TryOffset || currentException.TryLength != prevException.TryLength)
                    {
                        if (extraNewLine && pos < code.Length)
                        {
                            extraNewLine = false;
                            lw.WriteLine();
                        }
                        level -= 2;
                        lw.GoToColumn(level);
                        lw.WriteLine("}  // end handler");
                        handler = false;
                    }
                    else
                    {
                        handler = true;
                    }
                }
            }
        }

        void WriteInlineVar(LineWriter lw, MethodBase mb, OpCode opcode, ParameterInfo[] parameters, int index)
        {
            if (opcode == OpCodes.Ldarg_S
                || opcode == OpCodes.Starg_S
                || opcode == OpCodes.Ldarga_S
                || opcode == OpCodes.Ldarg
                || opcode == OpCodes.Starg
                || opcode == OpCodes.Ldarga)
            {
                ParameterInfo param = mb.IsStatic ? parameters[index] : index == 0 ? null : parameters[index - 1];
                if (param == null)
                {
                    // this
                    lw.Write("0");
                }
                else if (param.Name == null)
                {
                    lw.Write("A_{0}", index);
                }
                else
                {
                    lw.Write("{0}", QuoteIdentifier(param.Name));
                }
            }
            else
            {
                lw.Write("V_{0}", index);
            }
        }

        static int FloatToInt32Bits(float v)
        {
            return IKVM.Reflection.Reader.SingleConverter.SingleToInt32Bits(v);
        }

        string ToString(float value, bool field)
        {
            if (value == 0 && !field)
            {
                return FloatToInt32Bits(value) < 0
                    ? "-0.0"
                    : "0.0";
            }
            else if (compat != CompatLevel.None)
            {
                byte[] buf = new byte[50];
                _gcvt(value, 8, buf);
                string str = Encoding.ASCII.GetString(buf, 0, Array.IndexOf(buf, (byte)0));
                float v2;
                if (Single.TryParse(str, out v2) && FloatToInt32Bits(value) == FloatToInt32Bits(v2))
                {
                    return str;
                }
                else
                {
                    if (field)
                    {
                        return String.Format("0x{0:X}", FloatToInt32Bits(value));
                    }
                    else
                    {
                        byte[] buf2 = BitConverter.GetBytes(value);
                        return String.Format("({0:X2} {1:X2} {2:X2} {3:X2})", buf2[0], buf2[1], buf2[2], buf2[3]);
                    }
                }
            }
            else if (Single.IsInfinity(value) || Single.IsNaN(value))
            {
                if (field)
                {
                    return String.Format("0x{0:X}", FloatToInt32Bits(value));
                }
                else
                {
                    byte[] buf = BitConverter.GetBytes(value);
                    return String.Format("({0:X2} {1:X2} {2:X2} {3:X2})", buf[0], buf[1], buf[2], buf[3]);
                }
            }
            else
            {
                return String.Format("{0:R}", value);
            }
        }

        void WriteShortInlineR(LineWriter lw, float value, bool field)
        {
            lw.Write(ToString(value, field));
        }

        [System.Runtime.InteropServices.DllImport("msvcrt.dll", CallingConvention = System.Runtime.InteropServices.CallingConvention.Cdecl)]
        static extern IntPtr _gcvt(double value, int digits, byte[] buffer);

        string ToString(double value, bool field)
        {
            if (value == 0 && !field)
            {
                return BitConverter.DoubleToInt64Bits(value) < 0
                    ? "-0.0"
                    : "0.0";
            }
            else if (compat != CompatLevel.None)
            {
                byte[] buf = new byte[50];
                _gcvt(value, 17, buf);
                string str = Encoding.ASCII.GetString(buf, 0, Array.IndexOf(buf, (byte)0));
                double v2;
                if (Double.TryParse(str, out v2) && BitConverter.DoubleToInt64Bits(value) == BitConverter.DoubleToInt64Bits(v2))
                {
                    return str;
                }
                else
                {
                    if (field)
                    {
                        return String.Format("0x{0:X}", BitConverter.DoubleToInt64Bits(value));
                    }
                    else
                    {
                        byte[] buf2 = BitConverter.GetBytes(value);
                        return String.Format("({0:X2} {1:X2} {2:X2} {3:X2} {4:X2} {5:X2} {6:X2} {7:X2})", buf2[0], buf2[1], buf2[2], buf2[3], buf2[4], buf2[5], buf2[6], buf2[7]);
                    }
                }
            }
            else if (Double.IsInfinity(value) || Double.IsNaN(value))
            {
                if (field)
                {
                    return String.Format("0x{0:X}", BitConverter.DoubleToInt64Bits(value));
                }
                else
                {
                    byte[] buf = BitConverter.GetBytes(value);
                    return String.Format("({0:X2} {1:X2} {2:X2} {3:X2} {4:X2} {5:X2} {6:X2} {7:X2})", buf[0], buf[1], buf[2], buf[3], buf[4], buf[5], buf[6], buf[7]);
                }
            }
            else
            {
                return String.Format("{0:R}", value.ToString("R"));
            }
        }

        void WriteInlineR(LineWriter lw, double value, bool field)
        {
            lw.Write(ToString(value, field));
        }

        void WriteInlineString(LineWriter lw, string str, int level)
        {
            int initial = 44 - lw.Column + level;
            int pos = 44;
            StringBuilder sb = new StringBuilder(str.Length + 10);
            int backslashes = 0;
            for (int i = 0; i < str.Length; i++)
            {
                char c = str[i];
                if (i < str.Length - 2 && ((pos == 94 && pos - initial != backslashes) || pos > 94))
                {
                    if (pos - initial == backslashes)
                    {
                        sb.Append('\\', backslashes * 2);
                        backslashes = 0;
                    }
                    pos = initial + backslashes;
                    sb.Append("\"\r\n");
                    sb.Append(' ', level);
                    sb.Append("+ \"");
                }
                if (c == '\\')
                {
                    backslashes++;
                }
                else if (backslashes != 0)
                {
                    sb.Append('\\', backslashes * 2);
                    backslashes = 0;
                }
                if (c < 32)
                {
                    switch (c)
                    {
                        case '\r':
                            sb.Append("\\r");
                            break;
                        case '\n':
                            sb.Append("\\n");
                            break;
                        case '\t':
                            sb.Append("\\t");
                            break;
                        default:
                            lw.Write("bytearray (");
                            WriteBytes(lw, GetBytes(str), false);
                            return;
                    }
                }
                else if (c > 126)
                {
                    lw.Write("bytearray (");
                    WriteBytes(lw, GetBytes(str), false);
                    return;
                }
                else
                {
                    switch (c)
                    {
                        case '"':
                            sb.Append("\\\"");
                            break;
                        case '?':
                            sb.Append("\\?");
                            break;
                        case '\\':
                            break;
                        default:
                            sb.Append(c);
                            break;
                    }
                }
                pos++;
            }
            sb.Append('\\', backslashes * 2);
            lw.Write("\"{0}\"", sb);
        }

        static byte[] GetBytes(string str)
        {
            byte[] buf = new byte[str.Length * 2];
            for (int i = 0; i < str.Length; i++)
            {
                char ch = str[i];
                buf[i * 2 + 0] = (byte)(ch >> 0);
                buf[i * 2 + 1] = (byte)(ch >> 8);
            }
            return buf;
        }

        void WriteInlineI(LineWriter lw, int value)
        {
            if (value >= 128 || value < 128)
            {
                lw.Write("0x{0:x}", value);
            }
            else
            {
                lw.Write("{0}", value);
            }
        }

        void WriteInlineI8(LineWriter lw, long value)
        {
            if (value >= 128 || value < 128)
            {
                lw.Write("0x{0:x}", value);
            }
            else
            {
                lw.Write("{0}", value);
            }
        }

        static bool IsArrayOfGenericParameter(Type type)
        {
            if (type != null && type.IsArray)
            {
                while (type.IsArray)
                {
                    type = type.GetElementType();
                }
                return !type.__IsMissing && type.IsGenericParameter;
            }
            return false;
        }

        void WriteInlineMethod(LineWriter lw, MethodBase mb, Type[] optionalParameterTypes, CustomModifiers[] customModifiers, MethodInfo methodimpl = null)
        {
            WriteCallingConvention(lw, mb.CallingConvention);
            if (mb is ConstructorInfo)
            {
                WriteSignatureType(lw, ((ConstructorInfo)mb).__ReturnParameter.ParameterType);
                WriteCustomModifiers(lw, ((ConstructorInfo)mb).__ReturnParameter.__GetCustomModifiers());
                lw.Write(" ");
            }
            else
            {
                WriteSignatureType(lw, ((MethodInfo)mb.__GetMethodOnTypeDefinition()).ReturnType, IsArrayOfGenericParameter(mb.DeclaringType) ? TypeLocation.General : TypeLocation.MemberRefNoWrap);
                WriteCustomModifiers(lw, ((MethodInfo)mb).ReturnParameter.__GetCustomModifiers());
                lw.Write(" ");
            }
            bool generic;
            if (mb.DeclaringType == null)
            {
                generic = false;
                lw.Write("{0}", QuoteIdentifier(GetMethodName(mb)));
            }
            else
            {
                if (mb.DeclaringType.__IsMissing || !mb.DeclaringType.IsGenericType)
                {
                    generic = false;
                    WriteTypeDefOrRef(lw, mb.DeclaringType);
                }
                else
                {
                    generic = true;
                    WriteSignatureType(lw, mb.DeclaringType, mb.IsGenericMethod ? TypeLocation.DeclaringType : TypeLocation.General);
                }
                lw.Write("::{0}", QuoteIdentifier(GetMethodName(mb)));
            }
            if (mb.IsGenericMethod)
            {
                if (methodimpl != null)
                {
                    lw.Write("<[{0}]>", mb.GetGenericArguments().Length);
                }
                else
                {
                    lw.Write("<");
                    string sep = "";
                    foreach (var par in mb.GetGenericArguments())
                    {
                        lw.Write(sep);
                        sep = ",";
                        WriteSignatureType(lw, par, generic ? TypeLocation.MemberRefNoWrap : TypeLocation.MethodGenericParameter);
                    }
                    lw.Write(">");
                }
            }
            if (mb.IsGenericMethodDefinition && methodimpl != null)
            {
                mb = ((MethodInfo)mb).MakeGenericMethod(methodimpl.GetGenericArguments());
            }
            else
            {
                mb = mb.__GetMethodOnTypeDefinition();
            }
            lw.Write("(");
            TypeLocation loc = (methodimpl != null && mb.IsGenericMethod)
                ? TypeLocation.GenericMethodImpl
                : IsArrayOfGenericParameter(mb.DeclaringType) ? TypeLocation.General : TypeLocation.MemberRefNoWrap;
            int level = lw.Column;
            if (compat != CompatLevel.None && loc == TypeLocation.GenericMethodImpl)
            {
                // ildasm doesn't take the length of the arity ("<[1]>") into account
                level -= 5 + (int)Math.Log10(mb.GetGenericArguments().Length);
            }
            bool first = true;
            bool noLineWrapCompat = false;
            foreach (var parameter in mb.GetParameters())
            {
                if (!first)
                {
                    if (noLineWrapCompat)
                    {
                        lw.Write(",");
                    }
                    else
                    {
                        if (loc == TypeLocation.MemberRefNoWrap)
                        {
                            loc = TypeLocation.MemberRef;
                        }
                        lw.WriteLine(",");
                        lw.GoToColumn(level);
                    }
                }
                first = false;
                lw.ClearWrappedFlag();
                WriteSignatureType(lw, parameter.ParameterType, loc);
                noLineWrapCompat |= lw.Wrapped;
                WriteCustomModifiers(lw, parameter.__GetCustomModifiers());
            }
            if (optionalParameterTypes.Length != 0)
            {
                if (!first)
                {
                    lw.WriteLine(",");
                    lw.GoToColumn(level);
                }
                first = false;
                lw.Write("...");
                for (int i = 0; i < optionalParameterTypes.Length; i++)
                {
                    if (!first)
                    {
                        lw.WriteLine(",");
                        lw.GoToColumn(level);
                    }
                    first = false;
                    WriteSignatureType(lw, optionalParameterTypes[i], TypeLocation.MemberRef);
                    WriteCustomModifiers(lw, customModifiers[i]);
                }
            }
            lw.Write(")");
        }

        void WriteInlineType(LineWriter lw, int metadataToken, Type[] genericTypeArguments, Type[] genericMethodArguments)
        {
            CustomModifiers mods = new CustomModifiers();
            if (metadataToken >> 24 == 0x1B)
            {
                mods = module.__ResolveTypeSpecCustomModifiers(metadataToken, genericTypeArguments, genericMethodArguments);
            }
            if (!mods.IsEmpty)
            {
                lw.Write("class ");
            }
            Type type = ResolveType(metadataToken, genericTypeArguments, genericMethodArguments);
            if (type.HasElementType)
            {
                WriteSignatureType(lw, type);
            }
            else if (!type.__IsMissing && type.IsGenericType)
            {
                WriteSignatureType(lw, type, TypeLocation.General);
            }
            else
            {
                WriteTypeDefOrRef(lw, type);
            }
            if (!mods.IsEmpty)
            {
                WriteCustomModifiers(lw, mods);
            }
        }

        void WriteInlineField(LineWriter lw, FieldInfo field)
        {
            WriteSignatureType(lw, field.__GetFieldOnTypeDefinition().FieldType, TypeLocation.MemberRefNoWrap);
            WriteCustomModifiers(lw, field.__GetCustomModifiers());
            lw.Write(" ");
            if (field.DeclaringType == null)
            {
                lw.Write("{0}", QuoteIdentifier(GetFieldName(field)));
            }
            else
            {
                if (field.DeclaringType.__IsMissing || !field.DeclaringType.IsGenericType)
                {
                    WriteTypeDefOrRef(lw, field.DeclaringType);
                }
                else
                {
                    WriteSignatureType(lw, field.DeclaringType, TypeLocation.General);
                }
                lw.Write("::{0}", QuoteIdentifier(GetFieldName(field)));
            }
        }

        Type[] ResolveOptionalParameterTypes(int token, Type[] genericTypeArguments, Type[] genericMethodArguments, out CustomModifiers[] customModifiers)
        {
            return module.__ResolveOptionalParameterTypes(token, genericTypeArguments, genericMethodArguments, out customModifiers);
        }

        void SortExceptions(IList<ExceptionHandlingClause> all, List<ExceptionHandlingClause> nested, List<ExceptionHandlingClause> flat)
        {
            var exceptions = new List<ExceptionHandlingClause>(all);
            exceptions.Sort(this);
            int first = 0;
            for (int i = 1; i <= exceptions.Count; i++)
            {
                if (i < exceptions.Count
                    && exceptions[first].TryOffset == exceptions[i].TryOffset
                    && exceptions[first].TryLength == exceptions[i].TryLength
                    && (compat != CompatLevel.V20 || exceptions[i].FilterOffset == 0))
                {
                    // part of a multiple handler block
                }
                else
                {
                    if (compat == CompatLevel.V20)
                    {
                        for (int j = first; j < i; j++)
                        {
                            if (exceptions[j].FilterOffset != 0
                                || (i < exceptions.Count
                                    && exceptions[j].TryOffset == exceptions[i].TryOffset
                                    && exceptions[j].TryLength == exceptions[i].TryLength
                                    && exceptions[j].HandlerOffset + exceptions[j].HandlerLength > exceptions[i].FilterOffset))
                            {
                                flat.Add(exceptions[j]);
                            }
                            else
                            {
                                nested.Add(exceptions[j]);
                            }
                        }
                    }
                    else
                    {
                        for (int j = first; j < i; j++)
                        {
                            nested.Add(exceptions[j]);
                        }
                        int end = exceptions[first].TryOffset + exceptions[first].TryLength;
                        for (int j = i - 1; j >= first; j--)
                        {
                            Debug.Assert(exceptions[j].TryOffset == exceptions[first].TryOffset && exceptions[j].TryLength == exceptions[first].TryLength);
                            if (exceptions[j].FilterOffset == end)
                            {
                                end += exceptions[j].HandlerOffset - exceptions[j].FilterOffset;
                            }
                            if (exceptions[j].HandlerOffset != end)
                            {
                                throw new NotImplementedException();
                            }
                            end += exceptions[j].HandlerLength;
                        }
                    }
                    first = i;
                }
            }
            flat.Sort(FlatExceptionComparer);
        }

        static int FlatExceptionComparer(ExceptionHandlingClause x, ExceptionHandlingClause y)
        {
            return (x.HandlerOffset + x.HandlerLength).CompareTo(y.HandlerOffset + y.HandlerLength);
        }

        Type ResolveType(int token, Type[] genericTypeArguments, Type[] genericMethodArguments)
        {
            return module.ResolveType(token, genericTypeArguments, genericMethodArguments);
        }

        FieldInfo ResolveField(int token, Type[] genericTypeArguments, Type[] genericMethodArguments)
        {
            return module.ResolveField(token, genericTypeArguments, genericMethodArguments);
        }

        MethodBase ResolveMethod(int token, Type[] genericTypeArguments, Type[] genericMethodArguments)
        {
            return module.ResolveMethod(token, genericTypeArguments, genericMethodArguments);
        }

        MemberInfo ResolveMember(int token, Type[] genericTypeArguments, Type[] genericMethodArguments)
        {
            return module.ResolveMember(token, genericTypeArguments, genericMethodArguments);
        }

        short ReadInt16(byte[] code, ref int pos)
        {
            short s = BitConverter.ToInt16(code, pos);
            pos += 2;
            return s;
        }

        int ReadInt32(byte[] code, ref int pos)
        {
            int i = BitConverter.ToInt32(code, pos);
            pos += 4;
            return i;
        }

        long ReadInt64(byte[] code, ref int pos)
        {
            long l = BitConverter.ToInt64(code, pos);
            pos += 8;
            return l;
        }

        float ReadSingle(byte[] code, ref int pos)
        {
            float f = BitConverter.ToSingle(code, pos);
            pos += 4;
            return f;
        }

        double ReadDouble(byte[] code, ref int pos)
        {
            double d = BitConverter.ToDouble(code, pos);
            pos += 8;
            return d;
        }

        int IComparer<ExceptionHandlingClause>.Compare(ExceptionHandlingClause x, ExceptionHandlingClause y)
		{
			if (x.TryOffset < y.TryOffset)
			{
				return -1;
			}
			if (x.TryOffset > y.TryOffset)
			{
				return 1;
			}
			if (x.TryLength > y.TryLength)
			{
				return -1;
			}
			if (x.TryLength < y.TryLength)
			{
				return 1;
			}
			if (x.HandlerOffset > y.HandlerOffset)
			{
				return -1;
			}
            if (x.HandlerOffset < y.HandlerOffset)
            {
                return 1;
            }
            return 0;
		}
    }
}
