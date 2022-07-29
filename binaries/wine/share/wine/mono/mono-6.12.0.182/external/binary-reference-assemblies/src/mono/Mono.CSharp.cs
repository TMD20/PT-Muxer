// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

[assembly:System.Reflection.AssemblyVersionAttribute("4.0.0.0")]
[assembly:System.Diagnostics.DebuggableAttribute((System.Diagnostics.DebuggableAttribute.DebuggingModes)(2))]
[assembly:System.Reflection.AssemblyCompanyAttribute("Mono development team")]
[assembly:System.Reflection.AssemblyCopyrightAttribute("(c) Various Mono authors")]
[assembly:System.Reflection.AssemblyDefaultAliasAttribute("Mono.CSharp.dll")]
[assembly:System.Reflection.AssemblyDescriptionAttribute("Mono.CSharp.dll")]
[assembly:System.Reflection.AssemblyFileVersionAttribute("4.6.57.0")]
[assembly:System.Reflection.AssemblyInformationalVersionAttribute("4.6.57.0")]
[assembly:System.Reflection.AssemblyProductAttribute("Mono Common Language Infrastructure")]
[assembly:System.Reflection.AssemblyTitleAttribute("Mono.CSharp.dll")]
[assembly:System.Resources.NeutralResourcesLanguageAttribute("en-US")]
[assembly:System.Resources.SatelliteContractVersionAttribute("4.0.0.0")]
[assembly:System.Runtime.CompilerServices.CompilationRelaxationsAttribute(8)]
[assembly:System.Runtime.CompilerServices.InternalsVisibleToAttribute("Microsoft.CSharp, PublicKey=002400000480000094000000060200000024000052534131000400000100010007d1fa57c4aed9f0a32e84aa0faefd0de9e8fd6aec8f87fb03766c834c99921eb23be79ad9d5dcc1dd9ad236132102900b723cf980957fc4e177108fc607774f29e8320e92ea05ece4e821c0a5efe8f1645c4c0c93c1ab99285d622caa652c1dfad63d745d6f2de5f17e5eaf0fc4963d261c8a12436518206dc093344d5ad293")]
[assembly:System.Runtime.CompilerServices.ReferenceAssemblyAttribute]
[assembly:System.Runtime.CompilerServices.RuntimeCompatibilityAttribute(WrapNonExceptionThrows=true)]
[assembly:System.Runtime.InteropServices.ComVisibleAttribute(false)]
namespace Mono.CompilerServices.SymbolWriter
{
    public partial class AnonymousScopeEntry
    {
        public readonly int ID;
        public AnonymousScopeEntry(int id) { }
        public Mono.CompilerServices.SymbolWriter.CapturedScope[] CapturedScopes { get { throw null; } }
        public Mono.CompilerServices.SymbolWriter.CapturedVariable[] CapturedVariables { get { throw null; } }
        public override string ToString() { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public partial struct CapturedScope
    {
        public readonly string CapturedName;
        public readonly int Scope;
        public CapturedScope(int scope, string captured_name) { throw null;}
        public override string ToString() { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public partial struct CapturedVariable
    {
        public readonly string CapturedName;
        public readonly Mono.CompilerServices.SymbolWriter.CapturedVariable.CapturedKind Kind;
        public readonly string Name;
        public CapturedVariable(string name, string captured_name, Mono.CompilerServices.SymbolWriter.CapturedVariable.CapturedKind kind) { throw null;}
        public override string ToString() { throw null; }
        public enum CapturedKind : byte
        {
            Local = (byte)0,
            Parameter = (byte)1,
            This = (byte)2,
        }
    }
    public partial class CodeBlockEntry
    {
        public Mono.CompilerServices.SymbolWriter.CodeBlockEntry.Type BlockType;
        public int EndOffset;
        public int Index;
        public int Parent;
        public int StartOffset;
        public CodeBlockEntry(int index, int parent, Mono.CompilerServices.SymbolWriter.CodeBlockEntry.Type type, int start_offset) { }
        public void Close(int end_offset) { }
        public override string ToString() { throw null; }
        public enum Type
        {
            CompilerGenerated = 2,
            IteratorBody = 3,
            IteratorDispatcher = 4,
            Lexical = 1,
        }
    }
    public partial class CompileUnitEntry : Mono.CompilerServices.SymbolWriter.ICompileUnit
    {
        public readonly int Index;
        public CompileUnitEntry(Mono.CompilerServices.SymbolWriter.MonoSymbolFile file, Mono.CompilerServices.SymbolWriter.SourceFileEntry source) { }
        public Mono.CompilerServices.SymbolWriter.SourceFileEntry[] IncludeFiles { get { throw null; } }
        Mono.CompilerServices.SymbolWriter.CompileUnitEntry Mono.CompilerServices.SymbolWriter.ICompileUnit.Entry { get { throw null; } }
        public Mono.CompilerServices.SymbolWriter.NamespaceEntry[] Namespaces { get { throw null; } }
        public static int Size { get { throw null; } }
        public Mono.CompilerServices.SymbolWriter.SourceFileEntry SourceFile { get { throw null; } }
        public void AddFile(Mono.CompilerServices.SymbolWriter.SourceFileEntry file) { }
        public int DefineNamespace(string name, string[] using_clauses, int parent) { throw null; }
        public void ReadAll() { }
    }
    public partial interface ICompileUnit
    {
        Mono.CompilerServices.SymbolWriter.CompileUnitEntry Entry { get; }
    }
    public partial interface IMethodDef
    {
        string Name { get; }
        int Token { get; }
    }
    public partial interface ISourceFile
    {
        Mono.CompilerServices.SymbolWriter.SourceFileEntry Entry { get; }
    }
    public partial class LineNumberEntry
    {
        public int Column;
        public int EndColumn;
        public int EndRow;
        public readonly int File;
        public readonly bool IsHidden;
        public static readonly Mono.CompilerServices.SymbolWriter.LineNumberEntry Null;
        public readonly int Offset;
        public readonly int Row;
        public LineNumberEntry(int file, int row, int offset) { }
        public LineNumberEntry(int file, int row, int column, int offset) { }
        public LineNumberEntry(int file, int row, int column, int offset, bool is_hidden) { }
        public LineNumberEntry(int file, int row, int column, int end_row, int end_column, int offset, bool is_hidden) { }
        public override string ToString() { throw null; }
        public sealed partial class LocationComparer : System.Collections.Generic.IComparer<Mono.CompilerServices.SymbolWriter.LineNumberEntry>
        {
            public static readonly Mono.CompilerServices.SymbolWriter.LineNumberEntry.LocationComparer Default;
            public LocationComparer() { }
            public int Compare(Mono.CompilerServices.SymbolWriter.LineNumberEntry l1, Mono.CompilerServices.SymbolWriter.LineNumberEntry l2) { throw null; }
        }
    }
    public partial class LineNumberTable
    {
        public const int Default_LineBase = -1;
        public const int Default_LineRange = 8;
        public const byte Default_OpcodeBase = (byte)9;
        public const byte DW_LNE_end_sequence = (byte)1;
        public const byte DW_LNE_MONO_negate_is_hidden = (byte)64;
        public const byte DW_LNS_advance_line = (byte)3;
        public const byte DW_LNS_advance_pc = (byte)2;
        public const byte DW_LNS_const_add_pc = (byte)8;
        public const byte DW_LNS_copy = (byte)1;
        public const byte DW_LNS_set_file = (byte)4;
        public readonly int LineBase;
        public readonly int LineRange;
        public readonly int MaxAddressIncrement;
        public readonly byte OpcodeBase;
        protected Mono.CompilerServices.SymbolWriter.LineNumberEntry[] _line_numbers;
        protected LineNumberTable(Mono.CompilerServices.SymbolWriter.MonoSymbolFile file) { }
        public Mono.CompilerServices.SymbolWriter.LineNumberEntry[] LineNumbers { get { throw null; } }
        public bool GetMethodBounds(out Mono.CompilerServices.SymbolWriter.LineNumberEntry start, out Mono.CompilerServices.SymbolWriter.LineNumberEntry end) { start = default(Mono.CompilerServices.SymbolWriter.LineNumberEntry); end = default(Mono.CompilerServices.SymbolWriter.LineNumberEntry); throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public partial struct LocalVariableEntry
    {
        public readonly int BlockIndex;
        public readonly int Index;
        public readonly string Name;
        public LocalVariableEntry(int index, string name, int block) { throw null;}
        public override string ToString() { throw null; }
    }
    public partial class MethodEntry : System.IComparable
    {
        internal MethodEntry() { }
        public readonly Mono.CompilerServices.SymbolWriter.CompileUnitEntry CompileUnit;
        public readonly int CompileUnitIndex;
        public readonly int NamespaceID;
        public const int Size = 12;
        public readonly Mono.CompilerServices.SymbolWriter.MonoSymbolFile SymbolFile;
        public readonly int Token;
        public int Index { get { throw null; } set { } }
        public Mono.CompilerServices.SymbolWriter.MethodEntry.Flags MethodFlags { get { throw null; } }
        public int CompareTo(object obj) { throw null; }
        public Mono.CompilerServices.SymbolWriter.CodeBlockEntry[] GetCodeBlocks() { throw null; }
        public Mono.CompilerServices.SymbolWriter.LineNumberTable GetLineNumberTable() { throw null; }
        public Mono.CompilerServices.SymbolWriter.LocalVariableEntry[] GetLocals() { throw null; }
        public string GetRealName() { throw null; }
        public Mono.CompilerServices.SymbolWriter.ScopeVariable[] GetScopeVariables() { throw null; }
        public void ReadAll() { }
        public override string ToString() { throw null; }
        [System.FlagsAttribute]
        public enum Flags
        {
            ColumnsInfoIncluded = 2,
            EndInfoIncluded = 4,
            LocalNamesAmbiguous = 1,
        }
    }
    public partial class MonoSymbolFile : System.IDisposable
    {
        public readonly int MajorVersion;
        public readonly int MinorVersion;
        public int NumLineNumbers;
        public MonoSymbolFile() { }
        public int AnonymousScopeCount { get { throw null; } }
        public int CompileUnitCount { get { throw null; } }
        public Mono.CompilerServices.SymbolWriter.CompileUnitEntry[] CompileUnits { get { throw null; } }
        public System.Guid Guid { get { throw null; } }
        public int MethodCount { get { throw null; } }
        public Mono.CompilerServices.SymbolWriter.MethodEntry[] Methods { get { throw null; } }
        public int NamespaceCount { get { throw null; } }
        public Mono.CompilerServices.SymbolWriter.OffsetTable OffsetTable { get { throw null; } }
        public int SourceCount { get { throw null; } }
        public Mono.CompilerServices.SymbolWriter.SourceFileEntry[] Sources { get { throw null; } }
        public int TypeCount { get { throw null; } }
        public int AddCompileUnit(Mono.CompilerServices.SymbolWriter.CompileUnitEntry entry) { throw null; }
        public void AddMethod(Mono.CompilerServices.SymbolWriter.MethodEntry entry) { }
        public int AddSource(Mono.CompilerServices.SymbolWriter.SourceFileEntry source) { throw null; }
        public void CreateSymbolFile(System.Guid guid, System.IO.FileStream fs) { }
        public Mono.CompilerServices.SymbolWriter.MethodEntry DefineMethod(Mono.CompilerServices.SymbolWriter.CompileUnitEntry comp_unit, int token, Mono.CompilerServices.SymbolWriter.ScopeVariable[] scope_vars, Mono.CompilerServices.SymbolWriter.LocalVariableEntry[] locals, Mono.CompilerServices.SymbolWriter.LineNumberEntry[] lines, Mono.CompilerServices.SymbolWriter.CodeBlockEntry[] code_blocks, string real_name, Mono.CompilerServices.SymbolWriter.MethodEntry.Flags flags, int namespace_id) { throw null; }
        public void Dispose() { }
        protected virtual void Dispose(bool disposing) { }
        public int FindSource(string file_name) { throw null; }
        public Mono.CompilerServices.SymbolWriter.AnonymousScopeEntry GetAnonymousScope(int id) { throw null; }
        public Mono.CompilerServices.SymbolWriter.CompileUnitEntry GetCompileUnit(int index) { throw null; }
        public Mono.CompilerServices.SymbolWriter.MethodEntry GetMethod(int index) { throw null; }
        public Mono.CompilerServices.SymbolWriter.MethodEntry GetMethodByToken(int token) { throw null; }
        public Mono.CompilerServices.SymbolWriter.SourceFileEntry GetSourceFile(int index) { throw null; }
        public static Mono.CompilerServices.SymbolWriter.MonoSymbolFile ReadSymbolFile(System.IO.Stream stream) { throw null; }
        public static Mono.CompilerServices.SymbolWriter.MonoSymbolFile ReadSymbolFile(System.Reflection.Assembly assembly) { throw null; }
        public static Mono.CompilerServices.SymbolWriter.MonoSymbolFile ReadSymbolFile(string mdbFilename) { throw null; }
        public static Mono.CompilerServices.SymbolWriter.MonoSymbolFile ReadSymbolFile(string mdbFilename, System.Guid assemblyGuid) { throw null; }
    }
    public partial class MonoSymbolFileException : System.Exception
    {
        public MonoSymbolFileException() { }
        public MonoSymbolFileException(string message, System.Exception innerException) { }
        public MonoSymbolFileException(string message, params object[] args) { }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public partial struct NamespaceEntry
    {
        public readonly int Index;
        public readonly string Name;
        public readonly int Parent;
        public readonly string[] UsingClauses;
        public NamespaceEntry(string name, int index, string[] using_clauses, int parent) { throw null;}
        public override string ToString() { throw null; }
    }
    public partial class OffsetTable
    {
        internal OffsetTable() { }
        public int AnonymousScopeCount;
        public int AnonymousScopeTableOffset;
        public int AnonymousScopeTableSize;
        public int CompileUnitCount;
        public int CompileUnitTableOffset;
        public int CompileUnitTableSize;
        public int DataSectionOffset;
        public int DataSectionSize;
        public Mono.CompilerServices.SymbolWriter.OffsetTable.Flags FileFlags;
        public int LineNumberTable_LineBase;
        public int LineNumberTable_LineRange;
        public int LineNumberTable_OpcodeBase;
        public const long Magic = (long)5037318119232611860;
        public const int MajorVersion = 50;
        public int MethodCount;
        public int MethodTableOffset;
        public int MethodTableSize;
        public const int MinorVersion = 0;
        public int SourceCount;
        public int SourceTableOffset;
        public int SourceTableSize;
        public int TotalFileSize;
        public int TypeCount;
        public override string ToString() { throw null; }
        [System.FlagsAttribute]
        public enum Flags
        {
            IsAspxSource = 1,
            WindowsFileNames = 2,
        }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public partial struct ScopeVariable
    {
        public readonly int Index;
        public readonly int Scope;
        public ScopeVariable(int scope, int index) { throw null;}
        public override string ToString() { throw null; }
    }
    public partial class SourceFileEntry
    {
        public readonly int Index;
        public SourceFileEntry(Mono.CompilerServices.SymbolWriter.MonoSymbolFile file, string file_name) { }
        public SourceFileEntry(Mono.CompilerServices.SymbolWriter.MonoSymbolFile file, string sourceFile, byte[] guid, byte[] checksum) { }
        public SourceFileEntry(Mono.CompilerServices.SymbolWriter.MonoSymbolFile file, string fileName, string sourceFile, byte[] guid, byte[] checksum) { }
        public bool AutoGenerated { get { throw null; } }
        public byte[] Checksum { get { throw null; } }
        public string FileName { get { throw null; } set { } }
        public static int Size { get { throw null; } }
        public bool CheckChecksum() { throw null; }
        public void SetAutoGenerated() { }
        public override string ToString() { throw null; }
    }
    public partial class SourceMethodBuilder
    {
        public SourceMethodBuilder(Mono.CompilerServices.SymbolWriter.ICompileUnit comp_unit) { }
        public SourceMethodBuilder(Mono.CompilerServices.SymbolWriter.ICompileUnit comp_unit, int ns_id, Mono.CompilerServices.SymbolWriter.IMethodDef method) { }
        public Mono.CompilerServices.SymbolWriter.CodeBlockEntry[] Blocks { get { throw null; } }
        public Mono.CompilerServices.SymbolWriter.CodeBlockEntry CurrentBlock { get { throw null; } }
        public Mono.CompilerServices.SymbolWriter.LocalVariableEntry[] Locals { get { throw null; } }
        public Mono.CompilerServices.SymbolWriter.ScopeVariable[] ScopeVariables { get { throw null; } }
        public Mono.CompilerServices.SymbolWriter.ICompileUnit SourceFile { get { throw null; } }
        public void AddLocal(int index, string name) { }
        public void AddScopeVariable(int scope, int index) { }
        public void DefineMethod(Mono.CompilerServices.SymbolWriter.MonoSymbolFile file) { }
        public void DefineMethod(Mono.CompilerServices.SymbolWriter.MonoSymbolFile file, int token) { }
        public void EndBlock(int end_offset) { }
        public void MarkSequencePoint(int offset, Mono.CompilerServices.SymbolWriter.SourceFileEntry file, int line, int column, bool is_hidden) { }
        public void MarkSequencePoint(int offset, Mono.CompilerServices.SymbolWriter.SourceFileEntry file, int line, int column, int end_line, int end_column, bool is_hidden) { }
        public void StartBlock(Mono.CompilerServices.SymbolWriter.CodeBlockEntry.Type type, int start_offset) { }
        public void StartBlock(Mono.CompilerServices.SymbolWriter.CodeBlockEntry.Type type, int start_offset, int scopeIndex) { }
    }
}
namespace Mono.CSharp
{
    public abstract partial class AbstractMessage
    {
        protected readonly int code;
        protected readonly Mono.CSharp.Location location;
        protected AbstractMessage(Mono.CSharp.AbstractMessage aMsg) { }
        protected AbstractMessage(int code, Mono.CSharp.Location loc, string msg, System.Collections.Generic.List<string> extraInfo) { }
        public int Code { get { throw null; } }
        public abstract bool IsWarning { get; }
        public Mono.CSharp.Location Location { get { throw null; } }
        public abstract string MessageType { get; }
        public string[] RelatedSymbols { get { throw null; } }
        public string Text { get { throw null; } }
        public override bool Equals(object obj) { throw null; }
        public override int GetHashCode() { throw null; }
    }
    public abstract partial class AbstractPropertyEventMethod : Mono.CSharp.MemberCore, Mono.CSharp.IMemberContext, Mono.CSharp.IMemberDefinition, Mono.CSharp.IMethodData, Mono.CSharp.IMethodDefinition, Mono.CSharp.IModuleContext
    {
        protected Mono.CSharp.ToplevelBlock block;
        protected System.Collections.Generic.Dictionary<System.Security.Permissions.SecurityAction, System.Security.PermissionSet> declarative_security;
        protected Mono.CSharp.MethodData method_data;
        protected readonly string prefix;
        protected AbstractPropertyEventMethod(Mono.CSharp.InterfaceMemberBase member, string prefix, Mono.CSharp.Attributes attrs, Mono.CSharp.Location loc) : base (default(Mono.CSharp.TypeContainer), default(Mono.CSharp.MemberName), default(Mono.CSharp.Attributes)) { }
        public Mono.CSharp.ToplevelBlock Block { get { throw null; } set { } }
        public System.Reflection.CallingConventions CallingConventions { get { throw null; } }
        public override string DocCommentHeader { get { throw null; } }
        public bool IsAccessor { get { throw null; } }
        public Mono.CSharp.MemberName MethodName { get { throw null; } }
        System.Reflection.MethodBase Mono.CSharp.IMethodDefinition.Metadata { get { throw null; } }
        public abstract Mono.CSharp.ParametersCompiled ParameterInfo { get; }
        public Mono.CSharp.TypeSpec[] ParameterTypes { get { throw null; } }
        public abstract Mono.CSharp.TypeSpec ReturnType { get; }
        public Mono.CSharp.MethodSpec Spec { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]protected set { } }
        public override void ApplyAttributeBuilder(Mono.CSharp.Attribute a, Mono.CSharp.MethodSpec ctor, byte[] cdata, Mono.CSharp.PredefinedAttributes pa) { }
        protected virtual void ApplyToExtraTarget(Mono.CSharp.Attribute a, Mono.CSharp.MethodSpec ctor, byte[] cdata, Mono.CSharp.PredefinedAttributes pa) { }
        public Mono.CSharp.EmitContext CreateEmitContext(System.Reflection.Emit.ILGenerator ig, Mono.CompilerServices.SymbolWriter.SourceMethodBuilder sourceMethod) { throw null; }
        public sealed override bool Define() { throw null; }
        public virtual void Emit(Mono.CSharp.TypeDefinition parent) { }
        public override bool EnableOverloadChecks(Mono.CSharp.MemberCore overload) { throw null; }
        public override string GetCallerMemberName() { throw null; }
        public override string GetSignatureForDocumentation() { throw null; }
        public override bool IsClsComplianceRequired() { throw null; }
        public void PrepareEmit() { }
        public void UpdateName(Mono.CSharp.InterfaceMemberBase member) { }
        public override void WriteDebugSymbol(Mono.CompilerServices.SymbolWriter.MonoSymbolFile file) { }
    }
    [System.FlagsAttribute]
    public enum AddressOp
    {
        Load = 2,
        LoadStore = 3,
        Store = 1,
    }
    public abstract partial class AnonymousExpression : Mono.CSharp.ExpressionStatement
    {
        protected readonly Mono.CSharp.ParametersBlock block;
        public Mono.CSharp.TypeSpec ReturnType;
        protected AnonymousExpression(Mono.CSharp.ParametersBlock block, Mono.CSharp.TypeSpec return_type, Mono.CSharp.Location loc) { }
        public Mono.CSharp.ParametersBlock Block { get { throw null; } }
        public abstract string ContainerType { get; }
        public abstract bool IsIterator { get; }
        public abstract Mono.CSharp.AnonymousMethodStorey Storey { get; }
        public Mono.CSharp.AnonymousExpression Compatible(Mono.CSharp.ResolveContext ec) { throw null; }
        public Mono.CSharp.AnonymousExpression Compatible(Mono.CSharp.ResolveContext ec, Mono.CSharp.AnonymousExpression ae) { throw null; }
        public override bool ContainsEmitWithAwait() { throw null; }
        public override void FlowAnalysis(Mono.CSharp.FlowAnalysisContext fc) { }
        public override Mono.CSharp.Reachability MarkReachable(Mono.CSharp.Reachability rc) { throw null; }
        public void SetHasThisAccess() { }
        protected partial class AnonymousMethodMethod : Mono.CSharp.Method
        {
            public readonly Mono.CSharp.AnonymousExpression AnonymousMethod;
            public readonly Mono.CSharp.AnonymousMethodStorey Storey;
            public AnonymousMethodMethod(Mono.CSharp.TypeDefinition parent, Mono.CSharp.AnonymousExpression am, Mono.CSharp.AnonymousMethodStorey storey, Mono.CSharp.TypeExpr return_type, Mono.CSharp.Modifiers mod, Mono.CSharp.MemberName name, Mono.CSharp.ParametersCompiled parameters) : base (default(Mono.CSharp.TypeDefinition), default(Mono.CSharp.FullNamedExpression), default(Mono.CSharp.Modifiers), default(Mono.CSharp.MemberName), default(Mono.CSharp.ParametersCompiled), default(Mono.CSharp.Attributes)) { }
            public override Mono.CSharp.EmitContext CreateEmitContext(System.Reflection.Emit.ILGenerator ig, Mono.CompilerServices.SymbolWriter.SourceMethodBuilder sourceMethod) { throw null; }
            protected override void DefineTypeParameters() { }
            public override void Emit() { }
            protected override bool ResolveMemberType() { throw null; }
        }
    }
    public partial class AnonymousMethodBody : Mono.CSharp.AnonymousExpression
    {
        protected readonly Mono.CSharp.ParametersCompiled parameters;
        public AnonymousMethodBody(Mono.CSharp.ParametersCompiled parameters, Mono.CSharp.ParametersBlock block, Mono.CSharp.TypeSpec return_type, Mono.CSharp.TypeSpec delegate_type, Mono.CSharp.Location loc) : base (default(Mono.CSharp.ParametersBlock), default(Mono.CSharp.TypeSpec), default(Mono.CSharp.Location)) { }
        public override string ContainerType { get { throw null; } }
        public Mono.CSharp.MethodGroupExpr DirectMethodGroupConversion { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public override bool IsIterator { get { throw null; } }
        public Mono.CSharp.ParametersCompiled Parameters { get { throw null; } }
        public Mono.CSharp.TypeInferenceContext ReturnTypeInference { get { throw null; } set { } }
        public override Mono.CSharp.AnonymousMethodStorey Storey { get { throw null; } }
        public override Mono.CSharp.Expression CreateExpressionTree(Mono.CSharp.ResolveContext ec) { throw null; }
        protected override Mono.CSharp.Expression DoResolve(Mono.CSharp.ResolveContext ec) { throw null; }
        public override void Emit(Mono.CSharp.EmitContext ec) { }
        public override void EmitStatement(Mono.CSharp.EmitContext ec) { }
        public override string GetSignatureForError() { throw null; }
    }
    public partial class AnonymousMethodExpression : Mono.CSharp.Expression
    {
        public Mono.CSharp.ParametersBlock Block;
        public AnonymousMethodExpression(Mono.CSharp.Location loc) { }
        public override string ExprClassName { get { throw null; } }
        public virtual bool HasExplicitParameters { get { throw null; } }
        public override bool IsSideEffectFree { get { throw null; } }
        public Mono.CSharp.ParametersCompiled Parameters { get { throw null; } }
        public Mono.CSharp.ReportPrinter TypeInferenceReportPrinter { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public override object Accept(Mono.CSharp.StructuralVisitor visitor) { throw null; }
        protected override void CloneTo(Mono.CSharp.CloneContext clonectx, Mono.CSharp.Expression t) { }
        public Mono.CSharp.Expression Compatible(Mono.CSharp.ResolveContext ec, Mono.CSharp.TypeSpec type) { throw null; }
        protected virtual Mono.CSharp.AnonymousMethodBody CompatibleMethodFactory(Mono.CSharp.TypeSpec return_type, Mono.CSharp.TypeSpec delegate_type, Mono.CSharp.ParametersCompiled p, Mono.CSharp.ParametersBlock b) { throw null; }
        public override bool ContainsEmitWithAwait() { throw null; }
        public override Mono.CSharp.Expression CreateExpressionTree(Mono.CSharp.ResolveContext ec) { throw null; }
        protected virtual Mono.CSharp.Expression CreateExpressionTree(Mono.CSharp.ResolveContext ec, Mono.CSharp.TypeSpec delegate_type) { throw null; }
        protected override Mono.CSharp.Expression DoResolve(Mono.CSharp.ResolveContext rc) { throw null; }
        protected virtual bool DoResolveParameters(Mono.CSharp.ResolveContext rc) { throw null; }
        public override void Emit(Mono.CSharp.EmitContext ec) { }
        public static void Error_AddressOfCapturedVar(Mono.CSharp.ResolveContext rc, Mono.CSharp.IVariableReference var, Mono.CSharp.Location loc) { }
        public bool ExplicitTypeInference(Mono.CSharp.TypeInferenceContext type_inference, Mono.CSharp.TypeSpec delegate_type) { throw null; }
        public override string GetSignatureForError() { throw null; }
        public bool ImplicitStandardConversionExists(Mono.CSharp.ResolveContext ec, Mono.CSharp.TypeSpec delegate_type) { throw null; }
        public Mono.CSharp.TypeSpec InferReturnType(Mono.CSharp.ResolveContext ec, Mono.CSharp.TypeInferenceContext tic, Mono.CSharp.TypeSpec delegate_type) { throw null; }
        protected virtual Mono.CSharp.ParametersCompiled ResolveParameters(Mono.CSharp.ResolveContext ec, Mono.CSharp.TypeInferenceContext tic, Mono.CSharp.TypeSpec delegate_type) { throw null; }
        protected bool VerifyExplicitParameters(Mono.CSharp.ResolveContext ec, Mono.CSharp.TypeInferenceContext tic, Mono.CSharp.TypeSpec delegate_type, Mono.CSharp.AParametersCollection parameters) { throw null; }
        protected bool VerifyParameterCompatibility(Mono.CSharp.ResolveContext ec, Mono.CSharp.TypeInferenceContext tic, Mono.CSharp.TypeSpec delegate_type, Mono.CSharp.AParametersCollection invoke_pd, bool ignore_errors) { throw null; }
    }
    public partial class AnonymousMethodStorey : Mono.CSharp.HoistedStoreyClass
    {
        protected System.Collections.Generic.List<Mono.CSharp.HoistedVariable> hoisted_locals;
        protected System.Collections.Generic.List<Mono.CSharp.HoistedParameter> hoisted_params;
        protected Mono.CSharp.HoistedThis hoisted_this;
        public readonly int ID;
        public Mono.CSharp.Expression Instance;
        public readonly Mono.CSharp.ExplicitBlock OriginalSourceBlock;
        public AnonymousMethodStorey(Mono.CSharp.ExplicitBlock block, Mono.CSharp.TypeDefinition parent, Mono.CSharp.MemberBase host, Mono.CSharp.TypeParameters tparams, string name, Mono.CSharp.MemberKind kind) : base (default(Mono.CSharp.TypeDefinition), default(Mono.CSharp.MemberName), default(Mono.CSharp.TypeParameters), default(Mono.CSharp.Modifiers), default(Mono.CSharp.MemberKind)) { }
        public Mono.CSharp.HoistedThis HoistedThis { get { throw null; } set { } }
        public System.Collections.Generic.IList<Mono.CSharp.ExplicitBlock> ReferencesFromChildrenBlock { get { throw null; } }
        public void AddCapturedThisField(Mono.CSharp.EmitContext ec, Mono.CSharp.AnonymousMethodStorey parent) { }
        public Mono.CSharp.Field AddCapturedVariable(string name, Mono.CSharp.TypeSpec type) { throw null; }
        protected Mono.CSharp.Field AddCompilerGeneratedField(string name, Mono.CSharp.FullNamedExpression type) { throw null; }
        protected Mono.CSharp.Field AddCompilerGeneratedField(string name, Mono.CSharp.FullNamedExpression type, bool privateAccess) { throw null; }
        public void AddParentStoreyReference(Mono.CSharp.EmitContext ec, Mono.CSharp.AnonymousMethodStorey storey) { }
        public void AddReferenceFromChildrenBlock(Mono.CSharp.ExplicitBlock block) { }
        public void CaptureLocalVariable(Mono.CSharp.ResolveContext ec, Mono.CSharp.LocalVariable localVariable) { }
        public void CaptureParameter(Mono.CSharp.ResolveContext ec, Mono.CSharp.ParametersBlock.ParameterInfo parameterInfo, Mono.CSharp.ParameterReference parameterReference) { }
        protected override bool DoResolveTypeParameters() { throw null; }
        protected virtual void EmitHoistedParameters(Mono.CSharp.EmitContext ec, System.Collections.Generic.List<Mono.CSharp.HoistedParameter> hoisted) { }
        public void EmitStoreyInstantiation(Mono.CSharp.EmitContext ec, Mono.CSharp.ExplicitBlock block) { }
        public Mono.CSharp.Expression GetStoreyInstanceExpression(Mono.CSharp.EmitContext ec) { throw null; }
        protected virtual string GetVariableMangledName(Mono.CSharp.ResolveContext rc, Mono.CSharp.LocalVariable local_info) { throw null; }
        public void SetNestedStoryParent(Mono.CSharp.AnonymousMethodStorey parentStorey) { }
    }
    public partial class AnonymousTypeClass : Mono.CSharp.CompilerGeneratedContainer
    {
        internal AnonymousTypeClass() : base (default(Mono.CSharp.TypeContainer), default(Mono.CSharp.MemberName), default(Mono.CSharp.Modifiers)) { }
        public const string ClassNamePrefix = "<>__AnonType";
        public const string SignatureForError = "anonymous type";
        public System.Collections.Generic.IList<Mono.CSharp.AnonymousTypeParameter> Parameters { get { throw null; } }
        public static Mono.CSharp.AnonymousTypeClass Create(Mono.CSharp.TypeContainer parent, System.Collections.Generic.IList<Mono.CSharp.AnonymousTypeParameter> parameters, Mono.CSharp.Location loc) { throw null; }
        protected override bool DoDefineMembers() { throw null; }
        public override Mono.CSharp.CompilationSourceFile GetCompilationSourceFile() { throw null; }
        public override string GetSignatureForError() { throw null; }
    }
    public partial class AnonymousTypeParameter : Mono.CSharp.ShimExpression
    {
        public readonly string Name;
        public AnonymousTypeParameter(Mono.CSharp.Expression initializer, string name, Mono.CSharp.Location loc) : base (default(Mono.CSharp.Expression)) { }
        public AnonymousTypeParameter(Mono.CSharp.Parameter parameter) : base (default(Mono.CSharp.Expression)) { }
        protected override Mono.CSharp.Expression DoResolve(Mono.CSharp.ResolveContext ec) { throw null; }
        public override bool Equals(object o) { throw null; }
        protected virtual void Error_InvalidInitializer(Mono.CSharp.ResolveContext ec, string initializer) { }
        public override int GetHashCode() { throw null; }
    }
    public abstract partial class AParametersCollection
    {
        protected bool has_arglist;
        protected bool has_params;
        protected Mono.CSharp.IParameterData[] parameters;
        protected Mono.CSharp.TypeSpec[] types;
        protected AParametersCollection() { }
        public System.Reflection.CallingConventions CallingConvention { get { throw null; } }
        public int Count { get { throw null; } }
        public Mono.CSharp.TypeSpec ExtensionMethodType { get { throw null; } }
        public Mono.CSharp.IParameterData[] FixedParameters { get { throw null; } }
        public bool HasArglist { get { throw null; } }
        public bool HasExtensionMethodType { get { throw null; } }
        public bool HasParams { get { throw null; } }
        public bool IsEmpty { get { throw null; } }
        public Mono.CSharp.TypeSpec[] Types { get { throw null; } set { } }
        public System.Type[] GetMetaInfo() { throw null; }
        public static System.Reflection.ParameterAttributes GetParameterAttribute(Mono.CSharp.Parameter.Modifier modFlags) { throw null; }
        public int GetParameterIndexByName(string name) { throw null; }
        public string GetSignatureForDocumentation() { throw null; }
        public string GetSignatureForError() { throw null; }
        public string GetSignatureForError(string start, string end, int count) { throw null; }
        public static bool HasSameParameterDefaults(Mono.CSharp.AParametersCollection a, Mono.CSharp.AParametersCollection b) { throw null; }
        public Mono.CSharp.AParametersCollection Inflate(Mono.CSharp.TypeParameterInflator inflator) { throw null; }
        public string ParameterDesc(int pos) { throw null; }
    }
    public partial class Arglist : Mono.CSharp.Expression
    {
        public Arglist(Mono.CSharp.Arguments args, Mono.CSharp.Location l) { }
        public Arglist(Mono.CSharp.Location loc) { }
        public Mono.CSharp.Arguments Arguments { get { throw null; } }
        public System.Type[] ArgumentTypes { get { throw null; } }
        public override object Accept(Mono.CSharp.StructuralVisitor visitor) { throw null; }
        protected override void CloneTo(Mono.CSharp.CloneContext clonectx, Mono.CSharp.Expression t) { }
        public override bool ContainsEmitWithAwait() { throw null; }
        public override Mono.CSharp.Expression CreateExpressionTree(Mono.CSharp.ResolveContext ec) { throw null; }
        protected override Mono.CSharp.Expression DoResolve(Mono.CSharp.ResolveContext ec) { throw null; }
        public override void Emit(Mono.CSharp.EmitContext ec) { }
    }
    public partial class ArglistAccess : Mono.CSharp.Expression
    {
        public ArglistAccess(Mono.CSharp.Location loc) { }
        public override object Accept(Mono.CSharp.StructuralVisitor visitor) { throw null; }
        protected override void CloneTo(Mono.CSharp.CloneContext clonectx, Mono.CSharp.Expression target) { }
        public override bool ContainsEmitWithAwait() { throw null; }
        public override Mono.CSharp.Expression CreateExpressionTree(Mono.CSharp.ResolveContext ec) { throw null; }
        protected override Mono.CSharp.Expression DoResolve(Mono.CSharp.ResolveContext ec) { throw null; }
        public override void Emit(Mono.CSharp.EmitContext ec) { }
    }
    public partial class ArglistParameter : Mono.CSharp.Parameter
    {
        public ArglistParameter(Mono.CSharp.Location loc) : base (default(Mono.CSharp.FullNamedExpression), default(string), default(Mono.CSharp.Parameter.Modifier), default(Mono.CSharp.Attributes), default(Mono.CSharp.Location)) { }
        public override void ApplyAttributes(System.Reflection.Emit.MethodBuilder mb, System.Reflection.Emit.ConstructorBuilder cb, int index, Mono.CSharp.PredefinedAttributes pa) { }
        public override bool CheckAccessibility(Mono.CSharp.InterfaceMemberBase member) { throw null; }
        public override Mono.CSharp.TypeSpec Resolve(Mono.CSharp.IMemberContext ec, int index) { throw null; }
    }
    public partial class Argument
    {
        public readonly Mono.CSharp.Argument.AType ArgType;
        public Mono.CSharp.Expression Expr;
        public Argument(Mono.CSharp.Expression expr) { }
        public Argument(Mono.CSharp.Expression expr, Mono.CSharp.Argument.AType type) { }
        public bool IsByRef { get { throw null; } }
        public bool IsDefaultArgument { get { throw null; } }
        public bool IsExtensionType { get { throw null; } }
        public Mono.CSharp.Parameter.Modifier Modifier { get { throw null; } }
        public Mono.CSharp.TypeSpec Type { get { throw null; } }
        public Mono.CSharp.Argument Clone(Mono.CSharp.CloneContext clonectx) { throw null; }
        public Mono.CSharp.Argument Clone(Mono.CSharp.Expression expr) { throw null; }
        public virtual Mono.CSharp.Expression CreateExpressionTree(Mono.CSharp.ResolveContext ec) { throw null; }
        public virtual void Emit(Mono.CSharp.EmitContext ec) { }
        public Mono.CSharp.Argument EmitToField(Mono.CSharp.EmitContext ec, bool cloneResult) { throw null; }
        public void FlowAnalysis(Mono.CSharp.FlowAnalysisContext fc) { }
        public string GetSignatureForError() { throw null; }
        public void Resolve(Mono.CSharp.ResolveContext ec) { }
        public bool ResolveMethodGroup(Mono.CSharp.ResolveContext ec) { throw null; }
        public enum AType : byte
        {
            ConditionalAccessFlag = (byte)128,
            Default = (byte)3,
            DynamicTypeName = (byte)4,
            ExtensionType = (byte)5,
            ExtensionTypeConditionalAccess = (byte)133,
            None = (byte)0,
            Out = (byte)2,
            Ref = (byte)1,
        }
    }
    public partial class Arguments
    {
        public Arguments(int capacity) { }
        public int Count { get { throw null; } }
        public bool HasDynamic { get { throw null; } }
        public bool HasNamed { get { throw null; } }
        public Mono.CSharp.Argument this[int index] { get { throw null; } set { } }
        public void Add(Mono.CSharp.Argument arg) { }
        public void AddRange(Mono.CSharp.Arguments args) { }
        public void CheckArrayAsAttribute(Mono.CSharp.CompilerContext ctx) { }
        public Mono.CSharp.Arguments Clone(Mono.CSharp.CloneContext ctx) { throw null; }
        public bool ContainsEmitWithAwait() { throw null; }
        public Mono.CSharp.ArrayInitializer CreateDynamicBinderArguments(Mono.CSharp.ResolveContext rc) { throw null; }
        public static Mono.CSharp.Arguments CreateForExpressionTree(Mono.CSharp.ResolveContext ec, Mono.CSharp.Arguments args, params Mono.CSharp.Expression[] e) { throw null; }
        public void Emit(Mono.CSharp.EmitContext ec) { }
        public virtual Mono.CSharp.Arguments Emit(Mono.CSharp.EmitContext ec, bool dup_args, bool prepareAwait) { throw null; }
        public void EmitPrepare(Mono.CSharp.EmitContext ec) { }
        public virtual void FlowAnalysis(Mono.CSharp.FlowAnalysisContext fc, System.Collections.Generic.List<Mono.CSharp.MovableArgument> movable=null) { }
        public System.Collections.Generic.List<Mono.CSharp.Argument>.Enumerator GetEnumerator() { throw null; }
        public void Insert(int index, Mono.CSharp.Argument arg) { }
        public static System.Linq.Expressions.Expression[] MakeExpression(Mono.CSharp.Arguments args, Mono.CSharp.BuilderContext ctx) { throw null; }
        public Mono.CSharp.Arguments MarkOrderedArgument(Mono.CSharp.NamedArgument a) { throw null; }
        public void RemoveAt(int index) { }
        public void Resolve(Mono.CSharp.ResolveContext rc, out bool dynamic) { dynamic = default(bool); }
    }
    public partial class ArrayAccess : Mono.CSharp.Expression, Mono.CSharp.IAssignMethod, Mono.CSharp.IMemoryLocation
    {
        public ArrayAccess(Mono.CSharp.ElementAccess ea_data, Mono.CSharp.Location l) { }
        public bool ConditionalAccess { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public void AddressOf(Mono.CSharp.EmitContext ec, Mono.CSharp.AddressOp mode) { }
        public override bool ContainsEmitWithAwait() { throw null; }
        public override Mono.CSharp.Expression CreateExpressionTree(Mono.CSharp.ResolveContext ec) { throw null; }
        protected override Mono.CSharp.Expression DoResolve(Mono.CSharp.ResolveContext ec) { throw null; }
        public override Mono.CSharp.Expression DoResolveLValue(Mono.CSharp.ResolveContext ec, Mono.CSharp.Expression right_side) { throw null; }
        public override void Emit(Mono.CSharp.EmitContext ec) { }
        public void Emit(Mono.CSharp.EmitContext ec, bool leave_copy) { }
        public void EmitAssign(Mono.CSharp.EmitContext ec, Mono.CSharp.Expression source, bool leave_copy, bool isCompound) { }
        public override Mono.CSharp.Expression EmitToField(Mono.CSharp.EmitContext ec) { throw null; }
        protected override void Error_NegativeArrayIndex(Mono.CSharp.ResolveContext ec, Mono.CSharp.Location loc) { }
        public override void FlowAnalysis(Mono.CSharp.FlowAnalysisContext fc) { }
        public override bool HasConditionalAccess() { throw null; }
        public System.Linq.Expressions.Expression MakeAssignExpression(Mono.CSharp.BuilderContext ctx, Mono.CSharp.Expression source) { throw null; }
        public override System.Linq.Expressions.Expression MakeExpression(Mono.CSharp.BuilderContext ctx) { throw null; }
        public void SetConditionalAccessReceiver() { }
    }
    public partial class ArrayContainer : Mono.CSharp.ElementTypeSpec
    {
        internal ArrayContainer() : base (default(Mono.CSharp.MemberKind), default(Mono.CSharp.TypeSpec), default(System.Type)) { }
        public override System.Collections.Generic.IList<Mono.CSharp.TypeSpec> Interfaces { get { throw null; } }
        public int Rank { get { throw null; } }
        public System.Reflection.MethodInfo GetAddressMethod() { throw null; }
        public System.Reflection.MethodInfo GetConstructor() { throw null; }
        public System.Reflection.MethodInfo GetGetMethod() { throw null; }
        public override System.Type GetMetaInfo() { throw null; }
        protected override string GetPostfixSignature() { throw null; }
        public static string GetPostfixSignature(int rank) { throw null; }
        public System.Reflection.MethodInfo GetSetMethod() { throw null; }
        public override string GetSignatureForDocumentation(bool explicitName) { throw null; }
        public static Mono.CSharp.ArrayContainer MakeType(Mono.CSharp.ModuleContainer module, Mono.CSharp.TypeSpec element) { throw null; }
        public static Mono.CSharp.ArrayContainer MakeType(Mono.CSharp.ModuleContainer module, Mono.CSharp.TypeSpec element, int rank) { throw null; }
        public override System.Collections.Generic.List<Mono.CSharp.MissingTypeSpecReference> ResolveMissingDependencies(Mono.CSharp.MemberSpec caller) { throw null; }
        [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
        public partial struct TypeRankPair : System.IEquatable<Mono.CSharp.ArrayContainer.TypeRankPair>
        {
            public TypeRankPair(Mono.CSharp.TypeSpec ts, int rank) { throw null;}
            public bool Equals(Mono.CSharp.ArrayContainer.TypeRankPair other) { throw null; }
            public override int GetHashCode() { throw null; }
        }
    }
    public partial class ArrayCreation : Mono.CSharp.Expression
    {
        protected System.Collections.Generic.List<Mono.CSharp.Expression> arguments;
        protected System.Collections.Generic.List<Mono.CSharp.Expression> array_data;
        protected Mono.CSharp.TypeSpec array_element_type;
        protected int dimensions;
        protected readonly Mono.CSharp.ComposedTypeSpecifier rank;
        public ArrayCreation(Mono.CSharp.FullNamedExpression requested_base_type, Mono.CSharp.ArrayInitializer initializers) { }
        public ArrayCreation(Mono.CSharp.FullNamedExpression requested_base_type, Mono.CSharp.ArrayInitializer initializers, Mono.CSharp.Location loc) { }
        public ArrayCreation(Mono.CSharp.FullNamedExpression requested_base_type, Mono.CSharp.ComposedTypeSpecifier rank, Mono.CSharp.ArrayInitializer initializers, Mono.CSharp.Location loc) { }
        public ArrayCreation(Mono.CSharp.FullNamedExpression requested_base_type, System.Collections.Generic.List<Mono.CSharp.Expression> exprs, Mono.CSharp.ComposedTypeSpecifier rank, Mono.CSharp.ArrayInitializer initializers, Mono.CSharp.Location l) { }
        public Mono.CSharp.ArrayInitializer Initializers { get { throw null; } }
        public bool NoEmptyInterpolation { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public Mono.CSharp.ComposedTypeSpecifier Rank { get { throw null; } }
        public Mono.CSharp.FullNamedExpression TypeExpression { get { throw null; } }
        public override object Accept(Mono.CSharp.StructuralVisitor visitor) { throw null; }
        protected override void CloneTo(Mono.CSharp.CloneContext clonectx, Mono.CSharp.Expression t) { }
        public override bool ContainsEmitWithAwait() { throw null; }
        public override Mono.CSharp.Expression CreateExpressionTree(Mono.CSharp.ResolveContext ec) { throw null; }
        protected override Mono.CSharp.Expression DoResolve(Mono.CSharp.ResolveContext ec) { throw null; }
        public override void Emit(Mono.CSharp.EmitContext ec) { }
        protected sealed override Mono.CSharp.FieldExpr EmitToFieldSource(Mono.CSharp.EmitContext ec) { throw null; }
        public override void EncodeAttributeValue(Mono.CSharp.IMemberContext rc, Mono.CSharp.AttributeEncoder enc, Mono.CSharp.TypeSpec targetType, Mono.CSharp.TypeSpec parameterType) { }
        protected override void Error_NegativeArrayIndex(Mono.CSharp.ResolveContext ec, Mono.CSharp.Location loc) { }
        public override void FlowAnalysis(Mono.CSharp.FlowAnalysisContext fc) { }
        public override System.Linq.Expressions.Expression MakeExpression(Mono.CSharp.BuilderContext ctx) { throw null; }
        protected virtual Mono.CSharp.Expression ResolveArrayElement(Mono.CSharp.ResolveContext ec, Mono.CSharp.Expression element) { throw null; }
        protected bool ResolveInitializers(Mono.CSharp.ResolveContext ec) { throw null; }
    }
    public partial class ArrayIndexCast : Mono.CSharp.TypeCast
    {
        public ArrayIndexCast(Mono.CSharp.Expression expr, Mono.CSharp.TypeSpec returnType) : base (default(Mono.CSharp.Expression), default(Mono.CSharp.TypeSpec)) { }
        public override Mono.CSharp.Expression CreateExpressionTree(Mono.CSharp.ResolveContext ec) { throw null; }
        public override void Emit(Mono.CSharp.EmitContext ec) { }
    }
    public partial class ArrayInitializer : Mono.CSharp.Expression
    {
        public ArrayInitializer(Mono.CSharp.Location loc) { }
        public ArrayInitializer(System.Collections.Generic.List<Mono.CSharp.Expression> init, Mono.CSharp.Location loc) { }
        public ArrayInitializer(int count, Mono.CSharp.Location loc) { }
        public int Count { get { throw null; } }
        public System.Collections.Generic.List<Mono.CSharp.Expression> Elements { get { throw null; } }
        public Mono.CSharp.Expression this[int index] { get { throw null; } }
        public Mono.CSharp.BlockVariable VariableDeclaration { get { throw null; } set { } }
        public override object Accept(Mono.CSharp.StructuralVisitor visitor) { throw null; }
        public void Add(Mono.CSharp.Expression expr) { }
        protected override void CloneTo(Mono.CSharp.CloneContext clonectx, Mono.CSharp.Expression t) { }
        public override bool ContainsEmitWithAwait() { throw null; }
        public override Mono.CSharp.Expression CreateExpressionTree(Mono.CSharp.ResolveContext ec) { throw null; }
        protected override Mono.CSharp.Expression DoResolve(Mono.CSharp.ResolveContext rc) { throw null; }
        public override void Emit(Mono.CSharp.EmitContext ec) { }
        public override void FlowAnalysis(Mono.CSharp.FlowAnalysisContext fc) { }
    }
    public partial class As : Mono.CSharp.Probe
    {
        public As(Mono.CSharp.Expression expr, Mono.CSharp.Expression probe_type, Mono.CSharp.Location l) : base (default(Mono.CSharp.Expression), default(Mono.CSharp.Expression), default(Mono.CSharp.Location)) { }
        protected override string OperatorName { get { throw null; } }
        public override object Accept(Mono.CSharp.StructuralVisitor visitor) { throw null; }
        public override Mono.CSharp.Expression CreateExpressionTree(Mono.CSharp.ResolveContext ec) { throw null; }
        protected override Mono.CSharp.Expression DoResolve(Mono.CSharp.ResolveContext ec) { throw null; }
        public override void Emit(Mono.CSharp.EmitContext ec) { }
    }
    public partial class AssemblyBuilderExtension
    {
        protected readonly Mono.CSharp.CompilerContext ctx;
        public AssemblyBuilderExtension(Mono.CSharp.CompilerContext ctx) { }
        public virtual System.Reflection.Module AddModule(string module) { throw null; }
        public virtual void AddPermissionRequests(System.Security.PermissionSet[] permissions) { }
        public virtual void AddTypeForwarder(Mono.CSharp.TypeSpec type, Mono.CSharp.Location loc) { }
        public virtual void DefineWin32IconResource(string fileName) { }
        public virtual System.Reflection.AssemblyName[] GetReferencedAssemblies() { throw null; }
        public virtual void SetAlgorithmId(uint value, Mono.CSharp.Location loc) { }
        public virtual void SetCulture(string culture, Mono.CSharp.Location loc) { }
        public virtual void SetFlags(uint flags, Mono.CSharp.Location loc) { }
        public virtual void SetVersion(System.Version version, Mono.CSharp.Location loc) { }
    }
    public abstract partial class AssemblyDefinition : Mono.CSharp.IAssemblyDefinition
    {
        protected System.Collections.Generic.List<Mono.CSharp.ImportedModuleDefinition> added_modules;
        public System.Reflection.Emit.AssemblyBuilder Builder;
        protected Mono.CSharp.AssemblyBuilderExtension builder_extra;
        protected readonly string file_name;
        protected Mono.CSharp.ModuleContainer module;
        protected AssemblyDefinition(Mono.CSharp.ModuleContainer module, string name) { }
        protected AssemblyDefinition(Mono.CSharp.ModuleContainer module, string name, string fileName) { }
        public Mono.CSharp.Attribute CLSCompliantAttribute { get { throw null; } }
        public Mono.CSharp.CompilerContext Compiler { get { throw null; } }
        public Mono.CSharp.Method EntryPoint { get { throw null; } set { } }
        public string FullName { get { throw null; } }
        public bool HasCLSCompliantAttribute { get { throw null; } }
        public Mono.CSharp.MetadataImporter Importer { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public bool IsCLSCompliant { get { throw null; } }
        public bool IsSatelliteAssembly { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        bool Mono.CSharp.IAssemblyDefinition.IsMissing { get { throw null; } }
        public string Name { get { throw null; } }
        protected Mono.CSharp.Report Report { get { throw null; } }
        public Mono.CompilerServices.SymbolWriter.MonoSymbolFile SymbolWriter { get { throw null; } }
        public bool WrapNonExceptionThrows { get { throw null; } }
        public void AddModule(Mono.CSharp.ImportedModuleDefinition module) { }
        public void ApplyAttributeBuilder(Mono.CSharp.Attribute a, Mono.CSharp.MethodSpec ctor, byte[] cdata, Mono.CSharp.PredefinedAttributes pa) { }
        protected System.Reflection.AssemblyName CreateAssemblyName() { throw null; }
        public virtual System.Reflection.Emit.ModuleBuilder CreateModuleBuilder() { throw null; }
        public void EmbedResources() { }
        public virtual void Emit() { }
        protected virtual System.Collections.Generic.List<Mono.CSharp.AssemblyReferenceMessageInfo> GetNotUnifiedReferences(System.Reflection.AssemblyName assemblyName) { throw null; }
        public byte[] GetPublicKeyToken() { throw null; }
        public bool IsFriendAssemblyTo(Mono.CSharp.IAssemblyDefinition assembly) { throw null; }
        public void Resolve() { }
        protected void ResolveAssemblySecurityAttributes() { }
        public void Save() { }
        protected virtual void SaveModule(System.Reflection.PortableExecutableKinds pekind, System.Reflection.ImageFileMachine machine) { }
    }
    public partial class AssemblyDefinitionDynamic : Mono.CSharp.AssemblyDefinition
    {
        public AssemblyDefinitionDynamic(Mono.CSharp.ModuleContainer module, string name) : base (default(Mono.CSharp.ModuleContainer), default(string)) { }
        public AssemblyDefinitionDynamic(Mono.CSharp.ModuleContainer module, string name, string fileName) : base (default(Mono.CSharp.ModuleContainer), default(string)) { }
        public bool Create(System.AppDomain domain, System.Reflection.Emit.AssemblyBuilderAccess access) { throw null; }
        public override System.Reflection.Emit.ModuleBuilder CreateModuleBuilder() { throw null; }
        public System.Reflection.Module IncludeModule(string moduleFile) { throw null; }
        protected override void SaveModule(System.Reflection.PortableExecutableKinds pekind, System.Reflection.ImageFileMachine machine) { }
    }
    public partial class AssemblyReferenceMessageInfo
    {
        public AssemblyReferenceMessageInfo(System.Reflection.AssemblyName dependencyName, System.Action<Mono.CSharp.Report> reportMessage) { }
        public System.Reflection.AssemblyName DependencyName { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        public System.Action<Mono.CSharp.Report> ReportMessage { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
    }
    public partial class AssemblyResource : System.IEquatable<Mono.CSharp.AssemblyResource>
    {
        public AssemblyResource(string fileName, string name) { }
        public AssemblyResource(string fileName, string name, bool isPrivate) { }
        public System.Reflection.ResourceAttributes Attributes { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        public string FileName { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        public bool IsEmbeded { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public string Name { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        public bool Equals(Mono.CSharp.AssemblyResource other) { throw null; }
    }
    public abstract partial class Assign : Mono.CSharp.ExpressionStatement
    {
        protected Mono.CSharp.Expression source;
        protected Mono.CSharp.Expression target;
        protected Assign(Mono.CSharp.Expression target, Mono.CSharp.Expression source, Mono.CSharp.Location loc) { }
        public Mono.CSharp.Expression Source { get { throw null; } }
        public override Mono.CSharp.Location StartLocation { get { throw null; } }
        public Mono.CSharp.Expression Target { get { throw null; } }
        public override object Accept(Mono.CSharp.StructuralVisitor visitor) { throw null; }
        protected override void CloneTo(Mono.CSharp.CloneContext clonectx, Mono.CSharp.Expression t) { }
        public override bool ContainsEmitWithAwait() { throw null; }
        public override Mono.CSharp.Expression CreateExpressionTree(Mono.CSharp.ResolveContext ec) { throw null; }
        protected override Mono.CSharp.Expression DoResolve(Mono.CSharp.ResolveContext ec) { throw null; }
        public override void Emit(Mono.CSharp.EmitContext ec) { }
        public override void EmitStatement(Mono.CSharp.EmitContext ec) { }
        public override void FlowAnalysis(Mono.CSharp.FlowAnalysisContext fc) { }
        public override System.Linq.Expressions.Expression MakeExpression(Mono.CSharp.BuilderContext ctx) { throw null; }
        protected virtual Mono.CSharp.Expression ResolveConversions(Mono.CSharp.ResolveContext ec) { throw null; }
    }
    public partial class AsyncInitializer : Mono.CSharp.StateMachineInitializer
    {
        public AsyncInitializer(Mono.CSharp.ParametersBlock block, Mono.CSharp.TypeDefinition host, Mono.CSharp.TypeSpec returnType) : base (default(Mono.CSharp.ParametersBlock), default(Mono.CSharp.TypeDefinition), default(Mono.CSharp.TypeSpec)) { }
        public override string ContainerType { get { throw null; } }
        public Mono.CSharp.TypeSpec DelegateType { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public Mono.CSharp.StackFieldExpr HoistedReturnState { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public override bool IsIterator { get { throw null; } }
        public Mono.CSharp.TypeInferenceContext ReturnTypeInference { get { throw null; } }
        protected override Mono.CSharp.BlockContext CreateBlockContext(Mono.CSharp.BlockContext bc) { throw null; }
        public override void Emit(Mono.CSharp.EmitContext ec) { }
        public void EmitCatchBlock(Mono.CSharp.EmitContext ec) { }
        protected override void EmitMoveNextEpilogue(Mono.CSharp.EmitContext ec) { }
        public override void EmitStatement(Mono.CSharp.EmitContext ec) { }
        public override Mono.CSharp.Reachability MarkReachable(Mono.CSharp.Reachability rc) { throw null; }
    }
    public abstract partial class Attributable
    {
        protected Mono.CSharp.Attributes attributes;
        protected Attributable() { }
        public abstract System.AttributeTargets AttributeTargets { get; }
        public Mono.CSharp.Attributes OptAttributes { get { throw null; } set { } }
        public abstract string[] ValidAttributeTargets { get; }
        public void AddAttributes(Mono.CSharp.Attributes attrs, Mono.CSharp.IMemberContext context) { }
        public abstract void ApplyAttributeBuilder(Mono.CSharp.Attribute a, Mono.CSharp.MethodSpec ctor, byte[] cdata, Mono.CSharp.PredefinedAttributes pa);
        public abstract bool IsClsComplianceRequired();
    }
    public partial class Attribute
    {
        public static readonly System.AttributeUsageAttribute DefaultUsageAttribute;
        public static readonly object[] EmptyObject;
        public readonly string ExplicitTarget;
        public System.AttributeTargets Target;
        public Mono.CSharp.TypeSpec Type;
        public Attribute(string target, Mono.CSharp.ATypeNameExpression expr, Mono.CSharp.Arguments[] args, Mono.CSharp.Location loc, bool nameEscaped) { }
        public bool HasSecurityAttribute { get { throw null; } }
        public Mono.CSharp.Location Location { get { throw null; } }
        public string Name { get { throw null; } }
        public Mono.CSharp.Arguments NamedArguments { get { throw null; } }
        public Mono.CSharp.Arguments PositionalArguments { get { throw null; } }
        public Mono.CSharp.Report Report { get { throw null; } }
        public bool ResolveError { get { throw null; } }
        public Mono.CSharp.ATypeNameExpression TypeExpression { get { throw null; } }
        public void AttachTo(Mono.CSharp.Attributable target, Mono.CSharp.IMemberContext context) { }
        public bool CheckTarget() { throw null; }
        public Mono.CSharp.Attribute Clone() { throw null; }
        public Mono.CSharp.ResolveContext CreateResolveContext() { throw null; }
        public void Emit(System.Collections.Generic.Dictionary<Mono.CSharp.Attribute, System.Collections.Generic.List<Mono.CSharp.Attribute>> allEmitted) { }
        public override bool Equals(object obj) { throw null; }
        public static void Error_AttributeArgumentIsDynamic(Mono.CSharp.IMemberContext context, Mono.CSharp.Location loc) { }
        public void Error_InvalidArgumentValue(Mono.CSharp.TypeSpec attributeType) { }
        public void Error_InvalidSecurityParent() { }
        public void Error_MissingGuidAttribute() { }
        public void Error_MisusedDynamicAttribute() { }
        public void Error_MisusedExtensionAttribute() { }
        public void Error_MisusedTupleAttribute() { }
        public void ExtractSecurityPermissionSet(Mono.CSharp.MethodSpec ctor, ref System.Collections.Generic.Dictionary<System.Security.Permissions.SecurityAction, System.Security.PermissionSet> permissions) { }
        public Mono.CSharp.TypeSpec GetArgumentType() { throw null; }
        public System.AttributeUsageAttribute GetAttributeUsageAttribute() { throw null; }
        public bool GetBoolean() { throw null; }
        public System.Runtime.InteropServices.CharSet GetCharSetValue() { throw null; }
        public bool GetClsCompliantAttributeValue() { throw null; }
        public Mono.CSharp.TypeSpec GetCoClassAttributeValue() { throw null; }
        public string GetConditionalAttributeValue() { throw null; }
        public override int GetHashCode() { throw null; }
        public string GetIndexerAttributeValue() { throw null; }
        public System.Runtime.CompilerServices.MethodImplOptions GetMethodImplOptions() { throw null; }
        public Mono.CSharp.Constant GetNamedValue(string name) { throw null; }
        public System.ObsoleteAttribute GetObsoleteAttribute() { throw null; }
        public Mono.CSharp.Expression GetParameterDefaultValue() { throw null; }
        public string GetSignatureForError() { throw null; }
        public string GetString() { throw null; }
        public string GetValidTargets() { throw null; }
        public bool HasField(string fieldName) { throw null; }
        public bool IsExplicitLayoutKind() { throw null; }
        public bool IsInternalCall() { throw null; }
        public static bool IsValidArgumentType(Mono.CSharp.TypeSpec t) { throw null; }
        public bool IsValidSecurityAttribute() { throw null; }
        public Mono.CSharp.MethodSpec Resolve() { throw null; }
        public Mono.CSharp.TypeSpec ResolveTypeForComparison() { throw null; }
        public void SetOwner(Mono.CSharp.Attributable owner) { }
    }
    public sealed partial class AttributeEncoder
    {
        public static readonly byte[] Empty;
        public AttributeEncoder() { }
        public Mono.CSharp.AttributeEncoder.EncodedTypeProperties Encode(Mono.CSharp.TypeSpec type) { throw null; }
        public void Encode(bool value) { }
        public void Encode(byte value) { }
        public void Encode(double value) { }
        public void Encode(short value) { }
        public void Encode(int value) { }
        public void Encode(long value) { }
        public void Encode(sbyte value) { }
        public void Encode(float value) { }
        public void Encode(string value) { }
        public void Encode(ushort value) { }
        public void Encode(uint value) { }
        public void Encode(ulong value) { }
        public void EncodeEmptyNamedArguments() { }
        public void EncodeNamedArguments<T>(T[] members, Mono.CSharp.Constant[] values) where T : Mono.CSharp.MemberSpec, Mono.CSharp.IInterfaceMemberSpec { }
        public void EncodeNamedFieldArgument(Mono.CSharp.FieldSpec field, Mono.CSharp.Constant value) { }
        public void EncodeNamedPropertyArgument(Mono.CSharp.PropertySpec property, Mono.CSharp.Constant value) { }
        public void EncodeTypeName(Mono.CSharp.TypeContainer type) { }
        public void EncodeTypeName(Mono.CSharp.TypeSpec type) { }
        public byte[] ToArray() { throw null; }
        [System.FlagsAttribute]
        public enum EncodedTypeProperties
        {
            DynamicType = 1,
            None = 0,
            TypeParameter = 2,
        }
    }
    public partial class Attributes
    {
        public readonly System.Collections.Generic.List<Mono.CSharp.Attribute> Attrs;
        public Attributes(Mono.CSharp.Attribute a) { }
        public Attributes(System.Collections.Generic.List<Mono.CSharp.Attribute> attrs) { }
        public void AddAttribute(Mono.CSharp.Attribute attr) { }
        public void AddAttributes(System.Collections.Generic.List<Mono.CSharp.Attribute> attrs) { }
        public static void AttachFromPartial(Mono.CSharp.Attributable target, Mono.CSharp.Attributable partialSrc) { }
        public void AttachTo(Mono.CSharp.Attributable attributable, Mono.CSharp.IMemberContext context) { }
        public bool CheckTargets() { throw null; }
        public Mono.CSharp.Attributes Clone() { throw null; }
        public bool Contains(Mono.CSharp.PredefinedAttribute t) { throw null; }
        public void ConvertGlobalAttributes(Mono.CSharp.TypeContainer member, Mono.CSharp.NamespaceContainer currentNamespace, bool isGlobal) { }
        public void Emit() { }
        public bool HasResolveError() { throw null; }
        public Mono.CSharp.Attribute Search(Mono.CSharp.PredefinedAttribute t) { throw null; }
        public Mono.CSharp.Attribute Search(string explicitTarget, Mono.CSharp.PredefinedAttribute t) { throw null; }
        public Mono.CSharp.Attribute[] SearchMulti(Mono.CSharp.PredefinedAttribute t) { throw null; }
    }
    public abstract partial class ATypeNameExpression : Mono.CSharp.FullNamedExpression
    {
        protected Mono.CSharp.TypeArguments targs;
        protected ATypeNameExpression(string name, Mono.CSharp.Location l) { }
        protected ATypeNameExpression(string name, Mono.CSharp.TypeArguments targs, Mono.CSharp.Location l) { }
        protected ATypeNameExpression(string name, int arity, Mono.CSharp.Location l) { }
        public int Arity { get { throw null; } }
        public bool HasTypeArguments { get { throw null; } }
        public string Name { get { throw null; } set { } }
        public Mono.CSharp.TypeArguments TypeArguments { get { throw null; } }
        public override bool Equals(object obj) { throw null; }
        public override int GetHashCode() { throw null; }
        public static string GetMemberType(Mono.CSharp.MemberCore mc) { throw null; }
        public override string GetSignatureForError() { throw null; }
        public abstract Mono.CSharp.Expression LookupNameExpression(Mono.CSharp.ResolveContext rc, Mono.CSharp.Expression.MemberLookupRestrictions restriction);
    }
    public partial class Await : Mono.CSharp.ExpressionStatement
    {
        public Await(Mono.CSharp.Expression expr, Mono.CSharp.Location loc) { }
        public Mono.CSharp.Expression Expr { get { throw null; } }
        public Mono.CSharp.AwaitStatement Statement { get { throw null; } }
        public override object Accept(Mono.CSharp.StructuralVisitor visitor) { throw null; }
        protected override void CloneTo(Mono.CSharp.CloneContext clonectx, Mono.CSharp.Expression target) { }
        public override bool ContainsEmitWithAwait() { throw null; }
        public override Mono.CSharp.Expression CreateExpressionTree(Mono.CSharp.ResolveContext ec) { throw null; }
        protected override Mono.CSharp.Expression DoResolve(Mono.CSharp.ResolveContext rc) { throw null; }
        public override void Emit(Mono.CSharp.EmitContext ec) { }
        public void EmitAssign(Mono.CSharp.EmitContext ec, Mono.CSharp.FieldExpr field) { }
        public override void EmitStatement(Mono.CSharp.EmitContext ec) { }
        public override Mono.CSharp.Expression EmitToField(Mono.CSharp.EmitContext ec) { throw null; }
        public override void FlowAnalysis(Mono.CSharp.FlowAnalysisContext fc) { }
        public override Mono.CSharp.Reachability MarkReachable(Mono.CSharp.Reachability rc) { throw null; }
    }
    public partial class AwaiterDefinition
    {
        public AwaiterDefinition() { }
        public Mono.CSharp.MethodSpec GetResult { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public bool INotifyCompletion { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public Mono.CSharp.PropertySpec IsCompleted { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public bool IsValidPattern { get { throw null; } }
    }
    public partial class AwaitStatement : Mono.CSharp.YieldStatement<Mono.CSharp.AsyncInitializer>
    {
        public AwaitStatement(Mono.CSharp.Expression expr, Mono.CSharp.Location loc) : base (default(Mono.CSharp.Expression), default(Mono.CSharp.Location)) { }
        public Mono.CSharp.TypeSpec ResultType { get { throw null; } }
        protected override void DoEmit(Mono.CSharp.EmitContext ec) { }
        public void EmitPrologue(Mono.CSharp.EmitContext ec) { }
        public void EmitStatement(Mono.CSharp.EmitContext ec) { }
        public Mono.CSharp.Expression GetResultExpression(Mono.CSharp.EmitContext ec) { throw null; }
        public override bool Resolve(Mono.CSharp.BlockContext bc) { throw null; }
        public sealed partial class AwaitableMemberAccess : Mono.CSharp.MemberAccess
        {
            public AwaitableMemberAccess(Mono.CSharp.Expression expr) : base (default(Mono.CSharp.Expression), default(string)) { }
            public bool ProbingMode { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
            protected override void Error_OperatorCannotBeApplied(Mono.CSharp.ResolveContext rc, Mono.CSharp.TypeSpec type) { }
            public override void Error_TypeDoesNotContainDefinition(Mono.CSharp.ResolveContext rc, Mono.CSharp.TypeSpec type, string name) { }
        }
    }
    public partial class BaseThis : Mono.CSharp.This
    {
        public BaseThis(Mono.CSharp.Location loc) : base (default(Mono.CSharp.Location)) { }
        public BaseThis(Mono.CSharp.TypeSpec type, Mono.CSharp.Location loc) : base (default(Mono.CSharp.Location)) { }
        public override string Name { get { throw null; } }
        public override object Accept(Mono.CSharp.StructuralVisitor visitor) { throw null; }
        public override Mono.CSharp.Expression CreateExpressionTree(Mono.CSharp.ResolveContext ec) { throw null; }
        public override void Emit(Mono.CSharp.EmitContext ec) { }
        protected override void Error_ThisNotAvailable(Mono.CSharp.ResolveContext ec) { }
        public override void ResolveBase(Mono.CSharp.ResolveContext ec) { }
    }
    public partial class Binary : Mono.CSharp.Expression
    {
        public Binary(Mono.CSharp.Binary.Operator oper, Mono.CSharp.Expression left, Mono.CSharp.Expression right) { }
        public Binary(Mono.CSharp.Binary.Operator oper, Mono.CSharp.Expression left, Mono.CSharp.Expression right, Mono.CSharp.Binary.State state) { }
        public Binary(Mono.CSharp.Binary.Operator oper, Mono.CSharp.Expression left, Mono.CSharp.Expression right, Mono.CSharp.Location loc) { }
        public Binary(Mono.CSharp.Binary.Operator oper, Mono.CSharp.Expression left, Mono.CSharp.Expression right, bool isCompound) { }
        public bool IsCompound { get { throw null; } }
        public Mono.CSharp.Expression Left { get { throw null; } }
        public Mono.CSharp.Binary.Operator Oper { get { throw null; } }
        public Mono.CSharp.Expression Right { get { throw null; } }
        public override Mono.CSharp.Location StartLocation { get { throw null; } }
        public override object Accept(Mono.CSharp.StructuralVisitor visitor) { throw null; }
        protected override void CloneTo(Mono.CSharp.CloneContext clonectx, Mono.CSharp.Expression t) { }
        public override bool ContainsEmitWithAwait() { throw null; }
        public static Mono.CSharp.Operator.OpType ConvertBinaryToUserOperator(Mono.CSharp.Binary.Operator op) { throw null; }
        public Mono.CSharp.Expression CreateCallSiteBinder(Mono.CSharp.ResolveContext ec, Mono.CSharp.Arguments args) { throw null; }
        public static Mono.CSharp.Binary.PredefinedOperator[] CreateEqualityLiftedOperatorsTable(Mono.CSharp.ModuleContainer module) { throw null; }
        public static Mono.CSharp.Binary.PredefinedOperator[] CreateEqualityOperatorsTable(Mono.CSharp.BuiltinTypes types) { throw null; }
        public override Mono.CSharp.Expression CreateExpressionTree(Mono.CSharp.ResolveContext ec) { throw null; }
        public Mono.CSharp.Expression CreateExpressionTree(Mono.CSharp.ResolveContext ec, Mono.CSharp.Expression method) { throw null; }
        public Mono.CSharp.Expression CreateLiftedValueTypeResult(Mono.CSharp.ResolveContext rc, Mono.CSharp.TypeSpec valueType) { throw null; }
        public static Mono.CSharp.Binary.PredefinedOperator[] CreatePointerOperatorsTable(Mono.CSharp.BuiltinTypes types) { throw null; }
        public static Mono.CSharp.Binary.PredefinedOperator[] CreateStandardLiftedOperatorsTable(Mono.CSharp.ModuleContainer module) { throw null; }
        public static Mono.CSharp.Binary.PredefinedOperator[] CreateStandardOperatorsTable(Mono.CSharp.BuiltinTypes types) { throw null; }
        protected override Mono.CSharp.Expression DoResolve(Mono.CSharp.ResolveContext ec) { throw null; }
        public override void Emit(Mono.CSharp.EmitContext ec) { }
        public override void EmitBranchable(Mono.CSharp.EmitContext ec, System.Reflection.Emit.Label target, bool on_true) { }
        public void EmitOperator(Mono.CSharp.EmitContext ec, Mono.CSharp.Expression left, Mono.CSharp.Expression right) { }
        public static void EmitOperatorOpcode(Mono.CSharp.EmitContext ec, Mono.CSharp.Binary.Operator oper, Mono.CSharp.TypeSpec l, Mono.CSharp.Expression right) { }
        public override void EmitSideEffect(Mono.CSharp.EmitContext ec) { }
        public override Mono.CSharp.Expression EmitToField(Mono.CSharp.EmitContext ec) { throw null; }
        public static void Error_OperatorCannotBeApplied(Mono.CSharp.ResolveContext ec, Mono.CSharp.Expression left, Mono.CSharp.Expression right, Mono.CSharp.Binary.Operator oper, Mono.CSharp.Location loc) { }
        public static void Error_OperatorCannotBeApplied(Mono.CSharp.ResolveContext ec, Mono.CSharp.Expression left, Mono.CSharp.Expression right, string oper, Mono.CSharp.Location loc) { }
        public override void FlowAnalysis(Mono.CSharp.FlowAnalysisContext fc) { }
        public override void FlowAnalysisConditional(Mono.CSharp.FlowAnalysisContext fc) { }
        public static Mono.CSharp.ConvCast.Mode GetEnumResultCast(Mono.CSharp.TypeSpec type) { throw null; }
        public override System.Linq.Expressions.Expression MakeExpression(Mono.CSharp.BuilderContext ctx) { throw null; }
        public System.Linq.Expressions.Expression MakeExpression(Mono.CSharp.BuilderContext ctx, Mono.CSharp.Expression left, Mono.CSharp.Expression right) { throw null; }
        public Mono.CSharp.Expression ResolveOperator(Mono.CSharp.ResolveContext rc) { throw null; }
        [System.FlagsAttribute]
        public enum Operator
        {
            Addition = 2083,
            AdditionMask = 2048,
            ArithmeticMask = 32,
            BitwiseAnd = 525,
            BitwiseMask = 512,
            BitwiseOr = 527,
            ComparisonMask = 128,
            DecomposedMask = 524288,
            Division = 33,
            Equality = 395,
            EqualityMask = 256,
            ExclusiveOr = 526,
            GreaterThan = 8328,
            GreaterThanOrEqual = 8330,
            Inequality = 396,
            LeftShift = 69,
            LessThan = 8327,
            LessThanOrEqual = 8329,
            LogicalAnd = 1040,
            LogicalMask = 1024,
            LogicalOr = 1041,
            Modulus = 34,
            Multiply = 32,
            NullableMask = 1048576,
            RelationalMask = 8192,
            RightShift = 70,
            ShiftMask = 64,
            Subtraction = 4132,
            SubtractionMask = 4096,
            ValuesOnlyMask = 31,
        }
        public partial class PredefinedOperator
        {
            protected readonly Mono.CSharp.TypeSpec left;
            protected readonly Mono.CSharp.TypeSpec left_unwrap;
            public readonly Mono.CSharp.Binary.Operator OperatorsMask;
            public Mono.CSharp.TypeSpec ReturnType;
            protected readonly Mono.CSharp.TypeSpec right;
            protected readonly Mono.CSharp.TypeSpec right_unwrap;
            public PredefinedOperator(Mono.CSharp.TypeSpec type, Mono.CSharp.Binary.Operator op_mask) { }
            public PredefinedOperator(Mono.CSharp.TypeSpec type, Mono.CSharp.Binary.Operator op_mask, Mono.CSharp.TypeSpec return_type) { }
            public PredefinedOperator(Mono.CSharp.TypeSpec ltype, Mono.CSharp.TypeSpec rtype, Mono.CSharp.Binary.Operator op_mask) { }
            public PredefinedOperator(Mono.CSharp.TypeSpec ltype, Mono.CSharp.TypeSpec rtype, Mono.CSharp.Binary.Operator op_mask, Mono.CSharp.TypeSpec return_type) { }
            public bool IsLifted { get { throw null; } }
            public virtual Mono.CSharp.Expression ConvertResult(Mono.CSharp.ResolveContext rc, Mono.CSharp.Binary b) { throw null; }
            public virtual bool IsApplicable(Mono.CSharp.ResolveContext ec, Mono.CSharp.Expression lexpr, Mono.CSharp.Expression rexpr) { throw null; }
            public bool IsPrimitiveApplicable(Mono.CSharp.TypeSpec ltype, Mono.CSharp.TypeSpec rtype) { throw null; }
            public Mono.CSharp.Binary.PredefinedOperator ResolveBetterOperator(Mono.CSharp.ResolveContext ec, Mono.CSharp.Binary.PredefinedOperator best_operator) { throw null; }
        }
        [System.FlagsAttribute]
        public enum State : byte
        {
            Compound = (byte)2,
            None = (byte)0,
            UserOperatorsExcluded = (byte)4,
        }
    }
    [System.FlagsAttribute]
    public enum BindingRestriction
    {
        DeclaredOnly = 2,
        InstanceOnly = 4,
        NoAccessors = 8,
        None = 0,
        OverrideOnly = 16,
    }
    public partial class Block : Mono.CSharp.Statement
    {
        public Mono.CSharp.Location EndLocation;
        public Mono.CSharp.ExplicitBlock Explicit;
        protected Mono.CSharp.Block.Flags flags;
        public Mono.CSharp.ParametersBlock ParametersBlock;
        public Mono.CSharp.Block Parent;
        protected System.Collections.Generic.List<Mono.CSharp.Statement> scope_initializers;
        public Mono.CSharp.Location StartLocation;
        protected System.Collections.Generic.List<Mono.CSharp.Statement> statements;
        public Block(Mono.CSharp.Block parent, Mono.CSharp.Block.Flags flags, Mono.CSharp.Location start, Mono.CSharp.Location end) { }
        public Block(Mono.CSharp.Block parent, Mono.CSharp.Location start, Mono.CSharp.Location end) { }
        public bool IsCatchBlock { get { throw null; } }
        public bool IsCompilerGenerated { get { throw null; } set { } }
        public bool IsFinallyBlock { get { throw null; } }
        public Mono.CSharp.Block Original { get { throw null; } protected set { } }
        public System.Collections.Generic.List<Mono.CSharp.Statement> Statements { get { throw null; } }
        public bool Unchecked { get { throw null; } set { } }
        public bool Unsafe { get { throw null; } set { } }
        public override object Accept(Mono.CSharp.StructuralVisitor visitor) { throw null; }
        public void AddLabel(Mono.CSharp.LabeledStatement target) { }
        public void AddLocalName(Mono.CSharp.LocalVariable li) { }
        public void AddLocalName(string name, Mono.CSharp.INamedBlockVariable li) { }
        public void AddScopeStatement(Mono.CSharp.Statement s) { }
        public void AddStatement(Mono.CSharp.Statement s) { }
        protected override void CloneTo(Mono.CSharp.CloneContext clonectx, Mono.CSharp.Statement t) { }
        protected override void DoEmit(Mono.CSharp.EmitContext ec) { }
        protected override bool DoFlowAnalysis(Mono.CSharp.FlowAnalysisContext fc) { throw null; }
        public override void Emit(Mono.CSharp.EmitContext ec) { }
        protected void EmitScopeInitializers(Mono.CSharp.EmitContext ec) { }
        public virtual void Error_AlreadyDeclared(string name, Mono.CSharp.INamedBlockVariable variable) { }
        public virtual void Error_AlreadyDeclared(string name, Mono.CSharp.INamedBlockVariable variable, string reason) { }
        public virtual void Error_AlreadyDeclaredTypeParameter(string name, Mono.CSharp.Location loc) { }
        public void InsertStatement(int index, Mono.CSharp.Statement s) { }
        public Mono.CSharp.LabeledStatement LookupLabel(string name) { throw null; }
        public override Mono.CSharp.Reachability MarkReachable(Mono.CSharp.Reachability rc) { throw null; }
        public void MarkReachableScope(Mono.CSharp.Reachability rc) { }
        public override bool Resolve(Mono.CSharp.BlockContext bc) { throw null; }
        public void ScanGotoJump(Mono.CSharp.Statement label) { }
        public void ScanGotoJump(Mono.CSharp.Statement label, Mono.CSharp.FlowAnalysisContext fc) { }
        public void SetEndLocation(Mono.CSharp.Location loc) { }
        [System.FlagsAttribute]
        public enum Flags
        {
            AwaitBlock = 8192,
            CatchBlock = 32768,
            CompilerGenerated = 512,
            FinallyBlock = 16384,
            HasAsyncModifier = 1024,
            HasCapturedThis = 128,
            HasCapturedVariable = 64,
            HasReferenceToStoreyForInstanceLambdas = 65536,
            InitializationEmitted = 4194304,
            IsExpressionTree = 256,
            Iterator = 1048576,
            NoFlowAnalysis = 2097152,
            ReachableEnd = 8,
            Resolved = 2048,
            Unchecked = 1,
            Unsafe = 16,
            YieldBlock = 4096,
        }
    }
    public partial class BlockConstant : Mono.CSharp.BlockVariable
    {
        public BlockConstant(Mono.CSharp.FullNamedExpression type, Mono.CSharp.LocalVariable li) : base (default(Mono.CSharp.FullNamedExpression), default(Mono.CSharp.LocalVariable)) { }
        public override object Accept(Mono.CSharp.StructuralVisitor visitor) { throw null; }
        public override void Emit(Mono.CSharp.EmitContext ec) { }
        protected override Mono.CSharp.Expression ResolveInitializer(Mono.CSharp.BlockContext bc, Mono.CSharp.LocalVariable li, Mono.CSharp.Expression initializer) { throw null; }
    }
    public partial class BlockContext : Mono.CSharp.ResolveContext
    {
        public int AssignmentInfoOffset;
        public BlockContext(Mono.CSharp.IMemberContext mc, Mono.CSharp.ExplicitBlock block, Mono.CSharp.TypeSpec returnType) : base (default(Mono.CSharp.IMemberContext)) { }
        public BlockContext(Mono.CSharp.ResolveContext rc, Mono.CSharp.ExplicitBlock block, Mono.CSharp.TypeSpec returnType) : base (default(Mono.CSharp.IMemberContext)) { }
        public Mono.CSharp.ExceptionStatement CurrentTryBlock { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public Mono.CSharp.TryCatch CurrentTryCatch { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public Mono.CSharp.LoopStatement EnclosingLoop { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public Mono.CSharp.LoopStatement EnclosingLoopOrSwitch { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public Mono.CSharp.TypeSpec ReturnType { get { throw null; } }
        public Mono.CSharp.Switch Switch { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    }
    public partial class BlockVariable : Mono.CSharp.Statement
    {
        protected System.Collections.Generic.List<Mono.CSharp.BlockVariableDeclarator> declarators;
        protected Mono.CSharp.LocalVariable li;
        protected Mono.CSharp.FullNamedExpression type_expr;
        public BlockVariable(Mono.CSharp.FullNamedExpression type, Mono.CSharp.LocalVariable li) { }
        protected BlockVariable(Mono.CSharp.LocalVariable li) { }
        public System.Collections.Generic.List<Mono.CSharp.BlockVariableDeclarator> Declarators { get { throw null; } }
        public Mono.CSharp.Expression Initializer { get { throw null; } set { } }
        public Mono.CSharp.FullNamedExpression TypeExpression { get { throw null; } }
        public Mono.CSharp.LocalVariable Variable { get { throw null; } }
        public override object Accept(Mono.CSharp.StructuralVisitor visitor) { throw null; }
        public void AddDeclarator(Mono.CSharp.BlockVariableDeclarator decl) { }
        protected override void CloneTo(Mono.CSharp.CloneContext clonectx, Mono.CSharp.Statement target) { }
        protected override void DoEmit(Mono.CSharp.EmitContext ec) { }
        protected override bool DoFlowAnalysis(Mono.CSharp.FlowAnalysisContext fc) { throw null; }
        public override Mono.CSharp.Reachability MarkReachable(Mono.CSharp.Reachability rc) { throw null; }
        public override bool Resolve(Mono.CSharp.BlockContext bc) { throw null; }
        public bool Resolve(Mono.CSharp.BlockContext bc, bool resolveDeclaratorInitializers) { throw null; }
        protected virtual Mono.CSharp.Expression ResolveInitializer(Mono.CSharp.BlockContext bc, Mono.CSharp.LocalVariable li, Mono.CSharp.Expression initializer) { throw null; }
    }
    public partial class BlockVariableDeclarator
    {
        public BlockVariableDeclarator(Mono.CSharp.LocalVariable li, Mono.CSharp.Expression initializer) { }
        public Mono.CSharp.Expression Initializer { get { throw null; } set { } }
        public Mono.CSharp.LocalVariable Variable { get { throw null; } }
        public virtual Mono.CSharp.BlockVariableDeclarator Clone(Mono.CSharp.CloneContext cloneCtx) { throw null; }
    }
    public partial class BoolConstant : Mono.CSharp.Constant
    {
        public readonly bool Value;
        public BoolConstant(Mono.CSharp.BuiltinTypes types, bool val, Mono.CSharp.Location loc) : base (default(Mono.CSharp.Location)) { }
        public BoolConstant(Mono.CSharp.TypeSpec type, bool val, Mono.CSharp.Location loc) : base (default(Mono.CSharp.Location)) { }
        public override bool IsDefaultValue { get { throw null; } }
        public override bool IsNegative { get { throw null; } }
        public override bool IsZeroInteger { get { throw null; } }
        public override Mono.CSharp.Constant ConvertExplicitly(bool in_checked_context, Mono.CSharp.TypeSpec target_type) { throw null; }
        public override void Emit(Mono.CSharp.EmitContext ec) { }
        public override void EncodeAttributeValue(Mono.CSharp.IMemberContext rc, Mono.CSharp.AttributeEncoder enc, Mono.CSharp.TypeSpec targetType, Mono.CSharp.TypeSpec parameterType) { }
        public override object GetValue() { throw null; }
        public override string GetValueAsLiteral() { throw null; }
        public override long GetValueAsLong() { throw null; }
    }
    public partial class BooleanExpression : Mono.CSharp.ShimExpression
    {
        public BooleanExpression(Mono.CSharp.Expression expr) : base (default(Mono.CSharp.Expression)) { }
        public override object Accept(Mono.CSharp.StructuralVisitor visitor) { throw null; }
        public override Mono.CSharp.Expression CreateExpressionTree(Mono.CSharp.ResolveContext ec) { throw null; }
        protected override Mono.CSharp.Expression DoResolve(Mono.CSharp.ResolveContext ec) { throw null; }
    }
    public partial class BooleanExpressionFalse : Mono.CSharp.Unary
    {
        public BooleanExpressionFalse(Mono.CSharp.Expression expr) : base (default(Mono.CSharp.Unary.Operator), default(Mono.CSharp.Expression), default(Mono.CSharp.Location)) { }
        protected override Mono.CSharp.Expression ResolveOperator(Mono.CSharp.ResolveContext ec, Mono.CSharp.Expression expr) { throw null; }
    }
    public partial class BoolLiteral : Mono.CSharp.BoolConstant, Mono.CSharp.ILiteralConstant
    {
        public BoolLiteral(Mono.CSharp.BuiltinTypes types, bool val, Mono.CSharp.Location loc) : base (default(Mono.CSharp.BuiltinTypes), default(bool), default(Mono.CSharp.Location)) { }
        public override bool IsLiteral { get { throw null; } }
        public override object Accept(Mono.CSharp.StructuralVisitor visitor) { throw null; }
    }
    public partial class BoxedCast : Mono.CSharp.TypeCast
    {
        public BoxedCast(Mono.CSharp.Expression expr, Mono.CSharp.TypeSpec target_type) : base (default(Mono.CSharp.Expression), default(Mono.CSharp.TypeSpec)) { }
        protected override Mono.CSharp.Expression DoResolve(Mono.CSharp.ResolveContext ec) { throw null; }
        public override void Emit(Mono.CSharp.EmitContext ec) { }
        public override void EmitSideEffect(Mono.CSharp.EmitContext ec) { }
        public override void EncodeAttributeValue(Mono.CSharp.IMemberContext rc, Mono.CSharp.AttributeEncoder enc, Mono.CSharp.TypeSpec targetType, Mono.CSharp.TypeSpec parameterType) { }
    }
    public partial class Break : Mono.CSharp.LocalExitStatement
    {
        public Break(Mono.CSharp.Location l) : base (default(Mono.CSharp.Location)) { }
        public override object Accept(Mono.CSharp.StructuralVisitor visitor) { throw null; }
        protected override void DoEmit(Mono.CSharp.EmitContext ec) { }
        protected override bool DoFlowAnalysis(Mono.CSharp.FlowAnalysisContext fc) { throw null; }
        protected override bool DoResolve(Mono.CSharp.BlockContext bc) { throw null; }
        public override Mono.CSharp.Reachability MarkReachable(Mono.CSharp.Reachability rc) { throw null; }
    }
    public partial class BuilderContext
    {
        protected Mono.CSharp.BuilderContext.Options flags;
        public BuilderContext() { }
        public bool HasSet(Mono.CSharp.BuilderContext.Options options) { throw null; }
        public Mono.CSharp.BuilderContext.FlagsHandle With(Mono.CSharp.BuilderContext.Options options, bool enable) { throw null; }
        [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
        public partial struct FlagsHandle : System.IDisposable
        {
            public FlagsHandle(Mono.CSharp.BuilderContext ec, Mono.CSharp.BuilderContext.Options flagsToSet) { throw null;}
            public void Dispose() { }
        }
        [System.FlagsAttribute]
        public enum Options
        {
            AccurateDebugInfo = 2,
            AsyncBody = 16,
            CheckedScope = 1,
            ConstructorScope = 8,
            OmitDebugInfo = 4,
        }
    }
    public partial class BuiltinTypes
    {
        public readonly Mono.CSharp.BuiltinTypeSpec Array;
        public readonly Mono.CSharp.BuiltinTypeSpec Attribute;
        public readonly Mono.CSharp.TypeSpec[] BinaryPromotionsTypes;
        public readonly Mono.CSharp.BuiltinTypeSpec Bool;
        public readonly Mono.CSharp.BuiltinTypeSpec Byte;
        public readonly Mono.CSharp.BuiltinTypeSpec Char;
        public readonly Mono.CSharp.BuiltinTypeSpec Decimal;
        public readonly Mono.CSharp.BuiltinTypeSpec Delegate;
        public readonly Mono.CSharp.BuiltinTypeSpec Double;
        public readonly Mono.CSharp.BuiltinTypeSpec Dynamic;
        public readonly Mono.CSharp.BuiltinTypeSpec Enum;
        public readonly Mono.CSharp.BuiltinTypeSpec Exception;
        public readonly Mono.CSharp.BuiltinTypeSpec Float;
        public readonly Mono.CSharp.BuiltinTypeSpec IDisposable;
        public readonly Mono.CSharp.BuiltinTypeSpec IEnumerable;
        public readonly Mono.CSharp.BuiltinTypeSpec IEnumerator;
        public readonly Mono.CSharp.BuiltinTypeSpec Int;
        public readonly Mono.CSharp.BuiltinTypeSpec IntPtr;
        public readonly Mono.CSharp.BuiltinTypeSpec Long;
        public readonly Mono.CSharp.BuiltinTypeSpec MulticastDelegate;
        public readonly Mono.CSharp.BuiltinTypeSpec Object;
        public readonly Mono.CSharp.Binary.PredefinedOperator[] OperatorsBinaryEquality;
        public readonly Mono.CSharp.Binary.PredefinedOperator[] OperatorsBinaryStandard;
        public readonly Mono.CSharp.Binary.PredefinedOperator[] OperatorsBinaryUnsafe;
        public readonly Mono.CSharp.TypeSpec[][] OperatorsUnary;
        public readonly Mono.CSharp.TypeSpec[] OperatorsUnaryMutator;
        public readonly Mono.CSharp.BuiltinTypeSpec RuntimeFieldHandle;
        public readonly Mono.CSharp.BuiltinTypeSpec RuntimeTypeHandle;
        public readonly Mono.CSharp.BuiltinTypeSpec SByte;
        public readonly Mono.CSharp.BuiltinTypeSpec Short;
        public readonly Mono.CSharp.BuiltinTypeSpec String;
        public readonly Mono.CSharp.BuiltinTypeSpec Type;
        public readonly Mono.CSharp.BuiltinTypeSpec UInt;
        public readonly Mono.CSharp.BuiltinTypeSpec UIntPtr;
        public readonly Mono.CSharp.BuiltinTypeSpec ULong;
        public readonly Mono.CSharp.BuiltinTypeSpec UShort;
        public readonly Mono.CSharp.BuiltinTypeSpec ValueType;
        public readonly Mono.CSharp.BuiltinTypeSpec Void;
        public BuiltinTypes() { }
        public Mono.CSharp.BuiltinTypeSpec[] AllTypes { get { throw null; } }
        public bool CheckDefinitions(Mono.CSharp.ModuleContainer module) { throw null; }
    }
    public sealed partial class BuiltinTypeSpec : Mono.CSharp.TypeSpec
    {
        public BuiltinTypeSpec(Mono.CSharp.MemberKind kind, string ns, string name, Mono.CSharp.BuiltinTypeSpec.Type builtinKind) : base (default(Mono.CSharp.MemberKind), default(Mono.CSharp.TypeSpec), default(Mono.CSharp.ITypeDefinition), default(System.Type), default(Mono.CSharp.Modifiers)) { }
        public BuiltinTypeSpec(string name, Mono.CSharp.BuiltinTypeSpec.Type builtinKind) : base (default(Mono.CSharp.MemberKind), default(Mono.CSharp.TypeSpec), default(Mono.CSharp.ITypeDefinition), default(System.Type), default(Mono.CSharp.Modifiers)) { }
        public override int Arity { get { throw null; } }
        public override Mono.CSharp.BuiltinTypeSpec.Type BuiltinType { get { throw null; } }
        public string FullName { get { throw null; } }
        public override string Name { get { throw null; } }
        public string Namespace { get { throw null; } }
        public override string GetSignatureForError() { throw null; }
        public static int GetSize(Mono.CSharp.TypeSpec type) { throw null; }
        public static bool IsPrimitiveType(Mono.CSharp.TypeSpec type) { throw null; }
        public static bool IsPrimitiveTypeOrDecimal(Mono.CSharp.TypeSpec type) { throw null; }
        public void SetDefinition(Mono.CSharp.ITypeDefinition td, System.Type type, Mono.CSharp.Modifiers mod) { }
        public void SetDefinition(Mono.CSharp.TypeSpec ts) { }
        public enum Type
        {
            Array = 24,
            Attribute = 29,
            Bool = 1,
            Byte = 2,
            Char = 4,
            Decimal = 13,
            Delegate = 22,
            Double = 12,
            Dynamic = 17,
            Enum = 21,
            Exception = 28,
            FirstPrimitive = 1,
            Float = 11,
            IDisposable = 27,
            IEnumerable = 26,
            IEnumerator = 25,
            Int = 7,
            IntPtr = 14,
            LastPrimitive = 12,
            Long = 9,
            MulticastDelegate = 23,
            None = 0,
            Object = 16,
            Other = 30,
            SByte = 3,
            Short = 5,
            String = 18,
            Type = 19,
            UInt = 8,
            UIntPtr = 15,
            ULong = 10,
            UShort = 6,
            ValueType = 20,
        }
    }
    public partial class ByteConstant : Mono.CSharp.IntegralConstant
    {
        public readonly byte Value;
        public ByteConstant(Mono.CSharp.BuiltinTypes types, byte v, Mono.CSharp.Location loc) : base (default(Mono.CSharp.TypeSpec), default(Mono.CSharp.Location)) { }
        public ByteConstant(Mono.CSharp.TypeSpec type, byte v, Mono.CSharp.Location loc) : base (default(Mono.CSharp.TypeSpec), default(Mono.CSharp.Location)) { }
        public override bool IsDefaultValue { get { throw null; } }
        public override bool IsNegative { get { throw null; } }
        public override bool IsOneInteger { get { throw null; } }
        public override bool IsZeroInteger { get { throw null; } }
        public override Mono.CSharp.Constant ConvertExplicitly(bool in_checked_context, Mono.CSharp.TypeSpec target_type) { throw null; }
        public override void Emit(Mono.CSharp.EmitContext ec) { }
        public override void EncodeAttributeValue(Mono.CSharp.IMemberContext rc, Mono.CSharp.AttributeEncoder enc, Mono.CSharp.TypeSpec targetType, Mono.CSharp.TypeSpec parameterType) { }
        public override object GetValue() { throw null; }
        public override long GetValueAsLong() { throw null; }
        public override Mono.CSharp.Constant Increment() { throw null; }
    }
    public partial class Cast : Mono.CSharp.ShimExpression
    {
        public Cast(Mono.CSharp.Expression cast_type, Mono.CSharp.Expression expr, Mono.CSharp.Location loc) : base (default(Mono.CSharp.Expression)) { }
        public Mono.CSharp.Expression TargetType { get { throw null; } }
        public override object Accept(Mono.CSharp.StructuralVisitor visitor) { throw null; }
        protected override void CloneTo(Mono.CSharp.CloneContext clonectx, Mono.CSharp.Expression t) { }
        protected override Mono.CSharp.Expression DoResolve(Mono.CSharp.ResolveContext ec) { throw null; }
    }
    public partial class Catch : Mono.CSharp.Statement
    {
        public Catch(Mono.CSharp.ExplicitBlock block, Mono.CSharp.Location loc) { }
        public Mono.CSharp.ExplicitBlock Block { get { throw null; } }
        public Mono.CSharp.TypeSpec CatchType { get { throw null; } }
        public Mono.CSharp.Expression Filter { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public bool IsGeneral { get { throw null; } }
        public Mono.CSharp.FullNamedExpression TypeExpression { get { throw null; } set { } }
        public Mono.CSharp.LocalVariable Variable { get { throw null; } set { } }
        protected override void CloneTo(Mono.CSharp.CloneContext clonectx, Mono.CSharp.Statement t) { }
        protected override void DoEmit(Mono.CSharp.EmitContext ec) { }
        protected override bool DoFlowAnalysis(Mono.CSharp.FlowAnalysisContext fc) { throw null; }
        public override Mono.CSharp.Reachability MarkReachable(Mono.CSharp.Reachability rc) { throw null; }
        public override bool Resolve(Mono.CSharp.BlockContext bc) { throw null; }
    }
    public partial class CatchFilterExpression : Mono.CSharp.BooleanExpression
    {
        public CatchFilterExpression(Mono.CSharp.Expression expr, Mono.CSharp.Location loc) : base (default(Mono.CSharp.Expression)) { }
    }
    public partial class CharConstant : Mono.CSharp.Constant
    {
        public readonly char Value;
        public CharConstant(Mono.CSharp.BuiltinTypes types, char v, Mono.CSharp.Location loc) : base (default(Mono.CSharp.Location)) { }
        public CharConstant(Mono.CSharp.TypeSpec type, char v, Mono.CSharp.Location loc) : base (default(Mono.CSharp.Location)) { }
        public override bool IsDefaultValue { get { throw null; } }
        public override bool IsNegative { get { throw null; } }
        public override bool IsZeroInteger { get { throw null; } }
        public override Mono.CSharp.Constant ConvertExplicitly(bool in_checked_context, Mono.CSharp.TypeSpec target_type) { throw null; }
        public override void Emit(Mono.CSharp.EmitContext ec) { }
        public override void EncodeAttributeValue(Mono.CSharp.IMemberContext rc, Mono.CSharp.AttributeEncoder enc, Mono.CSharp.TypeSpec targetType, Mono.CSharp.TypeSpec parameterType) { }
        public override object GetValue() { throw null; }
        public override string GetValueAsLiteral() { throw null; }
        public override long GetValueAsLong() { throw null; }
    }
    public partial class CharLiteral : Mono.CSharp.CharConstant, Mono.CSharp.ILiteralConstant
    {
        public CharLiteral(Mono.CSharp.BuiltinTypes types, char c, Mono.CSharp.Location loc) : base (default(Mono.CSharp.BuiltinTypes), default(char), default(Mono.CSharp.Location)) { }
        public override bool IsLiteral { get { throw null; } }
        public override object Accept(Mono.CSharp.StructuralVisitor visitor) { throw null; }
    }
    public partial class Checked : Mono.CSharp.Statement
    {
        public Mono.CSharp.Block Block;
        public Checked(Mono.CSharp.Block b, Mono.CSharp.Location loc) { }
        public override object Accept(Mono.CSharp.StructuralVisitor visitor) { throw null; }
        protected override void CloneTo(Mono.CSharp.CloneContext clonectx, Mono.CSharp.Statement t) { }
        protected override void DoEmit(Mono.CSharp.EmitContext ec) { }
        protected override bool DoFlowAnalysis(Mono.CSharp.FlowAnalysisContext fc) { throw null; }
        public override Mono.CSharp.Reachability MarkReachable(Mono.CSharp.Reachability rc) { throw null; }
        public override bool Resolve(Mono.CSharp.BlockContext ec) { throw null; }
    }
    public partial class CheckedExpr : Mono.CSharp.Expression
    {
        public Mono.CSharp.Expression Expr;
        public CheckedExpr(Mono.CSharp.Expression e, Mono.CSharp.Location l) { }
        public override object Accept(Mono.CSharp.StructuralVisitor visitor) { throw null; }
        protected override void CloneTo(Mono.CSharp.CloneContext clonectx, Mono.CSharp.Expression t) { }
        public override bool ContainsEmitWithAwait() { throw null; }
        public override Mono.CSharp.Expression CreateExpressionTree(Mono.CSharp.ResolveContext ec) { throw null; }
        protected override Mono.CSharp.Expression DoResolve(Mono.CSharp.ResolveContext ec) { throw null; }
        public override void Emit(Mono.CSharp.EmitContext ec) { }
        public override void EmitBranchable(Mono.CSharp.EmitContext ec, System.Reflection.Emit.Label target, bool on_true) { }
        public override void FlowAnalysis(Mono.CSharp.FlowAnalysisContext fc) { }
        public override System.Linq.Expressions.Expression MakeExpression(Mono.CSharp.BuilderContext ctx) { throw null; }
    }
    public sealed partial class Class : Mono.CSharp.ClassOrStruct
    {
        public Class(Mono.CSharp.TypeContainer parent, Mono.CSharp.MemberName name, Mono.CSharp.Modifiers mod, Mono.CSharp.Attributes attrs) : base (default(Mono.CSharp.TypeContainer), default(Mono.CSharp.MemberName), default(Mono.CSharp.Attributes), default(Mono.CSharp.MemberKind)) { }
        public override System.AttributeTargets AttributeTargets { get { throw null; } }
        public override void Accept(Mono.CSharp.StructuralVisitor visitor) { }
        public override void ApplyAttributeBuilder(Mono.CSharp.Attribute a, Mono.CSharp.MethodSpec ctor, byte[] cdata, Mono.CSharp.PredefinedAttributes pa) { }
        public override string[] ConditionalConditions() { throw null; }
        protected override bool DoDefineMembers() { throw null; }
        public override void Emit() { }
        public override void GetCompletionStartingWith(string prefix, System.Collections.Generic.List<string> results) { }
        protected override Mono.CSharp.TypeSpec[] ResolveBaseTypes(out Mono.CSharp.FullNamedExpression base_class) { base_class = default(Mono.CSharp.FullNamedExpression); throw null; }
        public override void SetBaseTypes(System.Collections.Generic.List<Mono.CSharp.FullNamedExpression> baseTypes) { }
    }
    public sealed partial class ClassCast : Mono.CSharp.TypeCast
    {
        public ClassCast(Mono.CSharp.Expression child, Mono.CSharp.TypeSpec return_type) : base (default(Mono.CSharp.Expression), default(Mono.CSharp.TypeSpec)) { }
        public ClassCast(Mono.CSharp.Expression child, Mono.CSharp.TypeSpec return_type, bool forced) : base (default(Mono.CSharp.Expression), default(Mono.CSharp.TypeSpec)) { }
        public override void Emit(Mono.CSharp.EmitContext ec) { }
    }
    public abstract partial class ClassOrStruct : Mono.CSharp.TypeDefinition
    {
        protected Mono.CSharp.Constructor generated_primary_constructor;
        public const System.Reflection.TypeAttributes StaticClassAttribute = (System.Reflection.TypeAttributes)(384);
        protected ClassOrStruct(Mono.CSharp.TypeContainer parent, Mono.CSharp.MemberName name, Mono.CSharp.Attributes attrs, Mono.CSharp.MemberKind kind) : base (default(Mono.CSharp.TypeContainer), default(Mono.CSharp.MemberName), default(Mono.CSharp.Attributes), default(Mono.CSharp.MemberKind)) { }
        public Mono.CSharp.ToplevelBlock PrimaryConstructorBlock { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        protected override System.Reflection.TypeAttributes TypeAttr { get { throw null; } }
        public override void AddNameToContainer(Mono.CSharp.MemberCore symbol, string name) { }
        public override void ApplyAttributeBuilder(Mono.CSharp.Attribute a, Mono.CSharp.MethodSpec ctor, byte[] cdata, Mono.CSharp.PredefinedAttributes pa) { }
        protected virtual Mono.CSharp.Constructor DefineDefaultConstructor(bool is_static) { throw null; }
        protected override bool DoDefineMembers() { throw null; }
        public override void Emit() { }
        public override void PrepareEmit() { }
    }
    public partial class CloneContext
    {
        public CloneContext() { }
        public void AddBlockMap(Mono.CSharp.Block from, Mono.CSharp.Block to) { }
        public Mono.CSharp.Block LookupBlock(Mono.CSharp.Block from) { throw null; }
        public Mono.CSharp.Block RemapBlockCopy(Mono.CSharp.Block from) { throw null; }
    }
    public partial class CollectionOrObjectInitializers : Mono.CSharp.ExpressionStatement
    {
        public CollectionOrObjectInitializers(Mono.CSharp.Location loc) { }
        public CollectionOrObjectInitializers(System.Collections.Generic.IList<Mono.CSharp.Expression> initializers, Mono.CSharp.Location loc) { }
        public System.Collections.Generic.IList<Mono.CSharp.Expression> Initializers { get { throw null; } }
        public bool IsCollectionInitializer { get { throw null; } }
        public bool IsEmpty { get { throw null; } }
        protected override void CloneTo(Mono.CSharp.CloneContext clonectx, Mono.CSharp.Expression target) { }
        public override bool ContainsEmitWithAwait() { throw null; }
        public override Mono.CSharp.Expression CreateExpressionTree(Mono.CSharp.ResolveContext ec) { throw null; }
        public Mono.CSharp.Expression CreateExpressionTree(Mono.CSharp.ResolveContext ec, bool inferType) { throw null; }
        protected override Mono.CSharp.Expression DoResolve(Mono.CSharp.ResolveContext ec) { throw null; }
        public override void Emit(Mono.CSharp.EmitContext ec) { }
        public override void EmitStatement(Mono.CSharp.EmitContext ec) { }
        public override void FlowAnalysis(Mono.CSharp.FlowAnalysisContext fc) { }
    }
    public partial class CommandLineParser
    {
        public CommandLineParser(System.IO.TextWriter errorOutput) { }
        public CommandLineParser(System.IO.TextWriter errorOutput, System.IO.TextWriter messagesOutput) { }
        public bool HasBeenStopped { get { throw null; } }
        public event System.Func<string[], int, int> UnknownOptionHandler { add { } remove { } }
        public bool ParseArguments(Mono.CSharp.CompilerSettings settings, string[] args) { throw null; }
        public Mono.CSharp.CompilerSettings ParseArguments(string[] args) { throw null; }
        public bool ProcessWarningsList(string text, System.Action<int> action) { throw null; }
    }
    public partial class Comparer : System.Collections.IComparer
    {
        internal Comparer() { }
        public int Compare(object a, object b) { throw null; }
        public static System.Reflection.EventInfo[] Sort(System.Reflection.EventInfo[] inf) { throw null; }
        public static System.Reflection.MemberInfo[] Sort(System.Reflection.MemberInfo[] inf) { throw null; }
        public static System.Reflection.MethodBase[] Sort(System.Reflection.MethodBase[] inf) { throw null; }
        public static System.Reflection.PropertyInfo[] Sort(System.Reflection.PropertyInfo[] inf) { throw null; }
    }
    public partial class CompilationSourceFile : Mono.CSharp.NamespaceContainer
    {
        public CompilationSourceFile(Mono.CSharp.ModuleContainer parent) : base (default(Mono.CSharp.MemberName), default(Mono.CSharp.NamespaceContainer)) { }
        public CompilationSourceFile(Mono.CSharp.ModuleContainer parent, Mono.CSharp.SourceFile sourceFile) : base (default(Mono.CSharp.MemberName), default(Mono.CSharp.NamespaceContainer)) { }
        public string FileName { get { throw null; } }
        public Mono.CSharp.SourceFile SourceFile { get { throw null; } }
        public Mono.CompilerServices.SymbolWriter.CompileUnitEntry SymbolUnitEntry { get { throw null; } }
        public override void Accept(Mono.CSharp.StructuralVisitor visitor) { }
        public void AddDefine(string value) { }
        public void AddIncludeFile(Mono.CSharp.SourceFile file) { }
        public void AddUndefine(string value) { }
        public bool IsConditionalDefined(string value) { throw null; }
        public override void PrepareEmit() { }
    }
    public delegate void CompiledMethod(ref object retvalue);
    public partial class CompilerCallableEntryPoint : System.MarshalByRefObject
    {
        public CompilerCallableEntryPoint() { }
        public static int[] AllWarningNumbers { get { throw null; } }
        public static bool InvokeCompiler(string[] args, System.IO.TextWriter error) { throw null; }
        public static void PartialReset() { }
        public static void Reset() { }
        public static void Reset(bool full_flag) { }
    }
    public partial class CompilerContext
    {
        public CompilerContext(Mono.CSharp.CompilerSettings settings, Mono.CSharp.ReportPrinter reportPrinter) { }
        public Mono.CSharp.BuiltinTypes BuiltinTypes { get { throw null; } }
        public bool IsRuntimeBinder { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public Mono.CSharp.Report Report { get { throw null; } }
        public Mono.CSharp.CompilerSettings Settings { get { throw null; } }
        public System.Collections.Generic.List<Mono.CSharp.SourceFile> SourceFiles { get { throw null; } }
        public Mono.CSharp.SourceFile LookupFile(Mono.CSharp.CompilationSourceFile comp_unit, string name) { throw null; }
    }
    public abstract partial class CompilerGeneratedContainer : Mono.CSharp.ClassOrStruct
    {
        protected CompilerGeneratedContainer(Mono.CSharp.TypeContainer parent, Mono.CSharp.MemberName name, Mono.CSharp.Modifiers mod) : base (default(Mono.CSharp.TypeContainer), default(Mono.CSharp.MemberName), default(Mono.CSharp.Attributes), default(Mono.CSharp.MemberKind)) { }
        protected CompilerGeneratedContainer(Mono.CSharp.TypeContainer parent, Mono.CSharp.MemberName name, Mono.CSharp.Modifiers mod, Mono.CSharp.MemberKind kind) : base (default(Mono.CSharp.TypeContainer), default(Mono.CSharp.MemberName), default(Mono.CSharp.Attributes), default(Mono.CSharp.MemberKind)) { }
        protected void CheckMembersDefined() { }
        protected override bool DoDefineMembers() { throw null; }
        protected static Mono.CSharp.MemberName MakeMemberName(Mono.CSharp.MemberBase host, string name, int unique_id, Mono.CSharp.TypeParameters tparams, Mono.CSharp.Location loc) { throw null; }
        public static string MakeName(string host, string typePrefix, string name, int id) { throw null; }
        protected override Mono.CSharp.TypeSpec[] ResolveBaseTypes(out Mono.CSharp.FullNamedExpression base_class) { base_class = default(Mono.CSharp.FullNamedExpression); throw null; }
    }
    public partial class CompilerSettings
    {
        public System.Collections.Generic.List<string> AssemblyReferences;
        public System.Collections.Generic.List<System.Tuple<string, string>> AssemblyReferencesAliases;
        public bool BreakOnInternalError;
        public bool Checked;
        public int DebugFlags;
        public string DocumentationFile;
        public System.Text.Encoding Encoding;
        public bool EnhancedWarnings;
        public int FatalCounter;
        public bool GenerateDebugInfo;
        public System.Collections.Generic.List<string> GetResourceStrings;
        public bool LoadDefaultReferences;
        public string MainClass;
        public System.Collections.Generic.List<string> Modules;
        public bool Optimize;
        public string OutputFile;
        public bool ParseOnly;
        public System.Collections.Generic.List<System.Collections.Generic.KeyValuePair<string, string>> PathMap;
        public Mono.CSharp.Platform Platform;
        public System.Collections.Generic.List<string> ReferencesLookupPaths;
        public System.Collections.Generic.List<Mono.CSharp.AssemblyResource> Resources;
        public string RuntimeMetadataVersion;
        public string SdkVersion;
        public bool ShowFullPaths;
        public bool Stacktrace;
        public bool StatementMode;
        public bool StdLib;
        public Mono.CSharp.RuntimeVersion StdLibRuntimeVersion;
        public bool StrongNameDelaySign;
        public string StrongNameKeyContainer;
        public string StrongNameKeyFile;
        public int TabSize;
        public Mono.CSharp.Target Target;
        public string TargetExt;
        public bool Timestamps;
        public bool TokenizeOnly;
        public bool Unsafe;
        public int VerboseParserFlag;
        public bool VerifyClsCompliance;
        public Mono.CSharp.LanguageVersion Version;
        public int WarningLevel;
        public bool WarningsAreErrors;
        public string Win32IconFile;
        public string Win32ResourceFile;
        public bool WriteMetadataOnly;
        public CompilerSettings() { }
        public Mono.CSharp.SourceFile FirstSourceFile { get { throw null; } }
        public bool HasKeyFileOrContainer { get { throw null; } }
        public bool NeedsEntryPoint { get { throw null; } }
        public System.Collections.Generic.List<Mono.CSharp.SourceFile> SourceFiles { get { throw null; } }
        public void AddConditionalSymbol(string symbol) { }
        public void AddWarningAsError(int id) { }
        public void AddWarningOnly(int id) { }
        public bool IsConditionalSymbolDefined(string symbol) { throw null; }
        public bool IsWarningAsError(int code) { throw null; }
        public bool IsWarningDisabledGlobally(int code) { throw null; }
        public bool IsWarningEnabled(int code, int level) { throw null; }
        public void SetIgnoreWarning(int code) { }
    }
    public abstract partial class CompletingExpression : Mono.CSharp.ExpressionStatement
    {
        protected CompletingExpression() { }
        public static void AppendResults(System.Collections.Generic.List<string> results, string prefix, System.Collections.Generic.IEnumerable<string> names) { }
        public override bool ContainsEmitWithAwait() { throw null; }
        public override Mono.CSharp.Expression CreateExpressionTree(Mono.CSharp.ResolveContext ec) { throw null; }
        public override void Emit(Mono.CSharp.EmitContext ec) { }
        public override void EmitStatement(Mono.CSharp.EmitContext ec) { }
    }
    public partial class CompletionElementInitializer : Mono.CSharp.CompletingExpression
    {
        public CompletionElementInitializer(string partial_name, Mono.CSharp.Location l) { }
        protected override void CloneTo(Mono.CSharp.CloneContext clonectx, Mono.CSharp.Expression t) { }
        protected override Mono.CSharp.Expression DoResolve(Mono.CSharp.ResolveContext ec) { throw null; }
    }
    public partial class CompletionMemberAccess : Mono.CSharp.CompletingExpression
    {
        public CompletionMemberAccess(Mono.CSharp.Expression e, string partial_name, Mono.CSharp.Location l) { }
        public CompletionMemberAccess(Mono.CSharp.Expression e, string partial_name, Mono.CSharp.TypeArguments targs, Mono.CSharp.Location l) { }
        protected override void CloneTo(Mono.CSharp.CloneContext clonectx, Mono.CSharp.Expression t) { }
        protected override Mono.CSharp.Expression DoResolve(Mono.CSharp.ResolveContext rc) { throw null; }
    }
    public partial class CompletionResult : System.Exception
    {
        public CompletionResult(string base_text, string[] res) { }
        public string BaseText { get { throw null; } }
        public string[] Result { get { throw null; } }
    }
    public partial class CompletionSimpleName : Mono.CSharp.CompletingExpression
    {
        public string Prefix;
        public CompletionSimpleName(string prefix, Mono.CSharp.Location l) { }
        protected override void CloneTo(Mono.CSharp.CloneContext clonectx, Mono.CSharp.Expression t) { }
        protected override Mono.CSharp.Expression DoResolve(Mono.CSharp.ResolveContext ec) { throw null; }
    }
    public partial class ComposedCast : Mono.CSharp.TypeExpr
    {
        public ComposedCast(Mono.CSharp.FullNamedExpression left, Mono.CSharp.ComposedTypeSpecifier spec) { }
        public override object Accept(Mono.CSharp.StructuralVisitor visitor) { throw null; }
        public override string GetSignatureForError() { throw null; }
        public override Mono.CSharp.TypeSpec ResolveAsType(Mono.CSharp.IMemberContext ec, bool allowUnboundTypeArguments) { throw null; }
    }
    public partial class ComposedTypeSpecifier
    {
        public readonly int Dimension;
        public readonly Mono.CSharp.Location Location;
        public static readonly Mono.CSharp.ComposedTypeSpecifier SingleDimension;
        public ComposedTypeSpecifier(int specifier, Mono.CSharp.Location loc) { }
        public bool IsNullable { get { throw null; } }
        public bool IsPointer { get { throw null; } }
        public Mono.CSharp.ComposedTypeSpecifier Next { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public static Mono.CSharp.ComposedTypeSpecifier CreateArrayDimension(int dimension, Mono.CSharp.Location loc) { throw null; }
        public static Mono.CSharp.ComposedTypeSpecifier CreateNullable(Mono.CSharp.Location loc) { throw null; }
        public static Mono.CSharp.ComposedTypeSpecifier CreatePointer(Mono.CSharp.Location loc) { throw null; }
        public string GetSignatureForError() { throw null; }
    }
    public abstract partial class CompositeExpression : Mono.CSharp.Expression
    {
        protected Mono.CSharp.Expression expr;
        protected CompositeExpression(Mono.CSharp.Expression expr) { }
        public Mono.CSharp.Expression Child { get { throw null; } }
        public override bool IsNull { get { throw null; } }
        public override bool ContainsEmitWithAwait() { throw null; }
        public override Mono.CSharp.Expression CreateExpressionTree(Mono.CSharp.ResolveContext rc) { throw null; }
        protected override Mono.CSharp.Expression DoResolve(Mono.CSharp.ResolveContext rc) { throw null; }
        public override void Emit(Mono.CSharp.EmitContext ec) { }
    }
    public partial class CompoundAssign : Mono.CSharp.Assign
    {
        public CompoundAssign(Mono.CSharp.Binary.Operator op, Mono.CSharp.Expression target, Mono.CSharp.Expression source) : base (default(Mono.CSharp.Expression), default(Mono.CSharp.Expression), default(Mono.CSharp.Location)) { }
        public CompoundAssign(Mono.CSharp.Binary.Operator op, Mono.CSharp.Expression target, Mono.CSharp.Expression source, Mono.CSharp.Expression left) : base (default(Mono.CSharp.Expression), default(Mono.CSharp.Expression), default(Mono.CSharp.Location)) { }
        public Mono.CSharp.Binary.Operator Operator { get { throw null; } }
        public override object Accept(Mono.CSharp.StructuralVisitor visitor) { throw null; }
        protected override void CloneTo(Mono.CSharp.CloneContext clonectx, Mono.CSharp.Expression t) { }
        protected override Mono.CSharp.Expression DoResolve(Mono.CSharp.ResolveContext ec) { throw null; }
        public override void FlowAnalysis(Mono.CSharp.FlowAnalysisContext fc) { }
        protected override Mono.CSharp.Expression ResolveConversions(Mono.CSharp.ResolveContext ec) { throw null; }
        public sealed partial class TargetExpression : Mono.CSharp.Expression
        {
            public TargetExpression(Mono.CSharp.Expression child) { }
            public bool RequiresEmitWithAwait { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
            public override bool ContainsEmitWithAwait() { throw null; }
            public override Mono.CSharp.Expression CreateExpressionTree(Mono.CSharp.ResolveContext ec) { throw null; }
            protected override Mono.CSharp.Expression DoResolve(Mono.CSharp.ResolveContext ec) { throw null; }
            public override void Emit(Mono.CSharp.EmitContext ec) { }
            public override Mono.CSharp.Expression EmitToField(Mono.CSharp.EmitContext ec) { throw null; }
        }
    }
    public partial class Conditional : Mono.CSharp.Expression
    {
        public Conditional(Mono.CSharp.Expression expr, Mono.CSharp.Expression true_expr, Mono.CSharp.Expression false_expr, Mono.CSharp.Location loc) { }
        public Mono.CSharp.Expression Expr { get { throw null; } }
        public Mono.CSharp.Expression FalseExpr { get { throw null; } }
        public Mono.CSharp.Expression TrueExpr { get { throw null; } }
        protected override void CloneTo(Mono.CSharp.CloneContext clonectx, Mono.CSharp.Expression t) { }
        public override bool ContainsEmitWithAwait() { throw null; }
        public override Mono.CSharp.Expression CreateExpressionTree(Mono.CSharp.ResolveContext ec) { throw null; }
        protected override Mono.CSharp.Expression DoResolve(Mono.CSharp.ResolveContext ec) { throw null; }
        public override void Emit(Mono.CSharp.EmitContext ec) { }
        public override void FlowAnalysis(Mono.CSharp.FlowAnalysisContext fc) { }
        public override void FlowAnalysisConditional(Mono.CSharp.FlowAnalysisContext fc) { }
    }
    public partial class ConditionalAccessContext
    {
        public ConditionalAccessContext(Mono.CSharp.TypeSpec type, System.Reflection.Emit.Label endLabel) { }
        public System.Reflection.Emit.Label EndLabel { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        public bool Statement { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public Mono.CSharp.TypeSpec Type { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
    }
    public partial class ConditionalLogicalOperator : Mono.CSharp.UserOperatorCall
    {
        public ConditionalLogicalOperator(Mono.CSharp.MethodSpec oper, Mono.CSharp.Arguments arguments, System.Func<Mono.CSharp.ResolveContext, Mono.CSharp.Expression, Mono.CSharp.Expression> expr_tree, bool is_and, Mono.CSharp.Location loc) : base (default(Mono.CSharp.MethodSpec), default(Mono.CSharp.Arguments), default(System.Func<Mono.CSharp.ResolveContext, Mono.CSharp.Expression, Mono.CSharp.Expression>), default(Mono.CSharp.Location)) { }
        protected override Mono.CSharp.Expression DoResolve(Mono.CSharp.ResolveContext ec) { throw null; }
        public override void Emit(Mono.CSharp.EmitContext ec) { }
    }
    public partial class ConditionalMemberAccess : Mono.CSharp.MemberAccess
    {
        public ConditionalMemberAccess(Mono.CSharp.Expression expr, string identifier, Mono.CSharp.TypeArguments args, Mono.CSharp.Location loc) : base (default(Mono.CSharp.Expression), default(string)) { }
        public override bool HasConditionalAccess() { throw null; }
    }
    public partial class ConsoleReportPrinter : Mono.CSharp.StreamReportPrinter
    {
        public ConsoleReportPrinter() : base (default(System.IO.TextWriter)) { }
        public ConsoleReportPrinter(System.IO.TextWriter writer) : base (default(System.IO.TextWriter)) { }
        protected override string FormatText(string txt) { throw null; }
    }
    public partial class Const : Mono.CSharp.FieldBase
    {
        public Const(Mono.CSharp.TypeDefinition parent, Mono.CSharp.FullNamedExpression type, Mono.CSharp.Modifiers mod_flags, Mono.CSharp.MemberName name, Mono.CSharp.Attributes attrs) : base (default(Mono.CSharp.TypeDefinition), default(Mono.CSharp.FullNamedExpression), default(Mono.CSharp.Modifiers), default(Mono.CSharp.Modifiers), default(Mono.CSharp.MemberName), default(Mono.CSharp.Attributes)) { }
        public override void Accept(Mono.CSharp.StructuralVisitor visitor) { }
        public override bool Define() { throw null; }
        public void DefineValue() { }
        public override void Emit() { }
        public static void Error_InvalidConstantType(Mono.CSharp.TypeSpec t, Mono.CSharp.Location loc, Mono.CSharp.Report Report) { }
        public override void PrepareEmit() { }
    }
    public abstract partial class Constant : Mono.CSharp.Expression
    {
        protected Constant(Mono.CSharp.Location loc) { }
        public abstract bool IsDefaultValue { get; }
        public virtual bool IsLiteral { get { throw null; } }
        public abstract bool IsNegative { get; }
        public virtual bool IsOneInteger { get { throw null; } }
        public override bool IsSideEffectFree { get { throw null; } }
        public virtual bool IsZeroInteger { get { throw null; } }
        public sealed override Mono.CSharp.Expression Clone(Mono.CSharp.CloneContext clonectx) { throw null; }
        protected override void CloneTo(Mono.CSharp.CloneContext clonectx, Mono.CSharp.Expression target) { }
        public override bool ContainsEmitWithAwait() { throw null; }
        public abstract Mono.CSharp.Constant ConvertExplicitly(bool in_checked_context, Mono.CSharp.TypeSpec target_type);
        public virtual Mono.CSharp.Constant ConvertImplicitly(Mono.CSharp.TypeSpec type) { throw null; }
        public static Mono.CSharp.Constant CreateConstantFromValue(Mono.CSharp.TypeSpec t, object v, Mono.CSharp.Location loc) { throw null; }
        public override Mono.CSharp.Expression CreateExpressionTree(Mono.CSharp.ResolveContext ec) { throw null; }
        protected override Mono.CSharp.Expression DoResolve(Mono.CSharp.ResolveContext rc) { throw null; }
        public override void EmitSideEffect(Mono.CSharp.EmitContext ec) { }
        public override void Error_ValueCannotBeConverted(Mono.CSharp.ResolveContext ec, Mono.CSharp.TypeSpec target, bool expl) { }
        public static Mono.CSharp.Constant ExtractConstantFromValue(Mono.CSharp.TypeSpec t, object v, Mono.CSharp.Location loc) { throw null; }
        public virtual object GetTypedValue() { throw null; }
        public abstract object GetValue();
        public abstract string GetValueAsLiteral();
        public abstract long GetValueAsLong();
        public Mono.CSharp.Constant ImplicitConversionRequired(Mono.CSharp.ResolveContext ec, Mono.CSharp.TypeSpec type) { throw null; }
        public bool IsDefaultInitializer(Mono.CSharp.TypeSpec type) { throw null; }
        public override System.Linq.Expressions.Expression MakeExpression(Mono.CSharp.BuilderContext ctx) { throw null; }
        public Mono.CSharp.Constant Reduce(Mono.CSharp.ResolveContext ec, Mono.CSharp.TypeSpec target_type) { throw null; }
        public new bool Resolve(Mono.CSharp.ResolveContext rc) { throw null; }
        public override string ToString() { throw null; }
        public Mono.CSharp.Constant TryReduce(Mono.CSharp.ResolveContext rc, Mono.CSharp.TypeSpec targetType) { throw null; }
    }
    public partial class ConstantExpr : Mono.CSharp.MemberExpr
    {
        public ConstantExpr(Mono.CSharp.ConstSpec constant, Mono.CSharp.Location loc) { }
        protected override Mono.CSharp.TypeSpec DeclaringType { get { throw null; } }
        public override bool IsInstance { get { throw null; } }
        public override bool IsStatic { get { throw null; } }
        public override string KindName { get { throw null; } }
        public override string Name { get { throw null; } }
        public override Mono.CSharp.Expression CreateExpressionTree(Mono.CSharp.ResolveContext ec) { throw null; }
        protected override Mono.CSharp.Expression DoResolve(Mono.CSharp.ResolveContext rc) { throw null; }
        public override void Emit(Mono.CSharp.EmitContext ec) { }
        public override string GetSignatureForError() { throw null; }
        public override void ResolveNameOf(Mono.CSharp.ResolveContext rc, Mono.CSharp.ATypeNameExpression expr) { }
        public override void SetTypeArguments(Mono.CSharp.ResolveContext ec, Mono.CSharp.TypeArguments ta) { }
    }
    public static partial class ConstantFold
    {
        public static Mono.CSharp.Constant BinaryFold(Mono.CSharp.ResolveContext ec, Mono.CSharp.Binary.Operator oper, Mono.CSharp.Constant left, Mono.CSharp.Constant right, Mono.CSharp.Location loc) { throw null; }
        public static Mono.CSharp.TypeSpec[] CreateBinaryPromotionsTypes(Mono.CSharp.BuiltinTypes types) { throw null; }
    }
    public partial class ConstInitializer : Mono.CSharp.ShimExpression
    {
        public ConstInitializer(Mono.CSharp.FieldBase field, Mono.CSharp.Expression value, Mono.CSharp.Location loc) : base (default(Mono.CSharp.Expression)) { }
        public string Name { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public override object Accept(Mono.CSharp.StructuralVisitor visitor) { throw null; }
        protected override Mono.CSharp.Expression DoResolve(Mono.CSharp.ResolveContext unused) { throw null; }
        protected virtual Mono.CSharp.Expression DoResolveInitializer(Mono.CSharp.ResolveContext rc) { throw null; }
        public override string GetSignatureForError() { throw null; }
    }
    public partial class Constraints
    {
        public Constraints(Mono.CSharp.SimpleMemberName tparam, System.Collections.Generic.List<Mono.CSharp.FullNamedExpression> constraints, Mono.CSharp.Location loc) { }
        public Mono.CSharp.Location Location { get { throw null; } }
        public System.Collections.Generic.List<Mono.CSharp.FullNamedExpression> TypeExpressions { get { throw null; } }
        public Mono.CSharp.SimpleMemberName TypeParameter { get { throw null; } }
        public static bool CheckConflictingInheritedConstraint(Mono.CSharp.TypeParameterSpec spec, Mono.CSharp.TypeSpec bb, Mono.CSharp.IMemberContext context, Mono.CSharp.Location loc) { throw null; }
        public void CheckGenericConstraints(Mono.CSharp.IMemberContext context, bool obsoleteCheck) { }
        public static void Error_ConflictingConstraints(Mono.CSharp.IMemberContext context, Mono.CSharp.TypeParameterSpec tp, Mono.CSharp.TypeSpec ba, Mono.CSharp.TypeSpec bb, Mono.CSharp.Location loc) { }
        public bool Resolve(Mono.CSharp.IMemberContext context, Mono.CSharp.TypeParameter tp) { throw null; }
        public void VerifyClsCompliance(Mono.CSharp.Report report) { }
    }
    public partial class Constructor : Mono.CSharp.MethodCore, Mono.CSharp.IMemberContext, Mono.CSharp.IMemberDefinition, Mono.CSharp.IMethodData, Mono.CSharp.IMethodDefinition, Mono.CSharp.IModuleContext
    {
        public const Mono.CSharp.Modifiers AllowedModifiers = (Mono.CSharp.Modifiers)(10383);
        public System.Reflection.Emit.ConstructorBuilder ConstructorBuilder;
        public static readonly string ConstructorName;
        public Mono.CSharp.ConstructorInitializer Initializer;
        public static readonly string TypeConstructorName;
        public Constructor(Mono.CSharp.TypeDefinition parent, string name, Mono.CSharp.Modifiers mod, Mono.CSharp.Attributes attrs, Mono.CSharp.ParametersCompiled args, Mono.CSharp.Location loc) : base (default(Mono.CSharp.TypeDefinition), default(Mono.CSharp.FullNamedExpression), default(Mono.CSharp.Modifiers), default(Mono.CSharp.Modifiers), default(Mono.CSharp.MemberName), default(Mono.CSharp.Attributes), default(Mono.CSharp.ParametersCompiled)) { }
        public override System.AttributeTargets AttributeTargets { get { throw null; } }
        public bool HasCompliantArgs { get { throw null; } }
        public bool IsPrimaryConstructor { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public Mono.CSharp.MemberName MethodName { get { throw null; } }
        bool Mono.CSharp.IMethodData.IsAccessor { get { throw null; } }
        System.Reflection.MethodBase Mono.CSharp.IMethodDefinition.Metadata { get { throw null; } }
        public Mono.CSharp.TypeSpec ReturnType { get { throw null; } }
        public override string[] ValidAttributeTargets { get { throw null; } }
        public override void Accept(Mono.CSharp.StructuralVisitor visitor) { }
        public override void ApplyAttributeBuilder(Mono.CSharp.Attribute a, Mono.CSharp.MethodSpec ctor, byte[] cdata, Mono.CSharp.PredefinedAttributes pa) { }
        protected override bool CheckBase() { throw null; }
        public override bool Define() { throw null; }
        public override void Emit() { }
        protected override Mono.CSharp.MemberSpec FindBaseMember(out Mono.CSharp.MemberSpec bestCandidate, ref bool overrides) { bestCandidate = default(Mono.CSharp.MemberSpec); throw null; }
        public override string GetCallerMemberName() { throw null; }
        public override string GetSignatureForDocumentation() { throw null; }
        public override string GetSignatureForError() { throw null; }
        public bool IsDefault() { throw null; }
        Mono.CSharp.EmitContext Mono.CSharp.IMethodData.CreateEmitContext(System.Reflection.Emit.ILGenerator ig, Mono.CompilerServices.SymbolWriter.SourceMethodBuilder sourceMethod) { throw null; }
        protected override bool VerifyClsCompliance() { throw null; }
        public override void WriteDebugSymbol(Mono.CompilerServices.SymbolWriter.MonoSymbolFile file) { }
    }
    public partial class ConstructorBaseInitializer : Mono.CSharp.ConstructorInitializer
    {
        public ConstructorBaseInitializer(Mono.CSharp.Arguments argument_list, Mono.CSharp.Location l) : base (default(Mono.CSharp.Arguments), default(Mono.CSharp.Location)) { }
    }
    public abstract partial class ConstructorInitializer : Mono.CSharp.ExpressionStatement
    {
        protected ConstructorInitializer(Mono.CSharp.Arguments argument_list, Mono.CSharp.Location loc) { }
        public Mono.CSharp.Arguments Arguments { get { throw null; } }
        public override bool ContainsEmitWithAwait() { throw null; }
        public override Mono.CSharp.Expression CreateExpressionTree(Mono.CSharp.ResolveContext ec) { throw null; }
        protected override Mono.CSharp.Expression DoResolve(Mono.CSharp.ResolveContext ec) { throw null; }
        public override void Emit(Mono.CSharp.EmitContext ec) { }
        public override void EmitStatement(Mono.CSharp.EmitContext ec) { }
        public override void FlowAnalysis(Mono.CSharp.FlowAnalysisContext fc) { }
    }
    public partial class ConstructorThisInitializer : Mono.CSharp.ConstructorInitializer
    {
        public ConstructorThisInitializer(Mono.CSharp.Arguments argument_list, Mono.CSharp.Location l) : base (default(Mono.CSharp.Arguments), default(Mono.CSharp.Location)) { }
    }
    public partial class ConstSpec : Mono.CSharp.FieldSpec
    {
        public ConstSpec(Mono.CSharp.TypeSpec declaringType, Mono.CSharp.IMemberDefinition definition, Mono.CSharp.TypeSpec memberType, System.Reflection.FieldInfo fi, Mono.CSharp.Modifiers mod, Mono.CSharp.Expression value) : base (default(Mono.CSharp.TypeSpec), default(Mono.CSharp.IMemberDefinition), default(Mono.CSharp.TypeSpec), default(System.Reflection.FieldInfo), default(Mono.CSharp.Modifiers)) { }
        public Mono.CSharp.Expression Value { get { throw null; } }
        public Mono.CSharp.Constant GetConstant(Mono.CSharp.ResolveContext rc) { throw null; }
    }
    public partial class ContextualReturn : Mono.CSharp.Return
    {
        public ContextualReturn(Mono.CSharp.Expression expr) : base (default(Mono.CSharp.Expression), default(Mono.CSharp.Location)) { }
        public override Mono.CSharp.Expression CreateExpressionTree(Mono.CSharp.ResolveContext ec) { throw null; }
        protected override void DoEmit(Mono.CSharp.EmitContext ec) { }
        protected override bool DoResolve(Mono.CSharp.BlockContext ec) { throw null; }
    }
    public partial class Continue : Mono.CSharp.LocalExitStatement
    {
        public Continue(Mono.CSharp.Location l) : base (default(Mono.CSharp.Location)) { }
        public override object Accept(Mono.CSharp.StructuralVisitor visitor) { throw null; }
        protected override void DoEmit(Mono.CSharp.EmitContext ec) { }
        protected override bool DoResolve(Mono.CSharp.BlockContext bc) { throw null; }
        public override Mono.CSharp.Reachability MarkReachable(Mono.CSharp.Reachability rc) { throw null; }
    }
    public partial class ConvCast : Mono.CSharp.TypeCast
    {
        public ConvCast(Mono.CSharp.Expression child, Mono.CSharp.TypeSpec return_type, Mono.CSharp.ConvCast.Mode m) : base (default(Mono.CSharp.Expression), default(Mono.CSharp.TypeSpec)) { }
        protected override Mono.CSharp.Expression DoResolve(Mono.CSharp.ResolveContext ec) { throw null; }
        public override void Emit(Mono.CSharp.EmitContext ec) { }
        public static void Emit(Mono.CSharp.EmitContext ec, Mono.CSharp.ConvCast.Mode mode) { }
        public override string ToString() { throw null; }
        public enum Mode : byte
        {
            CH_I1 = (byte)48,
            CH_I2 = (byte)50,
            CH_U1 = (byte)49,
            I1_CH = (byte)4,
            I1_U1 = (byte)0,
            I1_U2 = (byte)1,
            I1_U4 = (byte)2,
            I1_U8 = (byte)3,
            I2_CH = (byte)12,
            I2_I1 = (byte)7,
            I2_U1 = (byte)8,
            I2_U2 = (byte)9,
            I2_U4 = (byte)10,
            I2_U8 = (byte)11,
            I4_CH = (byte)23,
            I4_I1 = (byte)17,
            I4_I2 = (byte)19,
            I4_U1 = (byte)18,
            I4_U2 = (byte)20,
            I4_U4 = (byte)21,
            I4_U8 = (byte)22,
            I8_CH = (byte)37,
            I8_I = (byte)38,
            I8_I1 = (byte)30,
            I8_I2 = (byte)32,
            I8_I4 = (byte)34,
            I8_U1 = (byte)31,
            I8_U2 = (byte)33,
            I8_U4 = (byte)35,
            I8_U8 = (byte)36,
            I_I8 = (byte)70,
            R4_CH = (byte)59,
            R4_I1 = (byte)51,
            R4_I2 = (byte)53,
            R4_I4 = (byte)55,
            R4_I8 = (byte)57,
            R4_U1 = (byte)52,
            R4_U2 = (byte)54,
            R4_U4 = (byte)56,
            R4_U8 = (byte)58,
            R8_CH = (byte)68,
            R8_I1 = (byte)60,
            R8_I2 = (byte)62,
            R8_I4 = (byte)64,
            R8_I8 = (byte)66,
            R8_R4 = (byte)69,
            R8_U1 = (byte)61,
            R8_U2 = (byte)63,
            R8_U4 = (byte)65,
            R8_U8 = (byte)67,
            U1_CH = (byte)6,
            U1_I1 = (byte)5,
            U2_CH = (byte)16,
            U2_I1 = (byte)13,
            U2_I2 = (byte)15,
            U2_U1 = (byte)14,
            U4_CH = (byte)29,
            U4_I1 = (byte)24,
            U4_I2 = (byte)26,
            U4_I4 = (byte)28,
            U4_U1 = (byte)25,
            U4_U2 = (byte)27,
            U8_CH = (byte)46,
            U8_I = (byte)47,
            U8_I1 = (byte)39,
            U8_I2 = (byte)41,
            U8_I4 = (byte)43,
            U8_I8 = (byte)45,
            U8_U1 = (byte)40,
            U8_U2 = (byte)42,
            U8_U4 = (byte)44,
        }
    }
    [System.FlagsAttribute]
    public enum CSharpBinderFlags
    {
        BinaryOperationLogical = 8,
        CheckedContext = 1,
        ConvertArrayIndex = 32,
        ConvertExplicit = 16,
        InvokeSimpleName = 2,
        InvokeSpecialName = 4,
        None = 0,
        ResultDiscarded = 256,
        ResultIndexed = 64,
        ValueFromCompoundAssignment = 128,
    }
    public partial class CSharpParser
    {
        public int eof_token;
        public System.IO.TextWriter ErrorOutput;
        public Mono.CSharp.Class InteractiveResult;
        public Mono.CSharp.Undo undo;
        public bool UnexpectedEOF;
        protected bool use_global_stacks;
        protected static readonly short[] yyCheck;
        protected static readonly short[] yyDgoto;
        protected const int yyFinal = 7;
        protected static readonly short[] yyGindex;
        protected int yyMax;
        protected static readonly string[] yyNames;
        protected static readonly short[] yyRindex;
        protected static readonly short[] yySindex;
        protected static readonly short[] yyTable;
        public CSharpParser(Mono.CSharp.SeekableStreamReader reader, Mono.CSharp.CompilationSourceFile file, Mono.CSharp.ParserSession session) { }
        public CSharpParser(Mono.CSharp.SeekableStreamReader reader, Mono.CSharp.CompilationSourceFile file, Mono.CSharp.Report report, Mono.CSharp.ParserSession session) { }
        public Mono.CSharp.Tokenizer Lexer { get { throw null; } }
        public void parse() { }
        protected object yyDefault(object first) { throw null; }
        public void yyerror(string message) { }
        public void yyerror(string message, string[] expected) { }
        protected string[] yyExpecting(int state) { throw null; }
        protected int[] yyExpectingTokens(int state) { throw null; }
    }
    public partial class DecimalConstant : Mono.CSharp.Constant
    {
        public readonly decimal Value;
        public DecimalConstant(Mono.CSharp.BuiltinTypes types, decimal d, Mono.CSharp.Location loc) : base (default(Mono.CSharp.Location)) { }
        public DecimalConstant(Mono.CSharp.TypeSpec type, decimal d, Mono.CSharp.Location loc) : base (default(Mono.CSharp.Location)) { }
        public override bool IsDefaultValue { get { throw null; } }
        public override bool IsNegative { get { throw null; } }
        public override Mono.CSharp.Constant ConvertExplicitly(bool in_checked_context, Mono.CSharp.TypeSpec target_type) { throw null; }
        public override void Emit(Mono.CSharp.EmitContext ec) { }
        public override object GetValue() { throw null; }
        public override string GetValueAsLiteral() { throw null; }
        public override long GetValueAsLong() { throw null; }
    }
    public partial class DecimalLiteral : Mono.CSharp.DecimalConstant, Mono.CSharp.ILiteralConstant
    {
        public DecimalLiteral(Mono.CSharp.BuiltinTypes types, decimal d, Mono.CSharp.Location loc) : base (default(Mono.CSharp.BuiltinTypes), default(decimal), default(Mono.CSharp.Location)) { }
        public override bool IsLiteral { get { throw null; } }
        public override object Accept(Mono.CSharp.StructuralVisitor visitor) { throw null; }
    }
    public partial class DeclarationExpression : Mono.CSharp.Expression, Mono.CSharp.IMemoryLocation
    {
        public DeclarationExpression(Mono.CSharp.FullNamedExpression variableType, Mono.CSharp.LocalVariable variable) { }
        public Mono.CSharp.Expression Initializer { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public Mono.CSharp.LocalVariable Variable { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public Mono.CSharp.FullNamedExpression VariableType { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public void AddressOf(Mono.CSharp.EmitContext ec, Mono.CSharp.AddressOp mode) { }
        protected override void CloneTo(Mono.CSharp.CloneContext clonectx, Mono.CSharp.Expression t) { }
        public override Mono.CSharp.Expression CreateExpressionTree(Mono.CSharp.ResolveContext rc) { throw null; }
        protected override Mono.CSharp.Expression DoResolve(Mono.CSharp.ResolveContext rc) { throw null; }
        public override Mono.CSharp.Expression DoResolveLValue(Mono.CSharp.ResolveContext rc, Mono.CSharp.Expression right_side) { throw null; }
        public override void Emit(Mono.CSharp.EmitContext ec) { }
        public override void EmitPrepare(Mono.CSharp.EmitContext ec) { }
    }
    public partial class DefaultParameterValueExpression : Mono.CSharp.CompositeExpression
    {
        public DefaultParameterValueExpression(Mono.CSharp.Expression expr) : base (default(Mono.CSharp.Expression)) { }
        public override object Accept(Mono.CSharp.StructuralVisitor visitor) { throw null; }
        public void Resolve(Mono.CSharp.ResolveContext rc, Mono.CSharp.Parameter p) { }
    }
    public partial class DefaultValueExpression : Mono.CSharp.Expression
    {
        public DefaultValueExpression(Mono.CSharp.Expression expr, Mono.CSharp.Location loc) { }
        public Mono.CSharp.Expression Expr { get { throw null; } }
        public override bool IsSideEffectFree { get { throw null; } }
        public override object Accept(Mono.CSharp.StructuralVisitor visitor) { throw null; }
        protected override void CloneTo(Mono.CSharp.CloneContext clonectx, Mono.CSharp.Expression t) { }
        public override bool ContainsEmitWithAwait() { throw null; }
        public override Mono.CSharp.Expression CreateExpressionTree(Mono.CSharp.ResolveContext ec) { throw null; }
        protected override Mono.CSharp.Expression DoResolve(Mono.CSharp.ResolveContext ec) { throw null; }
        public override void Emit(Mono.CSharp.EmitContext ec) { }
        public override System.Linq.Expressions.Expression MakeExpression(Mono.CSharp.BuilderContext ctx) { throw null; }
    }
    public partial class DefiniteAssignmentBitSet
    {
        public static readonly Mono.CSharp.DefiniteAssignmentBitSet Empty;
        public DefiniteAssignmentBitSet(Mono.CSharp.DefiniteAssignmentBitSet source) { }
        public DefiniteAssignmentBitSet(int length) { }
        public bool this[int index] { get { throw null; } }
        public static Mono.CSharp.DefiniteAssignmentBitSet And(System.Collections.Generic.List<Mono.CSharp.DefiniteAssignmentBitSet> das) { throw null; }
        public static bool IsIncluded(Mono.CSharp.DefiniteAssignmentBitSet @set, Mono.CSharp.DefiniteAssignmentBitSet test) { throw null; }
        public static Mono.CSharp.DefiniteAssignmentBitSet operator &(Mono.CSharp.DefiniteAssignmentBitSet a, Mono.CSharp.DefiniteAssignmentBitSet b) { throw null; }
        public static Mono.CSharp.DefiniteAssignmentBitSet operator |(Mono.CSharp.DefiniteAssignmentBitSet a, Mono.CSharp.DefiniteAssignmentBitSet b) { throw null; }
        public void Set(int index) { }
        public void Set(int index, int length) { }
        public override string ToString() { throw null; }
    }
    public partial class Delegate : Mono.CSharp.TypeDefinition, Mono.CSharp.IInterfaceMemberSpec, Mono.CSharp.IParametersMember
    {
        public static readonly string InvokeMethodName;
        public Delegate(Mono.CSharp.TypeContainer parent, Mono.CSharp.FullNamedExpression type, Mono.CSharp.Modifiers mod_flags, Mono.CSharp.MemberName name, Mono.CSharp.ParametersCompiled param_list, Mono.CSharp.Attributes attrs) : base (default(Mono.CSharp.TypeContainer), default(Mono.CSharp.MemberName), default(Mono.CSharp.Attributes), default(Mono.CSharp.MemberKind)) { }
        public override System.AttributeTargets AttributeTargets { get { throw null; } }
        public Mono.CSharp.Expression InstanceExpression { get { throw null; } set { } }
        public Mono.CSharp.TypeSpec MemberType { get { throw null; } }
        public Mono.CSharp.AParametersCollection Parameters { get { throw null; } }
        protected override System.Reflection.TypeAttributes TypeAttr { get { throw null; } }
        public Mono.CSharp.FullNamedExpression TypExpression { get { throw null; } }
        public override string[] ValidAttributeTargets { get { throw null; } }
        public override void Accept(Mono.CSharp.StructuralVisitor visitor) { }
        public override void ApplyAttributeBuilder(Mono.CSharp.Attribute a, Mono.CSharp.MethodSpec ctor, byte[] cdata, Mono.CSharp.PredefinedAttributes pa) { }
        protected override bool DoDefineMembers() { throw null; }
        public override void Emit() { }
        public static string FullDelegateDesc(Mono.CSharp.MethodSpec invoke_method) { throw null; }
        public static Mono.CSharp.MethodSpec GetConstructor(Mono.CSharp.TypeSpec delType) { throw null; }
        public static Mono.CSharp.MethodSpec GetInvokeMethod(Mono.CSharp.TypeSpec delType) { throw null; }
        public static Mono.CSharp.AParametersCollection GetParameters(Mono.CSharp.TypeSpec delType) { throw null; }
        public static bool IsTypeCovariant(Mono.CSharp.ResolveContext rc, Mono.CSharp.TypeSpec a, Mono.CSharp.TypeSpec b) { throw null; }
        public override void PrepareEmit() { }
        protected override Mono.CSharp.TypeSpec[] ResolveBaseTypes(out Mono.CSharp.FullNamedExpression base_class) { base_class = default(Mono.CSharp.FullNamedExpression); throw null; }
        protected override bool VerifyClsCompliance() { throw null; }
    }
    public abstract partial class DelegateCreation : Mono.CSharp.Expression, Mono.CSharp.OverloadResolver.IErrorHandler
    {
        protected Mono.CSharp.MethodSpec constructor_method;
        protected Mono.CSharp.MethodGroupExpr method_group;
        protected DelegateCreation() { }
        public bool AllowSpecialMethodsInvocation { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public override bool ContainsEmitWithAwait() { throw null; }
        public static Mono.CSharp.Arguments CreateDelegateMethodArguments(Mono.CSharp.ResolveContext rc, Mono.CSharp.AParametersCollection pd, Mono.CSharp.TypeSpec[] types, Mono.CSharp.Location loc) { throw null; }
        public override Mono.CSharp.Expression CreateExpressionTree(Mono.CSharp.ResolveContext ec) { throw null; }
        protected override Mono.CSharp.Expression DoResolve(Mono.CSharp.ResolveContext ec) { throw null; }
        public override void Emit(Mono.CSharp.EmitContext ec) { }
        public override void FlowAnalysis(Mono.CSharp.FlowAnalysisContext fc) { }
        public static bool ImplicitStandardConversionExists(Mono.CSharp.ResolveContext ec, Mono.CSharp.MethodGroupExpr mg, Mono.CSharp.TypeSpec target_type) { throw null; }
        bool Mono.CSharp.OverloadResolver.IErrorHandler.AmbiguousCandidates(Mono.CSharp.ResolveContext ec, Mono.CSharp.MemberSpec best, Mono.CSharp.MemberSpec ambiguous) { throw null; }
        bool Mono.CSharp.OverloadResolver.IErrorHandler.ArgumentMismatch(Mono.CSharp.ResolveContext rc, Mono.CSharp.MemberSpec best, Mono.CSharp.Argument arg, int index) { throw null; }
        bool Mono.CSharp.OverloadResolver.IErrorHandler.NoArgumentMatch(Mono.CSharp.ResolveContext rc, Mono.CSharp.MemberSpec best) { throw null; }
        bool Mono.CSharp.OverloadResolver.IErrorHandler.TypeInferenceFailed(Mono.CSharp.ResolveContext rc, Mono.CSharp.MemberSpec best) { throw null; }
    }
    public partial class Destructor : Mono.CSharp.MethodOrOperator
    {
        public static readonly string MetadataName;
        public Destructor(Mono.CSharp.TypeDefinition parent, Mono.CSharp.Modifiers mod, Mono.CSharp.ParametersCompiled parameters, Mono.CSharp.Attributes attrs, Mono.CSharp.Location l) : base (default(Mono.CSharp.TypeDefinition), default(Mono.CSharp.FullNamedExpression), default(Mono.CSharp.Modifiers), default(Mono.CSharp.Modifiers), default(Mono.CSharp.MemberName), default(Mono.CSharp.Attributes), default(Mono.CSharp.ParametersCompiled)) { }
        public override string[] ValidAttributeTargets { get { throw null; } }
        public override void Accept(Mono.CSharp.StructuralVisitor visitor) { }
        public override void ApplyAttributeBuilder(Mono.CSharp.Attribute a, Mono.CSharp.MethodSpec ctor, byte[] cdata, Mono.CSharp.PredefinedAttributes pa) { }
        protected override bool CheckBase() { throw null; }
        public override bool Define() { throw null; }
        public override void Emit() { }
        public override string GetSignatureForError() { throw null; }
        protected override bool ResolveMemberType() { throw null; }
    }
    public partial class Do : Mono.CSharp.LoopStatement
    {
        public Mono.CSharp.Expression expr;
        public Do(Mono.CSharp.Statement statement, Mono.CSharp.BooleanExpression bool_expr, Mono.CSharp.Location doLocation, Mono.CSharp.Location whileLocation) : base (default(Mono.CSharp.Statement)) { }
        public Mono.CSharp.Location WhileLocation { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        public override object Accept(Mono.CSharp.StructuralVisitor visitor) { throw null; }
        protected override void CloneTo(Mono.CSharp.CloneContext clonectx, Mono.CSharp.Statement t) { }
        protected override void DoEmit(Mono.CSharp.EmitContext ec) { }
        protected override bool DoFlowAnalysis(Mono.CSharp.FlowAnalysisContext fc) { throw null; }
        public override Mono.CSharp.Reachability MarkReachable(Mono.CSharp.Reachability rc) { throw null; }
        public override bool Resolve(Mono.CSharp.BlockContext bc) { throw null; }
        public override void SetEndReachable() { }
        public override void SetIteratorReachable() { }
    }
    public partial class DoubleConstant : Mono.CSharp.Constant
    {
        public readonly double Value;
        public DoubleConstant(Mono.CSharp.BuiltinTypes types, double v, Mono.CSharp.Location loc) : base (default(Mono.CSharp.Location)) { }
        public DoubleConstant(Mono.CSharp.TypeSpec type, double v, Mono.CSharp.Location loc) : base (default(Mono.CSharp.Location)) { }
        public override bool IsDefaultValue { get { throw null; } }
        public override bool IsNegative { get { throw null; } }
        public override Mono.CSharp.Constant ConvertExplicitly(bool in_checked_context, Mono.CSharp.TypeSpec target_type) { throw null; }
        public override void Emit(Mono.CSharp.EmitContext ec) { }
        public override void EncodeAttributeValue(Mono.CSharp.IMemberContext rc, Mono.CSharp.AttributeEncoder enc, Mono.CSharp.TypeSpec targetType, Mono.CSharp.TypeSpec parameterType) { }
        public override object GetValue() { throw null; }
        public override string GetValueAsLiteral() { throw null; }
        public override long GetValueAsLong() { throw null; }
    }
    public partial class DoubleLiteral : Mono.CSharp.DoubleConstant, Mono.CSharp.ILiteralConstant
    {
        public DoubleLiteral(Mono.CSharp.BuiltinTypes types, double d, Mono.CSharp.Location loc) : base (default(Mono.CSharp.BuiltinTypes), default(double), default(Mono.CSharp.Location)) { }
        public override bool IsLiteral { get { throw null; } }
        public override object Accept(Mono.CSharp.StructuralVisitor visitor) { throw null; }
        public override void Error_ValueCannotBeConverted(Mono.CSharp.ResolveContext ec, Mono.CSharp.TypeSpec target, bool expl) { }
    }
    public partial class DynamicResultCast : Mono.CSharp.ShimExpression
    {
        public DynamicResultCast(Mono.CSharp.TypeSpec type, Mono.CSharp.Expression expr) : base (default(Mono.CSharp.Expression)) { }
        protected override Mono.CSharp.Expression DoResolve(Mono.CSharp.ResolveContext ec) { throw null; }
        public override System.Linq.Expressions.Expression MakeExpression(Mono.CSharp.BuilderContext ctx) { throw null; }
    }
    public partial class ElementAccess : Mono.CSharp.Expression
    {
        public Mono.CSharp.Arguments Arguments;
        public Mono.CSharp.Expression Expr;
        public ElementAccess(Mono.CSharp.Expression e, Mono.CSharp.Arguments args, Mono.CSharp.Location loc) { }
        public bool ConditionalAccess { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public override Mono.CSharp.Location StartLocation { get { throw null; } }
        public override object Accept(Mono.CSharp.StructuralVisitor visitor) { throw null; }
        protected override void CloneTo(Mono.CSharp.CloneContext clonectx, Mono.CSharp.Expression t) { }
        public override bool ContainsEmitWithAwait() { throw null; }
        public override Mono.CSharp.Expression CreateExpressionTree(Mono.CSharp.ResolveContext ec) { throw null; }
        protected override Mono.CSharp.Expression DoResolve(Mono.CSharp.ResolveContext rc) { throw null; }
        public override Mono.CSharp.Expression DoResolveLValue(Mono.CSharp.ResolveContext ec, Mono.CSharp.Expression rhs) { throw null; }
        public override void Emit(Mono.CSharp.EmitContext ec) { }
        public static void Error_CannotApplyIndexing(Mono.CSharp.ResolveContext rc, Mono.CSharp.TypeSpec type, Mono.CSharp.Location loc) { }
        public override void FlowAnalysis(Mono.CSharp.FlowAnalysisContext fc) { }
        public override string GetSignatureForError() { throw null; }
        public override bool HasConditionalAccess() { throw null; }
    }
    public partial class ElementInitializer : Mono.CSharp.Assign
    {
        public readonly string Name;
        public ElementInitializer(string name, Mono.CSharp.Expression initializer, Mono.CSharp.Location loc) : base (default(Mono.CSharp.Expression), default(Mono.CSharp.Expression), default(Mono.CSharp.Location)) { }
        public bool IsDictionaryInitializer { get { throw null; } }
        protected override void CloneTo(Mono.CSharp.CloneContext clonectx, Mono.CSharp.Expression t) { }
        public override Mono.CSharp.Expression CreateExpressionTree(Mono.CSharp.ResolveContext ec) { throw null; }
        protected override Mono.CSharp.Expression DoResolve(Mono.CSharp.ResolveContext ec) { throw null; }
        public override void EmitStatement(Mono.CSharp.EmitContext ec) { }
        protected virtual bool ResolveElement(Mono.CSharp.ResolveContext rc) { throw null; }
    }
    public abstract partial class ElementTypeSpec : Mono.CSharp.TypeSpec, Mono.CSharp.IMemberDefinition, Mono.CSharp.ITypeDefinition
    {
        protected ElementTypeSpec(Mono.CSharp.MemberKind kind, Mono.CSharp.TypeSpec element, System.Type info) : base (default(Mono.CSharp.MemberKind), default(Mono.CSharp.TypeSpec), default(Mono.CSharp.ITypeDefinition), default(System.Type), default(Mono.CSharp.Modifiers)) { }
        public Mono.CSharp.TypeSpec Element { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        public override System.Collections.Generic.IList<Mono.CSharp.TypeSpec> Interfaces { set { } }
        public bool IsImported { get { throw null; } }
        System.Nullable<bool> Mono.CSharp.IMemberDefinition.CLSAttributeValue { get { throw null; } }
        Mono.CSharp.IAssemblyDefinition Mono.CSharp.ITypeDefinition.DeclaringAssembly { get { throw null; } }
        bool Mono.CSharp.ITypeDefinition.IsComImport { get { throw null; } }
        bool Mono.CSharp.ITypeDefinition.IsCyclicTypeForwarder { get { throw null; } }
        bool Mono.CSharp.ITypeDefinition.IsPartial { get { throw null; } }
        bool Mono.CSharp.ITypeDefinition.IsTypeForwarder { get { throw null; } }
        public override string Name { get { throw null; } }
        public string Namespace { get { throw null; } }
        public Mono.CSharp.TypeParameterSpec[] TypeParameters { get { throw null; } }
        public int TypeParametersCount { get { throw null; } }
        public override void CheckObsoleteness(Mono.CSharp.IMemberContext mc, Mono.CSharp.Location loc) { }
        public string[] ConditionalConditions() { throw null; }
        public Mono.CSharp.TypeSpec GetAttributeCoClass() { throw null; }
        public string GetAttributeDefaultMember() { throw null; }
        public override System.ObsoleteAttribute GetAttributeObsolete() { throw null; }
        protected virtual string GetPostfixSignature() { throw null; }
        public override string GetSignatureForDocumentation(bool explicitName) { throw null; }
        public override string GetSignatureForError() { throw null; }
        public void LoadMembers(Mono.CSharp.TypeSpec declaringType, bool onlyTypes, ref Mono.CSharp.MemberCache cache) { }
        bool Mono.CSharp.ITypeDefinition.IsInternalAsPublic(Mono.CSharp.IAssemblyDefinition assembly) { throw null; }
        public override Mono.CSharp.TypeSpec Mutate(Mono.CSharp.TypeParameterMutator mutator) { throw null; }
        public void SetIsAssigned() { }
        public void SetIsUsed() { }
    }
    public partial class EmitContext : Mono.CSharp.BuilderContext
    {
        public Mono.CSharp.AnonymousExpression CurrentAnonymousMethod;
        public System.Reflection.Emit.Label DefaultTarget;
        public readonly System.Reflection.Emit.ILGenerator ig;
        public System.Reflection.Emit.Label LoopBegin;
        public System.Reflection.Emit.Label LoopEnd;
        public System.Reflection.Emit.LocalBuilder return_value;
        public Mono.CSharp.Switch Switch;
        public EmitContext(Mono.CSharp.IMemberContext rc, System.Reflection.Emit.ILGenerator ig, Mono.CSharp.TypeSpec return_type, Mono.CompilerServices.SymbolWriter.SourceMethodBuilder methodSymbols) { }
        public Mono.CSharp.LocalVariable AsyncThrowVariable { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public Mono.CSharp.BuiltinTypes BuiltinTypes { get { throw null; } }
        public Mono.CSharp.ConditionalAccessContext ConditionalAccess { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public Mono.CSharp.TypeSpec CurrentType { get { throw null; } }
        public Mono.CSharp.MemberCore CurrentTypeDefinition { get { throw null; } }
        public Mono.CSharp.TypeParameters CurrentTypeParameters { get { throw null; } }
        public bool EmitAccurateDebugInfo { get { throw null; } }
        public bool HasMethodSymbolBuilder { get { throw null; } }
        public bool HasReturnLabel { get { throw null; } }
        public bool IsAnonymousStoreyMutateRequired { get { throw null; } }
        public bool IsStatic { get { throw null; } }
        public bool IsStaticConstructor { get { throw null; } }
        public Mono.CSharp.IMemberContext MemberContext { get { throw null; } }
        public Mono.CSharp.ModuleContainer Module { get { throw null; } }
        public bool NotifyEvaluatorOnStore { get { throw null; } }
        public System.Reflection.Emit.Label RecursivePatternLabel { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public Mono.CSharp.Report Report { get { throw null; } }
        public System.Reflection.Emit.Label ReturnLabel { get { throw null; } }
        public Mono.CSharp.TypeSpec ReturnType { get { throw null; } }
        public System.Collections.Generic.List<Mono.CSharp.IExpressionCleanup> StatementEpilogue { get { throw null; } }
        public System.Collections.Generic.List<Mono.CSharp.TryFinally> TryFinallyUnwind { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public void AddStatementEpilog(Mono.CSharp.IExpressionCleanup cleanupExpression) { }
        public void AssertEmptyStack() { }
        public void BeginCatchBlock(Mono.CSharp.TypeSpec type) { }
        public void BeginCompilerScope(int scopeIndex) { }
        public void BeginExceptionBlock() { }
        public void BeginExceptionFilterBlock() { }
        public void BeginFilterHandler() { }
        public void BeginFinallyBlock() { }
        public void BeginScope(int scopeIndex) { }
        public void CloseConditionalAccess(Mono.CSharp.TypeSpec type) { }
        public System.Reflection.Emit.Label CreateReturnLabel() { throw null; }
        public System.Reflection.Emit.LocalBuilder DeclareLocal(Mono.CSharp.TypeSpec type, bool pinned) { throw null; }
        public System.Reflection.Emit.Label DefineLabel() { throw null; }
        public void DefineLocalVariable(string name, System.Reflection.Emit.LocalBuilder builder) { }
        public void Emit(System.Reflection.Emit.OpCode opcode) { }
        public void Emit(System.Reflection.Emit.OpCode opcode, Mono.CSharp.FieldSpec field) { }
        public void Emit(System.Reflection.Emit.OpCode opcode, Mono.CSharp.MethodSpec method) { }
        public void Emit(System.Reflection.Emit.OpCode opcode, Mono.CSharp.MethodSpec method, System.Type[] vargs) { }
        public void Emit(System.Reflection.Emit.OpCode opcode, Mono.CSharp.TypeSpec type) { }
        public void Emit(System.Reflection.Emit.OpCode opcode, double arg) { }
        public void Emit(System.Reflection.Emit.OpCode opcode, System.Reflection.Emit.Label label) { }
        public void Emit(System.Reflection.Emit.OpCode opcode, System.Reflection.Emit.Label[] labels) { }
        public void Emit(System.Reflection.Emit.OpCode opcode, System.Reflection.Emit.LocalBuilder local) { }
        public void Emit(System.Reflection.Emit.OpCode opcode, System.Reflection.MethodInfo method) { }
        public void Emit(System.Reflection.Emit.OpCode opcode, float arg) { }
        public void Emit(System.Reflection.Emit.OpCode opcode, string arg) { }
        public void EmitArgumentAddress(int pos) { }
        public void EmitArgumentLoad(int pos) { }
        public void EmitArgumentStore(int pos) { }
        public void EmitArrayAddress(Mono.CSharp.ArrayContainer ac) { }
        public void EmitArrayLoad(Mono.CSharp.ArrayContainer ac) { }
        public void EmitArrayNew(Mono.CSharp.ArrayContainer ac) { }
        public void EmitArrayStore(Mono.CSharp.ArrayContainer ac) { }
        public void EmitEpilogue() { }
        public void EmitInt(int i) { }
        public void EmitLoadFromPtr(Mono.CSharp.TypeSpec type) { }
        public void EmitLong(long l) { }
        public void EmitNull() { }
        public void EmitStoreFromPtr(Mono.CSharp.TypeSpec type) { }
        public void EmitThis() { }
        public void EndExceptionBlock() { }
        public void EndScope() { }
        public void FreeTemporaryLocal(System.Reflection.Emit.LocalBuilder b, Mono.CSharp.TypeSpec t) { }
        public Mono.CSharp.StackFieldExpr GetTemporaryField(Mono.CSharp.TypeSpec type, bool initializedFieldRequired=false) { throw null; }
        public System.Reflection.Emit.LocalBuilder GetTemporaryLocal(Mono.CSharp.TypeSpec t) { throw null; }
        public bool Mark(Mono.CSharp.Location loc) { throw null; }
        public void MarkCallEntry(Mono.CSharp.Location loc) { }
        public void MarkLabel(System.Reflection.Emit.Label label) { }
        public System.Reflection.Emit.LocalBuilder TemporaryReturn() { throw null; }
    }
    public partial class EmptyCast : Mono.CSharp.TypeCast
    {
        internal EmptyCast() : base (default(Mono.CSharp.Expression), default(Mono.CSharp.TypeSpec)) { }
        public static Mono.CSharp.Expression Create(Mono.CSharp.Expression child, Mono.CSharp.TypeSpec type) { throw null; }
        public override void EmitBranchable(Mono.CSharp.EmitContext ec, System.Reflection.Emit.Label label, bool on_true) { }
        public override void EmitSideEffect(Mono.CSharp.EmitContext ec) { }
    }
    public partial class EmptyCompletion : Mono.CSharp.CompletingExpression
    {
        public EmptyCompletion() { }
        protected override void CloneTo(Mono.CSharp.CloneContext clonectx, Mono.CSharp.Expression target) { }
        protected override Mono.CSharp.Expression DoResolve(Mono.CSharp.ResolveContext rc) { throw null; }
    }
    public partial class EmptyConstantCast : Mono.CSharp.Constant
    {
        public readonly Mono.CSharp.Constant child;
        public EmptyConstantCast(Mono.CSharp.Constant child, Mono.CSharp.TypeSpec type) : base (default(Mono.CSharp.Location)) { }
        public override bool IsDefaultValue { get { throw null; } }
        public override bool IsNegative { get { throw null; } }
        public override bool IsNull { get { throw null; } }
        public override bool IsOneInteger { get { throw null; } }
        public override bool IsSideEffectFree { get { throw null; } }
        public override bool IsZeroInteger { get { throw null; } }
        public override Mono.CSharp.Constant ConvertExplicitly(bool in_checked_context, Mono.CSharp.TypeSpec target_type) { throw null; }
        public override Mono.CSharp.Constant ConvertImplicitly(Mono.CSharp.TypeSpec target_type) { throw null; }
        public override Mono.CSharp.Expression CreateExpressionTree(Mono.CSharp.ResolveContext ec) { throw null; }
        public override void Emit(Mono.CSharp.EmitContext ec) { }
        public override void EmitBranchable(Mono.CSharp.EmitContext ec, System.Reflection.Emit.Label label, bool on_true) { }
        public override void EmitSideEffect(Mono.CSharp.EmitContext ec) { }
        public override object GetValue() { throw null; }
        public override string GetValueAsLiteral() { throw null; }
        public override long GetValueAsLong() { throw null; }
    }
    public partial class EmptyExpression : Mono.CSharp.Expression
    {
        public static readonly Mono.CSharp.EmptyExpression EventAddition;
        public static readonly Mono.CSharp.EmptyExpression EventSubtraction;
        public static readonly Mono.CSharp.EmptyExpression LValueMemberAccess;
        public static readonly Mono.CSharp.EmptyExpression LValueMemberOutAccess;
        public static readonly Mono.CSharp.EmptyExpression MissingValue;
        public static readonly Mono.CSharp.Expression Null;
        public static readonly Mono.CSharp.EmptyExpression OutAccess;
        public static readonly Mono.CSharp.EmptyExpression UnaryAddress;
        public EmptyExpression(Mono.CSharp.TypeSpec t) { }
        public override object Accept(Mono.CSharp.StructuralVisitor visitor) { throw null; }
        protected override void CloneTo(Mono.CSharp.CloneContext clonectx, Mono.CSharp.Expression target) { }
        public override bool ContainsEmitWithAwait() { throw null; }
        public override Mono.CSharp.Expression CreateExpressionTree(Mono.CSharp.ResolveContext ec) { throw null; }
        protected override Mono.CSharp.Expression DoResolve(Mono.CSharp.ResolveContext ec) { throw null; }
        public override void Emit(Mono.CSharp.EmitContext ec) { }
        public override void EmitBranchable(Mono.CSharp.EmitContext ec, System.Reflection.Emit.Label target, bool on_true) { }
        public override void EmitSideEffect(Mono.CSharp.EmitContext ec) { }
    }
    public sealed partial class EmptyExpressionStatement : Mono.CSharp.ExpressionStatement
    {
        internal EmptyExpressionStatement() { }
        public static readonly Mono.CSharp.EmptyExpressionStatement Instance;
        public override object Accept(Mono.CSharp.StructuralVisitor visitor) { throw null; }
        public override bool ContainsEmitWithAwait() { throw null; }
        public override Mono.CSharp.Expression CreateExpressionTree(Mono.CSharp.ResolveContext ec) { throw null; }
        protected override Mono.CSharp.Expression DoResolve(Mono.CSharp.ResolveContext ec) { throw null; }
        public override void Emit(Mono.CSharp.EmitContext ec) { }
        public override void EmitStatement(Mono.CSharp.EmitContext ec) { }
    }
    public sealed partial class EmptyStatement : Mono.CSharp.Statement
    {
        public EmptyStatement(Mono.CSharp.Location loc) { }
        public override object Accept(Mono.CSharp.StructuralVisitor visitor) { throw null; }
        protected override void CloneTo(Mono.CSharp.CloneContext clonectx, Mono.CSharp.Statement target) { }
        protected override void DoEmit(Mono.CSharp.EmitContext ec) { }
        protected override bool DoFlowAnalysis(Mono.CSharp.FlowAnalysisContext fc) { throw null; }
        public override void Emit(Mono.CSharp.EmitContext ec) { }
        public override bool Resolve(Mono.CSharp.BlockContext ec) { throw null; }
    }
    public partial class Enum : Mono.CSharp.TypeDefinition
    {
        public static readonly string UnderlyingValueField;
        public Enum(Mono.CSharp.TypeContainer parent, Mono.CSharp.FullNamedExpression type, Mono.CSharp.Modifiers mod_flags, Mono.CSharp.MemberName name, Mono.CSharp.Attributes attrs) : base (default(Mono.CSharp.TypeContainer), default(Mono.CSharp.MemberName), default(Mono.CSharp.Attributes), default(Mono.CSharp.MemberKind)) { }
        public override System.AttributeTargets AttributeTargets { get { throw null; } }
        public Mono.CSharp.FullNamedExpression BaseTypeExpression { get { throw null; } }
        protected override System.Reflection.TypeAttributes TypeAttr { get { throw null; } }
        public Mono.CSharp.TypeSpec UnderlyingType { get { throw null; } }
        public override void Accept(Mono.CSharp.StructuralVisitor visitor) { }
        public void AddEnumMember(Mono.CSharp.EnumMember em) { }
        protected override void DoDefineContainer() { }
        protected override bool DoDefineMembers() { throw null; }
        public void Error_UnderlyingType(Mono.CSharp.Location loc) { }
        public override bool IsUnmanagedType() { throw null; }
        protected override Mono.CSharp.TypeSpec[] ResolveBaseTypes(out Mono.CSharp.FullNamedExpression base_class) { base_class = default(Mono.CSharp.FullNamedExpression); throw null; }
        protected override bool VerifyClsCompliance() { throw null; }
    }
    public partial class EnumConstant : Mono.CSharp.Constant
    {
        public Mono.CSharp.Constant Child;
        public EnumConstant(Mono.CSharp.Constant child, Mono.CSharp.TypeSpec enum_type) : base (default(Mono.CSharp.Location)) { }
        protected EnumConstant(Mono.CSharp.Location loc) : base (default(Mono.CSharp.Location)) { }
        public override bool IsDefaultValue { get { throw null; } }
        public override bool IsNegative { get { throw null; } }
        public override bool IsSideEffectFree { get { throw null; } }
        public override bool IsZeroInteger { get { throw null; } }
        public override Mono.CSharp.Constant ConvertExplicitly(bool in_checked_context, Mono.CSharp.TypeSpec target_type) { throw null; }
        public override Mono.CSharp.Constant ConvertImplicitly(Mono.CSharp.TypeSpec type) { throw null; }
        public override void Emit(Mono.CSharp.EmitContext ec) { }
        public override void EmitBranchable(Mono.CSharp.EmitContext ec, System.Reflection.Emit.Label label, bool on_true) { }
        public override void EmitSideEffect(Mono.CSharp.EmitContext ec) { }
        public override void EncodeAttributeValue(Mono.CSharp.IMemberContext rc, Mono.CSharp.AttributeEncoder enc, Mono.CSharp.TypeSpec targetType, Mono.CSharp.TypeSpec parameterType) { }
        public override string GetSignatureForError() { throw null; }
        public override object GetTypedValue() { throw null; }
        public override object GetValue() { throw null; }
        public override string GetValueAsLiteral() { throw null; }
        public override long GetValueAsLong() { throw null; }
        public Mono.CSharp.EnumConstant Increment() { throw null; }
    }
    public partial class EnumMember : Mono.CSharp.Const
    {
        public EnumMember(Mono.CSharp.Enum parent, Mono.CSharp.MemberName name, Mono.CSharp.Attributes attrs) : base (default(Mono.CSharp.TypeDefinition), default(Mono.CSharp.FullNamedExpression), default(Mono.CSharp.Modifiers), default(Mono.CSharp.MemberName), default(Mono.CSharp.Attributes)) { }
        public override void Accept(Mono.CSharp.StructuralVisitor visitor) { }
        public override Mono.CSharp.Constant ConvertInitializer(Mono.CSharp.ResolveContext rc, Mono.CSharp.Constant expr) { throw null; }
        public override bool Define() { throw null; }
    }
    public partial class ErrorExpression : Mono.CSharp.EmptyExpression
    {
        internal ErrorExpression() : base (default(Mono.CSharp.TypeSpec)) { }
        public static readonly Mono.CSharp.ErrorExpression Instance;
        public override object Accept(Mono.CSharp.StructuralVisitor visitor) { throw null; }
        public override Mono.CSharp.Expression CreateExpressionTree(Mono.CSharp.ResolveContext ec) { throw null; }
        public override Mono.CSharp.Expression DoResolveLValue(Mono.CSharp.ResolveContext rc, Mono.CSharp.Expression right_side) { throw null; }
        public override void Error_OperatorCannotBeApplied(Mono.CSharp.ResolveContext rc, Mono.CSharp.Location loc, string oper, Mono.CSharp.TypeSpec t) { }
        public override void Error_UnexpectedKind(Mono.CSharp.ResolveContext ec, Mono.CSharp.ResolveFlags flags, Mono.CSharp.Location loc) { }
        public override void Error_ValueAssignment(Mono.CSharp.ResolveContext rc, Mono.CSharp.Expression rhs) { }
        public override void Error_ValueCannotBeConverted(Mono.CSharp.ResolveContext ec, Mono.CSharp.TypeSpec target, bool expl) { }
    }
    public partial class Evaluator
    {
        public bool DescribeTypeExpressions;
        public bool Terse;
        public Evaluator(Mono.CSharp.CompilerContext ctx) { }
        public System.Type InteractiveBaseClass { get { throw null; } set { } }
        public Mono.CSharp.ValueModificationHandler ModificationListener { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public bool WaitOnTask { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public Mono.CSharp.CompiledMethod Compile(string input) { throw null; }
        public string Compile(string input, out Mono.CSharp.CompiledMethod compiled) { compiled = default(Mono.CSharp.CompiledMethod); throw null; }
        public object Evaluate(string input) { throw null; }
        public string Evaluate(string input, out object result, out bool result_set) { result = default(object); result_set = default(bool); throw null; }
        public string[] GetCompletions(string input, out string prefix) { prefix = default(string); throw null; }
        public string GetUsing() { throw null; }
        public string GetVars() { throw null; }
        public void ImportTypes(bool importExtensionTypes, params System.Type[] types) { }
        public void Interrupt() { }
        public void LoadAssembly(string file) { }
        public void ReferenceAssembly(System.Reflection.Assembly a) { }
        public bool Run(string statement) { throw null; }
    }
    public abstract partial class Event : Mono.CSharp.PropertyBasedMember
    {
        protected Mono.CSharp.EventSpec spec;
        protected Event(Mono.CSharp.TypeDefinition parent, Mono.CSharp.FullNamedExpression type, Mono.CSharp.Modifiers mod_flags, Mono.CSharp.MemberName name, Mono.CSharp.Attributes attrs) : base (default(Mono.CSharp.TypeDefinition), default(Mono.CSharp.FullNamedExpression), default(Mono.CSharp.Modifiers), default(Mono.CSharp.Modifiers), default(Mono.CSharp.MemberName), default(Mono.CSharp.Attributes)) { }
        public Mono.CSharp.Event.AEventAccessor Add { get { throw null; } set { } }
        public override System.AttributeTargets AttributeTargets { get { throw null; } }
        public override string DocCommentHeader { get { throw null; } }
        public override Mono.CSharp.Variance ExpectedMemberTypeVariance { get { throw null; } }
        public Mono.CSharp.Event.AEventAccessor Remove { get { throw null; } set { } }
        public override void ApplyAttributeBuilder(Mono.CSharp.Attribute a, Mono.CSharp.MethodSpec ctor, byte[] cdata, Mono.CSharp.PredefinedAttributes pa) { }
        protected override bool CheckOverrideAgainstBase(Mono.CSharp.MemberSpec base_member) { throw null; }
        public override bool Define() { throw null; }
        public override void Emit() { }
        public override void PrepareEmit() { }
        public override void WriteDebugSymbol(Mono.CompilerServices.SymbolWriter.MonoSymbolFile file) { }
        public abstract partial class AEventAccessor : Mono.CSharp.AbstractPropertyEventMethod
        {
            public const string AddPrefix = "add_";
            protected readonly Mono.CSharp.Event method;
            public const string RemovePrefix = "remove_";
            protected AEventAccessor(Mono.CSharp.Event method, string prefix, Mono.CSharp.Attributes attrs, Mono.CSharp.Location loc) : base (default(Mono.CSharp.InterfaceMemberBase), default(string), default(Mono.CSharp.Attributes), default(Mono.CSharp.Location)) { }
            public override System.AttributeTargets AttributeTargets { get { throw null; } }
            public bool IsInterfaceImplementation { get { throw null; } }
            public Mono.CSharp.MethodData MethodData { get { throw null; } }
            public override Mono.CSharp.ParametersCompiled ParameterInfo { get { throw null; } }
            public override Mono.CSharp.TypeSpec ReturnType { get { throw null; } }
            public override string[] ValidAttributeTargets { get { throw null; } }
            public override void ApplyAttributeBuilder(Mono.CSharp.Attribute a, Mono.CSharp.MethodSpec ctor, byte[] cdata, Mono.CSharp.PredefinedAttributes pa) { }
            protected override void ApplyToExtraTarget(Mono.CSharp.Attribute a, Mono.CSharp.MethodSpec ctor, byte[] cdata, Mono.CSharp.PredefinedAttributes pa) { }
            public virtual void Define(Mono.CSharp.TypeContainer parent) { }
            public override System.ObsoleteAttribute GetAttributeObsolete() { throw null; }
            public override bool IsClsComplianceRequired() { throw null; }
        }
    }
    public partial class EventExpr : Mono.CSharp.MemberExpr, Mono.CSharp.IAssignMethod
    {
        public EventExpr(Mono.CSharp.EventSpec spec, Mono.CSharp.Location loc) { }
        protected override Mono.CSharp.TypeSpec DeclaringType { get { throw null; } }
        public override bool IsInstance { get { throw null; } }
        public override bool IsStatic { get { throw null; } }
        public override string KindName { get { throw null; } }
        public override string Name { get { throw null; } }
        public Mono.CSharp.MethodSpec Operator { get { throw null; } }
        public override Mono.CSharp.Expression CreateExpressionTree(Mono.CSharp.ResolveContext ec) { throw null; }
        protected override Mono.CSharp.Expression DoResolve(Mono.CSharp.ResolveContext ec) { throw null; }
        public override Mono.CSharp.Expression DoResolveLValue(Mono.CSharp.ResolveContext ec, Mono.CSharp.Expression right_side) { throw null; }
        public override void Emit(Mono.CSharp.EmitContext ec) { }
        public void Emit(Mono.CSharp.EmitContext ec, bool leave_copy) { }
        public void EmitAssign(Mono.CSharp.EmitContext ec, Mono.CSharp.Expression source, bool leave_copy, bool isCompound) { }
        protected override void Error_CannotCallAbstractBase(Mono.CSharp.ResolveContext rc, string name) { }
        public override string GetSignatureForError() { throw null; }
        public override Mono.CSharp.MemberExpr ResolveMemberAccess(Mono.CSharp.ResolveContext ec, Mono.CSharp.Expression left, Mono.CSharp.SimpleName original) { throw null; }
        public override void ResolveNameOf(Mono.CSharp.ResolveContext rc, Mono.CSharp.ATypeNameExpression expr) { }
        public override void SetTypeArguments(Mono.CSharp.ResolveContext ec, Mono.CSharp.TypeArguments ta) { }
    }
    public partial class EventField : Mono.CSharp.Event
    {
        public EventField(Mono.CSharp.TypeDefinition parent, Mono.CSharp.FullNamedExpression type, Mono.CSharp.Modifiers mod_flags, Mono.CSharp.MemberName name, Mono.CSharp.Attributes attrs) : base (default(Mono.CSharp.TypeDefinition), default(Mono.CSharp.FullNamedExpression), default(Mono.CSharp.Modifiers), default(Mono.CSharp.MemberName), default(Mono.CSharp.Attributes)) { }
        public System.Collections.Generic.List<Mono.CSharp.FieldDeclarator> Declarators { get { throw null; } }
        public Mono.CSharp.Expression Initializer { get { throw null; } set { } }
        public override string[] ValidAttributeTargets { get { throw null; } }
        public override void Accept(Mono.CSharp.StructuralVisitor visitor) { }
        public void AddDeclarator(Mono.CSharp.FieldDeclarator declarator) { }
        public override void ApplyAttributeBuilder(Mono.CSharp.Attribute a, Mono.CSharp.MethodSpec ctor, byte[] cdata, Mono.CSharp.PredefinedAttributes pa) { }
        public override bool Define() { throw null; }
    }
    public partial class EventProperty : Mono.CSharp.Event
    {
        public EventProperty(Mono.CSharp.TypeDefinition parent, Mono.CSharp.FullNamedExpression type, Mono.CSharp.Modifiers mod_flags, Mono.CSharp.MemberName name, Mono.CSharp.Attributes attrs) : base (default(Mono.CSharp.TypeDefinition), default(Mono.CSharp.FullNamedExpression), default(Mono.CSharp.Modifiers), default(Mono.CSharp.MemberName), default(Mono.CSharp.Attributes)) { }
        public override string[] ValidAttributeTargets { get { throw null; } }
        public override void Accept(Mono.CSharp.StructuralVisitor visitor) { }
        public override bool Define() { throw null; }
        public sealed partial class AddDelegateMethod : Mono.CSharp.EventProperty.AEventPropertyAccessor
        {
            public AddDelegateMethod(Mono.CSharp.EventProperty method, Mono.CSharp.Attributes attrs, Mono.CSharp.Location loc) : base (default(Mono.CSharp.EventProperty), default(string), default(Mono.CSharp.Attributes), default(Mono.CSharp.Location)) { }
        }
        public abstract partial class AEventPropertyAccessor : Mono.CSharp.Event.AEventAccessor
        {
            protected AEventPropertyAccessor(Mono.CSharp.EventProperty method, string prefix, Mono.CSharp.Attributes attrs, Mono.CSharp.Location loc) : base (default(Mono.CSharp.Event), default(string), default(Mono.CSharp.Attributes), default(Mono.CSharp.Location)) { }
            public override void Define(Mono.CSharp.TypeContainer ds) { }
            public override string GetSignatureForError() { throw null; }
        }
        public sealed partial class RemoveDelegateMethod : Mono.CSharp.EventProperty.AEventPropertyAccessor
        {
            public RemoveDelegateMethod(Mono.CSharp.EventProperty method, Mono.CSharp.Attributes attrs, Mono.CSharp.Location loc) : base (default(Mono.CSharp.EventProperty), default(string), default(Mono.CSharp.Attributes), default(Mono.CSharp.Location)) { }
        }
    }
    public partial class EventSpec : Mono.CSharp.MemberSpec, Mono.CSharp.IInterfaceMemberSpec
    {
        public EventSpec(Mono.CSharp.TypeSpec declaringType, Mono.CSharp.IMemberDefinition definition, Mono.CSharp.TypeSpec eventType, Mono.CSharp.Modifiers modifiers, Mono.CSharp.MethodSpec add, Mono.CSharp.MethodSpec remove) : base (default(Mono.CSharp.MemberKind), default(Mono.CSharp.TypeSpec), default(Mono.CSharp.IMemberDefinition), default(Mono.CSharp.Modifiers)) { }
        public Mono.CSharp.MethodSpec AccessorAdd { get { throw null; } set { } }
        public Mono.CSharp.MethodSpec AccessorRemove { get { throw null; } set { } }
        public Mono.CSharp.FieldSpec BackingField { get { throw null; } set { } }
        public Mono.CSharp.TypeSpec MemberType { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        public override Mono.CSharp.MemberSpec InflateMember(Mono.CSharp.TypeParameterInflator inflator) { throw null; }
        public override System.Collections.Generic.List<Mono.CSharp.MissingTypeSpecReference> ResolveMissingDependencies(Mono.CSharp.MemberSpec caller) { throw null; }
    }
    public abstract partial class ExceptionStatement : Mono.CSharp.ResumableStatement
    {
        protected int first_catch_resume_pc;
        protected int first_resume_pc;
        protected Mono.CSharp.ExceptionStatement parent_try_block;
        protected System.Collections.Generic.List<Mono.CSharp.ResumableStatement> resume_points;
        protected ExceptionStatement(Mono.CSharp.Location loc) { }
        public int AddResumePoint(Mono.CSharp.ResumableStatement stmt, int pc, Mono.CSharp.StateMachineInitializer stateMachine, Mono.CSharp.TryCatch catchBlock) { throw null; }
        protected virtual void EmitTryBodyPrepare(Mono.CSharp.EmitContext ec) { }
    }
    public abstract partial class ExitStatement : Mono.CSharp.Statement
    {
        protected bool unwind_protect;
        protected ExitStatement() { }
        protected abstract bool IsLocalExit { get; }
        protected override bool DoFlowAnalysis(Mono.CSharp.FlowAnalysisContext fc) { throw null; }
        protected abstract bool DoResolve(Mono.CSharp.BlockContext bc);
        public override bool Resolve(Mono.CSharp.BlockContext bc) { throw null; }
    }
    public partial class ExplicitBlock : Mono.CSharp.Block
    {
        protected Mono.CSharp.AnonymousMethodStorey am_storey;
        public ExplicitBlock(Mono.CSharp.Block parent, Mono.CSharp.Block.Flags flags, Mono.CSharp.Location start, Mono.CSharp.Location end) : base (default(Mono.CSharp.Block), default(Mono.CSharp.Location), default(Mono.CSharp.Location)) { }
        public ExplicitBlock(Mono.CSharp.Block parent, Mono.CSharp.Location start, Mono.CSharp.Location end) : base (default(Mono.CSharp.Block), default(Mono.CSharp.Location), default(Mono.CSharp.Location)) { }
        public Mono.CSharp.AnonymousMethodStorey AnonymousMethodStorey { get { throw null; } }
        public bool HasAwait { get { throw null; } }
        public bool HasCapturedThis { get { throw null; } set { } }
        public bool HasCapturedVariable { get { throw null; } set { } }
        public bool HasReachableClosingBrace { get { throw null; } set { } }
        public bool HasYield { get { throw null; } }
        public Mono.CSharp.AnonymousMethodStorey CreateAnonymousMethodStorey(Mono.CSharp.ResolveContext ec) { throw null; }
        protected void DefineStoreyContainer(Mono.CSharp.EmitContext ec, Mono.CSharp.AnonymousMethodStorey storey) { }
        public void DisableDebugScopeIndex() { }
        public override void Emit(Mono.CSharp.EmitContext ec) { }
        public void EmitScopeInitialization(Mono.CSharp.EmitContext ec) { }
        public virtual int GetDebugSymbolScopeIndex() { throw null; }
        public void RegisterAsyncAwait() { }
        public void RegisterIteratorYield() { }
        public void SetCatchBlock() { }
        public void SetFinallyBlock() { }
        public void WrapIntoDestructor(Mono.CSharp.TryFinally tf, Mono.CSharp.ExplicitBlock tryBlock) { }
    }
    public enum ExprClass : byte
    {
        EventAccess = (byte)8,
        IndexerAccess = (byte)9,
        MethodGroup = (byte)6,
        Namespace = (byte)3,
        Nothing = (byte)10,
        PropertyAccess = (byte)7,
        Type = (byte)4,
        TypeParameter = (byte)5,
        Unresolved = (byte)0,
        Value = (byte)1,
        Variable = (byte)2,
    }
    public abstract partial class Expression
    {
        public Mono.CSharp.ExprClass eclass;
        protected Mono.CSharp.Location loc;
        protected Mono.CSharp.TypeSpec type;
        protected Expression() { }
        public virtual string ExprClassName { get { throw null; } }
        public Mono.CSharp.ResolveFlags ExprClassToResolveFlags { get { throw null; } }
        public virtual bool IsNull { get { throw null; } }
        public virtual bool IsSideEffectFree { get { throw null; } }
        public Mono.CSharp.Location Location { get { throw null; } }
        public virtual Mono.CSharp.Location StartLocation { get { throw null; } }
        public Mono.CSharp.TypeSpec Type { get { throw null; } set { } }
        public virtual object Accept(Mono.CSharp.StructuralVisitor visitor) { throw null; }
        public virtual Mono.CSharp.MethodGroupExpr CanReduceLambda(Mono.CSharp.AnonymousMethodBody body) { throw null; }
        protected void CheckExpressionVariable(Mono.CSharp.ResolveContext rc) { }
        public virtual Mono.CSharp.Expression Clone(Mono.CSharp.CloneContext clonectx) { throw null; }
        protected virtual void CloneTo(Mono.CSharp.CloneContext clonectx, Mono.CSharp.Expression target) { }
        public static Mono.CSharp.MethodSpec ConstructorLookup(Mono.CSharp.ResolveContext rc, Mono.CSharp.TypeSpec type, ref Mono.CSharp.Arguments args, Mono.CSharp.Location loc) { throw null; }
        public virtual bool ContainsEmitWithAwait() { throw null; }
        protected Mono.CSharp.Expression ConvertExpressionToArrayIndex(Mono.CSharp.ResolveContext ec, Mono.CSharp.Expression source, bool pointerArray=false) { throw null; }
        protected Mono.CSharp.Expression CreateExpressionFactoryCall(Mono.CSharp.ResolveContext ec, string name, Mono.CSharp.Arguments args) { throw null; }
        protected Mono.CSharp.Expression CreateExpressionFactoryCall(Mono.CSharp.ResolveContext ec, string name, Mono.CSharp.TypeArguments typeArguments, Mono.CSharp.Arguments args) { throw null; }
        public static Mono.CSharp.Expression CreateExpressionFactoryCall(Mono.CSharp.ResolveContext ec, string name, Mono.CSharp.TypeArguments typeArguments, Mono.CSharp.Arguments args, Mono.CSharp.Location loc) { throw null; }
        public abstract Mono.CSharp.Expression CreateExpressionTree(Mono.CSharp.ResolveContext ec);
        protected static Mono.CSharp.TypeExpr CreateExpressionTypeExpression(Mono.CSharp.ResolveContext ec, Mono.CSharp.Location loc) { throw null; }
        protected abstract Mono.CSharp.Expression DoResolve(Mono.CSharp.ResolveContext rc);
        public virtual Mono.CSharp.Expression DoResolveLValue(Mono.CSharp.ResolveContext rc, Mono.CSharp.Expression right_side) { throw null; }
        public abstract void Emit(Mono.CSharp.EmitContext ec);
        public virtual void EmitBranchable(Mono.CSharp.EmitContext ec, System.Reflection.Emit.Label target, bool on_true) { }
        protected static void EmitExpressionsList(Mono.CSharp.EmitContext ec, System.Collections.Generic.List<Mono.CSharp.Expression> expressions) { }
        public virtual void EmitPrepare(Mono.CSharp.EmitContext ec) { }
        public virtual void EmitSideEffect(Mono.CSharp.EmitContext ec) { }
        public virtual Mono.CSharp.Expression EmitToField(Mono.CSharp.EmitContext ec) { throw null; }
        protected virtual Mono.CSharp.FieldExpr EmitToFieldSource(Mono.CSharp.EmitContext ec) { throw null; }
        public virtual void EncodeAttributeValue(Mono.CSharp.IMemberContext rc, Mono.CSharp.AttributeEncoder enc, Mono.CSharp.TypeSpec targetType, Mono.CSharp.TypeSpec parameterType) { }
        public static void ErrorIsInaccesible(Mono.CSharp.IMemberContext rc, string member, Mono.CSharp.Location loc) { }
        public void Error_ConstantCanBeInitializedWithNullOnly(Mono.CSharp.ResolveContext rc, Mono.CSharp.TypeSpec type, Mono.CSharp.Location loc, string name) { }
        public void Error_ExpressionMustBeConstant(Mono.CSharp.ResolveContext rc, Mono.CSharp.Location loc, string e_name) { }
        public void Error_InvalidExpressionStatement(Mono.CSharp.BlockContext bc) { }
        public void Error_InvalidExpressionStatement(Mono.CSharp.Report report) { }
        protected virtual void Error_InvalidExpressionStatement(Mono.CSharp.Report report, Mono.CSharp.Location loc) { }
        protected static void Error_NamedArgument(Mono.CSharp.NamedArgument na, Mono.CSharp.Report Report) { }
        protected virtual void Error_NegativeArrayIndex(Mono.CSharp.ResolveContext ec, Mono.CSharp.Location loc) { }
        protected void Error_NullPropagatingLValue(Mono.CSharp.ResolveContext rc) { }
        protected void Error_NullShortCircuitInsideExpressionTree(Mono.CSharp.ResolveContext rc) { }
        public virtual void Error_OperatorCannotBeApplied(Mono.CSharp.ResolveContext rc, Mono.CSharp.Location loc, string oper, Mono.CSharp.TypeSpec t) { }
        protected void Error_PointerInsideExpressionTree(Mono.CSharp.ResolveContext ec) { }
        public void Error_TypeArgumentsCannotBeUsed(Mono.CSharp.IMemberContext context, Mono.CSharp.MemberSpec member, Mono.CSharp.Location loc) { }
        public static void Error_TypeArgumentsCannotBeUsed(Mono.CSharp.IMemberContext context, string exprType, string name, Mono.CSharp.Location loc) { }
        public static void Error_TypeDoesNotContainDefinition(Mono.CSharp.ResolveContext ec, Mono.CSharp.Location loc, Mono.CSharp.TypeSpec type, string name) { }
        public virtual void Error_TypeDoesNotContainDefinition(Mono.CSharp.ResolveContext ec, Mono.CSharp.TypeSpec type, string name) { }
        public static void Error_UnexpectedKind(Mono.CSharp.IMemberContext ctx, Mono.CSharp.Expression memberExpr, string expected, string was, Mono.CSharp.Location loc) { }
        public virtual void Error_UnexpectedKind(Mono.CSharp.ResolveContext ec, Mono.CSharp.ResolveFlags flags, Mono.CSharp.Location loc) { }
        public virtual void Error_ValueAssignment(Mono.CSharp.ResolveContext rc, Mono.CSharp.Expression rhs) { }
        public virtual void Error_ValueCannotBeConverted(Mono.CSharp.ResolveContext ec, Mono.CSharp.TypeSpec target, bool expl) { }
        protected void Error_ValueCannotBeConvertedCore(Mono.CSharp.ResolveContext ec, Mono.CSharp.Location loc, Mono.CSharp.TypeSpec target, bool expl) { }
        public static void Error_VoidInvalidInTheContext(Mono.CSharp.Location loc, Mono.CSharp.Report Report) { }
        protected void Error_VoidPointerOperation(Mono.CSharp.ResolveContext rc) { }
        public virtual void FlowAnalysis(Mono.CSharp.FlowAnalysisContext fc) { }
        public virtual void FlowAnalysisConditional(Mono.CSharp.FlowAnalysisContext fc) { }
        protected static Mono.CSharp.Expression GetOperatorFalse(Mono.CSharp.ResolveContext ec, Mono.CSharp.Expression e, Mono.CSharp.Location loc) { throw null; }
        protected static Mono.CSharp.Expression GetOperatorTrue(Mono.CSharp.ResolveContext ec, Mono.CSharp.Expression e, Mono.CSharp.Location loc) { throw null; }
        public virtual string GetSignatureForError() { throw null; }
        public virtual bool HasConditionalAccess() { throw null; }
        public static bool IsNeverNull(Mono.CSharp.Expression expr) { throw null; }
        protected static bool IsNullPropagatingValid(Mono.CSharp.TypeSpec type) { throw null; }
        protected Mono.CSharp.TypeSpec LiftMemberType(Mono.CSharp.ResolveContext rc, Mono.CSharp.TypeSpec type) { throw null; }
        public virtual System.Linq.Expressions.Expression MakeExpression(Mono.CSharp.BuilderContext ctx) { throw null; }
        public Mono.CSharp.Expression MakePointerAccess(Mono.CSharp.ResolveContext rc, Mono.CSharp.TypeSpec type, Mono.CSharp.Arguments args) { throw null; }
        public virtual Mono.CSharp.Reachability MarkReachable(Mono.CSharp.Reachability rc) { throw null; }
        public static Mono.CSharp.Expression MemberLookup(Mono.CSharp.IMemberContext rc, bool errorMode, Mono.CSharp.TypeSpec queried_type, string name, int arity, Mono.CSharp.Expression.MemberLookupRestrictions restrictions, Mono.CSharp.Location loc) { throw null; }
        public static Mono.CSharp.Expression MemberLookupToExpression(Mono.CSharp.IMemberContext rc, System.Collections.Generic.IList<Mono.CSharp.MemberSpec> members, bool errorMode, Mono.CSharp.TypeSpec queried_type, string name, int arity, Mono.CSharp.Expression.MemberLookupRestrictions restrictions, Mono.CSharp.Location loc) { throw null; }
        public Mono.CSharp.Expression ProbeIdenticalTypeName(Mono.CSharp.ResolveContext rc, Mono.CSharp.Expression left, Mono.CSharp.SimpleName name) { throw null; }
        public Mono.CSharp.Expression Resolve(Mono.CSharp.ResolveContext rc) { throw null; }
        public Mono.CSharp.Expression Resolve(Mono.CSharp.ResolveContext ec, Mono.CSharp.ResolveFlags flags) { throw null; }
        public virtual Mono.CSharp.TypeSpec ResolveAsType(Mono.CSharp.IMemberContext mc, bool allowUnboundTypeArguments=false) { throw null; }
        public Mono.CSharp.Constant ResolveLabelConstant(Mono.CSharp.ResolveContext rc) { throw null; }
        public Mono.CSharp.Expression ResolveLValue(Mono.CSharp.ResolveContext ec, Mono.CSharp.Expression right_side) { throw null; }
        public static void UnsafeError(Mono.CSharp.Report Report, Mono.CSharp.Location loc) { }
        public static void UnsafeError(Mono.CSharp.ResolveContext ec, Mono.CSharp.Location loc) { }
        public static void UnsafeInsideIteratorError(Mono.CSharp.Report report, Mono.CSharp.Location loc) { }
        public static void UnsafeInsideIteratorError(Mono.CSharp.ResolveContext rc, Mono.CSharp.Location loc) { }
        public static void Warning_UnreachableExpression(Mono.CSharp.ResolveContext rc, Mono.CSharp.Location loc) { }
        [System.FlagsAttribute]
        public enum MemberLookupRestrictions
        {
            DontSetConditionalAccess = 256,
            EmptyArguments = 16,
            ExactArity = 4,
            IgnoreAmbiguity = 64,
            IgnoreArity = 32,
            InvocableOnly = 1,
            NameOfExcluded = 128,
            None = 0,
            ReadAccess = 8,
        }
    }
    public abstract partial class ExpressionStatement : Mono.CSharp.Expression
    {
        protected ExpressionStatement() { }
        public override void EmitSideEffect(Mono.CSharp.EmitContext ec) { }
        public abstract void EmitStatement(Mono.CSharp.EmitContext ec);
        public virtual Mono.CSharp.ExpressionStatement ResolveStatement(Mono.CSharp.BlockContext ec) { throw null; }
    }
    public partial class ExtensionMethodCandidates
    {
        public ExtensionMethodCandidates(Mono.CSharp.IMemberContext context, System.Collections.Generic.IList<Mono.CSharp.MethodSpec> methods, Mono.CSharp.NamespaceContainer nsContainer, int lookupIndex) { }
        public Mono.CSharp.NamespaceContainer Container { get { throw null; } }
        public Mono.CSharp.IMemberContext Context { get { throw null; } }
        public int LookupIndex { get { throw null; } }
        public System.Collections.Generic.IList<Mono.CSharp.MethodSpec> Methods { get { throw null; } }
    }
    public partial class Field : Mono.CSharp.FieldBase
    {
        public Field(Mono.CSharp.TypeDefinition parent, Mono.CSharp.FullNamedExpression type, Mono.CSharp.Modifiers mod, Mono.CSharp.MemberName name, Mono.CSharp.Attributes attrs) : base (default(Mono.CSharp.TypeDefinition), default(Mono.CSharp.FullNamedExpression), default(Mono.CSharp.Modifiers), default(Mono.CSharp.Modifiers), default(Mono.CSharp.MemberName), default(Mono.CSharp.Attributes)) { }
        public override void Accept(Mono.CSharp.StructuralVisitor visitor) { }
        public override bool Define() { throw null; }
        protected override void DoMemberTypeDependentChecks() { }
        protected override bool VerifyClsCompliance() { throw null; }
    }
    public abstract partial class FieldBase : Mono.CSharp.MemberBase
    {
        protected System.Collections.Generic.List<Mono.CSharp.FieldDeclarator> declarators;
        protected System.Reflection.Emit.FieldBuilder FieldBuilder;
        protected Mono.CSharp.Expression initializer;
        protected Mono.CSharp.FieldSpec spec;
        public Mono.CSharp.FieldBase.Status status;
        protected FieldBase(Mono.CSharp.TypeDefinition parent, Mono.CSharp.FullNamedExpression type, Mono.CSharp.Modifiers mod, Mono.CSharp.Modifiers allowed_mod, Mono.CSharp.MemberName name, Mono.CSharp.Attributes attrs) : base (default(Mono.CSharp.TypeDefinition), default(Mono.CSharp.FullNamedExpression), default(Mono.CSharp.Modifiers), default(Mono.CSharp.Modifiers), default(Mono.CSharp.Modifiers), default(Mono.CSharp.MemberName), default(Mono.CSharp.Attributes)) { }
        public override System.AttributeTargets AttributeTargets { get { throw null; } }
        public System.Collections.Generic.List<Mono.CSharp.FieldDeclarator> Declarators { get { throw null; } }
        public override string DocCommentHeader { get { throw null; } }
        public Mono.CSharp.Expression Initializer { get { throw null; } set { } }
        public string Name { get { throw null; } }
        public Mono.CSharp.FieldSpec Spec { get { throw null; } }
        public override string[] ValidAttributeTargets { get { throw null; } }
        public void AddDeclarator(Mono.CSharp.FieldDeclarator declarator) { }
        public override void ApplyAttributeBuilder(Mono.CSharp.Attribute a, Mono.CSharp.MethodSpec ctor, byte[] cdata, Mono.CSharp.PredefinedAttributes pa) { }
        protected override bool CheckBase() { throw null; }
        public virtual Mono.CSharp.Constant ConvertInitializer(Mono.CSharp.ResolveContext rc, Mono.CSharp.Constant expr) { throw null; }
        protected override void DoMemberTypeDependentChecks() { }
        public override void Emit() { }
        public static void Error_VariableOfStaticClass(Mono.CSharp.Location loc, string variable_name, Mono.CSharp.TypeSpec static_class, Mono.CSharp.Report Report) { }
        public void SetCustomAttribute(Mono.CSharp.MethodSpec ctor, byte[] data) { }
        protected override bool VerifyClsCompliance() { throw null; }
        [System.FlagsAttribute]
        public enum Status : byte
        {
            HAS_OFFSET = (byte)4,
        }
    }
    public partial class FieldDeclarator
    {
        public FieldDeclarator(Mono.CSharp.SimpleMemberName name, Mono.CSharp.Expression initializer) { }
        public Mono.CSharp.Expression Initializer { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        public Mono.CSharp.SimpleMemberName Name { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        public virtual Mono.CSharp.FullNamedExpression GetFieldTypeExpression(Mono.CSharp.FieldBase field) { throw null; }
    }
    public partial class FieldExpr : Mono.CSharp.MemberExpr, Mono.CSharp.IAssignMethod, Mono.CSharp.IFixedExpression, Mono.CSharp.IMemoryLocation, Mono.CSharp.IVariableReference
    {
        protected Mono.CSharp.FieldSpec spec;
        public FieldExpr(Mono.CSharp.FieldBase fi, Mono.CSharp.Location l) { }
        public FieldExpr(Mono.CSharp.FieldSpec spec, Mono.CSharp.Location loc) { }
        protected FieldExpr(Mono.CSharp.Location l) { }
        protected override Mono.CSharp.TypeSpec DeclaringType { get { throw null; } }
        public bool IsFixed { get { throw null; } }
        public bool IsHoisted { get { throw null; } }
        public override bool IsInstance { get { throw null; } }
        public override bool IsStatic { get { throw null; } }
        public override string KindName { get { throw null; } }
        public override string Name { get { throw null; } }
        public Mono.CSharp.FieldSpec Spec { get { throw null; } }
        public Mono.CSharp.VariableInfo VariableInfo { get { throw null; } }
        public virtual void AddressOf(Mono.CSharp.EmitContext ec, Mono.CSharp.AddressOp mode) { }
        protected override void CloneTo(Mono.CSharp.CloneContext clonectx, Mono.CSharp.Expression target) { }
        public override Mono.CSharp.Expression CreateExpressionTree(Mono.CSharp.ResolveContext ec) { throw null; }
        public Mono.CSharp.Expression CreateExpressionTree(Mono.CSharp.ResolveContext ec, bool convertInstance) { throw null; }
        public Mono.CSharp.Expression CreateTypeOfExpression() { throw null; }
        protected override Mono.CSharp.Expression DoResolve(Mono.CSharp.ResolveContext ec) { throw null; }
        public override Mono.CSharp.Expression DoResolveLValue(Mono.CSharp.ResolveContext ec, Mono.CSharp.Expression right_side) { throw null; }
        public override void Emit(Mono.CSharp.EmitContext ec) { }
        public void Emit(Mono.CSharp.EmitContext ec, bool leave_copy) { }
        public void EmitAssign(Mono.CSharp.EmitContext ec, Mono.CSharp.Expression source, bool leave_copy, bool isCompound) { }
        public void EmitAssignFromStack(Mono.CSharp.EmitContext ec) { }
        public override void EmitSideEffect(Mono.CSharp.EmitContext ec) { }
        public override bool Equals(object obj) { throw null; }
        public override void FlowAnalysis(Mono.CSharp.FlowAnalysisContext fc) { }
        public override int GetHashCode() { throw null; }
        public override string GetSignatureForError() { throw null; }
        public bool IsMarshalByRefAccess(Mono.CSharp.ResolveContext rc) { throw null; }
        public System.Linq.Expressions.Expression MakeAssignExpression(Mono.CSharp.BuilderContext ctx, Mono.CSharp.Expression source) { throw null; }
        public override System.Linq.Expressions.Expression MakeExpression(Mono.CSharp.BuilderContext ctx) { throw null; }
        public override void ResolveNameOf(Mono.CSharp.ResolveContext rc, Mono.CSharp.ATypeNameExpression expr) { }
        public void SetFieldAssigned(Mono.CSharp.FlowAnalysisContext fc) { }
        public void SetHasAddressTaken() { }
        public override void SetTypeArguments(Mono.CSharp.ResolveContext ec, Mono.CSharp.TypeArguments ta) { }
    }
    public partial class FieldInitializer : Mono.CSharp.Assign
    {
        public FieldInitializer(Mono.CSharp.FieldBase mc, Mono.CSharp.Expression expression, Mono.CSharp.Location loc) : base (default(Mono.CSharp.Expression), default(Mono.CSharp.Expression), default(Mono.CSharp.Location)) { }
        public int AssignmentOffset { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        public Mono.CSharp.FieldBase Field { get { throw null; } }
        public bool IsDefaultInitializer { get { throw null; } }
        public override bool IsSideEffectFree { get { throw null; } }
        public override Mono.CSharp.Location StartLocation { get { throw null; } }
        protected override Mono.CSharp.Expression DoResolve(Mono.CSharp.ResolveContext rc) { throw null; }
        public override void EmitStatement(Mono.CSharp.EmitContext ec) { }
        public override void FlowAnalysis(Mono.CSharp.FlowAnalysisContext fc) { }
    }
    public partial class FieldSpec : Mono.CSharp.MemberSpec, Mono.CSharp.IInterfaceMemberSpec
    {
        public FieldSpec(Mono.CSharp.TypeSpec declaringType, Mono.CSharp.IMemberDefinition definition, Mono.CSharp.TypeSpec memberType, System.Reflection.FieldInfo info, Mono.CSharp.Modifiers modifiers) : base (default(Mono.CSharp.MemberKind), default(Mono.CSharp.TypeSpec), default(Mono.CSharp.IMemberDefinition), default(Mono.CSharp.Modifiers)) { }
        public bool IsReadOnly { get { throw null; } }
        public Mono.CSharp.TypeSpec MemberType { get { throw null; } }
        public System.Reflection.FieldInfo GetMetaInfo() { throw null; }
        public override Mono.CSharp.MemberSpec InflateMember(Mono.CSharp.TypeParameterInflator inflator) { throw null; }
        public Mono.CSharp.FieldSpec Mutate(Mono.CSharp.TypeParameterMutator mutator) { throw null; }
        public override System.Collections.Generic.List<Mono.CSharp.MissingTypeSpecReference> ResolveMissingDependencies(Mono.CSharp.MemberSpec caller) { throw null; }
    }
    public partial class Fixed : Mono.CSharp.Statement
    {
        public Fixed(Mono.CSharp.Fixed.VariableDeclaration decl, Mono.CSharp.Statement stmt, Mono.CSharp.Location l) { }
        public Mono.CSharp.Statement Statement { get { throw null; } }
        public Mono.CSharp.BlockVariable Variables { get { throw null; } }
        public override object Accept(Mono.CSharp.StructuralVisitor visitor) { throw null; }
        protected override void CloneTo(Mono.CSharp.CloneContext clonectx, Mono.CSharp.Statement t) { }
        protected override void DoEmit(Mono.CSharp.EmitContext ec) { }
        protected override bool DoFlowAnalysis(Mono.CSharp.FlowAnalysisContext fc) { throw null; }
        public override Mono.CSharp.Reachability MarkReachable(Mono.CSharp.Reachability rc) { throw null; }
        public override bool Resolve(Mono.CSharp.BlockContext bc) { throw null; }
        public partial class VariableDeclaration : Mono.CSharp.BlockVariable
        {
            public VariableDeclaration(Mono.CSharp.FullNamedExpression type, Mono.CSharp.LocalVariable li) : base (default(Mono.CSharp.FullNamedExpression), default(Mono.CSharp.LocalVariable)) { }
            protected override Mono.CSharp.Expression ResolveInitializer(Mono.CSharp.BlockContext bc, Mono.CSharp.LocalVariable li, Mono.CSharp.Expression initializer) { throw null; }
        }
    }
    public partial class FixedField : Mono.CSharp.FieldBase
    {
        public const string FixedElementName = "FixedElementField";
        public FixedField(Mono.CSharp.TypeDefinition parent, Mono.CSharp.FullNamedExpression type, Mono.CSharp.Modifiers mod, Mono.CSharp.MemberName name, Mono.CSharp.Attributes attrs) : base (default(Mono.CSharp.TypeDefinition), default(Mono.CSharp.FullNamedExpression), default(Mono.CSharp.Modifiers), default(Mono.CSharp.Modifiers), default(Mono.CSharp.MemberName), default(Mono.CSharp.Attributes)) { }
        public System.Nullable<System.Runtime.InteropServices.CharSet> CharSetValue { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public override Mono.CSharp.Constant ConvertInitializer(Mono.CSharp.ResolveContext rc, Mono.CSharp.Constant expr) { throw null; }
        public override bool Define() { throw null; }
        protected override void DoMemberTypeIndependentChecks() { }
        public override void Emit() { }
    }
    public partial class FloatConstant : Mono.CSharp.Constant
    {
        public readonly double DoubleValue;
        public FloatConstant(Mono.CSharp.BuiltinTypes types, double v, Mono.CSharp.Location loc) : base (default(Mono.CSharp.Location)) { }
        public FloatConstant(Mono.CSharp.TypeSpec type, double v, Mono.CSharp.Location loc) : base (default(Mono.CSharp.Location)) { }
        public override bool IsDefaultValue { get { throw null; } }
        public override bool IsNegative { get { throw null; } }
        public float Value { get { throw null; } }
        public override Mono.CSharp.Constant ConvertExplicitly(bool in_checked_context, Mono.CSharp.TypeSpec target_type) { throw null; }
        public override Mono.CSharp.Constant ConvertImplicitly(Mono.CSharp.TypeSpec type) { throw null; }
        public override void Emit(Mono.CSharp.EmitContext ec) { }
        public override void EncodeAttributeValue(Mono.CSharp.IMemberContext rc, Mono.CSharp.AttributeEncoder enc, Mono.CSharp.TypeSpec targetType, Mono.CSharp.TypeSpec parameterType) { }
        public override object GetValue() { throw null; }
        public override string GetValueAsLiteral() { throw null; }
        public override long GetValueAsLong() { throw null; }
    }
    public partial class FloatLiteral : Mono.CSharp.FloatConstant, Mono.CSharp.ILiteralConstant
    {
        public FloatLiteral(Mono.CSharp.BuiltinTypes types, float f, Mono.CSharp.Location loc) : base (default(Mono.CSharp.BuiltinTypes), default(double), default(Mono.CSharp.Location)) { }
        public override bool IsLiteral { get { throw null; } }
        public override object Accept(Mono.CSharp.StructuralVisitor visitor) { throw null; }
    }
    public partial class FlowAnalysisContext
    {
        public FlowAnalysisContext(Mono.CSharp.CompilerContext ctx, Mono.CSharp.ParametersBlock parametersBlock, int definiteAssignmentLength) { }
        public Mono.CSharp.DefiniteAssignmentBitSet DefiniteAssignment { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public Mono.CSharp.DefiniteAssignmentBitSet DefiniteAssignmentOnFalse { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public Mono.CSharp.DefiniteAssignmentBitSet DefiniteAssignmentOnTrue { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public Mono.CSharp.ParametersBlock ParametersBlock { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public Mono.CSharp.Report Report { get { throw null; } }
        public Mono.CSharp.DefiniteAssignmentBitSet SwitchInitialDefinitiveAssignment { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public Mono.CSharp.TryFinally TryFinally { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public bool UnreachableReported { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public bool AddReachedLabel(Mono.CSharp.Statement label) { throw null; }
        public Mono.CSharp.DefiniteAssignmentBitSet BranchDefiniteAssignment() { throw null; }
        public Mono.CSharp.DefiniteAssignmentBitSet BranchDefiniteAssignment(Mono.CSharp.DefiniteAssignmentBitSet da) { throw null; }
        public System.Collections.Generic.Dictionary<Mono.CSharp.Statement, System.Collections.Generic.List<Mono.CSharp.DefiniteAssignmentBitSet>> CopyLabelStack() { throw null; }
        public bool IsDefinitelyAssigned(Mono.CSharp.VariableInfo variable) { throw null; }
        public bool IsStructFieldDefinitelyAssigned(Mono.CSharp.VariableInfo variable, string name) { throw null; }
        public void SetLabelStack(System.Collections.Generic.Dictionary<Mono.CSharp.Statement, System.Collections.Generic.List<Mono.CSharp.DefiniteAssignmentBitSet>> labelStack) { }
        public void SetStructFieldAssigned(Mono.CSharp.VariableInfo variable, string name) { }
        public void SetVariableAssigned(Mono.CSharp.VariableInfo variable, Mono.CSharp.DefiniteAssignmentBitSet da) { }
        public void SetVariableAssigned(Mono.CSharp.VariableInfo variable, bool generatedAssignment=false) { }
    }
    public partial class For : Mono.CSharp.LoopStatement
    {
        public For(Mono.CSharp.Location l) : base (default(Mono.CSharp.Statement)) { }
        public Mono.CSharp.Expression Condition { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public Mono.CSharp.Statement Initializer { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public Mono.CSharp.Statement Iterator { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public override object Accept(Mono.CSharp.StructuralVisitor visitor) { throw null; }
        public override void AddEndDefiniteAssignment(Mono.CSharp.FlowAnalysisContext fc) { }
        protected override void CloneTo(Mono.CSharp.CloneContext clonectx, Mono.CSharp.Statement t) { }
        protected override void DoEmit(Mono.CSharp.EmitContext ec) { }
        protected override bool DoFlowAnalysis(Mono.CSharp.FlowAnalysisContext fc) { throw null; }
        public override Mono.CSharp.Reachability MarkReachable(Mono.CSharp.Reachability rc) { throw null; }
        public override bool Resolve(Mono.CSharp.BlockContext bc) { throw null; }
        public override void SetEndReachable() { }
        public override void SetIteratorReachable() { }
    }
    public partial class Foreach : Mono.CSharp.LoopStatement
    {
        public Foreach(Mono.CSharp.Expression type, Mono.CSharp.LocalVariable var, Mono.CSharp.Expression expr, Mono.CSharp.Statement stmt, Mono.CSharp.Block body, Mono.CSharp.Location l) : base (default(Mono.CSharp.Statement)) { }
        public Mono.CSharp.Expression Expr { get { throw null; } }
        public Mono.CSharp.Expression TypeExpression { get { throw null; } }
        public Mono.CSharp.LocalVariable Variable { get { throw null; } }
        public override object Accept(Mono.CSharp.StructuralVisitor visitor) { throw null; }
        protected override void CloneTo(Mono.CSharp.CloneContext clonectx, Mono.CSharp.Statement t) { }
        protected override void DoEmit(Mono.CSharp.EmitContext ec) { }
        protected override bool DoFlowAnalysis(Mono.CSharp.FlowAnalysisContext fc) { throw null; }
        public override Mono.CSharp.Reachability MarkReachable(Mono.CSharp.Reachability rc) { throw null; }
        public override bool Resolve(Mono.CSharp.BlockContext ec) { throw null; }
    }
    public abstract partial class FullNamedExpression : Mono.CSharp.Expression
    {
        protected FullNamedExpression() { }
        protected override void CloneTo(Mono.CSharp.CloneContext clonectx, Mono.CSharp.Expression target) { }
        public override bool ContainsEmitWithAwait() { throw null; }
        public override Mono.CSharp.Expression CreateExpressionTree(Mono.CSharp.ResolveContext ec) { throw null; }
        public override void Emit(Mono.CSharp.EmitContext ec) { }
        public override Mono.CSharp.TypeSpec ResolveAsType(Mono.CSharp.IMemberContext mc, bool allowUnboundTypeArguments=false) { throw null; }
        public abstract Mono.CSharp.FullNamedExpression ResolveAsTypeOrNamespace(Mono.CSharp.IMemberContext mc, bool allowUnboundTypeArguments);
    }
    public sealed partial class GlobalRootNamespace : Mono.CSharp.RootNamespace
    {
        public GlobalRootNamespace() : base (default(string)) { }
    }
    public partial class Goto : Mono.CSharp.ExitStatement
    {
        public Goto(string label, Mono.CSharp.Location l) { }
        protected override bool IsLocalExit { get { throw null; } }
        public string Target { get { throw null; } }
        public override object Accept(Mono.CSharp.StructuralVisitor visitor) { throw null; }
        protected override void CloneTo(Mono.CSharp.CloneContext clonectx, Mono.CSharp.Statement target) { }
        protected override void DoEmit(Mono.CSharp.EmitContext ec) { }
        protected override bool DoFlowAnalysis(Mono.CSharp.FlowAnalysisContext fc) { throw null; }
        protected override bool DoResolve(Mono.CSharp.BlockContext bc) { throw null; }
        public static void Error_UnknownLabel(Mono.CSharp.BlockContext bc, string label, Mono.CSharp.Location loc) { }
        public override Mono.CSharp.Reachability MarkReachable(Mono.CSharp.Reachability rc) { throw null; }
    }
    public partial class GotoCase : Mono.CSharp.SwitchGoto
    {
        public GotoCase(Mono.CSharp.Expression e, Mono.CSharp.Location l) : base (default(Mono.CSharp.Location)) { }
        public Mono.CSharp.Expression Expr { get { throw null; } }
        public Mono.CSharp.SwitchLabel Label { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public override object Accept(Mono.CSharp.StructuralVisitor visitor) { throw null; }
        protected override void CloneTo(Mono.CSharp.CloneContext clonectx, Mono.CSharp.Statement t) { }
        protected override void DoEmit(Mono.CSharp.EmitContext ec) { }
        public override Mono.CSharp.Reachability MarkReachable(Mono.CSharp.Reachability rc) { throw null; }
        public override bool Resolve(Mono.CSharp.BlockContext ec) { throw null; }
    }
    public partial class GotoDefault : Mono.CSharp.SwitchGoto
    {
        public GotoDefault(Mono.CSharp.Location l) : base (default(Mono.CSharp.Location)) { }
        public override object Accept(Mono.CSharp.StructuralVisitor visitor) { throw null; }
        protected override void DoEmit(Mono.CSharp.EmitContext ec) { }
        public override Mono.CSharp.Reachability MarkReachable(Mono.CSharp.Reachability rc) { throw null; }
        public override bool Resolve(Mono.CSharp.BlockContext bc) { throw null; }
    }
    public partial class HoistedParameter : Mono.CSharp.HoistedVariable
    {
        public HoistedParameter(Mono.CSharp.AnonymousMethodStorey scope, Mono.CSharp.ParameterReference par) : base (default(Mono.CSharp.AnonymousMethodStorey), default(string), default(Mono.CSharp.TypeSpec)) { }
        public HoistedParameter(Mono.CSharp.HoistedParameter hp, string name) : base (default(Mono.CSharp.AnonymousMethodStorey), default(string), default(Mono.CSharp.TypeSpec)) { }
        public bool IsAssigned { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public Mono.CSharp.ParameterReference Parameter { get { throw null; } }
        public void EmitHoistingAssignment(Mono.CSharp.EmitContext ec) { }
    }
    public partial class HoistedStoreyClass : Mono.CSharp.CompilerGeneratedContainer
    {
        protected Mono.CSharp.TypeParameterMutator mutator;
        public HoistedStoreyClass(Mono.CSharp.TypeDefinition parent, Mono.CSharp.MemberName name, Mono.CSharp.TypeParameters tparams, Mono.CSharp.Modifiers mods, Mono.CSharp.MemberKind kind) : base (default(Mono.CSharp.TypeContainer), default(Mono.CSharp.MemberName), default(Mono.CSharp.Modifiers)) { }
        public Mono.CSharp.TypeParameterMutator Mutator { get { throw null; } set { } }
        public Mono.CSharp.HoistedStoreyClass GetGenericStorey() { throw null; }
        public sealed partial class HoistedField : Mono.CSharp.Field
        {
            public HoistedField(Mono.CSharp.HoistedStoreyClass parent, Mono.CSharp.FullNamedExpression type, Mono.CSharp.Modifiers mod, string name, Mono.CSharp.Attributes attrs, Mono.CSharp.Location loc) : base (default(Mono.CSharp.TypeDefinition), default(Mono.CSharp.FullNamedExpression), default(Mono.CSharp.Modifiers), default(Mono.CSharp.MemberName), default(Mono.CSharp.Attributes)) { }
            protected override bool ResolveMemberType() { throw null; }
        }
    }
    public partial class HoistedThis : Mono.CSharp.HoistedVariable
    {
        public HoistedThis(Mono.CSharp.AnonymousMethodStorey storey, Mono.CSharp.Field field) : base (default(Mono.CSharp.AnonymousMethodStorey), default(string), default(Mono.CSharp.TypeSpec)) { }
    }
    public abstract partial class HoistedVariable
    {
        protected Mono.CSharp.Field field;
        protected readonly Mono.CSharp.AnonymousMethodStorey storey;
        protected HoistedVariable(Mono.CSharp.AnonymousMethodStorey storey, Mono.CSharp.Field field) { }
        protected HoistedVariable(Mono.CSharp.AnonymousMethodStorey storey, string name, Mono.CSharp.TypeSpec type) { }
        public Mono.CSharp.Field Field { get { throw null; } }
        public Mono.CSharp.AnonymousMethodStorey Storey { get { throw null; } }
        public void AddressOf(Mono.CSharp.EmitContext ec, Mono.CSharp.AddressOp mode) { }
        public Mono.CSharp.Expression CreateExpressionTree() { throw null; }
        public void Emit(Mono.CSharp.EmitContext ec) { }
        public void Emit(Mono.CSharp.EmitContext ec, bool leave_copy) { }
        public void EmitAssign(Mono.CSharp.EmitContext ec, Mono.CSharp.Expression source, bool leave_copy, bool isCompound) { }
        public void EmitAssignFromStack(Mono.CSharp.EmitContext ec) { }
        public Mono.CSharp.Expression EmitToField(Mono.CSharp.EmitContext ec) { throw null; }
        protected virtual Mono.CSharp.FieldExpr GetFieldExpression(Mono.CSharp.EmitContext ec) { throw null; }
    }
    public partial interface IAssemblyDefinition
    {
        string FullName { get; }
        bool IsCLSCompliant { get; }
        bool IsMissing { get; }
        string Name { get; }
        byte[] GetPublicKeyToken();
        bool IsFriendAssemblyTo(Mono.CSharp.IAssemblyDefinition assembly);
    }
    public partial interface IAssignMethod
    {
        void Emit(Mono.CSharp.EmitContext ec, bool leave_copy);
        void EmitAssign(Mono.CSharp.EmitContext ec, Mono.CSharp.Expression source, bool leave_copy, bool isCompound);
    }
    public partial interface IExpressionCleanup
    {
        void EmitCleanup(Mono.CSharp.EmitContext ec);
    }
    public partial class If : Mono.CSharp.Statement
    {
        public Mono.CSharp.Statement FalseStatement;
        public Mono.CSharp.Statement TrueStatement;
        public If(Mono.CSharp.Expression bool_expr, Mono.CSharp.Statement true_statement, Mono.CSharp.Location l) { }
        public If(Mono.CSharp.Expression bool_expr, Mono.CSharp.Statement true_statement, Mono.CSharp.Statement false_statement, Mono.CSharp.Location l) { }
        public Mono.CSharp.Expression Expr { get { throw null; } }
        public override object Accept(Mono.CSharp.StructuralVisitor visitor) { throw null; }
        protected override void CloneTo(Mono.CSharp.CloneContext clonectx, Mono.CSharp.Statement t) { }
        protected override void DoEmit(Mono.CSharp.EmitContext ec) { }
        protected override bool DoFlowAnalysis(Mono.CSharp.FlowAnalysisContext fc) { throw null; }
        public override Mono.CSharp.Reachability MarkReachable(Mono.CSharp.Reachability rc) { throw null; }
        public override bool Resolve(Mono.CSharp.BlockContext ec) { throw null; }
    }
    public partial interface IFixedExpression
    {
        bool IsFixed { get; }
    }
    public partial interface IGenericMethodDefinition : Mono.CSharp.IMemberDefinition, Mono.CSharp.IMethodDefinition
    {
        Mono.CSharp.TypeParameterSpec[] TypeParameters { get; }
        int TypeParametersCount { get; }
    }
    public partial interface IInterfaceMemberSpec
    {
        Mono.CSharp.TypeSpec MemberType { get; }
    }
    public partial interface ILiteralConstant
    {
    }
    public partial interface ILocalVariable
    {
        void Emit(Mono.CSharp.EmitContext ec);
        void EmitAddressOf(Mono.CSharp.EmitContext ec);
        void EmitAssign(Mono.CSharp.EmitContext ec);
    }
    public partial interface IMemberContext : Mono.CSharp.IModuleContext
    {
        Mono.CSharp.MemberCore CurrentMemberDefinition { get; }
        Mono.CSharp.TypeSpec CurrentType { get; }
        Mono.CSharp.TypeParameters CurrentTypeParameters { get; }
        bool IsObsolete { get; }
        bool IsStatic { get; }
        bool IsUnsafe { get; }
        string GetSignatureForError();
        Mono.CSharp.ExtensionMethodCandidates LookupExtensionMethod(string name, int arity);
        Mono.CSharp.FullNamedExpression LookupNamespaceAlias(string name);
        Mono.CSharp.FullNamedExpression LookupNamespaceOrType(string name, int arity, Mono.CSharp.LookupMode mode, Mono.CSharp.Location loc);
    }
    public partial interface IMemberDefinition
    {
        System.Nullable<bool> CLSAttributeValue { get; }
        bool IsImported { get; }
        string Name { get; }
        string[] ConditionalConditions();
        System.ObsoleteAttribute GetAttributeObsolete();
        void SetIsAssigned();
        void SetIsUsed();
    }
    public partial interface IMemoryLocation
    {
        void AddressOf(Mono.CSharp.EmitContext ec, Mono.CSharp.AddressOp mode);
    }
    public partial interface IMethodData : Mono.CSharp.IMemberContext, Mono.CSharp.IModuleContext
    {
        Mono.CSharp.ToplevelBlock Block { get; set; }
        System.Reflection.CallingConventions CallingConventions { get; }
        bool IsAccessor { get; }
        Mono.CSharp.Location Location { get; }
        Mono.CSharp.MemberName MethodName { get; }
        Mono.CSharp.Attributes OptAttributes { get; }
        Mono.CSharp.ParametersCompiled ParameterInfo { get; }
        Mono.CSharp.TypeSpec ReturnType { get; }
        Mono.CSharp.MethodSpec Spec { get; }
        Mono.CSharp.EmitContext CreateEmitContext(System.Reflection.Emit.ILGenerator ig, Mono.CompilerServices.SymbolWriter.SourceMethodBuilder sourceMethod);
    }
    public partial interface IMethodDefinition : Mono.CSharp.IMemberDefinition
    {
        System.Reflection.MethodBase Metadata { get; }
    }
    public partial interface IModuleContext
    {
        Mono.CSharp.ModuleContainer Module { get; }
    }
    public partial class ImplicitCast : Mono.CSharp.ShimExpression
    {
        public ImplicitCast(Mono.CSharp.Expression expr, Mono.CSharp.TypeSpec target, bool arrayAccess) : base (default(Mono.CSharp.Expression)) { }
        protected override Mono.CSharp.Expression DoResolve(Mono.CSharp.ResolveContext ec) { throw null; }
    }
    public partial class ImplicitDelegateCreation : Mono.CSharp.DelegateCreation
    {
        public ImplicitDelegateCreation(Mono.CSharp.TypeSpec delegateType, Mono.CSharp.MethodGroupExpr mg, Mono.CSharp.Location loc) { }
        public static bool ContainsMethodTypeParameter(Mono.CSharp.TypeSpec type) { throw null; }
        protected override Mono.CSharp.Expression DoResolve(Mono.CSharp.ResolveContext ec) { throw null; }
        public override void Emit(Mono.CSharp.EmitContext ec) { }
    }
    public partial class ImplicitLambdaParameter : Mono.CSharp.Parameter
    {
        public ImplicitLambdaParameter(string name, Mono.CSharp.Location loc) : base (default(Mono.CSharp.FullNamedExpression), default(string), default(Mono.CSharp.Parameter.Modifier), default(Mono.CSharp.Attributes), default(Mono.CSharp.Location)) { }
        public override Mono.CSharp.TypeSpec Resolve(Mono.CSharp.IMemberContext ec, int index) { throw null; }
        public void SetParameterType(Mono.CSharp.TypeSpec type) { }
    }
    public partial class ImportedAssemblyDefinition : Mono.CSharp.IAssemblyDefinition
    {
        public ImportedAssemblyDefinition(System.Reflection.Assembly assembly) { }
        public System.Reflection.Assembly Assembly { get { throw null; } }
        public string FullName { get { throw null; } }
        public bool HasStrongName { get { throw null; } }
        public bool IsCLSCompliant { get { throw null; } }
        public bool IsMissing { get { throw null; } }
        public string Location { get { throw null; } }
        public string Name { get { throw null; } }
        public System.Reflection.AssemblyName GetAssemblyVisibleToName(Mono.CSharp.IAssemblyDefinition assembly) { throw null; }
        public byte[] GetPublicKeyToken() { throw null; }
        public bool IsFriendAssemblyTo(Mono.CSharp.IAssemblyDefinition assembly) { throw null; }
        public void ReadAttributes() { }
        public override string ToString() { throw null; }
    }
    public partial class ImportedModuleDefinition
    {
        public ImportedModuleDefinition(System.Reflection.Module module) { }
        public bool IsCLSCompliant { get { throw null; } }
        public string Name { get { throw null; } }
        public System.Collections.Generic.List<Mono.CSharp.Attribute> ReadAssemblyAttributes() { throw null; }
        public void ReadAttributes() { }
    }
    public partial interface INamedBlockVariable
    {
        Mono.CSharp.Block Block { get; }
        bool IsDeclared { get; }
        bool IsParameter { get; }
        Mono.CSharp.Location Location { get; }
        Mono.CSharp.Expression CreateReferenceExpression(Mono.CSharp.ResolveContext rc, Mono.CSharp.Location loc);
    }
    public partial class Indexer : Mono.CSharp.PropertyBase, Mono.CSharp.IInterfaceMemberSpec, Mono.CSharp.IParametersMember
    {
        public Indexer(Mono.CSharp.TypeDefinition parent, Mono.CSharp.FullNamedExpression type, Mono.CSharp.MemberName name, Mono.CSharp.Modifiers mod, Mono.CSharp.ParametersCompiled parameters, Mono.CSharp.Attributes attrs) : base (default(Mono.CSharp.TypeDefinition), default(Mono.CSharp.FullNamedExpression), default(Mono.CSharp.Modifiers), default(Mono.CSharp.Modifiers), default(Mono.CSharp.MemberName), default(Mono.CSharp.Attributes)) { }
        Mono.CSharp.AParametersCollection Mono.CSharp.IParametersMember.Parameters { get { throw null; } }
        public Mono.CSharp.ParametersCompiled ParameterInfo { get { throw null; } }
        public override void Accept(Mono.CSharp.StructuralVisitor visitor) { }
        public override void ApplyAttributeBuilder(Mono.CSharp.Attribute a, Mono.CSharp.MethodSpec ctor, byte[] cdata, Mono.CSharp.PredefinedAttributes pa) { }
        protected override bool CheckForDuplications() { throw null; }
        public override bool Define() { throw null; }
        public override void Emit() { }
        public override bool EnableOverloadChecks(Mono.CSharp.MemberCore overload) { throw null; }
        public override string GetSignatureForDocumentation() { throw null; }
        public override string GetSignatureForError() { throw null; }
        public override void PrepareEmit() { }
        protected override bool VerifyClsCompliance() { throw null; }
        public partial class GetIndexerMethod : Mono.CSharp.PropertyBase.GetMethod, Mono.CSharp.IInterfaceMemberSpec, Mono.CSharp.IParametersMember
        {
            public GetIndexerMethod(Mono.CSharp.PropertyBase property, Mono.CSharp.Modifiers modifiers, Mono.CSharp.ParametersCompiled parameters, Mono.CSharp.Attributes attrs, Mono.CSharp.Location loc) : base (default(Mono.CSharp.PropertyBase), default(Mono.CSharp.Modifiers), default(Mono.CSharp.Attributes), default(Mono.CSharp.Location)) { }
            Mono.CSharp.TypeSpec Mono.CSharp.IInterfaceMemberSpec.MemberType { get { throw null; } }
            Mono.CSharp.AParametersCollection Mono.CSharp.IParametersMember.Parameters { get { throw null; } }
            public override Mono.CSharp.ParametersCompiled ParameterInfo { get { throw null; } }
            public override void Define(Mono.CSharp.TypeContainer parent) { }
        }
        public partial class SetIndexerMethod : Mono.CSharp.PropertyBase.SetMethod, Mono.CSharp.IInterfaceMemberSpec, Mono.CSharp.IParametersMember
        {
            public SetIndexerMethod(Mono.CSharp.PropertyBase property, Mono.CSharp.Modifiers modifiers, Mono.CSharp.ParametersCompiled parameters, Mono.CSharp.Attributes attrs, Mono.CSharp.Location loc) : base (default(Mono.CSharp.PropertyBase), default(Mono.CSharp.Modifiers), default(Mono.CSharp.ParametersCompiled), default(Mono.CSharp.Attributes), default(Mono.CSharp.Location)) { }
            Mono.CSharp.TypeSpec Mono.CSharp.IInterfaceMemberSpec.MemberType { get { throw null; } }
            Mono.CSharp.AParametersCollection Mono.CSharp.IParametersMember.Parameters { get { throw null; } }
        }
    }
    public partial class IndexerSpec : Mono.CSharp.PropertySpec, Mono.CSharp.IInterfaceMemberSpec, Mono.CSharp.IParametersMember
    {
        public IndexerSpec(Mono.CSharp.TypeSpec declaringType, Mono.CSharp.IMemberDefinition definition, Mono.CSharp.TypeSpec memberType, Mono.CSharp.AParametersCollection parameters, System.Reflection.PropertyInfo info, Mono.CSharp.Modifiers modifiers) : base (default(Mono.CSharp.MemberKind), default(Mono.CSharp.TypeSpec), default(Mono.CSharp.IMemberDefinition), default(Mono.CSharp.TypeSpec), default(System.Reflection.PropertyInfo), default(Mono.CSharp.Modifiers)) { }
        public Mono.CSharp.AParametersCollection Parameters { get { throw null; } }
        public static Mono.CSharp.ParametersImported CreateParametersFromSetter(Mono.CSharp.MethodSpec setter, int set_param_count) { throw null; }
        public override string GetSignatureForDocumentation() { throw null; }
        public override string GetSignatureForError() { throw null; }
        public override Mono.CSharp.MemberSpec InflateMember(Mono.CSharp.TypeParameterInflator inflator) { throw null; }
        public override System.Collections.Generic.List<Mono.CSharp.MissingTypeSpecReference> ResolveMissingDependencies(Mono.CSharp.MemberSpec caller) { throw null; }
    }
    public partial class Indirection : Mono.CSharp.Expression, Mono.CSharp.IAssignMethod, Mono.CSharp.IFixedExpression, Mono.CSharp.IMemoryLocation
    {
        public Indirection(Mono.CSharp.Expression expr, Mono.CSharp.Location l) { }
        public Mono.CSharp.Expression Expr { get { throw null; } }
        public bool IsFixed { get { throw null; } }
        public override Mono.CSharp.Location StartLocation { get { throw null; } }
        public override object Accept(Mono.CSharp.StructuralVisitor visitor) { throw null; }
        public void AddressOf(Mono.CSharp.EmitContext ec, Mono.CSharp.AddressOp Mode) { }
        protected override void CloneTo(Mono.CSharp.CloneContext clonectx, Mono.CSharp.Expression t) { }
        public override bool ContainsEmitWithAwait() { throw null; }
        public override Mono.CSharp.Expression CreateExpressionTree(Mono.CSharp.ResolveContext ec) { throw null; }
        protected override Mono.CSharp.Expression DoResolve(Mono.CSharp.ResolveContext ec) { throw null; }
        public override Mono.CSharp.Expression DoResolveLValue(Mono.CSharp.ResolveContext ec, Mono.CSharp.Expression right_side) { throw null; }
        public override void Emit(Mono.CSharp.EmitContext ec) { }
        public void Emit(Mono.CSharp.EmitContext ec, bool leave_copy) { }
        public void EmitAssign(Mono.CSharp.EmitContext ec, Mono.CSharp.Expression source, bool leave_copy, bool isCompound) { }
    }
    public partial class InflatedTypeSpec : Mono.CSharp.TypeSpec
    {
        public InflatedTypeSpec(Mono.CSharp.IModuleContext context, Mono.CSharp.TypeSpec openType, Mono.CSharp.TypeSpec declaringType, Mono.CSharp.TypeSpec[] targs) : base (default(Mono.CSharp.MemberKind), default(Mono.CSharp.TypeSpec), default(Mono.CSharp.ITypeDefinition), default(System.Type), default(Mono.CSharp.Modifiers)) { }
        public override Mono.CSharp.TypeSpec BaseType { get { throw null; } }
        public Mono.CSharp.TypeParameterSpec[] Constraints { get { throw null; } }
        public bool HasConstraintsChecked { get { throw null; } set { } }
        public override System.Collections.Generic.IList<Mono.CSharp.TypeSpec> Interfaces { get { throw null; } }
        public override bool IsArrayGenericInterface { get { throw null; } }
        public override bool IsExpressionTreeType { get { throw null; } }
        public override bool IsGenericTask { get { throw null; } }
        public override bool IsNullableType { get { throw null; } }
        public override bool IsTupleType { get { throw null; } }
        public override Mono.CSharp.TypeSpec[] TypeArguments { get { throw null; } }
        public override bool AddInterface(Mono.CSharp.TypeSpec iface) { throw null; }
        public override void CheckObsoleteness(Mono.CSharp.IMemberContext mc, Mono.CSharp.Location loc) { }
        public static bool ContainsTypeParameter(Mono.CSharp.TypeSpec type) { throw null; }
        public Mono.CSharp.TypeParameterInflator CreateLocalInflator(Mono.CSharp.IModuleContext context) { throw null; }
        public override System.ObsoleteAttribute GetAttributeObsolete() { throw null; }
        public override Mono.CSharp.TypeSpec GetDefinition() { throw null; }
        public override System.Type GetMetaInfo() { throw null; }
        public override string GetSignatureForError() { throw null; }
        protected override string GetTypeNameSignature() { throw null; }
        public bool HasDynamicArgument() { throw null; }
        protected override void InitializeMemberCache(bool onlyTypes) { }
        protected override bool IsNotCLSCompliant(out bool attrValue) { attrValue = default(bool); throw null; }
        public override Mono.CSharp.TypeSpec Mutate(Mono.CSharp.TypeParameterMutator mutator) { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public partial struct InstanceEmitter
    {
        public InstanceEmitter(Mono.CSharp.Expression instance, bool addressLoad) { throw null;}
        public void Emit(Mono.CSharp.EmitContext ec, bool conditionalAccess) { }
        public void EmitLoad(Mono.CSharp.EmitContext ec, bool boxInstance) { }
        public Mono.CSharp.TypeSpec GetStackType(Mono.CSharp.EmitContext ec) { throw null; }
    }
    public partial class IntConstant : Mono.CSharp.IntegralConstant
    {
        public readonly int Value;
        public IntConstant(Mono.CSharp.BuiltinTypes types, int v, Mono.CSharp.Location loc) : base (default(Mono.CSharp.TypeSpec), default(Mono.CSharp.Location)) { }
        public IntConstant(Mono.CSharp.TypeSpec type, int v, Mono.CSharp.Location loc) : base (default(Mono.CSharp.TypeSpec), default(Mono.CSharp.Location)) { }
        public override bool IsDefaultValue { get { throw null; } }
        public override bool IsNegative { get { throw null; } }
        public override bool IsOneInteger { get { throw null; } }
        public override bool IsZeroInteger { get { throw null; } }
        public override Mono.CSharp.Constant ConvertExplicitly(bool in_checked_context, Mono.CSharp.TypeSpec target_type) { throw null; }
        public override Mono.CSharp.Constant ConvertImplicitly(Mono.CSharp.TypeSpec type) { throw null; }
        public override void Emit(Mono.CSharp.EmitContext ec) { }
        public override void EncodeAttributeValue(Mono.CSharp.IMemberContext rc, Mono.CSharp.AttributeEncoder enc, Mono.CSharp.TypeSpec targetType, Mono.CSharp.TypeSpec parameterType) { }
        public override object GetValue() { throw null; }
        public override long GetValueAsLong() { throw null; }
        public override Mono.CSharp.Constant Increment() { throw null; }
    }
    public abstract partial class IntegralConstant : Mono.CSharp.Constant
    {
        protected IntegralConstant(Mono.CSharp.TypeSpec type, Mono.CSharp.Location loc) : base (default(Mono.CSharp.Location)) { }
        public override void Error_ValueCannotBeConverted(Mono.CSharp.ResolveContext ec, Mono.CSharp.TypeSpec target, bool expl) { }
        public override string GetValueAsLiteral() { throw null; }
        public abstract Mono.CSharp.Constant Increment();
    }
    public partial class InteractiveBase
    {
        public static string ContinuationPrompt;
        public static System.IO.TextWriter Error;
        public static Mono.CSharp.Evaluator Evaluator;
        public static System.IO.TextWriter Output;
        public static string Prompt;
        public static bool QuitRequested;
        public InteractiveBase() { }
        public static string help { get { throw null; } }
        public static object quit { get { throw null; } }
        public static string Describe(object x) { throw null; }
        public static void LoadAssembly(string assembly) { }
        public static void LoadPackage(string pkg) { }
        public static void print(object obj) { }
        public static void print(string fmt, params object[] args) { }
        public static void Quit() { }
        public static void ShowUsing() { }
        public static void ShowVars() { }
        public static System.TimeSpan Time(System.Action a) { throw null; }
    }
    public sealed partial class Interface : Mono.CSharp.TypeDefinition
    {
        public Interface(Mono.CSharp.TypeContainer parent, Mono.CSharp.MemberName name, Mono.CSharp.Modifiers mod, Mono.CSharp.Attributes attrs) : base (default(Mono.CSharp.TypeContainer), default(Mono.CSharp.MemberName), default(Mono.CSharp.Attributes), default(Mono.CSharp.MemberKind)) { }
        public override System.AttributeTargets AttributeTargets { get { throw null; } }
        protected override System.Reflection.TypeAttributes TypeAttr { get { throw null; } }
        public override void Accept(Mono.CSharp.StructuralVisitor visitor) { }
        public override void ApplyAttributeBuilder(Mono.CSharp.Attribute a, Mono.CSharp.MethodSpec ctor, byte[] cdata, Mono.CSharp.PredefinedAttributes pa) { }
        protected override bool VerifyClsCompliance() { throw null; }
    }
    public abstract partial class InterfaceMemberBase : Mono.CSharp.MemberBase
    {
        protected const Mono.CSharp.Modifiers AllowedModifiersClass = (Mono.CSharp.Modifiers)(12031);
        protected const Mono.CSharp.Modifiers AllowedModifiersInterface = (Mono.CSharp.Modifiers)(8208);
        protected const Mono.CSharp.Modifiers AllowedModifiersStruct = (Mono.CSharp.Modifiers)(11423);
        protected Mono.CSharp.MethodSpec base_method;
        public System.Reflection.MethodAttributes flags;
        public Mono.CSharp.TypeSpec InterfaceType;
        public readonly bool IsExplicitImpl;
        public bool IsInterface;
        protected bool is_external_implementation;
        protected InterfaceMemberBase(Mono.CSharp.TypeDefinition parent, Mono.CSharp.FullNamedExpression type, Mono.CSharp.Modifiers mod, Mono.CSharp.Modifiers allowed_mod, Mono.CSharp.MemberName name, Mono.CSharp.Attributes attrs) : base (default(Mono.CSharp.TypeDefinition), default(Mono.CSharp.FullNamedExpression), default(Mono.CSharp.Modifiers), default(Mono.CSharp.Modifiers), default(Mono.CSharp.Modifiers), default(Mono.CSharp.MemberName), default(Mono.CSharp.Attributes)) { }
        public abstract Mono.CSharp.Variance ExpectedMemberTypeVariance { get; }
        public override bool IsUsed { get { throw null; } }
        public string ShortName { get { throw null; } }
        protected static bool CheckAccessModifiers(Mono.CSharp.MemberCore this_member, Mono.CSharp.MemberSpec base_member) { throw null; }
        protected override bool CheckBase() { throw null; }
        protected virtual bool CheckForDuplications() { throw null; }
        protected virtual bool CheckOverrideAgainstBase(Mono.CSharp.MemberSpec base_member) { throw null; }
        public override bool Define() { throw null; }
        protected bool DefineParameters(Mono.CSharp.ParametersCompiled parameters) { throw null; }
        protected override void DoMemberTypeDependentChecks() { }
        public override void Emit() { }
        public override bool EnableOverloadChecks(Mono.CSharp.MemberCore overload) { throw null; }
        protected void Error_CannotChangeAccessModifiers(Mono.CSharp.MemberCore member, Mono.CSharp.MemberSpec base_member) { }
        protected void Error_StaticReturnType() { }
        protected virtual Mono.CSharp.MemberSpec FindBaseMember(out Mono.CSharp.MemberSpec bestCandidate, ref bool overrides) { bestCandidate = default(Mono.CSharp.MemberSpec); throw null; }
        public string GetFullName(Mono.CSharp.MemberName name) { throw null; }
        public string GetFullName(string name) { throw null; }
        public override string GetSignatureForDocumentation() { throw null; }
        public override void SetConstraints(System.Collections.Generic.List<Mono.CSharp.Constraints> constraints_list) { }
    }
    public partial class InternalErrorException : System.Exception
    {
        public InternalErrorException() { }
        public InternalErrorException(Mono.CSharp.MemberCore mc, System.Exception e) { }
        public InternalErrorException(System.Exception e, Mono.CSharp.Location loc) { }
        public InternalErrorException(System.Exception exception, string message, params object[] args) { }
        public InternalErrorException(string message) { }
        public InternalErrorException(string message, params object[] args) { }
    }
    public partial class InterpolatedString : Mono.CSharp.Expression
    {
        public InterpolatedString(Mono.CSharp.StringLiteral start, System.Collections.Generic.List<Mono.CSharp.Expression> interpolations, Mono.CSharp.StringLiteral end) { }
        protected override void CloneTo(Mono.CSharp.CloneContext clonectx, Mono.CSharp.Expression t) { }
        public override bool ContainsEmitWithAwait() { throw null; }
        public Mono.CSharp.Expression ConvertTo(Mono.CSharp.ResolveContext rc, Mono.CSharp.TypeSpec type) { throw null; }
        public override Mono.CSharp.Expression CreateExpressionTree(Mono.CSharp.ResolveContext rc) { throw null; }
        protected override Mono.CSharp.Expression DoResolve(Mono.CSharp.ResolveContext rc) { throw null; }
        public override void Emit(Mono.CSharp.EmitContext ec) { }
        public override void FlowAnalysis(Mono.CSharp.FlowAnalysisContext fc) { }
    }
    public partial class InterpolatedStringInsert : Mono.CSharp.CompositeExpression
    {
        public InterpolatedStringInsert(Mono.CSharp.Expression expr) : base (default(Mono.CSharp.Expression)) { }
        public Mono.CSharp.Expression Alignment { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public string Format { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        protected override void CloneTo(Mono.CSharp.CloneContext clonectx, Mono.CSharp.Expression t) { }
        protected override Mono.CSharp.Expression DoResolve(Mono.CSharp.ResolveContext rc) { throw null; }
        public override void FlowAnalysis(Mono.CSharp.FlowAnalysisContext fc) { }
        public System.Nullable<int> ResolveAligment(Mono.CSharp.ResolveContext rc) { throw null; }
    }
    public partial class IntLiteral : Mono.CSharp.IntConstant, Mono.CSharp.ILiteralConstant
    {
        public IntLiteral(Mono.CSharp.BuiltinTypes types, int l, Mono.CSharp.Location loc) : base (default(Mono.CSharp.BuiltinTypes), default(int), default(Mono.CSharp.Location)) { }
        public override bool IsLiteral { get { throw null; } }
        public override object Accept(Mono.CSharp.StructuralVisitor visitor) { throw null; }
        public override Mono.CSharp.Constant ConvertImplicitly(Mono.CSharp.TypeSpec type) { throw null; }
    }
    public partial class Invocation : Mono.CSharp.ExpressionStatement
    {
        protected Mono.CSharp.Arguments arguments;
        protected Mono.CSharp.Expression expr;
        protected Mono.CSharp.MethodGroupExpr mg;
        public Invocation(Mono.CSharp.Expression expr, Mono.CSharp.Arguments arguments) { }
        public Mono.CSharp.Arguments Arguments { get { throw null; } }
        public Mono.CSharp.Expression Exp { get { throw null; } }
        public Mono.CSharp.MethodGroupExpr MethodGroup { get { throw null; } }
        public override Mono.CSharp.Location StartLocation { get { throw null; } }
        public override object Accept(Mono.CSharp.StructuralVisitor visitor) { throw null; }
        public override Mono.CSharp.MethodGroupExpr CanReduceLambda(Mono.CSharp.AnonymousMethodBody body) { throw null; }
        protected override void CloneTo(Mono.CSharp.CloneContext clonectx, Mono.CSharp.Expression t) { }
        public override bool ContainsEmitWithAwait() { throw null; }
        public override Mono.CSharp.Expression CreateExpressionTree(Mono.CSharp.ResolveContext ec) { throw null; }
        protected override Mono.CSharp.Expression DoResolve(Mono.CSharp.ResolveContext rc) { throw null; }
        protected virtual Mono.CSharp.Expression DoResolveDynamic(Mono.CSharp.ResolveContext ec, Mono.CSharp.Expression memberExpr) { throw null; }
        public override Mono.CSharp.Expression DoResolveLValue(Mono.CSharp.ResolveContext rc, Mono.CSharp.Expression right_side) { throw null; }
        protected virtual Mono.CSharp.MethodGroupExpr DoResolveOverload(Mono.CSharp.ResolveContext ec) { throw null; }
        public override void Emit(Mono.CSharp.EmitContext ec) { }
        public override void EmitPrepare(Mono.CSharp.EmitContext ec) { }
        public override void EmitStatement(Mono.CSharp.EmitContext ec) { }
        public override void FlowAnalysis(Mono.CSharp.FlowAnalysisContext fc) { }
        public override string GetSignatureForError() { throw null; }
        public override bool HasConditionalAccess() { throw null; }
        public static bool IsMemberInvocable(Mono.CSharp.MemberSpec member) { throw null; }
        public static bool IsSpecialMethodInvocation(Mono.CSharp.ResolveContext ec, Mono.CSharp.MethodSpec method, Mono.CSharp.Location loc) { throw null; }
        public override System.Linq.Expressions.Expression MakeExpression(Mono.CSharp.BuilderContext ctx) { throw null; }
        public static System.Linq.Expressions.Expression MakeExpression(Mono.CSharp.BuilderContext ctx, Mono.CSharp.Expression instance, Mono.CSharp.MethodSpec mi, Mono.CSharp.Arguments args) { throw null; }
        public override Mono.CSharp.ExpressionStatement ResolveStatement(Mono.CSharp.BlockContext bc) { throw null; }
        public partial class Predefined : Mono.CSharp.Invocation
        {
            public Predefined(Mono.CSharp.MethodGroupExpr expr, Mono.CSharp.Arguments arguments) : base (default(Mono.CSharp.Expression), default(Mono.CSharp.Arguments)) { }
            protected override Mono.CSharp.MethodGroupExpr DoResolveOverload(Mono.CSharp.ResolveContext rc) { throw null; }
        }
    }
    public partial interface IParameterData
    {
        Mono.CSharp.Expression DefaultValue { get; }
        bool HasDefaultValue { get; }
        bool HasExtensionMethodModifier { get; }
        Mono.CSharp.Parameter.Modifier ModFlags { get; }
        string Name { get; }
    }
    public partial interface IParametersMember : Mono.CSharp.IInterfaceMemberSpec
    {
        Mono.CSharp.AParametersCollection Parameters { get; }
    }
    public partial class Is : Mono.CSharp.Probe
    {
        public Is(Mono.CSharp.Expression expr, Mono.CSharp.Expression probe_type, Mono.CSharp.Location l) : base (default(Mono.CSharp.Expression), default(Mono.CSharp.Expression), default(Mono.CSharp.Location)) { }
        protected override string OperatorName { get { throw null; } }
        public Mono.CSharp.LocalVariable Variable { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public override object Accept(Mono.CSharp.StructuralVisitor visitor) { throw null; }
        public override Mono.CSharp.Expression CreateExpressionTree(Mono.CSharp.ResolveContext ec) { throw null; }
        protected override Mono.CSharp.Expression DoResolve(Mono.CSharp.ResolveContext rc) { throw null; }
        public override void Emit(Mono.CSharp.EmitContext ec) { }
        public override void EmitBranchable(Mono.CSharp.EmitContext ec, System.Reflection.Emit.Label target, bool on_true) { }
        public override void EmitPrepare(Mono.CSharp.EmitContext ec) { }
        public override void FlowAnalysis(Mono.CSharp.FlowAnalysisContext fc) { }
        public override void FlowAnalysisConditional(Mono.CSharp.FlowAnalysisContext fc) { }
        protected override void ResolveProbeType(Mono.CSharp.ResolveContext rc) { }
    }
    public partial class Iterator : Mono.CSharp.StateMachineInitializer
    {
        public readonly bool IsEnumerable;
        public readonly Mono.CSharp.TypeSpec OriginalIteratorType;
        public readonly Mono.CSharp.IMethodData OriginalMethod;
        public Iterator(Mono.CSharp.ParametersBlock block, Mono.CSharp.IMethodData method, Mono.CSharp.TypeDefinition host, Mono.CSharp.TypeSpec iterator_type, bool is_enumerable) : base (default(Mono.CSharp.ParametersBlock), default(Mono.CSharp.TypeDefinition), default(Mono.CSharp.TypeSpec)) { }
        public Mono.CSharp.ToplevelBlock Container { get { throw null; } }
        public override string ContainerType { get { throw null; } }
        public override bool IsIterator { get { throw null; } }
        public Mono.CSharp.Method CreateFinallyHost(Mono.CSharp.TryFinallyBlock block) { throw null; }
        public static void CreateIterator(Mono.CSharp.IMethodData method, Mono.CSharp.TypeDefinition parent, Mono.CSharp.Modifiers modifiers) { }
        public override void Emit(Mono.CSharp.EmitContext ec) { }
        public void EmitDispose(Mono.CSharp.EmitContext ec) { }
        public override void EmitStatement(Mono.CSharp.EmitContext ec) { }
        public void EmitYieldBreak(Mono.CSharp.EmitContext ec, bool unwind_protect) { }
        public override string GetSignatureForError() { throw null; }
        public override void InjectYield(Mono.CSharp.EmitContext ec, Mono.CSharp.Expression expr, int resume_pc, bool unwind_protect, System.Reflection.Emit.Label resume_point) { }
    }
    public partial interface ITypeDefinition : Mono.CSharp.IMemberDefinition
    {
        Mono.CSharp.IAssemblyDefinition DeclaringAssembly { get; }
        bool IsComImport { get; }
        bool IsCyclicTypeForwarder { get; }
        bool IsPartial { get; }
        bool IsTypeForwarder { get; }
        string Namespace { get; }
        Mono.CSharp.TypeParameterSpec[] TypeParameters { get; }
        int TypeParametersCount { get; }
        Mono.CSharp.TypeSpec GetAttributeCoClass();
        string GetAttributeDefaultMember();
        System.AttributeUsageAttribute GetAttributeUsage(Mono.CSharp.PredefinedAttribute pa);
        bool IsInternalAsPublic(Mono.CSharp.IAssemblyDefinition assembly);
        void LoadMembers(Mono.CSharp.TypeSpec declaringType, bool onlyTypes, ref Mono.CSharp.MemberCache cache);
    }
    public partial interface IVariableReference : Mono.CSharp.IFixedExpression
    {
        bool IsHoisted { get; }
        string Name { get; }
        Mono.CSharp.VariableInfo VariableInfo { get; }
        void SetHasAddressTaken();
    }
    public partial class LabeledStatement : Mono.CSharp.Statement
    {
        public LabeledStatement(string name, Mono.CSharp.Block block, Mono.CSharp.Location l) { }
        public Mono.CSharp.Block Block { get { throw null; } }
        public string Name { get { throw null; } }
        public override object Accept(Mono.CSharp.StructuralVisitor visitor) { throw null; }
        public void AddGotoReference(Mono.CSharp.Reachability rc) { }
        protected override void CloneTo(Mono.CSharp.CloneContext clonectx, Mono.CSharp.Statement target) { }
        protected override void DoEmit(Mono.CSharp.EmitContext ec) { }
        protected override bool DoFlowAnalysis(Mono.CSharp.FlowAnalysisContext fc) { throw null; }
        public System.Reflection.Emit.Label LabelTarget(Mono.CSharp.EmitContext ec) { throw null; }
        public override Mono.CSharp.Reachability MarkReachable(Mono.CSharp.Reachability rc) { throw null; }
        public override bool Resolve(Mono.CSharp.BlockContext bc) { throw null; }
    }
    public partial class LambdaExpression : Mono.CSharp.AnonymousMethodExpression
    {
        public LambdaExpression(Mono.CSharp.Location loc) : base (default(Mono.CSharp.Location)) { }
        public override bool HasExplicitParameters { get { throw null; } }
        public override object Accept(Mono.CSharp.StructuralVisitor visitor) { throw null; }
        protected override Mono.CSharp.AnonymousMethodBody CompatibleMethodFactory(Mono.CSharp.TypeSpec returnType, Mono.CSharp.TypeSpec delegateType, Mono.CSharp.ParametersCompiled p, Mono.CSharp.ParametersBlock b) { throw null; }
        protected override Mono.CSharp.Expression CreateExpressionTree(Mono.CSharp.ResolveContext ec, Mono.CSharp.TypeSpec delegate_type) { throw null; }
        protected override bool DoResolveParameters(Mono.CSharp.ResolveContext rc) { throw null; }
        public override string GetSignatureForError() { throw null; }
        protected override Mono.CSharp.ParametersCompiled ResolveParameters(Mono.CSharp.ResolveContext ec, Mono.CSharp.TypeInferenceContext tic, Mono.CSharp.TypeSpec delegateType) { throw null; }
    }
    public enum LanguageVersion
    {
        Default = 7,
        Experimental = 100,
        ISO_1 = 1,
        ISO_2 = 2,
        V_3 = 3,
        V_4 = 4,
        V_5 = 5,
        V_6 = 6,
        V_7 = 7,
    }
    public abstract partial class LocalExitStatement : Mono.CSharp.ExitStatement
    {
        protected Mono.CSharp.LoopStatement enclosing_loop;
        protected LocalExitStatement(Mono.CSharp.Location loc) { }
        protected override bool IsLocalExit { get { throw null; } }
        protected override void CloneTo(Mono.CSharp.CloneContext clonectx, Mono.CSharp.Statement t) { }
        protected override bool DoResolve(Mono.CSharp.BlockContext bc) { throw null; }
    }
    public partial class LocalTemporary : Mono.CSharp.Expression, Mono.CSharp.IAssignMethod, Mono.CSharp.IMemoryLocation
    {
        public LocalTemporary(Mono.CSharp.TypeSpec t) { }
        public LocalTemporary(System.Reflection.Emit.LocalBuilder b, Mono.CSharp.TypeSpec t) { }
        public System.Reflection.Emit.LocalBuilder Builder { get { throw null; } }
        public void AddressOf(Mono.CSharp.EmitContext ec, Mono.CSharp.AddressOp mode) { }
        public override bool ContainsEmitWithAwait() { throw null; }
        public override Mono.CSharp.Expression CreateExpressionTree(Mono.CSharp.ResolveContext ec) { throw null; }
        protected override Mono.CSharp.Expression DoResolve(Mono.CSharp.ResolveContext ec) { throw null; }
        public override Mono.CSharp.Expression DoResolveLValue(Mono.CSharp.ResolveContext ec, Mono.CSharp.Expression right_side) { throw null; }
        public override void Emit(Mono.CSharp.EmitContext ec) { }
        public void Emit(Mono.CSharp.EmitContext ec, bool leave_copy) { }
        public void EmitAssign(Mono.CSharp.EmitContext ec, Mono.CSharp.Expression source, bool leave_copy, bool isCompound) { }
        public void Release(Mono.CSharp.EmitContext ec) { }
        public void Store(Mono.CSharp.EmitContext ec) { }
    }
    public sealed partial class LocalVariable : Mono.CSharp.ILocalVariable, Mono.CSharp.INamedBlockVariable
    {
        public Mono.CSharp.VariableInfo VariableInfo;
        public LocalVariable(Mono.CSharp.Block block, string name, Mono.CSharp.LocalVariable.Flags flags, Mono.CSharp.Location loc) { }
        public LocalVariable(Mono.CSharp.Block block, string name, Mono.CSharp.Location loc) { }
        public LocalVariable(Mono.CSharp.LocalVariable li, string name, Mono.CSharp.Location loc) { }
        public bool AddressTaken { get { throw null; } }
        public Mono.CSharp.Block Block { get { throw null; } }
        public Mono.CSharp.Constant ConstantValue { get { throw null; } set { } }
        public bool Created { get { throw null; } }
        public Mono.CSharp.HoistedVariable HoistedVariant { get { throw null; } set { } }
        public bool IsCompilerGenerated { get { throw null; } }
        public bool IsConstant { get { throw null; } }
        public bool IsDeclared { get { throw null; } }
        public bool IsFixed { get { throw null; } set { } }
        public bool IsLocked { get { throw null; } set { } }
        public bool IsReadonly { get { throw null; } }
        public bool IsThis { get { throw null; } }
        public bool IsUsed { get { throw null; } }
        public Mono.CSharp.Location Location { get { throw null; } }
        bool Mono.CSharp.INamedBlockVariable.IsParameter { get { throw null; } }
        public string Name { get { throw null; } }
        public Mono.CSharp.TypeSpec Type { get { throw null; } set { } }
        public void CreateBuilder(Mono.CSharp.EmitContext ec) { }
        public static Mono.CSharp.LocalVariable CreateCompilerGenerated(Mono.CSharp.TypeSpec type, Mono.CSharp.Block block, Mono.CSharp.Location loc, bool writeToSymbolFile=false) { throw null; }
        public Mono.CSharp.Expression CreateReferenceExpression(Mono.CSharp.ResolveContext rc, Mono.CSharp.Location loc) { throw null; }
        public void Emit(Mono.CSharp.EmitContext ec) { }
        public void EmitAddressOf(Mono.CSharp.EmitContext ec) { }
        public void EmitAssign(Mono.CSharp.EmitContext ec) { }
        public static string GetCompilerGeneratedName(Mono.CSharp.Block block) { throw null; }
        public string GetReadOnlyContext() { throw null; }
        public bool IsAssigned(Mono.CSharp.FlowAnalysisContext fc) { throw null; }
        public bool IsThisAssigned(Mono.CSharp.FlowAnalysisContext fc, Mono.CSharp.Block block) { throw null; }
        public void PrepareAssignmentAnalysis(Mono.CSharp.BlockContext bc) { }
        public void SetHasAddressTaken() { }
        public void SetIsUsed() { }
        public override string ToString() { throw null; }
        [System.FlagsAttribute]
        public enum Flags
        {
            AddressTaken = 4,
            CompilerGenerated = 8,
            Constant = 16,
            FixedVariable = 64,
            ForeachVariable = 32,
            IsLocked = 256,
            IsThis = 2,
            ReadonlyMask = 224,
            SymbolFileHidden = 512,
            Used = 1,
            UsingVariable = 128,
        }
    }
    public partial class LocalVariableReference : Mono.CSharp.VariableReference
    {
        public Mono.CSharp.LocalVariable local_info;
        public LocalVariableReference(Mono.CSharp.LocalVariable li, Mono.CSharp.Location l) { }
        public override bool IsFixed { get { throw null; } }
        public override bool IsLockedByStatement { get { throw null; } set { } }
        public override bool IsRef { get { throw null; } }
        public override string Name { get { throw null; } }
        protected override Mono.CSharp.ILocalVariable Variable { get { throw null; } }
        public override Mono.CSharp.VariableInfo VariableInfo { get { throw null; } }
        protected override void CloneTo(Mono.CSharp.CloneContext clonectx, Mono.CSharp.Expression t) { }
        protected override Mono.CSharp.Expression DoResolve(Mono.CSharp.ResolveContext ec) { throw null; }
        public override Mono.CSharp.Expression DoResolveLValue(Mono.CSharp.ResolveContext ec, Mono.CSharp.Expression rhs) { throw null; }
        public override bool Equals(object obj) { throw null; }
        public override void FlowAnalysis(Mono.CSharp.FlowAnalysisContext fc) { }
        public override int GetHashCode() { throw null; }
        public override Mono.CSharp.HoistedVariable GetHoistedVariable(Mono.CSharp.AnonymousExpression ae) { throw null; }
        public override void SetHasAddressTaken() { }
        public override string ToString() { throw null; }
    }
    public partial class LocatedToken
    {
        public int column;
        public Mono.CSharp.SourceFile file;
        public int row;
        public string value;
        public LocatedToken() { }
        public LocatedToken(string value, Mono.CSharp.Location loc) { }
        public Mono.CSharp.Location Location { get { throw null; } }
        public string Value { get { throw null; } }
        public override string ToString() { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public partial struct Location : System.IEquatable<Mono.CSharp.Location>
    {
        public static bool InEmacs;
        public static readonly Mono.CSharp.Location Null;
        public Location(Mono.CSharp.SourceFile file, int row, int column) { throw null;}
        public int Column { get { throw null; } }
        public int File { get { throw null; } }
        public bool IsNull { get { throw null; } }
        public string Name { get { throw null; } }
        public string NameFullPath { get { throw null; } }
        public int Row { get { throw null; } }
        public Mono.CSharp.SourceFile SourceFile { get { throw null; } }
        public static void AddFile(Mono.CSharp.SourceFile file) { }
        public bool Equals(Mono.CSharp.Location other) { throw null; }
        public static void Initialize(System.Collections.Generic.List<Mono.CSharp.SourceFile> files) { }
        public static Mono.CSharp.Location operator -(Mono.CSharp.Location loc, int columns) { throw null; }
        public static void Reset() { }
        public override string ToString() { throw null; }
        public string ToStringFullName() { throw null; }
    }
    public partial class LocationsBag
    {
        public LocationsBag() { }
        [System.Diagnostics.ConditionalAttribute("FULL_AST")]
        public void AddLocation(object element, params Mono.CSharp.Location[] locations) { }
        [System.Diagnostics.ConditionalAttribute("FULL_AST")]
        public void AddMember(Mono.CSharp.MemberCore member, System.Collections.Generic.IList<System.Tuple<Mono.CSharp.Modifiers, Mono.CSharp.Location>> modLocations) { }
        [System.Diagnostics.ConditionalAttribute("FULL_AST")]
        public void AddMember(Mono.CSharp.MemberCore member, System.Collections.Generic.IList<System.Tuple<Mono.CSharp.Modifiers, Mono.CSharp.Location>> modLocations, Mono.CSharp.Location location) { }
        [System.Diagnostics.ConditionalAttribute("FULL_AST")]
        public void AddMember(Mono.CSharp.MemberCore member, System.Collections.Generic.IList<System.Tuple<Mono.CSharp.Modifiers, Mono.CSharp.Location>> modLocations, params Mono.CSharp.Location[] locations) { }
        [System.Diagnostics.ConditionalAttribute("FULL_AST")]
        public void AddMember(Mono.CSharp.MemberCore member, System.Collections.Generic.IList<System.Tuple<Mono.CSharp.Modifiers, Mono.CSharp.Location>> modLocations, System.Collections.Generic.List<Mono.CSharp.Location> locations) { }
        [System.Diagnostics.ConditionalAttribute("FULL_AST")]
        public void AddStatement(object element, params Mono.CSharp.Location[] locations) { }
        [System.Diagnostics.ConditionalAttribute("FULL_AST")]
        public void AppendTo(object element, Mono.CSharp.Location location) { }
        [System.Diagnostics.ConditionalAttribute("FULL_AST")]
        public void AppendToMember(Mono.CSharp.MemberCore existing, params Mono.CSharp.Location[] locations) { }
        public System.Collections.Generic.List<Mono.CSharp.Location> GetLocations(object element) { throw null; }
        public Mono.CSharp.LocationsBag.MemberLocations GetMemberLocation(Mono.CSharp.MemberCore element) { throw null; }
        [System.Diagnostics.ConditionalAttribute("FULL_AST")]
        public void InsertLocation(object element, int index, Mono.CSharp.Location location) { }
        public partial class MemberLocations
        {
            public readonly System.Collections.Generic.IList<System.Tuple<Mono.CSharp.Modifiers, Mono.CSharp.Location>> Modifiers;
            public MemberLocations(System.Collections.Generic.IList<System.Tuple<Mono.CSharp.Modifiers, Mono.CSharp.Location>> mods) { }
            public MemberLocations(System.Collections.Generic.IList<System.Tuple<Mono.CSharp.Modifiers, Mono.CSharp.Location>> mods, Mono.CSharp.Location loc) { }
            public MemberLocations(System.Collections.Generic.IList<System.Tuple<Mono.CSharp.Modifiers, Mono.CSharp.Location>> mods, Mono.CSharp.Location[] locs) { }
            public MemberLocations(System.Collections.Generic.IList<System.Tuple<Mono.CSharp.Modifiers, Mono.CSharp.Location>> mods, System.Collections.Generic.List<Mono.CSharp.Location> locs) { }
            public int Count { get { throw null; } }
            public Mono.CSharp.Location this[int index] { get { throw null; } }
            public void AddLocations(Mono.CSharp.Location loc) { }
            public void AddLocations(params Mono.CSharp.Location[] additional) { }
        }
    }
    public partial class Lock : Mono.CSharp.TryFinallyBlock
    {
        public Lock(Mono.CSharp.Expression expr, Mono.CSharp.Statement stmt, Mono.CSharp.Location loc) : base (default(Mono.CSharp.Statement), default(Mono.CSharp.Location)) { }
        public Mono.CSharp.Expression Expr { get { throw null; } }
        public override object Accept(Mono.CSharp.StructuralVisitor visitor) { throw null; }
        protected override void CloneTo(Mono.CSharp.CloneContext clonectx, Mono.CSharp.Statement t) { }
        protected override bool DoFlowAnalysis(Mono.CSharp.FlowAnalysisContext fc) { throw null; }
        public override void EmitFinallyBody(Mono.CSharp.EmitContext ec) { }
        protected override void EmitTryBody(Mono.CSharp.EmitContext ec) { }
        protected override void EmitTryBodyPrepare(Mono.CSharp.EmitContext ec) { }
        public override bool Resolve(Mono.CSharp.BlockContext ec) { throw null; }
    }
    public partial class LongConstant : Mono.CSharp.IntegralConstant
    {
        public readonly long Value;
        public LongConstant(Mono.CSharp.BuiltinTypes types, long v, Mono.CSharp.Location loc) : base (default(Mono.CSharp.TypeSpec), default(Mono.CSharp.Location)) { }
        public LongConstant(Mono.CSharp.TypeSpec type, long v, Mono.CSharp.Location loc) : base (default(Mono.CSharp.TypeSpec), default(Mono.CSharp.Location)) { }
        public override bool IsDefaultValue { get { throw null; } }
        public override bool IsNegative { get { throw null; } }
        public override bool IsOneInteger { get { throw null; } }
        public override bool IsZeroInteger { get { throw null; } }
        public override Mono.CSharp.Constant ConvertExplicitly(bool in_checked_context, Mono.CSharp.TypeSpec target_type) { throw null; }
        public override Mono.CSharp.Constant ConvertImplicitly(Mono.CSharp.TypeSpec type) { throw null; }
        public override void Emit(Mono.CSharp.EmitContext ec) { }
        public override void EncodeAttributeValue(Mono.CSharp.IMemberContext rc, Mono.CSharp.AttributeEncoder enc, Mono.CSharp.TypeSpec targetType, Mono.CSharp.TypeSpec parameterType) { }
        public override object GetValue() { throw null; }
        public override long GetValueAsLong() { throw null; }
        public override Mono.CSharp.Constant Increment() { throw null; }
    }
    public partial class LongLiteral : Mono.CSharp.LongConstant, Mono.CSharp.ILiteralConstant
    {
        public LongLiteral(Mono.CSharp.BuiltinTypes types, long l, Mono.CSharp.Location loc) : base (default(Mono.CSharp.BuiltinTypes), default(long), default(Mono.CSharp.Location)) { }
        public override bool IsLiteral { get { throw null; } }
        public override object Accept(Mono.CSharp.StructuralVisitor visitor) { throw null; }
    }
    public enum LookupMode
    {
        IgnoreAccessibility = 2,
        IgnoreStaticUsing = 1024,
        Normal = 0,
        Probing = 1,
    }
    public abstract partial class LoopStatement : Mono.CSharp.Statement
    {
        protected LoopStatement(Mono.CSharp.Statement statement) { }
        public Mono.CSharp.Statement Statement { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public virtual void AddEndDefiniteAssignment(Mono.CSharp.FlowAnalysisContext fc) { }
        public override bool Resolve(Mono.CSharp.BlockContext bc) { throw null; }
        public virtual void SetEndReachable() { }
        public virtual void SetIteratorReachable() { }
    }
    public partial class MakeRefExpr : Mono.CSharp.ShimExpression
    {
        public MakeRefExpr(Mono.CSharp.Expression expr, Mono.CSharp.Location loc) : base (default(Mono.CSharp.Expression)) { }
        public override object Accept(Mono.CSharp.StructuralVisitor visitor) { throw null; }
        public override bool ContainsEmitWithAwait() { throw null; }
        protected override Mono.CSharp.Expression DoResolve(Mono.CSharp.ResolveContext rc) { throw null; }
        public override void Emit(Mono.CSharp.EmitContext ec) { }
    }
    public partial class MemberAccess : Mono.CSharp.ATypeNameExpression
    {
        protected Mono.CSharp.Expression expr;
        public MemberAccess(Mono.CSharp.Expression expr, string id) : base (default(string), default(Mono.CSharp.Location)) { }
        public MemberAccess(Mono.CSharp.Expression expr, string identifier, Mono.CSharp.Location loc) : base (default(string), default(Mono.CSharp.Location)) { }
        public MemberAccess(Mono.CSharp.Expression expr, string identifier, Mono.CSharp.TypeArguments args, Mono.CSharp.Location loc) : base (default(string), default(Mono.CSharp.Location)) { }
        public MemberAccess(Mono.CSharp.Expression expr, string identifier, int arity, Mono.CSharp.Location loc) : base (default(string), default(Mono.CSharp.Location)) { }
        public Mono.CSharp.Expression LeftExpression { get { throw null; } }
        public override Mono.CSharp.Location StartLocation { get { throw null; } }
        public override object Accept(Mono.CSharp.StructuralVisitor visitor) { throw null; }
        protected override void CloneTo(Mono.CSharp.CloneContext clonectx, Mono.CSharp.Expression t) { }
        protected override Mono.CSharp.Expression DoResolve(Mono.CSharp.ResolveContext rc) { throw null; }
        public override Mono.CSharp.Expression DoResolveLValue(Mono.CSharp.ResolveContext rc, Mono.CSharp.Expression rhs) { throw null; }
        public void Error_IdentifierNotFound(Mono.CSharp.IMemberContext rc, Mono.CSharp.TypeSpec expr_type) { }
        protected override void Error_InvalidExpressionStatement(Mono.CSharp.Report report, Mono.CSharp.Location loc) { }
        protected virtual void Error_OperatorCannotBeApplied(Mono.CSharp.ResolveContext rc, Mono.CSharp.TypeSpec type) { }
        public override void Error_TypeDoesNotContainDefinition(Mono.CSharp.ResolveContext ec, Mono.CSharp.TypeSpec type, string name) { }
        public override string GetSignatureForError() { throw null; }
        public override bool HasConditionalAccess() { throw null; }
        public static bool IsValidDotExpression(Mono.CSharp.TypeSpec type) { throw null; }
        public override Mono.CSharp.Expression LookupNameExpression(Mono.CSharp.ResolveContext rc, Mono.CSharp.Expression.MemberLookupRestrictions restrictions) { throw null; }
        public override Mono.CSharp.FullNamedExpression ResolveAsTypeOrNamespace(Mono.CSharp.IMemberContext rc, bool allowUnboundTypeArguments) { throw null; }
    }
    public abstract partial class MemberBase : Mono.CSharp.MemberCore
    {
        protected Mono.CSharp.TypeSpec member_type;
        public new Mono.CSharp.TypeDefinition Parent;
        protected Mono.CSharp.FullNamedExpression type_expr;
        protected MemberBase(Mono.CSharp.TypeDefinition parent, Mono.CSharp.FullNamedExpression type, Mono.CSharp.Modifiers mod, Mono.CSharp.Modifiers allowed_mod, Mono.CSharp.Modifiers def_mod, Mono.CSharp.MemberName name, Mono.CSharp.Attributes attrs) : base (default(Mono.CSharp.TypeContainer), default(Mono.CSharp.MemberName), default(Mono.CSharp.Attributes)) { }
        public Mono.CSharp.TypeSpec MemberType { get { throw null; } }
        public Mono.CSharp.FullNamedExpression TypeExpression { get { throw null; } set { } }
        protected virtual bool CheckBase() { throw null; }
        public override bool Define() { throw null; }
        protected virtual void DoMemberTypeDependentChecks() { }
        protected virtual void DoMemberTypeIndependentChecks() { }
        public override string GetSignatureForDocumentation() { throw null; }
        protected void IsTypePermitted() { }
        public virtual void PrepareEmit() { }
        protected virtual bool ResolveMemberType() { throw null; }
    }
    public partial class MemberCache
    {
        public static readonly Mono.CSharp.MemberCache Empty;
        public static readonly string IndexerNameAlias;
        public MemberCache() { }
        public MemberCache(Mono.CSharp.MemberCache cache) { }
        public MemberCache(Mono.CSharp.TypeContainer container) { }
        public MemberCache(int capacity) { }
        public void AddBaseType(Mono.CSharp.TypeSpec baseType) { }
        public void AddInterface(Mono.CSharp.TypeSpec iface) { }
        public void AddMember(Mono.CSharp.InterfaceMemberBase imb, string exlicitName, Mono.CSharp.MemberSpec ms) { }
        public void AddMember(Mono.CSharp.MemberSpec ms) { }
        public void AddMemberImported(Mono.CSharp.MemberSpec ms) { }
        public bool CheckExistingMembersOverloads(Mono.CSharp.MemberCore member, Mono.CSharp.AParametersCollection parameters) { throw null; }
        public bool CheckExistingMembersOverloads(Mono.CSharp.MemberCore member, string name, Mono.CSharp.AParametersCollection parameters) { throw null; }
        public static Mono.CSharp.MemberSpec FindBaseMember(Mono.CSharp.MemberCore member, out Mono.CSharp.MemberSpec bestCandidate, ref bool overrides) { bestCandidate = default(Mono.CSharp.MemberSpec); throw null; }
        public System.Collections.Generic.List<Mono.CSharp.MethodSpec> FindExtensionMethods(Mono.CSharp.IMemberContext invocationContext, string name, int arity) { throw null; }
        public static System.Collections.Generic.IList<Mono.CSharp.MemberSpec> FindInterfaceMembers(Mono.CSharp.TypeParameterSpec typeParameter, string name) { throw null; }
        public static Mono.CSharp.MemberSpec FindMember(Mono.CSharp.TypeSpec container, Mono.CSharp.MemberFilter filter, Mono.CSharp.BindingRestriction restrictions) { throw null; }
        public static System.Collections.Generic.IList<Mono.CSharp.MemberSpec> FindMembers(Mono.CSharp.TypeSpec container, string name, bool declaredOnlyClass) { throw null; }
        public static Mono.CSharp.TypeSpec FindNestedType(Mono.CSharp.TypeSpec container, string name, int arity, bool declaredOnlyClass) { throw null; }
        public static System.Collections.Generic.List<Mono.CSharp.FieldSpec> GetAllFieldsForDefiniteAssignment(Mono.CSharp.TypeSpec container, Mono.CSharp.IMemberContext context) { throw null; }
        public static System.Collections.Generic.IList<Mono.CSharp.MemberSpec> GetCompletitionMembers(Mono.CSharp.IMemberContext ctx, Mono.CSharp.TypeSpec container, string name) { throw null; }
        public static System.Collections.Generic.List<Mono.CSharp.TypeSpec> GetDeclaredNestedTypes(Mono.CSharp.TypeSpec container) { throw null; }
        public static System.Collections.Generic.List<Mono.CSharp.MethodSpec> GetInterfaceMethods(Mono.CSharp.TypeSpec iface) { throw null; }
        public static T GetMember<T>(Mono.CSharp.TypeSpec container, T spec) where T : Mono.CSharp.MemberSpec { throw null; }
        public static System.Collections.Generic.IList<Mono.CSharp.MethodSpec> GetNotImplementedAbstractMethods(Mono.CSharp.TypeSpec type) { throw null; }
        public static System.Collections.Generic.IList<Mono.CSharp.MemberSpec> GetUserOperator(Mono.CSharp.TypeSpec container, Mono.CSharp.Operator.OpType op, bool declaredOnly) { throw null; }
        public void InflateMembers(Mono.CSharp.MemberCache cacheToInflate, Mono.CSharp.TypeSpec inflatedType, Mono.CSharp.TypeParameterInflator inflator) { }
        public void InflateTypes(Mono.CSharp.MemberCache inflated_cache, Mono.CSharp.TypeParameterInflator inflator) { }
        public void RemoveHiddenMembers(Mono.CSharp.TypeSpec container) { }
        public void VerifyClsCompliance(Mono.CSharp.TypeSpec container, Mono.CSharp.Report report) { }
    }
    [System.Diagnostics.DebuggerDisplayAttribute("{GetSignatureForError()}")]
    public abstract partial class MemberCore : Mono.CSharp.Attributable, Mono.CSharp.IMemberContext, Mono.CSharp.IMemberDefinition, Mono.CSharp.IModuleContext
    {
        protected string comment;
        public Mono.CSharp.TypeContainer Parent;
        protected MemberCore(Mono.CSharp.TypeContainer parent, Mono.CSharp.MemberName name, Mono.CSharp.Attributes attrs) { }
        public System.Nullable<bool> CLSAttributeValue { get { throw null; } }
        public virtual Mono.CSharp.CompilerContext Compiler { get { throw null; } }
        public Mono.CSharp.MemberCore CurrentMemberDefinition { get { throw null; } }
        public virtual Mono.CSharp.TypeSpec CurrentType { get { throw null; } }
        public virtual Mono.CSharp.TypeParameters CurrentTypeParameters { get { throw null; } }
        public virtual string DocComment { get { throw null; } set { } }
        public abstract string DocCommentHeader { get; }
        protected bool HasClsCompliantAttribute { get { throw null; } }
        public bool IsAvailableForReuse { get { throw null; } set { } }
        public bool IsCompilerGenerated { get { throw null; } }
        public bool IsImported { get { throw null; } }
        public bool IsObsolete { get { throw null; } }
        public bool IsStatic { get { throw null; } }
        public bool IsUnsafe { get { throw null; } }
        public virtual bool IsUsed { get { throw null; } }
        public Mono.CSharp.Location Location { get { throw null; } }
        public Mono.CSharp.MemberName MemberName { get { throw null; } }
        public Mono.CSharp.Modifiers ModFlags { get { throw null; } set { } }
        public virtual Mono.CSharp.ModuleContainer Module { get { throw null; } }
        string Mono.CSharp.IMemberDefinition.Name { get { throw null; } }
        protected Mono.CSharp.Report Report { get { throw null; } }
        public virtual void Accept(Mono.CSharp.StructuralVisitor visitor) { }
        protected bool CheckAbstractAndExtern(bool has_block) { throw null; }
        protected void CheckProtectedModifier() { }
        public virtual string[] ConditionalConditions() { throw null; }
        public abstract bool Define();
        public virtual void Emit() { }
        public virtual bool EnableOverloadChecks(Mono.CSharp.MemberCore overload) { throw null; }
        public virtual System.ObsoleteAttribute GetAttributeObsolete() { throw null; }
        public virtual string GetCallerMemberName() { throw null; }
        public virtual void GetCompletionStartingWith(string prefix, System.Collections.Generic.List<string> results) { }
        public abstract string GetSignatureForDocumentation();
        public virtual string GetSignatureForError() { throw null; }
        public bool IsAccessibleAs(Mono.CSharp.TypeSpec p) { throw null; }
        public override bool IsClsComplianceRequired() { throw null; }
        public bool IsExposedFromAssembly() { throw null; }
        public Mono.CSharp.ExtensionMethodCandidates LookupExtensionMethod(string name, int arity) { throw null; }
        public virtual Mono.CSharp.FullNamedExpression LookupNamespaceAlias(string name) { throw null; }
        public virtual Mono.CSharp.FullNamedExpression LookupNamespaceOrType(string name, int arity, Mono.CSharp.LookupMode mode, Mono.CSharp.Location loc) { throw null; }
        public virtual void SetConstraints(System.Collections.Generic.List<Mono.CSharp.Constraints> constraints_list) { }
        public void SetIsAssigned() { }
        public void SetIsUsed() { }
        protected virtual void SetMemberName(Mono.CSharp.MemberName new_name) { }
        protected virtual bool VerifyClsCompliance() { throw null; }
        protected void Warning_IdentifierNotCompliant() { }
        public virtual void WriteDebugSymbol(Mono.CompilerServices.SymbolWriter.MonoSymbolFile file) { }
        [System.FlagsAttribute]
        public enum Flags
        {
            CanBeReused = 262144,
            CloseTypeCreated = 16,
            ClsCompliance_Undetected = 4,
            ClsCompliant = 8,
            ClsCompliantAttributeFalse = 128,
            Excluded = 512,
            Excluded_Undetected = 256,
            HasClsCompliantAttribute = 64,
            HasCompliantAttribute_Undetected = 32,
            HasExplicitLayout = 8192,
            HasInstanceConstructor = 65536,
            HasInstanceField = 1048576,
            HasStructLayout = 32768,
            HasUserOperators = 131072,
            InterfacesExpanded = 524288,
            IsAssigned = 4096,
            IsUsed = 2048,
            MethodOverloadsExist = 1024,
            Obsolete = 2,
            Obsolete_Undetected = 1,
            PartialDefinitionExists = 16384,
        }
    }
    public abstract partial class MemberExpr : Mono.CSharp.Expression, Mono.CSharp.OverloadResolver.IInstanceQualifier
    {
        protected bool conditional_access_receiver;
        public Mono.CSharp.Expression InstanceExpression;
        protected MemberExpr() { }
        public bool ConditionalAccess { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        protected abstract Mono.CSharp.TypeSpec DeclaringType { get; }
        public bool IsBase { get { throw null; } }
        public abstract bool IsInstance { get; }
        public abstract bool IsStatic { get; }
        public abstract string KindName { get; }
        Mono.CSharp.TypeSpec Mono.CSharp.OverloadResolver.IInstanceQualifier.InstanceType { get { throw null; } }
        public abstract string Name { get; }
        protected Mono.CSharp.MethodSpec CandidateToBaseOverride(Mono.CSharp.ResolveContext rc, Mono.CSharp.MethodSpec method) { throw null; }
        protected void CheckProtectedMemberAccess(Mono.CSharp.ResolveContext rc, Mono.CSharp.MemberSpec member) { }
        public static bool CheckProtectedMemberAccess<T>(Mono.CSharp.ResolveContext rc, T member, Mono.CSharp.TypeSpec qualifier) where T : Mono.CSharp.MemberSpec { throw null; }
        public override bool ContainsEmitWithAwait() { throw null; }
        protected void DoBestMemberChecks<T>(Mono.CSharp.ResolveContext rc, T member) where T : Mono.CSharp.MemberSpec, Mono.CSharp.IInterfaceMemberSpec { }
        protected void EmitInstance(Mono.CSharp.EmitContext ec, bool prepare_for_load) { }
        protected virtual void Error_CannotCallAbstractBase(Mono.CSharp.ResolveContext rc, string name) { }
        public static void Error_ProtectedMemberAccess(Mono.CSharp.ResolveContext rc, Mono.CSharp.MemberSpec member, Mono.CSharp.TypeSpec qualifier, Mono.CSharp.Location loc) { }
        public override void FlowAnalysis(Mono.CSharp.FlowAnalysisContext fc) { }
        public override bool HasConditionalAccess() { throw null; }
        bool Mono.CSharp.OverloadResolver.IInstanceQualifier.CheckProtectedMemberAccess(Mono.CSharp.ResolveContext rc, Mono.CSharp.MemberSpec member) { throw null; }
        protected void ResolveConditionalAccessReceiver(Mono.CSharp.ResolveContext rc) { }
        public bool ResolveInstanceExpression(Mono.CSharp.ResolveContext rc, Mono.CSharp.Expression rhs) { throw null; }
        public virtual Mono.CSharp.MemberExpr ResolveMemberAccess(Mono.CSharp.ResolveContext ec, Mono.CSharp.Expression left, Mono.CSharp.SimpleName original) { throw null; }
        public virtual void ResolveNameOf(Mono.CSharp.ResolveContext rc, Mono.CSharp.ATypeNameExpression expr) { }
        public abstract void SetTypeArguments(Mono.CSharp.ResolveContext ec, Mono.CSharp.TypeArguments ta);
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public partial struct MemberFilter : System.IEquatable<Mono.CSharp.MemberSpec>
    {
        public readonly int Arity;
        public readonly Mono.CSharp.MemberKind Kind;
        public readonly Mono.CSharp.TypeSpec MemberType;
        public readonly string Name;
        public readonly Mono.CSharp.AParametersCollection Parameters;
        public MemberFilter(Mono.CSharp.MethodSpec m) { throw null;}
        public MemberFilter(string name, int arity, Mono.CSharp.MemberKind kind, Mono.CSharp.AParametersCollection param, Mono.CSharp.TypeSpec type) { throw null;}
        public static Mono.CSharp.MemberFilter Constructor(Mono.CSharp.AParametersCollection param) { throw null; }
        public bool Equals(Mono.CSharp.MemberSpec other) { throw null; }
        public static Mono.CSharp.MemberFilter Field(string name, Mono.CSharp.TypeSpec type) { throw null; }
        public static Mono.CSharp.MemberFilter Method(string name, int arity, Mono.CSharp.AParametersCollection param, Mono.CSharp.TypeSpec type) { throw null; }
        public static Mono.CSharp.MemberFilter Property(string name, Mono.CSharp.TypeSpec type) { throw null; }
    }
    [System.FlagsAttribute]
    public enum MemberKind
    {
        ArrayType = 524288,
        Class = 2048,
        Constructor = 1,
        Delegate = 8192,
        Destructor = 128,
        Enum = 16384,
        Event = 2,
        Field = 4,
        GenericMask = 47112,
        Indexer = 32,
        Interface = 32768,
        InternalCompilerType = 2097152,
        MaskType = 63743,
        Method = 8,
        MissingType = 4194304,
        Namespace = 16777216,
        NestedMask = 63488,
        Operator = 64,
        PointerType = 1048576,
        Property = 16,
        Struct = 4096,
        TypeParameter = 65536,
        Void = 8388608,
    }
    [System.Diagnostics.DebuggerDisplayAttribute("{GetSignatureForError()}")]
    public partial class MemberName
    {
        public readonly Mono.CSharp.FullNamedExpression ExplicitInterface;
        public readonly Mono.CSharp.MemberName Left;
        public readonly Mono.CSharp.Location Location;
        public readonly string Name;
        public static readonly Mono.CSharp.MemberName Null;
        public Mono.CSharp.TypeParameters TypeParameters;
        public MemberName(Mono.CSharp.MemberName left, Mono.CSharp.MemberName right) { }
        public MemberName(Mono.CSharp.MemberName left, string name, Mono.CSharp.FullNamedExpression explicitInterface, Mono.CSharp.Location loc) { }
        public MemberName(Mono.CSharp.MemberName left, string name, Mono.CSharp.Location loc) { }
        public MemberName(string name) { }
        public MemberName(string name, Mono.CSharp.Location loc) { }
        public MemberName(string name, Mono.CSharp.TypeParameters tparams, Mono.CSharp.FullNamedExpression explicitInterface, Mono.CSharp.Location loc) { }
        public MemberName(string name, Mono.CSharp.TypeParameters tparams, Mono.CSharp.Location loc) { }
        public int Arity { get { throw null; } }
        public string Basename { get { throw null; } }
        public bool IsGeneric { get { throw null; } }
        public void CreateMetadataName(System.Text.StringBuilder sb) { }
        public bool Equals(Mono.CSharp.MemberName other) { throw null; }
        public override bool Equals(object other) { throw null; }
        public override int GetHashCode() { throw null; }
        public string GetSignatureForDocumentation() { throw null; }
        public string GetSignatureForError() { throw null; }
        public static string MakeName(string name, Mono.CSharp.TypeParameters args) { throw null; }
    }
    public abstract partial class MemberSpec
    {
        protected Mono.CSharp.TypeSpec declaringType;
        protected Mono.CSharp.IMemberDefinition definition;
        public readonly Mono.CSharp.MemberKind Kind;
        protected Mono.CSharp.Modifiers modifiers;
        protected const Mono.CSharp.MemberSpec.StateFlags SharedStateFlags = (Mono.CSharp.MemberSpec.StateFlags)(383);
        public Mono.CSharp.MemberSpec.StateFlags state;
        protected MemberSpec(Mono.CSharp.MemberKind kind, Mono.CSharp.TypeSpec declaringType, Mono.CSharp.IMemberDefinition definition, Mono.CSharp.Modifiers modifiers) { }
        public virtual int Arity { get { throw null; } }
        public Mono.CSharp.TypeSpec DeclaringType { get { throw null; } set { } }
        public bool IsAbstract { get { throw null; } }
        public bool IsAccessor { get { throw null; } set { } }
        public bool IsGeneric { get { throw null; } set { } }
        public bool IsNotCSharpCompatible { get { throw null; } set { } }
        public bool IsPrivate { get { throw null; } }
        public bool IsPublic { get { throw null; } }
        public bool IsStatic { get { throw null; } }
        public Mono.CSharp.IMemberDefinition MemberDefinition { get { throw null; } }
        public Mono.CSharp.Modifiers Modifiers { get { throw null; } set { } }
        public virtual string Name { get { throw null; } }
        public virtual void CheckObsoleteness(Mono.CSharp.IMemberContext mc, Mono.CSharp.Location loc) { }
        public virtual System.ObsoleteAttribute GetAttributeObsolete() { throw null; }
        public System.Collections.Generic.List<Mono.CSharp.MissingTypeSpecReference> GetMissingDependencies() { throw null; }
        public System.Collections.Generic.List<Mono.CSharp.MissingTypeSpecReference> GetMissingDependencies(Mono.CSharp.MemberSpec caller) { throw null; }
        public virtual string GetSignatureForDocumentation() { throw null; }
        public virtual string GetSignatureForError() { throw null; }
        public virtual Mono.CSharp.MemberSpec InflateMember(Mono.CSharp.TypeParameterInflator inflator) { throw null; }
        public bool IsAccessible(Mono.CSharp.IMemberContext ctx) { throw null; }
        public bool IsCLSCompliant() { throw null; }
        public bool IsConditionallyExcluded(Mono.CSharp.IMemberContext ctx) { throw null; }
        protected virtual bool IsNotCLSCompliant(out bool attrValue) { attrValue = default(bool); throw null; }
        public abstract System.Collections.Generic.List<Mono.CSharp.MissingTypeSpecReference> ResolveMissingDependencies(Mono.CSharp.MemberSpec caller);
        public override string ToString() { throw null; }
        [System.FlagsAttribute]
        public enum StateFlags
        {
            CLSCompliant = 8,
            CLSCompliant_Undetected = 4,
            ConstraintsChecked = 128,
            GenericIterateInterface = 2097152,
            GenericTask = 4194304,
            HasDynamicElement = 64,
            HasNamedTupleElement = 256,
            InflatedExpressionType = 524288,
            InflatedNullableType = 1048576,
            InterfacesExpanded = 65536,
            InterfacesImported = 8388608,
            IsAccessor = 512,
            IsGeneric = 1024,
            IsNotCSharpCompatible = 131072,
            MissingDependency = 32,
            MissingDependency_Undetected = 16,
            Obsolete = 2,
            Obsolete_Undetected = 1,
            PendingBaseTypeInflate = 32768,
            PendingMakeMethod = 8192,
            PendingMemberCacheMembers = 16384,
            PendingMetaInflate = 4096,
            SpecialRuntimeType = 262144,
            Tuple = 16777216,
        }
    }
    public abstract partial class MetadataImporter
    {
        protected readonly System.Collections.Generic.Dictionary<System.Reflection.Assembly, Mono.CSharp.IAssemblyDefinition> assembly_2_definition;
        protected readonly System.Collections.Generic.Dictionary<System.Type, Mono.CSharp.TypeSpec> compiled_types;
        public static readonly string CompilerServicesNamespace;
        protected readonly System.Collections.Generic.Dictionary<System.Type, Mono.CSharp.TypeSpec> import_cache;
        protected readonly Mono.CSharp.ModuleContainer module;
        protected MetadataImporter(Mono.CSharp.ModuleContainer module) { }
        public System.Collections.Generic.ICollection<Mono.CSharp.IAssemblyDefinition> Assemblies { get { throw null; } }
        public bool IgnoreCompilerGeneratedField { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public bool IgnorePrivateMembers { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public abstract void AddCompiledType(System.Reflection.Emit.TypeBuilder builder, Mono.CSharp.TypeSpec spec);
        public Mono.CSharp.EventSpec CreateEvent(System.Reflection.EventInfo ei, Mono.CSharp.TypeSpec declaringType, Mono.CSharp.MethodSpec add, Mono.CSharp.MethodSpec remove) { throw null; }
        public Mono.CSharp.FieldSpec CreateField(System.Reflection.FieldInfo fi, Mono.CSharp.TypeSpec declaringType) { throw null; }
        public Mono.CSharp.MethodSpec CreateMethod(System.Reflection.MethodBase mb, Mono.CSharp.TypeSpec declaringType) { throw null; }
        public Mono.CSharp.TypeSpec CreateNestedType(System.Type type, Mono.CSharp.TypeSpec declaringType) { throw null; }
        public Mono.CSharp.PropertySpec CreateProperty(System.Reflection.PropertyInfo pi, Mono.CSharp.TypeSpec declaringType, Mono.CSharp.MethodSpec @get, Mono.CSharp.MethodSpec @set) { throw null; }
        public Mono.CSharp.TypeSpec CreateType(System.Type type) { throw null; }
        protected Mono.CSharp.TypeSpec CreateType(System.Type type, Mono.CSharp.TypeSpec declaringType, Mono.CSharp.MetadataImporter.AttributesTypeInfoReader dtype, bool canImportBaseType) { throw null; }
        protected abstract Mono.CSharp.MemberKind DetermineKindFromBaseType(System.Type baseType);
        public Mono.CSharp.IAssemblyDefinition GetAssemblyDefinition(System.Reflection.Assembly assembly) { throw null; }
        public Mono.CSharp.ImportedAssemblyDefinition GetImportedAssemblyDefinition(System.Reflection.AssemblyName assemblyName) { throw null; }
        public static bool HasAttribute(System.Collections.Generic.IList<System.Reflection.CustomAttributeData> attributesData, string attrName, string attrNamespace) { throw null; }
        protected abstract bool HasVolatileModifier(System.Type[] modifiers);
        public Mono.CSharp.TypeSpec ImportType(System.Type type) { throw null; }
        public void ImportTypeBase(System.Type type) { }
        public void ImportTypes(System.Type[] types, Mono.CSharp.Namespace targetNamespace, bool importExtensionTypes) { }
        [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
        protected partial struct AttributesTypeInfoReader
        {
            public int DynamicPosition;
            public int TuplePosition;
            public AttributesTypeInfoReader(object provider) { throw null;}
            public System.Collections.Generic.IList<string> GetNamedTupleElements(int length) { throw null; }
            public bool HasDynamicAttribute() { throw null; }
            public bool HasNamedTupleAttribute() { throw null; }
            public bool IsDynamicObject() { throw null; }
        }
    }
    public partial class Method : Mono.CSharp.MethodOrOperator, Mono.CSharp.IGenericMethodDefinition, Mono.CSharp.IMemberDefinition, Mono.CSharp.IMethodDefinition
    {
        public Method(Mono.CSharp.TypeDefinition parent, Mono.CSharp.FullNamedExpression return_type, Mono.CSharp.Modifiers mod, Mono.CSharp.MemberName name, Mono.CSharp.ParametersCompiled parameters, Mono.CSharp.Attributes attrs) : base (default(Mono.CSharp.TypeDefinition), default(Mono.CSharp.FullNamedExpression), default(Mono.CSharp.Modifiers), default(Mono.CSharp.Modifiers), default(Mono.CSharp.MemberName), default(Mono.CSharp.Attributes), default(Mono.CSharp.ParametersCompiled)) { }
        protected Method(Mono.CSharp.TypeDefinition parent, Mono.CSharp.FullNamedExpression return_type, Mono.CSharp.Modifiers mod, Mono.CSharp.Modifiers amod, Mono.CSharp.MemberName name, Mono.CSharp.ParametersCompiled parameters, Mono.CSharp.Attributes attrs) : base (default(Mono.CSharp.TypeDefinition), default(Mono.CSharp.FullNamedExpression), default(Mono.CSharp.Modifiers), default(Mono.CSharp.Modifiers), default(Mono.CSharp.MemberName), default(Mono.CSharp.Attributes), default(Mono.CSharp.ParametersCompiled)) { }
        public override Mono.CSharp.TypeParameters CurrentTypeParameters { get { throw null; } }
        public Mono.CSharp.TypeParameterSpec[] TypeParameters { get { throw null; } }
        public int TypeParametersCount { get { throw null; } }
        public override void Accept(Mono.CSharp.StructuralVisitor visitor) { }
        public override void ApplyAttributeBuilder(Mono.CSharp.Attribute a, Mono.CSharp.MethodSpec ctor, byte[] cdata, Mono.CSharp.PredefinedAttributes pa) { }
        public static bool CheckImplementingMethodConstraints(Mono.CSharp.TypeContainer container, Mono.CSharp.MethodSpec method, Mono.CSharp.MethodSpec baseMethod) { throw null; }
        public static Mono.CSharp.Method Create(Mono.CSharp.TypeDefinition parent, Mono.CSharp.FullNamedExpression returnType, Mono.CSharp.Modifiers mod, Mono.CSharp.MemberName name, Mono.CSharp.ParametersCompiled parameters, Mono.CSharp.Attributes attrs) { throw null; }
        public override bool Define() { throw null; }
        protected virtual void DefineTypeParameters() { }
        public override void Emit() { }
        public override bool EnableOverloadChecks(Mono.CSharp.MemberCore overload) { throw null; }
        public static void Error1599(Mono.CSharp.Location loc, Mono.CSharp.TypeSpec t, Mono.CSharp.Report Report) { }
        public override string GetSignatureForError() { throw null; }
        public override Mono.CSharp.FullNamedExpression LookupNamespaceOrType(string name, int arity, Mono.CSharp.LookupMode mode, Mono.CSharp.Location loc) { throw null; }
        public override void PrepareEmit() { }
        protected override bool ResolveMemberType() { throw null; }
        public void SetPartialDefinition(Mono.CSharp.Method methodDefinition) { }
    }
    public abstract partial class MethodCore : Mono.CSharp.InterfaceMemberBase, Mono.CSharp.IInterfaceMemberSpec, Mono.CSharp.IParametersMember
    {
        protected Mono.CSharp.ToplevelBlock block;
        protected Mono.CSharp.ParametersCompiled parameters;
        protected Mono.CSharp.MethodSpec spec;
        protected MethodCore(Mono.CSharp.TypeDefinition parent, Mono.CSharp.FullNamedExpression type, Mono.CSharp.Modifiers mod, Mono.CSharp.Modifiers allowed_mod, Mono.CSharp.MemberName name, Mono.CSharp.Attributes attrs, Mono.CSharp.ParametersCompiled parameters) : base (default(Mono.CSharp.TypeDefinition), default(Mono.CSharp.FullNamedExpression), default(Mono.CSharp.Modifiers), default(Mono.CSharp.Modifiers), default(Mono.CSharp.MemberName), default(Mono.CSharp.Attributes)) { }
        public Mono.CSharp.ToplevelBlock Block { get { throw null; } set { } }
        public System.Reflection.CallingConventions CallingConventions { get { throw null; } }
        public override string DocCommentHeader { get { throw null; } }
        public override Mono.CSharp.Variance ExpectedMemberTypeVariance { get { throw null; } }
        Mono.CSharp.AParametersCollection Mono.CSharp.IParametersMember.Parameters { get { throw null; } }
        public Mono.CSharp.ParametersCompiled ParameterInfo { get { throw null; } }
        public Mono.CSharp.TypeSpec[] ParameterTypes { get { throw null; } }
        public Mono.CSharp.MethodSpec Spec { get { throw null; } }
        protected override bool CheckBase() { throw null; }
        protected override bool CheckOverrideAgainstBase(Mono.CSharp.MemberSpec base_member) { throw null; }
        public override void Emit() { }
        public override bool EnableOverloadChecks(Mono.CSharp.MemberCore overload) { throw null; }
        public override string GetSignatureForDocumentation() { throw null; }
        public override void PrepareEmit() { }
        protected override bool VerifyClsCompliance() { throw null; }
    }
    public partial class MethodData
    {
        protected Mono.CSharp.TypeSpec declaring_type;
        protected System.Reflection.MethodAttributes flags;
        public Mono.CSharp.MethodSpec implementing;
        protected Mono.CSharp.InterfaceMemberBase member;
        public readonly Mono.CSharp.IMethodData method;
        protected Mono.CSharp.Modifiers modifiers;
        public MethodData(Mono.CSharp.InterfaceMemberBase member, Mono.CSharp.Modifiers modifiers, System.Reflection.MethodAttributes flags, Mono.CSharp.IMethodData method) { }
        public Mono.CSharp.TypeSpec DeclaringType { get { throw null; } }
        public string MetadataName { get { throw null; } }
        public System.Reflection.Emit.MethodBuilder MethodBuilder { get { throw null; } }
        public bool Define(Mono.CSharp.TypeDefinition container, string method_full_name) { throw null; }
        public System.Reflection.Emit.MethodBuilder DefineMethodBuilder(Mono.CSharp.TypeDefinition container) { throw null; }
        public System.Reflection.Emit.MethodBuilder DefineMethodBuilder(Mono.CSharp.TypeDefinition container, Mono.CSharp.ParametersCompiled param) { throw null; }
        public void Emit(Mono.CSharp.TypeDefinition parent) { }
        public void WriteDebugSymbol(Mono.CompilerServices.SymbolWriter.MonoSymbolFile file) { }
    }
    public partial class MethodGroupExpr : Mono.CSharp.MemberExpr, Mono.CSharp.OverloadResolver.IBaseMembersProvider
    {
        protected System.Collections.Generic.IList<Mono.CSharp.MemberSpec> Methods;
        protected Mono.CSharp.TypeSpec queried_type;
        protected Mono.CSharp.TypeArguments type_arguments;
        public MethodGroupExpr(Mono.CSharp.MethodSpec m, Mono.CSharp.TypeSpec type, Mono.CSharp.Location loc) { }
        public MethodGroupExpr(System.Collections.Generic.IList<Mono.CSharp.MemberSpec> mi, Mono.CSharp.TypeSpec type, Mono.CSharp.Location loc) { }
        public Mono.CSharp.MethodSpec BestCandidate { get { throw null; } }
        public Mono.CSharp.TypeSpec BestCandidateReturnType { get { throw null; } }
        public System.Collections.Generic.IList<Mono.CSharp.MemberSpec> Candidates { get { throw null; } }
        protected override Mono.CSharp.TypeSpec DeclaringType { get { throw null; } }
        public bool IsConditionallyExcluded { get { throw null; } }
        public override bool IsInstance { get { throw null; } }
        public override bool IsSideEffectFree { get { throw null; } }
        public override bool IsStatic { get { throw null; } }
        public override string KindName { get { throw null; } }
        public override string Name { get { throw null; } }
        public override Mono.CSharp.Expression CreateExpressionTree(Mono.CSharp.ResolveContext ec) { throw null; }
        public static Mono.CSharp.MethodGroupExpr CreatePredefined(Mono.CSharp.MethodSpec best, Mono.CSharp.TypeSpec queriedType, Mono.CSharp.Location loc) { throw null; }
        protected override Mono.CSharp.Expression DoResolve(Mono.CSharp.ResolveContext ec) { throw null; }
        public override void Emit(Mono.CSharp.EmitContext ec) { }
        public void EmitCall(Mono.CSharp.EmitContext ec, Mono.CSharp.Arguments arguments, Mono.CSharp.TypeSpec conditionalAccessReceiver, bool statement) { }
        public void EmitCall(Mono.CSharp.EmitContext ec, Mono.CSharp.Arguments arguments, bool statement) { }
        public override void EmitPrepare(Mono.CSharp.EmitContext ec) { }
        public override void Error_ValueCannotBeConverted(Mono.CSharp.ResolveContext ec, Mono.CSharp.TypeSpec target, bool expl) { }
        public virtual System.Collections.Generic.IList<Mono.CSharp.MemberSpec> GetBaseMembers(Mono.CSharp.TypeSpec type) { throw null; }
        public Mono.CSharp.IParametersMember GetOverrideMemberParameters(Mono.CSharp.MemberSpec member) { throw null; }
        public override string GetSignatureForError() { throw null; }
        public bool HasAccessibleCandidate(Mono.CSharp.ResolveContext rc) { throw null; }
        public static bool IsExtensionMethodArgument(Mono.CSharp.Expression expr) { throw null; }
        public virtual Mono.CSharp.MethodGroupExpr LookupExtensionMethod(Mono.CSharp.ResolveContext rc) { throw null; }
        public virtual Mono.CSharp.MethodGroupExpr OverloadResolve(Mono.CSharp.ResolveContext ec, ref Mono.CSharp.Arguments args, Mono.CSharp.OverloadResolver.IErrorHandler cerrors, Mono.CSharp.OverloadResolver.Restrictions restr) { throw null; }
        public override Mono.CSharp.MemberExpr ResolveMemberAccess(Mono.CSharp.ResolveContext ec, Mono.CSharp.Expression left, Mono.CSharp.SimpleName original) { throw null; }
        public override void ResolveNameOf(Mono.CSharp.ResolveContext rc, Mono.CSharp.ATypeNameExpression expr) { }
        public override void SetTypeArguments(Mono.CSharp.ResolveContext ec, Mono.CSharp.TypeArguments ta) { }
    }
    public abstract partial class MethodOrOperator : Mono.CSharp.MethodCore, Mono.CSharp.IMemberContext, Mono.CSharp.IMemberDefinition, Mono.CSharp.IMethodData, Mono.CSharp.IMethodDefinition, Mono.CSharp.IModuleContext
    {
        protected Mono.CSharp.MethodData MethodData;
        protected MethodOrOperator(Mono.CSharp.TypeDefinition parent, Mono.CSharp.FullNamedExpression type, Mono.CSharp.Modifiers mod, Mono.CSharp.Modifiers allowed_mod, Mono.CSharp.MemberName name, Mono.CSharp.Attributes attrs, Mono.CSharp.ParametersCompiled parameters) : base (default(Mono.CSharp.TypeDefinition), default(Mono.CSharp.FullNamedExpression), default(Mono.CSharp.Modifiers), default(Mono.CSharp.Modifiers), default(Mono.CSharp.MemberName), default(Mono.CSharp.Attributes), default(Mono.CSharp.ParametersCompiled)) { }
        public override System.AttributeTargets AttributeTargets { get { throw null; } }
        public bool IsPartialDefinition { get { throw null; } }
        public bool IsPartialImplementation { get { throw null; } }
        public System.Reflection.Emit.MethodBuilder MethodBuilder { get { throw null; } }
        public Mono.CSharp.MemberName MethodName { get { throw null; } }
        bool Mono.CSharp.IMethodData.IsAccessor { get { throw null; } }
        System.Reflection.MethodBase Mono.CSharp.IMethodDefinition.Metadata { get { throw null; } }
        public Mono.CSharp.TypeSpec ReturnType { get { throw null; } }
        public override string[] ValidAttributeTargets { get { throw null; } }
        public override void ApplyAttributeBuilder(Mono.CSharp.Attribute a, Mono.CSharp.MethodSpec ctor, byte[] cdata, Mono.CSharp.PredefinedAttributes pa) { }
        protected override bool CheckForDuplications() { throw null; }
        public override string[] ConditionalConditions() { throw null; }
        public virtual Mono.CSharp.EmitContext CreateEmitContext(System.Reflection.Emit.ILGenerator ig, Mono.CompilerServices.SymbolWriter.SourceMethodBuilder sourceMethod) { throw null; }
        public override bool Define() { throw null; }
        protected override void DoMemberTypeDependentChecks() { }
        protected override void DoMemberTypeIndependentChecks() { }
        public override void Emit() { }
        protected void Error_ConditionalAttributeIsNotValid() { }
        public override void PrepareEmit() { }
        public override void WriteDebugSymbol(Mono.CompilerServices.SymbolWriter.MonoSymbolFile file) { }
    }
    public sealed partial class MethodSpec : Mono.CSharp.MemberSpec, Mono.CSharp.IInterfaceMemberSpec, Mono.CSharp.IParametersMember
    {
        public static readonly Mono.CSharp.MethodSpec Excluded;
        public MethodSpec(Mono.CSharp.MemberKind kind, Mono.CSharp.TypeSpec declaringType, Mono.CSharp.IMethodDefinition details, Mono.CSharp.TypeSpec returnType, Mono.CSharp.AParametersCollection parameters, Mono.CSharp.Modifiers modifiers) : base (default(Mono.CSharp.MemberKind), default(Mono.CSharp.TypeSpec), default(Mono.CSharp.IMemberDefinition), default(Mono.CSharp.Modifiers)) { }
        public override int Arity { get { throw null; } }
        public Mono.CSharp.TypeParameterSpec[] Constraints { get { throw null; } }
        public Mono.CSharp.IGenericMethodDefinition GenericDefinition { get { throw null; } }
        public bool IsAsync { get { throw null; } }
        public bool IsConstructor { get { throw null; } }
        public bool IsExtensionMethod { get { throw null; } }
        public bool IsReservedMethod { get { throw null; } }
        public bool IsSealed { get { throw null; } }
        public bool IsVirtual { get { throw null; } }
        public new Mono.CSharp.IMethodDefinition MemberDefinition { get { throw null; } }
        Mono.CSharp.TypeSpec Mono.CSharp.IInterfaceMemberSpec.MemberType { get { throw null; } }
        public Mono.CSharp.AParametersCollection Parameters { get { throw null; } }
        public Mono.CSharp.TypeSpec ReturnType { get { throw null; } }
        public Mono.CSharp.TypeSpec[] TypeArguments { get { throw null; } }
        public Mono.CSharp.MethodSpec GetGenericMethodDefinition() { throw null; }
        public System.Reflection.MethodBase GetMetaInfo() { throw null; }
        public override string GetSignatureForDocumentation() { throw null; }
        public override string GetSignatureForError() { throw null; }
        public override Mono.CSharp.MemberSpec InflateMember(Mono.CSharp.TypeParameterInflator inflator) { throw null; }
        public Mono.CSharp.MethodSpec MakeGenericMethod(Mono.CSharp.IMemberContext context, params Mono.CSharp.TypeSpec[] targs) { throw null; }
        public Mono.CSharp.MethodSpec Mutate(Mono.CSharp.TypeParameterMutator mutator) { throw null; }
        public override System.Collections.Generic.List<Mono.CSharp.MissingTypeSpecReference> ResolveMissingDependencies(Mono.CSharp.MemberSpec caller) { throw null; }
    }
    public partial class MissingTypeSpecReference
    {
        public MissingTypeSpecReference(Mono.CSharp.TypeSpec type, Mono.CSharp.MemberSpec caller) { }
        public Mono.CSharp.MemberSpec Caller { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        public Mono.CSharp.TypeSpec Type { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
    }
    [System.FlagsAttribute]
    public enum Modifiers
    {
        ABSTRACT = 32,
        AccessibilityMask = 15,
        AllowedExplicitImplFlags = 10240,
        ASYNC = 16384,
        AutoProperty = 16777216,
        BACKING_FIELD = 2097152,
        COMPILER_GENERATED = 1048576,
        DEBUGGER_HIDDEN = 4194304,
        DEBUGGER_STEP_THROUGH = 8388608,
        DEFAULT_ACCESS_MODIFIER = 262144,
        EXTERN = 2048,
        INTERNAL = 8,
        METHOD_EXTENSION = 524288,
        NEW = 16,
        OVERRIDE = 1024,
        PARTIAL = 131072,
        PRIVATE = 4,
        PROPERTY_CUSTOM = 65536,
        PROTECTED = 1,
        PUBLIC = 2,
        READONLY = 256,
        SEALED = 64,
        STATIC = 128,
        TOP = 32768,
        UNSAFE = 8192,
        VIRTUAL = 512,
        VOLATILE = 4096,
    }
    public sealed partial class ModuleContainer : Mono.CSharp.TypeContainer
    {
        public System.Nullable<System.Runtime.InteropServices.CharSet> DefaultCharSet;
        public System.Reflection.TypeAttributes DefaultCharSetType;
        public Mono.CSharp.Binary.PredefinedOperator[] OperatorsBinaryEqualityLifted;
        public Mono.CSharp.Binary.PredefinedOperator[] OperatorsBinaryLifted;
        public ModuleContainer(Mono.CSharp.CompilerContext context) : base (default(Mono.CSharp.TypeContainer), default(Mono.CSharp.MemberName), default(Mono.CSharp.Attributes), default(Mono.CSharp.MemberKind)) { }
        public override System.AttributeTargets AttributeTargets { get { throw null; } }
        public System.Reflection.Emit.ModuleBuilder Builder { get { throw null; } }
        public override Mono.CSharp.CompilerContext Compiler { get { throw null; } }
        public int CounterAnonymousTypes { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public Mono.CSharp.AssemblyDefinition DeclaringAssembly { get { throw null; } }
        public override string DocCommentHeader { get { throw null; } }
        public Mono.CSharp.Evaluator Evaluator { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public System.Collections.Generic.Dictionary<string, string> GetResourceStrings { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        public Mono.CSharp.RootNamespace GlobalRootNamespace { get { throw null; } }
        public bool HasDefaultCharSet { get { throw null; } }
        public bool HasExtensionMethod { get { throw null; } set { } }
        public bool HasTypesFullyDefined { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public override Mono.CSharp.ModuleContainer Module { get { throw null; } }
        public override string[] ValidAttributeTargets { get { throw null; } }
        public override void Accept(Mono.CSharp.StructuralVisitor visitor) { }
        public void AddAnonymousType(Mono.CSharp.AnonymousTypeClass type) { }
        public void AddAttribute(Mono.CSharp.Attribute attr, Mono.CSharp.IMemberContext context) { }
        public override void AddTypeContainer(Mono.CSharp.TypeContainer tc) { }
        public override void ApplyAttributeBuilder(Mono.CSharp.Attribute a, Mono.CSharp.MethodSpec ctor, byte[] cdata, Mono.CSharp.PredefinedAttributes pa) { }
        public override void CloseContainer() { }
        public void Create(Mono.CSharp.AssemblyDefinition assembly, System.Reflection.Emit.ModuleBuilder moduleBuilder) { }
        public System.Reflection.Emit.TypeBuilder CreateBuilder(string name, System.Reflection.TypeAttributes attr, int typeSize) { throw null; }
        public Mono.CSharp.ModuleContainer.PatternMatchingHelper CreatePatterMatchingHelper() { throw null; }
        public Mono.CSharp.RootNamespace CreateRootNamespace(string alias) { throw null; }
        public override bool Define() { throw null; }
        public override bool DefineContainer() { throw null; }
        public override void EmitContainer() { }
        public void EnableRedefinition() { }
        public Mono.CSharp.AnonymousTypeClass GetAnonymousType(System.Collections.Generic.IList<Mono.CSharp.AnonymousTypeParameter> parameters) { throw null; }
        public Mono.CSharp.AwaiterDefinition GetAwaiter(Mono.CSharp.TypeSpec type) { throw null; }
        public override void GetCompletionStartingWith(string prefix, System.Collections.Generic.List<string> results) { }
        public Mono.CSharp.Binary.PredefinedOperator[] GetPredefinedEnumAritmeticOperators(Mono.CSharp.TypeSpec enumType, bool nullable) { throw null; }
        public Mono.CSharp.RootNamespace GetRootNamespace(string name) { throw null; }
        public override string GetSignatureForError() { throw null; }
        public void InitializePredefinedTypes() { }
        public override bool IsClsComplianceRequired() { throw null; }
        public void LoadGetResourceStrings(System.Collections.Generic.List<string> fileNames) { }
        public Mono.CSharp.Attribute ResolveAssemblyAttribute(Mono.CSharp.PredefinedAttribute a_type) { throw null; }
        public void SetDeclaringAssembly(Mono.CSharp.AssemblyDefinition assembly) { }
        public sealed partial class PatternMatchingHelper : Mono.CSharp.CompilerGeneratedContainer
        {
            public PatternMatchingHelper(Mono.CSharp.ModuleContainer module) : base (default(Mono.CSharp.TypeContainer), default(Mono.CSharp.MemberName), default(Mono.CSharp.Modifiers)) { }
            public Mono.CSharp.Method NumberMatcher { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
            protected override bool DoDefineMembers() { throw null; }
        }
    }
    public partial class MovableArgument : Mono.CSharp.Argument
    {
        public MovableArgument(Mono.CSharp.Argument arg) : base (default(Mono.CSharp.Expression), default(Mono.CSharp.Argument.AType)) { }
        protected MovableArgument(Mono.CSharp.Expression expr, Mono.CSharp.Argument.AType modifier) : base (default(Mono.CSharp.Expression), default(Mono.CSharp.Argument.AType)) { }
        public override void Emit(Mono.CSharp.EmitContext ec) { }
        public void EmitToVariable(Mono.CSharp.EmitContext ec) { }
    }
    public partial class NamedArgument : Mono.CSharp.MovableArgument
    {
        public readonly string Name;
        public NamedArgument(string name, Mono.CSharp.Location loc, Mono.CSharp.Expression expr) : base (default(Mono.CSharp.Argument)) { }
        public NamedArgument(string name, Mono.CSharp.Location loc, Mono.CSharp.Expression expr, Mono.CSharp.Argument.AType modifier) : base (default(Mono.CSharp.Argument)) { }
        public Mono.CSharp.Location Location { get { throw null; } }
        public override Mono.CSharp.Expression CreateExpressionTree(Mono.CSharp.ResolveContext ec) { throw null; }
    }
    public partial class NamedTupleSpec : Mono.CSharp.TypeSpec
    {
        internal NamedTupleSpec() : base (default(Mono.CSharp.MemberKind), default(Mono.CSharp.TypeSpec), default(Mono.CSharp.ITypeDefinition), default(System.Type), default(Mono.CSharp.Modifiers)) { }
        public System.Collections.Generic.IList<string> Elements { get { throw null; } }
        public override Mono.CSharp.TypeSpec[] TypeArguments { get { throw null; } }
        public static bool CheckOverrideName(Mono.CSharp.IParametersMember member, Mono.CSharp.IParametersMember baseMember) { throw null; }
        public static bool CheckOverrideName(Mono.CSharp.TypeSpec type, Mono.CSharp.TypeSpec baseType) { throw null; }
        public Mono.CSharp.MemberSpec FindElement(Mono.CSharp.IMemberContext mc, string name, Mono.CSharp.Location loc) { throw null; }
        public static string GetElementPropertyName(int index) { throw null; }
        public override System.Type GetMetaInfo() { throw null; }
        public override string GetSignatureForError() { throw null; }
        public string GetSignatureForErrorWithNames() { throw null; }
        protected override void InitializeMemberCache(bool onlyTypes) { }
        public static Mono.CSharp.NamedTupleSpec MakeType(Mono.CSharp.ModuleContainer module, Mono.CSharp.InflatedTypeSpec tupleType, System.Collections.Generic.IList<string> names) { throw null; }
    }
    public partial class Namespace
    {
        protected System.Collections.Generic.Dictionary<string, Mono.CSharp.Namespace> namespaces;
        protected System.Collections.Generic.Dictionary<string, System.Collections.Generic.IList<Mono.CSharp.TypeSpec>> types;
        protected Namespace() { }
        public Namespace(Mono.CSharp.Namespace parent, string name) { }
        public string Name { get { throw null; } }
        public Mono.CSharp.Namespace Parent { get { throw null; } }
        public Mono.CSharp.Namespace AddNamespace(Mono.CSharp.MemberName name) { throw null; }
        public void AddType(Mono.CSharp.ModuleContainer module, Mono.CSharp.TypeSpec ts) { }
        public System.Collections.Generic.IEnumerable<string> CompletionGetTypesStartingWith(string prefix) { throw null; }
        public System.Collections.Generic.IList<Mono.CSharp.TypeSpec> GetAllTypes(string name) { throw null; }
        public Mono.CSharp.Namespace GetNamespace(string name, bool create) { throw null; }
        public virtual string GetSignatureForError() { throw null; }
        public static Mono.CSharp.TypeSpec IsImportedTypeOverride(Mono.CSharp.ModuleContainer module, Mono.CSharp.TypeSpec ts, Mono.CSharp.TypeSpec found) { throw null; }
        public System.Collections.Generic.List<Mono.CSharp.MethodSpec> LookupExtensionMethod(Mono.CSharp.IMemberContext invocationContext, string name, int arity) { throw null; }
        public Mono.CSharp.TypeSpec LookupType(Mono.CSharp.IMemberContext ctx, string name, int arity, Mono.CSharp.LookupMode mode, Mono.CSharp.Location loc) { throw null; }
        public Mono.CSharp.FullNamedExpression LookupTypeOrNamespace(Mono.CSharp.IMemberContext ctx, string name, int arity, Mono.CSharp.LookupMode mode, Mono.CSharp.Location loc) { throw null; }
        public void RemoveContainer(Mono.CSharp.TypeContainer tc) { }
        public void SetBuiltinType(Mono.CSharp.BuiltinTypeSpec pts) { }
        public bool TryGetNamespace(string name, out Mono.CSharp.Namespace ns) { ns = default(Mono.CSharp.Namespace); throw null; }
        public void VerifyClsCompliance() { }
    }
    public partial class NamespaceContainer : Mono.CSharp.TypeContainer, Mono.CSharp.IMemberContext, Mono.CSharp.IModuleContext
    {
        public bool DeclarationFound;
        public readonly new Mono.CSharp.NamespaceContainer Parent;
        public NamespaceContainer(Mono.CSharp.MemberName name, Mono.CSharp.NamespaceContainer parent) : base (default(Mono.CSharp.TypeContainer), default(Mono.CSharp.MemberName), default(Mono.CSharp.Attributes), default(Mono.CSharp.MemberKind)) { }
        protected NamespaceContainer(Mono.CSharp.ModuleContainer parent) : base (default(Mono.CSharp.TypeContainer), default(Mono.CSharp.MemberName), default(Mono.CSharp.Attributes), default(Mono.CSharp.MemberKind)) { }
        public override System.AttributeTargets AttributeTargets { get { throw null; } }
        public override string DocCommentHeader { get { throw null; } }
        public Mono.CSharp.Namespace NS { get { throw null; } }
        public System.Collections.Generic.List<Mono.CSharp.UsingClause> Usings { get { throw null; } }
        public override string[] ValidAttributeTargets { get { throw null; } }
        public override void Accept(Mono.CSharp.StructuralVisitor visitor) { }
        public override void AddPartial(Mono.CSharp.TypeDefinition next_part) { }
        public override void AddTypeContainer(Mono.CSharp.TypeContainer tc) { }
        public void AddUsing(Mono.CSharp.UsingAliasNamespace un) { }
        public void AddUsing(Mono.CSharp.UsingClause un) { }
        public override void ApplyAttributeBuilder(Mono.CSharp.Attribute a, Mono.CSharp.MethodSpec ctor, byte[] cdata, Mono.CSharp.PredefinedAttributes pa) { }
        protected override void DefineNamespace() { }
        protected override void DoDefineContainer() { }
        public override void EmitContainer() { }
        public void EnableRedefinition() { }
        public override void GetCompletionStartingWith(string prefix, System.Collections.Generic.List<string> results) { }
        public override string GetSignatureForError() { throw null; }
        public Mono.CSharp.ExtensionMethodCandidates LookupExtensionMethod(Mono.CSharp.IMemberContext invocationContext, string name, int arity, int position) { throw null; }
        public Mono.CSharp.FullNamedExpression LookupExternAlias(string name) { throw null; }
        public override Mono.CSharp.FullNamedExpression LookupNamespaceAlias(string name) { throw null; }
        public override Mono.CSharp.FullNamedExpression LookupNamespaceOrType(string name, int arity, Mono.CSharp.LookupMode mode, Mono.CSharp.Location loc) { throw null; }
        public static Mono.CSharp.Expression LookupStaticUsings(Mono.CSharp.IMemberContext mc, string name, int arity, Mono.CSharp.Location loc) { throw null; }
        public override void RemoveContainer(Mono.CSharp.TypeContainer cont) { }
        protected override bool VerifyClsCompliance() { throw null; }
    }
    public partial class NamespaceExpression : Mono.CSharp.FullNamedExpression
    {
        public NamespaceExpression(Mono.CSharp.Namespace ns, Mono.CSharp.Location loc) { }
        public Mono.CSharp.Namespace Namespace { get { throw null; } }
        protected override Mono.CSharp.Expression DoResolve(Mono.CSharp.ResolveContext rc) { throw null; }
        public void Error_NamespaceDoesNotExist(Mono.CSharp.IMemberContext ctx, string name, int arity, Mono.CSharp.Location loc) { }
        public override string GetSignatureForError() { throw null; }
        public Mono.CSharp.FullNamedExpression LookupTypeOrNamespace(Mono.CSharp.IMemberContext ctx, string name, int arity, Mono.CSharp.LookupMode mode, Mono.CSharp.Location loc) { throw null; }
        public override Mono.CSharp.FullNamedExpression ResolveAsTypeOrNamespace(Mono.CSharp.IMemberContext mc, bool allowUnboundTypeArguments) { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class New : Mono.CSharp.ExpressionStatement, Mono.CSharp.IMemoryLocation
    {
        protected Mono.CSharp.Arguments arguments;
        protected Mono.CSharp.MethodSpec method;
        protected Mono.CSharp.Expression RequestedType;
        public New(Mono.CSharp.Expression requested_type, Mono.CSharp.Arguments arguments, Mono.CSharp.Location l) { }
        public Mono.CSharp.Arguments Arguments { get { throw null; } }
        public bool IsGeneratedStructConstructor { get { throw null; } }
        public Mono.CSharp.Expression TypeExpression { get { throw null; } }
        public override object Accept(Mono.CSharp.StructuralVisitor visitor) { throw null; }
        public void AddressOf(Mono.CSharp.EmitContext ec, Mono.CSharp.AddressOp mode) { }
        public virtual bool CanEmitOptimizedLocalTarget(Mono.CSharp.EmitContext ec) { throw null; }
        public Mono.CSharp.Expression CheckComImport(Mono.CSharp.ResolveContext ec) { throw null; }
        protected override void CloneTo(Mono.CSharp.CloneContext clonectx, Mono.CSharp.Expression t) { }
        public static Mono.CSharp.Constant Constantify(Mono.CSharp.TypeSpec t, Mono.CSharp.Location loc) { throw null; }
        public override bool ContainsEmitWithAwait() { throw null; }
        public override Mono.CSharp.Expression CreateExpressionTree(Mono.CSharp.ResolveContext ec) { throw null; }
        protected override Mono.CSharp.Expression DoResolve(Mono.CSharp.ResolveContext ec) { throw null; }
        public override void Emit(Mono.CSharp.EmitContext ec) { }
        public virtual bool Emit(Mono.CSharp.EmitContext ec, Mono.CSharp.IMemoryLocation target) { throw null; }
        protected virtual Mono.CSharp.IMemoryLocation EmitAddressOf(Mono.CSharp.EmitContext ec, Mono.CSharp.AddressOp mode) { throw null; }
        public override void EmitStatement(Mono.CSharp.EmitContext ec) { }
        public override void FlowAnalysis(Mono.CSharp.FlowAnalysisContext fc) { }
        public override System.Linq.Expressions.Expression MakeExpression(Mono.CSharp.BuilderContext ctx) { throw null; }
    }
    public partial class NewAnonymousType : Mono.CSharp.New
    {
        public NewAnonymousType(System.Collections.Generic.List<Mono.CSharp.AnonymousTypeParameter> parameters, Mono.CSharp.TypeContainer parent, Mono.CSharp.Location loc) : base (default(Mono.CSharp.Expression), default(Mono.CSharp.Arguments), default(Mono.CSharp.Location)) { }
        public System.Collections.Generic.List<Mono.CSharp.AnonymousTypeParameter> Parameters { get { throw null; } }
        public override object Accept(Mono.CSharp.StructuralVisitor visitor) { throw null; }
        protected override void CloneTo(Mono.CSharp.CloneContext clonectx, Mono.CSharp.Expression target) { }
        public override Mono.CSharp.Expression CreateExpressionTree(Mono.CSharp.ResolveContext ec) { throw null; }
        protected override Mono.CSharp.Expression DoResolve(Mono.CSharp.ResolveContext ec) { throw null; }
    }
    public partial class NewDelegate : Mono.CSharp.DelegateCreation
    {
        public Mono.CSharp.Arguments Arguments;
        public NewDelegate(Mono.CSharp.TypeSpec type, Mono.CSharp.Arguments Arguments, Mono.CSharp.Location loc) { }
        protected override Mono.CSharp.Expression DoResolve(Mono.CSharp.ResolveContext ec) { throw null; }
    }
    public partial class NewInitialize : Mono.CSharp.New
    {
        public NewInitialize(Mono.CSharp.FullNamedExpression requested_type, Mono.CSharp.Arguments arguments, Mono.CSharp.CollectionOrObjectInitializers initializers, Mono.CSharp.Location l) : base (default(Mono.CSharp.Expression), default(Mono.CSharp.Arguments), default(Mono.CSharp.Location)) { }
        public Mono.CSharp.CollectionOrObjectInitializers Initializers { get { throw null; } }
        public override object Accept(Mono.CSharp.StructuralVisitor visitor) { throw null; }
        public override bool CanEmitOptimizedLocalTarget(Mono.CSharp.EmitContext ec) { throw null; }
        protected override void CloneTo(Mono.CSharp.CloneContext clonectx, Mono.CSharp.Expression t) { }
        public override bool ContainsEmitWithAwait() { throw null; }
        public override Mono.CSharp.Expression CreateExpressionTree(Mono.CSharp.ResolveContext ec) { throw null; }
        protected override Mono.CSharp.Expression DoResolve(Mono.CSharp.ResolveContext rc) { throw null; }
        public override void Emit(Mono.CSharp.EmitContext ec) { }
        public override bool Emit(Mono.CSharp.EmitContext ec, Mono.CSharp.IMemoryLocation target) { throw null; }
        protected override Mono.CSharp.IMemoryLocation EmitAddressOf(Mono.CSharp.EmitContext ec, Mono.CSharp.AddressOp Mode) { throw null; }
        public override void FlowAnalysis(Mono.CSharp.FlowAnalysisContext fc) { }
    }
    public partial class NullConstant : Mono.CSharp.Constant
    {
        public NullConstant(Mono.CSharp.TypeSpec type, Mono.CSharp.Location loc) : base (default(Mono.CSharp.Location)) { }
        public override string ExprClassName { get { throw null; } }
        public override bool IsDefaultValue { get { throw null; } }
        public override bool IsNegative { get { throw null; } }
        public override bool IsNull { get { throw null; } }
        public override bool IsZeroInteger { get { throw null; } }
        public override Mono.CSharp.Constant ConvertExplicitly(bool inCheckedContext, Mono.CSharp.TypeSpec targetType) { throw null; }
        public override Mono.CSharp.Constant ConvertImplicitly(Mono.CSharp.TypeSpec targetType) { throw null; }
        public override Mono.CSharp.Expression CreateExpressionTree(Mono.CSharp.ResolveContext ec) { throw null; }
        public override void Emit(Mono.CSharp.EmitContext ec) { }
        public override void EncodeAttributeValue(Mono.CSharp.IMemberContext rc, Mono.CSharp.AttributeEncoder enc, Mono.CSharp.TypeSpec targetType, Mono.CSharp.TypeSpec parameterType) { }
        public override string GetSignatureForError() { throw null; }
        public override object GetValue() { throw null; }
        public override string GetValueAsLiteral() { throw null; }
        public override long GetValueAsLong() { throw null; }
    }
    public partial class NullLiteral : Mono.CSharp.NullConstant
    {
        public NullLiteral(Mono.CSharp.Location loc) : base (default(Mono.CSharp.TypeSpec), default(Mono.CSharp.Location)) { }
        public override bool IsLiteral { get { throw null; } }
        public override void Error_ValueCannotBeConverted(Mono.CSharp.ResolveContext ec, Mono.CSharp.TypeSpec t, bool expl) { }
        public override string GetValueAsLiteral() { throw null; }
        public override System.Linq.Expressions.Expression MakeExpression(Mono.CSharp.BuilderContext ctx) { throw null; }
    }
    public partial class Operator : Mono.CSharp.MethodOrOperator
    {
        public readonly Mono.CSharp.Operator.OpType OperatorType;
        public Operator(Mono.CSharp.TypeDefinition parent, Mono.CSharp.Operator.OpType type, Mono.CSharp.FullNamedExpression ret_type, Mono.CSharp.Modifiers mod_flags, Mono.CSharp.ParametersCompiled parameters, Mono.CSharp.ToplevelBlock block, Mono.CSharp.Attributes attrs, Mono.CSharp.Location loc) : base (default(Mono.CSharp.TypeDefinition), default(Mono.CSharp.FullNamedExpression), default(Mono.CSharp.Modifiers), default(Mono.CSharp.Modifiers), default(Mono.CSharp.MemberName), default(Mono.CSharp.Attributes), default(Mono.CSharp.ParametersCompiled)) { }
        public override void Accept(Mono.CSharp.StructuralVisitor visitor) { }
        public override void ApplyAttributeBuilder(Mono.CSharp.Attribute a, Mono.CSharp.MethodSpec ctor, byte[] cdata, Mono.CSharp.PredefinedAttributes pa) { }
        public override bool Define() { throw null; }
        protected override Mono.CSharp.MemberSpec FindBaseMember(out Mono.CSharp.MemberSpec bestCandidate, ref bool overrides) { bestCandidate = default(Mono.CSharp.MemberSpec); throw null; }
        public Mono.CSharp.Operator.OpType GetMatchingOperator() { throw null; }
        public static string GetMetadataName(Mono.CSharp.Operator.OpType ot) { throw null; }
        public static string GetMetadataName(string name) { throw null; }
        public static string GetName(Mono.CSharp.Operator.OpType ot) { throw null; }
        public static string GetName(string metadata_name) { throw null; }
        public override string GetSignatureForDocumentation() { throw null; }
        public override string GetSignatureForError() { throw null; }
        public static System.Nullable<Mono.CSharp.Operator.OpType> GetType(string metadata_name) { throw null; }
        protected override bool ResolveMemberType() { throw null; }
        public enum OpType : byte
        {
            Addition = (byte)6,
            BitwiseAnd = (byte)13,
            BitwiseOr = (byte)14,
            Decrement = (byte)3,
            Division = (byte)11,
            Equality = (byte)18,
            ExclusiveOr = (byte)15,
            Explicit = (byte)25,
            False = (byte)5,
            GreaterThan = (byte)20,
            GreaterThanOrEqual = (byte)22,
            Implicit = (byte)24,
            Increment = (byte)2,
            Inequality = (byte)19,
            Is = (byte)26,
            LeftShift = (byte)16,
            LessThan = (byte)21,
            LessThanOrEqual = (byte)23,
            LogicalNot = (byte)0,
            Modulus = (byte)12,
            Multiply = (byte)10,
            OnesComplement = (byte)1,
            RightShift = (byte)17,
            Subtraction = (byte)7,
            TOP = (byte)27,
            True = (byte)4,
            UnaryNegation = (byte)9,
            UnaryPlus = (byte)8,
        }
    }
    public partial class OperatorCast : Mono.CSharp.TypeCast
    {
        public OperatorCast(Mono.CSharp.Expression expr, Mono.CSharp.TypeSpec target_type) : base (default(Mono.CSharp.Expression), default(Mono.CSharp.TypeSpec)) { }
        public OperatorCast(Mono.CSharp.Expression expr, Mono.CSharp.TypeSpec declaringType, Mono.CSharp.TypeSpec returnType, bool isExplicit) : base (default(Mono.CSharp.Expression), default(Mono.CSharp.TypeSpec)) { }
        public OperatorCast(Mono.CSharp.Expression expr, Mono.CSharp.TypeSpec target_type, bool find_explicit) : base (default(Mono.CSharp.Expression), default(Mono.CSharp.TypeSpec)) { }
        public override void Emit(Mono.CSharp.EmitContext ec) { }
    }
    public partial class Outline
    {
        public Outline(System.Type t, System.IO.TextWriter output, bool declared_only, bool show_private, bool filter_obsolete) { }
        public void OutlineType() { }
        public static string RemoveGenericArity(string name) { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public partial struct OverloadResolver
    {
        public OverloadResolver(System.Collections.Generic.IList<Mono.CSharp.MemberSpec> members, Mono.CSharp.OverloadResolver.Restrictions restrictions, Mono.CSharp.Location loc) { throw null;}
        public OverloadResolver(System.Collections.Generic.IList<Mono.CSharp.MemberSpec> members, Mono.CSharp.TypeArguments targs, Mono.CSharp.OverloadResolver.Restrictions restrictions, Mono.CSharp.Location loc) { throw null;}
        public Mono.CSharp.OverloadResolver.IBaseMembersProvider BaseMembersProvider { get { throw null; } set { } }
        public bool BestCandidateIsDynamic { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public Mono.CSharp.MethodGroupExpr BestCandidateNewMethodGroup { get { throw null; } }
        public Mono.CSharp.TypeSpec BestCandidateReturnType { get { throw null; } }
        public Mono.CSharp.OverloadResolver.IErrorHandler CustomErrors { get { throw null; } set { } }
        public Mono.CSharp.OverloadResolver.IInstanceQualifier InstanceQualifier { get { throw null; } set { } }
        public static int BetterTypeConversion(Mono.CSharp.ResolveContext ec, Mono.CSharp.TypeSpec p, Mono.CSharp.TypeSpec q) { throw null; }
        public static void Error_ConstructorMismatch(Mono.CSharp.ResolveContext rc, Mono.CSharp.TypeSpec type, int argCount, Mono.CSharp.Location loc) { }
        public static Mono.CSharp.Expression ResolveDefaultValueArgument(Mono.CSharp.ResolveContext ec, Mono.CSharp.TypeSpec ptype, Mono.CSharp.Expression e, Mono.CSharp.Location loc) { throw null; }
        public T ResolveMember<T>(Mono.CSharp.ResolveContext rc, ref Mono.CSharp.Arguments args) where T : Mono.CSharp.MemberSpec, Mono.CSharp.IParametersMember { throw null; }
        public Mono.CSharp.MethodSpec ResolveOperator(Mono.CSharp.ResolveContext rc, ref Mono.CSharp.Arguments args) { throw null; }
        public partial interface IBaseMembersProvider
        {
            System.Collections.Generic.IList<Mono.CSharp.MemberSpec> GetBaseMembers(Mono.CSharp.TypeSpec baseType);
            Mono.CSharp.IParametersMember GetOverrideMemberParameters(Mono.CSharp.MemberSpec member);
            Mono.CSharp.MethodGroupExpr LookupExtensionMethod(Mono.CSharp.ResolveContext rc);
        }
        public partial interface IErrorHandler
        {
            bool AmbiguousCandidates(Mono.CSharp.ResolveContext rc, Mono.CSharp.MemberSpec best, Mono.CSharp.MemberSpec ambiguous);
            bool ArgumentMismatch(Mono.CSharp.ResolveContext rc, Mono.CSharp.MemberSpec best, Mono.CSharp.Argument a, int index);
            bool NoArgumentMatch(Mono.CSharp.ResolveContext rc, Mono.CSharp.MemberSpec best);
            bool TypeInferenceFailed(Mono.CSharp.ResolveContext rc, Mono.CSharp.MemberSpec best);
        }
        public partial interface IInstanceQualifier
        {
            Mono.CSharp.TypeSpec InstanceType { get; }
            bool CheckProtectedMemberAccess(Mono.CSharp.ResolveContext rc, Mono.CSharp.MemberSpec member);
        }
        [System.FlagsAttribute]
        public enum Restrictions
        {
            BaseMembersIncluded = 16,
            CovariantDelegate = 4,
            DelegateInvoke = 1,
            GetEnumeratorLookup = 32,
            NoBaseMembers = 8,
            None = 0,
            ProbingOnly = 2,
        }
    }
    public partial class Parameter : Mono.CSharp.ParameterBase, Mono.CSharp.ILocalVariable, Mono.CSharp.IParameterData
    {
        public bool HasAddressTaken;
        protected int idx;
        protected Mono.CSharp.TypeSpec parameter_type;
        public Parameter(Mono.CSharp.FullNamedExpression type, string name, Mono.CSharp.Parameter.Modifier mod, Mono.CSharp.Attributes attrs, Mono.CSharp.Location loc) { }
        public override System.AttributeTargets AttributeTargets { get { throw null; } }
        public Mono.CSharp.Expression DefaultExpression { get { throw null; } }
        public Mono.CSharp.DefaultParameterValueExpression DefaultValue { get { throw null; } set { } }
        public bool HasDefaultValue { get { throw null; } }
        public bool HasExtensionMethodModifier { get { throw null; } }
        public Mono.CSharp.HoistedParameter HoistedVariant { get { throw null; } set { } }
        public Mono.CSharp.Location Location { get { throw null; } }
        public Mono.CSharp.Parameter.Modifier ModFlags { get { throw null; } }
        Mono.CSharp.Expression Mono.CSharp.IParameterData.DefaultValue { get { throw null; } }
        public string Name { get { throw null; } set { } }
        public Mono.CSharp.Parameter.Modifier ParameterModifier { get { throw null; } }
        public Mono.CSharp.TypeSpec Type { get { throw null; } set { } }
        public Mono.CSharp.FullNamedExpression TypeExpression { get { throw null; } }
        public override string[] ValidAttributeTargets { get { throw null; } }
        public override void ApplyAttributeBuilder(Mono.CSharp.Attribute a, Mono.CSharp.MethodSpec ctor, byte[] cdata, Mono.CSharp.PredefinedAttributes pa) { }
        public virtual void ApplyAttributes(System.Reflection.Emit.MethodBuilder mb, System.Reflection.Emit.ConstructorBuilder cb, int index, Mono.CSharp.PredefinedAttributes pa) { }
        public virtual bool CheckAccessibility(Mono.CSharp.InterfaceMemberBase member) { throw null; }
        public Mono.CSharp.Parameter Clone() { throw null; }
        public Mono.CSharp.ExpressionStatement CreateExpressionTreeVariable(Mono.CSharp.BlockContext ec) { throw null; }
        public void Emit(Mono.CSharp.EmitContext ec) { }
        public void EmitAddressOf(Mono.CSharp.EmitContext ec) { }
        public void EmitAssign(Mono.CSharp.EmitContext ec) { }
        public void Error_DuplicateName(Mono.CSharp.Report r) { }
        public Mono.CSharp.TemporaryVariableReference ExpressionTreeVariableReference() { throw null; }
        public static string GetModifierSignature(Mono.CSharp.Parameter.Modifier mod) { throw null; }
        public virtual string GetSignatureForError() { throw null; }
        public void IsClsCompliant(Mono.CSharp.IMemberContext ctx) { }
        public virtual Mono.CSharp.TypeSpec Resolve(Mono.CSharp.IMemberContext rc, int index) { throw null; }
        public void ResolveDefaultValue(Mono.CSharp.ResolveContext rc) { }
        public static Mono.CSharp.TypeExpr ResolveParameterExpressionType(Mono.CSharp.IMemberContext ec, Mono.CSharp.Location location) { throw null; }
        public void SetIndex(int index) { }
        public void Warning_UselessOptionalParameter(Mono.CSharp.Report Report) { }
        [System.FlagsAttribute]
        public enum Modifier : byte
        {
            CallerFilePath = (byte)64,
            CallerLineNumber = (byte)32,
            CallerMask = (byte)112,
            CallerMemberName = (byte)16,
            ModifierMask = (byte)15,
            NONE = (byte)0,
            OUT = (byte)4,
            PARAMS = (byte)1,
            REF = (byte)2,
            RefOutMask = (byte)6,
            This = (byte)8,
        }
    }
    public abstract partial class ParameterBase : Mono.CSharp.Attributable
    {
        protected System.Reflection.Emit.ParameterBuilder builder;
        protected ParameterBase() { }
        public System.Reflection.Emit.ParameterBuilder Builder { get { throw null; } }
        public override void ApplyAttributeBuilder(Mono.CSharp.Attribute a, Mono.CSharp.MethodSpec ctor, byte[] cdata, Mono.CSharp.PredefinedAttributes pa) { }
        public override bool IsClsComplianceRequired() { throw null; }
    }
    public partial class ParameterData : Mono.CSharp.IParameterData
    {
        public ParameterData(string name, Mono.CSharp.Parameter.Modifier modifiers) { }
        public ParameterData(string name, Mono.CSharp.Parameter.Modifier modifiers, Mono.CSharp.Expression defaultValue) { }
        public Mono.CSharp.Expression DefaultValue { get { throw null; } }
        public bool HasDefaultValue { get { throw null; } }
        public bool HasExtensionMethodModifier { get { throw null; } }
        public Mono.CSharp.Parameter.Modifier ModFlags { get { throw null; } }
        public string Name { get { throw null; } }
    }
    public partial class ParameterReference : Mono.CSharp.VariableReference
    {
        protected Mono.CSharp.ParametersBlock.ParameterInfo pi;
        public ParameterReference(Mono.CSharp.ParametersBlock.ParameterInfo pi, Mono.CSharp.Location loc) { }
        public override bool IsFixed { get { throw null; } }
        public override bool IsLockedByStatement { get { throw null; } set { } }
        public override bool IsRef { get { throw null; } }
        public override string Name { get { throw null; } }
        public Mono.CSharp.Parameter Parameter { get { throw null; } }
        protected override Mono.CSharp.ILocalVariable Variable { get { throw null; } }
        public override Mono.CSharp.VariableInfo VariableInfo { get { throw null; } }
        public override void AddressOf(Mono.CSharp.EmitContext ec, Mono.CSharp.AddressOp mode) { }
        protected override void CloneTo(Mono.CSharp.CloneContext clonectx, Mono.CSharp.Expression target) { }
        public override Mono.CSharp.Expression CreateExpressionTree(Mono.CSharp.ResolveContext ec) { throw null; }
        protected override Mono.CSharp.Expression DoResolve(Mono.CSharp.ResolveContext ec) { throw null; }
        public override Mono.CSharp.Expression DoResolveLValue(Mono.CSharp.ResolveContext ec, Mono.CSharp.Expression right_side) { throw null; }
        public override bool Equals(object obj) { throw null; }
        public override void FlowAnalysis(Mono.CSharp.FlowAnalysisContext fc) { }
        public override int GetHashCode() { throw null; }
        public override Mono.CSharp.HoistedVariable GetHoistedVariable(Mono.CSharp.AnonymousExpression ae) { throw null; }
        public override void SetHasAddressTaken() { }
    }
    public partial class ParametersBlock : Mono.CSharp.ExplicitBlock
    {
        protected System.Collections.Generic.Dictionary<string, object> labels;
        protected Mono.CSharp.ParametersCompiled parameters;
        protected Mono.CSharp.ParametersBlock.ParameterInfo[] parameter_info;
        protected bool resolved;
        protected Mono.CSharp.StateMachine state_machine;
        protected Mono.CSharp.ToplevelBlock top_block;
        public ParametersBlock(Mono.CSharp.Block parent, Mono.CSharp.ParametersCompiled parameters, Mono.CSharp.Location start, Mono.CSharp.Block.Flags flags=(Mono.CSharp.Block.Flags)(0)) : base (default(Mono.CSharp.Block), default(Mono.CSharp.Location), default(Mono.CSharp.Location)) { }
        protected ParametersBlock(Mono.CSharp.ParametersBlock source, Mono.CSharp.ParametersCompiled parameters) : base (default(Mono.CSharp.Block), default(Mono.CSharp.Location), default(Mono.CSharp.Location)) { }
        protected ParametersBlock(Mono.CSharp.ParametersCompiled parameters, Mono.CSharp.Location start) : base (default(Mono.CSharp.Block), default(Mono.CSharp.Location), default(Mono.CSharp.Location)) { }
        public bool HasReferenceToStoreyForInstanceLambdas { get { throw null; } set { } }
        public bool IsAsync { get { throw null; } set { } }
        public bool IsExpressionTree { get { throw null; } }
        public Mono.CSharp.ParametersCompiled Parameters { get { throw null; } }
        public bool Resolved { get { throw null; } }
        public Mono.CSharp.StateMachine StateMachine { get { throw null; } }
        public int TemporaryLocalsCount { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public Mono.CSharp.ToplevelBlock TopBlock { get { throw null; } set { } }
        public void CheckControlExit(Mono.CSharp.FlowAnalysisContext fc) { }
        public virtual void CheckControlExit(Mono.CSharp.FlowAnalysisContext fc, Mono.CSharp.DefiniteAssignmentBitSet dat) { }
        protected override void CloneTo(Mono.CSharp.CloneContext clonectx, Mono.CSharp.Statement t) { }
        public Mono.CSharp.ParametersBlock ConvertToAsyncTask(Mono.CSharp.IMemberContext context, Mono.CSharp.TypeDefinition host, Mono.CSharp.ParametersCompiled parameters, Mono.CSharp.TypeSpec returnType, Mono.CSharp.TypeSpec delegateType, Mono.CSharp.Location loc) { throw null; }
        public Mono.CSharp.ToplevelBlock ConvertToIterator(Mono.CSharp.IMethodData method, Mono.CSharp.TypeDefinition host, Mono.CSharp.TypeSpec iterator_type, bool is_enumerable) { throw null; }
        public override Mono.CSharp.Expression CreateExpressionTree(Mono.CSharp.ResolveContext ec) { throw null; }
        protected override bool DoFlowAnalysis(Mono.CSharp.FlowAnalysisContext fc) { throw null; }
        public override void Emit(Mono.CSharp.EmitContext ec) { }
        public void EmitEmbedded(Mono.CSharp.EmitContext ec) { }
        public override int GetDebugSymbolScopeIndex() { throw null; }
        public Mono.CSharp.LabeledStatement GetLabel(string name, Mono.CSharp.Block block) { throw null; }
        public Mono.CSharp.ParametersBlock.ParameterInfo GetParameterInfo(Mono.CSharp.Parameter p) { throw null; }
        public Mono.CSharp.ParameterReference GetParameterReference(int index, Mono.CSharp.Location loc) { throw null; }
        public Mono.CSharp.Statement PerformClone(ref System.Collections.Generic.HashSet<Mono.CSharp.LocalVariable> undeclaredVariables) { throw null; }
        protected void ProcessParameters() { }
        public override bool Resolve(Mono.CSharp.BlockContext bc) { throw null; }
        public partial class ParameterInfo : Mono.CSharp.INamedBlockVariable
        {
            public Mono.CSharp.VariableInfo VariableInfo;
            public ParameterInfo(Mono.CSharp.ParametersBlock block, int index) { }
            public Mono.CSharp.ParametersBlock Block { get { throw null; } }
            public bool IsDeclared { get { throw null; } }
            public bool IsLocked { get { throw null; } set { } }
            public bool IsParameter { get { throw null; } }
            public Mono.CSharp.Location Location { get { throw null; } }
            Mono.CSharp.Block Mono.CSharp.INamedBlockVariable.Block { get { throw null; } }
            public Mono.CSharp.Parameter Parameter { get { throw null; } }
            public Mono.CSharp.TypeSpec ParameterType { get { throw null; } }
            public Mono.CSharp.Expression CreateReferenceExpression(Mono.CSharp.ResolveContext rc, Mono.CSharp.Location loc) { throw null; }
        }
    }
    public partial class ParametersCompiled : Mono.CSharp.AParametersCollection
    {
        public static readonly Mono.CSharp.ParametersCompiled EmptyReadOnlyParameters;
        public static readonly Mono.CSharp.ParametersCompiled Undefined;
        public ParametersCompiled(params Mono.CSharp.Parameter[] parameters) { }
        public ParametersCompiled(Mono.CSharp.Parameter[] parameters, bool has_arglist) { }
        public Mono.CSharp.Parameter this[int pos] { get { throw null; } }
        public void ApplyAttributes(Mono.CSharp.IMemberContext mc, System.Reflection.MethodBase builder) { }
        public void CheckConstraints(Mono.CSharp.IMemberContext mc) { }
        public void CheckParameters(Mono.CSharp.MemberCore member) { }
        public Mono.CSharp.ParametersCompiled Clone() { throw null; }
        public Mono.CSharp.Expression CreateExpressionTree(Mono.CSharp.BlockContext ec, Mono.CSharp.Location loc) { throw null; }
        public static Mono.CSharp.ParametersCompiled CreateFullyResolved(Mono.CSharp.Parameter p, Mono.CSharp.TypeSpec type) { throw null; }
        public static Mono.CSharp.ParametersCompiled CreateFullyResolved(Mono.CSharp.Parameter[] parameters, Mono.CSharp.TypeSpec[] types) { throw null; }
        public static Mono.CSharp.AParametersCollection CreateFullyResolved(params Mono.CSharp.TypeSpec[] types) { throw null; }
        public static Mono.CSharp.ParametersCompiled CreateImplicitParameter(Mono.CSharp.FullNamedExpression texpr, Mono.CSharp.Location loc) { throw null; }
        public static int IsSameClsSignature(Mono.CSharp.AParametersCollection a, Mono.CSharp.AParametersCollection b) { throw null; }
        public static Mono.CSharp.ParametersCompiled MergeGenerated(Mono.CSharp.CompilerContext ctx, Mono.CSharp.ParametersCompiled userParams, bool checkConflicts, Mono.CSharp.Parameter compilerParams, Mono.CSharp.TypeSpec compilerTypes) { throw null; }
        public static Mono.CSharp.ParametersCompiled MergeGenerated(Mono.CSharp.CompilerContext ctx, Mono.CSharp.ParametersCompiled userParams, bool checkConflicts, Mono.CSharp.Parameter[] compilerParams, Mono.CSharp.TypeSpec[] compilerTypes) { throw null; }
        public static Mono.CSharp.ParametersCompiled Prefix(Mono.CSharp.ParametersCompiled parameters, Mono.CSharp.Parameter p, Mono.CSharp.TypeSpec type) { throw null; }
        public bool Resolve(Mono.CSharp.IMemberContext ec) { throw null; }
        public void ResolveDefaultValues(Mono.CSharp.MemberCore m) { }
        public void VerifyClsCompliance(Mono.CSharp.IMemberContext ctx) { }
    }
    public partial class ParametersImported : Mono.CSharp.AParametersCollection
    {
        public ParametersImported(Mono.CSharp.IParameterData[] param, Mono.CSharp.TypeSpec[] types, bool hasParams) { }
        public ParametersImported(Mono.CSharp.IParameterData[] parameters, Mono.CSharp.TypeSpec[] types, bool hasArglist, bool hasParams) { }
    }
    public partial class ParamsParameter : Mono.CSharp.Parameter
    {
        public ParamsParameter(Mono.CSharp.FullNamedExpression type, string name, Mono.CSharp.Attributes attrs, Mono.CSharp.Location loc) : base (default(Mono.CSharp.FullNamedExpression), default(string), default(Mono.CSharp.Parameter.Modifier), default(Mono.CSharp.Attributes), default(Mono.CSharp.Location)) { }
        public override void ApplyAttributes(System.Reflection.Emit.MethodBuilder mb, System.Reflection.Emit.ConstructorBuilder cb, int index, Mono.CSharp.PredefinedAttributes pa) { }
        public override Mono.CSharp.TypeSpec Resolve(Mono.CSharp.IMemberContext ec, int index) { throw null; }
    }
    public partial class ParenthesizedExpression : Mono.CSharp.ShimExpression
    {
        public ParenthesizedExpression(Mono.CSharp.Expression expr, Mono.CSharp.Location loc) : base (default(Mono.CSharp.Expression)) { }
        public override object Accept(Mono.CSharp.StructuralVisitor visitor) { throw null; }
        protected override Mono.CSharp.Expression DoResolve(Mono.CSharp.ResolveContext rc) { throw null; }
        public override Mono.CSharp.Expression DoResolveLValue(Mono.CSharp.ResolveContext ec, Mono.CSharp.Expression right_side) { throw null; }
        public override bool HasConditionalAccess() { throw null; }
    }
    public partial class ParserSession
    {
        public readonly char[] IDBuilder;
        public readonly System.Collections.Generic.Dictionary<char[], string>[] Identifiers;
        public readonly char[] NumberBuilder;
        public readonly System.Collections.Generic.List<Mono.CSharp.Parameter> ParametersStack;
        public readonly char[] StreamReaderBuffer;
        public ParserSession() { }
        public Mono.CSharp.LocatedToken[] LocatedTokens { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public Mono.CSharp.LocationsBag LocationsBag { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public bool UseJayGlobalArrays { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public System.Security.Cryptography.MD5 GetChecksumAlgorithm() { throw null; }
    }
    public partial class PendingImplementation
    {
        internal PendingImplementation() { }
        public static Mono.CSharp.PendingImplementation GetPendingImplementations(Mono.CSharp.TypeDefinition container) { throw null; }
        public void ImplementMethod(Mono.CSharp.MemberName name, Mono.CSharp.TypeSpec ifaceType, Mono.CSharp.MethodData method, bool clear_one, out Mono.CSharp.MethodSpec ambiguousCandidate, ref bool optional) { ambiguousCandidate = default(Mono.CSharp.MethodSpec); }
        public Mono.CSharp.MethodSpec InterfaceMethod(Mono.CSharp.MemberName name, Mono.CSharp.TypeSpec iType, Mono.CSharp.MethodData method, Mono.CSharp.PendingImplementation.Operation op, out Mono.CSharp.MethodSpec ambiguousCandidate, ref bool optional) { ambiguousCandidate = default(Mono.CSharp.MethodSpec); throw null; }
        public Mono.CSharp.MethodSpec IsInterfaceMethod(Mono.CSharp.MemberName name, Mono.CSharp.TypeSpec ifaceType, Mono.CSharp.MethodData method, out Mono.CSharp.MethodSpec ambiguousCandidate, ref bool optional) { ambiguousCandidate = default(Mono.CSharp.MethodSpec); throw null; }
        public bool VerifyPendingMethods() { throw null; }
        public enum Operation
        {
            ClearAll = 2,
            ClearOne = 1,
            Lookup = 0,
        }
    }
    public enum Platform
    {
        AnyCPU = 0,
        AnyCPU32Preferred = 1,
        Arm = 2,
        IA64 = 5,
        X64 = 4,
        X86 = 3,
    }
    public partial class PointerArithmetic : Mono.CSharp.Expression
    {
        public PointerArithmetic(Mono.CSharp.Binary.Operator op, Mono.CSharp.Expression l, Mono.CSharp.Expression r, Mono.CSharp.TypeSpec t, Mono.CSharp.Location loc) { }
        public override bool ContainsEmitWithAwait() { throw null; }
        public override Mono.CSharp.Expression CreateExpressionTree(Mono.CSharp.ResolveContext ec) { throw null; }
        protected override Mono.CSharp.Expression DoResolve(Mono.CSharp.ResolveContext ec) { throw null; }
        public override void Emit(Mono.CSharp.EmitContext ec) { }
    }
    public partial class PredefinedAttribute : Mono.CSharp.PredefinedType
    {
        protected Mono.CSharp.MethodSpec ctor;
        public PredefinedAttribute(Mono.CSharp.ModuleContainer module, string ns, string name) : base (default(Mono.CSharp.ModuleContainer), default(Mono.CSharp.MemberKind), default(string), default(string), default(int)) { }
        public Mono.CSharp.MethodSpec Constructor { get { throw null; } }
        public void EmitAttribute(System.Reflection.Emit.AssemblyBuilder builder) { }
        public void EmitAttribute(System.Reflection.Emit.ConstructorBuilder builder) { }
        public void EmitAttribute(System.Reflection.Emit.FieldBuilder builder) { }
        public void EmitAttribute(System.Reflection.Emit.MethodBuilder builder) { }
        public void EmitAttribute(System.Reflection.Emit.ModuleBuilder builder) { }
        public void EmitAttribute(System.Reflection.Emit.ParameterBuilder builder) { }
        public void EmitAttribute(System.Reflection.Emit.PropertyBuilder builder) { }
        public void EmitAttribute(System.Reflection.Emit.TypeBuilder builder) { }
        public override bool Equals(object obj) { throw null; }
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Mono.CSharp.TypeSpec type, Mono.CSharp.PredefinedAttribute pa) { throw null; }
        public static bool operator !=(Mono.CSharp.TypeSpec type, Mono.CSharp.PredefinedAttribute pa) { throw null; }
        public bool ResolveBuilder() { throw null; }
    }
    public partial class PredefinedAttributes
    {
        public readonly Mono.CSharp.PredefinedAttribute AssemblyAlgorithmId;
        public readonly Mono.CSharp.PredefinedAttribute AssemblyCompany;
        public readonly Mono.CSharp.PredefinedAttribute AssemblyCopyright;
        public readonly Mono.CSharp.PredefinedAttribute AssemblyCulture;
        public readonly Mono.CSharp.PredefinedAttribute AssemblyFileVersion;
        public readonly Mono.CSharp.PredefinedAttribute AssemblyFlags;
        public readonly Mono.CSharp.PredefinedAttribute AssemblyInformationalVersion;
        public readonly Mono.CSharp.PredefinedAttribute AssemblyProduct;
        public readonly Mono.CSharp.PredefinedAttribute AssemblyTrademark;
        public readonly Mono.CSharp.PredefinedAttribute AssemblyVersion;
        public readonly Mono.CSharp.PredefinedStateMachineAttribute AsyncStateMachine;
        public readonly Mono.CSharp.PredefinedAttribute AttributeUsage;
        public readonly Mono.CSharp.PredefinedAttribute CallerFilePathAttribute;
        public readonly Mono.CSharp.PredefinedAttribute CallerLineNumberAttribute;
        public readonly Mono.CSharp.PredefinedAttribute CallerMemberNameAttribute;
        public readonly Mono.CSharp.PredefinedAttribute CLSCompliant;
        public readonly Mono.CSharp.PredefinedAttribute CoClass;
        public readonly Mono.CSharp.PredefinedAttribute ComImport;
        public readonly Mono.CSharp.PredefinedAttribute CompilerGenerated;
        public readonly Mono.CSharp.PredefinedAttribute Conditional;
        public readonly Mono.CSharp.PredefinedDebuggableAttribute Debuggable;
        public readonly Mono.CSharp.PredefinedDebuggerBrowsableAttribute DebuggerBrowsable;
        public readonly Mono.CSharp.PredefinedAttribute DebuggerHidden;
        public readonly Mono.CSharp.PredefinedAttribute DebuggerStepThrough;
        public readonly Mono.CSharp.PredefinedDecimalAttribute DecimalConstant;
        public readonly Mono.CSharp.PredefinedAttribute DefaultCharset;
        public readonly Mono.CSharp.PredefinedAttribute DefaultMember;
        public readonly Mono.CSharp.PredefinedAttribute DefaultParameterValue;
        public readonly Mono.CSharp.PredefinedAttribute DllImport;
        public readonly Mono.CSharp.PredefinedDynamicAttribute Dynamic;
        public readonly Mono.CSharp.PredefinedAttribute Extension;
        public readonly Mono.CSharp.PredefinedAttribute FieldOffset;
        public readonly Mono.CSharp.PredefinedAttribute FixedBuffer;
        public readonly Mono.CSharp.PredefinedAttribute Guid;
        public readonly Mono.CSharp.PredefinedAttribute HostProtection;
        public readonly Mono.CSharp.PredefinedAttribute In;
        public readonly Mono.CSharp.PredefinedAttribute IndexerName;
        public readonly Mono.CSharp.PredefinedAttribute InternalsVisibleTo;
        public readonly Mono.CSharp.PredefinedAttribute MarshalAs;
        public readonly Mono.CSharp.PredefinedAttribute MethodImpl;
        public readonly Mono.CSharp.PredefinedAttribute Obsolete;
        public readonly Mono.CSharp.PredefinedAttribute OptionalParameter;
        public readonly Mono.CSharp.PredefinedAttribute Out;
        public readonly Mono.CSharp.PredefinedAttribute ParamArray;
        public readonly Mono.CSharp.PredefinedAttribute Required;
        public readonly Mono.CSharp.PredefinedAttribute RuntimeCompatibility;
        public readonly Mono.CSharp.PredefinedAttribute Security;
        public readonly Mono.CSharp.PredefinedAttribute StructLayout;
        public readonly Mono.CSharp.PredefinedTupleElementNamesAttribute TupleElementNames;
        public readonly Mono.CSharp.PredefinedAttribute TypeForwarder;
        public readonly Mono.CSharp.PredefinedAttribute UnmanagedFunctionPointer;
        public readonly Mono.CSharp.PredefinedAttribute UnsafeValueType;
        public readonly Mono.CSharp.PredefinedAttribute UnverifiableCode;
        public PredefinedAttributes(Mono.CSharp.ModuleContainer module) { }
    }
    public partial class PredefinedDebuggableAttribute : Mono.CSharp.PredefinedAttribute
    {
        public PredefinedDebuggableAttribute(Mono.CSharp.ModuleContainer module, string ns, string name) : base (default(Mono.CSharp.ModuleContainer), default(string), default(string)) { }
        public void EmitAttribute(System.Reflection.Emit.AssemblyBuilder builder, System.Diagnostics.DebuggableAttribute.DebuggingModes modes) { }
    }
    public partial class PredefinedDebuggerBrowsableAttribute : Mono.CSharp.PredefinedAttribute
    {
        public PredefinedDebuggerBrowsableAttribute(Mono.CSharp.ModuleContainer module, string ns, string name) : base (default(Mono.CSharp.ModuleContainer), default(string), default(string)) { }
        public void EmitAttribute(System.Reflection.Emit.FieldBuilder builder, System.Diagnostics.DebuggerBrowsableState state) { }
    }
    public partial class PredefinedDecimalAttribute : Mono.CSharp.PredefinedAttribute
    {
        public PredefinedDecimalAttribute(Mono.CSharp.ModuleContainer module, string ns, string name) : base (default(Mono.CSharp.ModuleContainer), default(string), default(string)) { }
        public void EmitAttribute(System.Reflection.Emit.FieldBuilder builder, decimal value, Mono.CSharp.Location loc) { }
        public void EmitAttribute(System.Reflection.Emit.ParameterBuilder builder, decimal value, Mono.CSharp.Location loc) { }
    }
    public partial class PredefinedDynamicAttribute : Mono.CSharp.PredefinedAttribute
    {
        public PredefinedDynamicAttribute(Mono.CSharp.ModuleContainer module, string ns, string name) : base (default(Mono.CSharp.ModuleContainer), default(string), default(string)) { }
        public void EmitAttribute(System.Reflection.Emit.FieldBuilder builder, Mono.CSharp.TypeSpec type, Mono.CSharp.Location loc) { }
        public void EmitAttribute(System.Reflection.Emit.ParameterBuilder builder, Mono.CSharp.TypeSpec type, Mono.CSharp.Location loc) { }
        public void EmitAttribute(System.Reflection.Emit.PropertyBuilder builder, Mono.CSharp.TypeSpec type, Mono.CSharp.Location loc) { }
        public void EmitAttribute(System.Reflection.Emit.TypeBuilder builder, Mono.CSharp.TypeSpec type, Mono.CSharp.Location loc) { }
    }
    public partial class PredefinedMember<T> where T : Mono.CSharp.MemberSpec
    {
        public PredefinedMember(Mono.CSharp.ModuleContainer module, Mono.CSharp.BuiltinTypeSpec type, string name, params Mono.CSharp.TypeSpec[] types) { }
        public PredefinedMember(Mono.CSharp.ModuleContainer module, Mono.CSharp.PredefinedType type, Mono.CSharp.MemberFilter filter) { }
        public PredefinedMember(Mono.CSharp.ModuleContainer module, Mono.CSharp.PredefinedType type, string name, Mono.CSharp.MemberKind kind, params Mono.CSharp.PredefinedType[] types) { }
        public PredefinedMember(Mono.CSharp.ModuleContainer module, Mono.CSharp.PredefinedType type, string name, Mono.CSharp.MemberKind kind, System.Func<Mono.CSharp.TypeSpec[]> typesBuilder, Mono.CSharp.TypeSpec returnType) { }
        public PredefinedMember(Mono.CSharp.ModuleContainer module, Mono.CSharp.PredefinedType type, string name, params Mono.CSharp.TypeSpec[] types) { }
        public PredefinedMember(Mono.CSharp.ModuleContainer module, Mono.CSharp.TypeSpec type, Mono.CSharp.MemberFilter filter) { }
        public T Get() { throw null; }
        public T Resolve(Mono.CSharp.Location loc) { throw null; }
    }
    public partial class PredefinedStateMachineAttribute : Mono.CSharp.PredefinedAttribute
    {
        public PredefinedStateMachineAttribute(Mono.CSharp.ModuleContainer module, string ns, string name) : base (default(Mono.CSharp.ModuleContainer), default(string), default(string)) { }
        public void EmitAttribute(System.Reflection.Emit.MethodBuilder builder, Mono.CSharp.StateMachine type) { }
    }
    public partial class PredefinedTupleElementNamesAttribute : Mono.CSharp.PredefinedAttribute
    {
        public PredefinedTupleElementNamesAttribute(Mono.CSharp.ModuleContainer module, string ns, string name) : base (default(Mono.CSharp.ModuleContainer), default(string), default(string)) { }
        public void EmitAttribute(System.Reflection.Emit.FieldBuilder builder, Mono.CSharp.TypeSpec type, Mono.CSharp.Location loc) { }
        public void EmitAttribute(System.Reflection.Emit.ParameterBuilder builder, Mono.CSharp.TypeSpec type, Mono.CSharp.Location loc) { }
        public void EmitAttribute(System.Reflection.Emit.PropertyBuilder builder, Mono.CSharp.TypeSpec type, Mono.CSharp.Location loc) { }
        public void EmitAttribute(System.Reflection.Emit.TypeBuilder builder, Mono.CSharp.TypeSpec type, Mono.CSharp.Location loc) { }
    }
    public partial class PredefinedType
    {
        protected readonly Mono.CSharp.ModuleContainer module;
        protected Mono.CSharp.TypeSpec type;
        public PredefinedType(Mono.CSharp.BuiltinTypeSpec type) { }
        public PredefinedType(Mono.CSharp.ModuleContainer module, Mono.CSharp.MemberKind kind, string ns, string name) { }
        public PredefinedType(Mono.CSharp.ModuleContainer module, Mono.CSharp.MemberKind kind, string ns, string name, int arity) { }
        public int Arity { get { throw null; } }
        public bool IsDefined { get { throw null; } }
        public string Name { get { throw null; } }
        public string Namespace { get { throw null; } }
        public Mono.CSharp.TypeSpec TypeSpec { get { throw null; } }
        public bool Define() { throw null; }
        public string GetSignatureForError() { throw null; }
        public Mono.CSharp.TypeSpec Resolve() { throw null; }
        public static Mono.CSharp.TypeSpec Resolve(Mono.CSharp.ModuleContainer module, Mono.CSharp.MemberKind kind, string ns, string name, int arity, bool required, bool reportErrors) { throw null; }
    }
    public abstract partial class Probe : Mono.CSharp.Expression
    {
        protected Mono.CSharp.Expression expr;
        public Mono.CSharp.Expression ProbeType;
        protected Mono.CSharp.TypeSpec probe_type_expr;
        protected Probe(Mono.CSharp.Expression expr, Mono.CSharp.Expression probe_type, Mono.CSharp.Location l) { }
        public Mono.CSharp.Expression Expr { get { throw null; } }
        protected abstract string OperatorName { get; }
        protected override void CloneTo(Mono.CSharp.CloneContext clonectx, Mono.CSharp.Expression t) { }
        public override bool ContainsEmitWithAwait() { throw null; }
        public override void EmitPrepare(Mono.CSharp.EmitContext ec) { }
        public override void EmitSideEffect(Mono.CSharp.EmitContext ec) { }
        public override void FlowAnalysis(Mono.CSharp.FlowAnalysisContext fc) { }
        public override bool HasConditionalAccess() { throw null; }
        protected Mono.CSharp.Expression ResolveCommon(Mono.CSharp.ResolveContext rc) { throw null; }
        protected virtual void ResolveProbeType(Mono.CSharp.ResolveContext rc) { }
    }
    public partial class Property : Mono.CSharp.PropertyBase
    {
        public Property(Mono.CSharp.TypeDefinition parent, Mono.CSharp.FullNamedExpression type, Mono.CSharp.Modifiers mod, Mono.CSharp.MemberName name, Mono.CSharp.Attributes attrs) : base (default(Mono.CSharp.TypeDefinition), default(Mono.CSharp.FullNamedExpression), default(Mono.CSharp.Modifiers), default(Mono.CSharp.Modifiers), default(Mono.CSharp.MemberName), default(Mono.CSharp.Attributes)) { }
        public Mono.CSharp.Property.BackingFieldDeclaration BackingField { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        public Mono.CSharp.Expression Initializer { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public override string[] ValidAttributeTargets { get { throw null; } }
        public override void Accept(Mono.CSharp.StructuralVisitor visitor) { }
        public override void ApplyAttributeBuilder(Mono.CSharp.Attribute a, Mono.CSharp.MethodSpec ctor, byte[] cdata, Mono.CSharp.PredefinedAttributes pa) { }
        public override bool Define() { throw null; }
        public override void Emit() { }
        public sealed partial class BackingFieldDeclaration : Mono.CSharp.Field
        {
            public BackingFieldDeclaration(Mono.CSharp.Property p, bool readOnly) : base (default(Mono.CSharp.TypeDefinition), default(Mono.CSharp.FullNamedExpression), default(Mono.CSharp.Modifiers), default(Mono.CSharp.MemberName), default(Mono.CSharp.Attributes)) { }
            public Mono.CSharp.Property OriginalProperty { get { throw null; } }
            public override string GetSignatureForError() { throw null; }
        }
    }
    public abstract partial class PropertyBase : Mono.CSharp.PropertyBasedMember
    {
        protected PropertyBase(Mono.CSharp.TypeDefinition parent, Mono.CSharp.FullNamedExpression type, Mono.CSharp.Modifiers mod_flags, Mono.CSharp.Modifiers allowed_mod, Mono.CSharp.MemberName name, Mono.CSharp.Attributes attrs) : base (default(Mono.CSharp.TypeDefinition), default(Mono.CSharp.FullNamedExpression), default(Mono.CSharp.Modifiers), default(Mono.CSharp.Modifiers), default(Mono.CSharp.MemberName), default(Mono.CSharp.Attributes)) { }
        public Mono.CSharp.PropertyBase.PropertyMethod AccessorFirst { get { throw null; } }
        public Mono.CSharp.PropertyBase.PropertyMethod AccessorSecond { get { throw null; } }
        public override System.AttributeTargets AttributeTargets { get { throw null; } }
        public override string DocCommentHeader { get { throw null; } }
        public override Mono.CSharp.Variance ExpectedMemberTypeVariance { get { throw null; } }
        public Mono.CSharp.PropertyBase.PropertyMethod Get { get { throw null; } set { } }
        public override bool IsUsed { get { throw null; } }
        public Mono.CSharp.PropertyBase.PropertyMethod Set { get { throw null; } set { } }
        public override string[] ValidAttributeTargets { get { throw null; } }
        public override void ApplyAttributeBuilder(Mono.CSharp.Attribute a, Mono.CSharp.MethodSpec ctor, byte[] cdata, Mono.CSharp.PredefinedAttributes pa) { }
        protected override bool CheckOverrideAgainstBase(Mono.CSharp.MemberSpec base_member) { throw null; }
        protected bool DefineAccessors() { throw null; }
        protected void DefineBuilders(Mono.CSharp.MemberKind kind, Mono.CSharp.ParametersCompiled parameters) { }
        protected override void DoMemberTypeDependentChecks() { }
        protected override void DoMemberTypeIndependentChecks() { }
        public override void Emit() { }
        public override void PrepareEmit() { }
        protected override void SetMemberName(Mono.CSharp.MemberName new_name) { }
        public override void WriteDebugSymbol(Mono.CompilerServices.SymbolWriter.MonoSymbolFile file) { }
        public partial class GetMethod : Mono.CSharp.PropertyBase.PropertyMethod
        {
            public GetMethod(Mono.CSharp.PropertyBase method, Mono.CSharp.Modifiers modifiers, Mono.CSharp.Attributes attrs, Mono.CSharp.Location loc) : base (default(Mono.CSharp.PropertyBase), default(string), default(Mono.CSharp.Modifiers), default(Mono.CSharp.Attributes), default(Mono.CSharp.Location)) { }
            public override Mono.CSharp.ParametersCompiled ParameterInfo { get { throw null; } }
            public override Mono.CSharp.TypeSpec ReturnType { get { throw null; } }
            public override string[] ValidAttributeTargets { get { throw null; } }
            public override void Define(Mono.CSharp.TypeContainer parent) { }
        }
        public abstract partial class PropertyMethod : Mono.CSharp.AbstractPropertyEventMethod
        {
            protected System.Reflection.MethodAttributes flags;
            protected readonly Mono.CSharp.PropertyBase method;
            public PropertyMethod(Mono.CSharp.PropertyBase method, string prefix, Mono.CSharp.Modifiers modifiers, Mono.CSharp.Attributes attrs, Mono.CSharp.Location loc) : base (default(Mono.CSharp.InterfaceMemberBase), default(string), default(Mono.CSharp.Attributes), default(Mono.CSharp.Location)) { }
            public override System.AttributeTargets AttributeTargets { get { throw null; } }
            public bool HasCustomAccessModifier { get { throw null; } }
            public Mono.CSharp.PropertyBase Property { get { throw null; } }
            public override void ApplyAttributeBuilder(Mono.CSharp.Attribute a, Mono.CSharp.MethodSpec ctor, byte[] cdata, Mono.CSharp.PredefinedAttributes pa) { }
            public virtual void Define(Mono.CSharp.TypeContainer parent) { }
            public override System.ObsoleteAttribute GetAttributeObsolete() { throw null; }
            public override string GetSignatureForError() { throw null; }
            public override bool IsClsComplianceRequired() { throw null; }
        }
        public partial class SetMethod : Mono.CSharp.PropertyBase.PropertyMethod
        {
            protected Mono.CSharp.ParametersCompiled parameters;
            public SetMethod(Mono.CSharp.PropertyBase method, Mono.CSharp.Modifiers modifiers, Mono.CSharp.ParametersCompiled parameters, Mono.CSharp.Attributes attrs, Mono.CSharp.Location loc) : base (default(Mono.CSharp.PropertyBase), default(string), default(Mono.CSharp.Modifiers), default(Mono.CSharp.Attributes), default(Mono.CSharp.Location)) { }
            public override Mono.CSharp.ParametersCompiled ParameterInfo { get { throw null; } }
            public override Mono.CSharp.TypeSpec ReturnType { get { throw null; } }
            public override string[] ValidAttributeTargets { get { throw null; } }
            protected override void ApplyToExtraTarget(Mono.CSharp.Attribute a, Mono.CSharp.MethodSpec ctor, byte[] cdata, Mono.CSharp.PredefinedAttributes pa) { }
            public override void Define(Mono.CSharp.TypeContainer parent) { }
        }
    }
    public abstract partial class PropertyBasedMember : Mono.CSharp.InterfaceMemberBase
    {
        protected PropertyBasedMember(Mono.CSharp.TypeDefinition parent, Mono.CSharp.FullNamedExpression type, Mono.CSharp.Modifiers mod, Mono.CSharp.Modifiers allowed_mod, Mono.CSharp.MemberName name, Mono.CSharp.Attributes attrs) : base (default(Mono.CSharp.TypeDefinition), default(Mono.CSharp.FullNamedExpression), default(Mono.CSharp.Modifiers), default(Mono.CSharp.Modifiers), default(Mono.CSharp.MemberName), default(Mono.CSharp.Attributes)) { }
        protected void CheckReservedNameConflict(string prefix, Mono.CSharp.MethodSpec accessor) { }
        protected override bool VerifyClsCompliance() { throw null; }
    }
    public partial class PropertySpec : Mono.CSharp.MemberSpec, Mono.CSharp.IInterfaceMemberSpec
    {
        public PropertySpec(Mono.CSharp.MemberKind kind, Mono.CSharp.TypeSpec declaringType, Mono.CSharp.IMemberDefinition definition, Mono.CSharp.TypeSpec memberType, System.Reflection.PropertyInfo info, Mono.CSharp.Modifiers modifiers) : base (default(Mono.CSharp.MemberKind), default(Mono.CSharp.TypeSpec), default(Mono.CSharp.IMemberDefinition), default(Mono.CSharp.Modifiers)) { }
        public Mono.CSharp.MethodSpec Get { get { throw null; } set { } }
        public bool HasDifferentAccessibility { get { throw null; } }
        public bool HasGet { get { throw null; } }
        public bool HasSet { get { throw null; } }
        public Mono.CSharp.TypeSpec MemberType { get { throw null; } }
        public System.Reflection.PropertyInfo MetaInfo { get { throw null; } }
        public Mono.CSharp.MethodSpec Set { get { throw null; } set { } }
        public override Mono.CSharp.MemberSpec InflateMember(Mono.CSharp.TypeParameterInflator inflator) { throw null; }
        public override System.Collections.Generic.List<Mono.CSharp.MissingTypeSpecReference> ResolveMissingDependencies(Mono.CSharp.MemberSpec caller) { throw null; }
    }
    public partial class QualifiedAliasMember : Mono.CSharp.MemberAccess
    {
        public static readonly string GlobalAlias;
        public QualifiedAliasMember(string alias, string identifier, Mono.CSharp.Location l) : base (default(Mono.CSharp.Expression), default(string)) { }
        public QualifiedAliasMember(string alias, string identifier, Mono.CSharp.TypeArguments targs, Mono.CSharp.Location l) : base (default(Mono.CSharp.Expression), default(string)) { }
        public QualifiedAliasMember(string alias, string identifier, int arity, Mono.CSharp.Location l) : base (default(Mono.CSharp.Expression), default(string)) { }
        public string Alias { get { throw null; } }
        public override object Accept(Mono.CSharp.StructuralVisitor visitor) { throw null; }
        protected override void CloneTo(Mono.CSharp.CloneContext clonectx, Mono.CSharp.Expression t) { }
        public Mono.CSharp.FullNamedExpression CreateExpressionFromAlias(Mono.CSharp.IMemberContext mc) { throw null; }
        protected override Mono.CSharp.Expression DoResolve(Mono.CSharp.ResolveContext rc) { throw null; }
        public override string GetSignatureForError() { throw null; }
        public override bool HasConditionalAccess() { throw null; }
        public override Mono.CSharp.Expression LookupNameExpression(Mono.CSharp.ResolveContext rc, Mono.CSharp.Expression.MemberLookupRestrictions restrictions) { throw null; }
        public override Mono.CSharp.FullNamedExpression ResolveAsTypeOrNamespace(Mono.CSharp.IMemberContext mc, bool allowUnboundTypeArguments) { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public partial struct Reachability
    {
        public bool IsUnreachable { get { throw null; } }
        public static Mono.CSharp.Reachability CreateUnreachable() { throw null; }
        public static Mono.CSharp.Reachability operator &(Mono.CSharp.Reachability a, Mono.CSharp.Reachability b) { throw null; }
        public static Mono.CSharp.Reachability operator |(Mono.CSharp.Reachability a, Mono.CSharp.Reachability b) { throw null; }
    }
    public partial class ReducedExpression : Mono.CSharp.Expression
    {
        internal ReducedExpression() { }
        public override bool IsSideEffectFree { get { throw null; } }
        public Mono.CSharp.Expression OriginalExpression { get { throw null; } }
        public override bool ContainsEmitWithAwait() { throw null; }
        public static Mono.CSharp.Constant Create(Mono.CSharp.Constant expr, Mono.CSharp.Expression originalExpr) { throw null; }
        public static Mono.CSharp.Expression Create(Mono.CSharp.Expression expr, Mono.CSharp.Expression original_expr) { throw null; }
        public static Mono.CSharp.Expression Create(Mono.CSharp.Expression expr, Mono.CSharp.Expression original_expr, bool canBeConstant) { throw null; }
        public static Mono.CSharp.ExpressionStatement Create(Mono.CSharp.ExpressionStatement s, Mono.CSharp.Expression orig) { throw null; }
        public override Mono.CSharp.Expression CreateExpressionTree(Mono.CSharp.ResolveContext ec) { throw null; }
        protected override Mono.CSharp.Expression DoResolve(Mono.CSharp.ResolveContext ec) { throw null; }
        public override void Emit(Mono.CSharp.EmitContext ec) { }
        public override void EmitBranchable(Mono.CSharp.EmitContext ec, System.Reflection.Emit.Label target, bool on_true) { }
        public override Mono.CSharp.Expression EmitToField(Mono.CSharp.EmitContext ec) { throw null; }
        public override void FlowAnalysis(Mono.CSharp.FlowAnalysisContext fc) { }
        public override void FlowAnalysisConditional(Mono.CSharp.FlowAnalysisContext fc) { }
        public override System.Linq.Expressions.Expression MakeExpression(Mono.CSharp.BuilderContext ctx) { throw null; }
        public override Mono.CSharp.Reachability MarkReachable(Mono.CSharp.Reachability rc) { throw null; }
        public partial class ReducedConstantExpression : Mono.CSharp.EmptyConstantCast
        {
            public ReducedConstantExpression(Mono.CSharp.Constant expr, Mono.CSharp.Expression orig_expr) : base (default(Mono.CSharp.Constant), default(Mono.CSharp.TypeSpec)) { }
            public Mono.CSharp.Expression OriginalExpression { get { throw null; } }
            public override Mono.CSharp.Constant ConvertExplicitly(bool in_checked_context, Mono.CSharp.TypeSpec target_type) { throw null; }
            public override Mono.CSharp.Constant ConvertImplicitly(Mono.CSharp.TypeSpec target_type) { throw null; }
            public override Mono.CSharp.Expression CreateExpressionTree(Mono.CSharp.ResolveContext ec) { throw null; }
            public override void EncodeAttributeValue(Mono.CSharp.IMemberContext rc, Mono.CSharp.AttributeEncoder enc, Mono.CSharp.TypeSpec targetType, Mono.CSharp.TypeSpec parameterType) { }
        }
    }
    public sealed partial class ReflectionImporter : Mono.CSharp.MetadataImporter
    {
        public ReflectionImporter(Mono.CSharp.ModuleContainer module, Mono.CSharp.BuiltinTypes builtin) : base (default(Mono.CSharp.ModuleContainer)) { }
        public override void AddCompiledType(System.Reflection.Emit.TypeBuilder builder, Mono.CSharp.TypeSpec spec) { }
        protected override Mono.CSharp.MemberKind DetermineKindFromBaseType(System.Type baseType) { throw null; }
        protected override bool HasVolatileModifier(System.Type[] modifiers) { throw null; }
        public void ImportAssembly(System.Reflection.Assembly assembly, Mono.CSharp.RootNamespace targetNamespace) { }
        public Mono.CSharp.ImportedModuleDefinition ImportModule(System.Reflection.Module module, Mono.CSharp.RootNamespace targetNamespace) { throw null; }
    }
    public partial class RefTypeExpr : Mono.CSharp.ShimExpression
    {
        public RefTypeExpr(Mono.CSharp.Expression expr, Mono.CSharp.Location loc) : base (default(Mono.CSharp.Expression)) { }
        public override object Accept(Mono.CSharp.StructuralVisitor visitor) { throw null; }
        protected override Mono.CSharp.Expression DoResolve(Mono.CSharp.ResolveContext rc) { throw null; }
        public override void Emit(Mono.CSharp.EmitContext ec) { }
    }
    public partial class RefValueExpr : Mono.CSharp.ShimExpression, Mono.CSharp.IAssignMethod, Mono.CSharp.IMemoryLocation
    {
        public RefValueExpr(Mono.CSharp.Expression expr, Mono.CSharp.FullNamedExpression texpr, Mono.CSharp.Location loc) : base (default(Mono.CSharp.Expression)) { }
        public Mono.CSharp.FullNamedExpression TypeExpression { get { throw null; } }
        public override object Accept(Mono.CSharp.StructuralVisitor visitor) { throw null; }
        public void AddressOf(Mono.CSharp.EmitContext ec, Mono.CSharp.AddressOp mode) { }
        public override bool ContainsEmitWithAwait() { throw null; }
        protected override Mono.CSharp.Expression DoResolve(Mono.CSharp.ResolveContext rc) { throw null; }
        public override Mono.CSharp.Expression DoResolveLValue(Mono.CSharp.ResolveContext rc, Mono.CSharp.Expression right_side) { throw null; }
        public override void Emit(Mono.CSharp.EmitContext ec) { }
        public void Emit(Mono.CSharp.EmitContext ec, bool leave_copy) { }
        public void EmitAssign(Mono.CSharp.EmitContext ec, Mono.CSharp.Expression source, bool leave_copy, bool isCompound) { }
    }
    public partial class Report
    {
        public static readonly int[] AllWarnings;
        public const int RuntimeErrorId = 10000;
        public Report(Mono.CSharp.CompilerContext context, Mono.CSharp.ReportPrinter printer) { }
        public int Errors { get { throw null; } }
        public bool IsDisabled { get { throw null; } }
        public Mono.CSharp.ReportPrinter Printer { get { throw null; } }
        public int Warnings { get { throw null; } }
        [System.Diagnostics.ConditionalAttribute("MCS_DEBUG")]
        public static void Debug(int category, string message, params object[] args) { }
        [System.Diagnostics.ConditionalAttribute("MCS_DEBUG")]
        public static void Debug(string message, params object[] args) { }
        public void DisableReporting() { }
        public void EnableReporting() { }
        public void Error(int code, Mono.CSharp.Location loc, string error) { }
        public void Error(int code, Mono.CSharp.Location loc, string format, string arg) { }
        public void Error(int code, Mono.CSharp.Location loc, string format, string arg1, string arg2) { }
        public void Error(int code, Mono.CSharp.Location loc, string format, params string[] args) { }
        public void Error(int code, string error) { }
        public void Error(int code, string format, string arg) { }
        public void Error(int code, string format, string arg1, string arg2) { }
        public void Error(int code, string format, params string[] args) { }
        public void ExtraInformation(Mono.CSharp.Location loc, string msg) { }
        public void FeatureIsNotAvailable(Mono.CSharp.CompilerContext compiler, Mono.CSharp.Location loc, string feature) { }
        public void FeatureIsNotSupported(Mono.CSharp.Location loc, string feature) { }
        public Mono.CSharp.WarningRegions RegisterWarningRegion(Mono.CSharp.Location location) { throw null; }
        public void RuntimeMissingSupport(Mono.CSharp.Location loc, string feature) { }
        public Mono.CSharp.ReportPrinter SetPrinter(Mono.CSharp.ReportPrinter printer) { throw null; }
        public void SymbolRelatedToPreviousError(Mono.CSharp.Location loc, string symbol) { }
        public void SymbolRelatedToPreviousError(Mono.CSharp.MemberCore mc) { }
        public void SymbolRelatedToPreviousError(Mono.CSharp.MemberSpec ms) { }
        public void SymbolRelatedToPreviousError(string loc) { }
        public void Warning(int code, int level, Mono.CSharp.Location loc, string message) { }
        public void Warning(int code, int level, Mono.CSharp.Location loc, string format, params object[] args) { }
        public void Warning(int code, int level, Mono.CSharp.Location loc, string format, string arg) { }
        public void Warning(int code, int level, Mono.CSharp.Location loc, string format, string arg1, string arg2) { }
        public void Warning(int code, int level, string message) { }
        public void Warning(int code, int level, string format, string arg) { }
        public void Warning(int code, int level, string format, string arg1, string arg2) { }
        public void Warning(int code, int level, string format, params string[] args) { }
    }
    public abstract partial class ReportPrinter
    {
        protected System.Collections.Generic.HashSet<Mono.CSharp.ITypeDefinition> reported_missing_definitions;
        protected ReportPrinter() { }
        public int ErrorsCount { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]protected set { } }
        public virtual bool HasRelatedSymbolSupport { get { throw null; } }
        public int WarningsCount { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        protected virtual string FormatText(string txt) { throw null; }
        public bool MissingTypeReported(Mono.CSharp.ITypeDefinition typeDefinition) { throw null; }
        public virtual void Print(Mono.CSharp.AbstractMessage msg, bool showFullPath) { }
        protected void Print(Mono.CSharp.AbstractMessage msg, System.IO.TextWriter output, bool showFullPath) { }
        public void Reset() { }
    }
    public partial class ResolveContext : Mono.CSharp.IMemberContext, Mono.CSharp.IModuleContext
    {
        public Mono.CSharp.AnonymousExpression CurrentAnonymousMethod;
        public Mono.CSharp.Block CurrentBlock;
        public Mono.CSharp.Expression CurrentInitializerVariable;
        protected Mono.CSharp.ResolveContext.Options flags;
        public readonly Mono.CSharp.IMemberContext MemberContext;
        public ResolveContext(Mono.CSharp.IMemberContext mc) { }
        public ResolveContext(Mono.CSharp.IMemberContext mc, Mono.CSharp.ResolveContext.Options options) { }
        public Mono.CSharp.BuiltinTypes BuiltinTypes { get { throw null; } }
        public bool ConstantCheckState { get { throw null; } }
        public virtual Mono.CSharp.ExplicitBlock ConstructorBlock { get { throw null; } }
        public Mono.CSharp.Iterator CurrentIterator { get { throw null; } }
        public Mono.CSharp.MemberCore CurrentMemberDefinition { get { throw null; } }
        public Mono.CSharp.TypeSpec CurrentType { get { throw null; } }
        public Mono.CSharp.TypeParameters CurrentTypeParameters { get { throw null; } }
        public bool IsInProbingMode { get { throw null; } }
        public bool IsObsolete { get { throw null; } }
        public bool IsRuntimeBinder { get { throw null; } }
        public bool IsStatic { get { throw null; } }
        public bool IsUnsafe { get { throw null; } }
        public bool IsVariableCapturingRequired { get { throw null; } }
        public Mono.CSharp.ModuleContainer Module { get { throw null; } }
        public Mono.CSharp.Report Report { get { throw null; } }
        public string GetSignatureForError() { throw null; }
        public bool HasAny(Mono.CSharp.ResolveContext.Options options) { throw null; }
        public bool HasSet(Mono.CSharp.ResolveContext.Options options) { throw null; }
        public Mono.CSharp.ExtensionMethodCandidates LookupExtensionMethod(string name, int arity) { throw null; }
        public Mono.CSharp.FullNamedExpression LookupNamespaceAlias(string name) { throw null; }
        public Mono.CSharp.FullNamedExpression LookupNamespaceOrType(string name, int arity, Mono.CSharp.LookupMode mode, Mono.CSharp.Location loc) { throw null; }
        public bool MustCaptureVariable(Mono.CSharp.INamedBlockVariable local) { throw null; }
        public Mono.CSharp.ResolveContext.FlagsHandle Set(Mono.CSharp.ResolveContext.Options options) { throw null; }
        public Mono.CSharp.ResolveContext.FlagsHandle With(Mono.CSharp.ResolveContext.Options options, bool enable) { throw null; }
        [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
        public partial struct FlagsHandle : System.IDisposable
        {
            public FlagsHandle(Mono.CSharp.ResolveContext ec, Mono.CSharp.ResolveContext.Options flagsToSet) { throw null;}
            public void Dispose() { }
        }
        [System.FlagsAttribute]
        public enum Options
        {
            AllCheckStateFlags = 3,
            BaseInitializer = 256,
            CatchScope = 8,
            CheckedScope = 1,
            CompoundAssignmentScope = 64,
            ConstantCheckState = 2,
            ConstantScope = 1024,
            ConstructorScope = 2048,
            DontSetConditionalAccessReceiver = 65536,
            EnumScope = 512,
            ExpressionTreeConversion = 33554432,
            FieldInitializerScope = 32,
            FinallyScope = 16,
            FixedInitializerScope = 128,
            InferReturnType = 8388608,
            InvokeSpecialName = 67108864,
            LockScope = 8192,
            NameOfScope = 131072,
            OmitDebuggingInfo = 16777216,
            ProbingMode = 4194304,
            QueryClauseScope = 262144,
            TryScope = 16384,
            TryWithCatchScope = 32768,
            UnsafeScope = 4,
            UsingInitializerScope = 4096,
        }
    }
    [System.FlagsAttribute]
    public enum ResolveFlags
    {
        MaskExprClass = 15,
        MethodGroup = 4,
        Type = 2,
        TypeParameter = 8,
        VariableOrValue = 1,
    }
    public abstract partial class ResumableStatement : Mono.CSharp.Statement
    {
        protected System.Reflection.Emit.Label resume_point;
        protected ResumableStatement() { }
        public virtual void EmitForDispose(Mono.CSharp.EmitContext ec, System.Reflection.Emit.LocalBuilder pc, System.Reflection.Emit.Label end, bool have_dispatcher) { }
        public virtual System.Reflection.Emit.Label PrepareForDispose(Mono.CSharp.EmitContext ec, System.Reflection.Emit.Label end) { throw null; }
        public System.Reflection.Emit.Label PrepareForEmit(Mono.CSharp.EmitContext ec) { throw null; }
    }
    public partial class Return : Mono.CSharp.ExitStatement
    {
        public Return(Mono.CSharp.Expression expr, Mono.CSharp.Location l) { }
        public Mono.CSharp.Expression Expr { get { throw null; } protected set { } }
        protected override bool IsLocalExit { get { throw null; } }
        public override object Accept(Mono.CSharp.StructuralVisitor visitor) { throw null; }
        protected override void CloneTo(Mono.CSharp.CloneContext clonectx, Mono.CSharp.Statement t) { }
        protected override void DoEmit(Mono.CSharp.EmitContext ec) { }
        protected override bool DoFlowAnalysis(Mono.CSharp.FlowAnalysisContext fc) { throw null; }
        protected override bool DoResolve(Mono.CSharp.BlockContext ec) { throw null; }
        public override Mono.CSharp.Reachability MarkReachable(Mono.CSharp.Reachability rc) { throw null; }
    }
    public partial class ReturnParameter : Mono.CSharp.ParameterBase
    {
        public ReturnParameter(Mono.CSharp.MemberCore method, System.Reflection.Emit.MethodBuilder mb, Mono.CSharp.Location location) { }
        public override System.AttributeTargets AttributeTargets { get { throw null; } }
        public override string[] ValidAttributeTargets { get { throw null; } }
        public override void ApplyAttributeBuilder(Mono.CSharp.Attribute a, Mono.CSharp.MethodSpec ctor, byte[] cdata, Mono.CSharp.PredefinedAttributes pa) { }
    }
    public partial class RootContext
    {
        public RootContext() { }
        public static Mono.CSharp.ModuleContainer ToplevelTypes { get { throw null; } set { } }
    }
    public partial class RootNamespace : Mono.CSharp.Namespace
    {
        public RootNamespace(string alias_name) { }
        public string Alias { get { throw null; } }
        public static void Error_GlobalNamespaceRedefined(Mono.CSharp.Report report, Mono.CSharp.Location loc) { }
        public System.Collections.Generic.List<string> FindExtensionMethodNamespaces(Mono.CSharp.IMemberContext ctx, string name, int arity) { throw null; }
        public System.Collections.Generic.List<string> FindTypeNamespaces(Mono.CSharp.IMemberContext ctx, string name, int arity) { throw null; }
        public override string GetSignatureForError() { throw null; }
        public void RegisterNamespace(Mono.CSharp.Namespace child) { }
    }
    public partial class RuntimeExplicitAssign : Mono.CSharp.Assign
    {
        public RuntimeExplicitAssign(Mono.CSharp.Expression target, Mono.CSharp.Expression source) : base (default(Mono.CSharp.Expression), default(Mono.CSharp.Expression), default(Mono.CSharp.Location)) { }
        protected override Mono.CSharp.Expression ResolveConversions(Mono.CSharp.ResolveContext ec) { throw null; }
    }
    public partial class RuntimeValueExpression : Mono.CSharp.Expression, Mono.CSharp.IAssignMethod, Mono.CSharp.IMemoryLocation
    {
        public RuntimeValueExpression(System.Dynamic.DynamicMetaObject obj, Mono.CSharp.TypeSpec type) { }
        public bool IsSuggestionOnly { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public System.Dynamic.DynamicMetaObject MetaObject { get { throw null; } }
        public void AddressOf(Mono.CSharp.EmitContext ec, Mono.CSharp.AddressOp mode) { }
        public override bool ContainsEmitWithAwait() { throw null; }
        public override Mono.CSharp.Expression CreateExpressionTree(Mono.CSharp.ResolveContext ec) { throw null; }
        protected override Mono.CSharp.Expression DoResolve(Mono.CSharp.ResolveContext ec) { throw null; }
        public override Mono.CSharp.Expression DoResolveLValue(Mono.CSharp.ResolveContext ec, Mono.CSharp.Expression right_side) { throw null; }
        public override void Emit(Mono.CSharp.EmitContext ec) { }
        public void Emit(Mono.CSharp.EmitContext ec, bool leave_copy) { }
        public void EmitAssign(Mono.CSharp.EmitContext ec, Mono.CSharp.Expression source, bool leave_copy, bool isCompound) { }
        public System.Linq.Expressions.Expression MakeAssignExpression(Mono.CSharp.BuilderContext ctx, Mono.CSharp.Expression source) { throw null; }
        public override System.Linq.Expressions.Expression MakeExpression(Mono.CSharp.BuilderContext ctx) { throw null; }
    }
    public enum RuntimeVersion
    {
        v1 = 0,
        v2 = 1,
        v4 = 2,
    }
    public partial class SByteConstant : Mono.CSharp.IntegralConstant
    {
        public readonly sbyte Value;
        public SByteConstant(Mono.CSharp.BuiltinTypes types, sbyte v, Mono.CSharp.Location loc) : base (default(Mono.CSharp.TypeSpec), default(Mono.CSharp.Location)) { }
        public SByteConstant(Mono.CSharp.TypeSpec type, sbyte v, Mono.CSharp.Location loc) : base (default(Mono.CSharp.TypeSpec), default(Mono.CSharp.Location)) { }
        public override bool IsDefaultValue { get { throw null; } }
        public override bool IsNegative { get { throw null; } }
        public override bool IsOneInteger { get { throw null; } }
        public override bool IsZeroInteger { get { throw null; } }
        public override Mono.CSharp.Constant ConvertExplicitly(bool in_checked_context, Mono.CSharp.TypeSpec target_type) { throw null; }
        public override void Emit(Mono.CSharp.EmitContext ec) { }
        public override void EncodeAttributeValue(Mono.CSharp.IMemberContext rc, Mono.CSharp.AttributeEncoder enc, Mono.CSharp.TypeSpec targetType, Mono.CSharp.TypeSpec parameterType) { }
        public override object GetValue() { throw null; }
        public override long GetValueAsLong() { throw null; }
        public override Mono.CSharp.Constant Increment() { throw null; }
    }
    public partial class SeekableStreamReader : System.IDisposable
    {
        public const int DefaultReadAheadSize = 2048;
        public readonly System.IO.Stream Stream;
        public SeekableStreamReader(System.IO.Stream stream, System.Text.Encoding encoding, char[] sharedBuffer=null) { }
        public int Position { get { throw null; } set { } }
        public void Dispose() { }
        public int Peek() { throw null; }
        public int Read() { throw null; }
        public char[] ReadChars(int fromPosition, int toPosition) { throw null; }
    }
    public abstract partial class ShimExpression : Mono.CSharp.Expression
    {
        protected Mono.CSharp.Expression expr;
        protected ShimExpression(Mono.CSharp.Expression expr) { }
        public Mono.CSharp.Expression Expr { get { throw null; } }
        protected override void CloneTo(Mono.CSharp.CloneContext clonectx, Mono.CSharp.Expression t) { }
        public override bool ContainsEmitWithAwait() { throw null; }
        public override Mono.CSharp.Expression CreateExpressionTree(Mono.CSharp.ResolveContext ec) { throw null; }
        public override void Emit(Mono.CSharp.EmitContext ec) { }
    }
    public partial class ShortConstant : Mono.CSharp.IntegralConstant
    {
        public readonly short Value;
        public ShortConstant(Mono.CSharp.BuiltinTypes types, short v, Mono.CSharp.Location loc) : base (default(Mono.CSharp.TypeSpec), default(Mono.CSharp.Location)) { }
        public ShortConstant(Mono.CSharp.TypeSpec type, short v, Mono.CSharp.Location loc) : base (default(Mono.CSharp.TypeSpec), default(Mono.CSharp.Location)) { }
        public override bool IsDefaultValue { get { throw null; } }
        public override bool IsNegative { get { throw null; } }
        public override bool IsOneInteger { get { throw null; } }
        public override bool IsZeroInteger { get { throw null; } }
        public override Mono.CSharp.Constant ConvertExplicitly(bool in_checked_context, Mono.CSharp.TypeSpec target_type) { throw null; }
        public override void Emit(Mono.CSharp.EmitContext ec) { }
        public override void EncodeAttributeValue(Mono.CSharp.IMemberContext rc, Mono.CSharp.AttributeEncoder enc, Mono.CSharp.TypeSpec targetType, Mono.CSharp.TypeSpec parameterType) { }
        public override object GetValue() { throw null; }
        public override long GetValueAsLong() { throw null; }
        public override Mono.CSharp.Constant Increment() { throw null; }
    }
    public partial class SideEffectConstant : Mono.CSharp.Constant
    {
        public readonly Mono.CSharp.Constant value;
        public SideEffectConstant(Mono.CSharp.Constant value, Mono.CSharp.Expression side_effect, Mono.CSharp.Location loc) : base (default(Mono.CSharp.Location)) { }
        public override bool IsDefaultValue { get { throw null; } }
        public override bool IsNegative { get { throw null; } }
        public override bool IsSideEffectFree { get { throw null; } }
        public override bool IsZeroInteger { get { throw null; } }
        public override bool ContainsEmitWithAwait() { throw null; }
        public override Mono.CSharp.Constant ConvertExplicitly(bool in_checked_context, Mono.CSharp.TypeSpec target_type) { throw null; }
        public override void Emit(Mono.CSharp.EmitContext ec) { }
        public override void EmitSideEffect(Mono.CSharp.EmitContext ec) { }
        public override void FlowAnalysis(Mono.CSharp.FlowAnalysisContext fc) { }
        public override object GetValue() { throw null; }
        public override string GetValueAsLiteral() { throw null; }
        public override long GetValueAsLong() { throw null; }
    }
    public partial class SimpleAssign : Mono.CSharp.Assign
    {
        public SimpleAssign(Mono.CSharp.Expression target, Mono.CSharp.Expression source) : base (default(Mono.CSharp.Expression), default(Mono.CSharp.Expression), default(Mono.CSharp.Location)) { }
        public SimpleAssign(Mono.CSharp.Expression target, Mono.CSharp.Expression source, Mono.CSharp.Location loc) : base (default(Mono.CSharp.Expression), default(Mono.CSharp.Expression), default(Mono.CSharp.Location)) { }
        protected override Mono.CSharp.Expression DoResolve(Mono.CSharp.ResolveContext ec) { throw null; }
        public override void FlowAnalysis(Mono.CSharp.FlowAnalysisContext fc) { }
        public override Mono.CSharp.Reachability MarkReachable(Mono.CSharp.Reachability rc) { throw null; }
    }
    public partial class SimpleMemberName
    {
        public Mono.CSharp.Location Location;
        public string Value;
        public SimpleMemberName(string name, Mono.CSharp.Location loc) { }
    }
    public partial class SimpleName : Mono.CSharp.ATypeNameExpression
    {
        public SimpleName(string name, Mono.CSharp.Location l) : base (default(string), default(Mono.CSharp.Location)) { }
        public SimpleName(string name, Mono.CSharp.TypeArguments args, Mono.CSharp.Location l) : base (default(string), default(Mono.CSharp.Location)) { }
        public SimpleName(string name, int arity, Mono.CSharp.Location l) : base (default(string), default(Mono.CSharp.Location)) { }
        public override object Accept(Mono.CSharp.StructuralVisitor visitor) { throw null; }
        protected override Mono.CSharp.Expression DoResolve(Mono.CSharp.ResolveContext rc) { throw null; }
        public override Mono.CSharp.Expression DoResolveLValue(Mono.CSharp.ResolveContext ec, Mono.CSharp.Expression right_side) { throw null; }
        public void Error_NameDoesNotExist(Mono.CSharp.ResolveContext rc) { }
        protected virtual void Error_TypeOrNamespaceNotFound(Mono.CSharp.IMemberContext ctx) { }
        public Mono.CSharp.SimpleName GetMethodGroup() { throw null; }
        public bool IsPossibleType(Mono.CSharp.IMemberContext mc) { throw null; }
        public override Mono.CSharp.Expression LookupNameExpression(Mono.CSharp.ResolveContext rc, Mono.CSharp.Expression.MemberLookupRestrictions restrictions) { throw null; }
        public override Mono.CSharp.FullNamedExpression ResolveAsTypeOrNamespace(Mono.CSharp.IMemberContext mc, bool allowUnboundTypeArguments) { throw null; }
    }
    public partial class SizeOf : Mono.CSharp.Expression
    {
        public SizeOf(Mono.CSharp.Expression queried_type, Mono.CSharp.Location l) { }
        public override bool IsSideEffectFree { get { throw null; } }
        public Mono.CSharp.Expression TypeExpression { get { throw null; } }
        public override object Accept(Mono.CSharp.StructuralVisitor visitor) { throw null; }
        protected override void CloneTo(Mono.CSharp.CloneContext clonectx, Mono.CSharp.Expression t) { }
        public override bool ContainsEmitWithAwait() { throw null; }
        public override Mono.CSharp.Expression CreateExpressionTree(Mono.CSharp.ResolveContext ec) { throw null; }
        protected override Mono.CSharp.Expression DoResolve(Mono.CSharp.ResolveContext ec) { throw null; }
        public override void Emit(Mono.CSharp.EmitContext ec) { }
    }
    public partial class SourceFile : System.IEquatable<Mono.CSharp.SourceFile>
    {
        public bool AutoGenerated;
        public System.Func<Mono.CSharp.SourceFile, Mono.CSharp.SeekableStreamReader> GetInputStream;
        public readonly int Index;
        public readonly string Name;
        public readonly string OriginalFullPathName;
        public SourceFile(string name, string path, int index) { }
        public SourceFile(string name, string path, int index, System.Func<Mono.CSharp.SourceFile, Mono.CSharp.SeekableStreamReader> inputStreamDelegate) { }
        public byte[] Checksum { get { throw null; } }
        public bool HasChecksum { get { throw null; } }
        public Mono.CompilerServices.SymbolWriter.SourceFileEntry SourceFileEntry { get { throw null; } }
        public Mono.CompilerServices.SymbolWriter.SourceFileEntry CreateSymbolInfo(Mono.CompilerServices.SymbolWriter.MonoSymbolFile symwriter, System.Collections.Generic.List<System.Collections.Generic.KeyValuePair<string, string>> pathMap) { throw null; }
        public bool Equals(Mono.CSharp.SourceFile other) { throw null; }
        public string GetFullPathName(System.Collections.Generic.List<System.Collections.Generic.KeyValuePair<string, string>> pathMap) { throw null; }
        public bool IsHiddenLocation(Mono.CSharp.Location loc) { throw null; }
        public void RegisterHiddenScope(Mono.CSharp.Location start, Mono.CSharp.Location end) { }
        public void SetChecksum(byte[] checksum) { }
        public void SetChecksum(byte[] algorithmGuid, byte[] checksum) { }
        public override string ToString() { throw null; }
    }
    [System.FlagsAttribute]
    public enum SpecialConstraint
    {
        Class = 8,
        Constructor = 4,
        None = 0,
        Struct = 16,
    }
    public partial class SpecialContraintExpr : Mono.CSharp.FullNamedExpression
    {
        public SpecialContraintExpr(Mono.CSharp.SpecialConstraint constraint, Mono.CSharp.Location loc) { }
        public Mono.CSharp.SpecialConstraint Constraint { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        protected override Mono.CSharp.Expression DoResolve(Mono.CSharp.ResolveContext rc) { throw null; }
        public override Mono.CSharp.FullNamedExpression ResolveAsTypeOrNamespace(Mono.CSharp.IMemberContext mc, bool allowUnboundTypeArguments) { throw null; }
    }
    public partial class StackAlloc : Mono.CSharp.Expression
    {
        public StackAlloc(Mono.CSharp.Expression type, Mono.CSharp.Expression count, Mono.CSharp.Location l) { }
        public Mono.CSharp.Expression CountExpression { get { throw null; } }
        public Mono.CSharp.Expression TypeExpression { get { throw null; } }
        public override object Accept(Mono.CSharp.StructuralVisitor visitor) { throw null; }
        protected override void CloneTo(Mono.CSharp.CloneContext clonectx, Mono.CSharp.Expression t) { }
        public override bool ContainsEmitWithAwait() { throw null; }
        public override Mono.CSharp.Expression CreateExpressionTree(Mono.CSharp.ResolveContext ec) { throw null; }
        protected override Mono.CSharp.Expression DoResolve(Mono.CSharp.ResolveContext ec) { throw null; }
        public override void Emit(Mono.CSharp.EmitContext ec) { }
    }
    public partial class StackFieldExpr : Mono.CSharp.FieldExpr, Mono.CSharp.IExpressionCleanup
    {
        public StackFieldExpr(Mono.CSharp.Field field) : base (default(Mono.CSharp.Location)) { }
        public bool AutomaticallyReuse { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public bool IsAvailableForReuse { get { throw null; } }
        public override void AddressOf(Mono.CSharp.EmitContext ec, Mono.CSharp.AddressOp mode) { }
        public override void Emit(Mono.CSharp.EmitContext ec) { }
        public void EmitLoad(Mono.CSharp.EmitContext ec) { }
        void Mono.CSharp.IExpressionCleanup.EmitCleanup(Mono.CSharp.EmitContext ec) { }
        public void PrepareCleanup(Mono.CSharp.EmitContext ec) { }
    }
    public abstract partial class StateMachine : Mono.CSharp.AnonymousMethodStorey
    {
        protected StateMachine(Mono.CSharp.ParametersBlock block, Mono.CSharp.TypeDefinition parent, Mono.CSharp.MemberBase host, Mono.CSharp.TypeParameters tparams, string name, Mono.CSharp.MemberKind kind) : base (default(Mono.CSharp.ExplicitBlock), default(Mono.CSharp.TypeDefinition), default(Mono.CSharp.MemberBase), default(Mono.CSharp.TypeParameters), default(string), default(Mono.CSharp.MemberKind)) { }
        public Mono.CSharp.TypeParameters OriginalTypeParameters { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        public Mono.CSharp.Field PC { get { throw null; } }
        public Mono.CSharp.StateMachineMethod StateMachineMethod { get { throw null; } }
        public void AddEntryMethod(Mono.CSharp.StateMachineMethod method) { }
        protected override bool DoDefineMembers() { throw null; }
        protected override string GetVariableMangledName(Mono.CSharp.ResolveContext rc, Mono.CSharp.LocalVariable local_info) { throw null; }
        public enum State
        {
            After = -1,
            Running = -3,
            Start = 0,
            Uninitialized = -2,
        }
    }
    public abstract partial class StateMachineInitializer : Mono.CSharp.AnonymousExpression
    {
        protected System.Reflection.Emit.LocalBuilder current_pc;
        public readonly Mono.CSharp.TypeDefinition Host;
        protected System.Reflection.Emit.Label move_next_error;
        protected System.Reflection.Emit.Label move_next_ok;
        protected System.Collections.Generic.List<Mono.CSharp.ResumableStatement> resume_points;
        protected Mono.CSharp.StateMachine storey;
        protected StateMachineInitializer(Mono.CSharp.ParametersBlock block, Mono.CSharp.TypeDefinition host, Mono.CSharp.TypeSpec returnType) : base (default(Mono.CSharp.ParametersBlock), default(Mono.CSharp.TypeSpec), default(Mono.CSharp.Location)) { }
        public System.Reflection.Emit.Label BodyEnd { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public System.Reflection.Emit.LocalBuilder CurrentPC { get { throw null; } }
        public System.Reflection.Emit.LocalBuilder SkipFinally { get { throw null; } }
        public override Mono.CSharp.AnonymousMethodStorey Storey { get { throw null; } }
        public int AddResumePoint(Mono.CSharp.ResumableStatement stmt) { throw null; }
        protected virtual Mono.CSharp.BlockContext CreateBlockContext(Mono.CSharp.BlockContext bc) { throw null; }
        public override Mono.CSharp.Expression CreateExpressionTree(Mono.CSharp.ResolveContext ec) { throw null; }
        protected override Mono.CSharp.Expression DoResolve(Mono.CSharp.ResolveContext rc) { throw null; }
        public override void Emit(Mono.CSharp.EmitContext ec) { }
        public void EmitLeave(Mono.CSharp.EmitContext ec, bool unwind_protect) { }
        protected virtual void EmitMoveNextEpilogue(Mono.CSharp.EmitContext ec) { }
        public virtual void InjectYield(Mono.CSharp.EmitContext ec, Mono.CSharp.Expression expr, int resume_pc, bool unwind_protect, System.Reflection.Emit.Label resume_point) { }
        public void SetStateMachine(Mono.CSharp.StateMachine stateMachine) { }
    }
    public partial class StateMachineMethod : Mono.CSharp.Method
    {
        public StateMachineMethod(Mono.CSharp.StateMachine host, Mono.CSharp.StateMachineInitializer expr, Mono.CSharp.FullNamedExpression returnType, Mono.CSharp.Modifiers mod, Mono.CSharp.MemberName name, Mono.CSharp.Block.Flags blockFlags) : base (default(Mono.CSharp.TypeDefinition), default(Mono.CSharp.FullNamedExpression), default(Mono.CSharp.Modifiers), default(Mono.CSharp.MemberName), default(Mono.CSharp.ParametersCompiled), default(Mono.CSharp.Attributes)) { }
        public override Mono.CSharp.EmitContext CreateEmitContext(System.Reflection.Emit.ILGenerator ig, Mono.CompilerServices.SymbolWriter.SourceMethodBuilder sourceMethod) { throw null; }
    }
    public abstract partial class Statement
    {
        public Mono.CSharp.Location loc;
        protected bool reachable;
        protected Statement() { }
        public bool IsUnreachable { get { throw null; } }
        public virtual object Accept(Mono.CSharp.StructuralVisitor visitor) { throw null; }
        protected void CheckExitBoundaries(Mono.CSharp.BlockContext bc, Mono.CSharp.Block scope) { }
        public Mono.CSharp.Statement Clone(Mono.CSharp.CloneContext clonectx) { throw null; }
        protected abstract void CloneTo(Mono.CSharp.CloneContext clonectx, Mono.CSharp.Statement target);
        public virtual Mono.CSharp.Expression CreateExpressionTree(Mono.CSharp.ResolveContext ec) { throw null; }
        protected abstract void DoEmit(Mono.CSharp.EmitContext ec);
        protected abstract bool DoFlowAnalysis(Mono.CSharp.FlowAnalysisContext fc);
        public virtual void Emit(Mono.CSharp.EmitContext ec) { }
        protected void Error_FinallyClauseExit(Mono.CSharp.BlockContext bc) { }
        public bool FlowAnalysis(Mono.CSharp.FlowAnalysisContext fc) { throw null; }
        public virtual Mono.CSharp.Reachability MarkReachable(Mono.CSharp.Reachability rc) { throw null; }
        public virtual bool Resolve(Mono.CSharp.BlockContext bc) { throw null; }
    }
    public partial class StatementErrorExpression : Mono.CSharp.Statement
    {
        public StatementErrorExpression(Mono.CSharp.Expression expr) { }
        public Mono.CSharp.Expression Expr { get { throw null; } }
        public override object Accept(Mono.CSharp.StructuralVisitor visitor) { throw null; }
        protected override void CloneTo(Mono.CSharp.CloneContext clonectx, Mono.CSharp.Statement target) { }
        protected override void DoEmit(Mono.CSharp.EmitContext ec) { }
        protected override bool DoFlowAnalysis(Mono.CSharp.FlowAnalysisContext fc) { throw null; }
        public override bool Resolve(Mono.CSharp.BlockContext bc) { throw null; }
    }
    public partial class StatementExpression : Mono.CSharp.Statement
    {
        public StatementExpression(Mono.CSharp.ExpressionStatement expr) { }
        public StatementExpression(Mono.CSharp.ExpressionStatement expr, Mono.CSharp.Location loc) { }
        public Mono.CSharp.ExpressionStatement Expr { get { throw null; } }
        public override object Accept(Mono.CSharp.StructuralVisitor visitor) { throw null; }
        protected override void CloneTo(Mono.CSharp.CloneContext clonectx, Mono.CSharp.Statement t) { }
        protected override void DoEmit(Mono.CSharp.EmitContext ec) { }
        protected override bool DoFlowAnalysis(Mono.CSharp.FlowAnalysisContext fc) { throw null; }
        public override Mono.CSharp.Reachability MarkReachable(Mono.CSharp.Reachability rc) { throw null; }
        public override bool Resolve(Mono.CSharp.BlockContext ec) { throw null; }
    }
    public partial class StatementList : Mono.CSharp.Statement
    {
        public StatementList(Mono.CSharp.Statement first, Mono.CSharp.Statement second) { }
        public System.Collections.Generic.IList<Mono.CSharp.Statement> Statements { get { throw null; } }
        public override object Accept(Mono.CSharp.StructuralVisitor visitor) { throw null; }
        public void Add(Mono.CSharp.Statement statement) { }
        protected override void CloneTo(Mono.CSharp.CloneContext clonectx, Mono.CSharp.Statement target) { }
        protected override void DoEmit(Mono.CSharp.EmitContext ec) { }
        protected override bool DoFlowAnalysis(Mono.CSharp.FlowAnalysisContext fc) { throw null; }
        public override Mono.CSharp.Reachability MarkReachable(Mono.CSharp.Reachability rc) { throw null; }
        public override bool Resolve(Mono.CSharp.BlockContext ec) { throw null; }
    }
    public partial class StreamReportPrinter : Mono.CSharp.ReportPrinter
    {
        public StreamReportPrinter(System.IO.TextWriter writer) { }
        public override void Print(Mono.CSharp.AbstractMessage msg, bool showFullPath) { }
    }
    public partial class StringConcat : Mono.CSharp.Expression
    {
        internal StringConcat() { }
        public override bool ContainsEmitWithAwait() { throw null; }
        public static Mono.CSharp.StringConcat Create(Mono.CSharp.ResolveContext rc, Mono.CSharp.Expression left, Mono.CSharp.Expression right, Mono.CSharp.Location loc) { throw null; }
        public override Mono.CSharp.Expression CreateExpressionTree(Mono.CSharp.ResolveContext ec) { throw null; }
        protected override Mono.CSharp.Expression DoResolve(Mono.CSharp.ResolveContext ec) { throw null; }
        public override void Emit(Mono.CSharp.EmitContext ec) { }
        public override void FlowAnalysis(Mono.CSharp.FlowAnalysisContext fc) { }
        public override System.Linq.Expressions.Expression MakeExpression(Mono.CSharp.BuilderContext ctx) { throw null; }
    }
    public partial class StringConstant : Mono.CSharp.Constant
    {
        public StringConstant(Mono.CSharp.BuiltinTypes types, string s, Mono.CSharp.Location loc) : base (default(Mono.CSharp.Location)) { }
        protected StringConstant(Mono.CSharp.Location loc) : base (default(Mono.CSharp.Location)) { }
        public StringConstant(Mono.CSharp.TypeSpec type, string s, Mono.CSharp.Location loc) : base (default(Mono.CSharp.Location)) { }
        public override bool IsDefaultValue { get { throw null; } }
        public override bool IsNegative { get { throw null; } }
        public override bool IsNull { get { throw null; } }
        public string Value { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]protected set { } }
        public override Mono.CSharp.Constant ConvertExplicitly(bool in_checked_context, Mono.CSharp.TypeSpec target_type) { throw null; }
        public override Mono.CSharp.Constant ConvertImplicitly(Mono.CSharp.TypeSpec type) { throw null; }
        public override void Emit(Mono.CSharp.EmitContext ec) { }
        public override void EncodeAttributeValue(Mono.CSharp.IMemberContext rc, Mono.CSharp.AttributeEncoder enc, Mono.CSharp.TypeSpec targetType, Mono.CSharp.TypeSpec parameterType) { }
        public override object GetValue() { throw null; }
        public override string GetValueAsLiteral() { throw null; }
        public override long GetValueAsLong() { throw null; }
    }
    public partial class StringLiteral : Mono.CSharp.StringConstant, Mono.CSharp.ILiteralConstant
    {
        public StringLiteral(Mono.CSharp.BuiltinTypes types, string s, Mono.CSharp.Location loc) : base (default(Mono.CSharp.BuiltinTypes), default(string), default(Mono.CSharp.Location)) { }
        public override bool IsLiteral { get { throw null; } }
        public override object Accept(Mono.CSharp.StructuralVisitor visitor) { throw null; }
    }
    public sealed partial class Struct : Mono.CSharp.ClassOrStruct
    {
        public Struct(Mono.CSharp.TypeContainer parent, Mono.CSharp.MemberName name, Mono.CSharp.Modifiers mod, Mono.CSharp.Attributes attrs) : base (default(Mono.CSharp.TypeContainer), default(Mono.CSharp.MemberName), default(Mono.CSharp.Attributes), default(Mono.CSharp.MemberKind)) { }
        public override System.AttributeTargets AttributeTargets { get { throw null; } }
        public bool HasUnmanagedCheckDone { get { throw null; } }
        public override void Accept(Mono.CSharp.StructuralVisitor visitor) { }
        public override void ApplyAttributeBuilder(Mono.CSharp.Attribute a, Mono.CSharp.MethodSpec ctor, byte[] cdata, Mono.CSharp.PredefinedAttributes pa) { }
        protected override bool DoDefineMembers() { throw null; }
        public override void Emit() { }
        public override bool IsUnmanagedType() { throw null; }
        protected override Mono.CSharp.TypeSpec[] ResolveBaseTypes(out Mono.CSharp.FullNamedExpression base_class) { base_class = default(Mono.CSharp.FullNamedExpression); throw null; }
    }
    public abstract partial class StructuralVisitor
    {
        protected StructuralVisitor() { }
        public virtual object Visit(Mono.CSharp.AnonymousMethodExpression anonymousMethodExpression) { throw null; }
        public virtual object Visit(Mono.CSharp.Arglist argListExpression) { throw null; }
        public virtual object Visit(Mono.CSharp.ArglistAccess argListAccessExpression) { throw null; }
        public virtual object Visit(Mono.CSharp.ArrayCreation arrayCreationExpression) { throw null; }
        public virtual object Visit(Mono.CSharp.ArrayInitializer arrayInitializer) { throw null; }
        public virtual object Visit(Mono.CSharp.As asExpression) { throw null; }
        public virtual object Visit(Mono.CSharp.Await awaitExpr) { throw null; }
        public virtual object Visit(Mono.CSharp.BaseThis baseAccessExpression) { throw null; }
        public virtual object Visit(Mono.CSharp.Binary binaryExpression) { throw null; }
        public virtual object Visit(Mono.CSharp.Block blockStatement) { throw null; }
        public virtual object Visit(Mono.CSharp.BlockConstant blockConstantDeclaration) { throw null; }
        public virtual object Visit(Mono.CSharp.BlockVariable blockVariableDeclaration) { throw null; }
        public virtual object Visit(Mono.CSharp.BooleanExpression booleanExpression) { throw null; }
        public virtual object Visit(Mono.CSharp.Break breakStatement) { throw null; }
        public virtual object Visit(Mono.CSharp.Cast castExpression) { throw null; }
        public virtual object Visit(Mono.CSharp.Checked checkedStatement) { throw null; }
        public virtual object Visit(Mono.CSharp.CheckedExpr checkedExpression) { throw null; }
        public virtual void Visit(Mono.CSharp.Class c) { }
        public virtual void Visit(Mono.CSharp.CompilationSourceFile csf) { }
        public virtual object Visit(Mono.CSharp.ComposedCast composedCast) { throw null; }
        public virtual object Visit(Mono.CSharp.CompoundAssign compoundAssign) { throw null; }
        public virtual object Visit(Mono.CSharp.Conditional conditionalExpression) { throw null; }
        public virtual void Visit(Mono.CSharp.Const c) { }
        public virtual object Visit(Mono.CSharp.Constant constant) { throw null; }
        public virtual object Visit(Mono.CSharp.ConstInitializer constInitializer) { throw null; }
        public virtual void Visit(Mono.CSharp.Constructor c) { }
        public virtual object Visit(Mono.CSharp.Continue continueStatement) { throw null; }
        public virtual object Visit(Mono.CSharp.DefaultParameterValueExpression defaultParameterValueExpression) { throw null; }
        public virtual object Visit(Mono.CSharp.DefaultValueExpression defaultValueExpression) { throw null; }
        public virtual void Visit(Mono.CSharp.Delegate d) { }
        public virtual void Visit(Mono.CSharp.Destructor d) { }
        public virtual object Visit(Mono.CSharp.Do doStatement) { throw null; }
        public virtual object Visit(Mono.CSharp.ElementAccess elementAccessExpression) { throw null; }
        public virtual object Visit(Mono.CSharp.EmptyExpression emptyExpression) { throw null; }
        public virtual object Visit(Mono.CSharp.EmptyExpressionStatement emptyExpressionStatement) { throw null; }
        public virtual object Visit(Mono.CSharp.EmptyStatement emptyStatement) { throw null; }
        public virtual void Visit(Mono.CSharp.Enum e) { }
        public virtual void Visit(Mono.CSharp.EnumMember em) { }
        public virtual object Visit(Mono.CSharp.ErrorExpression errorExpression) { throw null; }
        public virtual void Visit(Mono.CSharp.EventField e) { }
        public virtual void Visit(Mono.CSharp.EventProperty ep) { }
        public virtual object Visit(Mono.CSharp.Expression expression) { throw null; }
        public virtual void Visit(Mono.CSharp.Field f) { }
        public virtual object Visit(Mono.CSharp.Fixed fixedStatement) { throw null; }
        public virtual void Visit(Mono.CSharp.FixedField f) { }
        public virtual object Visit(Mono.CSharp.For forStatement) { throw null; }
        public virtual object Visit(Mono.CSharp.Foreach foreachStatement) { throw null; }
        public virtual object Visit(Mono.CSharp.Goto gotoStatement) { throw null; }
        public virtual object Visit(Mono.CSharp.GotoCase gotoCase) { throw null; }
        public virtual object Visit(Mono.CSharp.GotoDefault gotoDefault) { throw null; }
        public virtual object Visit(Mono.CSharp.If ifStatement) { throw null; }
        public virtual void Visit(Mono.CSharp.Indexer i) { }
        public virtual object Visit(Mono.CSharp.Indirection indirectionExpression) { throw null; }
        public virtual void Visit(Mono.CSharp.Interface i) { }
        public virtual object Visit(Mono.CSharp.Invocation invocationExpression) { throw null; }
        public virtual object Visit(Mono.CSharp.Is isExpression) { throw null; }
        public virtual object Visit(Mono.CSharp.LabeledStatement labeledStatement) { throw null; }
        public virtual object Visit(Mono.CSharp.LambdaExpression lambdaExpression) { throw null; }
        public virtual object Visit(Mono.CSharp.Linq.GroupBy groupBy) { throw null; }
        public virtual object Visit(Mono.CSharp.Linq.GroupJoin groupJoin) { throw null; }
        public virtual object Visit(Mono.CSharp.Linq.Join join) { throw null; }
        public virtual object Visit(Mono.CSharp.Linq.Let let) { throw null; }
        public virtual object Visit(Mono.CSharp.Linq.OrderByAscending orderByAscending) { throw null; }
        public virtual object Visit(Mono.CSharp.Linq.OrderByDescending orderByDescending) { throw null; }
        public virtual object Visit(Mono.CSharp.Linq.QueryExpression queryExpression) { throw null; }
        public virtual object Visit(Mono.CSharp.Linq.QueryStartClause queryExpression) { throw null; }
        public virtual object Visit(Mono.CSharp.Linq.Select select) { throw null; }
        public virtual object Visit(Mono.CSharp.Linq.SelectMany selectMany) { throw null; }
        public virtual object Visit(Mono.CSharp.Linq.ThenByAscending thenByAscending) { throw null; }
        public virtual object Visit(Mono.CSharp.Linq.ThenByDescending thenByDescending) { throw null; }
        public virtual object Visit(Mono.CSharp.Linq.Where where) { throw null; }
        public virtual object Visit(Mono.CSharp.LocalVariableReference localVariableReference) { throw null; }
        public virtual object Visit(Mono.CSharp.Lock lockStatement) { throw null; }
        public virtual object Visit(Mono.CSharp.MakeRefExpr makeRefExpr) { throw null; }
        public virtual object Visit(Mono.CSharp.MemberAccess memberAccess) { throw null; }
        public virtual void Visit(Mono.CSharp.MemberCore member) { }
        public virtual void Visit(Mono.CSharp.Method m) { }
        public virtual void Visit(Mono.CSharp.ModuleContainer module) { }
        public virtual void Visit(Mono.CSharp.NamespaceContainer ns) { }
        public virtual object Visit(Mono.CSharp.New newExpression) { throw null; }
        public virtual object Visit(Mono.CSharp.NewAnonymousType newAnonymousType) { throw null; }
        public virtual object Visit(Mono.CSharp.NewInitialize newInitializeExpression) { throw null; }
        public virtual object Visit(Mono.CSharp.Nullable.NullCoalescingOperator nullCoalescingOperator) { throw null; }
        public virtual void Visit(Mono.CSharp.Operator o) { }
        public virtual object Visit(Mono.CSharp.ParenthesizedExpression parenthesizedExpression) { throw null; }
        public virtual void Visit(Mono.CSharp.Property p) { }
        public virtual object Visit(Mono.CSharp.QualifiedAliasMember qualifiedAliasMember) { throw null; }
        public virtual object Visit(Mono.CSharp.RefTypeExpr refTypeExpr) { throw null; }
        public virtual object Visit(Mono.CSharp.RefValueExpr refValueExpr) { throw null; }
        public virtual object Visit(Mono.CSharp.Return returnStatement) { throw null; }
        public virtual object Visit(Mono.CSharp.SimpleAssign simpleAssign) { throw null; }
        public virtual object Visit(Mono.CSharp.SimpleName simpleName) { throw null; }
        public virtual object Visit(Mono.CSharp.SizeOf sizeOfExpression) { throw null; }
        public virtual object Visit(Mono.CSharp.StackAlloc stackAllocExpression) { throw null; }
        public virtual object Visit(Mono.CSharp.Statement stmt) { throw null; }
        public virtual object Visit(Mono.CSharp.StatementErrorExpression errorStatement) { throw null; }
        public virtual object Visit(Mono.CSharp.StatementExpression statementExpression) { throw null; }
        public virtual object Visit(Mono.CSharp.StatementList statementList) { throw null; }
        public virtual void Visit(Mono.CSharp.Struct s) { }
        public virtual object Visit(Mono.CSharp.Switch switchStatement) { throw null; }
        public virtual object Visit(Mono.CSharp.SwitchLabel switchLabel) { throw null; }
        public virtual object Visit(Mono.CSharp.This thisExpression) { throw null; }
        public virtual object Visit(Mono.CSharp.Throw throwStatement) { throw null; }
        public virtual object Visit(Mono.CSharp.TryCatch tryCatchStatement) { throw null; }
        public virtual object Visit(Mono.CSharp.TryFinally tryFinallyStatement) { throw null; }
        public virtual object Visit(Mono.CSharp.TypeExpression typeExpression) { throw null; }
        public virtual object Visit(Mono.CSharp.TypeOf typeOfExpression) { throw null; }
        public virtual object Visit(Mono.CSharp.Unary unaryExpression) { throw null; }
        public virtual object Visit(Mono.CSharp.UnaryMutator unaryMutatorExpression) { throw null; }
        public virtual object Visit(Mono.CSharp.Unchecked uncheckedStatement) { throw null; }
        public virtual object Visit(Mono.CSharp.UnCheckedExpr uncheckedExpression) { throw null; }
        public virtual object Visit(Mono.CSharp.Unsafe unsafeStatement) { throw null; }
        public virtual object Visit(Mono.CSharp.Using usingStatement) { throw null; }
        public virtual void Visit(Mono.CSharp.UsingAliasNamespace uan) { }
        public virtual void Visit(Mono.CSharp.UsingExternAlias uea) { }
        public virtual void Visit(Mono.CSharp.UsingNamespace un) { }
        public virtual object Visit(Mono.CSharp.While whileStatement) { throw null; }
        public virtual object Visit(Mono.CSharp.Yield yieldStatement) { throw null; }
        public virtual object Visit(Mono.CSharp.YieldBreak yieldBreakStatement) { throw null; }
    }
    public partial class Switch : Mono.CSharp.LoopStatement
    {
        public Mono.CSharp.Expression Expr;
        public Mono.CSharp.TypeSpec SwitchType;
        public Switch(Mono.CSharp.Expression e, Mono.CSharp.ExplicitBlock block, Mono.CSharp.Location l) : base (default(Mono.CSharp.Statement)) { }
        public Mono.CSharp.SwitchLabel ActiveLabel { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public Mono.CSharp.ExplicitBlock Block { get { throw null; } }
        public Mono.CSharp.SwitchLabel DefaultLabel { get { throw null; } }
        public Mono.CSharp.VariableReference ExpressionValue { get { throw null; } }
        public bool IsNullable { get { throw null; } }
        public bool IsPatternMatching { get { throw null; } }
        public System.Collections.Generic.List<Mono.CSharp.SwitchLabel> RegisteredLabels { get { throw null; } }
        public override object Accept(Mono.CSharp.StructuralVisitor visitor) { throw null; }
        public override void AddEndDefiniteAssignment(Mono.CSharp.FlowAnalysisContext fc) { }
        protected override void CloneTo(Mono.CSharp.CloneContext clonectx, Mono.CSharp.Statement t) { }
        public static Mono.CSharp.TypeSpec[] CreateSwitchUserTypes(Mono.CSharp.ModuleContainer module, Mono.CSharp.TypeSpec nullable) { throw null; }
        protected override void DoEmit(Mono.CSharp.EmitContext ec) { }
        protected override bool DoFlowAnalysis(Mono.CSharp.FlowAnalysisContext fc) { throw null; }
        public Mono.CSharp.SwitchLabel FindLabel(Mono.CSharp.Constant value) { throw null; }
        public override Mono.CSharp.Reachability MarkReachable(Mono.CSharp.Reachability rc) { throw null; }
        public void RegisterGotoCase(Mono.CSharp.GotoCase gotoCase, Mono.CSharp.Constant value) { }
        public void RegisterLabel(Mono.CSharp.BlockContext rc, Mono.CSharp.SwitchLabel sl) { }
        public override bool Resolve(Mono.CSharp.BlockContext ec) { throw null; }
        public override void SetEndReachable() { }
    }
    public abstract partial class SwitchGoto : Mono.CSharp.Statement
    {
        protected Mono.CSharp.Switch switch_statement;
        protected bool unwind_protect;
        protected SwitchGoto(Mono.CSharp.Location loc) { }
        protected override void CloneTo(Mono.CSharp.CloneContext clonectx, Mono.CSharp.Statement target) { }
        protected override bool DoFlowAnalysis(Mono.CSharp.FlowAnalysisContext fc) { throw null; }
        protected void Error_GotoCaseRequiresSwitchBlock(Mono.CSharp.BlockContext bc) { }
        public override Mono.CSharp.Reachability MarkReachable(Mono.CSharp.Reachability rc) { throw null; }
        public override bool Resolve(Mono.CSharp.BlockContext bc) { throw null; }
    }
    public partial class SwitchLabel : Mono.CSharp.Statement
    {
        public SwitchLabel(Mono.CSharp.Expression expr, Mono.CSharp.Location l) { }
        public Mono.CSharp.Constant Converted { get { throw null; } set { } }
        public bool IsDefault { get { throw null; } }
        public Mono.CSharp.Expression Label { get { throw null; } }
        public Mono.CSharp.Location Location { get { throw null; } }
        public bool PatternMatching { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public bool SectionStart { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public override object Accept(Mono.CSharp.StructuralVisitor visitor) { throw null; }
        protected override void CloneTo(Mono.CSharp.CloneContext clonectx, Mono.CSharp.Statement target) { }
        protected override void DoEmit(Mono.CSharp.EmitContext ec) { }
        protected override bool DoFlowAnalysis(Mono.CSharp.FlowAnalysisContext fc) { throw null; }
        public void Error_AlreadyOccurs(Mono.CSharp.ResolveContext ec, Mono.CSharp.SwitchLabel collision_with) { }
        public System.Reflection.Emit.Label GetILLabel(Mono.CSharp.EmitContext ec) { throw null; }
        public string GetSignatureForError() { throw null; }
        public override bool Resolve(Mono.CSharp.BlockContext bc) { throw null; }
    }
    public enum Target
    {
        Exe = 1,
        Library = 0,
        Module = 2,
        WinExe = 3,
    }
    public partial class TemporaryVariableReference : Mono.CSharp.VariableReference
    {
        public TemporaryVariableReference(Mono.CSharp.LocalVariable li, Mono.CSharp.Location loc) { }
        public override bool IsFixed { get { throw null; } }
        public override bool IsLockedByStatement { get { throw null; } set { } }
        public override bool IsRef { get { throw null; } }
        public Mono.CSharp.LocalVariable LocalInfo { get { throw null; } }
        public override string Name { get { throw null; } }
        protected override Mono.CSharp.ILocalVariable Variable { get { throw null; } }
        public override Mono.CSharp.VariableInfo VariableInfo { get { throw null; } }
        public static Mono.CSharp.TemporaryVariableReference Create(Mono.CSharp.TypeSpec type, Mono.CSharp.Block block, Mono.CSharp.Location loc, bool writeToSymbolFile=false) { throw null; }
        protected override Mono.CSharp.Expression DoResolve(Mono.CSharp.ResolveContext ec) { throw null; }
        public override Mono.CSharp.Expression DoResolveLValue(Mono.CSharp.ResolveContext ec, Mono.CSharp.Expression right_side) { throw null; }
        public override void Emit(Mono.CSharp.EmitContext ec) { }
        public void EmitAssign(Mono.CSharp.EmitContext ec, Mono.CSharp.Expression source) { }
        public override Mono.CSharp.HoistedVariable GetHoistedVariable(Mono.CSharp.AnonymousExpression ae) { throw null; }
        public override void SetHasAddressTaken() { }
        public partial class Declarator : Mono.CSharp.Statement
        {
            public Declarator(Mono.CSharp.TemporaryVariableReference variable) { }
            protected override void CloneTo(Mono.CSharp.CloneContext clonectx, Mono.CSharp.Statement target) { }
            protected override void DoEmit(Mono.CSharp.EmitContext ec) { }
            protected override bool DoFlowAnalysis(Mono.CSharp.FlowAnalysisContext fc) { throw null; }
            public override void Emit(Mono.CSharp.EmitContext ec) { }
        }
    }
    public partial class This : Mono.CSharp.VariableReference
    {
        protected Mono.CSharp.VariableInfo variable_info;
        public This(Mono.CSharp.Location loc) { }
        public override bool IsFixed { get { throw null; } }
        public override bool IsLockedByStatement { get { throw null; } set { } }
        public override bool IsRef { get { throw null; } }
        public override bool IsSideEffectFree { get { throw null; } }
        public override string Name { get { throw null; } }
        protected override Mono.CSharp.ILocalVariable Variable { get { throw null; } }
        public override Mono.CSharp.VariableInfo VariableInfo { get { throw null; } }
        public override object Accept(Mono.CSharp.StructuralVisitor visitor) { throw null; }
        protected override void CloneTo(Mono.CSharp.CloneContext clonectx, Mono.CSharp.Expression t) { }
        protected override Mono.CSharp.Expression DoResolve(Mono.CSharp.ResolveContext ec) { throw null; }
        public override Mono.CSharp.Expression DoResolveLValue(Mono.CSharp.ResolveContext ec, Mono.CSharp.Expression right_side) { throw null; }
        public override bool Equals(object obj) { throw null; }
        protected virtual void Error_ThisNotAvailable(Mono.CSharp.ResolveContext ec) { }
        public override void FlowAnalysis(Mono.CSharp.FlowAnalysisContext fc) { }
        public override int GetHashCode() { throw null; }
        public override Mono.CSharp.HoistedVariable GetHoistedVariable(Mono.CSharp.AnonymousExpression ae) { throw null; }
        public static bool IsThisAvailable(Mono.CSharp.ResolveContext ec, bool ignoreAnonymous) { throw null; }
        public virtual void ResolveBase(Mono.CSharp.ResolveContext ec) { }
        public override void SetHasAddressTaken() { }
    }
    public partial class Throw : Mono.CSharp.Statement
    {
        public Throw(Mono.CSharp.Expression expr, Mono.CSharp.Location l) { }
        public Mono.CSharp.Expression Expr { get { throw null; } }
        public override object Accept(Mono.CSharp.StructuralVisitor visitor) { throw null; }
        protected override void CloneTo(Mono.CSharp.CloneContext clonectx, Mono.CSharp.Statement t) { }
        public static Mono.CSharp.Expression ConvertType(Mono.CSharp.ResolveContext rc, Mono.CSharp.Expression expr) { throw null; }
        protected override void DoEmit(Mono.CSharp.EmitContext ec) { }
        protected override bool DoFlowAnalysis(Mono.CSharp.FlowAnalysisContext fc) { throw null; }
        public override Mono.CSharp.Reachability MarkReachable(Mono.CSharp.Reachability rc) { throw null; }
        public override bool Resolve(Mono.CSharp.BlockContext ec) { throw null; }
    }
    public partial class Tokenizer
    {
        public bool CompleteOnEOF;
        public const int DocumentationXref = 1048579;
        public const int EvalCompilationUnitParserCharacter = 1048577;
        public const int EvalStatementParserCharacter = 1048576;
        public const int EvalUsingDeclarationsParserCharacter = 1048578;
        public const int MaxIdentifierLength = 512;
        public const int MaxNumberLength = 512;
        public bool parsing_attribute_section;
        public int parsing_block;
        public bool parsing_catch_when;
        public int parsing_declaration;
        public bool parsing_generic_declaration;
        public bool parsing_generic_declaration_doc;
        public bool parsing_interpolation_format;
        public bool parsing_modifiers;
        public int parsing_type;
        public Tokenizer(Mono.CSharp.SeekableStreamReader input, Mono.CSharp.CompilationSourceFile file, Mono.CSharp.ParserSession session, Mono.CSharp.Report report) { }
        public bool ConstraintsParsing { get { throw null; } set { } }
        public Mono.CSharp.XmlCommentState doc_state { get { throw null; } set { } }
        public bool EventParsing { get { throw null; } set { } }
        public int Line { get { throw null; } }
        public Mono.CSharp.Location Location { get { throw null; } }
        public bool PropertyParsing { get { throw null; } set { } }
        public object Value { get { throw null; } }
        public bool advance() { throw null; }
        public void check_incorrect_doc_comment() { }
        public void cleanup() { }
        public string consume_doc_comment() { throw null; }
        public void DiscardPosition() { }
        public bool IsEscapedIdentifier(Mono.CSharp.ATypeNameExpression name) { throw null; }
        public static bool IsKeyword(string s) { throw null; }
        public static bool IsValidIdentifier(string s) { throw null; }
        public int peek_token() { throw null; }
        public void PopPosition() { }
        public void PushPosition() { }
        public void putback(int c) { }
        public int token() { throw null; }
        public object value() { throw null; }
        public int xtoken() { throw null; }
        public partial class LocatedTokenBuffer
        {
            public int pos;
            public LocatedTokenBuffer() { }
            public LocatedTokenBuffer(Mono.CSharp.LocatedToken[] buffer) { }
            public Mono.CSharp.LocatedToken Create(Mono.CSharp.SourceFile file, int row, int column) { throw null; }
            public Mono.CSharp.LocatedToken Create(string value, Mono.CSharp.SourceFile file, int row, int column) { throw null; }
            [System.Diagnostics.ConditionalAttribute("FULL_AST")]
            public void CreateOptional(Mono.CSharp.SourceFile file, int row, int col, ref object token) { }
        }
        public enum PreprocessorDirective
        {
            CustomArgumentsParsing = 1024,
            Define = 2055,
            Elif = 2053,
            Else = 6,
            Endif = 4,
            Endregion = 2,
            Error = 9,
            If = 2051,
            Invalid = 0,
            Line = 1036,
            Pragma = 1035,
            Region = 1,
            RequiresArgument = 2048,
            Undef = 2056,
            Warning = 10,
        }
    }
    public partial class ToplevelBlock : Mono.CSharp.ParametersBlock
    {
        public ToplevelBlock(Mono.CSharp.CompilerContext ctx, Mono.CSharp.Location loc) : base (default(Mono.CSharp.Block), default(Mono.CSharp.ParametersCompiled), default(Mono.CSharp.Location), default(Mono.CSharp.Block.Flags)) { }
        public ToplevelBlock(Mono.CSharp.CompilerContext ctx, Mono.CSharp.ParametersCompiled parameters, Mono.CSharp.Location start, Mono.CSharp.Block.Flags flags=(Mono.CSharp.Block.Flags)(0)) : base (default(Mono.CSharp.Block), default(Mono.CSharp.ParametersCompiled), default(Mono.CSharp.Location), default(Mono.CSharp.Block.Flags)) { }
        public ToplevelBlock(Mono.CSharp.ParametersBlock source, Mono.CSharp.ParametersCompiled parameters) : base (default(Mono.CSharp.Block), default(Mono.CSharp.ParametersCompiled), default(Mono.CSharp.Location), default(Mono.CSharp.Block.Flags)) { }
        public bool IsIterator { get { throw null; } set { } }
        public Mono.CSharp.Report Report { get { throw null; } }
        public System.Collections.Generic.List<Mono.CSharp.ExplicitBlock> ThisReferencesFromChildrenBlock { get { throw null; } }
        public Mono.CSharp.LocalVariable ThisVariable { get { throw null; } }
        public void AddLabel(string name, Mono.CSharp.LabeledStatement label) { }
        public void AddLocalName(string name, Mono.CSharp.INamedBlockVariable li, bool ignoreChildrenBlocks) { }
        public void AddThisReferenceFromChildrenBlock(Mono.CSharp.ExplicitBlock block) { }
        public void AddThisVariable(Mono.CSharp.BlockContext bc) { }
        public override void CheckControlExit(Mono.CSharp.FlowAnalysisContext fc, Mono.CSharp.DefiniteAssignmentBitSet dat) { }
        public override void Emit(Mono.CSharp.EmitContext ec) { }
        public Mono.CSharp.Arguments GetAllParametersArguments() { throw null; }
        public bool GetLocalName(string name, Mono.CSharp.Block block, ref Mono.CSharp.INamedBlockVariable variable) { throw null; }
        public System.Collections.Generic.HashSet<Mono.CSharp.LocalVariable> GetUndeclaredVariables() { throw null; }
        public void IncludeBlock(Mono.CSharp.ParametersBlock pb, Mono.CSharp.ToplevelBlock block) { }
        public void RemoveThisReferenceFromChildrenBlock(Mono.CSharp.ExplicitBlock block) { }
        public bool Resolve(Mono.CSharp.BlockContext bc, Mono.CSharp.IMethodData md) { throw null; }
        public void SetUndeclaredVariables(System.Collections.Generic.HashSet<Mono.CSharp.LocalVariable> undeclaredVariables) { }
    }
    public partial class TryCatch : Mono.CSharp.ExceptionStatement
    {
        public Mono.CSharp.Block Block;
        public TryCatch(Mono.CSharp.Block block, System.Collections.Generic.List<Mono.CSharp.Catch> catch_clauses, Mono.CSharp.Location l, bool inside_try_finally) : base (default(Mono.CSharp.Location)) { }
        public System.Collections.Generic.List<Mono.CSharp.Catch> Clauses { get { throw null; } }
        public bool HasClauseWithAwait { get { throw null; } }
        public bool IsTryCatchFinally { get { throw null; } }
        public override object Accept(Mono.CSharp.StructuralVisitor visitor) { throw null; }
        protected override void CloneTo(Mono.CSharp.CloneContext clonectx, Mono.CSharp.Statement t) { }
        protected sealed override void DoEmit(Mono.CSharp.EmitContext ec) { }
        protected override bool DoFlowAnalysis(Mono.CSharp.FlowAnalysisContext fc) { throw null; }
        public override Mono.CSharp.Reachability MarkReachable(Mono.CSharp.Reachability rc) { throw null; }
        public override bool Resolve(Mono.CSharp.BlockContext bc) { throw null; }
    }
    public partial class TryFinally : Mono.CSharp.TryFinallyBlock
    {
        public TryFinally(Mono.CSharp.Statement stmt, Mono.CSharp.ExplicitBlock fini, Mono.CSharp.Location loc) : base (default(Mono.CSharp.Statement), default(Mono.CSharp.Location)) { }
        public Mono.CSharp.ExplicitBlock FinallyBlock { get { throw null; } }
        public override object Accept(Mono.CSharp.StructuralVisitor visitor) { throw null; }
        protected override void CloneTo(Mono.CSharp.CloneContext clonectx, Mono.CSharp.Statement t) { }
        protected override bool DoFlowAnalysis(Mono.CSharp.FlowAnalysisContext fc) { throw null; }
        protected override bool EmitBeginFinallyBlock(Mono.CSharp.EmitContext ec) { throw null; }
        public override void EmitFinallyBody(Mono.CSharp.EmitContext ec) { }
        public static System.Reflection.Emit.Label EmitRedirectedJump(Mono.CSharp.EmitContext ec, Mono.CSharp.AsyncInitializer initializer, System.Reflection.Emit.Label label, Mono.CSharp.Block labelBlock, bool unwindProtect) { throw null; }
        public static System.Reflection.Emit.Label EmitRedirectedReturn(Mono.CSharp.EmitContext ec, Mono.CSharp.AsyncInitializer initializer, bool unwindProtect) { throw null; }
        protected override void EmitTryBody(Mono.CSharp.EmitContext ec) { }
        public override Mono.CSharp.Reachability MarkReachable(Mono.CSharp.Reachability rc) { throw null; }
        public void RegisterForControlExitCheck(Mono.CSharp.DefiniteAssignmentBitSet vector) { }
        public override bool Resolve(Mono.CSharp.BlockContext bc) { throw null; }
    }
    public abstract partial class TryFinallyBlock : Mono.CSharp.ExceptionStatement
    {
        protected Mono.CSharp.Statement stmt;
        protected TryFinallyBlock(Mono.CSharp.Statement stmt, Mono.CSharp.Location loc) : base (default(Mono.CSharp.Location)) { }
        public Mono.CSharp.Statement Statement { get { throw null; } }
        protected sealed override void DoEmit(Mono.CSharp.EmitContext ec) { }
        protected override bool DoFlowAnalysis(Mono.CSharp.FlowAnalysisContext fc) { throw null; }
        protected virtual bool EmitBeginFinallyBlock(Mono.CSharp.EmitContext ec) { throw null; }
        public abstract void EmitFinallyBody(Mono.CSharp.EmitContext ec);
        public override void EmitForDispose(Mono.CSharp.EmitContext ec, System.Reflection.Emit.LocalBuilder pc, System.Reflection.Emit.Label end, bool have_dispatcher) { }
        protected abstract void EmitTryBody(Mono.CSharp.EmitContext ec);
        public override Mono.CSharp.Reachability MarkReachable(Mono.CSharp.Reachability rc) { throw null; }
        public override System.Reflection.Emit.Label PrepareForDispose(Mono.CSharp.EmitContext ec, System.Reflection.Emit.Label end) { throw null; }
        public override bool Resolve(Mono.CSharp.BlockContext bc) { throw null; }
    }
    public partial class TypeArguments
    {
        public TypeArguments(params Mono.CSharp.FullNamedExpression[] types) { }
        public Mono.CSharp.TypeSpec[] Arguments { get { throw null; } set { } }
        public int Count { get { throw null; } }
        public virtual bool IsEmpty { get { throw null; } }
        public System.Collections.Generic.List<Mono.CSharp.FullNamedExpression> TypeExpressions { get { throw null; } }
        public void Add(Mono.CSharp.FullNamedExpression type) { }
        public Mono.CSharp.TypeArguments Clone() { throw null; }
        public string GetSignatureForError() { throw null; }
        public virtual bool Resolve(Mono.CSharp.IMemberContext ec, bool allowUnbound) { throw null; }
    }
    public abstract partial class TypeCast : Mono.CSharp.Expression
    {
        protected readonly Mono.CSharp.Expression child;
        protected TypeCast(Mono.CSharp.Expression child, Mono.CSharp.TypeSpec return_type) { }
        public Mono.CSharp.Expression Child { get { throw null; } }
        public override bool IsNull { get { throw null; } }
        protected override void CloneTo(Mono.CSharp.CloneContext clonectx, Mono.CSharp.Expression t) { }
        public override bool ContainsEmitWithAwait() { throw null; }
        public override Mono.CSharp.Expression CreateExpressionTree(Mono.CSharp.ResolveContext ec) { throw null; }
        protected override Mono.CSharp.Expression DoResolve(Mono.CSharp.ResolveContext ec) { throw null; }
        public override void Emit(Mono.CSharp.EmitContext ec) { }
        public override void FlowAnalysis(Mono.CSharp.FlowAnalysisContext fc) { }
        public override System.Linq.Expressions.Expression MakeExpression(Mono.CSharp.BuilderContext ctx) { throw null; }
        public override Mono.CSharp.Reachability MarkReachable(Mono.CSharp.Reachability rc) { throw null; }
    }
    public abstract partial class TypeContainer : Mono.CSharp.MemberCore
    {
        protected System.Collections.Generic.List<Mono.CSharp.TypeContainer> containers;
        protected System.Collections.Generic.Dictionary<string, Mono.CSharp.MemberCore> defined_names;
        protected bool is_defined;
        public readonly Mono.CSharp.MemberKind Kind;
        protected TypeContainer(Mono.CSharp.TypeContainer parent, Mono.CSharp.MemberName name, Mono.CSharp.Attributes attrs, Mono.CSharp.MemberKind kind) : base (default(Mono.CSharp.TypeContainer), default(Mono.CSharp.MemberName), default(Mono.CSharp.Attributes)) { }
        public System.Collections.Generic.IList<Mono.CSharp.TypeContainer> Containers { get { throw null; } }
        public int CounterAnonymousContainers { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public int CounterAnonymousMethods { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public int CounterSwitchTypes { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public override Mono.CSharp.TypeSpec CurrentType { get { throw null; } }
        public System.Collections.Generic.Dictionary<string, Mono.CSharp.MemberCore> DefinedNames { get { throw null; } }
        public Mono.CSharp.TypeDefinition PartialContainer { get { throw null; } protected set { } }
        public Mono.CSharp.Attributes UnattachedAttributes { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public void AddCompilerGeneratedClass(Mono.CSharp.CompilerGeneratedContainer c) { }
        public virtual void AddPartial(Mono.CSharp.TypeDefinition next_part) { }
        protected void AddPartial(Mono.CSharp.TypeDefinition next_part, Mono.CSharp.TypeDefinition existing) { }
        public virtual void AddTypeContainer(Mono.CSharp.TypeContainer tc) { }
        protected virtual void AddTypeContainerMember(Mono.CSharp.TypeContainer tc) { }
        public virtual void CloseContainer() { }
        public virtual bool CreateContainer() { throw null; }
        public virtual void CreateMetadataName(System.Text.StringBuilder sb) { }
        public override bool Define() { throw null; }
        public virtual bool DefineContainer() { throw null; }
        protected virtual void DefineNamespace() { }
        protected virtual void DoDefineContainer() { }
        public virtual void EmitContainer() { }
        protected void Error_MissingPartialModifier(Mono.CSharp.MemberCore type) { }
        public virtual void ExpandBaseInterfaces() { }
        public override string GetSignatureForDocumentation() { throw null; }
        public override string GetSignatureForError() { throw null; }
        public virtual string GetSignatureForMetadata() { throw null; }
        public virtual void PrepareEmit() { }
        public virtual void RemoveContainer(Mono.CSharp.TypeContainer cont) { }
        public virtual void VerifyMembers() { }
        public override void WriteDebugSymbol(Mono.CompilerServices.SymbolWriter.MonoSymbolFile file) { }
    }
    public abstract partial class TypeDefinition : Mono.CSharp.TypeContainer, Mono.CSharp.IMemberDefinition, Mono.CSharp.ITypeDefinition
    {
        public int AnonymousMethodsCounter;
        protected Mono.CSharp.TypeSpec base_type;
        public const string DefaultIndexerName = "Item";
        public int DynamicSitesCounter;
        protected Mono.CSharp.FieldBase first_nonstatic_field;
        protected bool has_static_constructor;
        protected Mono.CSharp.TypeSpec[] iface_exprs;
        protected System.Collections.Generic.List<Mono.CSharp.FieldInitializer> initialized_fields;
        protected System.Collections.Generic.List<Mono.CSharp.FieldInitializer> initialized_static_fields;
        public int MethodGroupsCounter;
        protected Mono.CSharp.TypeSpec spec;
        public System.Reflection.Emit.TypeBuilder TypeBuilder;
        protected System.Collections.Generic.List<Mono.CSharp.FullNamedExpression> type_bases;
        protected TypeDefinition(Mono.CSharp.TypeContainer parent, Mono.CSharp.MemberName name, Mono.CSharp.Attributes attrs, Mono.CSharp.MemberKind kind) : base (default(Mono.CSharp.TypeContainer), default(Mono.CSharp.MemberName), default(Mono.CSharp.Attributes), default(Mono.CSharp.MemberKind)) { }
        public override System.AttributeTargets AttributeTargets { get { throw null; } }
        public Mono.CSharp.TypeSpec BaseType { get { throw null; } }
        public System.Collections.Generic.List<Mono.CSharp.FullNamedExpression> BaseTypeExpressions { get { throw null; } }
        public override Mono.CSharp.TypeSpec CurrentType { get { throw null; } }
        public override Mono.CSharp.TypeParameters CurrentTypeParameters { get { throw null; } }
        public virtual Mono.CSharp.AssemblyDefinition DeclaringAssembly { get { throw null; } }
        public Mono.CSharp.TypeSpec Definition { get { throw null; } }
        public override string DocComment { get { throw null; } set { } }
        public override string DocCommentHeader { get { throw null; } }
        public bool HasEquals { get { throw null; } }
        public bool HasExplicitLayout { get { throw null; } set { } }
        public bool HasGetHashCode { get { throw null; } }
        public bool HasInstanceConstructor { get { throw null; } set { } }
        public bool HasInstanceField { get { throw null; } set { } }
        public bool HasMembersDefined { get { throw null; } }
        public bool HasOperators { get { throw null; } set { } }
        public bool HasStaticFieldInitializer { get { throw null; } set { } }
        public bool HasStructLayout { get { throw null; } set { } }
        public Mono.CSharp.TypeSpec[] Interfaces { get { throw null; } }
        public bool IsComImport { get { throw null; } }
        public bool IsGenericOrParentIsGeneric { get { throw null; } }
        public bool IsPartial { get { throw null; } }
        public bool IsTopLevel { get { throw null; } }
        public Mono.CSharp.MemberCache MemberCache { get { throw null; } }
        public System.Collections.Generic.List<Mono.CSharp.MemberCore> Members { get { throw null; } }
        Mono.CSharp.IAssemblyDefinition Mono.CSharp.ITypeDefinition.DeclaringAssembly { get { throw null; } }
        bool Mono.CSharp.ITypeDefinition.IsCyclicTypeForwarder { get { throw null; } }
        bool Mono.CSharp.ITypeDefinition.IsTypeForwarder { get { throw null; } }
        string Mono.CSharp.ITypeDefinition.Namespace { get { throw null; } }
        Mono.CSharp.TypeParameterSpec[] Mono.CSharp.ITypeDefinition.TypeParameters { get { throw null; } }
        public Mono.CSharp.PendingImplementation PendingImplementations { get { throw null; } }
        public Mono.CSharp.Arguments PrimaryConstructorBaseArguments { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public Mono.CSharp.Location PrimaryConstructorBaseArgumentsStart { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public Mono.CSharp.ParametersCompiled PrimaryConstructorParameters { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        protected virtual System.Reflection.TypeAttributes TypeAttr { get { throw null; } }
        public Mono.CSharp.TypeParameters TypeParametersAll { get { throw null; } }
        public int TypeParametersCount { get { throw null; } }
        public override string[] ValidAttributeTargets { get { throw null; } }
        public override void Accept(Mono.CSharp.StructuralVisitor visitor) { }
        public void AddConstructor(Mono.CSharp.Constructor c) { }
        public void AddConstructor(Mono.CSharp.Constructor c, bool isDefault) { }
        public bool AddField(Mono.CSharp.FieldBase field) { throw null; }
        public void AddIndexer(Mono.CSharp.Indexer i) { }
        public void AddMember(Mono.CSharp.MemberCore symbol) { }
        public virtual void AddNameToContainer(Mono.CSharp.MemberCore symbol, string name) { }
        public void AddOperator(Mono.CSharp.Operator op) { }
        public void AddPartialPart(Mono.CSharp.TypeDefinition part) { }
        public override void AddTypeContainer(Mono.CSharp.TypeContainer tc) { }
        protected override void AddTypeContainerMember(Mono.CSharp.TypeContainer tc) { }
        public override void ApplyAttributeBuilder(Mono.CSharp.Attribute a, Mono.CSharp.MethodSpec ctor, byte[] cdata, Mono.CSharp.PredefinedAttributes pa) { }
        public override void CloseContainer() { }
        public override bool CreateContainer() { throw null; }
        public Mono.CSharp.MethodSpec CreateHoistedBaseCallProxy(Mono.CSharp.ResolveContext rc, Mono.CSharp.MethodSpec method) { throw null; }
        public override void CreateMetadataName(System.Text.StringBuilder sb) { }
        public Mono.CompilerServices.SymbolWriter.SourceMethodBuilder CreateMethodSymbolEntry() { throw null; }
        public sealed override bool Define() { throw null; }
        protected bool DefineBaseTypes() { throw null; }
        protected override void DoDefineContainer() { }
        protected virtual bool DoDefineMembers() { throw null; }
        public void DoExpandBaseInterfaces() { }
        protected virtual bool DoResolveTypeParameters() { throw null; }
        public override void Emit() { }
        public sealed override void EmitContainer() { }
        public override void ExpandBaseInterfaces() { }
        public static string FilterNestedName(string name) { throw null; }
        public Mono.CSharp.TypeSpec GetAttributeCoClass() { throw null; }
        public string GetAttributeDefaultMember() { throw null; }
        public System.AttributeUsageAttribute GetAttributeUsage(Mono.CSharp.PredefinedAttribute pa) { throw null; }
        public virtual Mono.CSharp.CompilationSourceFile GetCompilationSourceFile() { throw null; }
        public override string GetSignatureForMetadata() { throw null; }
        public bool IsBaseTypeDefinition(Mono.CSharp.TypeSpec baseType) { throw null; }
        public override bool IsClsComplianceRequired() { throw null; }
        public virtual bool IsUnmanagedType() { throw null; }
        public void LoadMembers(Mono.CSharp.TypeSpec declaringType, bool onlyTypes, ref Mono.CSharp.MemberCache cache) { }
        public override Mono.CSharp.FullNamedExpression LookupNamespaceOrType(string name, int arity, Mono.CSharp.LookupMode mode, Mono.CSharp.Location loc) { throw null; }
        public void Mark_HasEquals() { }
        public void Mark_HasGetHashCode() { }
        public bool MethodModifiersValid(Mono.CSharp.MemberCore mc) { throw null; }
        bool Mono.CSharp.ITypeDefinition.IsInternalAsPublic(Mono.CSharp.IAssemblyDefinition assembly) { throw null; }
        public override void PrepareEmit() { }
        public void RegisterFieldForInitialization(Mono.CSharp.MemberCore field, Mono.CSharp.FieldInitializer expression) { }
        public override void RemoveContainer(Mono.CSharp.TypeContainer cont) { }
        protected virtual Mono.CSharp.TypeSpec[] ResolveBaseTypes(out Mono.CSharp.FullNamedExpression base_class) { base_class = default(Mono.CSharp.FullNamedExpression); throw null; }
        public void ResolveFieldInitializers(Mono.CSharp.BlockContext ec) { }
        public virtual void SetBaseTypes(System.Collections.Generic.List<Mono.CSharp.FullNamedExpression> baseTypes) { }
        public void SetPredefinedSpec(Mono.CSharp.BuiltinTypeSpec spec) { }
        protected override bool VerifyClsCompliance() { throw null; }
        public bool VerifyImplements(Mono.CSharp.InterfaceMemberBase mb) { throw null; }
        public override void VerifyMembers() { }
        public override void WriteDebugSymbol(Mono.CompilerServices.SymbolWriter.MonoSymbolFile file) { }
        [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
        public partial struct BaseContext : Mono.CSharp.IMemberContext, Mono.CSharp.IModuleContext
        {
            public BaseContext(Mono.CSharp.TypeContainer tc) { throw null;}
            public Mono.CSharp.CompilerContext Compiler { get { throw null; } }
            public Mono.CSharp.MemberCore CurrentMemberDefinition { get { throw null; } }
            public Mono.CSharp.TypeSpec CurrentType { get { throw null; } }
            public Mono.CSharp.TypeParameters CurrentTypeParameters { get { throw null; } }
            public bool IsObsolete { get { throw null; } }
            public bool IsStatic { get { throw null; } }
            public bool IsUnsafe { get { throw null; } }
            public Mono.CSharp.ModuleContainer Module { get { throw null; } }
            public string GetSignatureForError() { throw null; }
            public Mono.CSharp.ExtensionMethodCandidates LookupExtensionMethod(string name, int arity) { throw null; }
            public Mono.CSharp.FullNamedExpression LookupNamespaceAlias(string name) { throw null; }
            public Mono.CSharp.FullNamedExpression LookupNamespaceOrType(string name, int arity, Mono.CSharp.LookupMode mode, Mono.CSharp.Location loc) { throw null; }
        }
    }
    public abstract partial class TypeExpr : Mono.CSharp.FullNamedExpression
    {
        protected TypeExpr() { }
        protected sealed override Mono.CSharp.Expression DoResolve(Mono.CSharp.ResolveContext ec) { throw null; }
        public override bool Equals(object obj) { throw null; }
        public override int GetHashCode() { throw null; }
        public sealed override Mono.CSharp.FullNamedExpression ResolveAsTypeOrNamespace(Mono.CSharp.IMemberContext mc, bool allowUnboundTypeArguments) { throw null; }
    }
    public partial class TypeExpression : Mono.CSharp.TypeExpr
    {
        public TypeExpression(Mono.CSharp.TypeSpec t, Mono.CSharp.Location l) { }
        public sealed override Mono.CSharp.TypeSpec ResolveAsType(Mono.CSharp.IMemberContext mc, bool allowUnboundTypeArguments=false) { throw null; }
    }
    public static partial class TypeExtensions
    {
        public static string GetNamespace(this System.Type t) { throw null; }
    }
    public partial class TypeInferenceContext
    {
        public TypeInferenceContext() { }
        public TypeInferenceContext(Mono.CSharp.TypeSpec[] typeArguments) { }
        public Mono.CSharp.TypeSpec[] InferredTypeArguments { get { throw null; } }
        public bool UnfixedVariableExists { get { throw null; } }
        public void AddCommonTypeBound(Mono.CSharp.TypeSpec type) { }
        public void AddCommonTypeBoundAsync(Mono.CSharp.TypeSpec type) { }
        public int ExactInference(Mono.CSharp.TypeSpec u, Mono.CSharp.TypeSpec v) { throw null; }
        public bool FixAllTypes(Mono.CSharp.ResolveContext ec) { throw null; }
        public bool FixDependentTypes(Mono.CSharp.ResolveContext ec, ref bool fixed_any) { throw null; }
        public bool FixIndependentTypeArguments(Mono.CSharp.ResolveContext ec, Mono.CSharp.TypeSpec[] methodParameters, ref bool fixed_any) { throw null; }
        public bool FixType(Mono.CSharp.ResolveContext ec, int i) { throw null; }
        public bool HasBounds(int pos) { throw null; }
        public Mono.CSharp.TypeSpec InflateGenericArgument(Mono.CSharp.IModuleContext context, Mono.CSharp.TypeSpec parameter) { throw null; }
        public bool IsReturnTypeNonDependent(Mono.CSharp.MethodSpec invoke, Mono.CSharp.TypeSpec returnType) { throw null; }
        public int LowerBoundInference(Mono.CSharp.TypeSpec u, Mono.CSharp.TypeSpec v) { throw null; }
        public int OutputTypeInference(Mono.CSharp.ResolveContext ec, Mono.CSharp.Expression e, Mono.CSharp.TypeSpec t) { throw null; }
        protected enum BoundKind
        {
            Exact = 0,
            Lower = 1,
            Upper = 2,
        }
    }
    public partial class TypeInfo
    {
        internal TypeInfo() { }
        public readonly bool IsStruct;
        public readonly int Length;
        public readonly int Offset;
        public Mono.CSharp.TypeInfo[] SubStructInfo;
        public readonly int TotalLength;
        public int GetFieldIndex(string name) { throw null; }
        public Mono.CSharp.TypeInfo GetStructField(string name) { throw null; }
        public static Mono.CSharp.TypeInfo GetTypeInfo(Mono.CSharp.TypeSpec type, Mono.CSharp.IMemberContext context) { throw null; }
        public bool IsFullyInitialized(Mono.CSharp.FlowAnalysisContext fc, Mono.CSharp.VariableInfo vi, Mono.CSharp.Location loc) { throw null; }
        public static void Reset() { }
        public override string ToString() { throw null; }
    }
    public partial class TypeOf : Mono.CSharp.Expression
    {
        public TypeOf(Mono.CSharp.FullNamedExpression queried_type, Mono.CSharp.Location l) { }
        public TypeOf(Mono.CSharp.TypeSpec type, Mono.CSharp.Location loc) { }
        public override bool IsSideEffectFree { get { throw null; } }
        public Mono.CSharp.TypeSpec TypeArgument { get { throw null; } }
        public Mono.CSharp.FullNamedExpression TypeExpression { get { throw null; } }
        public override object Accept(Mono.CSharp.StructuralVisitor visitor) { throw null; }
        protected override void CloneTo(Mono.CSharp.CloneContext clonectx, Mono.CSharp.Expression t) { }
        public override bool ContainsEmitWithAwait() { throw null; }
        public override Mono.CSharp.Expression CreateExpressionTree(Mono.CSharp.ResolveContext ec) { throw null; }
        protected override Mono.CSharp.Expression DoResolve(Mono.CSharp.ResolveContext ec) { throw null; }
        public override void Emit(Mono.CSharp.EmitContext ec) { }
        public override void EncodeAttributeValue(Mono.CSharp.IMemberContext rc, Mono.CSharp.AttributeEncoder enc, Mono.CSharp.TypeSpec targetType, Mono.CSharp.TypeSpec parameterType) { }
    }
    public partial class TypeParameter : Mono.CSharp.MemberCore, Mono.CSharp.IMemberDefinition, Mono.CSharp.ITypeDefinition
    {
        public TypeParameter(Mono.CSharp.MemberName name, Mono.CSharp.Attributes attrs, Mono.CSharp.VarianceDecl variance) : base (default(Mono.CSharp.TypeContainer), default(Mono.CSharp.MemberName), default(Mono.CSharp.Attributes)) { }
        public TypeParameter(Mono.CSharp.TypeParameterSpec spec, Mono.CSharp.TypeSpec parentSpec, Mono.CSharp.MemberName name, Mono.CSharp.Attributes attrs) : base (default(Mono.CSharp.TypeContainer), default(Mono.CSharp.MemberName), default(Mono.CSharp.Attributes)) { }
        public TypeParameter(int index, Mono.CSharp.MemberName name, Mono.CSharp.Constraints constraints, Mono.CSharp.Attributes attrs, Mono.CSharp.Variance Variance) : base (default(Mono.CSharp.TypeContainer), default(Mono.CSharp.MemberName), default(Mono.CSharp.Attributes)) { }
        public override System.AttributeTargets AttributeTargets { get { throw null; } }
        public Mono.CSharp.Constraints Constraints { get { throw null; } set { } }
        public Mono.CSharp.IAssemblyDefinition DeclaringAssembly { get { throw null; } }
        public override string DocCommentHeader { get { throw null; } }
        public bool IsMethodTypeParameter { get { throw null; } }
        bool Mono.CSharp.ITypeDefinition.IsComImport { get { throw null; } }
        bool Mono.CSharp.ITypeDefinition.IsCyclicTypeForwarder { get { throw null; } }
        bool Mono.CSharp.ITypeDefinition.IsPartial { get { throw null; } }
        bool Mono.CSharp.ITypeDefinition.IsTypeForwarder { get { throw null; } }
        public string Name { get { throw null; } }
        public string Namespace { get { throw null; } }
        public Mono.CSharp.TypeParameterSpec Type { get { throw null; } }
        public Mono.CSharp.TypeParameterSpec[] TypeParameters { get { throw null; } }
        public int TypeParametersCount { get { throw null; } }
        public override string[] ValidAttributeTargets { get { throw null; } }
        public Mono.CSharp.Variance Variance { get { throw null; } }
        public Mono.CSharp.VarianceDecl VarianceDecl { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        public bool AddPartialConstraints(Mono.CSharp.TypeDefinition part, Mono.CSharp.TypeParameter tp) { throw null; }
        public override void ApplyAttributeBuilder(Mono.CSharp.Attribute a, Mono.CSharp.MethodSpec ctor, byte[] cdata, Mono.CSharp.PredefinedAttributes pa) { }
        public void CheckGenericConstraints(bool obsoleteCheck) { }
        public void Create(Mono.CSharp.TypeSpec declaringType, Mono.CSharp.TypeContainer parent) { }
        public Mono.CSharp.TypeParameter CreateHoistedCopy(Mono.CSharp.TypeSpec declaringSpec) { throw null; }
        public override bool Define() { throw null; }
        public void Define(Mono.CSharp.TypeParameter tp) { }
        public void Define(System.Reflection.Emit.GenericTypeParameterBuilder type) { }
        public override void Emit() { }
        public void EmitConstraints(System.Reflection.Emit.GenericTypeParameterBuilder builder) { }
        public void ErrorInvalidVariance(Mono.CSharp.IMemberContext mc, Mono.CSharp.Variance expected) { }
        public Mono.CSharp.TypeSpec GetAttributeCoClass() { throw null; }
        public string GetAttributeDefaultMember() { throw null; }
        public System.AttributeUsageAttribute GetAttributeUsage(Mono.CSharp.PredefinedAttribute pa) { throw null; }
        public override string GetSignatureForDocumentation() { throw null; }
        public override string GetSignatureForError() { throw null; }
        public override bool IsClsComplianceRequired() { throw null; }
        public void LoadMembers(Mono.CSharp.TypeSpec declaringType, bool onlyTypes, ref Mono.CSharp.MemberCache cache) { }
        bool Mono.CSharp.ITypeDefinition.IsInternalAsPublic(Mono.CSharp.IAssemblyDefinition assembly) { throw null; }
        public bool ResolveConstraints(Mono.CSharp.IMemberContext context) { throw null; }
        public new void VerifyClsCompliance() { }
        public void WarningParentNameConflict(Mono.CSharp.TypeParameter conflict) { }
    }
    public partial class TypeParameterExpr : Mono.CSharp.TypeExpression
    {
        public TypeParameterExpr(Mono.CSharp.TypeParameter type_parameter, Mono.CSharp.Location loc) : base (default(Mono.CSharp.TypeSpec), default(Mono.CSharp.Location)) { }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public partial struct TypeParameterInflator
    {
        public TypeParameterInflator(Mono.CSharp.IModuleContext context, Mono.CSharp.TypeSpec type, Mono.CSharp.TypeParameterSpec[] tparams, Mono.CSharp.TypeSpec[] targs) { throw null;}
        public TypeParameterInflator(Mono.CSharp.TypeParameterInflator nested, Mono.CSharp.TypeSpec type) { throw null;}
        public Mono.CSharp.IModuleContext Context { get { throw null; } }
        public Mono.CSharp.TypeSpec TypeInstance { get { throw null; } }
        public Mono.CSharp.TypeParameterSpec[] TypeParameters { get { throw null; } }
        public Mono.CSharp.TypeSpec Inflate(Mono.CSharp.TypeParameterSpec tp) { throw null; }
        public Mono.CSharp.TypeSpec Inflate(Mono.CSharp.TypeSpec type) { throw null; }
    }
    public partial class TypeParameterMutator
    {
        public TypeParameterMutator(Mono.CSharp.TypeParameters mvar, Mono.CSharp.TypeParameters var) { }
        public TypeParameterMutator(Mono.CSharp.TypeParameterSpec[] srcVar, Mono.CSharp.TypeParameters destVar) { }
        public Mono.CSharp.TypeParameters MethodTypeParameters { get { throw null; } }
        public static Mono.CSharp.TypeSpec GetMemberDeclaringType(Mono.CSharp.TypeSpec type) { throw null; }
        public Mono.CSharp.TypeParameterSpec Mutate(Mono.CSharp.TypeParameterSpec tp) { throw null; }
        public Mono.CSharp.TypeSpec Mutate(Mono.CSharp.TypeSpec ts) { throw null; }
        public Mono.CSharp.TypeSpec[] Mutate(Mono.CSharp.TypeSpec[] targs) { throw null; }
    }
    public partial class TypeParameters
    {
        public TypeParameters() { }
        public TypeParameters(int count) { }
        public int Count { get { throw null; } }
        public Mono.CSharp.TypeParameter this[int index] { get { throw null; } set { } }
        public Mono.CSharp.TypeParameterSpec[] Types { get { throw null; } }
        public void Add(Mono.CSharp.TypeParameter tparam) { }
        public void Add(Mono.CSharp.TypeParameters tparams) { }
        public void CheckPartialConstraints(Mono.CSharp.Method part) { }
        public void Create(Mono.CSharp.TypeSpec declaringType, int parentOffset, Mono.CSharp.TypeContainer parent) { }
        public void Define(System.Reflection.Emit.GenericTypeParameterBuilder[] builders) { }
        public Mono.CSharp.TypeParameter Find(string name) { throw null; }
        public string[] GetAllNames() { throw null; }
        public string GetSignatureForError() { throw null; }
        public void UpdateConstraints(Mono.CSharp.TypeDefinition part) { }
        public void VerifyClsCompliance() { }
    }
    [System.Diagnostics.DebuggerDisplayAttribute("{DisplayDebugInfo()}")]
    public partial class TypeParameterSpec : Mono.CSharp.TypeSpec
    {
        public static readonly new Mono.CSharp.TypeParameterSpec[] EmptyTypes;
        public TypeParameterSpec(Mono.CSharp.TypeSpec declaringType, int index, Mono.CSharp.ITypeDefinition definition, Mono.CSharp.SpecialConstraint spec, Mono.CSharp.Variance variance, System.Type info) : base (default(Mono.CSharp.MemberKind), default(Mono.CSharp.TypeSpec), default(Mono.CSharp.ITypeDefinition), default(System.Type), default(Mono.CSharp.Modifiers)) { }
        public TypeParameterSpec(int index, Mono.CSharp.ITypeDefinition definition, Mono.CSharp.SpecialConstraint spec, Mono.CSharp.Variance variance, System.Type info) : base (default(Mono.CSharp.MemberKind), default(Mono.CSharp.TypeSpec), default(Mono.CSharp.ITypeDefinition), default(System.Type), default(Mono.CSharp.Modifiers)) { }
        public int DeclaredPosition { get { throw null; } set { } }
        public bool HasAnyTypeConstraint { get { throw null; } }
        public bool HasSpecialClass { get { throw null; } }
        public bool HasSpecialConstructor { get { throw null; } }
        public bool HasSpecialStruct { get { throw null; } }
        public bool HasTypeConstraint { get { throw null; } }
        public Mono.CSharp.MemberCache InterfaceCache { get { throw null; } }
        public override System.Collections.Generic.IList<Mono.CSharp.TypeSpec> Interfaces { get { throw null; } }
        public Mono.CSharp.TypeSpec[] InterfacesDefined { get { throw null; } set { } }
        public bool IsConstrained { get { throw null; } }
        public bool IsMethodOwned { get { throw null; } }
        public bool IsReferenceType { get { throw null; } }
        public bool IsValueType { get { throw null; } }
        public override string Name { get { throw null; } }
        public Mono.CSharp.SpecialConstraint SpecialConstraint { get { throw null; } set { } }
        public new Mono.CSharp.TypeSpec[] TypeArguments { get { throw null; } set { } }
        public Mono.CSharp.Variance Variance { get { throw null; } }
        public string DisplayDebugInfo() { throw null; }
        public Mono.CSharp.TypeSpec GetEffectiveBase() { throw null; }
        public override string GetSignatureForDocumentation(bool explicitName) { throw null; }
        public override string GetSignatureForError() { throw null; }
        public static bool HasAnyTypeParameterConstrained(Mono.CSharp.IGenericMethodDefinition md) { throw null; }
        public static bool HasAnyTypeParameterTypeConstrained(Mono.CSharp.IGenericMethodDefinition md) { throw null; }
        public bool HasDependencyOn(Mono.CSharp.TypeSpec type) { throw null; }
        public bool HasSameConstraintsDefinition(Mono.CSharp.TypeParameterSpec other) { throw null; }
        public bool HasSameConstraintsImplementation(Mono.CSharp.TypeParameterSpec other) { throw null; }
        public void InflateConstraints(Mono.CSharp.TypeParameterInflator inflator, Mono.CSharp.TypeParameterSpec tps) { }
        public static Mono.CSharp.TypeParameterSpec[] InflateConstraints(Mono.CSharp.TypeParameterInflator inflator, Mono.CSharp.TypeParameterSpec[] tparams) { throw null; }
        public static Mono.CSharp.TypeParameterSpec[] InflateConstraints<T>(Mono.CSharp.TypeParameterSpec[] tparams, System.Func<T, Mono.CSharp.TypeParameterInflator> inflatorFactory, T arg) { throw null; }
        public override Mono.CSharp.MemberSpec InflateMember(Mono.CSharp.TypeParameterInflator inflator) { throw null; }
        protected override void InitializeMemberCache(bool onlyTypes) { }
        public bool IsConvertibleToInterface(Mono.CSharp.TypeSpec iface) { throw null; }
        public override Mono.CSharp.TypeSpec Mutate(Mono.CSharp.TypeParameterMutator mutator) { throw null; }
    }
    public partial class TypeSpec : Mono.CSharp.MemberSpec
    {
        protected Mono.CSharp.MemberCache cache;
        public static readonly Mono.CSharp.TypeSpec[] EmptyTypes;
        protected System.Collections.Generic.IList<Mono.CSharp.TypeSpec> ifaces;
        protected System.Type info;
        public TypeSpec(Mono.CSharp.MemberKind kind, Mono.CSharp.TypeSpec declaringType, Mono.CSharp.ITypeDefinition definition, System.Type info, Mono.CSharp.Modifiers modifiers) : base (default(Mono.CSharp.MemberKind), default(Mono.CSharp.TypeSpec), default(Mono.CSharp.IMemberDefinition), default(Mono.CSharp.Modifiers)) { }
        public override int Arity { get { throw null; } }
        public virtual Mono.CSharp.TypeSpec BaseType { get { throw null; } set { } }
        public virtual Mono.CSharp.BuiltinTypeSpec.Type BuiltinType { get { throw null; } }
        public bool HasDynamicElement { get { throw null; } }
        public bool HasNamedTupleElement { get { throw null; } }
        public virtual System.Collections.Generic.IList<Mono.CSharp.TypeSpec> Interfaces { get { throw null; } set { } }
        public bool IsArray { get { throw null; } }
        public virtual bool IsArrayGenericInterface { get { throw null; } set { } }
        public bool IsAttribute { get { throw null; } }
        public bool IsClass { get { throw null; } }
        public bool IsConstantCompatible { get { throw null; } }
        public bool IsDelegate { get { throw null; } }
        public bool IsEnum { get { throw null; } }
        public virtual bool IsExpressionTreeType { get { throw null; } set { } }
        public bool IsGenericOrParentIsGeneric { get { throw null; } }
        public bool IsGenericParameter { get { throw null; } }
        public virtual bool IsGenericTask { get { throw null; } set { } }
        public bool IsInterface { get { throw null; } }
        public bool IsNested { get { throw null; } }
        public virtual bool IsNullableType { get { throw null; } set { } }
        public bool IsPointer { get { throw null; } }
        public bool IsSealed { get { throw null; } }
        public bool IsSpecialRuntimeType { get { throw null; } set { } }
        public bool IsStruct { get { throw null; } }
        public bool IsStructOrEnum { get { throw null; } }
        public virtual bool IsTupleType { get { throw null; } set { } }
        public bool IsTypeBuilder { get { throw null; } }
        public bool IsUnmanaged { get { throw null; } }
        public Mono.CSharp.MemberCache MemberCache { get { throw null; } set { } }
        public Mono.CSharp.MemberCache MemberCacheTypes { get { throw null; } }
        public new Mono.CSharp.ITypeDefinition MemberDefinition { get { throw null; } }
        public virtual Mono.CSharp.TypeSpec[] TypeArguments { get { throw null; } }
        public virtual bool AddInterface(Mono.CSharp.TypeSpec iface) { throw null; }
        public bool AddInterfaceDefined(Mono.CSharp.TypeSpec iface) { throw null; }
        public static Mono.CSharp.TypeSpec[] GetAllTypeArguments(Mono.CSharp.TypeSpec type) { throw null; }
        public System.AttributeUsageAttribute GetAttributeUsage(Mono.CSharp.PredefinedAttribute pa) { throw null; }
        public virtual Mono.CSharp.TypeSpec GetDefinition() { throw null; }
        public virtual System.Type GetMetaInfo() { throw null; }
        public sealed override string GetSignatureForDocumentation() { throw null; }
        public virtual string GetSignatureForDocumentation(bool explicitName) { throw null; }
        public override string GetSignatureForError() { throw null; }
        public string GetSignatureForErrorIncludingAssemblyName() { throw null; }
        protected virtual string GetTypeNameSignature() { throw null; }
        public bool ImplementsInterface(Mono.CSharp.TypeSpec iface, bool variantly) { throw null; }
        public override Mono.CSharp.MemberSpec InflateMember(Mono.CSharp.TypeParameterInflator inflator) { throw null; }
        protected virtual void InitializeMemberCache(bool onlyTypes) { }
        public static bool IsBaseClass(Mono.CSharp.TypeSpec type, Mono.CSharp.TypeSpec baseClass, bool dynamicIsObject) { throw null; }
        public static bool IsNonNullableValueType(Mono.CSharp.TypeSpec t) { throw null; }
        public static bool IsReferenceType(Mono.CSharp.TypeSpec t) { throw null; }
        public static bool IsValueType(Mono.CSharp.TypeSpec t) { throw null; }
        public Mono.CSharp.InflatedTypeSpec MakeGenericType(Mono.CSharp.IModuleContext context, Mono.CSharp.TypeSpec[] targs) { throw null; }
        public virtual Mono.CSharp.TypeSpec Mutate(Mono.CSharp.TypeParameterMutator mutator) { throw null; }
        public override System.Collections.Generic.List<Mono.CSharp.MissingTypeSpecReference> ResolveMissingDependencies(Mono.CSharp.MemberSpec caller) { throw null; }
        public void SetExtensionMethodContainer() { }
        public void SetMetaInfo(System.Type info) { }
        public void UpdateInflatedInstancesBaseType() { }
    }
    public partial class UIntConstant : Mono.CSharp.IntegralConstant
    {
        public readonly uint Value;
        public UIntConstant(Mono.CSharp.BuiltinTypes types, uint v, Mono.CSharp.Location loc) : base (default(Mono.CSharp.TypeSpec), default(Mono.CSharp.Location)) { }
        public UIntConstant(Mono.CSharp.TypeSpec type, uint v, Mono.CSharp.Location loc) : base (default(Mono.CSharp.TypeSpec), default(Mono.CSharp.Location)) { }
        public override bool IsDefaultValue { get { throw null; } }
        public override bool IsNegative { get { throw null; } }
        public override bool IsOneInteger { get { throw null; } }
        public override bool IsZeroInteger { get { throw null; } }
        public override Mono.CSharp.Constant ConvertExplicitly(bool in_checked_context, Mono.CSharp.TypeSpec target_type) { throw null; }
        public override void Emit(Mono.CSharp.EmitContext ec) { }
        public override void EncodeAttributeValue(Mono.CSharp.IMemberContext rc, Mono.CSharp.AttributeEncoder enc, Mono.CSharp.TypeSpec targetType, Mono.CSharp.TypeSpec parameterType) { }
        public override object GetValue() { throw null; }
        public override long GetValueAsLong() { throw null; }
        public override Mono.CSharp.Constant Increment() { throw null; }
    }
    public partial class UIntLiteral : Mono.CSharp.UIntConstant, Mono.CSharp.ILiteralConstant
    {
        public UIntLiteral(Mono.CSharp.BuiltinTypes types, uint l, Mono.CSharp.Location loc) : base (default(Mono.CSharp.BuiltinTypes), default(uint), default(Mono.CSharp.Location)) { }
        public override bool IsLiteral { get { throw null; } }
        public override object Accept(Mono.CSharp.StructuralVisitor visitor) { throw null; }
    }
    public partial class ULongConstant : Mono.CSharp.IntegralConstant
    {
        public readonly ulong Value;
        public ULongConstant(Mono.CSharp.BuiltinTypes types, ulong v, Mono.CSharp.Location loc) : base (default(Mono.CSharp.TypeSpec), default(Mono.CSharp.Location)) { }
        public ULongConstant(Mono.CSharp.TypeSpec type, ulong v, Mono.CSharp.Location loc) : base (default(Mono.CSharp.TypeSpec), default(Mono.CSharp.Location)) { }
        public override bool IsDefaultValue { get { throw null; } }
        public override bool IsNegative { get { throw null; } }
        public override bool IsOneInteger { get { throw null; } }
        public override bool IsZeroInteger { get { throw null; } }
        public override Mono.CSharp.Constant ConvertExplicitly(bool in_checked_context, Mono.CSharp.TypeSpec target_type) { throw null; }
        public override void Emit(Mono.CSharp.EmitContext ec) { }
        public override void EncodeAttributeValue(Mono.CSharp.IMemberContext rc, Mono.CSharp.AttributeEncoder enc, Mono.CSharp.TypeSpec targetType, Mono.CSharp.TypeSpec parameterType) { }
        public override object GetValue() { throw null; }
        public override long GetValueAsLong() { throw null; }
        public override Mono.CSharp.Constant Increment() { throw null; }
    }
    public partial class ULongLiteral : Mono.CSharp.ULongConstant, Mono.CSharp.ILiteralConstant
    {
        public ULongLiteral(Mono.CSharp.BuiltinTypes types, ulong l, Mono.CSharp.Location loc) : base (default(Mono.CSharp.BuiltinTypes), default(ulong), default(Mono.CSharp.Location)) { }
        public override bool IsLiteral { get { throw null; } }
        public override object Accept(Mono.CSharp.StructuralVisitor visitor) { throw null; }
    }
    public partial class Unary : Mono.CSharp.Expression
    {
        public Mono.CSharp.Expression Expr;
        public readonly Mono.CSharp.Unary.Operator Oper;
        public Unary(Mono.CSharp.Unary.Operator op, Mono.CSharp.Expression expr, Mono.CSharp.Location loc) { }
        public override object Accept(Mono.CSharp.StructuralVisitor visitor) { throw null; }
        protected override void CloneTo(Mono.CSharp.CloneContext clonectx, Mono.CSharp.Expression t) { }
        public override bool ContainsEmitWithAwait() { throw null; }
        public override Mono.CSharp.Expression CreateExpressionTree(Mono.CSharp.ResolveContext ec) { throw null; }
        public static Mono.CSharp.TypeSpec[][] CreatePredefinedOperatorsTable(Mono.CSharp.BuiltinTypes types) { throw null; }
        protected override Mono.CSharp.Expression DoResolve(Mono.CSharp.ResolveContext ec) { throw null; }
        public override Mono.CSharp.Expression DoResolveLValue(Mono.CSharp.ResolveContext ec, Mono.CSharp.Expression right) { throw null; }
        public override void Emit(Mono.CSharp.EmitContext ec) { }
        public override void EmitBranchable(Mono.CSharp.EmitContext ec, System.Reflection.Emit.Label target, bool on_true) { }
        protected void EmitOperator(Mono.CSharp.EmitContext ec, Mono.CSharp.TypeSpec type) { }
        public override void EmitSideEffect(Mono.CSharp.EmitContext ec) { }
        public static void Error_Ambiguous(Mono.CSharp.ResolveContext rc, string oper, Mono.CSharp.TypeSpec type, Mono.CSharp.Location loc) { }
        public override void FlowAnalysis(Mono.CSharp.FlowAnalysisContext fc) { }
        public override void FlowAnalysisConditional(Mono.CSharp.FlowAnalysisContext fc) { }
        public override System.Linq.Expressions.Expression MakeExpression(Mono.CSharp.BuilderContext ctx) { throw null; }
        public static string OperName(Mono.CSharp.Unary.Operator oper) { throw null; }
        protected virtual Mono.CSharp.Expression ResolveEnumOperator(Mono.CSharp.ResolveContext ec, Mono.CSharp.Expression expr, Mono.CSharp.TypeSpec[] predefined) { throw null; }
        protected virtual Mono.CSharp.Expression ResolveOperator(Mono.CSharp.ResolveContext ec, Mono.CSharp.Expression expr) { throw null; }
        protected virtual Mono.CSharp.Expression ResolveUserOperator(Mono.CSharp.ResolveContext ec, Mono.CSharp.Expression expr) { throw null; }
        public enum Operator : byte
        {
            AddressOf = (byte)4,
            LogicalNot = (byte)2,
            OnesComplement = (byte)3,
            TOP = (byte)5,
            UnaryNegation = (byte)1,
            UnaryPlus = (byte)0,
        }
    }
    public partial class UnaryMutator : Mono.CSharp.ExpressionStatement
    {
        protected Mono.CSharp.Expression expr;
        public UnaryMutator(Mono.CSharp.UnaryMutator.Mode m, Mono.CSharp.Expression e, Mono.CSharp.Location loc) { }
        public Mono.CSharp.Expression Expr { get { throw null; } }
        public override Mono.CSharp.Location StartLocation { get { throw null; } }
        public Mono.CSharp.UnaryMutator.Mode UnaryMutatorMode { get { throw null; } }
        public override object Accept(Mono.CSharp.StructuralVisitor visitor) { throw null; }
        protected override void CloneTo(Mono.CSharp.CloneContext clonectx, Mono.CSharp.Expression t) { }
        public override bool ContainsEmitWithAwait() { throw null; }
        public override Mono.CSharp.Expression CreateExpressionTree(Mono.CSharp.ResolveContext ec) { throw null; }
        public static Mono.CSharp.TypeSpec[] CreatePredefinedOperatorsTable(Mono.CSharp.BuiltinTypes types) { throw null; }
        protected override Mono.CSharp.Expression DoResolve(Mono.CSharp.ResolveContext ec) { throw null; }
        protected Mono.CSharp.Expression DoResolveOperation(Mono.CSharp.ResolveContext ec) { throw null; }
        public override void Emit(Mono.CSharp.EmitContext ec) { }
        protected virtual void EmitOperation(Mono.CSharp.EmitContext ec) { }
        public override void EmitStatement(Mono.CSharp.EmitContext ec) { }
        public override void FlowAnalysis(Mono.CSharp.FlowAnalysisContext fc) { }
        public override System.Linq.Expressions.Expression MakeExpression(Mono.CSharp.BuilderContext ctx) { throw null; }
        public static string OperName(Mono.CSharp.UnaryMutator.Mode oper) { throw null; }
        [System.FlagsAttribute]
        public enum Mode : byte
        {
            IsDecrement = (byte)1,
            IsIncrement = (byte)0,
            IsPost = (byte)2,
            IsPre = (byte)0,
            PostDecrement = (byte)3,
            PostIncrement = (byte)2,
            PreDecrement = (byte)1,
            PreIncrement = (byte)0,
        }
    }
    public partial class UnboundTypeArguments : Mono.CSharp.TypeArguments
    {
        public UnboundTypeArguments(int arity, Mono.CSharp.Location loc) : base (default(Mono.CSharp.FullNamedExpression[])) { }
        public override bool IsEmpty { get { throw null; } }
        public override bool Resolve(Mono.CSharp.IMemberContext mc, bool allowUnbound) { throw null; }
    }
    public partial class UnboxCast : Mono.CSharp.TypeCast
    {
        public UnboxCast(Mono.CSharp.Expression expr, Mono.CSharp.TypeSpec return_type) : base (default(Mono.CSharp.Expression), default(Mono.CSharp.TypeSpec)) { }
        protected override Mono.CSharp.Expression DoResolve(Mono.CSharp.ResolveContext ec) { throw null; }
        public override void Emit(Mono.CSharp.EmitContext ec) { }
    }
    public partial class Unchecked : Mono.CSharp.Statement
    {
        public Mono.CSharp.Block Block;
        public Unchecked(Mono.CSharp.Block b, Mono.CSharp.Location loc) { }
        public override object Accept(Mono.CSharp.StructuralVisitor visitor) { throw null; }
        protected override void CloneTo(Mono.CSharp.CloneContext clonectx, Mono.CSharp.Statement t) { }
        protected override void DoEmit(Mono.CSharp.EmitContext ec) { }
        protected override bool DoFlowAnalysis(Mono.CSharp.FlowAnalysisContext fc) { throw null; }
        public override Mono.CSharp.Reachability MarkReachable(Mono.CSharp.Reachability rc) { throw null; }
        public override bool Resolve(Mono.CSharp.BlockContext ec) { throw null; }
    }
    public partial class UnCheckedExpr : Mono.CSharp.Expression
    {
        public Mono.CSharp.Expression Expr;
        public UnCheckedExpr(Mono.CSharp.Expression e, Mono.CSharp.Location l) { }
        public override object Accept(Mono.CSharp.StructuralVisitor visitor) { throw null; }
        protected override void CloneTo(Mono.CSharp.CloneContext clonectx, Mono.CSharp.Expression t) { }
        public override bool ContainsEmitWithAwait() { throw null; }
        public override Mono.CSharp.Expression CreateExpressionTree(Mono.CSharp.ResolveContext ec) { throw null; }
        protected override Mono.CSharp.Expression DoResolve(Mono.CSharp.ResolveContext ec) { throw null; }
        public override void Emit(Mono.CSharp.EmitContext ec) { }
        public override void EmitBranchable(Mono.CSharp.EmitContext ec, System.Reflection.Emit.Label target, bool on_true) { }
        public override void FlowAnalysis(Mono.CSharp.FlowAnalysisContext fc) { }
    }
    public partial class Undo
    {
        public Undo() { }
        public void AddTypeContainer(Mono.CSharp.TypeContainer current_container, Mono.CSharp.TypeDefinition tc) { }
        public void ExecuteUndo() { }
    }
    public partial class UnixUtils
    {
        public UnixUtils() { }
        public static bool isatty(int fd) { throw null; }
    }
    public partial class UnreachableExpression : Mono.CSharp.Expression
    {
        public UnreachableExpression(Mono.CSharp.Expression expr) { }
        public override Mono.CSharp.Expression CreateExpressionTree(Mono.CSharp.ResolveContext ec) { throw null; }
        protected override Mono.CSharp.Expression DoResolve(Mono.CSharp.ResolveContext rc) { throw null; }
        public override void Emit(Mono.CSharp.EmitContext ec) { }
        public override void EmitBranchable(Mono.CSharp.EmitContext ec, System.Reflection.Emit.Label target, bool on_true) { }
        public override void FlowAnalysis(Mono.CSharp.FlowAnalysisContext fc) { }
    }
    public partial class Unsafe : Mono.CSharp.Statement
    {
        public Mono.CSharp.Block Block;
        public Unsafe(Mono.CSharp.Block b, Mono.CSharp.Location loc) { }
        public override object Accept(Mono.CSharp.StructuralVisitor visitor) { throw null; }
        protected override void CloneTo(Mono.CSharp.CloneContext clonectx, Mono.CSharp.Statement t) { }
        protected override void DoEmit(Mono.CSharp.EmitContext ec) { }
        protected override bool DoFlowAnalysis(Mono.CSharp.FlowAnalysisContext fc) { throw null; }
        public override Mono.CSharp.Reachability MarkReachable(Mono.CSharp.Reachability rc) { throw null; }
        public override bool Resolve(Mono.CSharp.BlockContext ec) { throw null; }
    }
    public partial class UserCast : Mono.CSharp.Expression
    {
        public UserCast(Mono.CSharp.MethodSpec method, Mono.CSharp.Expression source, Mono.CSharp.Location l) { }
        public Mono.CSharp.Expression Source { get { throw null; } set { } }
        public override bool ContainsEmitWithAwait() { throw null; }
        public override Mono.CSharp.Expression CreateExpressionTree(Mono.CSharp.ResolveContext ec) { throw null; }
        protected override Mono.CSharp.Expression DoResolve(Mono.CSharp.ResolveContext ec) { throw null; }
        public override void Emit(Mono.CSharp.EmitContext ec) { }
        public override void FlowAnalysis(Mono.CSharp.FlowAnalysisContext fc) { }
        public override string GetSignatureForError() { throw null; }
        public override System.Linq.Expressions.Expression MakeExpression(Mono.CSharp.BuilderContext ctx) { throw null; }
    }
    public partial class UserOperatorCall : Mono.CSharp.Expression
    {
        protected readonly Mono.CSharp.Arguments arguments;
        protected readonly Mono.CSharp.MethodSpec oper;
        public UserOperatorCall(Mono.CSharp.MethodSpec oper, Mono.CSharp.Arguments args, System.Func<Mono.CSharp.ResolveContext, Mono.CSharp.Expression, Mono.CSharp.Expression> expr_tree, Mono.CSharp.Location loc) { }
        protected override void CloneTo(Mono.CSharp.CloneContext context, Mono.CSharp.Expression target) { }
        public override bool ContainsEmitWithAwait() { throw null; }
        public override Mono.CSharp.Expression CreateExpressionTree(Mono.CSharp.ResolveContext ec) { throw null; }
        protected override Mono.CSharp.Expression DoResolve(Mono.CSharp.ResolveContext ec) { throw null; }
        public override void Emit(Mono.CSharp.EmitContext ec) { }
        public override void FlowAnalysis(Mono.CSharp.FlowAnalysisContext fc) { }
        public override System.Linq.Expressions.Expression MakeExpression(Mono.CSharp.BuilderContext ctx) { throw null; }
    }
    public partial class UShortConstant : Mono.CSharp.IntegralConstant
    {
        public readonly ushort Value;
        public UShortConstant(Mono.CSharp.BuiltinTypes types, ushort v, Mono.CSharp.Location loc) : base (default(Mono.CSharp.TypeSpec), default(Mono.CSharp.Location)) { }
        public UShortConstant(Mono.CSharp.TypeSpec type, ushort v, Mono.CSharp.Location loc) : base (default(Mono.CSharp.TypeSpec), default(Mono.CSharp.Location)) { }
        public override bool IsDefaultValue { get { throw null; } }
        public override bool IsNegative { get { throw null; } }
        public override bool IsOneInteger { get { throw null; } }
        public override bool IsZeroInteger { get { throw null; } }
        public override Mono.CSharp.Constant ConvertExplicitly(bool in_checked_context, Mono.CSharp.TypeSpec target_type) { throw null; }
        public override void Emit(Mono.CSharp.EmitContext ec) { }
        public override void EncodeAttributeValue(Mono.CSharp.IMemberContext rc, Mono.CSharp.AttributeEncoder enc, Mono.CSharp.TypeSpec targetType, Mono.CSharp.TypeSpec parameterType) { }
        public override object GetValue() { throw null; }
        public override long GetValueAsLong() { throw null; }
        public override Mono.CSharp.Constant Increment() { throw null; }
    }
    public partial class Using : Mono.CSharp.TryFinallyBlock
    {
        public Using(Mono.CSharp.Expression expr, Mono.CSharp.Statement stmt, Mono.CSharp.Location loc) : base (default(Mono.CSharp.Statement), default(Mono.CSharp.Location)) { }
        public Using(Mono.CSharp.Using.VariableDeclaration decl, Mono.CSharp.Statement stmt, Mono.CSharp.Location loc) : base (default(Mono.CSharp.Statement), default(Mono.CSharp.Location)) { }
        public Mono.CSharp.Expression Expr { get { throw null; } }
        public Mono.CSharp.BlockVariable Variables { get { throw null; } }
        public override object Accept(Mono.CSharp.StructuralVisitor visitor) { throw null; }
        protected override void CloneTo(Mono.CSharp.CloneContext clonectx, Mono.CSharp.Statement t) { }
        protected override bool DoFlowAnalysis(Mono.CSharp.FlowAnalysisContext fc) { throw null; }
        public override void Emit(Mono.CSharp.EmitContext ec) { }
        public override void EmitFinallyBody(Mono.CSharp.EmitContext ec) { }
        protected override void EmitTryBody(Mono.CSharp.EmitContext ec) { }
        protected override void EmitTryBodyPrepare(Mono.CSharp.EmitContext ec) { }
        public override Mono.CSharp.Reachability MarkReachable(Mono.CSharp.Reachability rc) { throw null; }
        public override bool Resolve(Mono.CSharp.BlockContext ec) { throw null; }
        public partial class VariableDeclaration : Mono.CSharp.BlockVariable
        {
            public VariableDeclaration(Mono.CSharp.Expression expr) : base (default(Mono.CSharp.FullNamedExpression), default(Mono.CSharp.LocalVariable)) { }
            public VariableDeclaration(Mono.CSharp.FullNamedExpression type, Mono.CSharp.LocalVariable li) : base (default(Mono.CSharp.FullNamedExpression), default(Mono.CSharp.LocalVariable)) { }
            public VariableDeclaration(Mono.CSharp.LocalVariable li, Mono.CSharp.Location loc) : base (default(Mono.CSharp.FullNamedExpression), default(Mono.CSharp.LocalVariable)) { }
            public bool IsNested { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
            public override object Accept(Mono.CSharp.StructuralVisitor visitor) { throw null; }
            protected virtual void CheckIDiposableConversion(Mono.CSharp.BlockContext bc, Mono.CSharp.LocalVariable li, Mono.CSharp.Expression initializer) { }
            protected virtual Mono.CSharp.Statement CreateDisposeCall(Mono.CSharp.BlockContext bc, Mono.CSharp.LocalVariable lv) { throw null; }
            public void EmitDispose(Mono.CSharp.EmitContext ec) { }
            public override bool Resolve(Mono.CSharp.BlockContext bc) { throw null; }
            public void ResolveDeclaratorInitializer(Mono.CSharp.BlockContext bc) { }
            public Mono.CSharp.Expression ResolveExpression(Mono.CSharp.BlockContext bc) { throw null; }
            protected override Mono.CSharp.Expression ResolveInitializer(Mono.CSharp.BlockContext bc, Mono.CSharp.LocalVariable li, Mono.CSharp.Expression initializer) { throw null; }
            public Mono.CSharp.Statement RewriteUsingDeclarators(Mono.CSharp.BlockContext bc, Mono.CSharp.Statement stmt) { throw null; }
        }
    }
    public partial class UsingAliasNamespace : Mono.CSharp.UsingNamespace
    {
        public UsingAliasNamespace(Mono.CSharp.SimpleMemberName alias, Mono.CSharp.ATypeNameExpression expr, Mono.CSharp.Location loc) : base (default(Mono.CSharp.ATypeNameExpression), default(Mono.CSharp.Location)) { }
        public override Mono.CSharp.SimpleMemberName Alias { get { throw null; } }
        public override void Define(Mono.CSharp.NamespaceContainer ctx) { }
        [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
        public partial struct AliasContext : Mono.CSharp.IMemberContext, Mono.CSharp.IModuleContext
        {
            public AliasContext(Mono.CSharp.NamespaceContainer ns) { throw null;}
            public Mono.CSharp.MemberCore CurrentMemberDefinition { get { throw null; } }
            public Mono.CSharp.TypeSpec CurrentType { get { throw null; } }
            public Mono.CSharp.TypeParameters CurrentTypeParameters { get { throw null; } }
            public bool IsObsolete { get { throw null; } }
            public bool IsStatic { get { throw null; } }
            public bool IsUnsafe { get { throw null; } }
            public Mono.CSharp.ModuleContainer Module { get { throw null; } }
            public string GetSignatureForError() { throw null; }
            public Mono.CSharp.ExtensionMethodCandidates LookupExtensionMethod(string name, int arity) { throw null; }
            public Mono.CSharp.FullNamedExpression LookupNamespaceAlias(string name) { throw null; }
            public Mono.CSharp.FullNamedExpression LookupNamespaceOrType(string name, int arity, Mono.CSharp.LookupMode mode, Mono.CSharp.Location loc) { throw null; }
        }
    }
    public partial class UsingClause
    {
        protected Mono.CSharp.FullNamedExpression resolved;
        public UsingClause(Mono.CSharp.ATypeNameExpression expr, Mono.CSharp.Location loc) { }
        public virtual Mono.CSharp.SimpleMemberName Alias { get { throw null; } }
        public Mono.CSharp.Location Location { get { throw null; } }
        public Mono.CSharp.ATypeNameExpression NamespaceExpression { get { throw null; } }
        public Mono.CSharp.FullNamedExpression ResolvedExpression { get { throw null; } }
        public virtual void Define(Mono.CSharp.NamespaceContainer ctx) { }
        public string GetSignatureForError() { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class UsingExternAlias : Mono.CSharp.UsingAliasNamespace
    {
        public UsingExternAlias(Mono.CSharp.SimpleMemberName alias, Mono.CSharp.Location loc) : base (default(Mono.CSharp.SimpleMemberName), default(Mono.CSharp.ATypeNameExpression), default(Mono.CSharp.Location)) { }
        public override void Define(Mono.CSharp.NamespaceContainer ctx) { }
    }
    public partial class UsingNamespace : Mono.CSharp.UsingClause
    {
        public UsingNamespace(Mono.CSharp.ATypeNameExpression expr, Mono.CSharp.Location loc) : base (default(Mono.CSharp.ATypeNameExpression), default(Mono.CSharp.Location)) { }
        public override void Define(Mono.CSharp.NamespaceContainer ctx) { }
    }
    public partial class UsingType : Mono.CSharp.UsingClause
    {
        public UsingType(Mono.CSharp.ATypeNameExpression expr, Mono.CSharp.Location loc) : base (default(Mono.CSharp.ATypeNameExpression), default(Mono.CSharp.Location)) { }
        public override void Define(Mono.CSharp.NamespaceContainer ctx) { }
    }
    public delegate void ValueModificationHandler(string variableName, int row, int column, object value);
    public partial class VariableInfo
    {
        internal VariableInfo() { }
        public bool IsParameter;
        public bool IsEverAssigned { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public static Mono.CSharp.VariableInfo Create(Mono.CSharp.BlockContext bc, Mono.CSharp.LocalVariable variable) { throw null; }
        public static Mono.CSharp.VariableInfo Create(Mono.CSharp.BlockContext bc, Mono.CSharp.Parameter parameter) { throw null; }
        public Mono.CSharp.VariableInfo GetStructFieldInfo(string fieldName) { throw null; }
        public bool IsAssigned(Mono.CSharp.DefiniteAssignmentBitSet vector) { throw null; }
        public bool IsFullyInitialized(Mono.CSharp.FlowAnalysisContext fc, Mono.CSharp.Location loc) { throw null; }
        public bool IsStructFieldAssigned(Mono.CSharp.DefiniteAssignmentBitSet vector, string field_name) { throw null; }
        public void SetAssigned(Mono.CSharp.DefiniteAssignmentBitSet vector, bool generatedAssignment) { }
        public void SetStructFieldAssigned(Mono.CSharp.DefiniteAssignmentBitSet vector, string field_name) { }
        public override string ToString() { throw null; }
    }
    public abstract partial class VariableReference : Mono.CSharp.Expression, Mono.CSharp.IAssignMethod, Mono.CSharp.IFixedExpression, Mono.CSharp.IMemoryLocation, Mono.CSharp.IVariableReference
    {
        protected VariableReference() { }
        public abstract bool IsFixed { get; }
        public bool IsHoisted { get { throw null; } }
        public abstract bool IsLockedByStatement { get; set; }
        public abstract bool IsRef { get; }
        public abstract string Name { get; }
        protected abstract Mono.CSharp.ILocalVariable Variable { get; }
        public abstract Mono.CSharp.VariableInfo VariableInfo { get; }
        public virtual void AddressOf(Mono.CSharp.EmitContext ec, Mono.CSharp.AddressOp mode) { }
        public override bool ContainsEmitWithAwait() { throw null; }
        public override Mono.CSharp.Expression CreateExpressionTree(Mono.CSharp.ResolveContext ec) { throw null; }
        public override Mono.CSharp.Expression DoResolveLValue(Mono.CSharp.ResolveContext rc, Mono.CSharp.Expression right_side) { throw null; }
        public override void Emit(Mono.CSharp.EmitContext ec) { }
        public void Emit(Mono.CSharp.EmitContext ec, bool leave_copy) { }
        public void EmitAssign(Mono.CSharp.EmitContext ec, Mono.CSharp.Expression source, bool leave_copy, bool prepare_for_load) { }
        public void EmitLoad(Mono.CSharp.EmitContext ec) { }
        public override void EmitSideEffect(Mono.CSharp.EmitContext ec) { }
        public override Mono.CSharp.Expression EmitToField(Mono.CSharp.EmitContext ec) { throw null; }
        public abstract Mono.CSharp.HoistedVariable GetHoistedVariable(Mono.CSharp.AnonymousExpression ae);
        public Mono.CSharp.HoistedVariable GetHoistedVariable(Mono.CSharp.EmitContext ec) { throw null; }
        public Mono.CSharp.HoistedVariable GetHoistedVariable(Mono.CSharp.ResolveContext rc) { throw null; }
        public override string GetSignatureForError() { throw null; }
        public abstract void SetHasAddressTaken();
    }
    public enum Variance
    {
        Contravariant = -1,
        Covariant = 1,
        None = 0,
    }
    public partial class VarianceDecl
    {
        public VarianceDecl(Mono.CSharp.Variance variance, Mono.CSharp.Location loc) { }
        public Mono.CSharp.Location Location { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        public Mono.CSharp.Variance Variance { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        public static Mono.CSharp.Variance CheckTypeVariance(Mono.CSharp.TypeSpec t, Mono.CSharp.Variance expected, Mono.CSharp.IMemberContext member) { throw null; }
    }
    public partial class WarningRegions
    {
        public WarningRegions() { }
        public bool IsWarningEnabled(int code, int src_line) { throw null; }
        public void WarningDisable(Mono.CSharp.Location location, int code, Mono.CSharp.Report Report) { }
        public void WarningDisable(int line) { }
        public void WarningEnable(Mono.CSharp.Location location, int code, Mono.CSharp.CompilerContext context) { }
        public void WarningEnable(int line) { }
    }
    public partial class While : Mono.CSharp.LoopStatement
    {
        public Mono.CSharp.Expression expr;
        public While(Mono.CSharp.BooleanExpression bool_expr, Mono.CSharp.Statement statement, Mono.CSharp.Location l) : base (default(Mono.CSharp.Statement)) { }
        public override object Accept(Mono.CSharp.StructuralVisitor visitor) { throw null; }
        public override void AddEndDefiniteAssignment(Mono.CSharp.FlowAnalysisContext fc) { }
        protected override void CloneTo(Mono.CSharp.CloneContext clonectx, Mono.CSharp.Statement t) { }
        protected override void DoEmit(Mono.CSharp.EmitContext ec) { }
        protected override bool DoFlowAnalysis(Mono.CSharp.FlowAnalysisContext fc) { throw null; }
        public override Mono.CSharp.Reachability MarkReachable(Mono.CSharp.Reachability rc) { throw null; }
        public override bool Resolve(Mono.CSharp.BlockContext bc) { throw null; }
        public override void SetEndReachable() { }
    }
    public enum XmlCommentState
    {
        Allowed = 0,
        Error = 2,
        NotAllowed = 1,
    }
    public partial class Yield : Mono.CSharp.YieldStatement<Mono.CSharp.Iterator>
    {
        public Yield(Mono.CSharp.Expression expr, Mono.CSharp.Location loc) : base (default(Mono.CSharp.Expression), default(Mono.CSharp.Location)) { }
        public override object Accept(Mono.CSharp.StructuralVisitor visitor) { throw null; }
        public static bool CheckContext(Mono.CSharp.BlockContext bc, Mono.CSharp.Location loc) { throw null; }
        public override bool Resolve(Mono.CSharp.BlockContext bc) { throw null; }
    }
    public partial class YieldBreak : Mono.CSharp.ExitStatement
    {
        public YieldBreak(Mono.CSharp.Location l) { }
        protected override bool IsLocalExit { get { throw null; } }
        public override object Accept(Mono.CSharp.StructuralVisitor visitor) { throw null; }
        protected override void CloneTo(Mono.CSharp.CloneContext clonectx, Mono.CSharp.Statement target) { }
        protected override void DoEmit(Mono.CSharp.EmitContext ec) { }
        protected override bool DoFlowAnalysis(Mono.CSharp.FlowAnalysisContext fc) { throw null; }
        protected override bool DoResolve(Mono.CSharp.BlockContext bc) { throw null; }
        public override Mono.CSharp.Reachability MarkReachable(Mono.CSharp.Reachability rc) { throw null; }
    }
    public abstract partial class YieldStatement<T> : Mono.CSharp.ResumableStatement where T : Mono.CSharp.StateMachineInitializer
    {
        protected Mono.CSharp.Expression expr;
        protected T machine_initializer;
        protected bool unwind_protect;
        protected YieldStatement(Mono.CSharp.Expression expr, Mono.CSharp.Location l) { }
        public Mono.CSharp.Expression Expr { get { throw null; } }
        protected override void CloneTo(Mono.CSharp.CloneContext clonectx, Mono.CSharp.Statement t) { }
        protected override void DoEmit(Mono.CSharp.EmitContext ec) { }
        protected override bool DoFlowAnalysis(Mono.CSharp.FlowAnalysisContext fc) { throw null; }
        public void RegisterResumePoint() { }
        public override bool Resolve(Mono.CSharp.BlockContext bc) { throw null; }
    }
}
namespace Mono.CSharp.Linq
{
    public abstract partial class AQueryClause : Mono.CSharp.ShimExpression
    {
        public Mono.CSharp.Linq.QueryBlock block;
        public Mono.CSharp.Linq.AQueryClause next;
        protected AQueryClause(Mono.CSharp.Linq.QueryBlock block, Mono.CSharp.Expression expr, Mono.CSharp.Location loc) : base (default(Mono.CSharp.Expression)) { }
        protected abstract string MethodName { get; }
        public Mono.CSharp.Linq.AQueryClause Next { set { } }
        public Mono.CSharp.Linq.AQueryClause Tail { get { throw null; } }
        public virtual Mono.CSharp.Expression BuildQueryClause(Mono.CSharp.ResolveContext ec, Mono.CSharp.Expression lSide, Mono.CSharp.Parameter parameter) { throw null; }
        protected override void CloneTo(Mono.CSharp.CloneContext clonectx, Mono.CSharp.Expression target) { }
        protected virtual void CreateArguments(Mono.CSharp.ResolveContext ec, Mono.CSharp.Parameter parameter, ref Mono.CSharp.Arguments args) { }
        protected virtual Mono.CSharp.Parameter CreateChildrenParameters(Mono.CSharp.Parameter parameter) { throw null; }
        protected Mono.CSharp.Invocation CreateQueryExpression(Mono.CSharp.Expression lSide, Mono.CSharp.Arguments arguments) { throw null; }
        protected override Mono.CSharp.Expression DoResolve(Mono.CSharp.ResolveContext ec) { throw null; }
        protected partial class QueryExpressionAccess : Mono.CSharp.MemberAccess
        {
            public QueryExpressionAccess(Mono.CSharp.Expression expr, string methodName, Mono.CSharp.Location loc) : base (default(Mono.CSharp.Expression), default(string)) { }
            public QueryExpressionAccess(Mono.CSharp.Expression expr, string methodName, Mono.CSharp.TypeArguments typeArguments, Mono.CSharp.Location loc) : base (default(Mono.CSharp.Expression), default(string)) { }
            public override void Error_TypeDoesNotContainDefinition(Mono.CSharp.ResolveContext ec, Mono.CSharp.TypeSpec type, string name) { }
        }
        protected partial class QueryExpressionInvocation : Mono.CSharp.Invocation, Mono.CSharp.OverloadResolver.IErrorHandler
        {
            public QueryExpressionInvocation(Mono.CSharp.Linq.AQueryClause.QueryExpressionAccess expr, Mono.CSharp.Arguments arguments) : base (default(Mono.CSharp.Expression), default(Mono.CSharp.Arguments)) { }
            protected override Mono.CSharp.Expression DoResolveDynamic(Mono.CSharp.ResolveContext ec, Mono.CSharp.Expression memberExpr) { throw null; }
            protected override Mono.CSharp.MethodGroupExpr DoResolveOverload(Mono.CSharp.ResolveContext rc) { throw null; }
            bool Mono.CSharp.OverloadResolver.IErrorHandler.AmbiguousCandidates(Mono.CSharp.ResolveContext ec, Mono.CSharp.MemberSpec best, Mono.CSharp.MemberSpec ambiguous) { throw null; }
            bool Mono.CSharp.OverloadResolver.IErrorHandler.ArgumentMismatch(Mono.CSharp.ResolveContext rc, Mono.CSharp.MemberSpec best, Mono.CSharp.Argument arg, int index) { throw null; }
            bool Mono.CSharp.OverloadResolver.IErrorHandler.NoArgumentMatch(Mono.CSharp.ResolveContext rc, Mono.CSharp.MemberSpec best) { throw null; }
            bool Mono.CSharp.OverloadResolver.IErrorHandler.TypeInferenceFailed(Mono.CSharp.ResolveContext rc, Mono.CSharp.MemberSpec best) { throw null; }
        }
    }
    public abstract partial class ARangeVariableQueryClause : Mono.CSharp.Linq.AQueryClause
    {
        protected Mono.CSharp.Linq.RangeVariable identifier;
        protected ARangeVariableQueryClause(Mono.CSharp.Linq.QueryBlock block, Mono.CSharp.Linq.RangeVariable identifier, Mono.CSharp.Expression expr, Mono.CSharp.Location loc) : base (default(Mono.CSharp.Linq.QueryBlock), default(Mono.CSharp.Expression), default(Mono.CSharp.Location)) { }
        public Mono.CSharp.Linq.RangeVariable Identifier { get { throw null; } }
        public Mono.CSharp.FullNamedExpression IdentifierType { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        protected Mono.CSharp.Invocation CreateCastExpression(Mono.CSharp.Expression lSide) { throw null; }
        protected override Mono.CSharp.Parameter CreateChildrenParameters(Mono.CSharp.Parameter parameter) { throw null; }
        protected static Mono.CSharp.Expression CreateRangeVariableType(Mono.CSharp.ResolveContext rc, Mono.CSharp.Parameter parameter, Mono.CSharp.Linq.RangeVariable name, Mono.CSharp.Expression init) { throw null; }
        protected virtual Mono.CSharp.Linq.RangeVariable GetIntoVariable() { throw null; }
    }
    public partial class GroupBy : Mono.CSharp.Linq.AQueryClause
    {
        public GroupBy(Mono.CSharp.Linq.QueryBlock block, Mono.CSharp.Expression elementSelector, Mono.CSharp.Linq.QueryBlock elementBlock, Mono.CSharp.Expression keySelector, Mono.CSharp.Location loc) : base (default(Mono.CSharp.Linq.QueryBlock), default(Mono.CSharp.Expression), default(Mono.CSharp.Location)) { }
        protected override string MethodName { get { throw null; } }
        public Mono.CSharp.Expression SelectorExpression { get { throw null; } }
        public override object Accept(Mono.CSharp.StructuralVisitor visitor) { throw null; }
        protected override void CloneTo(Mono.CSharp.CloneContext clonectx, Mono.CSharp.Expression target) { }
        protected override void CreateArguments(Mono.CSharp.ResolveContext ec, Mono.CSharp.Parameter parameter, ref Mono.CSharp.Arguments args) { }
    }
    public partial class GroupJoin : Mono.CSharp.Linq.Join
    {
        public GroupJoin(Mono.CSharp.Linq.QueryBlock block, Mono.CSharp.Linq.RangeVariable lt, Mono.CSharp.Expression inner, Mono.CSharp.Linq.QueryBlock outerSelector, Mono.CSharp.Linq.QueryBlock innerSelector, Mono.CSharp.Linq.RangeVariable into, Mono.CSharp.Location loc) : base (default(Mono.CSharp.Linq.QueryBlock), default(Mono.CSharp.Linq.RangeVariable), default(Mono.CSharp.Expression), default(Mono.CSharp.Linq.QueryBlock), default(Mono.CSharp.Linq.QueryBlock), default(Mono.CSharp.Location)) { }
        protected override string MethodName { get { throw null; } }
        public override object Accept(Mono.CSharp.StructuralVisitor visitor) { throw null; }
        protected override Mono.CSharp.Linq.RangeVariable GetIntoVariable() { throw null; }
    }
    public partial class Join : Mono.CSharp.Linq.SelectMany
    {
        public Join(Mono.CSharp.Linq.QueryBlock block, Mono.CSharp.Linq.RangeVariable lt, Mono.CSharp.Expression inner, Mono.CSharp.Linq.QueryBlock outerSelector, Mono.CSharp.Linq.QueryBlock innerSelector, Mono.CSharp.Location loc) : base (default(Mono.CSharp.Linq.QueryBlock), default(Mono.CSharp.Linq.RangeVariable), default(Mono.CSharp.Expression), default(Mono.CSharp.Location)) { }
        public Mono.CSharp.Linq.QueryBlock InnerSelector { get { throw null; } }
        protected override string MethodName { get { throw null; } }
        public Mono.CSharp.Linq.QueryBlock OuterSelector { get { throw null; } }
        public override object Accept(Mono.CSharp.StructuralVisitor visitor) { throw null; }
        protected override void CloneTo(Mono.CSharp.CloneContext clonectx, Mono.CSharp.Expression target) { }
        protected override void CreateArguments(Mono.CSharp.ResolveContext ec, Mono.CSharp.Parameter parameter, ref Mono.CSharp.Arguments args) { }
    }
    public partial class Let : Mono.CSharp.Linq.ARangeVariableQueryClause
    {
        public Let(Mono.CSharp.Linq.QueryBlock block, Mono.CSharp.Linq.RangeVariable identifier, Mono.CSharp.Expression expr, Mono.CSharp.Location loc) : base (default(Mono.CSharp.Linq.QueryBlock), default(Mono.CSharp.Linq.RangeVariable), default(Mono.CSharp.Expression), default(Mono.CSharp.Location)) { }
        protected override string MethodName { get { throw null; } }
        public override object Accept(Mono.CSharp.StructuralVisitor visitor) { throw null; }
        protected override void CreateArguments(Mono.CSharp.ResolveContext ec, Mono.CSharp.Parameter parameter, ref Mono.CSharp.Arguments args) { }
    }
    public partial class OrderByAscending : Mono.CSharp.Linq.AQueryClause
    {
        public OrderByAscending(Mono.CSharp.Linq.QueryBlock block, Mono.CSharp.Expression expr) : base (default(Mono.CSharp.Linq.QueryBlock), default(Mono.CSharp.Expression), default(Mono.CSharp.Location)) { }
        protected override string MethodName { get { throw null; } }
        public override object Accept(Mono.CSharp.StructuralVisitor visitor) { throw null; }
    }
    public partial class OrderByDescending : Mono.CSharp.Linq.AQueryClause
    {
        public OrderByDescending(Mono.CSharp.Linq.QueryBlock block, Mono.CSharp.Expression expr) : base (default(Mono.CSharp.Linq.QueryBlock), default(Mono.CSharp.Expression), default(Mono.CSharp.Location)) { }
        protected override string MethodName { get { throw null; } }
        public override object Accept(Mono.CSharp.StructuralVisitor visitor) { throw null; }
    }
    public partial class QueryBlock : Mono.CSharp.ParametersBlock
    {
        public QueryBlock(Mono.CSharp.Block parent, Mono.CSharp.Location start) : base (default(Mono.CSharp.Block), default(Mono.CSharp.ParametersCompiled), default(Mono.CSharp.Location), default(Mono.CSharp.Block.Flags)) { }
        public void AddRangeVariable(Mono.CSharp.Linq.RangeVariable variable) { }
        public override void Error_AlreadyDeclared(string name, Mono.CSharp.INamedBlockVariable variable) { }
        public override void Error_AlreadyDeclared(string name, Mono.CSharp.INamedBlockVariable variable, string reason) { }
        public override void Error_AlreadyDeclaredTypeParameter(string name, Mono.CSharp.Location loc) { }
        public void SetParameter(Mono.CSharp.Parameter parameter) { }
        public void SetParameters(Mono.CSharp.Parameter first, Mono.CSharp.Parameter second) { }
        public sealed partial class TransparentParameter : Mono.CSharp.ImplicitLambdaParameter
        {
            public static int Counter;
            public readonly string Identifier;
            public readonly Mono.CSharp.Parameter Parent;
            public TransparentParameter(Mono.CSharp.Parameter parent, Mono.CSharp.Linq.RangeVariable identifier) : base (default(string), default(Mono.CSharp.Location)) { }
            public static void Reset() { }
        }
    }
    public partial class QueryExpression : Mono.CSharp.Linq.AQueryClause
    {
        public QueryExpression(Mono.CSharp.Linq.AQueryClause start) : base (default(Mono.CSharp.Linq.QueryBlock), default(Mono.CSharp.Expression), default(Mono.CSharp.Location)) { }
        protected override string MethodName { get { throw null; } }
        public override Mono.CSharp.Expression BuildQueryClause(Mono.CSharp.ResolveContext ec, Mono.CSharp.Expression lSide, Mono.CSharp.Parameter parentParameter) { throw null; }
        protected override Mono.CSharp.Expression DoResolve(Mono.CSharp.ResolveContext ec) { throw null; }
    }
    public partial class QueryStartClause : Mono.CSharp.Linq.ARangeVariableQueryClause
    {
        public QueryStartClause(Mono.CSharp.Linq.QueryBlock block, Mono.CSharp.Expression expr, Mono.CSharp.Linq.RangeVariable identifier, Mono.CSharp.Location loc) : base (default(Mono.CSharp.Linq.QueryBlock), default(Mono.CSharp.Linq.RangeVariable), default(Mono.CSharp.Expression), default(Mono.CSharp.Location)) { }
        protected override string MethodName { get { throw null; } }
        public override Mono.CSharp.Expression BuildQueryClause(Mono.CSharp.ResolveContext ec, Mono.CSharp.Expression lSide, Mono.CSharp.Parameter parameter) { throw null; }
        protected override Mono.CSharp.Expression DoResolve(Mono.CSharp.ResolveContext ec) { throw null; }
    }
    public sealed partial class RangeVariable : Mono.CSharp.INamedBlockVariable
    {
        public RangeVariable(string name, Mono.CSharp.Location loc) { }
        public Mono.CSharp.Block Block { get { throw null; } set { } }
        public bool IsDeclared { get { throw null; } }
        public bool IsParameter { get { throw null; } }
        public Mono.CSharp.Location Location { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        public string Name { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        public Mono.CSharp.Expression CreateReferenceExpression(Mono.CSharp.ResolveContext rc, Mono.CSharp.Location loc) { throw null; }
    }
    public partial class Select : Mono.CSharp.Linq.AQueryClause
    {
        public Select(Mono.CSharp.Linq.QueryBlock block, Mono.CSharp.Expression expr, Mono.CSharp.Location loc) : base (default(Mono.CSharp.Linq.QueryBlock), default(Mono.CSharp.Expression), default(Mono.CSharp.Location)) { }
        protected override string MethodName { get { throw null; } }
        public override object Accept(Mono.CSharp.StructuralVisitor visitor) { throw null; }
        public bool IsRequired(Mono.CSharp.Parameter parameter) { throw null; }
    }
    public partial class SelectMany : Mono.CSharp.Linq.ARangeVariableQueryClause
    {
        public SelectMany(Mono.CSharp.Linq.QueryBlock block, Mono.CSharp.Linq.RangeVariable identifier, Mono.CSharp.Expression expr, Mono.CSharp.Location loc) : base (default(Mono.CSharp.Linq.QueryBlock), default(Mono.CSharp.Linq.RangeVariable), default(Mono.CSharp.Expression), default(Mono.CSharp.Location)) { }
        protected override string MethodName { get { throw null; } }
        public override object Accept(Mono.CSharp.StructuralVisitor visitor) { throw null; }
        protected override void CreateArguments(Mono.CSharp.ResolveContext ec, Mono.CSharp.Parameter parameter, ref Mono.CSharp.Arguments args) { }
    }
    public partial class ThenByAscending : Mono.CSharp.Linq.OrderByAscending
    {
        public ThenByAscending(Mono.CSharp.Linq.QueryBlock block, Mono.CSharp.Expression expr) : base (default(Mono.CSharp.Linq.QueryBlock), default(Mono.CSharp.Expression)) { }
        protected override string MethodName { get { throw null; } }
        public override object Accept(Mono.CSharp.StructuralVisitor visitor) { throw null; }
    }
    public partial class ThenByDescending : Mono.CSharp.Linq.OrderByDescending
    {
        public ThenByDescending(Mono.CSharp.Linq.QueryBlock block, Mono.CSharp.Expression expr) : base (default(Mono.CSharp.Linq.QueryBlock), default(Mono.CSharp.Expression)) { }
        protected override string MethodName { get { throw null; } }
        public override object Accept(Mono.CSharp.StructuralVisitor visitor) { throw null; }
    }
    public partial class Where : Mono.CSharp.Linq.AQueryClause
    {
        public Where(Mono.CSharp.Linq.QueryBlock block, Mono.CSharp.Expression expr, Mono.CSharp.Location loc) : base (default(Mono.CSharp.Linq.QueryBlock), default(Mono.CSharp.Expression), default(Mono.CSharp.Location)) { }
        protected override string MethodName { get { throw null; } }
        public override object Accept(Mono.CSharp.StructuralVisitor visitor) { throw null; }
    }
}
namespace Mono.CSharp.Nullable
{
    public partial class LiftedConversion : Mono.CSharp.Expression, Mono.CSharp.IMemoryLocation
    {
        public LiftedConversion(Mono.CSharp.Expression expr, Mono.CSharp.Expression unwrap, Mono.CSharp.TypeSpec type) { }
        public LiftedConversion(Mono.CSharp.Expression expr, Mono.CSharp.Nullable.Unwrap unwrap, Mono.CSharp.TypeSpec type) { }
        public override bool IsNull { get { throw null; } }
        public void AddressOf(Mono.CSharp.EmitContext ec, Mono.CSharp.AddressOp mode) { }
        public override bool ContainsEmitWithAwait() { throw null; }
        public override Mono.CSharp.Expression CreateExpressionTree(Mono.CSharp.ResolveContext ec) { throw null; }
        protected override Mono.CSharp.Expression DoResolve(Mono.CSharp.ResolveContext ec) { throw null; }
        public override void Emit(Mono.CSharp.EmitContext ec) { }
        public override void FlowAnalysis(Mono.CSharp.FlowAnalysisContext fc) { }
    }
    public partial class LiftedNull : Mono.CSharp.NullConstant, Mono.CSharp.IMemoryLocation
    {
        internal LiftedNull() : base (default(Mono.CSharp.TypeSpec), default(Mono.CSharp.Location)) { }
        public void AddressOf(Mono.CSharp.EmitContext ec, Mono.CSharp.AddressOp Mode) { }
        public static Mono.CSharp.Constant Create(Mono.CSharp.TypeSpec nullable, Mono.CSharp.Location loc) { throw null; }
        public static Mono.CSharp.Constant CreateFromExpression(Mono.CSharp.ResolveContext rc, Mono.CSharp.Expression e) { throw null; }
        public override void Emit(Mono.CSharp.EmitContext ec) { }
    }
    public partial class LiftedUnaryOperator : Mono.CSharp.Unary, Mono.CSharp.IMemoryLocation
    {
        public LiftedUnaryOperator(Mono.CSharp.Unary.Operator op, Mono.CSharp.Expression expr, Mono.CSharp.Location loc) : base (default(Mono.CSharp.Unary.Operator), default(Mono.CSharp.Expression), default(Mono.CSharp.Location)) { }
        public void AddressOf(Mono.CSharp.EmitContext ec, Mono.CSharp.AddressOp mode) { }
        public override Mono.CSharp.Expression CreateExpressionTree(Mono.CSharp.ResolveContext ec) { throw null; }
        protected override Mono.CSharp.Expression DoResolve(Mono.CSharp.ResolveContext ec) { throw null; }
        public override void Emit(Mono.CSharp.EmitContext ec) { }
        protected override Mono.CSharp.Expression ResolveEnumOperator(Mono.CSharp.ResolveContext ec, Mono.CSharp.Expression expr, Mono.CSharp.TypeSpec[] predefined) { throw null; }
        protected override Mono.CSharp.Expression ResolveUserOperator(Mono.CSharp.ResolveContext ec, Mono.CSharp.Expression expr) { throw null; }
    }
    public partial class NullableType : Mono.CSharp.TypeExpr
    {
        public NullableType(Mono.CSharp.TypeSpec type, Mono.CSharp.Location loc) { }
        public override Mono.CSharp.TypeSpec ResolveAsType(Mono.CSharp.IMemberContext ec, bool allowUnboundTypeArguments=false) { throw null; }
    }
    public partial class NullCoalescingOperator : Mono.CSharp.Expression
    {
        public NullCoalescingOperator(Mono.CSharp.Expression left, Mono.CSharp.Expression right) { }
        public Mono.CSharp.Expression LeftExpression { get { throw null; } }
        public Mono.CSharp.Expression RightExpression { get { throw null; } }
        public override object Accept(Mono.CSharp.StructuralVisitor visitor) { throw null; }
        protected override void CloneTo(Mono.CSharp.CloneContext clonectx, Mono.CSharp.Expression t) { }
        public override bool ContainsEmitWithAwait() { throw null; }
        public override Mono.CSharp.Expression CreateExpressionTree(Mono.CSharp.ResolveContext ec) { throw null; }
        protected override Mono.CSharp.Expression DoResolve(Mono.CSharp.ResolveContext ec) { throw null; }
        public override void Emit(Mono.CSharp.EmitContext ec) { }
        public override void FlowAnalysis(Mono.CSharp.FlowAnalysisContext fc) { }
    }
    public partial class Unwrap : Mono.CSharp.Expression, Mono.CSharp.IMemoryLocation
    {
        public Unwrap(Mono.CSharp.Expression expr, bool useDefaultValue=true) { }
        public override bool IsNull { get { throw null; } }
        public Mono.CSharp.Expression Original { get { throw null; } }
        public void AddressOf(Mono.CSharp.EmitContext ec, Mono.CSharp.AddressOp mode) { }
        public override bool ContainsEmitWithAwait() { throw null; }
        public static Mono.CSharp.Expression Create(Mono.CSharp.Expression expr) { throw null; }
        public static Mono.CSharp.Nullable.Unwrap Create(Mono.CSharp.Expression expr, bool useDefaultValue) { throw null; }
        public override Mono.CSharp.Expression CreateExpressionTree(Mono.CSharp.ResolveContext ec) { throw null; }
        public static Mono.CSharp.Expression CreateUnwrapped(Mono.CSharp.Expression expr) { throw null; }
        protected override Mono.CSharp.Expression DoResolve(Mono.CSharp.ResolveContext ec) { throw null; }
        public override Mono.CSharp.Expression DoResolveLValue(Mono.CSharp.ResolveContext ec, Mono.CSharp.Expression right_side) { throw null; }
        public override void Emit(Mono.CSharp.EmitContext ec) { }
        public void EmitCheck(Mono.CSharp.EmitContext ec) { }
        public override void EmitSideEffect(Mono.CSharp.EmitContext ec) { }
        public override Mono.CSharp.Expression EmitToField(Mono.CSharp.EmitContext ec) { throw null; }
        public override bool Equals(object obj) { throw null; }
        public override void FlowAnalysis(Mono.CSharp.FlowAnalysisContext fc) { }
        public override int GetHashCode() { throw null; }
        public void Load(Mono.CSharp.EmitContext ec) { }
        public override System.Linq.Expressions.Expression MakeExpression(Mono.CSharp.BuilderContext ctx) { throw null; }
        public void Store(Mono.CSharp.EmitContext ec) { }
    }
    public partial class UnwrapCall : Mono.CSharp.CompositeExpression
    {
        public UnwrapCall(Mono.CSharp.Expression expr) : base (default(Mono.CSharp.Expression)) { }
        protected override Mono.CSharp.Expression DoResolve(Mono.CSharp.ResolveContext rc) { throw null; }
        public override void Emit(Mono.CSharp.EmitContext ec) { }
    }
    public partial class Wrap : Mono.CSharp.TypeCast
    {
        internal Wrap() : base (default(Mono.CSharp.Expression), default(Mono.CSharp.TypeSpec)) { }
        public static Mono.CSharp.Expression Create(Mono.CSharp.Expression expr, Mono.CSharp.TypeSpec type) { throw null; }
        public override Mono.CSharp.Expression CreateExpressionTree(Mono.CSharp.ResolveContext ec) { throw null; }
        public override void Emit(Mono.CSharp.EmitContext ec) { }
    }
}
namespace Mono.Security.Cryptography
{
    public sealed partial class CryptoConvert
    {
        internal CryptoConvert() { }
        public static System.Security.Cryptography.RSA FromCapiKeyBlob(byte[] blob) { throw null; }
        public static System.Security.Cryptography.RSA FromCapiKeyBlob(byte[] blob, int offset) { throw null; }
        public static System.Security.Cryptography.DSA FromCapiKeyBlobDSA(byte[] blob) { throw null; }
        public static System.Security.Cryptography.DSA FromCapiKeyBlobDSA(byte[] blob, int offset) { throw null; }
        public static System.Security.Cryptography.RSA FromCapiPrivateKeyBlob(byte[] blob) { throw null; }
        public static System.Security.Cryptography.RSA FromCapiPrivateKeyBlob(byte[] blob, int offset) { throw null; }
        public static System.Security.Cryptography.DSA FromCapiPrivateKeyBlobDSA(byte[] blob) { throw null; }
        public static System.Security.Cryptography.DSA FromCapiPrivateKeyBlobDSA(byte[] blob, int offset) { throw null; }
        public static System.Security.Cryptography.RSA FromCapiPublicKeyBlob(byte[] blob) { throw null; }
        public static System.Security.Cryptography.RSA FromCapiPublicKeyBlob(byte[] blob, int offset) { throw null; }
        public static System.Security.Cryptography.DSA FromCapiPublicKeyBlobDSA(byte[] blob) { throw null; }
        public static System.Security.Cryptography.DSA FromCapiPublicKeyBlobDSA(byte[] blob, int offset) { throw null; }
        public static byte[] FromHex(string hex) { throw null; }
        public static byte[] ToCapiKeyBlob(System.Security.Cryptography.AsymmetricAlgorithm keypair, bool includePrivateKey) { throw null; }
        public static byte[] ToCapiKeyBlob(System.Security.Cryptography.DSA dsa, bool includePrivateKey) { throw null; }
        public static byte[] ToCapiKeyBlob(System.Security.Cryptography.RSA rsa, bool includePrivateKey) { throw null; }
        public static byte[] ToCapiPrivateKeyBlob(System.Security.Cryptography.DSA dsa) { throw null; }
        public static byte[] ToCapiPrivateKeyBlob(System.Security.Cryptography.RSA rsa) { throw null; }
        public static byte[] ToCapiPublicKeyBlob(System.Security.Cryptography.DSA dsa) { throw null; }
        public static byte[] ToCapiPublicKeyBlob(System.Security.Cryptography.RSA rsa) { throw null; }
        public static string ToHex(byte[] input) { throw null; }
    }
}
