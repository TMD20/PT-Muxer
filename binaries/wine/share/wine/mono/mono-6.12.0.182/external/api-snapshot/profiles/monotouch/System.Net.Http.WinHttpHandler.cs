// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

[assembly:System.Reflection.AssemblyVersionAttribute("2.0.5.0")]
[assembly:System.CLSCompliantAttribute(true)]
[assembly:System.Diagnostics.DebuggableAttribute(System.Diagnostics.DebuggableAttribute.DebuggingModes.IgnoreSymbolStoreSequencePoints)]
[assembly:System.Reflection.AssemblyCompanyAttribute("Mono development team")]
[assembly:System.Reflection.AssemblyCopyrightAttribute("(c) Various Mono authors")]
[assembly:System.Reflection.AssemblyDefaultAliasAttribute("System.Net.Http.WinHttpHandler.dll")]
[assembly:System.Reflection.AssemblyDescriptionAttribute("System.Net.Http.WinHttpHandler.dll")]
[assembly:System.Reflection.AssemblyFileVersionAttribute("4.0.50524.0")]
[assembly:System.Reflection.AssemblyInformationalVersionAttribute("4.0.50524.0")]
[assembly:System.Reflection.AssemblyProductAttribute("Mono Common Language Infrastructure")]
[assembly:System.Reflection.AssemblyTitleAttribute("System.Net.Http.WinHttpHandler.dll")]
[assembly:System.Resources.NeutralResourcesLanguageAttribute("en-US")]
[assembly:System.Resources.SatelliteContractVersionAttribute("2.0.5.0")]
[assembly:System.Runtime.CompilerServices.CompilationRelaxationsAttribute(8)]
[assembly:System.Runtime.CompilerServices.RuntimeCompatibilityAttribute(WrapNonExceptionThrows=true)]
[assembly:System.Runtime.InteropServices.ComVisibleAttribute(false)]
[assembly:System.Security.SecurityCriticalAttribute]
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
namespace System.Net.Http
{
    public enum CookieUsePolicy
    {
        IgnoreCookies = 0,
        UseInternalCookieStoreOnly = 1,
        UseSpecifiedCookieContainer = 2,
    }
    public enum WindowsProxyUsePolicy
    {
        DoNotUseProxy = 0,
        UseCustomProxy = 3,
        UseWinHttpProxy = 1,
        UseWinInetProxy = 2,
    }
    public partial class WinHttpHandler : System.Net.Http.HttpMessageHandler
    {
        public WinHttpHandler() { }
        public System.Net.DecompressionMethods AutomaticDecompression { get { throw null; } set { } }
        public bool AutomaticRedirection { get { throw null; } set { } }
        public bool CheckCertificateRevocationList { get { throw null; } set { } }
        public System.Net.Http.ClientCertificateOption ClientCertificateOption { get { throw null; } set { } }
        public System.Security.Cryptography.X509Certificates.X509Certificate2Collection ClientCertificates { get { throw null; } }
        public System.Net.CookieContainer CookieContainer { get { throw null; } set { } }
        public System.Net.Http.CookieUsePolicy CookieUsePolicy { get { throw null; } set { } }
        public System.Net.ICredentials DefaultProxyCredentials { get { throw null; } set { } }
        public int MaxAutomaticRedirections { get { throw null; } set { } }
        public int MaxConnectionsPerServer { get { throw null; } set { } }
        public int MaxResponseDrainSize { get { throw null; } set { } }
        public int MaxResponseHeadersLength { get { throw null; } set { } }
        public bool PreAuthenticate { get { throw null; } set { } }
        public System.Collections.Generic.IDictionary<string, object> Properties { get { throw null; } }
        public System.Net.IWebProxy Proxy { get { throw null; } set { } }
        public System.TimeSpan ReceiveDataTimeout { get { throw null; } set { } }
        public System.TimeSpan ReceiveHeadersTimeout { get { throw null; } set { } }
        public System.TimeSpan SendTimeout { get { throw null; } set { } }
        public System.Func<System.Net.Http.HttpRequestMessage, System.Security.Cryptography.X509Certificates.X509Certificate2, System.Security.Cryptography.X509Certificates.X509Chain, System.Net.Security.SslPolicyErrors, bool> ServerCertificateValidationCallback { get { throw null; } set { } }
        public System.Net.ICredentials ServerCredentials { get { throw null; } set { } }
        public System.Security.Authentication.SslProtocols SslProtocols { get { throw null; } set { } }
        public System.Net.Http.WindowsProxyUsePolicy WindowsProxyUsePolicy { get { throw null; } set { } }
        protected override void Dispose(bool disposing) { }
        protected override System.Threading.Tasks.Task<System.Net.Http.HttpResponseMessage> SendAsync(System.Net.Http.HttpRequestMessage request, System.Threading.CancellationToken cancellationToken) { throw null; }
    }
}
