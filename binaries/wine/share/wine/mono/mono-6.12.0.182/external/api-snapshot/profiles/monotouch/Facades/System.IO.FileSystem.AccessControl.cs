// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

[assembly:System.Reflection.AssemblyVersionAttribute("4.0.2.0")]
[assembly:System.Diagnostics.DebuggableAttribute(System.Diagnostics.DebuggableAttribute.DebuggingModes.IgnoreSymbolStoreSequencePoints)]
[assembly:System.Reflection.AssemblyCompanyAttribute("Mono development team")]
[assembly:System.Reflection.AssemblyCopyrightAttribute("(c) Various Mono authors")]
[assembly:System.Reflection.AssemblyDefaultAliasAttribute("System.IO.FileSystem.AccessControl")]
[assembly:System.Reflection.AssemblyDescriptionAttribute("System.IO.FileSystem.AccessControl")]
[assembly:System.Reflection.AssemblyFileVersionAttribute("4.0.0.0")]
[assembly:System.Reflection.AssemblyInformationalVersionAttribute("4.0.0.0")]
[assembly:System.Reflection.AssemblyProductAttribute("Mono Common Language Infrastructure")]
[assembly:System.Reflection.AssemblyTitleAttribute("System.IO.FileSystem.AccessControl")]
[assembly:System.Runtime.CompilerServices.CompilationRelaxationsAttribute(8)]
[assembly:System.Runtime.CompilerServices.RuntimeCompatibilityAttribute(WrapNonExceptionThrows=true)]
[assembly:System.Runtime.CompilerServices.TypeForwardedToAttribute(typeof(System.Security.AccessControl.DirectoryObjectSecurity))]
[assembly:System.Runtime.CompilerServices.TypeForwardedToAttribute(typeof(System.Security.AccessControl.DirectorySecurity))]
[assembly:System.Runtime.CompilerServices.TypeForwardedToAttribute(typeof(System.Security.AccessControl.FileSecurity))]
[assembly:System.Runtime.CompilerServices.TypeForwardedToAttribute(typeof(System.Security.AccessControl.FileSystemAccessRule))]
[assembly:System.Runtime.CompilerServices.TypeForwardedToAttribute(typeof(System.Security.AccessControl.FileSystemAuditRule))]
[assembly:System.Runtime.CompilerServices.TypeForwardedToAttribute(typeof(System.Security.AccessControl.FileSystemRights))]
[assembly:System.Runtime.CompilerServices.TypeForwardedToAttribute(typeof(System.Security.AccessControl.FileSystemSecurity))]
namespace System.IO
{
    public static partial class FileSystemAclExtensions
    {
        public static System.Security.AccessControl.DirectorySecurity GetAccessControl(this System.IO.DirectoryInfo directoryInfo) { throw null; }
        public static System.Security.AccessControl.DirectorySecurity GetAccessControl(this System.IO.DirectoryInfo directoryInfo, System.Security.AccessControl.AccessControlSections includeSections) { throw null; }
        public static System.Security.AccessControl.FileSecurity GetAccessControl(this System.IO.FileInfo fileInfo) { throw null; }
        public static System.Security.AccessControl.FileSecurity GetAccessControl(this System.IO.FileInfo fileInfo, System.Security.AccessControl.AccessControlSections includeSections) { throw null; }
        public static System.Security.AccessControl.FileSecurity GetAccessControl(this System.IO.FileStream fileStream) { throw null; }
        public static void SetAccessControl(this System.IO.DirectoryInfo directoryInfo, System.Security.AccessControl.DirectorySecurity directorySecurity) { }
        public static void SetAccessControl(this System.IO.FileInfo fileInfo, System.Security.AccessControl.FileSecurity fileSecurity) { }
        public static void SetAccessControl(this System.IO.FileStream fileStream, System.Security.AccessControl.FileSecurity fileSecurity) { }
    }
}
