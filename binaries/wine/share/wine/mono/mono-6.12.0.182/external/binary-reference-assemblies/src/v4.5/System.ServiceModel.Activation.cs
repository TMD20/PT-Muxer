// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

[assembly:System.Reflection.AssemblyVersionAttribute("4.0.0.0")]
[assembly:System.CLSCompliantAttribute(true)]
[assembly:System.Diagnostics.DebuggableAttribute((System.Diagnostics.DebuggableAttribute.DebuggingModes)(258))]
[assembly:System.Reflection.AssemblyCompanyAttribute("Mono development team")]
[assembly:System.Reflection.AssemblyCopyrightAttribute("(c) Various Mono authors")]
[assembly:System.Reflection.AssemblyDefaultAliasAttribute("System.ServiceModel.Activation.dll")]
[assembly:System.Reflection.AssemblyDescriptionAttribute("System.ServiceModel.Activation.dll")]
[assembly:System.Reflection.AssemblyFileVersionAttribute("4.0.30319.17020")]
[assembly:System.Reflection.AssemblyInformationalVersionAttribute("4.0.30319.17020")]
[assembly:System.Reflection.AssemblyProductAttribute("Mono Common Language Infrastructure")]
[assembly:System.Reflection.AssemblyTitleAttribute("System.ServiceModel.Activation.dll")]
[assembly:System.Resources.NeutralResourcesLanguageAttribute("en-US")]
[assembly:System.Resources.SatelliteContractVersionAttribute("4.0.0.0")]
[assembly:System.Runtime.CompilerServices.InternalsVisibleToAttribute("System.ServiceModel, PublicKey=00000000000000000400000000000000")]
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
namespace System.ServiceModel
{
    [System.Runtime.CompilerServices.TypeForwardedFromAttribute("System.ServiceModel, Version=3.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")]
    public static partial class ServiceHostingEnvironment
    {
        public static bool AspNetCompatibilityEnabled { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        public static bool MultipleSiteBindingsEnabled { get { throw null; } }
        public static void EnsureInitialized() { }
        public static void EnsureServiceAvailable(string virtualPath) { }
    }
}
namespace System.ServiceModel.Activation
{
    public abstract partial class HostedTransportConfiguration
    {
        protected HostedTransportConfiguration() { }
        public abstract System.Uri[] GetBaseAddresses(string virtualPath);
    }
    public sealed partial class ServiceActivationBuildProviderAttribute : System.Attribute
    {
        public ServiceActivationBuildProviderAttribute() { }
    }
#if WEB_DEP
    public sealed partial class ServiceBuildProvider : System.Web.Compilation.BuildProvider
#else
    public sealed partial class ServiceBuildProvider
#endif
    {
        public ServiceBuildProvider() { }
#if WEB_DEP
        public override System.Web.Compilation.CompilerType CodeCompilerType { get { throw null; } }
        public override System.Collections.ICollection VirtualPathDependencies { get { throw null; } }
        public override void GenerateCode(System.Web.Compilation.AssemblyBuilder assemblyBuilder) { }
        protected override System.CodeDom.CodeCompileUnit GetCodeCompileUnit(out System.Collections.IDictionary linePragmasTable) { linePragmasTable = default(System.Collections.IDictionary); throw null; }
        public override string GetCustomString(System.CodeDom.Compiler.CompilerResults results) { throw null; }
        public override System.Web.Compilation.BuildProviderResultFlags GetResultFlags(System.CodeDom.Compiler.CompilerResults results) { throw null; }
#endif
    }
    [System.Runtime.CompilerServices.TypeForwardedFromAttribute("System.ServiceModel, Version=3.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")]
#if SERVICEMODEL_DEP
    public partial class ServiceHostFactory : System.ServiceModel.Activation.ServiceHostFactoryBase
#else
    public partial class ServiceHostFactory
#endif
    {
        public ServiceHostFactory() { }
#if SERVICEMODEL_DEP
        [System.MonoTODOAttribute]
        public override System.ServiceModel.ServiceHostBase CreateServiceHost(string constructorString, System.Uri[] baseAddresses) { throw null; }
        [System.MonoTODOAttribute("untested")]
        protected virtual System.ServiceModel.ServiceHost CreateServiceHost(System.Type serviceType, System.Uri[] baseAddresses) { throw null; }
#endif
    }
#if SERVICEMODEL_DEP
    public partial class ServiceRoute : System.Web.Routing.Route
#else
    public partial class ServiceRoute
#endif
    {
#if SERVICEMODEL_DEP
        public ServiceRoute(string routePrefix, System.ServiceModel.Activation.ServiceHostFactoryBase serviceHostFactory, System.Type serviceType) : base (default(string), default(System.Web.Routing.IRouteHandler)) { }
#endif
    }
}
namespace System.ServiceModel.Activities.Activation
{
#if WORKFLOW_DEP
    public partial class WorkflowServiceHostFactory : System.ServiceModel.Activation.ServiceHostFactoryBase
#else
    public partial class WorkflowServiceHostFactory
#endif
    {
        public WorkflowServiceHostFactory() { }
#if WORKFLOW_DEP
        public override System.ServiceModel.ServiceHostBase CreateServiceHost(string constructorString, System.Uri[] baseAddresses) { throw null; }
        protected virtual System.ServiceModel.Activities.WorkflowServiceHost CreateWorkflowServiceHost(System.Activities.Activity activity, System.Uri[] baseAddresses) { throw null; }
        protected virtual System.ServiceModel.Activities.WorkflowServiceHost CreateWorkflowServiceHost(System.ServiceModel.Activities.WorkflowService service, System.Uri[] baseAddresses) { throw null; }
#endif
    }
}
