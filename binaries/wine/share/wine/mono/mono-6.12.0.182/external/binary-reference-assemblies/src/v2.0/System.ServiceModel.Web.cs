// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

[assembly:System.Reflection.AssemblyVersionAttribute("3.5.0.0")]
[assembly:System.CLSCompliantAttribute(true)]
[assembly:System.Diagnostics.DebuggableAttribute((System.Diagnostics.DebuggableAttribute.DebuggingModes)(2))]
[assembly:System.Reflection.AssemblyCompanyAttribute("MONO development team")]
[assembly:System.Reflection.AssemblyCopyrightAttribute("(c) 2003 Various Authors")]
[assembly:System.Reflection.AssemblyDefaultAliasAttribute("System.ServiceModel.Web.dll")]
[assembly:System.Reflection.AssemblyDescriptionAttribute("System.ServiceModel.Web.dll")]
[assembly:System.Reflection.AssemblyFileVersionAttribute("3.5.21022.8")]
[assembly:System.Reflection.AssemblyInformationalVersionAttribute("3.5.594.0")]
[assembly:System.Reflection.AssemblyProductAttribute("MONO CLI")]
[assembly:System.Reflection.AssemblyTitleAttribute("System.ServiceModel.Web.dll")]
[assembly:System.Resources.NeutralResourcesLanguageAttribute("en-US")]
[assembly:System.Resources.SatelliteContractVersionAttribute("3.5.0.0")]
[assembly:System.Runtime.CompilerServices.CompilationRelaxationsAttribute((System.Runtime.CompilerServices.CompilationRelaxations)(8))]
[assembly:System.Runtime.CompilerServices.InternalsVisibleToAttribute("dummy-System.Json, PublicKey=00240000048000009400000006020000002400005253413100040000010001008D56C76F9E8649383049F383C44BE0EC204181822A6C31CF5EB7EF486944D032188EA1D3920763712CCB12D75FB77E9811149E6148E5D32FBAAB37611C1878DDC19E20EF135D0CB2CFF2BFEC3D115810C3D9069638FE4BE215DBF795861920E5AB6F7DB2E2CEEF136AC23D5DD2BF031700AEC232F6C6B1C785B4305C123B37AB")]
[assembly:System.Runtime.CompilerServices.RuntimeCompatibilityAttribute(WrapNonExceptionThrows=true)]
[assembly:System.Runtime.InteropServices.ComVisibleAttribute(false)]
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
    public partial class UriTemplate
    {
        public UriTemplate(string template) { }
        public UriTemplate(string template, bool ignoreTrailingSlash) { }
        public UriTemplate(string template, bool ignoreTrailingSlash, System.Collections.Generic.IDictionary<string, string> additionalDefaults) { }
        public UriTemplate(string template, System.Collections.Generic.IDictionary<string, string> additionalDefaults) { }
        public System.Collections.Generic.IDictionary<string, string> Defaults { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        public bool IgnoreTrailingSlash { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        public System.Collections.ObjectModel.ReadOnlyCollection<string> PathSegmentVariableNames { get { throw null; } }
        public System.Collections.ObjectModel.ReadOnlyCollection<string> QueryValueVariableNames { get { throw null; } }
        public System.Uri BindByName(System.Uri baseAddress, System.Collections.Generic.IDictionary<string, string> parameters) { throw null; }
        public System.Uri BindByName(System.Uri baseAddress, System.Collections.Generic.IDictionary<string, string> parameters, bool omitDefaults) { throw null; }
        public System.Uri BindByName(System.Uri baseAddress, System.Collections.Specialized.NameValueCollection parameters) { throw null; }
        public System.Uri BindByName(System.Uri baseAddress, System.Collections.Specialized.NameValueCollection parameters, bool omitDefaults) { throw null; }
        public System.Uri BindByPosition(System.Uri baseAddress, params string[] values) { throw null; }
        public bool IsEquivalentTo(System.UriTemplate other) { throw null; }
        public System.UriTemplateMatch Match(System.Uri baseAddress, System.Uri candidate) { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class UriTemplateEquivalenceComparer : System.Collections.Generic.IEqualityComparer<System.UriTemplate>
    {
        public UriTemplateEquivalenceComparer() { }
        public bool Equals(System.UriTemplate x, System.UriTemplate y) { throw null; }
        public int GetHashCode(System.UriTemplate obj) { throw null; }
    }
    public partial class UriTemplateMatch
    {
        public UriTemplateMatch() { }
        public System.Uri BaseUri { get { throw null; } set { } }
        public System.Collections.Specialized.NameValueCollection BoundVariables { get { throw null; } }
        public object Data { get { throw null; } set { } }
        public System.Collections.Specialized.NameValueCollection QueryParameters { get { throw null; } }
        public System.Collections.ObjectModel.Collection<string> RelativePathSegments { get { throw null; } }
        public System.Uri RequestUri { get { throw null; } set { } }
        public System.UriTemplate Template { get { throw null; } set { } }
        public System.Collections.ObjectModel.Collection<string> WildcardPathSegments { get { throw null; } }
    }
    [System.SerializableAttribute]
    public partial class UriTemplateMatchException : System.SystemException
    {
        public UriTemplateMatchException() { }
        protected UriTemplateMatchException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
        public UriTemplateMatchException(string msg) { }
        public UriTemplateMatchException(string msg, System.Exception inner) { }
    }
    public partial class UriTemplateTable
    {
        public UriTemplateTable() { }
        public UriTemplateTable(System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.UriTemplate, object>> keyValuePairs) { }
        public UriTemplateTable(System.Uri baseAddress) { }
        public UriTemplateTable(System.Uri baseAddress, System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.UriTemplate, object>> keyValuePairs) { }
        public System.Uri BaseAddress { get { throw null; } set { } }
        public bool IsReadOnly { get { throw null; } }
        public System.Collections.Generic.IList<System.Collections.Generic.KeyValuePair<System.UriTemplate, object>> KeyValuePairs { get { throw null; } }
        [System.MonoTODOAttribute]
        public void MakeReadOnly(bool allowDuplicateEquivalentUriTemplates) { }
        public System.Collections.ObjectModel.Collection<System.UriTemplateMatch> Match(System.Uri uri) { throw null; }
        public System.UriTemplateMatch MatchSingle(System.Uri uri) { throw null; }
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
namespace System.ServiceModel
{
    public partial class WebHttpBinding : System.ServiceModel.Channels.Binding, System.ServiceModel.Channels.IBindingRuntimePreferences
    {
        public WebHttpBinding() { }
        public WebHttpBinding(System.ServiceModel.WebHttpSecurityMode mode) { }
        public WebHttpBinding(string configurationName) { }
        public bool AllowCookies { get { throw null; } set { } }
        public bool BypassProxyOnLocal { get { throw null; } set { } }
        public System.ServiceModel.EnvelopeVersion EnvelopeVersion { get { throw null; } }
        public System.ServiceModel.HostNameComparisonMode HostNameComparisonMode { get { throw null; } set { } }
        public long MaxBufferPoolSize { get { throw null; } set { } }
        public int MaxBufferSize { get { throw null; } set { } }
        public long MaxReceivedMessageSize { get { throw null; } set { } }
        public System.Uri ProxyAddress { get { throw null; } set { } }
        public System.Xml.XmlDictionaryReaderQuotas ReaderQuotas { get { throw null; } set { } }
        public override string Scheme { get { throw null; } }
        public System.ServiceModel.WebHttpSecurity Security { get { throw null; } }
        bool System.ServiceModel.Channels.IBindingRuntimePreferences.ReceiveSynchronously { get { throw null; } }
        public System.ServiceModel.TransferMode TransferMode { get { throw null; } set { } }
        public bool UseDefaultWebProxy { get { throw null; } set { } }
        public System.Text.Encoding WriteEncoding { get { throw null; } set { } }
        public override System.ServiceModel.Channels.BindingElementCollection CreateBindingElements() { throw null; }
    }
    public sealed partial class WebHttpSecurity
    {
        internal WebHttpSecurity() { }
        public System.ServiceModel.WebHttpSecurityMode Mode { get { throw null; } set { } }
        public System.ServiceModel.HttpTransportSecurity Transport { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
    }
    public enum WebHttpSecurityMode
    {
        None = 0,
        Transport = 1,
        TransportCredentialOnly = 2,
    }
}
namespace System.ServiceModel.Activation
{
    public partial class WebScriptServiceHostFactory : System.ServiceModel.Activation.ServiceHostFactory
    {
        public WebScriptServiceHostFactory() { }
        protected override System.ServiceModel.ServiceHost CreateServiceHost(System.Type serviceType, System.Uri[] baseAddresses) { throw null; }
    }
    public partial class WebServiceHostFactory : System.ServiceModel.Activation.ServiceHostFactory
    {
        public WebServiceHostFactory() { }
        protected override System.ServiceModel.ServiceHost CreateServiceHost(System.Type serviceType, System.Uri[] baseAddresses) { throw null; }
    }
}
namespace System.ServiceModel.Channels
{
    public sealed partial class WebBodyFormatMessageProperty : System.ServiceModel.Channels.IMessageProperty
    {
        public const string Name = "WebBodyFormatMessageProperty";
        public WebBodyFormatMessageProperty(System.ServiceModel.Channels.WebContentFormat format) { }
        public System.ServiceModel.Channels.WebContentFormat Format { get { throw null; } }
        public System.ServiceModel.Channels.IMessageProperty CreateCopy() { throw null; }
        public override string ToString() { throw null; }
    }
    public enum WebContentFormat
    {
        Default = 0,
        Json = 2,
        Raw = 3,
        Xml = 1,
    }
    public abstract partial class WebContentTypeMapper
    {
        protected WebContentTypeMapper() { }
        public abstract System.ServiceModel.Channels.WebContentFormat GetMessageFormatForContentType(string contentType);
    }
    public sealed partial class WebMessageEncodingBindingElement : System.ServiceModel.Channels.MessageEncodingBindingElement, System.ServiceModel.Description.IWsdlExportExtension
    {
        public WebMessageEncodingBindingElement() { }
        public WebMessageEncodingBindingElement(System.Text.Encoding writeEncoding) { }
        public System.ServiceModel.Channels.WebContentTypeMapper ContentTypeMapper { get { throw null; } set { } }
        [System.MonoTODOAttribute]
        public int MaxReadPoolSize { get { throw null; } set { } }
        [System.MonoTODOAttribute]
        public int MaxWritePoolSize { get { throw null; } set { } }
        public override System.ServiceModel.Channels.MessageVersion MessageVersion { get { throw null; } set { } }
        public System.Xml.XmlDictionaryReaderQuotas ReaderQuotas { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        public System.Text.Encoding WriteEncoding { get { throw null; } set { } }
        public override System.ServiceModel.Channels.IChannelFactory<TChannel> BuildChannelFactory<TChannel>(System.ServiceModel.Channels.BindingContext context) { throw null; }
        public override System.ServiceModel.Channels.IChannelListener<TChannel> BuildChannelListener<TChannel>(System.ServiceModel.Channels.BindingContext context) { throw null; }
        [System.MonoTODOAttribute("Why is it overriden?")]
        public override bool CanBuildChannelListener<TChannel>(System.ServiceModel.Channels.BindingContext context) { throw null; }
        public override System.ServiceModel.Channels.BindingElement Clone() { throw null; }
        public override System.ServiceModel.Channels.MessageEncoderFactory CreateMessageEncoderFactory() { throw null; }
        public override T GetProperty<T>(System.ServiceModel.Channels.BindingContext context) { throw null; }
        [System.MonoTODOAttribute]
        void System.ServiceModel.Description.IWsdlExportExtension.ExportContract(System.ServiceModel.Description.WsdlExporter exporter, System.ServiceModel.Description.WsdlContractConversionContext context) { }
        [System.MonoTODOAttribute]
        void System.ServiceModel.Description.IWsdlExportExtension.ExportEndpoint(System.ServiceModel.Description.WsdlExporter exporter, System.ServiceModel.Description.WsdlEndpointConversionContext context) { }
    }
}
namespace System.ServiceModel.Configuration
{
    public partial class WebHttpBindingCollectionElement : System.ServiceModel.Configuration.StandardBindingCollectionElement<System.ServiceModel.WebHttpBinding, System.ServiceModel.Configuration.WebHttpBindingElement>
    {
        public WebHttpBindingCollectionElement() { }
        protected internal override System.ServiceModel.Channels.Binding GetDefault() { throw null; }
    }
    public partial class WebHttpBindingElement : System.ServiceModel.Configuration.StandardBindingElement, System.ServiceModel.Configuration.IBindingConfigurationElement
    {
        public WebHttpBindingElement() { }
        public WebHttpBindingElement(string name) { }
        [System.Configuration.ConfigurationPropertyAttribute("allowCookies", DefaultValue=false, Options=(System.Configuration.ConfigurationPropertyOptions)(0))]
        public bool AllowCookies { get { throw null; } set { } }
        protected override System.Type BindingElementType { get { throw null; } }
        [System.Configuration.ConfigurationPropertyAttribute("bypassProxyOnLocal", DefaultValue=false, Options=(System.Configuration.ConfigurationPropertyOptions)(0))]
        public bool BypassProxyOnLocal { get { throw null; } set { } }
        [System.Configuration.ConfigurationPropertyAttribute("hostNameComparisonMode", DefaultValue="StrongWildcard", Options=(System.Configuration.ConfigurationPropertyOptions)(0))]
        public System.ServiceModel.HostNameComparisonMode HostNameComparisonMode { get { throw null; } set { } }
        [System.Configuration.ConfigurationPropertyAttribute("maxBufferPoolSize", DefaultValue="524288", Options=(System.Configuration.ConfigurationPropertyOptions)(0))]
        [System.Configuration.LongValidatorAttribute(MinValue=(long)0, MaxValue=(long)9223372036854775807, ExcludeRange=false)]
        public long MaxBufferPoolSize { get { throw null; } set { } }
        [System.Configuration.ConfigurationPropertyAttribute("maxBufferSize", DefaultValue="65536", Options=(System.Configuration.ConfigurationPropertyOptions)(0))]
        [System.Configuration.IntegerValidatorAttribute(MinValue=1, MaxValue=2147483647, ExcludeRange=false)]
        public int MaxBufferSize { get { throw null; } set { } }
        [System.Configuration.ConfigurationPropertyAttribute("maxReceivedMessageSize", DefaultValue="65536", Options=(System.Configuration.ConfigurationPropertyOptions)(0))]
        [System.Configuration.LongValidatorAttribute(MinValue=(long)1, MaxValue=(long)9223372036854775807, ExcludeRange=false)]
        public long MaxReceivedMessageSize { get { throw null; } set { } }
        protected override System.Configuration.ConfigurationPropertyCollection Properties { get { throw null; } }
        [System.Configuration.ConfigurationPropertyAttribute("proxyAddress", DefaultValue=null, Options=(System.Configuration.ConfigurationPropertyOptions)(0))]
        public System.Uri ProxyAddress { get { throw null; } set { } }
        [System.Configuration.ConfigurationPropertyAttribute("readerQuotas", Options=(System.Configuration.ConfigurationPropertyOptions)(0))]
        public System.ServiceModel.Configuration.XmlDictionaryReaderQuotasElement ReaderQuotas { get { throw null; } }
        [System.Configuration.ConfigurationPropertyAttribute("security", Options=(System.Configuration.ConfigurationPropertyOptions)(0))]
        public System.ServiceModel.Configuration.WebHttpSecurityElement Security { get { throw null; } }
        [System.Configuration.ConfigurationPropertyAttribute("transferMode", DefaultValue="Buffered", Options=(System.Configuration.ConfigurationPropertyOptions)(0))]
        public System.ServiceModel.TransferMode TransferMode { get { throw null; } set { } }
        [System.Configuration.ConfigurationPropertyAttribute("useDefaultWebProxy", DefaultValue=true, Options=(System.Configuration.ConfigurationPropertyOptions)(0))]
        public bool UseDefaultWebProxy { get { throw null; } set { } }
        [System.ComponentModel.TypeConverterAttribute]
        [System.Configuration.ConfigurationPropertyAttribute("writeEncoding", DefaultValue="utf-8", Options=(System.Configuration.ConfigurationPropertyOptions)(0))]
        public System.Text.Encoding WriteEncoding { get { throw null; } set { } }
        protected internal override void InitializeFrom(System.ServiceModel.Channels.Binding binding) { }
        protected override void OnApplyConfiguration(System.ServiceModel.Channels.Binding binding) { }
    }
    public sealed partial class WebHttpElement : System.ServiceModel.Configuration.BehaviorExtensionElement
    {
        public WebHttpElement() { }
        public override System.Type BehaviorType { get { throw null; } }
        protected internal override object CreateBehavior() { throw null; }
    }
    public sealed partial class WebHttpSecurityElement : System.Configuration.ConfigurationElement
    {
        public WebHttpSecurityElement() { }
        [System.Configuration.ConfigurationPropertyAttribute("mode", DefaultValue="None", Options=(System.Configuration.ConfigurationPropertyOptions)(0))]
        public System.ServiceModel.WebHttpSecurityMode Mode { get { throw null; } set { } }
        protected override System.Configuration.ConfigurationPropertyCollection Properties { get { throw null; } }
        [System.Configuration.ConfigurationPropertyAttribute("transport", Options=(System.Configuration.ConfigurationPropertyOptions)(0))]
        public System.ServiceModel.Configuration.HttpTransportSecurityElement Transport { get { throw null; } }
    }
    public sealed partial class WebMessageEncodingElement : System.ServiceModel.Configuration.BindingElementExtensionElement
    {
        public WebMessageEncodingElement() { }
        public override System.Type BindingElementType { get { throw null; } }
        [System.Configuration.ConfigurationPropertyAttribute("maxReadPoolSize", Options=(System.Configuration.ConfigurationPropertyOptions)(0), DefaultValue="64")]
        [System.Configuration.IntegerValidatorAttribute(MinValue=1, MaxValue=2147483647, ExcludeRange=false)]
        public int MaxReadPoolSize { get { throw null; } set { } }
        [System.Configuration.ConfigurationPropertyAttribute("maxWritePoolSize", Options=(System.Configuration.ConfigurationPropertyOptions)(0), DefaultValue="16")]
        [System.Configuration.IntegerValidatorAttribute(MinValue=1, MaxValue=2147483647, ExcludeRange=false)]
        public int MaxWritePoolSize { get { throw null; } set { } }
        [System.Configuration.ConfigurationPropertyAttribute("readerQuotas", Options=(System.Configuration.ConfigurationPropertyOptions)(0))]
        public System.ServiceModel.Configuration.XmlDictionaryReaderQuotasElement ReaderQuotas { get { throw null; } }
        [System.Configuration.ConfigurationPropertyAttribute("webContentTypeMapperType", Options=(System.Configuration.ConfigurationPropertyOptions)(0), DefaultValue="")]
        [System.Configuration.StringValidatorAttribute(MinLength=0, MaxLength=2147483647)]
        public string WebContentTypeMapperType { get { throw null; } set { } }
        [System.ComponentModel.TypeConverterAttribute]
        [System.Configuration.ConfigurationPropertyAttribute("writeEncoding", Options=(System.Configuration.ConfigurationPropertyOptions)(0), DefaultValue="utf-8")]
        public System.Text.Encoding WriteEncoding { get { throw null; } set { } }
        public override void ApplyConfiguration(System.ServiceModel.Channels.BindingElement bindingElement) { }
        public override void CopyFrom(System.ServiceModel.Configuration.ServiceModelExtensionElement from) { }
        protected internal override System.ServiceModel.Channels.BindingElement CreateBindingElement() { throw null; }
    }
    public sealed partial class WebScriptEnablingElement : System.ServiceModel.Configuration.BehaviorExtensionElement
    {
        public WebScriptEnablingElement() { }
        public override System.Type BehaviorType { get { throw null; } }
        protected internal override object CreateBehavior() { throw null; }
    }
}
namespace System.ServiceModel.Description
{
    public partial class WebHttpBehavior : System.ServiceModel.Description.IEndpointBehavior
    {
        public WebHttpBehavior() { }
        public virtual System.ServiceModel.Web.WebMessageBodyStyle DefaultBodyStyle { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public virtual System.ServiceModel.Web.WebMessageFormat DefaultOutgoingRequestFormat { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public virtual System.ServiceModel.Web.WebMessageFormat DefaultOutgoingResponseFormat { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public virtual void AddBindingParameters(System.ServiceModel.Description.ServiceEndpoint endpoint, System.ServiceModel.Channels.BindingParameterCollection bindingParameters) { }
        [System.MonoTODOAttribute]
        protected virtual void AddClientErrorInspector(System.ServiceModel.Description.ServiceEndpoint endpoint, System.ServiceModel.Dispatcher.ClientRuntime clientRuntime) { }
        protected virtual void AddServerErrorHandlers(System.ServiceModel.Description.ServiceEndpoint endpoint, System.ServiceModel.Dispatcher.EndpointDispatcher endpointDispatcher) { }
        public virtual void ApplyClientBehavior(System.ServiceModel.Description.ServiceEndpoint endpoint, System.ServiceModel.Dispatcher.ClientRuntime clientRuntime) { }
        public virtual void ApplyDispatchBehavior(System.ServiceModel.Description.ServiceEndpoint endpoint, System.ServiceModel.Dispatcher.EndpointDispatcher endpointDispatcher) { }
        protected virtual System.ServiceModel.Dispatcher.WebHttpDispatchOperationSelector GetOperationSelector(System.ServiceModel.Description.ServiceEndpoint endpoint) { throw null; }
        protected virtual System.ServiceModel.Dispatcher.QueryStringConverter GetQueryStringConverter(System.ServiceModel.Description.OperationDescription operationDescription) { throw null; }
        protected virtual System.ServiceModel.Dispatcher.IClientMessageFormatter GetReplyClientFormatter(System.ServiceModel.Description.OperationDescription operationDescription, System.ServiceModel.Description.ServiceEndpoint endpoint) { throw null; }
        protected virtual System.ServiceModel.Dispatcher.IDispatchMessageFormatter GetReplyDispatchFormatter(System.ServiceModel.Description.OperationDescription operationDescription, System.ServiceModel.Description.ServiceEndpoint endpoint) { throw null; }
        protected virtual System.ServiceModel.Dispatcher.IClientMessageFormatter GetRequestClientFormatter(System.ServiceModel.Description.OperationDescription operationDescription, System.ServiceModel.Description.ServiceEndpoint endpoint) { throw null; }
        protected virtual System.ServiceModel.Dispatcher.IDispatchMessageFormatter GetRequestDispatchFormatter(System.ServiceModel.Description.OperationDescription operationDescription, System.ServiceModel.Description.ServiceEndpoint endpoint) { throw null; }
        [System.MonoTODOAttribute("check UriTemplate validity")]
        public virtual void Validate(System.ServiceModel.Description.ServiceEndpoint endpoint) { }
        protected virtual void ValidateBinding(System.ServiceModel.Description.ServiceEndpoint endpoint) { }
        protected void ValidateOperation(System.ServiceModel.Description.OperationDescription operation) { }
    }
    public sealed partial class WebScriptEnablingBehavior : System.ServiceModel.Description.WebHttpBehavior
    {
        public WebScriptEnablingBehavior() { }
        public override System.ServiceModel.Web.WebMessageBodyStyle DefaultBodyStyle { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public override System.ServiceModel.Web.WebMessageFormat DefaultOutgoingRequestFormat { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public override System.ServiceModel.Web.WebMessageFormat DefaultOutgoingResponseFormat { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        [System.MonoTODOAttribute]
        protected override void AddClientErrorInspector(System.ServiceModel.Description.ServiceEndpoint endpoint, System.ServiceModel.Dispatcher.ClientRuntime clientRuntime) { }
        [System.MonoTODOAttribute]
        protected override void AddServerErrorHandlers(System.ServiceModel.Description.ServiceEndpoint endpoint, System.ServiceModel.Dispatcher.EndpointDispatcher endpointDispatcher) { }
        [System.MonoTODOAttribute]
        public override void ApplyClientBehavior(System.ServiceModel.Description.ServiceEndpoint endpoint, System.ServiceModel.Dispatcher.ClientRuntime clientRuntime) { }
        public override void ApplyDispatchBehavior(System.ServiceModel.Description.ServiceEndpoint endpoint, System.ServiceModel.Dispatcher.EndpointDispatcher endpointDispatcher) { }
        protected override System.ServiceModel.Dispatcher.QueryStringConverter GetQueryStringConverter(System.ServiceModel.Description.OperationDescription operationDescription) { throw null; }
        [System.MonoTODOAttribute("add non-XmlSerializer-ness check (but where?)")]
        public override void Validate(System.ServiceModel.Description.ServiceEndpoint endpoint) { }
    }
}
namespace System.ServiceModel.Dispatcher
{
    public partial class JsonQueryStringConverter : System.ServiceModel.Dispatcher.QueryStringConverter
    {
        public JsonQueryStringConverter() { }
        public override bool CanConvert(System.Type type) { throw null; }
        public override object ConvertStringToValue(string parameter, System.Type parameterType) { throw null; }
        public override string ConvertValueToString(object parameter, System.Type parameterType) { throw null; }
    }
    public partial class QueryStringConverter
    {
        public QueryStringConverter() { }
        public virtual bool CanConvert(System.Type type) { throw null; }
        public virtual object ConvertStringToValue(string parameter, System.Type parameterType) { throw null; }
        public virtual string ConvertValueToString(object parameter, System.Type parameterType) { throw null; }
    }
    public partial class WebHttpDispatchOperationSelector : System.ServiceModel.Dispatcher.IDispatchOperationSelector
    {
        public const string HttpOperationSelectorUriMatchedPropertyName = "UriMatched";
        protected WebHttpDispatchOperationSelector() { }
        public WebHttpDispatchOperationSelector(System.ServiceModel.Description.ServiceEndpoint endpoint) { }
        public string SelectOperation(ref System.ServiceModel.Channels.Message message) { throw null; }
        protected virtual string SelectOperation(ref System.ServiceModel.Channels.Message message, out bool uriMatched) { uriMatched = default(bool); throw null; }
    }
}
namespace System.ServiceModel.Syndication
{
    [System.Xml.Serialization.XmlRootAttribute("feed", Namespace="http://www.w3.org/2005/Atom")]
    public partial class Atom10FeedFormatter : System.ServiceModel.Syndication.SyndicationFeedFormatter, System.Xml.Serialization.IXmlSerializable
    {
        public Atom10FeedFormatter() { }
        public Atom10FeedFormatter(System.ServiceModel.Syndication.SyndicationFeed feedToWrite) { }
        public Atom10FeedFormatter(System.Type feedTypeToCreate) { }
        protected System.Type FeedType { get { throw null; } }
        public bool PreserveAttributeExtensions { get { throw null; } set { } }
        public bool PreserveElementExtensions { get { throw null; } set { } }
        public override string Version { get { throw null; } }
        public override bool CanRead(System.Xml.XmlReader reader) { throw null; }
        protected override System.ServiceModel.Syndication.SyndicationFeed CreateFeedInstance() { throw null; }
        public override void ReadFrom(System.Xml.XmlReader reader) { }
        protected virtual System.ServiceModel.Syndication.SyndicationItem ReadItem(System.Xml.XmlReader reader, System.ServiceModel.Syndication.SyndicationFeed feed) { throw null; }
        protected virtual System.Collections.Generic.IEnumerable<System.ServiceModel.Syndication.SyndicationItem> ReadItems(System.Xml.XmlReader reader, System.ServiceModel.Syndication.SyndicationFeed feed, out bool areAllItemsRead) { areAllItemsRead = default(bool); throw null; }
        System.Xml.Schema.XmlSchema System.Xml.Serialization.IXmlSerializable.GetSchema() { throw null; }
        void System.Xml.Serialization.IXmlSerializable.ReadXml(System.Xml.XmlReader reader) { }
        void System.Xml.Serialization.IXmlSerializable.WriteXml(System.Xml.XmlWriter writer) { }
        [System.MonoTODOAttribute("Find out how feedBaseUri is used")]
        protected virtual void WriteItem(System.Xml.XmlWriter writer, System.ServiceModel.Syndication.SyndicationItem item, System.Uri feedBaseUri) { }
        protected virtual void WriteItems(System.Xml.XmlWriter writer, System.Collections.Generic.IEnumerable<System.ServiceModel.Syndication.SyndicationItem> items, System.Uri feedBaseUri) { }
        public override void WriteTo(System.Xml.XmlWriter writer) { }
    }
    [System.Xml.Serialization.XmlRootAttribute("feed", Namespace="http://www.w3.org/2005/Atom")]
    public partial class Atom10FeedFormatter<TSyndicationFeed> : System.ServiceModel.Syndication.Atom10FeedFormatter where TSyndicationFeed : System.ServiceModel.Syndication.SyndicationFeed, new()
    {
        public Atom10FeedFormatter() { }
        public Atom10FeedFormatter(TSyndicationFeed feedToWrite) { }
        protected override System.ServiceModel.Syndication.SyndicationFeed CreateFeedInstance() { throw null; }
    }
    [System.Xml.Serialization.XmlRootAttribute("entry", Namespace="http://www.w3.org/2005/Atom")]
    public partial class Atom10ItemFormatter : System.ServiceModel.Syndication.SyndicationItemFormatter, System.Xml.Serialization.IXmlSerializable
    {
        public Atom10ItemFormatter() { }
        public Atom10ItemFormatter(System.ServiceModel.Syndication.SyndicationItem feedToWrite) { }
        public Atom10ItemFormatter(System.Type itemTypeToCreate) { }
        protected System.Type ItemType { get { throw null; } }
        public bool PreserveAttributeExtensions { get { throw null; } set { } }
        public bool PreserveElementExtensions { get { throw null; } set { } }
        public override string Version { get { throw null; } }
        public override bool CanRead(System.Xml.XmlReader reader) { throw null; }
        protected override System.ServiceModel.Syndication.SyndicationItem CreateItemInstance() { throw null; }
        public override void ReadFrom(System.Xml.XmlReader reader) { }
        System.Xml.Schema.XmlSchema System.Xml.Serialization.IXmlSerializable.GetSchema() { throw null; }
        void System.Xml.Serialization.IXmlSerializable.ReadXml(System.Xml.XmlReader reader) { }
        void System.Xml.Serialization.IXmlSerializable.WriteXml(System.Xml.XmlWriter writer) { }
        public override void WriteTo(System.Xml.XmlWriter writer) { }
    }
    [System.Xml.Serialization.XmlRootAttribute("entry", Namespace="http://www.w3.org/2005/Atom")]
    public partial class Atom10ItemFormatter<TSyndicationItem> : System.ServiceModel.Syndication.Atom10ItemFormatter where TSyndicationItem : System.ServiceModel.Syndication.SyndicationItem, new()
    {
        public Atom10ItemFormatter() { }
        public Atom10ItemFormatter(TSyndicationItem itemToWrite) { }
        protected override System.ServiceModel.Syndication.SyndicationItem CreateItemInstance() { throw null; }
    }
    [System.Xml.Serialization.XmlRootAttribute("categories", Namespace="http://www.w3.org/2007/app")]
    public partial class AtomPub10CategoriesDocumentFormatter : System.ServiceModel.Syndication.CategoriesDocumentFormatter, System.Xml.Serialization.IXmlSerializable
    {
        public AtomPub10CategoriesDocumentFormatter() { }
        public AtomPub10CategoriesDocumentFormatter(System.ServiceModel.Syndication.CategoriesDocument documentToWrite) { }
        public AtomPub10CategoriesDocumentFormatter(System.Type inlineDocumentType, System.Type referencedDocumentType) { }
        public override string Version { get { throw null; } }
        public override bool CanRead(System.Xml.XmlReader reader) { throw null; }
        protected override System.ServiceModel.Syndication.InlineCategoriesDocument CreateInlineCategoriesDocument() { throw null; }
        protected override System.ServiceModel.Syndication.ReferencedCategoriesDocument CreateReferencedCategoriesDocument() { throw null; }
        public override void ReadFrom(System.Xml.XmlReader reader) { }
        System.Xml.Schema.XmlSchema System.Xml.Serialization.IXmlSerializable.GetSchema() { throw null; }
        void System.Xml.Serialization.IXmlSerializable.ReadXml(System.Xml.XmlReader reader) { }
        void System.Xml.Serialization.IXmlSerializable.WriteXml(System.Xml.XmlWriter writer) { }
        public override void WriteTo(System.Xml.XmlWriter writer) { }
    }
    [System.Xml.Serialization.XmlRootAttribute("service", Namespace="http://www.w3.org/2007/app")]
    public partial class AtomPub10ServiceDocumentFormatter : System.ServiceModel.Syndication.ServiceDocumentFormatter, System.Xml.Serialization.IXmlSerializable
    {
        public AtomPub10ServiceDocumentFormatter() { }
        public AtomPub10ServiceDocumentFormatter(System.ServiceModel.Syndication.ServiceDocument documentToWrite) { }
        public AtomPub10ServiceDocumentFormatter(System.Type documentTypeToCreate) { }
        public override string Version { get { throw null; } }
        public override bool CanRead(System.Xml.XmlReader reader) { throw null; }
        protected override System.ServiceModel.Syndication.ServiceDocument CreateDocumentInstance() { throw null; }
        public override void ReadFrom(System.Xml.XmlReader reader) { }
        System.Xml.Schema.XmlSchema System.Xml.Serialization.IXmlSerializable.GetSchema() { throw null; }
        void System.Xml.Serialization.IXmlSerializable.ReadXml(System.Xml.XmlReader reader) { }
        void System.Xml.Serialization.IXmlSerializable.WriteXml(System.Xml.XmlWriter writer) { }
        public override void WriteTo(System.Xml.XmlWriter writer) { }
    }
    [System.Xml.Serialization.XmlRootAttribute("service", Namespace="http://www.w3.org/2007/app")]
    public partial class AtomPub10ServiceDocumentFormatter<TServiceDocument> : System.ServiceModel.Syndication.AtomPub10ServiceDocumentFormatter where TServiceDocument : System.ServiceModel.Syndication.ServiceDocument, new()
    {
        public AtomPub10ServiceDocumentFormatter() { }
        public AtomPub10ServiceDocumentFormatter(TServiceDocument documentToWrite) { }
        protected override System.ServiceModel.Syndication.ServiceDocument CreateDocumentInstance() { throw null; }
    }
    public abstract partial class CategoriesDocument
    {
        internal CategoriesDocument() { }
        public System.Collections.Generic.Dictionary<System.Xml.XmlQualifiedName, string> AttributeExtensions { get { throw null; } }
        public System.Uri BaseUri { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public System.ServiceModel.Syndication.SyndicationElementExtensionCollection ElementExtensions { get { throw null; } }
        public string Language { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public static System.ServiceModel.Syndication.InlineCategoriesDocument Create(System.Collections.ObjectModel.Collection<System.ServiceModel.Syndication.SyndicationCategory> categories) { throw null; }
        public static System.ServiceModel.Syndication.InlineCategoriesDocument Create(System.Collections.ObjectModel.Collection<System.ServiceModel.Syndication.SyndicationCategory> categories, bool isFixed, string scheme) { throw null; }
        public static System.ServiceModel.Syndication.ReferencedCategoriesDocument Create(System.Uri linkToCategoriesDocument) { throw null; }
        public System.ServiceModel.Syndication.CategoriesDocumentFormatter GetFormatter() { throw null; }
        public static System.ServiceModel.Syndication.CategoriesDocument Load(System.Xml.XmlReader reader) { throw null; }
        public void Save(System.Xml.XmlWriter writer) { }
        protected internal virtual bool TryParseAttribute(string name, string ns, string value, string version) { throw null; }
        protected internal virtual bool TryParseElement(System.Xml.XmlReader reader, string version) { throw null; }
        protected internal virtual void WriteAttributeExtensions(System.Xml.XmlWriter writer, string version) { }
        protected internal virtual void WriteElementExtensions(System.Xml.XmlWriter writer, string version) { }
    }
    [System.Runtime.Serialization.DataContractAttribute]
    public abstract partial class CategoriesDocumentFormatter
    {
        protected CategoriesDocumentFormatter() { }
        protected CategoriesDocumentFormatter(System.ServiceModel.Syndication.CategoriesDocument documentToWrite) { }
        public System.ServiceModel.Syndication.CategoriesDocument Document { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        public abstract string Version { get; }
        public abstract bool CanRead(System.Xml.XmlReader reader);
        protected virtual System.ServiceModel.Syndication.InlineCategoriesDocument CreateInlineCategoriesDocument() { throw null; }
        protected virtual System.ServiceModel.Syndication.ReferencedCategoriesDocument CreateReferencedCategoriesDocument() { throw null; }
        public abstract void ReadFrom(System.Xml.XmlReader reader);
        protected virtual void SetDocument(System.ServiceModel.Syndication.CategoriesDocument document) { }
        public abstract void WriteTo(System.Xml.XmlWriter writer);
    }
    public partial class InlineCategoriesDocument : System.ServiceModel.Syndication.CategoriesDocument
    {
        public InlineCategoriesDocument() { }
        public InlineCategoriesDocument(System.Collections.Generic.IEnumerable<System.ServiceModel.Syndication.SyndicationCategory> categories) { }
        public InlineCategoriesDocument(System.Collections.Generic.IEnumerable<System.ServiceModel.Syndication.SyndicationCategory> categories, bool isFixed, string scheme) { }
        public System.Collections.ObjectModel.Collection<System.ServiceModel.Syndication.SyndicationCategory> Categories { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        public bool IsFixed { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public string Scheme { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        protected internal virtual System.ServiceModel.Syndication.SyndicationCategory CreateCategory() { throw null; }
    }
    public partial class ReferencedCategoriesDocument : System.ServiceModel.Syndication.CategoriesDocument
    {
        public ReferencedCategoriesDocument() { }
        public ReferencedCategoriesDocument(System.Uri link) { }
        public System.Uri Link { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    }
    public partial class ResourceCollectionInfo
    {
        public ResourceCollectionInfo() { }
        public ResourceCollectionInfo(System.ServiceModel.Syndication.TextSyndicationContent title, System.Uri link) { }
        public ResourceCollectionInfo(System.ServiceModel.Syndication.TextSyndicationContent title, System.Uri link, System.Collections.Generic.IEnumerable<System.ServiceModel.Syndication.CategoriesDocument> categories, bool allowsNewEntries) { }
        public ResourceCollectionInfo(System.ServiceModel.Syndication.TextSyndicationContent title, System.Uri link, System.Collections.Generic.IEnumerable<System.ServiceModel.Syndication.CategoriesDocument> categories, System.Collections.Generic.IEnumerable<string> accepts) { }
        public ResourceCollectionInfo(string title, System.Uri link) { }
        public System.Collections.ObjectModel.Collection<string> Accepts { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        public System.Collections.Generic.Dictionary<System.Xml.XmlQualifiedName, string> AttributeExtensions { get { throw null; } }
        public System.Uri BaseUri { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public System.Collections.ObjectModel.Collection<System.ServiceModel.Syndication.CategoriesDocument> Categories { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        public System.ServiceModel.Syndication.SyndicationElementExtensionCollection ElementExtensions { get { throw null; } }
        public System.Uri Link { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public System.ServiceModel.Syndication.TextSyndicationContent Title { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        protected internal virtual System.ServiceModel.Syndication.InlineCategoriesDocument CreateInlineCategoriesDocument() { throw null; }
        protected internal virtual System.ServiceModel.Syndication.ReferencedCategoriesDocument CreateReferencedCategoriesDocument() { throw null; }
        protected internal virtual bool TryParseAttribute(string name, string ns, string value, string version) { throw null; }
        protected internal virtual bool TryParseElement(System.Xml.XmlReader reader, string version) { throw null; }
        protected internal virtual void WriteAttributeExtensions(System.Xml.XmlWriter writer, string version) { }
        protected internal virtual void WriteElementExtensions(System.Xml.XmlWriter writer, string version) { }
    }
    [System.Xml.Serialization.XmlRootAttribute("rss", Namespace="")]
    public partial class Rss20FeedFormatter : System.ServiceModel.Syndication.SyndicationFeedFormatter, System.Xml.Serialization.IXmlSerializable
    {
        public Rss20FeedFormatter() { }
        public Rss20FeedFormatter(System.ServiceModel.Syndication.SyndicationFeed feedToWrite) { }
        public Rss20FeedFormatter(System.ServiceModel.Syndication.SyndicationFeed feedToWrite, bool serializeExtensionsAsAtom) { }
        public Rss20FeedFormatter(System.Type feedTypeToCreate) { }
        protected System.Type FeedType { get { throw null; } }
        public bool PreserveAttributeExtensions { get { throw null; } set { } }
        public bool PreserveElementExtensions { get { throw null; } set { } }
        public bool SerializeExtensionsAsAtom { get { throw null; } set { } }
        public override string Version { get { throw null; } }
        public override bool CanRead(System.Xml.XmlReader reader) { throw null; }
        protected override System.ServiceModel.Syndication.SyndicationFeed CreateFeedInstance() { throw null; }
        public override void ReadFrom(System.Xml.XmlReader reader) { }
        protected virtual System.ServiceModel.Syndication.SyndicationItem ReadItem(System.Xml.XmlReader reader, System.ServiceModel.Syndication.SyndicationFeed feed) { throw null; }
        protected virtual System.Collections.Generic.IEnumerable<System.ServiceModel.Syndication.SyndicationItem> ReadItems(System.Xml.XmlReader reader, System.ServiceModel.Syndication.SyndicationFeed feed, out bool areAllItemsRead) { areAllItemsRead = default(bool); throw null; }
        protected internal override void SetFeed(System.ServiceModel.Syndication.SyndicationFeed feed) { }
        System.Xml.Schema.XmlSchema System.Xml.Serialization.IXmlSerializable.GetSchema() { throw null; }
        void System.Xml.Serialization.IXmlSerializable.ReadXml(System.Xml.XmlReader reader) { }
        void System.Xml.Serialization.IXmlSerializable.WriteXml(System.Xml.XmlWriter writer) { }
        protected virtual void WriteItem(System.Xml.XmlWriter writer, System.ServiceModel.Syndication.SyndicationItem item, System.Uri feedBaseUri) { }
        protected virtual void WriteItems(System.Xml.XmlWriter writer, System.Collections.Generic.IEnumerable<System.ServiceModel.Syndication.SyndicationItem> items, System.Uri feedBaseUri) { }
        public override void WriteTo(System.Xml.XmlWriter writer) { }
    }
    [System.Xml.Serialization.XmlRootAttribute("rss", Namespace="")]
    public partial class Rss20FeedFormatter<TSyndicationFeed> : System.ServiceModel.Syndication.Rss20FeedFormatter where TSyndicationFeed : System.ServiceModel.Syndication.SyndicationFeed, new()
    {
        public Rss20FeedFormatter() { }
        public Rss20FeedFormatter(TSyndicationFeed feedToWrite) { }
        public Rss20FeedFormatter(TSyndicationFeed feedToWrite, bool serializeExtensionsAsAtom) { }
        protected override System.ServiceModel.Syndication.SyndicationFeed CreateFeedInstance() { throw null; }
    }
    [System.Xml.Serialization.XmlRootAttribute("item", Namespace="")]
    public partial class Rss20ItemFormatter : System.ServiceModel.Syndication.SyndicationItemFormatter, System.Xml.Serialization.IXmlSerializable
    {
        public Rss20ItemFormatter() { }
        public Rss20ItemFormatter(System.ServiceModel.Syndication.SyndicationItem itemToWrite) { }
        public Rss20ItemFormatter(System.ServiceModel.Syndication.SyndicationItem itemToWrite, bool serializeExtensionsAsAtom) { }
        public Rss20ItemFormatter(System.Type itemTypeToCreate) { }
        protected System.Type ItemType { get { throw null; } }
        public bool PreserveAttributeExtensions { get { throw null; } set { } }
        public bool PreserveElementExtensions { get { throw null; } set { } }
        public bool SerializeExtensionsAsAtom { get { throw null; } set { } }
        public override string Version { get { throw null; } }
        public override bool CanRead(System.Xml.XmlReader reader) { throw null; }
        protected override System.ServiceModel.Syndication.SyndicationItem CreateItemInstance() { throw null; }
        public override void ReadFrom(System.Xml.XmlReader reader) { }
        System.Xml.Schema.XmlSchema System.Xml.Serialization.IXmlSerializable.GetSchema() { throw null; }
        void System.Xml.Serialization.IXmlSerializable.ReadXml(System.Xml.XmlReader reader) { }
        void System.Xml.Serialization.IXmlSerializable.WriteXml(System.Xml.XmlWriter writer) { }
        public override void WriteTo(System.Xml.XmlWriter writer) { }
    }
    [System.Xml.Serialization.XmlRootAttribute("item", Namespace="")]
    public partial class Rss20ItemFormatter<TSyndicationItem> : System.ServiceModel.Syndication.Rss20ItemFormatter where TSyndicationItem : System.ServiceModel.Syndication.SyndicationItem, new()
    {
        public Rss20ItemFormatter() { }
        public Rss20ItemFormatter(TSyndicationItem itemToWrite) { }
        public Rss20ItemFormatter(TSyndicationItem itemToWrite, bool serializeExtensionsAsAtom) { }
        protected override System.ServiceModel.Syndication.SyndicationItem CreateItemInstance() { throw null; }
    }
    public partial class ServiceDocument
    {
        public ServiceDocument() { }
        public ServiceDocument(System.Collections.Generic.IEnumerable<System.ServiceModel.Syndication.Workspace> workspaces) { }
        public System.Collections.Generic.Dictionary<System.Xml.XmlQualifiedName, string> AttributeExtensions { get { throw null; } }
        public System.Uri BaseUri { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public System.ServiceModel.Syndication.SyndicationElementExtensionCollection ElementExtensions { get { throw null; } }
        public string Language { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public System.Collections.ObjectModel.Collection<System.ServiceModel.Syndication.Workspace> Workspaces { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        protected internal virtual System.ServiceModel.Syndication.Workspace CreateWorkspace() { throw null; }
        public System.ServiceModel.Syndication.ServiceDocumentFormatter GetFormatter() { throw null; }
        public static System.ServiceModel.Syndication.ServiceDocument Load(System.Xml.XmlReader reader) { throw null; }
        public static TServiceDocument Load<TServiceDocument>(System.Xml.XmlReader reader) where TServiceDocument : System.ServiceModel.Syndication.ServiceDocument, new() { throw null; }
        public void Save(System.Xml.XmlWriter writer) { }
        protected internal virtual bool TryParseAttribute(string name, string ns, string value, string version) { throw null; }
        protected internal virtual bool TryParseElement(System.Xml.XmlReader reader, string version) { throw null; }
        protected internal virtual void WriteAttributeExtensions(System.Xml.XmlWriter writer, string version) { }
        protected internal virtual void WriteElementExtensions(System.Xml.XmlWriter writer, string version) { }
    }
    [System.Runtime.Serialization.DataContractAttribute]
    public abstract partial class ServiceDocumentFormatter
    {
        protected ServiceDocumentFormatter() { }
        protected ServiceDocumentFormatter(System.ServiceModel.Syndication.ServiceDocument documentToWrite) { }
        public System.ServiceModel.Syndication.ServiceDocument Document { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        public abstract string Version { get; }
        public abstract bool CanRead(System.Xml.XmlReader reader);
        protected static System.ServiceModel.Syndication.SyndicationCategory CreateCategory(System.ServiceModel.Syndication.InlineCategoriesDocument inlineCategories) { throw null; }
        protected static System.ServiceModel.Syndication.ResourceCollectionInfo CreateCollection(System.ServiceModel.Syndication.Workspace workspace) { throw null; }
        protected virtual System.ServiceModel.Syndication.ServiceDocument CreateDocumentInstance() { throw null; }
        protected static System.ServiceModel.Syndication.InlineCategoriesDocument CreateInlineCategories(System.ServiceModel.Syndication.ResourceCollectionInfo collection) { throw null; }
        protected static System.ServiceModel.Syndication.ReferencedCategoriesDocument CreateReferencedCategories(System.ServiceModel.Syndication.ResourceCollectionInfo collection) { throw null; }
        protected static System.ServiceModel.Syndication.Workspace CreateWorkspace(System.ServiceModel.Syndication.ServiceDocument document) { throw null; }
        [System.MonoTODOAttribute("Use maxExtensionSize somewhere")]
        protected static void LoadElementExtensions(System.Xml.XmlReader reader, System.ServiceModel.Syndication.CategoriesDocument categories, int maxExtensionSize) { }
        [System.MonoTODOAttribute("Use maxExtensionSize somewhere")]
        protected static void LoadElementExtensions(System.Xml.XmlReader reader, System.ServiceModel.Syndication.ResourceCollectionInfo collection, int maxExtensionSize) { }
        [System.MonoTODOAttribute("Use maxExtensionSize somewhere")]
        protected static void LoadElementExtensions(System.Xml.XmlReader reader, System.ServiceModel.Syndication.ServiceDocument document, int maxExtensionSize) { }
        [System.MonoTODOAttribute("Use maxExtensionSize somewhere")]
        protected static void LoadElementExtensions(System.Xml.XmlReader reader, System.ServiceModel.Syndication.Workspace workspace, int maxExtensionSize) { }
        public abstract void ReadFrom(System.Xml.XmlReader reader);
        protected virtual void SetDocument(System.ServiceModel.Syndication.ServiceDocument document) { }
        protected static bool TryParseAttribute(string name, string ns, string value, System.ServiceModel.Syndication.CategoriesDocument categories, string version) { throw null; }
        protected static bool TryParseAttribute(string name, string ns, string value, System.ServiceModel.Syndication.ResourceCollectionInfo collection, string version) { throw null; }
        protected static bool TryParseAttribute(string name, string ns, string value, System.ServiceModel.Syndication.ServiceDocument document, string version) { throw null; }
        protected static bool TryParseAttribute(string name, string ns, string value, System.ServiceModel.Syndication.Workspace workspace, string version) { throw null; }
        protected static bool TryParseElement(System.Xml.XmlReader reader, System.ServiceModel.Syndication.CategoriesDocument categories, string version) { throw null; }
        protected static bool TryParseElement(System.Xml.XmlReader reader, System.ServiceModel.Syndication.ResourceCollectionInfo collection, string version) { throw null; }
        protected static bool TryParseElement(System.Xml.XmlReader reader, System.ServiceModel.Syndication.ServiceDocument document, string version) { throw null; }
        protected static bool TryParseElement(System.Xml.XmlReader reader, System.ServiceModel.Syndication.Workspace workspace, string version) { throw null; }
        protected static void WriteAttributeExtensions(System.Xml.XmlWriter writer, System.ServiceModel.Syndication.CategoriesDocument categories, string version) { }
        protected static void WriteAttributeExtensions(System.Xml.XmlWriter writer, System.ServiceModel.Syndication.ResourceCollectionInfo collection, string version) { }
        protected static void WriteAttributeExtensions(System.Xml.XmlWriter writer, System.ServiceModel.Syndication.ServiceDocument document, string version) { }
        protected static void WriteAttributeExtensions(System.Xml.XmlWriter writer, System.ServiceModel.Syndication.Workspace workspace, string version) { }
        protected static void WriteElementExtensions(System.Xml.XmlWriter writer, System.ServiceModel.Syndication.CategoriesDocument categories, string version) { }
        protected static void WriteElementExtensions(System.Xml.XmlWriter writer, System.ServiceModel.Syndication.ResourceCollectionInfo collection, string version) { }
        protected static void WriteElementExtensions(System.Xml.XmlWriter writer, System.ServiceModel.Syndication.ServiceDocument document, string version) { }
        protected static void WriteElementExtensions(System.Xml.XmlWriter writer, System.ServiceModel.Syndication.Workspace workspace, string version) { }
        public abstract void WriteTo(System.Xml.XmlWriter writer);
    }
    public partial class SyndicationCategory
    {
        public SyndicationCategory() { }
        protected SyndicationCategory(System.ServiceModel.Syndication.SyndicationCategory source) { }
        public SyndicationCategory(string name) { }
        public SyndicationCategory(string name, string scheme, string label) { }
        public System.Collections.Generic.Dictionary<System.Xml.XmlQualifiedName, string> AttributeExtensions { get { throw null; } }
        public System.ServiceModel.Syndication.SyndicationElementExtensionCollection ElementExtensions { get { throw null; } }
        public string Label { get { throw null; } set { } }
        public string Name { get { throw null; } set { } }
        public string Scheme { get { throw null; } set { } }
        public virtual System.ServiceModel.Syndication.SyndicationCategory Clone() { throw null; }
        protected internal virtual bool TryParseAttribute(string name, string ns, string value, string version) { throw null; }
        protected internal virtual bool TryParseElement(System.Xml.XmlReader reader, string version) { throw null; }
        protected internal virtual void WriteAttributeExtensions(System.Xml.XmlWriter writer, string version) { }
        protected internal virtual void WriteElementExtensions(System.Xml.XmlWriter writer, string version) { }
    }
    public abstract partial class SyndicationContent
    {
        protected SyndicationContent() { }
        protected SyndicationContent(System.ServiceModel.Syndication.SyndicationContent source) { }
        public System.Collections.Generic.Dictionary<System.Xml.XmlQualifiedName, string> AttributeExtensions { get { throw null; } }
        public abstract string Type { get; }
        public abstract System.ServiceModel.Syndication.SyndicationContent Clone();
        public static System.ServiceModel.Syndication.TextSyndicationContent CreateHtmlContent(string content) { throw null; }
        public static System.ServiceModel.Syndication.TextSyndicationContent CreatePlaintextContent(string content) { throw null; }
        public static System.ServiceModel.Syndication.UrlSyndicationContent CreateUrlContent(System.Uri url, string mediaType) { throw null; }
        public static System.ServiceModel.Syndication.TextSyndicationContent CreateXhtmlContent(string content) { throw null; }
        public static System.ServiceModel.Syndication.XmlSyndicationContent CreateXmlContent(object dataContractObject) { throw null; }
        public static System.ServiceModel.Syndication.XmlSyndicationContent CreateXmlContent(object dataContractObject, System.Runtime.Serialization.XmlObjectSerializer dataContractSerializer) { throw null; }
        public static System.ServiceModel.Syndication.XmlSyndicationContent CreateXmlContent(object xmlSerializerObject, System.Xml.Serialization.XmlSerializer serializer) { throw null; }
        public static System.ServiceModel.Syndication.XmlSyndicationContent CreateXmlContent(System.Xml.XmlReader reader) { throw null; }
        protected abstract void WriteContentsTo(System.Xml.XmlWriter writer);
        public void WriteTo(System.Xml.XmlWriter writer, string outerElementName, string outerElementNamespace) { }
    }
    public partial class SyndicationElementExtension
    {
        public SyndicationElementExtension(object dataContractExtension) { }
        public SyndicationElementExtension(object dataContractExtension, System.Runtime.Serialization.XmlObjectSerializer dataContractSerializer) { }
        public SyndicationElementExtension(object xmlSerializerExtension, System.Xml.Serialization.XmlSerializer serializer) { }
        public SyndicationElementExtension(string outerName, string outerNamespace, object dataContractExtension) { }
        public SyndicationElementExtension(string outerName, string outerNamespace, object dataContractExtension, System.Runtime.Serialization.XmlObjectSerializer dataContractSerializer) { }
        public SyndicationElementExtension(System.Xml.XmlReader xmlReader) { }
        public string OuterName { get { throw null; } }
        public string OuterNamespace { get { throw null; } }
        public TExtension GetObject<TExtension>() { throw null; }
        public TExtension GetObject<TExtension>(System.Runtime.Serialization.XmlObjectSerializer serializer) { throw null; }
        public TExtension GetObject<TExtension>(System.Xml.Serialization.XmlSerializer serializer) { throw null; }
        public System.Xml.XmlReader GetReader() { throw null; }
        public void WriteTo(System.Xml.XmlWriter writer) { }
    }
    public sealed partial class SyndicationElementExtensionCollection : System.Collections.ObjectModel.Collection<System.ServiceModel.Syndication.SyndicationElementExtension>
    {
        internal SyndicationElementExtensionCollection() { }
        public void Add(object extension) { }
        public void Add(object dataContractExtension, System.Runtime.Serialization.DataContractSerializer serializer) { }
        public void Add(object xmlSerializerExtension, System.Xml.Serialization.XmlSerializer serializer) { }
        public void Add(string outerName, string outerNamespace, object dataContractExtension) { }
        public void Add(string outerName, string outerNamespace, object dataContractExtension, System.Runtime.Serialization.XmlObjectSerializer dataContractSerializer) { }
        public void Add(System.Xml.XmlReader xmlReader) { }
        [System.MonoTODOAttribute("Find out what is expected here")]
        protected override void ClearItems() { }
        [System.MonoTODOAttribute]
        public System.Xml.XmlReader GetReaderAtElementExtensions() { throw null; }
        protected override void InsertItem(int index, System.ServiceModel.Syndication.SyndicationElementExtension item) { }
        public System.Collections.ObjectModel.Collection<TExtension> ReadElementExtensions<TExtension>(string extensionName, string extensionNamespace) { throw null; }
        public System.Collections.ObjectModel.Collection<TExtension> ReadElementExtensions<TExtension>(string extensionName, string extensionNamespace, System.Runtime.Serialization.XmlObjectSerializer serializer) { throw null; }
        public System.Collections.ObjectModel.Collection<TExtension> ReadElementExtensions<TExtension>(string extensionName, string extensionNamespace, System.Xml.Serialization.XmlSerializer serializer) { throw null; }
        [System.MonoTODOAttribute("Find out what is expected here")]
        protected override void RemoveItem(int index) { }
        protected override void SetItem(int index, System.ServiceModel.Syndication.SyndicationElementExtension item) { }
    }
    public partial class SyndicationFeed
    {
        public SyndicationFeed() { }
        public SyndicationFeed(System.Collections.Generic.IEnumerable<System.ServiceModel.Syndication.SyndicationItem> items) { }
        protected SyndicationFeed(System.ServiceModel.Syndication.SyndicationFeed source, bool cloneItems) { }
        public SyndicationFeed(string title, string description, System.Uri feedAlternateLink) { }
        public SyndicationFeed(string title, string description, System.Uri feedAlternateLink, System.Collections.Generic.IEnumerable<System.ServiceModel.Syndication.SyndicationItem> items) { }
        public SyndicationFeed(string title, string description, System.Uri feedAlternateLink, string id, System.DateTimeOffset lastUpdatedTime) { }
        public SyndicationFeed(string title, string description, System.Uri feedAlternateLink, string id, System.DateTimeOffset lastUpdatedTime, System.Collections.Generic.IEnumerable<System.ServiceModel.Syndication.SyndicationItem> items) { }
        public System.Collections.Generic.Dictionary<System.Xml.XmlQualifiedName, string> AttributeExtensions { get { throw null; } }
        public System.Collections.ObjectModel.Collection<System.ServiceModel.Syndication.SyndicationPerson> Authors { get { throw null; } }
        public System.Uri BaseUri { get { throw null; } set { } }
        public System.Collections.ObjectModel.Collection<System.ServiceModel.Syndication.SyndicationCategory> Categories { get { throw null; } }
        public System.Collections.ObjectModel.Collection<System.ServiceModel.Syndication.SyndicationPerson> Contributors { get { throw null; } }
        public System.ServiceModel.Syndication.TextSyndicationContent Copyright { get { throw null; } set { } }
        public System.ServiceModel.Syndication.TextSyndicationContent Description { get { throw null; } set { } }
        public System.ServiceModel.Syndication.SyndicationElementExtensionCollection ElementExtensions { get { throw null; } }
        public string Generator { get { throw null; } set { } }
        public string Id { get { throw null; } set { } }
        public System.Uri ImageUrl { get { throw null; } set { } }
        public System.Collections.Generic.IEnumerable<System.ServiceModel.Syndication.SyndicationItem> Items { get { throw null; } set { } }
        public string Language { get { throw null; } set { } }
        public System.DateTimeOffset LastUpdatedTime { get { throw null; } set { } }
        public System.Collections.ObjectModel.Collection<System.ServiceModel.Syndication.SyndicationLink> Links { get { throw null; } }
        public System.ServiceModel.Syndication.TextSyndicationContent Title { get { throw null; } set { } }
        public virtual System.ServiceModel.Syndication.SyndicationFeed Clone(bool cloneItems) { throw null; }
        protected internal virtual System.ServiceModel.Syndication.SyndicationCategory CreateCategory() { throw null; }
        protected internal virtual System.ServiceModel.Syndication.SyndicationItem CreateItem() { throw null; }
        protected internal virtual System.ServiceModel.Syndication.SyndicationLink CreateLink() { throw null; }
        protected internal virtual System.ServiceModel.Syndication.SyndicationPerson CreatePerson() { throw null; }
        public System.ServiceModel.Syndication.Atom10FeedFormatter GetAtom10Formatter() { throw null; }
        public System.ServiceModel.Syndication.Rss20FeedFormatter GetRss20Formatter() { throw null; }
        public System.ServiceModel.Syndication.Rss20FeedFormatter GetRss20Formatter(bool serializeExtensionsAsAtom) { throw null; }
        public static System.ServiceModel.Syndication.SyndicationFeed Load(System.Xml.XmlReader reader) { throw null; }
        public static TSyndicationFeed Load<TSyndicationFeed>(System.Xml.XmlReader reader) where TSyndicationFeed : System.ServiceModel.Syndication.SyndicationFeed, new() { throw null; }
        public void SaveAsAtom10(System.Xml.XmlWriter writer) { }
        public void SaveAsRss20(System.Xml.XmlWriter writer) { }
        protected internal virtual bool TryParseAttribute(string name, string ns, string value, string version) { throw null; }
        protected internal virtual bool TryParseElement(System.Xml.XmlReader reader, string version) { throw null; }
        protected internal virtual void WriteAttributeExtensions(System.Xml.XmlWriter writer, string version) { }
        protected internal virtual void WriteElementExtensions(System.Xml.XmlWriter writer, string version) { }
    }
    [System.Runtime.Serialization.DataContractAttribute]
    public abstract partial class SyndicationFeedFormatter
    {
        protected SyndicationFeedFormatter() { }
        protected SyndicationFeedFormatter(System.ServiceModel.Syndication.SyndicationFeed feedToWrite) { }
        public System.ServiceModel.Syndication.SyndicationFeed Feed { get { throw null; } }
        public abstract string Version { get; }
        public abstract bool CanRead(System.Xml.XmlReader reader);
        protected internal static System.ServiceModel.Syndication.SyndicationCategory CreateCategory(System.ServiceModel.Syndication.SyndicationFeed feed) { throw null; }
        protected internal static System.ServiceModel.Syndication.SyndicationCategory CreateCategory(System.ServiceModel.Syndication.SyndicationItem item) { throw null; }
        protected abstract System.ServiceModel.Syndication.SyndicationFeed CreateFeedInstance();
        protected internal static System.ServiceModel.Syndication.SyndicationItem CreateItem(System.ServiceModel.Syndication.SyndicationFeed feed) { throw null; }
        protected internal static System.ServiceModel.Syndication.SyndicationLink CreateLink(System.ServiceModel.Syndication.SyndicationFeed feed) { throw null; }
        protected internal static System.ServiceModel.Syndication.SyndicationLink CreateLink(System.ServiceModel.Syndication.SyndicationItem item) { throw null; }
        protected internal static System.ServiceModel.Syndication.SyndicationPerson CreatePerson(System.ServiceModel.Syndication.SyndicationFeed feed) { throw null; }
        protected internal static System.ServiceModel.Syndication.SyndicationPerson CreatePerson(System.ServiceModel.Syndication.SyndicationItem item) { throw null; }
        [System.MonoTODOAttribute("use maxExtensionsSize parameter")]
        protected internal static void LoadElementExtensions(System.Xml.XmlReader reader, System.ServiceModel.Syndication.SyndicationCategory category, int maxExtensionSize) { }
        [System.MonoTODOAttribute("use maxExtensionsSize parameter")]
        protected internal static void LoadElementExtensions(System.Xml.XmlReader reader, System.ServiceModel.Syndication.SyndicationFeed feed, int maxExtensionSize) { }
        [System.MonoTODOAttribute("use maxExtensionsSize parameter")]
        protected internal static void LoadElementExtensions(System.Xml.XmlReader reader, System.ServiceModel.Syndication.SyndicationItem item, int maxExtensionSize) { }
        [System.MonoTODOAttribute("use maxExtensionsSize parameter")]
        protected internal static void LoadElementExtensions(System.Xml.XmlReader reader, System.ServiceModel.Syndication.SyndicationLink link, int maxExtensionSize) { }
        [System.MonoTODOAttribute("use maxExtensionsSize parameter")]
        protected internal static void LoadElementExtensions(System.Xml.XmlReader reader, System.ServiceModel.Syndication.SyndicationPerson person, int maxExtensionSize) { }
        public abstract void ReadFrom(System.Xml.XmlReader reader);
        protected internal virtual void SetFeed(System.ServiceModel.Syndication.SyndicationFeed feed) { }
        public override string ToString() { throw null; }
        protected internal static bool TryParseAttribute(string name, string ns, string value, System.ServiceModel.Syndication.SyndicationCategory category, string version) { throw null; }
        protected internal static bool TryParseAttribute(string name, string ns, string value, System.ServiceModel.Syndication.SyndicationFeed feed, string version) { throw null; }
        protected internal static bool TryParseAttribute(string name, string ns, string value, System.ServiceModel.Syndication.SyndicationItem item, string version) { throw null; }
        protected internal static bool TryParseAttribute(string name, string ns, string value, System.ServiceModel.Syndication.SyndicationLink link, string version) { throw null; }
        protected internal static bool TryParseAttribute(string name, string ns, string value, System.ServiceModel.Syndication.SyndicationPerson person, string version) { throw null; }
        protected internal static bool TryParseContent(System.Xml.XmlReader reader, System.ServiceModel.Syndication.SyndicationItem item, string contentType, string version, out System.ServiceModel.Syndication.SyndicationContent content) { content = default(System.ServiceModel.Syndication.SyndicationContent); throw null; }
        protected internal static bool TryParseElement(System.Xml.XmlReader reader, System.ServiceModel.Syndication.SyndicationCategory category, string version) { throw null; }
        protected internal static bool TryParseElement(System.Xml.XmlReader reader, System.ServiceModel.Syndication.SyndicationFeed feed, string version) { throw null; }
        protected internal static bool TryParseElement(System.Xml.XmlReader reader, System.ServiceModel.Syndication.SyndicationItem item, string version) { throw null; }
        protected internal static bool TryParseElement(System.Xml.XmlReader reader, System.ServiceModel.Syndication.SyndicationLink link, string version) { throw null; }
        protected internal static bool TryParseElement(System.Xml.XmlReader reader, System.ServiceModel.Syndication.SyndicationPerson person, string version) { throw null; }
        protected internal static void WriteAttributeExtensions(System.Xml.XmlWriter writer, System.ServiceModel.Syndication.SyndicationCategory category, string version) { }
        protected internal static void WriteAttributeExtensions(System.Xml.XmlWriter writer, System.ServiceModel.Syndication.SyndicationFeed feed, string version) { }
        protected internal static void WriteAttributeExtensions(System.Xml.XmlWriter writer, System.ServiceModel.Syndication.SyndicationItem item, string version) { }
        protected internal static void WriteAttributeExtensions(System.Xml.XmlWriter writer, System.ServiceModel.Syndication.SyndicationLink link, string version) { }
        protected internal static void WriteAttributeExtensions(System.Xml.XmlWriter writer, System.ServiceModel.Syndication.SyndicationPerson person, string version) { }
        protected internal static void WriteElementExtensions(System.Xml.XmlWriter writer, System.ServiceModel.Syndication.SyndicationCategory category, string version) { }
        protected internal static void WriteElementExtensions(System.Xml.XmlWriter writer, System.ServiceModel.Syndication.SyndicationFeed feed, string version) { }
        protected internal static void WriteElementExtensions(System.Xml.XmlWriter writer, System.ServiceModel.Syndication.SyndicationItem item, string version) { }
        protected internal static void WriteElementExtensions(System.Xml.XmlWriter writer, System.ServiceModel.Syndication.SyndicationLink link, string version) { }
        protected internal static void WriteElementExtensions(System.Xml.XmlWriter writer, System.ServiceModel.Syndication.SyndicationPerson person, string version) { }
        public abstract void WriteTo(System.Xml.XmlWriter writer);
    }
    public partial class SyndicationItem
    {
        public SyndicationItem() { }
        protected SyndicationItem(System.ServiceModel.Syndication.SyndicationItem source) { }
        public SyndicationItem(string title, System.ServiceModel.Syndication.SyndicationContent content, System.Uri feedAlternateLink, string id, System.DateTimeOffset lastUpdatedTime) { }
        public SyndicationItem(string title, string content, System.Uri feedAlternateLink) { }
        public SyndicationItem(string title, string content, System.Uri feedAlternateLink, string id, System.DateTimeOffset lastUpdatedTime) { }
        public System.Collections.Generic.Dictionary<System.Xml.XmlQualifiedName, string> AttributeExtensions { get { throw null; } }
        public System.Collections.ObjectModel.Collection<System.ServiceModel.Syndication.SyndicationPerson> Authors { get { throw null; } }
        public System.Uri BaseUri { get { throw null; } set { } }
        public System.Collections.ObjectModel.Collection<System.ServiceModel.Syndication.SyndicationCategory> Categories { get { throw null; } }
        public System.ServiceModel.Syndication.SyndicationContent Content { get { throw null; } set { } }
        public System.Collections.ObjectModel.Collection<System.ServiceModel.Syndication.SyndicationPerson> Contributors { get { throw null; } }
        public System.ServiceModel.Syndication.TextSyndicationContent Copyright { get { throw null; } set { } }
        public System.ServiceModel.Syndication.SyndicationElementExtensionCollection ElementExtensions { get { throw null; } }
        public string Id { get { throw null; } set { } }
        public System.DateTimeOffset LastUpdatedTime { get { throw null; } set { } }
        public System.Collections.ObjectModel.Collection<System.ServiceModel.Syndication.SyndicationLink> Links { get { throw null; } }
        public System.DateTimeOffset PublishDate { get { throw null; } set { } }
        public System.ServiceModel.Syndication.SyndicationFeed SourceFeed { get { throw null; } set { } }
        public System.ServiceModel.Syndication.TextSyndicationContent Summary { get { throw null; } set { } }
        public System.ServiceModel.Syndication.TextSyndicationContent Title { get { throw null; } set { } }
        public void AddPermalink(System.Uri link) { }
        public virtual System.ServiceModel.Syndication.SyndicationItem Clone() { throw null; }
        protected internal virtual System.ServiceModel.Syndication.SyndicationCategory CreateCategory() { throw null; }
        protected internal virtual System.ServiceModel.Syndication.SyndicationLink CreateLink() { throw null; }
        protected internal virtual System.ServiceModel.Syndication.SyndicationPerson CreatePerson() { throw null; }
        public System.ServiceModel.Syndication.Atom10ItemFormatter GetAtom10Formatter() { throw null; }
        public System.ServiceModel.Syndication.Rss20ItemFormatter GetRss20Formatter() { throw null; }
        public System.ServiceModel.Syndication.Rss20ItemFormatter GetRss20Formatter(bool serializeExtensionsAsAtom) { throw null; }
        public static System.ServiceModel.Syndication.SyndicationItem Load(System.Xml.XmlReader reader) { throw null; }
        public static TSyndicationItem Load<TSyndicationItem>(System.Xml.XmlReader reader) where TSyndicationItem : System.ServiceModel.Syndication.SyndicationItem, new() { throw null; }
        public void SaveAsAtom10(System.Xml.XmlWriter writer) { }
        public void SaveAsRss20(System.Xml.XmlWriter writer) { }
        protected internal virtual bool TryParseAttribute(string name, string ns, string value, string version) { throw null; }
        protected internal virtual bool TryParseContent(System.Xml.XmlReader reader, string contentType, string version, out System.ServiceModel.Syndication.SyndicationContent content) { content = default(System.ServiceModel.Syndication.SyndicationContent); throw null; }
        protected internal virtual bool TryParseElement(System.Xml.XmlReader reader, string version) { throw null; }
        protected internal virtual void WriteAttributeExtensions(System.Xml.XmlWriter writer, string version) { }
        protected internal virtual void WriteElementExtensions(System.Xml.XmlWriter writer, string version) { }
    }
    [System.Runtime.Serialization.DataContractAttribute]
    public abstract partial class SyndicationItemFormatter
    {
        protected SyndicationItemFormatter() { }
        protected SyndicationItemFormatter(System.ServiceModel.Syndication.SyndicationItem itemToWrite) { }
        public System.ServiceModel.Syndication.SyndicationItem Item { get { throw null; } }
        public abstract string Version { get; }
        public abstract bool CanRead(System.Xml.XmlReader reader);
        protected internal static System.ServiceModel.Syndication.SyndicationCategory CreateCategory(System.ServiceModel.Syndication.SyndicationItem item) { throw null; }
        protected abstract System.ServiceModel.Syndication.SyndicationItem CreateItemInstance();
        protected internal static System.ServiceModel.Syndication.SyndicationLink CreateLink(System.ServiceModel.Syndication.SyndicationItem item) { throw null; }
        protected internal static System.ServiceModel.Syndication.SyndicationPerson CreatePerson(System.ServiceModel.Syndication.SyndicationItem item) { throw null; }
        [System.MonoTODOAttribute("use maxExtensionsSize parameter")]
        protected internal static void LoadElementExtensions(System.Xml.XmlReader reader, System.ServiceModel.Syndication.SyndicationCategory category, int maxExtensionSize) { }
        [System.MonoTODOAttribute("use maxExtensionsSize parameter")]
        protected internal static void LoadElementExtensions(System.Xml.XmlReader reader, System.ServiceModel.Syndication.SyndicationItem item, int maxExtensionSize) { }
        [System.MonoTODOAttribute("use maxExtensionsSize parameter")]
        protected internal static void LoadElementExtensions(System.Xml.XmlReader reader, System.ServiceModel.Syndication.SyndicationLink link, int maxExtensionSize) { }
        [System.MonoTODOAttribute("use maxExtensionsSize parameter")]
        protected internal static void LoadElementExtensions(System.Xml.XmlReader reader, System.ServiceModel.Syndication.SyndicationPerson person, int maxExtensionSize) { }
        public abstract void ReadFrom(System.Xml.XmlReader reader);
        protected internal virtual void SetItem(System.ServiceModel.Syndication.SyndicationItem item) { }
        public override string ToString() { throw null; }
        protected internal static bool TryParseAttribute(string name, string ns, string value, System.ServiceModel.Syndication.SyndicationCategory category, string version) { throw null; }
        protected internal static bool TryParseAttribute(string name, string ns, string value, System.ServiceModel.Syndication.SyndicationItem item, string version) { throw null; }
        protected internal static bool TryParseAttribute(string name, string ns, string value, System.ServiceModel.Syndication.SyndicationLink link, string version) { throw null; }
        protected internal static bool TryParseAttribute(string name, string ns, string value, System.ServiceModel.Syndication.SyndicationPerson person, string version) { throw null; }
        protected internal static bool TryParseContent(System.Xml.XmlReader reader, System.ServiceModel.Syndication.SyndicationItem item, string contentType, string version, out System.ServiceModel.Syndication.SyndicationContent content) { content = default(System.ServiceModel.Syndication.SyndicationContent); throw null; }
        protected internal static bool TryParseElement(System.Xml.XmlReader reader, System.ServiceModel.Syndication.SyndicationCategory category, string version) { throw null; }
        protected internal static bool TryParseElement(System.Xml.XmlReader reader, System.ServiceModel.Syndication.SyndicationItem item, string version) { throw null; }
        protected internal static bool TryParseElement(System.Xml.XmlReader reader, System.ServiceModel.Syndication.SyndicationLink link, string version) { throw null; }
        protected internal static bool TryParseElement(System.Xml.XmlReader reader, System.ServiceModel.Syndication.SyndicationPerson person, string version) { throw null; }
        protected internal static void WriteAttributeExtensions(System.Xml.XmlWriter writer, System.ServiceModel.Syndication.SyndicationCategory category, string version) { }
        protected internal static void WriteAttributeExtensions(System.Xml.XmlWriter writer, System.ServiceModel.Syndication.SyndicationItem item, string version) { }
        protected internal static void WriteAttributeExtensions(System.Xml.XmlWriter writer, System.ServiceModel.Syndication.SyndicationLink link, string version) { }
        protected internal static void WriteAttributeExtensions(System.Xml.XmlWriter writer, System.ServiceModel.Syndication.SyndicationPerson person, string version) { }
        protected internal void WriteElementExtensions(System.Xml.XmlWriter writer, System.ServiceModel.Syndication.SyndicationCategory category, string version) { }
        protected internal static void WriteElementExtensions(System.Xml.XmlWriter writer, System.ServiceModel.Syndication.SyndicationItem item, string version) { }
        protected internal void WriteElementExtensions(System.Xml.XmlWriter writer, System.ServiceModel.Syndication.SyndicationLink link, string version) { }
        protected internal void WriteElementExtensions(System.Xml.XmlWriter writer, System.ServiceModel.Syndication.SyndicationPerson person, string version) { }
        public abstract void WriteTo(System.Xml.XmlWriter writer);
    }
    public partial class SyndicationLink
    {
        public SyndicationLink() { }
        protected SyndicationLink(System.ServiceModel.Syndication.SyndicationLink source) { }
        public SyndicationLink(System.Uri uri) { }
        public SyndicationLink(System.Uri uri, string relationshipType, string title, string mediaType, long length) { }
        public System.Collections.Generic.Dictionary<System.Xml.XmlQualifiedName, string> AttributeExtensions { get { throw null; } }
        public System.Uri BaseUri { get { throw null; } set { } }
        public System.ServiceModel.Syndication.SyndicationElementExtensionCollection ElementExtensions { get { throw null; } }
        public long Length { get { throw null; } set { } }
        public string MediaType { get { throw null; } set { } }
        public string RelationshipType { get { throw null; } set { } }
        public string Title { get { throw null; } set { } }
        public System.Uri Uri { get { throw null; } set { } }
        public virtual System.ServiceModel.Syndication.SyndicationLink Clone() { throw null; }
        public static System.ServiceModel.Syndication.SyndicationLink CreateAlternateLink(System.Uri uri) { throw null; }
        public static System.ServiceModel.Syndication.SyndicationLink CreateAlternateLink(System.Uri uri, string mediaType) { throw null; }
        public static System.ServiceModel.Syndication.SyndicationLink CreateMediaEnclosureLink(System.Uri uri, string mediaType, long length) { throw null; }
        public static System.ServiceModel.Syndication.SyndicationLink CreateSelfLink(System.Uri uri) { throw null; }
        public static System.ServiceModel.Syndication.SyndicationLink CreateSelfLink(System.Uri uri, string mediaType) { throw null; }
        public System.Uri GetAbsoluteUri() { throw null; }
        protected internal virtual bool TryParseAttribute(string name, string ns, string value, string version) { throw null; }
        protected internal virtual bool TryParseElement(System.Xml.XmlReader reader, string version) { throw null; }
        protected internal virtual void WriteAttributeExtensions(System.Xml.XmlWriter writer, string version) { }
        protected internal virtual void WriteElementExtensions(System.Xml.XmlWriter writer, string version) { }
    }
    public partial class SyndicationPerson
    {
        public SyndicationPerson() { }
        protected SyndicationPerson(System.ServiceModel.Syndication.SyndicationPerson source) { }
        public SyndicationPerson(string email) { }
        public SyndicationPerson(string email, string name, string uri) { }
        public System.Collections.Generic.Dictionary<System.Xml.XmlQualifiedName, string> AttributeExtensions { get { throw null; } }
        public System.ServiceModel.Syndication.SyndicationElementExtensionCollection ElementExtensions { get { throw null; } }
        public string Email { get { throw null; } set { } }
        public string Name { get { throw null; } set { } }
        public string Uri { get { throw null; } set { } }
        public virtual System.ServiceModel.Syndication.SyndicationPerson Clone() { throw null; }
        protected internal virtual bool TryParseAttribute(string name, string ns, string value, string version) { throw null; }
        protected internal virtual bool TryParseElement(System.Xml.XmlReader reader, string version) { throw null; }
        protected internal virtual void WriteAttributeExtensions(System.Xml.XmlWriter writer, string version) { }
        protected internal virtual void WriteElementExtensions(System.Xml.XmlWriter writer, string version) { }
    }
    public static partial class SyndicationVersions
    {
        public const string Atom10 = "Atom10";
        public const string Rss20 = "Rss20";
    }
    public partial class TextSyndicationContent : System.ServiceModel.Syndication.SyndicationContent
    {
        protected TextSyndicationContent(System.ServiceModel.Syndication.TextSyndicationContent source) { }
        public TextSyndicationContent(string text) { }
        public TextSyndicationContent(string text, System.ServiceModel.Syndication.TextSyndicationContentKind textKind) { }
        public string Text { get { throw null; } }
        public override string Type { get { throw null; } }
        public override System.ServiceModel.Syndication.SyndicationContent Clone() { throw null; }
        protected override void WriteContentsTo(System.Xml.XmlWriter writer) { }
    }
    public enum TextSyndicationContentKind
    {
        Html = 1,
        Plaintext = 0,
        XHtml = 2,
    }
    public partial class UrlSyndicationContent : System.ServiceModel.Syndication.SyndicationContent
    {
        protected UrlSyndicationContent(System.ServiceModel.Syndication.UrlSyndicationContent source) { }
        public UrlSyndicationContent(System.Uri url, string mediaType) { }
        public override string Type { get { throw null; } }
        public System.Uri Url { get { throw null; } }
        public override System.ServiceModel.Syndication.SyndicationContent Clone() { throw null; }
        protected override void WriteContentsTo(System.Xml.XmlWriter writer) { }
    }
    public partial class Workspace
    {
        public Workspace() { }
        public Workspace(System.ServiceModel.Syndication.TextSyndicationContent title, System.Collections.Generic.IEnumerable<System.ServiceModel.Syndication.ResourceCollectionInfo> collections) { }
        public Workspace(string title, System.Collections.Generic.IEnumerable<System.ServiceModel.Syndication.ResourceCollectionInfo> collections) { }
        public System.Collections.Generic.Dictionary<System.Xml.XmlQualifiedName, string> AttributeExtensions { get { throw null; } }
        public System.Uri BaseUri { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public System.Collections.ObjectModel.Collection<System.ServiceModel.Syndication.ResourceCollectionInfo> Collections { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        public System.ServiceModel.Syndication.SyndicationElementExtensionCollection ElementExtensions { get { throw null; } }
        public System.ServiceModel.Syndication.TextSyndicationContent Title { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        protected internal virtual System.ServiceModel.Syndication.ResourceCollectionInfo CreateResourceCollection() { throw null; }
        protected internal virtual bool TryParseAttribute(string name, string ns, string value, string version) { throw null; }
        protected internal virtual bool TryParseElement(System.Xml.XmlReader reader, string version) { throw null; }
        protected internal virtual void WriteAttributeExtensions(System.Xml.XmlWriter writer, string version) { }
        protected internal virtual void WriteElementExtensions(System.Xml.XmlWriter writer, string version) { }
    }
    public partial class XmlSyndicationContent : System.ServiceModel.Syndication.SyndicationContent
    {
        protected XmlSyndicationContent(System.ServiceModel.Syndication.XmlSyndicationContent source) { }
        public XmlSyndicationContent(string type, object dataContractExtension, System.Runtime.Serialization.XmlObjectSerializer dataContractSerializer) { }
        public XmlSyndicationContent(string type, object xmlSerializerExtension, System.Xml.Serialization.XmlSerializer serializer) { }
        public XmlSyndicationContent(string type, System.ServiceModel.Syndication.SyndicationElementExtension extension) { }
        public XmlSyndicationContent(System.Xml.XmlReader reader) { }
        public System.ServiceModel.Syndication.SyndicationElementExtension Extension { get { throw null; } }
        public override string Type { get { throw null; } }
        public override System.ServiceModel.Syndication.SyndicationContent Clone() { throw null; }
        public System.Xml.XmlDictionaryReader GetReaderAtContent() { throw null; }
        public TContent ReadContent<TContent>() { throw null; }
        public TContent ReadContent<TContent>(System.Runtime.Serialization.XmlObjectSerializer serializer) { throw null; }
        public TContent ReadContent<TContent>(System.Xml.Serialization.XmlSerializer serializer) { throw null; }
        protected override void WriteContentsTo(System.Xml.XmlWriter writer) { }
    }
}
namespace System.ServiceModel.Web
{
    public partial class IncomingWebRequestContext
    {
        internal IncomingWebRequestContext() { }
        public string Accept { get { throw null; } }
        public long ContentLength { get { throw null; } }
        public string ContentType { get { throw null; } }
        public System.Net.WebHeaderCollection Headers { get { throw null; } }
        public string Method { get { throw null; } }
        public System.UriTemplateMatch UriTemplateMatch { get { throw null; } set { } }
        public string UserAgent { get { throw null; } }
    }
    public partial class IncomingWebResponseContext
    {
        internal IncomingWebResponseContext() { }
        public long ContentLength { get { throw null; } }
        public string ContentType { get { throw null; } }
        public string ETag { get { throw null; } }
        public System.Net.WebHeaderCollection Headers { get { throw null; } }
        public string Location { get { throw null; } }
        public System.Net.HttpStatusCode StatusCode { get { throw null; } }
        public string StatusDescription { get { throw null; } }
    }
    public partial class OutgoingWebRequestContext
    {
        internal OutgoingWebRequestContext() { }
        public string Accept { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public long ContentLength { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public string ContentType { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public System.Net.WebHeaderCollection Headers { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        public string IfMatch { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public string IfModifiedSince { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public string IfNoneMatch { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public string IfUnmodifiedSince { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public string Method { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public bool SuppressEntityBody { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public string UserAgent { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    }
    public partial class OutgoingWebResponseContext
    {
        internal OutgoingWebResponseContext() { }
        public long ContentLength { get { throw null; } set { } }
        public string ContentType { get { throw null; } set { } }
        public string ETag { get { throw null; } set { } }
        public System.Net.WebHeaderCollection Headers { get { throw null; } }
        public System.DateTime LastModified { get { throw null; } set { } }
        public string Location { get { throw null; } set { } }
        public System.Net.HttpStatusCode StatusCode { get { throw null; } set { } }
        public string StatusDescription { get { throw null; } set { } }
        public bool SuppressEntityBody { get { throw null; } set { } }
        public void SetStatusAsCreated(System.Uri locationUri) { }
        public void SetStatusAsNotFound() { }
        public void SetStatusAsNotFound(string description) { }
    }
    public partial class WebChannelFactory<TChannel> : System.ServiceModel.ChannelFactory<TChannel>
    {
        public WebChannelFactory() { }
        public WebChannelFactory(System.ServiceModel.Channels.Binding binding) { }
        public WebChannelFactory(System.ServiceModel.Channels.Binding binding, System.Uri remoteAddress) { }
        public WebChannelFactory(System.ServiceModel.Description.ServiceEndpoint endpoint) { }
        public WebChannelFactory(string configurationName) { }
        public WebChannelFactory(string endpointConfigurationName, System.Uri remoteAddress) { }
        public WebChannelFactory(System.Type serviceType) { }
        public WebChannelFactory(System.Uri remoteAddress) { }
        protected override void OnOpening() { }
    }
    [System.AttributeUsageAttribute((System.AttributeTargets)(64))]
    public sealed partial class WebGetAttribute : System.Attribute, System.ServiceModel.Description.IOperationBehavior
    {
        public WebGetAttribute() { }
        public System.ServiceModel.Web.WebMessageBodyStyle BodyStyle { get { throw null; } set { } }
        public bool IsBodyStyleSetExplicitly { get { throw null; } }
        public bool IsRequestFormatSetExplicitly { get { throw null; } }
        public bool IsResponseFormatSetExplicitly { get { throw null; } }
        public System.ServiceModel.Web.WebMessageFormat RequestFormat { get { throw null; } set { } }
        public System.ServiceModel.Web.WebMessageFormat ResponseFormat { get { throw null; } set { } }
        public string UriTemplate { get { throw null; } set { } }
        void System.ServiceModel.Description.IOperationBehavior.AddBindingParameters(System.ServiceModel.Description.OperationDescription operation, System.ServiceModel.Channels.BindingParameterCollection parameters) { }
        void System.ServiceModel.Description.IOperationBehavior.ApplyClientBehavior(System.ServiceModel.Description.OperationDescription operation, System.ServiceModel.Dispatcher.ClientOperation client) { }
        void System.ServiceModel.Description.IOperationBehavior.ApplyDispatchBehavior(System.ServiceModel.Description.OperationDescription operation, System.ServiceModel.Dispatcher.DispatchOperation service) { }
        void System.ServiceModel.Description.IOperationBehavior.Validate(System.ServiceModel.Description.OperationDescription operation) { }
    }
    [System.AttributeUsageAttribute((System.AttributeTargets)(64))]
    public sealed partial class WebInvokeAttribute : System.Attribute, System.ServiceModel.Description.IOperationBehavior
    {
        public WebInvokeAttribute() { }
        public System.ServiceModel.Web.WebMessageBodyStyle BodyStyle { get { throw null; } set { } }
        public bool IsBodyStyleSetExplicitly { get { throw null; } }
        public bool IsRequestFormatSetExplicitly { get { throw null; } }
        public bool IsResponseFormatSetExplicitly { get { throw null; } }
        public string Method { get { throw null; } set { } }
        public System.ServiceModel.Web.WebMessageFormat RequestFormat { get { throw null; } set { } }
        public System.ServiceModel.Web.WebMessageFormat ResponseFormat { get { throw null; } set { } }
        public string UriTemplate { get { throw null; } set { } }
        void System.ServiceModel.Description.IOperationBehavior.AddBindingParameters(System.ServiceModel.Description.OperationDescription operation, System.ServiceModel.Channels.BindingParameterCollection parameters) { }
        void System.ServiceModel.Description.IOperationBehavior.ApplyClientBehavior(System.ServiceModel.Description.OperationDescription operation, System.ServiceModel.Dispatcher.ClientOperation client) { }
        void System.ServiceModel.Description.IOperationBehavior.ApplyDispatchBehavior(System.ServiceModel.Description.OperationDescription operation, System.ServiceModel.Dispatcher.DispatchOperation service) { }
        void System.ServiceModel.Description.IOperationBehavior.Validate(System.ServiceModel.Description.OperationDescription operation) { }
    }
    public enum WebMessageBodyStyle
    {
        Bare = 0,
        Wrapped = 1,
        WrappedRequest = 2,
        WrappedResponse = 3,
    }
    public enum WebMessageFormat
    {
        Json = 1,
        Xml = 0,
    }
    public partial class WebOperationContext : System.ServiceModel.IExtension<System.ServiceModel.OperationContext>
    {
        public WebOperationContext(System.ServiceModel.OperationContext operation) { }
        public static System.ServiceModel.Web.WebOperationContext Current { get { throw null; } }
        public System.ServiceModel.Web.IncomingWebRequestContext IncomingRequest { get { throw null; } }
        public System.ServiceModel.Web.IncomingWebResponseContext IncomingResponse { get { throw null; } }
        public System.ServiceModel.Web.OutgoingWebRequestContext OutgoingRequest { get { throw null; } }
        public System.ServiceModel.Web.OutgoingWebResponseContext OutgoingResponse { get { throw null; } }
        public void Attach(System.ServiceModel.OperationContext context) { }
        public void Detach(System.ServiceModel.OperationContext context) { }
    }
    public partial class WebServiceHost : System.ServiceModel.ServiceHost
    {
        public WebServiceHost() { }
        public WebServiceHost(object singletonInstance, params System.Uri[] baseAddresses) { }
        public WebServiceHost(System.Type serviceType, params System.Uri[] baseAddresses) { }
        protected override void OnOpening() { }
    }
}
