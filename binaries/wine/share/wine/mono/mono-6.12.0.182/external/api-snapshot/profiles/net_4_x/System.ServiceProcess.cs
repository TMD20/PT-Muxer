// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

[assembly:System.Reflection.AssemblyVersionAttribute("4.0.0.0")]
[assembly:System.CLSCompliantAttribute(true)]
[assembly:System.Diagnostics.DebuggableAttribute(System.Diagnostics.DebuggableAttribute.DebuggingModes.IgnoreSymbolStoreSequencePoints)]
[assembly:System.Reflection.AssemblyCompanyAttribute("Mono development team")]
[assembly:System.Reflection.AssemblyCopyrightAttribute("(c) Various Mono authors")]
[assembly:System.Reflection.AssemblyDefaultAliasAttribute("System.ServiceProcess.dll")]
[assembly:System.Reflection.AssemblyDescriptionAttribute("System.ServiceProcess.dll")]
[assembly:System.Reflection.AssemblyFileVersionAttribute("4.6.57.0")]
[assembly:System.Reflection.AssemblyInformationalVersionAttribute("4.6.57.0")]
[assembly:System.Reflection.AssemblyProductAttribute("Mono Common Language Infrastructure")]
[assembly:System.Reflection.AssemblyTitleAttribute("System.ServiceProcess.dll")]
[assembly:System.Resources.NeutralResourcesLanguageAttribute("en-US")]
[assembly:System.Resources.SatelliteContractVersionAttribute("4.0.0.0")]
[assembly:System.Runtime.CompilerServices.CompilationRelaxationsAttribute(System.Runtime.CompilerServices.CompilationRelaxations.NoStringInterning)]
[assembly:System.Runtime.CompilerServices.RuntimeCompatibilityAttribute(WrapNonExceptionThrows=true)]
[assembly:System.Runtime.InteropServices.ComVisibleAttribute(false)]
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
namespace System.ServiceProcess
{
    public enum PowerBroadcastStatus
    {
        BatteryLow = 9,
        OemEvent = 11,
        PowerStatusChange = 10,
        QuerySuspend = 0,
        QuerySuspendFailed = 2,
        ResumeAutomatic = 18,
        ResumeCritical = 6,
        ResumeSuspend = 7,
        Suspend = 4,
    }
    public enum ServiceAccount
    {
        LocalService = 0,
        LocalSystem = 2,
        NetworkService = 1,
        User = 3,
    }
    [System.ComponentModel.InstallerTypeAttribute(typeof(System.ServiceProcess.ServiceProcessInstaller))]
    public partial class ServiceBase : System.ComponentModel.Component
    {
        public const int MaxNameLength = 80;
        public ServiceBase() { }
        [System.ComponentModel.DefaultValueAttribute(true)]
        [System.ServiceProcess.ServiceProcessDescriptionAttribute("Whether the service should automatically write to the event log on common events such as Install and Start.")]
        public bool AutoLog { get { throw null; } set { } }
        [System.ComponentModel.DefaultValueAttribute(false)]
        [System.MonoTODOAttribute]
        public bool CanHandlePowerEvent { get { throw null; } set { } }
        [System.ComponentModel.DefaultValueAttribute(false)]
        [System.MonoTODOAttribute]
        [System.Runtime.InteropServices.ComVisibleAttribute(false)]
        public bool CanHandleSessionChangeEvent { get { throw null; } set { } }
        [System.ComponentModel.DefaultValueAttribute(false)]
        public bool CanPauseAndContinue { get { throw null; } set { } }
        [System.ComponentModel.DefaultValueAttribute(false)]
        public bool CanShutdown { get { throw null; } set { } }
        [System.ComponentModel.DefaultValueAttribute(true)]
        public bool CanStop { get { throw null; } set { } }
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.DesignerSerializationVisibilityAttribute(System.ComponentModel.DesignerSerializationVisibility.Hidden)]
        public virtual System.Diagnostics.EventLog EventLog { get { throw null; } }
        [System.Runtime.InteropServices.ComVisibleAttribute(false)]
        public int ExitCode { get { throw null; } set { } }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        [System.MonoTODOAttribute]
        protected System.IntPtr ServiceHandle { get { throw null; } }
        [System.ComponentModel.TypeConverterAttribute("System.Diagnostics.Design.StringValueConverter, System.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
        [System.ServiceProcess.ServiceProcessDescriptionAttribute("The name by which the service is identified to the system.")]
        public string ServiceName { get { throw null; } set { } }
        protected override void Dispose(bool disposing) { }
        protected virtual void OnContinue() { }
        protected virtual void OnCustomCommand(int command) { }
        protected virtual void OnPause() { }
        protected virtual bool OnPowerEvent(System.ServiceProcess.PowerBroadcastStatus powerStatus) { throw null; }
        protected virtual void OnSessionChange(System.ServiceProcess.SessionChangeDescription changeDescription) { }
        protected virtual void OnShutdown() { }
        protected virtual void OnStart(string[] args) { }
        protected virtual void OnStop() { }
        [System.MonoTODOAttribute]
        [System.Runtime.InteropServices.ComVisibleAttribute(false)]
        public void RequestAdditionalTime(int milliseconds) { }
        public static void Run(System.ServiceProcess.ServiceBase service) { }
        public static void Run(System.ServiceProcess.ServiceBase[] services) { }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.MonoTODOAttribute("This only makes sense on Windows")]
        [System.Runtime.InteropServices.ComVisibleAttribute(false)]
        public void ServiceMainCallback(int argCount, System.IntPtr argPointer) { }
        public void Stop() { }
    }
    [System.ComponentModel.DesignerAttribute("System.ServiceProcess.Design.ServiceControllerDesigner, System.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
    [System.MonoTODOAttribute("No unix implementation")]
    [System.ServiceProcess.ServiceProcessDescriptionAttribute("Provides the ability to connect to, query, and manipulate running or stopped Windows services.")]
    public partial class ServiceController : System.ComponentModel.Component
    {
        public ServiceController() { }
        public ServiceController(string name) { }
        public ServiceController(string name, string machineName) { }
        [System.ComponentModel.DesignerSerializationVisibilityAttribute(System.ComponentModel.DesignerSerializationVisibility.Hidden)]
        [System.ServiceProcess.ServiceProcessDescriptionAttribute("Whether this service recognizes the Pause and Continue commands.")]
        public bool CanPauseAndContinue { get { throw null; } }
        [System.ComponentModel.DesignerSerializationVisibilityAttribute(System.ComponentModel.DesignerSerializationVisibility.Hidden)]
        [System.ServiceProcess.ServiceProcessDescriptionAttribute("Whether this service can respond to a system shutdown.")]
        public bool CanShutdown { get { throw null; } }
        [System.ComponentModel.DesignerSerializationVisibilityAttribute(System.ComponentModel.DesignerSerializationVisibility.Hidden)]
        [System.ServiceProcess.ServiceProcessDescriptionAttribute("Whether this service can be stopped.")]
        public bool CanStop { get { throw null; } }
        [System.ComponentModel.DesignerSerializationVisibilityAttribute(System.ComponentModel.DesignerSerializationVisibility.Hidden)]
        [System.ServiceProcess.ServiceProcessDescriptionAttribute("The services that depend on this service in order to run.")]
        public System.ServiceProcess.ServiceController[] DependentServices { get { throw null; } }
        [System.ComponentModel.DesignerSerializationVisibilityAttribute(System.ComponentModel.DesignerSerializationVisibility.Hidden)]
        [System.ComponentModel.ReadOnlyAttribute(true)]
        [System.ServiceProcess.ServiceProcessDescriptionAttribute("The descriptive name of the service.")]
        public string DisplayName { get { throw null; } set { } }
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.DefaultValueAttribute(".")]
        [System.ComponentModel.RecommendedAsConfigurableAttribute(true)]
        [System.ServiceProcess.ServiceProcessDescriptionAttribute("The name of the machine on which this service resides.")]
        public string MachineName { get { throw null; } set { } }
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.DesignerSerializationVisibilityAttribute(System.ComponentModel.DesignerSerializationVisibility.Hidden)]
        [System.MonoTODOAttribute]
        public System.Runtime.InteropServices.SafeHandle ServiceHandle { get { throw null; } }
        [System.ComponentModel.DefaultValueAttribute("")]
        [System.ComponentModel.ReadOnlyAttribute(true)]
        [System.ComponentModel.RecommendedAsConfigurableAttribute(true)]
        [System.ComponentModel.TypeConverterAttribute("System.ServiceProcess.Design.ServiceNameConverter")]
        [System.ServiceProcess.ServiceProcessDescriptionAttribute("The short name of the service.")]
        public string ServiceName { get { throw null; } set { } }
        [System.ComponentModel.DesignerSerializationVisibilityAttribute(System.ComponentModel.DesignerSerializationVisibility.Hidden)]
        [System.ServiceProcess.ServiceProcessDescriptionAttribute("Services that must be started in order for this one to start.")]
        public System.ServiceProcess.ServiceController[] ServicesDependedOn { get { throw null; } }
        [System.ComponentModel.DesignerSerializationVisibilityAttribute(System.ComponentModel.DesignerSerializationVisibility.Hidden)]
        [System.ServiceProcess.ServiceProcessDescriptionAttribute("The type of this service.")]
        public System.ServiceProcess.ServiceType ServiceType { get { throw null; } }
        [System.ComponentModel.DesignerSerializationVisibilityAttribute(System.ComponentModel.DesignerSerializationVisibility.Hidden)]
        [System.ServiceProcess.ServiceProcessDescriptionAttribute("The status of the service, e.g., Running or Stopped.")]
        public System.ServiceProcess.ServiceControllerStatus Status { get { throw null; } }
        public void Close() { }
        public void Continue() { }
        protected override void Dispose(bool disposing) { }
        public void ExecuteCommand(int command) { }
        public static System.ServiceProcess.ServiceController[] GetDevices() { throw null; }
        public static System.ServiceProcess.ServiceController[] GetDevices(string machineName) { throw null; }
        public static System.ServiceProcess.ServiceController[] GetServices() { throw null; }
        public static System.ServiceProcess.ServiceController[] GetServices(string machineName) { throw null; }
        public void Pause() { }
        public void Refresh() { }
        public void Start() { }
        public void Start(string[] args) { }
        public void Stop() { }
        public void WaitForStatus(System.ServiceProcess.ServiceControllerStatus desiredStatus) { }
        public void WaitForStatus(System.ServiceProcess.ServiceControllerStatus desiredStatus, System.TimeSpan timeout) { }
    }
    [System.SerializableAttribute]
    public sealed partial class ServiceControllerPermission : System.Security.Permissions.ResourcePermissionBase
    {
        public ServiceControllerPermission() { }
        public ServiceControllerPermission(System.Security.Permissions.PermissionState state) { }
        public ServiceControllerPermission(System.ServiceProcess.ServiceControllerPermissionAccess permissionAccess, string machineName, string serviceName) { }
        public ServiceControllerPermission(System.ServiceProcess.ServiceControllerPermissionEntry[] permissionAccessEntries) { }
        public System.ServiceProcess.ServiceControllerPermissionEntryCollection PermissionEntries { get { throw null; } }
    }
    [System.FlagsAttribute]
    public enum ServiceControllerPermissionAccess
    {
        Browse = 2,
        Control = 6,
        None = 0,
    }
    [System.AttributeUsageAttribute(System.AttributeTargets.Assembly | System.AttributeTargets.Class | System.AttributeTargets.Constructor | System.AttributeTargets.Event | System.AttributeTargets.Method | System.AttributeTargets.Struct, AllowMultiple=true, Inherited=false)]
    [System.SerializableAttribute]
    public partial class ServiceControllerPermissionAttribute : System.Security.Permissions.CodeAccessSecurityAttribute
    {
        public ServiceControllerPermissionAttribute(System.Security.Permissions.SecurityAction action) : base (default(System.Security.Permissions.SecurityAction)) { }
        public string MachineName { get { throw null; } set { } }
        public System.ServiceProcess.ServiceControllerPermissionAccess PermissionAccess { get { throw null; } set { } }
        public string ServiceName { get { throw null; } set { } }
        public override System.Security.IPermission CreatePermission() { throw null; }
    }
    [System.SerializableAttribute]
    public partial class ServiceControllerPermissionEntry
    {
        public ServiceControllerPermissionEntry() { }
        public ServiceControllerPermissionEntry(System.ServiceProcess.ServiceControllerPermissionAccess permissionAccess, string machineName, string serviceName) { }
        public string MachineName { get { throw null; } }
        public System.ServiceProcess.ServiceControllerPermissionAccess PermissionAccess { get { throw null; } }
        public string ServiceName { get { throw null; } }
    }
    [System.SerializableAttribute]
    public partial class ServiceControllerPermissionEntryCollection : System.Collections.CollectionBase
    {
        internal ServiceControllerPermissionEntryCollection() { }
        public System.ServiceProcess.ServiceControllerPermissionEntry this[int index] { get { throw null; } set { } }
        public int Add(System.ServiceProcess.ServiceControllerPermissionEntry value) { throw null; }
        public void AddRange(System.ServiceProcess.ServiceControllerPermissionEntryCollection value) { }
        public void AddRange(System.ServiceProcess.ServiceControllerPermissionEntry[] value) { }
        public bool Contains(System.ServiceProcess.ServiceControllerPermissionEntry value) { throw null; }
        public void CopyTo(System.ServiceProcess.ServiceControllerPermissionEntry[] array, int index) { }
        public int IndexOf(System.ServiceProcess.ServiceControllerPermissionEntry value) { throw null; }
        public void Insert(int index, System.ServiceProcess.ServiceControllerPermissionEntry value) { }
        protected override void OnClear() { }
        protected override void OnInsert(int index, object value) { }
        protected override void OnRemove(int index, object value) { }
        protected override void OnSet(int index, object oldValue, object newValue) { }
        public void Remove(System.ServiceProcess.ServiceControllerPermissionEntry value) { }
    }
    public enum ServiceControllerStatus
    {
        ContinuePending = 5,
        Paused = 7,
        PausePending = 6,
        Running = 4,
        StartPending = 2,
        Stopped = 1,
        StopPending = 3,
    }
    [System.MonoTODOAttribute]
    public partial class ServiceInstaller : System.Configuration.Install.ComponentInstaller
    {
        public ServiceInstaller() { }
        [System.ComponentModel.DefaultValueAttribute(false)]
        [System.ServiceProcess.ServiceProcessDescriptionAttribute("Indicates that the service's start should be delayed after other automatically started services have started.")]
        public bool DelayedAutoStart { get { throw null; } set { } }
        [System.ComponentModel.DefaultValueAttribute("")]
        [System.Runtime.InteropServices.ComVisibleAttribute(false)]
        [System.ServiceProcess.ServiceProcessDescriptionAttribute("Indicates the service's description (a brief comment that explains the purpose of the service). ")]
        public string Description { get { throw null; } set { } }
        [System.ComponentModel.DefaultValueAttribute("")]
        [System.ServiceProcess.ServiceProcessDescriptionAttribute("Indicates the friendly name that identifies the service to the user.")]
        public string DisplayName { get { throw null; } set { } }
        [System.ComponentModel.DefaultValueAttribute("")]
        [System.ComponentModel.TypeConverterAttribute("System.Diagnostics.Design.StringValueConverter, System.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
        [System.ServiceProcess.ServiceProcessDescriptionAttribute("Indicates the name used by the system to identify this service.")]
        public string ServiceName { get { throw null; } set { } }
        [System.ServiceProcess.ServiceProcessDescriptionAttribute("Indicates the services that must be running in order for this service to run.")]
        public string[] ServicesDependedOn { get { throw null; } set { } }
        [System.ComponentModel.DefaultValueAttribute(System.ServiceProcess.ServiceStartMode.Manual)]
        [System.ServiceProcess.ServiceProcessDescriptionAttribute("Indicates how and when this service is started.")]
        public System.ServiceProcess.ServiceStartMode StartType { get { throw null; } set { } }
        public override void CopyFromComponent(System.ComponentModel.IComponent component) { }
        public override void Install(System.Collections.IDictionary stateSaver) { }
        public override bool IsEquivalentInstaller(System.Configuration.Install.ComponentInstaller otherInstaller) { throw null; }
        public override void Rollback(System.Collections.IDictionary savedState) { }
        public override void Uninstall(System.Collections.IDictionary savedState) { }
    }
    [System.AttributeUsageAttribute(System.AttributeTargets.All)]
    public partial class ServiceProcessDescriptionAttribute : System.ComponentModel.DescriptionAttribute
    {
        public ServiceProcessDescriptionAttribute(string description) { }
        public override string Description { get { throw null; } }
    }
    public partial class ServiceProcessInstaller : System.Configuration.Install.ComponentInstaller
    {
        public ServiceProcessInstaller() { }
        [System.ComponentModel.DefaultValueAttribute(System.ServiceProcess.ServiceAccount.User)]
        [System.ServiceProcess.ServiceProcessDescriptionAttribute("Indicates the account type under which the service will run.")]
        public System.ServiceProcess.ServiceAccount Account { get { throw null; } set { } }
        public override string HelpText { get { throw null; } }
        [System.ComponentModel.BrowsableAttribute(false)]
        public string Password { get { throw null; } set { } }
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.TypeConverterAttribute("System.Diagnostics.Design.StringValueConverter, System.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
        public string Username { get { throw null; } set { } }
        public override void CopyFromComponent(System.ComponentModel.IComponent comp) { }
        public override void Install(System.Collections.IDictionary stateSaver) { }
        public override void Rollback(System.Collections.IDictionary savedState) { }
    }
    public enum ServiceStartMode
    {
        Automatic = 2,
        Disabled = 4,
        Manual = 3,
    }
    [System.FlagsAttribute]
    public enum ServiceType
    {
        Adapter = 4,
        FileSystemDriver = 2,
        InteractiveProcess = 256,
        KernelDriver = 1,
        RecognizerDriver = 8,
        Win32OwnProcess = 16,
        Win32ShareProcess = 32,
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public partial struct SessionChangeDescription
    {
        private int _dummyPrimitive;
        public System.ServiceProcess.SessionChangeReason Reason { get { throw null; } }
        public int SessionId { get { throw null; } }
        public override bool Equals(object obj) { throw null; }
        public bool Equals(System.ServiceProcess.SessionChangeDescription changeDescription) { throw null; }
        public override int GetHashCode() { throw null; }
        public static bool operator ==(System.ServiceProcess.SessionChangeDescription a, System.ServiceProcess.SessionChangeDescription b) { throw null; }
        public static bool operator !=(System.ServiceProcess.SessionChangeDescription a, System.ServiceProcess.SessionChangeDescription b) { throw null; }
    }
    public enum SessionChangeReason
    {
        ConsoleConnect = 1,
        ConsoleDisconnect = 2,
        RemoteConnect = 3,
        RemoteDisconnect = 4,
        SessionLock = 7,
        SessionLogoff = 6,
        SessionLogon = 5,
        SessionRemoteControl = 9,
        SessionUnlock = 8,
    }
    [System.SerializableAttribute]
    public partial class TimeoutException : System.SystemException
    {
        public TimeoutException() { }
        protected TimeoutException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
        public TimeoutException(string message) { }
        public TimeoutException(string message, System.Exception innerException) { }
    }
}
namespace System.ServiceProcess.Design
{
    [System.MonoTODOAttribute]
    public partial class ServiceInstallerDialog : System.Windows.Forms.Form
    {
        public ServiceInstallerDialog() { }
        public string Password { get { throw null; } set { } }
        [System.MonoTODOAttribute]
        public System.ServiceProcess.Design.ServiceInstallerDialogResult Result { get { throw null; } }
        public string Username { get { throw null; } set { } }
        [System.MonoTODOAttribute]
        [System.STAThreadAttribute]
        public static void Main() { }
    }
    public enum ServiceInstallerDialogResult
    {
        Canceled = 2,
        OK = 0,
        UseSystem = 1,
    }
}
