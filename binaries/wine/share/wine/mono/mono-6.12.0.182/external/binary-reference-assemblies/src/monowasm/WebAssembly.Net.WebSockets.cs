[assembly:System.Reflection.AssemblyVersionAttribute("0.2.2.0")]
[assembly:System.Diagnostics.DebuggableAttribute(System.Diagnostics.DebuggableAttribute.DebuggingModes.Default | System.Diagnostics.DebuggableAttribute.DebuggingModes.DisableOptimizations | System.Diagnostics.DebuggableAttribute.DebuggingModes.EnableEditAndContinue | System.Diagnostics.DebuggableAttribute.DebuggingModes.IgnoreSymbolStoreSequencePoints)]
[assembly:System.Reflection.AssemblyCompanyAttribute("WebAssembly.Net.WebSockets")]
[assembly:System.Reflection.AssemblyConfigurationAttribute("Debug")]
[assembly:System.Reflection.AssemblyFileVersionAttribute("0.2.2.0")]
[assembly:System.Reflection.AssemblyInformationalVersionAttribute("0.2.2")]
[assembly:System.Reflection.AssemblyProductAttribute("WebAssembly.Net.WebSockets")]
[assembly:System.Reflection.AssemblyTitleAttribute("WebAssembly.Net.WebSockets")]
[assembly:System.Runtime.CompilerServices.CompilationRelaxationsAttribute(8)]
[assembly:System.Runtime.CompilerServices.RuntimeCompatibilityAttribute(WrapNonExceptionThrows=true)]
[assembly:System.Runtime.Versioning.TargetFrameworkAttribute(".NETStandard,Version=v2.0", FrameworkDisplayName="")]
namespace WebAssembly.Net.WebSockets
{
    public sealed partial class ClientWebSocket : System.Net.WebSockets.WebSocket
    {
        public ClientWebSocket() { }
        public override System.Nullable<System.Net.WebSockets.WebSocketCloseStatus> CloseStatus { get { throw null; } }
        public override string CloseStatusDescription { get { throw null; } }
        public WebAssembly.Net.WebSockets.ClientWebSocket.ClientWebSocketOptions Options { get { throw null; } }
        public override System.Net.WebSockets.WebSocketState State { get { throw null; } }
        public override string SubProtocol { get { throw null; } }
        public override void Abort() { }
        [System.Diagnostics.DebuggerStepThroughAttribute]
        public override System.Threading.Tasks.Task CloseAsync(System.Net.WebSockets.WebSocketCloseStatus closeStatus, string statusDescription, System.Threading.CancellationToken cancellationToken) { throw null; }
        public override System.Threading.Tasks.Task CloseOutputAsync(System.Net.WebSockets.WebSocketCloseStatus closeStatus, string statusDescription, System.Threading.CancellationToken cancellationToken) { throw null; }
        public System.Threading.Tasks.Task ConnectAsync(System.Uri uri, System.Threading.CancellationToken cancellationToken) { throw null; }
        public override void Dispose() { }
        [System.Diagnostics.DebuggerStepThroughAttribute]
        public override System.Threading.Tasks.Task<System.Net.WebSockets.WebSocketReceiveResult> ReceiveAsync(System.ArraySegment<byte> buffer, System.Threading.CancellationToken cancellationToken) { throw null; }
        [System.Diagnostics.DebuggerStepThroughAttribute]
        public override System.Threading.Tasks.Task SendAsync(System.ArraySegment<byte> buffer, System.Net.WebSockets.WebSocketMessageType messageType, bool endOfMessage, System.Threading.CancellationToken cancellationToken) { throw null; }
        public sealed partial class ClientWebSocketOptions
        {
            internal ClientWebSocketOptions() { }
            public System.Security.Cryptography.X509Certificates.X509CertificateCollection ClientCertificates { get { throw null; } set { } }
            public System.Net.CookieContainer Cookies { get { throw null; } set { } }
            public System.Net.ICredentials Credentials { get { throw null; } set { } }
            public System.TimeSpan KeepAliveInterval { get { throw null; } set { } }
            public System.Net.IWebProxy Proxy { get { throw null; } set { } }
            public System.Net.Security.RemoteCertificateValidationCallback RemoteCertificateValidationCallback { get { throw null; } set { } }
            public bool UseDefaultCredentials { get { throw null; } set { } }
            public void AddSubProtocol(string subProtocol) { }
            public void SetBuffer(int receiveBufferSize, int sendBufferSize) { }
            public void SetBuffer(int receiveBufferSize, int sendBufferSize, System.ArraySegment<byte> buffer) { }
            public void SetRequestHeader(string headerName, string headerValue) { }
        }
    }
}
