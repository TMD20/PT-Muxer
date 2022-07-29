// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

[assembly:System.Reflection.AssemblyVersionAttribute("2.0.5.0")]
[assembly:System.CLSCompliantAttribute(true)]
[assembly:System.Diagnostics.DebuggableAttribute(System.Diagnostics.DebuggableAttribute.DebuggingModes.IgnoreSymbolStoreSequencePoints)]
[assembly:System.Reflection.AssemblyCompanyAttribute("MONO development team")]
[assembly:System.Reflection.AssemblyCopyrightAttribute("(c) 2008 Novell, Inc")]
[assembly:System.Reflection.AssemblyDescriptionAttribute("Mono.Simd.dll")]
[assembly:System.Reflection.AssemblyProductAttribute("MONO CLI")]
[assembly:System.Reflection.AssemblyTitleAttribute("Mono.Simd.dll")]
[assembly:System.Resources.NeutralResourcesLanguageAttribute("en-US")]
[assembly:System.Runtime.CompilerServices.CompilationRelaxationsAttribute(8)]
[assembly:System.Runtime.CompilerServices.RuntimeCompatibilityAttribute(WrapNonExceptionThrows=true)]
[assembly:System.Runtime.InteropServices.ComVisibleAttribute(false)]
[assembly:System.Security.Permissions.SecurityPermissionAttribute(System.Security.Permissions.SecurityAction.RequestMinimum, SkipVerification=true)]
namespace Mono.Simd
{
    [System.AttributeUsageAttribute(System.AttributeTargets.Constructor | System.AttributeTargets.Method | System.AttributeTargets.Property, Inherited=false)]
    public sealed partial class AccelerationAttribute : System.Attribute
    {
        public AccelerationAttribute(Mono.Simd.AccelMode mode) { }
        public Mono.Simd.AccelMode Mode { get { throw null; } set { } }
    }
    [System.FlagsAttribute]
    public enum AccelMode
    {
        None = 0,
        SSE1 = 1,
        SSE2 = 2,
        SSE3 = 4,
        SSE41 = 16,
        SSE42 = 32,
        SSE4A = 64,
        SSSE3 = 8,
    }
    public static partial class ArrayExtensions
    {
        [Mono.Simd.AccelerationAttribute(Mono.Simd.AccelMode.SSE1)]
        [System.CLSCompliantAttribute(false)]
        public static Mono.Simd.Vector16b GetVector(this byte[] array, int offset) { throw null; }
        [Mono.Simd.AccelerationAttribute(Mono.Simd.AccelMode.SSE1)]
        [System.CLSCompliantAttribute(false)]
        public static Mono.Simd.Vector2d GetVector(this double[] array, int offset) { throw null; }
        [Mono.Simd.AccelerationAttribute(Mono.Simd.AccelMode.SSE1)]
        [System.CLSCompliantAttribute(false)]
        public static Mono.Simd.Vector8s GetVector(this short[] array, int offset) { throw null; }
        [Mono.Simd.AccelerationAttribute(Mono.Simd.AccelMode.SSE1)]
        [System.CLSCompliantAttribute(false)]
        public static Mono.Simd.Vector4i GetVector(this int[] array, int offset) { throw null; }
        [Mono.Simd.AccelerationAttribute(Mono.Simd.AccelMode.SSE1)]
        [System.CLSCompliantAttribute(false)]
        public static Mono.Simd.Vector2l GetVector(this long[] array, int offset) { throw null; }
        [Mono.Simd.AccelerationAttribute(Mono.Simd.AccelMode.SSE1)]
        [System.CLSCompliantAttribute(false)]
        public static Mono.Simd.Vector16sb GetVector(this sbyte[] array, int offset) { throw null; }
        [Mono.Simd.AccelerationAttribute(Mono.Simd.AccelMode.SSE1)]
        [System.CLSCompliantAttribute(false)]
        public static Mono.Simd.Vector4f GetVector(this float[] array, int offset) { throw null; }
        [Mono.Simd.AccelerationAttribute(Mono.Simd.AccelMode.SSE1)]
        [System.CLSCompliantAttribute(false)]
        public static Mono.Simd.Vector8us GetVector(this ushort[] array, int offset) { throw null; }
        [Mono.Simd.AccelerationAttribute(Mono.Simd.AccelMode.SSE1)]
        [System.CLSCompliantAttribute(false)]
        public static Mono.Simd.Vector4ui GetVector(this uint[] array, int offset) { throw null; }
        [Mono.Simd.AccelerationAttribute(Mono.Simd.AccelMode.SSE1)]
        [System.CLSCompliantAttribute(false)]
        public static Mono.Simd.Vector2ul GetVector(this ulong[] array, int offset) { throw null; }
        [Mono.Simd.AccelerationAttribute(Mono.Simd.AccelMode.SSE1)]
        [System.CLSCompliantAttribute(false)]
        public static Mono.Simd.Vector16b GetVectorAligned(this byte[] array, int offset) { throw null; }
        [Mono.Simd.AccelerationAttribute(Mono.Simd.AccelMode.SSE1)]
        [System.CLSCompliantAttribute(false)]
        public static Mono.Simd.Vector2d GetVectorAligned(this double[] array, int offset) { throw null; }
        [Mono.Simd.AccelerationAttribute(Mono.Simd.AccelMode.SSE1)]
        [System.CLSCompliantAttribute(false)]
        public static Mono.Simd.Vector8s GetVectorAligned(this short[] array, int offset) { throw null; }
        [Mono.Simd.AccelerationAttribute(Mono.Simd.AccelMode.SSE1)]
        [System.CLSCompliantAttribute(false)]
        public static Mono.Simd.Vector4i GetVectorAligned(this int[] array, int offset) { throw null; }
        [Mono.Simd.AccelerationAttribute(Mono.Simd.AccelMode.SSE1)]
        [System.CLSCompliantAttribute(false)]
        public static Mono.Simd.Vector2l GetVectorAligned(this long[] array, int offset) { throw null; }
        [Mono.Simd.AccelerationAttribute(Mono.Simd.AccelMode.SSE1)]
        [System.CLSCompliantAttribute(false)]
        public static Mono.Simd.Vector16sb GetVectorAligned(this sbyte[] array, int offset) { throw null; }
        [Mono.Simd.AccelerationAttribute(Mono.Simd.AccelMode.SSE1)]
        [System.CLSCompliantAttribute(false)]
        public static Mono.Simd.Vector4f GetVectorAligned(this float[] array, int offset) { throw null; }
        [Mono.Simd.AccelerationAttribute(Mono.Simd.AccelMode.SSE1)]
        [System.CLSCompliantAttribute(false)]
        public static Mono.Simd.Vector8us GetVectorAligned(this ushort[] array, int offset) { throw null; }
        [Mono.Simd.AccelerationAttribute(Mono.Simd.AccelMode.SSE1)]
        [System.CLSCompliantAttribute(false)]
        public static Mono.Simd.Vector4ui GetVectorAligned(this uint[] array, int offset) { throw null; }
        [Mono.Simd.AccelerationAttribute(Mono.Simd.AccelMode.SSE1)]
        [System.CLSCompliantAttribute(false)]
        public static Mono.Simd.Vector2ul GetVectorAligned(this ulong[] array, int offset) { throw null; }
        public static bool IsAligned<T>(this T[] vect, int index) where T : struct { throw null; }
        [Mono.Simd.AccelerationAttribute(Mono.Simd.AccelMode.SSE1)]
        [System.CLSCompliantAttribute(false)]
        public static void SetVector(this byte[] array, Mono.Simd.Vector16b val, int offset) { }
        [Mono.Simd.AccelerationAttribute(Mono.Simd.AccelMode.SSE1)]
        [System.CLSCompliantAttribute(false)]
        public static void SetVector(this double[] array, Mono.Simd.Vector2d val, int offset) { }
        [Mono.Simd.AccelerationAttribute(Mono.Simd.AccelMode.SSE1)]
        [System.CLSCompliantAttribute(false)]
        public static void SetVector(this short[] array, Mono.Simd.Vector8s val, int offset) { }
        [Mono.Simd.AccelerationAttribute(Mono.Simd.AccelMode.SSE1)]
        [System.CLSCompliantAttribute(false)]
        public static void SetVector(this int[] array, Mono.Simd.Vector4i val, int offset) { }
        [Mono.Simd.AccelerationAttribute(Mono.Simd.AccelMode.SSE1)]
        [System.CLSCompliantAttribute(false)]
        public static void SetVector(this long[] array, Mono.Simd.Vector2l val, int offset) { }
        [Mono.Simd.AccelerationAttribute(Mono.Simd.AccelMode.SSE1)]
        [System.CLSCompliantAttribute(false)]
        public static void SetVector(this sbyte[] array, Mono.Simd.Vector16sb val, int offset) { }
        [Mono.Simd.AccelerationAttribute(Mono.Simd.AccelMode.SSE1)]
        [System.CLSCompliantAttribute(false)]
        public static void SetVector(this float[] array, Mono.Simd.Vector4f val, int offset) { }
        [Mono.Simd.AccelerationAttribute(Mono.Simd.AccelMode.SSE1)]
        [System.CLSCompliantAttribute(false)]
        public static void SetVector(this ushort[] array, Mono.Simd.Vector8us val, int offset) { }
        [Mono.Simd.AccelerationAttribute(Mono.Simd.AccelMode.SSE1)]
        [System.CLSCompliantAttribute(false)]
        public static void SetVector(this uint[] array, Mono.Simd.Vector4ui val, int offset) { }
        [Mono.Simd.AccelerationAttribute(Mono.Simd.AccelMode.SSE1)]
        [System.CLSCompliantAttribute(false)]
        public static void SetVector(this ulong[] array, Mono.Simd.Vector2ul val, int offset) { }
        [Mono.Simd.AccelerationAttribute(Mono.Simd.AccelMode.SSE1)]
        [System.CLSCompliantAttribute(false)]
        public static void SetVectorAligned(this byte[] array, Mono.Simd.Vector16b val, int offset) { }
        [Mono.Simd.AccelerationAttribute(Mono.Simd.AccelMode.SSE1)]
        [System.CLSCompliantAttribute(false)]
        public static void SetVectorAligned(this double[] array, Mono.Simd.Vector2d val, int offset) { }
        [Mono.Simd.AccelerationAttribute(Mono.Simd.AccelMode.SSE1)]
        [System.CLSCompliantAttribute(false)]
        public static void SetVectorAligned(this short[] array, Mono.Simd.Vector8s val, int offset) { }
        [Mono.Simd.AccelerationAttribute(Mono.Simd.AccelMode.SSE1)]
        [System.CLSCompliantAttribute(false)]
        public static void SetVectorAligned(this int[] array, Mono.Simd.Vector4i val, int offset) { }
        [Mono.Simd.AccelerationAttribute(Mono.Simd.AccelMode.SSE1)]
        [System.CLSCompliantAttribute(false)]
        public static void SetVectorAligned(this long[] array, Mono.Simd.Vector2l val, int offset) { }
        [Mono.Simd.AccelerationAttribute(Mono.Simd.AccelMode.SSE1)]
        [System.CLSCompliantAttribute(false)]
        public static void SetVectorAligned(this sbyte[] array, Mono.Simd.Vector16sb val, int offset) { }
        [Mono.Simd.AccelerationAttribute(Mono.Simd.AccelMode.SSE1)]
        [System.CLSCompliantAttribute(false)]
        public static void SetVectorAligned(this float[] array, Mono.Simd.Vector4f val, int offset) { }
        [Mono.Simd.AccelerationAttribute(Mono.Simd.AccelMode.SSE1)]
        [System.CLSCompliantAttribute(false)]
        public static void SetVectorAligned(this ushort[] array, Mono.Simd.Vector8us val, int offset) { }
        [Mono.Simd.AccelerationAttribute(Mono.Simd.AccelMode.SSE1)]
        [System.CLSCompliantAttribute(false)]
        public static void SetVectorAligned(this uint[] array, Mono.Simd.Vector4ui val, int offset) { }
        [Mono.Simd.AccelerationAttribute(Mono.Simd.AccelMode.SSE1)]
        [System.CLSCompliantAttribute(false)]
        public static void SetVectorAligned(this ulong[] array, Mono.Simd.Vector2ul val, int offset) { }
    }
    public enum ShuffleSel
    {
        ExpandInterleavedXY = 68,
        ExpandInterleavedZW = 238,
        ExpandW = 255,
        ExpandX = 0,
        ExpandXY = 80,
        ExpandY = 85,
        ExpandZ = 170,
        ExpandZW = 250,
        RotateLeft = 147,
        RotateRight = 57,
        Swap = 27,
        WFromW = 192,
        WFromX = 0,
        WFromY = 64,
        WFromZ = 128,
        XFromW = 3,
        XFromX = 0,
        XFromY = 1,
        XFromZ = 2,
        YFromW = 12,
        YFromX = 0,
        YFromY = 4,
        YFromZ = 8,
        ZFromW = 48,
        ZFromX = 0,
        ZFromY = 16,
        ZFromZ = 32,
    }
    public static partial class SimdRuntime
    {
        public static Mono.Simd.AccelMode AccelMode { get { throw null; } }
        public static bool IsMethodAccelerated(System.Type type, string method) { throw null; }
        public static bool IsMethodAccelerated(System.Type type, string method, params System.Type[] signature) { throw null; }
        public static Mono.Simd.AccelMode MethodAccelerationMode(System.Reflection.MethodInfo method) { throw null; }
        public static Mono.Simd.AccelMode MethodAccelerationMode(System.Type type, string method) { throw null; }
        public static Mono.Simd.AccelMode MethodAccelerationMode(System.Type type, string method, params System.Type[] signature) { throw null; }
    }
    [System.ObsoleteAttribute("Use the types in the System.Numerics.Vectors namespace")]
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Explicit, Size=16, Pack=1)]
    public partial struct Vector16b
    {
        [System.Runtime.InteropServices.FieldOffsetAttribute(0)]
        private int _dummyPrimitive;
        public Vector16b(byte b) { throw null; }
        public Vector16b(byte v0, byte v1, byte v2, byte v3, byte v4, byte v5, byte v6, byte v7, byte v8, byte v9, byte v10, byte v11, byte v12, byte v13, byte v14, byte v15) { throw null; }
        [System.Runtime.CompilerServices.IndexerName("Component")]
        public byte this[int index] { get { throw null; } set { } }
        public static Mono.Simd.Vector16b One { get { throw null; } }
        public byte V0 { get { throw null; } set { } }
        public byte V1 { get { throw null; } set { } }
        public byte V10 { get { throw null; } set { } }
        public byte V11 { get { throw null; } set { } }
        public byte V12 { get { throw null; } set { } }
        public byte V13 { get { throw null; } set { } }
        public byte V14 { get { throw null; } set { } }
        public byte V15 { get { throw null; } set { } }
        public byte V2 { get { throw null; } set { } }
        public byte V3 { get { throw null; } set { } }
        public byte V4 { get { throw null; } set { } }
        public byte V5 { get { throw null; } set { } }
        public byte V6 { get { throw null; } set { } }
        public byte V7 { get { throw null; } set { } }
        public byte V8 { get { throw null; } set { } }
        public byte V9 { get { throw null; } set { } }
        public static Mono.Simd.Vector16b Zero { get { throw null; } }
        [Mono.Simd.AccelerationAttribute(Mono.Simd.AccelMode.SSE1)]
        [System.CLSCompliantAttribute(false)]
        public unsafe static Mono.Simd.Vector16b LoadAligned(Mono.Simd.Vector16b* v) { throw null; }
        [Mono.Simd.AccelerationAttribute(Mono.Simd.AccelMode.SSE1)]
        public static Mono.Simd.Vector16b LoadAligned(ref Mono.Simd.Vector16b v) { throw null; }
        [Mono.Simd.AccelerationAttribute(Mono.Simd.AccelMode.SSE2)]
        public static Mono.Simd.Vector16b operator +(Mono.Simd.Vector16b va, Mono.Simd.Vector16b vb) { throw null; }
        [Mono.Simd.AccelerationAttribute(Mono.Simd.AccelMode.SSE2)]
        public static Mono.Simd.Vector16b operator &(Mono.Simd.Vector16b va, Mono.Simd.Vector16b vb) { throw null; }
        [Mono.Simd.AccelerationAttribute(Mono.Simd.AccelMode.SSE2)]
        public static Mono.Simd.Vector16b operator |(Mono.Simd.Vector16b va, Mono.Simd.Vector16b vb) { throw null; }
        [Mono.Simd.AccelerationAttribute(Mono.Simd.AccelMode.SSE2)]
        public static bool operator ==(Mono.Simd.Vector16b va, Mono.Simd.Vector16b vb) { throw null; }
        [Mono.Simd.AccelerationAttribute(Mono.Simd.AccelMode.SSE2)]
        public static Mono.Simd.Vector16b operator ^(Mono.Simd.Vector16b va, Mono.Simd.Vector16b vb) { throw null; }
        [Mono.Simd.AccelerationAttribute(Mono.Simd.AccelMode.SSE1)]
        [System.CLSCompliantAttribute(false)]
        public static explicit operator Mono.Simd.Vector16sb (Mono.Simd.Vector16b v) { throw null; }
        [Mono.Simd.AccelerationAttribute(Mono.Simd.AccelMode.SSE1)]
        public static explicit operator Mono.Simd.Vector2d (Mono.Simd.Vector16b v) { throw null; }
        [Mono.Simd.AccelerationAttribute(Mono.Simd.AccelMode.SSE1)]
        public static explicit operator Mono.Simd.Vector2l (Mono.Simd.Vector16b v) { throw null; }
        [Mono.Simd.AccelerationAttribute(Mono.Simd.AccelMode.SSE1)]
        [System.CLSCompliantAttribute(false)]
        public static explicit operator Mono.Simd.Vector2ul (Mono.Simd.Vector16b v) { throw null; }
        [Mono.Simd.AccelerationAttribute(Mono.Simd.AccelMode.SSE1)]
        public static explicit operator Mono.Simd.Vector4f (Mono.Simd.Vector16b v) { throw null; }
        [Mono.Simd.AccelerationAttribute(Mono.Simd.AccelMode.SSE1)]
        public static explicit operator Mono.Simd.Vector4i (Mono.Simd.Vector16b v) { throw null; }
        [Mono.Simd.AccelerationAttribute(Mono.Simd.AccelMode.SSE1)]
        [System.CLSCompliantAttribute(false)]
        public static explicit operator Mono.Simd.Vector4ui (Mono.Simd.Vector16b v) { throw null; }
        [Mono.Simd.AccelerationAttribute(Mono.Simd.AccelMode.SSE1)]
        public static explicit operator Mono.Simd.Vector8s (Mono.Simd.Vector16b v) { throw null; }
        [Mono.Simd.AccelerationAttribute(Mono.Simd.AccelMode.SSE1)]
        [System.CLSCompliantAttribute(false)]
        public static explicit operator Mono.Simd.Vector8us (Mono.Simd.Vector16b v) { throw null; }
        [Mono.Simd.AccelerationAttribute(Mono.Simd.AccelMode.SSE2)]
        public static bool operator !=(Mono.Simd.Vector16b va, Mono.Simd.Vector16b vb) { throw null; }
        [Mono.Simd.AccelerationAttribute(Mono.Simd.AccelMode.SSE2)]
        public static Mono.Simd.Vector16b operator -(Mono.Simd.Vector16b va, Mono.Simd.Vector16b vb) { throw null; }
        [Mono.Simd.AccelerationAttribute(Mono.Simd.AccelMode.SSE1)]
        [System.CLSCompliantAttribute(false)]
        public unsafe static void PrefetchNonTemporal(Mono.Simd.Vector16b* res) { }
        [Mono.Simd.AccelerationAttribute(Mono.Simd.AccelMode.SSE1)]
        [System.CLSCompliantAttribute(false)]
        public static void PrefetchNonTemporal(ref Mono.Simd.Vector16b res) { }
        [Mono.Simd.AccelerationAttribute(Mono.Simd.AccelMode.SSE1)]
        [System.CLSCompliantAttribute(false)]
        public unsafe static void PrefetchTemporal1stLevelCache(Mono.Simd.Vector16b* res) { }
        [Mono.Simd.AccelerationAttribute(Mono.Simd.AccelMode.SSE1)]
        [System.CLSCompliantAttribute(false)]
        public static void PrefetchTemporal1stLevelCache(ref Mono.Simd.Vector16b res) { }
        [Mono.Simd.AccelerationAttribute(Mono.Simd.AccelMode.SSE1)]
        [System.CLSCompliantAttribute(false)]
        public unsafe static void PrefetchTemporal2ndLevelCache(Mono.Simd.Vector16b* res) { }
        [Mono.Simd.AccelerationAttribute(Mono.Simd.AccelMode.SSE1)]
        [System.CLSCompliantAttribute(false)]
        public static void PrefetchTemporal2ndLevelCache(ref Mono.Simd.Vector16b res) { }
        [Mono.Simd.AccelerationAttribute(Mono.Simd.AccelMode.SSE1)]
        [System.CLSCompliantAttribute(false)]
        public unsafe static void PrefetchTemporalAllCacheLevels(Mono.Simd.Vector16b* res) { }
        [Mono.Simd.AccelerationAttribute(Mono.Simd.AccelMode.SSE1)]
        [System.CLSCompliantAttribute(false)]
        public static void PrefetchTemporalAllCacheLevels(ref Mono.Simd.Vector16b res) { }
        [Mono.Simd.AccelerationAttribute(Mono.Simd.AccelMode.SSE1)]
        [System.CLSCompliantAttribute(false)]
        public unsafe static void StoreAligned(Mono.Simd.Vector16b* res, Mono.Simd.Vector16b val) { }
        [Mono.Simd.AccelerationAttribute(Mono.Simd.AccelMode.SSE1)]
        public static void StoreAligned(ref Mono.Simd.Vector16b res, Mono.Simd.Vector16b val) { }
        public override string ToString() { throw null; }
    }
    [System.CLSCompliantAttribute(false)]
    [System.ObsoleteAttribute("Use the types in the System.Numerics.Vectors namespace")]
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Explicit, Size=16, Pack=1)]
    public partial struct Vector16sb
    {
        [System.Runtime.InteropServices.FieldOffsetAttribute(0)]
        private int _dummyPrimitive;
        public Vector16sb(sbyte sb) { throw null; }
        public Vector16sb(sbyte v0, sbyte v1, sbyte v2, sbyte v3, sbyte v4, sbyte v5, sbyte v6, sbyte v7, sbyte v8, sbyte v9, sbyte v10, sbyte v11, sbyte v12, sbyte v13, sbyte v14, sbyte v15) { throw null; }
        [System.Runtime.CompilerServices.IndexerName("Component")]
        public sbyte this[int index] { get { throw null; } set { } }
        public static Mono.Simd.Vector16sb MinusOne { get { throw null; } }
        public static Mono.Simd.Vector16sb One { get { throw null; } }
        public sbyte V0 { get { throw null; } set { } }
        public sbyte V1 { get { throw null; } set { } }
        public sbyte V10 { get { throw null; } set { } }
        public sbyte V11 { get { throw null; } set { } }
        public sbyte V12 { get { throw null; } set { } }
        public sbyte V13 { get { throw null; } set { } }
        public sbyte V14 { get { throw null; } set { } }
        public sbyte V15 { get { throw null; } set { } }
        public sbyte V2 { get { throw null; } set { } }
        public sbyte V3 { get { throw null; } set { } }
        public sbyte V4 { get { throw null; } set { } }
        public sbyte V5 { get { throw null; } set { } }
        public sbyte V6 { get { throw null; } set { } }
        public sbyte V7 { get { throw null; } set { } }
        public sbyte V8 { get { throw null; } set { } }
        public sbyte V9 { get { throw null; } set { } }
        public static Mono.Simd.Vector16sb Zero { get { throw null; } }
        [Mono.Simd.AccelerationAttribute(Mono.Simd.AccelMode.SSE1)]
        public unsafe static Mono.Simd.Vector16sb LoadAligned(Mono.Simd.Vector16sb* v) { throw null; }
        [Mono.Simd.AccelerationAttribute(Mono.Simd.AccelMode.SSE1)]
        public static Mono.Simd.Vector16sb LoadAligned(ref Mono.Simd.Vector16sb v) { throw null; }
        [Mono.Simd.AccelerationAttribute(Mono.Simd.AccelMode.SSE2)]
        public static Mono.Simd.Vector16sb operator +(Mono.Simd.Vector16sb va, Mono.Simd.Vector16sb vb) { throw null; }
        [Mono.Simd.AccelerationAttribute(Mono.Simd.AccelMode.SSE2)]
        public static Mono.Simd.Vector16sb operator &(Mono.Simd.Vector16sb va, Mono.Simd.Vector16sb vb) { throw null; }
        [Mono.Simd.AccelerationAttribute(Mono.Simd.AccelMode.SSE2)]
        public static Mono.Simd.Vector16sb operator |(Mono.Simd.Vector16sb va, Mono.Simd.Vector16sb vb) { throw null; }
        [Mono.Simd.AccelerationAttribute(Mono.Simd.AccelMode.SSE2)]
        public static bool operator ==(Mono.Simd.Vector16sb va, Mono.Simd.Vector16sb vb) { throw null; }
        [Mono.Simd.AccelerationAttribute(Mono.Simd.AccelMode.SSE2)]
        public static Mono.Simd.Vector16sb operator ^(Mono.Simd.Vector16sb va, Mono.Simd.Vector16sb vb) { throw null; }
        [Mono.Simd.AccelerationAttribute(Mono.Simd.AccelMode.SSE1)]
        public static explicit operator Mono.Simd.Vector16b (Mono.Simd.Vector16sb v) { throw null; }
        [Mono.Simd.AccelerationAttribute(Mono.Simd.AccelMode.SSE1)]
        public static explicit operator Mono.Simd.Vector2d (Mono.Simd.Vector16sb v) { throw null; }
        [Mono.Simd.AccelerationAttribute(Mono.Simd.AccelMode.SSE1)]
        public static explicit operator Mono.Simd.Vector2l (Mono.Simd.Vector16sb v) { throw null; }
        [Mono.Simd.AccelerationAttribute(Mono.Simd.AccelMode.SSE1)]
        public static explicit operator Mono.Simd.Vector2ul (Mono.Simd.Vector16sb v) { throw null; }
        [Mono.Simd.AccelerationAttribute(Mono.Simd.AccelMode.SSE1)]
        public static explicit operator Mono.Simd.Vector4f (Mono.Simd.Vector16sb v) { throw null; }
        [Mono.Simd.AccelerationAttribute(Mono.Simd.AccelMode.SSE1)]
        public static explicit operator Mono.Simd.Vector4i (Mono.Simd.Vector16sb v) { throw null; }
        [Mono.Simd.AccelerationAttribute(Mono.Simd.AccelMode.SSE1)]
        public static explicit operator Mono.Simd.Vector4ui (Mono.Simd.Vector16sb v) { throw null; }
        [Mono.Simd.AccelerationAttribute(Mono.Simd.AccelMode.SSE1)]
        public static explicit operator Mono.Simd.Vector8s (Mono.Simd.Vector16sb v) { throw null; }
        [Mono.Simd.AccelerationAttribute(Mono.Simd.AccelMode.SSE1)]
        public static explicit operator Mono.Simd.Vector8us (Mono.Simd.Vector16sb v) { throw null; }
        [Mono.Simd.AccelerationAttribute(Mono.Simd.AccelMode.SSE2)]
        public static bool operator !=(Mono.Simd.Vector16sb va, Mono.Simd.Vector16sb vb) { throw null; }
        [Mono.Simd.AccelerationAttribute(Mono.Simd.AccelMode.SSE2)]
        public static Mono.Simd.Vector16sb operator -(Mono.Simd.Vector16sb va, Mono.Simd.Vector16sb vb) { throw null; }
        [Mono.Simd.AccelerationAttribute(Mono.Simd.AccelMode.SSE1)]
        [System.CLSCompliantAttribute(false)]
        public unsafe static void PrefetchNonTemporal(Mono.Simd.Vector16sb* res) { }
        [Mono.Simd.AccelerationAttribute(Mono.Simd.AccelMode.SSE1)]
        [System.CLSCompliantAttribute(false)]
        public static void PrefetchNonTemporal(ref Mono.Simd.Vector16sb res) { }
        [Mono.Simd.AccelerationAttribute(Mono.Simd.AccelMode.SSE1)]
        [System.CLSCompliantAttribute(false)]
        public unsafe static void PrefetchTemporal1stLevelCache(Mono.Simd.Vector16sb* res) { }
        [Mono.Simd.AccelerationAttribute(Mono.Simd.AccelMode.SSE1)]
        [System.CLSCompliantAttribute(false)]
        public static void PrefetchTemporal1stLevelCache(ref Mono.Simd.Vector16sb res) { }
        [Mono.Simd.AccelerationAttribute(Mono.Simd.AccelMode.SSE1)]
        [System.CLSCompliantAttribute(false)]
        public unsafe static void PrefetchTemporal2ndLevelCache(Mono.Simd.Vector16sb* res) { }
        [Mono.Simd.AccelerationAttribute(Mono.Simd.AccelMode.SSE1)]
        [System.CLSCompliantAttribute(false)]
        public static void PrefetchTemporal2ndLevelCache(ref Mono.Simd.Vector16sb res) { }
        [Mono.Simd.AccelerationAttribute(Mono.Simd.AccelMode.SSE1)]
        [System.CLSCompliantAttribute(false)]
        public unsafe static void PrefetchTemporalAllCacheLevels(Mono.Simd.Vector16sb* res) { }
        [Mono.Simd.AccelerationAttribute(Mono.Simd.AccelMode.SSE1)]
        [System.CLSCompliantAttribute(false)]
        public static void PrefetchTemporalAllCacheLevels(ref Mono.Simd.Vector16sb res) { }
        [Mono.Simd.AccelerationAttribute(Mono.Simd.AccelMode.SSE1)]
        public unsafe static void StoreAligned(Mono.Simd.Vector16sb* res, Mono.Simd.Vector16sb val) { }
        [Mono.Simd.AccelerationAttribute(Mono.Simd.AccelMode.SSE1)]
        public static void StoreAligned(ref Mono.Simd.Vector16sb res, Mono.Simd.Vector16sb val) { }
        public override string ToString() { throw null; }
    }
    [System.ObsoleteAttribute("Use the types in the System.Numerics.Vectors namespace")]
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Explicit, Size=16)]
    public partial struct Vector2d
    {
        [System.Runtime.InteropServices.FieldOffsetAttribute(0)]
        private int _dummyPrimitive;
        public Vector2d(double d) { throw null; }
        public Vector2d(double x, double y) { throw null; }
        [System.Runtime.CompilerServices.IndexerName("Component")]
        public double this[int index] { get { throw null; } set { } }
        public static Mono.Simd.Vector2d E { get { throw null; } }
        public static Mono.Simd.Vector2d MinusOne { get { throw null; } }
        public static Mono.Simd.Vector2d One { get { throw null; } }
        public static Mono.Simd.Vector2d Pi { get { throw null; } }
        public double X { get { throw null; } set { } }
        public double Y { get { throw null; } set { } }
        public static Mono.Simd.Vector2d Zero { get { throw null; } }
        [Mono.Simd.AccelerationAttribute(Mono.Simd.AccelMode.SSE1)]
        [System.CLSCompliantAttribute(false)]
        public unsafe static Mono.Simd.Vector2d LoadAligned(Mono.Simd.Vector2d* v) { throw null; }
        [Mono.Simd.AccelerationAttribute(Mono.Simd.AccelMode.SSE1)]
        public static Mono.Simd.Vector2d LoadAligned(ref Mono.Simd.Vector2d v) { throw null; }
        [Mono.Simd.AccelerationAttribute(Mono.Simd.AccelMode.SSE2)]
        public static Mono.Simd.Vector2d operator +(Mono.Simd.Vector2d v1, Mono.Simd.Vector2d v2) { throw null; }
        [Mono.Simd.AccelerationAttribute(Mono.Simd.AccelMode.SSE2)]
        public static Mono.Simd.Vector2d operator &(Mono.Simd.Vector2d v1, Mono.Simd.Vector2d v2) { throw null; }
        [Mono.Simd.AccelerationAttribute(Mono.Simd.AccelMode.SSE2)]
        public static Mono.Simd.Vector2d operator |(Mono.Simd.Vector2d v1, Mono.Simd.Vector2d v2) { throw null; }
        [Mono.Simd.AccelerationAttribute(Mono.Simd.AccelMode.SSE2)]
        public static Mono.Simd.Vector2d operator /(Mono.Simd.Vector2d v1, Mono.Simd.Vector2d v2) { throw null; }
        [Mono.Simd.AccelerationAttribute(Mono.Simd.AccelMode.SSE2)]
        public static Mono.Simd.Vector2d operator ^(Mono.Simd.Vector2d v1, Mono.Simd.Vector2d v2) { throw null; }
        [Mono.Simd.AccelerationAttribute(Mono.Simd.AccelMode.SSE1)]
        public static explicit operator Mono.Simd.Vector16b (Mono.Simd.Vector2d v) { throw null; }
        [Mono.Simd.AccelerationAttribute(Mono.Simd.AccelMode.SSE1)]
        [System.CLSCompliantAttribute(false)]
        public static explicit operator Mono.Simd.Vector16sb (Mono.Simd.Vector2d v) { throw null; }
        [Mono.Simd.AccelerationAttribute(Mono.Simd.AccelMode.SSE1)]
        public static explicit operator Mono.Simd.Vector2l (Mono.Simd.Vector2d v) { throw null; }
        [Mono.Simd.AccelerationAttribute(Mono.Simd.AccelMode.SSE1)]
        [System.CLSCompliantAttribute(false)]
        public static explicit operator Mono.Simd.Vector2ul (Mono.Simd.Vector2d v) { throw null; }
        [Mono.Simd.AccelerationAttribute(Mono.Simd.AccelMode.SSE1)]
        public static explicit operator Mono.Simd.Vector4f (Mono.Simd.Vector2d v) { throw null; }
        [Mono.Simd.AccelerationAttribute(Mono.Simd.AccelMode.SSE1)]
        public static explicit operator Mono.Simd.Vector4i (Mono.Simd.Vector2d v) { throw null; }
        [Mono.Simd.AccelerationAttribute(Mono.Simd.AccelMode.SSE1)]
        [System.CLSCompliantAttribute(false)]
        public static explicit operator Mono.Simd.Vector4ui (Mono.Simd.Vector2d v) { throw null; }
        [Mono.Simd.AccelerationAttribute(Mono.Simd.AccelMode.SSE1)]
        public static explicit operator Mono.Simd.Vector8s (Mono.Simd.Vector2d v) { throw null; }
        [Mono.Simd.AccelerationAttribute(Mono.Simd.AccelMode.SSE1)]
        [System.CLSCompliantAttribute(false)]
        public static explicit operator Mono.Simd.Vector8us (Mono.Simd.Vector2d v) { throw null; }
        [Mono.Simd.AccelerationAttribute(Mono.Simd.AccelMode.SSE2)]
        public static Mono.Simd.Vector2d operator *(Mono.Simd.Vector2d v1, Mono.Simd.Vector2d v2) { throw null; }
        [Mono.Simd.AccelerationAttribute(Mono.Simd.AccelMode.SSE2)]
        public static Mono.Simd.Vector2d operator -(Mono.Simd.Vector2d v1, Mono.Simd.Vector2d v2) { throw null; }
        [Mono.Simd.AccelerationAttribute(Mono.Simd.AccelMode.SSE1)]
        [System.CLSCompliantAttribute(false)]
        public unsafe static void PrefetchNonTemporal(Mono.Simd.Vector2d* res) { }
        [Mono.Simd.AccelerationAttribute(Mono.Simd.AccelMode.SSE1)]
        [System.CLSCompliantAttribute(false)]
        public static void PrefetchNonTemporal(ref Mono.Simd.Vector2d res) { }
        [Mono.Simd.AccelerationAttribute(Mono.Simd.AccelMode.SSE1)]
        [System.CLSCompliantAttribute(false)]
        public unsafe static void PrefetchTemporal1stLevelCache(Mono.Simd.Vector2d* res) { }
        [Mono.Simd.AccelerationAttribute(Mono.Simd.AccelMode.SSE1)]
        [System.CLSCompliantAttribute(false)]
        public static void PrefetchTemporal1stLevelCache(ref Mono.Simd.Vector2d res) { }
        [Mono.Simd.AccelerationAttribute(Mono.Simd.AccelMode.SSE1)]
        [System.CLSCompliantAttribute(false)]
        public unsafe static void PrefetchTemporal2ndLevelCache(Mono.Simd.Vector2d* res) { }
        [Mono.Simd.AccelerationAttribute(Mono.Simd.AccelMode.SSE1)]
        [System.CLSCompliantAttribute(false)]
        public static void PrefetchTemporal2ndLevelCache(ref Mono.Simd.Vector2d res) { }
        [Mono.Simd.AccelerationAttribute(Mono.Simd.AccelMode.SSE1)]
        [System.CLSCompliantAttribute(false)]
        public unsafe static void PrefetchTemporalAllCacheLevels(Mono.Simd.Vector2d* res) { }
        [Mono.Simd.AccelerationAttribute(Mono.Simd.AccelMode.SSE1)]
        [System.CLSCompliantAttribute(false)]
        public static void PrefetchTemporalAllCacheLevels(ref Mono.Simd.Vector2d res) { }
        [Mono.Simd.AccelerationAttribute(Mono.Simd.AccelMode.SSE1)]
        [System.CLSCompliantAttribute(false)]
        public unsafe static void StoreAligned(Mono.Simd.Vector2d* res, Mono.Simd.Vector2d val) { }
        [Mono.Simd.AccelerationAttribute(Mono.Simd.AccelMode.SSE1)]
        public static void StoreAligned(ref Mono.Simd.Vector2d res, Mono.Simd.Vector2d val) { }
        public override string ToString() { throw null; }
    }
    [System.ObsoleteAttribute("Use the types in the System.Numerics.Vectors namespace")]
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Explicit, Size=16)]
    public partial struct Vector2l
    {
        [System.Runtime.InteropServices.FieldOffsetAttribute(0)]
        private int _dummyPrimitive;
        public Vector2l(long l) { throw null; }
        public Vector2l(long x, long y) { throw null; }
        [System.Runtime.CompilerServices.IndexerName("Component")]
        public long this[int index] { get { throw null; } set { } }
        public static Mono.Simd.Vector2l MinusOne { get { throw null; } }
        public static Mono.Simd.Vector2l One { get { throw null; } }
        public long X { get { throw null; } set { } }
        public long Y { get { throw null; } set { } }
        public static Mono.Simd.Vector2l Zero { get { throw null; } }
        [Mono.Simd.AccelerationAttribute(Mono.Simd.AccelMode.SSE1)]
        [System.CLSCompliantAttribute(false)]
        public unsafe static Mono.Simd.Vector2l LoadAligned(Mono.Simd.Vector2l* v) { throw null; }
        [Mono.Simd.AccelerationAttribute(Mono.Simd.AccelMode.SSE1)]
        public static Mono.Simd.Vector2l LoadAligned(ref Mono.Simd.Vector2l v) { throw null; }
        [Mono.Simd.AccelerationAttribute(Mono.Simd.AccelMode.SSE2)]
        public static Mono.Simd.Vector2l operator +(Mono.Simd.Vector2l v1, Mono.Simd.Vector2l v2) { throw null; }
        [Mono.Simd.AccelerationAttribute(Mono.Simd.AccelMode.SSE2)]
        public static Mono.Simd.Vector2l operator &(Mono.Simd.Vector2l v1, Mono.Simd.Vector2l v2) { throw null; }
        [Mono.Simd.AccelerationAttribute(Mono.Simd.AccelMode.SSE2)]
        public static Mono.Simd.Vector2l operator |(Mono.Simd.Vector2l v1, Mono.Simd.Vector2l v2) { throw null; }
        [Mono.Simd.AccelerationAttribute(Mono.Simd.AccelMode.SSE2)]
        public static Mono.Simd.Vector2l operator ^(Mono.Simd.Vector2l v1, Mono.Simd.Vector2l v2) { throw null; }
        [Mono.Simd.AccelerationAttribute(Mono.Simd.AccelMode.SSE1)]
        public static explicit operator Mono.Simd.Vector16b (Mono.Simd.Vector2l v) { throw null; }
        [Mono.Simd.AccelerationAttribute(Mono.Simd.AccelMode.SSE1)]
        [System.CLSCompliantAttribute(false)]
        public static explicit operator Mono.Simd.Vector16sb (Mono.Simd.Vector2l v) { throw null; }
        [Mono.Simd.AccelerationAttribute(Mono.Simd.AccelMode.SSE1)]
        public static explicit operator Mono.Simd.Vector2d (Mono.Simd.Vector2l v) { throw null; }
        [Mono.Simd.AccelerationAttribute(Mono.Simd.AccelMode.SSE1)]
        [System.CLSCompliantAttribute(false)]
        public static explicit operator Mono.Simd.Vector2ul (Mono.Simd.Vector2l v) { throw null; }
        [Mono.Simd.AccelerationAttribute(Mono.Simd.AccelMode.SSE1)]
        public static explicit operator Mono.Simd.Vector4f (Mono.Simd.Vector2l v) { throw null; }
        [Mono.Simd.AccelerationAttribute(Mono.Simd.AccelMode.SSE1)]
        public static explicit operator Mono.Simd.Vector4i (Mono.Simd.Vector2l v) { throw null; }
        [Mono.Simd.AccelerationAttribute(Mono.Simd.AccelMode.SSE1)]
        [System.CLSCompliantAttribute(false)]
        public static explicit operator Mono.Simd.Vector4ui (Mono.Simd.Vector2l v) { throw null; }
        [Mono.Simd.AccelerationAttribute(Mono.Simd.AccelMode.SSE1)]
        public static explicit operator Mono.Simd.Vector8s (Mono.Simd.Vector2l v) { throw null; }
        [Mono.Simd.AccelerationAttribute(Mono.Simd.AccelMode.SSE1)]
        [System.CLSCompliantAttribute(false)]
        public static explicit operator Mono.Simd.Vector8us (Mono.Simd.Vector2l v) { throw null; }
        [Mono.Simd.AccelerationAttribute(Mono.Simd.AccelMode.SSE2)]
        public static Mono.Simd.Vector2l operator <<(Mono.Simd.Vector2l v1, int amount) { throw null; }
        [Mono.Simd.AccelerationAttribute(Mono.Simd.AccelMode.SSE2)]
        public static Mono.Simd.Vector2l operator -(Mono.Simd.Vector2l v1, Mono.Simd.Vector2l v2) { throw null; }
        [Mono.Simd.AccelerationAttribute(Mono.Simd.AccelMode.SSE1)]
        [System.CLSCompliantAttribute(false)]
        public unsafe static void PrefetchNonTemporal(Mono.Simd.Vector2l* res) { }
        [Mono.Simd.AccelerationAttribute(Mono.Simd.AccelMode.SSE1)]
        [System.CLSCompliantAttribute(false)]
        public static void PrefetchNonTemporal(ref Mono.Simd.Vector2l res) { }
        [Mono.Simd.AccelerationAttribute(Mono.Simd.AccelMode.SSE1)]
        [System.CLSCompliantAttribute(false)]
        public unsafe static void PrefetchTemporal1stLevelCache(Mono.Simd.Vector2l* res) { }
        [Mono.Simd.AccelerationAttribute(Mono.Simd.AccelMode.SSE1)]
        [System.CLSCompliantAttribute(false)]
        public static void PrefetchTemporal1stLevelCache(ref Mono.Simd.Vector2l res) { }
        [Mono.Simd.AccelerationAttribute(Mono.Simd.AccelMode.SSE1)]
        [System.CLSCompliantAttribute(false)]
        public unsafe static void PrefetchTemporal2ndLevelCache(Mono.Simd.Vector2l* res) { }
        [Mono.Simd.AccelerationAttribute(Mono.Simd.AccelMode.SSE1)]
        [System.CLSCompliantAttribute(false)]
        public static void PrefetchTemporal2ndLevelCache(ref Mono.Simd.Vector2l res) { }
        [Mono.Simd.AccelerationAttribute(Mono.Simd.AccelMode.SSE1)]
        [System.CLSCompliantAttribute(false)]
        public unsafe static void PrefetchTemporalAllCacheLevels(Mono.Simd.Vector2l* res) { }
        [Mono.Simd.AccelerationAttribute(Mono.Simd.AccelMode.SSE1)]
        [System.CLSCompliantAttribute(false)]
        public static void PrefetchTemporalAllCacheLevels(ref Mono.Simd.Vector2l res) { }
        [Mono.Simd.AccelerationAttribute(Mono.Simd.AccelMode.SSE1)]
        [System.CLSCompliantAttribute(false)]
        public unsafe static void StoreAligned(Mono.Simd.Vector2l* res, Mono.Simd.Vector2l val) { }
        [Mono.Simd.AccelerationAttribute(Mono.Simd.AccelMode.SSE1)]
        public static void StoreAligned(ref Mono.Simd.Vector2l res, Mono.Simd.Vector2l val) { }
        public override string ToString() { throw null; }
    }
    [System.CLSCompliantAttribute(false)]
    [System.ObsoleteAttribute("Use the types in the System.Numerics.Vectors namespace")]
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Explicit, Size=16)]
    public partial struct Vector2ul
    {
        [System.Runtime.InteropServices.FieldOffsetAttribute(0)]
        private int _dummyPrimitive;
        public Vector2ul(ulong ul) { throw null; }
        public Vector2ul(ulong x, ulong y) { throw null; }
        [System.Runtime.CompilerServices.IndexerName("Component")]
        public ulong this[int index] { get { throw null; } set { } }
        public static Mono.Simd.Vector2ul One { get { throw null; } }
        public ulong X { get { throw null; } set { } }
        public ulong Y { get { throw null; } set { } }
        public static Mono.Simd.Vector2ul Zero { get { throw null; } }
        [Mono.Simd.AccelerationAttribute(Mono.Simd.AccelMode.SSE1)]
        public unsafe static Mono.Simd.Vector2ul LoadAligned(Mono.Simd.Vector2ul* v) { throw null; }
        [Mono.Simd.AccelerationAttribute(Mono.Simd.AccelMode.SSE1)]
        public static Mono.Simd.Vector2ul LoadAligned(ref Mono.Simd.Vector2ul v) { throw null; }
        [Mono.Simd.AccelerationAttribute(Mono.Simd.AccelMode.SSE2)]
        public static Mono.Simd.Vector2ul operator +(Mono.Simd.Vector2ul v1, Mono.Simd.Vector2ul v2) { throw null; }
        [Mono.Simd.AccelerationAttribute(Mono.Simd.AccelMode.SSE2)]
        public static Mono.Simd.Vector2ul operator &(Mono.Simd.Vector2ul v1, Mono.Simd.Vector2ul v2) { throw null; }
        [Mono.Simd.AccelerationAttribute(Mono.Simd.AccelMode.SSE2)]
        public static Mono.Simd.Vector2ul operator |(Mono.Simd.Vector2ul v1, Mono.Simd.Vector2ul v2) { throw null; }
        [Mono.Simd.AccelerationAttribute(Mono.Simd.AccelMode.SSE2)]
        public static Mono.Simd.Vector2ul operator ^(Mono.Simd.Vector2ul v1, Mono.Simd.Vector2ul v2) { throw null; }
        [Mono.Simd.AccelerationAttribute(Mono.Simd.AccelMode.SSE1)]
        public static explicit operator Mono.Simd.Vector16b (Mono.Simd.Vector2ul v) { throw null; }
        [Mono.Simd.AccelerationAttribute(Mono.Simd.AccelMode.SSE1)]
        public static explicit operator Mono.Simd.Vector16sb (Mono.Simd.Vector2ul v) { throw null; }
        [Mono.Simd.AccelerationAttribute(Mono.Simd.AccelMode.SSE1)]
        public static explicit operator Mono.Simd.Vector2d (Mono.Simd.Vector2ul v) { throw null; }
        [Mono.Simd.AccelerationAttribute(Mono.Simd.AccelMode.SSE1)]
        public static explicit operator Mono.Simd.Vector2l (Mono.Simd.Vector2ul v) { throw null; }
        [Mono.Simd.AccelerationAttribute(Mono.Simd.AccelMode.SSE1)]
        public static explicit operator Mono.Simd.Vector4f (Mono.Simd.Vector2ul v) { throw null; }
        [Mono.Simd.AccelerationAttribute(Mono.Simd.AccelMode.SSE1)]
        public static explicit operator Mono.Simd.Vector4i (Mono.Simd.Vector2ul v) { throw null; }
        [Mono.Simd.AccelerationAttribute(Mono.Simd.AccelMode.SSE1)]
        public static explicit operator Mono.Simd.Vector4ui (Mono.Simd.Vector2ul v) { throw null; }
        [Mono.Simd.AccelerationAttribute(Mono.Simd.AccelMode.SSE1)]
        public static explicit operator Mono.Simd.Vector8s (Mono.Simd.Vector2ul v) { throw null; }
        [Mono.Simd.AccelerationAttribute(Mono.Simd.AccelMode.SSE1)]
        public static explicit operator Mono.Simd.Vector8us (Mono.Simd.Vector2ul v) { throw null; }
        [Mono.Simd.AccelerationAttribute(Mono.Simd.AccelMode.SSE2)]
        public static Mono.Simd.Vector2ul operator <<(Mono.Simd.Vector2ul v1, int amount) { throw null; }
        [Mono.Simd.AccelerationAttribute(Mono.Simd.AccelMode.SSE2)]
        public static Mono.Simd.Vector2ul operator >>(Mono.Simd.Vector2ul v1, int amount) { throw null; }
        [Mono.Simd.AccelerationAttribute(Mono.Simd.AccelMode.SSE2)]
        public static Mono.Simd.Vector2ul operator -(Mono.Simd.Vector2ul v1, Mono.Simd.Vector2ul v2) { throw null; }
        [Mono.Simd.AccelerationAttribute(Mono.Simd.AccelMode.SSE1)]
        [System.CLSCompliantAttribute(false)]
        public unsafe static void PrefetchNonTemporal(Mono.Simd.Vector2ul* res) { }
        [Mono.Simd.AccelerationAttribute(Mono.Simd.AccelMode.SSE1)]
        [System.CLSCompliantAttribute(false)]
        public static void PrefetchNonTemporal(ref Mono.Simd.Vector2ul res) { }
        [Mono.Simd.AccelerationAttribute(Mono.Simd.AccelMode.SSE1)]
        [System.CLSCompliantAttribute(false)]
        public unsafe static void PrefetchTemporal1stLevelCache(Mono.Simd.Vector2ul* res) { }
        [Mono.Simd.AccelerationAttribute(Mono.Simd.AccelMode.SSE1)]
        [System.CLSCompliantAttribute(false)]
        public static void PrefetchTemporal1stLevelCache(ref Mono.Simd.Vector2ul res) { }
        [Mono.Simd.AccelerationAttribute(Mono.Simd.AccelMode.SSE1)]
        [System.CLSCompliantAttribute(false)]
        public unsafe static void PrefetchTemporal2ndLevelCache(Mono.Simd.Vector2ul* res) { }
        [Mono.Simd.AccelerationAttribute(Mono.Simd.AccelMode.SSE1)]
        [System.CLSCompliantAttribute(false)]
        public static void PrefetchTemporal2ndLevelCache(ref Mono.Simd.Vector2ul res) { }
        [Mono.Simd.AccelerationAttribute(Mono.Simd.AccelMode.SSE1)]
        [System.CLSCompliantAttribute(false)]
        public unsafe static void PrefetchTemporalAllCacheLevels(Mono.Simd.Vector2ul* res) { }
        [Mono.Simd.AccelerationAttribute(Mono.Simd.AccelMode.SSE1)]
        [System.CLSCompliantAttribute(false)]
        public static void PrefetchTemporalAllCacheLevels(ref Mono.Simd.Vector2ul res) { }
        [Mono.Simd.AccelerationAttribute(Mono.Simd.AccelMode.SSE1)]
        public unsafe static void StoreAligned(Mono.Simd.Vector2ul* res, Mono.Simd.Vector2ul val) { }
        [Mono.Simd.AccelerationAttribute(Mono.Simd.AccelMode.SSE1)]
        public static void StoreAligned(ref Mono.Simd.Vector2ul res, Mono.Simd.Vector2ul val) { }
        public override string ToString() { throw null; }
    }
    [System.ObsoleteAttribute("Use the types in the System.Numerics.Vectors namespace")]
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Explicit, Size=16)]
    public partial struct Vector4f
    {
        [System.Runtime.InteropServices.FieldOffsetAttribute(0)]
        private int _dummyPrimitive;
        public Vector4f(float f) { throw null; }
        public Vector4f(float x, float y, float z, float w) { throw null; }
        [System.Runtime.CompilerServices.IndexerName("Component")]
        public float this[int index] { get { throw null; } set { } }
        public static Mono.Simd.Vector4f E { get { throw null; } }
        public static Mono.Simd.Vector4f MinusOne { get { throw null; } }
        public static Mono.Simd.Vector4f One { get { throw null; } }
        public static Mono.Simd.Vector4f Pi { get { throw null; } }
        public float W { get { throw null; } set { } }
        public float X { get { throw null; } set { } }
        public float Y { get { throw null; } set { } }
        public float Z { get { throw null; } set { } }
        public static Mono.Simd.Vector4f Zero { get { throw null; } }
        [Mono.Simd.AccelerationAttribute(Mono.Simd.AccelMode.SSE1)]
        [System.CLSCompliantAttribute(false)]
        public unsafe static Mono.Simd.Vector4f LoadAligned(Mono.Simd.Vector4f* v) { throw null; }
        [Mono.Simd.AccelerationAttribute(Mono.Simd.AccelMode.SSE1)]
        public static Mono.Simd.Vector4f LoadAligned(ref Mono.Simd.Vector4f v) { throw null; }
        [Mono.Simd.AccelerationAttribute(Mono.Simd.AccelMode.SSE1)]
        public static Mono.Simd.Vector4f operator +(Mono.Simd.Vector4f v1, Mono.Simd.Vector4f v2) { throw null; }
        [Mono.Simd.AccelerationAttribute(Mono.Simd.AccelMode.SSE1)]
        public static Mono.Simd.Vector4f operator &(Mono.Simd.Vector4f v1, Mono.Simd.Vector4f v2) { throw null; }
        [Mono.Simd.AccelerationAttribute(Mono.Simd.AccelMode.SSE1)]
        public static Mono.Simd.Vector4f operator |(Mono.Simd.Vector4f v1, Mono.Simd.Vector4f v2) { throw null; }
        [Mono.Simd.AccelerationAttribute(Mono.Simd.AccelMode.SSE1)]
        public static Mono.Simd.Vector4f operator /(Mono.Simd.Vector4f v1, Mono.Simd.Vector4f v2) { throw null; }
        [Mono.Simd.AccelerationAttribute(Mono.Simd.AccelMode.SSE2)]
        public static bool operator ==(Mono.Simd.Vector4f v1, Mono.Simd.Vector4f v2) { throw null; }
        [Mono.Simd.AccelerationAttribute(Mono.Simd.AccelMode.SSE1)]
        public static Mono.Simd.Vector4f operator ^(Mono.Simd.Vector4f v1, Mono.Simd.Vector4f v2) { throw null; }
        [Mono.Simd.AccelerationAttribute(Mono.Simd.AccelMode.SSE1)]
        public static explicit operator Mono.Simd.Vector16b (Mono.Simd.Vector4f v) { throw null; }
        [Mono.Simd.AccelerationAttribute(Mono.Simd.AccelMode.SSE1)]
        [System.CLSCompliantAttribute(false)]
        public static explicit operator Mono.Simd.Vector16sb (Mono.Simd.Vector4f v) { throw null; }
        [Mono.Simd.AccelerationAttribute(Mono.Simd.AccelMode.SSE1)]
        public static explicit operator Mono.Simd.Vector2d (Mono.Simd.Vector4f v) { throw null; }
        [Mono.Simd.AccelerationAttribute(Mono.Simd.AccelMode.SSE1)]
        public static explicit operator Mono.Simd.Vector2l (Mono.Simd.Vector4f v) { throw null; }
        [Mono.Simd.AccelerationAttribute(Mono.Simd.AccelMode.SSE1)]
        [System.CLSCompliantAttribute(false)]
        public static explicit operator Mono.Simd.Vector2ul (Mono.Simd.Vector4f v) { throw null; }
        [Mono.Simd.AccelerationAttribute(Mono.Simd.AccelMode.SSE1)]
        public static explicit operator Mono.Simd.Vector4i (Mono.Simd.Vector4f v) { throw null; }
        [Mono.Simd.AccelerationAttribute(Mono.Simd.AccelMode.SSE1)]
        [System.CLSCompliantAttribute(false)]
        public static explicit operator Mono.Simd.Vector4ui (Mono.Simd.Vector4f v) { throw null; }
        [Mono.Simd.AccelerationAttribute(Mono.Simd.AccelMode.SSE1)]
        public static explicit operator Mono.Simd.Vector8s (Mono.Simd.Vector4f v) { throw null; }
        [Mono.Simd.AccelerationAttribute(Mono.Simd.AccelMode.SSE1)]
        [System.CLSCompliantAttribute(false)]
        public static explicit operator Mono.Simd.Vector8us (Mono.Simd.Vector4f v) { throw null; }
        [Mono.Simd.AccelerationAttribute(Mono.Simd.AccelMode.SSE2)]
        public static bool operator !=(Mono.Simd.Vector4f v1, Mono.Simd.Vector4f v2) { throw null; }
        [Mono.Simd.AccelerationAttribute(Mono.Simd.AccelMode.SSE1)]
        public static Mono.Simd.Vector4f operator *(Mono.Simd.Vector4f v1, Mono.Simd.Vector4f v2) { throw null; }
        [Mono.Simd.AccelerationAttribute(Mono.Simd.AccelMode.SSE1)]
        public static Mono.Simd.Vector4f operator *(Mono.Simd.Vector4f v, float scalar) { throw null; }
        [Mono.Simd.AccelerationAttribute(Mono.Simd.AccelMode.SSE1)]
        public static Mono.Simd.Vector4f operator *(float scalar, Mono.Simd.Vector4f v) { throw null; }
        [Mono.Simd.AccelerationAttribute(Mono.Simd.AccelMode.SSE1)]
        public static Mono.Simd.Vector4f operator -(Mono.Simd.Vector4f v1, Mono.Simd.Vector4f v2) { throw null; }
        [Mono.Simd.AccelerationAttribute(Mono.Simd.AccelMode.SSE1)]
        [System.CLSCompliantAttribute(false)]
        public unsafe static void PrefetchNonTemporal(Mono.Simd.Vector4f* res) { }
        [Mono.Simd.AccelerationAttribute(Mono.Simd.AccelMode.SSE1)]
        [System.CLSCompliantAttribute(false)]
        public static void PrefetchNonTemporal(ref Mono.Simd.Vector4f res) { }
        [Mono.Simd.AccelerationAttribute(Mono.Simd.AccelMode.SSE1)]
        [System.CLSCompliantAttribute(false)]
        public unsafe static void PrefetchTemporal1stLevelCache(Mono.Simd.Vector4f* res) { }
        [Mono.Simd.AccelerationAttribute(Mono.Simd.AccelMode.SSE1)]
        [System.CLSCompliantAttribute(false)]
        public static void PrefetchTemporal1stLevelCache(ref Mono.Simd.Vector4f res) { }
        [Mono.Simd.AccelerationAttribute(Mono.Simd.AccelMode.SSE1)]
        [System.CLSCompliantAttribute(false)]
        public unsafe static void PrefetchTemporal2ndLevelCache(Mono.Simd.Vector4f* res) { }
        [Mono.Simd.AccelerationAttribute(Mono.Simd.AccelMode.SSE1)]
        [System.CLSCompliantAttribute(false)]
        public static void PrefetchTemporal2ndLevelCache(ref Mono.Simd.Vector4f res) { }
        [Mono.Simd.AccelerationAttribute(Mono.Simd.AccelMode.SSE1)]
        [System.CLSCompliantAttribute(false)]
        public unsafe static void PrefetchTemporalAllCacheLevels(Mono.Simd.Vector4f* res) { }
        [Mono.Simd.AccelerationAttribute(Mono.Simd.AccelMode.SSE1)]
        [System.CLSCompliantAttribute(false)]
        public static void PrefetchTemporalAllCacheLevels(ref Mono.Simd.Vector4f res) { }
        [Mono.Simd.AccelerationAttribute(Mono.Simd.AccelMode.SSE1)]
        [System.CLSCompliantAttribute(false)]
        public unsafe static void StoreAligned(Mono.Simd.Vector4f* res, Mono.Simd.Vector4f val) { }
        [Mono.Simd.AccelerationAttribute(Mono.Simd.AccelMode.SSE1)]
        public static void StoreAligned(ref Mono.Simd.Vector4f res, Mono.Simd.Vector4f val) { }
        public override string ToString() { throw null; }
    }
    [System.ObsoleteAttribute("Use the types in the System.Numerics.Vectors namespace")]
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Explicit, Size=16)]
    public partial struct Vector4i
    {
        [System.Runtime.InteropServices.FieldOffsetAttribute(0)]
        private int _dummyPrimitive;
        public Vector4i(int i) { throw null; }
        public Vector4i(int x, int y, int z, int w) { throw null; }
        [System.Runtime.CompilerServices.IndexerName("Component")]
        public int this[int index] { get { throw null; } set { } }
        public static Mono.Simd.Vector4i Identity { get { throw null; } }
        public static Mono.Simd.Vector4i MinusOne { get { throw null; } }
        public int W { get { throw null; } set { } }
        public int X { get { throw null; } set { } }
        public int Y { get { throw null; } set { } }
        public int Z { get { throw null; } set { } }
        public static Mono.Simd.Vector4i Zero { get { throw null; } }
        [Mono.Simd.AccelerationAttribute(Mono.Simd.AccelMode.SSE1)]
        [System.CLSCompliantAttribute(false)]
        public unsafe static Mono.Simd.Vector4i LoadAligned(Mono.Simd.Vector4i* v) { throw null; }
        [Mono.Simd.AccelerationAttribute(Mono.Simd.AccelMode.SSE1)]
        public static Mono.Simd.Vector4i LoadAligned(ref Mono.Simd.Vector4i v) { throw null; }
        [Mono.Simd.AccelerationAttribute(Mono.Simd.AccelMode.SSE2)]
        public static Mono.Simd.Vector4i operator +(Mono.Simd.Vector4i v1, Mono.Simd.Vector4i v2) { throw null; }
        [Mono.Simd.AccelerationAttribute(Mono.Simd.AccelMode.SSE2)]
        public static Mono.Simd.Vector4i operator &(Mono.Simd.Vector4i v1, Mono.Simd.Vector4i v2) { throw null; }
        [Mono.Simd.AccelerationAttribute(Mono.Simd.AccelMode.SSE2)]
        public static Mono.Simd.Vector4i operator |(Mono.Simd.Vector4i v1, Mono.Simd.Vector4i v2) { throw null; }
        [Mono.Simd.AccelerationAttribute(Mono.Simd.AccelMode.SSE2)]
        public static bool operator ==(Mono.Simd.Vector4i v1, Mono.Simd.Vector4i v2) { throw null; }
        [Mono.Simd.AccelerationAttribute(Mono.Simd.AccelMode.SSE2)]
        public static Mono.Simd.Vector4i operator ^(Mono.Simd.Vector4i v1, Mono.Simd.Vector4i v2) { throw null; }
        [Mono.Simd.AccelerationAttribute(Mono.Simd.AccelMode.SSE1)]
        public static explicit operator Mono.Simd.Vector16b (Mono.Simd.Vector4i v) { throw null; }
        [Mono.Simd.AccelerationAttribute(Mono.Simd.AccelMode.SSE1)]
        [System.CLSCompliantAttribute(false)]
        public static explicit operator Mono.Simd.Vector16sb (Mono.Simd.Vector4i v) { throw null; }
        [Mono.Simd.AccelerationAttribute(Mono.Simd.AccelMode.SSE1)]
        public static explicit operator Mono.Simd.Vector2d (Mono.Simd.Vector4i v) { throw null; }
        [Mono.Simd.AccelerationAttribute(Mono.Simd.AccelMode.SSE1)]
        public static explicit operator Mono.Simd.Vector2l (Mono.Simd.Vector4i v) { throw null; }
        [Mono.Simd.AccelerationAttribute(Mono.Simd.AccelMode.SSE1)]
        [System.CLSCompliantAttribute(false)]
        public static explicit operator Mono.Simd.Vector2ul (Mono.Simd.Vector4i v) { throw null; }
        [Mono.Simd.AccelerationAttribute(Mono.Simd.AccelMode.SSE1)]
        public static explicit operator Mono.Simd.Vector4f (Mono.Simd.Vector4i v) { throw null; }
        [Mono.Simd.AccelerationAttribute(Mono.Simd.AccelMode.SSE1)]
        [System.CLSCompliantAttribute(false)]
        public static explicit operator Mono.Simd.Vector4ui (Mono.Simd.Vector4i v) { throw null; }
        [Mono.Simd.AccelerationAttribute(Mono.Simd.AccelMode.SSE1)]
        public static explicit operator Mono.Simd.Vector8s (Mono.Simd.Vector4i v) { throw null; }
        [Mono.Simd.AccelerationAttribute(Mono.Simd.AccelMode.SSE1)]
        [System.CLSCompliantAttribute(false)]
        public static explicit operator Mono.Simd.Vector8us (Mono.Simd.Vector4i v) { throw null; }
        [Mono.Simd.AccelerationAttribute(Mono.Simd.AccelMode.SSE2)]
        public static bool operator !=(Mono.Simd.Vector4i v1, Mono.Simd.Vector4i v2) { throw null; }
        [Mono.Simd.AccelerationAttribute(Mono.Simd.AccelMode.SSE2)]
        public static Mono.Simd.Vector4i operator <<(Mono.Simd.Vector4i v1, int amount) { throw null; }
        [Mono.Simd.AccelerationAttribute(Mono.Simd.AccelMode.SSE41)]
        public static Mono.Simd.Vector4i operator *(Mono.Simd.Vector4i v1, Mono.Simd.Vector4i v2) { throw null; }
        [Mono.Simd.AccelerationAttribute(Mono.Simd.AccelMode.SSE2)]
        public static Mono.Simd.Vector4i operator >>(Mono.Simd.Vector4i v1, int amount) { throw null; }
        [Mono.Simd.AccelerationAttribute(Mono.Simd.AccelMode.SSE2)]
        public static Mono.Simd.Vector4i operator -(Mono.Simd.Vector4i v1, Mono.Simd.Vector4i v2) { throw null; }
        [Mono.Simd.AccelerationAttribute(Mono.Simd.AccelMode.SSE1)]
        [System.CLSCompliantAttribute(false)]
        public unsafe static void PrefetchNonTemporal(Mono.Simd.Vector4i* res) { }
        [Mono.Simd.AccelerationAttribute(Mono.Simd.AccelMode.SSE1)]
        [System.CLSCompliantAttribute(false)]
        public static void PrefetchNonTemporal(ref Mono.Simd.Vector4i res) { }
        [Mono.Simd.AccelerationAttribute(Mono.Simd.AccelMode.SSE1)]
        [System.CLSCompliantAttribute(false)]
        public unsafe static void PrefetchTemporal1stLevelCache(Mono.Simd.Vector4i* res) { }
        [Mono.Simd.AccelerationAttribute(Mono.Simd.AccelMode.SSE1)]
        [System.CLSCompliantAttribute(false)]
        public static void PrefetchTemporal1stLevelCache(ref Mono.Simd.Vector4i res) { }
        [Mono.Simd.AccelerationAttribute(Mono.Simd.AccelMode.SSE1)]
        [System.CLSCompliantAttribute(false)]
        public unsafe static void PrefetchTemporal2ndLevelCache(Mono.Simd.Vector4i* res) { }
        [Mono.Simd.AccelerationAttribute(Mono.Simd.AccelMode.SSE1)]
        [System.CLSCompliantAttribute(false)]
        public static void PrefetchTemporal2ndLevelCache(ref Mono.Simd.Vector4i res) { }
        [Mono.Simd.AccelerationAttribute(Mono.Simd.AccelMode.SSE1)]
        [System.CLSCompliantAttribute(false)]
        public unsafe static void PrefetchTemporalAllCacheLevels(Mono.Simd.Vector4i* res) { }
        [Mono.Simd.AccelerationAttribute(Mono.Simd.AccelMode.SSE1)]
        [System.CLSCompliantAttribute(false)]
        public static void PrefetchTemporalAllCacheLevels(ref Mono.Simd.Vector4i res) { }
        [Mono.Simd.AccelerationAttribute(Mono.Simd.AccelMode.SSE1)]
        [System.CLSCompliantAttribute(false)]
        public unsafe static void StoreAligned(Mono.Simd.Vector4i* res, Mono.Simd.Vector4i val) { }
        [Mono.Simd.AccelerationAttribute(Mono.Simd.AccelMode.SSE1)]
        public static void StoreAligned(ref Mono.Simd.Vector4i res, Mono.Simd.Vector4i val) { }
        public override string ToString() { throw null; }
    }
    [System.CLSCompliantAttribute(false)]
    [System.ObsoleteAttribute("Use the types in the System.Numerics.Vectors namespace")]
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Explicit, Size=16)]
    public partial struct Vector4ui
    {
        [System.Runtime.InteropServices.FieldOffsetAttribute(0)]
        private int _dummyPrimitive;
        public Vector4ui(uint ui) { throw null; }
        public Vector4ui(uint x, uint y, uint z, uint w) { throw null; }
        [System.Runtime.CompilerServices.IndexerName("Component")]
        public uint this[int index] { get { throw null; } set { } }
        public static Mono.Simd.Vector4ui Identity { get { throw null; } }
        public uint W { get { throw null; } set { } }
        public uint X { get { throw null; } set { } }
        public uint Y { get { throw null; } set { } }
        public uint Z { get { throw null; } set { } }
        public static Mono.Simd.Vector4ui Zero { get { throw null; } }
        [Mono.Simd.AccelerationAttribute(Mono.Simd.AccelMode.SSE1)]
        public unsafe static Mono.Simd.Vector4ui LoadAligned(Mono.Simd.Vector4ui* v) { throw null; }
        [Mono.Simd.AccelerationAttribute(Mono.Simd.AccelMode.SSE1)]
        public static Mono.Simd.Vector4ui LoadAligned(ref Mono.Simd.Vector4ui v) { throw null; }
        [Mono.Simd.AccelerationAttribute(Mono.Simd.AccelMode.SSE2)]
        public static Mono.Simd.Vector4ui operator +(Mono.Simd.Vector4ui v1, Mono.Simd.Vector4ui v2) { throw null; }
        [Mono.Simd.AccelerationAttribute(Mono.Simd.AccelMode.SSE2)]
        public static Mono.Simd.Vector4ui operator &(Mono.Simd.Vector4ui v1, Mono.Simd.Vector4ui v2) { throw null; }
        [Mono.Simd.AccelerationAttribute(Mono.Simd.AccelMode.SSE2)]
        public static Mono.Simd.Vector4ui operator |(Mono.Simd.Vector4ui v1, Mono.Simd.Vector4ui v2) { throw null; }
        [Mono.Simd.AccelerationAttribute(Mono.Simd.AccelMode.SSE2)]
        public static bool operator ==(Mono.Simd.Vector4ui v1, Mono.Simd.Vector4ui v2) { throw null; }
        [Mono.Simd.AccelerationAttribute(Mono.Simd.AccelMode.SSE2)]
        public static Mono.Simd.Vector4ui operator ^(Mono.Simd.Vector4ui v1, Mono.Simd.Vector4ui v2) { throw null; }
        [Mono.Simd.AccelerationAttribute(Mono.Simd.AccelMode.SSE1)]
        public static explicit operator Mono.Simd.Vector16b (Mono.Simd.Vector4ui v) { throw null; }
        [Mono.Simd.AccelerationAttribute(Mono.Simd.AccelMode.SSE1)]
        public static explicit operator Mono.Simd.Vector16sb (Mono.Simd.Vector4ui v) { throw null; }
        [Mono.Simd.AccelerationAttribute(Mono.Simd.AccelMode.SSE1)]
        public static explicit operator Mono.Simd.Vector2d (Mono.Simd.Vector4ui v) { throw null; }
        [Mono.Simd.AccelerationAttribute(Mono.Simd.AccelMode.SSE1)]
        public static explicit operator Mono.Simd.Vector2l (Mono.Simd.Vector4ui v) { throw null; }
        [Mono.Simd.AccelerationAttribute(Mono.Simd.AccelMode.SSE1)]
        public static explicit operator Mono.Simd.Vector2ul (Mono.Simd.Vector4ui v) { throw null; }
        [Mono.Simd.AccelerationAttribute(Mono.Simd.AccelMode.SSE1)]
        public static explicit operator Mono.Simd.Vector4f (Mono.Simd.Vector4ui v) { throw null; }
        [Mono.Simd.AccelerationAttribute(Mono.Simd.AccelMode.SSE1)]
        public static explicit operator Mono.Simd.Vector4i (Mono.Simd.Vector4ui v) { throw null; }
        [Mono.Simd.AccelerationAttribute(Mono.Simd.AccelMode.SSE1)]
        public static explicit operator Mono.Simd.Vector8s (Mono.Simd.Vector4ui v) { throw null; }
        [Mono.Simd.AccelerationAttribute(Mono.Simd.AccelMode.SSE1)]
        public static explicit operator Mono.Simd.Vector8us (Mono.Simd.Vector4ui v) { throw null; }
        [Mono.Simd.AccelerationAttribute(Mono.Simd.AccelMode.SSE2)]
        public static bool operator !=(Mono.Simd.Vector4ui v1, Mono.Simd.Vector4ui v2) { throw null; }
        [Mono.Simd.AccelerationAttribute(Mono.Simd.AccelMode.SSE2)]
        public static Mono.Simd.Vector4ui operator <<(Mono.Simd.Vector4ui v1, int amount) { throw null; }
        [Mono.Simd.AccelerationAttribute(Mono.Simd.AccelMode.SSE41)]
        public static Mono.Simd.Vector4ui operator *(Mono.Simd.Vector4ui v1, Mono.Simd.Vector4ui v2) { throw null; }
        [Mono.Simd.AccelerationAttribute(Mono.Simd.AccelMode.SSE2)]
        public static Mono.Simd.Vector4ui operator >>(Mono.Simd.Vector4ui v1, int amount) { throw null; }
        [Mono.Simd.AccelerationAttribute(Mono.Simd.AccelMode.SSE2)]
        public static Mono.Simd.Vector4ui operator -(Mono.Simd.Vector4ui v1, Mono.Simd.Vector4ui v2) { throw null; }
        [Mono.Simd.AccelerationAttribute(Mono.Simd.AccelMode.SSE1)]
        [System.CLSCompliantAttribute(false)]
        public unsafe static void PrefetchNonTemporal(Mono.Simd.Vector4ui* res) { }
        [Mono.Simd.AccelerationAttribute(Mono.Simd.AccelMode.SSE1)]
        [System.CLSCompliantAttribute(false)]
        public static void PrefetchNonTemporal(ref Mono.Simd.Vector4ui res) { }
        [Mono.Simd.AccelerationAttribute(Mono.Simd.AccelMode.SSE1)]
        [System.CLSCompliantAttribute(false)]
        public unsafe static void PrefetchTemporal1stLevelCache(Mono.Simd.Vector4ui* res) { }
        [Mono.Simd.AccelerationAttribute(Mono.Simd.AccelMode.SSE1)]
        [System.CLSCompliantAttribute(false)]
        public static void PrefetchTemporal1stLevelCache(ref Mono.Simd.Vector4ui res) { }
        [Mono.Simd.AccelerationAttribute(Mono.Simd.AccelMode.SSE1)]
        [System.CLSCompliantAttribute(false)]
        public unsafe static void PrefetchTemporal2ndLevelCache(Mono.Simd.Vector4ui* res) { }
        [Mono.Simd.AccelerationAttribute(Mono.Simd.AccelMode.SSE1)]
        [System.CLSCompliantAttribute(false)]
        public static void PrefetchTemporal2ndLevelCache(ref Mono.Simd.Vector4ui res) { }
        [Mono.Simd.AccelerationAttribute(Mono.Simd.AccelMode.SSE1)]
        [System.CLSCompliantAttribute(false)]
        public unsafe static void PrefetchTemporalAllCacheLevels(Mono.Simd.Vector4ui* res) { }
        [Mono.Simd.AccelerationAttribute(Mono.Simd.AccelMode.SSE1)]
        [System.CLSCompliantAttribute(false)]
        public static void PrefetchTemporalAllCacheLevels(ref Mono.Simd.Vector4ui res) { }
        [Mono.Simd.AccelerationAttribute(Mono.Simd.AccelMode.SSE1)]
        public unsafe static void StoreAligned(Mono.Simd.Vector4ui* res, Mono.Simd.Vector4ui val) { }
        [Mono.Simd.AccelerationAttribute(Mono.Simd.AccelMode.SSE1)]
        public static void StoreAligned(ref Mono.Simd.Vector4ui res, Mono.Simd.Vector4ui val) { }
        public override string ToString() { throw null; }
    }
    [System.ObsoleteAttribute("Use the types in the System.Numerics.Vectors namespace")]
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Explicit, Size=16)]
    public partial struct Vector8s
    {
        [System.Runtime.InteropServices.FieldOffsetAttribute(0)]
        private int _dummyPrimitive;
        public Vector8s(short s) { throw null; }
        public Vector8s(short v0, short v1, short v2, short v3, short v4, short v5, short v6, short v7) { throw null; }
        [System.Runtime.CompilerServices.IndexerName("Component")]
        public short this[int index] { get { throw null; } set { } }
        public static Mono.Simd.Vector8s Identity { get { throw null; } }
        public static Mono.Simd.Vector8s MinusOne { get { throw null; } }
        public short V0 { get { throw null; } set { } }
        public short V1 { get { throw null; } set { } }
        public short V2 { get { throw null; } set { } }
        public short V3 { get { throw null; } set { } }
        public short V4 { get { throw null; } set { } }
        public short V5 { get { throw null; } set { } }
        public short V6 { get { throw null; } set { } }
        public short V7 { get { throw null; } set { } }
        public static Mono.Simd.Vector8s Zero { get { throw null; } }
        [Mono.Simd.AccelerationAttribute(Mono.Simd.AccelMode.SSE1)]
        [System.CLSCompliantAttribute(false)]
        public unsafe static Mono.Simd.Vector8s LoadAligned(Mono.Simd.Vector8s* v) { throw null; }
        [Mono.Simd.AccelerationAttribute(Mono.Simd.AccelMode.SSE1)]
        public static Mono.Simd.Vector8s LoadAligned(ref Mono.Simd.Vector8s v) { throw null; }
        [Mono.Simd.AccelerationAttribute(Mono.Simd.AccelMode.SSE2)]
        public static Mono.Simd.Vector8s operator +(Mono.Simd.Vector8s va, Mono.Simd.Vector8s vb) { throw null; }
        [Mono.Simd.AccelerationAttribute(Mono.Simd.AccelMode.SSE2)]
        public static Mono.Simd.Vector8s operator &(Mono.Simd.Vector8s va, Mono.Simd.Vector8s vb) { throw null; }
        [Mono.Simd.AccelerationAttribute(Mono.Simd.AccelMode.SSE2)]
        public static Mono.Simd.Vector8s operator |(Mono.Simd.Vector8s va, Mono.Simd.Vector8s vb) { throw null; }
        [Mono.Simd.AccelerationAttribute(Mono.Simd.AccelMode.SSE2)]
        public static bool operator ==(Mono.Simd.Vector8s va, Mono.Simd.Vector8s vb) { throw null; }
        [Mono.Simd.AccelerationAttribute(Mono.Simd.AccelMode.SSE2)]
        public static Mono.Simd.Vector8s operator ^(Mono.Simd.Vector8s va, Mono.Simd.Vector8s vb) { throw null; }
        [Mono.Simd.AccelerationAttribute(Mono.Simd.AccelMode.SSE1)]
        public static explicit operator Mono.Simd.Vector16b (Mono.Simd.Vector8s v) { throw null; }
        [Mono.Simd.AccelerationAttribute(Mono.Simd.AccelMode.SSE1)]
        [System.CLSCompliantAttribute(false)]
        public static explicit operator Mono.Simd.Vector16sb (Mono.Simd.Vector8s v) { throw null; }
        [Mono.Simd.AccelerationAttribute(Mono.Simd.AccelMode.SSE1)]
        public static explicit operator Mono.Simd.Vector2d (Mono.Simd.Vector8s v) { throw null; }
        [Mono.Simd.AccelerationAttribute(Mono.Simd.AccelMode.SSE1)]
        public static explicit operator Mono.Simd.Vector2l (Mono.Simd.Vector8s v) { throw null; }
        [Mono.Simd.AccelerationAttribute(Mono.Simd.AccelMode.SSE1)]
        [System.CLSCompliantAttribute(false)]
        public static explicit operator Mono.Simd.Vector2ul (Mono.Simd.Vector8s v) { throw null; }
        [Mono.Simd.AccelerationAttribute(Mono.Simd.AccelMode.SSE1)]
        public static explicit operator Mono.Simd.Vector4f (Mono.Simd.Vector8s v) { throw null; }
        [Mono.Simd.AccelerationAttribute(Mono.Simd.AccelMode.SSE1)]
        public static explicit operator Mono.Simd.Vector4i (Mono.Simd.Vector8s v) { throw null; }
        [Mono.Simd.AccelerationAttribute(Mono.Simd.AccelMode.SSE1)]
        [System.CLSCompliantAttribute(false)]
        public static explicit operator Mono.Simd.Vector4ui (Mono.Simd.Vector8s v) { throw null; }
        [Mono.Simd.AccelerationAttribute(Mono.Simd.AccelMode.SSE1)]
        [System.CLSCompliantAttribute(false)]
        public static explicit operator Mono.Simd.Vector8us (Mono.Simd.Vector8s v) { throw null; }
        [Mono.Simd.AccelerationAttribute(Mono.Simd.AccelMode.SSE2)]
        public static bool operator !=(Mono.Simd.Vector8s va, Mono.Simd.Vector8s vb) { throw null; }
        [Mono.Simd.AccelerationAttribute(Mono.Simd.AccelMode.SSE2)]
        public static Mono.Simd.Vector8s operator <<(Mono.Simd.Vector8s va, int amount) { throw null; }
        [Mono.Simd.AccelerationAttribute(Mono.Simd.AccelMode.SSE2)]
        public static Mono.Simd.Vector8s operator *(Mono.Simd.Vector8s va, Mono.Simd.Vector8s vb) { throw null; }
        [Mono.Simd.AccelerationAttribute(Mono.Simd.AccelMode.SSE2)]
        public static Mono.Simd.Vector8s operator >>(Mono.Simd.Vector8s va, int amount) { throw null; }
        [Mono.Simd.AccelerationAttribute(Mono.Simd.AccelMode.SSE2)]
        public static Mono.Simd.Vector8s operator -(Mono.Simd.Vector8s va, Mono.Simd.Vector8s vb) { throw null; }
        [Mono.Simd.AccelerationAttribute(Mono.Simd.AccelMode.SSE1)]
        [System.CLSCompliantAttribute(false)]
        public unsafe static void PrefetchNonTemporal(Mono.Simd.Vector8s* res) { }
        [Mono.Simd.AccelerationAttribute(Mono.Simd.AccelMode.SSE1)]
        [System.CLSCompliantAttribute(false)]
        public static void PrefetchNonTemporal(ref Mono.Simd.Vector8s res) { }
        [Mono.Simd.AccelerationAttribute(Mono.Simd.AccelMode.SSE1)]
        [System.CLSCompliantAttribute(false)]
        public unsafe static void PrefetchTemporal1stLevelCache(Mono.Simd.Vector8s* res) { }
        [Mono.Simd.AccelerationAttribute(Mono.Simd.AccelMode.SSE1)]
        [System.CLSCompliantAttribute(false)]
        public static void PrefetchTemporal1stLevelCache(ref Mono.Simd.Vector8s res) { }
        [Mono.Simd.AccelerationAttribute(Mono.Simd.AccelMode.SSE1)]
        [System.CLSCompliantAttribute(false)]
        public unsafe static void PrefetchTemporal2ndLevelCache(Mono.Simd.Vector8s* res) { }
        [Mono.Simd.AccelerationAttribute(Mono.Simd.AccelMode.SSE1)]
        [System.CLSCompliantAttribute(false)]
        public static void PrefetchTemporal2ndLevelCache(ref Mono.Simd.Vector8s res) { }
        [Mono.Simd.AccelerationAttribute(Mono.Simd.AccelMode.SSE1)]
        [System.CLSCompliantAttribute(false)]
        public unsafe static void PrefetchTemporalAllCacheLevels(Mono.Simd.Vector8s* res) { }
        [Mono.Simd.AccelerationAttribute(Mono.Simd.AccelMode.SSE1)]
        [System.CLSCompliantAttribute(false)]
        public static void PrefetchTemporalAllCacheLevels(ref Mono.Simd.Vector8s res) { }
        [Mono.Simd.AccelerationAttribute(Mono.Simd.AccelMode.SSE1)]
        [System.CLSCompliantAttribute(false)]
        public unsafe static void StoreAligned(Mono.Simd.Vector8s* res, Mono.Simd.Vector8s val) { }
        [Mono.Simd.AccelerationAttribute(Mono.Simd.AccelMode.SSE1)]
        public static void StoreAligned(ref Mono.Simd.Vector8s res, Mono.Simd.Vector8s val) { }
        public override string ToString() { throw null; }
    }
    [System.CLSCompliantAttribute(false)]
    [System.ObsoleteAttribute("Use the types in the System.Numerics.Vectors namespace")]
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Explicit, Size=16)]
    public partial struct Vector8us
    {
        [System.Runtime.InteropServices.FieldOffsetAttribute(0)]
        private int _dummyPrimitive;
        public Vector8us(ushort us) { throw null; }
        public Vector8us(ushort v0, ushort v1, ushort v2, ushort v3, ushort v4, ushort v5, ushort v6, ushort v7) { throw null; }
        [System.Runtime.CompilerServices.IndexerName("Component")]
        public ushort this[int index] { get { throw null; } set { } }
        public static Mono.Simd.Vector8us Identity { get { throw null; } }
        public ushort V0 { get { throw null; } set { } }
        public ushort V1 { get { throw null; } set { } }
        public ushort V2 { get { throw null; } set { } }
        public ushort V3 { get { throw null; } set { } }
        public ushort V4 { get { throw null; } set { } }
        public ushort V5 { get { throw null; } set { } }
        public ushort V6 { get { throw null; } set { } }
        public ushort V7 { get { throw null; } set { } }
        public static Mono.Simd.Vector8us Zero { get { throw null; } }
        [Mono.Simd.AccelerationAttribute(Mono.Simd.AccelMode.SSE1)]
        public unsafe static Mono.Simd.Vector8us LoadAligned(Mono.Simd.Vector8us* v) { throw null; }
        [Mono.Simd.AccelerationAttribute(Mono.Simd.AccelMode.SSE1)]
        public static Mono.Simd.Vector8us LoadAligned(ref Mono.Simd.Vector8us v) { throw null; }
        [Mono.Simd.AccelerationAttribute(Mono.Simd.AccelMode.SSE2)]
        public static Mono.Simd.Vector8us operator +(Mono.Simd.Vector8us va, Mono.Simd.Vector8us vb) { throw null; }
        [Mono.Simd.AccelerationAttribute(Mono.Simd.AccelMode.SSE2)]
        public static Mono.Simd.Vector8us operator &(Mono.Simd.Vector8us va, Mono.Simd.Vector8us vb) { throw null; }
        [Mono.Simd.AccelerationAttribute(Mono.Simd.AccelMode.SSE2)]
        public static Mono.Simd.Vector8us operator |(Mono.Simd.Vector8us va, Mono.Simd.Vector8us vb) { throw null; }
        [Mono.Simd.AccelerationAttribute(Mono.Simd.AccelMode.SSE2)]
        public static bool operator ==(Mono.Simd.Vector8us va, Mono.Simd.Vector8us vb) { throw null; }
        [Mono.Simd.AccelerationAttribute(Mono.Simd.AccelMode.SSE2)]
        public static Mono.Simd.Vector8us operator ^(Mono.Simd.Vector8us va, Mono.Simd.Vector8us vb) { throw null; }
        [Mono.Simd.AccelerationAttribute(Mono.Simd.AccelMode.SSE1)]
        public static explicit operator Mono.Simd.Vector16b (Mono.Simd.Vector8us v) { throw null; }
        [Mono.Simd.AccelerationAttribute(Mono.Simd.AccelMode.SSE1)]
        public static explicit operator Mono.Simd.Vector16sb (Mono.Simd.Vector8us v) { throw null; }
        [Mono.Simd.AccelerationAttribute(Mono.Simd.AccelMode.SSE1)]
        public static explicit operator Mono.Simd.Vector2d (Mono.Simd.Vector8us v) { throw null; }
        [Mono.Simd.AccelerationAttribute(Mono.Simd.AccelMode.SSE1)]
        public static explicit operator Mono.Simd.Vector2l (Mono.Simd.Vector8us v) { throw null; }
        [Mono.Simd.AccelerationAttribute(Mono.Simd.AccelMode.SSE1)]
        public static explicit operator Mono.Simd.Vector2ul (Mono.Simd.Vector8us v) { throw null; }
        [Mono.Simd.AccelerationAttribute(Mono.Simd.AccelMode.SSE1)]
        public static explicit operator Mono.Simd.Vector4f (Mono.Simd.Vector8us v) { throw null; }
        [Mono.Simd.AccelerationAttribute(Mono.Simd.AccelMode.SSE1)]
        public static explicit operator Mono.Simd.Vector4i (Mono.Simd.Vector8us v) { throw null; }
        [Mono.Simd.AccelerationAttribute(Mono.Simd.AccelMode.SSE1)]
        public static explicit operator Mono.Simd.Vector4ui (Mono.Simd.Vector8us v) { throw null; }
        [Mono.Simd.AccelerationAttribute(Mono.Simd.AccelMode.SSE1)]
        public static explicit operator Mono.Simd.Vector8s (Mono.Simd.Vector8us v) { throw null; }
        [Mono.Simd.AccelerationAttribute(Mono.Simd.AccelMode.SSE2)]
        public static bool operator !=(Mono.Simd.Vector8us va, Mono.Simd.Vector8us vb) { throw null; }
        [Mono.Simd.AccelerationAttribute(Mono.Simd.AccelMode.SSE2)]
        public static Mono.Simd.Vector8us operator <<(Mono.Simd.Vector8us va, int amount) { throw null; }
        [Mono.Simd.AccelerationAttribute(Mono.Simd.AccelMode.SSE2)]
        public static Mono.Simd.Vector8us operator *(Mono.Simd.Vector8us va, Mono.Simd.Vector8us vb) { throw null; }
        [Mono.Simd.AccelerationAttribute(Mono.Simd.AccelMode.SSE2)]
        public static Mono.Simd.Vector8us operator >>(Mono.Simd.Vector8us va, int amount) { throw null; }
        [Mono.Simd.AccelerationAttribute(Mono.Simd.AccelMode.SSE2)]
        public static Mono.Simd.Vector8us operator -(Mono.Simd.Vector8us va, Mono.Simd.Vector8us vb) { throw null; }
        [Mono.Simd.AccelerationAttribute(Mono.Simd.AccelMode.SSE1)]
        [System.CLSCompliantAttribute(false)]
        public unsafe static void PrefetchNonTemporal(Mono.Simd.Vector8us* res) { }
        [Mono.Simd.AccelerationAttribute(Mono.Simd.AccelMode.SSE1)]
        [System.CLSCompliantAttribute(false)]
        public static void PrefetchNonTemporal(ref Mono.Simd.Vector8us res) { }
        [Mono.Simd.AccelerationAttribute(Mono.Simd.AccelMode.SSE1)]
        [System.CLSCompliantAttribute(false)]
        public unsafe static void PrefetchTemporal1stLevelCache(Mono.Simd.Vector8us* res) { }
        [Mono.Simd.AccelerationAttribute(Mono.Simd.AccelMode.SSE1)]
        [System.CLSCompliantAttribute(false)]
        public static void PrefetchTemporal1stLevelCache(ref Mono.Simd.Vector8us res) { }
        [Mono.Simd.AccelerationAttribute(Mono.Simd.AccelMode.SSE1)]
        [System.CLSCompliantAttribute(false)]
        public unsafe static void PrefetchTemporal2ndLevelCache(Mono.Simd.Vector8us* res) { }
        [Mono.Simd.AccelerationAttribute(Mono.Simd.AccelMode.SSE1)]
        [System.CLSCompliantAttribute(false)]
        public static void PrefetchTemporal2ndLevelCache(ref Mono.Simd.Vector8us res) { }
        [Mono.Simd.AccelerationAttribute(Mono.Simd.AccelMode.SSE1)]
        [System.CLSCompliantAttribute(false)]
        public unsafe static void PrefetchTemporalAllCacheLevels(Mono.Simd.Vector8us* res) { }
        [Mono.Simd.AccelerationAttribute(Mono.Simd.AccelMode.SSE1)]
        [System.CLSCompliantAttribute(false)]
        public static void PrefetchTemporalAllCacheLevels(ref Mono.Simd.Vector8us res) { }
        [Mono.Simd.AccelerationAttribute(Mono.Simd.AccelMode.SSE1)]
        public unsafe static void StoreAligned(Mono.Simd.Vector8us* res, Mono.Simd.Vector8us val) { }
        [Mono.Simd.AccelerationAttribute(Mono.Simd.AccelMode.SSE1)]
        public static void StoreAligned(ref Mono.Simd.Vector8us res, Mono.Simd.Vector8us val) { }
        public override string ToString() { throw null; }
    }
    public static partial class VectorOperations
    {
        [Mono.Simd.AccelerationAttribute(Mono.Simd.AccelMode.SSE3)]
        public static Mono.Simd.Vector2d AddSub(this Mono.Simd.Vector2d v1, Mono.Simd.Vector2d v2) { throw null; }
        [Mono.Simd.AccelerationAttribute(Mono.Simd.AccelMode.SSE3)]
        public static Mono.Simd.Vector4f AddSub(this Mono.Simd.Vector4f v1, Mono.Simd.Vector4f v2) { throw null; }
        [Mono.Simd.AccelerationAttribute(Mono.Simd.AccelMode.SSE2)]
        public static Mono.Simd.Vector16b AddWithSaturation(this Mono.Simd.Vector16b va, Mono.Simd.Vector16b vb) { throw null; }
        [Mono.Simd.AccelerationAttribute(Mono.Simd.AccelMode.SSE2)]
        [System.CLSCompliantAttribute(false)]
        public static Mono.Simd.Vector16sb AddWithSaturation(this Mono.Simd.Vector16sb va, Mono.Simd.Vector16sb vb) { throw null; }
        [Mono.Simd.AccelerationAttribute(Mono.Simd.AccelMode.SSE2)]
        public static Mono.Simd.Vector8s AddWithSaturation(this Mono.Simd.Vector8s va, Mono.Simd.Vector8s vb) { throw null; }
        [Mono.Simd.AccelerationAttribute(Mono.Simd.AccelMode.SSE2)]
        [System.CLSCompliantAttribute(false)]
        public static Mono.Simd.Vector8us AddWithSaturation(this Mono.Simd.Vector8us va, Mono.Simd.Vector8us vb) { throw null; }
        [Mono.Simd.AccelerationAttribute(Mono.Simd.AccelMode.SSE2)]
        public static Mono.Simd.Vector2d AndNot(this Mono.Simd.Vector2d v1, Mono.Simd.Vector2d v2) { throw null; }
        [Mono.Simd.AccelerationAttribute(Mono.Simd.AccelMode.SSE1)]
        public static Mono.Simd.Vector4f AndNot(this Mono.Simd.Vector4f v1, Mono.Simd.Vector4f v2) { throw null; }
        [Mono.Simd.AccelerationAttribute(Mono.Simd.AccelMode.SSE2)]
        [System.CLSCompliantAttribute(false)]
        public static Mono.Simd.Vector4ui ArithmeticRightShift(this Mono.Simd.Vector4ui v1, int amount) { throw null; }
        [Mono.Simd.AccelerationAttribute(Mono.Simd.AccelMode.SSE2)]
        [System.CLSCompliantAttribute(false)]
        public static Mono.Simd.Vector8us ArithmeticRightShift(this Mono.Simd.Vector8us va, int amount) { throw null; }
        [Mono.Simd.AccelerationAttribute(Mono.Simd.AccelMode.SSE2)]
        public static Mono.Simd.Vector16b Average(this Mono.Simd.Vector16b va, Mono.Simd.Vector16b vb) { throw null; }
        [Mono.Simd.AccelerationAttribute(Mono.Simd.AccelMode.SSE2)]
        [System.CLSCompliantAttribute(false)]
        public static Mono.Simd.Vector8us Average(this Mono.Simd.Vector8us va, Mono.Simd.Vector8us vb) { throw null; }
        [Mono.Simd.AccelerationAttribute(Mono.Simd.AccelMode.SSE2)]
        public static Mono.Simd.Vector16b CompareEqual(this Mono.Simd.Vector16b va, Mono.Simd.Vector16b vb) { throw null; }
        [Mono.Simd.AccelerationAttribute(Mono.Simd.AccelMode.SSE2)]
        [System.CLSCompliantAttribute(false)]
        public static Mono.Simd.Vector16sb CompareEqual(this Mono.Simd.Vector16sb va, Mono.Simd.Vector16sb vb) { throw null; }
        [Mono.Simd.AccelerationAttribute(Mono.Simd.AccelMode.SSE2)]
        public static Mono.Simd.Vector2d CompareEqual(this Mono.Simd.Vector2d v1, Mono.Simd.Vector2d v2) { throw null; }
        [Mono.Simd.AccelerationAttribute(Mono.Simd.AccelMode.SSE41)]
        public static Mono.Simd.Vector2l CompareEqual(this Mono.Simd.Vector2l v1, Mono.Simd.Vector2l v2) { throw null; }
        [Mono.Simd.AccelerationAttribute(Mono.Simd.AccelMode.SSE41)]
        [System.CLSCompliantAttribute(false)]
        public static Mono.Simd.Vector2ul CompareEqual(this Mono.Simd.Vector2ul v1, Mono.Simd.Vector2ul v2) { throw null; }
        [Mono.Simd.AccelerationAttribute(Mono.Simd.AccelMode.SSE1)]
        public static Mono.Simd.Vector4f CompareEqual(this Mono.Simd.Vector4f v1, Mono.Simd.Vector4f v2) { throw null; }
        [Mono.Simd.AccelerationAttribute(Mono.Simd.AccelMode.SSE2)]
        public static Mono.Simd.Vector4i CompareEqual(this Mono.Simd.Vector4i v1, Mono.Simd.Vector4i v2) { throw null; }
        [Mono.Simd.AccelerationAttribute(Mono.Simd.AccelMode.SSE2)]
        [System.CLSCompliantAttribute(false)]
        public static Mono.Simd.Vector4ui CompareEqual(this Mono.Simd.Vector4ui v1, Mono.Simd.Vector4ui v2) { throw null; }
        [Mono.Simd.AccelerationAttribute(Mono.Simd.AccelMode.SSE2)]
        public static Mono.Simd.Vector8s CompareEqual(this Mono.Simd.Vector8s va, Mono.Simd.Vector8s vb) { throw null; }
        [Mono.Simd.AccelerationAttribute(Mono.Simd.AccelMode.SSE2)]
        [System.CLSCompliantAttribute(false)]
        public static Mono.Simd.Vector8us CompareEqual(this Mono.Simd.Vector8us va, Mono.Simd.Vector8us vb) { throw null; }
        [Mono.Simd.AccelerationAttribute(Mono.Simd.AccelMode.SSE2)]
        [System.CLSCompliantAttribute(false)]
        public static Mono.Simd.Vector16sb CompareGreaterThan(this Mono.Simd.Vector16sb va, Mono.Simd.Vector16sb vb) { throw null; }
        [Mono.Simd.AccelerationAttribute(Mono.Simd.AccelMode.SSE42)]
        public static Mono.Simd.Vector2l CompareGreaterThan(this Mono.Simd.Vector2l v1, Mono.Simd.Vector2l v2) { throw null; }
        [Mono.Simd.AccelerationAttribute(Mono.Simd.AccelMode.SSE2)]
        public static Mono.Simd.Vector4i CompareGreaterThan(this Mono.Simd.Vector4i v1, Mono.Simd.Vector4i v2) { throw null; }
        [Mono.Simd.AccelerationAttribute(Mono.Simd.AccelMode.SSE2)]
        public static Mono.Simd.Vector8s CompareGreaterThan(this Mono.Simd.Vector8s va, Mono.Simd.Vector8s vb) { throw null; }
        [Mono.Simd.AccelerationAttribute(Mono.Simd.AccelMode.SSE2)]
        public static Mono.Simd.Vector2d CompareLessEqual(this Mono.Simd.Vector2d v1, Mono.Simd.Vector2d v2) { throw null; }
        [Mono.Simd.AccelerationAttribute(Mono.Simd.AccelMode.SSE1)]
        public static Mono.Simd.Vector4f CompareLessEqual(this Mono.Simd.Vector4f v1, Mono.Simd.Vector4f v2) { throw null; }
        [Mono.Simd.AccelerationAttribute(Mono.Simd.AccelMode.SSE2)]
        public static Mono.Simd.Vector2d CompareLessThan(this Mono.Simd.Vector2d v1, Mono.Simd.Vector2d v2) { throw null; }
        [Mono.Simd.AccelerationAttribute(Mono.Simd.AccelMode.SSE1)]
        public static Mono.Simd.Vector4f CompareLessThan(this Mono.Simd.Vector4f v1, Mono.Simd.Vector4f v2) { throw null; }
        [Mono.Simd.AccelerationAttribute(Mono.Simd.AccelMode.SSE2)]
        public static Mono.Simd.Vector2d CompareNotEqual(this Mono.Simd.Vector2d v1, Mono.Simd.Vector2d v2) { throw null; }
        [Mono.Simd.AccelerationAttribute(Mono.Simd.AccelMode.SSE1)]
        public static Mono.Simd.Vector4f CompareNotEqual(this Mono.Simd.Vector4f v1, Mono.Simd.Vector4f v2) { throw null; }
        [Mono.Simd.AccelerationAttribute(Mono.Simd.AccelMode.SSE2)]
        public static Mono.Simd.Vector2d CompareNotLessEqual(this Mono.Simd.Vector2d v1, Mono.Simd.Vector2d v2) { throw null; }
        [Mono.Simd.AccelerationAttribute(Mono.Simd.AccelMode.SSE1)]
        public static Mono.Simd.Vector4f CompareNotLessEqual(this Mono.Simd.Vector4f v1, Mono.Simd.Vector4f v2) { throw null; }
        [Mono.Simd.AccelerationAttribute(Mono.Simd.AccelMode.SSE2)]
        public static Mono.Simd.Vector2d CompareNotLessThan(this Mono.Simd.Vector2d v1, Mono.Simd.Vector2d v2) { throw null; }
        [Mono.Simd.AccelerationAttribute(Mono.Simd.AccelMode.SSE1)]
        public static Mono.Simd.Vector4f CompareNotLessThan(this Mono.Simd.Vector4f v1, Mono.Simd.Vector4f v2) { throw null; }
        [Mono.Simd.AccelerationAttribute(Mono.Simd.AccelMode.SSE2)]
        public static Mono.Simd.Vector2d CompareOrdered(this Mono.Simd.Vector2d v1, Mono.Simd.Vector2d v2) { throw null; }
        [Mono.Simd.AccelerationAttribute(Mono.Simd.AccelMode.SSE1)]
        public static Mono.Simd.Vector4f CompareOrdered(this Mono.Simd.Vector4f v1, Mono.Simd.Vector4f v2) { throw null; }
        [Mono.Simd.AccelerationAttribute(Mono.Simd.AccelMode.SSE2)]
        public static Mono.Simd.Vector2d CompareUnordered(this Mono.Simd.Vector2d v1, Mono.Simd.Vector2d v2) { throw null; }
        [Mono.Simd.AccelerationAttribute(Mono.Simd.AccelMode.SSE1)]
        public static Mono.Simd.Vector4f CompareUnordered(this Mono.Simd.Vector4f v1, Mono.Simd.Vector4f v2) { throw null; }
        [Mono.Simd.AccelerationAttribute(Mono.Simd.AccelMode.SSE2)]
        public static Mono.Simd.Vector2d ConvertToDouble(this Mono.Simd.Vector4f v0) { throw null; }
        [Mono.Simd.AccelerationAttribute(Mono.Simd.AccelMode.SSE2)]
        public static Mono.Simd.Vector2d ConvertToDouble(this Mono.Simd.Vector4i v0) { throw null; }
        [Mono.Simd.AccelerationAttribute(Mono.Simd.AccelMode.SSE2)]
        public static Mono.Simd.Vector4f ConvertToFloat(this Mono.Simd.Vector2d v0) { throw null; }
        [Mono.Simd.AccelerationAttribute(Mono.Simd.AccelMode.SSE2)]
        public static Mono.Simd.Vector4f ConvertToFloat(this Mono.Simd.Vector4i v0) { throw null; }
        [Mono.Simd.AccelerationAttribute(Mono.Simd.AccelMode.SSE2)]
        public static Mono.Simd.Vector4i ConvertToInt(this Mono.Simd.Vector2d v0) { throw null; }
        [Mono.Simd.AccelerationAttribute(Mono.Simd.AccelMode.SSE2)]
        public static Mono.Simd.Vector4i ConvertToInt(this Mono.Simd.Vector4f v0) { throw null; }
        [Mono.Simd.AccelerationAttribute(Mono.Simd.AccelMode.SSE2)]
        public static Mono.Simd.Vector4i ConvertToIntTruncated(this Mono.Simd.Vector2d v0) { throw null; }
        [Mono.Simd.AccelerationAttribute(Mono.Simd.AccelMode.SSE2)]
        public static Mono.Simd.Vector4i ConvertToIntTruncated(this Mono.Simd.Vector4f v0) { throw null; }
        [Mono.Simd.AccelerationAttribute(Mono.Simd.AccelMode.SSE3)]
        public static Mono.Simd.Vector2d Duplicate(this Mono.Simd.Vector2d v1) { throw null; }
        [Mono.Simd.AccelerationAttribute(Mono.Simd.AccelMode.SSE3)]
        public static Mono.Simd.Vector4f DuplicateHigh(this Mono.Simd.Vector4f v1) { throw null; }
        [Mono.Simd.AccelerationAttribute(Mono.Simd.AccelMode.SSE3)]
        public static Mono.Simd.Vector4f DuplicateLow(this Mono.Simd.Vector4f v1) { throw null; }
        [Mono.Simd.AccelerationAttribute(Mono.Simd.AccelMode.SSE2)]
        public static int ExtractByteMask(this Mono.Simd.Vector16b va) { throw null; }
        [Mono.Simd.AccelerationAttribute(Mono.Simd.AccelMode.SSE2)]
        [System.CLSCompliantAttribute(false)]
        public static int ExtractByteMask(this Mono.Simd.Vector16sb va) { throw null; }
        [Mono.Simd.AccelerationAttribute(Mono.Simd.AccelMode.SSE3)]
        public static Mono.Simd.Vector2d HorizontalAdd(this Mono.Simd.Vector2d v1, Mono.Simd.Vector2d v2) { throw null; }
        [Mono.Simd.AccelerationAttribute(Mono.Simd.AccelMode.SSE3)]
        public static Mono.Simd.Vector4f HorizontalAdd(this Mono.Simd.Vector4f v1, Mono.Simd.Vector4f v2) { throw null; }
        [Mono.Simd.AccelerationAttribute(Mono.Simd.AccelMode.SSE3)]
        public static Mono.Simd.Vector2d HorizontalSub(this Mono.Simd.Vector2d v1, Mono.Simd.Vector2d v2) { throw null; }
        [Mono.Simd.AccelerationAttribute(Mono.Simd.AccelMode.SSE3)]
        public static Mono.Simd.Vector4f HorizontalSub(this Mono.Simd.Vector4f v1, Mono.Simd.Vector4f v2) { throw null; }
        [Mono.Simd.AccelerationAttribute(Mono.Simd.AccelMode.SSE2)]
        public static Mono.Simd.Vector2d InterleaveHigh(this Mono.Simd.Vector2d v1, Mono.Simd.Vector2d v2) { throw null; }
        [Mono.Simd.AccelerationAttribute(Mono.Simd.AccelMode.SSE1)]
        public static Mono.Simd.Vector4f InterleaveHigh(this Mono.Simd.Vector4f v1, Mono.Simd.Vector4f v2) { throw null; }
        [Mono.Simd.AccelerationAttribute(Mono.Simd.AccelMode.SSE2)]
        public static Mono.Simd.Vector2d InterleaveLow(this Mono.Simd.Vector2d v1, Mono.Simd.Vector2d v2) { throw null; }
        [Mono.Simd.AccelerationAttribute(Mono.Simd.AccelMode.SSE1)]
        public static Mono.Simd.Vector4f InterleaveLow(this Mono.Simd.Vector4f v1, Mono.Simd.Vector4f v2) { throw null; }
        [Mono.Simd.AccelerationAttribute(Mono.Simd.AccelMode.SSE1)]
        public static Mono.Simd.Vector4f InvSqrt(this Mono.Simd.Vector4f v1) { throw null; }
        [Mono.Simd.AccelerationAttribute(Mono.Simd.AccelMode.SSE2)]
        public static Mono.Simd.Vector2l LogicalRightShift(this Mono.Simd.Vector2l v1, int amount) { throw null; }
        [Mono.Simd.AccelerationAttribute(Mono.Simd.AccelMode.SSE2)]
        public static Mono.Simd.Vector4i LogicalRightShift(this Mono.Simd.Vector4i v1, int amount) { throw null; }
        [Mono.Simd.AccelerationAttribute(Mono.Simd.AccelMode.SSE2)]
        public static Mono.Simd.Vector8s LogicalRightShift(this Mono.Simd.Vector8s va, int amount) { throw null; }
        [Mono.Simd.AccelerationAttribute(Mono.Simd.AccelMode.SSE2)]
        public static Mono.Simd.Vector16b Max(this Mono.Simd.Vector16b va, Mono.Simd.Vector16b vb) { throw null; }
        [Mono.Simd.AccelerationAttribute(Mono.Simd.AccelMode.SSE41)]
        [System.CLSCompliantAttribute(false)]
        public static Mono.Simd.Vector16sb Max(this Mono.Simd.Vector16sb va, Mono.Simd.Vector16sb vb) { throw null; }
        [Mono.Simd.AccelerationAttribute(Mono.Simd.AccelMode.SSE2)]
        public static Mono.Simd.Vector2d Max(this Mono.Simd.Vector2d v1, Mono.Simd.Vector2d v2) { throw null; }
        [Mono.Simd.AccelerationAttribute(Mono.Simd.AccelMode.SSE1)]
        public static Mono.Simd.Vector4f Max(this Mono.Simd.Vector4f v1, Mono.Simd.Vector4f v2) { throw null; }
        [Mono.Simd.AccelerationAttribute(Mono.Simd.AccelMode.SSE41)]
        public static Mono.Simd.Vector4i Max(this Mono.Simd.Vector4i v1, Mono.Simd.Vector4i v2) { throw null; }
        [Mono.Simd.AccelerationAttribute(Mono.Simd.AccelMode.SSE41)]
        [System.CLSCompliantAttribute(false)]
        public static Mono.Simd.Vector4ui Max(this Mono.Simd.Vector4ui v1, Mono.Simd.Vector4ui v2) { throw null; }
        [Mono.Simd.AccelerationAttribute(Mono.Simd.AccelMode.SSE2)]
        public static Mono.Simd.Vector8s Max(this Mono.Simd.Vector8s va, Mono.Simd.Vector8s vb) { throw null; }
        [Mono.Simd.AccelerationAttribute(Mono.Simd.AccelMode.SSE41)]
        [System.CLSCompliantAttribute(false)]
        public static Mono.Simd.Vector8us Max(this Mono.Simd.Vector8us va, Mono.Simd.Vector8us vb) { throw null; }
        [Mono.Simd.AccelerationAttribute(Mono.Simd.AccelMode.SSE2)]
        public static Mono.Simd.Vector16b Min(this Mono.Simd.Vector16b va, Mono.Simd.Vector16b vb) { throw null; }
        [Mono.Simd.AccelerationAttribute(Mono.Simd.AccelMode.SSE41)]
        [System.CLSCompliantAttribute(false)]
        public static Mono.Simd.Vector16sb Min(this Mono.Simd.Vector16sb va, Mono.Simd.Vector16sb vb) { throw null; }
        [Mono.Simd.AccelerationAttribute(Mono.Simd.AccelMode.SSE2)]
        public static Mono.Simd.Vector2d Min(this Mono.Simd.Vector2d v1, Mono.Simd.Vector2d v2) { throw null; }
        [Mono.Simd.AccelerationAttribute(Mono.Simd.AccelMode.SSE1)]
        public static Mono.Simd.Vector4f Min(this Mono.Simd.Vector4f v1, Mono.Simd.Vector4f v2) { throw null; }
        [Mono.Simd.AccelerationAttribute(Mono.Simd.AccelMode.SSE41)]
        public static Mono.Simd.Vector4i Min(this Mono.Simd.Vector4i v1, Mono.Simd.Vector4i v2) { throw null; }
        [Mono.Simd.AccelerationAttribute(Mono.Simd.AccelMode.SSE41)]
        [System.CLSCompliantAttribute(false)]
        public static Mono.Simd.Vector4ui Min(this Mono.Simd.Vector4ui v1, Mono.Simd.Vector4ui v2) { throw null; }
        [Mono.Simd.AccelerationAttribute(Mono.Simd.AccelMode.SSE2)]
        public static Mono.Simd.Vector8s Min(this Mono.Simd.Vector8s va, Mono.Simd.Vector8s vb) { throw null; }
        [Mono.Simd.AccelerationAttribute(Mono.Simd.AccelMode.SSE41)]
        [System.CLSCompliantAttribute(false)]
        public static Mono.Simd.Vector8us Min(this Mono.Simd.Vector8us va, Mono.Simd.Vector8us vb) { throw null; }
        [Mono.Simd.AccelerationAttribute(Mono.Simd.AccelMode.SSE2)]
        public static Mono.Simd.Vector8s MultiplyStoreHigh(this Mono.Simd.Vector8s va, Mono.Simd.Vector8s vb) { throw null; }
        [Mono.Simd.AccelerationAttribute(Mono.Simd.AccelMode.SSE2)]
        [System.CLSCompliantAttribute(false)]
        public static Mono.Simd.Vector8us MultiplyStoreHigh(this Mono.Simd.Vector8us va, Mono.Simd.Vector8us vb) { throw null; }
        [Mono.Simd.AccelerationAttribute(Mono.Simd.AccelMode.SSE2)]
        public static Mono.Simd.Vector8s PackWithSignedSaturation(this Mono.Simd.Vector4i va, Mono.Simd.Vector4i vb) { throw null; }
        [Mono.Simd.AccelerationAttribute(Mono.Simd.AccelMode.SSE2)]
        [System.CLSCompliantAttribute(false)]
        public static Mono.Simd.Vector16sb PackWithSignedSaturation(this Mono.Simd.Vector8s va, Mono.Simd.Vector8s vb) { throw null; }
        [Mono.Simd.AccelerationAttribute(Mono.Simd.AccelMode.SSE41)]
        [System.CLSCompliantAttribute(false)]
        public static Mono.Simd.Vector8us PackWithUnsignedSaturation(this Mono.Simd.Vector4i va, Mono.Simd.Vector4i vb) { throw null; }
        [Mono.Simd.AccelerationAttribute(Mono.Simd.AccelMode.SSE2)]
        public static Mono.Simd.Vector16b PackWithUnsignedSaturation(this Mono.Simd.Vector8s va, Mono.Simd.Vector8s vb) { throw null; }
        [Mono.Simd.AccelerationAttribute(Mono.Simd.AccelMode.SSE1)]
        public static Mono.Simd.Vector4f Reciprocal(this Mono.Simd.Vector4f v1) { throw null; }
        [Mono.Simd.AccelerationAttribute(Mono.Simd.AccelMode.SSE2)]
        public static Mono.Simd.Vector2d Shuffle(this Mono.Simd.Vector2d v1, Mono.Simd.Vector2d v2, int sel) { throw null; }
        [Mono.Simd.AccelerationAttribute(Mono.Simd.AccelMode.SSE2)]
        public static Mono.Simd.Vector2l Shuffle(this Mono.Simd.Vector2l v1, Mono.Simd.Vector2l v2, int sel) { throw null; }
        [Mono.Simd.AccelerationAttribute(Mono.Simd.AccelMode.SSE2)]
        public static Mono.Simd.Vector2ul Shuffle(this Mono.Simd.Vector2ul v1, Mono.Simd.Vector2ul v2, int sel) { throw null; }
        [Mono.Simd.AccelerationAttribute(Mono.Simd.AccelMode.SSE2)]
        public static Mono.Simd.Vector4f Shuffle(this Mono.Simd.Vector4f v1, Mono.Simd.ShuffleSel sel) { throw null; }
        [Mono.Simd.AccelerationAttribute(Mono.Simd.AccelMode.SSE2)]
        public static Mono.Simd.Vector4f Shuffle(this Mono.Simd.Vector4f v1, Mono.Simd.Vector4f v2, Mono.Simd.ShuffleSel sel) { throw null; }
        [Mono.Simd.AccelerationAttribute(Mono.Simd.AccelMode.SSE2)]
        public static Mono.Simd.Vector4i Shuffle(this Mono.Simd.Vector4i v1, Mono.Simd.ShuffleSel sel) { throw null; }
        [Mono.Simd.AccelerationAttribute(Mono.Simd.AccelMode.SSE2)]
        public static Mono.Simd.Vector4i Shuffle(this Mono.Simd.Vector4i v1, Mono.Simd.Vector4i v2, Mono.Simd.ShuffleSel sel) { throw null; }
        [Mono.Simd.AccelerationAttribute(Mono.Simd.AccelMode.SSE2)]
        [System.CLSCompliantAttribute(false)]
        public static Mono.Simd.Vector4ui Shuffle(this Mono.Simd.Vector4ui v1, Mono.Simd.ShuffleSel sel) { throw null; }
        [Mono.Simd.AccelerationAttribute(Mono.Simd.AccelMode.SSE2)]
        public static Mono.Simd.Vector4ui Shuffle(this Mono.Simd.Vector4ui v1, Mono.Simd.Vector4ui v2, Mono.Simd.ShuffleSel sel) { throw null; }
        [Mono.Simd.AccelerationAttribute(Mono.Simd.AccelMode.SSE2)]
        public static Mono.Simd.Vector8s ShuffleHigh(this Mono.Simd.Vector8s va, Mono.Simd.ShuffleSel sel) { throw null; }
        [Mono.Simd.AccelerationAttribute(Mono.Simd.AccelMode.SSE2)]
        [System.CLSCompliantAttribute(false)]
        public static Mono.Simd.Vector8us ShuffleHigh(this Mono.Simd.Vector8us va, Mono.Simd.ShuffleSel sel) { throw null; }
        [Mono.Simd.AccelerationAttribute(Mono.Simd.AccelMode.SSE2)]
        public static Mono.Simd.Vector8s ShuffleLow(this Mono.Simd.Vector8s va, Mono.Simd.ShuffleSel sel) { throw null; }
        [Mono.Simd.AccelerationAttribute(Mono.Simd.AccelMode.SSE2)]
        [System.CLSCompliantAttribute(false)]
        public static Mono.Simd.Vector8us ShuffleLow(this Mono.Simd.Vector8us va, Mono.Simd.ShuffleSel sel) { throw null; }
        [Mono.Simd.AccelerationAttribute(Mono.Simd.AccelMode.SSE2)]
        [System.CLSCompliantAttribute(false)]
        public static Mono.Simd.Vector8s SignedPackWithSignedSaturation(this Mono.Simd.Vector4ui va, Mono.Simd.Vector4ui vb) { throw null; }
        [Mono.Simd.AccelerationAttribute(Mono.Simd.AccelMode.SSE2)]
        [System.CLSCompliantAttribute(false)]
        public static Mono.Simd.Vector16sb SignedPackWithSignedSaturation(this Mono.Simd.Vector8us va, Mono.Simd.Vector8us vb) { throw null; }
        [Mono.Simd.AccelerationAttribute(Mono.Simd.AccelMode.SSE41)]
        [System.CLSCompliantAttribute(false)]
        public static Mono.Simd.Vector8us SignedPackWithUnsignedSaturation(this Mono.Simd.Vector4ui va, Mono.Simd.Vector4ui vb) { throw null; }
        [Mono.Simd.AccelerationAttribute(Mono.Simd.AccelMode.SSE2)]
        [System.CLSCompliantAttribute(false)]
        public static Mono.Simd.Vector16b SignedPackWithUnsignedSaturation(this Mono.Simd.Vector8us va, Mono.Simd.Vector8us vb) { throw null; }
        [Mono.Simd.AccelerationAttribute(Mono.Simd.AccelMode.SSE2)]
        public static Mono.Simd.Vector2d Sqrt(this Mono.Simd.Vector2d v1) { throw null; }
        [Mono.Simd.AccelerationAttribute(Mono.Simd.AccelMode.SSE1)]
        public static Mono.Simd.Vector4f Sqrt(this Mono.Simd.Vector4f v1) { throw null; }
        [Mono.Simd.AccelerationAttribute(Mono.Simd.AccelMode.SSE2)]
        public static Mono.Simd.Vector16b SubtractWithSaturation(this Mono.Simd.Vector16b va, Mono.Simd.Vector16b vb) { throw null; }
        [Mono.Simd.AccelerationAttribute(Mono.Simd.AccelMode.SSE2)]
        [System.CLSCompliantAttribute(false)]
        public static Mono.Simd.Vector16sb SubtractWithSaturation(this Mono.Simd.Vector16sb va, Mono.Simd.Vector16sb vb) { throw null; }
        [Mono.Simd.AccelerationAttribute(Mono.Simd.AccelMode.SSE2)]
        public static Mono.Simd.Vector8s SubtractWithSaturation(this Mono.Simd.Vector8s va, Mono.Simd.Vector8s vb) { throw null; }
        [Mono.Simd.AccelerationAttribute(Mono.Simd.AccelMode.SSE2)]
        [System.CLSCompliantAttribute(false)]
        public static Mono.Simd.Vector8us SubtractWithSaturation(this Mono.Simd.Vector8us va, Mono.Simd.Vector8us vb) { throw null; }
        [Mono.Simd.AccelerationAttribute(Mono.Simd.AccelMode.SSE2)]
        [System.CLSCompliantAttribute(false)]
        public static Mono.Simd.Vector8us SumOfAbsoluteDifferences(this Mono.Simd.Vector16b va, Mono.Simd.Vector16sb vb) { throw null; }
        [Mono.Simd.AccelerationAttribute(Mono.Simd.AccelMode.SSE2)]
        public static Mono.Simd.Vector16b UnpackHigh(this Mono.Simd.Vector16b va, Mono.Simd.Vector16b vb) { throw null; }
        [Mono.Simd.AccelerationAttribute(Mono.Simd.AccelMode.SSE2)]
        [System.CLSCompliantAttribute(false)]
        public static Mono.Simd.Vector16sb UnpackHigh(this Mono.Simd.Vector16sb va, Mono.Simd.Vector16sb vb) { throw null; }
        [Mono.Simd.AccelerationAttribute(Mono.Simd.AccelMode.SSE2)]
        public static Mono.Simd.Vector2l UnpackHigh(this Mono.Simd.Vector2l v1, Mono.Simd.Vector2l v2) { throw null; }
        [Mono.Simd.AccelerationAttribute(Mono.Simd.AccelMode.SSE2)]
        [System.CLSCompliantAttribute(false)]
        public static Mono.Simd.Vector2ul UnpackHigh(this Mono.Simd.Vector2ul v1, Mono.Simd.Vector2ul v2) { throw null; }
        [Mono.Simd.AccelerationAttribute(Mono.Simd.AccelMode.SSE2)]
        public static Mono.Simd.Vector4i UnpackHigh(this Mono.Simd.Vector4i v1, Mono.Simd.Vector4i v2) { throw null; }
        [Mono.Simd.AccelerationAttribute(Mono.Simd.AccelMode.SSE2)]
        [System.CLSCompliantAttribute(false)]
        public static Mono.Simd.Vector4ui UnpackHigh(this Mono.Simd.Vector4ui v1, Mono.Simd.Vector4ui v2) { throw null; }
        [Mono.Simd.AccelerationAttribute(Mono.Simd.AccelMode.SSE2)]
        public static Mono.Simd.Vector8s UnpackHigh(this Mono.Simd.Vector8s va, Mono.Simd.Vector8s vb) { throw null; }
        [Mono.Simd.AccelerationAttribute(Mono.Simd.AccelMode.SSE2)]
        [System.CLSCompliantAttribute(false)]
        public static Mono.Simd.Vector8us UnpackHigh(this Mono.Simd.Vector8us va, Mono.Simd.Vector8us vb) { throw null; }
        [Mono.Simd.AccelerationAttribute(Mono.Simd.AccelMode.SSE2)]
        public static Mono.Simd.Vector16b UnpackLow(this Mono.Simd.Vector16b va, Mono.Simd.Vector16b vb) { throw null; }
        [Mono.Simd.AccelerationAttribute(Mono.Simd.AccelMode.SSE2)]
        [System.CLSCompliantAttribute(false)]
        public static Mono.Simd.Vector16sb UnpackLow(this Mono.Simd.Vector16sb va, Mono.Simd.Vector16sb vb) { throw null; }
        [Mono.Simd.AccelerationAttribute(Mono.Simd.AccelMode.SSE2)]
        public static Mono.Simd.Vector2l UnpackLow(this Mono.Simd.Vector2l v1, Mono.Simd.Vector2l v2) { throw null; }
        [Mono.Simd.AccelerationAttribute(Mono.Simd.AccelMode.SSE2)]
        [System.CLSCompliantAttribute(false)]
        public static Mono.Simd.Vector2ul UnpackLow(this Mono.Simd.Vector2ul v1, Mono.Simd.Vector2ul v2) { throw null; }
        [Mono.Simd.AccelerationAttribute(Mono.Simd.AccelMode.SSE2)]
        public static Mono.Simd.Vector4i UnpackLow(this Mono.Simd.Vector4i v1, Mono.Simd.Vector4i v2) { throw null; }
        [Mono.Simd.AccelerationAttribute(Mono.Simd.AccelMode.SSE2)]
        [System.CLSCompliantAttribute(false)]
        public static Mono.Simd.Vector4ui UnpackLow(this Mono.Simd.Vector4ui v1, Mono.Simd.Vector4ui v2) { throw null; }
        [Mono.Simd.AccelerationAttribute(Mono.Simd.AccelMode.SSE2)]
        public static Mono.Simd.Vector8s UnpackLow(this Mono.Simd.Vector8s va, Mono.Simd.Vector8s vb) { throw null; }
        [Mono.Simd.AccelerationAttribute(Mono.Simd.AccelMode.SSE2)]
        [System.CLSCompliantAttribute(false)]
        public static Mono.Simd.Vector8us UnpackLow(this Mono.Simd.Vector8us va, Mono.Simd.Vector8us vb) { throw null; }
    }
}
