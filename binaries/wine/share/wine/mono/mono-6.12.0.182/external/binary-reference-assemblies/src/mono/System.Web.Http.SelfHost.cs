// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

[assembly:System.Reflection.AssemblyVersionAttribute("4.0.0.0")]
[assembly:System.CLSCompliantAttribute(true)]
[assembly:System.Diagnostics.DebuggableAttribute((System.Diagnostics.DebuggableAttribute.DebuggingModes)(2))]
[assembly:System.Reflection.AssemblyCompanyAttribute("Microsoft Corporation")]
[assembly:System.Reflection.AssemblyConfigurationAttribute("")]
[assembly:System.Reflection.AssemblyCopyrightAttribute("© Microsoft Corporation. All rights reserved.")]
[assembly:System.Reflection.AssemblyDescriptionAttribute("")]
[assembly:System.Reflection.AssemblyFileVersionAttribute("4.0.0.0")]
[assembly:System.Reflection.AssemblyProductAttribute("Microsoft ASP.NET MVC")]
[assembly:System.Reflection.AssemblyTitleAttribute("System.Web.Http.SelfHost")]
[assembly:System.Reflection.AssemblyTrademarkAttribute("")]
[assembly:System.Resources.NeutralResourcesLanguageAttribute("en-US")]
[assembly:System.Runtime.CompilerServices.CompilationRelaxationsAttribute(8)]
[assembly:System.Runtime.CompilerServices.ReferenceAssemblyAttribute]
[assembly:System.Runtime.CompilerServices.RuntimeCompatibilityAttribute(WrapNonExceptionThrows=true)]
[assembly:System.Runtime.InteropServices.ComVisibleAttribute(false)]
[assembly:System.Security.SecurityTransparentAttribute]
namespace System.Net.Http
{
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    public static partial class HttpRequestMessageExtensions
    {
        public static System.ServiceModel.Security.SecurityMessageProperty GetSecurityMessageProperty(this System.Net.Http.HttpRequestMessage request) { throw null; }
    }
}
namespace System.Web.Http.SelfHost
{
    public partial class HttpSelfHostConfiguration : System.Web.Http.HttpConfiguration
    {
        public HttpSelfHostConfiguration(string baseAddress) { }
        public HttpSelfHostConfiguration(System.Uri baseAddress) { }
        public System.Uri BaseAddress { get { throw null; } }
        public System.ServiceModel.HostNameComparisonMode HostNameComparisonMode { get { throw null; } set { } }
        public int MaxBufferSize { get { throw null; } set { } }
        public int MaxConcurrentRequests { get { throw null; } set { } }
        public long MaxReceivedMessageSize { get { throw null; } set { } }
        public System.ServiceModel.TransferMode TransferMode { get { throw null; } set { } }
        public System.IdentityModel.Selectors.UserNamePasswordValidator UserNamePasswordValidator { get { throw null; } set { } }
        public bool UseWindowsAuthentication { get { throw null; } set { } }
        protected virtual System.ServiceModel.Channels.BindingParameterCollection OnConfigureBinding(System.Web.Http.SelfHost.Channels.HttpBinding httpBinding) { throw null; }
    }
    public sealed partial class HttpSelfHostServer : System.Web.Http.HttpServer
    {
        public HttpSelfHostServer(System.Web.Http.SelfHost.HttpSelfHostConfiguration configuration) { }
        public HttpSelfHostServer(System.Web.Http.SelfHost.HttpSelfHostConfiguration configuration, System.Net.Http.HttpMessageHandler dispatcher) { }
        public System.Threading.Tasks.Task CloseAsync() { throw null; }
        protected override void Dispose(bool disposing) { }
        public System.Threading.Tasks.Task OpenAsync() { throw null; }
    }
}
namespace System.Web.Http.SelfHost.Channels
{
    public partial class HttpBinding : System.ServiceModel.Channels.Binding, System.ServiceModel.Channels.IBindingRuntimePreferences
    {
        public HttpBinding() { }
        public HttpBinding(System.Web.Http.SelfHost.Channels.HttpBindingSecurityMode securityMode) { }
        public System.ServiceModel.EnvelopeVersion EnvelopeVersion { get { throw null; } }
        [System.ComponentModel.DefaultValueAttribute((System.ServiceModel.HostNameComparisonMode)(0))]
        public System.ServiceModel.HostNameComparisonMode HostNameComparisonMode { get { throw null; } set { } }
        [System.ComponentModel.DefaultValueAttribute((long)524288)]
        public long MaxBufferPoolSize { get { throw null; } set { } }
        [System.ComponentModel.DefaultValueAttribute(65536)]
        public int MaxBufferSize { get { throw null; } set { } }
        [System.ComponentModel.DefaultValueAttribute((long)65536)]
        public long MaxReceivedMessageSize { get { throw null; } set { } }
        public override string Scheme { get { throw null; } }
        public System.Web.Http.SelfHost.Channels.HttpBindingSecurity Security { get { throw null; } set { } }
        bool System.ServiceModel.Channels.IBindingRuntimePreferences.ReceiveSynchronously { get { throw null; } }
        [System.ComponentModel.DefaultValueAttribute((System.ServiceModel.TransferMode)(0))]
        public System.ServiceModel.TransferMode TransferMode { get { throw null; } set { } }
        public override System.ServiceModel.Channels.BindingElementCollection CreateBindingElements() { throw null; }
    }
    public sealed partial class HttpBindingSecurity
    {
        public HttpBindingSecurity() { }
        public System.Web.Http.SelfHost.Channels.HttpBindingSecurityMode Mode { get { throw null; } set { } }
        public System.ServiceModel.HttpTransportSecurity Transport { get { throw null; } set { } }
    }
    public enum HttpBindingSecurityMode
    {
        None = 0,
        Transport = 1,
        TransportCredentialOnly = 2,
    }
}
