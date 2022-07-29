// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

[assembly:System.Reflection.AssemblyVersionAttribute("4.0.0.0")]
[assembly:System.CLSCompliantAttribute(true)]
[assembly:System.Diagnostics.DebuggableAttribute((System.Diagnostics.DebuggableAttribute.DebuggingModes)(2))]
[assembly:System.Reflection.AssemblyCompanyAttribute("Mono development team")]
[assembly:System.Reflection.AssemblyCopyrightAttribute("(c) Various Mono authors")]
[assembly:System.Reflection.AssemblyDefaultAliasAttribute("System.Configuration.Install.dll")]
[assembly:System.Reflection.AssemblyDescriptionAttribute("System.Configuration.Install.dll")]
[assembly:System.Reflection.AssemblyFileVersionAttribute("4.6.57.0")]
[assembly:System.Reflection.AssemblyInformationalVersionAttribute("4.6.57.0")]
[assembly:System.Reflection.AssemblyProductAttribute("Mono Common Language Infrastructure")]
[assembly:System.Reflection.AssemblyTitleAttribute("System.Configuration.Install.dll")]
[assembly:System.Resources.NeutralResourcesLanguageAttribute("en-US")]
[assembly:System.Resources.SatelliteContractVersionAttribute("4.0.0.0")]
[assembly:System.Runtime.CompilerServices.CompilationRelaxationsAttribute(8)]
[assembly:System.Runtime.CompilerServices.ReferenceAssemblyAttribute]
[assembly:System.Runtime.CompilerServices.RuntimeCompatibilityAttribute(WrapNonExceptionThrows=true)]
[assembly:System.Runtime.InteropServices.ComCompatibleVersionAttribute(1, 0, 3300, 0)]
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
namespace System.Configuration.Install
{
    public partial class AssemblyInstaller : System.Configuration.Install.Installer
    {
        public AssemblyInstaller() { }
        public AssemblyInstaller(System.Reflection.Assembly assembly, string[] commandLine) { }
        public AssemblyInstaller(string fileName, string[] commandLine) { }
        public System.Reflection.Assembly Assembly { get { throw null; } set { } }
        public string[] CommandLine { get { throw null; } set { } }
        public override string HelpText { get { throw null; } }
        public string Path { get { throw null; } set { } }
        public bool UseNewContext { get { throw null; } set { } }
        [System.MonoTODOAttribute]
        public static void CheckIfInstallable(string assemblyName) { }
        public override void Commit(System.Collections.IDictionary savedState) { }
        public override void Install(System.Collections.IDictionary savedState) { }
        public override void Rollback(System.Collections.IDictionary savedState) { }
        public override void Uninstall(System.Collections.IDictionary savedState) { }
    }
    public abstract partial class ComponentInstaller : System.Configuration.Install.Installer
    {
        protected ComponentInstaller() { }
        public abstract void CopyFromComponent(System.ComponentModel.IComponent component);
        [System.MonoTODOAttribute("Mono always returns false")]
        public virtual bool IsEquivalentInstaller(System.Configuration.Install.ComponentInstaller otherInstaller) { throw null; }
    }
    [System.Runtime.InteropServices.GuidAttribute("1E233FE7-C16D-4512-8C3B-2E9988F08D38")]
    [System.Runtime.InteropServices.InterfaceTypeAttribute((System.Runtime.InteropServices.ComInterfaceType)(1))]
    public partial interface IManagedInstaller
    {
        [return: System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.I4)]
        int ManagedInstall([System.Runtime.InteropServices.In][System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.BStr)]string commandLine, [System.Runtime.InteropServices.In][System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.I4)]int hInstall);
    }
    public partial class InstallContext
    {
        public InstallContext() { }
        public InstallContext(string logFilePath, string[] commandLine) { }
        public System.Collections.Specialized.StringDictionary Parameters { get { throw null; } }
        public bool IsParameterTrue(string paramName) { throw null; }
        public void LogMessage(string message) { }
        protected static System.Collections.Specialized.StringDictionary ParseCommandLine(string[] args) { throw null; }
    }
    [System.ComponentModel.DefaultEventAttribute("AfterInstall")]
    public partial class Installer : System.ComponentModel.Component
    {
        public Installer() { }
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(0))]
        public System.Configuration.Install.InstallContext Context { get { throw null; } set { } }
        public virtual string HelpText { get { throw null; } }
        public System.Configuration.Install.InstallerCollection Installers { get { throw null; } }
        public System.Configuration.Install.Installer Parent { get { throw null; } set { } }
        public event System.Configuration.Install.InstallEventHandler AfterInstall { add { } remove { } }
        public event System.Configuration.Install.InstallEventHandler AfterRollback { add { } remove { } }
        public event System.Configuration.Install.InstallEventHandler AfterUninstall { add { } remove { } }
        public event System.Configuration.Install.InstallEventHandler BeforeInstall { add { } remove { } }
        public event System.Configuration.Install.InstallEventHandler BeforeRollback { add { } remove { } }
        public event System.Configuration.Install.InstallEventHandler BeforeUninstall { add { } remove { } }
        public event System.Configuration.Install.InstallEventHandler Committed { add { } remove { } }
        public event System.Configuration.Install.InstallEventHandler Committing { add { } remove { } }
        public virtual void Commit(System.Collections.IDictionary savedState) { }
        public virtual void Install(System.Collections.IDictionary stateSaver) { }
        protected virtual void OnAfterInstall(System.Collections.IDictionary savedState) { }
        protected virtual void OnAfterRollback(System.Collections.IDictionary savedState) { }
        protected virtual void OnAfterUninstall(System.Collections.IDictionary savedState) { }
        protected virtual void OnBeforeInstall(System.Collections.IDictionary savedState) { }
        protected virtual void OnBeforeRollback(System.Collections.IDictionary savedState) { }
        protected virtual void OnBeforeUninstall(System.Collections.IDictionary savedState) { }
        protected virtual void OnCommitted(System.Collections.IDictionary savedState) { }
        protected virtual void OnCommitting(System.Collections.IDictionary savedState) { }
        public virtual void Rollback(System.Collections.IDictionary savedState) { }
        public virtual void Uninstall(System.Collections.IDictionary savedState) { }
    }
    public partial class InstallerCollection : System.Collections.CollectionBase
    {
        internal InstallerCollection() { }
        public System.Configuration.Install.Installer this[int index] { get { throw null; } set { } }
        public int Add(System.Configuration.Install.Installer value) { throw null; }
        public void AddRange(System.Configuration.Install.InstallerCollection value) { }
        public void AddRange(System.Configuration.Install.Installer[] value) { }
        public bool Contains(System.Configuration.Install.Installer value) { throw null; }
        public void CopyTo(System.Configuration.Install.Installer[] array, int index) { }
        public int IndexOf(System.Configuration.Install.Installer value) { throw null; }
        public void Insert(int index, System.Configuration.Install.Installer value) { }
        protected override void OnInsert(int index, object value) { }
        protected override void OnRemove(int index, object value) { }
        protected override void OnSet(int index, object oldValue, object newValue) { }
        public void Remove(System.Configuration.Install.Installer value) { }
    }
    public partial class InstallEventArgs : System.EventArgs
    {
        public InstallEventArgs() { }
        public InstallEventArgs(System.Collections.IDictionary savedState) { }
        public System.Collections.IDictionary SavedState { get { throw null; } }
    }
    public delegate void InstallEventHandler(object sender, System.Configuration.Install.InstallEventArgs e);
    [System.SerializableAttribute]
    public partial class InstallException : System.SystemException
    {
        public InstallException() { }
        protected InstallException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
        public InstallException(string message) { }
        public InstallException(string message, System.Exception innerException) { }
    }
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    [System.Runtime.InteropServices.GuidAttribute("42EB0342-0393-448f-84AA-D4BEB0283595")]
    public partial class ManagedInstallerClass : System.Configuration.Install.IManagedInstaller
    {
        public ManagedInstallerClass() { }
        [System.MonoTODOAttribute]
        public static void InstallHelper(string[] args) { }
        [System.MonoTODOAttribute]
        int System.Configuration.Install.IManagedInstaller.ManagedInstall(string argString, int hInstall) { throw null; }
    }
    public partial class TransactedInstaller : System.Configuration.Install.Installer
    {
        public TransactedInstaller() { }
        public override void Install(System.Collections.IDictionary savedState) { }
        public override void Uninstall(System.Collections.IDictionary savedState) { }
    }
    public enum UninstallAction
    {
        NoAction = 1,
        Remove = 0,
    }
}
namespace System.Diagnostics
{
    public partial class EventLogInstaller : System.Configuration.Install.ComponentInstaller
    {
        public EventLogInstaller() { }
        [System.MonoTODOAttribute]
        [System.Runtime.InteropServices.ComVisibleAttribute(false)]
        public int CategoryCount { get { throw null; } set { } }
        [System.ComponentModel.EditorAttribute("System.Windows.Forms.Design.FileNameEditor, System.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor, System.Drawing, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
        [System.ComponentModel.TypeConverterAttribute("System.Diagnostics.Design.StringValueConverter, System.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
        [System.MonoTODOAttribute]
        [System.Runtime.InteropServices.ComVisibleAttribute(false)]
        public string CategoryResourceFile { get { throw null; } set { } }
        [System.ComponentModel.TypeConverterAttribute("System.Diagnostics.Design.StringValueConverter, System.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
        public string Log { get { throw null; } set { } }
        [System.ComponentModel.EditorAttribute("System.Windows.Forms.Design.FileNameEditor, System.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor, System.Drawing, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
        [System.ComponentModel.TypeConverterAttribute("System.Diagnostics.Design.StringValueConverter, System.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
        [System.MonoTODOAttribute]
        [System.Runtime.InteropServices.ComVisibleAttribute(false)]
        public string MessageResourceFile { get { throw null; } set { } }
        [System.ComponentModel.EditorAttribute("System.Windows.Forms.Design.FileNameEditor, System.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor, System.Drawing, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
        [System.ComponentModel.TypeConverterAttribute("System.Diagnostics.Design.StringValueConverter, System.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
        [System.MonoTODOAttribute]
        [System.Runtime.InteropServices.ComVisibleAttribute(false)]
        public string ParameterResourceFile { get { throw null; } set { } }
        [System.ComponentModel.TypeConverterAttribute("System.Diagnostics.Design.StringValueConverter, System.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
        public string Source { get { throw null; } set { } }
        [System.ComponentModel.DefaultValueAttribute((System.Configuration.Install.UninstallAction)(0))]
        public System.Configuration.Install.UninstallAction UninstallAction { get { throw null; } set { } }
        [System.MonoTODOAttribute]
        public override void CopyFromComponent(System.ComponentModel.IComponent component) { }
        [System.MonoTODOAttribute]
        public override void Install(System.Collections.IDictionary stateSaver) { }
        [System.MonoTODOAttribute]
        public override bool IsEquivalentInstaller(System.Configuration.Install.ComponentInstaller otherInstaller) { throw null; }
        [System.MonoTODOAttribute]
        public override void Rollback(System.Collections.IDictionary savedState) { }
        [System.MonoTODOAttribute]
        public override void Uninstall(System.Collections.IDictionary savedState) { }
    }
    public partial class PerformanceCounterInstaller : System.Configuration.Install.ComponentInstaller
    {
        public PerformanceCounterInstaller() { }
        [System.ComponentModel.DefaultValueAttribute("")]
        public string CategoryHelp { get { throw null; } set { } }
        [System.ComponentModel.DefaultValueAttribute("")]
        [System.ComponentModel.TypeConverterAttribute("System.Diagnostics.Design.StringValueConverter, System.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
        public string CategoryName { get { throw null; } set { } }
        [System.ComponentModel.DefaultValueAttribute((System.Diagnostics.PerformanceCounterCategoryType)(-1))]
        [System.Runtime.InteropServices.ComVisibleAttribute(false)]
        public System.Diagnostics.PerformanceCounterCategoryType CategoryType { get { throw null; } set { } }
        [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(2))]
        public System.Diagnostics.CounterCreationDataCollection Counters { get { throw null; } }
        [System.ComponentModel.DefaultValueAttribute((System.Configuration.Install.UninstallAction)(0))]
        public System.Configuration.Install.UninstallAction UninstallAction { get { throw null; } set { } }
        [System.MonoTODOAttribute]
        public override void CopyFromComponent(System.ComponentModel.IComponent component) { }
        [System.MonoTODOAttribute]
        public override void Install(System.Collections.IDictionary stateSaver) { }
        [System.MonoTODOAttribute]
        public override void Rollback(System.Collections.IDictionary savedState) { }
        [System.MonoTODOAttribute]
        public override void Uninstall(System.Collections.IDictionary savedState) { }
    }
}
