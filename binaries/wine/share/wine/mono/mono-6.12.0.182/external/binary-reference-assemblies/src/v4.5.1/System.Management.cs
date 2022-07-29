// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

[assembly:System.Reflection.AssemblyVersionAttribute("4.0.0.0")]
[assembly:System.CLSCompliantAttribute(true)]
[assembly:System.Diagnostics.DebuggableAttribute((System.Diagnostics.DebuggableAttribute.DebuggingModes)(258))]
[assembly:System.Reflection.AssemblyCompanyAttribute("Mono development team")]
[assembly:System.Reflection.AssemblyCopyrightAttribute("(c) Various Mono authors")]
[assembly:System.Reflection.AssemblyDefaultAliasAttribute("System.Management.dll")]
[assembly:System.Reflection.AssemblyDescriptionAttribute("System.Management.dll")]
[assembly:System.Reflection.AssemblyFileVersionAttribute("4.0.30319.17020")]
[assembly:System.Reflection.AssemblyInformationalVersionAttribute("4.0.30319.17020")]
[assembly:System.Reflection.AssemblyProductAttribute("Mono Common Language Infrastructure")]
[assembly:System.Reflection.AssemblyTitleAttribute("System.Management.dll")]
[assembly:System.Resources.NeutralResourcesLanguageAttribute("en-US")]
[assembly:System.Resources.SatelliteContractVersionAttribute("4.0.0.0")]
[assembly:System.Runtime.CompilerServices.CompilationRelaxationsAttribute((System.Runtime.CompilerServices.CompilationRelaxations)(8))]
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
namespace System.Management
{
    public enum AuthenticationLevel
    {
        Call = 3,
        Connect = 2,
        Default = 0,
        None = 1,
        Packet = 4,
        PacketIntegrity = 5,
        PacketPrivacy = 6,
        Unchanged = -1,
    }
    public enum CimType
    {
        Boolean = 11,
        Char16 = 103,
        DateTime = 101,
        None = 0,
        Object = 13,
        Real32 = 4,
        Real64 = 5,
        Reference = 102,
        SInt16 = 2,
        SInt32 = 3,
        SInt64 = 20,
        SInt8 = 16,
        String = 8,
        UInt16 = 18,
        UInt32 = 19,
        UInt64 = 21,
        UInt8 = 17,
    }
    public enum CodeLanguage
    {
        CSharp = 0,
        JScript = 1,
        Mcpp = 4,
        VB = 2,
        VJSharp = 3,
    }
    [System.FlagsAttribute]
    public enum ComparisonSettings
    {
        IgnoreCase = 16,
        IgnoreClass = 8,
        IgnoreDefaultValues = 4,
        IgnoreFlavor = 32,
        IgnoreObjectSource = 2,
        IgnoreQualifiers = 1,
        IncludeAll = 0,
    }
    public partial class CompletedEventArgs : System.Management.ManagementEventArgs
    {
        internal CompletedEventArgs() { }
        public System.Management.ManagementStatus Status { [System.MonoTODOAttribute]get { throw null; } }
        public System.Management.ManagementBaseObject StatusObject { [System.MonoTODOAttribute]get { throw null; } }
    }
    public delegate void CompletedEventHandler(object sender, System.Management.CompletedEventArgs e);
    public partial class ConnectionOptions : System.Management.ManagementOptions
    {
        [System.MonoTODOAttribute]
        public ConnectionOptions() { }
        public ConnectionOptions(string locale, string username, System.Security.SecureString password, string authority, System.Management.ImpersonationLevel impersonation, System.Management.AuthenticationLevel authentication, bool enablePrivileges, System.Management.ManagementNamedValueCollection context, System.TimeSpan timeout) { }
        [System.MonoTODOAttribute]
        public ConnectionOptions(string locale, string username, string password, string authority, System.Management.ImpersonationLevel impersonation, System.Management.AuthenticationLevel authentication, bool enablePrivileges, System.Management.ManagementNamedValueCollection context, System.TimeSpan timeout) { }
        [System.MonoTODOAttribute]
        public System.Management.AuthenticationLevel Authentication { get { throw null; } set { } }
        [System.MonoTODOAttribute]
        public string Authority { get { throw null; } set { } }
        [System.MonoTODOAttribute]
        public bool EnablePrivileges { get { throw null; } set { } }
        [System.MonoTODOAttribute]
        public System.Management.ImpersonationLevel Impersonation { get { throw null; } set { } }
        [System.MonoTODOAttribute]
        public string Locale { get { throw null; } set { } }
        [System.MonoTODOAttribute]
        public string Password { set { } }
        public System.Security.SecureString SecurePassword { set { } }
        [System.MonoTODOAttribute]
        public string Username { get { throw null; } set { } }
        [System.MonoTODOAttribute]
        public override object Clone() { throw null; }
    }
    public partial class DeleteOptions : System.Management.ManagementOptions
    {
        [System.MonoTODOAttribute]
        public DeleteOptions() { }
        [System.MonoTODOAttribute]
        public DeleteOptions(System.Management.ManagementNamedValueCollection context, System.TimeSpan timeout) { }
        [System.MonoTODOAttribute]
        public override object Clone() { throw null; }
    }
    public partial class EnumerationOptions : System.Management.ManagementOptions
    {
        public EnumerationOptions() { }
        public EnumerationOptions(System.Management.ManagementNamedValueCollection context, System.TimeSpan timeout, int blockSize, bool rewindable, bool returnImmediatley, bool useAmendedQualifiers, bool ensureLocatable, bool prototypeOnly, bool directRead, bool enumerateDeep) { }
        public int BlockSize { [System.MonoTODOAttribute]get { throw null; } [System.MonoTODOAttribute]set { } }
        public bool DirectRead { [System.MonoTODOAttribute]get { throw null; } [System.MonoTODOAttribute]set { } }
        public bool EnsureLocatable { [System.MonoTODOAttribute]get { throw null; } [System.MonoTODOAttribute]set { } }
        public bool EnumerateDeep { [System.MonoTODOAttribute]get { throw null; } [System.MonoTODOAttribute]set { } }
        public bool PrototypeOnly { [System.MonoTODOAttribute]get { throw null; } [System.MonoTODOAttribute]set { } }
        public bool ReturnImmediately { [System.MonoTODOAttribute]get { throw null; } [System.MonoTODOAttribute]set { } }
        public bool Rewindable { [System.MonoTODOAttribute]get { throw null; } [System.MonoTODOAttribute]set { } }
        public bool UseAmendedQualifiers { [System.MonoTODOAttribute]get { throw null; } [System.MonoTODOAttribute]set { } }
        [System.MonoTODOAttribute]
        public override object Clone() { throw null; }
    }
    public partial class EventArrivedEventArgs : System.Management.ManagementEventArgs
    {
        internal EventArrivedEventArgs() { }
        public System.Management.ManagementBaseObject NewEvent { get { throw null; } }
    }
    public delegate void EventArrivedEventHandler(object sender, System.Management.EventArrivedEventArgs e);
    public partial class EventQuery : System.Management.ManagementQuery
    {
        [System.MonoTODOAttribute]
        public EventQuery() { }
        [System.MonoTODOAttribute]
        public EventQuery(string query) { }
        [System.MonoTODOAttribute]
        public EventQuery(string language, string query) { }
        [System.MonoTODOAttribute]
        public override object Clone() { throw null; }
    }
    public partial class EventWatcherOptions : System.Management.ManagementOptions
    {
        [System.MonoTODOAttribute]
        public EventWatcherOptions() { }
        [System.MonoTODOAttribute]
        public EventWatcherOptions(System.Management.ManagementNamedValueCollection context, System.TimeSpan timeout, int blockSize) { }
        [System.MonoTODOAttribute]
        public int BlockSize { get { throw null; } set { } }
        [System.MonoTODOAttribute]
        public override object Clone() { throw null; }
    }
    public enum ImpersonationLevel
    {
        Anonymous = 1,
        Default = 0,
        Delegate = 4,
        Identify = 2,
        Impersonate = 3,
    }
    public partial class InvokeMethodOptions : System.Management.ManagementOptions
    {
        [System.MonoTODOAttribute]
        public InvokeMethodOptions() { }
        [System.MonoTODOAttribute]
        public InvokeMethodOptions(System.Management.ManagementNamedValueCollection context, System.TimeSpan timeout) { }
        [System.MonoTODOAttribute]
        public override object Clone() { throw null; }
    }
    [System.ComponentModel.ToolboxItemAttribute(true)]
    [System.SerializableAttribute]
    public partial class ManagementBaseObject : System.ComponentModel.Component, System.ICloneable, System.Runtime.Serialization.ISerializable
    {
        [System.MonoTODOAttribute]
        protected ManagementBaseObject(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
        public virtual System.Management.ManagementPath ClassPath { [System.MonoTODOAttribute]get { throw null; } }
        public object this[string propertyName] { [System.MonoTODOAttribute]get { throw null; } [System.MonoTODOAttribute]set { } }
        public virtual System.Management.PropertyDataCollection Properties { [System.MonoTODOAttribute]get { throw null; } }
        public virtual System.Management.QualifierDataCollection Qualifiers { [System.MonoTODOAttribute]get { throw null; } }
        public virtual System.Management.PropertyDataCollection SystemProperties { [System.MonoTODOAttribute]get { throw null; } }
        [System.MonoTODOAttribute]
        public virtual object Clone() { throw null; }
        [System.MonoTODOAttribute]
        public bool CompareTo(System.Management.ManagementBaseObject otherObject, System.Management.ComparisonSettings settings) { throw null; }
        public new void Dispose() { }
        [System.MonoTODOAttribute]
        public override bool Equals(object obj) { throw null; }
        [System.MonoTODOAttribute]
        public override int GetHashCode() { throw null; }
        [System.MonoTODOAttribute]
        protected virtual void GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
        [System.MonoTODOAttribute]
        public object GetPropertyQualifierValue(string propertyName, string qualifierName) { throw null; }
        [System.MonoTODOAttribute]
        public object GetPropertyValue(string propertyName) { throw null; }
        [System.MonoTODOAttribute]
        public object GetQualifierValue(string qualifierName) { throw null; }
        [System.MonoTODOAttribute]
        public string GetText(System.Management.TextFormat format) { throw null; }
        [System.MonoTODOAttribute]
        public static explicit operator System.IntPtr (System.Management.ManagementBaseObject managementObject) { throw null; }
        [System.MonoTODOAttribute]
        public void SetPropertyQualifierValue(string propertyName, string qualifierName, object qualifierValue) { }
        [System.MonoTODOAttribute]
        public void SetPropertyValue(string propertyName, object propertyValue) { }
        [System.MonoTODOAttribute]
        public void SetQualifierValue(string qualifierName, object qualifierValue) { }
        [System.MonoTODOAttribute]
        void System.Runtime.Serialization.ISerializable.GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
    }
    [System.MonoTODOAttribute("System.Management is not implemented")]
    [System.SerializableAttribute]
    public partial class ManagementClass : System.Management.ManagementObject
    {
        public ManagementClass() { }
        public ManagementClass(System.Management.ManagementPath path) { }
        public ManagementClass(System.Management.ManagementPath path, System.Management.ObjectGetOptions options) { }
        public ManagementClass(System.Management.ManagementScope scope, System.Management.ManagementPath path, System.Management.ObjectGetOptions options) { }
        [System.MonoTODOAttribute]
        protected ManagementClass(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
        public ManagementClass(string path) { }
        public ManagementClass(string path, System.Management.ObjectGetOptions options) { }
        public ManagementClass(string scope, string path, System.Management.ObjectGetOptions options) { }
        public System.Collections.Specialized.StringCollection Derivation { get { throw null; } }
        public System.Management.MethodDataCollection Methods { get { throw null; } }
        public override System.Management.ManagementPath Path { get { throw null; } set { } }
        public override object Clone() { throw null; }
        public System.Management.ManagementObject CreateInstance() { throw null; }
        public System.Management.ManagementClass Derive(string newClassName) { throw null; }
        public System.Management.ManagementObjectCollection GetInstances() { throw null; }
        public System.Management.ManagementObjectCollection GetInstances(System.Management.EnumerationOptions options) { throw null; }
        public void GetInstances(System.Management.ManagementOperationObserver watcher) { }
        public void GetInstances(System.Management.ManagementOperationObserver watcher, System.Management.EnumerationOptions options) { }
        [System.MonoTODOAttribute]
        protected override void GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
        public System.Management.ManagementObjectCollection GetRelatedClasses() { throw null; }
        public void GetRelatedClasses(System.Management.ManagementOperationObserver watcher) { }
        public void GetRelatedClasses(System.Management.ManagementOperationObserver watcher, string relatedClass) { }
        public void GetRelatedClasses(System.Management.ManagementOperationObserver watcher, string relatedClass, string relationshipClass, string relationshipQualifier, string relatedQualifier, string relatedRole, string thisRole, System.Management.EnumerationOptions options) { }
        public System.Management.ManagementObjectCollection GetRelatedClasses(string relatedClass) { throw null; }
        public System.Management.ManagementObjectCollection GetRelatedClasses(string relatedClass, string relationshipClass, string relationshipQualifier, string relatedQualifier, string relatedRole, string thisRole, System.Management.EnumerationOptions options) { throw null; }
        public System.Management.ManagementObjectCollection GetRelationshipClasses() { throw null; }
        public void GetRelationshipClasses(System.Management.ManagementOperationObserver watcher) { }
        public void GetRelationshipClasses(System.Management.ManagementOperationObserver watcher, string relationshipClass) { }
        public void GetRelationshipClasses(System.Management.ManagementOperationObserver watcher, string relationshipClass, string relationshipQualifier, string thisRole, System.Management.EnumerationOptions options) { }
        public System.Management.ManagementObjectCollection GetRelationshipClasses(string relationshipClass) { throw null; }
        public System.Management.ManagementObjectCollection GetRelationshipClasses(string relationshipClass, string relationshipQualifier, string thisRole, System.Management.EnumerationOptions options) { throw null; }
        public System.CodeDom.CodeTypeDeclaration GetStronglyTypedClassCode(bool includeSystemClassInClassDef, bool systemPropertyClass) { throw null; }
        public bool GetStronglyTypedClassCode(System.Management.CodeLanguage lang, string filePath, string classNamespace) { throw null; }
        public System.Management.ManagementObjectCollection GetSubclasses() { throw null; }
        public System.Management.ManagementObjectCollection GetSubclasses(System.Management.EnumerationOptions options) { throw null; }
        public void GetSubclasses(System.Management.ManagementOperationObserver watcher) { }
        public void GetSubclasses(System.Management.ManagementOperationObserver watcher, System.Management.EnumerationOptions options) { }
    }
    public sealed partial class ManagementDateTimeConverter
    {
        internal ManagementDateTimeConverter() { }
        [System.MonoTODOAttribute]
        public static System.DateTime ToDateTime(string dmtfDate) { throw null; }
        [System.MonoTODOAttribute]
        public static string ToDmtfDateTime(System.DateTime date) { throw null; }
        [System.MonoTODOAttribute]
        public static string ToDmtfTimeInterval(System.TimeSpan timespan) { throw null; }
        [System.MonoTODOAttribute]
        public static System.TimeSpan ToTimeSpan(string dmtfTimespan) { throw null; }
    }
    public abstract partial class ManagementEventArgs : System.EventArgs
    {
        internal ManagementEventArgs() { }
        public object Context { get { throw null; } }
    }
    [System.ComponentModel.ToolboxItemAttribute(true)]
    public partial class ManagementEventWatcher : System.ComponentModel.Component
    {
        [System.MonoTODOAttribute]
        public ManagementEventWatcher() { }
        [System.MonoTODOAttribute]
        public ManagementEventWatcher(System.Management.EventQuery query) { }
        [System.MonoTODOAttribute]
        public ManagementEventWatcher(System.Management.ManagementScope scope, System.Management.EventQuery query) { }
        [System.MonoTODOAttribute]
        public ManagementEventWatcher(System.Management.ManagementScope scope, System.Management.EventQuery query, System.Management.EventWatcherOptions options) { }
        [System.MonoTODOAttribute]
        public ManagementEventWatcher(string query) { }
        [System.MonoTODOAttribute]
        public ManagementEventWatcher(string scope, string query) { }
        [System.MonoTODOAttribute]
        public ManagementEventWatcher(string scope, string query, System.Management.EventWatcherOptions options) { }
        [System.MonoTODOAttribute]
        public System.Management.EventWatcherOptions Options { get { throw null; } set { } }
        [System.MonoTODOAttribute]
        public System.Management.EventQuery Query { get { throw null; } set { } }
        [System.MonoTODOAttribute]
        public System.Management.ManagementScope Scope { get { throw null; } set { } }
        public event System.Management.EventArrivedEventHandler EventArrived { add { } remove { } }
        public event System.Management.StoppedEventHandler Stopped { add { } remove { } }
        [System.MonoTODOAttribute]
        ~ManagementEventWatcher() { }
        [System.MonoTODOAttribute]
        public void Start() { }
        [System.MonoTODOAttribute]
        public void Stop() { }
        [System.MonoTODOAttribute]
        public System.Management.ManagementBaseObject WaitForNextEvent() { throw null; }
    }
    [System.SerializableAttribute]
    public partial class ManagementException : System.SystemException
    {
        public ManagementException() { }
        protected ManagementException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
        public ManagementException(string message) { }
        public ManagementException(string message, System.Exception innerException) { }
        [System.MonoTODOAttribute]
        public System.Management.ManagementStatus ErrorCode { get { throw null; } }
        [System.MonoTODOAttribute]
        public System.Management.ManagementBaseObject ErrorInformation { get { throw null; } }
        public override void GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
    }
    public partial class ManagementNamedValueCollection : System.Collections.Specialized.NameObjectCollectionBase
    {
        public ManagementNamedValueCollection() { }
        protected ManagementNamedValueCollection(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
        public object this[string name] { get { throw null; } }
        public void Add(string name, object value) { }
        public System.Management.ManagementNamedValueCollection Clone() { throw null; }
        public void Remove(string name) { }
        public void RemoveAll() { }
    }
    [System.SerializableAttribute]
    public partial class ManagementObject : System.Management.ManagementBaseObject, System.ICloneable
    {
        [System.MonoTODOAttribute]
        public ManagementObject() : base (default(System.Runtime.Serialization.SerializationInfo), default(System.Runtime.Serialization.StreamingContext)) { }
        [System.MonoTODOAttribute]
        public ManagementObject(System.Management.ManagementPath path) : base (default(System.Runtime.Serialization.SerializationInfo), default(System.Runtime.Serialization.StreamingContext)) { }
        [System.MonoTODOAttribute]
        public ManagementObject(System.Management.ManagementPath path, System.Management.ObjectGetOptions options) : base (default(System.Runtime.Serialization.SerializationInfo), default(System.Runtime.Serialization.StreamingContext)) { }
        [System.MonoTODOAttribute]
        public ManagementObject(System.Management.ManagementScope scope, System.Management.ManagementPath path, System.Management.ObjectGetOptions options) : base (default(System.Runtime.Serialization.SerializationInfo), default(System.Runtime.Serialization.StreamingContext)) { }
        [System.MonoTODOAttribute]
        protected ManagementObject(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) : base (default(System.Runtime.Serialization.SerializationInfo), default(System.Runtime.Serialization.StreamingContext)) { }
        [System.MonoTODOAttribute]
        public ManagementObject(string path) : base (default(System.Runtime.Serialization.SerializationInfo), default(System.Runtime.Serialization.StreamingContext)) { }
        [System.MonoTODOAttribute]
        public ManagementObject(string path, System.Management.ObjectGetOptions options) : base (default(System.Runtime.Serialization.SerializationInfo), default(System.Runtime.Serialization.StreamingContext)) { }
        [System.MonoTODOAttribute]
        public ManagementObject(string scopeString, string pathString, System.Management.ObjectGetOptions options) : base (default(System.Runtime.Serialization.SerializationInfo), default(System.Runtime.Serialization.StreamingContext)) { }
        public override System.Management.ManagementPath ClassPath { [System.MonoTODOAttribute]get { throw null; } }
        public System.Management.ObjectGetOptions Options { [System.MonoTODOAttribute]get { throw null; } [System.MonoTODOAttribute]set { } }
        public virtual System.Management.ManagementPath Path { [System.MonoTODOAttribute]get { throw null; } [System.MonoTODOAttribute]set { } }
        public System.Management.ManagementScope Scope { [System.MonoTODOAttribute]get { throw null; } [System.MonoTODOAttribute]set { } }
        [System.MonoTODOAttribute]
        public override object Clone() { throw null; }
        [System.MonoTODOAttribute]
        public void CopyTo(System.Management.ManagementOperationObserver watcher, System.Management.ManagementPath path) { }
        [System.MonoTODOAttribute]
        public void CopyTo(System.Management.ManagementOperationObserver watcher, System.Management.ManagementPath path, System.Management.PutOptions options) { }
        [System.MonoTODOAttribute]
        public void CopyTo(System.Management.ManagementOperationObserver watcher, string path) { }
        [System.MonoTODOAttribute]
        public void CopyTo(System.Management.ManagementOperationObserver watcher, string path, System.Management.PutOptions options) { }
        [System.MonoTODOAttribute]
        public System.Management.ManagementPath CopyTo(System.Management.ManagementPath path) { throw null; }
        [System.MonoTODOAttribute]
        public System.Management.ManagementPath CopyTo(System.Management.ManagementPath path, System.Management.PutOptions options) { throw null; }
        [System.MonoTODOAttribute]
        public System.Management.ManagementPath CopyTo(string path) { throw null; }
        [System.MonoTODOAttribute]
        public System.Management.ManagementPath CopyTo(string path, System.Management.PutOptions options) { throw null; }
        [System.MonoTODOAttribute]
        public void Delete() { }
        [System.MonoTODOAttribute]
        public void Delete(System.Management.DeleteOptions options) { }
        [System.MonoTODOAttribute]
        public void Delete(System.Management.ManagementOperationObserver watcher) { }
        [System.MonoTODOAttribute]
        public void Delete(System.Management.ManagementOperationObserver watcher, System.Management.DeleteOptions options) { }
        [System.MonoTODOAttribute]
        public new void Dispose() { }
        [System.MonoTODOAttribute]
        public void Get() { }
        [System.MonoTODOAttribute]
        public void Get(System.Management.ManagementOperationObserver watcher) { }
        [System.MonoTODOAttribute]
        public System.Management.ManagementBaseObject GetMethodParameters(string methodName) { throw null; }
        [System.MonoTODOAttribute]
        protected override void GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
        [System.MonoTODOAttribute]
        public System.Management.ManagementObjectCollection GetRelated() { throw null; }
        [System.MonoTODOAttribute]
        public void GetRelated(System.Management.ManagementOperationObserver watcher) { }
        [System.MonoTODOAttribute]
        public void GetRelated(System.Management.ManagementOperationObserver watcher, string relatedClass) { }
        [System.MonoTODOAttribute]
        public void GetRelated(System.Management.ManagementOperationObserver watcher, string relatedClass, string relationshipClass, string relationshipQualifier, string relatedQualifier, string relatedRole, string thisRole, bool classDefinitionsOnly, System.Management.EnumerationOptions options) { }
        [System.MonoTODOAttribute]
        public System.Management.ManagementObjectCollection GetRelated(string relatedClass) { throw null; }
        [System.MonoTODOAttribute]
        public System.Management.ManagementObjectCollection GetRelated(string relatedClass, string relationshipClass, string relationshipQualifier, string relatedQualifier, string relatedRole, string thisRole, bool classDefinitionsOnly, System.Management.EnumerationOptions options) { throw null; }
        [System.MonoTODOAttribute]
        public System.Management.ManagementObjectCollection GetRelationships() { throw null; }
        [System.MonoTODOAttribute]
        public void GetRelationships(System.Management.ManagementOperationObserver watcher) { }
        [System.MonoTODOAttribute]
        public void GetRelationships(System.Management.ManagementOperationObserver watcher, string relationshipClass) { }
        [System.MonoTODOAttribute]
        public void GetRelationships(System.Management.ManagementOperationObserver watcher, string relationshipClass, string relationshipQualifier, string thisRole, bool classDefinitionsOnly, System.Management.EnumerationOptions options) { }
        [System.MonoTODOAttribute]
        public System.Management.ManagementObjectCollection GetRelationships(string relationshipClass) { throw null; }
        [System.MonoTODOAttribute]
        public System.Management.ManagementObjectCollection GetRelationships(string relationshipClass, string relationshipQualifier, string thisRole, bool classDefinitionsOnly, System.Management.EnumerationOptions options) { throw null; }
        [System.MonoTODOAttribute]
        public void InvokeMethod(System.Management.ManagementOperationObserver watcher, string methodName, System.Management.ManagementBaseObject inParameters, System.Management.InvokeMethodOptions options) { }
        [System.MonoTODOAttribute]
        public void InvokeMethod(System.Management.ManagementOperationObserver watcher, string methodName, object[] args) { }
        [System.MonoTODOAttribute]
        public System.Management.ManagementBaseObject InvokeMethod(string methodName, System.Management.ManagementBaseObject inParameters, System.Management.InvokeMethodOptions options) { throw null; }
        [System.MonoTODOAttribute]
        public object InvokeMethod(string methodName, object[] args) { throw null; }
        [System.MonoTODOAttribute]
        public System.Management.ManagementPath Put() { throw null; }
        [System.MonoTODOAttribute]
        public void Put(System.Management.ManagementOperationObserver watcher) { }
        [System.MonoTODOAttribute]
        public void Put(System.Management.ManagementOperationObserver watcher, System.Management.PutOptions options) { }
        [System.MonoTODOAttribute]
        public System.Management.ManagementPath Put(System.Management.PutOptions options) { throw null; }
        [System.MonoTODOAttribute]
        public override string ToString() { throw null; }
    }
    public partial class ManagementObjectCollection : System.Collections.ICollection, System.Collections.IEnumerable, System.IDisposable
    {
        internal ManagementObjectCollection() { }
        public int Count { [System.MonoTODOAttribute]get { throw null; } }
        public bool IsSynchronized { [System.MonoTODOAttribute]get { throw null; } }
        public object SyncRoot { [System.MonoTODOAttribute]get { throw null; } }
        [System.MonoTODOAttribute]
        public void CopyTo(System.Array array, int index) { }
        [System.MonoTODOAttribute]
        public void CopyTo(System.Management.ManagementBaseObject[] objectCollection, int index) { }
        [System.MonoTODOAttribute]
        public void Dispose() { }
        ~ManagementObjectCollection() { }
        [System.MonoTODOAttribute]
        public System.Management.ManagementObjectCollection.ManagementObjectEnumerator GetEnumerator() { throw null; }
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { throw null; }
        public partial class ManagementObjectEnumerator : System.Collections.IEnumerator, System.IDisposable
        {
            internal ManagementObjectEnumerator() { }
            public System.Management.ManagementBaseObject Current { [System.MonoTODOAttribute]get { throw null; } }
            object System.Collections.IEnumerator.Current { [System.MonoTODOAttribute]get { throw null; } }
            [System.MonoTODOAttribute]
            public void Dispose() { }
            [System.MonoTODOAttribute]
            ~ManagementObjectEnumerator() { }
            [System.MonoTODOAttribute]
            public bool MoveNext() { throw null; }
            [System.MonoTODOAttribute]
            public void Reset() { }
        }
    }
    [System.ComponentModel.ToolboxItemAttribute(false)]
    public partial class ManagementObjectSearcher : System.ComponentModel.Component
    {
        public ManagementObjectSearcher() { }
        public ManagementObjectSearcher(System.Management.ManagementScope scope, System.Management.ObjectQuery query) { }
        public ManagementObjectSearcher(System.Management.ManagementScope scope, System.Management.ObjectQuery query, System.Management.EnumerationOptions options) { }
        public ManagementObjectSearcher(System.Management.ObjectQuery query) { }
        public ManagementObjectSearcher(string queryString) { }
        public ManagementObjectSearcher(string scope, string queryString) { }
        public ManagementObjectSearcher(string scope, string queryString, System.Management.EnumerationOptions options) { }
        public System.Management.EnumerationOptions Options { get { throw null; } set { } }
        public System.Management.ObjectQuery Query { get { throw null; } set { } }
        public System.Management.ManagementScope Scope { get { throw null; } set { } }
        public System.Management.ManagementObjectCollection Get() { throw null; }
        public void Get(System.Management.ManagementOperationObserver watcher) { }
    }
    public partial class ManagementOperationObserver
    {
        [System.MonoTODOAttribute]
        public ManagementOperationObserver() { }
        public event System.Management.CompletedEventHandler Completed { add { } remove { } }
        public event System.Management.ObjectPutEventHandler ObjectPut { add { } remove { } }
        public event System.Management.ObjectReadyEventHandler ObjectReady { add { } remove { } }
        public event System.Management.ProgressEventHandler Progress { add { } remove { } }
        [System.MonoTODOAttribute]
        public void Cancel() { }
    }
    [System.ComponentModel.TypeConverterAttribute(typeof(System.ComponentModel.ExpandableObjectConverter))]
    public abstract partial class ManagementOptions : System.ICloneable
    {
        internal ManagementOptions() { }
        public static readonly System.TimeSpan InfiniteTimeout;
        public System.Management.ManagementNamedValueCollection Context { get { throw null; } set { } }
        public System.TimeSpan Timeout { get { throw null; } set { } }
        [System.MonoTODOAttribute]
        public abstract object Clone();
    }
    public partial class ManagementPath : System.ICloneable
    {
        [System.MonoTODOAttribute]
        public ManagementPath() { }
        [System.MonoTODOAttribute]
        public ManagementPath(string path) { }
        [System.ComponentModel.RefreshPropertiesAttribute((System.ComponentModel.RefreshProperties)(1))]
        public string ClassName { [System.MonoTODOAttribute]get { throw null; } [System.MonoTODOAttribute]set { } }
        public static System.Management.ManagementPath DefaultPath { [System.MonoTODOAttribute]get { throw null; } [System.MonoTODOAttribute]set { } }
        public bool IsClass { [System.MonoTODOAttribute]get { throw null; } }
        public bool IsInstance { [System.MonoTODOAttribute]get { throw null; } }
        public bool IsSingleton { [System.MonoTODOAttribute]get { throw null; } }
        [System.ComponentModel.RefreshPropertiesAttribute((System.ComponentModel.RefreshProperties)(1))]
        public string NamespacePath { [System.MonoTODOAttribute]get { throw null; } [System.MonoTODOAttribute]set { } }
        [System.ComponentModel.RefreshPropertiesAttribute((System.ComponentModel.RefreshProperties)(1))]
        public string Path { [System.MonoTODOAttribute]get { throw null; } [System.MonoTODOAttribute]set { } }
        [System.ComponentModel.RefreshPropertiesAttribute((System.ComponentModel.RefreshProperties)(1))]
        public string RelativePath { [System.MonoTODOAttribute]get { throw null; } [System.MonoTODOAttribute]set { } }
        [System.ComponentModel.RefreshPropertiesAttribute((System.ComponentModel.RefreshProperties)(1))]
        public string Server { [System.MonoTODOAttribute]get { throw null; } [System.MonoTODOAttribute]set { } }
        [System.MonoTODOAttribute]
        public System.Management.ManagementPath Clone() { throw null; }
        [System.MonoTODOAttribute]
        public void SetAsClass() { }
        [System.MonoTODOAttribute]
        public void SetAsSingleton() { }
        [System.MonoTODOAttribute]
        object System.ICloneable.Clone() { throw null; }
        [System.MonoTODOAttribute]
        public override string ToString() { throw null; }
    }
    [System.MonoTODOAttribute("System.Management is not implemented")]
    public abstract partial class ManagementQuery : System.ICloneable
    {
        internal ManagementQuery() { }
        public virtual string QueryLanguage { get { throw null; } set { } }
        public virtual string QueryString { get { throw null; } set { } }
        public abstract object Clone();
        [System.MonoTODOAttribute]
        protected internal virtual void ParseQuery(string query) { }
    }
    public partial class ManagementScope : System.ICloneable
    {
        [System.MonoTODOAttribute]
        public ManagementScope() { }
        [System.MonoTODOAttribute]
        public ManagementScope(System.Management.ManagementPath path) { }
        [System.MonoTODOAttribute]
        public ManagementScope(System.Management.ManagementPath path, System.Management.ConnectionOptions options) { }
        [System.MonoTODOAttribute]
        public ManagementScope(string path) { }
        [System.MonoTODOAttribute]
        public ManagementScope(string path, System.Management.ConnectionOptions options) { }
        public bool IsConnected { [System.MonoTODOAttribute]get { throw null; } }
        public System.Management.ConnectionOptions Options { [System.MonoTODOAttribute]get { throw null; } [System.MonoTODOAttribute]set { } }
        public System.Management.ManagementPath Path { [System.MonoTODOAttribute]get { throw null; } [System.MonoTODOAttribute]set { } }
        [System.MonoTODOAttribute]
        public System.Management.ManagementScope Clone() { throw null; }
        [System.MonoTODOAttribute]
        public void Connect() { }
        [System.MonoTODOAttribute]
        object System.ICloneable.Clone() { throw null; }
    }
    public enum ManagementStatus
    {
        AccessDenied = -2147217405,
        AggregatingByObject = -2147217315,
        AlreadyExists = -2147217383,
        AmendedObject = -2147217306,
        BackupRestoreWinmgmtRunning = -2147217312,
        BufferTooSmall = -2147217348,
        CallCanceled = -2147217358,
        CannotBeAbstract = -2147217307,
        CannotBeKey = -2147217377,
        CannotBeSingleton = -2147217364,
        CannotChangeIndexInheritance = -2147217328,
        CannotChangeKeyInheritance = -2147217335,
        CircularReference = -2147217337,
        ClassHasChildren = -2147217371,
        ClassHasInstances = -2147217370,
        ClientTooSlow = -2147217305,
        CriticalError = -2147217398,
        Different = 262147,
        DuplicateObjects = 262152,
        Failed = -2147217407,
        False = 1,
        IllegalNull = -2147217368,
        IllegalOperation = -2147217378,
        IncompleteClass = -2147217376,
        InitializationFailure = -2147217388,
        InvalidCimType = -2147217363,
        InvalidClass = -2147217392,
        InvalidContext = -2147217401,
        InvalidDuplicateParameter = -2147217341,
        InvalidFlavor = -2147217338,
        InvalidMethod = -2147217362,
        InvalidMethodParameters = -2147217361,
        InvalidNamespace = -2147217394,
        InvalidObject = -2147217393,
        InvalidObjectPath = -2147217350,
        InvalidOperation = -2147217386,
        InvalidOperator = -2147217309,
        InvalidParameter = -2147217400,
        InvalidParameterID = -2147217353,
        InvalidProperty = -2147217359,
        InvalidPropertyType = -2147217366,
        InvalidProviderRegistration = -2147217390,
        InvalidQualifier = -2147217342,
        InvalidQualifierType = -2147217367,
        InvalidQuery = -2147217385,
        InvalidQueryType = -2147217384,
        InvalidStream = -2147217397,
        InvalidSuperclass = -2147217395,
        InvalidSyntax = -2147217375,
        LocalCredentials = -2147217308,
        MarshalInvalidSignature = -2147217343,
        MarshalVersionMismatch = -2147217344,
        MethodDisabled = -2147217322,
        MethodNotImplemented = -2147217323,
        MissingAggregationList = -2147217317,
        MissingGroupWithin = -2147217318,
        MissingParameterID = -2147217354,
        NoError = 0,
        NoMoreData = 262149,
        NonconsecutiveParameterIDs = -2147217352,
        NondecoratedObject = -2147217374,
        NotAvailable = -2147217399,
        NotEventClass = -2147217319,
        NotFound = -2147217406,
        NotSupported = -2147217396,
        OperationCanceled = 262150,
        OutOfDiskSpace = -2147217349,
        OutOfMemory = -2147217402,
        OverrideNotAllowed = -2147217382,
        ParameterIDOnRetval = -2147217351,
        PartialResults = 262160,
        Pending = 262151,
        PrivilegeNotHeld = -2147217310,
        PropagatedMethod = -2147217356,
        PropagatedProperty = -2147217380,
        PropagatedQualifier = -2147217381,
        PropertyNotAnObject = -2147217316,
        ProviderFailure = -2147217404,
        ProviderLoadFailure = -2147217389,
        ProviderNotCapable = -2147217372,
        ProviderNotFound = -2147217391,
        QueryNotImplemented = -2147217369,
        QueueOverflow = -2147217311,
        ReadOnly = -2147217373,
        RefresherBusy = -2147217321,
        RegistrationTooBroad = -2147213311,
        RegistrationTooPrecise = -2147213310,
        ResetToDefault = 262146,
        ServerTooBusy = -2147217339,
        ShuttingDown = -2147217357,
        SystemProperty = -2147217360,
        Timedout = 262148,
        TooManyProperties = -2147217327,
        TooMuchData = -2147217340,
        TransportFailure = -2147217387,
        TypeMismatch = -2147217403,
        Unexpected = -2147217379,
        UninterpretableProviderQuery = -2147217313,
        UnknownObjectType = -2147217346,
        UnknownPacketType = -2147217345,
        UnparsableQuery = -2147217320,
        UnsupportedClassUpdate = -2147217336,
        UnsupportedParameter = -2147217355,
        UnsupportedPutExtension = -2147217347,
        UpdateOverrideNotAllowed = -2147217325,
        UpdatePropagatedMethod = -2147217324,
        UpdateTypeMismatch = -2147217326,
        ValueOutOfRange = -2147217365,
    }
    public partial class MethodData
    {
        internal MethodData() { }
        public System.Management.ManagementBaseObject InParameters { get { throw null; } }
        public string Name { get { throw null; } }
        public string Origin { get { throw null; } }
        public System.Management.ManagementBaseObject OutParameters { get { throw null; } }
        public System.Management.QualifierDataCollection Qualifiers { get { throw null; } }
    }
    [System.MonoTODOAttribute("System.Management is not implemented")]
    public partial class MethodDataCollection : System.Collections.ICollection, System.Collections.IEnumerable
    {
        internal MethodDataCollection() { }
        public int Count { get { throw null; } }
        public bool IsSynchronized { get { throw null; } }
        public virtual System.Management.MethodData this[string methodName] { get { throw null; } }
        public object SyncRoot { get { throw null; } }
        public virtual void Add(string methodName) { }
        public virtual void Add(string methodName, System.Management.ManagementBaseObject inParameters, System.Management.ManagementBaseObject outParameters) { }
        public void CopyTo(System.Array array, int index) { }
        public void CopyTo(System.Management.MethodData[] methodArray, int index) { }
        public System.Management.MethodDataCollection.MethodDataEnumerator GetEnumerator() { throw null; }
        public virtual void Remove(string methodName) { }
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { throw null; }
        public partial class MethodDataEnumerator : System.Collections.IEnumerator
        {
            internal MethodDataEnumerator() { }
            public System.Management.MethodData Current { get { throw null; } }
            object System.Collections.IEnumerator.Current { get { throw null; } }
            public bool MoveNext() { throw null; }
            public void Reset() { }
        }
    }
    public partial class ObjectGetOptions : System.Management.ManagementOptions
    {
        [System.MonoTODOAttribute]
        public ObjectGetOptions() { }
        [System.MonoTODOAttribute]
        public ObjectGetOptions(System.Management.ManagementNamedValueCollection context) { }
        [System.MonoTODOAttribute]
        public ObjectGetOptions(System.Management.ManagementNamedValueCollection context, System.TimeSpan timeout, bool useAmendedQualifiers) { }
        [System.MonoTODOAttribute]
        public bool UseAmendedQualifiers { get { throw null; } set { } }
        [System.MonoTODOAttribute]
        public override object Clone() { throw null; }
    }
    public partial class ObjectPutEventArgs : System.Management.ManagementEventArgs
    {
        internal ObjectPutEventArgs() { }
        [System.MonoTODOAttribute]
        public System.Management.ManagementPath Path { get { throw null; } }
    }
    public delegate void ObjectPutEventHandler(object sender, System.Management.ObjectPutEventArgs e);
    public partial class ObjectQuery : System.Management.ManagementQuery
    {
        public ObjectQuery() { }
        public ObjectQuery(string query) { }
        public ObjectQuery(string language, string query) { }
        public override object Clone() { throw null; }
    }
    public partial class ObjectReadyEventArgs : System.Management.ManagementEventArgs
    {
        internal ObjectReadyEventArgs() { }
        public System.Management.ManagementBaseObject NewObject { [System.MonoTODOAttribute]get { throw null; } }
    }
    public delegate void ObjectReadyEventHandler(object sender, System.Management.ObjectReadyEventArgs e);
    public partial class ProgressEventArgs : System.Management.ManagementEventArgs
    {
        internal ProgressEventArgs() { }
        public int Current { [System.MonoTODOAttribute]get { throw null; } }
        public string Message { [System.MonoTODOAttribute]get { throw null; } }
        public int UpperBound { [System.MonoTODOAttribute]get { throw null; } }
    }
    public delegate void ProgressEventHandler(object sender, System.Management.ProgressEventArgs e);
    public partial class PropertyData
    {
        internal PropertyData() { }
        public bool IsArray { [System.MonoTODOAttribute]get { throw null; } }
        public bool IsLocal { [System.MonoTODOAttribute]get { throw null; } }
        public string Name { [System.MonoTODOAttribute]get { throw null; } }
        public string Origin { [System.MonoTODOAttribute]get { throw null; } }
        public System.Management.QualifierDataCollection Qualifiers { [System.MonoTODOAttribute]get { throw null; } }
        public System.Management.CimType Type { [System.MonoTODOAttribute]get { throw null; } }
        public object Value { [System.MonoTODOAttribute]get { throw null; } [System.MonoTODOAttribute]set { } }
    }
    public partial class PropertyDataCollection : System.Collections.ICollection, System.Collections.IEnumerable
    {
        internal PropertyDataCollection() { }
        [System.MonoTODOAttribute]
        public int Count { get { throw null; } }
        [System.MonoTODOAttribute]
        public bool IsSynchronized { get { throw null; } }
        [System.MonoTODOAttribute]
        public virtual System.Management.PropertyData this[string propertyName] { get { throw null; } }
        [System.MonoTODOAttribute]
        public object SyncRoot { get { throw null; } }
        [System.MonoTODOAttribute]
        public void Add(string propertyName, System.Management.CimType propertyType, bool isArray) { }
        [System.MonoTODOAttribute]
        public virtual void Add(string propertyName, object propertyValue) { }
        [System.MonoTODOAttribute]
        public void Add(string propertyName, object propertyValue, System.Management.CimType propertyType) { }
        [System.MonoTODOAttribute]
        public void CopyTo(System.Array array, int index) { }
        [System.MonoTODOAttribute]
        public void CopyTo(System.Management.PropertyData[] propertyArray, int index) { }
        [System.MonoTODOAttribute]
        public System.Management.PropertyDataCollection.PropertyDataEnumerator GetEnumerator() { throw null; }
        [System.MonoTODOAttribute]
        public virtual void Remove(string propertyName) { }
        [System.MonoTODOAttribute]
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { throw null; }
        public partial class PropertyDataEnumerator : System.Collections.IEnumerator
        {
            internal PropertyDataEnumerator() { }
            public System.Management.PropertyData Current { [System.MonoTODOAttribute]get { throw null; } }
            object System.Collections.IEnumerator.Current { [System.MonoTODOAttribute]get { throw null; } }
            [System.MonoTODOAttribute]
            public bool MoveNext() { throw null; }
            [System.MonoTODOAttribute]
            public void Reset() { }
        }
    }
    public partial class PutOptions : System.Management.ManagementOptions
    {
        public PutOptions() { }
        public PutOptions(System.Management.ManagementNamedValueCollection context) { }
        public PutOptions(System.Management.ManagementNamedValueCollection context, System.TimeSpan timeout, bool useAmendedQualifiers, System.Management.PutType putType) { }
        public System.Management.PutType Type { [System.MonoTODOAttribute]get { throw null; } [System.MonoTODOAttribute]set { } }
        public bool UseAmendedQualifiers { [System.MonoTODOAttribute]get { throw null; } [System.MonoTODOAttribute]set { } }
        [System.MonoTODOAttribute]
        public override object Clone() { throw null; }
    }
    public enum PutType
    {
        CreateOnly = 2,
        None = 0,
        UpdateOnly = 1,
        UpdateOrCreate = 3,
    }
    public partial class QualifierData
    {
        internal QualifierData() { }
        public bool IsAmended { [System.MonoTODOAttribute]get { throw null; } [System.MonoTODOAttribute]set { } }
        public bool IsLocal { [System.MonoTODOAttribute]get { throw null; } }
        public bool IsOverridable { [System.MonoTODOAttribute]get { throw null; } [System.MonoTODOAttribute]set { } }
        public string Name { [System.MonoTODOAttribute]get { throw null; } }
        public bool PropagatesToInstance { [System.MonoTODOAttribute]get { throw null; } [System.MonoTODOAttribute]set { } }
        public bool PropagatesToSubclass { [System.MonoTODOAttribute]get { throw null; } [System.MonoTODOAttribute]set { } }
        public object Value { [System.MonoTODOAttribute]get { throw null; } [System.MonoTODOAttribute]set { } }
    }
    public partial class QualifierDataCollection : System.Collections.ICollection, System.Collections.IEnumerable
    {
        internal QualifierDataCollection() { }
        public int Count { [System.MonoTODOAttribute]get { throw null; } }
        public bool IsSynchronized { [System.MonoTODOAttribute]get { throw null; } }
        public virtual System.Management.QualifierData this[string qualifierName] { [System.MonoTODOAttribute]get { throw null; } }
        public object SyncRoot { [System.MonoTODOAttribute]get { throw null; } }
        [System.MonoTODOAttribute]
        public virtual void Add(string qualifierName, object qualifierValue) { }
        [System.MonoTODOAttribute]
        public virtual void Add(string qualifierName, object qualifierValue, bool isAmended, bool propagatesToInstance, bool propagatesToSubclass, bool isOverridable) { }
        [System.MonoTODOAttribute]
        public void CopyTo(System.Array array, int index) { }
        [System.MonoTODOAttribute]
        public void CopyTo(System.Management.QualifierData[] qualifierArray, int index) { }
        [System.MonoTODOAttribute]
        public System.Management.QualifierDataCollection.QualifierDataEnumerator GetEnumerator() { throw null; }
        [System.MonoTODOAttribute]
        public virtual void Remove(string qualifierName) { }
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { throw null; }
        public partial class QualifierDataEnumerator : System.Collections.IEnumerator
        {
            internal QualifierDataEnumerator() { }
            public System.Management.QualifierData Current { [System.MonoTODOAttribute]get { throw null; } }
            object System.Collections.IEnumerator.Current { [System.MonoTODOAttribute]get { throw null; } }
            [System.MonoTODOAttribute]
            public bool MoveNext() { throw null; }
            [System.MonoTODOAttribute]
            public void Reset() { }
        }
    }
    public partial class RelatedObjectQuery : System.Management.WqlObjectQuery
    {
        [System.MonoTODOAttribute]
        public RelatedObjectQuery() { }
        [System.MonoTODOAttribute]
        public RelatedObjectQuery(bool isSchemaQuery, string sourceObject, string relatedClass, string relationshipClass, string relatedQualifier, string relationshipQualifier, string relatedRole, string thisRole) { }
        [System.MonoTODOAttribute]
        public RelatedObjectQuery(string queryOrSourceObject) { }
        [System.MonoTODOAttribute]
        public RelatedObjectQuery(string sourceObject, string relatedClass) { }
        [System.MonoTODOAttribute]
        public RelatedObjectQuery(string sourceObject, string relatedClass, string relationshipClass, string relatedQualifier, string relationshipQualifier, string relatedRole, string thisRole, bool classDefinitionsOnly) { }
        [System.MonoTODOAttribute]
        public bool ClassDefinitionsOnly { get { throw null; } set { } }
        [System.MonoTODOAttribute]
        public bool IsSchemaQuery { get { throw null; } set { } }
        [System.MonoTODOAttribute]
        public string RelatedClass { get { throw null; } set { } }
        [System.MonoTODOAttribute]
        public string RelatedQualifier { get { throw null; } set { } }
        [System.MonoTODOAttribute]
        public string RelatedRole { get { throw null; } set { } }
        [System.MonoTODOAttribute]
        public string RelationshipClass { get { throw null; } set { } }
        [System.MonoTODOAttribute]
        public string RelationshipQualifier { get { throw null; } set { } }
        [System.MonoTODOAttribute]
        public string SourceObject { get { throw null; } set { } }
        [System.MonoTODOAttribute]
        public string ThisRole { get { throw null; } set { } }
        [System.MonoTODOAttribute]
        protected internal void BuildQuery() { }
        [System.MonoTODOAttribute]
        public override object Clone() { throw null; }
        [System.MonoTODOAttribute]
        protected internal override void ParseQuery(string query) { }
    }
    public partial class RelationshipQuery : System.Management.WqlObjectQuery
    {
        [System.MonoTODOAttribute]
        public RelationshipQuery() { }
        [System.MonoTODOAttribute]
        public RelationshipQuery(bool isSchemaQuery, string sourceObject, string relationshipClass, string relationshipQualifier, string thisRole) { }
        [System.MonoTODOAttribute]
        public RelationshipQuery(string queryOrSourceObject) { }
        [System.MonoTODOAttribute]
        public RelationshipQuery(string sourceObject, string relationshipClass) { }
        [System.MonoTODOAttribute]
        public RelationshipQuery(string sourceObject, string relationshipClass, string relationshipQualifier, string thisRole, bool classDefinitionsOnly) { }
        [System.MonoTODOAttribute]
        public bool ClassDefinitionsOnly { get { throw null; } set { } }
        [System.MonoTODOAttribute]
        public bool IsSchemaQuery { get { throw null; } set { } }
        [System.MonoTODOAttribute]
        public string RelationshipClass { get { throw null; } set { } }
        [System.MonoTODOAttribute]
        public string RelationshipQualifier { get { throw null; } set { } }
        [System.MonoTODOAttribute]
        public string SourceObject { get { throw null; } set { } }
        [System.MonoTODOAttribute]
        public string ThisRole { get { throw null; } set { } }
        [System.MonoTODOAttribute]
        protected internal void BuildQuery() { }
        [System.MonoTODOAttribute]
        public override object Clone() { throw null; }
        [System.MonoTODOAttribute]
        protected internal override void ParseQuery(string query) { }
    }
    public partial class SelectQuery : System.Management.WqlObjectQuery
    {
        [System.MonoTODOAttribute]
        public SelectQuery() { }
        [System.MonoTODOAttribute]
        public SelectQuery(bool isSchemaQuery, string condition) { }
        [System.MonoTODOAttribute]
        public SelectQuery(string queryOrClassName) { }
        [System.MonoTODOAttribute]
        public SelectQuery(string className, string condition) { }
        [System.MonoTODOAttribute]
        public SelectQuery(string className, string condition, string[] selectedProperties) { }
        [System.MonoTODOAttribute]
        public string ClassName { get { throw null; } set { } }
        [System.MonoTODOAttribute]
        public string Condition { get { throw null; } set { } }
        [System.MonoTODOAttribute]
        public bool IsSchemaQuery { get { throw null; } set { } }
        [System.MonoTODOAttribute]
        public override string QueryString { get { throw null; } set { } }
        [System.MonoTODOAttribute]
        public System.Collections.Specialized.StringCollection SelectedProperties { get { throw null; } set { } }
        [System.MonoTODOAttribute]
        protected internal void BuildQuery() { }
        [System.MonoTODOAttribute]
        public override object Clone() { throw null; }
        [System.MonoTODOAttribute]
        protected internal override void ParseQuery(string query) { }
    }
    public partial class StoppedEventArgs : System.Management.ManagementEventArgs
    {
        internal StoppedEventArgs() { }
        public System.Management.ManagementStatus Status { get { throw null; } }
    }
    public delegate void StoppedEventHandler(object sender, System.Management.StoppedEventArgs e);
    public enum TextFormat
    {
        CimDtd20 = 1,
        Mof = 0,
        WmiDtd20 = 2,
    }
    public partial class WqlEventQuery : System.Management.EventQuery
    {
        [System.MonoTODOAttribute]
        public WqlEventQuery() { }
        [System.MonoTODOAttribute]
        public WqlEventQuery(string queryOrEventClassName) { }
        [System.MonoTODOAttribute]
        public WqlEventQuery(string eventClassName, string condition) { }
        [System.MonoTODOAttribute]
        public WqlEventQuery(string eventClassName, string condition, System.TimeSpan groupWithinInterval) { }
        [System.MonoTODOAttribute]
        public WqlEventQuery(string eventClassName, string condition, System.TimeSpan groupWithinInterval, string[] groupByPropertyList) { }
        [System.MonoTODOAttribute]
        public WqlEventQuery(string eventClassName, System.TimeSpan withinInterval) { }
        [System.MonoTODOAttribute]
        public WqlEventQuery(string eventClassName, System.TimeSpan withinInterval, string condition) { }
        [System.MonoTODOAttribute]
        public WqlEventQuery(string eventClassName, System.TimeSpan withinInterval, string condition, System.TimeSpan groupWithinInterval, string[] groupByPropertyList, string havingCondition) { }
        [System.MonoTODOAttribute]
        public string Condition { get { throw null; } set { } }
        [System.MonoTODOAttribute]
        public string EventClassName { get { throw null; } set { } }
        [System.MonoTODOAttribute]
        public System.Collections.Specialized.StringCollection GroupByPropertyList { get { throw null; } set { } }
        [System.MonoTODOAttribute]
        public System.TimeSpan GroupWithinInterval { get { throw null; } set { } }
        [System.MonoTODOAttribute]
        public string HavingCondition { get { throw null; } set { } }
        [System.MonoTODOAttribute]
        public override string QueryLanguage { get { throw null; } }
        [System.MonoTODOAttribute]
        public override string QueryString { get { throw null; } set { } }
        [System.MonoTODOAttribute]
        public System.TimeSpan WithinInterval { get { throw null; } set { } }
        [System.MonoTODOAttribute]
        protected internal void BuildQuery() { }
        [System.MonoTODOAttribute]
        public override object Clone() { throw null; }
        [System.MonoTODOAttribute]
        protected internal override void ParseQuery(string query) { }
    }
    public partial class WqlObjectQuery : System.Management.ObjectQuery
    {
        [System.MonoTODOAttribute]
        public WqlObjectQuery() { }
        [System.MonoTODOAttribute]
        public WqlObjectQuery(string query) { }
        [System.MonoTODOAttribute]
        public override string QueryLanguage { get { throw null; } }
        [System.MonoTODOAttribute]
        public override object Clone() { throw null; }
    }
}
namespace System.Management.Instrumentation
{
    [System.Management.Instrumentation.InstrumentationClassAttribute((System.Management.Instrumentation.InstrumentationType)(1))]
    public abstract partial class BaseEvent : System.Management.Instrumentation.IEvent
    {
        [System.MonoTODOAttribute]
        protected BaseEvent() { }
        [System.MonoTODOAttribute]
        public void Fire() { }
    }
    public partial class DefaultManagementProjectInstaller : System.Configuration.Install.Installer
    {
        [System.MonoTODOAttribute]
        public DefaultManagementProjectInstaller() { }
    }
    public partial interface IEvent
    {
        void Fire();
    }
    [System.AttributeUsageAttribute((System.AttributeTargets)(448))]
    public partial class IgnoreMemberAttribute : System.Attribute
    {
        [System.MonoTODOAttribute]
        public IgnoreMemberAttribute() { }
    }
    public partial interface IInstance
    {
        bool Published { get; set; }
    }
    [System.Management.Instrumentation.InstrumentationClassAttribute((System.Management.Instrumentation.InstrumentationType)(0))]
    public abstract partial class Instance : System.Management.Instrumentation.IInstance
    {
        [System.MonoTODOAttribute]
        protected Instance() { }
        [System.Management.Instrumentation.IgnoreMemberAttribute]
        public bool Published { get { throw null; } set { } }
    }
    public partial class Instrumentation
    {
        [System.MonoTODOAttribute]
        public Instrumentation() { }
        [System.MonoTODOAttribute]
        public static void Fire(object eventData) { }
        [System.MonoTODOAttribute]
        public static bool IsAssemblyRegistered(System.Reflection.Assembly assemblyToRegister) { throw null; }
        [System.MonoTODOAttribute]
        public static void Publish(object instanceData) { }
        [System.MonoTODOAttribute]
        public static void RegisterAssembly(System.Reflection.Assembly assemblyToRegister) { }
        [System.MonoTODOAttribute]
        public static void Revoke(object instanceData) { }
        [System.MonoTODOAttribute]
        public static void SetBatchSize(System.Type instrumentationClass, int batchSize) { }
    }
    [System.AttributeUsageAttribute((System.AttributeTargets)(12))]
    public partial class InstrumentationClassAttribute : System.Attribute
    {
        public InstrumentationClassAttribute(System.Management.Instrumentation.InstrumentationType instrumentationType) { }
        public InstrumentationClassAttribute(System.Management.Instrumentation.InstrumentationType instrumentationType, string managedBaseClassName) { }
        public System.Management.Instrumentation.InstrumentationType InstrumentationType { get { throw null; } }
        public string ManagedBaseClassName { get { throw null; } }
    }
    public enum InstrumentationType
    {
        Abstract = 2,
        Event = 1,
        Instance = 0,
    }
    [System.AttributeUsageAttribute((System.AttributeTargets)(1))]
    public partial class InstrumentedAttribute : System.Attribute
    {
        [System.MonoTODOAttribute]
        public InstrumentedAttribute() { }
        [System.MonoTODOAttribute]
        public InstrumentedAttribute(string namespaceName) { }
        [System.MonoTODOAttribute]
        public InstrumentedAttribute(string namespaceName, string securityDescriptor) { }
        public string NamespaceName { [System.MonoTODOAttribute]get { throw null; } }
        public string SecurityDescriptor { [System.MonoTODOAttribute]get { throw null; } }
    }
    [System.AttributeUsageAttribute((System.AttributeTargets)(460))]
    public partial class ManagedNameAttribute : System.Attribute
    {
        public ManagedNameAttribute(string name) { }
        public string Name { get { throw null; } }
    }
    public partial class ManagementInstaller : System.Configuration.Install.Installer
    {
        [System.MonoTODOAttribute]
        public ManagementInstaller() { }
        [System.MonoTODOAttribute]
        public override string HelpText { get { throw null; } }
        [System.MonoTODOAttribute]
        public override void Commit(System.Collections.IDictionary savedState) { }
        [System.MonoTODOAttribute]
        public override void Install(System.Collections.IDictionary savedState) { }
        [System.MonoTODOAttribute]
        public override void Rollback(System.Collections.IDictionary savedState) { }
        [System.MonoTODOAttribute]
        public override void Uninstall(System.Collections.IDictionary savedState) { }
    }
}
