// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

[assembly:System.Reflection.AssemblyVersionAttribute("2.0.5.0")]
[assembly:System.CLSCompliantAttribute(true)]
[assembly:System.Diagnostics.DebuggableAttribute(System.Diagnostics.DebuggableAttribute.DebuggingModes.IgnoreSymbolStoreSequencePoints)]
[assembly:System.Reflection.AssemblyCompanyAttribute("MONO development team")]
[assembly:System.Reflection.AssemblyCopyrightAttribute("(c) 2003 Various Authors")]
[assembly:System.Reflection.AssemblyDefaultAliasAttribute("System.ServiceModel.Web.dll")]
[assembly:System.Reflection.AssemblyDescriptionAttribute("System.ServiceModel.Web.dll")]
[assembly:System.Reflection.AssemblyFileVersionAttribute("4.0.50524.0")]
[assembly:System.Reflection.AssemblyInformationalVersionAttribute("4.0.50524.0")]
[assembly:System.Reflection.AssemblyProductAttribute("MONO CLI")]
[assembly:System.Reflection.AssemblyTitleAttribute("System.ServiceModel.Web.dll")]
[assembly:System.Resources.NeutralResourcesLanguageAttribute("en-US")]
[assembly:System.Resources.SatelliteContractVersionAttribute("2.0.5.0")]
[assembly:System.Runtime.CompilerServices.CompilationRelaxationsAttribute(System.Runtime.CompilerServices.CompilationRelaxations.NoStringInterning)]
[assembly:System.Runtime.CompilerServices.InternalsVisibleToAttribute("System.Json, PublicKey=0024000004800000940000000602000000240000525341310004000001000100b5fc90e7027f67871e773a8fde8938c81dd402ba65b9201d60593e96c492651e889cc13f1415ebb53fac1131ae0bd333c5ee6021672d9718ea31a8aebd0da0072f25d87dba6fc90ffd598ed4da35e44c398c454307e8e33b8426143daec9f596836f97c8f74750e5975c64e2189f45def46b2a2b1247adc3652bf5c308055da9")]
[assembly:System.Runtime.CompilerServices.InternalsVisibleToAttribute("System.ServiceModel.Web.Extensions, PublicKey=0024000004800000940000000602000000240000525341310004000001000100b5fc90e7027f67871e773a8fde8938c81dd402ba65b9201d60593e96c492651e889cc13f1415ebb53fac1131ae0bd333c5ee6021672d9718ea31a8aebd0da0072f25d87dba6fc90ffd598ed4da35e44c398c454307e8e33b8426143daec9f596836f97c8f74750e5975c64e2189f45def46b2a2b1247adc3652bf5c308055da9")]
[assembly:System.Runtime.CompilerServices.InternalsVisibleToAttribute("System.Windows.Browser, PublicKey=00240000048000009400000006020000002400005253413100040000010001008D56C76F9E8649383049F383C44BE0EC204181822A6C31CF5EB7EF486944D032188EA1D3920763712CCB12D75FB77E9811149E6148E5D32FBAAB37611C1878DDC19E20EF135D0CB2CFF2BFEC3D115810C3D9069638FE4BE215DBF795861920E5AB6F7DB2E2CEEF136AC23D5DD2BF031700AEC232F6C6B1C785B4305C123B37AB")]
[assembly:System.Runtime.CompilerServices.RuntimeCompatibilityAttribute(WrapNonExceptionThrows=true)]
[assembly:System.Runtime.InteropServices.ComVisibleAttribute(false)]
[assembly:System.Runtime.CompilerServices.TypeForwardedToAttribute(typeof(System.Runtime.Serialization.Json.DataContractJsonSerializer))]
namespace System
{
    [System.AttributeUsageAttribute(System.AttributeTargets.All, AllowMultiple=true)]
    internal partial class MonoDocumentationNoteAttribute : System.MonoTODOAttribute
    {
        public MonoDocumentationNoteAttribute(string comment) { }
    }
    [System.AttributeUsageAttribute(System.AttributeTargets.All, AllowMultiple=true)]
    internal partial class MonoExtensionAttribute : System.MonoTODOAttribute
    {
        public MonoExtensionAttribute(string comment) { }
    }
    [System.AttributeUsageAttribute(System.AttributeTargets.All, AllowMultiple=true)]
    internal partial class MonoInternalNoteAttribute : System.MonoTODOAttribute
    {
        public MonoInternalNoteAttribute(string comment) { }
    }
    [System.AttributeUsageAttribute(System.AttributeTargets.All, AllowMultiple=true)]
    internal partial class MonoLimitationAttribute : System.MonoTODOAttribute
    {
        public MonoLimitationAttribute(string comment) { }
    }
    [System.AttributeUsageAttribute(System.AttributeTargets.All, AllowMultiple=true)]
    internal partial class MonoNotSupportedAttribute : System.MonoTODOAttribute
    {
        public MonoNotSupportedAttribute(string comment) { }
    }
    [System.AttributeUsageAttribute(System.AttributeTargets.All, AllowMultiple=true)]
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
        public System.Collections.Generic.IDictionary<string, string> Defaults { get { throw null; } }
        public bool IgnoreTrailingSlash { get { throw null; } }
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
        public UriTemplateMatchException(string message) { }
        public UriTemplateMatchException(string message, System.Exception innerException) { }
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
namespace System.ServiceModel
{
    public partial class WebHttpBinding : System.ServiceModel.Channels.Binding, System.ServiceModel.Channels.IBindingRuntimePreferences
    {
        public WebHttpBinding() { }
        public WebHttpBinding(System.ServiceModel.WebHttpSecurityMode securityMode) { }
        public WebHttpBinding(string configurationName) { }
        public System.ServiceModel.EnvelopeVersion EnvelopeVersion { get { throw null; } }
        [System.ComponentModel.DefaultValueAttribute(524288)]
        public int MaxBufferSize { get { throw null; } set { } }
        [System.ComponentModel.DefaultValueAttribute(65536)]
        public long MaxReceivedMessageSize { get { throw null; } set { } }
        public System.Xml.XmlDictionaryReaderQuotas ReaderQuotas { get { throw null; } set { } }
        public override string Scheme { get { throw null; } }
        public System.ServiceModel.WebHttpSecurity Security { get { throw null; } set { } }
        bool System.ServiceModel.Channels.IBindingRuntimePreferences.ReceiveSynchronously { get { throw null; } }
        public System.Text.Encoding WriteEncoding { get { throw null; } set { } }
        public override System.ServiceModel.Channels.BindingElementCollection CreateBindingElements() { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        public bool ShouldSerializeReaderQuotas() { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        public bool ShouldSerializeSecurity() { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        public bool ShouldSerializeWriteEncoding() { throw null; }
    }
    public sealed partial class WebHttpSecurity
    {
        public WebHttpSecurity() { }
        public System.ServiceModel.WebHttpSecurityMode Mode { get { throw null; } set { } }
        public System.ServiceModel.HttpTransportSecurity Transport { get { throw null; } set { } }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        public bool ShouldSerializeMode() { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        public bool ShouldSerializeTransport() { throw null; }
    }
    public enum WebHttpSecurityMode
    {
        None = 0,
        Transport = 1,
        TransportCredentialOnly = 2,
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
    public sealed partial class WebMessageEncodingBindingElement : System.ServiceModel.Channels.MessageEncodingBindingElement
    {
        public WebMessageEncodingBindingElement() { }
        public WebMessageEncodingBindingElement(System.Text.Encoding writeEncoding) { }
        public System.ServiceModel.Channels.WebContentTypeMapper ContentTypeMapper { get { throw null; } set { } }
        [System.MonoTODOAttribute]
        public int MaxReadPoolSize { get { throw null; } set { } }
        [System.MonoTODOAttribute]
        public int MaxWritePoolSize { get { throw null; } set { } }
        public override System.ServiceModel.Channels.MessageVersion MessageVersion { get { throw null; } set { } }
        public System.Xml.XmlDictionaryReaderQuotas ReaderQuotas { get { throw null; } }
        public System.Text.Encoding WriteEncoding { get { throw null; } set { } }
        public override System.ServiceModel.Channels.IChannelFactory<TChannel> BuildChannelFactory<TChannel>(System.ServiceModel.Channels.BindingContext context) { throw null; }
        public override System.ServiceModel.Channels.BindingElement Clone() { throw null; }
        public override System.ServiceModel.Channels.MessageEncoderFactory CreateMessageEncoderFactory() { throw null; }
        public override T GetProperty<T>(System.ServiceModel.Channels.BindingContext context) { throw null; }
    }
}
namespace System.ServiceModel.Description
{
    public partial class WebHttpBehavior : System.ServiceModel.Description.IEndpointBehavior
    {
        public WebHttpBehavior() { }
        public virtual bool AutomaticFormatSelectionEnabled { get { throw null; } set { } }
        public virtual System.ServiceModel.Web.WebMessageBodyStyle DefaultBodyStyle { get { throw null; } set { } }
        public virtual System.ServiceModel.Web.WebMessageFormat DefaultOutgoingRequestFormat { get { throw null; } set { } }
        public virtual System.ServiceModel.Web.WebMessageFormat DefaultOutgoingResponseFormat { get { throw null; } set { } }
        public virtual bool FaultExceptionEnabled { get { throw null; } set { } }
        public virtual bool HelpEnabled { get { throw null; } set { } }
        public virtual void AddBindingParameters(System.ServiceModel.Description.ServiceEndpoint endpoint, System.ServiceModel.Channels.BindingParameterCollection bindingParameters) { }
        [System.MonoTODOAttribute]
        protected virtual void AddClientErrorInspector(System.ServiceModel.Description.ServiceEndpoint endpoint, System.ServiceModel.Dispatcher.ClientRuntime clientRuntime) { }
        public virtual void ApplyClientBehavior(System.ServiceModel.Description.ServiceEndpoint endpoint, System.ServiceModel.Dispatcher.ClientRuntime clientRuntime) { }
        public virtual void ApplyDispatchBehavior(System.ServiceModel.Description.ServiceEndpoint endpoint, System.ServiceModel.Dispatcher.EndpointDispatcher endpointDispatcher) { }
        protected virtual System.ServiceModel.Dispatcher.QueryStringConverter GetQueryStringConverter(System.ServiceModel.Description.OperationDescription operationDescription) { throw null; }
        protected virtual System.ServiceModel.Dispatcher.IClientMessageFormatter GetReplyClientFormatter(System.ServiceModel.Description.OperationDescription operationDescription, System.ServiceModel.Description.ServiceEndpoint endpoint) { throw null; }
        protected virtual System.ServiceModel.Dispatcher.IClientMessageFormatter GetRequestClientFormatter(System.ServiceModel.Description.OperationDescription operationDescription, System.ServiceModel.Description.ServiceEndpoint endpoint) { throw null; }
        [System.MonoTODOAttribute("check UriTemplate validity")]
        public virtual void Validate(System.ServiceModel.Description.ServiceEndpoint endpoint) { }
        protected virtual void ValidateBinding(System.ServiceModel.Description.ServiceEndpoint endpoint) { }
        protected void ValidateOperation(System.ServiceModel.Description.OperationDescription operation) { }
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
}
namespace System.ServiceModel.Web
{
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
        public string Accept { get { throw null; } set { } }
        public long ContentLength { get { throw null; } set { } }
        public string ContentType { get { throw null; } set { } }
        public System.Net.WebHeaderCollection Headers { get { throw null; } }
        public string IfMatch { get { throw null; } set { } }
        public string IfModifiedSince { get { throw null; } set { } }
        public string IfNoneMatch { get { throw null; } set { } }
        public string IfUnmodifiedSince { get { throw null; } set { } }
        public string Method { get { throw null; } set { } }
        public bool SuppressEntityBody { get { throw null; } set { } }
        public string UserAgent { get { throw null; } set { } }
    }
    public partial class WebChannelFactory<TChannel> : System.ServiceModel.ChannelFactory<TChannel>
    {
        public WebChannelFactory(System.ServiceModel.Channels.Binding binding, System.Uri remoteAddress) { }
        public WebChannelFactory(string endpointConfigurationName) { }
        public WebChannelFactory(string endpointConfigurationName, System.Uri remoteAddress) { }
        public WebChannelFactory(System.Type channelType) { }
        public WebChannelFactory(System.Uri remoteAddress) { }
        protected override void OnOpening() { }
    }
    [System.AttributeUsageAttribute(System.AttributeTargets.Method)]
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
    [System.AttributeUsageAttribute(System.AttributeTargets.Method)]
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
    public partial class WebOperationContext
    {
        public WebOperationContext(System.ServiceModel.OperationContext operationContext) { }
        public System.ServiceModel.Web.IncomingWebResponseContext IncomingResponse { get { throw null; } }
        public System.ServiceModel.Web.OutgoingWebRequestContext OutgoingRequest { get { throw null; } }
        public void Attach(System.ServiceModel.OperationContext owner) { }
        public void Detach(System.ServiceModel.OperationContext owner) { }
    }
}
