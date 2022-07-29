// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

[assembly:System.Reflection.AssemblyVersionAttribute("2.0.0.0")]
[assembly:System.CLSCompliantAttribute(true)]
[assembly:System.Diagnostics.DebuggableAttribute(System.Diagnostics.DebuggableAttribute.DebuggingModes.IgnoreSymbolStoreSequencePoints)]
[assembly:System.Reflection.AssemblyCompanyAttribute("Microsoft Corporation")]
[assembly:System.Reflection.AssemblyConfigurationAttribute("")]
[assembly:System.Reflection.AssemblyCopyrightAttribute("© Microsoft Corporation. All rights reserved.")]
[assembly:System.Reflection.AssemblyDefaultAliasAttribute("System.Web.WebPages.Deployment.dll")]
[assembly:System.Reflection.AssemblyDescriptionAttribute("")]
[assembly:System.Reflection.AssemblyFileVersionAttribute("2.0.0.0")]
[assembly:System.Reflection.AssemblyInformationalVersionAttribute("4.6.57.0")]
[assembly:System.Reflection.AssemblyProductAttribute("Microsoft ASP.NET Web Pages")]
[assembly:System.Reflection.AssemblyTitleAttribute("System.Web.WebPages.Deployment")]
[assembly:System.Reflection.AssemblyTrademarkAttribute("")]
[assembly:System.Resources.NeutralResourcesLanguageAttribute("en-US")]
[assembly:System.Runtime.CompilerServices.CompilationRelaxationsAttribute(8)]
[assembly:System.Runtime.CompilerServices.InternalsVisibleToAttribute("System.Web.WebPages.Deployment.Test, PublicKey=0024000004800000940000000602000000240000525341310004000001000100b5fc90e7027f67871e773a8fde8938c81dd402ba65b9201d60593e96c492651e889cc13f1415ebb53fac1131ae0bd333c5ee6021672d9718ea31a8aebd0da0072f25d87dba6fc90ffd598ed4da35e44c398c454307e8e33b8426143daec9f596836f97c8f74750e5975c64e2189f45def46b2a2b1247adc3652bf5c308055da9")]
[assembly:System.Runtime.CompilerServices.RuntimeCompatibilityAttribute(WrapNonExceptionThrows=true)]
[assembly:System.Runtime.InteropServices.ComVisibleAttribute(false)]
[assembly:System.Security.SecurityTransparentAttribute]
[assembly:System.Web.PreApplicationStartMethodAttribute(typeof(System.Web.WebPages.Deployment.PreApplicationStartCode), "Start")]
namespace System.Web.WebPages.Deployment
{
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    public static partial class PreApplicationStartCode
    {
        public static void Start() { }
    }
    public static partial class WebPagesDeployment
    {
        public static string GetAssemblyPath(System.Version version) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public static System.Collections.Generic.IDictionary<string, System.Version> GetIncompatibleDependencies(string appPath) { throw null; }
        public static System.Version GetMaxVersion() { throw null; }
        [System.ObsoleteAttribute("This method is obsolete and is meant for legacy code. Use GetVersionWithoutEnabled instead.")]
        public static System.Version GetVersion(string path) { throw null; }
        public static System.Version GetVersionWithoutEnabledCheck(string path) { throw null; }
        public static System.Collections.Generic.IEnumerable<System.Reflection.AssemblyName> GetWebPagesAssemblies() { throw null; }
        public static bool IsEnabled(string path) { throw null; }
        public static bool IsExplicitlyDisabled(string path) { throw null; }
    }
}
