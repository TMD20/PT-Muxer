// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

[assembly:System.Reflection.AssemblyVersionAttribute("4.0.0.0")]
[assembly:System.CLSCompliantAttribute(true)]
[assembly:System.Reflection.AssemblyCompanyAttribute("MONO development team")]
[assembly:System.Reflection.AssemblyConfigurationAttribute("Development version")]
[assembly:System.Reflection.AssemblyCopyrightAttribute("(c) 2003 Various Authors")]
[assembly:System.Reflection.AssemblyDefaultAliasAttribute("System.Runtime.DurableInstancing.dll")]
[assembly:System.Reflection.AssemblyDescriptionAttribute("System.Runtime.DurableInstancing.dll")]
[assembly:System.Reflection.AssemblyInformationalVersionAttribute("3.5.594.0")]
[assembly:System.Reflection.AssemblyProductAttribute("MONO CLI")]
[assembly:System.Reflection.AssemblyTitleAttribute("System.Runtime.DurableInstancing.dll")]
[assembly:System.Reflection.AssemblyTrademarkAttribute("")]
[assembly:System.Resources.NeutralResourcesLanguageAttribute("en-US")]
[assembly:System.Resources.SatelliteContractVersionAttribute("4.0.0.0")]
[assembly:System.Runtime.CompilerServices.ReferenceAssemblyAttribute]
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
}
namespace System.Runtime.DurableInstancing
{
    [System.SerializableAttribute]
    public partial class InstanceCollisionException : System.Runtime.DurableInstancing.InstancePersistenceCommandException
    {
        public InstanceCollisionException() { }
        protected InstanceCollisionException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
        public InstanceCollisionException(string msg) { }
        public InstanceCollisionException(string msg, System.Exception inner) { }
    }
    [System.SerializableAttribute]
    public partial class InstanceCompleteException : System.Runtime.DurableInstancing.InstancePersistenceCommandException
    {
        public InstanceCompleteException() { }
        protected InstanceCompleteException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
        public InstanceCompleteException(string msg) { }
        public InstanceCompleteException(string msg, System.Exception inner) { }
    }
    public sealed partial class InstanceHandle
    {
        internal InstanceHandle() { }
        public bool IsValid { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        public void Free() { }
    }
    [System.SerializableAttribute]
    public partial class InstanceHandleConflictException : System.Runtime.DurableInstancing.InstancePersistenceCommandException
    {
        public InstanceHandleConflictException() { }
        protected InstanceHandleConflictException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
        public InstanceHandleConflictException(string msg) { }
        public InstanceHandleConflictException(string msg, System.Exception inner) { }
    }
    public partial class InstanceKey
    {
        public InstanceKey(System.Guid value) { }
        public InstanceKey(System.Guid value, System.Collections.Generic.IDictionary<System.Xml.Linq.XName, System.Runtime.DurableInstancing.InstanceValue> metadata) { }
        public static System.Runtime.DurableInstancing.InstanceKey InvalidKey { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        public bool IsValid { get { throw null; } }
        public System.Collections.Generic.IDictionary<System.Xml.Linq.XName, System.Runtime.DurableInstancing.InstanceValue> Metadata { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        public System.Guid Value { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        public override bool Equals(object obj) { throw null; }
        public override int GetHashCode() { throw null; }
    }
    [System.SerializableAttribute]
    public partial class InstanceKeyCollisionException : System.Runtime.DurableInstancing.InstancePersistenceCommandException
    {
        public InstanceKeyCollisionException() { }
        protected InstanceKeyCollisionException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
        public InstanceKeyCollisionException(string msg) { }
        public InstanceKeyCollisionException(string msg, System.Exception inner) { }
    }
    [System.SerializableAttribute]
    public partial class InstanceKeyCompleteException : System.Runtime.DurableInstancing.InstancePersistenceCommandException
    {
        public InstanceKeyCompleteException() { }
        protected InstanceKeyCompleteException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
        public InstanceKeyCompleteException(string msg) { }
        public InstanceKeyCompleteException(string msg, System.Exception inner) { }
    }
    [System.SerializableAttribute]
    public partial class InstanceKeyNotReadyException : System.Runtime.DurableInstancing.InstancePersistenceCommandException
    {
        public InstanceKeyNotReadyException() { }
        protected InstanceKeyNotReadyException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
        public InstanceKeyNotReadyException(string msg) { }
        public InstanceKeyNotReadyException(string msg, System.Exception inner) { }
    }
    public enum InstanceKeyState
    {
        Associated = 1,
        Completed = 2,
        Unknown = 0,
    }
    public sealed partial class InstanceKeyView
    {
        internal InstanceKeyView() { }
        public System.Guid InstanceKey { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        public System.Collections.Generic.IDictionary<System.Xml.Linq.XName, System.Runtime.DurableInstancing.InstanceValue> InstanceKeyMetadata { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        public System.Runtime.DurableInstancing.InstanceValueConsistency InstanceKeyMetadataConsistency { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        public System.Runtime.DurableInstancing.InstanceKeyState InstanceKeyState { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
    }
    [System.SerializableAttribute]
    public partial class InstanceLockedException : System.Runtime.DurableInstancing.InstancePersistenceCommandException
    {
        public InstanceLockedException() { }
        protected InstanceLockedException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
        public InstanceLockedException(string msg) { }
        public InstanceLockedException(string msg, System.Exception inner) { }
    }
    [System.SerializableAttribute]
    public partial class InstanceLockLostException : System.Runtime.DurableInstancing.InstancePersistenceCommandException
    {
        public InstanceLockLostException() { }
        protected InstanceLockLostException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
        public InstanceLockLostException(string msg) { }
        public InstanceLockLostException(string msg, System.Exception inner) { }
    }
    public sealed partial class InstanceLockQueryResult : System.Runtime.DurableInstancing.InstanceStoreQueryResult
    {
        public InstanceLockQueryResult() { }
        public InstanceLockQueryResult(System.Collections.Generic.IDictionary<System.Guid, System.Guid> instanceOwnerIds) { }
        public InstanceLockQueryResult(System.Guid instanceId, System.Guid instanceOwnerId) { }
        public System.Collections.Generic.IDictionary<System.Guid, System.Guid> InstanceOwnerIds { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
    }
    [System.SerializableAttribute]
    public partial class InstanceNotReadyException : System.Runtime.DurableInstancing.InstancePersistenceCommandException
    {
        public InstanceNotReadyException() { }
        protected InstanceNotReadyException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
        public InstanceNotReadyException(string msg) { }
        public InstanceNotReadyException(string msg, System.Exception inner) { }
    }
    public sealed partial class InstanceOwner
    {
        internal InstanceOwner() { }
        public System.Guid InstanceOwnerId { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
    }
    [System.SerializableAttribute]
    public partial class InstanceOwnerException : System.Runtime.DurableInstancing.InstancePersistenceException
    {
        public InstanceOwnerException() { }
        protected InstanceOwnerException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
        public InstanceOwnerException(string msg) { }
        public InstanceOwnerException(string msg, System.Exception inner) { }
    }
    public sealed partial class InstanceOwnerQueryResult : System.Runtime.DurableInstancing.InstanceStoreQueryResult
    {
        public InstanceOwnerQueryResult() { }
        public InstanceOwnerQueryResult(System.Collections.Generic.IDictionary<System.Guid, System.Collections.Generic.IDictionary<System.Xml.Linq.XName, System.Runtime.DurableInstancing.InstanceValue>> instanceOwners) { }
        public InstanceOwnerQueryResult(System.Guid instanceOwnerId, System.Collections.Generic.IDictionary<System.Xml.Linq.XName, System.Runtime.DurableInstancing.InstanceValue> metadata) { }
        public System.Collections.Generic.IDictionary<System.Guid, System.Collections.Generic.IDictionary<System.Xml.Linq.XName, System.Runtime.DurableInstancing.InstanceValue>> InstanceOwners { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
    }
    public abstract partial class InstancePersistenceCommand
    {
        protected InstancePersistenceCommand(System.Xml.Linq.XName name) { }
        protected internal virtual bool AutomaticallyAcquiringLock { get { throw null; } }
        protected internal virtual bool IsTransactionEnlistmentOptional { get { throw null; } }
        public System.Xml.Linq.XName Name { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        protected internal virtual void Validate(System.Runtime.DurableInstancing.InstanceView view) { }
    }
    [System.SerializableAttribute]
    public partial class InstancePersistenceCommandException : System.Runtime.DurableInstancing.InstancePersistenceException
    {
        public InstancePersistenceCommandException() { }
        protected InstancePersistenceCommandException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
        public InstancePersistenceCommandException(string msg) { }
        public InstancePersistenceCommandException(string msg, System.Exception inner) { }
    }
    public sealed partial class InstancePersistenceContext
    {
        internal InstancePersistenceContext() { }
        public System.Runtime.DurableInstancing.InstanceHandle InstanceHandle { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        public long InstanceVersion { get { throw null; } }
        public System.Runtime.DurableInstancing.InstanceView InstanceView { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        public System.Guid LockToken { get { throw null; } }
        public object UserContext { get { throw null; } }
        public void AssociatedInstanceKey(System.Guid key) { }
        public System.IAsyncResult BeginBindReclaimedLock(long instanceVersion, System.TimeSpan timeout, System.AsyncCallback callback, object state) { throw null; }
        public System.IAsyncResult BeginExecute(System.Runtime.DurableInstancing.InstancePersistenceCommand command, System.TimeSpan timeout, System.AsyncCallback callback, object state) { throw null; }
        public void BindAcquiredLock(long instanceVersion) { }
        public void BindEvent(System.Runtime.DurableInstancing.InstancePersistenceEvent persistenceEvent) { }
        public void BindInstance(System.Guid instanceId) { }
        public void BindInstanceOwner(System.Guid instanceOwnerId, System.Guid lockToken) { }
        public void BindReclaimedLock(long instanceVersion, System.TimeSpan timeout) { }
        public void CompletedInstance() { }
        public void CompletedInstanceKey(System.Guid key) { }
        public System.Exception CreateBindReclaimedLockException(long instanceVersion) { throw null; }
        public void EndBindReclaimedLock(System.IAsyncResult result) { }
        public void EndExecute(System.IAsyncResult result) { }
        public void Execute(System.Runtime.DurableInstancing.InstancePersistenceCommand command, System.TimeSpan timeout) { }
        public void LoadedInstance(System.Runtime.DurableInstancing.InstanceState state, System.Collections.Generic.IDictionary<System.Xml.Linq.XName, System.Runtime.DurableInstancing.InstanceValue> instanceData, System.Collections.Generic.IDictionary<System.Xml.Linq.XName, System.Runtime.DurableInstancing.InstanceValue> instanceMetadata, System.Collections.Generic.IDictionary<System.Guid, System.Collections.Generic.IDictionary<System.Xml.Linq.XName, System.Runtime.DurableInstancing.InstanceValue>> associatedInstanceKeyMetadata, System.Collections.Generic.IDictionary<System.Guid, System.Collections.Generic.IDictionary<System.Xml.Linq.XName, System.Runtime.DurableInstancing.InstanceValue>> completedInstanceKeyMetadata) { }
        public void PersistedInstance(System.Collections.Generic.IDictionary<System.Xml.Linq.XName, System.Runtime.DurableInstancing.InstanceValue> data) { }
        public void QueriedInstanceStore(System.Runtime.DurableInstancing.InstanceStoreQueryResult queryResult) { }
        public void ReadInstanceKeyMetadata(System.Guid key, System.Collections.Generic.IDictionary<System.Xml.Linq.XName, System.Runtime.DurableInstancing.InstanceValue> metadata, bool complete) { }
        public void SetCancellationHandler(System.Action<System.Runtime.DurableInstancing.InstancePersistenceContext> cancellationHandler) { }
        public void UnassociatedInstanceKey(System.Guid key) { }
        public void WroteInstanceKeyMetadataValue(System.Guid key, System.Xml.Linq.XName name, System.Runtime.DurableInstancing.InstanceValue value) { }
        public void WroteInstanceMetadataValue(System.Xml.Linq.XName name, System.Runtime.DurableInstancing.InstanceValue value) { }
        public void WroteInstanceOwnerMetadataValue(System.Xml.Linq.XName name, System.Runtime.DurableInstancing.InstanceValue value) { }
    }
    public abstract partial class InstancePersistenceEvent : System.IEquatable<System.Runtime.DurableInstancing.InstancePersistenceEvent>
    {
        internal InstancePersistenceEvent() { }
        public System.Xml.Linq.XName Name { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        public override bool Equals(object obj) { throw null; }
        public bool Equals(System.Runtime.DurableInstancing.InstancePersistenceEvent persistenceEvent) { throw null; }
        public override int GetHashCode() { throw null; }
        public static bool operator ==(System.Runtime.DurableInstancing.InstancePersistenceEvent left, System.Runtime.DurableInstancing.InstancePersistenceEvent right) { throw null; }
        public static bool operator !=(System.Runtime.DurableInstancing.InstancePersistenceEvent left, System.Runtime.DurableInstancing.InstancePersistenceEvent right) { throw null; }
    }
    public abstract partial class InstancePersistenceEvent<T> : System.Runtime.DurableInstancing.InstancePersistenceEvent where T : System.Runtime.DurableInstancing.InstancePersistenceEvent<T>, new()
    {
        protected InstancePersistenceEvent(System.Xml.Linq.XName name) { }
        public static T Value { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
    }
    [System.SerializableAttribute]
    public partial class InstancePersistenceException : System.Exception
    {
        public InstancePersistenceException() { }
        protected InstancePersistenceException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
        public InstancePersistenceException(string msg) { }
        public InstancePersistenceException(string msg, System.Exception inner) { }
    }
    public enum InstanceState
    {
        Completed = 3,
        Initialized = 2,
        Uninitialized = 1,
        Unknown = 0,
    }
    public abstract partial class InstanceStore
    {
        protected InstanceStore() { }
        public System.Runtime.DurableInstancing.InstanceOwner DefaultInstanceOwner { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public System.IAsyncResult BeginExecute(System.Runtime.DurableInstancing.InstanceHandle handle, System.Runtime.DurableInstancing.InstancePersistenceCommand command, System.TimeSpan timeout, System.AsyncCallback callback, object state) { throw null; }
        protected internal virtual System.IAsyncResult BeginTryCommand(System.Runtime.DurableInstancing.InstancePersistenceContext context, System.Runtime.DurableInstancing.InstancePersistenceCommand command, System.TimeSpan timeout, System.AsyncCallback callback, object state) { throw null; }
        public System.IAsyncResult BeginWaitForEvents(System.Runtime.DurableInstancing.InstanceHandle handle, System.TimeSpan timeout, System.AsyncCallback callback, object state) { throw null; }
        public System.Runtime.DurableInstancing.InstanceHandle CreateInstanceHandle() { throw null; }
        public System.Runtime.DurableInstancing.InstanceHandle CreateInstanceHandle(System.Guid instanceId) { throw null; }
        public System.Runtime.DurableInstancing.InstanceHandle CreateInstanceHandle(System.Runtime.DurableInstancing.InstanceOwner owner) { throw null; }
        public System.Runtime.DurableInstancing.InstanceHandle CreateInstanceHandle(System.Runtime.DurableInstancing.InstanceOwner owner, System.Guid instanceId) { throw null; }
        public System.Runtime.DurableInstancing.InstanceView EndExecute(System.IAsyncResult result) { throw null; }
        public bool EndTryCommand(System.IAsyncResult result) { throw null; }
        public System.Collections.Generic.List<System.Runtime.DurableInstancing.InstancePersistenceEvent> EndWaitForEvents(System.IAsyncResult result) { throw null; }
        public System.Runtime.DurableInstancing.InstanceView Execute(System.Runtime.DurableInstancing.InstanceHandle handle, System.Runtime.DurableInstancing.InstancePersistenceCommand command, System.TimeSpan timeout) { throw null; }
        protected System.Runtime.DurableInstancing.InstancePersistenceEvent[] GetEvents(System.Runtime.DurableInstancing.InstanceOwner owner) { throw null; }
        protected System.Runtime.DurableInstancing.InstanceOwner[] GetInstanceOwners() { throw null; }
        protected virtual void OnFreeInstanceHandle(System.Runtime.DurableInstancing.InstanceHandle instanceHandle, object userContext) { }
        protected virtual object OnNewInstanceHandle(System.Runtime.DurableInstancing.InstanceHandle instanceHandle) { throw null; }
        protected void ResetEvent(System.Runtime.DurableInstancing.InstancePersistenceEvent persistenceEvent, System.Runtime.DurableInstancing.InstanceOwner owner) { }
        protected void SignalEvent(System.Runtime.DurableInstancing.InstancePersistenceEvent persistenceEvent, System.Runtime.DurableInstancing.InstanceOwner owner) { }
        protected internal virtual bool TryCommand(System.Runtime.DurableInstancing.InstancePersistenceContext context, System.Runtime.DurableInstancing.InstancePersistenceCommand command, System.TimeSpan timeout) { throw null; }
        public System.Collections.Generic.List<System.Runtime.DurableInstancing.InstancePersistenceEvent> WaitForEvents(System.Runtime.DurableInstancing.InstanceHandle handle, System.TimeSpan timeout) { throw null; }
    }
    public abstract partial class InstanceStoreQueryResult
    {
        protected InstanceStoreQueryResult() { }
    }
    public sealed partial class InstanceValue
    {
        public InstanceValue(object value) { }
        public InstanceValue(object value, System.Runtime.DurableInstancing.InstanceValueOptions options) { }
        public static System.Runtime.DurableInstancing.InstanceValue DeletedValue { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        public bool IsDeletedValue { get { throw null; } }
        public System.Runtime.DurableInstancing.InstanceValueOptions Options { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        public object Value { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
    }
    [System.FlagsAttribute]
    public enum InstanceValueConsistency
    {
        InDoubt = 1,
        None = 0,
        Partial = 2,
    }
    [System.FlagsAttribute]
    public enum InstanceValueOptions
    {
        None = 0,
        Optional = 1,
        WriteOnly = 2,
    }
    public sealed partial class InstanceView
    {
        internal InstanceView() { }
        public System.Collections.Generic.IDictionary<System.Xml.Linq.XName, System.Runtime.DurableInstancing.InstanceValue> InstanceData { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        public System.Runtime.DurableInstancing.InstanceValueConsistency InstanceDataConsistency { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        public System.Guid InstanceId { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        public System.Collections.Generic.IDictionary<System.Guid, System.Runtime.DurableInstancing.InstanceKeyView> InstanceKeys { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        public System.Runtime.DurableInstancing.InstanceValueConsistency InstanceKeysConsistency { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        public System.Collections.Generic.IDictionary<System.Xml.Linq.XName, System.Runtime.DurableInstancing.InstanceValue> InstanceMetadata { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        public System.Runtime.DurableInstancing.InstanceValueConsistency InstanceMetadataConsistency { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        public System.Runtime.DurableInstancing.InstanceOwner InstanceOwner { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        public System.Collections.Generic.IDictionary<System.Xml.Linq.XName, System.Runtime.DurableInstancing.InstanceValue> InstanceOwnerMetadata { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        public System.Runtime.DurableInstancing.InstanceValueConsistency InstanceOwnerMetadataConsistency { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        public System.Runtime.DurableInstancing.InstanceState InstanceState { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        public System.Collections.ObjectModel.ReadOnlyCollection<System.Runtime.DurableInstancing.InstanceStoreQueryResult> InstanceStoreQueryResults { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        public bool IsBoundToInstance { get { throw null; } }
        public bool IsBoundToInstanceOwner { get { throw null; } }
        public bool IsBoundToLock { get { throw null; } }
    }
}
