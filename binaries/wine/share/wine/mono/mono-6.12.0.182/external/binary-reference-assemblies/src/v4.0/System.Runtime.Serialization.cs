// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

[assembly:System.Reflection.AssemblyVersionAttribute("4.0.0.0")]
[assembly:System.CLSCompliantAttribute(true)]
[assembly:System.Reflection.AssemblyCompanyAttribute("Mono development team")]
[assembly:System.Reflection.AssemblyCopyrightAttribute("(c) Various Mono authors")]
[assembly:System.Reflection.AssemblyDefaultAliasAttribute("System.Runtime.Serialization.dll")]
[assembly:System.Reflection.AssemblyDescriptionAttribute("System.Runtime.Serialization.dll")]
[assembly:System.Reflection.AssemblyFileVersionAttribute("4.0.30319.1")]
[assembly:System.Reflection.AssemblyInformationalVersionAttribute("4.0.30319.1")]
[assembly:System.Reflection.AssemblyProductAttribute("Mono Common Language Infrastructure")]
[assembly:System.Reflection.AssemblyTitleAttribute("System.Runtime.Serialization.dll")]
[assembly:System.Resources.NeutralResourcesLanguageAttribute("en-US")]
[assembly:System.Resources.SatelliteContractVersionAttribute("4.0.0.0")]
[assembly:System.Runtime.CompilerServices.ReferenceAssemblyAttribute]
[assembly:System.Runtime.CompilerServices.RuntimeCompatibilityAttribute(WrapNonExceptionThrows=true)]
[assembly:System.Runtime.InteropServices.ComCompatibleVersionAttribute(1, 0, 3300, 0)]
[assembly:System.Runtime.InteropServices.ComVisibleAttribute(false)]
[assembly:System.Security.AllowPartiallyTrustedCallersAttribute]
[assembly:System.Security.SecurityCriticalAttribute((System.Security.SecurityCriticalScope)(0))]
namespace System
{
    [System.AttributeUsageAttribute((System.AttributeTargets)(32767), AllowMultiple=true)]
    internal partial class MonoDocumentationNoteAttribute : System.MonoTODOAttribute
    {
        public MonoDocumentationNoteAttribute(string comment) { }
    }
    [System.AttributeUsageAttribute((System.AttributeTargets)(32767), AllowMultiple=true)]
    internal partial class MonoExtensionAttribute : System.MonoTODOAttribute
    {
        public MonoExtensionAttribute(string comment) { }
    }
    [System.AttributeUsageAttribute((System.AttributeTargets)(32767), AllowMultiple=true)]
    internal partial class MonoInternalNoteAttribute : System.MonoTODOAttribute
    {
        public MonoInternalNoteAttribute(string comment) { }
    }
    [System.AttributeUsageAttribute((System.AttributeTargets)(32767), AllowMultiple=true)]
    internal partial class MonoLimitationAttribute : System.MonoTODOAttribute
    {
        public MonoLimitationAttribute(string comment) { }
    }
    [System.AttributeUsageAttribute((System.AttributeTargets)(32767), AllowMultiple=true)]
    internal partial class MonoNotSupportedAttribute : System.MonoTODOAttribute
    {
        public MonoNotSupportedAttribute(string comment) { }
    }
    [System.AttributeUsageAttribute((System.AttributeTargets)(32767), AllowMultiple=true)]
    internal partial class MonoTODOAttribute : System.Attribute
    {
        public MonoTODOAttribute() { }
        public MonoTODOAttribute(string comment) { }
        public string Comment { get { throw null; } }
    }
}
namespace System.Runtime.Serialization
{
    [System.AttributeUsageAttribute((System.AttributeTargets)(12), Inherited=false, AllowMultiple=false)]
    public sealed partial class CollectionDataContractAttribute : System.Attribute
    {
        public CollectionDataContractAttribute() { }
        public bool IsReference { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public string ItemName { get { throw null; } set { } }
        public string KeyName { get { throw null; } set { } }
        public string Name { get { throw null; } set { } }
        public string Namespace { get { throw null; } set { } }
        public string ValueName { get { throw null; } set { } }
    }
    [System.AttributeUsageAttribute((System.AttributeTargets)(3), Inherited=false, AllowMultiple=true)]
    public sealed partial class ContractNamespaceAttribute : System.Attribute
    {
        public ContractNamespaceAttribute(string ns) { }
        public string ClrNamespace { get { throw null; } set { } }
        public string ContractNamespace { get { throw null; } }
    }
    [System.AttributeUsageAttribute((System.AttributeTargets)(28), Inherited=false, AllowMultiple=false)]
    public sealed partial class DataContractAttribute : System.Attribute
    {
        public DataContractAttribute() { }
        public bool IsReference { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public string Name { get { throw null; } set { } }
        public string Namespace { get { throw null; } set { } }
    }
    public abstract partial class DataContractResolver
    {
        protected DataContractResolver() { }
        public abstract System.Type ResolveName(string typeName, string typeNamespace, System.Type declaredType, System.Runtime.Serialization.DataContractResolver knownTypeResolver);
        public abstract bool TryResolveType(System.Type type, System.Type declaredType, System.Runtime.Serialization.DataContractResolver knownTypeResolver, out System.Xml.XmlDictionaryString typeName, out System.Xml.XmlDictionaryString typeNamespace);
    }
    public sealed partial class DataContractSerializer : System.Runtime.Serialization.XmlObjectSerializer
    {
        public DataContractSerializer(System.Type type) { }
        public DataContractSerializer(System.Type type, System.Collections.Generic.IEnumerable<System.Type> knownTypes) { }
        public DataContractSerializer(System.Type type, System.Collections.Generic.IEnumerable<System.Type> knownTypes, int maxObjectsInGraph, bool ignoreExtensionDataObject, bool preserveObjectReferences, System.Runtime.Serialization.IDataContractSurrogate dataContractSurrogate) { }
        public DataContractSerializer(System.Type type, System.Collections.Generic.IEnumerable<System.Type> knownTypes, int maxObjectsInGraph, bool ignoreExtensionDataObject, bool preserveObjectReferences, System.Runtime.Serialization.IDataContractSurrogate dataContractSurrogate, System.Runtime.Serialization.DataContractResolver dataContractResolver) { }
        public DataContractSerializer(System.Type type, string rootName, string rootNamespace) { }
        public DataContractSerializer(System.Type type, string rootName, string rootNamespace, System.Collections.Generic.IEnumerable<System.Type> knownTypes) { }
        public DataContractSerializer(System.Type type, string rootName, string rootNamespace, System.Collections.Generic.IEnumerable<System.Type> knownTypes, int maxObjectsInGraph, bool ignoreExtensionDataObject, bool preserveObjectReferences, System.Runtime.Serialization.IDataContractSurrogate dataContractSurrogate) { }
        public DataContractSerializer(System.Type type, string rootName, string rootNamespace, System.Collections.Generic.IEnumerable<System.Type> knownTypes, int maxObjectsInGraph, bool ignoreExtensionDataObject, bool preserveObjectReferences, System.Runtime.Serialization.IDataContractSurrogate dataContractSurrogate, System.Runtime.Serialization.DataContractResolver dataContractResolver) { }
        public DataContractSerializer(System.Type type, System.Xml.XmlDictionaryString rootName, System.Xml.XmlDictionaryString rootNamespace) { }
        public DataContractSerializer(System.Type type, System.Xml.XmlDictionaryString rootName, System.Xml.XmlDictionaryString rootNamespace, System.Collections.Generic.IEnumerable<System.Type> knownTypes) { }
        public DataContractSerializer(System.Type type, System.Xml.XmlDictionaryString rootName, System.Xml.XmlDictionaryString rootNamespace, System.Collections.Generic.IEnumerable<System.Type> knownTypes, int maxObjectsInGraph, bool ignoreExtensionDataObject, bool preserveObjectReferences, System.Runtime.Serialization.IDataContractSurrogate dataContractSurrogate) { }
        public DataContractSerializer(System.Type type, System.Xml.XmlDictionaryString rootName, System.Xml.XmlDictionaryString rootNamespace, System.Collections.Generic.IEnumerable<System.Type> knownTypes, int maxObjectsInGraph, bool ignoreExtensionDataObject, bool preserveObjectReferences, System.Runtime.Serialization.IDataContractSurrogate dataContractSurrogate, System.Runtime.Serialization.DataContractResolver dataContractResolver) { }
        public System.Runtime.Serialization.DataContractResolver DataContractResolver { get { throw null; } }
        public System.Runtime.Serialization.IDataContractSurrogate DataContractSurrogate { get { throw null; } }
        public bool IgnoreExtensionDataObject { get { throw null; } }
        public System.Collections.ObjectModel.ReadOnlyCollection<System.Type> KnownTypes { get { throw null; } }
        public int MaxItemsInObjectGraph { get { throw null; } }
        public bool PreserveObjectReferences { get { throw null; } }
        public override bool IsStartObject(System.Xml.XmlDictionaryReader reader) { throw null; }
        public override bool IsStartObject(System.Xml.XmlReader reader) { throw null; }
        public override object ReadObject(System.Xml.XmlDictionaryReader reader, bool verifyObjectName) { throw null; }
        public object ReadObject(System.Xml.XmlDictionaryReader reader, bool verifyObjectName, System.Runtime.Serialization.DataContractResolver resolver) { throw null; }
        public override object ReadObject(System.Xml.XmlReader reader) { throw null; }
        public override object ReadObject(System.Xml.XmlReader reader, bool verifyObjectName) { throw null; }
        public override void WriteEndObject(System.Xml.XmlDictionaryWriter writer) { }
        public override void WriteEndObject(System.Xml.XmlWriter writer) { }
        public void WriteObject(System.Xml.XmlDictionaryWriter writer, object graph, System.Runtime.Serialization.DataContractResolver resolver) { }
        public override void WriteObject(System.Xml.XmlWriter writer, object graph) { }
        [System.MonoTODOAttribute("use DataContractSurrogate")]
        public override void WriteObjectContent(System.Xml.XmlDictionaryWriter writer, object graph) { }
        public override void WriteObjectContent(System.Xml.XmlWriter writer, object graph) { }
        public override void WriteStartObject(System.Xml.XmlDictionaryWriter writer, object graph) { }
        public override void WriteStartObject(System.Xml.XmlWriter writer, object graph) { }
    }
    [System.AttributeUsageAttribute((System.AttributeTargets)(384), Inherited=false, AllowMultiple=false)]
    public sealed partial class DataMemberAttribute : System.Attribute
    {
        public DataMemberAttribute() { }
        public bool EmitDefaultValue { get { throw null; } set { } }
        public bool IsRequired { get { throw null; } set { } }
        public string Name { get { throw null; } set { } }
        public int Order { get { throw null; } set { } }
    }
    [System.AttributeUsageAttribute((System.AttributeTargets)(256), Inherited=false, AllowMultiple=false)]
    public sealed partial class EnumMemberAttribute : System.Attribute
    {
        public EnumMemberAttribute() { }
        public string Value { get { throw null; } set { } }
    }
    public partial class ExportOptions
    {
        public ExportOptions() { }
        public System.Runtime.Serialization.IDataContractSurrogate DataContractSurrogate { get { throw null; } set { } }
        [System.MonoTODOAttribute]
        public System.Collections.ObjectModel.Collection<System.Type> KnownTypes { get { throw null; } }
    }
    public sealed partial class ExtensionDataObject
    {
        internal ExtensionDataObject() { }
    }
    public partial interface IDataContractSurrogate
    {
        object GetCustomDataToExport(System.Reflection.MemberInfo memberInfo, System.Type dataContractType);
        object GetCustomDataToExport(System.Type clrType, System.Type dataContractType);
        System.Type GetDataContractType(System.Type type);
        object GetDeserializedObject(object obj, System.Type targetType);
        void GetKnownCustomDataTypes(System.Collections.ObjectModel.Collection<System.Type> customDataTypes);
        object GetObjectToSerialize(object obj, System.Type targetType);
        System.Type GetReferencedTypeOnImport(string typeName, string typeNamespace, object customData);
        System.CodeDom.CodeTypeDeclaration ProcessImportedType(System.CodeDom.CodeTypeDeclaration typeDeclaration, System.CodeDom.CodeCompileUnit compileUnit);
    }
    public partial interface IExtensibleDataObject
    {
        System.Runtime.Serialization.ExtensionDataObject ExtensionData { get; set; }
    }
    [System.AttributeUsageAttribute((System.AttributeTargets)(384), Inherited=false, AllowMultiple=false)]
    public sealed partial class IgnoreDataMemberAttribute : System.Attribute
    {
        public IgnoreDataMemberAttribute() { }
    }
    public partial class ImportOptions
    {
        public ImportOptions() { }
        public System.CodeDom.Compiler.CodeDomProvider CodeProvider { get { throw null; } set { } }
        [System.MonoTODOAttribute]
        public System.Runtime.Serialization.IDataContractSurrogate DataContractSurrogate { get { throw null; } set { } }
        [System.MonoTODOAttribute]
        public bool EnableDataBinding { get { throw null; } set { } }
        public bool GenerateInternal { get { throw null; } set { } }
        public bool GenerateSerializable { get { throw null; } set { } }
        [System.MonoTODOAttribute]
        public bool ImportXmlType { get { throw null; } set { } }
        public System.Collections.Generic.IDictionary<string, string> Namespaces { get { throw null; } }
        [System.MonoTODOAttribute]
        public System.Collections.Generic.ICollection<System.Type> ReferencedCollectionTypes { get { throw null; } }
        [System.MonoTODOAttribute]
        public System.Collections.Generic.ICollection<System.Type> ReferencedTypes { get { throw null; } }
    }
    [System.SerializableAttribute]
    public partial class InvalidDataContractException : System.Exception
    {
        public InvalidDataContractException() { }
        protected InvalidDataContractException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
        public InvalidDataContractException(string message) { }
        public InvalidDataContractException(string message, System.Exception innerException) { }
    }
    [System.AttributeUsageAttribute((System.AttributeTargets)(12), Inherited=true, AllowMultiple=true)]
    public sealed partial class KnownTypeAttribute : System.Attribute
    {
        public KnownTypeAttribute(string methodName) { }
        public KnownTypeAttribute(System.Type type) { }
        public string MethodName { get { throw null; } }
        public System.Type Type { get { throw null; } }
    }
    public sealed partial class NetDataContractSerializer : System.Runtime.Serialization.XmlObjectSerializer, System.Runtime.Serialization.IFormatter
    {
        public NetDataContractSerializer() { }
        public NetDataContractSerializer(System.Runtime.Serialization.StreamingContext context) { }
        public NetDataContractSerializer(System.Runtime.Serialization.StreamingContext context, int maxItemsInObjectGraph, bool ignoreExtensibleDataObject, System.Runtime.Serialization.Formatters.FormatterAssemblyStyle assemblyFormat, System.Runtime.Serialization.ISurrogateSelector surrogateSelector) { }
        public NetDataContractSerializer(string rootName, string rootNamespace) { }
        public NetDataContractSerializer(string rootName, string rootNamespace, System.Runtime.Serialization.StreamingContext context, int maxItemsInObjectGraph, bool ignoreExtensibleDataObject, System.Runtime.Serialization.Formatters.FormatterAssemblyStyle assemblyFormat, System.Runtime.Serialization.ISurrogateSelector surrogateSelector) { }
        public NetDataContractSerializer(System.Xml.XmlDictionaryString rootName, System.Xml.XmlDictionaryString rootNamespace) { }
        public NetDataContractSerializer(System.Xml.XmlDictionaryString rootName, System.Xml.XmlDictionaryString rootNamespace, System.Runtime.Serialization.StreamingContext context, int maxItemsInObjectGraph, bool ignoreExtensibleDataObject, System.Runtime.Serialization.Formatters.FormatterAssemblyStyle assemblyFormat, System.Runtime.Serialization.ISurrogateSelector surrogateSelector) { }
        public System.Runtime.Serialization.Formatters.FormatterAssemblyStyle AssemblyFormat { get { throw null; } set { } }
        public System.Runtime.Serialization.SerializationBinder Binder { get { throw null; } set { } }
        public System.Runtime.Serialization.StreamingContext Context { get { throw null; } set { } }
        public bool IgnoreExtensionDataObject { get { throw null; } }
        public int MaxItemsInObjectGraph { get { throw null; } }
        public System.Runtime.Serialization.ISurrogateSelector SurrogateSelector { get { throw null; } set { } }
        public object Deserialize(System.IO.Stream stream) { throw null; }
        [System.MonoTODOAttribute]
        public override bool IsStartObject(System.Xml.XmlDictionaryReader reader) { throw null; }
        public override object ReadObject(System.Xml.XmlDictionaryReader reader, bool readContentOnly) { throw null; }
        public void Serialize(System.IO.Stream stream, object graph) { }
        public override void WriteEndObject(System.Xml.XmlDictionaryWriter writer) { }
        [System.MonoTODOAttribute("support arrays; support Serializable; support SharedType; use DataContractSurrogate")]
        public override void WriteObjectContent(System.Xml.XmlDictionaryWriter writer, object graph) { }
        public override void WriteStartObject(System.Xml.XmlDictionaryWriter writer, object graph) { }
    }
    public abstract partial class XmlObjectSerializer
    {
        protected XmlObjectSerializer() { }
        public abstract bool IsStartObject(System.Xml.XmlDictionaryReader reader);
        public virtual bool IsStartObject(System.Xml.XmlReader reader) { throw null; }
        public virtual object ReadObject(System.IO.Stream stream) { throw null; }
        public virtual object ReadObject(System.Xml.XmlDictionaryReader reader) { throw null; }
        [System.MonoTODOAttribute]
        public abstract object ReadObject(System.Xml.XmlDictionaryReader reader, bool readContentOnly);
        public virtual object ReadObject(System.Xml.XmlReader reader) { throw null; }
        public virtual object ReadObject(System.Xml.XmlReader reader, bool readContentOnly) { throw null; }
        public abstract void WriteEndObject(System.Xml.XmlDictionaryWriter writer);
        public virtual void WriteEndObject(System.Xml.XmlWriter writer) { }
        public virtual void WriteObject(System.IO.Stream stream, object graph) { }
        public virtual void WriteObject(System.Xml.XmlDictionaryWriter writer, object graph) { }
        public virtual void WriteObject(System.Xml.XmlWriter writer, object graph) { }
        public abstract void WriteObjectContent(System.Xml.XmlDictionaryWriter writer, object graph);
        public virtual void WriteObjectContent(System.Xml.XmlWriter writer, object graph) { }
        public abstract void WriteStartObject(System.Xml.XmlDictionaryWriter writer, object graph);
        public virtual void WriteStartObject(System.Xml.XmlWriter writer, object graph) { }
    }
    public static partial class XmlSerializableServices
    {
        [System.MonoTODOAttribute]
        public static void AddDefaultSchema(System.Xml.Schema.XmlSchemaSet schemas, System.Xml.XmlQualifiedName typeQName) { }
        public static System.Xml.XmlNode[] ReadNodes(System.Xml.XmlReader xmlReader) { throw null; }
        public static void WriteNodes(System.Xml.XmlWriter xmlWriter, System.Xml.XmlNode[] nodes) { }
    }
    public partial class XsdDataContractExporter
    {
        public XsdDataContractExporter() { }
        public XsdDataContractExporter(System.Xml.Schema.XmlSchemaSet schemas) { }
        public System.Runtime.Serialization.ExportOptions Options { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public System.Xml.Schema.XmlSchemaSet Schemas { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        public bool CanExport(System.Collections.Generic.ICollection<System.Reflection.Assembly> assemblies) { throw null; }
        public bool CanExport(System.Collections.Generic.ICollection<System.Type> types) { throw null; }
        public bool CanExport(System.Type type) { throw null; }
        public void Export(System.Collections.Generic.ICollection<System.Reflection.Assembly> assemblies) { }
        public void Export(System.Collections.Generic.ICollection<System.Type> types) { }
        public void Export(System.Type type) { }
        public System.Xml.XmlQualifiedName GetRootElementName(System.Type type) { throw null; }
        public System.Xml.Schema.XmlSchemaType GetSchemaType(System.Type type) { throw null; }
        public System.Xml.XmlQualifiedName GetSchemaTypeName(System.Type type) { throw null; }
    }
    [System.MonoTODOAttribute("support arrays")]
    public partial class XsdDataContractImporter
    {
        public XsdDataContractImporter() { }
        public XsdDataContractImporter(System.CodeDom.CodeCompileUnit codeCompileUnit) { }
        public System.CodeDom.CodeCompileUnit CodeCompileUnit { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        public System.Runtime.Serialization.ImportOptions Options { get { throw null; } set { } }
        public bool CanImport(System.Xml.Schema.XmlSchemaSet schemas) { throw null; }
        public bool CanImport(System.Xml.Schema.XmlSchemaSet schemas, System.Collections.Generic.ICollection<System.Xml.XmlQualifiedName> typeNames) { throw null; }
        public bool CanImport(System.Xml.Schema.XmlSchemaSet schemas, System.Xml.Schema.XmlSchemaElement element) { throw null; }
        public bool CanImport(System.Xml.Schema.XmlSchemaSet schemas, System.Xml.XmlQualifiedName typeName) { throw null; }
        public System.CodeDom.CodeTypeReference GetCodeTypeReference(System.Xml.XmlQualifiedName typeName) { throw null; }
        [System.MonoTODOAttribute("use element argument and fill Nullable etc.")]
        public System.CodeDom.CodeTypeReference GetCodeTypeReference(System.Xml.XmlQualifiedName typeName, System.Xml.Schema.XmlSchemaElement element) { throw null; }
        public System.Collections.Generic.ICollection<System.CodeDom.CodeTypeReference> GetKnownTypeReferences(System.Xml.XmlQualifiedName typeName) { throw null; }
        public void Import(System.Xml.Schema.XmlSchemaSet schemas) { }
        public void Import(System.Xml.Schema.XmlSchemaSet schemas, System.Collections.Generic.ICollection<System.Xml.XmlQualifiedName> typeNames) { }
        public System.Xml.XmlQualifiedName Import(System.Xml.Schema.XmlSchemaSet schemas, System.Xml.Schema.XmlSchemaElement element) { throw null; }
        public void Import(System.Xml.Schema.XmlSchemaSet schemas, System.Xml.XmlQualifiedName typeName) { }
    }
}
namespace System.Runtime.Serialization.Configuration
{
    public sealed partial class DataContractSerializerSection : System.Configuration.ConfigurationSection
    {
        public DataContractSerializerSection() { }
        [System.Configuration.ConfigurationPropertyAttribute("declaredTypes", DefaultValue=null)]
        public System.Runtime.Serialization.Configuration.DeclaredTypeElementCollection DeclaredTypes { get { throw null; } }
        protected override System.Configuration.ConfigurationPropertyCollection Properties { get { throw null; } }
    }
    [System.MonoTODOAttribute]
    public sealed partial class DeclaredTypeElement : System.Configuration.ConfigurationElement
    {
        public DeclaredTypeElement() { }
        public DeclaredTypeElement(string typeName) { }
        [System.Configuration.ConfigurationPropertyAttribute("", DefaultValue=null, Options=(System.Configuration.ConfigurationPropertyOptions)(1))]
        public System.Runtime.Serialization.Configuration.TypeElementCollection KnownTypes { get { throw null; } }
        protected override System.Configuration.ConfigurationPropertyCollection Properties { get { throw null; } }
        [System.Configuration.ConfigurationPropertyAttribute("type", DefaultValue="", Options=(System.Configuration.ConfigurationPropertyOptions)(4))]
        public string Type { get { throw null; } set { } }
        protected override void PostDeserialize() { }
    }
    [System.Configuration.ConfigurationCollectionAttribute(typeof(System.Runtime.Serialization.Configuration.DeclaredTypeElement))]
    public sealed partial class DeclaredTypeElementCollection : System.Configuration.ConfigurationElementCollection
    {
        public DeclaredTypeElementCollection() { }
        public System.Runtime.Serialization.Configuration.DeclaredTypeElement this[int index] { get { throw null; } set { } }
        public new System.Runtime.Serialization.Configuration.DeclaredTypeElement this[string typeName] { get { throw null; } set { } }
        public void Add(System.Runtime.Serialization.Configuration.DeclaredTypeElement element) { }
        public void Clear() { }
        public bool Contains(string typeName) { throw null; }
        protected override System.Configuration.ConfigurationElement CreateNewElement() { throw null; }
        protected override object GetElementKey(System.Configuration.ConfigurationElement element) { throw null; }
        public int IndexOf(System.Runtime.Serialization.Configuration.DeclaredTypeElement element) { throw null; }
        public void Remove(System.Runtime.Serialization.Configuration.DeclaredTypeElement element) { }
        public void Remove(string typeName) { }
        public void RemoveAt(int index) { }
    }
    public sealed partial class ParameterElement : System.Configuration.ConfigurationElement
    {
        public ParameterElement() { }
        public ParameterElement(int index) { }
        public ParameterElement(string typeName) { }
        [System.Configuration.ConfigurationPropertyAttribute("index", DefaultValue=0)]
        [System.Configuration.IntegerValidatorAttribute(MinValue=0)]
        public int Index { get { throw null; } set { } }
        [System.Configuration.ConfigurationPropertyAttribute("", DefaultValue=null, Options=(System.Configuration.ConfigurationPropertyOptions)(1))]
        public System.Runtime.Serialization.Configuration.ParameterElementCollection Parameters { get { throw null; } }
        protected override System.Configuration.ConfigurationPropertyCollection Properties { get { throw null; } }
        [System.Configuration.ConfigurationPropertyAttribute("type", DefaultValue="")]
        [System.Configuration.StringValidatorAttribute(MinLength=0)]
        public string Type { get { throw null; } set { } }
        protected override void PostDeserialize() { }
        protected override void PreSerialize(System.Xml.XmlWriter writer) { }
    }
    [System.Configuration.ConfigurationCollectionAttribute(typeof(System.Runtime.Serialization.Configuration.ParameterElement), AddItemName="parameter", CollectionType=(System.Configuration.ConfigurationElementCollectionType)(0))]
    public sealed partial class ParameterElementCollection : System.Configuration.ConfigurationElementCollection
    {
        public ParameterElementCollection() { }
        public override System.Configuration.ConfigurationElementCollectionType CollectionType { get { throw null; } }
        protected override string ElementName { get { throw null; } }
        public System.Runtime.Serialization.Configuration.ParameterElement this[int index] { get { throw null; } set { } }
        public void Add(System.Runtime.Serialization.Configuration.ParameterElement element) { }
        public void Clear() { }
        public bool Contains(string typeName) { throw null; }
        protected override System.Configuration.ConfigurationElement CreateNewElement() { throw null; }
        protected override object GetElementKey(System.Configuration.ConfigurationElement element) { throw null; }
        public int IndexOf(System.Runtime.Serialization.Configuration.ParameterElement element) { throw null; }
        public void Remove(System.Runtime.Serialization.Configuration.ParameterElement element) { }
        public void RemoveAt(int index) { }
    }
    public sealed partial class SerializationSectionGroup : System.Configuration.ConfigurationSectionGroup
    {
        public SerializationSectionGroup() { }
        public System.Runtime.Serialization.Configuration.DataContractSerializerSection DataContractSerializer { get { throw null; } }
        public static System.Runtime.Serialization.Configuration.SerializationSectionGroup GetSectionGroup(System.Configuration.Configuration config) { throw null; }
    }
    public sealed partial class TypeElement : System.Configuration.ConfigurationElement
    {
        public TypeElement() { }
        public TypeElement(string typeName) { }
        [System.Configuration.ConfigurationPropertyAttribute("index", DefaultValue=0)]
        [System.Configuration.IntegerValidatorAttribute(MinValue=0)]
        public int Index { get { throw null; } set { } }
        [System.Configuration.ConfigurationPropertyAttribute("", DefaultValue=null, Options=(System.Configuration.ConfigurationPropertyOptions)(1))]
        public System.Runtime.Serialization.Configuration.ParameterElementCollection Parameters { get { throw null; } }
        protected override System.Configuration.ConfigurationPropertyCollection Properties { get { throw null; } }
        [System.Configuration.ConfigurationPropertyAttribute("type", DefaultValue="")]
        [System.Configuration.StringValidatorAttribute(MinLength=0)]
        public string Type { get { throw null; } set { } }
        protected override void Reset(System.Configuration.ConfigurationElement parentElement) { }
    }
    [System.Configuration.ConfigurationCollectionAttribute(typeof(System.Runtime.Serialization.Configuration.TypeElement), CollectionType=(System.Configuration.ConfigurationElementCollectionType)(0))]
    public sealed partial class TypeElementCollection : System.Configuration.ConfigurationElementCollection
    {
        public TypeElementCollection() { }
        public override System.Configuration.ConfigurationElementCollectionType CollectionType { get { throw null; } }
        protected override string ElementName { get { throw null; } }
        public System.Runtime.Serialization.Configuration.TypeElement this[int index] { get { throw null; } set { } }
        public void Add(System.Runtime.Serialization.Configuration.TypeElement element) { }
        public void Clear() { }
        protected override System.Configuration.ConfigurationElement CreateNewElement() { throw null; }
        protected override object GetElementKey(System.Configuration.ConfigurationElement element) { throw null; }
        public int IndexOf(System.Runtime.Serialization.Configuration.TypeElement element) { throw null; }
        public void Remove(System.Runtime.Serialization.Configuration.TypeElement element) { }
        public void RemoveAt(int index) { }
    }
}
namespace System.Runtime.Serialization.Json
{
    public sealed partial class DataContractJsonSerializer : System.Runtime.Serialization.XmlObjectSerializer
    {
        public DataContractJsonSerializer(System.Type type) { }
        public DataContractJsonSerializer(System.Type type, System.Collections.Generic.IEnumerable<System.Type> knownTypes) { }
        public DataContractJsonSerializer(System.Type type, System.Collections.Generic.IEnumerable<System.Type> knownTypes, int maxItemsInObjectGraph, bool ignoreExtensionDataObject, System.Runtime.Serialization.IDataContractSurrogate dataContractSurrogate, bool alwaysEmitTypeInformation) { }
        public DataContractJsonSerializer(System.Type type, string rootName) { }
        public DataContractJsonSerializer(System.Type type, string rootName, System.Collections.Generic.IEnumerable<System.Type> knownTypes) { }
        public DataContractJsonSerializer(System.Type type, string rootName, System.Collections.Generic.IEnumerable<System.Type> knownTypes, int maxItemsInObjectGraph, bool ignoreExtensionDataObject, System.Runtime.Serialization.IDataContractSurrogate dataContractSurrogate, bool alwaysEmitTypeInformation) { }
        public DataContractJsonSerializer(System.Type type, System.Xml.XmlDictionaryString rootName) { }
        public DataContractJsonSerializer(System.Type type, System.Xml.XmlDictionaryString rootName, System.Collections.Generic.IEnumerable<System.Type> knownTypes) { }
        public DataContractJsonSerializer(System.Type type, System.Xml.XmlDictionaryString rootName, System.Collections.Generic.IEnumerable<System.Type> knownTypes, int maxItemsInObjectGraph, bool ignoreExtensionDataObject, System.Runtime.Serialization.IDataContractSurrogate dataContractSurrogate, bool alwaysEmitTypeInformation) { }
        [System.MonoTODOAttribute]
        public System.Runtime.Serialization.IDataContractSurrogate DataContractSurrogate { get { throw null; } }
        [System.MonoTODOAttribute]
        public bool IgnoreExtensionDataObject { get { throw null; } }
        [System.MonoTODOAttribute]
        public System.Collections.ObjectModel.ReadOnlyCollection<System.Type> KnownTypes { get { throw null; } }
        public int MaxItemsInObjectGraph { get { throw null; } }
        public override bool IsStartObject(System.Xml.XmlDictionaryReader reader) { throw null; }
        public override bool IsStartObject(System.Xml.XmlReader reader) { throw null; }
        public override object ReadObject(System.IO.Stream stream) { throw null; }
        public override object ReadObject(System.Xml.XmlDictionaryReader reader) { throw null; }
        public override object ReadObject(System.Xml.XmlDictionaryReader reader, bool verifyObjectName) { throw null; }
        public override object ReadObject(System.Xml.XmlReader reader) { throw null; }
        public override object ReadObject(System.Xml.XmlReader reader, bool verifyObjectName) { throw null; }
        public override void WriteEndObject(System.Xml.XmlDictionaryWriter writer) { }
        public override void WriteEndObject(System.Xml.XmlWriter writer) { }
        public override void WriteObject(System.IO.Stream stream, object graph) { }
        public override void WriteObject(System.Xml.XmlDictionaryWriter writer, object graph) { }
        public override void WriteObject(System.Xml.XmlWriter writer, object graph) { }
        public override void WriteObjectContent(System.Xml.XmlDictionaryWriter writer, object graph) { }
        public override void WriteObjectContent(System.Xml.XmlWriter writer, object graph) { }
        public override void WriteStartObject(System.Xml.XmlDictionaryWriter writer, object graph) { }
        public override void WriteStartObject(System.Xml.XmlWriter writer, object graph) { }
    }
    public partial interface IXmlJsonReaderInitializer
    {
        void SetInput(byte[] buffer, int offset, int count, System.Text.Encoding encoding, System.Xml.XmlDictionaryReaderQuotas quotas, System.Xml.OnXmlDictionaryReaderClose onClose);
        void SetInput(System.IO.Stream stream, System.Text.Encoding encoding, System.Xml.XmlDictionaryReaderQuotas quotas, System.Xml.OnXmlDictionaryReaderClose onClose);
    }
    public partial interface IXmlJsonWriterInitializer
    {
        void SetOutput(System.IO.Stream stream, System.Text.Encoding encoding, bool ownsStream);
    }
    public static partial class JsonReaderWriterFactory
    {
        public static System.Xml.XmlDictionaryReader CreateJsonReader(byte[] buffer, int offset, int count, System.Text.Encoding encoding, System.Xml.XmlDictionaryReaderQuotas quotas, System.Xml.OnXmlDictionaryReaderClose onClose) { throw null; }
        public static System.Xml.XmlDictionaryReader CreateJsonReader(byte[] buffer, int offset, int count, System.Xml.XmlDictionaryReaderQuotas quotas) { throw null; }
        public static System.Xml.XmlDictionaryReader CreateJsonReader(byte[] buffer, System.Xml.XmlDictionaryReaderQuotas quotas) { throw null; }
        public static System.Xml.XmlDictionaryReader CreateJsonReader(System.IO.Stream stream, System.Text.Encoding encoding, System.Xml.XmlDictionaryReaderQuotas quotas, System.Xml.OnXmlDictionaryReaderClose onClose) { throw null; }
        public static System.Xml.XmlDictionaryReader CreateJsonReader(System.IO.Stream stream, System.Xml.XmlDictionaryReaderQuotas quotas) { throw null; }
        public static System.Xml.XmlDictionaryWriter CreateJsonWriter(System.IO.Stream stream) { throw null; }
        public static System.Xml.XmlDictionaryWriter CreateJsonWriter(System.IO.Stream stream, System.Text.Encoding encoding) { throw null; }
        public static System.Xml.XmlDictionaryWriter CreateJsonWriter(System.IO.Stream stream, System.Text.Encoding encoding, bool ownsStream) { throw null; }
    }
}
namespace System.Xml
{
    public partial interface IFragmentCapableXmlDictionaryWriter
    {
        bool CanFragment { get; }
        void EndFragment();
        void StartFragment(System.IO.Stream stream, bool generateSelfContainedTextFragment);
        void WriteFragment(byte[] buffer, int offset, int count);
    }
    public partial interface IStreamProvider
    {
        System.IO.Stream GetStream();
        void ReleaseStream(System.IO.Stream stream);
    }
    public partial interface IXmlBinaryReaderInitializer
    {
        void SetInput(byte[] buffer, int offset, int count, System.Xml.IXmlDictionary dictionary, System.Xml.XmlDictionaryReaderQuotas quota, System.Xml.XmlBinaryReaderSession session, System.Xml.OnXmlDictionaryReaderClose onClose);
        void SetInput(System.IO.Stream stream, System.Xml.IXmlDictionary dictionary, System.Xml.XmlDictionaryReaderQuotas quota, System.Xml.XmlBinaryReaderSession session, System.Xml.OnXmlDictionaryReaderClose onClose);
    }
    public partial interface IXmlBinaryWriterInitializer
    {
        void SetOutput(System.IO.Stream stream, System.Xml.IXmlDictionary dictionary, System.Xml.XmlBinaryWriterSession session, bool ownsStream);
    }
    public partial interface IXmlDictionary
    {
        bool TryLookup(int key, out System.Xml.XmlDictionaryString result);
        bool TryLookup(string value, out System.Xml.XmlDictionaryString result);
        bool TryLookup(System.Xml.XmlDictionaryString value, out System.Xml.XmlDictionaryString result);
    }
    public partial interface IXmlMtomReaderInitializer
    {
        void SetInput(byte[] buffer, int offset, int count, System.Text.Encoding[] encodings, string contentType, System.Xml.XmlDictionaryReaderQuotas quotas, int maxBufferSize, System.Xml.OnXmlDictionaryReaderClose onClose);
        void SetInput(System.IO.Stream stream, System.Text.Encoding[] encodings, string contentType, System.Xml.XmlDictionaryReaderQuotas quotas, int maxBufferSize, System.Xml.OnXmlDictionaryReaderClose onClose);
    }
    public partial interface IXmlMtomWriterInitializer
    {
        void SetOutput(System.IO.Stream stream, System.Text.Encoding encoding, int maxSizeInBytes, string startInfo, string boundary, string startUri, bool writeMessageHeaders, bool ownsStream);
    }
    public partial interface IXmlTextReaderInitializer
    {
        void SetInput(byte[] buffer, int offset, int count, System.Text.Encoding encoding, System.Xml.XmlDictionaryReaderQuotas quota, System.Xml.OnXmlDictionaryReaderClose onClose);
        void SetInput(System.IO.Stream stream, System.Text.Encoding encoding, System.Xml.XmlDictionaryReaderQuotas quota, System.Xml.OnXmlDictionaryReaderClose onClose);
    }
    public partial interface IXmlTextWriterInitializer
    {
        void SetOutput(System.IO.Stream stream, System.Text.Encoding encoding, bool ownsStream);
    }
    public delegate void OnXmlDictionaryReaderClose(System.Xml.XmlDictionaryReader reader);
    public partial class UniqueId
    {
        public UniqueId() { }
        public UniqueId(byte[] id) { }
        [System.Security.SecurityCriticalAttribute]
        [System.Security.SecurityTreatAsSafeAttribute]
        public UniqueId(byte[] id, int offset) { }
        [System.Security.SecurityCriticalAttribute]
        [System.Security.SecurityTreatAsSafeAttribute]
        public UniqueId(char[] id, int offset, int count) { }
        public UniqueId(System.Guid id) { }
        [System.Security.SecurityCriticalAttribute]
        [System.Security.SecurityTreatAsSafeAttribute]
        public UniqueId(string value) { }
        public int CharArrayLength { [System.Security.SecurityCriticalAttribute, System.Security.SecurityTreatAsSafeAttribute]get { throw null; } }
        public bool IsGuid { get { throw null; } }
        public override bool Equals(object obj) { throw null; }
        [System.MonoTODOAttribute("Determine semantics when IsGuid==true")]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(System.Xml.UniqueId id1, System.Xml.UniqueId id2) { throw null; }
        public static bool operator !=(System.Xml.UniqueId id1, System.Xml.UniqueId id2) { throw null; }
        [System.Security.SecurityCriticalAttribute]
        [System.Security.SecurityTreatAsSafeAttribute]
        public int ToCharArray(char[] array, int offset) { throw null; }
        [System.Security.SecurityCriticalAttribute]
        [System.Security.SecurityTreatAsSafeAttribute]
        public override string ToString() { throw null; }
        [System.Security.SecurityCriticalAttribute]
        [System.Security.SecurityTreatAsSafeAttribute]
        public bool TryGetGuid(byte[] buffer, int offset) { throw null; }
        public bool TryGetGuid(out System.Guid guid) { guid = default(System.Guid); throw null; }
    }
    public partial class XmlBinaryReaderSession : System.Xml.IXmlDictionary
    {
        public XmlBinaryReaderSession() { }
        public System.Xml.XmlDictionaryString Add(int id, string value) { throw null; }
        public void Clear() { }
        public bool TryLookup(int key, out System.Xml.XmlDictionaryString result) { result = default(System.Xml.XmlDictionaryString); throw null; }
        public bool TryLookup(string value, out System.Xml.XmlDictionaryString result) { result = default(System.Xml.XmlDictionaryString); throw null; }
        public bool TryLookup(System.Xml.XmlDictionaryString value, out System.Xml.XmlDictionaryString result) { result = default(System.Xml.XmlDictionaryString); throw null; }
    }
    public partial class XmlBinaryWriterSession
    {
        public XmlBinaryWriterSession() { }
        public void Reset() { }
        public virtual bool TryAdd(System.Xml.XmlDictionaryString value, out int key) { key = default(int); throw null; }
    }
    public partial class XmlDictionary : System.Xml.IXmlDictionary
    {
        public XmlDictionary() { }
        public XmlDictionary(int capacity) { }
        public static System.Xml.IXmlDictionary Empty { get { throw null; } }
        public virtual System.Xml.XmlDictionaryString Add(string value) { throw null; }
        public virtual bool TryLookup(int key, out System.Xml.XmlDictionaryString result) { result = default(System.Xml.XmlDictionaryString); throw null; }
        public virtual bool TryLookup(string value, out System.Xml.XmlDictionaryString result) { result = default(System.Xml.XmlDictionaryString); throw null; }
        public virtual bool TryLookup(System.Xml.XmlDictionaryString value, out System.Xml.XmlDictionaryString result) { result = default(System.Xml.XmlDictionaryString); throw null; }
    }
    public abstract partial class XmlDictionaryReader : System.Xml.XmlReader
    {
        protected XmlDictionaryReader() { }
        public virtual bool CanCanonicalize { get { throw null; } }
        public virtual System.Xml.XmlDictionaryReaderQuotas Quotas { get { throw null; } }
        public static System.Xml.XmlDictionaryReader CreateBinaryReader(byte[] buffer, int offset, int count, System.Xml.IXmlDictionary dictionary, System.Xml.XmlDictionaryReaderQuotas quotas) { throw null; }
        public static System.Xml.XmlDictionaryReader CreateBinaryReader(byte[] buffer, int offset, int count, System.Xml.IXmlDictionary dictionary, System.Xml.XmlDictionaryReaderQuotas quotas, System.Xml.XmlBinaryReaderSession session) { throw null; }
        public static System.Xml.XmlDictionaryReader CreateBinaryReader(byte[] buffer, int offset, int count, System.Xml.IXmlDictionary dictionary, System.Xml.XmlDictionaryReaderQuotas quotas, System.Xml.XmlBinaryReaderSession session, System.Xml.OnXmlDictionaryReaderClose onClose) { throw null; }
        public static System.Xml.XmlDictionaryReader CreateBinaryReader(byte[] buffer, int offset, int count, System.Xml.XmlDictionaryReaderQuotas quotas) { throw null; }
        public static System.Xml.XmlDictionaryReader CreateBinaryReader(byte[] buffer, System.Xml.XmlDictionaryReaderQuotas quotas) { throw null; }
        public static System.Xml.XmlDictionaryReader CreateBinaryReader(System.IO.Stream stream, System.Xml.IXmlDictionary dictionary, System.Xml.XmlDictionaryReaderQuotas quotas) { throw null; }
        public static System.Xml.XmlDictionaryReader CreateBinaryReader(System.IO.Stream stream, System.Xml.IXmlDictionary dictionary, System.Xml.XmlDictionaryReaderQuotas quotas, System.Xml.XmlBinaryReaderSession session) { throw null; }
        public static System.Xml.XmlDictionaryReader CreateBinaryReader(System.IO.Stream stream, System.Xml.IXmlDictionary dictionary, System.Xml.XmlDictionaryReaderQuotas quotas, System.Xml.XmlBinaryReaderSession session, System.Xml.OnXmlDictionaryReaderClose onClose) { throw null; }
        public static System.Xml.XmlDictionaryReader CreateBinaryReader(System.IO.Stream stream, System.Xml.XmlDictionaryReaderQuotas quotas) { throw null; }
        public static System.Xml.XmlDictionaryReader CreateDictionaryReader(System.Xml.XmlReader reader) { throw null; }
        public static System.Xml.XmlDictionaryReader CreateMtomReader(byte[] buffer, int offset, int count, System.Text.Encoding encoding, System.Xml.XmlDictionaryReaderQuotas quotas) { throw null; }
        public static System.Xml.XmlDictionaryReader CreateMtomReader(byte[] buffer, int offset, int count, System.Text.Encoding[] encodings, string contentType, System.Xml.XmlDictionaryReaderQuotas quotas) { throw null; }
        public static System.Xml.XmlDictionaryReader CreateMtomReader(byte[] buffer, int offset, int count, System.Text.Encoding[] encodings, string contentType, System.Xml.XmlDictionaryReaderQuotas quotas, int maxBufferSize, System.Xml.OnXmlDictionaryReaderClose onClose) { throw null; }
        public static System.Xml.XmlDictionaryReader CreateMtomReader(byte[] buffer, int offset, int count, System.Text.Encoding[] encodings, System.Xml.XmlDictionaryReaderQuotas quotas) { throw null; }
        public static System.Xml.XmlDictionaryReader CreateMtomReader(System.IO.Stream stream, System.Text.Encoding encoding, System.Xml.XmlDictionaryReaderQuotas quotas) { throw null; }
        public static System.Xml.XmlDictionaryReader CreateMtomReader(System.IO.Stream stream, System.Text.Encoding[] encodings, string contentType, System.Xml.XmlDictionaryReaderQuotas quotas) { throw null; }
        public static System.Xml.XmlDictionaryReader CreateMtomReader(System.IO.Stream stream, System.Text.Encoding[] encodings, string contentType, System.Xml.XmlDictionaryReaderQuotas quotas, int maxBufferSize, System.Xml.OnXmlDictionaryReaderClose onClose) { throw null; }
        public static System.Xml.XmlDictionaryReader CreateMtomReader(System.IO.Stream stream, System.Text.Encoding[] encodings, System.Xml.XmlDictionaryReaderQuotas quotas) { throw null; }
        public static System.Xml.XmlDictionaryReader CreateTextReader(byte[] buffer, int offset, int count, System.Text.Encoding encoding, System.Xml.XmlDictionaryReaderQuotas quotas, System.Xml.OnXmlDictionaryReaderClose onClose) { throw null; }
        public static System.Xml.XmlDictionaryReader CreateTextReader(byte[] buffer, int offset, int count, System.Xml.XmlDictionaryReaderQuotas quotas) { throw null; }
        public static System.Xml.XmlDictionaryReader CreateTextReader(byte[] buffer, System.Xml.XmlDictionaryReaderQuotas quotas) { throw null; }
        public static System.Xml.XmlDictionaryReader CreateTextReader(System.IO.Stream stream, System.Text.Encoding encoding, System.Xml.XmlDictionaryReaderQuotas quotas, System.Xml.OnXmlDictionaryReaderClose onClose) { throw null; }
        public static System.Xml.XmlDictionaryReader CreateTextReader(System.IO.Stream stream, System.Xml.XmlDictionaryReaderQuotas quotas) { throw null; }
        public virtual void EndCanonicalization() { }
        public virtual string GetAttribute(System.Xml.XmlDictionaryString localName, System.Xml.XmlDictionaryString namespaceUri) { throw null; }
        public virtual int IndexOfLocalName(string[] localNames, string namespaceUri) { throw null; }
        public virtual int IndexOfLocalName(System.Xml.XmlDictionaryString[] localNames, System.Xml.XmlDictionaryString namespaceUri) { throw null; }
        public virtual bool IsArray(out System.Type type) { type = default(System.Type); throw null; }
        public virtual bool IsLocalName(string localName) { throw null; }
        public virtual bool IsLocalName(System.Xml.XmlDictionaryString localName) { throw null; }
        public virtual bool IsNamespaceUri(string namespaceUri) { throw null; }
        public virtual bool IsNamespaceUri(System.Xml.XmlDictionaryString namespaceUri) { throw null; }
        public virtual bool IsStartArray(out System.Type type) { type = default(System.Type); throw null; }
        public virtual bool IsStartElement(System.Xml.XmlDictionaryString localName, System.Xml.XmlDictionaryString namespaceUri) { throw null; }
        protected bool IsTextNode(System.Xml.XmlNodeType nodeType) { throw null; }
        public virtual void MoveToStartElement() { }
        public virtual void MoveToStartElement(string name) { }
        public virtual void MoveToStartElement(string localName, string namespaceUri) { }
        public virtual void MoveToStartElement(System.Xml.XmlDictionaryString localName, System.Xml.XmlDictionaryString namespaceUri) { }
        public virtual int ReadArray(string localName, string namespaceUri, bool[] array, int offset, int length) { throw null; }
        public virtual int ReadArray(string localName, string namespaceUri, System.DateTime[] array, int offset, int length) { throw null; }
        public virtual int ReadArray(string localName, string namespaceUri, decimal[] array, int offset, int length) { throw null; }
        public virtual int ReadArray(string localName, string namespaceUri, double[] array, int offset, int length) { throw null; }
        public virtual int ReadArray(string localName, string namespaceUri, System.Guid[] array, int offset, int length) { throw null; }
        public virtual int ReadArray(string localName, string namespaceUri, short[] array, int offset, int length) { throw null; }
        public virtual int ReadArray(string localName, string namespaceUri, int[] array, int offset, int length) { throw null; }
        public virtual int ReadArray(string localName, string namespaceUri, long[] array, int offset, int length) { throw null; }
        public virtual int ReadArray(string localName, string namespaceUri, float[] array, int offset, int length) { throw null; }
        public virtual int ReadArray(string localName, string namespaceUri, System.TimeSpan[] array, int offset, int length) { throw null; }
        public virtual int ReadArray(System.Xml.XmlDictionaryString localName, System.Xml.XmlDictionaryString namespaceUri, bool[] array, int offset, int length) { throw null; }
        public virtual int ReadArray(System.Xml.XmlDictionaryString localName, System.Xml.XmlDictionaryString namespaceUri, System.DateTime[] array, int offset, int length) { throw null; }
        public virtual int ReadArray(System.Xml.XmlDictionaryString localName, System.Xml.XmlDictionaryString namespaceUri, decimal[] array, int offset, int length) { throw null; }
        public virtual int ReadArray(System.Xml.XmlDictionaryString localName, System.Xml.XmlDictionaryString namespaceUri, double[] array, int offset, int length) { throw null; }
        public virtual int ReadArray(System.Xml.XmlDictionaryString localName, System.Xml.XmlDictionaryString namespaceUri, System.Guid[] array, int offset, int length) { throw null; }
        public virtual int ReadArray(System.Xml.XmlDictionaryString localName, System.Xml.XmlDictionaryString namespaceUri, short[] array, int offset, int length) { throw null; }
        public virtual int ReadArray(System.Xml.XmlDictionaryString localName, System.Xml.XmlDictionaryString namespaceUri, int[] array, int offset, int length) { throw null; }
        public virtual int ReadArray(System.Xml.XmlDictionaryString localName, System.Xml.XmlDictionaryString namespaceUri, long[] array, int offset, int length) { throw null; }
        public virtual int ReadArray(System.Xml.XmlDictionaryString localName, System.Xml.XmlDictionaryString namespaceUri, float[] array, int offset, int length) { throw null; }
        public virtual int ReadArray(System.Xml.XmlDictionaryString localName, System.Xml.XmlDictionaryString namespaceUri, System.TimeSpan[] array, int offset, int length) { throw null; }
        public virtual bool[] ReadBooleanArray(string localName, string namespaceUri) { throw null; }
        public virtual bool[] ReadBooleanArray(System.Xml.XmlDictionaryString localName, System.Xml.XmlDictionaryString namespaceUri) { throw null; }
        public override object ReadContentAs(System.Type type, System.Xml.IXmlNamespaceResolver nsResolver) { throw null; }
        public virtual byte[] ReadContentAsBase64() { throw null; }
        public virtual byte[] ReadContentAsBinHex() { throw null; }
        protected byte[] ReadContentAsBinHex(int maxByteArrayContentLength) { throw null; }
        [System.MonoTODOAttribute]
        public virtual int ReadContentAsChars(char[] chars, int offset, int count) { throw null; }
        public override decimal ReadContentAsDecimal() { throw null; }
        public override float ReadContentAsFloat() { throw null; }
        public virtual System.Guid ReadContentAsGuid() { throw null; }
        public virtual void ReadContentAsQualifiedName(out string localName, out string namespaceUri) { localName = default(string); namespaceUri = default(string); }
        public override string ReadContentAsString() { throw null; }
        [System.MonoTODOAttribute]
        protected string ReadContentAsString(int maxStringContentLength) { throw null; }
        [System.MonoTODOAttribute("there is exactly no information on the web")]
        public virtual string ReadContentAsString(string[] strings, out int index) { index = default(int); throw null; }
        [System.MonoTODOAttribute("there is exactly no information on the web")]
        public virtual string ReadContentAsString(System.Xml.XmlDictionaryString[] strings, out int index) { index = default(int); throw null; }
        public virtual System.TimeSpan ReadContentAsTimeSpan() { throw null; }
        public virtual System.Xml.UniqueId ReadContentAsUniqueId() { throw null; }
        public virtual System.DateTime[] ReadDateTimeArray(string localName, string namespaceUri) { throw null; }
        public virtual System.DateTime[] ReadDateTimeArray(System.Xml.XmlDictionaryString localName, System.Xml.XmlDictionaryString namespaceUri) { throw null; }
        public virtual decimal[] ReadDecimalArray(string localName, string namespaceUri) { throw null; }
        public virtual decimal[] ReadDecimalArray(System.Xml.XmlDictionaryString localName, System.Xml.XmlDictionaryString namespaceUri) { throw null; }
        public virtual double[] ReadDoubleArray(string localName, string namespaceUri) { throw null; }
        public virtual double[] ReadDoubleArray(System.Xml.XmlDictionaryString localName, System.Xml.XmlDictionaryString namespaceUri) { throw null; }
        public virtual byte[] ReadElementContentAsBase64() { throw null; }
        public virtual byte[] ReadElementContentAsBinHex() { throw null; }
        public override bool ReadElementContentAsBoolean() { throw null; }
        public override System.DateTime ReadElementContentAsDateTime() { throw null; }
        public override decimal ReadElementContentAsDecimal() { throw null; }
        public override double ReadElementContentAsDouble() { throw null; }
        public override float ReadElementContentAsFloat() { throw null; }
        public virtual System.Guid ReadElementContentAsGuid() { throw null; }
        public override int ReadElementContentAsInt() { throw null; }
        public override long ReadElementContentAsLong() { throw null; }
        public override string ReadElementContentAsString() { throw null; }
        public virtual System.TimeSpan ReadElementContentAsTimeSpan() { throw null; }
        public virtual System.Xml.UniqueId ReadElementContentAsUniqueId() { throw null; }
        public virtual void ReadFullStartElement() { }
        public virtual void ReadFullStartElement(string name) { }
        public virtual void ReadFullStartElement(string localName, string namespaceUri) { }
        public virtual void ReadFullStartElement(System.Xml.XmlDictionaryString localName, System.Xml.XmlDictionaryString namespaceUri) { }
        public virtual System.Guid[] ReadGuidArray(string localName, string namespaceUri) { throw null; }
        public virtual System.Guid[] ReadGuidArray(System.Xml.XmlDictionaryString localName, System.Xml.XmlDictionaryString namespaceUri) { throw null; }
        public virtual short[] ReadInt16Array(string localName, string namespaceUri) { throw null; }
        public virtual short[] ReadInt16Array(System.Xml.XmlDictionaryString localName, System.Xml.XmlDictionaryString namespaceUri) { throw null; }
        public virtual int[] ReadInt32Array(string localName, string namespaceUri) { throw null; }
        public virtual int[] ReadInt32Array(System.Xml.XmlDictionaryString localName, System.Xml.XmlDictionaryString namespaceUri) { throw null; }
        public virtual long[] ReadInt64Array(string localName, string namespaceUri) { throw null; }
        public virtual long[] ReadInt64Array(System.Xml.XmlDictionaryString localName, System.Xml.XmlDictionaryString namespaceUri) { throw null; }
        public virtual float[] ReadSingleArray(string localName, string namespaceUri) { throw null; }
        public virtual float[] ReadSingleArray(System.Xml.XmlDictionaryString localName, System.Xml.XmlDictionaryString namespaceUri) { throw null; }
        public virtual void ReadStartElement(System.Xml.XmlDictionaryString localName, System.Xml.XmlDictionaryString namespaceUri) { }
        public override string ReadString() { throw null; }
        [System.MonoTODOAttribute]
        protected string ReadString(int maxStringContentLength) { throw null; }
        public virtual System.TimeSpan[] ReadTimeSpanArray(string localName, string namespaceUri) { throw null; }
        public virtual System.TimeSpan[] ReadTimeSpanArray(System.Xml.XmlDictionaryString localName, System.Xml.XmlDictionaryString namespaceUri) { throw null; }
        public virtual int ReadValueAsBase64(byte[] bytes, int start, int length) { throw null; }
        public virtual void StartCanonicalization(System.IO.Stream stream, bool includeComments, string[] inclusivePrefixes) { }
        public virtual bool TryGetArrayLength(out int count) { count = default(int); throw null; }
        public virtual bool TryGetBase64ContentLength(out int count) { count = default(int); throw null; }
        public virtual bool TryGetLocalNameAsDictionaryString(out System.Xml.XmlDictionaryString localName) { localName = default(System.Xml.XmlDictionaryString); throw null; }
        public virtual bool TryGetNamespaceUriAsDictionaryString(out System.Xml.XmlDictionaryString namespaceUri) { namespaceUri = default(System.Xml.XmlDictionaryString); throw null; }
        public virtual bool TryGetValueAsDictionaryString(out System.Xml.XmlDictionaryString value) { value = default(System.Xml.XmlDictionaryString); throw null; }
    }
    public sealed partial class XmlDictionaryReaderQuotas
    {
        public XmlDictionaryReaderQuotas() { }
        public static System.Xml.XmlDictionaryReaderQuotas Max { get { throw null; } }
        public int MaxArrayLength { get { throw null; } set { } }
        public int MaxBytesPerRead { get { throw null; } set { } }
        public int MaxDepth { get { throw null; } set { } }
        public int MaxNameTableCharCount { get { throw null; } set { } }
        public int MaxStringContentLength { get { throw null; } set { } }
        public void CopyTo(System.Xml.XmlDictionaryReaderQuotas quota) { }
    }
    public partial class XmlDictionaryString
    {
        public XmlDictionaryString(System.Xml.IXmlDictionary dictionary, string value, int key) { }
        public System.Xml.IXmlDictionary Dictionary { get { throw null; } }
        public static System.Xml.XmlDictionaryString Empty { get { throw null; } }
        public int Key { get { throw null; } }
        public string Value { get { throw null; } }
        public override string ToString() { throw null; }
    }
    public abstract partial class XmlDictionaryWriter : System.Xml.XmlWriter
    {
        protected XmlDictionaryWriter() { }
        public virtual bool CanCanonicalize { get { throw null; } }
        public static System.Xml.XmlDictionaryWriter CreateBinaryWriter(System.IO.Stream stream) { throw null; }
        public static System.Xml.XmlDictionaryWriter CreateBinaryWriter(System.IO.Stream stream, System.Xml.IXmlDictionary dictionary) { throw null; }
        public static System.Xml.XmlDictionaryWriter CreateBinaryWriter(System.IO.Stream stream, System.Xml.IXmlDictionary dictionary, System.Xml.XmlBinaryWriterSession session) { throw null; }
        public static System.Xml.XmlDictionaryWriter CreateBinaryWriter(System.IO.Stream stream, System.Xml.IXmlDictionary dictionary, System.Xml.XmlBinaryWriterSession session, bool ownsStream) { throw null; }
        public static System.Xml.XmlDictionaryWriter CreateDictionaryWriter(System.Xml.XmlWriter writer) { throw null; }
        public static System.Xml.XmlDictionaryWriter CreateMtomWriter(System.IO.Stream stream, System.Text.Encoding encoding, int maxSizeInBytes, string startInfo) { throw null; }
        public static System.Xml.XmlDictionaryWriter CreateMtomWriter(System.IO.Stream stream, System.Text.Encoding encoding, int maxSizeInBytes, string startInfo, string boundary, string startUri, bool writeMessageHeaders, bool ownsStream) { throw null; }
        public static System.Xml.XmlDictionaryWriter CreateTextWriter(System.IO.Stream stream) { throw null; }
        public static System.Xml.XmlDictionaryWriter CreateTextWriter(System.IO.Stream stream, System.Text.Encoding encoding) { throw null; }
        public static System.Xml.XmlDictionaryWriter CreateTextWriter(System.IO.Stream stream, System.Text.Encoding encoding, bool ownsStream) { throw null; }
        public virtual void EndCanonicalization() { }
        public virtual void StartCanonicalization(System.IO.Stream stream, bool includeComments, string[] inclusivePrefixes) { }
        public virtual void WriteArray(string prefix, string localName, string namespaceUri, bool[] array, int offset, int length) { }
        public virtual void WriteArray(string prefix, string localName, string namespaceUri, System.DateTime[] array, int offset, int length) { }
        public virtual void WriteArray(string prefix, string localName, string namespaceUri, decimal[] array, int offset, int length) { }
        public virtual void WriteArray(string prefix, string localName, string namespaceUri, double[] array, int offset, int length) { }
        public virtual void WriteArray(string prefix, string localName, string namespaceUri, System.Guid[] array, int offset, int length) { }
        public virtual void WriteArray(string prefix, string localName, string namespaceUri, short[] array, int offset, int length) { }
        public virtual void WriteArray(string prefix, string localName, string namespaceUri, int[] array, int offset, int length) { }
        public virtual void WriteArray(string prefix, string localName, string namespaceUri, long[] array, int offset, int length) { }
        public virtual void WriteArray(string prefix, string localName, string namespaceUri, float[] array, int offset, int length) { }
        public virtual void WriteArray(string prefix, string localName, string namespaceUri, System.TimeSpan[] array, int offset, int length) { }
        public virtual void WriteArray(string prefix, System.Xml.XmlDictionaryString localName, System.Xml.XmlDictionaryString namespaceUri, bool[] array, int offset, int length) { }
        public virtual void WriteArray(string prefix, System.Xml.XmlDictionaryString localName, System.Xml.XmlDictionaryString namespaceUri, System.DateTime[] array, int offset, int length) { }
        public virtual void WriteArray(string prefix, System.Xml.XmlDictionaryString localName, System.Xml.XmlDictionaryString namespaceUri, decimal[] array, int offset, int length) { }
        public virtual void WriteArray(string prefix, System.Xml.XmlDictionaryString localName, System.Xml.XmlDictionaryString namespaceUri, double[] array, int offset, int length) { }
        public virtual void WriteArray(string prefix, System.Xml.XmlDictionaryString localName, System.Xml.XmlDictionaryString namespaceUri, System.Guid[] array, int offset, int length) { }
        public virtual void WriteArray(string prefix, System.Xml.XmlDictionaryString localName, System.Xml.XmlDictionaryString namespaceUri, short[] array, int offset, int length) { }
        public virtual void WriteArray(string prefix, System.Xml.XmlDictionaryString localName, System.Xml.XmlDictionaryString namespaceUri, int[] array, int offset, int length) { }
        public virtual void WriteArray(string prefix, System.Xml.XmlDictionaryString localName, System.Xml.XmlDictionaryString namespaceUri, long[] array, int offset, int length) { }
        public virtual void WriteArray(string prefix, System.Xml.XmlDictionaryString localName, System.Xml.XmlDictionaryString namespaceUri, float[] array, int offset, int length) { }
        public virtual void WriteArray(string prefix, System.Xml.XmlDictionaryString localName, System.Xml.XmlDictionaryString namespaceUri, System.TimeSpan[] array, int offset, int length) { }
        public void WriteAttributeString(string prefix, System.Xml.XmlDictionaryString localName, System.Xml.XmlDictionaryString namespaceUri, string value) { }
        public void WriteAttributeString(System.Xml.XmlDictionaryString localName, System.Xml.XmlDictionaryString namespaceUri, string value) { }
        public void WriteElementString(string prefix, System.Xml.XmlDictionaryString localName, System.Xml.XmlDictionaryString namespaceUri, string value) { }
        public void WriteElementString(System.Xml.XmlDictionaryString localName, System.Xml.XmlDictionaryString namespaceUri, string value) { }
        public virtual void WriteNode(System.Xml.XmlDictionaryReader reader, bool defattr) { }
        public override void WriteNode(System.Xml.XmlReader reader, bool defattr) { }
        public virtual void WriteQualifiedName(System.Xml.XmlDictionaryString localName, System.Xml.XmlDictionaryString namespaceUri) { }
        public virtual void WriteStartAttribute(string prefix, System.Xml.XmlDictionaryString localName, System.Xml.XmlDictionaryString namespaceUri) { }
        public void WriteStartAttribute(System.Xml.XmlDictionaryString localName, System.Xml.XmlDictionaryString namespaceUri) { }
        public virtual void WriteStartElement(string prefix, System.Xml.XmlDictionaryString localName, System.Xml.XmlDictionaryString namespaceUri) { }
        public void WriteStartElement(System.Xml.XmlDictionaryString localName, System.Xml.XmlDictionaryString namespaceUri) { }
        public virtual void WriteString(System.Xml.XmlDictionaryString value) { }
        protected virtual void WriteTextNode(System.Xml.XmlDictionaryReader reader, bool isAttribute) { }
        public virtual void WriteValue(System.Guid guid) { }
        public virtual void WriteValue(System.TimeSpan duration) { }
        public virtual void WriteValue(System.Xml.IStreamProvider value) { }
        public virtual void WriteValue(System.Xml.UniqueId id) { }
        public virtual void WriteValue(System.Xml.XmlDictionaryString value) { }
        public virtual void WriteXmlAttribute(string localName, string value) { }
        public virtual void WriteXmlAttribute(System.Xml.XmlDictionaryString localName, System.Xml.XmlDictionaryString value) { }
        public virtual void WriteXmlnsAttribute(string prefix, string namespaceUri) { }
        public virtual void WriteXmlnsAttribute(string prefix, System.Xml.XmlDictionaryString namespaceUri) { }
    }
}
