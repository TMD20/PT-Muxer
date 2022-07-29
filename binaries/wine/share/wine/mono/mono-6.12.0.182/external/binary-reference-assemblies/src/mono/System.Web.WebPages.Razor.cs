// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

[assembly:System.Reflection.AssemblyVersionAttribute("2.0.0.0")]
[assembly:System.CLSCompliantAttribute(true)]
[assembly:System.Diagnostics.DebuggableAttribute((System.Diagnostics.DebuggableAttribute.DebuggingModes)(2))]
[assembly:System.Reflection.AssemblyCompanyAttribute("Microsoft Corporation")]
[assembly:System.Reflection.AssemblyConfigurationAttribute("")]
[assembly:System.Reflection.AssemblyCopyrightAttribute("© Microsoft Corporation. All rights reserved.")]
[assembly:System.Reflection.AssemblyDefaultAliasAttribute("System.Web.WebPages.Razor.dll")]
[assembly:System.Reflection.AssemblyDescriptionAttribute("")]
[assembly:System.Reflection.AssemblyFileVersionAttribute("2.0.0.0")]
[assembly:System.Reflection.AssemblyInformationalVersionAttribute("4.7.2046.0")]
[assembly:System.Reflection.AssemblyProductAttribute("Microsoft ASP.NET Web Pages")]
[assembly:System.Reflection.AssemblyTitleAttribute("System.Web.WebPages.Razor")]
[assembly:System.Reflection.AssemblyTrademarkAttribute("")]
[assembly:System.Resources.NeutralResourcesLanguageAttribute("en-US")]
[assembly:System.Resources.SatelliteContractVersionAttribute("4.0.0.0")]
[assembly:System.Runtime.CompilerServices.CompilationRelaxationsAttribute(8)]
[assembly:System.Runtime.CompilerServices.ReferenceAssemblyAttribute]
[assembly:System.Runtime.CompilerServices.RuntimeCompatibilityAttribute(WrapNonExceptionThrows=true)]
[assembly:System.Runtime.InteropServices.ComVisibleAttribute(false)]
[assembly:System.Security.SecurityTransparentAttribute]
[assembly:System.Web.PreApplicationStartMethodAttribute(typeof(System.Web.WebPages.Razor.PreApplicationStartCode), "Start")]
namespace System.Web.WebPages.Razor
{
    public partial class CompilingPathEventArgs : System.EventArgs
    {
        public CompilingPathEventArgs(string virtualPath, System.Web.WebPages.Razor.WebPageRazorHost host) { }
        public System.Web.WebPages.Razor.WebPageRazorHost Host { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public string VirtualPath { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
    }
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    public static partial class PreApplicationStartCode
    {
        public static void Start() { }
    }
    [System.Web.Compilation.BuildProviderAppliesToAttribute((System.Web.Compilation.BuildProviderAppliesTo)(3))]
    public partial class RazorBuildProvider : System.Web.Compilation.BuildProvider
    {
        public RazorBuildProvider() { }
        public System.Web.Compilation.AssemblyBuilder AssemblyBuilder { get { throw null; } }
        public override System.Web.Compilation.CompilerType CodeCompilerType { get { throw null; } }
        public new string VirtualPath { get { throw null; } }
        public override System.Collections.ICollection VirtualPathDependencies { get { throw null; } }
        public static event System.EventHandler<System.Web.Razor.Generator.CodeGenerationCompleteEventArgs> CodeGenerationCompleted { add { } remove { } }
        public static event System.EventHandler CodeGenerationStarted { add { } remove { } }
        public static event System.EventHandler<System.Web.WebPages.Razor.CompilingPathEventArgs> CompilingPath { add { } remove { } }
        public void AddVirtualPathDependency(string dependency) { }
        protected internal virtual System.Web.WebPages.Razor.WebPageRazorHost CreateHost() { throw null; }
        public override void GenerateCode(System.Web.Compilation.AssemblyBuilder assemblyBuilder) { }
        public override System.Type GetGeneratedType(System.CodeDom.Compiler.CompilerResults results) { throw null; }
        protected internal virtual System.Web.WebPages.Razor.WebPageRazorHost GetHostFromConfig() { throw null; }
        protected internal virtual System.IO.TextReader InternalOpenReader() { throw null; }
        protected virtual void OnBeforeCompilePath(System.Web.WebPages.Razor.CompilingPathEventArgs args) { }
    }
    public partial class WebCodeRazorHost : System.Web.WebPages.Razor.WebPageRazorHost
    {
        public WebCodeRazorHost(string virtualPath) : base (default(string)) { }
        public WebCodeRazorHost(string virtualPath, string physicalPath) : base (default(string)) { }
        protected override string GetClassName(string virtualPath) { throw null; }
        public override void PostProcessGeneratedCode(System.Web.Razor.Generator.CodeGeneratorContext context) { }
    }
    public partial class WebPageRazorHost : System.Web.Razor.RazorEngineHost
    {
        public WebPageRazorHost(string virtualPath) { }
        public WebPageRazorHost(string virtualPath, string physicalPath) { }
        public override System.Web.Razor.RazorCodeLanguage CodeLanguage { get { throw null; } protected set { } }
        public override string DefaultBaseClass { get { throw null; } set { } }
        public override string DefaultClassName { get { throw null; } set { } }
        public bool DefaultDebugCompilation { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public string DefaultPageBaseClass { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public override string InstrumentedSourceFilePath { get { throw null; } set { } }
        public bool IsSpecialPage { get { throw null; } }
        public string PhysicalPath { get { throw null; } set { } }
        public string VirtualPath { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        public static void AddGlobalImport(string ns) { }
        public override System.Web.Razor.Parser.ParserBase CreateMarkupParser() { throw null; }
        protected virtual string GetClassName(string virtualPath) { throw null; }
        protected virtual System.Web.Razor.RazorCodeLanguage GetCodeLanguage() { throw null; }
        public static System.Collections.Generic.IEnumerable<string> GetGlobalImports() { throw null; }
        public override void PostProcessGeneratedCode(System.Web.Razor.Generator.CodeGeneratorContext context) { }
        protected void RegisterSpecialFile(string fileName, string baseTypeName) { }
        protected void RegisterSpecialFile(string fileName, System.Type baseType) { }
    }
    public partial class WebRazorHostFactory
    {
        public WebRazorHostFactory() { }
        public static void ApplyConfigurationToHost(System.Web.WebPages.Razor.Configuration.RazorPagesSection config, System.Web.WebPages.Razor.WebPageRazorHost host) { }
        public static System.Web.WebPages.Razor.WebPageRazorHost CreateDefaultHost(string virtualPath) { throw null; }
        public static System.Web.WebPages.Razor.WebPageRazorHost CreateDefaultHost(string virtualPath, string physicalPath) { throw null; }
        public virtual System.Web.WebPages.Razor.WebPageRazorHost CreateHost(string virtualPath, string physicalPath) { throw null; }
        public static System.Web.WebPages.Razor.WebPageRazorHost CreateHostFromConfig(string virtualPath) { throw null; }
        public static System.Web.WebPages.Razor.WebPageRazorHost CreateHostFromConfig(string virtualPath, string physicalPath) { throw null; }
        public static System.Web.WebPages.Razor.WebPageRazorHost CreateHostFromConfig(System.Web.WebPages.Razor.Configuration.RazorWebSectionGroup config, string virtualPath) { throw null; }
        public static System.Web.WebPages.Razor.WebPageRazorHost CreateHostFromConfig(System.Web.WebPages.Razor.Configuration.RazorWebSectionGroup config, string virtualPath, string physicalPath) { throw null; }
    }
}
namespace System.Web.WebPages.Razor.Configuration
{
    public partial class HostSection : System.Configuration.ConfigurationSection
    {
        public static readonly string SectionName;
        public HostSection() { }
        [System.Configuration.ConfigurationPropertyAttribute("factoryType", IsRequired=true, DefaultValue=null)]
        public string FactoryType { get { throw null; } set { } }
    }
    public partial class RazorPagesSection : System.Configuration.ConfigurationSection
    {
        public static readonly string SectionName;
        public RazorPagesSection() { }
        [System.Configuration.ConfigurationPropertyAttribute("namespaces", IsRequired=true)]
        public System.Web.Configuration.NamespaceCollection Namespaces { get { throw null; } set { } }
        [System.Configuration.ConfigurationPropertyAttribute("pageBaseType", IsRequired=true)]
        public string PageBaseType { get { throw null; } set { } }
    }
    public partial class RazorWebSectionGroup : System.Configuration.ConfigurationSectionGroup
    {
        public static readonly string GroupName;
        public RazorWebSectionGroup() { }
        [System.Configuration.ConfigurationPropertyAttribute("host", IsRequired=false)]
        public System.Web.WebPages.Razor.Configuration.HostSection Host { get { throw null; } set { } }
        [System.Configuration.ConfigurationPropertyAttribute("pages", IsRequired=false)]
        public System.Web.WebPages.Razor.Configuration.RazorPagesSection Pages { get { throw null; } set { } }
    }
}
