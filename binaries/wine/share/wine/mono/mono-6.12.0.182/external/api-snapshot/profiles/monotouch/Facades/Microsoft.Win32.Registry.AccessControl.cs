// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

[assembly:System.Reflection.AssemblyVersionAttribute("4.0.0.0")]
[assembly:System.Diagnostics.DebuggableAttribute(System.Diagnostics.DebuggableAttribute.DebuggingModes.IgnoreSymbolStoreSequencePoints)]
[assembly:System.Reflection.AssemblyCompanyAttribute("Mono development team")]
[assembly:System.Reflection.AssemblyCopyrightAttribute("(c) Various Mono authors")]
[assembly:System.Reflection.AssemblyDefaultAliasAttribute("Microsoft.Win32.Registry.AccessControl")]
[assembly:System.Reflection.AssemblyDescriptionAttribute("Microsoft.Win32.Registry.AccessControl")]
[assembly:System.Reflection.AssemblyFileVersionAttribute("4.0.0.0")]
[assembly:System.Reflection.AssemblyInformationalVersionAttribute("4.0.0.0")]
[assembly:System.Reflection.AssemblyProductAttribute("Mono Common Language Infrastructure")]
[assembly:System.Reflection.AssemblyTitleAttribute("Microsoft.Win32.Registry.AccessControl")]
[assembly:System.Runtime.CompilerServices.CompilationRelaxationsAttribute(8)]
[assembly:System.Runtime.CompilerServices.RuntimeCompatibilityAttribute(WrapNonExceptionThrows=true)]
[assembly:System.Runtime.CompilerServices.TypeForwardedToAttribute(typeof(System.Security.AccessControl.RegistryAccessRule))]
[assembly:System.Runtime.CompilerServices.TypeForwardedToAttribute(typeof(System.Security.AccessControl.RegistryAuditRule))]
[assembly:System.Runtime.CompilerServices.TypeForwardedToAttribute(typeof(System.Security.AccessControl.RegistrySecurity))]
namespace Microsoft.Win32
{
    public static partial class RegistryAclExtensions
    {
        public static System.Security.AccessControl.RegistrySecurity GetAccessControl(this Microsoft.Win32.RegistryKey key) { throw null; }
        public static System.Security.AccessControl.RegistrySecurity GetAccessControl(this Microsoft.Win32.RegistryKey key, System.Security.AccessControl.AccessControlSections includeSections) { throw null; }
        public static void SetAccessControl(this Microsoft.Win32.RegistryKey key, System.Security.AccessControl.RegistrySecurity registrySecurity) { }
    }
}
