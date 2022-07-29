// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

[assembly:System.Reflection.AssemblyVersionAttribute("1.0.0.0")]
[assembly:System.CLSCompliantAttribute(true)]
[assembly:System.Diagnostics.DebuggableAttribute(System.Diagnostics.DebuggableAttribute.DebuggingModes.IgnoreSymbolStoreSequencePoints)]
[assembly:System.Reflection.AssemblyCompanyAttribute("Novell, Inc")]
[assembly:System.Reflection.AssemblyConfigurationAttribute("")]
[assembly:System.Reflection.AssemblyCopyrightAttribute("© Novell, Inc. All rights reserved.")]
[assembly:System.Reflection.AssemblyDescriptionAttribute("")]
[assembly:System.Reflection.AssemblyFileVersionAttribute("1.0.20105.407")]
[assembly:System.Reflection.AssemblyProductAttribute("ASP.Net WebPages")]
[assembly:System.Reflection.AssemblyTitleAttribute("Microsoft.Web.Infrastructure")]
[assembly:System.Reflection.AssemblyTrademarkAttribute("")]
[assembly:System.Resources.NeutralResourcesLanguageAttribute("en-US")]
[assembly:System.Runtime.CompilerServices.CompilationRelaxationsAttribute(8)]
[assembly:System.Runtime.CompilerServices.RuntimeCompatibilityAttribute(WrapNonExceptionThrows=true)]
[assembly:System.Runtime.InteropServices.ComVisibleAttribute(false)]
[assembly:System.Security.AllowPartiallyTrustedCallersAttribute]
namespace Microsoft.Web.Infrastructure
{
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    public static partial class HttpContextHelper
    {
        [System.Security.SecuritySafeCriticalAttribute]
        public static void ExecuteInNullContext(System.Action action) { }
    }
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    public static partial class InfrastructureHelper
    {
        [System.Security.SecuritySafeCriticalAttribute]
        public static bool IsCodeDomDefinedExtension(string extension) { throw null; }
        [System.Security.SecuritySafeCriticalAttribute]
        public static void UnloadAppDomain() { }
    }
}
namespace Microsoft.Web.Infrastructure.DynamicModuleHelper
{
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    public static partial class DynamicModuleUtility
    {
        [System.Security.SecuritySafeCriticalAttribute]
        public static void RegisterModule(System.Type moduleType) { }
    }
}
namespace Microsoft.Web.Infrastructure.DynamicValidationHelper
{
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    public static partial class ValidationUtility
    {
        [System.Security.SecuritySafeCriticalAttribute]
        public static void EnableDynamicValidation(System.Web.HttpContext context) { }
        [System.Security.SecuritySafeCriticalAttribute]
        public static void GetUnvalidatedCollections(System.Web.HttpContext context, out System.Func<System.Collections.Specialized.NameValueCollection> formGetter, out System.Func<System.Collections.Specialized.NameValueCollection> queryStringGetter) { throw null; }
        [System.Security.SecuritySafeCriticalAttribute]
        public static System.Nullable<bool> IsValidationEnabled(System.Web.HttpContext context) { throw null; }
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
