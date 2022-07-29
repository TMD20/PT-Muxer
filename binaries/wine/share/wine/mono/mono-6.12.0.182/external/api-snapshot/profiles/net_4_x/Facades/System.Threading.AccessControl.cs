// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

[assembly:System.Reflection.AssemblyVersionAttribute("4.0.2.0")]
[assembly:System.Diagnostics.DebuggableAttribute(System.Diagnostics.DebuggableAttribute.DebuggingModes.IgnoreSymbolStoreSequencePoints)]
[assembly:System.Reflection.AssemblyCompanyAttribute("Mono development team")]
[assembly:System.Reflection.AssemblyCopyrightAttribute("(c) Various Mono authors")]
[assembly:System.Reflection.AssemblyDefaultAliasAttribute("System.Threading.AccessControl")]
[assembly:System.Reflection.AssemblyDescriptionAttribute("System.Threading.AccessControl")]
[assembly:System.Reflection.AssemblyFileVersionAttribute("4.0.0.0")]
[assembly:System.Reflection.AssemblyInformationalVersionAttribute("4.0.0.0")]
[assembly:System.Reflection.AssemblyProductAttribute("Mono Common Language Infrastructure")]
[assembly:System.Reflection.AssemblyTitleAttribute("System.Threading.AccessControl")]
[assembly:System.Runtime.CompilerServices.CompilationRelaxationsAttribute(8)]
[assembly:System.Runtime.CompilerServices.RuntimeCompatibilityAttribute(WrapNonExceptionThrows=true)]
[assembly:System.Runtime.CompilerServices.TypeForwardedToAttribute(typeof(System.Security.AccessControl.EventWaitHandleAccessRule))]
[assembly:System.Runtime.CompilerServices.TypeForwardedToAttribute(typeof(System.Security.AccessControl.EventWaitHandleAuditRule))]
[assembly:System.Runtime.CompilerServices.TypeForwardedToAttribute(typeof(System.Security.AccessControl.EventWaitHandleRights))]
[assembly:System.Runtime.CompilerServices.TypeForwardedToAttribute(typeof(System.Security.AccessControl.EventWaitHandleSecurity))]
[assembly:System.Runtime.CompilerServices.TypeForwardedToAttribute(typeof(System.Security.AccessControl.MutexAccessRule))]
[assembly:System.Runtime.CompilerServices.TypeForwardedToAttribute(typeof(System.Security.AccessControl.MutexAuditRule))]
[assembly:System.Runtime.CompilerServices.TypeForwardedToAttribute(typeof(System.Security.AccessControl.MutexRights))]
[assembly:System.Runtime.CompilerServices.TypeForwardedToAttribute(typeof(System.Security.AccessControl.MutexSecurity))]
[assembly:System.Runtime.CompilerServices.TypeForwardedToAttribute(typeof(System.Security.AccessControl.SemaphoreAccessRule))]
[assembly:System.Runtime.CompilerServices.TypeForwardedToAttribute(typeof(System.Security.AccessControl.SemaphoreAuditRule))]
[assembly:System.Runtime.CompilerServices.TypeForwardedToAttribute(typeof(System.Security.AccessControl.SemaphoreRights))]
[assembly:System.Runtime.CompilerServices.TypeForwardedToAttribute(typeof(System.Security.AccessControl.SemaphoreSecurity))]
namespace System.Threading
{
    public static partial class ThreadingAclExtensions
    {
        public static System.Security.AccessControl.EventWaitHandleSecurity GetAccessControl(this System.Threading.EventWaitHandle handle) { throw null; }
        public static System.Security.AccessControl.MutexSecurity GetAccessControl(this System.Threading.Mutex mutex) { throw null; }
        public static System.Security.AccessControl.SemaphoreSecurity GetAccessControl(this System.Threading.Semaphore semaphore) { throw null; }
        public static void SetAccessControl(this System.Threading.EventWaitHandle handle, System.Security.AccessControl.EventWaitHandleSecurity eventSecurity) { }
        public static void SetAccessControl(this System.Threading.Mutex mutex, System.Security.AccessControl.MutexSecurity mutexSecurity) { }
        public static void SetAccessControl(this System.Threading.Semaphore semaphore, System.Security.AccessControl.SemaphoreSecurity semaphoreSecurity) { }
    }
}
