// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

[assembly:System.Reflection.AssemblyVersionAttribute("4.0.0.0")]
[assembly:System.CLSCompliantAttribute(true)]
[assembly:System.Diagnostics.DebuggableAttribute((System.Diagnostics.DebuggableAttribute.DebuggingModes)(2))]
[assembly:System.Reflection.AssemblyCompanyAttribute("Mono development team")]
[assembly:System.Reflection.AssemblyCopyrightAttribute("(c) Various Mono authors")]
[assembly:System.Reflection.AssemblyDefaultAliasAttribute("System.Runtime.Caching.dll")]
[assembly:System.Reflection.AssemblyDescriptionAttribute("System.Runtime.Caching.dll")]
[assembly:System.Reflection.AssemblyFileVersionAttribute("4.7.2046.0")]
[assembly:System.Reflection.AssemblyInformationalVersionAttribute("4.7.2046.0")]
[assembly:System.Reflection.AssemblyProductAttribute("Mono Common Language Infrastructure")]
[assembly:System.Reflection.AssemblyTitleAttribute("System.Runtime.Caching.dll")]
[assembly:System.Resources.NeutralResourcesLanguageAttribute("en-US")]
[assembly:System.Resources.SatelliteContractVersionAttribute("4.0.0.0")]
[assembly:System.Runtime.CompilerServices.CompilationRelaxationsAttribute(8)]
[assembly:System.Runtime.CompilerServices.ReferenceAssemblyAttribute]
[assembly:System.Runtime.CompilerServices.RuntimeCompatibilityAttribute(WrapNonExceptionThrows=true)]
[assembly:System.Runtime.InteropServices.ComVisibleAttribute(false)]
[assembly:System.Runtime.InteropServices.DefaultDllImportSearchPathsAttribute((System.Runtime.InteropServices.DllImportSearchPath)(2050))]
[assembly:System.Security.AllowPartiallyTrustedCallersAttribute]
[assembly:System.Security.SecurityRulesAttribute((System.Security.SecurityRuleSet)(2), SkipVerificationInFullTrust=true)]
[assembly:System.Security.Permissions.SecurityPermissionAttribute(System.Security.Permissions.SecurityAction.RequestMinimum, Execution=true)]
namespace System.Runtime.Caching
{
    public abstract partial class CacheEntryChangeMonitor : System.Runtime.Caching.ChangeMonitor
    {
        protected CacheEntryChangeMonitor() { }
        public abstract System.Collections.ObjectModel.ReadOnlyCollection<string> CacheKeys { get; }
        public abstract System.DateTimeOffset LastModified { get; }
        public abstract string RegionName { get; }
    }
    public partial class CacheEntryRemovedArguments
    {
        public CacheEntryRemovedArguments(System.Runtime.Caching.ObjectCache source, System.Runtime.Caching.CacheEntryRemovedReason reason, System.Runtime.Caching.CacheItem cacheItem) { }
        public System.Runtime.Caching.CacheItem CacheItem { get { throw null; } }
        public System.Runtime.Caching.CacheEntryRemovedReason RemovedReason { get { throw null; } }
        public System.Runtime.Caching.ObjectCache Source { get { throw null; } }
    }
    public delegate void CacheEntryRemovedCallback(System.Runtime.Caching.CacheEntryRemovedArguments arguments);
    public enum CacheEntryRemovedReason
    {
        CacheSpecificEviction = 4,
        ChangeMonitorChanged = 3,
        Evicted = 2,
        Expired = 1,
        Removed = 0,
    }
    public partial class CacheEntryUpdateArguments
    {
        public CacheEntryUpdateArguments(System.Runtime.Caching.ObjectCache source, System.Runtime.Caching.CacheEntryRemovedReason reason, string key, string regionName) { }
        public string Key { get { throw null; } }
        public string RegionName { get { throw null; } }
        public System.Runtime.Caching.CacheEntryRemovedReason RemovedReason { get { throw null; } }
        public System.Runtime.Caching.ObjectCache Source { get { throw null; } }
        public System.Runtime.Caching.CacheItem UpdatedCacheItem { get { throw null; } set { } }
        public System.Runtime.Caching.CacheItemPolicy UpdatedCacheItemPolicy { get { throw null; } set { } }
    }
    public delegate void CacheEntryUpdateCallback(System.Runtime.Caching.CacheEntryUpdateArguments arguments);
    public partial class CacheItem
    {
        public CacheItem(string key) { }
        public CacheItem(string key, object value) { }
        public CacheItem(string key, object value, string regionName) { }
        public string Key { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public string RegionName { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public object Value { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    }
    public partial class CacheItemPolicy
    {
        public CacheItemPolicy() { }
        public System.DateTimeOffset AbsoluteExpiration { get { throw null; } set { } }
        public System.Collections.ObjectModel.Collection<System.Runtime.Caching.ChangeMonitor> ChangeMonitors { get { throw null; } }
        public System.Runtime.Caching.CacheItemPriority Priority { get { throw null; } set { } }
        public System.Runtime.Caching.CacheEntryRemovedCallback RemovedCallback { get { throw null; } set { } }
        public System.TimeSpan SlidingExpiration { get { throw null; } set { } }
        public System.Runtime.Caching.CacheEntryUpdateCallback UpdateCallback { get { throw null; } set { } }
    }
    public enum CacheItemPriority
    {
        Default = 0,
        NotRemovable = 1,
    }
    public abstract partial class ChangeMonitor : System.IDisposable
    {
        protected ChangeMonitor() { }
        public bool HasChanged { get { throw null; } }
        public bool IsDisposed { get { throw null; } }
        public abstract string UniqueId { get; }
        public void Dispose() { }
        protected abstract void Dispose(bool disposing);
        protected void InitializationComplete() { }
        public void NotifyOnChanged(System.Runtime.Caching.OnChangedCallback onChangedCallback) { }
        protected void OnChanged(object state) { }
    }
    [System.FlagsAttribute]
    public enum DefaultCacheCapabilities
    {
        AbsoluteExpirations = 8,
        CacheEntryChangeMonitors = 4,
        CacheEntryRemovedCallback = 64,
        CacheEntryUpdateCallback = 32,
        CacheRegions = 128,
        InMemoryProvider = 1,
        None = 0,
        OutOfProcessProvider = 2,
        SlidingExpirations = 16,
    }
    public abstract partial class FileChangeMonitor : System.Runtime.Caching.ChangeMonitor
    {
        protected FileChangeMonitor() { }
        public abstract System.Collections.ObjectModel.ReadOnlyCollection<string> FilePaths { get; }
        public abstract System.DateTimeOffset LastModified { get; }
    }
    public sealed partial class HostFileChangeMonitor : System.Runtime.Caching.FileChangeMonitor
    {
        public HostFileChangeMonitor(System.Collections.Generic.IList<string> filePaths) { }
        public override System.Collections.ObjectModel.ReadOnlyCollection<string> FilePaths { get { throw null; } }
        public override System.DateTimeOffset LastModified { get { throw null; } }
        public override string UniqueId { get { throw null; } }
        protected override void Dispose(bool disposing) { }
    }
    public partial class MemoryCache : System.Runtime.Caching.ObjectCache, System.Collections.IEnumerable, System.IDisposable
    {
        public MemoryCache(string name, System.Collections.Specialized.NameValueCollection config=null) { }
        public MemoryCache(string name, System.Collections.Specialized.NameValueCollection config, bool ignoreConfigSection) { }
        public long CacheMemoryLimit { get { throw null; } }
        public static System.Runtime.Caching.MemoryCache Default { get { throw null; } }
        public override System.Runtime.Caching.DefaultCacheCapabilities DefaultCacheCapabilities { get { throw null; } }
        public override object this[string key] { get { throw null; } set { } }
        public override string Name { get { throw null; } }
        public long PhysicalMemoryLimit { get { throw null; } }
        public System.TimeSpan PollingInterval { get { throw null; } }
        public override bool Add(System.Runtime.Caching.CacheItem item, System.Runtime.Caching.CacheItemPolicy policy) { throw null; }
        public override System.Runtime.Caching.CacheItem AddOrGetExisting(System.Runtime.Caching.CacheItem item, System.Runtime.Caching.CacheItemPolicy policy) { throw null; }
        public override object AddOrGetExisting(string key, object value, System.DateTimeOffset absoluteExpiration, string regionName=null) { throw null; }
        public override object AddOrGetExisting(string key, object value, System.Runtime.Caching.CacheItemPolicy policy, string regionName=null) { throw null; }
        public override bool Contains(string key, string regionName=null) { throw null; }
        public override System.Runtime.Caching.CacheEntryChangeMonitor CreateCacheEntryChangeMonitor(System.Collections.Generic.IEnumerable<string> keys, string regionName=null) { throw null; }
        public void Dispose() { }
        public override object Get(string key, string regionName=null) { throw null; }
        public override System.Runtime.Caching.CacheItem GetCacheItem(string key, string regionName=null) { throw null; }
        public override long GetCount(string regionName=null) { throw null; }
        protected override System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<string, object>> GetEnumerator() { throw null; }
        public long GetLastSize(string regionName=null) { throw null; }
        public override System.Collections.Generic.IDictionary<string, object> GetValues(System.Collections.Generic.IEnumerable<string> keys, string regionName=null) { throw null; }
        public object Remove(string key, System.Runtime.Caching.CacheEntryRemovedReason reason, string regionName=null) { throw null; }
        public override object Remove(string key, string regionName=null) { throw null; }
        public override void Set(System.Runtime.Caching.CacheItem item, System.Runtime.Caching.CacheItemPolicy policy) { }
        public override void Set(string key, object value, System.DateTimeOffset absoluteExpiration, string regionName=null) { }
        public override void Set(string key, object value, System.Runtime.Caching.CacheItemPolicy policy, string regionName=null) { }
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { throw null; }
        public long Trim(int percent) { throw null; }
    }
    public abstract partial class ObjectCache : System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<string, object>>, System.Collections.IEnumerable
    {
        public static readonly System.DateTimeOffset InfiniteAbsoluteExpiration;
        public static readonly System.TimeSpan NoSlidingExpiration;
        protected ObjectCache() { }
        public abstract System.Runtime.Caching.DefaultCacheCapabilities DefaultCacheCapabilities { get; }
        public static System.IServiceProvider Host { [System.Security.SecurityCriticalAttribute][System.Security.Permissions.PermissionSetAttribute(System.Security.Permissions.SecurityAction.Demand, Unrestricted=true)]get { throw null; } [System.Security.SecurityCriticalAttribute][System.Security.Permissions.PermissionSetAttribute(System.Security.Permissions.SecurityAction.Demand, Unrestricted=true)]set { } }
        public abstract object this[string key] { get; set; }
        public abstract string Name { get; }
        public virtual bool Add(System.Runtime.Caching.CacheItem item, System.Runtime.Caching.CacheItemPolicy policy) { throw null; }
        public virtual bool Add(string key, object value, System.DateTimeOffset absoluteExpiration, string regionName=null) { throw null; }
        public virtual bool Add(string key, object value, System.Runtime.Caching.CacheItemPolicy policy, string regionName=null) { throw null; }
        public abstract System.Runtime.Caching.CacheItem AddOrGetExisting(System.Runtime.Caching.CacheItem value, System.Runtime.Caching.CacheItemPolicy policy);
        public abstract object AddOrGetExisting(string key, object value, System.DateTimeOffset absoluteExpiration, string regionName=null);
        public abstract object AddOrGetExisting(string key, object value, System.Runtime.Caching.CacheItemPolicy policy, string regionName=null);
        public abstract bool Contains(string key, string regionName=null);
        public abstract System.Runtime.Caching.CacheEntryChangeMonitor CreateCacheEntryChangeMonitor(System.Collections.Generic.IEnumerable<string> keys, string regionName=null);
        public abstract object Get(string key, string regionName=null);
        public abstract System.Runtime.Caching.CacheItem GetCacheItem(string key, string regionName=null);
        public abstract long GetCount(string regionName=null);
        protected abstract System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<string, object>> GetEnumerator();
        public abstract System.Collections.Generic.IDictionary<string, object> GetValues(System.Collections.Generic.IEnumerable<string> keys, string regionName=null);
        public virtual System.Collections.Generic.IDictionary<string, object> GetValues(string regionName, params string[] keys) { throw null; }
        public abstract object Remove(string key, string regionName=null);
        public abstract void Set(System.Runtime.Caching.CacheItem item, System.Runtime.Caching.CacheItemPolicy policy);
        public abstract void Set(string key, object value, System.DateTimeOffset absoluteExpiration, string regionName=null);
        public abstract void Set(string key, object value, System.Runtime.Caching.CacheItemPolicy policy, string regionName=null);
        System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<string, object>> System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.String,System.Object>>.GetEnumerator() { throw null; }
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { throw null; }
    }
    public delegate void OnChangedCallback(object state);
    public sealed partial class SqlChangeMonitor : System.Runtime.Caching.ChangeMonitor
    {
        public SqlChangeMonitor(System.Data.SqlClient.SqlDependency dependency) { }
        public override string UniqueId { get { throw null; } }
        protected override void Dispose(bool disposing) { }
    }
}
namespace System.Runtime.Caching.Configuration
{
    public sealed partial class CachingSectionGroup : System.Configuration.ConfigurationSectionGroup
    {
        public CachingSectionGroup() { }
        [System.Configuration.ConfigurationPropertyAttribute("memoryCache")]
        public System.Runtime.Caching.Configuration.MemoryCacheSection MemoryCaches { get { throw null; } }
    }
    public sealed partial class MemoryCacheElement : System.Configuration.ConfigurationElement
    {
        public MemoryCacheElement(string name) { }
        [System.Configuration.ConfigurationPropertyAttribute("cacheMemoryLimitMegabytes", DefaultValue=0)]
        [System.Configuration.IntegerValidatorAttribute(MinValue=0)]
        public int CacheMemoryLimitMegabytes { get { throw null; } set { } }
        [System.ComponentModel.TypeConverterAttribute(typeof(System.Configuration.WhiteSpaceTrimStringConverter))]
        [System.Configuration.ConfigurationPropertyAttribute("name", DefaultValue="", IsRequired=true, IsKey=true)]
        [System.Configuration.StringValidatorAttribute(MinLength=1)]
        public string Name { get { throw null; } set { } }
        [System.Configuration.ConfigurationPropertyAttribute("physicalMemoryLimitPercentage", DefaultValue=0)]
        [System.Configuration.IntegerValidatorAttribute(MinValue=0, MaxValue=100)]
        public int PhysicalMemoryLimitPercentage { get { throw null; } set { } }
        [System.ComponentModel.TypeConverterAttribute(typeof(System.Configuration.InfiniteTimeSpanConverter))]
        [System.Configuration.ConfigurationPropertyAttribute("pollingInterval", DefaultValue="00:02:00")]
        public System.TimeSpan PollingInterval { get { throw null; } set { } }
        protected override System.Configuration.ConfigurationPropertyCollection Properties { get { throw null; } }
    }
    public sealed partial class MemoryCacheSection : System.Configuration.ConfigurationSection
    {
        public MemoryCacheSection() { }
        [System.Configuration.ConfigurationPropertyAttribute("namedCaches")]
        public System.Runtime.Caching.Configuration.MemoryCacheSettingsCollection NamedCaches { get { throw null; } }
        protected override System.Configuration.ConfigurationPropertyCollection Properties { get { throw null; } }
    }
    [System.Configuration.ConfigurationCollectionAttribute(typeof(System.Runtime.Caching.Configuration.MemoryCacheElement), CollectionType=(System.Configuration.ConfigurationElementCollectionType)(1))]
    public sealed partial class MemoryCacheSettingsCollection : System.Configuration.ConfigurationElementCollection
    {
        public MemoryCacheSettingsCollection() { }
        public override System.Configuration.ConfigurationElementCollectionType CollectionType { get { throw null; } }
        public System.Runtime.Caching.Configuration.MemoryCacheElement this[int index] { get { throw null; } set { } }
        public new System.Runtime.Caching.Configuration.MemoryCacheElement this[string key] { get { throw null; } }
        protected override System.Configuration.ConfigurationPropertyCollection Properties { get { throw null; } }
        public void Add(System.Runtime.Caching.Configuration.MemoryCacheElement cache) { }
        public void Clear() { }
        protected override System.Configuration.ConfigurationElement CreateNewElement() { throw null; }
        protected override System.Configuration.ConfigurationElement CreateNewElement(string elementName) { throw null; }
        protected override object GetElementKey(System.Configuration.ConfigurationElement element) { throw null; }
        public int IndexOf(System.Runtime.Caching.Configuration.MemoryCacheElement cache) { throw null; }
        public void Remove(System.Runtime.Caching.Configuration.MemoryCacheElement cache) { }
        public void RemoveAt(int index) { }
    }
}
namespace System.Runtime.Caching.Hosting
{
    public partial interface IApplicationIdentifier
    {
        string GetApplicationId();
    }
    public partial interface IFileChangeNotificationSystem
    {
        void StartMonitoring(string filePath, System.Runtime.Caching.OnChangedCallback onChangedCallback, out object state, out System.DateTimeOffset lastWriteTime, out long fileSize);
        void StopMonitoring(string filePath, object state);
    }
    public partial interface IMemoryCacheManager
    {
        void ReleaseCache(System.Runtime.Caching.MemoryCache cache);
        void UpdateCacheSize(long size, System.Runtime.Caching.MemoryCache cache);
    }
}
