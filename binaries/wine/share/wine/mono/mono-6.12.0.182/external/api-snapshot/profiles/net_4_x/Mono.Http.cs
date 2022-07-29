// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

[assembly:System.Reflection.AssemblyVersionAttribute("4.0.0.0")]
[assembly:System.Diagnostics.DebuggableAttribute(System.Diagnostics.DebuggableAttribute.DebuggingModes.IgnoreSymbolStoreSequencePoints)]
[assembly:System.Reflection.AssemblyCompanyAttribute("MONO development team")]
[assembly:System.Reflection.AssemblyConfigurationAttribute("Development version")]
[assembly:System.Reflection.AssemblyCopyrightAttribute("(c) 2003 Various Authors")]
[assembly:System.Reflection.AssemblyDescriptionAttribute("Http and ASP.NET utilities")]
[assembly:System.Reflection.AssemblyProductAttribute("MONO CLI")]
[assembly:System.Reflection.AssemblyTitleAttribute("Mono.Http.dll")]
[assembly:System.Runtime.CompilerServices.CompilationRelaxationsAttribute(8)]
[assembly:System.Runtime.CompilerServices.RuntimeCompatibilityAttribute(WrapNonExceptionThrows=true)]
namespace Mono.Http
{
    [System.SerializableAttribute]
    public partial class GZipWebRequest : System.Net.WebRequest, System.Runtime.Serialization.ISerializable
    {
        public GZipWebRequest(System.Net.WebRequest request) { }
        protected GZipWebRequest(System.Runtime.Serialization.SerializationInfo serializationInfo, System.Runtime.Serialization.StreamingContext streamingContext) { }
        public override string ConnectionGroupName { get { throw null; } set { } }
        public override long ContentLength { get { throw null; } set { } }
        public override string ContentType { get { throw null; } set { } }
        public override System.Net.ICredentials Credentials { get { throw null; } set { } }
        public bool EnableCompression { get { throw null; } set { } }
        public override System.Net.WebHeaderCollection Headers { get { throw null; } set { } }
        public override string Method { get { throw null; } set { } }
        public override bool PreAuthenticate { get { throw null; } set { } }
        public override System.Net.IWebProxy Proxy { get { throw null; } set { } }
        public System.Net.WebRequest RealRequest { get { throw null; } }
        public override System.Uri RequestUri { get { throw null; } }
        public override int Timeout { get { throw null; } set { } }
        public override void Abort() { }
        public override System.IAsyncResult BeginGetRequestStream(System.AsyncCallback callback, object state) { throw null; }
        public override System.IAsyncResult BeginGetResponse(System.AsyncCallback callback, object state) { throw null; }
        public override System.IO.Stream EndGetRequestStream(System.IAsyncResult asyncResult) { throw null; }
        public override System.Net.WebResponse EndGetResponse(System.IAsyncResult asyncResult) { throw null; }
        public override System.IO.Stream GetRequestStream() { throw null; }
        public override System.Net.WebResponse GetResponse() { throw null; }
        void System.Runtime.Serialization.ISerializable.GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
    }
    public partial class GZipWebRequestCreator : System.Net.IWebRequestCreate
    {
        public GZipWebRequestCreator() { }
        public System.Net.WebRequest Create(System.Uri uri) { throw null; }
    }
    public partial class GZipWriteFilter : System.IO.Stream
    {
        public GZipWriteFilter(System.IO.Stream baseStream) { }
        public override bool CanRead { get { throw null; } }
        public override bool CanSeek { get { throw null; } }
        public override bool CanWrite { get { throw null; } }
        public override long Length { get { throw null; } }
        public override long Position { get { throw null; } set { } }
        public override void Close() { }
        public override void Flush() { }
        public override int Read(byte[] buffer, int offset, int count) { throw null; }
        public override long Seek(long offset, System.IO.SeekOrigin origin) { throw null; }
        public override void SetLength(long value) { }
        public override void Write(byte[] buffer, int offset, int count) { }
    }
    public partial class NtlmClient : System.Net.IAuthenticationModule
    {
        public NtlmClient() { }
        public string AuthenticationType { get { throw null; } }
        public bool CanPreAuthenticate { get { throw null; } }
        public System.Net.Authorization Authenticate(string challenge, System.Net.WebRequest webRequest, System.Net.ICredentials credentials) { throw null; }
        public System.Net.Authorization PreAuthenticate(System.Net.WebRequest webRequest, System.Net.ICredentials credentials) { throw null; }
    }
}
namespace Mono.Http.Configuration
{
    public partial class AcceptEncodingConfig
    {
        public AcceptEncodingConfig() { }
        public AcceptEncodingConfig(Mono.Http.Configuration.AcceptEncodingConfig parent) { }
        public void Add(string encoding, string type) { }
        public void Clear() { }
        public bool SetFilter(System.Web.HttpResponse response, string acceptEncoding) { throw null; }
    }
    public partial class AcceptEncodingSectionHandler : System.Configuration.IConfigurationSectionHandler
    {
        public AcceptEncodingSectionHandler() { }
        public object Create(object parent, object configContext, System.Xml.XmlNode section) { throw null; }
    }
}
namespace Mono.Http.Modules
{
    public partial class AcceptEncodingModule : System.Web.IHttpModule
    {
        public AcceptEncodingModule() { }
        public void Dispose() { }
        public void Init(System.Web.HttpApplication app) { }
    }
    public abstract partial class AuthenticationModule : System.Web.IHttpModule
    {
        public AuthenticationModule(string authenticationMethod) { }
        public string AuthenticationMethod { get { throw null; } }
        protected bool AuthenticationRequired { get { throw null; } }
        protected abstract bool AcceptCredentials(System.Web.HttpApplication app, string authentication);
        protected string Authorization(System.Web.HttpApplication app, string authenticationMethod) { throw null; }
        protected void DenyAccess(System.Web.HttpApplication app) { }
        public virtual void Dispose() { }
        public virtual void Init(System.Web.HttpApplication context) { }
        public virtual void OnAuthenticateRequest(object source, System.EventArgs eventArgs) { }
        public abstract void OnEndRequest(object source, System.EventArgs eventArgs);
    }
    public partial class BasicAuthenticationModule : Mono.Http.Modules.AuthenticationModule
    {
        public BasicAuthenticationModule() : base (default(string)) { }
        protected override bool AcceptCredentials(System.Web.HttpApplication app, string authentication) { throw null; }
        public override void OnEndRequest(object source, System.EventArgs eventArgs) { }
    }
    public partial class DigestAuthenticationModule : Mono.Http.Modules.AuthenticationModule
    {
        public DigestAuthenticationModule() : base (default(string)) { }
        protected override bool AcceptCredentials(System.Web.HttpApplication app, string authentication) { throw null; }
        protected virtual string GetCurrentNonce() { throw null; }
        protected virtual bool GetUserByName(System.Web.HttpApplication app, string username, out string password, out string[] roles) { throw null; }
        protected virtual bool IsValidNonce(string nonce) { throw null; }
        public override void OnEndRequest(object source, System.EventArgs eventArgs) { }
    }
}
namespace System.Net
{
    [System.SerializableAttribute]
    public partial class GZipWebResponse : System.Net.WebResponse, System.IDisposable, System.Runtime.Serialization.ISerializable
    {
        protected GZipWebResponse(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
        public override long ContentLength { get { throw null; } }
        public override string ContentType { get { throw null; } }
        public override System.Net.WebHeaderCollection Headers { get { throw null; } }
        public bool IsCompressed { get { throw null; } }
        public System.Net.WebResponse RealResponse { get { throw null; } }
        public override System.Uri ResponseUri { get { throw null; } }
        public override void Close() { }
        public override System.IO.Stream GetResponseStream() { throw null; }
        void System.IDisposable.Dispose() { }
        void System.Runtime.Serialization.ISerializable.GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
    }
}
