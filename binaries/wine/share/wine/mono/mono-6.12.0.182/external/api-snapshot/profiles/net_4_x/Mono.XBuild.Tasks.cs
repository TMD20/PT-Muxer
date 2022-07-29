// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

[assembly:System.Reflection.AssemblyVersionAttribute("4.0.0.0")]
[assembly:System.CLSCompliantAttribute(true)]
[assembly:System.Diagnostics.DebuggableAttribute(System.Diagnostics.DebuggableAttribute.DebuggingModes.IgnoreSymbolStoreSequencePoints)]
[assembly:System.Reflection.AssemblyCompanyAttribute("Mono development team")]
[assembly:System.Reflection.AssemblyCopyrightAttribute("(c) Various Mono authors")]
[assembly:System.Reflection.AssemblyDefaultAliasAttribute("Mono.XBuild.Tasks.dll")]
[assembly:System.Reflection.AssemblyDescriptionAttribute("Mono.XBuild.Tasks.dll")]
[assembly:System.Reflection.AssemblyFileVersionAttribute("4.6.57.0")]
[assembly:System.Reflection.AssemblyInformationalVersionAttribute("4.6.57.0")]
[assembly:System.Reflection.AssemblyProductAttribute("Mono Common Language Infrastructure")]
[assembly:System.Reflection.AssemblyTitleAttribute("Mono.XBuild.Tasks.dll")]
[assembly:System.Resources.NeutralResourcesLanguageAttribute("en-US")]
[assembly:System.Resources.SatelliteContractVersionAttribute("4.0.0.0")]
[assembly:System.Runtime.CompilerServices.CompilationRelaxationsAttribute(8)]
[assembly:System.Runtime.CompilerServices.RuntimeCompatibilityAttribute(WrapNonExceptionThrows=true)]
[assembly:System.Runtime.InteropServices.ComVisibleAttribute(false)]
namespace Mono.PkgConfig
{
    public partial interface IPcFileCacheContext : Mono.PkgConfig.IPcFileCacheContext<Mono.PkgConfig.PackageInfo>
    {
    }
    public partial interface IPcFileCacheContext<TP> where TP : Mono.PkgConfig.PackageInfo, new()
    {
        bool IsCustomDataComplete(string pcfile, TP pkg);
        void ReportError(string message, System.Exception ex);
        void StoreCustomData(Mono.PkgConfig.PcFile pcfile, TP pkg);
    }
    public partial class LibraryPackageInfo : Mono.PkgConfig.PackageInfo
    {
        public LibraryPackageInfo() { }
        public bool IsGacPackage { get { throw null; } set { } }
        protected internal override bool IsValidPackage { get { throw null; } }
    }
    public partial class LibraryPcFileCache : Mono.PkgConfig.PcFileCache<Mono.PkgConfig.LibraryPackageInfo>
    {
        public LibraryPcFileCache(Mono.PkgConfig.IPcFileCacheContext<Mono.PkgConfig.LibraryPackageInfo> ctx) : base (default(Mono.PkgConfig.IPcFileCacheContext<Mono.PkgConfig.LibraryPackageInfo>)) { }
        protected override string CacheDirectory { get { throw null; } }
        public Mono.PkgConfig.PackageAssemblyInfo GetAssemblyLocation(string fullName) { throw null; }
        public Mono.PkgConfig.PackageAssemblyInfo GetAssemblyLocation(string fullName, System.Collections.Generic.IEnumerable<string> searchPaths) { throw null; }
        public static string NormalizeAsmName(string name) { throw null; }
        protected override void ParsePackageInfo(Mono.PkgConfig.PcFile file, Mono.PkgConfig.LibraryPackageInfo pinfo) { }
        protected override void ReadPackageContent(System.Xml.XmlReader tr, Mono.PkgConfig.LibraryPackageInfo pinfo) { }
        public System.Collections.Generic.IEnumerable<Mono.PkgConfig.PackageAssemblyInfo> ResolveAssemblyName(string name) { throw null; }
        public System.Collections.Generic.IEnumerable<Mono.PkgConfig.PackageAssemblyInfo> ResolveAssemblyName(string name, System.Collections.Generic.IEnumerable<string> searchPaths) { throw null; }
        protected override void WritePackageContent(System.Xml.XmlTextWriter tw, string file, Mono.PkgConfig.LibraryPackageInfo pinfo) { }
    }
    public partial class PackageAssemblyInfo
    {
        public string Culture;
        public string Name;
        public string PublicKeyToken;
        public string Version;
        public PackageAssemblyInfo() { }
        public string File { get { throw null; } set { } }
        public string FullName { get { throw null; } }
        public Mono.PkgConfig.LibraryPackageInfo ParentPackage { get { throw null; } set { } }
        public void Update(System.Reflection.AssemblyName aname) { }
        public void UpdateFromFile(string file) { }
    }
    public partial class PackageInfo
    {
        public PackageInfo() { }
        public string Description { get { throw null; } set { } }
        protected internal virtual bool IsValidPackage { get { throw null; } }
        public string Name { get { throw null; } set { } }
        public string Requires { get { throw null; } set { } }
        public string Version { get { throw null; } set { } }
        public string GetData(string name) { throw null; }
        public void RemoveData(string name) { }
        public void SetData(string name, string value) { }
    }
    public partial class PcFile
    {
        public PcFile() { }
        public string Description { get { throw null; } set { } }
        public string FilePath { get { throw null; } set { } }
        public bool HasErrors { get { throw null; } set { } }
        public string Libs { get { throw null; } set { } }
        public string Name { get { throw null; } set { } }
        public string Requires { get { throw null; } set { } }
        public string Version { get { throw null; } set { } }
        public string GetVariable(string varName) { throw null; }
        public void Load(string pcfile) { }
    }
    public abstract partial class PcFileCache : Mono.PkgConfig.PcFileCache<Mono.PkgConfig.PackageInfo>
    {
        public PcFileCache(Mono.PkgConfig.IPcFileCacheContext ctx) : base (default(Mono.PkgConfig.IPcFileCacheContext<Mono.PkgConfig.PackageInfo>)) { }
    }
    public abstract partial class PcFileCache<TP> where TP : Mono.PkgConfig.PackageInfo, new()
    {
        public PcFileCache(Mono.PkgConfig.IPcFileCacheContext<TP> ctx) { }
        protected abstract string CacheDirectory { get; }
        public object SyncRoot { get { throw null; } }
        public TP GetPackageInfo(string file) { throw null; }
        public TP GetPackageInfoByName(string name) { throw null; }
        public TP GetPackageInfoByName(string name, System.Collections.Generic.IEnumerable<string> pkgConfigDirs) { throw null; }
        public System.Collections.Generic.IEnumerable<TP> GetPackages() { throw null; }
        public System.Collections.Generic.IEnumerable<TP> GetPackages(System.Collections.Generic.IEnumerable<string> pkgConfigDirs) { throw null; }
        public System.Collections.Generic.IEnumerable<string> GetPkgconfigPaths(string prefix, string pkgConfigPath, string pkgConfigLibdir) { throw null; }
        protected virtual void ParsePackageInfo(Mono.PkgConfig.PcFile file, TP pinfo) { }
        protected virtual void ReadPackageContent(System.Xml.XmlReader tr, TP pinfo) { }
        public void Save() { }
        public void Update() { }
        public void Update(System.Collections.Generic.IEnumerable<string> pkgConfigDirs) { }
        protected virtual void WritePackageContent(System.Xml.XmlTextWriter tw, string file, TP pinfo) { }
    }
}
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
