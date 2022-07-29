// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

[assembly:System.Reflection.AssemblyVersionAttribute("0.11.1.0")]
[assembly:System.Diagnostics.DebuggableAttribute(System.Diagnostics.DebuggableAttribute.DebuggingModes.IgnoreSymbolStoreSequencePoints)]
[assembly:System.Reflection.AssemblyCopyrightAttribute("Copyright © 2008 - 2018 Jb Evain")]
[assembly:System.Reflection.AssemblyFileVersionAttribute("0.11.1.0")]
[assembly:System.Reflection.AssemblyInformationalVersionAttribute("0.11.1.0")]
[assembly:System.Reflection.AssemblyProductAttribute("Mono.Cecil")]
[assembly:System.Reflection.AssemblyTitleAttribute("Mono.Cecil")]
[assembly:System.Runtime.CompilerServices.CompilationRelaxationsAttribute(8)]
[assembly:System.Runtime.CompilerServices.InternalsVisibleToAttribute("Mono.Cecil.Mdb, PublicKey=002400000480000094000000060200000024000052534131000400000100010079159977d2d03a8e6bea7a2e74e8d1afcc93e8851974952bb480a12c9134474d04062447c37e0e68c080536fcf3c3fbe2ff9c979ce998475e506e8ce82dd5b0f350dc10e93bf2eeecf874b24770c5081dbea7447fddafa277b22de47d6ffea449674a4f9fccf84d15069089380284dbdd35f46cdff12a1bd78e4ef0065d016df")]
[assembly:System.Runtime.CompilerServices.InternalsVisibleToAttribute("Mono.Cecil.Pdb, PublicKey=002400000480000094000000060200000024000052534131000400000100010079159977d2d03a8e6bea7a2e74e8d1afcc93e8851974952bb480a12c9134474d04062447c37e0e68c080536fcf3c3fbe2ff9c979ce998475e506e8ce82dd5b0f350dc10e93bf2eeecf874b24770c5081dbea7447fddafa277b22de47d6ffea449674a4f9fccf84d15069089380284dbdd35f46cdff12a1bd78e4ef0065d016df")]
[assembly:System.Runtime.CompilerServices.InternalsVisibleToAttribute("Mono.Cecil.Rocks, PublicKey=002400000480000094000000060200000024000052534131000400000100010079159977d2d03a8e6bea7a2e74e8d1afcc93e8851974952bb480a12c9134474d04062447c37e0e68c080536fcf3c3fbe2ff9c979ce998475e506e8ce82dd5b0f350dc10e93bf2eeecf874b24770c5081dbea7447fddafa277b22de47d6ffea449674a4f9fccf84d15069089380284dbdd35f46cdff12a1bd78e4ef0065d016df")]
[assembly:System.Runtime.CompilerServices.InternalsVisibleToAttribute("Mono.Cecil.Tests, PublicKey=002400000480000094000000060200000024000052534131000400000100010079159977d2d03a8e6bea7a2e74e8d1afcc93e8851974952bb480a12c9134474d04062447c37e0e68c080536fcf3c3fbe2ff9c979ce998475e506e8ce82dd5b0f350dc10e93bf2eeecf874b24770c5081dbea7447fddafa277b22de47d6ffea449674a4f9fccf84d15069089380284dbdd35f46cdff12a1bd78e4ef0065d016df")]
[assembly:System.Runtime.CompilerServices.RuntimeCompatibilityAttribute(WrapNonExceptionThrows=true)]
[assembly:System.Runtime.InteropServices.ComVisibleAttribute(false)]
[assembly:System.Runtime.InteropServices.GuidAttribute("fd225bb4-fa53-44b2-a6db-85f5e48dcb54")]
[assembly:System.Security.Permissions.SecurityPermissionAttribute(System.Security.Permissions.SecurityAction.RequestMinimum, SkipVerification=true)]
namespace Mono.Cecil
{
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public partial struct ArrayDimension
    {
        private int _dummyPrimitive;
        public ArrayDimension(System.Nullable<int> lowerBound, System.Nullable<int> upperBound) { throw null; }
        public bool IsSized { get { throw null; } }
        public System.Nullable<int> LowerBound { get { throw null; } set { } }
        public System.Nullable<int> UpperBound { get { throw null; } set { } }
        public override string ToString() { throw null; }
    }
    public sealed partial class ArrayMarshalInfo : Mono.Cecil.MarshalInfo
    {
        public ArrayMarshalInfo() : base (default(Mono.Cecil.NativeType)) { }
        public Mono.Cecil.NativeType ElementType { get { throw null; } set { } }
        public int Size { get { throw null; } set { } }
        public int SizeParameterIndex { get { throw null; } set { } }
        public int SizeParameterMultiplier { get { throw null; } set { } }
    }
    public sealed partial class ArrayType : Mono.Cecil.TypeSpecification
    {
        public ArrayType(Mono.Cecil.TypeReference type) { }
        public ArrayType(Mono.Cecil.TypeReference type, int rank) { }
        public Mono.Collections.Generic.Collection<Mono.Cecil.ArrayDimension> Dimensions { get { throw null; } }
        public override string FullName { get { throw null; } }
        public override bool IsArray { get { throw null; } }
        public override bool IsValueType { get { throw null; } set { } }
        public bool IsVector { get { throw null; } }
        public override string Name { get { throw null; } }
        public int Rank { get { throw null; } }
    }
    [System.FlagsAttribute]
    public enum AssemblyAttributes : uint
    {
        DisableJITCompileOptimizer = (uint)16384,
        EnableJITCompileTracking = (uint)32768,
        PublicKey = (uint)1,
        Retargetable = (uint)256,
        SideBySideCompatible = (uint)0,
        WindowsRuntime = (uint)512,
    }
    public sealed partial class AssemblyDefinition : Mono.Cecil.ICustomAttributeProvider, Mono.Cecil.IMetadataTokenProvider, Mono.Cecil.ISecurityDeclarationProvider, System.IDisposable
    {
        internal AssemblyDefinition() { }
        public Mono.Collections.Generic.Collection<Mono.Cecil.CustomAttribute> CustomAttributes { get { throw null; } }
        public Mono.Cecil.MethodDefinition EntryPoint { get { throw null; } set { } }
        public string FullName { get { throw null; } }
        public bool HasCustomAttributes { get { throw null; } }
        public bool HasSecurityDeclarations { get { throw null; } }
        public Mono.Cecil.ModuleDefinition MainModule { get { throw null; } }
        public Mono.Cecil.MetadataToken MetadataToken { get { throw null; } set { } }
        public Mono.Collections.Generic.Collection<Mono.Cecil.ModuleDefinition> Modules { get { throw null; } }
        public Mono.Cecil.AssemblyNameDefinition Name { get { throw null; } set { } }
        public Mono.Collections.Generic.Collection<Mono.Cecil.SecurityDeclaration> SecurityDeclarations { get { throw null; } }
        public static Mono.Cecil.AssemblyDefinition CreateAssembly(Mono.Cecil.AssemblyNameDefinition assemblyName, string moduleName, Mono.Cecil.ModuleKind kind) { throw null; }
        public static Mono.Cecil.AssemblyDefinition CreateAssembly(Mono.Cecil.AssemblyNameDefinition assemblyName, string moduleName, Mono.Cecil.ModuleParameters parameters) { throw null; }
        public void Dispose() { }
        public static Mono.Cecil.AssemblyDefinition ReadAssembly(System.IO.Stream stream) { throw null; }
        public static Mono.Cecil.AssemblyDefinition ReadAssembly(System.IO.Stream stream, Mono.Cecil.ReaderParameters parameters) { throw null; }
        public static Mono.Cecil.AssemblyDefinition ReadAssembly(string fileName) { throw null; }
        public static Mono.Cecil.AssemblyDefinition ReadAssembly(string fileName, Mono.Cecil.ReaderParameters parameters) { throw null; }
        public override string ToString() { throw null; }
        public void Write() { }
        public void Write(Mono.Cecil.WriterParameters parameters) { }
        public void Write(System.IO.Stream stream) { }
        public void Write(System.IO.Stream stream, Mono.Cecil.WriterParameters parameters) { }
        public void Write(string fileName) { }
        public void Write(string fileName, Mono.Cecil.WriterParameters parameters) { }
    }
    public enum AssemblyHashAlgorithm : uint
    {
        None = (uint)0,
        Reserved = (uint)32771,
        SHA1 = (uint)32772,
    }
    public sealed partial class AssemblyLinkedResource : Mono.Cecil.Resource
    {
        public AssemblyLinkedResource(string name, Mono.Cecil.ManifestResourceAttributes flags) { }
        public AssemblyLinkedResource(string name, Mono.Cecil.ManifestResourceAttributes flags, Mono.Cecil.AssemblyNameReference reference) { }
        public Mono.Cecil.AssemblyNameReference Assembly { get { throw null; } set { } }
        public override Mono.Cecil.ResourceType ResourceType { get { throw null; } }
    }
    public sealed partial class AssemblyNameDefinition : Mono.Cecil.AssemblyNameReference
    {
        public AssemblyNameDefinition(string name, System.Version version) : base (default(string), default(System.Version)) { }
        public override byte[] Hash { get { throw null; } }
    }
    public partial class AssemblyNameReference : Mono.Cecil.IMetadataScope, Mono.Cecil.IMetadataTokenProvider
    {
        public AssemblyNameReference(string name, System.Version version) { }
        public Mono.Cecil.AssemblyAttributes Attributes { get { throw null; } set { } }
        public string Culture { get { throw null; } set { } }
        public string FullName { get { throw null; } }
        public virtual byte[] Hash { get { throw null; } set { } }
        public Mono.Cecil.AssemblyHashAlgorithm HashAlgorithm { get { throw null; } set { } }
        public bool HasPublicKey { get { throw null; } set { } }
        public bool IsRetargetable { get { throw null; } set { } }
        public bool IsSideBySideCompatible { get { throw null; } set { } }
        public bool IsWindowsRuntime { get { throw null; } set { } }
        public virtual Mono.Cecil.MetadataScopeType MetadataScopeType { get { throw null; } }
        public Mono.Cecil.MetadataToken MetadataToken { get { throw null; } set { } }
        public string Name { get { throw null; } set { } }
        public byte[] PublicKey { get { throw null; } set { } }
        public byte[] PublicKeyToken { get { throw null; } set { } }
        public System.Version Version { get { throw null; } set { } }
        public static Mono.Cecil.AssemblyNameReference Parse(string fullName) { throw null; }
        public override string ToString() { throw null; }
    }
    [System.SerializableAttribute]
    public sealed partial class AssemblyResolutionException : System.IO.FileNotFoundException
    {
        public AssemblyResolutionException(Mono.Cecil.AssemblyNameReference reference) { }
        public AssemblyResolutionException(Mono.Cecil.AssemblyNameReference reference, System.Exception innerException) { }
        public Mono.Cecil.AssemblyNameReference AssemblyReference { get { throw null; } }
    }
    public sealed partial class AssemblyResolveEventArgs : System.EventArgs
    {
        public AssemblyResolveEventArgs(Mono.Cecil.AssemblyNameReference reference) { }
        public Mono.Cecil.AssemblyNameReference AssemblyReference { get { throw null; } }
    }
    public delegate Mono.Cecil.AssemblyDefinition AssemblyResolveEventHandler(object sender, Mono.Cecil.AssemblyNameReference reference);
    public abstract partial class BaseAssemblyResolver : Mono.Cecil.IAssemblyResolver, System.IDisposable
    {
        protected BaseAssemblyResolver() { }
        public event Mono.Cecil.AssemblyResolveEventHandler ResolveFailure { add { } remove { } }
        public void AddSearchDirectory(string directory) { }
        public void Dispose() { }
        protected virtual void Dispose(bool disposing) { }
        public string[] GetSearchDirectories() { throw null; }
        public void RemoveSearchDirectory(string directory) { }
        public virtual Mono.Cecil.AssemblyDefinition Resolve(Mono.Cecil.AssemblyNameReference name) { throw null; }
        public virtual Mono.Cecil.AssemblyDefinition Resolve(Mono.Cecil.AssemblyNameReference name, Mono.Cecil.ReaderParameters parameters) { throw null; }
        protected virtual Mono.Cecil.AssemblyDefinition SearchDirectory(Mono.Cecil.AssemblyNameReference name, System.Collections.Generic.IEnumerable<string> directories, Mono.Cecil.ReaderParameters parameters) { throw null; }
    }
    public sealed partial class ByReferenceType : Mono.Cecil.TypeSpecification
    {
        public ByReferenceType(Mono.Cecil.TypeReference type) { }
        public override string FullName { get { throw null; } }
        public override bool IsByReference { get { throw null; } }
        public override bool IsValueType { get { throw null; } set { } }
        public override string Name { get { throw null; } }
    }
    public sealed partial class CallSite : Mono.Cecil.IMetadataTokenProvider, Mono.Cecil.IMethodSignature
    {
        public CallSite(Mono.Cecil.TypeReference returnType) { }
        public Mono.Cecil.MethodCallingConvention CallingConvention { get { throw null; } set { } }
        public bool ExplicitThis { get { throw null; } set { } }
        public string FullName { get { throw null; } }
        public bool HasParameters { get { throw null; } }
        public bool HasThis { get { throw null; } set { } }
        public Mono.Cecil.MetadataToken MetadataToken { get { throw null; } set { } }
        public Mono.Cecil.MethodReturnType MethodReturnType { get { throw null; } }
        public Mono.Cecil.ModuleDefinition Module { get { throw null; } }
        public string Name { get { throw null; } set { } }
        public string Namespace { get { throw null; } set { } }
        public Mono.Collections.Generic.Collection<Mono.Cecil.ParameterDefinition> Parameters { get { throw null; } }
        public Mono.Cecil.TypeReference ReturnType { get { throw null; } set { } }
        public Mono.Cecil.IMetadataScope Scope { get { throw null; } }
        public override string ToString() { throw null; }
    }
    [System.Diagnostics.DebuggerDisplayAttribute("{AttributeType}")]
    public sealed partial class CustomAttribute : Mono.Cecil.ICustomAttribute
    {
        public CustomAttribute(Mono.Cecil.MethodReference constructor) { }
        public CustomAttribute(Mono.Cecil.MethodReference constructor, byte[] blob) { }
        public Mono.Cecil.TypeReference AttributeType { get { throw null; } }
        public Mono.Cecil.MethodReference Constructor { get { throw null; } set { } }
        public Mono.Collections.Generic.Collection<Mono.Cecil.CustomAttributeArgument> ConstructorArguments { get { throw null; } }
        public Mono.Collections.Generic.Collection<Mono.Cecil.CustomAttributeNamedArgument> Fields { get { throw null; } }
        public bool HasConstructorArguments { get { throw null; } }
        public bool HasFields { get { throw null; } }
        public bool HasProperties { get { throw null; } }
        public bool IsResolved { get { throw null; } }
        public Mono.Collections.Generic.Collection<Mono.Cecil.CustomAttributeNamedArgument> Properties { get { throw null; } }
        public byte[] GetBlob() { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public partial struct CustomAttributeArgument
    {
        private object _dummy;
        public CustomAttributeArgument(Mono.Cecil.TypeReference type, object value) { throw null; }
        public Mono.Cecil.TypeReference Type { get { throw null; } }
        public object Value { get { throw null; } }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public partial struct CustomAttributeNamedArgument
    {
        private object _dummy;
        public CustomAttributeNamedArgument(string name, Mono.Cecil.CustomAttributeArgument argument) { throw null; }
        public Mono.Cecil.CustomAttributeArgument Argument { get { throw null; } }
        public string Name { get { throw null; } }
    }
    public sealed partial class CustomMarshalInfo : Mono.Cecil.MarshalInfo
    {
        public CustomMarshalInfo() : base (default(Mono.Cecil.NativeType)) { }
        public string Cookie { get { throw null; } set { } }
        public System.Guid Guid { get { throw null; } set { } }
        public Mono.Cecil.TypeReference ManagedType { get { throw null; } set { } }
        public string UnmanagedType { get { throw null; } set { } }
    }
    public partial class DefaultAssemblyResolver : Mono.Cecil.BaseAssemblyResolver
    {
        public DefaultAssemblyResolver() { }
        protected override void Dispose(bool disposing) { }
        protected void RegisterAssembly(Mono.Cecil.AssemblyDefinition assembly) { }
        public override Mono.Cecil.AssemblyDefinition Resolve(Mono.Cecil.AssemblyNameReference name) { throw null; }
    }
    public partial class DefaultMetadataImporter : Mono.Cecil.IMetadataImporter
    {
        protected readonly Mono.Cecil.ModuleDefinition module;
        public DefaultMetadataImporter(Mono.Cecil.ModuleDefinition module) { }
        public virtual Mono.Cecil.AssemblyNameReference ImportReference(Mono.Cecil.AssemblyNameReference name) { throw null; }
        public virtual Mono.Cecil.FieldReference ImportReference(Mono.Cecil.FieldReference field, Mono.Cecil.IGenericParameterProvider context) { throw null; }
        public virtual Mono.Cecil.MethodReference ImportReference(Mono.Cecil.MethodReference method, Mono.Cecil.IGenericParameterProvider context) { throw null; }
        public virtual Mono.Cecil.TypeReference ImportReference(Mono.Cecil.TypeReference type, Mono.Cecil.IGenericParameterProvider context) { throw null; }
        protected Mono.Cecil.IMetadataScope ImportScope(Mono.Cecil.IMetadataScope scope) { throw null; }
        protected virtual Mono.Cecil.IMetadataScope ImportScope(Mono.Cecil.TypeReference type) { throw null; }
    }
    public partial class DefaultReflectionImporter : Mono.Cecil.IReflectionImporter
    {
        protected readonly Mono.Cecil.ModuleDefinition module;
        public DefaultReflectionImporter(Mono.Cecil.ModuleDefinition module) { }
        public virtual Mono.Cecil.AssemblyNameReference ImportReference(System.Reflection.AssemblyName name) { throw null; }
        public virtual Mono.Cecil.FieldReference ImportReference(System.Reflection.FieldInfo field, Mono.Cecil.IGenericParameterProvider context) { throw null; }
        public virtual Mono.Cecil.MethodReference ImportReference(System.Reflection.MethodBase method, Mono.Cecil.IGenericParameterProvider context) { throw null; }
        public virtual Mono.Cecil.TypeReference ImportReference(System.Type type, Mono.Cecil.IGenericParameterProvider context) { throw null; }
        protected Mono.Cecil.AssemblyNameReference ImportScope(System.Reflection.Assembly assembly) { throw null; }
        protected virtual Mono.Cecil.IMetadataScope ImportScope(System.Type type) { throw null; }
    }
    public sealed partial class EmbeddedResource : Mono.Cecil.Resource
    {
        public EmbeddedResource(string name, Mono.Cecil.ManifestResourceAttributes attributes, byte[] data) { }
        public EmbeddedResource(string name, Mono.Cecil.ManifestResourceAttributes attributes, System.IO.Stream stream) { }
        public override Mono.Cecil.ResourceType ResourceType { get { throw null; } }
        public byte[] GetResourceData() { throw null; }
        public System.IO.Stream GetResourceStream() { throw null; }
    }
    [System.FlagsAttribute]
    public enum EventAttributes : ushort
    {
        None = (ushort)0,
        RTSpecialName = (ushort)1024,
        SpecialName = (ushort)512,
    }
    public sealed partial class EventDefinition : Mono.Cecil.EventReference, Mono.Cecil.ICustomAttributeProvider, Mono.Cecil.IMemberDefinition, Mono.Cecil.IMetadataTokenProvider
    {
        public EventDefinition(string name, Mono.Cecil.EventAttributes attributes, Mono.Cecil.TypeReference eventType) : base (default(string), default(Mono.Cecil.TypeReference)) { }
        public Mono.Cecil.MethodDefinition AddMethod { get { throw null; } set { } }
        public Mono.Cecil.EventAttributes Attributes { get { throw null; } set { } }
        public Mono.Collections.Generic.Collection<Mono.Cecil.CustomAttribute> CustomAttributes { get { throw null; } }
        public new Mono.Cecil.TypeDefinition DeclaringType { get { throw null; } set { } }
        public bool HasCustomAttributes { get { throw null; } }
        public bool HasOtherMethods { get { throw null; } }
        public Mono.Cecil.MethodDefinition InvokeMethod { get { throw null; } set { } }
        public override bool IsDefinition { get { throw null; } }
        public bool IsRuntimeSpecialName { get { throw null; } set { } }
        public bool IsSpecialName { get { throw null; } set { } }
        public Mono.Collections.Generic.Collection<Mono.Cecil.MethodDefinition> OtherMethods { get { throw null; } }
        public Mono.Cecil.MethodDefinition RemoveMethod { get { throw null; } set { } }
        public override Mono.Cecil.EventDefinition Resolve() { throw null; }
    }
    public abstract partial class EventReference : Mono.Cecil.MemberReference
    {
        protected EventReference(string name, Mono.Cecil.TypeReference eventType) { }
        public Mono.Cecil.TypeReference EventType { get { throw null; } set { } }
        public override string FullName { get { throw null; } }
        public abstract new Mono.Cecil.EventDefinition Resolve();
        protected override Mono.Cecil.IMemberDefinition ResolveDefinition() { throw null; }
    }
    public sealed partial class ExportedType : Mono.Cecil.IMetadataTokenProvider
    {
        public ExportedType(string @namespace, string name, Mono.Cecil.ModuleDefinition module, Mono.Cecil.IMetadataScope scope) { }
        public Mono.Cecil.TypeAttributes Attributes { get { throw null; } set { } }
        public Mono.Cecil.ExportedType DeclaringType { get { throw null; } set { } }
        public string FullName { get { throw null; } }
        public bool HasSecurity { get { throw null; } set { } }
        public int Identifier { get { throw null; } set { } }
        public bool IsAbstract { get { throw null; } set { } }
        public bool IsAnsiClass { get { throw null; } set { } }
        public bool IsAutoClass { get { throw null; } set { } }
        public bool IsAutoLayout { get { throw null; } set { } }
        public bool IsBeforeFieldInit { get { throw null; } set { } }
        public bool IsClass { get { throw null; } set { } }
        public bool IsExplicitLayout { get { throw null; } set { } }
        public bool IsForwarder { get { throw null; } set { } }
        public bool IsImport { get { throw null; } set { } }
        public bool IsInterface { get { throw null; } set { } }
        public bool IsNestedAssembly { get { throw null; } set { } }
        public bool IsNestedFamily { get { throw null; } set { } }
        public bool IsNestedFamilyAndAssembly { get { throw null; } set { } }
        public bool IsNestedFamilyOrAssembly { get { throw null; } set { } }
        public bool IsNestedPrivate { get { throw null; } set { } }
        public bool IsNestedPublic { get { throw null; } set { } }
        public bool IsNotPublic { get { throw null; } set { } }
        public bool IsPublic { get { throw null; } set { } }
        public bool IsRuntimeSpecialName { get { throw null; } set { } }
        public bool IsSealed { get { throw null; } set { } }
        public bool IsSequentialLayout { get { throw null; } set { } }
        public bool IsSerializable { get { throw null; } set { } }
        public bool IsSpecialName { get { throw null; } set { } }
        public bool IsUnicodeClass { get { throw null; } set { } }
        public Mono.Cecil.MetadataToken MetadataToken { get { throw null; } set { } }
        public string Name { get { throw null; } set { } }
        public string Namespace { get { throw null; } set { } }
        public Mono.Cecil.IMetadataScope Scope { get { throw null; } set { } }
        public Mono.Cecil.TypeDefinition Resolve() { throw null; }
        public override string ToString() { throw null; }
    }
    [System.FlagsAttribute]
    public enum FieldAttributes : ushort
    {
        Assembly = (ushort)3,
        CompilerControlled = (ushort)0,
        FamANDAssem = (ushort)2,
        Family = (ushort)4,
        FamORAssem = (ushort)5,
        FieldAccessMask = (ushort)7,
        HasDefault = (ushort)32768,
        HasFieldMarshal = (ushort)4096,
        HasFieldRVA = (ushort)256,
        InitOnly = (ushort)32,
        Literal = (ushort)64,
        NotSerialized = (ushort)128,
        PInvokeImpl = (ushort)8192,
        Private = (ushort)1,
        Public = (ushort)6,
        RTSpecialName = (ushort)1024,
        SpecialName = (ushort)512,
        Static = (ushort)16,
    }
    public sealed partial class FieldDefinition : Mono.Cecil.FieldReference, Mono.Cecil.IConstantProvider, Mono.Cecil.ICustomAttributeProvider, Mono.Cecil.IMarshalInfoProvider, Mono.Cecil.IMemberDefinition, Mono.Cecil.IMetadataTokenProvider
    {
        public FieldDefinition(string name, Mono.Cecil.FieldAttributes attributes, Mono.Cecil.TypeReference fieldType) : base (default(string), default(Mono.Cecil.TypeReference)) { }
        public Mono.Cecil.FieldAttributes Attributes { get { throw null; } set { } }
        public object Constant { get { throw null; } set { } }
        public Mono.Collections.Generic.Collection<Mono.Cecil.CustomAttribute> CustomAttributes { get { throw null; } }
        public new Mono.Cecil.TypeDefinition DeclaringType { get { throw null; } set { } }
        public bool HasConstant { get { throw null; } set { } }
        public bool HasCustomAttributes { get { throw null; } }
        public bool HasDefault { get { throw null; } set { } }
        public bool HasLayoutInfo { get { throw null; } }
        public bool HasMarshalInfo { get { throw null; } }
        public byte[] InitialValue { get { throw null; } set { } }
        public bool IsAssembly { get { throw null; } set { } }
        public bool IsCompilerControlled { get { throw null; } set { } }
        public override bool IsDefinition { get { throw null; } }
        public bool IsFamily { get { throw null; } set { } }
        public bool IsFamilyAndAssembly { get { throw null; } set { } }
        public bool IsFamilyOrAssembly { get { throw null; } set { } }
        public bool IsInitOnly { get { throw null; } set { } }
        public bool IsLiteral { get { throw null; } set { } }
        public bool IsNotSerialized { get { throw null; } set { } }
        public bool IsPInvokeImpl { get { throw null; } set { } }
        public bool IsPrivate { get { throw null; } set { } }
        public bool IsPublic { get { throw null; } set { } }
        public bool IsRuntimeSpecialName { get { throw null; } set { } }
        public bool IsSpecialName { get { throw null; } set { } }
        public bool IsStatic { get { throw null; } set { } }
        public Mono.Cecil.MarshalInfo MarshalInfo { get { throw null; } set { } }
        public int Offset { get { throw null; } set { } }
        public int RVA { get { throw null; } }
        public override Mono.Cecil.FieldDefinition Resolve() { throw null; }
    }
    public partial class FieldReference : Mono.Cecil.MemberReference
    {
        public FieldReference(string name, Mono.Cecil.TypeReference fieldType) { }
        public FieldReference(string name, Mono.Cecil.TypeReference fieldType, Mono.Cecil.TypeReference declaringType) { }
        public override bool ContainsGenericParameter { get { throw null; } }
        public Mono.Cecil.TypeReference FieldType { get { throw null; } set { } }
        public override string FullName { get { throw null; } }
        public virtual new Mono.Cecil.FieldDefinition Resolve() { throw null; }
        protected override Mono.Cecil.IMemberDefinition ResolveDefinition() { throw null; }
    }
    public sealed partial class FixedArrayMarshalInfo : Mono.Cecil.MarshalInfo
    {
        public FixedArrayMarshalInfo() : base (default(Mono.Cecil.NativeType)) { }
        public Mono.Cecil.NativeType ElementType { get { throw null; } set { } }
        public int Size { get { throw null; } set { } }
    }
    public sealed partial class FixedSysStringMarshalInfo : Mono.Cecil.MarshalInfo
    {
        public FixedSysStringMarshalInfo() : base (default(Mono.Cecil.NativeType)) { }
        public int Size { get { throw null; } set { } }
    }
    public sealed partial class FunctionPointerType : Mono.Cecil.TypeSpecification, Mono.Cecil.IMetadataTokenProvider, Mono.Cecil.IMethodSignature
    {
        public FunctionPointerType() { }
        public Mono.Cecil.MethodCallingConvention CallingConvention { get { throw null; } set { } }
        public override bool ContainsGenericParameter { get { throw null; } }
        public bool ExplicitThis { get { throw null; } set { } }
        public override string FullName { get { throw null; } }
        public bool HasParameters { get { throw null; } }
        public bool HasThis { get { throw null; } set { } }
        public override bool IsFunctionPointer { get { throw null; } }
        public Mono.Cecil.MethodReturnType MethodReturnType { get { throw null; } }
        public override Mono.Cecil.ModuleDefinition Module { get { throw null; } }
        public override string Name { get { throw null; } set { } }
        public override string Namespace { get { throw null; } set { } }
        public Mono.Collections.Generic.Collection<Mono.Cecil.ParameterDefinition> Parameters { get { throw null; } }
        public Mono.Cecil.TypeReference ReturnType { get { throw null; } set { } }
        public override Mono.Cecil.IMetadataScope Scope { get { throw null; } set { } }
        public override Mono.Cecil.TypeReference GetElementType() { throw null; }
        public override Mono.Cecil.TypeDefinition Resolve() { throw null; }
    }
    public sealed partial class GenericInstanceMethod : Mono.Cecil.MethodSpecification, Mono.Cecil.IGenericInstance, Mono.Cecil.IMetadataTokenProvider
    {
        public GenericInstanceMethod(Mono.Cecil.MethodReference method) { }
        public override bool ContainsGenericParameter { get { throw null; } }
        public override string FullName { get { throw null; } }
        public Mono.Collections.Generic.Collection<Mono.Cecil.TypeReference> GenericArguments { get { throw null; } }
        public bool HasGenericArguments { get { throw null; } }
        public override bool IsGenericInstance { get { throw null; } }
    }
    public sealed partial class GenericInstanceType : Mono.Cecil.TypeSpecification, Mono.Cecil.IGenericInstance, Mono.Cecil.IMetadataTokenProvider
    {
        public GenericInstanceType(Mono.Cecil.TypeReference type) { }
        public override bool ContainsGenericParameter { get { throw null; } }
        public override Mono.Cecil.TypeReference DeclaringType { get { throw null; } set { } }
        public override string FullName { get { throw null; } }
        public Mono.Collections.Generic.Collection<Mono.Cecil.TypeReference> GenericArguments { get { throw null; } }
        public bool HasGenericArguments { get { throw null; } }
        public override bool IsGenericInstance { get { throw null; } }
    }
    public sealed partial class GenericParameter : Mono.Cecil.TypeReference, Mono.Cecil.ICustomAttributeProvider, Mono.Cecil.IMetadataTokenProvider
    {
        public GenericParameter(Mono.Cecil.IGenericParameterProvider owner) : base (default(string), default(string)) { }
        public GenericParameter(string name, Mono.Cecil.IGenericParameterProvider owner) : base (default(string), default(string)) { }
        public Mono.Cecil.GenericParameterAttributes Attributes { get { throw null; } set { } }
        public Mono.Collections.Generic.Collection<Mono.Cecil.GenericParameterConstraint> Constraints { get { throw null; } }
        public override bool ContainsGenericParameter { get { throw null; } }
        public Mono.Collections.Generic.Collection<Mono.Cecil.CustomAttribute> CustomAttributes { get { throw null; } }
        public Mono.Cecil.MethodReference DeclaringMethod { get { throw null; } }
        public override Mono.Cecil.TypeReference DeclaringType { get { throw null; } set { } }
        public override string FullName { get { throw null; } }
        public bool HasConstraints { get { throw null; } }
        public bool HasCustomAttributes { get { throw null; } }
        public bool HasDefaultConstructorConstraint { get { throw null; } set { } }
        public bool HasNotNullableValueTypeConstraint { get { throw null; } set { } }
        public bool HasReferenceTypeConstraint { get { throw null; } set { } }
        public bool IsContravariant { get { throw null; } set { } }
        public bool IsCovariant { get { throw null; } set { } }
        public override bool IsGenericParameter { get { throw null; } }
        public bool IsNonVariant { get { throw null; } set { } }
        public override Mono.Cecil.MetadataType MetadataType { get { throw null; } }
        public override Mono.Cecil.ModuleDefinition Module { get { throw null; } }
        public override string Name { get { throw null; } }
        public override string Namespace { get { throw null; } set { } }
        public Mono.Cecil.IGenericParameterProvider Owner { get { throw null; } }
        public int Position { get { throw null; } }
        public override Mono.Cecil.IMetadataScope Scope { get { throw null; } set { } }
        public Mono.Cecil.GenericParameterType Type { get { throw null; } }
        public override Mono.Cecil.TypeDefinition Resolve() { throw null; }
    }
    [System.FlagsAttribute]
    public enum GenericParameterAttributes : ushort
    {
        Contravariant = (ushort)2,
        Covariant = (ushort)1,
        DefaultConstructorConstraint = (ushort)16,
        NonVariant = (ushort)0,
        NotNullableValueTypeConstraint = (ushort)8,
        ReferenceTypeConstraint = (ushort)4,
        SpecialConstraintMask = (ushort)28,
        VarianceMask = (ushort)3,
    }
    public sealed partial class GenericParameterConstraint : Mono.Cecil.ICustomAttributeProvider, Mono.Cecil.IMetadataTokenProvider
    {
        public GenericParameterConstraint(Mono.Cecil.TypeReference constraintType) { }
        public Mono.Cecil.TypeReference ConstraintType { get { throw null; } set { } }
        public Mono.Collections.Generic.Collection<Mono.Cecil.CustomAttribute> CustomAttributes { get { throw null; } }
        public bool HasCustomAttributes { get { throw null; } }
        public Mono.Cecil.MetadataToken MetadataToken { get { throw null; } set { } }
    }
    public enum GenericParameterType
    {
        Method = 1,
        Type = 0,
    }
    public partial interface IAssemblyResolver : System.IDisposable
    {
        Mono.Cecil.AssemblyDefinition Resolve(Mono.Cecil.AssemblyNameReference name);
        Mono.Cecil.AssemblyDefinition Resolve(Mono.Cecil.AssemblyNameReference name, Mono.Cecil.ReaderParameters parameters);
    }
    public partial interface IConstantProvider : Mono.Cecil.IMetadataTokenProvider
    {
        object Constant { get; set; }
        bool HasConstant { get; set; }
    }
    public partial interface ICustomAttribute
    {
        Mono.Cecil.TypeReference AttributeType { get; }
        Mono.Collections.Generic.Collection<Mono.Cecil.CustomAttributeArgument> ConstructorArguments { get; }
        Mono.Collections.Generic.Collection<Mono.Cecil.CustomAttributeNamedArgument> Fields { get; }
        bool HasConstructorArguments { get; }
        bool HasFields { get; }
        bool HasProperties { get; }
        Mono.Collections.Generic.Collection<Mono.Cecil.CustomAttributeNamedArgument> Properties { get; }
    }
    public partial interface ICustomAttributeProvider : Mono.Cecil.IMetadataTokenProvider
    {
        Mono.Collections.Generic.Collection<Mono.Cecil.CustomAttribute> CustomAttributes { get; }
        bool HasCustomAttributes { get; }
    }
    public partial interface IGenericInstance : Mono.Cecil.IMetadataTokenProvider
    {
        Mono.Collections.Generic.Collection<Mono.Cecil.TypeReference> GenericArguments { get; }
        bool HasGenericArguments { get; }
    }
    public partial interface IGenericParameterProvider : Mono.Cecil.IMetadataTokenProvider
    {
        Mono.Collections.Generic.Collection<Mono.Cecil.GenericParameter> GenericParameters { get; }
        Mono.Cecil.GenericParameterType GenericParameterType { get; }
        bool HasGenericParameters { get; }
        bool IsDefinition { get; }
        Mono.Cecil.ModuleDefinition Module { get; }
    }
    public partial interface IMarshalInfoProvider : Mono.Cecil.IMetadataTokenProvider
    {
        bool HasMarshalInfo { get; }
        Mono.Cecil.MarshalInfo MarshalInfo { get; set; }
    }
    public partial interface IMemberDefinition : Mono.Cecil.ICustomAttributeProvider, Mono.Cecil.IMetadataTokenProvider
    {
        Mono.Cecil.TypeDefinition DeclaringType { get; set; }
        string FullName { get; }
        bool IsRuntimeSpecialName { get; set; }
        bool IsSpecialName { get; set; }
        string Name { get; set; }
    }
    public partial interface IMetadataImporter
    {
        Mono.Cecil.AssemblyNameReference ImportReference(Mono.Cecil.AssemblyNameReference reference);
        Mono.Cecil.FieldReference ImportReference(Mono.Cecil.FieldReference field, Mono.Cecil.IGenericParameterProvider context);
        Mono.Cecil.MethodReference ImportReference(Mono.Cecil.MethodReference method, Mono.Cecil.IGenericParameterProvider context);
        Mono.Cecil.TypeReference ImportReference(Mono.Cecil.TypeReference type, Mono.Cecil.IGenericParameterProvider context);
    }
    public partial interface IMetadataImporterProvider
    {
        Mono.Cecil.IMetadataImporter GetMetadataImporter(Mono.Cecil.ModuleDefinition module);
    }
    public partial interface IMetadataResolver
    {
        Mono.Cecil.FieldDefinition Resolve(Mono.Cecil.FieldReference field);
        Mono.Cecil.MethodDefinition Resolve(Mono.Cecil.MethodReference method);
        Mono.Cecil.TypeDefinition Resolve(Mono.Cecil.TypeReference type);
    }
    public partial interface IMetadataScope : Mono.Cecil.IMetadataTokenProvider
    {
        Mono.Cecil.MetadataScopeType MetadataScopeType { get; }
        string Name { get; set; }
    }
    public partial interface IMetadataTokenProvider
    {
        Mono.Cecil.MetadataToken MetadataToken { get; set; }
    }
    public partial interface IMethodSignature : Mono.Cecil.IMetadataTokenProvider
    {
        Mono.Cecil.MethodCallingConvention CallingConvention { get; set; }
        bool ExplicitThis { get; set; }
        bool HasParameters { get; }
        bool HasThis { get; set; }
        Mono.Cecil.MethodReturnType MethodReturnType { get; }
        Mono.Collections.Generic.Collection<Mono.Cecil.ParameterDefinition> Parameters { get; }
        Mono.Cecil.TypeReference ReturnType { get; set; }
    }
    public partial interface IModifierType
    {
        Mono.Cecil.TypeReference ElementType { get; }
        Mono.Cecil.TypeReference ModifierType { get; }
    }
    public sealed partial class InterfaceImplementation : Mono.Cecil.ICustomAttributeProvider, Mono.Cecil.IMetadataTokenProvider
    {
        public InterfaceImplementation(Mono.Cecil.TypeReference interfaceType) { }
        public Mono.Collections.Generic.Collection<Mono.Cecil.CustomAttribute> CustomAttributes { get { throw null; } }
        public bool HasCustomAttributes { get { throw null; } }
        public Mono.Cecil.TypeReference InterfaceType { get { throw null; } set { } }
        public Mono.Cecil.MetadataToken MetadataToken { get { throw null; } set { } }
    }
    public partial interface IReflectionImporter
    {
        Mono.Cecil.AssemblyNameReference ImportReference(System.Reflection.AssemblyName reference);
        Mono.Cecil.FieldReference ImportReference(System.Reflection.FieldInfo field, Mono.Cecil.IGenericParameterProvider context);
        Mono.Cecil.MethodReference ImportReference(System.Reflection.MethodBase method, Mono.Cecil.IGenericParameterProvider context);
        Mono.Cecil.TypeReference ImportReference(System.Type type, Mono.Cecil.IGenericParameterProvider context);
    }
    public partial interface IReflectionImporterProvider
    {
        Mono.Cecil.IReflectionImporter GetReflectionImporter(Mono.Cecil.ModuleDefinition module);
    }
    public partial interface ISecurityDeclarationProvider : Mono.Cecil.IMetadataTokenProvider
    {
        bool HasSecurityDeclarations { get; }
        Mono.Collections.Generic.Collection<Mono.Cecil.SecurityDeclaration> SecurityDeclarations { get; }
    }
    public sealed partial class LinkedResource : Mono.Cecil.Resource
    {
        public LinkedResource(string name, Mono.Cecil.ManifestResourceAttributes flags) { }
        public LinkedResource(string name, Mono.Cecil.ManifestResourceAttributes flags, string file) { }
        public string File { get { throw null; } set { } }
        public byte[] Hash { get { throw null; } }
        public override Mono.Cecil.ResourceType ResourceType { get { throw null; } }
    }
    [System.FlagsAttribute]
    public enum ManifestResourceAttributes : uint
    {
        Private = (uint)2,
        Public = (uint)1,
        VisibilityMask = (uint)7,
    }
    public partial class MarshalInfo
    {
        public MarshalInfo(Mono.Cecil.NativeType native) { }
        public Mono.Cecil.NativeType NativeType { get { throw null; } set { } }
    }
    public abstract partial class MemberReference : Mono.Cecil.IMetadataTokenProvider
    {
        internal MemberReference() { }
        public virtual bool ContainsGenericParameter { get { throw null; } }
        public virtual Mono.Cecil.TypeReference DeclaringType { get { throw null; } set { } }
        public abstract string FullName { get; }
        public virtual bool IsDefinition { get { throw null; } }
        public bool IsWindowsRuntimeProjection { get { throw null; } }
        public Mono.Cecil.MetadataToken MetadataToken { get { throw null; } set { } }
        public virtual Mono.Cecil.ModuleDefinition Module { get { throw null; } }
        public virtual string Name { get { throw null; } set { } }
        public Mono.Cecil.IMemberDefinition Resolve() { throw null; }
        protected abstract Mono.Cecil.IMemberDefinition ResolveDefinition();
        public override string ToString() { throw null; }
    }
    public enum MetadataKind
    {
        Ecma335 = 0,
        ManagedWindowsMetadata = 2,
        WindowsMetadata = 1,
    }
    public partial class MetadataResolver : Mono.Cecil.IMetadataResolver
    {
        public MetadataResolver(Mono.Cecil.IAssemblyResolver assemblyResolver) { }
        public Mono.Cecil.IAssemblyResolver AssemblyResolver { get { throw null; } }
        public static Mono.Cecil.MethodDefinition GetMethod(Mono.Collections.Generic.Collection<Mono.Cecil.MethodDefinition> methods, Mono.Cecil.MethodReference reference) { throw null; }
        public virtual Mono.Cecil.FieldDefinition Resolve(Mono.Cecil.FieldReference field) { throw null; }
        public virtual Mono.Cecil.MethodDefinition Resolve(Mono.Cecil.MethodReference method) { throw null; }
        public virtual Mono.Cecil.TypeDefinition Resolve(Mono.Cecil.TypeReference type) { throw null; }
    }
    public enum MetadataScopeType
    {
        AssemblyNameReference = 0,
        ModuleDefinition = 2,
        ModuleReference = 1,
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public partial struct MetadataToken : System.IEquatable<Mono.Cecil.MetadataToken>
    {
        private int _dummyPrimitive;
        public static readonly Mono.Cecil.MetadataToken Zero;
        public MetadataToken(Mono.Cecil.TokenType type) { throw null; }
        public MetadataToken(Mono.Cecil.TokenType type, int rid) { throw null; }
        public MetadataToken(Mono.Cecil.TokenType type, uint rid) { throw null; }
        public MetadataToken(uint token) { throw null; }
        public uint RID { get { throw null; } }
        public Mono.Cecil.TokenType TokenType { get { throw null; } }
        public bool Equals(Mono.Cecil.MetadataToken other) { throw null; }
        public override bool Equals(object obj) { throw null; }
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Mono.Cecil.MetadataToken one, Mono.Cecil.MetadataToken other) { throw null; }
        public static bool operator !=(Mono.Cecil.MetadataToken one, Mono.Cecil.MetadataToken other) { throw null; }
        public int ToInt32() { throw null; }
        public override string ToString() { throw null; }
        public uint ToUInt32() { throw null; }
    }
    public enum MetadataType : byte
    {
        Array = (byte)20,
        Boolean = (byte)2,
        ByReference = (byte)16,
        Byte = (byte)5,
        Char = (byte)3,
        Class = (byte)18,
        Double = (byte)13,
        FunctionPointer = (byte)27,
        GenericInstance = (byte)21,
        Int16 = (byte)6,
        Int32 = (byte)8,
        Int64 = (byte)10,
        IntPtr = (byte)24,
        MVar = (byte)30,
        Object = (byte)28,
        OptionalModifier = (byte)32,
        Pinned = (byte)69,
        Pointer = (byte)15,
        RequiredModifier = (byte)31,
        SByte = (byte)4,
        Sentinel = (byte)65,
        Single = (byte)12,
        String = (byte)14,
        TypedByReference = (byte)22,
        UInt16 = (byte)7,
        UInt32 = (byte)9,
        UInt64 = (byte)11,
        UIntPtr = (byte)25,
        ValueType = (byte)17,
        Var = (byte)19,
        Void = (byte)1,
    }
    [System.FlagsAttribute]
    public enum MethodAttributes : ushort
    {
        Abstract = (ushort)1024,
        Assembly = (ushort)3,
        CheckAccessOnOverride = (ushort)512,
        CompilerControlled = (ushort)0,
        FamANDAssem = (ushort)2,
        Family = (ushort)4,
        FamORAssem = (ushort)5,
        Final = (ushort)32,
        HasSecurity = (ushort)16384,
        HideBySig = (ushort)128,
        MemberAccessMask = (ushort)7,
        NewSlot = (ushort)256,
        PInvokeImpl = (ushort)8192,
        Private = (ushort)1,
        Public = (ushort)6,
        RequireSecObject = (ushort)32768,
        ReuseSlot = (ushort)0,
        RTSpecialName = (ushort)4096,
        SpecialName = (ushort)2048,
        Static = (ushort)16,
        UnmanagedExport = (ushort)8,
        Virtual = (ushort)64,
        VtableLayoutMask = (ushort)256,
    }
    public enum MethodCallingConvention : byte
    {
        C = (byte)1,
        Default = (byte)0,
        FastCall = (byte)4,
        Generic = (byte)16,
        StdCall = (byte)2,
        ThisCall = (byte)3,
        VarArg = (byte)5,
    }
    public sealed partial class MethodDefinition : Mono.Cecil.MethodReference, Mono.Cecil.Cil.ICustomDebugInformationProvider, Mono.Cecil.ICustomAttributeProvider, Mono.Cecil.IMemberDefinition, Mono.Cecil.IMetadataTokenProvider, Mono.Cecil.ISecurityDeclarationProvider
    {
        public MethodDefinition(string name, Mono.Cecil.MethodAttributes attributes, Mono.Cecil.TypeReference returnType) : base (default(string), default(Mono.Cecil.TypeReference)) { }
        public bool AggressiveInlining { get { throw null; } set { } }
        public Mono.Cecil.MethodAttributes Attributes { get { throw null; } set { } }
        public Mono.Cecil.Cil.MethodBody Body { get { throw null; } set { } }
        public Mono.Collections.Generic.Collection<Mono.Cecil.CustomAttribute> CustomAttributes { get { throw null; } }
        public Mono.Collections.Generic.Collection<Mono.Cecil.Cil.CustomDebugInformation> CustomDebugInformations { get { throw null; } }
        public Mono.Cecil.Cil.MethodDebugInformation DebugInformation { get { throw null; } set { } }
        public new Mono.Cecil.TypeDefinition DeclaringType { get { throw null; } set { } }
        public override Mono.Collections.Generic.Collection<Mono.Cecil.GenericParameter> GenericParameters { get { throw null; } }
        public bool HasBody { get { throw null; } }
        public bool HasCustomAttributes { get { throw null; } }
        public bool HasCustomDebugInformations { get { throw null; } }
        public override bool HasGenericParameters { get { throw null; } }
        public bool HasOverrides { get { throw null; } }
        public bool HasPInvokeInfo { get { throw null; } }
        public bool HasSecurity { get { throw null; } set { } }
        public bool HasSecurityDeclarations { get { throw null; } }
        public Mono.Cecil.MethodImplAttributes ImplAttributes { get { throw null; } set { } }
        public bool IsAbstract { get { throw null; } set { } }
        public bool IsAddOn { get { throw null; } set { } }
        public bool IsAssembly { get { throw null; } set { } }
        public bool IsCheckAccessOnOverride { get { throw null; } set { } }
        public bool IsCompilerControlled { get { throw null; } set { } }
        public bool IsConstructor { get { throw null; } }
        public override bool IsDefinition { get { throw null; } }
        public bool IsFamily { get { throw null; } set { } }
        public bool IsFamilyAndAssembly { get { throw null; } set { } }
        public bool IsFamilyOrAssembly { get { throw null; } set { } }
        public bool IsFinal { get { throw null; } set { } }
        public bool IsFire { get { throw null; } set { } }
        public bool IsForwardRef { get { throw null; } set { } }
        public bool IsGetter { get { throw null; } set { } }
        public bool IsHideBySig { get { throw null; } set { } }
        public bool IsIL { get { throw null; } set { } }
        public bool IsInternalCall { get { throw null; } set { } }
        public bool IsManaged { get { throw null; } set { } }
        public bool IsNative { get { throw null; } set { } }
        public bool IsNewSlot { get { throw null; } set { } }
        public bool IsOther { get { throw null; } set { } }
        public bool IsPInvokeImpl { get { throw null; } set { } }
        public bool IsPreserveSig { get { throw null; } set { } }
        public bool IsPrivate { get { throw null; } set { } }
        public bool IsPublic { get { throw null; } set { } }
        public bool IsRemoveOn { get { throw null; } set { } }
        public bool IsReuseSlot { get { throw null; } set { } }
        public bool IsRuntime { get { throw null; } set { } }
        public bool IsRuntimeSpecialName { get { throw null; } set { } }
        public bool IsSetter { get { throw null; } set { } }
        public bool IsSpecialName { get { throw null; } set { } }
        public bool IsStatic { get { throw null; } set { } }
        public bool IsSynchronized { get { throw null; } set { } }
        public bool IsUnmanaged { get { throw null; } set { } }
        public bool IsUnmanagedExport { get { throw null; } set { } }
        public bool IsVirtual { get { throw null; } set { } }
        public override string Name { get { throw null; } set { } }
        public bool NoInlining { get { throw null; } set { } }
        public bool NoOptimization { get { throw null; } set { } }
        public Mono.Collections.Generic.Collection<Mono.Cecil.MethodReference> Overrides { get { throw null; } }
        public Mono.Cecil.PInvokeInfo PInvokeInfo { get { throw null; } set { } }
        public int RVA { get { throw null; } }
        public Mono.Collections.Generic.Collection<Mono.Cecil.SecurityDeclaration> SecurityDeclarations { get { throw null; } }
        public Mono.Cecil.MethodSemanticsAttributes SemanticsAttributes { get { throw null; } set { } }
        public override Mono.Cecil.MethodDefinition Resolve() { throw null; }
    }
    [System.FlagsAttribute]
    public enum MethodImplAttributes : ushort
    {
        AggressiveInlining = (ushort)256,
        CodeTypeMask = (ushort)3,
        ForwardRef = (ushort)16,
        IL = (ushort)0,
        InternalCall = (ushort)4096,
        Managed = (ushort)0,
        ManagedMask = (ushort)4,
        Native = (ushort)1,
        NoInlining = (ushort)8,
        NoOptimization = (ushort)64,
        OPTIL = (ushort)2,
        PreserveSig = (ushort)128,
        Runtime = (ushort)3,
        Synchronized = (ushort)32,
        Unmanaged = (ushort)4,
    }
    public partial class MethodReference : Mono.Cecil.MemberReference, Mono.Cecil.IGenericParameterProvider, Mono.Cecil.IMetadataTokenProvider, Mono.Cecil.IMethodSignature
    {
        public MethodReference(string name, Mono.Cecil.TypeReference returnType) { }
        public MethodReference(string name, Mono.Cecil.TypeReference returnType, Mono.Cecil.TypeReference declaringType) { }
        public virtual Mono.Cecil.MethodCallingConvention CallingConvention { get { throw null; } set { } }
        public override bool ContainsGenericParameter { get { throw null; } }
        public virtual bool ExplicitThis { get { throw null; } set { } }
        public override string FullName { get { throw null; } }
        public virtual Mono.Collections.Generic.Collection<Mono.Cecil.GenericParameter> GenericParameters { get { throw null; } }
        public virtual bool HasGenericParameters { get { throw null; } }
        public virtual bool HasParameters { get { throw null; } }
        public virtual bool HasThis { get { throw null; } set { } }
        public virtual bool IsGenericInstance { get { throw null; } }
        public virtual Mono.Cecil.MethodReturnType MethodReturnType { get { throw null; } set { } }
        Mono.Cecil.GenericParameterType Mono.Cecil.IGenericParameterProvider.GenericParameterType { get { throw null; } }
        public virtual Mono.Collections.Generic.Collection<Mono.Cecil.ParameterDefinition> Parameters { get { throw null; } }
        public Mono.Cecil.TypeReference ReturnType { get { throw null; } set { } }
        public virtual Mono.Cecil.MethodReference GetElementMethod() { throw null; }
        public virtual new Mono.Cecil.MethodDefinition Resolve() { throw null; }
        protected override Mono.Cecil.IMemberDefinition ResolveDefinition() { throw null; }
    }
    public sealed partial class MethodReturnType : Mono.Cecil.IConstantProvider, Mono.Cecil.ICustomAttributeProvider, Mono.Cecil.IMarshalInfoProvider, Mono.Cecil.IMetadataTokenProvider
    {
        public MethodReturnType(Mono.Cecil.IMethodSignature method) { }
        public Mono.Cecil.ParameterAttributes Attributes { get { throw null; } set { } }
        public object Constant { get { throw null; } set { } }
        public Mono.Collections.Generic.Collection<Mono.Cecil.CustomAttribute> CustomAttributes { get { throw null; } }
        public bool HasConstant { get { throw null; } set { } }
        public bool HasCustomAttributes { get { throw null; } }
        public bool HasDefault { get { throw null; } set { } }
        public bool HasFieldMarshal { get { throw null; } set { } }
        public bool HasMarshalInfo { get { throw null; } }
        public Mono.Cecil.MarshalInfo MarshalInfo { get { throw null; } set { } }
        public Mono.Cecil.MetadataToken MetadataToken { get { throw null; } set { } }
        public Mono.Cecil.IMethodSignature Method { get { throw null; } }
        public string Name { get { throw null; } set { } }
        public Mono.Cecil.TypeReference ReturnType { get { throw null; } set { } }
    }
    [System.FlagsAttribute]
    public enum MethodSemanticsAttributes : ushort
    {
        AddOn = (ushort)8,
        Fire = (ushort)32,
        Getter = (ushort)2,
        None = (ushort)0,
        Other = (ushort)4,
        RemoveOn = (ushort)16,
        Setter = (ushort)1,
    }
    public abstract partial class MethodSpecification : Mono.Cecil.MethodReference
    {
        internal MethodSpecification() : base (default(string), default(Mono.Cecil.TypeReference)) { }
        public override Mono.Cecil.MethodCallingConvention CallingConvention { get { throw null; } set { } }
        public override bool ContainsGenericParameter { get { throw null; } }
        public override Mono.Cecil.TypeReference DeclaringType { get { throw null; } set { } }
        public Mono.Cecil.MethodReference ElementMethod { get { throw null; } }
        public override bool ExplicitThis { get { throw null; } set { } }
        public override bool HasParameters { get { throw null; } }
        public override bool HasThis { get { throw null; } set { } }
        public override Mono.Cecil.MethodReturnType MethodReturnType { get { throw null; } set { } }
        public override Mono.Cecil.ModuleDefinition Module { get { throw null; } }
        public override string Name { get { throw null; } set { } }
        public override Mono.Collections.Generic.Collection<Mono.Cecil.ParameterDefinition> Parameters { get { throw null; } }
        public sealed override Mono.Cecil.MethodReference GetElementMethod() { throw null; }
    }
    [System.FlagsAttribute]
    public enum ModuleAttributes
    {
        ILLibrary = 4,
        ILOnly = 1,
        Preferred32Bit = 131072,
        Required32Bit = 2,
        StrongNameSigned = 8,
    }
    [System.FlagsAttribute]
    public enum ModuleCharacteristics
    {
        AppContainer = 4096,
        DynamicBase = 64,
        HighEntropyVA = 32,
        NoSEH = 1024,
        NXCompat = 256,
        TerminalServerAware = 32768,
    }
    public sealed partial class ModuleDefinition : Mono.Cecil.ModuleReference, Mono.Cecil.Cil.ICustomDebugInformationProvider, Mono.Cecil.ICustomAttributeProvider, Mono.Cecil.IMetadataTokenProvider, System.IDisposable
    {
        internal ModuleDefinition() : base (default(string)) { }
        public Mono.Cecil.TargetArchitecture Architecture { get { throw null; } set { } }
        public Mono.Cecil.AssemblyDefinition Assembly { get { throw null; } }
        public Mono.Collections.Generic.Collection<Mono.Cecil.AssemblyNameReference> AssemblyReferences { get { throw null; } }
        public Mono.Cecil.IAssemblyResolver AssemblyResolver { get { throw null; } }
        public Mono.Cecil.ModuleAttributes Attributes { get { throw null; } set { } }
        public Mono.Cecil.ModuleCharacteristics Characteristics { get { throw null; } set { } }
        public Mono.Collections.Generic.Collection<Mono.Cecil.CustomAttribute> CustomAttributes { get { throw null; } }
        public Mono.Collections.Generic.Collection<Mono.Cecil.Cil.CustomDebugInformation> CustomDebugInformations { get { throw null; } }
        public Mono.Cecil.MethodDefinition EntryPoint { get { throw null; } set { } }
        public Mono.Collections.Generic.Collection<Mono.Cecil.ExportedType> ExportedTypes { get { throw null; } }
        public string FileName { get { throw null; } }
        [System.ObsoleteAttribute("Use FileName")]
        public string FullyQualifiedName { get { throw null; } }
        public bool HasAssemblyReferences { get { throw null; } }
        public bool HasCustomAttributes { get { throw null; } }
        public bool HasCustomDebugInformations { get { throw null; } }
        public bool HasDebugHeader { get { throw null; } }
        public bool HasExportedTypes { get { throw null; } }
        public bool HasModuleReferences { get { throw null; } }
        public bool HasResources { get { throw null; } }
        public bool HasSymbols { get { throw null; } }
        public bool HasTypes { get { throw null; } }
        public bool IsMain { get { throw null; } }
        public Mono.Cecil.ModuleKind Kind { get { throw null; } set { } }
        public Mono.Cecil.MetadataKind MetadataKind { get { throw null; } set { } }
        public Mono.Cecil.IMetadataResolver MetadataResolver { get { throw null; } }
        public override Mono.Cecil.MetadataScopeType MetadataScopeType { get { throw null; } }
        public Mono.Collections.Generic.Collection<Mono.Cecil.ModuleReference> ModuleReferences { get { throw null; } }
        public System.Guid Mvid { get { throw null; } set { } }
        public Mono.Collections.Generic.Collection<Mono.Cecil.Resource> Resources { get { throw null; } }
        public Mono.Cecil.TargetRuntime Runtime { get { throw null; } set { } }
        public string RuntimeVersion { get { throw null; } set { } }
        public Mono.Cecil.Cil.ISymbolReader SymbolReader { get { throw null; } }
        public Mono.Collections.Generic.Collection<Mono.Cecil.TypeDefinition> Types { get { throw null; } }
        public Mono.Cecil.TypeSystem TypeSystem { get { throw null; } }
        public static Mono.Cecil.ModuleDefinition CreateModule(string name, Mono.Cecil.ModuleKind kind) { throw null; }
        public static Mono.Cecil.ModuleDefinition CreateModule(string name, Mono.Cecil.ModuleParameters parameters) { throw null; }
        public void Dispose() { }
        public System.Collections.Generic.IEnumerable<Mono.Cecil.CustomAttribute> GetCustomAttributes() { throw null; }
        public Mono.Cecil.Cil.ImageDebugHeader GetDebugHeader() { throw null; }
        public System.Collections.Generic.IEnumerable<Mono.Cecil.MemberReference> GetMemberReferences() { throw null; }
        public Mono.Cecil.TypeDefinition GetType(string fullName) { throw null; }
        public Mono.Cecil.TypeReference GetType(string fullName, bool runtimeName) { throw null; }
        public Mono.Cecil.TypeDefinition GetType(string @namespace, string name) { throw null; }
        public System.Collections.Generic.IEnumerable<Mono.Cecil.TypeReference> GetTypeReferences() { throw null; }
        public System.Collections.Generic.IEnumerable<Mono.Cecil.TypeDefinition> GetTypes() { throw null; }
        public bool HasTypeReference(string fullName) { throw null; }
        public bool HasTypeReference(string scope, string fullName) { throw null; }
        [System.ObsoleteAttribute("Use ImportReference", false)]
        public Mono.Cecil.FieldReference Import(Mono.Cecil.FieldReference field) { throw null; }
        [System.ObsoleteAttribute("Use ImportReference", false)]
        public Mono.Cecil.FieldReference Import(Mono.Cecil.FieldReference field, Mono.Cecil.IGenericParameterProvider context) { throw null; }
        [System.ObsoleteAttribute("Use ImportReference", false)]
        public Mono.Cecil.MethodReference Import(Mono.Cecil.MethodReference method) { throw null; }
        [System.ObsoleteAttribute("Use ImportReference", false)]
        public Mono.Cecil.MethodReference Import(Mono.Cecil.MethodReference method, Mono.Cecil.IGenericParameterProvider context) { throw null; }
        [System.ObsoleteAttribute("Use ImportReference", false)]
        public Mono.Cecil.TypeReference Import(Mono.Cecil.TypeReference type) { throw null; }
        [System.ObsoleteAttribute("Use ImportReference", false)]
        public Mono.Cecil.TypeReference Import(Mono.Cecil.TypeReference type, Mono.Cecil.IGenericParameterProvider context) { throw null; }
        [System.ObsoleteAttribute("Use ImportReference", false)]
        public Mono.Cecil.FieldReference Import(System.Reflection.FieldInfo field) { throw null; }
        [System.ObsoleteAttribute("Use ImportReference", false)]
        public Mono.Cecil.FieldReference Import(System.Reflection.FieldInfo field, Mono.Cecil.IGenericParameterProvider context) { throw null; }
        [System.ObsoleteAttribute("Use ImportReference", false)]
        public Mono.Cecil.MethodReference Import(System.Reflection.MethodBase method) { throw null; }
        [System.ObsoleteAttribute("Use ImportReference", false)]
        public Mono.Cecil.MethodReference Import(System.Reflection.MethodBase method, Mono.Cecil.IGenericParameterProvider context) { throw null; }
        [System.ObsoleteAttribute("Use ImportReference", false)]
        public Mono.Cecil.TypeReference Import(System.Type type) { throw null; }
        [System.ObsoleteAttribute("Use ImportReference", false)]
        public Mono.Cecil.TypeReference Import(System.Type type, Mono.Cecil.IGenericParameterProvider context) { throw null; }
        public Mono.Cecil.FieldReference ImportReference(Mono.Cecil.FieldReference field) { throw null; }
        public Mono.Cecil.FieldReference ImportReference(Mono.Cecil.FieldReference field, Mono.Cecil.IGenericParameterProvider context) { throw null; }
        public Mono.Cecil.MethodReference ImportReference(Mono.Cecil.MethodReference method) { throw null; }
        public Mono.Cecil.MethodReference ImportReference(Mono.Cecil.MethodReference method, Mono.Cecil.IGenericParameterProvider context) { throw null; }
        public Mono.Cecil.TypeReference ImportReference(Mono.Cecil.TypeReference type) { throw null; }
        public Mono.Cecil.TypeReference ImportReference(Mono.Cecil.TypeReference type, Mono.Cecil.IGenericParameterProvider context) { throw null; }
        public Mono.Cecil.FieldReference ImportReference(System.Reflection.FieldInfo field) { throw null; }
        public Mono.Cecil.FieldReference ImportReference(System.Reflection.FieldInfo field, Mono.Cecil.IGenericParameterProvider context) { throw null; }
        public Mono.Cecil.MethodReference ImportReference(System.Reflection.MethodBase method) { throw null; }
        public Mono.Cecil.MethodReference ImportReference(System.Reflection.MethodBase method, Mono.Cecil.IGenericParameterProvider context) { throw null; }
        public Mono.Cecil.TypeReference ImportReference(System.Type type) { throw null; }
        public Mono.Cecil.TypeReference ImportReference(System.Type type, Mono.Cecil.IGenericParameterProvider context) { throw null; }
        public Mono.Cecil.IMetadataTokenProvider LookupToken(Mono.Cecil.MetadataToken token) { throw null; }
        public Mono.Cecil.IMetadataTokenProvider LookupToken(int token) { throw null; }
        public static Mono.Cecil.ModuleDefinition ReadModule(System.IO.Stream stream) { throw null; }
        public static Mono.Cecil.ModuleDefinition ReadModule(System.IO.Stream stream, Mono.Cecil.ReaderParameters parameters) { throw null; }
        public static Mono.Cecil.ModuleDefinition ReadModule(string fileName) { throw null; }
        public static Mono.Cecil.ModuleDefinition ReadModule(string fileName, Mono.Cecil.ReaderParameters parameters) { throw null; }
        public void ReadSymbols() { }
        public void ReadSymbols(Mono.Cecil.Cil.ISymbolReader reader) { }
        public void ReadSymbols(Mono.Cecil.Cil.ISymbolReader reader, bool throwIfSymbolsAreNotMaching) { }
        public bool TryGetTypeReference(string fullName, out Mono.Cecil.TypeReference type) { throw null; }
        public bool TryGetTypeReference(string scope, string fullName, out Mono.Cecil.TypeReference type) { throw null; }
        public void Write() { }
        public void Write(Mono.Cecil.WriterParameters parameters) { }
        public void Write(System.IO.Stream stream) { }
        public void Write(System.IO.Stream stream, Mono.Cecil.WriterParameters parameters) { }
        public void Write(string fileName) { }
        public void Write(string fileName, Mono.Cecil.WriterParameters parameters) { }
    }
    public enum ModuleKind
    {
        Console = 1,
        Dll = 0,
        NetModule = 3,
        Windows = 2,
    }
    public sealed partial class ModuleParameters
    {
        public ModuleParameters() { }
        public Mono.Cecil.TargetArchitecture Architecture { get { throw null; } set { } }
        public Mono.Cecil.IAssemblyResolver AssemblyResolver { get { throw null; } set { } }
        public Mono.Cecil.ModuleKind Kind { get { throw null; } set { } }
        public Mono.Cecil.IMetadataImporterProvider MetadataImporterProvider { get { throw null; } set { } }
        public Mono.Cecil.IMetadataResolver MetadataResolver { get { throw null; } set { } }
        public Mono.Cecil.IReflectionImporterProvider ReflectionImporterProvider { get { throw null; } set { } }
        public Mono.Cecil.TargetRuntime Runtime { get { throw null; } set { } }
        public System.Nullable<uint> Timestamp { get { throw null; } set { } }
    }
    public partial class ModuleReference : Mono.Cecil.IMetadataScope, Mono.Cecil.IMetadataTokenProvider
    {
        public ModuleReference(string name) { }
        public virtual Mono.Cecil.MetadataScopeType MetadataScopeType { get { throw null; } }
        public Mono.Cecil.MetadataToken MetadataToken { get { throw null; } set { } }
        public string Name { get { throw null; } set { } }
        public override string ToString() { throw null; }
    }
    public enum NativeType
    {
        ANSIBStr = 35,
        Array = 42,
        ASAny = 40,
        Boolean = 2,
        BStr = 19,
        ByValStr = 34,
        Currency = 15,
        CustomMarshaler = 44,
        Error = 45,
        FixedArray = 30,
        FixedSysString = 23,
        Func = 38,
        I1 = 3,
        I2 = 5,
        I4 = 7,
        I8 = 9,
        IDispatch = 26,
        Int = 31,
        IntF = 28,
        IUnknown = 25,
        LPStr = 20,
        LPStruct = 43,
        LPTStr = 22,
        LPWStr = 21,
        Max = 80,
        None = 102,
        R4 = 11,
        R8 = 12,
        SafeArray = 29,
        Struct = 27,
        TBStr = 36,
        U1 = 4,
        U2 = 6,
        U4 = 8,
        U8 = 10,
        UInt = 32,
        VariantBool = 37,
    }
    public sealed partial class OptionalModifierType : Mono.Cecil.TypeSpecification, Mono.Cecil.IModifierType
    {
        public OptionalModifierType(Mono.Cecil.TypeReference modifierType, Mono.Cecil.TypeReference type) { }
        public override bool ContainsGenericParameter { get { throw null; } }
        public override string FullName { get { throw null; } }
        public override bool IsOptionalModifier { get { throw null; } }
        public override bool IsValueType { get { throw null; } set { } }
        public Mono.Cecil.TypeReference ModifierType { get { throw null; } set { } }
        public override string Name { get { throw null; } }
    }
    [System.FlagsAttribute]
    public enum ParameterAttributes : ushort
    {
        HasDefault = (ushort)4096,
        HasFieldMarshal = (ushort)8192,
        In = (ushort)1,
        Lcid = (ushort)4,
        None = (ushort)0,
        Optional = (ushort)16,
        Out = (ushort)2,
        Retval = (ushort)8,
        Unused = (ushort)53216,
    }
    public sealed partial class ParameterDefinition : Mono.Cecil.ParameterReference, Mono.Cecil.IConstantProvider, Mono.Cecil.ICustomAttributeProvider, Mono.Cecil.IMarshalInfoProvider, Mono.Cecil.IMetadataTokenProvider
    {
        public ParameterDefinition(Mono.Cecil.TypeReference parameterType) { }
        public ParameterDefinition(string name, Mono.Cecil.ParameterAttributes attributes, Mono.Cecil.TypeReference parameterType) { }
        public Mono.Cecil.ParameterAttributes Attributes { get { throw null; } set { } }
        public object Constant { get { throw null; } set { } }
        public Mono.Collections.Generic.Collection<Mono.Cecil.CustomAttribute> CustomAttributes { get { throw null; } }
        public bool HasConstant { get { throw null; } set { } }
        public bool HasCustomAttributes { get { throw null; } }
        public bool HasDefault { get { throw null; } set { } }
        public bool HasFieldMarshal { get { throw null; } set { } }
        public bool HasMarshalInfo { get { throw null; } }
        public bool IsIn { get { throw null; } set { } }
        public bool IsLcid { get { throw null; } set { } }
        public bool IsOptional { get { throw null; } set { } }
        public bool IsOut { get { throw null; } set { } }
        public bool IsReturnValue { get { throw null; } set { } }
        public Mono.Cecil.MarshalInfo MarshalInfo { get { throw null; } set { } }
        public Mono.Cecil.IMethodSignature Method { get { throw null; } }
        public int Sequence { get { throw null; } }
        public override Mono.Cecil.ParameterDefinition Resolve() { throw null; }
    }
    public abstract partial class ParameterReference : Mono.Cecil.IMetadataTokenProvider
    {
        internal ParameterReference() { }
        protected Mono.Cecil.TypeReference parameter_type;
        public int Index { get { throw null; } }
        public Mono.Cecil.MetadataToken MetadataToken { get { throw null; } set { } }
        public string Name { get { throw null; } set { } }
        public Mono.Cecil.TypeReference ParameterType { get { throw null; } set { } }
        public abstract Mono.Cecil.ParameterDefinition Resolve();
        public override string ToString() { throw null; }
    }
    public sealed partial class PinnedType : Mono.Cecil.TypeSpecification
    {
        public PinnedType(Mono.Cecil.TypeReference type) { }
        public override bool IsPinned { get { throw null; } }
        public override bool IsValueType { get { throw null; } set { } }
    }
    [System.FlagsAttribute]
    public enum PInvokeAttributes : ushort
    {
        BestFitDisabled = (ushort)32,
        BestFitEnabled = (ushort)16,
        BestFitMask = (ushort)48,
        CallConvCdecl = (ushort)512,
        CallConvFastcall = (ushort)1280,
        CallConvMask = (ushort)1792,
        CallConvStdCall = (ushort)768,
        CallConvThiscall = (ushort)1024,
        CallConvWinapi = (ushort)256,
        CharSetAnsi = (ushort)2,
        CharSetAuto = (ushort)6,
        CharSetMask = (ushort)6,
        CharSetNotSpec = (ushort)0,
        CharSetUnicode = (ushort)4,
        NoMangle = (ushort)1,
        SupportsLastError = (ushort)64,
        ThrowOnUnmappableCharDisabled = (ushort)8192,
        ThrowOnUnmappableCharEnabled = (ushort)4096,
        ThrowOnUnmappableCharMask = (ushort)12288,
    }
    public sealed partial class PInvokeInfo
    {
        public PInvokeInfo(Mono.Cecil.PInvokeAttributes attributes, string entryPoint, Mono.Cecil.ModuleReference module) { }
        public Mono.Cecil.PInvokeAttributes Attributes { get { throw null; } set { } }
        public string EntryPoint { get { throw null; } set { } }
        public bool IsBestFitDisabled { get { throw null; } set { } }
        public bool IsBestFitEnabled { get { throw null; } set { } }
        public bool IsCallConvCdecl { get { throw null; } set { } }
        public bool IsCallConvFastcall { get { throw null; } set { } }
        public bool IsCallConvStdCall { get { throw null; } set { } }
        public bool IsCallConvThiscall { get { throw null; } set { } }
        public bool IsCallConvWinapi { get { throw null; } set { } }
        public bool IsCharSetAnsi { get { throw null; } set { } }
        public bool IsCharSetAuto { get { throw null; } set { } }
        public bool IsCharSetNotSpec { get { throw null; } set { } }
        public bool IsCharSetUnicode { get { throw null; } set { } }
        public bool IsNoMangle { get { throw null; } set { } }
        public bool IsThrowOnUnmappableCharDisabled { get { throw null; } set { } }
        public bool IsThrowOnUnmappableCharEnabled { get { throw null; } set { } }
        public Mono.Cecil.ModuleReference Module { get { throw null; } set { } }
        public bool SupportsLastError { get { throw null; } set { } }
    }
    public sealed partial class PointerType : Mono.Cecil.TypeSpecification
    {
        public PointerType(Mono.Cecil.TypeReference type) { }
        public override string FullName { get { throw null; } }
        public override bool IsPointer { get { throw null; } }
        public override bool IsValueType { get { throw null; } set { } }
        public override string Name { get { throw null; } }
    }
    [System.FlagsAttribute]
    public enum PropertyAttributes : ushort
    {
        HasDefault = (ushort)4096,
        None = (ushort)0,
        RTSpecialName = (ushort)1024,
        SpecialName = (ushort)512,
        Unused = (ushort)59903,
    }
    public sealed partial class PropertyDefinition : Mono.Cecil.PropertyReference, Mono.Cecil.IConstantProvider, Mono.Cecil.ICustomAttributeProvider, Mono.Cecil.IMemberDefinition, Mono.Cecil.IMetadataTokenProvider
    {
        public PropertyDefinition(string name, Mono.Cecil.PropertyAttributes attributes, Mono.Cecil.TypeReference propertyType) { }
        public Mono.Cecil.PropertyAttributes Attributes { get { throw null; } set { } }
        public object Constant { get { throw null; } set { } }
        public Mono.Collections.Generic.Collection<Mono.Cecil.CustomAttribute> CustomAttributes { get { throw null; } }
        public new Mono.Cecil.TypeDefinition DeclaringType { get { throw null; } set { } }
        public override string FullName { get { throw null; } }
        public Mono.Cecil.MethodDefinition GetMethod { get { throw null; } set { } }
        public bool HasConstant { get { throw null; } set { } }
        public bool HasCustomAttributes { get { throw null; } }
        public bool HasDefault { get { throw null; } set { } }
        public bool HasOtherMethods { get { throw null; } }
        public bool HasParameters { get { throw null; } }
        public bool HasThis { get { throw null; } set { } }
        public override bool IsDefinition { get { throw null; } }
        public bool IsRuntimeSpecialName { get { throw null; } set { } }
        public bool IsSpecialName { get { throw null; } set { } }
        public Mono.Collections.Generic.Collection<Mono.Cecil.MethodDefinition> OtherMethods { get { throw null; } }
        public override Mono.Collections.Generic.Collection<Mono.Cecil.ParameterDefinition> Parameters { get { throw null; } }
        public Mono.Cecil.MethodDefinition SetMethod { get { throw null; } set { } }
        public override Mono.Cecil.PropertyDefinition Resolve() { throw null; }
    }
    public abstract partial class PropertyReference : Mono.Cecil.MemberReference
    {
        internal PropertyReference() { }
        public abstract Mono.Collections.Generic.Collection<Mono.Cecil.ParameterDefinition> Parameters { get; }
        public Mono.Cecil.TypeReference PropertyType { get { throw null; } set { } }
        public abstract new Mono.Cecil.PropertyDefinition Resolve();
        protected override Mono.Cecil.IMemberDefinition ResolveDefinition() { throw null; }
    }
    public sealed partial class ReaderParameters
    {
        public ReaderParameters() { }
        public ReaderParameters(Mono.Cecil.ReadingMode readingMode) { }
        public bool ApplyWindowsRuntimeProjections { get { throw null; } set { } }
        public Mono.Cecil.IAssemblyResolver AssemblyResolver { get { throw null; } set { } }
        public bool InMemory { get { throw null; } set { } }
        public Mono.Cecil.IMetadataImporterProvider MetadataImporterProvider { get { throw null; } set { } }
        public Mono.Cecil.IMetadataResolver MetadataResolver { get { throw null; } set { } }
        public Mono.Cecil.ReadingMode ReadingMode { get { throw null; } set { } }
        public bool ReadSymbols { get { throw null; } set { } }
        public bool ReadWrite { get { throw null; } set { } }
        public Mono.Cecil.IReflectionImporterProvider ReflectionImporterProvider { get { throw null; } set { } }
        public Mono.Cecil.Cil.ISymbolReaderProvider SymbolReaderProvider { get { throw null; } set { } }
        public System.IO.Stream SymbolStream { get { throw null; } set { } }
        public bool ThrowIfSymbolsAreNotMatching { get { throw null; } set { } }
    }
    public enum ReadingMode
    {
        Deferred = 2,
        Immediate = 1,
    }
    public sealed partial class RequiredModifierType : Mono.Cecil.TypeSpecification, Mono.Cecil.IModifierType
    {
        public RequiredModifierType(Mono.Cecil.TypeReference modifierType, Mono.Cecil.TypeReference type) { }
        public override bool ContainsGenericParameter { get { throw null; } }
        public override string FullName { get { throw null; } }
        public override bool IsRequiredModifier { get { throw null; } }
        public override bool IsValueType { get { throw null; } set { } }
        public Mono.Cecil.TypeReference ModifierType { get { throw null; } set { } }
        public override string Name { get { throw null; } }
    }
    [System.SerializableAttribute]
    public sealed partial class ResolutionException : System.Exception
    {
        public ResolutionException(Mono.Cecil.MemberReference member) { }
        public ResolutionException(Mono.Cecil.MemberReference member, System.Exception innerException) { }
        public Mono.Cecil.MemberReference Member { get { throw null; } }
        public Mono.Cecil.IMetadataScope Scope { get { throw null; } }
    }
    public abstract partial class Resource
    {
        internal Resource() { }
        public Mono.Cecil.ManifestResourceAttributes Attributes { get { throw null; } set { } }
        public bool IsPrivate { get { throw null; } set { } }
        public bool IsPublic { get { throw null; } set { } }
        public string Name { get { throw null; } set { } }
        public abstract Mono.Cecil.ResourceType ResourceType { get; }
    }
    public enum ResourceType
    {
        AssemblyLinked = 2,
        Embedded = 1,
        Linked = 0,
    }
    public sealed partial class SafeArrayMarshalInfo : Mono.Cecil.MarshalInfo
    {
        public SafeArrayMarshalInfo() : base (default(Mono.Cecil.NativeType)) { }
        public Mono.Cecil.VariantType ElementType { get { throw null; } set { } }
    }
    public enum SecurityAction : ushort
    {
        Assert = (ushort)3,
        Demand = (ushort)2,
        Deny = (ushort)4,
        InheritDemand = (ushort)7,
        LinkDemand = (ushort)6,
        NonCasDemand = (ushort)13,
        NonCasInheritance = (ushort)15,
        NonCasLinkDemand = (ushort)14,
        PermitOnly = (ushort)5,
        PreJitDeny = (ushort)12,
        PreJitGrant = (ushort)11,
        Request = (ushort)1,
        RequestMinimum = (ushort)8,
        RequestOptional = (ushort)9,
        RequestRefuse = (ushort)10,
    }
    [System.Diagnostics.DebuggerDisplayAttribute("{AttributeType}")]
    public sealed partial class SecurityAttribute : Mono.Cecil.ICustomAttribute
    {
        public SecurityAttribute(Mono.Cecil.TypeReference attributeType) { }
        public Mono.Cecil.TypeReference AttributeType { get { throw null; } set { } }
        public Mono.Collections.Generic.Collection<Mono.Cecil.CustomAttributeNamedArgument> Fields { get { throw null; } }
        public bool HasFields { get { throw null; } }
        public bool HasProperties { get { throw null; } }
        Mono.Collections.Generic.Collection<Mono.Cecil.CustomAttributeArgument> Mono.Cecil.ICustomAttribute.ConstructorArguments { get { throw null; } }
        bool Mono.Cecil.ICustomAttribute.HasConstructorArguments { get { throw null; } }
        public Mono.Collections.Generic.Collection<Mono.Cecil.CustomAttributeNamedArgument> Properties { get { throw null; } }
    }
    public sealed partial class SecurityDeclaration
    {
        public SecurityDeclaration(Mono.Cecil.SecurityAction action) { }
        public SecurityDeclaration(Mono.Cecil.SecurityAction action, byte[] blob) { }
        public Mono.Cecil.SecurityAction Action { get { throw null; } set { } }
        public bool HasSecurityAttributes { get { throw null; } }
        public Mono.Collections.Generic.Collection<Mono.Cecil.SecurityAttribute> SecurityAttributes { get { throw null; } }
        public byte[] GetBlob() { throw null; }
    }
    public sealed partial class SentinelType : Mono.Cecil.TypeSpecification
    {
        public SentinelType(Mono.Cecil.TypeReference type) { }
        public override bool IsSentinel { get { throw null; } }
        public override bool IsValueType { get { throw null; } set { } }
    }
    public enum TargetArchitecture
    {
        AMD64 = 34404,
        ARM = 448,
        ARM64 = 43620,
        ARMv7 = 452,
        I386 = 332,
        IA64 = 512,
    }
    public enum TargetRuntime
    {
        Net_1_0 = 0,
        Net_1_1 = 1,
        Net_2_0 = 2,
        Net_4_0 = 3,
    }
    public enum TokenType : uint
    {
        Assembly = (uint)536870912,
        AssemblyRef = (uint)587202560,
        CustomAttribute = (uint)201326592,
        CustomDebugInformation = (uint)922746880,
        Document = (uint)805306368,
        Event = (uint)335544320,
        ExportedType = (uint)654311424,
        Field = (uint)67108864,
        File = (uint)637534208,
        GenericParam = (uint)704643072,
        GenericParamConstraint = (uint)738197504,
        ImportScope = (uint)889192448,
        InterfaceImpl = (uint)150994944,
        LocalConstant = (uint)872415232,
        LocalScope = (uint)838860800,
        LocalVariable = (uint)855638016,
        ManifestResource = (uint)671088640,
        MemberRef = (uint)167772160,
        Method = (uint)100663296,
        MethodDebugInformation = (uint)822083584,
        MethodSpec = (uint)721420288,
        Module = (uint)0,
        ModuleRef = (uint)436207616,
        Param = (uint)134217728,
        Permission = (uint)234881024,
        Property = (uint)385875968,
        Signature = (uint)285212672,
        StateMachineMethod = (uint)905969664,
        String = (uint)1879048192,
        TypeDef = (uint)33554432,
        TypeRef = (uint)16777216,
        TypeSpec = (uint)452984832,
    }
    [System.FlagsAttribute]
    public enum TypeAttributes : uint
    {
        Abstract = (uint)128,
        AnsiClass = (uint)0,
        AutoClass = (uint)131072,
        AutoLayout = (uint)0,
        BeforeFieldInit = (uint)1048576,
        Class = (uint)0,
        ClassSemanticMask = (uint)32,
        ExplicitLayout = (uint)16,
        Forwarder = (uint)2097152,
        HasSecurity = (uint)262144,
        Import = (uint)4096,
        Interface = (uint)32,
        LayoutMask = (uint)24,
        NestedAssembly = (uint)5,
        NestedFamANDAssem = (uint)6,
        NestedFamily = (uint)4,
        NestedFamORAssem = (uint)7,
        NestedPrivate = (uint)3,
        NestedPublic = (uint)2,
        NotPublic = (uint)0,
        Public = (uint)1,
        RTSpecialName = (uint)2048,
        Sealed = (uint)256,
        SequentialLayout = (uint)8,
        Serializable = (uint)8192,
        SpecialName = (uint)1024,
        StringFormatMask = (uint)196608,
        UnicodeClass = (uint)65536,
        VisibilityMask = (uint)7,
        WindowsRuntime = (uint)16384,
    }
    public sealed partial class TypeDefinition : Mono.Cecil.TypeReference, Mono.Cecil.ICustomAttributeProvider, Mono.Cecil.IMemberDefinition, Mono.Cecil.IMetadataTokenProvider, Mono.Cecil.ISecurityDeclarationProvider
    {
        public TypeDefinition(string @namespace, string name, Mono.Cecil.TypeAttributes attributes) : base (default(string), default(string)) { }
        public TypeDefinition(string @namespace, string name, Mono.Cecil.TypeAttributes attributes, Mono.Cecil.TypeReference baseType) : base (default(string), default(string)) { }
        public Mono.Cecil.TypeAttributes Attributes { get { throw null; } set { } }
        public Mono.Cecil.TypeReference BaseType { get { throw null; } set { } }
        public int ClassSize { get { throw null; } set { } }
        public Mono.Collections.Generic.Collection<Mono.Cecil.CustomAttribute> CustomAttributes { get { throw null; } }
        public new Mono.Cecil.TypeDefinition DeclaringType { get { throw null; } set { } }
        public Mono.Collections.Generic.Collection<Mono.Cecil.EventDefinition> Events { get { throw null; } }
        public Mono.Collections.Generic.Collection<Mono.Cecil.FieldDefinition> Fields { get { throw null; } }
        public override Mono.Collections.Generic.Collection<Mono.Cecil.GenericParameter> GenericParameters { get { throw null; } }
        public bool HasCustomAttributes { get { throw null; } }
        public bool HasEvents { get { throw null; } }
        public bool HasFields { get { throw null; } }
        public override bool HasGenericParameters { get { throw null; } }
        public bool HasInterfaces { get { throw null; } }
        public bool HasLayoutInfo { get { throw null; } }
        public bool HasMethods { get { throw null; } }
        public bool HasNestedTypes { get { throw null; } }
        public bool HasProperties { get { throw null; } }
        public bool HasSecurity { get { throw null; } set { } }
        public bool HasSecurityDeclarations { get { throw null; } }
        public Mono.Collections.Generic.Collection<Mono.Cecil.InterfaceImplementation> Interfaces { get { throw null; } }
        public bool IsAbstract { get { throw null; } set { } }
        public bool IsAnsiClass { get { throw null; } set { } }
        public bool IsAutoClass { get { throw null; } set { } }
        public bool IsAutoLayout { get { throw null; } set { } }
        public bool IsBeforeFieldInit { get { throw null; } set { } }
        public bool IsClass { get { throw null; } set { } }
        public override bool IsDefinition { get { throw null; } }
        public bool IsEnum { get { throw null; } }
        public bool IsExplicitLayout { get { throw null; } set { } }
        public bool IsImport { get { throw null; } set { } }
        public bool IsInterface { get { throw null; } set { } }
        public bool IsNestedAssembly { get { throw null; } set { } }
        public bool IsNestedFamily { get { throw null; } set { } }
        public bool IsNestedFamilyAndAssembly { get { throw null; } set { } }
        public bool IsNestedFamilyOrAssembly { get { throw null; } set { } }
        public bool IsNestedPrivate { get { throw null; } set { } }
        public bool IsNestedPublic { get { throw null; } set { } }
        public bool IsNotPublic { get { throw null; } set { } }
        public override bool IsPrimitive { get { throw null; } }
        public bool IsPublic { get { throw null; } set { } }
        public bool IsRuntimeSpecialName { get { throw null; } set { } }
        public bool IsSealed { get { throw null; } set { } }
        public bool IsSequentialLayout { get { throw null; } set { } }
        public bool IsSerializable { get { throw null; } set { } }
        public bool IsSpecialName { get { throw null; } set { } }
        public bool IsUnicodeClass { get { throw null; } set { } }
        public override bool IsValueType { get { throw null; } set { } }
        public bool IsWindowsRuntime { get { throw null; } set { } }
        public override Mono.Cecil.MetadataType MetadataType { get { throw null; } }
        public Mono.Collections.Generic.Collection<Mono.Cecil.MethodDefinition> Methods { get { throw null; } }
        public override string Name { get { throw null; } set { } }
        public Mono.Collections.Generic.Collection<Mono.Cecil.TypeDefinition> NestedTypes { get { throw null; } }
        public short PackingSize { get { throw null; } set { } }
        public Mono.Collections.Generic.Collection<Mono.Cecil.PropertyDefinition> Properties { get { throw null; } }
        public Mono.Collections.Generic.Collection<Mono.Cecil.SecurityDeclaration> SecurityDeclarations { get { throw null; } }
        protected override void ClearFullName() { }
        public override Mono.Cecil.TypeDefinition Resolve() { throw null; }
    }
    public partial class TypeReference : Mono.Cecil.MemberReference, Mono.Cecil.IGenericParameterProvider, Mono.Cecil.IMetadataTokenProvider
    {
        protected Mono.Collections.Generic.Collection<Mono.Cecil.GenericParameter> generic_parameters;
        protected TypeReference(string @namespace, string name) { }
        public TypeReference(string @namespace, string name, Mono.Cecil.ModuleDefinition module, Mono.Cecil.IMetadataScope scope) { }
        public TypeReference(string @namespace, string name, Mono.Cecil.ModuleDefinition module, Mono.Cecil.IMetadataScope scope, bool valueType) { }
        public override Mono.Cecil.TypeReference DeclaringType { get { throw null; } set { } }
        public override string FullName { get { throw null; } }
        public virtual Mono.Collections.Generic.Collection<Mono.Cecil.GenericParameter> GenericParameters { get { throw null; } }
        public virtual bool HasGenericParameters { get { throw null; } }
        public virtual bool IsArray { get { throw null; } }
        public virtual bool IsByReference { get { throw null; } }
        public virtual bool IsFunctionPointer { get { throw null; } }
        public virtual bool IsGenericInstance { get { throw null; } }
        public virtual bool IsGenericParameter { get { throw null; } }
        public bool IsNested { get { throw null; } }
        public virtual bool IsOptionalModifier { get { throw null; } }
        public virtual bool IsPinned { get { throw null; } }
        public virtual bool IsPointer { get { throw null; } }
        public virtual bool IsPrimitive { get { throw null; } }
        public virtual bool IsRequiredModifier { get { throw null; } }
        public virtual bool IsSentinel { get { throw null; } }
        public virtual bool IsValueType { get { throw null; } set { } }
        public virtual Mono.Cecil.MetadataType MetadataType { get { throw null; } }
        public override Mono.Cecil.ModuleDefinition Module { get { throw null; } }
        Mono.Cecil.GenericParameterType Mono.Cecil.IGenericParameterProvider.GenericParameterType { get { throw null; } }
        public override string Name { get { throw null; } set { } }
        public virtual string Namespace { get { throw null; } set { } }
        public virtual Mono.Cecil.IMetadataScope Scope { get { throw null; } set { } }
        protected virtual void ClearFullName() { }
        public virtual Mono.Cecil.TypeReference GetElementType() { throw null; }
        public virtual new Mono.Cecil.TypeDefinition Resolve() { throw null; }
        protected override Mono.Cecil.IMemberDefinition ResolveDefinition() { throw null; }
    }
    public abstract partial class TypeSpecification : Mono.Cecil.TypeReference
    {
        internal TypeSpecification() : base (default(string), default(string)) { }
        public override bool ContainsGenericParameter { get { throw null; } }
        public Mono.Cecil.TypeReference ElementType { get { throw null; } }
        public override string FullName { get { throw null; } }
        public override Mono.Cecil.MetadataType MetadataType { get { throw null; } }
        public override Mono.Cecil.ModuleDefinition Module { get { throw null; } }
        public override string Name { get { throw null; } set { } }
        public override string Namespace { get { throw null; } set { } }
        public override Mono.Cecil.IMetadataScope Scope { get { throw null; } set { } }
        public override Mono.Cecil.TypeReference GetElementType() { throw null; }
    }
    public abstract partial class TypeSystem
    {
        internal TypeSystem() { }
        public Mono.Cecil.TypeReference Boolean { get { throw null; } }
        public Mono.Cecil.TypeReference Byte { get { throw null; } }
        public Mono.Cecil.TypeReference Char { get { throw null; } }
        public Mono.Cecil.IMetadataScope CoreLibrary { get { throw null; } }
        [System.ObsoleteAttribute("Use CoreLibrary")]
        public Mono.Cecil.IMetadataScope Corlib { get { throw null; } }
        public Mono.Cecil.TypeReference Double { get { throw null; } }
        public Mono.Cecil.TypeReference Int16 { get { throw null; } }
        public Mono.Cecil.TypeReference Int32 { get { throw null; } }
        public Mono.Cecil.TypeReference Int64 { get { throw null; } }
        public Mono.Cecil.TypeReference IntPtr { get { throw null; } }
        public Mono.Cecil.TypeReference Object { get { throw null; } }
        public Mono.Cecil.TypeReference SByte { get { throw null; } }
        public Mono.Cecil.TypeReference Single { get { throw null; } }
        public Mono.Cecil.TypeReference String { get { throw null; } }
        public Mono.Cecil.TypeReference TypedReference { get { throw null; } }
        public Mono.Cecil.TypeReference UInt16 { get { throw null; } }
        public Mono.Cecil.TypeReference UInt32 { get { throw null; } }
        public Mono.Cecil.TypeReference UInt64 { get { throw null; } }
        public Mono.Cecil.TypeReference UIntPtr { get { throw null; } }
        public Mono.Cecil.TypeReference Void { get { throw null; } }
    }
    public enum VariantType
    {
        Bool = 11,
        BStr = 8,
        CY = 6,
        Date = 7,
        Decimal = 14,
        Dispatch = 9,
        Error = 10,
        I1 = 16,
        I2 = 2,
        I4 = 3,
        I8 = 20,
        Int = 22,
        None = 0,
        R4 = 4,
        R8 = 5,
        UI1 = 17,
        UI2 = 18,
        UI4 = 19,
        UI8 = 21,
        UInt = 23,
        Unknown = 13,
        Variant = 12,
    }
    public sealed partial class WriterParameters
    {
        public WriterParameters() { }
        public bool DeterministicMvid { get { throw null; } set { } }
        public bool HasStrongNameKey { get { throw null; } }
        public byte[] StrongNameKeyBlob { get { throw null; } set { } }
        public string StrongNameKeyContainer { get { throw null; } set { } }
        public System.Reflection.StrongNameKeyPair StrongNameKeyPair { get { throw null; } set { } }
        public System.IO.Stream SymbolStream { get { throw null; } set { } }
        public Mono.Cecil.Cil.ISymbolWriterProvider SymbolWriterProvider { get { throw null; } set { } }
        public System.Nullable<uint> Timestamp { get { throw null; } set { } }
        public bool WriteSymbols { get { throw null; } set { } }
    }
}
namespace Mono.Cecil.Cil
{
    public sealed partial class AsyncMethodBodyDebugInformation : Mono.Cecil.Cil.CustomDebugInformation
    {
        public static System.Guid KindIdentifier;
        public AsyncMethodBodyDebugInformation() { }
        public AsyncMethodBodyDebugInformation(Mono.Cecil.Cil.Instruction catchHandler) { }
        public Mono.Cecil.Cil.InstructionOffset CatchHandler { get { throw null; } set { } }
        public override Mono.Cecil.Cil.CustomDebugInformationKind Kind { get { throw null; } }
        public Mono.Collections.Generic.Collection<Mono.Cecil.MethodDefinition> ResumeMethods { get { throw null; } }
        public Mono.Collections.Generic.Collection<Mono.Cecil.Cil.InstructionOffset> Resumes { get { throw null; } }
        public Mono.Collections.Generic.Collection<Mono.Cecil.Cil.InstructionOffset> Yields { get { throw null; } }
    }
    public sealed partial class BinaryCustomDebugInformation : Mono.Cecil.Cil.CustomDebugInformation
    {
        public BinaryCustomDebugInformation(System.Guid identifier, byte[] data) { }
        public byte[] Data { get { throw null; } set { } }
        public override Mono.Cecil.Cil.CustomDebugInformationKind Kind { get { throw null; } }
    }
    public enum Code
    {
        Add = 87,
        Add_Ovf = 180,
        Add_Ovf_Un = 181,
        And = 94,
        Arglist = 191,
        Beq = 58,
        Beq_S = 45,
        Bge = 59,
        Bge_S = 46,
        Bge_Un = 64,
        Bge_Un_S = 51,
        Bgt = 60,
        Bgt_S = 47,
        Bgt_Un = 65,
        Bgt_Un_S = 52,
        Ble = 61,
        Ble_S = 48,
        Ble_Un = 66,
        Ble_Un_S = 53,
        Blt = 62,
        Blt_S = 49,
        Blt_Un = 67,
        Blt_Un_S = 54,
        Bne_Un = 63,
        Bne_Un_S = 50,
        Box = 137,
        Br = 55,
        Break = 1,
        Brfalse = 56,
        Brfalse_S = 43,
        Brtrue = 57,
        Brtrue_S = 44,
        Br_S = 42,
        Call = 39,
        Calli = 40,
        Callvirt = 110,
        Castclass = 115,
        Ceq = 192,
        Cgt = 193,
        Cgt_Un = 194,
        Ckfinite = 172,
        Clt = 195,
        Clt_Un = 196,
        Constrained = 211,
        Conv_I = 177,
        Conv_I1 = 102,
        Conv_I2 = 103,
        Conv_I4 = 104,
        Conv_I8 = 105,
        Conv_Ovf_I = 178,
        Conv_Ovf_I1 = 163,
        Conv_Ovf_I1_Un = 127,
        Conv_Ovf_I2 = 165,
        Conv_Ovf_I2_Un = 128,
        Conv_Ovf_I4 = 167,
        Conv_Ovf_I4_Un = 129,
        Conv_Ovf_I8 = 169,
        Conv_Ovf_I8_Un = 130,
        Conv_Ovf_I_Un = 135,
        Conv_Ovf_U = 179,
        Conv_Ovf_U1 = 164,
        Conv_Ovf_U1_Un = 131,
        Conv_Ovf_U2 = 166,
        Conv_Ovf_U2_Un = 132,
        Conv_Ovf_U4 = 168,
        Conv_Ovf_U4_Un = 133,
        Conv_Ovf_U8 = 170,
        Conv_Ovf_U8_Un = 134,
        Conv_Ovf_U_Un = 136,
        Conv_R4 = 106,
        Conv_R8 = 107,
        Conv_R_Un = 117,
        Conv_U = 190,
        Conv_U1 = 176,
        Conv_U2 = 175,
        Conv_U4 = 108,
        Conv_U8 = 109,
        Cpblk = 212,
        Cpobj = 111,
        Div = 90,
        Div_Un = 91,
        Dup = 36,
        Endfilter = 206,
        Endfinally = 186,
        Initblk = 213,
        Initobj = 210,
        Isinst = 116,
        Jmp = 38,
        Ldarg = 199,
        Ldarga = 200,
        Ldarga_S = 15,
        Ldarg_0 = 2,
        Ldarg_1 = 3,
        Ldarg_2 = 4,
        Ldarg_3 = 5,
        Ldarg_S = 14,
        Ldc_I4 = 32,
        Ldc_I4_0 = 22,
        Ldc_I4_1 = 23,
        Ldc_I4_2 = 24,
        Ldc_I4_3 = 25,
        Ldc_I4_4 = 26,
        Ldc_I4_5 = 27,
        Ldc_I4_6 = 28,
        Ldc_I4_7 = 29,
        Ldc_I4_8 = 30,
        Ldc_I4_M1 = 21,
        Ldc_I4_S = 31,
        Ldc_I8 = 33,
        Ldc_R4 = 34,
        Ldc_R8 = 35,
        Ldelema = 140,
        Ldelem_Any = 160,
        Ldelem_I = 148,
        Ldelem_I1 = 141,
        Ldelem_I2 = 143,
        Ldelem_I4 = 145,
        Ldelem_I8 = 147,
        Ldelem_R4 = 149,
        Ldelem_R8 = 150,
        Ldelem_Ref = 151,
        Ldelem_U1 = 142,
        Ldelem_U2 = 144,
        Ldelem_U4 = 146,
        Ldfld = 120,
        Ldflda = 121,
        Ldftn = 197,
        Ldind_I = 76,
        Ldind_I1 = 69,
        Ldind_I2 = 71,
        Ldind_I4 = 73,
        Ldind_I8 = 75,
        Ldind_R4 = 77,
        Ldind_R8 = 78,
        Ldind_Ref = 79,
        Ldind_U1 = 70,
        Ldind_U2 = 72,
        Ldind_U4 = 74,
        Ldlen = 139,
        Ldloc = 202,
        Ldloca = 203,
        Ldloca_S = 18,
        Ldloc_0 = 6,
        Ldloc_1 = 7,
        Ldloc_2 = 8,
        Ldloc_3 = 9,
        Ldloc_S = 17,
        Ldnull = 20,
        Ldobj = 112,
        Ldsfld = 123,
        Ldsflda = 124,
        Ldstr = 113,
        Ldtoken = 174,
        Ldvirtftn = 198,
        Leave = 187,
        Leave_S = 188,
        Localloc = 205,
        Mkrefany = 173,
        Mul = 89,
        Mul_Ovf = 182,
        Mul_Ovf_Un = 183,
        Neg = 100,
        Newarr = 138,
        Newobj = 114,
        No = 214,
        Nop = 0,
        Not = 101,
        Or = 95,
        Pop = 37,
        Readonly = 218,
        Refanytype = 217,
        Refanyval = 171,
        Rem = 92,
        Rem_Un = 93,
        Ret = 41,
        Rethrow = 215,
        Shl = 97,
        Shr = 98,
        Shr_Un = 99,
        Sizeof = 216,
        Starg = 201,
        Starg_S = 16,
        Stelem_Any = 161,
        Stelem_I = 152,
        Stelem_I1 = 153,
        Stelem_I2 = 154,
        Stelem_I4 = 155,
        Stelem_I8 = 156,
        Stelem_R4 = 157,
        Stelem_R8 = 158,
        Stelem_Ref = 159,
        Stfld = 122,
        Stind_I = 189,
        Stind_I1 = 81,
        Stind_I2 = 82,
        Stind_I4 = 83,
        Stind_I8 = 84,
        Stind_R4 = 85,
        Stind_R8 = 86,
        Stind_Ref = 80,
        Stloc = 204,
        Stloc_0 = 10,
        Stloc_1 = 11,
        Stloc_2 = 12,
        Stloc_3 = 13,
        Stloc_S = 19,
        Stobj = 126,
        Stsfld = 125,
        Sub = 88,
        Sub_Ovf = 184,
        Sub_Ovf_Un = 185,
        Switch = 68,
        Tail = 209,
        Throw = 119,
        Unaligned = 207,
        Unbox = 118,
        Unbox_Any = 162,
        Volatile = 208,
        Xor = 96,
    }
    public sealed partial class ConstantDebugInformation : Mono.Cecil.Cil.DebugInformation
    {
        public ConstantDebugInformation(string name, Mono.Cecil.TypeReference constant_type, object value) { }
        public Mono.Cecil.TypeReference ConstantType { get { throw null; } set { } }
        public string Name { get { throw null; } set { } }
        public object Value { get { throw null; } set { } }
    }
    public abstract partial class CustomDebugInformation : Mono.Cecil.Cil.DebugInformation
    {
        internal CustomDebugInformation() { }
        public System.Guid Identifier { get { throw null; } }
        public abstract Mono.Cecil.Cil.CustomDebugInformationKind Kind { get; }
    }
    public enum CustomDebugInformationKind
    {
        AsyncMethodBody = 4,
        Binary = 0,
        DefaultNamespace = 3,
        DynamicVariable = 2,
        EmbeddedSource = 5,
        SourceLink = 6,
        StateMachineScope = 1,
    }
    public abstract partial class DebugInformation : Mono.Cecil.Cil.ICustomDebugInformationProvider, Mono.Cecil.IMetadataTokenProvider
    {
        internal DebugInformation() { }
        public Mono.Collections.Generic.Collection<Mono.Cecil.Cil.CustomDebugInformation> CustomDebugInformations { get { throw null; } }
        public bool HasCustomDebugInformations { get { throw null; } }
        public Mono.Cecil.MetadataToken MetadataToken { get { throw null; } set { } }
    }
    public partial class DefaultSymbolReaderProvider : Mono.Cecil.Cil.ISymbolReaderProvider
    {
        public DefaultSymbolReaderProvider() { }
        public DefaultSymbolReaderProvider(bool throwIfNoSymbol) { }
        public Mono.Cecil.Cil.ISymbolReader GetSymbolReader(Mono.Cecil.ModuleDefinition module, System.IO.Stream symbolStream) { throw null; }
        public Mono.Cecil.Cil.ISymbolReader GetSymbolReader(Mono.Cecil.ModuleDefinition module, string fileName) { throw null; }
    }
    public partial class DefaultSymbolWriterProvider : Mono.Cecil.Cil.ISymbolWriterProvider
    {
        public DefaultSymbolWriterProvider() { }
        public Mono.Cecil.Cil.ISymbolWriter GetSymbolWriter(Mono.Cecil.ModuleDefinition module, System.IO.Stream symbolStream) { throw null; }
        public Mono.Cecil.Cil.ISymbolWriter GetSymbolWriter(Mono.Cecil.ModuleDefinition module, string fileName) { throw null; }
    }
    public sealed partial class Document : Mono.Cecil.Cil.DebugInformation
    {
        public Document(string url) { }
        public byte[] EmbeddedSource { get { throw null; } set { } }
        public byte[] Hash { get { throw null; } set { } }
        public Mono.Cecil.Cil.DocumentHashAlgorithm HashAlgorithm { get { throw null; } set { } }
        public System.Guid HashAlgorithmGuid { get { throw null; } set { } }
        public Mono.Cecil.Cil.DocumentLanguage Language { get { throw null; } set { } }
        public System.Guid LanguageGuid { get { throw null; } set { } }
        public Mono.Cecil.Cil.DocumentLanguageVendor LanguageVendor { get { throw null; } set { } }
        public System.Guid LanguageVendorGuid { get { throw null; } set { } }
        public Mono.Cecil.Cil.DocumentType Type { get { throw null; } set { } }
        public System.Guid TypeGuid { get { throw null; } set { } }
        public string Url { get { throw null; } set { } }
    }
    public enum DocumentHashAlgorithm
    {
        MD5 = 1,
        None = 0,
        SHA1 = 2,
        SHA256 = 3,
    }
    public enum DocumentLanguage
    {
        Basic = 4,
        C = 1,
        Cil = 8,
        Cobol = 6,
        Cpp = 2,
        CSharp = 3,
        FSharp = 12,
        Java = 5,
        JScript = 9,
        MCpp = 11,
        Other = 0,
        Pascal = 7,
        Smc = 10,
    }
    public enum DocumentLanguageVendor
    {
        Microsoft = 1,
        Other = 0,
    }
    public enum DocumentType
    {
        Other = 0,
        Text = 1,
    }
    public sealed partial class EmbeddedPortablePdbReader : Mono.Cecil.Cil.ISymbolReader, System.IDisposable
    {
        internal EmbeddedPortablePdbReader() { }
        public void Dispose() { }
        public Mono.Cecil.Cil.ISymbolWriterProvider GetWriterProvider() { throw null; }
        public bool ProcessDebugHeader(Mono.Cecil.Cil.ImageDebugHeader header) { throw null; }
        public Mono.Cecil.Cil.MethodDebugInformation Read(Mono.Cecil.MethodDefinition method) { throw null; }
    }
    public sealed partial class EmbeddedPortablePdbReaderProvider : Mono.Cecil.Cil.ISymbolReaderProvider
    {
        public EmbeddedPortablePdbReaderProvider() { }
        public Mono.Cecil.Cil.ISymbolReader GetSymbolReader(Mono.Cecil.ModuleDefinition module, System.IO.Stream symbolStream) { throw null; }
        public Mono.Cecil.Cil.ISymbolReader GetSymbolReader(Mono.Cecil.ModuleDefinition module, string fileName) { throw null; }
    }
    public sealed partial class EmbeddedPortablePdbWriter : Mono.Cecil.Cil.ISymbolWriter, System.IDisposable
    {
        internal EmbeddedPortablePdbWriter() { }
        public void Dispose() { }
        public Mono.Cecil.Cil.ImageDebugHeader GetDebugHeader() { throw null; }
        public Mono.Cecil.Cil.ISymbolReaderProvider GetReaderProvider() { throw null; }
        public void Write(Mono.Cecil.Cil.MethodDebugInformation info) { }
    }
    public sealed partial class EmbeddedPortablePdbWriterProvider : Mono.Cecil.Cil.ISymbolWriterProvider
    {
        public EmbeddedPortablePdbWriterProvider() { }
        public Mono.Cecil.Cil.ISymbolWriter GetSymbolWriter(Mono.Cecil.ModuleDefinition module, System.IO.Stream symbolStream) { throw null; }
        public Mono.Cecil.Cil.ISymbolWriter GetSymbolWriter(Mono.Cecil.ModuleDefinition module, string fileName) { throw null; }
    }
    public sealed partial class EmbeddedSourceDebugInformation : Mono.Cecil.Cil.CustomDebugInformation
    {
        public static System.Guid KindIdentifier;
        public EmbeddedSourceDebugInformation(byte[] content, bool compress) { }
        public bool Compress { get { throw null; } set { } }
        public byte[] Content { get { throw null; } set { } }
        public override Mono.Cecil.Cil.CustomDebugInformationKind Kind { get { throw null; } }
    }
    public sealed partial class ExceptionHandler
    {
        public ExceptionHandler(Mono.Cecil.Cil.ExceptionHandlerType handlerType) { }
        public Mono.Cecil.TypeReference CatchType { get { throw null; } set { } }
        public Mono.Cecil.Cil.Instruction FilterStart { get { throw null; } set { } }
        public Mono.Cecil.Cil.Instruction HandlerEnd { get { throw null; } set { } }
        public Mono.Cecil.Cil.Instruction HandlerStart { get { throw null; } set { } }
        public Mono.Cecil.Cil.ExceptionHandlerType HandlerType { get { throw null; } set { } }
        public Mono.Cecil.Cil.Instruction TryEnd { get { throw null; } set { } }
        public Mono.Cecil.Cil.Instruction TryStart { get { throw null; } set { } }
    }
    public enum ExceptionHandlerType
    {
        Catch = 0,
        Fault = 4,
        Filter = 1,
        Finally = 2,
    }
    public enum FlowControl
    {
        Branch = 0,
        Break = 1,
        Call = 2,
        Cond_Branch = 3,
        Meta = 4,
        Next = 5,
        Phi = 6,
        Return = 7,
        Throw = 8,
    }
    public partial interface ICustomDebugInformationProvider : Mono.Cecil.IMetadataTokenProvider
    {
        Mono.Collections.Generic.Collection<Mono.Cecil.Cil.CustomDebugInformation> CustomDebugInformations { get; }
        bool HasCustomDebugInformations { get; }
    }
    public sealed partial class ILProcessor
    {
        internal ILProcessor() { }
        public Mono.Cecil.Cil.MethodBody Body { get { throw null; } }
        public void Append(Mono.Cecil.Cil.Instruction instruction) { }
        public Mono.Cecil.Cil.Instruction Create(Mono.Cecil.Cil.OpCode opcode) { throw null; }
        public Mono.Cecil.Cil.Instruction Create(Mono.Cecil.Cil.OpCode opcode, Mono.Cecil.CallSite site) { throw null; }
        public Mono.Cecil.Cil.Instruction Create(Mono.Cecil.Cil.OpCode opcode, Mono.Cecil.Cil.Instruction target) { throw null; }
        public Mono.Cecil.Cil.Instruction Create(Mono.Cecil.Cil.OpCode opcode, Mono.Cecil.Cil.Instruction[] targets) { throw null; }
        public Mono.Cecil.Cil.Instruction Create(Mono.Cecil.Cil.OpCode opcode, Mono.Cecil.Cil.VariableDefinition variable) { throw null; }
        public Mono.Cecil.Cil.Instruction Create(Mono.Cecil.Cil.OpCode opcode, Mono.Cecil.FieldReference field) { throw null; }
        public Mono.Cecil.Cil.Instruction Create(Mono.Cecil.Cil.OpCode opcode, Mono.Cecil.MethodReference method) { throw null; }
        public Mono.Cecil.Cil.Instruction Create(Mono.Cecil.Cil.OpCode opcode, Mono.Cecil.ParameterDefinition parameter) { throw null; }
        public Mono.Cecil.Cil.Instruction Create(Mono.Cecil.Cil.OpCode opcode, Mono.Cecil.TypeReference type) { throw null; }
        public Mono.Cecil.Cil.Instruction Create(Mono.Cecil.Cil.OpCode opcode, byte value) { throw null; }
        public Mono.Cecil.Cil.Instruction Create(Mono.Cecil.Cil.OpCode opcode, double value) { throw null; }
        public Mono.Cecil.Cil.Instruction Create(Mono.Cecil.Cil.OpCode opcode, int value) { throw null; }
        public Mono.Cecil.Cil.Instruction Create(Mono.Cecil.Cil.OpCode opcode, long value) { throw null; }
        public Mono.Cecil.Cil.Instruction Create(Mono.Cecil.Cil.OpCode opcode, sbyte value) { throw null; }
        public Mono.Cecil.Cil.Instruction Create(Mono.Cecil.Cil.OpCode opcode, float value) { throw null; }
        public Mono.Cecil.Cil.Instruction Create(Mono.Cecil.Cil.OpCode opcode, string value) { throw null; }
        public void Emit(Mono.Cecil.Cil.OpCode opcode) { }
        public void Emit(Mono.Cecil.Cil.OpCode opcode, Mono.Cecil.CallSite site) { }
        public void Emit(Mono.Cecil.Cil.OpCode opcode, Mono.Cecil.Cil.Instruction target) { }
        public void Emit(Mono.Cecil.Cil.OpCode opcode, Mono.Cecil.Cil.Instruction[] targets) { }
        public void Emit(Mono.Cecil.Cil.OpCode opcode, Mono.Cecil.Cil.VariableDefinition variable) { }
        public void Emit(Mono.Cecil.Cil.OpCode opcode, Mono.Cecil.FieldReference field) { }
        public void Emit(Mono.Cecil.Cil.OpCode opcode, Mono.Cecil.MethodReference method) { }
        public void Emit(Mono.Cecil.Cil.OpCode opcode, Mono.Cecil.ParameterDefinition parameter) { }
        public void Emit(Mono.Cecil.Cil.OpCode opcode, Mono.Cecil.TypeReference type) { }
        public void Emit(Mono.Cecil.Cil.OpCode opcode, byte value) { }
        public void Emit(Mono.Cecil.Cil.OpCode opcode, double value) { }
        public void Emit(Mono.Cecil.Cil.OpCode opcode, int value) { }
        public void Emit(Mono.Cecil.Cil.OpCode opcode, long value) { }
        public void Emit(Mono.Cecil.Cil.OpCode opcode, sbyte value) { }
        public void Emit(Mono.Cecil.Cil.OpCode opcode, float value) { }
        public void Emit(Mono.Cecil.Cil.OpCode opcode, string value) { }
        public void InsertAfter(Mono.Cecil.Cil.Instruction target, Mono.Cecil.Cil.Instruction instruction) { }
        public void InsertAfter(int index, Mono.Cecil.Cil.Instruction instruction) { }
        public void InsertBefore(Mono.Cecil.Cil.Instruction target, Mono.Cecil.Cil.Instruction instruction) { }
        public void Remove(Mono.Cecil.Cil.Instruction instruction) { }
        public void RemoveAt(int index) { }
        public void Replace(Mono.Cecil.Cil.Instruction target, Mono.Cecil.Cil.Instruction instruction) { }
        public void Replace(int index, Mono.Cecil.Cil.Instruction instruction) { }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public partial struct ImageDebugDirectory
    {
        public int AddressOfRawData;
        public int Characteristics;
        public short MajorVersion;
        public short MinorVersion;
        public int PointerToRawData;
        public const int Size = 28;
        public int SizeOfData;
        public int TimeDateStamp;
        public Mono.Cecil.Cil.ImageDebugType Type;
    }
    public sealed partial class ImageDebugHeader
    {
        public ImageDebugHeader() { }
        public ImageDebugHeader(Mono.Cecil.Cil.ImageDebugHeaderEntry entry) { }
        public ImageDebugHeader(Mono.Cecil.Cil.ImageDebugHeaderEntry[] entries) { }
        public Mono.Cecil.Cil.ImageDebugHeaderEntry[] Entries { get { throw null; } }
        public bool HasEntries { get { throw null; } }
    }
    public sealed partial class ImageDebugHeaderEntry
    {
        public ImageDebugHeaderEntry(Mono.Cecil.Cil.ImageDebugDirectory directory, byte[] data) { }
        public byte[] Data { get { throw null; } }
        public Mono.Cecil.Cil.ImageDebugDirectory Directory { get { throw null; } }
    }
    public enum ImageDebugType
    {
        CodeView = 2,
        Deterministic = 16,
        EmbeddedPortablePdb = 17,
    }
    public sealed partial class ImportDebugInformation : Mono.Cecil.Cil.DebugInformation
    {
        public ImportDebugInformation() { }
        public bool HasTargets { get { throw null; } }
        public Mono.Cecil.Cil.ImportDebugInformation Parent { get { throw null; } set { } }
        public Mono.Collections.Generic.Collection<Mono.Cecil.Cil.ImportTarget> Targets { get { throw null; } }
    }
    public sealed partial class ImportTarget
    {
        public ImportTarget(Mono.Cecil.Cil.ImportTargetKind kind) { }
        public string Alias { get { throw null; } set { } }
        public Mono.Cecil.AssemblyNameReference AssemblyReference { get { throw null; } set { } }
        public Mono.Cecil.Cil.ImportTargetKind Kind { get { throw null; } set { } }
        public string Namespace { get { throw null; } set { } }
        public Mono.Cecil.TypeReference Type { get { throw null; } set { } }
    }
    public enum ImportTargetKind : byte
    {
        DefineAssemblyAlias = (byte)6,
        DefineNamespaceAlias = (byte)7,
        DefineNamespaceInAssemblyAlias = (byte)8,
        DefineTypeAlias = (byte)9,
        ImportAlias = (byte)5,
        ImportNamespace = (byte)1,
        ImportNamespaceInAssembly = (byte)2,
        ImportType = (byte)3,
        ImportXmlNamespaceWithAlias = (byte)4,
    }
    public sealed partial class Instruction
    {
        internal Instruction() { }
        public Mono.Cecil.Cil.Instruction Next { get { throw null; } set { } }
        public int Offset { get { throw null; } set { } }
        public Mono.Cecil.Cil.OpCode OpCode { get { throw null; } set { } }
        public object Operand { get { throw null; } set { } }
        public Mono.Cecil.Cil.Instruction Previous { get { throw null; } set { } }
        public static Mono.Cecil.Cil.Instruction Create(Mono.Cecil.Cil.OpCode opcode) { throw null; }
        public static Mono.Cecil.Cil.Instruction Create(Mono.Cecil.Cil.OpCode opcode, Mono.Cecil.CallSite site) { throw null; }
        public static Mono.Cecil.Cil.Instruction Create(Mono.Cecil.Cil.OpCode opcode, Mono.Cecil.Cil.Instruction target) { throw null; }
        public static Mono.Cecil.Cil.Instruction Create(Mono.Cecil.Cil.OpCode opcode, Mono.Cecil.Cil.Instruction[] targets) { throw null; }
        public static Mono.Cecil.Cil.Instruction Create(Mono.Cecil.Cil.OpCode opcode, Mono.Cecil.Cil.VariableDefinition variable) { throw null; }
        public static Mono.Cecil.Cil.Instruction Create(Mono.Cecil.Cil.OpCode opcode, Mono.Cecil.FieldReference field) { throw null; }
        public static Mono.Cecil.Cil.Instruction Create(Mono.Cecil.Cil.OpCode opcode, Mono.Cecil.MethodReference method) { throw null; }
        public static Mono.Cecil.Cil.Instruction Create(Mono.Cecil.Cil.OpCode opcode, Mono.Cecil.ParameterDefinition parameter) { throw null; }
        public static Mono.Cecil.Cil.Instruction Create(Mono.Cecil.Cil.OpCode opcode, Mono.Cecil.TypeReference type) { throw null; }
        public static Mono.Cecil.Cil.Instruction Create(Mono.Cecil.Cil.OpCode opcode, byte value) { throw null; }
        public static Mono.Cecil.Cil.Instruction Create(Mono.Cecil.Cil.OpCode opcode, double value) { throw null; }
        public static Mono.Cecil.Cil.Instruction Create(Mono.Cecil.Cil.OpCode opcode, int value) { throw null; }
        public static Mono.Cecil.Cil.Instruction Create(Mono.Cecil.Cil.OpCode opcode, long value) { throw null; }
        public static Mono.Cecil.Cil.Instruction Create(Mono.Cecil.Cil.OpCode opcode, sbyte value) { throw null; }
        public static Mono.Cecil.Cil.Instruction Create(Mono.Cecil.Cil.OpCode opcode, float value) { throw null; }
        public static Mono.Cecil.Cil.Instruction Create(Mono.Cecil.Cil.OpCode opcode, string value) { throw null; }
        public int GetSize() { throw null; }
        public override string ToString() { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public partial struct InstructionOffset
    {
        private object _dummy;
        private int _dummyPrimitive;
        public InstructionOffset(Mono.Cecil.Cil.Instruction instruction) { throw null; }
        public InstructionOffset(int offset) { throw null; }
        public bool IsEndOfMethod { get { throw null; } }
        public int Offset { get { throw null; } }
    }
    public partial interface ISymbolReader : System.IDisposable
    {
        Mono.Cecil.Cil.ISymbolWriterProvider GetWriterProvider();
        bool ProcessDebugHeader(Mono.Cecil.Cil.ImageDebugHeader header);
        Mono.Cecil.Cil.MethodDebugInformation Read(Mono.Cecil.MethodDefinition method);
    }
    public partial interface ISymbolReaderProvider
    {
        Mono.Cecil.Cil.ISymbolReader GetSymbolReader(Mono.Cecil.ModuleDefinition module, System.IO.Stream symbolStream);
        Mono.Cecil.Cil.ISymbolReader GetSymbolReader(Mono.Cecil.ModuleDefinition module, string fileName);
    }
    public partial interface ISymbolWriter : System.IDisposable
    {
        Mono.Cecil.Cil.ImageDebugHeader GetDebugHeader();
        Mono.Cecil.Cil.ISymbolReaderProvider GetReaderProvider();
        void Write(Mono.Cecil.Cil.MethodDebugInformation info);
    }
    public partial interface ISymbolWriterProvider
    {
        Mono.Cecil.Cil.ISymbolWriter GetSymbolWriter(Mono.Cecil.ModuleDefinition module, System.IO.Stream symbolStream);
        Mono.Cecil.Cil.ISymbolWriter GetSymbolWriter(Mono.Cecil.ModuleDefinition module, string fileName);
    }
    public sealed partial class MethodBody
    {
        public MethodBody(Mono.Cecil.MethodDefinition method) { }
        public int CodeSize { get { throw null; } }
        public Mono.Collections.Generic.Collection<Mono.Cecil.Cil.ExceptionHandler> ExceptionHandlers { get { throw null; } }
        public bool HasExceptionHandlers { get { throw null; } }
        public bool HasVariables { get { throw null; } }
        public bool InitLocals { get { throw null; } set { } }
        public Mono.Collections.Generic.Collection<Mono.Cecil.Cil.Instruction> Instructions { get { throw null; } }
        public Mono.Cecil.MetadataToken LocalVarToken { get { throw null; } set { } }
        public int MaxStackSize { get { throw null; } set { } }
        public Mono.Cecil.MethodDefinition Method { get { throw null; } }
        public Mono.Cecil.ParameterDefinition ThisParameter { get { throw null; } }
        public Mono.Collections.Generic.Collection<Mono.Cecil.Cil.VariableDefinition> Variables { get { throw null; } }
        public Mono.Cecil.Cil.ILProcessor GetILProcessor() { throw null; }
    }
    public sealed partial class MethodDebugInformation : Mono.Cecil.Cil.DebugInformation
    {
        internal MethodDebugInformation() { }
        public bool HasSequencePoints { get { throw null; } }
        public Mono.Cecil.MethodDefinition Method { get { throw null; } }
        public Mono.Cecil.Cil.ScopeDebugInformation Scope { get { throw null; } set { } }
        public Mono.Collections.Generic.Collection<Mono.Cecil.Cil.SequencePoint> SequencePoints { get { throw null; } }
        public Mono.Cecil.MethodDefinition StateMachineKickOffMethod { get { throw null; } set { } }
        public System.Collections.Generic.IEnumerable<Mono.Cecil.Cil.ScopeDebugInformation> GetScopes() { throw null; }
        public Mono.Cecil.Cil.SequencePoint GetSequencePoint(Mono.Cecil.Cil.Instruction instruction) { throw null; }
        public System.Collections.Generic.IDictionary<Mono.Cecil.Cil.Instruction, Mono.Cecil.Cil.SequencePoint> GetSequencePointMapping() { throw null; }
        public bool TryGetName(Mono.Cecil.Cil.VariableDefinition variable, out string name) { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public partial struct OpCode : System.IEquatable<Mono.Cecil.Cil.OpCode>
    {
        private int _dummyPrimitive;
        public Mono.Cecil.Cil.Code Code { get { throw null; } }
        public Mono.Cecil.Cil.FlowControl FlowControl { get { throw null; } }
        public string Name { get { throw null; } }
        public byte Op1 { get { throw null; } }
        public byte Op2 { get { throw null; } }
        public Mono.Cecil.Cil.OpCodeType OpCodeType { get { throw null; } }
        public Mono.Cecil.Cil.OperandType OperandType { get { throw null; } }
        public int Size { get { throw null; } }
        public Mono.Cecil.Cil.StackBehaviour StackBehaviourPop { get { throw null; } }
        public Mono.Cecil.Cil.StackBehaviour StackBehaviourPush { get { throw null; } }
        public short Value { get { throw null; } }
        public bool Equals(Mono.Cecil.Cil.OpCode opcode) { throw null; }
        public override bool Equals(object obj) { throw null; }
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Mono.Cecil.Cil.OpCode one, Mono.Cecil.Cil.OpCode other) { throw null; }
        public static bool operator !=(Mono.Cecil.Cil.OpCode one, Mono.Cecil.Cil.OpCode other) { throw null; }
        public override string ToString() { throw null; }
    }
    public static partial class OpCodes
    {
        public static readonly Mono.Cecil.Cil.OpCode Add;
        public static readonly Mono.Cecil.Cil.OpCode Add_Ovf;
        public static readonly Mono.Cecil.Cil.OpCode Add_Ovf_Un;
        public static readonly Mono.Cecil.Cil.OpCode And;
        public static readonly Mono.Cecil.Cil.OpCode Arglist;
        public static readonly Mono.Cecil.Cil.OpCode Beq;
        public static readonly Mono.Cecil.Cil.OpCode Beq_S;
        public static readonly Mono.Cecil.Cil.OpCode Bge;
        public static readonly Mono.Cecil.Cil.OpCode Bge_S;
        public static readonly Mono.Cecil.Cil.OpCode Bge_Un;
        public static readonly Mono.Cecil.Cil.OpCode Bge_Un_S;
        public static readonly Mono.Cecil.Cil.OpCode Bgt;
        public static readonly Mono.Cecil.Cil.OpCode Bgt_S;
        public static readonly Mono.Cecil.Cil.OpCode Bgt_Un;
        public static readonly Mono.Cecil.Cil.OpCode Bgt_Un_S;
        public static readonly Mono.Cecil.Cil.OpCode Ble;
        public static readonly Mono.Cecil.Cil.OpCode Ble_S;
        public static readonly Mono.Cecil.Cil.OpCode Ble_Un;
        public static readonly Mono.Cecil.Cil.OpCode Ble_Un_S;
        public static readonly Mono.Cecil.Cil.OpCode Blt;
        public static readonly Mono.Cecil.Cil.OpCode Blt_S;
        public static readonly Mono.Cecil.Cil.OpCode Blt_Un;
        public static readonly Mono.Cecil.Cil.OpCode Blt_Un_S;
        public static readonly Mono.Cecil.Cil.OpCode Bne_Un;
        public static readonly Mono.Cecil.Cil.OpCode Bne_Un_S;
        public static readonly Mono.Cecil.Cil.OpCode Box;
        public static readonly Mono.Cecil.Cil.OpCode Br;
        public static readonly Mono.Cecil.Cil.OpCode Break;
        public static readonly Mono.Cecil.Cil.OpCode Brfalse;
        public static readonly Mono.Cecil.Cil.OpCode Brfalse_S;
        public static readonly Mono.Cecil.Cil.OpCode Brtrue;
        public static readonly Mono.Cecil.Cil.OpCode Brtrue_S;
        public static readonly Mono.Cecil.Cil.OpCode Br_S;
        public static readonly Mono.Cecil.Cil.OpCode Call;
        public static readonly Mono.Cecil.Cil.OpCode Calli;
        public static readonly Mono.Cecil.Cil.OpCode Callvirt;
        public static readonly Mono.Cecil.Cil.OpCode Castclass;
        public static readonly Mono.Cecil.Cil.OpCode Ceq;
        public static readonly Mono.Cecil.Cil.OpCode Cgt;
        public static readonly Mono.Cecil.Cil.OpCode Cgt_Un;
        public static readonly Mono.Cecil.Cil.OpCode Ckfinite;
        public static readonly Mono.Cecil.Cil.OpCode Clt;
        public static readonly Mono.Cecil.Cil.OpCode Clt_Un;
        public static readonly Mono.Cecil.Cil.OpCode Constrained;
        public static readonly Mono.Cecil.Cil.OpCode Conv_I;
        public static readonly Mono.Cecil.Cil.OpCode Conv_I1;
        public static readonly Mono.Cecil.Cil.OpCode Conv_I2;
        public static readonly Mono.Cecil.Cil.OpCode Conv_I4;
        public static readonly Mono.Cecil.Cil.OpCode Conv_I8;
        public static readonly Mono.Cecil.Cil.OpCode Conv_Ovf_I;
        public static readonly Mono.Cecil.Cil.OpCode Conv_Ovf_I1;
        public static readonly Mono.Cecil.Cil.OpCode Conv_Ovf_I1_Un;
        public static readonly Mono.Cecil.Cil.OpCode Conv_Ovf_I2;
        public static readonly Mono.Cecil.Cil.OpCode Conv_Ovf_I2_Un;
        public static readonly Mono.Cecil.Cil.OpCode Conv_Ovf_I4;
        public static readonly Mono.Cecil.Cil.OpCode Conv_Ovf_I4_Un;
        public static readonly Mono.Cecil.Cil.OpCode Conv_Ovf_I8;
        public static readonly Mono.Cecil.Cil.OpCode Conv_Ovf_I8_Un;
        public static readonly Mono.Cecil.Cil.OpCode Conv_Ovf_I_Un;
        public static readonly Mono.Cecil.Cil.OpCode Conv_Ovf_U;
        public static readonly Mono.Cecil.Cil.OpCode Conv_Ovf_U1;
        public static readonly Mono.Cecil.Cil.OpCode Conv_Ovf_U1_Un;
        public static readonly Mono.Cecil.Cil.OpCode Conv_Ovf_U2;
        public static readonly Mono.Cecil.Cil.OpCode Conv_Ovf_U2_Un;
        public static readonly Mono.Cecil.Cil.OpCode Conv_Ovf_U4;
        public static readonly Mono.Cecil.Cil.OpCode Conv_Ovf_U4_Un;
        public static readonly Mono.Cecil.Cil.OpCode Conv_Ovf_U8;
        public static readonly Mono.Cecil.Cil.OpCode Conv_Ovf_U8_Un;
        public static readonly Mono.Cecil.Cil.OpCode Conv_Ovf_U_Un;
        public static readonly Mono.Cecil.Cil.OpCode Conv_R4;
        public static readonly Mono.Cecil.Cil.OpCode Conv_R8;
        public static readonly Mono.Cecil.Cil.OpCode Conv_R_Un;
        public static readonly Mono.Cecil.Cil.OpCode Conv_U;
        public static readonly Mono.Cecil.Cil.OpCode Conv_U1;
        public static readonly Mono.Cecil.Cil.OpCode Conv_U2;
        public static readonly Mono.Cecil.Cil.OpCode Conv_U4;
        public static readonly Mono.Cecil.Cil.OpCode Conv_U8;
        public static readonly Mono.Cecil.Cil.OpCode Cpblk;
        public static readonly Mono.Cecil.Cil.OpCode Cpobj;
        public static readonly Mono.Cecil.Cil.OpCode Div;
        public static readonly Mono.Cecil.Cil.OpCode Div_Un;
        public static readonly Mono.Cecil.Cil.OpCode Dup;
        public static readonly Mono.Cecil.Cil.OpCode Endfilter;
        public static readonly Mono.Cecil.Cil.OpCode Endfinally;
        public static readonly Mono.Cecil.Cil.OpCode Initblk;
        public static readonly Mono.Cecil.Cil.OpCode Initobj;
        public static readonly Mono.Cecil.Cil.OpCode Isinst;
        public static readonly Mono.Cecil.Cil.OpCode Jmp;
        public static readonly Mono.Cecil.Cil.OpCode Ldarg;
        public static readonly Mono.Cecil.Cil.OpCode Ldarga;
        public static readonly Mono.Cecil.Cil.OpCode Ldarga_S;
        public static readonly Mono.Cecil.Cil.OpCode Ldarg_0;
        public static readonly Mono.Cecil.Cil.OpCode Ldarg_1;
        public static readonly Mono.Cecil.Cil.OpCode Ldarg_2;
        public static readonly Mono.Cecil.Cil.OpCode Ldarg_3;
        public static readonly Mono.Cecil.Cil.OpCode Ldarg_S;
        public static readonly Mono.Cecil.Cil.OpCode Ldc_I4;
        public static readonly Mono.Cecil.Cil.OpCode Ldc_I4_0;
        public static readonly Mono.Cecil.Cil.OpCode Ldc_I4_1;
        public static readonly Mono.Cecil.Cil.OpCode Ldc_I4_2;
        public static readonly Mono.Cecil.Cil.OpCode Ldc_I4_3;
        public static readonly Mono.Cecil.Cil.OpCode Ldc_I4_4;
        public static readonly Mono.Cecil.Cil.OpCode Ldc_I4_5;
        public static readonly Mono.Cecil.Cil.OpCode Ldc_I4_6;
        public static readonly Mono.Cecil.Cil.OpCode Ldc_I4_7;
        public static readonly Mono.Cecil.Cil.OpCode Ldc_I4_8;
        public static readonly Mono.Cecil.Cil.OpCode Ldc_I4_M1;
        public static readonly Mono.Cecil.Cil.OpCode Ldc_I4_S;
        public static readonly Mono.Cecil.Cil.OpCode Ldc_I8;
        public static readonly Mono.Cecil.Cil.OpCode Ldc_R4;
        public static readonly Mono.Cecil.Cil.OpCode Ldc_R8;
        public static readonly Mono.Cecil.Cil.OpCode Ldelema;
        public static readonly Mono.Cecil.Cil.OpCode Ldelem_Any;
        public static readonly Mono.Cecil.Cil.OpCode Ldelem_I;
        public static readonly Mono.Cecil.Cil.OpCode Ldelem_I1;
        public static readonly Mono.Cecil.Cil.OpCode Ldelem_I2;
        public static readonly Mono.Cecil.Cil.OpCode Ldelem_I4;
        public static readonly Mono.Cecil.Cil.OpCode Ldelem_I8;
        public static readonly Mono.Cecil.Cil.OpCode Ldelem_R4;
        public static readonly Mono.Cecil.Cil.OpCode Ldelem_R8;
        public static readonly Mono.Cecil.Cil.OpCode Ldelem_Ref;
        public static readonly Mono.Cecil.Cil.OpCode Ldelem_U1;
        public static readonly Mono.Cecil.Cil.OpCode Ldelem_U2;
        public static readonly Mono.Cecil.Cil.OpCode Ldelem_U4;
        public static readonly Mono.Cecil.Cil.OpCode Ldfld;
        public static readonly Mono.Cecil.Cil.OpCode Ldflda;
        public static readonly Mono.Cecil.Cil.OpCode Ldftn;
        public static readonly Mono.Cecil.Cil.OpCode Ldind_I;
        public static readonly Mono.Cecil.Cil.OpCode Ldind_I1;
        public static readonly Mono.Cecil.Cil.OpCode Ldind_I2;
        public static readonly Mono.Cecil.Cil.OpCode Ldind_I4;
        public static readonly Mono.Cecil.Cil.OpCode Ldind_I8;
        public static readonly Mono.Cecil.Cil.OpCode Ldind_R4;
        public static readonly Mono.Cecil.Cil.OpCode Ldind_R8;
        public static readonly Mono.Cecil.Cil.OpCode Ldind_Ref;
        public static readonly Mono.Cecil.Cil.OpCode Ldind_U1;
        public static readonly Mono.Cecil.Cil.OpCode Ldind_U2;
        public static readonly Mono.Cecil.Cil.OpCode Ldind_U4;
        public static readonly Mono.Cecil.Cil.OpCode Ldlen;
        public static readonly Mono.Cecil.Cil.OpCode Ldloc;
        public static readonly Mono.Cecil.Cil.OpCode Ldloca;
        public static readonly Mono.Cecil.Cil.OpCode Ldloca_S;
        public static readonly Mono.Cecil.Cil.OpCode Ldloc_0;
        public static readonly Mono.Cecil.Cil.OpCode Ldloc_1;
        public static readonly Mono.Cecil.Cil.OpCode Ldloc_2;
        public static readonly Mono.Cecil.Cil.OpCode Ldloc_3;
        public static readonly Mono.Cecil.Cil.OpCode Ldloc_S;
        public static readonly Mono.Cecil.Cil.OpCode Ldnull;
        public static readonly Mono.Cecil.Cil.OpCode Ldobj;
        public static readonly Mono.Cecil.Cil.OpCode Ldsfld;
        public static readonly Mono.Cecil.Cil.OpCode Ldsflda;
        public static readonly Mono.Cecil.Cil.OpCode Ldstr;
        public static readonly Mono.Cecil.Cil.OpCode Ldtoken;
        public static readonly Mono.Cecil.Cil.OpCode Ldvirtftn;
        public static readonly Mono.Cecil.Cil.OpCode Leave;
        public static readonly Mono.Cecil.Cil.OpCode Leave_S;
        public static readonly Mono.Cecil.Cil.OpCode Localloc;
        public static readonly Mono.Cecil.Cil.OpCode Mkrefany;
        public static readonly Mono.Cecil.Cil.OpCode Mul;
        public static readonly Mono.Cecil.Cil.OpCode Mul_Ovf;
        public static readonly Mono.Cecil.Cil.OpCode Mul_Ovf_Un;
        public static readonly Mono.Cecil.Cil.OpCode Neg;
        public static readonly Mono.Cecil.Cil.OpCode Newarr;
        public static readonly Mono.Cecil.Cil.OpCode Newobj;
        public static readonly Mono.Cecil.Cil.OpCode No;
        public static readonly Mono.Cecil.Cil.OpCode Nop;
        public static readonly Mono.Cecil.Cil.OpCode Not;
        public static readonly Mono.Cecil.Cil.OpCode Or;
        public static readonly Mono.Cecil.Cil.OpCode Pop;
        public static readonly Mono.Cecil.Cil.OpCode Readonly;
        public static readonly Mono.Cecil.Cil.OpCode Refanytype;
        public static readonly Mono.Cecil.Cil.OpCode Refanyval;
        public static readonly Mono.Cecil.Cil.OpCode Rem;
        public static readonly Mono.Cecil.Cil.OpCode Rem_Un;
        public static readonly Mono.Cecil.Cil.OpCode Ret;
        public static readonly Mono.Cecil.Cil.OpCode Rethrow;
        public static readonly Mono.Cecil.Cil.OpCode Shl;
        public static readonly Mono.Cecil.Cil.OpCode Shr;
        public static readonly Mono.Cecil.Cil.OpCode Shr_Un;
        public static readonly Mono.Cecil.Cil.OpCode Sizeof;
        public static readonly Mono.Cecil.Cil.OpCode Starg;
        public static readonly Mono.Cecil.Cil.OpCode Starg_S;
        public static readonly Mono.Cecil.Cil.OpCode Stelem_Any;
        public static readonly Mono.Cecil.Cil.OpCode Stelem_I;
        public static readonly Mono.Cecil.Cil.OpCode Stelem_I1;
        public static readonly Mono.Cecil.Cil.OpCode Stelem_I2;
        public static readonly Mono.Cecil.Cil.OpCode Stelem_I4;
        public static readonly Mono.Cecil.Cil.OpCode Stelem_I8;
        public static readonly Mono.Cecil.Cil.OpCode Stelem_R4;
        public static readonly Mono.Cecil.Cil.OpCode Stelem_R8;
        public static readonly Mono.Cecil.Cil.OpCode Stelem_Ref;
        public static readonly Mono.Cecil.Cil.OpCode Stfld;
        public static readonly Mono.Cecil.Cil.OpCode Stind_I;
        public static readonly Mono.Cecil.Cil.OpCode Stind_I1;
        public static readonly Mono.Cecil.Cil.OpCode Stind_I2;
        public static readonly Mono.Cecil.Cil.OpCode Stind_I4;
        public static readonly Mono.Cecil.Cil.OpCode Stind_I8;
        public static readonly Mono.Cecil.Cil.OpCode Stind_R4;
        public static readonly Mono.Cecil.Cil.OpCode Stind_R8;
        public static readonly Mono.Cecil.Cil.OpCode Stind_Ref;
        public static readonly Mono.Cecil.Cil.OpCode Stloc;
        public static readonly Mono.Cecil.Cil.OpCode Stloc_0;
        public static readonly Mono.Cecil.Cil.OpCode Stloc_1;
        public static readonly Mono.Cecil.Cil.OpCode Stloc_2;
        public static readonly Mono.Cecil.Cil.OpCode Stloc_3;
        public static readonly Mono.Cecil.Cil.OpCode Stloc_S;
        public static readonly Mono.Cecil.Cil.OpCode Stobj;
        public static readonly Mono.Cecil.Cil.OpCode Stsfld;
        public static readonly Mono.Cecil.Cil.OpCode Sub;
        public static readonly Mono.Cecil.Cil.OpCode Sub_Ovf;
        public static readonly Mono.Cecil.Cil.OpCode Sub_Ovf_Un;
        public static readonly Mono.Cecil.Cil.OpCode Switch;
        public static readonly Mono.Cecil.Cil.OpCode Tail;
        public static readonly Mono.Cecil.Cil.OpCode Throw;
        public static readonly Mono.Cecil.Cil.OpCode Unaligned;
        public static readonly Mono.Cecil.Cil.OpCode Unbox;
        public static readonly Mono.Cecil.Cil.OpCode Unbox_Any;
        public static readonly Mono.Cecil.Cil.OpCode Volatile;
        public static readonly Mono.Cecil.Cil.OpCode Xor;
    }
    public enum OpCodeType
    {
        Annotation = 0,
        Macro = 1,
        Nternal = 2,
        Objmodel = 3,
        Prefix = 4,
        Primitive = 5,
    }
    public enum OperandType
    {
        InlineArg = 14,
        InlineBrTarget = 0,
        InlineField = 1,
        InlineI = 2,
        InlineI8 = 3,
        InlineMethod = 4,
        InlineNone = 5,
        InlinePhi = 6,
        InlineR = 7,
        InlineSig = 8,
        InlineString = 9,
        InlineSwitch = 10,
        InlineTok = 11,
        InlineType = 12,
        InlineVar = 13,
        ShortInlineArg = 19,
        ShortInlineBrTarget = 15,
        ShortInlineI = 16,
        ShortInlineR = 17,
        ShortInlineVar = 18,
    }
    public sealed partial class PortablePdbReader : Mono.Cecil.Cil.ISymbolReader, System.IDisposable
    {
        internal PortablePdbReader() { }
        public void Dispose() { }
        public Mono.Cecil.Cil.ISymbolWriterProvider GetWriterProvider() { throw null; }
        public bool ProcessDebugHeader(Mono.Cecil.Cil.ImageDebugHeader header) { throw null; }
        public Mono.Cecil.Cil.MethodDebugInformation Read(Mono.Cecil.MethodDefinition method) { throw null; }
    }
    public sealed partial class PortablePdbReaderProvider : Mono.Cecil.Cil.ISymbolReaderProvider
    {
        public PortablePdbReaderProvider() { }
        public Mono.Cecil.Cil.ISymbolReader GetSymbolReader(Mono.Cecil.ModuleDefinition module, System.IO.Stream symbolStream) { throw null; }
        public Mono.Cecil.Cil.ISymbolReader GetSymbolReader(Mono.Cecil.ModuleDefinition module, string fileName) { throw null; }
    }
    public sealed partial class PortablePdbWriter : Mono.Cecil.Cil.ISymbolWriter, System.IDisposable
    {
        internal PortablePdbWriter() { }
        public void Dispose() { }
        public Mono.Cecil.Cil.ImageDebugHeader GetDebugHeader() { throw null; }
        public Mono.Cecil.Cil.ISymbolReaderProvider GetReaderProvider() { throw null; }
        public void Write(Mono.Cecil.Cil.MethodDebugInformation info) { }
    }
    public sealed partial class PortablePdbWriterProvider : Mono.Cecil.Cil.ISymbolWriterProvider
    {
        public PortablePdbWriterProvider() { }
        public Mono.Cecil.Cil.ISymbolWriter GetSymbolWriter(Mono.Cecil.ModuleDefinition module, System.IO.Stream symbolStream) { throw null; }
        public Mono.Cecil.Cil.ISymbolWriter GetSymbolWriter(Mono.Cecil.ModuleDefinition module, string fileName) { throw null; }
    }
    public sealed partial class ScopeDebugInformation : Mono.Cecil.Cil.DebugInformation
    {
        public ScopeDebugInformation(Mono.Cecil.Cil.Instruction start, Mono.Cecil.Cil.Instruction end) { }
        public Mono.Collections.Generic.Collection<Mono.Cecil.Cil.ConstantDebugInformation> Constants { get { throw null; } }
        public Mono.Cecil.Cil.InstructionOffset End { get { throw null; } set { } }
        public bool HasConstants { get { throw null; } }
        public bool HasScopes { get { throw null; } }
        public bool HasVariables { get { throw null; } }
        public Mono.Cecil.Cil.ImportDebugInformation Import { get { throw null; } set { } }
        public Mono.Collections.Generic.Collection<Mono.Cecil.Cil.ScopeDebugInformation> Scopes { get { throw null; } }
        public Mono.Cecil.Cil.InstructionOffset Start { get { throw null; } set { } }
        public Mono.Collections.Generic.Collection<Mono.Cecil.Cil.VariableDebugInformation> Variables { get { throw null; } }
        public bool TryGetName(Mono.Cecil.Cil.VariableDefinition variable, out string name) { throw null; }
    }
    public sealed partial class SequencePoint
    {
        public SequencePoint(Mono.Cecil.Cil.Instruction instruction, Mono.Cecil.Cil.Document document) { }
        public Mono.Cecil.Cil.Document Document { get { throw null; } set { } }
        public int EndColumn { get { throw null; } set { } }
        public int EndLine { get { throw null; } set { } }
        public bool IsHidden { get { throw null; } }
        public int Offset { get { throw null; } }
        public int StartColumn { get { throw null; } set { } }
        public int StartLine { get { throw null; } set { } }
    }
    public sealed partial class SourceLinkDebugInformation : Mono.Cecil.Cil.CustomDebugInformation
    {
        public static System.Guid KindIdentifier;
        public SourceLinkDebugInformation(string content) { }
        public string Content { get { throw null; } set { } }
        public override Mono.Cecil.Cil.CustomDebugInformationKind Kind { get { throw null; } }
    }
    public enum StackBehaviour
    {
        Pop0 = 0,
        Pop1 = 1,
        Pop1_pop1 = 2,
        PopAll = 18,
        Popi = 3,
        Popi_pop1 = 4,
        Popi_popi = 5,
        Popi_popi8 = 6,
        Popi_popi_popi = 7,
        Popi_popr4 = 8,
        Popi_popr8 = 9,
        Popref = 10,
        Popref_pop1 = 11,
        Popref_popi = 12,
        Popref_popi_popi = 13,
        Popref_popi_popi8 = 14,
        Popref_popi_popr4 = 15,
        Popref_popi_popr8 = 16,
        Popref_popi_popref = 17,
        Push0 = 19,
        Push1 = 20,
        Push1_push1 = 21,
        Pushi = 22,
        Pushi8 = 23,
        Pushr4 = 24,
        Pushr8 = 25,
        Pushref = 26,
        Varpop = 27,
        Varpush = 28,
    }
    public sealed partial class StateMachineScope
    {
        public StateMachineScope(Mono.Cecil.Cil.Instruction start, Mono.Cecil.Cil.Instruction end) { }
        public Mono.Cecil.Cil.InstructionOffset End { get { throw null; } set { } }
        public Mono.Cecil.Cil.InstructionOffset Start { get { throw null; } set { } }
    }
    public sealed partial class StateMachineScopeDebugInformation : Mono.Cecil.Cil.CustomDebugInformation
    {
        public static System.Guid KindIdentifier;
        public StateMachineScopeDebugInformation() { }
        public override Mono.Cecil.Cil.CustomDebugInformationKind Kind { get { throw null; } }
        public Mono.Collections.Generic.Collection<Mono.Cecil.Cil.StateMachineScope> Scopes { get { throw null; } }
    }
    [System.SerializableAttribute]
    public sealed partial class SymbolsNotFoundException : System.IO.FileNotFoundException
    {
        public SymbolsNotFoundException(string message) { }
    }
    [System.SerializableAttribute]
    public sealed partial class SymbolsNotMatchingException : System.InvalidOperationException
    {
        public SymbolsNotMatchingException(string message) { }
    }
    [System.FlagsAttribute]
    public enum VariableAttributes : ushort
    {
        DebuggerHidden = (ushort)1,
        None = (ushort)0,
    }
    public sealed partial class VariableDebugInformation : Mono.Cecil.Cil.DebugInformation
    {
        public VariableDebugInformation(Mono.Cecil.Cil.VariableDefinition variable, string name) { }
        public Mono.Cecil.Cil.VariableAttributes Attributes { get { throw null; } set { } }
        public int Index { get { throw null; } }
        public bool IsDebuggerHidden { get { throw null; } set { } }
        public string Name { get { throw null; } set { } }
    }
    public sealed partial class VariableDefinition : Mono.Cecil.Cil.VariableReference
    {
        public VariableDefinition(Mono.Cecil.TypeReference variableType) { }
        public bool IsPinned { get { throw null; } }
        public override Mono.Cecil.Cil.VariableDefinition Resolve() { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public partial struct VariableIndex
    {
        private object _dummy;
        private int _dummyPrimitive;
        public VariableIndex(Mono.Cecil.Cil.VariableDefinition variable) { throw null; }
        public VariableIndex(int index) { throw null; }
        public int Index { get { throw null; } }
    }
    public abstract partial class VariableReference
    {
        internal VariableReference() { }
        protected Mono.Cecil.TypeReference variable_type;
        public int Index { get { throw null; } }
        public Mono.Cecil.TypeReference VariableType { get { throw null; } set { } }
        public abstract Mono.Cecil.Cil.VariableDefinition Resolve();
        public override string ToString() { throw null; }
    }
}
namespace Mono.Collections.Generic
{
    public partial class Collection<T> : System.Collections.Generic.ICollection<T>, System.Collections.Generic.IEnumerable<T>, System.Collections.Generic.IList<T>, System.Collections.ICollection, System.Collections.IEnumerable, System.Collections.IList
    {
        public Collection() { }
        public Collection(System.Collections.Generic.ICollection<T> items) { }
        public Collection(int capacity) { }
        public int Capacity { get { throw null; } set { } }
        public int Count { get { throw null; } }
        public T this[int index] { get { throw null; } set { } }
        bool System.Collections.Generic.ICollection<T>.IsReadOnly { get { throw null; } }
        int System.Collections.ICollection.Count { get { throw null; } }
        bool System.Collections.ICollection.IsSynchronized { get { throw null; } }
        object System.Collections.ICollection.SyncRoot { get { throw null; } }
        bool System.Collections.IList.IsFixedSize { get { throw null; } }
        bool System.Collections.IList.IsReadOnly { get { throw null; } }
        object System.Collections.IList.this[int index] { get { throw null; } set { } }
        public void Add(T item) { }
        public void Clear() { }
        public bool Contains(T item) { throw null; }
        public void CopyTo(T[] array, int arrayIndex) { }
        public Mono.Collections.Generic.Collection<T>.Enumerator GetEnumerator() { throw null; }
        public int IndexOf(T item) { throw null; }
        public void Insert(int index, T item) { }
        protected virtual void OnAdd(T item, int index) { }
        protected virtual void OnClear() { }
        protected virtual void OnInsert(T item, int index) { }
        protected virtual void OnRemove(T item, int index) { }
        protected virtual void OnSet(T item, int index) { }
        public bool Remove(T item) { throw null; }
        public void RemoveAt(int index) { }
        protected void Resize(int new_size) { }
        System.Collections.Generic.IEnumerator<T> System.Collections.Generic.IEnumerable<T>.GetEnumerator() { throw null; }
        void System.Collections.ICollection.CopyTo(System.Array array, int index) { }
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { throw null; }
        int System.Collections.IList.Add(object value) { throw null; }
        void System.Collections.IList.Clear() { }
        bool System.Collections.IList.Contains(object value) { throw null; }
        int System.Collections.IList.IndexOf(object value) { throw null; }
        void System.Collections.IList.Insert(int index, object value) { }
        void System.Collections.IList.Remove(object value) { }
        void System.Collections.IList.RemoveAt(int index) { }
        public T[] ToArray() { throw null; }
        [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
        public partial struct Enumerator : System.Collections.Generic.IEnumerator<T>, System.Collections.IEnumerator, System.IDisposable
        {
            private T current;
            private object _dummy;
            private int _dummyPrimitive;
            public T Current { get { throw null; } }
            object System.Collections.IEnumerator.Current { get { throw null; } }
            public void Dispose() { }
            public bool MoveNext() { throw null; }
            public void Reset() { }
        }
    }
    public sealed partial class ReadOnlyCollection<T> : Mono.Collections.Generic.Collection<T>, System.Collections.Generic.ICollection<T>, System.Collections.Generic.IEnumerable<T>, System.Collections.ICollection, System.Collections.IEnumerable, System.Collections.IList
    {
        public ReadOnlyCollection(Mono.Collections.Generic.Collection<T> collection) { }
        public ReadOnlyCollection(T[] array) { }
        public static Mono.Collections.Generic.ReadOnlyCollection<T> Empty { get { throw null; } }
        bool System.Collections.Generic.ICollection<T>.IsReadOnly { get { throw null; } }
        bool System.Collections.IList.IsFixedSize { get { throw null; } }
        bool System.Collections.IList.IsReadOnly { get { throw null; } }
        protected override void OnAdd(T item, int index) { }
        protected override void OnClear() { }
        protected override void OnInsert(T item, int index) { }
        protected override void OnRemove(T item, int index) { }
        protected override void OnSet(T item, int index) { }
    }
}
