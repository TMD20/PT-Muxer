// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

[assembly:System.Reflection.AssemblyVersionAttribute("4.0.0.0")]
[assembly:System.CLSCompliantAttribute(true)]
[assembly:System.Diagnostics.DebuggableAttribute((System.Diagnostics.DebuggableAttribute.DebuggingModes)(258))]
[assembly:System.Reflection.AssemblyCompanyAttribute("Mono development team")]
[assembly:System.Reflection.AssemblyCopyrightAttribute("(c) Various Mono authors")]
[assembly:System.Reflection.AssemblyDefaultAliasAttribute("System.Web.Routing.dll")]
[assembly:System.Reflection.AssemblyDescriptionAttribute("System.Web.Routing.dll")]
[assembly:System.Reflection.AssemblyFileVersionAttribute("4.0.30319.17020")]
[assembly:System.Reflection.AssemblyInformationalVersionAttribute("4.0.30319.17020")]
[assembly:System.Reflection.AssemblyProductAttribute("Mono Common Language Infrastructure")]
[assembly:System.Reflection.AssemblyTitleAttribute("System.Web.Routing.dll")]
[assembly:System.Resources.NeutralResourcesLanguageAttribute("en-US")]
[assembly:System.Resources.SatelliteContractVersionAttribute("4.0.0.0")]
[assembly:System.Runtime.CompilerServices.ReferenceAssemblyAttribute]
[assembly:System.Runtime.CompilerServices.RuntimeCompatibilityAttribute(WrapNonExceptionThrows=true)]
[assembly:System.Runtime.InteropServices.ComVisibleAttribute(false)]
[assembly:System.Security.AllowPartiallyTrustedCallersAttribute]
[assembly:System.Security.SecurityRulesAttribute((System.Security.SecurityRuleSet)(2), SkipVerificationInFullTrust=true)]
[assembly:System.Security.SecurityTransparentAttribute]
[assembly:System.Runtime.CompilerServices.TypeForwardedToAttribute(typeof(System.Web.Routing.HttpMethodConstraint))]
[assembly:System.Runtime.CompilerServices.TypeForwardedToAttribute(typeof(System.Web.Routing.IRouteConstraint))]
[assembly:System.Runtime.CompilerServices.TypeForwardedToAttribute(typeof(System.Web.Routing.IRouteHandler))]
[assembly:System.Runtime.CompilerServices.TypeForwardedToAttribute(typeof(System.Web.Routing.RequestContext))]
[assembly:System.Runtime.CompilerServices.TypeForwardedToAttribute(typeof(System.Web.Routing.Route))]
[assembly:System.Runtime.CompilerServices.TypeForwardedToAttribute(typeof(System.Web.Routing.RouteBase))]
[assembly:System.Runtime.CompilerServices.TypeForwardedToAttribute(typeof(System.Web.Routing.RouteCollection))]
[assembly:System.Runtime.CompilerServices.TypeForwardedToAttribute(typeof(System.Web.Routing.RouteData))]
[assembly:System.Runtime.CompilerServices.TypeForwardedToAttribute(typeof(System.Web.Routing.RouteDirection))]
[assembly:System.Runtime.CompilerServices.TypeForwardedToAttribute(typeof(System.Web.Routing.RouteTable))]
[assembly:System.Runtime.CompilerServices.TypeForwardedToAttribute(typeof(System.Web.Routing.RouteValueDictionary))]
[assembly:System.Runtime.CompilerServices.TypeForwardedToAttribute(typeof(System.Web.Routing.StopRoutingHandler))]
[assembly:System.Runtime.CompilerServices.TypeForwardedToAttribute(typeof(System.Web.Routing.UrlRoutingHandler))]
[assembly:System.Runtime.CompilerServices.TypeForwardedToAttribute(typeof(System.Web.Routing.UrlRoutingModule))]
[assembly:System.Runtime.CompilerServices.TypeForwardedToAttribute(typeof(System.Web.Routing.VirtualPathData))]
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
