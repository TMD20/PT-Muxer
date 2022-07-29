// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

[assembly:System.Reflection.AssemblyVersionAttribute("4.0.0.0")]
[assembly:System.Diagnostics.DebuggableAttribute(System.Diagnostics.DebuggableAttribute.DebuggingModes.IgnoreSymbolStoreSequencePoints)]
[assembly:System.Runtime.CompilerServices.CompilationRelaxationsAttribute(8)]
[assembly:System.Runtime.CompilerServices.RuntimeCompatibilityAttribute(WrapNonExceptionThrows=true)]
namespace PEAPI
{
    public partial class AddressConstant : PEAPI.DataConstant
    {
        public AddressConstant(PEAPI.DataConstant dConst) { }
    }
    public abstract partial class Array : PEAPI.Type
    {
        internal Array() { }
        protected string cname;
        protected string cnameSpace;
        protected PEAPI.Type elemType;
        protected PEAPI.MetaData metaData;
    }
    public partial class ArrayConstant : PEAPI.DataConstant
    {
        public ArrayConstant(PEAPI.DataConstant[] dVals) { }
        public System.Nullable<int> ExplicitSize { get { throw null; } set { } }
    }
    public enum AssemAttr
    {
        DisableJITCompileOptimizer = 16384,
        EnableJITCompileTracking = 32768,
        Retargetable = 256,
    }
    public partial class Assembly : PEAPI.ResolutionScope
    {
        internal Assembly() { }
        public void AddAssemblyAttr(PEAPI.AssemAttr aa) { }
        public void AddAssemblyInfo(int majVer, int minVer, int bldNo, int revNo, byte[] key, uint hash, string cult) { }
    }
    public partial class AssemblyRef : PEAPI.ResolutionScope, PEAPI.IExternRef
    {
        internal AssemblyRef() { }
        public void AddAssemblyAttr(PEAPI.AssemAttr aa) { }
        public virtual PEAPI.ClassRef AddClass(string nsName, string name) { throw null; }
        public void AddCulture(string cult) { }
        public void AddHash(byte[] hash) { }
        public void AddKey(byte[] key) { }
        public void AddKeyToken(byte[] key) { }
        public virtual PEAPI.ClassRef AddValueClass(string nsName, string name) { throw null; }
        public void AddVersionInfo(int majVer, int minVer, int bldNo, int revNo) { }
    }
    public abstract partial class BaseDeclSecurity : PEAPI.MetaDataElement
    {
        internal BaseDeclSecurity() { }
    }
    public partial class BoolConst : PEAPI.DataConstant
    {
        public BoolConst(bool val) { }
    }
    public partial class BoundArray : PEAPI.Array
    {
        public BoundArray(PEAPI.Type elementType, uint dimensions) { }
        public BoundArray(PEAPI.Type elementType, uint dimensions, int[] size) { }
        public BoundArray(PEAPI.Type elementType, uint dimensions, int[] loBounds, int[] sizes) { }
    }
    public enum BranchOp
    {
        beq = 59,
        beq_s = 46,
        bge = 60,
        bge_s = 47,
        bge_un = 65,
        bge_un_s = 52,
        bgt = 61,
        bgt_s = 48,
        bgt_un = 66,
        bgt_un_s = 53,
        ble = 62,
        ble_s = 49,
        ble_un = 67,
        ble_un_s = 54,
        blt = 63,
        blt_s = 50,
        blt_un = 68,
        blt_un_s = 55,
        bne_un = 64,
        bne_un_s = 51,
        br = 56,
        brfalse = 57,
        brfalse_s = 44,
        brtrue = 58,
        brtrue_s = 45,
        br_s = 43,
        leave = 221,
        leave_s = 222,
    }
    public partial class ByteArrConst : PEAPI.DataConstant
    {
        public ByteArrConst(byte[] val) { }
        public PEAPI.Type Type { get { throw null; } set { } }
    }
    [System.FlagsAttribute]
    public enum CallConv
    {
        Cdecl = 1,
        Default = 0,
        Fastcall = 4,
        Generic = 16,
        Instance = 32,
        InstanceExplicit = 96,
        Stdcall = 2,
        Thiscall = 3,
        Vararg = 5,
    }
    public partial class CalliSig : PEAPI.Signature
    {
        public CalliSig(PEAPI.CallConv cconv, PEAPI.Type retType, PEAPI.Type[] pars) { }
        public void AddCallingConv(PEAPI.CallConv cconv) { }
        public void AddVarArgs(PEAPI.Type[] optPars) { }
    }
    public partial class Catch : PEAPI.HandlerBlock
    {
        public Catch(PEAPI.Class except, PEAPI.CILLabel handlerStart, PEAPI.CILLabel handlerEnd) : base (default(PEAPI.CILLabel), default(PEAPI.CILLabel)) { }
        public Catch(PEAPI.Type except, PEAPI.CILLabel handlerStart, PEAPI.CILLabel handlerEnd) : base (default(PEAPI.CILLabel), default(PEAPI.CILLabel)) { }
    }
    public partial class CharConst : PEAPI.Constant
    {
        public CharConst(char val) { }
    }
    public partial class CILInstructions
    {
        internal CILInstructions() { }
        public uint Offset { get { throw null; } }
        public void AddTryBlock(PEAPI.TryBlock tryBlock) { }
        public void Branch(PEAPI.BranchOp inst, PEAPI.CILLabel lab) { }
        public void calli(PEAPI.CalliSig sig) { }
        public void CodeLabel(PEAPI.CILLabel lab) { }
        public void emitbyte(byte bVal) { }
        public void EndCatchBlock(PEAPI.Class exceptType, PEAPI.TryBlock tryBlock) { }
        public void EndFaultBlock(PEAPI.TryBlock tryBlock) { }
        public void EndFilterBlock(PEAPI.CILLabel filterLab, PEAPI.TryBlock tryBlock) { }
        public void EndFinallyBlock(PEAPI.TryBlock tryBlock) { }
        public PEAPI.TryBlock EndTryBlock() { throw null; }
        public void FieldInst(PEAPI.FieldOp inst, PEAPI.Field f) { }
        public void Inst(PEAPI.Op inst) { }
        public void IntInst(PEAPI.IntOp inst, int val) { }
        public void ldc_i8(long cVal) { }
        public void ldc_r4(float cVal) { }
        public void ldc_r8(double cVal) { }
        public void ldstr(byte[] str) { }
        public void ldstr(string str) { }
        public void LoadArg(int argNo) { }
        public void LoadArgAdr(int argNo) { }
        public void LoadLocal(int locNo) { }
        public void LoadLocalAdr(int locNo) { }
        public void MethInst(PEAPI.MethodOp inst, PEAPI.Method m) { }
        public PEAPI.CILLabel NewCodedLabel() { throw null; }
        public PEAPI.CILLabel NewLabel() { throw null; }
        public void PushFalse() { }
        public void PushInt(int i) { }
        public void PushLong(long l) { }
        public void PushTrue() { }
        public void StartBlock() { }
        public void StoreArg(int argNo) { }
        public void StoreLocal(int locNo) { }
        public void Switch(PEAPI.CILLabel[] labs) { }
        public void TypeInst(PEAPI.TypeOp inst, PEAPI.Type aType) { }
    }
    public partial class CILLabel
    {
        public CILLabel(uint offset) { }
        public CILLabel(uint offset, bool absolute) { }
    }
    public abstract partial class Class : PEAPI.Type
    {
        internal Class() { }
        public string name;
        protected uint nameIx;
        public string nameSpace;
        protected uint nameSpaceIx;
        protected int row;
        protected PEAPI.MetaData _metaData;
    }
    public partial class ClassDef : PEAPI.Class
    {
        internal ClassDef() { }
        public void AddAttribute(PEAPI.TypeAttr ta) { }
        public PEAPI.Event AddEvent(string name, PEAPI.Type eType) { throw null; }
        public PEAPI.FieldDef AddField(PEAPI.FieldAttr fAtts, string name, PEAPI.Type fType) { throw null; }
        public PEAPI.FieldDef AddField(string name, PEAPI.Type fType) { throw null; }
        public PEAPI.GenericParameter AddGenericParameter(short index, string name) { throw null; }
        public PEAPI.GenericParameter AddGenericParameter(short index, string name, PEAPI.GenericParamAttributes attr) { throw null; }
        public void AddImplementedInterface(PEAPI.Class iFace) { }
        public void AddLayoutInfo(int packSize, int classSize) { }
        public PEAPI.MethodDef AddMethod(PEAPI.MethAttr mAtts, PEAPI.ImplAttr iAtts, string name, PEAPI.Param ret_param, PEAPI.Param[] pars) { throw null; }
        public PEAPI.MethodDef AddMethod(string name, PEAPI.Param ret_param, PEAPI.Param[] pars) { throw null; }
        public PEAPI.MethodDef AddMethod(string name, PEAPI.Type retType, PEAPI.Param[] pars) { throw null; }
        public void AddMethodOverride(PEAPI.Method decl, PEAPI.Method body) { }
        public PEAPI.ClassDef AddNestedClass(PEAPI.TypeAttr attrSet, string nsName, string name) { throw null; }
        public PEAPI.ClassDef AddNestedClass(PEAPI.TypeAttr attrSet, string nsName, string name, PEAPI.Class sType) { throw null; }
        public PEAPI.Property AddProperty(string name, PEAPI.Type retType, PEAPI.Type[] pars) { throw null; }
        public void AddSecurity(byte[] permissionSet) { }
        public static bool IsEnum(PEAPI.Class type) { throw null; }
        public static bool IsEnum(string nsName, string name) { throw null; }
        public static bool IsValueType(PEAPI.Class type) { throw null; }
        public static bool IsValueType(string nsName, string name) { throw null; }
        public void SetFieldOrder(System.Collections.ArrayList fields) { }
        public void SpecialNoSuper() { }
    }
    public partial class ClassRef : PEAPI.Class, PEAPI.IExternRef, PEAPI.IResolutionScope
    {
        internal ClassRef() { }
        protected PEAPI.MetaData metaData;
        protected PEAPI.IResolutionScope parent;
        public PEAPI.ClassRef AddClass(string nsName, string name) { throw null; }
        public PEAPI.FieldRef AddField(string name, PEAPI.Type fType) { throw null; }
        public PEAPI.MethodRef AddMethod(string name, PEAPI.Type retType, PEAPI.Type[] pars) { throw null; }
        public PEAPI.MethodRef AddMethod(string name, PEAPI.Type retType, PEAPI.Type[] pars, int gen_param_count) { throw null; }
        public PEAPI.ClassRef AddValueClass(string nsName, string name) { throw null; }
        public PEAPI.MethodRef AddVarArgMethod(string name, PEAPI.Type retType, PEAPI.Type[] pars, PEAPI.Type[] optPars) { throw null; }
    }
    public partial class ClassRefInst : PEAPI.Type
    {
        public ClassRefInst(PEAPI.Type type, bool is_value) { }
    }
    public partial class ClassType : PEAPI.Constant
    {
        public ClassType(PEAPI.Class classDesc) { }
        public ClassType(string className) { }
    }
    public abstract partial class CodeBlock
    {
        protected PEAPI.CILLabel end;
        protected bool small;
        protected PEAPI.CILLabel start;
        public CodeBlock(PEAPI.CILLabel start, PEAPI.CILLabel end) { }
    }
    public abstract partial class Constant
    {
        internal Constant() { }
        protected bool addedToBlobHeap;
        protected uint blobIndex;
        protected uint size;
        protected PEAPI.Type type;
    }
    public enum CorFlags
    {
        CF_32_BITREQUIRED = 2,
        CF_IL_ONLY = 1,
        CF_STRONGNAMESIGNED = 8,
        CF_TRACKDEBUGDATA = 65536,
    }
    public partial class CustomAttribute : PEAPI.MetaDataElement
    {
        internal CustomAttribute() { }
        public void AddFieldOrProp(string name, PEAPI.Constant val) { }
    }
    public partial class CustomMarshaller : PEAPI.NativeType
    {
        public CustomMarshaller(string marshallerName, string optCookie) { }
        public CustomMarshaller(string typeNameOrGUID, string marshallerName, string optCookie) { }
    }
    public partial class CustomModifiedType : PEAPI.Type
    {
        public CustomModifiedType(PEAPI.Type type, PEAPI.CustomModifier cmod, PEAPI.Class cmodType) { }
        public CustomModifiedType(PEAPI.Type type, PEAPI.CustomModifier cmod, PEAPI.PrimitiveTypeRef cmodType) { }
    }
    public enum CustomModifier
    {
        modopt = 32,
        modreq = 31,
    }
    public abstract partial class DataConstant : PEAPI.Constant
    {
        internal DataConstant() { }
        public uint DataOffset { get { throw null; } set { } }
    }
    public enum DataSegment
    {
        CIL = 2,
        Data = 0,
        TLS = 1,
    }
    public partial class DeclSecurity : PEAPI.BaseDeclSecurity
    {
        internal DeclSecurity() { }
    }
    public partial class DeclSecurity_20 : PEAPI.BaseDeclSecurity
    {
        internal DeclSecurity_20() { }
    }
    public partial class DoubleConst : PEAPI.DataConstant
    {
        public DoubleConst(double val) { }
    }
    public partial class Event : PEAPI.Feature
    {
        internal Event() { }
        public void AddAddon(PEAPI.MethodDef addon) { }
        public void AddFire(PEAPI.MethodDef fire) { }
        public void AddOther(PEAPI.MethodDef other) { }
        public void AddRemoveOn(PEAPI.MethodDef removeOn) { }
    }
    public partial class ExternClassRef : PEAPI.ClassRef
    {
        internal ExternClassRef() { }
        public PEAPI.ClassRef AddNestedClass(PEAPI.TypeAttr attrs, string name) { throw null; }
    }
    public partial class Fault : PEAPI.HandlerBlock
    {
        public Fault(PEAPI.CILLabel faultStart, PEAPI.CILLabel faultEnd) : base (default(PEAPI.CILLabel), default(PEAPI.CILLabel)) { }
    }
    public partial class Feature : PEAPI.MetaDataElement
    {
        internal Feature() { }
        protected ushort flags;
        protected PEAPI.MethodSemantics[] methods;
        protected string name;
        protected uint nameIx;
        protected PEAPI.ClassDef parent;
        protected int tide;
        public void SetRTSpecialName() { }
        public void SetSpecialName() { }
    }
    public abstract partial class Field : PEAPI.Member
    {
        internal Field() { }
        protected static readonly byte FieldSig;
        protected PEAPI.Type type;
    }
    public enum FieldAttr
    {
        Assembly = 3,
        Default = 0,
        FamAndAssem = 2,
        Family = 4,
        FamOrAssem = 5,
        HasFieldMarshal = 4096,
        Initonly = 32,
        Literal = 64,
        Notserialized = 128,
        Private = 1,
        Public = 6,
        PublicStatic = 22,
        RTSpecialName = 1024,
        SpecialName = 512,
        Static = 16,
    }
    public partial class FieldDef : PEAPI.Field
    {
        internal FieldDef() { }
        public void AddDataValue(PEAPI.DataConstant val) { }
        public void AddFieldAttr(PEAPI.FieldAttr fa) { }
        public void AddValue(PEAPI.Constant val) { }
        public void SetMarshalInfo(PEAPI.NativeType marshallType) { }
        public void SetOffset(uint offs) { }
    }
    public partial class FieldLayout : PEAPI.MetaDataElement
    {
        internal FieldLayout() { }
    }
    public partial class FieldMarshal : PEAPI.MetaDataElement
    {
        internal FieldMarshal() { }
    }
    public enum FieldOp
    {
        ldfld = 123,
        ldflda = 124,
        ldsfld = 126,
        ldsflda = 127,
        ldtoken = 208,
        stfld = 125,
        stsfld = 128,
    }
    public partial class FieldRef : PEAPI.Field
    {
        internal FieldRef() { }
    }
    public partial class FieldRVA : PEAPI.MetaDataElement
    {
        internal FieldRVA() { }
    }
    public partial class FileRef : PEAPI.MetaDataElement
    {
        internal FileRef() { }
        protected string name;
    }
    public partial class Filter : PEAPI.HandlerBlock
    {
        public Filter(PEAPI.CILLabel filterLabel, PEAPI.CILLabel handlerStart, PEAPI.CILLabel handlerEnd) : base (default(PEAPI.CILLabel), default(PEAPI.CILLabel)) { }
    }
    public partial class Finally : PEAPI.HandlerBlock
    {
        public Finally(PEAPI.CILLabel finallyStart, PEAPI.CILLabel finallyEnd) : base (default(PEAPI.CILLabel), default(PEAPI.CILLabel)) { }
    }
    public partial class FixedArray : PEAPI.NativeType
    {
        public FixedArray(int numElems) { }
    }
    public partial class FixedSysString : PEAPI.NativeType
    {
        public FixedSysString(uint size) { }
    }
    public partial class FloatConst : PEAPI.DataConstant
    {
        public FloatConst(float val) { }
    }
    public partial class GenericMethodSig
    {
        public GenericMethodSig(PEAPI.Type[] gen_param) { }
    }
    [System.FlagsAttribute]
    public enum GenericParamAttributes : ushort
    {
        Contravariant = (ushort)2,
        Covariant = (ushort)1,
        DefaultConstructorConstrait = (ushort)16,
        NonVariant = (ushort)0,
        NotNullableValueTypeConstraint = (ushort)8,
        ReferenceTypeConstraint = (ushort)4,
        SpecialConstraintMask = (ushort)28,
        VarianceMask = (ushort)3,
    }
    public partial class GenericParameter : PEAPI.MetaDataElement
    {
        internal GenericParameter() { }
        public string name;
        public void AddConstraint(PEAPI.Type constraint) { }
    }
    public partial class GenericTypeInst : PEAPI.Class
    {
        public GenericTypeInst(PEAPI.Type gen_type, PEAPI.Type[] gen_param) { }
    }
    public partial class GenParam : PEAPI.Class
    {
        public GenParam(int index, string name, PEAPI.GenParamType ptype) { }
        public int Index { get { throw null; } set { } }
        public string Name { get { throw null; } set { } }
        public PEAPI.GenParamType Type { get { throw null; } }
    }
    public enum GenParamType : byte
    {
        MVar = (byte)30,
        Var = (byte)19,
    }
    public abstract partial class HandlerBlock : PEAPI.CodeBlock
    {
        protected static readonly short ExceptionFlag;
        protected static readonly short FaultFlag;
        protected static readonly short FilterFlag;
        protected static readonly short FinallyFlag;
        public HandlerBlock(PEAPI.CILLabel start, PEAPI.CILLabel end) : base (default(PEAPI.CILLabel), default(PEAPI.CILLabel)) { }
    }
    public enum HashAlgorithm
    {
        None = 0,
        SHA1 = 1,
    }
    public partial class Hex
    {
        public Hex() { }
        public static string Byte(int b) { throw null; }
        public static string Int(int val) { throw null; }
        public static string Int(uint num) { throw null; }
        public static string Long(long lnum) { throw null; }
        public static string Short(int b) { throw null; }
    }
    public partial interface IExternRef
    {
        PEAPI.ClassRef AddClass(string nsName, string name);
        PEAPI.ClassRef AddValueClass(string nsName, string name);
    }
    public enum ImplAttr
    {
        AggressiveInlining = 256,
        ForwardRef = 16,
        IL = 0,
        InternalCall = 4096,
        Native = 1,
        NoInLining = 8,
        NoOptimization = 64,
        Optil = 2,
        PreserveSig = 128,
        Runtime = 3,
        Synchronised = 32,
        Synchronized = 32,
        Unmanaged = 4,
    }
    public partial class ImplMap : PEAPI.MetaDataElement
    {
        internal ImplMap() { }
    }
    public partial class IntConst : PEAPI.DataConstant
    {
        public IntConst(short val) { }
        public IntConst(int val) { }
        public IntConst(long val) { }
        public IntConst(sbyte val) { }
    }
    public partial class InterfaceImpl : PEAPI.MetaDataElement
    {
        internal InterfaceImpl() { }
    }
    public enum IntOp
    {
        ldarg = 65033,
        ldarga = 65034,
        ldarga_s = 15,
        ldarg_s = 14,
        ldc_i4 = 32,
        ldc_i4_s = 31,
        ldloc = 65036,
        ldloca = 65037,
        ldloca_s = 18,
        ldloc_s = 17,
        starg = 65035,
        starg_s = 16,
        stloc = 65038,
        stloc_s = 19,
        unaligned = 65042,
    }
    public partial interface IResolutionScope
    {
    }
    public partial class Local
    {
        public Local(string lName, PEAPI.Type lType) { }
        public Local(string lName, PEAPI.Type lType, bool byRef, bool isPinned) { }
    }
    public partial class LocalSig : PEAPI.Signature
    {
        public LocalSig(PEAPI.Local[] locals) { }
    }
    public partial class ManagedPointer : PEAPI.PtrType
    {
        public ManagedPointer(PEAPI.Type baseType) { }
    }
    public partial class ManifestResource : PEAPI.MetaDataElement
    {
        public static readonly uint PrivateResource;
        public static readonly uint PublicResource;
        public ManifestResource(string name, byte[] resBytes, uint flags) { }
        public ManifestResource(string name, uint flags, PEAPI.AssemblyRef assemRef) { }
        public ManifestResource(string name, uint flags, PEAPI.FileRef fileRef) { }
        public ManifestResource(string name, uint flags, PEAPI.FileRef fileRef, uint fileIx) { }
        public string Name { get { throw null; } set { } }
    }
    public partial class MapElem : PEAPI.MetaDataElement
    {
        internal MapElem() { }
    }
    public enum MDTable
    {
        Assembly = 32,
        AssemblyOS = 34,
        AssemblyProcessor = 33,
        AssemblyRef = 35,
        AssemblyRefOS = 37,
        AssemblyRefProcessor = 36,
        ClassLayout = 15,
        Constant = 11,
        CustomAttribute = 12,
        DeclSecurity = 14,
        Event = 20,
        EventMap = 18,
        ExportedType = 39,
        Field = 4,
        FieldLayout = 16,
        FieldMarshal = 13,
        FieldRVA = 29,
        File = 38,
        GenericParam = 42,
        GenericParamConstraint = 44,
        ImplMap = 28,
        InterfaceImpl = 9,
        ManifestResource = 40,
        MemberRef = 10,
        Method = 6,
        MethodImpl = 25,
        MethodSemantics = 24,
        MethodSpec = 43,
        Module = 0,
        ModuleRef = 26,
        NestedClass = 41,
        Param = 8,
        Property = 23,
        PropertyMap = 21,
        StandAloneSig = 17,
        TypeDef = 2,
        TypeRef = 1,
        TypeSpec = 27,
    }
    public abstract partial class Member : PEAPI.MetaDataElement
    {
        internal Member() { }
        protected string name;
        protected uint nameIx;
        protected uint sigIx;
    }
    public partial class MetaData
    {
        internal MetaData() { }
        public PEAPI.MSCorLib mscorlib { get { throw null; } }
    }
    public abstract partial class MetaDataElement : System.IComparable
    {
        internal MetaDataElement() { }
        protected System.Collections.ArrayList customAttributes;
        protected bool done;
        protected bool sortTable;
        protected PEAPI.MDTable tabIx;
        public bool HasCustomAttr { get { throw null; } set { } }
        public uint Row { get { throw null; } set { } }
        public void AddCustomAttribute(PEAPI.Method ctorMeth, PEAPI.Constant[] cVals) { }
        public void AddCustomAttribute(PEAPI.Method ctorMeth, byte[] val) { }
        public int CompareTo(object obj) { throw null; }
    }
    public enum MethAttr
    {
        Abstract = 1024,
        Assembly = 3,
        Default = 0,
        FamAndAssem = 2,
        Family = 4,
        FamOrAssem = 5,
        Final = 32,
        HasSecurity = 16384,
        HideBySig = 128,
        NewSlot = 256,
        Private = 1,
        PrivateVirtual = 65,
        Public = 6,
        PublicStatic = 22,
        PublicStaticFinal = 54,
        PublicVirtual = 70,
        RequireSecObject = 32768,
        RTSpecialName = 4096,
        SpecialName = 2048,
        SpecialRTSpecialName = 6144,
        Static = 16,
        Strict = 512,
        Virtual = 64,
    }
    public abstract partial class Method : PEAPI.Member
    {
        internal Method() { }
        public abstract void AddCallConv(PEAPI.CallConv cconv);
    }
    public partial class MethodDef : PEAPI.Method
    {
        internal MethodDef() { }
        public override void AddCallConv(PEAPI.CallConv cconv) { }
        public PEAPI.GenericParameter AddGenericParameter(short index, string name) { throw null; }
        public PEAPI.GenericParameter AddGenericParameter(short index, string name, PEAPI.GenericParamAttributes attr) { throw null; }
        public void AddImplAttribute(PEAPI.ImplAttr ia) { }
        public void AddLocals(PEAPI.Local[] locals, bool initLocals) { }
        public void AddMethAttribute(PEAPI.MethAttr ma) { }
        public void AddPInvokeInfo(PEAPI.ModuleRef scope, string methName, PEAPI.PInvokeAttr callAttr) { }
        public void AddRetTypeMarshallInfo(PEAPI.NativeType marshallType) { }
        public PEAPI.CILInstructions CreateCodeBuffer() { throw null; }
        public void DeclareEntryPoint() { }
        public PEAPI.MethodRef MakeVarArgSignature(PEAPI.Type[] optPars) { throw null; }
        public void SetMaxStack(int maxStack) { }
    }
    public partial class MethodImpl : PEAPI.MetaDataElement
    {
        internal MethodImpl() { }
    }
    public enum MethodOp
    {
        call = 40,
        callvirt = 111,
        jmp = 39,
        ldftn = 65030,
        ldtoken = 208,
        ldvirtfn = 65031,
        newobj = 115,
    }
    public partial class MethodRef : PEAPI.Method
    {
        internal MethodRef() { }
        public override void AddCallConv(PEAPI.CallConv cconv) { }
    }
    public partial class MethodSemantics : PEAPI.MetaDataElement
    {
        internal MethodSemantics() { }
    }
    public partial class MethPtrType : PEAPI.Type
    {
        public MethPtrType(PEAPI.CallConv callconv, PEAPI.Type retType, PEAPI.Type[] pars, bool varArgMeth, PEAPI.Type[] optPars) { }
    }
    public partial class Module : PEAPI.ResolutionScope, PEAPI.IExternRef
    {
        internal Module() { }
        public System.Guid Guid { get { throw null; } }
        public PEAPI.ClassRef AddClass(string nsName, string name) { throw null; }
        public PEAPI.ClassRef AddValueClass(string nsName, string name) { throw null; }
    }
    public partial class ModuleRef : PEAPI.ResolutionScope, PEAPI.IExternRef
    {
        internal ModuleRef() { }
        public PEAPI.ClassRef AddClass(string nsName, string name) { throw null; }
        public PEAPI.ExternClassRef AddExternClass(PEAPI.TypeAttr attrSet, string nsName, string name, PEAPI.FileRef declFile, bool isValueClass) { throw null; }
        public PEAPI.FieldRef AddField(string name, PEAPI.Type fType) { throw null; }
        public PEAPI.MethodRef AddMethod(string name, PEAPI.Type retType, PEAPI.Type[] pars) { throw null; }
        public PEAPI.ClassRef AddValueClass(string nsName, string name) { throw null; }
        public PEAPI.MethodRef AddVarArgMethod(string name, PEAPI.Type retType, PEAPI.Type[] pars, PEAPI.Type[] optPars) { throw null; }
        public PEAPI.FileRef MakeFile(byte[] hashBytes, bool hasMetaData, bool entryPoint) { throw null; }
    }
    public sealed partial class MSCorLib : PEAPI.AssemblyRef
    {
        internal MSCorLib() { }
        public override PEAPI.ClassRef AddClass(string nsName, string name) { throw null; }
        public override PEAPI.ClassRef AddValueClass(string nsName, string name) { throw null; }
    }
    public partial class NativeArray : PEAPI.NativeType
    {
        public NativeArray(PEAPI.NativeType elemType) { }
        public NativeArray(PEAPI.NativeType elemType, int numElem, int parNumForLen) { }
        public NativeArray(PEAPI.NativeType elemType, int numElem, int parNumForLen, int elemMult) { }
    }
    public partial class NativeType
    {
        internal NativeType() { }
        public static readonly PEAPI.NativeType AnsiBStr;
        public static readonly PEAPI.NativeType AsAny;
        public static readonly PEAPI.NativeType Boolean;
        public static readonly PEAPI.NativeType BStr;
        public static readonly PEAPI.NativeType ByValStr;
        public static readonly PEAPI.NativeType Currency;
        public static readonly PEAPI.NativeType Error;
        public static readonly PEAPI.NativeType FixedSysString;
        public static readonly PEAPI.NativeType Float32;
        public static readonly PEAPI.NativeType Float64;
        public static readonly PEAPI.NativeType FuncPtr;
        public static readonly PEAPI.NativeType IDispatch;
        public static readonly PEAPI.NativeType Int;
        public static readonly PEAPI.NativeType Int16;
        public static readonly PEAPI.NativeType Int32;
        public static readonly PEAPI.NativeType Int64;
        public static readonly PEAPI.NativeType Int8;
        public static readonly PEAPI.NativeType Interface;
        public static readonly PEAPI.NativeType IUnknown;
        public static readonly PEAPI.NativeType LPStr;
        public static readonly PEAPI.NativeType LPStruct;
        public static readonly PEAPI.NativeType LPTStr;
        public static readonly PEAPI.NativeType LPWStr;
        public static readonly PEAPI.NativeType Struct;
        public static readonly PEAPI.NativeType TBstr;
        protected byte typeIndex;
        public static readonly PEAPI.NativeType UInt;
        public static readonly PEAPI.NativeType UInt16;
        public static readonly PEAPI.NativeType UInt32;
        public static readonly PEAPI.NativeType UInt64;
        public static readonly PEAPI.NativeType UInt8;
        public static readonly PEAPI.NativeType VariantBool;
        public static readonly PEAPI.NativeType Void;
    }
    public partial class NotYetImplementedException : System.Exception
    {
        public NotYetImplementedException(string msg) { }
    }
    public partial class NullConst : PEAPI.Constant
    {
        public NullConst() { }
    }
    public enum Op
    {
        add = 88,
        add_ovf = 214,
        add_ovf_un = 215,
        and = 95,
        arglist = 65024,
        breakOp = 1,
        ceq = 65025,
        cgt = 65026,
        cgt_un = 65027,
        ckfinite = 195,
        clt = 65028,
        clt_un = 65029,
        conf_ovf_u1_un = 134,
        conv_i = 211,
        conv_i1 = 103,
        conv_i2 = 104,
        conv_i4 = 105,
        conv_i8 = 106,
        conv_ovf_i = 212,
        conv_ovf_i1 = 179,
        conv_ovf_i1_un = 130,
        conv_ovf_i2 = 181,
        conv_ovf_i2_un = 131,
        conv_ovf_i4 = 183,
        conv_ovf_i4_un = 132,
        conv_ovf_i8 = 185,
        conv_ovf_i8_un = 133,
        conv_ovf_i_un = 138,
        conv_ovf_u = 213,
        conv_ovf_u1 = 180,
        conv_ovf_u2 = 182,
        conv_ovf_u2_un = 135,
        conv_ovf_u4 = 184,
        conv_ovf_u4_un = 136,
        conv_ovf_u8 = 186,
        conv_ovf_u8_un = 137,
        conv_ovf_u_un = 139,
        conv_r4 = 107,
        conv_r8 = 108,
        conv_r_un = 118,
        conv_u = 224,
        conv_u1 = 210,
        conv_u2 = 209,
        conv_u4 = 109,
        conv_u8 = 110,
        cpblk = 65047,
        div = 91,
        div_un = 92,
        dup = 37,
        endfilter = 65041,
        endfinally = 220,
        initblk = 65048,
        ldarg_0 = 2,
        ldarg_1 = 3,
        ldarg_2 = 4,
        ldarg_3 = 5,
        ldc_i4_0 = 22,
        ldc_i4_1 = 23,
        ldc_i4_2 = 24,
        ldc_i4_3 = 25,
        ldc_i4_4 = 26,
        ldc_i4_5 = 27,
        ldc_i4_6 = 28,
        ldc_i4_7 = 29,
        ldc_i4_8 = 30,
        ldc_i4_m1 = 21,
        ldelem_i = 151,
        ldelem_i1 = 144,
        ldelem_i2 = 146,
        ldelem_i4 = 148,
        ldelem_i8 = 150,
        ldelem_r4 = 152,
        ldelem_r8 = 153,
        ldelem_ref = 154,
        ldelem_u1 = 145,
        ldelem_u2 = 147,
        ldelem_u4 = 149,
        ldind_i = 77,
        ldind_i1 = 70,
        ldind_i2 = 72,
        ldind_i4 = 74,
        ldind_i8 = 76,
        ldind_r4 = 78,
        ldind_r8 = 79,
        ldind_ref = 80,
        ldind_u1 = 71,
        ldind_u2 = 73,
        ldind_u4 = 75,
        ldlen = 142,
        ldloc_0 = 6,
        ldloc_1 = 7,
        ldloc_2 = 8,
        ldloc_3 = 9,
        ldnull = 20,
        localloc = 65039,
        mul = 90,
        mul_ovf = 216,
        mul_ovf_un = 217,
        neg = 101,
        nop = 0,
        not = 102,
        or = 96,
        pop = 38,
        readonly_ = 65054,
        refanytype = 65053,
        rem = 93,
        rem_un = 94,
        ret = 42,
        rethrow = 65050,
        shl = 98,
        shr = 99,
        shr_un = 100,
        stelem_i = 155,
        stelem_i1 = 156,
        stelem_i2 = 157,
        stelem_i4 = 158,
        stelem_i8 = 159,
        stelem_r4 = 160,
        stelem_r8 = 161,
        stelem_ref = 162,
        stind_i = 223,
        stind_i1 = 82,
        stind_i2 = 83,
        stind_i4 = 84,
        stind_i8 = 85,
        stind_r4 = 86,
        stind_r8 = 87,
        stind_ref = 81,
        stloc_0 = 10,
        stloc_1 = 11,
        stloc_2 = 12,
        stloc_3 = 13,
        sub = 89,
        sub_ovf = 218,
        sub_ovf_un = 219,
        tail_ = 65044,
        throwOp = 122,
        volatile_ = 65043,
        xor = 97,
    }
    public partial class Param : PEAPI.MetaDataElement
    {
        public Param(PEAPI.ParamAttr mode, string parName, PEAPI.Type parType) { }
        public bool HasMarshalInfo { get { throw null; } }
        public void AddDefaultValue(PEAPI.Constant cVal) { }
        public void AddMarshallInfo(PEAPI.NativeType marshallType) { }
    }
    public enum ParamAttr
    {
        Default = 0,
        HasDefault = 4096,
        HasFieldMarshal = 8192,
        In = 1,
        Opt = 16,
        Out = 2,
    }
    public partial class PEFile
    {
        public PEFile(string name, bool isDLL, bool hasAssembly) { }
        public PEFile(string name, bool isDLL, bool hasAssembly, System.IO.Stream outStream) { }
        public PEFile(string name, bool isDLL, bool hasAssembly, string outputDir) { }
        public PEFile(string name, string module_name, bool isDLL, bool hasAssembly, System.IO.Stream outStream) { }
        public PEFile(string name, string module_name, bool isDLL, bool hasAssembly, string outputDir, System.IO.Stream outStream) { }
        public PEAPI.ClassDef ModuleClass { get { throw null; } }
        public PEAPI.ClassDef AddClass(PEAPI.TypeAttr attrSet, string nsName, string name) { throw null; }
        public PEAPI.ClassDef AddClass(PEAPI.TypeAttr attrSet, string nsName, string name, PEAPI.Class superType) { throw null; }
        public void AddCustomAttribute(PEAPI.Method meth, PEAPI.Constant constant, PEAPI.MetaDataElement element) { }
        public void AddCustomAttribute(PEAPI.Method meth, byte[] data, PEAPI.MetaDataElement element) { }
        public void AddDeclSecurity(PEAPI.SecurityAction sec_action, PEAPI.PermissionSet ps, PEAPI.MetaDataElement element) { }
        public void AddDeclSecurity(PEAPI.SecurityAction sec_action, byte[] data, PEAPI.MetaDataElement element) { }
        public void AddExternalManagedResource(PEAPI.ManifestResource mr) { }
        public void AddExternalManagedResource(string resName, PEAPI.AssemblyRef assem, uint flags) { }
        public PEAPI.AssemblyRef AddExternAssembly(string assemName) { throw null; }
        public PEAPI.ClassRef AddExternClass(string ns, string name, PEAPI.TypeAttr attrs, PEAPI.MetaDataElement declRef) { throw null; }
        public PEAPI.ModuleRef AddExternModule(string name) { throw null; }
        public PEAPI.FieldDef AddField(PEAPI.FieldAttr attrSet, string name, PEAPI.Type fType) { throw null; }
        public PEAPI.FieldDef AddField(string name, PEAPI.Type fType) { throw null; }
        public PEAPI.FieldRef AddFieldToTypeSpec(PEAPI.Type item, string name, PEAPI.Type fType) { throw null; }
        public PEAPI.FileRef AddFile(string fName, byte[] hashBytes, bool hasMetaData, bool entryPoint) { throw null; }
        public void AddGenericClass(PEAPI.GenericTypeInst gti) { }
        public void AddGenericParam(PEAPI.GenParam param) { }
        public void AddManifestResource(PEAPI.ManifestResource mr) { }
        public PEAPI.MethodDef AddMethod(PEAPI.MethAttr mAtts, PEAPI.ImplAttr iAtts, string name, PEAPI.Param ret_param, PEAPI.Param[] pars) { throw null; }
        public PEAPI.MethodDef AddMethod(PEAPI.MethAttr mAtts, PEAPI.ImplAttr iAtts, string name, PEAPI.Type retType, PEAPI.Param[] pars) { throw null; }
        public PEAPI.MethodDef AddMethod(string name, PEAPI.Param ret_param, PEAPI.Param[] pars) { throw null; }
        public PEAPI.MethodDef AddMethod(string name, PEAPI.Type retType, PEAPI.Param[] pars) { throw null; }
        public PEAPI.Method AddMethodSpec(PEAPI.Method m, PEAPI.GenericMethodSig g_sig) { throw null; }
        public PEAPI.MethodRef AddMethodToTypeSpec(PEAPI.Type item, string name, PEAPI.Type retType, PEAPI.Type[] pars) { throw null; }
        public PEAPI.MethodRef AddMethodToTypeSpec(PEAPI.Type item, string name, PEAPI.Type retType, PEAPI.Type[] pars, int gen_param_count) { throw null; }
        public PEAPI.PrimitiveTypeRef AddPrimitiveType(PEAPI.PrimitiveType type) { throw null; }
        public PEAPI.ClassDef AddValueClass(PEAPI.TypeAttr attrSet, string nsName, string name, PEAPI.ValueClass vClass) { throw null; }
        public PEAPI.MethodRef AddVarArgMethodToTypeSpec(PEAPI.Type item, string name, PEAPI.Type retType, PEAPI.Type[] pars, PEAPI.Type[] optPars) { throw null; }
        public PEAPI.ManifestResource GetResource(string name) { throw null; }
        public PEAPI.ManifestResource[] GetResources() { throw null; }
        public PEAPI.Assembly GetThisAssembly() { throw null; }
        public PEAPI.Module GetThisModule() { throw null; }
        public void SetCorFlags(int flags) { }
        public void SetStackReserve(long stackReserve) { }
        public void SetSubSystem(PEAPI.SubSystem subS) { }
        public void WritePEFile() { }
    }
    public partial class PEFileException : System.Exception
    {
        public PEFileException(string msg) { }
    }
    public partial class Permission
    {
        public Permission(PEAPI.Type type, string name) { }
        public void AddMember(PEAPI.PermissionMember member) { }
        public void Write(System.IO.BinaryWriter bw) { }
    }
    public partial class PermissionMember
    {
        public PermissionMember(System.Reflection.MemberTypes member_type, PEAPI.Type type, string name, object value) { }
        public void Write(System.IO.BinaryWriter bw) { }
    }
    public partial class PermissionSet
    {
        public PermissionSet(PEAPI.SecurityAction sec_action) { }
        public void AddPermission(PEAPI.Permission perm) { }
        public void Write(System.IO.BinaryWriter bw) { }
    }
    public enum PInvokeAttr
    {
        ansi = 2,
        autochar = 6,
        bestfit_mask = 48,
        bestfit_off = 32,
        bestfit_on = 16,
        cdecl = 512,
        charmaperror_off = 8192,
        charmaperror_on = 4096,
        fastcall = 1280,
        lasterr = 64,
        nomangle = 1,
        stdcall = 768,
        thiscall = 1024,
        unicode = 4,
        winapi = 256,
    }
    public partial class PrimitiveType : PEAPI.Type
    {
        internal PrimitiveType() { }
        public static readonly PEAPI.PrimitiveType Boolean;
        public static readonly PEAPI.PrimitiveType Char;
        public static readonly PEAPI.PrimitiveType Float32;
        public static readonly PEAPI.PrimitiveType Float64;
        public static readonly PEAPI.PrimitiveType Int16;
        public static readonly PEAPI.PrimitiveType Int32;
        public static readonly PEAPI.PrimitiveType Int64;
        public static readonly PEAPI.PrimitiveType Int8;
        public static readonly PEAPI.PrimitiveType IntPtr;
        public static readonly PEAPI.PrimitiveType NativeInt;
        public static readonly PEAPI.PrimitiveType NativeUInt;
        public static int NumSystemTypes;
        public static readonly PEAPI.PrimitiveType Object;
        public static readonly PEAPI.PrimitiveType String;
        public static readonly PEAPI.PrimitiveType TypedRef;
        public static readonly PEAPI.PrimitiveType UInt16;
        public static readonly PEAPI.PrimitiveType UInt32;
        public static readonly PEAPI.PrimitiveType UInt64;
        public static readonly PEAPI.PrimitiveType UInt8;
        public static readonly PEAPI.PrimitiveType UIntPtr;
        public static readonly PEAPI.PrimitiveType Void;
    }
    public partial class PrimitiveTypeRef : PEAPI.Type
    {
        internal PrimitiveTypeRef() { }
    }
    public partial class Property : PEAPI.Feature
    {
        internal Property() { }
        public void AddGetter(PEAPI.MethodDef getter) { }
        public void AddInitValue(PEAPI.Constant constVal) { }
        public void AddOther(PEAPI.MethodDef other) { }
        public void AddSetter(PEAPI.MethodDef setter) { }
        public void SetInstance(bool isInstance) { }
    }
    public abstract partial class PtrType : PEAPI.Type
    {
        internal PtrType() { }
    }
    public partial class RepeatedConstant : PEAPI.DataConstant
    {
        public RepeatedConstant(PEAPI.DataConstant dConst, int repeatCount) { }
    }
    public abstract partial class ResolutionScope : PEAPI.MetaDataElement, PEAPI.IResolutionScope
    {
        internal ResolutionScope() { }
        protected PEAPI.MetaData metaData;
        protected string name;
        protected uint nameIx;
    }
    public partial class SafeArray : PEAPI.NativeType
    {
        public SafeArray() { }
        public SafeArray(PEAPI.SafeArrayType elemType) { }
    }
    public enum SafeArrayType
    {
        boolean = 11,
        bstr = 8,
        currency = 6,
        date = 7,
        Decimal = 14,
        dispatch = 9,
        error = 10,
        float32 = 4,
        float64 = 5,
        Int = 22,
        int16 = 2,
        int32 = 3,
        int8 = 16,
        UInt = 23,
        uint16 = 18,
        uint32 = 19,
        uint8 = 17,
        unknown = 13,
        variant = 12,
    }
    public enum SecurityAction : short
    {
        Assert = (short)3,
        Demand = (short)2,
        DemandChoice = (short)18,
        Deny = (short)4,
        InheritDemand = (short)7,
        InheritDemandChoice = (short)17,
        LinkDemand = (short)6,
        LinkDemandChoice = (short)16,
        NonCasDemand = (short)13,
        NonCasInheritance = (short)15,
        NonCasLinkDemand = (short)14,
        PermitOnly = (short)5,
        PreJitDeny = (short)12,
        PreJitGrant = (short)11,
        Request = (short)1,
        RequestMinimum = (short)8,
        RequestOptional = (short)9,
        RequestRefuse = (short)10,
    }
    public partial class Sentinel : PEAPI.Type
    {
        public Sentinel() { }
    }
    public abstract partial class Signature : PEAPI.MetaDataElement
    {
        internal Signature() { }
        protected uint sigIx;
    }
    public partial class StringConst : PEAPI.DataConstant
    {
        public StringConst(string val) { }
    }
    public enum SubSystem
    {
        Native = 1,
        Native_Windows = 8,
        OS2_CUI = 5,
        POSIX_CUI = 7,
        Windows_CE_GUI = 9,
        Windows_CUI = 3,
        Windows_GUI = 2,
    }
    public partial class TryBlock : PEAPI.CodeBlock
    {
        protected bool fatFormat;
        protected int flags;
        public TryBlock(PEAPI.CILLabel start, PEAPI.CILLabel end) : base (default(PEAPI.CILLabel), default(PEAPI.CILLabel)) { }
        public void AddHandler(PEAPI.HandlerBlock handler) { }
    }
    public abstract partial class Type : PEAPI.MetaDataElement
    {
        internal Type() { }
        protected byte typeIndex;
        protected PEAPI.TypeSpec typeSpec;
    }
    [System.FlagsAttribute]
    public enum TypeAttr
    {
        Abstract = 128,
        AutoClass = 131072,
        BeforeFieldInit = 1048576,
        ExplicitLayout = 16,
        Forwarder = 2097152,
        HasSecurity = 262144,
        Import = 4096,
        Interface = 32,
        NestedAssembly = 5,
        NestedFamAndAssem = 6,
        NestedFamily = 4,
        NestedFamOrAssem = 7,
        NestedPrivate = 3,
        NestedPublic = 2,
        Private = 0,
        Public = 1,
        PublicAbstract = 129,
        PublicSealed = 257,
        RTSpecialName = 2048,
        Sealed = 256,
        SequentialLayout = 8,
        Serializable = 8192,
        SpecialName = 1024,
        UnicodeClass = 65536,
        VisibilityMask = 7,
    }
    public enum TypeOp
    {
        box = 140,
        castclass = 116,
        constrained = 65046,
        cpobj = 112,
        initobj = 65045,
        isinst = 117,
        ldelem = 163,
        ldelema = 143,
        ldobj = 113,
        ldtoken = 208,
        mkrefany = 198,
        newarr = 141,
        refanyval = 194,
        sizeOf = 65052,
        stelem = 164,
        stobj = 129,
        unbox = 121,
        unbox_any = 165,
    }
    public partial class TypeSignatureException : System.Exception
    {
        public TypeSignatureException(string msg) { }
    }
    public partial class TypeSpec : PEAPI.MetaDataElement
    {
        internal TypeSpec() { }
    }
    public partial class UIntConst : PEAPI.DataConstant
    {
        public UIntConst(byte val) { }
        public UIntConst(ushort val) { }
        public UIntConst(uint val) { }
        public UIntConst(ulong val) { }
    }
    public partial class UnmanagedPointer : PEAPI.PtrType
    {
        public UnmanagedPointer(PEAPI.Type baseType) { }
    }
    public enum ValueClass
    {
        Enum = 1,
        ValueType = 0,
    }
    public partial class ZeroBasedArray : PEAPI.Array
    {
        public ZeroBasedArray(PEAPI.Type elementType) { }
    }
}
