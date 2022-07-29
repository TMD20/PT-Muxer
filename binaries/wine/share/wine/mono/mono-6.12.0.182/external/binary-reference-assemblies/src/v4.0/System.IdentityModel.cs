// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

[assembly:System.Reflection.AssemblyVersionAttribute("4.0.0.0")]
[assembly:System.CLSCompliantAttribute(true)]
[assembly:System.Reflection.AssemblyCompanyAttribute("Mono development team")]
[assembly:System.Reflection.AssemblyCopyrightAttribute("(c) Various Mono authors")]
[assembly:System.Reflection.AssemblyDefaultAliasAttribute("System.IdentityModel.dll")]
[assembly:System.Reflection.AssemblyDescriptionAttribute("System.IdentityModel.dll")]
[assembly:System.Reflection.AssemblyFileVersionAttribute("4.0.30319.1")]
[assembly:System.Reflection.AssemblyInformationalVersionAttribute("4.0.30319.1")]
[assembly:System.Reflection.AssemblyProductAttribute("Mono Common Language Infrastructure")]
[assembly:System.Reflection.AssemblyTitleAttribute("System.IdentityModel.dll")]
[assembly:System.Resources.NeutralResourcesLanguageAttribute("en-US")]
[assembly:System.Resources.SatelliteContractVersionAttribute("4.0.0.0")]
[assembly:System.Runtime.CompilerServices.ReferenceAssemblyAttribute]
[assembly:System.Runtime.CompilerServices.RuntimeCompatibilityAttribute(WrapNonExceptionThrows=true)]
[assembly:System.Runtime.InteropServices.ComCompatibleVersionAttribute(1, 0, 3300, 0)]
[assembly:System.Runtime.InteropServices.ComVisibleAttribute(false)]
[assembly:System.Security.AllowPartiallyTrustedCallersAttribute]
[assembly:System.Security.SecurityCriticalAttribute((System.Security.SecurityCriticalScope)(0))]
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
        [System.MonoTODOAttribute]
        public static System.IdentityModel.Claims.Claim CreateDenyOnlyWindowsSidClaim(System.Security.Principal.SecurityIdentifier identifier) { throw null; }
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
        [System.MonoTODOAttribute]
        public static System.IdentityModel.Claims.ClaimSet Windows { get { throw null; } }
        public virtual bool ContainsClaim(System.IdentityModel.Claims.Claim claim) { throw null; }
        public virtual bool ContainsClaim(System.IdentityModel.Claims.Claim claim, System.Collections.Generic.IEqualityComparer<System.IdentityModel.Claims.Claim> comparer) { throw null; }
        public abstract System.Collections.Generic.IEnumerable<System.IdentityModel.Claims.Claim> FindClaims(string resourceType, string right);
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
        [System.MonoTODOAttribute]
        public override string ToString() { throw null; }
    }
    public static partial class Rights
    {
        public static string Identity { get { throw null; } }
        public static string PossessProperty { get { throw null; } }
    }
    public partial class WindowsClaimSet : System.IdentityModel.Claims.ClaimSet, System.IDisposable
    {
        [System.MonoTODOAttribute]
        public WindowsClaimSet(System.Security.Principal.WindowsIdentity identity) { }
        [System.MonoTODOAttribute]
        public WindowsClaimSet(System.Security.Principal.WindowsIdentity identity, bool includeWindowsGroups) { }
        [System.MonoTODOAttribute]
        public WindowsClaimSet(System.Security.Principal.WindowsIdentity identity, bool includeWindowsGroups, System.DateTime expirationTime) { }
        [System.MonoTODOAttribute]
        public WindowsClaimSet(System.Security.Principal.WindowsIdentity identity, System.DateTime expirationTime) { }
        public override int Count { get { throw null; } }
        public System.DateTime ExpirationTime { get { throw null; } }
        public override System.IdentityModel.Claims.ClaimSet Issuer { get { throw null; } }
        public override System.IdentityModel.Claims.Claim this[int index] { get { throw null; } }
        public System.Security.Principal.WindowsIdentity WindowsIdentity { get { throw null; } }
        [System.MonoTODOAttribute]
        public void Dispose() { }
        [System.MonoTODOAttribute]
        public override System.Collections.Generic.IEnumerable<System.IdentityModel.Claims.Claim> FindClaims(string claimType, string right) { throw null; }
        [System.MonoTODOAttribute]
        public override System.Collections.Generic.IEnumerator<System.IdentityModel.Claims.Claim> GetEnumerator() { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class X509CertificateClaimSet : System.IdentityModel.Claims.ClaimSet, System.IDisposable
    {
        public X509CertificateClaimSet(System.Security.Cryptography.X509Certificates.X509Certificate2 certificate) { }
        public override int Count { get { throw null; } }
        [System.MonoTODOAttribute("use ParseExact")]
        public System.DateTime ExpirationTime { get { throw null; } }
        public override System.IdentityModel.Claims.ClaimSet Issuer { get { throw null; } }
        public override System.IdentityModel.Claims.Claim this[int index] { get { throw null; } }
        public System.Security.Cryptography.X509Certificates.X509Certificate2 X509Certificate { get { throw null; } }
        [System.MonoTODOAttribute]
        public void Dispose() { }
        [System.MonoTODOAttribute]
        public override System.Collections.Generic.IEnumerable<System.IdentityModel.Claims.Claim> FindClaims(string claimType, string right) { throw null; }
        public override System.Collections.Generic.IEnumerator<System.IdentityModel.Claims.Claim> GetEnumerator() { throw null; }
        [System.MonoTODOAttribute]
        public override string ToString() { throw null; }
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
        [System.MonoTODOAttribute]
        public static System.IdentityModel.Policy.AuthorizationContext CreateDefaultAuthorizationContext(System.Collections.Generic.IList<System.IdentityModel.Policy.IAuthorizationPolicy> policies) { throw null; }
    }
    public abstract partial class EvaluationContext
    {
        protected EvaluationContext() { }
        public abstract System.Collections.ObjectModel.ReadOnlyCollection<System.IdentityModel.Claims.ClaimSet> ClaimSets { get; }
        public abstract int Generation { get; }
        public abstract System.Collections.Generic.IDictionary<string, object> Properties { get; }
        public abstract void AddClaimSet(System.IdentityModel.Policy.IAuthorizationPolicy authorizationPolicy, System.IdentityModel.Claims.ClaimSet claimSet);
        public abstract void RecordExpirationTime(System.DateTime time);
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
namespace System.IdentityModel.Selectors
{
    public enum AudienceUriMode
    {
        Always = 1,
        BearerKeyOnly = 2,
        Never = 0,
    }
    public partial class CustomUserNameSecurityTokenAuthenticator : System.IdentityModel.Selectors.UserNameSecurityTokenAuthenticator
    {
        public CustomUserNameSecurityTokenAuthenticator(System.IdentityModel.Selectors.UserNamePasswordValidator validator) { }
        protected override System.Collections.ObjectModel.ReadOnlyCollection<System.IdentityModel.Policy.IAuthorizationPolicy> ValidateUserNamePasswordCore(string userName, string password) { throw null; }
    }
    public partial class KerberosSecurityTokenAuthenticator : System.IdentityModel.Selectors.WindowsSecurityTokenAuthenticator
    {
        [System.MonoTODOAttribute]
        public KerberosSecurityTokenAuthenticator() { }
        [System.MonoTODOAttribute]
        public KerberosSecurityTokenAuthenticator(bool includeWindowsGroups) { }
        [System.MonoTODOAttribute]
        protected override bool CanValidateTokenCore(System.IdentityModel.Tokens.SecurityToken token) { throw null; }
    }
    public partial class KerberosSecurityTokenProvider : System.IdentityModel.Selectors.SecurityTokenProvider
    {
        public KerberosSecurityTokenProvider(string servicePrincipalName) { }
        [System.MonoTODOAttribute]
        public KerberosSecurityTokenProvider(string servicePrincipalName, System.Security.Principal.TokenImpersonationLevel tokenImpersonationLevel) { }
        [System.MonoTODOAttribute]
        public KerberosSecurityTokenProvider(string servicePrincipalName, System.Security.Principal.TokenImpersonationLevel tokenImpersonationLevel, System.Net.NetworkCredential credential) { }
        public System.Net.NetworkCredential NetworkCredential { get { throw null; } }
        public string ServicePrincipalName { get { throw null; } }
        public System.Security.Principal.TokenImpersonationLevel TokenImpersonationLevel { get { throw null; } }
        [System.MonoTODOAttribute]
        protected override System.IdentityModel.Tokens.SecurityToken GetTokenCore(System.TimeSpan timeout) { throw null; }
    }
    public partial class RsaSecurityTokenAuthenticator : System.IdentityModel.Selectors.SecurityTokenAuthenticator
    {
        public RsaSecurityTokenAuthenticator() { }
        protected override bool CanValidateTokenCore(System.IdentityModel.Tokens.SecurityToken token) { throw null; }
        [System.MonoTODOAttribute("hmm, what to validate?")]
        protected override System.Collections.ObjectModel.ReadOnlyCollection<System.IdentityModel.Policy.IAuthorizationPolicy> ValidateTokenCore(System.IdentityModel.Tokens.SecurityToken token) { throw null; }
    }
    public partial class SamlSecurityTokenAuthenticator : System.IdentityModel.Selectors.SecurityTokenAuthenticator
    {
        public SamlSecurityTokenAuthenticator(System.Collections.Generic.IList<System.IdentityModel.Selectors.SecurityTokenAuthenticator> supportingAuthenticators) { }
        public SamlSecurityTokenAuthenticator(System.Collections.Generic.IList<System.IdentityModel.Selectors.SecurityTokenAuthenticator> supportingAuthenticators, System.TimeSpan maxClockSkew) { }
        protected override bool CanValidateTokenCore(System.IdentityModel.Tokens.SecurityToken token) { throw null; }
        [System.MonoTODOAttribute]
        public virtual System.IdentityModel.Claims.ClaimSet ResolveClaimSet(System.IdentityModel.Tokens.SecurityKeyIdentifier keyIdentifier) { throw null; }
        public virtual System.IdentityModel.Claims.ClaimSet ResolveClaimSet(System.IdentityModel.Tokens.SecurityToken token) { throw null; }
        [System.MonoTODOAttribute]
        public virtual System.Security.Principal.IIdentity ResolveIdentity(System.IdentityModel.Tokens.SecurityKeyIdentifier keyIdentifier) { throw null; }
        public virtual System.Security.Principal.IIdentity ResolveIdentity(System.IdentityModel.Tokens.SecurityToken token) { throw null; }
        [System.MonoTODOAttribute]
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
        public abstract System.IdentityModel.Selectors.SecurityTokenAuthenticator CreateSecurityTokenAuthenticator(System.IdentityModel.Selectors.SecurityTokenRequirement requirement, out System.IdentityModel.Selectors.SecurityTokenResolver resolver);
        public abstract System.IdentityModel.Selectors.SecurityTokenProvider CreateSecurityTokenProvider(System.IdentityModel.Selectors.SecurityTokenRequirement requirement);
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
        [System.MonoTODOAttribute]
        protected virtual System.IAsyncResult BeginGetTokenCore(System.TimeSpan timeout, System.AsyncCallback callback, object state) { throw null; }
        public System.IAsyncResult BeginRenewToken(System.TimeSpan timeout, System.IdentityModel.Tokens.SecurityToken token, System.AsyncCallback callback, object state) { throw null; }
        protected virtual System.IAsyncResult BeginRenewTokenCore(System.TimeSpan timeout, System.IdentityModel.Tokens.SecurityToken token, System.AsyncCallback callback, object state) { throw null; }
        public void CancelToken(System.TimeSpan timeout, System.IdentityModel.Tokens.SecurityToken token) { }
        protected virtual void CancelTokenCore(System.TimeSpan timeout, System.IdentityModel.Tokens.SecurityToken token) { }
        public void EndCancelToken(System.IAsyncResult result) { }
        protected virtual void EndCancelTokenCore(System.IAsyncResult result) { }
        public System.IdentityModel.Tokens.SecurityToken EndGetToken(System.IAsyncResult result) { throw null; }
        [System.MonoTODOAttribute]
        protected virtual System.IdentityModel.Tokens.SecurityToken EndGetTokenCore(System.IAsyncResult result) { throw null; }
        public System.IdentityModel.Tokens.SecurityToken EndRenewToken(System.IAsyncResult result) { throw null; }
        protected virtual System.IdentityModel.Tokens.SecurityToken EndRenewTokenCore(System.IAsyncResult result) { throw null; }
        public System.IdentityModel.Tokens.SecurityToken GetToken(System.TimeSpan timeout) { throw null; }
        protected abstract System.IdentityModel.Tokens.SecurityToken GetTokenCore(System.TimeSpan timeout);
        public System.IdentityModel.Tokens.SecurityToken RenewToken(System.TimeSpan timeout, System.IdentityModel.Tokens.SecurityToken token) { throw null; }
        protected virtual System.IdentityModel.Tokens.SecurityToken RenewTokenCore(System.TimeSpan timeout, System.IdentityModel.Tokens.SecurityToken token) { throw null; }
    }
    public partial class SecurityTokenRequirement
    {
        public SecurityTokenRequirement() { }
        public int KeySize { get { throw null; } set { } }
        public static string KeySizeProperty { get { throw null; } }
        public System.IdentityModel.Tokens.SecurityKeyType KeyType { get { throw null; } set { } }
        public static string KeyTypeProperty { get { throw null; } }
        public System.IdentityModel.Tokens.SecurityKeyUsage KeyUsage { get { throw null; } set { } }
        public static string KeyUsageProperty { get { throw null; } }
        public System.Collections.Generic.IDictionary<string, object> Properties { get { throw null; } }
        public bool RequireCryptographicToken { get { throw null; } set { } }
        public static string RequireCryptographicTokenProperty { get { throw null; } }
        public string TokenType { get { throw null; } set { } }
        public static string TokenTypeProperty { get { throw null; } }
        public TValue GetProperty<TValue>(string property) { throw null; }
        public bool TryGetProperty<TValue>(string property, out TValue value) { value = default(TValue); throw null; }
    }
    public abstract partial class SecurityTokenResolver
    {
        protected SecurityTokenResolver() { }
        public static System.IdentityModel.Selectors.SecurityTokenResolver CreateDefaultSecurityTokenResolver(System.Collections.ObjectModel.ReadOnlyCollection<System.IdentityModel.Tokens.SecurityToken> tokens, bool canMatchLocalId) { throw null; }
        public System.IdentityModel.Tokens.SecurityKey ResolveSecurityKey(System.IdentityModel.Tokens.SecurityKeyIdentifierClause keyIdentifierClause) { throw null; }
        public System.IdentityModel.Tokens.SecurityToken ResolveToken(System.IdentityModel.Tokens.SecurityKeyIdentifier keyIdentifier) { throw null; }
        public System.IdentityModel.Tokens.SecurityToken ResolveToken(System.IdentityModel.Tokens.SecurityKeyIdentifierClause keyIdentifierClause) { throw null; }
        public bool TryResolveSecurityKey(System.IdentityModel.Tokens.SecurityKeyIdentifierClause keyIdentifierClause, out System.IdentityModel.Tokens.SecurityKey key) { key = default(System.IdentityModel.Tokens.SecurityKey); throw null; }
        protected abstract bool TryResolveSecurityKeyCore(System.IdentityModel.Tokens.SecurityKeyIdentifierClause keyIdentifierClause, out System.IdentityModel.Tokens.SecurityKey key);
        public bool TryResolveToken(System.IdentityModel.Tokens.SecurityKeyIdentifier keyIdentifier, out System.IdentityModel.Tokens.SecurityToken token) { token = default(System.IdentityModel.Tokens.SecurityToken); throw null; }
        public bool TryResolveToken(System.IdentityModel.Tokens.SecurityKeyIdentifierClause keyIdentifierClause, out System.IdentityModel.Tokens.SecurityToken token) { token = default(System.IdentityModel.Tokens.SecurityToken); throw null; }
        protected abstract bool TryResolveTokenCore(System.IdentityModel.Tokens.SecurityKeyIdentifier keyIdentifier, out System.IdentityModel.Tokens.SecurityToken token);
        protected abstract bool TryResolveTokenCore(System.IdentityModel.Tokens.SecurityKeyIdentifierClause keyIdentifierClause, out System.IdentityModel.Tokens.SecurityToken token);
    }
    public abstract partial class SecurityTokenSerializer
    {
        protected SecurityTokenSerializer() { }
        [System.MonoTODOAttribute]
        public bool CanReadKeyIdentifier(System.Xml.XmlReader reader) { throw null; }
        [System.MonoTODOAttribute]
        public bool CanReadKeyIdentifierClause(System.Xml.XmlReader reader) { throw null; }
        protected abstract bool CanReadKeyIdentifierClauseCore(System.Xml.XmlReader reader);
        protected abstract bool CanReadKeyIdentifierCore(System.Xml.XmlReader reader);
        [System.MonoTODOAttribute]
        public bool CanReadToken(System.Xml.XmlReader reader) { throw null; }
        protected abstract bool CanReadTokenCore(System.Xml.XmlReader reader);
        [System.MonoTODOAttribute]
        public bool CanWriteKeyIdentifier(System.IdentityModel.Tokens.SecurityKeyIdentifier keyIdentifier) { throw null; }
        [System.MonoTODOAttribute]
        public bool CanWriteKeyIdentifierClause(System.IdentityModel.Tokens.SecurityKeyIdentifierClause keyIdentifierClause) { throw null; }
        protected abstract bool CanWriteKeyIdentifierClauseCore(System.IdentityModel.Tokens.SecurityKeyIdentifierClause keyIdentifierClause);
        protected abstract bool CanWriteKeyIdentifierCore(System.IdentityModel.Tokens.SecurityKeyIdentifier keyIdentifier);
        [System.MonoTODOAttribute]
        public bool CanWriteToken(System.IdentityModel.Tokens.SecurityToken token) { throw null; }
        protected abstract bool CanWriteTokenCore(System.IdentityModel.Tokens.SecurityToken token);
        [System.MonoTODOAttribute]
        public System.IdentityModel.Tokens.SecurityKeyIdentifier ReadKeyIdentifier(System.Xml.XmlReader reader) { throw null; }
        [System.MonoTODOAttribute]
        public System.IdentityModel.Tokens.SecurityKeyIdentifierClause ReadKeyIdentifierClause(System.Xml.XmlReader reader) { throw null; }
        protected abstract System.IdentityModel.Tokens.SecurityKeyIdentifierClause ReadKeyIdentifierClauseCore(System.Xml.XmlReader reader);
        protected abstract System.IdentityModel.Tokens.SecurityKeyIdentifier ReadKeyIdentifierCore(System.Xml.XmlReader reader);
        [System.MonoTODOAttribute]
        public System.IdentityModel.Tokens.SecurityToken ReadToken(System.Xml.XmlReader reader, System.IdentityModel.Selectors.SecurityTokenResolver tokenResolver) { throw null; }
        protected abstract System.IdentityModel.Tokens.SecurityToken ReadTokenCore(System.Xml.XmlReader reader, System.IdentityModel.Selectors.SecurityTokenResolver tokenResolver);
        [System.MonoTODOAttribute]
        public void WriteKeyIdentifier(System.Xml.XmlWriter writer, System.IdentityModel.Tokens.SecurityKeyIdentifier keyIdentifier) { }
        [System.MonoTODOAttribute]
        public void WriteKeyIdentifierClause(System.Xml.XmlWriter writer, System.IdentityModel.Tokens.SecurityKeyIdentifierClause keyIdentifierClause) { }
        protected abstract void WriteKeyIdentifierClauseCore(System.Xml.XmlWriter writer, System.IdentityModel.Tokens.SecurityKeyIdentifierClause keyIdentifierClause);
        protected abstract void WriteKeyIdentifierCore(System.Xml.XmlWriter writer, System.IdentityModel.Tokens.SecurityKeyIdentifier keyIdentifier);
        [System.MonoTODOAttribute]
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
        [System.MonoTODOAttribute]
        public WindowsSecurityTokenAuthenticator() { }
        [System.MonoTODOAttribute]
        public WindowsSecurityTokenAuthenticator(bool includeWindowsGroups) { }
        [System.MonoTODOAttribute]
        protected override bool CanValidateTokenCore(System.IdentityModel.Tokens.SecurityToken token) { throw null; }
        [System.MonoTODOAttribute]
        protected override System.Collections.ObjectModel.ReadOnlyCollection<System.IdentityModel.Policy.IAuthorizationPolicy> ValidateTokenCore(System.IdentityModel.Tokens.SecurityToken token) { throw null; }
    }
    public partial class WindowsUserNameSecurityTokenAuthenticator : System.IdentityModel.Selectors.UserNameSecurityTokenAuthenticator
    {
        public WindowsUserNameSecurityTokenAuthenticator() { }
        public WindowsUserNameSecurityTokenAuthenticator(bool includeWindowsGroups) { }
        [System.MonoTODOAttribute]
        protected override System.Collections.ObjectModel.ReadOnlyCollection<System.IdentityModel.Policy.IAuthorizationPolicy> ValidateUserNamePasswordCore(string userName, string password) { throw null; }
    }
    public abstract partial class X509CertificateValidator
    {
        protected X509CertificateValidator() { }
        public static System.IdentityModel.Selectors.X509CertificateValidator ChainTrust { get { throw null; } }
        public static System.IdentityModel.Selectors.X509CertificateValidator None { get { throw null; } }
        public static System.IdentityModel.Selectors.X509CertificateValidator PeerOrChainTrust { get { throw null; } }
        public static System.IdentityModel.Selectors.X509CertificateValidator PeerTrust { get { throw null; } }
        public static System.IdentityModel.Selectors.X509CertificateValidator CreateChainTrustValidator(bool useMachineContext, System.Security.Cryptography.X509Certificates.X509ChainPolicy chainPolicy) { throw null; }
        public static System.IdentityModel.Selectors.X509CertificateValidator CreatePeerOrChainTrustValidator(bool useMachineContext, System.Security.Cryptography.X509Certificates.X509ChainPolicy chainPolicy) { throw null; }
        public abstract void Validate(System.Security.Cryptography.X509Certificates.X509Certificate2 certificate);
    }
    public partial class X509SecurityTokenAuthenticator : System.IdentityModel.Selectors.SecurityTokenAuthenticator
    {
        public X509SecurityTokenAuthenticator() { }
        public X509SecurityTokenAuthenticator(System.IdentityModel.Selectors.X509CertificateValidator validator) { }
        public X509SecurityTokenAuthenticator(System.IdentityModel.Selectors.X509CertificateValidator validator, bool mapToWindows) { }
        public X509SecurityTokenAuthenticator(System.IdentityModel.Selectors.X509CertificateValidator validator, bool mapToWindows, bool includeWindowsGroups) { }
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
    public abstract partial class AsymmetricSecurityKey : System.IdentityModel.Tokens.SecurityKey
    {
        protected AsymmetricSecurityKey() { }
        public abstract System.Security.Cryptography.AsymmetricAlgorithm GetAsymmetricAlgorithm(string algorithm, bool privateKey);
        public abstract System.Security.Cryptography.HashAlgorithm GetHashAlgorithmForSignature(string algorithm);
        public abstract System.Security.Cryptography.AsymmetricSignatureDeformatter GetSignatureDeformatter(string algorithm);
        public abstract System.Security.Cryptography.AsymmetricSignatureFormatter GetSignatureFormatter(string algorithm);
        public abstract bool HasPrivateKey();
    }
    public abstract partial class BinaryKeyIdentifierClause : System.IdentityModel.Tokens.SecurityKeyIdentifierClause
    {
        protected BinaryKeyIdentifierClause(string clauseType, byte[] identificationData, bool cloneBuffer) : base (default(string)) { }
        protected BinaryKeyIdentifierClause(string clauseType, byte[] identificationData, bool cloneBuffer, byte[] derivationNonce, int derivationLength) : base (default(string)) { }
        public byte[] GetBuffer() { throw null; }
        protected byte[] GetRawBuffer() { throw null; }
        public bool Matches(byte[] data) { throw null; }
        public bool Matches(byte[] data, int offset) { throw null; }
        public override bool Matches(System.IdentityModel.Tokens.SecurityKeyIdentifierClause clause) { throw null; }
    }
    public sealed partial class EncryptedKeyIdentifierClause : System.IdentityModel.Tokens.BinaryKeyIdentifierClause
    {
        public EncryptedKeyIdentifierClause(byte[] encryptedKey, string encryptionMethod) : base (default(string), default(byte[]), default(bool)) { }
        public EncryptedKeyIdentifierClause(byte[] encryptedKey, string encryptionMethod, System.IdentityModel.Tokens.SecurityKeyIdentifier identifier) : base (default(string), default(byte[]), default(bool)) { }
        public EncryptedKeyIdentifierClause(byte[] encryptedKey, string encryptionMethod, System.IdentityModel.Tokens.SecurityKeyIdentifier identifier, string carriedKeyName) : base (default(string), default(byte[]), default(bool)) { }
        public EncryptedKeyIdentifierClause(byte[] encryptedKey, string encryptionMethod, System.IdentityModel.Tokens.SecurityKeyIdentifier identifier, string carriedKeyName, byte[] derivationNonce, int derivationLength) : base (default(string), default(byte[]), default(bool)) { }
        public string CarriedKeyName { get { throw null; } }
        public System.IdentityModel.Tokens.SecurityKeyIdentifier EncryptingKeyIdentifier { get { throw null; } }
        public string EncryptionMethod { get { throw null; } }
        public byte[] GetEncryptedKey() { throw null; }
        public bool Matches(byte[] encryptedKey, string encryptionMethod, string carriedKeyName) { throw null; }
        public override bool Matches(System.IdentityModel.Tokens.SecurityKeyIdentifierClause clause) { throw null; }
        [System.MonoTODOAttribute]
        public override string ToString() { throw null; }
    }
    public partial class GenericXmlSecurityToken : System.IdentityModel.Tokens.SecurityToken
    {
        public GenericXmlSecurityToken(System.Xml.XmlElement tokenXml, System.IdentityModel.Tokens.SecurityToken proofToken, System.DateTime effectiveTime, System.DateTime expirationTime, System.IdentityModel.Tokens.SecurityKeyIdentifierClause internalTokenReference, System.IdentityModel.Tokens.SecurityKeyIdentifierClause externalTokenReference, System.Collections.ObjectModel.ReadOnlyCollection<System.IdentityModel.Policy.IAuthorizationPolicy> authorizationPolicies) { }
        public System.Collections.ObjectModel.ReadOnlyCollection<System.IdentityModel.Policy.IAuthorizationPolicy> AuthorizationPolicies { get { throw null; } }
        public System.IdentityModel.Tokens.SecurityKeyIdentifierClause ExternalTokenReference { get { throw null; } }
        [System.MonoTODOAttribute]
        public override string Id { get { throw null; } }
        public System.IdentityModel.Tokens.SecurityKeyIdentifierClause InternalTokenReference { get { throw null; } }
        public System.IdentityModel.Tokens.SecurityToken ProofToken { get { throw null; } }
        [System.MonoTODOAttribute]
        public override System.Collections.ObjectModel.ReadOnlyCollection<System.IdentityModel.Tokens.SecurityKey> SecurityKeys { get { throw null; } }
        public System.Xml.XmlElement TokenXml { get { throw null; } }
        public override System.DateTime ValidFrom { get { throw null; } }
        public override System.DateTime ValidTo { get { throw null; } }
        [System.MonoTODOAttribute]
        public override bool CanCreateKeyIdentifierClause<T>() { throw null; }
        [System.MonoTODOAttribute]
        public override T CreateKeyIdentifierClause<T>() { throw null; }
        [System.MonoTODOAttribute]
        public override bool MatchesKeyIdentifierClause(System.IdentityModel.Tokens.SecurityKeyIdentifierClause skiClause) { throw null; }
    }
    public partial class InMemorySymmetricSecurityKey : System.IdentityModel.Tokens.SymmetricSecurityKey
    {
        public InMemorySymmetricSecurityKey(byte[] key) { }
        public InMemorySymmetricSecurityKey(byte[] key, bool clone) { }
        public override int KeySize { get { throw null; } }
        public override byte[] DecryptKey(string algorithm, byte[] keyData) { throw null; }
        public override byte[] EncryptKey(string algorithm, byte[] keyData) { throw null; }
        public override byte[] GenerateDerivedKey(string algorithm, byte[] label, byte[] nonce, int derivedKeyLength, int offset) { throw null; }
        public override System.Security.Cryptography.ICryptoTransform GetDecryptionTransform(string algorithm, byte[] iv) { throw null; }
        public override System.Security.Cryptography.ICryptoTransform GetEncryptionTransform(string algorithm, byte[] iv) { throw null; }
        [System.MonoTODOAttribute]
        public override int GetIVSize(string algorithm) { throw null; }
        public override System.Security.Cryptography.KeyedHashAlgorithm GetKeyedHashAlgorithm(string algorithm) { throw null; }
        public override System.Security.Cryptography.SymmetricAlgorithm GetSymmetricAlgorithm(string algorithm) { throw null; }
        public override byte[] GetSymmetricKey() { throw null; }
        public override bool IsAsymmetricAlgorithm(string algorithm) { throw null; }
        public override bool IsSupportedAlgorithm(string algorithm) { throw null; }
        public override bool IsSymmetricAlgorithm(string algorithm) { throw null; }
    }
    public partial class KerberosReceiverSecurityToken : System.IdentityModel.Tokens.WindowsSecurityToken
    {
        [System.MonoTODOAttribute]
        public KerberosReceiverSecurityToken(byte[] request) { }
        [System.MonoTODOAttribute]
        public KerberosReceiverSecurityToken(byte[] request, string id) { }
        [System.MonoTODOAttribute]
        public System.IdentityModel.Tokens.SymmetricSecurityKey SecurityKey { get { throw null; } }
        [System.MonoTODOAttribute]
        public override System.Collections.ObjectModel.ReadOnlyCollection<System.IdentityModel.Tokens.SecurityKey> SecurityKeys { get { throw null; } }
        [System.MonoTODOAttribute]
        public override bool CanCreateKeyIdentifierClause<T>() { throw null; }
        [System.MonoTODOAttribute]
        public override T CreateKeyIdentifierClause<T>() { throw null; }
        [System.MonoTODOAttribute]
        public byte[] GetRequest() { throw null; }
        [System.MonoTODOAttribute]
        public override bool MatchesKeyIdentifierClause(System.IdentityModel.Tokens.SecurityKeyIdentifierClause skiClause) { throw null; }
    }
    public partial class KerberosRequestorSecurityToken : System.IdentityModel.Tokens.SecurityToken
    {
        [System.MonoTODOAttribute]
        public KerberosRequestorSecurityToken(string servicePrincipalName) { }
        [System.MonoTODOAttribute]
        public KerberosRequestorSecurityToken(string servicePrincipalName, System.Security.Principal.TokenImpersonationLevel tokenImpersonationLevel, System.Net.NetworkCredential networkCredential, string id) { }
        public override string Id { get { throw null; } }
        [System.MonoTODOAttribute]
        public System.IdentityModel.Tokens.SymmetricSecurityKey SecurityKey { get { throw null; } }
        [System.MonoTODOAttribute]
        public override System.Collections.ObjectModel.ReadOnlyCollection<System.IdentityModel.Tokens.SecurityKey> SecurityKeys { get { throw null; } }
        public string ServicePrincipalName { get { throw null; } }
        [System.MonoTODOAttribute]
        public override System.DateTime ValidFrom { get { throw null; } }
        [System.MonoTODOAttribute]
        public override System.DateTime ValidTo { get { throw null; } }
        [System.MonoTODOAttribute]
        public override bool CanCreateKeyIdentifierClause<T>() { throw null; }
        [System.MonoTODOAttribute]
        public override T CreateKeyIdentifierClause<T>() { throw null; }
        [System.MonoTODOAttribute]
        public byte[] GetRequest() { throw null; }
        [System.MonoTODOAttribute]
        public override bool MatchesKeyIdentifierClause(System.IdentityModel.Tokens.SecurityKeyIdentifierClause skiClause) { throw null; }
    }
    public partial class LocalIdKeyIdentifierClause : System.IdentityModel.Tokens.SecurityKeyIdentifierClause
    {
        public LocalIdKeyIdentifierClause(string localId) : base (default(string)) { }
        public LocalIdKeyIdentifierClause(string localId, byte[] derivationNonce, int derivationLength, System.Type ownerType) : base (default(string)) { }
        public LocalIdKeyIdentifierClause(string localId, System.Type ownerType) : base (default(string)) { }
        public string LocalId { get { throw null; } }
        public System.Type OwnerType { get { throw null; } }
        public override bool Matches(System.IdentityModel.Tokens.SecurityKeyIdentifierClause clause) { throw null; }
        public bool Matches(string localId, System.Type ownerType) { throw null; }
        [System.MonoTODOAttribute]
        public override string ToString() { throw null; }
    }
    public partial class RsaKeyIdentifierClause : System.IdentityModel.Tokens.SecurityKeyIdentifierClause
    {
        public RsaKeyIdentifierClause(System.Security.Cryptography.RSA rsa) : base (default(string)) { }
        public override bool CanCreateKey { get { throw null; } }
        public System.Security.Cryptography.RSA Rsa { get { throw null; } }
        public override System.IdentityModel.Tokens.SecurityKey CreateKey() { throw null; }
        public byte[] GetExponent() { throw null; }
        public byte[] GetModulus() { throw null; }
        public override bool Matches(System.IdentityModel.Tokens.SecurityKeyIdentifierClause clause) { throw null; }
        public bool Matches(System.Security.Cryptography.RSA rsa) { throw null; }
        [System.MonoTODOAttribute]
        public override string ToString() { throw null; }
        [System.MonoTODOAttribute]
        public void WriteExponentAsBase64(System.Xml.XmlWriter writer) { }
        [System.MonoTODOAttribute]
        public void WriteModulusAsBase64(System.Xml.XmlWriter writer) { }
    }
    public sealed partial class RsaSecurityKey : System.IdentityModel.Tokens.AsymmetricSecurityKey
    {
        public RsaSecurityKey(System.Security.Cryptography.RSA rsa) { }
        public override int KeySize { get { throw null; } }
        [System.MonoTODOAttribute]
        public override byte[] DecryptKey(string algorithm, byte[] keyData) { throw null; }
        [System.MonoTODOAttribute]
        public override byte[] EncryptKey(string algorithm, byte[] keyData) { throw null; }
        [System.MonoTODOAttribute]
        public override System.Security.Cryptography.AsymmetricAlgorithm GetAsymmetricAlgorithm(string algorithm, bool privateKey) { throw null; }
        [System.MonoTODOAttribute]
        public override System.Security.Cryptography.HashAlgorithm GetHashAlgorithmForSignature(string algorithm) { throw null; }
        [System.MonoTODOAttribute]
        public override System.Security.Cryptography.AsymmetricSignatureDeformatter GetSignatureDeformatter(string algorithm) { throw null; }
        [System.MonoTODOAttribute]
        public override System.Security.Cryptography.AsymmetricSignatureFormatter GetSignatureFormatter(string algorithm) { throw null; }
        public override bool HasPrivateKey() { throw null; }
        [System.MonoTODOAttribute]
        public override bool IsAsymmetricAlgorithm(string algorithm) { throw null; }
        [System.MonoTODOAttribute]
        public override bool IsSupportedAlgorithm(string algorithm) { throw null; }
        [System.MonoTODOAttribute]
        public override bool IsSymmetricAlgorithm(string algorithm) { throw null; }
    }
    public partial class RsaSecurityToken : System.IdentityModel.Tokens.SecurityToken
    {
        public RsaSecurityToken(System.Security.Cryptography.RSA rsa) { }
        public RsaSecurityToken(System.Security.Cryptography.RSA rsa, string id) { }
        public override string Id { get { throw null; } }
        public System.Security.Cryptography.RSA Rsa { get { throw null; } }
        [System.MonoTODOAttribute]
        public override System.Collections.ObjectModel.ReadOnlyCollection<System.IdentityModel.Tokens.SecurityKey> SecurityKeys { get { throw null; } }
        public override System.DateTime ValidFrom { get { throw null; } }
        public override System.DateTime ValidTo { get { throw null; } }
        [System.MonoTODOAttribute]
        public override bool CanCreateKeyIdentifierClause<T>() { throw null; }
        [System.MonoTODOAttribute]
        public override T CreateKeyIdentifierClause<T>() { throw null; }
        [System.MonoTODOAttribute]
        public override bool MatchesKeyIdentifierClause(System.IdentityModel.Tokens.SecurityKeyIdentifierClause skiClause) { throw null; }
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
        public virtual void ReadXml(System.Xml.XmlDictionaryReader reader, System.IdentityModel.Tokens.SamlSerializer samlSerializer, System.IdentityModel.Selectors.SecurityTokenSerializer keyInfoTokenSerializer, System.IdentityModel.Selectors.SecurityTokenResolver outOfBandTokenResolver) { }
        public virtual void WriteXml(System.Xml.XmlDictionaryWriter writer, System.IdentityModel.Tokens.SamlSerializer samlSerializer, System.IdentityModel.Selectors.SecurityTokenSerializer keyInfoTokenSerializer) { }
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
        public virtual void ReadXml(System.Xml.XmlDictionaryReader reader, System.IdentityModel.Tokens.SamlSerializer samlSerializer, System.IdentityModel.Selectors.SecurityTokenSerializer keyInfoTokenSerializer, System.IdentityModel.Selectors.SecurityTokenResolver outOfBandTokenResolver) { }
        public virtual void WriteXml(System.Xml.XmlDictionaryWriter writer, System.IdentityModel.Tokens.SamlSerializer samlSerializer, System.IdentityModel.Selectors.SecurityTokenSerializer keyInfoTokenSerializer) { }
    }
    public partial class SamlAssertion
    {
        public SamlAssertion() { }
        public SamlAssertion(string assertionId, string issuer, System.DateTime issueInstant, System.IdentityModel.Tokens.SamlConditions conditions, System.IdentityModel.Tokens.SamlAdvice advice, System.Collections.Generic.IEnumerable<System.IdentityModel.Tokens.SamlStatement> statements) { }
        public System.IdentityModel.Tokens.SamlAdvice Advice { get { throw null; } set { } }
        public string AssertionId { get { throw null; } set { } }
        public System.IdentityModel.Tokens.SamlConditions Conditions { get { throw null; } set { } }
        public bool IsReadOnly { get { throw null; } }
        public System.DateTime IssueInstant { get { throw null; } set { } }
        public string Issuer { get { throw null; } set { } }
        public int MajorVersion { get { throw null; } }
        public int MinorVersion { get { throw null; } }
        public System.IdentityModel.Tokens.SigningCredentials SigningCredentials { get { throw null; } set { } }
        [System.MonoTODOAttribute]
        public System.IdentityModel.Tokens.SecurityToken SigningToken { get { throw null; } }
        public System.Collections.Generic.IList<System.IdentityModel.Tokens.SamlStatement> Statements { get { throw null; } }
        public void MakeReadOnly() { }
        [System.MonoTODOAttribute]
        protected void ReadSignature(System.Xml.XmlDictionaryReader reader, System.IdentityModel.Selectors.SecurityTokenSerializer keyInfoTokenSerializer, System.IdentityModel.Selectors.SecurityTokenResolver outOfBandTokenResolver, System.IdentityModel.Tokens.SamlSerializer samlSerializer) { }
        [System.MonoTODOAttribute]
        public virtual void ReadXml(System.Xml.XmlDictionaryReader reader, System.IdentityModel.Tokens.SamlSerializer samlSerializer, System.IdentityModel.Selectors.SecurityTokenSerializer keyInfoTokenSerializer, System.IdentityModel.Selectors.SecurityTokenResolver outOfBandTokenResolver) { }
        public virtual void WriteXml(System.Xml.XmlDictionaryWriter writer, System.IdentityModel.Tokens.SamlSerializer samlSerializer, System.IdentityModel.Selectors.SecurityTokenSerializer keyInfoTokenSerializer) { }
    }
    public partial class SamlAssertionKeyIdentifierClause : System.IdentityModel.Tokens.SecurityKeyIdentifierClause
    {
        [System.MonoTODOAttribute]
        public SamlAssertionKeyIdentifierClause(string assertionId) : base (default(string)) { }
        public string AssertionId { get { throw null; } }
        [System.MonoTODOAttribute]
        public override bool Matches(System.IdentityModel.Tokens.SecurityKeyIdentifierClause clause) { throw null; }
        public bool Matches(string assertionId) { throw null; }
        [System.MonoTODOAttribute]
        public override string ToString() { throw null; }
    }
    public partial class SamlAttribute
    {
        public SamlAttribute() { }
        public SamlAttribute(System.IdentityModel.Claims.Claim claim) { }
        public SamlAttribute(string attributeNamespace, string attributeName, System.Collections.Generic.IEnumerable<string> attributeValues) { }
        public System.Collections.Generic.IList<string> AttributeValues { get { throw null; } }
        public bool IsReadOnly { get { throw null; } }
        public string Name { get { throw null; } set { } }
        public string Namespace { get { throw null; } set { } }
        [System.MonoTODOAttribute]
        public virtual System.Collections.ObjectModel.ReadOnlyCollection<System.IdentityModel.Claims.Claim> ExtractClaims() { throw null; }
        public void MakeReadOnly() { }
        [System.MonoTODOAttribute]
        public virtual void ReadXml(System.Xml.XmlDictionaryReader reader, System.IdentityModel.Tokens.SamlSerializer samlSerializer, System.IdentityModel.Selectors.SecurityTokenSerializer keyInfoTokenSerializer, System.IdentityModel.Selectors.SecurityTokenResolver outOfBandTokenResolver) { }
        public virtual void WriteXml(System.Xml.XmlDictionaryWriter writer, System.IdentityModel.Tokens.SamlSerializer samlSerializer, System.IdentityModel.Selectors.SecurityTokenSerializer keyInfoTokenSerializer) { }
    }
    public partial class SamlAttributeStatement : System.IdentityModel.Tokens.SamlSubjectStatement
    {
        public SamlAttributeStatement() { }
        public SamlAttributeStatement(System.IdentityModel.Tokens.SamlSubject samlSubject, System.Collections.Generic.IEnumerable<System.IdentityModel.Tokens.SamlAttribute> attributes) { }
        public System.Collections.Generic.IList<System.IdentityModel.Tokens.SamlAttribute> Attributes { get { throw null; } }
        public override bool IsReadOnly { get { throw null; } }
        [System.MonoTODOAttribute]
        protected override void AddClaimsToList(System.Collections.Generic.IList<System.IdentityModel.Claims.Claim> claims) { }
        public override void MakeReadOnly() { }
        [System.MonoTODOAttribute]
        public override void ReadXml(System.Xml.XmlDictionaryReader reader, System.IdentityModel.Tokens.SamlSerializer samlSerializer, System.IdentityModel.Selectors.SecurityTokenSerializer keyInfoTokenSerializer, System.IdentityModel.Selectors.SecurityTokenResolver outOfBandTokenResolver) { }
        public override void WriteXml(System.Xml.XmlDictionaryWriter writer, System.IdentityModel.Tokens.SamlSerializer samlSerializer, System.IdentityModel.Selectors.SecurityTokenSerializer keyInfoTokenSerializer) { }
    }
    public partial class SamlAudienceRestrictionCondition : System.IdentityModel.Tokens.SamlCondition
    {
        public SamlAudienceRestrictionCondition() { }
        public SamlAudienceRestrictionCondition(System.Collections.Generic.IEnumerable<System.Uri> audiences) { }
        public System.Collections.Generic.IList<System.Uri> Audiences { get { throw null; } }
        public override bool IsReadOnly { get { throw null; } }
        public override void MakeReadOnly() { }
        [System.MonoTODOAttribute]
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
        [System.MonoTODOAttribute]
        protected override void AddClaimsToList(System.Collections.Generic.IList<System.IdentityModel.Claims.Claim> claims) { }
        public override void MakeReadOnly() { }
        [System.MonoTODOAttribute]
        public override void ReadXml(System.Xml.XmlDictionaryReader reader, System.IdentityModel.Tokens.SamlSerializer samlSerializer, System.IdentityModel.Selectors.SecurityTokenSerializer keyInfoTokenSerializer, System.IdentityModel.Selectors.SecurityTokenResolver outOfBandTokenResolver) { }
        public override void WriteXml(System.Xml.XmlDictionaryWriter writer, System.IdentityModel.Tokens.SamlSerializer samlSerializer, System.IdentityModel.Selectors.SecurityTokenSerializer keyInfoTokenSerializer) { }
    }
    [System.Runtime.Serialization.DataContractAttribute]
    public partial class SamlAuthorityBinding
    {
        public SamlAuthorityBinding() { }
        public SamlAuthorityBinding(System.Xml.XmlQualifiedName kind, string binding, string location) { }
        [System.Runtime.Serialization.DataMemberAttribute]
        public System.Xml.XmlQualifiedName AuthorityKind { get { throw null; } set { } }
        [System.Runtime.Serialization.DataMemberAttribute]
        public string Binding { get { throw null; } set { } }
        public bool IsReadOnly { get { throw null; } }
        [System.Runtime.Serialization.DataMemberAttribute]
        public string Location { get { throw null; } set { } }
        public void MakeReadOnly() { }
        [System.MonoTODOAttribute]
        public virtual void ReadXml(System.Xml.XmlDictionaryReader reader, System.IdentityModel.Tokens.SamlSerializer samlSerializer, System.IdentityModel.Selectors.SecurityTokenSerializer keyInfoSerializer, System.IdentityModel.Selectors.SecurityTokenResolver outOfBandTokenResolver) { }
        public virtual void WriteXml(System.Xml.XmlDictionaryWriter writer, System.IdentityModel.Tokens.SamlSerializer samlSerializer, System.IdentityModel.Selectors.SecurityTokenSerializer keyInfoSerializer) { }
    }
    [System.Runtime.Serialization.DataContractAttribute]
    public partial class SamlAuthorizationDecisionClaimResource
    {
        public SamlAuthorizationDecisionClaimResource(string resource, System.IdentityModel.Tokens.SamlAccessDecision decision, string actionName, string actionNamespace) { }
        public System.IdentityModel.Tokens.SamlAccessDecision AccessDecision { get { throw null; } }
        public string ActionName { get { throw null; } }
        public string ActionNamespace { get { throw null; } }
        public string Resource { get { throw null; } }
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
        [System.MonoTODOAttribute]
        protected override void AddClaimsToList(System.Collections.Generic.IList<System.IdentityModel.Claims.Claim> claims) { }
        public override void MakeReadOnly() { }
        public override void ReadXml(System.Xml.XmlDictionaryReader reader, System.IdentityModel.Tokens.SamlSerializer samlSerializer, System.IdentityModel.Selectors.SecurityTokenSerializer keyInfoSerializer, System.IdentityModel.Selectors.SecurityTokenResolver resolver) { }
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
        [System.MonoTODOAttribute]
        public virtual void ReadXml(System.Xml.XmlDictionaryReader reader, System.IdentityModel.Tokens.SamlSerializer samlSerializer, System.IdentityModel.Selectors.SecurityTokenSerializer keyInfoTokenSerializer, System.IdentityModel.Selectors.SecurityTokenResolver outOfBandTokenResolver) { }
        public virtual void WriteXml(System.Xml.XmlDictionaryWriter writer, System.IdentityModel.Tokens.SamlSerializer samlSerializer, System.IdentityModel.Selectors.SecurityTokenSerializer keyInfoTokenSerializer) { }
    }
    public static partial class SamlConstants
    {
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
        [System.MonoTODOAttribute]
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
        public virtual void ReadXml(System.Xml.XmlDictionaryReader reader, System.IdentityModel.Tokens.SamlSerializer samlSerializer, System.IdentityModel.Selectors.SecurityTokenSerializer keyInfoSerializer, System.IdentityModel.Selectors.SecurityTokenResolver resolver) { }
        public virtual void WriteXml(System.Xml.XmlDictionaryWriter writer, System.IdentityModel.Tokens.SamlSerializer samlSerializer, System.IdentityModel.Selectors.SecurityTokenSerializer keyInfoSerializer) { }
    }
    [System.Runtime.Serialization.DataContractAttribute]
    public partial class SamlNameIdentifierClaimResource
    {
        public SamlNameIdentifierClaimResource(string name, string nameQualifier, string format) { }
        public string Format { get { throw null; } }
        public string Name { get { throw null; } }
        public string NameQualifier { get { throw null; } }
    }
    public partial class SamlSecurityToken : System.IdentityModel.Tokens.SecurityToken
    {
        [System.MonoTODOAttribute]
        protected SamlSecurityToken() { }
        public SamlSecurityToken(System.IdentityModel.Tokens.SamlAssertion assertion) { }
        public System.IdentityModel.Tokens.SamlAssertion Assertion { get { throw null; } }
        [System.MonoTODOAttribute]
        public override string Id { get { throw null; } }
        [System.MonoTODOAttribute]
        public override System.Collections.ObjectModel.ReadOnlyCollection<System.IdentityModel.Tokens.SecurityKey> SecurityKeys { get { throw null; } }
        [System.MonoTODOAttribute]
        public override System.DateTime ValidFrom { get { throw null; } }
        [System.MonoTODOAttribute]
        public override System.DateTime ValidTo { get { throw null; } }
        [System.MonoTODOAttribute]
        public override bool CanCreateKeyIdentifierClause<T>() { throw null; }
        [System.MonoTODOAttribute]
        public override T CreateKeyIdentifierClause<T>() { throw null; }
        [System.MonoTODOAttribute]
        protected void Initialize(System.IdentityModel.Tokens.SamlAssertion assertion) { }
        [System.MonoTODOAttribute]
        public override bool MatchesKeyIdentifierClause(System.IdentityModel.Tokens.SecurityKeyIdentifierClause skiClause) { throw null; }
    }
    public partial class SamlSerializer
    {
        [System.MonoTODOAttribute]
        public SamlSerializer() { }
        [System.MonoTODOAttribute]
        public virtual System.IdentityModel.Tokens.SamlAdvice LoadAdvice(System.Xml.XmlDictionaryReader reader, System.IdentityModel.Selectors.SecurityTokenSerializer tokenSerializer, System.IdentityModel.Selectors.SecurityTokenResolver tokenResolver) { throw null; }
        [System.MonoTODOAttribute]
        public virtual System.IdentityModel.Tokens.SamlAssertion LoadAssertion(System.Xml.XmlDictionaryReader reader, System.IdentityModel.Selectors.SecurityTokenSerializer tokenSerializer, System.IdentityModel.Selectors.SecurityTokenResolver tokenResolver) { throw null; }
        [System.MonoTODOAttribute]
        public virtual System.IdentityModel.Tokens.SamlAttribute LoadAttribute(System.Xml.XmlDictionaryReader reader, System.IdentityModel.Selectors.SecurityTokenSerializer tokenSerializer, System.IdentityModel.Selectors.SecurityTokenResolver tokenResolver) { throw null; }
        [System.MonoTODOAttribute]
        public virtual System.IdentityModel.Tokens.SamlCondition LoadCondition(System.Xml.XmlDictionaryReader reader, System.IdentityModel.Selectors.SecurityTokenSerializer tokenSerializer, System.IdentityModel.Selectors.SecurityTokenResolver tokenResolver) { throw null; }
        [System.MonoTODOAttribute]
        public virtual System.IdentityModel.Tokens.SamlConditions LoadConditions(System.Xml.XmlDictionaryReader reader, System.IdentityModel.Selectors.SecurityTokenSerializer tokenSerializer, System.IdentityModel.Selectors.SecurityTokenResolver tokenResolver) { throw null; }
        [System.MonoTODOAttribute]
        public virtual System.IdentityModel.Tokens.SamlStatement LoadStatement(System.Xml.XmlDictionaryReader reader, System.IdentityModel.Selectors.SecurityTokenSerializer tokenSerializer, System.IdentityModel.Selectors.SecurityTokenResolver tokenResolver) { throw null; }
        [System.MonoTODOAttribute]
        public void PopulateDictionary(System.Xml.IXmlDictionary dictionary) { }
        [System.MonoTODOAttribute]
        public virtual System.IdentityModel.Tokens.SamlSecurityToken ReadToken(System.Xml.XmlReader reader, System.IdentityModel.Selectors.SecurityTokenSerializer tokenSerializer, System.IdentityModel.Selectors.SecurityTokenResolver tokenResolver) { throw null; }
        [System.MonoTODOAttribute]
        public virtual void WriteToken(System.IdentityModel.Tokens.SamlSecurityToken token, System.Xml.XmlWriter writer, System.IdentityModel.Selectors.SecurityTokenSerializer keyInfoSerializer) { }
    }
    public abstract partial class SamlStatement
    {
        protected SamlStatement() { }
        public abstract bool IsReadOnly { get; }
        public abstract System.IdentityModel.Policy.IAuthorizationPolicy CreatePolicy(System.IdentityModel.Claims.ClaimSet issuer, System.IdentityModel.Selectors.SamlSecurityTokenAuthenticator samlAuthenticator);
        public abstract void MakeReadOnly();
        public abstract void ReadXml(System.Xml.XmlDictionaryReader reader, System.IdentityModel.Tokens.SamlSerializer samlSerializer, System.IdentityModel.Selectors.SecurityTokenSerializer keyInfoTokenSerializer, System.IdentityModel.Selectors.SecurityTokenResolver outOfBandTokenResolver);
        public abstract void WriteXml(System.Xml.XmlDictionaryWriter writer, System.IdentityModel.Tokens.SamlSerializer samlSerializer, System.IdentityModel.Selectors.SecurityTokenSerializer keyInfoTokenSerializer);
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
        [System.MonoTODOAttribute]
        public virtual System.Collections.ObjectModel.ReadOnlyCollection<System.IdentityModel.Claims.Claim> ExtractClaims() { throw null; }
        [System.MonoTODOAttribute]
        public virtual System.IdentityModel.Claims.ClaimSet ExtractSubjectKeyClaimSet(System.IdentityModel.Selectors.SamlSecurityTokenAuthenticator samlAuthenticator) { throw null; }
        public void MakeReadOnly() { }
        public virtual void ReadXml(System.Xml.XmlDictionaryReader reader, System.IdentityModel.Tokens.SamlSerializer samlSerializer, System.IdentityModel.Selectors.SecurityTokenSerializer keyInfoTokenSerializer, System.IdentityModel.Selectors.SecurityTokenResolver outOfBandTokenResolver) { }
        public virtual void WriteXml(System.Xml.XmlDictionaryWriter writer, System.IdentityModel.Tokens.SamlSerializer samlSerializer, System.IdentityModel.Selectors.SecurityTokenSerializer keyInfoTokenSerializer) { }
    }
    public abstract partial class SamlSubjectStatement : System.IdentityModel.Tokens.SamlStatement
    {
        protected SamlSubjectStatement() { }
        protected SamlSubjectStatement(System.IdentityModel.Tokens.SamlSubject samlSubject) { }
        public override bool IsReadOnly { get { throw null; } }
        public System.IdentityModel.Tokens.SamlSubject SamlSubject { get { throw null; } set { } }
        protected abstract void AddClaimsToList(System.Collections.Generic.IList<System.IdentityModel.Claims.Claim> claims);
        [System.MonoTODOAttribute]
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
        public const string Ripemd160Digest = "http://www.w3.org/2001/04/xmlenc#ripemd160";
        public const string RsaOaepKeyWrap = "http://www.w3.org/2001/04/xmlenc#rsa-oaep-mgf1p";
        public const string RsaSha1Signature = "http://www.w3.org/2000/09/xmldsig#rsa-sha1";
        public const string RsaSha256Signature = "http://www.w3.org/2001/04/xmldsig-more#rsa-sha256";
        public const string RsaV15KeyWrap = "http://www.w3.org/2001/04/xmlenc#rsa-1_5";
        public const string Sha1Digest = "http://www.w3.org/2000/09/xmldsig#sha1";
        public const string Sha256Digest = "http://www.w3.org/2001/04/xmlenc#sha256";
        public const string Sha512Digest = "http://www.w3.org/2001/04/xmlenc#sha512";
        public const string TlsSspiKeyWrap = "http://schemas.xmlsoap.org/2005/02/trust/tlsnego#TLS_Wrap";
        public const string TripleDesEncryption = "http://www.w3.org/2001/04/xmlenc#tripledes-cbc";
        public const string TripleDesKeyWrap = "http://www.w3.org/2001/04/xmlenc#kw-tripledes";
        public const string WindowsSspiKeyWrap = "http://schemas.xmlsoap.org/2005/02/trust/spnego#GSS_Wrap";
    }
    public abstract partial class SecurityKey
    {
        [System.MonoTODOAttribute]
        protected SecurityKey() { }
        public abstract int KeySize { get; }
        public abstract byte[] DecryptKey(string algorithm, byte[] keyData);
        public abstract byte[] EncryptKey(string algorithm, byte[] keyData);
        public abstract bool IsAsymmetricAlgorithm(string algorithm);
        public abstract bool IsSupportedAlgorithm(string algorithm);
        public abstract bool IsSymmetricAlgorithm(string algorithm);
    }
    public partial class SecurityKeyIdentifier : System.Collections.Generic.IEnumerable<System.IdentityModel.Tokens.SecurityKeyIdentifierClause>, System.Collections.IEnumerable
    {
        public SecurityKeyIdentifier() { }
        public SecurityKeyIdentifier(params System.IdentityModel.Tokens.SecurityKeyIdentifierClause[] identifiers) { }
        public bool CanCreateKey { get { throw null; } }
        public int Count { get { throw null; } }
        public bool IsReadOnly { get { throw null; } }
        public System.IdentityModel.Tokens.SecurityKeyIdentifierClause this[int i] { get { throw null; } }
        public void Add(System.IdentityModel.Tokens.SecurityKeyIdentifierClause item) { }
        public System.IdentityModel.Tokens.SecurityKey CreateKey() { throw null; }
        public TClause Find<TClause>() where TClause : System.IdentityModel.Tokens.SecurityKeyIdentifierClause { throw null; }
        public System.Collections.Generic.IEnumerator<System.IdentityModel.Tokens.SecurityKeyIdentifierClause> GetEnumerator() { throw null; }
        public void MakeReadOnly() { }
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { throw null; }
        public override string ToString() { throw null; }
        public bool TryFind<TClause>(out TClause result) where TClause : System.IdentityModel.Tokens.SecurityKeyIdentifierClause { result = default(TClause); throw null; }
    }
    public abstract partial class SecurityKeyIdentifierClause
    {
        protected SecurityKeyIdentifierClause(string clauseType) { }
        protected SecurityKeyIdentifierClause(string clauseType, byte[] derivationNonce, int derivationLength) { }
        public virtual bool CanCreateKey { get { throw null; } }
        public string ClauseType { get { throw null; } }
        public int DerivationLength { get { throw null; } }
        public string Id { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public virtual System.IdentityModel.Tokens.SecurityKey CreateKey() { throw null; }
        public byte[] GetDerivationNonce() { throw null; }
        [System.MonoTODOAttribute]
        public virtual bool Matches(System.IdentityModel.Tokens.SecurityKeyIdentifierClause clause) { throw null; }
    }
    public enum SecurityKeyType
    {
        AsymmetricKey = 1,
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
        [System.MonoTODOAttribute]
        public abstract System.DateTime ValidFrom { get; }
        [System.MonoTODOAttribute]
        public abstract System.DateTime ValidTo { get; }
        [System.MonoTODOAttribute]
        public virtual bool CanCreateKeyIdentifierClause<T>() where T : System.IdentityModel.Tokens.SecurityKeyIdentifierClause { throw null; }
        [System.MonoTODOAttribute]
        public virtual T CreateKeyIdentifierClause<T>() where T : System.IdentityModel.Tokens.SecurityKeyIdentifierClause { throw null; }
        public virtual bool MatchesKeyIdentifierClause(System.IdentityModel.Tokens.SecurityKeyIdentifierClause skiClause) { throw null; }
        [System.MonoTODOAttribute]
        public virtual System.IdentityModel.Tokens.SecurityKey ResolveKeyIdentifierClause(System.IdentityModel.Tokens.SecurityKeyIdentifierClause skiClause) { throw null; }
    }
    [System.SerializableAttribute]
    public partial class SecurityTokenException : System.SystemException
    {
        public SecurityTokenException() { }
        protected SecurityTokenException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
        public SecurityTokenException(string msg) { }
        public SecurityTokenException(string msg, System.Exception inner) { }
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
        public SecurityTokenValidationException(string msg) { }
        public SecurityTokenValidationException(string msg, System.Exception inner) { }
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
    public abstract partial class SymmetricSecurityKey : System.IdentityModel.Tokens.SecurityKey
    {
        [System.MonoTODOAttribute]
        protected SymmetricSecurityKey() { }
        public abstract byte[] GenerateDerivedKey(string algorithm, byte[] label, byte[] nonce, int derivedKeyLength, int offset);
        public abstract System.Security.Cryptography.ICryptoTransform GetDecryptionTransform(string algorithm, byte[] iv);
        public abstract System.Security.Cryptography.ICryptoTransform GetEncryptionTransform(string algorithm, byte[] iv);
        public abstract int GetIVSize(string algorithm);
        public abstract System.Security.Cryptography.KeyedHashAlgorithm GetKeyedHashAlgorithm(string algorithm);
        public abstract System.Security.Cryptography.SymmetricAlgorithm GetSymmetricAlgorithm(string algorithm);
        public abstract byte[] GetSymmetricKey();
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
    public partial class WindowsSecurityToken : System.IdentityModel.Tokens.SecurityToken
    {
        [System.MonoTODOAttribute]
        public WindowsSecurityToken() { }
        [System.MonoTODOAttribute]
        public WindowsSecurityToken(System.Security.Principal.WindowsIdentity identity) { }
        public WindowsSecurityToken(System.Security.Principal.WindowsIdentity identity, string id) { }
        public override string Id { get { throw null; } }
        [System.MonoTODOAttribute]
        public override System.Collections.ObjectModel.ReadOnlyCollection<System.IdentityModel.Tokens.SecurityKey> SecurityKeys { get { throw null; } }
        [System.MonoTODOAttribute]
        public override System.DateTime ValidFrom { get { throw null; } }
        [System.MonoTODOAttribute]
        public override System.DateTime ValidTo { get { throw null; } }
        public System.Security.Principal.WindowsIdentity WindowsIdentity { get { throw null; } }
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
    public partial class X509IssuerSerialKeyIdentifierClause : System.IdentityModel.Tokens.SecurityKeyIdentifierClause
    {
        public X509IssuerSerialKeyIdentifierClause(System.Security.Cryptography.X509Certificates.X509Certificate2 certificate) : base (default(string)) { }
        public X509IssuerSerialKeyIdentifierClause(string issuerName, string issuerSerialNumber) : base (default(string)) { }
        public string IssuerName { get { throw null; } }
        public string IssuerSerialNumber { get { throw null; } }
        public override bool Matches(System.IdentityModel.Tokens.SecurityKeyIdentifierClause clause) { throw null; }
        public bool Matches(System.Security.Cryptography.X509Certificates.X509Certificate2 certificate) { throw null; }
        public bool Matches(string issuerName, string issuerSerialNumber) { throw null; }
        [System.MonoTODOAttribute]
        public override string ToString() { throw null; }
    }
    public partial class X509RawDataKeyIdentifierClause : System.IdentityModel.Tokens.BinaryKeyIdentifierClause
    {
        public X509RawDataKeyIdentifierClause(byte[] certificateRawData) : base (default(string), default(byte[]), default(bool)) { }
        public X509RawDataKeyIdentifierClause(System.Security.Cryptography.X509Certificates.X509Certificate2 certificate) : base (default(string), default(byte[]), default(bool)) { }
        public override bool CanCreateKey { get { throw null; } }
        public override System.IdentityModel.Tokens.SecurityKey CreateKey() { throw null; }
        [System.MonoTODOAttribute("Not sure what should be returned when there are public/private pair key and public-only key")]
        public byte[] GetX509RawData() { throw null; }
        [System.MonoTODOAttribute("Not sure what should be returned when there are public/private pair key and public-only key")]
        public bool Matches(System.Security.Cryptography.X509Certificates.X509Certificate2 certificate) { throw null; }
        [System.MonoTODOAttribute]
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
        [System.MonoTODOAttribute]
        public override bool MatchesKeyIdentifierClause(System.IdentityModel.Tokens.SecurityKeyIdentifierClause skiClause) { throw null; }
        protected void ThrowIfDisposed() { }
    }
    public partial class X509SubjectKeyIdentifierClause : System.IdentityModel.Tokens.BinaryKeyIdentifierClause
    {
        [System.MonoTODOAttribute]
        public X509SubjectKeyIdentifierClause(byte[] certificateSubject) : base (default(string), default(byte[]), default(bool)) { }
        [System.MonoTODOAttribute]
        public static bool CanCreateFrom(System.Security.Cryptography.X509Certificates.X509Certificate2 certificate) { throw null; }
        [System.MonoTODOAttribute]
        public byte[] GetX509SubjectKeyIdentifier() { throw null; }
        [System.MonoTODOAttribute]
        public bool Matches(System.Security.Cryptography.X509Certificates.X509Certificate2 certificate) { throw null; }
        [System.MonoTODOAttribute]
        public override string ToString() { throw null; }
        [System.MonoTODOAttribute]
        public static bool TryCreateFrom(System.Security.Cryptography.X509Certificates.X509Certificate2 certificate, out System.IdentityModel.Tokens.X509SubjectKeyIdentifierClause clause) { clause = default(System.IdentityModel.Tokens.X509SubjectKeyIdentifierClause); throw null; }
    }
    public partial class X509ThumbprintKeyIdentifierClause : System.IdentityModel.Tokens.BinaryKeyIdentifierClause
    {
        public X509ThumbprintKeyIdentifierClause(byte[] certificateThumbprint) : base (default(string), default(byte[]), default(bool)) { }
        public X509ThumbprintKeyIdentifierClause(System.Security.Cryptography.X509Certificates.X509Certificate2 certificate) : base (default(string), default(byte[]), default(bool)) { }
        public byte[] GetX509Thumbprint() { throw null; }
        public bool Matches(System.Security.Cryptography.X509Certificates.X509Certificate2 certificate) { throw null; }
        [System.MonoTODOAttribute]
        public override string ToString() { throw null; }
    }
    public partial class X509WindowsSecurityToken : System.IdentityModel.Tokens.X509SecurityToken
    {
        [System.MonoTODOAttribute]
        public X509WindowsSecurityToken(System.Security.Cryptography.X509Certificates.X509Certificate2 cert, System.Security.Principal.WindowsIdentity identity) : base (default(System.Security.Cryptography.X509Certificates.X509Certificate2)) { }
        public X509WindowsSecurityToken(System.Security.Cryptography.X509Certificates.X509Certificate2 cert, System.Security.Principal.WindowsIdentity identity, string id) : base (default(System.Security.Cryptography.X509Certificates.X509Certificate2)) { }
        public System.Security.Principal.WindowsIdentity WindowsIdentity { get { throw null; } }
    }
}
namespace System.Security.Claims
{
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
}
