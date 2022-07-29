// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

[assembly:System.Reflection.AssemblyVersionAttribute("4.0.0.0")]
[assembly:System.CLSCompliantAttribute(true)]
[assembly:System.Reflection.AssemblyCompanyAttribute("Mono development team")]
[assembly:System.Reflection.AssemblyCopyrightAttribute("(c) Various Mono authors")]
[assembly:System.Reflection.AssemblyDefaultAliasAttribute("System.Net.dll")]
[assembly:System.Reflection.AssemblyDescriptionAttribute("System.Net.dll")]
[assembly:System.Reflection.AssemblyFileVersionAttribute("4.0.30319.1")]
[assembly:System.Reflection.AssemblyInformationalVersionAttribute("4.0.30319.1")]
[assembly:System.Reflection.AssemblyProductAttribute("Mono Common Language Infrastructure")]
[assembly:System.Reflection.AssemblyTitleAttribute("System.Net.dll")]
[assembly:System.Resources.NeutralResourcesLanguageAttribute("en-US")]
[assembly:System.Resources.SatelliteContractVersionAttribute("4.0.0.0")]
[assembly:System.Runtime.CompilerServices.ReferenceAssemblyAttribute]
[assembly:System.Runtime.CompilerServices.RuntimeCompatibilityAttribute(WrapNonExceptionThrows=true)]
[assembly:System.Runtime.InteropServices.ComVisibleAttribute(false)]
[assembly:System.Security.AllowPartiallyTrustedCallersAttribute]
[assembly:System.Security.SecurityCriticalAttribute]
[assembly:System.Security.Permissions.SecurityPermissionAttribute(System.Security.Permissions.SecurityAction.RequestMinimum, SkipVerification=true)]
[assembly:System.Runtime.CompilerServices.TypeForwardedToAttribute(typeof(System.Net.Cookie))]
[assembly:System.Runtime.CompilerServices.TypeForwardedToAttribute(typeof(System.Net.CookieCollection))]
[assembly:System.Runtime.CompilerServices.TypeForwardedToAttribute(typeof(System.Net.CookieContainer))]
[assembly:System.Runtime.CompilerServices.TypeForwardedToAttribute(typeof(System.Net.CookieException))]
[assembly:System.Runtime.CompilerServices.TypeForwardedToAttribute(typeof(System.Net.HttpRequestHeader))]
[assembly:System.Runtime.CompilerServices.TypeForwardedToAttribute(typeof(System.Net.HttpStatusCode))]
[assembly:System.Runtime.CompilerServices.TypeForwardedToAttribute(typeof(System.Net.HttpWebRequest))]
[assembly:System.Runtime.CompilerServices.TypeForwardedToAttribute(typeof(System.Net.HttpWebResponse))]
[assembly:System.Runtime.CompilerServices.TypeForwardedToAttribute(typeof(System.Net.ICredentials))]
[assembly:System.Runtime.CompilerServices.TypeForwardedToAttribute(typeof(System.Net.IWebRequestCreate))]
[assembly:System.Runtime.CompilerServices.TypeForwardedToAttribute(typeof(System.Net.NetworkCredential))]
[assembly:System.Runtime.CompilerServices.TypeForwardedToAttribute(typeof(System.Net.NetworkInformation.NetworkAddressChangedEventHandler))]
[assembly:System.Runtime.CompilerServices.TypeForwardedToAttribute(typeof(System.Net.NetworkInformation.NetworkChange))]
[assembly:System.Runtime.CompilerServices.TypeForwardedToAttribute(typeof(System.Net.NetworkInformation.NetworkInterface))]
[assembly:System.Runtime.CompilerServices.TypeForwardedToAttribute(typeof(System.Net.ProtocolViolationException))]
[assembly:System.Runtime.CompilerServices.TypeForwardedToAttribute(typeof(System.Net.WebException))]
[assembly:System.Runtime.CompilerServices.TypeForwardedToAttribute(typeof(System.Net.WebExceptionStatus))]
[assembly:System.Runtime.CompilerServices.TypeForwardedToAttribute(typeof(System.Net.WebHeaderCollection))]
[assembly:System.Runtime.CompilerServices.TypeForwardedToAttribute(typeof(System.Net.WebRequest))]
[assembly:System.Runtime.CompilerServices.TypeForwardedToAttribute(typeof(System.Net.WebResponse))]
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
namespace System.Net
{
    public partial class IPEndPointCollection : System.Collections.ObjectModel.Collection<System.Net.IPEndPoint>
    {
        public IPEndPointCollection() { }
        protected override void InsertItem(int index, System.Net.IPEndPoint item) { }
        protected override void SetItem(int index, System.Net.IPEndPoint item) { }
    }
}
