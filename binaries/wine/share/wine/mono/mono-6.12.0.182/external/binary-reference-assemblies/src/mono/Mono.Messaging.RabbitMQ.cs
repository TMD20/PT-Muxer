// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

[assembly:System.Reflection.AssemblyVersionAttribute("4.0.0.0")]
[assembly:System.CLSCompliantAttribute(false)]
[assembly:System.Diagnostics.DebuggableAttribute((System.Diagnostics.DebuggableAttribute.DebuggingModes)(2))]
[assembly:System.Reflection.AssemblyCompanyAttribute("Mono development team")]
[assembly:System.Reflection.AssemblyCopyrightAttribute("(c) Various Mono authors")]
[assembly:System.Reflection.AssemblyDefaultAliasAttribute("Mono.Messaging.RabbitMQ.dll")]
[assembly:System.Reflection.AssemblyDescriptionAttribute("Mono.Messaging.RabbitMQ.dll")]
[assembly:System.Reflection.AssemblyFileVersionAttribute("4.6.57.0")]
[assembly:System.Reflection.AssemblyInformationalVersionAttribute("4.6.57.0")]
[assembly:System.Reflection.AssemblyProductAttribute("Mono Common Language Infrastructure")]
[assembly:System.Reflection.AssemblyTitleAttribute("Mono.Messaging.RabbitMQ.dll")]
[assembly:System.Resources.NeutralResourcesLanguageAttribute("en-US")]
[assembly:System.Resources.SatelliteContractVersionAttribute("4.0.0.0")]
[assembly:System.Runtime.CompilerServices.CompilationRelaxationsAttribute((System.Runtime.CompilerServices.CompilationRelaxations)(8))]
[assembly:System.Runtime.CompilerServices.ReferenceAssemblyAttribute]
[assembly:System.Runtime.CompilerServices.RuntimeCompatibilityAttribute(WrapNonExceptionThrows=true)]
[assembly:System.Runtime.InteropServices.ComVisibleAttribute(false)]
namespace Mono.Messaging.RabbitMQ
{
    public delegate global::RabbitMQ.Client.IConnection CreateConnectionDelegate(string host);
    public partial interface IMessagingContext : System.IDisposable
    {
        void Delete(Mono.Messaging.QueueReference qRef);
        void Purge(Mono.Messaging.QueueReference qRef);
        Mono.Messaging.IMessage Receive(Mono.Messaging.QueueReference qRef, System.TimeSpan timeout, Mono.Messaging.RabbitMQ.IsMatch matcher, bool ack);
        void Send(Mono.Messaging.QueueReference qRef, Mono.Messaging.IMessage msg);
    }
    public delegate bool IsMatch(global::RabbitMQ.Client.Events.BasicDeliverEventArgs result);
    public partial class MessageFactory
    {
        public MessageFactory(Mono.Messaging.RabbitMQ.RabbitMQMessagingProvider provider) { }
        public static System.DateTime AmqpTimestampToDateTime(global::RabbitMQ.Client.AmqpTimestamp ats) { throw null; }
        public static global::RabbitMQ.Client.AmqpTimestamp DateTimeToAmqpTimestamp(System.DateTime t) { throw null; }
        public static string GetString(System.Collections.IDictionary properties, string key) { throw null; }
        public Mono.Messaging.IMessage ReadMessage(Mono.Messaging.QueueReference destination, global::RabbitMQ.Client.Events.BasicDeliverEventArgs result) { throw null; }
        public static int TimeSpanToMillis(System.TimeSpan timespan) { throw null; }
        public global::RabbitMQ.Client.Content.IMessageBuilder WriteMessage(global::RabbitMQ.Client.IModel ch, Mono.Messaging.IMessage msg) { throw null; }
    }
    public partial class MessagingContext : Mono.Messaging.RabbitMQ.IMessagingContext, System.IDisposable
    {
        public MessagingContext(Mono.Messaging.RabbitMQ.MessageFactory factory, string host, Mono.Messaging.RabbitMQ.CreateConnectionDelegate createConnection) { }
        public global::RabbitMQ.Client.IConnection Connection { get { throw null; } }
        public global::RabbitMQ.Client.IModel Model { get { throw null; } }
        public void Delete(Mono.Messaging.QueueReference qRef) { }
        public void Dispose() { }
        protected virtual void Dispose(bool disposing) { }
        public void Purge(Mono.Messaging.QueueReference qRef) { }
        public Mono.Messaging.IMessage Receive(Mono.Messaging.QueueReference qRef, System.TimeSpan timeout, Mono.Messaging.RabbitMQ.IsMatch matcher, bool ack) { throw null; }
        public void Send(Mono.Messaging.QueueReference qRef, Mono.Messaging.IMessage message) { }
    }
    public partial class MessagingContextPool
    {
        public MessagingContextPool(Mono.Messaging.RabbitMQ.MessageFactory messageFactory, Mono.Messaging.RabbitMQ.CreateConnectionDelegate createConnectionDelegate) { }
        public Mono.Messaging.RabbitMQ.MessagingContext GetContext(string host) { throw null; }
        public void ReturnContext(Mono.Messaging.RabbitMQ.MessagingContext context) { }
    }
    public partial class RabbitMQMessageEnumerator : Mono.Messaging.IMessageEnumerator, System.IDisposable
    {
        public RabbitMQMessageEnumerator(Mono.Messaging.RabbitMQ.MessageFactory helper, Mono.Messaging.QueueReference qRef) { }
        public Mono.Messaging.IMessage Current { get { throw null; } }
        public System.IntPtr CursorHandle { get { throw null; } }
        public void Close() { }
        public void Dispose() { }
        public void Dispose(bool disposing) { }
        public bool MoveNext() { throw null; }
        public bool MoveNext(System.TimeSpan timeout) { throw null; }
        public Mono.Messaging.IMessage RemoveCurrent() { throw null; }
        public Mono.Messaging.IMessage RemoveCurrent(Mono.Messaging.IMessageQueueTransaction transaction) { throw null; }
        public Mono.Messaging.IMessage RemoveCurrent(Mono.Messaging.MessageQueueTransactionType transactionType) { throw null; }
        public Mono.Messaging.IMessage RemoveCurrent(System.TimeSpan timeout) { throw null; }
        public Mono.Messaging.IMessage RemoveCurrent(System.TimeSpan timeout, Mono.Messaging.IMessageQueueTransaction transaction) { throw null; }
        public Mono.Messaging.IMessage RemoveCurrent(System.TimeSpan timeout, Mono.Messaging.MessageQueueTransactionType transactionType) { throw null; }
        public void Reset() { }
    }
    public partial class RabbitMQMessageQueue : Mono.Messaging.MessageQueueBase, Mono.Messaging.IMessageQueue
    {
        public RabbitMQMessageQueue(Mono.Messaging.RabbitMQ.RabbitMQMessagingProvider provider, Mono.Messaging.QueueReference qRef, bool transactional) { }
        public RabbitMQMessageQueue(Mono.Messaging.RabbitMQ.RabbitMQMessagingProvider provider, bool transactional) { }
        public bool Authenticate { get { throw null; } set { } }
        public short BasePriority { get { throw null; } set { } }
        public bool CanRead { get { throw null; } }
        public bool CanWrite { get { throw null; } }
        public System.Guid Category { get { throw null; } set { } }
        public System.DateTime CreateTime { get { throw null; } }
        public bool DenySharedReceive { get { throw null; } set { } }
        public Mono.Messaging.EncryptionRequired EncryptionRequired { get { throw null; } set { } }
        public System.Guid Id { get { throw null; } }
        public System.DateTime LastModifyTime { get { throw null; } }
        public long MaximumJournalSize { get { throw null; } set { } }
        public long MaximumQueueSize { get { throw null; } set { } }
        public Mono.Messaging.QueueReference QRef { get { throw null; } set { } }
        protected override Mono.Messaging.IMessageQueue Queue { get { throw null; } }
        public System.IntPtr ReadHandle { get { throw null; } }
        public System.ComponentModel.ISynchronizeInvoke SynchronizingObject { get { throw null; } set { } }
        public bool Transactional { get { throw null; } }
        public bool UseJournalQueue { get { throw null; } set { } }
        public System.IntPtr WriteHandle { get { throw null; } }
        public void Close() { }
        public static void Delete(Mono.Messaging.QueueReference qRef) { }
        public Mono.Messaging.IMessageEnumerator GetMessageEnumerator() { throw null; }
        event Mono.Messaging.CompletedEventHandler Mono.Messaging.IMessageQueue.PeekCompleted { add { } remove { } }
        event Mono.Messaging.CompletedEventHandler Mono.Messaging.IMessageQueue.ReceiveCompleted { add { } remove { } }
        System.IAsyncResult Mono.Messaging.IMessageQueue.BeginPeek() { throw null; }
        System.IAsyncResult Mono.Messaging.IMessageQueue.BeginPeek(System.TimeSpan timeout) { throw null; }
        System.IAsyncResult Mono.Messaging.IMessageQueue.BeginPeek(System.TimeSpan timeout, object stateObject) { throw null; }
        System.IAsyncResult Mono.Messaging.IMessageQueue.BeginPeek(System.TimeSpan timeout, object stateObject, System.AsyncCallback callback) { throw null; }
        System.IAsyncResult Mono.Messaging.IMessageQueue.BeginReceive() { throw null; }
        System.IAsyncResult Mono.Messaging.IMessageQueue.BeginReceive(System.TimeSpan timeout) { throw null; }
        System.IAsyncResult Mono.Messaging.IMessageQueue.BeginReceive(System.TimeSpan timeout, object stateObject) { throw null; }
        System.IAsyncResult Mono.Messaging.IMessageQueue.BeginReceive(System.TimeSpan timeout, object stateObject, System.AsyncCallback callback) { throw null; }
        Mono.Messaging.IMessage Mono.Messaging.IMessageQueue.EndPeek(System.IAsyncResult asyncResult) { throw null; }
        Mono.Messaging.IMessage Mono.Messaging.IMessageQueue.EndReceive(System.IAsyncResult asyncResult) { throw null; }
        void Mono.Messaging.IMessageQueue.SendPeekCompleted(System.IAsyncResult result) { }
        void Mono.Messaging.IMessageQueue.SendReceiveCompleted(System.IAsyncResult result) { }
        public Mono.Messaging.IMessage Peek() { throw null; }
        public Mono.Messaging.IMessage Peek(System.TimeSpan timeout) { throw null; }
        public Mono.Messaging.IMessage PeekByCorrelationId(string id) { throw null; }
        public Mono.Messaging.IMessage PeekByCorrelationId(string id, System.TimeSpan timeout) { throw null; }
        public Mono.Messaging.IMessage PeekById(string id) { throw null; }
        public Mono.Messaging.IMessage PeekById(string id, System.TimeSpan timeout) { throw null; }
        public void Purge() { }
        public Mono.Messaging.IMessage Receive() { throw null; }
        public Mono.Messaging.IMessage Receive(Mono.Messaging.IMessageQueueTransaction transaction) { throw null; }
        public Mono.Messaging.IMessage Receive(Mono.Messaging.MessageQueueTransactionType transactionType) { throw null; }
        public Mono.Messaging.IMessage Receive(System.TimeSpan timeout) { throw null; }
        public Mono.Messaging.IMessage Receive(System.TimeSpan timeout, Mono.Messaging.IMessageQueueTransaction transaction) { throw null; }
        public Mono.Messaging.IMessage Receive(System.TimeSpan timeout, Mono.Messaging.MessageQueueTransactionType transactionType) { throw null; }
        public Mono.Messaging.IMessage ReceiveByCorrelationId(string id) { throw null; }
        public Mono.Messaging.IMessage ReceiveByCorrelationId(string id, Mono.Messaging.IMessageQueueTransaction transaction) { throw null; }
        public Mono.Messaging.IMessage ReceiveByCorrelationId(string id, Mono.Messaging.MessageQueueTransactionType transactionType) { throw null; }
        public Mono.Messaging.IMessage ReceiveByCorrelationId(string id, System.TimeSpan timeout) { throw null; }
        public Mono.Messaging.IMessage ReceiveByCorrelationId(string id, System.TimeSpan timeout, Mono.Messaging.IMessageQueueTransaction transaction) { throw null; }
        public Mono.Messaging.IMessage ReceiveByCorrelationId(string id, System.TimeSpan timeout, Mono.Messaging.MessageQueueTransactionType transactionType) { throw null; }
        public Mono.Messaging.IMessage ReceiveById(string id) { throw null; }
        public Mono.Messaging.IMessage ReceiveById(string id, Mono.Messaging.IMessageQueueTransaction transaction) { throw null; }
        public Mono.Messaging.IMessage ReceiveById(string id, Mono.Messaging.MessageQueueTransactionType transactionType) { throw null; }
        public Mono.Messaging.IMessage ReceiveById(string id, System.TimeSpan timeout) { throw null; }
        public Mono.Messaging.IMessage ReceiveById(string id, System.TimeSpan timeout, Mono.Messaging.IMessageQueueTransaction transaction) { throw null; }
        public Mono.Messaging.IMessage ReceiveById(string id, System.TimeSpan timeout, Mono.Messaging.MessageQueueTransactionType transactionType) { throw null; }
        public void Send(Mono.Messaging.IMessage msg) { }
        public void Send(Mono.Messaging.IMessage msg, Mono.Messaging.IMessageQueueTransaction transaction) { }
        public void Send(Mono.Messaging.IMessage msg, Mono.Messaging.MessageQueueTransactionType transactionType) { }
    }
    public partial class RabbitMQMessageQueueTransaction : Mono.Messaging.IMessageQueueTransaction, Mono.Messaging.RabbitMQ.IMessagingContext, System.IDisposable
    {
        public RabbitMQMessageQueueTransaction(string txId, Mono.Messaging.RabbitMQ.MessagingContextPool contextPool) { }
        public string Id { get { throw null; } }
        public Mono.Messaging.MessageQueueTransactionStatus Status { get { throw null; } }
        public void Abort() { }
        public void Begin() { }
        public void Commit() { }
        public void Delete(Mono.Messaging.QueueReference qRef) { }
        public void Dispose() { }
        protected virtual void Dispose(bool disposing) { }
        public void Purge(Mono.Messaging.QueueReference qRef) { }
        public Mono.Messaging.IMessage Receive(Mono.Messaging.QueueReference qRef, System.TimeSpan timeout, Mono.Messaging.RabbitMQ.IsMatch matcher, bool ack) { throw null; }
        public void Send(Mono.Messaging.QueueReference qRef, Mono.Messaging.IMessage msg) { }
    }
    public partial class RabbitMQMessagingProvider : Mono.Messaging.IMessagingProvider
    {
        public RabbitMQMessagingProvider() { }
        public Mono.Messaging.RabbitMQ.IMessagingContext CreateContext(string host) { throw null; }
        public Mono.Messaging.IMessage CreateMessage() { throw null; }
        public Mono.Messaging.IMessageQueue CreateMessageQueue(Mono.Messaging.QueueReference qRef, bool transactional) { throw null; }
        public Mono.Messaging.IMessageQueueTransaction CreateMessageQueueTransaction() { throw null; }
        public void DeleteQueue(Mono.Messaging.QueueReference qRef) { }
        public bool Exists(Mono.Messaging.QueueReference qRef) { throw null; }
        public Mono.Messaging.IMessageQueue GetMessageQueue(Mono.Messaging.QueueReference qRef) { throw null; }
        public Mono.Messaging.IMessageQueue[] GetPublicQueues() { throw null; }
    }
}
