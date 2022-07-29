// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

[assembly:System.Reflection.AssemblyVersionAttribute("4.0.0.0")]
[assembly:System.CLSCompliantAttribute(true)]
[assembly:System.Diagnostics.DebuggableAttribute((System.Diagnostics.DebuggableAttribute.DebuggingModes)(2))]
[assembly:System.Reflection.AssemblyCompanyAttribute("Mono development team")]
[assembly:System.Reflection.AssemblyCopyrightAttribute("(c) Various Mono authors")]
[assembly:System.Reflection.AssemblyDefaultAliasAttribute("System.ServiceModel.Activation.dll")]
[assembly:System.Reflection.AssemblyDescriptionAttribute("System.ServiceModel.Activation.dll")]
[assembly:System.Reflection.AssemblyFileVersionAttribute("4.7.2558.0")]
[assembly:System.Reflection.AssemblyInformationalVersionAttribute("4.7.2558.0")]
[assembly:System.Reflection.AssemblyProductAttribute("Mono Common Language Infrastructure")]
[assembly:System.Reflection.AssemblyTitleAttribute("System.ServiceModel.Activation.dll")]
[assembly:System.Resources.NeutralResourcesLanguageAttribute("en-US")]
[assembly:System.Resources.SatelliteContractVersionAttribute("4.0.0.0")]
[assembly:System.Runtime.CompilerServices.CompilationRelaxationsAttribute(8)]
[assembly:System.Runtime.CompilerServices.ReferenceAssemblyAttribute]
[assembly:System.Runtime.CompilerServices.RuntimeCompatibilityAttribute(WrapNonExceptionThrows=true)]
[assembly:System.Runtime.InteropServices.ComVisibleAttribute(false)]
[assembly:System.Runtime.InteropServices.DefaultDllImportSearchPathsAttribute((System.Runtime.InteropServices.DllImportSearchPath)(2050))]
[assembly:System.Security.AllowPartiallyTrustedCallersAttribute]
[assembly:System.Security.SecurityRulesAttribute((System.Security.SecurityRuleSet)(1), SkipVerificationInFullTrust=true)]
[assembly:System.Security.Permissions.SecurityPermissionAttribute(System.Security.Permissions.SecurityAction.RequestMinimum, Execution=true)]
namespace System.ServiceModel
{
    [System.Runtime.CompilerServices.TypeForwardedFromAttribute("System.ServiceModel, Version=3.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")]
    public static partial class ServiceHostingEnvironment
    {
        public static bool AspNetCompatibilityEnabled { get { throw null; } }
        public static bool MultipleSiteBindingsEnabled { get { throw null; } }
        [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
        public static void EnsureInitialized() { }
        public static void EnsureServiceAvailable(string virtualPath) { }
    }
}
namespace System.ServiceModel.Activation
{
    [System.Runtime.CompilerServices.TypeForwardedFromAttribute("System.ServiceModel, Version=3.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")]
    public abstract partial class HostedTransportConfiguration
    {
        protected HostedTransportConfiguration() { }
        public abstract System.Uri[] GetBaseAddresses(string virtualPath);
    }
    [System.AttributeUsageAttribute((System.AttributeTargets)(4))]
    public sealed partial class ServiceActivationBuildProviderAttribute : System.Attribute
    {
        public ServiceActivationBuildProviderAttribute() { }
    }
    [System.Security.SecurityCriticalAttribute((System.Security.SecurityCriticalScope)(1))]
#if SERVICEMODEL_DEP
    [System.ServiceModel.Activation.ServiceActivationBuildProviderAttribute]
#endif
#if WEB_DEP
    [System.Web.Compilation.BuildProviderAppliesToAttribute((System.Web.Compilation.BuildProviderAppliesTo)(1))]
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
        public override System.ServiceModel.ServiceHostBase CreateServiceHost(string constructorString, System.Uri[] baseAddresses) { throw null; }
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
