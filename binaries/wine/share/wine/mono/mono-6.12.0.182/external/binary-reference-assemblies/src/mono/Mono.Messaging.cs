// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

[assembly:System.Reflection.AssemblyVersionAttribute("4.0.0.0")]
[assembly:System.CLSCompliantAttribute(true)]
[assembly:System.Diagnostics.DebuggableAttribute((System.Diagnostics.DebuggableAttribute.DebuggingModes)(2))]
[assembly:System.Reflection.AssemblyCompanyAttribute("Mono development team")]
[assembly:System.Reflection.AssemblyCopyrightAttribute("(c) Various Mono authors")]
[assembly:System.Reflection.AssemblyDefaultAliasAttribute("Mono.Messaging.dll")]
[assembly:System.Reflection.AssemblyDescriptionAttribute("Mono.Messaging.dll")]
[assembly:System.Reflection.AssemblyFileVersionAttribute("4.6.57.0")]
[assembly:System.Reflection.AssemblyInformationalVersionAttribute("4.6.57.0")]
[assembly:System.Reflection.AssemblyProductAttribute("Mono Common Language Infrastructure")]
[assembly:System.Reflection.AssemblyTitleAttribute("Mono.Messaging.dll")]
[assembly:System.Resources.NeutralResourcesLanguageAttribute("en-US")]
[assembly:System.Resources.SatelliteContractVersionAttribute("4.0.0.0")]
[assembly:System.Runtime.CompilerServices.CompilationRelaxationsAttribute((System.Runtime.CompilerServices.CompilationRelaxations)(8))]
[assembly:System.Runtime.CompilerServices.ReferenceAssemblyAttribute]
[assembly:System.Runtime.CompilerServices.RuntimeCompatibilityAttribute(WrapNonExceptionThrows=true)]
[assembly:System.Runtime.InteropServices.ComVisibleAttribute(false)]
namespace Mono.Messaging
{
    [System.FlagsAttribute]
    [System.SerializableAttribute]
    public enum AcknowledgeTypes
    {
        FullReachQueue = 5,
        FullReceive = 14,
        NegativeReceive = 8,
        None = 0,
        NotAcknowledgeReachQueue = 4,
        NotAcknowledgeReceive = 12,
        PositiveArrival = 1,
        PositiveReceive = 2,
    }
    [System.SerializableAttribute]
    public enum Acknowledgment
    {
        AccessDenied = 32772,
        BadDestinationQueue = 32768,
        BadEncryption = 32775,
        BadSignature = 32774,
        CouldNotEncrypt = 32776,
        HopCountExceeded = 32773,
        None = 0,
        NotTransactionalMessage = 32778,
        NotTransactionalQueue = 32777,
        Purged = 32769,
        QueueDeleted = 49152,
        QueueExceedMaximumSize = 32771,
        QueuePurged = 49153,
        ReachQueue = 2,
        ReachQueueTimeout = 32770,
        Receive = 16384,
        ReceiveTimeout = 49154,
    }
    public partial class CompletedEventArgs : System.EventArgs
    {
        public CompletedEventArgs(System.IAsyncResult result) { }
        public System.IAsyncResult AsyncResult { get { throw null; } set { } }
    }
    [System.SerializableAttribute]
    public delegate void CompletedEventHandler(object sender, Mono.Messaging.CompletedEventArgs e);
    public partial class ConcurrentLinkedQueue<T>
    {
        public ConcurrentLinkedQueue() { }
        public T Dequeue() { throw null; }
        public void Enqueue(T context) { }
        public override string ToString() { throw null; }
    }
    public partial class ConnectionException : Mono.Messaging.MonoMessagingException
    {
        public ConnectionException(Mono.Messaging.QueueReference qRef) { }
        public ConnectionException(Mono.Messaging.QueueReference qRef, System.Exception e) { }
        public Mono.Messaging.QueueReference QRef { get { throw null; } }
    }
    [System.SerializableAttribute]
    public enum CryptographicProviderType
    {
        Dss = 3,
        Fortezza = 4,
        MicrosoftExchange = 5,
        None = 0,
        RsaFull = 1,
        RsqSig = 2,
        Ssl = 6,
        SttAcq = 8,
        SttBrnd = 9,
        SttIss = 11,
        SttMer = 7,
        SttRoot = 10,
    }
    [System.SerializableAttribute]
    public enum EncryptionAlgorithm
    {
        None = 0,
        Rc2 = 26114,
        Rc4 = 26625,
    }
    [System.SerializableAttribute]
    public enum EncryptionRequired
    {
        Body = 2,
        None = 0,
        Optional = 1,
    }
    [System.SerializableAttribute]
    public enum HashAlgorithm
    {
        Mac = 32773,
        Md2 = 32769,
        Md4 = 32770,
        Md5 = 32771,
        None = 0,
        Sha = 32772,
    }
    public partial interface IMessage
    {
        Mono.Messaging.AcknowledgeTypes AcknowledgeType { get; set; }
        Mono.Messaging.Acknowledgment Acknowledgment { get; }
        Mono.Messaging.IMessageQueue AdministrationQueue { get; set; }
        int AppSpecific { get; set; }
        System.DateTime ArrivedTime { get; }
        bool AttachSenderId { get; set; }
        bool Authenticated { get; }
        string AuthenticationProviderName { get; set; }
        Mono.Messaging.CryptographicProviderType AuthenticationProviderType { get; set; }
        System.IO.Stream BodyStream { get; set; }
        int BodyType { get; set; }
        System.Guid ConnectorType { get; set; }
        string CorrelationId { get; set; }
        Mono.Messaging.IMessageQueue DestinationQueue { get; }
        byte[] DestinationSymmetricKey { get; set; }
        byte[] DigitalSignature { get; set; }
        Mono.Messaging.EncryptionAlgorithm EncryptionAlgorithm { get; set; }
        byte[] Extension { get; set; }
        Mono.Messaging.HashAlgorithm HashAlgorithm { get; set; }
        string Id { get; }
        bool IsFirstInTransaction { get; }
        bool IsLastInTransaction { get; }
        string Label { get; set; }
        Mono.Messaging.MessageType MessageType { get; }
        Mono.Messaging.MessagePriority Priority { get; set; }
        bool Recoverable { get; set; }
        Mono.Messaging.IMessageQueue ResponseQueue { get; set; }
        byte[] SenderCertificate { get; set; }
        byte[] SenderId { get; }
        long SenderVersion { get; }
        System.DateTime SentTime { get; }
        string SourceMachine { get; }
        System.TimeSpan TimeToBeReceived { get; set; }
        System.TimeSpan TimeToReachQueue { get; set; }
        string TransactionId { get; }
        Mono.Messaging.IMessageQueue TransactionStatusQueue { get; set; }
        bool UseAuthentication { get; set; }
        bool UseDeadLetterQueue { get; set; }
        bool UseEncryption { get; set; }
        bool UseJournalQueue { get; set; }
        bool UseTracing { get; set; }
        void SetDeliveryInfo(Mono.Messaging.Acknowledgment acknowledgment, System.DateTime arrivedTime, Mono.Messaging.IMessageQueue destinationQueue, string id, Mono.Messaging.MessageType messageType, byte[] senderId, long senderVersion, System.DateTime sentTime, string sourceMachine, string transactionId);
    }
    public partial interface IMessageEnumerator : System.IDisposable
    {
        Mono.Messaging.IMessage Current { get; }
        System.IntPtr CursorHandle { get; }
        void Close();
        void Dispose(bool disposing);
        bool MoveNext();
        bool MoveNext(System.TimeSpan timeout);
        Mono.Messaging.IMessage RemoveCurrent();
        Mono.Messaging.IMessage RemoveCurrent(Mono.Messaging.IMessageQueueTransaction transaction);
        Mono.Messaging.IMessage RemoveCurrent(Mono.Messaging.MessageQueueTransactionType transactionType);
        Mono.Messaging.IMessage RemoveCurrent(System.TimeSpan timeout);
        Mono.Messaging.IMessage RemoveCurrent(System.TimeSpan timeout, Mono.Messaging.IMessageQueueTransaction transaction);
        Mono.Messaging.IMessage RemoveCurrent(System.TimeSpan timeout, Mono.Messaging.MessageQueueTransactionType transactionType);
    }
    public partial interface IMessageQueue
    {
        bool Authenticate { get; set; }
        short BasePriority { get; set; }
        bool CanRead { get; }
        bool CanWrite { get; }
        System.Guid Category { get; set; }
        System.DateTime CreateTime { get; }
        bool DenySharedReceive { get; set; }
        Mono.Messaging.EncryptionRequired EncryptionRequired { get; set; }
        System.Guid Id { get; }
        System.DateTime LastModifyTime { get; }
        long MaximumJournalSize { get; set; }
        long MaximumQueueSize { get; set; }
        Mono.Messaging.QueueReference QRef { get; set; }
        System.IntPtr ReadHandle { get; }
        System.ComponentModel.ISynchronizeInvoke SynchronizingObject { get; set; }
        bool Transactional { get; }
        bool UseJournalQueue { get; set; }
        System.IntPtr WriteHandle { get; }
        event Mono.Messaging.CompletedEventHandler PeekCompleted;
        event Mono.Messaging.CompletedEventHandler ReceiveCompleted;
        System.IAsyncResult BeginPeek();
        System.IAsyncResult BeginPeek(System.TimeSpan timeout);
        System.IAsyncResult BeginPeek(System.TimeSpan timeout, object stateObject);
        System.IAsyncResult BeginPeek(System.TimeSpan timeout, object stateObject, System.AsyncCallback callback);
        System.IAsyncResult BeginReceive();
        System.IAsyncResult BeginReceive(System.TimeSpan timeout);
        System.IAsyncResult BeginReceive(System.TimeSpan timeout, object stateObject);
        System.IAsyncResult BeginReceive(System.TimeSpan timeout, object stateObject, System.AsyncCallback callback);
        void Close();
        Mono.Messaging.IMessage EndPeek(System.IAsyncResult asyncResult);
        Mono.Messaging.IMessage EndReceive(System.IAsyncResult asyncResult);
        Mono.Messaging.IMessageEnumerator GetMessageEnumerator();
        Mono.Messaging.IMessage Peek();
        Mono.Messaging.IMessage Peek(System.TimeSpan timeout);
        Mono.Messaging.IMessage PeekByCorrelationId(string correlationId);
        Mono.Messaging.IMessage PeekByCorrelationId(string correlationId, System.TimeSpan timeout);
        Mono.Messaging.IMessage PeekById(string id);
        Mono.Messaging.IMessage PeekById(string id, System.TimeSpan timeout);
        void Purge();
        Mono.Messaging.IMessage Receive();
        Mono.Messaging.IMessage Receive(Mono.Messaging.IMessageQueueTransaction transaction);
        Mono.Messaging.IMessage Receive(Mono.Messaging.MessageQueueTransactionType transactionType);
        Mono.Messaging.IMessage Receive(System.TimeSpan timeout);
        Mono.Messaging.IMessage Receive(System.TimeSpan timeout, Mono.Messaging.IMessageQueueTransaction transaction);
        Mono.Messaging.IMessage Receive(System.TimeSpan timeout, Mono.Messaging.MessageQueueTransactionType transactionType);
        Mono.Messaging.IMessage ReceiveByCorrelationId(string correlationId);
        Mono.Messaging.IMessage ReceiveByCorrelationId(string correlationId, Mono.Messaging.IMessageQueueTransaction transaction);
        Mono.Messaging.IMessage ReceiveByCorrelationId(string correlationId, Mono.Messaging.MessageQueueTransactionType transactionType);
        Mono.Messaging.IMessage ReceiveByCorrelationId(string correlationId, System.TimeSpan timeout);
        Mono.Messaging.IMessage ReceiveByCorrelationId(string correlationId, System.TimeSpan timeout, Mono.Messaging.IMessageQueueTransaction transaction);
        Mono.Messaging.IMessage ReceiveByCorrelationId(string correlationId, System.TimeSpan timeout, Mono.Messaging.MessageQueueTransactionType transactionType);
        Mono.Messaging.IMessage ReceiveById(string id);
        Mono.Messaging.IMessage ReceiveById(string id, Mono.Messaging.IMessageQueueTransaction transaction);
        Mono.Messaging.IMessage ReceiveById(string id, Mono.Messaging.MessageQueueTransactionType transactionType);
        Mono.Messaging.IMessage ReceiveById(string id, System.TimeSpan timeout);
        Mono.Messaging.IMessage ReceiveById(string id, System.TimeSpan timeout, Mono.Messaging.IMessageQueueTransaction transaction);
        Mono.Messaging.IMessage ReceiveById(string id, System.TimeSpan timeout, Mono.Messaging.MessageQueueTransactionType transactionType);
        void Send(Mono.Messaging.IMessage message);
        void Send(Mono.Messaging.IMessage message, Mono.Messaging.IMessageQueueTransaction transaction);
        void Send(Mono.Messaging.IMessage message, Mono.Messaging.MessageQueueTransactionType transactionType);
        void SendPeekCompleted(System.IAsyncResult result);
        void SendReceiveCompleted(System.IAsyncResult result);
    }
    public partial interface IMessageQueueTransaction : System.IDisposable
    {
        Mono.Messaging.MessageQueueTransactionStatus Status { get; }
        void Abort();
        void Begin();
        void Commit();
    }
    public partial interface IMessagingProvider
    {
        Mono.Messaging.IMessage CreateMessage();
        Mono.Messaging.IMessageQueue CreateMessageQueue(Mono.Messaging.QueueReference qRef, bool transactional);
        Mono.Messaging.IMessageQueueTransaction CreateMessageQueueTransaction();
        void DeleteQueue(Mono.Messaging.QueueReference qRef);
        bool Exists(Mono.Messaging.QueueReference qRef);
        Mono.Messaging.IMessageQueue GetMessageQueue(Mono.Messaging.QueueReference qRef);
        Mono.Messaging.IMessageQueue[] GetPublicQueues();
    }
    public partial class MessageBase : Mono.Messaging.IMessage
    {
        public MessageBase() { }
        public Mono.Messaging.AcknowledgeTypes AcknowledgeType { get { throw null; } set { } }
        public Mono.Messaging.Acknowledgment Acknowledgment { get { throw null; } }
        public Mono.Messaging.IMessageQueue AdministrationQueue { get { throw null; } set { } }
        public int AppSpecific { get { throw null; } set { } }
        public System.DateTime ArrivedTime { get { throw null; } }
        public bool AttachSenderId { get { throw null; } set { } }
        public bool Authenticated { get { throw null; } }
        public string AuthenticationProviderName { get { throw null; } set { } }
        public Mono.Messaging.CryptographicProviderType AuthenticationProviderType { get { throw null; } set { } }
        public System.IO.Stream BodyStream { get { throw null; } set { } }
        public int BodyType { get { throw null; } set { } }
        public System.Guid ConnectorType { get { throw null; } set { } }
        public string CorrelationId { get { throw null; } set { } }
        public Mono.Messaging.IMessageQueue DestinationQueue { get { throw null; } }
        public byte[] DestinationSymmetricKey { get { throw null; } set { } }
        public byte[] DigitalSignature { get { throw null; } set { } }
        public Mono.Messaging.EncryptionAlgorithm EncryptionAlgorithm { get { throw null; } set { } }
        public byte[] Extension { get { throw null; } set { } }
        public Mono.Messaging.HashAlgorithm HashAlgorithm { get { throw null; } set { } }
        public string Id { get { throw null; } }
        public bool IsFirstInTransaction { get { throw null; } }
        public bool IsLastInTransaction { get { throw null; } }
        public string Label { get { throw null; } set { } }
        public Mono.Messaging.MessageType MessageType { get { throw null; } }
        public Mono.Messaging.MessagePriority Priority { get { throw null; } set { } }
        public bool Recoverable { get { throw null; } set { } }
        public Mono.Messaging.IMessageQueue ResponseQueue { get { throw null; } set { } }
        public byte[] SenderCertificate { get { throw null; } set { } }
        public byte[] SenderId { get { throw null; } }
        public long SenderVersion { get { throw null; } }
        public System.DateTime SentTime { get { throw null; } }
        public string SourceMachine { get { throw null; } }
        public System.TimeSpan TimeToBeReceived { get { throw null; } set { } }
        public System.TimeSpan TimeToReachQueue { get { throw null; } set { } }
        public string TransactionId { get { throw null; } }
        public Mono.Messaging.IMessageQueue TransactionStatusQueue { get { throw null; } set { } }
        public bool UseAuthentication { get { throw null; } set { } }
        public bool UseDeadLetterQueue { get { throw null; } set { } }
        public bool UseEncryption { get { throw null; } set { } }
        public bool UseJournalQueue { get { throw null; } set { } }
        public bool UseTracing { get { throw null; } set { } }
        public void SetDeliveryInfo(Mono.Messaging.Acknowledgment acknowledgment, System.DateTime arrivedTime, Mono.Messaging.IMessageQueue destinationQueue, string id, Mono.Messaging.MessageType messageType, byte[] senderId, long senderVersion, System.DateTime sentTime, string sourceMachine, string transactionId) { }
    }
    [System.SerializableAttribute]
    public enum MessagePriority
    {
        AboveNormal = 4,
        High = 5,
        Highest = 7,
        Low = 2,
        Lowest = 0,
        Normal = 3,
        VeryHigh = 6,
        VeryLow = 1,
    }
    public abstract partial class MessageQueueBase
    {
        protected MessageQueueBase() { }
        protected abstract Mono.Messaging.IMessageQueue Queue { get; }
        public event Mono.Messaging.CompletedEventHandler PeekCompleted { add { } remove { } }
        public event Mono.Messaging.CompletedEventHandler ReceiveCompleted { add { } remove { } }
        public System.IAsyncResult BeginPeek() { throw null; }
        public System.IAsyncResult BeginPeek(System.TimeSpan timeout) { throw null; }
        public System.IAsyncResult BeginPeek(System.TimeSpan timeout, object stateObject) { throw null; }
        public System.IAsyncResult BeginPeek(System.TimeSpan timeout, object stateObject, System.AsyncCallback callback) { throw null; }
        public System.IAsyncResult BeginReceive() { throw null; }
        public System.IAsyncResult BeginReceive(System.TimeSpan timeout) { throw null; }
        public System.IAsyncResult BeginReceive(System.TimeSpan timeout, object stateObject) { throw null; }
        public System.IAsyncResult BeginReceive(System.TimeSpan timeout, object stateObject, System.AsyncCallback callback) { throw null; }
        public Mono.Messaging.IMessage EndPeek(System.IAsyncResult asyncResult) { throw null; }
        public Mono.Messaging.IMessage EndReceive(System.IAsyncResult asyncResult) { throw null; }
        public void SendPeekCompleted(System.IAsyncResult result) { }
        public void SendReceiveCompleted(System.IAsyncResult result) { }
    }
    [System.SerializableAttribute]
    public enum MessageQueueTransactionStatus
    {
        Aborted = 0,
        Committed = 1,
        Initialized = 2,
        Pending = 3,
    }
    [System.SerializableAttribute]
    public enum MessageQueueTransactionType
    {
        Automatic = 1,
        None = 0,
        Single = 3,
    }
    [System.SerializableAttribute]
    public enum MessageType
    {
        Acknowledgment = 1,
        Normal = 2,
        Report = 3,
    }
    public partial class MessageUnavailableException : Mono.Messaging.MonoMessagingException
    {
        public MessageUnavailableException() { }
        public MessageUnavailableException(string msg) { }
        public MessageUnavailableException(string msg, System.Exception e) { }
    }
    public partial class MessagingProviderLocator
    {
        internal MessagingProviderLocator() { }
        public static readonly System.TimeSpan InfiniteTimeout;
        public static Mono.Messaging.MessagingProviderLocator Instance { get { throw null; } }
        public static Mono.Messaging.IMessagingProvider GetProvider() { throw null; }
    }
    public partial class MonoMessagingException : System.Exception
    {
        public MonoMessagingException() { }
        public MonoMessagingException(string msg) { }
        public MonoMessagingException(string msg, System.Exception e) { }
    }
    public sealed partial class QueueReference
    {
        public static readonly Mono.Messaging.QueueReference DEFAULT;
        public static readonly string LOCALHOST;
        public QueueReference(string host, string queue, bool isPrivate) { }
        public string Host { get { throw null; } }
        public bool IsPrivate { get { throw null; } }
        public string Queue { get { throw null; } }
        public bool Equals(Mono.Messaging.QueueReference other) { throw null; }
        public override bool Equals(object other) { throw null; }
        public override int GetHashCode() { throw null; }
        public static bool IsPrivateStr(string s) { throw null; }
        public static bool operator ==(Mono.Messaging.QueueReference a, Mono.Messaging.QueueReference b) { throw null; }
        public static bool operator !=(Mono.Messaging.QueueReference a, Mono.Messaging.QueueReference b) { throw null; }
        public static Mono.Messaging.QueueReference Parse(string path) { throw null; }
        public static string RemoveLeadingSlashes(string s) { throw null; }
        public Mono.Messaging.QueueReference SetHost(string host) { throw null; }
        public Mono.Messaging.QueueReference SetQueue(string queue) { throw null; }
        public override string ToString() { throw null; }
    }
}
