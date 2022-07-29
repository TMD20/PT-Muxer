// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

[assembly:System.Reflection.AssemblyVersionAttribute("4.2.0.0")]
[assembly:System.Diagnostics.DebuggableAttribute(System.Diagnostics.DebuggableAttribute.DebuggingModes.IgnoreSymbolStoreSequencePoints)]
[assembly:System.Reflection.AssemblyCompanyAttribute("Mono development team")]
[assembly:System.Reflection.AssemblyCopyrightAttribute("(c) Various Mono authors")]
[assembly:System.Reflection.AssemblyDefaultAliasAttribute("System.ServiceProcess.ServiceController")]
[assembly:System.Reflection.AssemblyDescriptionAttribute("System.ServiceProcess.ServiceController")]
[assembly:System.Reflection.AssemblyFileVersionAttribute("4.0.0.0")]
[assembly:System.Reflection.AssemblyInformationalVersionAttribute("4.0.0.0")]
[assembly:System.Reflection.AssemblyProductAttribute("Mono Common Language Infrastructure")]
[assembly:System.Reflection.AssemblyTitleAttribute("System.ServiceProcess.ServiceController")]
[assembly:System.Runtime.CompilerServices.CompilationRelaxationsAttribute(8)]
[assembly:System.Runtime.CompilerServices.RuntimeCompatibilityAttribute(WrapNonExceptionThrows=true)]
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
    public partial class ServiceController : System.IDisposable
    {
        public ServiceController(string name) { }
        public ServiceController(string name, string machineName) { }
        public bool CanPauseAndContinue { get { throw null; } }
        public bool CanShutdown { get { throw null; } }
        public bool CanStop { get { throw null; } }
        public System.ServiceProcess.ServiceController[] DependentServices { get { throw null; } }
        public string DisplayName { get { throw null; } }
        public string MachineName { get { throw null; } }
        public System.Runtime.InteropServices.SafeHandle ServiceHandle { get { throw null; } }
        public string ServiceName { get { throw null; } }
        public System.ServiceProcess.ServiceController[] ServicesDependedOn { get { throw null; } }
        public System.ServiceProcess.ServiceType ServiceType { get { throw null; } }
        public System.ServiceProcess.ServiceStartMode StartType { get { throw null; } }
        public System.ServiceProcess.ServiceControllerStatus Status { get { throw null; } }
        public void Continue() { }
        public void Dispose() { }
        protected virtual void Dispose(bool disposing) { }
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
    public enum ServiceStartMode
    {
        Automatic = 2,
        Boot = 0,
        Disabled = 4,
        Manual = 3,
        System = 1,
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
    public partial class TimeoutException : System.Exception
    {
        public TimeoutException() { }
        protected TimeoutException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
        public TimeoutException(string message) { }
        public TimeoutException(string message, System.Exception innerException) { }
    }
}
