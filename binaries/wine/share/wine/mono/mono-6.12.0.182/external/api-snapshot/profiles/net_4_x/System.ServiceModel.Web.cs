// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

[assembly:System.Reflection.AssemblyVersionAttribute("4.0.0.0")]
[assembly:System.CLSCompliantAttribute(true)]
[assembly:System.Diagnostics.DebuggableAttribute(System.Diagnostics.DebuggableAttribute.DebuggingModes.IgnoreSymbolStoreSequencePoints)]
[assembly:System.Reflection.AssemblyCompanyAttribute("MONO development team")]
[assembly:System.Reflection.AssemblyCopyrightAttribute("(c) 2003 Various Authors")]
[assembly:System.Reflection.AssemblyDefaultAliasAttribute("System.ServiceModel.Web.dll")]
[assembly:System.Reflection.AssemblyDescriptionAttribute("System.ServiceModel.Web.dll")]
[assembly:System.Reflection.AssemblyFileVersionAttribute("4.6.57.0")]
[assembly:System.Reflection.AssemblyInformationalVersionAttribute("4.6.57.0")]
[assembly:System.Reflection.AssemblyProductAttribute("MONO CLI")]
[assembly:System.Reflection.AssemblyTitleAttribute("System.ServiceModel.Web.dll")]
[assembly:System.Resources.NeutralResourcesLanguageAttribute("en-US")]
[assembly:System.Resources.SatelliteContractVersionAttribute("4.0.0.0")]
[assembly:System.Runtime.CompilerServices.CompilationRelaxationsAttribute(System.Runtime.CompilerServices.CompilationRelaxations.NoStringInterning)]
[assembly:System.Runtime.CompilerServices.InternalsVisibleToAttribute("dummy-System.Json, PublicKey=00240000048000009400000006020000002400005253413100040000010001008D56C76F9E8649383049F383C44BE0EC204181822A6C31CF5EB7EF486944D032188EA1D3920763712CCB12D75FB77E9811149E6148E5D32FBAAB37611C1878DDC19E20EF135D0CB2CFF2BFEC3D115810C3D9069638FE4BE215DBF795861920E5AB6F7DB2E2CEEF136AC23D5DD2BF031700AEC232F6C6B1C785B4305C123B37AB")]
[assembly:System.Runtime.CompilerServices.RuntimeCompatibilityAttribute(WrapNonExceptionThrows=true)]
[assembly:System.Runtime.InteropServices.ComVisibleAttribute(false)]
[assembly:System.Runtime.CompilerServices.TypeForwardedToAttribute(typeof(System.Runtime.Serialization.Json.DataContractJsonSerializer))]
namespace System.ServiceModel
{
    public partial class WebHttpBinding : System.ServiceModel.Channels.Binding, System.ServiceModel.Channels.IBindingRuntimePreferences
    {
        public WebHttpBinding() { }
        public WebHttpBinding(System.ServiceModel.WebHttpSecurityMode securityMode) { }
        public WebHttpBinding(string configurationName) { }
        [System.ComponentModel.DefaultValueAttribute(false)]
        public bool AllowCookies { get { throw null; } set { } }
        [System.ComponentModel.DefaultValueAttribute(false)]
        public bool BypassProxyOnLocal { get { throw null; } set { } }
        public System.ServiceModel.Channels.WebContentTypeMapper ContentTypeMapper { get { throw null; } set { } }
        [System.MonoTODOAttribute]
        public bool CrossDomainScriptAccessEnabled { get { throw null; } set { } }
        public System.ServiceModel.EnvelopeVersion EnvelopeVersion { get { throw null; } }
        [System.ComponentModel.DefaultValueAttribute(System.ServiceModel.HostNameComparisonMode.StrongWildcard)]
        public System.ServiceModel.HostNameComparisonMode HostNameComparisonMode { get { throw null; } set { } }
        [System.ComponentModel.DefaultValueAttribute(65536)]
        public long MaxBufferPoolSize { get { throw null; } set { } }
        [System.ComponentModel.DefaultValueAttribute(524288)]
        public int MaxBufferSize { get { throw null; } set { } }
        [System.ComponentModel.DefaultValueAttribute(65536)]
        public long MaxReceivedMessageSize { get { throw null; } set { } }
        [System.ComponentModel.DefaultValueAttribute(null)]
        public System.Uri ProxyAddress { get { throw null; } set { } }
        public System.Xml.XmlDictionaryReaderQuotas ReaderQuotas { get { throw null; } set { } }
        public override string Scheme { get { throw null; } }
        public System.ServiceModel.WebHttpSecurity Security { get { throw null; } set { } }
        bool System.ServiceModel.Channels.IBindingRuntimePreferences.ReceiveSynchronously { get { throw null; } }
        [System.ComponentModel.DefaultValueAttribute(System.ServiceModel.TransferMode.Buffered)]
        public System.ServiceModel.TransferMode TransferMode { get { throw null; } set { } }
        [System.ComponentModel.DefaultValueAttribute(true)]
        public bool UseDefaultWebProxy { get { throw null; } set { } }
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
        public System.Xml.XmlDictionaryReaderQuotas ReaderQuotas { get { throw null; } }
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
        [System.Configuration.ConfigurationPropertyAttribute("allowCookies", DefaultValue=false, Options=System.Configuration.ConfigurationPropertyOptions.None)]
        public bool AllowCookies { get { throw null; } set { } }
        protected override System.Type BindingElementType { get { throw null; } }
        [System.Configuration.ConfigurationPropertyAttribute("bypassProxyOnLocal", DefaultValue=false, Options=System.Configuration.ConfigurationPropertyOptions.None)]
        public bool BypassProxyOnLocal { get { throw null; } set { } }
        [System.Configuration.ConfigurationPropertyAttribute("hostNameComparisonMode", DefaultValue="StrongWildcard", Options=System.Configuration.ConfigurationPropertyOptions.None)]
        public System.ServiceModel.HostNameComparisonMode HostNameComparisonMode { get { throw null; } set { } }
        [System.Configuration.ConfigurationPropertyAttribute("maxBufferPoolSize", DefaultValue="524288", Options=System.Configuration.ConfigurationPropertyOptions.None)]
        [System.Configuration.LongValidatorAttribute(MinValue=(long)0, MaxValue=(long)9223372036854775807, ExcludeRange=false)]
        public long MaxBufferPoolSize { get { throw null; } set { } }
        [System.Configuration.ConfigurationPropertyAttribute("maxBufferSize", DefaultValue="65536", Options=System.Configuration.ConfigurationPropertyOptions.None)]
        [System.Configuration.IntegerValidatorAttribute(MinValue=1, MaxValue=2147483647, ExcludeRange=false)]
        public int MaxBufferSize { get { throw null; } set { } }
        [System.Configuration.ConfigurationPropertyAttribute("maxReceivedMessageSize", DefaultValue="65536", Options=System.Configuration.ConfigurationPropertyOptions.None)]
        [System.Configuration.LongValidatorAttribute(MinValue=(long)1, MaxValue=(long)9223372036854775807, ExcludeRange=false)]
        public long MaxReceivedMessageSize { get { throw null; } set { } }
        protected override System.Configuration.ConfigurationPropertyCollection Properties { get { throw null; } }
        [System.Configuration.ConfigurationPropertyAttribute("proxyAddress", DefaultValue=null, Options=System.Configuration.ConfigurationPropertyOptions.None)]
        public System.Uri ProxyAddress { get { throw null; } set { } }
        [System.Configuration.ConfigurationPropertyAttribute("readerQuotas", Options=System.Configuration.ConfigurationPropertyOptions.None)]
        public System.ServiceModel.Configuration.XmlDictionaryReaderQuotasElement ReaderQuotas { get { throw null; } }
        [System.Configuration.ConfigurationPropertyAttribute("security", Options=System.Configuration.ConfigurationPropertyOptions.None)]
        public System.ServiceModel.Configuration.WebHttpSecurityElement Security { get { throw null; } }
        [System.Configuration.ConfigurationPropertyAttribute("transferMode", DefaultValue="Buffered", Options=System.Configuration.ConfigurationPropertyOptions.None)]
        public System.ServiceModel.TransferMode TransferMode { get { throw null; } set { } }
        [System.Configuration.ConfigurationPropertyAttribute("useDefaultWebProxy", DefaultValue=true, Options=System.Configuration.ConfigurationPropertyOptions.None)]
        public bool UseDefaultWebProxy { get { throw null; } set { } }
        [System.ComponentModel.TypeConverterAttribute]
        [System.Configuration.ConfigurationPropertyAttribute("writeEncoding", DefaultValue="utf-8", Options=System.Configuration.ConfigurationPropertyOptions.None)]
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
    public partial class WebHttpEndpointCollectionElement : System.ServiceModel.Configuration.StandardEndpointCollectionElement<System.ServiceModel.Description.WebHttpEndpoint, System.ServiceModel.Configuration.WebHttpEndpointElement>
    {
        public WebHttpEndpointCollectionElement() { }
    }
    public partial class WebHttpEndpointElement : System.ServiceModel.Configuration.StandardEndpointElement
    {
        public WebHttpEndpointElement() { }
        [System.Configuration.ConfigurationPropertyAttribute("automaticFormatSelectionEnabled", DefaultValue=false)]
        public bool AutomaticFormatSelectionEnabled { get { throw null; } set { } }
        [System.Configuration.ConfigurationPropertyAttribute("contentTypeMapper", DefaultValue="")]
        [System.Configuration.StringValidatorAttribute(MinLength=0)]
        public string ContentTypeMapper { get { throw null; } set { } }
        [System.Configuration.ConfigurationPropertyAttribute("crossDomainScriptAccessEnabled", DefaultValue=false)]
        public bool CrossDomainScriptAccessEnabled { get { throw null; } set { } }
        [System.Configuration.ConfigurationPropertyAttribute("defaultOutgoingResponseFormat", DefaultValue=System.ServiceModel.Web.WebMessageFormat.Xml)]
        public System.ServiceModel.Web.WebMessageFormat DefaultOutgoingResponseFormat { get { throw null; } set { } }
        protected internal override System.Type EndpointType { get { throw null; } }
        [System.Configuration.ConfigurationPropertyAttribute("faultExceptionEnabled", DefaultValue=false)]
        public bool FaultExceptionEnabled { get { throw null; } set { } }
        [System.Configuration.ConfigurationPropertyAttribute("helpEnabled", DefaultValue=false)]
        public bool HelpEnabled { get { throw null; } set { } }
        [System.Configuration.ConfigurationPropertyAttribute("hostNameComparisonMode", DefaultValue=System.ServiceModel.HostNameComparisonMode.StrongWildcard)]
        public System.ServiceModel.HostNameComparisonMode HostNameComparisonMode { get { throw null; } set { } }
        [System.Configuration.ConfigurationPropertyAttribute("maxBufferPoolSize", DefaultValue=524288, Options=System.Configuration.ConfigurationPropertyOptions.None)]
        [System.Configuration.LongValidatorAttribute(MinValue=(long)0, MaxValue=(long)9223372036854775807, ExcludeRange=false)]
        public long MaxBufferPoolSize { get { throw null; } set { } }
        [System.Configuration.ConfigurationPropertyAttribute("maxBufferSize", DefaultValue=65536, Options=System.Configuration.ConfigurationPropertyOptions.None)]
        [System.Configuration.IntegerValidatorAttribute(MinValue=1, MaxValue=2147483647, ExcludeRange=false)]
        public int MaxBufferSize { get { throw null; } set { } }
        [System.Configuration.ConfigurationPropertyAttribute("maxReceivedMessageSize", DefaultValue=65536, Options=System.Configuration.ConfigurationPropertyOptions.None)]
        [System.Configuration.LongValidatorAttribute(MinValue=(long)1, MaxValue=(long)9223372036854775807, ExcludeRange=false)]
        public long MaxReceivedMessageSize { get { throw null; } set { } }
        protected override System.Configuration.ConfigurationPropertyCollection Properties { get { throw null; } }
        [System.Configuration.ConfigurationPropertyAttribute("readerQuotas")]
        public System.ServiceModel.Configuration.XmlDictionaryReaderQuotasElement ReaderQuotas { get { throw null; } }
        [System.Configuration.ConfigurationPropertyAttribute("security")]
        public System.ServiceModel.Configuration.WebHttpSecurityElement Security { get { throw null; } }
        [System.Configuration.ConfigurationPropertyAttribute("transferMode", DefaultValue=System.ServiceModel.TransferMode.Buffered)]
        public System.ServiceModel.TransferMode TransferMode { get { throw null; } set { } }
        [System.ComponentModel.TypeConverterAttribute("System.ServiceModel.Configuration.EncodingConverter")]
        [System.Configuration.ConfigurationPropertyAttribute("writeEncoding", DefaultValue="utf-8")]
        public System.Text.Encoding WriteEncoding { get { throw null; } set { } }
        protected internal override System.ServiceModel.Description.ServiceEndpoint CreateServiceEndpoint(System.ServiceModel.Description.ContractDescription contractDescription) { throw null; }
        protected override void OnApplyConfiguration(System.ServiceModel.Description.ServiceEndpoint endpoint, System.ServiceModel.Configuration.ChannelEndpointElement serviceEndpointElement) { }
        protected override void OnApplyConfiguration(System.ServiceModel.Description.ServiceEndpoint endpoint, System.ServiceModel.Configuration.ServiceEndpointElement serviceEndpointElement) { }
        protected override void OnInitializeAndValidate(System.ServiceModel.Configuration.ChannelEndpointElement channelEndpointElement) { }
        protected override void OnInitializeAndValidate(System.ServiceModel.Configuration.ServiceEndpointElement serviceEndpointElement) { }
    }
    public sealed partial class WebHttpSecurityElement : System.Configuration.ConfigurationElement
    {
        public WebHttpSecurityElement() { }
        [System.Configuration.ConfigurationPropertyAttribute("mode", DefaultValue="None", Options=System.Configuration.ConfigurationPropertyOptions.None)]
        public System.ServiceModel.WebHttpSecurityMode Mode { get { throw null; } set { } }
        protected override System.Configuration.ConfigurationPropertyCollection Properties { get { throw null; } }
        [System.Configuration.ConfigurationPropertyAttribute("transport", Options=System.Configuration.ConfigurationPropertyOptions.None)]
        public System.ServiceModel.Configuration.HttpTransportSecurityElement Transport { get { throw null; } }
    }
    public sealed partial class WebMessageEncodingElement : System.ServiceModel.Configuration.BindingElementExtensionElement
    {
        public WebMessageEncodingElement() { }
        public override System.Type BindingElementType { get { throw null; } }
        [System.Configuration.ConfigurationPropertyAttribute("maxReadPoolSize", Options=System.Configuration.ConfigurationPropertyOptions.None, DefaultValue="64")]
        [System.Configuration.IntegerValidatorAttribute(MinValue=1, MaxValue=2147483647, ExcludeRange=false)]
        public int MaxReadPoolSize { get { throw null; } set { } }
        [System.Configuration.ConfigurationPropertyAttribute("maxWritePoolSize", Options=System.Configuration.ConfigurationPropertyOptions.None, DefaultValue="16")]
        [System.Configuration.IntegerValidatorAttribute(MinValue=1, MaxValue=2147483647, ExcludeRange=false)]
        public int MaxWritePoolSize { get { throw null; } set { } }
        [System.Configuration.ConfigurationPropertyAttribute("readerQuotas", Options=System.Configuration.ConfigurationPropertyOptions.None)]
        public System.ServiceModel.Configuration.XmlDictionaryReaderQuotasElement ReaderQuotas { get { throw null; } }
        [System.Configuration.ConfigurationPropertyAttribute("webContentTypeMapperType", Options=System.Configuration.ConfigurationPropertyOptions.None, DefaultValue="")]
        [System.Configuration.StringValidatorAttribute(MinLength=0, MaxLength=2147483647)]
        public string WebContentTypeMapperType { get { throw null; } set { } }
        [System.ComponentModel.TypeConverterAttribute]
        [System.Configuration.ConfigurationPropertyAttribute("writeEncoding", Options=System.Configuration.ConfigurationPropertyOptions.None, DefaultValue="utf-8")]
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
    public partial class WebScriptEndpointCollectionElement : System.ServiceModel.Configuration.StandardEndpointCollectionElement<System.ServiceModel.Description.WebScriptEndpoint, System.ServiceModel.Configuration.WebScriptEndpointElement>
    {
        public WebScriptEndpointCollectionElement() { }
    }
    public partial class WebScriptEndpointElement : System.ServiceModel.Configuration.StandardEndpointElement
    {
        public WebScriptEndpointElement() { }
        [System.Configuration.ConfigurationPropertyAttribute("contentTypeMapper", DefaultValue="")]
        [System.Configuration.StringValidatorAttribute(MinLength=0)]
        public string ContentTypeMapper { get { throw null; } set { } }
        [System.Configuration.ConfigurationPropertyAttribute("crossDomainScriptAccessEnabled", DefaultValue=false)]
        public bool CrossDomainScriptAccessEnabled { get { throw null; } set { } }
        protected internal override System.Type EndpointType { get { throw null; } }
        [System.Configuration.ConfigurationPropertyAttribute("hostNameComparisonMode", DefaultValue=System.ServiceModel.HostNameComparisonMode.StrongWildcard)]
        public System.ServiceModel.HostNameComparisonMode HostNameComparisonMode { get { throw null; } set { } }
        [System.Configuration.ConfigurationPropertyAttribute("maxBufferPoolSize", DefaultValue=524288, Options=System.Configuration.ConfigurationPropertyOptions.None)]
        [System.Configuration.LongValidatorAttribute(MinValue=(long)0, MaxValue=(long)9223372036854775807, ExcludeRange=false)]
        public long MaxBufferPoolSize { get { throw null; } set { } }
        [System.Configuration.ConfigurationPropertyAttribute("maxBufferSize", DefaultValue=65536, Options=System.Configuration.ConfigurationPropertyOptions.None)]
        [System.Configuration.IntegerValidatorAttribute(MinValue=1, MaxValue=2147483647, ExcludeRange=false)]
        public int MaxBufferSize { get { throw null; } set { } }
        [System.Configuration.ConfigurationPropertyAttribute("maxReceivedMessageSize", DefaultValue=65536, Options=System.Configuration.ConfigurationPropertyOptions.None)]
        [System.Configuration.LongValidatorAttribute(MinValue=(long)1, MaxValue=(long)9223372036854775807, ExcludeRange=false)]
        public long MaxReceivedMessageSize { get { throw null; } set { } }
        protected override System.Configuration.ConfigurationPropertyCollection Properties { get { throw null; } }
        [System.Configuration.ConfigurationPropertyAttribute("readerQuotas")]
        public System.ServiceModel.Configuration.XmlDictionaryReaderQuotasElement ReaderQuotas { get { throw null; } }
        [System.Configuration.ConfigurationPropertyAttribute("security")]
        public System.ServiceModel.Configuration.WebHttpSecurityElement Security { get { throw null; } }
        [System.Configuration.ConfigurationPropertyAttribute("transferMode", DefaultValue=System.ServiceModel.TransferMode.Buffered)]
        public System.ServiceModel.TransferMode TransferMode { get { throw null; } set { } }
        [System.ComponentModel.TypeConverterAttribute("System.ServiceModel.Configuration.EncodingConverter")]
        [System.Configuration.ConfigurationPropertyAttribute("writeEncoding", DefaultValue="utf-8")]
        public System.Text.Encoding WriteEncoding { get { throw null; } set { } }
        protected internal override System.ServiceModel.Description.ServiceEndpoint CreateServiceEndpoint(System.ServiceModel.Description.ContractDescription contractDescription) { throw null; }
        protected override void OnApplyConfiguration(System.ServiceModel.Description.ServiceEndpoint endpoint, System.ServiceModel.Configuration.ChannelEndpointElement serviceEndpointElement) { }
        protected override void OnApplyConfiguration(System.ServiceModel.Description.ServiceEndpoint endpoint, System.ServiceModel.Configuration.ServiceEndpointElement serviceEndpointElement) { }
        protected override void OnInitializeAndValidate(System.ServiceModel.Configuration.ChannelEndpointElement channelEndpointElement) { }
        protected override void OnInitializeAndValidate(System.ServiceModel.Configuration.ServiceEndpointElement serviceEndpointElement) { }
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
    [System.MonoTODOAttribute]
    public partial class WebHttpEndpoint : System.ServiceModel.Description.WebServiceEndpoint
    {
        public WebHttpEndpoint(System.ServiceModel.Description.ContractDescription contract) { }
        public WebHttpEndpoint(System.ServiceModel.Description.ContractDescription contract, System.ServiceModel.EndpointAddress address) { }
        public bool AutomaticFormatSelectionEnabled { get { throw null; } set { } }
        public System.ServiceModel.Web.WebMessageFormat DefaultOutgoingResponseFormat { get { throw null; } set { } }
        public bool FaultExceptionEnabled { get { throw null; } set { } }
        public bool HelpEnabled { get { throw null; } set { } }
        protected override System.Type WebEndpointType { get { throw null; } }
    }
    public sealed partial class WebScriptEnablingBehavior : System.ServiceModel.Description.WebHttpBehavior
    {
        public WebScriptEnablingBehavior() { }
        public override System.ServiceModel.Web.WebMessageBodyStyle DefaultBodyStyle { get { throw null; } set { } }
        public override System.ServiceModel.Web.WebMessageFormat DefaultOutgoingRequestFormat { get { throw null; } set { } }
        public override System.ServiceModel.Web.WebMessageFormat DefaultOutgoingResponseFormat { get { throw null; } set { } }
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
    [System.MonoTODOAttribute]
    public partial class WebScriptEndpoint : System.ServiceModel.Description.WebServiceEndpoint
    {
        public WebScriptEndpoint(System.ServiceModel.Description.ContractDescription contract) { }
        public WebScriptEndpoint(System.ServiceModel.Description.ContractDescription contract, System.ServiceModel.EndpointAddress address) { }
        protected override System.Type WebEndpointType { get { throw null; } }
    }
    public abstract partial class WebServiceEndpoint : System.ServiceModel.Description.ServiceEndpoint
    {
        internal WebServiceEndpoint() : base (default(System.ServiceModel.Description.ContractDescription)) { }
        public System.ServiceModel.Channels.WebContentTypeMapper ContentTypeMapper { get { throw null; } set { } }
        public bool CrossDomainScriptAccessEnabled { get { throw null; } set { } }
        public System.ServiceModel.HostNameComparisonMode HostNameComparisonMode { get { throw null; } set { } }
        public long MaxBufferPoolSize { get { throw null; } set { } }
        public int MaxBufferSize { get { throw null; } set { } }
        public long MaxReceivedMessageSize { get { throw null; } set { } }
        public System.Xml.XmlDictionaryReaderQuotas ReaderQuotas { get { throw null; } set { } }
        public System.ServiceModel.WebHttpSecurity Security { get { throw null; } }
        public System.ServiceModel.TransferMode TransferMode { get { throw null; } set { } }
        protected abstract System.Type WebEndpointType { get; }
        public System.Text.Encoding WriteEncoding { get { throw null; } set { } }
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
        protected virtual string SelectOperation(ref System.ServiceModel.Channels.Message message, out bool uriMatched) { throw null; }
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
    public partial class WebOperationContext : System.ServiceModel.IExtension<System.ServiceModel.OperationContext>
    {
        public WebOperationContext(System.ServiceModel.OperationContext operationContext) { }
        public static System.ServiceModel.Web.WebOperationContext Current { get { throw null; } }
        public System.ServiceModel.Web.IncomingWebRequestContext IncomingRequest { get { throw null; } }
        public System.ServiceModel.Web.IncomingWebResponseContext IncomingResponse { get { throw null; } }
        public System.ServiceModel.Web.OutgoingWebRequestContext OutgoingRequest { get { throw null; } }
        public System.ServiceModel.Web.OutgoingWebResponseContext OutgoingResponse { get { throw null; } }
        public void Attach(System.ServiceModel.OperationContext owner) { }
        public System.ServiceModel.Channels.Message CreateAtom10Response(System.ServiceModel.Syndication.ServiceDocument document) { throw null; }
        public System.ServiceModel.Channels.Message CreateAtom10Response(System.ServiceModel.Syndication.SyndicationFeed feed) { throw null; }
        public System.ServiceModel.Channels.Message CreateAtom10Response(System.ServiceModel.Syndication.SyndicationItem item) { throw null; }
        public System.ServiceModel.Channels.Message CreateJsonResponse<T>(T instance) { throw null; }
        public System.ServiceModel.Channels.Message CreateJsonResponse<T>(T instance, System.Runtime.Serialization.Json.DataContractJsonSerializer serializer) { throw null; }
        public void Detach(System.ServiceModel.OperationContext owner) { }
    }
    public partial class WebServiceHost : System.ServiceModel.ServiceHost
    {
        public WebServiceHost() { }
        public WebServiceHost(object singletonInstance, params System.Uri[] baseAddresses) { }
        public WebServiceHost(System.Type serviceType, params System.Uri[] baseAddresses) { }
        protected override void OnOpening() { }
    }
}
