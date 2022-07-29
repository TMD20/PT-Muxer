// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

[assembly:System.Reflection.AssemblyVersionAttribute("2.0.5.0")]
[assembly:System.CLSCompliantAttribute(true)]
[assembly:System.Diagnostics.DebuggableAttribute(System.Diagnostics.DebuggableAttribute.DebuggingModes.IgnoreSymbolStoreSequencePoints)]
[assembly:System.Reflection.AssemblyCompanyAttribute("Mono development team")]
[assembly:System.Reflection.AssemblyCopyrightAttribute("(c) Various Mono authors")]
[assembly:System.Reflection.AssemblyDefaultAliasAttribute("System.ServiceModel.dll")]
[assembly:System.Reflection.AssemblyDescriptionAttribute("System.ServiceModel.dll")]
[assembly:System.Reflection.AssemblyFileVersionAttribute("4.0.50524.0")]
[assembly:System.Reflection.AssemblyInformationalVersionAttribute("4.0.50524.0")]
[assembly:System.Reflection.AssemblyProductAttribute("Mono Common Language Infrastructure")]
[assembly:System.Reflection.AssemblyTitleAttribute("System.ServiceModel.dll")]
[assembly:System.Resources.NeutralResourcesLanguageAttribute("en-US")]
[assembly:System.Resources.SatelliteContractVersionAttribute("2.0.5.0")]
[assembly:System.Runtime.CompilerServices.CompilationRelaxationsAttribute(8)]
[assembly:System.Runtime.CompilerServices.RuntimeCompatibilityAttribute(WrapNonExceptionThrows=true)]
[assembly:System.Runtime.InteropServices.ComVisibleAttribute(false)]
[assembly:System.Security.Permissions.SecurityPermissionAttribute(System.Security.Permissions.SecurityAction.RequestMinimum, SkipVerification=true)]
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
}
namespace System.Collections.Generic
{
    public partial class KeyedByTypeCollection<TItem> : System.Collections.ObjectModel.KeyedCollection<System.Type, TItem>
    {
        public KeyedByTypeCollection() { }
        public KeyedByTypeCollection(System.Collections.Generic.IEnumerable<TItem> items) { }
        public System.Collections.ObjectModel.Collection<T> FindAll<T>() { throw null; }
        public T Find<T>() { throw null; }
        protected override System.Type GetKeyForItem(TItem item) { throw null; }
        protected override void InsertItem(int index, TItem item) { }
        public System.Collections.ObjectModel.Collection<T> RemoveAll<T>() { throw null; }
        public T Remove<T>() { throw null; }
        protected override void SetItem(int index, TItem item) { }
    }
    [System.Runtime.InteropServices.ComVisibleAttribute(false)]
    public partial class SynchronizedCollection<T> : System.Collections.Generic.ICollection<T>, System.Collections.Generic.IEnumerable<T>, System.Collections.Generic.IList<T>, System.Collections.ICollection, System.Collections.IEnumerable, System.Collections.IList
    {
        public SynchronizedCollection() { }
        public SynchronizedCollection(object syncRoot) { }
        public SynchronizedCollection(object syncRoot, System.Collections.Generic.IEnumerable<T> list) { }
        public SynchronizedCollection(object syncRoot, params T[] list) { }
        public int Count { get { throw null; } }
        public T this[int index] { get { throw null; } set { } }
        protected System.Collections.Generic.List<T> Items { get { throw null; } }
        public object SyncRoot { get { throw null; } }
        bool System.Collections.Generic.ICollection<T>.IsReadOnly { get { throw null; } }
        bool System.Collections.ICollection.IsSynchronized { get { throw null; } }
        object System.Collections.ICollection.SyncRoot { get { throw null; } }
        bool System.Collections.IList.IsFixedSize { get { throw null; } }
        bool System.Collections.IList.IsReadOnly { get { throw null; } }
        object System.Collections.IList.this[int index] { get { throw null; } set { } }
        public void Add(T item) { }
        public void Clear() { }
        protected virtual void ClearItems() { }
        public bool Contains(T item) { throw null; }
        public void CopyTo(T[] array, int index) { }
        public System.Collections.Generic.IEnumerator<T> GetEnumerator() { throw null; }
        public int IndexOf(T item) { throw null; }
        public void Insert(int index, T item) { }
        protected virtual void InsertItem(int index, T item) { }
        public bool Remove(T item) { throw null; }
        public void RemoveAt(int index) { }
        protected virtual void RemoveItem(int index) { }
        protected virtual void SetItem(int index, T item) { }
        void System.Collections.ICollection.CopyTo(System.Array array, int index) { }
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { throw null; }
        int System.Collections.IList.Add(object value) { throw null; }
        bool System.Collections.IList.Contains(object value) { throw null; }
        int System.Collections.IList.IndexOf(object value) { throw null; }
        void System.Collections.IList.Insert(int index, object value) { }
        void System.Collections.IList.Remove(object value) { }
    }
    [System.Runtime.InteropServices.ComVisibleAttribute(false)]
    public abstract partial class SynchronizedKeyedCollection<K, T> : System.Collections.Generic.SynchronizedCollection<T>
    {
        protected SynchronizedKeyedCollection() { }
        protected SynchronizedKeyedCollection(object syncRoot) { }
        protected SynchronizedKeyedCollection(object syncRoot, System.Collections.Generic.IEqualityComparer<K> comparer) { }
        protected SynchronizedKeyedCollection(object syncRoot, System.Collections.Generic.IEqualityComparer<K> comparer, int dictionaryCreationThreshold) { }
        protected System.Collections.Generic.IDictionary<K, T> Dictionary { get { throw null; } }
        public T this[K key] { get { throw null; } }
        protected void ChangeItemKey(T item, K newKey) { }
        protected override void ClearItems() { }
        public bool Contains(K key) { throw null; }
        protected abstract K GetKeyForItem(T item);
        protected override void InsertItem(int index, T item) { }
        public bool Remove(K key) { throw null; }
        protected override void RemoveItem(int index) { }
        protected override void SetItem(int index, T item) { }
    }
    [System.Runtime.InteropServices.ComVisibleAttribute(false)]
    public partial class SynchronizedReadOnlyCollection<T> : System.Collections.Generic.ICollection<T>, System.Collections.Generic.IEnumerable<T>, System.Collections.Generic.IList<T>, System.Collections.ICollection, System.Collections.IEnumerable, System.Collections.IList
    {
        public SynchronizedReadOnlyCollection() { }
        public SynchronizedReadOnlyCollection(object syncRoot) { }
        public SynchronizedReadOnlyCollection(object syncRoot, System.Collections.Generic.IEnumerable<T> list) { }
        public SynchronizedReadOnlyCollection(object syncRoot, params T[] list) { }
        public int Count { get { throw null; } }
        public T this[int index] { get { throw null; } }
        protected System.Collections.Generic.IList<T> Items { get { throw null; } }
        bool System.Collections.Generic.ICollection<T>.IsReadOnly { get { throw null; } }
        T System.Collections.Generic.IList<T>.this[int index] { get { throw null; } set { } }
        bool System.Collections.ICollection.IsSynchronized { get { throw null; } }
        object System.Collections.ICollection.SyncRoot { get { throw null; } }
        bool System.Collections.IList.IsFixedSize { get { throw null; } }
        bool System.Collections.IList.IsReadOnly { get { throw null; } }
        object System.Collections.IList.this[int index] { get { throw null; } set { } }
        public bool Contains(T value) { throw null; }
        public void CopyTo(T[] array, int index) { }
        public System.Collections.Generic.IEnumerator<T> GetEnumerator() { throw null; }
        public int IndexOf(T value) { throw null; }
        void System.Collections.Generic.ICollection<T>.Add(T value) { }
        void System.Collections.Generic.ICollection<T>.Clear() { }
        bool System.Collections.Generic.ICollection<T>.Remove(T value) { throw null; }
        void System.Collections.Generic.IList<T>.Insert(int index, T value) { }
        void System.Collections.Generic.IList<T>.RemoveAt(int index) { }
        void System.Collections.ICollection.CopyTo(System.Array array, int index) { }
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { throw null; }
        int System.Collections.IList.Add(object value) { throw null; }
        void System.Collections.IList.Clear() { }
        bool System.Collections.IList.Contains(object value) { throw null; }
        int System.Collections.IList.IndexOf(object value) { throw null; }
        void System.Collections.IList.Insert(int index, object value) { }
        void System.Collections.IList.Remove(object value) { }
        void System.Collections.IList.RemoveAt(int index) { }
    }
}
namespace System.ServiceModel
{
    [System.SerializableAttribute]
    public partial class ActionNotSupportedException : System.ServiceModel.CommunicationException
    {
        public ActionNotSupportedException() { }
        protected ActionNotSupportedException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
        public ActionNotSupportedException(string message) { }
        public ActionNotSupportedException(string message, System.Exception innerException) { }
    }
    public enum AddressFilterMode
    {
        Any = 2,
        Exact = 0,
        Prefix = 1,
    }
    public enum AuditLevel
    {
        Failure = 2,
        None = 0,
        Success = 1,
        SuccessOrFailure = 3,
    }
    public enum AuditLogLocation
    {
        Application = 1,
        Default = 0,
        Security = 2,
    }
    public partial class BasicHttpBinding : System.ServiceModel.HttpBindingBase, System.ServiceModel.Channels.IBindingRuntimePreferences
    {
        public BasicHttpBinding() { }
        public BasicHttpBinding(System.ServiceModel.BasicHttpSecurityMode securityMode) { }
        public System.ServiceModel.WSMessageEncoding MessageEncoding { get { throw null; } set { } }
        public override string Scheme { get { throw null; } }
        public System.ServiceModel.BasicHttpSecurity Security { get { throw null; } set { } }
        public override System.ServiceModel.Channels.BindingElementCollection CreateBindingElements() { throw null; }
    }
    public enum BasicHttpMessageCredentialType
    {
        Certificate = 1,
        UserName = 0,
    }
    [System.MonoTODOAttribute]
    public sealed partial class BasicHttpMessageSecurity
    {
        internal BasicHttpMessageSecurity() { }
        public System.ServiceModel.BasicHttpMessageCredentialType ClientCredentialType { get { throw null; } set { } }
    }
    public partial class BasicHttpsBinding : System.ServiceModel.HttpBindingBase, System.ServiceModel.Channels.IBindingRuntimePreferences
    {
        public BasicHttpsBinding() { }
        public BasicHttpsBinding(System.ServiceModel.BasicHttpsSecurityMode securityMode) { }
        public System.ServiceModel.WSMessageEncoding MessageEncoding { get { throw null; } set { } }
        public override string Scheme { get { throw null; } }
        public System.ServiceModel.BasicHttpsSecurity Security { get { throw null; } set { } }
        public override System.ServiceModel.Channels.BindingElementCollection CreateBindingElements() { throw null; }
    }
    public sealed partial class BasicHttpSecurity
    {
        public BasicHttpSecurity() { }
        public System.ServiceModel.BasicHttpMessageSecurity Message { get { throw null; } set { } }
        public System.ServiceModel.BasicHttpSecurityMode Mode { get { throw null; } set { } }
        public System.ServiceModel.HttpTransportSecurity Transport { get { throw null; } set { } }
    }
    public enum BasicHttpSecurityMode
    {
        Message = 2,
        None = 0,
        Transport = 1,
        TransportCredentialOnly = 4,
        TransportWithMessageCredential = 3,
    }
    public sealed partial class BasicHttpsSecurity
    {
        public BasicHttpsSecurity() { }
        public System.ServiceModel.BasicHttpMessageSecurity Message { get { throw null; } }
        public System.ServiceModel.BasicHttpsSecurityMode Mode { get { throw null; } set { } }
        public System.ServiceModel.HttpTransportSecurity Transport { get { throw null; } set { } }
    }
    public enum BasicHttpsSecurityMode
    {
        Transport = 0,
        TransportWithMessageCredential = 1,
    }
    [System.AttributeUsageAttribute(System.AttributeTargets.Class)]
    public sealed partial class CallbackBehaviorAttribute : System.Attribute, System.ServiceModel.Description.IEndpointBehavior
    {
        public CallbackBehaviorAttribute() { }
        [System.MonoTODOAttribute]
        public bool AutomaticSessionShutdown { get { throw null; } set { } }
        [System.MonoTODOAttribute]
        public System.ServiceModel.ConcurrencyMode ConcurrencyMode { get { throw null; } set { } }
        [System.MonoTODOAttribute]
        public bool IgnoreExtensionDataObject { get { throw null; } set { } }
        [System.MonoTODOAttribute]
        public bool IncludeExceptionDetailInFaults { get { throw null; } set { } }
        [System.MonoTODOAttribute]
        public int MaxItemsInObjectGraph { get { throw null; } set { } }
        [System.MonoTODOAttribute]
        public string TransactionTimeout { get { throw null; } set { } }
        [System.MonoTODOAttribute]
        public bool UseSynchronizationContext { get { throw null; } set { } }
        [System.MonoTODOAttribute]
        public bool ValidateMustUnderstand { get { throw null; } set { } }
        void System.ServiceModel.Description.IEndpointBehavior.AddBindingParameters(System.ServiceModel.Description.ServiceEndpoint endpoint, System.ServiceModel.Channels.BindingParameterCollection parameters) { }
        [System.MonoTODOAttribute]
        void System.ServiceModel.Description.IEndpointBehavior.ApplyClientBehavior(System.ServiceModel.Description.ServiceEndpoint serviceEndpoint, System.ServiceModel.Dispatcher.ClientRuntime behavior) { }
        void System.ServiceModel.Description.IEndpointBehavior.ApplyDispatchBehavior(System.ServiceModel.Description.ServiceEndpoint serviceEndpoint, System.ServiceModel.Dispatcher.EndpointDispatcher dispatcher) { }
        [System.MonoTODOAttribute]
        void System.ServiceModel.Description.IEndpointBehavior.Validate(System.ServiceModel.Description.ServiceEndpoint serviceEndpoint) { }
    }
    public abstract partial class ChannelFactory : System.ServiceModel.Channels.CommunicationObject, System.IDisposable, System.ServiceModel.Channels.IChannelFactory, System.ServiceModel.ICommunicationObject
    {
        protected ChannelFactory() { }
        public System.ServiceModel.Description.ClientCredentials Credentials { get { throw null; } }
        protected internal override System.TimeSpan DefaultCloseTimeout { get { throw null; } }
        protected internal override System.TimeSpan DefaultOpenTimeout { get { throw null; } }
        public System.ServiceModel.Description.ServiceEndpoint Endpoint { get { throw null; } }
        protected virtual void ApplyConfiguration(string configurationName) { }
        protected abstract System.ServiceModel.Description.ServiceEndpoint CreateDescription();
        protected virtual System.ServiceModel.Channels.IChannelFactory CreateFactory() { throw null; }
        protected void EnsureOpened() { }
        public T GetProperty<T>() where T : class { throw null; }
        protected void InitializeEndpoint(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress address) { }
        protected void InitializeEndpoint(System.ServiceModel.Description.ServiceEndpoint endpoint) { }
        protected void InitializeEndpoint(string configurationName, System.ServiceModel.EndpointAddress address) { }
        protected override void OnAbort() { }
        protected override System.IAsyncResult OnBeginClose(System.TimeSpan timeout, System.AsyncCallback callback, object state) { throw null; }
        protected override System.IAsyncResult OnBeginOpen(System.TimeSpan timeout, System.AsyncCallback callback, object state) { throw null; }
        protected override void OnClose(System.TimeSpan timeout) { }
        protected override void OnEndClose(System.IAsyncResult result) { }
        protected override void OnEndOpen(System.IAsyncResult result) { }
        protected override void OnOpen(System.TimeSpan timeout) { }
        protected override void OnOpened() { }
        protected override void OnOpening() { }
        void System.IDisposable.Dispose() { }
    }
    public partial class ChannelFactory<TChannel> : System.ServiceModel.ChannelFactory, System.ServiceModel.Channels.IChannelFactory, System.ServiceModel.Channels.IChannelFactory<TChannel>, System.ServiceModel.ICommunicationObject
    {
        public ChannelFactory() { }
        public ChannelFactory(System.ServiceModel.Channels.Binding binding) { }
        public ChannelFactory(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) { }
        public ChannelFactory(System.ServiceModel.Channels.Binding binding, string remoteAddress) { }
        public ChannelFactory(System.ServiceModel.Description.ServiceEndpoint endpoint) { }
        public ChannelFactory(string endpointConfigurationName) { }
        public ChannelFactory(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) { }
        protected ChannelFactory(System.Type channelType) { }
        public TChannel CreateChannel() { throw null; }
        public static TChannel CreateChannel(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress endpointAddress) { throw null; }
        public static TChannel CreateChannel(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress endpointAddress, System.Uri via) { throw null; }
        public TChannel CreateChannel(System.ServiceModel.EndpointAddress address) { throw null; }
        public virtual TChannel CreateChannel(System.ServiceModel.EndpointAddress address, System.Uri via) { throw null; }
        protected static TChannel CreateChannel(string endpointConfigurationName) { throw null; }
        protected override System.ServiceModel.Description.ServiceEndpoint CreateDescription() { throw null; }
    }
    [System.MonoTODOAttribute("It somehow rejects classes, but dunno how we can do that besides our code wise.")]
    public abstract partial class ClientBase<TChannel> : System.IDisposable, System.ServiceModel.ICommunicationObject where TChannel : class
    {
        protected ClientBase() { }
        protected ClientBase(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) { }
        protected ClientBase(System.ServiceModel.Description.ServiceEndpoint endpoint) { }
        protected ClientBase(System.ServiceModel.InstanceContext callbackInstance) { }
        protected ClientBase(System.ServiceModel.InstanceContext callbackInstance, System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) { }
        protected ClientBase(System.ServiceModel.InstanceContext callbackInstance, System.ServiceModel.Description.ServiceEndpoint endpoint) { }
        protected ClientBase(System.ServiceModel.InstanceContext callbackInstance, string endpointConfigurationName) { }
        protected ClientBase(System.ServiceModel.InstanceContext callbackInstance, string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) { }
        protected ClientBase(System.ServiceModel.InstanceContext callbackInstance, string endpointConfigurationName, string remoteAddress) { }
        protected ClientBase(string endpointConfigurationName) { }
        protected ClientBase(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) { }
        protected ClientBase(string endpointConfigurationName, string remoteAddress) { }
        protected TChannel Channel { get { throw null; } }
        public System.ServiceModel.ChannelFactory<TChannel> ChannelFactory { get { throw null; } }
        public System.ServiceModel.Description.ClientCredentials ClientCredentials { get { throw null; } }
        public System.ServiceModel.Description.ServiceEndpoint Endpoint { get { throw null; } }
        public System.ServiceModel.IClientChannel InnerChannel { get { throw null; } }
        public System.ServiceModel.CommunicationState State { get { throw null; } }
        event System.EventHandler System.ServiceModel.ICommunicationObject.Closed { add { } remove { } }
        event System.EventHandler System.ServiceModel.ICommunicationObject.Closing { add { } remove { } }
        event System.EventHandler System.ServiceModel.ICommunicationObject.Faulted { add { } remove { } }
        event System.EventHandler System.ServiceModel.ICommunicationObject.Opened { add { } remove { } }
        event System.EventHandler System.ServiceModel.ICommunicationObject.Opening { add { } remove { } }
        public void Abort() { }
        public void Close() { }
        protected virtual TChannel CreateChannel() { throw null; }
        public void DisplayInitializationUI() { }
        protected T GetDefaultValueForInitialization<T>() { throw null; }
        protected void InvokeAsync(System.ServiceModel.ClientBase<TChannel>.BeginOperationDelegate beginOperationDelegate, object[] inValues, System.ServiceModel.ClientBase<TChannel>.EndOperationDelegate endOperationDelegate, System.Threading.SendOrPostCallback operationCompletedCallback, object userState) { }
        public void Open() { }
        void System.IDisposable.Dispose() { }
        System.IAsyncResult System.ServiceModel.ICommunicationObject.BeginClose(System.AsyncCallback callback, object state) { throw null; }
        System.IAsyncResult System.ServiceModel.ICommunicationObject.BeginClose(System.TimeSpan timeout, System.AsyncCallback callback, object state) { throw null; }
        System.IAsyncResult System.ServiceModel.ICommunicationObject.BeginOpen(System.AsyncCallback callback, object state) { throw null; }
        System.IAsyncResult System.ServiceModel.ICommunicationObject.BeginOpen(System.TimeSpan timeout, System.AsyncCallback callback, object state) { throw null; }
        void System.ServiceModel.ICommunicationObject.Close(System.TimeSpan timeout) { }
        void System.ServiceModel.ICommunicationObject.EndClose(System.IAsyncResult result) { }
        void System.ServiceModel.ICommunicationObject.EndOpen(System.IAsyncResult result) { }
        void System.ServiceModel.ICommunicationObject.Open(System.TimeSpan timeout) { }
        protected delegate System.IAsyncResult BeginOperationDelegate(object[] inValues, System.AsyncCallback asyncCallback, object state);
        protected internal partial class ChannelBase<T> : System.IDisposable, System.ServiceModel.Channels.IChannel, System.ServiceModel.Channels.IOutputChannel, System.ServiceModel.Channels.IRequestChannel, System.ServiceModel.IClientChannel, System.ServiceModel.ICommunicationObject, System.ServiceModel.IContextChannel, System.ServiceModel.IExtensibleObject<System.ServiceModel.IContextChannel> where T : class
        {
            protected ChannelBase(System.ServiceModel.ClientBase<T> client) { }
            public bool AllowInitializationUI { get { throw null; } set { } }
            [System.MonoTODOAttribute]
            public bool AllowOutputBatching { get { throw null; } set { } }
            public bool DidInteractiveInitialization { get { throw null; } }
            [System.MonoTODOAttribute]
            public System.ServiceModel.Channels.IInputSession InputSession { get { throw null; } }
            public System.ServiceModel.EndpointAddress LocalAddress { get { throw null; } }
            [System.MonoTODOAttribute]
            public System.TimeSpan OperationTimeout { get { throw null; } set { } }
            [System.MonoTODOAttribute]
            public System.ServiceModel.Channels.IOutputSession OutputSession { get { throw null; } }
            public System.ServiceModel.EndpointAddress RemoteAddress { get { throw null; } }
            [System.MonoTODOAttribute]
            public string SessionId { get { throw null; } }
            System.ServiceModel.EndpointAddress System.ServiceModel.Channels.IRequestChannel.RemoteAddress { get { throw null; } }
            System.Uri System.ServiceModel.Channels.IRequestChannel.Via { get { throw null; } }
            System.ServiceModel.CommunicationState System.ServiceModel.ICommunicationObject.State { get { throw null; } }
            System.ServiceModel.IExtensionCollection<System.ServiceModel.IContextChannel> System.ServiceModel.IExtensibleObject<System.ServiceModel.IContextChannel>.Extensions { get { throw null; } }
            public System.Uri Via { get { throw null; } }
            event System.EventHandler System.ServiceModel.ICommunicationObject.Closed { add { } remove { } }
            event System.EventHandler System.ServiceModel.ICommunicationObject.Closing { add { } remove { } }
            event System.EventHandler System.ServiceModel.ICommunicationObject.Faulted { add { } remove { } }
            event System.EventHandler System.ServiceModel.ICommunicationObject.Opened { add { } remove { } }
            event System.EventHandler System.ServiceModel.ICommunicationObject.Opening { add { } remove { } }
            public event System.EventHandler<System.ServiceModel.UnknownMessageReceivedEventArgs> UnknownMessageReceived { add { } remove { } }
            public System.IAsyncResult BeginDisplayInitializationUI(System.AsyncCallback callback, object state) { throw null; }
            protected System.IAsyncResult BeginInvoke(string methodName, object[] args, System.AsyncCallback callback, object state) { throw null; }
            public void DisplayInitializationUI() { }
            public void Dispose() { }
            public void EndDisplayInitializationUI(System.IAsyncResult result) { }
            protected object EndInvoke(string methodName, object[] args, System.IAsyncResult result) { throw null; }
            protected object Invoke(string methodName, object[] args) { throw null; }
            TProperty System.ServiceModel.Channels.IChannel.GetProperty<TProperty>() { throw null; }
            System.IAsyncResult System.ServiceModel.Channels.IOutputChannel.BeginSend(System.ServiceModel.Channels.Message message, System.AsyncCallback callback, object state) { throw null; }
            System.IAsyncResult System.ServiceModel.Channels.IOutputChannel.BeginSend(System.ServiceModel.Channels.Message message, System.TimeSpan timeout, System.AsyncCallback callback, object state) { throw null; }
            void System.ServiceModel.Channels.IOutputChannel.EndSend(System.IAsyncResult result) { }
            void System.ServiceModel.Channels.IOutputChannel.Send(System.ServiceModel.Channels.Message message) { }
            void System.ServiceModel.Channels.IOutputChannel.Send(System.ServiceModel.Channels.Message message, System.TimeSpan timeout) { }
            System.IAsyncResult System.ServiceModel.Channels.IRequestChannel.BeginRequest(System.ServiceModel.Channels.Message message, System.AsyncCallback callback, object state) { throw null; }
            System.IAsyncResult System.ServiceModel.Channels.IRequestChannel.BeginRequest(System.ServiceModel.Channels.Message message, System.TimeSpan timeout, System.AsyncCallback callback, object state) { throw null; }
            System.ServiceModel.Channels.Message System.ServiceModel.Channels.IRequestChannel.EndRequest(System.IAsyncResult result) { throw null; }
            System.ServiceModel.Channels.Message System.ServiceModel.Channels.IRequestChannel.Request(System.ServiceModel.Channels.Message message) { throw null; }
            System.ServiceModel.Channels.Message System.ServiceModel.Channels.IRequestChannel.Request(System.ServiceModel.Channels.Message message, System.TimeSpan timeout) { throw null; }
            void System.ServiceModel.ICommunicationObject.Abort() { }
            System.IAsyncResult System.ServiceModel.ICommunicationObject.BeginClose(System.AsyncCallback callback, object state) { throw null; }
            System.IAsyncResult System.ServiceModel.ICommunicationObject.BeginClose(System.TimeSpan timeout, System.AsyncCallback callback, object state) { throw null; }
            System.IAsyncResult System.ServiceModel.ICommunicationObject.BeginOpen(System.AsyncCallback callback, object state) { throw null; }
            System.IAsyncResult System.ServiceModel.ICommunicationObject.BeginOpen(System.TimeSpan timeout, System.AsyncCallback callback, object state) { throw null; }
            void System.ServiceModel.ICommunicationObject.Close() { }
            void System.ServiceModel.ICommunicationObject.Close(System.TimeSpan timeout) { }
            void System.ServiceModel.ICommunicationObject.EndClose(System.IAsyncResult result) { }
            void System.ServiceModel.ICommunicationObject.EndOpen(System.IAsyncResult result) { }
            void System.ServiceModel.ICommunicationObject.Open() { }
            void System.ServiceModel.ICommunicationObject.Open(System.TimeSpan timeout) { }
        }
        protected delegate object[] EndOperationDelegate(System.IAsyncResult result);
        protected partial class InvokeAsyncCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs
        {
            internal InvokeAsyncCompletedEventArgs() : base (default(System.Exception), default(bool), default(object)) { }
            public object[] Results { get { throw null; } }
        }
    }
    [System.SerializableAttribute]
    public partial class CommunicationException : System.SystemException
    {
        public CommunicationException() { }
        protected CommunicationException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
        public CommunicationException(string message) { }
        public CommunicationException(string message, System.Exception innerException) { }
    }
    [System.SerializableAttribute]
    public partial class CommunicationObjectAbortedException : System.ServiceModel.CommunicationException
    {
        public CommunicationObjectAbortedException() { }
        protected CommunicationObjectAbortedException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
        public CommunicationObjectAbortedException(string message) { }
        public CommunicationObjectAbortedException(string message, System.Exception innerException) { }
    }
    [System.SerializableAttribute]
    public partial class CommunicationObjectFaultedException : System.ServiceModel.CommunicationException
    {
        public CommunicationObjectFaultedException() { }
        protected CommunicationObjectFaultedException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
        public CommunicationObjectFaultedException(string message) { }
        public CommunicationObjectFaultedException(string message, System.Exception innerException) { }
    }
    public enum CommunicationState
    {
        Closed = 4,
        Closing = 3,
        Created = 0,
        Faulted = 5,
        Opened = 2,
        Opening = 1,
    }
    public enum ConcurrencyMode
    {
        Multiple = 2,
        Reentrant = 1,
        Single = 0,
    }
    [System.AttributeUsageAttribute(System.AttributeTargets.Class | System.AttributeTargets.Interface | System.AttributeTargets.Method, Inherited=false)]
    public sealed partial class DataContractFormatAttribute : System.Attribute
    {
        public DataContractFormatAttribute() { }
        public System.ServiceModel.OperationFormatStyle Style { get { throw null; } set { } }
    }
    public enum DeadLetterQueue
    {
        Custom = 2,
        None = 0,
        System = 1,
    }
    public partial class DnsEndpointIdentity : System.ServiceModel.EndpointIdentity
    {
        public DnsEndpointIdentity(string dnsName) { }
    }
    public partial class DuplexChannelFactory<TChannel> : System.ServiceModel.ChannelFactory<TChannel>
    {
        public DuplexChannelFactory(object callbackObject) { }
        public DuplexChannelFactory(object callbackObject, System.ServiceModel.Channels.Binding binding) { }
        public DuplexChannelFactory(object callbackObject, System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) { }
        public DuplexChannelFactory(object callbackObject, System.ServiceModel.Channels.Binding binding, string remoteAddress) { }
        public DuplexChannelFactory(object callbackObject, System.ServiceModel.Description.ServiceEndpoint endpoint) { }
        public DuplexChannelFactory(object callbackObject, string endpointConfigurationName) { }
        public DuplexChannelFactory(object callbackObject, string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) { }
        public DuplexChannelFactory(System.ServiceModel.InstanceContext callbackInstance) { }
        public DuplexChannelFactory(System.ServiceModel.InstanceContext callbackInstance, System.ServiceModel.Channels.Binding binding) { }
        public DuplexChannelFactory(System.ServiceModel.InstanceContext callbackInstance, System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) { }
        public DuplexChannelFactory(System.ServiceModel.InstanceContext callbackInstance, System.ServiceModel.Channels.Binding binding, string remoteAddress) { }
        public DuplexChannelFactory(System.ServiceModel.InstanceContext callbackInstance, System.ServiceModel.Description.ServiceEndpoint endpoint) { }
        public DuplexChannelFactory(System.ServiceModel.InstanceContext callbackInstance, string endpointConfigurationName) { }
        public DuplexChannelFactory(System.ServiceModel.InstanceContext callbackInstance, string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) { }
        public DuplexChannelFactory(System.Type callbackInstanceType) { }
        public DuplexChannelFactory(System.Type callbackInstanceType, System.ServiceModel.Channels.Binding binding) { }
        public DuplexChannelFactory(System.Type callbackInstanceType, System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) { }
        public DuplexChannelFactory(System.Type callbackInstanceType, System.ServiceModel.Channels.Binding binding, string remoteAddress) { }
        public DuplexChannelFactory(System.Type callbackInstanceType, System.ServiceModel.Description.ServiceEndpoint endpoint) { }
        public DuplexChannelFactory(System.Type callbackInstanceType, string endpointConfigurationName) { }
        public DuplexChannelFactory(System.Type callbackInstanceType, string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) { }
        public static TChannel CreateChannel(object callbackObject, System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress endpointAddress) { throw null; }
        public static TChannel CreateChannel(object callbackObject, System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress endpointAddress, System.Uri via) { throw null; }
        public static TChannel CreateChannel(object callbackObject, string endpointConfigurationName) { throw null; }
        public override TChannel CreateChannel(System.ServiceModel.EndpointAddress address, System.Uri via) { throw null; }
        public TChannel CreateChannel(System.ServiceModel.InstanceContext callbackInstance) { throw null; }
        public static TChannel CreateChannel(System.ServiceModel.InstanceContext callbackInstance, System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress endpointAddress) { throw null; }
        public static TChannel CreateChannel(System.ServiceModel.InstanceContext callbackInstance, System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress endpointAddress, System.Uri via) { throw null; }
        public TChannel CreateChannel(System.ServiceModel.InstanceContext callbackInstance, System.ServiceModel.EndpointAddress address) { throw null; }
        public virtual TChannel CreateChannel(System.ServiceModel.InstanceContext callbackInstance, System.ServiceModel.EndpointAddress address, System.Uri via) { throw null; }
        public static TChannel CreateChannel(System.ServiceModel.InstanceContext callbackInstance, string endpointConfigurationName) { throw null; }
    }
    public partial class DuplexClientBase<TChannel> : System.ServiceModel.ClientBase<TChannel> where TChannel : class
    {
        protected DuplexClientBase(object callbackInstance) { }
        protected DuplexClientBase(object callbackInstance, System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) { }
        protected DuplexClientBase(object callbackInstance, System.ServiceModel.Description.ServiceEndpoint endpoint) { }
        protected DuplexClientBase(object callbackInstance, string endpointConfigurationName) { }
        protected DuplexClientBase(object callbackInstance, string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) { }
        protected DuplexClientBase(object callbackInstance, string endpointConfigurationName, string remoteAddress) { }
        protected DuplexClientBase(System.ServiceModel.InstanceContext callbackInstance) { }
        protected DuplexClientBase(System.ServiceModel.InstanceContext callbackInstance, System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) { }
        protected DuplexClientBase(System.ServiceModel.InstanceContext callbackInstance, System.ServiceModel.Description.ServiceEndpoint endpoint) { }
        protected DuplexClientBase(System.ServiceModel.InstanceContext callbackInstance, string endpointConfigurationName) { }
        protected DuplexClientBase(System.ServiceModel.InstanceContext callbackInstance, string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) { }
        protected DuplexClientBase(System.ServiceModel.InstanceContext callbackInstance, string endpointConfigurationName, string remoteAddress) { }
        public System.ServiceModel.IDuplexContextChannel InnerDuplexChannel { get { throw null; } }
        protected override TChannel CreateChannel() { throw null; }
    }
    public partial class EndpointAddress
    {
        public EndpointAddress(string uri) { }
        public EndpointAddress(System.Uri uri, params System.ServiceModel.Channels.AddressHeader[] addressHeaders) { }
        public EndpointAddress(System.Uri uri, System.ServiceModel.EndpointIdentity identity, System.ServiceModel.Channels.AddressHeaderCollection headers) { }
        public EndpointAddress(System.Uri uri, System.ServiceModel.EndpointIdentity identity, System.ServiceModel.Channels.AddressHeaderCollection headers, System.Xml.XmlDictionaryReader metadataReader, System.Xml.XmlDictionaryReader extensionReader) { }
        public EndpointAddress(System.Uri uri, System.ServiceModel.EndpointIdentity identity, params System.ServiceModel.Channels.AddressHeader[] addressHeaders) { }
        public static System.Uri AnonymousUri { get { throw null; } }
        public System.ServiceModel.Channels.AddressHeaderCollection Headers { get { throw null; } }
        public System.ServiceModel.EndpointIdentity Identity { get { throw null; } }
        public bool IsAnonymous { get { throw null; } }
        public bool IsNone { get { throw null; } }
        public static System.Uri NoneUri { get { throw null; } }
        public System.Uri Uri { get { throw null; } }
        [System.MonoTODOAttribute]
        public void ApplyTo(System.ServiceModel.Channels.Message message) { }
        public override bool Equals(object obj) { throw null; }
        public override int GetHashCode() { throw null; }
        public System.Xml.XmlDictionaryReader GetReaderAtExtensions() { throw null; }
        public System.Xml.XmlDictionaryReader GetReaderAtMetadata() { throw null; }
        public static bool operator ==(System.ServiceModel.EndpointAddress address1, System.ServiceModel.EndpointAddress address2) { throw null; }
        public static bool operator !=(System.ServiceModel.EndpointAddress address1, System.ServiceModel.EndpointAddress address2) { throw null; }
        public static System.ServiceModel.EndpointAddress ReadFrom(System.ServiceModel.Channels.AddressingVersion addressingVersion, System.Xml.XmlDictionaryReader reader) { throw null; }
        public static System.ServiceModel.EndpointAddress ReadFrom(System.ServiceModel.Channels.AddressingVersion addressingVersion, System.Xml.XmlDictionaryReader reader, System.Xml.XmlDictionaryString localName, System.Xml.XmlDictionaryString ns) { throw null; }
        public static System.ServiceModel.EndpointAddress ReadFrom(System.ServiceModel.Channels.AddressingVersion addressingVersion, System.Xml.XmlReader reader) { throw null; }
        public static System.ServiceModel.EndpointAddress ReadFrom(System.ServiceModel.Channels.AddressingVersion addressingVersion, System.Xml.XmlReader reader, string localName, string ns) { throw null; }
        public static System.ServiceModel.EndpointAddress ReadFrom(System.Xml.XmlDictionaryReader reader) { throw null; }
        public static System.ServiceModel.EndpointAddress ReadFrom(System.Xml.XmlDictionaryReader reader, System.Xml.XmlDictionaryString localName, System.Xml.XmlDictionaryString ns) { throw null; }
        public override string ToString() { throw null; }
        public void WriteContentsTo(System.ServiceModel.Channels.AddressingVersion addressingVersion, System.Xml.XmlDictionaryWriter writer) { }
        public void WriteContentsTo(System.ServiceModel.Channels.AddressingVersion addressingVersion, System.Xml.XmlWriter writer) { }
        public void WriteTo(System.ServiceModel.Channels.AddressingVersion addressingVersion, System.Xml.XmlDictionaryWriter writer) { }
        public void WriteTo(System.ServiceModel.Channels.AddressingVersion addressingVersion, System.Xml.XmlDictionaryWriter writer, System.Xml.XmlDictionaryString localName, System.Xml.XmlDictionaryString ns) { }
        public void WriteTo(System.ServiceModel.Channels.AddressingVersion addressingVersion, System.Xml.XmlWriter writer) { }
        public void WriteTo(System.ServiceModel.Channels.AddressingVersion addressingVersion, System.Xml.XmlWriter writer, string localName, string ns) { }
    }
    public partial class EndpointAddressBuilder
    {
        public EndpointAddressBuilder() { }
        public EndpointAddressBuilder(System.ServiceModel.EndpointAddress address) { }
        public System.Collections.ObjectModel.Collection<System.ServiceModel.Channels.AddressHeader> Headers { get { throw null; } }
        public System.ServiceModel.EndpointIdentity Identity { get { throw null; } set { } }
        public System.Uri Uri { get { throw null; } set { } }
        public System.ServiceModel.EndpointAddress ToEndpointAddress() { throw null; }
    }
    public partial class EndpointIdentity
    {
        public EndpointIdentity() { }
    }
    [System.SerializableAttribute]
    public partial class EndpointNotFoundException : System.ServiceModel.CommunicationException
    {
        public EndpointNotFoundException() { }
        protected EndpointNotFoundException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
        public EndpointNotFoundException(string message) { }
        public EndpointNotFoundException(string message, System.Exception innerException) { }
    }
    public sealed partial class EnvelopeVersion
    {
        internal EnvelopeVersion() { }
        public string NextDestinationActorValue { get { throw null; } }
        public static System.ServiceModel.EnvelopeVersion None { get { throw null; } }
        public static System.ServiceModel.EnvelopeVersion Soap11 { get { throw null; } }
        public static System.ServiceModel.EnvelopeVersion Soap12 { get { throw null; } }
        public string[] GetUltimateDestinationActorValues() { throw null; }
        public override string ToString() { throw null; }
    }
    [System.Runtime.Serialization.DataContractAttribute]
    public partial class ExceptionDetail
    {
        public ExceptionDetail(System.Exception exception) { }
        [System.Runtime.Serialization.DataMemberAttribute]
        public string HelpLink { get { throw null; } set { } }
        [System.Runtime.Serialization.DataMemberAttribute]
        public System.ServiceModel.ExceptionDetail InnerException { get { throw null; } set { } }
        [System.Runtime.Serialization.DataMemberAttribute]
        public string Message { get { throw null; } set { } }
        [System.Runtime.Serialization.DataMemberAttribute]
        public string StackTrace { get { throw null; } set { } }
        [System.Runtime.Serialization.DataMemberAttribute]
        public string Type { get { throw null; } set { } }
        public override string ToString() { throw null; }
    }
    public sealed partial class ExtensionCollection<T> : System.Collections.Generic.SynchronizedCollection<System.ServiceModel.IExtension<T>>, System.Collections.Generic.ICollection<System.ServiceModel.IExtension<T>>, System.Collections.Generic.IEnumerable<System.ServiceModel.IExtension<T>>, System.Collections.IEnumerable, System.ServiceModel.IExtensionCollection<T> where T : System.ServiceModel.IExtensibleObject<T>
    {
        public ExtensionCollection(T owner) { }
        public ExtensionCollection(T owner, object syncRoot) { }
        bool System.Collections.Generic.ICollection<System.ServiceModel.IExtension<T>>.IsReadOnly { get { throw null; } }
        [System.MonoTODOAttribute]
        protected override void ClearItems() { }
        public System.Collections.ObjectModel.Collection<E> FindAll<E>() { throw null; }
        public E Find<E>() { throw null; }
        [System.MonoTODOAttribute]
        protected override void InsertItem(int index, System.ServiceModel.IExtension<T> item) { }
        [System.MonoTODOAttribute]
        protected override void RemoveItem(int index) { }
        [System.MonoTODOAttribute]
        protected override void SetItem(int index, System.ServiceModel.IExtension<T> item) { }
    }
    public partial class FaultCode
    {
        public FaultCode(string name) { }
        public FaultCode(string name, System.ServiceModel.FaultCode subCode) { }
        public FaultCode(string name, string ns) { }
        public FaultCode(string name, string ns, System.ServiceModel.FaultCode subCode) { }
        public bool IsPredefinedFault { get { throw null; } }
        public bool IsReceiverFault { get { throw null; } }
        public bool IsSenderFault { get { throw null; } }
        public string Name { get { throw null; } }
        public string Namespace { get { throw null; } }
        public System.ServiceModel.FaultCode SubCode { get { throw null; } }
        public static System.ServiceModel.FaultCode CreateReceiverFaultCode(System.ServiceModel.FaultCode subCode) { throw null; }
        public static System.ServiceModel.FaultCode CreateReceiverFaultCode(string name, string ns) { throw null; }
        public static System.ServiceModel.FaultCode CreateSenderFaultCode(System.ServiceModel.FaultCode subCode) { throw null; }
        public static System.ServiceModel.FaultCode CreateSenderFaultCode(string name, string ns) { throw null; }
    }
    [System.AttributeUsageAttribute(System.AttributeTargets.Method, Inherited=false, AllowMultiple=true)]
    public sealed partial class FaultContractAttribute : System.Attribute
    {
        public FaultContractAttribute(System.Type detailType) { }
        public string Action { get { throw null; } set { } }
        public System.Type DetailType { get { throw null; } }
        public bool HasProtectionLevel { get { throw null; } }
        public string Name { get { throw null; } set { } }
        public string Namespace { get { throw null; } set { } }
        public System.Net.Security.ProtectionLevel ProtectionLevel { get { throw null; } set { } }
    }
    [System.SerializableAttribute]
    public partial class FaultException : System.ServiceModel.CommunicationException
    {
        public FaultException() { }
        [System.MonoTODOAttribute]
        protected FaultException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
        [System.MonoTODOAttribute]
        public FaultException(System.ServiceModel.Channels.MessageFault fault) { }
        public FaultException(System.ServiceModel.Channels.MessageFault fault, string action) { }
        [System.MonoTODOAttribute]
        public FaultException(System.ServiceModel.FaultReason reason) { }
        public FaultException(System.ServiceModel.FaultReason reason, System.ServiceModel.FaultCode code) { }
        public FaultException(System.ServiceModel.FaultReason reason, System.ServiceModel.FaultCode code, string action) { }
        public FaultException(string reason) { }
        public FaultException(string reason, System.ServiceModel.FaultCode code) { }
        public FaultException(string reason, System.ServiceModel.FaultCode code, string action) { }
        public string Action { get { throw null; } }
        public System.ServiceModel.FaultCode Code { get { throw null; } }
        public override string Message { get { throw null; } }
        public System.ServiceModel.FaultReason Reason { get { throw null; } }
        [System.MonoTODOAttribute]
        public static System.ServiceModel.FaultException CreateFault(System.ServiceModel.Channels.MessageFault messageFault, string action, params System.Type[] faultDetailTypes) { throw null; }
        [System.MonoTODOAttribute]
        public static System.ServiceModel.FaultException CreateFault(System.ServiceModel.Channels.MessageFault messageFault, params System.Type[] faultDetailTypes) { throw null; }
        public virtual System.ServiceModel.Channels.MessageFault CreateMessageFault() { throw null; }
        [System.MonoTODOAttribute]
        public override void GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
    }
    [System.SerializableAttribute]
    public partial class FaultException<TDetail> : System.ServiceModel.FaultException
    {
        [System.MonoTODOAttribute]
        protected FaultException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
        public FaultException(TDetail detail) { }
        public FaultException(TDetail detail, System.ServiceModel.FaultReason reason) { }
        public FaultException(TDetail detail, System.ServiceModel.FaultReason reason, System.ServiceModel.FaultCode code) { }
        public FaultException(TDetail detail, System.ServiceModel.FaultReason reason, System.ServiceModel.FaultCode code, string action) { }
        public FaultException(TDetail detail, string reason) { }
        public FaultException(TDetail detail, string reason, System.ServiceModel.FaultCode code) { }
        public FaultException(TDetail detail, string reason, System.ServiceModel.FaultCode code, string action) { }
        public TDetail Detail { get { throw null; } }
        public override System.ServiceModel.Channels.MessageFault CreateMessageFault() { throw null; }
        [System.MonoTODOAttribute("see FaultException.TestGetObjectData to see how it's serialized")]
        public override void GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
        public override string ToString() { throw null; }
    }
    public partial class FaultReason
    {
        public FaultReason(System.Collections.Generic.IEnumerable<System.ServiceModel.FaultReasonText> translations) { }
        public FaultReason(System.ServiceModel.FaultReasonText translation) { }
        public FaultReason(string text) { }
        public System.Collections.Generic.SynchronizedReadOnlyCollection<System.ServiceModel.FaultReasonText> Translations { get { throw null; } }
        public System.ServiceModel.FaultReasonText GetMatchingTranslation() { throw null; }
        public System.ServiceModel.FaultReasonText GetMatchingTranslation(System.Globalization.CultureInfo cultureInfo) { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class FaultReasonText
    {
        public FaultReasonText(string text) { }
        public FaultReasonText(string text, System.Globalization.CultureInfo cultureInfo) { }
        public FaultReasonText(string text, string xmlLang) { }
        public string Text { get { throw null; } }
        public string XmlLang { get { throw null; } }
        public bool Matches(System.Globalization.CultureInfo cultureInfo) { throw null; }
    }
    public enum HostNameComparisonMode
    {
        Exact = 1,
        StrongWildcard = 0,
        WeakWildcard = 2,
    }
    public abstract partial class HttpBindingBase : System.ServiceModel.Channels.Binding, System.ServiceModel.Channels.IBindingRuntimePreferences
    {
        protected HttpBindingBase() { }
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
        bool System.ServiceModel.Channels.IBindingRuntimePreferences.ReceiveSynchronously { get { throw null; } }
        public System.Text.Encoding TextEncoding { get { throw null; } set { } }
        public System.ServiceModel.TransferMode TransferMode { get { throw null; } set { } }
        public bool UseDefaultWebProxy { get { throw null; } set { } }
        public abstract override System.ServiceModel.Channels.BindingElementCollection CreateBindingElements();
    }
    public enum HttpClientCredentialType
    {
        Basic = 1,
        Certificate = 5,
        Digest = 2,
        InheritedFromHost = 6,
        None = 0,
        Ntlm = 3,
        Windows = 4,
    }
    public enum HttpProxyCredentialType
    {
        Basic = 1,
        Digest = 2,
        None = 0,
        Ntlm = 3,
        Windows = 4,
    }
    public sealed partial class HttpTransportSecurity
    {
        public HttpTransportSecurity() { }
        public System.ServiceModel.HttpClientCredentialType ClientCredentialType { get { throw null; } set { } }
        [System.MonoTODOAttribute]
        public System.Security.Authentication.ExtendedProtection.ExtendedProtectionPolicy ExtendedProtectionPolicy { get { throw null; } set { } }
        public System.ServiceModel.HttpProxyCredentialType ProxyCredentialType { get { throw null; } set { } }
        public string Realm { get { throw null; } set { } }
    }
    public partial interface IClientChannel : System.IDisposable, System.ServiceModel.Channels.IChannel, System.ServiceModel.ICommunicationObject, System.ServiceModel.IContextChannel, System.ServiceModel.IExtensibleObject<System.ServiceModel.IContextChannel>
    {
        bool AllowInitializationUI { get; set; }
        bool DidInteractiveInitialization { get; }
        System.Uri Via { get; }
        event System.EventHandler<System.ServiceModel.UnknownMessageReceivedEventArgs> UnknownMessageReceived;
        System.IAsyncResult BeginDisplayInitializationUI(System.AsyncCallback callback, object state);
        void DisplayInitializationUI();
        void EndDisplayInitializationUI(System.IAsyncResult result);
    }
    public partial interface ICommunicationObject
    {
        System.ServiceModel.CommunicationState State { get; }
        event System.EventHandler Closed;
        event System.EventHandler Closing;
        event System.EventHandler Faulted;
        event System.EventHandler Opened;
        event System.EventHandler Opening;
        void Abort();
        System.IAsyncResult BeginClose(System.AsyncCallback callback, object state);
        System.IAsyncResult BeginClose(System.TimeSpan timeout, System.AsyncCallback callback, object state);
        System.IAsyncResult BeginOpen(System.AsyncCallback callback, object state);
        System.IAsyncResult BeginOpen(System.TimeSpan timeout, System.AsyncCallback callback, object state);
        void Close();
        void Close(System.TimeSpan timeout);
        void EndClose(System.IAsyncResult result);
        void EndOpen(System.IAsyncResult result);
        void Open();
        void Open(System.TimeSpan timeout);
    }
    public partial interface IContextChannel : System.ServiceModel.Channels.IChannel, System.ServiceModel.ICommunicationObject, System.ServiceModel.IExtensibleObject<System.ServiceModel.IContextChannel>
    {
        bool AllowOutputBatching { get; set; }
        System.ServiceModel.Channels.IInputSession InputSession { get; }
        System.ServiceModel.EndpointAddress LocalAddress { get; }
        System.TimeSpan OperationTimeout { get; set; }
        System.ServiceModel.Channels.IOutputSession OutputSession { get; }
        System.ServiceModel.EndpointAddress RemoteAddress { get; }
        string SessionId { get; }
    }
    public partial interface IDefaultCommunicationTimeouts
    {
        System.TimeSpan CloseTimeout { get; }
        System.TimeSpan OpenTimeout { get; }
        System.TimeSpan ReceiveTimeout { get; }
        System.TimeSpan SendTimeout { get; }
    }
    public partial interface IDuplexContextChannel : System.ServiceModel.Channels.IChannel, System.ServiceModel.ICommunicationObject, System.ServiceModel.IContextChannel, System.ServiceModel.IExtensibleObject<System.ServiceModel.IContextChannel>
    {
        bool AutomaticInputSessionShutdown { get; set; }
        System.ServiceModel.InstanceContext CallbackInstance { get; set; }
        System.IAsyncResult BeginCloseOutputSession(System.TimeSpan timeout, System.AsyncCallback callback, object state);
        void CloseOutputSession(System.TimeSpan timeout);
        void EndCloseOutputSession(System.IAsyncResult result);
    }
    public partial interface IExtensibleObject<T> where T : System.ServiceModel.IExtensibleObject<T>
    {
        System.ServiceModel.IExtensionCollection<T> Extensions { get; }
    }
    public partial interface IExtensionCollection<T> : System.Collections.Generic.ICollection<System.ServiceModel.IExtension<T>>, System.Collections.Generic.IEnumerable<System.ServiceModel.IExtension<T>>, System.Collections.IEnumerable where T : System.ServiceModel.IExtensibleObject<T>
    {
        System.Collections.ObjectModel.Collection<E> FindAll<E>();
        E Find<E>();
    }
    public partial interface IExtension<T> where T : System.ServiceModel.IExtensibleObject<T>
    {
        void Attach(T owner);
        void Detach(T owner);
    }
    public enum ImpersonationOption
    {
        Allowed = 1,
        NotAllowed = 0,
        Required = 2,
    }
    public partial class InstanceContext : System.ServiceModel.Channels.CommunicationObject, System.ServiceModel.IExtensibleObject<System.ServiceModel.InstanceContext>
    {
        public InstanceContext(object implementation) { }
        protected internal override System.TimeSpan DefaultCloseTimeout { get { throw null; } }
        protected internal override System.TimeSpan DefaultOpenTimeout { get { throw null; } }
        public System.ServiceModel.IExtensionCollection<System.ServiceModel.InstanceContext> Extensions { get { throw null; } }
        public System.Threading.SynchronizationContext SynchronizationContext { get { throw null; } set { } }
        public object GetServiceInstance(System.ServiceModel.Channels.Message message) { throw null; }
        protected override void OnAbort() { }
        protected override System.IAsyncResult OnBeginClose(System.TimeSpan timeout, System.AsyncCallback callback, object state) { throw null; }
        protected override System.IAsyncResult OnBeginOpen(System.TimeSpan timeout, System.AsyncCallback callback, object state) { throw null; }
        protected override void OnClose(System.TimeSpan timeout) { }
        protected override void OnClosed() { }
        protected override void OnEndClose(System.IAsyncResult result) { }
        protected override void OnEndOpen(System.IAsyncResult result) { }
        protected override void OnFaulted() { }
        protected override void OnOpen(System.TimeSpan timeout) { }
        protected override void OnOpened() { }
        protected override void OnOpening() { }
    }
    public enum InstanceContextMode
    {
        PerCall = 1,
        PerSession = 0,
        Single = 2,
    }
    [System.SerializableAttribute]
    public partial class InvalidMessageContractException : System.SystemException
    {
        public InvalidMessageContractException() { }
        protected InvalidMessageContractException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
        public InvalidMessageContractException(string message) { }
        public InvalidMessageContractException(string message, System.Exception innerException) { }
    }
    [System.AttributeUsageAttribute(System.AttributeTargets.Field | System.AttributeTargets.Property, Inherited=false)]
    public partial class MessageBodyMemberAttribute : System.ServiceModel.MessageContractMemberAttribute
    {
        public MessageBodyMemberAttribute() { }
        public int Order { get { throw null; } set { } }
    }
    [System.AttributeUsageAttribute(System.AttributeTargets.Class | System.AttributeTargets.Struct)]
    public sealed partial class MessageContractAttribute : System.Attribute
    {
        public MessageContractAttribute() { }
        public bool HasProtectionLevel { get { throw null; } }
        public bool IsWrapped { get { throw null; } set { } }
        public System.Net.Security.ProtectionLevel ProtectionLevel { get { throw null; } set { } }
        public string WrapperName { get { throw null; } set { } }
        public string WrapperNamespace { get { throw null; } set { } }
    }
    public abstract partial class MessageContractMemberAttribute : System.Attribute
    {
        protected MessageContractMemberAttribute() { }
        public bool HasProtectionLevel { get { throw null; } }
        public string Name { get { throw null; } set { } }
        public string Namespace { get { throw null; } set { } }
        public System.Net.Security.ProtectionLevel ProtectionLevel { get { throw null; } set { } }
    }
    public enum MessageCredentialType
    {
        Certificate = 3,
        IssuedToken = 4,
        None = 0,
        UserName = 2,
        Windows = 1,
    }
    [System.AttributeUsageAttribute(System.AttributeTargets.Field | System.AttributeTargets.Property, Inherited=false)]
    public sealed partial class MessageHeaderArrayAttribute : System.ServiceModel.MessageHeaderAttribute
    {
        public MessageHeaderArrayAttribute() { }
    }
    [System.AttributeUsageAttribute(System.AttributeTargets.Field | System.AttributeTargets.Property, Inherited=false)]
    public partial class MessageHeaderAttribute : System.ServiceModel.MessageContractMemberAttribute
    {
        public MessageHeaderAttribute() { }
        public string Actor { get { throw null; } set { } }
        public bool MustUnderstand { get { throw null; } set { } }
        public bool Relay { get { throw null; } set { } }
    }
    [System.SerializableAttribute]
    public partial class MessageHeaderException : System.ServiceModel.ProtocolException
    {
        public MessageHeaderException() { }
        protected MessageHeaderException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
        public MessageHeaderException(string message) { }
        public MessageHeaderException(string message, bool isDuplicate) { }
        public MessageHeaderException(string message, System.Exception innerException) { }
        public MessageHeaderException(string message, string headerName, string ns) { }
        public MessageHeaderException(string message, string headerName, string ns, bool isDuplicate) { }
        public MessageHeaderException(string message, string headerName, string ns, bool isDuplicate, System.Exception innerException) { }
        public MessageHeaderException(string message, string headerName, string ns, System.Exception innerException) { }
        public string HeaderName { get { throw null; } }
        public string HeaderNamespace { get { throw null; } }
        public bool IsDuplicate { get { throw null; } }
    }
    public partial class MessageHeader<T>
    {
        public MessageHeader() { }
        public MessageHeader(T content) { }
        public MessageHeader(T content, bool mustUnderstand, string actor, bool relay) { }
        public string Actor { get { throw null; } set { } }
        public T Content { get { throw null; } set { } }
        public bool MustUnderstand { get { throw null; } set { } }
        public bool Relay { get { throw null; } set { } }
        public System.ServiceModel.Channels.MessageHeader GetUntypedHeader(string name, string ns) { throw null; }
    }
    [System.AttributeUsageAttribute(System.AttributeTargets.Parameter | System.AttributeTargets.ReturnValue, Inherited=false)]
    public sealed partial class MessageParameterAttribute : System.Attribute
    {
        public MessageParameterAttribute() { }
        public string Name { get { throw null; } set { } }
    }
    [System.AttributeUsageAttribute(System.AttributeTargets.Field | System.AttributeTargets.Property, Inherited=false)]
    public sealed partial class MessagePropertyAttribute : System.Attribute
    {
        public MessagePropertyAttribute() { }
        public string Name { get { throw null; } set { } }
    }
    public sealed partial class MessageSecurityOverTcp
    {
        public MessageSecurityOverTcp() { }
        public System.ServiceModel.MessageCredentialType ClientCredentialType { get { throw null; } set { } }
    }
    public abstract partial class MessageSecurityVersion
    {
        internal MessageSecurityVersion() { }
        public abstract System.ServiceModel.Security.BasicSecurityProfileVersion BasicSecurityProfileVersion { get; }
        public static System.ServiceModel.MessageSecurityVersion Default { get { throw null; } }
        public System.ServiceModel.Security.SecureConversationVersion SecureConversationVersion { get { throw null; } }
        public abstract System.ServiceModel.Security.SecurityPolicyVersion SecurityPolicyVersion { get; }
        public System.ServiceModel.Security.SecurityVersion SecurityVersion { get { throw null; } }
        public System.ServiceModel.Security.TrustVersion TrustVersion { get { throw null; } }
        public static System.ServiceModel.MessageSecurityVersion WSSecurity10WSTrust13WSSecureConversation13WSSecurityPolicy12BasicSecurityProfile10 { get { throw null; } }
        public static System.ServiceModel.MessageSecurityVersion WSSecurity10WSTrustFebruary2005WSSecureConversationFebruary2005WSSecurityPolicy11BasicSecurityProfile10 { get { throw null; } }
        public static System.ServiceModel.MessageSecurityVersion WSSecurity11WSTrust13WSSecureConversation13WSSecurityPolicy12 { get { throw null; } }
        public static System.ServiceModel.MessageSecurityVersion WSSecurity11WSTrust13WSSecureConversation13WSSecurityPolicy12BasicSecurityProfile10 { get { throw null; } }
        public static System.ServiceModel.MessageSecurityVersion WSSecurity11WSTrustFebruary2005WSSecureConversationFebruary2005WSSecurityPolicy11 { get { throw null; } }
        public static System.ServiceModel.MessageSecurityVersion WSSecurity11WSTrustFebruary2005WSSecureConversationFebruary2005WSSecurityPolicy11BasicSecurityProfile10 { get { throw null; } }
    }
    public enum MsmqAuthenticationMode
    {
        Certificate = 2,
        None = 0,
        WindowsDomain = 1,
    }
    public enum MsmqEncryptionAlgorithm
    {
        Aes = 1,
        RC4Stream = 0,
    }
    public enum MsmqSecureHashAlgorithm
    {
        MD5 = 0,
        Sha1 = 1,
        Sha256 = 2,
        Sha512 = 3,
    }
    [System.MonoTODOAttribute]
    public partial class NetHttpBinding : System.ServiceModel.HttpBindingBase
    {
        public NetHttpBinding() { }
        public NetHttpBinding(System.ServiceModel.BasicHttpSecurityMode securityMode) { }
        public NetHttpBinding(System.ServiceModel.BasicHttpSecurityMode securityMode, bool reliableSessionEnabled) { }
        public NetHttpBinding(string configurationName) { }
        public System.ServiceModel.NetHttpMessageEncoding MessageEncoding { get { throw null; } set { } }
        public System.ServiceModel.OptionalReliableSession ReliableSession { get { throw null; } set { } }
        public override string Scheme { get { throw null; } }
        public System.ServiceModel.BasicHttpSecurity Security { get { throw null; } set { } }
        public System.ServiceModel.Channels.WebSocketTransportSettings WebSocketSettings { get { throw null; } }
        public override System.ServiceModel.Channels.BindingElementCollection CreateBindingElements() { throw null; }
        public bool ShouldSerializeReliableSession() { throw null; }
        public bool ShouldSerializeSecurity() { throw null; }
    }
    public enum NetHttpMessageEncoding
    {
        Binary = 0,
        Mtom = 2,
        Text = 1,
    }
    [System.MonoTODOAttribute]
    public partial class NetHttpsBinding : System.ServiceModel.HttpBindingBase
    {
        public NetHttpsBinding() { }
        public NetHttpsBinding(System.ServiceModel.BasicHttpsSecurityMode securityMode) { }
        public NetHttpsBinding(System.ServiceModel.BasicHttpsSecurityMode securityMode, bool reliableSessionEnabled) { }
        public NetHttpsBinding(string configurationName) { }
        public System.ServiceModel.NetHttpMessageEncoding MessageEncoding { get { throw null; } set { } }
        public System.ServiceModel.OptionalReliableSession ReliableSession { get { throw null; } set { } }
        public override string Scheme { get { throw null; } }
        public System.ServiceModel.BasicHttpsSecurity Security { get { throw null; } set { } }
        public System.ServiceModel.Channels.WebSocketTransportSettings WebSocketSettings { get { throw null; } }
        public override System.ServiceModel.Channels.BindingElementCollection CreateBindingElements() { throw null; }
        public bool ShouldSerializeReliableSession() { throw null; }
        public bool ShouldSerializeSecurity() { throw null; }
    }
    public enum NetMsmqSecurityMode
    {
        Both = 3,
        Message = 2,
        None = 0,
        Transport = 1,
    }
    public enum NetNamedPipeSecurityMode
    {
        None = 0,
        Transport = 1,
    }
    public partial class NetTcpBinding : System.ServiceModel.Channels.Binding, System.ServiceModel.Channels.IBindingRuntimePreferences
    {
        public NetTcpBinding() { }
        public NetTcpBinding(System.ServiceModel.SecurityMode securityMode) { }
        public NetTcpBinding(System.ServiceModel.SecurityMode securityMode, bool reliableSessionEnabled) { }
        public NetTcpBinding(string configurationName) { }
        public System.ServiceModel.EnvelopeVersion EnvelopeVersion { get { throw null; } }
        public System.ServiceModel.HostNameComparisonMode HostNameComparisonMode { get { throw null; } set { } }
        public int ListenBacklog { get { throw null; } set { } }
        public long MaxBufferPoolSize { get { throw null; } set { } }
        public int MaxBufferSize { get { throw null; } set { } }
        [System.MonoTODOAttribute]
        public int MaxConnections { get { throw null; } set { } }
        public long MaxReceivedMessageSize { get { throw null; } set { } }
        public bool PortSharingEnabled { get { throw null; } set { } }
        public System.Xml.XmlDictionaryReaderQuotas ReaderQuotas { get { throw null; } set { } }
        [System.MonoTODOAttribute]
        public System.ServiceModel.OptionalReliableSession ReliableSession { get { throw null; } }
        public override string Scheme { get { throw null; } }
        public System.ServiceModel.NetTcpSecurity Security { get { throw null; } set { } }
        bool System.ServiceModel.Channels.IBindingRuntimePreferences.ReceiveSynchronously { get { throw null; } }
        public bool TransactionFlow { get { throw null; } set { } }
        public System.ServiceModel.TransferMode TransferMode { get { throw null; } set { } }
        public override System.ServiceModel.Channels.BindingElementCollection CreateBindingElements() { throw null; }
    }
    public sealed partial class NetTcpSecurity
    {
        public NetTcpSecurity() { }
        public System.ServiceModel.MessageSecurityOverTcp Message { get { throw null; } set { } }
        public System.ServiceModel.SecurityMode Mode { get { throw null; } set { } }
        public System.ServiceModel.TcpTransportSecurity Transport { get { throw null; } set { } }
    }
    public sealed partial class OperationContext : System.ServiceModel.IExtensibleObject<System.ServiceModel.OperationContext>
    {
        public OperationContext(System.ServiceModel.IContextChannel channel) { }
        public System.ServiceModel.IContextChannel Channel { get { throw null; } }
        public static System.ServiceModel.OperationContext Current { get { throw null; } set { } }
        public System.ServiceModel.IExtensionCollection<System.ServiceModel.OperationContext> Extensions { get { throw null; } }
        public System.ServiceModel.Channels.MessageHeaders IncomingMessageHeaders { get { throw null; } }
        public System.ServiceModel.Channels.MessageProperties IncomingMessageProperties { get { throw null; } }
        public System.ServiceModel.Channels.MessageVersion IncomingMessageVersion { get { throw null; } }
        [System.MonoTODOAttribute]
        public System.ServiceModel.InstanceContext InstanceContext { get { throw null; } }
        public bool IsUserContext { get { throw null; } }
        public System.ServiceModel.Channels.MessageHeaders OutgoingMessageHeaders { get { throw null; } }
        public System.ServiceModel.Channels.MessageProperties OutgoingMessageProperties { get { throw null; } }
        public System.ServiceModel.Channels.RequestContext RequestContext { get { throw null; } set { } }
        public string SessionId { get { throw null; } }
        public event System.EventHandler OperationCompleted { add { } remove { } }
    }
    public sealed partial class OperationContextScope : System.IDisposable
    {
        public OperationContextScope(System.ServiceModel.IContextChannel channel) { }
        public OperationContextScope(System.ServiceModel.OperationContext context) { }
        public void Dispose() { }
    }
    [System.AttributeUsageAttribute(System.AttributeTargets.Method)]
    public sealed partial class OperationContractAttribute : System.Attribute
    {
        public OperationContractAttribute() { }
        public string Action { get { throw null; } set { } }
        public bool AsyncPattern { get { throw null; } set { } }
        public bool HasProtectionLevel { get { throw null; } }
        public bool IsInitiating { get { throw null; } set { } }
        public bool IsOneWay { get { throw null; } set { } }
        public bool IsTerminating { get { throw null; } set { } }
        public string Name { get { throw null; } set { } }
        public System.Net.Security.ProtectionLevel ProtectionLevel { get { throw null; } set { } }
        public string ReplyAction { get { throw null; } set { } }
    }
    public enum OperationFormatStyle
    {
        Document = 0,
        Rpc = 1,
    }
    public enum OperationFormatUse
    {
        Encoded = 1,
        Literal = 0,
    }
    public partial class OptionalReliableSession : System.ServiceModel.ReliableSession
    {
        public OptionalReliableSession() { }
        public OptionalReliableSession(System.ServiceModel.Channels.ReliableSessionBindingElement reliableSessionBindingElement) { }
        public bool Enabled { get { throw null; } set { } }
    }
    public partial class PeerHopCountAttribute
    {
        public PeerHopCountAttribute() { }
    }
    public enum PeerMessageOrigination
    {
        Local = 0,
        Remote = 1,
    }
    public enum PeerMessagePropagation
    {
        Local = 1,
        LocalAndRemote = 3,
        None = 0,
        Remote = 2,
    }
    public enum PeerTransportCredentialType
    {
        Certificate = 1,
        Password = 0,
    }
    [System.SerializableAttribute]
    public partial class ProtocolException : System.ServiceModel.CommunicationException
    {
        public ProtocolException() { }
        protected ProtocolException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
        public ProtocolException(string message) { }
        public ProtocolException(string message, System.Exception innerException) { }
    }
    public enum QueuedDeliveryRequirementsMode
    {
        Allowed = 0,
        NotAllowed = 2,
        Required = 1,
    }
    public enum QueueTransferProtocol
    {
        Native = 0,
        Srmp = 1,
        SrmpSecure = 2,
    }
    [System.SerializableAttribute]
    public partial class QuotaExceededException : System.SystemException
    {
        public QuotaExceededException() { }
        protected QuotaExceededException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
        public QuotaExceededException(string message) { }
        public QuotaExceededException(string message, System.Exception innerException) { }
    }
    public enum ReceiveErrorHandling
    {
        Drop = 1,
        Fault = 0,
        Move = 3,
        Reject = 2,
    }
    public enum ReleaseInstanceMode
    {
        AfterCall = 2,
        BeforeAndAfterCall = 3,
        BeforeCall = 1,
        None = 0,
    }
    [System.MonoTODOAttribute]
    public abstract partial class ReliableMessagingVersion
    {
        protected ReliableMessagingVersion() { }
        public static System.ServiceModel.ReliableMessagingVersion Default { get { throw null; } }
        public static System.ServiceModel.ReliableMessagingVersion WSReliableMessaging11 { get { throw null; } }
        public static System.ServiceModel.ReliableMessagingVersion WSReliableMessagingFebruary2005 { get { throw null; } }
    }
    public partial class ReliableSession
    {
        public ReliableSession() { }
        public ReliableSession(System.ServiceModel.Channels.ReliableSessionBindingElement reliableSessionBindingElement) { }
        public System.TimeSpan InactivityTimeout { get { throw null; } set { } }
        public bool Ordered { get { throw null; } set { } }
    }
    public enum SecurityMode
    {
        Message = 2,
        None = 0,
        Transport = 1,
        TransportWithMessageCredential = 3,
    }
    [System.SerializableAttribute]
    public partial class ServerTooBusyException : System.ServiceModel.CommunicationException
    {
        public ServerTooBusyException() { }
        protected ServerTooBusyException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
        public ServerTooBusyException(string message) { }
        public ServerTooBusyException(string message, System.Exception innerException) { }
    }
    [System.SerializableAttribute]
    public partial class ServiceActivationException : System.ServiceModel.CommunicationException
    {
        public ServiceActivationException() { }
        protected ServiceActivationException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
        public ServiceActivationException(string message) { }
        public ServiceActivationException(string message, System.Exception innerException) { }
    }
    [System.AttributeUsageAttribute(System.AttributeTargets.Class | System.AttributeTargets.Interface, Inherited=false)]
    public sealed partial class ServiceContractAttribute : System.Attribute
    {
        public ServiceContractAttribute() { }
        public System.Type CallbackContract { get { throw null; } set { } }
        public string ConfigurationName { get { throw null; } set { } }
        public bool HasProtectionLevel { get { throw null; } }
        public string Name { get { throw null; } set { } }
        public string Namespace { get { throw null; } set { } }
        public System.Net.Security.ProtectionLevel ProtectionLevel { get { throw null; } set { } }
        public System.ServiceModel.SessionMode SessionMode { get { throw null; } set { } }
    }
    [System.AttributeUsageAttribute(System.AttributeTargets.Class | System.AttributeTargets.Interface | System.AttributeTargets.Method, AllowMultiple=true, Inherited=true)]
    public sealed partial class ServiceKnownTypeAttribute : System.Attribute
    {
        public ServiceKnownTypeAttribute(string methodName) { }
        public ServiceKnownTypeAttribute(string methodName, System.Type declaringType) { }
        public ServiceKnownTypeAttribute(System.Type type) { }
        public System.Type DeclaringType { get { throw null; } }
        public string MethodName { get { throw null; } }
        public System.Type Type { get { throw null; } }
    }
    public enum SessionMode
    {
        Allowed = 0,
        NotAllowed = 2,
        Required = 1,
    }
    public partial class SpnEndpointIdentity : System.ServiceModel.EndpointIdentity
    {
        public SpnEndpointIdentity(string spnName) { }
        [System.MonoTODOAttribute]
        public static System.TimeSpan SpnLookupTime { get { throw null; } set { } }
    }
    public enum TcpClientCredentialType
    {
        Certificate = 2,
        None = 0,
        Windows = 1,
    }
    [System.MonoTODOAttribute]
    public sealed partial class TcpTransportSecurity
    {
        public TcpTransportSecurity() { }
        public System.ServiceModel.TcpClientCredentialType ClientCredentialType { get { throw null; } set { } }
        public System.Net.Security.ProtectionLevel ProtectionLevel { get { throw null; } set { } }
        [System.MonoTODOAttribute]
        public System.Security.Authentication.SslProtocols SslProtocols { get { throw null; } set { } }
    }
    public enum TransactionFlowOption
    {
        Allowed = 1,
        Mandatory = 2,
        NotAllowed = 0,
    }
    public enum TransferMode
    {
        Buffered = 0,
        Streamed = 1,
        StreamedRequest = 2,
        StreamedResponse = 3,
    }
    public sealed partial class UnknownMessageReceivedEventArgs : System.EventArgs
    {
        internal UnknownMessageReceivedEventArgs() { }
        public System.ServiceModel.Channels.Message Message { get { throw null; } }
    }
    public partial class UpnEndpointIdentity : System.ServiceModel.EndpointIdentity
    {
        public UpnEndpointIdentity(string upnName) { }
    }
    [System.MonoTODOAttribute("It is untested.")]
    public partial class UriSchemeKeyedCollection : System.Collections.Generic.SynchronizedKeyedCollection<string, System.Uri>
    {
        public UriSchemeKeyedCollection(params System.Uri[] addresses) { }
        protected override string GetKeyForItem(System.Uri item) { throw null; }
        [System.MonoTODOAttribute("hmm, what should I do further?")]
        protected override void InsertItem(int index, System.Uri item) { }
        [System.MonoTODOAttribute("hmm, what should I do further?")]
        protected override void SetItem(int index, System.Uri item) { }
    }
    public enum WSDualHttpSecurityMode
    {
        Message = 1,
        None = 0,
    }
    public enum WSFederationHttpSecurityMode
    {
        Message = 1,
        None = 0,
        TransportWithMessageCredential = 2,
    }
    public enum WSMessageEncoding
    {
        Mtom = 1,
        Text = 0,
    }
    [System.AttributeUsageAttribute(System.AttributeTargets.Class | System.AttributeTargets.Interface | System.AttributeTargets.Method, Inherited=false)]
    public sealed partial class XmlSerializerFormatAttribute : System.Attribute
    {
        public XmlSerializerFormatAttribute() { }
        public System.ServiceModel.OperationFormatStyle Style { get { throw null; } set { } }
        [System.MonoTODOAttribute]
        public bool SupportFaults { get { throw null; } set { } }
        public System.ServiceModel.OperationFormatUse Use { get { throw null; } set { } }
    }
}
namespace System.ServiceModel.Activation
{
    public enum AspNetCompatibilityRequirementsMode
    {
        Allowed = 1,
        NotAllowed = 0,
        Required = 2,
    }
}
namespace System.ServiceModel.Activation.Configuration
{
    public partial class Dummy
    {
        public Dummy() { }
    }
}
namespace System.ServiceModel.Channels
{
    public abstract partial class AddressHeader
    {
        protected AddressHeader() { }
        public abstract string Name { get; }
        public abstract string Namespace { get; }
        public static System.ServiceModel.Channels.AddressHeader CreateAddressHeader(object value) { throw null; }
        public static System.ServiceModel.Channels.AddressHeader CreateAddressHeader(object value, System.Runtime.Serialization.XmlObjectSerializer serializer) { throw null; }
        public static System.ServiceModel.Channels.AddressHeader CreateAddressHeader(string name, string ns, object value) { throw null; }
        public static System.ServiceModel.Channels.AddressHeader CreateAddressHeader(string name, string ns, object value, System.Runtime.Serialization.XmlObjectSerializer serializer) { throw null; }
        public override bool Equals(object obj) { throw null; }
        public virtual System.Xml.XmlDictionaryReader GetAddressHeaderReader() { throw null; }
        public override int GetHashCode() { throw null; }
        public T GetValue<T>() { throw null; }
        public T GetValue<T>(System.Runtime.Serialization.XmlObjectSerializer serializer) { throw null; }
        protected abstract void OnWriteAddressHeaderContents(System.Xml.XmlDictionaryWriter writer);
        protected virtual void OnWriteStartAddressHeader(System.Xml.XmlDictionaryWriter writer) { }
        public System.ServiceModel.Channels.MessageHeader ToMessageHeader() { throw null; }
        public void WriteAddressHeader(System.Xml.XmlDictionaryWriter writer) { }
        public void WriteAddressHeader(System.Xml.XmlWriter writer) { }
        public void WriteAddressHeaderContents(System.Xml.XmlDictionaryWriter writer) { }
        public void WriteStartAddressHeader(System.Xml.XmlDictionaryWriter writer) { }
    }
    public sealed partial class AddressHeaderCollection : System.Collections.ObjectModel.ReadOnlyCollection<System.ServiceModel.Channels.AddressHeader>
    {
        public AddressHeaderCollection() : base (default(System.Collections.Generic.IList<System.ServiceModel.Channels.AddressHeader>)) { }
        public AddressHeaderCollection(System.Collections.Generic.IEnumerable<System.ServiceModel.Channels.AddressHeader> addressHeaders) : base (default(System.Collections.Generic.IList<System.ServiceModel.Channels.AddressHeader>)) { }
        public void AddHeadersTo(System.ServiceModel.Channels.Message message) { }
        public System.ServiceModel.Channels.AddressHeader[] FindAll(string name, string ns) { throw null; }
        public System.ServiceModel.Channels.AddressHeader FindHeader(string name, string ns) { throw null; }
    }
    public sealed partial class AddressingVersion
    {
        internal AddressingVersion() { }
        public static System.ServiceModel.Channels.AddressingVersion None { get { throw null; } }
        public static System.ServiceModel.Channels.AddressingVersion WSAddressing10 { get { throw null; } }
        public static System.ServiceModel.Channels.AddressingVersion WSAddressingAugust2004 { get { throw null; } }
        public override string ToString() { throw null; }
    }
    [System.MonoTODOAttribute]
    public sealed partial class BinaryMessageEncodingBindingElement : System.ServiceModel.Channels.MessageEncodingBindingElement, System.ServiceModel.Description.IPolicyExportExtension, System.ServiceModel.Description.IWsdlExportExtension
    {
        public BinaryMessageEncodingBindingElement() { }
        [System.MonoTODOAttribute]
        public System.ServiceModel.Channels.CompressionFormat CompressionFormat { get { throw null; } set { } }
        public int MaxReadPoolSize { get { throw null; } set { } }
        public int MaxSessionSize { get { throw null; } set { } }
        public int MaxWritePoolSize { get { throw null; } set { } }
        public override System.ServiceModel.Channels.MessageVersion MessageVersion { get { throw null; } set { } }
        public System.Xml.XmlDictionaryReaderQuotas ReaderQuotas { get { throw null; } set { } }
        public override System.ServiceModel.Channels.IChannelFactory<TChannel> BuildChannelFactory<TChannel>(System.ServiceModel.Channels.BindingContext context) { throw null; }
        public override System.ServiceModel.Channels.BindingElement Clone() { throw null; }
        public override System.ServiceModel.Channels.MessageEncoderFactory CreateMessageEncoderFactory() { throw null; }
        public override T GetProperty<T>(System.ServiceModel.Channels.BindingContext context) { throw null; }
    }
    public abstract partial class Binding : System.ServiceModel.IDefaultCommunicationTimeouts
    {
        protected Binding() { }
        protected Binding(string name, string ns) { }
        public System.TimeSpan CloseTimeout { get { throw null; } set { } }
        public System.ServiceModel.Channels.MessageVersion MessageVersion { get { throw null; } }
        public string Name { get { throw null; } set { } }
        public string Namespace { get { throw null; } set { } }
        public System.TimeSpan OpenTimeout { get { throw null; } set { } }
        public System.TimeSpan ReceiveTimeout { get { throw null; } set { } }
        public abstract string Scheme { get; }
        public System.TimeSpan SendTimeout { get { throw null; } set { } }
        public System.ServiceModel.Channels.IChannelFactory<TChannel> BuildChannelFactory<TChannel>(params object[] parameters) { throw null; }
        public virtual System.ServiceModel.Channels.IChannelFactory<TChannel> BuildChannelFactory<TChannel>(System.ServiceModel.Channels.BindingParameterCollection parameters) { throw null; }
        public bool CanBuildChannelFactory<TChannel>(params object[] parameters) { throw null; }
        public virtual bool CanBuildChannelFactory<TChannel>(System.ServiceModel.Channels.BindingParameterCollection parameters) { throw null; }
        public abstract System.ServiceModel.Channels.BindingElementCollection CreateBindingElements();
        public T GetProperty<T>(System.ServiceModel.Channels.BindingParameterCollection parameters) where T : class { throw null; }
    }
    public partial class BindingContext
    {
        public BindingContext(System.ServiceModel.Channels.CustomBinding binding, System.ServiceModel.Channels.BindingParameterCollection parameters) { }
        public BindingContext(System.ServiceModel.Channels.CustomBinding binding, System.ServiceModel.Channels.BindingParameterCollection parameters, System.Uri listenUriBaseAddress, string listenUriRelativeAddress, System.ServiceModel.Description.ListenUriMode listenUriMode) { }
        public System.ServiceModel.Channels.CustomBinding Binding { get { throw null; } }
        public System.ServiceModel.Channels.BindingParameterCollection BindingParameters { get { throw null; } }
        public System.Uri ListenUriBaseAddress { get { throw null; } set { } }
        public System.ServiceModel.Description.ListenUriMode ListenUriMode { get { throw null; } set { } }
        public string ListenUriRelativeAddress { get { throw null; } set { } }
        public System.ServiceModel.Channels.BindingElementCollection RemainingBindingElements { get { throw null; } }
        public System.ServiceModel.Channels.IChannelFactory<TChannel> BuildInnerChannelFactory<TChannel>() { throw null; }
        public bool CanBuildInnerChannelFactory<TChannel>() { throw null; }
        public System.ServiceModel.Channels.BindingContext Clone() { throw null; }
        public T GetInnerProperty<T>() where T : class { throw null; }
    }
    public abstract partial class BindingElement
    {
        protected BindingElement() { }
        [System.MonoTODOAttribute]
        protected BindingElement(System.ServiceModel.Channels.BindingElement elementToBeCloned) { }
        public virtual System.ServiceModel.Channels.IChannelFactory<TChannel> BuildChannelFactory<TChannel>(System.ServiceModel.Channels.BindingContext context) { throw null; }
        public virtual bool CanBuildChannelFactory<TChannel>(System.ServiceModel.Channels.BindingContext context) { throw null; }
        public abstract System.ServiceModel.Channels.BindingElement Clone();
        public abstract T GetProperty<T>(System.ServiceModel.Channels.BindingContext context) where T : class;
    }
    [System.MonoTODOAttribute]
    public partial class BindingElementCollection : System.Collections.ObjectModel.Collection<System.ServiceModel.Channels.BindingElement>
    {
        public BindingElementCollection() { }
        public BindingElementCollection(System.Collections.Generic.IEnumerable<System.ServiceModel.Channels.BindingElement> elements) { }
        public BindingElementCollection(System.ServiceModel.Channels.BindingElement[] elements) { }
        public void AddRange(params System.ServiceModel.Channels.BindingElement[] elements) { }
        public System.ServiceModel.Channels.BindingElementCollection Clone() { throw null; }
        public bool Contains(System.Type bindingElementType) { throw null; }
        public System.Collections.ObjectModel.Collection<T> FindAll<T>() { throw null; }
        public T Find<T>() { throw null; }
        protected override void InsertItem(int index, System.ServiceModel.Channels.BindingElement item) { }
        public System.Collections.ObjectModel.Collection<T> RemoveAll<T>() { throw null; }
        public T Remove<T>() { throw null; }
        protected override void SetItem(int index, System.ServiceModel.Channels.BindingElement item) { }
    }
    public partial class BindingParameterCollection : System.Collections.Generic.KeyedByTypeCollection<object>
    {
        public BindingParameterCollection() { }
        protected override System.Type GetKeyForItem(object item) { throw null; }
        protected override void InsertItem(int index, object item) { }
        protected override void SetItem(int index, object item) { }
    }
    public abstract partial class BodyWriter
    {
        protected BodyWriter(bool isBuffered) { }
        public bool IsBuffered { get { throw null; } }
        public System.ServiceModel.Channels.BodyWriter CreateBufferedCopy(int maxBufferSize) { throw null; }
        protected virtual System.ServiceModel.Channels.BodyWriter OnCreateBufferedCopy(int maxBufferSize) { throw null; }
        protected abstract void OnWriteBodyContents(System.Xml.XmlDictionaryWriter writer);
        public void WriteBodyContents(System.Xml.XmlDictionaryWriter writer) { }
    }
    public abstract partial class BufferManager
    {
        protected BufferManager() { }
        public abstract void Clear();
        public static System.ServiceModel.Channels.BufferManager CreateBufferManager(long maxBufferPoolSize, int maxBufferSize) { throw null; }
        public abstract void ReturnBuffer(byte[] buffer);
        public abstract byte[] TakeBuffer(int bufferSize);
    }
    [System.MonoTODOAttribute]
    public abstract partial class ChannelBase : System.ServiceModel.Channels.CommunicationObject, System.ServiceModel.Channels.IChannel, System.ServiceModel.ICommunicationObject, System.ServiceModel.IDefaultCommunicationTimeouts
    {
        protected ChannelBase(System.ServiceModel.Channels.ChannelManagerBase channelManager) { }
        protected internal override System.TimeSpan DefaultCloseTimeout { get { throw null; } }
        protected internal override System.TimeSpan DefaultOpenTimeout { get { throw null; } }
        protected internal System.TimeSpan DefaultReceiveTimeout { get { throw null; } }
        protected internal System.TimeSpan DefaultSendTimeout { get { throw null; } }
        protected System.ServiceModel.Channels.ChannelManagerBase Manager { get { throw null; } }
        System.TimeSpan System.ServiceModel.IDefaultCommunicationTimeouts.CloseTimeout { get { throw null; } }
        System.TimeSpan System.ServiceModel.IDefaultCommunicationTimeouts.OpenTimeout { get { throw null; } }
        System.TimeSpan System.ServiceModel.IDefaultCommunicationTimeouts.ReceiveTimeout { get { throw null; } }
        System.TimeSpan System.ServiceModel.IDefaultCommunicationTimeouts.SendTimeout { get { throw null; } }
        public virtual T GetProperty<T>() where T : class { throw null; }
        protected override void OnClosed() { }
    }
    public abstract partial class ChannelFactoryBase : System.ServiceModel.Channels.ChannelManagerBase, System.ServiceModel.Channels.IChannelFactory, System.ServiceModel.ICommunicationObject
    {
        protected ChannelFactoryBase() { }
        protected ChannelFactoryBase(System.ServiceModel.IDefaultCommunicationTimeouts timeouts) { }
        protected internal override System.TimeSpan DefaultCloseTimeout { get { throw null; } }
        protected internal override System.TimeSpan DefaultOpenTimeout { get { throw null; } }
        protected internal override System.TimeSpan DefaultReceiveTimeout { get { throw null; } }
        protected internal override System.TimeSpan DefaultSendTimeout { get { throw null; } }
        public virtual T GetProperty<T>() where T : class { throw null; }
        protected override void OnAbort() { }
        protected override System.IAsyncResult OnBeginClose(System.TimeSpan timeout, System.AsyncCallback callback, object state) { throw null; }
        protected override void OnClose(System.TimeSpan timeout) { }
        protected override void OnEndClose(System.IAsyncResult result) { }
    }
    public abstract partial class ChannelFactoryBase<TChannel> : System.ServiceModel.Channels.ChannelFactoryBase, System.ServiceModel.Channels.IChannelFactory, System.ServiceModel.Channels.IChannelFactory<TChannel>, System.ServiceModel.ICommunicationObject
    {
        protected ChannelFactoryBase() { }
        protected ChannelFactoryBase(System.ServiceModel.IDefaultCommunicationTimeouts timeouts) { }
        public TChannel CreateChannel(System.ServiceModel.EndpointAddress address) { throw null; }
        public TChannel CreateChannel(System.ServiceModel.EndpointAddress address, System.Uri via) { throw null; }
        protected override void OnAbort() { }
        protected override System.IAsyncResult OnBeginClose(System.TimeSpan timeout, System.AsyncCallback callback, object state) { throw null; }
        protected override void OnClose(System.TimeSpan timeout) { }
        protected abstract TChannel OnCreateChannel(System.ServiceModel.EndpointAddress address, System.Uri via);
        protected override void OnEndClose(System.IAsyncResult result) { }
        protected void ValidateCreateChannel() { }
    }
    public abstract partial class ChannelManagerBase : System.ServiceModel.Channels.CommunicationObject, System.ServiceModel.ICommunicationObject, System.ServiceModel.IDefaultCommunicationTimeouts
    {
        protected ChannelManagerBase() { }
        protected internal abstract System.TimeSpan DefaultReceiveTimeout { get; }
        protected internal abstract System.TimeSpan DefaultSendTimeout { get; }
        System.TimeSpan System.ServiceModel.IDefaultCommunicationTimeouts.CloseTimeout { get { throw null; } }
        System.TimeSpan System.ServiceModel.IDefaultCommunicationTimeouts.OpenTimeout { get { throw null; } }
        System.TimeSpan System.ServiceModel.IDefaultCommunicationTimeouts.ReceiveTimeout { get { throw null; } }
        System.TimeSpan System.ServiceModel.IDefaultCommunicationTimeouts.SendTimeout { get { throw null; } }
    }
    public partial class ChannelParameterCollection : System.Collections.ObjectModel.Collection<object>
    {
        public ChannelParameterCollection() { }
        public ChannelParameterCollection(System.ServiceModel.Channels.IChannel channel) { }
        protected virtual System.ServiceModel.Channels.IChannel Channel { get { throw null; } }
        protected override void ClearItems() { }
        protected override void InsertItem(int index, object item) { }
        public void PropagateChannelParameters(System.ServiceModel.Channels.IChannel innerChannel) { }
        protected override void RemoveItem(int index) { }
        protected override void SetItem(int index, object item) { }
    }
    public partial class ChannelPoolSettings
    {
        [System.MonoTODOAttribute]
        public ChannelPoolSettings() { }
        [System.MonoTODOAttribute]
        public System.TimeSpan IdleTimeout { get { throw null; } set { } }
        [System.MonoTODOAttribute]
        public System.TimeSpan LeaseTimeout { get { throw null; } set { } }
        [System.MonoTODOAttribute]
        public int MaxOutboundChannelsPerEndpoint { get { throw null; } set { } }
    }
    public abstract partial class CommunicationObject : System.ServiceModel.ICommunicationObject
    {
        protected CommunicationObject() { }
        protected CommunicationObject(object mutex) { }
        protected internal abstract System.TimeSpan DefaultCloseTimeout { get; }
        protected internal abstract System.TimeSpan DefaultOpenTimeout { get; }
        protected bool IsDisposed { get { throw null; } }
        public System.ServiceModel.CommunicationState State { get { throw null; } }
        protected object ThisLock { get { throw null; } }
        public event System.EventHandler Closed { add { } remove { } }
        public event System.EventHandler Closing { add { } remove { } }
        public event System.EventHandler Faulted { add { } remove { } }
        public event System.EventHandler Opened { add { } remove { } }
        public event System.EventHandler Opening { add { } remove { } }
        public void Abort() { }
        public System.IAsyncResult BeginClose(System.AsyncCallback callback, object state) { throw null; }
        public System.IAsyncResult BeginClose(System.TimeSpan timeout, System.AsyncCallback callback, object state) { throw null; }
        public System.IAsyncResult BeginOpen(System.AsyncCallback callback, object state) { throw null; }
        public System.IAsyncResult BeginOpen(System.TimeSpan timeout, System.AsyncCallback callback, object state) { throw null; }
        public void Close() { }
        public void Close(System.TimeSpan timeout) { }
        public void EndClose(System.IAsyncResult result) { }
        public void EndOpen(System.IAsyncResult result) { }
        protected void Fault() { }
        protected virtual System.Type GetCommunicationObjectType() { throw null; }
        protected abstract void OnAbort();
        protected abstract System.IAsyncResult OnBeginClose(System.TimeSpan timeout, System.AsyncCallback callback, object state);
        protected abstract System.IAsyncResult OnBeginOpen(System.TimeSpan timeout, System.AsyncCallback callback, object state);
        protected abstract void OnClose(System.TimeSpan timeout);
        protected virtual void OnClosed() { }
        protected virtual void OnClosing() { }
        protected abstract void OnEndClose(System.IAsyncResult result);
        protected abstract void OnEndOpen(System.IAsyncResult result);
        protected virtual void OnFaulted() { }
        protected abstract void OnOpen(System.TimeSpan timeout);
        protected virtual void OnOpened() { }
        protected virtual void OnOpening() { }
        public void Open() { }
        public void Open(System.TimeSpan timeout) { }
        protected void ThrowIfDisposed() { }
        protected void ThrowIfDisposedOrImmutable() { }
        protected void ThrowIfDisposedOrNotOpen() { }
    }
    public enum CompressionFormat
    {
        Deflate = 2,
        GZip = 1,
        None = 0,
    }
    [System.MonoTODOAttribute]
    public abstract partial class ConnectionOrientedTransportBindingElement : System.ServiceModel.Channels.TransportBindingElement, System.ServiceModel.Description.IPolicyExportExtension, System.ServiceModel.Description.IWsdlExportExtension
    {
        internal ConnectionOrientedTransportBindingElement() { }
        public System.TimeSpan ChannelInitializationTimeout { get { throw null; } set { } }
        public int ConnectionBufferSize { get { throw null; } set { } }
        public System.ServiceModel.HostNameComparisonMode HostNameComparisonMode { get { throw null; } set { } }
        public int MaxBufferSize { get { throw null; } set { } }
        public System.TimeSpan MaxOutputDelay { get { throw null; } set { } }
        public int MaxPendingAccepts { get { throw null; } set { } }
        public int MaxPendingConnections { get { throw null; } set { } }
        public System.ServiceModel.TransferMode TransferMode { get { throw null; } set { } }
        public override bool CanBuildChannelFactory<TChannel>(System.ServiceModel.Channels.BindingContext context) { throw null; }
        public override T GetProperty<T>(System.ServiceModel.Channels.BindingContext context) { throw null; }
    }
    public partial class CustomBinding : System.ServiceModel.Channels.Binding
    {
        public CustomBinding() { }
        public CustomBinding(System.Collections.Generic.IEnumerable<System.ServiceModel.Channels.BindingElement> bindingElementsInTopDownChannelStackOrder) { }
        public CustomBinding(System.ServiceModel.Channels.Binding binding) { }
        public CustomBinding(params System.ServiceModel.Channels.BindingElement[] bindingElementsInTopDownChannelStackOrder) { }
        public CustomBinding(string configurationName) { }
        public CustomBinding(string name, string ns, params System.ServiceModel.Channels.BindingElement[] bindingElementsInTopDownChannelStackOrder) { }
        public System.ServiceModel.Channels.BindingElementCollection Elements { get { throw null; } }
        public override string Scheme { get { throw null; } }
        public override System.ServiceModel.Channels.BindingElementCollection CreateBindingElements() { throw null; }
    }
    public abstract partial class FaultConverter
    {
        protected FaultConverter() { }
        public static System.ServiceModel.Channels.FaultConverter GetDefaultFaultConverter(System.ServiceModel.Channels.MessageVersion version) { throw null; }
        [System.MonoTODOAttribute]
        protected abstract bool OnTryCreateException(System.ServiceModel.Channels.Message message, System.ServiceModel.Channels.MessageFault fault, out System.Exception exception);
        [System.MonoTODOAttribute]
        protected abstract bool OnTryCreateFaultMessage(System.Exception exception, out System.ServiceModel.Channels.Message message);
        public bool TryCreateException(System.ServiceModel.Channels.Message message, System.ServiceModel.Channels.MessageFault fault, out System.Exception exception) { throw null; }
        public bool TryCreateFaultMessage(System.Exception exception, out System.ServiceModel.Channels.Message message) { throw null; }
    }
    [System.ObsoleteAttribute("Use AllowCookies.")]
    public partial class HttpCookieContainerBindingElement : System.ServiceModel.Channels.BindingElement
    {
        public HttpCookieContainerBindingElement() { }
        protected HttpCookieContainerBindingElement(System.ServiceModel.Channels.HttpCookieContainerBindingElement elementToBeCloned) { }
        public override System.ServiceModel.Channels.IChannelFactory<TChannel> BuildChannelFactory<TChannel>(System.ServiceModel.Channels.BindingContext context) { throw null; }
        public override System.ServiceModel.Channels.BindingElement Clone() { throw null; }
        public override T GetProperty<T>(System.ServiceModel.Channels.BindingContext context) { throw null; }
    }
    public sealed partial class HttpRequestMessageProperty : System.ServiceModel.Channels.IMessageProperty
    {
        public HttpRequestMessageProperty() { }
        public System.Net.WebHeaderCollection Headers { get { throw null; } }
        public string Method { get { throw null; } set { } }
        public static string Name { get { throw null; } }
        public string QueryString { get { throw null; } set { } }
        public bool SuppressEntityBody { get { throw null; } set { } }
        System.ServiceModel.Channels.IMessageProperty System.ServiceModel.Channels.IMessageProperty.CreateCopy() { throw null; }
    }
    public sealed partial class HttpResponseMessageProperty : System.ServiceModel.Channels.IMessageProperty
    {
        public HttpResponseMessageProperty() { }
        public System.Net.WebHeaderCollection Headers { get { throw null; } }
        public static string Name { get { throw null; } }
        public System.Net.HttpStatusCode StatusCode { get { throw null; } set { } }
        public string StatusDescription { get { throw null; } set { } }
        public bool SuppressEntityBody { get { throw null; } set { } }
        System.ServiceModel.Channels.IMessageProperty System.ServiceModel.Channels.IMessageProperty.CreateCopy() { throw null; }
    }
    [System.MonoTODOAttribute]
    public partial class HttpsTransportBindingElement : System.ServiceModel.Channels.HttpTransportBindingElement, System.ServiceModel.Channels.ITransportTokenAssertionProvider, System.ServiceModel.Description.IPolicyExportExtension, System.ServiceModel.Description.IWsdlExportExtension
    {
        public HttpsTransportBindingElement() { }
        protected HttpsTransportBindingElement(System.ServiceModel.Channels.HttpsTransportBindingElement elementToBeCloned) { }
        public bool RequireClientCertificate { get { throw null; } set { } }
        public override string Scheme { get { throw null; } }
        public override System.ServiceModel.Channels.IChannelFactory<TChannel> BuildChannelFactory<TChannel>(System.ServiceModel.Channels.BindingContext context) { throw null; }
        public override System.ServiceModel.Channels.BindingElement Clone() { throw null; }
        public override T GetProperty<T>(System.ServiceModel.Channels.BindingContext context) { throw null; }
    }
    public partial class HttpTransportBindingElement : System.ServiceModel.Channels.TransportBindingElement, System.ServiceModel.Description.IPolicyExportExtension, System.ServiceModel.Description.IWsdlExportExtension
    {
        public HttpTransportBindingElement() { }
        protected HttpTransportBindingElement(System.ServiceModel.Channels.HttpTransportBindingElement elementToBeCloned) { }
        [System.ComponentModel.DefaultValueAttribute(false)]
        public bool AllowCookies { get { throw null; } set { } }
        [System.ComponentModel.DefaultValueAttribute(System.Net.AuthenticationSchemes.Anonymous)]
        public System.Net.AuthenticationSchemes AuthenticationScheme { get { throw null; } set { } }
        [System.ComponentModel.DefaultValueAttribute(false)]
        public bool BypassProxyOnLocal { get { throw null; } set { } }
        [System.ComponentModel.DefaultValueAttribute(false)]
        [System.MonoTODOAttribute]
        public bool DecompressionEnabled { get { throw null; } set { } }
        [System.MonoTODOAttribute]
        public System.Security.Authentication.ExtendedProtection.ExtendedProtectionPolicy ExtendedProtectionPolicy { get { throw null; } set { } }
        [System.ComponentModel.DefaultValueAttribute(System.ServiceModel.HostNameComparisonMode.StrongWildcard)]
        public System.ServiceModel.HostNameComparisonMode HostNameComparisonMode { get { throw null; } set { } }
        [System.ComponentModel.DefaultValueAttribute(true)]
        public bool KeepAliveEnabled { get { throw null; } set { } }
        [System.MonoTODOAttribute]
        [System.ObsoleteAttribute("Use ExtendedProtectionPolicy")]
        public object LegacyExtendedProtectionPolicy { get { throw null; } set { } }
        [System.ComponentModel.DefaultValueAttribute(65536)]
        public int MaxBufferSize { get { throw null; } set { } }
        [System.ComponentModel.DefaultValueAttribute(null)]
        [System.ComponentModel.TypeConverterAttribute(typeof(System.UriTypeConverter))]
        public System.Uri ProxyAddress { get { throw null; } set { } }
        [System.ComponentModel.DefaultValueAttribute(System.Net.AuthenticationSchemes.Anonymous)]
        public System.Net.AuthenticationSchemes ProxyAuthenticationScheme { get { throw null; } set { } }
        [System.ComponentModel.DefaultValueAttribute("")]
        public string Realm { get { throw null; } set { } }
        public override string Scheme { get { throw null; } }
        [System.ComponentModel.DefaultValueAttribute(System.ServiceModel.TransferMode.Buffered)]
        public System.ServiceModel.TransferMode TransferMode { get { throw null; } set { } }
        [System.ComponentModel.DefaultValueAttribute(false)]
        public bool UnsafeConnectionNtlmAuthentication { get { throw null; } set { } }
        [System.ComponentModel.DefaultValueAttribute(true)]
        public bool UseDefaultWebProxy { get { throw null; } set { } }
        public System.ServiceModel.Channels.WebSocketTransportSettings WebSocketSettings { get { throw null; } set { } }
        public override System.ServiceModel.Channels.IChannelFactory<TChannel> BuildChannelFactory<TChannel>(System.ServiceModel.Channels.BindingContext context) { throw null; }
        public override bool CanBuildChannelFactory<TChannel>(System.ServiceModel.Channels.BindingContext context) { throw null; }
        public override System.ServiceModel.Channels.BindingElement Clone() { throw null; }
        public override T GetProperty<T>(System.ServiceModel.Channels.BindingContext context) { throw null; }
    }
    public partial interface IBindingDeliveryCapabilities
    {
        bool AssuresOrderedDelivery { get; }
        bool QueuedDelivery { get; }
    }
    public partial interface IBindingRuntimePreferences
    {
        bool ReceiveSynchronously { get; }
    }
    public partial interface IChannel : System.ServiceModel.ICommunicationObject
    {
        T GetProperty<T>() where T : class;
    }
    public partial interface IChannelFactory : System.ServiceModel.ICommunicationObject
    {
        T GetProperty<T>() where T : class;
    }
    public partial interface IChannelFactory<TChannel> : System.ServiceModel.Channels.IChannelFactory, System.ServiceModel.ICommunicationObject
    {
        TChannel CreateChannel(System.ServiceModel.EndpointAddress to);
        TChannel CreateChannel(System.ServiceModel.EndpointAddress to, System.Uri via);
    }
    public partial interface IDuplexChannel : System.ServiceModel.Channels.IChannel, System.ServiceModel.Channels.IInputChannel, System.ServiceModel.Channels.IOutputChannel, System.ServiceModel.ICommunicationObject
    {
    }
    public partial interface IDuplexSession : System.ServiceModel.Channels.IInputSession, System.ServiceModel.Channels.IOutputSession, System.ServiceModel.Channels.ISession
    {
        System.IAsyncResult BeginCloseOutputSession(System.AsyncCallback callback, object state);
        System.IAsyncResult BeginCloseOutputSession(System.TimeSpan timeout, System.AsyncCallback callback, object state);
        void CloseOutputSession();
        void CloseOutputSession(System.TimeSpan timeout);
        void EndCloseOutputSession(System.IAsyncResult result);
    }
    public partial interface IDuplexSessionChannel : System.ServiceModel.Channels.IChannel, System.ServiceModel.Channels.IDuplexChannel, System.ServiceModel.Channels.IInputChannel, System.ServiceModel.Channels.IOutputChannel, System.ServiceModel.Channels.ISessionChannel<System.ServiceModel.Channels.IDuplexSession>, System.ServiceModel.ICommunicationObject
    {
    }
    public partial interface IHttpCookieContainerManager
    {
        System.Net.CookieContainer CookieContainer { get; set; }
    }
    public partial interface IInputChannel : System.ServiceModel.Channels.IChannel, System.ServiceModel.ICommunicationObject
    {
        System.ServiceModel.EndpointAddress LocalAddress { get; }
        System.IAsyncResult BeginReceive(System.AsyncCallback callback, object state);
        System.IAsyncResult BeginReceive(System.TimeSpan timeout, System.AsyncCallback callback, object state);
        System.IAsyncResult BeginTryReceive(System.TimeSpan timeout, System.AsyncCallback callback, object state);
        System.IAsyncResult BeginWaitForMessage(System.TimeSpan timeout, System.AsyncCallback callback, object state);
        System.ServiceModel.Channels.Message EndReceive(System.IAsyncResult result);
        bool EndTryReceive(System.IAsyncResult result, out System.ServiceModel.Channels.Message message);
        bool EndWaitForMessage(System.IAsyncResult result);
        System.ServiceModel.Channels.Message Receive();
        System.ServiceModel.Channels.Message Receive(System.TimeSpan timeout);
        bool TryReceive(System.TimeSpan timeout, out System.ServiceModel.Channels.Message message);
        bool WaitForMessage(System.TimeSpan timeout);
    }
    public partial interface IInputSession : System.ServiceModel.Channels.ISession
    {
    }
    public partial interface IInputSessionChannel : System.ServiceModel.Channels.IChannel, System.ServiceModel.Channels.IInputChannel, System.ServiceModel.Channels.ISessionChannel<System.ServiceModel.Channels.IInputSession>, System.ServiceModel.ICommunicationObject
    {
    }
    public partial interface IMessageProperty
    {
        System.ServiceModel.Channels.IMessageProperty CreateCopy();
    }
    public partial interface IOutputChannel : System.ServiceModel.Channels.IChannel, System.ServiceModel.ICommunicationObject
    {
        System.ServiceModel.EndpointAddress RemoteAddress { get; }
        System.Uri Via { get; }
        System.IAsyncResult BeginSend(System.ServiceModel.Channels.Message message, System.AsyncCallback callback, object state);
        System.IAsyncResult BeginSend(System.ServiceModel.Channels.Message message, System.TimeSpan timeout, System.AsyncCallback callback, object state);
        void EndSend(System.IAsyncResult result);
        void Send(System.ServiceModel.Channels.Message message);
        void Send(System.ServiceModel.Channels.Message message, System.TimeSpan timeout);
    }
    public partial interface IOutputSession : System.ServiceModel.Channels.ISession
    {
    }
    public partial interface IOutputSessionChannel : System.ServiceModel.Channels.IChannel, System.ServiceModel.Channels.IOutputChannel, System.ServiceModel.Channels.ISessionChannel<System.ServiceModel.Channels.IOutputSession>, System.ServiceModel.ICommunicationObject
    {
    }
    public partial interface IRequestChannel : System.ServiceModel.Channels.IChannel, System.ServiceModel.ICommunicationObject
    {
        System.ServiceModel.EndpointAddress RemoteAddress { get; }
        System.Uri Via { get; }
        System.IAsyncResult BeginRequest(System.ServiceModel.Channels.Message message, System.AsyncCallback callback, object state);
        System.IAsyncResult BeginRequest(System.ServiceModel.Channels.Message message, System.TimeSpan timeout, System.AsyncCallback callback, object state);
        System.ServiceModel.Channels.Message EndRequest(System.IAsyncResult result);
        System.ServiceModel.Channels.Message Request(System.ServiceModel.Channels.Message message);
        System.ServiceModel.Channels.Message Request(System.ServiceModel.Channels.Message message, System.TimeSpan timeout);
    }
    public partial interface IRequestSessionChannel : System.ServiceModel.Channels.IChannel, System.ServiceModel.Channels.IRequestChannel, System.ServiceModel.Channels.ISessionChannel<System.ServiceModel.Channels.IOutputSession>, System.ServiceModel.ICommunicationObject
    {
    }
    public partial interface ISecurityCapabilities
    {
        System.Net.Security.ProtectionLevel SupportedRequestProtectionLevel { get; }
        System.Net.Security.ProtectionLevel SupportedResponseProtectionLevel { get; }
        bool SupportsClientAuthentication { get; }
        bool SupportsClientWindowsIdentity { get; }
        bool SupportsServerAuthentication { get; }
    }
    public partial interface ISession
    {
        string Id { get; }
    }
    public partial interface ISessionChannel<TSession> where TSession : System.ServiceModel.Channels.ISession
    {
        TSession Session { get; }
    }
    public partial interface ITransportTokenAssertionProvider
    {
    }
    [System.MonoTODOAttribute]
    public sealed partial class LocalClientSecuritySettings
    {
        public LocalClientSecuritySettings() { }
        public System.TimeSpan MaxClockSkew { get { throw null; } set { } }
        public System.TimeSpan ReplayWindow { get { throw null; } set { } }
        public System.TimeSpan TimestampValidityDuration { get { throw null; } set { } }
        [System.MonoTODOAttribute("What happens to IdentityVerifier?")]
        public System.ServiceModel.Channels.LocalClientSecuritySettings Clone() { throw null; }
    }
    public abstract partial class Message : System.IDisposable
    {
        protected Message() { }
        public abstract System.ServiceModel.Channels.MessageHeaders Headers { get; }
        protected bool IsDisposed { get { throw null; } }
        public virtual bool IsEmpty { get { throw null; } }
        public virtual bool IsFault { get { throw null; } }
        public abstract System.ServiceModel.Channels.MessageProperties Properties { get; }
        public System.ServiceModel.Channels.MessageState State { get { throw null; } }
        public abstract System.ServiceModel.Channels.MessageVersion Version { get; }
        public void Close() { }
        public System.ServiceModel.Channels.MessageBuffer CreateBufferedCopy(int maxBufferSize) { throw null; }
        public static System.ServiceModel.Channels.Message CreateMessage(System.ServiceModel.Channels.MessageVersion version, System.ServiceModel.Channels.MessageFault fault, string action) { throw null; }
        public static System.ServiceModel.Channels.Message CreateMessage(System.ServiceModel.Channels.MessageVersion version, System.ServiceModel.FaultCode faultCode, string reason, object detail, string action) { throw null; }
        public static System.ServiceModel.Channels.Message CreateMessage(System.ServiceModel.Channels.MessageVersion version, System.ServiceModel.FaultCode faultCode, string reason, string action) { throw null; }
        public static System.ServiceModel.Channels.Message CreateMessage(System.ServiceModel.Channels.MessageVersion version, string action) { throw null; }
        public static System.ServiceModel.Channels.Message CreateMessage(System.ServiceModel.Channels.MessageVersion version, string action, object body) { throw null; }
        public static System.ServiceModel.Channels.Message CreateMessage(System.ServiceModel.Channels.MessageVersion version, string action, object body, System.Runtime.Serialization.XmlObjectSerializer serializer) { throw null; }
        public static System.ServiceModel.Channels.Message CreateMessage(System.ServiceModel.Channels.MessageVersion version, string action, System.ServiceModel.Channels.BodyWriter body) { throw null; }
        public static System.ServiceModel.Channels.Message CreateMessage(System.ServiceModel.Channels.MessageVersion version, string action, System.Xml.XmlDictionaryReader body) { throw null; }
        public static System.ServiceModel.Channels.Message CreateMessage(System.ServiceModel.Channels.MessageVersion version, string action, System.Xml.XmlReader body) { throw null; }
        public static System.ServiceModel.Channels.Message CreateMessage(System.Xml.XmlDictionaryReader envelopeReader, int maxSizeOfHeaders, System.ServiceModel.Channels.MessageVersion version) { throw null; }
        public static System.ServiceModel.Channels.Message CreateMessage(System.Xml.XmlReader envelopeReader, int maxSizeOfHeaders, System.ServiceModel.Channels.MessageVersion version) { throw null; }
        public string GetBodyAttribute(string localName, string ns) { throw null; }
        public T GetBody<T>() { throw null; }
        public T GetBody<T>(System.Runtime.Serialization.XmlObjectSerializer serializer) { throw null; }
        public System.Xml.XmlDictionaryReader GetReaderAtBodyContents() { throw null; }
        protected virtual void OnBodyToString(System.Xml.XmlDictionaryWriter writer) { }
        protected virtual void OnClose() { }
        protected virtual System.ServiceModel.Channels.MessageBuffer OnCreateBufferedCopy(int maxBufferSize) { throw null; }
        protected virtual string OnGetBodyAttribute(string localName, string ns) { throw null; }
        protected virtual T OnGetBody<T>(System.Xml.XmlDictionaryReader reader) { throw null; }
        protected virtual System.Xml.XmlDictionaryReader OnGetReaderAtBodyContents() { throw null; }
        protected abstract void OnWriteBodyContents(System.Xml.XmlDictionaryWriter writer);
        protected virtual void OnWriteMessage(System.Xml.XmlDictionaryWriter writer) { }
        protected virtual void OnWriteStartBody(System.Xml.XmlDictionaryWriter writer) { }
        protected virtual void OnWriteStartEnvelope(System.Xml.XmlDictionaryWriter writer) { }
        protected virtual void OnWriteStartHeaders(System.Xml.XmlDictionaryWriter writer) { }
        void System.IDisposable.Dispose() { }
        public override string ToString() { throw null; }
        public void WriteBody(System.Xml.XmlDictionaryWriter writer) { }
        public void WriteBody(System.Xml.XmlWriter writer) { }
        public void WriteBodyContents(System.Xml.XmlDictionaryWriter writer) { }
        public void WriteMessage(System.Xml.XmlDictionaryWriter writer) { }
        public void WriteMessage(System.Xml.XmlWriter writer) { }
        public void WriteStartBody(System.Xml.XmlDictionaryWriter writer) { }
        public void WriteStartBody(System.Xml.XmlWriter writer) { }
        public void WriteStartEnvelope(System.Xml.XmlDictionaryWriter writer) { }
    }
    public abstract partial class MessageBuffer : System.IDisposable
    {
        protected MessageBuffer() { }
        public abstract int BufferSize { get; }
        public virtual string MessageContentType { get { throw null; } }
        public abstract void Close();
        public abstract System.ServiceModel.Channels.Message CreateMessage();
        void System.IDisposable.Dispose() { }
        public virtual void WriteMessage(System.IO.Stream stream) { }
    }
    public abstract partial class MessageEncoder
    {
        protected MessageEncoder() { }
        public abstract string ContentType { get; }
        public abstract string MediaType { get; }
        public abstract System.ServiceModel.Channels.MessageVersion MessageVersion { get; }
        [System.MonoTODOAttribute]
        public virtual T GetProperty<T>() where T : class { throw null; }
        public virtual bool IsContentTypeSupported(string contentType) { throw null; }
        public System.ServiceModel.Channels.Message ReadMessage(System.ArraySegment<byte> buffer, System.ServiceModel.Channels.BufferManager bufferManager) { throw null; }
        public abstract System.ServiceModel.Channels.Message ReadMessage(System.ArraySegment<byte> buffer, System.ServiceModel.Channels.BufferManager bufferManager, string contentType);
        public System.ServiceModel.Channels.Message ReadMessage(System.IO.Stream stream, int maxSizeOfHeaders) { throw null; }
        public abstract System.ServiceModel.Channels.Message ReadMessage(System.IO.Stream stream, int maxSizeOfHeaders, string contentType);
        public override string ToString() { throw null; }
        public System.ArraySegment<byte> WriteMessage(System.ServiceModel.Channels.Message message, int maxMessageSize, System.ServiceModel.Channels.BufferManager bufferManager) { throw null; }
        public abstract System.ArraySegment<byte> WriteMessage(System.ServiceModel.Channels.Message message, int maxMessageSize, System.ServiceModel.Channels.BufferManager bufferManager, int messageOffset);
        public abstract void WriteMessage(System.ServiceModel.Channels.Message message, System.IO.Stream stream);
    }
    public abstract partial class MessageEncoderFactory
    {
        protected MessageEncoderFactory() { }
        public abstract System.ServiceModel.Channels.MessageEncoder Encoder { get; }
        public abstract System.ServiceModel.Channels.MessageVersion MessageVersion { get; }
        [System.MonoTODOAttribute("Not sure how it is used; it just returns Encoder so far")]
        public virtual System.ServiceModel.Channels.MessageEncoder CreateSessionEncoder() { throw null; }
    }
    public abstract partial class MessageEncodingBindingElement : System.ServiceModel.Channels.BindingElement
    {
        public MessageEncodingBindingElement() { }
        [System.MonoTODOAttribute]
        public MessageEncodingBindingElement(System.ServiceModel.Channels.MessageEncodingBindingElement elementToBeCloned) { }
        public abstract System.ServiceModel.Channels.MessageVersion MessageVersion { get; set; }
        public abstract System.ServiceModel.Channels.MessageEncoderFactory CreateMessageEncoderFactory();
        public override T GetProperty<T>(System.ServiceModel.Channels.BindingContext context) { throw null; }
    }
    public abstract partial class MessageFault
    {
        protected MessageFault() { }
        [System.MonoTODOAttribute("is this true?")]
        public virtual string Actor { get { throw null; } }
        public abstract System.ServiceModel.FaultCode Code { get; }
        public abstract bool HasDetail { get; }
        [System.MonoTODOAttribute("is this true?")]
        public virtual string Node { get { throw null; } }
        public abstract System.ServiceModel.FaultReason Reason { get; }
        public static System.ServiceModel.Channels.MessageFault CreateFault(System.ServiceModel.Channels.Message message, int maxBufferSize) { throw null; }
        public static System.ServiceModel.Channels.MessageFault CreateFault(System.ServiceModel.FaultCode code, System.ServiceModel.FaultReason reason) { throw null; }
        public static System.ServiceModel.Channels.MessageFault CreateFault(System.ServiceModel.FaultCode code, System.ServiceModel.FaultReason reason, object detail) { throw null; }
        public static System.ServiceModel.Channels.MessageFault CreateFault(System.ServiceModel.FaultCode code, System.ServiceModel.FaultReason reason, object detail, System.Runtime.Serialization.XmlObjectSerializer serializer) { throw null; }
        public static System.ServiceModel.Channels.MessageFault CreateFault(System.ServiceModel.FaultCode code, System.ServiceModel.FaultReason reason, object detail, System.Runtime.Serialization.XmlObjectSerializer serializer, string actor) { throw null; }
        public static System.ServiceModel.Channels.MessageFault CreateFault(System.ServiceModel.FaultCode code, System.ServiceModel.FaultReason reason, object detail, System.Runtime.Serialization.XmlObjectSerializer serializer, string actor, string node) { throw null; }
        public static System.ServiceModel.Channels.MessageFault CreateFault(System.ServiceModel.FaultCode code, string reason) { throw null; }
        public T GetDetail<T>() { throw null; }
        public T GetDetail<T>(System.Runtime.Serialization.XmlObjectSerializer serializer) { throw null; }
        public System.Xml.XmlDictionaryReader GetReaderAtDetailContents() { throw null; }
        protected virtual System.Xml.XmlDictionaryReader OnGetReaderAtDetailContents() { throw null; }
        protected virtual void OnWriteDetail(System.Xml.XmlDictionaryWriter writer, System.ServiceModel.EnvelopeVersion version) { }
        protected abstract void OnWriteDetailContents(System.Xml.XmlDictionaryWriter writer);
        protected virtual void OnWriteStartDetail(System.Xml.XmlDictionaryWriter writer, System.ServiceModel.EnvelopeVersion version) { }
        public void WriteTo(System.Xml.XmlDictionaryWriter writer, System.ServiceModel.EnvelopeVersion version) { }
        public void WriteTo(System.Xml.XmlWriter writer, System.ServiceModel.EnvelopeVersion version) { }
    }
    public abstract partial class MessageHeader : System.ServiceModel.Channels.MessageHeaderInfo
    {
        protected MessageHeader() { }
        public override string Actor { get { throw null; } }
        public override bool IsReferenceParameter { get { throw null; } }
        public override bool MustUnderstand { get { throw null; } }
        public override bool Relay { get { throw null; } }
        public static System.ServiceModel.Channels.MessageHeader CreateHeader(string name, string ns, object value) { throw null; }
        public static System.ServiceModel.Channels.MessageHeader CreateHeader(string name, string ns, object value, bool mustUnderstand) { throw null; }
        public static System.ServiceModel.Channels.MessageHeader CreateHeader(string name, string ns, object value, bool mustUnderstand, string actor) { throw null; }
        public static System.ServiceModel.Channels.MessageHeader CreateHeader(string name, string ns, object value, bool mustUnderstand, string actor, bool relay) { throw null; }
        public static System.ServiceModel.Channels.MessageHeader CreateHeader(string name, string ns, object value, System.Runtime.Serialization.XmlObjectSerializer serializer) { throw null; }
        public static System.ServiceModel.Channels.MessageHeader CreateHeader(string name, string ns, object value, System.Runtime.Serialization.XmlObjectSerializer serializer, bool mustUnderstand) { throw null; }
        public static System.ServiceModel.Channels.MessageHeader CreateHeader(string name, string ns, object value, System.Runtime.Serialization.XmlObjectSerializer serializer, bool mustUnderstand, string actor) { throw null; }
        public static System.ServiceModel.Channels.MessageHeader CreateHeader(string name, string ns, object value, System.Runtime.Serialization.XmlObjectSerializer serializer, bool mustUnderstand, string actor, bool relay) { throw null; }
        public virtual bool IsMessageVersionSupported(System.ServiceModel.Channels.MessageVersion messageVersion) { throw null; }
        protected abstract void OnWriteHeaderContents(System.Xml.XmlDictionaryWriter writer, System.ServiceModel.Channels.MessageVersion messageVersion);
        protected virtual void OnWriteStartHeader(System.Xml.XmlDictionaryWriter writer, System.ServiceModel.Channels.MessageVersion messageVersion) { }
        public override string ToString() { throw null; }
        public void WriteHeader(System.Xml.XmlDictionaryWriter writer, System.ServiceModel.Channels.MessageVersion messageVersion) { }
        public void WriteHeader(System.Xml.XmlWriter writer, System.ServiceModel.Channels.MessageVersion messageVersion) { }
        protected void WriteHeaderAttributes(System.Xml.XmlDictionaryWriter writer, System.ServiceModel.Channels.MessageVersion messageVersion) { }
        public void WriteHeaderContents(System.Xml.XmlDictionaryWriter writer, System.ServiceModel.Channels.MessageVersion messageVersion) { }
        public void WriteStartHeader(System.Xml.XmlDictionaryWriter writer, System.ServiceModel.Channels.MessageVersion messageVersion) { }
    }
    public abstract partial class MessageHeaderInfo
    {
        protected MessageHeaderInfo() { }
        public abstract string Actor { get; }
        public abstract bool IsReferenceParameter { get; }
        public abstract bool MustUnderstand { get; }
        public abstract string Name { get; }
        public abstract string Namespace { get; }
        public abstract bool Relay { get; }
    }
    public sealed partial class MessageHeaders : System.Collections.Generic.IEnumerable<System.ServiceModel.Channels.MessageHeaderInfo>, System.Collections.IEnumerable
    {
        public MessageHeaders(System.ServiceModel.Channels.MessageHeaders collection) { }
        public MessageHeaders(System.ServiceModel.Channels.MessageVersion version) { }
        public MessageHeaders(System.ServiceModel.Channels.MessageVersion version, int initialSize) { }
        public string Action { get { throw null; } set { } }
        public int Count { get { throw null; } }
        public System.ServiceModel.EndpointAddress FaultTo { get { throw null; } set { } }
        public System.ServiceModel.EndpointAddress From { get { throw null; } set { } }
        public System.ServiceModel.Channels.MessageHeaderInfo this[int index] { get { throw null; } }
        public System.Xml.UniqueId MessageId { get { throw null; } set { } }
        public System.ServiceModel.Channels.MessageVersion MessageVersion { get { throw null; } }
        public System.Xml.UniqueId RelatesTo { get { throw null; } set { } }
        public System.ServiceModel.EndpointAddress ReplyTo { get { throw null; } set { } }
        public System.Uri To { get { throw null; } set { } }
        [System.MonoTODOAttribute]
        public System.ServiceModel.Channels.UnderstoodHeaders UnderstoodHeaders { get { throw null; } }
        public void Add(System.ServiceModel.Channels.MessageHeader header) { }
        public void Clear() { }
        public void CopyHeaderFrom(System.ServiceModel.Channels.Message message, int headerIndex) { }
        public void CopyHeaderFrom(System.ServiceModel.Channels.MessageHeaders collection, int headerIndex) { }
        public void CopyHeadersFrom(System.ServiceModel.Channels.Message message) { }
        public void CopyHeadersFrom(System.ServiceModel.Channels.MessageHeaders collection) { }
        public void CopyTo(System.ServiceModel.Channels.MessageHeaderInfo[] array, int index) { }
        public int FindHeader(string name, string ns) { throw null; }
        public int FindHeader(string name, string ns, params string[] actors) { throw null; }
        public System.Collections.Generic.IEnumerator<System.ServiceModel.Channels.MessageHeaderInfo> GetEnumerator() { throw null; }
        public T GetHeader<T>(int index) { throw null; }
        public T GetHeader<T>(int index, System.Runtime.Serialization.XmlObjectSerializer serializer) { throw null; }
        public T GetHeader<T>(string name, string ns) { throw null; }
        public T GetHeader<T>(string name, string ns, System.Runtime.Serialization.XmlObjectSerializer serializer) { throw null; }
        public T GetHeader<T>(string name, string ns, params string[] actors) { throw null; }
        public System.Xml.XmlDictionaryReader GetReaderAtHeader(int headerIndex) { throw null; }
        public bool HaveMandatoryHeadersBeenUnderstood() { throw null; }
        public bool HaveMandatoryHeadersBeenUnderstood(params string[] actors) { throw null; }
        public void Insert(int headerIndex, System.ServiceModel.Channels.MessageHeader header) { }
        public void RemoveAll(string name, string ns) { }
        public void RemoveAt(int headerIndex) { }
        public void SetAction(System.Xml.XmlDictionaryString action) { }
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { throw null; }
        public void WriteHeader(int headerIndex, System.Xml.XmlDictionaryWriter writer) { }
        public void WriteHeader(int headerIndex, System.Xml.XmlWriter writer) { }
        public void WriteHeaderContents(int headerIndex, System.Xml.XmlDictionaryWriter writer) { }
        public void WriteHeaderContents(int headerIndex, System.Xml.XmlWriter writer) { }
        public void WriteStartHeader(int headerIndex, System.Xml.XmlDictionaryWriter writer) { }
        public void WriteStartHeader(int headerIndex, System.Xml.XmlWriter writer) { }
    }
    public sealed partial class MessageProperties : System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<string, object>>, System.Collections.Generic.IDictionary<string, object>, System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<string, object>>, System.Collections.IEnumerable, System.IDisposable
    {
        public MessageProperties() { }
        public MessageProperties(System.ServiceModel.Channels.MessageProperties properties) { }
        public bool AllowOutputBatching { get { throw null; } set { } }
        public int Count { get { throw null; } }
        public System.ServiceModel.Channels.MessageEncoder Encoder { get { throw null; } set { } }
        public bool IsFixedSize { get { throw null; } }
        public bool IsReadOnly { get { throw null; } }
        public object this[string name] { get { throw null; } set { } }
        public System.Collections.Generic.ICollection<string> Keys { get { throw null; } }
        public System.Collections.Generic.ICollection<object> Values { get { throw null; } }
        public System.Uri Via { get { throw null; } set { } }
        public void Add(string name, object property) { }
        public void Clear() { }
        public bool ContainsKey(string name) { throw null; }
        public void CopyProperties(System.ServiceModel.Channels.MessageProperties properties) { }
        public void Dispose() { }
        public bool Remove(string name) { throw null; }
        void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,System.Object>>.Add(System.Collections.Generic.KeyValuePair<string, object> pair) { }
        bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,System.Object>>.Contains(System.Collections.Generic.KeyValuePair<string, object> pair) { throw null; }
        void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,System.Object>>.CopyTo(System.Collections.Generic.KeyValuePair<string, object>[] array, int index) { }
        bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,System.Object>>.Remove(System.Collections.Generic.KeyValuePair<string, object> pair) { throw null; }
        System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<string, object>> System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.String,System.Object>>.GetEnumerator() { throw null; }
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { throw null; }
        public bool TryGetValue(string name, out object value) { throw null; }
    }
    public enum MessageState
    {
        Closed = 4,
        Copied = 3,
        Created = 0,
        Read = 1,
        Written = 2,
    }
    public sealed partial class MessageVersion
    {
        internal MessageVersion() { }
        public System.ServiceModel.Channels.AddressingVersion Addressing { get { throw null; } }
        public static System.ServiceModel.Channels.MessageVersion Default { get { throw null; } }
        public System.ServiceModel.EnvelopeVersion Envelope { get { throw null; } }
        public static System.ServiceModel.Channels.MessageVersion None { get { throw null; } }
        public static System.ServiceModel.Channels.MessageVersion Soap11 { get { throw null; } }
        public static System.ServiceModel.Channels.MessageVersion Soap11WSAddressing10 { get { throw null; } }
        public static System.ServiceModel.Channels.MessageVersion Soap11WSAddressingAugust2004 { get { throw null; } }
        public static System.ServiceModel.Channels.MessageVersion Soap12 { get { throw null; } }
        public static System.ServiceModel.Channels.MessageVersion Soap12WSAddressing10 { get { throw null; } }
        public static System.ServiceModel.Channels.MessageVersion Soap12WSAddressingAugust2004 { get { throw null; } }
        public static System.ServiceModel.Channels.MessageVersion CreateVersion(System.ServiceModel.EnvelopeVersion envelopeVersion) { throw null; }
        public static System.ServiceModel.Channels.MessageVersion CreateVersion(System.ServiceModel.EnvelopeVersion envelopeVersion, System.ServiceModel.Channels.AddressingVersion addressingVersion) { throw null; }
        public override bool Equals(object obj) { throw null; }
        public override int GetHashCode() { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class PrivacyNoticeBindingElementImporter
    {
        public PrivacyNoticeBindingElementImporter() { }
    }
    public sealed partial class ReliableSessionBindingElement : System.ServiceModel.Channels.BindingElement
    {
        public ReliableSessionBindingElement() { }
        public ReliableSessionBindingElement(bool ordered) { }
        [System.MonoTODOAttribute]
        public System.TimeSpan AcknowledgementInterval { get { throw null; } set { } }
        [System.MonoTODOAttribute]
        public bool FlowControlEnabled { get { throw null; } set { } }
        [System.MonoTODOAttribute]
        public System.TimeSpan InactivityTimeout { get { throw null; } set { } }
        [System.MonoTODOAttribute]
        public int MaxPendingChannels { get { throw null; } set { } }
        [System.MonoTODOAttribute]
        public int MaxRetryCount { get { throw null; } set { } }
        [System.MonoTODOAttribute]
        public int MaxTransferWindowSize { get { throw null; } set { } }
        [System.MonoTODOAttribute]
        public bool Ordered { get { throw null; } set { } }
        [System.MonoTODOAttribute]
        public System.ServiceModel.ReliableMessagingVersion ReliableMessagingVersion { get { throw null; } set { } }
        [System.MonoTODOAttribute]
        public override System.ServiceModel.Channels.IChannelFactory<TChannel> BuildChannelFactory<TChannel>(System.ServiceModel.Channels.BindingContext context) { throw null; }
        [System.MonoTODOAttribute]
        public override bool CanBuildChannelFactory<TChannel>(System.ServiceModel.Channels.BindingContext context) { throw null; }
        public override System.ServiceModel.Channels.BindingElement Clone() { throw null; }
        public override T GetProperty<T>(System.ServiceModel.Channels.BindingContext context) { throw null; }
    }
    public abstract partial class RequestContext : System.IDisposable
    {
        protected RequestContext() { }
        public abstract System.ServiceModel.Channels.Message RequestMessage { get; }
        public abstract void Abort();
        public abstract System.IAsyncResult BeginReply(System.ServiceModel.Channels.Message message, System.AsyncCallback callback, object state);
        public abstract System.IAsyncResult BeginReply(System.ServiceModel.Channels.Message message, System.TimeSpan timeout, System.AsyncCallback callback, object state);
        public abstract void Close();
        public abstract void Close(System.TimeSpan timeout);
        protected virtual void Dispose(bool disposing) { }
        public abstract void EndReply(System.IAsyncResult result);
        public abstract void Reply(System.ServiceModel.Channels.Message message);
        public abstract void Reply(System.ServiceModel.Channels.Message message, System.TimeSpan timeout);
        void System.IDisposable.Dispose() { }
    }
    public abstract partial class SecurityBindingElement : System.ServiceModel.Channels.BindingElement
    {
        internal SecurityBindingElement() { }
        public System.ServiceModel.Security.Tokens.SupportingTokenParameters EndpointSupportingTokenParameters { get { throw null; } }
        public bool IncludeTimestamp { get { throw null; } set { } }
        public System.ServiceModel.Channels.LocalClientSecuritySettings LocalClientSettings { get { throw null; } }
        public System.ServiceModel.MessageSecurityVersion MessageSecurityVersion { get { throw null; } set { } }
        public System.ServiceModel.Channels.SecurityHeaderLayout SecurityHeaderLayout { get { throw null; } set { } }
        protected abstract System.ServiceModel.Channels.IChannelFactory<TChannel> BuildChannelFactoryCore<TChannel>(System.ServiceModel.Channels.BindingContext context);
        public override System.ServiceModel.Channels.IChannelFactory<TChannel> BuildChannelFactory<TChannel>(System.ServiceModel.Channels.BindingContext context) { throw null; }
        [System.MonoTODOAttribute("Implement for TransportSecurityBindingElement")]
        public override bool CanBuildChannelFactory<TChannel>(System.ServiceModel.Channels.BindingContext context) { throw null; }
        public static System.ServiceModel.Channels.SecurityBindingElement CreateSecureConversationBindingElement(System.ServiceModel.Channels.SecurityBindingElement bootstrapSecurity) { throw null; }
        public static System.ServiceModel.Channels.SecurityBindingElement CreateSecureConversationBindingElement(System.ServiceModel.Channels.SecurityBindingElement bootstrapSecurity, bool requireCancellation) { throw null; }
        public static System.ServiceModel.Channels.SecurityBindingElement CreateSecureConversationBindingElement(System.ServiceModel.Channels.SecurityBindingElement bootstrapSecurity, bool requireCancellation, System.ServiceModel.Security.ChannelProtectionRequirements bootstrapProtectionRequirements) { throw null; }
        [System.MonoTODOAttribute]
        public static System.ServiceModel.Channels.TransportSecurityBindingElement CreateUserNameOverTransportBindingElement() { throw null; }
        [System.MonoTODOAttribute]
        public override T GetProperty<T>(System.ServiceModel.Channels.BindingContext context) { throw null; }
    }
    public enum SecurityHeaderLayout
    {
        Lax = 1,
        LaxTimestampFirst = 2,
        LaxTimestampLast = 3,
        Strict = 0,
    }
    [System.MonoTODOAttribute]
    public partial class SslStreamSecurityBindingElement : System.ServiceModel.Channels.BindingElement, System.ServiceModel.Channels.ITransportTokenAssertionProvider, System.ServiceModel.Description.IPolicyExportExtension
    {
        public SslStreamSecurityBindingElement() { }
        public bool RequireClientCertificate { get { throw null; } set { } }
        [System.MonoTODOAttribute]
        public System.Security.Authentication.SslProtocols SslProtocols { get { throw null; } set { } }
        [System.MonoTODOAttribute]
        public override System.ServiceModel.Channels.IChannelFactory<TChannel> BuildChannelFactory<TChannel>(System.ServiceModel.Channels.BindingContext context) { throw null; }
        [System.MonoTODOAttribute]
        public override bool CanBuildChannelFactory<TChannel>(System.ServiceModel.Channels.BindingContext context) { throw null; }
        public override System.ServiceModel.Channels.BindingElement Clone() { throw null; }
        [System.MonoTODOAttribute]
        public override T GetProperty<T>(System.ServiceModel.Channels.BindingContext context) { throw null; }
    }
    public enum SupportedAddressingMode
    {
        Anonymous = 0,
        Mixed = 2,
        NonAnonymous = 1,
    }
    public sealed partial class TcpConnectionPoolSettings
    {
        internal TcpConnectionPoolSettings() { }
        [System.MonoTODOAttribute]
        public string GroupName { get { throw null; } set { } }
        [System.MonoTODOAttribute]
        public System.TimeSpan IdleTimeout { get { throw null; } set { } }
        [System.MonoTODOAttribute]
        public System.TimeSpan LeaseTimeout { get { throw null; } set { } }
        [System.MonoTODOAttribute]
        public int MaxOutboundConnectionsPerEndpoint { get { throw null; } set { } }
    }
    public partial class TcpTransportBindingElement : System.ServiceModel.Channels.ConnectionOrientedTransportBindingElement
    {
        public TcpTransportBindingElement() { }
        protected TcpTransportBindingElement(System.ServiceModel.Channels.TcpTransportBindingElement elementToBeCloned) { }
        public System.ServiceModel.Channels.TcpConnectionPoolSettings ConnectionPoolSettings { get { throw null; } }
        public int ListenBacklog { get { throw null; } set { } }
        public bool PortSharingEnabled { get { throw null; } set { } }
        public override string Scheme { get { throw null; } }
        public bool TeredoEnabled { get { throw null; } set { } }
        public override System.ServiceModel.Channels.IChannelFactory<TChannel> BuildChannelFactory<TChannel>(System.ServiceModel.Channels.BindingContext context) { throw null; }
        public override System.ServiceModel.Channels.BindingElement Clone() { throw null; }
        public override T GetProperty<T>(System.ServiceModel.Channels.BindingContext context) { throw null; }
    }
    [System.MonoTODOAttribute]
    public sealed partial class TextMessageEncodingBindingElement : System.ServiceModel.Channels.MessageEncodingBindingElement, System.ServiceModel.Description.IPolicyExportExtension, System.ServiceModel.Description.IWsdlExportExtension
    {
        public TextMessageEncodingBindingElement() { }
        public TextMessageEncodingBindingElement(System.ServiceModel.Channels.MessageVersion messageVersion, System.Text.Encoding writeEncoding) { }
        public int MaxReadPoolSize { get { throw null; } set { } }
        public int MaxWritePoolSize { get { throw null; } set { } }
        public override System.ServiceModel.Channels.MessageVersion MessageVersion { get { throw null; } set { } }
        public System.Xml.XmlDictionaryReaderQuotas ReaderQuotas { get { throw null; } set { } }
        public System.Text.Encoding WriteEncoding { get { throw null; } set { } }
        public override System.ServiceModel.Channels.IChannelFactory<TChannel> BuildChannelFactory<TChannel>(System.ServiceModel.Channels.BindingContext context) { throw null; }
        public override System.ServiceModel.Channels.BindingElement Clone() { throw null; }
        public override System.ServiceModel.Channels.MessageEncoderFactory CreateMessageEncoderFactory() { throw null; }
        [System.MonoTODOAttribute]
        public override T GetProperty<T>(System.ServiceModel.Channels.BindingContext context) { throw null; }
    }
    public enum TransferSession
    {
        None = 0,
        Ordered = 1,
        Unordered = 2,
    }
    public abstract partial class TransportBindingElement : System.ServiceModel.Channels.BindingElement
    {
        protected TransportBindingElement() { }
        protected TransportBindingElement(System.ServiceModel.Channels.TransportBindingElement elementToBeCloned) { }
        public virtual bool ManualAddressing { get { throw null; } set { } }
        public virtual long MaxBufferPoolSize { get { throw null; } set { } }
        public virtual long MaxReceivedMessageSize { get { throw null; } set { } }
        public abstract string Scheme { get; }
        public override T GetProperty<T>(System.ServiceModel.Channels.BindingContext context) { throw null; }
    }
    public sealed partial class TransportSecurityBindingElement : System.ServiceModel.Channels.SecurityBindingElement
    {
        public TransportSecurityBindingElement() { }
        [System.MonoTODOAttribute]
        protected override System.ServiceModel.Channels.IChannelFactory<TChannel> BuildChannelFactoryCore<TChannel>(System.ServiceModel.Channels.BindingContext context) { throw null; }
        public override System.ServiceModel.Channels.BindingElement Clone() { throw null; }
    }
    public sealed partial class UnderstoodHeaders : System.Collections.Generic.IEnumerable<System.ServiceModel.Channels.MessageHeaderInfo>, System.Collections.IEnumerable
    {
        internal UnderstoodHeaders() { }
        public void Add(System.ServiceModel.Channels.MessageHeaderInfo headerInfo) { }
        public bool Contains(System.ServiceModel.Channels.MessageHeaderInfo headerInfo) { throw null; }
        public System.Collections.Generic.IEnumerator<System.ServiceModel.Channels.MessageHeaderInfo> GetEnumerator() { throw null; }
        public void Remove(System.ServiceModel.Channels.MessageHeaderInfo headerInfo) { }
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { throw null; }
    }
    public static partial class UrlUtility
    {
        public static string UrlDecode(string s, System.Text.Encoding e) { throw null; }
        public static string UrlEncode(string s, System.Text.Encoding e) { throw null; }
    }
    public partial class UseManagedPresentationBindingElementImporter
    {
        public UseManagedPresentationBindingElementImporter() { }
    }
    [System.MonoTODOAttribute]
    public sealed partial class WebSocketTransportSettings : System.IEquatable<System.ServiceModel.Channels.WebSocketTransportSettings>
    {
        public const string BinaryEncoderTransferModeHeader = null;
        public const string BinaryMessageReceivedAction = "http://schemas.microsoft.com/2011/02/websockets/onbinarymessage";
        public const string ConnectionOpenedAction = null;
        public const string SoapContentTypeHeader = null;
        public const string TextMessageReceivedAction = "http://schemas.microsoft.com/2011/02/websockets/ontextmessage";
        public WebSocketTransportSettings() { }
        public bool CreateNotificationOnConnection { get { throw null; } set { } }
        public bool DisablePayloadMasking { get { throw null; } set { } }
        public System.TimeSpan KeepAliveInterval { get { throw null; } set { } }
        public int MaxPendingConnections { get { throw null; } set { } }
        public int ReceiveBufferSize { get { throw null; } set { } }
        public int SendBufferSize { get { throw null; } set { } }
        public string SubProtocol { get { throw null; } set { } }
        public System.ServiceModel.Channels.WebSocketTransportUsage TransportUsage { get { throw null; } set { } }
        public bool Equals(System.ServiceModel.Channels.WebSocketTransportSettings other) { throw null; }
    }
    public enum WebSocketTransportUsage
    {
        Always = 1,
        Never = 2,
        WhenDuplex = 0,
    }
    [System.MonoTODOAttribute]
    public partial class WindowsStreamSecurityBindingElement : System.ServiceModel.Channels.BindingElement, System.ServiceModel.Channels.ISecurityCapabilities, System.ServiceModel.Channels.ITransportTokenAssertionProvider, System.ServiceModel.Description.IPolicyExportExtension
    {
        public WindowsStreamSecurityBindingElement() { }
        public WindowsStreamSecurityBindingElement(System.ServiceModel.Channels.WindowsStreamSecurityBindingElement other) { }
        public System.Net.Security.ProtectionLevel ProtectionLevel { get { throw null; } set { } }
        [System.MonoTODOAttribute]
        System.Net.Security.ProtectionLevel System.ServiceModel.Channels.ISecurityCapabilities.SupportedRequestProtectionLevel { get { throw null; } }
        [System.MonoTODOAttribute]
        System.Net.Security.ProtectionLevel System.ServiceModel.Channels.ISecurityCapabilities.SupportedResponseProtectionLevel { get { throw null; } }
        [System.MonoTODOAttribute]
        bool System.ServiceModel.Channels.ISecurityCapabilities.SupportsClientAuthentication { get { throw null; } }
        [System.MonoTODOAttribute]
        bool System.ServiceModel.Channels.ISecurityCapabilities.SupportsClientWindowsIdentity { get { throw null; } }
        [System.MonoTODOAttribute]
        bool System.ServiceModel.Channels.ISecurityCapabilities.SupportsServerAuthentication { get { throw null; } }
        public override System.ServiceModel.Channels.IChannelFactory<TChannel> BuildChannelFactory<TChannel>(System.ServiceModel.Channels.BindingContext context) { throw null; }
        public override bool CanBuildChannelFactory<TChannel>(System.ServiceModel.Channels.BindingContext context) { throw null; }
        public override System.ServiceModel.Channels.BindingElement Clone() { throw null; }
        public override T GetProperty<T>(System.ServiceModel.Channels.BindingContext context) { throw null; }
    }
    public partial class XmlSerializerImportOptions
    {
        public XmlSerializerImportOptions() { }
    }
}
namespace System.ServiceModel.Description
{
    public partial class ClientCredentials : System.ServiceModel.Description.IEndpointBehavior
    {
        public ClientCredentials() { }
        [System.MonoTODOAttribute]
        protected ClientCredentials(System.ServiceModel.Description.ClientCredentials other) { }
        public System.ServiceModel.Security.X509CertificateInitiatorClientCredential ClientCertificate { get { throw null; } }
        public System.ServiceModel.Security.HttpDigestClientCredential HttpDigest { get { throw null; } }
        public System.ServiceModel.Security.X509CertificateRecipientClientCredential ServiceCertificate { get { throw null; } }
        public System.ServiceModel.Security.UserNamePasswordClientCredential UserName { get { throw null; } }
        public System.ServiceModel.Security.WindowsClientCredential Windows { get { throw null; } }
        [System.MonoTODOAttribute]
        public virtual void ApplyClientBehavior(System.ServiceModel.Description.ServiceEndpoint serviceEndpoint, System.ServiceModel.Dispatcher.ClientRuntime behavior) { }
        public System.ServiceModel.Description.ClientCredentials Clone() { throw null; }
        protected virtual System.ServiceModel.Description.ClientCredentials CloneCore() { throw null; }
        void System.ServiceModel.Description.IEndpointBehavior.AddBindingParameters(System.ServiceModel.Description.ServiceEndpoint endpoint, System.ServiceModel.Channels.BindingParameterCollection parameters) { }
        void System.ServiceModel.Description.IEndpointBehavior.ApplyDispatchBehavior(System.ServiceModel.Description.ServiceEndpoint endpoint, System.ServiceModel.Dispatcher.EndpointDispatcher dispatcher) { }
        void System.ServiceModel.Description.IEndpointBehavior.Validate(System.ServiceModel.Description.ServiceEndpoint endpoint) { }
    }
    [System.Diagnostics.DebuggerDisplayAttribute("Name={name}, Namespace={ns}, ContractType={contractType}")]
    public partial class ContractDescription
    {
        public ContractDescription(string name) { }
        public ContractDescription(string name, string ns) { }
        public System.Collections.Generic.KeyedByTypeCollection<System.ServiceModel.Description.IContractBehavior> Behaviors { get { throw null; } }
        public System.Type CallbackContractType { get { throw null; } set { } }
        public string ConfigurationName { get { throw null; } set { } }
        [System.MonoTODOAttribute]
        public System.Collections.ObjectModel.KeyedCollection<System.Type, System.ServiceModel.Description.IContractBehavior> ContractBehaviors { get { throw null; } }
        public System.Type ContractType { get { throw null; } set { } }
        public bool HasProtectionLevel { get { throw null; } }
        public string Name { get { throw null; } set { } }
        public string Namespace { get { throw null; } set { } }
        public System.ServiceModel.Description.OperationDescriptionCollection Operations { get { throw null; } }
        public System.Net.Security.ProtectionLevel ProtectionLevel { get { throw null; } set { } }
        public System.ServiceModel.SessionMode SessionMode { get { throw null; } set { } }
        public static System.ServiceModel.Description.ContractDescription GetContract(System.Type contractType) { throw null; }
        public static System.ServiceModel.Description.ContractDescription GetContract(System.Type contractType, object serviceImplementation) { throw null; }
        public static System.ServiceModel.Description.ContractDescription GetContract(System.Type contractType, System.Type serviceType) { throw null; }
        public System.Collections.ObjectModel.Collection<System.ServiceModel.Description.ContractDescription> GetInheritedContracts() { throw null; }
    }
    public partial class DataContractSerializerOperationBehavior : System.ServiceModel.Description.IOperationBehavior, System.ServiceModel.Description.IWsdlExportExtension
    {
        public DataContractSerializerOperationBehavior(System.ServiceModel.Description.OperationDescription operation) { }
        public DataContractSerializerOperationBehavior(System.ServiceModel.Description.OperationDescription operation, System.ServiceModel.DataContractFormatAttribute dataContractFormatAttribute) { }
        public System.ServiceModel.DataContractFormatAttribute DataContractFormatAttribute { get { throw null; } }
        public System.Runtime.Serialization.DataContractResolver DataContractResolver { get { throw null; } set { } }
        public bool IgnoreExtensionDataObject { get { throw null; } set { } }
        public int MaxItemsInObjectGraph { get { throw null; } set { } }
        public virtual System.Runtime.Serialization.XmlObjectSerializer CreateSerializer(System.Type type, string name, string ns, System.Collections.Generic.IList<System.Type> knownTypes) { throw null; }
        public virtual System.Runtime.Serialization.XmlObjectSerializer CreateSerializer(System.Type type, System.Xml.XmlDictionaryString name, System.Xml.XmlDictionaryString ns, System.Collections.Generic.IList<System.Type> knownTypes) { throw null; }
        void System.ServiceModel.Description.IOperationBehavior.AddBindingParameters(System.ServiceModel.Description.OperationDescription description, System.ServiceModel.Channels.BindingParameterCollection parameters) { }
        void System.ServiceModel.Description.IOperationBehavior.ApplyClientBehavior(System.ServiceModel.Description.OperationDescription description, System.ServiceModel.Dispatcher.ClientOperation proxy) { }
        void System.ServiceModel.Description.IOperationBehavior.ApplyDispatchBehavior(System.ServiceModel.Description.OperationDescription description, System.ServiceModel.Dispatcher.DispatchOperation dispatch) { }
        void System.ServiceModel.Description.IOperationBehavior.Validate(System.ServiceModel.Description.OperationDescription description) { }
    }
    [System.Diagnostics.DebuggerDisplayAttribute("Name={name}, Action={action}, DetailType={detailType}")]
    public partial class FaultDescription
    {
        public FaultDescription(string action) { }
        public string Action { get { throw null; } }
        public System.Type DetailType { get { throw null; } set { } }
        public bool HasProtectionLevel { get { throw null; } }
        public string Name { get { throw null; } set { } }
        public string Namespace { get { throw null; } set { } }
        public System.Net.Security.ProtectionLevel ProtectionLevel { get { throw null; } set { } }
    }
    public partial class FaultDescriptionCollection : System.Collections.ObjectModel.Collection<System.ServiceModel.Description.FaultDescription>
    {
        internal FaultDescriptionCollection() { }
        public System.ServiceModel.Description.FaultDescription Find(string action) { throw null; }
        public System.Collections.ObjectModel.Collection<System.ServiceModel.Description.FaultDescription> FindAll(string action) { throw null; }
    }
    public partial interface IContractBehavior
    {
        void AddBindingParameters(System.ServiceModel.Description.ContractDescription contractDescription, System.ServiceModel.Description.ServiceEndpoint endpoint, System.ServiceModel.Channels.BindingParameterCollection bindingParameters);
        void ApplyClientBehavior(System.ServiceModel.Description.ContractDescription contractDescription, System.ServiceModel.Description.ServiceEndpoint endpoint, System.ServiceModel.Dispatcher.ClientRuntime clientRuntime);
        void ApplyDispatchBehavior(System.ServiceModel.Description.ContractDescription contractDescription, System.ServiceModel.Description.ServiceEndpoint endpoint, System.ServiceModel.Dispatcher.DispatchRuntime dispatchRuntime);
        void Validate(System.ServiceModel.Description.ContractDescription contractDescription, System.ServiceModel.Description.ServiceEndpoint endpoint);
    }
    public partial interface IEndpointBehavior
    {
        void AddBindingParameters(System.ServiceModel.Description.ServiceEndpoint endpoint, System.ServiceModel.Channels.BindingParameterCollection bindingParameters);
        void ApplyClientBehavior(System.ServiceModel.Description.ServiceEndpoint endpoint, System.ServiceModel.Dispatcher.ClientRuntime clientRuntime);
        void ApplyDispatchBehavior(System.ServiceModel.Description.ServiceEndpoint endpoint, System.ServiceModel.Dispatcher.EndpointDispatcher endpointDispatcher);
        void Validate(System.ServiceModel.Description.ServiceEndpoint endpoint);
    }
    public partial interface IOperationBehavior
    {
        void AddBindingParameters(System.ServiceModel.Description.OperationDescription operationDescription, System.ServiceModel.Channels.BindingParameterCollection bindingParameters);
        void ApplyClientBehavior(System.ServiceModel.Description.OperationDescription operationDescription, System.ServiceModel.Dispatcher.ClientOperation clientOperation);
        void ApplyDispatchBehavior(System.ServiceModel.Description.OperationDescription operationDescription, System.ServiceModel.Dispatcher.DispatchOperation dispatchOperation);
        void Validate(System.ServiceModel.Description.OperationDescription operationDescription);
    }
    public partial interface IPolicyExportExtension
    {
    }
    public partial interface IPolicyImportExtension
    {
    }
    public partial interface IWsdlExportExtension
    {
    }
    public partial interface IWsdlImportExtension
    {
    }
    public enum ListenUriMode
    {
        Explicit = 0,
        Unique = 1,
    }
    public partial class MessageBodyDescription
    {
        public MessageBodyDescription() { }
        public System.ServiceModel.Description.MessagePartDescriptionCollection Parts { get { throw null; } }
        public System.ServiceModel.Description.MessagePartDescription ReturnValue { get { throw null; } set { } }
        public string WrapperName { get { throw null; } set { } }
        public string WrapperNamespace { get { throw null; } set { } }
    }
    [System.Diagnostics.DebuggerDisplayAttribute("Action={action}, Direction={direction}, MessageType={messageType}")]
    public partial class MessageDescription
    {
        public MessageDescription(string action, System.ServiceModel.Description.MessageDirection direction) { }
        public string Action { get { throw null; } }
        public System.ServiceModel.Description.MessageBodyDescription Body { get { throw null; } }
        public System.ServiceModel.Description.MessageDirection Direction { get { throw null; } }
        public bool HasProtectionLevel { get { throw null; } }
        public System.ServiceModel.Description.MessageHeaderDescriptionCollection Headers { get { throw null; } }
        public System.Type MessageType { get { throw null; } set { } }
        public System.ServiceModel.Description.MessagePropertyDescriptionCollection Properties { get { throw null; } }
        public System.Net.Security.ProtectionLevel ProtectionLevel { get { throw null; } set { } }
    }
    public partial class MessageDescriptionCollection : System.Collections.ObjectModel.Collection<System.ServiceModel.Description.MessageDescription>
    {
        internal MessageDescriptionCollection() { }
        public System.ServiceModel.Description.MessageDescription Find(string action) { throw null; }
        public System.Collections.ObjectModel.Collection<System.ServiceModel.Description.MessageDescription> FindAll(string action) { throw null; }
    }
    public enum MessageDirection
    {
        Input = 0,
        Output = 1,
    }
    [System.MonoTODOAttribute]
    public partial class MessageHeaderDescription : System.ServiceModel.Description.MessagePartDescription
    {
        public MessageHeaderDescription(string name, string ns) : base (default(string), default(string)) { }
        public string Actor { get { throw null; } set { } }
        public bool MustUnderstand { get { throw null; } set { } }
        public bool Relay { get { throw null; } set { } }
        public bool TypedHeader { get { throw null; } set { } }
    }
    public partial class MessageHeaderDescriptionCollection : System.Collections.ObjectModel.KeyedCollection<System.Xml.XmlQualifiedName, System.ServiceModel.Description.MessageHeaderDescription>
    {
        internal MessageHeaderDescriptionCollection() { }
        protected override System.Xml.XmlQualifiedName GetKeyForItem(System.ServiceModel.Description.MessageHeaderDescription item) { throw null; }
    }
    [System.Diagnostics.DebuggerDisplayAttribute("Name={name}, Namespace={ns}, Type={Type}, Index={index}}")]
    public partial class MessagePartDescription
    {
        public MessagePartDescription(string name, string ns) { }
        public bool HasProtectionLevel { get { throw null; } }
        public int Index { get { throw null; } set { } }
        public System.Reflection.MemberInfo MemberInfo { get { throw null; } set { } }
        public bool Multiple { get { throw null; } set { } }
        public string Name { get { throw null; } }
        public string Namespace { get { throw null; } }
        public System.Net.Security.ProtectionLevel ProtectionLevel { get { throw null; } set { } }
        public System.Type Type { get { throw null; } set { } }
    }
    public partial class MessagePartDescriptionCollection : System.Collections.ObjectModel.KeyedCollection<System.Xml.XmlQualifiedName, System.ServiceModel.Description.MessagePartDescription>
    {
        internal MessagePartDescriptionCollection() { }
        protected override System.Xml.XmlQualifiedName GetKeyForItem(System.ServiceModel.Description.MessagePartDescription item) { throw null; }
    }
    [System.MonoTODOAttribute]
    public partial class MessagePropertyDescription : System.ServiceModel.Description.MessagePartDescription
    {
        public MessagePropertyDescription(string name) : base (default(string), default(string)) { }
    }
    public partial class MessagePropertyDescriptionCollection : System.Collections.ObjectModel.KeyedCollection<string, System.ServiceModel.Description.MessagePropertyDescription>
    {
        internal MessagePropertyDescriptionCollection() { }
        protected override string GetKeyForItem(System.ServiceModel.Description.MessagePropertyDescription item) { throw null; }
    }
    public enum MetadataExchangeClientMode
    {
        HttpGet = 1,
        MetadataExchange = 0,
    }
    [System.Diagnostics.DebuggerDisplayAttribute("Name={name}, IsInitiating={isInitiating}, IsTerminating={isTerminating}")]
    public partial class OperationDescription
    {
        public OperationDescription(string name, System.ServiceModel.Description.ContractDescription declaringContract) { }
        public System.Reflection.MethodInfo BeginMethod { get { throw null; } set { } }
        public System.Collections.Generic.KeyedByTypeCollection<System.ServiceModel.Description.IOperationBehavior> Behaviors { get { throw null; } }
        public System.ServiceModel.Description.ContractDescription DeclaringContract { get { throw null; } set { } }
        public System.Reflection.MethodInfo EndMethod { get { throw null; } set { } }
        public System.ServiceModel.Description.FaultDescriptionCollection Faults { get { throw null; } }
        public bool HasProtectionLevel { get { throw null; } }
        public bool IsInitiating { get { throw null; } set { } }
        public bool IsOneWay { get { throw null; } }
        public bool IsTerminating { get { throw null; } set { } }
        public System.Collections.ObjectModel.Collection<System.Type> KnownTypes { get { throw null; } }
        public System.ServiceModel.Description.MessageDescriptionCollection Messages { get { throw null; } }
        public string Name { get { throw null; } }
        [System.MonoTODOAttribute]
        public System.Collections.ObjectModel.KeyedCollection<System.Type, System.ServiceModel.Description.IOperationBehavior> OperationBehaviors { get { throw null; } }
        public System.Net.Security.ProtectionLevel ProtectionLevel { get { throw null; } set { } }
        public System.Reflection.MethodInfo SyncMethod { get { throw null; } set { } }
        [System.MonoTODOAttribute]
        public System.Reflection.MethodInfo TaskMethod { get { throw null; } set { } }
    }
    public partial class OperationDescriptionCollection : System.Collections.ObjectModel.Collection<System.ServiceModel.Description.OperationDescription>
    {
        internal OperationDescriptionCollection() { }
        public System.ServiceModel.Description.OperationDescription Find(string name) { throw null; }
        public System.Collections.ObjectModel.Collection<System.ServiceModel.Description.OperationDescription> FindAll(string name) { throw null; }
        protected override void InsertItem(int index, System.ServiceModel.Description.OperationDescription item) { }
        protected override void SetItem(int index, System.ServiceModel.Description.OperationDescription item) { }
    }
    public enum PrincipalPermissionMode
    {
        Custom = 3,
        None = 0,
        UseAspNetRoles = 2,
        UseWindowsGroups = 1,
    }
    [System.FlagsAttribute]
    public enum ServiceContractGenerationOptions
    {
        AsynchronousMethods = 1,
        ChannelInterface = 2,
        ClientClass = 8,
        EventBasedAsynchronousMethods = 32,
        InternalTypes = 4,
        None = 0,
        TypedMessages = 16,
    }
    [System.Diagnostics.DebuggerDisplayAttribute("Address={address}")]
    [System.Diagnostics.DebuggerDisplayAttribute("Name={name}")]
    public partial class ServiceEndpoint
    {
        public ServiceEndpoint(System.ServiceModel.Description.ContractDescription contract) { }
        public ServiceEndpoint(System.ServiceModel.Description.ContractDescription contract, System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress address) { }
        public System.ServiceModel.EndpointAddress Address { get { throw null; } set { } }
        public System.Collections.Generic.KeyedByTypeCollection<System.ServiceModel.Description.IEndpointBehavior> Behaviors { get { throw null; } }
        public System.ServiceModel.Channels.Binding Binding { get { throw null; } set { } }
        public System.ServiceModel.Description.ContractDescription Contract { get { throw null; } set { } }
        public System.Collections.ObjectModel.KeyedCollection<System.Type, System.ServiceModel.Description.IEndpointBehavior> EndpointBehaviors { get { throw null; } }
        public bool IsSystemEndpoint { get { throw null; } set { } }
        public System.Uri ListenUri { get { throw null; } set { } }
        public System.ServiceModel.Description.ListenUriMode ListenUriMode { get { throw null; } set { } }
        public string Name { get { throw null; } set { } }
    }
    public partial class XmlSerializerOperationBehavior : System.ServiceModel.Description.IOperationBehavior
    {
        public XmlSerializerOperationBehavior(System.ServiceModel.Description.OperationDescription operation) { }
        public XmlSerializerOperationBehavior(System.ServiceModel.Description.OperationDescription operation, System.ServiceModel.XmlSerializerFormatAttribute attribute) { }
        public System.ServiceModel.XmlSerializerFormatAttribute XmlSerializerFormatAttribute { get { throw null; } }
        [System.MonoTODOAttribute]
        public System.Collections.ObjectModel.Collection<System.Xml.Serialization.XmlMapping> GetXmlMappings() { throw null; }
        void System.ServiceModel.Description.IOperationBehavior.AddBindingParameters(System.ServiceModel.Description.OperationDescription description, System.ServiceModel.Channels.BindingParameterCollection parameters) { }
        void System.ServiceModel.Description.IOperationBehavior.ApplyClientBehavior(System.ServiceModel.Description.OperationDescription description, System.ServiceModel.Dispatcher.ClientOperation proxy) { }
        void System.ServiceModel.Description.IOperationBehavior.ApplyDispatchBehavior(System.ServiceModel.Description.OperationDescription description, System.ServiceModel.Dispatcher.DispatchOperation dispatch) { }
        void System.ServiceModel.Description.IOperationBehavior.Validate(System.ServiceModel.Description.OperationDescription description) { }
    }
}
namespace System.ServiceModel.Dispatcher
{
    public sealed partial class ClientOperation
    {
        public ClientOperation(System.ServiceModel.Dispatcher.ClientRuntime parent, string name, string action) { }
        public ClientOperation(System.ServiceModel.Dispatcher.ClientRuntime parent, string name, string action, string replyAction) { }
        public string Action { get { throw null; } }
        public System.Reflection.MethodInfo BeginMethod { get { throw null; } set { } }
        [System.MonoTODOAttribute]
        public System.Collections.Generic.ICollection<System.ServiceModel.Dispatcher.IParameterInspector> ClientParameterInspectors { get { throw null; } }
        public bool DeserializeReply { get { throw null; } set { } }
        public System.Reflection.MethodInfo EndMethod { get { throw null; } set { } }
        public System.Collections.Generic.SynchronizedCollection<System.ServiceModel.Dispatcher.FaultContractInfo> FaultContractInfos { get { throw null; } }
        public System.ServiceModel.Dispatcher.IClientMessageFormatter Formatter { get { throw null; } set { } }
        public bool IsInitiating { get { throw null; } set { } }
        public bool IsOneWay { get { throw null; } set { } }
        public bool IsTerminating { get { throw null; } set { } }
        public string Name { get { throw null; } }
        public System.Collections.Generic.SynchronizedCollection<System.ServiceModel.Dispatcher.IParameterInspector> ParameterInspectors { get { throw null; } }
        public System.ServiceModel.Dispatcher.ClientRuntime Parent { get { throw null; } }
        public string ReplyAction { get { throw null; } }
        public bool SerializeRequest { get { throw null; } set { } }
        public System.Reflection.MethodInfo SyncMethod { get { throw null; } set { } }
        [System.MonoTODOAttribute]
        public System.Reflection.MethodInfo TaskMethod { get { throw null; } set { } }
        [System.MonoTODOAttribute]
        public System.Type TaskTResult { get { throw null; } set { } }
    }
    public sealed partial class ClientRuntime
    {
        internal ClientRuntime() { }
        public System.Type CallbackClientType { get { throw null; } set { } }
        public System.Collections.Generic.SynchronizedCollection<System.ServiceModel.Dispatcher.IChannelInitializer> ChannelInitializers { get { throw null; } }
        [System.MonoTODOAttribute]
        public System.Collections.Generic.ICollection<System.ServiceModel.Dispatcher.IClientMessageInspector> ClientMessageInspectors { get { throw null; } }
        [System.MonoTODOAttribute]
        public System.Collections.Generic.ICollection<System.ServiceModel.Dispatcher.ClientOperation> ClientOperations { get { throw null; } }
        public System.Type ContractClientType { get { throw null; } set { } }
        public string ContractName { get { throw null; } }
        public string ContractNamespace { get { throw null; } }
        public System.Collections.Generic.SynchronizedCollection<System.ServiceModel.Dispatcher.IInteractiveChannelInitializer> InteractiveChannelInitializers { get { throw null; } }
        public bool ManualAddressing { get { throw null; } set { } }
        public int MaxFaultSize { get { throw null; } set { } }
        public System.Collections.Generic.SynchronizedCollection<System.ServiceModel.Dispatcher.IClientMessageInspector> MessageInspectors { get { throw null; } }
        [System.MonoTODOAttribute]
        public bool MessageVersionNoneFaultsEnabled { get { throw null; } set { } }
        public System.Collections.ObjectModel.KeyedCollection<string, System.ServiceModel.Dispatcher.ClientOperation> Operations { get { throw null; } }
        public System.ServiceModel.Dispatcher.IClientOperationSelector OperationSelector { get { throw null; } set { } }
        [System.MonoTODOAttribute]
        public System.ServiceModel.Dispatcher.ClientOperation UnhandledClientOperation { get { throw null; } }
        public bool ValidateMustUnderstand { get { throw null; } set { } }
        public System.Uri Via { get { throw null; } set { } }
    }
    public sealed partial class DispatchOperation
    {
        public DispatchOperation(System.ServiceModel.Dispatcher.DispatchRuntime parent, string name, string action) { }
        public DispatchOperation(System.ServiceModel.Dispatcher.DispatchRuntime parent, string name, string action, string replyAction) { }
        public string Action { get { throw null; } }
        public bool AutoDisposeParameters { get { throw null; } set { } }
        public bool DeserializeRequest { get { throw null; } set { } }
        public System.ServiceModel.Dispatcher.IDispatchMessageFormatter Formatter { get { throw null; } set { } }
        public bool IsOneWay { get { throw null; } }
        public string Name { get { throw null; } }
        public System.ServiceModel.Dispatcher.DispatchRuntime Parent { get { throw null; } }
        public bool SerializeReply { get { throw null; } set { } }
    }
    public sealed partial class DispatchRuntime
    {
        internal DispatchRuntime() { }
        public System.ServiceModel.Dispatcher.DispatchOperation UnhandledDispatchOperation { get { throw null; } set { } }
    }
    public sealed partial class EndpointDispatcher
    {
        internal EndpointDispatcher() { }
    }
    public partial class FaultContractInfo
    {
        public FaultContractInfo(string action, System.Type detail) { }
        public string Action { get { throw null; } }
        public System.Type Detail { get { throw null; } }
    }
    public partial interface IChannelInitializer
    {
        void Initialize(System.ServiceModel.IClientChannel channel);
    }
    public partial interface IClientMessageFormatter
    {
        object DeserializeReply(System.ServiceModel.Channels.Message message, object[] parameters);
        System.ServiceModel.Channels.Message SerializeRequest(System.ServiceModel.Channels.MessageVersion messageVersion, object[] parameters);
    }
    public partial interface IClientMessageInspector
    {
        void AfterReceiveReply(ref System.ServiceModel.Channels.Message reply, object correlationState);
        object BeforeSendRequest(ref System.ServiceModel.Channels.Message request, System.ServiceModel.IClientChannel channel);
    }
    public partial interface IClientOperationSelector
    {
        bool AreParametersRequiredForSelection { get; }
        string SelectOperation(System.Reflection.MethodBase method, object[] parameters);
    }
    public partial interface IDispatchMessageFormatter
    {
        void DeserializeRequest(System.ServiceModel.Channels.Message message, object[] parameters);
        System.ServiceModel.Channels.Message SerializeReply(System.ServiceModel.Channels.MessageVersion messageVersion, object[] parameters, object result);
    }
    public partial interface IInteractiveChannelInitializer
    {
        System.IAsyncResult BeginDisplayInitializationUI(System.ServiceModel.IClientChannel channel, System.AsyncCallback callback, object state);
        void EndDisplayInitializationUI(System.IAsyncResult result);
    }
    public partial interface IParameterInspector
    {
        void AfterCall(string operationName, object[] outputs, object returnValue, object correlationState);
        object BeforeCall(string operationName, object[] inputs);
    }
}
namespace System.ServiceModel.MsmqIntegration
{
    public enum MsmqIntegrationSecurityMode
    {
        None = 0,
        Transport = 1,
    }
    public enum MsmqMessageSerializationFormat
    {
        ActiveX = 2,
        Binary = 1,
        ByteArray = 3,
        Stream = 4,
        Xml = 0,
    }
}
namespace System.ServiceModel.Security
{
    public abstract partial class BasicSecurityProfileVersion
    {
        internal BasicSecurityProfileVersion() { }
        public static System.ServiceModel.Security.BasicSecurityProfileVersion BasicSecurityProfile10 { get { throw null; } }
    }
    public partial class ChannelProtectionRequirements
    {
        public ChannelProtectionRequirements() { }
        public ChannelProtectionRequirements(System.ServiceModel.Security.ChannelProtectionRequirements other) { }
        public System.ServiceModel.Security.ScopedMessagePartSpecification IncomingEncryptionParts { get { throw null; } }
        public System.ServiceModel.Security.ScopedMessagePartSpecification IncomingSignatureParts { get { throw null; } }
        public bool IsReadOnly { get { throw null; } }
        public System.ServiceModel.Security.ScopedMessagePartSpecification OutgoingEncryptionParts { get { throw null; } }
        public System.ServiceModel.Security.ScopedMessagePartSpecification OutgoingSignatureParts { get { throw null; } }
        public void Add(System.ServiceModel.Security.ChannelProtectionRequirements protectionRequirements) { }
        public void Add(System.ServiceModel.Security.ChannelProtectionRequirements protectionRequirements, bool channelScopeOnly) { }
        public System.ServiceModel.Security.ChannelProtectionRequirements CreateInverse() { throw null; }
        public void MakeReadOnly() { }
    }
    public sealed partial class HttpDigestClientCredential
    {
        internal HttpDigestClientCredential() { }
        public System.Security.Principal.TokenImpersonationLevel AllowedImpersonationLevel { get { throw null; } set { } }
        public System.Net.NetworkCredential ClientCredential { get { throw null; } set { } }
    }
    public partial class MessagePartSpecification
    {
        public MessagePartSpecification() { }
        public MessagePartSpecification(bool isBodyIncluded) { }
        public MessagePartSpecification(bool isBodyIncluded, params System.Xml.XmlQualifiedName[] headerTypes) { }
        public MessagePartSpecification(params System.Xml.XmlQualifiedName[] headerTypes) { }
        public System.Collections.Generic.ICollection<System.Xml.XmlQualifiedName> HeaderTypes { get { throw null; } }
        public bool IsBodyIncluded { get { throw null; } set { } }
        public bool IsReadOnly { get { throw null; } }
        public static System.ServiceModel.Security.MessagePartSpecification NoParts { get { throw null; } }
        public void Clear() { }
        public void MakeReadOnly() { }
        public void Union(System.ServiceModel.Security.MessagePartSpecification specification) { }
    }
    [System.SerializableAttribute]
    public partial class MessageSecurityException : System.ServiceModel.CommunicationException
    {
        public MessageSecurityException() { }
        protected MessageSecurityException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
        public MessageSecurityException(string message) { }
        public MessageSecurityException(string message, System.Exception innerException) { }
        public override void GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext ctx) { }
    }
    public partial class ScopedMessagePartSpecification
    {
        public ScopedMessagePartSpecification() { }
        public ScopedMessagePartSpecification(System.ServiceModel.Security.ScopedMessagePartSpecification other) { }
        public System.Collections.Generic.ICollection<string> Actions { get { throw null; } }
        public System.ServiceModel.Security.MessagePartSpecification ChannelParts { get { throw null; } }
        public bool IsReadOnly { get { throw null; } }
        public void AddParts(System.ServiceModel.Security.MessagePartSpecification parts) { }
        public void AddParts(System.ServiceModel.Security.MessagePartSpecification parts, string action) { }
        public void MakeReadOnly() { }
        public bool TryGetParts(string action, bool excludeChannelScope, out System.ServiceModel.Security.MessagePartSpecification parts) { throw null; }
        public bool TryGetParts(string action, out System.ServiceModel.Security.MessagePartSpecification parts) { throw null; }
    }
    public abstract partial class SecureConversationVersion
    {
        protected SecureConversationVersion() { }
        public static System.ServiceModel.Security.SecureConversationVersion Default { get { throw null; } }
        public System.Xml.XmlDictionaryString Namespace { get { throw null; } }
        public System.Xml.XmlDictionaryString Prefix { get { throw null; } }
        public static System.ServiceModel.Security.SecureConversationVersion WSSecureConversation13 { get { throw null; } }
        public static System.ServiceModel.Security.SecureConversationVersion WSSecureConversationFeb2005 { get { throw null; } }
    }
    [System.SerializableAttribute]
    public partial class SecurityAccessDeniedException : System.ServiceModel.CommunicationException
    {
        public SecurityAccessDeniedException() { }
        protected SecurityAccessDeniedException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
        public SecurityAccessDeniedException(string message) { }
        public SecurityAccessDeniedException(string message, System.Exception innerException) { }
    }
    [System.SerializableAttribute]
    public partial class SecurityNegotiationException : System.ServiceModel.CommunicationException
    {
        public SecurityNegotiationException() { }
        protected SecurityNegotiationException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
        public SecurityNegotiationException(string message) { }
        public SecurityNegotiationException(string message, System.Exception innerException) { }
    }
    public abstract partial class SecurityPolicyVersion
    {
        protected SecurityPolicyVersion() { }
        public string Namespace { get { throw null; } }
        public string Prefix { get { throw null; } }
        public static System.ServiceModel.Security.SecurityPolicyVersion WSSecurityPolicy11 { get { throw null; } }
        public static System.ServiceModel.Security.SecurityPolicyVersion WSSecurityPolicy12 { get { throw null; } }
    }
    public abstract partial class SecurityVersion
    {
        protected SecurityVersion() { }
        public static System.ServiceModel.Security.SecurityVersion WSSecurity10 { get { throw null; } }
        public static System.ServiceModel.Security.SecurityVersion WSSecurity11 { get { throw null; } }
    }
    public abstract partial class TrustVersion
    {
        protected TrustVersion() { }
        public static System.ServiceModel.Security.TrustVersion Default { get { throw null; } }
        public System.Xml.XmlDictionaryString Namespace { get { throw null; } }
        public System.Xml.XmlDictionaryString Prefix { get { throw null; } }
        public static System.ServiceModel.Security.TrustVersion WSTrust13 { get { throw null; } }
        public static System.ServiceModel.Security.TrustVersion WSTrustFeb2005 { get { throw null; } }
    }
    public sealed partial class UserNamePasswordClientCredential
    {
        internal UserNamePasswordClientCredential() { }
        public string Password { get { throw null; } set { } }
        public string UserName { get { throw null; } set { } }
    }
    public enum UserNamePasswordValidationMode
    {
        Custom = 2,
        MembershipProvider = 1,
        Windows = 0,
    }
    public sealed partial class WindowsClientCredential
    {
        internal WindowsClientCredential() { }
        public System.Security.Principal.TokenImpersonationLevel AllowedImpersonationLevel { get { throw null; } set { } }
        public bool AllowNtlm { get { throw null; } set { } }
        [System.MonoTODOAttribute]
        public System.Net.NetworkCredential ClientCredential { get { throw null; } set { } }
    }
    public sealed partial class X509CertificateInitiatorClientCredential
    {
        internal X509CertificateInitiatorClientCredential() { }
        public System.Security.Cryptography.X509Certificates.X509Certificate2 Certificate { get { throw null; } set { } }
        public void SetCertificate(System.Security.Cryptography.X509Certificates.StoreLocation storeLocation, System.Security.Cryptography.X509Certificates.StoreName storeName, System.Security.Cryptography.X509Certificates.X509FindType findType, object findValue) { }
        public void SetCertificate(string subjectName, System.Security.Cryptography.X509Certificates.StoreLocation storeLocation, System.Security.Cryptography.X509Certificates.StoreName storeName) { }
    }
    public sealed partial class X509CertificateRecipientClientCredential
    {
        internal X509CertificateRecipientClientCredential() { }
        public System.ServiceModel.Security.X509ServiceCertificateAuthentication Authentication { get { throw null; } }
        public System.Security.Cryptography.X509Certificates.X509Certificate2 DefaultCertificate { get { throw null; } set { } }
        public System.Collections.Generic.Dictionary<System.Uri, System.Security.Cryptography.X509Certificates.X509Certificate2> ScopedCertificates { get { throw null; } }
        [System.MonoTODOAttribute]
        public System.ServiceModel.Security.X509ServiceCertificateAuthentication SslCertificateAuthentication { get { throw null; } set { } }
        public void SetDefaultCertificate(System.Security.Cryptography.X509Certificates.StoreLocation storeLocation, System.Security.Cryptography.X509Certificates.StoreName storeName, System.Security.Cryptography.X509Certificates.X509FindType findType, object findValue) { }
        public void SetDefaultCertificate(string subjectName, System.Security.Cryptography.X509Certificates.StoreLocation storeLocation, System.Security.Cryptography.X509Certificates.StoreName storeName) { }
        public void SetScopedCertificate(System.Security.Cryptography.X509Certificates.StoreLocation storeLocation, System.Security.Cryptography.X509Certificates.StoreName storeName, System.Security.Cryptography.X509Certificates.X509FindType findType, object findValue, System.Uri targetService) { }
        public void SetScopedCertificate(string subjectName, System.Security.Cryptography.X509Certificates.StoreLocation storeLocation, System.Security.Cryptography.X509Certificates.StoreName storeName, System.Uri targetService) { }
    }
    [System.MonoTODOAttribute]
    public partial class X509ServiceCertificateAuthentication
    {
        public X509ServiceCertificateAuthentication() { }
        public System.ServiceModel.Security.X509CertificateValidationMode CertificateValidationMode { get { throw null; } set { } }
        public System.IdentityModel.Selectors.X509CertificateValidator CustomCertificateValidator { get { throw null; } set { } }
        public System.Security.Cryptography.X509Certificates.X509RevocationMode RevocationMode { get { throw null; } set { } }
        public System.Security.Cryptography.X509Certificates.StoreLocation TrustedStoreLocation { get { throw null; } set { } }
    }
}
namespace System.ServiceModel.Security.Tokens
{
    public partial class SecureConversationSecurityTokenParameters : System.ServiceModel.Security.Tokens.SecurityTokenParameters
    {
        public SecureConversationSecurityTokenParameters() { }
        public SecureConversationSecurityTokenParameters(System.ServiceModel.Channels.SecurityBindingElement bootstrapSecurityBindingElement) { }
        public SecureConversationSecurityTokenParameters(System.ServiceModel.Channels.SecurityBindingElement bootstrapSecurityBindingElement, bool requireCancellation) { }
        protected SecureConversationSecurityTokenParameters(System.ServiceModel.Security.Tokens.SecureConversationSecurityTokenParameters other) { }
        public System.ServiceModel.Channels.SecurityBindingElement BootstrapSecurityBindingElement { get { throw null; } set { } }
        protected override bool HasAsymmetricKey { get { throw null; } }
        public bool RequireCancellation { get { throw null; } set { } }
        protected override bool SupportsClientAuthentication { get { throw null; } }
        protected override bool SupportsClientWindowsIdentity { get { throw null; } }
        protected override bool SupportsServerAuthentication { get { throw null; } }
        protected override System.ServiceModel.Security.Tokens.SecurityTokenParameters CloneCore() { throw null; }
        public override string ToString() { throw null; }
    }
    public enum SecurityTokenInclusionMode
    {
        AlwaysToInitiator = 3,
        AlwaysToRecipient = 0,
        Never = 1,
        Once = 2,
    }
    public abstract partial class SecurityTokenParameters
    {
        protected SecurityTokenParameters() { }
        protected SecurityTokenParameters(System.ServiceModel.Security.Tokens.SecurityTokenParameters other) { }
        protected abstract bool HasAsymmetricKey { get; }
        public System.ServiceModel.Security.Tokens.SecurityTokenInclusionMode InclusionMode { get { throw null; } set { } }
        public System.ServiceModel.Security.Tokens.SecurityTokenReferenceStyle ReferenceStyle { get { throw null; } set { } }
        public bool RequireDerivedKeys { get { throw null; } set { } }
        protected abstract bool SupportsClientAuthentication { get; }
        protected abstract bool SupportsClientWindowsIdentity { get; }
        protected abstract bool SupportsServerAuthentication { get; }
        public System.ServiceModel.Security.Tokens.SecurityTokenParameters Clone() { throw null; }
        protected abstract System.ServiceModel.Security.Tokens.SecurityTokenParameters CloneCore();
        public override string ToString() { throw null; }
    }
    public enum SecurityTokenReferenceStyle
    {
        External = 1,
        Internal = 0,
    }
    public partial class SupportingTokenParameters
    {
        public SupportingTokenParameters() { }
        public System.Collections.ObjectModel.Collection<System.ServiceModel.Security.Tokens.SecurityTokenParameters> Endorsing { get { throw null; } }
        public System.Collections.ObjectModel.Collection<System.ServiceModel.Security.Tokens.SecurityTokenParameters> Signed { get { throw null; } }
        public System.Collections.ObjectModel.Collection<System.ServiceModel.Security.Tokens.SecurityTokenParameters> SignedEncrypted { get { throw null; } }
        public System.Collections.ObjectModel.Collection<System.ServiceModel.Security.Tokens.SecurityTokenParameters> SignedEndorsing { get { throw null; } }
        public System.ServiceModel.Security.Tokens.SupportingTokenParameters Clone() { throw null; }
        public void SetKeyDerivation(bool requireDerivedKeys) { }
        public override string ToString() { throw null; }
    }
    public partial class UserNameSecurityTokenParameters : System.ServiceModel.Security.Tokens.SecurityTokenParameters
    {
        public UserNameSecurityTokenParameters() { }
        protected UserNameSecurityTokenParameters(System.ServiceModel.Security.Tokens.UserNameSecurityTokenParameters other) { }
        protected override bool HasAsymmetricKey { get { throw null; } }
        protected override bool SupportsClientAuthentication { get { throw null; } }
        protected override bool SupportsClientWindowsIdentity { get { throw null; } }
        protected override bool SupportsServerAuthentication { get { throw null; } }
        protected override System.ServiceModel.Security.Tokens.SecurityTokenParameters CloneCore() { throw null; }
    }
    public enum X509KeyIdentifierClauseType
    {
        Any = 0,
        IssuerSerial = 2,
        RawDataKeyIdentifier = 4,
        SubjectKeyIdentifier = 3,
        Thumbprint = 1,
    }
}
