// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

[assembly:System.Reflection.AssemblyVersionAttribute("4.0.0.0")]
[assembly:System.CLSCompliantAttribute(true)]
[assembly:System.Diagnostics.DebuggableAttribute((System.Diagnostics.DebuggableAttribute.DebuggingModes)(258))]
[assembly:System.Reflection.AssemblyCompanyAttribute("MONO development team")]
[assembly:System.Reflection.AssemblyConfigurationAttribute("Development version")]
[assembly:System.Reflection.AssemblyCopyrightAttribute("(c) 2003 Various Authors")]
[assembly:System.Reflection.AssemblyDefaultAliasAttribute("System.ServiceModel.Routing.dll")]
[assembly:System.Reflection.AssemblyDescriptionAttribute("System.ServiceModel.Routing.dll")]
[assembly:System.Reflection.AssemblyInformationalVersionAttribute("3.5.594.0")]
[assembly:System.Reflection.AssemblyProductAttribute("MONO CLI")]
[assembly:System.Reflection.AssemblyTitleAttribute("System.ServiceModel.Routing.dll")]
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
namespace System.ServiceModel.Dispatcher
{
    public partial class EndpointNameMessageFilter : System.ServiceModel.Dispatcher.MessageFilter
    {
        public EndpointNameMessageFilter(string endpointName) { }
        [System.MonoTODOAttribute]
        public override bool Match(System.ServiceModel.Channels.Message message) { throw null; }
        [System.MonoTODOAttribute]
        public override bool Match(System.ServiceModel.Channels.MessageBuffer buffer) { throw null; }
    }
    public partial class StrictAndMessageFilter : System.ServiceModel.Dispatcher.MessageFilter
    {
        public StrictAndMessageFilter(System.ServiceModel.Dispatcher.MessageFilter filter1, System.ServiceModel.Dispatcher.MessageFilter filter2) { }
        protected internal override System.ServiceModel.Dispatcher.IMessageFilterTable<TFilterData> CreateFilterTable<TFilterData>() { throw null; }
        public override bool Match(System.ServiceModel.Channels.Message message) { throw null; }
        public override bool Match(System.ServiceModel.Channels.MessageBuffer buffer) { throw null; }
    }
}
namespace System.ServiceModel.Routing
{
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://schemas.microsoft.com/netfx/2009/05/routing", SessionMode=(System.ServiceModel.SessionMode)(1))]
    public partial interface IDuplexSessionRouter
    {
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, IsOneWay=true, Action="*")]
        System.IAsyncResult BeginProcessMessage(System.ServiceModel.Channels.Message message, System.AsyncCallback callback, object state);
        void EndProcessMessage(System.IAsyncResult result);
    }
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://schemas.microsoft.com/netfx/2009/05/routing", SessionMode=(System.ServiceModel.SessionMode)(0))]
    public partial interface IRequestReplyRouter
    {
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, IsOneWay=false, Action="*", ReplyAction="*")]
        System.IAsyncResult BeginProcessRequest(System.ServiceModel.Channels.Message message, System.AsyncCallback callback, object state);
        System.ServiceModel.Channels.Message EndProcessRequest(System.IAsyncResult result);
    }
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://schemas.microsoft.com/netfx/2009/05/routing", SessionMode=(System.ServiceModel.SessionMode)(0))]
    public partial interface ISimplexDatagramRouter
    {
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, IsOneWay=true, Action="*")]
        System.IAsyncResult BeginProcessMessage(System.ServiceModel.Channels.Message message, System.AsyncCallback callback, object state);
        void EndProcessMessage(System.IAsyncResult result);
    }
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://schemas.microsoft.com/netfx/2009/05/routing", SessionMode=(System.ServiceModel.SessionMode)(1))]
    public partial interface ISimplexSessionRouter
    {
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, IsOneWay=true, Action="*")]
        System.IAsyncResult BeginProcessMessage(System.ServiceModel.Channels.Message message, System.AsyncCallback callback, object state);
        void EndProcessMessage(System.IAsyncResult result);
    }
    public sealed partial class RoutingBehavior : System.ServiceModel.Description.IServiceBehavior
    {
        public RoutingBehavior(System.ServiceModel.Routing.RoutingConfiguration routingConfiguration) { }
        [System.MonoTODOAttribute]
        public static System.Type GetContractForDescription(System.ServiceModel.Description.ContractDescription description) { throw null; }
        void System.ServiceModel.Description.IServiceBehavior.AddBindingParameters(System.ServiceModel.Description.ServiceDescription serviceDescription, System.ServiceModel.ServiceHostBase serviceHostBase, System.Collections.ObjectModel.Collection<System.ServiceModel.Description.ServiceEndpoint> endpoints, System.ServiceModel.Channels.BindingParameterCollection bindingParameters) { }
        void System.ServiceModel.Description.IServiceBehavior.ApplyDispatchBehavior(System.ServiceModel.Description.ServiceDescription serviceDescription, System.ServiceModel.ServiceHostBase serviceHostBase) { }
        void System.ServiceModel.Description.IServiceBehavior.Validate(System.ServiceModel.Description.ServiceDescription serviceDescription, System.ServiceModel.ServiceHostBase serviceHostBase) { }
    }
    public sealed partial class RoutingConfiguration
    {
        public RoutingConfiguration() { }
        public RoutingConfiguration(System.ServiceModel.Dispatcher.MessageFilterTable<System.Collections.Generic.IEnumerable<System.ServiceModel.Description.ServiceEndpoint>> filterTable, bool routeOnHeadersOnly) { }
        public bool EnsureOrderedDispatch { get { throw null; } set { } }
        public System.ServiceModel.Dispatcher.MessageFilterTable<System.Collections.Generic.IEnumerable<System.ServiceModel.Description.ServiceEndpoint>> FilterTable { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        public bool RouteOnHeadersOnly { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public bool SoapProcessingEnabled { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    }
    public sealed partial class RoutingExtension : System.ServiceModel.IExtension<System.ServiceModel.ServiceHostBase>
    {
        internal RoutingExtension() { }
        public void ApplyConfiguration(System.ServiceModel.Routing.RoutingConfiguration routingConfiguration) { }
        void System.ServiceModel.IExtension<System.ServiceModel.ServiceHostBase>.Attach(System.ServiceModel.ServiceHostBase owner) { }
        void System.ServiceModel.IExtension<System.ServiceModel.ServiceHostBase>.Detach(System.ServiceModel.ServiceHostBase owner) { }
    }
    [System.ServiceModel.ServiceBehaviorAttribute(AddressFilterMode=(System.ServiceModel.AddressFilterMode)(2), InstanceContextMode=(System.ServiceModel.InstanceContextMode)(0), UseSynchronizationContext=false, ValidateMustUnderstand=false)]
    public sealed partial class RoutingService : System.IDisposable, System.ServiceModel.Routing.IDuplexSessionRouter, System.ServiceModel.Routing.IRequestReplyRouter, System.ServiceModel.Routing.ISimplexDatagramRouter, System.ServiceModel.Routing.ISimplexSessionRouter
    {
        internal RoutingService() { }
        void System.IDisposable.Dispose() { }
        System.IAsyncResult System.ServiceModel.Routing.IDuplexSessionRouter.BeginProcessMessage(System.ServiceModel.Channels.Message message, System.AsyncCallback callback, object state) { throw null; }
        void System.ServiceModel.Routing.IDuplexSessionRouter.EndProcessMessage(System.IAsyncResult result) { }
        System.IAsyncResult System.ServiceModel.Routing.IRequestReplyRouter.BeginProcessRequest(System.ServiceModel.Channels.Message message, System.AsyncCallback callback, object state) { throw null; }
        System.ServiceModel.Channels.Message System.ServiceModel.Routing.IRequestReplyRouter.EndProcessRequest(System.IAsyncResult result) { throw null; }
        System.IAsyncResult System.ServiceModel.Routing.ISimplexDatagramRouter.BeginProcessMessage(System.ServiceModel.Channels.Message message, System.AsyncCallback callback, object state) { throw null; }
        void System.ServiceModel.Routing.ISimplexDatagramRouter.EndProcessMessage(System.IAsyncResult result) { }
        System.IAsyncResult System.ServiceModel.Routing.ISimplexSessionRouter.BeginProcessMessage(System.ServiceModel.Channels.Message message, System.AsyncCallback callback, object state) { throw null; }
        void System.ServiceModel.Routing.ISimplexSessionRouter.EndProcessMessage(System.IAsyncResult result) { }
    }
    public partial class SoapProcessingBehavior : System.ServiceModel.Description.IEndpointBehavior
    {
        public SoapProcessingBehavior() { }
        public bool ProcessMessages { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public void AddBindingParameters(System.ServiceModel.Description.ServiceEndpoint endpoint, System.ServiceModel.Channels.BindingParameterCollection bindingParameters) { }
        public void ApplyClientBehavior(System.ServiceModel.Description.ServiceEndpoint endpoint, System.ServiceModel.Dispatcher.ClientRuntime clientRuntime) { }
        public void ApplyDispatchBehavior(System.ServiceModel.Description.ServiceEndpoint endpoint, System.ServiceModel.Dispatcher.EndpointDispatcher endpointDispatcher) { }
        public void Validate(System.ServiceModel.Description.ServiceEndpoint endpoint) { }
    }
}
namespace System.ServiceModel.Routing.Configuration
{
    [System.Configuration.ConfigurationCollectionAttribute(typeof(System.ServiceModel.Routing.Configuration.BackupEndpointElement))]
    public partial class BackupEndpointCollection : System.Configuration.ConfigurationElementCollection
    {
        public BackupEndpointCollection() { }
        [System.Configuration.ConfigurationPropertyAttribute("name", DefaultValue=null, Options=(System.Configuration.ConfigurationPropertyOptions)(2))]
        public string Name { get { throw null; } set { } }
        public void Add(System.ServiceModel.Routing.Configuration.BackupEndpointElement element) { }
        public void Clear() { }
        protected override System.Configuration.ConfigurationElement CreateNewElement() { throw null; }
        protected override object GetElementKey(System.Configuration.ConfigurationElement element) { throw null; }
        public void Remove(System.ServiceModel.Routing.Configuration.BackupEndpointElement element) { }
    }
    public partial class BackupEndpointElement : System.Configuration.ConfigurationElement
    {
        public BackupEndpointElement() { }
        [System.Configuration.ConfigurationPropertyAttribute("endpointName", DefaultValue=null, Options=(System.Configuration.ConfigurationPropertyOptions)(2))]
        public string EndpointName { get { throw null; } set { } }
    }
    [System.Configuration.ConfigurationCollectionAttribute(typeof(System.ServiceModel.Routing.Configuration.BackupEndpointCollection), AddItemName="backupList")]
    public partial class BackupListCollection : System.Configuration.ConfigurationElementCollection
    {
        public BackupListCollection() { }
        public new System.ServiceModel.Routing.Configuration.BackupEndpointCollection this[string name] { get { throw null; } }
        public void Add(System.ServiceModel.Routing.Configuration.BackupEndpointCollection element) { }
        public void Clear() { }
        protected override System.Configuration.ConfigurationElement CreateNewElement() { throw null; }
        protected override object GetElementKey(System.Configuration.ConfigurationElement element) { throw null; }
        public void Remove(System.ServiceModel.Routing.Configuration.BackupEndpointCollection element) { }
    }
    public partial class FilterElement : System.Configuration.ConfigurationElement
    {
        public FilterElement() { }
        [System.Configuration.ConfigurationPropertyAttribute("customType", DefaultValue=null, Options=(System.Configuration.ConfigurationPropertyOptions)(0))]
        public string CustomType { get { throw null; } set { } }
        [System.Configuration.ConfigurationPropertyAttribute("filter1", DefaultValue=null, Options=(System.Configuration.ConfigurationPropertyOptions)(0))]
        public string Filter1 { get { throw null; } set { } }
        [System.Configuration.ConfigurationPropertyAttribute("filter2", DefaultValue=null, Options=(System.Configuration.ConfigurationPropertyOptions)(0))]
        public string Filter2 { get { throw null; } set { } }
        [System.Configuration.ConfigurationPropertyAttribute("filterData", DefaultValue=null, Options=(System.Configuration.ConfigurationPropertyOptions)(0))]
        public string FilterData { get { throw null; } set { } }
        [System.Configuration.ConfigurationPropertyAttribute("filterType", DefaultValue=null, Options=(System.Configuration.ConfigurationPropertyOptions)(2))]
        public System.ServiceModel.Routing.Configuration.FilterType FilterType { get { throw null; } set { } }
        [System.Configuration.ConfigurationPropertyAttribute("name", DefaultValue=null, Options=(System.Configuration.ConfigurationPropertyOptions)(6))]
        public string Name { get { throw null; } set { } }
    }
    [System.Configuration.ConfigurationCollectionAttribute(typeof(System.ServiceModel.Routing.Configuration.FilterElement), AddItemName="filter")]
    public partial class FilterElementCollection : System.Configuration.ConfigurationElementCollection
    {
        public FilterElementCollection() { }
        public System.ServiceModel.Routing.Configuration.FilterElement this[int index] { get { throw null; } set { } }
        public new System.ServiceModel.Routing.Configuration.FilterElement this[string name] { get { throw null; } }
        public void Add(System.ServiceModel.Routing.Configuration.FilterElement element) { }
        public void Clear() { }
        protected override System.Configuration.ConfigurationElement CreateNewElement() { throw null; }
        protected override object GetElementKey(System.Configuration.ConfigurationElement element) { throw null; }
        protected override bool IsElementRemovable(System.Configuration.ConfigurationElement element) { throw null; }
        public override bool IsReadOnly() { throw null; }
        public void Remove(System.ServiceModel.Routing.Configuration.FilterElement element) { }
    }
    [System.Configuration.ConfigurationCollectionAttribute(typeof(System.ServiceModel.Routing.Configuration.FilterTableEntryCollection), AddItemName="filterTable")]
    public partial class FilterTableCollection : System.Configuration.ConfigurationElementCollection
    {
        public FilterTableCollection() { }
        public new System.ServiceModel.Routing.Configuration.FilterTableEntryCollection this[string name] { get { throw null; } }
        public void Add(System.ServiceModel.Routing.Configuration.FilterTableEntryCollection element) { }
        public void Clear() { }
        protected override System.Configuration.ConfigurationElement CreateNewElement() { throw null; }
        protected override object GetElementKey(System.Configuration.ConfigurationElement element) { throw null; }
        public void Remove(System.ServiceModel.Routing.Configuration.FilterTableEntryCollection element) { }
    }
    [System.Configuration.ConfigurationCollectionAttribute(typeof(System.ServiceModel.Routing.Configuration.FilterTableEntryElement))]
    public partial class FilterTableEntryCollection : System.Configuration.ConfigurationElementCollection
    {
        public FilterTableEntryCollection() { }
        [System.Configuration.ConfigurationPropertyAttribute("name", DefaultValue=null, Options=(System.Configuration.ConfigurationPropertyOptions)(6))]
        public string Name { get { throw null; } set { } }
        public void Add(System.ServiceModel.Routing.Configuration.FilterTableEntryElement element) { }
        public void Clear() { }
        protected override System.Configuration.ConfigurationElement CreateNewElement() { throw null; }
        protected override object GetElementKey(System.Configuration.ConfigurationElement element) { throw null; }
        public void Remove(System.ServiceModel.Routing.Configuration.FilterTableEntryElement element) { }
    }
    public partial class FilterTableEntryElement : System.Configuration.ConfigurationElement
    {
        public FilterTableEntryElement() { }
        [System.Configuration.ConfigurationPropertyAttribute("backupList", DefaultValue=null, Options=(System.Configuration.ConfigurationPropertyOptions)(0))]
        public string BackupList { get { throw null; } set { } }
        [System.Configuration.ConfigurationPropertyAttribute("endpointName", DefaultValue=null, Options=(System.Configuration.ConfigurationPropertyOptions)(6))]
        public string EndpointName { get { throw null; } set { } }
        [System.Configuration.ConfigurationPropertyAttribute("filterName", DefaultValue=null, Options=(System.Configuration.ConfigurationPropertyOptions)(6))]
        public string FilterName { get { throw null; } set { } }
        [System.Configuration.ConfigurationPropertyAttribute("priority", Options=(System.Configuration.ConfigurationPropertyOptions)(0))]
        public int Priority { get { throw null; } set { } }
    }
    public enum FilterType
    {
        Action = 0,
        And = 3,
        Custom = 4,
        EndpointAddress = 1,
        EndpointName = 5,
        MatchAll = 6,
        PrefixEndpointAddress = 2,
        XPath = 7,
    }
    public partial class NamespaceElement : System.Configuration.ConfigurationElement
    {
        public NamespaceElement() { }
        [System.Configuration.ConfigurationPropertyAttribute("namespace", DefaultValue=null, Options=(System.Configuration.ConfigurationPropertyOptions)(2))]
        public string Namespace { get { throw null; } set { } }
        [System.Configuration.ConfigurationPropertyAttribute("prefix", DefaultValue=null, Options=(System.Configuration.ConfigurationPropertyOptions)(6))]
        public string Prefix { get { throw null; } set { } }
    }
    [System.Configuration.ConfigurationCollectionAttribute(typeof(System.ServiceModel.Routing.Configuration.NamespaceElement))]
    public partial class NamespaceElementCollection : System.Configuration.ConfigurationElementCollection
    {
        public NamespaceElementCollection() { }
        public System.ServiceModel.Routing.Configuration.NamespaceElement this[int index] { get { throw null; } set { } }
        public new System.ServiceModel.Routing.Configuration.NamespaceElement this[string name] { get { throw null; } }
        public void Add(System.ServiceModel.Routing.Configuration.NamespaceElement element) { }
        public void Clear() { }
        protected override System.Configuration.ConfigurationElement CreateNewElement() { throw null; }
        protected override object GetElementKey(System.Configuration.ConfigurationElement element) { throw null; }
        public void Remove(System.ServiceModel.Routing.Configuration.NamespaceElement element) { }
    }
    public sealed partial class RoutingExtensionElement : System.ServiceModel.Configuration.BehaviorExtensionElement
    {
        public RoutingExtensionElement() { }
        public override System.Type BehaviorType { get { throw null; } }
        public bool EnsureOrderedDispatch { get { throw null; } set { } }
        [System.Configuration.ConfigurationPropertyAttribute("filterTableName", DefaultValue=null)]
        public string FilterTableName { get { throw null; } set { } }
        [System.Configuration.ConfigurationPropertyAttribute("routeOnHeadersOnly", DefaultValue=true, Options=(System.Configuration.ConfigurationPropertyOptions)(0))]
        public bool RouteOnHeadersOnly { get { throw null; } set { } }
        [System.Configuration.ConfigurationPropertyAttribute("soapProcessingEnabled", DefaultValue=true)]
        public bool SoapProcessingEnabled { get { throw null; } set { } }
        protected internal override object CreateBehavior() { throw null; }
    }
    public partial class RoutingSection : System.Configuration.ConfigurationSection
    {
        public RoutingSection() { }
        [System.Configuration.ConfigurationPropertyAttribute("backupLists", Options=(System.Configuration.ConfigurationPropertyOptions)(0))]
        public System.ServiceModel.Routing.Configuration.BackupListCollection BackupLists { get { throw null; } }
        [System.Configuration.ConfigurationPropertyAttribute("filters", Options=(System.Configuration.ConfigurationPropertyOptions)(0))]
        public System.ServiceModel.Routing.Configuration.FilterElementCollection Filters { get { throw null; } }
        [System.Configuration.ConfigurationPropertyAttribute("filterTables", Options=(System.Configuration.ConfigurationPropertyOptions)(0))]
        public System.ServiceModel.Routing.Configuration.FilterTableCollection FilterTables { get { throw null; } }
        [System.Configuration.ConfigurationPropertyAttribute("namespaceTable", Options=(System.Configuration.ConfigurationPropertyOptions)(0))]
        public System.ServiceModel.Routing.Configuration.NamespaceElementCollection NamespaceTable { get { throw null; } }
        [System.MonoTODOAttribute]
        public static System.ServiceModel.Dispatcher.MessageFilterTable<System.Collections.Generic.IEnumerable<System.ServiceModel.Description.ServiceEndpoint>> CreateFilterTable(string name) { throw null; }
    }
    public partial class SoapProcessingExtensionElement : System.ServiceModel.Configuration.BehaviorExtensionElement
    {
        public SoapProcessingExtensionElement() { }
        public override System.Type BehaviorType { get { throw null; } }
        [System.Configuration.ConfigurationPropertyAttribute("processMessages", DefaultValue=true, Options=(System.Configuration.ConfigurationPropertyOptions)(0))]
        public bool ProcessMessages { get { throw null; } set { } }
        protected internal override object CreateBehavior() { throw null; }
    }
}
