// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

[assembly:System.Reflection.AssemblyVersionAttribute("2.0.0.0")]
[assembly:System.CLSCompliantAttribute(true)]
[assembly:System.Diagnostics.DebuggableAttribute((System.Diagnostics.DebuggableAttribute.DebuggingModes)(2))]
[assembly:System.Reflection.AssemblyCompanyAttribute("Microsoft Corporation")]
[assembly:System.Reflection.AssemblyConfigurationAttribute("")]
[assembly:System.Reflection.AssemblyCopyrightAttribute("© Microsoft Corporation. All rights reserved.")]
[assembly:System.Reflection.AssemblyDefaultAliasAttribute("System.Web.Razor.dll")]
[assembly:System.Reflection.AssemblyDescriptionAttribute("")]
[assembly:System.Reflection.AssemblyFileVersionAttribute("2.0.0.0")]
[assembly:System.Reflection.AssemblyInformationalVersionAttribute("4.7.2046.0")]
[assembly:System.Reflection.AssemblyProductAttribute("Microsoft ASP.NET Web Pages")]
[assembly:System.Reflection.AssemblyTitleAttribute("System.Web.Razor")]
[assembly:System.Reflection.AssemblyTrademarkAttribute("")]
[assembly:System.Resources.NeutralResourcesLanguageAttribute("en-US")]
[assembly:System.Runtime.CompilerServices.CompilationRelaxationsAttribute(8)]
[assembly:System.Runtime.CompilerServices.ReferenceAssemblyAttribute]
[assembly:System.Runtime.CompilerServices.RuntimeCompatibilityAttribute(WrapNonExceptionThrows=true)]
[assembly:System.Runtime.InteropServices.ComVisibleAttribute(false)]
[assembly:System.Security.SecurityTransparentAttribute]
namespace System.Web.Razor
{
    public partial class CSharpRazorCodeLanguage : System.Web.Razor.RazorCodeLanguage
    {
        public CSharpRazorCodeLanguage() { }
        public override System.Type CodeDomProviderType { get { throw null; } }
        public override string LanguageName { get { throw null; } }
        public override System.Web.Razor.Generator.RazorCodeGenerator CreateCodeGenerator(string className, string rootNamespaceName, string sourceFileName, System.Web.Razor.RazorEngineHost host) { throw null; }
        public override System.Web.Razor.Parser.ParserBase CreateCodeParser() { throw null; }
    }
    public partial class DocumentParseCompleteEventArgs : System.EventArgs
    {
        public DocumentParseCompleteEventArgs() { }
        public System.Web.Razor.GeneratorResults GeneratorResults { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public System.Web.Razor.Text.TextChange SourceChange { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public bool TreeStructureChanged { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    }
    public partial class GeneratorResults : System.Web.Razor.ParserResults
    {
        protected GeneratorResults(bool success, System.Web.Razor.Parser.SyntaxTree.Block document, System.Collections.Generic.IList<System.Web.Razor.Parser.SyntaxTree.RazorError> parserErrors, System.CodeDom.CodeCompileUnit generatedCode, System.Collections.Generic.IDictionary<int, System.Web.Razor.Generator.GeneratedCodeMapping> designTimeLineMappings) : base (default(System.Web.Razor.Parser.SyntaxTree.Block), default(System.Collections.Generic.IList<System.Web.Razor.Parser.SyntaxTree.RazorError>)) { }
        public GeneratorResults(System.Web.Razor.Parser.SyntaxTree.Block document, System.Collections.Generic.IList<System.Web.Razor.Parser.SyntaxTree.RazorError> parserErrors, System.CodeDom.CodeCompileUnit generatedCode, System.Collections.Generic.IDictionary<int, System.Web.Razor.Generator.GeneratedCodeMapping> designTimeLineMappings) : base (default(System.Web.Razor.Parser.SyntaxTree.Block), default(System.Collections.Generic.IList<System.Web.Razor.Parser.SyntaxTree.RazorError>)) { }
        public GeneratorResults(System.Web.Razor.ParserResults parserResults, System.CodeDom.CodeCompileUnit generatedCode, System.Collections.Generic.IDictionary<int, System.Web.Razor.Generator.GeneratedCodeMapping> designTimeLineMappings) : base (default(System.Web.Razor.Parser.SyntaxTree.Block), default(System.Collections.Generic.IList<System.Web.Razor.Parser.SyntaxTree.RazorError>)) { }
        public System.Collections.Generic.IDictionary<int, System.Web.Razor.Generator.GeneratedCodeMapping> DesignTimeLineMappings { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        public System.CodeDom.CodeCompileUnit GeneratedCode { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
    }
    public partial class ParserResults
    {
        protected ParserResults(bool success, System.Web.Razor.Parser.SyntaxTree.Block document, System.Collections.Generic.IList<System.Web.Razor.Parser.SyntaxTree.RazorError> errors) { }
        public ParserResults(System.Web.Razor.Parser.SyntaxTree.Block document, System.Collections.Generic.IList<System.Web.Razor.Parser.SyntaxTree.RazorError> parserErrors) { }
        public System.Web.Razor.Parser.SyntaxTree.Block Document { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        public System.Collections.Generic.IList<System.Web.Razor.Parser.SyntaxTree.RazorError> ParserErrors { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        public bool Success { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
    }
    [System.FlagsAttribute]
    public enum PartialParseResult
    {
        Accepted = 2,
        AutoCompleteBlock = 16,
        Provisional = 4,
        Rejected = 1,
        SpanContextChanged = 8,
    }
    public abstract partial class RazorCodeLanguage
    {
        protected RazorCodeLanguage() { }
        public abstract System.Type CodeDomProviderType { get; }
        public abstract string LanguageName { get; }
        public static System.Collections.Generic.IDictionary<string, System.Web.Razor.RazorCodeLanguage> Languages { get { throw null; } }
        public abstract System.Web.Razor.Generator.RazorCodeGenerator CreateCodeGenerator(string className, string rootNamespaceName, string sourceFileName, System.Web.Razor.RazorEngineHost host);
        public abstract System.Web.Razor.Parser.ParserBase CreateCodeParser();
        public static System.Web.Razor.RazorCodeLanguage GetLanguageByExtension(string fileExtension) { throw null; }
    }
    [System.AttributeUsageAttribute((System.AttributeTargets)(4), AllowMultiple=true, Inherited=true)]
    public sealed partial class RazorDirectiveAttribute : System.Attribute
    {
        public RazorDirectiveAttribute(string name, string value) { }
        public string Name { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        public override object TypeId { get { throw null; } }
        public string Value { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        public override bool Equals(object obj) { throw null; }
        public override int GetHashCode() { throw null; }
    }
    public partial class RazorEditorParser : System.IDisposable
    {
        public RazorEditorParser(System.Web.Razor.RazorEngineHost host, string sourceFileName) { }
        public System.Web.Razor.Parser.SyntaxTree.Block CurrentParseTree { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        public string FileName { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        public System.Web.Razor.RazorEngineHost Host { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        public bool LastResultProvisional { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        public event System.EventHandler<System.Web.Razor.DocumentParseCompleteEventArgs> DocumentParseComplete { add { } remove { } }
        public virtual System.Web.Razor.PartialParseResult CheckForStructureChanges(System.Web.Razor.Text.TextChange change) { throw null; }
        public void Dispose() { }
        protected virtual void Dispose(bool disposing) { }
        public virtual string GetAutoCompleteString() { throw null; }
    }
    public partial class RazorEngineHost
    {
        protected RazorEngineHost() { }
        public RazorEngineHost(System.Web.Razor.RazorCodeLanguage codeLanguage) { }
        public RazorEngineHost(System.Web.Razor.RazorCodeLanguage codeLanguage, System.Func<System.Web.Razor.Parser.ParserBase> markupParserFactory) { }
        public virtual System.Web.Razor.RazorCodeLanguage CodeLanguage { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]protected set { } }
        public virtual string DefaultBaseClass { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public virtual string DefaultClassName { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public virtual string DefaultNamespace { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public virtual bool DesignTimeMode { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public virtual bool EnableInstrumentation { get { throw null; } set { } }
        public virtual System.Web.Razor.Generator.GeneratedClassContext GeneratedClassContext { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public virtual string InstrumentedSourceFilePath { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public virtual System.Collections.Generic.ISet<string> NamespaceImports { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        public virtual bool StaticHelpers { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public virtual System.Web.Razor.Parser.ParserBase CreateMarkupParser() { throw null; }
        public virtual System.Web.Razor.Generator.RazorCodeGenerator DecorateCodeGenerator(System.Web.Razor.Generator.RazorCodeGenerator incomingCodeGenerator) { throw null; }
        public virtual System.Web.Razor.Parser.ParserBase DecorateCodeParser(System.Web.Razor.Parser.ParserBase incomingCodeParser) { throw null; }
        public virtual System.Web.Razor.Parser.ParserBase DecorateMarkupParser(System.Web.Razor.Parser.ParserBase incomingMarkupParser) { throw null; }
        [System.ObsoleteAttribute("This method is obsolete, use the override which takes a CodeGeneratorContext instead")]
        public virtual void PostProcessGeneratedCode(System.CodeDom.CodeCompileUnit codeCompileUnit, System.CodeDom.CodeNamespace generatedNamespace, System.CodeDom.CodeTypeDeclaration generatedClass, System.CodeDom.CodeMemberMethod executeMethod) { }
        public virtual void PostProcessGeneratedCode(System.Web.Razor.Generator.CodeGeneratorContext context) { }
    }
    public partial class RazorTemplateEngine
    {
        public static readonly string DefaultClassName;
        public static readonly string DefaultNamespace;
        public RazorTemplateEngine(System.Web.Razor.RazorEngineHost host) { }
        public System.Web.Razor.RazorEngineHost Host { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        protected internal virtual System.Web.Razor.Generator.RazorCodeGenerator CreateCodeGenerator(string className, string rootNamespace, string sourceFileName) { throw null; }
        protected internal virtual System.Web.Razor.Parser.RazorParser CreateParser() { throw null; }
        public System.Web.Razor.GeneratorResults GenerateCode(System.IO.TextReader input) { throw null; }
        public System.Web.Razor.GeneratorResults GenerateCode(System.IO.TextReader input, System.Nullable<System.Threading.CancellationToken> cancelToken) { throw null; }
        public System.Web.Razor.GeneratorResults GenerateCode(System.IO.TextReader input, string className, string rootNamespace, string sourceFileName) { throw null; }
        public System.Web.Razor.GeneratorResults GenerateCode(System.IO.TextReader input, string className, string rootNamespace, string sourceFileName, System.Nullable<System.Threading.CancellationToken> cancelToken) { throw null; }
        public System.Web.Razor.GeneratorResults GenerateCode(System.Web.Razor.Text.ITextBuffer input) { throw null; }
        public System.Web.Razor.GeneratorResults GenerateCode(System.Web.Razor.Text.ITextBuffer input, System.Nullable<System.Threading.CancellationToken> cancelToken) { throw null; }
        public System.Web.Razor.GeneratorResults GenerateCode(System.Web.Razor.Text.ITextBuffer input, string className, string rootNamespace, string sourceFileName) { throw null; }
        public System.Web.Razor.GeneratorResults GenerateCode(System.Web.Razor.Text.ITextBuffer input, string className, string rootNamespace, string sourceFileName, System.Nullable<System.Threading.CancellationToken> cancelToken) { throw null; }
        protected internal virtual System.Web.Razor.GeneratorResults GenerateCodeCore(System.Web.Razor.Text.ITextDocument input, string className, string rootNamespace, string sourceFileName, System.Nullable<System.Threading.CancellationToken> cancelToken) { throw null; }
        public System.Web.Razor.ParserResults ParseTemplate(System.IO.TextReader input) { throw null; }
        public System.Web.Razor.ParserResults ParseTemplate(System.IO.TextReader input, System.Nullable<System.Threading.CancellationToken> cancelToken) { throw null; }
        public System.Web.Razor.ParserResults ParseTemplate(System.Web.Razor.Text.ITextBuffer input) { throw null; }
        public System.Web.Razor.ParserResults ParseTemplate(System.Web.Razor.Text.ITextBuffer input, System.Nullable<System.Threading.CancellationToken> cancelToken) { throw null; }
        protected internal virtual System.Web.Razor.ParserResults ParseTemplateCore(System.Web.Razor.Text.ITextDocument input, System.Nullable<System.Threading.CancellationToken> cancelToken) { throw null; }
    }
    public abstract partial class StateMachine<TReturn>
    {
        protected StateMachine() { }
        protected System.Web.Razor.StateMachine<TReturn>.State CurrentState { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        protected abstract System.Web.Razor.StateMachine<TReturn>.State StartState { get; }
        protected System.Web.Razor.StateMachine<TReturn>.StateResult Stay() { throw null; }
        protected System.Web.Razor.StateMachine<TReturn>.StateResult Stay(TReturn output) { throw null; }
        protected System.Web.Razor.StateMachine<TReturn>.StateResult Stop() { throw null; }
        protected System.Web.Razor.StateMachine<TReturn>.StateResult Transition(System.Web.Razor.StateMachine<TReturn>.State newState) { throw null; }
        protected System.Web.Razor.StateMachine<TReturn>.StateResult Transition(TReturn output, System.Web.Razor.StateMachine<TReturn>.State newState) { throw null; }
        protected virtual TReturn Turn() { throw null; }
        protected delegate System.Web.Razor.StateMachine<TReturn>.StateResult State();
        protected partial class StateResult
        {
            public StateResult(System.Web.Razor.StateMachine<TReturn>.State next) { }
            public StateResult(TReturn output, System.Web.Razor.StateMachine<TReturn>.State next) { }
            public bool HasOutput { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
            public System.Web.Razor.StateMachine<TReturn>.State Next { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
            public TReturn Output { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        }
    }
    public partial class VBRazorCodeLanguage : System.Web.Razor.RazorCodeLanguage
    {
        public VBRazorCodeLanguage() { }
        public override System.Type CodeDomProviderType { get { throw null; } }
        public override string LanguageName { get { throw null; } }
        public override System.Web.Razor.Generator.RazorCodeGenerator CreateCodeGenerator(string className, string rootNamespaceName, string sourceFileName, System.Web.Razor.RazorEngineHost host) { throw null; }
        public override System.Web.Razor.Parser.ParserBase CreateCodeParser() { throw null; }
    }
}
namespace System.Web.Razor.Editor
{
    [System.FlagsAttribute]
    public enum EditorHints
    {
        LayoutPage = 2,
        None = 0,
        VirtualPath = 1,
    }
    public partial class EditResult
    {
        public EditResult(System.Web.Razor.PartialParseResult result, System.Web.Razor.Parser.SyntaxTree.SpanBuilder editedSpan) { }
        public System.Web.Razor.Parser.SyntaxTree.SpanBuilder EditedSpan { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public System.Web.Razor.PartialParseResult Result { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    }
    public partial class ImplicitExpressionEditHandler : System.Web.Razor.Editor.SpanEditHandler
    {
        public ImplicitExpressionEditHandler(System.Func<string, System.Collections.Generic.IEnumerable<System.Web.Razor.Tokenizer.Symbols.ISymbol>> tokenizer, System.Collections.Generic.ISet<string> keywords, bool acceptTrailingDot) : base (default(System.Func<string, System.Collections.Generic.IEnumerable<System.Web.Razor.Tokenizer.Symbols.ISymbol>>)) { }
        public bool AcceptTrailingDot { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        public System.Collections.Generic.ISet<string> Keywords { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        protected override System.Web.Razor.PartialParseResult CanAcceptChange(System.Web.Razor.Parser.SyntaxTree.Span target, System.Web.Razor.Text.TextChange normalizedChange) { throw null; }
        public override bool Equals(object obj) { throw null; }
        public override int GetHashCode() { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class SingleLineMarkupEditHandler : System.Web.Razor.Editor.SpanEditHandler
    {
        public SingleLineMarkupEditHandler(System.Func<string, System.Collections.Generic.IEnumerable<System.Web.Razor.Tokenizer.Symbols.ISymbol>> tokenizer) : base (default(System.Func<string, System.Collections.Generic.IEnumerable<System.Web.Razor.Tokenizer.Symbols.ISymbol>>)) { }
        public SingleLineMarkupEditHandler(System.Func<string, System.Collections.Generic.IEnumerable<System.Web.Razor.Tokenizer.Symbols.ISymbol>> tokenizer, System.Web.Razor.Parser.SyntaxTree.AcceptedCharacters accepted) : base (default(System.Func<string, System.Collections.Generic.IEnumerable<System.Web.Razor.Tokenizer.Symbols.ISymbol>>)) { }
    }
    public partial class SpanEditHandler
    {
        public SpanEditHandler(System.Func<string, System.Collections.Generic.IEnumerable<System.Web.Razor.Tokenizer.Symbols.ISymbol>> tokenizer) { }
        public SpanEditHandler(System.Func<string, System.Collections.Generic.IEnumerable<System.Web.Razor.Tokenizer.Symbols.ISymbol>> tokenizer, System.Web.Razor.Parser.SyntaxTree.AcceptedCharacters accepted) { }
        public System.Web.Razor.Parser.SyntaxTree.AcceptedCharacters AcceptedCharacters { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public System.Web.Razor.Editor.EditorHints EditorHints { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public System.Func<string, System.Collections.Generic.IEnumerable<System.Web.Razor.Tokenizer.Symbols.ISymbol>> Tokenizer { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public virtual System.Web.Razor.Editor.EditResult ApplyChange(System.Web.Razor.Parser.SyntaxTree.Span target, System.Web.Razor.Text.TextChange change) { throw null; }
        public virtual System.Web.Razor.Editor.EditResult ApplyChange(System.Web.Razor.Parser.SyntaxTree.Span target, System.Web.Razor.Text.TextChange change, bool force) { throw null; }
        protected virtual System.Web.Razor.PartialParseResult CanAcceptChange(System.Web.Razor.Parser.SyntaxTree.Span target, System.Web.Razor.Text.TextChange normalizedChange) { throw null; }
        public static System.Web.Razor.Editor.SpanEditHandler CreateDefault() { throw null; }
        public static System.Web.Razor.Editor.SpanEditHandler CreateDefault(System.Func<string, System.Collections.Generic.IEnumerable<System.Web.Razor.Tokenizer.Symbols.ISymbol>> tokenizer) { throw null; }
        public override bool Equals(object obj) { throw null; }
        public override int GetHashCode() { throw null; }
        protected internal static string GetOldText(System.Web.Razor.Parser.SyntaxTree.Span target, System.Web.Razor.Text.TextChange change) { throw null; }
        protected internal static bool IsAtEndOfFirstLine(System.Web.Razor.Parser.SyntaxTree.Span target, System.Web.Razor.Text.TextChange change) { throw null; }
        protected internal static bool IsAtEndOfSpan(System.Web.Razor.Parser.SyntaxTree.Span target, System.Web.Razor.Text.TextChange change) { throw null; }
        protected internal static bool IsEndDeletion(System.Web.Razor.Parser.SyntaxTree.Span target, System.Web.Razor.Text.TextChange change) { throw null; }
        protected internal static bool IsEndInsertion(System.Web.Razor.Parser.SyntaxTree.Span target, System.Web.Razor.Text.TextChange change) { throw null; }
        protected internal static bool IsEndReplace(System.Web.Razor.Parser.SyntaxTree.Span target, System.Web.Razor.Text.TextChange change) { throw null; }
        public virtual bool OwnsChange(System.Web.Razor.Parser.SyntaxTree.Span target, System.Web.Razor.Text.TextChange change) { throw null; }
        public override string ToString() { throw null; }
        protected virtual System.Web.Razor.Parser.SyntaxTree.SpanBuilder UpdateSpan(System.Web.Razor.Parser.SyntaxTree.Span target, System.Web.Razor.Text.TextChange normalizedChange) { throw null; }
    }
}
namespace System.Web.Razor.Generator
{
    public partial class AddImportCodeGenerator : System.Web.Razor.Generator.SpanCodeGenerator
    {
        public AddImportCodeGenerator(string ns, int namespaceKeywordLength) { }
        public string Namespace { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        public int NamespaceKeywordLength { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public override bool Equals(object obj) { throw null; }
        public override void GenerateCode(System.Web.Razor.Parser.SyntaxTree.Span target, System.Web.Razor.Generator.CodeGeneratorContext context) { }
        public override int GetHashCode() { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class AttributeBlockCodeGenerator : System.Web.Razor.Generator.BlockCodeGenerator
    {
        public AttributeBlockCodeGenerator(string name, System.Web.Razor.Text.LocationTagged<string> prefix, System.Web.Razor.Text.LocationTagged<string> suffix) { }
        public string Name { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        public System.Web.Razor.Text.LocationTagged<string> Prefix { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        public System.Web.Razor.Text.LocationTagged<string> Suffix { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        public override bool Equals(object obj) { throw null; }
        public override void GenerateEndBlockCode(System.Web.Razor.Parser.SyntaxTree.Block target, System.Web.Razor.Generator.CodeGeneratorContext context) { }
        public override void GenerateStartBlockCode(System.Web.Razor.Parser.SyntaxTree.Block target, System.Web.Razor.Generator.CodeGeneratorContext context) { }
        public override int GetHashCode() { throw null; }
        public override string ToString() { throw null; }
    }
    public abstract partial class BlockCodeGenerator : System.Web.Razor.Generator.CodeGeneratorBase, System.Web.Razor.Generator.IBlockCodeGenerator
    {
        public static readonly System.Web.Razor.Generator.IBlockCodeGenerator Null;
        protected BlockCodeGenerator() { }
        public override bool Equals(object obj) { throw null; }
        public virtual void GenerateEndBlockCode(System.Web.Razor.Parser.SyntaxTree.Block target, System.Web.Razor.Generator.CodeGeneratorContext context) { }
        public virtual void GenerateStartBlockCode(System.Web.Razor.Parser.SyntaxTree.Block target, System.Web.Razor.Generator.CodeGeneratorContext context) { }
        public override int GetHashCode() { throw null; }
    }
    public partial class CodeGenerationCompleteEventArgs : System.EventArgs
    {
        public CodeGenerationCompleteEventArgs(string virtualPath, string physicalPath, System.CodeDom.CodeCompileUnit generatedCode) { }
        public System.CodeDom.CodeCompileUnit GeneratedCode { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        public string PhysicalPath { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        public string VirtualPath { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
    }
    public abstract partial class CodeGeneratorBase
    {
        protected CodeGeneratorBase() { }
        protected internal static int CalculatePadding(System.Web.Razor.Parser.SyntaxTree.Span target) { throw null; }
        protected internal static int CalculatePadding(System.Web.Razor.Parser.SyntaxTree.Span target, int generatedStart) { throw null; }
        protected internal static string Pad(string code, System.Web.Razor.Parser.SyntaxTree.Span target) { throw null; }
        protected internal static string Pad(string code, System.Web.Razor.Parser.SyntaxTree.Span target, int generatedStart) { throw null; }
    }
    public partial class CodeGeneratorContext
    {
        internal CodeGeneratorContext() { }
        public System.Collections.Generic.IDictionary<int, System.Web.Razor.Generator.GeneratedCodeMapping> CodeMappings { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        public System.CodeDom.CodeCompileUnit CompileUnit { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        public string CurrentBufferedStatement { get { throw null; } }
        public System.CodeDom.CodeTypeDeclaration GeneratedClass { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        public System.Web.Razor.RazorEngineHost Host { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        public System.CodeDom.CodeNamespace Namespace { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        public string SourceFile { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        public System.CodeDom.CodeMemberMethod TargetMethod { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public string TargetWriterName { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public int AddCodeMapping(System.Web.Razor.Text.SourceLocation sourceLocation, int generatedCodeStart, int generatedCodeLength) { throw null; }
        public void AddContextCall(System.Web.Razor.Parser.SyntaxTree.Span contentSpan, string methodName, bool isLiteral) { }
        public void AddDesignTimeHelperStatement(System.CodeDom.CodeSnippetStatement statement) { }
        public void AddStatement(string generatedCode) { }
        public void AddStatement(string body, System.CodeDom.CodeLinePragma pragma) { }
        public void BufferStatementFragment(string fragment) { }
        public void BufferStatementFragment(string fragment, System.Web.Razor.Parser.SyntaxTree.Span sourceSpan) { }
        public void BufferStatementFragment(System.Web.Razor.Parser.SyntaxTree.Span sourceSpan) { }
        public System.IDisposable ChangeStatementCollector(System.Action<string, System.CodeDom.CodeLinePragma> collector) { throw null; }
        public static System.Web.Razor.Generator.CodeGeneratorContext Create(System.Web.Razor.RazorEngineHost host, string className, string rootNamespace, string sourceFile, bool shouldGenerateLinePragmas) { throw null; }
        public void EnsureExpressionHelperVariable() { }
        public void FlushBufferedStatement() { }
        public System.CodeDom.CodeLinePragma GenerateLinePragma(System.Web.Razor.Parser.SyntaxTree.Span target) { throw null; }
        public System.CodeDom.CodeLinePragma GenerateLinePragma(System.Web.Razor.Parser.SyntaxTree.Span target, int generatedCodeStart) { throw null; }
        public System.CodeDom.CodeLinePragma GenerateLinePragma(System.Web.Razor.Parser.SyntaxTree.Span target, int generatedCodeStart, int codeLength) { throw null; }
        public System.CodeDom.CodeLinePragma GenerateLinePragma(System.Web.Razor.Text.SourceLocation start, int generatedCodeStart, int codeLength) { throw null; }
        public void MarkEndOfGeneratedCode() { }
        public void MarkStartOfGeneratedCode() { }
    }
    public partial class CSharpRazorCodeGenerator : System.Web.Razor.Generator.RazorCodeGenerator
    {
        public CSharpRazorCodeGenerator(string className, string rootNamespaceName, string sourceFileName, System.Web.Razor.RazorEngineHost host) : base (default(string), default(string), default(string), default(System.Web.Razor.RazorEngineHost)) { }
        protected override void Initialize(System.Web.Razor.Generator.CodeGeneratorContext context) { }
    }
    public partial class DynamicAttributeBlockCodeGenerator : System.Web.Razor.Generator.BlockCodeGenerator
    {
        public DynamicAttributeBlockCodeGenerator(System.Web.Razor.Text.LocationTagged<string> prefix, int offset, int line, int col) { }
        public DynamicAttributeBlockCodeGenerator(System.Web.Razor.Text.LocationTagged<string> prefix, System.Web.Razor.Text.SourceLocation valueStart) { }
        public System.Web.Razor.Text.LocationTagged<string> Prefix { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        public System.Web.Razor.Text.SourceLocation ValueStart { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        public override bool Equals(object obj) { throw null; }
        public override void GenerateEndBlockCode(System.Web.Razor.Parser.SyntaxTree.Block target, System.Web.Razor.Generator.CodeGeneratorContext context) { }
        public override void GenerateStartBlockCode(System.Web.Razor.Parser.SyntaxTree.Block target, System.Web.Razor.Generator.CodeGeneratorContext context) { }
        public override int GetHashCode() { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class ExpressionCodeGenerator : System.Web.Razor.Generator.HybridCodeGenerator
    {
        public ExpressionCodeGenerator() { }
        public override bool Equals(object obj) { throw null; }
        public override void GenerateCode(System.Web.Razor.Parser.SyntaxTree.Span target, System.Web.Razor.Generator.CodeGeneratorContext context) { }
        public override void GenerateEndBlockCode(System.Web.Razor.Parser.SyntaxTree.Block target, System.Web.Razor.Generator.CodeGeneratorContext context) { }
        public override void GenerateStartBlockCode(System.Web.Razor.Parser.SyntaxTree.Block target, System.Web.Razor.Generator.CodeGeneratorContext context) { }
        public override int GetHashCode() { throw null; }
        public override string ToString() { throw null; }
    }
    public enum ExpressionRenderingMode
    {
        InjectCode = 1,
        WriteToOutput = 0,
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public partial struct GeneratedClassContext
    {
        public static readonly System.Web.Razor.Generator.GeneratedClassContext Default;
        public static readonly string DefaultExecuteMethodName;
        public static readonly string DefaultLayoutPropertyName;
        public static readonly string DefaultWriteAttributeMethodName;
        public static readonly string DefaultWriteAttributeToMethodName;
        public static readonly string DefaultWriteLiteralMethodName;
        public static readonly string DefaultWriteMethodName;
        public GeneratedClassContext(string executeMethodName, string writeMethodName, string writeLiteralMethodName) { throw null;}
        public GeneratedClassContext(string executeMethodName, string writeMethodName, string writeLiteralMethodName, string writeToMethodName, string writeLiteralToMethodName, string templateTypeName) { throw null;}
        public GeneratedClassContext(string executeMethodName, string writeMethodName, string writeLiteralMethodName, string writeToMethodName, string writeLiteralToMethodName, string templateTypeName, string defineSectionMethodName) { throw null;}
        public GeneratedClassContext(string executeMethodName, string writeMethodName, string writeLiteralMethodName, string writeToMethodName, string writeLiteralToMethodName, string templateTypeName, string defineSectionMethodName, string beginContextMethodName, string endContextMethodName) { throw null;}
        public bool AllowSections { get { throw null; } }
        public bool AllowTemplates { get { throw null; } }
        public string BeginContextMethodName { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public string DefineSectionMethodName { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public string EndContextMethodName { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public string ExecuteMethodName { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        public string LayoutPropertyName { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public string ResolveUrlMethodName { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public bool SupportsInstrumentation { get { throw null; } }
        public string TemplateTypeName { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public string WriteAttributeMethodName { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public string WriteAttributeToMethodName { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public string WriteLiteralMethodName { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        public string WriteLiteralToMethodName { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        public string WriteMethodName { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        public string WriteToMethodName { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        public override bool Equals(object obj) { throw null; }
        public override int GetHashCode() { throw null; }
        public static bool operator ==(System.Web.Razor.Generator.GeneratedClassContext left, System.Web.Razor.Generator.GeneratedClassContext right) { throw null; }
        public static bool operator !=(System.Web.Razor.Generator.GeneratedClassContext left, System.Web.Razor.Generator.GeneratedClassContext right) { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public partial struct GeneratedCodeMapping
    {
        public GeneratedCodeMapping(int startLine, int startColumn, int startGeneratedColumn, int codeLength) { throw null;}
        public GeneratedCodeMapping(int startOffset, int startLine, int startColumn, int startGeneratedColumn, int codeLength) { throw null;}
        public int CodeLength { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public int StartColumn { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public int StartGeneratedColumn { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public int StartLine { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public System.Nullable<int> StartOffset { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public override bool Equals(object obj) { throw null; }
        public override int GetHashCode() { throw null; }
        public static bool operator ==(System.Web.Razor.Generator.GeneratedCodeMapping left, System.Web.Razor.Generator.GeneratedCodeMapping right) { throw null; }
        public static bool operator !=(System.Web.Razor.Generator.GeneratedCodeMapping left, System.Web.Razor.Generator.GeneratedCodeMapping right) { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class HelperCodeGenerator : System.Web.Razor.Generator.BlockCodeGenerator
    {
        public HelperCodeGenerator(System.Web.Razor.Text.LocationTagged<string> signature, bool headerComplete) { }
        public System.Web.Razor.Text.LocationTagged<string> Footer { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public bool HeaderComplete { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        public System.Web.Razor.Text.LocationTagged<string> Signature { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        public override bool Equals(object obj) { throw null; }
        public override void GenerateEndBlockCode(System.Web.Razor.Parser.SyntaxTree.Block target, System.Web.Razor.Generator.CodeGeneratorContext context) { }
        public override void GenerateStartBlockCode(System.Web.Razor.Parser.SyntaxTree.Block target, System.Web.Razor.Generator.CodeGeneratorContext context) { }
        public override int GetHashCode() { throw null; }
        public override string ToString() { throw null; }
    }
    public abstract partial class HybridCodeGenerator : System.Web.Razor.Generator.CodeGeneratorBase, System.Web.Razor.Generator.IBlockCodeGenerator, System.Web.Razor.Generator.ISpanCodeGenerator
    {
        protected HybridCodeGenerator() { }
        public virtual void GenerateCode(System.Web.Razor.Parser.SyntaxTree.Span target, System.Web.Razor.Generator.CodeGeneratorContext context) { }
        public virtual void GenerateEndBlockCode(System.Web.Razor.Parser.SyntaxTree.Block target, System.Web.Razor.Generator.CodeGeneratorContext context) { }
        public virtual void GenerateStartBlockCode(System.Web.Razor.Parser.SyntaxTree.Block target, System.Web.Razor.Generator.CodeGeneratorContext context) { }
    }
    public partial interface IBlockCodeGenerator
    {
        void GenerateEndBlockCode(System.Web.Razor.Parser.SyntaxTree.Block target, System.Web.Razor.Generator.CodeGeneratorContext context);
        void GenerateStartBlockCode(System.Web.Razor.Parser.SyntaxTree.Block target, System.Web.Razor.Generator.CodeGeneratorContext context);
    }
    public partial interface ISpanCodeGenerator
    {
        void GenerateCode(System.Web.Razor.Parser.SyntaxTree.Span target, System.Web.Razor.Generator.CodeGeneratorContext context);
    }
    public partial class LiteralAttributeCodeGenerator : System.Web.Razor.Generator.SpanCodeGenerator
    {
        public LiteralAttributeCodeGenerator(System.Web.Razor.Text.LocationTagged<string> prefix, System.Web.Razor.Text.LocationTagged<string> value) { }
        public LiteralAttributeCodeGenerator(System.Web.Razor.Text.LocationTagged<string> prefix, System.Web.Razor.Text.LocationTagged<System.Web.Razor.Generator.SpanCodeGenerator> valueGenerator) { }
        public System.Web.Razor.Text.LocationTagged<string> Prefix { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        public System.Web.Razor.Text.LocationTagged<string> Value { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        public System.Web.Razor.Text.LocationTagged<System.Web.Razor.Generator.SpanCodeGenerator> ValueGenerator { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        public override bool Equals(object obj) { throw null; }
        public override void GenerateCode(System.Web.Razor.Parser.SyntaxTree.Span target, System.Web.Razor.Generator.CodeGeneratorContext context) { }
        public override int GetHashCode() { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class MarkupCodeGenerator : System.Web.Razor.Generator.SpanCodeGenerator
    {
        public MarkupCodeGenerator() { }
        public override bool Equals(object obj) { throw null; }
        public override void GenerateCode(System.Web.Razor.Parser.SyntaxTree.Span target, System.Web.Razor.Generator.CodeGeneratorContext context) { }
        public override int GetHashCode() { throw null; }
        public override string ToString() { throw null; }
    }
    public abstract partial class RazorCodeGenerator : System.Web.Razor.Parser.ParserVisitor
    {
        protected RazorCodeGenerator(string className, string rootNamespaceName, string sourceFileName, System.Web.Razor.RazorEngineHost host) { }
        public string ClassName { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        public System.Web.Razor.Generator.CodeGeneratorContext Context { get { throw null; } }
        public bool DesignTimeMode { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public bool GenerateLinePragmas { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public System.Web.Razor.RazorEngineHost Host { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        public string RootNamespaceName { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        public string SourceFileName { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        protected virtual void Initialize(System.Web.Razor.Generator.CodeGeneratorContext context) { }
        public override void OnComplete() { }
        public override void VisitEndBlock(System.Web.Razor.Parser.SyntaxTree.Block block) { }
        public override void VisitSpan(System.Web.Razor.Parser.SyntaxTree.Span span) { }
        public override void VisitStartBlock(System.Web.Razor.Parser.SyntaxTree.Block block) { }
    }
    public partial class RazorCommentCodeGenerator : System.Web.Razor.Generator.BlockCodeGenerator
    {
        public RazorCommentCodeGenerator() { }
        public override void GenerateStartBlockCode(System.Web.Razor.Parser.SyntaxTree.Block target, System.Web.Razor.Generator.CodeGeneratorContext context) { }
    }
    public partial class RazorDirectiveAttributeCodeGenerator : System.Web.Razor.Generator.SpanCodeGenerator
    {
        public RazorDirectiveAttributeCodeGenerator(string name, string value) { }
        public string Name { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        public string Value { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        public override bool Equals(object obj) { throw null; }
        public override void GenerateCode(System.Web.Razor.Parser.SyntaxTree.Span target, System.Web.Razor.Generator.CodeGeneratorContext context) { }
        public override int GetHashCode() { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class ResolveUrlCodeGenerator : System.Web.Razor.Generator.SpanCodeGenerator
    {
        public ResolveUrlCodeGenerator() { }
        public override bool Equals(object obj) { throw null; }
        public override void GenerateCode(System.Web.Razor.Parser.SyntaxTree.Span target, System.Web.Razor.Generator.CodeGeneratorContext context) { }
        public override int GetHashCode() { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class SectionCodeGenerator : System.Web.Razor.Generator.BlockCodeGenerator
    {
        public SectionCodeGenerator(string sectionName) { }
        public string SectionName { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        public override bool Equals(object obj) { throw null; }
        public override void GenerateEndBlockCode(System.Web.Razor.Parser.SyntaxTree.Block target, System.Web.Razor.Generator.CodeGeneratorContext context) { }
        public override void GenerateStartBlockCode(System.Web.Razor.Parser.SyntaxTree.Block target, System.Web.Razor.Generator.CodeGeneratorContext context) { }
        public override int GetHashCode() { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class SetBaseTypeCodeGenerator : System.Web.Razor.Generator.SpanCodeGenerator
    {
        public SetBaseTypeCodeGenerator(string baseType) { }
        public string BaseType { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        public override bool Equals(object obj) { throw null; }
        public override void GenerateCode(System.Web.Razor.Parser.SyntaxTree.Span target, System.Web.Razor.Generator.CodeGeneratorContext context) { }
        public override int GetHashCode() { throw null; }
        protected virtual string ResolveType(System.Web.Razor.Generator.CodeGeneratorContext context, string baseType) { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class SetLayoutCodeGenerator : System.Web.Razor.Generator.SpanCodeGenerator
    {
        public SetLayoutCodeGenerator(string layoutPath) { }
        public string LayoutPath { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public override bool Equals(object obj) { throw null; }
        public override void GenerateCode(System.Web.Razor.Parser.SyntaxTree.Span target, System.Web.Razor.Generator.CodeGeneratorContext context) { }
        public override int GetHashCode() { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class SetVBOptionCodeGenerator : System.Web.Razor.Generator.SpanCodeGenerator
    {
        public static readonly string ExplicitCodeDomOptionName;
        public static readonly string StrictCodeDomOptionName;
        public SetVBOptionCodeGenerator(string optionName, bool value) { }
        public string OptionName { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        public bool Value { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        public static System.Web.Razor.Generator.SetVBOptionCodeGenerator Explicit(bool onOffValue) { throw null; }
        public override void GenerateCode(System.Web.Razor.Parser.SyntaxTree.Span target, System.Web.Razor.Generator.CodeGeneratorContext context) { }
        public static System.Web.Razor.Generator.SetVBOptionCodeGenerator Strict(bool onOffValue) { throw null; }
        public override string ToString() { throw null; }
    }
    public abstract partial class SpanCodeGenerator : System.Web.Razor.Generator.CodeGeneratorBase, System.Web.Razor.Generator.ISpanCodeGenerator
    {
        public static readonly System.Web.Razor.Generator.ISpanCodeGenerator Null;
        protected SpanCodeGenerator() { }
        public override bool Equals(object obj) { throw null; }
        public virtual void GenerateCode(System.Web.Razor.Parser.SyntaxTree.Span target, System.Web.Razor.Generator.CodeGeneratorContext context) { }
        public override int GetHashCode() { throw null; }
    }
    public partial class StatementCodeGenerator : System.Web.Razor.Generator.SpanCodeGenerator
    {
        public StatementCodeGenerator() { }
        public override bool Equals(object obj) { throw null; }
        public override void GenerateCode(System.Web.Razor.Parser.SyntaxTree.Span target, System.Web.Razor.Generator.CodeGeneratorContext context) { }
        public override int GetHashCode() { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class TemplateBlockCodeGenerator : System.Web.Razor.Generator.BlockCodeGenerator
    {
        public TemplateBlockCodeGenerator() { }
        public override void GenerateEndBlockCode(System.Web.Razor.Parser.SyntaxTree.Block target, System.Web.Razor.Generator.CodeGeneratorContext context) { }
        public override void GenerateStartBlockCode(System.Web.Razor.Parser.SyntaxTree.Block target, System.Web.Razor.Generator.CodeGeneratorContext context) { }
    }
    public partial class TypeMemberCodeGenerator : System.Web.Razor.Generator.SpanCodeGenerator
    {
        public TypeMemberCodeGenerator() { }
        public override bool Equals(object obj) { throw null; }
        public override void GenerateCode(System.Web.Razor.Parser.SyntaxTree.Span target, System.Web.Razor.Generator.CodeGeneratorContext context) { }
        public override int GetHashCode() { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class VBRazorCodeGenerator : System.Web.Razor.Generator.RazorCodeGenerator
    {
        public VBRazorCodeGenerator(string className, string rootNamespaceName, string sourceFileName, System.Web.Razor.RazorEngineHost host) : base (default(string), default(string), default(string), default(System.Web.Razor.RazorEngineHost)) { }
    }
}
namespace System.Web.Razor.Parser
{
    [System.FlagsAttribute]
    public enum BalancingModes
    {
        AllowCommentsAndTemplates = 4,
        AllowEmbeddedTransitions = 8,
        BacktrackOnFailure = 1,
        NoErrorOnFailure = 2,
        None = 0,
    }
    public partial class CallbackVisitor : System.Web.Razor.Parser.ParserVisitor
    {
        public CallbackVisitor(System.Action<System.Web.Razor.Parser.SyntaxTree.Span> spanCallback) { }
        public CallbackVisitor(System.Action<System.Web.Razor.Parser.SyntaxTree.Span> spanCallback, System.Action<System.Web.Razor.Parser.SyntaxTree.RazorError> errorCallback) { }
        public CallbackVisitor(System.Action<System.Web.Razor.Parser.SyntaxTree.Span> spanCallback, System.Action<System.Web.Razor.Parser.SyntaxTree.RazorError> errorCallback, System.Action<System.Web.Razor.Parser.SyntaxTree.BlockType> startBlockCallback, System.Action<System.Web.Razor.Parser.SyntaxTree.BlockType> endBlockCallback) { }
        public CallbackVisitor(System.Action<System.Web.Razor.Parser.SyntaxTree.Span> spanCallback, System.Action<System.Web.Razor.Parser.SyntaxTree.RazorError> errorCallback, System.Action<System.Web.Razor.Parser.SyntaxTree.BlockType> startBlockCallback, System.Action<System.Web.Razor.Parser.SyntaxTree.BlockType> endBlockCallback, System.Action completeCallback) { }
        public System.Threading.SynchronizationContext SynchronizationContext { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public override void OnComplete() { }
        public override void VisitEndBlock(System.Web.Razor.Parser.SyntaxTree.Block block) { }
        public override void VisitError(System.Web.Razor.Parser.SyntaxTree.RazorError err) { }
        public override void VisitSpan(System.Web.Razor.Parser.SyntaxTree.Span span) { }
        public override void VisitStartBlock(System.Web.Razor.Parser.SyntaxTree.Block block) { }
    }
    public partial class CSharpCodeParser : System.Web.Razor.Parser.TokenizerBackedParser<System.Web.Razor.Tokenizer.CSharpTokenizer, System.Web.Razor.Tokenizer.Symbols.CSharpSymbol, System.Web.Razor.Tokenizer.Symbols.CSharpSymbolType>
    {
        public CSharpCodeParser() { }
        public bool IsNested { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        protected internal System.Collections.Generic.ISet<string> Keywords { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        protected override System.Web.Razor.Parser.LanguageCharacteristics<System.Web.Razor.Tokenizer.CSharpTokenizer, System.Web.Razor.Tokenizer.Symbols.CSharpSymbol, System.Web.Razor.Tokenizer.Symbols.CSharpSymbolType> Language { get { throw null; } }
        protected override System.Web.Razor.Parser.ParserBase OtherParser { get { throw null; } }
        protected internal bool AcceptIf(System.Web.Razor.Tokenizer.Symbols.CSharpKeyword keyword) { throw null; }
        [System.Diagnostics.ConditionalAttribute("DEBUG")]
        protected void AssertDirective(string directive) { }
        protected internal bool At(System.Web.Razor.Tokenizer.Symbols.CSharpKeyword keyword) { throw null; }
        protected void BaseTypeDirective(string noTypeNameError, System.Func<string, System.Web.Razor.Generator.SpanCodeGenerator> createCodeGenerator) { }
        protected virtual void FunctionsDirective() { }
        protected override void HandleEmbeddedTransition() { }
        protected virtual void HelperDirective() { }
        protected virtual void InheritsDirective() { }
        protected void InheritsDirectiveCore() { }
        protected override bool IsAtEmbeddedTransition(bool allowTemplatesAndComments, bool allowTransitions) { throw null; }
        protected static System.Func<System.Web.Razor.Tokenizer.Symbols.CSharpSymbol, bool> IsSpacingToken(bool includeNewLines, bool includeComments) { throw null; }
        protected virtual void LayoutDirective() { }
        protected void MapDirectives(System.Action handler, params string[] directives) { }
        protected override void OutputSpanBeforeRazorComment() { }
        public override void ParseBlock() { }
        protected virtual void ReservedDirective(bool topLevel) { }
        protected virtual void SectionDirective() { }
        protected virtual void SessionStateDirective() { }
        protected void SessionStateDirectiveCore() { }
        protected void SessionStateTypeDirective(string noValueError, System.Func<string, string, System.Web.Razor.Generator.SpanCodeGenerator> createCodeGenerator) { }
        protected bool TryGetDirectiveHandler(string directive, out System.Action handler) { handler = default(System.Action); throw null; }
        protected virtual bool ValidSessionStateValue() { throw null; }
        protected partial class Block
        {
            public Block(string name, System.Web.Razor.Text.SourceLocation start) { }
            public Block(System.Web.Razor.Tokenizer.Symbols.CSharpSymbol symbol) { }
            public string Name { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
            public System.Web.Razor.Text.SourceLocation Start { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        }
    }
    public partial class CSharpLanguageCharacteristics : System.Web.Razor.Parser.LanguageCharacteristics<System.Web.Razor.Tokenizer.CSharpTokenizer, System.Web.Razor.Tokenizer.Symbols.CSharpSymbol, System.Web.Razor.Tokenizer.Symbols.CSharpSymbolType>
    {
        internal CSharpLanguageCharacteristics() { }
        public static System.Web.Razor.Parser.CSharpLanguageCharacteristics Instance { get { throw null; } }
        public override System.Web.Razor.Tokenizer.Symbols.CSharpSymbol CreateMarkerSymbol(System.Web.Razor.Text.SourceLocation location) { throw null; }
        protected override System.Web.Razor.Tokenizer.Symbols.CSharpSymbol CreateSymbol(System.Web.Razor.Text.SourceLocation location, string content, System.Web.Razor.Tokenizer.Symbols.CSharpSymbolType type, System.Collections.Generic.IEnumerable<System.Web.Razor.Parser.SyntaxTree.RazorError> errors) { throw null; }
        public override System.Web.Razor.Tokenizer.CSharpTokenizer CreateTokenizer(System.Web.Razor.Text.ITextDocument source) { throw null; }
        public override System.Web.Razor.Tokenizer.Symbols.CSharpSymbolType FlipBracket(System.Web.Razor.Tokenizer.Symbols.CSharpSymbolType bracket) { throw null; }
        public static string GetKeyword(System.Web.Razor.Tokenizer.Symbols.CSharpKeyword keyword) { throw null; }
        public override System.Web.Razor.Tokenizer.Symbols.CSharpSymbolType GetKnownSymbolType(System.Web.Razor.Tokenizer.Symbols.KnownSymbolType type) { throw null; }
        public override string GetSample(System.Web.Razor.Tokenizer.Symbols.CSharpSymbolType type) { throw null; }
        public static string GetSymbolSample(System.Web.Razor.Tokenizer.Symbols.CSharpSymbolType type) { throw null; }
    }
    public partial class HtmlLanguageCharacteristics : System.Web.Razor.Parser.LanguageCharacteristics<System.Web.Razor.Tokenizer.HtmlTokenizer, System.Web.Razor.Tokenizer.Symbols.HtmlSymbol, System.Web.Razor.Tokenizer.Symbols.HtmlSymbolType>
    {
        internal HtmlLanguageCharacteristics() { }
        public static System.Web.Razor.Parser.HtmlLanguageCharacteristics Instance { get { throw null; } }
        public override System.Web.Razor.Tokenizer.Symbols.HtmlSymbol CreateMarkerSymbol(System.Web.Razor.Text.SourceLocation location) { throw null; }
        protected override System.Web.Razor.Tokenizer.Symbols.HtmlSymbol CreateSymbol(System.Web.Razor.Text.SourceLocation location, string content, System.Web.Razor.Tokenizer.Symbols.HtmlSymbolType type, System.Collections.Generic.IEnumerable<System.Web.Razor.Parser.SyntaxTree.RazorError> errors) { throw null; }
        public override System.Web.Razor.Tokenizer.HtmlTokenizer CreateTokenizer(System.Web.Razor.Text.ITextDocument source) { throw null; }
        public override System.Web.Razor.Tokenizer.Symbols.HtmlSymbolType FlipBracket(System.Web.Razor.Tokenizer.Symbols.HtmlSymbolType bracket) { throw null; }
        public override System.Web.Razor.Tokenizer.Symbols.HtmlSymbolType GetKnownSymbolType(System.Web.Razor.Tokenizer.Symbols.KnownSymbolType type) { throw null; }
        public override string GetSample(System.Web.Razor.Tokenizer.Symbols.HtmlSymbolType type) { throw null; }
    }
    public partial class HtmlMarkupParser : System.Web.Razor.Parser.TokenizerBackedParser<System.Web.Razor.Tokenizer.HtmlTokenizer, System.Web.Razor.Tokenizer.Symbols.HtmlSymbol, System.Web.Razor.Tokenizer.Symbols.HtmlSymbolType>
    {
        public HtmlMarkupParser() { }
        protected override System.Web.Razor.Parser.LanguageCharacteristics<System.Web.Razor.Tokenizer.HtmlTokenizer, System.Web.Razor.Tokenizer.Symbols.HtmlSymbol, System.Web.Razor.Tokenizer.Symbols.HtmlSymbolType> Language { get { throw null; } }
        protected override System.Web.Razor.Parser.ParserBase OtherParser { get { throw null; } }
        public System.Collections.Generic.ISet<string> VoidElements { get { throw null; } }
        public override void BuildSpan(System.Web.Razor.Parser.SyntaxTree.SpanBuilder span, System.Web.Razor.Text.SourceLocation start, string content) { }
        protected static System.Func<System.Web.Razor.Tokenizer.Symbols.HtmlSymbol, bool> IsSpacingToken(bool includeNewLines) { throw null; }
        protected override void OutputSpanBeforeRazorComment() { }
        public override void ParseBlock() { }
        public override void ParseDocument() { }
        public override void ParseSection(System.Tuple<string, string> nestingSequences, bool caseSensitive) { }
        protected void SkipToAndParseCode(System.Func<System.Web.Razor.Tokenizer.Symbols.HtmlSymbol, bool> condition) { }
        protected void SkipToAndParseCode(System.Web.Razor.Tokenizer.Symbols.HtmlSymbolType type) { }
    }
    public abstract partial class LanguageCharacteristics<TTokenizer, TSymbol, TSymbolType> where TTokenizer : System.Web.Razor.Tokenizer.Tokenizer<TSymbol, TSymbolType> where TSymbol : System.Web.Razor.Tokenizer.Symbols.SymbolBase<TSymbolType>
    {
        protected LanguageCharacteristics() { }
        public abstract TSymbol CreateMarkerSymbol(System.Web.Razor.Text.SourceLocation location);
        protected abstract TSymbol CreateSymbol(System.Web.Razor.Text.SourceLocation location, string content, TSymbolType type, System.Collections.Generic.IEnumerable<System.Web.Razor.Parser.SyntaxTree.RazorError> errors);
        public abstract TTokenizer CreateTokenizer(System.Web.Razor.Text.ITextDocument source);
        public abstract TSymbolType FlipBracket(TSymbolType bracket);
        public abstract TSymbolType GetKnownSymbolType(System.Web.Razor.Tokenizer.Symbols.KnownSymbolType type);
        public abstract string GetSample(TSymbolType type);
        public virtual bool IsCommentBody(TSymbol symbol) { throw null; }
        public virtual bool IsCommentStar(TSymbol symbol) { throw null; }
        public virtual bool IsCommentStart(TSymbol symbol) { throw null; }
        public virtual bool IsIdentifier(TSymbol symbol) { throw null; }
        public virtual bool IsKeyword(TSymbol symbol) { throw null; }
        public virtual bool IsKnownSymbolType(TSymbol symbol, System.Web.Razor.Tokenizer.Symbols.KnownSymbolType type) { throw null; }
        public virtual bool IsNewLine(TSymbol symbol) { throw null; }
        public virtual bool IsTransition(TSymbol symbol) { throw null; }
        public virtual bool IsUnknown(TSymbol symbol) { throw null; }
        public virtual bool IsWhiteSpace(TSymbol symbol) { throw null; }
        public virtual bool KnowsSymbolType(System.Web.Razor.Tokenizer.Symbols.KnownSymbolType type) { throw null; }
        public virtual System.Tuple<TSymbol, TSymbol> SplitSymbol(TSymbol symbol, int splitAt, TSymbolType leftType) { throw null; }
        public virtual System.Collections.Generic.IEnumerable<TSymbol> TokenizeString(string content) { throw null; }
        public virtual System.Collections.Generic.IEnumerable<TSymbol> TokenizeString(System.Web.Razor.Text.SourceLocation start, string input) { throw null; }
    }
    public abstract partial class ParserBase
    {
        protected ParserBase() { }
        public virtual System.Web.Razor.Parser.ParserContext Context { get { throw null; } set { } }
        public virtual bool IsMarkupParser { get { throw null; } }
        protected abstract System.Web.Razor.Parser.ParserBase OtherParser { get; }
        public abstract void BuildSpan(System.Web.Razor.Parser.SyntaxTree.SpanBuilder span, System.Web.Razor.Text.SourceLocation start, string content);
        public abstract void ParseBlock();
        public virtual void ParseDocument() { }
        public virtual void ParseSection(System.Tuple<string, string> nestingSequences, bool caseSensitive) { }
    }
    public partial class ParserContext
    {
        public ParserContext(System.Web.Razor.Text.ITextDocument source, System.Web.Razor.Parser.ParserBase codeParser, System.Web.Razor.Parser.ParserBase markupParser, System.Web.Razor.Parser.ParserBase activeParser) { }
        public System.Web.Razor.Parser.ParserBase ActiveParser { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        public System.Web.Razor.Parser.ParserBase CodeParser { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        public System.Web.Razor.Parser.SyntaxTree.BlockBuilder CurrentBlock { get { throw null; } }
        public char CurrentCharacter { get { throw null; } }
        public bool DesignTimeMode { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public bool EndOfFile { get { throw null; } }
        public System.Collections.Generic.IList<System.Web.Razor.Parser.SyntaxTree.RazorError> Errors { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        public System.Web.Razor.Parser.SyntaxTree.AcceptedCharacters LastAcceptedCharacters { get { throw null; } }
        public System.Web.Razor.Parser.SyntaxTree.Span LastSpan { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        public System.Web.Razor.Parser.ParserBase MarkupParser { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        public System.Web.Razor.Text.TextDocumentReader Source { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public bool WhiteSpaceIsSignificantToAncestorBlock { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public void AddSpan(System.Web.Razor.Parser.SyntaxTree.Span span) { }
        public System.Web.Razor.ParserResults CompleteParse() { throw null; }
        public void EndBlock() { }
        public bool IsWithin(System.Web.Razor.Parser.SyntaxTree.BlockType type) { throw null; }
        public void OnError(System.Web.Razor.Text.SourceLocation location, string message) { }
        public void OnError(System.Web.Razor.Text.SourceLocation location, string message, params object[] args) { }
        public System.IDisposable StartBlock() { throw null; }
        public System.IDisposable StartBlock(System.Web.Razor.Parser.SyntaxTree.BlockType blockType) { throw null; }
        public void SwitchActiveParser() { }
    }
    public static partial class ParserHelpers
    {
        public static bool IsCombining(char value) { throw null; }
        public static bool IsConnecting(char value) { throw null; }
        public static bool IsDecimalDigit(char value) { throw null; }
        public static bool IsEmailPart(char character) { throw null; }
        public static bool IsFormatting(char value) { throw null; }
        public static bool IsHexDigit(char value) { throw null; }
        public static bool IsIdentifier(string value) { throw null; }
        public static bool IsIdentifier(string value, bool requireIdentifierStart) { throw null; }
        public static bool IsIdentifierPart(char value) { throw null; }
        public static bool IsIdentifierStart(char value) { throw null; }
        public static bool IsLetter(char value) { throw null; }
        public static bool IsLetterOrDecimalDigit(char value) { throw null; }
        public static bool IsNewLine(char value) { throw null; }
        public static bool IsNewLine(string value) { throw null; }
        public static bool IsTerminatingCharToken(char value) { throw null; }
        public static bool IsTerminatingQuotedStringToken(char value) { throw null; }
        public static bool IsWhitespace(char value) { throw null; }
        public static bool IsWhitespaceOrNewLine(char value) { throw null; }
        public static string SanitizeClassName(string inputName) { throw null; }
    }
    public abstract partial class ParserVisitor
    {
        protected ParserVisitor() { }
        public System.Nullable<System.Threading.CancellationToken> CancelToken { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public virtual void OnComplete() { }
        public virtual void ThrowIfCanceled() { }
        public virtual void VisitBlock(System.Web.Razor.Parser.SyntaxTree.Block block) { }
        public virtual void VisitEndBlock(System.Web.Razor.Parser.SyntaxTree.Block block) { }
        public virtual void VisitError(System.Web.Razor.Parser.SyntaxTree.RazorError err) { }
        public virtual void VisitSpan(System.Web.Razor.Parser.SyntaxTree.Span span) { }
        public virtual void VisitStartBlock(System.Web.Razor.Parser.SyntaxTree.Block block) { }
    }
    public static partial class ParserVisitorExtensions
    {
        public static void Visit(this System.Web.Razor.Parser.ParserVisitor self, System.Web.Razor.ParserResults result) { }
    }
    public partial class RazorParser
    {
        public RazorParser(System.Web.Razor.Parser.ParserBase codeParser, System.Web.Razor.Parser.ParserBase markupParser) { }
        public bool DesignTimeMode { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public virtual System.Threading.Tasks.Task CreateParseTask(System.IO.TextReader input, System.Action<System.Web.Razor.Parser.SyntaxTree.Span> spanCallback, System.Action<System.Web.Razor.Parser.SyntaxTree.RazorError> errorCallback) { throw null; }
        public virtual System.Threading.Tasks.Task CreateParseTask(System.IO.TextReader input, System.Action<System.Web.Razor.Parser.SyntaxTree.Span> spanCallback, System.Action<System.Web.Razor.Parser.SyntaxTree.RazorError> errorCallback, System.Threading.CancellationToken cancelToken) { throw null; }
        public virtual System.Threading.Tasks.Task CreateParseTask(System.IO.TextReader input, System.Action<System.Web.Razor.Parser.SyntaxTree.Span> spanCallback, System.Action<System.Web.Razor.Parser.SyntaxTree.RazorError> errorCallback, System.Threading.SynchronizationContext context) { throw null; }
        public virtual System.Threading.Tasks.Task CreateParseTask(System.IO.TextReader input, System.Action<System.Web.Razor.Parser.SyntaxTree.Span> spanCallback, System.Action<System.Web.Razor.Parser.SyntaxTree.RazorError> errorCallback, System.Threading.SynchronizationContext context, System.Threading.CancellationToken cancelToken) { throw null; }
        public virtual System.Threading.Tasks.Task CreateParseTask(System.IO.TextReader input, System.Web.Razor.Parser.ParserVisitor consumer) { throw null; }
        public virtual System.Web.Razor.ParserResults Parse(System.IO.TextReader input) { throw null; }
        public virtual void Parse(System.IO.TextReader input, System.Web.Razor.Parser.ParserVisitor visitor) { }
        public virtual System.Web.Razor.ParserResults Parse(System.Web.Razor.Text.ITextDocument input) { throw null; }
        [System.ObsoleteAttribute("Lookahead-based readers have been deprecated, use overrides which accept a TextReader or ITextDocument instead")]
        public virtual System.Web.Razor.ParserResults Parse(System.Web.Razor.Text.LookaheadTextReader input) { throw null; }
        [System.ObsoleteAttribute("Lookahead-based readers have been deprecated, use overrides which accept a TextReader or ITextDocument instead")]
        public virtual void Parse(System.Web.Razor.Text.LookaheadTextReader input, System.Web.Razor.Parser.ParserVisitor visitor) { }
    }
    public static partial class SyntaxConstants
    {
        public static readonly string EndCommentSequence;
        public static readonly string StartCommentSequence;
        public static readonly string TextTagName;
        public static readonly char TransitionCharacter;
        public static readonly string TransitionString;
        public static partial class CSharp
        {
            public static readonly string ClassKeyword;
            public static readonly string ElseIfKeyword;
            public static readonly string FunctionsKeyword;
            public static readonly string HelperKeyword;
            public static readonly string InheritsKeyword;
            public static readonly string LayoutKeyword;
            public static readonly string NamespaceKeyword;
            public static readonly string SectionKeyword;
            public static readonly string SessionStateKeyword;
            public static readonly int UsingKeywordLength;
        }
        public static partial class VB
        {
            public static readonly string CodeKeyword;
            public static readonly string EndCodeKeyword;
            public static readonly string EndFunctionsKeyword;
            public static readonly string EndHelperKeyword;
            public static readonly string EndKeyword;
            public static readonly string EndSectionKeyword;
            public static readonly string ExplicitKeyword;
            public static readonly string FunctionsKeyword;
            public static readonly string HelperKeyword;
            public static readonly int ImportsKeywordLength;
            public static readonly string LayoutKeyword;
            public static readonly string OffKeyword;
            public static readonly string SectionKeyword;
            public static readonly string SelectCaseKeyword;
            public static readonly string SessionStateKeyword;
            public static readonly string StrictKeyword;
        }
    }
    public abstract partial class TokenizerBackedParser<TTokenizer, TSymbol, TSymbolType> : System.Web.Razor.Parser.ParserBase where TTokenizer : System.Web.Razor.Tokenizer.Tokenizer<TSymbol, TSymbolType> where TSymbol : System.Web.Razor.Tokenizer.Symbols.SymbolBase<TSymbolType>
    {
        protected TokenizerBackedParser() { }
        protected System.Web.Razor.Text.SourceLocation CurrentLocation { get { throw null; } }
        protected TSymbol CurrentSymbol { get { throw null; } }
        protected bool EndOfFile { get { throw null; } }
        protected abstract System.Web.Razor.Parser.LanguageCharacteristics<TTokenizer, TSymbol, TSymbolType> Language { get; }
        protected TSymbol PreviousSymbol { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        protected System.Web.Razor.Parser.SyntaxTree.SpanBuilder Span { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        protected System.Action<System.Web.Razor.Parser.SyntaxTree.SpanBuilder> SpanConfig { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        protected System.Web.Razor.Tokenizer.TokenizerView<TTokenizer, TSymbol, TSymbolType> Tokenizer { get { throw null; } }
        protected internal void Accept(System.Collections.Generic.IEnumerable<TSymbol> symbols) { }
        protected internal void Accept(TSymbol symbol) { }
        protected internal bool AcceptAll(params TSymbolType[] types) { throw null; }
        protected internal bool AcceptAndMoveNext() { throw null; }
        protected TSymbol AcceptSingleWhiteSpaceCharacter() { throw null; }
        protected internal void AcceptUntil(TSymbolType type) { }
        protected internal void AcceptUntil(TSymbolType type1, TSymbolType type2) { }
        protected internal void AcceptUntil(TSymbolType type1, TSymbolType type2, TSymbolType type3) { }
        protected internal void AcceptUntil(params TSymbolType[] types) { }
        protected internal void AcceptWhile(System.Func<TSymbol, bool> condition) { }
        protected internal void AcceptWhile(TSymbolType type) { }
        protected internal void AcceptWhile(TSymbolType type1, TSymbolType type2) { }
        protected internal void AcceptWhile(TSymbolType type1, TSymbolType type2, TSymbolType type3) { }
        protected internal void AcceptWhile(params TSymbolType[] types) { }
        protected TSymbol AcceptWhiteSpaceInLines() { throw null; }
        protected internal void AddMarkerSymbolIfNecessary() { }
        protected internal void AddMarkerSymbolIfNecessary(System.Web.Razor.Text.SourceLocation location) { }
        protected internal bool At(TSymbolType type) { throw null; }
        protected bool AtIdentifier(bool allowKeywords) { throw null; }
        protected internal bool Balance(System.Web.Razor.Parser.BalancingModes mode) { throw null; }
        protected internal bool Balance(System.Web.Razor.Parser.BalancingModes mode, TSymbolType left, TSymbolType right, System.Web.Razor.Text.SourceLocation start) { throw null; }
        public override void BuildSpan(System.Web.Razor.Parser.SyntaxTree.SpanBuilder span, System.Web.Razor.Text.SourceLocation start, string content) { }
        protected void ConfigureSpan(System.Action<System.Web.Razor.Parser.SyntaxTree.SpanBuilder, System.Action<System.Web.Razor.Parser.SyntaxTree.SpanBuilder>> config) { }
        protected void ConfigureSpan(System.Action<System.Web.Razor.Parser.SyntaxTree.SpanBuilder> config) { }
        protected bool EnsureCurrent() { throw null; }
        protected internal void Expected(System.Web.Razor.Tokenizer.Symbols.KnownSymbolType type) { }
        protected internal void Expected(params TSymbolType[] types) { }
        protected virtual void HandleEmbeddedTransition() { }
        protected void Initialize(System.Web.Razor.Parser.SyntaxTree.SpanBuilder span) { }
        protected virtual bool IsAtEmbeddedTransition(bool allowTemplatesAndComments, bool allowTransitions) { throw null; }
        protected internal bool NextIs(System.Func<TSymbol, bool> condition) { throw null; }
        protected internal bool NextIs(TSymbolType type) { throw null; }
        protected internal bool NextIs(params TSymbolType[] types) { throw null; }
        protected internal bool NextToken() { throw null; }
        protected internal bool Optional(System.Web.Razor.Tokenizer.Symbols.KnownSymbolType type) { throw null; }
        protected internal bool Optional(TSymbolType type) { throw null; }
        protected internal void Output(System.Web.Razor.Parser.SyntaxTree.AcceptedCharacters accepts) { }
        protected internal void Output(System.Web.Razor.Parser.SyntaxTree.SpanKind kind) { }
        protected internal void Output(System.Web.Razor.Parser.SyntaxTree.SpanKind kind, System.Web.Razor.Parser.SyntaxTree.AcceptedCharacters accepts) { }
        protected virtual void OutputSpanBeforeRazorComment() { }
        protected System.IDisposable PushSpanConfig() { throw null; }
        protected System.IDisposable PushSpanConfig(System.Action<System.Web.Razor.Parser.SyntaxTree.SpanBuilder, System.Action<System.Web.Razor.Parser.SyntaxTree.SpanBuilder>> newConfig) { throw null; }
        protected System.IDisposable PushSpanConfig(System.Action<System.Web.Razor.Parser.SyntaxTree.SpanBuilder> newConfig) { throw null; }
        protected internal void PutBack(System.Collections.Generic.IEnumerable<TSymbol> symbols) { }
        protected internal void PutBack(TSymbol symbol) { }
        protected internal void PutCurrentBack() { }
        protected void RazorComment() { }
        protected internal System.Collections.Generic.IEnumerable<TSymbol> ReadWhile(System.Func<TSymbol, bool> condition) { throw null; }
        protected internal bool Required(TSymbolType expected, bool errorIfNotFound, string errorBase) { throw null; }
        protected internal bool Was(TSymbolType type) { throw null; }
    }
    public partial class VBCodeParser : System.Web.Razor.Parser.TokenizerBackedParser<System.Web.Razor.Tokenizer.VBTokenizer, System.Web.Razor.Tokenizer.Symbols.VBSymbol, System.Web.Razor.Tokenizer.Symbols.VBSymbolType>
    {
        public VBCodeParser() { }
        protected internal System.Collections.Generic.ISet<string> Keywords { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        protected override System.Web.Razor.Parser.LanguageCharacteristics<System.Web.Razor.Tokenizer.VBTokenizer, System.Web.Razor.Tokenizer.Symbols.VBSymbol, System.Web.Razor.Tokenizer.Symbols.VBSymbolType> Language { get { throw null; } }
        protected override System.Web.Razor.Parser.ParserBase OtherParser { get { throw null; } }
        protected void AcceptVBSpaces() { }
        [System.Diagnostics.ConditionalAttribute("DEBUG")]
        protected void Assert(System.Web.Razor.Tokenizer.Symbols.VBKeyword keyword) { }
        [System.Diagnostics.ConditionalAttribute("DEBUG")]
        protected void AssertDirective(string directive) { }
        protected bool At(string directive) { throw null; }
        protected bool At(System.Web.Razor.Tokenizer.Symbols.VBKeyword keyword) { throw null; }
        protected virtual System.Func<bool> EndTerminatedDirective(string directive, System.Web.Razor.Parser.SyntaxTree.BlockType blockType, System.Web.Razor.Generator.SpanCodeGenerator codeGenerator, bool allowMarkup) { throw null; }
        protected virtual bool EndTerminatedDirectiveBody(string directive, System.Web.Razor.Text.SourceLocation blockStart, bool allowAllTransitions) { throw null; }
        protected virtual System.Func<bool> EndTerminatedStatement(System.Web.Razor.Tokenizer.Symbols.VBKeyword keyword, bool supportsExit, bool supportsContinue) { throw null; }
        protected virtual System.Func<bool> EndTerminatedStatement(System.Web.Razor.Tokenizer.Symbols.VBKeyword keyword, bool supportsExit, bool supportsContinue, string blockName) { throw null; }
        protected override void HandleEmbeddedTransition() { }
        protected void HandleEmbeddedTransition(System.Web.Razor.Tokenizer.Symbols.VBSymbol lastWhiteSpace) { }
        protected void HandleExitOrContinue(System.Web.Razor.Tokenizer.Symbols.VBKeyword keyword) { }
        protected void HandleTransition(System.Web.Razor.Tokenizer.Symbols.VBSymbol lastWhiteSpace) { }
        protected virtual bool HelperDirective() { throw null; }
        protected virtual bool ImportsStatement() { throw null; }
        protected virtual bool InheritsStatement() { throw null; }
        protected override bool IsAtEmbeddedTransition(bool allowTemplatesAndComments, bool allowTransitions) { throw null; }
        public bool IsDirectiveDefined(string directive) { throw null; }
        protected virtual System.Func<bool> KeywordTerminatedStatement(System.Web.Razor.Tokenizer.Symbols.VBKeyword start, System.Web.Razor.Tokenizer.Symbols.VBKeyword terminator, bool supportsExit, bool supportsContinue) { throw null; }
        protected virtual bool LayoutDirective() { throw null; }
        protected void MapDirective(string directive, System.Func<bool> action) { }
        protected void MapKeyword(System.Web.Razor.Tokenizer.Symbols.VBKeyword keyword, System.Func<bool> action) { }
        protected void NestedBlock() { }
        protected bool Optional(System.Web.Razor.Tokenizer.Symbols.VBKeyword keyword) { throw null; }
        protected virtual bool OptionStatement() { throw null; }
        protected void OtherParserBlock() { }
        protected void OtherParserBlock(string startSequence, string endSequence) { }
        protected override void OutputSpanBeforeRazorComment() { }
        public override void ParseBlock() { }
        protected System.Collections.Generic.IEnumerable<System.Web.Razor.Tokenizer.Symbols.VBSymbol> ReadVBSpaces() { throw null; }
        protected bool Required(System.Web.Razor.Tokenizer.Symbols.VBSymbolType expected, string errorBase) { throw null; }
        protected bool ReservedWord() { throw null; }
        protected virtual bool SectionDirective() { throw null; }
        protected virtual bool SessionStateDirective() { throw null; }
    }
    public partial class VBLanguageCharacteristics : System.Web.Razor.Parser.LanguageCharacteristics<System.Web.Razor.Tokenizer.VBTokenizer, System.Web.Razor.Tokenizer.Symbols.VBSymbol, System.Web.Razor.Tokenizer.Symbols.VBSymbolType>
    {
        internal VBLanguageCharacteristics() { }
        public static System.Web.Razor.Parser.VBLanguageCharacteristics Instance { get { throw null; } }
        public override System.Web.Razor.Tokenizer.Symbols.VBSymbol CreateMarkerSymbol(System.Web.Razor.Text.SourceLocation location) { throw null; }
        protected override System.Web.Razor.Tokenizer.Symbols.VBSymbol CreateSymbol(System.Web.Razor.Text.SourceLocation location, string content, System.Web.Razor.Tokenizer.Symbols.VBSymbolType type, System.Collections.Generic.IEnumerable<System.Web.Razor.Parser.SyntaxTree.RazorError> errors) { throw null; }
        public override System.Web.Razor.Tokenizer.VBTokenizer CreateTokenizer(System.Web.Razor.Text.ITextDocument source) { throw null; }
        public override System.Web.Razor.Tokenizer.Symbols.VBSymbolType FlipBracket(System.Web.Razor.Tokenizer.Symbols.VBSymbolType bracket) { throw null; }
        public override System.Web.Razor.Tokenizer.Symbols.VBSymbolType GetKnownSymbolType(System.Web.Razor.Tokenizer.Symbols.KnownSymbolType type) { throw null; }
        public override string GetSample(System.Web.Razor.Tokenizer.Symbols.VBSymbolType type) { throw null; }
    }
}
namespace System.Web.Razor.Parser.SyntaxTree
{
    [System.FlagsAttribute]
    public enum AcceptedCharacters
    {
        AllWhiteSpace = 3,
        Any = 7,
        AnyExceptNewline = 6,
        NewLine = 1,
        None = 0,
        NonWhiteSpace = 4,
        WhiteSpace = 2,
    }
    public partial class AutoCompleteEditHandler : System.Web.Razor.Editor.SpanEditHandler
    {
        public AutoCompleteEditHandler(System.Func<string, System.Collections.Generic.IEnumerable<System.Web.Razor.Tokenizer.Symbols.ISymbol>> tokenizer) : base (default(System.Func<string, System.Collections.Generic.IEnumerable<System.Web.Razor.Tokenizer.Symbols.ISymbol>>)) { }
        public AutoCompleteEditHandler(System.Func<string, System.Collections.Generic.IEnumerable<System.Web.Razor.Tokenizer.Symbols.ISymbol>> tokenizer, System.Web.Razor.Parser.SyntaxTree.AcceptedCharacters accepted) : base (default(System.Func<string, System.Collections.Generic.IEnumerable<System.Web.Razor.Tokenizer.Symbols.ISymbol>>)) { }
        public bool AutoCompleteAtEndOfSpan { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public string AutoCompleteString { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        protected override System.Web.Razor.PartialParseResult CanAcceptChange(System.Web.Razor.Parser.SyntaxTree.Span target, System.Web.Razor.Text.TextChange normalizedChange) { throw null; }
        public override bool Equals(object obj) { throw null; }
        public override int GetHashCode() { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class Block : System.Web.Razor.Parser.SyntaxTree.SyntaxTreeNode
    {
        public Block(System.Web.Razor.Parser.SyntaxTree.BlockBuilder source) { }
        public System.Collections.Generic.IEnumerable<System.Web.Razor.Parser.SyntaxTree.SyntaxTreeNode> Children { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        public System.Web.Razor.Generator.IBlockCodeGenerator CodeGenerator { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        public override bool IsBlock { get { throw null; } }
        public override int Length { get { throw null; } }
        public string Name { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        public override System.Web.Razor.Text.SourceLocation Start { get { throw null; } }
        public System.Web.Razor.Parser.SyntaxTree.BlockType Type { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        public override void Accept(System.Web.Razor.Parser.ParserVisitor visitor) { }
        public override bool Equals(object obj) { throw null; }
        public override bool EquivalentTo(System.Web.Razor.Parser.SyntaxTree.SyntaxTreeNode node) { throw null; }
        public System.Web.Razor.Parser.SyntaxTree.Span FindFirstDescendentSpan() { throw null; }
        public System.Web.Razor.Parser.SyntaxTree.Span FindLastDescendentSpan() { throw null; }
        public System.Collections.Generic.IEnumerable<System.Web.Razor.Parser.SyntaxTree.Span> Flatten() { throw null; }
        public override int GetHashCode() { throw null; }
        public System.Web.Razor.Parser.SyntaxTree.Span LocateOwner(System.Web.Razor.Text.TextChange change) { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class BlockBuilder
    {
        public BlockBuilder() { }
        public BlockBuilder(System.Web.Razor.Parser.SyntaxTree.Block original) { }
        public System.Collections.Generic.IList<System.Web.Razor.Parser.SyntaxTree.SyntaxTreeNode> Children { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        public System.Web.Razor.Generator.IBlockCodeGenerator CodeGenerator { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public string Name { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public System.Nullable<System.Web.Razor.Parser.SyntaxTree.BlockType> Type { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public System.Web.Razor.Parser.SyntaxTree.Block Build() { throw null; }
        public void Reset() { }
    }
    public enum BlockType
    {
        Comment = 8,
        Directive = 1,
        Expression = 3,
        Functions = 2,
        Helper = 4,
        Markup = 5,
        Section = 6,
        Statement = 0,
        Template = 7,
    }
    public partial class RazorError : System.IEquatable<System.Web.Razor.Parser.SyntaxTree.RazorError>
    {
        public RazorError(string message, int absoluteIndex, int lineIndex, int columnIndex) { }
        public RazorError(string message, int absoluteIndex, int lineIndex, int columnIndex, int length) { }
        public RazorError(string message, System.Web.Razor.Text.SourceLocation location) { }
        public RazorError(string message, System.Web.Razor.Text.SourceLocation location, int length) { }
        public int Length { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        public System.Web.Razor.Text.SourceLocation Location { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        public string Message { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        public override bool Equals(object obj) { throw null; }
        public bool Equals(System.Web.Razor.Parser.SyntaxTree.RazorError other) { throw null; }
        public override int GetHashCode() { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class Span : System.Web.Razor.Parser.SyntaxTree.SyntaxTreeNode
    {
        public Span(System.Web.Razor.Parser.SyntaxTree.SpanBuilder builder) { }
        public System.Web.Razor.Generator.ISpanCodeGenerator CodeGenerator { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]protected set { } }
        public string Content { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        public System.Web.Razor.Editor.SpanEditHandler EditHandler { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]protected set { } }
        public override bool IsBlock { get { throw null; } }
        public System.Web.Razor.Parser.SyntaxTree.SpanKind Kind { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]protected set { } }
        public override int Length { get { throw null; } }
        public System.Web.Razor.Parser.SyntaxTree.Span Next { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]protected internal set { } }
        public System.Web.Razor.Parser.SyntaxTree.Span Previous { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]protected internal set { } }
        public override System.Web.Razor.Text.SourceLocation Start { get { throw null; } }
        public System.Collections.Generic.IEnumerable<System.Web.Razor.Tokenizer.Symbols.ISymbol> Symbols { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]protected set { } }
        public override void Accept(System.Web.Razor.Parser.ParserVisitor visitor) { }
        public void Change(System.Action<System.Web.Razor.Parser.SyntaxTree.SpanBuilder> changes) { }
        public void ChangeStart(System.Web.Razor.Text.SourceLocation newStart) { }
        public override bool Equals(object obj) { throw null; }
        public override bool EquivalentTo(System.Web.Razor.Parser.SyntaxTree.SyntaxTreeNode node) { throw null; }
        public override int GetHashCode() { throw null; }
        public void ReplaceWith(System.Web.Razor.Parser.SyntaxTree.SpanBuilder builder) { }
        public override string ToString() { throw null; }
    }
    public partial class SpanBuilder
    {
        public SpanBuilder() { }
        public SpanBuilder(System.Web.Razor.Parser.SyntaxTree.Span original) { }
        public System.Web.Razor.Generator.ISpanCodeGenerator CodeGenerator { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public System.Web.Razor.Editor.SpanEditHandler EditHandler { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public System.Web.Razor.Parser.SyntaxTree.SpanKind Kind { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public System.Web.Razor.Text.SourceLocation Start { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public System.Collections.ObjectModel.ReadOnlyCollection<System.Web.Razor.Tokenizer.Symbols.ISymbol> Symbols { get { throw null; } }
        public void Accept(System.Web.Razor.Tokenizer.Symbols.ISymbol symbol) { }
        public System.Web.Razor.Parser.SyntaxTree.Span Build() { throw null; }
        public void ClearSymbols() { }
        public void Reset() { }
    }
    public enum SpanKind
    {
        Code = 3,
        Comment = 2,
        Markup = 4,
        MetaCode = 1,
        Transition = 0,
    }
    public abstract partial class SyntaxTreeNode
    {
        protected SyntaxTreeNode() { }
        public abstract bool IsBlock { get; }
        public abstract int Length { get; }
        public System.Web.Razor.Parser.SyntaxTree.Block Parent { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        public abstract System.Web.Razor.Text.SourceLocation Start { get; }
        public abstract void Accept(System.Web.Razor.Parser.ParserVisitor visitor);
        public abstract bool EquivalentTo(System.Web.Razor.Parser.SyntaxTree.SyntaxTreeNode node);
    }
}
namespace System.Web.Razor.Text
{
    public partial class BufferingTextReader : System.Web.Razor.Text.LookaheadTextReader
    {
        public BufferingTextReader(System.IO.TextReader source) { }
        protected virtual int CurrentCharacter { get { throw null; } }
        public override System.Web.Razor.Text.SourceLocation CurrentLocation { get { throw null; } }
        public override System.IDisposable BeginLookahead() { throw null; }
        public override void CancelBacktrack() { }
        protected override void Dispose(bool disposing) { }
        protected bool ExpandBuffer() { throw null; }
        protected virtual void NextCharacter() { }
        public override int Peek() { throw null; }
        public override int Read() { throw null; }
    }
    public partial interface ITextBuffer
    {
        int Length { get; }
        int Position { get; set; }
        int Peek();
        int Read();
    }
    public partial interface ITextDocument : System.Web.Razor.Text.ITextBuffer
    {
        System.Web.Razor.Text.SourceLocation Location { get; }
    }
    [System.Diagnostics.DebuggerDisplayAttribute("({Location})\"{Value}\"")]
    public partial class LocationTagged<T> : System.IFormattable
    {
        public LocationTagged(T value, int offset, int line, int col) { }
        public LocationTagged(T value, System.Web.Razor.Text.SourceLocation location) { }
        public System.Web.Razor.Text.SourceLocation Location { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        public T Value { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        public override bool Equals(object obj) { throw null; }
        public override int GetHashCode() { throw null; }
        public static bool operator ==(System.Web.Razor.Text.LocationTagged<T> left, System.Web.Razor.Text.LocationTagged<T> right) { throw null; }
        public static implicit operator T (System.Web.Razor.Text.LocationTagged<T> value) { throw null; }
        public static bool operator !=(System.Web.Razor.Text.LocationTagged<T> left, System.Web.Razor.Text.LocationTagged<T> right) { throw null; }
        public override string ToString() { throw null; }
        public string ToString(string format, System.IFormatProvider formatProvider) { throw null; }
    }
    public abstract partial class LookaheadTextReader : System.IO.TextReader
    {
        protected LookaheadTextReader() { }
        public abstract System.Web.Razor.Text.SourceLocation CurrentLocation { get; }
        public abstract System.IDisposable BeginLookahead();
        public abstract void CancelBacktrack();
    }
    public partial class LookaheadToken : System.IDisposable
    {
        public LookaheadToken(System.Action cancelAction) { }
        public void Accept() { }
        public void Dispose() { }
        protected virtual void Dispose(bool disposing) { }
    }
    public partial class SeekableTextReader : System.IO.TextReader, System.Web.Razor.Text.ITextBuffer, System.Web.Razor.Text.ITextDocument
    {
        public SeekableTextReader(System.IO.TextReader source) { }
        public SeekableTextReader(string content) { }
        public SeekableTextReader(System.Web.Razor.Text.ITextBuffer buffer) { }
        public int Length { get { throw null; } }
        public System.Web.Razor.Text.SourceLocation Location { get { throw null; } }
        public int Position { get { throw null; } set { } }
        public override int Peek() { throw null; }
        public override int Read() { throw null; }
    }
    [System.SerializableAttribute]
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public partial struct SourceLocation : System.IComparable<System.Web.Razor.Text.SourceLocation>, System.IEquatable<System.Web.Razor.Text.SourceLocation>
    {
        public static readonly System.Web.Razor.Text.SourceLocation Undefined;
        public static readonly System.Web.Razor.Text.SourceLocation Zero;
        public SourceLocation(int absoluteIndex, int lineIndex, int characterIndex) { throw null;}
        public int AbsoluteIndex { get { throw null; } }
        public int CharacterIndex { get { throw null; } }
        public int LineIndex { get { throw null; } }
        public static System.Web.Razor.Text.SourceLocation Add(System.Web.Razor.Text.SourceLocation left, System.Web.Razor.Text.SourceLocation right) { throw null; }
        public static System.Web.Razor.Text.SourceLocation Advance(System.Web.Razor.Text.SourceLocation left, string text) { throw null; }
        public int CompareTo(System.Web.Razor.Text.SourceLocation other) { throw null; }
        public override bool Equals(object obj) { throw null; }
        public bool Equals(System.Web.Razor.Text.SourceLocation other) { throw null; }
        public override int GetHashCode() { throw null; }
        public static System.Web.Razor.Text.SourceLocation operator +(System.Web.Razor.Text.SourceLocation left, System.Web.Razor.Text.SourceLocation right) { throw null; }
        public static bool operator ==(System.Web.Razor.Text.SourceLocation left, System.Web.Razor.Text.SourceLocation right) { throw null; }
        public static bool operator >(System.Web.Razor.Text.SourceLocation left, System.Web.Razor.Text.SourceLocation right) { throw null; }
        public static bool operator !=(System.Web.Razor.Text.SourceLocation left, System.Web.Razor.Text.SourceLocation right) { throw null; }
        public static bool operator <(System.Web.Razor.Text.SourceLocation left, System.Web.Razor.Text.SourceLocation right) { throw null; }
        public static System.Web.Razor.Text.SourceLocation operator -(System.Web.Razor.Text.SourceLocation left, System.Web.Razor.Text.SourceLocation right) { throw null; }
        public static System.Web.Razor.Text.SourceLocation Subtract(System.Web.Razor.Text.SourceLocation left, System.Web.Razor.Text.SourceLocation right) { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class SourceLocationTracker
    {
        public SourceLocationTracker() { }
        public SourceLocationTracker(System.Web.Razor.Text.SourceLocation currentLocation) { }
        public System.Web.Razor.Text.SourceLocation CurrentLocation { get { throw null; } set { } }
        public static System.Web.Razor.Text.SourceLocation CalculateNewLocation(System.Web.Razor.Text.SourceLocation lastPosition, string newContent) { throw null; }
        public void UpdateLocation(char characterRead, char nextCharacter) { }
        public System.Web.Razor.Text.SourceLocationTracker UpdateLocation(string content) { throw null; }
    }
    public partial class TextBufferReader : System.Web.Razor.Text.LookaheadTextReader
    {
        public TextBufferReader(System.Web.Razor.Text.ITextBuffer buffer) { }
        public override System.Web.Razor.Text.SourceLocation CurrentLocation { get { throw null; } }
        public override System.IDisposable BeginLookahead() { throw null; }
        public override void CancelBacktrack() { }
        protected override void Dispose(bool disposing) { }
        public override int Peek() { throw null; }
        public override int Read() { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public partial struct TextChange
    {
        public TextChange(int oldPosition, int oldLength, System.Web.Razor.Text.ITextBuffer oldBuffer, int newPosition, int newLength, System.Web.Razor.Text.ITextBuffer newBuffer) { throw null;}
        public bool IsDelete { get { throw null; } }
        public bool IsInsert { get { throw null; } }
        public bool IsReplace { get { throw null; } }
        public System.Web.Razor.Text.ITextBuffer NewBuffer { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        public int NewLength { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        public int NewPosition { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        public string NewText { get { throw null; } }
        public System.Web.Razor.Text.ITextBuffer OldBuffer { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        public int OldLength { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        public int OldPosition { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        public string OldText { get { throw null; } }
        public string ApplyChange(string content, int changeOffset) { throw null; }
        public string ApplyChange(System.Web.Razor.Parser.SyntaxTree.Span span) { throw null; }
        public override bool Equals(object obj) { throw null; }
        public override int GetHashCode() { throw null; }
        public System.Web.Razor.Text.TextChange Normalize() { throw null; }
        public static bool operator ==(System.Web.Razor.Text.TextChange left, System.Web.Razor.Text.TextChange right) { throw null; }
        public static bool operator !=(System.Web.Razor.Text.TextChange left, System.Web.Razor.Text.TextChange right) { throw null; }
        public override string ToString() { throw null; }
    }
    public enum TextChangeType
    {
        Insert = 0,
        Remove = 1,
    }
    public partial class TextDocumentReader : System.IO.TextReader, System.Web.Razor.Text.ITextBuffer, System.Web.Razor.Text.ITextDocument
    {
        public TextDocumentReader(System.Web.Razor.Text.ITextDocument source) { }
        public int Length { get { throw null; } }
        public System.Web.Razor.Text.SourceLocation Location { get { throw null; } }
        public int Position { get { throw null; } set { } }
        public override int Peek() { throw null; }
        public override int Read() { throw null; }
    }
}
namespace System.Web.Razor.Tokenizer
{
    public static partial class CSharpHelpers
    {
        public static bool IsIdentifierPart(char character) { throw null; }
        public static bool IsIdentifierStart(char character) { throw null; }
        public static bool IsRealLiteralSuffix(char character) { throw null; }
    }
    public partial class CSharpTokenizer : System.Web.Razor.Tokenizer.Tokenizer<System.Web.Razor.Tokenizer.Symbols.CSharpSymbol, System.Web.Razor.Tokenizer.Symbols.CSharpSymbolType>
    {
        public CSharpTokenizer(System.Web.Razor.Text.ITextDocument source) : base (default(System.Web.Razor.Text.ITextDocument)) { }
        public override System.Web.Razor.Tokenizer.Symbols.CSharpSymbolType RazorCommentStarType { get { throw null; } }
        public override System.Web.Razor.Tokenizer.Symbols.CSharpSymbolType RazorCommentTransitionType { get { throw null; } }
        public override System.Web.Razor.Tokenizer.Symbols.CSharpSymbolType RazorCommentType { get { throw null; } }
        protected override System.Web.Razor.StateMachine<System.Web.Razor.Tokenizer.Symbols.CSharpSymbol>.State StartState { get { throw null; } }
        protected override System.Web.Razor.Tokenizer.Symbols.CSharpSymbol CreateSymbol(System.Web.Razor.Text.SourceLocation start, string content, System.Web.Razor.Tokenizer.Symbols.CSharpSymbolType type, System.Collections.Generic.IEnumerable<System.Web.Razor.Parser.SyntaxTree.RazorError> errors) { throw null; }
    }
    public partial class HtmlTokenizer : System.Web.Razor.Tokenizer.Tokenizer<System.Web.Razor.Tokenizer.Symbols.HtmlSymbol, System.Web.Razor.Tokenizer.Symbols.HtmlSymbolType>
    {
        public HtmlTokenizer(System.Web.Razor.Text.ITextDocument source) : base (default(System.Web.Razor.Text.ITextDocument)) { }
        public override System.Web.Razor.Tokenizer.Symbols.HtmlSymbolType RazorCommentStarType { get { throw null; } }
        public override System.Web.Razor.Tokenizer.Symbols.HtmlSymbolType RazorCommentTransitionType { get { throw null; } }
        public override System.Web.Razor.Tokenizer.Symbols.HtmlSymbolType RazorCommentType { get { throw null; } }
        protected override System.Web.Razor.StateMachine<System.Web.Razor.Tokenizer.Symbols.HtmlSymbol>.State StartState { get { throw null; } }
        protected override System.Web.Razor.Tokenizer.Symbols.HtmlSymbol CreateSymbol(System.Web.Razor.Text.SourceLocation start, string content, System.Web.Razor.Tokenizer.Symbols.HtmlSymbolType type, System.Collections.Generic.IEnumerable<System.Web.Razor.Parser.SyntaxTree.RazorError> errors) { throw null; }
    }
    public partial interface ITokenizer
    {
        System.Web.Razor.Tokenizer.Symbols.ISymbol NextSymbol();
    }
    public partial class TokenizerView<TTokenizer, TSymbol, TSymbolType> where TTokenizer : System.Web.Razor.Tokenizer.Tokenizer<TSymbol, TSymbolType> where TSymbol : System.Web.Razor.Tokenizer.Symbols.SymbolBase<TSymbolType>
    {
        public TokenizerView(TTokenizer tokenizer) { }
        public TSymbol Current { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        public bool EndOfFile { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        public System.Web.Razor.Text.ITextDocument Source { get { throw null; } }
        public TTokenizer Tokenizer { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        public bool Next() { throw null; }
        public void PutBack(TSymbol symbol) { }
    }
    public abstract partial class Tokenizer<TSymbol, TSymbolType> : System.Web.Razor.StateMachine<TSymbol>, System.Web.Razor.Tokenizer.ITokenizer where TSymbol : System.Web.Razor.Tokenizer.Symbols.SymbolBase<TSymbolType>
    {
        protected Tokenizer(System.Web.Razor.Text.ITextDocument source) { }
        protected System.Text.StringBuilder Buffer { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        protected char CurrentCharacter { get { throw null; } }
        protected System.Collections.Generic.IList<System.Web.Razor.Parser.SyntaxTree.RazorError> CurrentErrors { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        protected System.Web.Razor.Text.SourceLocation CurrentLocation { get { throw null; } }
        protected System.Web.Razor.Text.SourceLocation CurrentStart { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        protected bool EndOfFile { get { throw null; } }
        protected bool HaveContent { get { throw null; } }
        public abstract TSymbolType RazorCommentStarType { get; }
        public abstract TSymbolType RazorCommentTransitionType { get; }
        public abstract TSymbolType RazorCommentType { get; }
        public System.Web.Razor.Text.TextDocumentReader Source { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        protected System.Web.Razor.StateMachine<TSymbol>.StateResult AfterRazorCommentTransition() { throw null; }
        protected bool At(string expected, bool caseSensitive) { throw null; }
        protected System.Func<char, bool> CharOrWhiteSpace(char character) { throw null; }
        protected abstract TSymbol CreateSymbol(System.Web.Razor.Text.SourceLocation start, string content, TSymbolType type, System.Collections.Generic.IEnumerable<System.Web.Razor.Parser.SyntaxTree.RazorError> errors);
        protected TSymbol EndSymbol(System.Web.Razor.Text.SourceLocation start, TSymbolType type) { throw null; }
        protected TSymbol EndSymbol(TSymbolType type) { throw null; }
        protected void MoveNext() { }
        public virtual TSymbol NextSymbol() { throw null; }
        protected char Peek() { throw null; }
        protected System.Web.Razor.StateMachine<TSymbol>.StateResult RazorCommentBody() { throw null; }
        public void Reset() { }
        protected void ResumeSymbol(TSymbol previous) { }
        protected TSymbol Single(TSymbolType type) { throw null; }
        protected void StartSymbol() { }
        System.Web.Razor.Tokenizer.Symbols.ISymbol System.Web.Razor.Tokenizer.ITokenizer.NextSymbol() { throw null; }
        protected bool TakeAll(string expected, bool caseSensitive) { throw null; }
        protected void TakeCurrent() { }
        protected bool TakeString(string input, bool caseSensitive) { throw null; }
        protected bool TakeUntil(System.Func<char, bool> predicate) { throw null; }
    }
    public static partial class VBHelpers
    {
        public static bool IsDoubleQuote(char character) { throw null; }
        public static bool IsOctalDigit(char character) { throw null; }
        public static bool IsSingleQuote(char character) { throw null; }
    }
    public partial class VBTokenizer : System.Web.Razor.Tokenizer.Tokenizer<System.Web.Razor.Tokenizer.Symbols.VBSymbol, System.Web.Razor.Tokenizer.Symbols.VBSymbolType>
    {
        public VBTokenizer(System.Web.Razor.Text.ITextDocument source) : base (default(System.Web.Razor.Text.ITextDocument)) { }
        public override System.Web.Razor.Tokenizer.Symbols.VBSymbolType RazorCommentStarType { get { throw null; } }
        public override System.Web.Razor.Tokenizer.Symbols.VBSymbolType RazorCommentTransitionType { get { throw null; } }
        public override System.Web.Razor.Tokenizer.Symbols.VBSymbolType RazorCommentType { get { throw null; } }
        protected override System.Web.Razor.StateMachine<System.Web.Razor.Tokenizer.Symbols.VBSymbol>.State StartState { get { throw null; } }
        protected override System.Web.Razor.Tokenizer.Symbols.VBSymbol CreateSymbol(System.Web.Razor.Text.SourceLocation start, string content, System.Web.Razor.Tokenizer.Symbols.VBSymbolType type, System.Collections.Generic.IEnumerable<System.Web.Razor.Parser.SyntaxTree.RazorError> errors) { throw null; }
    }
}
namespace System.Web.Razor.Tokenizer.Symbols
{
    public enum CSharpKeyword
    {
        Abstract = 0,
        As = 16,
        Base = 39,
        Bool = 59,
        Break = 74,
        Byte = 1,
        Case = 24,
        Catch = 40,
        Char = 60,
        Checked = 75,
        Class = 2,
        Const = 25,
        Continue = 41,
        Decimal = 54,
        Default = 61,
        Delegate = 3,
        Do = 17,
        Double = 42,
        Else = 55,
        Enum = 65,
        Event = 4,
        Explicit = 26,
        Extern = 35,
        False = 49,
        Finally = 66,
        Fixed = 5,
        Float = 27,
        For = 43,
        Foreach = 62,
        Goto = 71,
        If = 6,
        Implicit = 31,
        In = 44,
        Int = 67,
        Interface = 73,
        Internal = 7,
        Is = 18,
        Lock = 45,
        Long = 63,
        Namespace = 76,
        New = 8,
        Null = 28,
        Object = 46,
        Operator = 56,
        Out = 68,
        Override = 9,
        Params = 19,
        Private = 32,
        Protected = 47,
        Public = 50,
        Readonly = 10,
        Ref = 20,
        Return = 36,
        Sbyte = 51,
        Sealed = 69,
        Short = 11,
        Sizeof = 29,
        Stackalloc = 37,
        Static = 48,
        String = 57,
        Struct = 12,
        Switch = 21,
        This = 33,
        Throw = 52,
        True = 70,
        Try = 13,
        Typeof = 30,
        Uint = 38,
        Ulong = 58,
        Unchecked = 72,
        Unsafe = 14,
        Ushort = 22,
        Using = 34,
        Virtual = 53,
        Void = 64,
        Volatile = 15,
        While = 23,
    }
    public partial class CSharpSymbol : System.Web.Razor.Tokenizer.Symbols.SymbolBase<System.Web.Razor.Tokenizer.Symbols.CSharpSymbolType>
    {
        public CSharpSymbol(int offset, int line, int column, string content, System.Web.Razor.Tokenizer.Symbols.CSharpSymbolType type) : base (default(System.Web.Razor.Text.SourceLocation), default(string), default(System.Web.Razor.Tokenizer.Symbols.CSharpSymbolType), default(System.Collections.Generic.IEnumerable<System.Web.Razor.Parser.SyntaxTree.RazorError>)) { }
        public CSharpSymbol(int offset, int line, int column, string content, System.Web.Razor.Tokenizer.Symbols.CSharpSymbolType type, System.Collections.Generic.IEnumerable<System.Web.Razor.Parser.SyntaxTree.RazorError> errors) : base (default(System.Web.Razor.Text.SourceLocation), default(string), default(System.Web.Razor.Tokenizer.Symbols.CSharpSymbolType), default(System.Collections.Generic.IEnumerable<System.Web.Razor.Parser.SyntaxTree.RazorError>)) { }
        public CSharpSymbol(System.Web.Razor.Text.SourceLocation start, string content, System.Web.Razor.Tokenizer.Symbols.CSharpSymbolType type) : base (default(System.Web.Razor.Text.SourceLocation), default(string), default(System.Web.Razor.Tokenizer.Symbols.CSharpSymbolType), default(System.Collections.Generic.IEnumerable<System.Web.Razor.Parser.SyntaxTree.RazorError>)) { }
        public CSharpSymbol(System.Web.Razor.Text.SourceLocation start, string content, System.Web.Razor.Tokenizer.Symbols.CSharpSymbolType type, System.Collections.Generic.IEnumerable<System.Web.Razor.Parser.SyntaxTree.RazorError> errors) : base (default(System.Web.Razor.Text.SourceLocation), default(string), default(System.Web.Razor.Tokenizer.Symbols.CSharpSymbolType), default(System.Collections.Generic.IEnumerable<System.Web.Razor.Parser.SyntaxTree.RazorError>)) { }
        public System.Nullable<bool> EscapedIdentifier { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public System.Nullable<System.Web.Razor.Tokenizer.Symbols.CSharpKeyword> Keyword { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public override bool Equals(object obj) { throw null; }
        public override int GetHashCode() { throw null; }
    }
    public enum CSharpSymbolType
    {
        And = 19,
        AndAssign = 18,
        Arrow = 10,
        Assign = 51,
        CharacterLiteral = 8,
        Colon = 30,
        Comma = 25,
        Comment = 6,
        Decrement = 12,
        DivideAssign = 28,
        Dot = 26,
        DoubleAnd = 20,
        DoubleColon = 29,
        DoubleOr = 40,
        Equals = 52,
        GreaterThan = 53,
        GreaterThanEqual = 54,
        Hash = 57,
        Identifier = 1,
        Increment = 46,
        IntegerLiteral = 3,
        Keyword = 2,
        LeftBrace = 38,
        LeftBracket = 35,
        LeftParenthesis = 21,
        LeftShift = 49,
        LeftShiftAssign = 50,
        LessThan = 47,
        LessThanEqual = 48,
        Minus = 11,
        MinusAssign = 13,
        Modulo = 16,
        ModuloAssign = 17,
        MultiplyAssign = 24,
        NewLine = 4,
        Not = 15,
        NotEqual = 14,
        NullCoalesce = 33,
        Or = 41,
        OrAssign = 39,
        Plus = 44,
        PlusAssign = 45,
        QuestionMark = 32,
        RazorComment = 61,
        RazorCommentStar = 60,
        RazorCommentTransition = 59,
        RealLiteral = 7,
        RightBrace = 42,
        RightBracket = 34,
        RightParenthesis = 22,
        RightShift = 55,
        RightShiftAssign = 56,
        Semicolon = 31,
        Slash = 27,
        Star = 23,
        StringLiteral = 9,
        Tilde = 43,
        Transition = 58,
        Unknown = 0,
        WhiteSpace = 5,
        Xor = 37,
        XorAssign = 36,
    }
    public partial class HtmlSymbol : System.Web.Razor.Tokenizer.Symbols.SymbolBase<System.Web.Razor.Tokenizer.Symbols.HtmlSymbolType>
    {
        public HtmlSymbol(int offset, int line, int column, string content, System.Web.Razor.Tokenizer.Symbols.HtmlSymbolType type) : base (default(System.Web.Razor.Text.SourceLocation), default(string), default(System.Web.Razor.Tokenizer.Symbols.HtmlSymbolType), default(System.Collections.Generic.IEnumerable<System.Web.Razor.Parser.SyntaxTree.RazorError>)) { }
        public HtmlSymbol(int offset, int line, int column, string content, System.Web.Razor.Tokenizer.Symbols.HtmlSymbolType type, System.Collections.Generic.IEnumerable<System.Web.Razor.Parser.SyntaxTree.RazorError> errors) : base (default(System.Web.Razor.Text.SourceLocation), default(string), default(System.Web.Razor.Tokenizer.Symbols.HtmlSymbolType), default(System.Collections.Generic.IEnumerable<System.Web.Razor.Parser.SyntaxTree.RazorError>)) { }
        public HtmlSymbol(System.Web.Razor.Text.SourceLocation start, string content, System.Web.Razor.Tokenizer.Symbols.HtmlSymbolType type) : base (default(System.Web.Razor.Text.SourceLocation), default(string), default(System.Web.Razor.Tokenizer.Symbols.HtmlSymbolType), default(System.Collections.Generic.IEnumerable<System.Web.Razor.Parser.SyntaxTree.RazorError>)) { }
        public HtmlSymbol(System.Web.Razor.Text.SourceLocation start, string content, System.Web.Razor.Tokenizer.Symbols.HtmlSymbolType type, System.Collections.Generic.IEnumerable<System.Web.Razor.Parser.SyntaxTree.RazorError> errors) : base (default(System.Web.Razor.Text.SourceLocation), default(string), default(System.Web.Razor.Tokenizer.Symbols.HtmlSymbolType), default(System.Collections.Generic.IEnumerable<System.Web.Razor.Parser.SyntaxTree.RazorError>)) { }
    }
    public enum HtmlSymbolType
    {
        Bang = 5,
        CloseAngle = 10,
        Colon = 16,
        DoubleHyphen = 8,
        DoubleQuote = 13,
        Equals = 12,
        LeftBracket = 9,
        NewLine = 3,
        OpenAngle = 4,
        QuestionMark = 7,
        RazorComment = 17,
        RazorCommentStar = 18,
        RazorCommentTransition = 19,
        RightBracket = 11,
        SingleQuote = 14,
        Solidus = 6,
        Text = 1,
        Transition = 15,
        Unknown = 0,
        WhiteSpace = 2,
    }
    public partial interface ISymbol
    {
        string Content { get; }
        System.Web.Razor.Text.SourceLocation Start { get; }
        void ChangeStart(System.Web.Razor.Text.SourceLocation newStart);
        void OffsetStart(System.Web.Razor.Text.SourceLocation documentStart);
    }
    public enum KnownSymbolType
    {
        CommentBody = 8,
        CommentStar = 7,
        CommentStart = 6,
        Identifier = 2,
        Keyword = 3,
        NewLine = 1,
        Transition = 4,
        Unknown = 5,
        WhiteSpace = 0,
    }
    public abstract partial class SymbolBase<TType> : System.Web.Razor.Tokenizer.Symbols.ISymbol
    {
        protected SymbolBase(System.Web.Razor.Text.SourceLocation start, string content, TType type, System.Collections.Generic.IEnumerable<System.Web.Razor.Parser.SyntaxTree.RazorError> errors) { }
        public string Content { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        public System.Collections.Generic.IEnumerable<System.Web.Razor.Parser.SyntaxTree.RazorError> Errors { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        public System.Web.Razor.Text.SourceLocation Start { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        public TType Type { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        public void ChangeStart(System.Web.Razor.Text.SourceLocation newStart) { }
        public override bool Equals(object obj) { throw null; }
        public override int GetHashCode() { throw null; }
        public void OffsetStart(System.Web.Razor.Text.SourceLocation documentStart) { }
        public override string ToString() { throw null; }
    }
    public static partial class SymbolExtensions
    {
        public static System.Web.Razor.Text.LocationTagged<string> GetContent(this System.Collections.Generic.IEnumerable<System.Web.Razor.Tokenizer.Symbols.ISymbol> symbols, System.Web.Razor.Text.SourceLocation spanStart) { throw null; }
        public static System.Web.Razor.Text.LocationTagged<string> GetContent(this System.Web.Razor.Parser.SyntaxTree.SpanBuilder span) { throw null; }
        public static System.Web.Razor.Text.LocationTagged<string> GetContent(this System.Web.Razor.Parser.SyntaxTree.SpanBuilder span, System.Func<System.Collections.Generic.IEnumerable<System.Web.Razor.Tokenizer.Symbols.ISymbol>, System.Collections.Generic.IEnumerable<System.Web.Razor.Tokenizer.Symbols.ISymbol>> filter) { throw null; }
        public static System.Web.Razor.Text.LocationTagged<string> GetContent(this System.Web.Razor.Tokenizer.Symbols.ISymbol symbol) { throw null; }
    }
    public enum VBKeyword
    {
        AddHandler = 0,
        AddressOf = 23,
        Alias = 46,
        And = 69,
        AndAlso = 1,
        As = 24,
        Boolean = 47,
        ByRef = 70,
        Byte = 2,
        ByVal = 25,
        Call = 48,
        Case = 71,
        Catch = 3,
        CBool = 26,
        CByte = 49,
        CChar = 72,
        CDate = 4,
        CDbl = 27,
        CDec = 50,
        Char = 73,
        CInt = 5,
        Class = 28,
        CLng = 51,
        CObj = 74,
        Const = 6,
        Continue = 29,
        CSByte = 52,
        CShort = 75,
        CSng = 7,
        CStr = 30,
        CType = 53,
        CUInt = 76,
        CULng = 8,
        CUShort = 31,
        Date = 54,
        Decimal = 77,
        Declare = 9,
        Default = 32,
        Delegate = 55,
        Dim = 78,
        DirectCast = 10,
        Do = 33,
        Double = 56,
        Each = 79,
        Else = 11,
        ElseIf = 34,
        End = 57,
        EndIf = 80,
        Enum = 12,
        Erase = 35,
        Error = 58,
        Event = 81,
        Exit = 13,
        False = 36,
        Finally = 59,
        For = 82,
        Friend = 14,
        Function = 37,
        Get = 60,
        GetType = 83,
        GetXmlNamespace = 15,
        Global = 38,
        GoSub = 61,
        GoTo = 84,
        Handles = 16,
        If = 39,
        Implements = 62,
        Imports = 85,
        In = 17,
        Inherits = 40,
        Integer = 63,
        Interface = 86,
        Is = 18,
        IsNot = 41,
        Let = 64,
        Lib = 87,
        Like = 19,
        Long = 42,
        Loop = 65,
        Me = 88,
        Mod = 20,
        Module = 43,
        MustInherit = 66,
        MustOverride = 89,
        MyBase = 21,
        MyClass = 44,
        Namespace = 67,
        Narrowing = 90,
        New = 22,
        Next = 45,
        Not = 68,
        Nothing = 91,
        NotInheritable = 92,
        NotOverridable = 107,
        Object = 122,
        Of = 137,
        On = 93,
        Operator = 108,
        Option = 123,
        Optional = 138,
        Or = 94,
        OrElse = 109,
        Overloads = 124,
        Overridable = 139,
        Overrides = 95,
        ParamArray = 110,
        Partial = 125,
        Private = 140,
        Property = 96,
        Protected = 111,
        Public = 126,
        RaiseEvent = 141,
        ReadOnly = 97,
        ReDim = 112,
        Rem = 127,
        RemoveHandler = 142,
        Resume = 98,
        Return = 113,
        SByte = 128,
        Select = 143,
        Set = 99,
        Shadows = 114,
        Shared = 129,
        Short = 144,
        Single = 100,
        Static = 115,
        Step = 130,
        Stop = 145,
        String = 101,
        Structure = 116,
        Sub = 131,
        SyncLock = 146,
        Then = 102,
        Throw = 117,
        To = 132,
        True = 147,
        Try = 103,
        TryCast = 118,
        TypeOf = 133,
        UInteger = 148,
        ULong = 104,
        UShort = 119,
        Using = 134,
        Variant = 149,
        Wend = 105,
        When = 120,
        While = 135,
        Widening = 150,
        With = 106,
        WithEvents = 121,
        WriteOnly = 136,
        Xor = 151,
    }
    public partial class VBSymbol : System.Web.Razor.Tokenizer.Symbols.SymbolBase<System.Web.Razor.Tokenizer.Symbols.VBSymbolType>
    {
        public VBSymbol(int offset, int line, int column, string content, System.Web.Razor.Tokenizer.Symbols.VBSymbolType type) : base (default(System.Web.Razor.Text.SourceLocation), default(string), default(System.Web.Razor.Tokenizer.Symbols.VBSymbolType), default(System.Collections.Generic.IEnumerable<System.Web.Razor.Parser.SyntaxTree.RazorError>)) { }
        public VBSymbol(int offset, int line, int column, string content, System.Web.Razor.Tokenizer.Symbols.VBSymbolType type, System.Collections.Generic.IEnumerable<System.Web.Razor.Parser.SyntaxTree.RazorError> errors) : base (default(System.Web.Razor.Text.SourceLocation), default(string), default(System.Web.Razor.Tokenizer.Symbols.VBSymbolType), default(System.Collections.Generic.IEnumerable<System.Web.Razor.Parser.SyntaxTree.RazorError>)) { }
        public VBSymbol(System.Web.Razor.Text.SourceLocation start, string content, System.Web.Razor.Tokenizer.Symbols.VBSymbolType type) : base (default(System.Web.Razor.Text.SourceLocation), default(string), default(System.Web.Razor.Tokenizer.Symbols.VBSymbolType), default(System.Collections.Generic.IEnumerable<System.Web.Razor.Parser.SyntaxTree.RazorError>)) { }
        public VBSymbol(System.Web.Razor.Text.SourceLocation start, string content, System.Web.Razor.Tokenizer.Symbols.VBSymbolType type, System.Collections.Generic.IEnumerable<System.Web.Razor.Parser.SyntaxTree.RazorError> errors) : base (default(System.Web.Razor.Text.SourceLocation), default(string), default(System.Web.Razor.Tokenizer.Symbols.VBSymbolType), default(System.Collections.Generic.IEnumerable<System.Web.Razor.Parser.SyntaxTree.RazorError>)) { }
        public System.Nullable<System.Web.Razor.Tokenizer.Symbols.VBKeyword> Keyword { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public override bool Equals(object obj) { throw null; }
        public override int GetHashCode() { throw null; }
        public static string GetSample(System.Web.Razor.Tokenizer.Symbols.VBSymbolType type) { throw null; }
    }
    public enum VBSymbolType
    {
        Add = 25,
        Bang = 17,
        CharacterLiteral = 10,
        Colon = 20,
        Comma = 18,
        Comment = 4,
        Concatenation = 21,
        DateLiteral = 11,
        Divide = 26,
        Dollar = 34,
        Dot = 19,
        Equal = 31,
        Exponentiation = 28,
        FloatingPointLiteral = 8,
        GreaterThan = 30,
        Hash = 16,
        Identifier = 5,
        IntegerDivide = 27,
        IntegerLiteral = 7,
        Keyword = 6,
        LeftBrace = 14,
        LeftBracket = 33,
        LeftParenthesis = 12,
        LessThan = 29,
        LineContinuation = 3,
        Multiply = 24,
        NewLine = 2,
        QuestionMark = 22,
        RazorComment = 38,
        RazorCommentStar = 37,
        RazorCommentTransition = 36,
        RightBrace = 13,
        RightBracket = 32,
        RightParenthesis = 15,
        StringLiteral = 9,
        Subtract = 23,
        Transition = 35,
        Unknown = 0,
        WhiteSpace = 1,
    }
}
