// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

[assembly:System.Reflection.AssemblyVersionAttribute("4.0.0.0")]
[assembly:System.CLSCompliantAttribute(true)]
[assembly:System.Diagnostics.DebuggableAttribute((System.Diagnostics.DebuggableAttribute.DebuggingModes)(2))]
[assembly:System.Reflection.AssemblyCompanyAttribute("Mono development team")]
[assembly:System.Reflection.AssemblyCopyrightAttribute("(c) Various Mono authors")]
[assembly:System.Reflection.AssemblyDefaultAliasAttribute("System.Web.Services.dll")]
[assembly:System.Reflection.AssemblyDescriptionAttribute("System.Web.Services.dll")]
[assembly:System.Reflection.AssemblyFileVersionAttribute("4.7.2046.0")]
[assembly:System.Reflection.AssemblyInformationalVersionAttribute("4.7.2046.0")]
[assembly:System.Reflection.AssemblyProductAttribute("Mono Common Language Infrastructure")]
[assembly:System.Reflection.AssemblyTitleAttribute("System.Web.Services.dll")]
[assembly:System.Resources.NeutralResourcesLanguageAttribute("en-US")]
[assembly:System.Resources.SatelliteContractVersionAttribute("4.0.0.0")]
[assembly:System.Runtime.CompilerServices.CompilationRelaxationsAttribute(8)]
[assembly:System.Runtime.CompilerServices.ReferenceAssemblyAttribute]
[assembly:System.Runtime.CompilerServices.RuntimeCompatibilityAttribute(WrapNonExceptionThrows=true)]
[assembly:System.Runtime.InteropServices.ComVisibleAttribute(false)]
[assembly:System.Runtime.InteropServices.DefaultDllImportSearchPathsAttribute((System.Runtime.InteropServices.DllImportSearchPath)(2050))]
[assembly:System.Security.AllowPartiallyTrustedCallersAttribute]
[assembly:System.Security.SecurityRulesAttribute((System.Security.SecurityRuleSet)(1), SkipVerificationInFullTrust=true)]
namespace System.Web.Services
{
    [System.AttributeUsageAttribute((System.AttributeTargets)(64))]
    public sealed partial class WebMethodAttribute : System.Attribute
    {
        public WebMethodAttribute() { }
        public WebMethodAttribute(bool enableSession) { }
        public WebMethodAttribute(bool enableSession, System.EnterpriseServices.TransactionOption transactionOption) { }
        public WebMethodAttribute(bool enableSession, System.EnterpriseServices.TransactionOption transactionOption, int cacheDuration) { }
        public WebMethodAttribute(bool enableSession, System.EnterpriseServices.TransactionOption transactionOption, int cacheDuration, bool bufferResponse) { }
        public bool BufferResponse { get { throw null; } set { } }
        public int CacheDuration { get { throw null; } set { } }
        public string Description { get { throw null; } set { } }
        public bool EnableSession { get { throw null; } set { } }
        public string MessageName { get { throw null; } set { } }
        public System.EnterpriseServices.TransactionOption TransactionOption { get { throw null; } set { } }
    }
    public partial class WebService : System.ComponentModel.MarshalByValueComponent
    {
        public WebService() { }
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.DescriptionAttribute("The ASP.NET application object for the current request.")]
        [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(0))]
        public System.Web.HttpApplicationState Application { [System.Web.AspNetHostingPermissionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Level=(System.Web.AspNetHostingPermissionLevel)(200))]get { throw null; } }
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(0))]
        public System.Web.HttpContext Context { [System.Web.AspNetHostingPermissionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Level=(System.Web.AspNetHostingPermissionLevel)(200))]get { throw null; } }
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(0))]
        public System.Web.HttpServerUtility Server { [System.Web.AspNetHostingPermissionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Level=(System.Web.AspNetHostingPermissionLevel)(200))]get { throw null; } }
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(0))]
        public System.Web.SessionState.HttpSessionState Session { [System.Web.AspNetHostingPermissionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Level=(System.Web.AspNetHostingPermissionLevel)(200))]get { throw null; } }
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(0))]
        [System.Runtime.InteropServices.ComVisibleAttribute(false)]
        public System.Web.Services.Protocols.SoapProtocolVersion SoapVersion { [System.Web.AspNetHostingPermissionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Level=(System.Web.AspNetHostingPermissionLevel)(200))]get { throw null; } }
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(0))]
        public System.Security.Principal.IPrincipal User { [System.Web.AspNetHostingPermissionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Level=(System.Web.AspNetHostingPermissionLevel)(200))]get { throw null; } }
    }
    [System.AttributeUsageAttribute((System.AttributeTargets)(1028))]
    public sealed partial class WebServiceAttribute : System.Attribute
    {
        public const string DefaultNamespace = "http://tempuri.org/";
        public WebServiceAttribute() { }
        public string Description { get { throw null; } set { } }
        public string Name { get { throw null; } set { } }
        public string Namespace { get { throw null; } set { } }
    }
    [System.AttributeUsageAttribute((System.AttributeTargets)(1028), AllowMultiple=true)]
    public sealed partial class WebServiceBindingAttribute : System.Attribute
    {
        public WebServiceBindingAttribute() { }
        public WebServiceBindingAttribute(string name) { }
        public WebServiceBindingAttribute(string name, string ns) { }
        public WebServiceBindingAttribute(string name, string ns, string location) { }
        public System.Web.Services.WsiProfiles ConformsTo { get { throw null; } set { } }
        public bool EmitConformanceClaims { get { throw null; } set { } }
        public string Location { get { throw null; } set { } }
        public string Name { get { throw null; } set { } }
        public string Namespace { get { throw null; } set { } }
    }
    [System.FlagsAttribute]
    public enum WsiProfiles
    {
        BasicProfile1_1 = 1,
        None = 0,
    }
}
namespace System.Web.Services.Configuration
{
    public sealed partial class DiagnosticsElement : System.Configuration.ConfigurationElement
    {
        public DiagnosticsElement() { }
        protected override System.Configuration.ConfigurationPropertyCollection Properties { get { throw null; } }
        [System.Configuration.ConfigurationPropertyAttribute("suppressReturningExceptions", DefaultValue=false)]
        public bool SuppressReturningExceptions { get { throw null; } set { } }
    }
    public enum PriorityGroup
    {
        High = 0,
        Low = 1,
    }
    public sealed partial class ProtocolElement : System.Configuration.ConfigurationElement
    {
        public ProtocolElement() { }
        public ProtocolElement(System.Web.Services.Configuration.WebServiceProtocols protocol) { }
        [System.Configuration.ConfigurationPropertyAttribute("name", IsKey=true, DefaultValue=(System.Web.Services.Configuration.WebServiceProtocols)(0))]
        public System.Web.Services.Configuration.WebServiceProtocols Name { get { throw null; } set { } }
        protected override System.Configuration.ConfigurationPropertyCollection Properties { get { throw null; } }
    }
    [System.Configuration.ConfigurationCollectionAttribute(typeof(System.Web.Services.Configuration.ProtocolElement))]
    public sealed partial class ProtocolElementCollection : System.Configuration.ConfigurationElementCollection
    {
        public ProtocolElementCollection() { }
        public System.Web.Services.Configuration.ProtocolElement this[int index] { get { throw null; } set { } }
        public System.Web.Services.Configuration.ProtocolElement this[object key] { get { throw null; } set { } }
        public void Add(System.Web.Services.Configuration.ProtocolElement element) { }
        public void Clear() { }
        public bool ContainsKey(object key) { throw null; }
        public void CopyTo(System.Web.Services.Configuration.ProtocolElement[] array, int index) { }
        protected override System.Configuration.ConfigurationElement CreateNewElement() { throw null; }
        protected override object GetElementKey(System.Configuration.ConfigurationElement element) { throw null; }
        public int IndexOf(System.Web.Services.Configuration.ProtocolElement element) { throw null; }
        public void Remove(System.Web.Services.Configuration.ProtocolElement element) { }
        public void RemoveAt(int index) { }
        public void RemoveAt(object key) { }
    }
    public sealed partial class SoapEnvelopeProcessingElement : System.Configuration.ConfigurationElement
    {
        public SoapEnvelopeProcessingElement() { }
        public SoapEnvelopeProcessingElement(int readTimeout) { }
        public SoapEnvelopeProcessingElement(int readTimeout, bool strict) { }
        [System.Configuration.ConfigurationPropertyAttribute("strict", DefaultValue=false)]
        public bool IsStrict { get { throw null; } set { } }
        protected override System.Configuration.ConfigurationPropertyCollection Properties { get { throw null; } }
        [System.ComponentModel.TypeConverterAttribute(typeof(System.Configuration.InfiniteIntConverter))]
        [System.Configuration.ConfigurationPropertyAttribute("readTimeout", DefaultValue=2147483647)]
        public int ReadTimeout { get { throw null; } set { } }
    }
    public sealed partial class SoapExtensionTypeElement : System.Configuration.ConfigurationElement
    {
        public SoapExtensionTypeElement() { }
        public SoapExtensionTypeElement(string type, int priority, System.Web.Services.Configuration.PriorityGroup group) { }
        public SoapExtensionTypeElement(System.Type type, int priority, System.Web.Services.Configuration.PriorityGroup group) { }
        [System.Configuration.ConfigurationPropertyAttribute("group", IsKey=true, DefaultValue=(System.Web.Services.Configuration.PriorityGroup)(1))]
        public System.Web.Services.Configuration.PriorityGroup Group { get { throw null; } set { } }
        [System.Configuration.ConfigurationPropertyAttribute("priority", IsKey=true, DefaultValue=0)]
        [System.Configuration.IntegerValidatorAttribute(MinValue=0)]
        public int Priority { get { throw null; } set { } }
        protected override System.Configuration.ConfigurationPropertyCollection Properties { get { throw null; } }
        [System.ComponentModel.TypeConverterAttribute("System.Web.Services.Configuration.TypeTypeConverter")]
        [System.Configuration.ConfigurationPropertyAttribute("type", IsKey=true)]
        public System.Type Type { get { throw null; } set { } }
    }
    [System.Configuration.ConfigurationCollectionAttribute(typeof(System.Web.Services.Configuration.SoapExtensionTypeElement))]
    public sealed partial class SoapExtensionTypeElementCollection : System.Configuration.ConfigurationElementCollection
    {
        public SoapExtensionTypeElementCollection() { }
        public System.Web.Services.Configuration.SoapExtensionTypeElement this[int index] { get { throw null; } set { } }
        public System.Web.Services.Configuration.SoapExtensionTypeElement this[object key] { get { throw null; } set { } }
        public void Add(System.Web.Services.Configuration.SoapExtensionTypeElement element) { }
        public void Clear() { }
        public bool ContainsKey(object key) { throw null; }
        public void CopyTo(System.Web.Services.Configuration.SoapExtensionTypeElement[] array, int index) { }
        protected override System.Configuration.ConfigurationElement CreateNewElement() { throw null; }
        protected override object GetElementKey(System.Configuration.ConfigurationElement element) { throw null; }
        public int IndexOf(System.Web.Services.Configuration.SoapExtensionTypeElement element) { throw null; }
        public void Remove(System.Web.Services.Configuration.SoapExtensionTypeElement element) { }
        public void RemoveAt(int index) { }
        public void RemoveAt(object key) { }
    }
    public sealed partial class TypeElement : System.Configuration.ConfigurationElement
    {
        public TypeElement() { }
        public TypeElement(string type) { }
        public TypeElement(System.Type type) { }
        protected override System.Configuration.ConfigurationPropertyCollection Properties { get { throw null; } }
        [System.ComponentModel.TypeConverterAttribute("System.Web.Services.Configuration.TypeAndNameConverter")]
        [System.Configuration.ConfigurationPropertyAttribute("type", IsKey=true)]
        public System.Type Type { get { throw null; } set { } }
    }
    [System.Configuration.ConfigurationCollectionAttribute(typeof(System.Web.Services.Configuration.TypeElement))]
    public sealed partial class TypeElementCollection : System.Configuration.ConfigurationElementCollection
    {
        public TypeElementCollection() { }
        public System.Web.Services.Configuration.TypeElement this[int index] { get { throw null; } set { } }
        public System.Web.Services.Configuration.TypeElement this[object key] { get { throw null; } set { } }
        public void Add(System.Web.Services.Configuration.TypeElement element) { }
        public void Clear() { }
        public bool ContainsKey(object key) { throw null; }
        public void CopyTo(System.Web.Services.Configuration.TypeElement[] array, int index) { }
        protected override System.Configuration.ConfigurationElement CreateNewElement() { throw null; }
        protected override object GetElementKey(System.Configuration.ConfigurationElement element) { throw null; }
        public int IndexOf(System.Web.Services.Configuration.TypeElement element) { throw null; }
        public void Remove(System.Web.Services.Configuration.TypeElement element) { }
        public void RemoveAt(int index) { }
        public void RemoveAt(object key) { }
    }
    [System.FlagsAttribute]
    public enum WebServiceProtocols
    {
        AnyHttpSoap = 33,
        Documentation = 8,
        HttpGet = 2,
        HttpPost = 4,
        HttpPostLocalhost = 16,
        HttpSoap = 1,
        HttpSoap12 = 32,
        Unknown = 0,
    }
    public sealed partial class WebServicesSection : System.Configuration.ConfigurationSection
    {
        public WebServicesSection() { }
        [System.Configuration.ConfigurationPropertyAttribute("conformanceWarnings")]
        public System.Web.Services.Configuration.WsiProfilesElementCollection ConformanceWarnings { get { throw null; } }
        public static System.Web.Services.Configuration.WebServicesSection Current { get { throw null; } }
        public System.Web.Services.Configuration.DiagnosticsElement Diagnostics { get { throw null; } set { } }
        public System.Web.Services.Configuration.WebServiceProtocols EnabledProtocols { get { throw null; } }
        protected override System.Configuration.ConfigurationPropertyCollection Properties { get { throw null; } }
        [System.Configuration.ConfigurationPropertyAttribute("protocols")]
        public System.Web.Services.Configuration.ProtocolElementCollection Protocols { get { throw null; } }
        [System.Configuration.ConfigurationPropertyAttribute("serviceDescriptionFormatExtensionTypes")]
        public System.Web.Services.Configuration.TypeElementCollection ServiceDescriptionFormatExtensionTypes { get { throw null; } }
        [System.Configuration.ConfigurationPropertyAttribute("soapEnvelopeProcessing")]
        public System.Web.Services.Configuration.SoapEnvelopeProcessingElement SoapEnvelopeProcessing { get { throw null; } set { } }
        [System.Configuration.ConfigurationPropertyAttribute("soapExtensionImporterTypes")]
        public System.Web.Services.Configuration.TypeElementCollection SoapExtensionImporterTypes { get { throw null; } }
        [System.Configuration.ConfigurationPropertyAttribute("soapExtensionReflectorTypes")]
        public System.Web.Services.Configuration.TypeElementCollection SoapExtensionReflectorTypes { get { throw null; } }
        [System.Configuration.ConfigurationPropertyAttribute("soapExtensionTypes")]
        public System.Web.Services.Configuration.SoapExtensionTypeElementCollection SoapExtensionTypes { get { throw null; } }
        [System.Configuration.ConfigurationPropertyAttribute("soapServerProtocolFactory")]
        public System.Web.Services.Configuration.TypeElement SoapServerProtocolFactoryType { get { throw null; } }
        [System.Configuration.ConfigurationPropertyAttribute("soapTransportImporterTypes")]
        public System.Web.Services.Configuration.TypeElementCollection SoapTransportImporterTypes { get { throw null; } }
        [System.Configuration.ConfigurationPropertyAttribute("wsdlHelpGenerator")]
        public System.Web.Services.Configuration.WsdlHelpGeneratorElement WsdlHelpGenerator { get { throw null; } }
        [System.Configuration.ConfigurationPermissionAttribute(System.Security.Permissions.SecurityAction.Assert, Unrestricted=true)]
        public static System.Web.Services.Configuration.WebServicesSection GetSection(System.Configuration.Configuration config) { throw null; }
        protected override void InitializeDefault() { }
        protected override void Reset(System.Configuration.ConfigurationElement parentElement) { }
    }
    public sealed partial class WsdlHelpGeneratorElement : System.Configuration.ConfigurationElement
    {
        public WsdlHelpGeneratorElement() { }
        [System.Configuration.ConfigurationPropertyAttribute("href", IsRequired=true)]
        public string Href { get { throw null; } set { } }
        protected override System.Configuration.ConfigurationPropertyCollection Properties { get { throw null; } }
        protected override void DeserializeElement(System.Xml.XmlReader reader, bool serializeCollectionKey) { }
        protected override void Reset(System.Configuration.ConfigurationElement parentElement) { }
    }
    public sealed partial class WsiProfilesElement : System.Configuration.ConfigurationElement
    {
        public WsiProfilesElement() { }
        public WsiProfilesElement(System.Web.Services.WsiProfiles name) { }
        [System.Configuration.ConfigurationPropertyAttribute("name", IsKey=true, DefaultValue=(System.Web.Services.WsiProfiles)(0))]
        public System.Web.Services.WsiProfiles Name { get { throw null; } set { } }
        protected override System.Configuration.ConfigurationPropertyCollection Properties { get { throw null; } }
    }
    [System.Configuration.ConfigurationCollectionAttribute(typeof(System.Web.Services.Configuration.WsiProfilesElement))]
    public sealed partial class WsiProfilesElementCollection : System.Configuration.ConfigurationElementCollection
    {
        public WsiProfilesElementCollection() { }
        public System.Web.Services.Configuration.WsiProfilesElement this[int index] { get { throw null; } set { } }
        public System.Web.Services.Configuration.WsiProfilesElement this[object key] { get { throw null; } set { } }
        public void Add(System.Web.Services.Configuration.WsiProfilesElement element) { }
        public void Clear() { }
        public bool ContainsKey(object key) { throw null; }
        public void CopyTo(System.Web.Services.Configuration.WsiProfilesElement[] array, int index) { }
        protected override System.Configuration.ConfigurationElement CreateNewElement() { throw null; }
        protected override object GetElementKey(System.Configuration.ConfigurationElement element) { throw null; }
        public int IndexOf(System.Web.Services.Configuration.WsiProfilesElement element) { throw null; }
        public void Remove(System.Web.Services.Configuration.WsiProfilesElement element) { }
        public void RemoveAt(int index) { }
        public void RemoveAt(object key) { }
    }
    [System.AttributeUsageAttribute((System.AttributeTargets)(4))]
    public sealed partial class XmlFormatExtensionAttribute : System.Attribute
    {
        public XmlFormatExtensionAttribute() { }
        public XmlFormatExtensionAttribute(string elementName, string ns, System.Type extensionPoint1) { }
        public XmlFormatExtensionAttribute(string elementName, string ns, System.Type extensionPoint1, System.Type extensionPoint2) { }
        public XmlFormatExtensionAttribute(string elementName, string ns, System.Type extensionPoint1, System.Type extensionPoint2, System.Type extensionPoint3) { }
        public XmlFormatExtensionAttribute(string elementName, string ns, System.Type extensionPoint1, System.Type extensionPoint2, System.Type extensionPoint3, System.Type extensionPoint4) { }
        public XmlFormatExtensionAttribute(string elementName, string ns, System.Type[] extensionPoints) { }
        public string ElementName { get { throw null; } set { } }
        public System.Type[] ExtensionPoints { get { throw null; } set { } }
        public string Namespace { get { throw null; } set { } }
    }
    [System.AttributeUsageAttribute((System.AttributeTargets)(4))]
    public sealed partial class XmlFormatExtensionPointAttribute : System.Attribute
    {
        public XmlFormatExtensionPointAttribute(string memberName) { }
        public bool AllowElements { get { throw null; } set { } }
        public string MemberName { get { throw null; } set { } }
    }
    [System.AttributeUsageAttribute((System.AttributeTargets)(4), AllowMultiple=true)]
    public sealed partial class XmlFormatExtensionPrefixAttribute : System.Attribute
    {
        public XmlFormatExtensionPrefixAttribute() { }
        public XmlFormatExtensionPrefixAttribute(string prefix, string ns) { }
        public string Namespace { get { throw null; } set { } }
        public string Prefix { get { throw null; } set { } }
    }
}
namespace System.Web.Services.Description
{
    public partial class BasicProfileViolation
    {
        internal BasicProfileViolation() { }
        public System.Web.Services.WsiProfiles Claims { get { throw null; } }
        public string Details { get { throw null; } }
        public System.Collections.Specialized.StringCollection Elements { get { throw null; } }
        public string NormativeStatement { get { throw null; } }
        public string Recommendation { get { throw null; } }
        public override string ToString() { throw null; }
    }
    public partial class BasicProfileViolationCollection : System.Collections.CollectionBase, System.Collections.Generic.IEnumerable<System.Web.Services.Description.BasicProfileViolation>, System.Collections.IEnumerable
    {
        public BasicProfileViolationCollection() { }
        public System.Web.Services.Description.BasicProfileViolation this[int index] { get { throw null; } set { } }
        public bool Contains(System.Web.Services.Description.BasicProfileViolation violation) { throw null; }
        public void CopyTo(System.Web.Services.Description.BasicProfileViolation[] array, int index) { }
        public int IndexOf(System.Web.Services.Description.BasicProfileViolation violation) { throw null; }
        public void Insert(int index, System.Web.Services.Description.BasicProfileViolation violation) { }
        public void Remove(System.Web.Services.Description.BasicProfileViolation violation) { }
        System.Collections.Generic.IEnumerator<System.Web.Services.Description.BasicProfileViolation> System.Collections.Generic.IEnumerable<System.Web.Services.Description.BasicProfileViolation>.GetEnumerator() { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class BasicProfileViolationEnumerator : System.Collections.Generic.IEnumerator<System.Web.Services.Description.BasicProfileViolation>, System.Collections.IEnumerator, System.IDisposable
    {
        public BasicProfileViolationEnumerator(System.Web.Services.Description.BasicProfileViolationCollection list) { }
        public System.Web.Services.Description.BasicProfileViolation Current { get { throw null; } }
        object System.Collections.IEnumerator.Current { get { throw null; } }
        public void Dispose() { }
        public bool MoveNext() { throw null; }
        void System.Collections.IEnumerator.Reset() { }
    }
    [System.Web.Services.Configuration.XmlFormatExtensionPointAttribute("Extensions")]
    public sealed partial class Binding : System.Web.Services.Description.NamedItem
    {
        public Binding() { }
        [System.Xml.Serialization.XmlIgnoreAttribute]
        public override System.Web.Services.Description.ServiceDescriptionFormatExtensionCollection Extensions { get { throw null; } }
        [System.Xml.Serialization.XmlElementAttribute("operation")]
        public System.Web.Services.Description.OperationBindingCollection Operations { get { throw null; } }
        public System.Web.Services.Description.ServiceDescription ServiceDescription { get { throw null; } }
        [System.Xml.Serialization.XmlAttributeAttribute("type")]
        public System.Xml.XmlQualifiedName Type { get { throw null; } set { } }
    }
    public sealed partial class BindingCollection : System.Web.Services.Description.ServiceDescriptionBaseCollection
    {
        internal BindingCollection() { }
        public System.Web.Services.Description.Binding this[int index] { get { throw null; } set { } }
        public System.Web.Services.Description.Binding this[string name] { get { throw null; } }
        public int Add(System.Web.Services.Description.Binding binding) { throw null; }
        public bool Contains(System.Web.Services.Description.Binding binding) { throw null; }
        public void CopyTo(System.Web.Services.Description.Binding[] array, int index) { }
        protected override string GetKey(object value) { throw null; }
        public int IndexOf(System.Web.Services.Description.Binding binding) { throw null; }
        public void Insert(int index, System.Web.Services.Description.Binding binding) { }
        public void Remove(System.Web.Services.Description.Binding binding) { }
        protected override void SetParent(object value, object parent) { }
    }
    public abstract partial class DocumentableItem
    {
        protected DocumentableItem() { }
        [System.Xml.Serialization.XmlIgnoreAttribute]
        public string Documentation { get { throw null; } set { } }
        [System.Runtime.InteropServices.ComVisibleAttribute(false)]
        [System.Xml.Serialization.XmlAnyElementAttribute("documentation", Namespace="http://schemas.xmlsoap.org/wsdl/")]
        public System.Xml.XmlElement DocumentationElement { get { throw null; } set { } }
        [System.Xml.Serialization.XmlAnyAttributeAttribute]
        public System.Xml.XmlAttribute[] ExtensibleAttributes { get { throw null; } set { } }
        [System.Xml.Serialization.XmlIgnoreAttribute]
        public abstract System.Web.Services.Description.ServiceDescriptionFormatExtensionCollection Extensions { get; }
        [System.Xml.Serialization.XmlNamespaceDeclarationsAttribute]
        public System.Xml.Serialization.XmlSerializerNamespaces Namespaces { get { throw null; } set { } }
    }
    [System.Web.Services.Configuration.XmlFormatExtensionPointAttribute("Extensions")]
    public sealed partial class FaultBinding : System.Web.Services.Description.MessageBinding
    {
        public FaultBinding() { }
        [System.Xml.Serialization.XmlIgnoreAttribute]
        public override System.Web.Services.Description.ServiceDescriptionFormatExtensionCollection Extensions { get { throw null; } }
    }
    public sealed partial class FaultBindingCollection : System.Web.Services.Description.ServiceDescriptionBaseCollection
    {
        internal FaultBindingCollection() { }
        public System.Web.Services.Description.FaultBinding this[int index] { get { throw null; } set { } }
        public System.Web.Services.Description.FaultBinding this[string name] { get { throw null; } }
        public int Add(System.Web.Services.Description.FaultBinding bindingOperationFault) { throw null; }
        public bool Contains(System.Web.Services.Description.FaultBinding bindingOperationFault) { throw null; }
        public void CopyTo(System.Web.Services.Description.FaultBinding[] array, int index) { }
        protected override string GetKey(object value) { throw null; }
        public int IndexOf(System.Web.Services.Description.FaultBinding bindingOperationFault) { throw null; }
        public void Insert(int index, System.Web.Services.Description.FaultBinding bindingOperationFault) { }
        public void Remove(System.Web.Services.Description.FaultBinding bindingOperationFault) { }
        protected override void SetParent(object value, object parent) { }
    }
    [System.Web.Services.Configuration.XmlFormatExtensionAttribute("address", "http://schemas.xmlsoap.org/wsdl/http/", typeof(System.Web.Services.Description.Port))]
    public sealed partial class HttpAddressBinding : System.Web.Services.Description.ServiceDescriptionFormatExtension
    {
        public HttpAddressBinding() { }
        [System.Xml.Serialization.XmlAttributeAttribute("location")]
        public string Location { get { throw null; } set { } }
    }
    [System.Web.Services.Configuration.XmlFormatExtensionAttribute("binding", "http://schemas.xmlsoap.org/wsdl/http/", typeof(System.Web.Services.Description.Binding))]
    [System.Web.Services.Configuration.XmlFormatExtensionPrefixAttribute("http", "http://schemas.xmlsoap.org/wsdl/http/")]
    public sealed partial class HttpBinding : System.Web.Services.Description.ServiceDescriptionFormatExtension
    {
        public const string Namespace = "http://schemas.xmlsoap.org/wsdl/http/";
        public HttpBinding() { }
        [System.Xml.Serialization.XmlAttributeAttribute("verb")]
        public string Verb { get { throw null; } set { } }
    }
    [System.Web.Services.Configuration.XmlFormatExtensionAttribute("operation", "http://schemas.xmlsoap.org/wsdl/http/", typeof(System.Web.Services.Description.OperationBinding))]
    public sealed partial class HttpOperationBinding : System.Web.Services.Description.ServiceDescriptionFormatExtension
    {
        public HttpOperationBinding() { }
        [System.Xml.Serialization.XmlAttributeAttribute("location")]
        public string Location { get { throw null; } set { } }
    }
    [System.Web.Services.Configuration.XmlFormatExtensionAttribute("urlEncoded", "http://schemas.xmlsoap.org/wsdl/http/", typeof(System.Web.Services.Description.InputBinding))]
    public sealed partial class HttpUrlEncodedBinding : System.Web.Services.Description.ServiceDescriptionFormatExtension
    {
        public HttpUrlEncodedBinding() { }
    }
    [System.Web.Services.Configuration.XmlFormatExtensionAttribute("urlReplacement", "http://schemas.xmlsoap.org/wsdl/http/", typeof(System.Web.Services.Description.InputBinding))]
    public sealed partial class HttpUrlReplacementBinding : System.Web.Services.Description.ServiceDescriptionFormatExtension
    {
        public HttpUrlReplacementBinding() { }
    }
    [System.Web.Services.Configuration.XmlFormatExtensionPointAttribute("Extensions")]
    public sealed partial class Import : System.Web.Services.Description.DocumentableItem
    {
        public Import() { }
        [System.Xml.Serialization.XmlIgnoreAttribute]
        public override System.Web.Services.Description.ServiceDescriptionFormatExtensionCollection Extensions { get { throw null; } }
        [System.Xml.Serialization.XmlAttributeAttribute("location")]
        public string Location { get { throw null; } set { } }
        [System.Xml.Serialization.XmlAttributeAttribute("namespace")]
        public string Namespace { get { throw null; } set { } }
        public System.Web.Services.Description.ServiceDescription ServiceDescription { get { throw null; } }
    }
    public sealed partial class ImportCollection : System.Web.Services.Description.ServiceDescriptionBaseCollection
    {
        internal ImportCollection() { }
        public System.Web.Services.Description.Import this[int index] { get { throw null; } set { } }
        public int Add(System.Web.Services.Description.Import import) { throw null; }
        public bool Contains(System.Web.Services.Description.Import import) { throw null; }
        public void CopyTo(System.Web.Services.Description.Import[] array, int index) { }
        public int IndexOf(System.Web.Services.Description.Import import) { throw null; }
        public void Insert(int index, System.Web.Services.Description.Import import) { }
        public void Remove(System.Web.Services.Description.Import import) { }
        protected override void SetParent(object value, object parent) { }
    }
    [System.Web.Services.Configuration.XmlFormatExtensionPointAttribute("Extensions")]
    public sealed partial class InputBinding : System.Web.Services.Description.MessageBinding
    {
        public InputBinding() { }
        [System.Xml.Serialization.XmlIgnoreAttribute]
        public override System.Web.Services.Description.ServiceDescriptionFormatExtensionCollection Extensions { get { throw null; } }
    }
    [System.Web.Services.Configuration.XmlFormatExtensionPointAttribute("Extensions")]
    public sealed partial class Message : System.Web.Services.Description.NamedItem
    {
        public Message() { }
        [System.Xml.Serialization.XmlIgnoreAttribute]
        public override System.Web.Services.Description.ServiceDescriptionFormatExtensionCollection Extensions { get { throw null; } }
        [System.Xml.Serialization.XmlElementAttribute("part")]
        public System.Web.Services.Description.MessagePartCollection Parts { get { throw null; } }
        public System.Web.Services.Description.ServiceDescription ServiceDescription { get { throw null; } }
        public System.Web.Services.Description.MessagePart FindPartByName(string partName) { throw null; }
        public System.Web.Services.Description.MessagePart[] FindPartsByName(string[] partNames) { throw null; }
    }
    public abstract partial class MessageBinding : System.Web.Services.Description.NamedItem
    {
        protected MessageBinding() { }
        public System.Web.Services.Description.OperationBinding OperationBinding { get { throw null; } }
    }
    public sealed partial class MessageCollection : System.Web.Services.Description.ServiceDescriptionBaseCollection
    {
        internal MessageCollection() { }
        public System.Web.Services.Description.Message this[int index] { get { throw null; } set { } }
        public System.Web.Services.Description.Message this[string name] { get { throw null; } }
        public int Add(System.Web.Services.Description.Message message) { throw null; }
        public bool Contains(System.Web.Services.Description.Message message) { throw null; }
        public void CopyTo(System.Web.Services.Description.Message[] array, int index) { }
        protected override string GetKey(object value) { throw null; }
        public int IndexOf(System.Web.Services.Description.Message message) { throw null; }
        public void Insert(int index, System.Web.Services.Description.Message message) { }
        public void Remove(System.Web.Services.Description.Message message) { }
        protected override void SetParent(object value, object parent) { }
    }
    [System.Web.Services.Configuration.XmlFormatExtensionPointAttribute("Extensions")]
    public sealed partial class MessagePart : System.Web.Services.Description.NamedItem
    {
        public MessagePart() { }
        [System.Xml.Serialization.XmlAttributeAttribute("element")]
        public System.Xml.XmlQualifiedName Element { get { throw null; } set { } }
        [System.Xml.Serialization.XmlIgnoreAttribute]
        public override System.Web.Services.Description.ServiceDescriptionFormatExtensionCollection Extensions { get { throw null; } }
        public System.Web.Services.Description.Message Message { get { throw null; } }
        [System.Xml.Serialization.XmlAttributeAttribute("type")]
        public System.Xml.XmlQualifiedName Type { get { throw null; } set { } }
    }
    public sealed partial class MessagePartCollection : System.Web.Services.Description.ServiceDescriptionBaseCollection
    {
        internal MessagePartCollection() { }
        public System.Web.Services.Description.MessagePart this[int index] { get { throw null; } set { } }
        public System.Web.Services.Description.MessagePart this[string name] { get { throw null; } }
        public int Add(System.Web.Services.Description.MessagePart messagePart) { throw null; }
        public bool Contains(System.Web.Services.Description.MessagePart messagePart) { throw null; }
        public void CopyTo(System.Web.Services.Description.MessagePart[] array, int index) { }
        protected override string GetKey(object value) { throw null; }
        public int IndexOf(System.Web.Services.Description.MessagePart messagePart) { throw null; }
        public void Insert(int index, System.Web.Services.Description.MessagePart messagePart) { }
        public void Remove(System.Web.Services.Description.MessagePart messagePart) { }
        protected override void SetParent(object value, object parent) { }
    }
    [System.Web.Services.Configuration.XmlFormatExtensionAttribute("content", "http://schemas.xmlsoap.org/wsdl/mime/", typeof(System.Web.Services.Description.MimePart), typeof(System.Web.Services.Description.InputBinding), typeof(System.Web.Services.Description.OutputBinding))]
    [System.Web.Services.Configuration.XmlFormatExtensionPrefixAttribute("mime", "http://schemas.xmlsoap.org/wsdl/mime/")]
    public sealed partial class MimeContentBinding : System.Web.Services.Description.ServiceDescriptionFormatExtension
    {
        public const string Namespace = "http://schemas.xmlsoap.org/wsdl/mime/";
        public MimeContentBinding() { }
        [System.Xml.Serialization.XmlAttributeAttribute("part")]
        public string Part { get { throw null; } set { } }
        [System.Xml.Serialization.XmlAttributeAttribute("type")]
        public string Type { get { throw null; } set { } }
    }
    [System.Web.Services.Configuration.XmlFormatExtensionAttribute("multipartRelated", "http://schemas.xmlsoap.org/wsdl/mime/", typeof(System.Web.Services.Description.InputBinding), typeof(System.Web.Services.Description.OutputBinding))]
    public sealed partial class MimeMultipartRelatedBinding : System.Web.Services.Description.ServiceDescriptionFormatExtension
    {
        public MimeMultipartRelatedBinding() { }
        [System.Xml.Serialization.XmlElementAttribute("part")]
        public System.Web.Services.Description.MimePartCollection Parts { get { throw null; } }
    }
    [System.Web.Services.Configuration.XmlFormatExtensionPointAttribute("Extensions")]
    public sealed partial class MimePart : System.Web.Services.Description.ServiceDescriptionFormatExtension
    {
        public MimePart() { }
        [System.Xml.Serialization.XmlIgnoreAttribute]
        public System.Web.Services.Description.ServiceDescriptionFormatExtensionCollection Extensions { get { throw null; } }
    }
    public sealed partial class MimePartCollection : System.Collections.CollectionBase
    {
        public MimePartCollection() { }
        public System.Web.Services.Description.MimePart this[int index] { get { throw null; } set { } }
        public int Add(System.Web.Services.Description.MimePart mimePart) { throw null; }
        public bool Contains(System.Web.Services.Description.MimePart mimePart) { throw null; }
        public void CopyTo(System.Web.Services.Description.MimePart[] array, int index) { }
        public int IndexOf(System.Web.Services.Description.MimePart mimePart) { throw null; }
        public void Insert(int index, System.Web.Services.Description.MimePart mimePart) { }
        public void Remove(System.Web.Services.Description.MimePart mimePart) { }
    }
    [System.Web.Services.Configuration.XmlFormatExtensionAttribute("text", "http://microsoft.com/wsdl/mime/textMatching/", typeof(System.Web.Services.Description.InputBinding), typeof(System.Web.Services.Description.OutputBinding), typeof(System.Web.Services.Description.MimePart))]
    [System.Web.Services.Configuration.XmlFormatExtensionPrefixAttribute("tm", "http://microsoft.com/wsdl/mime/textMatching/")]
    public sealed partial class MimeTextBinding : System.Web.Services.Description.ServiceDescriptionFormatExtension
    {
        public const string Namespace = "http://microsoft.com/wsdl/mime/textMatching/";
        public MimeTextBinding() { }
        [System.Xml.Serialization.XmlElementAttribute("match", typeof(System.Web.Services.Description.MimeTextMatch))]
        public System.Web.Services.Description.MimeTextMatchCollection Matches { get { throw null; } }
    }
    public sealed partial class MimeTextMatch
    {
        public MimeTextMatch() { }
        [System.ComponentModel.DefaultValueAttribute(0)]
        [System.Xml.Serialization.XmlAttributeAttribute("capture")]
        public int Capture { get { throw null; } set { } }
        [System.ComponentModel.DefaultValueAttribute(1)]
        [System.Xml.Serialization.XmlAttributeAttribute("group")]
        public int Group { get { throw null; } set { } }
        [System.Xml.Serialization.XmlAttributeAttribute("ignoreCase")]
        public bool IgnoreCase { get { throw null; } set { } }
        [System.Xml.Serialization.XmlElementAttribute("match")]
        public System.Web.Services.Description.MimeTextMatchCollection Matches { get { throw null; } }
        [System.Xml.Serialization.XmlAttributeAttribute("name")]
        public string Name { get { throw null; } set { } }
        [System.Xml.Serialization.XmlAttributeAttribute("pattern")]
        public string Pattern { get { throw null; } set { } }
        [System.Xml.Serialization.XmlIgnoreAttribute]
        public int Repeats { get { throw null; } set { } }
        [System.ComponentModel.DefaultValueAttribute("1")]
        [System.Xml.Serialization.XmlAttributeAttribute("repeats")]
        public string RepeatsString { get { throw null; } set { } }
        [System.Xml.Serialization.XmlAttributeAttribute("type")]
        public string Type { get { throw null; } set { } }
    }
    public sealed partial class MimeTextMatchCollection : System.Collections.CollectionBase
    {
        public MimeTextMatchCollection() { }
        public System.Web.Services.Description.MimeTextMatch this[int index] { get { throw null; } set { } }
        public int Add(System.Web.Services.Description.MimeTextMatch match) { throw null; }
        public bool Contains(System.Web.Services.Description.MimeTextMatch match) { throw null; }
        public void CopyTo(System.Web.Services.Description.MimeTextMatch[] array, int index) { }
        public int IndexOf(System.Web.Services.Description.MimeTextMatch match) { throw null; }
        public void Insert(int index, System.Web.Services.Description.MimeTextMatch match) { }
        public void Remove(System.Web.Services.Description.MimeTextMatch match) { }
    }
    [System.Web.Services.Configuration.XmlFormatExtensionAttribute("mimeXml", "http://schemas.xmlsoap.org/wsdl/mime/", typeof(System.Web.Services.Description.MimePart), typeof(System.Web.Services.Description.InputBinding), typeof(System.Web.Services.Description.OutputBinding))]
    public sealed partial class MimeXmlBinding : System.Web.Services.Description.ServiceDescriptionFormatExtension
    {
        public MimeXmlBinding() { }
        [System.Xml.Serialization.XmlAttributeAttribute("part")]
        public string Part { get { throw null; } set { } }
    }
    public abstract partial class NamedItem : System.Web.Services.Description.DocumentableItem
    {
        protected NamedItem() { }
        [System.Xml.Serialization.XmlAttributeAttribute("name")]
        public string Name { get { throw null; } set { } }
    }
    [System.Web.Services.Configuration.XmlFormatExtensionPointAttribute("Extensions")]
    public sealed partial class Operation : System.Web.Services.Description.NamedItem
    {
        public Operation() { }
        [System.Xml.Serialization.XmlIgnoreAttribute]
        public override System.Web.Services.Description.ServiceDescriptionFormatExtensionCollection Extensions { get { throw null; } }
        [System.Xml.Serialization.XmlElementAttribute("fault")]
        public System.Web.Services.Description.OperationFaultCollection Faults { get { throw null; } }
        [System.Xml.Serialization.XmlElementAttribute("input", typeof(System.Web.Services.Description.OperationInput))]
        [System.Xml.Serialization.XmlElementAttribute("output", typeof(System.Web.Services.Description.OperationOutput))]
        public System.Web.Services.Description.OperationMessageCollection Messages { get { throw null; } }
        [System.Xml.Serialization.XmlIgnoreAttribute]
        public string[] ParameterOrder { get { throw null; } set { } }
        [System.ComponentModel.DefaultValueAttribute("")]
        [System.Xml.Serialization.XmlAttributeAttribute("parameterOrder")]
        public string ParameterOrderString { get { throw null; } set { } }
        public System.Web.Services.Description.PortType PortType { get { throw null; } }
        public bool IsBoundBy(System.Web.Services.Description.OperationBinding operationBinding) { throw null; }
    }
    [System.Web.Services.Configuration.XmlFormatExtensionPointAttribute("Extensions")]
    public sealed partial class OperationBinding : System.Web.Services.Description.NamedItem
    {
        public OperationBinding() { }
        public System.Web.Services.Description.Binding Binding { get { throw null; } }
        [System.Xml.Serialization.XmlIgnoreAttribute]
        public override System.Web.Services.Description.ServiceDescriptionFormatExtensionCollection Extensions { get { throw null; } }
        [System.Xml.Serialization.XmlElementAttribute("fault")]
        public System.Web.Services.Description.FaultBindingCollection Faults { get { throw null; } }
        [System.Xml.Serialization.XmlElementAttribute("input")]
        public System.Web.Services.Description.InputBinding Input { get { throw null; } set { } }
        [System.Xml.Serialization.XmlElementAttribute("output")]
        public System.Web.Services.Description.OutputBinding Output { get { throw null; } set { } }
    }
    public sealed partial class OperationBindingCollection : System.Web.Services.Description.ServiceDescriptionBaseCollection
    {
        internal OperationBindingCollection() { }
        public System.Web.Services.Description.OperationBinding this[int index] { get { throw null; } set { } }
        public int Add(System.Web.Services.Description.OperationBinding bindingOperation) { throw null; }
        public bool Contains(System.Web.Services.Description.OperationBinding bindingOperation) { throw null; }
        public void CopyTo(System.Web.Services.Description.OperationBinding[] array, int index) { }
        public int IndexOf(System.Web.Services.Description.OperationBinding bindingOperation) { throw null; }
        public void Insert(int index, System.Web.Services.Description.OperationBinding bindingOperation) { }
        public void Remove(System.Web.Services.Description.OperationBinding bindingOperation) { }
        protected override void SetParent(object value, object parent) { }
    }
    public sealed partial class OperationCollection : System.Web.Services.Description.ServiceDescriptionBaseCollection
    {
        internal OperationCollection() { }
        public System.Web.Services.Description.Operation this[int index] { get { throw null; } set { } }
        public int Add(System.Web.Services.Description.Operation operation) { throw null; }
        public bool Contains(System.Web.Services.Description.Operation operation) { throw null; }
        public void CopyTo(System.Web.Services.Description.Operation[] array, int index) { }
        public int IndexOf(System.Web.Services.Description.Operation operation) { throw null; }
        public void Insert(int index, System.Web.Services.Description.Operation operation) { }
        public void Remove(System.Web.Services.Description.Operation operation) { }
        protected override void SetParent(object value, object parent) { }
    }
    [System.Web.Services.Configuration.XmlFormatExtensionPointAttribute("Extensions")]
    public sealed partial class OperationFault : System.Web.Services.Description.OperationMessage
    {
        public OperationFault() { }
        [System.Xml.Serialization.XmlIgnoreAttribute]
        public override System.Web.Services.Description.ServiceDescriptionFormatExtensionCollection Extensions { get { throw null; } }
    }
    public sealed partial class OperationFaultCollection : System.Web.Services.Description.ServiceDescriptionBaseCollection
    {
        internal OperationFaultCollection() { }
        public System.Web.Services.Description.OperationFault this[int index] { get { throw null; } set { } }
        public System.Web.Services.Description.OperationFault this[string name] { get { throw null; } }
        public int Add(System.Web.Services.Description.OperationFault operationFaultMessage) { throw null; }
        public bool Contains(System.Web.Services.Description.OperationFault operationFaultMessage) { throw null; }
        public void CopyTo(System.Web.Services.Description.OperationFault[] array, int index) { }
        protected override string GetKey(object value) { throw null; }
        public int IndexOf(System.Web.Services.Description.OperationFault operationFaultMessage) { throw null; }
        public void Insert(int index, System.Web.Services.Description.OperationFault operationFaultMessage) { }
        public void Remove(System.Web.Services.Description.OperationFault operationFaultMessage) { }
        protected override void SetParent(object value, object parent) { }
    }
    public enum OperationFlow
    {
        None = 0,
        Notification = 2,
        OneWay = 1,
        RequestResponse = 3,
        SolicitResponse = 4,
    }
    [System.Web.Services.Configuration.XmlFormatExtensionPointAttribute("Extensions")]
    public sealed partial class OperationInput : System.Web.Services.Description.OperationMessage
    {
        public OperationInput() { }
        [System.Xml.Serialization.XmlIgnoreAttribute]
        public override System.Web.Services.Description.ServiceDescriptionFormatExtensionCollection Extensions { get { throw null; } }
    }
    public abstract partial class OperationMessage : System.Web.Services.Description.NamedItem
    {
        protected OperationMessage() { }
        [System.Xml.Serialization.XmlAttributeAttribute("message")]
        public System.Xml.XmlQualifiedName Message { get { throw null; } set { } }
        public System.Web.Services.Description.Operation Operation { get { throw null; } }
    }
    public sealed partial class OperationMessageCollection : System.Web.Services.Description.ServiceDescriptionBaseCollection
    {
        internal OperationMessageCollection() { }
        public System.Web.Services.Description.OperationFlow Flow { get { throw null; } }
        public System.Web.Services.Description.OperationInput Input { get { throw null; } }
        public System.Web.Services.Description.OperationMessage this[int index] { get { throw null; } set { } }
        public System.Web.Services.Description.OperationOutput Output { get { throw null; } }
        public int Add(System.Web.Services.Description.OperationMessage operationMessage) { throw null; }
        public bool Contains(System.Web.Services.Description.OperationMessage operationMessage) { throw null; }
        public void CopyTo(System.Web.Services.Description.OperationMessage[] array, int index) { }
        public int IndexOf(System.Web.Services.Description.OperationMessage operationMessage) { throw null; }
        public void Insert(int index, System.Web.Services.Description.OperationMessage operationMessage) { }
        protected override void OnInsert(int index, object value) { }
        protected override void OnSet(int index, object oldValue, object newValue) { }
        protected override void OnValidate(object value) { }
        public void Remove(System.Web.Services.Description.OperationMessage operationMessage) { }
        protected override void SetParent(object value, object parent) { }
    }
    [System.Web.Services.Configuration.XmlFormatExtensionPointAttribute("Extensions")]
    public sealed partial class OperationOutput : System.Web.Services.Description.OperationMessage
    {
        public OperationOutput() { }
        [System.Xml.Serialization.XmlIgnoreAttribute]
        public override System.Web.Services.Description.ServiceDescriptionFormatExtensionCollection Extensions { get { throw null; } }
    }
    [System.Web.Services.Configuration.XmlFormatExtensionPointAttribute("Extensions")]
    public sealed partial class OutputBinding : System.Web.Services.Description.MessageBinding
    {
        public OutputBinding() { }
        [System.Xml.Serialization.XmlIgnoreAttribute]
        public override System.Web.Services.Description.ServiceDescriptionFormatExtensionCollection Extensions { get { throw null; } }
    }
    [System.Web.Services.Configuration.XmlFormatExtensionPointAttribute("Extensions")]
    public sealed partial class Port : System.Web.Services.Description.NamedItem
    {
        public Port() { }
        [System.Xml.Serialization.XmlAttributeAttribute("binding")]
        public System.Xml.XmlQualifiedName Binding { get { throw null; } set { } }
        [System.Xml.Serialization.XmlIgnoreAttribute]
        public override System.Web.Services.Description.ServiceDescriptionFormatExtensionCollection Extensions { get { throw null; } }
        public System.Web.Services.Description.Service Service { get { throw null; } }
    }
    public sealed partial class PortCollection : System.Web.Services.Description.ServiceDescriptionBaseCollection
    {
        internal PortCollection() { }
        public System.Web.Services.Description.Port this[int index] { get { throw null; } set { } }
        public System.Web.Services.Description.Port this[string name] { get { throw null; } }
        public int Add(System.Web.Services.Description.Port port) { throw null; }
        public bool Contains(System.Web.Services.Description.Port port) { throw null; }
        public void CopyTo(System.Web.Services.Description.Port[] array, int index) { }
        protected override string GetKey(object value) { throw null; }
        public int IndexOf(System.Web.Services.Description.Port port) { throw null; }
        public void Insert(int index, System.Web.Services.Description.Port port) { }
        public void Remove(System.Web.Services.Description.Port port) { }
        protected override void SetParent(object value, object parent) { }
    }
    [System.Web.Services.Configuration.XmlFormatExtensionPointAttribute("Extensions")]
    public sealed partial class PortType : System.Web.Services.Description.NamedItem
    {
        public PortType() { }
        [System.Xml.Serialization.XmlIgnoreAttribute]
        public override System.Web.Services.Description.ServiceDescriptionFormatExtensionCollection Extensions { get { throw null; } }
        [System.Xml.Serialization.XmlElementAttribute("operation")]
        public System.Web.Services.Description.OperationCollection Operations { get { throw null; } }
        public System.Web.Services.Description.ServiceDescription ServiceDescription { get { throw null; } }
    }
    public sealed partial class PortTypeCollection : System.Web.Services.Description.ServiceDescriptionBaseCollection
    {
        internal PortTypeCollection() { }
        public System.Web.Services.Description.PortType this[int index] { get { throw null; } set { } }
        public System.Web.Services.Description.PortType this[string name] { get { throw null; } }
        public int Add(System.Web.Services.Description.PortType portType) { throw null; }
        public bool Contains(System.Web.Services.Description.PortType portType) { throw null; }
        public void CopyTo(System.Web.Services.Description.PortType[] array, int index) { }
        protected override string GetKey(object value) { throw null; }
        public int IndexOf(System.Web.Services.Description.PortType portType) { throw null; }
        public void Insert(int index, System.Web.Services.Description.PortType portType) { }
        public void Remove(System.Web.Services.Description.PortType portType) { }
        protected override void SetParent(object value, object parent) { }
    }
    [System.Security.Permissions.PermissionSetAttribute(System.Security.Permissions.SecurityAction.InheritanceDemand, Name="FullTrust")]
    [System.Security.Permissions.PermissionSetAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Name="FullTrust")]
    public abstract partial class ProtocolImporter
    {
        protected ProtocolImporter() { }
        public System.Xml.Serialization.XmlSchemas AbstractSchemas { get { throw null; } }
        public System.Web.Services.Description.Binding Binding { get { throw null; } }
        public string ClassName { get { throw null; } }
        public System.Xml.Serialization.CodeIdentifiers ClassNames { get { throw null; } }
        public System.CodeDom.CodeNamespace CodeNamespace { get { throw null; } }
        public System.CodeDom.CodeTypeDeclaration CodeTypeDeclaration { get { throw null; } }
        public System.Xml.Serialization.XmlSchemas ConcreteSchemas { get { throw null; } }
        public System.Web.Services.Description.Message InputMessage { get { throw null; } }
        public string MethodName { get { throw null; } }
        public System.Web.Services.Description.Operation Operation { get { throw null; } }
        public System.Web.Services.Description.OperationBinding OperationBinding { get { throw null; } }
        public System.Web.Services.Description.Message OutputMessage { get { throw null; } }
        public System.Web.Services.Description.Port Port { get { throw null; } }
        public System.Web.Services.Description.PortType PortType { get { throw null; } }
        public abstract string ProtocolName { get; }
        public System.Xml.Serialization.XmlSchemas Schemas { get { throw null; } }
        public System.Web.Services.Description.Service Service { get { throw null; } }
        public System.Web.Services.Description.ServiceDescriptionCollection ServiceDescriptions { get { throw null; } }
        public System.Web.Services.Description.ServiceDescriptionImportStyle Style { get { throw null; } }
        public System.Web.Services.Description.ServiceDescriptionImportWarnings Warnings { get { throw null; } set { } }
        public void AddExtensionWarningComments(System.CodeDom.CodeCommentStatementCollection comments, System.Web.Services.Description.ServiceDescriptionFormatExtensionCollection extensions) { }
        protected abstract System.CodeDom.CodeTypeDeclaration BeginClass();
        protected virtual void BeginNamespace() { }
        protected virtual void EndClass() { }
        protected virtual void EndNamespace() { }
        protected abstract System.CodeDom.CodeMemberMethod GenerateMethod();
        protected abstract bool IsBindingSupported();
        protected abstract bool IsOperationFlowSupported(System.Web.Services.Description.OperationFlow flow);
        public System.Exception OperationBindingSyntaxException(string text) { throw null; }
        public System.Exception OperationSyntaxException(string text) { throw null; }
        public void UnsupportedBindingWarning(string text) { }
        public void UnsupportedOperationBindingWarning(string text) { }
        public void UnsupportedOperationWarning(string text) { }
    }
    [System.Security.Permissions.PermissionSetAttribute(System.Security.Permissions.SecurityAction.InheritanceDemand, Name="FullTrust")]
    [System.Security.Permissions.PermissionSetAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Name="FullTrust")]
    public abstract partial class ProtocolReflector
    {
        protected ProtocolReflector() { }
        public System.Web.Services.Description.Binding Binding { get { throw null; } }
        public string DefaultNamespace { get { throw null; } }
        public System.Web.Services.Description.MessageCollection HeaderMessages { get { throw null; } }
        public System.Web.Services.Description.Message InputMessage { get { throw null; } }
        public System.Web.Services.Protocols.LogicalMethodInfo Method { get { throw null; } }
        public System.Web.Services.WebMethodAttribute MethodAttribute { get { throw null; } }
        public System.Web.Services.Protocols.LogicalMethodInfo[] Methods { get { throw null; } }
        public System.Web.Services.Description.Operation Operation { get { throw null; } }
        public System.Web.Services.Description.OperationBinding OperationBinding { get { throw null; } }
        public System.Web.Services.Description.Message OutputMessage { get { throw null; } }
        public System.Web.Services.Description.Port Port { get { throw null; } }
        public System.Web.Services.Description.PortType PortType { get { throw null; } }
        public abstract string ProtocolName { get; }
        public System.Xml.Serialization.XmlReflectionImporter ReflectionImporter { get { throw null; } }
        public System.Xml.Serialization.XmlSchemaExporter SchemaExporter { get { throw null; } }
        public System.Xml.Serialization.XmlSchemas Schemas { get { throw null; } }
        public System.Web.Services.Description.Service Service { get { throw null; } }
        public System.Web.Services.Description.ServiceDescription ServiceDescription { get { throw null; } }
        public System.Web.Services.Description.ServiceDescriptionCollection ServiceDescriptions { get { throw null; } }
        public System.Type ServiceType { get { throw null; } }
        public string ServiceUrl { get { throw null; } }
        protected virtual void BeginClass() { }
        protected virtual void EndClass() { }
        public System.Web.Services.Description.ServiceDescription GetServiceDescription(string ns) { throw null; }
        protected virtual void ReflectDescription() { }
        protected abstract bool ReflectMethod();
        protected virtual string ReflectMethodBinding() { throw null; }
    }
    [System.Web.Services.Configuration.XmlFormatExtensionPointAttribute("Extensions")]
    public sealed partial class Service : System.Web.Services.Description.NamedItem
    {
        public Service() { }
        [System.Xml.Serialization.XmlIgnoreAttribute]
        public override System.Web.Services.Description.ServiceDescriptionFormatExtensionCollection Extensions { get { throw null; } }
        [System.Xml.Serialization.XmlElementAttribute("port")]
        public System.Web.Services.Description.PortCollection Ports { get { throw null; } }
        public System.Web.Services.Description.ServiceDescription ServiceDescription { get { throw null; } }
    }
    public sealed partial class ServiceCollection : System.Web.Services.Description.ServiceDescriptionBaseCollection
    {
        internal ServiceCollection() { }
        public System.Web.Services.Description.Service this[int index] { get { throw null; } set { } }
        public System.Web.Services.Description.Service this[string name] { get { throw null; } }
        public int Add(System.Web.Services.Description.Service service) { throw null; }
        public bool Contains(System.Web.Services.Description.Service service) { throw null; }
        public void CopyTo(System.Web.Services.Description.Service[] array, int index) { }
        protected override string GetKey(object value) { throw null; }
        public int IndexOf(System.Web.Services.Description.Service service) { throw null; }
        public void Insert(int index, System.Web.Services.Description.Service service) { }
        public void Remove(System.Web.Services.Description.Service service) { }
        protected override void SetParent(object value, object parent) { }
    }
    [System.Web.Services.Configuration.XmlFormatExtensionPointAttribute("Extensions")]
    [System.Xml.Serialization.XmlRootAttribute("definitions", Namespace="http://schemas.xmlsoap.org/wsdl/")]
    public sealed partial class ServiceDescription : System.Web.Services.Description.NamedItem
    {
        public const string Namespace = "http://schemas.xmlsoap.org/wsdl/";
        public ServiceDescription() { }
        [System.Xml.Serialization.XmlElementAttribute("binding")]
        public System.Web.Services.Description.BindingCollection Bindings { get { throw null; } }
        [System.Xml.Serialization.XmlIgnoreAttribute]
        public override System.Web.Services.Description.ServiceDescriptionFormatExtensionCollection Extensions { get { throw null; } }
        [System.Xml.Serialization.XmlElementAttribute("import")]
        public System.Web.Services.Description.ImportCollection Imports { get { throw null; } }
        [System.Xml.Serialization.XmlElementAttribute("message")]
        public System.Web.Services.Description.MessageCollection Messages { get { throw null; } }
        [System.Xml.Serialization.XmlElementAttribute("portType")]
        public System.Web.Services.Description.PortTypeCollection PortTypes { get { throw null; } }
        [System.Xml.Serialization.XmlIgnoreAttribute]
        public string RetrievalUrl { get { throw null; } set { } }
        public static System.Xml.Schema.XmlSchema Schema { get { throw null; } }
        [System.Xml.Serialization.XmlIgnoreAttribute]
        public static System.Xml.Serialization.XmlSerializer Serializer { get { throw null; } }
        [System.Xml.Serialization.XmlIgnoreAttribute]
        public System.Web.Services.Description.ServiceDescriptionCollection ServiceDescriptions { get { throw null; } }
        [System.Xml.Serialization.XmlElementAttribute("service")]
        public System.Web.Services.Description.ServiceCollection Services { get { throw null; } }
        [System.Xml.Serialization.XmlAttributeAttribute("targetNamespace")]
        public string TargetNamespace { get { throw null; } set { } }
        [System.Xml.Serialization.XmlElementAttribute("types")]
        public System.Web.Services.Description.Types Types { get { throw null; } set { } }
        [System.Xml.Serialization.XmlIgnoreAttribute]
        public System.Collections.Specialized.StringCollection ValidationWarnings { get { throw null; } }
        public static bool CanRead(System.Xml.XmlReader reader) { throw null; }
        public static System.Web.Services.Description.ServiceDescription Read(System.IO.Stream stream) { throw null; }
        public static System.Web.Services.Description.ServiceDescription Read(System.IO.Stream stream, bool validate) { throw null; }
        public static System.Web.Services.Description.ServiceDescription Read(System.IO.TextReader textReader) { throw null; }
        public static System.Web.Services.Description.ServiceDescription Read(System.IO.TextReader textReader, bool validate) { throw null; }
        public static System.Web.Services.Description.ServiceDescription Read(string fileName) { throw null; }
        public static System.Web.Services.Description.ServiceDescription Read(string fileName, bool validate) { throw null; }
        public static System.Web.Services.Description.ServiceDescription Read(System.Xml.XmlReader reader) { throw null; }
        public static System.Web.Services.Description.ServiceDescription Read(System.Xml.XmlReader reader, bool validate) { throw null; }
        public void Write(System.IO.Stream stream) { }
        public void Write(System.IO.TextWriter writer) { }
        public void Write(string fileName) { }
        public void Write(System.Xml.XmlWriter writer) { }
    }
    public abstract partial class ServiceDescriptionBaseCollection : System.Collections.CollectionBase
    {
        internal ServiceDescriptionBaseCollection() { }
        protected virtual System.Collections.IDictionary Table { get { throw null; } }
        protected virtual string GetKey(object value) { throw null; }
        protected override void OnClear() { }
        protected override void OnInsertComplete(int index, object value) { }
        protected override void OnRemove(int index, object value) { }
        protected override void OnSet(int index, object oldValue, object newValue) { }
        protected virtual void SetParent(object value, object parent) { }
    }
    public sealed partial class ServiceDescriptionCollection : System.Web.Services.Description.ServiceDescriptionBaseCollection
    {
        public ServiceDescriptionCollection() { }
        public System.Web.Services.Description.ServiceDescription this[int index] { get { throw null; } set { } }
        public System.Web.Services.Description.ServiceDescription this[string ns] { get { throw null; } }
        public int Add(System.Web.Services.Description.ServiceDescription serviceDescription) { throw null; }
        public bool Contains(System.Web.Services.Description.ServiceDescription serviceDescription) { throw null; }
        public void CopyTo(System.Web.Services.Description.ServiceDescription[] array, int index) { }
        public System.Web.Services.Description.Binding GetBinding(System.Xml.XmlQualifiedName name) { throw null; }
        protected override string GetKey(object value) { throw null; }
        public System.Web.Services.Description.Message GetMessage(System.Xml.XmlQualifiedName name) { throw null; }
        public System.Web.Services.Description.PortType GetPortType(System.Xml.XmlQualifiedName name) { throw null; }
        public System.Web.Services.Description.Service GetService(System.Xml.XmlQualifiedName name) { throw null; }
        public int IndexOf(System.Web.Services.Description.ServiceDescription serviceDescription) { throw null; }
        public void Insert(int index, System.Web.Services.Description.ServiceDescription serviceDescription) { }
        protected override void OnInsertComplete(int index, object value) { }
        public void Remove(System.Web.Services.Description.ServiceDescription serviceDescription) { }
        protected override void SetParent(object value, object parent) { }
    }
    public abstract partial class ServiceDescriptionFormatExtension
    {
        protected ServiceDescriptionFormatExtension() { }
        [System.Xml.Serialization.XmlIgnoreAttribute]
        public bool Handled { get { throw null; } set { } }
        public object Parent { get { throw null; } }
        [System.ComponentModel.DefaultValueAttribute(false)]
        [System.Xml.Serialization.XmlAttributeAttribute("required", Namespace="http://schemas.xmlsoap.org/wsdl/")]
        public bool Required { get { throw null; } set { } }
    }
    public sealed partial class ServiceDescriptionFormatExtensionCollection : System.Web.Services.Description.ServiceDescriptionBaseCollection
    {
        public ServiceDescriptionFormatExtensionCollection(object parent) { }
        public object this[int index] { get { throw null; } set { } }
        public int Add(object extension) { throw null; }
        public bool Contains(object extension) { throw null; }
        public void CopyTo(object[] array, int index) { }
        public System.Xml.XmlElement Find(string name, string ns) { throw null; }
        public object Find(System.Type type) { throw null; }
        public System.Xml.XmlElement[] FindAll(string name, string ns) { throw null; }
        public object[] FindAll(System.Type type) { throw null; }
        public int IndexOf(object extension) { throw null; }
        public void Insert(int index, object extension) { }
        public bool IsHandled(object item) { throw null; }
        public bool IsRequired(object item) { throw null; }
        protected override void OnValidate(object value) { }
        public void Remove(object extension) { }
        protected override void SetParent(object value, object parent) { }
    }
    [System.Security.Permissions.PermissionSetAttribute(System.Security.Permissions.SecurityAction.InheritanceDemand, Name="FullTrust")]
    [System.Security.Permissions.PermissionSetAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Name="FullTrust")]
    public partial class ServiceDescriptionImporter
    {
        public ServiceDescriptionImporter() { }
        [System.Runtime.InteropServices.ComVisibleAttribute(false)]
        public System.Xml.Serialization.CodeGenerationOptions CodeGenerationOptions { get { throw null; } set { } }
        [System.Runtime.InteropServices.ComVisibleAttribute(false)]
        public System.CodeDom.Compiler.CodeDomProvider CodeGenerator { get { throw null; } set { } }
        public string ProtocolName { get { throw null; } set { } }
        public System.Xml.Serialization.XmlSchemas Schemas { get { throw null; } }
        public System.Web.Services.Description.ServiceDescriptionCollection ServiceDescriptions { get { throw null; } }
        public System.Web.Services.Description.ServiceDescriptionImportStyle Style { get { throw null; } set { } }
        public void AddServiceDescription(System.Web.Services.Description.ServiceDescription serviceDescription, string appSettingUrlKey, string appSettingBaseUrl) { }
        public static System.Collections.Specialized.StringCollection GenerateWebReferences(System.Web.Services.Description.WebReferenceCollection webReferences, System.CodeDom.Compiler.CodeDomProvider codeProvider, System.CodeDom.CodeCompileUnit codeCompileUnit, System.Web.Services.Description.WebReferenceOptions options) { throw null; }
        public System.Web.Services.Description.ServiceDescriptionImportWarnings Import(System.CodeDom.CodeNamespace codeNamespace, System.CodeDom.CodeCompileUnit codeCompileUnit) { throw null; }
    }
    public enum ServiceDescriptionImportStyle
    {
        [System.Xml.Serialization.XmlEnumAttribute("client")]
        Client = 0,
        [System.Xml.Serialization.XmlEnumAttribute("server")]
        Server = 1,
        [System.Xml.Serialization.XmlEnumAttribute("serverInterface")]
        ServerInterface = 2,
    }
    [System.FlagsAttribute]
    public enum ServiceDescriptionImportWarnings
    {
        NoCodeGenerated = 1,
        NoMethodsGenerated = 32,
        OptionalExtensionsIgnored = 2,
        RequiredExtensionsIgnored = 4,
        SchemaValidation = 64,
        UnsupportedBindingsIgnored = 16,
        UnsupportedOperationsIgnored = 8,
        WsiConformance = 128,
    }
    [System.Security.Permissions.PermissionSetAttribute(System.Security.Permissions.SecurityAction.InheritanceDemand, Name="FullTrust")]
    [System.Security.Permissions.PermissionSetAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Name="FullTrust")]
    public partial class ServiceDescriptionReflector
    {
        public ServiceDescriptionReflector() { }
        public System.Xml.Serialization.XmlSchemas Schemas { get { throw null; } }
        public System.Web.Services.Description.ServiceDescriptionCollection ServiceDescriptions { get { throw null; } }
        public void Reflect(System.Type type, string url) { }
    }
    [System.Web.Services.Configuration.XmlFormatExtensionAttribute("address", "http://schemas.xmlsoap.org/wsdl/soap12/", typeof(System.Web.Services.Description.Port))]
    public sealed partial class Soap12AddressBinding : System.Web.Services.Description.SoapAddressBinding
    {
        public Soap12AddressBinding() { }
    }
    [System.Web.Services.Configuration.XmlFormatExtensionAttribute("binding", "http://schemas.xmlsoap.org/wsdl/soap12/", typeof(System.Web.Services.Description.Binding))]
    [System.Web.Services.Configuration.XmlFormatExtensionPrefixAttribute("soap12", "http://schemas.xmlsoap.org/wsdl/soap12/")]
    public sealed partial class Soap12Binding : System.Web.Services.Description.SoapBinding
    {
        public new const string HttpTransport = "http://schemas.xmlsoap.org/soap/http";
        public new const string Namespace = "http://schemas.xmlsoap.org/wsdl/soap12/";
        public Soap12Binding() { }
    }
    [System.Web.Services.Configuration.XmlFormatExtensionAttribute("body", "http://schemas.xmlsoap.org/wsdl/soap12/", typeof(System.Web.Services.Description.InputBinding), typeof(System.Web.Services.Description.OutputBinding), typeof(System.Web.Services.Description.MimePart))]
    public sealed partial class Soap12BodyBinding : System.Web.Services.Description.SoapBodyBinding
    {
        public Soap12BodyBinding() { }
    }
    [System.Web.Services.Configuration.XmlFormatExtensionAttribute("fault", "http://schemas.xmlsoap.org/wsdl/soap12/", typeof(System.Web.Services.Description.FaultBinding))]
    public sealed partial class Soap12FaultBinding : System.Web.Services.Description.SoapFaultBinding
    {
        public Soap12FaultBinding() { }
    }
    [System.Web.Services.Configuration.XmlFormatExtensionAttribute("header", "http://schemas.xmlsoap.org/wsdl/soap12/", typeof(System.Web.Services.Description.InputBinding), typeof(System.Web.Services.Description.OutputBinding))]
    public sealed partial class Soap12HeaderBinding : System.Web.Services.Description.SoapHeaderBinding
    {
        public Soap12HeaderBinding() { }
    }
    [System.Web.Services.Configuration.XmlFormatExtensionAttribute("operation", "http://schemas.xmlsoap.org/wsdl/soap12/", typeof(System.Web.Services.Description.OperationBinding))]
    public sealed partial class Soap12OperationBinding : System.Web.Services.Description.SoapOperationBinding
    {
        public Soap12OperationBinding() { }
        [System.ComponentModel.DefaultValueAttribute(false)]
        [System.Xml.Serialization.XmlAttributeAttribute("soapActionRequired")]
        public bool SoapActionRequired { get { throw null; } set { } }
    }
    [System.Web.Services.Configuration.XmlFormatExtensionAttribute("address", "http://schemas.xmlsoap.org/wsdl/soap/", typeof(System.Web.Services.Description.Port))]
    public partial class SoapAddressBinding : System.Web.Services.Description.ServiceDescriptionFormatExtension
    {
        public SoapAddressBinding() { }
        [System.Xml.Serialization.XmlAttributeAttribute("location")]
        public string Location { get { throw null; } set { } }
    }
    [System.Web.Services.Configuration.XmlFormatExtensionAttribute("binding", "http://schemas.xmlsoap.org/wsdl/soap/", typeof(System.Web.Services.Description.Binding))]
    [System.Web.Services.Configuration.XmlFormatExtensionPrefixAttribute("soap", "http://schemas.xmlsoap.org/wsdl/soap/")]
    [System.Web.Services.Configuration.XmlFormatExtensionPrefixAttribute("soapenc", "http://schemas.xmlsoap.org/soap/encoding/")]
    public partial class SoapBinding : System.Web.Services.Description.ServiceDescriptionFormatExtension
    {
        public const string HttpTransport = "http://schemas.xmlsoap.org/soap/http";
        public const string Namespace = "http://schemas.xmlsoap.org/wsdl/soap/";
        public SoapBinding() { }
        public static System.Xml.Schema.XmlSchema Schema { get { throw null; } }
        [System.ComponentModel.DefaultValueAttribute((System.Web.Services.Description.SoapBindingStyle)(1))]
        [System.Xml.Serialization.XmlAttributeAttribute("style")]
        public System.Web.Services.Description.SoapBindingStyle Style { get { throw null; } set { } }
        [System.Xml.Serialization.XmlAttributeAttribute("transport")]
        public string Transport { get { throw null; } set { } }
    }
    public enum SoapBindingStyle
    {
        [System.Xml.Serialization.XmlIgnoreAttribute]
        Default = 0,
        [System.Xml.Serialization.XmlEnumAttribute("document")]
        Document = 1,
        [System.Xml.Serialization.XmlEnumAttribute("rpc")]
        Rpc = 2,
    }
    public enum SoapBindingUse
    {
        [System.Xml.Serialization.XmlIgnoreAttribute]
        Default = 0,
        [System.Xml.Serialization.XmlEnumAttribute("encoded")]
        Encoded = 1,
        [System.Xml.Serialization.XmlEnumAttribute("literal")]
        Literal = 2,
    }
    [System.Web.Services.Configuration.XmlFormatExtensionAttribute("body", "http://schemas.xmlsoap.org/wsdl/soap/", typeof(System.Web.Services.Description.InputBinding), typeof(System.Web.Services.Description.OutputBinding), typeof(System.Web.Services.Description.MimePart))]
    public partial class SoapBodyBinding : System.Web.Services.Description.ServiceDescriptionFormatExtension
    {
        public SoapBodyBinding() { }
        [System.ComponentModel.DefaultValueAttribute("")]
        [System.Xml.Serialization.XmlAttributeAttribute("encodingStyle")]
        public string Encoding { get { throw null; } set { } }
        [System.ComponentModel.DefaultValueAttribute("")]
        [System.Xml.Serialization.XmlAttributeAttribute("namespace")]
        public string Namespace { get { throw null; } set { } }
        [System.Xml.Serialization.XmlIgnoreAttribute]
        public string[] Parts { get { throw null; } set { } }
        [System.Xml.Serialization.XmlAttributeAttribute("parts")]
        public string PartsString { get { throw null; } set { } }
        [System.ComponentModel.DefaultValueAttribute((System.Web.Services.Description.SoapBindingUse)(0))]
        [System.Xml.Serialization.XmlAttributeAttribute("use")]
        public System.Web.Services.Description.SoapBindingUse Use { get { throw null; } set { } }
    }
    [System.Security.Permissions.PermissionSetAttribute(System.Security.Permissions.SecurityAction.InheritanceDemand, Name="FullTrust")]
    [System.Security.Permissions.PermissionSetAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Name="FullTrust")]
    public abstract partial class SoapExtensionImporter
    {
        protected SoapExtensionImporter() { }
        public System.Web.Services.Description.SoapProtocolImporter ImportContext { get { throw null; } set { } }
        public abstract void ImportMethod(System.CodeDom.CodeAttributeDeclarationCollection metadata);
    }
    [System.Security.Permissions.PermissionSetAttribute(System.Security.Permissions.SecurityAction.InheritanceDemand, Name="FullTrust")]
    [System.Security.Permissions.PermissionSetAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Name="FullTrust")]
    public abstract partial class SoapExtensionReflector
    {
        protected SoapExtensionReflector() { }
        public System.Web.Services.Description.ProtocolReflector ReflectionContext { get { throw null; } set { } }
        public virtual void ReflectDescription() { }
        public abstract void ReflectMethod();
    }
    [System.Web.Services.Configuration.XmlFormatExtensionAttribute("fault", "http://schemas.xmlsoap.org/wsdl/soap/", typeof(System.Web.Services.Description.FaultBinding))]
    public partial class SoapFaultBinding : System.Web.Services.Description.ServiceDescriptionFormatExtension
    {
        public SoapFaultBinding() { }
        [System.ComponentModel.DefaultValueAttribute("")]
        [System.Xml.Serialization.XmlAttributeAttribute("encodingStyle")]
        public string Encoding { get { throw null; } set { } }
        [System.Xml.Serialization.XmlAttributeAttribute("name")]
        public string Name { get { throw null; } set { } }
        [System.Xml.Serialization.XmlAttributeAttribute("namespace")]
        public string Namespace { get { throw null; } set { } }
        [System.ComponentModel.DefaultValueAttribute((System.Web.Services.Description.SoapBindingUse)(0))]
        [System.Xml.Serialization.XmlAttributeAttribute("use")]
        public System.Web.Services.Description.SoapBindingUse Use { get { throw null; } set { } }
    }
    [System.Web.Services.Configuration.XmlFormatExtensionAttribute("header", "http://schemas.xmlsoap.org/wsdl/soap/", typeof(System.Web.Services.Description.InputBinding), typeof(System.Web.Services.Description.OutputBinding))]
    public partial class SoapHeaderBinding : System.Web.Services.Description.ServiceDescriptionFormatExtension
    {
        public SoapHeaderBinding() { }
        [System.ComponentModel.DefaultValueAttribute("")]
        [System.Xml.Serialization.XmlAttributeAttribute("encodingStyle")]
        public string Encoding { get { throw null; } set { } }
        [System.Xml.Serialization.XmlElementAttribute("headerfault")]
        public System.Web.Services.Description.SoapHeaderFaultBinding Fault { get { throw null; } set { } }
        [System.Xml.Serialization.XmlIgnoreAttribute]
        public bool MapToProperty { get { throw null; } set { } }
        [System.Xml.Serialization.XmlAttributeAttribute("message")]
        public System.Xml.XmlQualifiedName Message { get { throw null; } set { } }
        [System.ComponentModel.DefaultValueAttribute("")]
        [System.Xml.Serialization.XmlAttributeAttribute("namespace")]
        public string Namespace { get { throw null; } set { } }
        [System.Xml.Serialization.XmlAttributeAttribute("part")]
        public string Part { get { throw null; } set { } }
        [System.ComponentModel.DefaultValueAttribute((System.Web.Services.Description.SoapBindingUse)(0))]
        [System.Xml.Serialization.XmlAttributeAttribute("use")]
        public System.Web.Services.Description.SoapBindingUse Use { get { throw null; } set { } }
    }
    public partial class SoapHeaderFaultBinding : System.Web.Services.Description.ServiceDescriptionFormatExtension
    {
        public SoapHeaderFaultBinding() { }
        [System.ComponentModel.DefaultValueAttribute("")]
        [System.Xml.Serialization.XmlAttributeAttribute("encodingStyle")]
        public string Encoding { get { throw null; } set { } }
        [System.Xml.Serialization.XmlAttributeAttribute("message")]
        public System.Xml.XmlQualifiedName Message { get { throw null; } set { } }
        [System.ComponentModel.DefaultValueAttribute("")]
        [System.Xml.Serialization.XmlAttributeAttribute("namespace")]
        public string Namespace { get { throw null; } set { } }
        [System.Xml.Serialization.XmlAttributeAttribute("part")]
        public string Part { get { throw null; } set { } }
        [System.ComponentModel.DefaultValueAttribute((System.Web.Services.Description.SoapBindingUse)(0))]
        [System.Xml.Serialization.XmlAttributeAttribute("use")]
        public System.Web.Services.Description.SoapBindingUse Use { get { throw null; } set { } }
    }
    [System.Web.Services.Configuration.XmlFormatExtensionAttribute("operation", "http://schemas.xmlsoap.org/wsdl/soap/", typeof(System.Web.Services.Description.OperationBinding))]
    public partial class SoapOperationBinding : System.Web.Services.Description.ServiceDescriptionFormatExtension
    {
        public SoapOperationBinding() { }
        [System.Xml.Serialization.XmlAttributeAttribute("soapAction")]
        public string SoapAction { get { throw null; } set { } }
        [System.ComponentModel.DefaultValueAttribute((System.Web.Services.Description.SoapBindingStyle)(0))]
        [System.Xml.Serialization.XmlAttributeAttribute("style")]
        public System.Web.Services.Description.SoapBindingStyle Style { get { throw null; } set { } }
    }
    [System.Security.Permissions.PermissionSetAttribute(System.Security.Permissions.SecurityAction.InheritanceDemand, Name="FullTrust")]
    [System.Security.Permissions.PermissionSetAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Name="FullTrust")]
    public partial class SoapProtocolImporter : System.Web.Services.Description.ProtocolImporter
    {
        public SoapProtocolImporter() { }
        public override string ProtocolName { get { throw null; } }
        public System.Web.Services.Description.SoapBinding SoapBinding { get { throw null; } }
        public System.Xml.Serialization.SoapCodeExporter SoapExporter { get { throw null; } }
        public System.Xml.Serialization.SoapSchemaImporter SoapImporter { get { throw null; } }
        public System.Xml.Serialization.XmlCodeExporter XmlExporter { get { throw null; } }
        public System.Xml.Serialization.XmlSchemaImporter XmlImporter { get { throw null; } }
        protected override System.CodeDom.CodeTypeDeclaration BeginClass() { throw null; }
        protected override void BeginNamespace() { }
        protected override void EndClass() { }
        protected override void EndNamespace() { }
        protected override System.CodeDom.CodeMemberMethod GenerateMethod() { throw null; }
        protected override bool IsBindingSupported() { throw null; }
        protected override bool IsOperationFlowSupported(System.Web.Services.Description.OperationFlow flow) { throw null; }
        protected virtual bool IsSoapEncodingPresent(string uriList) { throw null; }
    }
    [System.Security.Permissions.PermissionSetAttribute(System.Security.Permissions.SecurityAction.InheritanceDemand, Name="FullTrust")]
    public abstract partial class SoapTransportImporter
    {
        protected SoapTransportImporter() { }
        public System.Web.Services.Description.SoapProtocolImporter ImportContext { get { throw null; } set { } }
        public abstract void ImportClass();
        public abstract bool IsSupportedTransport(string transport);
    }
    [System.Web.Services.Configuration.XmlFormatExtensionPointAttribute("Extensions")]
    public sealed partial class Types : System.Web.Services.Description.DocumentableItem
    {
        public Types() { }
        [System.Xml.Serialization.XmlIgnoreAttribute]
        public override System.Web.Services.Description.ServiceDescriptionFormatExtensionCollection Extensions { get { throw null; } }
        [System.Xml.Serialization.XmlElementAttribute("schema", typeof(System.Xml.Schema.XmlSchema), Namespace="http://www.w3.org/2001/XMLSchema")]
        public System.Xml.Serialization.XmlSchemas Schemas { get { throw null; } }
    }
    public sealed partial class WebReference
    {
        public WebReference(System.Web.Services.Discovery.DiscoveryClientDocumentCollection documents, System.CodeDom.CodeNamespace proxyCode) { }
        public WebReference(System.Web.Services.Discovery.DiscoveryClientDocumentCollection documents, System.CodeDom.CodeNamespace proxyCode, string appSettingUrlKey, string appSettingBaseUrl) { }
        public WebReference(System.Web.Services.Discovery.DiscoveryClientDocumentCollection documents, System.CodeDom.CodeNamespace proxyCode, string protocolName, string appSettingUrlKey, string appSettingBaseUrl) { }
        public string AppSettingBaseUrl { get { throw null; } }
        public string AppSettingUrlKey { get { throw null; } }
        public System.Web.Services.Discovery.DiscoveryClientDocumentCollection Documents { get { throw null; } }
        public string ProtocolName { get { throw null; } set { } }
        public System.CodeDom.CodeNamespace ProxyCode { get { throw null; } }
        public System.Collections.Specialized.StringCollection ValidationWarnings { get { throw null; } }
        public System.Web.Services.Description.ServiceDescriptionImportWarnings Warnings { get { throw null; } set { } }
    }
    public sealed partial class WebReferenceCollection : System.Collections.CollectionBase
    {
        public WebReferenceCollection() { }
        public System.Web.Services.Description.WebReference this[int index] { get { throw null; } set { } }
        public int Add(System.Web.Services.Description.WebReference webReference) { throw null; }
        public bool Contains(System.Web.Services.Description.WebReference webReference) { throw null; }
        public void CopyTo(System.Web.Services.Description.WebReference[] array, int index) { }
        public int IndexOf(System.Web.Services.Description.WebReference webReference) { throw null; }
        public void Insert(int index, System.Web.Services.Description.WebReference webReference) { }
        public void Remove(System.Web.Services.Description.WebReference webReference) { }
    }
    [System.Xml.Serialization.XmlRootAttribute("webReferenceOptions", Namespace="http://microsoft.com/webReference/")]
    [System.Xml.Serialization.XmlTypeAttribute("webReferenceOptions", Namespace="http://microsoft.com/webReference/")]
    public partial class WebReferenceOptions
    {
        public const string TargetNamespace = "http://microsoft.com/webReference/";
        public WebReferenceOptions() { }
        [System.ComponentModel.DefaultValueAttribute((System.Xml.Serialization.CodeGenerationOptions)(4))]
        [System.Xml.Serialization.XmlElementAttribute("codeGenerationOptions")]
        public System.Xml.Serialization.CodeGenerationOptions CodeGenerationOptions { get { throw null; } set { } }
        public static System.Xml.Schema.XmlSchema Schema { get { throw null; } }
        [System.Xml.Serialization.XmlArrayAttribute("schemaImporterExtensions")]
        [System.Xml.Serialization.XmlArrayItemAttribute("type")]
        public System.Collections.Specialized.StringCollection SchemaImporterExtensions { get { throw null; } }
        [System.ComponentModel.DefaultValueAttribute((System.Web.Services.Description.ServiceDescriptionImportStyle)(0))]
        [System.Xml.Serialization.XmlElementAttribute("style")]
        public System.Web.Services.Description.ServiceDescriptionImportStyle Style { get { throw null; } set { } }
        [System.Xml.Serialization.XmlElementAttribute("verbose")]
        public bool Verbose { get { throw null; } set { } }
        public static System.Web.Services.Description.WebReferenceOptions Read(System.IO.Stream stream, System.Xml.Schema.ValidationEventHandler validationEventHandler) { throw null; }
        public static System.Web.Services.Description.WebReferenceOptions Read(System.IO.TextReader reader, System.Xml.Schema.ValidationEventHandler validationEventHandler) { throw null; }
        public static System.Web.Services.Description.WebReferenceOptions Read(System.Xml.XmlReader xmlReader, System.Xml.Schema.ValidationEventHandler validationEventHandler) { throw null; }
    }
    public sealed partial class WebServicesInteroperability
    {
        internal WebServicesInteroperability() { }
        public static bool CheckConformance(System.Web.Services.WsiProfiles claims, System.Web.Services.Description.ServiceDescription description, System.Web.Services.Description.BasicProfileViolationCollection violations) { throw null; }
        public static bool CheckConformance(System.Web.Services.WsiProfiles claims, System.Web.Services.Description.ServiceDescriptionCollection descriptions, System.Web.Services.Description.BasicProfileViolationCollection violations) { throw null; }
        public static bool CheckConformance(System.Web.Services.WsiProfiles claims, System.Web.Services.Description.WebReference webReference, System.Web.Services.Description.BasicProfileViolationCollection violations) { throw null; }
    }
}
namespace System.Web.Services.Discovery
{
    [System.Xml.Serialization.XmlRootAttribute("contractRef", Namespace="http://schemas.xmlsoap.org/disco/scl/")]
    public partial class ContractReference : System.Web.Services.Discovery.DiscoveryReference
    {
        public const string Namespace = "http://schemas.xmlsoap.org/disco/scl/";
        public ContractReference() { }
        public ContractReference(string href) { }
        public ContractReference(string href, string docRef) { }
        [System.Xml.Serialization.XmlIgnoreAttribute]
        public System.Web.Services.Description.ServiceDescription Contract { get { throw null; } }
        [System.Xml.Serialization.XmlIgnoreAttribute]
        public override string DefaultFilename { get { throw null; } }
        [System.Xml.Serialization.XmlAttributeAttribute("docRef")]
        public string DocRef { get { throw null; } set { } }
        [System.Xml.Serialization.XmlAttributeAttribute("ref")]
        public string Ref { get { throw null; } set { } }
        [System.Xml.Serialization.XmlIgnoreAttribute]
        public override string Url { get { throw null; } set { } }
        public override object ReadDocument(System.IO.Stream stream) { throw null; }
        protected internal override void Resolve(string contentType, System.IO.Stream stream) { }
        public override void WriteDocument(object document, System.IO.Stream stream) { }
    }
    public sealed partial class ContractSearchPattern : System.Web.Services.Discovery.DiscoverySearchPattern
    {
        public ContractSearchPattern() { }
        public override string Pattern { get { throw null; } }
        public override System.Web.Services.Discovery.DiscoveryReference GetDiscoveryReference(string filename) { throw null; }
    }
    public sealed partial class DiscoveryClientDocumentCollection : System.Collections.DictionaryBase
    {
        public DiscoveryClientDocumentCollection() { }
        public object this[string url] { get { throw null; } set { } }
        public System.Collections.ICollection Keys { get { throw null; } }
        public System.Collections.ICollection Values { get { throw null; } }
        public void Add(string url, object value) { }
        public bool Contains(string url) { throw null; }
        public void Remove(string url) { }
    }
    public partial class DiscoveryClientProtocol : System.Web.Services.Protocols.HttpWebClientProtocol
    {
        public DiscoveryClientProtocol() { }
        public System.Collections.IList AdditionalInformation { get { throw null; } }
        public System.Web.Services.Discovery.DiscoveryClientDocumentCollection Documents { get { throw null; } }
        public System.Web.Services.Discovery.DiscoveryExceptionDictionary Errors { get { throw null; } }
        public System.Web.Services.Discovery.DiscoveryClientReferenceCollection References { get { throw null; } }
        [System.Security.Permissions.PermissionSetAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Name="FullTrust")]
        public System.Web.Services.Discovery.DiscoveryDocument Discover(string url) { throw null; }
        [System.Security.Permissions.PermissionSetAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Name="FullTrust")]
        public System.Web.Services.Discovery.DiscoveryDocument DiscoverAny(string url) { throw null; }
        [System.Security.Permissions.PermissionSetAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Name="FullTrust")]
        public System.IO.Stream Download(ref string url) { throw null; }
        [System.Security.Permissions.PermissionSetAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Name="FullTrust")]
        public System.IO.Stream Download(ref string url, ref string contentType) { throw null; }
        [System.ObsoleteAttribute("This method will be removed from a future version. The method call is no longer required for resource discovery", false)]
        [System.Runtime.InteropServices.ComVisibleAttribute(false)]
        public void LoadExternals() { }
        [System.Security.Permissions.PermissionSetAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Name="FullTrust")]
        public System.Web.Services.Discovery.DiscoveryClientResultCollection ReadAll(string topLevelFilename) { throw null; }
        [System.Security.Permissions.PermissionSetAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Name="FullTrust")]
        public void ResolveAll() { }
        [System.Security.Permissions.PermissionSetAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Name="FullTrust")]
        public void ResolveOneLevel() { }
        [System.Security.Permissions.PermissionSetAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Name="FullTrust")]
        public System.Web.Services.Discovery.DiscoveryClientResultCollection WriteAll(string directory, string topLevelFilename) { throw null; }
        public sealed partial class DiscoveryClientResultsFile
        {
            public DiscoveryClientResultsFile() { }
            public System.Web.Services.Discovery.DiscoveryClientResultCollection Results { get { throw null; } }
        }
    }
    public sealed partial class DiscoveryClientReferenceCollection : System.Collections.DictionaryBase
    {
        public DiscoveryClientReferenceCollection() { }
        public System.Web.Services.Discovery.DiscoveryReference this[string url] { get { throw null; } set { } }
        public System.Collections.ICollection Keys { get { throw null; } }
        public System.Collections.ICollection Values { get { throw null; } }
        public void Add(string url, System.Web.Services.Discovery.DiscoveryReference value) { }
        public void Add(System.Web.Services.Discovery.DiscoveryReference value) { }
        public bool Contains(string url) { throw null; }
        public void Remove(string url) { }
    }
    public sealed partial class DiscoveryClientResult
    {
        public DiscoveryClientResult() { }
        public DiscoveryClientResult(System.Type referenceType, string url, string filename) { }
        [System.Xml.Serialization.XmlAttributeAttribute("filename")]
        public string Filename { get { throw null; } set { } }
        [System.Xml.Serialization.XmlAttributeAttribute("referenceType")]
        public string ReferenceTypeName { get { throw null; } set { } }
        [System.Xml.Serialization.XmlAttributeAttribute("url")]
        public string Url { get { throw null; } set { } }
    }
    public sealed partial class DiscoveryClientResultCollection : System.Collections.CollectionBase
    {
        public DiscoveryClientResultCollection() { }
        public System.Web.Services.Discovery.DiscoveryClientResult this[int i] { get { throw null; } set { } }
        public int Add(System.Web.Services.Discovery.DiscoveryClientResult value) { throw null; }
        public bool Contains(System.Web.Services.Discovery.DiscoveryClientResult value) { throw null; }
        public void Remove(System.Web.Services.Discovery.DiscoveryClientResult value) { }
    }
    [System.Xml.Serialization.XmlRootAttribute("discovery", Namespace="http://schemas.xmlsoap.org/disco/")]
    public sealed partial class DiscoveryDocument
    {
        public const string Namespace = "http://schemas.xmlsoap.org/disco/";
        public DiscoveryDocument() { }
        [System.Xml.Serialization.XmlIgnoreAttribute]
        public System.Collections.IList References { get { throw null; } }
        public static bool CanRead(System.Xml.XmlReader xmlReader) { throw null; }
        public static System.Web.Services.Discovery.DiscoveryDocument Read(System.IO.Stream stream) { throw null; }
        public static System.Web.Services.Discovery.DiscoveryDocument Read(System.IO.TextReader reader) { throw null; }
        public static System.Web.Services.Discovery.DiscoveryDocument Read(System.Xml.XmlReader xmlReader) { throw null; }
        public void Write(System.IO.Stream stream) { }
        public void Write(System.IO.TextWriter writer) { }
        public void Write(System.Xml.XmlWriter writer) { }
    }
    public partial class DiscoveryDocumentLinksPattern : System.Web.Services.Discovery.DiscoverySearchPattern
    {
        public DiscoveryDocumentLinksPattern() { }
        public override string Pattern { get { throw null; } }
        public override System.Web.Services.Discovery.DiscoveryReference GetDiscoveryReference(string filename) { throw null; }
    }
    [System.Xml.Serialization.XmlRootAttribute("discoveryRef", Namespace="http://schemas.xmlsoap.org/disco/")]
    public sealed partial class DiscoveryDocumentReference : System.Web.Services.Discovery.DiscoveryReference
    {
        public DiscoveryDocumentReference() { }
        public DiscoveryDocumentReference(string href) { }
        [System.Xml.Serialization.XmlIgnoreAttribute]
        public override string DefaultFilename { get { throw null; } }
        [System.Xml.Serialization.XmlIgnoreAttribute]
        public System.Web.Services.Discovery.DiscoveryDocument Document { get { throw null; } }
        [System.Xml.Serialization.XmlAttributeAttribute("ref")]
        public string Ref { get { throw null; } set { } }
        [System.Xml.Serialization.XmlIgnoreAttribute]
        public override string Url { get { throw null; } set { } }
        public override object ReadDocument(System.IO.Stream stream) { throw null; }
        protected internal override void Resolve(string contentType, System.IO.Stream stream) { }
        public void ResolveAll() { }
        public override void WriteDocument(object document, System.IO.Stream stream) { }
    }
    public sealed partial class DiscoveryDocumentSearchPattern : System.Web.Services.Discovery.DiscoverySearchPattern
    {
        public DiscoveryDocumentSearchPattern() { }
        public override string Pattern { get { throw null; } }
        public override System.Web.Services.Discovery.DiscoveryReference GetDiscoveryReference(string filename) { throw null; }
    }
    public sealed partial class DiscoveryExceptionDictionary : System.Collections.DictionaryBase
    {
        public DiscoveryExceptionDictionary() { }
        public System.Exception this[string url] { get { throw null; } set { } }
        public System.Collections.ICollection Keys { get { throw null; } }
        public System.Collections.ICollection Values { get { throw null; } }
        public void Add(string url, System.Exception value) { }
        public bool Contains(string url) { throw null; }
        public void Remove(string url) { }
    }
    public abstract partial class DiscoveryReference
    {
        protected DiscoveryReference() { }
        [System.Xml.Serialization.XmlIgnoreAttribute]
        public System.Web.Services.Discovery.DiscoveryClientProtocol ClientProtocol { get { throw null; } set { } }
        [System.Xml.Serialization.XmlIgnoreAttribute]
        public virtual string DefaultFilename { get { throw null; } }
        [System.Xml.Serialization.XmlIgnoreAttribute]
        public abstract string Url { get; set; }
        public static string FilenameFromUrl(string url) { throw null; }
        public abstract object ReadDocument(System.IO.Stream stream);
        public void Resolve() { }
        protected internal abstract void Resolve(string contentType, System.IO.Stream stream);
        public abstract void WriteDocument(object document, System.IO.Stream stream);
    }
    public sealed partial class DiscoveryReferenceCollection : System.Collections.CollectionBase
    {
        public DiscoveryReferenceCollection() { }
        public System.Web.Services.Discovery.DiscoveryReference this[int i] { get { throw null; } set { } }
        public int Add(System.Web.Services.Discovery.DiscoveryReference value) { throw null; }
        public bool Contains(System.Web.Services.Discovery.DiscoveryReference value) { throw null; }
        public void Remove(System.Web.Services.Discovery.DiscoveryReference value) { }
    }
    public sealed partial class DiscoveryRequestHandler : System.Web.IHttpHandler
    {
        public DiscoveryRequestHandler() { }
        public bool IsReusable { get { throw null; } }
        public void ProcessRequest(System.Web.HttpContext context) { }
    }
    [System.Security.Permissions.PermissionSetAttribute(System.Security.Permissions.SecurityAction.InheritanceDemand, Name="FullTrust")]
    public abstract partial class DiscoverySearchPattern
    {
        protected DiscoverySearchPattern() { }
        public abstract string Pattern { get; }
        public abstract System.Web.Services.Discovery.DiscoveryReference GetDiscoveryReference(string filename);
    }
    [System.Xml.Serialization.XmlRootAttribute("dynamicDiscovery", Namespace="urn:schemas-dynamicdiscovery:disco.2000-03-17")]
    public sealed partial class DynamicDiscoveryDocument
    {
        public const string Namespace = "urn:schemas-dynamicdiscovery:disco.2000-03-17";
        public DynamicDiscoveryDocument() { }
        [System.Xml.Serialization.XmlElementAttribute("exclude", typeof(System.Web.Services.Discovery.ExcludePathInfo))]
        public System.Web.Services.Discovery.ExcludePathInfo[] ExcludePaths { get { throw null; } set { } }
        public static System.Web.Services.Discovery.DynamicDiscoveryDocument Load(System.IO.Stream stream) { throw null; }
        public void Write(System.IO.Stream stream) { }
    }
    public sealed partial class ExcludePathInfo
    {
        public ExcludePathInfo() { }
        public ExcludePathInfo(string path) { }
        [System.Xml.Serialization.XmlAttributeAttribute("path")]
        public string Path { get { throw null; } set { } }
    }
    [System.Xml.Serialization.XmlRootAttribute("schemaRef", Namespace="http://schemas.xmlsoap.org/disco/schema/")]
    public sealed partial class SchemaReference : System.Web.Services.Discovery.DiscoveryReference
    {
        public const string Namespace = "http://schemas.xmlsoap.org/disco/schema/";
        public SchemaReference() { }
        public SchemaReference(string url) { }
        [System.Xml.Serialization.XmlIgnoreAttribute]
        public override string DefaultFilename { get { throw null; } }
        [System.Xml.Serialization.XmlAttributeAttribute("ref")]
        public string Ref { get { throw null; } set { } }
        [System.Xml.Serialization.XmlIgnoreAttribute]
        public System.Xml.Schema.XmlSchema Schema { get { throw null; } }
        [System.ComponentModel.DefaultValueAttribute(null)]
        [System.Xml.Serialization.XmlAttributeAttribute("targetNamespace")]
        public string TargetNamespace { get { throw null; } set { } }
        [System.Xml.Serialization.XmlIgnoreAttribute]
        public override string Url { get { throw null; } set { } }
        public override object ReadDocument(System.IO.Stream stream) { throw null; }
        protected internal override void Resolve(string contentType, System.IO.Stream stream) { }
        public override void WriteDocument(object document, System.IO.Stream stream) { }
    }
    [System.Xml.Serialization.XmlRootAttribute("soap", Namespace="http://schemas.xmlsoap.org/disco/soap/")]
    public sealed partial class SoapBinding
    {
        public const string Namespace = "http://schemas.xmlsoap.org/disco/soap/";
        public SoapBinding() { }
        [System.Xml.Serialization.XmlAttributeAttribute("address")]
        public string Address { get { throw null; } set { } }
        [System.Xml.Serialization.XmlAttributeAttribute("binding")]
        public System.Xml.XmlQualifiedName Binding { get { throw null; } set { } }
    }
    public sealed partial class XmlSchemaSearchPattern : System.Web.Services.Discovery.DiscoverySearchPattern
    {
        public XmlSchemaSearchPattern() { }
        public override string Pattern { get { throw null; } }
        public override System.Web.Services.Discovery.DiscoveryReference GetDiscoveryReference(string filename) { throw null; }
    }
}
namespace System.Web.Services.Protocols
{
    public partial class AnyReturnReader : System.Web.Services.Protocols.MimeReturnReader
    {
        public AnyReturnReader() { }
        public override object GetInitializer(System.Web.Services.Protocols.LogicalMethodInfo methodInfo) { throw null; }
        public override void Initialize(object o) { }
        public override object Read(System.Net.WebResponse response, System.IO.Stream responseStream) { throw null; }
    }
    public partial class HtmlFormParameterReader : System.Web.Services.Protocols.ValueCollectionParameterReader
    {
        public HtmlFormParameterReader() { }
        public override object[] Read(System.Web.HttpRequest request) { throw null; }
    }
    public partial class HtmlFormParameterWriter : System.Web.Services.Protocols.UrlEncodedParameterWriter
    {
        public HtmlFormParameterWriter() { }
        public override bool UsesWriteRequest { get { throw null; } }
        public override void InitializeRequest(System.Net.WebRequest request, object[] values) { }
        public override void WriteRequest(System.IO.Stream requestStream, object[] values) { }
    }
    public partial class HttpGetClientProtocol : System.Web.Services.Protocols.HttpSimpleClientProtocol
    {
        public HttpGetClientProtocol() { }
        protected override System.Net.WebRequest GetWebRequest(System.Uri uri) { throw null; }
    }
    [System.AttributeUsageAttribute((System.AttributeTargets)(64))]
    public sealed partial class HttpMethodAttribute : System.Attribute
    {
        public HttpMethodAttribute() { }
        public HttpMethodAttribute(System.Type returnFormatter, System.Type parameterFormatter) { }
        public System.Type ParameterFormatter { get { throw null; } set { } }
        public System.Type ReturnFormatter { get { throw null; } set { } }
    }
    public partial class HttpPostClientProtocol : System.Web.Services.Protocols.HttpSimpleClientProtocol
    {
        public HttpPostClientProtocol() { }
        protected override System.Net.WebRequest GetWebRequest(System.Uri uri) { throw null; }
    }
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public abstract partial class HttpSimpleClientProtocol : System.Web.Services.Protocols.HttpWebClientProtocol
    {
        protected HttpSimpleClientProtocol() { }
        protected System.IAsyncResult BeginInvoke(string methodName, string requestUrl, object[] parameters, System.AsyncCallback callback, object asyncState) { throw null; }
        protected object EndInvoke(System.IAsyncResult asyncResult) { throw null; }
        protected object Invoke(string methodName, string requestUrl, object[] parameters) { throw null; }
        protected void InvokeAsync(string methodName, string requestUrl, object[] parameters, System.Threading.SendOrPostCallback callback) { }
        protected void InvokeAsync(string methodName, string requestUrl, object[] parameters, System.Threading.SendOrPostCallback callback, object userState) { }
    }
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public abstract partial class HttpWebClientProtocol : System.Web.Services.Protocols.WebClientProtocol
    {
        protected HttpWebClientProtocol() { }
        [System.ComponentModel.DefaultValueAttribute(false)]
        public bool AllowAutoRedirect { get { throw null; } set { } }
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(0))]
        public System.Security.Cryptography.X509Certificates.X509CertificateCollection ClientCertificates { get { throw null; } }
        [System.ComponentModel.DefaultValueAttribute(null)]
        public System.Net.CookieContainer CookieContainer { get { throw null; } set { } }
        [System.ComponentModel.DefaultValueAttribute(false)]
        public bool EnableDecompression { get { throw null; } set { } }
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(0))]
        public System.Net.IWebProxy Proxy { get { throw null; } set { } }
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(0))]
        public bool UnsafeAuthenticatedConnectionSharing { get { throw null; } set { } }
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(0))]
        public string UserAgent { get { throw null; } set { } }
        protected void CancelAsync(object userState) { }
        public static bool GenerateXmlMappings(System.Type type, System.Collections.ArrayList mappings) { throw null; }
        public static System.Collections.Hashtable GenerateXmlMappings(System.Type[] types, System.Collections.ArrayList mappings) { throw null; }
        protected override System.Net.WebRequest GetWebRequest(System.Uri uri) { throw null; }
        protected override System.Net.WebResponse GetWebResponse(System.Net.WebRequest request) { throw null; }
        protected override System.Net.WebResponse GetWebResponse(System.Net.WebRequest request, System.IAsyncResult result) { throw null; }
    }
    public partial class InvokeCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs
    {
        internal InvokeCompletedEventArgs() : base (default(System.Exception), default(bool), default(object)) { }
        public object[] Results { get { throw null; } }
    }
    public delegate void InvokeCompletedEventHandler(object sender, System.Web.Services.Protocols.InvokeCompletedEventArgs e);
    public sealed partial class LogicalMethodInfo
    {
        public LogicalMethodInfo(System.Reflection.MethodInfo methodInfo) { }
        public System.Reflection.ParameterInfo AsyncCallbackParameter { get { throw null; } }
        public System.Reflection.ParameterInfo AsyncResultParameter { get { throw null; } }
        public System.Reflection.ParameterInfo AsyncStateParameter { get { throw null; } }
        public System.Reflection.MethodInfo BeginMethodInfo { get { throw null; } }
        public System.Reflection.ICustomAttributeProvider CustomAttributeProvider { get { throw null; } }
        public System.Type DeclaringType { get { throw null; } }
        public System.Reflection.MethodInfo EndMethodInfo { get { throw null; } }
        public System.Reflection.ParameterInfo[] InParameters { get { throw null; } }
        public bool IsAsync { get { throw null; } }
        public bool IsVoid { get { throw null; } }
        public System.Reflection.MethodInfo MethodInfo { get { throw null; } }
        public string Name { get { throw null; } }
        public System.Reflection.ParameterInfo[] OutParameters { get { throw null; } }
        public System.Reflection.ParameterInfo[] Parameters { get { throw null; } }
        public System.Type ReturnType { get { throw null; } }
        public System.Reflection.ICustomAttributeProvider ReturnTypeCustomAttributeProvider { get { throw null; } }
        [System.Security.Permissions.PermissionSetAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Name="FullTrust")]
        public System.IAsyncResult BeginInvoke(object target, object[] values, System.AsyncCallback callback, object asyncState) { throw null; }
        public static System.Web.Services.Protocols.LogicalMethodInfo[] Create(System.Reflection.MethodInfo[] methodInfos) { throw null; }
        public static System.Web.Services.Protocols.LogicalMethodInfo[] Create(System.Reflection.MethodInfo[] methodInfos, System.Web.Services.Protocols.LogicalMethodTypes types) { throw null; }
        [System.Security.Permissions.PermissionSetAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Name="FullTrust")]
        public object[] EndInvoke(object target, System.IAsyncResult asyncResult) { throw null; }
        public object GetCustomAttribute(System.Type type) { throw null; }
        public object[] GetCustomAttributes(System.Type type) { throw null; }
        [System.Security.Permissions.PermissionSetAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Name="FullTrust")]
        public object[] Invoke(object target, object[] values) { throw null; }
        public static bool IsBeginMethod(System.Reflection.MethodInfo methodInfo) { throw null; }
        public static bool IsEndMethod(System.Reflection.MethodInfo methodInfo) { throw null; }
        public override string ToString() { throw null; }
    }
    public enum LogicalMethodTypes
    {
        Async = 2,
        Sync = 1,
    }
    [System.AttributeUsageAttribute((System.AttributeTargets)(32767))]
    public sealed partial class MatchAttribute : System.Attribute
    {
        public MatchAttribute(string pattern) { }
        public int Capture { get { throw null; } set { } }
        public int Group { get { throw null; } set { } }
        public bool IgnoreCase { get { throw null; } set { } }
        public int MaxRepeats { get { throw null; } set { } }
        public string Pattern { get { throw null; } set { } }
    }
    public abstract partial class MimeFormatter
    {
        protected MimeFormatter() { }
        [System.Security.Permissions.PermissionSetAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Name="FullTrust")]
        public static System.Web.Services.Protocols.MimeFormatter CreateInstance(System.Type type, object initializer) { throw null; }
        [System.Security.Permissions.PermissionSetAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Name="FullTrust")]
        public static object GetInitializer(System.Type type, System.Web.Services.Protocols.LogicalMethodInfo methodInfo) { throw null; }
        public abstract object GetInitializer(System.Web.Services.Protocols.LogicalMethodInfo methodInfo);
        [System.Security.Permissions.PermissionSetAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Name="FullTrust")]
        public static object[] GetInitializers(System.Type type, System.Web.Services.Protocols.LogicalMethodInfo[] methodInfos) { throw null; }
        public virtual object[] GetInitializers(System.Web.Services.Protocols.LogicalMethodInfo[] methodInfos) { throw null; }
        public abstract void Initialize(object initializer);
    }
    [System.Security.Permissions.PermissionSetAttribute(System.Security.Permissions.SecurityAction.InheritanceDemand, Name="FullTrust")]
    public abstract partial class MimeParameterReader : System.Web.Services.Protocols.MimeFormatter
    {
        protected MimeParameterReader() { }
        public abstract object[] Read(System.Web.HttpRequest request);
    }
    public abstract partial class MimeParameterWriter : System.Web.Services.Protocols.MimeFormatter
    {
        protected MimeParameterWriter() { }
        public virtual System.Text.Encoding RequestEncoding { get { throw null; } set { } }
        public virtual bool UsesWriteRequest { get { throw null; } }
        public virtual string GetRequestUrl(string url, object[] parameters) { throw null; }
        public virtual void InitializeRequest(System.Net.WebRequest request, object[] values) { }
        public virtual void WriteRequest(System.IO.Stream requestStream, object[] values) { }
    }
    public abstract partial class MimeReturnReader : System.Web.Services.Protocols.MimeFormatter
    {
        protected MimeReturnReader() { }
        public abstract object Read(System.Net.WebResponse response, System.IO.Stream responseStream);
    }
    public partial class NopReturnReader : System.Web.Services.Protocols.MimeReturnReader
    {
        public NopReturnReader() { }
        public override object GetInitializer(System.Web.Services.Protocols.LogicalMethodInfo methodInfo) { throw null; }
        public override void Initialize(object initializer) { }
        public override object Read(System.Net.WebResponse response, System.IO.Stream responseStream) { throw null; }
    }
    [System.Security.Permissions.PermissionSetAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Name="FullTrust")]
    public sealed partial class PatternMatcher
    {
        public PatternMatcher(System.Type type) { }
        public object Match(string text) { throw null; }
    }
    [System.Security.Permissions.PermissionSetAttribute(System.Security.Permissions.SecurityAction.InheritanceDemand, Name="FullTrust")]
    [System.Security.Permissions.PermissionSetAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Name="FullTrust")]
    public abstract partial class ServerProtocol
    {
        protected ServerProtocol() { }
        protected internal System.Web.HttpContext Context { get { throw null; } }
        protected internal System.Web.HttpRequest Request { get { throw null; } }
        protected internal System.Web.HttpResponse Response { get { throw null; } }
        protected internal virtual object Target { get { throw null; } }
        protected void AddToCache(System.Type protocolType, System.Type serverType, object value) { }
        protected object GetFromCache(System.Type protocolType, System.Type serverType) { throw null; }
    }
    [System.Security.Permissions.PermissionSetAttribute(System.Security.Permissions.SecurityAction.InheritanceDemand, Name="FullTrust")]
    [System.Security.Permissions.PermissionSetAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Name="FullTrust")]
    public abstract partial class ServerProtocolFactory
    {
        protected ServerProtocolFactory() { }
        protected abstract System.Web.Services.Protocols.ServerProtocol CreateIfRequestCompatible(System.Web.HttpRequest request);
    }
    [System.Security.Permissions.PermissionSetAttribute(System.Security.Permissions.SecurityAction.InheritanceDemand, Name="FullTrust")]
    [System.Security.Permissions.PermissionSetAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Name="FullTrust")]
    public partial class ServerType
    {
        public ServerType(System.Type type) { }
    }
    public sealed partial class Soap12FaultCodes
    {
        internal Soap12FaultCodes() { }
        public static readonly System.Xml.XmlQualifiedName DataEncodingUnknownFaultCode;
        public static readonly System.Xml.XmlQualifiedName EncodingMissingIdFaultCode;
        public static readonly System.Xml.XmlQualifiedName EncodingUntypedValueFaultCode;
        public static readonly System.Xml.XmlQualifiedName MustUnderstandFaultCode;
        public static readonly System.Xml.XmlQualifiedName ReceiverFaultCode;
        public static readonly System.Xml.XmlQualifiedName RpcBadArgumentsFaultCode;
        public static readonly System.Xml.XmlQualifiedName RpcProcedureNotPresentFaultCode;
        public static readonly System.Xml.XmlQualifiedName SenderFaultCode;
        public static readonly System.Xml.XmlQualifiedName VersionMismatchFaultCode;
    }
    public sealed partial class SoapClientMessage : System.Web.Services.Protocols.SoapMessage
    {
        internal SoapClientMessage() { }
        public override string Action { get { throw null; } }
        public System.Web.Services.Protocols.SoapHttpClientProtocol Client { get { throw null; } }
        public override System.Web.Services.Protocols.LogicalMethodInfo MethodInfo { get { throw null; } }
        public override bool OneWay { get { throw null; } }
        [System.Runtime.InteropServices.ComVisibleAttribute(false)]
        public override System.Web.Services.Protocols.SoapProtocolVersion SoapVersion { get { throw null; } }
        public override string Url { get { throw null; } }
        protected override void EnsureInStage() { }
        protected override void EnsureOutStage() { }
    }
    [System.AttributeUsageAttribute((System.AttributeTargets)(64))]
    public sealed partial class SoapDocumentMethodAttribute : System.Attribute
    {
        public SoapDocumentMethodAttribute() { }
        public SoapDocumentMethodAttribute(string action) { }
        public string Action { get { throw null; } set { } }
        public string Binding { get { throw null; } set { } }
        public bool OneWay { get { throw null; } set { } }
        public System.Web.Services.Protocols.SoapParameterStyle ParameterStyle { get { throw null; } set { } }
        public string RequestElementName { get { throw null; } set { } }
        public string RequestNamespace { get { throw null; } set { } }
        public string ResponseElementName { get { throw null; } set { } }
        public string ResponseNamespace { get { throw null; } set { } }
        public System.Web.Services.Description.SoapBindingUse Use { get { throw null; } set { } }
    }
    [System.AttributeUsageAttribute((System.AttributeTargets)(4))]
    public sealed partial class SoapDocumentServiceAttribute : System.Attribute
    {
        public SoapDocumentServiceAttribute() { }
        public SoapDocumentServiceAttribute(System.Web.Services.Description.SoapBindingUse use) { }
        public SoapDocumentServiceAttribute(System.Web.Services.Description.SoapBindingUse use, System.Web.Services.Protocols.SoapParameterStyle paramStyle) { }
        public System.Web.Services.Protocols.SoapParameterStyle ParameterStyle { get { throw null; } set { } }
        public System.Web.Services.Protocols.SoapServiceRoutingStyle RoutingStyle { get { throw null; } set { } }
        public System.Web.Services.Description.SoapBindingUse Use { get { throw null; } set { } }
    }
    [System.SerializableAttribute]
    public partial class SoapException : System.SystemException
    {
        public static readonly System.Xml.XmlQualifiedName ClientFaultCode;
        public static readonly System.Xml.XmlQualifiedName DetailElementName;
        public static readonly System.Xml.XmlQualifiedName MustUnderstandFaultCode;
        public static readonly System.Xml.XmlQualifiedName ServerFaultCode;
        public static readonly System.Xml.XmlQualifiedName VersionMismatchFaultCode;
        public SoapException() { }
        protected SoapException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
        public SoapException(string message, System.Xml.XmlQualifiedName code) { }
        public SoapException(string message, System.Xml.XmlQualifiedName code, System.Exception innerException) { }
        public SoapException(string message, System.Xml.XmlQualifiedName code, string actor) { }
        public SoapException(string message, System.Xml.XmlQualifiedName code, string actor, System.Exception innerException) { }
        public SoapException(string message, System.Xml.XmlQualifiedName code, string actor, string role, string lang, System.Xml.XmlNode detail, System.Web.Services.Protocols.SoapFaultSubCode subCode, System.Exception innerException) { }
        public SoapException(string message, System.Xml.XmlQualifiedName code, string actor, string role, System.Xml.XmlNode detail, System.Web.Services.Protocols.SoapFaultSubCode subCode, System.Exception innerException) { }
        public SoapException(string message, System.Xml.XmlQualifiedName code, string actor, System.Xml.XmlNode detail) { }
        public SoapException(string message, System.Xml.XmlQualifiedName code, string actor, System.Xml.XmlNode detail, System.Exception innerException) { }
        public SoapException(string message, System.Xml.XmlQualifiedName code, System.Web.Services.Protocols.SoapFaultSubCode subCode) { }
        public string Actor { get { throw null; } }
        public System.Xml.XmlQualifiedName Code { get { throw null; } }
        public System.Xml.XmlNode Detail { get { throw null; } }
        [System.Runtime.InteropServices.ComVisibleAttribute(false)]
        public string Lang { get { throw null; } }
        [System.Runtime.InteropServices.ComVisibleAttribute(false)]
        public string Node { get { throw null; } }
        [System.Runtime.InteropServices.ComVisibleAttribute(false)]
        public string Role { get { throw null; } }
        [System.Runtime.InteropServices.ComVisibleAttribute(false)]
        public System.Web.Services.Protocols.SoapFaultSubCode SubCode { get { throw null; } }
        [System.Security.Permissions.SecurityPermissionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Flags=(System.Security.Permissions.SecurityPermissionFlag)(128))]
        public override void GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
        public static bool IsClientFaultCode(System.Xml.XmlQualifiedName code) { throw null; }
        public static bool IsMustUnderstandFaultCode(System.Xml.XmlQualifiedName code) { throw null; }
        public static bool IsServerFaultCode(System.Xml.XmlQualifiedName code) { throw null; }
        public static bool IsVersionMismatchFaultCode(System.Xml.XmlQualifiedName code) { throw null; }
    }
    public abstract partial class SoapExtension
    {
        protected SoapExtension() { }
        public virtual System.IO.Stream ChainStream(System.IO.Stream stream) { throw null; }
        public abstract object GetInitializer(System.Type serviceType);
        public abstract object GetInitializer(System.Web.Services.Protocols.LogicalMethodInfo methodInfo, System.Web.Services.Protocols.SoapExtensionAttribute attribute);
        public abstract void Initialize(object initializer);
        public abstract void ProcessMessage(System.Web.Services.Protocols.SoapMessage message);
    }
    public abstract partial class SoapExtensionAttribute : System.Attribute
    {
        protected SoapExtensionAttribute() { }
        public abstract System.Type ExtensionType { get; }
        public abstract int Priority { get; set; }
    }
    [System.SerializableAttribute]
    public partial class SoapFaultSubCode
    {
        public SoapFaultSubCode(System.Xml.XmlQualifiedName code) { }
        public SoapFaultSubCode(System.Xml.XmlQualifiedName code, System.Web.Services.Protocols.SoapFaultSubCode subCode) { }
        public System.Xml.XmlQualifiedName Code { get { throw null; } }
        public System.Web.Services.Protocols.SoapFaultSubCode SubCode { get { throw null; } }
    }
    [System.Xml.Serialization.SoapTypeAttribute(IncludeInSchema=false)]
    [System.Xml.Serialization.XmlTypeAttribute(IncludeInSchema=false)]
    public abstract partial class SoapHeader
    {
        protected SoapHeader() { }
        [System.ComponentModel.DefaultValueAttribute("")]
        [System.Xml.Serialization.SoapAttributeAttribute("actor", Namespace="http://schemas.xmlsoap.org/soap/envelope/")]
        [System.Xml.Serialization.XmlAttributeAttribute("actor", Namespace="http://schemas.xmlsoap.org/soap/envelope/")]
        public string Actor { get { throw null; } set { } }
        [System.Xml.Serialization.SoapIgnoreAttribute]
        [System.Xml.Serialization.XmlIgnoreAttribute]
        public bool DidUnderstand { get { throw null; } set { } }
        [System.ComponentModel.DefaultValueAttribute("0")]
        [System.Xml.Serialization.SoapAttributeAttribute("mustUnderstand", Namespace="http://schemas.xmlsoap.org/soap/envelope/")]
        [System.Xml.Serialization.XmlAttributeAttribute("mustUnderstand", Namespace="http://schemas.xmlsoap.org/soap/envelope/")]
        public string EncodedMustUnderstand { get { throw null; } set { } }
        [System.ComponentModel.DefaultValueAttribute("0")]
        [System.Runtime.InteropServices.ComVisibleAttribute(false)]
        [System.Xml.Serialization.SoapAttributeAttribute("mustUnderstand", Namespace="http://www.w3.org/2003/05/soap-envelope")]
        [System.Xml.Serialization.XmlAttributeAttribute("mustUnderstand", Namespace="http://www.w3.org/2003/05/soap-envelope")]
        public string EncodedMustUnderstand12 { get { throw null; } set { } }
        [System.ComponentModel.DefaultValueAttribute("0")]
        [System.Runtime.InteropServices.ComVisibleAttribute(false)]
        [System.Xml.Serialization.SoapAttributeAttribute("relay", Namespace="http://www.w3.org/2003/05/soap-envelope")]
        [System.Xml.Serialization.XmlAttributeAttribute("relay", Namespace="http://www.w3.org/2003/05/soap-envelope")]
        public string EncodedRelay { get { throw null; } set { } }
        [System.Xml.Serialization.SoapIgnoreAttribute]
        [System.Xml.Serialization.XmlIgnoreAttribute]
        public bool MustUnderstand { get { throw null; } set { } }
        [System.Runtime.InteropServices.ComVisibleAttribute(false)]
        [System.Xml.Serialization.SoapIgnoreAttribute]
        [System.Xml.Serialization.XmlIgnoreAttribute]
        public bool Relay { get { throw null; } set { } }
        [System.ComponentModel.DefaultValueAttribute("")]
        [System.Runtime.InteropServices.ComVisibleAttribute(false)]
        [System.Xml.Serialization.SoapAttributeAttribute("role", Namespace="http://www.w3.org/2003/05/soap-envelope")]
        [System.Xml.Serialization.XmlAttributeAttribute("role", Namespace="http://www.w3.org/2003/05/soap-envelope")]
        public string Role { get { throw null; } set { } }
    }
    [System.AttributeUsageAttribute((System.AttributeTargets)(64), AllowMultiple=true)]
    public sealed partial class SoapHeaderAttribute : System.Attribute
    {
        public SoapHeaderAttribute(string memberName) { }
        public System.Web.Services.Protocols.SoapHeaderDirection Direction { get { throw null; } set { } }
        public string MemberName { get { throw null; } set { } }
        [System.ObsoleteAttribute("This property will be removed from a future version. The presence of a particular header in a SOAP message is no longer enforced", false)]
        public bool Required { get { throw null; } set { } }
    }
    [System.Security.Permissions.PermissionSetAttribute(System.Security.Permissions.SecurityAction.InheritanceDemand, Name="FullTrust")]
    public partial class SoapHeaderCollection : System.Collections.CollectionBase
    {
        public SoapHeaderCollection() { }
        public System.Web.Services.Protocols.SoapHeader this[int index] { get { throw null; } set { } }
        public int Add(System.Web.Services.Protocols.SoapHeader header) { throw null; }
        public bool Contains(System.Web.Services.Protocols.SoapHeader header) { throw null; }
        public void CopyTo(System.Web.Services.Protocols.SoapHeader[] array, int index) { }
        public int IndexOf(System.Web.Services.Protocols.SoapHeader header) { throw null; }
        public void Insert(int index, System.Web.Services.Protocols.SoapHeader header) { }
        public void Remove(System.Web.Services.Protocols.SoapHeader header) { }
    }
    [System.FlagsAttribute]
    public enum SoapHeaderDirection
    {
        Fault = 4,
        In = 1,
        InOut = 3,
        Out = 2,
    }
    [System.SerializableAttribute]
    public partial class SoapHeaderException : System.Web.Services.Protocols.SoapException
    {
        public SoapHeaderException() { }
        protected SoapHeaderException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
        public SoapHeaderException(string message, System.Xml.XmlQualifiedName code) { }
        public SoapHeaderException(string message, System.Xml.XmlQualifiedName code, System.Exception innerException) { }
        public SoapHeaderException(string message, System.Xml.XmlQualifiedName code, string actor) { }
        public SoapHeaderException(string message, System.Xml.XmlQualifiedName code, string actor, System.Exception innerException) { }
        public SoapHeaderException(string message, System.Xml.XmlQualifiedName code, string actor, string role, string lang, System.Web.Services.Protocols.SoapFaultSubCode subCode, System.Exception innerException) { }
        public SoapHeaderException(string message, System.Xml.XmlQualifiedName code, string actor, string role, System.Web.Services.Protocols.SoapFaultSubCode subCode, System.Exception innerException) { }
    }
    [System.Security.Permissions.PermissionSetAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Name="FullTrust")]
    public sealed partial class SoapHeaderHandling
    {
        public SoapHeaderHandling() { }
        public static void EnsureHeadersUnderstood(System.Web.Services.Protocols.SoapHeaderCollection headers) { }
        public static void GetHeaderMembers(System.Web.Services.Protocols.SoapHeaderCollection headers, object target, System.Web.Services.Protocols.SoapHeaderMapping[] mappings, System.Web.Services.Protocols.SoapHeaderDirection direction, bool client) { }
        public string ReadHeaders(System.Xml.XmlReader reader, System.Xml.Serialization.XmlSerializer serializer, System.Web.Services.Protocols.SoapHeaderCollection headers, System.Web.Services.Protocols.SoapHeaderMapping[] mappings, System.Web.Services.Protocols.SoapHeaderDirection direction, string envelopeNS, string encodingStyle, bool checkRequiredHeaders) { throw null; }
        public static void SetHeaderMembers(System.Web.Services.Protocols.SoapHeaderCollection headers, object target, System.Web.Services.Protocols.SoapHeaderMapping[] mappings, System.Web.Services.Protocols.SoapHeaderDirection direction, bool client) { }
        public static void WriteHeaders(System.Xml.XmlWriter writer, System.Xml.Serialization.XmlSerializer serializer, System.Web.Services.Protocols.SoapHeaderCollection headers, System.Web.Services.Protocols.SoapHeaderMapping[] mappings, System.Web.Services.Protocols.SoapHeaderDirection direction, bool isEncoded, string defaultNS, bool serviceDefaultIsEncoded, string envelopeNS) { }
        public static void WriteUnknownHeaders(System.Xml.XmlWriter writer, System.Web.Services.Protocols.SoapHeaderCollection headers, string envelopeNS) { }
    }
    [System.Security.Permissions.PermissionSetAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Name="FullTrust")]
    public sealed partial class SoapHeaderMapping
    {
        internal SoapHeaderMapping() { }
        public bool Custom { get { throw null; } }
        public System.Web.Services.Protocols.SoapHeaderDirection Direction { get { throw null; } }
        public System.Type HeaderType { get { throw null; } }
        public System.Reflection.MemberInfo MemberInfo { get { throw null; } }
        public bool Repeats { get { throw null; } }
    }
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial class SoapHttpClientProtocol : System.Web.Services.Protocols.HttpWebClientProtocol
    {
        public SoapHttpClientProtocol() { }
        [System.ComponentModel.DefaultValueAttribute((System.Web.Services.Protocols.SoapProtocolVersion)(0))]
        [System.Runtime.InteropServices.ComVisibleAttribute(false)]
        public System.Web.Services.Protocols.SoapProtocolVersion SoapVersion { get { throw null; } set { } }
        protected System.IAsyncResult BeginInvoke(string methodName, object[] parameters, System.AsyncCallback callback, object asyncState) { throw null; }
        public void Discover() { }
        protected object[] EndInvoke(System.IAsyncResult asyncResult) { throw null; }
        [System.Security.Permissions.PermissionSetAttribute(System.Security.Permissions.SecurityAction.InheritanceDemand, Name="FullTrust")]
        protected virtual System.Xml.XmlReader GetReaderForMessage(System.Web.Services.Protocols.SoapClientMessage message, int bufferSize) { throw null; }
        protected override System.Net.WebRequest GetWebRequest(System.Uri uri) { throw null; }
        [System.Security.Permissions.PermissionSetAttribute(System.Security.Permissions.SecurityAction.InheritanceDemand, Name="FullTrust")]
        protected virtual System.Xml.XmlWriter GetWriterForMessage(System.Web.Services.Protocols.SoapClientMessage message, int bufferSize) { throw null; }
        protected object[] Invoke(string methodName, object[] parameters) { throw null; }
        protected void InvokeAsync(string methodName, object[] parameters, System.Threading.SendOrPostCallback callback) { }
        protected void InvokeAsync(string methodName, object[] parameters, System.Threading.SendOrPostCallback callback, object userState) { }
    }
    [System.Security.Permissions.PermissionSetAttribute(System.Security.Permissions.SecurityAction.InheritanceDemand, Name="FullTrust")]
    public abstract partial class SoapMessage
    {
        internal SoapMessage() { }
        public abstract string Action { get; }
        public string ContentEncoding { get { throw null; } set { } }
        public string ContentType { get { throw null; } set { } }
        public System.Web.Services.Protocols.SoapException Exception { get { throw null; } set { } }
        public System.Web.Services.Protocols.SoapHeaderCollection Headers { get { throw null; } }
        public abstract System.Web.Services.Protocols.LogicalMethodInfo MethodInfo { get; }
        public abstract bool OneWay { get; }
        [System.ComponentModel.DefaultValueAttribute((System.Web.Services.Protocols.SoapProtocolVersion)(0))]
        [System.Runtime.InteropServices.ComVisibleAttribute(false)]
        public virtual System.Web.Services.Protocols.SoapProtocolVersion SoapVersion { get { throw null; } }
        public System.Web.Services.Protocols.SoapMessageStage Stage { get { throw null; } }
        public System.IO.Stream Stream { get { throw null; } }
        public abstract string Url { get; }
        protected abstract void EnsureInStage();
        protected abstract void EnsureOutStage();
        protected void EnsureStage(System.Web.Services.Protocols.SoapMessageStage stage) { }
        public object GetInParameterValue(int index) { throw null; }
        public object GetOutParameterValue(int index) { throw null; }
        public object GetReturnValue() { throw null; }
    }
    public enum SoapMessageStage
    {
        AfterDeserialize = 8,
        AfterSerialize = 2,
        BeforeDeserialize = 4,
        BeforeSerialize = 1,
    }
    public enum SoapParameterStyle
    {
        Bare = 1,
        Default = 0,
        Wrapped = 2,
    }
    public enum SoapProtocolVersion
    {
        Default = 0,
        Soap11 = 1,
        Soap12 = 2,
    }
    [System.AttributeUsageAttribute((System.AttributeTargets)(64))]
    public sealed partial class SoapRpcMethodAttribute : System.Attribute
    {
        public SoapRpcMethodAttribute() { }
        public SoapRpcMethodAttribute(string action) { }
        public string Action { get { throw null; } set { } }
        public string Binding { get { throw null; } set { } }
        public bool OneWay { get { throw null; } set { } }
        public string RequestElementName { get { throw null; } set { } }
        public string RequestNamespace { get { throw null; } set { } }
        public string ResponseElementName { get { throw null; } set { } }
        public string ResponseNamespace { get { throw null; } set { } }
        [System.Runtime.InteropServices.ComVisibleAttribute(false)]
        public System.Web.Services.Description.SoapBindingUse Use { get { throw null; } set { } }
    }
    [System.AttributeUsageAttribute((System.AttributeTargets)(4))]
    public sealed partial class SoapRpcServiceAttribute : System.Attribute
    {
        public SoapRpcServiceAttribute() { }
        public System.Web.Services.Protocols.SoapServiceRoutingStyle RoutingStyle { get { throw null; } set { } }
        [System.Runtime.InteropServices.ComVisibleAttribute(false)]
        public System.Web.Services.Description.SoapBindingUse Use { get { throw null; } set { } }
    }
    public sealed partial class SoapServerMessage : System.Web.Services.Protocols.SoapMessage
    {
        internal SoapServerMessage() { }
        public override string Action { get { throw null; } }
        public override System.Web.Services.Protocols.LogicalMethodInfo MethodInfo { get { throw null; } }
        public override bool OneWay { get { throw null; } }
        public object Server { get { throw null; } }
        [System.Runtime.InteropServices.ComVisibleAttribute(false)]
        public override System.Web.Services.Protocols.SoapProtocolVersion SoapVersion { get { throw null; } }
        public override string Url { get { throw null; } }
        protected override void EnsureInStage() { }
        protected override void EnsureOutStage() { }
    }
    [System.Security.Permissions.PermissionSetAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Name="FullTrust")]
    public sealed partial class SoapServerMethod
    {
        public SoapServerMethod() { }
        public SoapServerMethod(System.Type serverType, System.Web.Services.Protocols.LogicalMethodInfo methodInfo) { }
        public string Action { get { throw null; } }
        public System.Web.Services.Description.SoapBindingUse BindingUse { get { throw null; } }
        public System.Web.Services.Protocols.SoapHeaderMapping[] InHeaderMappings { get { throw null; } }
        public System.Xml.Serialization.XmlSerializer InHeaderSerializer { get { throw null; } }
        public System.Web.Services.Protocols.LogicalMethodInfo MethodInfo { get { throw null; } }
        public bool OneWay { get { throw null; } }
        public System.Web.Services.Protocols.SoapHeaderMapping[] OutHeaderMappings { get { throw null; } }
        public System.Xml.Serialization.XmlSerializer OutHeaderSerializer { get { throw null; } }
        public System.Xml.Serialization.XmlSerializer ParameterSerializer { get { throw null; } }
        public System.Web.Services.Protocols.SoapParameterStyle ParameterStyle { get { throw null; } }
        public System.Xml.Serialization.XmlSerializer ReturnSerializer { get { throw null; } }
        public bool Rpc { get { throw null; } }
        public System.Web.Services.WsiProfiles WsiClaims { get { throw null; } }
    }
    [System.Security.Permissions.PermissionSetAttribute(System.Security.Permissions.SecurityAction.InheritanceDemand, Name="FullTrust")]
    [System.Security.Permissions.PermissionSetAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Name="FullTrust")]
    public partial class SoapServerProtocol : System.Web.Services.Protocols.ServerProtocol
    {
        protected internal SoapServerProtocol() { }
        [System.Security.Permissions.PermissionSetAttribute(System.Security.Permissions.SecurityAction.InheritanceDemand, Name="FullTrust")]
        protected virtual System.Xml.XmlReader GetReaderForMessage(System.Web.Services.Protocols.SoapServerMessage message, int bufferSize) { throw null; }
        [System.Security.Permissions.PermissionSetAttribute(System.Security.Permissions.SecurityAction.InheritanceDemand, Name="FullTrust")]
        protected virtual System.Xml.XmlWriter GetWriterForMessage(System.Web.Services.Protocols.SoapServerMessage message, int bufferSize) { throw null; }
        protected virtual System.Web.Services.Protocols.SoapExtension[] ModifyInitializedExtensions(System.Web.Services.Configuration.PriorityGroup group, System.Web.Services.Protocols.SoapExtension[] extensions) { throw null; }
        protected virtual System.Web.Services.Protocols.SoapServerMethod RouteRequest(System.Web.Services.Protocols.SoapServerMessage message) { throw null; }
    }
    [System.Security.Permissions.PermissionSetAttribute(System.Security.Permissions.SecurityAction.InheritanceDemand, Name="FullTrust")]
    [System.Security.Permissions.PermissionSetAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Name="FullTrust")]
    public partial class SoapServerProtocolFactory : System.Web.Services.Protocols.ServerProtocolFactory
    {
        public SoapServerProtocolFactory() { }
        protected override System.Web.Services.Protocols.ServerProtocol CreateIfRequestCompatible(System.Web.HttpRequest request) { throw null; }
    }
    [System.Security.Permissions.PermissionSetAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Name="FullTrust")]
    public sealed partial class SoapServerType : System.Web.Services.Protocols.ServerType
    {
        public SoapServerType(System.Type type, System.Web.Services.Configuration.WebServiceProtocols protocolsSupported) : base (default(System.Type)) { }
        public bool ServiceDefaultIsEncoded { get { throw null; } }
        public string ServiceNamespace { get { throw null; } }
        public bool ServiceRoutingOnSoapAction { get { throw null; } }
        public System.Web.Services.Protocols.SoapServerMethod GetDuplicateMethod(object key) { throw null; }
        public System.Web.Services.Protocols.SoapServerMethod GetMethod(object key) { throw null; }
    }
    public enum SoapServiceRoutingStyle
    {
        RequestElement = 1,
        SoapAction = 0,
    }
    public sealed partial class SoapUnknownHeader : System.Web.Services.Protocols.SoapHeader
    {
        public SoapUnknownHeader() { }
        [System.Xml.Serialization.XmlIgnoreAttribute]
        public System.Xml.XmlElement Element { get { throw null; } set { } }
    }
    [System.Security.Permissions.PermissionSetAttribute(System.Security.Permissions.SecurityAction.InheritanceDemand, Name="FullTrust")]
    public partial class TextReturnReader : System.Web.Services.Protocols.MimeReturnReader
    {
        public TextReturnReader() { }
        public override object GetInitializer(System.Web.Services.Protocols.LogicalMethodInfo methodInfo) { throw null; }
        public override void Initialize(object o) { }
        public override object Read(System.Net.WebResponse response, System.IO.Stream responseStream) { throw null; }
    }
    public abstract partial class UrlEncodedParameterWriter : System.Web.Services.Protocols.MimeParameterWriter
    {
        protected UrlEncodedParameterWriter() { }
        public override System.Text.Encoding RequestEncoding { get { throw null; } set { } }
        protected void Encode(System.IO.TextWriter writer, object[] values) { }
        protected void Encode(System.IO.TextWriter writer, string name, object value) { }
        public override object GetInitializer(System.Web.Services.Protocols.LogicalMethodInfo methodInfo) { throw null; }
        public override void Initialize(object initializer) { }
    }
    public partial class UrlParameterReader : System.Web.Services.Protocols.ValueCollectionParameterReader
    {
        public UrlParameterReader() { }
        public override object[] Read(System.Web.HttpRequest request) { throw null; }
    }
    public partial class UrlParameterWriter : System.Web.Services.Protocols.UrlEncodedParameterWriter
    {
        public UrlParameterWriter() { }
        public override string GetRequestUrl(string url, object[] parameters) { throw null; }
    }
    public abstract partial class ValueCollectionParameterReader : System.Web.Services.Protocols.MimeParameterReader
    {
        protected ValueCollectionParameterReader() { }
        public override object GetInitializer(System.Web.Services.Protocols.LogicalMethodInfo methodInfo) { throw null; }
        public override void Initialize(object o) { }
        public static bool IsSupported(System.Reflection.ParameterInfo paramInfo) { throw null; }
        public static bool IsSupported(System.Web.Services.Protocols.LogicalMethodInfo methodInfo) { throw null; }
        protected object[] Read(System.Collections.Specialized.NameValueCollection collection) { throw null; }
    }
    [System.Security.Permissions.PermissionSetAttribute(System.Security.Permissions.SecurityAction.InheritanceDemand, Name="FullTrust")]
    public partial class WebClientAsyncResult : System.IAsyncResult
    {
        internal WebClientAsyncResult() { }
        public object AsyncState { get { throw null; } }
        public System.Threading.WaitHandle AsyncWaitHandle { get { throw null; } }
        public bool CompletedSynchronously { get { throw null; } }
        public bool IsCompleted { get { throw null; } }
        public void Abort() { }
    }
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public abstract partial class WebClientProtocol : System.ComponentModel.Component
    {
        protected WebClientProtocol() { }
        [System.ComponentModel.DefaultValueAttribute("")]
        public string ConnectionGroupName { get { throw null; } set { } }
        public System.Net.ICredentials Credentials { get { throw null; } set { } }
        [System.ComponentModel.DefaultValueAttribute(false)]
        public bool PreAuthenticate { get { throw null; } set { } }
        [System.ComponentModel.DefaultValueAttribute(null)]
        [System.ComponentModel.SettingsBindableAttribute(true)]
        public System.Text.Encoding RequestEncoding { get { throw null; } set { } }
        [System.ComponentModel.DefaultValueAttribute(100000)]
        [System.ComponentModel.SettingsBindableAttribute(true)]
        public int Timeout { get { throw null; } set { } }
        [System.ComponentModel.DefaultValueAttribute("")]
        [System.ComponentModel.SettingsBindableAttribute(true)]
        public string Url { get { throw null; } set { } }
        public bool UseDefaultCredentials { get { throw null; } set { } }
        public virtual void Abort() { }
        protected static void AddToCache(System.Type type, object value) { }
        protected static object GetFromCache(System.Type type) { throw null; }
        protected virtual System.Net.WebRequest GetWebRequest(System.Uri uri) { throw null; }
        protected virtual System.Net.WebResponse GetWebResponse(System.Net.WebRequest request) { throw null; }
        protected virtual System.Net.WebResponse GetWebResponse(System.Net.WebRequest request, System.IAsyncResult result) { throw null; }
    }
    [System.Security.Permissions.PermissionSetAttribute(System.Security.Permissions.SecurityAction.InheritanceDemand, Name="FullTrust")]
    public partial class WebServiceHandlerFactory : System.Web.IHttpHandlerFactory
    {
        public WebServiceHandlerFactory() { }
        public System.Web.IHttpHandler GetHandler(System.Web.HttpContext context, string verb, string url, string filePath) { throw null; }
        public void ReleaseHandler(System.Web.IHttpHandler handler) { }
    }
    public partial class XmlReturnReader : System.Web.Services.Protocols.MimeReturnReader
    {
        public XmlReturnReader() { }
        public override object GetInitializer(System.Web.Services.Protocols.LogicalMethodInfo methodInfo) { throw null; }
        public override object[] GetInitializers(System.Web.Services.Protocols.LogicalMethodInfo[] methodInfos) { throw null; }
        public override void Initialize(object o) { }
        public override object Read(System.Net.WebResponse response, System.IO.Stream responseStream) { throw null; }
    }
}
