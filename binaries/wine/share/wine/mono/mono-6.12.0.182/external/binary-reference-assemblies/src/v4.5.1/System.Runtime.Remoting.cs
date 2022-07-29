// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

[assembly:System.Reflection.AssemblyVersionAttribute("4.0.0.0")]
[assembly:System.CLSCompliantAttribute(false)]
[assembly:System.Diagnostics.DebuggableAttribute((System.Diagnostics.DebuggableAttribute.DebuggingModes)(258))]
[assembly:System.Reflection.AssemblyCompanyAttribute("Mono development team")]
[assembly:System.Reflection.AssemblyCopyrightAttribute("(c) Various Mono authors")]
[assembly:System.Reflection.AssemblyDefaultAliasAttribute("System.Runtime.Remoting.dll")]
[assembly:System.Reflection.AssemblyDescriptionAttribute("System.Runtime.Remoting.dll")]
[assembly:System.Reflection.AssemblyFileVersionAttribute("4.0.30319.17020")]
[assembly:System.Reflection.AssemblyInformationalVersionAttribute("4.0.30319.17020")]
[assembly:System.Reflection.AssemblyProductAttribute("Mono Common Language Infrastructure")]
[assembly:System.Reflection.AssemblyTitleAttribute("System.Runtime.Remoting.dll")]
[assembly:System.Resources.NeutralResourcesLanguageAttribute("en-US")]
[assembly:System.Resources.SatelliteContractVersionAttribute("4.0.0.0")]
[assembly:System.Runtime.CompilerServices.CompilationRelaxationsAttribute((System.Runtime.CompilerServices.CompilationRelaxations)(8))]
[assembly:System.Runtime.CompilerServices.ReferenceAssemblyAttribute]
[assembly:System.Runtime.CompilerServices.RuntimeCompatibilityAttribute(WrapNonExceptionThrows=true)]
[assembly:System.Runtime.InteropServices.ComCompatibleVersionAttribute(1, 0, 3300, 0)]
[assembly:System.Runtime.InteropServices.ComVisibleAttribute(false)]
[assembly:System.Runtime.InteropServices.TypeLibVersionAttribute(2, 0)]
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
namespace System.Runtime.Remoting.Channels
{
    public partial class BinaryClientFormatterSink : System.Runtime.Remoting.Channels.IChannelSinkBase, System.Runtime.Remoting.Channels.IClientChannelSink, System.Runtime.Remoting.Channels.IClientFormatterSink, System.Runtime.Remoting.Messaging.IMessageSink
    {
        public BinaryClientFormatterSink(System.Runtime.Remoting.Channels.IClientChannelSink nextSink) { }
        public System.Runtime.Remoting.Channels.IClientChannelSink NextChannelSink { get { throw null; } }
        public System.Runtime.Remoting.Messaging.IMessageSink NextSink { get { throw null; } }
        public System.Collections.IDictionary Properties { get { throw null; } }
        public System.Runtime.Remoting.Messaging.IMessageCtrl AsyncProcessMessage(System.Runtime.Remoting.Messaging.IMessage msg, System.Runtime.Remoting.Messaging.IMessageSink replySink) { throw null; }
        public void AsyncProcessRequest(System.Runtime.Remoting.Channels.IClientChannelSinkStack sinkStack, System.Runtime.Remoting.Messaging.IMessage msg, System.Runtime.Remoting.Channels.ITransportHeaders headers, System.IO.Stream stream) { }
        public void AsyncProcessResponse(System.Runtime.Remoting.Channels.IClientResponseChannelSinkStack sinkStack, object state, System.Runtime.Remoting.Channels.ITransportHeaders headers, System.IO.Stream stream) { }
        public System.IO.Stream GetRequestStream(System.Runtime.Remoting.Messaging.IMessage msg, System.Runtime.Remoting.Channels.ITransportHeaders headers) { throw null; }
        public void ProcessMessage(System.Runtime.Remoting.Messaging.IMessage msg, System.Runtime.Remoting.Channels.ITransportHeaders requestHeaders, System.IO.Stream requestStream, out System.Runtime.Remoting.Channels.ITransportHeaders responseHeaders, out System.IO.Stream responseStream) { responseHeaders = default(System.Runtime.Remoting.Channels.ITransportHeaders); responseStream = default(System.IO.Stream); }
        public System.Runtime.Remoting.Messaging.IMessage SyncProcessMessage(System.Runtime.Remoting.Messaging.IMessage msg) { throw null; }
    }
    public partial class BinaryClientFormatterSinkProvider : System.Runtime.Remoting.Channels.IClientChannelSinkProvider, System.Runtime.Remoting.Channels.IClientFormatterSinkProvider
    {
        public BinaryClientFormatterSinkProvider() { }
        public BinaryClientFormatterSinkProvider(System.Collections.IDictionary properties, System.Collections.ICollection providerData) { }
        public System.Runtime.Remoting.Channels.IClientChannelSinkProvider Next { get { throw null; } set { } }
        public System.Runtime.Remoting.Channels.IClientChannelSink CreateSink(System.Runtime.Remoting.Channels.IChannelSender channel, string url, object remoteChannelData) { throw null; }
    }
    public partial class BinaryServerFormatterSink : System.Runtime.Remoting.Channels.IChannelSinkBase, System.Runtime.Remoting.Channels.IServerChannelSink
    {
        public BinaryServerFormatterSink(System.Runtime.Remoting.Channels.BinaryServerFormatterSink.Protocol protocol, System.Runtime.Remoting.Channels.IServerChannelSink nextSink, System.Runtime.Remoting.Channels.IChannelReceiver receiver) { }
        public System.Runtime.Remoting.Channels.IServerChannelSink NextChannelSink { get { throw null; } }
        public System.Collections.IDictionary Properties { get { throw null; } }
        [System.Runtime.InteropServices.ComVisibleAttribute(false)]
        public System.Runtime.Serialization.Formatters.TypeFilterLevel TypeFilterLevel { get { throw null; } set { } }
        public void AsyncProcessResponse(System.Runtime.Remoting.Channels.IServerResponseChannelSinkStack sinkStack, object state, System.Runtime.Remoting.Messaging.IMessage msg, System.Runtime.Remoting.Channels.ITransportHeaders headers, System.IO.Stream stream) { }
        public System.IO.Stream GetResponseStream(System.Runtime.Remoting.Channels.IServerResponseChannelSinkStack sinkStack, object state, System.Runtime.Remoting.Messaging.IMessage msg, System.Runtime.Remoting.Channels.ITransportHeaders headers) { throw null; }
        public System.Runtime.Remoting.Channels.ServerProcessing ProcessMessage(System.Runtime.Remoting.Channels.IServerChannelSinkStack sinkStack, System.Runtime.Remoting.Messaging.IMessage requestMsg, System.Runtime.Remoting.Channels.ITransportHeaders requestHeaders, System.IO.Stream requestStream, out System.Runtime.Remoting.Messaging.IMessage responseMsg, out System.Runtime.Remoting.Channels.ITransportHeaders responseHeaders, out System.IO.Stream responseStream) { responseMsg = default(System.Runtime.Remoting.Messaging.IMessage); responseHeaders = default(System.Runtime.Remoting.Channels.ITransportHeaders); responseStream = default(System.IO.Stream); throw null; }
        [System.SerializableAttribute]
        public enum Protocol
        {
            Http = 0,
            Other = 1,
        }
    }
    public partial class BinaryServerFormatterSinkProvider : System.Runtime.Remoting.Channels.IServerChannelSinkProvider, System.Runtime.Remoting.Channels.IServerFormatterSinkProvider
    {
        public BinaryServerFormatterSinkProvider() { }
        public BinaryServerFormatterSinkProvider(System.Collections.IDictionary properties, System.Collections.ICollection providerData) { }
        public System.Runtime.Remoting.Channels.IServerChannelSinkProvider Next { get { throw null; } set { } }
        [System.Runtime.InteropServices.ComVisibleAttribute(false)]
        public System.Runtime.Serialization.Formatters.TypeFilterLevel TypeFilterLevel { get { throw null; } set { } }
        public System.Runtime.Remoting.Channels.IServerChannelSink CreateSink(System.Runtime.Remoting.Channels.IChannelReceiver channel) { throw null; }
        public void GetChannelData(System.Runtime.Remoting.Channels.IChannelDataStore channelData) { }
    }
    public partial class CommonTransportKeys
    {
        public const string ConnectionId = "__ConnectionId";
        public const string IPAddress = "__IPAddress";
        public const string RequestUri = "__RequestUri";
        public CommonTransportKeys() { }
    }
    public partial interface IAuthorizeRemotingConnection
    {
        bool IsConnectingEndPointAuthorized(System.Net.EndPoint endPoint);
        bool IsConnectingIdentityAuthorized(System.Security.Principal.IIdentity identity);
    }
    public partial class SoapClientFormatterSink : System.Runtime.Remoting.Channels.IChannelSinkBase, System.Runtime.Remoting.Channels.IClientChannelSink, System.Runtime.Remoting.Channels.IClientFormatterSink, System.Runtime.Remoting.Messaging.IMessageSink
    {
        public SoapClientFormatterSink(System.Runtime.Remoting.Channels.IClientChannelSink nextSink) { }
        public System.Runtime.Remoting.Channels.IClientChannelSink NextChannelSink { get { throw null; } }
        public System.Runtime.Remoting.Messaging.IMessageSink NextSink { get { throw null; } }
        public System.Collections.IDictionary Properties { get { throw null; } }
        public System.Runtime.Remoting.Messaging.IMessageCtrl AsyncProcessMessage(System.Runtime.Remoting.Messaging.IMessage msg, System.Runtime.Remoting.Messaging.IMessageSink replySink) { throw null; }
        public void AsyncProcessRequest(System.Runtime.Remoting.Channels.IClientChannelSinkStack sinkStack, System.Runtime.Remoting.Messaging.IMessage msg, System.Runtime.Remoting.Channels.ITransportHeaders headers, System.IO.Stream stream) { }
        public void AsyncProcessResponse(System.Runtime.Remoting.Channels.IClientResponseChannelSinkStack sinkStack, object state, System.Runtime.Remoting.Channels.ITransportHeaders headers, System.IO.Stream stream) { }
        public System.IO.Stream GetRequestStream(System.Runtime.Remoting.Messaging.IMessage msg, System.Runtime.Remoting.Channels.ITransportHeaders headers) { throw null; }
        public void ProcessMessage(System.Runtime.Remoting.Messaging.IMessage msg, System.Runtime.Remoting.Channels.ITransportHeaders requestHeaders, System.IO.Stream requestStream, out System.Runtime.Remoting.Channels.ITransportHeaders responseHeaders, out System.IO.Stream responseStream) { responseHeaders = default(System.Runtime.Remoting.Channels.ITransportHeaders); responseStream = default(System.IO.Stream); }
        public System.Runtime.Remoting.Messaging.IMessage SyncProcessMessage(System.Runtime.Remoting.Messaging.IMessage msg) { throw null; }
    }
    public partial class SoapClientFormatterSinkProvider : System.Runtime.Remoting.Channels.IClientChannelSinkProvider, System.Runtime.Remoting.Channels.IClientFormatterSinkProvider
    {
        public SoapClientFormatterSinkProvider() { }
        public SoapClientFormatterSinkProvider(System.Collections.IDictionary properties, System.Collections.ICollection providerData) { }
        public System.Runtime.Remoting.Channels.IClientChannelSinkProvider Next { get { throw null; } set { } }
        public System.Runtime.Remoting.Channels.IClientChannelSink CreateSink(System.Runtime.Remoting.Channels.IChannelSender channel, string url, object remoteChannelData) { throw null; }
    }
    public partial class SoapServerFormatterSink : System.Runtime.Remoting.Channels.IChannelSinkBase, System.Runtime.Remoting.Channels.IServerChannelSink
    {
        public SoapServerFormatterSink(System.Runtime.Remoting.Channels.SoapServerFormatterSink.Protocol protocol, System.Runtime.Remoting.Channels.IServerChannelSink nextSink, System.Runtime.Remoting.Channels.IChannelReceiver receiver) { }
        public System.Runtime.Remoting.Channels.IServerChannelSink NextChannelSink { get { throw null; } }
        public System.Collections.IDictionary Properties { get { throw null; } }
        [System.Runtime.InteropServices.ComVisibleAttribute(false)]
        public System.Runtime.Serialization.Formatters.TypeFilterLevel TypeFilterLevel { get { throw null; } set { } }
        public void AsyncProcessResponse(System.Runtime.Remoting.Channels.IServerResponseChannelSinkStack sinkStack, object state, System.Runtime.Remoting.Messaging.IMessage msg, System.Runtime.Remoting.Channels.ITransportHeaders headers, System.IO.Stream stream) { }
        public System.IO.Stream GetResponseStream(System.Runtime.Remoting.Channels.IServerResponseChannelSinkStack sinkStack, object state, System.Runtime.Remoting.Messaging.IMessage msg, System.Runtime.Remoting.Channels.ITransportHeaders headers) { throw null; }
        public System.Runtime.Remoting.Channels.ServerProcessing ProcessMessage(System.Runtime.Remoting.Channels.IServerChannelSinkStack sinkStack, System.Runtime.Remoting.Messaging.IMessage requestMsg, System.Runtime.Remoting.Channels.ITransportHeaders requestHeaders, System.IO.Stream requestStream, out System.Runtime.Remoting.Messaging.IMessage responseMsg, out System.Runtime.Remoting.Channels.ITransportHeaders responseHeaders, out System.IO.Stream responseStream) { responseMsg = default(System.Runtime.Remoting.Messaging.IMessage); responseHeaders = default(System.Runtime.Remoting.Channels.ITransportHeaders); responseStream = default(System.IO.Stream); throw null; }
        [System.SerializableAttribute]
        public enum Protocol
        {
            Http = 0,
            Other = 1,
        }
    }
    public partial class SoapServerFormatterSinkProvider : System.Runtime.Remoting.Channels.IServerChannelSinkProvider, System.Runtime.Remoting.Channels.IServerFormatterSinkProvider
    {
        public SoapServerFormatterSinkProvider() { }
        public SoapServerFormatterSinkProvider(System.Collections.IDictionary properties, System.Collections.ICollection providerData) { }
        public System.Runtime.Remoting.Channels.IServerChannelSinkProvider Next { get { throw null; } set { } }
        [System.Runtime.InteropServices.ComVisibleAttribute(false)]
        public System.Runtime.Serialization.Formatters.TypeFilterLevel TypeFilterLevel { get { throw null; } set { } }
        public System.Runtime.Remoting.Channels.IServerChannelSink CreateSink(System.Runtime.Remoting.Channels.IChannelReceiver channel) { throw null; }
        public void GetChannelData(System.Runtime.Remoting.Channels.IChannelDataStore channelData) { }
    }
    public enum SocketCachePolicy
    {
        AbsoluteTimeout = 1,
        Default = 0,
    }
}
namespace System.Runtime.Remoting.Channels.Http
{
    public partial class HttpChannel : System.Runtime.Remoting.Channels.BaseChannelWithProperties, System.Runtime.Remoting.Channels.IChannel, System.Runtime.Remoting.Channels.IChannelReceiver, System.Runtime.Remoting.Channels.IChannelReceiverHook, System.Runtime.Remoting.Channels.IChannelSender, System.Runtime.Remoting.Channels.ISecurableChannel
    {
        public HttpChannel() { }
        public HttpChannel(System.Collections.IDictionary properties, System.Runtime.Remoting.Channels.IClientChannelSinkProvider clientSinkProvider, System.Runtime.Remoting.Channels.IServerChannelSinkProvider serverSinkProvider) { }
        public HttpChannel(int port) { }
        public object ChannelData { get { throw null; } }
        public string ChannelName { get { throw null; } }
        public int ChannelPriority { get { throw null; } }
        public string ChannelScheme { get { throw null; } }
        public System.Runtime.Remoting.Channels.IServerChannelSink ChannelSinkChain { get { throw null; } }
        public bool IsSecured { get { throw null; } set { } }
        public override object this[object key] { get { throw null; } set { } }
        public override System.Collections.ICollection Keys { get { throw null; } }
        public override System.Collections.IDictionary Properties { get { throw null; } }
        public bool WantsToListen { get { throw null; } set { } }
        public void AddHookChannelUri(string channelUri) { }
        public System.Runtime.Remoting.Messaging.IMessageSink CreateMessageSink(string url, object remoteChannelData, out string objectURI) { objectURI = default(string); throw null; }
        public string[] GetUrlsForUri(string objectURI) { throw null; }
        public string Parse(string url, out string objectURI) { objectURI = default(string); throw null; }
        public void StartListening(object data) { }
        public void StopListening(object data) { }
    }
    public partial class HttpClientChannel : System.Runtime.Remoting.Channels.BaseChannelWithProperties, System.Runtime.Remoting.Channels.IChannel, System.Runtime.Remoting.Channels.IChannelSender, System.Runtime.Remoting.Channels.ISecurableChannel
    {
        public HttpClientChannel() { }
        [System.MonoTODOAttribute("Handle the machineName, proxyName, proxyPort, servicePrincipalName, useAuthenticatedConnectionSharing properties")]
        public HttpClientChannel(System.Collections.IDictionary properties, System.Runtime.Remoting.Channels.IClientChannelSinkProvider sinkProvider) { }
        public HttpClientChannel(string name, System.Runtime.Remoting.Channels.IClientChannelSinkProvider sinkProvider) { }
        public string ChannelName { get { throw null; } }
        public int ChannelPriority { get { throw null; } }
        public bool IsSecured { get { throw null; } set { } }
        public override object this[object key] { get { throw null; } set { } }
        public override System.Collections.ICollection Keys { get { throw null; } }
        public virtual System.Runtime.Remoting.Messaging.IMessageSink CreateMessageSink(string url, object remoteChannelData, out string objectURI) { objectURI = default(string); throw null; }
        public string Parse(string url, out string objectURI) { objectURI = default(string); throw null; }
    }
    public partial class HttpRemotingHandler : System.Web.IHttpHandler
    {
        public HttpRemotingHandler() { }
        [System.MonoTODOAttribute]
        public HttpRemotingHandler(System.Type type, object srvID) { }
        public bool IsReusable { get { throw null; } }
        public void ProcessRequest(System.Web.HttpContext context) { }
    }
    public partial class HttpRemotingHandlerFactory : System.Web.IHttpHandlerFactory
    {
        public HttpRemotingHandlerFactory() { }
        public System.Web.IHttpHandler GetHandler(System.Web.HttpContext context, string verb, string url, string filePath) { throw null; }
        public void ReleaseHandler(System.Web.IHttpHandler handler) { }
    }
    public partial class HttpServerChannel : System.Runtime.Remoting.Channels.BaseChannelWithProperties, System.Runtime.Remoting.Channels.IChannel, System.Runtime.Remoting.Channels.IChannelReceiver, System.Runtime.Remoting.Channels.IChannelReceiverHook
    {
        public HttpServerChannel() { }
        [System.MonoTODOAttribute("Handle the listen property")]
        public HttpServerChannel(System.Collections.IDictionary properties, System.Runtime.Remoting.Channels.IServerChannelSinkProvider sinkProvider) { }
        public HttpServerChannel(int port) { }
        public HttpServerChannel(string name, int port) { }
        public HttpServerChannel(string name, int port, System.Runtime.Remoting.Channels.IServerChannelSinkProvider sinkProvider) { }
        public object ChannelData { get { throw null; } }
        public string ChannelName { get { throw null; } }
        public int ChannelPriority { get { throw null; } }
        public string ChannelScheme { get { throw null; } }
        public System.Runtime.Remoting.Channels.IServerChannelSink ChannelSinkChain { get { throw null; } }
        public override object this[object key] { get { throw null; } set { } }
        public override System.Collections.ICollection Keys { get { throw null; } }
        public bool WantsToListen { get { throw null; } set { } }
        public void AddHookChannelUri(string channelUri) { }
        public string GetChannelUri() { throw null; }
        public virtual string[] GetUrlsForUri(string objectUri) { throw null; }
        public string Parse(string url, out string objectURI) { objectURI = default(string); throw null; }
        public void StartListening(object data) { }
        public void StopListening(object data) { }
    }
}
namespace System.Runtime.Remoting.Channels.Ipc
{
    public partial class IpcChannel : System.Runtime.Remoting.Channels.IChannel, System.Runtime.Remoting.Channels.IChannelReceiver, System.Runtime.Remoting.Channels.IChannelSender, System.Runtime.Remoting.Channels.ISecurableChannel
    {
        public IpcChannel() { }
        public IpcChannel(System.Collections.IDictionary properties, System.Runtime.Remoting.Channels.IClientChannelSinkProvider clientSinkProvider, System.Runtime.Remoting.Channels.IServerChannelSinkProvider serverSinkProvider) { }
        public IpcChannel(System.Collections.IDictionary properties, System.Runtime.Remoting.Channels.IClientChannelSinkProvider clientSinkProvider, System.Runtime.Remoting.Channels.IServerChannelSinkProvider serverSinkProvider, System.Security.AccessControl.CommonSecurityDescriptor securityDescriptor) { }
        public IpcChannel(string portName) { }
        public object ChannelData { get { throw null; } }
        public string ChannelName { get { throw null; } }
        public int ChannelPriority { get { throw null; } }
        public bool IsSecured { get { throw null; } set { } }
        public System.Runtime.Remoting.Messaging.IMessageSink CreateMessageSink(string url, object remoteChannelData, out string objectURI) { objectURI = default(string); throw null; }
        public string[] GetUrlsForUri(string objectURI) { throw null; }
        public string Parse(string url, out string objectURI) { objectURI = default(string); throw null; }
        public void StartListening(object data) { }
        public void StopListening(object data) { }
    }
    public partial class IpcClientChannel : System.Runtime.Remoting.Channels.IChannel, System.Runtime.Remoting.Channels.IChannelSender, System.Runtime.Remoting.Channels.ISecurableChannel
    {
        public IpcClientChannel() { }
        public IpcClientChannel(System.Collections.IDictionary properties, System.Runtime.Remoting.Channels.IClientChannelSinkProvider sinkProvider) { }
        public IpcClientChannel(string name, System.Runtime.Remoting.Channels.IClientChannelSinkProvider sinkProvider) { }
        public string ChannelName { get { throw null; } }
        public int ChannelPriority { get { throw null; } }
        public bool IsSecured { get { throw null; } set { } }
        public virtual System.Runtime.Remoting.Messaging.IMessageSink CreateMessageSink(string url, object remoteChannelData, out string objectURI) { objectURI = default(string); throw null; }
        public string Parse(string url, out string objectURI) { objectURI = default(string); throw null; }
    }
    public partial class IpcServerChannel : System.Runtime.Remoting.Channels.IChannel, System.Runtime.Remoting.Channels.IChannelReceiver, System.Runtime.Remoting.Channels.ISecurableChannel
    {
        public IpcServerChannel(System.Collections.IDictionary properties, System.Runtime.Remoting.Channels.IServerChannelSinkProvider sinkProvider) { }
        public IpcServerChannel(System.Collections.IDictionary properties, System.Runtime.Remoting.Channels.IServerChannelSinkProvider sinkProvider, System.Security.AccessControl.CommonSecurityDescriptor securityDescriptor) { }
        public IpcServerChannel(string portName) { }
        public IpcServerChannel(string name, string portName) { }
        public IpcServerChannel(string name, string portName, System.Runtime.Remoting.Channels.IServerChannelSinkProvider sinkProvider) { }
        public object ChannelData { get { throw null; } }
        public string ChannelName { get { throw null; } }
        public int ChannelPriority { get { throw null; } }
        public bool IsSecured { get { throw null; } set { } }
        public string GetChannelUri() { throw null; }
        public virtual string[] GetUrlsForUri(string objectUri) { throw null; }
        public string Parse(string url, out string objectURI) { objectURI = default(string); throw null; }
        public void StartListening(object data) { }
        public void StopListening(object data) { }
    }
}
namespace System.Runtime.Remoting.Channels.Tcp
{
    public partial class TcpChannel : System.Runtime.Remoting.Channels.IChannel, System.Runtime.Remoting.Channels.IChannelReceiver, System.Runtime.Remoting.Channels.IChannelSender, System.Runtime.Remoting.Channels.ISecurableChannel
    {
        public TcpChannel() { }
        public TcpChannel(System.Collections.IDictionary properties, System.Runtime.Remoting.Channels.IClientChannelSinkProvider clientSinkProvider, System.Runtime.Remoting.Channels.IServerChannelSinkProvider serverSinkProvider) { }
        public TcpChannel(int port) { }
        public object ChannelData { get { throw null; } }
        public string ChannelName { get { throw null; } }
        public int ChannelPriority { get { throw null; } }
        public bool IsSecured { get { throw null; } set { } }
        public System.Runtime.Remoting.Messaging.IMessageSink CreateMessageSink(string url, object remoteChannelData, out string objectURI) { objectURI = default(string); throw null; }
        public string[] GetUrlsForUri(string objectURI) { throw null; }
        public string Parse(string url, out string objectURI) { objectURI = default(string); throw null; }
        public void StartListening(object data) { }
        public void StopListening(object data) { }
    }
    public partial class TcpClientChannel : System.Runtime.Remoting.Channels.IChannel, System.Runtime.Remoting.Channels.IChannelSender, System.Runtime.Remoting.Channels.ISecurableChannel
    {
        public TcpClientChannel() { }
        public TcpClientChannel(System.Collections.IDictionary properties, System.Runtime.Remoting.Channels.IClientChannelSinkProvider sinkProvider) { }
        public TcpClientChannel(string name, System.Runtime.Remoting.Channels.IClientChannelSinkProvider sinkProvider) { }
        public string ChannelName { get { throw null; } }
        public int ChannelPriority { get { throw null; } }
        public bool IsSecured { get { throw null; } set { } }
        public virtual System.Runtime.Remoting.Messaging.IMessageSink CreateMessageSink(string url, object remoteChannelData, out string objectURI) { objectURI = default(string); throw null; }
        public string Parse(string url, out string objectURI) { objectURI = default(string); throw null; }
    }
    public partial class TcpServerChannel : System.Runtime.Remoting.Channels.IChannel, System.Runtime.Remoting.Channels.IChannelReceiver, System.Runtime.Remoting.Channels.ISecurableChannel
    {
        public TcpServerChannel(System.Collections.IDictionary properties, System.Runtime.Remoting.Channels.IServerChannelSinkProvider sinkProvider) { }
        public TcpServerChannel(System.Collections.IDictionary properties, System.Runtime.Remoting.Channels.IServerChannelSinkProvider sinkProvider, System.Runtime.Remoting.Channels.IAuthorizeRemotingConnection authorizeCallback) { }
        public TcpServerChannel(int port) { }
        public TcpServerChannel(string name, int port) { }
        public TcpServerChannel(string name, int port, System.Runtime.Remoting.Channels.IServerChannelSinkProvider sinkProvider) { }
        public object ChannelData { get { throw null; } }
        public string ChannelName { get { throw null; } }
        public int ChannelPriority { get { throw null; } }
        public bool IsSecured { get { throw null; } set { } }
        public string GetChannelUri() { throw null; }
        public virtual string[] GetUrlsForUri(string objectUri) { throw null; }
        public string Parse(string url, out string objectURI) { objectURI = default(string); throw null; }
        public void StartListening(object data) { }
        public void StopListening(object data) { }
    }
}
namespace System.Runtime.Remoting.MetadataServices
{
    public partial class MetaData
    {
        public MetaData() { }
        [System.MonoTODOAttribute("strong name")]
        public static void ConvertCodeSourceFileToAssemblyFile(string codePath, string assemblyPath, string strongNameFilename) { }
        [System.MonoTODOAttribute("strong name")]
        public static void ConvertCodeSourceStreamToAssemblyFile(System.Collections.ArrayList outCodeStreamList, string assemblyPath, string strongNameFilename) { }
        public static void ConvertSchemaStreamToCodeSourceStream(bool clientProxy, string outputDirectory, System.IO.Stream inputStream, System.Collections.ArrayList outCodeStreamList) { }
        public static void ConvertSchemaStreamToCodeSourceStream(bool clientProxy, string outputDirectory, System.IO.Stream inputStream, System.Collections.ArrayList outCodeStreamList, string proxyUrl) { }
        public static void ConvertSchemaStreamToCodeSourceStream(bool clientProxy, string outputDirectory, System.IO.Stream inputStream, System.Collections.ArrayList outCodeStreamList, string proxyUrl, string proxyNamespace) { }
        public static void ConvertTypesToSchemaToFile(System.Runtime.Remoting.MetadataServices.ServiceType[] types, System.Runtime.Remoting.MetadataServices.SdlType sdlType, string path) { }
        public static void ConvertTypesToSchemaToFile(System.Type[] types, System.Runtime.Remoting.MetadataServices.SdlType sdlType, string path) { }
        public static void ConvertTypesToSchemaToStream(System.Runtime.Remoting.MetadataServices.ServiceType[] serviceTypes, System.Runtime.Remoting.MetadataServices.SdlType sdlType, System.IO.Stream outputStream) { }
        public static void ConvertTypesToSchemaToStream(System.Type[] types, System.Runtime.Remoting.MetadataServices.SdlType sdlType, System.IO.Stream outputStream) { }
        public static void RetrieveSchemaFromUrlToFile(string url, string path) { }
        public static void RetrieveSchemaFromUrlToStream(string url, System.IO.Stream outputStream) { }
        public static void SaveStreamToFile(System.IO.Stream inputStream, string path) { }
    }
    public partial class SdlChannelSink : System.Runtime.Remoting.Channels.IChannelSinkBase, System.Runtime.Remoting.Channels.IServerChannelSink
    {
        public SdlChannelSink(System.Runtime.Remoting.Channels.IChannelReceiver receiver, System.Runtime.Remoting.Channels.IServerChannelSink nextSink) { }
        public System.Runtime.Remoting.Channels.IServerChannelSink NextChannelSink { get { throw null; } }
        public System.Collections.IDictionary Properties { get { throw null; } }
        public void AsyncProcessResponse(System.Runtime.Remoting.Channels.IServerResponseChannelSinkStack sinkStack, object state, System.Runtime.Remoting.Messaging.IMessage msg, System.Runtime.Remoting.Channels.ITransportHeaders headers, System.IO.Stream stream) { }
        public System.IO.Stream GetResponseStream(System.Runtime.Remoting.Channels.IServerResponseChannelSinkStack sinkStack, object state, System.Runtime.Remoting.Messaging.IMessage msg, System.Runtime.Remoting.Channels.ITransportHeaders headers) { throw null; }
        public System.Runtime.Remoting.Channels.ServerProcessing ProcessMessage(System.Runtime.Remoting.Channels.IServerChannelSinkStack sinkStack, System.Runtime.Remoting.Messaging.IMessage requestMsg, System.Runtime.Remoting.Channels.ITransportHeaders requestHeaders, System.IO.Stream requestStream, out System.Runtime.Remoting.Messaging.IMessage responseMsg, out System.Runtime.Remoting.Channels.ITransportHeaders responseHeaders, out System.IO.Stream responseStream) { responseMsg = default(System.Runtime.Remoting.Messaging.IMessage); responseHeaders = default(System.Runtime.Remoting.Channels.ITransportHeaders); responseStream = default(System.IO.Stream); throw null; }
    }
    public partial class SdlChannelSinkProvider : System.Runtime.Remoting.Channels.IServerChannelSinkProvider
    {
        public SdlChannelSinkProvider() { }
        public SdlChannelSinkProvider(System.Collections.IDictionary properties, System.Collections.ICollection providerData) { }
        public System.Runtime.Remoting.Channels.IServerChannelSinkProvider Next { get { throw null; } set { } }
        public System.Runtime.Remoting.Channels.IServerChannelSink CreateSink(System.Runtime.Remoting.Channels.IChannelReceiver channel) { throw null; }
        public void GetChannelData(System.Runtime.Remoting.Channels.IChannelDataStore localChannelData) { }
    }
    [System.SerializableAttribute]
    public enum SdlType
    {
        Sdl = 0,
        Wsdl = 1,
    }
    public partial class ServiceType
    {
        public ServiceType(System.Type type) { }
        public ServiceType(System.Type type, string url) { }
        public System.Type ObjectType { get { throw null; } }
        public string Url { get { throw null; } }
    }
    [System.SerializableAttribute]
    public partial class SUDSGeneratorException : System.Exception
    {
        protected SUDSGeneratorException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
    }
    [System.SerializableAttribute]
    public partial class SUDSParserException : System.Exception
    {
        protected SUDSParserException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
    }
}
namespace System.Runtime.Remoting.Services
{
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public abstract partial class RemotingClientProxy : System.ComponentModel.Component
    {
        protected object _tp;
        protected System.Type _type;
        protected string _url;
        protected RemotingClientProxy() { }
        [System.MonoTODOAttribute]
        public bool AllowAutoRedirect { get { throw null; } set { } }
        [System.MonoTODOAttribute]
        public object Cookies { get { throw null; } }
        [System.MonoTODOAttribute]
        public string Domain { get { throw null; } set { } }
        [System.MonoTODOAttribute]
        public bool EnableCookies { get { throw null; } set { } }
        [System.MonoTODOAttribute]
        public string Password { get { throw null; } set { } }
        [System.MonoTODOAttribute]
        public string Path { get { throw null; } set { } }
        [System.MonoTODOAttribute]
        public bool PreAuthenticate { get { throw null; } set { } }
        [System.MonoTODOAttribute]
        public string ProxyName { get { throw null; } set { } }
        [System.MonoTODOAttribute]
        public int ProxyPort { get { throw null; } set { } }
        [System.MonoTODOAttribute]
        public int Timeout { get { throw null; } set { } }
        [System.MonoTODOAttribute]
        public string Url { get { throw null; } set { } }
        [System.MonoTODOAttribute]
        public string UserAgent { get { throw null; } set { } }
        [System.MonoTODOAttribute]
        public string Username { get { throw null; } set { } }
        [System.MonoTODOAttribute]
        protected void ConfigureProxy(System.Type type, string url) { }
        [System.MonoTODOAttribute]
        protected void ConnectProxy() { }
    }
    public partial class RemotingService : System.ComponentModel.Component
    {
        public RemotingService() { }
        [System.MonoTODOAttribute]
        public System.Web.HttpApplicationState Application { get { throw null; } }
        [System.MonoTODOAttribute]
        public System.Web.HttpContext Context { get { throw null; } }
        [System.MonoTODOAttribute]
        public System.Web.HttpServerUtility Server { get { throw null; } }
        [System.MonoTODOAttribute]
        public System.Web.SessionState.HttpSessionState Session { get { throw null; } }
        [System.MonoTODOAttribute]
        public System.Security.Principal.IPrincipal User { get { throw null; } }
    }
}
