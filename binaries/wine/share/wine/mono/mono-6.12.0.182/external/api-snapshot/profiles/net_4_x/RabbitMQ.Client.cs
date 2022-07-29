// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

[assembly:System.Reflection.AssemblyVersionAttribute("4.0.0.0")]
[assembly:System.Diagnostics.DebuggableAttribute(System.Diagnostics.DebuggableAttribute.DebuggingModes.IgnoreSymbolStoreSequencePoints)]
[assembly:System.Reflection.AssemblyCompanyAttribute("Mono development team")]
[assembly:System.Reflection.AssemblyCopyrightAttribute("(c) Various Mono authors")]
[assembly:System.Reflection.AssemblyDefaultAliasAttribute("RabbitMQ.Client.dll")]
[assembly:System.Reflection.AssemblyDescriptionAttribute("RabbitMQ.Client.dll")]
[assembly:System.Reflection.AssemblyFileVersionAttribute("4.6.57.0")]
[assembly:System.Reflection.AssemblyInformationalVersionAttribute("4.6.57.0")]
[assembly:System.Reflection.AssemblyProductAttribute("Mono Common Language Infrastructure")]
[assembly:System.Reflection.AssemblyTitleAttribute("RabbitMQ.Client.dll")]
[assembly:System.Resources.NeutralResourcesLanguageAttribute("en-US")]
[assembly:System.Resources.SatelliteContractVersionAttribute("4.0.0.0")]
[assembly:System.Runtime.CompilerServices.CompilationRelaxationsAttribute(System.Runtime.CompilerServices.CompilationRelaxations.NoStringInterning)]
[assembly:System.Runtime.CompilerServices.RuntimeCompatibilityAttribute(WrapNonExceptionThrows=true)]
[assembly:System.Runtime.InteropServices.ComVisibleAttribute(false)]
namespace RabbitMQ.Client
{
    public partial class AmqpTcpEndpoint
    {
        public const int UseDefaultPort = -1;
        public AmqpTcpEndpoint() { }
        public AmqpTcpEndpoint(RabbitMQ.Client.IProtocol protocol) { }
        public AmqpTcpEndpoint(RabbitMQ.Client.IProtocol protocol, string hostName) { }
        public AmqpTcpEndpoint(RabbitMQ.Client.IProtocol protocol, string hostName, int portOrMinusOne) { }
        public AmqpTcpEndpoint(RabbitMQ.Client.IProtocol protocol, string hostName, int portOrMinusOne, RabbitMQ.Client.SslOption ssl) { }
        public AmqpTcpEndpoint(RabbitMQ.Client.IProtocol protocol, System.Uri uri) { }
        public AmqpTcpEndpoint(RabbitMQ.Client.IProtocol protocol, System.Uri uri, RabbitMQ.Client.SslOption ssl) { }
        public AmqpTcpEndpoint(string hostName) { }
        public AmqpTcpEndpoint(string hostName, int portOrMinusOne) { }
        public AmqpTcpEndpoint(System.Uri uri) { }
        public string HostName { get { throw null; } set { } }
        public int Port { get { throw null; } set { } }
        public RabbitMQ.Client.IProtocol Protocol { get { throw null; } set { } }
        public RabbitMQ.Client.SslOption Ssl { get { throw null; } set { } }
        public override bool Equals(object obj) { throw null; }
        public override int GetHashCode() { throw null; }
        public static RabbitMQ.Client.AmqpTcpEndpoint Parse(RabbitMQ.Client.IProtocol protocol, string address) { throw null; }
        public static RabbitMQ.Client.AmqpTcpEndpoint[] ParseMultiple(RabbitMQ.Client.IProtocol protocol, string addresses) { throw null; }
        public override string ToString() { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public partial struct AmqpTimestamp
    {
        private int _dummyPrimitive;
        public AmqpTimestamp(long unixTime) { throw null; }
        public long UnixTime { get { throw null; } }
        public override string ToString() { throw null; }
    }
    public partial class AmqpVersion
    {
        public AmqpVersion(int major, int minor) { }
        public int Major { get { throw null; } }
        public int Minor { get { throw null; } }
        public override bool Equals(object other) { throw null; }
        public override int GetHashCode() { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class BasicGetResult
    {
        public BasicGetResult(ulong deliveryTag, bool redelivered, string exchange, string routingKey, uint messageCount, RabbitMQ.Client.IBasicProperties basicProperties, byte[] body) { }
        public RabbitMQ.Client.IBasicProperties BasicProperties { get { throw null; } }
        public byte[] Body { get { throw null; } }
        public ulong DeliveryTag { get { throw null; } }
        public string Exchange { get { throw null; } }
        public uint MessageCount { get { throw null; } }
        public bool Redelivered { get { throw null; } }
        public string RoutingKey { get { throw null; } }
    }
    public partial class BinaryTableValue
    {
        public BinaryTableValue() { }
        public BinaryTableValue(byte[] bytes) { }
        public byte[] Bytes { get { throw null; } set { } }
    }
    public partial class ConnectionFactory
    {
        public System.Collections.IDictionary ClientProperties;
        public const ushort DefaultChannelMax = (ushort)0;
        public const uint DefaultFrameMax = (uint)0;
        public const ushort DefaultHeartbeat = (ushort)0;
        public const string DefaultPass = "guest";
        public const string DefaultUser = "guest";
        public const string DefaultVHost = "/";
        public string HostName;
        public string Password;
        public int Port;
        public RabbitMQ.Client.IProtocol Protocol;
        public ushort RequestedChannelMax;
        public uint RequestedFrameMax;
        public ushort RequestedHeartbeat;
        public RabbitMQ.Client.SslOption Ssl;
        public string UserName;
        public string VirtualHost;
        public ConnectionFactory() { }
        public string Address { get { throw null; } set { } }
        public RabbitMQ.Client.AmqpTcpEndpoint Endpoint { get { throw null; } set { } }
        public virtual RabbitMQ.Client.IConnection CreateConnection() { throw null; }
        public virtual RabbitMQ.Client.IConnection CreateConnection(int maxRedirects) { throw null; }
        protected virtual RabbitMQ.Client.IConnection CreateConnection(int maxRedirects, System.Collections.IDictionary connectionAttempts, System.Collections.IDictionary connectionErrors, params RabbitMQ.Client.AmqpTcpEndpoint[] endpoints) { throw null; }
        protected virtual RabbitMQ.Client.IConnection FollowRedirectChain(int maxRedirects, System.Collections.IDictionary connectionAttempts, System.Collections.IDictionary connectionErrors, ref RabbitMQ.Client.AmqpTcpEndpoint[] mostRecentKnownHosts, RabbitMQ.Client.AmqpTcpEndpoint endpoint) { throw null; }
    }
    public partial class DefaultBasicConsumer : RabbitMQ.Client.IBasicConsumer
    {
        public DefaultBasicConsumer() { }
        public DefaultBasicConsumer(RabbitMQ.Client.IModel model) { }
        public string ConsumerTag { get { throw null; } set { } }
        public bool IsRunning { get { throw null; } }
        public RabbitMQ.Client.IModel Model { get { throw null; } set { } }
        public RabbitMQ.Client.ShutdownEventArgs ShutdownReason { get { throw null; } }
        public virtual void HandleBasicCancelOk(string consumerTag) { }
        public virtual void HandleBasicConsumeOk(string consumerTag) { }
        public virtual void HandleBasicDeliver(string consumerTag, ulong deliveryTag, bool redelivered, string exchange, string routingKey, RabbitMQ.Client.IBasicProperties properties, byte[] body) { }
        public virtual void HandleModelShutdown(RabbitMQ.Client.IModel model, RabbitMQ.Client.ShutdownEventArgs reason) { }
        public virtual void OnCancel() { }
    }
    public partial class ExchangeType
    {
        internal ExchangeType() { }
        public const string Direct = "direct";
        public const string Fanout = "fanout";
        public const string Topic = "topic";
        public static System.Collections.ICollection All() { throw null; }
    }
    public partial interface IBasicConsumer
    {
        RabbitMQ.Client.IModel Model { get; }
        void HandleBasicCancelOk(string consumerTag);
        void HandleBasicConsumeOk(string consumerTag);
        void HandleBasicDeliver(string consumerTag, ulong deliveryTag, bool redelivered, string exchange, string routingKey, RabbitMQ.Client.IBasicProperties properties, byte[] body);
        void HandleModelShutdown(RabbitMQ.Client.IModel model, RabbitMQ.Client.ShutdownEventArgs reason);
    }
    public partial interface IBasicProperties : RabbitMQ.Client.IContentHeader, System.ICloneable
    {
        string AppId { get; set; }
        string ClusterId { get; set; }
        string ContentEncoding { get; set; }
        string ContentType { get; set; }
        string CorrelationId { get; set; }
        byte DeliveryMode { get; set; }
        string Expiration { get; set; }
        System.Collections.IDictionary Headers { get; set; }
        string MessageId { get; set; }
        byte Priority { get; set; }
        string ReplyTo { get; set; }
        RabbitMQ.Client.PublicationAddress ReplyToAddress { get; set; }
        RabbitMQ.Client.AmqpTimestamp Timestamp { get; set; }
        string Type { get; set; }
        string UserId { get; set; }
        void ClearAppId();
        void ClearClusterId();
        void ClearContentEncoding();
        void ClearContentType();
        void ClearCorrelationId();
        void ClearDeliveryMode();
        void ClearExpiration();
        void ClearHeaders();
        void ClearMessageId();
        void ClearPriority();
        void ClearReplyTo();
        void ClearTimestamp();
        void ClearType();
        void ClearUserId();
        bool IsAppIdPresent();
        bool IsClusterIdPresent();
        bool IsContentEncodingPresent();
        bool IsContentTypePresent();
        bool IsCorrelationIdPresent();
        bool IsDeliveryModePresent();
        bool IsExpirationPresent();
        bool IsHeadersPresent();
        bool IsMessageIdPresent();
        bool IsPriorityPresent();
        bool IsReplyToPresent();
        bool IsTimestampPresent();
        bool IsTypePresent();
        bool IsUserIdPresent();
        void SetPersistent(bool persistent);
    }
    public partial interface IConnection : System.IDisposable
    {
        bool AutoClose { get; set; }
        ushort ChannelMax { get; }
        System.Collections.IDictionary ClientProperties { get; }
        RabbitMQ.Client.ShutdownEventArgs CloseReason { get; }
        RabbitMQ.Client.AmqpTcpEndpoint Endpoint { get; }
        uint FrameMax { get; }
        ushort Heartbeat { get; }
        bool IsOpen { get; }
        RabbitMQ.Client.AmqpTcpEndpoint[] KnownHosts { get; }
        RabbitMQ.Client.IProtocol Protocol { get; }
        System.Collections.IDictionary ServerProperties { get; }
        System.Collections.IList ShutdownReport { get; }
        event RabbitMQ.Client.Events.CallbackExceptionEventHandler CallbackException;
        event RabbitMQ.Client.Events.ConnectionShutdownEventHandler ConnectionShutdown;
        void Abort();
        void Abort(int timeout);
        void Abort(ushort reasonCode, string reasonText);
        void Abort(ushort reasonCode, string reasonText, int timeout);
        void Close();
        void Close(int timeout);
        void Close(ushort reasonCode, string reasonText);
        void Close(ushort reasonCode, string reasonText, int timeout);
        RabbitMQ.Client.IModel CreateModel();
    }
    public partial interface IContentHeader : System.ICloneable
    {
        int ProtocolClassId { get; }
        string ProtocolClassName { get; }
    }
    public partial interface IFileProperties : RabbitMQ.Client.IContentHeader, System.ICloneable
    {
        string ClusterId { get; set; }
        string ContentEncoding { get; set; }
        string ContentType { get; set; }
        string Filename { get; set; }
        System.Collections.IDictionary Headers { get; set; }
        string MessageId { get; set; }
        byte Priority { get; set; }
        string ReplyTo { get; set; }
        RabbitMQ.Client.AmqpTimestamp Timestamp { get; set; }
        void ClearClusterId();
        void ClearContentEncoding();
        void ClearContentType();
        void ClearFilename();
        void ClearHeaders();
        void ClearMessageId();
        void ClearPriority();
        void ClearReplyTo();
        void ClearTimestamp();
        bool IsClusterIdPresent();
        bool IsContentEncodingPresent();
        bool IsContentTypePresent();
        bool IsFilenamePresent();
        bool IsHeadersPresent();
        bool IsMessageIdPresent();
        bool IsPriorityPresent();
        bool IsReplyToPresent();
        bool IsTimestampPresent();
    }
    public partial interface IMethod
    {
        int ProtocolClassId { get; }
        int ProtocolMethodId { get; }
        string ProtocolMethodName { get; }
    }
    public partial interface IModel : System.IDisposable
    {
        RabbitMQ.Client.ShutdownEventArgs CloseReason { get; }
        bool IsOpen { get; }
        event RabbitMQ.Client.Events.BasicReturnEventHandler BasicReturn;
        event RabbitMQ.Client.Events.CallbackExceptionEventHandler CallbackException;
        event RabbitMQ.Client.Events.ModelShutdownEventHandler ModelShutdown;
        [RabbitMQ.Client.Apigen.Attributes.AmqpMethodDoNotImplementAttribute(null)]
        void Abort();
        [RabbitMQ.Client.Apigen.Attributes.AmqpMethodDoNotImplementAttribute(null)]
        void Abort(ushort replyCode, string replyText);
        void BasicAck(ulong deliveryTag, bool multiple);
        [RabbitMQ.Client.Apigen.Attributes.AmqpMethodDoNotImplementAttribute(null)]
        void BasicCancel(string consumerTag);
        [RabbitMQ.Client.Apigen.Attributes.AmqpMethodDoNotImplementAttribute(null)]
        string BasicConsume(string queue, bool noAck, System.Collections.IDictionary filter, RabbitMQ.Client.IBasicConsumer consumer);
        [RabbitMQ.Client.Apigen.Attributes.AmqpMethodDoNotImplementAttribute(null)]
        string BasicConsume(string queue, bool noAck, string consumerTag, bool noLocal, bool exclusive, System.Collections.IDictionary filter, RabbitMQ.Client.IBasicConsumer consumer);
        [RabbitMQ.Client.Apigen.Attributes.AmqpMethodDoNotImplementAttribute(null)]
        string BasicConsume(string queue, bool noAck, string consumerTag, System.Collections.IDictionary filter, RabbitMQ.Client.IBasicConsumer consumer);
        [RabbitMQ.Client.Apigen.Attributes.AmqpMethodDoNotImplementAttribute(null)]
        string BasicConsume(string queue, System.Collections.IDictionary filter, RabbitMQ.Client.IBasicConsumer consumer);
        [RabbitMQ.Client.Apigen.Attributes.AmqpMethodDoNotImplementAttribute(null)]
        RabbitMQ.Client.BasicGetResult BasicGet(string queue, bool noAck);
        [RabbitMQ.Client.Apigen.Attributes.AmqpMethodDoNotImplementAttribute(null)]
        void BasicPublish(RabbitMQ.Client.PublicationAddress addr, RabbitMQ.Client.IBasicProperties basicProperties, byte[] body);
        [RabbitMQ.Client.Apigen.Attributes.AmqpMethodDoNotImplementAttribute(null)]
        void BasicPublish(string exchange, string routingKey, RabbitMQ.Client.IBasicProperties basicProperties, byte[] body);
        [RabbitMQ.Client.Apigen.Attributes.AmqpMethodDoNotImplementAttribute(null)]
        void BasicPublish(string exchange, string routingKey, bool mandatory, bool immediate, RabbitMQ.Client.IBasicProperties basicProperties, byte[] body);
        void BasicQos(uint prefetchSize, ushort prefetchCount, bool global);
        void BasicRecover(bool requeue);
        void BasicReject(ulong deliveryTag, bool requeue);
        [RabbitMQ.Client.Apigen.Attributes.AmqpFieldMappingAttribute(null, "active")]void ChannelFlow(bool active);
        [RabbitMQ.Client.Apigen.Attributes.AmqpMethodDoNotImplementAttribute(null)]
        void Close();
        [RabbitMQ.Client.Apigen.Attributes.AmqpMethodDoNotImplementAttribute(null)]
        void Close(ushort replyCode, string replyText);
        [RabbitMQ.Client.Apigen.Attributes.AmqpContentHeaderFactoryAttribute("basic")]
        RabbitMQ.Client.IBasicProperties CreateBasicProperties();
        [RabbitMQ.Client.Apigen.Attributes.AmqpContentHeaderFactoryAttribute("file")]
        RabbitMQ.Client.IFileProperties CreateFileProperties();
        [RabbitMQ.Client.Apigen.Attributes.AmqpContentHeaderFactoryAttribute("stream")]
        RabbitMQ.Client.IStreamProperties CreateStreamProperties();
        void DtxSelect();
        void DtxStart(string dtxIdentifier);
        [RabbitMQ.Client.Apigen.Attributes.AmqpMethodDoNotImplementAttribute(null)]
        void ExchangeDeclare(string exchange, string type);
        [RabbitMQ.Client.Apigen.Attributes.AmqpMethodDoNotImplementAttribute(null)]
        void ExchangeDeclare(string exchange, string type, bool durable);
        void ExchangeDeclare(string exchange, string type, bool passive, bool durable, bool autoDelete, bool @internal, [RabbitMQ.Client.Apigen.Attributes.AmqpNowaitArgumentAttribute(null)]bool nowait, System.Collections.IDictionary arguments);
        void ExchangeDelete(string exchange, bool ifUnused, [RabbitMQ.Client.Apigen.Attributes.AmqpNowaitArgumentAttribute(null)]bool nowait);
        void QueueBind(string queue, string exchange, string routingKey, [RabbitMQ.Client.Apigen.Attributes.AmqpNowaitArgumentAttribute(null)]bool nowait, System.Collections.IDictionary arguments);
        [RabbitMQ.Client.Apigen.Attributes.AmqpMethodDoNotImplementAttribute(null)]
        string QueueDeclare();
        [RabbitMQ.Client.Apigen.Attributes.AmqpMethodDoNotImplementAttribute(null)]
        string QueueDeclare(string queue);
        [RabbitMQ.Client.Apigen.Attributes.AmqpMethodDoNotImplementAttribute(null)]
        string QueueDeclare(string queue, bool durable);
        [RabbitMQ.Client.Apigen.Attributes.AmqpFieldMappingAttribute(null, "queue")]string QueueDeclare(string queue, bool passive, bool durable, bool exclusive, bool autoDelete, [RabbitMQ.Client.Apigen.Attributes.AmqpNowaitArgumentAttribute(null)]bool nowait, System.Collections.IDictionary arguments);
        [RabbitMQ.Client.Apigen.Attributes.AmqpFieldMappingAttribute(null, "messageCount")]uint QueueDelete(string queue, bool ifUnused, bool ifEmpty, [RabbitMQ.Client.Apigen.Attributes.AmqpNowaitArgumentAttribute(null, "0xFFFFFFFF")]bool nowait);
        [RabbitMQ.Client.Apigen.Attributes.AmqpFieldMappingAttribute(null, "messageCount")]uint QueuePurge(string queue, [RabbitMQ.Client.Apigen.Attributes.AmqpNowaitArgumentAttribute(null, "0xFFFFFFFF")]bool nowait);
        [RabbitMQ.Client.Apigen.Attributes.AmqpUnsupportedAttribute("RabbitMQ.Client.Framing.v0_8qpid")]
        void QueueUnbind(string queue, string exchange, string routingKey, System.Collections.IDictionary arguments);
        void TxCommit();
        void TxRollback();
        void TxSelect();
    }
    public partial interface IProtocol
    {
        string ApiName { get; }
        int DefaultPort { get; }
        int MajorVersion { get; }
        int MinorVersion { get; }
        RabbitMQ.Client.IConnection CreateConnection(RabbitMQ.Client.ConnectionFactory factory, bool insist, RabbitMQ.Client.Impl.IFrameHandler frameHandler);
        RabbitMQ.Client.Impl.IFrameHandler CreateFrameHandler(RabbitMQ.Client.AmqpTcpEndpoint endpoint);
        RabbitMQ.Client.IModel CreateModel(RabbitMQ.Client.Impl.ISession session);
    }
    public partial interface IStreamProperties : RabbitMQ.Client.IContentHeader, System.ICloneable
    {
        string ContentEncoding { get; set; }
        string ContentType { get; set; }
        System.Collections.IDictionary Headers { get; set; }
        byte Priority { get; set; }
        RabbitMQ.Client.AmqpTimestamp Timestamp { get; set; }
        void ClearContentEncoding();
        void ClearContentType();
        void ClearHeaders();
        void ClearPriority();
        void ClearTimestamp();
        bool IsContentEncodingPresent();
        bool IsContentTypePresent();
        bool IsHeadersPresent();
        bool IsPriorityPresent();
        bool IsTimestampPresent();
    }
    public partial class Protocols
    {
        internal Protocols() { }
        public static readonly string DefaultAppSettingsKey;
        public static readonly string EnvironmentVariable;
        public static RabbitMQ.Client.IProtocol AMQP_0_8 { get { throw null; } }
        public static RabbitMQ.Client.IProtocol AMQP_0_8_QPID { get { throw null; } }
        public static RabbitMQ.Client.IProtocol AMQP_0_9 { get { throw null; } }
        public static RabbitMQ.Client.IProtocol DefaultProtocol { get { throw null; } }
        public static RabbitMQ.Client.IProtocol FromConfiguration() { throw null; }
        public static RabbitMQ.Client.IProtocol FromConfiguration(string appSettingsKey) { throw null; }
        public static RabbitMQ.Client.IProtocol FromEnvironment() { throw null; }
        public static RabbitMQ.Client.IProtocol FromEnvironment(string appSettingsKey) { throw null; }
        public static RabbitMQ.Client.IProtocol FromEnvironmentVariable() { throw null; }
        public static RabbitMQ.Client.IProtocol Lookup(string name) { throw null; }
        public static RabbitMQ.Client.IProtocol SafeLookup(string name) { throw null; }
    }
    public partial class PublicationAddress
    {
        public static readonly System.Text.RegularExpressions.Regex PSEUDO_URI_PARSER;
        public PublicationAddress(string exchangeType, string exchangeName, string routingKey) { }
        public string ExchangeName { get { throw null; } }
        public string ExchangeType { get { throw null; } }
        public string RoutingKey { get { throw null; } }
        public static RabbitMQ.Client.PublicationAddress Parse(string uriLikeString) { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class QueueingBasicConsumer : RabbitMQ.Client.DefaultBasicConsumer
    {
        protected RabbitMQ.Util.SharedQueue m_queue;
        public QueueingBasicConsumer() { }
        public QueueingBasicConsumer(RabbitMQ.Client.IModel model) { }
        public QueueingBasicConsumer(RabbitMQ.Client.IModel model, RabbitMQ.Util.SharedQueue queue) { }
        public RabbitMQ.Util.SharedQueue Queue { get { throw null; } }
        public override void HandleBasicDeliver(string consumerTag, ulong deliveryTag, bool redelivered, string exchange, string routingKey, RabbitMQ.Client.IBasicProperties properties, byte[] body) { }
        public override void OnCancel() { }
    }
    public partial class ShutdownEventArgs : System.EventArgs
    {
        public ShutdownEventArgs(RabbitMQ.Client.ShutdownInitiator initiator, ushort replyCode, string replyText) { }
        public ShutdownEventArgs(RabbitMQ.Client.ShutdownInitiator initiator, ushort replyCode, string replyText, object cause) { }
        public ShutdownEventArgs(RabbitMQ.Client.ShutdownInitiator initiator, ushort replyCode, string replyText, ushort classId, ushort methodId) { }
        public ShutdownEventArgs(RabbitMQ.Client.ShutdownInitiator initiator, ushort replyCode, string replyText, ushort classId, ushort methodId, object cause) { }
        public object Cause { get { throw null; } }
        public ushort ClassId { get { throw null; } }
        public RabbitMQ.Client.ShutdownInitiator Initiator { get { throw null; } }
        public ushort MethodId { get { throw null; } }
        public ushort ReplyCode { get { throw null; } }
        public string ReplyText { get { throw null; } }
        public override string ToString() { throw null; }
    }
    public enum ShutdownInitiator
    {
        Application = 0,
        Library = 1,
        Peer = 2,
    }
    public partial class ShutdownReportEntry
    {
        public string m_description;
        public System.Exception m_ex;
        public ShutdownReportEntry(string description, System.Exception ex) { }
        public string Description { get { throw null; } }
        public System.Exception Exception { get { throw null; } }
        public override string ToString() { throw null; }
    }
    public partial class SslHelper
    {
        internal SslHelper() { }
        public static System.IO.Stream TcpUpgrade(System.IO.Stream tcpStream, RabbitMQ.Client.SslOption sslOption) { throw null; }
    }
    public partial class SslOption
    {
        public SslOption() { }
        public SslOption(string serverName) { }
        public SslOption(string serverName, string certPath, bool enabled) { }
        public System.Net.Security.SslPolicyErrors AcceptablePolicyErrors { get { throw null; } set { } }
        public string CertPassphrase { get { throw null; } set { } }
        public string CertPath { get { throw null; } set { } }
        public System.Security.Cryptography.X509Certificates.X509CertificateCollection Certs { get { throw null; } }
        public bool Enabled { get { throw null; } set { } }
        public string ServerName { get { throw null; } set { } }
        public System.Security.Authentication.SslProtocols Version { get { throw null; } set { } }
    }
}
namespace RabbitMQ.Client.Apigen.Attributes
{
    public abstract partial class AmqpApigenAttribute : System.Attribute
    {
        public string m_namespaceName;
        public AmqpApigenAttribute(string namespaceName) { }
    }
    [System.AttributeUsageAttribute(System.AttributeTargets.All, AllowMultiple=true)]
    public partial class AmqpAsynchronousHandlerAttribute : RabbitMQ.Client.Apigen.Attributes.AmqpApigenAttribute
    {
        public AmqpAsynchronousHandlerAttribute(string namespaceName) : base (default(string)) { }
    }
    public partial class AmqpContentBodyMappingAttribute : System.Attribute
    {
        public AmqpContentBodyMappingAttribute() { }
    }
    public partial class AmqpContentHeaderFactoryAttribute : System.Attribute
    {
        public string m_contentClass;
        public AmqpContentHeaderFactoryAttribute(string contentClass) { }
    }
    public partial class AmqpContentHeaderMappingAttribute : System.Attribute
    {
        public AmqpContentHeaderMappingAttribute() { }
    }
    [System.AttributeUsageAttribute(System.AttributeTargets.All, AllowMultiple=true)]
    public partial class AmqpFieldMappingAttribute : RabbitMQ.Client.Apigen.Attributes.AmqpApigenAttribute
    {
        public string m_fieldName;
        public AmqpFieldMappingAttribute(string namespaceName, string fieldName) : base (default(string)) { }
    }
    public partial class AmqpForceOneWayAttribute : System.Attribute
    {
        public AmqpForceOneWayAttribute() { }
    }
    [System.AttributeUsageAttribute(System.AttributeTargets.All, AllowMultiple=true)]
    public partial class AmqpMethodDoNotImplementAttribute : RabbitMQ.Client.Apigen.Attributes.AmqpApigenAttribute
    {
        public AmqpMethodDoNotImplementAttribute(string namespaceName) : base (default(string)) { }
    }
    [System.AttributeUsageAttribute(System.AttributeTargets.All, AllowMultiple=true)]
    public partial class AmqpMethodMappingAttribute : RabbitMQ.Client.Apigen.Attributes.AmqpApigenAttribute
    {
        public string m_className;
        public string m_methodName;
        public AmqpMethodMappingAttribute(string namespaceName, string className, string methodName) : base (default(string)) { }
    }
    [System.AttributeUsageAttribute(System.AttributeTargets.All, AllowMultiple=true)]
    public partial class AmqpNowaitArgumentAttribute : RabbitMQ.Client.Apigen.Attributes.AmqpApigenAttribute
    {
        public string m_replacementExpression;
        public AmqpNowaitArgumentAttribute(string namespaceName) : base (default(string)) { }
        public AmqpNowaitArgumentAttribute(string namespaceName, string replacementExpression) : base (default(string)) { }
    }
    [System.AttributeUsageAttribute(System.AttributeTargets.All, AllowMultiple=true)]
    public partial class AmqpUnsupportedAttribute : RabbitMQ.Client.Apigen.Attributes.AmqpApigenAttribute
    {
        public AmqpUnsupportedAttribute(string namespaceName) : base (default(string)) { }
    }
}
namespace RabbitMQ.Client.Content
{
    public partial class BasicMessageBuilder : RabbitMQ.Client.Content.IMessageBuilder
    {
        public const int DefaultAccumulatorSize = 1024;
        protected System.IO.MemoryStream m_accumulator;
        protected RabbitMQ.Client.IBasicProperties m_properties;
        protected RabbitMQ.Util.NetworkBinaryWriter m_writer;
        public BasicMessageBuilder(RabbitMQ.Client.IModel model) { }
        public BasicMessageBuilder(RabbitMQ.Client.IModel model, int initialAccumulatorSize) { }
        public System.IO.Stream BodyStream { get { throw null; } }
        public System.Collections.IDictionary Headers { get { throw null; } }
        public RabbitMQ.Client.IBasicProperties Properties { get { throw null; } }
        public RabbitMQ.Util.NetworkBinaryWriter Writer { get { throw null; } }
        public virtual byte[] GetContentBody() { throw null; }
        public virtual RabbitMQ.Client.IContentHeader GetContentHeader() { throw null; }
        public virtual string GetDefaultContentType() { throw null; }
        public RabbitMQ.Client.Content.IMessageBuilder RawWrite(byte b) { throw null; }
        public RabbitMQ.Client.Content.IMessageBuilder RawWrite(byte[] bytes) { throw null; }
        public RabbitMQ.Client.Content.IMessageBuilder RawWrite(byte[] bytes, int offset, int length) { throw null; }
    }
    public partial class BasicMessageReader : RabbitMQ.Client.Content.IMessageReader
    {
        protected byte[] m_body;
        protected RabbitMQ.Client.IBasicProperties m_properties;
        protected RabbitMQ.Util.NetworkBinaryReader m_reader;
        protected System.IO.MemoryStream m_stream;
        public BasicMessageReader(RabbitMQ.Client.IBasicProperties properties, byte[] body) { }
        public byte[] BodyBytes { get { throw null; } }
        public System.IO.Stream BodyStream { get { throw null; } }
        public System.Collections.IDictionary Headers { get { throw null; } }
        public RabbitMQ.Client.IBasicProperties Properties { get { throw null; } }
        public RabbitMQ.Util.NetworkBinaryReader Reader { get { throw null; } }
        public int RawRead() { throw null; }
        public int RawRead(byte[] target, int offset, int length) { throw null; }
    }
    public partial class BytesMessageBuilder : RabbitMQ.Client.Content.BasicMessageBuilder, RabbitMQ.Client.Content.IBytesMessageBuilder, RabbitMQ.Client.Content.IMessageBuilder
    {
        public static readonly string MimeType;
        public BytesMessageBuilder(RabbitMQ.Client.IModel model) : base (default(RabbitMQ.Client.IModel)) { }
        public BytesMessageBuilder(RabbitMQ.Client.IModel model, int initialAccumulatorSize) : base (default(RabbitMQ.Client.IModel)) { }
        public override string GetDefaultContentType() { throw null; }
        public RabbitMQ.Client.Content.IBytesMessageBuilder Write(byte[] source, int offset, int count) { throw null; }
        public RabbitMQ.Client.Content.IBytesMessageBuilder WriteByte(byte value) { throw null; }
        public RabbitMQ.Client.Content.IBytesMessageBuilder WriteBytes(byte[] source) { throw null; }
        public RabbitMQ.Client.Content.IBytesMessageBuilder WriteChar(char value) { throw null; }
        public RabbitMQ.Client.Content.IBytesMessageBuilder WriteDouble(double value) { throw null; }
        public RabbitMQ.Client.Content.IBytesMessageBuilder WriteInt16(short value) { throw null; }
        public RabbitMQ.Client.Content.IBytesMessageBuilder WriteInt32(int value) { throw null; }
        public RabbitMQ.Client.Content.IBytesMessageBuilder WriteInt64(long value) { throw null; }
        public RabbitMQ.Client.Content.IBytesMessageBuilder WriteSingle(float value) { throw null; }
        public RabbitMQ.Client.Content.IBytesMessageBuilder WriteString(string value) { throw null; }
    }
    public partial class BytesMessageReader : RabbitMQ.Client.Content.BasicMessageReader, RabbitMQ.Client.Content.IBytesMessageReader, RabbitMQ.Client.Content.IMessageReader
    {
        public static readonly string MimeType;
        public BytesMessageReader(RabbitMQ.Client.IBasicProperties properties, byte[] payload) : base (default(RabbitMQ.Client.IBasicProperties), default(byte[])) { }
        public int Read(byte[] target, int offset, int count) { throw null; }
        public byte ReadByte() { throw null; }
        public byte[] ReadBytes(int count) { throw null; }
        public char ReadChar() { throw null; }
        public double ReadDouble() { throw null; }
        public short ReadInt16() { throw null; }
        public int ReadInt32() { throw null; }
        public long ReadInt64() { throw null; }
        public float ReadSingle() { throw null; }
        public string ReadString() { throw null; }
    }
    public partial class BytesWireFormatting
    {
        public BytesWireFormatting() { }
        public static int Read(RabbitMQ.Util.NetworkBinaryReader reader, byte[] target, int offset, int count) { throw null; }
        public static byte ReadByte(RabbitMQ.Util.NetworkBinaryReader reader) { throw null; }
        public static byte[] ReadBytes(RabbitMQ.Util.NetworkBinaryReader reader, int count) { throw null; }
        public static char ReadChar(RabbitMQ.Util.NetworkBinaryReader reader) { throw null; }
        public static double ReadDouble(RabbitMQ.Util.NetworkBinaryReader reader) { throw null; }
        public static short ReadInt16(RabbitMQ.Util.NetworkBinaryReader reader) { throw null; }
        public static int ReadInt32(RabbitMQ.Util.NetworkBinaryReader reader) { throw null; }
        public static long ReadInt64(RabbitMQ.Util.NetworkBinaryReader reader) { throw null; }
        public static float ReadSingle(RabbitMQ.Util.NetworkBinaryReader reader) { throw null; }
        public static string ReadString(RabbitMQ.Util.NetworkBinaryReader reader) { throw null; }
        public static void Write(RabbitMQ.Util.NetworkBinaryWriter writer, byte[] source, int offset, int count) { }
        public static void WriteByte(RabbitMQ.Util.NetworkBinaryWriter writer, byte value) { }
        public static void WriteBytes(RabbitMQ.Util.NetworkBinaryWriter writer, byte[] source) { }
        public static void WriteChar(RabbitMQ.Util.NetworkBinaryWriter writer, char value) { }
        public static void WriteDouble(RabbitMQ.Util.NetworkBinaryWriter writer, double value) { }
        public static void WriteInt16(RabbitMQ.Util.NetworkBinaryWriter writer, short value) { }
        public static void WriteInt32(RabbitMQ.Util.NetworkBinaryWriter writer, int value) { }
        public static void WriteInt64(RabbitMQ.Util.NetworkBinaryWriter writer, long value) { }
        public static void WriteSingle(RabbitMQ.Util.NetworkBinaryWriter writer, float value) { }
        public static void WriteString(RabbitMQ.Util.NetworkBinaryWriter writer, string value) { }
    }
    public partial interface IBytesMessageBuilder : RabbitMQ.Client.Content.IMessageBuilder
    {
        RabbitMQ.Client.Content.IBytesMessageBuilder Write(byte[] source, int offset, int count);
        RabbitMQ.Client.Content.IBytesMessageBuilder WriteByte(byte value);
        RabbitMQ.Client.Content.IBytesMessageBuilder WriteBytes(byte[] source);
        RabbitMQ.Client.Content.IBytesMessageBuilder WriteChar(char value);
        RabbitMQ.Client.Content.IBytesMessageBuilder WriteDouble(double value);
        RabbitMQ.Client.Content.IBytesMessageBuilder WriteInt16(short value);
        RabbitMQ.Client.Content.IBytesMessageBuilder WriteInt32(int value);
        RabbitMQ.Client.Content.IBytesMessageBuilder WriteInt64(long value);
        RabbitMQ.Client.Content.IBytesMessageBuilder WriteSingle(float value);
        RabbitMQ.Client.Content.IBytesMessageBuilder WriteString(string value);
    }
    public partial interface IBytesMessageReader : RabbitMQ.Client.Content.IMessageReader
    {
        int Read(byte[] target, int offset, int count);
        byte ReadByte();
        byte[] ReadBytes(int count);
        char ReadChar();
        double ReadDouble();
        short ReadInt16();
        int ReadInt32();
        long ReadInt64();
        float ReadSingle();
        string ReadString();
    }
    public partial interface IMapMessageBuilder : RabbitMQ.Client.Content.IMessageBuilder
    {
        System.Collections.IDictionary Body { get; }
    }
    public partial interface IMapMessageReader : RabbitMQ.Client.Content.IMessageReader
    {
        System.Collections.IDictionary Body { get; }
    }
    public partial interface IMessageBuilder
    {
        System.IO.Stream BodyStream { get; }
        System.Collections.IDictionary Headers { get; }
        byte[] GetContentBody();
        RabbitMQ.Client.IContentHeader GetContentHeader();
        string GetDefaultContentType();
        RabbitMQ.Client.Content.IMessageBuilder RawWrite(byte b);
        RabbitMQ.Client.Content.IMessageBuilder RawWrite(byte[] bytes);
        RabbitMQ.Client.Content.IMessageBuilder RawWrite(byte[] bytes, int offset, int length);
    }
    public partial interface IMessageReader
    {
        byte[] BodyBytes { get; }
        System.IO.Stream BodyStream { get; }
        System.Collections.IDictionary Headers { get; }
        int RawRead();
        int RawRead(byte[] target, int offset, int length);
    }
    public partial interface IStreamMessageBuilder : RabbitMQ.Client.Content.IMessageBuilder
    {
        RabbitMQ.Client.Content.IStreamMessageBuilder WriteBool(bool value);
        RabbitMQ.Client.Content.IStreamMessageBuilder WriteByte(byte value);
        RabbitMQ.Client.Content.IStreamMessageBuilder WriteBytes(byte[] source);
        RabbitMQ.Client.Content.IStreamMessageBuilder WriteBytes(byte[] source, int offset, int count);
        RabbitMQ.Client.Content.IStreamMessageBuilder WriteChar(char value);
        RabbitMQ.Client.Content.IStreamMessageBuilder WriteDouble(double value);
        RabbitMQ.Client.Content.IStreamMessageBuilder WriteInt16(short value);
        RabbitMQ.Client.Content.IStreamMessageBuilder WriteInt32(int value);
        RabbitMQ.Client.Content.IStreamMessageBuilder WriteInt64(long value);
        RabbitMQ.Client.Content.IStreamMessageBuilder WriteObject(object value);
        RabbitMQ.Client.Content.IStreamMessageBuilder WriteObjects(params object[] values);
        RabbitMQ.Client.Content.IStreamMessageBuilder WriteSingle(float value);
        RabbitMQ.Client.Content.IStreamMessageBuilder WriteString(string value);
    }
    public partial interface IStreamMessageReader : RabbitMQ.Client.Content.IMessageReader
    {
        bool ReadBool();
        byte ReadByte();
        byte[] ReadBytes();
        char ReadChar();
        double ReadDouble();
        short ReadInt16();
        int ReadInt32();
        long ReadInt64();
        object ReadObject();
        object[] ReadObjects();
        float ReadSingle();
        string ReadString();
    }
    public partial class MapMessageBuilder : RabbitMQ.Client.Content.BasicMessageBuilder, RabbitMQ.Client.Content.IMapMessageBuilder, RabbitMQ.Client.Content.IMessageBuilder
    {
        public static readonly string MimeType;
        protected System.Collections.IDictionary m_table;
        public MapMessageBuilder(RabbitMQ.Client.IModel model) : base (default(RabbitMQ.Client.IModel)) { }
        public MapMessageBuilder(RabbitMQ.Client.IModel model, int initialAccumulatorSize) : base (default(RabbitMQ.Client.IModel)) { }
        public System.Collections.IDictionary Body { get { throw null; } }
        public override byte[] GetContentBody() { throw null; }
        public override string GetDefaultContentType() { throw null; }
    }
    public partial class MapMessageReader : RabbitMQ.Client.Content.BasicMessageReader, RabbitMQ.Client.Content.IMapMessageReader, RabbitMQ.Client.Content.IMessageReader
    {
        public static readonly string MimeType;
        protected System.Collections.IDictionary m_table;
        public MapMessageReader(RabbitMQ.Client.IBasicProperties properties, byte[] payload) : base (default(RabbitMQ.Client.IBasicProperties), default(byte[])) { }
        public System.Collections.IDictionary Body { get { throw null; } }
    }
    public partial class MapWireFormatting
    {
        public MapWireFormatting() { }
        public static System.Collections.IDictionary ReadMap(RabbitMQ.Util.NetworkBinaryReader reader) { throw null; }
        public static void WriteMap(RabbitMQ.Util.NetworkBinaryWriter writer, System.Collections.IDictionary table) { }
    }
    public partial class PrimitiveParser
    {
        public PrimitiveParser() { }
        public static void InvalidConversion(string target, object source) { }
        public static bool ParseBool(string value) { throw null; }
        public static byte ParseByte(string value) { throw null; }
        public static double ParseDouble(string value) { throw null; }
        public static float ParseFloat(string value) { throw null; }
        public static int ParseInt(string value) { throw null; }
        public static long ParseLong(string value) { throw null; }
        public static short ParseShort(string value) { throw null; }
    }
    public partial class StreamMessageBuilder : RabbitMQ.Client.Content.BasicMessageBuilder, RabbitMQ.Client.Content.IMessageBuilder, RabbitMQ.Client.Content.IStreamMessageBuilder
    {
        public static readonly string MimeType;
        public StreamMessageBuilder(RabbitMQ.Client.IModel model) : base (default(RabbitMQ.Client.IModel)) { }
        public StreamMessageBuilder(RabbitMQ.Client.IModel model, int initialAccumulatorSize) : base (default(RabbitMQ.Client.IModel)) { }
        public override string GetDefaultContentType() { throw null; }
        public RabbitMQ.Client.Content.IStreamMessageBuilder WriteBool(bool value) { throw null; }
        public RabbitMQ.Client.Content.IStreamMessageBuilder WriteByte(byte value) { throw null; }
        public RabbitMQ.Client.Content.IStreamMessageBuilder WriteBytes(byte[] source) { throw null; }
        public RabbitMQ.Client.Content.IStreamMessageBuilder WriteBytes(byte[] source, int offset, int count) { throw null; }
        public RabbitMQ.Client.Content.IStreamMessageBuilder WriteChar(char value) { throw null; }
        public RabbitMQ.Client.Content.IStreamMessageBuilder WriteDouble(double value) { throw null; }
        public RabbitMQ.Client.Content.IStreamMessageBuilder WriteInt16(short value) { throw null; }
        public RabbitMQ.Client.Content.IStreamMessageBuilder WriteInt32(int value) { throw null; }
        public RabbitMQ.Client.Content.IStreamMessageBuilder WriteInt64(long value) { throw null; }
        public RabbitMQ.Client.Content.IStreamMessageBuilder WriteObject(object value) { throw null; }
        public RabbitMQ.Client.Content.IStreamMessageBuilder WriteObjects(params object[] values) { throw null; }
        public RabbitMQ.Client.Content.IStreamMessageBuilder WriteSingle(float value) { throw null; }
        public RabbitMQ.Client.Content.IStreamMessageBuilder WriteString(string value) { throw null; }
    }
    public partial class StreamMessageReader : RabbitMQ.Client.Content.BasicMessageReader, RabbitMQ.Client.Content.IMessageReader, RabbitMQ.Client.Content.IStreamMessageReader
    {
        public static readonly string MimeType;
        public StreamMessageReader(RabbitMQ.Client.IBasicProperties properties, byte[] payload) : base (default(RabbitMQ.Client.IBasicProperties), default(byte[])) { }
        public bool ReadBool() { throw null; }
        public byte ReadByte() { throw null; }
        public byte[] ReadBytes() { throw null; }
        public char ReadChar() { throw null; }
        public double ReadDouble() { throw null; }
        public short ReadInt16() { throw null; }
        public int ReadInt32() { throw null; }
        public long ReadInt64() { throw null; }
        public object ReadObject() { throw null; }
        public object[] ReadObjects() { throw null; }
        public float ReadSingle() { throw null; }
        public string ReadString() { throw null; }
    }
    public partial class StreamWireFormatting
    {
        public StreamWireFormatting() { }
        public static bool ReadBool(RabbitMQ.Util.NetworkBinaryReader reader) { throw null; }
        public static byte ReadByte(RabbitMQ.Util.NetworkBinaryReader reader) { throw null; }
        public static byte[] ReadBytes(RabbitMQ.Util.NetworkBinaryReader reader) { throw null; }
        public static char ReadChar(RabbitMQ.Util.NetworkBinaryReader reader) { throw null; }
        public static double ReadDouble(RabbitMQ.Util.NetworkBinaryReader reader) { throw null; }
        public static short ReadInt16(RabbitMQ.Util.NetworkBinaryReader reader) { throw null; }
        public static int ReadInt32(RabbitMQ.Util.NetworkBinaryReader reader) { throw null; }
        public static long ReadInt64(RabbitMQ.Util.NetworkBinaryReader reader) { throw null; }
        public static object ReadNonnullObject(string target, RabbitMQ.Util.NetworkBinaryReader reader) { throw null; }
        public static object ReadObject(RabbitMQ.Util.NetworkBinaryReader reader) { throw null; }
        public static float ReadSingle(RabbitMQ.Util.NetworkBinaryReader reader) { throw null; }
        public static string ReadString(RabbitMQ.Util.NetworkBinaryReader reader) { throw null; }
        public static string ReadUntypedString(RabbitMQ.Util.NetworkBinaryReader reader) { throw null; }
        public static void WriteBool(RabbitMQ.Util.NetworkBinaryWriter writer, bool value) { }
        public static void WriteByte(RabbitMQ.Util.NetworkBinaryWriter writer, byte value) { }
        public static void WriteBytes(RabbitMQ.Util.NetworkBinaryWriter writer, byte[] value) { }
        public static void WriteBytes(RabbitMQ.Util.NetworkBinaryWriter writer, byte[] value, int offset, int length) { }
        public static void WriteChar(RabbitMQ.Util.NetworkBinaryWriter writer, char value) { }
        public static void WriteDouble(RabbitMQ.Util.NetworkBinaryWriter writer, double value) { }
        public static void WriteInt16(RabbitMQ.Util.NetworkBinaryWriter writer, short value) { }
        public static void WriteInt32(RabbitMQ.Util.NetworkBinaryWriter writer, int value) { }
        public static void WriteInt64(RabbitMQ.Util.NetworkBinaryWriter writer, long value) { }
        public static void WriteObject(RabbitMQ.Util.NetworkBinaryWriter writer, object value) { }
        public static void WriteSingle(RabbitMQ.Util.NetworkBinaryWriter writer, float value) { }
        public static void WriteString(RabbitMQ.Util.NetworkBinaryWriter writer, string value) { }
        public static void WriteUntypedString(RabbitMQ.Util.NetworkBinaryWriter writer, string value) { }
    }
    public enum StreamWireFormattingTag
    {
        Bool = 1,
        Byte = 2,
        Bytes = 3,
        Char = 5,
        Double = 9,
        Int16 = 4,
        Int32 = 6,
        Int64 = 7,
        Null = 11,
        Single = 8,
        String = 10,
    }
}
namespace RabbitMQ.Client.Events
{
    public partial class BasicDeliverEventArgs : System.EventArgs
    {
        public BasicDeliverEventArgs() { }
        public BasicDeliverEventArgs(string consumerTag, ulong deliveryTag, bool redelivered, string exchange, string routingKey, RabbitMQ.Client.IBasicProperties properties, byte[] body) { }
        public RabbitMQ.Client.IBasicProperties BasicProperties { get { throw null; } set { } }
        public byte[] Body { get { throw null; } set { } }
        public string ConsumerTag { get { throw null; } set { } }
        public ulong DeliveryTag { get { throw null; } set { } }
        public string Exchange { get { throw null; } set { } }
        public bool Redelivered { get { throw null; } set { } }
        public string RoutingKey { get { throw null; } set { } }
    }
    public delegate void BasicDeliverEventHandler(RabbitMQ.Client.IBasicConsumer sender, RabbitMQ.Client.Events.BasicDeliverEventArgs args);
    public partial class BasicReturnEventArgs : System.EventArgs
    {
        public BasicReturnEventArgs() { }
        public RabbitMQ.Client.IBasicProperties BasicProperties { get { throw null; } set { } }
        public byte[] Body { get { throw null; } set { } }
        public string Exchange { get { throw null; } set { } }
        public ushort ReplyCode { get { throw null; } set { } }
        public string ReplyText { get { throw null; } set { } }
        public string RoutingKey { get { throw null; } set { } }
    }
    public delegate void BasicReturnEventHandler(RabbitMQ.Client.IModel model, RabbitMQ.Client.Events.BasicReturnEventArgs args);
    public partial class CallbackExceptionEventArgs : System.EventArgs
    {
        public CallbackExceptionEventArgs(System.Exception exception) { }
        public System.Collections.IDictionary Detail { get { throw null; } }
        public System.Exception Exception { get { throw null; } }
    }
    public delegate void CallbackExceptionEventHandler(object sender, RabbitMQ.Client.Events.CallbackExceptionEventArgs e);
    public delegate void ConnectionShutdownEventHandler(RabbitMQ.Client.IConnection connection, RabbitMQ.Client.ShutdownEventArgs reason);
    public partial class ConsumerEventArgs : System.EventArgs
    {
        public ConsumerEventArgs(string consumerTag) { }
        public string ConsumerTag { get { throw null; } }
    }
    public delegate void ConsumerEventHandler(object sender, RabbitMQ.Client.Events.ConsumerEventArgs e);
    public delegate void ConsumerShutdownEventHandler(object sender, RabbitMQ.Client.ShutdownEventArgs e);
    public partial class EventingBasicConsumer : RabbitMQ.Client.DefaultBasicConsumer
    {
        public EventingBasicConsumer() { }
        public event RabbitMQ.Client.Events.BasicDeliverEventHandler Received { add { } remove { } }
        public event RabbitMQ.Client.Events.ConsumerEventHandler Registered { add { } remove { } }
        public event RabbitMQ.Client.Events.ConsumerShutdownEventHandler Shutdown { add { } remove { } }
        public event RabbitMQ.Client.Events.ConsumerEventHandler Unregistered { add { } remove { } }
        public override void HandleBasicCancelOk(string consumerTag) { }
        public override void HandleBasicConsumeOk(string consumerTag) { }
        public override void HandleBasicDeliver(string consumerTag, ulong deliveryTag, bool redelivered, string exchange, string routingKey, RabbitMQ.Client.IBasicProperties properties, byte[] body) { }
        public override void HandleModelShutdown(RabbitMQ.Client.IModel model, RabbitMQ.Client.ShutdownEventArgs reason) { }
    }
    public delegate void ModelShutdownEventHandler(RabbitMQ.Client.IModel model, RabbitMQ.Client.ShutdownEventArgs reason);
}
namespace RabbitMQ.Client.Exceptions
{
    public partial class AlreadyClosedException : RabbitMQ.Client.Exceptions.OperationInterruptedException
    {
        public AlreadyClosedException(RabbitMQ.Client.ShutdownEventArgs reason) { }
    }
    public partial class BrokerUnreachableException : System.IO.IOException
    {
        public BrokerUnreachableException(System.Collections.IDictionary connectionAttempts, System.Collections.IDictionary connectionErrors) { }
        public System.Collections.IDictionary ConnectionAttempts { get { throw null; } }
        public System.Collections.IDictionary ConnectionErrors { get { throw null; } }
        public override System.Collections.IDictionary Data { get { throw null; } }
        public override string ToString() { throw null; }
    }
    public partial class ChannelAllocationException : System.Exception
    {
        public ChannelAllocationException() { }
        public ChannelAllocationException(int channel) { }
        public int Channel { get { throw null; } }
    }
    [System.SerializableAttribute]
    public partial class OperationInterruptedException : System.Exception
    {
        protected RabbitMQ.Client.ShutdownEventArgs m_shutdownReason;
        protected OperationInterruptedException() { }
        public OperationInterruptedException(RabbitMQ.Client.ShutdownEventArgs reason) { }
        protected OperationInterruptedException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
        protected OperationInterruptedException(string message) { }
        protected OperationInterruptedException(string message, System.Exception inner) { }
        public RabbitMQ.Client.ShutdownEventArgs ShutdownReason { get { throw null; } }
    }
    public partial class PacketNotRecognizedException : System.Net.ProtocolViolationException
    {
        public PacketNotRecognizedException(int transportHigh, int transportLow, int serverMajor, int serverMinor) { }
        public int ServerMajor { get { throw null; } }
        public int ServerMinor { get { throw null; } }
        public int TransportHigh { get { throw null; } }
        public int TransportLow { get { throw null; } }
    }
    public partial class PossibleAuthenticationFailureException : System.Exception
    {
        public PossibleAuthenticationFailureException(string msg, System.Exception inner) { }
    }
    public partial class ProtocolVersionMismatchException : System.Net.ProtocolViolationException
    {
        public ProtocolVersionMismatchException(int clientMajor, int clientMinor, int serverMajor, int serverMinor) { }
        public int ClientMajor { get { throw null; } }
        public int ClientMinor { get { throw null; } }
        public int ServerMajor { get { throw null; } }
        public int ServerMinor { get { throw null; } }
    }
    public partial class UnexpectedMethodException : System.Exception
    {
        public UnexpectedMethodException(RabbitMQ.Client.IMethod method) { }
        public RabbitMQ.Client.IMethod Method { get { throw null; } }
    }
    public partial class UnsupportedMethodException : System.NotSupportedException
    {
        public UnsupportedMethodException(string methodName) { }
        public string MethodName { get { throw null; } }
    }
    public partial class UnsupportedMethodFieldException : System.NotSupportedException
    {
        public UnsupportedMethodFieldException(string methodName, string fieldName) { }
        public string FieldName { get { throw null; } }
        public string MethodName { get { throw null; } }
    }
    public partial class WireFormattingException : System.Net.ProtocolViolationException
    {
        public WireFormattingException(string message) { }
        public WireFormattingException(string message, object offender) { }
        public object Offender { get { throw null; } }
    }
}
namespace RabbitMQ.Client.Framing.Impl.v0_8
{
    public partial class AccessRequest : RabbitMQ.Client.Impl.MethodBase, RabbitMQ.Client.Framing.v0_8.IAccessRequest, RabbitMQ.Client.IMethod
    {
        public const int ClassId = 30;
        public const int MethodId = 10;
        public bool m_active;
        public bool m_exclusive;
        public bool m_passive;
        public bool m_read;
        public string m_realm;
        public bool m_write;
        public AccessRequest() { }
        public AccessRequest(string initRealm, bool initExclusive, bool initPassive, bool initActive, bool initWrite, bool initRead) { }
        public override bool HasContent { get { throw null; } }
        public override int ProtocolClassId { get { throw null; } }
        public override int ProtocolMethodId { get { throw null; } }
        public override string ProtocolMethodName { get { throw null; } }
        bool RabbitMQ.Client.Framing.v0_8.IAccessRequest.Active { get { throw null; } }
        bool RabbitMQ.Client.Framing.v0_8.IAccessRequest.Exclusive { get { throw null; } }
        bool RabbitMQ.Client.Framing.v0_8.IAccessRequest.Passive { get { throw null; } }
        bool RabbitMQ.Client.Framing.v0_8.IAccessRequest.Read { get { throw null; } }
        string RabbitMQ.Client.Framing.v0_8.IAccessRequest.Realm { get { throw null; } }
        bool RabbitMQ.Client.Framing.v0_8.IAccessRequest.Write { get { throw null; } }
        public override void AppendArgumentDebugStringTo(System.Text.StringBuilder sb) { }
        public override void ReadArgumentsFrom(RabbitMQ.Client.Impl.MethodArgumentReader reader) { }
        public override void WriteArgumentsTo(RabbitMQ.Client.Impl.MethodArgumentWriter writer) { }
    }
    public partial class AccessRequestOk : RabbitMQ.Client.Impl.MethodBase, RabbitMQ.Client.Framing.v0_8.IAccessRequestOk, RabbitMQ.Client.IMethod
    {
        public const int ClassId = 30;
        public const int MethodId = 11;
        public ushort m_ticket;
        public AccessRequestOk() { }
        public AccessRequestOk(ushort initTicket) { }
        public override bool HasContent { get { throw null; } }
        public override int ProtocolClassId { get { throw null; } }
        public override int ProtocolMethodId { get { throw null; } }
        public override string ProtocolMethodName { get { throw null; } }
        ushort RabbitMQ.Client.Framing.v0_8.IAccessRequestOk.Ticket { get { throw null; } }
        public override void AppendArgumentDebugStringTo(System.Text.StringBuilder sb) { }
        public override void ReadArgumentsFrom(RabbitMQ.Client.Impl.MethodArgumentReader reader) { }
        public override void WriteArgumentsTo(RabbitMQ.Client.Impl.MethodArgumentWriter writer) { }
    }
    public partial class BasicAck : RabbitMQ.Client.Impl.MethodBase, RabbitMQ.Client.Framing.v0_8.IBasicAck, RabbitMQ.Client.IMethod
    {
        public const int ClassId = 60;
        public const int MethodId = 80;
        public ulong m_deliveryTag;
        public bool m_multiple;
        public BasicAck() { }
        public BasicAck(ulong initDeliveryTag, bool initMultiple) { }
        public override bool HasContent { get { throw null; } }
        public override int ProtocolClassId { get { throw null; } }
        public override int ProtocolMethodId { get { throw null; } }
        public override string ProtocolMethodName { get { throw null; } }
        ulong RabbitMQ.Client.Framing.v0_8.IBasicAck.DeliveryTag { get { throw null; } }
        bool RabbitMQ.Client.Framing.v0_8.IBasicAck.Multiple { get { throw null; } }
        public override void AppendArgumentDebugStringTo(System.Text.StringBuilder sb) { }
        public override void ReadArgumentsFrom(RabbitMQ.Client.Impl.MethodArgumentReader reader) { }
        public override void WriteArgumentsTo(RabbitMQ.Client.Impl.MethodArgumentWriter writer) { }
    }
    public partial class BasicCancel : RabbitMQ.Client.Impl.MethodBase, RabbitMQ.Client.Framing.v0_8.IBasicCancel, RabbitMQ.Client.IMethod
    {
        public const int ClassId = 60;
        public const int MethodId = 30;
        public string m_consumerTag;
        public bool m_nowait;
        public BasicCancel() { }
        public BasicCancel(string initConsumerTag, bool initNowait) { }
        public override bool HasContent { get { throw null; } }
        public override int ProtocolClassId { get { throw null; } }
        public override int ProtocolMethodId { get { throw null; } }
        public override string ProtocolMethodName { get { throw null; } }
        string RabbitMQ.Client.Framing.v0_8.IBasicCancel.ConsumerTag { get { throw null; } }
        bool RabbitMQ.Client.Framing.v0_8.IBasicCancel.Nowait { get { throw null; } }
        public override void AppendArgumentDebugStringTo(System.Text.StringBuilder sb) { }
        public override void ReadArgumentsFrom(RabbitMQ.Client.Impl.MethodArgumentReader reader) { }
        public override void WriteArgumentsTo(RabbitMQ.Client.Impl.MethodArgumentWriter writer) { }
    }
    public partial class BasicCancelOk : RabbitMQ.Client.Impl.MethodBase, RabbitMQ.Client.Framing.v0_8.IBasicCancelOk, RabbitMQ.Client.IMethod
    {
        public const int ClassId = 60;
        public const int MethodId = 31;
        public string m_consumerTag;
        public BasicCancelOk() { }
        public BasicCancelOk(string initConsumerTag) { }
        public override bool HasContent { get { throw null; } }
        public override int ProtocolClassId { get { throw null; } }
        public override int ProtocolMethodId { get { throw null; } }
        public override string ProtocolMethodName { get { throw null; } }
        string RabbitMQ.Client.Framing.v0_8.IBasicCancelOk.ConsumerTag { get { throw null; } }
        public override void AppendArgumentDebugStringTo(System.Text.StringBuilder sb) { }
        public override void ReadArgumentsFrom(RabbitMQ.Client.Impl.MethodArgumentReader reader) { }
        public override void WriteArgumentsTo(RabbitMQ.Client.Impl.MethodArgumentWriter writer) { }
    }
    public partial class BasicConsume : RabbitMQ.Client.Impl.MethodBase, RabbitMQ.Client.Framing.v0_8.IBasicConsume, RabbitMQ.Client.IMethod
    {
        public const int ClassId = 60;
        public const int MethodId = 20;
        public string m_consumerTag;
        public bool m_exclusive;
        public bool m_noAck;
        public bool m_noLocal;
        public bool m_nowait;
        public string m_queue;
        public ushort m_ticket;
        public BasicConsume() { }
        public BasicConsume(ushort initTicket, string initQueue, string initConsumerTag, bool initNoLocal, bool initNoAck, bool initExclusive, bool initNowait) { }
        public override bool HasContent { get { throw null; } }
        public override int ProtocolClassId { get { throw null; } }
        public override int ProtocolMethodId { get { throw null; } }
        public override string ProtocolMethodName { get { throw null; } }
        string RabbitMQ.Client.Framing.v0_8.IBasicConsume.ConsumerTag { get { throw null; } }
        bool RabbitMQ.Client.Framing.v0_8.IBasicConsume.Exclusive { get { throw null; } }
        bool RabbitMQ.Client.Framing.v0_8.IBasicConsume.NoAck { get { throw null; } }
        bool RabbitMQ.Client.Framing.v0_8.IBasicConsume.NoLocal { get { throw null; } }
        bool RabbitMQ.Client.Framing.v0_8.IBasicConsume.Nowait { get { throw null; } }
        string RabbitMQ.Client.Framing.v0_8.IBasicConsume.Queue { get { throw null; } }
        ushort RabbitMQ.Client.Framing.v0_8.IBasicConsume.Ticket { get { throw null; } }
        public override void AppendArgumentDebugStringTo(System.Text.StringBuilder sb) { }
        public override void ReadArgumentsFrom(RabbitMQ.Client.Impl.MethodArgumentReader reader) { }
        public override void WriteArgumentsTo(RabbitMQ.Client.Impl.MethodArgumentWriter writer) { }
    }
    public partial class BasicConsumeOk : RabbitMQ.Client.Impl.MethodBase, RabbitMQ.Client.Framing.v0_8.IBasicConsumeOk, RabbitMQ.Client.IMethod
    {
        public const int ClassId = 60;
        public const int MethodId = 21;
        public string m_consumerTag;
        public BasicConsumeOk() { }
        public BasicConsumeOk(string initConsumerTag) { }
        public override bool HasContent { get { throw null; } }
        public override int ProtocolClassId { get { throw null; } }
        public override int ProtocolMethodId { get { throw null; } }
        public override string ProtocolMethodName { get { throw null; } }
        string RabbitMQ.Client.Framing.v0_8.IBasicConsumeOk.ConsumerTag { get { throw null; } }
        public override void AppendArgumentDebugStringTo(System.Text.StringBuilder sb) { }
        public override void ReadArgumentsFrom(RabbitMQ.Client.Impl.MethodArgumentReader reader) { }
        public override void WriteArgumentsTo(RabbitMQ.Client.Impl.MethodArgumentWriter writer) { }
    }
    public partial class BasicDeliver : RabbitMQ.Client.Impl.MethodBase, RabbitMQ.Client.Framing.v0_8.IBasicDeliver, RabbitMQ.Client.IMethod
    {
        public const int ClassId = 60;
        public const int MethodId = 60;
        public string m_consumerTag;
        public ulong m_deliveryTag;
        public string m_exchange;
        public bool m_redelivered;
        public string m_routingKey;
        public BasicDeliver() { }
        public BasicDeliver(string initConsumerTag, ulong initDeliveryTag, bool initRedelivered, string initExchange, string initRoutingKey) { }
        public override bool HasContent { get { throw null; } }
        public override int ProtocolClassId { get { throw null; } }
        public override int ProtocolMethodId { get { throw null; } }
        public override string ProtocolMethodName { get { throw null; } }
        string RabbitMQ.Client.Framing.v0_8.IBasicDeliver.ConsumerTag { get { throw null; } }
        ulong RabbitMQ.Client.Framing.v0_8.IBasicDeliver.DeliveryTag { get { throw null; } }
        string RabbitMQ.Client.Framing.v0_8.IBasicDeliver.Exchange { get { throw null; } }
        bool RabbitMQ.Client.Framing.v0_8.IBasicDeliver.Redelivered { get { throw null; } }
        string RabbitMQ.Client.Framing.v0_8.IBasicDeliver.RoutingKey { get { throw null; } }
        public override void AppendArgumentDebugStringTo(System.Text.StringBuilder sb) { }
        public override void ReadArgumentsFrom(RabbitMQ.Client.Impl.MethodArgumentReader reader) { }
        public override void WriteArgumentsTo(RabbitMQ.Client.Impl.MethodArgumentWriter writer) { }
    }
    public partial class BasicGet : RabbitMQ.Client.Impl.MethodBase, RabbitMQ.Client.Framing.v0_8.IBasicGet, RabbitMQ.Client.IMethod
    {
        public const int ClassId = 60;
        public const int MethodId = 70;
        public bool m_noAck;
        public string m_queue;
        public ushort m_ticket;
        public BasicGet() { }
        public BasicGet(ushort initTicket, string initQueue, bool initNoAck) { }
        public override bool HasContent { get { throw null; } }
        public override int ProtocolClassId { get { throw null; } }
        public override int ProtocolMethodId { get { throw null; } }
        public override string ProtocolMethodName { get { throw null; } }
        bool RabbitMQ.Client.Framing.v0_8.IBasicGet.NoAck { get { throw null; } }
        string RabbitMQ.Client.Framing.v0_8.IBasicGet.Queue { get { throw null; } }
        ushort RabbitMQ.Client.Framing.v0_8.IBasicGet.Ticket { get { throw null; } }
        public override void AppendArgumentDebugStringTo(System.Text.StringBuilder sb) { }
        public override void ReadArgumentsFrom(RabbitMQ.Client.Impl.MethodArgumentReader reader) { }
        public override void WriteArgumentsTo(RabbitMQ.Client.Impl.MethodArgumentWriter writer) { }
    }
    public partial class BasicGetEmpty : RabbitMQ.Client.Impl.MethodBase, RabbitMQ.Client.Framing.v0_8.IBasicGetEmpty, RabbitMQ.Client.IMethod
    {
        public const int ClassId = 60;
        public const int MethodId = 72;
        public string m_clusterId;
        public BasicGetEmpty() { }
        public BasicGetEmpty(string initClusterId) { }
        public override bool HasContent { get { throw null; } }
        public override int ProtocolClassId { get { throw null; } }
        public override int ProtocolMethodId { get { throw null; } }
        public override string ProtocolMethodName { get { throw null; } }
        string RabbitMQ.Client.Framing.v0_8.IBasicGetEmpty.ClusterId { get { throw null; } }
        public override void AppendArgumentDebugStringTo(System.Text.StringBuilder sb) { }
        public override void ReadArgumentsFrom(RabbitMQ.Client.Impl.MethodArgumentReader reader) { }
        public override void WriteArgumentsTo(RabbitMQ.Client.Impl.MethodArgumentWriter writer) { }
    }
    public partial class BasicGetOk : RabbitMQ.Client.Impl.MethodBase, RabbitMQ.Client.Framing.v0_8.IBasicGetOk, RabbitMQ.Client.IMethod
    {
        public const int ClassId = 60;
        public const int MethodId = 71;
        public ulong m_deliveryTag;
        public string m_exchange;
        public uint m_messageCount;
        public bool m_redelivered;
        public string m_routingKey;
        public BasicGetOk() { }
        public BasicGetOk(ulong initDeliveryTag, bool initRedelivered, string initExchange, string initRoutingKey, uint initMessageCount) { }
        public override bool HasContent { get { throw null; } }
        public override int ProtocolClassId { get { throw null; } }
        public override int ProtocolMethodId { get { throw null; } }
        public override string ProtocolMethodName { get { throw null; } }
        ulong RabbitMQ.Client.Framing.v0_8.IBasicGetOk.DeliveryTag { get { throw null; } }
        string RabbitMQ.Client.Framing.v0_8.IBasicGetOk.Exchange { get { throw null; } }
        uint RabbitMQ.Client.Framing.v0_8.IBasicGetOk.MessageCount { get { throw null; } }
        bool RabbitMQ.Client.Framing.v0_8.IBasicGetOk.Redelivered { get { throw null; } }
        string RabbitMQ.Client.Framing.v0_8.IBasicGetOk.RoutingKey { get { throw null; } }
        public override void AppendArgumentDebugStringTo(System.Text.StringBuilder sb) { }
        public override void ReadArgumentsFrom(RabbitMQ.Client.Impl.MethodArgumentReader reader) { }
        public override void WriteArgumentsTo(RabbitMQ.Client.Impl.MethodArgumentWriter writer) { }
    }
    public partial class BasicPublish : RabbitMQ.Client.Impl.MethodBase, RabbitMQ.Client.Framing.v0_8.IBasicPublish, RabbitMQ.Client.IMethod
    {
        public const int ClassId = 60;
        public const int MethodId = 40;
        public string m_exchange;
        public bool m_immediate;
        public bool m_mandatory;
        public string m_routingKey;
        public ushort m_ticket;
        public BasicPublish() { }
        public BasicPublish(ushort initTicket, string initExchange, string initRoutingKey, bool initMandatory, bool initImmediate) { }
        public override bool HasContent { get { throw null; } }
        public override int ProtocolClassId { get { throw null; } }
        public override int ProtocolMethodId { get { throw null; } }
        public override string ProtocolMethodName { get { throw null; } }
        string RabbitMQ.Client.Framing.v0_8.IBasicPublish.Exchange { get { throw null; } }
        bool RabbitMQ.Client.Framing.v0_8.IBasicPublish.Immediate { get { throw null; } }
        bool RabbitMQ.Client.Framing.v0_8.IBasicPublish.Mandatory { get { throw null; } }
        string RabbitMQ.Client.Framing.v0_8.IBasicPublish.RoutingKey { get { throw null; } }
        ushort RabbitMQ.Client.Framing.v0_8.IBasicPublish.Ticket { get { throw null; } }
        public override void AppendArgumentDebugStringTo(System.Text.StringBuilder sb) { }
        public override void ReadArgumentsFrom(RabbitMQ.Client.Impl.MethodArgumentReader reader) { }
        public override void WriteArgumentsTo(RabbitMQ.Client.Impl.MethodArgumentWriter writer) { }
    }
    public partial class BasicQos : RabbitMQ.Client.Impl.MethodBase, RabbitMQ.Client.Framing.v0_8.IBasicQos, RabbitMQ.Client.IMethod
    {
        public const int ClassId = 60;
        public const int MethodId = 10;
        public bool m_global;
        public ushort m_prefetchCount;
        public uint m_prefetchSize;
        public BasicQos() { }
        public BasicQos(uint initPrefetchSize, ushort initPrefetchCount, bool initGlobal) { }
        public override bool HasContent { get { throw null; } }
        public override int ProtocolClassId { get { throw null; } }
        public override int ProtocolMethodId { get { throw null; } }
        public override string ProtocolMethodName { get { throw null; } }
        bool RabbitMQ.Client.Framing.v0_8.IBasicQos.Global { get { throw null; } }
        ushort RabbitMQ.Client.Framing.v0_8.IBasicQos.PrefetchCount { get { throw null; } }
        uint RabbitMQ.Client.Framing.v0_8.IBasicQos.PrefetchSize { get { throw null; } }
        public override void AppendArgumentDebugStringTo(System.Text.StringBuilder sb) { }
        public override void ReadArgumentsFrom(RabbitMQ.Client.Impl.MethodArgumentReader reader) { }
        public override void WriteArgumentsTo(RabbitMQ.Client.Impl.MethodArgumentWriter writer) { }
    }
    public partial class BasicQosOk : RabbitMQ.Client.Impl.MethodBase, RabbitMQ.Client.Framing.v0_8.IBasicQosOk, RabbitMQ.Client.IMethod
    {
        public const int ClassId = 60;
        public const int MethodId = 11;
        public BasicQosOk() { }
        public override bool HasContent { get { throw null; } }
        public override int ProtocolClassId { get { throw null; } }
        public override int ProtocolMethodId { get { throw null; } }
        public override string ProtocolMethodName { get { throw null; } }
        public override void AppendArgumentDebugStringTo(System.Text.StringBuilder sb) { }
        public override void ReadArgumentsFrom(RabbitMQ.Client.Impl.MethodArgumentReader reader) { }
        public override void WriteArgumentsTo(RabbitMQ.Client.Impl.MethodArgumentWriter writer) { }
    }
    public partial class BasicRecover : RabbitMQ.Client.Impl.MethodBase, RabbitMQ.Client.Framing.v0_8.IBasicRecover, RabbitMQ.Client.IMethod
    {
        public const int ClassId = 60;
        public const int MethodId = 100;
        public bool m_requeue;
        public BasicRecover() { }
        public BasicRecover(bool initRequeue) { }
        public override bool HasContent { get { throw null; } }
        public override int ProtocolClassId { get { throw null; } }
        public override int ProtocolMethodId { get { throw null; } }
        public override string ProtocolMethodName { get { throw null; } }
        bool RabbitMQ.Client.Framing.v0_8.IBasicRecover.Requeue { get { throw null; } }
        public override void AppendArgumentDebugStringTo(System.Text.StringBuilder sb) { }
        public override void ReadArgumentsFrom(RabbitMQ.Client.Impl.MethodArgumentReader reader) { }
        public override void WriteArgumentsTo(RabbitMQ.Client.Impl.MethodArgumentWriter writer) { }
    }
    public partial class BasicReject : RabbitMQ.Client.Impl.MethodBase, RabbitMQ.Client.Framing.v0_8.IBasicReject, RabbitMQ.Client.IMethod
    {
        public const int ClassId = 60;
        public const int MethodId = 90;
        public ulong m_deliveryTag;
        public bool m_requeue;
        public BasicReject() { }
        public BasicReject(ulong initDeliveryTag, bool initRequeue) { }
        public override bool HasContent { get { throw null; } }
        public override int ProtocolClassId { get { throw null; } }
        public override int ProtocolMethodId { get { throw null; } }
        public override string ProtocolMethodName { get { throw null; } }
        ulong RabbitMQ.Client.Framing.v0_8.IBasicReject.DeliveryTag { get { throw null; } }
        bool RabbitMQ.Client.Framing.v0_8.IBasicReject.Requeue { get { throw null; } }
        public override void AppendArgumentDebugStringTo(System.Text.StringBuilder sb) { }
        public override void ReadArgumentsFrom(RabbitMQ.Client.Impl.MethodArgumentReader reader) { }
        public override void WriteArgumentsTo(RabbitMQ.Client.Impl.MethodArgumentWriter writer) { }
    }
    public partial class BasicReturn : RabbitMQ.Client.Impl.MethodBase, RabbitMQ.Client.Framing.v0_8.IBasicReturn, RabbitMQ.Client.IMethod
    {
        public const int ClassId = 60;
        public const int MethodId = 50;
        public string m_exchange;
        public ushort m_replyCode;
        public string m_replyText;
        public string m_routingKey;
        public BasicReturn() { }
        public BasicReturn(ushort initReplyCode, string initReplyText, string initExchange, string initRoutingKey) { }
        public override bool HasContent { get { throw null; } }
        public override int ProtocolClassId { get { throw null; } }
        public override int ProtocolMethodId { get { throw null; } }
        public override string ProtocolMethodName { get { throw null; } }
        string RabbitMQ.Client.Framing.v0_8.IBasicReturn.Exchange { get { throw null; } }
        ushort RabbitMQ.Client.Framing.v0_8.IBasicReturn.ReplyCode { get { throw null; } }
        string RabbitMQ.Client.Framing.v0_8.IBasicReturn.ReplyText { get { throw null; } }
        string RabbitMQ.Client.Framing.v0_8.IBasicReturn.RoutingKey { get { throw null; } }
        public override void AppendArgumentDebugStringTo(System.Text.StringBuilder sb) { }
        public override void ReadArgumentsFrom(RabbitMQ.Client.Impl.MethodArgumentReader reader) { }
        public override void WriteArgumentsTo(RabbitMQ.Client.Impl.MethodArgumentWriter writer) { }
    }
    public partial class ChannelAlert : RabbitMQ.Client.Impl.MethodBase, RabbitMQ.Client.Framing.v0_8.IChannelAlert, RabbitMQ.Client.IMethod
    {
        public const int ClassId = 20;
        public const int MethodId = 30;
        public System.Collections.IDictionary m_details;
        public ushort m_replyCode;
        public string m_replyText;
        public ChannelAlert() { }
        public ChannelAlert(ushort initReplyCode, string initReplyText, System.Collections.IDictionary initDetails) { }
        public override bool HasContent { get { throw null; } }
        public override int ProtocolClassId { get { throw null; } }
        public override int ProtocolMethodId { get { throw null; } }
        public override string ProtocolMethodName { get { throw null; } }
        System.Collections.IDictionary RabbitMQ.Client.Framing.v0_8.IChannelAlert.Details { get { throw null; } }
        ushort RabbitMQ.Client.Framing.v0_8.IChannelAlert.ReplyCode { get { throw null; } }
        string RabbitMQ.Client.Framing.v0_8.IChannelAlert.ReplyText { get { throw null; } }
        public override void AppendArgumentDebugStringTo(System.Text.StringBuilder sb) { }
        public override void ReadArgumentsFrom(RabbitMQ.Client.Impl.MethodArgumentReader reader) { }
        public override void WriteArgumentsTo(RabbitMQ.Client.Impl.MethodArgumentWriter writer) { }
    }
    public partial class ChannelClose : RabbitMQ.Client.Impl.MethodBase, RabbitMQ.Client.Framing.v0_8.IChannelClose, RabbitMQ.Client.IMethod
    {
        public const int ClassId = 20;
        public const int MethodId = 40;
        public ushort m_classId;
        public ushort m_methodId;
        public ushort m_replyCode;
        public string m_replyText;
        public ChannelClose() { }
        public ChannelClose(ushort initReplyCode, string initReplyText, ushort initClassId, ushort initMethodId) { }
        public override bool HasContent { get { throw null; } }
        public override int ProtocolClassId { get { throw null; } }
        public override int ProtocolMethodId { get { throw null; } }
        public override string ProtocolMethodName { get { throw null; } }
        ushort RabbitMQ.Client.Framing.v0_8.IChannelClose.ClassId { get { throw null; } }
        ushort RabbitMQ.Client.Framing.v0_8.IChannelClose.MethodId { get { throw null; } }
        ushort RabbitMQ.Client.Framing.v0_8.IChannelClose.ReplyCode { get { throw null; } }
        string RabbitMQ.Client.Framing.v0_8.IChannelClose.ReplyText { get { throw null; } }
        public override void AppendArgumentDebugStringTo(System.Text.StringBuilder sb) { }
        public override void ReadArgumentsFrom(RabbitMQ.Client.Impl.MethodArgumentReader reader) { }
        public override void WriteArgumentsTo(RabbitMQ.Client.Impl.MethodArgumentWriter writer) { }
    }
    public partial class ChannelCloseOk : RabbitMQ.Client.Impl.MethodBase, RabbitMQ.Client.Framing.v0_8.IChannelCloseOk, RabbitMQ.Client.IMethod
    {
        public const int ClassId = 20;
        public const int MethodId = 41;
        public ChannelCloseOk() { }
        public override bool HasContent { get { throw null; } }
        public override int ProtocolClassId { get { throw null; } }
        public override int ProtocolMethodId { get { throw null; } }
        public override string ProtocolMethodName { get { throw null; } }
        public override void AppendArgumentDebugStringTo(System.Text.StringBuilder sb) { }
        public override void ReadArgumentsFrom(RabbitMQ.Client.Impl.MethodArgumentReader reader) { }
        public override void WriteArgumentsTo(RabbitMQ.Client.Impl.MethodArgumentWriter writer) { }
    }
    public partial class ChannelFlow : RabbitMQ.Client.Impl.MethodBase, RabbitMQ.Client.Framing.v0_8.IChannelFlow, RabbitMQ.Client.IMethod
    {
        public const int ClassId = 20;
        public const int MethodId = 20;
        public bool m_active;
        public ChannelFlow() { }
        public ChannelFlow(bool initActive) { }
        public override bool HasContent { get { throw null; } }
        public override int ProtocolClassId { get { throw null; } }
        public override int ProtocolMethodId { get { throw null; } }
        public override string ProtocolMethodName { get { throw null; } }
        bool RabbitMQ.Client.Framing.v0_8.IChannelFlow.Active { get { throw null; } }
        public override void AppendArgumentDebugStringTo(System.Text.StringBuilder sb) { }
        public override void ReadArgumentsFrom(RabbitMQ.Client.Impl.MethodArgumentReader reader) { }
        public override void WriteArgumentsTo(RabbitMQ.Client.Impl.MethodArgumentWriter writer) { }
    }
    public partial class ChannelFlowOk : RabbitMQ.Client.Impl.MethodBase, RabbitMQ.Client.Framing.v0_8.IChannelFlowOk, RabbitMQ.Client.IMethod
    {
        public const int ClassId = 20;
        public const int MethodId = 21;
        public bool m_active;
        public ChannelFlowOk() { }
        public ChannelFlowOk(bool initActive) { }
        public override bool HasContent { get { throw null; } }
        public override int ProtocolClassId { get { throw null; } }
        public override int ProtocolMethodId { get { throw null; } }
        public override string ProtocolMethodName { get { throw null; } }
        bool RabbitMQ.Client.Framing.v0_8.IChannelFlowOk.Active { get { throw null; } }
        public override void AppendArgumentDebugStringTo(System.Text.StringBuilder sb) { }
        public override void ReadArgumentsFrom(RabbitMQ.Client.Impl.MethodArgumentReader reader) { }
        public override void WriteArgumentsTo(RabbitMQ.Client.Impl.MethodArgumentWriter writer) { }
    }
    public partial class ChannelOpen : RabbitMQ.Client.Impl.MethodBase, RabbitMQ.Client.Framing.v0_8.IChannelOpen, RabbitMQ.Client.IMethod
    {
        public const int ClassId = 20;
        public const int MethodId = 10;
        public string m_outOfBand;
        public ChannelOpen() { }
        public ChannelOpen(string initOutOfBand) { }
        public override bool HasContent { get { throw null; } }
        public override int ProtocolClassId { get { throw null; } }
        public override int ProtocolMethodId { get { throw null; } }
        public override string ProtocolMethodName { get { throw null; } }
        string RabbitMQ.Client.Framing.v0_8.IChannelOpen.OutOfBand { get { throw null; } }
        public override void AppendArgumentDebugStringTo(System.Text.StringBuilder sb) { }
        public override void ReadArgumentsFrom(RabbitMQ.Client.Impl.MethodArgumentReader reader) { }
        public override void WriteArgumentsTo(RabbitMQ.Client.Impl.MethodArgumentWriter writer) { }
    }
    public partial class ChannelOpenOk : RabbitMQ.Client.Impl.MethodBase, RabbitMQ.Client.Framing.v0_8.IChannelOpenOk, RabbitMQ.Client.IMethod
    {
        public const int ClassId = 20;
        public const int MethodId = 11;
        public ChannelOpenOk() { }
        public override bool HasContent { get { throw null; } }
        public override int ProtocolClassId { get { throw null; } }
        public override int ProtocolMethodId { get { throw null; } }
        public override string ProtocolMethodName { get { throw null; } }
        public override void AppendArgumentDebugStringTo(System.Text.StringBuilder sb) { }
        public override void ReadArgumentsFrom(RabbitMQ.Client.Impl.MethodArgumentReader reader) { }
        public override void WriteArgumentsTo(RabbitMQ.Client.Impl.MethodArgumentWriter writer) { }
    }
    public enum ClassId
    {
        Access = 30,
        Basic = 60,
        Channel = 20,
        Connection = 10,
        Dtx = 100,
        Exchange = 40,
        File = 70,
        Invalid = -1,
        Queue = 50,
        Stream = 80,
        Test = 120,
        Tunnel = 110,
        Tx = 90,
    }
    public partial class Connection : RabbitMQ.Client.Impl.ConnectionBase
    {
        public Connection(RabbitMQ.Client.ConnectionFactory factory, bool insist, RabbitMQ.Client.Impl.IFrameHandler frameHandler) : base (default(RabbitMQ.Client.ConnectionFactory), default(bool), default(RabbitMQ.Client.Impl.IFrameHandler)) { }
    }
    public partial class ConnectionClose : RabbitMQ.Client.Impl.MethodBase, RabbitMQ.Client.Framing.v0_8.IConnectionClose, RabbitMQ.Client.IMethod
    {
        public const int ClassId = 10;
        public const int MethodId = 60;
        public ushort m_classId;
        public ushort m_methodId;
        public ushort m_replyCode;
        public string m_replyText;
        public ConnectionClose() { }
        public ConnectionClose(ushort initReplyCode, string initReplyText, ushort initClassId, ushort initMethodId) { }
        public override bool HasContent { get { throw null; } }
        public override int ProtocolClassId { get { throw null; } }
        public override int ProtocolMethodId { get { throw null; } }
        public override string ProtocolMethodName { get { throw null; } }
        ushort RabbitMQ.Client.Framing.v0_8.IConnectionClose.ClassId { get { throw null; } }
        ushort RabbitMQ.Client.Framing.v0_8.IConnectionClose.MethodId { get { throw null; } }
        ushort RabbitMQ.Client.Framing.v0_8.IConnectionClose.ReplyCode { get { throw null; } }
        string RabbitMQ.Client.Framing.v0_8.IConnectionClose.ReplyText { get { throw null; } }
        public override void AppendArgumentDebugStringTo(System.Text.StringBuilder sb) { }
        public override void ReadArgumentsFrom(RabbitMQ.Client.Impl.MethodArgumentReader reader) { }
        public override void WriteArgumentsTo(RabbitMQ.Client.Impl.MethodArgumentWriter writer) { }
    }
    public partial class ConnectionCloseOk : RabbitMQ.Client.Impl.MethodBase, RabbitMQ.Client.Framing.v0_8.IConnectionCloseOk, RabbitMQ.Client.IMethod
    {
        public const int ClassId = 10;
        public const int MethodId = 61;
        public ConnectionCloseOk() { }
        public override bool HasContent { get { throw null; } }
        public override int ProtocolClassId { get { throw null; } }
        public override int ProtocolMethodId { get { throw null; } }
        public override string ProtocolMethodName { get { throw null; } }
        public override void AppendArgumentDebugStringTo(System.Text.StringBuilder sb) { }
        public override void ReadArgumentsFrom(RabbitMQ.Client.Impl.MethodArgumentReader reader) { }
        public override void WriteArgumentsTo(RabbitMQ.Client.Impl.MethodArgumentWriter writer) { }
    }
    public partial class ConnectionOpen : RabbitMQ.Client.Impl.MethodBase, RabbitMQ.Client.Framing.v0_8.IConnectionOpen, RabbitMQ.Client.IMethod
    {
        public const int ClassId = 10;
        public const int MethodId = 40;
        public string m_capabilities;
        public bool m_insist;
        public string m_virtualHost;
        public ConnectionOpen() { }
        public ConnectionOpen(string initVirtualHost, string initCapabilities, bool initInsist) { }
        public override bool HasContent { get { throw null; } }
        public override int ProtocolClassId { get { throw null; } }
        public override int ProtocolMethodId { get { throw null; } }
        public override string ProtocolMethodName { get { throw null; } }
        string RabbitMQ.Client.Framing.v0_8.IConnectionOpen.Capabilities { get { throw null; } }
        bool RabbitMQ.Client.Framing.v0_8.IConnectionOpen.Insist { get { throw null; } }
        string RabbitMQ.Client.Framing.v0_8.IConnectionOpen.VirtualHost { get { throw null; } }
        public override void AppendArgumentDebugStringTo(System.Text.StringBuilder sb) { }
        public override void ReadArgumentsFrom(RabbitMQ.Client.Impl.MethodArgumentReader reader) { }
        public override void WriteArgumentsTo(RabbitMQ.Client.Impl.MethodArgumentWriter writer) { }
    }
    public partial class ConnectionOpenOk : RabbitMQ.Client.Impl.MethodBase, RabbitMQ.Client.Framing.v0_8.IConnectionOpenOk, RabbitMQ.Client.IMethod
    {
        public const int ClassId = 10;
        public const int MethodId = 41;
        public string m_knownHosts;
        public ConnectionOpenOk() { }
        public ConnectionOpenOk(string initKnownHosts) { }
        public override bool HasContent { get { throw null; } }
        public override int ProtocolClassId { get { throw null; } }
        public override int ProtocolMethodId { get { throw null; } }
        public override string ProtocolMethodName { get { throw null; } }
        string RabbitMQ.Client.Framing.v0_8.IConnectionOpenOk.KnownHosts { get { throw null; } }
        public override void AppendArgumentDebugStringTo(System.Text.StringBuilder sb) { }
        public override void ReadArgumentsFrom(RabbitMQ.Client.Impl.MethodArgumentReader reader) { }
        public override void WriteArgumentsTo(RabbitMQ.Client.Impl.MethodArgumentWriter writer) { }
    }
    public partial class ConnectionRedirect : RabbitMQ.Client.Impl.MethodBase, RabbitMQ.Client.Framing.v0_8.IConnectionRedirect, RabbitMQ.Client.IMethod
    {
        public const int ClassId = 10;
        public const int MethodId = 50;
        public string m_host;
        public string m_knownHosts;
        public ConnectionRedirect() { }
        public ConnectionRedirect(string initHost, string initKnownHosts) { }
        public override bool HasContent { get { throw null; } }
        public override int ProtocolClassId { get { throw null; } }
        public override int ProtocolMethodId { get { throw null; } }
        public override string ProtocolMethodName { get { throw null; } }
        string RabbitMQ.Client.Framing.v0_8.IConnectionRedirect.Host { get { throw null; } }
        string RabbitMQ.Client.Framing.v0_8.IConnectionRedirect.KnownHosts { get { throw null; } }
        public override void AppendArgumentDebugStringTo(System.Text.StringBuilder sb) { }
        public override void ReadArgumentsFrom(RabbitMQ.Client.Impl.MethodArgumentReader reader) { }
        public override void WriteArgumentsTo(RabbitMQ.Client.Impl.MethodArgumentWriter writer) { }
    }
    public partial class ConnectionSecure : RabbitMQ.Client.Impl.MethodBase, RabbitMQ.Client.Framing.v0_8.IConnectionSecure, RabbitMQ.Client.IMethod
    {
        public const int ClassId = 10;
        public const int MethodId = 20;
        public byte[] m_challenge;
        public ConnectionSecure() { }
        public ConnectionSecure(byte[] initChallenge) { }
        public override bool HasContent { get { throw null; } }
        public override int ProtocolClassId { get { throw null; } }
        public override int ProtocolMethodId { get { throw null; } }
        public override string ProtocolMethodName { get { throw null; } }
        byte[] RabbitMQ.Client.Framing.v0_8.IConnectionSecure.Challenge { get { throw null; } }
        public override void AppendArgumentDebugStringTo(System.Text.StringBuilder sb) { }
        public override void ReadArgumentsFrom(RabbitMQ.Client.Impl.MethodArgumentReader reader) { }
        public override void WriteArgumentsTo(RabbitMQ.Client.Impl.MethodArgumentWriter writer) { }
    }
    public partial class ConnectionSecureOk : RabbitMQ.Client.Impl.MethodBase, RabbitMQ.Client.Framing.v0_8.IConnectionSecureOk, RabbitMQ.Client.IMethod
    {
        public const int ClassId = 10;
        public const int MethodId = 21;
        public byte[] m_response;
        public ConnectionSecureOk() { }
        public ConnectionSecureOk(byte[] initResponse) { }
        public override bool HasContent { get { throw null; } }
        public override int ProtocolClassId { get { throw null; } }
        public override int ProtocolMethodId { get { throw null; } }
        public override string ProtocolMethodName { get { throw null; } }
        byte[] RabbitMQ.Client.Framing.v0_8.IConnectionSecureOk.Response { get { throw null; } }
        public override void AppendArgumentDebugStringTo(System.Text.StringBuilder sb) { }
        public override void ReadArgumentsFrom(RabbitMQ.Client.Impl.MethodArgumentReader reader) { }
        public override void WriteArgumentsTo(RabbitMQ.Client.Impl.MethodArgumentWriter writer) { }
    }
    public partial class ConnectionStart : RabbitMQ.Client.Impl.MethodBase, RabbitMQ.Client.Framing.v0_8.IConnectionStart, RabbitMQ.Client.IMethod
    {
        public const int ClassId = 10;
        public const int MethodId = 10;
        public byte[] m_locales;
        public byte[] m_mechanisms;
        public System.Collections.IDictionary m_serverProperties;
        public byte m_versionMajor;
        public byte m_versionMinor;
        public ConnectionStart() { }
        public ConnectionStart(byte initVersionMajor, byte initVersionMinor, System.Collections.IDictionary initServerProperties, byte[] initMechanisms, byte[] initLocales) { }
        public override bool HasContent { get { throw null; } }
        public override int ProtocolClassId { get { throw null; } }
        public override int ProtocolMethodId { get { throw null; } }
        public override string ProtocolMethodName { get { throw null; } }
        byte[] RabbitMQ.Client.Framing.v0_8.IConnectionStart.Locales { get { throw null; } }
        byte[] RabbitMQ.Client.Framing.v0_8.IConnectionStart.Mechanisms { get { throw null; } }
        System.Collections.IDictionary RabbitMQ.Client.Framing.v0_8.IConnectionStart.ServerProperties { get { throw null; } }
        byte RabbitMQ.Client.Framing.v0_8.IConnectionStart.VersionMajor { get { throw null; } }
        byte RabbitMQ.Client.Framing.v0_8.IConnectionStart.VersionMinor { get { throw null; } }
        public override void AppendArgumentDebugStringTo(System.Text.StringBuilder sb) { }
        public override void ReadArgumentsFrom(RabbitMQ.Client.Impl.MethodArgumentReader reader) { }
        public override void WriteArgumentsTo(RabbitMQ.Client.Impl.MethodArgumentWriter writer) { }
    }
    public partial class ConnectionStartOk : RabbitMQ.Client.Impl.MethodBase, RabbitMQ.Client.Framing.v0_8.IConnectionStartOk, RabbitMQ.Client.IMethod
    {
        public const int ClassId = 10;
        public const int MethodId = 11;
        public System.Collections.IDictionary m_clientProperties;
        public string m_locale;
        public string m_mechanism;
        public byte[] m_response;
        public ConnectionStartOk() { }
        public ConnectionStartOk(System.Collections.IDictionary initClientProperties, string initMechanism, byte[] initResponse, string initLocale) { }
        public override bool HasContent { get { throw null; } }
        public override int ProtocolClassId { get { throw null; } }
        public override int ProtocolMethodId { get { throw null; } }
        public override string ProtocolMethodName { get { throw null; } }
        System.Collections.IDictionary RabbitMQ.Client.Framing.v0_8.IConnectionStartOk.ClientProperties { get { throw null; } }
        string RabbitMQ.Client.Framing.v0_8.IConnectionStartOk.Locale { get { throw null; } }
        string RabbitMQ.Client.Framing.v0_8.IConnectionStartOk.Mechanism { get { throw null; } }
        byte[] RabbitMQ.Client.Framing.v0_8.IConnectionStartOk.Response { get { throw null; } }
        public override void AppendArgumentDebugStringTo(System.Text.StringBuilder sb) { }
        public override void ReadArgumentsFrom(RabbitMQ.Client.Impl.MethodArgumentReader reader) { }
        public override void WriteArgumentsTo(RabbitMQ.Client.Impl.MethodArgumentWriter writer) { }
    }
    public partial class ConnectionTune : RabbitMQ.Client.Impl.MethodBase, RabbitMQ.Client.Framing.v0_8.IConnectionTune, RabbitMQ.Client.IMethod
    {
        public const int ClassId = 10;
        public const int MethodId = 30;
        public ushort m_channelMax;
        public uint m_frameMax;
        public ushort m_heartbeat;
        public ConnectionTune() { }
        public ConnectionTune(ushort initChannelMax, uint initFrameMax, ushort initHeartbeat) { }
        public override bool HasContent { get { throw null; } }
        public override int ProtocolClassId { get { throw null; } }
        public override int ProtocolMethodId { get { throw null; } }
        public override string ProtocolMethodName { get { throw null; } }
        ushort RabbitMQ.Client.Framing.v0_8.IConnectionTune.ChannelMax { get { throw null; } }
        uint RabbitMQ.Client.Framing.v0_8.IConnectionTune.FrameMax { get { throw null; } }
        ushort RabbitMQ.Client.Framing.v0_8.IConnectionTune.Heartbeat { get { throw null; } }
        public override void AppendArgumentDebugStringTo(System.Text.StringBuilder sb) { }
        public override void ReadArgumentsFrom(RabbitMQ.Client.Impl.MethodArgumentReader reader) { }
        public override void WriteArgumentsTo(RabbitMQ.Client.Impl.MethodArgumentWriter writer) { }
    }
    public partial class ConnectionTuneOk : RabbitMQ.Client.Impl.MethodBase, RabbitMQ.Client.Framing.v0_8.IConnectionTuneOk, RabbitMQ.Client.IMethod
    {
        public const int ClassId = 10;
        public const int MethodId = 31;
        public ushort m_channelMax;
        public uint m_frameMax;
        public ushort m_heartbeat;
        public ConnectionTuneOk() { }
        public ConnectionTuneOk(ushort initChannelMax, uint initFrameMax, ushort initHeartbeat) { }
        public override bool HasContent { get { throw null; } }
        public override int ProtocolClassId { get { throw null; } }
        public override int ProtocolMethodId { get { throw null; } }
        public override string ProtocolMethodName { get { throw null; } }
        ushort RabbitMQ.Client.Framing.v0_8.IConnectionTuneOk.ChannelMax { get { throw null; } }
        uint RabbitMQ.Client.Framing.v0_8.IConnectionTuneOk.FrameMax { get { throw null; } }
        ushort RabbitMQ.Client.Framing.v0_8.IConnectionTuneOk.Heartbeat { get { throw null; } }
        public override void AppendArgumentDebugStringTo(System.Text.StringBuilder sb) { }
        public override void ReadArgumentsFrom(RabbitMQ.Client.Impl.MethodArgumentReader reader) { }
        public override void WriteArgumentsTo(RabbitMQ.Client.Impl.MethodArgumentWriter writer) { }
    }
    public partial class DtxSelect : RabbitMQ.Client.Impl.MethodBase, RabbitMQ.Client.Framing.v0_8.IDtxSelect, RabbitMQ.Client.IMethod
    {
        public const int ClassId = 100;
        public const int MethodId = 10;
        public DtxSelect() { }
        public override bool HasContent { get { throw null; } }
        public override int ProtocolClassId { get { throw null; } }
        public override int ProtocolMethodId { get { throw null; } }
        public override string ProtocolMethodName { get { throw null; } }
        public override void AppendArgumentDebugStringTo(System.Text.StringBuilder sb) { }
        public override void ReadArgumentsFrom(RabbitMQ.Client.Impl.MethodArgumentReader reader) { }
        public override void WriteArgumentsTo(RabbitMQ.Client.Impl.MethodArgumentWriter writer) { }
    }
    public partial class DtxSelectOk : RabbitMQ.Client.Impl.MethodBase, RabbitMQ.Client.Framing.v0_8.IDtxSelectOk, RabbitMQ.Client.IMethod
    {
        public const int ClassId = 100;
        public const int MethodId = 11;
        public DtxSelectOk() { }
        public override bool HasContent { get { throw null; } }
        public override int ProtocolClassId { get { throw null; } }
        public override int ProtocolMethodId { get { throw null; } }
        public override string ProtocolMethodName { get { throw null; } }
        public override void AppendArgumentDebugStringTo(System.Text.StringBuilder sb) { }
        public override void ReadArgumentsFrom(RabbitMQ.Client.Impl.MethodArgumentReader reader) { }
        public override void WriteArgumentsTo(RabbitMQ.Client.Impl.MethodArgumentWriter writer) { }
    }
    public partial class DtxStart : RabbitMQ.Client.Impl.MethodBase, RabbitMQ.Client.Framing.v0_8.IDtxStart, RabbitMQ.Client.IMethod
    {
        public const int ClassId = 100;
        public const int MethodId = 20;
        public string m_dtxIdentifier;
        public DtxStart() { }
        public DtxStart(string initDtxIdentifier) { }
        public override bool HasContent { get { throw null; } }
        public override int ProtocolClassId { get { throw null; } }
        public override int ProtocolMethodId { get { throw null; } }
        public override string ProtocolMethodName { get { throw null; } }
        string RabbitMQ.Client.Framing.v0_8.IDtxStart.DtxIdentifier { get { throw null; } }
        public override void AppendArgumentDebugStringTo(System.Text.StringBuilder sb) { }
        public override void ReadArgumentsFrom(RabbitMQ.Client.Impl.MethodArgumentReader reader) { }
        public override void WriteArgumentsTo(RabbitMQ.Client.Impl.MethodArgumentWriter writer) { }
    }
    public partial class DtxStartOk : RabbitMQ.Client.Impl.MethodBase, RabbitMQ.Client.Framing.v0_8.IDtxStartOk, RabbitMQ.Client.IMethod
    {
        public const int ClassId = 100;
        public const int MethodId = 21;
        public DtxStartOk() { }
        public override bool HasContent { get { throw null; } }
        public override int ProtocolClassId { get { throw null; } }
        public override int ProtocolMethodId { get { throw null; } }
        public override string ProtocolMethodName { get { throw null; } }
        public override void AppendArgumentDebugStringTo(System.Text.StringBuilder sb) { }
        public override void ReadArgumentsFrom(RabbitMQ.Client.Impl.MethodArgumentReader reader) { }
        public override void WriteArgumentsTo(RabbitMQ.Client.Impl.MethodArgumentWriter writer) { }
    }
    public partial class ExchangeDeclare : RabbitMQ.Client.Impl.MethodBase, RabbitMQ.Client.Framing.v0_8.IExchangeDeclare, RabbitMQ.Client.IMethod
    {
        public const int ClassId = 40;
        public const int MethodId = 10;
        public System.Collections.IDictionary m_arguments;
        public bool m_autoDelete;
        public bool m_durable;
        public string m_exchange;
        public bool m_internal;
        public bool m_nowait;
        public bool m_passive;
        public ushort m_ticket;
        public string m_type;
        public ExchangeDeclare() { }
        public ExchangeDeclare(ushort initTicket, string initExchange, string initType, bool initPassive, bool initDurable, bool initAutoDelete, bool initInternal, bool initNowait, System.Collections.IDictionary initArguments) { }
        public override bool HasContent { get { throw null; } }
        public override int ProtocolClassId { get { throw null; } }
        public override int ProtocolMethodId { get { throw null; } }
        public override string ProtocolMethodName { get { throw null; } }
        System.Collections.IDictionary RabbitMQ.Client.Framing.v0_8.IExchangeDeclare.Arguments { get { throw null; } }
        bool RabbitMQ.Client.Framing.v0_8.IExchangeDeclare.AutoDelete { get { throw null; } }
        bool RabbitMQ.Client.Framing.v0_8.IExchangeDeclare.Durable { get { throw null; } }
        string RabbitMQ.Client.Framing.v0_8.IExchangeDeclare.Exchange { get { throw null; } }
        bool RabbitMQ.Client.Framing.v0_8.IExchangeDeclare.Internal { get { throw null; } }
        bool RabbitMQ.Client.Framing.v0_8.IExchangeDeclare.Nowait { get { throw null; } }
        bool RabbitMQ.Client.Framing.v0_8.IExchangeDeclare.Passive { get { throw null; } }
        ushort RabbitMQ.Client.Framing.v0_8.IExchangeDeclare.Ticket { get { throw null; } }
        string RabbitMQ.Client.Framing.v0_8.IExchangeDeclare.Type { get { throw null; } }
        public override void AppendArgumentDebugStringTo(System.Text.StringBuilder sb) { }
        public override void ReadArgumentsFrom(RabbitMQ.Client.Impl.MethodArgumentReader reader) { }
        public override void WriteArgumentsTo(RabbitMQ.Client.Impl.MethodArgumentWriter writer) { }
    }
    public partial class ExchangeDeclareOk : RabbitMQ.Client.Impl.MethodBase, RabbitMQ.Client.Framing.v0_8.IExchangeDeclareOk, RabbitMQ.Client.IMethod
    {
        public const int ClassId = 40;
        public const int MethodId = 11;
        public ExchangeDeclareOk() { }
        public override bool HasContent { get { throw null; } }
        public override int ProtocolClassId { get { throw null; } }
        public override int ProtocolMethodId { get { throw null; } }
        public override string ProtocolMethodName { get { throw null; } }
        public override void AppendArgumentDebugStringTo(System.Text.StringBuilder sb) { }
        public override void ReadArgumentsFrom(RabbitMQ.Client.Impl.MethodArgumentReader reader) { }
        public override void WriteArgumentsTo(RabbitMQ.Client.Impl.MethodArgumentWriter writer) { }
    }
    public partial class ExchangeDelete : RabbitMQ.Client.Impl.MethodBase, RabbitMQ.Client.Framing.v0_8.IExchangeDelete, RabbitMQ.Client.IMethod
    {
        public const int ClassId = 40;
        public const int MethodId = 20;
        public string m_exchange;
        public bool m_ifUnused;
        public bool m_nowait;
        public ushort m_ticket;
        public ExchangeDelete() { }
        public ExchangeDelete(ushort initTicket, string initExchange, bool initIfUnused, bool initNowait) { }
        public override bool HasContent { get { throw null; } }
        public override int ProtocolClassId { get { throw null; } }
        public override int ProtocolMethodId { get { throw null; } }
        public override string ProtocolMethodName { get { throw null; } }
        string RabbitMQ.Client.Framing.v0_8.IExchangeDelete.Exchange { get { throw null; } }
        bool RabbitMQ.Client.Framing.v0_8.IExchangeDelete.IfUnused { get { throw null; } }
        bool RabbitMQ.Client.Framing.v0_8.IExchangeDelete.Nowait { get { throw null; } }
        ushort RabbitMQ.Client.Framing.v0_8.IExchangeDelete.Ticket { get { throw null; } }
        public override void AppendArgumentDebugStringTo(System.Text.StringBuilder sb) { }
        public override void ReadArgumentsFrom(RabbitMQ.Client.Impl.MethodArgumentReader reader) { }
        public override void WriteArgumentsTo(RabbitMQ.Client.Impl.MethodArgumentWriter writer) { }
    }
    public partial class ExchangeDeleteOk : RabbitMQ.Client.Impl.MethodBase, RabbitMQ.Client.Framing.v0_8.IExchangeDeleteOk, RabbitMQ.Client.IMethod
    {
        public const int ClassId = 40;
        public const int MethodId = 21;
        public ExchangeDeleteOk() { }
        public override bool HasContent { get { throw null; } }
        public override int ProtocolClassId { get { throw null; } }
        public override int ProtocolMethodId { get { throw null; } }
        public override string ProtocolMethodName { get { throw null; } }
        public override void AppendArgumentDebugStringTo(System.Text.StringBuilder sb) { }
        public override void ReadArgumentsFrom(RabbitMQ.Client.Impl.MethodArgumentReader reader) { }
        public override void WriteArgumentsTo(RabbitMQ.Client.Impl.MethodArgumentWriter writer) { }
    }
    public partial class FileAck : RabbitMQ.Client.Impl.MethodBase, RabbitMQ.Client.Framing.v0_8.IFileAck, RabbitMQ.Client.IMethod
    {
        public const int ClassId = 70;
        public const int MethodId = 90;
        public ulong m_deliveryTag;
        public bool m_multiple;
        public FileAck() { }
        public FileAck(ulong initDeliveryTag, bool initMultiple) { }
        public override bool HasContent { get { throw null; } }
        public override int ProtocolClassId { get { throw null; } }
        public override int ProtocolMethodId { get { throw null; } }
        public override string ProtocolMethodName { get { throw null; } }
        ulong RabbitMQ.Client.Framing.v0_8.IFileAck.DeliveryTag { get { throw null; } }
        bool RabbitMQ.Client.Framing.v0_8.IFileAck.Multiple { get { throw null; } }
        public override void AppendArgumentDebugStringTo(System.Text.StringBuilder sb) { }
        public override void ReadArgumentsFrom(RabbitMQ.Client.Impl.MethodArgumentReader reader) { }
        public override void WriteArgumentsTo(RabbitMQ.Client.Impl.MethodArgumentWriter writer) { }
    }
    public partial class FileCancel : RabbitMQ.Client.Impl.MethodBase, RabbitMQ.Client.Framing.v0_8.IFileCancel, RabbitMQ.Client.IMethod
    {
        public const int ClassId = 70;
        public const int MethodId = 30;
        public string m_consumerTag;
        public bool m_nowait;
        public FileCancel() { }
        public FileCancel(string initConsumerTag, bool initNowait) { }
        public override bool HasContent { get { throw null; } }
        public override int ProtocolClassId { get { throw null; } }
        public override int ProtocolMethodId { get { throw null; } }
        public override string ProtocolMethodName { get { throw null; } }
        string RabbitMQ.Client.Framing.v0_8.IFileCancel.ConsumerTag { get { throw null; } }
        bool RabbitMQ.Client.Framing.v0_8.IFileCancel.Nowait { get { throw null; } }
        public override void AppendArgumentDebugStringTo(System.Text.StringBuilder sb) { }
        public override void ReadArgumentsFrom(RabbitMQ.Client.Impl.MethodArgumentReader reader) { }
        public override void WriteArgumentsTo(RabbitMQ.Client.Impl.MethodArgumentWriter writer) { }
    }
    public partial class FileCancelOk : RabbitMQ.Client.Impl.MethodBase, RabbitMQ.Client.Framing.v0_8.IFileCancelOk, RabbitMQ.Client.IMethod
    {
        public const int ClassId = 70;
        public const int MethodId = 31;
        public string m_consumerTag;
        public FileCancelOk() { }
        public FileCancelOk(string initConsumerTag) { }
        public override bool HasContent { get { throw null; } }
        public override int ProtocolClassId { get { throw null; } }
        public override int ProtocolMethodId { get { throw null; } }
        public override string ProtocolMethodName { get { throw null; } }
        string RabbitMQ.Client.Framing.v0_8.IFileCancelOk.ConsumerTag { get { throw null; } }
        public override void AppendArgumentDebugStringTo(System.Text.StringBuilder sb) { }
        public override void ReadArgumentsFrom(RabbitMQ.Client.Impl.MethodArgumentReader reader) { }
        public override void WriteArgumentsTo(RabbitMQ.Client.Impl.MethodArgumentWriter writer) { }
    }
    public partial class FileConsume : RabbitMQ.Client.Impl.MethodBase, RabbitMQ.Client.Framing.v0_8.IFileConsume, RabbitMQ.Client.IMethod
    {
        public const int ClassId = 70;
        public const int MethodId = 20;
        public string m_consumerTag;
        public bool m_exclusive;
        public bool m_noAck;
        public bool m_noLocal;
        public bool m_nowait;
        public string m_queue;
        public ushort m_ticket;
        public FileConsume() { }
        public FileConsume(ushort initTicket, string initQueue, string initConsumerTag, bool initNoLocal, bool initNoAck, bool initExclusive, bool initNowait) { }
        public override bool HasContent { get { throw null; } }
        public override int ProtocolClassId { get { throw null; } }
        public override int ProtocolMethodId { get { throw null; } }
        public override string ProtocolMethodName { get { throw null; } }
        string RabbitMQ.Client.Framing.v0_8.IFileConsume.ConsumerTag { get { throw null; } }
        bool RabbitMQ.Client.Framing.v0_8.IFileConsume.Exclusive { get { throw null; } }
        bool RabbitMQ.Client.Framing.v0_8.IFileConsume.NoAck { get { throw null; } }
        bool RabbitMQ.Client.Framing.v0_8.IFileConsume.NoLocal { get { throw null; } }
        bool RabbitMQ.Client.Framing.v0_8.IFileConsume.Nowait { get { throw null; } }
        string RabbitMQ.Client.Framing.v0_8.IFileConsume.Queue { get { throw null; } }
        ushort RabbitMQ.Client.Framing.v0_8.IFileConsume.Ticket { get { throw null; } }
        public override void AppendArgumentDebugStringTo(System.Text.StringBuilder sb) { }
        public override void ReadArgumentsFrom(RabbitMQ.Client.Impl.MethodArgumentReader reader) { }
        public override void WriteArgumentsTo(RabbitMQ.Client.Impl.MethodArgumentWriter writer) { }
    }
    public partial class FileConsumeOk : RabbitMQ.Client.Impl.MethodBase, RabbitMQ.Client.Framing.v0_8.IFileConsumeOk, RabbitMQ.Client.IMethod
    {
        public const int ClassId = 70;
        public const int MethodId = 21;
        public string m_consumerTag;
        public FileConsumeOk() { }
        public FileConsumeOk(string initConsumerTag) { }
        public override bool HasContent { get { throw null; } }
        public override int ProtocolClassId { get { throw null; } }
        public override int ProtocolMethodId { get { throw null; } }
        public override string ProtocolMethodName { get { throw null; } }
        string RabbitMQ.Client.Framing.v0_8.IFileConsumeOk.ConsumerTag { get { throw null; } }
        public override void AppendArgumentDebugStringTo(System.Text.StringBuilder sb) { }
        public override void ReadArgumentsFrom(RabbitMQ.Client.Impl.MethodArgumentReader reader) { }
        public override void WriteArgumentsTo(RabbitMQ.Client.Impl.MethodArgumentWriter writer) { }
    }
    public partial class FileDeliver : RabbitMQ.Client.Impl.MethodBase, RabbitMQ.Client.Framing.v0_8.IFileDeliver, RabbitMQ.Client.IMethod
    {
        public const int ClassId = 70;
        public const int MethodId = 80;
        public string m_consumerTag;
        public ulong m_deliveryTag;
        public string m_exchange;
        public string m_identifier;
        public bool m_redelivered;
        public string m_routingKey;
        public FileDeliver() { }
        public FileDeliver(string initConsumerTag, ulong initDeliveryTag, bool initRedelivered, string initExchange, string initRoutingKey, string initIdentifier) { }
        public override bool HasContent { get { throw null; } }
        public override int ProtocolClassId { get { throw null; } }
        public override int ProtocolMethodId { get { throw null; } }
        public override string ProtocolMethodName { get { throw null; } }
        string RabbitMQ.Client.Framing.v0_8.IFileDeliver.ConsumerTag { get { throw null; } }
        ulong RabbitMQ.Client.Framing.v0_8.IFileDeliver.DeliveryTag { get { throw null; } }
        string RabbitMQ.Client.Framing.v0_8.IFileDeliver.Exchange { get { throw null; } }
        string RabbitMQ.Client.Framing.v0_8.IFileDeliver.Identifier { get { throw null; } }
        bool RabbitMQ.Client.Framing.v0_8.IFileDeliver.Redelivered { get { throw null; } }
        string RabbitMQ.Client.Framing.v0_8.IFileDeliver.RoutingKey { get { throw null; } }
        public override void AppendArgumentDebugStringTo(System.Text.StringBuilder sb) { }
        public override void ReadArgumentsFrom(RabbitMQ.Client.Impl.MethodArgumentReader reader) { }
        public override void WriteArgumentsTo(RabbitMQ.Client.Impl.MethodArgumentWriter writer) { }
    }
    public partial class FileOpen : RabbitMQ.Client.Impl.MethodBase, RabbitMQ.Client.Framing.v0_8.IFileOpen, RabbitMQ.Client.IMethod
    {
        public const int ClassId = 70;
        public const int MethodId = 40;
        public ulong m_contentSize;
        public string m_identifier;
        public FileOpen() { }
        public FileOpen(string initIdentifier, ulong initContentSize) { }
        public override bool HasContent { get { throw null; } }
        public override int ProtocolClassId { get { throw null; } }
        public override int ProtocolMethodId { get { throw null; } }
        public override string ProtocolMethodName { get { throw null; } }
        ulong RabbitMQ.Client.Framing.v0_8.IFileOpen.ContentSize { get { throw null; } }
        string RabbitMQ.Client.Framing.v0_8.IFileOpen.Identifier { get { throw null; } }
        public override void AppendArgumentDebugStringTo(System.Text.StringBuilder sb) { }
        public override void ReadArgumentsFrom(RabbitMQ.Client.Impl.MethodArgumentReader reader) { }
        public override void WriteArgumentsTo(RabbitMQ.Client.Impl.MethodArgumentWriter writer) { }
    }
    public partial class FileOpenOk : RabbitMQ.Client.Impl.MethodBase, RabbitMQ.Client.Framing.v0_8.IFileOpenOk, RabbitMQ.Client.IMethod
    {
        public const int ClassId = 70;
        public const int MethodId = 41;
        public ulong m_stagedSize;
        public FileOpenOk() { }
        public FileOpenOk(ulong initStagedSize) { }
        public override bool HasContent { get { throw null; } }
        public override int ProtocolClassId { get { throw null; } }
        public override int ProtocolMethodId { get { throw null; } }
        public override string ProtocolMethodName { get { throw null; } }
        ulong RabbitMQ.Client.Framing.v0_8.IFileOpenOk.StagedSize { get { throw null; } }
        public override void AppendArgumentDebugStringTo(System.Text.StringBuilder sb) { }
        public override void ReadArgumentsFrom(RabbitMQ.Client.Impl.MethodArgumentReader reader) { }
        public override void WriteArgumentsTo(RabbitMQ.Client.Impl.MethodArgumentWriter writer) { }
    }
    public partial class FilePublish : RabbitMQ.Client.Impl.MethodBase, RabbitMQ.Client.Framing.v0_8.IFilePublish, RabbitMQ.Client.IMethod
    {
        public const int ClassId = 70;
        public const int MethodId = 60;
        public string m_exchange;
        public string m_identifier;
        public bool m_immediate;
        public bool m_mandatory;
        public string m_routingKey;
        public ushort m_ticket;
        public FilePublish() { }
        public FilePublish(ushort initTicket, string initExchange, string initRoutingKey, bool initMandatory, bool initImmediate, string initIdentifier) { }
        public override bool HasContent { get { throw null; } }
        public override int ProtocolClassId { get { throw null; } }
        public override int ProtocolMethodId { get { throw null; } }
        public override string ProtocolMethodName { get { throw null; } }
        string RabbitMQ.Client.Framing.v0_8.IFilePublish.Exchange { get { throw null; } }
        string RabbitMQ.Client.Framing.v0_8.IFilePublish.Identifier { get { throw null; } }
        bool RabbitMQ.Client.Framing.v0_8.IFilePublish.Immediate { get { throw null; } }
        bool RabbitMQ.Client.Framing.v0_8.IFilePublish.Mandatory { get { throw null; } }
        string RabbitMQ.Client.Framing.v0_8.IFilePublish.RoutingKey { get { throw null; } }
        ushort RabbitMQ.Client.Framing.v0_8.IFilePublish.Ticket { get { throw null; } }
        public override void AppendArgumentDebugStringTo(System.Text.StringBuilder sb) { }
        public override void ReadArgumentsFrom(RabbitMQ.Client.Impl.MethodArgumentReader reader) { }
        public override void WriteArgumentsTo(RabbitMQ.Client.Impl.MethodArgumentWriter writer) { }
    }
    public partial class FileQos : RabbitMQ.Client.Impl.MethodBase, RabbitMQ.Client.Framing.v0_8.IFileQos, RabbitMQ.Client.IMethod
    {
        public const int ClassId = 70;
        public const int MethodId = 10;
        public bool m_global;
        public ushort m_prefetchCount;
        public uint m_prefetchSize;
        public FileQos() { }
        public FileQos(uint initPrefetchSize, ushort initPrefetchCount, bool initGlobal) { }
        public override bool HasContent { get { throw null; } }
        public override int ProtocolClassId { get { throw null; } }
        public override int ProtocolMethodId { get { throw null; } }
        public override string ProtocolMethodName { get { throw null; } }
        bool RabbitMQ.Client.Framing.v0_8.IFileQos.Global { get { throw null; } }
        ushort RabbitMQ.Client.Framing.v0_8.IFileQos.PrefetchCount { get { throw null; } }
        uint RabbitMQ.Client.Framing.v0_8.IFileQos.PrefetchSize { get { throw null; } }
        public override void AppendArgumentDebugStringTo(System.Text.StringBuilder sb) { }
        public override void ReadArgumentsFrom(RabbitMQ.Client.Impl.MethodArgumentReader reader) { }
        public override void WriteArgumentsTo(RabbitMQ.Client.Impl.MethodArgumentWriter writer) { }
    }
    public partial class FileQosOk : RabbitMQ.Client.Impl.MethodBase, RabbitMQ.Client.Framing.v0_8.IFileQosOk, RabbitMQ.Client.IMethod
    {
        public const int ClassId = 70;
        public const int MethodId = 11;
        public FileQosOk() { }
        public override bool HasContent { get { throw null; } }
        public override int ProtocolClassId { get { throw null; } }
        public override int ProtocolMethodId { get { throw null; } }
        public override string ProtocolMethodName { get { throw null; } }
        public override void AppendArgumentDebugStringTo(System.Text.StringBuilder sb) { }
        public override void ReadArgumentsFrom(RabbitMQ.Client.Impl.MethodArgumentReader reader) { }
        public override void WriteArgumentsTo(RabbitMQ.Client.Impl.MethodArgumentWriter writer) { }
    }
    public partial class FileReject : RabbitMQ.Client.Impl.MethodBase, RabbitMQ.Client.Framing.v0_8.IFileReject, RabbitMQ.Client.IMethod
    {
        public const int ClassId = 70;
        public const int MethodId = 100;
        public ulong m_deliveryTag;
        public bool m_requeue;
        public FileReject() { }
        public FileReject(ulong initDeliveryTag, bool initRequeue) { }
        public override bool HasContent { get { throw null; } }
        public override int ProtocolClassId { get { throw null; } }
        public override int ProtocolMethodId { get { throw null; } }
        public override string ProtocolMethodName { get { throw null; } }
        ulong RabbitMQ.Client.Framing.v0_8.IFileReject.DeliveryTag { get { throw null; } }
        bool RabbitMQ.Client.Framing.v0_8.IFileReject.Requeue { get { throw null; } }
        public override void AppendArgumentDebugStringTo(System.Text.StringBuilder sb) { }
        public override void ReadArgumentsFrom(RabbitMQ.Client.Impl.MethodArgumentReader reader) { }
        public override void WriteArgumentsTo(RabbitMQ.Client.Impl.MethodArgumentWriter writer) { }
    }
    public partial class FileReturn : RabbitMQ.Client.Impl.MethodBase, RabbitMQ.Client.Framing.v0_8.IFileReturn, RabbitMQ.Client.IMethod
    {
        public const int ClassId = 70;
        public const int MethodId = 70;
        public string m_exchange;
        public ushort m_replyCode;
        public string m_replyText;
        public string m_routingKey;
        public FileReturn() { }
        public FileReturn(ushort initReplyCode, string initReplyText, string initExchange, string initRoutingKey) { }
        public override bool HasContent { get { throw null; } }
        public override int ProtocolClassId { get { throw null; } }
        public override int ProtocolMethodId { get { throw null; } }
        public override string ProtocolMethodName { get { throw null; } }
        string RabbitMQ.Client.Framing.v0_8.IFileReturn.Exchange { get { throw null; } }
        ushort RabbitMQ.Client.Framing.v0_8.IFileReturn.ReplyCode { get { throw null; } }
        string RabbitMQ.Client.Framing.v0_8.IFileReturn.ReplyText { get { throw null; } }
        string RabbitMQ.Client.Framing.v0_8.IFileReturn.RoutingKey { get { throw null; } }
        public override void AppendArgumentDebugStringTo(System.Text.StringBuilder sb) { }
        public override void ReadArgumentsFrom(RabbitMQ.Client.Impl.MethodArgumentReader reader) { }
        public override void WriteArgumentsTo(RabbitMQ.Client.Impl.MethodArgumentWriter writer) { }
    }
    public partial class FileStage : RabbitMQ.Client.Impl.MethodBase, RabbitMQ.Client.Framing.v0_8.IFileStage, RabbitMQ.Client.IMethod
    {
        public const int ClassId = 70;
        public const int MethodId = 50;
        public FileStage() { }
        public override bool HasContent { get { throw null; } }
        public override int ProtocolClassId { get { throw null; } }
        public override int ProtocolMethodId { get { throw null; } }
        public override string ProtocolMethodName { get { throw null; } }
        public override void AppendArgumentDebugStringTo(System.Text.StringBuilder sb) { }
        public override void ReadArgumentsFrom(RabbitMQ.Client.Impl.MethodArgumentReader reader) { }
        public override void WriteArgumentsTo(RabbitMQ.Client.Impl.MethodArgumentWriter writer) { }
    }
    public partial class Model : RabbitMQ.Client.Impl.ModelBase
    {
        public Model(RabbitMQ.Client.Impl.ISession session) : base (default(RabbitMQ.Client.Impl.ISession)) { }
        public override void BasicAck(ulong deliveryTag, bool multiple) { }
        public override void BasicQos(uint prefetchSize, ushort prefetchCount, bool global) { }
        public override void BasicRecover(bool requeue) { }
        public override void BasicReject(ulong deliveryTag, bool requeue) { }
        public override void ChannelFlow(bool active) { }
        public override RabbitMQ.Client.Impl.ConnectionTuneDetails ConnectionStartOk(System.Collections.IDictionary clientProperties, string mechanism, byte[] response, string locale) { throw null; }
        public override void ConnectionTuneOk(ushort channelMax, uint frameMax, ushort heartbeat) { }
        public override RabbitMQ.Client.IBasicProperties CreateBasicProperties() { throw null; }
        public override RabbitMQ.Client.IFileProperties CreateFileProperties() { throw null; }
        public override RabbitMQ.Client.IStreamProperties CreateStreamProperties() { throw null; }
        public override bool DispatchAsynchronous(RabbitMQ.Client.Impl.Command cmd) { throw null; }
        public override void DtxSelect() { }
        public override void DtxStart(string dtxIdentifier) { }
        public override void ExchangeDeclare(string exchange, string type, bool passive, bool durable, bool autoDelete, bool @internal, bool nowait, System.Collections.IDictionary arguments) { }
        public override void ExchangeDelete(string exchange, bool ifUnused, bool nowait) { }
        public override void QueueBind(string queue, string exchange, string routingKey, bool nowait, System.Collections.IDictionary arguments) { }
        public override string QueueDeclare(string queue, bool passive, bool durable, bool exclusive, bool autoDelete, bool nowait, System.Collections.IDictionary arguments) { throw null; }
        public override uint QueueDelete(string queue, bool ifUnused, bool ifEmpty, bool nowait) { throw null; }
        public override uint QueuePurge(string queue, bool nowait) { throw null; }
        public override void QueueUnbind(string queue, string exchange, string routingKey, System.Collections.IDictionary arguments) { }
        public override void TxCommit() { }
        public override void TxRollback() { }
        public override void TxSelect() { }
        public override void _Private_BasicCancel(string consumerTag, bool nowait) { }
        public override void _Private_BasicConsume(string queue, string consumerTag, bool noLocal, bool noAck, bool exclusive, bool nowait, System.Collections.IDictionary filter) { }
        public override void _Private_BasicGet(string queue, bool noAck) { }
        public override void _Private_BasicPublish(string exchange, string routingKey, bool mandatory, bool immediate, RabbitMQ.Client.IBasicProperties basicProperties, byte[] body) { }
        public override void _Private_ChannelClose(ushort replyCode, string replyText, ushort classId, ushort methodId) { }
        public override void _Private_ChannelCloseOk() { }
        public override void _Private_ChannelFlowOk() { }
        public override void _Private_ChannelOpen(string outOfBand) { }
        public override void _Private_ConnectionClose(ushort replyCode, string replyText, ushort classId, ushort methodId) { }
        public override void _Private_ConnectionCloseOk() { }
        public override void _Private_ConnectionOpen(string virtualHost, string capabilities, bool insist) { }
    }
    public abstract partial class ProtocolBase : RabbitMQ.Client.Impl.AbstractProtocolBase
    {
        protected ProtocolBase() { }
        public override bool CanSendWhileClosed(RabbitMQ.Client.Impl.Command cmd) { throw null; }
        public override void CreateChannelClose(ushort reasonCode, string reasonText, out RabbitMQ.Client.Impl.Command request, out int replyClassId, out int replyMethodId) { throw null; }
        public override RabbitMQ.Client.IConnection CreateConnection(RabbitMQ.Client.ConnectionFactory factory, bool insist, RabbitMQ.Client.Impl.IFrameHandler frameHandler) { throw null; }
        public override void CreateConnectionClose(ushort reasonCode, string reasonText, out RabbitMQ.Client.Impl.Command request, out int replyClassId, out int replyMethodId) { throw null; }
        public override RabbitMQ.Client.Impl.IFrameHandler CreateFrameHandler(RabbitMQ.Client.AmqpTcpEndpoint endpoint) { throw null; }
        public override RabbitMQ.Client.IModel CreateModel(RabbitMQ.Client.Impl.ISession session) { throw null; }
    }
    public partial class QueueBind : RabbitMQ.Client.Impl.MethodBase, RabbitMQ.Client.Framing.v0_8.IQueueBind, RabbitMQ.Client.IMethod
    {
        public const int ClassId = 50;
        public const int MethodId = 20;
        public System.Collections.IDictionary m_arguments;
        public string m_exchange;
        public bool m_nowait;
        public string m_queue;
        public string m_routingKey;
        public ushort m_ticket;
        public QueueBind() { }
        public QueueBind(ushort initTicket, string initQueue, string initExchange, string initRoutingKey, bool initNowait, System.Collections.IDictionary initArguments) { }
        public override bool HasContent { get { throw null; } }
        public override int ProtocolClassId { get { throw null; } }
        public override int ProtocolMethodId { get { throw null; } }
        public override string ProtocolMethodName { get { throw null; } }
        System.Collections.IDictionary RabbitMQ.Client.Framing.v0_8.IQueueBind.Arguments { get { throw null; } }
        string RabbitMQ.Client.Framing.v0_8.IQueueBind.Exchange { get { throw null; } }
        bool RabbitMQ.Client.Framing.v0_8.IQueueBind.Nowait { get { throw null; } }
        string RabbitMQ.Client.Framing.v0_8.IQueueBind.Queue { get { throw null; } }
        string RabbitMQ.Client.Framing.v0_8.IQueueBind.RoutingKey { get { throw null; } }
        ushort RabbitMQ.Client.Framing.v0_8.IQueueBind.Ticket { get { throw null; } }
        public override void AppendArgumentDebugStringTo(System.Text.StringBuilder sb) { }
        public override void ReadArgumentsFrom(RabbitMQ.Client.Impl.MethodArgumentReader reader) { }
        public override void WriteArgumentsTo(RabbitMQ.Client.Impl.MethodArgumentWriter writer) { }
    }
    public partial class QueueBindOk : RabbitMQ.Client.Impl.MethodBase, RabbitMQ.Client.Framing.v0_8.IQueueBindOk, RabbitMQ.Client.IMethod
    {
        public const int ClassId = 50;
        public const int MethodId = 21;
        public QueueBindOk() { }
        public override bool HasContent { get { throw null; } }
        public override int ProtocolClassId { get { throw null; } }
        public override int ProtocolMethodId { get { throw null; } }
        public override string ProtocolMethodName { get { throw null; } }
        public override void AppendArgumentDebugStringTo(System.Text.StringBuilder sb) { }
        public override void ReadArgumentsFrom(RabbitMQ.Client.Impl.MethodArgumentReader reader) { }
        public override void WriteArgumentsTo(RabbitMQ.Client.Impl.MethodArgumentWriter writer) { }
    }
    public partial class QueueDeclare : RabbitMQ.Client.Impl.MethodBase, RabbitMQ.Client.Framing.v0_8.IQueueDeclare, RabbitMQ.Client.IMethod
    {
        public const int ClassId = 50;
        public const int MethodId = 10;
        public System.Collections.IDictionary m_arguments;
        public bool m_autoDelete;
        public bool m_durable;
        public bool m_exclusive;
        public bool m_nowait;
        public bool m_passive;
        public string m_queue;
        public ushort m_ticket;
        public QueueDeclare() { }
        public QueueDeclare(ushort initTicket, string initQueue, bool initPassive, bool initDurable, bool initExclusive, bool initAutoDelete, bool initNowait, System.Collections.IDictionary initArguments) { }
        public override bool HasContent { get { throw null; } }
        public override int ProtocolClassId { get { throw null; } }
        public override int ProtocolMethodId { get { throw null; } }
        public override string ProtocolMethodName { get { throw null; } }
        System.Collections.IDictionary RabbitMQ.Client.Framing.v0_8.IQueueDeclare.Arguments { get { throw null; } }
        bool RabbitMQ.Client.Framing.v0_8.IQueueDeclare.AutoDelete { get { throw null; } }
        bool RabbitMQ.Client.Framing.v0_8.IQueueDeclare.Durable { get { throw null; } }
        bool RabbitMQ.Client.Framing.v0_8.IQueueDeclare.Exclusive { get { throw null; } }
        bool RabbitMQ.Client.Framing.v0_8.IQueueDeclare.Nowait { get { throw null; } }
        bool RabbitMQ.Client.Framing.v0_8.IQueueDeclare.Passive { get { throw null; } }
        string RabbitMQ.Client.Framing.v0_8.IQueueDeclare.Queue { get { throw null; } }
        ushort RabbitMQ.Client.Framing.v0_8.IQueueDeclare.Ticket { get { throw null; } }
        public override void AppendArgumentDebugStringTo(System.Text.StringBuilder sb) { }
        public override void ReadArgumentsFrom(RabbitMQ.Client.Impl.MethodArgumentReader reader) { }
        public override void WriteArgumentsTo(RabbitMQ.Client.Impl.MethodArgumentWriter writer) { }
    }
    public partial class QueueDeclareOk : RabbitMQ.Client.Impl.MethodBase, RabbitMQ.Client.Framing.v0_8.IQueueDeclareOk, RabbitMQ.Client.IMethod
    {
        public const int ClassId = 50;
        public const int MethodId = 11;
        public uint m_consumerCount;
        public uint m_messageCount;
        public string m_queue;
        public QueueDeclareOk() { }
        public QueueDeclareOk(string initQueue, uint initMessageCount, uint initConsumerCount) { }
        public override bool HasContent { get { throw null; } }
        public override int ProtocolClassId { get { throw null; } }
        public override int ProtocolMethodId { get { throw null; } }
        public override string ProtocolMethodName { get { throw null; } }
        uint RabbitMQ.Client.Framing.v0_8.IQueueDeclareOk.ConsumerCount { get { throw null; } }
        uint RabbitMQ.Client.Framing.v0_8.IQueueDeclareOk.MessageCount { get { throw null; } }
        string RabbitMQ.Client.Framing.v0_8.IQueueDeclareOk.Queue { get { throw null; } }
        public override void AppendArgumentDebugStringTo(System.Text.StringBuilder sb) { }
        public override void ReadArgumentsFrom(RabbitMQ.Client.Impl.MethodArgumentReader reader) { }
        public override void WriteArgumentsTo(RabbitMQ.Client.Impl.MethodArgumentWriter writer) { }
    }
    public partial class QueueDelete : RabbitMQ.Client.Impl.MethodBase, RabbitMQ.Client.Framing.v0_8.IQueueDelete, RabbitMQ.Client.IMethod
    {
        public const int ClassId = 50;
        public const int MethodId = 40;
        public bool m_ifEmpty;
        public bool m_ifUnused;
        public bool m_nowait;
        public string m_queue;
        public ushort m_ticket;
        public QueueDelete() { }
        public QueueDelete(ushort initTicket, string initQueue, bool initIfUnused, bool initIfEmpty, bool initNowait) { }
        public override bool HasContent { get { throw null; } }
        public override int ProtocolClassId { get { throw null; } }
        public override int ProtocolMethodId { get { throw null; } }
        public override string ProtocolMethodName { get { throw null; } }
        bool RabbitMQ.Client.Framing.v0_8.IQueueDelete.IfEmpty { get { throw null; } }
        bool RabbitMQ.Client.Framing.v0_8.IQueueDelete.IfUnused { get { throw null; } }
        bool RabbitMQ.Client.Framing.v0_8.IQueueDelete.Nowait { get { throw null; } }
        string RabbitMQ.Client.Framing.v0_8.IQueueDelete.Queue { get { throw null; } }
        ushort RabbitMQ.Client.Framing.v0_8.IQueueDelete.Ticket { get { throw null; } }
        public override void AppendArgumentDebugStringTo(System.Text.StringBuilder sb) { }
        public override void ReadArgumentsFrom(RabbitMQ.Client.Impl.MethodArgumentReader reader) { }
        public override void WriteArgumentsTo(RabbitMQ.Client.Impl.MethodArgumentWriter writer) { }
    }
    public partial class QueueDeleteOk : RabbitMQ.Client.Impl.MethodBase, RabbitMQ.Client.Framing.v0_8.IQueueDeleteOk, RabbitMQ.Client.IMethod
    {
        public const int ClassId = 50;
        public const int MethodId = 41;
        public uint m_messageCount;
        public QueueDeleteOk() { }
        public QueueDeleteOk(uint initMessageCount) { }
        public override bool HasContent { get { throw null; } }
        public override int ProtocolClassId { get { throw null; } }
        public override int ProtocolMethodId { get { throw null; } }
        public override string ProtocolMethodName { get { throw null; } }
        uint RabbitMQ.Client.Framing.v0_8.IQueueDeleteOk.MessageCount { get { throw null; } }
        public override void AppendArgumentDebugStringTo(System.Text.StringBuilder sb) { }
        public override void ReadArgumentsFrom(RabbitMQ.Client.Impl.MethodArgumentReader reader) { }
        public override void WriteArgumentsTo(RabbitMQ.Client.Impl.MethodArgumentWriter writer) { }
    }
    public partial class QueuePurge : RabbitMQ.Client.Impl.MethodBase, RabbitMQ.Client.Framing.v0_8.IQueuePurge, RabbitMQ.Client.IMethod
    {
        public const int ClassId = 50;
        public const int MethodId = 30;
        public bool m_nowait;
        public string m_queue;
        public ushort m_ticket;
        public QueuePurge() { }
        public QueuePurge(ushort initTicket, string initQueue, bool initNowait) { }
        public override bool HasContent { get { throw null; } }
        public override int ProtocolClassId { get { throw null; } }
        public override int ProtocolMethodId { get { throw null; } }
        public override string ProtocolMethodName { get { throw null; } }
        bool RabbitMQ.Client.Framing.v0_8.IQueuePurge.Nowait { get { throw null; } }
        string RabbitMQ.Client.Framing.v0_8.IQueuePurge.Queue { get { throw null; } }
        ushort RabbitMQ.Client.Framing.v0_8.IQueuePurge.Ticket { get { throw null; } }
        public override void AppendArgumentDebugStringTo(System.Text.StringBuilder sb) { }
        public override void ReadArgumentsFrom(RabbitMQ.Client.Impl.MethodArgumentReader reader) { }
        public override void WriteArgumentsTo(RabbitMQ.Client.Impl.MethodArgumentWriter writer) { }
    }
    public partial class QueuePurgeOk : RabbitMQ.Client.Impl.MethodBase, RabbitMQ.Client.Framing.v0_8.IQueuePurgeOk, RabbitMQ.Client.IMethod
    {
        public const int ClassId = 50;
        public const int MethodId = 31;
        public uint m_messageCount;
        public QueuePurgeOk() { }
        public QueuePurgeOk(uint initMessageCount) { }
        public override bool HasContent { get { throw null; } }
        public override int ProtocolClassId { get { throw null; } }
        public override int ProtocolMethodId { get { throw null; } }
        public override string ProtocolMethodName { get { throw null; } }
        uint RabbitMQ.Client.Framing.v0_8.IQueuePurgeOk.MessageCount { get { throw null; } }
        public override void AppendArgumentDebugStringTo(System.Text.StringBuilder sb) { }
        public override void ReadArgumentsFrom(RabbitMQ.Client.Impl.MethodArgumentReader reader) { }
        public override void WriteArgumentsTo(RabbitMQ.Client.Impl.MethodArgumentWriter writer) { }
    }
    public partial class QueueUnbind : RabbitMQ.Client.Impl.MethodBase, RabbitMQ.Client.Framing.v0_8.IQueueUnbind, RabbitMQ.Client.IMethod
    {
        public const int ClassId = 50;
        public const int MethodId = 50;
        public System.Collections.IDictionary m_arguments;
        public string m_exchange;
        public string m_queue;
        public string m_routingKey;
        public ushort m_ticket;
        public QueueUnbind() { }
        public QueueUnbind(ushort initTicket, string initQueue, string initExchange, string initRoutingKey, System.Collections.IDictionary initArguments) { }
        public override bool HasContent { get { throw null; } }
        public override int ProtocolClassId { get { throw null; } }
        public override int ProtocolMethodId { get { throw null; } }
        public override string ProtocolMethodName { get { throw null; } }
        System.Collections.IDictionary RabbitMQ.Client.Framing.v0_8.IQueueUnbind.Arguments { get { throw null; } }
        string RabbitMQ.Client.Framing.v0_8.IQueueUnbind.Exchange { get { throw null; } }
        string RabbitMQ.Client.Framing.v0_8.IQueueUnbind.Queue { get { throw null; } }
        string RabbitMQ.Client.Framing.v0_8.IQueueUnbind.RoutingKey { get { throw null; } }
        ushort RabbitMQ.Client.Framing.v0_8.IQueueUnbind.Ticket { get { throw null; } }
        public override void AppendArgumentDebugStringTo(System.Text.StringBuilder sb) { }
        public override void ReadArgumentsFrom(RabbitMQ.Client.Impl.MethodArgumentReader reader) { }
        public override void WriteArgumentsTo(RabbitMQ.Client.Impl.MethodArgumentWriter writer) { }
    }
    public partial class QueueUnbindOk : RabbitMQ.Client.Impl.MethodBase, RabbitMQ.Client.Framing.v0_8.IQueueUnbindOk, RabbitMQ.Client.IMethod
    {
        public const int ClassId = 50;
        public const int MethodId = 51;
        public QueueUnbindOk() { }
        public override bool HasContent { get { throw null; } }
        public override int ProtocolClassId { get { throw null; } }
        public override int ProtocolMethodId { get { throw null; } }
        public override string ProtocolMethodName { get { throw null; } }
        public override void AppendArgumentDebugStringTo(System.Text.StringBuilder sb) { }
        public override void ReadArgumentsFrom(RabbitMQ.Client.Impl.MethodArgumentReader reader) { }
        public override void WriteArgumentsTo(RabbitMQ.Client.Impl.MethodArgumentWriter writer) { }
    }
    public partial class StreamCancel : RabbitMQ.Client.Impl.MethodBase, RabbitMQ.Client.Framing.v0_8.IStreamCancel, RabbitMQ.Client.IMethod
    {
        public const int ClassId = 80;
        public const int MethodId = 30;
        public string m_consumerTag;
        public bool m_nowait;
        public StreamCancel() { }
        public StreamCancel(string initConsumerTag, bool initNowait) { }
        public override bool HasContent { get { throw null; } }
        public override int ProtocolClassId { get { throw null; } }
        public override int ProtocolMethodId { get { throw null; } }
        public override string ProtocolMethodName { get { throw null; } }
        string RabbitMQ.Client.Framing.v0_8.IStreamCancel.ConsumerTag { get { throw null; } }
        bool RabbitMQ.Client.Framing.v0_8.IStreamCancel.Nowait { get { throw null; } }
        public override void AppendArgumentDebugStringTo(System.Text.StringBuilder sb) { }
        public override void ReadArgumentsFrom(RabbitMQ.Client.Impl.MethodArgumentReader reader) { }
        public override void WriteArgumentsTo(RabbitMQ.Client.Impl.MethodArgumentWriter writer) { }
    }
    public partial class StreamCancelOk : RabbitMQ.Client.Impl.MethodBase, RabbitMQ.Client.Framing.v0_8.IStreamCancelOk, RabbitMQ.Client.IMethod
    {
        public const int ClassId = 80;
        public const int MethodId = 31;
        public string m_consumerTag;
        public StreamCancelOk() { }
        public StreamCancelOk(string initConsumerTag) { }
        public override bool HasContent { get { throw null; } }
        public override int ProtocolClassId { get { throw null; } }
        public override int ProtocolMethodId { get { throw null; } }
        public override string ProtocolMethodName { get { throw null; } }
        string RabbitMQ.Client.Framing.v0_8.IStreamCancelOk.ConsumerTag { get { throw null; } }
        public override void AppendArgumentDebugStringTo(System.Text.StringBuilder sb) { }
        public override void ReadArgumentsFrom(RabbitMQ.Client.Impl.MethodArgumentReader reader) { }
        public override void WriteArgumentsTo(RabbitMQ.Client.Impl.MethodArgumentWriter writer) { }
    }
    public partial class StreamConsume : RabbitMQ.Client.Impl.MethodBase, RabbitMQ.Client.Framing.v0_8.IStreamConsume, RabbitMQ.Client.IMethod
    {
        public const int ClassId = 80;
        public const int MethodId = 20;
        public string m_consumerTag;
        public bool m_exclusive;
        public bool m_noLocal;
        public bool m_nowait;
        public string m_queue;
        public ushort m_ticket;
        public StreamConsume() { }
        public StreamConsume(ushort initTicket, string initQueue, string initConsumerTag, bool initNoLocal, bool initExclusive, bool initNowait) { }
        public override bool HasContent { get { throw null; } }
        public override int ProtocolClassId { get { throw null; } }
        public override int ProtocolMethodId { get { throw null; } }
        public override string ProtocolMethodName { get { throw null; } }
        string RabbitMQ.Client.Framing.v0_8.IStreamConsume.ConsumerTag { get { throw null; } }
        bool RabbitMQ.Client.Framing.v0_8.IStreamConsume.Exclusive { get { throw null; } }
        bool RabbitMQ.Client.Framing.v0_8.IStreamConsume.NoLocal { get { throw null; } }
        bool RabbitMQ.Client.Framing.v0_8.IStreamConsume.Nowait { get { throw null; } }
        string RabbitMQ.Client.Framing.v0_8.IStreamConsume.Queue { get { throw null; } }
        ushort RabbitMQ.Client.Framing.v0_8.IStreamConsume.Ticket { get { throw null; } }
        public override void AppendArgumentDebugStringTo(System.Text.StringBuilder sb) { }
        public override void ReadArgumentsFrom(RabbitMQ.Client.Impl.MethodArgumentReader reader) { }
        public override void WriteArgumentsTo(RabbitMQ.Client.Impl.MethodArgumentWriter writer) { }
    }
    public partial class StreamConsumeOk : RabbitMQ.Client.Impl.MethodBase, RabbitMQ.Client.Framing.v0_8.IStreamConsumeOk, RabbitMQ.Client.IMethod
    {
        public const int ClassId = 80;
        public const int MethodId = 21;
        public string m_consumerTag;
        public StreamConsumeOk() { }
        public StreamConsumeOk(string initConsumerTag) { }
        public override bool HasContent { get { throw null; } }
        public override int ProtocolClassId { get { throw null; } }
        public override int ProtocolMethodId { get { throw null; } }
        public override string ProtocolMethodName { get { throw null; } }
        string RabbitMQ.Client.Framing.v0_8.IStreamConsumeOk.ConsumerTag { get { throw null; } }
        public override void AppendArgumentDebugStringTo(System.Text.StringBuilder sb) { }
        public override void ReadArgumentsFrom(RabbitMQ.Client.Impl.MethodArgumentReader reader) { }
        public override void WriteArgumentsTo(RabbitMQ.Client.Impl.MethodArgumentWriter writer) { }
    }
    public partial class StreamDeliver : RabbitMQ.Client.Impl.MethodBase, RabbitMQ.Client.Framing.v0_8.IStreamDeliver, RabbitMQ.Client.IMethod
    {
        public const int ClassId = 80;
        public const int MethodId = 60;
        public string m_consumerTag;
        public ulong m_deliveryTag;
        public string m_exchange;
        public string m_queue;
        public StreamDeliver() { }
        public StreamDeliver(string initConsumerTag, ulong initDeliveryTag, string initExchange, string initQueue) { }
        public override bool HasContent { get { throw null; } }
        public override int ProtocolClassId { get { throw null; } }
        public override int ProtocolMethodId { get { throw null; } }
        public override string ProtocolMethodName { get { throw null; } }
        string RabbitMQ.Client.Framing.v0_8.IStreamDeliver.ConsumerTag { get { throw null; } }
        ulong RabbitMQ.Client.Framing.v0_8.IStreamDeliver.DeliveryTag { get { throw null; } }
        string RabbitMQ.Client.Framing.v0_8.IStreamDeliver.Exchange { get { throw null; } }
        string RabbitMQ.Client.Framing.v0_8.IStreamDeliver.Queue { get { throw null; } }
        public override void AppendArgumentDebugStringTo(System.Text.StringBuilder sb) { }
        public override void ReadArgumentsFrom(RabbitMQ.Client.Impl.MethodArgumentReader reader) { }
        public override void WriteArgumentsTo(RabbitMQ.Client.Impl.MethodArgumentWriter writer) { }
    }
    public partial class StreamPublish : RabbitMQ.Client.Impl.MethodBase, RabbitMQ.Client.Framing.v0_8.IStreamPublish, RabbitMQ.Client.IMethod
    {
        public const int ClassId = 80;
        public const int MethodId = 40;
        public string m_exchange;
        public bool m_immediate;
        public bool m_mandatory;
        public string m_routingKey;
        public ushort m_ticket;
        public StreamPublish() { }
        public StreamPublish(ushort initTicket, string initExchange, string initRoutingKey, bool initMandatory, bool initImmediate) { }
        public override bool HasContent { get { throw null; } }
        public override int ProtocolClassId { get { throw null; } }
        public override int ProtocolMethodId { get { throw null; } }
        public override string ProtocolMethodName { get { throw null; } }
        string RabbitMQ.Client.Framing.v0_8.IStreamPublish.Exchange { get { throw null; } }
        bool RabbitMQ.Client.Framing.v0_8.IStreamPublish.Immediate { get { throw null; } }
        bool RabbitMQ.Client.Framing.v0_8.IStreamPublish.Mandatory { get { throw null; } }
        string RabbitMQ.Client.Framing.v0_8.IStreamPublish.RoutingKey { get { throw null; } }
        ushort RabbitMQ.Client.Framing.v0_8.IStreamPublish.Ticket { get { throw null; } }
        public override void AppendArgumentDebugStringTo(System.Text.StringBuilder sb) { }
        public override void ReadArgumentsFrom(RabbitMQ.Client.Impl.MethodArgumentReader reader) { }
        public override void WriteArgumentsTo(RabbitMQ.Client.Impl.MethodArgumentWriter writer) { }
    }
    public partial class StreamQos : RabbitMQ.Client.Impl.MethodBase, RabbitMQ.Client.Framing.v0_8.IStreamQos, RabbitMQ.Client.IMethod
    {
        public const int ClassId = 80;
        public const int MethodId = 10;
        public uint m_consumeRate;
        public bool m_global;
        public ushort m_prefetchCount;
        public uint m_prefetchSize;
        public StreamQos() { }
        public StreamQos(uint initPrefetchSize, ushort initPrefetchCount, uint initConsumeRate, bool initGlobal) { }
        public override bool HasContent { get { throw null; } }
        public override int ProtocolClassId { get { throw null; } }
        public override int ProtocolMethodId { get { throw null; } }
        public override string ProtocolMethodName { get { throw null; } }
        uint RabbitMQ.Client.Framing.v0_8.IStreamQos.ConsumeRate { get { throw null; } }
        bool RabbitMQ.Client.Framing.v0_8.IStreamQos.Global { get { throw null; } }
        ushort RabbitMQ.Client.Framing.v0_8.IStreamQos.PrefetchCount { get { throw null; } }
        uint RabbitMQ.Client.Framing.v0_8.IStreamQos.PrefetchSize { get { throw null; } }
        public override void AppendArgumentDebugStringTo(System.Text.StringBuilder sb) { }
        public override void ReadArgumentsFrom(RabbitMQ.Client.Impl.MethodArgumentReader reader) { }
        public override void WriteArgumentsTo(RabbitMQ.Client.Impl.MethodArgumentWriter writer) { }
    }
    public partial class StreamQosOk : RabbitMQ.Client.Impl.MethodBase, RabbitMQ.Client.Framing.v0_8.IStreamQosOk, RabbitMQ.Client.IMethod
    {
        public const int ClassId = 80;
        public const int MethodId = 11;
        public StreamQosOk() { }
        public override bool HasContent { get { throw null; } }
        public override int ProtocolClassId { get { throw null; } }
        public override int ProtocolMethodId { get { throw null; } }
        public override string ProtocolMethodName { get { throw null; } }
        public override void AppendArgumentDebugStringTo(System.Text.StringBuilder sb) { }
        public override void ReadArgumentsFrom(RabbitMQ.Client.Impl.MethodArgumentReader reader) { }
        public override void WriteArgumentsTo(RabbitMQ.Client.Impl.MethodArgumentWriter writer) { }
    }
    public partial class StreamReturn : RabbitMQ.Client.Impl.MethodBase, RabbitMQ.Client.Framing.v0_8.IStreamReturn, RabbitMQ.Client.IMethod
    {
        public const int ClassId = 80;
        public const int MethodId = 50;
        public string m_exchange;
        public ushort m_replyCode;
        public string m_replyText;
        public string m_routingKey;
        public StreamReturn() { }
        public StreamReturn(ushort initReplyCode, string initReplyText, string initExchange, string initRoutingKey) { }
        public override bool HasContent { get { throw null; } }
        public override int ProtocolClassId { get { throw null; } }
        public override int ProtocolMethodId { get { throw null; } }
        public override string ProtocolMethodName { get { throw null; } }
        string RabbitMQ.Client.Framing.v0_8.IStreamReturn.Exchange { get { throw null; } }
        ushort RabbitMQ.Client.Framing.v0_8.IStreamReturn.ReplyCode { get { throw null; } }
        string RabbitMQ.Client.Framing.v0_8.IStreamReturn.ReplyText { get { throw null; } }
        string RabbitMQ.Client.Framing.v0_8.IStreamReturn.RoutingKey { get { throw null; } }
        public override void AppendArgumentDebugStringTo(System.Text.StringBuilder sb) { }
        public override void ReadArgumentsFrom(RabbitMQ.Client.Impl.MethodArgumentReader reader) { }
        public override void WriteArgumentsTo(RabbitMQ.Client.Impl.MethodArgumentWriter writer) { }
    }
    public partial class TestContent : RabbitMQ.Client.Impl.MethodBase, RabbitMQ.Client.Framing.v0_8.ITestContent, RabbitMQ.Client.IMethod
    {
        public const int ClassId = 120;
        public const int MethodId = 40;
        public TestContent() { }
        public override bool HasContent { get { throw null; } }
        public override int ProtocolClassId { get { throw null; } }
        public override int ProtocolMethodId { get { throw null; } }
        public override string ProtocolMethodName { get { throw null; } }
        public override void AppendArgumentDebugStringTo(System.Text.StringBuilder sb) { }
        public override void ReadArgumentsFrom(RabbitMQ.Client.Impl.MethodArgumentReader reader) { }
        public override void WriteArgumentsTo(RabbitMQ.Client.Impl.MethodArgumentWriter writer) { }
    }
    public partial class TestContentOk : RabbitMQ.Client.Impl.MethodBase, RabbitMQ.Client.Framing.v0_8.ITestContentOk, RabbitMQ.Client.IMethod
    {
        public const int ClassId = 120;
        public const int MethodId = 41;
        public uint m_contentChecksum;
        public TestContentOk() { }
        public TestContentOk(uint initContentChecksum) { }
        public override bool HasContent { get { throw null; } }
        public override int ProtocolClassId { get { throw null; } }
        public override int ProtocolMethodId { get { throw null; } }
        public override string ProtocolMethodName { get { throw null; } }
        uint RabbitMQ.Client.Framing.v0_8.ITestContentOk.ContentChecksum { get { throw null; } }
        public override void AppendArgumentDebugStringTo(System.Text.StringBuilder sb) { }
        public override void ReadArgumentsFrom(RabbitMQ.Client.Impl.MethodArgumentReader reader) { }
        public override void WriteArgumentsTo(RabbitMQ.Client.Impl.MethodArgumentWriter writer) { }
    }
    public partial class TestInteger : RabbitMQ.Client.Impl.MethodBase, RabbitMQ.Client.Framing.v0_8.ITestInteger, RabbitMQ.Client.IMethod
    {
        public const int ClassId = 120;
        public const int MethodId = 10;
        public byte m_integer1;
        public ushort m_integer2;
        public uint m_integer3;
        public ulong m_integer4;
        public byte m_operation;
        public TestInteger() { }
        public TestInteger(byte initInteger1, ushort initInteger2, uint initInteger3, ulong initInteger4, byte initOperation) { }
        public override bool HasContent { get { throw null; } }
        public override int ProtocolClassId { get { throw null; } }
        public override int ProtocolMethodId { get { throw null; } }
        public override string ProtocolMethodName { get { throw null; } }
        byte RabbitMQ.Client.Framing.v0_8.ITestInteger.Integer1 { get { throw null; } }
        ushort RabbitMQ.Client.Framing.v0_8.ITestInteger.Integer2 { get { throw null; } }
        uint RabbitMQ.Client.Framing.v0_8.ITestInteger.Integer3 { get { throw null; } }
        ulong RabbitMQ.Client.Framing.v0_8.ITestInteger.Integer4 { get { throw null; } }
        byte RabbitMQ.Client.Framing.v0_8.ITestInteger.Operation { get { throw null; } }
        public override void AppendArgumentDebugStringTo(System.Text.StringBuilder sb) { }
        public override void ReadArgumentsFrom(RabbitMQ.Client.Impl.MethodArgumentReader reader) { }
        public override void WriteArgumentsTo(RabbitMQ.Client.Impl.MethodArgumentWriter writer) { }
    }
    public partial class TestIntegerOk : RabbitMQ.Client.Impl.MethodBase, RabbitMQ.Client.Framing.v0_8.ITestIntegerOk, RabbitMQ.Client.IMethod
    {
        public const int ClassId = 120;
        public const int MethodId = 11;
        public ulong m_result;
        public TestIntegerOk() { }
        public TestIntegerOk(ulong initResult) { }
        public override bool HasContent { get { throw null; } }
        public override int ProtocolClassId { get { throw null; } }
        public override int ProtocolMethodId { get { throw null; } }
        public override string ProtocolMethodName { get { throw null; } }
        ulong RabbitMQ.Client.Framing.v0_8.ITestIntegerOk.Result { get { throw null; } }
        public override void AppendArgumentDebugStringTo(System.Text.StringBuilder sb) { }
        public override void ReadArgumentsFrom(RabbitMQ.Client.Impl.MethodArgumentReader reader) { }
        public override void WriteArgumentsTo(RabbitMQ.Client.Impl.MethodArgumentWriter writer) { }
    }
    public partial class TestString : RabbitMQ.Client.Impl.MethodBase, RabbitMQ.Client.Framing.v0_8.ITestString, RabbitMQ.Client.IMethod
    {
        public const int ClassId = 120;
        public const int MethodId = 20;
        public byte m_operation;
        public string m_string1;
        public byte[] m_string2;
        public TestString() { }
        public TestString(string initString1, byte[] initString2, byte initOperation) { }
        public override bool HasContent { get { throw null; } }
        public override int ProtocolClassId { get { throw null; } }
        public override int ProtocolMethodId { get { throw null; } }
        public override string ProtocolMethodName { get { throw null; } }
        byte RabbitMQ.Client.Framing.v0_8.ITestString.Operation { get { throw null; } }
        string RabbitMQ.Client.Framing.v0_8.ITestString.String1 { get { throw null; } }
        byte[] RabbitMQ.Client.Framing.v0_8.ITestString.String2 { get { throw null; } }
        public override void AppendArgumentDebugStringTo(System.Text.StringBuilder sb) { }
        public override void ReadArgumentsFrom(RabbitMQ.Client.Impl.MethodArgumentReader reader) { }
        public override void WriteArgumentsTo(RabbitMQ.Client.Impl.MethodArgumentWriter writer) { }
    }
    public partial class TestStringOk : RabbitMQ.Client.Impl.MethodBase, RabbitMQ.Client.Framing.v0_8.ITestStringOk, RabbitMQ.Client.IMethod
    {
        public const int ClassId = 120;
        public const int MethodId = 21;
        public byte[] m_result;
        public TestStringOk() { }
        public TestStringOk(byte[] initResult) { }
        public override bool HasContent { get { throw null; } }
        public override int ProtocolClassId { get { throw null; } }
        public override int ProtocolMethodId { get { throw null; } }
        public override string ProtocolMethodName { get { throw null; } }
        byte[] RabbitMQ.Client.Framing.v0_8.ITestStringOk.Result { get { throw null; } }
        public override void AppendArgumentDebugStringTo(System.Text.StringBuilder sb) { }
        public override void ReadArgumentsFrom(RabbitMQ.Client.Impl.MethodArgumentReader reader) { }
        public override void WriteArgumentsTo(RabbitMQ.Client.Impl.MethodArgumentWriter writer) { }
    }
    public partial class TestTable : RabbitMQ.Client.Impl.MethodBase, RabbitMQ.Client.Framing.v0_8.ITestTable, RabbitMQ.Client.IMethod
    {
        public const int ClassId = 120;
        public const int MethodId = 30;
        public byte m_integerOp;
        public byte m_stringOp;
        public System.Collections.IDictionary m_table;
        public TestTable() { }
        public TestTable(System.Collections.IDictionary initTable, byte initIntegerOp, byte initStringOp) { }
        public override bool HasContent { get { throw null; } }
        public override int ProtocolClassId { get { throw null; } }
        public override int ProtocolMethodId { get { throw null; } }
        public override string ProtocolMethodName { get { throw null; } }
        byte RabbitMQ.Client.Framing.v0_8.ITestTable.IntegerOp { get { throw null; } }
        byte RabbitMQ.Client.Framing.v0_8.ITestTable.StringOp { get { throw null; } }
        System.Collections.IDictionary RabbitMQ.Client.Framing.v0_8.ITestTable.Table { get { throw null; } }
        public override void AppendArgumentDebugStringTo(System.Text.StringBuilder sb) { }
        public override void ReadArgumentsFrom(RabbitMQ.Client.Impl.MethodArgumentReader reader) { }
        public override void WriteArgumentsTo(RabbitMQ.Client.Impl.MethodArgumentWriter writer) { }
    }
    public partial class TestTableOk : RabbitMQ.Client.Impl.MethodBase, RabbitMQ.Client.Framing.v0_8.ITestTableOk, RabbitMQ.Client.IMethod
    {
        public const int ClassId = 120;
        public const int MethodId = 31;
        public ulong m_integerResult;
        public byte[] m_stringResult;
        public TestTableOk() { }
        public TestTableOk(ulong initIntegerResult, byte[] initStringResult) { }
        public override bool HasContent { get { throw null; } }
        public override int ProtocolClassId { get { throw null; } }
        public override int ProtocolMethodId { get { throw null; } }
        public override string ProtocolMethodName { get { throw null; } }
        ulong RabbitMQ.Client.Framing.v0_8.ITestTableOk.IntegerResult { get { throw null; } }
        byte[] RabbitMQ.Client.Framing.v0_8.ITestTableOk.StringResult { get { throw null; } }
        public override void AppendArgumentDebugStringTo(System.Text.StringBuilder sb) { }
        public override void ReadArgumentsFrom(RabbitMQ.Client.Impl.MethodArgumentReader reader) { }
        public override void WriteArgumentsTo(RabbitMQ.Client.Impl.MethodArgumentWriter writer) { }
    }
    public partial class TunnelRequest : RabbitMQ.Client.Impl.MethodBase, RabbitMQ.Client.Framing.v0_8.ITunnelRequest, RabbitMQ.Client.IMethod
    {
        public const int ClassId = 110;
        public const int MethodId = 10;
        public System.Collections.IDictionary m_metaData;
        public TunnelRequest() { }
        public TunnelRequest(System.Collections.IDictionary initMetaData) { }
        public override bool HasContent { get { throw null; } }
        public override int ProtocolClassId { get { throw null; } }
        public override int ProtocolMethodId { get { throw null; } }
        public override string ProtocolMethodName { get { throw null; } }
        System.Collections.IDictionary RabbitMQ.Client.Framing.v0_8.ITunnelRequest.MetaData { get { throw null; } }
        public override void AppendArgumentDebugStringTo(System.Text.StringBuilder sb) { }
        public override void ReadArgumentsFrom(RabbitMQ.Client.Impl.MethodArgumentReader reader) { }
        public override void WriteArgumentsTo(RabbitMQ.Client.Impl.MethodArgumentWriter writer) { }
    }
    public partial class TxCommit : RabbitMQ.Client.Impl.MethodBase, RabbitMQ.Client.Framing.v0_8.ITxCommit, RabbitMQ.Client.IMethod
    {
        public const int ClassId = 90;
        public const int MethodId = 20;
        public TxCommit() { }
        public override bool HasContent { get { throw null; } }
        public override int ProtocolClassId { get { throw null; } }
        public override int ProtocolMethodId { get { throw null; } }
        public override string ProtocolMethodName { get { throw null; } }
        public override void AppendArgumentDebugStringTo(System.Text.StringBuilder sb) { }
        public override void ReadArgumentsFrom(RabbitMQ.Client.Impl.MethodArgumentReader reader) { }
        public override void WriteArgumentsTo(RabbitMQ.Client.Impl.MethodArgumentWriter writer) { }
    }
    public partial class TxCommitOk : RabbitMQ.Client.Impl.MethodBase, RabbitMQ.Client.Framing.v0_8.ITxCommitOk, RabbitMQ.Client.IMethod
    {
        public const int ClassId = 90;
        public const int MethodId = 21;
        public TxCommitOk() { }
        public override bool HasContent { get { throw null; } }
        public override int ProtocolClassId { get { throw null; } }
        public override int ProtocolMethodId { get { throw null; } }
        public override string ProtocolMethodName { get { throw null; } }
        public override void AppendArgumentDebugStringTo(System.Text.StringBuilder sb) { }
        public override void ReadArgumentsFrom(RabbitMQ.Client.Impl.MethodArgumentReader reader) { }
        public override void WriteArgumentsTo(RabbitMQ.Client.Impl.MethodArgumentWriter writer) { }
    }
    public partial class TxRollback : RabbitMQ.Client.Impl.MethodBase, RabbitMQ.Client.Framing.v0_8.ITxRollback, RabbitMQ.Client.IMethod
    {
        public const int ClassId = 90;
        public const int MethodId = 30;
        public TxRollback() { }
        public override bool HasContent { get { throw null; } }
        public override int ProtocolClassId { get { throw null; } }
        public override int ProtocolMethodId { get { throw null; } }
        public override string ProtocolMethodName { get { throw null; } }
        public override void AppendArgumentDebugStringTo(System.Text.StringBuilder sb) { }
        public override void ReadArgumentsFrom(RabbitMQ.Client.Impl.MethodArgumentReader reader) { }
        public override void WriteArgumentsTo(RabbitMQ.Client.Impl.MethodArgumentWriter writer) { }
    }
    public partial class TxRollbackOk : RabbitMQ.Client.Impl.MethodBase, RabbitMQ.Client.Framing.v0_8.ITxRollbackOk, RabbitMQ.Client.IMethod
    {
        public const int ClassId = 90;
        public const int MethodId = 31;
        public TxRollbackOk() { }
        public override bool HasContent { get { throw null; } }
        public override int ProtocolClassId { get { throw null; } }
        public override int ProtocolMethodId { get { throw null; } }
        public override string ProtocolMethodName { get { throw null; } }
        public override void AppendArgumentDebugStringTo(System.Text.StringBuilder sb) { }
        public override void ReadArgumentsFrom(RabbitMQ.Client.Impl.MethodArgumentReader reader) { }
        public override void WriteArgumentsTo(RabbitMQ.Client.Impl.MethodArgumentWriter writer) { }
    }
    public partial class TxSelect : RabbitMQ.Client.Impl.MethodBase, RabbitMQ.Client.Framing.v0_8.ITxSelect, RabbitMQ.Client.IMethod
    {
        public const int ClassId = 90;
        public const int MethodId = 10;
        public TxSelect() { }
        public override bool HasContent { get { throw null; } }
        public override int ProtocolClassId { get { throw null; } }
        public override int ProtocolMethodId { get { throw null; } }
        public override string ProtocolMethodName { get { throw null; } }
        public override void AppendArgumentDebugStringTo(System.Text.StringBuilder sb) { }
        public override void ReadArgumentsFrom(RabbitMQ.Client.Impl.MethodArgumentReader reader) { }
        public override void WriteArgumentsTo(RabbitMQ.Client.Impl.MethodArgumentWriter writer) { }
    }
    public partial class TxSelectOk : RabbitMQ.Client.Impl.MethodBase, RabbitMQ.Client.Framing.v0_8.ITxSelectOk, RabbitMQ.Client.IMethod
    {
        public const int ClassId = 90;
        public const int MethodId = 11;
        public TxSelectOk() { }
        public override bool HasContent { get { throw null; } }
        public override int ProtocolClassId { get { throw null; } }
        public override int ProtocolMethodId { get { throw null; } }
        public override string ProtocolMethodName { get { throw null; } }
        public override void AppendArgumentDebugStringTo(System.Text.StringBuilder sb) { }
        public override void ReadArgumentsFrom(RabbitMQ.Client.Impl.MethodArgumentReader reader) { }
        public override void WriteArgumentsTo(RabbitMQ.Client.Impl.MethodArgumentWriter writer) { }
    }
}
namespace RabbitMQ.Client.Framing.Impl.v0_8qpid
{
    public partial class AccessRequest : RabbitMQ.Client.Impl.MethodBase, RabbitMQ.Client.Framing.v0_8qpid.IAccessRequest, RabbitMQ.Client.IMethod
    {
        public const int ClassId = 30;
        public const int MethodId = 10;
        public bool m_active;
        public bool m_exclusive;
        public bool m_passive;
        public bool m_read;
        public string m_realm;
        public bool m_write;
        public AccessRequest() { }
        public AccessRequest(string initRealm, bool initExclusive, bool initPassive, bool initActive, bool initWrite, bool initRead) { }
        public override bool HasContent { get { throw null; } }
        public override int ProtocolClassId { get { throw null; } }
        public override int ProtocolMethodId { get { throw null; } }
        public override string ProtocolMethodName { get { throw null; } }
        bool RabbitMQ.Client.Framing.v0_8qpid.IAccessRequest.Active { get { throw null; } }
        bool RabbitMQ.Client.Framing.v0_8qpid.IAccessRequest.Exclusive { get { throw null; } }
        bool RabbitMQ.Client.Framing.v0_8qpid.IAccessRequest.Passive { get { throw null; } }
        bool RabbitMQ.Client.Framing.v0_8qpid.IAccessRequest.Read { get { throw null; } }
        string RabbitMQ.Client.Framing.v0_8qpid.IAccessRequest.Realm { get { throw null; } }
        bool RabbitMQ.Client.Framing.v0_8qpid.IAccessRequest.Write { get { throw null; } }
        public override void AppendArgumentDebugStringTo(System.Text.StringBuilder sb) { }
        public override void ReadArgumentsFrom(RabbitMQ.Client.Impl.MethodArgumentReader reader) { }
        public override void WriteArgumentsTo(RabbitMQ.Client.Impl.MethodArgumentWriter writer) { }
    }
    public partial class AccessRequestOk : RabbitMQ.Client.Impl.MethodBase, RabbitMQ.Client.Framing.v0_8qpid.IAccessRequestOk, RabbitMQ.Client.IMethod
    {
        public const int ClassId = 30;
        public const int MethodId = 11;
        public ushort m_ticket;
        public AccessRequestOk() { }
        public AccessRequestOk(ushort initTicket) { }
        public override bool HasContent { get { throw null; } }
        public override int ProtocolClassId { get { throw null; } }
        public override int ProtocolMethodId { get { throw null; } }
        public override string ProtocolMethodName { get { throw null; } }
        ushort RabbitMQ.Client.Framing.v0_8qpid.IAccessRequestOk.Ticket { get { throw null; } }
        public override void AppendArgumentDebugStringTo(System.Text.StringBuilder sb) { }
        public override void ReadArgumentsFrom(RabbitMQ.Client.Impl.MethodArgumentReader reader) { }
        public override void WriteArgumentsTo(RabbitMQ.Client.Impl.MethodArgumentWriter writer) { }
    }
    public partial class BasicAck : RabbitMQ.Client.Impl.MethodBase, RabbitMQ.Client.Framing.v0_8qpid.IBasicAck, RabbitMQ.Client.IMethod
    {
        public const int ClassId = 60;
        public const int MethodId = 80;
        public ulong m_deliveryTag;
        public bool m_multiple;
        public BasicAck() { }
        public BasicAck(ulong initDeliveryTag, bool initMultiple) { }
        public override bool HasContent { get { throw null; } }
        public override int ProtocolClassId { get { throw null; } }
        public override int ProtocolMethodId { get { throw null; } }
        public override string ProtocolMethodName { get { throw null; } }
        ulong RabbitMQ.Client.Framing.v0_8qpid.IBasicAck.DeliveryTag { get { throw null; } }
        bool RabbitMQ.Client.Framing.v0_8qpid.IBasicAck.Multiple { get { throw null; } }
        public override void AppendArgumentDebugStringTo(System.Text.StringBuilder sb) { }
        public override void ReadArgumentsFrom(RabbitMQ.Client.Impl.MethodArgumentReader reader) { }
        public override void WriteArgumentsTo(RabbitMQ.Client.Impl.MethodArgumentWriter writer) { }
    }
    public partial class BasicCancel : RabbitMQ.Client.Impl.MethodBase, RabbitMQ.Client.Framing.v0_8qpid.IBasicCancel, RabbitMQ.Client.IMethod
    {
        public const int ClassId = 60;
        public const int MethodId = 30;
        public string m_consumerTag;
        public bool m_nowait;
        public BasicCancel() { }
        public BasicCancel(string initConsumerTag, bool initNowait) { }
        public override bool HasContent { get { throw null; } }
        public override int ProtocolClassId { get { throw null; } }
        public override int ProtocolMethodId { get { throw null; } }
        public override string ProtocolMethodName { get { throw null; } }
        string RabbitMQ.Client.Framing.v0_8qpid.IBasicCancel.ConsumerTag { get { throw null; } }
        bool RabbitMQ.Client.Framing.v0_8qpid.IBasicCancel.Nowait { get { throw null; } }
        public override void AppendArgumentDebugStringTo(System.Text.StringBuilder sb) { }
        public override void ReadArgumentsFrom(RabbitMQ.Client.Impl.MethodArgumentReader reader) { }
        public override void WriteArgumentsTo(RabbitMQ.Client.Impl.MethodArgumentWriter writer) { }
    }
    public partial class BasicCancelOk : RabbitMQ.Client.Impl.MethodBase, RabbitMQ.Client.Framing.v0_8qpid.IBasicCancelOk, RabbitMQ.Client.IMethod
    {
        public const int ClassId = 60;
        public const int MethodId = 31;
        public string m_consumerTag;
        public BasicCancelOk() { }
        public BasicCancelOk(string initConsumerTag) { }
        public override bool HasContent { get { throw null; } }
        public override int ProtocolClassId { get { throw null; } }
        public override int ProtocolMethodId { get { throw null; } }
        public override string ProtocolMethodName { get { throw null; } }
        string RabbitMQ.Client.Framing.v0_8qpid.IBasicCancelOk.ConsumerTag { get { throw null; } }
        public override void AppendArgumentDebugStringTo(System.Text.StringBuilder sb) { }
        public override void ReadArgumentsFrom(RabbitMQ.Client.Impl.MethodArgumentReader reader) { }
        public override void WriteArgumentsTo(RabbitMQ.Client.Impl.MethodArgumentWriter writer) { }
    }
    public partial class BasicConsume : RabbitMQ.Client.Impl.MethodBase, RabbitMQ.Client.Framing.v0_8qpid.IBasicConsume, RabbitMQ.Client.IMethod
    {
        public const int ClassId = 60;
        public const int MethodId = 20;
        public System.Collections.IDictionary m_arguments;
        public string m_consumerTag;
        public bool m_exclusive;
        public bool m_noAck;
        public bool m_noLocal;
        public bool m_nowait;
        public string m_queue;
        public ushort m_ticket;
        public BasicConsume() { }
        public BasicConsume(ushort initTicket, string initQueue, string initConsumerTag, bool initNoLocal, bool initNoAck, bool initExclusive, bool initNowait, System.Collections.IDictionary initArguments) { }
        public override bool HasContent { get { throw null; } }
        public override int ProtocolClassId { get { throw null; } }
        public override int ProtocolMethodId { get { throw null; } }
        public override string ProtocolMethodName { get { throw null; } }
        System.Collections.IDictionary RabbitMQ.Client.Framing.v0_8qpid.IBasicConsume.Arguments { get { throw null; } }
        string RabbitMQ.Client.Framing.v0_8qpid.IBasicConsume.ConsumerTag { get { throw null; } }
        bool RabbitMQ.Client.Framing.v0_8qpid.IBasicConsume.Exclusive { get { throw null; } }
        bool RabbitMQ.Client.Framing.v0_8qpid.IBasicConsume.NoAck { get { throw null; } }
        bool RabbitMQ.Client.Framing.v0_8qpid.IBasicConsume.NoLocal { get { throw null; } }
        bool RabbitMQ.Client.Framing.v0_8qpid.IBasicConsume.Nowait { get { throw null; } }
        string RabbitMQ.Client.Framing.v0_8qpid.IBasicConsume.Queue { get { throw null; } }
        ushort RabbitMQ.Client.Framing.v0_8qpid.IBasicConsume.Ticket { get { throw null; } }
        public override void AppendArgumentDebugStringTo(System.Text.StringBuilder sb) { }
        public override void ReadArgumentsFrom(RabbitMQ.Client.Impl.MethodArgumentReader reader) { }
        public override void WriteArgumentsTo(RabbitMQ.Client.Impl.MethodArgumentWriter writer) { }
    }
    public partial class BasicConsumeOk : RabbitMQ.Client.Impl.MethodBase, RabbitMQ.Client.Framing.v0_8qpid.IBasicConsumeOk, RabbitMQ.Client.IMethod
    {
        public const int ClassId = 60;
        public const int MethodId = 21;
        public string m_consumerTag;
        public BasicConsumeOk() { }
        public BasicConsumeOk(string initConsumerTag) { }
        public override bool HasContent { get { throw null; } }
        public override int ProtocolClassId { get { throw null; } }
        public override int ProtocolMethodId { get { throw null; } }
        public override string ProtocolMethodName { get { throw null; } }
        string RabbitMQ.Client.Framing.v0_8qpid.IBasicConsumeOk.ConsumerTag { get { throw null; } }
        public override void AppendArgumentDebugStringTo(System.Text.StringBuilder sb) { }
        public override void ReadArgumentsFrom(RabbitMQ.Client.Impl.MethodArgumentReader reader) { }
        public override void WriteArgumentsTo(RabbitMQ.Client.Impl.MethodArgumentWriter writer) { }
    }
    public partial class BasicDeliver : RabbitMQ.Client.Impl.MethodBase, RabbitMQ.Client.Framing.v0_8qpid.IBasicDeliver, RabbitMQ.Client.IMethod
    {
        public const int ClassId = 60;
        public const int MethodId = 60;
        public string m_consumerTag;
        public ulong m_deliveryTag;
        public string m_exchange;
        public bool m_redelivered;
        public string m_routingKey;
        public BasicDeliver() { }
        public BasicDeliver(string initConsumerTag, ulong initDeliveryTag, bool initRedelivered, string initExchange, string initRoutingKey) { }
        public override bool HasContent { get { throw null; } }
        public override int ProtocolClassId { get { throw null; } }
        public override int ProtocolMethodId { get { throw null; } }
        public override string ProtocolMethodName { get { throw null; } }
        string RabbitMQ.Client.Framing.v0_8qpid.IBasicDeliver.ConsumerTag { get { throw null; } }
        ulong RabbitMQ.Client.Framing.v0_8qpid.IBasicDeliver.DeliveryTag { get { throw null; } }
        string RabbitMQ.Client.Framing.v0_8qpid.IBasicDeliver.Exchange { get { throw null; } }
        bool RabbitMQ.Client.Framing.v0_8qpid.IBasicDeliver.Redelivered { get { throw null; } }
        string RabbitMQ.Client.Framing.v0_8qpid.IBasicDeliver.RoutingKey { get { throw null; } }
        public override void AppendArgumentDebugStringTo(System.Text.StringBuilder sb) { }
        public override void ReadArgumentsFrom(RabbitMQ.Client.Impl.MethodArgumentReader reader) { }
        public override void WriteArgumentsTo(RabbitMQ.Client.Impl.MethodArgumentWriter writer) { }
    }
    public partial class BasicGet : RabbitMQ.Client.Impl.MethodBase, RabbitMQ.Client.Framing.v0_8qpid.IBasicGet, RabbitMQ.Client.IMethod
    {
        public const int ClassId = 60;
        public const int MethodId = 70;
        public bool m_noAck;
        public string m_queue;
        public ushort m_ticket;
        public BasicGet() { }
        public BasicGet(ushort initTicket, string initQueue, bool initNoAck) { }
        public override bool HasContent { get { throw null; } }
        public override int ProtocolClassId { get { throw null; } }
        public override int ProtocolMethodId { get { throw null; } }
        public override string ProtocolMethodName { get { throw null; } }
        bool RabbitMQ.Client.Framing.v0_8qpid.IBasicGet.NoAck { get { throw null; } }
        string RabbitMQ.Client.Framing.v0_8qpid.IBasicGet.Queue { get { throw null; } }
        ushort RabbitMQ.Client.Framing.v0_8qpid.IBasicGet.Ticket { get { throw null; } }
        public override void AppendArgumentDebugStringTo(System.Text.StringBuilder sb) { }
        public override void ReadArgumentsFrom(RabbitMQ.Client.Impl.MethodArgumentReader reader) { }
        public override void WriteArgumentsTo(RabbitMQ.Client.Impl.MethodArgumentWriter writer) { }
    }
    public partial class BasicGetEmpty : RabbitMQ.Client.Impl.MethodBase, RabbitMQ.Client.Framing.v0_8qpid.IBasicGetEmpty, RabbitMQ.Client.IMethod
    {
        public const int ClassId = 60;
        public const int MethodId = 72;
        public string m_clusterId;
        public BasicGetEmpty() { }
        public BasicGetEmpty(string initClusterId) { }
        public override bool HasContent { get { throw null; } }
        public override int ProtocolClassId { get { throw null; } }
        public override int ProtocolMethodId { get { throw null; } }
        public override string ProtocolMethodName { get { throw null; } }
        string RabbitMQ.Client.Framing.v0_8qpid.IBasicGetEmpty.ClusterId { get { throw null; } }
        public override void AppendArgumentDebugStringTo(System.Text.StringBuilder sb) { }
        public override void ReadArgumentsFrom(RabbitMQ.Client.Impl.MethodArgumentReader reader) { }
        public override void WriteArgumentsTo(RabbitMQ.Client.Impl.MethodArgumentWriter writer) { }
    }
    public partial class BasicGetOk : RabbitMQ.Client.Impl.MethodBase, RabbitMQ.Client.Framing.v0_8qpid.IBasicGetOk, RabbitMQ.Client.IMethod
    {
        public const int ClassId = 60;
        public const int MethodId = 71;
        public ulong m_deliveryTag;
        public string m_exchange;
        public uint m_messageCount;
        public bool m_redelivered;
        public string m_routingKey;
        public BasicGetOk() { }
        public BasicGetOk(ulong initDeliveryTag, bool initRedelivered, string initExchange, string initRoutingKey, uint initMessageCount) { }
        public override bool HasContent { get { throw null; } }
        public override int ProtocolClassId { get { throw null; } }
        public override int ProtocolMethodId { get { throw null; } }
        public override string ProtocolMethodName { get { throw null; } }
        ulong RabbitMQ.Client.Framing.v0_8qpid.IBasicGetOk.DeliveryTag { get { throw null; } }
        string RabbitMQ.Client.Framing.v0_8qpid.IBasicGetOk.Exchange { get { throw null; } }
        uint RabbitMQ.Client.Framing.v0_8qpid.IBasicGetOk.MessageCount { get { throw null; } }
        bool RabbitMQ.Client.Framing.v0_8qpid.IBasicGetOk.Redelivered { get { throw null; } }
        string RabbitMQ.Client.Framing.v0_8qpid.IBasicGetOk.RoutingKey { get { throw null; } }
        public override void AppendArgumentDebugStringTo(System.Text.StringBuilder sb) { }
        public override void ReadArgumentsFrom(RabbitMQ.Client.Impl.MethodArgumentReader reader) { }
        public override void WriteArgumentsTo(RabbitMQ.Client.Impl.MethodArgumentWriter writer) { }
    }
    public partial class BasicPublish : RabbitMQ.Client.Impl.MethodBase, RabbitMQ.Client.Framing.v0_8qpid.IBasicPublish, RabbitMQ.Client.IMethod
    {
        public const int ClassId = 60;
        public const int MethodId = 40;
        public string m_exchange;
        public bool m_immediate;
        public bool m_mandatory;
        public string m_routingKey;
        public ushort m_ticket;
        public BasicPublish() { }
        public BasicPublish(ushort initTicket, string initExchange, string initRoutingKey, bool initMandatory, bool initImmediate) { }
        public override bool HasContent { get { throw null; } }
        public override int ProtocolClassId { get { throw null; } }
        public override int ProtocolMethodId { get { throw null; } }
        public override string ProtocolMethodName { get { throw null; } }
        string RabbitMQ.Client.Framing.v0_8qpid.IBasicPublish.Exchange { get { throw null; } }
        bool RabbitMQ.Client.Framing.v0_8qpid.IBasicPublish.Immediate { get { throw null; } }
        bool RabbitMQ.Client.Framing.v0_8qpid.IBasicPublish.Mandatory { get { throw null; } }
        string RabbitMQ.Client.Framing.v0_8qpid.IBasicPublish.RoutingKey { get { throw null; } }
        ushort RabbitMQ.Client.Framing.v0_8qpid.IBasicPublish.Ticket { get { throw null; } }
        public override void AppendArgumentDebugStringTo(System.Text.StringBuilder sb) { }
        public override void ReadArgumentsFrom(RabbitMQ.Client.Impl.MethodArgumentReader reader) { }
        public override void WriteArgumentsTo(RabbitMQ.Client.Impl.MethodArgumentWriter writer) { }
    }
    public partial class BasicQos : RabbitMQ.Client.Impl.MethodBase, RabbitMQ.Client.Framing.v0_8qpid.IBasicQos, RabbitMQ.Client.IMethod
    {
        public const int ClassId = 60;
        public const int MethodId = 10;
        public bool m_global;
        public ushort m_prefetchCount;
        public uint m_prefetchSize;
        public BasicQos() { }
        public BasicQos(uint initPrefetchSize, ushort initPrefetchCount, bool initGlobal) { }
        public override bool HasContent { get { throw null; } }
        public override int ProtocolClassId { get { throw null; } }
        public override int ProtocolMethodId { get { throw null; } }
        public override string ProtocolMethodName { get { throw null; } }
        bool RabbitMQ.Client.Framing.v0_8qpid.IBasicQos.Global { get { throw null; } }
        ushort RabbitMQ.Client.Framing.v0_8qpid.IBasicQos.PrefetchCount { get { throw null; } }
        uint RabbitMQ.Client.Framing.v0_8qpid.IBasicQos.PrefetchSize { get { throw null; } }
        public override void AppendArgumentDebugStringTo(System.Text.StringBuilder sb) { }
        public override void ReadArgumentsFrom(RabbitMQ.Client.Impl.MethodArgumentReader reader) { }
        public override void WriteArgumentsTo(RabbitMQ.Client.Impl.MethodArgumentWriter writer) { }
    }
    public partial class BasicQosOk : RabbitMQ.Client.Impl.MethodBase, RabbitMQ.Client.Framing.v0_8qpid.IBasicQosOk, RabbitMQ.Client.IMethod
    {
        public const int ClassId = 60;
        public const int MethodId = 11;
        public BasicQosOk() { }
        public override bool HasContent { get { throw null; } }
        public override int ProtocolClassId { get { throw null; } }
        public override int ProtocolMethodId { get { throw null; } }
        public override string ProtocolMethodName { get { throw null; } }
        public override void AppendArgumentDebugStringTo(System.Text.StringBuilder sb) { }
        public override void ReadArgumentsFrom(RabbitMQ.Client.Impl.MethodArgumentReader reader) { }
        public override void WriteArgumentsTo(RabbitMQ.Client.Impl.MethodArgumentWriter writer) { }
    }
    public partial class BasicRecover : RabbitMQ.Client.Impl.MethodBase, RabbitMQ.Client.Framing.v0_8qpid.IBasicRecover, RabbitMQ.Client.IMethod
    {
        public const int ClassId = 60;
        public const int MethodId = 100;
        public bool m_requeue;
        public BasicRecover() { }
        public BasicRecover(bool initRequeue) { }
        public override bool HasContent { get { throw null; } }
        public override int ProtocolClassId { get { throw null; } }
        public override int ProtocolMethodId { get { throw null; } }
        public override string ProtocolMethodName { get { throw null; } }
        bool RabbitMQ.Client.Framing.v0_8qpid.IBasicRecover.Requeue { get { throw null; } }
        public override void AppendArgumentDebugStringTo(System.Text.StringBuilder sb) { }
        public override void ReadArgumentsFrom(RabbitMQ.Client.Impl.MethodArgumentReader reader) { }
        public override void WriteArgumentsTo(RabbitMQ.Client.Impl.MethodArgumentWriter writer) { }
    }
    public partial class BasicRecoverOk : RabbitMQ.Client.Impl.MethodBase, RabbitMQ.Client.Framing.v0_8qpid.IBasicRecoverOk, RabbitMQ.Client.IMethod
    {
        public const int ClassId = 60;
        public const int MethodId = 101;
        public BasicRecoverOk() { }
        public override bool HasContent { get { throw null; } }
        public override int ProtocolClassId { get { throw null; } }
        public override int ProtocolMethodId { get { throw null; } }
        public override string ProtocolMethodName { get { throw null; } }
        public override void AppendArgumentDebugStringTo(System.Text.StringBuilder sb) { }
        public override void ReadArgumentsFrom(RabbitMQ.Client.Impl.MethodArgumentReader reader) { }
        public override void WriteArgumentsTo(RabbitMQ.Client.Impl.MethodArgumentWriter writer) { }
    }
    public partial class BasicReject : RabbitMQ.Client.Impl.MethodBase, RabbitMQ.Client.Framing.v0_8qpid.IBasicReject, RabbitMQ.Client.IMethod
    {
        public const int ClassId = 60;
        public const int MethodId = 90;
        public ulong m_deliveryTag;
        public bool m_requeue;
        public BasicReject() { }
        public BasicReject(ulong initDeliveryTag, bool initRequeue) { }
        public override bool HasContent { get { throw null; } }
        public override int ProtocolClassId { get { throw null; } }
        public override int ProtocolMethodId { get { throw null; } }
        public override string ProtocolMethodName { get { throw null; } }
        ulong RabbitMQ.Client.Framing.v0_8qpid.IBasicReject.DeliveryTag { get { throw null; } }
        bool RabbitMQ.Client.Framing.v0_8qpid.IBasicReject.Requeue { get { throw null; } }
        public override void AppendArgumentDebugStringTo(System.Text.StringBuilder sb) { }
        public override void ReadArgumentsFrom(RabbitMQ.Client.Impl.MethodArgumentReader reader) { }
        public override void WriteArgumentsTo(RabbitMQ.Client.Impl.MethodArgumentWriter writer) { }
    }
    public partial class BasicReturn : RabbitMQ.Client.Impl.MethodBase, RabbitMQ.Client.Framing.v0_8qpid.IBasicReturn, RabbitMQ.Client.IMethod
    {
        public const int ClassId = 60;
        public const int MethodId = 50;
        public string m_exchange;
        public ushort m_replyCode;
        public string m_replyText;
        public string m_routingKey;
        public BasicReturn() { }
        public BasicReturn(ushort initReplyCode, string initReplyText, string initExchange, string initRoutingKey) { }
        public override bool HasContent { get { throw null; } }
        public override int ProtocolClassId { get { throw null; } }
        public override int ProtocolMethodId { get { throw null; } }
        public override string ProtocolMethodName { get { throw null; } }
        string RabbitMQ.Client.Framing.v0_8qpid.IBasicReturn.Exchange { get { throw null; } }
        ushort RabbitMQ.Client.Framing.v0_8qpid.IBasicReturn.ReplyCode { get { throw null; } }
        string RabbitMQ.Client.Framing.v0_8qpid.IBasicReturn.ReplyText { get { throw null; } }
        string RabbitMQ.Client.Framing.v0_8qpid.IBasicReturn.RoutingKey { get { throw null; } }
        public override void AppendArgumentDebugStringTo(System.Text.StringBuilder sb) { }
        public override void ReadArgumentsFrom(RabbitMQ.Client.Impl.MethodArgumentReader reader) { }
        public override void WriteArgumentsTo(RabbitMQ.Client.Impl.MethodArgumentWriter writer) { }
    }
    public partial class ChannelAlert : RabbitMQ.Client.Impl.MethodBase, RabbitMQ.Client.Framing.v0_8qpid.IChannelAlert, RabbitMQ.Client.IMethod
    {
        public const int ClassId = 20;
        public const int MethodId = 30;
        public System.Collections.IDictionary m_details;
        public ushort m_replyCode;
        public string m_replyText;
        public ChannelAlert() { }
        public ChannelAlert(ushort initReplyCode, string initReplyText, System.Collections.IDictionary initDetails) { }
        public override bool HasContent { get { throw null; } }
        public override int ProtocolClassId { get { throw null; } }
        public override int ProtocolMethodId { get { throw null; } }
        public override string ProtocolMethodName { get { throw null; } }
        System.Collections.IDictionary RabbitMQ.Client.Framing.v0_8qpid.IChannelAlert.Details { get { throw null; } }
        ushort RabbitMQ.Client.Framing.v0_8qpid.IChannelAlert.ReplyCode { get { throw null; } }
        string RabbitMQ.Client.Framing.v0_8qpid.IChannelAlert.ReplyText { get { throw null; } }
        public override void AppendArgumentDebugStringTo(System.Text.StringBuilder sb) { }
        public override void ReadArgumentsFrom(RabbitMQ.Client.Impl.MethodArgumentReader reader) { }
        public override void WriteArgumentsTo(RabbitMQ.Client.Impl.MethodArgumentWriter writer) { }
    }
    public partial class ChannelClose : RabbitMQ.Client.Impl.MethodBase, RabbitMQ.Client.Framing.v0_8qpid.IChannelClose, RabbitMQ.Client.IMethod
    {
        public const int ClassId = 20;
        public const int MethodId = 40;
        public ushort m_classId;
        public ushort m_methodId;
        public ushort m_replyCode;
        public string m_replyText;
        public ChannelClose() { }
        public ChannelClose(ushort initReplyCode, string initReplyText, ushort initClassId, ushort initMethodId) { }
        public override bool HasContent { get { throw null; } }
        public override int ProtocolClassId { get { throw null; } }
        public override int ProtocolMethodId { get { throw null; } }
        public override string ProtocolMethodName { get { throw null; } }
        ushort RabbitMQ.Client.Framing.v0_8qpid.IChannelClose.ClassId { get { throw null; } }
        ushort RabbitMQ.Client.Framing.v0_8qpid.IChannelClose.MethodId { get { throw null; } }
        ushort RabbitMQ.Client.Framing.v0_8qpid.IChannelClose.ReplyCode { get { throw null; } }
        string RabbitMQ.Client.Framing.v0_8qpid.IChannelClose.ReplyText { get { throw null; } }
        public override void AppendArgumentDebugStringTo(System.Text.StringBuilder sb) { }
        public override void ReadArgumentsFrom(RabbitMQ.Client.Impl.MethodArgumentReader reader) { }
        public override void WriteArgumentsTo(RabbitMQ.Client.Impl.MethodArgumentWriter writer) { }
    }
    public partial class ChannelCloseOk : RabbitMQ.Client.Impl.MethodBase, RabbitMQ.Client.Framing.v0_8qpid.IChannelCloseOk, RabbitMQ.Client.IMethod
    {
        public const int ClassId = 20;
        public const int MethodId = 41;
        public ChannelCloseOk() { }
        public override bool HasContent { get { throw null; } }
        public override int ProtocolClassId { get { throw null; } }
        public override int ProtocolMethodId { get { throw null; } }
        public override string ProtocolMethodName { get { throw null; } }
        public override void AppendArgumentDebugStringTo(System.Text.StringBuilder sb) { }
        public override void ReadArgumentsFrom(RabbitMQ.Client.Impl.MethodArgumentReader reader) { }
        public override void WriteArgumentsTo(RabbitMQ.Client.Impl.MethodArgumentWriter writer) { }
    }
    public partial class ChannelFlow : RabbitMQ.Client.Impl.MethodBase, RabbitMQ.Client.Framing.v0_8qpid.IChannelFlow, RabbitMQ.Client.IMethod
    {
        public const int ClassId = 20;
        public const int MethodId = 20;
        public bool m_active;
        public ChannelFlow() { }
        public ChannelFlow(bool initActive) { }
        public override bool HasContent { get { throw null; } }
        public override int ProtocolClassId { get { throw null; } }
        public override int ProtocolMethodId { get { throw null; } }
        public override string ProtocolMethodName { get { throw null; } }
        bool RabbitMQ.Client.Framing.v0_8qpid.IChannelFlow.Active { get { throw null; } }
        public override void AppendArgumentDebugStringTo(System.Text.StringBuilder sb) { }
        public override void ReadArgumentsFrom(RabbitMQ.Client.Impl.MethodArgumentReader reader) { }
        public override void WriteArgumentsTo(RabbitMQ.Client.Impl.MethodArgumentWriter writer) { }
    }
    public partial class ChannelFlowOk : RabbitMQ.Client.Impl.MethodBase, RabbitMQ.Client.Framing.v0_8qpid.IChannelFlowOk, RabbitMQ.Client.IMethod
    {
        public const int ClassId = 20;
        public const int MethodId = 21;
        public bool m_active;
        public ChannelFlowOk() { }
        public ChannelFlowOk(bool initActive) { }
        public override bool HasContent { get { throw null; } }
        public override int ProtocolClassId { get { throw null; } }
        public override int ProtocolMethodId { get { throw null; } }
        public override string ProtocolMethodName { get { throw null; } }
        bool RabbitMQ.Client.Framing.v0_8qpid.IChannelFlowOk.Active { get { throw null; } }
        public override void AppendArgumentDebugStringTo(System.Text.StringBuilder sb) { }
        public override void ReadArgumentsFrom(RabbitMQ.Client.Impl.MethodArgumentReader reader) { }
        public override void WriteArgumentsTo(RabbitMQ.Client.Impl.MethodArgumentWriter writer) { }
    }
    public partial class ChannelOpen : RabbitMQ.Client.Impl.MethodBase, RabbitMQ.Client.Framing.v0_8qpid.IChannelOpen, RabbitMQ.Client.IMethod
    {
        public const int ClassId = 20;
        public const int MethodId = 10;
        public string m_outOfBand;
        public ChannelOpen() { }
        public ChannelOpen(string initOutOfBand) { }
        public override bool HasContent { get { throw null; } }
        public override int ProtocolClassId { get { throw null; } }
        public override int ProtocolMethodId { get { throw null; } }
        public override string ProtocolMethodName { get { throw null; } }
        string RabbitMQ.Client.Framing.v0_8qpid.IChannelOpen.OutOfBand { get { throw null; } }
        public override void AppendArgumentDebugStringTo(System.Text.StringBuilder sb) { }
        public override void ReadArgumentsFrom(RabbitMQ.Client.Impl.MethodArgumentReader reader) { }
        public override void WriteArgumentsTo(RabbitMQ.Client.Impl.MethodArgumentWriter writer) { }
    }
    public partial class ChannelOpenOk : RabbitMQ.Client.Impl.MethodBase, RabbitMQ.Client.Framing.v0_8qpid.IChannelOpenOk, RabbitMQ.Client.IMethod
    {
        public const int ClassId = 20;
        public const int MethodId = 11;
        public ChannelOpenOk() { }
        public override bool HasContent { get { throw null; } }
        public override int ProtocolClassId { get { throw null; } }
        public override int ProtocolMethodId { get { throw null; } }
        public override string ProtocolMethodName { get { throw null; } }
        public override void AppendArgumentDebugStringTo(System.Text.StringBuilder sb) { }
        public override void ReadArgumentsFrom(RabbitMQ.Client.Impl.MethodArgumentReader reader) { }
        public override void WriteArgumentsTo(RabbitMQ.Client.Impl.MethodArgumentWriter writer) { }
    }
    public enum ClassId
    {
        Access = 30,
        Basic = 60,
        Channel = 20,
        Connection = 10,
        Dtx = 100,
        Exchange = 40,
        File = 70,
        Invalid = -1,
        Queue = 50,
        Stream = 80,
        Test = 120,
        Tunnel = 110,
        Tx = 90,
    }
    public partial class Connection : RabbitMQ.Client.Impl.ConnectionBase
    {
        public Connection(RabbitMQ.Client.ConnectionFactory factory, bool insist, RabbitMQ.Client.Impl.IFrameHandler frameHandler) : base (default(RabbitMQ.Client.ConnectionFactory), default(bool), default(RabbitMQ.Client.Impl.IFrameHandler)) { }
    }
    public partial class ConnectionClose : RabbitMQ.Client.Impl.MethodBase, RabbitMQ.Client.Framing.v0_8qpid.IConnectionClose, RabbitMQ.Client.IMethod
    {
        public const int ClassId = 10;
        public const int MethodId = 60;
        public ushort m_classId;
        public ushort m_methodId;
        public ushort m_replyCode;
        public string m_replyText;
        public ConnectionClose() { }
        public ConnectionClose(ushort initReplyCode, string initReplyText, ushort initClassId, ushort initMethodId) { }
        public override bool HasContent { get { throw null; } }
        public override int ProtocolClassId { get { throw null; } }
        public override int ProtocolMethodId { get { throw null; } }
        public override string ProtocolMethodName { get { throw null; } }
        ushort RabbitMQ.Client.Framing.v0_8qpid.IConnectionClose.ClassId { get { throw null; } }
        ushort RabbitMQ.Client.Framing.v0_8qpid.IConnectionClose.MethodId { get { throw null; } }
        ushort RabbitMQ.Client.Framing.v0_8qpid.IConnectionClose.ReplyCode { get { throw null; } }
        string RabbitMQ.Client.Framing.v0_8qpid.IConnectionClose.ReplyText { get { throw null; } }
        public override void AppendArgumentDebugStringTo(System.Text.StringBuilder sb) { }
        public override void ReadArgumentsFrom(RabbitMQ.Client.Impl.MethodArgumentReader reader) { }
        public override void WriteArgumentsTo(RabbitMQ.Client.Impl.MethodArgumentWriter writer) { }
    }
    public partial class ConnectionCloseOk : RabbitMQ.Client.Impl.MethodBase, RabbitMQ.Client.Framing.v0_8qpid.IConnectionCloseOk, RabbitMQ.Client.IMethod
    {
        public const int ClassId = 10;
        public const int MethodId = 61;
        public ConnectionCloseOk() { }
        public override bool HasContent { get { throw null; } }
        public override int ProtocolClassId { get { throw null; } }
        public override int ProtocolMethodId { get { throw null; } }
        public override string ProtocolMethodName { get { throw null; } }
        public override void AppendArgumentDebugStringTo(System.Text.StringBuilder sb) { }
        public override void ReadArgumentsFrom(RabbitMQ.Client.Impl.MethodArgumentReader reader) { }
        public override void WriteArgumentsTo(RabbitMQ.Client.Impl.MethodArgumentWriter writer) { }
    }
    public partial class ConnectionOpen : RabbitMQ.Client.Impl.MethodBase, RabbitMQ.Client.Framing.v0_8qpid.IConnectionOpen, RabbitMQ.Client.IMethod
    {
        public const int ClassId = 10;
        public const int MethodId = 40;
        public string m_capabilities;
        public bool m_insist;
        public string m_virtualHost;
        public ConnectionOpen() { }
        public ConnectionOpen(string initVirtualHost, string initCapabilities, bool initInsist) { }
        public override bool HasContent { get { throw null; } }
        public override int ProtocolClassId { get { throw null; } }
        public override int ProtocolMethodId { get { throw null; } }
        public override string ProtocolMethodName { get { throw null; } }
        string RabbitMQ.Client.Framing.v0_8qpid.IConnectionOpen.Capabilities { get { throw null; } }
        bool RabbitMQ.Client.Framing.v0_8qpid.IConnectionOpen.Insist { get { throw null; } }
        string RabbitMQ.Client.Framing.v0_8qpid.IConnectionOpen.VirtualHost { get { throw null; } }
        public override void AppendArgumentDebugStringTo(System.Text.StringBuilder sb) { }
        public override void ReadArgumentsFrom(RabbitMQ.Client.Impl.MethodArgumentReader reader) { }
        public override void WriteArgumentsTo(RabbitMQ.Client.Impl.MethodArgumentWriter writer) { }
    }
    public partial class ConnectionOpenOk : RabbitMQ.Client.Impl.MethodBase, RabbitMQ.Client.Framing.v0_8qpid.IConnectionOpenOk, RabbitMQ.Client.IMethod
    {
        public const int ClassId = 10;
        public const int MethodId = 41;
        public string m_knownHosts;
        public ConnectionOpenOk() { }
        public ConnectionOpenOk(string initKnownHosts) { }
        public override bool HasContent { get { throw null; } }
        public override int ProtocolClassId { get { throw null; } }
        public override int ProtocolMethodId { get { throw null; } }
        public override string ProtocolMethodName { get { throw null; } }
        string RabbitMQ.Client.Framing.v0_8qpid.IConnectionOpenOk.KnownHosts { get { throw null; } }
        public override void AppendArgumentDebugStringTo(System.Text.StringBuilder sb) { }
        public override void ReadArgumentsFrom(RabbitMQ.Client.Impl.MethodArgumentReader reader) { }
        public override void WriteArgumentsTo(RabbitMQ.Client.Impl.MethodArgumentWriter writer) { }
    }
    public partial class ConnectionRedirect : RabbitMQ.Client.Impl.MethodBase, RabbitMQ.Client.Framing.v0_8qpid.IConnectionRedirect, RabbitMQ.Client.IMethod
    {
        public const int ClassId = 10;
        public const int MethodId = 50;
        public string m_host;
        public string m_knownHosts;
        public ConnectionRedirect() { }
        public ConnectionRedirect(string initHost, string initKnownHosts) { }
        public override bool HasContent { get { throw null; } }
        public override int ProtocolClassId { get { throw null; } }
        public override int ProtocolMethodId { get { throw null; } }
        public override string ProtocolMethodName { get { throw null; } }
        string RabbitMQ.Client.Framing.v0_8qpid.IConnectionRedirect.Host { get { throw null; } }
        string RabbitMQ.Client.Framing.v0_8qpid.IConnectionRedirect.KnownHosts { get { throw null; } }
        public override void AppendArgumentDebugStringTo(System.Text.StringBuilder sb) { }
        public override void ReadArgumentsFrom(RabbitMQ.Client.Impl.MethodArgumentReader reader) { }
        public override void WriteArgumentsTo(RabbitMQ.Client.Impl.MethodArgumentWriter writer) { }
    }
    public partial class ConnectionSecure : RabbitMQ.Client.Impl.MethodBase, RabbitMQ.Client.Framing.v0_8qpid.IConnectionSecure, RabbitMQ.Client.IMethod
    {
        public const int ClassId = 10;
        public const int MethodId = 20;
        public byte[] m_challenge;
        public ConnectionSecure() { }
        public ConnectionSecure(byte[] initChallenge) { }
        public override bool HasContent { get { throw null; } }
        public override int ProtocolClassId { get { throw null; } }
        public override int ProtocolMethodId { get { throw null; } }
        public override string ProtocolMethodName { get { throw null; } }
        byte[] RabbitMQ.Client.Framing.v0_8qpid.IConnectionSecure.Challenge { get { throw null; } }
        public override void AppendArgumentDebugStringTo(System.Text.StringBuilder sb) { }
        public override void ReadArgumentsFrom(RabbitMQ.Client.Impl.MethodArgumentReader reader) { }
        public override void WriteArgumentsTo(RabbitMQ.Client.Impl.MethodArgumentWriter writer) { }
    }
    public partial class ConnectionSecureOk : RabbitMQ.Client.Impl.MethodBase, RabbitMQ.Client.Framing.v0_8qpid.IConnectionSecureOk, RabbitMQ.Client.IMethod
    {
        public const int ClassId = 10;
        public const int MethodId = 21;
        public byte[] m_response;
        public ConnectionSecureOk() { }
        public ConnectionSecureOk(byte[] initResponse) { }
        public override bool HasContent { get { throw null; } }
        public override int ProtocolClassId { get { throw null; } }
        public override int ProtocolMethodId { get { throw null; } }
        public override string ProtocolMethodName { get { throw null; } }
        byte[] RabbitMQ.Client.Framing.v0_8qpid.IConnectionSecureOk.Response { get { throw null; } }
        public override void AppendArgumentDebugStringTo(System.Text.StringBuilder sb) { }
        public override void ReadArgumentsFrom(RabbitMQ.Client.Impl.MethodArgumentReader reader) { }
        public override void WriteArgumentsTo(RabbitMQ.Client.Impl.MethodArgumentWriter writer) { }
    }
    public partial class ConnectionStart : RabbitMQ.Client.Impl.MethodBase, RabbitMQ.Client.Framing.v0_8qpid.IConnectionStart, RabbitMQ.Client.IMethod
    {
        public const int ClassId = 10;
        public const int MethodId = 10;
        public byte[] m_locales;
        public byte[] m_mechanisms;
        public System.Collections.IDictionary m_serverProperties;
        public byte m_versionMajor;
        public byte m_versionMinor;
        public ConnectionStart() { }
        public ConnectionStart(byte initVersionMajor, byte initVersionMinor, System.Collections.IDictionary initServerProperties, byte[] initMechanisms, byte[] initLocales) { }
        public override bool HasContent { get { throw null; } }
        public override int ProtocolClassId { get { throw null; } }
        public override int ProtocolMethodId { get { throw null; } }
        public override string ProtocolMethodName { get { throw null; } }
        byte[] RabbitMQ.Client.Framing.v0_8qpid.IConnectionStart.Locales { get { throw null; } }
        byte[] RabbitMQ.Client.Framing.v0_8qpid.IConnectionStart.Mechanisms { get { throw null; } }
        System.Collections.IDictionary RabbitMQ.Client.Framing.v0_8qpid.IConnectionStart.ServerProperties { get { throw null; } }
        byte RabbitMQ.Client.Framing.v0_8qpid.IConnectionStart.VersionMajor { get { throw null; } }
        byte RabbitMQ.Client.Framing.v0_8qpid.IConnectionStart.VersionMinor { get { throw null; } }
        public override void AppendArgumentDebugStringTo(System.Text.StringBuilder sb) { }
        public override void ReadArgumentsFrom(RabbitMQ.Client.Impl.MethodArgumentReader reader) { }
        public override void WriteArgumentsTo(RabbitMQ.Client.Impl.MethodArgumentWriter writer) { }
    }
    public partial class ConnectionStartOk : RabbitMQ.Client.Impl.MethodBase, RabbitMQ.Client.Framing.v0_8qpid.IConnectionStartOk, RabbitMQ.Client.IMethod
    {
        public const int ClassId = 10;
        public const int MethodId = 11;
        public System.Collections.IDictionary m_clientProperties;
        public string m_locale;
        public string m_mechanism;
        public byte[] m_response;
        public ConnectionStartOk() { }
        public ConnectionStartOk(System.Collections.IDictionary initClientProperties, string initMechanism, byte[] initResponse, string initLocale) { }
        public override bool HasContent { get { throw null; } }
        public override int ProtocolClassId { get { throw null; } }
        public override int ProtocolMethodId { get { throw null; } }
        public override string ProtocolMethodName { get { throw null; } }
        System.Collections.IDictionary RabbitMQ.Client.Framing.v0_8qpid.IConnectionStartOk.ClientProperties { get { throw null; } }
        string RabbitMQ.Client.Framing.v0_8qpid.IConnectionStartOk.Locale { get { throw null; } }
        string RabbitMQ.Client.Framing.v0_8qpid.IConnectionStartOk.Mechanism { get { throw null; } }
        byte[] RabbitMQ.Client.Framing.v0_8qpid.IConnectionStartOk.Response { get { throw null; } }
        public override void AppendArgumentDebugStringTo(System.Text.StringBuilder sb) { }
        public override void ReadArgumentsFrom(RabbitMQ.Client.Impl.MethodArgumentReader reader) { }
        public override void WriteArgumentsTo(RabbitMQ.Client.Impl.MethodArgumentWriter writer) { }
    }
    public partial class ConnectionTune : RabbitMQ.Client.Impl.MethodBase, RabbitMQ.Client.Framing.v0_8qpid.IConnectionTune, RabbitMQ.Client.IMethod
    {
        public const int ClassId = 10;
        public const int MethodId = 30;
        public ushort m_channelMax;
        public uint m_frameMax;
        public ushort m_heartbeat;
        public ConnectionTune() { }
        public ConnectionTune(ushort initChannelMax, uint initFrameMax, ushort initHeartbeat) { }
        public override bool HasContent { get { throw null; } }
        public override int ProtocolClassId { get { throw null; } }
        public override int ProtocolMethodId { get { throw null; } }
        public override string ProtocolMethodName { get { throw null; } }
        ushort RabbitMQ.Client.Framing.v0_8qpid.IConnectionTune.ChannelMax { get { throw null; } }
        uint RabbitMQ.Client.Framing.v0_8qpid.IConnectionTune.FrameMax { get { throw null; } }
        ushort RabbitMQ.Client.Framing.v0_8qpid.IConnectionTune.Heartbeat { get { throw null; } }
        public override void AppendArgumentDebugStringTo(System.Text.StringBuilder sb) { }
        public override void ReadArgumentsFrom(RabbitMQ.Client.Impl.MethodArgumentReader reader) { }
        public override void WriteArgumentsTo(RabbitMQ.Client.Impl.MethodArgumentWriter writer) { }
    }
    public partial class ConnectionTuneOk : RabbitMQ.Client.Impl.MethodBase, RabbitMQ.Client.Framing.v0_8qpid.IConnectionTuneOk, RabbitMQ.Client.IMethod
    {
        public const int ClassId = 10;
        public const int MethodId = 31;
        public ushort m_channelMax;
        public uint m_frameMax;
        public ushort m_heartbeat;
        public ConnectionTuneOk() { }
        public ConnectionTuneOk(ushort initChannelMax, uint initFrameMax, ushort initHeartbeat) { }
        public override bool HasContent { get { throw null; } }
        public override int ProtocolClassId { get { throw null; } }
        public override int ProtocolMethodId { get { throw null; } }
        public override string ProtocolMethodName { get { throw null; } }
        ushort RabbitMQ.Client.Framing.v0_8qpid.IConnectionTuneOk.ChannelMax { get { throw null; } }
        uint RabbitMQ.Client.Framing.v0_8qpid.IConnectionTuneOk.FrameMax { get { throw null; } }
        ushort RabbitMQ.Client.Framing.v0_8qpid.IConnectionTuneOk.Heartbeat { get { throw null; } }
        public override void AppendArgumentDebugStringTo(System.Text.StringBuilder sb) { }
        public override void ReadArgumentsFrom(RabbitMQ.Client.Impl.MethodArgumentReader reader) { }
        public override void WriteArgumentsTo(RabbitMQ.Client.Impl.MethodArgumentWriter writer) { }
    }
    public partial class DtxSelect : RabbitMQ.Client.Impl.MethodBase, RabbitMQ.Client.Framing.v0_8qpid.IDtxSelect, RabbitMQ.Client.IMethod
    {
        public const int ClassId = 100;
        public const int MethodId = 10;
        public DtxSelect() { }
        public override bool HasContent { get { throw null; } }
        public override int ProtocolClassId { get { throw null; } }
        public override int ProtocolMethodId { get { throw null; } }
        public override string ProtocolMethodName { get { throw null; } }
        public override void AppendArgumentDebugStringTo(System.Text.StringBuilder sb) { }
        public override void ReadArgumentsFrom(RabbitMQ.Client.Impl.MethodArgumentReader reader) { }
        public override void WriteArgumentsTo(RabbitMQ.Client.Impl.MethodArgumentWriter writer) { }
    }
    public partial class DtxSelectOk : RabbitMQ.Client.Impl.MethodBase, RabbitMQ.Client.Framing.v0_8qpid.IDtxSelectOk, RabbitMQ.Client.IMethod
    {
        public const int ClassId = 100;
        public const int MethodId = 11;
        public DtxSelectOk() { }
        public override bool HasContent { get { throw null; } }
        public override int ProtocolClassId { get { throw null; } }
        public override int ProtocolMethodId { get { throw null; } }
        public override string ProtocolMethodName { get { throw null; } }
        public override void AppendArgumentDebugStringTo(System.Text.StringBuilder sb) { }
        public override void ReadArgumentsFrom(RabbitMQ.Client.Impl.MethodArgumentReader reader) { }
        public override void WriteArgumentsTo(RabbitMQ.Client.Impl.MethodArgumentWriter writer) { }
    }
    public partial class DtxStart : RabbitMQ.Client.Impl.MethodBase, RabbitMQ.Client.Framing.v0_8qpid.IDtxStart, RabbitMQ.Client.IMethod
    {
        public const int ClassId = 100;
        public const int MethodId = 20;
        public string m_dtxIdentifier;
        public DtxStart() { }
        public DtxStart(string initDtxIdentifier) { }
        public override bool HasContent { get { throw null; } }
        public override int ProtocolClassId { get { throw null; } }
        public override int ProtocolMethodId { get { throw null; } }
        public override string ProtocolMethodName { get { throw null; } }
        string RabbitMQ.Client.Framing.v0_8qpid.IDtxStart.DtxIdentifier { get { throw null; } }
        public override void AppendArgumentDebugStringTo(System.Text.StringBuilder sb) { }
        public override void ReadArgumentsFrom(RabbitMQ.Client.Impl.MethodArgumentReader reader) { }
        public override void WriteArgumentsTo(RabbitMQ.Client.Impl.MethodArgumentWriter writer) { }
    }
    public partial class DtxStartOk : RabbitMQ.Client.Impl.MethodBase, RabbitMQ.Client.Framing.v0_8qpid.IDtxStartOk, RabbitMQ.Client.IMethod
    {
        public const int ClassId = 100;
        public const int MethodId = 21;
        public DtxStartOk() { }
        public override bool HasContent { get { throw null; } }
        public override int ProtocolClassId { get { throw null; } }
        public override int ProtocolMethodId { get { throw null; } }
        public override string ProtocolMethodName { get { throw null; } }
        public override void AppendArgumentDebugStringTo(System.Text.StringBuilder sb) { }
        public override void ReadArgumentsFrom(RabbitMQ.Client.Impl.MethodArgumentReader reader) { }
        public override void WriteArgumentsTo(RabbitMQ.Client.Impl.MethodArgumentWriter writer) { }
    }
    public partial class ExchangeBound : RabbitMQ.Client.Impl.MethodBase, RabbitMQ.Client.Framing.v0_8qpid.IExchangeBound, RabbitMQ.Client.IMethod
    {
        public const int ClassId = 40;
        public const int MethodId = 22;
        public string m_exchange;
        public string m_queue;
        public string m_routingKey;
        public ExchangeBound() { }
        public ExchangeBound(string initExchange, string initRoutingKey, string initQueue) { }
        public override bool HasContent { get { throw null; } }
        public override int ProtocolClassId { get { throw null; } }
        public override int ProtocolMethodId { get { throw null; } }
        public override string ProtocolMethodName { get { throw null; } }
        string RabbitMQ.Client.Framing.v0_8qpid.IExchangeBound.Exchange { get { throw null; } }
        string RabbitMQ.Client.Framing.v0_8qpid.IExchangeBound.Queue { get { throw null; } }
        string RabbitMQ.Client.Framing.v0_8qpid.IExchangeBound.RoutingKey { get { throw null; } }
        public override void AppendArgumentDebugStringTo(System.Text.StringBuilder sb) { }
        public override void ReadArgumentsFrom(RabbitMQ.Client.Impl.MethodArgumentReader reader) { }
        public override void WriteArgumentsTo(RabbitMQ.Client.Impl.MethodArgumentWriter writer) { }
    }
    public partial class ExchangeBoundOk : RabbitMQ.Client.Impl.MethodBase, RabbitMQ.Client.Framing.v0_8qpid.IExchangeBoundOk, RabbitMQ.Client.IMethod
    {
        public const int ClassId = 40;
        public const int MethodId = 23;
        public ushort m_replyCode;
        public string m_replyText;
        public ExchangeBoundOk() { }
        public ExchangeBoundOk(ushort initReplyCode, string initReplyText) { }
        public override bool HasContent { get { throw null; } }
        public override int ProtocolClassId { get { throw null; } }
        public override int ProtocolMethodId { get { throw null; } }
        public override string ProtocolMethodName { get { throw null; } }
        ushort RabbitMQ.Client.Framing.v0_8qpid.IExchangeBoundOk.ReplyCode { get { throw null; } }
        string RabbitMQ.Client.Framing.v0_8qpid.IExchangeBoundOk.ReplyText { get { throw null; } }
        public override void AppendArgumentDebugStringTo(System.Text.StringBuilder sb) { }
        public override void ReadArgumentsFrom(RabbitMQ.Client.Impl.MethodArgumentReader reader) { }
        public override void WriteArgumentsTo(RabbitMQ.Client.Impl.MethodArgumentWriter writer) { }
    }
    public partial class ExchangeDeclare : RabbitMQ.Client.Impl.MethodBase, RabbitMQ.Client.Framing.v0_8qpid.IExchangeDeclare, RabbitMQ.Client.IMethod
    {
        public const int ClassId = 40;
        public const int MethodId = 10;
        public System.Collections.IDictionary m_arguments;
        public bool m_autoDelete;
        public bool m_durable;
        public string m_exchange;
        public bool m_internal;
        public bool m_nowait;
        public bool m_passive;
        public ushort m_ticket;
        public string m_type;
        public ExchangeDeclare() { }
        public ExchangeDeclare(ushort initTicket, string initExchange, string initType, bool initPassive, bool initDurable, bool initAutoDelete, bool initInternal, bool initNowait, System.Collections.IDictionary initArguments) { }
        public override bool HasContent { get { throw null; } }
        public override int ProtocolClassId { get { throw null; } }
        public override int ProtocolMethodId { get { throw null; } }
        public override string ProtocolMethodName { get { throw null; } }
        System.Collections.IDictionary RabbitMQ.Client.Framing.v0_8qpid.IExchangeDeclare.Arguments { get { throw null; } }
        bool RabbitMQ.Client.Framing.v0_8qpid.IExchangeDeclare.AutoDelete { get { throw null; } }
        bool RabbitMQ.Client.Framing.v0_8qpid.IExchangeDeclare.Durable { get { throw null; } }
        string RabbitMQ.Client.Framing.v0_8qpid.IExchangeDeclare.Exchange { get { throw null; } }
        bool RabbitMQ.Client.Framing.v0_8qpid.IExchangeDeclare.Internal { get { throw null; } }
        bool RabbitMQ.Client.Framing.v0_8qpid.IExchangeDeclare.Nowait { get { throw null; } }
        bool RabbitMQ.Client.Framing.v0_8qpid.IExchangeDeclare.Passive { get { throw null; } }
        ushort RabbitMQ.Client.Framing.v0_8qpid.IExchangeDeclare.Ticket { get { throw null; } }
        string RabbitMQ.Client.Framing.v0_8qpid.IExchangeDeclare.Type { get { throw null; } }
        public override void AppendArgumentDebugStringTo(System.Text.StringBuilder sb) { }
        public override void ReadArgumentsFrom(RabbitMQ.Client.Impl.MethodArgumentReader reader) { }
        public override void WriteArgumentsTo(RabbitMQ.Client.Impl.MethodArgumentWriter writer) { }
    }
    public partial class ExchangeDeclareOk : RabbitMQ.Client.Impl.MethodBase, RabbitMQ.Client.Framing.v0_8qpid.IExchangeDeclareOk, RabbitMQ.Client.IMethod
    {
        public const int ClassId = 40;
        public const int MethodId = 11;
        public ExchangeDeclareOk() { }
        public override bool HasContent { get { throw null; } }
        public override int ProtocolClassId { get { throw null; } }
        public override int ProtocolMethodId { get { throw null; } }
        public override string ProtocolMethodName { get { throw null; } }
        public override void AppendArgumentDebugStringTo(System.Text.StringBuilder sb) { }
        public override void ReadArgumentsFrom(RabbitMQ.Client.Impl.MethodArgumentReader reader) { }
        public override void WriteArgumentsTo(RabbitMQ.Client.Impl.MethodArgumentWriter writer) { }
    }
    public partial class ExchangeDelete : RabbitMQ.Client.Impl.MethodBase, RabbitMQ.Client.Framing.v0_8qpid.IExchangeDelete, RabbitMQ.Client.IMethod
    {
        public const int ClassId = 40;
        public const int MethodId = 20;
        public string m_exchange;
        public bool m_ifUnused;
        public bool m_nowait;
        public ushort m_ticket;
        public ExchangeDelete() { }
        public ExchangeDelete(ushort initTicket, string initExchange, bool initIfUnused, bool initNowait) { }
        public override bool HasContent { get { throw null; } }
        public override int ProtocolClassId { get { throw null; } }
        public override int ProtocolMethodId { get { throw null; } }
        public override string ProtocolMethodName { get { throw null; } }
        string RabbitMQ.Client.Framing.v0_8qpid.IExchangeDelete.Exchange { get { throw null; } }
        bool RabbitMQ.Client.Framing.v0_8qpid.IExchangeDelete.IfUnused { get { throw null; } }
        bool RabbitMQ.Client.Framing.v0_8qpid.IExchangeDelete.Nowait { get { throw null; } }
        ushort RabbitMQ.Client.Framing.v0_8qpid.IExchangeDelete.Ticket { get { throw null; } }
        public override void AppendArgumentDebugStringTo(System.Text.StringBuilder sb) { }
        public override void ReadArgumentsFrom(RabbitMQ.Client.Impl.MethodArgumentReader reader) { }
        public override void WriteArgumentsTo(RabbitMQ.Client.Impl.MethodArgumentWriter writer) { }
    }
    public partial class ExchangeDeleteOk : RabbitMQ.Client.Impl.MethodBase, RabbitMQ.Client.Framing.v0_8qpid.IExchangeDeleteOk, RabbitMQ.Client.IMethod
    {
        public const int ClassId = 40;
        public const int MethodId = 21;
        public ExchangeDeleteOk() { }
        public override bool HasContent { get { throw null; } }
        public override int ProtocolClassId { get { throw null; } }
        public override int ProtocolMethodId { get { throw null; } }
        public override string ProtocolMethodName { get { throw null; } }
        public override void AppendArgumentDebugStringTo(System.Text.StringBuilder sb) { }
        public override void ReadArgumentsFrom(RabbitMQ.Client.Impl.MethodArgumentReader reader) { }
        public override void WriteArgumentsTo(RabbitMQ.Client.Impl.MethodArgumentWriter writer) { }
    }
    public partial class FileAck : RabbitMQ.Client.Impl.MethodBase, RabbitMQ.Client.Framing.v0_8qpid.IFileAck, RabbitMQ.Client.IMethod
    {
        public const int ClassId = 70;
        public const int MethodId = 90;
        public ulong m_deliveryTag;
        public bool m_multiple;
        public FileAck() { }
        public FileAck(ulong initDeliveryTag, bool initMultiple) { }
        public override bool HasContent { get { throw null; } }
        public override int ProtocolClassId { get { throw null; } }
        public override int ProtocolMethodId { get { throw null; } }
        public override string ProtocolMethodName { get { throw null; } }
        ulong RabbitMQ.Client.Framing.v0_8qpid.IFileAck.DeliveryTag { get { throw null; } }
        bool RabbitMQ.Client.Framing.v0_8qpid.IFileAck.Multiple { get { throw null; } }
        public override void AppendArgumentDebugStringTo(System.Text.StringBuilder sb) { }
        public override void ReadArgumentsFrom(RabbitMQ.Client.Impl.MethodArgumentReader reader) { }
        public override void WriteArgumentsTo(RabbitMQ.Client.Impl.MethodArgumentWriter writer) { }
    }
    public partial class FileCancel : RabbitMQ.Client.Impl.MethodBase, RabbitMQ.Client.Framing.v0_8qpid.IFileCancel, RabbitMQ.Client.IMethod
    {
        public const int ClassId = 70;
        public const int MethodId = 30;
        public string m_consumerTag;
        public bool m_nowait;
        public FileCancel() { }
        public FileCancel(string initConsumerTag, bool initNowait) { }
        public override bool HasContent { get { throw null; } }
        public override int ProtocolClassId { get { throw null; } }
        public override int ProtocolMethodId { get { throw null; } }
        public override string ProtocolMethodName { get { throw null; } }
        string RabbitMQ.Client.Framing.v0_8qpid.IFileCancel.ConsumerTag { get { throw null; } }
        bool RabbitMQ.Client.Framing.v0_8qpid.IFileCancel.Nowait { get { throw null; } }
        public override void AppendArgumentDebugStringTo(System.Text.StringBuilder sb) { }
        public override void ReadArgumentsFrom(RabbitMQ.Client.Impl.MethodArgumentReader reader) { }
        public override void WriteArgumentsTo(RabbitMQ.Client.Impl.MethodArgumentWriter writer) { }
    }
    public partial class FileCancelOk : RabbitMQ.Client.Impl.MethodBase, RabbitMQ.Client.Framing.v0_8qpid.IFileCancelOk, RabbitMQ.Client.IMethod
    {
        public const int ClassId = 70;
        public const int MethodId = 31;
        public string m_consumerTag;
        public FileCancelOk() { }
        public FileCancelOk(string initConsumerTag) { }
        public override bool HasContent { get { throw null; } }
        public override int ProtocolClassId { get { throw null; } }
        public override int ProtocolMethodId { get { throw null; } }
        public override string ProtocolMethodName { get { throw null; } }
        string RabbitMQ.Client.Framing.v0_8qpid.IFileCancelOk.ConsumerTag { get { throw null; } }
        public override void AppendArgumentDebugStringTo(System.Text.StringBuilder sb) { }
        public override void ReadArgumentsFrom(RabbitMQ.Client.Impl.MethodArgumentReader reader) { }
        public override void WriteArgumentsTo(RabbitMQ.Client.Impl.MethodArgumentWriter writer) { }
    }
    public partial class FileConsume : RabbitMQ.Client.Impl.MethodBase, RabbitMQ.Client.Framing.v0_8qpid.IFileConsume, RabbitMQ.Client.IMethod
    {
        public const int ClassId = 70;
        public const int MethodId = 20;
        public string m_consumerTag;
        public bool m_exclusive;
        public bool m_noAck;
        public bool m_noLocal;
        public bool m_nowait;
        public string m_queue;
        public ushort m_ticket;
        public FileConsume() { }
        public FileConsume(ushort initTicket, string initQueue, string initConsumerTag, bool initNoLocal, bool initNoAck, bool initExclusive, bool initNowait) { }
        public override bool HasContent { get { throw null; } }
        public override int ProtocolClassId { get { throw null; } }
        public override int ProtocolMethodId { get { throw null; } }
        public override string ProtocolMethodName { get { throw null; } }
        string RabbitMQ.Client.Framing.v0_8qpid.IFileConsume.ConsumerTag { get { throw null; } }
        bool RabbitMQ.Client.Framing.v0_8qpid.IFileConsume.Exclusive { get { throw null; } }
        bool RabbitMQ.Client.Framing.v0_8qpid.IFileConsume.NoAck { get { throw null; } }
        bool RabbitMQ.Client.Framing.v0_8qpid.IFileConsume.NoLocal { get { throw null; } }
        bool RabbitMQ.Client.Framing.v0_8qpid.IFileConsume.Nowait { get { throw null; } }
        string RabbitMQ.Client.Framing.v0_8qpid.IFileConsume.Queue { get { throw null; } }
        ushort RabbitMQ.Client.Framing.v0_8qpid.IFileConsume.Ticket { get { throw null; } }
        public override void AppendArgumentDebugStringTo(System.Text.StringBuilder sb) { }
        public override void ReadArgumentsFrom(RabbitMQ.Client.Impl.MethodArgumentReader reader) { }
        public override void WriteArgumentsTo(RabbitMQ.Client.Impl.MethodArgumentWriter writer) { }
    }
    public partial class FileConsumeOk : RabbitMQ.Client.Impl.MethodBase, RabbitMQ.Client.Framing.v0_8qpid.IFileConsumeOk, RabbitMQ.Client.IMethod
    {
        public const int ClassId = 70;
        public const int MethodId = 21;
        public string m_consumerTag;
        public FileConsumeOk() { }
        public FileConsumeOk(string initConsumerTag) { }
        public override bool HasContent { get { throw null; } }
        public override int ProtocolClassId { get { throw null; } }
        public override int ProtocolMethodId { get { throw null; } }
        public override string ProtocolMethodName { get { throw null; } }
        string RabbitMQ.Client.Framing.v0_8qpid.IFileConsumeOk.ConsumerTag { get { throw null; } }
        public override void AppendArgumentDebugStringTo(System.Text.StringBuilder sb) { }
        public override void ReadArgumentsFrom(RabbitMQ.Client.Impl.MethodArgumentReader reader) { }
        public override void WriteArgumentsTo(RabbitMQ.Client.Impl.MethodArgumentWriter writer) { }
    }
    public partial class FileDeliver : RabbitMQ.Client.Impl.MethodBase, RabbitMQ.Client.Framing.v0_8qpid.IFileDeliver, RabbitMQ.Client.IMethod
    {
        public const int ClassId = 70;
        public const int MethodId = 80;
        public string m_consumerTag;
        public ulong m_deliveryTag;
        public string m_exchange;
        public string m_identifier;
        public bool m_redelivered;
        public string m_routingKey;
        public FileDeliver() { }
        public FileDeliver(string initConsumerTag, ulong initDeliveryTag, bool initRedelivered, string initExchange, string initRoutingKey, string initIdentifier) { }
        public override bool HasContent { get { throw null; } }
        public override int ProtocolClassId { get { throw null; } }
        public override int ProtocolMethodId { get { throw null; } }
        public override string ProtocolMethodName { get { throw null; } }
        string RabbitMQ.Client.Framing.v0_8qpid.IFileDeliver.ConsumerTag { get { throw null; } }
        ulong RabbitMQ.Client.Framing.v0_8qpid.IFileDeliver.DeliveryTag { get { throw null; } }
        string RabbitMQ.Client.Framing.v0_8qpid.IFileDeliver.Exchange { get { throw null; } }
        string RabbitMQ.Client.Framing.v0_8qpid.IFileDeliver.Identifier { get { throw null; } }
        bool RabbitMQ.Client.Framing.v0_8qpid.IFileDeliver.Redelivered { get { throw null; } }
        string RabbitMQ.Client.Framing.v0_8qpid.IFileDeliver.RoutingKey { get { throw null; } }
        public override void AppendArgumentDebugStringTo(System.Text.StringBuilder sb) { }
        public override void ReadArgumentsFrom(RabbitMQ.Client.Impl.MethodArgumentReader reader) { }
        public override void WriteArgumentsTo(RabbitMQ.Client.Impl.MethodArgumentWriter writer) { }
    }
    public partial class FileOpen : RabbitMQ.Client.Impl.MethodBase, RabbitMQ.Client.Framing.v0_8qpid.IFileOpen, RabbitMQ.Client.IMethod
    {
        public const int ClassId = 70;
        public const int MethodId = 40;
        public ulong m_contentSize;
        public string m_identifier;
        public FileOpen() { }
        public FileOpen(string initIdentifier, ulong initContentSize) { }
        public override bool HasContent { get { throw null; } }
        public override int ProtocolClassId { get { throw null; } }
        public override int ProtocolMethodId { get { throw null; } }
        public override string ProtocolMethodName { get { throw null; } }
        ulong RabbitMQ.Client.Framing.v0_8qpid.IFileOpen.ContentSize { get { throw null; } }
        string RabbitMQ.Client.Framing.v0_8qpid.IFileOpen.Identifier { get { throw null; } }
        public override void AppendArgumentDebugStringTo(System.Text.StringBuilder sb) { }
        public override void ReadArgumentsFrom(RabbitMQ.Client.Impl.MethodArgumentReader reader) { }
        public override void WriteArgumentsTo(RabbitMQ.Client.Impl.MethodArgumentWriter writer) { }
    }
    public partial class FileOpenOk : RabbitMQ.Client.Impl.MethodBase, RabbitMQ.Client.Framing.v0_8qpid.IFileOpenOk, RabbitMQ.Client.IMethod
    {
        public const int ClassId = 70;
        public const int MethodId = 41;
        public ulong m_stagedSize;
        public FileOpenOk() { }
        public FileOpenOk(ulong initStagedSize) { }
        public override bool HasContent { get { throw null; } }
        public override int ProtocolClassId { get { throw null; } }
        public override int ProtocolMethodId { get { throw null; } }
        public override string ProtocolMethodName { get { throw null; } }
        ulong RabbitMQ.Client.Framing.v0_8qpid.IFileOpenOk.StagedSize { get { throw null; } }
        public override void AppendArgumentDebugStringTo(System.Text.StringBuilder sb) { }
        public override void ReadArgumentsFrom(RabbitMQ.Client.Impl.MethodArgumentReader reader) { }
        public override void WriteArgumentsTo(RabbitMQ.Client.Impl.MethodArgumentWriter writer) { }
    }
    public partial class FilePublish : RabbitMQ.Client.Impl.MethodBase, RabbitMQ.Client.Framing.v0_8qpid.IFilePublish, RabbitMQ.Client.IMethod
    {
        public const int ClassId = 70;
        public const int MethodId = 60;
        public string m_exchange;
        public string m_identifier;
        public bool m_immediate;
        public bool m_mandatory;
        public string m_routingKey;
        public ushort m_ticket;
        public FilePublish() { }
        public FilePublish(ushort initTicket, string initExchange, string initRoutingKey, bool initMandatory, bool initImmediate, string initIdentifier) { }
        public override bool HasContent { get { throw null; } }
        public override int ProtocolClassId { get { throw null; } }
        public override int ProtocolMethodId { get { throw null; } }
        public override string ProtocolMethodName { get { throw null; } }
        string RabbitMQ.Client.Framing.v0_8qpid.IFilePublish.Exchange { get { throw null; } }
        string RabbitMQ.Client.Framing.v0_8qpid.IFilePublish.Identifier { get { throw null; } }
        bool RabbitMQ.Client.Framing.v0_8qpid.IFilePublish.Immediate { get { throw null; } }
        bool RabbitMQ.Client.Framing.v0_8qpid.IFilePublish.Mandatory { get { throw null; } }
        string RabbitMQ.Client.Framing.v0_8qpid.IFilePublish.RoutingKey { get { throw null; } }
        ushort RabbitMQ.Client.Framing.v0_8qpid.IFilePublish.Ticket { get { throw null; } }
        public override void AppendArgumentDebugStringTo(System.Text.StringBuilder sb) { }
        public override void ReadArgumentsFrom(RabbitMQ.Client.Impl.MethodArgumentReader reader) { }
        public override void WriteArgumentsTo(RabbitMQ.Client.Impl.MethodArgumentWriter writer) { }
    }
    public partial class FileQos : RabbitMQ.Client.Impl.MethodBase, RabbitMQ.Client.Framing.v0_8qpid.IFileQos, RabbitMQ.Client.IMethod
    {
        public const int ClassId = 70;
        public const int MethodId = 10;
        public bool m_global;
        public ushort m_prefetchCount;
        public uint m_prefetchSize;
        public FileQos() { }
        public FileQos(uint initPrefetchSize, ushort initPrefetchCount, bool initGlobal) { }
        public override bool HasContent { get { throw null; } }
        public override int ProtocolClassId { get { throw null; } }
        public override int ProtocolMethodId { get { throw null; } }
        public override string ProtocolMethodName { get { throw null; } }
        bool RabbitMQ.Client.Framing.v0_8qpid.IFileQos.Global { get { throw null; } }
        ushort RabbitMQ.Client.Framing.v0_8qpid.IFileQos.PrefetchCount { get { throw null; } }
        uint RabbitMQ.Client.Framing.v0_8qpid.IFileQos.PrefetchSize { get { throw null; } }
        public override void AppendArgumentDebugStringTo(System.Text.StringBuilder sb) { }
        public override void ReadArgumentsFrom(RabbitMQ.Client.Impl.MethodArgumentReader reader) { }
        public override void WriteArgumentsTo(RabbitMQ.Client.Impl.MethodArgumentWriter writer) { }
    }
    public partial class FileQosOk : RabbitMQ.Client.Impl.MethodBase, RabbitMQ.Client.Framing.v0_8qpid.IFileQosOk, RabbitMQ.Client.IMethod
    {
        public const int ClassId = 70;
        public const int MethodId = 11;
        public FileQosOk() { }
        public override bool HasContent { get { throw null; } }
        public override int ProtocolClassId { get { throw null; } }
        public override int ProtocolMethodId { get { throw null; } }
        public override string ProtocolMethodName { get { throw null; } }
        public override void AppendArgumentDebugStringTo(System.Text.StringBuilder sb) { }
        public override void ReadArgumentsFrom(RabbitMQ.Client.Impl.MethodArgumentReader reader) { }
        public override void WriteArgumentsTo(RabbitMQ.Client.Impl.MethodArgumentWriter writer) { }
    }
    public partial class FileReject : RabbitMQ.Client.Impl.MethodBase, RabbitMQ.Client.Framing.v0_8qpid.IFileReject, RabbitMQ.Client.IMethod
    {
        public const int ClassId = 70;
        public const int MethodId = 100;
        public ulong m_deliveryTag;
        public bool m_requeue;
        public FileReject() { }
        public FileReject(ulong initDeliveryTag, bool initRequeue) { }
        public override bool HasContent { get { throw null; } }
        public override int ProtocolClassId { get { throw null; } }
        public override int ProtocolMethodId { get { throw null; } }
        public override string ProtocolMethodName { get { throw null; } }
        ulong RabbitMQ.Client.Framing.v0_8qpid.IFileReject.DeliveryTag { get { throw null; } }
        bool RabbitMQ.Client.Framing.v0_8qpid.IFileReject.Requeue { get { throw null; } }
        public override void AppendArgumentDebugStringTo(System.Text.StringBuilder sb) { }
        public override void ReadArgumentsFrom(RabbitMQ.Client.Impl.MethodArgumentReader reader) { }
        public override void WriteArgumentsTo(RabbitMQ.Client.Impl.MethodArgumentWriter writer) { }
    }
    public partial class FileReturn : RabbitMQ.Client.Impl.MethodBase, RabbitMQ.Client.Framing.v0_8qpid.IFileReturn, RabbitMQ.Client.IMethod
    {
        public const int ClassId = 70;
        public const int MethodId = 70;
        public string m_exchange;
        public ushort m_replyCode;
        public string m_replyText;
        public string m_routingKey;
        public FileReturn() { }
        public FileReturn(ushort initReplyCode, string initReplyText, string initExchange, string initRoutingKey) { }
        public override bool HasContent { get { throw null; } }
        public override int ProtocolClassId { get { throw null; } }
        public override int ProtocolMethodId { get { throw null; } }
        public override string ProtocolMethodName { get { throw null; } }
        string RabbitMQ.Client.Framing.v0_8qpid.IFileReturn.Exchange { get { throw null; } }
        ushort RabbitMQ.Client.Framing.v0_8qpid.IFileReturn.ReplyCode { get { throw null; } }
        string RabbitMQ.Client.Framing.v0_8qpid.IFileReturn.ReplyText { get { throw null; } }
        string RabbitMQ.Client.Framing.v0_8qpid.IFileReturn.RoutingKey { get { throw null; } }
        public override void AppendArgumentDebugStringTo(System.Text.StringBuilder sb) { }
        public override void ReadArgumentsFrom(RabbitMQ.Client.Impl.MethodArgumentReader reader) { }
        public override void WriteArgumentsTo(RabbitMQ.Client.Impl.MethodArgumentWriter writer) { }
    }
    public partial class FileStage : RabbitMQ.Client.Impl.MethodBase, RabbitMQ.Client.Framing.v0_8qpid.IFileStage, RabbitMQ.Client.IMethod
    {
        public const int ClassId = 70;
        public const int MethodId = 50;
        public FileStage() { }
        public override bool HasContent { get { throw null; } }
        public override int ProtocolClassId { get { throw null; } }
        public override int ProtocolMethodId { get { throw null; } }
        public override string ProtocolMethodName { get { throw null; } }
        public override void AppendArgumentDebugStringTo(System.Text.StringBuilder sb) { }
        public override void ReadArgumentsFrom(RabbitMQ.Client.Impl.MethodArgumentReader reader) { }
        public override void WriteArgumentsTo(RabbitMQ.Client.Impl.MethodArgumentWriter writer) { }
    }
    public partial class Model : RabbitMQ.Client.Impl.ModelBase
    {
        public Model(RabbitMQ.Client.Impl.ISession session) : base (default(RabbitMQ.Client.Impl.ISession)) { }
        public override void BasicAck(ulong deliveryTag, bool multiple) { }
        public override void BasicQos(uint prefetchSize, ushort prefetchCount, bool global) { }
        public override void BasicRecover(bool requeue) { }
        public override void BasicReject(ulong deliveryTag, bool requeue) { }
        public override void ChannelFlow(bool active) { }
        public override RabbitMQ.Client.Impl.ConnectionTuneDetails ConnectionStartOk(System.Collections.IDictionary clientProperties, string mechanism, byte[] response, string locale) { throw null; }
        public override void ConnectionTuneOk(ushort channelMax, uint frameMax, ushort heartbeat) { }
        public override RabbitMQ.Client.IBasicProperties CreateBasicProperties() { throw null; }
        public override RabbitMQ.Client.IFileProperties CreateFileProperties() { throw null; }
        public override RabbitMQ.Client.IStreamProperties CreateStreamProperties() { throw null; }
        public override bool DispatchAsynchronous(RabbitMQ.Client.Impl.Command cmd) { throw null; }
        public override void DtxSelect() { }
        public override void DtxStart(string dtxIdentifier) { }
        public override void ExchangeDeclare(string exchange, string type, bool passive, bool durable, bool autoDelete, bool @internal, bool nowait, System.Collections.IDictionary arguments) { }
        public override void ExchangeDelete(string exchange, bool ifUnused, bool nowait) { }
        public override void QueueBind(string queue, string exchange, string routingKey, bool nowait, System.Collections.IDictionary arguments) { }
        public override string QueueDeclare(string queue, bool passive, bool durable, bool exclusive, bool autoDelete, bool nowait, System.Collections.IDictionary arguments) { throw null; }
        public override uint QueueDelete(string queue, bool ifUnused, bool ifEmpty, bool nowait) { throw null; }
        public override uint QueuePurge(string queue, bool nowait) { throw null; }
        public override void QueueUnbind(string queue, string exchange, string routingKey, System.Collections.IDictionary arguments) { }
        public override void TxCommit() { }
        public override void TxRollback() { }
        public override void TxSelect() { }
        public override void _Private_BasicCancel(string consumerTag, bool nowait) { }
        public override void _Private_BasicConsume(string queue, string consumerTag, bool noLocal, bool noAck, bool exclusive, bool nowait, System.Collections.IDictionary filter) { }
        public override void _Private_BasicGet(string queue, bool noAck) { }
        public override void _Private_BasicPublish(string exchange, string routingKey, bool mandatory, bool immediate, RabbitMQ.Client.IBasicProperties basicProperties, byte[] body) { }
        public override void _Private_ChannelClose(ushort replyCode, string replyText, ushort classId, ushort methodId) { }
        public override void _Private_ChannelCloseOk() { }
        public override void _Private_ChannelFlowOk() { }
        public override void _Private_ChannelOpen(string outOfBand) { }
        public override void _Private_ConnectionClose(ushort replyCode, string replyText, ushort classId, ushort methodId) { }
        public override void _Private_ConnectionCloseOk() { }
        public override void _Private_ConnectionOpen(string virtualHost, string capabilities, bool insist) { }
    }
    public abstract partial class ProtocolBase : RabbitMQ.Client.Impl.AbstractProtocolBase
    {
        protected ProtocolBase() { }
        public override bool CanSendWhileClosed(RabbitMQ.Client.Impl.Command cmd) { throw null; }
        public override void CreateChannelClose(ushort reasonCode, string reasonText, out RabbitMQ.Client.Impl.Command request, out int replyClassId, out int replyMethodId) { throw null; }
        public override RabbitMQ.Client.IConnection CreateConnection(RabbitMQ.Client.ConnectionFactory factory, bool insist, RabbitMQ.Client.Impl.IFrameHandler frameHandler) { throw null; }
        public override void CreateConnectionClose(ushort reasonCode, string reasonText, out RabbitMQ.Client.Impl.Command request, out int replyClassId, out int replyMethodId) { throw null; }
        public override RabbitMQ.Client.Impl.IFrameHandler CreateFrameHandler(RabbitMQ.Client.AmqpTcpEndpoint endpoint) { throw null; }
        public override RabbitMQ.Client.IModel CreateModel(RabbitMQ.Client.Impl.ISession session) { throw null; }
    }
    public partial class QueueBind : RabbitMQ.Client.Impl.MethodBase, RabbitMQ.Client.Framing.v0_8qpid.IQueueBind, RabbitMQ.Client.IMethod
    {
        public const int ClassId = 50;
        public const int MethodId = 20;
        public System.Collections.IDictionary m_arguments;
        public string m_exchange;
        public bool m_nowait;
        public string m_queue;
        public string m_routingKey;
        public ushort m_ticket;
        public QueueBind() { }
        public QueueBind(ushort initTicket, string initQueue, string initExchange, string initRoutingKey, bool initNowait, System.Collections.IDictionary initArguments) { }
        public override bool HasContent { get { throw null; } }
        public override int ProtocolClassId { get { throw null; } }
        public override int ProtocolMethodId { get { throw null; } }
        public override string ProtocolMethodName { get { throw null; } }
        System.Collections.IDictionary RabbitMQ.Client.Framing.v0_8qpid.IQueueBind.Arguments { get { throw null; } }
        string RabbitMQ.Client.Framing.v0_8qpid.IQueueBind.Exchange { get { throw null; } }
        bool RabbitMQ.Client.Framing.v0_8qpid.IQueueBind.Nowait { get { throw null; } }
        string RabbitMQ.Client.Framing.v0_8qpid.IQueueBind.Queue { get { throw null; } }
        string RabbitMQ.Client.Framing.v0_8qpid.IQueueBind.RoutingKey { get { throw null; } }
        ushort RabbitMQ.Client.Framing.v0_8qpid.IQueueBind.Ticket { get { throw null; } }
        public override void AppendArgumentDebugStringTo(System.Text.StringBuilder sb) { }
        public override void ReadArgumentsFrom(RabbitMQ.Client.Impl.MethodArgumentReader reader) { }
        public override void WriteArgumentsTo(RabbitMQ.Client.Impl.MethodArgumentWriter writer) { }
    }
    public partial class QueueBindOk : RabbitMQ.Client.Impl.MethodBase, RabbitMQ.Client.Framing.v0_8qpid.IQueueBindOk, RabbitMQ.Client.IMethod
    {
        public const int ClassId = 50;
        public const int MethodId = 21;
        public QueueBindOk() { }
        public override bool HasContent { get { throw null; } }
        public override int ProtocolClassId { get { throw null; } }
        public override int ProtocolMethodId { get { throw null; } }
        public override string ProtocolMethodName { get { throw null; } }
        public override void AppendArgumentDebugStringTo(System.Text.StringBuilder sb) { }
        public override void ReadArgumentsFrom(RabbitMQ.Client.Impl.MethodArgumentReader reader) { }
        public override void WriteArgumentsTo(RabbitMQ.Client.Impl.MethodArgumentWriter writer) { }
    }
    public partial class QueueDeclare : RabbitMQ.Client.Impl.MethodBase, RabbitMQ.Client.Framing.v0_8qpid.IQueueDeclare, RabbitMQ.Client.IMethod
    {
        public const int ClassId = 50;
        public const int MethodId = 10;
        public System.Collections.IDictionary m_arguments;
        public bool m_autoDelete;
        public bool m_durable;
        public bool m_exclusive;
        public bool m_nowait;
        public bool m_passive;
        public string m_queue;
        public ushort m_ticket;
        public QueueDeclare() { }
        public QueueDeclare(ushort initTicket, string initQueue, bool initPassive, bool initDurable, bool initExclusive, bool initAutoDelete, bool initNowait, System.Collections.IDictionary initArguments) { }
        public override bool HasContent { get { throw null; } }
        public override int ProtocolClassId { get { throw null; } }
        public override int ProtocolMethodId { get { throw null; } }
        public override string ProtocolMethodName { get { throw null; } }
        System.Collections.IDictionary RabbitMQ.Client.Framing.v0_8qpid.IQueueDeclare.Arguments { get { throw null; } }
        bool RabbitMQ.Client.Framing.v0_8qpid.IQueueDeclare.AutoDelete { get { throw null; } }
        bool RabbitMQ.Client.Framing.v0_8qpid.IQueueDeclare.Durable { get { throw null; } }
        bool RabbitMQ.Client.Framing.v0_8qpid.IQueueDeclare.Exclusive { get { throw null; } }
        bool RabbitMQ.Client.Framing.v0_8qpid.IQueueDeclare.Nowait { get { throw null; } }
        bool RabbitMQ.Client.Framing.v0_8qpid.IQueueDeclare.Passive { get { throw null; } }
        string RabbitMQ.Client.Framing.v0_8qpid.IQueueDeclare.Queue { get { throw null; } }
        ushort RabbitMQ.Client.Framing.v0_8qpid.IQueueDeclare.Ticket { get { throw null; } }
        public override void AppendArgumentDebugStringTo(System.Text.StringBuilder sb) { }
        public override void ReadArgumentsFrom(RabbitMQ.Client.Impl.MethodArgumentReader reader) { }
        public override void WriteArgumentsTo(RabbitMQ.Client.Impl.MethodArgumentWriter writer) { }
    }
    public partial class QueueDeclareOk : RabbitMQ.Client.Impl.MethodBase, RabbitMQ.Client.Framing.v0_8qpid.IQueueDeclareOk, RabbitMQ.Client.IMethod
    {
        public const int ClassId = 50;
        public const int MethodId = 11;
        public uint m_consumerCount;
        public uint m_messageCount;
        public string m_queue;
        public QueueDeclareOk() { }
        public QueueDeclareOk(string initQueue, uint initMessageCount, uint initConsumerCount) { }
        public override bool HasContent { get { throw null; } }
        public override int ProtocolClassId { get { throw null; } }
        public override int ProtocolMethodId { get { throw null; } }
        public override string ProtocolMethodName { get { throw null; } }
        uint RabbitMQ.Client.Framing.v0_8qpid.IQueueDeclareOk.ConsumerCount { get { throw null; } }
        uint RabbitMQ.Client.Framing.v0_8qpid.IQueueDeclareOk.MessageCount { get { throw null; } }
        string RabbitMQ.Client.Framing.v0_8qpid.IQueueDeclareOk.Queue { get { throw null; } }
        public override void AppendArgumentDebugStringTo(System.Text.StringBuilder sb) { }
        public override void ReadArgumentsFrom(RabbitMQ.Client.Impl.MethodArgumentReader reader) { }
        public override void WriteArgumentsTo(RabbitMQ.Client.Impl.MethodArgumentWriter writer) { }
    }
    public partial class QueueDelete : RabbitMQ.Client.Impl.MethodBase, RabbitMQ.Client.Framing.v0_8qpid.IQueueDelete, RabbitMQ.Client.IMethod
    {
        public const int ClassId = 50;
        public const int MethodId = 40;
        public bool m_ifEmpty;
        public bool m_ifUnused;
        public bool m_nowait;
        public string m_queue;
        public ushort m_ticket;
        public QueueDelete() { }
        public QueueDelete(ushort initTicket, string initQueue, bool initIfUnused, bool initIfEmpty, bool initNowait) { }
        public override bool HasContent { get { throw null; } }
        public override int ProtocolClassId { get { throw null; } }
        public override int ProtocolMethodId { get { throw null; } }
        public override string ProtocolMethodName { get { throw null; } }
        bool RabbitMQ.Client.Framing.v0_8qpid.IQueueDelete.IfEmpty { get { throw null; } }
        bool RabbitMQ.Client.Framing.v0_8qpid.IQueueDelete.IfUnused { get { throw null; } }
        bool RabbitMQ.Client.Framing.v0_8qpid.IQueueDelete.Nowait { get { throw null; } }
        string RabbitMQ.Client.Framing.v0_8qpid.IQueueDelete.Queue { get { throw null; } }
        ushort RabbitMQ.Client.Framing.v0_8qpid.IQueueDelete.Ticket { get { throw null; } }
        public override void AppendArgumentDebugStringTo(System.Text.StringBuilder sb) { }
        public override void ReadArgumentsFrom(RabbitMQ.Client.Impl.MethodArgumentReader reader) { }
        public override void WriteArgumentsTo(RabbitMQ.Client.Impl.MethodArgumentWriter writer) { }
    }
    public partial class QueueDeleteOk : RabbitMQ.Client.Impl.MethodBase, RabbitMQ.Client.Framing.v0_8qpid.IQueueDeleteOk, RabbitMQ.Client.IMethod
    {
        public const int ClassId = 50;
        public const int MethodId = 41;
        public uint m_messageCount;
        public QueueDeleteOk() { }
        public QueueDeleteOk(uint initMessageCount) { }
        public override bool HasContent { get { throw null; } }
        public override int ProtocolClassId { get { throw null; } }
        public override int ProtocolMethodId { get { throw null; } }
        public override string ProtocolMethodName { get { throw null; } }
        uint RabbitMQ.Client.Framing.v0_8qpid.IQueueDeleteOk.MessageCount { get { throw null; } }
        public override void AppendArgumentDebugStringTo(System.Text.StringBuilder sb) { }
        public override void ReadArgumentsFrom(RabbitMQ.Client.Impl.MethodArgumentReader reader) { }
        public override void WriteArgumentsTo(RabbitMQ.Client.Impl.MethodArgumentWriter writer) { }
    }
    public partial class QueuePurge : RabbitMQ.Client.Impl.MethodBase, RabbitMQ.Client.Framing.v0_8qpid.IQueuePurge, RabbitMQ.Client.IMethod
    {
        public const int ClassId = 50;
        public const int MethodId = 30;
        public bool m_nowait;
        public string m_queue;
        public ushort m_ticket;
        public QueuePurge() { }
        public QueuePurge(ushort initTicket, string initQueue, bool initNowait) { }
        public override bool HasContent { get { throw null; } }
        public override int ProtocolClassId { get { throw null; } }
        public override int ProtocolMethodId { get { throw null; } }
        public override string ProtocolMethodName { get { throw null; } }
        bool RabbitMQ.Client.Framing.v0_8qpid.IQueuePurge.Nowait { get { throw null; } }
        string RabbitMQ.Client.Framing.v0_8qpid.IQueuePurge.Queue { get { throw null; } }
        ushort RabbitMQ.Client.Framing.v0_8qpid.IQueuePurge.Ticket { get { throw null; } }
        public override void AppendArgumentDebugStringTo(System.Text.StringBuilder sb) { }
        public override void ReadArgumentsFrom(RabbitMQ.Client.Impl.MethodArgumentReader reader) { }
        public override void WriteArgumentsTo(RabbitMQ.Client.Impl.MethodArgumentWriter writer) { }
    }
    public partial class QueuePurgeOk : RabbitMQ.Client.Impl.MethodBase, RabbitMQ.Client.Framing.v0_8qpid.IQueuePurgeOk, RabbitMQ.Client.IMethod
    {
        public const int ClassId = 50;
        public const int MethodId = 31;
        public uint m_messageCount;
        public QueuePurgeOk() { }
        public QueuePurgeOk(uint initMessageCount) { }
        public override bool HasContent { get { throw null; } }
        public override int ProtocolClassId { get { throw null; } }
        public override int ProtocolMethodId { get { throw null; } }
        public override string ProtocolMethodName { get { throw null; } }
        uint RabbitMQ.Client.Framing.v0_8qpid.IQueuePurgeOk.MessageCount { get { throw null; } }
        public override void AppendArgumentDebugStringTo(System.Text.StringBuilder sb) { }
        public override void ReadArgumentsFrom(RabbitMQ.Client.Impl.MethodArgumentReader reader) { }
        public override void WriteArgumentsTo(RabbitMQ.Client.Impl.MethodArgumentWriter writer) { }
    }
    public partial class StreamCancel : RabbitMQ.Client.Impl.MethodBase, RabbitMQ.Client.Framing.v0_8qpid.IStreamCancel, RabbitMQ.Client.IMethod
    {
        public const int ClassId = 80;
        public const int MethodId = 30;
        public string m_consumerTag;
        public bool m_nowait;
        public StreamCancel() { }
        public StreamCancel(string initConsumerTag, bool initNowait) { }
        public override bool HasContent { get { throw null; } }
        public override int ProtocolClassId { get { throw null; } }
        public override int ProtocolMethodId { get { throw null; } }
        public override string ProtocolMethodName { get { throw null; } }
        string RabbitMQ.Client.Framing.v0_8qpid.IStreamCancel.ConsumerTag { get { throw null; } }
        bool RabbitMQ.Client.Framing.v0_8qpid.IStreamCancel.Nowait { get { throw null; } }
        public override void AppendArgumentDebugStringTo(System.Text.StringBuilder sb) { }
        public override void ReadArgumentsFrom(RabbitMQ.Client.Impl.MethodArgumentReader reader) { }
        public override void WriteArgumentsTo(RabbitMQ.Client.Impl.MethodArgumentWriter writer) { }
    }
    public partial class StreamCancelOk : RabbitMQ.Client.Impl.MethodBase, RabbitMQ.Client.Framing.v0_8qpid.IStreamCancelOk, RabbitMQ.Client.IMethod
    {
        public const int ClassId = 80;
        public const int MethodId = 31;
        public string m_consumerTag;
        public StreamCancelOk() { }
        public StreamCancelOk(string initConsumerTag) { }
        public override bool HasContent { get { throw null; } }
        public override int ProtocolClassId { get { throw null; } }
        public override int ProtocolMethodId { get { throw null; } }
        public override string ProtocolMethodName { get { throw null; } }
        string RabbitMQ.Client.Framing.v0_8qpid.IStreamCancelOk.ConsumerTag { get { throw null; } }
        public override void AppendArgumentDebugStringTo(System.Text.StringBuilder sb) { }
        public override void ReadArgumentsFrom(RabbitMQ.Client.Impl.MethodArgumentReader reader) { }
        public override void WriteArgumentsTo(RabbitMQ.Client.Impl.MethodArgumentWriter writer) { }
    }
    public partial class StreamConsume : RabbitMQ.Client.Impl.MethodBase, RabbitMQ.Client.Framing.v0_8qpid.IStreamConsume, RabbitMQ.Client.IMethod
    {
        public const int ClassId = 80;
        public const int MethodId = 20;
        public string m_consumerTag;
        public bool m_exclusive;
        public bool m_noLocal;
        public bool m_nowait;
        public string m_queue;
        public ushort m_ticket;
        public StreamConsume() { }
        public StreamConsume(ushort initTicket, string initQueue, string initConsumerTag, bool initNoLocal, bool initExclusive, bool initNowait) { }
        public override bool HasContent { get { throw null; } }
        public override int ProtocolClassId { get { throw null; } }
        public override int ProtocolMethodId { get { throw null; } }
        public override string ProtocolMethodName { get { throw null; } }
        string RabbitMQ.Client.Framing.v0_8qpid.IStreamConsume.ConsumerTag { get { throw null; } }
        bool RabbitMQ.Client.Framing.v0_8qpid.IStreamConsume.Exclusive { get { throw null; } }
        bool RabbitMQ.Client.Framing.v0_8qpid.IStreamConsume.NoLocal { get { throw null; } }
        bool RabbitMQ.Client.Framing.v0_8qpid.IStreamConsume.Nowait { get { throw null; } }
        string RabbitMQ.Client.Framing.v0_8qpid.IStreamConsume.Queue { get { throw null; } }
        ushort RabbitMQ.Client.Framing.v0_8qpid.IStreamConsume.Ticket { get { throw null; } }
        public override void AppendArgumentDebugStringTo(System.Text.StringBuilder sb) { }
        public override void ReadArgumentsFrom(RabbitMQ.Client.Impl.MethodArgumentReader reader) { }
        public override void WriteArgumentsTo(RabbitMQ.Client.Impl.MethodArgumentWriter writer) { }
    }
    public partial class StreamConsumeOk : RabbitMQ.Client.Impl.MethodBase, RabbitMQ.Client.Framing.v0_8qpid.IStreamConsumeOk, RabbitMQ.Client.IMethod
    {
        public const int ClassId = 80;
        public const int MethodId = 21;
        public string m_consumerTag;
        public StreamConsumeOk() { }
        public StreamConsumeOk(string initConsumerTag) { }
        public override bool HasContent { get { throw null; } }
        public override int ProtocolClassId { get { throw null; } }
        public override int ProtocolMethodId { get { throw null; } }
        public override string ProtocolMethodName { get { throw null; } }
        string RabbitMQ.Client.Framing.v0_8qpid.IStreamConsumeOk.ConsumerTag { get { throw null; } }
        public override void AppendArgumentDebugStringTo(System.Text.StringBuilder sb) { }
        public override void ReadArgumentsFrom(RabbitMQ.Client.Impl.MethodArgumentReader reader) { }
        public override void WriteArgumentsTo(RabbitMQ.Client.Impl.MethodArgumentWriter writer) { }
    }
    public partial class StreamDeliver : RabbitMQ.Client.Impl.MethodBase, RabbitMQ.Client.Framing.v0_8qpid.IStreamDeliver, RabbitMQ.Client.IMethod
    {
        public const int ClassId = 80;
        public const int MethodId = 60;
        public string m_consumerTag;
        public ulong m_deliveryTag;
        public string m_exchange;
        public string m_queue;
        public StreamDeliver() { }
        public StreamDeliver(string initConsumerTag, ulong initDeliveryTag, string initExchange, string initQueue) { }
        public override bool HasContent { get { throw null; } }
        public override int ProtocolClassId { get { throw null; } }
        public override int ProtocolMethodId { get { throw null; } }
        public override string ProtocolMethodName { get { throw null; } }
        string RabbitMQ.Client.Framing.v0_8qpid.IStreamDeliver.ConsumerTag { get { throw null; } }
        ulong RabbitMQ.Client.Framing.v0_8qpid.IStreamDeliver.DeliveryTag { get { throw null; } }
        string RabbitMQ.Client.Framing.v0_8qpid.IStreamDeliver.Exchange { get { throw null; } }
        string RabbitMQ.Client.Framing.v0_8qpid.IStreamDeliver.Queue { get { throw null; } }
        public override void AppendArgumentDebugStringTo(System.Text.StringBuilder sb) { }
        public override void ReadArgumentsFrom(RabbitMQ.Client.Impl.MethodArgumentReader reader) { }
        public override void WriteArgumentsTo(RabbitMQ.Client.Impl.MethodArgumentWriter writer) { }
    }
    public partial class StreamPublish : RabbitMQ.Client.Impl.MethodBase, RabbitMQ.Client.Framing.v0_8qpid.IStreamPublish, RabbitMQ.Client.IMethod
    {
        public const int ClassId = 80;
        public const int MethodId = 40;
        public string m_exchange;
        public bool m_immediate;
        public bool m_mandatory;
        public string m_routingKey;
        public ushort m_ticket;
        public StreamPublish() { }
        public StreamPublish(ushort initTicket, string initExchange, string initRoutingKey, bool initMandatory, bool initImmediate) { }
        public override bool HasContent { get { throw null; } }
        public override int ProtocolClassId { get { throw null; } }
        public override int ProtocolMethodId { get { throw null; } }
        public override string ProtocolMethodName { get { throw null; } }
        string RabbitMQ.Client.Framing.v0_8qpid.IStreamPublish.Exchange { get { throw null; } }
        bool RabbitMQ.Client.Framing.v0_8qpid.IStreamPublish.Immediate { get { throw null; } }
        bool RabbitMQ.Client.Framing.v0_8qpid.IStreamPublish.Mandatory { get { throw null; } }
        string RabbitMQ.Client.Framing.v0_8qpid.IStreamPublish.RoutingKey { get { throw null; } }
        ushort RabbitMQ.Client.Framing.v0_8qpid.IStreamPublish.Ticket { get { throw null; } }
        public override void AppendArgumentDebugStringTo(System.Text.StringBuilder sb) { }
        public override void ReadArgumentsFrom(RabbitMQ.Client.Impl.MethodArgumentReader reader) { }
        public override void WriteArgumentsTo(RabbitMQ.Client.Impl.MethodArgumentWriter writer) { }
    }
    public partial class StreamQos : RabbitMQ.Client.Impl.MethodBase, RabbitMQ.Client.Framing.v0_8qpid.IStreamQos, RabbitMQ.Client.IMethod
    {
        public const int ClassId = 80;
        public const int MethodId = 10;
        public uint m_consumeRate;
        public bool m_global;
        public ushort m_prefetchCount;
        public uint m_prefetchSize;
        public StreamQos() { }
        public StreamQos(uint initPrefetchSize, ushort initPrefetchCount, uint initConsumeRate, bool initGlobal) { }
        public override bool HasContent { get { throw null; } }
        public override int ProtocolClassId { get { throw null; } }
        public override int ProtocolMethodId { get { throw null; } }
        public override string ProtocolMethodName { get { throw null; } }
        uint RabbitMQ.Client.Framing.v0_8qpid.IStreamQos.ConsumeRate { get { throw null; } }
        bool RabbitMQ.Client.Framing.v0_8qpid.IStreamQos.Global { get { throw null; } }
        ushort RabbitMQ.Client.Framing.v0_8qpid.IStreamQos.PrefetchCount { get { throw null; } }
        uint RabbitMQ.Client.Framing.v0_8qpid.IStreamQos.PrefetchSize { get { throw null; } }
        public override void AppendArgumentDebugStringTo(System.Text.StringBuilder sb) { }
        public override void ReadArgumentsFrom(RabbitMQ.Client.Impl.MethodArgumentReader reader) { }
        public override void WriteArgumentsTo(RabbitMQ.Client.Impl.MethodArgumentWriter writer) { }
    }
    public partial class StreamQosOk : RabbitMQ.Client.Impl.MethodBase, RabbitMQ.Client.Framing.v0_8qpid.IStreamQosOk, RabbitMQ.Client.IMethod
    {
        public const int ClassId = 80;
        public const int MethodId = 11;
        public StreamQosOk() { }
        public override bool HasContent { get { throw null; } }
        public override int ProtocolClassId { get { throw null; } }
        public override int ProtocolMethodId { get { throw null; } }
        public override string ProtocolMethodName { get { throw null; } }
        public override void AppendArgumentDebugStringTo(System.Text.StringBuilder sb) { }
        public override void ReadArgumentsFrom(RabbitMQ.Client.Impl.MethodArgumentReader reader) { }
        public override void WriteArgumentsTo(RabbitMQ.Client.Impl.MethodArgumentWriter writer) { }
    }
    public partial class StreamReturn : RabbitMQ.Client.Impl.MethodBase, RabbitMQ.Client.Framing.v0_8qpid.IStreamReturn, RabbitMQ.Client.IMethod
    {
        public const int ClassId = 80;
        public const int MethodId = 50;
        public string m_exchange;
        public ushort m_replyCode;
        public string m_replyText;
        public string m_routingKey;
        public StreamReturn() { }
        public StreamReturn(ushort initReplyCode, string initReplyText, string initExchange, string initRoutingKey) { }
        public override bool HasContent { get { throw null; } }
        public override int ProtocolClassId { get { throw null; } }
        public override int ProtocolMethodId { get { throw null; } }
        public override string ProtocolMethodName { get { throw null; } }
        string RabbitMQ.Client.Framing.v0_8qpid.IStreamReturn.Exchange { get { throw null; } }
        ushort RabbitMQ.Client.Framing.v0_8qpid.IStreamReturn.ReplyCode { get { throw null; } }
        string RabbitMQ.Client.Framing.v0_8qpid.IStreamReturn.ReplyText { get { throw null; } }
        string RabbitMQ.Client.Framing.v0_8qpid.IStreamReturn.RoutingKey { get { throw null; } }
        public override void AppendArgumentDebugStringTo(System.Text.StringBuilder sb) { }
        public override void ReadArgumentsFrom(RabbitMQ.Client.Impl.MethodArgumentReader reader) { }
        public override void WriteArgumentsTo(RabbitMQ.Client.Impl.MethodArgumentWriter writer) { }
    }
    public partial class TestContent : RabbitMQ.Client.Impl.MethodBase, RabbitMQ.Client.Framing.v0_8qpid.ITestContent, RabbitMQ.Client.IMethod
    {
        public const int ClassId = 120;
        public const int MethodId = 40;
        public TestContent() { }
        public override bool HasContent { get { throw null; } }
        public override int ProtocolClassId { get { throw null; } }
        public override int ProtocolMethodId { get { throw null; } }
        public override string ProtocolMethodName { get { throw null; } }
        public override void AppendArgumentDebugStringTo(System.Text.StringBuilder sb) { }
        public override void ReadArgumentsFrom(RabbitMQ.Client.Impl.MethodArgumentReader reader) { }
        public override void WriteArgumentsTo(RabbitMQ.Client.Impl.MethodArgumentWriter writer) { }
    }
    public partial class TestContentOk : RabbitMQ.Client.Impl.MethodBase, RabbitMQ.Client.Framing.v0_8qpid.ITestContentOk, RabbitMQ.Client.IMethod
    {
        public const int ClassId = 120;
        public const int MethodId = 41;
        public uint m_contentChecksum;
        public TestContentOk() { }
        public TestContentOk(uint initContentChecksum) { }
        public override bool HasContent { get { throw null; } }
        public override int ProtocolClassId { get { throw null; } }
        public override int ProtocolMethodId { get { throw null; } }
        public override string ProtocolMethodName { get { throw null; } }
        uint RabbitMQ.Client.Framing.v0_8qpid.ITestContentOk.ContentChecksum { get { throw null; } }
        public override void AppendArgumentDebugStringTo(System.Text.StringBuilder sb) { }
        public override void ReadArgumentsFrom(RabbitMQ.Client.Impl.MethodArgumentReader reader) { }
        public override void WriteArgumentsTo(RabbitMQ.Client.Impl.MethodArgumentWriter writer) { }
    }
    public partial class TestInteger : RabbitMQ.Client.Impl.MethodBase, RabbitMQ.Client.Framing.v0_8qpid.ITestInteger, RabbitMQ.Client.IMethod
    {
        public const int ClassId = 120;
        public const int MethodId = 10;
        public byte m_integer1;
        public ushort m_integer2;
        public uint m_integer3;
        public ulong m_integer4;
        public byte m_operation;
        public TestInteger() { }
        public TestInteger(byte initInteger1, ushort initInteger2, uint initInteger3, ulong initInteger4, byte initOperation) { }
        public override bool HasContent { get { throw null; } }
        public override int ProtocolClassId { get { throw null; } }
        public override int ProtocolMethodId { get { throw null; } }
        public override string ProtocolMethodName { get { throw null; } }
        byte RabbitMQ.Client.Framing.v0_8qpid.ITestInteger.Integer1 { get { throw null; } }
        ushort RabbitMQ.Client.Framing.v0_8qpid.ITestInteger.Integer2 { get { throw null; } }
        uint RabbitMQ.Client.Framing.v0_8qpid.ITestInteger.Integer3 { get { throw null; } }
        ulong RabbitMQ.Client.Framing.v0_8qpid.ITestInteger.Integer4 { get { throw null; } }
        byte RabbitMQ.Client.Framing.v0_8qpid.ITestInteger.Operation { get { throw null; } }
        public override void AppendArgumentDebugStringTo(System.Text.StringBuilder sb) { }
        public override void ReadArgumentsFrom(RabbitMQ.Client.Impl.MethodArgumentReader reader) { }
        public override void WriteArgumentsTo(RabbitMQ.Client.Impl.MethodArgumentWriter writer) { }
    }
    public partial class TestIntegerOk : RabbitMQ.Client.Impl.MethodBase, RabbitMQ.Client.Framing.v0_8qpid.ITestIntegerOk, RabbitMQ.Client.IMethod
    {
        public const int ClassId = 120;
        public const int MethodId = 11;
        public ulong m_result;
        public TestIntegerOk() { }
        public TestIntegerOk(ulong initResult) { }
        public override bool HasContent { get { throw null; } }
        public override int ProtocolClassId { get { throw null; } }
        public override int ProtocolMethodId { get { throw null; } }
        public override string ProtocolMethodName { get { throw null; } }
        ulong RabbitMQ.Client.Framing.v0_8qpid.ITestIntegerOk.Result { get { throw null; } }
        public override void AppendArgumentDebugStringTo(System.Text.StringBuilder sb) { }
        public override void ReadArgumentsFrom(RabbitMQ.Client.Impl.MethodArgumentReader reader) { }
        public override void WriteArgumentsTo(RabbitMQ.Client.Impl.MethodArgumentWriter writer) { }
    }
    public partial class TestString : RabbitMQ.Client.Impl.MethodBase, RabbitMQ.Client.Framing.v0_8qpid.ITestString, RabbitMQ.Client.IMethod
    {
        public const int ClassId = 120;
        public const int MethodId = 20;
        public byte m_operation;
        public string m_string1;
        public byte[] m_string2;
        public TestString() { }
        public TestString(string initString1, byte[] initString2, byte initOperation) { }
        public override bool HasContent { get { throw null; } }
        public override int ProtocolClassId { get { throw null; } }
        public override int ProtocolMethodId { get { throw null; } }
        public override string ProtocolMethodName { get { throw null; } }
        byte RabbitMQ.Client.Framing.v0_8qpid.ITestString.Operation { get { throw null; } }
        string RabbitMQ.Client.Framing.v0_8qpid.ITestString.String1 { get { throw null; } }
        byte[] RabbitMQ.Client.Framing.v0_8qpid.ITestString.String2 { get { throw null; } }
        public override void AppendArgumentDebugStringTo(System.Text.StringBuilder sb) { }
        public override void ReadArgumentsFrom(RabbitMQ.Client.Impl.MethodArgumentReader reader) { }
        public override void WriteArgumentsTo(RabbitMQ.Client.Impl.MethodArgumentWriter writer) { }
    }
    public partial class TestStringOk : RabbitMQ.Client.Impl.MethodBase, RabbitMQ.Client.Framing.v0_8qpid.ITestStringOk, RabbitMQ.Client.IMethod
    {
        public const int ClassId = 120;
        public const int MethodId = 21;
        public byte[] m_result;
        public TestStringOk() { }
        public TestStringOk(byte[] initResult) { }
        public override bool HasContent { get { throw null; } }
        public override int ProtocolClassId { get { throw null; } }
        public override int ProtocolMethodId { get { throw null; } }
        public override string ProtocolMethodName { get { throw null; } }
        byte[] RabbitMQ.Client.Framing.v0_8qpid.ITestStringOk.Result { get { throw null; } }
        public override void AppendArgumentDebugStringTo(System.Text.StringBuilder sb) { }
        public override void ReadArgumentsFrom(RabbitMQ.Client.Impl.MethodArgumentReader reader) { }
        public override void WriteArgumentsTo(RabbitMQ.Client.Impl.MethodArgumentWriter writer) { }
    }
    public partial class TestTable : RabbitMQ.Client.Impl.MethodBase, RabbitMQ.Client.Framing.v0_8qpid.ITestTable, RabbitMQ.Client.IMethod
    {
        public const int ClassId = 120;
        public const int MethodId = 30;
        public byte m_integerOp;
        public byte m_stringOp;
        public System.Collections.IDictionary m_table;
        public TestTable() { }
        public TestTable(System.Collections.IDictionary initTable, byte initIntegerOp, byte initStringOp) { }
        public override bool HasContent { get { throw null; } }
        public override int ProtocolClassId { get { throw null; } }
        public override int ProtocolMethodId { get { throw null; } }
        public override string ProtocolMethodName { get { throw null; } }
        byte RabbitMQ.Client.Framing.v0_8qpid.ITestTable.IntegerOp { get { throw null; } }
        byte RabbitMQ.Client.Framing.v0_8qpid.ITestTable.StringOp { get { throw null; } }
        System.Collections.IDictionary RabbitMQ.Client.Framing.v0_8qpid.ITestTable.Table { get { throw null; } }
        public override void AppendArgumentDebugStringTo(System.Text.StringBuilder sb) { }
        public override void ReadArgumentsFrom(RabbitMQ.Client.Impl.MethodArgumentReader reader) { }
        public override void WriteArgumentsTo(RabbitMQ.Client.Impl.MethodArgumentWriter writer) { }
    }
    public partial class TestTableOk : RabbitMQ.Client.Impl.MethodBase, RabbitMQ.Client.Framing.v0_8qpid.ITestTableOk, RabbitMQ.Client.IMethod
    {
        public const int ClassId = 120;
        public const int MethodId = 31;
        public ulong m_integerResult;
        public byte[] m_stringResult;
        public TestTableOk() { }
        public TestTableOk(ulong initIntegerResult, byte[] initStringResult) { }
        public override bool HasContent { get { throw null; } }
        public override int ProtocolClassId { get { throw null; } }
        public override int ProtocolMethodId { get { throw null; } }
        public override string ProtocolMethodName { get { throw null; } }
        ulong RabbitMQ.Client.Framing.v0_8qpid.ITestTableOk.IntegerResult { get { throw null; } }
        byte[] RabbitMQ.Client.Framing.v0_8qpid.ITestTableOk.StringResult { get { throw null; } }
        public override void AppendArgumentDebugStringTo(System.Text.StringBuilder sb) { }
        public override void ReadArgumentsFrom(RabbitMQ.Client.Impl.MethodArgumentReader reader) { }
        public override void WriteArgumentsTo(RabbitMQ.Client.Impl.MethodArgumentWriter writer) { }
    }
    public partial class TunnelRequest : RabbitMQ.Client.Impl.MethodBase, RabbitMQ.Client.Framing.v0_8qpid.ITunnelRequest, RabbitMQ.Client.IMethod
    {
        public const int ClassId = 110;
        public const int MethodId = 10;
        public System.Collections.IDictionary m_metaData;
        public TunnelRequest() { }
        public TunnelRequest(System.Collections.IDictionary initMetaData) { }
        public override bool HasContent { get { throw null; } }
        public override int ProtocolClassId { get { throw null; } }
        public override int ProtocolMethodId { get { throw null; } }
        public override string ProtocolMethodName { get { throw null; } }
        System.Collections.IDictionary RabbitMQ.Client.Framing.v0_8qpid.ITunnelRequest.MetaData { get { throw null; } }
        public override void AppendArgumentDebugStringTo(System.Text.StringBuilder sb) { }
        public override void ReadArgumentsFrom(RabbitMQ.Client.Impl.MethodArgumentReader reader) { }
        public override void WriteArgumentsTo(RabbitMQ.Client.Impl.MethodArgumentWriter writer) { }
    }
    public partial class TxCommit : RabbitMQ.Client.Impl.MethodBase, RabbitMQ.Client.Framing.v0_8qpid.ITxCommit, RabbitMQ.Client.IMethod
    {
        public const int ClassId = 90;
        public const int MethodId = 20;
        public TxCommit() { }
        public override bool HasContent { get { throw null; } }
        public override int ProtocolClassId { get { throw null; } }
        public override int ProtocolMethodId { get { throw null; } }
        public override string ProtocolMethodName { get { throw null; } }
        public override void AppendArgumentDebugStringTo(System.Text.StringBuilder sb) { }
        public override void ReadArgumentsFrom(RabbitMQ.Client.Impl.MethodArgumentReader reader) { }
        public override void WriteArgumentsTo(RabbitMQ.Client.Impl.MethodArgumentWriter writer) { }
    }
    public partial class TxCommitOk : RabbitMQ.Client.Impl.MethodBase, RabbitMQ.Client.Framing.v0_8qpid.ITxCommitOk, RabbitMQ.Client.IMethod
    {
        public const int ClassId = 90;
        public const int MethodId = 21;
        public TxCommitOk() { }
        public override bool HasContent { get { throw null; } }
        public override int ProtocolClassId { get { throw null; } }
        public override int ProtocolMethodId { get { throw null; } }
        public override string ProtocolMethodName { get { throw null; } }
        public override void AppendArgumentDebugStringTo(System.Text.StringBuilder sb) { }
        public override void ReadArgumentsFrom(RabbitMQ.Client.Impl.MethodArgumentReader reader) { }
        public override void WriteArgumentsTo(RabbitMQ.Client.Impl.MethodArgumentWriter writer) { }
    }
    public partial class TxRollback : RabbitMQ.Client.Impl.MethodBase, RabbitMQ.Client.Framing.v0_8qpid.ITxRollback, RabbitMQ.Client.IMethod
    {
        public const int ClassId = 90;
        public const int MethodId = 30;
        public TxRollback() { }
        public override bool HasContent { get { throw null; } }
        public override int ProtocolClassId { get { throw null; } }
        public override int ProtocolMethodId { get { throw null; } }
        public override string ProtocolMethodName { get { throw null; } }
        public override void AppendArgumentDebugStringTo(System.Text.StringBuilder sb) { }
        public override void ReadArgumentsFrom(RabbitMQ.Client.Impl.MethodArgumentReader reader) { }
        public override void WriteArgumentsTo(RabbitMQ.Client.Impl.MethodArgumentWriter writer) { }
    }
    public partial class TxRollbackOk : RabbitMQ.Client.Impl.MethodBase, RabbitMQ.Client.Framing.v0_8qpid.ITxRollbackOk, RabbitMQ.Client.IMethod
    {
        public const int ClassId = 90;
        public const int MethodId = 31;
        public TxRollbackOk() { }
        public override bool HasContent { get { throw null; } }
        public override int ProtocolClassId { get { throw null; } }
        public override int ProtocolMethodId { get { throw null; } }
        public override string ProtocolMethodName { get { throw null; } }
        public override void AppendArgumentDebugStringTo(System.Text.StringBuilder sb) { }
        public override void ReadArgumentsFrom(RabbitMQ.Client.Impl.MethodArgumentReader reader) { }
        public override void WriteArgumentsTo(RabbitMQ.Client.Impl.MethodArgumentWriter writer) { }
    }
    public partial class TxSelect : RabbitMQ.Client.Impl.MethodBase, RabbitMQ.Client.Framing.v0_8qpid.ITxSelect, RabbitMQ.Client.IMethod
    {
        public const int ClassId = 90;
        public const int MethodId = 10;
        public TxSelect() { }
        public override bool HasContent { get { throw null; } }
        public override int ProtocolClassId { get { throw null; } }
        public override int ProtocolMethodId { get { throw null; } }
        public override string ProtocolMethodName { get { throw null; } }
        public override void AppendArgumentDebugStringTo(System.Text.StringBuilder sb) { }
        public override void ReadArgumentsFrom(RabbitMQ.Client.Impl.MethodArgumentReader reader) { }
        public override void WriteArgumentsTo(RabbitMQ.Client.Impl.MethodArgumentWriter writer) { }
    }
    public partial class TxSelectOk : RabbitMQ.Client.Impl.MethodBase, RabbitMQ.Client.Framing.v0_8qpid.ITxSelectOk, RabbitMQ.Client.IMethod
    {
        public const int ClassId = 90;
        public const int MethodId = 11;
        public TxSelectOk() { }
        public override bool HasContent { get { throw null; } }
        public override int ProtocolClassId { get { throw null; } }
        public override int ProtocolMethodId { get { throw null; } }
        public override string ProtocolMethodName { get { throw null; } }
        public override void AppendArgumentDebugStringTo(System.Text.StringBuilder sb) { }
        public override void ReadArgumentsFrom(RabbitMQ.Client.Impl.MethodArgumentReader reader) { }
        public override void WriteArgumentsTo(RabbitMQ.Client.Impl.MethodArgumentWriter writer) { }
    }
}
namespace RabbitMQ.Client.Framing.Impl.v0_9
{
    public partial class AccessRequest : RabbitMQ.Client.Impl.MethodBase, RabbitMQ.Client.Framing.v0_9.IAccessRequest, RabbitMQ.Client.IMethod
    {
        public const int ClassId = 30;
        public const int MethodId = 10;
        public bool m_active;
        public bool m_exclusive;
        public bool m_passive;
        public bool m_read;
        public string m_realm;
        public bool m_write;
        public AccessRequest() { }
        public AccessRequest(string initRealm, bool initExclusive, bool initPassive, bool initActive, bool initWrite, bool initRead) { }
        public override bool HasContent { get { throw null; } }
        public override int ProtocolClassId { get { throw null; } }
        public override int ProtocolMethodId { get { throw null; } }
        public override string ProtocolMethodName { get { throw null; } }
        bool RabbitMQ.Client.Framing.v0_9.IAccessRequest.Active { get { throw null; } }
        bool RabbitMQ.Client.Framing.v0_9.IAccessRequest.Exclusive { get { throw null; } }
        bool RabbitMQ.Client.Framing.v0_9.IAccessRequest.Passive { get { throw null; } }
        bool RabbitMQ.Client.Framing.v0_9.IAccessRequest.Read { get { throw null; } }
        string RabbitMQ.Client.Framing.v0_9.IAccessRequest.Realm { get { throw null; } }
        bool RabbitMQ.Client.Framing.v0_9.IAccessRequest.Write { get { throw null; } }
        public override void AppendArgumentDebugStringTo(System.Text.StringBuilder sb) { }
        public override void ReadArgumentsFrom(RabbitMQ.Client.Impl.MethodArgumentReader reader) { }
        public override void WriteArgumentsTo(RabbitMQ.Client.Impl.MethodArgumentWriter writer) { }
    }
    public partial class AccessRequestOk : RabbitMQ.Client.Impl.MethodBase, RabbitMQ.Client.Framing.v0_9.IAccessRequestOk, RabbitMQ.Client.IMethod
    {
        public const int ClassId = 30;
        public const int MethodId = 11;
        public ushort m_ticket;
        public AccessRequestOk() { }
        public AccessRequestOk(ushort initTicket) { }
        public override bool HasContent { get { throw null; } }
        public override int ProtocolClassId { get { throw null; } }
        public override int ProtocolMethodId { get { throw null; } }
        public override string ProtocolMethodName { get { throw null; } }
        ushort RabbitMQ.Client.Framing.v0_9.IAccessRequestOk.Ticket { get { throw null; } }
        public override void AppendArgumentDebugStringTo(System.Text.StringBuilder sb) { }
        public override void ReadArgumentsFrom(RabbitMQ.Client.Impl.MethodArgumentReader reader) { }
        public override void WriteArgumentsTo(RabbitMQ.Client.Impl.MethodArgumentWriter writer) { }
    }
    public partial class BasicAck : RabbitMQ.Client.Impl.MethodBase, RabbitMQ.Client.Framing.v0_9.IBasicAck, RabbitMQ.Client.IMethod
    {
        public const int ClassId = 60;
        public const int MethodId = 80;
        public ulong m_deliveryTag;
        public bool m_multiple;
        public BasicAck() { }
        public BasicAck(ulong initDeliveryTag, bool initMultiple) { }
        public override bool HasContent { get { throw null; } }
        public override int ProtocolClassId { get { throw null; } }
        public override int ProtocolMethodId { get { throw null; } }
        public override string ProtocolMethodName { get { throw null; } }
        ulong RabbitMQ.Client.Framing.v0_9.IBasicAck.DeliveryTag { get { throw null; } }
        bool RabbitMQ.Client.Framing.v0_9.IBasicAck.Multiple { get { throw null; } }
        public override void AppendArgumentDebugStringTo(System.Text.StringBuilder sb) { }
        public override void ReadArgumentsFrom(RabbitMQ.Client.Impl.MethodArgumentReader reader) { }
        public override void WriteArgumentsTo(RabbitMQ.Client.Impl.MethodArgumentWriter writer) { }
    }
    public partial class BasicCancel : RabbitMQ.Client.Impl.MethodBase, RabbitMQ.Client.Framing.v0_9.IBasicCancel, RabbitMQ.Client.IMethod
    {
        public const int ClassId = 60;
        public const int MethodId = 30;
        public string m_consumerTag;
        public bool m_nowait;
        public BasicCancel() { }
        public BasicCancel(string initConsumerTag, bool initNowait) { }
        public override bool HasContent { get { throw null; } }
        public override int ProtocolClassId { get { throw null; } }
        public override int ProtocolMethodId { get { throw null; } }
        public override string ProtocolMethodName { get { throw null; } }
        string RabbitMQ.Client.Framing.v0_9.IBasicCancel.ConsumerTag { get { throw null; } }
        bool RabbitMQ.Client.Framing.v0_9.IBasicCancel.Nowait { get { throw null; } }
        public override void AppendArgumentDebugStringTo(System.Text.StringBuilder sb) { }
        public override void ReadArgumentsFrom(RabbitMQ.Client.Impl.MethodArgumentReader reader) { }
        public override void WriteArgumentsTo(RabbitMQ.Client.Impl.MethodArgumentWriter writer) { }
    }
    public partial class BasicCancelOk : RabbitMQ.Client.Impl.MethodBase, RabbitMQ.Client.Framing.v0_9.IBasicCancelOk, RabbitMQ.Client.IMethod
    {
        public const int ClassId = 60;
        public const int MethodId = 31;
        public string m_consumerTag;
        public BasicCancelOk() { }
        public BasicCancelOk(string initConsumerTag) { }
        public override bool HasContent { get { throw null; } }
        public override int ProtocolClassId { get { throw null; } }
        public override int ProtocolMethodId { get { throw null; } }
        public override string ProtocolMethodName { get { throw null; } }
        string RabbitMQ.Client.Framing.v0_9.IBasicCancelOk.ConsumerTag { get { throw null; } }
        public override void AppendArgumentDebugStringTo(System.Text.StringBuilder sb) { }
        public override void ReadArgumentsFrom(RabbitMQ.Client.Impl.MethodArgumentReader reader) { }
        public override void WriteArgumentsTo(RabbitMQ.Client.Impl.MethodArgumentWriter writer) { }
    }
    public partial class BasicConsume : RabbitMQ.Client.Impl.MethodBase, RabbitMQ.Client.Framing.v0_9.IBasicConsume, RabbitMQ.Client.IMethod
    {
        public const int ClassId = 60;
        public const int MethodId = 20;
        public string m_consumerTag;
        public bool m_exclusive;
        public System.Collections.IDictionary m_filter;
        public bool m_noAck;
        public bool m_noLocal;
        public bool m_nowait;
        public string m_queue;
        public ushort m_ticket;
        public BasicConsume() { }
        public BasicConsume(ushort initTicket, string initQueue, string initConsumerTag, bool initNoLocal, bool initNoAck, bool initExclusive, bool initNowait, System.Collections.IDictionary initFilter) { }
        public override bool HasContent { get { throw null; } }
        public override int ProtocolClassId { get { throw null; } }
        public override int ProtocolMethodId { get { throw null; } }
        public override string ProtocolMethodName { get { throw null; } }
        string RabbitMQ.Client.Framing.v0_9.IBasicConsume.ConsumerTag { get { throw null; } }
        bool RabbitMQ.Client.Framing.v0_9.IBasicConsume.Exclusive { get { throw null; } }
        System.Collections.IDictionary RabbitMQ.Client.Framing.v0_9.IBasicConsume.Filter { get { throw null; } }
        bool RabbitMQ.Client.Framing.v0_9.IBasicConsume.NoAck { get { throw null; } }
        bool RabbitMQ.Client.Framing.v0_9.IBasicConsume.NoLocal { get { throw null; } }
        bool RabbitMQ.Client.Framing.v0_9.IBasicConsume.Nowait { get { throw null; } }
        string RabbitMQ.Client.Framing.v0_9.IBasicConsume.Queue { get { throw null; } }
        ushort RabbitMQ.Client.Framing.v0_9.IBasicConsume.Ticket { get { throw null; } }
        public override void AppendArgumentDebugStringTo(System.Text.StringBuilder sb) { }
        public override void ReadArgumentsFrom(RabbitMQ.Client.Impl.MethodArgumentReader reader) { }
        public override void WriteArgumentsTo(RabbitMQ.Client.Impl.MethodArgumentWriter writer) { }
    }
    public partial class BasicConsumeOk : RabbitMQ.Client.Impl.MethodBase, RabbitMQ.Client.Framing.v0_9.IBasicConsumeOk, RabbitMQ.Client.IMethod
    {
        public const int ClassId = 60;
        public const int MethodId = 21;
        public string m_consumerTag;
        public BasicConsumeOk() { }
        public BasicConsumeOk(string initConsumerTag) { }
        public override bool HasContent { get { throw null; } }
        public override int ProtocolClassId { get { throw null; } }
        public override int ProtocolMethodId { get { throw null; } }
        public override string ProtocolMethodName { get { throw null; } }
        string RabbitMQ.Client.Framing.v0_9.IBasicConsumeOk.ConsumerTag { get { throw null; } }
        public override void AppendArgumentDebugStringTo(System.Text.StringBuilder sb) { }
        public override void ReadArgumentsFrom(RabbitMQ.Client.Impl.MethodArgumentReader reader) { }
        public override void WriteArgumentsTo(RabbitMQ.Client.Impl.MethodArgumentWriter writer) { }
    }
    public partial class BasicDeliver : RabbitMQ.Client.Impl.MethodBase, RabbitMQ.Client.Framing.v0_9.IBasicDeliver, RabbitMQ.Client.IMethod
    {
        public const int ClassId = 60;
        public const int MethodId = 60;
        public string m_consumerTag;
        public ulong m_deliveryTag;
        public string m_exchange;
        public bool m_redelivered;
        public string m_routingKey;
        public BasicDeliver() { }
        public BasicDeliver(string initConsumerTag, ulong initDeliveryTag, bool initRedelivered, string initExchange, string initRoutingKey) { }
        public override bool HasContent { get { throw null; } }
        public override int ProtocolClassId { get { throw null; } }
        public override int ProtocolMethodId { get { throw null; } }
        public override string ProtocolMethodName { get { throw null; } }
        string RabbitMQ.Client.Framing.v0_9.IBasicDeliver.ConsumerTag { get { throw null; } }
        ulong RabbitMQ.Client.Framing.v0_9.IBasicDeliver.DeliveryTag { get { throw null; } }
        string RabbitMQ.Client.Framing.v0_9.IBasicDeliver.Exchange { get { throw null; } }
        bool RabbitMQ.Client.Framing.v0_9.IBasicDeliver.Redelivered { get { throw null; } }
        string RabbitMQ.Client.Framing.v0_9.IBasicDeliver.RoutingKey { get { throw null; } }
        public override void AppendArgumentDebugStringTo(System.Text.StringBuilder sb) { }
        public override void ReadArgumentsFrom(RabbitMQ.Client.Impl.MethodArgumentReader reader) { }
        public override void WriteArgumentsTo(RabbitMQ.Client.Impl.MethodArgumentWriter writer) { }
    }
    public partial class BasicGet : RabbitMQ.Client.Impl.MethodBase, RabbitMQ.Client.Framing.v0_9.IBasicGet, RabbitMQ.Client.IMethod
    {
        public const int ClassId = 60;
        public const int MethodId = 70;
        public bool m_noAck;
        public string m_queue;
        public ushort m_ticket;
        public BasicGet() { }
        public BasicGet(ushort initTicket, string initQueue, bool initNoAck) { }
        public override bool HasContent { get { throw null; } }
        public override int ProtocolClassId { get { throw null; } }
        public override int ProtocolMethodId { get { throw null; } }
        public override string ProtocolMethodName { get { throw null; } }
        bool RabbitMQ.Client.Framing.v0_9.IBasicGet.NoAck { get { throw null; } }
        string RabbitMQ.Client.Framing.v0_9.IBasicGet.Queue { get { throw null; } }
        ushort RabbitMQ.Client.Framing.v0_9.IBasicGet.Ticket { get { throw null; } }
        public override void AppendArgumentDebugStringTo(System.Text.StringBuilder sb) { }
        public override void ReadArgumentsFrom(RabbitMQ.Client.Impl.MethodArgumentReader reader) { }
        public override void WriteArgumentsTo(RabbitMQ.Client.Impl.MethodArgumentWriter writer) { }
    }
    public partial class BasicGetEmpty : RabbitMQ.Client.Impl.MethodBase, RabbitMQ.Client.Framing.v0_9.IBasicGetEmpty, RabbitMQ.Client.IMethod
    {
        public const int ClassId = 60;
        public const int MethodId = 72;
        public string m_clusterId;
        public BasicGetEmpty() { }
        public BasicGetEmpty(string initClusterId) { }
        public override bool HasContent { get { throw null; } }
        public override int ProtocolClassId { get { throw null; } }
        public override int ProtocolMethodId { get { throw null; } }
        public override string ProtocolMethodName { get { throw null; } }
        string RabbitMQ.Client.Framing.v0_9.IBasicGetEmpty.ClusterId { get { throw null; } }
        public override void AppendArgumentDebugStringTo(System.Text.StringBuilder sb) { }
        public override void ReadArgumentsFrom(RabbitMQ.Client.Impl.MethodArgumentReader reader) { }
        public override void WriteArgumentsTo(RabbitMQ.Client.Impl.MethodArgumentWriter writer) { }
    }
    public partial class BasicGetOk : RabbitMQ.Client.Impl.MethodBase, RabbitMQ.Client.Framing.v0_9.IBasicGetOk, RabbitMQ.Client.IMethod
    {
        public const int ClassId = 60;
        public const int MethodId = 71;
        public ulong m_deliveryTag;
        public string m_exchange;
        public uint m_messageCount;
        public bool m_redelivered;
        public string m_routingKey;
        public BasicGetOk() { }
        public BasicGetOk(ulong initDeliveryTag, bool initRedelivered, string initExchange, string initRoutingKey, uint initMessageCount) { }
        public override bool HasContent { get { throw null; } }
        public override int ProtocolClassId { get { throw null; } }
        public override int ProtocolMethodId { get { throw null; } }
        public override string ProtocolMethodName { get { throw null; } }
        ulong RabbitMQ.Client.Framing.v0_9.IBasicGetOk.DeliveryTag { get { throw null; } }
        string RabbitMQ.Client.Framing.v0_9.IBasicGetOk.Exchange { get { throw null; } }
        uint RabbitMQ.Client.Framing.v0_9.IBasicGetOk.MessageCount { get { throw null; } }
        bool RabbitMQ.Client.Framing.v0_9.IBasicGetOk.Redelivered { get { throw null; } }
        string RabbitMQ.Client.Framing.v0_9.IBasicGetOk.RoutingKey { get { throw null; } }
        public override void AppendArgumentDebugStringTo(System.Text.StringBuilder sb) { }
        public override void ReadArgumentsFrom(RabbitMQ.Client.Impl.MethodArgumentReader reader) { }
        public override void WriteArgumentsTo(RabbitMQ.Client.Impl.MethodArgumentWriter writer) { }
    }
    public partial class BasicPublish : RabbitMQ.Client.Impl.MethodBase, RabbitMQ.Client.Framing.v0_9.IBasicPublish, RabbitMQ.Client.IMethod
    {
        public const int ClassId = 60;
        public const int MethodId = 40;
        public string m_exchange;
        public bool m_immediate;
        public bool m_mandatory;
        public string m_routingKey;
        public ushort m_ticket;
        public BasicPublish() { }
        public BasicPublish(ushort initTicket, string initExchange, string initRoutingKey, bool initMandatory, bool initImmediate) { }
        public override bool HasContent { get { throw null; } }
        public override int ProtocolClassId { get { throw null; } }
        public override int ProtocolMethodId { get { throw null; } }
        public override string ProtocolMethodName { get { throw null; } }
        string RabbitMQ.Client.Framing.v0_9.IBasicPublish.Exchange { get { throw null; } }
        bool RabbitMQ.Client.Framing.v0_9.IBasicPublish.Immediate { get { throw null; } }
        bool RabbitMQ.Client.Framing.v0_9.IBasicPublish.Mandatory { get { throw null; } }
        string RabbitMQ.Client.Framing.v0_9.IBasicPublish.RoutingKey { get { throw null; } }
        ushort RabbitMQ.Client.Framing.v0_9.IBasicPublish.Ticket { get { throw null; } }
        public override void AppendArgumentDebugStringTo(System.Text.StringBuilder sb) { }
        public override void ReadArgumentsFrom(RabbitMQ.Client.Impl.MethodArgumentReader reader) { }
        public override void WriteArgumentsTo(RabbitMQ.Client.Impl.MethodArgumentWriter writer) { }
    }
    public partial class BasicQos : RabbitMQ.Client.Impl.MethodBase, RabbitMQ.Client.Framing.v0_9.IBasicQos, RabbitMQ.Client.IMethod
    {
        public const int ClassId = 60;
        public const int MethodId = 10;
        public bool m_global;
        public ushort m_prefetchCount;
        public uint m_prefetchSize;
        public BasicQos() { }
        public BasicQos(uint initPrefetchSize, ushort initPrefetchCount, bool initGlobal) { }
        public override bool HasContent { get { throw null; } }
        public override int ProtocolClassId { get { throw null; } }
        public override int ProtocolMethodId { get { throw null; } }
        public override string ProtocolMethodName { get { throw null; } }
        bool RabbitMQ.Client.Framing.v0_9.IBasicQos.Global { get { throw null; } }
        ushort RabbitMQ.Client.Framing.v0_9.IBasicQos.PrefetchCount { get { throw null; } }
        uint RabbitMQ.Client.Framing.v0_9.IBasicQos.PrefetchSize { get { throw null; } }
        public override void AppendArgumentDebugStringTo(System.Text.StringBuilder sb) { }
        public override void ReadArgumentsFrom(RabbitMQ.Client.Impl.MethodArgumentReader reader) { }
        public override void WriteArgumentsTo(RabbitMQ.Client.Impl.MethodArgumentWriter writer) { }
    }
    public partial class BasicQosOk : RabbitMQ.Client.Impl.MethodBase, RabbitMQ.Client.Framing.v0_9.IBasicQosOk, RabbitMQ.Client.IMethod
    {
        public const int ClassId = 60;
        public const int MethodId = 11;
        public BasicQosOk() { }
        public override bool HasContent { get { throw null; } }
        public override int ProtocolClassId { get { throw null; } }
        public override int ProtocolMethodId { get { throw null; } }
        public override string ProtocolMethodName { get { throw null; } }
        public override void AppendArgumentDebugStringTo(System.Text.StringBuilder sb) { }
        public override void ReadArgumentsFrom(RabbitMQ.Client.Impl.MethodArgumentReader reader) { }
        public override void WriteArgumentsTo(RabbitMQ.Client.Impl.MethodArgumentWriter writer) { }
    }
    public partial class BasicRecover : RabbitMQ.Client.Impl.MethodBase, RabbitMQ.Client.Framing.v0_9.IBasicRecover, RabbitMQ.Client.IMethod
    {
        public const int ClassId = 60;
        public const int MethodId = 100;
        public bool m_requeue;
        public BasicRecover() { }
        public BasicRecover(bool initRequeue) { }
        public override bool HasContent { get { throw null; } }
        public override int ProtocolClassId { get { throw null; } }
        public override int ProtocolMethodId { get { throw null; } }
        public override string ProtocolMethodName { get { throw null; } }
        bool RabbitMQ.Client.Framing.v0_9.IBasicRecover.Requeue { get { throw null; } }
        public override void AppendArgumentDebugStringTo(System.Text.StringBuilder sb) { }
        public override void ReadArgumentsFrom(RabbitMQ.Client.Impl.MethodArgumentReader reader) { }
        public override void WriteArgumentsTo(RabbitMQ.Client.Impl.MethodArgumentWriter writer) { }
    }
    public partial class BasicReject : RabbitMQ.Client.Impl.MethodBase, RabbitMQ.Client.Framing.v0_9.IBasicReject, RabbitMQ.Client.IMethod
    {
        public const int ClassId = 60;
        public const int MethodId = 90;
        public ulong m_deliveryTag;
        public bool m_requeue;
        public BasicReject() { }
        public BasicReject(ulong initDeliveryTag, bool initRequeue) { }
        public override bool HasContent { get { throw null; } }
        public override int ProtocolClassId { get { throw null; } }
        public override int ProtocolMethodId { get { throw null; } }
        public override string ProtocolMethodName { get { throw null; } }
        ulong RabbitMQ.Client.Framing.v0_9.IBasicReject.DeliveryTag { get { throw null; } }
        bool RabbitMQ.Client.Framing.v0_9.IBasicReject.Requeue { get { throw null; } }
        public override void AppendArgumentDebugStringTo(System.Text.StringBuilder sb) { }
        public override void ReadArgumentsFrom(RabbitMQ.Client.Impl.MethodArgumentReader reader) { }
        public override void WriteArgumentsTo(RabbitMQ.Client.Impl.MethodArgumentWriter writer) { }
    }
    public partial class BasicReturn : RabbitMQ.Client.Impl.MethodBase, RabbitMQ.Client.Framing.v0_9.IBasicReturn, RabbitMQ.Client.IMethod
    {
        public const int ClassId = 60;
        public const int MethodId = 50;
        public string m_exchange;
        public ushort m_replyCode;
        public string m_replyText;
        public string m_routingKey;
        public BasicReturn() { }
        public BasicReturn(ushort initReplyCode, string initReplyText, string initExchange, string initRoutingKey) { }
        public override bool HasContent { get { throw null; } }
        public override int ProtocolClassId { get { throw null; } }
        public override int ProtocolMethodId { get { throw null; } }
        public override string ProtocolMethodName { get { throw null; } }
        string RabbitMQ.Client.Framing.v0_9.IBasicReturn.Exchange { get { throw null; } }
        ushort RabbitMQ.Client.Framing.v0_9.IBasicReturn.ReplyCode { get { throw null; } }
        string RabbitMQ.Client.Framing.v0_9.IBasicReturn.ReplyText { get { throw null; } }
        string RabbitMQ.Client.Framing.v0_9.IBasicReturn.RoutingKey { get { throw null; } }
        public override void AppendArgumentDebugStringTo(System.Text.StringBuilder sb) { }
        public override void ReadArgumentsFrom(RabbitMQ.Client.Impl.MethodArgumentReader reader) { }
        public override void WriteArgumentsTo(RabbitMQ.Client.Impl.MethodArgumentWriter writer) { }
    }
    public partial class ChannelClose : RabbitMQ.Client.Impl.MethodBase, RabbitMQ.Client.Framing.v0_9.IChannelClose, RabbitMQ.Client.IMethod
    {
        public const int ClassId = 20;
        public const int MethodId = 40;
        public ushort m_classId;
        public ushort m_methodId;
        public ushort m_replyCode;
        public string m_replyText;
        public ChannelClose() { }
        public ChannelClose(ushort initReplyCode, string initReplyText, ushort initClassId, ushort initMethodId) { }
        public override bool HasContent { get { throw null; } }
        public override int ProtocolClassId { get { throw null; } }
        public override int ProtocolMethodId { get { throw null; } }
        public override string ProtocolMethodName { get { throw null; } }
        ushort RabbitMQ.Client.Framing.v0_9.IChannelClose.ClassId { get { throw null; } }
        ushort RabbitMQ.Client.Framing.v0_9.IChannelClose.MethodId { get { throw null; } }
        ushort RabbitMQ.Client.Framing.v0_9.IChannelClose.ReplyCode { get { throw null; } }
        string RabbitMQ.Client.Framing.v0_9.IChannelClose.ReplyText { get { throw null; } }
        public override void AppendArgumentDebugStringTo(System.Text.StringBuilder sb) { }
        public override void ReadArgumentsFrom(RabbitMQ.Client.Impl.MethodArgumentReader reader) { }
        public override void WriteArgumentsTo(RabbitMQ.Client.Impl.MethodArgumentWriter writer) { }
    }
    public partial class ChannelCloseOk : RabbitMQ.Client.Impl.MethodBase, RabbitMQ.Client.Framing.v0_9.IChannelCloseOk, RabbitMQ.Client.IMethod
    {
        public const int ClassId = 20;
        public const int MethodId = 41;
        public ChannelCloseOk() { }
        public override bool HasContent { get { throw null; } }
        public override int ProtocolClassId { get { throw null; } }
        public override int ProtocolMethodId { get { throw null; } }
        public override string ProtocolMethodName { get { throw null; } }
        public override void AppendArgumentDebugStringTo(System.Text.StringBuilder sb) { }
        public override void ReadArgumentsFrom(RabbitMQ.Client.Impl.MethodArgumentReader reader) { }
        public override void WriteArgumentsTo(RabbitMQ.Client.Impl.MethodArgumentWriter writer) { }
    }
    public partial class ChannelFlow : RabbitMQ.Client.Impl.MethodBase, RabbitMQ.Client.Framing.v0_9.IChannelFlow, RabbitMQ.Client.IMethod
    {
        public const int ClassId = 20;
        public const int MethodId = 20;
        public bool m_active;
        public ChannelFlow() { }
        public ChannelFlow(bool initActive) { }
        public override bool HasContent { get { throw null; } }
        public override int ProtocolClassId { get { throw null; } }
        public override int ProtocolMethodId { get { throw null; } }
        public override string ProtocolMethodName { get { throw null; } }
        bool RabbitMQ.Client.Framing.v0_9.IChannelFlow.Active { get { throw null; } }
        public override void AppendArgumentDebugStringTo(System.Text.StringBuilder sb) { }
        public override void ReadArgumentsFrom(RabbitMQ.Client.Impl.MethodArgumentReader reader) { }
        public override void WriteArgumentsTo(RabbitMQ.Client.Impl.MethodArgumentWriter writer) { }
    }
    public partial class ChannelFlowOk : RabbitMQ.Client.Impl.MethodBase, RabbitMQ.Client.Framing.v0_9.IChannelFlowOk, RabbitMQ.Client.IMethod
    {
        public const int ClassId = 20;
        public const int MethodId = 21;
        public bool m_active;
        public ChannelFlowOk() { }
        public ChannelFlowOk(bool initActive) { }
        public override bool HasContent { get { throw null; } }
        public override int ProtocolClassId { get { throw null; } }
        public override int ProtocolMethodId { get { throw null; } }
        public override string ProtocolMethodName { get { throw null; } }
        bool RabbitMQ.Client.Framing.v0_9.IChannelFlowOk.Active { get { throw null; } }
        public override void AppendArgumentDebugStringTo(System.Text.StringBuilder sb) { }
        public override void ReadArgumentsFrom(RabbitMQ.Client.Impl.MethodArgumentReader reader) { }
        public override void WriteArgumentsTo(RabbitMQ.Client.Impl.MethodArgumentWriter writer) { }
    }
    public partial class ChannelOk : RabbitMQ.Client.Impl.MethodBase, RabbitMQ.Client.Framing.v0_9.IChannelOk, RabbitMQ.Client.IMethod
    {
        public const int ClassId = 20;
        public const int MethodId = 80;
        public ChannelOk() { }
        public override bool HasContent { get { throw null; } }
        public override int ProtocolClassId { get { throw null; } }
        public override int ProtocolMethodId { get { throw null; } }
        public override string ProtocolMethodName { get { throw null; } }
        public override void AppendArgumentDebugStringTo(System.Text.StringBuilder sb) { }
        public override void ReadArgumentsFrom(RabbitMQ.Client.Impl.MethodArgumentReader reader) { }
        public override void WriteArgumentsTo(RabbitMQ.Client.Impl.MethodArgumentWriter writer) { }
    }
    public partial class ChannelOpen : RabbitMQ.Client.Impl.MethodBase, RabbitMQ.Client.Framing.v0_9.IChannelOpen, RabbitMQ.Client.IMethod
    {
        public const int ClassId = 20;
        public const int MethodId = 10;
        public string m_outOfBand;
        public ChannelOpen() { }
        public ChannelOpen(string initOutOfBand) { }
        public override bool HasContent { get { throw null; } }
        public override int ProtocolClassId { get { throw null; } }
        public override int ProtocolMethodId { get { throw null; } }
        public override string ProtocolMethodName { get { throw null; } }
        string RabbitMQ.Client.Framing.v0_9.IChannelOpen.OutOfBand { get { throw null; } }
        public override void AppendArgumentDebugStringTo(System.Text.StringBuilder sb) { }
        public override void ReadArgumentsFrom(RabbitMQ.Client.Impl.MethodArgumentReader reader) { }
        public override void WriteArgumentsTo(RabbitMQ.Client.Impl.MethodArgumentWriter writer) { }
    }
    public partial class ChannelOpenOk : RabbitMQ.Client.Impl.MethodBase, RabbitMQ.Client.Framing.v0_9.IChannelOpenOk, RabbitMQ.Client.IMethod
    {
        public const int ClassId = 20;
        public const int MethodId = 11;
        public byte[] m_channelId;
        public ChannelOpenOk() { }
        public ChannelOpenOk(byte[] initChannelId) { }
        public override bool HasContent { get { throw null; } }
        public override int ProtocolClassId { get { throw null; } }
        public override int ProtocolMethodId { get { throw null; } }
        public override string ProtocolMethodName { get { throw null; } }
        byte[] RabbitMQ.Client.Framing.v0_9.IChannelOpenOk.ChannelId { get { throw null; } }
        public override void AppendArgumentDebugStringTo(System.Text.StringBuilder sb) { }
        public override void ReadArgumentsFrom(RabbitMQ.Client.Impl.MethodArgumentReader reader) { }
        public override void WriteArgumentsTo(RabbitMQ.Client.Impl.MethodArgumentWriter writer) { }
    }
    public partial class ChannelPing : RabbitMQ.Client.Impl.MethodBase, RabbitMQ.Client.Framing.v0_9.IChannelPing, RabbitMQ.Client.IMethod
    {
        public const int ClassId = 20;
        public const int MethodId = 60;
        public ChannelPing() { }
        public override bool HasContent { get { throw null; } }
        public override int ProtocolClassId { get { throw null; } }
        public override int ProtocolMethodId { get { throw null; } }
        public override string ProtocolMethodName { get { throw null; } }
        public override void AppendArgumentDebugStringTo(System.Text.StringBuilder sb) { }
        public override void ReadArgumentsFrom(RabbitMQ.Client.Impl.MethodArgumentReader reader) { }
        public override void WriteArgumentsTo(RabbitMQ.Client.Impl.MethodArgumentWriter writer) { }
    }
    public partial class ChannelPong : RabbitMQ.Client.Impl.MethodBase, RabbitMQ.Client.Framing.v0_9.IChannelPong, RabbitMQ.Client.IMethod
    {
        public const int ClassId = 20;
        public const int MethodId = 70;
        public ChannelPong() { }
        public override bool HasContent { get { throw null; } }
        public override int ProtocolClassId { get { throw null; } }
        public override int ProtocolMethodId { get { throw null; } }
        public override string ProtocolMethodName { get { throw null; } }
        public override void AppendArgumentDebugStringTo(System.Text.StringBuilder sb) { }
        public override void ReadArgumentsFrom(RabbitMQ.Client.Impl.MethodArgumentReader reader) { }
        public override void WriteArgumentsTo(RabbitMQ.Client.Impl.MethodArgumentWriter writer) { }
    }
    public partial class ChannelResume : RabbitMQ.Client.Impl.MethodBase, RabbitMQ.Client.Framing.v0_9.IChannelResume, RabbitMQ.Client.IMethod
    {
        public const int ClassId = 20;
        public const int MethodId = 50;
        public byte[] m_channelId;
        public ChannelResume() { }
        public ChannelResume(byte[] initChannelId) { }
        public override bool HasContent { get { throw null; } }
        public override int ProtocolClassId { get { throw null; } }
        public override int ProtocolMethodId { get { throw null; } }
        public override string ProtocolMethodName { get { throw null; } }
        byte[] RabbitMQ.Client.Framing.v0_9.IChannelResume.ChannelId { get { throw null; } }
        public override void AppendArgumentDebugStringTo(System.Text.StringBuilder sb) { }
        public override void ReadArgumentsFrom(RabbitMQ.Client.Impl.MethodArgumentReader reader) { }
        public override void WriteArgumentsTo(RabbitMQ.Client.Impl.MethodArgumentWriter writer) { }
    }
    public enum ClassId
    {
        Access = 30,
        Basic = 60,
        Channel = 20,
        Connection = 10,
        Dtx = 100,
        Exchange = 40,
        File = 70,
        Invalid = -1,
        Message = 120,
        Queue = 50,
        Stream = 80,
        Tunnel = 110,
        Tx = 90,
    }
    public partial class Connection : RabbitMQ.Client.Impl.ConnectionBase
    {
        public Connection(RabbitMQ.Client.ConnectionFactory factory, bool insist, RabbitMQ.Client.Impl.IFrameHandler frameHandler) : base (default(RabbitMQ.Client.ConnectionFactory), default(bool), default(RabbitMQ.Client.Impl.IFrameHandler)) { }
    }
    public partial class ConnectionClose : RabbitMQ.Client.Impl.MethodBase, RabbitMQ.Client.Framing.v0_9.IConnectionClose, RabbitMQ.Client.IMethod
    {
        public const int ClassId = 10;
        public const int MethodId = 50;
        public ushort m_classId;
        public ushort m_methodId;
        public ushort m_replyCode;
        public string m_replyText;
        public ConnectionClose() { }
        public ConnectionClose(ushort initReplyCode, string initReplyText, ushort initClassId, ushort initMethodId) { }
        public override bool HasContent { get { throw null; } }
        public override int ProtocolClassId { get { throw null; } }
        public override int ProtocolMethodId { get { throw null; } }
        public override string ProtocolMethodName { get { throw null; } }
        ushort RabbitMQ.Client.Framing.v0_9.IConnectionClose.ClassId { get { throw null; } }
        ushort RabbitMQ.Client.Framing.v0_9.IConnectionClose.MethodId { get { throw null; } }
        ushort RabbitMQ.Client.Framing.v0_9.IConnectionClose.ReplyCode { get { throw null; } }
        string RabbitMQ.Client.Framing.v0_9.IConnectionClose.ReplyText { get { throw null; } }
        public override void AppendArgumentDebugStringTo(System.Text.StringBuilder sb) { }
        public override void ReadArgumentsFrom(RabbitMQ.Client.Impl.MethodArgumentReader reader) { }
        public override void WriteArgumentsTo(RabbitMQ.Client.Impl.MethodArgumentWriter writer) { }
    }
    public partial class ConnectionCloseOk : RabbitMQ.Client.Impl.MethodBase, RabbitMQ.Client.Framing.v0_9.IConnectionCloseOk, RabbitMQ.Client.IMethod
    {
        public const int ClassId = 10;
        public const int MethodId = 51;
        public ConnectionCloseOk() { }
        public override bool HasContent { get { throw null; } }
        public override int ProtocolClassId { get { throw null; } }
        public override int ProtocolMethodId { get { throw null; } }
        public override string ProtocolMethodName { get { throw null; } }
        public override void AppendArgumentDebugStringTo(System.Text.StringBuilder sb) { }
        public override void ReadArgumentsFrom(RabbitMQ.Client.Impl.MethodArgumentReader reader) { }
        public override void WriteArgumentsTo(RabbitMQ.Client.Impl.MethodArgumentWriter writer) { }
    }
    public partial class ConnectionOpen : RabbitMQ.Client.Impl.MethodBase, RabbitMQ.Client.Framing.v0_9.IConnectionOpen, RabbitMQ.Client.IMethod
    {
        public const int ClassId = 10;
        public const int MethodId = 40;
        public string m_capabilities;
        public bool m_insist;
        public string m_virtualHost;
        public ConnectionOpen() { }
        public ConnectionOpen(string initVirtualHost, string initCapabilities, bool initInsist) { }
        public override bool HasContent { get { throw null; } }
        public override int ProtocolClassId { get { throw null; } }
        public override int ProtocolMethodId { get { throw null; } }
        public override string ProtocolMethodName { get { throw null; } }
        string RabbitMQ.Client.Framing.v0_9.IConnectionOpen.Capabilities { get { throw null; } }
        bool RabbitMQ.Client.Framing.v0_9.IConnectionOpen.Insist { get { throw null; } }
        string RabbitMQ.Client.Framing.v0_9.IConnectionOpen.VirtualHost { get { throw null; } }
        public override void AppendArgumentDebugStringTo(System.Text.StringBuilder sb) { }
        public override void ReadArgumentsFrom(RabbitMQ.Client.Impl.MethodArgumentReader reader) { }
        public override void WriteArgumentsTo(RabbitMQ.Client.Impl.MethodArgumentWriter writer) { }
    }
    public partial class ConnectionOpenOk : RabbitMQ.Client.Impl.MethodBase, RabbitMQ.Client.Framing.v0_9.IConnectionOpenOk, RabbitMQ.Client.IMethod
    {
        public const int ClassId = 10;
        public const int MethodId = 41;
        public string m_knownHosts;
        public ConnectionOpenOk() { }
        public ConnectionOpenOk(string initKnownHosts) { }
        public override bool HasContent { get { throw null; } }
        public override int ProtocolClassId { get { throw null; } }
        public override int ProtocolMethodId { get { throw null; } }
        public override string ProtocolMethodName { get { throw null; } }
        string RabbitMQ.Client.Framing.v0_9.IConnectionOpenOk.KnownHosts { get { throw null; } }
        public override void AppendArgumentDebugStringTo(System.Text.StringBuilder sb) { }
        public override void ReadArgumentsFrom(RabbitMQ.Client.Impl.MethodArgumentReader reader) { }
        public override void WriteArgumentsTo(RabbitMQ.Client.Impl.MethodArgumentWriter writer) { }
    }
    public partial class ConnectionRedirect : RabbitMQ.Client.Impl.MethodBase, RabbitMQ.Client.Framing.v0_9.IConnectionRedirect, RabbitMQ.Client.IMethod
    {
        public const int ClassId = 10;
        public const int MethodId = 42;
        public string m_host;
        public string m_knownHosts;
        public ConnectionRedirect() { }
        public ConnectionRedirect(string initHost, string initKnownHosts) { }
        public override bool HasContent { get { throw null; } }
        public override int ProtocolClassId { get { throw null; } }
        public override int ProtocolMethodId { get { throw null; } }
        public override string ProtocolMethodName { get { throw null; } }
        string RabbitMQ.Client.Framing.v0_9.IConnectionRedirect.Host { get { throw null; } }
        string RabbitMQ.Client.Framing.v0_9.IConnectionRedirect.KnownHosts { get { throw null; } }
        public override void AppendArgumentDebugStringTo(System.Text.StringBuilder sb) { }
        public override void ReadArgumentsFrom(RabbitMQ.Client.Impl.MethodArgumentReader reader) { }
        public override void WriteArgumentsTo(RabbitMQ.Client.Impl.MethodArgumentWriter writer) { }
    }
    public partial class ConnectionSecure : RabbitMQ.Client.Impl.MethodBase, RabbitMQ.Client.Framing.v0_9.IConnectionSecure, RabbitMQ.Client.IMethod
    {
        public const int ClassId = 10;
        public const int MethodId = 20;
        public byte[] m_challenge;
        public ConnectionSecure() { }
        public ConnectionSecure(byte[] initChallenge) { }
        public override bool HasContent { get { throw null; } }
        public override int ProtocolClassId { get { throw null; } }
        public override int ProtocolMethodId { get { throw null; } }
        public override string ProtocolMethodName { get { throw null; } }
        byte[] RabbitMQ.Client.Framing.v0_9.IConnectionSecure.Challenge { get { throw null; } }
        public override void AppendArgumentDebugStringTo(System.Text.StringBuilder sb) { }
        public override void ReadArgumentsFrom(RabbitMQ.Client.Impl.MethodArgumentReader reader) { }
        public override void WriteArgumentsTo(RabbitMQ.Client.Impl.MethodArgumentWriter writer) { }
    }
    public partial class ConnectionSecureOk : RabbitMQ.Client.Impl.MethodBase, RabbitMQ.Client.Framing.v0_9.IConnectionSecureOk, RabbitMQ.Client.IMethod
    {
        public const int ClassId = 10;
        public const int MethodId = 21;
        public byte[] m_response;
        public ConnectionSecureOk() { }
        public ConnectionSecureOk(byte[] initResponse) { }
        public override bool HasContent { get { throw null; } }
        public override int ProtocolClassId { get { throw null; } }
        public override int ProtocolMethodId { get { throw null; } }
        public override string ProtocolMethodName { get { throw null; } }
        byte[] RabbitMQ.Client.Framing.v0_9.IConnectionSecureOk.Response { get { throw null; } }
        public override void AppendArgumentDebugStringTo(System.Text.StringBuilder sb) { }
        public override void ReadArgumentsFrom(RabbitMQ.Client.Impl.MethodArgumentReader reader) { }
        public override void WriteArgumentsTo(RabbitMQ.Client.Impl.MethodArgumentWriter writer) { }
    }
    public partial class ConnectionStart : RabbitMQ.Client.Impl.MethodBase, RabbitMQ.Client.Framing.v0_9.IConnectionStart, RabbitMQ.Client.IMethod
    {
        public const int ClassId = 10;
        public const int MethodId = 10;
        public byte[] m_locales;
        public byte[] m_mechanisms;
        public System.Collections.IDictionary m_serverProperties;
        public byte m_versionMajor;
        public byte m_versionMinor;
        public ConnectionStart() { }
        public ConnectionStart(byte initVersionMajor, byte initVersionMinor, System.Collections.IDictionary initServerProperties, byte[] initMechanisms, byte[] initLocales) { }
        public override bool HasContent { get { throw null; } }
        public override int ProtocolClassId { get { throw null; } }
        public override int ProtocolMethodId { get { throw null; } }
        public override string ProtocolMethodName { get { throw null; } }
        byte[] RabbitMQ.Client.Framing.v0_9.IConnectionStart.Locales { get { throw null; } }
        byte[] RabbitMQ.Client.Framing.v0_9.IConnectionStart.Mechanisms { get { throw null; } }
        System.Collections.IDictionary RabbitMQ.Client.Framing.v0_9.IConnectionStart.ServerProperties { get { throw null; } }
        byte RabbitMQ.Client.Framing.v0_9.IConnectionStart.VersionMajor { get { throw null; } }
        byte RabbitMQ.Client.Framing.v0_9.IConnectionStart.VersionMinor { get { throw null; } }
        public override void AppendArgumentDebugStringTo(System.Text.StringBuilder sb) { }
        public override void ReadArgumentsFrom(RabbitMQ.Client.Impl.MethodArgumentReader reader) { }
        public override void WriteArgumentsTo(RabbitMQ.Client.Impl.MethodArgumentWriter writer) { }
    }
    public partial class ConnectionStartOk : RabbitMQ.Client.Impl.MethodBase, RabbitMQ.Client.Framing.v0_9.IConnectionStartOk, RabbitMQ.Client.IMethod
    {
        public const int ClassId = 10;
        public const int MethodId = 11;
        public System.Collections.IDictionary m_clientProperties;
        public string m_locale;
        public string m_mechanism;
        public byte[] m_response;
        public ConnectionStartOk() { }
        public ConnectionStartOk(System.Collections.IDictionary initClientProperties, string initMechanism, byte[] initResponse, string initLocale) { }
        public override bool HasContent { get { throw null; } }
        public override int ProtocolClassId { get { throw null; } }
        public override int ProtocolMethodId { get { throw null; } }
        public override string ProtocolMethodName { get { throw null; } }
        System.Collections.IDictionary RabbitMQ.Client.Framing.v0_9.IConnectionStartOk.ClientProperties { get { throw null; } }
        string RabbitMQ.Client.Framing.v0_9.IConnectionStartOk.Locale { get { throw null; } }
        string RabbitMQ.Client.Framing.v0_9.IConnectionStartOk.Mechanism { get { throw null; } }
        byte[] RabbitMQ.Client.Framing.v0_9.IConnectionStartOk.Response { get { throw null; } }
        public override void AppendArgumentDebugStringTo(System.Text.StringBuilder sb) { }
        public override void ReadArgumentsFrom(RabbitMQ.Client.Impl.MethodArgumentReader reader) { }
        public override void WriteArgumentsTo(RabbitMQ.Client.Impl.MethodArgumentWriter writer) { }
    }
    public partial class ConnectionTune : RabbitMQ.Client.Impl.MethodBase, RabbitMQ.Client.Framing.v0_9.IConnectionTune, RabbitMQ.Client.IMethod
    {
        public const int ClassId = 10;
        public const int MethodId = 30;
        public ushort m_channelMax;
        public uint m_frameMax;
        public ushort m_heartbeat;
        public ConnectionTune() { }
        public ConnectionTune(ushort initChannelMax, uint initFrameMax, ushort initHeartbeat) { }
        public override bool HasContent { get { throw null; } }
        public override int ProtocolClassId { get { throw null; } }
        public override int ProtocolMethodId { get { throw null; } }
        public override string ProtocolMethodName { get { throw null; } }
        ushort RabbitMQ.Client.Framing.v0_9.IConnectionTune.ChannelMax { get { throw null; } }
        uint RabbitMQ.Client.Framing.v0_9.IConnectionTune.FrameMax { get { throw null; } }
        ushort RabbitMQ.Client.Framing.v0_9.IConnectionTune.Heartbeat { get { throw null; } }
        public override void AppendArgumentDebugStringTo(System.Text.StringBuilder sb) { }
        public override void ReadArgumentsFrom(RabbitMQ.Client.Impl.MethodArgumentReader reader) { }
        public override void WriteArgumentsTo(RabbitMQ.Client.Impl.MethodArgumentWriter writer) { }
    }
    public partial class ConnectionTuneOk : RabbitMQ.Client.Impl.MethodBase, RabbitMQ.Client.Framing.v0_9.IConnectionTuneOk, RabbitMQ.Client.IMethod
    {
        public const int ClassId = 10;
        public const int MethodId = 31;
        public ushort m_channelMax;
        public uint m_frameMax;
        public ushort m_heartbeat;
        public ConnectionTuneOk() { }
        public ConnectionTuneOk(ushort initChannelMax, uint initFrameMax, ushort initHeartbeat) { }
        public override bool HasContent { get { throw null; } }
        public override int ProtocolClassId { get { throw null; } }
        public override int ProtocolMethodId { get { throw null; } }
        public override string ProtocolMethodName { get { throw null; } }
        ushort RabbitMQ.Client.Framing.v0_9.IConnectionTuneOk.ChannelMax { get { throw null; } }
        uint RabbitMQ.Client.Framing.v0_9.IConnectionTuneOk.FrameMax { get { throw null; } }
        ushort RabbitMQ.Client.Framing.v0_9.IConnectionTuneOk.Heartbeat { get { throw null; } }
        public override void AppendArgumentDebugStringTo(System.Text.StringBuilder sb) { }
        public override void ReadArgumentsFrom(RabbitMQ.Client.Impl.MethodArgumentReader reader) { }
        public override void WriteArgumentsTo(RabbitMQ.Client.Impl.MethodArgumentWriter writer) { }
    }
    public partial class DtxSelect : RabbitMQ.Client.Impl.MethodBase, RabbitMQ.Client.Framing.v0_9.IDtxSelect, RabbitMQ.Client.IMethod
    {
        public const int ClassId = 100;
        public const int MethodId = 10;
        public DtxSelect() { }
        public override bool HasContent { get { throw null; } }
        public override int ProtocolClassId { get { throw null; } }
        public override int ProtocolMethodId { get { throw null; } }
        public override string ProtocolMethodName { get { throw null; } }
        public override void AppendArgumentDebugStringTo(System.Text.StringBuilder sb) { }
        public override void ReadArgumentsFrom(RabbitMQ.Client.Impl.MethodArgumentReader reader) { }
        public override void WriteArgumentsTo(RabbitMQ.Client.Impl.MethodArgumentWriter writer) { }
    }
    public partial class DtxSelectOk : RabbitMQ.Client.Impl.MethodBase, RabbitMQ.Client.Framing.v0_9.IDtxSelectOk, RabbitMQ.Client.IMethod
    {
        public const int ClassId = 100;
        public const int MethodId = 11;
        public DtxSelectOk() { }
        public override bool HasContent { get { throw null; } }
        public override int ProtocolClassId { get { throw null; } }
        public override int ProtocolMethodId { get { throw null; } }
        public override string ProtocolMethodName { get { throw null; } }
        public override void AppendArgumentDebugStringTo(System.Text.StringBuilder sb) { }
        public override void ReadArgumentsFrom(RabbitMQ.Client.Impl.MethodArgumentReader reader) { }
        public override void WriteArgumentsTo(RabbitMQ.Client.Impl.MethodArgumentWriter writer) { }
    }
    public partial class DtxStart : RabbitMQ.Client.Impl.MethodBase, RabbitMQ.Client.Framing.v0_9.IDtxStart, RabbitMQ.Client.IMethod
    {
        public const int ClassId = 100;
        public const int MethodId = 20;
        public string m_dtxIdentifier;
        public DtxStart() { }
        public DtxStart(string initDtxIdentifier) { }
        public override bool HasContent { get { throw null; } }
        public override int ProtocolClassId { get { throw null; } }
        public override int ProtocolMethodId { get { throw null; } }
        public override string ProtocolMethodName { get { throw null; } }
        string RabbitMQ.Client.Framing.v0_9.IDtxStart.DtxIdentifier { get { throw null; } }
        public override void AppendArgumentDebugStringTo(System.Text.StringBuilder sb) { }
        public override void ReadArgumentsFrom(RabbitMQ.Client.Impl.MethodArgumentReader reader) { }
        public override void WriteArgumentsTo(RabbitMQ.Client.Impl.MethodArgumentWriter writer) { }
    }
    public partial class DtxStartOk : RabbitMQ.Client.Impl.MethodBase, RabbitMQ.Client.Framing.v0_9.IDtxStartOk, RabbitMQ.Client.IMethod
    {
        public const int ClassId = 100;
        public const int MethodId = 21;
        public DtxStartOk() { }
        public override bool HasContent { get { throw null; } }
        public override int ProtocolClassId { get { throw null; } }
        public override int ProtocolMethodId { get { throw null; } }
        public override string ProtocolMethodName { get { throw null; } }
        public override void AppendArgumentDebugStringTo(System.Text.StringBuilder sb) { }
        public override void ReadArgumentsFrom(RabbitMQ.Client.Impl.MethodArgumentReader reader) { }
        public override void WriteArgumentsTo(RabbitMQ.Client.Impl.MethodArgumentWriter writer) { }
    }
    public partial class ExchangeDeclare : RabbitMQ.Client.Impl.MethodBase, RabbitMQ.Client.Framing.v0_9.IExchangeDeclare, RabbitMQ.Client.IMethod
    {
        public const int ClassId = 40;
        public const int MethodId = 10;
        public System.Collections.IDictionary m_arguments;
        public bool m_autoDelete;
        public bool m_durable;
        public string m_exchange;
        public bool m_internal;
        public bool m_nowait;
        public bool m_passive;
        public ushort m_ticket;
        public string m_type;
        public ExchangeDeclare() { }
        public ExchangeDeclare(ushort initTicket, string initExchange, string initType, bool initPassive, bool initDurable, bool initAutoDelete, bool initInternal, bool initNowait, System.Collections.IDictionary initArguments) { }
        public override bool HasContent { get { throw null; } }
        public override int ProtocolClassId { get { throw null; } }
        public override int ProtocolMethodId { get { throw null; } }
        public override string ProtocolMethodName { get { throw null; } }
        System.Collections.IDictionary RabbitMQ.Client.Framing.v0_9.IExchangeDeclare.Arguments { get { throw null; } }
        bool RabbitMQ.Client.Framing.v0_9.IExchangeDeclare.AutoDelete { get { throw null; } }
        bool RabbitMQ.Client.Framing.v0_9.IExchangeDeclare.Durable { get { throw null; } }
        string RabbitMQ.Client.Framing.v0_9.IExchangeDeclare.Exchange { get { throw null; } }
        bool RabbitMQ.Client.Framing.v0_9.IExchangeDeclare.Internal { get { throw null; } }
        bool RabbitMQ.Client.Framing.v0_9.IExchangeDeclare.Nowait { get { throw null; } }
        bool RabbitMQ.Client.Framing.v0_9.IExchangeDeclare.Passive { get { throw null; } }
        ushort RabbitMQ.Client.Framing.v0_9.IExchangeDeclare.Ticket { get { throw null; } }
        string RabbitMQ.Client.Framing.v0_9.IExchangeDeclare.Type { get { throw null; } }
        public override void AppendArgumentDebugStringTo(System.Text.StringBuilder sb) { }
        public override void ReadArgumentsFrom(RabbitMQ.Client.Impl.MethodArgumentReader reader) { }
        public override void WriteArgumentsTo(RabbitMQ.Client.Impl.MethodArgumentWriter writer) { }
    }
    public partial class ExchangeDeclareOk : RabbitMQ.Client.Impl.MethodBase, RabbitMQ.Client.Framing.v0_9.IExchangeDeclareOk, RabbitMQ.Client.IMethod
    {
        public const int ClassId = 40;
        public const int MethodId = 11;
        public ExchangeDeclareOk() { }
        public override bool HasContent { get { throw null; } }
        public override int ProtocolClassId { get { throw null; } }
        public override int ProtocolMethodId { get { throw null; } }
        public override string ProtocolMethodName { get { throw null; } }
        public override void AppendArgumentDebugStringTo(System.Text.StringBuilder sb) { }
        public override void ReadArgumentsFrom(RabbitMQ.Client.Impl.MethodArgumentReader reader) { }
        public override void WriteArgumentsTo(RabbitMQ.Client.Impl.MethodArgumentWriter writer) { }
    }
    public partial class ExchangeDelete : RabbitMQ.Client.Impl.MethodBase, RabbitMQ.Client.Framing.v0_9.IExchangeDelete, RabbitMQ.Client.IMethod
    {
        public const int ClassId = 40;
        public const int MethodId = 20;
        public string m_exchange;
        public bool m_ifUnused;
        public bool m_nowait;
        public ushort m_ticket;
        public ExchangeDelete() { }
        public ExchangeDelete(ushort initTicket, string initExchange, bool initIfUnused, bool initNowait) { }
        public override bool HasContent { get { throw null; } }
        public override int ProtocolClassId { get { throw null; } }
        public override int ProtocolMethodId { get { throw null; } }
        public override string ProtocolMethodName { get { throw null; } }
        string RabbitMQ.Client.Framing.v0_9.IExchangeDelete.Exchange { get { throw null; } }
        bool RabbitMQ.Client.Framing.v0_9.IExchangeDelete.IfUnused { get { throw null; } }
        bool RabbitMQ.Client.Framing.v0_9.IExchangeDelete.Nowait { get { throw null; } }
        ushort RabbitMQ.Client.Framing.v0_9.IExchangeDelete.Ticket { get { throw null; } }
        public override void AppendArgumentDebugStringTo(System.Text.StringBuilder sb) { }
        public override void ReadArgumentsFrom(RabbitMQ.Client.Impl.MethodArgumentReader reader) { }
        public override void WriteArgumentsTo(RabbitMQ.Client.Impl.MethodArgumentWriter writer) { }
    }
    public partial class ExchangeDeleteOk : RabbitMQ.Client.Impl.MethodBase, RabbitMQ.Client.Framing.v0_9.IExchangeDeleteOk, RabbitMQ.Client.IMethod
    {
        public const int ClassId = 40;
        public const int MethodId = 21;
        public ExchangeDeleteOk() { }
        public override bool HasContent { get { throw null; } }
        public override int ProtocolClassId { get { throw null; } }
        public override int ProtocolMethodId { get { throw null; } }
        public override string ProtocolMethodName { get { throw null; } }
        public override void AppendArgumentDebugStringTo(System.Text.StringBuilder sb) { }
        public override void ReadArgumentsFrom(RabbitMQ.Client.Impl.MethodArgumentReader reader) { }
        public override void WriteArgumentsTo(RabbitMQ.Client.Impl.MethodArgumentWriter writer) { }
    }
    public partial class FileAck : RabbitMQ.Client.Impl.MethodBase, RabbitMQ.Client.Framing.v0_9.IFileAck, RabbitMQ.Client.IMethod
    {
        public const int ClassId = 70;
        public const int MethodId = 90;
        public ulong m_deliveryTag;
        public bool m_multiple;
        public FileAck() { }
        public FileAck(ulong initDeliveryTag, bool initMultiple) { }
        public override bool HasContent { get { throw null; } }
        public override int ProtocolClassId { get { throw null; } }
        public override int ProtocolMethodId { get { throw null; } }
        public override string ProtocolMethodName { get { throw null; } }
        ulong RabbitMQ.Client.Framing.v0_9.IFileAck.DeliveryTag { get { throw null; } }
        bool RabbitMQ.Client.Framing.v0_9.IFileAck.Multiple { get { throw null; } }
        public override void AppendArgumentDebugStringTo(System.Text.StringBuilder sb) { }
        public override void ReadArgumentsFrom(RabbitMQ.Client.Impl.MethodArgumentReader reader) { }
        public override void WriteArgumentsTo(RabbitMQ.Client.Impl.MethodArgumentWriter writer) { }
    }
    public partial class FileCancel : RabbitMQ.Client.Impl.MethodBase, RabbitMQ.Client.Framing.v0_9.IFileCancel, RabbitMQ.Client.IMethod
    {
        public const int ClassId = 70;
        public const int MethodId = 30;
        public string m_consumerTag;
        public bool m_nowait;
        public FileCancel() { }
        public FileCancel(string initConsumerTag, bool initNowait) { }
        public override bool HasContent { get { throw null; } }
        public override int ProtocolClassId { get { throw null; } }
        public override int ProtocolMethodId { get { throw null; } }
        public override string ProtocolMethodName { get { throw null; } }
        string RabbitMQ.Client.Framing.v0_9.IFileCancel.ConsumerTag { get { throw null; } }
        bool RabbitMQ.Client.Framing.v0_9.IFileCancel.Nowait { get { throw null; } }
        public override void AppendArgumentDebugStringTo(System.Text.StringBuilder sb) { }
        public override void ReadArgumentsFrom(RabbitMQ.Client.Impl.MethodArgumentReader reader) { }
        public override void WriteArgumentsTo(RabbitMQ.Client.Impl.MethodArgumentWriter writer) { }
    }
    public partial class FileCancelOk : RabbitMQ.Client.Impl.MethodBase, RabbitMQ.Client.Framing.v0_9.IFileCancelOk, RabbitMQ.Client.IMethod
    {
        public const int ClassId = 70;
        public const int MethodId = 31;
        public string m_consumerTag;
        public FileCancelOk() { }
        public FileCancelOk(string initConsumerTag) { }
        public override bool HasContent { get { throw null; } }
        public override int ProtocolClassId { get { throw null; } }
        public override int ProtocolMethodId { get { throw null; } }
        public override string ProtocolMethodName { get { throw null; } }
        string RabbitMQ.Client.Framing.v0_9.IFileCancelOk.ConsumerTag { get { throw null; } }
        public override void AppendArgumentDebugStringTo(System.Text.StringBuilder sb) { }
        public override void ReadArgumentsFrom(RabbitMQ.Client.Impl.MethodArgumentReader reader) { }
        public override void WriteArgumentsTo(RabbitMQ.Client.Impl.MethodArgumentWriter writer) { }
    }
    public partial class FileConsume : RabbitMQ.Client.Impl.MethodBase, RabbitMQ.Client.Framing.v0_9.IFileConsume, RabbitMQ.Client.IMethod
    {
        public const int ClassId = 70;
        public const int MethodId = 20;
        public string m_consumerTag;
        public bool m_exclusive;
        public System.Collections.IDictionary m_filter;
        public bool m_noAck;
        public bool m_noLocal;
        public bool m_nowait;
        public string m_queue;
        public ushort m_ticket;
        public FileConsume() { }
        public FileConsume(ushort initTicket, string initQueue, string initConsumerTag, bool initNoLocal, bool initNoAck, bool initExclusive, bool initNowait, System.Collections.IDictionary initFilter) { }
        public override bool HasContent { get { throw null; } }
        public override int ProtocolClassId { get { throw null; } }
        public override int ProtocolMethodId { get { throw null; } }
        public override string ProtocolMethodName { get { throw null; } }
        string RabbitMQ.Client.Framing.v0_9.IFileConsume.ConsumerTag { get { throw null; } }
        bool RabbitMQ.Client.Framing.v0_9.IFileConsume.Exclusive { get { throw null; } }
        System.Collections.IDictionary RabbitMQ.Client.Framing.v0_9.IFileConsume.Filter { get { throw null; } }
        bool RabbitMQ.Client.Framing.v0_9.IFileConsume.NoAck { get { throw null; } }
        bool RabbitMQ.Client.Framing.v0_9.IFileConsume.NoLocal { get { throw null; } }
        bool RabbitMQ.Client.Framing.v0_9.IFileConsume.Nowait { get { throw null; } }
        string RabbitMQ.Client.Framing.v0_9.IFileConsume.Queue { get { throw null; } }
        ushort RabbitMQ.Client.Framing.v0_9.IFileConsume.Ticket { get { throw null; } }
        public override void AppendArgumentDebugStringTo(System.Text.StringBuilder sb) { }
        public override void ReadArgumentsFrom(RabbitMQ.Client.Impl.MethodArgumentReader reader) { }
        public override void WriteArgumentsTo(RabbitMQ.Client.Impl.MethodArgumentWriter writer) { }
    }
    public partial class FileConsumeOk : RabbitMQ.Client.Impl.MethodBase, RabbitMQ.Client.Framing.v0_9.IFileConsumeOk, RabbitMQ.Client.IMethod
    {
        public const int ClassId = 70;
        public const int MethodId = 21;
        public string m_consumerTag;
        public FileConsumeOk() { }
        public FileConsumeOk(string initConsumerTag) { }
        public override bool HasContent { get { throw null; } }
        public override int ProtocolClassId { get { throw null; } }
        public override int ProtocolMethodId { get { throw null; } }
        public override string ProtocolMethodName { get { throw null; } }
        string RabbitMQ.Client.Framing.v0_9.IFileConsumeOk.ConsumerTag { get { throw null; } }
        public override void AppendArgumentDebugStringTo(System.Text.StringBuilder sb) { }
        public override void ReadArgumentsFrom(RabbitMQ.Client.Impl.MethodArgumentReader reader) { }
        public override void WriteArgumentsTo(RabbitMQ.Client.Impl.MethodArgumentWriter writer) { }
    }
    public partial class FileDeliver : RabbitMQ.Client.Impl.MethodBase, RabbitMQ.Client.Framing.v0_9.IFileDeliver, RabbitMQ.Client.IMethod
    {
        public const int ClassId = 70;
        public const int MethodId = 80;
        public string m_consumerTag;
        public ulong m_deliveryTag;
        public string m_exchange;
        public string m_identifier;
        public bool m_redelivered;
        public string m_routingKey;
        public FileDeliver() { }
        public FileDeliver(string initConsumerTag, ulong initDeliveryTag, bool initRedelivered, string initExchange, string initRoutingKey, string initIdentifier) { }
        public override bool HasContent { get { throw null; } }
        public override int ProtocolClassId { get { throw null; } }
        public override int ProtocolMethodId { get { throw null; } }
        public override string ProtocolMethodName { get { throw null; } }
        string RabbitMQ.Client.Framing.v0_9.IFileDeliver.ConsumerTag { get { throw null; } }
        ulong RabbitMQ.Client.Framing.v0_9.IFileDeliver.DeliveryTag { get { throw null; } }
        string RabbitMQ.Client.Framing.v0_9.IFileDeliver.Exchange { get { throw null; } }
        string RabbitMQ.Client.Framing.v0_9.IFileDeliver.Identifier { get { throw null; } }
        bool RabbitMQ.Client.Framing.v0_9.IFileDeliver.Redelivered { get { throw null; } }
        string RabbitMQ.Client.Framing.v0_9.IFileDeliver.RoutingKey { get { throw null; } }
        public override void AppendArgumentDebugStringTo(System.Text.StringBuilder sb) { }
        public override void ReadArgumentsFrom(RabbitMQ.Client.Impl.MethodArgumentReader reader) { }
        public override void WriteArgumentsTo(RabbitMQ.Client.Impl.MethodArgumentWriter writer) { }
    }
    public partial class FileOpen : RabbitMQ.Client.Impl.MethodBase, RabbitMQ.Client.Framing.v0_9.IFileOpen, RabbitMQ.Client.IMethod
    {
        public const int ClassId = 70;
        public const int MethodId = 40;
        public ulong m_contentSize;
        public string m_identifier;
        public FileOpen() { }
        public FileOpen(string initIdentifier, ulong initContentSize) { }
        public override bool HasContent { get { throw null; } }
        public override int ProtocolClassId { get { throw null; } }
        public override int ProtocolMethodId { get { throw null; } }
        public override string ProtocolMethodName { get { throw null; } }
        ulong RabbitMQ.Client.Framing.v0_9.IFileOpen.ContentSize { get { throw null; } }
        string RabbitMQ.Client.Framing.v0_9.IFileOpen.Identifier { get { throw null; } }
        public override void AppendArgumentDebugStringTo(System.Text.StringBuilder sb) { }
        public override void ReadArgumentsFrom(RabbitMQ.Client.Impl.MethodArgumentReader reader) { }
        public override void WriteArgumentsTo(RabbitMQ.Client.Impl.MethodArgumentWriter writer) { }
    }
    public partial class FileOpenOk : RabbitMQ.Client.Impl.MethodBase, RabbitMQ.Client.Framing.v0_9.IFileOpenOk, RabbitMQ.Client.IMethod
    {
        public const int ClassId = 70;
        public const int MethodId = 41;
        public ulong m_stagedSize;
        public FileOpenOk() { }
        public FileOpenOk(ulong initStagedSize) { }
        public override bool HasContent { get { throw null; } }
        public override int ProtocolClassId { get { throw null; } }
        public override int ProtocolMethodId { get { throw null; } }
        public override string ProtocolMethodName { get { throw null; } }
        ulong RabbitMQ.Client.Framing.v0_9.IFileOpenOk.StagedSize { get { throw null; } }
        public override void AppendArgumentDebugStringTo(System.Text.StringBuilder sb) { }
        public override void ReadArgumentsFrom(RabbitMQ.Client.Impl.MethodArgumentReader reader) { }
        public override void WriteArgumentsTo(RabbitMQ.Client.Impl.MethodArgumentWriter writer) { }
    }
    public partial class FilePublish : RabbitMQ.Client.Impl.MethodBase, RabbitMQ.Client.Framing.v0_9.IFilePublish, RabbitMQ.Client.IMethod
    {
        public const int ClassId = 70;
        public const int MethodId = 60;
        public string m_exchange;
        public string m_identifier;
        public bool m_immediate;
        public bool m_mandatory;
        public string m_routingKey;
        public ushort m_ticket;
        public FilePublish() { }
        public FilePublish(ushort initTicket, string initExchange, string initRoutingKey, bool initMandatory, bool initImmediate, string initIdentifier) { }
        public override bool HasContent { get { throw null; } }
        public override int ProtocolClassId { get { throw null; } }
        public override int ProtocolMethodId { get { throw null; } }
        public override string ProtocolMethodName { get { throw null; } }
        string RabbitMQ.Client.Framing.v0_9.IFilePublish.Exchange { get { throw null; } }
        string RabbitMQ.Client.Framing.v0_9.IFilePublish.Identifier { get { throw null; } }
        bool RabbitMQ.Client.Framing.v0_9.IFilePublish.Immediate { get { throw null; } }
        bool RabbitMQ.Client.Framing.v0_9.IFilePublish.Mandatory { get { throw null; } }
        string RabbitMQ.Client.Framing.v0_9.IFilePublish.RoutingKey { get { throw null; } }
        ushort RabbitMQ.Client.Framing.v0_9.IFilePublish.Ticket { get { throw null; } }
        public override void AppendArgumentDebugStringTo(System.Text.StringBuilder sb) { }
        public override void ReadArgumentsFrom(RabbitMQ.Client.Impl.MethodArgumentReader reader) { }
        public override void WriteArgumentsTo(RabbitMQ.Client.Impl.MethodArgumentWriter writer) { }
    }
    public partial class FileQos : RabbitMQ.Client.Impl.MethodBase, RabbitMQ.Client.Framing.v0_9.IFileQos, RabbitMQ.Client.IMethod
    {
        public const int ClassId = 70;
        public const int MethodId = 10;
        public bool m_global;
        public ushort m_prefetchCount;
        public uint m_prefetchSize;
        public FileQos() { }
        public FileQos(uint initPrefetchSize, ushort initPrefetchCount, bool initGlobal) { }
        public override bool HasContent { get { throw null; } }
        public override int ProtocolClassId { get { throw null; } }
        public override int ProtocolMethodId { get { throw null; } }
        public override string ProtocolMethodName { get { throw null; } }
        bool RabbitMQ.Client.Framing.v0_9.IFileQos.Global { get { throw null; } }
        ushort RabbitMQ.Client.Framing.v0_9.IFileQos.PrefetchCount { get { throw null; } }
        uint RabbitMQ.Client.Framing.v0_9.IFileQos.PrefetchSize { get { throw null; } }
        public override void AppendArgumentDebugStringTo(System.Text.StringBuilder sb) { }
        public override void ReadArgumentsFrom(RabbitMQ.Client.Impl.MethodArgumentReader reader) { }
        public override void WriteArgumentsTo(RabbitMQ.Client.Impl.MethodArgumentWriter writer) { }
    }
    public partial class FileQosOk : RabbitMQ.Client.Impl.MethodBase, RabbitMQ.Client.Framing.v0_9.IFileQosOk, RabbitMQ.Client.IMethod
    {
        public const int ClassId = 70;
        public const int MethodId = 11;
        public FileQosOk() { }
        public override bool HasContent { get { throw null; } }
        public override int ProtocolClassId { get { throw null; } }
        public override int ProtocolMethodId { get { throw null; } }
        public override string ProtocolMethodName { get { throw null; } }
        public override void AppendArgumentDebugStringTo(System.Text.StringBuilder sb) { }
        public override void ReadArgumentsFrom(RabbitMQ.Client.Impl.MethodArgumentReader reader) { }
        public override void WriteArgumentsTo(RabbitMQ.Client.Impl.MethodArgumentWriter writer) { }
    }
    public partial class FileReject : RabbitMQ.Client.Impl.MethodBase, RabbitMQ.Client.Framing.v0_9.IFileReject, RabbitMQ.Client.IMethod
    {
        public const int ClassId = 70;
        public const int MethodId = 100;
        public ulong m_deliveryTag;
        public bool m_requeue;
        public FileReject() { }
        public FileReject(ulong initDeliveryTag, bool initRequeue) { }
        public override bool HasContent { get { throw null; } }
        public override int ProtocolClassId { get { throw null; } }
        public override int ProtocolMethodId { get { throw null; } }
        public override string ProtocolMethodName { get { throw null; } }
        ulong RabbitMQ.Client.Framing.v0_9.IFileReject.DeliveryTag { get { throw null; } }
        bool RabbitMQ.Client.Framing.v0_9.IFileReject.Requeue { get { throw null; } }
        public override void AppendArgumentDebugStringTo(System.Text.StringBuilder sb) { }
        public override void ReadArgumentsFrom(RabbitMQ.Client.Impl.MethodArgumentReader reader) { }
        public override void WriteArgumentsTo(RabbitMQ.Client.Impl.MethodArgumentWriter writer) { }
    }
    public partial class FileReturn : RabbitMQ.Client.Impl.MethodBase, RabbitMQ.Client.Framing.v0_9.IFileReturn, RabbitMQ.Client.IMethod
    {
        public const int ClassId = 70;
        public const int MethodId = 70;
        public string m_exchange;
        public ushort m_replyCode;
        public string m_replyText;
        public string m_routingKey;
        public FileReturn() { }
        public FileReturn(ushort initReplyCode, string initReplyText, string initExchange, string initRoutingKey) { }
        public override bool HasContent { get { throw null; } }
        public override int ProtocolClassId { get { throw null; } }
        public override int ProtocolMethodId { get { throw null; } }
        public override string ProtocolMethodName { get { throw null; } }
        string RabbitMQ.Client.Framing.v0_9.IFileReturn.Exchange { get { throw null; } }
        ushort RabbitMQ.Client.Framing.v0_9.IFileReturn.ReplyCode { get { throw null; } }
        string RabbitMQ.Client.Framing.v0_9.IFileReturn.ReplyText { get { throw null; } }
        string RabbitMQ.Client.Framing.v0_9.IFileReturn.RoutingKey { get { throw null; } }
        public override void AppendArgumentDebugStringTo(System.Text.StringBuilder sb) { }
        public override void ReadArgumentsFrom(RabbitMQ.Client.Impl.MethodArgumentReader reader) { }
        public override void WriteArgumentsTo(RabbitMQ.Client.Impl.MethodArgumentWriter writer) { }
    }
    public partial class FileStage : RabbitMQ.Client.Impl.MethodBase, RabbitMQ.Client.Framing.v0_9.IFileStage, RabbitMQ.Client.IMethod
    {
        public const int ClassId = 70;
        public const int MethodId = 50;
        public FileStage() { }
        public override bool HasContent { get { throw null; } }
        public override int ProtocolClassId { get { throw null; } }
        public override int ProtocolMethodId { get { throw null; } }
        public override string ProtocolMethodName { get { throw null; } }
        public override void AppendArgumentDebugStringTo(System.Text.StringBuilder sb) { }
        public override void ReadArgumentsFrom(RabbitMQ.Client.Impl.MethodArgumentReader reader) { }
        public override void WriteArgumentsTo(RabbitMQ.Client.Impl.MethodArgumentWriter writer) { }
    }
    public partial class MessageAppend : RabbitMQ.Client.Impl.MethodBase, RabbitMQ.Client.Framing.v0_9.IMessageAppend, RabbitMQ.Client.IMethod
    {
        public const int ClassId = 120;
        public const int MethodId = 80;
        public byte[] m_bytes;
        public byte[] m_reference;
        public MessageAppend() { }
        public MessageAppend(byte[] initReference, byte[] initBytes) { }
        public override bool HasContent { get { throw null; } }
        public override int ProtocolClassId { get { throw null; } }
        public override int ProtocolMethodId { get { throw null; } }
        public override string ProtocolMethodName { get { throw null; } }
        byte[] RabbitMQ.Client.Framing.v0_9.IMessageAppend.Bytes { get { throw null; } }
        byte[] RabbitMQ.Client.Framing.v0_9.IMessageAppend.Reference { get { throw null; } }
        public override void AppendArgumentDebugStringTo(System.Text.StringBuilder sb) { }
        public override void ReadArgumentsFrom(RabbitMQ.Client.Impl.MethodArgumentReader reader) { }
        public override void WriteArgumentsTo(RabbitMQ.Client.Impl.MethodArgumentWriter writer) { }
    }
    public partial class MessageCancel : RabbitMQ.Client.Impl.MethodBase, RabbitMQ.Client.Framing.v0_9.IMessageCancel, RabbitMQ.Client.IMethod
    {
        public const int ClassId = 120;
        public const int MethodId = 30;
        public string m_destination;
        public MessageCancel() { }
        public MessageCancel(string initDestination) { }
        public override bool HasContent { get { throw null; } }
        public override int ProtocolClassId { get { throw null; } }
        public override int ProtocolMethodId { get { throw null; } }
        public override string ProtocolMethodName { get { throw null; } }
        string RabbitMQ.Client.Framing.v0_9.IMessageCancel.Destination { get { throw null; } }
        public override void AppendArgumentDebugStringTo(System.Text.StringBuilder sb) { }
        public override void ReadArgumentsFrom(RabbitMQ.Client.Impl.MethodArgumentReader reader) { }
        public override void WriteArgumentsTo(RabbitMQ.Client.Impl.MethodArgumentWriter writer) { }
    }
    public partial class MessageCheckpoint : RabbitMQ.Client.Impl.MethodBase, RabbitMQ.Client.Framing.v0_9.IMessageCheckpoint, RabbitMQ.Client.IMethod
    {
        public const int ClassId = 120;
        public const int MethodId = 90;
        public string m_identifier;
        public byte[] m_reference;
        public MessageCheckpoint() { }
        public MessageCheckpoint(byte[] initReference, string initIdentifier) { }
        public override bool HasContent { get { throw null; } }
        public override int ProtocolClassId { get { throw null; } }
        public override int ProtocolMethodId { get { throw null; } }
        public override string ProtocolMethodName { get { throw null; } }
        string RabbitMQ.Client.Framing.v0_9.IMessageCheckpoint.Identifier { get { throw null; } }
        byte[] RabbitMQ.Client.Framing.v0_9.IMessageCheckpoint.Reference { get { throw null; } }
        public override void AppendArgumentDebugStringTo(System.Text.StringBuilder sb) { }
        public override void ReadArgumentsFrom(RabbitMQ.Client.Impl.MethodArgumentReader reader) { }
        public override void WriteArgumentsTo(RabbitMQ.Client.Impl.MethodArgumentWriter writer) { }
    }
    public partial class MessageClose : RabbitMQ.Client.Impl.MethodBase, RabbitMQ.Client.Framing.v0_9.IMessageClose, RabbitMQ.Client.IMethod
    {
        public const int ClassId = 120;
        public const int MethodId = 70;
        public byte[] m_reference;
        public MessageClose() { }
        public MessageClose(byte[] initReference) { }
        public override bool HasContent { get { throw null; } }
        public override int ProtocolClassId { get { throw null; } }
        public override int ProtocolMethodId { get { throw null; } }
        public override string ProtocolMethodName { get { throw null; } }
        byte[] RabbitMQ.Client.Framing.v0_9.IMessageClose.Reference { get { throw null; } }
        public override void AppendArgumentDebugStringTo(System.Text.StringBuilder sb) { }
        public override void ReadArgumentsFrom(RabbitMQ.Client.Impl.MethodArgumentReader reader) { }
        public override void WriteArgumentsTo(RabbitMQ.Client.Impl.MethodArgumentWriter writer) { }
    }
    public partial class MessageConsume : RabbitMQ.Client.Impl.MethodBase, RabbitMQ.Client.Framing.v0_9.IMessageConsume, RabbitMQ.Client.IMethod
    {
        public const int ClassId = 120;
        public const int MethodId = 20;
        public string m_destination;
        public bool m_exclusive;
        public System.Collections.IDictionary m_filter;
        public bool m_noAck;
        public bool m_noLocal;
        public string m_queue;
        public ushort m_ticket;
        public MessageConsume() { }
        public MessageConsume(ushort initTicket, string initQueue, string initDestination, bool initNoLocal, bool initNoAck, bool initExclusive, System.Collections.IDictionary initFilter) { }
        public override bool HasContent { get { throw null; } }
        public override int ProtocolClassId { get { throw null; } }
        public override int ProtocolMethodId { get { throw null; } }
        public override string ProtocolMethodName { get { throw null; } }
        string RabbitMQ.Client.Framing.v0_9.IMessageConsume.Destination { get { throw null; } }
        bool RabbitMQ.Client.Framing.v0_9.IMessageConsume.Exclusive { get { throw null; } }
        System.Collections.IDictionary RabbitMQ.Client.Framing.v0_9.IMessageConsume.Filter { get { throw null; } }
        bool RabbitMQ.Client.Framing.v0_9.IMessageConsume.NoAck { get { throw null; } }
        bool RabbitMQ.Client.Framing.v0_9.IMessageConsume.NoLocal { get { throw null; } }
        string RabbitMQ.Client.Framing.v0_9.IMessageConsume.Queue { get { throw null; } }
        ushort RabbitMQ.Client.Framing.v0_9.IMessageConsume.Ticket { get { throw null; } }
        public override void AppendArgumentDebugStringTo(System.Text.StringBuilder sb) { }
        public override void ReadArgumentsFrom(RabbitMQ.Client.Impl.MethodArgumentReader reader) { }
        public override void WriteArgumentsTo(RabbitMQ.Client.Impl.MethodArgumentWriter writer) { }
    }
    public partial class MessageEmpty : RabbitMQ.Client.Impl.MethodBase, RabbitMQ.Client.Framing.v0_9.IMessageEmpty, RabbitMQ.Client.IMethod
    {
        public const int ClassId = 120;
        public const int MethodId = 510;
        public MessageEmpty() { }
        public override bool HasContent { get { throw null; } }
        public override int ProtocolClassId { get { throw null; } }
        public override int ProtocolMethodId { get { throw null; } }
        public override string ProtocolMethodName { get { throw null; } }
        public override void AppendArgumentDebugStringTo(System.Text.StringBuilder sb) { }
        public override void ReadArgumentsFrom(RabbitMQ.Client.Impl.MethodArgumentReader reader) { }
        public override void WriteArgumentsTo(RabbitMQ.Client.Impl.MethodArgumentWriter writer) { }
    }
    public partial class MessageGet : RabbitMQ.Client.Impl.MethodBase, RabbitMQ.Client.Framing.v0_9.IMessageGet, RabbitMQ.Client.IMethod
    {
        public const int ClassId = 120;
        public const int MethodId = 40;
        public string m_destination;
        public bool m_noAck;
        public string m_queue;
        public ushort m_ticket;
        public MessageGet() { }
        public MessageGet(ushort initTicket, string initQueue, string initDestination, bool initNoAck) { }
        public override bool HasContent { get { throw null; } }
        public override int ProtocolClassId { get { throw null; } }
        public override int ProtocolMethodId { get { throw null; } }
        public override string ProtocolMethodName { get { throw null; } }
        string RabbitMQ.Client.Framing.v0_9.IMessageGet.Destination { get { throw null; } }
        bool RabbitMQ.Client.Framing.v0_9.IMessageGet.NoAck { get { throw null; } }
        string RabbitMQ.Client.Framing.v0_9.IMessageGet.Queue { get { throw null; } }
        ushort RabbitMQ.Client.Framing.v0_9.IMessageGet.Ticket { get { throw null; } }
        public override void AppendArgumentDebugStringTo(System.Text.StringBuilder sb) { }
        public override void ReadArgumentsFrom(RabbitMQ.Client.Impl.MethodArgumentReader reader) { }
        public override void WriteArgumentsTo(RabbitMQ.Client.Impl.MethodArgumentWriter writer) { }
    }
    public partial class MessageOffset : RabbitMQ.Client.Impl.MethodBase, RabbitMQ.Client.Framing.v0_9.IMessageOffset, RabbitMQ.Client.IMethod
    {
        public const int ClassId = 120;
        public const int MethodId = 530;
        public ulong m_value;
        public MessageOffset() { }
        public MessageOffset(ulong initValue) { }
        public override bool HasContent { get { throw null; } }
        public override int ProtocolClassId { get { throw null; } }
        public override int ProtocolMethodId { get { throw null; } }
        public override string ProtocolMethodName { get { throw null; } }
        ulong RabbitMQ.Client.Framing.v0_9.IMessageOffset.Value { get { throw null; } }
        public override void AppendArgumentDebugStringTo(System.Text.StringBuilder sb) { }
        public override void ReadArgumentsFrom(RabbitMQ.Client.Impl.MethodArgumentReader reader) { }
        public override void WriteArgumentsTo(RabbitMQ.Client.Impl.MethodArgumentWriter writer) { }
    }
    public partial class MessageOk : RabbitMQ.Client.Impl.MethodBase, RabbitMQ.Client.Framing.v0_9.IMessageOk, RabbitMQ.Client.IMethod
    {
        public const int ClassId = 120;
        public const int MethodId = 500;
        public MessageOk() { }
        public override bool HasContent { get { throw null; } }
        public override int ProtocolClassId { get { throw null; } }
        public override int ProtocolMethodId { get { throw null; } }
        public override string ProtocolMethodName { get { throw null; } }
        public override void AppendArgumentDebugStringTo(System.Text.StringBuilder sb) { }
        public override void ReadArgumentsFrom(RabbitMQ.Client.Impl.MethodArgumentReader reader) { }
        public override void WriteArgumentsTo(RabbitMQ.Client.Impl.MethodArgumentWriter writer) { }
    }
    public partial class MessageOpen : RabbitMQ.Client.Impl.MethodBase, RabbitMQ.Client.Framing.v0_9.IMessageOpen, RabbitMQ.Client.IMethod
    {
        public const int ClassId = 120;
        public const int MethodId = 60;
        public byte[] m_reference;
        public MessageOpen() { }
        public MessageOpen(byte[] initReference) { }
        public override bool HasContent { get { throw null; } }
        public override int ProtocolClassId { get { throw null; } }
        public override int ProtocolMethodId { get { throw null; } }
        public override string ProtocolMethodName { get { throw null; } }
        byte[] RabbitMQ.Client.Framing.v0_9.IMessageOpen.Reference { get { throw null; } }
        public override void AppendArgumentDebugStringTo(System.Text.StringBuilder sb) { }
        public override void ReadArgumentsFrom(RabbitMQ.Client.Impl.MethodArgumentReader reader) { }
        public override void WriteArgumentsTo(RabbitMQ.Client.Impl.MethodArgumentWriter writer) { }
    }
    public partial class MessageQos : RabbitMQ.Client.Impl.MethodBase, RabbitMQ.Client.Framing.v0_9.IMessageQos, RabbitMQ.Client.IMethod
    {
        public const int ClassId = 120;
        public const int MethodId = 110;
        public bool m_global;
        public ushort m_prefetchCount;
        public uint m_prefetchSize;
        public MessageQos() { }
        public MessageQos(uint initPrefetchSize, ushort initPrefetchCount, bool initGlobal) { }
        public override bool HasContent { get { throw null; } }
        public override int ProtocolClassId { get { throw null; } }
        public override int ProtocolMethodId { get { throw null; } }
        public override string ProtocolMethodName { get { throw null; } }
        bool RabbitMQ.Client.Framing.v0_9.IMessageQos.Global { get { throw null; } }
        ushort RabbitMQ.Client.Framing.v0_9.IMessageQos.PrefetchCount { get { throw null; } }
        uint RabbitMQ.Client.Framing.v0_9.IMessageQos.PrefetchSize { get { throw null; } }
        public override void AppendArgumentDebugStringTo(System.Text.StringBuilder sb) { }
        public override void ReadArgumentsFrom(RabbitMQ.Client.Impl.MethodArgumentReader reader) { }
        public override void WriteArgumentsTo(RabbitMQ.Client.Impl.MethodArgumentWriter writer) { }
    }
    public partial class MessageRecover : RabbitMQ.Client.Impl.MethodBase, RabbitMQ.Client.Framing.v0_9.IMessageRecover, RabbitMQ.Client.IMethod
    {
        public const int ClassId = 120;
        public const int MethodId = 50;
        public bool m_requeue;
        public MessageRecover() { }
        public MessageRecover(bool initRequeue) { }
        public override bool HasContent { get { throw null; } }
        public override int ProtocolClassId { get { throw null; } }
        public override int ProtocolMethodId { get { throw null; } }
        public override string ProtocolMethodName { get { throw null; } }
        bool RabbitMQ.Client.Framing.v0_9.IMessageRecover.Requeue { get { throw null; } }
        public override void AppendArgumentDebugStringTo(System.Text.StringBuilder sb) { }
        public override void ReadArgumentsFrom(RabbitMQ.Client.Impl.MethodArgumentReader reader) { }
        public override void WriteArgumentsTo(RabbitMQ.Client.Impl.MethodArgumentWriter writer) { }
    }
    public partial class MessageReject : RabbitMQ.Client.Impl.MethodBase, RabbitMQ.Client.Framing.v0_9.IMessageReject, RabbitMQ.Client.IMethod
    {
        public const int ClassId = 120;
        public const int MethodId = 520;
        public ushort m_code;
        public string m_text;
        public MessageReject() { }
        public MessageReject(ushort initCode, string initText) { }
        public override bool HasContent { get { throw null; } }
        public override int ProtocolClassId { get { throw null; } }
        public override int ProtocolMethodId { get { throw null; } }
        public override string ProtocolMethodName { get { throw null; } }
        ushort RabbitMQ.Client.Framing.v0_9.IMessageReject.Code { get { throw null; } }
        string RabbitMQ.Client.Framing.v0_9.IMessageReject.Text { get { throw null; } }
        public override void AppendArgumentDebugStringTo(System.Text.StringBuilder sb) { }
        public override void ReadArgumentsFrom(RabbitMQ.Client.Impl.MethodArgumentReader reader) { }
        public override void WriteArgumentsTo(RabbitMQ.Client.Impl.MethodArgumentWriter writer) { }
    }
    public partial class MessageResume : RabbitMQ.Client.Impl.MethodBase, RabbitMQ.Client.Framing.v0_9.IMessageResume, RabbitMQ.Client.IMethod
    {
        public const int ClassId = 120;
        public const int MethodId = 100;
        public string m_identifier;
        public byte[] m_reference;
        public MessageResume() { }
        public MessageResume(byte[] initReference, string initIdentifier) { }
        public override bool HasContent { get { throw null; } }
        public override int ProtocolClassId { get { throw null; } }
        public override int ProtocolMethodId { get { throw null; } }
        public override string ProtocolMethodName { get { throw null; } }
        string RabbitMQ.Client.Framing.v0_9.IMessageResume.Identifier { get { throw null; } }
        byte[] RabbitMQ.Client.Framing.v0_9.IMessageResume.Reference { get { throw null; } }
        public override void AppendArgumentDebugStringTo(System.Text.StringBuilder sb) { }
        public override void ReadArgumentsFrom(RabbitMQ.Client.Impl.MethodArgumentReader reader) { }
        public override void WriteArgumentsTo(RabbitMQ.Client.Impl.MethodArgumentWriter writer) { }
    }
    public partial class MessageTransfer : RabbitMQ.Client.Impl.MethodBase, RabbitMQ.Client.Framing.v0_9.IMessageTransfer, RabbitMQ.Client.IMethod
    {
        public const int ClassId = 120;
        public const int MethodId = 10;
        public string m_appId;
        public System.Collections.IDictionary m_applicationHeaders;
        public byte[] m_body;
        public string m_contentEncoding;
        public string m_contentType;
        public string m_correlationId;
        public byte m_deliveryMode;
        public string m_destination;
        public string m_exchange;
        public RabbitMQ.Client.AmqpTimestamp m_expiration;
        public bool m_immediate;
        public string m_messageId;
        public byte m_priority;
        public bool m_redelivered;
        public string m_replyTo;
        public string m_routingKey;
        public byte[] m_securityToken;
        public ushort m_ticket;
        public RabbitMQ.Client.AmqpTimestamp m_timestamp;
        public string m_transactionId;
        public ulong m_ttl;
        public string m_userId;
        public MessageTransfer() { }
        public MessageTransfer(ushort initTicket, string initDestination, bool initRedelivered, bool initImmediate, ulong initTtl, byte initPriority, RabbitMQ.Client.AmqpTimestamp initTimestamp, byte initDeliveryMode, RabbitMQ.Client.AmqpTimestamp initExpiration, string initExchange, string initRoutingKey, string initMessageId, string initCorrelationId, string initReplyTo, string initContentType, string initContentEncoding, string initUserId, string initAppId, string initTransactionId, byte[] initSecurityToken, System.Collections.IDictionary initApplicationHeaders, byte[] initBody) { }
        public override bool HasContent { get { throw null; } }
        public override int ProtocolClassId { get { throw null; } }
        public override int ProtocolMethodId { get { throw null; } }
        public override string ProtocolMethodName { get { throw null; } }
        string RabbitMQ.Client.Framing.v0_9.IMessageTransfer.AppId { get { throw null; } }
        System.Collections.IDictionary RabbitMQ.Client.Framing.v0_9.IMessageTransfer.ApplicationHeaders { get { throw null; } }
        byte[] RabbitMQ.Client.Framing.v0_9.IMessageTransfer.Body { get { throw null; } }
        string RabbitMQ.Client.Framing.v0_9.IMessageTransfer.ContentEncoding { get { throw null; } }
        string RabbitMQ.Client.Framing.v0_9.IMessageTransfer.ContentType { get { throw null; } }
        string RabbitMQ.Client.Framing.v0_9.IMessageTransfer.CorrelationId { get { throw null; } }
        byte RabbitMQ.Client.Framing.v0_9.IMessageTransfer.DeliveryMode { get { throw null; } }
        string RabbitMQ.Client.Framing.v0_9.IMessageTransfer.Destination { get { throw null; } }
        string RabbitMQ.Client.Framing.v0_9.IMessageTransfer.Exchange { get { throw null; } }
        RabbitMQ.Client.AmqpTimestamp RabbitMQ.Client.Framing.v0_9.IMessageTransfer.Expiration { get { throw null; } }
        bool RabbitMQ.Client.Framing.v0_9.IMessageTransfer.Immediate { get { throw null; } }
        string RabbitMQ.Client.Framing.v0_9.IMessageTransfer.MessageId { get { throw null; } }
        byte RabbitMQ.Client.Framing.v0_9.IMessageTransfer.Priority { get { throw null; } }
        bool RabbitMQ.Client.Framing.v0_9.IMessageTransfer.Redelivered { get { throw null; } }
        string RabbitMQ.Client.Framing.v0_9.IMessageTransfer.ReplyTo { get { throw null; } }
        string RabbitMQ.Client.Framing.v0_9.IMessageTransfer.RoutingKey { get { throw null; } }
        byte[] RabbitMQ.Client.Framing.v0_9.IMessageTransfer.SecurityToken { get { throw null; } }
        ushort RabbitMQ.Client.Framing.v0_9.IMessageTransfer.Ticket { get { throw null; } }
        RabbitMQ.Client.AmqpTimestamp RabbitMQ.Client.Framing.v0_9.IMessageTransfer.Timestamp { get { throw null; } }
        string RabbitMQ.Client.Framing.v0_9.IMessageTransfer.TransactionId { get { throw null; } }
        ulong RabbitMQ.Client.Framing.v0_9.IMessageTransfer.Ttl { get { throw null; } }
        string RabbitMQ.Client.Framing.v0_9.IMessageTransfer.UserId { get { throw null; } }
        public override void AppendArgumentDebugStringTo(System.Text.StringBuilder sb) { }
        public override void ReadArgumentsFrom(RabbitMQ.Client.Impl.MethodArgumentReader reader) { }
        public override void WriteArgumentsTo(RabbitMQ.Client.Impl.MethodArgumentWriter writer) { }
    }
    public partial class Model : RabbitMQ.Client.Impl.ModelBase
    {
        public Model(RabbitMQ.Client.Impl.ISession session) : base (default(RabbitMQ.Client.Impl.ISession)) { }
        public override void BasicAck(ulong deliveryTag, bool multiple) { }
        public override void BasicQos(uint prefetchSize, ushort prefetchCount, bool global) { }
        public override void BasicRecover(bool requeue) { }
        public override void BasicReject(ulong deliveryTag, bool requeue) { }
        public override void ChannelFlow(bool active) { }
        public override RabbitMQ.Client.Impl.ConnectionTuneDetails ConnectionStartOk(System.Collections.IDictionary clientProperties, string mechanism, byte[] response, string locale) { throw null; }
        public override void ConnectionTuneOk(ushort channelMax, uint frameMax, ushort heartbeat) { }
        public override RabbitMQ.Client.IBasicProperties CreateBasicProperties() { throw null; }
        public override RabbitMQ.Client.IFileProperties CreateFileProperties() { throw null; }
        public override RabbitMQ.Client.IStreamProperties CreateStreamProperties() { throw null; }
        public override bool DispatchAsynchronous(RabbitMQ.Client.Impl.Command cmd) { throw null; }
        public override void DtxSelect() { }
        public override void DtxStart(string dtxIdentifier) { }
        public override void ExchangeDeclare(string exchange, string type, bool passive, bool durable, bool autoDelete, bool @internal, bool nowait, System.Collections.IDictionary arguments) { }
        public override void ExchangeDelete(string exchange, bool ifUnused, bool nowait) { }
        public override void QueueBind(string queue, string exchange, string routingKey, bool nowait, System.Collections.IDictionary arguments) { }
        public override string QueueDeclare(string queue, bool passive, bool durable, bool exclusive, bool autoDelete, bool nowait, System.Collections.IDictionary arguments) { throw null; }
        public override uint QueueDelete(string queue, bool ifUnused, bool ifEmpty, bool nowait) { throw null; }
        public override uint QueuePurge(string queue, bool nowait) { throw null; }
        public override void QueueUnbind(string queue, string exchange, string routingKey, System.Collections.IDictionary arguments) { }
        public override void TxCommit() { }
        public override void TxRollback() { }
        public override void TxSelect() { }
        public override void _Private_BasicCancel(string consumerTag, bool nowait) { }
        public override void _Private_BasicConsume(string queue, string consumerTag, bool noLocal, bool noAck, bool exclusive, bool nowait, System.Collections.IDictionary filter) { }
        public override void _Private_BasicGet(string queue, bool noAck) { }
        public override void _Private_BasicPublish(string exchange, string routingKey, bool mandatory, bool immediate, RabbitMQ.Client.IBasicProperties basicProperties, byte[] body) { }
        public override void _Private_ChannelClose(ushort replyCode, string replyText, ushort classId, ushort methodId) { }
        public override void _Private_ChannelCloseOk() { }
        public override void _Private_ChannelFlowOk() { }
        public override void _Private_ChannelOpen(string outOfBand) { }
        public override void _Private_ConnectionClose(ushort replyCode, string replyText, ushort classId, ushort methodId) { }
        public override void _Private_ConnectionCloseOk() { }
        public override void _Private_ConnectionOpen(string virtualHost, string capabilities, bool insist) { }
    }
    public abstract partial class ProtocolBase : RabbitMQ.Client.Impl.AbstractProtocolBase
    {
        protected ProtocolBase() { }
        public override bool CanSendWhileClosed(RabbitMQ.Client.Impl.Command cmd) { throw null; }
        public override void CreateChannelClose(ushort reasonCode, string reasonText, out RabbitMQ.Client.Impl.Command request, out int replyClassId, out int replyMethodId) { throw null; }
        public override RabbitMQ.Client.IConnection CreateConnection(RabbitMQ.Client.ConnectionFactory factory, bool insist, RabbitMQ.Client.Impl.IFrameHandler frameHandler) { throw null; }
        public override void CreateConnectionClose(ushort reasonCode, string reasonText, out RabbitMQ.Client.Impl.Command request, out int replyClassId, out int replyMethodId) { throw null; }
        public override RabbitMQ.Client.Impl.IFrameHandler CreateFrameHandler(RabbitMQ.Client.AmqpTcpEndpoint endpoint) { throw null; }
        public override RabbitMQ.Client.IModel CreateModel(RabbitMQ.Client.Impl.ISession session) { throw null; }
    }
    public partial class QueueBind : RabbitMQ.Client.Impl.MethodBase, RabbitMQ.Client.Framing.v0_9.IQueueBind, RabbitMQ.Client.IMethod
    {
        public const int ClassId = 50;
        public const int MethodId = 20;
        public System.Collections.IDictionary m_arguments;
        public string m_exchange;
        public bool m_nowait;
        public string m_queue;
        public string m_routingKey;
        public ushort m_ticket;
        public QueueBind() { }
        public QueueBind(ushort initTicket, string initQueue, string initExchange, string initRoutingKey, bool initNowait, System.Collections.IDictionary initArguments) { }
        public override bool HasContent { get { throw null; } }
        public override int ProtocolClassId { get { throw null; } }
        public override int ProtocolMethodId { get { throw null; } }
        public override string ProtocolMethodName { get { throw null; } }
        System.Collections.IDictionary RabbitMQ.Client.Framing.v0_9.IQueueBind.Arguments { get { throw null; } }
        string RabbitMQ.Client.Framing.v0_9.IQueueBind.Exchange { get { throw null; } }
        bool RabbitMQ.Client.Framing.v0_9.IQueueBind.Nowait { get { throw null; } }
        string RabbitMQ.Client.Framing.v0_9.IQueueBind.Queue { get { throw null; } }
        string RabbitMQ.Client.Framing.v0_9.IQueueBind.RoutingKey { get { throw null; } }
        ushort RabbitMQ.Client.Framing.v0_9.IQueueBind.Ticket { get { throw null; } }
        public override void AppendArgumentDebugStringTo(System.Text.StringBuilder sb) { }
        public override void ReadArgumentsFrom(RabbitMQ.Client.Impl.MethodArgumentReader reader) { }
        public override void WriteArgumentsTo(RabbitMQ.Client.Impl.MethodArgumentWriter writer) { }
    }
    public partial class QueueBindOk : RabbitMQ.Client.Impl.MethodBase, RabbitMQ.Client.Framing.v0_9.IQueueBindOk, RabbitMQ.Client.IMethod
    {
        public const int ClassId = 50;
        public const int MethodId = 21;
        public QueueBindOk() { }
        public override bool HasContent { get { throw null; } }
        public override int ProtocolClassId { get { throw null; } }
        public override int ProtocolMethodId { get { throw null; } }
        public override string ProtocolMethodName { get { throw null; } }
        public override void AppendArgumentDebugStringTo(System.Text.StringBuilder sb) { }
        public override void ReadArgumentsFrom(RabbitMQ.Client.Impl.MethodArgumentReader reader) { }
        public override void WriteArgumentsTo(RabbitMQ.Client.Impl.MethodArgumentWriter writer) { }
    }
    public partial class QueueDeclare : RabbitMQ.Client.Impl.MethodBase, RabbitMQ.Client.Framing.v0_9.IQueueDeclare, RabbitMQ.Client.IMethod
    {
        public const int ClassId = 50;
        public const int MethodId = 10;
        public System.Collections.IDictionary m_arguments;
        public bool m_autoDelete;
        public bool m_durable;
        public bool m_exclusive;
        public bool m_nowait;
        public bool m_passive;
        public string m_queue;
        public ushort m_ticket;
        public QueueDeclare() { }
        public QueueDeclare(ushort initTicket, string initQueue, bool initPassive, bool initDurable, bool initExclusive, bool initAutoDelete, bool initNowait, System.Collections.IDictionary initArguments) { }
        public override bool HasContent { get { throw null; } }
        public override int ProtocolClassId { get { throw null; } }
        public override int ProtocolMethodId { get { throw null; } }
        public override string ProtocolMethodName { get { throw null; } }
        System.Collections.IDictionary RabbitMQ.Client.Framing.v0_9.IQueueDeclare.Arguments { get { throw null; } }
        bool RabbitMQ.Client.Framing.v0_9.IQueueDeclare.AutoDelete { get { throw null; } }
        bool RabbitMQ.Client.Framing.v0_9.IQueueDeclare.Durable { get { throw null; } }
        bool RabbitMQ.Client.Framing.v0_9.IQueueDeclare.Exclusive { get { throw null; } }
        bool RabbitMQ.Client.Framing.v0_9.IQueueDeclare.Nowait { get { throw null; } }
        bool RabbitMQ.Client.Framing.v0_9.IQueueDeclare.Passive { get { throw null; } }
        string RabbitMQ.Client.Framing.v0_9.IQueueDeclare.Queue { get { throw null; } }
        ushort RabbitMQ.Client.Framing.v0_9.IQueueDeclare.Ticket { get { throw null; } }
        public override void AppendArgumentDebugStringTo(System.Text.StringBuilder sb) { }
        public override void ReadArgumentsFrom(RabbitMQ.Client.Impl.MethodArgumentReader reader) { }
        public override void WriteArgumentsTo(RabbitMQ.Client.Impl.MethodArgumentWriter writer) { }
    }
    public partial class QueueDeclareOk : RabbitMQ.Client.Impl.MethodBase, RabbitMQ.Client.Framing.v0_9.IQueueDeclareOk, RabbitMQ.Client.IMethod
    {
        public const int ClassId = 50;
        public const int MethodId = 11;
        public uint m_consumerCount;
        public uint m_messageCount;
        public string m_queue;
        public QueueDeclareOk() { }
        public QueueDeclareOk(string initQueue, uint initMessageCount, uint initConsumerCount) { }
        public override bool HasContent { get { throw null; } }
        public override int ProtocolClassId { get { throw null; } }
        public override int ProtocolMethodId { get { throw null; } }
        public override string ProtocolMethodName { get { throw null; } }
        uint RabbitMQ.Client.Framing.v0_9.IQueueDeclareOk.ConsumerCount { get { throw null; } }
        uint RabbitMQ.Client.Framing.v0_9.IQueueDeclareOk.MessageCount { get { throw null; } }
        string RabbitMQ.Client.Framing.v0_9.IQueueDeclareOk.Queue { get { throw null; } }
        public override void AppendArgumentDebugStringTo(System.Text.StringBuilder sb) { }
        public override void ReadArgumentsFrom(RabbitMQ.Client.Impl.MethodArgumentReader reader) { }
        public override void WriteArgumentsTo(RabbitMQ.Client.Impl.MethodArgumentWriter writer) { }
    }
    public partial class QueueDelete : RabbitMQ.Client.Impl.MethodBase, RabbitMQ.Client.Framing.v0_9.IQueueDelete, RabbitMQ.Client.IMethod
    {
        public const int ClassId = 50;
        public const int MethodId = 40;
        public bool m_ifEmpty;
        public bool m_ifUnused;
        public bool m_nowait;
        public string m_queue;
        public ushort m_ticket;
        public QueueDelete() { }
        public QueueDelete(ushort initTicket, string initQueue, bool initIfUnused, bool initIfEmpty, bool initNowait) { }
        public override bool HasContent { get { throw null; } }
        public override int ProtocolClassId { get { throw null; } }
        public override int ProtocolMethodId { get { throw null; } }
        public override string ProtocolMethodName { get { throw null; } }
        bool RabbitMQ.Client.Framing.v0_9.IQueueDelete.IfEmpty { get { throw null; } }
        bool RabbitMQ.Client.Framing.v0_9.IQueueDelete.IfUnused { get { throw null; } }
        bool RabbitMQ.Client.Framing.v0_9.IQueueDelete.Nowait { get { throw null; } }
        string RabbitMQ.Client.Framing.v0_9.IQueueDelete.Queue { get { throw null; } }
        ushort RabbitMQ.Client.Framing.v0_9.IQueueDelete.Ticket { get { throw null; } }
        public override void AppendArgumentDebugStringTo(System.Text.StringBuilder sb) { }
        public override void ReadArgumentsFrom(RabbitMQ.Client.Impl.MethodArgumentReader reader) { }
        public override void WriteArgumentsTo(RabbitMQ.Client.Impl.MethodArgumentWriter writer) { }
    }
    public partial class QueueDeleteOk : RabbitMQ.Client.Impl.MethodBase, RabbitMQ.Client.Framing.v0_9.IQueueDeleteOk, RabbitMQ.Client.IMethod
    {
        public const int ClassId = 50;
        public const int MethodId = 41;
        public uint m_messageCount;
        public QueueDeleteOk() { }
        public QueueDeleteOk(uint initMessageCount) { }
        public override bool HasContent { get { throw null; } }
        public override int ProtocolClassId { get { throw null; } }
        public override int ProtocolMethodId { get { throw null; } }
        public override string ProtocolMethodName { get { throw null; } }
        uint RabbitMQ.Client.Framing.v0_9.IQueueDeleteOk.MessageCount { get { throw null; } }
        public override void AppendArgumentDebugStringTo(System.Text.StringBuilder sb) { }
        public override void ReadArgumentsFrom(RabbitMQ.Client.Impl.MethodArgumentReader reader) { }
        public override void WriteArgumentsTo(RabbitMQ.Client.Impl.MethodArgumentWriter writer) { }
    }
    public partial class QueuePurge : RabbitMQ.Client.Impl.MethodBase, RabbitMQ.Client.Framing.v0_9.IQueuePurge, RabbitMQ.Client.IMethod
    {
        public const int ClassId = 50;
        public const int MethodId = 30;
        public bool m_nowait;
        public string m_queue;
        public ushort m_ticket;
        public QueuePurge() { }
        public QueuePurge(ushort initTicket, string initQueue, bool initNowait) { }
        public override bool HasContent { get { throw null; } }
        public override int ProtocolClassId { get { throw null; } }
        public override int ProtocolMethodId { get { throw null; } }
        public override string ProtocolMethodName { get { throw null; } }
        bool RabbitMQ.Client.Framing.v0_9.IQueuePurge.Nowait { get { throw null; } }
        string RabbitMQ.Client.Framing.v0_9.IQueuePurge.Queue { get { throw null; } }
        ushort RabbitMQ.Client.Framing.v0_9.IQueuePurge.Ticket { get { throw null; } }
        public override void AppendArgumentDebugStringTo(System.Text.StringBuilder sb) { }
        public override void ReadArgumentsFrom(RabbitMQ.Client.Impl.MethodArgumentReader reader) { }
        public override void WriteArgumentsTo(RabbitMQ.Client.Impl.MethodArgumentWriter writer) { }
    }
    public partial class QueuePurgeOk : RabbitMQ.Client.Impl.MethodBase, RabbitMQ.Client.Framing.v0_9.IQueuePurgeOk, RabbitMQ.Client.IMethod
    {
        public const int ClassId = 50;
        public const int MethodId = 31;
        public uint m_messageCount;
        public QueuePurgeOk() { }
        public QueuePurgeOk(uint initMessageCount) { }
        public override bool HasContent { get { throw null; } }
        public override int ProtocolClassId { get { throw null; } }
        public override int ProtocolMethodId { get { throw null; } }
        public override string ProtocolMethodName { get { throw null; } }
        uint RabbitMQ.Client.Framing.v0_9.IQueuePurgeOk.MessageCount { get { throw null; } }
        public override void AppendArgumentDebugStringTo(System.Text.StringBuilder sb) { }
        public override void ReadArgumentsFrom(RabbitMQ.Client.Impl.MethodArgumentReader reader) { }
        public override void WriteArgumentsTo(RabbitMQ.Client.Impl.MethodArgumentWriter writer) { }
    }
    public partial class QueueUnbind : RabbitMQ.Client.Impl.MethodBase, RabbitMQ.Client.Framing.v0_9.IQueueUnbind, RabbitMQ.Client.IMethod
    {
        public const int ClassId = 50;
        public const int MethodId = 50;
        public System.Collections.IDictionary m_arguments;
        public string m_exchange;
        public string m_queue;
        public string m_routingKey;
        public ushort m_ticket;
        public QueueUnbind() { }
        public QueueUnbind(ushort initTicket, string initQueue, string initExchange, string initRoutingKey, System.Collections.IDictionary initArguments) { }
        public override bool HasContent { get { throw null; } }
        public override int ProtocolClassId { get { throw null; } }
        public override int ProtocolMethodId { get { throw null; } }
        public override string ProtocolMethodName { get { throw null; } }
        System.Collections.IDictionary RabbitMQ.Client.Framing.v0_9.IQueueUnbind.Arguments { get { throw null; } }
        string RabbitMQ.Client.Framing.v0_9.IQueueUnbind.Exchange { get { throw null; } }
        string RabbitMQ.Client.Framing.v0_9.IQueueUnbind.Queue { get { throw null; } }
        string RabbitMQ.Client.Framing.v0_9.IQueueUnbind.RoutingKey { get { throw null; } }
        ushort RabbitMQ.Client.Framing.v0_9.IQueueUnbind.Ticket { get { throw null; } }
        public override void AppendArgumentDebugStringTo(System.Text.StringBuilder sb) { }
        public override void ReadArgumentsFrom(RabbitMQ.Client.Impl.MethodArgumentReader reader) { }
        public override void WriteArgumentsTo(RabbitMQ.Client.Impl.MethodArgumentWriter writer) { }
    }
    public partial class QueueUnbindOk : RabbitMQ.Client.Impl.MethodBase, RabbitMQ.Client.Framing.v0_9.IQueueUnbindOk, RabbitMQ.Client.IMethod
    {
        public const int ClassId = 50;
        public const int MethodId = 51;
        public QueueUnbindOk() { }
        public override bool HasContent { get { throw null; } }
        public override int ProtocolClassId { get { throw null; } }
        public override int ProtocolMethodId { get { throw null; } }
        public override string ProtocolMethodName { get { throw null; } }
        public override void AppendArgumentDebugStringTo(System.Text.StringBuilder sb) { }
        public override void ReadArgumentsFrom(RabbitMQ.Client.Impl.MethodArgumentReader reader) { }
        public override void WriteArgumentsTo(RabbitMQ.Client.Impl.MethodArgumentWriter writer) { }
    }
    public partial class StreamCancel : RabbitMQ.Client.Impl.MethodBase, RabbitMQ.Client.Framing.v0_9.IStreamCancel, RabbitMQ.Client.IMethod
    {
        public const int ClassId = 80;
        public const int MethodId = 30;
        public string m_consumerTag;
        public bool m_nowait;
        public StreamCancel() { }
        public StreamCancel(string initConsumerTag, bool initNowait) { }
        public override bool HasContent { get { throw null; } }
        public override int ProtocolClassId { get { throw null; } }
        public override int ProtocolMethodId { get { throw null; } }
        public override string ProtocolMethodName { get { throw null; } }
        string RabbitMQ.Client.Framing.v0_9.IStreamCancel.ConsumerTag { get { throw null; } }
        bool RabbitMQ.Client.Framing.v0_9.IStreamCancel.Nowait { get { throw null; } }
        public override void AppendArgumentDebugStringTo(System.Text.StringBuilder sb) { }
        public override void ReadArgumentsFrom(RabbitMQ.Client.Impl.MethodArgumentReader reader) { }
        public override void WriteArgumentsTo(RabbitMQ.Client.Impl.MethodArgumentWriter writer) { }
    }
    public partial class StreamCancelOk : RabbitMQ.Client.Impl.MethodBase, RabbitMQ.Client.Framing.v0_9.IStreamCancelOk, RabbitMQ.Client.IMethod
    {
        public const int ClassId = 80;
        public const int MethodId = 31;
        public string m_consumerTag;
        public StreamCancelOk() { }
        public StreamCancelOk(string initConsumerTag) { }
        public override bool HasContent { get { throw null; } }
        public override int ProtocolClassId { get { throw null; } }
        public override int ProtocolMethodId { get { throw null; } }
        public override string ProtocolMethodName { get { throw null; } }
        string RabbitMQ.Client.Framing.v0_9.IStreamCancelOk.ConsumerTag { get { throw null; } }
        public override void AppendArgumentDebugStringTo(System.Text.StringBuilder sb) { }
        public override void ReadArgumentsFrom(RabbitMQ.Client.Impl.MethodArgumentReader reader) { }
        public override void WriteArgumentsTo(RabbitMQ.Client.Impl.MethodArgumentWriter writer) { }
    }
    public partial class StreamConsume : RabbitMQ.Client.Impl.MethodBase, RabbitMQ.Client.Framing.v0_9.IStreamConsume, RabbitMQ.Client.IMethod
    {
        public const int ClassId = 80;
        public const int MethodId = 20;
        public string m_consumerTag;
        public bool m_exclusive;
        public System.Collections.IDictionary m_filter;
        public bool m_noLocal;
        public bool m_nowait;
        public string m_queue;
        public ushort m_ticket;
        public StreamConsume() { }
        public StreamConsume(ushort initTicket, string initQueue, string initConsumerTag, bool initNoLocal, bool initExclusive, bool initNowait, System.Collections.IDictionary initFilter) { }
        public override bool HasContent { get { throw null; } }
        public override int ProtocolClassId { get { throw null; } }
        public override int ProtocolMethodId { get { throw null; } }
        public override string ProtocolMethodName { get { throw null; } }
        string RabbitMQ.Client.Framing.v0_9.IStreamConsume.ConsumerTag { get { throw null; } }
        bool RabbitMQ.Client.Framing.v0_9.IStreamConsume.Exclusive { get { throw null; } }
        System.Collections.IDictionary RabbitMQ.Client.Framing.v0_9.IStreamConsume.Filter { get { throw null; } }
        bool RabbitMQ.Client.Framing.v0_9.IStreamConsume.NoLocal { get { throw null; } }
        bool RabbitMQ.Client.Framing.v0_9.IStreamConsume.Nowait { get { throw null; } }
        string RabbitMQ.Client.Framing.v0_9.IStreamConsume.Queue { get { throw null; } }
        ushort RabbitMQ.Client.Framing.v0_9.IStreamConsume.Ticket { get { throw null; } }
        public override void AppendArgumentDebugStringTo(System.Text.StringBuilder sb) { }
        public override void ReadArgumentsFrom(RabbitMQ.Client.Impl.MethodArgumentReader reader) { }
        public override void WriteArgumentsTo(RabbitMQ.Client.Impl.MethodArgumentWriter writer) { }
    }
    public partial class StreamConsumeOk : RabbitMQ.Client.Impl.MethodBase, RabbitMQ.Client.Framing.v0_9.IStreamConsumeOk, RabbitMQ.Client.IMethod
    {
        public const int ClassId = 80;
        public const int MethodId = 21;
        public string m_consumerTag;
        public StreamConsumeOk() { }
        public StreamConsumeOk(string initConsumerTag) { }
        public override bool HasContent { get { throw null; } }
        public override int ProtocolClassId { get { throw null; } }
        public override int ProtocolMethodId { get { throw null; } }
        public override string ProtocolMethodName { get { throw null; } }
        string RabbitMQ.Client.Framing.v0_9.IStreamConsumeOk.ConsumerTag { get { throw null; } }
        public override void AppendArgumentDebugStringTo(System.Text.StringBuilder sb) { }
        public override void ReadArgumentsFrom(RabbitMQ.Client.Impl.MethodArgumentReader reader) { }
        public override void WriteArgumentsTo(RabbitMQ.Client.Impl.MethodArgumentWriter writer) { }
    }
    public partial class StreamDeliver : RabbitMQ.Client.Impl.MethodBase, RabbitMQ.Client.Framing.v0_9.IStreamDeliver, RabbitMQ.Client.IMethod
    {
        public const int ClassId = 80;
        public const int MethodId = 60;
        public string m_consumerTag;
        public ulong m_deliveryTag;
        public string m_exchange;
        public string m_queue;
        public StreamDeliver() { }
        public StreamDeliver(string initConsumerTag, ulong initDeliveryTag, string initExchange, string initQueue) { }
        public override bool HasContent { get { throw null; } }
        public override int ProtocolClassId { get { throw null; } }
        public override int ProtocolMethodId { get { throw null; } }
        public override string ProtocolMethodName { get { throw null; } }
        string RabbitMQ.Client.Framing.v0_9.IStreamDeliver.ConsumerTag { get { throw null; } }
        ulong RabbitMQ.Client.Framing.v0_9.IStreamDeliver.DeliveryTag { get { throw null; } }
        string RabbitMQ.Client.Framing.v0_9.IStreamDeliver.Exchange { get { throw null; } }
        string RabbitMQ.Client.Framing.v0_9.IStreamDeliver.Queue { get { throw null; } }
        public override void AppendArgumentDebugStringTo(System.Text.StringBuilder sb) { }
        public override void ReadArgumentsFrom(RabbitMQ.Client.Impl.MethodArgumentReader reader) { }
        public override void WriteArgumentsTo(RabbitMQ.Client.Impl.MethodArgumentWriter writer) { }
    }
    public partial class StreamPublish : RabbitMQ.Client.Impl.MethodBase, RabbitMQ.Client.Framing.v0_9.IStreamPublish, RabbitMQ.Client.IMethod
    {
        public const int ClassId = 80;
        public const int MethodId = 40;
        public string m_exchange;
        public bool m_immediate;
        public bool m_mandatory;
        public string m_routingKey;
        public ushort m_ticket;
        public StreamPublish() { }
        public StreamPublish(ushort initTicket, string initExchange, string initRoutingKey, bool initMandatory, bool initImmediate) { }
        public override bool HasContent { get { throw null; } }
        public override int ProtocolClassId { get { throw null; } }
        public override int ProtocolMethodId { get { throw null; } }
        public override string ProtocolMethodName { get { throw null; } }
        string RabbitMQ.Client.Framing.v0_9.IStreamPublish.Exchange { get { throw null; } }
        bool RabbitMQ.Client.Framing.v0_9.IStreamPublish.Immediate { get { throw null; } }
        bool RabbitMQ.Client.Framing.v0_9.IStreamPublish.Mandatory { get { throw null; } }
        string RabbitMQ.Client.Framing.v0_9.IStreamPublish.RoutingKey { get { throw null; } }
        ushort RabbitMQ.Client.Framing.v0_9.IStreamPublish.Ticket { get { throw null; } }
        public override void AppendArgumentDebugStringTo(System.Text.StringBuilder sb) { }
        public override void ReadArgumentsFrom(RabbitMQ.Client.Impl.MethodArgumentReader reader) { }
        public override void WriteArgumentsTo(RabbitMQ.Client.Impl.MethodArgumentWriter writer) { }
    }
    public partial class StreamQos : RabbitMQ.Client.Impl.MethodBase, RabbitMQ.Client.Framing.v0_9.IStreamQos, RabbitMQ.Client.IMethod
    {
        public const int ClassId = 80;
        public const int MethodId = 10;
        public uint m_consumeRate;
        public bool m_global;
        public ushort m_prefetchCount;
        public uint m_prefetchSize;
        public StreamQos() { }
        public StreamQos(uint initPrefetchSize, ushort initPrefetchCount, uint initConsumeRate, bool initGlobal) { }
        public override bool HasContent { get { throw null; } }
        public override int ProtocolClassId { get { throw null; } }
        public override int ProtocolMethodId { get { throw null; } }
        public override string ProtocolMethodName { get { throw null; } }
        uint RabbitMQ.Client.Framing.v0_9.IStreamQos.ConsumeRate { get { throw null; } }
        bool RabbitMQ.Client.Framing.v0_9.IStreamQos.Global { get { throw null; } }
        ushort RabbitMQ.Client.Framing.v0_9.IStreamQos.PrefetchCount { get { throw null; } }
        uint RabbitMQ.Client.Framing.v0_9.IStreamQos.PrefetchSize { get { throw null; } }
        public override void AppendArgumentDebugStringTo(System.Text.StringBuilder sb) { }
        public override void ReadArgumentsFrom(RabbitMQ.Client.Impl.MethodArgumentReader reader) { }
        public override void WriteArgumentsTo(RabbitMQ.Client.Impl.MethodArgumentWriter writer) { }
    }
    public partial class StreamQosOk : RabbitMQ.Client.Impl.MethodBase, RabbitMQ.Client.Framing.v0_9.IStreamQosOk, RabbitMQ.Client.IMethod
    {
        public const int ClassId = 80;
        public const int MethodId = 11;
        public StreamQosOk() { }
        public override bool HasContent { get { throw null; } }
        public override int ProtocolClassId { get { throw null; } }
        public override int ProtocolMethodId { get { throw null; } }
        public override string ProtocolMethodName { get { throw null; } }
        public override void AppendArgumentDebugStringTo(System.Text.StringBuilder sb) { }
        public override void ReadArgumentsFrom(RabbitMQ.Client.Impl.MethodArgumentReader reader) { }
        public override void WriteArgumentsTo(RabbitMQ.Client.Impl.MethodArgumentWriter writer) { }
    }
    public partial class StreamReturn : RabbitMQ.Client.Impl.MethodBase, RabbitMQ.Client.Framing.v0_9.IStreamReturn, RabbitMQ.Client.IMethod
    {
        public const int ClassId = 80;
        public const int MethodId = 50;
        public string m_exchange;
        public ushort m_replyCode;
        public string m_replyText;
        public string m_routingKey;
        public StreamReturn() { }
        public StreamReturn(ushort initReplyCode, string initReplyText, string initExchange, string initRoutingKey) { }
        public override bool HasContent { get { throw null; } }
        public override int ProtocolClassId { get { throw null; } }
        public override int ProtocolMethodId { get { throw null; } }
        public override string ProtocolMethodName { get { throw null; } }
        string RabbitMQ.Client.Framing.v0_9.IStreamReturn.Exchange { get { throw null; } }
        ushort RabbitMQ.Client.Framing.v0_9.IStreamReturn.ReplyCode { get { throw null; } }
        string RabbitMQ.Client.Framing.v0_9.IStreamReturn.ReplyText { get { throw null; } }
        string RabbitMQ.Client.Framing.v0_9.IStreamReturn.RoutingKey { get { throw null; } }
        public override void AppendArgumentDebugStringTo(System.Text.StringBuilder sb) { }
        public override void ReadArgumentsFrom(RabbitMQ.Client.Impl.MethodArgumentReader reader) { }
        public override void WriteArgumentsTo(RabbitMQ.Client.Impl.MethodArgumentWriter writer) { }
    }
    public partial class TunnelRequest : RabbitMQ.Client.Impl.MethodBase, RabbitMQ.Client.Framing.v0_9.ITunnelRequest, RabbitMQ.Client.IMethod
    {
        public const int ClassId = 110;
        public const int MethodId = 10;
        public System.Collections.IDictionary m_metaData;
        public TunnelRequest() { }
        public TunnelRequest(System.Collections.IDictionary initMetaData) { }
        public override bool HasContent { get { throw null; } }
        public override int ProtocolClassId { get { throw null; } }
        public override int ProtocolMethodId { get { throw null; } }
        public override string ProtocolMethodName { get { throw null; } }
        System.Collections.IDictionary RabbitMQ.Client.Framing.v0_9.ITunnelRequest.MetaData { get { throw null; } }
        public override void AppendArgumentDebugStringTo(System.Text.StringBuilder sb) { }
        public override void ReadArgumentsFrom(RabbitMQ.Client.Impl.MethodArgumentReader reader) { }
        public override void WriteArgumentsTo(RabbitMQ.Client.Impl.MethodArgumentWriter writer) { }
    }
    public partial class TxCommit : RabbitMQ.Client.Impl.MethodBase, RabbitMQ.Client.Framing.v0_9.ITxCommit, RabbitMQ.Client.IMethod
    {
        public const int ClassId = 90;
        public const int MethodId = 20;
        public TxCommit() { }
        public override bool HasContent { get { throw null; } }
        public override int ProtocolClassId { get { throw null; } }
        public override int ProtocolMethodId { get { throw null; } }
        public override string ProtocolMethodName { get { throw null; } }
        public override void AppendArgumentDebugStringTo(System.Text.StringBuilder sb) { }
        public override void ReadArgumentsFrom(RabbitMQ.Client.Impl.MethodArgumentReader reader) { }
        public override void WriteArgumentsTo(RabbitMQ.Client.Impl.MethodArgumentWriter writer) { }
    }
    public partial class TxCommitOk : RabbitMQ.Client.Impl.MethodBase, RabbitMQ.Client.Framing.v0_9.ITxCommitOk, RabbitMQ.Client.IMethod
    {
        public const int ClassId = 90;
        public const int MethodId = 21;
        public TxCommitOk() { }
        public override bool HasContent { get { throw null; } }
        public override int ProtocolClassId { get { throw null; } }
        public override int ProtocolMethodId { get { throw null; } }
        public override string ProtocolMethodName { get { throw null; } }
        public override void AppendArgumentDebugStringTo(System.Text.StringBuilder sb) { }
        public override void ReadArgumentsFrom(RabbitMQ.Client.Impl.MethodArgumentReader reader) { }
        public override void WriteArgumentsTo(RabbitMQ.Client.Impl.MethodArgumentWriter writer) { }
    }
    public partial class TxRollback : RabbitMQ.Client.Impl.MethodBase, RabbitMQ.Client.Framing.v0_9.ITxRollback, RabbitMQ.Client.IMethod
    {
        public const int ClassId = 90;
        public const int MethodId = 30;
        public TxRollback() { }
        public override bool HasContent { get { throw null; } }
        public override int ProtocolClassId { get { throw null; } }
        public override int ProtocolMethodId { get { throw null; } }
        public override string ProtocolMethodName { get { throw null; } }
        public override void AppendArgumentDebugStringTo(System.Text.StringBuilder sb) { }
        public override void ReadArgumentsFrom(RabbitMQ.Client.Impl.MethodArgumentReader reader) { }
        public override void WriteArgumentsTo(RabbitMQ.Client.Impl.MethodArgumentWriter writer) { }
    }
    public partial class TxRollbackOk : RabbitMQ.Client.Impl.MethodBase, RabbitMQ.Client.Framing.v0_9.ITxRollbackOk, RabbitMQ.Client.IMethod
    {
        public const int ClassId = 90;
        public const int MethodId = 31;
        public TxRollbackOk() { }
        public override bool HasContent { get { throw null; } }
        public override int ProtocolClassId { get { throw null; } }
        public override int ProtocolMethodId { get { throw null; } }
        public override string ProtocolMethodName { get { throw null; } }
        public override void AppendArgumentDebugStringTo(System.Text.StringBuilder sb) { }
        public override void ReadArgumentsFrom(RabbitMQ.Client.Impl.MethodArgumentReader reader) { }
        public override void WriteArgumentsTo(RabbitMQ.Client.Impl.MethodArgumentWriter writer) { }
    }
    public partial class TxSelect : RabbitMQ.Client.Impl.MethodBase, RabbitMQ.Client.Framing.v0_9.ITxSelect, RabbitMQ.Client.IMethod
    {
        public const int ClassId = 90;
        public const int MethodId = 10;
        public TxSelect() { }
        public override bool HasContent { get { throw null; } }
        public override int ProtocolClassId { get { throw null; } }
        public override int ProtocolMethodId { get { throw null; } }
        public override string ProtocolMethodName { get { throw null; } }
        public override void AppendArgumentDebugStringTo(System.Text.StringBuilder sb) { }
        public override void ReadArgumentsFrom(RabbitMQ.Client.Impl.MethodArgumentReader reader) { }
        public override void WriteArgumentsTo(RabbitMQ.Client.Impl.MethodArgumentWriter writer) { }
    }
    public partial class TxSelectOk : RabbitMQ.Client.Impl.MethodBase, RabbitMQ.Client.Framing.v0_9.ITxSelectOk, RabbitMQ.Client.IMethod
    {
        public const int ClassId = 90;
        public const int MethodId = 11;
        public TxSelectOk() { }
        public override bool HasContent { get { throw null; } }
        public override int ProtocolClassId { get { throw null; } }
        public override int ProtocolMethodId { get { throw null; } }
        public override string ProtocolMethodName { get { throw null; } }
        public override void AppendArgumentDebugStringTo(System.Text.StringBuilder sb) { }
        public override void ReadArgumentsFrom(RabbitMQ.Client.Impl.MethodArgumentReader reader) { }
        public override void WriteArgumentsTo(RabbitMQ.Client.Impl.MethodArgumentWriter writer) { }
    }
}
namespace RabbitMQ.Client.Framing.v0_8
{
    public partial class BasicProperties : RabbitMQ.Client.Impl.BasicProperties
    {
        public BasicProperties() { }
        public override string AppId { get { throw null; } set { } }
        public override string ClusterId { get { throw null; } set { } }
        public override string ContentEncoding { get { throw null; } set { } }
        public override string ContentType { get { throw null; } set { } }
        public override string CorrelationId { get { throw null; } set { } }
        public override byte DeliveryMode { get { throw null; } set { } }
        public override string Expiration { get { throw null; } set { } }
        public override System.Collections.IDictionary Headers { get { throw null; } set { } }
        public override string MessageId { get { throw null; } set { } }
        public override byte Priority { get { throw null; } set { } }
        public override int ProtocolClassId { get { throw null; } }
        public override string ProtocolClassName { get { throw null; } }
        public override string ReplyTo { get { throw null; } set { } }
        public override RabbitMQ.Client.AmqpTimestamp Timestamp { get { throw null; } set { } }
        public override string Type { get { throw null; } set { } }
        public override string UserId { get { throw null; } set { } }
        public override void AppendPropertyDebugStringTo(System.Text.StringBuilder sb) { }
        public override void ClearAppId() { }
        public override void ClearClusterId() { }
        public override void ClearContentEncoding() { }
        public override void ClearContentType() { }
        public override void ClearCorrelationId() { }
        public override void ClearDeliveryMode() { }
        public override void ClearExpiration() { }
        public override void ClearHeaders() { }
        public override void ClearMessageId() { }
        public override void ClearPriority() { }
        public override void ClearReplyTo() { }
        public override void ClearTimestamp() { }
        public override void ClearType() { }
        public override void ClearUserId() { }
        public override bool IsAppIdPresent() { throw null; }
        public override bool IsClusterIdPresent() { throw null; }
        public override bool IsContentEncodingPresent() { throw null; }
        public override bool IsContentTypePresent() { throw null; }
        public override bool IsCorrelationIdPresent() { throw null; }
        public override bool IsDeliveryModePresent() { throw null; }
        public override bool IsExpirationPresent() { throw null; }
        public override bool IsHeadersPresent() { throw null; }
        public override bool IsMessageIdPresent() { throw null; }
        public override bool IsPriorityPresent() { throw null; }
        public override bool IsReplyToPresent() { throw null; }
        public override bool IsTimestampPresent() { throw null; }
        public override bool IsTypePresent() { throw null; }
        public override bool IsUserIdPresent() { throw null; }
        public override void ReadPropertiesFrom(RabbitMQ.Client.Impl.ContentHeaderPropertyReader reader) { }
        public override void WritePropertiesTo(RabbitMQ.Client.Impl.ContentHeaderPropertyWriter writer) { }
    }
    public partial class Constants
    {
        public const int AccessRefused = 403;
        public const int ChannelError = 504;
        public const int CommandInvalid = 503;
        public const int ConnectionForced = 320;
        public const int ContentTooLarge = 311;
        public const int FrameBody = 3;
        public const int FrameEnd = 206;
        public const int FrameError = 501;
        public const int FrameHeader = 2;
        public const int FrameHeartbeat = 8;
        public const int FrameMethod = 1;
        public const int FrameMinSize = 4096;
        public const int FrameOobBody = 6;
        public const int FrameOobHeader = 5;
        public const int FrameOobMethod = 4;
        public const int FrameTrace = 7;
        public const int InternalError = 541;
        public const int InvalidPath = 402;
        public const int NotAllowed = 530;
        public const int NotDelivered = 310;
        public const int NotFound = 404;
        public const int NotImplemented = 540;
        public const int ReplySuccess = 200;
        public const int ResourceError = 506;
        public const int ResourceLocked = 405;
        public const int SyntaxError = 502;
        public Constants() { }
    }
    public partial class FileProperties : RabbitMQ.Client.Impl.FileProperties
    {
        public FileProperties() { }
        public override string ClusterId { get { throw null; } set { } }
        public override string ContentEncoding { get { throw null; } set { } }
        public override string ContentType { get { throw null; } set { } }
        public override string Filename { get { throw null; } set { } }
        public override System.Collections.IDictionary Headers { get { throw null; } set { } }
        public override string MessageId { get { throw null; } set { } }
        public override byte Priority { get { throw null; } set { } }
        public override int ProtocolClassId { get { throw null; } }
        public override string ProtocolClassName { get { throw null; } }
        public override string ReplyTo { get { throw null; } set { } }
        public override RabbitMQ.Client.AmqpTimestamp Timestamp { get { throw null; } set { } }
        public override void AppendPropertyDebugStringTo(System.Text.StringBuilder sb) { }
        public override void ClearClusterId() { }
        public override void ClearContentEncoding() { }
        public override void ClearContentType() { }
        public override void ClearFilename() { }
        public override void ClearHeaders() { }
        public override void ClearMessageId() { }
        public override void ClearPriority() { }
        public override void ClearReplyTo() { }
        public override void ClearTimestamp() { }
        public override bool IsClusterIdPresent() { throw null; }
        public override bool IsContentEncodingPresent() { throw null; }
        public override bool IsContentTypePresent() { throw null; }
        public override bool IsFilenamePresent() { throw null; }
        public override bool IsHeadersPresent() { throw null; }
        public override bool IsMessageIdPresent() { throw null; }
        public override bool IsPriorityPresent() { throw null; }
        public override bool IsReplyToPresent() { throw null; }
        public override bool IsTimestampPresent() { throw null; }
        public override void ReadPropertiesFrom(RabbitMQ.Client.Impl.ContentHeaderPropertyReader reader) { }
        public override void WritePropertiesTo(RabbitMQ.Client.Impl.ContentHeaderPropertyWriter writer) { }
    }
    public partial interface IAccessRequest : RabbitMQ.Client.IMethod
    {
        bool Active { get; }
        bool Exclusive { get; }
        bool Passive { get; }
        bool Read { get; }
        string Realm { get; }
        bool Write { get; }
    }
    public partial interface IAccessRequestOk : RabbitMQ.Client.IMethod
    {
        ushort Ticket { get; }
    }
    public partial interface IBasicAck : RabbitMQ.Client.IMethod
    {
        ulong DeliveryTag { get; }
        bool Multiple { get; }
    }
    public partial interface IBasicCancel : RabbitMQ.Client.IMethod
    {
        string ConsumerTag { get; }
        bool Nowait { get; }
    }
    public partial interface IBasicCancelOk : RabbitMQ.Client.IMethod
    {
        string ConsumerTag { get; }
    }
    public partial interface IBasicConsume : RabbitMQ.Client.IMethod
    {
        string ConsumerTag { get; }
        bool Exclusive { get; }
        bool NoAck { get; }
        bool NoLocal { get; }
        bool Nowait { get; }
        string Queue { get; }
        ushort Ticket { get; }
    }
    public partial interface IBasicConsumeOk : RabbitMQ.Client.IMethod
    {
        string ConsumerTag { get; }
    }
    public partial interface IBasicDeliver : RabbitMQ.Client.IMethod
    {
        string ConsumerTag { get; }
        ulong DeliveryTag { get; }
        string Exchange { get; }
        bool Redelivered { get; }
        string RoutingKey { get; }
    }
    public partial interface IBasicGet : RabbitMQ.Client.IMethod
    {
        bool NoAck { get; }
        string Queue { get; }
        ushort Ticket { get; }
    }
    public partial interface IBasicGetEmpty : RabbitMQ.Client.IMethod
    {
        string ClusterId { get; }
    }
    public partial interface IBasicGetOk : RabbitMQ.Client.IMethod
    {
        ulong DeliveryTag { get; }
        string Exchange { get; }
        uint MessageCount { get; }
        bool Redelivered { get; }
        string RoutingKey { get; }
    }
    public partial interface IBasicPublish : RabbitMQ.Client.IMethod
    {
        string Exchange { get; }
        bool Immediate { get; }
        bool Mandatory { get; }
        string RoutingKey { get; }
        ushort Ticket { get; }
    }
    public partial interface IBasicQos : RabbitMQ.Client.IMethod
    {
        bool Global { get; }
        ushort PrefetchCount { get; }
        uint PrefetchSize { get; }
    }
    public partial interface IBasicQosOk : RabbitMQ.Client.IMethod
    {
    }
    public partial interface IBasicRecover : RabbitMQ.Client.IMethod
    {
        bool Requeue { get; }
    }
    public partial interface IBasicReject : RabbitMQ.Client.IMethod
    {
        ulong DeliveryTag { get; }
        bool Requeue { get; }
    }
    public partial interface IBasicReturn : RabbitMQ.Client.IMethod
    {
        string Exchange { get; }
        ushort ReplyCode { get; }
        string ReplyText { get; }
        string RoutingKey { get; }
    }
    public partial interface IChannelAlert : RabbitMQ.Client.IMethod
    {
        System.Collections.IDictionary Details { get; }
        ushort ReplyCode { get; }
        string ReplyText { get; }
    }
    public partial interface IChannelClose : RabbitMQ.Client.IMethod
    {
        ushort ClassId { get; }
        ushort MethodId { get; }
        ushort ReplyCode { get; }
        string ReplyText { get; }
    }
    public partial interface IChannelCloseOk : RabbitMQ.Client.IMethod
    {
    }
    public partial interface IChannelFlow : RabbitMQ.Client.IMethod
    {
        bool Active { get; }
    }
    public partial interface IChannelFlowOk : RabbitMQ.Client.IMethod
    {
        bool Active { get; }
    }
    public partial interface IChannelOpen : RabbitMQ.Client.IMethod
    {
        string OutOfBand { get; }
    }
    public partial interface IChannelOpenOk : RabbitMQ.Client.IMethod
    {
    }
    public partial interface IConnectionClose : RabbitMQ.Client.IMethod
    {
        ushort ClassId { get; }
        ushort MethodId { get; }
        ushort ReplyCode { get; }
        string ReplyText { get; }
    }
    public partial interface IConnectionCloseOk : RabbitMQ.Client.IMethod
    {
    }
    public partial interface IConnectionOpen : RabbitMQ.Client.IMethod
    {
        string Capabilities { get; }
        bool Insist { get; }
        string VirtualHost { get; }
    }
    public partial interface IConnectionOpenOk : RabbitMQ.Client.IMethod
    {
        string KnownHosts { get; }
    }
    public partial interface IConnectionRedirect : RabbitMQ.Client.IMethod
    {
        string Host { get; }
        string KnownHosts { get; }
    }
    public partial interface IConnectionSecure : RabbitMQ.Client.IMethod
    {
        byte[] Challenge { get; }
    }
    public partial interface IConnectionSecureOk : RabbitMQ.Client.IMethod
    {
        byte[] Response { get; }
    }
    public partial interface IConnectionStart : RabbitMQ.Client.IMethod
    {
        byte[] Locales { get; }
        byte[] Mechanisms { get; }
        System.Collections.IDictionary ServerProperties { get; }
        byte VersionMajor { get; }
        byte VersionMinor { get; }
    }
    public partial interface IConnectionStartOk : RabbitMQ.Client.IMethod
    {
        System.Collections.IDictionary ClientProperties { get; }
        string Locale { get; }
        string Mechanism { get; }
        byte[] Response { get; }
    }
    public partial interface IConnectionTune : RabbitMQ.Client.IMethod
    {
        ushort ChannelMax { get; }
        uint FrameMax { get; }
        ushort Heartbeat { get; }
    }
    public partial interface IConnectionTuneOk : RabbitMQ.Client.IMethod
    {
        ushort ChannelMax { get; }
        uint FrameMax { get; }
        ushort Heartbeat { get; }
    }
    public partial interface IDtxSelect : RabbitMQ.Client.IMethod
    {
    }
    public partial interface IDtxSelectOk : RabbitMQ.Client.IMethod
    {
    }
    public partial interface IDtxStart : RabbitMQ.Client.IMethod
    {
        string DtxIdentifier { get; }
    }
    public partial interface IDtxStartOk : RabbitMQ.Client.IMethod
    {
    }
    public partial interface IExchangeDeclare : RabbitMQ.Client.IMethod
    {
        System.Collections.IDictionary Arguments { get; }
        bool AutoDelete { get; }
        bool Durable { get; }
        string Exchange { get; }
        bool Internal { get; }
        bool Nowait { get; }
        bool Passive { get; }
        ushort Ticket { get; }
        string Type { get; }
    }
    public partial interface IExchangeDeclareOk : RabbitMQ.Client.IMethod
    {
    }
    public partial interface IExchangeDelete : RabbitMQ.Client.IMethod
    {
        string Exchange { get; }
        bool IfUnused { get; }
        bool Nowait { get; }
        ushort Ticket { get; }
    }
    public partial interface IExchangeDeleteOk : RabbitMQ.Client.IMethod
    {
    }
    public partial interface IFileAck : RabbitMQ.Client.IMethod
    {
        ulong DeliveryTag { get; }
        bool Multiple { get; }
    }
    public partial interface IFileCancel : RabbitMQ.Client.IMethod
    {
        string ConsumerTag { get; }
        bool Nowait { get; }
    }
    public partial interface IFileCancelOk : RabbitMQ.Client.IMethod
    {
        string ConsumerTag { get; }
    }
    public partial interface IFileConsume : RabbitMQ.Client.IMethod
    {
        string ConsumerTag { get; }
        bool Exclusive { get; }
        bool NoAck { get; }
        bool NoLocal { get; }
        bool Nowait { get; }
        string Queue { get; }
        ushort Ticket { get; }
    }
    public partial interface IFileConsumeOk : RabbitMQ.Client.IMethod
    {
        string ConsumerTag { get; }
    }
    public partial interface IFileDeliver : RabbitMQ.Client.IMethod
    {
        string ConsumerTag { get; }
        ulong DeliveryTag { get; }
        string Exchange { get; }
        string Identifier { get; }
        bool Redelivered { get; }
        string RoutingKey { get; }
    }
    public partial interface IFileOpen : RabbitMQ.Client.IMethod
    {
        ulong ContentSize { get; }
        string Identifier { get; }
    }
    public partial interface IFileOpenOk : RabbitMQ.Client.IMethod
    {
        ulong StagedSize { get; }
    }
    public partial interface IFilePublish : RabbitMQ.Client.IMethod
    {
        string Exchange { get; }
        string Identifier { get; }
        bool Immediate { get; }
        bool Mandatory { get; }
        string RoutingKey { get; }
        ushort Ticket { get; }
    }
    public partial interface IFileQos : RabbitMQ.Client.IMethod
    {
        bool Global { get; }
        ushort PrefetchCount { get; }
        uint PrefetchSize { get; }
    }
    public partial interface IFileQosOk : RabbitMQ.Client.IMethod
    {
    }
    public partial interface IFileReject : RabbitMQ.Client.IMethod
    {
        ulong DeliveryTag { get; }
        bool Requeue { get; }
    }
    public partial interface IFileReturn : RabbitMQ.Client.IMethod
    {
        string Exchange { get; }
        ushort ReplyCode { get; }
        string ReplyText { get; }
        string RoutingKey { get; }
    }
    public partial interface IFileStage : RabbitMQ.Client.IMethod
    {
    }
    public partial interface IQueueBind : RabbitMQ.Client.IMethod
    {
        System.Collections.IDictionary Arguments { get; }
        string Exchange { get; }
        bool Nowait { get; }
        string Queue { get; }
        string RoutingKey { get; }
        ushort Ticket { get; }
    }
    public partial interface IQueueBindOk : RabbitMQ.Client.IMethod
    {
    }
    public partial interface IQueueDeclare : RabbitMQ.Client.IMethod
    {
        System.Collections.IDictionary Arguments { get; }
        bool AutoDelete { get; }
        bool Durable { get; }
        bool Exclusive { get; }
        bool Nowait { get; }
        bool Passive { get; }
        string Queue { get; }
        ushort Ticket { get; }
    }
    public partial interface IQueueDeclareOk : RabbitMQ.Client.IMethod
    {
        uint ConsumerCount { get; }
        uint MessageCount { get; }
        string Queue { get; }
    }
    public partial interface IQueueDelete : RabbitMQ.Client.IMethod
    {
        bool IfEmpty { get; }
        bool IfUnused { get; }
        bool Nowait { get; }
        string Queue { get; }
        ushort Ticket { get; }
    }
    public partial interface IQueueDeleteOk : RabbitMQ.Client.IMethod
    {
        uint MessageCount { get; }
    }
    public partial interface IQueuePurge : RabbitMQ.Client.IMethod
    {
        bool Nowait { get; }
        string Queue { get; }
        ushort Ticket { get; }
    }
    public partial interface IQueuePurgeOk : RabbitMQ.Client.IMethod
    {
        uint MessageCount { get; }
    }
    public partial interface IQueueUnbind : RabbitMQ.Client.IMethod
    {
        System.Collections.IDictionary Arguments { get; }
        string Exchange { get; }
        string Queue { get; }
        string RoutingKey { get; }
        ushort Ticket { get; }
    }
    public partial interface IQueueUnbindOk : RabbitMQ.Client.IMethod
    {
    }
    public partial interface IStreamCancel : RabbitMQ.Client.IMethod
    {
        string ConsumerTag { get; }
        bool Nowait { get; }
    }
    public partial interface IStreamCancelOk : RabbitMQ.Client.IMethod
    {
        string ConsumerTag { get; }
    }
    public partial interface IStreamConsume : RabbitMQ.Client.IMethod
    {
        string ConsumerTag { get; }
        bool Exclusive { get; }
        bool NoLocal { get; }
        bool Nowait { get; }
        string Queue { get; }
        ushort Ticket { get; }
    }
    public partial interface IStreamConsumeOk : RabbitMQ.Client.IMethod
    {
        string ConsumerTag { get; }
    }
    public partial interface IStreamDeliver : RabbitMQ.Client.IMethod
    {
        string ConsumerTag { get; }
        ulong DeliveryTag { get; }
        string Exchange { get; }
        string Queue { get; }
    }
    public partial interface IStreamPublish : RabbitMQ.Client.IMethod
    {
        string Exchange { get; }
        bool Immediate { get; }
        bool Mandatory { get; }
        string RoutingKey { get; }
        ushort Ticket { get; }
    }
    public partial interface IStreamQos : RabbitMQ.Client.IMethod
    {
        uint ConsumeRate { get; }
        bool Global { get; }
        ushort PrefetchCount { get; }
        uint PrefetchSize { get; }
    }
    public partial interface IStreamQosOk : RabbitMQ.Client.IMethod
    {
    }
    public partial interface IStreamReturn : RabbitMQ.Client.IMethod
    {
        string Exchange { get; }
        ushort ReplyCode { get; }
        string ReplyText { get; }
        string RoutingKey { get; }
    }
    public partial interface ITestContent : RabbitMQ.Client.IMethod
    {
    }
    public partial interface ITestContentOk : RabbitMQ.Client.IMethod
    {
        uint ContentChecksum { get; }
    }
    public partial interface ITestInteger : RabbitMQ.Client.IMethod
    {
        byte Integer1 { get; }
        ushort Integer2 { get; }
        uint Integer3 { get; }
        ulong Integer4 { get; }
        byte Operation { get; }
    }
    public partial interface ITestIntegerOk : RabbitMQ.Client.IMethod
    {
        ulong Result { get; }
    }
    public partial interface ITestString : RabbitMQ.Client.IMethod
    {
        byte Operation { get; }
        string String1 { get; }
        byte[] String2 { get; }
    }
    public partial interface ITestStringOk : RabbitMQ.Client.IMethod
    {
        byte[] Result { get; }
    }
    public partial interface ITestTable : RabbitMQ.Client.IMethod
    {
        byte IntegerOp { get; }
        byte StringOp { get; }
        System.Collections.IDictionary Table { get; }
    }
    public partial interface ITestTableOk : RabbitMQ.Client.IMethod
    {
        ulong IntegerResult { get; }
        byte[] StringResult { get; }
    }
    public partial interface ITunnelRequest : RabbitMQ.Client.IMethod
    {
        System.Collections.IDictionary MetaData { get; }
    }
    public partial interface ITxCommit : RabbitMQ.Client.IMethod
    {
    }
    public partial interface ITxCommitOk : RabbitMQ.Client.IMethod
    {
    }
    public partial interface ITxRollback : RabbitMQ.Client.IMethod
    {
    }
    public partial interface ITxRollbackOk : RabbitMQ.Client.IMethod
    {
    }
    public partial interface ITxSelect : RabbitMQ.Client.IMethod
    {
    }
    public partial interface ITxSelectOk : RabbitMQ.Client.IMethod
    {
    }
    public partial class Protocol : RabbitMQ.Client.Framing.Impl.v0_8.ProtocolBase
    {
        public Protocol() { }
        public override string ApiName { get { throw null; } }
        public override int DefaultPort { get { throw null; } }
        public override int MajorVersion { get { throw null; } }
        public override int MinorVersion { get { throw null; } }
        public override RabbitMQ.Client.Impl.ContentHeaderBase DecodeContentHeaderFrom(RabbitMQ.Util.NetworkBinaryReader reader) { throw null; }
        public override RabbitMQ.Client.Impl.MethodBase DecodeMethodFrom(RabbitMQ.Util.NetworkBinaryReader reader) { throw null; }
    }
    public partial class StreamProperties : RabbitMQ.Client.Impl.StreamProperties
    {
        public StreamProperties() { }
        public override string ContentEncoding { get { throw null; } set { } }
        public override string ContentType { get { throw null; } set { } }
        public override System.Collections.IDictionary Headers { get { throw null; } set { } }
        public override byte Priority { get { throw null; } set { } }
        public override int ProtocolClassId { get { throw null; } }
        public override string ProtocolClassName { get { throw null; } }
        public override RabbitMQ.Client.AmqpTimestamp Timestamp { get { throw null; } set { } }
        public override void AppendPropertyDebugStringTo(System.Text.StringBuilder sb) { }
        public override void ClearContentEncoding() { }
        public override void ClearContentType() { }
        public override void ClearHeaders() { }
        public override void ClearPriority() { }
        public override void ClearTimestamp() { }
        public override bool IsContentEncodingPresent() { throw null; }
        public override bool IsContentTypePresent() { throw null; }
        public override bool IsHeadersPresent() { throw null; }
        public override bool IsPriorityPresent() { throw null; }
        public override bool IsTimestampPresent() { throw null; }
        public override void ReadPropertiesFrom(RabbitMQ.Client.Impl.ContentHeaderPropertyReader reader) { }
        public override void WritePropertiesTo(RabbitMQ.Client.Impl.ContentHeaderPropertyWriter writer) { }
    }
    public partial class TestProperties : RabbitMQ.Client.Impl.ContentHeaderBase
    {
        public TestProperties() { }
        public override int ProtocolClassId { get { throw null; } }
        public override string ProtocolClassName { get { throw null; } }
        public override void AppendPropertyDebugStringTo(System.Text.StringBuilder sb) { }
        public override void ReadPropertiesFrom(RabbitMQ.Client.Impl.ContentHeaderPropertyReader reader) { }
        public override void WritePropertiesTo(RabbitMQ.Client.Impl.ContentHeaderPropertyWriter writer) { }
    }
    public partial class TunnelProperties : RabbitMQ.Client.Impl.ContentHeaderBase
    {
        public TunnelProperties() { }
        public byte Broadcast { get { throw null; } set { } }
        public string DataName { get { throw null; } set { } }
        public byte Durable { get { throw null; } set { } }
        public System.Collections.IDictionary Headers { get { throw null; } set { } }
        public override int ProtocolClassId { get { throw null; } }
        public override string ProtocolClassName { get { throw null; } }
        public string ProxyName { get { throw null; } set { } }
        public override void AppendPropertyDebugStringTo(System.Text.StringBuilder sb) { }
        public void ClearBroadcast() { }
        public void ClearDataName() { }
        public void ClearDurable() { }
        public void ClearHeaders() { }
        public void ClearProxyName() { }
        public bool IsBroadcastPresent() { throw null; }
        public bool IsDataNamePresent() { throw null; }
        public bool IsDurablePresent() { throw null; }
        public bool IsHeadersPresent() { throw null; }
        public bool IsProxyNamePresent() { throw null; }
        public override void ReadPropertiesFrom(RabbitMQ.Client.Impl.ContentHeaderPropertyReader reader) { }
        public override void WritePropertiesTo(RabbitMQ.Client.Impl.ContentHeaderPropertyWriter writer) { }
    }
}
namespace RabbitMQ.Client.Framing.v0_8qpid
{
    public partial class BasicProperties : RabbitMQ.Client.Impl.BasicProperties
    {
        public BasicProperties() { }
        public override string AppId { get { throw null; } set { } }
        public override string ClusterId { get { throw null; } set { } }
        public override string ContentEncoding { get { throw null; } set { } }
        public override string ContentType { get { throw null; } set { } }
        public override string CorrelationId { get { throw null; } set { } }
        public override byte DeliveryMode { get { throw null; } set { } }
        public override string Expiration { get { throw null; } set { } }
        public override System.Collections.IDictionary Headers { get { throw null; } set { } }
        public override string MessageId { get { throw null; } set { } }
        public override byte Priority { get { throw null; } set { } }
        public override int ProtocolClassId { get { throw null; } }
        public override string ProtocolClassName { get { throw null; } }
        public override string ReplyTo { get { throw null; } set { } }
        public override RabbitMQ.Client.AmqpTimestamp Timestamp { get { throw null; } set { } }
        public override string Type { get { throw null; } set { } }
        public override string UserId { get { throw null; } set { } }
        public override void AppendPropertyDebugStringTo(System.Text.StringBuilder sb) { }
        public override void ClearAppId() { }
        public override void ClearClusterId() { }
        public override void ClearContentEncoding() { }
        public override void ClearContentType() { }
        public override void ClearCorrelationId() { }
        public override void ClearDeliveryMode() { }
        public override void ClearExpiration() { }
        public override void ClearHeaders() { }
        public override void ClearMessageId() { }
        public override void ClearPriority() { }
        public override void ClearReplyTo() { }
        public override void ClearTimestamp() { }
        public override void ClearType() { }
        public override void ClearUserId() { }
        public override bool IsAppIdPresent() { throw null; }
        public override bool IsClusterIdPresent() { throw null; }
        public override bool IsContentEncodingPresent() { throw null; }
        public override bool IsContentTypePresent() { throw null; }
        public override bool IsCorrelationIdPresent() { throw null; }
        public override bool IsDeliveryModePresent() { throw null; }
        public override bool IsExpirationPresent() { throw null; }
        public override bool IsHeadersPresent() { throw null; }
        public override bool IsMessageIdPresent() { throw null; }
        public override bool IsPriorityPresent() { throw null; }
        public override bool IsReplyToPresent() { throw null; }
        public override bool IsTimestampPresent() { throw null; }
        public override bool IsTypePresent() { throw null; }
        public override bool IsUserIdPresent() { throw null; }
        public override void ReadPropertiesFrom(RabbitMQ.Client.Impl.ContentHeaderPropertyReader reader) { }
        public override void WritePropertiesTo(RabbitMQ.Client.Impl.ContentHeaderPropertyWriter writer) { }
    }
    public partial class Constants
    {
        public const int AccessRefused = 403;
        public const int ChannelError = 504;
        public const int CommandInvalid = 503;
        public const int ConnectionForced = 320;
        public const int ContentTooLarge = 311;
        public const int FrameBody = 3;
        public const int FrameEnd = 206;
        public const int FrameError = 501;
        public const int FrameHeader = 2;
        public const int FrameHeartbeat = 8;
        public const int FrameMethod = 1;
        public const int FrameMinSize = 4096;
        public const int FrameOobBody = 6;
        public const int FrameOobHeader = 5;
        public const int FrameOobMethod = 4;
        public const int FrameTrace = 7;
        public const int InternalError = 541;
        public const int InvalidPath = 402;
        public const int NotAllowed = 530;
        public const int NotDelivered = 310;
        public const int NotFound = 404;
        public const int NotImplemented = 540;
        public const int ReplySuccess = 200;
        public const int ResourceError = 506;
        public const int ResourceLocked = 405;
        public const int SyntaxError = 502;
        public Constants() { }
    }
    public partial class FileProperties : RabbitMQ.Client.Impl.FileProperties
    {
        public FileProperties() { }
        public override string ClusterId { get { throw null; } set { } }
        public override string ContentEncoding { get { throw null; } set { } }
        public override string ContentType { get { throw null; } set { } }
        public override string Filename { get { throw null; } set { } }
        public override System.Collections.IDictionary Headers { get { throw null; } set { } }
        public override string MessageId { get { throw null; } set { } }
        public override byte Priority { get { throw null; } set { } }
        public override int ProtocolClassId { get { throw null; } }
        public override string ProtocolClassName { get { throw null; } }
        public override string ReplyTo { get { throw null; } set { } }
        public override RabbitMQ.Client.AmqpTimestamp Timestamp { get { throw null; } set { } }
        public override void AppendPropertyDebugStringTo(System.Text.StringBuilder sb) { }
        public override void ClearClusterId() { }
        public override void ClearContentEncoding() { }
        public override void ClearContentType() { }
        public override void ClearFilename() { }
        public override void ClearHeaders() { }
        public override void ClearMessageId() { }
        public override void ClearPriority() { }
        public override void ClearReplyTo() { }
        public override void ClearTimestamp() { }
        public override bool IsClusterIdPresent() { throw null; }
        public override bool IsContentEncodingPresent() { throw null; }
        public override bool IsContentTypePresent() { throw null; }
        public override bool IsFilenamePresent() { throw null; }
        public override bool IsHeadersPresent() { throw null; }
        public override bool IsMessageIdPresent() { throw null; }
        public override bool IsPriorityPresent() { throw null; }
        public override bool IsReplyToPresent() { throw null; }
        public override bool IsTimestampPresent() { throw null; }
        public override void ReadPropertiesFrom(RabbitMQ.Client.Impl.ContentHeaderPropertyReader reader) { }
        public override void WritePropertiesTo(RabbitMQ.Client.Impl.ContentHeaderPropertyWriter writer) { }
    }
    public partial interface IAccessRequest : RabbitMQ.Client.IMethod
    {
        bool Active { get; }
        bool Exclusive { get; }
        bool Passive { get; }
        bool Read { get; }
        string Realm { get; }
        bool Write { get; }
    }
    public partial interface IAccessRequestOk : RabbitMQ.Client.IMethod
    {
        ushort Ticket { get; }
    }
    public partial interface IBasicAck : RabbitMQ.Client.IMethod
    {
        ulong DeliveryTag { get; }
        bool Multiple { get; }
    }
    public partial interface IBasicCancel : RabbitMQ.Client.IMethod
    {
        string ConsumerTag { get; }
        bool Nowait { get; }
    }
    public partial interface IBasicCancelOk : RabbitMQ.Client.IMethod
    {
        string ConsumerTag { get; }
    }
    public partial interface IBasicConsume : RabbitMQ.Client.IMethod
    {
        System.Collections.IDictionary Arguments { get; }
        string ConsumerTag { get; }
        bool Exclusive { get; }
        bool NoAck { get; }
        bool NoLocal { get; }
        bool Nowait { get; }
        string Queue { get; }
        ushort Ticket { get; }
    }
    public partial interface IBasicConsumeOk : RabbitMQ.Client.IMethod
    {
        string ConsumerTag { get; }
    }
    public partial interface IBasicDeliver : RabbitMQ.Client.IMethod
    {
        string ConsumerTag { get; }
        ulong DeliveryTag { get; }
        string Exchange { get; }
        bool Redelivered { get; }
        string RoutingKey { get; }
    }
    public partial interface IBasicGet : RabbitMQ.Client.IMethod
    {
        bool NoAck { get; }
        string Queue { get; }
        ushort Ticket { get; }
    }
    public partial interface IBasicGetEmpty : RabbitMQ.Client.IMethod
    {
        string ClusterId { get; }
    }
    public partial interface IBasicGetOk : RabbitMQ.Client.IMethod
    {
        ulong DeliveryTag { get; }
        string Exchange { get; }
        uint MessageCount { get; }
        bool Redelivered { get; }
        string RoutingKey { get; }
    }
    public partial interface IBasicPublish : RabbitMQ.Client.IMethod
    {
        string Exchange { get; }
        bool Immediate { get; }
        bool Mandatory { get; }
        string RoutingKey { get; }
        ushort Ticket { get; }
    }
    public partial interface IBasicQos : RabbitMQ.Client.IMethod
    {
        bool Global { get; }
        ushort PrefetchCount { get; }
        uint PrefetchSize { get; }
    }
    public partial interface IBasicQosOk : RabbitMQ.Client.IMethod
    {
    }
    public partial interface IBasicRecover : RabbitMQ.Client.IMethod
    {
        bool Requeue { get; }
    }
    public partial interface IBasicRecoverOk : RabbitMQ.Client.IMethod
    {
    }
    public partial interface IBasicReject : RabbitMQ.Client.IMethod
    {
        ulong DeliveryTag { get; }
        bool Requeue { get; }
    }
    public partial interface IBasicReturn : RabbitMQ.Client.IMethod
    {
        string Exchange { get; }
        ushort ReplyCode { get; }
        string ReplyText { get; }
        string RoutingKey { get; }
    }
    public partial interface IChannelAlert : RabbitMQ.Client.IMethod
    {
        System.Collections.IDictionary Details { get; }
        ushort ReplyCode { get; }
        string ReplyText { get; }
    }
    public partial interface IChannelClose : RabbitMQ.Client.IMethod
    {
        ushort ClassId { get; }
        ushort MethodId { get; }
        ushort ReplyCode { get; }
        string ReplyText { get; }
    }
    public partial interface IChannelCloseOk : RabbitMQ.Client.IMethod
    {
    }
    public partial interface IChannelFlow : RabbitMQ.Client.IMethod
    {
        bool Active { get; }
    }
    public partial interface IChannelFlowOk : RabbitMQ.Client.IMethod
    {
        bool Active { get; }
    }
    public partial interface IChannelOpen : RabbitMQ.Client.IMethod
    {
        string OutOfBand { get; }
    }
    public partial interface IChannelOpenOk : RabbitMQ.Client.IMethod
    {
    }
    public partial interface IConnectionClose : RabbitMQ.Client.IMethod
    {
        ushort ClassId { get; }
        ushort MethodId { get; }
        ushort ReplyCode { get; }
        string ReplyText { get; }
    }
    public partial interface IConnectionCloseOk : RabbitMQ.Client.IMethod
    {
    }
    public partial interface IConnectionOpen : RabbitMQ.Client.IMethod
    {
        string Capabilities { get; }
        bool Insist { get; }
        string VirtualHost { get; }
    }
    public partial interface IConnectionOpenOk : RabbitMQ.Client.IMethod
    {
        string KnownHosts { get; }
    }
    public partial interface IConnectionRedirect : RabbitMQ.Client.IMethod
    {
        string Host { get; }
        string KnownHosts { get; }
    }
    public partial interface IConnectionSecure : RabbitMQ.Client.IMethod
    {
        byte[] Challenge { get; }
    }
    public partial interface IConnectionSecureOk : RabbitMQ.Client.IMethod
    {
        byte[] Response { get; }
    }
    public partial interface IConnectionStart : RabbitMQ.Client.IMethod
    {
        byte[] Locales { get; }
        byte[] Mechanisms { get; }
        System.Collections.IDictionary ServerProperties { get; }
        byte VersionMajor { get; }
        byte VersionMinor { get; }
    }
    public partial interface IConnectionStartOk : RabbitMQ.Client.IMethod
    {
        System.Collections.IDictionary ClientProperties { get; }
        string Locale { get; }
        string Mechanism { get; }
        byte[] Response { get; }
    }
    public partial interface IConnectionTune : RabbitMQ.Client.IMethod
    {
        ushort ChannelMax { get; }
        uint FrameMax { get; }
        ushort Heartbeat { get; }
    }
    public partial interface IConnectionTuneOk : RabbitMQ.Client.IMethod
    {
        ushort ChannelMax { get; }
        uint FrameMax { get; }
        ushort Heartbeat { get; }
    }
    public partial interface IDtxSelect : RabbitMQ.Client.IMethod
    {
    }
    public partial interface IDtxSelectOk : RabbitMQ.Client.IMethod
    {
    }
    public partial interface IDtxStart : RabbitMQ.Client.IMethod
    {
        string DtxIdentifier { get; }
    }
    public partial interface IDtxStartOk : RabbitMQ.Client.IMethod
    {
    }
    public partial interface IExchangeBound : RabbitMQ.Client.IMethod
    {
        string Exchange { get; }
        string Queue { get; }
        string RoutingKey { get; }
    }
    public partial interface IExchangeBoundOk : RabbitMQ.Client.IMethod
    {
        ushort ReplyCode { get; }
        string ReplyText { get; }
    }
    public partial interface IExchangeDeclare : RabbitMQ.Client.IMethod
    {
        System.Collections.IDictionary Arguments { get; }
        bool AutoDelete { get; }
        bool Durable { get; }
        string Exchange { get; }
        bool Internal { get; }
        bool Nowait { get; }
        bool Passive { get; }
        ushort Ticket { get; }
        string Type { get; }
    }
    public partial interface IExchangeDeclareOk : RabbitMQ.Client.IMethod
    {
    }
    public partial interface IExchangeDelete : RabbitMQ.Client.IMethod
    {
        string Exchange { get; }
        bool IfUnused { get; }
        bool Nowait { get; }
        ushort Ticket { get; }
    }
    public partial interface IExchangeDeleteOk : RabbitMQ.Client.IMethod
    {
    }
    public partial interface IFileAck : RabbitMQ.Client.IMethod
    {
        ulong DeliveryTag { get; }
        bool Multiple { get; }
    }
    public partial interface IFileCancel : RabbitMQ.Client.IMethod
    {
        string ConsumerTag { get; }
        bool Nowait { get; }
    }
    public partial interface IFileCancelOk : RabbitMQ.Client.IMethod
    {
        string ConsumerTag { get; }
    }
    public partial interface IFileConsume : RabbitMQ.Client.IMethod
    {
        string ConsumerTag { get; }
        bool Exclusive { get; }
        bool NoAck { get; }
        bool NoLocal { get; }
        bool Nowait { get; }
        string Queue { get; }
        ushort Ticket { get; }
    }
    public partial interface IFileConsumeOk : RabbitMQ.Client.IMethod
    {
        string ConsumerTag { get; }
    }
    public partial interface IFileDeliver : RabbitMQ.Client.IMethod
    {
        string ConsumerTag { get; }
        ulong DeliveryTag { get; }
        string Exchange { get; }
        string Identifier { get; }
        bool Redelivered { get; }
        string RoutingKey { get; }
    }
    public partial interface IFileOpen : RabbitMQ.Client.IMethod
    {
        ulong ContentSize { get; }
        string Identifier { get; }
    }
    public partial interface IFileOpenOk : RabbitMQ.Client.IMethod
    {
        ulong StagedSize { get; }
    }
    public partial interface IFilePublish : RabbitMQ.Client.IMethod
    {
        string Exchange { get; }
        string Identifier { get; }
        bool Immediate { get; }
        bool Mandatory { get; }
        string RoutingKey { get; }
        ushort Ticket { get; }
    }
    public partial interface IFileQos : RabbitMQ.Client.IMethod
    {
        bool Global { get; }
        ushort PrefetchCount { get; }
        uint PrefetchSize { get; }
    }
    public partial interface IFileQosOk : RabbitMQ.Client.IMethod
    {
    }
    public partial interface IFileReject : RabbitMQ.Client.IMethod
    {
        ulong DeliveryTag { get; }
        bool Requeue { get; }
    }
    public partial interface IFileReturn : RabbitMQ.Client.IMethod
    {
        string Exchange { get; }
        ushort ReplyCode { get; }
        string ReplyText { get; }
        string RoutingKey { get; }
    }
    public partial interface IFileStage : RabbitMQ.Client.IMethod
    {
    }
    public partial interface IQueueBind : RabbitMQ.Client.IMethod
    {
        System.Collections.IDictionary Arguments { get; }
        string Exchange { get; }
        bool Nowait { get; }
        string Queue { get; }
        string RoutingKey { get; }
        ushort Ticket { get; }
    }
    public partial interface IQueueBindOk : RabbitMQ.Client.IMethod
    {
    }
    public partial interface IQueueDeclare : RabbitMQ.Client.IMethod
    {
        System.Collections.IDictionary Arguments { get; }
        bool AutoDelete { get; }
        bool Durable { get; }
        bool Exclusive { get; }
        bool Nowait { get; }
        bool Passive { get; }
        string Queue { get; }
        ushort Ticket { get; }
    }
    public partial interface IQueueDeclareOk : RabbitMQ.Client.IMethod
    {
        uint ConsumerCount { get; }
        uint MessageCount { get; }
        string Queue { get; }
    }
    public partial interface IQueueDelete : RabbitMQ.Client.IMethod
    {
        bool IfEmpty { get; }
        bool IfUnused { get; }
        bool Nowait { get; }
        string Queue { get; }
        ushort Ticket { get; }
    }
    public partial interface IQueueDeleteOk : RabbitMQ.Client.IMethod
    {
        uint MessageCount { get; }
    }
    public partial interface IQueuePurge : RabbitMQ.Client.IMethod
    {
        bool Nowait { get; }
        string Queue { get; }
        ushort Ticket { get; }
    }
    public partial interface IQueuePurgeOk : RabbitMQ.Client.IMethod
    {
        uint MessageCount { get; }
    }
    public partial interface IStreamCancel : RabbitMQ.Client.IMethod
    {
        string ConsumerTag { get; }
        bool Nowait { get; }
    }
    public partial interface IStreamCancelOk : RabbitMQ.Client.IMethod
    {
        string ConsumerTag { get; }
    }
    public partial interface IStreamConsume : RabbitMQ.Client.IMethod
    {
        string ConsumerTag { get; }
        bool Exclusive { get; }
        bool NoLocal { get; }
        bool Nowait { get; }
        string Queue { get; }
        ushort Ticket { get; }
    }
    public partial interface IStreamConsumeOk : RabbitMQ.Client.IMethod
    {
        string ConsumerTag { get; }
    }
    public partial interface IStreamDeliver : RabbitMQ.Client.IMethod
    {
        string ConsumerTag { get; }
        ulong DeliveryTag { get; }
        string Exchange { get; }
        string Queue { get; }
    }
    public partial interface IStreamPublish : RabbitMQ.Client.IMethod
    {
        string Exchange { get; }
        bool Immediate { get; }
        bool Mandatory { get; }
        string RoutingKey { get; }
        ushort Ticket { get; }
    }
    public partial interface IStreamQos : RabbitMQ.Client.IMethod
    {
        uint ConsumeRate { get; }
        bool Global { get; }
        ushort PrefetchCount { get; }
        uint PrefetchSize { get; }
    }
    public partial interface IStreamQosOk : RabbitMQ.Client.IMethod
    {
    }
    public partial interface IStreamReturn : RabbitMQ.Client.IMethod
    {
        string Exchange { get; }
        ushort ReplyCode { get; }
        string ReplyText { get; }
        string RoutingKey { get; }
    }
    public partial interface ITestContent : RabbitMQ.Client.IMethod
    {
    }
    public partial interface ITestContentOk : RabbitMQ.Client.IMethod
    {
        uint ContentChecksum { get; }
    }
    public partial interface ITestInteger : RabbitMQ.Client.IMethod
    {
        byte Integer1 { get; }
        ushort Integer2 { get; }
        uint Integer3 { get; }
        ulong Integer4 { get; }
        byte Operation { get; }
    }
    public partial interface ITestIntegerOk : RabbitMQ.Client.IMethod
    {
        ulong Result { get; }
    }
    public partial interface ITestString : RabbitMQ.Client.IMethod
    {
        byte Operation { get; }
        string String1 { get; }
        byte[] String2 { get; }
    }
    public partial interface ITestStringOk : RabbitMQ.Client.IMethod
    {
        byte[] Result { get; }
    }
    public partial interface ITestTable : RabbitMQ.Client.IMethod
    {
        byte IntegerOp { get; }
        byte StringOp { get; }
        System.Collections.IDictionary Table { get; }
    }
    public partial interface ITestTableOk : RabbitMQ.Client.IMethod
    {
        ulong IntegerResult { get; }
        byte[] StringResult { get; }
    }
    public partial interface ITunnelRequest : RabbitMQ.Client.IMethod
    {
        System.Collections.IDictionary MetaData { get; }
    }
    public partial interface ITxCommit : RabbitMQ.Client.IMethod
    {
    }
    public partial interface ITxCommitOk : RabbitMQ.Client.IMethod
    {
    }
    public partial interface ITxRollback : RabbitMQ.Client.IMethod
    {
    }
    public partial interface ITxRollbackOk : RabbitMQ.Client.IMethod
    {
    }
    public partial interface ITxSelect : RabbitMQ.Client.IMethod
    {
    }
    public partial interface ITxSelectOk : RabbitMQ.Client.IMethod
    {
    }
    public partial class Protocol : RabbitMQ.Client.Framing.Impl.v0_8qpid.ProtocolBase
    {
        public Protocol() { }
        public override string ApiName { get { throw null; } }
        public override int DefaultPort { get { throw null; } }
        public override int MajorVersion { get { throw null; } }
        public override int MinorVersion { get { throw null; } }
        public override RabbitMQ.Client.Impl.ContentHeaderBase DecodeContentHeaderFrom(RabbitMQ.Util.NetworkBinaryReader reader) { throw null; }
        public override RabbitMQ.Client.Impl.MethodBase DecodeMethodFrom(RabbitMQ.Util.NetworkBinaryReader reader) { throw null; }
    }
    public partial class StreamProperties : RabbitMQ.Client.Impl.StreamProperties
    {
        public StreamProperties() { }
        public override string ContentEncoding { get { throw null; } set { } }
        public override string ContentType { get { throw null; } set { } }
        public override System.Collections.IDictionary Headers { get { throw null; } set { } }
        public override byte Priority { get { throw null; } set { } }
        public override int ProtocolClassId { get { throw null; } }
        public override string ProtocolClassName { get { throw null; } }
        public override RabbitMQ.Client.AmqpTimestamp Timestamp { get { throw null; } set { } }
        public override void AppendPropertyDebugStringTo(System.Text.StringBuilder sb) { }
        public override void ClearContentEncoding() { }
        public override void ClearContentType() { }
        public override void ClearHeaders() { }
        public override void ClearPriority() { }
        public override void ClearTimestamp() { }
        public override bool IsContentEncodingPresent() { throw null; }
        public override bool IsContentTypePresent() { throw null; }
        public override bool IsHeadersPresent() { throw null; }
        public override bool IsPriorityPresent() { throw null; }
        public override bool IsTimestampPresent() { throw null; }
        public override void ReadPropertiesFrom(RabbitMQ.Client.Impl.ContentHeaderPropertyReader reader) { }
        public override void WritePropertiesTo(RabbitMQ.Client.Impl.ContentHeaderPropertyWriter writer) { }
    }
    public partial class TestProperties : RabbitMQ.Client.Impl.ContentHeaderBase
    {
        public TestProperties() { }
        public override int ProtocolClassId { get { throw null; } }
        public override string ProtocolClassName { get { throw null; } }
        public override void AppendPropertyDebugStringTo(System.Text.StringBuilder sb) { }
        public override void ReadPropertiesFrom(RabbitMQ.Client.Impl.ContentHeaderPropertyReader reader) { }
        public override void WritePropertiesTo(RabbitMQ.Client.Impl.ContentHeaderPropertyWriter writer) { }
    }
    public partial class TunnelProperties : RabbitMQ.Client.Impl.ContentHeaderBase
    {
        public TunnelProperties() { }
        public byte Broadcast { get { throw null; } set { } }
        public string DataName { get { throw null; } set { } }
        public byte Durable { get { throw null; } set { } }
        public System.Collections.IDictionary Headers { get { throw null; } set { } }
        public override int ProtocolClassId { get { throw null; } }
        public override string ProtocolClassName { get { throw null; } }
        public string ProxyName { get { throw null; } set { } }
        public override void AppendPropertyDebugStringTo(System.Text.StringBuilder sb) { }
        public void ClearBroadcast() { }
        public void ClearDataName() { }
        public void ClearDurable() { }
        public void ClearHeaders() { }
        public void ClearProxyName() { }
        public bool IsBroadcastPresent() { throw null; }
        public bool IsDataNamePresent() { throw null; }
        public bool IsDurablePresent() { throw null; }
        public bool IsHeadersPresent() { throw null; }
        public bool IsProxyNamePresent() { throw null; }
        public override void ReadPropertiesFrom(RabbitMQ.Client.Impl.ContentHeaderPropertyReader reader) { }
        public override void WritePropertiesTo(RabbitMQ.Client.Impl.ContentHeaderPropertyWriter writer) { }
    }
}
namespace RabbitMQ.Client.Framing.v0_9
{
    public partial class BasicProperties : RabbitMQ.Client.Impl.BasicProperties
    {
        public BasicProperties() { }
        public override string AppId { get { throw null; } set { } }
        public override string ClusterId { get { throw null; } set { } }
        public override string ContentEncoding { get { throw null; } set { } }
        public override string ContentType { get { throw null; } set { } }
        public override string CorrelationId { get { throw null; } set { } }
        public override byte DeliveryMode { get { throw null; } set { } }
        public override string Expiration { get { throw null; } set { } }
        public override System.Collections.IDictionary Headers { get { throw null; } set { } }
        public override string MessageId { get { throw null; } set { } }
        public override byte Priority { get { throw null; } set { } }
        public override int ProtocolClassId { get { throw null; } }
        public override string ProtocolClassName { get { throw null; } }
        public override string ReplyTo { get { throw null; } set { } }
        public override RabbitMQ.Client.AmqpTimestamp Timestamp { get { throw null; } set { } }
        public override string Type { get { throw null; } set { } }
        public override string UserId { get { throw null; } set { } }
        public override void AppendPropertyDebugStringTo(System.Text.StringBuilder sb) { }
        public override void ClearAppId() { }
        public override void ClearClusterId() { }
        public override void ClearContentEncoding() { }
        public override void ClearContentType() { }
        public override void ClearCorrelationId() { }
        public override void ClearDeliveryMode() { }
        public override void ClearExpiration() { }
        public override void ClearHeaders() { }
        public override void ClearMessageId() { }
        public override void ClearPriority() { }
        public override void ClearReplyTo() { }
        public override void ClearTimestamp() { }
        public override void ClearType() { }
        public override void ClearUserId() { }
        public override bool IsAppIdPresent() { throw null; }
        public override bool IsClusterIdPresent() { throw null; }
        public override bool IsContentEncodingPresent() { throw null; }
        public override bool IsContentTypePresent() { throw null; }
        public override bool IsCorrelationIdPresent() { throw null; }
        public override bool IsDeliveryModePresent() { throw null; }
        public override bool IsExpirationPresent() { throw null; }
        public override bool IsHeadersPresent() { throw null; }
        public override bool IsMessageIdPresent() { throw null; }
        public override bool IsPriorityPresent() { throw null; }
        public override bool IsReplyToPresent() { throw null; }
        public override bool IsTimestampPresent() { throw null; }
        public override bool IsTypePresent() { throw null; }
        public override bool IsUserIdPresent() { throw null; }
        public override void ReadPropertiesFrom(RabbitMQ.Client.Impl.ContentHeaderPropertyReader reader) { }
        public override void WritePropertiesTo(RabbitMQ.Client.Impl.ContentHeaderPropertyWriter writer) { }
    }
    public partial class Constants
    {
        public const int AccessRefused = 403;
        public const int ChannelError = 504;
        public const int CommandInvalid = 503;
        public const int ConnectionForced = 320;
        public const int ContentTooLarge = 311;
        public const int FrameBody = 3;
        public const int FrameEnd = 206;
        public const int FrameError = 501;
        public const int FrameHeader = 2;
        public const int FrameHeartbeat = 8;
        public const int FrameMethod = 1;
        public const int FrameMinSize = 4096;
        public const int FrameOobBody = 6;
        public const int FrameOobHeader = 5;
        public const int FrameOobMethod = 4;
        public const int FrameTrace = 7;
        public const int InternalError = 541;
        public const int InvalidPath = 402;
        public const int NoConsumers = 313;
        public const int NoRoute = 312;
        public const int NotAllowed = 530;
        public const int NotDelivered = 310;
        public const int NotFound = 404;
        public const int NotImplemented = 540;
        public const int PreconditionFailed = 406;
        public const int ReplySuccess = 200;
        public const int ResourceError = 506;
        public const int ResourceLocked = 405;
        public const int SyntaxError = 502;
        public Constants() { }
    }
    public partial class FileProperties : RabbitMQ.Client.Impl.FileProperties
    {
        public FileProperties() { }
        public override string ClusterId { get { throw null; } set { } }
        public override string ContentEncoding { get { throw null; } set { } }
        public override string ContentType { get { throw null; } set { } }
        public override string Filename { get { throw null; } set { } }
        public override System.Collections.IDictionary Headers { get { throw null; } set { } }
        public override string MessageId { get { throw null; } set { } }
        public override byte Priority { get { throw null; } set { } }
        public override int ProtocolClassId { get { throw null; } }
        public override string ProtocolClassName { get { throw null; } }
        public override string ReplyTo { get { throw null; } set { } }
        public override RabbitMQ.Client.AmqpTimestamp Timestamp { get { throw null; } set { } }
        public override void AppendPropertyDebugStringTo(System.Text.StringBuilder sb) { }
        public override void ClearClusterId() { }
        public override void ClearContentEncoding() { }
        public override void ClearContentType() { }
        public override void ClearFilename() { }
        public override void ClearHeaders() { }
        public override void ClearMessageId() { }
        public override void ClearPriority() { }
        public override void ClearReplyTo() { }
        public override void ClearTimestamp() { }
        public override bool IsClusterIdPresent() { throw null; }
        public override bool IsContentEncodingPresent() { throw null; }
        public override bool IsContentTypePresent() { throw null; }
        public override bool IsFilenamePresent() { throw null; }
        public override bool IsHeadersPresent() { throw null; }
        public override bool IsMessageIdPresent() { throw null; }
        public override bool IsPriorityPresent() { throw null; }
        public override bool IsReplyToPresent() { throw null; }
        public override bool IsTimestampPresent() { throw null; }
        public override void ReadPropertiesFrom(RabbitMQ.Client.Impl.ContentHeaderPropertyReader reader) { }
        public override void WritePropertiesTo(RabbitMQ.Client.Impl.ContentHeaderPropertyWriter writer) { }
    }
    public partial interface IAccessRequest : RabbitMQ.Client.IMethod
    {
        bool Active { get; }
        bool Exclusive { get; }
        bool Passive { get; }
        bool Read { get; }
        string Realm { get; }
        bool Write { get; }
    }
    public partial interface IAccessRequestOk : RabbitMQ.Client.IMethod
    {
        ushort Ticket { get; }
    }
    public partial interface IBasicAck : RabbitMQ.Client.IMethod
    {
        ulong DeliveryTag { get; }
        bool Multiple { get; }
    }
    public partial interface IBasicCancel : RabbitMQ.Client.IMethod
    {
        string ConsumerTag { get; }
        bool Nowait { get; }
    }
    public partial interface IBasicCancelOk : RabbitMQ.Client.IMethod
    {
        string ConsumerTag { get; }
    }
    public partial interface IBasicConsume : RabbitMQ.Client.IMethod
    {
        string ConsumerTag { get; }
        bool Exclusive { get; }
        System.Collections.IDictionary Filter { get; }
        bool NoAck { get; }
        bool NoLocal { get; }
        bool Nowait { get; }
        string Queue { get; }
        ushort Ticket { get; }
    }
    public partial interface IBasicConsumeOk : RabbitMQ.Client.IMethod
    {
        string ConsumerTag { get; }
    }
    public partial interface IBasicDeliver : RabbitMQ.Client.IMethod
    {
        string ConsumerTag { get; }
        ulong DeliveryTag { get; }
        string Exchange { get; }
        bool Redelivered { get; }
        string RoutingKey { get; }
    }
    public partial interface IBasicGet : RabbitMQ.Client.IMethod
    {
        bool NoAck { get; }
        string Queue { get; }
        ushort Ticket { get; }
    }
    public partial interface IBasicGetEmpty : RabbitMQ.Client.IMethod
    {
        string ClusterId { get; }
    }
    public partial interface IBasicGetOk : RabbitMQ.Client.IMethod
    {
        ulong DeliveryTag { get; }
        string Exchange { get; }
        uint MessageCount { get; }
        bool Redelivered { get; }
        string RoutingKey { get; }
    }
    public partial interface IBasicPublish : RabbitMQ.Client.IMethod
    {
        string Exchange { get; }
        bool Immediate { get; }
        bool Mandatory { get; }
        string RoutingKey { get; }
        ushort Ticket { get; }
    }
    public partial interface IBasicQos : RabbitMQ.Client.IMethod
    {
        bool Global { get; }
        ushort PrefetchCount { get; }
        uint PrefetchSize { get; }
    }
    public partial interface IBasicQosOk : RabbitMQ.Client.IMethod
    {
    }
    public partial interface IBasicRecover : RabbitMQ.Client.IMethod
    {
        bool Requeue { get; }
    }
    public partial interface IBasicReject : RabbitMQ.Client.IMethod
    {
        ulong DeliveryTag { get; }
        bool Requeue { get; }
    }
    public partial interface IBasicReturn : RabbitMQ.Client.IMethod
    {
        string Exchange { get; }
        ushort ReplyCode { get; }
        string ReplyText { get; }
        string RoutingKey { get; }
    }
    public partial interface IChannelClose : RabbitMQ.Client.IMethod
    {
        ushort ClassId { get; }
        ushort MethodId { get; }
        ushort ReplyCode { get; }
        string ReplyText { get; }
    }
    public partial interface IChannelCloseOk : RabbitMQ.Client.IMethod
    {
    }
    public partial interface IChannelFlow : RabbitMQ.Client.IMethod
    {
        bool Active { get; }
    }
    public partial interface IChannelFlowOk : RabbitMQ.Client.IMethod
    {
        bool Active { get; }
    }
    public partial interface IChannelOk : RabbitMQ.Client.IMethod
    {
    }
    public partial interface IChannelOpen : RabbitMQ.Client.IMethod
    {
        string OutOfBand { get; }
    }
    public partial interface IChannelOpenOk : RabbitMQ.Client.IMethod
    {
        byte[] ChannelId { get; }
    }
    public partial interface IChannelPing : RabbitMQ.Client.IMethod
    {
    }
    public partial interface IChannelPong : RabbitMQ.Client.IMethod
    {
    }
    public partial interface IChannelResume : RabbitMQ.Client.IMethod
    {
        byte[] ChannelId { get; }
    }
    public partial interface IConnectionClose : RabbitMQ.Client.IMethod
    {
        ushort ClassId { get; }
        ushort MethodId { get; }
        ushort ReplyCode { get; }
        string ReplyText { get; }
    }
    public partial interface IConnectionCloseOk : RabbitMQ.Client.IMethod
    {
    }
    public partial interface IConnectionOpen : RabbitMQ.Client.IMethod
    {
        string Capabilities { get; }
        bool Insist { get; }
        string VirtualHost { get; }
    }
    public partial interface IConnectionOpenOk : RabbitMQ.Client.IMethod
    {
        string KnownHosts { get; }
    }
    public partial interface IConnectionRedirect : RabbitMQ.Client.IMethod
    {
        string Host { get; }
        string KnownHosts { get; }
    }
    public partial interface IConnectionSecure : RabbitMQ.Client.IMethod
    {
        byte[] Challenge { get; }
    }
    public partial interface IConnectionSecureOk : RabbitMQ.Client.IMethod
    {
        byte[] Response { get; }
    }
    public partial interface IConnectionStart : RabbitMQ.Client.IMethod
    {
        byte[] Locales { get; }
        byte[] Mechanisms { get; }
        System.Collections.IDictionary ServerProperties { get; }
        byte VersionMajor { get; }
        byte VersionMinor { get; }
    }
    public partial interface IConnectionStartOk : RabbitMQ.Client.IMethod
    {
        System.Collections.IDictionary ClientProperties { get; }
        string Locale { get; }
        string Mechanism { get; }
        byte[] Response { get; }
    }
    public partial interface IConnectionTune : RabbitMQ.Client.IMethod
    {
        ushort ChannelMax { get; }
        uint FrameMax { get; }
        ushort Heartbeat { get; }
    }
    public partial interface IConnectionTuneOk : RabbitMQ.Client.IMethod
    {
        ushort ChannelMax { get; }
        uint FrameMax { get; }
        ushort Heartbeat { get; }
    }
    public partial interface IDtxSelect : RabbitMQ.Client.IMethod
    {
    }
    public partial interface IDtxSelectOk : RabbitMQ.Client.IMethod
    {
    }
    public partial interface IDtxStart : RabbitMQ.Client.IMethod
    {
        string DtxIdentifier { get; }
    }
    public partial interface IDtxStartOk : RabbitMQ.Client.IMethod
    {
    }
    public partial interface IExchangeDeclare : RabbitMQ.Client.IMethod
    {
        System.Collections.IDictionary Arguments { get; }
        bool AutoDelete { get; }
        bool Durable { get; }
        string Exchange { get; }
        bool Internal { get; }
        bool Nowait { get; }
        bool Passive { get; }
        ushort Ticket { get; }
        string Type { get; }
    }
    public partial interface IExchangeDeclareOk : RabbitMQ.Client.IMethod
    {
    }
    public partial interface IExchangeDelete : RabbitMQ.Client.IMethod
    {
        string Exchange { get; }
        bool IfUnused { get; }
        bool Nowait { get; }
        ushort Ticket { get; }
    }
    public partial interface IExchangeDeleteOk : RabbitMQ.Client.IMethod
    {
    }
    public partial interface IFileAck : RabbitMQ.Client.IMethod
    {
        ulong DeliveryTag { get; }
        bool Multiple { get; }
    }
    public partial interface IFileCancel : RabbitMQ.Client.IMethod
    {
        string ConsumerTag { get; }
        bool Nowait { get; }
    }
    public partial interface IFileCancelOk : RabbitMQ.Client.IMethod
    {
        string ConsumerTag { get; }
    }
    public partial interface IFileConsume : RabbitMQ.Client.IMethod
    {
        string ConsumerTag { get; }
        bool Exclusive { get; }
        System.Collections.IDictionary Filter { get; }
        bool NoAck { get; }
        bool NoLocal { get; }
        bool Nowait { get; }
        string Queue { get; }
        ushort Ticket { get; }
    }
    public partial interface IFileConsumeOk : RabbitMQ.Client.IMethod
    {
        string ConsumerTag { get; }
    }
    public partial interface IFileDeliver : RabbitMQ.Client.IMethod
    {
        string ConsumerTag { get; }
        ulong DeliveryTag { get; }
        string Exchange { get; }
        string Identifier { get; }
        bool Redelivered { get; }
        string RoutingKey { get; }
    }
    public partial interface IFileOpen : RabbitMQ.Client.IMethod
    {
        ulong ContentSize { get; }
        string Identifier { get; }
    }
    public partial interface IFileOpenOk : RabbitMQ.Client.IMethod
    {
        ulong StagedSize { get; }
    }
    public partial interface IFilePublish : RabbitMQ.Client.IMethod
    {
        string Exchange { get; }
        string Identifier { get; }
        bool Immediate { get; }
        bool Mandatory { get; }
        string RoutingKey { get; }
        ushort Ticket { get; }
    }
    public partial interface IFileQos : RabbitMQ.Client.IMethod
    {
        bool Global { get; }
        ushort PrefetchCount { get; }
        uint PrefetchSize { get; }
    }
    public partial interface IFileQosOk : RabbitMQ.Client.IMethod
    {
    }
    public partial interface IFileReject : RabbitMQ.Client.IMethod
    {
        ulong DeliveryTag { get; }
        bool Requeue { get; }
    }
    public partial interface IFileReturn : RabbitMQ.Client.IMethod
    {
        string Exchange { get; }
        ushort ReplyCode { get; }
        string ReplyText { get; }
        string RoutingKey { get; }
    }
    public partial interface IFileStage : RabbitMQ.Client.IMethod
    {
    }
    public partial interface IMessageAppend : RabbitMQ.Client.IMethod
    {
        byte[] Bytes { get; }
        byte[] Reference { get; }
    }
    public partial interface IMessageCancel : RabbitMQ.Client.IMethod
    {
        string Destination { get; }
    }
    public partial interface IMessageCheckpoint : RabbitMQ.Client.IMethod
    {
        string Identifier { get; }
        byte[] Reference { get; }
    }
    public partial interface IMessageClose : RabbitMQ.Client.IMethod
    {
        byte[] Reference { get; }
    }
    public partial interface IMessageConsume : RabbitMQ.Client.IMethod
    {
        string Destination { get; }
        bool Exclusive { get; }
        System.Collections.IDictionary Filter { get; }
        bool NoAck { get; }
        bool NoLocal { get; }
        string Queue { get; }
        ushort Ticket { get; }
    }
    public partial interface IMessageEmpty : RabbitMQ.Client.IMethod
    {
    }
    public partial interface IMessageGet : RabbitMQ.Client.IMethod
    {
        string Destination { get; }
        bool NoAck { get; }
        string Queue { get; }
        ushort Ticket { get; }
    }
    public partial interface IMessageOffset : RabbitMQ.Client.IMethod
    {
        ulong Value { get; }
    }
    public partial interface IMessageOk : RabbitMQ.Client.IMethod
    {
    }
    public partial interface IMessageOpen : RabbitMQ.Client.IMethod
    {
        byte[] Reference { get; }
    }
    public partial interface IMessageQos : RabbitMQ.Client.IMethod
    {
        bool Global { get; }
        ushort PrefetchCount { get; }
        uint PrefetchSize { get; }
    }
    public partial interface IMessageRecover : RabbitMQ.Client.IMethod
    {
        bool Requeue { get; }
    }
    public partial interface IMessageReject : RabbitMQ.Client.IMethod
    {
        ushort Code { get; }
        string Text { get; }
    }
    public partial interface IMessageResume : RabbitMQ.Client.IMethod
    {
        string Identifier { get; }
        byte[] Reference { get; }
    }
    public partial interface IMessageTransfer : RabbitMQ.Client.IMethod
    {
        string AppId { get; }
        System.Collections.IDictionary ApplicationHeaders { get; }
        byte[] Body { get; }
        string ContentEncoding { get; }
        string ContentType { get; }
        string CorrelationId { get; }
        byte DeliveryMode { get; }
        string Destination { get; }
        string Exchange { get; }
        RabbitMQ.Client.AmqpTimestamp Expiration { get; }
        bool Immediate { get; }
        string MessageId { get; }
        byte Priority { get; }
        bool Redelivered { get; }
        string ReplyTo { get; }
        string RoutingKey { get; }
        byte[] SecurityToken { get; }
        ushort Ticket { get; }
        RabbitMQ.Client.AmqpTimestamp Timestamp { get; }
        string TransactionId { get; }
        ulong Ttl { get; }
        string UserId { get; }
    }
    public partial interface IQueueBind : RabbitMQ.Client.IMethod
    {
        System.Collections.IDictionary Arguments { get; }
        string Exchange { get; }
        bool Nowait { get; }
        string Queue { get; }
        string RoutingKey { get; }
        ushort Ticket { get; }
    }
    public partial interface IQueueBindOk : RabbitMQ.Client.IMethod
    {
    }
    public partial interface IQueueDeclare : RabbitMQ.Client.IMethod
    {
        System.Collections.IDictionary Arguments { get; }
        bool AutoDelete { get; }
        bool Durable { get; }
        bool Exclusive { get; }
        bool Nowait { get; }
        bool Passive { get; }
        string Queue { get; }
        ushort Ticket { get; }
    }
    public partial interface IQueueDeclareOk : RabbitMQ.Client.IMethod
    {
        uint ConsumerCount { get; }
        uint MessageCount { get; }
        string Queue { get; }
    }
    public partial interface IQueueDelete : RabbitMQ.Client.IMethod
    {
        bool IfEmpty { get; }
        bool IfUnused { get; }
        bool Nowait { get; }
        string Queue { get; }
        ushort Ticket { get; }
    }
    public partial interface IQueueDeleteOk : RabbitMQ.Client.IMethod
    {
        uint MessageCount { get; }
    }
    public partial interface IQueuePurge : RabbitMQ.Client.IMethod
    {
        bool Nowait { get; }
        string Queue { get; }
        ushort Ticket { get; }
    }
    public partial interface IQueuePurgeOk : RabbitMQ.Client.IMethod
    {
        uint MessageCount { get; }
    }
    public partial interface IQueueUnbind : RabbitMQ.Client.IMethod
    {
        System.Collections.IDictionary Arguments { get; }
        string Exchange { get; }
        string Queue { get; }
        string RoutingKey { get; }
        ushort Ticket { get; }
    }
    public partial interface IQueueUnbindOk : RabbitMQ.Client.IMethod
    {
    }
    public partial interface IStreamCancel : RabbitMQ.Client.IMethod
    {
        string ConsumerTag { get; }
        bool Nowait { get; }
    }
    public partial interface IStreamCancelOk : RabbitMQ.Client.IMethod
    {
        string ConsumerTag { get; }
    }
    public partial interface IStreamConsume : RabbitMQ.Client.IMethod
    {
        string ConsumerTag { get; }
        bool Exclusive { get; }
        System.Collections.IDictionary Filter { get; }
        bool NoLocal { get; }
        bool Nowait { get; }
        string Queue { get; }
        ushort Ticket { get; }
    }
    public partial interface IStreamConsumeOk : RabbitMQ.Client.IMethod
    {
        string ConsumerTag { get; }
    }
    public partial interface IStreamDeliver : RabbitMQ.Client.IMethod
    {
        string ConsumerTag { get; }
        ulong DeliveryTag { get; }
        string Exchange { get; }
        string Queue { get; }
    }
    public partial interface IStreamPublish : RabbitMQ.Client.IMethod
    {
        string Exchange { get; }
        bool Immediate { get; }
        bool Mandatory { get; }
        string RoutingKey { get; }
        ushort Ticket { get; }
    }
    public partial interface IStreamQos : RabbitMQ.Client.IMethod
    {
        uint ConsumeRate { get; }
        bool Global { get; }
        ushort PrefetchCount { get; }
        uint PrefetchSize { get; }
    }
    public partial interface IStreamQosOk : RabbitMQ.Client.IMethod
    {
    }
    public partial interface IStreamReturn : RabbitMQ.Client.IMethod
    {
        string Exchange { get; }
        ushort ReplyCode { get; }
        string ReplyText { get; }
        string RoutingKey { get; }
    }
    public partial interface ITunnelRequest : RabbitMQ.Client.IMethod
    {
        System.Collections.IDictionary MetaData { get; }
    }
    public partial interface ITxCommit : RabbitMQ.Client.IMethod
    {
    }
    public partial interface ITxCommitOk : RabbitMQ.Client.IMethod
    {
    }
    public partial interface ITxRollback : RabbitMQ.Client.IMethod
    {
    }
    public partial interface ITxRollbackOk : RabbitMQ.Client.IMethod
    {
    }
    public partial interface ITxSelect : RabbitMQ.Client.IMethod
    {
    }
    public partial interface ITxSelectOk : RabbitMQ.Client.IMethod
    {
    }
    public partial class Protocol : RabbitMQ.Client.Framing.Impl.v0_9.ProtocolBase
    {
        public Protocol() { }
        public override string ApiName { get { throw null; } }
        public override int DefaultPort { get { throw null; } }
        public override int MajorVersion { get { throw null; } }
        public override int MinorVersion { get { throw null; } }
        public override RabbitMQ.Client.Impl.ContentHeaderBase DecodeContentHeaderFrom(RabbitMQ.Util.NetworkBinaryReader reader) { throw null; }
        public override RabbitMQ.Client.Impl.MethodBase DecodeMethodFrom(RabbitMQ.Util.NetworkBinaryReader reader) { throw null; }
    }
    public partial class StreamProperties : RabbitMQ.Client.Impl.StreamProperties
    {
        public StreamProperties() { }
        public override string ContentEncoding { get { throw null; } set { } }
        public override string ContentType { get { throw null; } set { } }
        public override System.Collections.IDictionary Headers { get { throw null; } set { } }
        public override byte Priority { get { throw null; } set { } }
        public override int ProtocolClassId { get { throw null; } }
        public override string ProtocolClassName { get { throw null; } }
        public override RabbitMQ.Client.AmqpTimestamp Timestamp { get { throw null; } set { } }
        public override void AppendPropertyDebugStringTo(System.Text.StringBuilder sb) { }
        public override void ClearContentEncoding() { }
        public override void ClearContentType() { }
        public override void ClearHeaders() { }
        public override void ClearPriority() { }
        public override void ClearTimestamp() { }
        public override bool IsContentEncodingPresent() { throw null; }
        public override bool IsContentTypePresent() { throw null; }
        public override bool IsHeadersPresent() { throw null; }
        public override bool IsPriorityPresent() { throw null; }
        public override bool IsTimestampPresent() { throw null; }
        public override void ReadPropertiesFrom(RabbitMQ.Client.Impl.ContentHeaderPropertyReader reader) { }
        public override void WritePropertiesTo(RabbitMQ.Client.Impl.ContentHeaderPropertyWriter writer) { }
    }
    public partial class TunnelProperties : RabbitMQ.Client.Impl.ContentHeaderBase
    {
        public TunnelProperties() { }
        public byte Broadcast { get { throw null; } set { } }
        public string DataName { get { throw null; } set { } }
        public byte Durable { get { throw null; } set { } }
        public System.Collections.IDictionary Headers { get { throw null; } set { } }
        public override int ProtocolClassId { get { throw null; } }
        public override string ProtocolClassName { get { throw null; } }
        public string ProxyName { get { throw null; } set { } }
        public override void AppendPropertyDebugStringTo(System.Text.StringBuilder sb) { }
        public void ClearBroadcast() { }
        public void ClearDataName() { }
        public void ClearDurable() { }
        public void ClearHeaders() { }
        public void ClearProxyName() { }
        public bool IsBroadcastPresent() { throw null; }
        public bool IsDataNamePresent() { throw null; }
        public bool IsDurablePresent() { throw null; }
        public bool IsHeadersPresent() { throw null; }
        public bool IsProxyNamePresent() { throw null; }
        public override void ReadPropertiesFrom(RabbitMQ.Client.Impl.ContentHeaderPropertyReader reader) { }
        public override void WritePropertiesTo(RabbitMQ.Client.Impl.ContentHeaderPropertyWriter writer) { }
    }
}
namespace RabbitMQ.Client.Impl
{
    public abstract partial class AbstractProtocolBase : RabbitMQ.Client.IProtocol
    {
        protected AbstractProtocolBase() { }
        public abstract string ApiName { get; }
        public abstract int DefaultPort { get; }
        public abstract int MajorVersion { get; }
        public abstract int MinorVersion { get; }
        public RabbitMQ.Client.AmqpVersion Version { get { throw null; } }
        public abstract bool CanSendWhileClosed(RabbitMQ.Client.Impl.Command cmd);
        public abstract void CreateChannelClose(ushort reasonCode, string reasonText, out RabbitMQ.Client.Impl.Command request, out int replyClassId, out int replyMethodId);
        public abstract RabbitMQ.Client.IConnection CreateConnection(RabbitMQ.Client.ConnectionFactory factory, bool insist, RabbitMQ.Client.Impl.IFrameHandler frameHandler);
        public abstract void CreateConnectionClose(ushort reasonCode, string reasonText, out RabbitMQ.Client.Impl.Command request, out int replyClassId, out int replyMethodId);
        public abstract RabbitMQ.Client.Impl.IFrameHandler CreateFrameHandler(RabbitMQ.Client.AmqpTcpEndpoint endpoint);
        public abstract RabbitMQ.Client.IModel CreateModel(RabbitMQ.Client.Impl.ISession session);
        public abstract RabbitMQ.Client.Impl.ContentHeaderBase DecodeContentHeaderFrom(RabbitMQ.Util.NetworkBinaryReader reader);
        public abstract RabbitMQ.Client.Impl.MethodBase DecodeMethodFrom(RabbitMQ.Util.NetworkBinaryReader reader);
        public override bool Equals(object obj) { throw null; }
        public override int GetHashCode() { throw null; }
        public override string ToString() { throw null; }
    }
    public enum AssemblyState
    {
        Complete = 3,
        ExpectingContentBody = 2,
        ExpectingContentHeader = 1,
        ExpectingMethod = 0,
    }
    public abstract partial class BasicProperties : RabbitMQ.Client.Impl.ContentHeaderBase, RabbitMQ.Client.IBasicProperties, RabbitMQ.Client.IContentHeader, System.ICloneable
    {
        protected BasicProperties() { }
        public abstract string AppId { get; set; }
        public abstract string ClusterId { get; set; }
        public abstract string ContentEncoding { get; set; }
        public abstract string ContentType { get; set; }
        public abstract string CorrelationId { get; set; }
        public abstract byte DeliveryMode { get; set; }
        public abstract string Expiration { get; set; }
        public abstract System.Collections.IDictionary Headers { get; set; }
        public abstract string MessageId { get; set; }
        public abstract byte Priority { get; set; }
        public abstract string ReplyTo { get; set; }
        public RabbitMQ.Client.PublicationAddress ReplyToAddress { get { throw null; } set { } }
        public abstract RabbitMQ.Client.AmqpTimestamp Timestamp { get; set; }
        public abstract string Type { get; set; }
        public abstract string UserId { get; set; }
        public abstract void ClearAppId();
        public abstract void ClearClusterId();
        public abstract void ClearContentEncoding();
        public abstract void ClearContentType();
        public abstract void ClearCorrelationId();
        public abstract void ClearDeliveryMode();
        public abstract void ClearExpiration();
        public abstract void ClearHeaders();
        public abstract void ClearMessageId();
        public abstract void ClearPriority();
        public abstract void ClearReplyTo();
        public abstract void ClearTimestamp();
        public abstract void ClearType();
        public abstract void ClearUserId();
        public override object Clone() { throw null; }
        public abstract bool IsAppIdPresent();
        public abstract bool IsClusterIdPresent();
        public abstract bool IsContentEncodingPresent();
        public abstract bool IsContentTypePresent();
        public abstract bool IsCorrelationIdPresent();
        public abstract bool IsDeliveryModePresent();
        public abstract bool IsExpirationPresent();
        public abstract bool IsHeadersPresent();
        public abstract bool IsMessageIdPresent();
        public abstract bool IsPriorityPresent();
        public abstract bool IsReplyToPresent();
        public abstract bool IsTimestampPresent();
        public abstract bool IsTypePresent();
        public abstract bool IsUserIdPresent();
        public void SetPersistent(bool persistent) { }
    }
    public partial class ChannelErrorException : RabbitMQ.Client.Impl.HardProtocolException
    {
        public ChannelErrorException(int channel) : base (default(string)) { }
        public int Channel { get { throw null; } }
        public override ushort ReplyCode { get { throw null; } }
    }
    public partial class Command
    {
        public const int EmptyContentBodyFrameSize = 8;
        public byte[] m_body0;
        public System.Collections.ArrayList m_bodyN;
        public RabbitMQ.Client.Impl.ContentHeaderBase m_header;
        public RabbitMQ.Client.Impl.MethodBase m_method;
        public Command() { }
        public Command(RabbitMQ.Client.Impl.MethodBase method) { }
        public Command(RabbitMQ.Client.Impl.MethodBase method, RabbitMQ.Client.Impl.ContentHeaderBase header, byte[] body) { }
        public byte[] Body { get { throw null; } }
        public RabbitMQ.Client.Impl.ContentHeaderBase Header { get { throw null; } }
        public RabbitMQ.Client.Impl.MethodBase Method { get { throw null; } }
        public void AppendBodyFragment(byte[] fragment) { }
        public static void CheckEmptyContentBodyFrameSize() { }
        public byte[] ConsolidateBody() { throw null; }
        public void Transmit(int channelNumber, RabbitMQ.Client.Impl.ConnectionBase connection) { }
    }
    public partial class CommandAssembler
    {
        public RabbitMQ.Client.Impl.Command m_command;
        public RabbitMQ.Client.Impl.AbstractProtocolBase m_protocol;
        public ulong m_remainingBodyBytes;
        public RabbitMQ.Client.Impl.AssemblyState m_state;
        public CommandAssembler(RabbitMQ.Client.Impl.AbstractProtocolBase protocol) { }
        public RabbitMQ.Client.Impl.Command HandleFrame(RabbitMQ.Client.Impl.Frame f) { throw null; }
    }
    public delegate void CommandHandler(RabbitMQ.Client.Impl.ISession session, RabbitMQ.Client.Impl.Command cmd);
    public abstract partial class ConnectionBase : RabbitMQ.Client.IConnection, System.IDisposable
    {
        public static int ConnectionCloseTimeout;
        public static int HandshakeTimeout;
        public System.Threading.ManualResetEvent m_appContinuation;
        public RabbitMQ.Client.Events.CallbackExceptionEventHandler m_callbackException;
        public System.Collections.IDictionary m_clientProperties;
        public volatile bool m_closed;
        public volatile RabbitMQ.Client.ShutdownEventArgs m_closeReason;
        public RabbitMQ.Client.Events.ConnectionShutdownEventHandler m_connectionShutdown;
        public readonly object m_eventLock;
        public RabbitMQ.Client.ConnectionFactory m_factory;
        public RabbitMQ.Client.Impl.IFrameHandler m_frameHandler;
        public uint m_frameMax;
        public ushort m_heartbeat;
        public readonly RabbitMQ.Client.Impl.Frame m_heartbeatFrame;
        public System.Threading.AutoResetEvent m_heartbeatRead;
        public System.Threading.AutoResetEvent m_heartbeatWrite;
        public System.Guid m_id;
        public RabbitMQ.Client.AmqpTcpEndpoint[] m_knownHosts;
        public int m_missedHeartbeats;
        public RabbitMQ.Client.Impl.ModelBase m_model0;
        public volatile bool m_running;
        public System.Collections.IDictionary m_serverProperties;
        public RabbitMQ.Client.Impl.MainSession m_session0;
        public RabbitMQ.Client.Impl.SessionManager m_sessionManager;
        public System.Collections.IList m_shutdownReport;
        public ConnectionBase(RabbitMQ.Client.ConnectionFactory factory, bool insist, RabbitMQ.Client.Impl.IFrameHandler frameHandler) { }
        public bool AutoClose { get { throw null; } set { } }
        public ushort ChannelMax { get { throw null; } }
        public System.Collections.IDictionary ClientProperties { get { throw null; } set { } }
        public RabbitMQ.Client.ShutdownEventArgs CloseReason { get { throw null; } }
        public RabbitMQ.Client.AmqpTcpEndpoint Endpoint { get { throw null; } }
        public uint FrameMax { get { throw null; } set { } }
        public ushort Heartbeat { get { throw null; } set { } }
        public bool IsOpen { get { throw null; } }
        public RabbitMQ.Client.AmqpTcpEndpoint[] KnownHosts { get { throw null; } set { } }
        public RabbitMQ.Client.Impl.AbstractProtocolBase Protocol { get { throw null; } }
        RabbitMQ.Client.IProtocol RabbitMQ.Client.IConnection.Protocol { get { throw null; } }
        public System.Collections.IDictionary ServerProperties { get { throw null; } set { } }
        public System.Collections.IList ShutdownReport { get { throw null; } }
        public event RabbitMQ.Client.Events.CallbackExceptionEventHandler CallbackException { add { } remove { } }
        public event RabbitMQ.Client.Events.ConnectionShutdownEventHandler ConnectionShutdown { add { } remove { } }
        public void Abort() { }
        public void Abort(int timeout) { }
        public void Abort(ushort reasonCode, string reasonText) { }
        public void Abort(ushort reasonCode, string reasonText, RabbitMQ.Client.ShutdownInitiator initiator, int timeout) { }
        public void Abort(ushort reasonCode, string reasonText, int timeout) { }
        public void Close() { }
        public void Close(RabbitMQ.Client.ShutdownEventArgs reason) { }
        public void Close(RabbitMQ.Client.ShutdownEventArgs reason, bool abort, int timeout) { }
        public void Close(int timeout) { }
        public void Close(ushort reasonCode, string reasonText) { }
        public void Close(ushort reasonCode, string reasonText, int timeout) { }
        public void ClosingLoop() { }
        public RabbitMQ.Client.Impl.Command ConnectionCloseWrapper(ushort reasonCode, string reasonText) { throw null; }
        public RabbitMQ.Client.IModel CreateModel() { throw null; }
        public RabbitMQ.Client.Impl.ISession CreateSession() { throw null; }
        public RabbitMQ.Client.Impl.ISession CreateSession(int channelNumber) { throw null; }
        public static System.Collections.IDictionary DefaultClientProperties() { throw null; }
        public void FinishClose() { }
        public void HandleDomainUnload(object sender, System.EventArgs ea) { }
        public void HandleMainLoopException(RabbitMQ.Client.ShutdownEventArgs reason) { }
        public bool HardProtocolExceptionHandler(RabbitMQ.Client.Impl.HardProtocolException hpe) { throw null; }
        public void HeartbeatReadLoop() { }
        public void HeartbeatWriteLoop() { }
        public void InternalClose(RabbitMQ.Client.ShutdownEventArgs reason) { }
        public void LogCloseError(string error, System.Exception ex) { }
        public void MainLoop() { }
        public void MainLoopIteration() { }
        public void NotifyHeartbeatThread() { }
        public void NotifyReceivedCloseOk() { }
        public void OnCallbackException(RabbitMQ.Client.Events.CallbackExceptionEventArgs args) { }
        public void OnShutdown() { }
        public void Open(bool insist) { }
        public void PrettyPrintShutdownReport() { }
        public void QuiesceChannel(RabbitMQ.Client.Impl.SoftProtocolException pe) { }
        public bool SetCloseReason(RabbitMQ.Client.ShutdownEventArgs reason) { throw null; }
        public void StartHeartbeatLoop(System.Threading.ThreadStart loop, string name) { }
        public void StartHeartbeatLoops() { }
        public void StartMainLoop() { }
        void System.IDisposable.Dispose() { }
        public void TerminateMainloop() { }
        public override string ToString() { throw null; }
        public void WriteFrame(RabbitMQ.Client.Impl.Frame f) { }
        public delegate void ConnectionCloseDelegate(ushort replyCode, string replyText, ushort classId, ushort methodId);
    }
    public partial class ConnectionStartDetails
    {
        public byte[] m_locales;
        public byte[] m_mechanisms;
        public System.Collections.IDictionary m_serverProperties;
        public byte m_versionMajor;
        public byte m_versionMinor;
        public ConnectionStartDetails() { }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public partial struct ConnectionTuneDetails
    {
        public ushort m_channelMax;
        public uint m_frameMax;
        public ushort m_heartbeat;
    }
    public abstract partial class ContentHeaderBase : RabbitMQ.Client.IContentHeader, System.ICloneable
    {
        protected ContentHeaderBase() { }
        public abstract int ProtocolClassId { get; }
        public abstract string ProtocolClassName { get; }
        public abstract void AppendPropertyDebugStringTo(System.Text.StringBuilder sb);
        public virtual object Clone() { throw null; }
        public ulong ReadFrom(RabbitMQ.Util.NetworkBinaryReader reader) { throw null; }
        public abstract void ReadPropertiesFrom(RabbitMQ.Client.Impl.ContentHeaderPropertyReader reader);
        public abstract void WritePropertiesTo(RabbitMQ.Client.Impl.ContentHeaderPropertyWriter writer);
        public void WriteTo(RabbitMQ.Util.NetworkBinaryWriter writer, ulong bodySize) { }
    }
    public partial class ContentHeaderPropertyReader
    {
        protected ushort m_bitCount;
        protected ushort m_flagWord;
        public ContentHeaderPropertyReader(RabbitMQ.Util.NetworkBinaryReader reader) { }
        public RabbitMQ.Util.NetworkBinaryReader BaseReader { get { throw null; } }
        public bool ContinuationBitSet { get { throw null; } }
        public void FinishPresence() { }
        public bool ReadBit() { throw null; }
        public void ReadFlagWord() { }
        public uint ReadLong() { throw null; }
        public ulong ReadLonglong() { throw null; }
        public byte[] ReadLongstr() { throw null; }
        public byte ReadOctet() { throw null; }
        public bool ReadPresence() { throw null; }
        public ushort ReadShort() { throw null; }
        public string ReadShortstr() { throw null; }
        public System.Collections.IDictionary ReadTable() { throw null; }
        public RabbitMQ.Client.AmqpTimestamp ReadTimestamp() { throw null; }
    }
    public partial class ContentHeaderPropertyWriter
    {
        protected int m_bitCount;
        protected ushort m_flagWord;
        public ContentHeaderPropertyWriter(RabbitMQ.Util.NetworkBinaryWriter writer) { }
        public RabbitMQ.Util.NetworkBinaryWriter BaseWriter { get { throw null; } }
        public void FinishPresence() { }
        public void WriteBit(bool bit) { }
        public void WriteLong(uint val) { }
        public void WriteLonglong(ulong val) { }
        public void WriteLongstr(byte[] val) { }
        public void WriteOctet(byte val) { }
        public void WritePresence(bool present) { }
        public void WriteShort(ushort val) { }
        public void WriteShortstr(string val) { }
        public void WriteTable(System.Collections.IDictionary val) { }
        public void WriteTimestamp(RabbitMQ.Client.AmqpTimestamp val) { }
    }
    public abstract partial class FileProperties : RabbitMQ.Client.Impl.ContentHeaderBase, RabbitMQ.Client.IContentHeader, RabbitMQ.Client.IFileProperties, System.ICloneable
    {
        protected FileProperties() { }
        public abstract string ClusterId { get; set; }
        public abstract string ContentEncoding { get; set; }
        public abstract string ContentType { get; set; }
        public abstract string Filename { get; set; }
        public abstract System.Collections.IDictionary Headers { get; set; }
        public abstract string MessageId { get; set; }
        public abstract byte Priority { get; set; }
        public abstract string ReplyTo { get; set; }
        public abstract RabbitMQ.Client.AmqpTimestamp Timestamp { get; set; }
        public abstract void ClearClusterId();
        public abstract void ClearContentEncoding();
        public abstract void ClearContentType();
        public abstract void ClearFilename();
        public abstract void ClearHeaders();
        public abstract void ClearMessageId();
        public abstract void ClearPriority();
        public abstract void ClearReplyTo();
        public abstract void ClearTimestamp();
        public override object Clone() { throw null; }
        public abstract bool IsClusterIdPresent();
        public abstract bool IsContentEncodingPresent();
        public abstract bool IsContentTypePresent();
        public abstract bool IsFilenamePresent();
        public abstract bool IsHeadersPresent();
        public abstract bool IsMessageIdPresent();
        public abstract bool IsPriorityPresent();
        public abstract bool IsReplyToPresent();
        public abstract bool IsTimestampPresent();
    }
    public partial class Frame
    {
        public System.IO.MemoryStream m_accumulator;
        public int m_channel;
        public byte[] m_payload;
        public int m_type;
        public Frame() { }
        public Frame(int type, int channel) { }
        public Frame(int type, int channel, byte[] payload) { }
        public int Channel { get { throw null; } }
        public byte[] Payload { get { throw null; } }
        public int Type { get { throw null; } }
        public void FinishWriting() { }
        public RabbitMQ.Util.NetworkBinaryReader GetReader() { throw null; }
        public RabbitMQ.Util.NetworkBinaryWriter GetWriter() { throw null; }
        public static void ProcessProtocolHeader(RabbitMQ.Util.NetworkBinaryReader reader) { }
        public static RabbitMQ.Client.Impl.Frame ReadFrom(RabbitMQ.Util.NetworkBinaryReader reader) { throw null; }
        public override string ToString() { throw null; }
        public void WriteTo(RabbitMQ.Util.NetworkBinaryWriter writer) { }
    }
    public abstract partial class HardProtocolException : RabbitMQ.Client.Impl.ProtocolException
    {
        protected HardProtocolException(string message) : base (default(string)) { }
    }
    public partial interface IFrameHandler
    {
        RabbitMQ.Client.AmqpTcpEndpoint Endpoint { get; }
        int Timeout { get; set; }
        void Close();
        RabbitMQ.Client.Impl.Frame ReadFrame();
        void SendHeader();
        void WriteFrame(RabbitMQ.Client.Impl.Frame frame);
    }
    public partial interface IFullModel : RabbitMQ.Client.IModel, System.IDisposable
    {
        [RabbitMQ.Client.Apigen.Attributes.AmqpMethodMappingAttribute(null, "connection", "tune")]RabbitMQ.Client.Impl.ConnectionTuneDetails ConnectionStartOk(System.Collections.IDictionary clientProperties, string mechanism, byte[] response, string locale);
        void ConnectionTuneOk(ushort channelMax, uint frameMax, ushort heartbeat);
        void HandleBasicCancelOk(string consumerTag);
        void HandleBasicConsumeOk(string consumerTag);
        void HandleBasicDeliver(string consumerTag, ulong deliveryTag, bool redelivered, string exchange, string routingKey, [RabbitMQ.Client.Apigen.Attributes.AmqpContentHeaderMappingAttribute]RabbitMQ.Client.IBasicProperties basicProperties, [RabbitMQ.Client.Apigen.Attributes.AmqpContentBodyMappingAttribute]byte[] body);
        void HandleBasicGetEmpty();
        void HandleBasicGetOk(ulong deliveryTag, bool redelivered, string exchange, string routingKey, uint messageCount, [RabbitMQ.Client.Apigen.Attributes.AmqpContentHeaderMappingAttribute]RabbitMQ.Client.IBasicProperties basicProperties, [RabbitMQ.Client.Apigen.Attributes.AmqpContentBodyMappingAttribute]byte[] body);
        void HandleBasicReturn(ushort replyCode, string replyText, string exchange, string routingKey, [RabbitMQ.Client.Apigen.Attributes.AmqpContentHeaderMappingAttribute]RabbitMQ.Client.IBasicProperties basicProperties, [RabbitMQ.Client.Apigen.Attributes.AmqpContentBodyMappingAttribute]byte[] body);
        void HandleChannelClose(ushort replyCode, string replyText, ushort classId, ushort methodId);
        void HandleChannelCloseOk();
        void HandleChannelFlow(bool active);
        void HandleConnectionClose(ushort replyCode, string replyText, ushort classId, ushort methodId);
        void HandleConnectionOpenOk(string knownHosts);
        void HandleConnectionRedirect(string host, string knownHosts);
        void HandleConnectionStart(byte versionMajor, byte versionMinor, System.Collections.IDictionary serverProperties, byte[] mechanisms, byte[] locales);
        [RabbitMQ.Client.Apigen.Attributes.AmqpForceOneWayAttribute]
        [RabbitMQ.Client.Apigen.Attributes.AmqpMethodMappingAttribute(null, "basic", "cancel")]
        void _Private_BasicCancel(string consumerTag, bool nowait);
        [RabbitMQ.Client.Apigen.Attributes.AmqpForceOneWayAttribute]
        [RabbitMQ.Client.Apigen.Attributes.AmqpMethodMappingAttribute(null, "basic", "consume")]
        void _Private_BasicConsume(string queue, string consumerTag, bool noLocal, bool noAck, bool exclusive, bool nowait, [RabbitMQ.Client.Apigen.Attributes.AmqpFieldMappingAttribute("RabbitMQ.Client.Framing.v0_8qpid", "arguments"), RabbitMQ.Client.Apigen.Attributes.AmqpUnsupportedAttribute("RabbitMQ.Client.Framing.v0_8")]System.Collections.IDictionary filter);
        [RabbitMQ.Client.Apigen.Attributes.AmqpForceOneWayAttribute]
        [RabbitMQ.Client.Apigen.Attributes.AmqpMethodMappingAttribute(null, "basic", "get")]
        void _Private_BasicGet(string queue, bool noAck);
        [RabbitMQ.Client.Apigen.Attributes.AmqpMethodMappingAttribute(null, "basic", "publish")]
        void _Private_BasicPublish(string exchange, string routingKey, bool mandatory, bool immediate, [RabbitMQ.Client.Apigen.Attributes.AmqpContentHeaderMappingAttribute]RabbitMQ.Client.IBasicProperties basicProperties, [RabbitMQ.Client.Apigen.Attributes.AmqpContentBodyMappingAttribute]byte[] body);
        [RabbitMQ.Client.Apigen.Attributes.AmqpForceOneWayAttribute]
        [RabbitMQ.Client.Apigen.Attributes.AmqpMethodMappingAttribute(null, "channel", "close")]
        void _Private_ChannelClose(ushort replyCode, string replyText, ushort classId, ushort methodId);
        [RabbitMQ.Client.Apigen.Attributes.AmqpMethodMappingAttribute(null, "channel", "close-ok")]
        void _Private_ChannelCloseOk();
        [RabbitMQ.Client.Apigen.Attributes.AmqpMethodMappingAttribute(null, "channel", "flow-ok")]
        void _Private_ChannelFlowOk();
        [RabbitMQ.Client.Apigen.Attributes.AmqpMethodMappingAttribute(null, "channel", "open")]
        void _Private_ChannelOpen(string outOfBand);
        [RabbitMQ.Client.Apigen.Attributes.AmqpMethodMappingAttribute(null, "connection", "close")]
        void _Private_ConnectionClose(ushort replyCode, string replyText, ushort classId, ushort methodId);
        [RabbitMQ.Client.Apigen.Attributes.AmqpMethodMappingAttribute(null, "connection", "close-ok")]
        void _Private_ConnectionCloseOk();
        [RabbitMQ.Client.Apigen.Attributes.AmqpForceOneWayAttribute]
        [RabbitMQ.Client.Apigen.Attributes.AmqpMethodMappingAttribute(null, "connection", "open")]
        void _Private_ConnectionOpen(string virtualHost, string capabilities, bool insist);
    }
    public partial interface IRpcContinuation
    {
        void HandleCommand(RabbitMQ.Client.Impl.Command cmd);
        void HandleModelShutdown(RabbitMQ.Client.ShutdownEventArgs reason);
    }
    public partial interface ISession
    {
        int ChannelNumber { get; }
        RabbitMQ.Client.ShutdownEventArgs CloseReason { get; }
        RabbitMQ.Client.Impl.CommandHandler CommandReceived { get; set; }
        RabbitMQ.Client.IConnection Connection { get; }
        bool IsOpen { get; }
        event RabbitMQ.Client.Impl.SessionShutdownEventHandler SessionShutdown;
        void Close(RabbitMQ.Client.ShutdownEventArgs reason);
        void Close(RabbitMQ.Client.ShutdownEventArgs reason, bool notify);
        void HandleFrame(RabbitMQ.Client.Impl.Frame frame);
        void Notify();
        void Transmit(RabbitMQ.Client.Impl.Command cmd);
    }
    public partial class MainSession : RabbitMQ.Client.Impl.Session
    {
        public int m_closeClassId;
        public int m_closeMethodId;
        public int m_closeOkClassId;
        public int m_closeOkMethodId;
        public bool m_closeServerInitiated;
        public bool m_closing;
        public RabbitMQ.Client.Impl.MainSession.SessionCloseDelegate m_handler;
        public MainSession(RabbitMQ.Client.Impl.ConnectionBase connection) : base (default(RabbitMQ.Client.Impl.ConnectionBase), default(int)) { }
        public RabbitMQ.Client.Impl.MainSession.SessionCloseDelegate Handler { get { throw null; } set { } }
        public override void HandleFrame(RabbitMQ.Client.Impl.Frame frame) { }
        public void SetSessionClosing(bool closeServerInitiated) { }
        public override void Transmit(RabbitMQ.Client.Impl.Command cmd) { }
        public delegate void SessionCloseDelegate();
    }
    public partial class MalformedFrameException : RabbitMQ.Client.Impl.HardProtocolException
    {
        public MalformedFrameException(string message) : base (default(string)) { }
        public override ushort ReplyCode { get { throw null; } }
    }
    public partial class MethodArgumentReader
    {
        public MethodArgumentReader(RabbitMQ.Util.NetworkBinaryReader reader) { }
        public RabbitMQ.Util.NetworkBinaryReader BaseReader { get { throw null; } }
        public bool ReadBit() { throw null; }
        public byte[] ReadContent() { throw null; }
        public uint ReadLong() { throw null; }
        public ulong ReadLonglong() { throw null; }
        public byte[] ReadLongstr() { throw null; }
        public byte ReadOctet() { throw null; }
        public ushort ReadShort() { throw null; }
        public string ReadShortstr() { throw null; }
        public System.Collections.IDictionary ReadTable() { throw null; }
        public RabbitMQ.Client.AmqpTimestamp ReadTimestamp() { throw null; }
    }
    public partial class MethodArgumentWriter
    {
        public MethodArgumentWriter(RabbitMQ.Util.NetworkBinaryWriter writer) { }
        public RabbitMQ.Util.NetworkBinaryWriter BaseWriter { get { throw null; } }
        public void Flush() { }
        public void WriteBit(bool val) { }
        public void WriteContent(byte[] val) { }
        public void WriteLong(uint val) { }
        public void WriteLonglong(ulong val) { }
        public void WriteLongstr(byte[] val) { }
        public void WriteOctet(byte val) { }
        public void WriteShort(ushort val) { }
        public void WriteShortstr(string val) { }
        public void WriteTable(System.Collections.IDictionary val) { }
        public void WriteTimestamp(RabbitMQ.Client.AmqpTimestamp val) { }
    }
    public abstract partial class MethodBase : RabbitMQ.Client.IMethod
    {
        protected MethodBase() { }
        public abstract bool HasContent { get; }
        public abstract int ProtocolClassId { get; }
        public abstract int ProtocolMethodId { get; }
        public abstract string ProtocolMethodName { get; }
        public abstract void AppendArgumentDebugStringTo(System.Text.StringBuilder sb);
        public abstract void ReadArgumentsFrom(RabbitMQ.Client.Impl.MethodArgumentReader reader);
        public abstract void WriteArgumentsTo(RabbitMQ.Client.Impl.MethodArgumentWriter writer);
    }
    public abstract partial class ModelBase : RabbitMQ.Client.IModel, RabbitMQ.Client.Impl.IFullModel, System.IDisposable
    {
        public RabbitMQ.Client.ShutdownEventArgs m_closeReason;
        public RabbitMQ.Util.BlockingCell m_connectionStartCell;
        public readonly System.Collections.IDictionary m_consumers;
        public RabbitMQ.Client.Impl.RpcContinuationQueue m_continuationQueue;
        public System.Threading.ManualResetEvent m_flowControlBlock;
        public RabbitMQ.Client.Impl.ISession m_session;
        public ModelBase(RabbitMQ.Client.Impl.ISession session) { }
        public RabbitMQ.Client.ShutdownEventArgs CloseReason { get { throw null; } }
        public bool IsOpen { get { throw null; } }
        public event RabbitMQ.Client.Events.BasicReturnEventHandler BasicReturn { add { } remove { } }
        public event RabbitMQ.Client.Events.CallbackExceptionEventHandler CallbackException { add { } remove { } }
        public event RabbitMQ.Client.Events.ModelShutdownEventHandler ModelShutdown { add { } remove { } }
        public void Abort() { }
        public void Abort(ushort replyCode, string replyText) { }
        public abstract void BasicAck(ulong deliveryTag, bool multiple);
        public void BasicCancel(string consumerTag) { }
        public string BasicConsume(string queue, bool noAck, System.Collections.IDictionary filter, RabbitMQ.Client.IBasicConsumer consumer) { throw null; }
        public string BasicConsume(string queue, bool noAck, string consumerTag, bool noLocal, bool exclusive, System.Collections.IDictionary filter, RabbitMQ.Client.IBasicConsumer consumer) { throw null; }
        public string BasicConsume(string queue, bool noAck, string consumerTag, System.Collections.IDictionary filter, RabbitMQ.Client.IBasicConsumer consumer) { throw null; }
        public string BasicConsume(string queue, System.Collections.IDictionary filter, RabbitMQ.Client.IBasicConsumer consumer) { throw null; }
        public RabbitMQ.Client.BasicGetResult BasicGet(string queue, bool noAck) { throw null; }
        public void BasicPublish(RabbitMQ.Client.PublicationAddress addr, RabbitMQ.Client.IBasicProperties basicProperties, byte[] body) { }
        public void BasicPublish(string exchange, string routingKey, RabbitMQ.Client.IBasicProperties basicProperties, byte[] body) { }
        public void BasicPublish(string exchange, string routingKey, bool mandatory, bool immediate, RabbitMQ.Client.IBasicProperties basicProperties, byte[] body) { }
        public abstract void BasicQos(uint prefetchSize, ushort prefetchCount, bool global);
        public abstract void BasicRecover(bool requeue);
        public abstract void BasicReject(ulong deliveryTag, bool requeue);
        public abstract void ChannelFlow(bool active);
        public void Close() { }
        public void Close(ushort replyCode, string replyText) { }
        public void Close(ushort replyCode, string replyText, bool abort) { }
        public string ConnectionOpen(string virtualHost, string capabilities, bool insist) { throw null; }
        public abstract RabbitMQ.Client.Impl.ConnectionTuneDetails ConnectionStartOk(System.Collections.IDictionary clientProperties, string mechanism, byte[] response, string locale);
        public abstract void ConnectionTuneOk(ushort channelMax, uint frameMax, ushort heartbeat);
        public abstract RabbitMQ.Client.IBasicProperties CreateBasicProperties();
        public abstract RabbitMQ.Client.IFileProperties CreateFileProperties();
        public abstract RabbitMQ.Client.IStreamProperties CreateStreamProperties();
        public abstract bool DispatchAsynchronous(RabbitMQ.Client.Impl.Command cmd);
        public abstract void DtxSelect();
        public abstract void DtxStart(string dtxIdentifier);
        public void Enqueue(RabbitMQ.Client.Impl.IRpcContinuation k) { }
        public void ExchangeDeclare(string exchange, string type) { }
        public void ExchangeDeclare(string exchange, string type, bool durable) { }
        public abstract void ExchangeDeclare(string exchange, string type, bool passive, bool durable, bool autoDelete, bool @internal, bool nowait, System.Collections.IDictionary arguments);
        public abstract void ExchangeDelete(string exchange, bool ifUnused, bool nowait);
        public void FinishClose() { }
        public void HandleBasicCancelOk(string consumerTag) { }
        public void HandleBasicConsumeOk(string consumerTag) { }
        public void HandleBasicDeliver(string consumerTag, ulong deliveryTag, bool redelivered, string exchange, string routingKey, RabbitMQ.Client.IBasicProperties basicProperties, byte[] body) { }
        public void HandleBasicGetEmpty() { }
        public void HandleBasicGetOk(ulong deliveryTag, bool redelivered, string exchange, string routingKey, uint messageCount, RabbitMQ.Client.IBasicProperties basicProperties, byte[] body) { }
        public void HandleBasicReturn(ushort replyCode, string replyText, string exchange, string routingKey, RabbitMQ.Client.IBasicProperties basicProperties, byte[] body) { }
        public void HandleChannelClose(ushort replyCode, string replyText, ushort classId, ushort methodId) { }
        public void HandleChannelCloseOk() { }
        public void HandleChannelFlow(bool active) { }
        public void HandleCommand(RabbitMQ.Client.Impl.ISession session, RabbitMQ.Client.Impl.Command cmd) { }
        public void HandleConnectionClose(ushort replyCode, string replyText, ushort classId, ushort methodId) { }
        public void HandleConnectionOpenOk(string knownHosts) { }
        public void HandleConnectionRedirect(string host, string knownHosts) { }
        public void HandleConnectionStart(byte versionMajor, byte versionMinor, System.Collections.IDictionary serverProperties, byte[] mechanisms, byte[] locales) { }
        public RabbitMQ.Client.Impl.MethodBase ModelRpc(RabbitMQ.Client.Impl.MethodBase method, RabbitMQ.Client.Impl.ContentHeaderBase header, byte[] body) { throw null; }
        public void ModelSend(RabbitMQ.Client.Impl.MethodBase method, RabbitMQ.Client.Impl.ContentHeaderBase header, byte[] body) { }
        public virtual void OnBasicReturn(RabbitMQ.Client.Events.BasicReturnEventArgs args) { }
        public virtual void OnCallbackException(RabbitMQ.Client.Events.CallbackExceptionEventArgs args) { }
        public virtual void OnModelShutdown(RabbitMQ.Client.ShutdownEventArgs reason) { }
        public void OnSessionShutdown(RabbitMQ.Client.Impl.ISession session, RabbitMQ.Client.ShutdownEventArgs reason) { }
        public abstract void QueueBind(string queue, string exchange, string routingKey, bool nowait, System.Collections.IDictionary arguments);
        public string QueueDeclare() { throw null; }
        public string QueueDeclare(string queue) { throw null; }
        public string QueueDeclare(string queue, bool durable) { throw null; }
        public abstract string QueueDeclare(string queue, bool passive, bool durable, bool exclusive, bool autoDelete, bool nowait, System.Collections.IDictionary arguments);
        public abstract uint QueueDelete(string queue, bool ifUnused, bool ifEmpty, bool nowait);
        public abstract uint QueuePurge(string queue, bool nowait);
        public abstract void QueueUnbind(string queue, string exchange, string routingKey, System.Collections.IDictionary arguments);
        public bool SetCloseReason(RabbitMQ.Client.ShutdownEventArgs reason) { throw null; }
        void System.IDisposable.Dispose() { }
        public override string ToString() { throw null; }
        public void TransmitAndEnqueue(RabbitMQ.Client.Impl.Command cmd, RabbitMQ.Client.Impl.IRpcContinuation k) { }
        public abstract void TxCommit();
        public abstract void TxRollback();
        public abstract void TxSelect();
        public abstract void _Private_BasicCancel(string consumerTag, bool nowait);
        public abstract void _Private_BasicConsume(string queue, string consumerTag, bool noLocal, bool noAck, bool exclusive, bool nowait, System.Collections.IDictionary filter);
        public abstract void _Private_BasicGet(string queue, bool noAck);
        public abstract void _Private_BasicPublish(string exchange, string routingKey, bool mandatory, bool immediate, RabbitMQ.Client.IBasicProperties basicProperties, byte[] body);
        public abstract void _Private_ChannelClose(ushort replyCode, string replyText, ushort classId, ushort methodId);
        public abstract void _Private_ChannelCloseOk();
        public abstract void _Private_ChannelFlowOk();
        public abstract void _Private_ChannelOpen(string outOfBand);
        public abstract void _Private_ConnectionClose(ushort replyCode, string replyText, ushort classId, ushort methodId);
        public abstract void _Private_ConnectionCloseOk();
        public abstract void _Private_ConnectionOpen(string virtualHost, string capabilities, bool insist);
        public partial class BasicConsumerRpcContinuation : RabbitMQ.Client.Impl.SimpleBlockingRpcContinuation
        {
            public RabbitMQ.Client.IBasicConsumer m_consumer;
            public string m_consumerTag;
            public BasicConsumerRpcContinuation() { }
        }
        public partial class BasicGetRpcContinuation : RabbitMQ.Client.Impl.SimpleBlockingRpcContinuation
        {
            public RabbitMQ.Client.BasicGetResult m_result;
            public BasicGetRpcContinuation() { }
        }
        public partial class ConnectionOpenContinuation : RabbitMQ.Client.Impl.SimpleBlockingRpcContinuation
        {
            public string m_host;
            public string m_knownHosts;
            public bool m_redirect;
            public ConnectionOpenContinuation() { }
        }
    }
    public abstract partial class ProtocolException : System.Net.ProtocolViolationException
    {
        protected ProtocolException(string message) { }
        public abstract ushort ReplyCode { get; }
        public virtual RabbitMQ.Client.ShutdownEventArgs ShutdownReason { get { throw null; } }
    }
    public partial class QuiescingSession : RabbitMQ.Client.Impl.SessionBase
    {
        public RabbitMQ.Client.ShutdownEventArgs m_reason;
        public int m_replyClassId;
        public int m_replyMethodId;
        public QuiescingSession(RabbitMQ.Client.Impl.ConnectionBase connection, int channelNumber, RabbitMQ.Client.ShutdownEventArgs reason, int replyClassId, int replyMethodId) : base (default(RabbitMQ.Client.Impl.ConnectionBase), default(int)) { }
        public override void HandleFrame(RabbitMQ.Client.Impl.Frame frame) { }
    }
    public partial class RedirectException : System.Exception
    {
        public RabbitMQ.Client.AmqpTcpEndpoint m_host;
        public RabbitMQ.Client.AmqpTcpEndpoint[] m_knownHosts;
        public RedirectException(RabbitMQ.Client.AmqpTcpEndpoint host, RabbitMQ.Client.AmqpTcpEndpoint[] knownHosts) { }
        public RedirectException(RabbitMQ.Client.IProtocol protocol, string host, string knownHosts) { }
        public RabbitMQ.Client.AmqpTcpEndpoint Host { get { throw null; } }
        public RabbitMQ.Client.AmqpTcpEndpoint[] KnownHosts { get { throw null; } }
        public static RabbitMQ.Client.AmqpTcpEndpoint ParseHost(RabbitMQ.Client.IProtocol protocol, string host) { throw null; }
    }
    public partial class RpcContinuationQueue
    {
        public RabbitMQ.Client.Impl.IRpcContinuation m_outstandingRpc;
        public RpcContinuationQueue() { }
        public void Enqueue(RabbitMQ.Client.Impl.IRpcContinuation k) { }
        public void HandleModelShutdown(RabbitMQ.Client.ShutdownEventArgs reason) { }
        public RabbitMQ.Client.Impl.IRpcContinuation Next() { throw null; }
    }
    public partial class Session : RabbitMQ.Client.Impl.SessionBase
    {
        public RabbitMQ.Client.Impl.CommandAssembler m_assembler;
        public Session(RabbitMQ.Client.Impl.ConnectionBase connection, int channelNumber) : base (default(RabbitMQ.Client.Impl.ConnectionBase), default(int)) { }
        public override void HandleFrame(RabbitMQ.Client.Impl.Frame frame) { }
    }
    public abstract partial class SessionBase : RabbitMQ.Client.Impl.ISession
    {
        public readonly int m_channelNumber;
        public RabbitMQ.Client.ShutdownEventArgs m_closeReason;
        public readonly RabbitMQ.Client.Impl.ConnectionBase m_connection;
        public SessionBase(RabbitMQ.Client.Impl.ConnectionBase connection, int channelNumber) { }
        public int ChannelNumber { get { throw null; } }
        public RabbitMQ.Client.ShutdownEventArgs CloseReason { get { throw null; } }
        public RabbitMQ.Client.Impl.CommandHandler CommandReceived { get { throw null; } set { } }
        public RabbitMQ.Client.Impl.ConnectionBase Connection { get { throw null; } }
        public bool IsOpen { get { throw null; } }
        RabbitMQ.Client.IConnection RabbitMQ.Client.Impl.ISession.Connection { get { throw null; } }
        public event RabbitMQ.Client.Impl.SessionShutdownEventHandler SessionShutdown { add { } remove { } }
        public void Close(RabbitMQ.Client.ShutdownEventArgs reason) { }
        public void Close(RabbitMQ.Client.ShutdownEventArgs reason, bool notify) { }
        public abstract void HandleFrame(RabbitMQ.Client.Impl.Frame frame);
        public void Notify() { }
        public virtual void OnCommandReceived(RabbitMQ.Client.Impl.Command cmd) { }
        public virtual void OnConnectionShutdown(RabbitMQ.Client.IConnection conn, RabbitMQ.Client.ShutdownEventArgs reason) { }
        public virtual void OnSessionShutdown(RabbitMQ.Client.ShutdownEventArgs reason) { }
        public override string ToString() { throw null; }
        public virtual void Transmit(RabbitMQ.Client.Impl.Command cmd) { }
    }
    public partial class SessionManager
    {
        public readonly ushort ChannelMax;
        public SessionManager(RabbitMQ.Client.Impl.ConnectionBase connection, ushort channelMax) { }
        public bool AutoClose { get { throw null; } set { } }
        public int Count { get { throw null; } }
        public void AutoCloseConnection() { }
        public void CheckAutoClose() { }
        public RabbitMQ.Client.Impl.ISession Create() { throw null; }
        public RabbitMQ.Client.Impl.ISession Create(int channelNumber) { throw null; }
        public RabbitMQ.Client.Impl.ISession CreateInternal(int channelNumber) { throw null; }
        public void HandleSessionShutdown(RabbitMQ.Client.Impl.ISession session, RabbitMQ.Client.ShutdownEventArgs reason) { }
        public RabbitMQ.Client.Impl.ISession Lookup(int number) { throw null; }
        public RabbitMQ.Client.Impl.ISession Swap(int channelNumber, RabbitMQ.Client.Impl.ISession replacement) { throw null; }
    }
    public delegate void SessionShutdownEventHandler(RabbitMQ.Client.Impl.ISession session, RabbitMQ.Client.ShutdownEventArgs reason);
    public partial class ShutdownContinuation
    {
        public readonly RabbitMQ.Util.BlockingCell m_cell;
        public ShutdownContinuation() { }
        public virtual void OnShutdown(RabbitMQ.Client.IConnection sender, RabbitMQ.Client.ShutdownEventArgs reason) { }
        public virtual void OnShutdown(RabbitMQ.Client.IModel sender, RabbitMQ.Client.ShutdownEventArgs reason) { }
        public virtual RabbitMQ.Client.ShutdownEventArgs Wait() { throw null; }
    }
    public partial class SimpleBlockingRpcContinuation : RabbitMQ.Client.Impl.IRpcContinuation
    {
        public readonly RabbitMQ.Util.BlockingCell m_cell;
        public SimpleBlockingRpcContinuation() { }
        public virtual RabbitMQ.Client.Impl.Command GetReply() { throw null; }
        public virtual void HandleCommand(RabbitMQ.Client.Impl.Command cmd) { }
        public virtual void HandleModelShutdown(RabbitMQ.Client.ShutdownEventArgs reason) { }
    }
    public partial class SocketFrameHandler_0_9 : RabbitMQ.Client.Impl.IFrameHandler
    {
        public RabbitMQ.Client.AmqpTcpEndpoint m_endpoint;
        public RabbitMQ.Util.NetworkBinaryReader m_reader;
        public System.Net.Sockets.TcpClient m_socket;
        public RabbitMQ.Util.NetworkBinaryWriter m_writer;
        public const int WSAEWOULDBLOCK = 10035;
        public SocketFrameHandler_0_9(RabbitMQ.Client.AmqpTcpEndpoint endpoint) { }
        public RabbitMQ.Client.AmqpTcpEndpoint Endpoint { get { throw null; } }
        public int Timeout { get { throw null; } set { } }
        public void Close() { }
        public RabbitMQ.Client.Impl.Frame ReadFrame() { throw null; }
        public void SendHeader() { }
        public void WriteFrame(RabbitMQ.Client.Impl.Frame frame) { }
    }
    public abstract partial class SoftProtocolException : RabbitMQ.Client.Impl.ProtocolException
    {
        protected SoftProtocolException(int channelNumber, string message) : base (default(string)) { }
        public int Channel { get { throw null; } }
    }
    public abstract partial class StreamProperties : RabbitMQ.Client.Impl.ContentHeaderBase, RabbitMQ.Client.IContentHeader, RabbitMQ.Client.IStreamProperties, System.ICloneable
    {
        protected StreamProperties() { }
        public abstract string ContentEncoding { get; set; }
        public abstract string ContentType { get; set; }
        public abstract System.Collections.IDictionary Headers { get; set; }
        public abstract byte Priority { get; set; }
        public abstract RabbitMQ.Client.AmqpTimestamp Timestamp { get; set; }
        public abstract void ClearContentEncoding();
        public abstract void ClearContentType();
        public abstract void ClearHeaders();
        public abstract void ClearPriority();
        public abstract void ClearTimestamp();
        public override object Clone() { throw null; }
        public abstract bool IsContentEncodingPresent();
        public abstract bool IsContentTypePresent();
        public abstract bool IsHeadersPresent();
        public abstract bool IsPriorityPresent();
        public abstract bool IsTimestampPresent();
    }
    public partial class SyntaxError : RabbitMQ.Client.Impl.HardProtocolException
    {
        public SyntaxError(string message) : base (default(string)) { }
        public override ushort ReplyCode { get { throw null; } }
    }
    public partial class UnexpectedFrameException : RabbitMQ.Client.Impl.HardProtocolException
    {
        public RabbitMQ.Client.Impl.Frame m_frame;
        public UnexpectedFrameException(RabbitMQ.Client.Impl.Frame frame) : base (default(string)) { }
        public RabbitMQ.Client.Impl.Frame Frame { get { throw null; } }
        public override ushort ReplyCode { get { throw null; } }
    }
    public partial class UnknownClassOrMethodException : RabbitMQ.Client.Impl.HardProtocolException
    {
        public UnknownClassOrMethodException(ushort classId, ushort methodId) : base (default(string)) { }
        public ushort ClassId { get { throw null; } }
        public ushort MethodId { get { throw null; } }
        public override ushort ReplyCode { get { throw null; } }
        public override string ToString() { throw null; }
    }
    public partial class WireFormatting
    {
        public WireFormatting() { }
        public static decimal AmqpToDecimal(byte scale, uint unsignedMantissa) { throw null; }
        public static void DecimalToAmqp(decimal value, out byte scale, out int mantissa) { throw null; }
        public static System.Collections.IList ReadArray(RabbitMQ.Util.NetworkBinaryReader reader) { throw null; }
        public static decimal ReadDecimal(RabbitMQ.Util.NetworkBinaryReader reader) { throw null; }
        public static object ReadFieldValue(RabbitMQ.Util.NetworkBinaryReader reader) { throw null; }
        public static uint ReadLong(RabbitMQ.Util.NetworkBinaryReader reader) { throw null; }
        public static ulong ReadLonglong(RabbitMQ.Util.NetworkBinaryReader reader) { throw null; }
        public static byte[] ReadLongstr(RabbitMQ.Util.NetworkBinaryReader reader) { throw null; }
        public static byte ReadOctet(RabbitMQ.Util.NetworkBinaryReader reader) { throw null; }
        public static ushort ReadShort(RabbitMQ.Util.NetworkBinaryReader reader) { throw null; }
        public static string ReadShortstr(RabbitMQ.Util.NetworkBinaryReader reader) { throw null; }
        public static System.Collections.IDictionary ReadTable(RabbitMQ.Util.NetworkBinaryReader reader) { throw null; }
        public static RabbitMQ.Client.AmqpTimestamp ReadTimestamp(RabbitMQ.Util.NetworkBinaryReader reader) { throw null; }
        public static void WriteArray(RabbitMQ.Util.NetworkBinaryWriter writer, System.Collections.IList val) { }
        public static void WriteDecimal(RabbitMQ.Util.NetworkBinaryWriter writer, decimal value) { }
        public static void WriteFieldValue(RabbitMQ.Util.NetworkBinaryWriter writer, object value) { }
        public static void WriteLong(RabbitMQ.Util.NetworkBinaryWriter writer, uint val) { }
        public static void WriteLonglong(RabbitMQ.Util.NetworkBinaryWriter writer, ulong val) { }
        public static void WriteLongstr(RabbitMQ.Util.NetworkBinaryWriter writer, byte[] val) { }
        public static void WriteOctet(RabbitMQ.Util.NetworkBinaryWriter writer, byte val) { }
        public static void WriteShort(RabbitMQ.Util.NetworkBinaryWriter writer, ushort val) { }
        public static void WriteShortstr(RabbitMQ.Util.NetworkBinaryWriter writer, string val) { }
        public static void WriteTable(RabbitMQ.Util.NetworkBinaryWriter writer, System.Collections.IDictionary val) { }
        public static void WriteTimestamp(RabbitMQ.Util.NetworkBinaryWriter writer, RabbitMQ.Client.AmqpTimestamp val) { }
    }
}
namespace RabbitMQ.Client.MessagePatterns
{
    public partial class SimpleRpcClient : System.IDisposable
    {
        protected RabbitMQ.Client.IModel m_model;
        protected RabbitMQ.Client.MessagePatterns.Subscription m_subscription;
        public SimpleRpcClient(RabbitMQ.Client.IModel model) { }
        public SimpleRpcClient(RabbitMQ.Client.IModel model, RabbitMQ.Client.PublicationAddress address) { }
        public SimpleRpcClient(RabbitMQ.Client.IModel model, string queueName) { }
        public SimpleRpcClient(RabbitMQ.Client.IModel model, string exchange, string exchangeType, string routingKey) { }
        public RabbitMQ.Client.PublicationAddress Address { get { throw null; } set { } }
        public RabbitMQ.Client.IModel Model { get { throw null; } }
        public RabbitMQ.Client.MessagePatterns.Subscription Subscription { get { throw null; } }
        public int TimeoutMilliseconds { get { throw null; } set { } }
        public event System.EventHandler Disconnected { add { } remove { } }
        public event System.EventHandler TimedOut { add { } remove { } }
        public virtual RabbitMQ.Client.Events.BasicDeliverEventArgs Call(RabbitMQ.Client.IBasicProperties requestProperties, byte[] body) { throw null; }
        public virtual byte[] Call(RabbitMQ.Client.IBasicProperties requestProperties, byte[] body, out RabbitMQ.Client.IBasicProperties replyProperties) { throw null; }
        public virtual byte[] Call(byte[] body) { throw null; }
        public virtual object[] Call(params object[] args) { throw null; }
        public virtual void Cast(RabbitMQ.Client.IBasicProperties requestProperties, byte[] body) { }
        public void Close() { }
        protected virtual void EnsureSubscription() { }
        public virtual void OnDisconnected() { }
        public virtual void OnTimedOut() { }
        protected virtual RabbitMQ.Client.Events.BasicDeliverEventArgs RetrieveReply(string correlationId) { throw null; }
        void System.IDisposable.Dispose() { }
    }
    public partial class SimpleRpcServer : System.IDisposable
    {
        protected RabbitMQ.Client.MessagePatterns.Subscription m_subscription;
        public SimpleRpcServer(RabbitMQ.Client.MessagePatterns.Subscription subscription) { }
        public bool Transactional { get { throw null; } }
        public void Close() { }
        public virtual byte[] HandleCall(bool isRedelivered, RabbitMQ.Client.IBasicProperties requestProperties, byte[] body, out RabbitMQ.Client.IBasicProperties replyProperties) { throw null; }
        public virtual void HandleCast(bool isRedelivered, RabbitMQ.Client.IBasicProperties requestProperties, byte[] body) { }
        public virtual byte[] HandleSimpleCall(bool isRedelivered, RabbitMQ.Client.IBasicProperties requestProperties, byte[] body, out RabbitMQ.Client.IBasicProperties replyProperties) { throw null; }
        public virtual void HandleSimpleCast(bool isRedelivered, RabbitMQ.Client.IBasicProperties requestProperties, byte[] body) { }
        public virtual void HandleStreamMessageCall(RabbitMQ.Client.Content.IStreamMessageBuilder replyWriter, bool isRedelivered, RabbitMQ.Client.IBasicProperties requestProperties, object[] args) { }
        public void MainLoop() { }
        public virtual void ProcessRequest(RabbitMQ.Client.Events.BasicDeliverEventArgs evt) { }
        public void SetTransactional() { }
        void System.IDisposable.Dispose() { }
    }
    public partial class Subscription : System.Collections.IEnumerable, System.Collections.IEnumerator, System.IDisposable
    {
        protected volatile RabbitMQ.Client.QueueingBasicConsumer m_consumer;
        protected readonly object m_consumerLock;
        protected string m_consumerTag;
        protected RabbitMQ.Client.Events.BasicDeliverEventArgs m_latestEvent;
        protected RabbitMQ.Client.IModel m_model;
        protected bool m_noAck;
        protected string m_queueName;
        protected volatile bool m_shouldDelete;
        public Subscription(RabbitMQ.Client.IModel model) { }
        public Subscription(RabbitMQ.Client.IModel model, string queueName) { }
        public Subscription(RabbitMQ.Client.IModel model, string queueName, bool noAck) { }
        public Subscription(RabbitMQ.Client.IModel model, string queueName, bool noAck, string exchangeName, string exchangeType, string routingKey) { }
        public Subscription(RabbitMQ.Client.IModel model, string exchangeName, string exchangeType, string routingKey) { }
        public Subscription(RabbitMQ.Client.IModel model, string queueName, string exchangeName, string exchangeType, string routingKey) { }
        public RabbitMQ.Client.IBasicConsumer Consumer { get { throw null; } }
        public string ConsumerTag { get { throw null; } }
        public RabbitMQ.Client.Events.BasicDeliverEventArgs LatestEvent { get { throw null; } }
        public RabbitMQ.Client.IModel Model { get { throw null; } }
        public bool NoAck { get { throw null; } }
        public string QueueName { get { throw null; } }
        object System.Collections.IEnumerator.Current { get { throw null; } }
        public void Ack() { }
        public void Ack(RabbitMQ.Client.Events.BasicDeliverEventArgs evt) { }
        public void Bind(string exchangeName, string exchangeType, string routingKey) { }
        public void Close() { }
        public RabbitMQ.Client.Events.BasicDeliverEventArgs Next() { throw null; }
        public bool Next(int millisecondsTimeout, out RabbitMQ.Client.Events.BasicDeliverEventArgs result) { throw null; }
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { throw null; }
        bool System.Collections.IEnumerator.MoveNext() { throw null; }
        void System.Collections.IEnumerator.Reset() { }
        void System.IDisposable.Dispose() { }
    }
}
namespace RabbitMQ.Util
{
    public partial class BlockingCell
    {
        public BlockingCell() { }
        public object Value { get { throw null; } set { } }
        public bool GetValue(int millisecondsTimeout, out object result) { throw null; }
        public static int validatedTimeout(int timeout) { throw null; }
    }
    public partial class DebugUtil
    {
        internal DebugUtil() { }
        public static void Dump(byte[] bytes) { }
        public static void Dump(byte[] bytes, System.IO.TextWriter writer) { }
        public static void DumpKeyValue(string key, object value, System.IO.TextWriter writer, int indent) { }
        public static void DumpProperties(object value, System.IO.TextWriter writer, int indent) { }
    }
    public partial class Either
    {
        internal Either() { }
        public RabbitMQ.Util.EitherAlternative Alternative { get { throw null; } }
        public object Value { get { throw null; } }
        public static RabbitMQ.Util.Either Left(object value) { throw null; }
        public static RabbitMQ.Util.Either Right(object value) { throw null; }
    }
    public enum EitherAlternative
    {
        Left = 0,
        Right = 1,
    }
    public partial class IntAllocator
    {
        public IntAllocator(int start, int end) { }
        public int Allocate() { throw null; }
        public void Free(int id) { }
        public bool Reserve(int id) { throw null; }
        public partial class IntervalList
        {
            public int End;
            public RabbitMQ.Util.IntAllocator.IntervalList Next;
            public int Start;
            public IntervalList(int start, int end) { }
            public static RabbitMQ.Util.IntAllocator.IntervalList FromArray(int[] xs, int length) { throw null; }
            public static RabbitMQ.Util.IntAllocator.IntervalList Merge(RabbitMQ.Util.IntAllocator.IntervalList x, RabbitMQ.Util.IntAllocator.IntervalList y) { throw null; }
        }
    }
    public partial class NetworkBinaryReader : System.IO.BinaryReader
    {
        public NetworkBinaryReader(System.IO.Stream input) : base (default(System.IO.Stream)) { }
        public NetworkBinaryReader(System.IO.Stream input, System.Text.Encoding encoding) : base (default(System.IO.Stream)) { }
        public override double ReadDouble() { throw null; }
        public override short ReadInt16() { throw null; }
        public override int ReadInt32() { throw null; }
        public override long ReadInt64() { throw null; }
        public override float ReadSingle() { throw null; }
        public override ushort ReadUInt16() { throw null; }
        public override uint ReadUInt32() { throw null; }
        public override ulong ReadUInt64() { throw null; }
        public static System.IO.BinaryReader TemporaryBinaryReader(byte[] bytes) { throw null; }
    }
    public partial class NetworkBinaryWriter : System.IO.BinaryWriter
    {
        public NetworkBinaryWriter(System.IO.Stream output) { }
        public NetworkBinaryWriter(System.IO.Stream output, System.Text.Encoding encoding) { }
        public static System.IO.BinaryWriter TemporaryBinaryWriter(int initialSize) { throw null; }
        public static byte[] TemporaryContents(System.IO.BinaryWriter w) { throw null; }
        public override void Write(double d) { }
        public override void Write(short i) { }
        public override void Write(int i) { }
        public override void Write(long i) { }
        public override void Write(float f) { }
        public override void Write(ushort i) { }
        public override void Write(uint i) { }
        public override void Write(ulong i) { }
    }
    public partial class Semaphore
    {
        public Semaphore() { }
        public Semaphore(int initialCount) { }
        public int Value { get { throw null; } }
        public void Release() { }
        public bool TryWait() { throw null; }
        public void Wait() { }
    }
    public partial class SharedQueue : System.Collections.IEnumerable
    {
        protected bool m_isOpen;
        protected System.Collections.Queue m_queue;
        public SharedQueue() { }
        public void Close() { }
        public object Dequeue() { throw null; }
        public bool Dequeue(int millisecondsTimeout, out object result) { throw null; }
        public object DequeueNoWait(object defaultValue) { throw null; }
        public void Enqueue(object o) { }
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { throw null; }
    }
    public partial class SharedQueueEnumerator : System.Collections.IEnumerator
    {
        protected object m_current;
        protected RabbitMQ.Util.SharedQueue m_queue;
        public SharedQueueEnumerator(RabbitMQ.Util.SharedQueue queue) { }
        object System.Collections.IEnumerator.Current { get { throw null; } }
        bool System.Collections.IEnumerator.MoveNext() { throw null; }
        void System.Collections.IEnumerator.Reset() { }
    }
    public partial class XmlUtil
    {
        internal XmlUtil() { }
        public static System.Xml.XmlTextWriter CreateIndentedXmlWriter() { throw null; }
        public static System.Xml.XmlTextWriter CreateIndentedXmlWriter(System.IO.Stream stream) { throw null; }
        public static System.Xml.XmlTextWriter CreateIndentedXmlWriter(string path) { throw null; }
        public static System.Xml.XmlDocument SerializeObject(System.Type serializationType, object obj) { throw null; }
    }
}
