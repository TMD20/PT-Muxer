// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

[assembly:System.Reflection.AssemblyVersionAttribute("4.0.0.0")]
[assembly:System.CLSCompliantAttribute(true)]
[assembly:System.EnterpriseServices.ApplicationIDAttribute("1e246775-2281-484f-8ad4-044c15b86eb7")]
[assembly:System.EnterpriseServices.ApplicationNameAttribute(".NET Utilities")]
[assembly:System.Reflection.AssemblyCompanyAttribute("Mono development team")]
[assembly:System.Reflection.AssemblyCopyrightAttribute("(c) Various Mono authors")]
[assembly:System.Reflection.AssemblyDefaultAliasAttribute("System.EnterpriseServices.dll")]
[assembly:System.Reflection.AssemblyDescriptionAttribute("System.EnterpriseServices.dll")]
[assembly:System.Reflection.AssemblyFileVersionAttribute("4.0.30319.1")]
[assembly:System.Reflection.AssemblyInformationalVersionAttribute("4.0.30319.1")]
[assembly:System.Reflection.AssemblyProductAttribute("Mono Common Language Infrastructure")]
[assembly:System.Reflection.AssemblyTitleAttribute("System.EnterpriseServices.dll")]
[assembly:System.Resources.NeutralResourcesLanguageAttribute("en-US")]
[assembly:System.Resources.SatelliteContractVersionAttribute("4.0.0.0")]
[assembly:System.Runtime.CompilerServices.CompilationRelaxationsAttribute((System.Runtime.CompilerServices.CompilationRelaxations)(8))]
[assembly:System.Runtime.CompilerServices.ReferenceAssemblyAttribute]
[assembly:System.Runtime.CompilerServices.RuntimeCompatibilityAttribute(WrapNonExceptionThrows=true)]
[assembly:System.Runtime.InteropServices.ComCompatibleVersionAttribute(1, 0, 3300, 0)]
[assembly:System.Runtime.InteropServices.ComVisibleAttribute(true)]
[assembly:System.Runtime.InteropServices.GuidAttribute("4fb2d46f-efc8-4643-bcd0-6e5bfa6a174c")]
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
namespace System.EnterpriseServices
{
    [System.SerializableAttribute]
    public enum AccessChecksLevelOption
    {
        Application = 0,
        ApplicationComponent = 1,
    }
    [System.SerializableAttribute]
    public enum ActivationOption
    {
        Library = 0,
        Server = 1,
    }
    [System.Runtime.InteropServices.ComVisibleAttribute(false)]
    public sealed partial class Activity
    {
        [System.MonoTODOAttribute]
        public Activity(System.EnterpriseServices.ServiceConfig cfg) { }
        [System.MonoTODOAttribute]
        public void AsynchronousCall(System.EnterpriseServices.IServiceCall serviceCall) { }
        [System.MonoTODOAttribute]
        public void BindToCurrentThread() { }
        [System.MonoTODOAttribute]
        public void SynchronousCall(System.EnterpriseServices.IServiceCall serviceCall) { }
        [System.MonoTODOAttribute]
        public void UnbindFromThread() { }
    }
    [System.AttributeUsageAttribute((System.AttributeTargets)(1))]
    [System.Runtime.InteropServices.ComVisibleAttribute(false)]
    public sealed partial class ApplicationAccessControlAttribute : System.Attribute
    {
        public ApplicationAccessControlAttribute() { }
        public ApplicationAccessControlAttribute(bool val) { }
        public System.EnterpriseServices.AccessChecksLevelOption AccessChecksLevel { get { throw null; } set { } }
        public System.EnterpriseServices.AuthenticationOption Authentication { get { throw null; } set { } }
        public System.EnterpriseServices.ImpersonationLevelOption ImpersonationLevel { get { throw null; } set { } }
        public bool Value { get { throw null; } set { } }
    }
    [System.AttributeUsageAttribute((System.AttributeTargets)(1))]
    [System.Runtime.InteropServices.ComVisibleAttribute(false)]
    public sealed partial class ApplicationActivationAttribute : System.Attribute
    {
        public ApplicationActivationAttribute(System.EnterpriseServices.ActivationOption opt) { }
        public string SoapMailbox { get { throw null; } set { } }
        public string SoapVRoot { get { throw null; } set { } }
        public System.EnterpriseServices.ActivationOption Value { get { throw null; } }
    }
    [System.AttributeUsageAttribute((System.AttributeTargets)(1))]
    [System.Runtime.InteropServices.ComVisibleAttribute(false)]
    public sealed partial class ApplicationIDAttribute : System.Attribute
    {
        public ApplicationIDAttribute(string guid) { }
        public System.Guid Value { get { throw null; } }
    }
    [System.AttributeUsageAttribute((System.AttributeTargets)(1))]
    [System.Runtime.InteropServices.ComVisibleAttribute(false)]
    public sealed partial class ApplicationNameAttribute : System.Attribute
    {
        public ApplicationNameAttribute(string name) { }
        public string Value { get { throw null; } }
    }
    [System.AttributeUsageAttribute((System.AttributeTargets)(1))]
    [System.Runtime.InteropServices.ComVisibleAttribute(false)]
    public sealed partial class ApplicationQueuingAttribute : System.Attribute
    {
        public ApplicationQueuingAttribute() { }
        public bool Enabled { get { throw null; } set { } }
        public int MaxListenerThreads { get { throw null; } set { } }
        public bool QueueListenerEnabled { get { throw null; } set { } }
    }
    [System.SerializableAttribute]
    public enum AuthenticationOption
    {
        Call = 3,
        Connect = 2,
        Default = 0,
        Integrity = 5,
        None = 1,
        Packet = 4,
        Privacy = 6,
    }
    [System.AttributeUsageAttribute((System.AttributeTargets)(64))]
    [System.Runtime.InteropServices.ComVisibleAttribute(false)]
    public sealed partial class AutoCompleteAttribute : System.Attribute
    {
        public AutoCompleteAttribute() { }
        public AutoCompleteAttribute(bool val) { }
        public bool Value { get { throw null; } }
    }
    [System.Runtime.InteropServices.ComVisibleAttribute(false)]
    [System.SerializableAttribute]
    public enum BindingOption
    {
        BindingToPoolThread = 1,
        NoBinding = 0,
    }
    [System.Runtime.InteropServices.ComVisibleAttribute(false)]
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public partial struct BOID
    {
        [System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.ByValArray)]
        public byte[] rgb;
    }
    public sealed partial class BYOT
    {
        internal BYOT() { }
        [System.MonoTODOAttribute]
        public static object CreateWithTipTransaction(string url, System.Type t) { throw null; }
        [System.MonoTODOAttribute]
        public static object CreateWithTransaction(object transaction, System.Type t) { throw null; }
    }
    [System.AttributeUsageAttribute((System.AttributeTargets)(4))]
    [System.Runtime.InteropServices.ComVisibleAttribute(false)]
    public sealed partial class ComponentAccessControlAttribute : System.Attribute
    {
        public ComponentAccessControlAttribute() { }
        public ComponentAccessControlAttribute(bool val) { }
        public bool Value { get { throw null; } }
    }
    [System.AttributeUsageAttribute((System.AttributeTargets)(4))]
    [System.Runtime.InteropServices.ComVisibleAttribute(false)]
    public sealed partial class COMTIIntrinsicsAttribute : System.Attribute
    {
        public COMTIIntrinsicsAttribute() { }
        public COMTIIntrinsicsAttribute(bool val) { }
        public bool Value { get { throw null; } }
    }
    [System.AttributeUsageAttribute((System.AttributeTargets)(4))]
    [System.Runtime.InteropServices.ComVisibleAttribute(false)]
    public sealed partial class ConstructionEnabledAttribute : System.Attribute
    {
        public ConstructionEnabledAttribute() { }
        public ConstructionEnabledAttribute(bool val) { }
        public string Default { get { throw null; } set { } }
        public bool Enabled { get { throw null; } set { } }
    }
    public sealed partial class ContextUtil
    {
        internal ContextUtil() { }
        public static System.Guid ActivityId { [System.MonoTODOAttribute]get { throw null; } }
        public static System.Guid ApplicationId { [System.MonoTODOAttribute]get { throw null; } }
        public static System.Guid ApplicationInstanceId { [System.MonoTODOAttribute]get { throw null; } }
        public static System.Guid ContextId { [System.MonoTODOAttribute]get { throw null; } }
        public static bool DeactivateOnReturn { get { throw null; } set { } }
        public static bool IsInTransaction { [System.MonoTODOAttribute]get { throw null; } }
        public static bool IsSecurityEnabled { [System.MonoTODOAttribute]get { throw null; } }
        [System.MonoTODOAttribute]
        public static System.EnterpriseServices.TransactionVote MyTransactionVote { get { throw null; } set { } }
        public static System.Guid PartitionId { [System.MonoTODOAttribute]get { throw null; } }
        public static System.Transactions.Transaction SystemTransaction { [System.MonoTODOAttribute]get { throw null; } }
        public static object Transaction { [System.MonoTODOAttribute]get { throw null; } }
        public static System.Guid TransactionId { [System.MonoTODOAttribute]get { throw null; } }
        [System.MonoTODOAttribute]
        public static void DisableCommit() { }
        [System.MonoTODOAttribute]
        public static void EnableCommit() { }
        [System.MonoTODOAttribute]
        public static object GetNamedProperty(string name) { throw null; }
        [System.MonoTODOAttribute]
        public static bool IsCallerInRole(string role) { throw null; }
        [System.MonoTODOAttribute]
        public static bool IsDefaultContext() { throw null; }
        [System.MonoTODOAttribute]
        public static void SetAbort() { }
        [System.MonoTODOAttribute]
        public static void SetComplete() { }
        [System.MonoTODOAttribute]
        public static void SetNamedProperty(string name, object property) { }
    }
    [System.AttributeUsageAttribute((System.AttributeTargets)(1093))]
    [System.Runtime.InteropServices.ComVisibleAttribute(false)]
    public sealed partial class DescriptionAttribute : System.Attribute
    {
        public DescriptionAttribute(string desc) { }
    }
    [System.AttributeUsageAttribute((System.AttributeTargets)(4))]
    [System.Runtime.InteropServices.ComVisibleAttribute(false)]
    public sealed partial class EventClassAttribute : System.Attribute
    {
        public EventClassAttribute() { }
        public bool AllowInprocSubscribers { get { throw null; } set { } }
        public bool FireInParallel { get { throw null; } set { } }
        public string PublisherFilter { get { throw null; } set { } }
    }
    [System.AttributeUsageAttribute((System.AttributeTargets)(4))]
    [System.Runtime.InteropServices.ComVisibleAttribute(false)]
    public sealed partial class EventTrackingEnabledAttribute : System.Attribute
    {
        public EventTrackingEnabledAttribute() { }
        public EventTrackingEnabledAttribute(bool val) { }
        public bool Value { get { throw null; } }
    }
    [System.AttributeUsageAttribute((System.AttributeTargets)(4))]
    [System.Runtime.InteropServices.ComVisibleAttribute(false)]
    public sealed partial class ExceptionClassAttribute : System.Attribute
    {
        public ExceptionClassAttribute(string name) { }
        public string Value { get { throw null; } }
    }
    [System.Runtime.InteropServices.GuidAttribute("FE6777FB-A674-4177-8F32-6D707E113484")]
    [System.Runtime.InteropServices.InterfaceTypeAttribute((System.Runtime.InteropServices.ComInterfaceType)(1))]
    public partial interface IAsyncErrorNotify
    {
        void OnError(int hresult);
    }
    [System.AttributeUsageAttribute((System.AttributeTargets)(4))]
    [System.Runtime.InteropServices.ComVisibleAttribute(false)]
    public sealed partial class IISIntrinsicsAttribute : System.Attribute
    {
        public IISIntrinsicsAttribute() { }
        public IISIntrinsicsAttribute(bool val) { }
        public bool Value { get { throw null; } }
    }
    [System.SerializableAttribute]
    public enum ImpersonationLevelOption
    {
        Anonymous = 1,
        Default = 0,
        Delegate = 4,
        Identify = 2,
        Impersonate = 3,
    }
    [System.Runtime.InteropServices.ComVisibleAttribute(false)]
    [System.SerializableAttribute]
    public enum InheritanceOption
    {
        Ignore = 1,
        Inherit = 0,
    }
    [System.FlagsAttribute]
    [System.SerializableAttribute]
    public enum InstallationFlags
    {
        Configure = 1024,
        ConfigureComponentsOnly = 16,
        CreateTargetApplication = 2,
        Default = 0,
        ExpectExistingTypeLib = 1,
        FindOrCreateTargetApplication = 4,
        Install = 512,
        ReconfigureExistingApplication = 8,
        Register = 256,
        ReportWarningsToConsole = 32,
    }
    [System.AttributeUsageAttribute((System.AttributeTargets)(1028), AllowMultiple=true)]
    [System.Runtime.InteropServices.ComVisibleAttribute(false)]
    public sealed partial class InterfaceQueuingAttribute : System.Attribute
    {
        public InterfaceQueuingAttribute() { }
        public InterfaceQueuingAttribute(bool enabled) { }
        public bool Enabled { get { throw null; } set { } }
        public string Interface { get { throw null; } set { } }
    }
    [System.Runtime.InteropServices.GuidAttribute("51372AFD-CAE7-11CF-BE81-00AA00A2FA25")]
    [System.Runtime.InteropServices.InterfaceTypeAttribute((System.Runtime.InteropServices.ComInterfaceType)(1))]
    public partial interface IPlaybackControl
    {
        void FinalClientRetry();
        void FinalServerRetry();
    }
    [System.Runtime.InteropServices.GuidAttribute("72380d55-8d2b-43a3-8513-2b6ef31434e9")]
    [System.Runtime.InteropServices.InterfaceTypeAttribute((System.Runtime.InteropServices.ComInterfaceType)(1))]
    public partial interface IProcessInitControl
    {
        void ResetInitializerTimeout(int dwSecondsRemaining);
    }
    [System.Runtime.InteropServices.GuidAttribute("1113f52d-dc7f-4943-aed6-88d04027e32a")]
    [System.Runtime.InteropServices.InterfaceTypeAttribute((System.Runtime.InteropServices.ComInterfaceType)(1))]
    public partial interface IProcessInitializer
    {
        void Shutdown();
        void Startup([System.Runtime.InteropServices.In][System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.IUnknown)]object punkProcessControl);
    }
    [System.Runtime.InteropServices.GuidAttribute("55e3ea25-55cb-4650-8887-18e8d30bb4bc")]
    [System.Runtime.InteropServices.InterfaceTypeAttribute((System.Runtime.InteropServices.ComInterfaceType)(1))]
    public partial interface IRegistrationHelper
    {
        void InstallAssembly([System.Runtime.InteropServices.In][System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.BStr)]string assembly, [System.Runtime.InteropServices.In][System.Runtime.InteropServices.Out][System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.BStr)]ref string application, [System.Runtime.InteropServices.In][System.Runtime.InteropServices.Out][System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.BStr)]ref string tlb, [System.Runtime.InteropServices.In]System.EnterpriseServices.InstallationFlags installFlags);
        void UninstallAssembly([System.Runtime.InteropServices.In][System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.BStr)]string assembly, [System.Runtime.InteropServices.In][System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.BStr)]string application);
    }
    [System.Runtime.InteropServices.GuidAttribute("6619a740-8154-43be-a186-0319578e02db")]
    public partial interface IRemoteDispatch
    {
        [System.EnterpriseServices.AutoCompleteAttribute]
        string RemoteDispatchAutoDone(string s);
        [System.EnterpriseServices.AutoCompleteAttribute(false)]
        string RemoteDispatchNotAutoDone(string s);
    }
    [System.Runtime.InteropServices.GuidAttribute("BD3E2E12-42DD-40f4-A09A-95A50C58304B")]
    [System.Runtime.InteropServices.InterfaceTypeAttribute((System.Runtime.InteropServices.ComInterfaceType)(1))]
    public partial interface IServiceCall
    {
        void OnCall();
    }
    [System.Runtime.InteropServices.GuidAttribute("8165B19E-8D3A-4d0b-80C8-97DE310DB583")]
    [System.Runtime.InteropServices.InterfaceTypeAttribute((System.Runtime.InteropServices.ComInterfaceType)(1))]
    public partial interface IServicedComponentInfo
    {
        void GetComponentInfo(ref int infoMask, out string[] infoArray);
    }
    [System.Runtime.InteropServices.GuidAttribute("0FB15084-AF41-11CE-BD2B-204C4F4F5020")]
    [System.Runtime.InteropServices.InterfaceTypeAttribute((System.Runtime.InteropServices.ComInterfaceType)(1))]
    public partial interface ITransaction
    {
        void Abort(ref System.EnterpriseServices.BOID pboidReason, int fRetaining, int fAsync);
        void Commit(int fRetaining, int grfTC, int grfRM);
        void GetTransactionInfo(out System.EnterpriseServices.XACTTRANSINFO pinfo);
    }
    [System.AttributeUsageAttribute((System.AttributeTargets)(4))]
    [System.Runtime.InteropServices.ComVisibleAttribute(false)]
    public sealed partial class JustInTimeActivationAttribute : System.Attribute
    {
        public JustInTimeActivationAttribute() { }
        public JustInTimeActivationAttribute(bool val) { }
        public bool Value { get { throw null; } }
    }
    [System.AttributeUsageAttribute((System.AttributeTargets)(4))]
    [System.Runtime.InteropServices.ComVisibleAttribute(false)]
    public sealed partial class LoadBalancingSupportedAttribute : System.Attribute
    {
        public LoadBalancingSupportedAttribute() { }
        public LoadBalancingSupportedAttribute(bool val) { }
        public bool Value { get { throw null; } }
    }
    [System.AttributeUsageAttribute((System.AttributeTargets)(4))]
    [System.Runtime.InteropServices.ComVisibleAttribute(false)]
    public sealed partial class MustRunInClientContextAttribute : System.Attribute
    {
        public MustRunInClientContextAttribute() { }
        public MustRunInClientContextAttribute(bool val) { }
        public bool Value { get { throw null; } }
    }
    [System.AttributeUsageAttribute((System.AttributeTargets)(4))]
    [System.Runtime.InteropServices.ComVisibleAttribute(false)]
    public sealed partial class ObjectPoolingAttribute : System.Attribute
    {
        public ObjectPoolingAttribute() { }
        public ObjectPoolingAttribute(bool enable) { }
        public ObjectPoolingAttribute(bool enable, int minPoolSize, int maxPoolSize) { }
        public ObjectPoolingAttribute(int minPoolSize, int maxPoolSize) { }
        public int CreationTimeout { get { throw null; } set { } }
        public bool Enabled { get { throw null; } set { } }
        public int MaxPoolSize { get { throw null; } set { } }
        public int MinPoolSize { get { throw null; } set { } }
        [System.MonoTODOAttribute]
        public bool AfterSaveChanges(System.Collections.Hashtable info) { throw null; }
        [System.MonoTODOAttribute]
        public bool Apply(System.Collections.Hashtable info) { throw null; }
        [System.MonoTODOAttribute]
        public bool IsValidTarget(string s) { throw null; }
    }
    [System.Runtime.InteropServices.ComVisibleAttribute(false)]
    [System.SerializableAttribute]
    public enum PartitionOption
    {
        Ignore = 0,
        Inherit = 1,
        New = 2,
    }
    [System.AttributeUsageAttribute((System.AttributeTargets)(4))]
    [System.Runtime.InteropServices.ComVisibleAttribute(false)]
    public sealed partial class PrivateComponentAttribute : System.Attribute
    {
        public PrivateComponentAttribute() { }
    }
    [System.Runtime.InteropServices.ComVisibleAttribute(false)]
    [System.SerializableAttribute]
    public enum PropertyLockMode
    {
        Method = 1,
        SetGet = 0,
    }
    [System.Runtime.InteropServices.ComVisibleAttribute(false)]
    [System.SerializableAttribute]
    public enum PropertyReleaseMode
    {
        Process = 1,
        Standard = 0,
    }
    [System.Runtime.InteropServices.GuidAttribute("36dcda30-dc3b-4d93-be42-90b2d74c64e7")]
    [System.SerializableAttribute]
    public partial class RegistrationConfig
    {
        [System.MonoTODOAttribute]
        public RegistrationConfig() { }
        [System.MonoTODOAttribute]
        public string Application { get { throw null; } set { } }
        [System.MonoTODOAttribute]
        public string ApplicationRootDirectory { get { throw null; } set { } }
        [System.MonoTODOAttribute]
        public string AssemblyFile { get { throw null; } set { } }
        [System.MonoTODOAttribute]
        public System.EnterpriseServices.InstallationFlags InstallationFlags { get { throw null; } set { } }
        [System.MonoTODOAttribute]
        public string Partition { get { throw null; } set { } }
        [System.MonoTODOAttribute]
        public string TypeLibrary { get { throw null; } set { } }
    }
    [System.SerializableAttribute]
    public sealed partial class RegistrationErrorInfo
    {
        internal RegistrationErrorInfo() { }
        public int ErrorCode { get { throw null; } }
        public string ErrorString { get { throw null; } }
        public string MajorRef { get { throw null; } }
        public string MinorRef { get { throw null; } }
        public string Name { get { throw null; } }
    }
    [System.SerializableAttribute]
    public sealed partial class RegistrationException : System.SystemException
    {
        public RegistrationException() { }
        [System.MonoTODOAttribute]
        public RegistrationException(string msg) { }
        public RegistrationException(string msg, System.Exception innerException) { }
        public System.EnterpriseServices.RegistrationErrorInfo[] ErrorInfo { get { throw null; } }
        [System.MonoTODOAttribute]
        public override void GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext ctx) { }
    }
    [System.Runtime.InteropServices.GuidAttribute("89a86e7b-c229-4008-9baa-2f5c8411d7e0")]
    public sealed partial class RegistrationHelper : System.MarshalByRefObject, System.EnterpriseServices.IRegistrationHelper
    {
        public RegistrationHelper() { }
        [System.MonoTODOAttribute]
        public void InstallAssembly(string assembly, ref string application, string partition, ref string tlb, System.EnterpriseServices.InstallationFlags installFlags) { }
        public void InstallAssembly(string assembly, ref string application, ref string tlb, System.EnterpriseServices.InstallationFlags installFlags) { }
        [System.MonoTODOAttribute]
        public void InstallAssemblyFromConfig([System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.IUnknown)]ref System.EnterpriseServices.RegistrationConfig regConfig) { }
        public void UninstallAssembly(string assembly, string application) { }
        [System.MonoTODOAttribute]
        public void UninstallAssembly(string assembly, string application, string partition) { }
        [System.MonoTODOAttribute]
        public void UninstallAssemblyFromConfig([System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.IUnknown)]ref System.EnterpriseServices.RegistrationConfig regConfig) { }
    }
    [System.EnterpriseServices.TransactionAttribute((System.EnterpriseServices.TransactionOption)(4))]
    [System.Runtime.InteropServices.GuidAttribute("C89AC250-E18A-4FC7-ABD5-B8897B6A78A5")]
    public sealed partial class RegistrationHelperTx : System.EnterpriseServices.ServicedComponent
    {
        [System.MonoTODOAttribute]
        public RegistrationHelperTx() { }
        [System.MonoTODOAttribute]
        protected internal override void Activate() { }
        [System.MonoTODOAttribute]
        protected internal override void Deactivate() { }
        [System.MonoTODOAttribute]
        public void InstallAssembly(string assembly, ref string application, string partition, ref string tlb, System.EnterpriseServices.InstallationFlags installFlags, object sync) { }
        public void InstallAssembly(string assembly, ref string application, ref string tlb, System.EnterpriseServices.InstallationFlags installFlags, object sync) { }
        [System.MonoTODOAttribute]
        public void InstallAssemblyFromConfig([System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.IUnknown)]ref System.EnterpriseServices.RegistrationConfig regConfig, object sync) { }
        [System.MonoTODOAttribute]
        public bool IsInTransaction() { throw null; }
        public void UninstallAssembly(string assembly, string application, object sync) { }
        [System.MonoTODOAttribute]
        public void UninstallAssembly(string assembly, string application, string partition, object sync) { }
        [System.MonoTODOAttribute]
        public void UninstallAssemblyFromConfig([System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.IUnknown)]ref System.EnterpriseServices.RegistrationConfig regConfig, object sync) { }
    }
    public sealed partial class ResourcePool
    {
        [System.MonoTODOAttribute]
        public ResourcePool(System.EnterpriseServices.ResourcePool.TransactionEndDelegate cb) { }
        [System.MonoTODOAttribute]
        public object GetResource() { throw null; }
        [System.MonoTODOAttribute]
        public bool PutResource(object resource) { throw null; }
        public delegate void TransactionEndDelegate(object resource);
    }
    [System.AttributeUsageAttribute((System.AttributeTargets)(68))]
    [System.Runtime.InteropServices.ComVisibleAttribute(false)]
    public sealed partial class SecureMethodAttribute : System.Attribute
    {
        public SecureMethodAttribute() { }
    }
    public sealed partial class SecurityCallContext
    {
        internal SecurityCallContext() { }
        public System.EnterpriseServices.SecurityCallers Callers { [System.MonoTODOAttribute]get { throw null; } }
        public static System.EnterpriseServices.SecurityCallContext CurrentCall { [System.MonoTODOAttribute]get { throw null; } }
        public System.EnterpriseServices.SecurityIdentity DirectCaller { [System.MonoTODOAttribute]get { throw null; } }
        public bool IsSecurityEnabled { [System.MonoTODOAttribute]get { throw null; } }
        public int MinAuthenticationLevel { [System.MonoTODOAttribute]get { throw null; } }
        public int NumCallers { [System.MonoTODOAttribute]get { throw null; } }
        public System.EnterpriseServices.SecurityIdentity OriginalCaller { [System.MonoTODOAttribute]get { throw null; } }
        [System.MonoTODOAttribute]
        public bool IsCallerInRole(string role) { throw null; }
        [System.MonoTODOAttribute]
        public bool IsUserInRole(string user, string role) { throw null; }
    }
    public sealed partial class SecurityCallers : System.Collections.IEnumerable
    {
        internal SecurityCallers() { }
        public int Count { [System.MonoTODOAttribute]get { throw null; } }
        public System.EnterpriseServices.SecurityIdentity this[int idx] { [System.MonoTODOAttribute]get { throw null; } }
        [System.MonoTODOAttribute]
        public System.Collections.IEnumerator GetEnumerator() { throw null; }
    }
    public sealed partial class SecurityIdentity
    {
        internal SecurityIdentity() { }
        public string AccountName { [System.MonoTODOAttribute]get { throw null; } }
        public System.EnterpriseServices.AuthenticationOption AuthenticationLevel { [System.MonoTODOAttribute]get { throw null; } }
        public int AuthenticationService { [System.MonoTODOAttribute]get { throw null; } }
        public System.EnterpriseServices.ImpersonationLevelOption ImpersonationLevel { [System.MonoTODOAttribute]get { throw null; } }
    }
    [System.AttributeUsageAttribute((System.AttributeTargets)(1093), AllowMultiple=true)]
    [System.Runtime.InteropServices.ComVisibleAttribute(false)]
    public sealed partial class SecurityRoleAttribute : System.Attribute
    {
        public SecurityRoleAttribute(string role) { }
        public SecurityRoleAttribute(string role, bool everyone) { }
        public string Description { get { throw null; } set { } }
        public string Role { get { throw null; } set { } }
        public bool SetEveryoneAccess { get { throw null; } set { } }
    }
    [System.MonoTODOAttribute]
    [System.Runtime.InteropServices.ComVisibleAttribute(false)]
    public sealed partial class ServiceConfig
    {
        [System.MonoTODOAttribute]
        public ServiceConfig() { }
        [System.MonoTODOAttribute]
        public System.EnterpriseServices.BindingOption Binding { get { throw null; } set { } }
        [System.MonoTODOAttribute]
        public System.Transactions.Transaction BringYourOwnSystemTransaction { get { throw null; } set { } }
        [System.MonoTODOAttribute]
        public System.EnterpriseServices.ITransaction BringYourOwnTransaction { get { throw null; } set { } }
        [System.MonoTODOAttribute]
        public bool COMTIIntrinsicsEnabled { get { throw null; } set { } }
        [System.MonoTODOAttribute]
        public bool IISIntrinsicsEnabled { get { throw null; } set { } }
        [System.MonoTODOAttribute]
        public System.EnterpriseServices.InheritanceOption Inheritance { get { throw null; } set { } }
        [System.MonoTODOAttribute]
        public System.EnterpriseServices.TransactionIsolationLevel IsolationLevel { get { throw null; } set { } }
        [System.MonoTODOAttribute]
        public System.Guid PartitionId { get { throw null; } set { } }
        [System.MonoTODOAttribute]
        public System.EnterpriseServices.PartitionOption PartitionOption { get { throw null; } set { } }
        [System.MonoTODOAttribute]
        public string SxsDirectory { get { throw null; } set { } }
        [System.MonoTODOAttribute]
        public string SxsName { get { throw null; } set { } }
        [System.MonoTODOAttribute]
        public System.EnterpriseServices.SxsOption SxsOption { get { throw null; } set { } }
        [System.MonoTODOAttribute]
        public System.EnterpriseServices.SynchronizationOption Synchronization { get { throw null; } set { } }
        [System.MonoTODOAttribute]
        public System.EnterpriseServices.ThreadPoolOption ThreadPool { get { throw null; } set { } }
        [System.MonoTODOAttribute]
        public string TipUrl { get { throw null; } set { } }
        [System.MonoTODOAttribute]
        public string TrackingAppName { get { throw null; } set { } }
        [System.MonoTODOAttribute]
        public string TrackingComponentName { get { throw null; } set { } }
        [System.MonoTODOAttribute]
        public bool TrackingEnabled { get { throw null; } set { } }
        [System.MonoTODOAttribute]
        public System.EnterpriseServices.TransactionOption Transaction { get { throw null; } set { } }
        [System.MonoTODOAttribute]
        public string TransactionDescription { get { throw null; } set { } }
        [System.MonoTODOAttribute]
        public int TransactionTimeout { get { throw null; } set { } }
    }
    [System.SerializableAttribute]
    public abstract partial class ServicedComponent : System.ContextBoundObject, System.EnterpriseServices.IRemoteDispatch, System.EnterpriseServices.IServicedComponentInfo, System.IDisposable
    {
        public ServicedComponent() { }
        [System.MonoTODOAttribute]
        protected internal virtual void Activate() { }
        [System.MonoTODOAttribute]
        protected internal virtual bool CanBePooled() { throw null; }
        [System.MonoTODOAttribute]
        protected internal virtual void Construct(string s) { }
        [System.MonoTODOAttribute]
        protected internal virtual void Deactivate() { }
        [System.MonoTODOAttribute]
        public void Dispose() { }
        [System.MonoTODOAttribute]
        protected virtual void Dispose(bool disposing) { }
        [System.MonoTODOAttribute]
        public static void DisposeObject(System.EnterpriseServices.ServicedComponent sc) { }
        [System.MonoTODOAttribute]
        string System.EnterpriseServices.IRemoteDispatch.RemoteDispatchAutoDone(string s) { throw null; }
        [System.MonoTODOAttribute]
        string System.EnterpriseServices.IRemoteDispatch.RemoteDispatchNotAutoDone(string s) { throw null; }
        [System.MonoTODOAttribute]
        void System.EnterpriseServices.IServicedComponentInfo.GetComponentInfo(ref int infoMask, out string[] infoArray) { infoArray = default(string[]); }
    }
    [System.Runtime.InteropServices.ComVisibleAttribute(false)]
    [System.SerializableAttribute]
    public sealed partial class ServicedComponentException : System.SystemException
    {
        public ServicedComponentException() { }
        public ServicedComponentException(string message) { }
        public ServicedComponentException(string message, System.Exception innerException) { }
    }
    [System.Runtime.InteropServices.ComVisibleAttribute(false)]
    public sealed partial class ServiceDomain
    {
        internal ServiceDomain() { }
        [System.MonoTODOAttribute]
        public static void Enter(System.EnterpriseServices.ServiceConfig cfg) { }
        [System.MonoTODOAttribute]
        public static System.EnterpriseServices.TransactionStatus Leave() { throw null; }
    }
    [System.Runtime.InteropServices.ComVisibleAttribute(false)]
    public sealed partial class SharedProperty
    {
        internal SharedProperty() { }
        public object Value { get { throw null; } set { } }
    }
    [System.Runtime.InteropServices.ComVisibleAttribute(false)]
    public sealed partial class SharedPropertyGroup
    {
        internal SharedPropertyGroup() { }
        public System.EnterpriseServices.SharedProperty CreateProperty(string name, out bool fExists) { fExists = default(bool); throw null; }
        public System.EnterpriseServices.SharedProperty CreatePropertyByPosition(int position, out bool fExists) { fExists = default(bool); throw null; }
        public System.EnterpriseServices.SharedProperty Property(string name) { throw null; }
        public System.EnterpriseServices.SharedProperty PropertyByPosition(int position) { throw null; }
    }
    [System.Runtime.InteropServices.ComVisibleAttribute(false)]
    public sealed partial class SharedPropertyGroupManager : System.Collections.IEnumerable
    {
        public SharedPropertyGroupManager() { }
        [System.MonoTODOAttribute]
        public System.EnterpriseServices.SharedPropertyGroup CreatePropertyGroup(string name, ref System.EnterpriseServices.PropertyLockMode dwIsoMode, ref System.EnterpriseServices.PropertyReleaseMode dwRelMode, out bool fExist) { fExist = default(bool); throw null; }
        [System.MonoTODOAttribute]
        public System.Collections.IEnumerator GetEnumerator() { throw null; }
        [System.MonoTODOAttribute]
        public System.EnterpriseServices.SharedPropertyGroup Group(string name) { throw null; }
    }
    [System.Runtime.InteropServices.ComVisibleAttribute(false)]
    [System.SerializableAttribute]
    public enum SxsOption
    {
        Ignore = 0,
        Inherit = 1,
        New = 2,
    }
    [System.AttributeUsageAttribute((System.AttributeTargets)(4))]
    [System.Runtime.InteropServices.ComVisibleAttribute(false)]
    public sealed partial class SynchronizationAttribute : System.Attribute
    {
        public SynchronizationAttribute() { }
        public SynchronizationAttribute(System.EnterpriseServices.SynchronizationOption val) { }
        public System.EnterpriseServices.SynchronizationOption Value { get { throw null; } }
    }
    [System.SerializableAttribute]
    public enum SynchronizationOption
    {
        Disabled = 0,
        NotSupported = 1,
        Required = 3,
        RequiresNew = 4,
        Supported = 2,
    }
    [System.Runtime.InteropServices.ComVisibleAttribute(false)]
    [System.SerializableAttribute]
    public enum ThreadPoolOption
    {
        Inherit = 1,
        MTA = 3,
        None = 0,
        STA = 2,
    }
    [System.AttributeUsageAttribute((System.AttributeTargets)(4))]
    [System.Runtime.InteropServices.ComVisibleAttribute(false)]
    public sealed partial class TransactionAttribute : System.Attribute
    {
        public TransactionAttribute() { }
        public TransactionAttribute(System.EnterpriseServices.TransactionOption val) { }
        public System.EnterpriseServices.TransactionIsolationLevel Isolation { get { throw null; } set { } }
        public int Timeout { get { throw null; } set { } }
        public System.EnterpriseServices.TransactionOption Value { get { throw null; } }
    }
    [System.SerializableAttribute]
    public enum TransactionIsolationLevel
    {
        Any = 0,
        ReadCommitted = 2,
        ReadUncommitted = 1,
        RepeatableRead = 3,
        Serializable = 4,
    }
    [System.SerializableAttribute]
    public enum TransactionOption
    {
        Disabled = 0,
        NotSupported = 1,
        Required = 3,
        RequiresNew = 4,
        Supported = 2,
    }
    [System.Runtime.InteropServices.ComVisibleAttribute(false)]
    [System.SerializableAttribute]
    public enum TransactionStatus
    {
        Aborted = 4,
        Aborting = 3,
        Commited = 0,
        LocallyOk = 1,
        NoTransaction = 2,
    }
    [System.Runtime.InteropServices.ComVisibleAttribute(false)]
    [System.SerializableAttribute]
    public enum TransactionVote
    {
        Abort = 1,
        Commit = 0,
    }
    [System.Runtime.InteropServices.ComVisibleAttribute(false)]
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public partial struct XACTTRANSINFO
    {
        public int grfRMSupported;
        public int grfRMSupportedRetaining;
        public int grfTCSupported;
        public int grfTCSupportedRetaining;
        public int isoFlags;
        public int isoLevel;
        public System.EnterpriseServices.BOID uow;
    }
}
namespace System.EnterpriseServices.CompensatingResourceManager
{
    [System.AttributeUsageAttribute((System.AttributeTargets)(1))]
    [System.Runtime.InteropServices.ComVisibleAttribute(false)]
    [System.Runtime.InteropServices.ProgIdAttribute("System.EnterpriseServices.Crm.ApplicationCrmEnabledAttribute")]
    public sealed partial class ApplicationCrmEnabledAttribute : System.Attribute
    {
        public ApplicationCrmEnabledAttribute() { }
        public ApplicationCrmEnabledAttribute(bool val) { }
        public bool Value { get { throw null; } }
    }
    public sealed partial class Clerk
    {
        [System.MonoTODOAttribute]
        public Clerk(string compensator, string description, System.EnterpriseServices.CompensatingResourceManager.CompensatorOptions flags) { }
        [System.MonoTODOAttribute]
        public Clerk(System.Type compensator, string description, System.EnterpriseServices.CompensatingResourceManager.CompensatorOptions flags) { }
        public int LogRecordCount { [System.MonoTODOAttribute]get { throw null; } }
        public string TransactionUOW { [System.MonoTODOAttribute]get { throw null; } }
        [System.MonoTODOAttribute]
        ~Clerk() { }
        [System.MonoTODOAttribute]
        public void ForceLog() { }
        [System.MonoTODOAttribute]
        public void ForceTransactionToAbort() { }
        [System.MonoTODOAttribute]
        public void ForgetLogRecord() { }
        [System.MonoTODOAttribute]
        public void WriteLogRecord(object record) { }
    }
    public sealed partial class ClerkInfo
    {
        internal ClerkInfo() { }
        [System.MonoTODOAttribute]
        public string ActivityId { get { throw null; } }
        [System.MonoTODOAttribute]
        public System.EnterpriseServices.CompensatingResourceManager.Clerk Clerk { get { throw null; } }
        [System.MonoTODOAttribute]
        public string Compensator { get { throw null; } }
        [System.MonoTODOAttribute]
        public string Description { get { throw null; } }
        [System.MonoTODOAttribute]
        public string InstanceId { get { throw null; } }
        [System.MonoTODOAttribute]
        public string TransactionUOW { get { throw null; } }
        [System.MonoTODOAttribute]
        ~ClerkInfo() { }
    }
    public sealed partial class ClerkMonitor : System.Collections.IEnumerable
    {
        [System.MonoTODOAttribute]
        public ClerkMonitor() { }
        [System.MonoTODOAttribute]
        public int Count { get { throw null; } }
        [System.MonoTODOAttribute]
        public System.EnterpriseServices.CompensatingResourceManager.ClerkInfo this[int index] { get { throw null; } }
        [System.MonoTODOAttribute]
        public System.EnterpriseServices.CompensatingResourceManager.ClerkInfo this[string index] { get { throw null; } }
        [System.MonoTODOAttribute]
        ~ClerkMonitor() { }
        [System.MonoTODOAttribute]
        public System.Collections.IEnumerator GetEnumerator() { throw null; }
        [System.MonoTODOAttribute]
        public void Populate() { }
    }
    public partial class Compensator : System.EnterpriseServices.ServicedComponent
    {
        [System.MonoTODOAttribute]
        public Compensator() { }
        public System.EnterpriseServices.CompensatingResourceManager.Clerk Clerk { [System.MonoTODOAttribute]get { throw null; } }
        [System.MonoTODOAttribute]
        public virtual bool AbortRecord(System.EnterpriseServices.CompensatingResourceManager.LogRecord rec) { throw null; }
        [System.MonoTODOAttribute]
        public virtual void BeginAbort(bool fRecovery) { }
        [System.MonoTODOAttribute]
        public virtual void BeginCommit(bool fRecovery) { }
        [System.MonoTODOAttribute]
        public virtual void BeginPrepare() { }
        [System.MonoTODOAttribute]
        public virtual bool CommitRecord(System.EnterpriseServices.CompensatingResourceManager.LogRecord rec) { throw null; }
        [System.MonoTODOAttribute]
        public virtual void EndAbort() { }
        [System.MonoTODOAttribute]
        public virtual void EndCommit() { }
        [System.MonoTODOAttribute]
        public virtual bool EndPrepare() { throw null; }
        [System.MonoTODOAttribute]
        public virtual bool PrepareRecord(System.EnterpriseServices.CompensatingResourceManager.LogRecord rec) { throw null; }
    }
    [System.FlagsAttribute]
    [System.SerializableAttribute]
    public enum CompensatorOptions
    {
        AbortPhase = 4,
        AllPhases = 7,
        CommitPhase = 2,
        FailIfInDoubtsRemain = 16,
        PreparePhase = 1,
    }
    public sealed partial class LogRecord
    {
        internal LogRecord() { }
        public System.EnterpriseServices.CompensatingResourceManager.LogRecordFlags Flags { get { throw null; } }
        public object Record { get { throw null; } }
        public int Sequence { get { throw null; } }
    }
    [System.FlagsAttribute]
    [System.SerializableAttribute]
    public enum LogRecordFlags
    {
        ForgetTarget = 1,
        ReplayInProgress = 64,
        WrittenDuringAbort = 8,
        WrittenDuringCommit = 4,
        WrittenDuringPrepare = 2,
        WrittenDuringReplay = 32,
        WrittenDurringRecovery = 16,
    }
    [System.SerializableAttribute]
    public enum TransactionState
    {
        Aborted = 2,
        Active = 0,
        Committed = 1,
        Indoubt = 3,
    }
}
namespace System.EnterpriseServices.Internal
{
    [System.Runtime.InteropServices.GuidAttribute("ef24f689-14f8-4d92-b4af-d7b1f0e70fd4")]
    public partial class AppDomainHelper
    {
        [System.MonoTODOAttribute]
        public AppDomainHelper() { }
        [System.MonoTODOAttribute]
        ~AppDomainHelper() { }
    }
    [System.Runtime.InteropServices.GuidAttribute("458aa3b5-265a-4b75-bc05-9bea4630cf18")]
    public partial class AssemblyLocator : System.MarshalByRefObject
    {
        [System.MonoTODOAttribute]
        public AssemblyLocator() { }
    }
    public partial class ClientRemotingConfig
    {
        [System.MonoTODOAttribute]
        public ClientRemotingConfig() { }
        [System.MonoTODOAttribute]
        public static bool Write(string DestinationDirectory, string VRoot, string BaseUrl, string AssemblyName, string TypeName, string ProgId, string Mode, string Transport) { throw null; }
    }
    [System.Runtime.InteropServices.GuidAttribute("ecabafd1-7f19-11d2-978e-0000f8757e2a")]
    public partial class ClrObjectFactory : System.EnterpriseServices.Internal.IClrObjectFactory
    {
        [System.MonoTODOAttribute]
        public ClrObjectFactory() { }
        [System.MonoTODOAttribute]
        public object CreateFromAssembly(string AssemblyName, string TypeName, string Mode) { throw null; }
        [System.MonoTODOAttribute]
        public object CreateFromMailbox(string Mailbox, string Mode) { throw null; }
        [System.MonoTODOAttribute]
        public object CreateFromVroot(string VrootUrl, string Mode) { throw null; }
        [System.MonoTODOAttribute]
        public object CreateFromWsdl(string WsdlUrl, string Mode) { throw null; }
    }
    [System.Runtime.InteropServices.GuidAttribute("3b0398c9-7812-4007-85cb-18c771f2206f")]
    public partial class ComManagedImportUtil : System.EnterpriseServices.Internal.IComManagedImportUtil
    {
        [System.MonoTODOAttribute]
        public ComManagedImportUtil() { }
        [System.MonoTODOAttribute]
        public void GetComponentInfo(string assemblyPath, out string numComponents, out string componentInfo) { numComponents = default(string); componentInfo = default(string); }
        [System.MonoTODOAttribute]
        public void InstallAssembly(string asmpath, string parname, string appname) { }
    }
    public partial class ComSoapPublishError
    {
        [System.MonoTODOAttribute]
        public ComSoapPublishError() { }
        [System.MonoTODOAttribute]
        public static void Report(string s) { }
    }
    [System.Runtime.InteropServices.GuidAttribute("d8013ff1-730b-45e2-ba24-874b7242c425")]
    public partial class GenerateMetadata : System.EnterpriseServices.Internal.IComSoapMetadata
    {
        [System.MonoTODOAttribute]
        public GenerateMetadata() { }
        [System.MonoTODOAttribute]
        public string Generate(string strSrcTypeLib, string outPath) { throw null; }
        [System.MonoTODOAttribute]
        public string GenerateMetaData(string strSrcTypeLib, string outPath, byte[] PublicKey, System.Reflection.StrongNameKeyPair KeyPair) { throw null; }
        [System.MonoTODOAttribute]
        public string GenerateSigned(string strSrcTypeLib, string outPath, bool InstallGac, out string Error) { Error = default(string); throw null; }
        [System.MonoTODOAttribute]
        public static int SearchPath(string path, string fileName, string extension, int numBufferChars, string buffer, int[] filePart) { throw null; }
    }
    [System.Runtime.InteropServices.GuidAttribute("ecabafd2-7f19-11d2-978e-0000f8757e2a")]
    public partial interface IClrObjectFactory
    {
        [System.Runtime.InteropServices.DispIdAttribute(1)]
        [return: System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.IDispatch)]
        object CreateFromAssembly(string assembly, string type, string mode);
        [System.Runtime.InteropServices.DispIdAttribute(4)]
        [return: System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.IDispatch)]
        object CreateFromMailbox(string Mailbox, string Mode);
        [System.Runtime.InteropServices.DispIdAttribute(2)]
        [return: System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.IDispatch)]
        object CreateFromVroot(string VrootUrl, string Mode);
        [System.Runtime.InteropServices.DispIdAttribute(3)]
        [return: System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.IDispatch)]
        object CreateFromWsdl(string WsdlUrl, string Mode);
    }
    [System.Runtime.InteropServices.GuidAttribute("c3f8f66b-91be-4c99-a94f-ce3b0a951039")]
    public partial interface IComManagedImportUtil
    {
        [System.Runtime.InteropServices.DispIdAttribute(4)]
        void GetComponentInfo([System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.BStr)]string assemblyPath, [System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.BStr)]out string numComponents, [System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.BStr)]out string componentInfo);
        [System.Runtime.InteropServices.DispIdAttribute(5)]
        void InstallAssembly([System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.BStr)]string filename, [System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.BStr)]string parname, [System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.BStr)]string appname);
    }
    [System.Runtime.InteropServices.GuidAttribute("d8013ef0-730b-45e2-ba24-874b7242c425")]
    public partial interface IComSoapIISVRoot
    {
        [System.Runtime.InteropServices.DispIdAttribute(1)]
        void Create([System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.BStr)]string RootWeb, [System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.BStr)]string PhysicalDirectory, [System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.BStr)]string VirtualDirectory, [System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.BStr)]out string Error);
        [System.Runtime.InteropServices.DispIdAttribute(2)]
        void Delete([System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.BStr)]string RootWeb, [System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.BStr)]string PhysicalDirectory, [System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.BStr)]string VirtualDirectory, [System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.BStr)]out string Error);
    }
    [System.Runtime.InteropServices.GuidAttribute("d8013ff0-730b-45e2-ba24-874b7242c425")]
    public partial interface IComSoapMetadata
    {
        [System.Runtime.InteropServices.DispIdAttribute(1)]
        [return: System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.BStr)]
        string Generate([System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.BStr)]string SrcTypeLibFileName, [System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.BStr)]string OutPath);
        [System.Runtime.InteropServices.DispIdAttribute(2)]
        [return: System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.BStr)]
        string GenerateSigned([System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.BStr)]string SrcTypeLibFileName, [System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.BStr)]string OutPath, [System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.Bool)]bool InstallGac, [System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.BStr)]out string Error);
    }
    [System.Runtime.InteropServices.GuidAttribute("d8013eee-730b-45e2-ba24-874b7242c425")]
    public partial interface IComSoapPublisher
    {
        [System.Runtime.InteropServices.DispIdAttribute(6)]
        void CreateMailBox([System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.BStr)]string RootMailServer, [System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.BStr)]string MailBox, [System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.BStr)]out string SmtpName, [System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.BStr)]out string Domain, [System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.BStr)]out string PhysicalPath, [System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.BStr)]out string Error);
        [System.Runtime.InteropServices.DispIdAttribute(4)]
        void CreateVirtualRoot([System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.BStr)]string Operation, [System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.BStr)]string FullUrl, [System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.BStr)]out string BaseUrl, [System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.BStr)]out string VirtualRoot, [System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.BStr)]out string PhysicalPath, [System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.BStr)]out string Error);
        [System.Runtime.InteropServices.DispIdAttribute(7)]
        void DeleteMailBox([System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.BStr)]string RootMailServer, [System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.BStr)]string MailBox, [System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.BStr)]out string Error);
        [System.Runtime.InteropServices.DispIdAttribute(5)]
        void DeleteVirtualRoot([System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.BStr)]string RootWebServer, [System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.BStr)]string FullUrl, [System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.BStr)]out string Error);
        [System.Runtime.InteropServices.DispIdAttribute(13)]
        void GacInstall([System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.BStr)]string AssemblyPath);
        [System.Runtime.InteropServices.DispIdAttribute(14)]
        void GacRemove([System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.BStr)]string AssemblyPath);
        [System.Runtime.InteropServices.DispIdAttribute(15)]
        void GetAssemblyNameForCache([System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.BStr)]string TypeLibPath, [System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.BStr)]out string CachePath);
        [System.Runtime.InteropServices.DispIdAttribute(10)]
        [return: System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.BStr)]
        string GetTypeNameFromProgId([System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.BStr)]string AssemblyPath, [System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.BStr)]string ProgId);
        [System.Runtime.InteropServices.DispIdAttribute(9)]
        void ProcessClientTlb([System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.BStr)]string ProgId, [System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.BStr)]string SrcTlbPath, [System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.BStr)]string PhysicalPath, [System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.BStr)]string VRoot, [System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.BStr)]string BaseUrl, [System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.BStr)]string Mode, [System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.BStr)]string Transport, [System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.BStr)]out string AssemblyName, [System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.BStr)]out string TypeName, [System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.BStr)]out string Error);
        [System.Runtime.InteropServices.DispIdAttribute(8)]
        void ProcessServerTlb([System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.BStr)]string ProgId, [System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.BStr)]string SrcTlbPath, [System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.BStr)]string PhysicalPath, [System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.BStr)]string Operation, [System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.BStr)]out string AssemblyName, [System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.BStr)]out string TypeName, [System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.BStr)]out string Error);
        [System.Runtime.InteropServices.DispIdAttribute(11)]
        void RegisterAssembly([System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.BStr)]string AssemblyPath);
        [System.Runtime.InteropServices.DispIdAttribute(12)]
        void UnRegisterAssembly([System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.BStr)]string AssemblyPath);
    }
    [System.Runtime.InteropServices.GuidAttribute("d8013ef1-730b-45e2-ba24-874b7242c425")]
    public partial class IISVirtualRoot : System.EnterpriseServices.Internal.IComSoapIISVRoot
    {
        [System.MonoTODOAttribute]
        public IISVirtualRoot() { }
        [System.MonoTODOAttribute]
        public void Create(string RootWeb, string inPhysicalDirectory, string VirtualDirectory, out string Error) { Error = default(string); }
        [System.MonoTODOAttribute]
        public void Delete(string RootWeb, string PhysicalDirectory, string VirtualDirectory, out string Error) { Error = default(string); }
    }
    [System.Runtime.InteropServices.GuidAttribute("6261e4b5-572a-4142-a2f9-1fe1a0c97097")]
    public partial interface IServerWebConfig
    {
        [System.Runtime.InteropServices.DispIdAttribute(1)]
        void AddElement([System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.BStr)]string FilePath, [System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.BStr)]string AssemblyName, [System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.BStr)]string TypeName, [System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.BStr)]string ProgId, [System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.BStr)]string Mode, [System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.BStr)]out string Error);
        [System.Runtime.InteropServices.DispIdAttribute(2)]
        void Create([System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.BStr)]string FilePath, [System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.BStr)]string FileRootName, [System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.BStr)]out string Error);
    }
    [System.Runtime.InteropServices.GuidAttribute("E7F0F021-9201-47e4-94DA-1D1416DEC27A")]
    public partial interface ISoapClientImport
    {
        [System.Runtime.InteropServices.DispIdAttribute(1)]
        void ProcessClientTlbEx([System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.BStr)]string progId, [System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.BStr)]string virtualRoot, [System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.BStr)]string baseUrl, [System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.BStr)]string authentication, [System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.BStr)]string assemblyName, [System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.BStr)]string typeName);
    }
    [System.Runtime.InteropServices.GuidAttribute("1E7BA9F7-21DB-4482-929E-21BDE2DFE51C")]
    public partial interface ISoapServerTlb
    {
        [System.Runtime.InteropServices.DispIdAttribute(1)]
        void AddServerTlb([System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.BStr)]string progId, [System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.BStr)]string classId, [System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.BStr)]string interfaceId, [System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.BStr)]string srcTlbPath, [System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.BStr)]string rootWebServer, [System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.BStr)]string baseUrl, [System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.BStr)]string virtualRoot, [System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.BStr)]string clientActivated, [System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.BStr)]string wellKnown, [System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.BStr)]string discoFile, [System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.BStr)]string operation, [System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.BStr)]out string assemblyName, [System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.BStr)]out string typeName);
        [System.Runtime.InteropServices.DispIdAttribute(2)]
        void DeleteServerTlb([System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.BStr)]string progId, [System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.BStr)]string classId, [System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.BStr)]string interfaceId, [System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.BStr)]string srcTlbPath, [System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.BStr)]string rootWebServer, [System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.BStr)]string baseUrl, [System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.BStr)]string virtualRoot, [System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.BStr)]string operation, [System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.BStr)]string assemblyName, [System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.BStr)]string typeName);
    }
    [System.Runtime.InteropServices.GuidAttribute("A31B6577-71D2-4344-AEDF-ADC1B0DC5347")]
    public partial interface ISoapServerVRoot
    {
        [System.Runtime.InteropServices.DispIdAttribute(1)]
        void CreateVirtualRootEx([System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.BStr)]string rootWebServer, [System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.BStr)]string inBaseUrl, [System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.BStr)]string inVirtualRoot, [System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.BStr)]string homePage, [System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.BStr)]string discoFile, [System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.BStr)]string secureSockets, [System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.BStr)]string authentication, [System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.BStr)]string operation, [System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.BStr)]out string baseUrl, [System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.BStr)]out string virtualRoot, [System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.BStr)]out string physicalPath);
        [System.Runtime.InteropServices.DispIdAttribute(2)]
        void DeleteVirtualRootEx([System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.BStr)]string rootWebServer, [System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.BStr)]string baseUrl, [System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.BStr)]string virtualRoot);
        [System.Runtime.InteropServices.DispIdAttribute(3)]
        void GetVirtualRootStatus([System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.BStr)]string rootWebServer, [System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.BStr)]string inBaseUrl, [System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.BStr)]string inVirtualRoot, [System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.BStr)]out string exists, [System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.BStr)]out string secureSockets, [System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.BStr)]out string windowsAuth, [System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.BStr)]out string anonymous, [System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.BStr)]out string homePage, [System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.BStr)]out string discoFile, [System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.BStr)]out string physicalPath, [System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.BStr)]out string baseUrl, [System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.BStr)]out string virtualRoot);
    }
    [System.Runtime.InteropServices.GuidAttribute("5AC4CB7E-F89F-429b-926B-C7F940936BF4")]
    public partial interface ISoapUtility
    {
        [System.Runtime.InteropServices.DispIdAttribute(2)]
        void GetServerBinPath([System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.BStr)]string rootWebServer, [System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.BStr)]string inBaseUrl, [System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.BStr)]string inVirtualRoot, [System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.BStr)]out string binPath);
        [System.Runtime.InteropServices.DispIdAttribute(1)]
        void GetServerPhysicalPath([System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.BStr)]string rootWebServer, [System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.BStr)]string inBaseUrl, [System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.BStr)]string inVirtualRoot, [System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.BStr)]out string physicalPath);
        [System.Runtime.InteropServices.DispIdAttribute(3)]
        void Present();
    }
    [System.Runtime.InteropServices.GuidAttribute("d8013eef-730b-45e2-ba24-874b7242c425")]
    public partial class Publish : System.EnterpriseServices.Internal.IComSoapPublisher
    {
        [System.MonoTODOAttribute]
        public Publish() { }
        [System.MonoTODOAttribute]
        public void CreateMailBox(string RootMailServer, string MailBox, out string SmtpName, out string Domain, out string PhysicalPath, out string Error) { SmtpName = default(string); Domain = default(string); PhysicalPath = default(string); Error = default(string); }
        [System.MonoTODOAttribute]
        public void CreateVirtualRoot(string Operation, string FullUrl, out string BaseUrl, out string VirtualRoot, out string PhysicalPath, out string Error) { BaseUrl = default(string); VirtualRoot = default(string); PhysicalPath = default(string); Error = default(string); }
        [System.MonoTODOAttribute]
        public void DeleteMailBox(string RootMailServer, string MailBox, out string Error) { Error = default(string); }
        [System.MonoTODOAttribute]
        public void DeleteVirtualRoot(string RootWebServer, string FullUrl, out string Error) { Error = default(string); }
        [System.MonoTODOAttribute]
        public void GacInstall(string AssemblyPath) { }
        [System.MonoTODOAttribute]
        public void GacRemove(string AssemblyPath) { }
        [System.MonoTODOAttribute]
        public void GetAssemblyNameForCache(string TypeLibPath, out string CachePath) { CachePath = default(string); }
        [System.MonoTODOAttribute]
        public static string GetClientPhysicalPath(bool CreateDir) { throw null; }
        [System.MonoTODOAttribute]
        public string GetTypeNameFromProgId(string AssemblyPath, string ProgId) { throw null; }
        [System.MonoTODOAttribute]
        public static void ParseUrl(string FullUrl, out string BaseUrl, out string VirtualRoot) { BaseUrl = default(string); VirtualRoot = default(string); }
        [System.MonoTODOAttribute]
        public void ProcessClientTlb(string ProgId, string SrcTlbPath, string PhysicalPath, string VRoot, string BaseUrl, string Mode, string Transport, out string AssemblyName, out string TypeName, out string Error) { AssemblyName = default(string); TypeName = default(string); Error = default(string); }
        [System.MonoTODOAttribute]
        public void ProcessServerTlb(string ProgId, string SrcTlbPath, string PhysicalPath, string Operation, out string strAssemblyName, out string TypeName, out string Error) { strAssemblyName = default(string); TypeName = default(string); Error = default(string); }
        [System.MonoTODOAttribute]
        public void RegisterAssembly(string AssemblyPath) { }
        [System.MonoTODOAttribute]
        public void UnRegisterAssembly(string AssemblyPath) { }
    }
    public partial class ServerWebConfig : System.EnterpriseServices.Internal.IServerWebConfig
    {
        [System.MonoTODOAttribute]
        public ServerWebConfig() { }
        [System.MonoTODOAttribute]
        public void AddElement(string FilePath, string AssemblyName, string TypeName, string ProgId, string WkoMode, out string Error) { Error = default(string); }
        [System.MonoTODOAttribute]
        public void Create(string FilePath, string FilePrefix, out string Error) { Error = default(string); }
    }
    [System.Runtime.InteropServices.GuidAttribute("346D5B9F-45E1-45c0-AADF-1B7D221E9063")]
    public sealed partial class SoapClientImport : System.EnterpriseServices.Internal.ISoapClientImport
    {
        [System.MonoTODOAttribute]
        public SoapClientImport() { }
        [System.MonoTODOAttribute]
        public void ProcessClientTlbEx(string progId, string virtualRoot, string baseUrl, string authentication, string assemblyName, string typeName) { }
    }
    [System.Runtime.InteropServices.GuidAttribute("F6B6768F-F99E-4152-8ED2-0412F78517FB")]
    public sealed partial class SoapServerTlb : System.EnterpriseServices.Internal.ISoapServerTlb
    {
        [System.MonoTODOAttribute]
        public SoapServerTlb() { }
        [System.MonoTODOAttribute]
        public void AddServerTlb(string progId, string classId, string interfaceId, string srcTlbPath, string rootWebServer, string inBaseUrl, string inVirtualRoot, string clientActivated, string wellKnown, string discoFile, string operation, out string strAssemblyName, out string typeName) { strAssemblyName = default(string); typeName = default(string); }
        [System.MonoTODOAttribute]
        public void DeleteServerTlb(string progId, string classId, string interfaceId, string srcTlbPath, string rootWebServer, string baseUrl, string virtualRoot, string operation, string assemblyName, string typeName) { }
    }
    [System.Runtime.InteropServices.GuidAttribute("CAA817CC-0C04-4d22-A05C-2B7E162F4E8F")]
    public sealed partial class SoapServerVRoot : System.EnterpriseServices.Internal.ISoapServerVRoot
    {
        [System.MonoTODOAttribute]
        public SoapServerVRoot() { }
        [System.MonoTODOAttribute]
        public void CreateVirtualRootEx(string rootWebServer, string inBaseUrl, string inVirtualRoot, string homePage, string discoFile, string secureSockets, string authentication, string operation, out string baseUrl, out string virtualRoot, out string physicalPath) { baseUrl = default(string); virtualRoot = default(string); physicalPath = default(string); }
        [System.MonoTODOAttribute]
        public void DeleteVirtualRootEx(string rootWebServer, string inBaseUrl, string inVirtualRoot) { }
        [System.MonoTODOAttribute]
        public void GetVirtualRootStatus(string RootWebServer, string inBaseUrl, string inVirtualRoot, out string Exists, out string SSL, out string WindowsAuth, out string Anonymous, out string HomePage, out string DiscoFile, out string PhysicalPath, out string BaseUrl, out string VirtualRoot) { Exists = default(string); SSL = default(string); WindowsAuth = default(string); Anonymous = default(string); HomePage = default(string); DiscoFile = default(string); PhysicalPath = default(string); BaseUrl = default(string); VirtualRoot = default(string); }
    }
    [System.Runtime.InteropServices.GuidAttribute("5F9A955F-AA55-4127-A32B-33496AA8A44E")]
    public sealed partial class SoapUtility : System.EnterpriseServices.Internal.ISoapUtility
    {
        [System.MonoTODOAttribute]
        public SoapUtility() { }
        [System.MonoTODOAttribute]
        public void GetServerBinPath(string rootWebServer, string inBaseUrl, string inVirtualRoot, out string binPath) { binPath = default(string); }
        [System.MonoTODOAttribute]
        public void GetServerPhysicalPath(string rootWebServer, string inBaseUrl, string inVirtualRoot, out string physicalPath) { physicalPath = default(string); }
        [System.MonoTODOAttribute]
        public void Present() { }
    }
}
