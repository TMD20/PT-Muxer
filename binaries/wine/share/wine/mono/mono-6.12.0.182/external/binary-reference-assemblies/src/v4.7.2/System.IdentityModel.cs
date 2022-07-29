// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

[assembly:System.Reflection.AssemblyVersionAttribute("4.0.0.0")]
[assembly:System.CLSCompliantAttribute(true)]
[assembly:System.Diagnostics.DebuggableAttribute(System.Diagnostics.DebuggableAttribute.DebuggingModes.IgnoreSymbolStoreSequencePoints)]
[assembly:System.Reflection.AssemblyCompanyAttribute("Mono development team")]
[assembly:System.Reflection.AssemblyCopyrightAttribute("(c) Various Mono authors")]
[assembly:System.Reflection.AssemblyDefaultAliasAttribute("System.IdentityModel.dll")]
[assembly:System.Reflection.AssemblyDescriptionAttribute("System.IdentityModel.dll")]
[assembly:System.Reflection.AssemblyFileVersionAttribute("4.7.3062.0")]
[assembly:System.Reflection.AssemblyInformationalVersionAttribute("4.7.3062.0")]
[assembly:System.Reflection.AssemblyProductAttribute("Mono Common Language Infrastructure")]
[assembly:System.Reflection.AssemblyTitleAttribute("System.IdentityModel.dll")]
[assembly:System.Resources.NeutralResourcesLanguageAttribute("en-US")]
[assembly:System.Resources.SatelliteContractVersionAttribute("4.0.0.0")]
[assembly:System.Runtime.CompilerServices.CompilationRelaxationsAttribute(8)]
[assembly:System.Runtime.CompilerServices.ReferenceAssemblyAttribute]
[assembly:System.Runtime.CompilerServices.RuntimeCompatibilityAttribute(WrapNonExceptionThrows=true)]
[assembly:System.Runtime.InteropServices.ComCompatibleVersionAttribute(1, 0, 3300, 0)]
[assembly:System.Runtime.InteropServices.ComVisibleAttribute(false)]
[assembly:System.Runtime.InteropServices.DefaultDllImportSearchPathsAttribute(System.Runtime.InteropServices.DllImportSearchPath.AssemblyDirectory | System.Runtime.InteropServices.DllImportSearchPath.System32)]
[assembly:System.Security.AllowPartiallyTrustedCallersAttribute]
[assembly:System.Security.SecurityCriticalAttribute]
[assembly:System.Security.SecurityRulesAttribute(System.Security.SecurityRuleSet.Level1)]
[assembly:System.Security.Permissions.SecurityPermissionAttribute(System.Security.Permissions.SecurityAction.RequestMinimum, SkipVerification=true)]
namespace System.IdentityModel
{
    [System.SerializableAttribute]
    public partial class AsynchronousOperationException : System.Exception
    {
        public AsynchronousOperationException() { }
        public AsynchronousOperationException(System.Exception innerException) { }
        protected AsynchronousOperationException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
        public AsynchronousOperationException(string message) { }
        public AsynchronousOperationException(string message, System.Exception innerException) { }
    }
    public abstract partial class AsyncResult : System.IAsyncResult, System.IDisposable
    {
        protected AsyncResult() { }
        protected AsyncResult(System.AsyncCallback callback, object state) { }
        protected AsyncResult(object state) { }
        public object AsyncState { get { throw null; } }
        public virtual System.Threading.WaitHandle AsyncWaitHandle { get { throw null; } }
        public bool CompletedSynchronously { get { throw null; } }
        public bool IsCompleted { get { throw null; } }
        protected void Complete(bool completedSynchronously) { }
        protected void Complete(bool completedSynchronously, System.Exception exception) { }
        public void Dispose() { }
        protected virtual void Dispose(bool isExplicitDispose) { }
        public static void End(System.IAsyncResult result) { }
        ~AsyncResult() { }
    }
    [System.SerializableAttribute]
    public partial class BadRequestException : System.IdentityModel.RequestException
    {
        public BadRequestException() { }
        protected BadRequestException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
        public BadRequestException(string message) { }
        public BadRequestException(string message, System.Exception innerException) { }
    }
    public abstract partial class CookieTransform
    {
        protected CookieTransform() { }
        public abstract byte[] Decode(byte[] encoded);
        public abstract byte[] Encode(byte[] value);
    }
    public sealed partial class DeflateCookieTransform : System.IdentityModel.CookieTransform
    {
        public DeflateCookieTransform() { }
        public int MaxDecompressedSize { get { throw null; } set { } }
        public override byte[] Decode(byte[] encoded) { throw null; }
        public override byte[] Encode(byte[] value) { throw null; }
    }
    public partial class DelegatingXmlDictionaryReader : System.Xml.XmlDictionaryReader
    {
        protected DelegatingXmlDictionaryReader() { }
        public override int AttributeCount { get { throw null; } }
        public override string BaseURI { get { throw null; } }
        public override int Depth { get { throw null; } }
        public override bool EOF { get { throw null; } }
        public override bool HasValue { get { throw null; } }
        protected System.Xml.XmlDictionaryReader InnerReader { get { throw null; } }
        public override bool IsDefault { get { throw null; } }
        public override bool IsEmptyElement { get { throw null; } }
        public override string this[int i] { get { throw null; } }
        public override string this[string name] { get { throw null; } }
        public override string this[string name, string namespaceURI] { get { throw null; } }
        public override string LocalName { get { throw null; } }
        public override string Name { get { throw null; } }
        public override string NamespaceURI { get { throw null; } }
        public override System.Xml.XmlNameTable NameTable { get { throw null; } }
        public override System.Xml.XmlNodeType NodeType { get { throw null; } }
        public override string Prefix { get { throw null; } }
        public override char QuoteChar { get { throw null; } }
        public override System.Xml.ReadState ReadState { get { throw null; } }
        public override string Value { get { throw null; } }
        public override System.Type ValueType { get { throw null; } }
        public override string XmlLang { get { throw null; } }
        public override System.Xml.XmlSpace XmlSpace { get { throw null; } }
        public override void Close() { }
        public override string GetAttribute(int i) { throw null; }
        public override string GetAttribute(string name) { throw null; }
        public override string GetAttribute(string name, string namespaceURI) { throw null; }
        protected void InitializeInnerReader(System.Xml.XmlDictionaryReader innerReader) { }
        public override string LookupNamespace(string prefix) { throw null; }
        public override void MoveToAttribute(int i) { }
        public override bool MoveToAttribute(string name) { throw null; }
        public override bool MoveToAttribute(string name, string ns) { throw null; }
        public override bool MoveToElement() { throw null; }
        public override bool MoveToFirstAttribute() { throw null; }
        public override bool MoveToNextAttribute() { throw null; }
        public override bool Read() { throw null; }
        public override bool ReadAttributeValue() { throw null; }
        public override int ReadContentAsBase64(byte[] buffer, int index, int count) { throw null; }
        public override int ReadContentAsBinHex(byte[] buffer, int index, int count) { throw null; }
        public override System.Xml.UniqueId ReadContentAsUniqueId() { throw null; }
        public override int ReadValueChunk(char[] buffer, int index, int count) { throw null; }
        public override void ResolveEntity() { }
    }
    public partial class DelegatingXmlDictionaryWriter : System.Xml.XmlDictionaryWriter
    {
        protected DelegatingXmlDictionaryWriter() { }
        public override bool CanCanonicalize { get { throw null; } }
        protected System.Xml.XmlDictionaryWriter InnerWriter { get { throw null; } }
        public override System.Xml.WriteState WriteState { get { throw null; } }
        public override void Close() { }
        public override void EndCanonicalization() { }
        public override void Flush() { }
        protected void InitializeInnerWriter(System.Xml.XmlDictionaryWriter innerWriter) { }
        protected void InitializeTracingWriter(System.Xml.XmlWriter tracingWriter) { }
        public override string LookupPrefix(string ns) { throw null; }
        public override void StartCanonicalization(System.IO.Stream stream, bool includeComments, string[] inclusivePrefixes) { }
        public override void WriteBase64(byte[] buffer, int index, int count) { }
        public override void WriteCData(string text) { }
        public override void WriteCharEntity(char ch) { }
        public override void WriteChars(char[] buffer, int index, int count) { }
        public override void WriteComment(string text) { }
        public override void WriteDocType(string name, string pubid, string sysid, string subset) { }
        public override void WriteEndAttribute() { }
        public override void WriteEndDocument() { }
        public override void WriteEndElement() { }
        public override void WriteEntityRef(string name) { }
        public override void WriteFullEndElement() { }
        public override void WriteProcessingInstruction(string name, string text) { }
        public override void WriteRaw(char[] buffer, int index, int count) { }
        public override void WriteRaw(string data) { }
        public override void WriteStartAttribute(string prefix, string localName, string ns) { }
        public override void WriteStartDocument() { }
        public override void WriteStartDocument(bool standalone) { }
        public override void WriteStartElement(string prefix, string localName, string ns) { }
        public override void WriteString(string text) { }
        public override void WriteSurrogateCharEntity(char lowChar, char highChar) { }
        public override void WriteWhitespace(string ws) { }
        public override void WriteXmlAttribute(string localName, string value) { }
        public override void WriteXmlnsAttribute(string prefix, string namespaceUri) { }
    }
    public sealed partial class EnvelopedSignatureReader : System.IdentityModel.DelegatingXmlDictionaryReader
    {
        public EnvelopedSignatureReader(System.Xml.XmlReader reader, System.IdentityModel.Selectors.SecurityTokenSerializer securityTokenSerializer) { }
        public EnvelopedSignatureReader(System.Xml.XmlReader reader, System.IdentityModel.Selectors.SecurityTokenSerializer securityTokenSerializer, System.IdentityModel.Selectors.SecurityTokenResolver signingTokenResolver) { }
        public EnvelopedSignatureReader(System.Xml.XmlReader reader, System.IdentityModel.Selectors.SecurityTokenSerializer securityTokenSerializer, System.IdentityModel.Selectors.SecurityTokenResolver signingTokenResolver, bool requireSignature, bool automaticallyReadSignature, bool resolveIntrinsicSigningKeys) { }
        public System.IdentityModel.Tokens.SigningCredentials SigningCredentials { get { throw null; } }
        protected override void Dispose(bool disposing) { }
        public override bool Read() { throw null; }
        public bool TryReadSignature() { throw null; }
    }
    public sealed partial class EnvelopedSignatureWriter : System.IdentityModel.DelegatingXmlDictionaryWriter
    {
        public EnvelopedSignatureWriter(System.Xml.XmlWriter innerWriter, System.IdentityModel.Tokens.SigningCredentials signingCredentials, string referenceId, System.IdentityModel.Selectors.SecurityTokenSerializer securityTokenSerializer) { }
        protected override void Dispose(bool disposing) { }
        public override void WriteEndElement() { }
        public override void WriteFullEndElement() { }
        public void WriteSignature() { }
        public override void WriteStartElement(string prefix, string localName, string ns) { }
    }
    [System.SerializableAttribute]
    public partial class LimitExceededException : System.SystemException
    {
        public LimitExceededException() { }
        protected LimitExceededException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
        public LimitExceededException(string message) { }
        public LimitExceededException(string message, System.Exception innerException) { }
    }
    public abstract partial class OpenObject
    {
        protected OpenObject() { }
        public System.Collections.Generic.Dictionary<string, object> Properties { get { throw null; } }
    }
    public sealed partial class ProtectedDataCookieTransform : System.IdentityModel.CookieTransform
    {
        public ProtectedDataCookieTransform() { }
        public override byte[] Decode(byte[] encoded) { throw null; }
        public override byte[] Encode(byte[] value) { throw null; }
    }
    [System.SerializableAttribute]
    public abstract partial class RequestException : System.Exception
    {
        protected RequestException() { }
        protected RequestException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
        protected RequestException(string message) { }
        protected RequestException(string message, System.Exception innerException) { }
    }
    [System.SerializableAttribute]
    public partial class RequestFailedException : System.IdentityModel.RequestException
    {
        public RequestFailedException() { }
        protected RequestFailedException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
        public RequestFailedException(string message) { }
        public RequestFailedException(string message, System.Exception innerException) { }
    }
    public partial class RsaEncryptionCookieTransform : System.IdentityModel.CookieTransform
    {
        public RsaEncryptionCookieTransform(System.Security.Cryptography.RSA key) { }
        public RsaEncryptionCookieTransform(System.Security.Cryptography.X509Certificates.X509Certificate2 certificate) { }
        protected virtual System.Collections.ObjectModel.ReadOnlyCollection<System.Security.Cryptography.RSA> DecryptionKeys { get { throw null; } }
        public virtual System.Security.Cryptography.RSA EncryptionKey { get { throw null; } set { } }
        public string HashName { get { throw null; } set { } }
        public override byte[] Decode(byte[] encoded) { throw null; }
        public override byte[] Encode(byte[] value) { throw null; }
    }
    public partial class RsaSignatureCookieTransform : System.IdentityModel.CookieTransform
    {
        public RsaSignatureCookieTransform(System.Security.Cryptography.RSA key) { }
        public RsaSignatureCookieTransform(System.Security.Cryptography.X509Certificates.X509Certificate2 certificate) { }
        public string HashName { get { throw null; } set { } }
        public virtual System.Security.Cryptography.RSA SigningKey { get { throw null; } set { } }
        protected virtual System.Collections.ObjectModel.ReadOnlyCollection<System.Security.Cryptography.RSA> VerificationKeys { get { throw null; } }
        public override byte[] Decode(byte[] encoded) { throw null; }
        public override byte[] Encode(byte[] value) { throw null; }
    }
    public partial class Scope
    {
        public Scope() { }
        public Scope(string appliesToAddress) { }
        public Scope(string appliesToAddress, System.IdentityModel.Tokens.EncryptingCredentials encryptingCredentials) { }
        public Scope(string appliesToAddress, System.IdentityModel.Tokens.SigningCredentials signingCredentials) { }
        public Scope(string appliesToAddress, System.IdentityModel.Tokens.SigningCredentials signingCredentials, System.IdentityModel.Tokens.EncryptingCredentials encryptingCredentials) { }
        public virtual string AppliesToAddress { get { throw null; } set { } }
        public virtual System.IdentityModel.Tokens.EncryptingCredentials EncryptingCredentials { get { throw null; } set { } }
        public virtual System.Collections.Generic.Dictionary<string, object> Properties { get { throw null; } }
        public virtual string ReplyToAddress { get { throw null; } set { } }
        public virtual System.IdentityModel.Tokens.SigningCredentials SigningCredentials { get { throw null; } set { } }
        public virtual bool SymmetricKeyEncryptionRequired { get { throw null; } set { } }
        public virtual bool TokenEncryptionRequired { get { throw null; } set { } }
    }
    [System.SerializableAttribute]
    public partial class SecurityMessageSerializationException : System.SystemException
    {
        public SecurityMessageSerializationException() { }
        protected SecurityMessageSerializationException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
        public SecurityMessageSerializationException(string message) { }
        public SecurityMessageSerializationException(string message, System.Exception innerException) { }
    }
    public abstract partial class SecurityTokenService
    {
        protected SecurityTokenService(System.IdentityModel.Configuration.SecurityTokenServiceConfiguration securityTokenServiceConfiguration) { }
        public System.Security.Claims.ClaimsPrincipal Principal { get { throw null; } set { } }
        public System.IdentityModel.Protocols.WSTrust.RequestSecurityToken Request { get { throw null; } set { } }
        public System.IdentityModel.Scope Scope { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        protected System.IdentityModel.Tokens.SecurityTokenDescriptor SecurityTokenDescriptor { get { throw null; } set { } }
        public System.IdentityModel.Configuration.SecurityTokenServiceConfiguration SecurityTokenServiceConfiguration { get { throw null; } }
        public virtual System.IAsyncResult BeginCancel(System.Security.Claims.ClaimsPrincipal principal, System.IdentityModel.Protocols.WSTrust.RequestSecurityToken request, System.AsyncCallback callback, object state) { throw null; }
        protected virtual System.IAsyncResult BeginGetOutputClaimsIdentity(System.Security.Claims.ClaimsPrincipal principal, System.IdentityModel.Protocols.WSTrust.RequestSecurityToken request, System.IdentityModel.Scope scope, System.AsyncCallback callback, object state) { throw null; }
        protected virtual System.IAsyncResult BeginGetScope(System.Security.Claims.ClaimsPrincipal principal, System.IdentityModel.Protocols.WSTrust.RequestSecurityToken request, System.AsyncCallback callback, object state) { throw null; }
        public virtual System.IAsyncResult BeginIssue(System.Security.Claims.ClaimsPrincipal principal, System.IdentityModel.Protocols.WSTrust.RequestSecurityToken request, System.AsyncCallback callback, object state) { throw null; }
        public virtual System.IAsyncResult BeginRenew(System.Security.Claims.ClaimsPrincipal principal, System.IdentityModel.Protocols.WSTrust.RequestSecurityToken request, System.AsyncCallback callback, object state) { throw null; }
        public virtual System.IAsyncResult BeginValidate(System.Security.Claims.ClaimsPrincipal principal, System.IdentityModel.Protocols.WSTrust.RequestSecurityToken request, System.AsyncCallback callback, object state) { throw null; }
        public virtual System.IdentityModel.Protocols.WSTrust.RequestSecurityTokenResponse Cancel(System.Security.Claims.ClaimsPrincipal principal, System.IdentityModel.Protocols.WSTrust.RequestSecurityToken request) { throw null; }
        protected virtual System.IdentityModel.Tokens.SecurityTokenDescriptor CreateSecurityTokenDescriptor(System.IdentityModel.Protocols.WSTrust.RequestSecurityToken request, System.IdentityModel.Scope scope) { throw null; }
        public virtual System.IdentityModel.Protocols.WSTrust.RequestSecurityTokenResponse EndCancel(System.IAsyncResult result) { throw null; }
        protected virtual System.Security.Claims.ClaimsIdentity EndGetOutputClaimsIdentity(System.IAsyncResult result) { throw null; }
        protected virtual System.IdentityModel.Scope EndGetScope(System.IAsyncResult result) { throw null; }
        public virtual System.IdentityModel.Protocols.WSTrust.RequestSecurityTokenResponse EndIssue(System.IAsyncResult result) { throw null; }
        public virtual System.IdentityModel.Protocols.WSTrust.RequestSecurityTokenResponse EndRenew(System.IAsyncResult result) { throw null; }
        public virtual System.IdentityModel.Protocols.WSTrust.RequestSecurityTokenResponse EndValidate(System.IAsyncResult result) { throw null; }
        protected virtual string GetIssuerName() { throw null; }
        protected abstract System.Security.Claims.ClaimsIdentity GetOutputClaimsIdentity(System.Security.Claims.ClaimsPrincipal principal, System.IdentityModel.Protocols.WSTrust.RequestSecurityToken request, System.IdentityModel.Scope scope);
        protected virtual System.IdentityModel.Tokens.ProofDescriptor GetProofToken(System.IdentityModel.Protocols.WSTrust.RequestSecurityToken request, System.IdentityModel.Scope scope) { throw null; }
        protected virtual System.IdentityModel.Tokens.EncryptingCredentials GetRequestorProofEncryptingCredentials(System.IdentityModel.Protocols.WSTrust.RequestSecurityToken request) { throw null; }
        protected virtual System.IdentityModel.Protocols.WSTrust.RequestSecurityTokenResponse GetResponse(System.IdentityModel.Protocols.WSTrust.RequestSecurityToken request, System.IdentityModel.Tokens.SecurityTokenDescriptor tokenDescriptor) { throw null; }
        protected abstract System.IdentityModel.Scope GetScope(System.Security.Claims.ClaimsPrincipal principal, System.IdentityModel.Protocols.WSTrust.RequestSecurityToken request);
        protected virtual System.IdentityModel.Tokens.SecurityTokenHandler GetSecurityTokenHandler(string requestedTokenType) { throw null; }
        protected virtual System.IdentityModel.Protocols.WSTrust.Lifetime GetTokenLifetime(System.IdentityModel.Protocols.WSTrust.Lifetime requestLifetime) { throw null; }
        public virtual System.IdentityModel.Protocols.WSTrust.RequestSecurityTokenResponse Issue(System.Security.Claims.ClaimsPrincipal principal, System.IdentityModel.Protocols.WSTrust.RequestSecurityToken request) { throw null; }
        public virtual System.IdentityModel.Protocols.WSTrust.RequestSecurityTokenResponse Renew(System.Security.Claims.ClaimsPrincipal principal, System.IdentityModel.Protocols.WSTrust.RequestSecurityToken request) { throw null; }
        public virtual System.IdentityModel.Protocols.WSTrust.RequestSecurityTokenResponse Validate(System.Security.Claims.ClaimsPrincipal principal, System.IdentityModel.Protocols.WSTrust.RequestSecurityToken request) { throw null; }
        protected virtual void ValidateRequest(System.IdentityModel.Protocols.WSTrust.RequestSecurityToken request) { }
        protected partial class FederatedAsyncState
        {
            public FederatedAsyncState(System.IdentityModel.Protocols.WSTrust.RequestSecurityToken request, System.Security.Claims.ClaimsPrincipal principal, System.IAsyncResult result) { }
            public FederatedAsyncState(System.IdentityModel.SecurityTokenService.FederatedAsyncState federatedAsyncState) { }
            public System.Security.Claims.ClaimsPrincipal ClaimsPrincipal { get { throw null; } }
            public System.IdentityModel.Protocols.WSTrust.RequestSecurityToken Request { get { throw null; } }
            public System.IAsyncResult Result { get { throw null; } }
            public System.IdentityModel.Tokens.SecurityTokenHandler SecurityTokenHandler { get { throw null; } set { } }
        }
    }
    [System.SerializableAttribute]
    public partial class SignatureVerificationFailedException : System.IdentityModel.Tokens.SecurityTokenException
    {
        public SignatureVerificationFailedException() { }
        protected SignatureVerificationFailedException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
        public SignatureVerificationFailedException(string message) { }
        public SignatureVerificationFailedException(string message, System.Exception inner) { }
    }
    public partial class TypedAsyncResult<T> : System.IdentityModel.AsyncResult
    {
        public TypedAsyncResult(System.AsyncCallback callback, object state) { }
        public TypedAsyncResult(object state) { }
        public T Result { get { throw null; } }
        public void Complete(T result, bool completedSynchronously) { }
        public void Complete(T result, bool completedSynchronously, System.Exception exception) { }
        public static new T End(System.IAsyncResult result) { throw null; }
    }
    [System.SerializableAttribute]
    public partial class UnsupportedTokenTypeBadRequestException : System.IdentityModel.BadRequestException
    {
        public UnsupportedTokenTypeBadRequestException() { }
        protected UnsupportedTokenTypeBadRequestException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
        public UnsupportedTokenTypeBadRequestException(string tokenType) { }
        public UnsupportedTokenTypeBadRequestException(string message, System.Exception exception) { }
        public string TokenType { get { throw null; } set { } }
        [System.Security.Permissions.SecurityPermissionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Flags=System.Security.Permissions.SecurityPermissionFlag.SerializationFormatter)]
        public override void GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
    }
}
namespace System.IdentityModel.Claims
{
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://schemas.xmlsoap.org/ws/2005/05/identity")]
    public partial class Claim
    {
        public Claim(string claimType, object resource, string right) { }
        public string ClaimType { get { throw null; } }
        public static System.Collections.Generic.IEqualityComparer<System.IdentityModel.Claims.Claim> DefaultComparer { get { throw null; } }
        public object Resource { get { throw null; } }
        public string Right { get { throw null; } }
        public static System.IdentityModel.Claims.Claim System { get { throw null; } }
        public static System.IdentityModel.Claims.Claim CreateDenyOnlyWindowsSidClaim(System.Security.Principal.SecurityIdentifier sid) { throw null; }
        public static System.IdentityModel.Claims.Claim CreateDnsClaim(string dns) { throw null; }
        public static System.IdentityModel.Claims.Claim CreateHashClaim(byte[] hash) { throw null; }
        public static System.IdentityModel.Claims.Claim CreateMailAddressClaim(System.Net.Mail.MailAddress mailAddress) { throw null; }
        public static System.IdentityModel.Claims.Claim CreateNameClaim(string name) { throw null; }
        public static System.IdentityModel.Claims.Claim CreateRsaClaim(System.Security.Cryptography.RSA rsa) { throw null; }
        public static System.IdentityModel.Claims.Claim CreateSpnClaim(string spn) { throw null; }
        public static System.IdentityModel.Claims.Claim CreateThumbprintClaim(byte[] thumbprint) { throw null; }
        public static System.IdentityModel.Claims.Claim CreateUpnClaim(string upn) { throw null; }
        public static System.IdentityModel.Claims.Claim CreateUriClaim(System.Uri uri) { throw null; }
        public static System.IdentityModel.Claims.Claim CreateWindowsSidClaim(System.Security.Principal.SecurityIdentifier sid) { throw null; }
        public static System.IdentityModel.Claims.Claim CreateX500DistinguishedNameClaim(System.Security.Cryptography.X509Certificates.X500DistinguishedName x500DistinguishedName) { throw null; }
        public override bool Equals(object obj) { throw null; }
        public override int GetHashCode() { throw null; }
        public override string ToString() { throw null; }
    }
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://schemas.xmlsoap.org/ws/2005/05/identity")]
    public abstract partial class ClaimSet : System.Collections.Generic.IEnumerable<System.IdentityModel.Claims.Claim>, System.Collections.IEnumerable
    {
        protected ClaimSet() { }
        public abstract int Count { get; }
        public abstract System.IdentityModel.Claims.ClaimSet Issuer { get; }
        public abstract System.IdentityModel.Claims.Claim this[int index] { get; }
        public static System.IdentityModel.Claims.ClaimSet System { get { throw null; } }
        public static System.IdentityModel.Claims.ClaimSet Windows { get { throw null; } }
        public virtual bool ContainsClaim(System.IdentityModel.Claims.Claim claim) { throw null; }
        public virtual bool ContainsClaim(System.IdentityModel.Claims.Claim claim, System.Collections.Generic.IEqualityComparer<System.IdentityModel.Claims.Claim> comparer) { throw null; }
        public abstract System.Collections.Generic.IEnumerable<System.IdentityModel.Claims.Claim> FindClaims(string claimType, string right);
        public abstract System.Collections.Generic.IEnumerator<System.IdentityModel.Claims.Claim> GetEnumerator();
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { throw null; }
    }
    public static partial class ClaimTypes
    {
        public static string Anonymous { get { throw null; } }
        public static string Authentication { get { throw null; } }
        public static string AuthorizationDecision { get { throw null; } }
        public static string Country { get { throw null; } }
        public static string DateOfBirth { get { throw null; } }
        public static string DenyOnlySid { get { throw null; } }
        public static string Dns { get { throw null; } }
        public static string Email { get { throw null; } }
        public static string Gender { get { throw null; } }
        public static string GivenName { get { throw null; } }
        public static string Hash { get { throw null; } }
        public static string HomePhone { get { throw null; } }
        public static string Locality { get { throw null; } }
        public static string MobilePhone { get { throw null; } }
        public static string Name { get { throw null; } }
        public static string NameIdentifier { get { throw null; } }
        public static string OtherPhone { get { throw null; } }
        public static string PostalCode { get { throw null; } }
        public static string PPID { get { throw null; } }
        public static string Rsa { get { throw null; } }
        public static string Sid { get { throw null; } }
        public static string Spn { get { throw null; } }
        public static string StateOrProvince { get { throw null; } }
        public static string StreetAddress { get { throw null; } }
        public static string Surname { get { throw null; } }
        public static string System { get { throw null; } }
        public static string Thumbprint { get { throw null; } }
        public static string Upn { get { throw null; } }
        public static string Uri { get { throw null; } }
        public static string Webpage { get { throw null; } }
        public static string X500DistinguishedName { get { throw null; } }
    }
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://schemas.xmlsoap.org/ws/2005/05/identity")]
    public partial class DefaultClaimSet : System.IdentityModel.Claims.ClaimSet
    {
        public DefaultClaimSet(System.Collections.Generic.IList<System.IdentityModel.Claims.Claim> claims) { }
        public DefaultClaimSet(System.IdentityModel.Claims.ClaimSet issuer, System.Collections.Generic.IList<System.IdentityModel.Claims.Claim> claims) { }
        public DefaultClaimSet(System.IdentityModel.Claims.ClaimSet issuer, params System.IdentityModel.Claims.Claim[] claims) { }
        public DefaultClaimSet(params System.IdentityModel.Claims.Claim[] claims) { }
        public override int Count { get { throw null; } }
        public override System.IdentityModel.Claims.ClaimSet Issuer { get { throw null; } }
        public override System.IdentityModel.Claims.Claim this[int index] { get { throw null; } }
        public override bool ContainsClaim(System.IdentityModel.Claims.Claim claim) { throw null; }
        public override System.Collections.Generic.IEnumerable<System.IdentityModel.Claims.Claim> FindClaims(string claimType, string right) { throw null; }
        public override System.Collections.Generic.IEnumerator<System.IdentityModel.Claims.Claim> GetEnumerator() { throw null; }
        protected void Initialize(System.IdentityModel.Claims.ClaimSet issuer, System.Collections.Generic.IList<System.IdentityModel.Claims.Claim> claims) { }
        public override string ToString() { throw null; }
    }
    public static partial class Rights
    {
        public static string Identity { get { throw null; } }
        public static string PossessProperty { get { throw null; } }
    }
    public partial class WindowsClaimSet : System.IdentityModel.Claims.ClaimSet, System.IDisposable
    {
        public WindowsClaimSet(System.Security.Principal.WindowsIdentity windowsIdentity) { }
        public WindowsClaimSet(System.Security.Principal.WindowsIdentity windowsIdentity, bool includeWindowsGroups) { }
        public WindowsClaimSet(System.Security.Principal.WindowsIdentity windowsIdentity, bool includeWindowsGroups, System.DateTime expirationTime) { }
        public WindowsClaimSet(System.Security.Principal.WindowsIdentity windowsIdentity, System.DateTime expirationTime) { }
        public WindowsClaimSet(System.Security.Principal.WindowsIdentity windowsIdentity, string authenticationType, bool includeWindowsGroups, System.DateTime expirationTime) { }
        public override int Count { get { throw null; } }
        public System.DateTime ExpirationTime { get { throw null; } }
        public override System.IdentityModel.Claims.ClaimSet Issuer { get { throw null; } }
        public override System.IdentityModel.Claims.Claim this[int index] { get { throw null; } }
        public System.Security.Principal.WindowsIdentity WindowsIdentity { get { throw null; } }
        public void Dispose() { }
        public override System.Collections.Generic.IEnumerable<System.IdentityModel.Claims.Claim> FindClaims(string claimType, string right) { throw null; }
        public override System.Collections.Generic.IEnumerator<System.IdentityModel.Claims.Claim> GetEnumerator() { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class X509CertificateClaimSet : System.IdentityModel.Claims.ClaimSet, System.IDisposable
    {
        public X509CertificateClaimSet(System.Security.Cryptography.X509Certificates.X509Certificate2 certificate) { }
        public override int Count { get { throw null; } }
        public System.DateTime ExpirationTime { get { throw null; } }
        public override System.IdentityModel.Claims.ClaimSet Issuer { get { throw null; } }
        public override System.IdentityModel.Claims.Claim this[int index] { get { throw null; } }
        public System.Security.Cryptography.X509Certificates.X509Certificate2 X509Certificate { get { throw null; } }
        public void Dispose() { }
        public override System.Collections.Generic.IEnumerable<System.IdentityModel.Claims.Claim> FindClaims(string claimType, string right) { throw null; }
        public override System.Collections.Generic.IEnumerator<System.IdentityModel.Claims.Claim> GetEnumerator() { throw null; }
        public override string ToString() { throw null; }
    }
}
namespace System.IdentityModel.Configuration
{
    public sealed partial class AudienceUriElement : System.Configuration.ConfigurationElement
    {
        public AudienceUriElement() { }
        protected override System.Configuration.ConfigurationPropertyCollection Properties { get { throw null; } }
        [System.Configuration.ConfigurationPropertyAttribute("value", IsRequired=true, DefaultValue=" ", IsKey=true)]
        [System.Configuration.StringValidatorAttribute(MinLength=1)]
        public string Value { get { throw null; } set { } }
    }
    [System.Configuration.ConfigurationCollectionAttribute(typeof(System.IdentityModel.Configuration.AudienceUriElement), CollectionType=System.Configuration.ConfigurationElementCollectionType.AddRemoveClearMap)]
    public sealed partial class AudienceUriElementCollection : System.Configuration.ConfigurationElementCollection
    {
        public AudienceUriElementCollection() { }
        [System.Configuration.ConfigurationPropertyAttribute("mode", IsRequired=false, DefaultValue=System.IdentityModel.Selectors.AudienceUriMode.Always)]
        public System.IdentityModel.Selectors.AudienceUriMode Mode { get { throw null; } set { } }
        protected override System.Configuration.ConfigurationPropertyCollection Properties { get { throw null; } }
        protected override System.Configuration.ConfigurationElement CreateNewElement() { throw null; }
        protected override object GetElementKey(System.Configuration.ConfigurationElement element) { throw null; }
        protected override void Init() { }
    }
    public partial class ConfigurationElementInterceptor : System.Configuration.ConfigurationElement
    {
        public ConfigurationElementInterceptor() { }
        public System.Xml.XmlNodeList ChildNodes { get { throw null; } }
        public System.Xml.XmlElement ElementAsXml { get { throw null; } }
        protected override void DeserializeElement(System.Xml.XmlReader reader, bool serializeCollectionKey) { }
        protected override bool OnDeserializeUnrecognizedAttribute(string name, string value) { throw null; }
        protected override bool OnDeserializeUnrecognizedElement(string elementName, System.Xml.XmlReader reader) { throw null; }
        protected override void Reset(System.Configuration.ConfigurationElement parentElement) { }
    }
    public sealed partial class CustomTypeElement : System.IdentityModel.Configuration.ConfigurationElementInterceptor
    {
        public CustomTypeElement() { }
        public bool IsConfigured { get { throw null; } }
        protected override System.Configuration.ConfigurationPropertyCollection Properties { get { throw null; } }
        [System.ComponentModel.TypeConverterAttribute(typeof(System.Configuration.TypeNameConverter))]
        [System.Configuration.ConfigurationPropertyAttribute("type", IsRequired=true, IsKey=true)]
        public System.Type Type { get { throw null; } set { } }
        public static T Resolve<T>(System.IdentityModel.Configuration.CustomTypeElement customTypeElement) where T : class { throw null; }
    }
    public partial interface ICustomIdentityConfiguration
    {
        void LoadCustomConfiguration(System.Xml.XmlNodeList nodeList);
    }
    public partial class IdentityConfiguration
    {
        public static readonly System.ServiceModel.Security.X509CertificateValidationMode DefaultCertificateValidationMode;
        public static readonly System.Type DefaultIssuerNameRegistryType;
        public static readonly System.TimeSpan DefaultMaxClockSkew;
        public static readonly System.Security.Cryptography.X509Certificates.X509RevocationMode DefaultRevocationMode;
        public const string DefaultServiceName = "";
        public static readonly System.Security.Cryptography.X509Certificates.StoreLocation DefaultTrustedStoreLocation;
        public IdentityConfiguration() { }
        public IdentityConfiguration(bool loadConfig) { }
        public IdentityConfiguration(bool loadConfig, System.Security.Cryptography.X509Certificates.X509Certificate2 serviceCertificate) { }
        public IdentityConfiguration(System.Security.Cryptography.X509Certificates.X509Certificate2 serviceCertificate) { }
        public IdentityConfiguration(string identityConfigurationName) { }
        public IdentityConfiguration(string identityConfigurationName, System.Security.Cryptography.X509Certificates.X509Certificate2 serviceCertificate) { }
        public System.IdentityModel.Tokens.AudienceRestriction AudienceRestriction { get { throw null; } set { } }
        public System.IdentityModel.Configuration.IdentityModelCaches Caches { get { throw null; } set { } }
        public System.ServiceModel.Security.X509CertificateValidationMode CertificateValidationMode { get { throw null; } set { } }
        public System.IdentityModel.Selectors.X509CertificateValidator CertificateValidator { get { throw null; } set { } }
        public System.Security.Claims.ClaimsAuthenticationManager ClaimsAuthenticationManager { get { throw null; } set { } }
        public System.Security.Claims.ClaimsAuthorizationManager ClaimsAuthorizationManager { get { throw null; } set { } }
        public bool DetectReplayedTokens { get { throw null; } set { } }
        public virtual bool IsInitialized { get { throw null; } protected set { } }
        public System.IdentityModel.Tokens.IssuerNameRegistry IssuerNameRegistry { get { throw null; } set { } }
        public System.IdentityModel.Selectors.SecurityTokenResolver IssuerTokenResolver { get { throw null; } set { } }
        public System.TimeSpan MaxClockSkew { get { throw null; } set { } }
        public string Name { get { throw null; } }
        public System.Security.Cryptography.X509Certificates.X509RevocationMode RevocationMode { get { throw null; } set { } }
        public bool SaveBootstrapContext { get { throw null; } set { } }
        public System.IdentityModel.Tokens.SecurityTokenHandlerCollectionManager SecurityTokenHandlerCollectionManager { get { throw null; } }
        public System.IdentityModel.Tokens.SecurityTokenHandlerCollection SecurityTokenHandlers { get { throw null; } }
        public System.Security.Cryptography.X509Certificates.X509Certificate2 ServiceCertificate { get { throw null; } set { } }
        public System.IdentityModel.Selectors.SecurityTokenResolver ServiceTokenResolver { get { throw null; } set { } }
        public System.TimeSpan TokenReplayCacheExpirationPeriod { get { throw null; } set { } }
        public System.Security.Cryptography.X509Certificates.StoreLocation TrustedStoreLocation { get { throw null; } set { } }
        public virtual void Initialize() { }
        protected void LoadConfiguration(System.IdentityModel.Configuration.IdentityConfigurationElement element) { }
        protected System.IdentityModel.Tokens.SecurityTokenHandlerConfiguration LoadHandlerConfiguration(System.IdentityModel.Configuration.IdentityConfigurationElement element) { throw null; }
        protected System.IdentityModel.Tokens.SecurityTokenHandlerConfiguration LoadHandlerConfiguration(System.IdentityModel.Tokens.SecurityTokenHandlerConfiguration baseConfiguration, System.IdentityModel.Configuration.SecurityTokenHandlerConfigurationElement element) { throw null; }
        protected System.IdentityModel.Tokens.SecurityTokenHandlerCollectionManager LoadHandlers(System.IdentityModel.Configuration.IdentityConfigurationElement serviceElement) { throw null; }
    }
    public sealed partial class IdentityConfigurationElement : System.Configuration.ConfigurationElement
    {
        public IdentityConfigurationElement() { }
        [System.Configuration.ConfigurationPropertyAttribute("audienceUris", IsRequired=false)]
        public System.IdentityModel.Configuration.AudienceUriElementCollection AudienceUris { get { throw null; } }
        [System.Configuration.ConfigurationPropertyAttribute("caches", IsRequired=false)]
        public System.IdentityModel.Configuration.IdentityModelCachesElement Caches { get { throw null; } set { } }
        [System.Configuration.ConfigurationPropertyAttribute("certificateValidation", IsRequired=false)]
        public System.IdentityModel.Configuration.X509CertificateValidationElement CertificateValidation { get { throw null; } set { } }
        [System.Configuration.ConfigurationPropertyAttribute("claimsAuthenticationManager", IsRequired=false)]
        public System.IdentityModel.Configuration.CustomTypeElement ClaimsAuthenticationManager { get { throw null; } set { } }
        [System.Configuration.ConfigurationPropertyAttribute("claimsAuthorizationManager", IsRequired=false)]
        public System.IdentityModel.Configuration.CustomTypeElement ClaimsAuthorizationManager { get { throw null; } set { } }
        [System.Configuration.ConfigurationPropertyAttribute("issuerNameRegistry", IsRequired=false)]
        public System.IdentityModel.Configuration.IssuerNameRegistryElement IssuerNameRegistry { get { throw null; } set { } }
        [System.Configuration.ConfigurationPropertyAttribute("issuerTokenResolver", IsRequired=false)]
        public System.IdentityModel.Configuration.CustomTypeElement IssuerTokenResolver { get { throw null; } set { } }
        [System.ComponentModel.TypeConverterAttribute("System.IdentityModel.Configuration.TimeSpanOrInfiniteConverter")]
        [System.Configuration.ConfigurationPropertyAttribute("maximumClockSkew", IsRequired=false, DefaultValue="00:05:00")]
        public System.TimeSpan MaximumClockSkew { get { throw null; } set { } }
        [System.Configuration.ConfigurationPropertyAttribute("name", Options=System.Configuration.ConfigurationPropertyOptions.IsKey)]
        [System.Configuration.StringValidatorAttribute(MinLength=0)]
        public string Name { get { throw null; } set { } }
        [System.Configuration.ConfigurationPropertyAttribute("saveBootstrapContext", IsRequired=false, DefaultValue=false)]
        public bool SaveBootstrapContext { get { throw null; } set { } }
        [System.Configuration.ConfigurationPropertyAttribute("", Options=System.Configuration.ConfigurationPropertyOptions.IsDefaultCollection)]
        public System.IdentityModel.Configuration.SecurityTokenHandlerSetElementCollection SecurityTokenHandlerSets { get { throw null; } }
        [System.Configuration.ConfigurationPropertyAttribute("serviceTokenResolver", IsRequired=false)]
        public System.IdentityModel.Configuration.CustomTypeElement ServiceTokenResolver { get { throw null; } set { } }
        [System.Configuration.ConfigurationPropertyAttribute("tokenReplayDetection", IsRequired=false)]
        public System.IdentityModel.Configuration.TokenReplayDetectionElement TokenReplayDetection { get { throw null; } set { } }
    }
    [System.Configuration.ConfigurationCollectionAttribute(typeof(System.IdentityModel.Configuration.IdentityConfigurationElement), AddItemName="identityConfiguration", CollectionType=System.Configuration.ConfigurationElementCollectionType.BasicMap)]
    public sealed partial class IdentityConfigurationElementCollection : System.Configuration.ConfigurationElementCollection
    {
        public IdentityConfigurationElementCollection() { }
        protected override bool ThrowOnDuplicate { get { throw null; } }
        protected override void BaseAdd(System.Configuration.ConfigurationElement element) { }
        protected override System.Configuration.ConfigurationElement CreateNewElement() { throw null; }
        public System.IdentityModel.Configuration.IdentityConfigurationElement GetElement(string name) { throw null; }
        protected override object GetElementKey(System.Configuration.ConfigurationElement element) { throw null; }
    }
    public sealed partial class IdentityModelCaches
    {
        public IdentityModelCaches() { }
        public System.IdentityModel.Tokens.SessionSecurityTokenCache SessionSecurityTokenCache { get { throw null; } set { } }
        public System.IdentityModel.Tokens.TokenReplayCache TokenReplayCache { get { throw null; } set { } }
    }
    public sealed partial class IdentityModelCachesElement : System.Configuration.ConfigurationElement
    {
        public IdentityModelCachesElement() { }
        public bool IsConfigured { get { throw null; } }
        protected override System.Configuration.ConfigurationPropertyCollection Properties { get { throw null; } }
        [System.Configuration.ConfigurationPropertyAttribute("sessionSecurityTokenCache", IsRequired=false)]
        public System.IdentityModel.Configuration.CustomTypeElement SessionSecurityTokenCache { get { throw null; } set { } }
        [System.Configuration.ConfigurationPropertyAttribute("tokenReplayCache", IsRequired=false)]
        public System.IdentityModel.Configuration.CustomTypeElement TokenReplayCache { get { throw null; } set { } }
    }
    public sealed partial class IssuerNameRegistryElement : System.IdentityModel.Configuration.ConfigurationElementInterceptor
    {
        public IssuerNameRegistryElement() { }
        protected override System.Configuration.ConfigurationPropertyCollection Properties { get { throw null; } }
        [System.Configuration.ConfigurationPropertyAttribute("type", IsRequired=false, IsKey=false)]
        [System.Configuration.StringValidatorAttribute(MinLength=0)]
        public string Type { get { throw null; } set { } }
    }
    public sealed partial class SecurityTokenHandlerConfigurationElement : System.Configuration.ConfigurationElement
    {
        public SecurityTokenHandlerConfigurationElement() { }
        [System.Configuration.ConfigurationPropertyAttribute("audienceUris", IsRequired=false)]
        public System.IdentityModel.Configuration.AudienceUriElementCollection AudienceUris { get { throw null; } }
        [System.Configuration.ConfigurationPropertyAttribute("caches", IsRequired=false)]
        public System.IdentityModel.Configuration.IdentityModelCachesElement Caches { get { throw null; } set { } }
        [System.Configuration.ConfigurationPropertyAttribute("certificateValidation", IsRequired=false)]
        public System.IdentityModel.Configuration.X509CertificateValidationElement CertificateValidation { get { throw null; } set { } }
        [System.Configuration.ConfigurationPropertyAttribute("issuerNameRegistry", IsRequired=false)]
        public System.IdentityModel.Configuration.IssuerNameRegistryElement IssuerNameRegistry { get { throw null; } set { } }
        [System.Configuration.ConfigurationPropertyAttribute("issuerTokenResolver", IsRequired=false)]
        public System.IdentityModel.Configuration.CustomTypeElement IssuerTokenResolver { get { throw null; } set { } }
        [System.ComponentModel.TypeConverterAttribute("System.IdentityModel.Configuration.TimeSpanOrInfiniteConverter")]
        [System.Configuration.ConfigurationPropertyAttribute("maximumClockSkew", IsRequired=false, DefaultValue="00:05:00")]
        public System.TimeSpan MaximumClockSkew { get { throw null; } set { } }
        [System.Configuration.ConfigurationPropertyAttribute("name", IsRequired=false, Options=System.Configuration.ConfigurationPropertyOptions.IsKey)]
        [System.Configuration.StringValidatorAttribute(MinLength=0)]
        public string Name { get { throw null; } set { } }
        protected override System.Configuration.ConfigurationPropertyCollection Properties { get { throw null; } }
        [System.Configuration.ConfigurationPropertyAttribute("saveBootstrapContext", IsRequired=false, DefaultValue=false)]
        public bool SaveBootstrapContext { get { throw null; } set { } }
        [System.Configuration.ConfigurationPropertyAttribute("serviceTokenResolver", IsRequired=false)]
        public System.IdentityModel.Configuration.CustomTypeElement ServiceTokenResolver { get { throw null; } set { } }
        [System.Configuration.ConfigurationPropertyAttribute("tokenReplayDetection", IsRequired=false)]
        public System.IdentityModel.Configuration.TokenReplayDetectionElement TokenReplayDetection { get { throw null; } set { } }
        protected override void Init() { }
    }
    [System.Configuration.ConfigurationCollectionAttribute(typeof(System.IdentityModel.Configuration.CustomTypeElement), CollectionType=System.Configuration.ConfigurationElementCollectionType.BasicMap)]
    public sealed partial class SecurityTokenHandlerElementCollection : System.Configuration.ConfigurationElementCollection
    {
        public SecurityTokenHandlerElementCollection() { }
        [System.Configuration.ConfigurationPropertyAttribute("name", Options=System.Configuration.ConfigurationPropertyOptions.IsKey)]
        [System.Configuration.StringValidatorAttribute(MinLength=0)]
        public string Name { get { throw null; } set { } }
        protected override System.Configuration.ConfigurationPropertyCollection Properties { get { throw null; } }
        [System.Configuration.ConfigurationPropertyAttribute("securityTokenHandlerConfiguration", IsRequired=false)]
        public System.IdentityModel.Configuration.SecurityTokenHandlerConfigurationElement SecurityTokenHandlerConfiguration { get { throw null; } set { } }
        protected override System.Configuration.ConfigurationElement CreateNewElement() { throw null; }
        protected override object GetElementKey(System.Configuration.ConfigurationElement element) { throw null; }
        protected override void Init() { }
    }
    [System.Configuration.ConfigurationCollectionAttribute(typeof(System.IdentityModel.Configuration.SecurityTokenHandlerElementCollection), AddItemName="securityTokenHandlers", CollectionType=System.Configuration.ConfigurationElementCollectionType.BasicMap)]
    public sealed partial class SecurityTokenHandlerSetElementCollection : System.Configuration.ConfigurationElementCollection
    {
        public SecurityTokenHandlerSetElementCollection() { }
        public bool IsConfigured { get { throw null; } }
        protected override bool ThrowOnDuplicate { get { throw null; } }
        protected override void BaseAdd(System.Configuration.ConfigurationElement element) { }
        protected override System.Configuration.ConfigurationElement CreateNewElement() { throw null; }
        protected override object GetElementKey(System.Configuration.ConfigurationElement element) { throw null; }
    }
    public partial class SecurityTokenServiceConfiguration : System.IdentityModel.Configuration.IdentityConfiguration
    {
        public SecurityTokenServiceConfiguration() { }
        public SecurityTokenServiceConfiguration(bool loadConfig) { }
        public SecurityTokenServiceConfiguration(string issuerName) { }
        public SecurityTokenServiceConfiguration(string issuerName, bool loadConfig) { }
        public SecurityTokenServiceConfiguration(string issuerName, System.IdentityModel.Tokens.SigningCredentials signingCredentials) { }
        public SecurityTokenServiceConfiguration(string issuerName, System.IdentityModel.Tokens.SigningCredentials signingCredentials, bool loadConfig) { }
        public SecurityTokenServiceConfiguration(string issuerName, System.IdentityModel.Tokens.SigningCredentials signingCredentials, string serviceName) { }
        public int DefaultMaxSymmetricKeySizeInBits { get { throw null; } set { } }
        public int DefaultSymmetricKeySizeInBits { get { throw null; } set { } }
        public System.TimeSpan DefaultTokenLifetime { get { throw null; } set { } }
        public string DefaultTokenType { get { throw null; } set { } }
        public bool DisableWsdl { get { throw null; } set { } }
        public System.TimeSpan MaximumTokenLifetime { get { throw null; } set { } }
        public System.Type SecurityTokenService { get { throw null; } set { } }
        public System.IdentityModel.Tokens.SigningCredentials SigningCredentials { get { throw null; } set { } }
        public string TokenIssuerName { get { throw null; } set { } }
        public System.IdentityModel.Protocols.WSTrust.WSTrust13RequestSerializer WSTrust13RequestSerializer { get { throw null; } set { } }
        public System.IdentityModel.Protocols.WSTrust.WSTrust13ResponseSerializer WSTrust13ResponseSerializer { get { throw null; } set { } }
        public System.IdentityModel.Protocols.WSTrust.WSTrustFeb2005RequestSerializer WSTrustFeb2005RequestSerializer { get { throw null; } set { } }
        public System.IdentityModel.Protocols.WSTrust.WSTrustFeb2005ResponseSerializer WSTrustFeb2005ResponseSerializer { get { throw null; } set { } }
        public virtual System.IdentityModel.SecurityTokenService CreateSecurityTokenService() { throw null; }
    }
    public sealed partial class SystemIdentityModelSection : System.Configuration.ConfigurationSection
    {
        public const string SectionName = "system.identityModel";
        public SystemIdentityModelSection() { }
        public static System.IdentityModel.Configuration.SystemIdentityModelSection Current { get { throw null; } }
        public static System.IdentityModel.Configuration.IdentityConfigurationElement DefaultIdentityConfigurationElement { get { throw null; } }
        [System.Configuration.ConfigurationPropertyAttribute("", Options=System.Configuration.ConfigurationPropertyOptions.IsDefaultCollection)]
        public System.IdentityModel.Configuration.IdentityConfigurationElementCollection IdentityConfigurationElements { get { throw null; } }
    }
    public sealed partial class TokenReplayDetectionElement : System.Configuration.ConfigurationElement
    {
        public TokenReplayDetectionElement() { }
        [System.Configuration.ConfigurationPropertyAttribute("enabled", IsRequired=false, DefaultValue=false)]
        public bool Enabled { get { throw null; } set { } }
        [System.ComponentModel.TypeConverterAttribute("System.IdentityModel.Configuration.TimeSpanOrInfiniteConverter")]
        [System.Configuration.ConfigurationPropertyAttribute("expirationPeriod", IsRequired=false, DefaultValue="10675199.02:48:05.4775807")]
        public System.TimeSpan ExpirationPeriod { get { throw null; } set { } }
        protected override System.Configuration.ConfigurationPropertyCollection Properties { get { throw null; } }
    }
    public sealed partial class X509CertificateValidationElement : System.Configuration.ConfigurationElement
    {
        public X509CertificateValidationElement() { }
        [System.Configuration.ConfigurationPropertyAttribute("certificateValidationMode", IsRequired=false, DefaultValue=System.ServiceModel.Security.X509CertificateValidationMode.PeerOrChainTrust)]
        public System.ServiceModel.Security.X509CertificateValidationMode CertificateValidationMode { get { throw null; } set { } }
        [System.Configuration.ConfigurationPropertyAttribute("certificateValidator", IsRequired=false)]
        public System.IdentityModel.Configuration.CustomTypeElement CertificateValidator { get { throw null; } set { } }
        protected override System.Configuration.ConfigurationPropertyCollection Properties { get { throw null; } }
        [System.Configuration.ConfigurationPropertyAttribute("revocationMode", IsRequired=false, DefaultValue=System.Security.Cryptography.X509Certificates.X509RevocationMode.Online)]
        public System.Security.Cryptography.X509Certificates.X509RevocationMode RevocationMode { get { throw null; } set { } }
        [System.Configuration.ConfigurationPropertyAttribute("trustedStoreLocation", IsRequired=false, DefaultValue=System.Security.Cryptography.X509Certificates.StoreLocation.LocalMachine)]
        public System.Security.Cryptography.X509Certificates.StoreLocation TrustedStoreLocation { get { throw null; } set { } }
    }
}
namespace System.IdentityModel.Metadata
{
    public partial class ApplicationServiceDescriptor : System.IdentityModel.Metadata.WebServiceDescriptor
    {
        public ApplicationServiceDescriptor() { }
        public System.Collections.Generic.ICollection<System.IdentityModel.Protocols.WSTrust.EndpointReference> Endpoints { get { throw null; } }
        public System.Collections.Generic.ICollection<System.IdentityModel.Protocols.WSTrust.EndpointReference> PassiveRequestorEndpoints { get { throw null; } }
    }
    public partial class ContactPerson
    {
        public ContactPerson() { }
        public ContactPerson(System.IdentityModel.Metadata.ContactType contactType) { }
        public string Company { get { throw null; } set { } }
        public System.Collections.Generic.ICollection<string> EmailAddresses { get { throw null; } }
        public string GivenName { get { throw null; } set { } }
        public string Surname { get { throw null; } set { } }
        public System.Collections.Generic.ICollection<string> TelephoneNumbers { get { throw null; } }
        public System.IdentityModel.Metadata.ContactType Type { get { throw null; } set { } }
    }
    public enum ContactType
    {
        Administrative = 3,
        Billing = 4,
        Other = 5,
        Support = 2,
        Technical = 1,
        Unspecified = 0,
    }
    public partial class DisplayClaim
    {
        public DisplayClaim(string claimType) { }
        public DisplayClaim(string claimType, string displayTag, string description) { }
        public DisplayClaim(string claimType, string displayTag, string description, string displayValue) { }
        public DisplayClaim(string claimType, string displayTag, string description, string displayValue, bool optional) { }
        public string ClaimType { get { throw null; } }
        public string Description { get { throw null; } set { } }
        public string DisplayTag { get { throw null; } set { } }
        public string DisplayValue { get { throw null; } set { } }
        public bool Optional { get { throw null; } set { } }
        public bool WriteOptionalAttribute { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public static System.IdentityModel.Metadata.DisplayClaim CreateDisplayClaimFromClaimType(string claimType) { throw null; }
    }
    public partial class EncryptionMethod
    {
        public EncryptionMethod(System.Uri algorithm) { }
        public System.Uri Algorithm { get { throw null; } set { } }
    }
    public partial class EntitiesDescriptor : System.IdentityModel.Metadata.MetadataBase
    {
        public EntitiesDescriptor() { }
        public EntitiesDescriptor(System.Collections.ObjectModel.Collection<System.IdentityModel.Metadata.EntitiesDescriptor> entityGroupList) { }
        public EntitiesDescriptor(System.Collections.ObjectModel.Collection<System.IdentityModel.Metadata.EntityDescriptor> entityList) { }
        public EntitiesDescriptor(System.Collections.ObjectModel.Collection<System.IdentityModel.Metadata.EntityDescriptor> entityList, System.Collections.ObjectModel.Collection<System.IdentityModel.Metadata.EntitiesDescriptor> entityGroupList) { }
        public System.Collections.Generic.ICollection<System.IdentityModel.Metadata.EntityDescriptor> ChildEntities { get { throw null; } }
        public System.Collections.Generic.ICollection<System.IdentityModel.Metadata.EntitiesDescriptor> ChildEntityGroups { get { throw null; } }
        public string Name { get { throw null; } set { } }
    }
    public partial class EntityDescriptor : System.IdentityModel.Metadata.MetadataBase
    {
        public EntityDescriptor() { }
        public EntityDescriptor(System.IdentityModel.Metadata.EntityId entityId) { }
        public System.Collections.Generic.ICollection<System.IdentityModel.Metadata.ContactPerson> Contacts { get { throw null; } }
        public System.IdentityModel.Metadata.EntityId EntityId { get { throw null; } set { } }
        public string FederationId { get { throw null; } set { } }
        public System.IdentityModel.Metadata.Organization Organization { get { throw null; } set { } }
        public System.Collections.Generic.ICollection<System.IdentityModel.Metadata.RoleDescriptor> RoleDescriptors { get { throw null; } }
    }
    public partial class EntityId
    {
        public EntityId() { }
        public EntityId(string id) { }
        public string Id { get { throw null; } set { } }
    }
    public partial class IdentityProviderSingleSignOnDescriptor : System.IdentityModel.Metadata.SingleSignOnDescriptor
    {
        public IdentityProviderSingleSignOnDescriptor() { }
        public System.Collections.Generic.ICollection<System.IdentityModel.Metadata.ProtocolEndpoint> SingleSignOnServices { get { throw null; } }
        public System.Collections.Generic.ICollection<System.IdentityModel.Tokens.Saml2Attribute> SupportedAttributes { get { throw null; } }
        public bool WantAuthenticationRequestsSigned { get { throw null; } set { } }
    }
    public partial class IndexedProtocolEndpoint : System.IdentityModel.Metadata.ProtocolEndpoint
    {
        public IndexedProtocolEndpoint() { }
        public IndexedProtocolEndpoint(int index, System.Uri binding, System.Uri location) { }
        public int Index { get { throw null; } set { } }
        public System.Nullable<bool> IsDefault { get { throw null; } set { } }
    }
    public partial class IndexedProtocolEndpointDictionary : System.Collections.Generic.SortedList<int, System.IdentityModel.Metadata.IndexedProtocolEndpoint>
    {
        public IndexedProtocolEndpointDictionary() { }
        public System.IdentityModel.Metadata.IndexedProtocolEndpoint Default { get { throw null; } }
    }
    public partial class KeyDescriptor
    {
        public KeyDescriptor() { }
        public KeyDescriptor(System.IdentityModel.Tokens.SecurityKeyIdentifier ski) { }
        public System.Collections.Generic.ICollection<System.IdentityModel.Metadata.EncryptionMethod> EncryptionMethods { get { throw null; } }
        public System.IdentityModel.Tokens.SecurityKeyIdentifier KeyInfo { get { throw null; } set { } }
        public System.IdentityModel.Metadata.KeyType Use { get { throw null; } set { } }
    }
    public enum KeyType
    {
        Encryption = 2,
        Signing = 1,
        Unspecified = 0,
    }
    public abstract partial class LocalizedEntry
    {
        protected LocalizedEntry() { }
        protected LocalizedEntry(System.Globalization.CultureInfo language) { }
        public System.Globalization.CultureInfo Language { get { throw null; } set { } }
    }
    public partial class LocalizedEntryCollection<T> : System.Collections.ObjectModel.KeyedCollection<System.Globalization.CultureInfo, T> where T : System.IdentityModel.Metadata.LocalizedEntry
    {
        public LocalizedEntryCollection() { }
        protected override System.Globalization.CultureInfo GetKeyForItem(T item) { throw null; }
    }
    public partial class LocalizedName : System.IdentityModel.Metadata.LocalizedEntry
    {
        public LocalizedName() { }
        public LocalizedName(string name, System.Globalization.CultureInfo language) { }
        public string Name { get { throw null; } set { } }
    }
    public partial class LocalizedUri : System.IdentityModel.Metadata.LocalizedEntry
    {
        public LocalizedUri() { }
        public LocalizedUri(System.Uri uri, System.Globalization.CultureInfo language) { }
        public System.Uri Uri { get { throw null; } set { } }
    }
    public abstract partial class MetadataBase
    {
        protected MetadataBase() { }
        public System.IdentityModel.Tokens.SigningCredentials SigningCredentials { get { throw null; } set { } }
    }
    [System.SerializableAttribute]
    public partial class MetadataSerializationException : System.Exception
    {
        public MetadataSerializationException() { }
        protected MetadataSerializationException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
        public MetadataSerializationException(string message) { }
        public MetadataSerializationException(string message, System.Exception innerException) { }
    }
    public partial class MetadataSerializer
    {
        public const string LanguageAttribute = "xml:lang";
        public const string LanguageLocalName = "lang";
        public const string LanguageNamespaceUri = "http://www.w3.org/XML/1998/namespace";
        public const string LanguagePrefix = "xml";
        public MetadataSerializer() { }
        public MetadataSerializer(System.IdentityModel.Selectors.SecurityTokenSerializer tokenSerializer) { }
        public System.ServiceModel.Security.X509CertificateValidationMode CertificateValidationMode { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public System.IdentityModel.Selectors.X509CertificateValidator CertificateValidator { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public System.Security.Cryptography.X509Certificates.X509RevocationMode RevocationMode { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public System.IdentityModel.Selectors.SecurityTokenSerializer SecurityTokenSerializer { get { throw null; } }
        public System.Collections.Generic.List<string> TrustedIssuers { get { throw null; } }
        public System.Security.Cryptography.X509Certificates.StoreLocation TrustedStoreLocation { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        protected virtual System.IdentityModel.Metadata.ApplicationServiceDescriptor CreateApplicationServiceInstance() { throw null; }
        protected virtual System.IdentityModel.Metadata.ContactPerson CreateContactPersonInstance() { throw null; }
        protected virtual System.IdentityModel.Metadata.EntitiesDescriptor CreateEntitiesDescriptorInstance() { throw null; }
        protected virtual System.IdentityModel.Metadata.EntityDescriptor CreateEntityDescriptorInstance() { throw null; }
        protected virtual System.IdentityModel.Metadata.IdentityProviderSingleSignOnDescriptor CreateIdentityProviderSingleSignOnDescriptorInstance() { throw null; }
        protected virtual System.IdentityModel.Metadata.IndexedProtocolEndpoint CreateIndexedProtocolEndpointInstance() { throw null; }
        protected virtual System.IdentityModel.Metadata.KeyDescriptor CreateKeyDescriptorInstance() { throw null; }
        protected virtual System.IdentityModel.Metadata.LocalizedName CreateLocalizedNameInstance() { throw null; }
        protected virtual System.IdentityModel.Metadata.LocalizedUri CreateLocalizedUriInstance() { throw null; }
        protected virtual System.IdentityModel.Metadata.Organization CreateOrganizationInstance() { throw null; }
        protected virtual System.IdentityModel.Metadata.ProtocolEndpoint CreateProtocolEndpointInstance() { throw null; }
        protected virtual System.IdentityModel.Metadata.SecurityTokenServiceDescriptor CreateSecurityTokenServiceDescriptorInstance() { throw null; }
        protected virtual System.IdentityModel.Metadata.ServiceProviderSingleSignOnDescriptor CreateServiceProviderSingleSignOnDescriptorInstance() { throw null; }
        protected virtual System.Security.Cryptography.X509Certificates.X509Certificate2 GetMetadataSigningCertificate(System.IdentityModel.Tokens.SecurityKeyIdentifier ski) { throw null; }
        protected virtual System.IdentityModel.Metadata.ApplicationServiceDescriptor ReadApplicationServiceDescriptor(System.Xml.XmlReader reader) { throw null; }
        protected virtual System.IdentityModel.Tokens.Saml2Attribute ReadAttribute(System.Xml.XmlReader reader) { throw null; }
        protected virtual System.IdentityModel.Metadata.ContactPerson ReadContactPerson(System.Xml.XmlReader reader) { throw null; }
        protected virtual void ReadCustomAttributes<T>(System.Xml.XmlReader reader, T target) { }
        protected virtual bool ReadCustomElement<T>(System.Xml.XmlReader reader, T target) { throw null; }
        protected virtual void ReadCustomRoleDescriptor(string xsiType, System.Xml.XmlReader reader, System.IdentityModel.Metadata.EntityDescriptor entityDescriptor) { }
        protected virtual System.IdentityModel.Metadata.DisplayClaim ReadDisplayClaim(System.Xml.XmlReader reader) { throw null; }
        protected virtual System.IdentityModel.Metadata.EntitiesDescriptor ReadEntitiesDescriptor(System.Xml.XmlReader reader, System.IdentityModel.Selectors.SecurityTokenResolver tokenResolver) { throw null; }
        protected virtual System.IdentityModel.Metadata.EntityDescriptor ReadEntityDescriptor(System.Xml.XmlReader inputReader, System.IdentityModel.Selectors.SecurityTokenResolver tokenResolver) { throw null; }
        protected virtual System.IdentityModel.Metadata.IdentityProviderSingleSignOnDescriptor ReadIdentityProviderSingleSignOnDescriptor(System.Xml.XmlReader reader) { throw null; }
        protected virtual System.IdentityModel.Metadata.IndexedProtocolEndpoint ReadIndexedProtocolEndpoint(System.Xml.XmlReader reader) { throw null; }
        protected virtual System.IdentityModel.Metadata.KeyDescriptor ReadKeyDescriptor(System.Xml.XmlReader reader) { throw null; }
        protected virtual System.IdentityModel.Metadata.LocalizedName ReadLocalizedName(System.Xml.XmlReader reader) { throw null; }
        protected virtual System.IdentityModel.Metadata.LocalizedUri ReadLocalizedUri(System.Xml.XmlReader reader) { throw null; }
        public System.IdentityModel.Metadata.MetadataBase ReadMetadata(System.IO.Stream stream) { throw null; }
        public System.IdentityModel.Metadata.MetadataBase ReadMetadata(System.Xml.XmlReader reader) { throw null; }
        public System.IdentityModel.Metadata.MetadataBase ReadMetadata(System.Xml.XmlReader reader, System.IdentityModel.Selectors.SecurityTokenResolver tokenResolver) { throw null; }
        protected virtual System.IdentityModel.Metadata.MetadataBase ReadMetadataCore(System.Xml.XmlReader reader, System.IdentityModel.Selectors.SecurityTokenResolver tokenResolver) { throw null; }
        protected virtual System.IdentityModel.Metadata.Organization ReadOrganization(System.Xml.XmlReader reader) { throw null; }
        protected virtual System.IdentityModel.Metadata.ProtocolEndpoint ReadProtocolEndpoint(System.Xml.XmlReader reader) { throw null; }
        protected virtual void ReadRoleDescriptorAttributes(System.Xml.XmlReader reader, System.IdentityModel.Metadata.RoleDescriptor roleDescriptor) { }
        protected virtual bool ReadRoleDescriptorElement(System.Xml.XmlReader reader, System.IdentityModel.Metadata.RoleDescriptor roleDescriptor) { throw null; }
        protected virtual System.IdentityModel.Metadata.SecurityTokenServiceDescriptor ReadSecurityTokenServiceDescriptor(System.Xml.XmlReader reader) { throw null; }
        protected virtual System.IdentityModel.Metadata.ServiceProviderSingleSignOnDescriptor ReadServiceProviderSingleSignOnDescriptor(System.Xml.XmlReader reader) { throw null; }
        protected virtual void ReadSingleSignOnDescriptorAttributes(System.Xml.XmlReader reader, System.IdentityModel.Metadata.SingleSignOnDescriptor roleDescriptor) { }
        protected virtual bool ReadSingleSignOnDescriptorElement(System.Xml.XmlReader reader, System.IdentityModel.Metadata.SingleSignOnDescriptor singleSignOnDescriptor) { throw null; }
        protected virtual void ReadWebServiceDescriptorAttributes(System.Xml.XmlReader reader, System.IdentityModel.Metadata.WebServiceDescriptor roleDescriptor) { }
        public virtual bool ReadWebServiceDescriptorElement(System.Xml.XmlReader reader, System.IdentityModel.Metadata.WebServiceDescriptor roleDescriptor) { throw null; }
        protected virtual void ValidateIssuer(System.Security.Cryptography.X509Certificates.X509Certificate2 signingCertificate) { }
        protected virtual void ValidateSigningCredential(System.IdentityModel.Tokens.SigningCredentials signingCredentials) { }
        protected virtual void WriteApplicationServiceDescriptor(System.Xml.XmlWriter writer, System.IdentityModel.Metadata.ApplicationServiceDescriptor appService) { }
        protected virtual void WriteAttribute(System.Xml.XmlWriter writer, System.IdentityModel.Tokens.Saml2Attribute data) { }
        protected virtual void WriteContactPerson(System.Xml.XmlWriter writer, System.IdentityModel.Metadata.ContactPerson contactPerson) { }
        protected virtual void WriteCustomAttributes<T>(System.Xml.XmlWriter writer, T source) { }
        protected virtual void WriteCustomElements<T>(System.Xml.XmlWriter writer, T source) { }
        protected virtual void WriteDisplayClaim(System.Xml.XmlWriter writer, System.IdentityModel.Metadata.DisplayClaim claim) { }
        protected virtual void WriteEntitiesDescriptor(System.Xml.XmlWriter inputWriter, System.IdentityModel.Metadata.EntitiesDescriptor entitiesDescriptor) { }
        protected virtual void WriteEntityDescriptor(System.Xml.XmlWriter inputWriter, System.IdentityModel.Metadata.EntityDescriptor entityDescriptor) { }
        protected virtual void WriteIdentityProviderSingleSignOnDescriptor(System.Xml.XmlWriter writer, System.IdentityModel.Metadata.IdentityProviderSingleSignOnDescriptor identityProviderSingleSignOnDescriptor) { }
        protected virtual void WriteIndexedProtocolEndpoint(System.Xml.XmlWriter writer, System.IdentityModel.Metadata.IndexedProtocolEndpoint indexedEP, System.Xml.XmlQualifiedName element) { }
        protected virtual void WriteKeyDescriptor(System.Xml.XmlWriter writer, System.IdentityModel.Metadata.KeyDescriptor keyDescriptor) { }
        protected virtual void WriteLocalizedName(System.Xml.XmlWriter writer, System.IdentityModel.Metadata.LocalizedName name, System.Xml.XmlQualifiedName element) { }
        protected virtual void WriteLocalizedUri(System.Xml.XmlWriter writer, System.IdentityModel.Metadata.LocalizedUri uri, System.Xml.XmlQualifiedName element) { }
        public void WriteMetadata(System.IO.Stream stream, System.IdentityModel.Metadata.MetadataBase metadata) { }
        public void WriteMetadata(System.Xml.XmlWriter writer, System.IdentityModel.Metadata.MetadataBase metadata) { }
        protected virtual void WriteMetadataCore(System.Xml.XmlWriter writer, System.IdentityModel.Metadata.MetadataBase metadataBase) { }
        protected virtual void WriteOrganization(System.Xml.XmlWriter writer, System.IdentityModel.Metadata.Organization organization) { }
        protected virtual void WriteProtocolEndpoint(System.Xml.XmlWriter writer, System.IdentityModel.Metadata.ProtocolEndpoint endpoint, System.Xml.XmlQualifiedName element) { }
        protected virtual void WriteRoleDescriptorAttributes(System.Xml.XmlWriter writer, System.IdentityModel.Metadata.RoleDescriptor roleDescriptor) { }
        protected virtual void WriteRoleDescriptorElements(System.Xml.XmlWriter writer, System.IdentityModel.Metadata.RoleDescriptor roleDescriptor) { }
        protected virtual void WriteSecurityTokenServiceDescriptor(System.Xml.XmlWriter writer, System.IdentityModel.Metadata.SecurityTokenServiceDescriptor securityTokenServiceDescriptor) { }
        protected virtual void WriteServiceProviderSingleSignOnDescriptor(System.Xml.XmlWriter writer, System.IdentityModel.Metadata.ServiceProviderSingleSignOnDescriptor serviceProviderSingleSignOnDescriptor) { }
        protected virtual void WriteSingleSignOnDescriptorAttributes(System.Xml.XmlWriter writer, System.IdentityModel.Metadata.SingleSignOnDescriptor singleSignOnDescriptor) { }
        protected virtual void WriteSingleSignOnDescriptorElements(System.Xml.XmlWriter writer, System.IdentityModel.Metadata.SingleSignOnDescriptor singleSignOnDescriptor) { }
        protected virtual void WriteWebServiceDescriptorAttributes(System.Xml.XmlWriter writer, System.IdentityModel.Metadata.WebServiceDescriptor wsDescriptor) { }
        protected virtual void WriteWebServiceDescriptorElements(System.Xml.XmlWriter writer, System.IdentityModel.Metadata.WebServiceDescriptor wsDescriptor) { }
    }
    public partial class Organization
    {
        public Organization() { }
        public Organization(System.IdentityModel.Metadata.LocalizedEntryCollection<System.IdentityModel.Metadata.LocalizedName> names, System.IdentityModel.Metadata.LocalizedEntryCollection<System.IdentityModel.Metadata.LocalizedName> displayNames, System.IdentityModel.Metadata.LocalizedEntryCollection<System.IdentityModel.Metadata.LocalizedUri> urls) { }
        public System.IdentityModel.Metadata.LocalizedEntryCollection<System.IdentityModel.Metadata.LocalizedName> DisplayNames { get { throw null; } }
        public System.IdentityModel.Metadata.LocalizedEntryCollection<System.IdentityModel.Metadata.LocalizedName> Names { get { throw null; } }
        public System.IdentityModel.Metadata.LocalizedEntryCollection<System.IdentityModel.Metadata.LocalizedUri> Urls { get { throw null; } }
    }
    public partial class ProtocolEndpoint
    {
        public ProtocolEndpoint() { }
        public ProtocolEndpoint(System.Uri binding, System.Uri location) { }
        public System.Uri Binding { get { throw null; } set { } }
        public System.Uri Location { get { throw null; } set { } }
        public System.Uri ResponseLocation { get { throw null; } set { } }
    }
    public abstract partial class RoleDescriptor
    {
        protected RoleDescriptor() { }
        protected RoleDescriptor(System.Collections.ObjectModel.Collection<System.Uri> protocolsSupported) { }
        public System.Collections.Generic.ICollection<System.IdentityModel.Metadata.ContactPerson> Contacts { get { throw null; } }
        public System.Uri ErrorUrl { get { throw null; } set { } }
        public System.Collections.Generic.ICollection<System.IdentityModel.Metadata.KeyDescriptor> Keys { get { throw null; } }
        public System.IdentityModel.Metadata.Organization Organization { get { throw null; } set { } }
        public System.Collections.Generic.ICollection<System.Uri> ProtocolsSupported { get { throw null; } }
        public System.DateTime ValidUntil { get { throw null; } set { } }
    }
    public partial class SecurityTokenServiceDescriptor : System.IdentityModel.Metadata.WebServiceDescriptor
    {
        public SecurityTokenServiceDescriptor() { }
        public System.Collections.ObjectModel.Collection<System.IdentityModel.Protocols.WSTrust.EndpointReference> PassiveRequestorEndpoints { get { throw null; } }
        public System.Collections.ObjectModel.Collection<System.IdentityModel.Protocols.WSTrust.EndpointReference> SecurityTokenServiceEndpoints { get { throw null; } }
    }
    public partial class ServiceProviderSingleSignOnDescriptor : System.IdentityModel.Metadata.SingleSignOnDescriptor
    {
        public ServiceProviderSingleSignOnDescriptor() { }
        public ServiceProviderSingleSignOnDescriptor(System.IdentityModel.Metadata.IndexedProtocolEndpointDictionary collection) { }
        public System.IdentityModel.Metadata.IndexedProtocolEndpointDictionary AssertionConsumerServices { get { throw null; } }
        public bool AuthenticationRequestsSigned { get { throw null; } set { } }
        public bool WantAssertionsSigned { get { throw null; } set { } }
    }
    public partial class SingleSignOnDescriptor : System.IdentityModel.Metadata.RoleDescriptor
    {
        public SingleSignOnDescriptor() { }
        public System.IdentityModel.Metadata.IndexedProtocolEndpointDictionary ArtifactResolutionServices { get { throw null; } }
        public System.Collections.Generic.ICollection<System.Uri> NameIdentifierFormats { get { throw null; } }
        public System.Collections.ObjectModel.Collection<System.IdentityModel.Metadata.ProtocolEndpoint> SingleLogoutServices { get { throw null; } }
    }
    public abstract partial class WebServiceDescriptor : System.IdentityModel.Metadata.RoleDescriptor
    {
        protected WebServiceDescriptor() { }
        public System.Collections.Generic.ICollection<System.IdentityModel.Metadata.DisplayClaim> ClaimTypesOffered { get { throw null; } }
        public System.Collections.Generic.ICollection<System.IdentityModel.Metadata.DisplayClaim> ClaimTypesRequested { get { throw null; } }
        public string ServiceDescription { get { throw null; } set { } }
        public string ServiceDisplayName { get { throw null; } set { } }
        public System.Collections.Generic.ICollection<System.IdentityModel.Protocols.WSTrust.EndpointReference> TargetScopes { get { throw null; } }
        public System.Collections.Generic.ICollection<System.Uri> TokenTypesOffered { get { throw null; } }
    }
}
namespace System.IdentityModel.Policy
{
    public abstract partial class AuthorizationContext : System.IdentityModel.Policy.IAuthorizationComponent
    {
        protected AuthorizationContext() { }
        public abstract System.Collections.ObjectModel.ReadOnlyCollection<System.IdentityModel.Claims.ClaimSet> ClaimSets { get; }
        public abstract System.DateTime ExpirationTime { get; }
        public abstract string Id { get; }
        public abstract System.Collections.Generic.IDictionary<string, object> Properties { get; }
        public static System.IdentityModel.Policy.AuthorizationContext CreateDefaultAuthorizationContext(System.Collections.Generic.IList<System.IdentityModel.Policy.IAuthorizationPolicy> authorizationPolicies) { throw null; }
    }
    public abstract partial class EvaluationContext
    {
        protected EvaluationContext() { }
        public abstract System.Collections.ObjectModel.ReadOnlyCollection<System.IdentityModel.Claims.ClaimSet> ClaimSets { get; }
        public abstract int Generation { get; }
        public abstract System.Collections.Generic.IDictionary<string, object> Properties { get; }
        public abstract void AddClaimSet(System.IdentityModel.Policy.IAuthorizationPolicy policy, System.IdentityModel.Claims.ClaimSet claimSet);
        public abstract void RecordExpirationTime(System.DateTime expirationTime);
    }
    public partial interface IAuthorizationComponent
    {
        string Id { get; }
    }
    public partial interface IAuthorizationPolicy : System.IdentityModel.Policy.IAuthorizationComponent
    {
        System.IdentityModel.Claims.ClaimSet Issuer { get; }
        bool Evaluate(System.IdentityModel.Policy.EvaluationContext evaluationContext, ref object state);
    }
}
namespace System.IdentityModel.Protocols.WSTrust
{
    public partial class AdditionalContext
    {
        public AdditionalContext() { }
        public AdditionalContext(System.Collections.Generic.IEnumerable<System.IdentityModel.Protocols.WSTrust.ContextItem> items) { }
        public System.Collections.Generic.IList<System.IdentityModel.Protocols.WSTrust.ContextItem> Items { get { throw null; } }
    }
    public partial class BinaryExchange
    {
        public BinaryExchange(byte[] binaryData, System.Uri valueType) { }
        public BinaryExchange(byte[] binaryData, System.Uri valueType, System.Uri encodingType) { }
        public byte[] BinaryData { get { throw null; } }
        public System.Uri EncodingType { get { throw null; } }
        public System.Uri ValueType { get { throw null; } }
    }
    public partial class ContextItem
    {
        public ContextItem(System.Uri name) { }
        public ContextItem(System.Uri name, string value) { }
        public ContextItem(System.Uri name, string value, System.Uri scope) { }
        public System.Uri Name { get { throw null; } set { } }
        public System.Uri Scope { get { throw null; } set { } }
        public string Value { get { throw null; } set { } }
    }
    public partial class EndpointReference
    {
        public EndpointReference(string uri) { }
        public System.Collections.ObjectModel.Collection<System.Xml.XmlElement> Details { get { throw null; } }
        public System.Uri Uri { get { throw null; } }
        public static System.IdentityModel.Protocols.WSTrust.EndpointReference ReadFrom(System.Xml.XmlDictionaryReader reader) { throw null; }
        public static System.IdentityModel.Protocols.WSTrust.EndpointReference ReadFrom(System.Xml.XmlReader reader) { throw null; }
        public void WriteTo(System.Xml.XmlWriter writer) { }
    }
    public partial class Entropy : System.IdentityModel.Protocols.WSTrust.ProtectedKey
    {
        public Entropy(byte[] secret) : base (default(byte[])) { }
        public Entropy(byte[] secret, System.IdentityModel.Tokens.EncryptingCredentials wrappingCredentials) : base (default(byte[])) { }
        public Entropy(System.IdentityModel.Protocols.WSTrust.ProtectedKey protectedKey) : base (default(byte[])) { }
        public Entropy(int entropySizeInBits) : base (default(byte[])) { }
    }
    [System.SerializableAttribute]
    public partial class InvalidRequestException : System.IdentityModel.RequestException
    {
        public InvalidRequestException() { }
        protected InvalidRequestException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
        public InvalidRequestException(string message) { }
        public InvalidRequestException(string message, System.Exception innerException) { }
    }
    public static partial class KeyTypes
    {
        public const string Asymmetric = "http://schemas.microsoft.com/idfx/keytype/asymmetric";
        public const string Bearer = "http://schemas.microsoft.com/idfx/keytype/bearer";
        public const string Symmetric = "http://schemas.microsoft.com/idfx/keytype/symmetric";
    }
    public partial class Lifetime
    {
        public Lifetime(System.DateTime created, System.DateTime expires) { }
        public Lifetime(System.Nullable<System.DateTime> created, System.Nullable<System.DateTime> expires) { }
        public System.Nullable<System.DateTime> Created { get { throw null; } set { } }
        public System.Nullable<System.DateTime> Expires { get { throw null; } set { } }
    }
    public partial class Participants
    {
        public Participants() { }
        public System.Collections.Generic.List<System.IdentityModel.Protocols.WSTrust.EndpointReference> Participant { get { throw null; } }
        public System.IdentityModel.Protocols.WSTrust.EndpointReference Primary { get { throw null; } set { } }
    }
    public partial class ProtectedKey
    {
        public ProtectedKey(byte[] secret) { }
        public ProtectedKey(byte[] secret, System.IdentityModel.Tokens.EncryptingCredentials wrappingCredentials) { }
        public System.IdentityModel.Tokens.EncryptingCredentials WrappingCredentials { get { throw null; } }
        public byte[] GetKeyBytes() { throw null; }
    }
    public partial class Renewing
    {
        public Renewing() { }
        public Renewing(bool allowRenewal, bool okForRenewalAfterExpiration) { }
        public bool AllowRenewal { get { throw null; } set { } }
        public bool OkForRenewalAfterExpiration { get { throw null; } set { } }
    }
    public partial class RequestClaim
    {
        public RequestClaim(string claimType) { }
        public RequestClaim(string claimType, bool isOptional) { }
        public RequestClaim(string claimType, bool isOptional, string value) { }
        public string ClaimType { get { throw null; } }
        public bool IsOptional { get { throw null; } set { } }
        public string Value { get { throw null; } set { } }
    }
    public partial class RequestClaimCollection : System.Collections.ObjectModel.Collection<System.IdentityModel.Protocols.WSTrust.RequestClaim>
    {
        public RequestClaimCollection() { }
        public string Dialect { get { throw null; } set { } }
    }
    public partial class RequestedProofToken
    {
        public RequestedProofToken(byte[] secret) { }
        public RequestedProofToken(byte[] secret, System.IdentityModel.Tokens.EncryptingCredentials wrappingCredentials) { }
        public RequestedProofToken(System.IdentityModel.Protocols.WSTrust.ProtectedKey protectedKey) { }
        public RequestedProofToken(string computedKeyAlgorithm) { }
        public string ComputedKeyAlgorithm { get { throw null; } }
        public System.IdentityModel.Protocols.WSTrust.ProtectedKey ProtectedKey { get { throw null; } }
    }
    public partial class RequestedSecurityToken
    {
        public RequestedSecurityToken(System.IdentityModel.Tokens.SecurityToken token) { }
        public RequestedSecurityToken(System.Xml.XmlElement tokenAsXml) { }
        public System.IdentityModel.Tokens.SecurityToken SecurityToken { get { throw null; } }
        public virtual System.Xml.XmlElement SecurityTokenXml { get { throw null; } }
    }
    public partial class RequestSecurityToken : System.IdentityModel.Protocols.WSTrust.WSTrustMessage
    {
        public RequestSecurityToken() { }
        public RequestSecurityToken(string requestType) { }
        public RequestSecurityToken(string requestType, string keyType) { }
        public System.IdentityModel.Tokens.SecurityTokenElement ActAs { get { throw null; } set { } }
        public System.IdentityModel.Protocols.WSTrust.AdditionalContext AdditionalContext { get { throw null; } set { } }
        public System.IdentityModel.Tokens.SecurityTokenElement CancelTarget { get { throw null; } set { } }
        public System.IdentityModel.Protocols.WSTrust.RequestClaimCollection Claims { get { throw null; } }
        public string ComputedKeyAlgorithm { get { throw null; } set { } }
        public System.Nullable<bool> Delegatable { get { throw null; } set { } }
        public System.IdentityModel.Tokens.SecurityTokenElement DelegateTo { get { throw null; } set { } }
        public System.IdentityModel.Tokens.SecurityTokenElement Encryption { get { throw null; } set { } }
        public System.Nullable<bool> Forwardable { get { throw null; } set { } }
        public System.IdentityModel.Protocols.WSTrust.EndpointReference Issuer { get { throw null; } set { } }
        public System.IdentityModel.Tokens.SecurityTokenElement OnBehalfOf { get { throw null; } set { } }
        public System.IdentityModel.Protocols.WSTrust.Participants Participants { get { throw null; } set { } }
        public System.IdentityModel.Tokens.SecurityTokenElement ProofEncryption { get { throw null; } set { } }
        public System.IdentityModel.Protocols.WSTrust.Renewing Renewing { get { throw null; } set { } }
        public System.IdentityModel.Tokens.SecurityTokenElement RenewTarget { get { throw null; } set { } }
        public System.IdentityModel.Protocols.WSTrust.RequestSecurityToken SecondaryParameters { get { throw null; } set { } }
        public System.IdentityModel.Tokens.SecurityTokenElement ValidateTarget { get { throw null; } set { } }
    }
    public partial class RequestSecurityTokenResponse : System.IdentityModel.Protocols.WSTrust.WSTrustMessage
    {
        public RequestSecurityTokenResponse() { }
        public RequestSecurityTokenResponse(System.IdentityModel.Protocols.WSTrust.WSTrustMessage message) { }
        public bool IsFinal { get { throw null; } set { } }
        public System.IdentityModel.Tokens.SecurityKeyIdentifierClause RequestedAttachedReference { get { throw null; } set { } }
        public System.IdentityModel.Protocols.WSTrust.RequestedProofToken RequestedProofToken { get { throw null; } set { } }
        public System.IdentityModel.Protocols.WSTrust.RequestedSecurityToken RequestedSecurityToken { get { throw null; } set { } }
        public bool RequestedTokenCancelled { get { throw null; } set { } }
        public System.IdentityModel.Tokens.SecurityKeyIdentifierClause RequestedUnattachedReference { get { throw null; } set { } }
        public System.IdentityModel.Protocols.WSTrust.Status Status { get { throw null; } set { } }
    }
    public static partial class RequestTypes
    {
        public const string Cancel = "http://schemas.microsoft.com/idfx/requesttype/cancel";
        public const string GetMetadata = "http://schemas.microsoft.com/idfx/requesttype/getMetadata";
        public const string Issue = "http://schemas.microsoft.com/idfx/requesttype/issue";
        public const string IssueCard = "http://schemas.microsoft.com/idfx/requesttype/issueCard";
        public const string Renew = "http://schemas.microsoft.com/idfx/requesttype/renew";
        public const string Validate = "http://schemas.microsoft.com/idfx/requesttype/validate";
    }
    public partial class Status
    {
        public Status(string code, string reason) { }
        public string Code { get { throw null; } set { } }
        public string Reason { get { throw null; } set { } }
    }
    public partial class UseKey
    {
        public UseKey() { }
        public UseKey(System.IdentityModel.Tokens.SecurityKeyIdentifier ski) { }
        public UseKey(System.IdentityModel.Tokens.SecurityKeyIdentifier ski, System.IdentityModel.Tokens.SecurityToken token) { }
        public UseKey(System.IdentityModel.Tokens.SecurityToken token) { }
        public System.IdentityModel.Tokens.SecurityKeyIdentifier SecurityKeyIdentifier { get { throw null; } }
        public System.IdentityModel.Tokens.SecurityToken Token { get { throw null; } }
    }
    public partial class WSTrust13RequestSerializer : System.IdentityModel.Protocols.WSTrust.WSTrustRequestSerializer
    {
        public WSTrust13RequestSerializer() { }
        public override bool CanRead(System.Xml.XmlReader reader) { throw null; }
        protected virtual System.IdentityModel.Protocols.WSTrust.RequestSecurityToken ReadSecondaryParameters(System.Xml.XmlReader reader, System.IdentityModel.Protocols.WSTrust.WSTrustSerializationContext context) { throw null; }
        public override System.IdentityModel.Protocols.WSTrust.RequestSecurityToken ReadXml(System.Xml.XmlReader reader, System.IdentityModel.Protocols.WSTrust.WSTrustSerializationContext context) { throw null; }
        public override void ReadXmlElement(System.Xml.XmlReader reader, System.IdentityModel.Protocols.WSTrust.RequestSecurityToken rst, System.IdentityModel.Protocols.WSTrust.WSTrustSerializationContext context) { }
        public override void WriteKnownRequestElement(System.IdentityModel.Protocols.WSTrust.RequestSecurityToken rst, System.Xml.XmlWriter writer, System.IdentityModel.Protocols.WSTrust.WSTrustSerializationContext context) { }
        public override void WriteXml(System.IdentityModel.Protocols.WSTrust.RequestSecurityToken request, System.Xml.XmlWriter writer, System.IdentityModel.Protocols.WSTrust.WSTrustSerializationContext context) { }
        public override void WriteXmlElement(System.Xml.XmlWriter writer, string elementName, object elementValue, System.IdentityModel.Protocols.WSTrust.RequestSecurityToken rst, System.IdentityModel.Protocols.WSTrust.WSTrustSerializationContext context) { }
    }
    public partial class WSTrust13ResponseSerializer : System.IdentityModel.Protocols.WSTrust.WSTrustResponseSerializer
    {
        public WSTrust13ResponseSerializer() { }
        public override bool CanRead(System.Xml.XmlReader reader) { throw null; }
        public override System.IdentityModel.Protocols.WSTrust.RequestSecurityTokenResponse ReadXml(System.Xml.XmlReader reader, System.IdentityModel.Protocols.WSTrust.WSTrustSerializationContext context) { throw null; }
        public override void ReadXmlElement(System.Xml.XmlReader reader, System.IdentityModel.Protocols.WSTrust.RequestSecurityTokenResponse rstr, System.IdentityModel.Protocols.WSTrust.WSTrustSerializationContext context) { }
        public override void WriteKnownResponseElement(System.IdentityModel.Protocols.WSTrust.RequestSecurityTokenResponse rstr, System.Xml.XmlWriter writer, System.IdentityModel.Protocols.WSTrust.WSTrustSerializationContext context) { }
        public override void WriteXml(System.IdentityModel.Protocols.WSTrust.RequestSecurityTokenResponse response, System.Xml.XmlWriter writer, System.IdentityModel.Protocols.WSTrust.WSTrustSerializationContext context) { }
        public override void WriteXmlElement(System.Xml.XmlWriter writer, string elementName, object elementValue, System.IdentityModel.Protocols.WSTrust.RequestSecurityTokenResponse rstr, System.IdentityModel.Protocols.WSTrust.WSTrustSerializationContext context) { }
    }
    public partial class WSTrustFeb2005RequestSerializer : System.IdentityModel.Protocols.WSTrust.WSTrustRequestSerializer
    {
        public WSTrustFeb2005RequestSerializer() { }
        public override bool CanRead(System.Xml.XmlReader reader) { throw null; }
        public override System.IdentityModel.Protocols.WSTrust.RequestSecurityToken ReadXml(System.Xml.XmlReader reader, System.IdentityModel.Protocols.WSTrust.WSTrustSerializationContext context) { throw null; }
        public override void ReadXmlElement(System.Xml.XmlReader reader, System.IdentityModel.Protocols.WSTrust.RequestSecurityToken rst, System.IdentityModel.Protocols.WSTrust.WSTrustSerializationContext context) { }
        public override void WriteKnownRequestElement(System.IdentityModel.Protocols.WSTrust.RequestSecurityToken rst, System.Xml.XmlWriter writer, System.IdentityModel.Protocols.WSTrust.WSTrustSerializationContext context) { }
        public override void WriteXml(System.IdentityModel.Protocols.WSTrust.RequestSecurityToken request, System.Xml.XmlWriter writer, System.IdentityModel.Protocols.WSTrust.WSTrustSerializationContext context) { }
        public override void WriteXmlElement(System.Xml.XmlWriter writer, string elementName, object elementValue, System.IdentityModel.Protocols.WSTrust.RequestSecurityToken rst, System.IdentityModel.Protocols.WSTrust.WSTrustSerializationContext context) { }
    }
    public partial class WSTrustFeb2005ResponseSerializer : System.IdentityModel.Protocols.WSTrust.WSTrustResponseSerializer
    {
        public WSTrustFeb2005ResponseSerializer() { }
        public override bool CanRead(System.Xml.XmlReader reader) { throw null; }
        public override System.IdentityModel.Protocols.WSTrust.RequestSecurityTokenResponse ReadXml(System.Xml.XmlReader reader, System.IdentityModel.Protocols.WSTrust.WSTrustSerializationContext context) { throw null; }
        public override void ReadXmlElement(System.Xml.XmlReader reader, System.IdentityModel.Protocols.WSTrust.RequestSecurityTokenResponse rstr, System.IdentityModel.Protocols.WSTrust.WSTrustSerializationContext context) { }
        public override void WriteKnownResponseElement(System.IdentityModel.Protocols.WSTrust.RequestSecurityTokenResponse rstr, System.Xml.XmlWriter writer, System.IdentityModel.Protocols.WSTrust.WSTrustSerializationContext context) { }
        public override void WriteXml(System.IdentityModel.Protocols.WSTrust.RequestSecurityTokenResponse response, System.Xml.XmlWriter writer, System.IdentityModel.Protocols.WSTrust.WSTrustSerializationContext context) { }
        public override void WriteXmlElement(System.Xml.XmlWriter writer, string elementName, object elementValue, System.IdentityModel.Protocols.WSTrust.RequestSecurityTokenResponse rstr, System.IdentityModel.Protocols.WSTrust.WSTrustSerializationContext context) { }
    }
    public abstract partial class WSTrustMessage : System.IdentityModel.OpenObject
    {
        protected WSTrustMessage() { }
        public bool AllowPostdating { get { throw null; } set { } }
        public System.IdentityModel.Protocols.WSTrust.EndpointReference AppliesTo { get { throw null; } set { } }
        public string AuthenticationType { get { throw null; } set { } }
        public System.IdentityModel.Protocols.WSTrust.BinaryExchange BinaryExchange { get { throw null; } set { } }
        public string CanonicalizationAlgorithm { get { throw null; } set { } }
        public string Context { get { throw null; } set { } }
        public string EncryptionAlgorithm { get { throw null; } set { } }
        public string EncryptWith { get { throw null; } set { } }
        public System.IdentityModel.Protocols.WSTrust.Entropy Entropy { get { throw null; } set { } }
        public System.Nullable<int> KeySizeInBits { get { throw null; } set { } }
        public string KeyType { get { throw null; } set { } }
        public string KeyWrapAlgorithm { get { throw null; } set { } }
        public System.IdentityModel.Protocols.WSTrust.Lifetime Lifetime { get { throw null; } set { } }
        public string ReplyTo { get { throw null; } set { } }
        public string RequestType { get { throw null; } set { } }
        public string SignatureAlgorithm { get { throw null; } set { } }
        public string SignWith { get { throw null; } set { } }
        public string TokenType { get { throw null; } set { } }
        public System.IdentityModel.Protocols.WSTrust.UseKey UseKey { get { throw null; } set { } }
    }
    public abstract partial class WSTrustRequestSerializer
    {
        protected WSTrustRequestSerializer() { }
        public abstract bool CanRead(System.Xml.XmlReader reader);
        public virtual System.IdentityModel.Protocols.WSTrust.RequestSecurityToken CreateRequestSecurityToken() { throw null; }
        protected virtual void ReadCustomElement(System.Xml.XmlReader reader, System.IdentityModel.Protocols.WSTrust.WSTrustSerializationContext context) { }
        public abstract System.IdentityModel.Protocols.WSTrust.RequestSecurityToken ReadXml(System.Xml.XmlReader reader, System.IdentityModel.Protocols.WSTrust.WSTrustSerializationContext context);
        public abstract void ReadXmlElement(System.Xml.XmlReader reader, System.IdentityModel.Protocols.WSTrust.RequestSecurityToken requestSecurityToken, System.IdentityModel.Protocols.WSTrust.WSTrustSerializationContext context);
        public virtual void Validate(System.IdentityModel.Protocols.WSTrust.RequestSecurityToken requestSecurityToken) { }
        public abstract void WriteKnownRequestElement(System.IdentityModel.Protocols.WSTrust.RequestSecurityToken requestSecurityToken, System.Xml.XmlWriter writer, System.IdentityModel.Protocols.WSTrust.WSTrustSerializationContext context);
        public abstract void WriteXml(System.IdentityModel.Protocols.WSTrust.RequestSecurityToken request, System.Xml.XmlWriter writer, System.IdentityModel.Protocols.WSTrust.WSTrustSerializationContext context);
        public abstract void WriteXmlElement(System.Xml.XmlWriter writer, string elementName, object elementValue, System.IdentityModel.Protocols.WSTrust.RequestSecurityToken requestSecurityToken, System.IdentityModel.Protocols.WSTrust.WSTrustSerializationContext context);
    }
    public abstract partial class WSTrustResponseSerializer
    {
        protected WSTrustResponseSerializer() { }
        public abstract bool CanRead(System.Xml.XmlReader reader);
        public virtual System.IdentityModel.Protocols.WSTrust.RequestSecurityTokenResponse CreateInstance() { throw null; }
        public abstract System.IdentityModel.Protocols.WSTrust.RequestSecurityTokenResponse ReadXml(System.Xml.XmlReader reader, System.IdentityModel.Protocols.WSTrust.WSTrustSerializationContext context);
        public abstract void ReadXmlElement(System.Xml.XmlReader reader, System.IdentityModel.Protocols.WSTrust.RequestSecurityTokenResponse requestSecurityTokenResponse, System.IdentityModel.Protocols.WSTrust.WSTrustSerializationContext context);
        public virtual void Validate(System.IdentityModel.Protocols.WSTrust.RequestSecurityTokenResponse requestSecurityTokenResponse) { }
        public abstract void WriteKnownResponseElement(System.IdentityModel.Protocols.WSTrust.RequestSecurityTokenResponse requestSecurityTokenResponse, System.Xml.XmlWriter writer, System.IdentityModel.Protocols.WSTrust.WSTrustSerializationContext context);
        public abstract void WriteXml(System.IdentityModel.Protocols.WSTrust.RequestSecurityTokenResponse response, System.Xml.XmlWriter writer, System.IdentityModel.Protocols.WSTrust.WSTrustSerializationContext context);
        public abstract void WriteXmlElement(System.Xml.XmlWriter writer, string elementName, object elementValue, System.IdentityModel.Protocols.WSTrust.RequestSecurityTokenResponse requestSecurityTokenResponse, System.IdentityModel.Protocols.WSTrust.WSTrustSerializationContext context);
    }
    public partial class WSTrustSerializationContext
    {
        public WSTrustSerializationContext() { }
        public WSTrustSerializationContext(System.IdentityModel.Tokens.SecurityTokenHandlerCollectionManager securityTokenHandlerCollectionManager) { }
        public WSTrustSerializationContext(System.IdentityModel.Tokens.SecurityTokenHandlerCollectionManager securityTokenHandlerCollectionManager, System.IdentityModel.Selectors.SecurityTokenResolver securityTokenResolver, System.IdentityModel.Selectors.SecurityTokenResolver useKeyTokenResolver) { }
        public System.IdentityModel.Tokens.SecurityTokenHandlerCollectionManager SecurityTokenHandlerCollectionManager { get { throw null; } set { } }
        public System.IdentityModel.Tokens.SecurityTokenHandlerCollection SecurityTokenHandlers { get { throw null; } }
        public System.IdentityModel.Selectors.SecurityTokenResolver TokenResolver { get { throw null; } set { } }
        public System.IdentityModel.Selectors.SecurityTokenResolver UseKeyTokenResolver { get { throw null; } set { } }
    }
    [System.SerializableAttribute]
    public partial class WSTrustSerializationException : System.Exception, System.Runtime.Serialization.ISerializable
    {
        public WSTrustSerializationException() { }
        protected WSTrustSerializationException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
        public WSTrustSerializationException(string message) { }
        public WSTrustSerializationException(string message, System.Exception inner) { }
    }
}
namespace System.IdentityModel.Selectors
{
    public enum AudienceUriMode
    {
        Always = 1,
        BearerKeyOnly = 2,
        Never = 0,
    }
    public static partial class AudienceUriModeValidationHelper
    {
        public static bool IsDefined(System.IdentityModel.Selectors.AudienceUriMode validationMode) { throw null; }
    }
    public partial class CustomUserNameSecurityTokenAuthenticator : System.IdentityModel.Selectors.UserNameSecurityTokenAuthenticator
    {
        public CustomUserNameSecurityTokenAuthenticator(System.IdentityModel.Selectors.UserNamePasswordValidator validator) { }
        protected override System.Collections.ObjectModel.ReadOnlyCollection<System.IdentityModel.Policy.IAuthorizationPolicy> ValidateUserNamePasswordCore(string userName, string password) { throw null; }
    }
    public partial class KerberosSecurityTokenAuthenticator : System.IdentityModel.Selectors.WindowsSecurityTokenAuthenticator
    {
        public KerberosSecurityTokenAuthenticator() { }
        public KerberosSecurityTokenAuthenticator(bool includeWindowsGroups) { }
        protected override bool CanValidateTokenCore(System.IdentityModel.Tokens.SecurityToken token) { throw null; }
    }
    public partial class KerberosSecurityTokenProvider : System.IdentityModel.Selectors.SecurityTokenProvider
    {
        public KerberosSecurityTokenProvider(string servicePrincipalName) { }
        public KerberosSecurityTokenProvider(string servicePrincipalName, System.Security.Principal.TokenImpersonationLevel tokenImpersonationLevel) { }
        public KerberosSecurityTokenProvider(string servicePrincipalName, System.Security.Principal.TokenImpersonationLevel tokenImpersonationLevel, System.Net.NetworkCredential networkCredential) { }
        public System.Net.NetworkCredential NetworkCredential { get { throw null; } }
        public string ServicePrincipalName { get { throw null; } }
        public System.Security.Principal.TokenImpersonationLevel TokenImpersonationLevel { get { throw null; } }
        protected override System.IdentityModel.Tokens.SecurityToken GetTokenCore(System.TimeSpan timeout) { throw null; }
    }
    public partial class RsaSecurityTokenAuthenticator : System.IdentityModel.Selectors.SecurityTokenAuthenticator
    {
        public RsaSecurityTokenAuthenticator() { }
        protected override bool CanValidateTokenCore(System.IdentityModel.Tokens.SecurityToken token) { throw null; }
        protected override System.Collections.ObjectModel.ReadOnlyCollection<System.IdentityModel.Policy.IAuthorizationPolicy> ValidateTokenCore(System.IdentityModel.Tokens.SecurityToken token) { throw null; }
    }
    public partial class SamlSecurityTokenAuthenticator : System.IdentityModel.Selectors.SecurityTokenAuthenticator
    {
        public SamlSecurityTokenAuthenticator(System.Collections.Generic.IList<System.IdentityModel.Selectors.SecurityTokenAuthenticator> supportingAuthenticators) { }
        public SamlSecurityTokenAuthenticator(System.Collections.Generic.IList<System.IdentityModel.Selectors.SecurityTokenAuthenticator> supportingAuthenticators, System.TimeSpan maxClockSkew) { }
        public System.Collections.Generic.IList<string> AllowedAudienceUris { get { throw null; } }
        public System.IdentityModel.Selectors.AudienceUriMode AudienceUriMode { get { throw null; } set { } }
        protected override bool CanValidateTokenCore(System.IdentityModel.Tokens.SecurityToken token) { throw null; }
        public virtual System.IdentityModel.Claims.ClaimSet ResolveClaimSet(System.IdentityModel.Tokens.SecurityKeyIdentifier keyIdentifier) { throw null; }
        public virtual System.IdentityModel.Claims.ClaimSet ResolveClaimSet(System.IdentityModel.Tokens.SecurityToken token) { throw null; }
        public virtual System.Security.Principal.IIdentity ResolveIdentity(System.IdentityModel.Tokens.SecurityKeyIdentifier keyIdentifier) { throw null; }
        public virtual System.Security.Principal.IIdentity ResolveIdentity(System.IdentityModel.Tokens.SecurityToken token) { throw null; }
        protected virtual bool ValidateAudienceRestriction(System.IdentityModel.Tokens.SamlAudienceRestrictionCondition audienceRestrictionCondition) { throw null; }
        protected override System.Collections.ObjectModel.ReadOnlyCollection<System.IdentityModel.Policy.IAuthorizationPolicy> ValidateTokenCore(System.IdentityModel.Tokens.SecurityToken token) { throw null; }
    }
    public abstract partial class SecurityTokenAuthenticator
    {
        protected SecurityTokenAuthenticator() { }
        public bool CanValidateToken(System.IdentityModel.Tokens.SecurityToken token) { throw null; }
        protected abstract bool CanValidateTokenCore(System.IdentityModel.Tokens.SecurityToken token);
        public System.Collections.ObjectModel.ReadOnlyCollection<System.IdentityModel.Policy.IAuthorizationPolicy> ValidateToken(System.IdentityModel.Tokens.SecurityToken token) { throw null; }
        protected abstract System.Collections.ObjectModel.ReadOnlyCollection<System.IdentityModel.Policy.IAuthorizationPolicy> ValidateTokenCore(System.IdentityModel.Tokens.SecurityToken token);
    }
    public abstract partial class SecurityTokenManager
    {
        protected SecurityTokenManager() { }
        public abstract System.IdentityModel.Selectors.SecurityTokenAuthenticator CreateSecurityTokenAuthenticator(System.IdentityModel.Selectors.SecurityTokenRequirement tokenRequirement, out System.IdentityModel.Selectors.SecurityTokenResolver outOfBandTokenResolver);
        public abstract System.IdentityModel.Selectors.SecurityTokenProvider CreateSecurityTokenProvider(System.IdentityModel.Selectors.SecurityTokenRequirement tokenRequirement);
        public abstract System.IdentityModel.Selectors.SecurityTokenSerializer CreateSecurityTokenSerializer(System.IdentityModel.Selectors.SecurityTokenVersion version);
    }
    public abstract partial class SecurityTokenProvider
    {
        protected SecurityTokenProvider() { }
        public virtual bool SupportsTokenCancellation { get { throw null; } }
        public virtual bool SupportsTokenRenewal { get { throw null; } }
        public System.IAsyncResult BeginCancelToken(System.TimeSpan timeout, System.IdentityModel.Tokens.SecurityToken token, System.AsyncCallback callback, object state) { throw null; }
        protected virtual System.IAsyncResult BeginCancelTokenCore(System.TimeSpan timeout, System.IdentityModel.Tokens.SecurityToken token, System.AsyncCallback callback, object state) { throw null; }
        public System.IAsyncResult BeginGetToken(System.TimeSpan timeout, System.AsyncCallback callback, object state) { throw null; }
        protected virtual System.IAsyncResult BeginGetTokenCore(System.TimeSpan timeout, System.AsyncCallback callback, object state) { throw null; }
        public System.IAsyncResult BeginRenewToken(System.TimeSpan timeout, System.IdentityModel.Tokens.SecurityToken tokenToBeRenewed, System.AsyncCallback callback, object state) { throw null; }
        protected virtual System.IAsyncResult BeginRenewTokenCore(System.TimeSpan timeout, System.IdentityModel.Tokens.SecurityToken tokenToBeRenewed, System.AsyncCallback callback, object state) { throw null; }
        public void CancelToken(System.TimeSpan timeout, System.IdentityModel.Tokens.SecurityToken token) { }
        protected virtual void CancelTokenCore(System.TimeSpan timeout, System.IdentityModel.Tokens.SecurityToken token) { }
        public void EndCancelToken(System.IAsyncResult result) { }
        protected virtual void EndCancelTokenCore(System.IAsyncResult result) { }
        public System.IdentityModel.Tokens.SecurityToken EndGetToken(System.IAsyncResult result) { throw null; }
        protected virtual System.IdentityModel.Tokens.SecurityToken EndGetTokenCore(System.IAsyncResult result) { throw null; }
        public System.IdentityModel.Tokens.SecurityToken EndRenewToken(System.IAsyncResult result) { throw null; }
        protected virtual System.IdentityModel.Tokens.SecurityToken EndRenewTokenCore(System.IAsyncResult result) { throw null; }
        public System.IdentityModel.Tokens.SecurityToken GetToken(System.TimeSpan timeout) { throw null; }
        protected abstract System.IdentityModel.Tokens.SecurityToken GetTokenCore(System.TimeSpan timeout);
        public System.IdentityModel.Tokens.SecurityToken RenewToken(System.TimeSpan timeout, System.IdentityModel.Tokens.SecurityToken tokenToBeRenewed) { throw null; }
        protected virtual System.IdentityModel.Tokens.SecurityToken RenewTokenCore(System.TimeSpan timeout, System.IdentityModel.Tokens.SecurityToken tokenToBeRenewed) { throw null; }
        protected internal partial class SecurityTokenAsyncResult : System.IAsyncResult
        {
            public SecurityTokenAsyncResult(System.IdentityModel.Tokens.SecurityToken token, System.AsyncCallback callback, object state) { }
            public object AsyncState { get { throw null; } }
            public System.Threading.WaitHandle AsyncWaitHandle { get { throw null; } }
            public bool CompletedSynchronously { get { throw null; } }
            public bool IsCompleted { get { throw null; } }
            public static System.IdentityModel.Tokens.SecurityToken End(System.IAsyncResult result) { throw null; }
        }
    }
    public partial class SecurityTokenRequirement
    {
        public SecurityTokenRequirement() { }
        public static string IsOptionalTokenProperty { get { throw null; } }
        public int KeySize { get { throw null; } set { } }
        public static string KeySizeProperty { get { throw null; } }
        public System.IdentityModel.Tokens.SecurityKeyType KeyType { get { throw null; } set { } }
        public static string KeyTypeProperty { get { throw null; } }
        public System.IdentityModel.Tokens.SecurityKeyUsage KeyUsage { get { throw null; } set { } }
        public static string KeyUsageProperty { get { throw null; } }
        public static string PeerAuthenticationMode { get { throw null; } }
        public System.Collections.Generic.IDictionary<string, object> Properties { get { throw null; } }
        public bool RequireCryptographicToken { get { throw null; } set { } }
        public static string RequireCryptographicTokenProperty { get { throw null; } }
        public string TokenType { get { throw null; } set { } }
        public static string TokenTypeProperty { get { throw null; } }
        public TValue GetProperty<TValue>(string propertyName) { throw null; }
        public bool TryGetProperty<TValue>(string propertyName, out TValue result) { throw null; }
    }
    public abstract partial class SecurityTokenResolver : System.IdentityModel.Configuration.ICustomIdentityConfiguration
    {
        protected SecurityTokenResolver() { }
        public static System.IdentityModel.Selectors.SecurityTokenResolver CreateDefaultSecurityTokenResolver(System.Collections.ObjectModel.ReadOnlyCollection<System.IdentityModel.Tokens.SecurityToken> tokens, bool canMatchLocalId) { throw null; }
        public virtual void LoadCustomConfiguration(System.Xml.XmlNodeList nodelist) { }
        public System.IdentityModel.Tokens.SecurityKey ResolveSecurityKey(System.IdentityModel.Tokens.SecurityKeyIdentifierClause keyIdentifierClause) { throw null; }
        public System.IdentityModel.Tokens.SecurityToken ResolveToken(System.IdentityModel.Tokens.SecurityKeyIdentifier keyIdentifier) { throw null; }
        public System.IdentityModel.Tokens.SecurityToken ResolveToken(System.IdentityModel.Tokens.SecurityKeyIdentifierClause keyIdentifierClause) { throw null; }
        public bool TryResolveSecurityKey(System.IdentityModel.Tokens.SecurityKeyIdentifierClause keyIdentifierClause, out System.IdentityModel.Tokens.SecurityKey key) { throw null; }
        protected abstract bool TryResolveSecurityKeyCore(System.IdentityModel.Tokens.SecurityKeyIdentifierClause keyIdentifierClause, out System.IdentityModel.Tokens.SecurityKey key);
        public bool TryResolveToken(System.IdentityModel.Tokens.SecurityKeyIdentifier keyIdentifier, out System.IdentityModel.Tokens.SecurityToken token) { throw null; }
        public bool TryResolveToken(System.IdentityModel.Tokens.SecurityKeyIdentifierClause keyIdentifierClause, out System.IdentityModel.Tokens.SecurityToken token) { throw null; }
        protected abstract bool TryResolveTokenCore(System.IdentityModel.Tokens.SecurityKeyIdentifier keyIdentifier, out System.IdentityModel.Tokens.SecurityToken token);
        protected abstract bool TryResolveTokenCore(System.IdentityModel.Tokens.SecurityKeyIdentifierClause keyIdentifierClause, out System.IdentityModel.Tokens.SecurityToken token);
    }
    public abstract partial class SecurityTokenSerializer
    {
        protected SecurityTokenSerializer() { }
        public bool CanReadKeyIdentifier(System.Xml.XmlReader reader) { throw null; }
        public bool CanReadKeyIdentifierClause(System.Xml.XmlReader reader) { throw null; }
        protected abstract bool CanReadKeyIdentifierClauseCore(System.Xml.XmlReader reader);
        protected abstract bool CanReadKeyIdentifierCore(System.Xml.XmlReader reader);
        public bool CanReadToken(System.Xml.XmlReader reader) { throw null; }
        protected abstract bool CanReadTokenCore(System.Xml.XmlReader reader);
        public bool CanWriteKeyIdentifier(System.IdentityModel.Tokens.SecurityKeyIdentifier keyIdentifier) { throw null; }
        public bool CanWriteKeyIdentifierClause(System.IdentityModel.Tokens.SecurityKeyIdentifierClause keyIdentifierClause) { throw null; }
        protected abstract bool CanWriteKeyIdentifierClauseCore(System.IdentityModel.Tokens.SecurityKeyIdentifierClause keyIdentifierClause);
        protected abstract bool CanWriteKeyIdentifierCore(System.IdentityModel.Tokens.SecurityKeyIdentifier keyIdentifier);
        public bool CanWriteToken(System.IdentityModel.Tokens.SecurityToken token) { throw null; }
        protected abstract bool CanWriteTokenCore(System.IdentityModel.Tokens.SecurityToken token);
        public System.IdentityModel.Tokens.SecurityKeyIdentifier ReadKeyIdentifier(System.Xml.XmlReader reader) { throw null; }
        public System.IdentityModel.Tokens.SecurityKeyIdentifierClause ReadKeyIdentifierClause(System.Xml.XmlReader reader) { throw null; }
        protected abstract System.IdentityModel.Tokens.SecurityKeyIdentifierClause ReadKeyIdentifierClauseCore(System.Xml.XmlReader reader);
        protected abstract System.IdentityModel.Tokens.SecurityKeyIdentifier ReadKeyIdentifierCore(System.Xml.XmlReader reader);
        public System.IdentityModel.Tokens.SecurityToken ReadToken(System.Xml.XmlReader reader, System.IdentityModel.Selectors.SecurityTokenResolver tokenResolver) { throw null; }
        protected abstract System.IdentityModel.Tokens.SecurityToken ReadTokenCore(System.Xml.XmlReader reader, System.IdentityModel.Selectors.SecurityTokenResolver tokenResolver);
        public void WriteKeyIdentifier(System.Xml.XmlWriter writer, System.IdentityModel.Tokens.SecurityKeyIdentifier keyIdentifier) { }
        public void WriteKeyIdentifierClause(System.Xml.XmlWriter writer, System.IdentityModel.Tokens.SecurityKeyIdentifierClause keyIdentifierClause) { }
        protected abstract void WriteKeyIdentifierClauseCore(System.Xml.XmlWriter writer, System.IdentityModel.Tokens.SecurityKeyIdentifierClause keyIdentifierClause);
        protected abstract void WriteKeyIdentifierCore(System.Xml.XmlWriter writer, System.IdentityModel.Tokens.SecurityKeyIdentifier keyIdentifier);
        public void WriteToken(System.Xml.XmlWriter writer, System.IdentityModel.Tokens.SecurityToken token) { }
        protected abstract void WriteTokenCore(System.Xml.XmlWriter writer, System.IdentityModel.Tokens.SecurityToken token);
    }
    public abstract partial class SecurityTokenVersion
    {
        protected SecurityTokenVersion() { }
        public abstract System.Collections.ObjectModel.ReadOnlyCollection<string> GetSecuritySpecifications();
    }
    public abstract partial class UserNamePasswordValidator
    {
        protected UserNamePasswordValidator() { }
        public static System.IdentityModel.Selectors.UserNamePasswordValidator None { get { throw null; } }
        public static System.IdentityModel.Selectors.UserNamePasswordValidator CreateMembershipProviderValidator(System.Web.Security.MembershipProvider provider) { throw null; }
        public abstract void Validate(string userName, string password);
    }
    public abstract partial class UserNameSecurityTokenAuthenticator : System.IdentityModel.Selectors.SecurityTokenAuthenticator
    {
        protected UserNameSecurityTokenAuthenticator() { }
        protected override bool CanValidateTokenCore(System.IdentityModel.Tokens.SecurityToken token) { throw null; }
        protected override System.Collections.ObjectModel.ReadOnlyCollection<System.IdentityModel.Policy.IAuthorizationPolicy> ValidateTokenCore(System.IdentityModel.Tokens.SecurityToken token) { throw null; }
        protected abstract System.Collections.ObjectModel.ReadOnlyCollection<System.IdentityModel.Policy.IAuthorizationPolicy> ValidateUserNamePasswordCore(string userName, string password);
    }
    public partial class UserNameSecurityTokenProvider : System.IdentityModel.Selectors.SecurityTokenProvider
    {
        public UserNameSecurityTokenProvider(string userName, string password) { }
        protected override System.IdentityModel.Tokens.SecurityToken GetTokenCore(System.TimeSpan timeout) { throw null; }
    }
    public partial class WindowsSecurityTokenAuthenticator : System.IdentityModel.Selectors.SecurityTokenAuthenticator
    {
        public WindowsSecurityTokenAuthenticator() { }
        public WindowsSecurityTokenAuthenticator(bool includeWindowsGroups) { }
        protected override bool CanValidateTokenCore(System.IdentityModel.Tokens.SecurityToken token) { throw null; }
        protected override System.Collections.ObjectModel.ReadOnlyCollection<System.IdentityModel.Policy.IAuthorizationPolicy> ValidateTokenCore(System.IdentityModel.Tokens.SecurityToken token) { throw null; }
    }
    public partial class WindowsUserNameSecurityTokenAuthenticator : System.IdentityModel.Selectors.UserNameSecurityTokenAuthenticator
    {
        public WindowsUserNameSecurityTokenAuthenticator() { }
        public WindowsUserNameSecurityTokenAuthenticator(bool includeWindowsGroups) { }
        protected override System.Collections.ObjectModel.ReadOnlyCollection<System.IdentityModel.Policy.IAuthorizationPolicy> ValidateUserNamePasswordCore(string userName, string password) { throw null; }
    }
    public abstract partial class X509CertificateValidator : System.IdentityModel.Configuration.ICustomIdentityConfiguration
    {
        protected X509CertificateValidator() { }
        public static System.IdentityModel.Selectors.X509CertificateValidator ChainTrust { get { throw null; } }
        public static System.IdentityModel.Selectors.X509CertificateValidator None { get { throw null; } }
        public static System.IdentityModel.Selectors.X509CertificateValidator PeerOrChainTrust { get { throw null; } }
        public static System.IdentityModel.Selectors.X509CertificateValidator PeerTrust { get { throw null; } }
        public static System.IdentityModel.Selectors.X509CertificateValidator CreateChainTrustValidator(bool useMachineContext, System.Security.Cryptography.X509Certificates.X509ChainPolicy chainPolicy) { throw null; }
        public static System.IdentityModel.Selectors.X509CertificateValidator CreatePeerOrChainTrustValidator(bool useMachineContext, System.Security.Cryptography.X509Certificates.X509ChainPolicy chainPolicy) { throw null; }
        public virtual void LoadCustomConfiguration(System.Xml.XmlNodeList nodelist) { }
        public abstract void Validate(System.Security.Cryptography.X509Certificates.X509Certificate2 certificate);
    }
    public partial class X509SecurityTokenAuthenticator : System.IdentityModel.Selectors.SecurityTokenAuthenticator
    {
        public X509SecurityTokenAuthenticator() { }
        public X509SecurityTokenAuthenticator(System.IdentityModel.Selectors.X509CertificateValidator validator) { }
        public X509SecurityTokenAuthenticator(System.IdentityModel.Selectors.X509CertificateValidator validator, bool mapToWindows) { }
        public X509SecurityTokenAuthenticator(System.IdentityModel.Selectors.X509CertificateValidator validator, bool mapToWindows, bool includeWindowsGroups) { }
        public bool MapCertificateToWindowsAccount { get { throw null; } }
        protected override bool CanValidateTokenCore(System.IdentityModel.Tokens.SecurityToken token) { throw null; }
        protected override System.Collections.ObjectModel.ReadOnlyCollection<System.IdentityModel.Policy.IAuthorizationPolicy> ValidateTokenCore(System.IdentityModel.Tokens.SecurityToken token) { throw null; }
    }
    public partial class X509SecurityTokenProvider : System.IdentityModel.Selectors.SecurityTokenProvider, System.IDisposable
    {
        public X509SecurityTokenProvider(System.Security.Cryptography.X509Certificates.StoreLocation storeLocation, System.Security.Cryptography.X509Certificates.StoreName storeName, System.Security.Cryptography.X509Certificates.X509FindType findType, object findValue) { }
        public X509SecurityTokenProvider(System.Security.Cryptography.X509Certificates.X509Certificate2 certificate) { }
        public System.Security.Cryptography.X509Certificates.X509Certificate2 Certificate { get { throw null; } }
        public void Dispose() { }
        protected override System.IdentityModel.Tokens.SecurityToken GetTokenCore(System.TimeSpan timeout) { throw null; }
    }
}
namespace System.IdentityModel.Tokens
{
    public partial class AggregateTokenResolver : System.IdentityModel.Selectors.SecurityTokenResolver
    {
        public AggregateTokenResolver(System.Collections.Generic.IEnumerable<System.IdentityModel.Selectors.SecurityTokenResolver> tokenResolvers) { }
        public System.Collections.ObjectModel.ReadOnlyCollection<System.IdentityModel.Selectors.SecurityTokenResolver> TokenResolvers { get { throw null; } }
        protected override bool TryResolveSecurityKeyCore(System.IdentityModel.Tokens.SecurityKeyIdentifierClause keyIdentifierClause, out System.IdentityModel.Tokens.SecurityKey key) { throw null; }
        protected override bool TryResolveTokenCore(System.IdentityModel.Tokens.SecurityKeyIdentifier keyIdentifier, out System.IdentityModel.Tokens.SecurityToken token) { throw null; }
        protected override bool TryResolveTokenCore(System.IdentityModel.Tokens.SecurityKeyIdentifierClause keyIdentifierClause, out System.IdentityModel.Tokens.SecurityToken token) { throw null; }
    }
    public partial class AsymmetricProofDescriptor : System.IdentityModel.Tokens.ProofDescriptor
    {
        public AsymmetricProofDescriptor() { }
        public AsymmetricProofDescriptor(System.IdentityModel.Tokens.SecurityKeyIdentifier keyIdentifier) { }
        public AsymmetricProofDescriptor(System.Security.Cryptography.RSA rsaAlgorithm) { }
        public override System.IdentityModel.Tokens.SecurityKeyIdentifier KeyIdentifier { get { throw null; } }
        public override void ApplyTo(System.IdentityModel.Protocols.WSTrust.RequestSecurityTokenResponse response) { }
    }
    public abstract partial class AsymmetricSecurityKey : System.IdentityModel.Tokens.SecurityKey
    {
        protected AsymmetricSecurityKey() { }
        public abstract System.Security.Cryptography.AsymmetricAlgorithm GetAsymmetricAlgorithm(string algorithm, bool privateKey);
        public abstract System.Security.Cryptography.HashAlgorithm GetHashAlgorithmForSignature(string algorithm);
        public abstract System.Security.Cryptography.AsymmetricSignatureDeformatter GetSignatureDeformatter(string algorithm);
        public abstract System.Security.Cryptography.AsymmetricSignatureFormatter GetSignatureFormatter(string algorithm);
        public abstract bool HasPrivateKey();
    }
    public partial class AudienceRestriction
    {
        public AudienceRestriction() { }
        public AudienceRestriction(System.IdentityModel.Selectors.AudienceUriMode audienceMode) { }
        public System.Collections.ObjectModel.Collection<System.Uri> AllowedAudienceUris { get { throw null; } }
        public System.IdentityModel.Selectors.AudienceUriMode AudienceMode { get { throw null; } set { } }
    }
    [System.SerializableAttribute]
    public partial class AudienceUriValidationFailedException : System.IdentityModel.Tokens.SecurityTokenValidationException
    {
        public AudienceUriValidationFailedException() { }
        protected AudienceUriValidationFailedException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
        public AudienceUriValidationFailedException(string message) { }
        public AudienceUriValidationFailedException(string message, System.Exception inner) { }
    }
    public partial class AuthenticationContext
    {
        public AuthenticationContext() { }
        public System.Collections.ObjectModel.Collection<string> Authorities { get { throw null; } }
        public string ContextClass { get { throw null; } set { } }
        public string ContextDeclaration { get { throw null; } set { } }
    }
    public static partial class AuthenticationMethods
    {
        public const string HardwareToken = "http://schemas.microsoft.com/ws/2008/06/identity/authenticationmethod/hardwaretoken";
        public const string Kerberos = "http://schemas.microsoft.com/ws/2008/06/identity/authenticationmethod/kerberos";
        public const string Namespace = "http://schemas.microsoft.com/ws/2008/06/identity/authenticationmethod/";
        public const string Password = "http://schemas.microsoft.com/ws/2008/06/identity/authenticationmethod/password";
        public const string Pgp = "http://schemas.microsoft.com/ws/2008/06/identity/authenticationmethod/pgp";
        public const string SecureRemotePassword = "http://schemas.microsoft.com/ws/2008/06/identity/authenticationmethod/secureremotepassword";
        public const string Signature = "http://schemas.microsoft.com/ws/2008/06/identity/authenticationmethod/signature";
        public const string Smartcard = "http://schemas.microsoft.com/ws/2008/06/identity/authenticationmethod/smartcard";
        public const string SmartcardPki = "http://schemas.microsoft.com/ws/2008/06/identity/authenticationmethod/smartcardpki";
        public const string Spki = "http://schemas.microsoft.com/ws/2008/06/identity/authenticationmethod/spki";
        public const string TlsClient = "http://schemas.microsoft.com/ws/2008/06/identity/authenticationmethod/tlsclient";
        public const string Unspecified = "http://schemas.microsoft.com/ws/2008/06/identity/authenticationmethod/unspecified";
        public const string Windows = "http://schemas.microsoft.com/ws/2008/06/identity/authenticationmethod/windows";
        public const string X509 = "http://schemas.microsoft.com/ws/2008/06/identity/authenticationmethod/x509";
        public const string Xkms = "http://schemas.microsoft.com/ws/2008/06/identity/authenticationmethod/xkms";
    }
    public abstract partial class BinaryKeyIdentifierClause : System.IdentityModel.Tokens.SecurityKeyIdentifierClause
    {
        protected BinaryKeyIdentifierClause(string clauseType, byte[] identificationData, bool cloneBuffer) : base (default(string)) { }
        protected BinaryKeyIdentifierClause(string clauseType, byte[] identificationData, bool cloneBuffer, byte[] derivationNonce, int derivationLength) : base (default(string)) { }
        public byte[] GetBuffer() { throw null; }
        protected byte[] GetRawBuffer() { throw null; }
        public bool Matches(byte[] data) { throw null; }
        public bool Matches(byte[] data, int offset) { throw null; }
        public override bool Matches(System.IdentityModel.Tokens.SecurityKeyIdentifierClause keyIdentifierClause) { throw null; }
    }
    [System.SerializableAttribute]
    public partial class BootstrapContext : System.Runtime.Serialization.ISerializable
    {
        public BootstrapContext(byte[] token) { }
        public BootstrapContext(System.IdentityModel.Tokens.SecurityToken token, System.IdentityModel.Tokens.SecurityTokenHandler tokenHandler) { }
        protected BootstrapContext(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
        public BootstrapContext(string token) { }
        public System.IdentityModel.Tokens.SecurityToken SecurityToken { get { throw null; } }
        public System.IdentityModel.Tokens.SecurityTokenHandler SecurityTokenHandler { get { throw null; } }
        public string Token { get { throw null; } }
        public byte[] TokenBytes { get { throw null; } }
        public virtual void GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
    }
    public static partial class ComputedKeyAlgorithms
    {
        public const string Psha1 = "http://schemas.microsoft.com/idfx/computedkeyalgorithm/psha1";
    }
    public partial class ConfigurationBasedIssuerNameRegistry : System.IdentityModel.Tokens.IssuerNameRegistry
    {
        public ConfigurationBasedIssuerNameRegistry() { }
        public System.Collections.Generic.IDictionary<string, string> ConfiguredTrustedIssuers { get { throw null; } }
        public void AddTrustedIssuer(string certificateThumbprint, string name) { }
        public override string GetIssuerName(System.IdentityModel.Tokens.SecurityToken securityToken) { throw null; }
        public override void LoadCustomConfiguration(System.Xml.XmlNodeList customConfiguration) { }
    }
    public partial class EmptySecurityKeyIdentifierClause : System.IdentityModel.Tokens.SecurityKeyIdentifierClause
    {
        public EmptySecurityKeyIdentifierClause() : base (default(string)) { }
        public EmptySecurityKeyIdentifierClause(object context) : base (default(string)) { }
        public object Context { get { throw null; } }
    }
    public partial class EncryptedKeyEncryptingCredentials : System.IdentityModel.Tokens.EncryptingCredentials
    {
        public EncryptedKeyEncryptingCredentials(System.IdentityModel.Tokens.EncryptingCredentials wrappingCredentials, int keySizeInBits, string encryptionAlgorithm) { }
        public EncryptedKeyEncryptingCredentials(System.Security.Cryptography.X509Certificates.X509Certificate2 certificate) { }
        public EncryptedKeyEncryptingCredentials(System.Security.Cryptography.X509Certificates.X509Certificate2 certificate, string keyWrappingAlgorithm, int keySizeInBits, string encryptionAlgorithm) { }
        public System.IdentityModel.Tokens.EncryptingCredentials WrappingCredentials { get { throw null; } }
    }
    public sealed partial class EncryptedKeyIdentifierClause : System.IdentityModel.Tokens.BinaryKeyIdentifierClause
    {
        public EncryptedKeyIdentifierClause(byte[] encryptedKey, string encryptionMethod) : base (default(string), default(byte[]), default(bool)) { }
        public EncryptedKeyIdentifierClause(byte[] encryptedKey, string encryptionMethod, System.IdentityModel.Tokens.SecurityKeyIdentifier encryptingKeyIdentifier) : base (default(string), default(byte[]), default(bool)) { }
        public EncryptedKeyIdentifierClause(byte[] encryptedKey, string encryptionMethod, System.IdentityModel.Tokens.SecurityKeyIdentifier encryptingKeyIdentifier, string carriedKeyName) : base (default(string), default(byte[]), default(bool)) { }
        public EncryptedKeyIdentifierClause(byte[] encryptedKey, string encryptionMethod, System.IdentityModel.Tokens.SecurityKeyIdentifier encryptingKeyIdentifier, string carriedKeyName, byte[] derivationNonce, int derivationLength) : base (default(string), default(byte[]), default(bool)) { }
        public string CarriedKeyName { get { throw null; } }
        public System.IdentityModel.Tokens.SecurityKeyIdentifier EncryptingKeyIdentifier { get { throw null; } }
        public string EncryptionMethod { get { throw null; } }
        public byte[] GetEncryptedKey() { throw null; }
        public bool Matches(byte[] encryptedKey, string encryptionMethod, string carriedKeyName) { throw null; }
        public override bool Matches(System.IdentityModel.Tokens.SecurityKeyIdentifierClause keyIdentifierClause) { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class EncryptedSecurityToken : System.IdentityModel.Tokens.SecurityToken
    {
        public EncryptedSecurityToken(System.IdentityModel.Tokens.SecurityToken token, System.IdentityModel.Tokens.EncryptingCredentials encryptingCredentials) { }
        public System.IdentityModel.Tokens.EncryptingCredentials EncryptingCredentials { get { throw null; } }
        public override string Id { get { throw null; } }
        public override System.Collections.ObjectModel.ReadOnlyCollection<System.IdentityModel.Tokens.SecurityKey> SecurityKeys { get { throw null; } }
        public System.IdentityModel.Tokens.SecurityToken Token { get { throw null; } }
        public override System.DateTime ValidFrom { get { throw null; } }
        public override System.DateTime ValidTo { get { throw null; } }
        public override bool CanCreateKeyIdentifierClause<T>() { throw null; }
        public override T CreateKeyIdentifierClause<T>() { throw null; }
        public override bool MatchesKeyIdentifierClause(System.IdentityModel.Tokens.SecurityKeyIdentifierClause keyIdentifierClause) { throw null; }
        public override System.IdentityModel.Tokens.SecurityKey ResolveKeyIdentifierClause(System.IdentityModel.Tokens.SecurityKeyIdentifierClause keyIdentifierClause) { throw null; }
    }
    public partial class EncryptedSecurityTokenHandler : System.IdentityModel.Tokens.SecurityTokenHandler
    {
        public EncryptedSecurityTokenHandler() { }
        public override bool CanWriteToken { get { throw null; } }
        public System.IdentityModel.Selectors.SecurityTokenSerializer KeyInfoSerializer { get { throw null; } set { } }
        public override System.Type TokenType { get { throw null; } }
        public override bool CanReadKeyIdentifierClause(System.Xml.XmlReader reader) { throw null; }
        public override bool CanReadToken(System.Xml.XmlReader reader) { throw null; }
        public override string[] GetTokenTypeIdentifiers() { throw null; }
        public override System.IdentityModel.Tokens.SecurityKeyIdentifierClause ReadKeyIdentifierClause(System.Xml.XmlReader reader) { throw null; }
        public override System.IdentityModel.Tokens.SecurityToken ReadToken(System.Xml.XmlReader reader) { throw null; }
        public override void WriteToken(System.Xml.XmlWriter writer, System.IdentityModel.Tokens.SecurityToken token) { }
    }
    [System.SerializableAttribute]
    public partial class EncryptedTokenDecryptionFailedException : System.IdentityModel.Tokens.SecurityTokenException
    {
        public EncryptedTokenDecryptionFailedException() { }
        protected EncryptedTokenDecryptionFailedException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
        public EncryptedTokenDecryptionFailedException(string message) { }
        public EncryptedTokenDecryptionFailedException(string message, System.Exception inner) { }
    }
    public partial class EncryptingCredentials
    {
        public EncryptingCredentials() { }
        public EncryptingCredentials(System.IdentityModel.Tokens.SecurityKey key, System.IdentityModel.Tokens.SecurityKeyIdentifier keyIdentifier, string algorithm) { }
        public string Algorithm { get { throw null; } set { } }
        public System.IdentityModel.Tokens.SecurityKey SecurityKey { get { throw null; } set { } }
        public System.IdentityModel.Tokens.SecurityKeyIdentifier SecurityKeyIdentifier { get { throw null; } set { } }
    }
    public partial class GenericXmlSecurityKeyIdentifierClause : System.IdentityModel.Tokens.SecurityKeyIdentifierClause
    {
        public GenericXmlSecurityKeyIdentifierClause(System.Xml.XmlElement referenceXml) : base (default(string)) { }
        public GenericXmlSecurityKeyIdentifierClause(System.Xml.XmlElement referenceXml, byte[] derivationNonce, int derivationLength) : base (default(string)) { }
        public System.Xml.XmlElement ReferenceXml { get { throw null; } }
        public override bool Matches(System.IdentityModel.Tokens.SecurityKeyIdentifierClause keyIdentifierClause) { throw null; }
    }
    public partial class GenericXmlSecurityToken : System.IdentityModel.Tokens.SecurityToken
    {
        public GenericXmlSecurityToken(System.Xml.XmlElement tokenXml, System.IdentityModel.Tokens.SecurityToken proofToken, System.DateTime effectiveTime, System.DateTime expirationTime, System.IdentityModel.Tokens.SecurityKeyIdentifierClause internalTokenReference, System.IdentityModel.Tokens.SecurityKeyIdentifierClause externalTokenReference, System.Collections.ObjectModel.ReadOnlyCollection<System.IdentityModel.Policy.IAuthorizationPolicy> authorizationPolicies) { }
        public System.Collections.ObjectModel.ReadOnlyCollection<System.IdentityModel.Policy.IAuthorizationPolicy> AuthorizationPolicies { get { throw null; } }
        public System.IdentityModel.Tokens.SecurityKeyIdentifierClause ExternalTokenReference { get { throw null; } }
        public override string Id { get { throw null; } }
        public System.IdentityModel.Tokens.SecurityKeyIdentifierClause InternalTokenReference { get { throw null; } }
        public System.IdentityModel.Tokens.SecurityToken ProofToken { get { throw null; } }
        public override System.Collections.ObjectModel.ReadOnlyCollection<System.IdentityModel.Tokens.SecurityKey> SecurityKeys { get { throw null; } }
        public System.Xml.XmlElement TokenXml { get { throw null; } }
        public override System.DateTime ValidFrom { get { throw null; } }
        public override System.DateTime ValidTo { get { throw null; } }
        public override bool CanCreateKeyIdentifierClause<T>() { throw null; }
        public override T CreateKeyIdentifierClause<T>() { throw null; }
        public override bool MatchesKeyIdentifierClause(System.IdentityModel.Tokens.SecurityKeyIdentifierClause keyIdentifierClause) { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class InMemorySymmetricSecurityKey : System.IdentityModel.Tokens.SymmetricSecurityKey
    {
        public InMemorySymmetricSecurityKey(byte[] symmetricKey) { }
        public InMemorySymmetricSecurityKey(byte[] symmetricKey, bool cloneBuffer) { }
        public override int KeySize { get { throw null; } }
        public override byte[] DecryptKey(string algorithm, byte[] keyData) { throw null; }
        public override byte[] EncryptKey(string algorithm, byte[] keyData) { throw null; }
        public override byte[] GenerateDerivedKey(string algorithm, byte[] label, byte[] nonce, int derivedKeyLength, int offset) { throw null; }
        public override System.Security.Cryptography.ICryptoTransform GetDecryptionTransform(string algorithm, byte[] iv) { throw null; }
        public override System.Security.Cryptography.ICryptoTransform GetEncryptionTransform(string algorithm, byte[] iv) { throw null; }
        public override int GetIVSize(string algorithm) { throw null; }
        public override System.Security.Cryptography.KeyedHashAlgorithm GetKeyedHashAlgorithm(string algorithm) { throw null; }
        public override System.Security.Cryptography.SymmetricAlgorithm GetSymmetricAlgorithm(string algorithm) { throw null; }
        public override byte[] GetSymmetricKey() { throw null; }
        public override bool IsAsymmetricAlgorithm(string algorithm) { throw null; }
        public override bool IsSupportedAlgorithm(string algorithm) { throw null; }
        public override bool IsSymmetricAlgorithm(string algorithm) { throw null; }
    }
    public abstract partial class IssuerNameRegistry : System.IdentityModel.Configuration.ICustomIdentityConfiguration
    {
        protected IssuerNameRegistry() { }
        public abstract string GetIssuerName(System.IdentityModel.Tokens.SecurityToken securityToken);
        public virtual string GetIssuerName(System.IdentityModel.Tokens.SecurityToken securityToken, string requestedIssuerName) { throw null; }
        public virtual string GetWindowsIssuerName() { throw null; }
        public virtual void LoadCustomConfiguration(System.Xml.XmlNodeList nodelist) { }
    }
    public partial class IssuerTokenResolver : System.IdentityModel.Selectors.SecurityTokenResolver
    {
        public static readonly System.Security.Cryptography.X509Certificates.StoreLocation DefaultStoreLocation;
        public static readonly System.Security.Cryptography.X509Certificates.StoreName DefaultStoreName;
        public IssuerTokenResolver() { }
        public IssuerTokenResolver(System.IdentityModel.Selectors.SecurityTokenResolver wrappedTokenResolver) { }
        public System.IdentityModel.Selectors.SecurityTokenResolver WrappedTokenResolver { get { throw null; } }
        protected override bool TryResolveSecurityKeyCore(System.IdentityModel.Tokens.SecurityKeyIdentifierClause keyIdentifierClause, out System.IdentityModel.Tokens.SecurityKey key) { throw null; }
        protected override bool TryResolveTokenCore(System.IdentityModel.Tokens.SecurityKeyIdentifier keyIdentifier, out System.IdentityModel.Tokens.SecurityToken token) { throw null; }
        protected override bool TryResolveTokenCore(System.IdentityModel.Tokens.SecurityKeyIdentifierClause keyIdentifierClause, out System.IdentityModel.Tokens.SecurityToken token) { throw null; }
    }
    public partial class KerberosReceiverSecurityToken : System.IdentityModel.Tokens.WindowsSecurityToken
    {
        public KerberosReceiverSecurityToken(byte[] request) { }
        public KerberosReceiverSecurityToken(byte[] request, string id) { }
        public KerberosReceiverSecurityToken(byte[] request, string id, string valueTypeUri) { }
        public System.IdentityModel.Tokens.SymmetricSecurityKey SecurityKey { get { throw null; } }
        public override System.Collections.ObjectModel.ReadOnlyCollection<System.IdentityModel.Tokens.SecurityKey> SecurityKeys { get { throw null; } }
        public override System.DateTime ValidFrom { get { throw null; } }
        public override System.DateTime ValidTo { get { throw null; } }
        public string ValueTypeUri { get { throw null; } }
        public override System.Security.Principal.WindowsIdentity WindowsIdentity { get { throw null; } }
        public override bool CanCreateKeyIdentifierClause<T>() { throw null; }
        public override T CreateKeyIdentifierClause<T>() { throw null; }
        public byte[] GetRequest() { throw null; }
        public override bool MatchesKeyIdentifierClause(System.IdentityModel.Tokens.SecurityKeyIdentifierClause keyIdentifierClause) { throw null; }
    }
    public partial class KerberosRequestorSecurityToken : System.IdentityModel.Tokens.SecurityToken
    {
        public KerberosRequestorSecurityToken(string servicePrincipalName) { }
        public KerberosRequestorSecurityToken(string servicePrincipalName, System.Security.Principal.TokenImpersonationLevel tokenImpersonationLevel, System.Net.NetworkCredential networkCredential, string id) { }
        public override string Id { get { throw null; } }
        public System.IdentityModel.Tokens.SymmetricSecurityKey SecurityKey { get { throw null; } }
        public override System.Collections.ObjectModel.ReadOnlyCollection<System.IdentityModel.Tokens.SecurityKey> SecurityKeys { get { throw null; } }
        public string ServicePrincipalName { get { throw null; } }
        public override System.DateTime ValidFrom { get { throw null; } }
        public override System.DateTime ValidTo { get { throw null; } }
        public override bool CanCreateKeyIdentifierClause<T>() { throw null; }
        public override T CreateKeyIdentifierClause<T>() { throw null; }
        public byte[] GetRequest() { throw null; }
        public override bool MatchesKeyIdentifierClause(System.IdentityModel.Tokens.SecurityKeyIdentifierClause keyIdentifierClause) { throw null; }
    }
    public partial class KerberosSecurityTokenHandler : System.IdentityModel.Tokens.SecurityTokenHandler
    {
        public KerberosSecurityTokenHandler() { }
        public override bool CanValidateToken { get { throw null; } }
        public override System.Type TokenType { get { throw null; } }
        public override string[] GetTokenTypeIdentifiers() { throw null; }
        public override System.Collections.ObjectModel.ReadOnlyCollection<System.Security.Claims.ClaimsIdentity> ValidateToken(System.IdentityModel.Tokens.SecurityToken token) { throw null; }
    }
    public sealed partial class KerberosTicketHashKeyIdentifierClause : System.IdentityModel.Tokens.BinaryKeyIdentifierClause
    {
        public KerberosTicketHashKeyIdentifierClause(byte[] ticketHash) : base (default(string), default(byte[]), default(bool)) { }
        public KerberosTicketHashKeyIdentifierClause(byte[] ticketHash, byte[] derivationNonce, int derivationLength) : base (default(string), default(byte[]), default(bool)) { }
        public byte[] GetKerberosTicketHash() { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class LocalIdKeyIdentifierClause : System.IdentityModel.Tokens.SecurityKeyIdentifierClause
    {
        public LocalIdKeyIdentifierClause(string localId) : base (default(string)) { }
        public LocalIdKeyIdentifierClause(string localId, byte[] derivationNonce, int derivationLength, System.Type ownerType) : base (default(string)) { }
        public LocalIdKeyIdentifierClause(string localId, System.Type ownerType) : base (default(string)) { }
        public string LocalId { get { throw null; } }
        public System.Type OwnerType { get { throw null; } }
        public override bool Matches(System.IdentityModel.Tokens.SecurityKeyIdentifierClause keyIdentifierClause) { throw null; }
        public bool Matches(string localId, System.Type ownerType) { throw null; }
        public override string ToString() { throw null; }
    }
    public abstract partial class ProofDescriptor
    {
        protected ProofDescriptor() { }
        public abstract System.IdentityModel.Tokens.SecurityKeyIdentifier KeyIdentifier { get; }
        public abstract void ApplyTo(System.IdentityModel.Protocols.WSTrust.RequestSecurityTokenResponse response);
    }
    public partial class RsaKeyIdentifierClause : System.IdentityModel.Tokens.SecurityKeyIdentifierClause
    {
        public RsaKeyIdentifierClause(System.Security.Cryptography.RSA rsa) : base (default(string)) { }
        public override bool CanCreateKey { get { throw null; } }
        public System.Security.Cryptography.RSA Rsa { get { throw null; } }
        public override System.IdentityModel.Tokens.SecurityKey CreateKey() { throw null; }
        public byte[] GetExponent() { throw null; }
        public byte[] GetModulus() { throw null; }
        public override bool Matches(System.IdentityModel.Tokens.SecurityKeyIdentifierClause keyIdentifierClause) { throw null; }
        public bool Matches(System.Security.Cryptography.RSA rsa) { throw null; }
        public override string ToString() { throw null; }
        public void WriteExponentAsBase64(System.Xml.XmlWriter writer) { }
        public void WriteModulusAsBase64(System.Xml.XmlWriter writer) { }
    }
    public sealed partial class RsaSecurityKey : System.IdentityModel.Tokens.AsymmetricSecurityKey
    {
        public RsaSecurityKey(System.Security.Cryptography.RSA rsa) { }
        public override int KeySize { get { throw null; } }
        public override byte[] DecryptKey(string algorithm, byte[] keyData) { throw null; }
        public override byte[] EncryptKey(string algorithm, byte[] keyData) { throw null; }
        public override System.Security.Cryptography.AsymmetricAlgorithm GetAsymmetricAlgorithm(string algorithm, bool requiresPrivateKey) { throw null; }
        public override System.Security.Cryptography.HashAlgorithm GetHashAlgorithmForSignature(string algorithm) { throw null; }
        public override System.Security.Cryptography.AsymmetricSignatureDeformatter GetSignatureDeformatter(string algorithm) { throw null; }
        public override System.Security.Cryptography.AsymmetricSignatureFormatter GetSignatureFormatter(string algorithm) { throw null; }
        public override bool HasPrivateKey() { throw null; }
        public override bool IsAsymmetricAlgorithm(string algorithm) { throw null; }
        public override bool IsSupportedAlgorithm(string algorithm) { throw null; }
        public override bool IsSymmetricAlgorithm(string algorithm) { throw null; }
    }
    public partial class RsaSecurityToken : System.IdentityModel.Tokens.SecurityToken
    {
        public RsaSecurityToken(System.Security.Cryptography.RSA rsa) { }
        public RsaSecurityToken(System.Security.Cryptography.RSA rsa, string id) { }
        public override string Id { get { throw null; } }
        public System.Security.Cryptography.RSA Rsa { get { throw null; } }
        public override System.Collections.ObjectModel.ReadOnlyCollection<System.IdentityModel.Tokens.SecurityKey> SecurityKeys { get { throw null; } }
        public override System.DateTime ValidFrom { get { throw null; } }
        public override System.DateTime ValidTo { get { throw null; } }
        public override bool CanCreateKeyIdentifierClause<T>() { throw null; }
        public override T CreateKeyIdentifierClause<T>() { throw null; }
        ~RsaSecurityToken() { }
        public override bool MatchesKeyIdentifierClause(System.IdentityModel.Tokens.SecurityKeyIdentifierClause keyIdentifierClause) { throw null; }
    }
    public partial class RsaSecurityTokenHandler : System.IdentityModel.Tokens.SecurityTokenHandler
    {
        public RsaSecurityTokenHandler() { }
        public override bool CanValidateToken { get { throw null; } }
        public override bool CanWriteToken { get { throw null; } }
        public override System.Type TokenType { get { throw null; } }
        public override bool CanReadToken(System.Xml.XmlReader reader) { throw null; }
        public override string[] GetTokenTypeIdentifiers() { throw null; }
        public override System.IdentityModel.Tokens.SecurityToken ReadToken(System.Xml.XmlReader reader) { throw null; }
        public override System.Collections.ObjectModel.ReadOnlyCollection<System.Security.Claims.ClaimsIdentity> ValidateToken(System.IdentityModel.Tokens.SecurityToken token) { throw null; }
        public override void WriteToken(System.Xml.XmlWriter writer, System.IdentityModel.Tokens.SecurityToken token) { }
    }
    public partial class Saml2Action
    {
        public Saml2Action(string value, System.Uri actionNamespace) { }
        public System.Uri Namespace { get { throw null; } set { } }
        public string Value { get { throw null; } set { } }
    }
    public partial class Saml2Advice
    {
        public Saml2Advice() { }
        public System.Collections.ObjectModel.Collection<System.IdentityModel.Tokens.Saml2Id> AssertionIdReferences { get { throw null; } }
        public System.Collections.ObjectModel.Collection<System.IdentityModel.Tokens.Saml2Assertion> Assertions { get { throw null; } }
        public System.Collections.ObjectModel.Collection<System.Uri> AssertionUriReferences { get { throw null; } }
    }
    public partial class Saml2Assertion
    {
        public Saml2Assertion(System.IdentityModel.Tokens.Saml2NameIdentifier issuer) { }
        public System.IdentityModel.Tokens.Saml2Advice Advice { get { throw null; } set { } }
        public virtual bool CanWriteSourceData { get { throw null; } }
        public System.IdentityModel.Tokens.Saml2Conditions Conditions { get { throw null; } set { } }
        public System.IdentityModel.Tokens.EncryptingCredentials EncryptingCredentials { get { throw null; } set { } }
        public System.Collections.ObjectModel.Collection<System.IdentityModel.Tokens.EncryptedKeyIdentifierClause> ExternalEncryptedKeys { get { throw null; } }
        public System.IdentityModel.Tokens.Saml2Id Id { get { throw null; } set { } }
        public System.DateTime IssueInstant { get { throw null; } set { } }
        public System.IdentityModel.Tokens.Saml2NameIdentifier Issuer { get { throw null; } set { } }
        public System.IdentityModel.Tokens.SigningCredentials SigningCredentials { get { throw null; } set { } }
        public System.Collections.ObjectModel.Collection<System.IdentityModel.Tokens.Saml2Statement> Statements { get { throw null; } }
        public System.IdentityModel.Tokens.Saml2Subject Subject { get { throw null; } set { } }
        public string Version { get { throw null; } }
        public virtual void WriteSourceData(System.Xml.XmlWriter writer) { }
    }
    public partial class Saml2AssertionKeyIdentifierClause : System.IdentityModel.Tokens.SecurityKeyIdentifierClause
    {
        public Saml2AssertionKeyIdentifierClause(string id) : base (default(string)) { }
        public Saml2AssertionKeyIdentifierClause(string id, byte[] derivationNonce, int derivationLength) : base (default(string)) { }
        public override bool Matches(System.IdentityModel.Tokens.SecurityKeyIdentifierClause keyIdentifierClause) { throw null; }
        public static bool Matches(string assertionId, System.IdentityModel.Tokens.SecurityKeyIdentifierClause keyIdentifierClause) { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class Saml2Attribute
    {
        public Saml2Attribute(string name) { }
        public Saml2Attribute(string name, System.Collections.Generic.IEnumerable<string> values) { }
        public Saml2Attribute(string name, string value) { }
        public string AttributeValueXsiType { get { throw null; } set { } }
        public string FriendlyName { get { throw null; } set { } }
        public string Name { get { throw null; } set { } }
        public System.Uri NameFormat { get { throw null; } set { } }
        public string OriginalIssuer { get { throw null; } set { } }
        public System.Collections.ObjectModel.Collection<string> Values { get { throw null; } }
    }
    public partial class Saml2AttributeStatement : System.IdentityModel.Tokens.Saml2Statement
    {
        public Saml2AttributeStatement() { }
        public Saml2AttributeStatement(System.Collections.Generic.IEnumerable<System.IdentityModel.Tokens.Saml2Attribute> attributes) { }
        public Saml2AttributeStatement(System.IdentityModel.Tokens.Saml2Attribute attribute) { }
        public System.Collections.ObjectModel.Collection<System.IdentityModel.Tokens.Saml2Attribute> Attributes { get { throw null; } }
    }
    public partial class Saml2AudienceRestriction
    {
        public Saml2AudienceRestriction() { }
        public Saml2AudienceRestriction(System.Collections.Generic.IEnumerable<System.Uri> audiences) { }
        public Saml2AudienceRestriction(System.Uri audience) { }
        public System.Collections.ObjectModel.Collection<System.Uri> Audiences { get { throw null; } }
    }
    public partial class Saml2AuthenticationContext
    {
        public Saml2AuthenticationContext() { }
        public Saml2AuthenticationContext(System.Uri classReference) { }
        public Saml2AuthenticationContext(System.Uri classReference, System.Uri declarationReference) { }
        public System.Collections.ObjectModel.Collection<System.Uri> AuthenticatingAuthorities { get { throw null; } }
        public System.Uri ClassReference { get { throw null; } set { } }
        public System.Uri DeclarationReference { get { throw null; } set { } }
    }
    public partial class Saml2AuthenticationStatement : System.IdentityModel.Tokens.Saml2Statement
    {
        public Saml2AuthenticationStatement(System.IdentityModel.Tokens.Saml2AuthenticationContext authenticationContext) { }
        public Saml2AuthenticationStatement(System.IdentityModel.Tokens.Saml2AuthenticationContext authenticationContext, System.DateTime authenticationInstant) { }
        public System.IdentityModel.Tokens.Saml2AuthenticationContext AuthenticationContext { get { throw null; } set { } }
        public System.DateTime AuthenticationInstant { get { throw null; } set { } }
        public string SessionIndex { get { throw null; } set { } }
        public System.Nullable<System.DateTime> SessionNotOnOrAfter { get { throw null; } set { } }
        public System.IdentityModel.Tokens.Saml2SubjectLocality SubjectLocality { get { throw null; } set { } }
    }
    public partial class Saml2AuthorizationDecisionStatement : System.IdentityModel.Tokens.Saml2Statement
    {
        public static readonly System.Uri EmptyResource;
        public Saml2AuthorizationDecisionStatement(System.Uri resource, System.IdentityModel.Tokens.SamlAccessDecision decision) { }
        public Saml2AuthorizationDecisionStatement(System.Uri resource, System.IdentityModel.Tokens.SamlAccessDecision decision, System.Collections.Generic.IEnumerable<System.IdentityModel.Tokens.Saml2Action> actions) { }
        public System.Collections.ObjectModel.Collection<System.IdentityModel.Tokens.Saml2Action> Actions { get { throw null; } }
        public System.IdentityModel.Tokens.SamlAccessDecision Decision { get { throw null; } set { } }
        public System.IdentityModel.Tokens.Saml2Evidence Evidence { get { throw null; } set { } }
        public System.Uri Resource { get { throw null; } set { } }
    }
    public partial class Saml2Conditions
    {
        public Saml2Conditions() { }
        public System.Collections.ObjectModel.Collection<System.IdentityModel.Tokens.Saml2AudienceRestriction> AudienceRestrictions { get { throw null; } }
        public System.Nullable<System.DateTime> NotBefore { get { throw null; } set { } }
        public System.Nullable<System.DateTime> NotOnOrAfter { get { throw null; } set { } }
        public bool OneTimeUse { get { throw null; } set { } }
        public System.IdentityModel.Tokens.Saml2ProxyRestriction ProxyRestriction { get { throw null; } set { } }
    }
    public partial class Saml2Evidence
    {
        public Saml2Evidence() { }
        public Saml2Evidence(System.IdentityModel.Tokens.Saml2Assertion assertion) { }
        public Saml2Evidence(System.IdentityModel.Tokens.Saml2Id idReference) { }
        public Saml2Evidence(System.Uri uriReference) { }
        public System.Collections.ObjectModel.Collection<System.IdentityModel.Tokens.Saml2Id> AssertionIdReferences { get { throw null; } }
        public System.Collections.ObjectModel.Collection<System.IdentityModel.Tokens.Saml2Assertion> Assertions { get { throw null; } }
        public System.Collections.ObjectModel.Collection<System.Uri> AssertionUriReferences { get { throw null; } }
    }
    public partial class Saml2Id
    {
        public Saml2Id() { }
        public Saml2Id(string value) { }
        public string Value { get { throw null; } }
        public override bool Equals(object obj) { throw null; }
        public override int GetHashCode() { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class Saml2NameIdentifier
    {
        public Saml2NameIdentifier(string name) { }
        public Saml2NameIdentifier(string name, System.Uri format) { }
        public System.IdentityModel.Tokens.EncryptingCredentials EncryptingCredentials { get { throw null; } set { } }
        public System.Collections.ObjectModel.Collection<System.IdentityModel.Tokens.EncryptedKeyIdentifierClause> ExternalEncryptedKeys { get { throw null; } }
        public System.Uri Format { get { throw null; } set { } }
        public string NameQualifier { get { throw null; } set { } }
        public string SPNameQualifier { get { throw null; } set { } }
        public string SPProvidedId { get { throw null; } set { } }
        public string Value { get { throw null; } set { } }
    }
    public partial class Saml2ProxyRestriction
    {
        public Saml2ProxyRestriction() { }
        public System.Collections.ObjectModel.Collection<System.Uri> Audiences { get { throw null; } }
        public System.Nullable<int> Count { get { throw null; } set { } }
    }
    public partial class Saml2SecurityKeyIdentifierClause : System.IdentityModel.Tokens.SecurityKeyIdentifierClause
    {
        public Saml2SecurityKeyIdentifierClause(System.IdentityModel.Tokens.Saml2Assertion assertion) : base (default(string)) { }
        public System.IdentityModel.Tokens.Saml2Assertion Assertion { get { throw null; } }
    }
    public partial class Saml2SecurityToken : System.IdentityModel.Tokens.SecurityToken
    {
        public Saml2SecurityToken(System.IdentityModel.Tokens.Saml2Assertion assertion) { }
        public Saml2SecurityToken(System.IdentityModel.Tokens.Saml2Assertion assertion, System.Collections.ObjectModel.ReadOnlyCollection<System.IdentityModel.Tokens.SecurityKey> keys, System.IdentityModel.Tokens.SecurityToken issuerToken) { }
        public System.IdentityModel.Tokens.Saml2Assertion Assertion { get { throw null; } }
        public override string Id { get { throw null; } }
        public System.IdentityModel.Tokens.SecurityToken IssuerToken { get { throw null; } }
        public override System.Collections.ObjectModel.ReadOnlyCollection<System.IdentityModel.Tokens.SecurityKey> SecurityKeys { get { throw null; } }
        public override System.DateTime ValidFrom { get { throw null; } }
        public override System.DateTime ValidTo { get { throw null; } }
        public override bool CanCreateKeyIdentifierClause<T>() { throw null; }
        public override T CreateKeyIdentifierClause<T>() { throw null; }
        public override bool MatchesKeyIdentifierClause(System.IdentityModel.Tokens.SecurityKeyIdentifierClause keyIdentifierClause) { throw null; }
    }
    public partial class Saml2SecurityTokenHandler : System.IdentityModel.Tokens.SecurityTokenHandler
    {
        public const string TokenProfile11ValueType = "http://docs.oasis-open.org/wss/oasis-wss-saml-token-profile-1.1#SAMLID";
        public Saml2SecurityTokenHandler() { }
        public Saml2SecurityTokenHandler(System.IdentityModel.Tokens.SamlSecurityTokenRequirement samlSecurityTokenRequirement) { }
        public override bool CanValidateToken { get { throw null; } }
        public override bool CanWriteToken { get { throw null; } }
        public System.IdentityModel.Selectors.X509CertificateValidator CertificateValidator { get { throw null; } set { } }
        public System.IdentityModel.Selectors.SecurityTokenSerializer KeyInfoSerializer { get { throw null; } set { } }
        public System.IdentityModel.Tokens.SamlSecurityTokenRequirement SamlSecurityTokenRequirement { get { throw null; } set { } }
        public override System.Type TokenType { get { throw null; } }
        protected virtual void AddDelegateToAttributes(System.Security.Claims.ClaimsIdentity subject, System.Collections.Generic.ICollection<System.IdentityModel.Tokens.Saml2Attribute> attributes, System.IdentityModel.Tokens.SecurityTokenDescriptor tokenDescriptor) { }
        public override bool CanReadKeyIdentifierClause(System.Xml.XmlReader reader) { throw null; }
        public override bool CanReadToken(System.Xml.XmlReader reader) { throw null; }
        public override bool CanWriteKeyIdentifierClause(System.IdentityModel.Tokens.SecurityKeyIdentifierClause securityKeyIdentifierClause) { throw null; }
        protected virtual System.Collections.Generic.ICollection<System.IdentityModel.Tokens.Saml2Attribute> CollectAttributeValues(System.Collections.Generic.ICollection<System.IdentityModel.Tokens.Saml2Attribute> attributes) { throw null; }
        protected virtual System.IdentityModel.Tokens.Saml2Advice CreateAdvice(System.IdentityModel.Tokens.SecurityTokenDescriptor tokenDescriptor) { throw null; }
        protected virtual System.IdentityModel.Tokens.Saml2Attribute CreateAttribute(System.Security.Claims.Claim claim, System.IdentityModel.Tokens.SecurityTokenDescriptor tokenDescriptor) { throw null; }
        protected virtual System.IdentityModel.Tokens.Saml2AttributeStatement CreateAttributeStatement(System.Security.Claims.ClaimsIdentity subject, System.IdentityModel.Tokens.SecurityTokenDescriptor tokenDescriptor) { throw null; }
        protected virtual System.IdentityModel.Tokens.Saml2AuthenticationStatement CreateAuthenticationStatement(System.Security.Claims.AuthenticationInformation authInfo, System.IdentityModel.Tokens.SecurityTokenDescriptor tokenDescriptor) { throw null; }
        protected virtual System.Security.Claims.ClaimsIdentity CreateClaims(System.IdentityModel.Tokens.Saml2SecurityToken samlToken) { throw null; }
        protected virtual System.IdentityModel.Tokens.Saml2Conditions CreateConditions(System.IdentityModel.Protocols.WSTrust.Lifetime tokenLifetime, string relyingPartyAddress, System.IdentityModel.Tokens.SecurityTokenDescriptor tokenDescriptor) { throw null; }
        protected virtual System.IdentityModel.Tokens.Saml2NameIdentifier CreateIssuerNameIdentifier(System.IdentityModel.Tokens.SecurityTokenDescriptor tokenDescriptor) { throw null; }
        protected virtual System.IdentityModel.Tokens.Saml2Subject CreateSamlSubject(System.IdentityModel.Tokens.SecurityTokenDescriptor tokenDescriptor) { throw null; }
        public override System.IdentityModel.Tokens.SecurityKeyIdentifierClause CreateSecurityTokenReference(System.IdentityModel.Tokens.SecurityToken token, bool attached) { throw null; }
        protected virtual System.Collections.Generic.IEnumerable<System.IdentityModel.Tokens.Saml2Statement> CreateStatements(System.IdentityModel.Tokens.SecurityTokenDescriptor tokenDescriptor) { throw null; }
        public override System.IdentityModel.Tokens.SecurityToken CreateToken(System.IdentityModel.Tokens.SecurityTokenDescriptor tokenDescriptor) { throw null; }
        protected virtual System.Security.Principal.WindowsIdentity CreateWindowsIdentity(string upn) { throw null; }
        protected virtual string CreateXmlStringFromAttributes(System.Collections.Generic.IEnumerable<System.IdentityModel.Tokens.Saml2Attribute> attributes) { throw null; }
        protected virtual string DenormalizeAuthenticationType(string normalizedAuthenticationType) { throw null; }
        protected override void DetectReplayedToken(System.IdentityModel.Tokens.SecurityToken token) { }
        protected virtual string FindUpn(System.Security.Claims.ClaimsIdentity claimsIdentity) { throw null; }
        protected virtual System.IdentityModel.Tokens.EncryptingCredentials GetEncryptingCredentials(System.IdentityModel.Tokens.SecurityTokenDescriptor tokenDescriptor) { throw null; }
        protected virtual System.IdentityModel.Tokens.SigningCredentials GetSigningCredentials(System.IdentityModel.Tokens.SecurityTokenDescriptor tokenDescriptor) { throw null; }
        protected virtual System.DateTime GetTokenReplayCacheEntryExpirationTime(System.IdentityModel.Tokens.Saml2SecurityToken token) { throw null; }
        public override string[] GetTokenTypeIdentifiers() { throw null; }
        public override void LoadCustomConfiguration(System.Xml.XmlNodeList customConfigElements) { }
        protected virtual string NormalizeAuthenticationContextClassReference(string saml2AuthenticationContextClassReference) { throw null; }
        protected virtual void ProcessAttributeStatement(System.IdentityModel.Tokens.Saml2AttributeStatement statement, System.Security.Claims.ClaimsIdentity subject, string issuer) { }
        protected virtual void ProcessAuthenticationStatement(System.IdentityModel.Tokens.Saml2AuthenticationStatement statement, System.Security.Claims.ClaimsIdentity subject, string issuer) { }
        protected virtual void ProcessAuthorizationDecisionStatement(System.IdentityModel.Tokens.Saml2AuthorizationDecisionStatement statement, System.Security.Claims.ClaimsIdentity subject, string issuer) { }
        protected virtual void ProcessSamlSubject(System.IdentityModel.Tokens.Saml2Subject assertionSubject, System.Security.Claims.ClaimsIdentity subject, string issuer) { }
        protected virtual void ProcessStatement(System.Collections.ObjectModel.Collection<System.IdentityModel.Tokens.Saml2Statement> statements, System.Security.Claims.ClaimsIdentity subject, string issuer) { }
        protected virtual System.IdentityModel.Tokens.Saml2Action ReadAction(System.Xml.XmlReader reader) { throw null; }
        protected virtual System.IdentityModel.Tokens.Saml2Advice ReadAdvice(System.Xml.XmlReader reader) { throw null; }
        protected virtual System.IdentityModel.Tokens.Saml2Assertion ReadAssertion(System.Xml.XmlReader reader) { throw null; }
        protected virtual System.IdentityModel.Tokens.Saml2Attribute ReadAttribute(System.Xml.XmlReader reader) { throw null; }
        protected virtual System.IdentityModel.Tokens.Saml2AttributeStatement ReadAttributeStatement(System.Xml.XmlReader reader) { throw null; }
        protected virtual string ReadAttributeValue(System.Xml.XmlReader reader, System.IdentityModel.Tokens.Saml2Attribute attribute) { throw null; }
        protected virtual System.IdentityModel.Tokens.Saml2AudienceRestriction ReadAudienceRestriction(System.Xml.XmlReader reader) { throw null; }
        protected virtual System.IdentityModel.Tokens.Saml2AuthenticationContext ReadAuthenticationContext(System.Xml.XmlReader reader) { throw null; }
        protected virtual System.IdentityModel.Tokens.Saml2AuthenticationStatement ReadAuthenticationStatement(System.Xml.XmlReader reader) { throw null; }
        protected virtual System.IdentityModel.Tokens.Saml2AuthorizationDecisionStatement ReadAuthorizationDecisionStatement(System.Xml.XmlReader reader) { throw null; }
        protected virtual System.IdentityModel.Tokens.Saml2Conditions ReadConditions(System.Xml.XmlReader reader) { throw null; }
        protected virtual System.IdentityModel.Tokens.Saml2NameIdentifier ReadEncryptedId(System.Xml.XmlReader reader) { throw null; }
        protected virtual System.IdentityModel.Tokens.Saml2Evidence ReadEvidence(System.Xml.XmlReader reader) { throw null; }
        protected virtual System.IdentityModel.Tokens.Saml2NameIdentifier ReadIssuer(System.Xml.XmlReader reader) { throw null; }
        public override System.IdentityModel.Tokens.SecurityKeyIdentifierClause ReadKeyIdentifierClause(System.Xml.XmlReader reader) { throw null; }
        protected virtual System.IdentityModel.Tokens.Saml2NameIdentifier ReadNameId(System.Xml.XmlReader reader) { throw null; }
        protected virtual System.IdentityModel.Tokens.Saml2NameIdentifier ReadNameIdType(System.Xml.XmlReader reader) { throw null; }
        protected virtual System.IdentityModel.Tokens.Saml2ProxyRestriction ReadProxyRestriction(System.Xml.XmlReader reader) { throw null; }
        protected virtual System.IdentityModel.Tokens.SecurityKeyIdentifier ReadSigningKeyInfo(System.Xml.XmlReader reader, System.IdentityModel.Tokens.Saml2Assertion assertion) { throw null; }
        protected virtual System.IdentityModel.Tokens.Saml2Statement ReadStatement(System.Xml.XmlReader reader) { throw null; }
        protected virtual System.IdentityModel.Tokens.Saml2Subject ReadSubject(System.Xml.XmlReader reader) { throw null; }
        protected virtual System.IdentityModel.Tokens.Saml2SubjectConfirmation ReadSubjectConfirmation(System.Xml.XmlReader reader) { throw null; }
        protected virtual System.IdentityModel.Tokens.Saml2SubjectConfirmationData ReadSubjectConfirmationData(System.Xml.XmlReader reader) { throw null; }
        protected virtual System.IdentityModel.Tokens.Saml2NameIdentifier ReadSubjectId(System.Xml.XmlReader reader, string parentElement) { throw null; }
        protected virtual System.IdentityModel.Tokens.SecurityKeyIdentifier ReadSubjectKeyInfo(System.Xml.XmlReader reader) { throw null; }
        protected virtual System.IdentityModel.Tokens.Saml2SubjectLocality ReadSubjectLocality(System.Xml.XmlReader reader) { throw null; }
        public override System.IdentityModel.Tokens.SecurityToken ReadToken(System.Xml.XmlReader reader) { throw null; }
        protected virtual System.IdentityModel.Tokens.SecurityToken ResolveIssuerToken(System.IdentityModel.Tokens.Saml2Assertion assertion, System.IdentityModel.Selectors.SecurityTokenResolver issuerResolver) { throw null; }
        protected virtual System.Collections.ObjectModel.ReadOnlyCollection<System.IdentityModel.Tokens.SecurityKey> ResolveSecurityKeys(System.IdentityModel.Tokens.Saml2Assertion assertion, System.IdentityModel.Selectors.SecurityTokenResolver resolver) { throw null; }
        protected virtual void SetDelegateFromAttribute(System.IdentityModel.Tokens.Saml2Attribute attribute, System.Security.Claims.ClaimsIdentity subject, string issuer) { }
        protected virtual bool TryResolveIssuerToken(System.IdentityModel.Tokens.Saml2Assertion assertion, System.IdentityModel.Selectors.SecurityTokenResolver issuerResolver, out System.IdentityModel.Tokens.SecurityToken token) { throw null; }
        protected virtual void ValidateConditions(System.IdentityModel.Tokens.Saml2Conditions conditions, bool enforceAudienceRestriction) { }
        protected virtual void ValidateConfirmationData(System.IdentityModel.Tokens.Saml2SubjectConfirmationData confirmationData) { }
        public override System.Collections.ObjectModel.ReadOnlyCollection<System.Security.Claims.ClaimsIdentity> ValidateToken(System.IdentityModel.Tokens.SecurityToken token) { throw null; }
        protected virtual void WriteAction(System.Xml.XmlWriter writer, System.IdentityModel.Tokens.Saml2Action data) { }
        protected virtual void WriteAdvice(System.Xml.XmlWriter writer, System.IdentityModel.Tokens.Saml2Advice data) { }
        protected virtual void WriteAssertion(System.Xml.XmlWriter writer, System.IdentityModel.Tokens.Saml2Assertion data) { }
        protected virtual void WriteAttribute(System.Xml.XmlWriter writer, System.IdentityModel.Tokens.Saml2Attribute data) { }
        protected virtual void WriteAttributeStatement(System.Xml.XmlWriter writer, System.IdentityModel.Tokens.Saml2AttributeStatement data) { }
        protected virtual void WriteAttributeValue(System.Xml.XmlWriter writer, string value, System.IdentityModel.Tokens.Saml2Attribute attribute) { }
        protected virtual void WriteAudienceRestriction(System.Xml.XmlWriter writer, System.IdentityModel.Tokens.Saml2AudienceRestriction data) { }
        protected virtual void WriteAuthenticationContext(System.Xml.XmlWriter writer, System.IdentityModel.Tokens.Saml2AuthenticationContext data) { }
        protected virtual void WriteAuthenticationStatement(System.Xml.XmlWriter writer, System.IdentityModel.Tokens.Saml2AuthenticationStatement data) { }
        protected virtual void WriteAuthorizationDecisionStatement(System.Xml.XmlWriter writer, System.IdentityModel.Tokens.Saml2AuthorizationDecisionStatement data) { }
        protected virtual void WriteConditions(System.Xml.XmlWriter writer, System.IdentityModel.Tokens.Saml2Conditions data) { }
        protected virtual void WriteEvidence(System.Xml.XmlWriter writer, System.IdentityModel.Tokens.Saml2Evidence data) { }
        protected virtual void WriteIssuer(System.Xml.XmlWriter writer, System.IdentityModel.Tokens.Saml2NameIdentifier data) { }
        public override void WriteKeyIdentifierClause(System.Xml.XmlWriter writer, System.IdentityModel.Tokens.SecurityKeyIdentifierClause securityKeyIdentifierClause) { }
        protected virtual void WriteNameId(System.Xml.XmlWriter writer, System.IdentityModel.Tokens.Saml2NameIdentifier data) { }
        protected virtual void WriteNameIdType(System.Xml.XmlWriter writer, System.IdentityModel.Tokens.Saml2NameIdentifier data) { }
        protected virtual void WriteProxyRestriction(System.Xml.XmlWriter writer, System.IdentityModel.Tokens.Saml2ProxyRestriction data) { }
        protected virtual void WriteSigningKeyInfo(System.Xml.XmlWriter writer, System.IdentityModel.Tokens.SecurityKeyIdentifier data) { }
        protected virtual void WriteStatement(System.Xml.XmlWriter writer, System.IdentityModel.Tokens.Saml2Statement data) { }
        protected virtual void WriteSubject(System.Xml.XmlWriter writer, System.IdentityModel.Tokens.Saml2Subject data) { }
        protected virtual void WriteSubjectConfirmation(System.Xml.XmlWriter writer, System.IdentityModel.Tokens.Saml2SubjectConfirmation data) { }
        protected virtual void WriteSubjectConfirmationData(System.Xml.XmlWriter writer, System.IdentityModel.Tokens.Saml2SubjectConfirmationData data) { }
        protected virtual void WriteSubjectKeyInfo(System.Xml.XmlWriter writer, System.IdentityModel.Tokens.SecurityKeyIdentifier data) { }
        protected virtual void WriteSubjectLocality(System.Xml.XmlWriter writer, System.IdentityModel.Tokens.Saml2SubjectLocality data) { }
        public override void WriteToken(System.Xml.XmlWriter writer, System.IdentityModel.Tokens.SecurityToken token) { }
    }
    public abstract partial class Saml2Statement
    {
        protected Saml2Statement() { }
    }
    public partial class Saml2Subject
    {
        public Saml2Subject() { }
        public Saml2Subject(System.IdentityModel.Tokens.Saml2NameIdentifier nameId) { }
        public Saml2Subject(System.IdentityModel.Tokens.Saml2SubjectConfirmation subjectConfirmation) { }
        public System.IdentityModel.Tokens.Saml2NameIdentifier NameId { get { throw null; } set { } }
        public System.Collections.ObjectModel.Collection<System.IdentityModel.Tokens.Saml2SubjectConfirmation> SubjectConfirmations { get { throw null; } }
    }
    public partial class Saml2SubjectConfirmation
    {
        public Saml2SubjectConfirmation(System.Uri method) { }
        public Saml2SubjectConfirmation(System.Uri method, System.IdentityModel.Tokens.Saml2SubjectConfirmationData data) { }
        public System.Uri Method { get { throw null; } set { } }
        public System.IdentityModel.Tokens.Saml2NameIdentifier NameIdentifier { get { throw null; } set { } }
        public System.IdentityModel.Tokens.Saml2SubjectConfirmationData SubjectConfirmationData { get { throw null; } set { } }
    }
    public partial class Saml2SubjectConfirmationData
    {
        public Saml2SubjectConfirmationData() { }
        public string Address { get { throw null; } set { } }
        public System.IdentityModel.Tokens.Saml2Id InResponseTo { get { throw null; } set { } }
        public System.Collections.ObjectModel.Collection<System.IdentityModel.Tokens.SecurityKeyIdentifier> KeyIdentifiers { get { throw null; } }
        public System.Nullable<System.DateTime> NotBefore { get { throw null; } set { } }
        public System.Nullable<System.DateTime> NotOnOrAfter { get { throw null; } set { } }
        public System.Uri Recipient { get { throw null; } set { } }
    }
    public partial class Saml2SubjectLocality
    {
        public Saml2SubjectLocality() { }
        public Saml2SubjectLocality(string address, string dnsName) { }
        public string Address { get { throw null; } set { } }
        public string DnsName { get { throw null; } set { } }
    }
    [System.Runtime.Serialization.DataContractAttribute]
    public enum SamlAccessDecision
    {
        [System.Runtime.Serialization.EnumMemberAttribute]
        Deny = 1,
        [System.Runtime.Serialization.EnumMemberAttribute]
        Indeterminate = 2,
        [System.Runtime.Serialization.EnumMemberAttribute]
        Permit = 0,
    }
    public partial class SamlAction
    {
        public SamlAction() { }
        public SamlAction(string action) { }
        public SamlAction(string action, string ns) { }
        public string Action { get { throw null; } set { } }
        public bool IsReadOnly { get { throw null; } }
        public string Namespace { get { throw null; } set { } }
        public void MakeReadOnly() { }
        public virtual void ReadXml(System.Xml.XmlDictionaryReader reader, System.IdentityModel.Tokens.SamlSerializer samlSerializer, System.IdentityModel.Selectors.SecurityTokenSerializer keyInfoSerializer, System.IdentityModel.Selectors.SecurityTokenResolver outOfBandTokenResolver) { }
        public virtual void WriteXml(System.Xml.XmlDictionaryWriter writer, System.IdentityModel.Tokens.SamlSerializer samlSerializer, System.IdentityModel.Selectors.SecurityTokenSerializer keyInfoSerializer) { }
    }
    public partial class SamlAdvice
    {
        public SamlAdvice() { }
        public SamlAdvice(System.Collections.Generic.IEnumerable<System.IdentityModel.Tokens.SamlAssertion> assertions) { }
        public SamlAdvice(System.Collections.Generic.IEnumerable<string> references) { }
        public SamlAdvice(System.Collections.Generic.IEnumerable<string> references, System.Collections.Generic.IEnumerable<System.IdentityModel.Tokens.SamlAssertion> assertions) { }
        public System.Collections.Generic.IList<string> AssertionIdReferences { get { throw null; } }
        public System.Collections.Generic.IList<System.IdentityModel.Tokens.SamlAssertion> Assertions { get { throw null; } }
        public bool IsReadOnly { get { throw null; } }
        public void MakeReadOnly() { }
        public virtual void ReadXml(System.Xml.XmlDictionaryReader reader, System.IdentityModel.Tokens.SamlSerializer samlSerializer, System.IdentityModel.Selectors.SecurityTokenSerializer keyInfoSerializer, System.IdentityModel.Selectors.SecurityTokenResolver outOfBandTokenResolver) { }
        public virtual void WriteXml(System.Xml.XmlDictionaryWriter writer, System.IdentityModel.Tokens.SamlSerializer samlSerializer, System.IdentityModel.Selectors.SecurityTokenSerializer keyInfoSerializer) { }
    }
    public partial class SamlAssertion
    {
        public SamlAssertion() { }
        public SamlAssertion(string assertionId, string issuer, System.DateTime issueInstant, System.IdentityModel.Tokens.SamlConditions samlConditions, System.IdentityModel.Tokens.SamlAdvice samlAdvice, System.Collections.Generic.IEnumerable<System.IdentityModel.Tokens.SamlStatement> samlStatements) { }
        public System.IdentityModel.Tokens.SamlAdvice Advice { get { throw null; } set { } }
        public string AssertionId { get { throw null; } set { } }
        public virtual bool CanWriteSourceData { get { throw null; } }
        public System.IdentityModel.Tokens.SamlConditions Conditions { get { throw null; } set { } }
        public bool IsReadOnly { get { throw null; } }
        public System.DateTime IssueInstant { get { throw null; } set { } }
        public string Issuer { get { throw null; } set { } }
        public int MajorVersion { get { throw null; } }
        public int MinorVersion { get { throw null; } }
        public System.IdentityModel.Tokens.SigningCredentials SigningCredentials { get { throw null; } set { } }
        public System.IdentityModel.Tokens.SecurityToken SigningToken { get { throw null; } set { } }
        public System.Collections.Generic.IList<System.IdentityModel.Tokens.SamlStatement> Statements { get { throw null; } }
        public void MakeReadOnly() { }
        protected void ReadSignature(System.Xml.XmlDictionaryReader reader, System.IdentityModel.Selectors.SecurityTokenSerializer keyInfoSerializer, System.IdentityModel.Selectors.SecurityTokenResolver outOfBandTokenResolver, System.IdentityModel.Tokens.SamlSerializer samlSerializer) { }
        public virtual void ReadXml(System.Xml.XmlDictionaryReader reader, System.IdentityModel.Tokens.SamlSerializer samlSerializer, System.IdentityModel.Selectors.SecurityTokenSerializer keyInfoSerializer, System.IdentityModel.Selectors.SecurityTokenResolver outOfBandTokenResolver) { }
        public virtual void WriteSourceData(System.Xml.XmlWriter writer) { }
        public virtual void WriteXml(System.Xml.XmlDictionaryWriter writer, System.IdentityModel.Tokens.SamlSerializer samlSerializer, System.IdentityModel.Selectors.SecurityTokenSerializer keyInfoSerializer) { }
    }
    public partial class SamlAssertionKeyIdentifierClause : System.IdentityModel.Tokens.SecurityKeyIdentifierClause
    {
        public SamlAssertionKeyIdentifierClause(string assertionId) : base (default(string)) { }
        public SamlAssertionKeyIdentifierClause(string assertionId, byte[] derivationNonce, int derivationLength) : base (default(string)) { }
        public string AssertionId { get { throw null; } }
        public override bool Matches(System.IdentityModel.Tokens.SecurityKeyIdentifierClause keyIdentifierClause) { throw null; }
        public bool Matches(string assertionId) { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class SamlAttribute
    {
        public SamlAttribute() { }
        public SamlAttribute(System.IdentityModel.Claims.Claim claim) { }
        public SamlAttribute(string attributeNamespace, string attributeName, System.Collections.Generic.IEnumerable<string> attributeValues) { }
        public System.Collections.Generic.IList<string> AttributeValues { get { throw null; } }
        public string AttributeValueXsiType { get { throw null; } set { } }
        public bool IsReadOnly { get { throw null; } }
        public string Name { get { throw null; } set { } }
        public string Namespace { get { throw null; } set { } }
        public string OriginalIssuer { get { throw null; } set { } }
        public virtual System.Collections.ObjectModel.ReadOnlyCollection<System.IdentityModel.Claims.Claim> ExtractClaims() { throw null; }
        public void MakeReadOnly() { }
        public virtual void ReadXml(System.Xml.XmlDictionaryReader reader, System.IdentityModel.Tokens.SamlSerializer samlSerializer, System.IdentityModel.Selectors.SecurityTokenSerializer keyInfoSerializer, System.IdentityModel.Selectors.SecurityTokenResolver outOfBandTokenResolver) { }
        public virtual void WriteXml(System.Xml.XmlDictionaryWriter writer, System.IdentityModel.Tokens.SamlSerializer samlSerializer, System.IdentityModel.Selectors.SecurityTokenSerializer keyInfoSerializer) { }
    }
    public partial class SamlAttributeStatement : System.IdentityModel.Tokens.SamlSubjectStatement
    {
        public SamlAttributeStatement() { }
        public SamlAttributeStatement(System.IdentityModel.Tokens.SamlSubject samlSubject, System.Collections.Generic.IEnumerable<System.IdentityModel.Tokens.SamlAttribute> attributes) { }
        public System.Collections.Generic.IList<System.IdentityModel.Tokens.SamlAttribute> Attributes { get { throw null; } }
        public override bool IsReadOnly { get { throw null; } }
        protected override void AddClaimsToList(System.Collections.Generic.IList<System.IdentityModel.Claims.Claim> claims) { }
        public override void MakeReadOnly() { }
        public override void ReadXml(System.Xml.XmlDictionaryReader reader, System.IdentityModel.Tokens.SamlSerializer samlSerializer, System.IdentityModel.Selectors.SecurityTokenSerializer keyInfoSerializer, System.IdentityModel.Selectors.SecurityTokenResolver outOfBandTokenResolver) { }
        public override void WriteXml(System.Xml.XmlDictionaryWriter writer, System.IdentityModel.Tokens.SamlSerializer samlSerializer, System.IdentityModel.Selectors.SecurityTokenSerializer keyInfoSerializer) { }
    }
    public partial class SamlAudienceRestrictionCondition : System.IdentityModel.Tokens.SamlCondition
    {
        public SamlAudienceRestrictionCondition() { }
        public SamlAudienceRestrictionCondition(System.Collections.Generic.IEnumerable<System.Uri> audiences) { }
        public System.Collections.Generic.IList<System.Uri> Audiences { get { throw null; } }
        public override bool IsReadOnly { get { throw null; } }
        public override void MakeReadOnly() { }
        public override void ReadXml(System.Xml.XmlDictionaryReader reader, System.IdentityModel.Tokens.SamlSerializer samlSerializer, System.IdentityModel.Selectors.SecurityTokenSerializer keyInfoSerializer, System.IdentityModel.Selectors.SecurityTokenResolver outOfBandTokenResolver) { }
        public override void WriteXml(System.Xml.XmlDictionaryWriter writer, System.IdentityModel.Tokens.SamlSerializer samlSerializer, System.IdentityModel.Selectors.SecurityTokenSerializer keyInfoSerializer) { }
    }
    [System.Runtime.Serialization.DataContractAttribute]
    public partial class SamlAuthenticationClaimResource
    {
        public SamlAuthenticationClaimResource(System.DateTime authenticationInstant, string authenticationMethod, string dnsAddress, string ipAddress) { }
        public SamlAuthenticationClaimResource(System.DateTime authenticationInstant, string authenticationMethod, string dnsAddress, string ipAddress, System.Collections.Generic.IEnumerable<System.IdentityModel.Tokens.SamlAuthorityBinding> authorityBindings) { }
        public SamlAuthenticationClaimResource(System.DateTime authenticationInstant, string authenticationMethod, string dnsAddress, string ipAddress, System.Collections.ObjectModel.ReadOnlyCollection<System.IdentityModel.Tokens.SamlAuthorityBinding> authorityBindings) { }
        public System.DateTime AuthenticationInstant { get { throw null; } }
        public string AuthenticationMethod { get { throw null; } }
        public System.Collections.ObjectModel.ReadOnlyCollection<System.IdentityModel.Tokens.SamlAuthorityBinding> AuthorityBindings { get { throw null; } }
        public string DnsAddress { get { throw null; } }
        public string IPAddress { get { throw null; } }
        public override bool Equals(object obj) { throw null; }
        public override int GetHashCode() { throw null; }
    }
    public partial class SamlAuthenticationStatement : System.IdentityModel.Tokens.SamlSubjectStatement
    {
        public SamlAuthenticationStatement() { }
        public SamlAuthenticationStatement(System.IdentityModel.Tokens.SamlSubject samlSubject, string authenticationMethod, System.DateTime authenticationInstant, string dnsAddress, string ipAddress, System.Collections.Generic.IEnumerable<System.IdentityModel.Tokens.SamlAuthorityBinding> authorityBindings) { }
        public System.DateTime AuthenticationInstant { get { throw null; } set { } }
        public string AuthenticationMethod { get { throw null; } set { } }
        public System.Collections.Generic.IList<System.IdentityModel.Tokens.SamlAuthorityBinding> AuthorityBindings { get { throw null; } }
        public static string ClaimType { get { throw null; } }
        public string DnsAddress { get { throw null; } set { } }
        public string IPAddress { get { throw null; } set { } }
        public override bool IsReadOnly { get { throw null; } }
        protected override void AddClaimsToList(System.Collections.Generic.IList<System.IdentityModel.Claims.Claim> claims) { }
        public override void MakeReadOnly() { }
        public override void ReadXml(System.Xml.XmlDictionaryReader reader, System.IdentityModel.Tokens.SamlSerializer samlSerializer, System.IdentityModel.Selectors.SecurityTokenSerializer keyInfoSerializer, System.IdentityModel.Selectors.SecurityTokenResolver outOfBandTokenResolver) { }
        public override void WriteXml(System.Xml.XmlDictionaryWriter writer, System.IdentityModel.Tokens.SamlSerializer samlSerializer, System.IdentityModel.Selectors.SecurityTokenSerializer keyInfoSerializer) { }
    }
    [System.Runtime.Serialization.DataContractAttribute]
    public partial class SamlAuthorityBinding
    {
        public SamlAuthorityBinding() { }
        public SamlAuthorityBinding(System.Xml.XmlQualifiedName authorityKind, string binding, string location) { }
        [System.Runtime.Serialization.DataMemberAttribute]
        public System.Xml.XmlQualifiedName AuthorityKind { get { throw null; } set { } }
        [System.Runtime.Serialization.DataMemberAttribute]
        public string Binding { get { throw null; } set { } }
        public bool IsReadOnly { get { throw null; } }
        [System.Runtime.Serialization.DataMemberAttribute]
        public string Location { get { throw null; } set { } }
        public void MakeReadOnly() { }
        public virtual void ReadXml(System.Xml.XmlDictionaryReader reader, System.IdentityModel.Tokens.SamlSerializer samlSerializer, System.IdentityModel.Selectors.SecurityTokenSerializer keyInfoSerializer, System.IdentityModel.Selectors.SecurityTokenResolver outOfBandTokenResolver) { }
        public virtual void WriteXml(System.Xml.XmlDictionaryWriter writer, System.IdentityModel.Tokens.SamlSerializer samlSerializer, System.IdentityModel.Selectors.SecurityTokenSerializer keyInfoSerializer) { }
    }
    [System.Runtime.Serialization.DataContractAttribute]
    public partial class SamlAuthorizationDecisionClaimResource
    {
        public SamlAuthorizationDecisionClaimResource(string resource, System.IdentityModel.Tokens.SamlAccessDecision accessDecision, string actionNamespace, string actionName) { }
        public System.IdentityModel.Tokens.SamlAccessDecision AccessDecision { get { throw null; } }
        public string ActionName { get { throw null; } }
        public string ActionNamespace { get { throw null; } }
        public string Resource { get { throw null; } }
        public override bool Equals(object obj) { throw null; }
        public override int GetHashCode() { throw null; }
    }
    public partial class SamlAuthorizationDecisionStatement : System.IdentityModel.Tokens.SamlSubjectStatement
    {
        public SamlAuthorizationDecisionStatement() { }
        public SamlAuthorizationDecisionStatement(System.IdentityModel.Tokens.SamlSubject samlSubject, string resource, System.IdentityModel.Tokens.SamlAccessDecision accessDecision, System.Collections.Generic.IEnumerable<System.IdentityModel.Tokens.SamlAction> samlActions) { }
        public SamlAuthorizationDecisionStatement(System.IdentityModel.Tokens.SamlSubject samlSubject, string resource, System.IdentityModel.Tokens.SamlAccessDecision accessDecision, System.Collections.Generic.IEnumerable<System.IdentityModel.Tokens.SamlAction> samlActions, System.IdentityModel.Tokens.SamlEvidence samlEvidence) { }
        public System.IdentityModel.Tokens.SamlAccessDecision AccessDecision { get { throw null; } set { } }
        public static string ClaimType { get { throw null; } }
        public System.IdentityModel.Tokens.SamlEvidence Evidence { get { throw null; } set { } }
        public override bool IsReadOnly { get { throw null; } }
        public string Resource { get { throw null; } set { } }
        public System.Collections.Generic.IList<System.IdentityModel.Tokens.SamlAction> SamlActions { get { throw null; } }
        protected override void AddClaimsToList(System.Collections.Generic.IList<System.IdentityModel.Claims.Claim> claims) { }
        public override void MakeReadOnly() { }
        public override void ReadXml(System.Xml.XmlDictionaryReader reader, System.IdentityModel.Tokens.SamlSerializer samlSerializer, System.IdentityModel.Selectors.SecurityTokenSerializer keyInfoSerializer, System.IdentityModel.Selectors.SecurityTokenResolver outOfBandTokenResolver) { }
        public override void WriteXml(System.Xml.XmlDictionaryWriter writer, System.IdentityModel.Tokens.SamlSerializer samlSerializer, System.IdentityModel.Selectors.SecurityTokenSerializer keyInfoSerializer) { }
    }
    public abstract partial class SamlCondition
    {
        protected SamlCondition() { }
        public abstract bool IsReadOnly { get; }
        public abstract void MakeReadOnly();
        public abstract void ReadXml(System.Xml.XmlDictionaryReader reader, System.IdentityModel.Tokens.SamlSerializer samlSerializer, System.IdentityModel.Selectors.SecurityTokenSerializer keyInfoSerializer, System.IdentityModel.Selectors.SecurityTokenResolver outOfBandTokenResolver);
        public abstract void WriteXml(System.Xml.XmlDictionaryWriter writer, System.IdentityModel.Tokens.SamlSerializer samlSerializer, System.IdentityModel.Selectors.SecurityTokenSerializer keyInfoSerializer);
    }
    public partial class SamlConditions
    {
        public SamlConditions() { }
        public SamlConditions(System.DateTime notBefore, System.DateTime notOnOrAfter) { }
        public SamlConditions(System.DateTime notBefore, System.DateTime notOnOrAfter, System.Collections.Generic.IEnumerable<System.IdentityModel.Tokens.SamlCondition> conditions) { }
        public System.Collections.Generic.IList<System.IdentityModel.Tokens.SamlCondition> Conditions { get { throw null; } }
        public bool IsReadOnly { get { throw null; } }
        public System.DateTime NotBefore { get { throw null; } set { } }
        public System.DateTime NotOnOrAfter { get { throw null; } set { } }
        public void MakeReadOnly() { }
        public virtual void ReadXml(System.Xml.XmlDictionaryReader reader, System.IdentityModel.Tokens.SamlSerializer samlSerializer, System.IdentityModel.Selectors.SecurityTokenSerializer keyInfoSerializer, System.IdentityModel.Selectors.SecurityTokenResolver outOfBandTokenResolver) { }
        public virtual void WriteXml(System.Xml.XmlDictionaryWriter writer, System.IdentityModel.Tokens.SamlSerializer samlSerializer, System.IdentityModel.Selectors.SecurityTokenSerializer keyInfoSerializer) { }
    }
    public static partial class SamlConstants
    {
        public const string Prefix = "saml";
        public static string EmailName { get { throw null; } }
        public static string EmailNamespace { get { throw null; } }
        public static string HolderOfKey { get { throw null; } }
        public static int MajorVersionValue { get { throw null; } }
        public static int MinorVersionValue { get { throw null; } }
        public static string Namespace { get { throw null; } }
        public static string SenderVouches { get { throw null; } }
        public static string UserName { get { throw null; } }
        public static string UserNameNamespace { get { throw null; } }
    }
    public partial class SamlDoNotCacheCondition : System.IdentityModel.Tokens.SamlCondition
    {
        public SamlDoNotCacheCondition() { }
        public override bool IsReadOnly { get { throw null; } }
        public override void MakeReadOnly() { }
        public override void ReadXml(System.Xml.XmlDictionaryReader reader, System.IdentityModel.Tokens.SamlSerializer samlSerializer, System.IdentityModel.Selectors.SecurityTokenSerializer keyInfoSerializer, System.IdentityModel.Selectors.SecurityTokenResolver outOfBandTokenResolver) { }
        public override void WriteXml(System.Xml.XmlDictionaryWriter writer, System.IdentityModel.Tokens.SamlSerializer samlSerializer, System.IdentityModel.Selectors.SecurityTokenSerializer keyInfoSerializer) { }
    }
    public partial class SamlEvidence
    {
        public SamlEvidence() { }
        public SamlEvidence(System.Collections.Generic.IEnumerable<System.IdentityModel.Tokens.SamlAssertion> assertions) { }
        public SamlEvidence(System.Collections.Generic.IEnumerable<string> assertionIdReferences) { }
        public SamlEvidence(System.Collections.Generic.IEnumerable<string> assertionIdReferences, System.Collections.Generic.IEnumerable<System.IdentityModel.Tokens.SamlAssertion> assertions) { }
        public System.Collections.Generic.IList<string> AssertionIdReferences { get { throw null; } }
        public System.Collections.Generic.IList<System.IdentityModel.Tokens.SamlAssertion> Assertions { get { throw null; } }
        public bool IsReadOnly { get { throw null; } }
        public void MakeReadOnly() { }
        public virtual void ReadXml(System.Xml.XmlDictionaryReader reader, System.IdentityModel.Tokens.SamlSerializer samlSerializer, System.IdentityModel.Selectors.SecurityTokenSerializer keyInfoSerializer, System.IdentityModel.Selectors.SecurityTokenResolver outOfBandTokenResolver) { }
        public virtual void WriteXml(System.Xml.XmlDictionaryWriter writer, System.IdentityModel.Tokens.SamlSerializer samlSerializer, System.IdentityModel.Selectors.SecurityTokenSerializer keyInfoSerializer) { }
    }
    [System.Runtime.Serialization.DataContractAttribute]
    public partial class SamlNameIdentifierClaimResource
    {
        public SamlNameIdentifierClaimResource(string name, string nameQualifier, string format) { }
        public string Format { get { throw null; } }
        public string Name { get { throw null; } }
        public string NameQualifier { get { throw null; } }
        public override bool Equals(object obj) { throw null; }
        public override int GetHashCode() { throw null; }
    }
    public partial class SamlSecurityKeyIdentifierClause : System.IdentityModel.Tokens.SecurityKeyIdentifierClause
    {
        public SamlSecurityKeyIdentifierClause(System.IdentityModel.Tokens.SamlAssertion assertion) : base (default(string)) { }
        public System.IdentityModel.Tokens.SamlAssertion Assertion { get { throw null; } }
    }
    public partial class SamlSecurityToken : System.IdentityModel.Tokens.SecurityToken
    {
        protected SamlSecurityToken() { }
        public SamlSecurityToken(System.IdentityModel.Tokens.SamlAssertion assertion) { }
        public System.IdentityModel.Tokens.SamlAssertion Assertion { get { throw null; } }
        public override string Id { get { throw null; } }
        public override System.Collections.ObjectModel.ReadOnlyCollection<System.IdentityModel.Tokens.SecurityKey> SecurityKeys { get { throw null; } }
        public override System.DateTime ValidFrom { get { throw null; } }
        public override System.DateTime ValidTo { get { throw null; } }
        public override bool CanCreateKeyIdentifierClause<T>() { throw null; }
        public override T CreateKeyIdentifierClause<T>() { throw null; }
        protected void Initialize(System.IdentityModel.Tokens.SamlAssertion assertion) { }
        public override bool MatchesKeyIdentifierClause(System.IdentityModel.Tokens.SecurityKeyIdentifierClause keyIdentifierClause) { throw null; }
    }
    public partial class SamlSecurityTokenHandler : System.IdentityModel.Tokens.SecurityTokenHandler
    {
        public const string Assertion = "urn:oasis:names:tc:SAML:1.0:assertion";
        public const string BearerConfirmationMethod = "urn:oasis:names:tc:SAML:1.0:cm:bearer";
        public const string Namespace = "urn:oasis:names:tc:SAML:1.0";
        public const string UnspecifiedAuthenticationMethod = "urn:oasis:names:tc:SAML:1.0:am:unspecified";
        public SamlSecurityTokenHandler() { }
        public SamlSecurityTokenHandler(System.IdentityModel.Tokens.SamlSecurityTokenRequirement samlSecurityTokenRequirement) { }
        public override bool CanValidateToken { get { throw null; } }
        public override bool CanWriteToken { get { throw null; } }
        public System.IdentityModel.Selectors.X509CertificateValidator CertificateValidator { get { throw null; } set { } }
        public System.IdentityModel.Selectors.SecurityTokenSerializer KeyInfoSerializer { get { throw null; } set { } }
        public System.IdentityModel.Tokens.SamlSecurityTokenRequirement SamlSecurityTokenRequirement { get { throw null; } set { } }
        public override System.Type TokenType { get { throw null; } }
        protected virtual void AddDelegateToAttributes(System.Security.Claims.ClaimsIdentity subject, System.Collections.Generic.ICollection<System.IdentityModel.Tokens.SamlAttribute> attributes, System.IdentityModel.Tokens.SecurityTokenDescriptor tokenDescriptor) { }
        public override bool CanReadToken(System.Xml.XmlReader reader) { throw null; }
        protected virtual System.Collections.Generic.ICollection<System.IdentityModel.Tokens.SamlAttribute> CollectAttributeValues(System.Collections.Generic.ICollection<System.IdentityModel.Tokens.SamlAttribute> attributes) { throw null; }
        protected virtual System.IdentityModel.Tokens.SamlAdvice CreateAdvice(System.IdentityModel.Tokens.SecurityTokenDescriptor tokenDescriptor) { throw null; }
        protected virtual System.IdentityModel.Tokens.SamlAssertion CreateAssertion(string issuer, System.IdentityModel.Tokens.SamlConditions conditions, System.IdentityModel.Tokens.SamlAdvice advice, System.Collections.Generic.IEnumerable<System.IdentityModel.Tokens.SamlStatement> statements) { throw null; }
        protected virtual System.IdentityModel.Tokens.SamlAttribute CreateAttribute(System.Security.Claims.Claim claim, System.IdentityModel.Tokens.SecurityTokenDescriptor tokenDescriptor) { throw null; }
        protected virtual System.IdentityModel.Tokens.SamlAttributeStatement CreateAttributeStatement(System.IdentityModel.Tokens.SamlSubject samlSubject, System.Security.Claims.ClaimsIdentity subject, System.IdentityModel.Tokens.SecurityTokenDescriptor tokenDescriptor) { throw null; }
        protected virtual System.IdentityModel.Tokens.SamlAuthenticationStatement CreateAuthenticationStatement(System.IdentityModel.Tokens.SamlSubject samlSubject, System.Security.Claims.AuthenticationInformation authInfo, System.IdentityModel.Tokens.SecurityTokenDescriptor tokenDescriptor) { throw null; }
        protected virtual System.Security.Claims.ClaimsIdentity CreateClaims(System.IdentityModel.Tokens.SamlSecurityToken samlSecurityToken) { throw null; }
        protected virtual System.IdentityModel.Tokens.SamlConditions CreateConditions(System.IdentityModel.Protocols.WSTrust.Lifetime tokenLifetime, string relyingPartyAddress, System.IdentityModel.Tokens.SecurityTokenDescriptor tokenDescriptor) { throw null; }
        protected virtual System.IdentityModel.Tokens.SamlSubject CreateSamlSubject(System.IdentityModel.Tokens.SecurityTokenDescriptor tokenDescriptor) { throw null; }
        public override System.IdentityModel.Tokens.SecurityKeyIdentifierClause CreateSecurityTokenReference(System.IdentityModel.Tokens.SecurityToken token, bool attached) { throw null; }
        protected virtual System.Collections.Generic.IEnumerable<System.IdentityModel.Tokens.SamlStatement> CreateStatements(System.IdentityModel.Tokens.SecurityTokenDescriptor tokenDescriptor) { throw null; }
        public override System.IdentityModel.Tokens.SecurityToken CreateToken(System.IdentityModel.Tokens.SecurityTokenDescriptor tokenDescriptor) { throw null; }
        protected virtual System.Security.Principal.WindowsIdentity CreateWindowsIdentity(string upn) { throw null; }
        protected virtual string CreateXmlStringFromAttributes(System.Collections.Generic.IEnumerable<System.IdentityModel.Tokens.SamlAttribute> attributes) { throw null; }
        protected virtual string DenormalizeAuthenticationType(string normalizedAuthenticationType) { throw null; }
        protected override void DetectReplayedToken(System.IdentityModel.Tokens.SecurityToken token) { }
        protected virtual string FindUpn(System.Security.Claims.ClaimsIdentity claimsIdentity) { throw null; }
        protected virtual System.IdentityModel.Tokens.EncryptingCredentials GetEncryptingCredentials(System.IdentityModel.Tokens.SecurityTokenDescriptor tokenDescriptor) { throw null; }
        protected virtual System.IdentityModel.Tokens.SigningCredentials GetSigningCredentials(System.IdentityModel.Tokens.SecurityTokenDescriptor tokenDescriptor) { throw null; }
        protected virtual System.DateTime GetTokenReplayCacheEntryExpirationTime(System.IdentityModel.Tokens.SamlSecurityToken token) { throw null; }
        public override string[] GetTokenTypeIdentifiers() { throw null; }
        public override void LoadCustomConfiguration(System.Xml.XmlNodeList customConfigElements) { }
        protected virtual string NormalizeAuthenticationType(string saml11AuthenticationMethod) { throw null; }
        protected virtual void ProcessAttributeStatement(System.IdentityModel.Tokens.SamlAttributeStatement samlStatement, System.Security.Claims.ClaimsIdentity subject, string issuer) { }
        protected virtual void ProcessAuthenticationStatement(System.IdentityModel.Tokens.SamlAuthenticationStatement samlStatement, System.Security.Claims.ClaimsIdentity subject, string issuer) { }
        protected virtual void ProcessAuthorizationDecisionStatement(System.IdentityModel.Tokens.SamlAuthorizationDecisionStatement samlStatement, System.Security.Claims.ClaimsIdentity subject, string issuer) { }
        protected virtual void ProcessSamlSubject(System.IdentityModel.Tokens.SamlSubject samlSubject, System.Security.Claims.ClaimsIdentity subject, string issuer) { }
        protected virtual void ProcessStatement(System.Collections.Generic.IList<System.IdentityModel.Tokens.SamlStatement> statements, System.Security.Claims.ClaimsIdentity subject, string issuer) { }
        protected virtual System.IdentityModel.Tokens.SamlAction ReadAction(System.Xml.XmlReader reader) { throw null; }
        protected virtual System.IdentityModel.Tokens.SamlAdvice ReadAdvice(System.Xml.XmlReader reader) { throw null; }
        protected virtual System.IdentityModel.Tokens.SamlAssertion ReadAssertion(System.Xml.XmlReader reader) { throw null; }
        protected virtual System.IdentityModel.Tokens.SamlAttribute ReadAttribute(System.Xml.XmlReader reader) { throw null; }
        protected virtual System.IdentityModel.Tokens.SamlAttributeStatement ReadAttributeStatement(System.Xml.XmlReader reader) { throw null; }
        protected virtual string ReadAttributeValue(System.Xml.XmlReader reader, System.IdentityModel.Tokens.SamlAttribute attribute) { throw null; }
        protected virtual System.IdentityModel.Tokens.SamlAudienceRestrictionCondition ReadAudienceRestrictionCondition(System.Xml.XmlReader reader) { throw null; }
        protected virtual System.IdentityModel.Tokens.SamlAuthenticationStatement ReadAuthenticationStatement(System.Xml.XmlReader reader) { throw null; }
        protected virtual System.IdentityModel.Tokens.SamlAuthorityBinding ReadAuthorityBinding(System.Xml.XmlReader reader) { throw null; }
        protected virtual System.IdentityModel.Tokens.SamlAuthorizationDecisionStatement ReadAuthorizationDecisionStatement(System.Xml.XmlReader reader) { throw null; }
        protected virtual System.IdentityModel.Tokens.SamlCondition ReadCondition(System.Xml.XmlReader reader) { throw null; }
        protected virtual System.IdentityModel.Tokens.SamlConditions ReadConditions(System.Xml.XmlReader reader) { throw null; }
        protected virtual System.IdentityModel.Tokens.SamlDoNotCacheCondition ReadDoNotCacheCondition(System.Xml.XmlReader reader) { throw null; }
        protected virtual System.IdentityModel.Tokens.SamlEvidence ReadEvidence(System.Xml.XmlReader reader) { throw null; }
        protected virtual System.IdentityModel.Tokens.SecurityKeyIdentifier ReadSigningKeyInfo(System.Xml.XmlReader reader, System.IdentityModel.Tokens.SamlAssertion assertion) { throw null; }
        protected virtual System.IdentityModel.Tokens.SamlStatement ReadStatement(System.Xml.XmlReader reader) { throw null; }
        protected virtual System.IdentityModel.Tokens.SamlSubject ReadSubject(System.Xml.XmlReader reader) { throw null; }
        protected virtual System.IdentityModel.Tokens.SecurityKeyIdentifier ReadSubjectKeyInfo(System.Xml.XmlReader reader) { throw null; }
        public override System.IdentityModel.Tokens.SecurityToken ReadToken(System.Xml.XmlReader reader) { throw null; }
        protected virtual System.IdentityModel.Tokens.SecurityToken ResolveIssuerToken(System.IdentityModel.Tokens.SamlAssertion assertion, System.IdentityModel.Selectors.SecurityTokenResolver issuerResolver) { throw null; }
        protected virtual System.IdentityModel.Tokens.SecurityKey ResolveSubjectKeyIdentifier(System.IdentityModel.Tokens.SecurityKeyIdentifier subjectKeyIdentifier) { throw null; }
        protected virtual void SetDelegateFromAttribute(System.IdentityModel.Tokens.SamlAttribute attribute, System.Security.Claims.ClaimsIdentity subject, string issuer) { }
        protected virtual bool TryResolveIssuerToken(System.IdentityModel.Tokens.SamlAssertion assertion, System.IdentityModel.Selectors.SecurityTokenResolver issuerResolver, out System.IdentityModel.Tokens.SecurityToken token) { throw null; }
        protected virtual void ValidateConditions(System.IdentityModel.Tokens.SamlConditions conditions, bool enforceAudienceRestriction) { }
        public override System.Collections.ObjectModel.ReadOnlyCollection<System.Security.Claims.ClaimsIdentity> ValidateToken(System.IdentityModel.Tokens.SecurityToken token) { throw null; }
        protected virtual void WriteAction(System.Xml.XmlWriter writer, System.IdentityModel.Tokens.SamlAction action) { }
        protected virtual void WriteAdvice(System.Xml.XmlWriter writer, System.IdentityModel.Tokens.SamlAdvice advice) { }
        protected virtual void WriteAssertion(System.Xml.XmlWriter writer, System.IdentityModel.Tokens.SamlAssertion assertion) { }
        protected virtual void WriteAttribute(System.Xml.XmlWriter writer, System.IdentityModel.Tokens.SamlAttribute attribute) { }
        protected virtual void WriteAttributeStatement(System.Xml.XmlWriter writer, System.IdentityModel.Tokens.SamlAttributeStatement statement) { }
        protected virtual void WriteAttributeValue(System.Xml.XmlWriter writer, string value, System.IdentityModel.Tokens.SamlAttribute attribute) { }
        protected virtual void WriteAudienceRestrictionCondition(System.Xml.XmlWriter writer, System.IdentityModel.Tokens.SamlAudienceRestrictionCondition condition) { }
        protected virtual void WriteAuthenticationStatement(System.Xml.XmlWriter writer, System.IdentityModel.Tokens.SamlAuthenticationStatement statement) { }
        protected virtual void WriteAuthorityBinding(System.Xml.XmlWriter writer, System.IdentityModel.Tokens.SamlAuthorityBinding authorityBinding) { }
        protected virtual void WriteAuthorizationDecisionStatement(System.Xml.XmlWriter writer, System.IdentityModel.Tokens.SamlAuthorizationDecisionStatement statement) { }
        protected virtual void WriteCondition(System.Xml.XmlWriter writer, System.IdentityModel.Tokens.SamlCondition condition) { }
        protected virtual void WriteConditions(System.Xml.XmlWriter writer, System.IdentityModel.Tokens.SamlConditions conditions) { }
        protected virtual void WriteDoNotCacheCondition(System.Xml.XmlWriter writer, System.IdentityModel.Tokens.SamlDoNotCacheCondition condition) { }
        protected virtual void WriteEvidence(System.Xml.XmlWriter writer, System.IdentityModel.Tokens.SamlEvidence evidence) { }
        protected virtual void WriteSigningKeyInfo(System.Xml.XmlWriter writer, System.IdentityModel.Tokens.SecurityKeyIdentifier signingKeyIdentifier) { }
        protected virtual void WriteStatement(System.Xml.XmlWriter writer, System.IdentityModel.Tokens.SamlStatement statement) { }
        protected virtual void WriteSubject(System.Xml.XmlWriter writer, System.IdentityModel.Tokens.SamlSubject subject) { }
        protected virtual void WriteSubjectKeyInfo(System.Xml.XmlWriter writer, System.IdentityModel.Tokens.SecurityKeyIdentifier subjectSki) { }
        public override void WriteToken(System.Xml.XmlWriter writer, System.IdentityModel.Tokens.SecurityToken token) { }
    }
    public partial class SamlSecurityTokenRequirement
    {
        public SamlSecurityTokenRequirement() { }
        public SamlSecurityTokenRequirement(System.Xml.XmlElement element) { }
        public System.IdentityModel.Selectors.X509CertificateValidator CertificateValidator { get { throw null; } set { } }
        public bool MapToWindows { get { throw null; } set { } }
        public string NameClaimType { get { throw null; } set { } }
        public string RoleClaimType { get { throw null; } set { } }
        public virtual bool ShouldEnforceAudienceRestriction(System.IdentityModel.Selectors.AudienceUriMode audienceUriMode, System.IdentityModel.Tokens.SecurityToken token) { throw null; }
        public virtual void ValidateAudienceRestriction(System.Collections.Generic.IList<System.Uri> allowedAudienceUris, System.Collections.Generic.IList<System.Uri> tokenAudiences) { }
    }
    public partial class SamlSerializer
    {
        public SamlSerializer() { }
        public virtual System.IdentityModel.Tokens.SamlAdvice LoadAdvice(System.Xml.XmlDictionaryReader reader, System.IdentityModel.Selectors.SecurityTokenSerializer keyInfoSerializer, System.IdentityModel.Selectors.SecurityTokenResolver outOfBandTokenResolver) { throw null; }
        public virtual System.IdentityModel.Tokens.SamlAssertion LoadAssertion(System.Xml.XmlDictionaryReader reader, System.IdentityModel.Selectors.SecurityTokenSerializer keyInfoSerializer, System.IdentityModel.Selectors.SecurityTokenResolver outOfBandTokenResolver) { throw null; }
        public virtual System.IdentityModel.Tokens.SamlAttribute LoadAttribute(System.Xml.XmlDictionaryReader reader, System.IdentityModel.Selectors.SecurityTokenSerializer keyInfoSerializer, System.IdentityModel.Selectors.SecurityTokenResolver outOfBandTokenResolver) { throw null; }
        public virtual System.IdentityModel.Tokens.SamlCondition LoadCondition(System.Xml.XmlDictionaryReader reader, System.IdentityModel.Selectors.SecurityTokenSerializer keyInfoSerializer, System.IdentityModel.Selectors.SecurityTokenResolver outOfBandTokenResolver) { throw null; }
        public virtual System.IdentityModel.Tokens.SamlConditions LoadConditions(System.Xml.XmlDictionaryReader reader, System.IdentityModel.Selectors.SecurityTokenSerializer keyInfoSerializer, System.IdentityModel.Selectors.SecurityTokenResolver outOfBandTokenResolver) { throw null; }
        public virtual System.IdentityModel.Tokens.SamlStatement LoadStatement(System.Xml.XmlDictionaryReader reader, System.IdentityModel.Selectors.SecurityTokenSerializer keyInfoSerializer, System.IdentityModel.Selectors.SecurityTokenResolver outOfBandTokenResolver) { throw null; }
        public void PopulateDictionary(System.Xml.IXmlDictionary dictionary) { }
        public virtual System.IdentityModel.Tokens.SamlSecurityToken ReadToken(System.Xml.XmlReader reader, System.IdentityModel.Selectors.SecurityTokenSerializer keyInfoSerializer, System.IdentityModel.Selectors.SecurityTokenResolver outOfBandTokenResolver) { throw null; }
        public virtual void WriteToken(System.IdentityModel.Tokens.SamlSecurityToken token, System.Xml.XmlWriter writer, System.IdentityModel.Selectors.SecurityTokenSerializer keyInfoSerializer) { }
    }
    public abstract partial class SamlStatement
    {
        protected SamlStatement() { }
        public abstract bool IsReadOnly { get; }
        public abstract System.IdentityModel.Policy.IAuthorizationPolicy CreatePolicy(System.IdentityModel.Claims.ClaimSet issuer, System.IdentityModel.Selectors.SamlSecurityTokenAuthenticator samlAuthenticator);
        public abstract void MakeReadOnly();
        public abstract void ReadXml(System.Xml.XmlDictionaryReader reader, System.IdentityModel.Tokens.SamlSerializer samlSerializer, System.IdentityModel.Selectors.SecurityTokenSerializer keyInfoSerializer, System.IdentityModel.Selectors.SecurityTokenResolver outOfBandTokenResolver);
        public abstract void WriteXml(System.Xml.XmlDictionaryWriter writer, System.IdentityModel.Tokens.SamlSerializer samlSerializer, System.IdentityModel.Selectors.SecurityTokenSerializer keyInfoSerializer);
    }
    public partial class SamlSubject
    {
        public SamlSubject() { }
        public SamlSubject(string nameFormat, string nameQualifier, string name) { }
        public SamlSubject(string nameFormat, string nameQualifier, string name, System.Collections.Generic.IEnumerable<string> confirmations, string confirmationData, System.IdentityModel.Tokens.SecurityKeyIdentifier securityKeyIdentifier) { }
        public System.Collections.Generic.IList<string> ConfirmationMethods { get { throw null; } }
        public System.IdentityModel.Tokens.SecurityKey Crypto { get { throw null; } set { } }
        public bool IsReadOnly { get { throw null; } }
        public System.IdentityModel.Tokens.SecurityKeyIdentifier KeyIdentifier { get { throw null; } set { } }
        public string Name { get { throw null; } set { } }
        public static string NameClaimType { get { throw null; } }
        public string NameFormat { get { throw null; } set { } }
        public string NameQualifier { get { throw null; } set { } }
        public string SubjectConfirmationData { get { throw null; } set { } }
        public virtual System.Collections.ObjectModel.ReadOnlyCollection<System.IdentityModel.Claims.Claim> ExtractClaims() { throw null; }
        public virtual System.IdentityModel.Claims.ClaimSet ExtractSubjectKeyClaimSet(System.IdentityModel.Selectors.SamlSecurityTokenAuthenticator samlAuthenticator) { throw null; }
        public void MakeReadOnly() { }
        public virtual void ReadXml(System.Xml.XmlDictionaryReader reader, System.IdentityModel.Tokens.SamlSerializer samlSerializer, System.IdentityModel.Selectors.SecurityTokenSerializer keyInfoSerializer, System.IdentityModel.Selectors.SecurityTokenResolver outOfBandTokenResolver) { }
        public virtual void WriteXml(System.Xml.XmlDictionaryWriter writer, System.IdentityModel.Tokens.SamlSerializer samlSerializer, System.IdentityModel.Selectors.SecurityTokenSerializer keyInfoSerializer) { }
    }
    public abstract partial class SamlSubjectStatement : System.IdentityModel.Tokens.SamlStatement
    {
        protected SamlSubjectStatement() { }
        protected SamlSubjectStatement(System.IdentityModel.Tokens.SamlSubject samlSubject) { }
        public override bool IsReadOnly { get { throw null; } }
        public System.IdentityModel.Tokens.SamlSubject SamlSubject { get { throw null; } set { } }
        protected abstract void AddClaimsToList(System.Collections.Generic.IList<System.IdentityModel.Claims.Claim> claims);
        public override System.IdentityModel.Policy.IAuthorizationPolicy CreatePolicy(System.IdentityModel.Claims.ClaimSet issuer, System.IdentityModel.Selectors.SamlSecurityTokenAuthenticator samlAuthenticator) { throw null; }
        public override void MakeReadOnly() { }
        protected void SetSubject(System.IdentityModel.Tokens.SamlSubject samlSubject) { }
    }
    public static partial class SecurityAlgorithms
    {
        public const string Aes128Encryption = "http://www.w3.org/2001/04/xmlenc#aes128-cbc";
        public const string Aes128KeyWrap = "http://www.w3.org/2001/04/xmlenc#kw-aes128";
        public const string Aes192Encryption = "http://www.w3.org/2001/04/xmlenc#aes192-cbc";
        public const string Aes192KeyWrap = "http://www.w3.org/2001/04/xmlenc#kw-aes192";
        public const string Aes256Encryption = "http://www.w3.org/2001/04/xmlenc#aes256-cbc";
        public const string Aes256KeyWrap = "http://www.w3.org/2001/04/xmlenc#kw-aes256";
        public const string DesEncryption = "http://www.w3.org/2001/04/xmlenc#des-cbc";
        public const string DsaSha1Signature = "http://www.w3.org/2000/09/xmldsig#dsa-sha1";
        public const string ExclusiveC14n = "http://www.w3.org/2001/10/xml-exc-c14n#";
        public const string ExclusiveC14nWithComments = "http://www.w3.org/2001/10/xml-exc-c14n#WithComments";
        public const string HmacSha1Signature = "http://www.w3.org/2000/09/xmldsig#hmac-sha1";
        public const string HmacSha256Signature = "http://www.w3.org/2001/04/xmldsig-more#hmac-sha256";
        public const string Psha1KeyDerivation = "http://schemas.xmlsoap.org/ws/2005/02/sc/dk/p_sha1";
        public const string Psha1KeyDerivationDec2005 = "http://docs.oasis-open.org/ws-sx/ws-secureconversation/200512/dk/p_sha1";
        public const string Ripemd160Digest = "http://www.w3.org/2001/04/xmlenc#ripemd160";
        public const string RsaOaepKeyWrap = "http://www.w3.org/2001/04/xmlenc#rsa-oaep-mgf1p";
        public const string RsaSha1Signature = "http://www.w3.org/2000/09/xmldsig#rsa-sha1";
        public const string RsaSha256Signature = "http://www.w3.org/2001/04/xmldsig-more#rsa-sha256";
        public const string RsaV15KeyWrap = "http://www.w3.org/2001/04/xmlenc#rsa-1_5";
        public const string Sha1Digest = "http://www.w3.org/2000/09/xmldsig#sha1";
        public const string Sha256Digest = "http://www.w3.org/2001/04/xmlenc#sha256";
        public const string Sha512Digest = "http://www.w3.org/2001/04/xmlenc#sha512";
        public const string StrTransform = "http://docs.oasis-open.org/wss/2004/01/oasis-200401-wss-soap-message-security-1.0#STR-Transform";
        public const string TlsSspiKeyWrap = "http://schemas.xmlsoap.org/2005/02/trust/tlsnego#TLS_Wrap";
        public const string TripleDesEncryption = "http://www.w3.org/2001/04/xmlenc#tripledes-cbc";
        public const string TripleDesKeyWrap = "http://www.w3.org/2001/04/xmlenc#kw-tripledes";
        public const string WindowsSspiKeyWrap = "http://schemas.xmlsoap.org/2005/02/trust/spnego#GSS_Wrap";
    }
    public abstract partial class SecurityKey
    {
        protected SecurityKey() { }
        public abstract int KeySize { get; }
        public abstract byte[] DecryptKey(string algorithm, byte[] keyData);
        public abstract byte[] EncryptKey(string algorithm, byte[] keyData);
        public abstract bool IsAsymmetricAlgorithm(string algorithm);
        public abstract bool IsSupportedAlgorithm(string algorithm);
        public abstract bool IsSymmetricAlgorithm(string algorithm);
    }
    public partial class SecurityKeyElement : System.IdentityModel.Tokens.SecurityKey
    {
        public SecurityKeyElement(System.IdentityModel.Tokens.SecurityKeyIdentifier securityKeyIdentifier, System.IdentityModel.Selectors.SecurityTokenResolver securityTokenResolver) { }
        public SecurityKeyElement(System.IdentityModel.Tokens.SecurityKeyIdentifierClause securityKeyIdentifierClause, System.IdentityModel.Selectors.SecurityTokenResolver securityTokenResolver) { }
        public override int KeySize { get { throw null; } }
        public override byte[] DecryptKey(string algorithm, byte[] keyData) { throw null; }
        public override byte[] EncryptKey(string algorithm, byte[] keyData) { throw null; }
        public override bool IsAsymmetricAlgorithm(string algorithm) { throw null; }
        public override bool IsSupportedAlgorithm(string algorithm) { throw null; }
        public override bool IsSymmetricAlgorithm(string algorithm) { throw null; }
    }
    public partial class SecurityKeyIdentifier : System.Collections.Generic.IEnumerable<System.IdentityModel.Tokens.SecurityKeyIdentifierClause>, System.Collections.IEnumerable
    {
        public SecurityKeyIdentifier() { }
        public SecurityKeyIdentifier(params System.IdentityModel.Tokens.SecurityKeyIdentifierClause[] clauses) { }
        public bool CanCreateKey { get { throw null; } }
        public int Count { get { throw null; } }
        public bool IsReadOnly { get { throw null; } }
        public System.IdentityModel.Tokens.SecurityKeyIdentifierClause this[int index] { get { throw null; } }
        public void Add(System.IdentityModel.Tokens.SecurityKeyIdentifierClause clause) { }
        public System.IdentityModel.Tokens.SecurityKey CreateKey() { throw null; }
        public TClause Find<TClause>() where TClause : System.IdentityModel.Tokens.SecurityKeyIdentifierClause { throw null; }
        public System.Collections.Generic.IEnumerator<System.IdentityModel.Tokens.SecurityKeyIdentifierClause> GetEnumerator() { throw null; }
        public void MakeReadOnly() { }
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { throw null; }
        public override string ToString() { throw null; }
        public bool TryFind<TClause>(out TClause clause) where TClause : System.IdentityModel.Tokens.SecurityKeyIdentifierClause { throw null; }
    }
    public abstract partial class SecurityKeyIdentifierClause
    {
        protected SecurityKeyIdentifierClause(string clauseType) { }
        protected SecurityKeyIdentifierClause(string clauseType, byte[] nonce, int length) { }
        public virtual bool CanCreateKey { get { throw null; } }
        public string ClauseType { get { throw null; } }
        public int DerivationLength { get { throw null; } }
        public string Id { get { throw null; } set { } }
        public virtual System.IdentityModel.Tokens.SecurityKey CreateKey() { throw null; }
        public byte[] GetDerivationNonce() { throw null; }
        public virtual bool Matches(System.IdentityModel.Tokens.SecurityKeyIdentifierClause keyIdentifierClause) { throw null; }
    }
    public abstract partial class SecurityKeyIdentifierClauseSerializer
    {
        protected SecurityKeyIdentifierClauseSerializer() { }
        public abstract bool CanReadKeyIdentifierClause(System.Xml.XmlReader reader);
        public abstract bool CanWriteKeyIdentifierClause(System.IdentityModel.Tokens.SecurityKeyIdentifierClause securityKeyIdentifierClause);
        public abstract System.IdentityModel.Tokens.SecurityKeyIdentifierClause ReadKeyIdentifierClause(System.Xml.XmlReader reader);
        public abstract void WriteKeyIdentifierClause(System.Xml.XmlWriter writer, System.IdentityModel.Tokens.SecurityKeyIdentifierClause securityKeyIdentifierClause);
    }
    public enum SecurityKeyType
    {
        AsymmetricKey = 1,
        BearerKey = 2,
        SymmetricKey = 0,
    }
    public enum SecurityKeyUsage
    {
        Exchange = 0,
        Signature = 1,
    }
    public abstract partial class SecurityToken
    {
        protected SecurityToken() { }
        public abstract string Id { get; }
        public abstract System.Collections.ObjectModel.ReadOnlyCollection<System.IdentityModel.Tokens.SecurityKey> SecurityKeys { get; }
        public abstract System.DateTime ValidFrom { get; }
        public abstract System.DateTime ValidTo { get; }
        public virtual bool CanCreateKeyIdentifierClause<T>() where T : System.IdentityModel.Tokens.SecurityKeyIdentifierClause { throw null; }
        public virtual T CreateKeyIdentifierClause<T>() where T : System.IdentityModel.Tokens.SecurityKeyIdentifierClause { throw null; }
        public virtual bool MatchesKeyIdentifierClause(System.IdentityModel.Tokens.SecurityKeyIdentifierClause keyIdentifierClause) { throw null; }
        public virtual System.IdentityModel.Tokens.SecurityKey ResolveKeyIdentifierClause(System.IdentityModel.Tokens.SecurityKeyIdentifierClause keyIdentifierClause) { throw null; }
    }
    public partial class SecurityTokenDescriptor
    {
        public SecurityTokenDescriptor() { }
        public string AppliesToAddress { get { throw null; } set { } }
        public System.IdentityModel.Tokens.SecurityKeyIdentifierClause AttachedReference { get { throw null; } set { } }
        public System.Security.Claims.AuthenticationInformation AuthenticationInfo { get { throw null; } set { } }
        public System.IdentityModel.Tokens.EncryptingCredentials EncryptingCredentials { get { throw null; } set { } }
        public System.IdentityModel.Protocols.WSTrust.Lifetime Lifetime { get { throw null; } set { } }
        public System.IdentityModel.Tokens.ProofDescriptor Proof { get { throw null; } set { } }
        public System.Collections.Generic.Dictionary<string, object> Properties { get { throw null; } }
        public string ReplyToAddress { get { throw null; } set { } }
        public System.IdentityModel.Tokens.SigningCredentials SigningCredentials { get { throw null; } set { } }
        public System.Security.Claims.ClaimsIdentity Subject { get { throw null; } set { } }
        public System.IdentityModel.Tokens.SecurityToken Token { get { throw null; } set { } }
        public string TokenIssuerName { get { throw null; } set { } }
        public string TokenType { get { throw null; } set { } }
        public System.IdentityModel.Tokens.SecurityKeyIdentifierClause UnattachedReference { get { throw null; } set { } }
        public void AddAuthenticationClaims(string authType) { }
        public void AddAuthenticationClaims(string authType, System.DateTime time) { }
        public virtual void ApplyTo(System.IdentityModel.Protocols.WSTrust.RequestSecurityTokenResponse response) { }
    }
    public partial class SecurityTokenElement
    {
        public SecurityTokenElement(System.IdentityModel.Tokens.SecurityToken securityToken) { }
        public SecurityTokenElement(System.Xml.XmlElement securityTokenXml, System.IdentityModel.Tokens.SecurityTokenHandlerCollection securityTokenHandlers) { }
        public System.Xml.XmlElement SecurityTokenXml { get { throw null; } }
        public System.Collections.ObjectModel.ReadOnlyCollection<System.Security.Claims.ClaimsIdentity> GetIdentities() { throw null; }
        public System.IdentityModel.Tokens.SecurityToken GetSecurityToken() { throw null; }
        protected virtual System.IdentityModel.Tokens.SecurityToken ReadSecurityToken(System.Xml.XmlElement securityTokenXml, System.IdentityModel.Tokens.SecurityTokenHandlerCollection securityTokenHandlers) { throw null; }
        protected virtual System.Collections.ObjectModel.ReadOnlyCollection<System.Security.Claims.ClaimsIdentity> ValidateToken(System.Xml.XmlElement securityTokenXml, System.IdentityModel.Tokens.SecurityTokenHandlerCollection securityTokenHandlers) { throw null; }
    }
    [System.SerializableAttribute]
    public partial class SecurityTokenException : System.SystemException
    {
        public SecurityTokenException() { }
        protected SecurityTokenException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
        public SecurityTokenException(string message) { }
        public SecurityTokenException(string message, System.Exception innerException) { }
    }
    [System.SerializableAttribute]
    public partial class SecurityTokenExpiredException : System.IdentityModel.Tokens.SecurityTokenValidationException
    {
        public SecurityTokenExpiredException() { }
        protected SecurityTokenExpiredException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
        public SecurityTokenExpiredException(string message) { }
        public SecurityTokenExpiredException(string message, System.Exception inner) { }
    }
    public abstract partial class SecurityTokenHandler : System.IdentityModel.Configuration.ICustomIdentityConfiguration
    {
        protected SecurityTokenHandler() { }
        public virtual bool CanValidateToken { get { throw null; } }
        public virtual bool CanWriteToken { get { throw null; } }
        public System.IdentityModel.Tokens.SecurityTokenHandlerConfiguration Configuration { get { throw null; } set { } }
        public System.IdentityModel.Tokens.SecurityTokenHandlerCollection ContainingCollection { get { throw null; } }
        public abstract System.Type TokenType { get; }
        public virtual bool CanReadKeyIdentifierClause(System.Xml.XmlReader reader) { throw null; }
        public virtual bool CanReadToken(string tokenString) { throw null; }
        public virtual bool CanReadToken(System.Xml.XmlReader reader) { throw null; }
        public virtual bool CanWriteKeyIdentifierClause(System.IdentityModel.Tokens.SecurityKeyIdentifierClause securityKeyIdentifierClause) { throw null; }
        public virtual System.IdentityModel.Tokens.SecurityKeyIdentifierClause CreateSecurityTokenReference(System.IdentityModel.Tokens.SecurityToken token, bool attached) { throw null; }
        public virtual System.IdentityModel.Tokens.SecurityToken CreateToken(System.IdentityModel.Tokens.SecurityTokenDescriptor tokenDescriptor) { throw null; }
        protected virtual void DetectReplayedToken(System.IdentityModel.Tokens.SecurityToken token) { }
        public abstract string[] GetTokenTypeIdentifiers();
        public virtual void LoadCustomConfiguration(System.Xml.XmlNodeList nodelist) { }
        public virtual System.IdentityModel.Tokens.SecurityKeyIdentifierClause ReadKeyIdentifierClause(System.Xml.XmlReader reader) { throw null; }
        public virtual System.IdentityModel.Tokens.SecurityToken ReadToken(string tokenString) { throw null; }
        public virtual System.IdentityModel.Tokens.SecurityToken ReadToken(System.Xml.XmlReader reader) { throw null; }
        public virtual System.IdentityModel.Tokens.SecurityToken ReadToken(System.Xml.XmlReader reader, System.IdentityModel.Selectors.SecurityTokenResolver tokenResolver) { throw null; }
        protected void TraceTokenValidationFailure(System.IdentityModel.Tokens.SecurityToken token, string errorMessage) { }
        protected void TraceTokenValidationSuccess(System.IdentityModel.Tokens.SecurityToken token) { }
        public virtual System.Collections.ObjectModel.ReadOnlyCollection<System.Security.Claims.ClaimsIdentity> ValidateToken(System.IdentityModel.Tokens.SecurityToken token) { throw null; }
        public virtual void WriteKeyIdentifierClause(System.Xml.XmlWriter writer, System.IdentityModel.Tokens.SecurityKeyIdentifierClause securityKeyIdentifierClause) { }
        public virtual string WriteToken(System.IdentityModel.Tokens.SecurityToken token) { throw null; }
        public virtual void WriteToken(System.Xml.XmlWriter writer, System.IdentityModel.Tokens.SecurityToken token) { }
    }
    public partial class SecurityTokenHandlerCollection : System.Collections.ObjectModel.Collection<System.IdentityModel.Tokens.SecurityTokenHandler>
    {
        public SecurityTokenHandlerCollection() { }
        public SecurityTokenHandlerCollection(System.Collections.Generic.IEnumerable<System.IdentityModel.Tokens.SecurityTokenHandler> handlers) { }
        public SecurityTokenHandlerCollection(System.Collections.Generic.IEnumerable<System.IdentityModel.Tokens.SecurityTokenHandler> handlers, System.IdentityModel.Tokens.SecurityTokenHandlerConfiguration configuration) { }
        public SecurityTokenHandlerCollection(System.IdentityModel.Tokens.SecurityTokenHandlerConfiguration configuration) { }
        public System.IdentityModel.Tokens.SecurityTokenHandlerConfiguration Configuration { get { throw null; } }
        public System.IdentityModel.Tokens.SecurityTokenHandler this[System.IdentityModel.Tokens.SecurityToken token] { get { throw null; } }
        public System.IdentityModel.Tokens.SecurityTokenHandler this[string tokenTypeIdentifier] { get { throw null; } }
        public System.IdentityModel.Tokens.SecurityTokenHandler this[System.Type tokenType] { get { throw null; } }
        public System.Collections.Generic.IEnumerable<string> TokenTypeIdentifiers { get { throw null; } }
        public System.Collections.Generic.IEnumerable<System.Type> TokenTypes { get { throw null; } }
        public void AddOrReplace(System.IdentityModel.Tokens.SecurityTokenHandler handler) { }
        public bool CanReadKeyIdentifierClause(System.Xml.XmlReader reader) { throw null; }
        protected virtual bool CanReadKeyIdentifierClauseCore(System.Xml.XmlReader reader) { throw null; }
        public bool CanReadToken(string tokenString) { throw null; }
        public bool CanReadToken(System.Xml.XmlReader reader) { throw null; }
        public bool CanWriteToken(System.IdentityModel.Tokens.SecurityToken token) { throw null; }
        protected override void ClearItems() { }
        public static System.IdentityModel.Tokens.SecurityTokenHandlerCollection CreateDefaultSecurityTokenHandlerCollection() { throw null; }
        public static System.IdentityModel.Tokens.SecurityTokenHandlerCollection CreateDefaultSecurityTokenHandlerCollection(System.IdentityModel.Tokens.SecurityTokenHandlerConfiguration configuration) { throw null; }
        public System.IdentityModel.Tokens.SecurityToken CreateToken(System.IdentityModel.Tokens.SecurityTokenDescriptor tokenDescriptor) { throw null; }
        protected override void InsertItem(int index, System.IdentityModel.Tokens.SecurityTokenHandler item) { }
        public System.IdentityModel.Tokens.SecurityKeyIdentifierClause ReadKeyIdentifierClause(System.Xml.XmlReader reader) { throw null; }
        protected virtual System.IdentityModel.Tokens.SecurityKeyIdentifierClause ReadKeyIdentifierClauseCore(System.Xml.XmlReader reader) { throw null; }
        public System.IdentityModel.Tokens.SecurityToken ReadToken(string tokenString) { throw null; }
        public System.IdentityModel.Tokens.SecurityToken ReadToken(System.Xml.XmlReader reader) { throw null; }
        protected override void RemoveItem(int index) { }
        protected override void SetItem(int index, System.IdentityModel.Tokens.SecurityTokenHandler item) { }
        public System.Collections.ObjectModel.ReadOnlyCollection<System.Security.Claims.ClaimsIdentity> ValidateToken(System.IdentityModel.Tokens.SecurityToken token) { throw null; }
        public void WriteKeyIdentifierClause(System.Xml.XmlWriter writer, System.IdentityModel.Tokens.SecurityKeyIdentifierClause keyIdentifierClause) { }
        protected virtual void WriteKeyIdentifierClauseCore(System.Xml.XmlWriter writer, System.IdentityModel.Tokens.SecurityKeyIdentifierClause keyIdentifierClause) { }
        public string WriteToken(System.IdentityModel.Tokens.SecurityToken token) { throw null; }
        public void WriteToken(System.Xml.XmlWriter writer, System.IdentityModel.Tokens.SecurityToken token) { }
    }
    public partial class SecurityTokenHandlerCollectionManager
    {
        public SecurityTokenHandlerCollectionManager(string serviceName) { }
        public int Count { get { throw null; } }
        public System.IdentityModel.Tokens.SecurityTokenHandlerCollection this[string usage] { get { throw null; } set { } }
        public System.Collections.Generic.IEnumerable<System.IdentityModel.Tokens.SecurityTokenHandlerCollection> SecurityTokenHandlerCollections { get { throw null; } }
        public string ServiceName { get { throw null; } }
        public bool ContainsKey(string usage) { throw null; }
        public static System.IdentityModel.Tokens.SecurityTokenHandlerCollectionManager CreateDefaultSecurityTokenHandlerCollectionManager() { throw null; }
        public static System.IdentityModel.Tokens.SecurityTokenHandlerCollectionManager CreateEmptySecurityTokenHandlerCollectionManager() { throw null; }
        public static partial class Usage
        {
            public const string ActAs = "ActAs";
            public const string Default = "";
            public const string OnBehalfOf = "OnBehalfOf";
        }
    }
    public partial class SecurityTokenHandlerConfiguration
    {
        public static readonly System.ServiceModel.Security.X509CertificateValidationMode DefaultCertificateValidationMode;
        public static readonly System.IdentityModel.Selectors.X509CertificateValidator DefaultCertificateValidator;
        public static readonly bool DefaultDetectReplayedTokens;
        public static readonly System.IdentityModel.Tokens.IssuerNameRegistry DefaultIssuerNameRegistry;
        public static readonly System.IdentityModel.Selectors.SecurityTokenResolver DefaultIssuerTokenResolver;
        public static readonly System.TimeSpan DefaultMaxClockSkew;
        public static readonly System.Security.Cryptography.X509Certificates.X509RevocationMode DefaultRevocationMode;
        public static readonly bool DefaultSaveBootstrapContext;
        public static readonly System.TimeSpan DefaultTokenReplayCacheExpirationPeriod;
        public static readonly System.Security.Cryptography.X509Certificates.StoreLocation DefaultTrustedStoreLocation;
        public SecurityTokenHandlerConfiguration() { }
        public System.IdentityModel.Tokens.AudienceRestriction AudienceRestriction { get { throw null; } set { } }
        public System.IdentityModel.Configuration.IdentityModelCaches Caches { get { throw null; } set { } }
        public System.ServiceModel.Security.X509CertificateValidationMode CertificateValidationMode { get { throw null; } set { } }
        public System.IdentityModel.Selectors.X509CertificateValidator CertificateValidator { get { throw null; } set { } }
        public bool DetectReplayedTokens { get { throw null; } set { } }
        public System.IdentityModel.Tokens.IssuerNameRegistry IssuerNameRegistry { get { throw null; } set { } }
        public System.IdentityModel.Selectors.SecurityTokenResolver IssuerTokenResolver { get { throw null; } set { } }
        public System.TimeSpan MaxClockSkew { get { throw null; } set { } }
        public System.Security.Cryptography.X509Certificates.X509RevocationMode RevocationMode { get { throw null; } set { } }
        public bool SaveBootstrapContext { get { throw null; } set { } }
        public System.IdentityModel.Selectors.SecurityTokenResolver ServiceTokenResolver { get { throw null; } set { } }
        public System.TimeSpan TokenReplayCacheExpirationPeriod { get { throw null; } set { } }
        public System.Security.Cryptography.X509Certificates.StoreLocation TrustedStoreLocation { get { throw null; } set { } }
    }
    [System.SerializableAttribute]
    public partial class SecurityTokenNotYetValidException : System.IdentityModel.Tokens.SecurityTokenValidationException
    {
        public SecurityTokenNotYetValidException() { }
        protected SecurityTokenNotYetValidException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
        public SecurityTokenNotYetValidException(string message) { }
        public SecurityTokenNotYetValidException(string message, System.Exception inner) { }
    }
    [System.SerializableAttribute]
    public partial class SecurityTokenReplayDetectedException : System.IdentityModel.Tokens.SecurityTokenValidationException
    {
        public SecurityTokenReplayDetectedException() { }
        protected SecurityTokenReplayDetectedException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
        public SecurityTokenReplayDetectedException(string message) { }
        public SecurityTokenReplayDetectedException(string message, System.Exception inner) { }
    }
    public static partial class SecurityTokenTypes
    {
        public static string Kerberos { get { throw null; } }
        public static string Rsa { get { throw null; } }
        public static string Saml { get { throw null; } }
        public static string UserName { get { throw null; } }
        public static string X509Certificate { get { throw null; } }
    }
    [System.SerializableAttribute]
    public partial class SecurityTokenValidationException : System.IdentityModel.Tokens.SecurityTokenException
    {
        public SecurityTokenValidationException() { }
        protected SecurityTokenValidationException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
        public SecurityTokenValidationException(string message) { }
        public SecurityTokenValidationException(string message, System.Exception innerException) { }
    }
    [System.SerializableAttribute]
    public partial class SessionSecurityToken : System.IdentityModel.Tokens.SecurityToken, System.Runtime.Serialization.ISerializable
    {
        protected SessionSecurityToken(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
        public SessionSecurityToken(System.Security.Claims.ClaimsPrincipal claimsPrincipal) { }
        public SessionSecurityToken(System.Security.Claims.ClaimsPrincipal claimsPrincipal, string context) { }
        public SessionSecurityToken(System.Security.Claims.ClaimsPrincipal claimsPrincipal, string context, System.Nullable<System.DateTime> validFrom, System.Nullable<System.DateTime> validTo) { }
        public SessionSecurityToken(System.Security.Claims.ClaimsPrincipal claimsPrincipal, string context, string endpointId, System.Nullable<System.DateTime> validFrom, System.Nullable<System.DateTime> validTo) { }
        public SessionSecurityToken(System.Security.Claims.ClaimsPrincipal claimsPrincipal, System.TimeSpan lifetime) { }
        public SessionSecurityToken(System.Security.Claims.ClaimsPrincipal claimsPrincipal, System.Xml.UniqueId contextId, string context, string endpointId, System.DateTime validFrom, System.TimeSpan lifetime, System.IdentityModel.Tokens.SymmetricSecurityKey key) { }
        public SessionSecurityToken(System.Security.Claims.ClaimsPrincipal claimsPrincipal, System.Xml.UniqueId contextId, string context, string endpointId, System.Nullable<System.DateTime> validFrom, System.Nullable<System.DateTime> validTo, System.IdentityModel.Tokens.SymmetricSecurityKey key) { }
        public SessionSecurityToken(System.Security.Claims.ClaimsPrincipal claimsPrincipal, System.Xml.UniqueId contextId, string context, string endpointId, System.TimeSpan lifetime, System.IdentityModel.Tokens.SymmetricSecurityKey key) { }
        public System.Security.Claims.ClaimsPrincipal ClaimsPrincipal { get { throw null; } }
        public string Context { get { throw null; } }
        public System.Xml.UniqueId ContextId { get { throw null; } }
        public string EndpointId { get { throw null; } }
        public override string Id { get { throw null; } }
        public bool IsPersistent { get { throw null; } set { } }
        public bool IsReferenceMode { get { throw null; } set { } }
        public System.DateTime KeyEffectiveTime { get { throw null; } }
        public System.DateTime KeyExpirationTime { get { throw null; } }
        public System.Xml.UniqueId KeyGeneration { get { throw null; } }
        public System.Uri SecureConversationVersion { get { throw null; } }
        public override System.Collections.ObjectModel.ReadOnlyCollection<System.IdentityModel.Tokens.SecurityKey> SecurityKeys { get { throw null; } }
        public override System.DateTime ValidFrom { get { throw null; } }
        public override System.DateTime ValidTo { get { throw null; } }
        public virtual void GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
    }
    public abstract partial class SessionSecurityTokenCache : System.IdentityModel.Configuration.ICustomIdentityConfiguration
    {
        protected SessionSecurityTokenCache() { }
        public abstract void AddOrUpdate(System.IdentityModel.Tokens.SessionSecurityTokenCacheKey key, System.IdentityModel.Tokens.SessionSecurityToken value, System.DateTime expiryTime);
        public abstract System.IdentityModel.Tokens.SessionSecurityToken Get(System.IdentityModel.Tokens.SessionSecurityTokenCacheKey key);
        public abstract System.Collections.Generic.IEnumerable<System.IdentityModel.Tokens.SessionSecurityToken> GetAll(string endpointId, System.Xml.UniqueId contextId);
        public virtual void LoadCustomConfiguration(System.Xml.XmlNodeList nodelist) { }
        public abstract void Remove(System.IdentityModel.Tokens.SessionSecurityTokenCacheKey key);
        public abstract void RemoveAll(string endpointId);
        public abstract void RemoveAll(string endpointId, System.Xml.UniqueId contextId);
    }
    public partial class SessionSecurityTokenCacheKey
    {
        public SessionSecurityTokenCacheKey(string endpointId, System.Xml.UniqueId contextId, System.Xml.UniqueId keyGeneration) { }
        public System.Xml.UniqueId ContextId { get { throw null; } }
        public string EndpointId { get { throw null; } }
        public bool IgnoreKeyGeneration { get { throw null; } set { } }
        public System.Xml.UniqueId KeyGeneration { get { throw null; } }
        public override bool Equals(object obj) { throw null; }
        public override int GetHashCode() { throw null; }
        public static bool operator ==(System.IdentityModel.Tokens.SessionSecurityTokenCacheKey first, System.IdentityModel.Tokens.SessionSecurityTokenCacheKey second) { throw null; }
        public static bool operator !=(System.IdentityModel.Tokens.SessionSecurityTokenCacheKey first, System.IdentityModel.Tokens.SessionSecurityTokenCacheKey second) { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class SessionSecurityTokenHandler : System.IdentityModel.Tokens.SecurityTokenHandler
    {
        public static readonly System.Collections.ObjectModel.ReadOnlyCollection<System.IdentityModel.CookieTransform> DefaultCookieTransforms;
        public static readonly System.TimeSpan DefaultLifetime;
        public SessionSecurityTokenHandler() { }
        public SessionSecurityTokenHandler(System.Collections.ObjectModel.ReadOnlyCollection<System.IdentityModel.CookieTransform> transforms) { }
        public SessionSecurityTokenHandler(System.Collections.ObjectModel.ReadOnlyCollection<System.IdentityModel.CookieTransform> transforms, System.TimeSpan tokenLifetime) { }
        public override bool CanValidateToken { get { throw null; } }
        public override bool CanWriteToken { get { throw null; } }
        public virtual string CookieElementName { get { throw null; } }
        public virtual string CookieNamespace { get { throw null; } }
        public static System.TimeSpan DefaultTokenLifetime { get { throw null; } }
        public virtual System.TimeSpan TokenLifetime { get { throw null; } set { } }
        public override System.Type TokenType { get { throw null; } }
        public System.Collections.ObjectModel.ReadOnlyCollection<System.IdentityModel.CookieTransform> Transforms { get { throw null; } }
        protected virtual byte[] ApplyTransforms(byte[] cookie, bool outbound) { throw null; }
        public override bool CanReadToken(System.Xml.XmlReader reader) { throw null; }
        public virtual System.IdentityModel.Tokens.SessionSecurityToken CreateSessionSecurityToken(System.Security.Claims.ClaimsPrincipal principal, string context, string endpointId, System.DateTime validFrom, System.DateTime validTo) { throw null; }
        public override System.IdentityModel.Tokens.SecurityToken CreateToken(System.IdentityModel.Tokens.SecurityTokenDescriptor tokenDescriptor) { throw null; }
        public override string[] GetTokenTypeIdentifiers() { throw null; }
        public override void LoadCustomConfiguration(System.Xml.XmlNodeList customConfigElements) { }
        public virtual System.IdentityModel.Tokens.SecurityToken ReadToken(byte[] token, System.IdentityModel.Selectors.SecurityTokenResolver tokenResolver) { throw null; }
        public override System.IdentityModel.Tokens.SecurityToken ReadToken(System.Xml.XmlReader reader) { throw null; }
        public override System.IdentityModel.Tokens.SecurityToken ReadToken(System.Xml.XmlReader reader, System.IdentityModel.Selectors.SecurityTokenResolver tokenResolver) { throw null; }
        protected void SetTransforms(System.Collections.Generic.IEnumerable<System.IdentityModel.CookieTransform> transforms) { }
        protected virtual void ValidateSession(System.IdentityModel.Tokens.SessionSecurityToken securityToken) { }
        public override System.Collections.ObjectModel.ReadOnlyCollection<System.Security.Claims.ClaimsIdentity> ValidateToken(System.IdentityModel.Tokens.SecurityToken token) { throw null; }
        public virtual System.Collections.ObjectModel.ReadOnlyCollection<System.Security.Claims.ClaimsIdentity> ValidateToken(System.IdentityModel.Tokens.SessionSecurityToken token, string endpointId) { throw null; }
        public virtual byte[] WriteToken(System.IdentityModel.Tokens.SessionSecurityToken sessionToken) { throw null; }
        public override void WriteToken(System.Xml.XmlWriter writer, System.IdentityModel.Tokens.SecurityToken token) { }
    }
    public partial class SigningCredentials
    {
        public SigningCredentials(System.IdentityModel.Tokens.SecurityKey signingKey, string signatureAlgorithm, string digestAlgorithm) { }
        public SigningCredentials(System.IdentityModel.Tokens.SecurityKey signingKey, string signatureAlgorithm, string digestAlgorithm, System.IdentityModel.Tokens.SecurityKeyIdentifier signingKeyIdentifier) { }
        public string DigestAlgorithm { get { throw null; } }
        public string SignatureAlgorithm { get { throw null; } }
        public System.IdentityModel.Tokens.SecurityKey SigningKey { get { throw null; } }
        public System.IdentityModel.Tokens.SecurityKeyIdentifier SigningKeyIdentifier { get { throw null; } }
    }
    public partial class SymmetricProofDescriptor : System.IdentityModel.Tokens.ProofDescriptor
    {
        public SymmetricProofDescriptor(byte[] key, System.IdentityModel.Tokens.EncryptingCredentials targetWrappingCredentials) { }
        public SymmetricProofDescriptor(System.IdentityModel.Tokens.EncryptingCredentials targetWrappingCredentials) { }
        public SymmetricProofDescriptor(int keySizeInBits, System.IdentityModel.Tokens.EncryptingCredentials targetWrappingCredentials) { }
        public SymmetricProofDescriptor(int keySizeInBits, System.IdentityModel.Tokens.EncryptingCredentials targetWrappingCredentials, System.IdentityModel.Tokens.EncryptingCredentials requestorWrappingCredentials) { }
        public SymmetricProofDescriptor(int keySizeInBits, System.IdentityModel.Tokens.EncryptingCredentials targetWrappingCredentials, System.IdentityModel.Tokens.EncryptingCredentials requestorWrappingCredentials, byte[] sourceEntropy) { }
        public SymmetricProofDescriptor(int keySizeInBits, System.IdentityModel.Tokens.EncryptingCredentials targetWrappingCredentials, System.IdentityModel.Tokens.EncryptingCredentials requestorWrappingCredentials, byte[] sourceEntropy, string encryptWith) { }
        public SymmetricProofDescriptor(int keySizeInBits, System.IdentityModel.Tokens.EncryptingCredentials targetWrappingCredentials, System.IdentityModel.Tokens.EncryptingCredentials requestorWrappingCredentials, string encryptWith) { }
        public override System.IdentityModel.Tokens.SecurityKeyIdentifier KeyIdentifier { get { throw null; } }
        protected System.IdentityModel.Tokens.EncryptingCredentials RequestorEncryptingCredentials { get { throw null; } }
        protected System.IdentityModel.Tokens.EncryptingCredentials TargetEncryptingCredentials { get { throw null; } }
        public override void ApplyTo(System.IdentityModel.Protocols.WSTrust.RequestSecurityTokenResponse response) { }
        public byte[] GetKeyBytes() { throw null; }
        protected byte[] GetSourceEntropy() { throw null; }
        protected byte[] GetTargetEntropy() { throw null; }
    }
    public abstract partial class SymmetricSecurityKey : System.IdentityModel.Tokens.SecurityKey
    {
        protected SymmetricSecurityKey() { }
        public abstract byte[] GenerateDerivedKey(string algorithm, byte[] label, byte[] nonce, int derivedKeyLength, int offset);
        public abstract System.Security.Cryptography.ICryptoTransform GetDecryptionTransform(string algorithm, byte[] iv);
        public abstract System.Security.Cryptography.ICryptoTransform GetEncryptionTransform(string algorithm, byte[] iv);
        public abstract int GetIVSize(string algorithm);
        public abstract System.Security.Cryptography.KeyedHashAlgorithm GetKeyedHashAlgorithm(string algorithm);
        public abstract System.Security.Cryptography.SymmetricAlgorithm GetSymmetricAlgorithm(string algorithm);
        public abstract byte[] GetSymmetricKey();
    }
    public abstract partial class TokenReplayCache : System.IdentityModel.Configuration.ICustomIdentityConfiguration
    {
        protected TokenReplayCache() { }
        public abstract void AddOrUpdate(string key, System.IdentityModel.Tokens.SecurityToken securityToken, System.DateTime expirationTime);
        public abstract bool Contains(string key);
        public abstract System.IdentityModel.Tokens.SecurityToken Get(string key);
        public virtual void LoadCustomConfiguration(System.Xml.XmlNodeList nodelist) { }
        public abstract void Remove(string key);
    }
    public partial class UserNameSecurityToken : System.IdentityModel.Tokens.SecurityToken
    {
        public UserNameSecurityToken(string userName, string password) { }
        public UserNameSecurityToken(string userName, string password, string id) { }
        public override string Id { get { throw null; } }
        public string Password { get { throw null; } }
        public override System.Collections.ObjectModel.ReadOnlyCollection<System.IdentityModel.Tokens.SecurityKey> SecurityKeys { get { throw null; } }
        public string UserName { get { throw null; } }
        public override System.DateTime ValidFrom { get { throw null; } }
        public override System.DateTime ValidTo { get { throw null; } }
    }
    public abstract partial class UserNameSecurityTokenHandler : System.IdentityModel.Tokens.SecurityTokenHandler
    {
        protected UserNameSecurityTokenHandler() { }
        public override bool CanWriteToken { get { throw null; } }
        public virtual bool RetainPassword { get { throw null; } set { } }
        public override System.Type TokenType { get { throw null; } }
        public override bool CanReadToken(System.Xml.XmlReader reader) { throw null; }
        public override string[] GetTokenTypeIdentifiers() { throw null; }
        public override System.IdentityModel.Tokens.SecurityToken ReadToken(System.Xml.XmlReader reader) { throw null; }
        public override void WriteToken(System.Xml.XmlWriter writer, System.IdentityModel.Tokens.SecurityToken token) { }
    }
    public partial class WindowsSecurityToken : System.IdentityModel.Tokens.SecurityToken, System.IDisposable
    {
        protected WindowsSecurityToken() { }
        public WindowsSecurityToken(System.Security.Principal.WindowsIdentity windowsIdentity) { }
        public WindowsSecurityToken(System.Security.Principal.WindowsIdentity windowsIdentity, string id) { }
        public WindowsSecurityToken(System.Security.Principal.WindowsIdentity windowsIdentity, string id, string authenticationType) { }
        public string AuthenticationType { get { throw null; } }
        public override string Id { get { throw null; } }
        public override System.Collections.ObjectModel.ReadOnlyCollection<System.IdentityModel.Tokens.SecurityKey> SecurityKeys { get { throw null; } }
        public override System.DateTime ValidFrom { get { throw null; } }
        public override System.DateTime ValidTo { get { throw null; } }
        public virtual System.Security.Principal.WindowsIdentity WindowsIdentity { get { throw null; } }
        public virtual void Dispose() { }
        protected void Initialize(string id, System.DateTime effectiveTime, System.DateTime expirationTime, System.Security.Principal.WindowsIdentity windowsIdentity, bool clone) { }
        protected void Initialize(string id, string authenticationType, System.DateTime effectiveTime, System.DateTime expirationTime, System.Security.Principal.WindowsIdentity windowsIdentity, bool clone) { }
        protected void ThrowIfDisposed() { }
    }
    public partial class WindowsUserNameSecurityTokenHandler : System.IdentityModel.Tokens.UserNameSecurityTokenHandler
    {
        public WindowsUserNameSecurityTokenHandler() { }
        public override bool CanValidateToken { get { throw null; } }
        public override System.Collections.ObjectModel.ReadOnlyCollection<System.Security.Claims.ClaimsIdentity> ValidateToken(System.IdentityModel.Tokens.SecurityToken token) { throw null; }
    }
    public partial class X509AsymmetricSecurityKey : System.IdentityModel.Tokens.AsymmetricSecurityKey
    {
        public X509AsymmetricSecurityKey(System.Security.Cryptography.X509Certificates.X509Certificate2 certificate) { }
        public override int KeySize { get { throw null; } }
        public override byte[] DecryptKey(string algorithm, byte[] keyData) { throw null; }
        public override byte[] EncryptKey(string algorithm, byte[] keyData) { throw null; }
        public override System.Security.Cryptography.AsymmetricAlgorithm GetAsymmetricAlgorithm(string algorithm, bool privateKey) { throw null; }
        public override System.Security.Cryptography.HashAlgorithm GetHashAlgorithmForSignature(string algorithm) { throw null; }
        public override System.Security.Cryptography.AsymmetricSignatureDeformatter GetSignatureDeformatter(string algorithm) { throw null; }
        public override System.Security.Cryptography.AsymmetricSignatureFormatter GetSignatureFormatter(string algorithm) { throw null; }
        public override bool HasPrivateKey() { throw null; }
        public override bool IsAsymmetricAlgorithm(string algorithm) { throw null; }
        public override bool IsSupportedAlgorithm(string algorithm) { throw null; }
        public override bool IsSymmetricAlgorithm(string algorithm) { throw null; }
    }
    public partial class X509CertificateStoreTokenResolver : System.IdentityModel.Selectors.SecurityTokenResolver
    {
        public X509CertificateStoreTokenResolver() { }
        public X509CertificateStoreTokenResolver(System.Security.Cryptography.X509Certificates.StoreName storeName, System.Security.Cryptography.X509Certificates.StoreLocation storeLocation) { }
        public X509CertificateStoreTokenResolver(string storeName, System.Security.Cryptography.X509Certificates.StoreLocation storeLocation) { }
        public System.Security.Cryptography.X509Certificates.StoreLocation StoreLocation { get { throw null; } }
        public string StoreName { get { throw null; } }
        protected override bool TryResolveSecurityKeyCore(System.IdentityModel.Tokens.SecurityKeyIdentifierClause keyIdentifierClause, out System.IdentityModel.Tokens.SecurityKey key) { throw null; }
        protected override bool TryResolveTokenCore(System.IdentityModel.Tokens.SecurityKeyIdentifier keyIdentifier, out System.IdentityModel.Tokens.SecurityToken token) { throw null; }
        protected override bool TryResolveTokenCore(System.IdentityModel.Tokens.SecurityKeyIdentifierClause keyIdentifierClause, out System.IdentityModel.Tokens.SecurityToken token) { throw null; }
    }
    public partial class X509DataSecurityKeyIdentifierClauseSerializer : System.IdentityModel.Tokens.SecurityKeyIdentifierClauseSerializer
    {
        public X509DataSecurityKeyIdentifierClauseSerializer() { }
        public override bool CanReadKeyIdentifierClause(System.Xml.XmlReader reader) { throw null; }
        public override bool CanWriteKeyIdentifierClause(System.IdentityModel.Tokens.SecurityKeyIdentifierClause securityKeyIdentifierClause) { throw null; }
        public override System.IdentityModel.Tokens.SecurityKeyIdentifierClause ReadKeyIdentifierClause(System.Xml.XmlReader reader) { throw null; }
        public override void WriteKeyIdentifierClause(System.Xml.XmlWriter writer, System.IdentityModel.Tokens.SecurityKeyIdentifierClause securityKeyIdentifierClause) { }
    }
    public partial class X509EncryptingCredentials : System.IdentityModel.Tokens.EncryptingCredentials
    {
        public X509EncryptingCredentials(System.Security.Cryptography.X509Certificates.X509Certificate2 certificate) { }
        public X509EncryptingCredentials(System.Security.Cryptography.X509Certificates.X509Certificate2 certificate, System.IdentityModel.Tokens.SecurityKeyIdentifier ski) { }
        public X509EncryptingCredentials(System.Security.Cryptography.X509Certificates.X509Certificate2 certificate, System.IdentityModel.Tokens.SecurityKeyIdentifier ski, string keyWrappingAlgorithm) { }
        public X509EncryptingCredentials(System.Security.Cryptography.X509Certificates.X509Certificate2 certificate, string keyWrappingAlgorithm) { }
        public System.Security.Cryptography.X509Certificates.X509Certificate2 Certificate { get { throw null; } }
    }
    public partial class X509IssuerSerialKeyIdentifierClause : System.IdentityModel.Tokens.SecurityKeyIdentifierClause
    {
        public X509IssuerSerialKeyIdentifierClause(System.Security.Cryptography.X509Certificates.X509Certificate2 certificate) : base (default(string)) { }
        public X509IssuerSerialKeyIdentifierClause(string issuerName, string issuerSerialNumber) : base (default(string)) { }
        public string IssuerName { get { throw null; } }
        public string IssuerSerialNumber { get { throw null; } }
        public override bool Matches(System.IdentityModel.Tokens.SecurityKeyIdentifierClause keyIdentifierClause) { throw null; }
        public bool Matches(System.Security.Cryptography.X509Certificates.X509Certificate2 certificate) { throw null; }
        public bool Matches(string issuerName, string issuerSerialNumber) { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class X509NTAuthChainTrustValidator : System.IdentityModel.Selectors.X509CertificateValidator
    {
        public X509NTAuthChainTrustValidator() { }
        public X509NTAuthChainTrustValidator(bool useMachineContext, System.Security.Cryptography.X509Certificates.X509ChainPolicy chainPolicy) { }
        public override void Validate(System.Security.Cryptography.X509Certificates.X509Certificate2 certificate) { }
    }
    public partial class X509RawDataKeyIdentifierClause : System.IdentityModel.Tokens.BinaryKeyIdentifierClause
    {
        public X509RawDataKeyIdentifierClause(byte[] certificateRawData) : base (default(string), default(byte[]), default(bool)) { }
        public X509RawDataKeyIdentifierClause(System.Security.Cryptography.X509Certificates.X509Certificate2 certificate) : base (default(string), default(byte[]), default(bool)) { }
        public override bool CanCreateKey { get { throw null; } }
        public override System.IdentityModel.Tokens.SecurityKey CreateKey() { throw null; }
        public byte[] GetX509RawData() { throw null; }
        public bool Matches(System.Security.Cryptography.X509Certificates.X509Certificate2 certificate) { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class X509SecurityToken : System.IdentityModel.Tokens.SecurityToken, System.IDisposable
    {
        public X509SecurityToken(System.Security.Cryptography.X509Certificates.X509Certificate2 certificate) { }
        public X509SecurityToken(System.Security.Cryptography.X509Certificates.X509Certificate2 certificate, string id) { }
        public System.Security.Cryptography.X509Certificates.X509Certificate2 Certificate { get { throw null; } }
        public override string Id { get { throw null; } }
        public override System.Collections.ObjectModel.ReadOnlyCollection<System.IdentityModel.Tokens.SecurityKey> SecurityKeys { get { throw null; } }
        public override System.DateTime ValidFrom { get { throw null; } }
        public override System.DateTime ValidTo { get { throw null; } }
        public override bool CanCreateKeyIdentifierClause<T>() { throw null; }
        public override T CreateKeyIdentifierClause<T>() { throw null; }
        public virtual void Dispose() { }
        public override bool MatchesKeyIdentifierClause(System.IdentityModel.Tokens.SecurityKeyIdentifierClause keyIdentifierClause) { throw null; }
        protected void ThrowIfDisposed() { }
    }
    public partial class X509SecurityTokenHandler : System.IdentityModel.Tokens.SecurityTokenHandler
    {
        public X509SecurityTokenHandler() { }
        public X509SecurityTokenHandler(bool mapToWindows) { }
        public X509SecurityTokenHandler(bool mapToWindows, System.IdentityModel.Selectors.X509CertificateValidator certificateValidator) { }
        public X509SecurityTokenHandler(System.IdentityModel.Selectors.X509CertificateValidator certificateValidator) { }
        public override bool CanValidateToken { get { throw null; } }
        public override bool CanWriteToken { get { throw null; } }
        public System.IdentityModel.Selectors.X509CertificateValidator CertificateValidator { get { throw null; } set { } }
        public bool MapToWindows { get { throw null; } set { } }
        public override System.Type TokenType { get { throw null; } }
        public bool WriteXmlDSigDefinedClauseTypes { get { throw null; } set { } }
        public System.IdentityModel.Tokens.X509NTAuthChainTrustValidator X509NTAuthChainTrustValidator { get { throw null; } set { } }
        public override bool CanReadKeyIdentifierClause(System.Xml.XmlReader reader) { throw null; }
        public override bool CanReadToken(System.Xml.XmlReader reader) { throw null; }
        public override bool CanWriteKeyIdentifierClause(System.IdentityModel.Tokens.SecurityKeyIdentifierClause securityKeyIdentifierClause) { throw null; }
        public override string[] GetTokenTypeIdentifiers() { throw null; }
        public override void LoadCustomConfiguration(System.Xml.XmlNodeList customConfigElements) { }
        public override System.IdentityModel.Tokens.SecurityKeyIdentifierClause ReadKeyIdentifierClause(System.Xml.XmlReader reader) { throw null; }
        public override System.IdentityModel.Tokens.SecurityToken ReadToken(System.Xml.XmlReader reader) { throw null; }
        public override System.Collections.ObjectModel.ReadOnlyCollection<System.Security.Claims.ClaimsIdentity> ValidateToken(System.IdentityModel.Tokens.SecurityToken token) { throw null; }
        public override void WriteKeyIdentifierClause(System.Xml.XmlWriter writer, System.IdentityModel.Tokens.SecurityKeyIdentifierClause securityKeyIdentifierClause) { }
        public override void WriteToken(System.Xml.XmlWriter writer, System.IdentityModel.Tokens.SecurityToken token) { }
    }
    public partial class X509SigningCredentials : System.IdentityModel.Tokens.SigningCredentials
    {
        public X509SigningCredentials(System.Security.Cryptography.X509Certificates.X509Certificate2 certificate) : base (default(System.IdentityModel.Tokens.SecurityKey), default(string), default(string)) { }
        public X509SigningCredentials(System.Security.Cryptography.X509Certificates.X509Certificate2 certificate, System.IdentityModel.Tokens.SecurityKeyIdentifier ski) : base (default(System.IdentityModel.Tokens.SecurityKey), default(string), default(string)) { }
        public X509SigningCredentials(System.Security.Cryptography.X509Certificates.X509Certificate2 certificate, System.IdentityModel.Tokens.SecurityKeyIdentifier ski, string signatureAlgorithm, string digestAlgorithm) : base (default(System.IdentityModel.Tokens.SecurityKey), default(string), default(string)) { }
        public X509SigningCredentials(System.Security.Cryptography.X509Certificates.X509Certificate2 certificate, string signatureAlgorithm, string digestAlgorithm) : base (default(System.IdentityModel.Tokens.SecurityKey), default(string), default(string)) { }
        public System.Security.Cryptography.X509Certificates.X509Certificate2 Certificate { get { throw null; } }
    }
    public partial class X509SubjectKeyIdentifierClause : System.IdentityModel.Tokens.BinaryKeyIdentifierClause
    {
        public X509SubjectKeyIdentifierClause(byte[] ski) : base (default(string), default(byte[]), default(bool)) { }
        public static bool CanCreateFrom(System.Security.Cryptography.X509Certificates.X509Certificate2 certificate) { throw null; }
        public byte[] GetX509SubjectKeyIdentifier() { throw null; }
        public bool Matches(System.Security.Cryptography.X509Certificates.X509Certificate2 certificate) { throw null; }
        public override string ToString() { throw null; }
        public static bool TryCreateFrom(System.Security.Cryptography.X509Certificates.X509Certificate2 certificate, out System.IdentityModel.Tokens.X509SubjectKeyIdentifierClause keyIdentifierClause) { throw null; }
    }
    public partial class X509ThumbprintKeyIdentifierClause : System.IdentityModel.Tokens.BinaryKeyIdentifierClause
    {
        public X509ThumbprintKeyIdentifierClause(byte[] thumbprint) : base (default(string), default(byte[]), default(bool)) { }
        public X509ThumbprintKeyIdentifierClause(System.Security.Cryptography.X509Certificates.X509Certificate2 certificate) : base (default(string), default(byte[]), default(bool)) { }
        public byte[] GetX509Thumbprint() { throw null; }
        public bool Matches(System.Security.Cryptography.X509Certificates.X509Certificate2 certificate) { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class X509WindowsSecurityToken : System.IdentityModel.Tokens.X509SecurityToken
    {
        public X509WindowsSecurityToken(System.Security.Cryptography.X509Certificates.X509Certificate2 certificate, System.Security.Principal.WindowsIdentity windowsIdentity) : base (default(System.Security.Cryptography.X509Certificates.X509Certificate2)) { }
        public X509WindowsSecurityToken(System.Security.Cryptography.X509Certificates.X509Certificate2 certificate, System.Security.Principal.WindowsIdentity windowsIdentity, string id) : base (default(System.Security.Cryptography.X509Certificates.X509Certificate2)) { }
        public X509WindowsSecurityToken(System.Security.Cryptography.X509Certificates.X509Certificate2 certificate, System.Security.Principal.WindowsIdentity windowsIdentity, string authenticationType, string id) : base (default(System.Security.Cryptography.X509Certificates.X509Certificate2)) { }
        public string AuthenticationType { get { throw null; } }
        public System.Security.Principal.WindowsIdentity WindowsIdentity { get { throw null; } }
        public override void Dispose() { }
    }
}
namespace System.Security.Claims
{
    public partial class AuthenticationInformation
    {
        public AuthenticationInformation() { }
        public string Address { get { throw null; } set { } }
        public System.Collections.ObjectModel.Collection<System.IdentityModel.Tokens.AuthenticationContext> AuthorizationContexts { get { throw null; } }
        public string DnsName { get { throw null; } set { } }
        public System.Nullable<System.DateTime> NotOnOrAfter { get { throw null; } set { } }
        public string Session { get { throw null; } set { } }
    }
    public static partial class AuthenticationTypes
    {
        public const string Basic = "Basic";
        public const string Federation = "Federation";
        public const string Kerberos = "Kerberos";
        public const string Negotiate = "Negotiate";
        public const string Password = "Password";
        public const string Signature = "Signature";
        public const string Windows = "Windows";
        public const string X509 = "X509";
    }
    public partial class AuthorizationContext
    {
        public AuthorizationContext(System.Security.Claims.ClaimsPrincipal principal, System.Collections.ObjectModel.Collection<System.Security.Claims.Claim> resource, System.Collections.ObjectModel.Collection<System.Security.Claims.Claim> action) { }
        public AuthorizationContext(System.Security.Claims.ClaimsPrincipal principal, string resource, string action) { }
        public System.Collections.ObjectModel.Collection<System.Security.Claims.Claim> Action { get { throw null; } }
        public System.Security.Claims.ClaimsPrincipal Principal { get { throw null; } }
        public System.Collections.ObjectModel.Collection<System.Security.Claims.Claim> Resource { get { throw null; } }
    }
    public static partial class ClaimProperties
    {
        public const string Namespace = "http://schemas.xmlsoap.org/ws/2005/05/identity/claimproperties";
        public const string SamlAttributeDisplayName = "http://schemas.xmlsoap.org/ws/2005/05/identity/claimproperties/displayname";
        public const string SamlAttributeNameFormat = "http://schemas.xmlsoap.org/ws/2005/05/identity/claimproperties/attributename";
        public const string SamlNameIdentifierFormat = "http://schemas.xmlsoap.org/ws/2005/05/identity/claimproperties/format";
        public const string SamlNameIdentifierNameQualifier = "http://schemas.xmlsoap.org/ws/2005/05/identity/claimproperties/namequalifier";
        public const string SamlNameIdentifierSPNameQualifier = "http://schemas.xmlsoap.org/ws/2005/05/identity/claimproperties/spnamequalifier";
        public const string SamlNameIdentifierSPProvidedId = "http://schemas.xmlsoap.org/ws/2005/05/identity/claimproperties/spprovidedid";
    }
    public partial class ClaimsAuthenticationManager : System.IdentityModel.Configuration.ICustomIdentityConfiguration
    {
        public ClaimsAuthenticationManager() { }
        public virtual System.Security.Claims.ClaimsPrincipal Authenticate(string resourceName, System.Security.Claims.ClaimsPrincipal incomingPrincipal) { throw null; }
        public virtual void LoadCustomConfiguration(System.Xml.XmlNodeList nodelist) { }
    }
    public partial class ClaimsAuthorizationManager : System.IdentityModel.Configuration.ICustomIdentityConfiguration
    {
        public ClaimsAuthorizationManager() { }
        public virtual bool CheckAccess(System.Security.Claims.AuthorizationContext context) { throw null; }
        public virtual void LoadCustomConfiguration(System.Xml.XmlNodeList nodelist) { }
    }
}
namespace System.ServiceModel.Security
{
    [System.Runtime.CompilerServices.TypeForwardedFromAttribute("System.ServiceModel, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")]
    public partial class BinarySecretKeyIdentifierClause : System.IdentityModel.Tokens.BinaryKeyIdentifierClause
    {
        public BinarySecretKeyIdentifierClause(byte[] key) : base (default(string), default(byte[]), default(bool)) { }
        public BinarySecretKeyIdentifierClause(byte[] key, bool cloneBuffer) : base (default(string), default(byte[]), default(bool)) { }
        public BinarySecretKeyIdentifierClause(byte[] key, bool cloneBuffer, byte[] derivationNonce, int derivationLength) : base (default(string), default(byte[]), default(bool)) { }
        public override bool CanCreateKey { get { throw null; } }
        public override System.IdentityModel.Tokens.SecurityKey CreateKey() { throw null; }
        public byte[] GetKeyBytes() { throw null; }
        public override bool Matches(System.IdentityModel.Tokens.SecurityKeyIdentifierClause keyIdentifierClause) { throw null; }
    }
    [System.Runtime.CompilerServices.TypeForwardedFromAttribute("System.ServiceModel, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")]
    public partial class KeyNameIdentifierClause : System.IdentityModel.Tokens.SecurityKeyIdentifierClause
    {
        public KeyNameIdentifierClause(string keyName) : base (default(string)) { }
        public string KeyName { get { throw null; } }
        public override bool Matches(System.IdentityModel.Tokens.SecurityKeyIdentifierClause keyIdentifierClause) { throw null; }
        public bool Matches(string keyName) { throw null; }
        public override string ToString() { throw null; }
    }
    [System.Runtime.CompilerServices.TypeForwardedFromAttribute("System.ServiceModel, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")]
    public partial class SecurityContextKeyIdentifierClause : System.IdentityModel.Tokens.SecurityKeyIdentifierClause
    {
        public SecurityContextKeyIdentifierClause(System.Xml.UniqueId contextId) : base (default(string)) { }
        public SecurityContextKeyIdentifierClause(System.Xml.UniqueId contextId, System.Xml.UniqueId generation) : base (default(string)) { }
        public SecurityContextKeyIdentifierClause(System.Xml.UniqueId contextId, System.Xml.UniqueId generation, byte[] derivationNonce, int derivationLength) : base (default(string)) { }
        public System.Xml.UniqueId ContextId { get { throw null; } }
        public System.Xml.UniqueId Generation { get { throw null; } }
        public override bool Matches(System.IdentityModel.Tokens.SecurityKeyIdentifierClause keyIdentifierClause) { throw null; }
        public bool Matches(System.Xml.UniqueId contextId, System.Xml.UniqueId generation) { throw null; }
        public override string ToString() { throw null; }
    }
    [System.Runtime.CompilerServices.TypeForwardedFromAttribute("System.ServiceModel, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")]
    public enum X509CertificateValidationMode
    {
        ChainTrust = 2,
        Custom = 4,
        None = 0,
        PeerOrChainTrust = 3,
        PeerTrust = 1,
    }
}
namespace System.ServiceModel.Security.Tokens
{
    [System.Runtime.CompilerServices.TypeForwardedFromAttribute("System.ServiceModel, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")]
    public partial class BinarySecretSecurityToken : System.IdentityModel.Tokens.SecurityToken
    {
        public BinarySecretSecurityToken(byte[] key) { }
        public BinarySecretSecurityToken(int keySizeInBits) { }
        public BinarySecretSecurityToken(string id, byte[] key) { }
        protected BinarySecretSecurityToken(string id, byte[] key, bool allowCrypto) { }
        public BinarySecretSecurityToken(string id, int keySizeInBits) { }
        protected BinarySecretSecurityToken(string id, int keySizeInBits, bool allowCrypto) { }
        public override string Id { get { throw null; } }
        public int KeySize { get { throw null; } }
        public override System.Collections.ObjectModel.ReadOnlyCollection<System.IdentityModel.Tokens.SecurityKey> SecurityKeys { get { throw null; } }
        public override System.DateTime ValidFrom { get { throw null; } }
        public override System.DateTime ValidTo { get { throw null; } }
        public byte[] GetKeyBytes() { throw null; }
    }
    [System.Runtime.CompilerServices.TypeForwardedFromAttribute("System.ServiceModel, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089")]
    public partial class WrappedKeySecurityToken : System.IdentityModel.Tokens.SecurityToken
    {
        public WrappedKeySecurityToken(string id, byte[] keyToWrap, string wrappingAlgorithm, System.IdentityModel.Tokens.SecurityToken wrappingToken, System.IdentityModel.Tokens.SecurityKeyIdentifier wrappingTokenReference) { }
        public override string Id { get { throw null; } }
        public override System.Collections.ObjectModel.ReadOnlyCollection<System.IdentityModel.Tokens.SecurityKey> SecurityKeys { get { throw null; } }
        public override System.DateTime ValidFrom { get { throw null; } }
        public override System.DateTime ValidTo { get { throw null; } }
        public string WrappingAlgorithm { get { throw null; } }
        public System.IdentityModel.Tokens.SecurityToken WrappingToken { get { throw null; } }
        public System.IdentityModel.Tokens.SecurityKeyIdentifier WrappingTokenReference { get { throw null; } }
        public override bool CanCreateKeyIdentifierClause<T>() { throw null; }
        public override T CreateKeyIdentifierClause<T>() { throw null; }
        public byte[] GetWrappedKey() { throw null; }
        public override bool MatchesKeyIdentifierClause(System.IdentityModel.Tokens.SecurityKeyIdentifierClause keyIdentifierClause) { throw null; }
    }
}
