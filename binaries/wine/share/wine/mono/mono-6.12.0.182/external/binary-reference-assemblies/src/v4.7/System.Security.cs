// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

[assembly:System.Reflection.AssemblyVersionAttribute("4.0.0.0")]
[assembly:System.CLSCompliantAttribute(true)]
[assembly:System.Diagnostics.DebuggableAttribute((System.Diagnostics.DebuggableAttribute.DebuggingModes)(2))]
[assembly:System.Reflection.AssemblyCompanyAttribute("Mono development team")]
[assembly:System.Reflection.AssemblyCopyrightAttribute("(c) Various Mono authors")]
[assembly:System.Reflection.AssemblyDefaultAliasAttribute("System.Security.dll")]
[assembly:System.Reflection.AssemblyDescriptionAttribute("System.Security.dll")]
[assembly:System.Reflection.AssemblyFileVersionAttribute("4.7.2046.0")]
[assembly:System.Reflection.AssemblyInformationalVersionAttribute("4.7.2046.0")]
[assembly:System.Reflection.AssemblyProductAttribute("Mono Common Language Infrastructure")]
[assembly:System.Reflection.AssemblyTitleAttribute("System.Security.dll")]
[assembly:System.Resources.NeutralResourcesLanguageAttribute("en-US")]
[assembly:System.Resources.SatelliteContractVersionAttribute("4.0.0.0")]
[assembly:System.Runtime.CompilerServices.CompilationRelaxationsAttribute(8)]
[assembly:System.Runtime.CompilerServices.ReferenceAssemblyAttribute]
[assembly:System.Runtime.CompilerServices.RuntimeCompatibilityAttribute(WrapNonExceptionThrows=true)]
[assembly:System.Runtime.InteropServices.ComVisibleAttribute(false)]
[assembly:System.Runtime.InteropServices.DefaultDllImportSearchPathsAttribute((System.Runtime.InteropServices.DllImportSearchPath)(2050))]
[assembly:System.Security.AllowPartiallyTrustedCallersAttribute]
[assembly:System.Security.SecurityRulesAttribute((System.Security.SecurityRuleSet)(2), SkipVerificationInFullTrust=true)]
[assembly:System.Security.Permissions.SecurityPermissionAttribute(System.Security.Permissions.SecurityAction.RequestMinimum, SkipVerification=true)]
namespace System.Security.Cryptography
{
    [System.Security.Permissions.HostProtectionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, MayLeakOnAbort=true)]
    public sealed partial class CryptographicAttributeObject
    {
        public CryptographicAttributeObject(System.Security.Cryptography.Oid oid) { }
        public CryptographicAttributeObject(System.Security.Cryptography.Oid oid, System.Security.Cryptography.AsnEncodedDataCollection values) { }
        public System.Security.Cryptography.Oid Oid { get { throw null; } }
        public System.Security.Cryptography.AsnEncodedDataCollection Values { get { throw null; } }
    }
    [System.Security.Permissions.HostProtectionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, MayLeakOnAbort=true)]
    public sealed partial class CryptographicAttributeObjectCollection : System.Collections.ICollection, System.Collections.IEnumerable
    {
        public CryptographicAttributeObjectCollection() { }
        public CryptographicAttributeObjectCollection(System.Security.Cryptography.CryptographicAttributeObject attribute) { }
        public int Count { get { throw null; } }
        public bool IsSynchronized { get { throw null; } }
        public System.Security.Cryptography.CryptographicAttributeObject this[int index] { get { throw null; } }
        public object SyncRoot { get { throw null; } }
        public int Add(System.Security.Cryptography.AsnEncodedData asnEncodedData) { throw null; }
        public int Add(System.Security.Cryptography.CryptographicAttributeObject attribute) { throw null; }
        public void CopyTo(System.Security.Cryptography.CryptographicAttributeObject[] array, int index) { }
        public System.Security.Cryptography.CryptographicAttributeObjectEnumerator GetEnumerator() { throw null; }
        public void Remove(System.Security.Cryptography.CryptographicAttributeObject attribute) { }
        void System.Collections.ICollection.CopyTo(System.Array array, int index) { }
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { throw null; }
    }
    [System.Security.Permissions.HostProtectionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, MayLeakOnAbort=true)]
    public sealed partial class CryptographicAttributeObjectEnumerator : System.Collections.IEnumerator
    {
        internal CryptographicAttributeObjectEnumerator() { }
        public System.Security.Cryptography.CryptographicAttributeObject Current { get { throw null; } }
        object System.Collections.IEnumerator.Current { get { throw null; } }
        public bool MoveNext() { throw null; }
        public void Reset() { }
    }
    public enum DataProtectionScope
    {
        CurrentUser = 0,
        LocalMachine = 1,
    }
    public abstract partial class DataProtector
    {
        protected DataProtector(string applicationName, string primaryPurpose, string[] specificPurposes) { }
        protected string ApplicationName { get { throw null; } }
        protected virtual bool PrependHashedPurposeToPlaintext { get { throw null; } }
        protected string PrimaryPurpose { get { throw null; } }
        protected System.Collections.Generic.IEnumerable<string> SpecificPurposes { get { throw null; } }
        public static System.Security.Cryptography.DataProtector Create(string providerClass, string applicationName, string primaryPurpose, params string[] specificPurposes) { throw null; }
        protected virtual byte[] GetHashedPurpose() { throw null; }
        public abstract bool IsReprotectRequired(byte[] encryptedData);
        public byte[] Protect(byte[] userData) { throw null; }
        protected abstract byte[] ProviderProtect(byte[] userData);
        protected abstract byte[] ProviderUnprotect(byte[] encryptedData);
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining | System.Runtime.CompilerServices.MethodImplOptions.NoOptimization)]public byte[] Unprotect(byte[] encryptedData) { throw null; }
    }
    public sealed partial class DpapiDataProtector : System.Security.Cryptography.DataProtector
    {
        [System.Security.SecuritySafeCriticalAttribute]
        [System.Security.Permissions.DataProtectionPermissionAttribute(System.Security.Permissions.SecurityAction.Demand, Unrestricted=true)]
        public DpapiDataProtector(string appName, string primaryPurpose, params string[] specificPurpose) : base (default(string), default(string), default(string[])) { }
        protected override bool PrependHashedPurposeToPlaintext { get { throw null; } }
        public System.Security.Cryptography.DataProtectionScope Scope { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public override bool IsReprotectRequired(byte[] encryptedData) { throw null; }
        [System.Security.SecuritySafeCriticalAttribute]
        [System.Security.Permissions.DataProtectionPermissionAttribute(System.Security.Permissions.SecurityAction.Assert, ProtectData=true)]
        protected override byte[] ProviderProtect(byte[] userData) { throw null; }
        [System.Security.SecuritySafeCriticalAttribute]
        [System.Security.Permissions.DataProtectionPermissionAttribute(System.Security.Permissions.SecurityAction.Assert, UnprotectData=true)]
        protected override byte[] ProviderUnprotect(byte[] encryptedData) { throw null; }
    }
    public enum MemoryProtectionScope
    {
        CrossProcess = 1,
        SameLogon = 2,
        SameProcess = 0,
    }
    [System.Security.Permissions.HostProtectionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, MayLeakOnAbort=true)]
    public static partial class ProtectedData
    {
        [System.Security.SecuritySafeCriticalAttribute]
        public static byte[] Protect(byte[] userData, byte[] optionalEntropy, System.Security.Cryptography.DataProtectionScope scope) { throw null; }
        [System.Security.SecuritySafeCriticalAttribute]
        public static byte[] Unprotect(byte[] encryptedData, byte[] optionalEntropy, System.Security.Cryptography.DataProtectionScope scope) { throw null; }
    }
    [System.Security.Permissions.HostProtectionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, MayLeakOnAbort=true)]
    public static partial class ProtectedMemory
    {
        [System.Security.SecuritySafeCriticalAttribute]
        public static void Protect(byte[] userData, System.Security.Cryptography.MemoryProtectionScope scope) { }
        [System.Security.SecuritySafeCriticalAttribute]
        public static void Unprotect(byte[] encryptedData, System.Security.Cryptography.MemoryProtectionScope scope) { }
    }
}
namespace System.Security.Cryptography.Pkcs
{
    [System.Security.Permissions.HostProtectionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, MayLeakOnAbort=true)]
    public sealed partial class AlgorithmIdentifier
    {
        public AlgorithmIdentifier() { }
        public AlgorithmIdentifier(System.Security.Cryptography.Oid oid) { }
        public AlgorithmIdentifier(System.Security.Cryptography.Oid oid, int keyLength) { }
        public int KeyLength { get { throw null; } set { } }
        public System.Security.Cryptography.Oid Oid { get { throw null; } set { } }
        public byte[] Parameters { get { throw null; } set { } }
    }
    [System.Security.Permissions.HostProtectionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, MayLeakOnAbort=true)]
    public sealed partial class CmsRecipient
    {
        public CmsRecipient(System.Security.Cryptography.Pkcs.SubjectIdentifierType recipientIdentifierType, System.Security.Cryptography.X509Certificates.X509Certificate2 certificate) { }
        public CmsRecipient(System.Security.Cryptography.X509Certificates.X509Certificate2 certificate) { }
        public System.Security.Cryptography.X509Certificates.X509Certificate2 Certificate { get { throw null; } }
        public System.Security.Cryptography.Pkcs.SubjectIdentifierType RecipientIdentifierType { get { throw null; } }
    }
    [System.Security.Permissions.HostProtectionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, MayLeakOnAbort=true)]
    public sealed partial class CmsRecipientCollection : System.Collections.ICollection, System.Collections.IEnumerable
    {
        public CmsRecipientCollection() { }
        public CmsRecipientCollection(System.Security.Cryptography.Pkcs.CmsRecipient recipient) { }
        public CmsRecipientCollection(System.Security.Cryptography.Pkcs.SubjectIdentifierType recipientIdentifierType, System.Security.Cryptography.X509Certificates.X509Certificate2Collection certificates) { }
        public int Count { get { throw null; } }
        public bool IsSynchronized { get { throw null; } }
        public System.Security.Cryptography.Pkcs.CmsRecipient this[int index] { get { throw null; } }
        public object SyncRoot { get { throw null; } }
        public int Add(System.Security.Cryptography.Pkcs.CmsRecipient recipient) { throw null; }
        public void CopyTo(System.Array array, int index) { }
        public void CopyTo(System.Security.Cryptography.Pkcs.CmsRecipient[] array, int index) { }
        public System.Security.Cryptography.Pkcs.CmsRecipientEnumerator GetEnumerator() { throw null; }
        public void Remove(System.Security.Cryptography.Pkcs.CmsRecipient recipient) { }
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { throw null; }
    }
    [System.Security.Permissions.HostProtectionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, MayLeakOnAbort=true)]
    public sealed partial class CmsRecipientEnumerator : System.Collections.IEnumerator
    {
        internal CmsRecipientEnumerator() { }
        public System.Security.Cryptography.Pkcs.CmsRecipient Current { get { throw null; } }
        object System.Collections.IEnumerator.Current { get { throw null; } }
        public bool MoveNext() { throw null; }
        public void Reset() { }
    }
    [System.Security.Permissions.HostProtectionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, MayLeakOnAbort=true)]
    public sealed partial class CmsSigner
    {
        public CmsSigner() { }
        [System.Security.SecuritySafeCriticalAttribute]
        public CmsSigner(System.Security.Cryptography.CspParameters parameters) { }
        public CmsSigner(System.Security.Cryptography.Pkcs.SubjectIdentifierType signerIdentifierType) { }
        public CmsSigner(System.Security.Cryptography.Pkcs.SubjectIdentifierType signerIdentifierType, System.Security.Cryptography.X509Certificates.X509Certificate2 certificate) { }
        public CmsSigner(System.Security.Cryptography.X509Certificates.X509Certificate2 certificate) { }
        public System.Security.Cryptography.X509Certificates.X509Certificate2 Certificate { get { throw null; } set { } }
        public System.Security.Cryptography.X509Certificates.X509Certificate2Collection Certificates { get { throw null; } }
        public System.Security.Cryptography.Oid DigestAlgorithm { get { throw null; } set { } }
        public System.Security.Cryptography.X509Certificates.X509IncludeOption IncludeOption { get { throw null; } set { } }
        public System.Security.Cryptography.CryptographicAttributeObjectCollection SignedAttributes { get { throw null; } }
        public System.Security.Cryptography.Pkcs.SubjectIdentifierType SignerIdentifierType { get { throw null; } set { } }
        public System.Security.Cryptography.CryptographicAttributeObjectCollection UnsignedAttributes { get { throw null; } }
    }
    [System.Security.Permissions.HostProtectionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, MayLeakOnAbort=true)]
    public sealed partial class ContentInfo
    {
        public ContentInfo(byte[] content) { }
        public ContentInfo(System.Security.Cryptography.Oid contentType, byte[] content) { }
        public byte[] Content { get { throw null; } }
        public System.Security.Cryptography.Oid ContentType { get { throw null; } }
        [System.Security.SecuritySafeCriticalAttribute]
        ~ContentInfo() { }
        [System.Security.SecuritySafeCriticalAttribute]
        public static System.Security.Cryptography.Oid GetContentType(byte[] encodedMessage) { throw null; }
    }
    [System.Security.Permissions.HostProtectionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, MayLeakOnAbort=true)]
    public sealed partial class EnvelopedCms
    {
        public EnvelopedCms() { }
        public EnvelopedCms(System.Security.Cryptography.Pkcs.ContentInfo contentInfo) { }
        public EnvelopedCms(System.Security.Cryptography.Pkcs.ContentInfo contentInfo, System.Security.Cryptography.Pkcs.AlgorithmIdentifier encryptionAlgorithm) { }
        public EnvelopedCms(System.Security.Cryptography.Pkcs.SubjectIdentifierType recipientIdentifierType, System.Security.Cryptography.Pkcs.ContentInfo contentInfo) { }
        [System.Security.SecuritySafeCriticalAttribute]
        public EnvelopedCms(System.Security.Cryptography.Pkcs.SubjectIdentifierType recipientIdentifierType, System.Security.Cryptography.Pkcs.ContentInfo contentInfo, System.Security.Cryptography.Pkcs.AlgorithmIdentifier encryptionAlgorithm) { }
        public System.Security.Cryptography.X509Certificates.X509Certificate2Collection Certificates { get { throw null; } }
        public System.Security.Cryptography.Pkcs.AlgorithmIdentifier ContentEncryptionAlgorithm { get { throw null; } }
        public System.Security.Cryptography.Pkcs.ContentInfo ContentInfo { get { throw null; } }
        public System.Security.Cryptography.Pkcs.RecipientInfoCollection RecipientInfos { [System.Security.SecuritySafeCriticalAttribute]get { throw null; } }
        public System.Security.Cryptography.CryptographicAttributeObjectCollection UnprotectedAttributes { get { throw null; } }
        public int Version { get { throw null; } }
        [System.Security.SecuritySafeCriticalAttribute]
        public void Decode(byte[] encodedMessage) { }
        public void Decrypt() { }
        public void Decrypt(System.Security.Cryptography.Pkcs.RecipientInfo recipientInfo) { }
        public void Decrypt(System.Security.Cryptography.Pkcs.RecipientInfo recipientInfo, System.Security.Cryptography.X509Certificates.X509Certificate2Collection extraStore) { }
        public void Decrypt(System.Security.Cryptography.X509Certificates.X509Certificate2Collection extraStore) { }
        [System.Security.SecuritySafeCriticalAttribute]
        public byte[] Encode() { throw null; }
        public void Encrypt() { }
        public void Encrypt(System.Security.Cryptography.Pkcs.CmsRecipient recipient) { }
        public void Encrypt(System.Security.Cryptography.Pkcs.CmsRecipientCollection recipients) { }
    }
    public enum KeyAgreeKeyChoice
    {
        EphemeralKey = 1,
        StaticKey = 2,
        Unknown = 0,
    }
    [System.Security.Permissions.HostProtectionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, MayLeakOnAbort=true)]
    public sealed partial class KeyAgreeRecipientInfo : System.Security.Cryptography.Pkcs.RecipientInfo
    {
        internal KeyAgreeRecipientInfo() { }
        public System.DateTime Date { get { throw null; } }
        public override byte[] EncryptedKey { [System.Security.SecuritySafeCriticalAttribute]get { throw null; } }
        public override System.Security.Cryptography.Pkcs.AlgorithmIdentifier KeyEncryptionAlgorithm { [System.Security.SecuritySafeCriticalAttribute]get { throw null; } }
        public System.Security.Cryptography.Pkcs.SubjectIdentifierOrKey OriginatorIdentifierOrKey { [System.Security.SecuritySafeCriticalAttribute]get { throw null; } }
        public System.Security.Cryptography.CryptographicAttributeObject OtherKeyAttribute { [System.Security.SecuritySafeCriticalAttribute]get { throw null; } }
        public override System.Security.Cryptography.Pkcs.SubjectIdentifier RecipientIdentifier { [System.Security.SecuritySafeCriticalAttribute]get { throw null; } }
        public override int Version { get { throw null; } }
    }
    [System.Security.Permissions.HostProtectionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, MayLeakOnAbort=true)]
    public sealed partial class KeyTransRecipientInfo : System.Security.Cryptography.Pkcs.RecipientInfo
    {
        internal KeyTransRecipientInfo() { }
        public override byte[] EncryptedKey { [System.Security.SecuritySafeCriticalAttribute]get { throw null; } }
        public override System.Security.Cryptography.Pkcs.AlgorithmIdentifier KeyEncryptionAlgorithm { [System.Security.SecuritySafeCriticalAttribute]get { throw null; } }
        public override System.Security.Cryptography.Pkcs.SubjectIdentifier RecipientIdentifier { [System.Security.SecuritySafeCriticalAttribute]get { throw null; } }
        public override int Version { get { throw null; } }
    }
    [System.Security.Permissions.HostProtectionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, MayLeakOnAbort=true)]
    public partial class Pkcs9AttributeObject : System.Security.Cryptography.AsnEncodedData
    {
        public Pkcs9AttributeObject() { }
        public Pkcs9AttributeObject(System.Security.Cryptography.AsnEncodedData asnEncodedData) { }
        public Pkcs9AttributeObject(System.Security.Cryptography.Oid oid, byte[] encodedData) { }
        public Pkcs9AttributeObject(string oid, byte[] encodedData) { }
        public new System.Security.Cryptography.Oid Oid { get { throw null; } }
        public override void CopyFrom(System.Security.Cryptography.AsnEncodedData asnEncodedData) { }
    }
    [System.Security.Permissions.HostProtectionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, MayLeakOnAbort=true)]
    public sealed partial class Pkcs9ContentType : System.Security.Cryptography.Pkcs.Pkcs9AttributeObject
    {
        public Pkcs9ContentType() { }
        public System.Security.Cryptography.Oid ContentType { get { throw null; } }
        public override void CopyFrom(System.Security.Cryptography.AsnEncodedData asnEncodedData) { }
    }
    [System.Security.Permissions.HostProtectionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, MayLeakOnAbort=true)]
    public sealed partial class Pkcs9DocumentDescription : System.Security.Cryptography.Pkcs.Pkcs9AttributeObject
    {
        public Pkcs9DocumentDescription() { }
        public Pkcs9DocumentDescription(byte[] encodedDocumentDescription) { }
        public Pkcs9DocumentDescription(string documentDescription) { }
        public string DocumentDescription { get { throw null; } }
        public override void CopyFrom(System.Security.Cryptography.AsnEncodedData asnEncodedData) { }
    }
    [System.Security.Permissions.HostProtectionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, MayLeakOnAbort=true)]
    public sealed partial class Pkcs9DocumentName : System.Security.Cryptography.Pkcs.Pkcs9AttributeObject
    {
        public Pkcs9DocumentName() { }
        public Pkcs9DocumentName(byte[] encodedDocumentName) { }
        public Pkcs9DocumentName(string documentName) { }
        public string DocumentName { get { throw null; } }
        public override void CopyFrom(System.Security.Cryptography.AsnEncodedData asnEncodedData) { }
    }
    [System.Security.Permissions.HostProtectionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, MayLeakOnAbort=true)]
    public sealed partial class Pkcs9MessageDigest : System.Security.Cryptography.Pkcs.Pkcs9AttributeObject
    {
        public Pkcs9MessageDigest() { }
        public byte[] MessageDigest { get { throw null; } }
        public override void CopyFrom(System.Security.Cryptography.AsnEncodedData asnEncodedData) { }
    }
    [System.Security.Permissions.HostProtectionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, MayLeakOnAbort=true)]
    public sealed partial class Pkcs9SigningTime : System.Security.Cryptography.Pkcs.Pkcs9AttributeObject
    {
        public Pkcs9SigningTime() { }
        public Pkcs9SigningTime(byte[] encodedSigningTime) { }
        public Pkcs9SigningTime(System.DateTime signingTime) { }
        public System.DateTime SigningTime { get { throw null; } }
        public override void CopyFrom(System.Security.Cryptography.AsnEncodedData asnEncodedData) { }
    }
    [System.Security.Permissions.HostProtectionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, MayLeakOnAbort=true)]
    public sealed partial class PublicKeyInfo
    {
        internal PublicKeyInfo() { }
        public System.Security.Cryptography.Pkcs.AlgorithmIdentifier Algorithm { get { throw null; } }
        public byte[] KeyValue { get { throw null; } }
    }
    [System.Security.Permissions.HostProtectionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, MayLeakOnAbort=true)]
    public abstract partial class RecipientInfo
    {
        internal RecipientInfo() { }
        public abstract byte[] EncryptedKey { get; }
        public abstract System.Security.Cryptography.Pkcs.AlgorithmIdentifier KeyEncryptionAlgorithm { get; }
        public abstract System.Security.Cryptography.Pkcs.SubjectIdentifier RecipientIdentifier { get; }
        public System.Security.Cryptography.Pkcs.RecipientInfoType Type { get { throw null; } }
        public abstract int Version { get; }
    }
    [System.Security.Permissions.HostProtectionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, MayLeakOnAbort=true)]
    public sealed partial class RecipientInfoCollection : System.Collections.ICollection, System.Collections.IEnumerable
    {
        internal RecipientInfoCollection() { }
        public int Count { get { throw null; } }
        public bool IsSynchronized { get { throw null; } }
        public System.Security.Cryptography.Pkcs.RecipientInfo this[int index] { get { throw null; } }
        public object SyncRoot { get { throw null; } }
        public void CopyTo(System.Array array, int index) { }
        public void CopyTo(System.Security.Cryptography.Pkcs.RecipientInfo[] array, int index) { }
        public System.Security.Cryptography.Pkcs.RecipientInfoEnumerator GetEnumerator() { throw null; }
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { throw null; }
    }
    [System.Security.Permissions.HostProtectionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, MayLeakOnAbort=true)]
    public sealed partial class RecipientInfoEnumerator : System.Collections.IEnumerator
    {
        internal RecipientInfoEnumerator() { }
        public System.Security.Cryptography.Pkcs.RecipientInfo Current { get { throw null; } }
        object System.Collections.IEnumerator.Current { get { throw null; } }
        public bool MoveNext() { throw null; }
        public void Reset() { }
    }
    public enum RecipientInfoType
    {
        KeyAgreement = 2,
        KeyTransport = 1,
        Unknown = 0,
    }
    [System.Security.Permissions.HostProtectionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, MayLeakOnAbort=true)]
    public sealed partial class SignedCms
    {
        public SignedCms() { }
        public SignedCms(System.Security.Cryptography.Pkcs.ContentInfo contentInfo) { }
        public SignedCms(System.Security.Cryptography.Pkcs.ContentInfo contentInfo, bool detached) { }
        public SignedCms(System.Security.Cryptography.Pkcs.SubjectIdentifierType signerIdentifierType) { }
        public SignedCms(System.Security.Cryptography.Pkcs.SubjectIdentifierType signerIdentifierType, System.Security.Cryptography.Pkcs.ContentInfo contentInfo) { }
        [System.Security.SecuritySafeCriticalAttribute]
        public SignedCms(System.Security.Cryptography.Pkcs.SubjectIdentifierType signerIdentifierType, System.Security.Cryptography.Pkcs.ContentInfo contentInfo, bool detached) { }
        public System.Security.Cryptography.X509Certificates.X509Certificate2Collection Certificates { [System.Security.SecuritySafeCriticalAttribute]get { throw null; } }
        public System.Security.Cryptography.Pkcs.ContentInfo ContentInfo { get { throw null; } }
        public bool Detached { get { throw null; } }
        public System.Security.Cryptography.Pkcs.SignerInfoCollection SignerInfos { [System.Security.SecuritySafeCriticalAttribute]get { throw null; } }
        public int Version { [System.Security.SecuritySafeCriticalAttribute]get { throw null; } }
        [System.Security.SecuritySafeCriticalAttribute]
        public void CheckHash() { }
        public void CheckSignature(bool verifySignatureOnly) { }
        [System.Security.SecuritySafeCriticalAttribute]
        public void CheckSignature(System.Security.Cryptography.X509Certificates.X509Certificate2Collection extraStore, bool verifySignatureOnly) { }
        public void ComputeSignature() { }
        public void ComputeSignature(System.Security.Cryptography.Pkcs.CmsSigner signer) { }
        [System.Security.SecuritySafeCriticalAttribute]
        public void ComputeSignature(System.Security.Cryptography.Pkcs.CmsSigner signer, bool silent) { }
        [System.Security.SecuritySafeCriticalAttribute]
        public void Decode(byte[] encodedMessage) { }
        [System.Security.SecuritySafeCriticalAttribute]
        public byte[] Encode() { throw null; }
        [System.Security.SecuritySafeCriticalAttribute]
        public void RemoveSignature(int index) { }
        [System.Security.SecuritySafeCriticalAttribute]
        public void RemoveSignature(System.Security.Cryptography.Pkcs.SignerInfo signerInfo) { }
    }
    [System.Security.Permissions.HostProtectionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, MayLeakOnAbort=true)]
    public sealed partial class SignerInfo
    {
        internal SignerInfo() { }
        public System.Security.Cryptography.X509Certificates.X509Certificate2 Certificate { get { throw null; } }
        public System.Security.Cryptography.Pkcs.SignerInfoCollection CounterSignerInfos { get { throw null; } }
        public System.Security.Cryptography.Oid DigestAlgorithm { get { throw null; } }
        public System.Security.Cryptography.CryptographicAttributeObjectCollection SignedAttributes { [System.Security.SecuritySafeCriticalAttribute]get { throw null; } }
        public System.Security.Cryptography.Pkcs.SubjectIdentifier SignerIdentifier { [System.Security.SecuritySafeCriticalAttribute]get { throw null; } }
        public System.Security.Cryptography.CryptographicAttributeObjectCollection UnsignedAttributes { [System.Security.SecuritySafeCriticalAttribute]get { throw null; } }
        public int Version { get { throw null; } }
        [System.Security.SecuritySafeCriticalAttribute]
        public void CheckHash() { }
        public void CheckSignature(bool verifySignatureOnly) { }
        public void CheckSignature(System.Security.Cryptography.X509Certificates.X509Certificate2Collection extraStore, bool verifySignatureOnly) { }
        public void ComputeCounterSignature() { }
        public void ComputeCounterSignature(System.Security.Cryptography.Pkcs.CmsSigner signer) { }
        [System.Security.SecuritySafeCriticalAttribute]
        public void RemoveCounterSignature(int index) { }
        [System.Security.SecuritySafeCriticalAttribute]
        public void RemoveCounterSignature(System.Security.Cryptography.Pkcs.SignerInfo counterSignerInfo) { }
    }
    [System.Security.Permissions.HostProtectionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, MayLeakOnAbort=true)]
    public sealed partial class SignerInfoCollection : System.Collections.ICollection, System.Collections.IEnumerable
    {
        internal SignerInfoCollection() { }
        public int Count { get { throw null; } }
        public bool IsSynchronized { get { throw null; } }
        public System.Security.Cryptography.Pkcs.SignerInfo this[int index] { get { throw null; } }
        public object SyncRoot { get { throw null; } }
        public void CopyTo(System.Array array, int index) { }
        public void CopyTo(System.Security.Cryptography.Pkcs.SignerInfo[] array, int index) { }
        public System.Security.Cryptography.Pkcs.SignerInfoEnumerator GetEnumerator() { throw null; }
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { throw null; }
    }
    [System.Security.Permissions.HostProtectionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, MayLeakOnAbort=true)]
    public sealed partial class SignerInfoEnumerator : System.Collections.IEnumerator
    {
        internal SignerInfoEnumerator() { }
        public System.Security.Cryptography.Pkcs.SignerInfo Current { get { throw null; } }
        object System.Collections.IEnumerator.Current { get { throw null; } }
        public bool MoveNext() { throw null; }
        public void Reset() { }
    }
    [System.Security.Permissions.HostProtectionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, MayLeakOnAbort=true)]
    public sealed partial class SubjectIdentifier
    {
        internal SubjectIdentifier() { }
        public System.Security.Cryptography.Pkcs.SubjectIdentifierType Type { get { throw null; } }
        public object Value { get { throw null; } }
    }
    [System.Security.Permissions.HostProtectionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, MayLeakOnAbort=true)]
    public sealed partial class SubjectIdentifierOrKey
    {
        internal SubjectIdentifierOrKey() { }
        public System.Security.Cryptography.Pkcs.SubjectIdentifierOrKeyType Type { get { throw null; } }
        public object Value { get { throw null; } }
    }
    public enum SubjectIdentifierOrKeyType
    {
        IssuerAndSerialNumber = 1,
        PublicKeyInfo = 3,
        SubjectKeyIdentifier = 2,
        Unknown = 0,
    }
    public enum SubjectIdentifierType
    {
        IssuerAndSerialNumber = 1,
        NoSignature = 3,
        SubjectKeyIdentifier = 2,
        Unknown = 0,
    }
}
namespace System.Security.Cryptography.X509Certificates
{
    [System.Security.Permissions.HostProtectionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, MayLeakOnAbort=true)]
    public static partial class X509Certificate2UI
    {
        [System.Security.SecuritySafeCriticalAttribute]
        public static void DisplayCertificate(System.Security.Cryptography.X509Certificates.X509Certificate2 certificate) { }
        [System.Security.SecurityCriticalAttribute]
        public static void DisplayCertificate(System.Security.Cryptography.X509Certificates.X509Certificate2 certificate, System.IntPtr hwndParent) { }
        public static System.Security.Cryptography.X509Certificates.X509Certificate2Collection SelectFromCollection(System.Security.Cryptography.X509Certificates.X509Certificate2Collection certificates, string title, string message, System.Security.Cryptography.X509Certificates.X509SelectionFlag selectionFlag) { throw null; }
        [System.Security.SecurityCriticalAttribute]
        public static System.Security.Cryptography.X509Certificates.X509Certificate2Collection SelectFromCollection(System.Security.Cryptography.X509Certificates.X509Certificate2Collection certificates, string title, string message, System.Security.Cryptography.X509Certificates.X509SelectionFlag selectionFlag, System.IntPtr hwndParent) { throw null; }
    }
    public enum X509SelectionFlag
    {
        MultiSelection = 1,
        SingleSelection = 0,
    }
}
namespace System.Security.Cryptography.Xml
{
    [System.Security.Permissions.HostProtectionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, MayLeakOnAbort=true)]
    public sealed partial class CipherData
    {
        public CipherData() { }
        public CipherData(byte[] cipherValue) { }
        public CipherData(System.Security.Cryptography.Xml.CipherReference cipherReference) { }
        public System.Security.Cryptography.Xml.CipherReference CipherReference { get { throw null; } set { } }
        public byte[] CipherValue { get { throw null; } set { } }
        public System.Xml.XmlElement GetXml() { throw null; }
        public void LoadXml(System.Xml.XmlElement value) { }
    }
    [System.Security.Permissions.HostProtectionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, MayLeakOnAbort=true)]
    public sealed partial class CipherReference : System.Security.Cryptography.Xml.EncryptedReference
    {
        public CipherReference() { }
        public CipherReference(string uri) { }
        public CipherReference(string uri, System.Security.Cryptography.Xml.TransformChain transformChain) { }
        public override System.Xml.XmlElement GetXml() { throw null; }
        public override void LoadXml(System.Xml.XmlElement value) { }
    }
    [System.Security.Permissions.HostProtectionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, MayLeakOnAbort=true)]
    public partial class DataObject
    {
        public DataObject() { }
        public DataObject(string id, string mimeType, string encoding, System.Xml.XmlElement data) { }
        public System.Xml.XmlNodeList Data { get { throw null; } set { } }
        public string Encoding { get { throw null; } set { } }
        public string Id { get { throw null; } set { } }
        public string MimeType { get { throw null; } set { } }
        public System.Xml.XmlElement GetXml() { throw null; }
        public void LoadXml(System.Xml.XmlElement value) { }
    }
    [System.Security.Permissions.HostProtectionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, MayLeakOnAbort=true)]
    public sealed partial class DataReference : System.Security.Cryptography.Xml.EncryptedReference
    {
        public DataReference() { }
        public DataReference(string uri) { }
        public DataReference(string uri, System.Security.Cryptography.Xml.TransformChain transformChain) { }
    }
    [System.Security.Permissions.HostProtectionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, MayLeakOnAbort=true)]
    public partial class DSAKeyValue : System.Security.Cryptography.Xml.KeyInfoClause
    {
        public DSAKeyValue() { }
        public DSAKeyValue(System.Security.Cryptography.DSA key) { }
        public System.Security.Cryptography.DSA Key { get { throw null; } set { } }
        public override System.Xml.XmlElement GetXml() { throw null; }
        public override void LoadXml(System.Xml.XmlElement value) { }
    }
    [System.Security.Permissions.HostProtectionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, MayLeakOnAbort=true)]
    public sealed partial class EncryptedData : System.Security.Cryptography.Xml.EncryptedType
    {
        public EncryptedData() { }
        public override System.Xml.XmlElement GetXml() { throw null; }
        public override void LoadXml(System.Xml.XmlElement value) { }
    }
    [System.Security.Permissions.HostProtectionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, MayLeakOnAbort=true)]
    public sealed partial class EncryptedKey : System.Security.Cryptography.Xml.EncryptedType
    {
        public EncryptedKey() { }
        public string CarriedKeyName { get { throw null; } set { } }
        public string Recipient { get { throw null; } set { } }
        public System.Security.Cryptography.Xml.ReferenceList ReferenceList { get { throw null; } }
        public void AddReference(System.Security.Cryptography.Xml.DataReference dataReference) { }
        public void AddReference(System.Security.Cryptography.Xml.KeyReference keyReference) { }
        public override System.Xml.XmlElement GetXml() { throw null; }
        public override void LoadXml(System.Xml.XmlElement value) { }
    }
    [System.Security.Permissions.HostProtectionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, MayLeakOnAbort=true)]
    public abstract partial class EncryptedReference
    {
        protected EncryptedReference() { }
        protected EncryptedReference(string uri) { }
        protected EncryptedReference(string uri, System.Security.Cryptography.Xml.TransformChain transformChain) { }
        protected internal bool CacheValid { get { throw null; } }
        protected string ReferenceType { get { throw null; } set { } }
        public System.Security.Cryptography.Xml.TransformChain TransformChain { get { throw null; } set { } }
        public string Uri { get { throw null; } set { } }
        public void AddTransform(System.Security.Cryptography.Xml.Transform transform) { }
        public virtual System.Xml.XmlElement GetXml() { throw null; }
        public virtual void LoadXml(System.Xml.XmlElement value) { }
    }
    [System.Security.Permissions.HostProtectionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, MayLeakOnAbort=true)]
    public abstract partial class EncryptedType
    {
        protected EncryptedType() { }
        public virtual System.Security.Cryptography.Xml.CipherData CipherData { get { throw null; } set { } }
        public virtual string Encoding { get { throw null; } set { } }
        public virtual System.Security.Cryptography.Xml.EncryptionMethod EncryptionMethod { get { throw null; } set { } }
        public virtual System.Security.Cryptography.Xml.EncryptionPropertyCollection EncryptionProperties { get { throw null; } }
        public virtual string Id { get { throw null; } set { } }
        public System.Security.Cryptography.Xml.KeyInfo KeyInfo { get { throw null; } set { } }
        public virtual string MimeType { get { throw null; } set { } }
        public virtual string Type { get { throw null; } set { } }
        public void AddProperty(System.Security.Cryptography.Xml.EncryptionProperty ep) { }
        public abstract System.Xml.XmlElement GetXml();
        public abstract void LoadXml(System.Xml.XmlElement value);
    }
    [System.Security.Permissions.HostProtectionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, MayLeakOnAbort=true)]
    public partial class EncryptedXml
    {
        public const string XmlEncAES128KeyWrapUrl = "http://www.w3.org/2001/04/xmlenc#kw-aes128";
        public const string XmlEncAES128Url = "http://www.w3.org/2001/04/xmlenc#aes128-cbc";
        public const string XmlEncAES192KeyWrapUrl = "http://www.w3.org/2001/04/xmlenc#kw-aes192";
        public const string XmlEncAES192Url = "http://www.w3.org/2001/04/xmlenc#aes192-cbc";
        public const string XmlEncAES256KeyWrapUrl = "http://www.w3.org/2001/04/xmlenc#kw-aes256";
        public const string XmlEncAES256Url = "http://www.w3.org/2001/04/xmlenc#aes256-cbc";
        public const string XmlEncDESUrl = "http://www.w3.org/2001/04/xmlenc#des-cbc";
        public const string XmlEncElementContentUrl = "http://www.w3.org/2001/04/xmlenc#Content";
        public const string XmlEncElementUrl = "http://www.w3.org/2001/04/xmlenc#Element";
        public const string XmlEncEncryptedKeyUrl = "http://www.w3.org/2001/04/xmlenc#EncryptedKey";
        public const string XmlEncNamespaceUrl = "http://www.w3.org/2001/04/xmlenc#";
        public const string XmlEncRSA15Url = "http://www.w3.org/2001/04/xmlenc#rsa-1_5";
        public const string XmlEncRSAOAEPUrl = "http://www.w3.org/2001/04/xmlenc#rsa-oaep-mgf1p";
        public const string XmlEncSHA256Url = "http://www.w3.org/2001/04/xmlenc#sha256";
        public const string XmlEncSHA512Url = "http://www.w3.org/2001/04/xmlenc#sha512";
        public const string XmlEncTripleDESKeyWrapUrl = "http://www.w3.org/2001/04/xmlenc#kw-tripledes";
        public const string XmlEncTripleDESUrl = "http://www.w3.org/2001/04/xmlenc#tripledes-cbc";
        public EncryptedXml() { }
        public EncryptedXml(System.Xml.XmlDocument document) { }
        public EncryptedXml(System.Xml.XmlDocument document, System.Security.Policy.Evidence evidence) { }
        public System.Security.Policy.Evidence DocumentEvidence { get { throw null; } set { } }
        public System.Text.Encoding Encoding { get { throw null; } set { } }
        public System.Security.Cryptography.CipherMode Mode { get { throw null; } set { } }
        public System.Security.Cryptography.PaddingMode Padding { get { throw null; } set { } }
        public string Recipient { get { throw null; } set { } }
        public System.Xml.XmlResolver Resolver { get { throw null; } set { } }
        public int XmlDSigSearchDepth { get { throw null; } set { } }
        public void AddKeyNameMapping(string keyName, object keyObject) { }
        public void ClearKeyNameMappings() { }
        public byte[] DecryptData(System.Security.Cryptography.Xml.EncryptedData encryptedData, System.Security.Cryptography.SymmetricAlgorithm symmetricAlgorithm) { throw null; }
        public void DecryptDocument() { }
        public virtual byte[] DecryptEncryptedKey(System.Security.Cryptography.Xml.EncryptedKey encryptedKey) { throw null; }
        public static byte[] DecryptKey(byte[] keyData, System.Security.Cryptography.RSA rsa, bool useOAEP) { throw null; }
        public static byte[] DecryptKey(byte[] keyData, System.Security.Cryptography.SymmetricAlgorithm symmetricAlgorithm) { throw null; }
        public System.Security.Cryptography.Xml.EncryptedData Encrypt(System.Xml.XmlElement inputElement, System.Security.Cryptography.X509Certificates.X509Certificate2 certificate) { throw null; }
        public System.Security.Cryptography.Xml.EncryptedData Encrypt(System.Xml.XmlElement inputElement, string keyName) { throw null; }
        public byte[] EncryptData(byte[] plaintext, System.Security.Cryptography.SymmetricAlgorithm symmetricAlgorithm) { throw null; }
        public byte[] EncryptData(System.Xml.XmlElement inputElement, System.Security.Cryptography.SymmetricAlgorithm symmetricAlgorithm, bool content) { throw null; }
        public static byte[] EncryptKey(byte[] keyData, System.Security.Cryptography.RSA rsa, bool useOAEP) { throw null; }
        public static byte[] EncryptKey(byte[] keyData, System.Security.Cryptography.SymmetricAlgorithm symmetricAlgorithm) { throw null; }
        public virtual byte[] GetDecryptionIV(System.Security.Cryptography.Xml.EncryptedData encryptedData, string symmetricAlgorithmUri) { throw null; }
        public virtual System.Security.Cryptography.SymmetricAlgorithm GetDecryptionKey(System.Security.Cryptography.Xml.EncryptedData encryptedData, string symmetricAlgorithmUri) { throw null; }
        public virtual System.Xml.XmlElement GetIdElement(System.Xml.XmlDocument document, string idValue) { throw null; }
        public void ReplaceData(System.Xml.XmlElement inputElement, byte[] decryptedData) { }
        public static void ReplaceElement(System.Xml.XmlElement inputElement, System.Security.Cryptography.Xml.EncryptedData encryptedData, bool content) { }
    }
    [System.Security.Permissions.HostProtectionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, MayLeakOnAbort=true)]
    public partial class EncryptionMethod
    {
        public EncryptionMethod() { }
        public EncryptionMethod(string algorithm) { }
        public string KeyAlgorithm { get { throw null; } set { } }
        public int KeySize { get { throw null; } set { } }
        public System.Xml.XmlElement GetXml() { throw null; }
        public void LoadXml(System.Xml.XmlElement value) { }
    }
    [System.Security.Permissions.HostProtectionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, MayLeakOnAbort=true)]
    public sealed partial class EncryptionProperty
    {
        public EncryptionProperty() { }
        public EncryptionProperty(System.Xml.XmlElement elementProperty) { }
        public string Id { get { throw null; } }
        public System.Xml.XmlElement PropertyElement { get { throw null; } set { } }
        public string Target { get { throw null; } }
        public System.Xml.XmlElement GetXml() { throw null; }
        public void LoadXml(System.Xml.XmlElement value) { }
    }
    [System.Security.Permissions.HostProtectionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, MayLeakOnAbort=true)]
    public sealed partial class EncryptionPropertyCollection : System.Collections.ICollection, System.Collections.IEnumerable, System.Collections.IList
    {
        public EncryptionPropertyCollection() { }
        public int Count { get { throw null; } }
        public bool IsFixedSize { get { throw null; } }
        public bool IsReadOnly { get { throw null; } }
        public bool IsSynchronized { get { throw null; } }
        [System.Runtime.CompilerServices.IndexerName("ItemOf")]
        public System.Security.Cryptography.Xml.EncryptionProperty this[int index] { get { throw null; } set { } }
        public object SyncRoot { get { throw null; } }
        object System.Collections.IList.this[int index] { get { throw null; } set { } }
        public int Add(System.Security.Cryptography.Xml.EncryptionProperty value) { throw null; }
        public void Clear() { }
        public bool Contains(System.Security.Cryptography.Xml.EncryptionProperty value) { throw null; }
        public void CopyTo(System.Array array, int index) { }
        public void CopyTo(System.Security.Cryptography.Xml.EncryptionProperty[] array, int index) { }
        public System.Collections.IEnumerator GetEnumerator() { throw null; }
        public int IndexOf(System.Security.Cryptography.Xml.EncryptionProperty value) { throw null; }
        public void Insert(int index, System.Security.Cryptography.Xml.EncryptionProperty value) { }
        public System.Security.Cryptography.Xml.EncryptionProperty Item(int index) { throw null; }
        public void Remove(System.Security.Cryptography.Xml.EncryptionProperty value) { }
        public void RemoveAt(int index) { }
        int System.Collections.IList.Add(object value) { throw null; }
        bool System.Collections.IList.Contains(object value) { throw null; }
        int System.Collections.IList.IndexOf(object value) { throw null; }
        void System.Collections.IList.Insert(int index, object value) { }
        void System.Collections.IList.Remove(object value) { }
    }
    public partial interface IRelDecryptor
    {
        System.IO.Stream Decrypt(System.Security.Cryptography.Xml.EncryptionMethod encryptionMethod, System.Security.Cryptography.Xml.KeyInfo keyInfo, System.IO.Stream toDecrypt);
    }
    [System.Security.Permissions.HostProtectionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, MayLeakOnAbort=true)]
    public partial class KeyInfo : System.Collections.IEnumerable
    {
        public KeyInfo() { }
        public int Count { get { throw null; } }
        public string Id { get { throw null; } set { } }
        public void AddClause(System.Security.Cryptography.Xml.KeyInfoClause clause) { }
        public System.Collections.IEnumerator GetEnumerator() { throw null; }
        public System.Collections.IEnumerator GetEnumerator(System.Type requestedObjectType) { throw null; }
        public System.Xml.XmlElement GetXml() { throw null; }
        public void LoadXml(System.Xml.XmlElement value) { }
    }
    [System.Security.Permissions.HostProtectionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, MayLeakOnAbort=true)]
    public abstract partial class KeyInfoClause
    {
        protected KeyInfoClause() { }
        public abstract System.Xml.XmlElement GetXml();
        public abstract void LoadXml(System.Xml.XmlElement element);
    }
    [System.Security.Permissions.HostProtectionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, MayLeakOnAbort=true)]
    public partial class KeyInfoEncryptedKey : System.Security.Cryptography.Xml.KeyInfoClause
    {
        public KeyInfoEncryptedKey() { }
        public KeyInfoEncryptedKey(System.Security.Cryptography.Xml.EncryptedKey encryptedKey) { }
        public System.Security.Cryptography.Xml.EncryptedKey EncryptedKey { get { throw null; } set { } }
        public override System.Xml.XmlElement GetXml() { throw null; }
        public override void LoadXml(System.Xml.XmlElement value) { }
    }
    [System.Security.Permissions.HostProtectionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, MayLeakOnAbort=true)]
    public partial class KeyInfoName : System.Security.Cryptography.Xml.KeyInfoClause
    {
        public KeyInfoName() { }
        public KeyInfoName(string keyName) { }
        public string Value { get { throw null; } set { } }
        public override System.Xml.XmlElement GetXml() { throw null; }
        public override void LoadXml(System.Xml.XmlElement value) { }
    }
    [System.Security.Permissions.HostProtectionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, MayLeakOnAbort=true)]
    public partial class KeyInfoNode : System.Security.Cryptography.Xml.KeyInfoClause
    {
        public KeyInfoNode() { }
        public KeyInfoNode(System.Xml.XmlElement node) { }
        public System.Xml.XmlElement Value { get { throw null; } set { } }
        public override System.Xml.XmlElement GetXml() { throw null; }
        public override void LoadXml(System.Xml.XmlElement value) { }
    }
    [System.Security.Permissions.HostProtectionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, MayLeakOnAbort=true)]
    public partial class KeyInfoRetrievalMethod : System.Security.Cryptography.Xml.KeyInfoClause
    {
        public KeyInfoRetrievalMethod() { }
        public KeyInfoRetrievalMethod(string strUri) { }
        public KeyInfoRetrievalMethod(string strUri, string typeName) { }
        [System.Runtime.InteropServices.ComVisibleAttribute(false)]
        public string Type { get { throw null; } set { } }
        public string Uri { get { throw null; } set { } }
        public override System.Xml.XmlElement GetXml() { throw null; }
        public override void LoadXml(System.Xml.XmlElement value) { }
    }
    [System.Security.Permissions.HostProtectionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, MayLeakOnAbort=true)]
    public partial class KeyInfoX509Data : System.Security.Cryptography.Xml.KeyInfoClause
    {
        public KeyInfoX509Data() { }
        public KeyInfoX509Data(byte[] rgbCert) { }
        public KeyInfoX509Data(System.Security.Cryptography.X509Certificates.X509Certificate cert) { }
        [System.Security.SecuritySafeCriticalAttribute]
        public KeyInfoX509Data(System.Security.Cryptography.X509Certificates.X509Certificate cert, System.Security.Cryptography.X509Certificates.X509IncludeOption includeOption) { }
        public System.Collections.ArrayList Certificates { get { throw null; } }
        public byte[] CRL { get { throw null; } set { } }
        public System.Collections.ArrayList IssuerSerials { get { throw null; } }
        public System.Collections.ArrayList SubjectKeyIds { get { throw null; } }
        public System.Collections.ArrayList SubjectNames { get { throw null; } }
        public void AddCertificate(System.Security.Cryptography.X509Certificates.X509Certificate certificate) { }
        public void AddIssuerSerial(string issuerName, string serialNumber) { }
        public void AddSubjectKeyId(byte[] subjectKeyId) { }
        [System.Runtime.InteropServices.ComVisibleAttribute(false)]
        public void AddSubjectKeyId(string subjectKeyId) { }
        public void AddSubjectName(string subjectName) { }
        public override System.Xml.XmlElement GetXml() { throw null; }
        public override void LoadXml(System.Xml.XmlElement element) { }
    }
    [System.Security.Permissions.HostProtectionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, MayLeakOnAbort=true)]
    public sealed partial class KeyReference : System.Security.Cryptography.Xml.EncryptedReference
    {
        public KeyReference() { }
        public KeyReference(string uri) { }
        public KeyReference(string uri, System.Security.Cryptography.Xml.TransformChain transformChain) { }
    }
    [System.Security.Permissions.HostProtectionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, MayLeakOnAbort=true)]
    public partial class Reference
    {
        public Reference() { }
        public Reference(System.IO.Stream stream) { }
        public Reference(string uri) { }
        public string DigestMethod { get { throw null; } set { } }
        public byte[] DigestValue { get { throw null; } set { } }
        public string Id { get { throw null; } set { } }
        public System.Security.Cryptography.Xml.TransformChain TransformChain { get { throw null; } [System.Runtime.InteropServices.ComVisibleAttribute(false)]set { } }
        public string Type { get { throw null; } set { } }
        public string Uri { get { throw null; } set { } }
        public void AddTransform(System.Security.Cryptography.Xml.Transform transform) { }
        public System.Xml.XmlElement GetXml() { throw null; }
        public void LoadXml(System.Xml.XmlElement value) { }
    }
    [System.Security.Permissions.HostProtectionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, MayLeakOnAbort=true)]
    public sealed partial class ReferenceList : System.Collections.ICollection, System.Collections.IEnumerable, System.Collections.IList
    {
        public ReferenceList() { }
        public int Count { get { throw null; } }
        public bool IsSynchronized { get { throw null; } }
        [System.Runtime.CompilerServices.IndexerName("ItemOf")]
        public System.Security.Cryptography.Xml.EncryptedReference this[int index] { get { throw null; } set { } }
        public object SyncRoot { get { throw null; } }
        bool System.Collections.IList.IsFixedSize { get { throw null; } }
        bool System.Collections.IList.IsReadOnly { get { throw null; } }
        object System.Collections.IList.this[int index] { get { throw null; } set { } }
        public int Add(object value) { throw null; }
        public void Clear() { }
        public bool Contains(object value) { throw null; }
        public void CopyTo(System.Array array, int index) { }
        public System.Collections.IEnumerator GetEnumerator() { throw null; }
        public int IndexOf(object value) { throw null; }
        public void Insert(int index, object value) { }
        public System.Security.Cryptography.Xml.EncryptedReference Item(int index) { throw null; }
        public void Remove(object value) { }
        public void RemoveAt(int index) { }
    }
    [System.Security.Permissions.HostProtectionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, MayLeakOnAbort=true)]
    public partial class RSAKeyValue : System.Security.Cryptography.Xml.KeyInfoClause
    {
        public RSAKeyValue() { }
        public RSAKeyValue(System.Security.Cryptography.RSA key) { }
        public System.Security.Cryptography.RSA Key { get { throw null; } set { } }
        public override System.Xml.XmlElement GetXml() { throw null; }
        public override void LoadXml(System.Xml.XmlElement value) { }
    }
    [System.Security.Permissions.HostProtectionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, MayLeakOnAbort=true)]
    public partial class Signature
    {
        public Signature() { }
        public string Id { get { throw null; } set { } }
        public System.Security.Cryptography.Xml.KeyInfo KeyInfo { get { throw null; } set { } }
        public System.Collections.IList ObjectList { get { throw null; } set { } }
        public byte[] SignatureValue { get { throw null; } set { } }
        public System.Security.Cryptography.Xml.SignedInfo SignedInfo { get { throw null; } set { } }
        public void AddObject(System.Security.Cryptography.Xml.DataObject dataObject) { }
        public System.Xml.XmlElement GetXml() { throw null; }
        public void LoadXml(System.Xml.XmlElement value) { }
    }
    [System.Security.Permissions.HostProtectionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, MayLeakOnAbort=true)]
    public partial class SignedInfo : System.Collections.ICollection, System.Collections.IEnumerable
    {
        public SignedInfo() { }
        public string CanonicalizationMethod { get { throw null; } set { } }
        [System.Runtime.InteropServices.ComVisibleAttribute(false)]
        public System.Security.Cryptography.Xml.Transform CanonicalizationMethodObject { get { throw null; } }
        public int Count { get { throw null; } }
        public string Id { get { throw null; } set { } }
        public bool IsReadOnly { get { throw null; } }
        public bool IsSynchronized { get { throw null; } }
        public System.Collections.ArrayList References { get { throw null; } }
        public string SignatureLength { get { throw null; } set { } }
        public string SignatureMethod { get { throw null; } set { } }
        public object SyncRoot { get { throw null; } }
        public void AddReference(System.Security.Cryptography.Xml.Reference reference) { }
        public void CopyTo(System.Array array, int index) { }
        public System.Collections.IEnumerator GetEnumerator() { throw null; }
        public System.Xml.XmlElement GetXml() { throw null; }
        public void LoadXml(System.Xml.XmlElement value) { }
    }
    [System.Security.Permissions.HostProtectionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, MayLeakOnAbort=true)]
    public partial class SignedXml
    {
        protected System.Security.Cryptography.Xml.Signature m_signature;
        protected string m_strSigningKeyName;
        public const string XmlDecryptionTransformUrl = "http://www.w3.org/2002/07/decrypt#XML";
        public const string XmlDsigBase64TransformUrl = "http://www.w3.org/2000/09/xmldsig#base64";
        public const string XmlDsigC14NTransformUrl = "http://www.w3.org/TR/2001/REC-xml-c14n-20010315";
        public const string XmlDsigC14NWithCommentsTransformUrl = "http://www.w3.org/TR/2001/REC-xml-c14n-20010315#WithComments";
        public const string XmlDsigCanonicalizationUrl = "http://www.w3.org/TR/2001/REC-xml-c14n-20010315";
        public const string XmlDsigCanonicalizationWithCommentsUrl = "http://www.w3.org/TR/2001/REC-xml-c14n-20010315#WithComments";
        public const string XmlDsigDSAUrl = "http://www.w3.org/2000/09/xmldsig#dsa-sha1";
        public const string XmlDsigEnvelopedSignatureTransformUrl = "http://www.w3.org/2000/09/xmldsig#enveloped-signature";
        public const string XmlDsigExcC14NTransformUrl = "http://www.w3.org/2001/10/xml-exc-c14n#";
        public const string XmlDsigExcC14NWithCommentsTransformUrl = "http://www.w3.org/2001/10/xml-exc-c14n#WithComments";
        public const string XmlDsigHMACSHA1Url = "http://www.w3.org/2000/09/xmldsig#hmac-sha1";
        public const string XmlDsigMinimalCanonicalizationUrl = "http://www.w3.org/2000/09/xmldsig#minimal";
        public const string XmlDsigNamespaceUrl = "http://www.w3.org/2000/09/xmldsig#";
        public const string XmlDsigRSASHA1Url = "http://www.w3.org/2000/09/xmldsig#rsa-sha1";
        public const string XmlDsigRSASHA256Url = "http://www.w3.org/2001/04/xmldsig-more#rsa-sha256";
        public const string XmlDsigRSASHA384Url = "http://www.w3.org/2001/04/xmldsig-more#rsa-sha384";
        public const string XmlDsigRSASHA512Url = "http://www.w3.org/2001/04/xmldsig-more#rsa-sha512";
        public const string XmlDsigSHA1Url = "http://www.w3.org/2000/09/xmldsig#sha1";
        public const string XmlDsigSHA256Url = "http://www.w3.org/2001/04/xmlenc#sha256";
        public const string XmlDsigSHA384Url = "http://www.w3.org/2001/04/xmldsig-more#sha384";
        public const string XmlDsigSHA512Url = "http://www.w3.org/2001/04/xmlenc#sha512";
        public const string XmlDsigXPathTransformUrl = "http://www.w3.org/TR/1999/REC-xpath-19991116";
        public const string XmlDsigXsltTransformUrl = "http://www.w3.org/TR/1999/REC-xslt-19991116";
        public const string XmlLicenseTransformUrl = "urn:mpeg:mpeg21:2003:01-REL-R-NS:licenseTransform";
        public SignedXml() { }
        public SignedXml(System.Xml.XmlDocument document) { }
        public SignedXml(System.Xml.XmlElement elem) { }
        [System.Runtime.InteropServices.ComVisibleAttribute(false)]
        public System.Security.Cryptography.Xml.EncryptedXml EncryptedXml { get { throw null; } set { } }
        public System.Security.Cryptography.Xml.KeyInfo KeyInfo { get { throw null; } set { } }
        [System.Runtime.InteropServices.ComVisibleAttribute(false)]
        public System.Xml.XmlResolver Resolver { set { } }
        public System.Collections.ObjectModel.Collection<string> SafeCanonicalizationMethods { get { throw null; } }
        public System.Security.Cryptography.Xml.Signature Signature { get { throw null; } }
        public System.Func<System.Security.Cryptography.Xml.SignedXml, bool> SignatureFormatValidator { get { throw null; } set { } }
        public string SignatureLength { get { throw null; } }
        public string SignatureMethod { get { throw null; } }
        public byte[] SignatureValue { get { throw null; } }
        public System.Security.Cryptography.Xml.SignedInfo SignedInfo { get { throw null; } }
        public System.Security.Cryptography.AsymmetricAlgorithm SigningKey { get { throw null; } set { } }
        public string SigningKeyName { get { throw null; } set { } }
        public void AddObject(System.Security.Cryptography.Xml.DataObject dataObject) { }
        public void AddReference(System.Security.Cryptography.Xml.Reference reference) { }
        public bool CheckSignature() { throw null; }
        public bool CheckSignature(System.Security.Cryptography.AsymmetricAlgorithm key) { throw null; }
        public bool CheckSignature(System.Security.Cryptography.KeyedHashAlgorithm macAlg) { throw null; }
        [System.Runtime.InteropServices.ComVisibleAttribute(false)]
        [System.Security.SecuritySafeCriticalAttribute]
        public bool CheckSignature(System.Security.Cryptography.X509Certificates.X509Certificate2 certificate, bool verifySignatureOnly) { throw null; }
        public bool CheckSignatureReturningKey(out System.Security.Cryptography.AsymmetricAlgorithm signingKey) { signingKey = default(System.Security.Cryptography.AsymmetricAlgorithm); throw null; }
        public void ComputeSignature() { }
        public void ComputeSignature(System.Security.Cryptography.KeyedHashAlgorithm macAlg) { }
        public virtual System.Xml.XmlElement GetIdElement(System.Xml.XmlDocument document, string idValue) { throw null; }
        protected virtual System.Security.Cryptography.AsymmetricAlgorithm GetPublicKey() { throw null; }
        public System.Xml.XmlElement GetXml() { throw null; }
        public void LoadXml(System.Xml.XmlElement value) { }
    }
    [System.Security.Permissions.HostProtectionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, MayLeakOnAbort=true)]
    public abstract partial class Transform
    {
        protected Transform() { }
        public string Algorithm { get { throw null; } set { } }
        [System.Runtime.InteropServices.ComVisibleAttribute(false)]
        public System.Xml.XmlElement Context { get { throw null; } set { } }
        public abstract System.Type[] InputTypes { get; }
        public abstract System.Type[] OutputTypes { get; }
        [System.Runtime.InteropServices.ComVisibleAttribute(false)]
        public System.Collections.Hashtable PropagatedNamespaces { get { throw null; } }
        [System.Runtime.InteropServices.ComVisibleAttribute(false)]
        public System.Xml.XmlResolver Resolver { set { } }
        [System.Runtime.InteropServices.ComVisibleAttribute(false)]
        public virtual byte[] GetDigestedOutput(System.Security.Cryptography.HashAlgorithm hash) { throw null; }
        protected abstract System.Xml.XmlNodeList GetInnerXml();
        public abstract object GetOutput();
        public abstract object GetOutput(System.Type type);
        public System.Xml.XmlElement GetXml() { throw null; }
        public abstract void LoadInnerXml(System.Xml.XmlNodeList nodeList);
        public abstract void LoadInput(object obj);
    }
    [System.Security.Permissions.HostProtectionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, MayLeakOnAbort=true)]
    public partial class TransformChain
    {
        public TransformChain() { }
        public int Count { get { throw null; } }
        public System.Security.Cryptography.Xml.Transform this[int index] { get { throw null; } }
        public void Add(System.Security.Cryptography.Xml.Transform transform) { }
        public System.Collections.IEnumerator GetEnumerator() { throw null; }
    }
    [System.Security.Permissions.HostProtectionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, MayLeakOnAbort=true)]
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public partial struct X509IssuerSerial
    {
        private object _dummy;
        public string IssuerName { get { throw null; } set { } }
        public string SerialNumber { get { throw null; } set { } }
    }
    [System.Security.Permissions.HostProtectionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, MayLeakOnAbort=true)]
    public partial class XmlDecryptionTransform : System.Security.Cryptography.Xml.Transform
    {
        public XmlDecryptionTransform() { }
        public System.Security.Cryptography.Xml.EncryptedXml EncryptedXml { get { throw null; } set { } }
        public override System.Type[] InputTypes { get { throw null; } }
        public override System.Type[] OutputTypes { get { throw null; } }
        public void AddExceptUri(string uri) { }
        protected override System.Xml.XmlNodeList GetInnerXml() { throw null; }
        public override object GetOutput() { throw null; }
        public override object GetOutput(System.Type type) { throw null; }
        protected virtual bool IsTargetElement(System.Xml.XmlElement inputElement, string idValue) { throw null; }
        public override void LoadInnerXml(System.Xml.XmlNodeList nodeList) { }
        public override void LoadInput(object obj) { }
    }
    [System.Security.Permissions.HostProtectionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, MayLeakOnAbort=true)]
    public partial class XmlDsigBase64Transform : System.Security.Cryptography.Xml.Transform
    {
        public XmlDsigBase64Transform() { }
        public override System.Type[] InputTypes { get { throw null; } }
        public override System.Type[] OutputTypes { get { throw null; } }
        protected override System.Xml.XmlNodeList GetInnerXml() { throw null; }
        public override object GetOutput() { throw null; }
        public override object GetOutput(System.Type type) { throw null; }
        public override void LoadInnerXml(System.Xml.XmlNodeList nodeList) { }
        public override void LoadInput(object obj) { }
    }
    [System.Security.Permissions.HostProtectionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, MayLeakOnAbort=true)]
    public partial class XmlDsigC14NTransform : System.Security.Cryptography.Xml.Transform
    {
        public XmlDsigC14NTransform() { }
        public XmlDsigC14NTransform(bool includeComments) { }
        public override System.Type[] InputTypes { get { throw null; } }
        public override System.Type[] OutputTypes { get { throw null; } }
        [System.Runtime.InteropServices.ComVisibleAttribute(false)]
        public override byte[] GetDigestedOutput(System.Security.Cryptography.HashAlgorithm hash) { throw null; }
        protected override System.Xml.XmlNodeList GetInnerXml() { throw null; }
        public override object GetOutput() { throw null; }
        public override object GetOutput(System.Type type) { throw null; }
        public override void LoadInnerXml(System.Xml.XmlNodeList nodeList) { }
        public override void LoadInput(object obj) { }
    }
    [System.Security.Permissions.HostProtectionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, MayLeakOnAbort=true)]
    public partial class XmlDsigC14NWithCommentsTransform : System.Security.Cryptography.Xml.XmlDsigC14NTransform
    {
        public XmlDsigC14NWithCommentsTransform() { }
    }
    [System.Security.Permissions.HostProtectionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, MayLeakOnAbort=true)]
    public partial class XmlDsigEnvelopedSignatureTransform : System.Security.Cryptography.Xml.Transform
    {
        public XmlDsigEnvelopedSignatureTransform() { }
        public XmlDsigEnvelopedSignatureTransform(bool includeComments) { }
        public override System.Type[] InputTypes { get { throw null; } }
        public override System.Type[] OutputTypes { get { throw null; } }
        protected override System.Xml.XmlNodeList GetInnerXml() { throw null; }
        public override object GetOutput() { throw null; }
        public override object GetOutput(System.Type type) { throw null; }
        public override void LoadInnerXml(System.Xml.XmlNodeList nodeList) { }
        public override void LoadInput(object obj) { }
    }
    [System.Security.Permissions.HostProtectionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, MayLeakOnAbort=true)]
    public partial class XmlDsigExcC14NTransform : System.Security.Cryptography.Xml.Transform
    {
        public XmlDsigExcC14NTransform() { }
        public XmlDsigExcC14NTransform(bool includeComments) { }
        public XmlDsigExcC14NTransform(bool includeComments, string inclusiveNamespacesPrefixList) { }
        public XmlDsigExcC14NTransform(string inclusiveNamespacesPrefixList) { }
        public string InclusiveNamespacesPrefixList { get { throw null; } set { } }
        public override System.Type[] InputTypes { get { throw null; } }
        public override System.Type[] OutputTypes { get { throw null; } }
        public override byte[] GetDigestedOutput(System.Security.Cryptography.HashAlgorithm hash) { throw null; }
        protected override System.Xml.XmlNodeList GetInnerXml() { throw null; }
        public override object GetOutput() { throw null; }
        public override object GetOutput(System.Type type) { throw null; }
        public override void LoadInnerXml(System.Xml.XmlNodeList nodeList) { }
        public override void LoadInput(object obj) { }
    }
    [System.Security.Permissions.HostProtectionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, MayLeakOnAbort=true)]
    public partial class XmlDsigExcC14NWithCommentsTransform : System.Security.Cryptography.Xml.XmlDsigExcC14NTransform
    {
        public XmlDsigExcC14NWithCommentsTransform() { }
        public XmlDsigExcC14NWithCommentsTransform(string inclusiveNamespacesPrefixList) { }
    }
    [System.Security.Permissions.HostProtectionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, MayLeakOnAbort=true)]
    public partial class XmlDsigXPathTransform : System.Security.Cryptography.Xml.Transform
    {
        public XmlDsigXPathTransform() { }
        public override System.Type[] InputTypes { get { throw null; } }
        public override System.Type[] OutputTypes { get { throw null; } }
        protected override System.Xml.XmlNodeList GetInnerXml() { throw null; }
        public override object GetOutput() { throw null; }
        public override object GetOutput(System.Type type) { throw null; }
        public override void LoadInnerXml(System.Xml.XmlNodeList nodeList) { }
        public override void LoadInput(object obj) { }
    }
    [System.Security.Permissions.HostProtectionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, MayLeakOnAbort=true)]
    public partial class XmlDsigXsltTransform : System.Security.Cryptography.Xml.Transform
    {
        public XmlDsigXsltTransform() { }
        public XmlDsigXsltTransform(bool includeComments) { }
        public override System.Type[] InputTypes { get { throw null; } }
        public override System.Type[] OutputTypes { get { throw null; } }
        protected override System.Xml.XmlNodeList GetInnerXml() { throw null; }
        public override object GetOutput() { throw null; }
        public override object GetOutput(System.Type type) { throw null; }
        public override void LoadInnerXml(System.Xml.XmlNodeList nodeList) { }
        public override void LoadInput(object obj) { }
    }
    [System.Security.Permissions.HostProtectionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, MayLeakOnAbort=true)]
    public partial class XmlLicenseTransform : System.Security.Cryptography.Xml.Transform
    {
        public XmlLicenseTransform() { }
        public System.Security.Cryptography.Xml.IRelDecryptor Decryptor { get { throw null; } set { } }
        public override System.Type[] InputTypes { get { throw null; } }
        public override System.Type[] OutputTypes { get { throw null; } }
        protected override System.Xml.XmlNodeList GetInnerXml() { throw null; }
        public override object GetOutput() { throw null; }
        public override object GetOutput(System.Type type) { throw null; }
        public override void LoadInnerXml(System.Xml.XmlNodeList nodeList) { }
        public override void LoadInput(object obj) { }
    }
}
namespace System.Security.Permissions
{
    [System.SerializableAttribute]
    public sealed partial class DataProtectionPermission : System.Security.CodeAccessPermission, System.Security.Permissions.IUnrestrictedPermission
    {
        public DataProtectionPermission(System.Security.Permissions.DataProtectionPermissionFlags flag) { }
        public DataProtectionPermission(System.Security.Permissions.PermissionState state) { }
        public System.Security.Permissions.DataProtectionPermissionFlags Flags { get { throw null; } set { } }
        public override System.Security.IPermission Copy() { throw null; }
        public override void FromXml(System.Security.SecurityElement securityElement) { }
        public override System.Security.IPermission Intersect(System.Security.IPermission target) { throw null; }
        public override bool IsSubsetOf(System.Security.IPermission target) { throw null; }
        public bool IsUnrestricted() { throw null; }
        public override System.Security.SecurityElement ToXml() { throw null; }
        public override System.Security.IPermission Union(System.Security.IPermission target) { throw null; }
    }
    [System.AttributeUsageAttribute((System.AttributeTargets)(109), AllowMultiple=true, Inherited=false)]
    [System.Security.Permissions.HostProtectionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, MayLeakOnAbort=true)]
    [System.SerializableAttribute]
    public sealed partial class DataProtectionPermissionAttribute : System.Security.Permissions.CodeAccessSecurityAttribute
    {
        public DataProtectionPermissionAttribute(System.Security.Permissions.SecurityAction action) : base (default(System.Security.Permissions.SecurityAction)) { }
        public System.Security.Permissions.DataProtectionPermissionFlags Flags { get { throw null; } set { } }
        public bool ProtectData { get { throw null; } set { } }
        public bool ProtectMemory { get { throw null; } set { } }
        public bool UnprotectData { get { throw null; } set { } }
        public bool UnprotectMemory { get { throw null; } set { } }
        public override System.Security.IPermission CreatePermission() { throw null; }
    }
    [System.FlagsAttribute]
    [System.SerializableAttribute]
    public enum DataProtectionPermissionFlags
    {
        AllFlags = 15,
        NoFlags = 0,
        ProtectData = 1,
        ProtectMemory = 4,
        UnprotectData = 2,
        UnprotectMemory = 8,
    }
}
