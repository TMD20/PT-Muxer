// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

[assembly:System.Reflection.AssemblyVersionAttribute("4.0.0.0")]
[assembly:System.CLSCompliantAttribute(true)]
[assembly:System.Diagnostics.DebuggableAttribute(System.Diagnostics.DebuggableAttribute.DebuggingModes.IgnoreSymbolStoreSequencePoints)]
[assembly:System.Reflection.AssemblyDescriptionAttribute("Commons.Xml.Relaxng.dll")]
[assembly:System.Reflection.AssemblyFileVersionAttribute("0.0.0.1")]
[assembly:System.Runtime.CompilerServices.CompilationRelaxationsAttribute(8)]
[assembly:System.Runtime.CompilerServices.RuntimeCompatibilityAttribute(WrapNonExceptionThrows=true)]
[assembly:System.Runtime.InteropServices.ComVisibleAttribute(false)]
namespace Commons.Xml
{
    public partial class XmlDefaultReader : System.Xml.XmlReader, System.Xml.IXmlLineInfo
    {
        public XmlDefaultReader(System.Xml.XmlReader reader) { }
        public override int AttributeCount { get { throw null; } }
        public override string BaseURI { get { throw null; } }
        public override int Depth { get { throw null; } }
        public override bool EOF { get { throw null; } }
        public override bool HasValue { get { throw null; } }
        public override bool IsDefault { get { throw null; } }
        public override bool IsEmptyElement { get { throw null; } }
        public override string this[int i] { get { throw null; } }
        public override string this[string name] { get { throw null; } }
        public override string this[string localName, string namespaceURI] { get { throw null; } }
        public int LineNumber { get { throw null; } }
        public int LinePosition { get { throw null; } }
        public override string LocalName { get { throw null; } }
        public override string Name { get { throw null; } }
        public override string NamespaceURI { get { throw null; } }
        public override System.Xml.XmlNameTable NameTable { get { throw null; } }
        public override System.Xml.XmlNodeType NodeType { get { throw null; } }
        public override string Prefix { get { throw null; } }
        public override char QuoteChar { get { throw null; } }
        public System.Xml.XmlReader Reader { get { throw null; } }
        public override System.Xml.ReadState ReadState { get { throw null; } }
        public override string Value { get { throw null; } }
        public override string XmlLang { get { throw null; } }
        public override System.Xml.XmlSpace XmlSpace { get { throw null; } }
        public override void Close() { }
        public override string GetAttribute(int i) { throw null; }
        public override string GetAttribute(string name) { throw null; }
        public override string GetAttribute(string localName, string namespaceURI) { throw null; }
        public bool HasLineInfo() { throw null; }
        public override string LookupNamespace(string prefix) { throw null; }
        public override void MoveToAttribute(int i) { }
        public override bool MoveToAttribute(string name) { throw null; }
        public override bool MoveToAttribute(string localName, string namespaceURI) { throw null; }
        public override bool MoveToElement() { throw null; }
        public override bool MoveToFirstAttribute() { throw null; }
        public override bool MoveToNextAttribute() { throw null; }
        public override bool Read() { throw null; }
        public override bool ReadAttributeValue() { throw null; }
        public override void ResolveEntity() { }
    }
}
namespace Commons.Xml.Nvdl
{
    public partial class Nvdl
    {
        internal Nvdl() { }
        public const string BuiltInValidationNamespace = "http://purl.oclc.org/dsdl/nvdl/ns/predefinedSchema/1.0";
        public const string InstanceNamespace = "http://purl.oclc.org/dsdl/nvdl/ns/instance/1.0";
        public const string Namespace = "http://purl.oclc.org/dsdl/nvdl/ns/structure/1.0";
    }
    public abstract partial class NvdlAction : Commons.Xml.Nvdl.NvdlAttributable
    {
        protected NvdlAction() { }
    }
    public partial class NvdlActionList : System.Collections.CollectionBase
    {
        public NvdlActionList() { }
        public Commons.Xml.Nvdl.NvdlAction this[int i] { get { throw null; } set { } }
        public void Add(Commons.Xml.Nvdl.NvdlAction item) { }
        public void Remove(Commons.Xml.Nvdl.NvdlAction item) { }
    }
    public partial class NvdlAllow : Commons.Xml.Nvdl.NvdlNoResultAction
    {
        public NvdlAllow() { }
    }
    public partial class NvdlAnyNamespace : Commons.Xml.Nvdl.NvdlRule
    {
        public NvdlAnyNamespace() { }
    }
    public partial class NvdlAttach : Commons.Xml.Nvdl.NvdlResultAction
    {
        public NvdlAttach() { }
        public override Commons.Xml.Nvdl.NvdlResultType ResultType { get { throw null; } }
    }
    public partial class NvdlAttachPlaceholder : Commons.Xml.Nvdl.NvdlResultAction
    {
        public NvdlAttachPlaceholder() { }
        public override Commons.Xml.Nvdl.NvdlResultType ResultType { get { throw null; } }
    }
    public partial class NvdlAttributable : Commons.Xml.Nvdl.NvdlElementBase
    {
        public NvdlAttributable() { }
        public System.Collections.ArrayList Foreign { get { throw null; } }
    }
    public partial class NvdlBuiltInValidationProvider : Commons.Xml.Nvdl.NvdlValidationProvider
    {
        public NvdlBuiltInValidationProvider() { }
        public override Commons.Xml.Nvdl.NvdlValidatorGenerator CreateGenerator(System.Xml.XmlReader reader, Commons.Xml.Nvdl.NvdlConfig config) { throw null; }
    }
    public partial class NvdlCancelAction : Commons.Xml.Nvdl.NvdlAction
    {
        public NvdlCancelAction() { }
    }
    public partial class NvdlCompileException : Commons.Xml.Nvdl.NvdlException
    {
        public NvdlCompileException(string message, System.Exception inner, System.Xml.IXmlLineInfo source) : base (default(string)) { }
        public NvdlCompileException(string message, System.Xml.IXmlLineInfo source) : base (default(string)) { }
    }
    public partial class NvdlConfig
    {
        public NvdlConfig() { }
        public System.Xml.XmlResolver XmlResolver { set { } }
        public void AddProvider(Commons.Xml.Nvdl.NvdlValidationProvider provider) { }
        public Commons.Xml.Nvdl.NvdlValidatorGenerator GetGenerator(Commons.Xml.Nvdl.NvdlValidate validate, string inheritSchemaType) { throw null; }
    }
    public partial class NvdlContext : Commons.Xml.Nvdl.NvdlAttributable
    {
        public NvdlContext() { }
        public Commons.Xml.Nvdl.NvdlNestedMode NestedMode { get { throw null; } set { } }
        public string Path { get { throw null; } set { } }
        public string UseMode { get { throw null; } set { } }
    }
    public partial class NvdlContextList : System.Collections.CollectionBase
    {
        public NvdlContextList() { }
        public Commons.Xml.Nvdl.NvdlContext this[int i] { get { throw null; } set { } }
        public void Add(Commons.Xml.Nvdl.NvdlContext item) { }
        public void Remove(Commons.Xml.Nvdl.NvdlContext item) { }
    }
    public partial class NvdlElementBase : System.Xml.IXmlLineInfo
    {
        public NvdlElementBase() { }
        public int LineNumber { get { throw null; } set { } }
        public int LinePosition { get { throw null; } set { } }
        public string SourceUri { get { throw null; } set { } }
        public bool HasLineInfo() { throw null; }
    }
    public partial class NvdlException : System.Exception
    {
        public NvdlException(string message) { }
        public NvdlException(string message, System.Exception inner) { }
    }
    public partial class NvdlIncludedMode : Commons.Xml.Nvdl.NvdlModeBase
    {
        public NvdlIncludedMode() { }
        public string Name { get { throw null; } set { } }
    }
    public partial class NvdlInstanceValidationException : Commons.Xml.Nvdl.NvdlException
    {
        public NvdlInstanceValidationException(string message, Commons.Xml.Nvdl.NvdlValidatorGenerator generator, string nvdlLocation) : base (default(string)) { }
        public NvdlInstanceValidationException(string message, System.Exception inner, Commons.Xml.Nvdl.NvdlValidatorGenerator generator, string nvdlLocation) : base (default(string)) { }
    }
    public partial class NvdlMessage : Commons.Xml.Nvdl.NvdlElementBase
    {
        public NvdlMessage() { }
        public System.Collections.ArrayList ForeignAttributes { get { throw null; } }
        public string Text { get { throw null; } set { } }
        public string XmlLang { get { throw null; } set { } }
    }
    public partial class NvdlMessageEventArgs : System.EventArgs
    {
        public NvdlMessageEventArgs(string message) { }
        public string Message { get { throw null; } }
    }
    public delegate void NvdlMessageEventHandler(object o, Commons.Xml.Nvdl.NvdlMessageEventArgs e);
    public partial class NvdlMessageList : System.Collections.CollectionBase
    {
        public NvdlMessageList() { }
        public Commons.Xml.Nvdl.NvdlMessage this[int i] { get { throw null; } set { } }
        public void Add(Commons.Xml.Nvdl.NvdlMessage item) { }
        public void Remove(Commons.Xml.Nvdl.NvdlMessage item) { }
    }
    public partial class NvdlMode : Commons.Xml.Nvdl.NvdlModeBase
    {
        public NvdlMode() { }
        public string Name { get { throw null; } set { } }
    }
    public abstract partial class NvdlModeBase : Commons.Xml.Nvdl.NvdlAttributable
    {
        protected NvdlModeBase() { }
        public Commons.Xml.Nvdl.NvdlModeList IncludedModes { get { throw null; } }
        public Commons.Xml.Nvdl.NvdlRuleList Rules { get { throw null; } }
    }
    public partial class NvdlModeList : System.Collections.CollectionBase
    {
        public NvdlModeList() { }
        public Commons.Xml.Nvdl.NvdlModeBase this[int i] { get { throw null; } set { } }
        public void Add(Commons.Xml.Nvdl.NvdlModeBase item) { }
        public void Remove(Commons.Xml.Nvdl.NvdlModeBase item) { }
    }
    public partial class NvdlModeUsage
    {
        public NvdlModeUsage() { }
        public Commons.Xml.Nvdl.NvdlContextList Contexts { get { throw null; } }
        public Commons.Xml.Nvdl.NvdlNestedMode NestedMode { get { throw null; } set { } }
        public string UseMode { get { throw null; } set { } }
    }
    public partial class NvdlNamespace : Commons.Xml.Nvdl.NvdlRule
    {
        public NvdlNamespace() { }
        public string NS { get { throw null; } set { } }
        public string Wildcard { get { throw null; } set { } }
    }
    public partial class NvdlNestedMode : Commons.Xml.Nvdl.NvdlModeBase
    {
        public NvdlNestedMode() { }
    }
    public abstract partial class NvdlNoCancelAction : Commons.Xml.Nvdl.NvdlAction
    {
        protected NvdlNoCancelAction() { }
        public Commons.Xml.Nvdl.NvdlMessageList Messages { get { throw null; } }
        public Commons.Xml.Nvdl.NvdlModeUsage ModeUsage { get { throw null; } set { } }
        public string SimpleMessage { get { throw null; } set { } }
    }
    public abstract partial class NvdlNoResultAction : Commons.Xml.Nvdl.NvdlNoCancelAction
    {
        protected NvdlNoResultAction() { }
    }
    public partial class NvdlOption : Commons.Xml.Nvdl.NvdlAttributable
    {
        public NvdlOption() { }
        public string Arg { get { throw null; } set { } }
        public string MustSupport { get { throw null; } set { } }
        public string Name { get { throw null; } set { } }
    }
    public partial class NvdlOptionList : System.Collections.CollectionBase
    {
        public NvdlOptionList() { }
        public Commons.Xml.Nvdl.NvdlOption this[int i] { get { throw null; } set { } }
        public void Add(Commons.Xml.Nvdl.NvdlOption item) { }
        public void Remove(Commons.Xml.Nvdl.NvdlOption item) { }
    }
    public partial class NvdlReader
    {
        internal NvdlReader() { }
        public static Commons.Xml.Nvdl.NvdlRules Read(System.Xml.XmlReader reader) { throw null; }
    }
    public partial class NvdlReject : Commons.Xml.Nvdl.NvdlNoResultAction
    {
        public NvdlReject() { }
    }
    public partial class NvdlRelaxngValidatorProvider : Commons.Xml.Nvdl.NvdlValidationProvider
    {
        public const string RncMimeType = "application/vnd.oasis-open.relax-ng.rnc";
        public NvdlRelaxngValidatorProvider() { }
        public override Commons.Xml.Nvdl.NvdlValidatorGenerator CreateGenerator(Commons.Xml.Nvdl.NvdlValidate validate, string schemaType, Commons.Xml.Nvdl.NvdlConfig config) { throw null; }
        public override Commons.Xml.Nvdl.NvdlValidatorGenerator CreateGenerator(System.Xml.XmlReader reader, Commons.Xml.Nvdl.NvdlConfig config) { throw null; }
    }
    public abstract partial class NvdlResultAction : Commons.Xml.Nvdl.NvdlNoCancelAction
    {
        protected NvdlResultAction() { }
        public abstract Commons.Xml.Nvdl.NvdlResultType ResultType { get; }
    }
    public enum NvdlResultType
    {
        Attach = 0,
        AttachPlaceholder = 1,
        Unwrap = 2,
    }
    public abstract partial class NvdlRule : Commons.Xml.Nvdl.NvdlAttributable
    {
        protected NvdlRule() { }
        public Commons.Xml.Nvdl.NvdlActionList Actions { get { throw null; } }
        public Commons.Xml.Nvdl.NvdlRuleTarget Match { get { throw null; } set { } }
    }
    public partial class NvdlRuleList : System.Collections.CollectionBase
    {
        public NvdlRuleList() { }
        public Commons.Xml.Nvdl.NvdlRule this[int i] { get { throw null; } set { } }
        public void Add(Commons.Xml.Nvdl.NvdlRule item) { }
        public void Remove(Commons.Xml.Nvdl.NvdlRule item) { }
    }
    public partial class NvdlRules : Commons.Xml.Nvdl.NvdlAttributable
    {
        public NvdlRules() { }
        public Commons.Xml.Nvdl.NvdlModeList Modes { get { throw null; } }
        public Commons.Xml.Nvdl.NvdlRuleList Rules { get { throw null; } }
        public string SchemaType { get { throw null; } set { } }
        public string StartMode { get { throw null; } set { } }
        public Commons.Xml.Nvdl.NvdlTriggerList Triggers { get { throw null; } }
    }
    public enum NvdlRuleTarget
    {
        Attributes = 2,
        Both = 3,
        Elements = 1,
        None = 0,
    }
    public partial class NvdlTrigger : Commons.Xml.Nvdl.NvdlAttributable
    {
        public NvdlTrigger() { }
        public string NameList { get { throw null; } set { } }
        public string NS { get { throw null; } set { } }
    }
    public partial class NvdlTriggerList : System.Collections.CollectionBase
    {
        public NvdlTriggerList() { }
        public Commons.Xml.Nvdl.NvdlTrigger this[int i] { get { throw null; } set { } }
        public void Add(Commons.Xml.Nvdl.NvdlTrigger item) { }
        public void Remove(Commons.Xml.Nvdl.NvdlTrigger item) { }
    }
    public partial class NvdlUnwrap : Commons.Xml.Nvdl.NvdlResultAction
    {
        public NvdlUnwrap() { }
        public override Commons.Xml.Nvdl.NvdlResultType ResultType { get { throw null; } }
    }
    public partial class NvdlValidate : Commons.Xml.Nvdl.NvdlNoResultAction
    {
        public NvdlValidate() { }
        public Commons.Xml.Nvdl.NvdlOptionList Options { get { throw null; } }
        public System.Xml.XmlElement SchemaBody { get { throw null; } set { } }
        public string SchemaType { get { throw null; } set { } }
        public string SchemaUri { get { throw null; } set { } }
    }
    public partial class NvdlValidatingReader : Commons.Xml.XmlDefaultReader
    {
        public NvdlValidatingReader(System.Xml.XmlReader reader, Commons.Xml.Nvdl.NvdlRules rules) : base (default(System.Xml.XmlReader)) { }
        public NvdlValidatingReader(System.Xml.XmlReader reader, Commons.Xml.Nvdl.NvdlRules rules, System.Xml.XmlResolver resolver) : base (default(System.Xml.XmlReader)) { }
        public NvdlValidatingReader(System.Xml.XmlReader reader, Commons.Xml.Nvdl.NvdlRules rules, System.Xml.XmlResolver resolver, Commons.Xml.Nvdl.NvdlConfig config) : base (default(System.Xml.XmlReader)) { }
        public event Commons.Xml.Nvdl.NvdlMessageEventHandler ActionStarted { add { } remove { } }
        public override bool Read() { throw null; }
    }
    public partial class NvdlValidationException : Commons.Xml.Nvdl.NvdlException
    {
        public NvdlValidationException(string message, System.Exception inner, System.Xml.IXmlLineInfo source) : base (default(string)) { }
        public NvdlValidationException(string message, System.Xml.IXmlLineInfo source) : base (default(string)) { }
    }
    public partial class NvdlValidationProvider
    {
        public NvdlValidationProvider() { }
        public Commons.Xml.Nvdl.NvdlConfig Config { get { throw null; } }
        public string SchemaType { get { throw null; } }
        public Commons.Xml.Nvdl.NvdlValidate ValidateAction { get { throw null; } }
        public virtual Commons.Xml.Nvdl.NvdlValidatorGenerator CreateGenerator(Commons.Xml.Nvdl.NvdlValidate validate, string schemaType, Commons.Xml.Nvdl.NvdlConfig config) { throw null; }
        public virtual Commons.Xml.Nvdl.NvdlValidatorGenerator CreateGenerator(System.Xml.XmlReader schema, Commons.Xml.Nvdl.NvdlConfig config) { throw null; }
        public string GetSchemaUri(Commons.Xml.Nvdl.NvdlValidate validate) { throw null; }
    }
    public abstract partial class NvdlValidatorGenerator
    {
        protected NvdlValidatorGenerator() { }
        public abstract bool AddOption(string name, string arg);
        public virtual System.Xml.XmlReader CreateAttributeValidator(System.Xml.XmlReader reader, System.Xml.XmlResolver resolver) { throw null; }
        public abstract System.Xml.XmlReader CreateValidator(System.Xml.XmlReader reader, System.Xml.XmlResolver resolver);
        public virtual bool HandleError(System.Exception ex, System.Xml.XmlReader reader, string nvdlLocation) { throw null; }
    }
    public partial class NvdlXsdValidatorProvider : Commons.Xml.Nvdl.NvdlValidationProvider
    {
        public NvdlXsdValidatorProvider() { }
        public override Commons.Xml.Nvdl.NvdlValidatorGenerator CreateGenerator(System.Xml.XmlReader reader, Commons.Xml.Nvdl.NvdlConfig config) { throw null; }
    }
}
namespace Commons.Xml.Relaxng
{
    public partial interface IGrammarContent
    {
    }
    public partial class RelaxngAnyName : Commons.Xml.Relaxng.RelaxngNameClass
    {
        public RelaxngAnyName() { }
        public Commons.Xml.Relaxng.RelaxngExceptNameClass Except { get { throw null; } set { } }
        public override void Write(System.Xml.XmlWriter writer) { }
    }
    public partial class RelaxngAttribute : Commons.Xml.Relaxng.RelaxngPattern
    {
        public RelaxngAttribute() { }
        public Commons.Xml.Relaxng.RelaxngNameClass NameClass { get { throw null; } set { } }
        public Commons.Xml.Relaxng.RelaxngPattern Pattern { get { throw null; } set { } }
        public override Commons.Xml.Relaxng.RelaxngPatternType PatternType { get { throw null; } }
        public override void Write(System.Xml.XmlWriter writer) { }
    }
    public abstract partial class RelaxngBinaryContentPattern : Commons.Xml.Relaxng.RelaxngPattern
    {
        protected RelaxngBinaryContentPattern() { }
        public Commons.Xml.Relaxng.RelaxngPatternList Patterns { get { throw null; } }
    }
    public partial class RelaxngChoice : Commons.Xml.Relaxng.RelaxngBinaryContentPattern
    {
        public RelaxngChoice() { }
        public override Commons.Xml.Relaxng.RelaxngPatternType PatternType { get { throw null; } }
        public override void Write(System.Xml.XmlWriter writer) { }
    }
    public partial class RelaxngData : Commons.Xml.Relaxng.RelaxngDataSupport
    {
        public RelaxngData() { }
        public Commons.Xml.Relaxng.RelaxngExcept Except { get { throw null; } set { } }
        public Commons.Xml.Relaxng.RelaxngParamList ParamList { get { throw null; } }
        public override Commons.Xml.Relaxng.RelaxngPatternType PatternType { get { throw null; } }
        public override void Write(System.Xml.XmlWriter writer) { }
    }
    public abstract partial class RelaxngDataSupport : Commons.Xml.Relaxng.RelaxngPattern
    {
        protected RelaxngDataSupport() { }
        public string DatatypeLibrary { get { throw null; } set { } }
        public string Type { get { throw null; } set { } }
    }
    public abstract partial class RelaxngDatatype
    {
        protected RelaxngDatatype() { }
        public abstract string Name { get; }
        public abstract string NamespaceURI { get; }
        public virtual bool Compare(object o1, object o2) { throw null; }
        public virtual bool CompareString(string s1, string s2, System.Xml.XmlReader reader) { throw null; }
        public virtual bool IsValid(string text, System.Xml.XmlReader reader) { throw null; }
        public abstract object Parse(string text, System.Xml.XmlReader reader);
    }
    public abstract partial class RelaxngDatatypeProvider
    {
        protected RelaxngDatatypeProvider() { }
        public abstract Commons.Xml.Relaxng.RelaxngDatatype GetDatatype(string name, string ns, Commons.Xml.Relaxng.RelaxngParamList parameters);
    }
    public partial class RelaxngDefine : Commons.Xml.Relaxng.RelaxngElementBase, Commons.Xml.Relaxng.IGrammarContent
    {
        public RelaxngDefine() { }
        public string Combine { get { throw null; } set { } }
        public string Name { get { throw null; } set { } }
        public Commons.Xml.Relaxng.RelaxngPatternList Patterns { get { throw null; } }
        public override void Write(System.Xml.XmlWriter writer) { }
    }
    public partial class RelaxngDiv : Commons.Xml.Relaxng.RelaxngElementBase, Commons.Xml.Relaxng.IGrammarContent
    {
        public RelaxngDiv() { }
        public Commons.Xml.Relaxng.RelaxngGrammarContentList Defines { get { throw null; } }
        public Commons.Xml.Relaxng.RelaxngGrammarContentList Divs { get { throw null; } }
        public Commons.Xml.Relaxng.RelaxngGrammarContentList Includes { get { throw null; } }
        public Commons.Xml.Relaxng.RelaxngGrammarContentList Starts { get { throw null; } }
        public override void Write(System.Xml.XmlWriter writer) { }
    }
    public partial class RelaxngElement : Commons.Xml.Relaxng.RelaxngSingleContentPattern
    {
        public RelaxngElement() { }
        public Commons.Xml.Relaxng.RelaxngNameClass NameClass { get { throw null; } set { } }
        public override Commons.Xml.Relaxng.RelaxngPatternType PatternType { get { throw null; } }
        public override void Write(System.Xml.XmlWriter writer) { }
    }
    public abstract partial class RelaxngElementBase
    {
        protected RelaxngElementBase() { }
        public string BaseUri { get { throw null; } set { } }
        public int LineNumber { get { throw null; } set { } }
        public int LinePosition { get { throw null; } set { } }
        public Commons.Xml.Relaxng.RelaxngPattern ReadExternalResource(Commons.Xml.Relaxng.RelaxngGrammar grammar, System.Uri uri, string nsContext) { throw null; }
        public abstract void Write(System.Xml.XmlWriter writer);
    }
    public partial class RelaxngEmpty : Commons.Xml.Relaxng.RelaxngPattern
    {
        public RelaxngEmpty() { }
        public override Commons.Xml.Relaxng.RelaxngPatternType PatternType { get { throw null; } }
        public override void Write(System.Xml.XmlWriter writer) { }
    }
    public partial class RelaxngExcept : Commons.Xml.Relaxng.RelaxngElementBase
    {
        public RelaxngExcept() { }
        public Commons.Xml.Relaxng.RelaxngPatternList Patterns { get { throw null; } }
        public override void Write(System.Xml.XmlWriter writer) { }
    }
    public partial class RelaxngException : System.Exception
    {
        public RelaxngException() { }
        public RelaxngException(Commons.Xml.Relaxng.RelaxngElementBase source, string message) { }
        public RelaxngException(Commons.Xml.Relaxng.RelaxngElementBase source, string message, System.Exception innerException) { }
        public RelaxngException(string message) { }
        public RelaxngException(string message, System.Exception innerException) { }
    }
    public partial class RelaxngExceptNameClass : Commons.Xml.Relaxng.RelaxngElementBase
    {
        public RelaxngExceptNameClass() { }
        public Commons.Xml.Relaxng.RelaxngNameClassList Names { get { throw null; } }
        public override void Write(System.Xml.XmlWriter writer) { }
    }
    public partial class RelaxngExternalRef : Commons.Xml.Relaxng.RelaxngPattern
    {
        public RelaxngExternalRef() { }
        public string Href { get { throw null; } set { } }
        public string NSContext { get { throw null; } set { } }
        public override Commons.Xml.Relaxng.RelaxngPatternType PatternType { get { throw null; } }
        public override void Write(System.Xml.XmlWriter writer) { }
    }
    public partial class RelaxngGrammar : Commons.Xml.Relaxng.RelaxngPattern
    {
        public static string NamespaceURI;
        public RelaxngGrammar() { }
        public string DefaultNamespace { get { throw null; } set { } }
        public Commons.Xml.Relaxng.RelaxngGrammarContentList Defines { get { throw null; } }
        public Commons.Xml.Relaxng.RelaxngGrammarContentList Divs { get { throw null; } }
        public Commons.Xml.Relaxng.RelaxngGrammarContentList Includes { get { throw null; } }
        public override Commons.Xml.Relaxng.RelaxngPatternType PatternType { get { throw null; } }
        public Commons.Xml.Relaxng.RelaxngGrammarContentList Starts { get { throw null; } }
        public override void Write(System.Xml.XmlWriter writer) { }
    }
    public partial class RelaxngGrammarContentList : System.Collections.CollectionBase
    {
        public RelaxngGrammarContentList() { }
        public Commons.Xml.Relaxng.IGrammarContent this[int i] { get { throw null; } set { } }
        public void Add(Commons.Xml.Relaxng.IGrammarContent p) { }
        public void Insert(int pos, Commons.Xml.Relaxng.IGrammarContent p) { }
        public void Remove(Commons.Xml.Relaxng.IGrammarContent p) { }
    }
    public partial class RelaxngGroup : Commons.Xml.Relaxng.RelaxngBinaryContentPattern
    {
        public RelaxngGroup() { }
        public override Commons.Xml.Relaxng.RelaxngPatternType PatternType { get { throw null; } }
        public override void Write(System.Xml.XmlWriter writer) { }
    }
    public partial class RelaxngInclude : Commons.Xml.Relaxng.RelaxngElementBase, Commons.Xml.Relaxng.IGrammarContent
    {
        public RelaxngInclude() { }
        public Commons.Xml.Relaxng.RelaxngGrammarContentList Defines { get { throw null; } }
        public Commons.Xml.Relaxng.RelaxngGrammarContentList Divs { get { throw null; } }
        public string Href { get { throw null; } set { } }
        public string NSContext { get { throw null; } set { } }
        public Commons.Xml.Relaxng.RelaxngGrammarContentList Starts { get { throw null; } }
        public override void Write(System.Xml.XmlWriter writer) { }
    }
    public partial class RelaxngInterleave : Commons.Xml.Relaxng.RelaxngBinaryContentPattern
    {
        public RelaxngInterleave() { }
        public override Commons.Xml.Relaxng.RelaxngPatternType PatternType { get { throw null; } }
        public override void Write(System.Xml.XmlWriter writer) { }
    }
    public partial class RelaxngList : Commons.Xml.Relaxng.RelaxngSingleContentPattern
    {
        internal RelaxngList() { }
        public override Commons.Xml.Relaxng.RelaxngPatternType PatternType { get { throw null; } }
        public override void Write(System.Xml.XmlWriter writer) { }
    }
    public partial class RelaxngMergedProvider : Commons.Xml.Relaxng.RelaxngDatatypeProvider
    {
        public RelaxngMergedProvider() { }
        public static Commons.Xml.Relaxng.RelaxngMergedProvider DefaultProvider { get { throw null; } }
        public Commons.Xml.Relaxng.RelaxngDatatypeProvider this[string ns] { get { throw null; } set { } }
        public override Commons.Xml.Relaxng.RelaxngDatatype GetDatatype(string name, string ns, Commons.Xml.Relaxng.RelaxngParamList parameters) { throw null; }
    }
    public partial class RelaxngMixed : Commons.Xml.Relaxng.RelaxngSingleContentPattern
    {
        public RelaxngMixed() { }
        public override Commons.Xml.Relaxng.RelaxngPatternType PatternType { get { throw null; } }
        public override void Write(System.Xml.XmlWriter writer) { }
    }
    public partial class RelaxngName : Commons.Xml.Relaxng.RelaxngNameClass
    {
        public RelaxngName() { }
        public RelaxngName(string ncname, string ns) { }
        public string LocalName { get { throw null; } set { } }
        public string Namespace { get { throw null; } set { } }
        public override void Write(System.Xml.XmlWriter writer) { }
    }
    public partial class RelaxngNameChoice : Commons.Xml.Relaxng.RelaxngNameClass
    {
        public RelaxngNameChoice() { }
        public Commons.Xml.Relaxng.RelaxngNameClassList Children { get { throw null; } set { } }
        public override void Write(System.Xml.XmlWriter writer) { }
    }
    public abstract partial class RelaxngNameClass : Commons.Xml.Relaxng.RelaxngElementBase
    {
        protected RelaxngNameClass() { }
    }
    public partial class RelaxngNameClassList : System.Collections.CollectionBase
    {
        public RelaxngNameClassList() { }
        public Commons.Xml.Relaxng.RelaxngNameClass this[int i] { get { throw null; } set { } }
        public void Add(Commons.Xml.Relaxng.RelaxngNameClass p) { }
        public void Insert(int pos, Commons.Xml.Relaxng.RelaxngNameClass p) { }
        public void Remove(Commons.Xml.Relaxng.RelaxngNameClass p) { }
    }
    public partial class RelaxngNotAllowed : Commons.Xml.Relaxng.RelaxngPattern
    {
        public RelaxngNotAllowed() { }
        public override Commons.Xml.Relaxng.RelaxngPatternType PatternType { get { throw null; } }
        public override void Write(System.Xml.XmlWriter writer) { }
    }
    public partial class RelaxngNsName : Commons.Xml.Relaxng.RelaxngNameClass
    {
        public RelaxngNsName() { }
        public Commons.Xml.Relaxng.RelaxngExceptNameClass Except { get { throw null; } set { } }
        public string Namespace { get { throw null; } set { } }
        public override void Write(System.Xml.XmlWriter writer) { }
    }
    public partial class RelaxngOneOrMore : Commons.Xml.Relaxng.RelaxngSingleContentPattern
    {
        public RelaxngOneOrMore() { }
        public override Commons.Xml.Relaxng.RelaxngPatternType PatternType { get { throw null; } }
        public override void Write(System.Xml.XmlWriter writer) { }
    }
    public partial class RelaxngOptional : Commons.Xml.Relaxng.RelaxngSingleContentPattern
    {
        public RelaxngOptional() { }
        public override Commons.Xml.Relaxng.RelaxngPatternType PatternType { get { throw null; } }
        public override void Write(System.Xml.XmlWriter writer) { }
    }
    public partial class RelaxngParam : Commons.Xml.Relaxng.RelaxngElementBase
    {
        public RelaxngParam() { }
        public RelaxngParam(string name, string value) { }
        public string Name { get { throw null; } set { } }
        public string Value { get { throw null; } set { } }
        public override void Write(System.Xml.XmlWriter writer) { }
    }
    public partial class RelaxngParamList : System.Collections.CollectionBase
    {
        public RelaxngParamList() { }
        public Commons.Xml.Relaxng.RelaxngParam this[int i] { get { throw null; } set { } }
        public void Add(Commons.Xml.Relaxng.RelaxngParam p) { }
        public void Insert(int pos, Commons.Xml.Relaxng.RelaxngParam p) { }
        public void Remove(Commons.Xml.Relaxng.RelaxngParam p) { }
    }
    public partial class RelaxngParentRef : Commons.Xml.Relaxng.RelaxngPattern
    {
        public RelaxngParentRef() { }
        public string Name { get { throw null; } set { } }
        public override Commons.Xml.Relaxng.RelaxngPatternType PatternType { get { throw null; } }
        public override void Write(System.Xml.XmlWriter writer) { }
    }
    public abstract partial class RelaxngPattern : Commons.Xml.Relaxng.RelaxngElementBase
    {
        protected RelaxngPattern() { }
        public Commons.Xml.Relaxng.RelaxngDatatypeProvider DataProvider { get { throw null; } set { } }
        public abstract Commons.Xml.Relaxng.RelaxngPatternType PatternType { get; }
        public System.Xml.XmlResolver XmlResolver { set { } }
        public void Compile() { }
        public static Commons.Xml.Relaxng.RelaxngPattern Read(System.Xml.XmlReader xmlReader) { throw null; }
        public static Commons.Xml.Relaxng.RelaxngPattern Read(System.Xml.XmlReader xmlReader, Commons.Xml.Relaxng.RelaxngDatatypeProvider provider) { throw null; }
        public static Commons.Xml.Relaxng.RelaxngPattern Read(System.Xml.XmlReader xmlReader, Commons.Xml.Relaxng.RelaxngDatatypeProvider provider, System.Xml.XmlResolver xmlResolver) { throw null; }
        public void WriteCompact(System.IO.TextWriter writer) { }
        public void WriteCompact(System.IO.TextWriter writer, System.Xml.IXmlNamespaceResolver res) { }
    }
    public partial class RelaxngPatternList : System.Collections.CollectionBase
    {
        public RelaxngPatternList() { }
        public Commons.Xml.Relaxng.RelaxngPattern this[int i] { get { throw null; } set { } }
        public void Add(Commons.Xml.Relaxng.RelaxngPattern p) { }
        public void Insert(int pos, Commons.Xml.Relaxng.RelaxngPattern p) { }
        public void Remove(Commons.Xml.Relaxng.RelaxngPattern p) { }
    }
    public enum RelaxngPatternType
    {
        After = 14,
        Attribute = 12,
        Choice = 4,
        Data = 9,
        DataExcept = 10,
        Element = 13,
        Empty = 1,
        ExternalRef = 21,
        Grammar = 16,
        Group = 6,
        Interleave = 5,
        List = 8,
        Mixed = 18,
        NotAllowed = 2,
        OneOrMore = 7,
        Optional = 19,
        ParentRef = 22,
        Ref = 15,
        Text = 3,
        Value = 11,
        ZeroOrMore = 17,
    }
    public partial class RelaxngReader : Commons.Xml.XmlDefaultReader
    {
        [System.ObsoleteAttribute]
        public static string RelaxngNS;
        public RelaxngReader(System.Xml.XmlReader reader) : base (default(System.Xml.XmlReader)) { }
        public RelaxngReader(System.Xml.XmlReader reader, string ns) : base (default(System.Xml.XmlReader)) { }
        public RelaxngReader(System.Xml.XmlReader reader, string ns, System.Xml.XmlResolver resolver) : base (default(System.Xml.XmlReader)) { }
        public string ContextNamespace { get { throw null; } }
        public string DatatypeLibrary { get { throw null; } }
        public static Commons.Xml.Relaxng.RelaxngPattern GrammarForRelaxng { get { throw null; } }
        public System.Xml.XmlResolver XmlResolver { set { } }
        public override bool Read() { throw null; }
        public Commons.Xml.Relaxng.RelaxngPattern ReadPattern() { throw null; }
        public override string ReadString() { throw null; }
    }
    public partial class RelaxngRef : Commons.Xml.Relaxng.RelaxngPattern
    {
        public RelaxngRef() { }
        public string Name { get { throw null; } set { } }
        public override Commons.Xml.Relaxng.RelaxngPatternType PatternType { get { throw null; } }
        public override void Write(System.Xml.XmlWriter writer) { }
    }
    public abstract partial class RelaxngSingleContentPattern : Commons.Xml.Relaxng.RelaxngPattern
    {
        protected RelaxngSingleContentPattern() { }
        public Commons.Xml.Relaxng.RelaxngPatternList Patterns { get { throw null; } }
    }
    public partial class RelaxngStart : Commons.Xml.Relaxng.RelaxngElementBase, Commons.Xml.Relaxng.IGrammarContent
    {
        public RelaxngStart() { }
        public string Combine { get { throw null; } set { } }
        public Commons.Xml.Relaxng.RelaxngPattern Pattern { get { throw null; } set { } }
        public override void Write(System.Xml.XmlWriter writer) { }
    }
    public partial class RelaxngString : Commons.Xml.Relaxng.RelaxngDatatype
    {
        public RelaxngString() { }
        public override string Name { get { throw null; } }
        public override string NamespaceURI { get { throw null; } }
        public override bool Compare(object o1, object o2) { throw null; }
        public override bool IsValid(string text, System.Xml.XmlReader reader) { throw null; }
        public override object Parse(string text, System.Xml.XmlReader reader) { throw null; }
    }
    public partial class RelaxngText : Commons.Xml.Relaxng.RelaxngPattern
    {
        public RelaxngText() { }
        public override Commons.Xml.Relaxng.RelaxngPatternType PatternType { get { throw null; } }
        public override void Write(System.Xml.XmlWriter writer) { }
    }
    public partial class RelaxngToken : Commons.Xml.Relaxng.RelaxngDatatype
    {
        public RelaxngToken() { }
        public override string Name { get { throw null; } }
        public override string NamespaceURI { get { throw null; } }
        public override bool Compare(object o1, object o2) { throw null; }
        public override bool CompareString(string s1, string s2, System.Xml.XmlReader reader) { throw null; }
        public override bool IsValid(string text, System.Xml.XmlReader reader) { throw null; }
        public override object Parse(string text, System.Xml.XmlReader reader) { throw null; }
    }
    public partial class RelaxngValidatingReader : Commons.Xml.XmlDefaultReader
    {
        public static readonly Commons.Xml.Relaxng.RelaxngValidatingReader.RelaxngValidationEventHandler IgnoreError;
        public RelaxngValidatingReader(System.Xml.XmlReader reader) : base (default(System.Xml.XmlReader)) { }
        public RelaxngValidatingReader(System.Xml.XmlReader reader, Commons.Xml.Relaxng.RelaxngPattern pattern) : base (default(System.Xml.XmlReader)) { }
        public RelaxngValidatingReader(System.Xml.XmlReader reader, System.Xml.XmlReader grammarXml) : base (default(System.Xml.XmlReader)) { }
        public RelaxngValidatingReader(System.Xml.XmlReader reader, System.Xml.XmlReader grammarXml, Commons.Xml.Relaxng.RelaxngDatatypeProvider provider) : base (default(System.Xml.XmlReader)) { }
        public bool ReportDetails { get { throw null; } set { } }
        public bool RoughLabelCheck { get { throw null; } set { } }
        public event Commons.Xml.Relaxng.RelaxngValidatingReader.RelaxngValidationEventHandler InvalidNodeFound { add { } remove { } }
        public object AfterAttribute(object stateObject, string localName, string ns) { throw null; }
        public object AfterCloseStartTag(object stateObject) { throw null; }
        public object AfterEndTag(object stateObject) { throw null; }
        public object AfterOpenStartTag(object stateObject, string localName, string ns) { throw null; }
        public bool Attribute(object stateObject, string localName, string ns) { throw null; }
        public bool CloseStartTag(object stateObject) { throw null; }
        public bool Emptiable(object stateObject) { throw null; }
        public bool EndTag(object stateObject) { throw null; }
        public System.Collections.ICollection GetAttributeLabels(object stateObject) { throw null; }
        public object GetCurrentState() { throw null; }
        public System.Collections.ICollection GetElementLabels(object stateObject) { throw null; }
        public bool OpenStartTag(object stateObject, string localName, string ns) { throw null; }
        public override bool Read() { throw null; }
        public delegate bool RelaxngValidationEventHandler(System.Xml.XmlReader source, string message);
    }
    public partial class RelaxngValue : Commons.Xml.Relaxng.RelaxngDataSupport
    {
        public RelaxngValue() { }
        public override Commons.Xml.Relaxng.RelaxngPatternType PatternType { get { throw null; } }
        public string Value { get { throw null; } set { } }
        public override void Write(System.Xml.XmlWriter writer) { }
    }
    public partial class RelaxngZeroOrMore : Commons.Xml.Relaxng.RelaxngSingleContentPattern
    {
        public RelaxngZeroOrMore() { }
        public override Commons.Xml.Relaxng.RelaxngPatternType PatternType { get { throw null; } }
        public override void Write(System.Xml.XmlWriter writer) { }
    }
}
namespace Commons.Xml.Relaxng.Derivative
{
    public abstract partial class RdpAbstractBinary : Commons.Xml.Relaxng.Derivative.RdpPattern
    {
        public RdpAbstractBinary(Commons.Xml.Relaxng.Derivative.RdpPattern l, Commons.Xml.Relaxng.Derivative.RdpPattern r) { }
        public override Commons.Xml.Relaxng.Derivative.RdpContentType ContentType { get { throw null; } }
        public Commons.Xml.Relaxng.Derivative.RdpPattern LValue { get { throw null; } set { } }
        public Commons.Xml.Relaxng.Derivative.RdpPattern RValue { get { throw null; } set { } }
    }
    public abstract partial class RdpAbstractSingleContent : Commons.Xml.Relaxng.Derivative.RdpPattern
    {
        public RdpAbstractSingleContent(Commons.Xml.Relaxng.Derivative.RdpPattern p) { }
        public Commons.Xml.Relaxng.Derivative.RdpPattern Child { get { throw null; } set { } }
    }
    public partial class RdpAfter : Commons.Xml.Relaxng.Derivative.RdpAbstractBinary
    {
        public RdpAfter(Commons.Xml.Relaxng.Derivative.RdpPattern l, Commons.Xml.Relaxng.Derivative.RdpPattern r) : base (default(Commons.Xml.Relaxng.Derivative.RdpPattern), default(Commons.Xml.Relaxng.Derivative.RdpPattern)) { }
        public override bool Nullable { get { throw null; } }
        public override Commons.Xml.Relaxng.RelaxngPatternType PatternType { get { throw null; } }
        public override Commons.Xml.Relaxng.Derivative.RdpPattern ApplyAfter(Commons.Xml.Relaxng.Derivative.RdpApplyAfterHandler handler) { throw null; }
        public override Commons.Xml.Relaxng.Derivative.RdpPattern AttDeriv(string name, string ns, string value, System.Xml.XmlReader reader) { throw null; }
        public override Commons.Xml.Relaxng.Derivative.RdpPattern EndAttDeriv() { throw null; }
        public override Commons.Xml.Relaxng.Derivative.RdpPattern EndTagDeriv() { throw null; }
        public override void GetLabels(System.Collections.Hashtable elements, System.Collections.Hashtable attributes, bool collectNameClass) { }
        public override Commons.Xml.Relaxng.Derivative.RdpPattern StartAttDeriv(string name, string ns) { throw null; }
        public override Commons.Xml.Relaxng.Derivative.RdpPattern StartTagCloseDeriv() { throw null; }
        public override Commons.Xml.Relaxng.Derivative.RdpPattern StartTagOpenDeriv(string name, string ns) { throw null; }
        public override Commons.Xml.Relaxng.Derivative.RdpPattern TextDeriv(string s, System.Xml.XmlReader reader) { throw null; }
    }
    public partial class RdpAnyName : Commons.Xml.Relaxng.Derivative.RdpNameClass
    {
        internal RdpAnyName() { }
        public override bool HasInfiniteName { get { throw null; } }
        public static Commons.Xml.Relaxng.Derivative.RdpAnyName Instance { get { throw null; } }
        public override Commons.Xml.Relaxng.Derivative.RdpNameClassType NameClassType { get { throw null; } }
        public override bool Contains(string name, string ns) { throw null; }
    }
    public partial class RdpAnyNameExcept : Commons.Xml.Relaxng.Derivative.RdpNameClass
    {
        public RdpAnyNameExcept(Commons.Xml.Relaxng.Derivative.RdpNameClass except) { }
        public Commons.Xml.Relaxng.Derivative.RdpNameClass ExceptNameClass { get { throw null; } }
        public override bool HasInfiniteName { get { throw null; } }
        public override Commons.Xml.Relaxng.Derivative.RdpNameClassType NameClassType { get { throw null; } }
        public override bool Contains(string name, string ns) { throw null; }
    }
    public delegate Commons.Xml.Relaxng.Derivative.RdpPattern RdpApplyAfterHandler(Commons.Xml.Relaxng.Derivative.RdpPattern p);
    public partial class RdpAttribute : Commons.Xml.Relaxng.Derivative.RdpPattern
    {
        public RdpAttribute(Commons.Xml.Relaxng.Derivative.RdpNameClass nameClass, Commons.Xml.Relaxng.Derivative.RdpPattern p) { }
        public Commons.Xml.Relaxng.Derivative.RdpPattern Children { get { throw null; } set { } }
        public override Commons.Xml.Relaxng.Derivative.RdpContentType ContentType { get { throw null; } }
        public Commons.Xml.Relaxng.Derivative.RdpNameClass NameClass { get { throw null; } }
        public override bool Nullable { get { throw null; } }
        public override Commons.Xml.Relaxng.RelaxngPatternType PatternType { get { throw null; } }
        public override Commons.Xml.Relaxng.Derivative.RdpPattern AttDeriv(string name, string ns, string value, System.Xml.XmlReader reader) { throw null; }
        public override void GetLabels(System.Collections.Hashtable elements, System.Collections.Hashtable attributes, bool collectNameClass) { }
        public override Commons.Xml.Relaxng.Derivative.RdpPattern StartAttDeriv(string name, string ns) { throw null; }
        public override Commons.Xml.Relaxng.Derivative.RdpPattern StartTagCloseDeriv() { throw null; }
    }
    public delegate Commons.Xml.Relaxng.Derivative.RdpPattern RdpBinaryFunction(Commons.Xml.Relaxng.Derivative.RdpPattern p1, Commons.Xml.Relaxng.Derivative.RdpPattern p2);
    public partial class RdpChoice : Commons.Xml.Relaxng.Derivative.RdpAbstractBinary
    {
        public RdpChoice(Commons.Xml.Relaxng.Derivative.RdpPattern l, Commons.Xml.Relaxng.Derivative.RdpPattern r) : base (default(Commons.Xml.Relaxng.Derivative.RdpPattern), default(Commons.Xml.Relaxng.Derivative.RdpPattern)) { }
        public override Commons.Xml.Relaxng.Derivative.RdpContentType ContentType { get { throw null; } }
        public override bool Nullable { get { throw null; } }
        public override Commons.Xml.Relaxng.RelaxngPatternType PatternType { get { throw null; } }
        public override Commons.Xml.Relaxng.Derivative.RdpPattern ApplyAfter(Commons.Xml.Relaxng.Derivative.RdpApplyAfterHandler handler) { throw null; }
        public override Commons.Xml.Relaxng.Derivative.RdpPattern AttDeriv(string name, string ns, string value, System.Xml.XmlReader reader) { throw null; }
        public override Commons.Xml.Relaxng.Derivative.RdpPattern EndAttDeriv() { throw null; }
        public override Commons.Xml.Relaxng.Derivative.RdpPattern EndTagDeriv() { throw null; }
        public override void GetLabels(System.Collections.Hashtable elements, System.Collections.Hashtable attributes, bool collectNameClass) { }
        public override Commons.Xml.Relaxng.Derivative.RdpPattern StartAttDeriv(string name, string ns) { throw null; }
        public override Commons.Xml.Relaxng.Derivative.RdpPattern StartTagCloseDeriv() { throw null; }
        public override Commons.Xml.Relaxng.Derivative.RdpPattern StartTagOpenDeriv(string name, string ns) { throw null; }
        public override Commons.Xml.Relaxng.Derivative.RdpPattern TextDeriv(string s, System.Xml.XmlReader reader) { throw null; }
    }
    public enum RdpContentType
    {
        Complex = 2,
        Empty = 1,
        Invalid = 0,
        Simple = 4,
    }
    public partial class RdpData : Commons.Xml.Relaxng.Derivative.RdpPattern
    {
        public RdpData(Commons.Xml.Relaxng.Derivative.RdpDatatype dt) { }
        public override Commons.Xml.Relaxng.Derivative.RdpContentType ContentType { get { throw null; } }
        public Commons.Xml.Relaxng.Derivative.RdpDatatype Datatype { get { throw null; } }
        public override bool Nullable { get { throw null; } }
        public override Commons.Xml.Relaxng.RelaxngPatternType PatternType { get { throw null; } }
        public override void GetLabels(System.Collections.Hashtable elements, System.Collections.Hashtable attributes, bool collectNameClass) { }
        public override Commons.Xml.Relaxng.Derivative.RdpPattern TextDeriv(string s, System.Xml.XmlReader reader) { throw null; }
    }
    public partial class RdpDataExcept : Commons.Xml.Relaxng.Derivative.RdpData
    {
        public RdpDataExcept(Commons.Xml.Relaxng.Derivative.RdpDatatype dt, Commons.Xml.Relaxng.Derivative.RdpPattern except) : base (default(Commons.Xml.Relaxng.Derivative.RdpDatatype)) { }
        public override Commons.Xml.Relaxng.Derivative.RdpContentType ContentType { get { throw null; } }
        public Commons.Xml.Relaxng.Derivative.RdpPattern Except { get { throw null; } set { } }
        public override Commons.Xml.Relaxng.RelaxngPatternType PatternType { get { throw null; } }
        public override Commons.Xml.Relaxng.Derivative.RdpPattern TextDeriv(string s, System.Xml.XmlReader reader) { throw null; }
    }
    public partial class RdpDatatype
    {
        public RdpDatatype(string ns, string localName, Commons.Xml.Relaxng.RelaxngParamList parameters, Commons.Xml.Relaxng.RelaxngDatatypeProvider provider) { }
        public bool IsContextDependent { get { throw null; } }
        public string LocalName { get { throw null; } }
        public string NamespaceURI { get { throw null; } }
        public virtual bool IsAllowed(string value, System.Xml.XmlReader reader) { throw null; }
        public virtual bool IsTypeEqual(string s1, string s2, System.Xml.XmlReader reader) { throw null; }
    }
    public partial class RdpElement : Commons.Xml.Relaxng.Derivative.RdpPattern
    {
        public RdpElement(Commons.Xml.Relaxng.Derivative.RdpNameClass nameClass, Commons.Xml.Relaxng.Derivative.RdpPattern p) { }
        public Commons.Xml.Relaxng.Derivative.RdpPattern Children { get { throw null; } set { } }
        public override Commons.Xml.Relaxng.Derivative.RdpContentType ContentType { get { throw null; } }
        public Commons.Xml.Relaxng.Derivative.RdpNameClass NameClass { get { throw null; } }
        public override bool Nullable { get { throw null; } }
        public override Commons.Xml.Relaxng.RelaxngPatternType PatternType { get { throw null; } }
        public override void GetLabels(System.Collections.Hashtable elements, System.Collections.Hashtable attributes, bool collectNameClass) { }
        public override Commons.Xml.Relaxng.Derivative.RdpPattern StartTagOpenDeriv(string name, string ns) { throw null; }
    }
    public partial class RdpEmpty : Commons.Xml.Relaxng.Derivative.RdpPattern
    {
        public RdpEmpty() { }
        public override Commons.Xml.Relaxng.Derivative.RdpContentType ContentType { get { throw null; } }
        public static Commons.Xml.Relaxng.Derivative.RdpEmpty Instance { get { throw null; } }
        public override bool Nullable { get { throw null; } }
        public override Commons.Xml.Relaxng.RelaxngPatternType PatternType { get { throw null; } }
        public override void GetLabels(System.Collections.Hashtable elements, System.Collections.Hashtable attributes, bool collectNameClass) { }
    }
    public partial class RdpGroup : Commons.Xml.Relaxng.Derivative.RdpAbstractBinary
    {
        public RdpGroup(Commons.Xml.Relaxng.Derivative.RdpPattern l, Commons.Xml.Relaxng.Derivative.RdpPattern r) : base (default(Commons.Xml.Relaxng.Derivative.RdpPattern), default(Commons.Xml.Relaxng.Derivative.RdpPattern)) { }
        public override bool Nullable { get { throw null; } }
        public override Commons.Xml.Relaxng.RelaxngPatternType PatternType { get { throw null; } }
        public override Commons.Xml.Relaxng.Derivative.RdpPattern AttDeriv(string name, string ns, string value, System.Xml.XmlReader reader) { throw null; }
        public override void GetLabels(System.Collections.Hashtable elements, System.Collections.Hashtable attributes, bool collectNameClass) { }
        public override Commons.Xml.Relaxng.Derivative.RdpPattern StartAttDeriv(string name, string ns) { throw null; }
        public override Commons.Xml.Relaxng.Derivative.RdpPattern StartTagCloseDeriv() { throw null; }
        public override Commons.Xml.Relaxng.Derivative.RdpPattern StartTagOpenDeriv(string name, string ns) { throw null; }
        public override Commons.Xml.Relaxng.Derivative.RdpPattern TextDeriv(string s, System.Xml.XmlReader reader) { throw null; }
    }
    public partial class RdpInterleave : Commons.Xml.Relaxng.Derivative.RdpAbstractBinary
    {
        public RdpInterleave(Commons.Xml.Relaxng.Derivative.RdpPattern l, Commons.Xml.Relaxng.Derivative.RdpPattern r) : base (default(Commons.Xml.Relaxng.Derivative.RdpPattern), default(Commons.Xml.Relaxng.Derivative.RdpPattern)) { }
        public override bool Nullable { get { throw null; } }
        public override Commons.Xml.Relaxng.RelaxngPatternType PatternType { get { throw null; } }
        public override Commons.Xml.Relaxng.Derivative.RdpPattern AttDeriv(string name, string ns, string value, System.Xml.XmlReader reader) { throw null; }
        public override void GetLabels(System.Collections.Hashtable elements, System.Collections.Hashtable attributes, bool collectNameClass) { }
        public override Commons.Xml.Relaxng.Derivative.RdpPattern StartAttDeriv(string name, string ns) { throw null; }
        public override Commons.Xml.Relaxng.Derivative.RdpPattern StartTagCloseDeriv() { throw null; }
        public override Commons.Xml.Relaxng.Derivative.RdpPattern StartTagOpenDeriv(string name, string ns) { throw null; }
        public override Commons.Xml.Relaxng.Derivative.RdpPattern TextDeriv(string s, System.Xml.XmlReader reader) { throw null; }
    }
    public partial class RdpList : Commons.Xml.Relaxng.Derivative.RdpAbstractSingleContent
    {
        public RdpList(Commons.Xml.Relaxng.Derivative.RdpPattern p) : base (default(Commons.Xml.Relaxng.Derivative.RdpPattern)) { }
        public override Commons.Xml.Relaxng.Derivative.RdpContentType ContentType { get { throw null; } }
        public override bool Nullable { get { throw null; } }
        public override Commons.Xml.Relaxng.RelaxngPatternType PatternType { get { throw null; } }
        public override void GetLabels(System.Collections.Hashtable elements, System.Collections.Hashtable attributes, bool collectNameClass) { }
        public override Commons.Xml.Relaxng.Derivative.RdpPattern TextDeriv(string s, System.Xml.XmlReader reader) { throw null; }
    }
    public partial class RdpName : Commons.Xml.Relaxng.Derivative.RdpNameClass
    {
        public RdpName(string local, string ns) { }
        public override bool HasInfiniteName { get { throw null; } }
        public string LocalName { get { throw null; } }
        public override Commons.Xml.Relaxng.Derivative.RdpNameClassType NameClassType { get { throw null; } }
        public string NamespaceURI { get { throw null; } }
        public override bool Contains(string name, string ns) { throw null; }
    }
    public abstract partial class RdpNameClass
    {
        protected RdpNameClass() { }
        public abstract bool HasInfiniteName { get; }
        public abstract Commons.Xml.Relaxng.Derivative.RdpNameClassType NameClassType { get; }
        public abstract bool Contains(string name, string ns);
    }
    public partial class RdpNameClassChoice : Commons.Xml.Relaxng.Derivative.RdpNameClass
    {
        public RdpNameClassChoice(Commons.Xml.Relaxng.Derivative.RdpNameClass l, Commons.Xml.Relaxng.Derivative.RdpNameClass r) { }
        public override bool HasInfiniteName { get { throw null; } }
        public Commons.Xml.Relaxng.Derivative.RdpNameClass LValue { get { throw null; } }
        public override Commons.Xml.Relaxng.Derivative.RdpNameClassType NameClassType { get { throw null; } }
        public Commons.Xml.Relaxng.Derivative.RdpNameClass RValue { get { throw null; } }
        public override bool Contains(string name, string ns) { throw null; }
    }
    public enum RdpNameClassType
    {
        AnyName = 1,
        AnyNameExcept = 2,
        Name = 5,
        NameClassChoice = 6,
        None = 0,
        NsName = 3,
        NsNameExcept = 4,
    }
    public partial class RdpNotAllowed : Commons.Xml.Relaxng.Derivative.RdpPattern
    {
        public RdpNotAllowed() { }
        public override Commons.Xml.Relaxng.Derivative.RdpContentType ContentType { get { throw null; } }
        public static Commons.Xml.Relaxng.Derivative.RdpNotAllowed Instance { get { throw null; } }
        public override bool Nullable { get { throw null; } }
        public override Commons.Xml.Relaxng.RelaxngPatternType PatternType { get { throw null; } }
        public override Commons.Xml.Relaxng.Derivative.RdpPattern ApplyAfter(Commons.Xml.Relaxng.Derivative.RdpApplyAfterHandler h) { throw null; }
        public override void GetLabels(System.Collections.Hashtable elements, System.Collections.Hashtable attributes, bool collectNameClass) { }
    }
    public partial class RdpNsName : Commons.Xml.Relaxng.Derivative.RdpNameClass
    {
        public RdpNsName(string ns) { }
        public override bool HasInfiniteName { get { throw null; } }
        public override Commons.Xml.Relaxng.Derivative.RdpNameClassType NameClassType { get { throw null; } }
        public string NamespaceURI { get { throw null; } }
        public override bool Contains(string name, string ns) { throw null; }
    }
    public partial class RdpNsNameExcept : Commons.Xml.Relaxng.Derivative.RdpNsName
    {
        public RdpNsNameExcept(string ns, Commons.Xml.Relaxng.Derivative.RdpNameClass except) : base (default(string)) { }
        public Commons.Xml.Relaxng.Derivative.RdpNameClass ExceptNameClass { get { throw null; } }
        public override bool HasInfiniteName { get { throw null; } }
        public override Commons.Xml.Relaxng.Derivative.RdpNameClassType NameClassType { get { throw null; } }
        public override bool Contains(string name, string ns) { throw null; }
    }
    public partial class RdpOneOrMore : Commons.Xml.Relaxng.Derivative.RdpAbstractSingleContent
    {
        public RdpOneOrMore(Commons.Xml.Relaxng.Derivative.RdpPattern p) : base (default(Commons.Xml.Relaxng.Derivative.RdpPattern)) { }
        public override Commons.Xml.Relaxng.Derivative.RdpContentType ContentType { get { throw null; } }
        public override bool Nullable { get { throw null; } }
        public override Commons.Xml.Relaxng.RelaxngPatternType PatternType { get { throw null; } }
        public override Commons.Xml.Relaxng.Derivative.RdpPattern AttDeriv(string name, string ns, string value, System.Xml.XmlReader reader) { throw null; }
        public override void GetLabels(System.Collections.Hashtable elements, System.Collections.Hashtable attributes, bool collectNameClass) { }
        public override Commons.Xml.Relaxng.Derivative.RdpPattern StartAttDeriv(string name, string ns) { throw null; }
        public override Commons.Xml.Relaxng.Derivative.RdpPattern StartTagCloseDeriv() { throw null; }
        public override Commons.Xml.Relaxng.Derivative.RdpPattern StartTagOpenDeriv(string name, string ns) { throw null; }
        public override Commons.Xml.Relaxng.Derivative.RdpPattern TextDeriv(string s, System.Xml.XmlReader reader) { throw null; }
    }
    public partial class RdpParam
    {
        public RdpParam(string localName, string value) { }
        public string LocalName { get { throw null; } }
        public string Value { get { throw null; } }
    }
    public partial class RdpParamList : System.Collections.ArrayList
    {
        public RdpParamList() { }
    }
    public abstract partial class RdpPattern
    {
        public static readonly Commons.Xml.Relaxng.Derivative.RdpPattern Anything;
        protected RdpPattern() { }
        public abstract Commons.Xml.Relaxng.Derivative.RdpContentType ContentType { get; }
        public abstract bool Nullable { get; }
        public abstract Commons.Xml.Relaxng.RelaxngPatternType PatternType { get; }
        public virtual Commons.Xml.Relaxng.Derivative.RdpPattern After(Commons.Xml.Relaxng.Derivative.RdpPattern p) { throw null; }
        public virtual Commons.Xml.Relaxng.Derivative.RdpPattern ApplyAfter(Commons.Xml.Relaxng.Derivative.RdpApplyAfterHandler h) { throw null; }
        public virtual Commons.Xml.Relaxng.Derivative.RdpPattern AttDeriv(string name, string ns, string value, System.Xml.XmlReader reader) { throw null; }
        public virtual Commons.Xml.Relaxng.Derivative.RdpPattern Choice(Commons.Xml.Relaxng.Derivative.RdpPattern p) { throw null; }
        public virtual Commons.Xml.Relaxng.Derivative.RdpPattern EndAttDeriv() { throw null; }
        public virtual Commons.Xml.Relaxng.Derivative.RdpPattern EndTagDeriv() { throw null; }
        public void GetLabels(System.Collections.Hashtable elements, System.Collections.Hashtable attributes) { }
        public abstract void GetLabels(System.Collections.Hashtable elements, System.Collections.Hashtable attributes, bool collectNameClass);
        public virtual Commons.Xml.Relaxng.Derivative.RdpPattern Group(Commons.Xml.Relaxng.Derivative.RdpPattern p) { throw null; }
        public virtual Commons.Xml.Relaxng.Derivative.RdpPattern Interleave(Commons.Xml.Relaxng.Derivative.RdpPattern p) { throw null; }
        public Commons.Xml.Relaxng.Derivative.RdpPattern ListDeriv(string[] list, int index, System.Xml.XmlReader reader) { throw null; }
        public Commons.Xml.Relaxng.Derivative.RdpAfter MakeAfter(Commons.Xml.Relaxng.Derivative.RdpPattern p1, Commons.Xml.Relaxng.Derivative.RdpPattern p2) { throw null; }
        public Commons.Xml.Relaxng.Derivative.RdpPattern MakeChoice(Commons.Xml.Relaxng.Derivative.RdpPattern p1, Commons.Xml.Relaxng.Derivative.RdpPattern p2) { throw null; }
        public Commons.Xml.Relaxng.Derivative.RdpChoice MakeChoiceLeaf(Commons.Xml.Relaxng.Derivative.RdpPattern p) { throw null; }
        public Commons.Xml.Relaxng.Derivative.RdpPattern MakeGroup(Commons.Xml.Relaxng.Derivative.RdpPattern p1, Commons.Xml.Relaxng.Derivative.RdpPattern p2) { throw null; }
        public Commons.Xml.Relaxng.Derivative.RdpInterleave MakeInterleave(Commons.Xml.Relaxng.Derivative.RdpPattern p1, Commons.Xml.Relaxng.Derivative.RdpPattern p2) { throw null; }
        public Commons.Xml.Relaxng.Derivative.RdpOneOrMore MakeOneOrMore(Commons.Xml.Relaxng.Derivative.RdpPattern p) { throw null; }
        public Commons.Xml.Relaxng.Derivative.RdpPattern OneOrMore() { throw null; }
        public virtual Commons.Xml.Relaxng.Derivative.RdpPattern StartAttDeriv(string name, string ns) { throw null; }
        public virtual Commons.Xml.Relaxng.Derivative.RdpPattern StartTagCloseDeriv() { throw null; }
        public virtual Commons.Xml.Relaxng.Derivative.RdpPattern StartTagOpenDeriv(string name, string ns) { throw null; }
        public virtual Commons.Xml.Relaxng.Derivative.RdpPattern TextDeriv(string s, System.Xml.XmlReader reader) { throw null; }
        public bool ValueMatch(string s, System.Xml.XmlReader reader) { throw null; }
    }
    public partial class RdpText : Commons.Xml.Relaxng.Derivative.RdpPattern
    {
        public RdpText() { }
        public override Commons.Xml.Relaxng.Derivative.RdpContentType ContentType { get { throw null; } }
        public static Commons.Xml.Relaxng.Derivative.RdpText Instance { get { throw null; } }
        public override bool Nullable { get { throw null; } }
        public override Commons.Xml.Relaxng.RelaxngPatternType PatternType { get { throw null; } }
        public override void GetLabels(System.Collections.Hashtable elements, System.Collections.Hashtable attributes, bool collectNameClass) { }
        public override Commons.Xml.Relaxng.Derivative.RdpPattern TextDeriv(string s, System.Xml.XmlReader reader) { throw null; }
    }
    public partial class RdpUtil
    {
        public static char[] WhitespaceChars;
        public RdpUtil() { }
    }
    public partial class RdpValue : Commons.Xml.Relaxng.Derivative.RdpPattern
    {
        public RdpValue(Commons.Xml.Relaxng.Derivative.RdpDatatype dt, string value) { }
        public override Commons.Xml.Relaxng.Derivative.RdpContentType ContentType { get { throw null; } }
        public Commons.Xml.Relaxng.Derivative.RdpDatatype Datatype { get { throw null; } }
        public override bool Nullable { get { throw null; } }
        public override Commons.Xml.Relaxng.RelaxngPatternType PatternType { get { throw null; } }
        public string Value { get { throw null; } }
        public override void GetLabels(System.Collections.Hashtable elements, System.Collections.Hashtable attributes, bool collectNameClass) { }
        public override Commons.Xml.Relaxng.Derivative.RdpPattern TextDeriv(string s, System.Xml.XmlReader reader) { throw null; }
    }
}
namespace Commons.Xml.Relaxng.Inference
{
    public partial class RelaxngInference
    {
        public RelaxngInference() { }
        public Commons.Xml.Relaxng.Inference.RelaxngInference.InferenceOption Occurrence { get { throw null; } set { } }
        public Commons.Xml.Relaxng.Inference.RelaxngInference.InferenceOption TypeInference { get { throw null; } set { } }
        public Commons.Xml.Relaxng.RelaxngGrammar InferSchema(System.Xml.XmlReader xmlReader) { throw null; }
        public Commons.Xml.Relaxng.RelaxngGrammar InferSchema(System.Xml.XmlReader xmlReader, Commons.Xml.Relaxng.RelaxngGrammar grammar) { throw null; }
        public enum InferenceOption
        {
            Relaxed = 1,
            Restricted = 0,
        }
    }
}
namespace Commons.Xml.Relaxng.Rnc
{
    public partial class RncParser
    {
        public int eof_token;
        public System.IO.TextWriter ErrorOutput;
        protected bool use_global_stacks;
        protected static readonly short[] yyCheck;
        protected static readonly short[] yyDgoto;
        protected const int yyFinal = 4;
        protected static readonly short[] yyGindex;
        protected int yyMax;
        protected static readonly string[] yyNames;
        protected static readonly short[] yyRindex;
        protected static readonly short[] yySindex;
        protected static readonly short[] yyTable;
        public RncParser(System.Xml.XmlNameTable nameTable) { }
        public string BaseUri { get { throw null; } }
        public int Column { get { throw null; } }
        public int Line { get { throw null; } }
        public Commons.Xml.Relaxng.RelaxngPattern Parse(System.IO.TextReader source) { throw null; }
        public Commons.Xml.Relaxng.RelaxngPattern Parse(System.IO.TextReader source, string baseUri) { throw null; }
        public Commons.Xml.Relaxng.RelaxngPattern Parse(System.IO.TextReader source, string baseUri, string defaultNamespace) { throw null; }
        public static Commons.Xml.Relaxng.RelaxngPattern ParseRnc(System.IO.TextReader reader) { throw null; }
        public static Commons.Xml.Relaxng.RelaxngPattern ParseRnc(System.IO.TextReader reader, System.Xml.XmlNameTable nameTable) { throw null; }
        public static Commons.Xml.Relaxng.RelaxngPattern ParseRnc(System.IO.TextReader reader, System.Xml.XmlNameTable nameTable, string baseUri) { throw null; }
        public static Commons.Xml.Relaxng.RelaxngPattern ParseRnc(System.IO.TextReader reader, System.Xml.XmlNameTable nameTable, string baseUri, string defaultNamespace) { throw null; }
        protected object yyDefault(object first) { throw null; }
        public void yyerror(string message) { }
        public void yyerror(string message, string[] expected) { }
        protected string[] yyExpecting(int state) { throw null; }
        protected int[] yyExpectingTokens(int state) { throw null; }
        public static string yyname(int token) { throw null; }
    }
}
namespace Commons.Xml.Relaxng.XmlSchema
{
    public partial class XsdDatatypeProvider : Commons.Xml.Relaxng.RelaxngDatatypeProvider
    {
        internal XsdDatatypeProvider() { }
        public static Commons.Xml.Relaxng.XmlSchema.XsdDatatypeProvider Instance { get { throw null; } }
        public override Commons.Xml.Relaxng.RelaxngDatatype GetDatatype(string name, string ns, Commons.Xml.Relaxng.RelaxngParamList parameters) { throw null; }
    }
    public partial class XsdPrimitiveType : Commons.Xml.Relaxng.RelaxngDatatype
    {
        public XsdPrimitiveType(string name, System.Xml.Schema.XmlSchemaDatatype xstype) { }
        public override string Name { get { throw null; } }
        public override string NamespaceURI { get { throw null; } }
        public override object Parse(string text, System.Xml.XmlReader reader) { throw null; }
    }
    public partial class XsdQNameWrapper : Commons.Xml.Relaxng.RelaxngDatatype
    {
        public XsdQNameWrapper() { }
        public override string Name { get { throw null; } }
        public override string NamespaceURI { get { throw null; } }
        public override object Parse(string s, System.Xml.XmlReader reader) { throw null; }
    }
    public partial class XsdSimpleRestrictionType : Commons.Xml.Relaxng.RelaxngDatatype
    {
        public XsdSimpleRestrictionType(Commons.Xml.Relaxng.RelaxngDatatype primitive, Commons.Xml.Relaxng.RelaxngParamList parameters) { }
        public override string Name { get { throw null; } }
        public override string NamespaceURI { get { throw null; } }
        public override object Parse(string value, System.Xml.XmlReader reader) { throw null; }
    }
}
