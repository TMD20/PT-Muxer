// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

[assembly:System.Reflection.AssemblyVersionAttribute("4.0.0.0")]
[assembly:System.Diagnostics.DebuggableAttribute(System.Diagnostics.DebuggableAttribute.DebuggingModes.IgnoreSymbolStoreSequencePoints)]
[assembly:System.Runtime.CompilerServices.CompilationRelaxationsAttribute(8)]
[assembly:System.Runtime.CompilerServices.RuntimeCompatibilityAttribute(WrapNonExceptionThrows=true)]
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
        public CapturedScope(int scope, string captured_name) { throw null; }
        public override string ToString() { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public partial struct CapturedVariable
    {
        public readonly string CapturedName;
        public readonly Mono.CompilerServices.SymbolWriter.CapturedVariable.CapturedKind Kind;
        public readonly string Name;
        public CapturedVariable(string name, string captured_name, Mono.CompilerServices.SymbolWriter.CapturedVariable.CapturedKind kind) { throw null; }
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
        public bool GetMethodBounds(out Mono.CompilerServices.SymbolWriter.LineNumberEntry start, out Mono.CompilerServices.SymbolWriter.LineNumberEntry end) { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public partial struct LocalVariableEntry
    {
        public readonly int BlockIndex;
        public readonly int Index;
        public readonly string Name;
        public LocalVariableEntry(int index, string name, int block) { throw null; }
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
    public partial class MonoSymbolWriter
    {
        protected readonly Mono.CompilerServices.SymbolWriter.MonoSymbolFile file;
        public MonoSymbolWriter(string filename) { }
        public Mono.CompilerServices.SymbolWriter.MonoSymbolFile SymbolFile { get { throw null; } }
        public void CloseCompilerGeneratedBlock(int end_offset) { }
        public void CloseMethod() { }
        public void CloseNamespace() { }
        public void CloseScope(int end_offset) { }
        public void DefineAnonymousScope(int id) { }
        public void DefineCapturedLocal(int scope_id, string name, string captured_name) { }
        public void DefineCapturedParameter(int scope_id, string name, string captured_name) { }
        public void DefineCapturedScope(int scope_id, int id, string captured_name) { }
        public void DefineCapturedThis(int scope_id, string captured_name) { }
        public Mono.CompilerServices.SymbolWriter.CompileUnitEntry DefineCompilationUnit(Mono.CompilerServices.SymbolWriter.SourceFileEntry source) { throw null; }
        public Mono.CompilerServices.SymbolWriter.SourceFileEntry DefineDocument(string url) { throw null; }
        public Mono.CompilerServices.SymbolWriter.SourceFileEntry DefineDocument(string url, byte[] guid, byte[] checksum) { throw null; }
        public void DefineLocalVariable(int index, string name) { }
        public int DefineNamespace(string name, Mono.CompilerServices.SymbolWriter.CompileUnitEntry unit, string[] using_clauses, int parent) { throw null; }
        public void DefineScopeVariable(int scope, int index) { }
        public void EndIteratorBody(int end_offset) { }
        public void EndIteratorDispatcher(int end_offset) { }
        public void MarkSequencePoint(int offset, Mono.CompilerServices.SymbolWriter.SourceFileEntry file, int line, int column, bool is_hidden) { }
        public void OpenCompilerGeneratedBlock(int start_offset) { }
        public Mono.CompilerServices.SymbolWriter.SourceMethodBuilder OpenMethod(Mono.CompilerServices.SymbolWriter.ICompileUnit file, int ns_id, Mono.CompilerServices.SymbolWriter.IMethodDef method) { throw null; }
        public int OpenScope(int start_offset) { throw null; }
        public void StartIteratorBody(int start_offset) { }
        public void StartIteratorDispatcher(int start_offset) { }
        public void WriteSymbolFile(System.Guid guid) { }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public partial struct NamespaceEntry
    {
        public readonly int Index;
        public readonly string Name;
        public readonly int Parent;
        public readonly string[] UsingClauses;
        public NamespaceEntry(string name, int index, string[] using_clauses, int parent) { throw null; }
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
        public ScopeVariable(int scope, int index) { throw null; }
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
    public partial class SymbolWriterImpl : System.Diagnostics.SymbolStore.ISymbolWriter
    {
        public SymbolWriterImpl(System.Reflection.Emit.ModuleBuilder mb) { }
        public void Close() { }
        public void CloseMethod() { }
        public void CloseNamespace() { }
        public void CloseScope(int endOffset) { }
        public System.Diagnostics.SymbolStore.ISymbolDocumentWriter DefineDocument(string url, System.Guid language, System.Guid languageVendor, System.Guid documentType) { throw null; }
        public void DefineField(System.Diagnostics.SymbolStore.SymbolToken parent, string name, System.Reflection.FieldAttributes attributes, byte[] signature, System.Diagnostics.SymbolStore.SymAddressKind addrKind, int addr1, int addr2, int addr3) { }
        public void DefineGlobalVariable(string name, System.Reflection.FieldAttributes attributes, byte[] signature, System.Diagnostics.SymbolStore.SymAddressKind addrKind, int addr1, int addr2, int addr3) { }
        public void DefineLocalVariable(string name, System.Reflection.FieldAttributes attributes, byte[] signature, System.Diagnostics.SymbolStore.SymAddressKind addrKind, int addr1, int addr2, int addr3, int startOffset, int endOffset) { }
        public void DefineParameter(string name, System.Reflection.ParameterAttributes attributes, int sequence, System.Diagnostics.SymbolStore.SymAddressKind addrKind, int addr1, int addr2, int addr3) { }
        public void DefineSequencePoints(System.Diagnostics.SymbolStore.ISymbolDocumentWriter document, int[] offsets, int[] lines, int[] columns, int[] endLines, int[] endColumns) { }
        public void Initialize(System.IntPtr emitter, string filename, bool fFullBuild) { }
        public void OpenMethod(System.Diagnostics.SymbolStore.SymbolToken method) { }
        public void OpenNamespace(string name) { }
        public int OpenScope(int startOffset) { throw null; }
        public void SetMethodSourceRange(System.Diagnostics.SymbolStore.ISymbolDocumentWriter startDoc, int startLine, int startColumn, System.Diagnostics.SymbolStore.ISymbolDocumentWriter endDoc, int endLine, int endColumn) { }
        public void SetScopeRange(int scopeID, int startOffset, int endOffset) { }
        public void SetSymAttribute(System.Diagnostics.SymbolStore.SymbolToken parent, string name, byte[] data) { }
        public void SetUnderlyingWriter(System.IntPtr underlyingWriter) { }
        public void SetUserEntryPoint(System.Diagnostics.SymbolStore.SymbolToken entryMethod) { }
        public void UsingNamespace(string fullName) { }
    }
}
