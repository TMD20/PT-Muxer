// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

[assembly:System.Reflection.AssemblyVersionAttribute("4.0.0.0")]
[assembly:System.CLSCompliantAttribute(true)]
[assembly:System.Diagnostics.DebuggableAttribute(System.Diagnostics.DebuggableAttribute.DebuggingModes.IgnoreSymbolStoreSequencePoints)]
[assembly:System.Reflection.AssemblyCompanyAttribute("MONO development team")]
[assembly:System.Reflection.AssemblyCopyrightAttribute("(c) 2016 Xamarin")]
[assembly:System.Reflection.AssemblyDescriptionAttribute("Mono.Btls.Interface")]
[assembly:System.Reflection.AssemblyProductAttribute("MONO CLI")]
[assembly:System.Reflection.AssemblyTitleAttribute("Mono.Btls.Interface")]
[assembly:System.Resources.NeutralResourcesLanguageAttribute("en-US")]
[assembly:System.Runtime.CompilerServices.CompilationRelaxationsAttribute(8)]
[assembly:System.Runtime.CompilerServices.RuntimeCompatibilityAttribute(WrapNonExceptionThrows=true)]
[assembly:System.Runtime.InteropServices.ComVisibleAttribute(false)]
[assembly:System.Security.Permissions.SecurityPermissionAttribute(System.Security.Permissions.SecurityAction.RequestMinimum, SkipVerification=true)]
namespace Mono.Btls.Interface
{
    public abstract partial class BtlsObject : System.IDisposable
    {
        internal BtlsObject() { }
        public bool IsValid { get { throw null; } }
        public void Dispose() { }
        protected void Dispose(bool disposing) { }
        ~BtlsObject() { }
    }
    public static partial class BtlsProvider
    {
        public static System.Security.Cryptography.X509Certificates.X509Certificate CreateCertificate(byte[] data, Mono.Btls.Interface.BtlsX509Format format, bool disallowFallback = false) { throw null; }
        public static System.Security.Cryptography.X509Certificates.X509Certificate2 CreateCertificate2(byte[] data, Mono.Btls.Interface.BtlsX509Format format, bool disallowFallback = false) { throw null; }
        public static System.Security.Cryptography.X509Certificates.X509Certificate2 CreateCertificate2(byte[] data, string password, bool disallowFallback = false) { throw null; }
        public static System.Security.Cryptography.X509Certificates.X509Chain CreateChain() { throw null; }
        public static Mono.Btls.Interface.BtlsX509 CreateNative(byte[] data, Mono.Btls.Interface.BtlsX509Format format) { throw null; }
        public static Mono.Btls.Interface.BtlsX509Chain CreateNativeChain() { throw null; }
        public static Mono.Btls.Interface.BtlsX509Store CreateNativeStore() { throw null; }
        public static Mono.Btls.Interface.BtlsX509StoreCtx CreateNativeStoreCtx() { throw null; }
        public static System.Security.Cryptography.X509Certificates.X509Chain GetManagedChain(Mono.Btls.Interface.BtlsX509Chain chain) { throw null; }
        public static Mono.Security.Interface.MonoTlsProvider GetProvider() { throw null; }
        public static string GetSystemStoreLocation() { throw null; }
        public static Mono.Btls.Interface.BtlsX509VerifyParam GetVerifyParam_SslClient() { throw null; }
        public static Mono.Btls.Interface.BtlsX509VerifyParam GetVerifyParam_SslServer() { throw null; }
        public static bool IsSupported() { throw null; }
    }
    public partial class BtlsX509 : Mono.Btls.Interface.BtlsObject
    {
        internal BtlsX509() { }
        public void ExportAsPEM(System.IO.Stream stream, bool includeHumanReadableForm) { }
        public byte[] GetCertHash() { throw null; }
        public Mono.Btls.Interface.BtlsX509Name GetIssuerName() { throw null; }
        public string GetIssuerNameString() { throw null; }
        public System.DateTime GetNotAfter() { throw null; }
        public System.DateTime GetNotBefore() { throw null; }
        public System.Security.Cryptography.AsnEncodedData GetPublicKeyAsn1() { throw null; }
        public byte[] GetPublicKeyData() { throw null; }
        public System.Security.Cryptography.AsnEncodedData GetPublicKeyParameters() { throw null; }
        public byte[] GetRawData(Mono.Btls.Interface.BtlsX509Format format) { throw null; }
        public byte[] GetSerialNumber(bool mono_style) { throw null; }
        public System.Security.Cryptography.Oid GetSignatureAlgorithm() { throw null; }
        public Mono.Btls.Interface.BtlsX509Name GetSubjectName() { throw null; }
        public long GetSubjectNameHash() { throw null; }
        public string GetSubjectNameString() { throw null; }
        public int GetVersion() { throw null; }
        public void Print(System.IO.Stream stream) { }
    }
    public partial class BtlsX509Chain : Mono.Btls.Interface.BtlsObject
    {
        internal BtlsX509Chain() { }
        public int Count { get { throw null; } }
        public Mono.Btls.Interface.BtlsX509 this[int index] { get { throw null; } }
        public void Add(Mono.Btls.Interface.BtlsX509 x509) { }
    }
    public enum BtlsX509Error
    {
        AKID_ISSUER_SERIAL_MISMATCH = 31,
        AKID_SKID_MISMATCH = 30,
        APPLICATION_VERIFICATION = 50,
        CERT_CHAIN_TOO_LONG = 22,
        CERT_HAS_EXPIRED = 10,
        CERT_NOT_YET_VALID = 9,
        CERT_REJECTED = 28,
        CERT_REVOKED = 23,
        CERT_SIGNATURE_FAILURE = 7,
        CERT_UNTRUSTED = 27,
        CRL_HAS_EXPIRED = 12,
        CRL_NOT_YET_VALID = 11,
        CRL_PATH_VALIDATION_ERROR = 54,
        CRL_SIGNATURE_FAILURE = 8,
        DEPTH_ZERO_SELF_SIGNED_CERT = 18,
        DIFFERENT_CRL_SCOPE = 44,
        EMAIL_MISMATCH = 63,
        ERROR_IN_CERT_NOT_AFTER_FIELD = 14,
        ERROR_IN_CERT_NOT_BEFORE_FIELD = 13,
        ERROR_IN_CRL_LAST_UPDATE_FIELD = 15,
        ERROR_IN_CRL_NEXT_UPDATE_FIELD = 16,
        EXCLUDED_VIOLATION = 48,
        HOSTNAME_MISMATCH = 62,
        INVALID_CA = 24,
        INVALID_EXTENSION = 41,
        INVALID_NON_CA = 37,
        INVALID_POLICY_EXTENSION = 42,
        INVALID_PURPOSE = 26,
        IP_ADDRESS_MISMATCH = 64,
        KEYUSAGE_NO_CERTSIGN = 32,
        KEYUSAGE_NO_CRL_SIGN = 35,
        KEYUSAGE_NO_DIGITAL_SIGNATURE = 39,
        NO_EXPLICIT_POLICY = 43,
        OK = 0,
        OUT_OF_MEM = 17,
        PATH_LENGTH_EXCEEDED = 25,
        PERMITTED_VIOLATION = 47,
        PROXY_CERTIFICATES_NOT_ALLOWED = 40,
        PROXY_PATH_LENGTH_EXCEEDED = 38,
        SELF_SIGNED_CERT_IN_CHAIN = 19,
        SUBJECT_ISSUER_MISMATCH = 29,
        SUBTREE_MINMAX = 49,
        SUITE_B_CANNOT_SIGN_P_384_WITH_P_256 = 61,
        SUITE_B_INVALID_ALGORITHM = 57,
        SUITE_B_INVALID_CURVE = 58,
        SUITE_B_INVALID_SIGNATURE_ALGORITHM = 59,
        SUITE_B_INVALID_VERSION = 56,
        SUITE_B_LOS_NOT_ALLOWED = 60,
        UNABLE_TO_DECODE_ISSUER_PUBLIC_KEY = 6,
        UNABLE_TO_DECRYPT_CERT_SIGNATURE = 4,
        UNABLE_TO_DECRYPT_CRL_SIGNATURE = 5,
        UNABLE_TO_GET_CRL = 3,
        UNABLE_TO_GET_CRL_ISSUER = 33,
        UNABLE_TO_GET_ISSUER_CERT = 2,
        UNABLE_TO_GET_ISSUER_CERT_LOCALLY = 20,
        UNABLE_TO_VERIFY_LEAF_SIGNATURE = 21,
        UNHANDLED_CRITICAL_CRL_EXTENSION = 36,
        UNHANDLED_CRITICAL_EXTENSION = 34,
        UNNESTED_RESOURCE = 46,
        UNSUPPORTED_CONSTRAINT_SYNTAX = 52,
        UNSUPPORTED_CONSTRAINT_TYPE = 51,
        UNSUPPORTED_EXTENSION_FEATURE = 45,
        UNSUPPORTED_NAME_SYNTAX = 53,
    }
    public enum BtlsX509Format
    {
        DER = 1,
        PEM = 2,
    }
    public partial class BtlsX509Lookup : Mono.Btls.Interface.BtlsObject
    {
        internal BtlsX509Lookup() { }
        public void AddDirectory(string dir, Mono.Btls.Interface.BtlsX509Format type) { }
        public void Initialize() { }
        public void LoadFile(string file, Mono.Btls.Interface.BtlsX509Format type) { }
        public Mono.Btls.Interface.BtlsX509 LookupBySubject(Mono.Btls.Interface.BtlsX509Name name) { throw null; }
        public void Shutdown() { }
    }
    public partial class BtlsX509Name : Mono.Btls.Interface.BtlsObject
    {
        internal BtlsX509Name() { }
        public long GetHash() { throw null; }
        public long GetHashOld() { throw null; }
        public byte[] GetRawData(bool use_canon_enc) { throw null; }
        public string GetString() { throw null; }
    }
    public enum BtlsX509Purpose
    {
        ANY = 7,
        CRL_SIGN = 6,
        NS_SSL_SERVER = 3,
        OCSP_HELPER = 8,
        SMIME_ENCRYPT = 5,
        SMIME_SIGN = 4,
        SSL_CLIENT = 1,
        SSL_SERVER = 2,
        TIMESTAMP_SIGN = 9,
    }
    public partial class BtlsX509Store : Mono.Btls.Interface.BtlsObject
    {
        internal BtlsX509Store() { }
        public void AddCertificate(Mono.Btls.Interface.BtlsX509 x509) { }
        public void AddDirectoryLookup(string dir, Mono.Btls.Interface.BtlsX509Format format) { }
        public void AddFileLookup(string file, Mono.Btls.Interface.BtlsX509Format format) { }
        public void AddLookup(System.Security.Cryptography.X509Certificates.X509CertificateCollection certificates, Mono.Btls.Interface.BtlsX509TrustKind trust) { }
        public void AddTrustedRoots() { }
        public int GetCount() { throw null; }
        public void LoadLocations(string file, string path) { }
    }
    public partial class BtlsX509StoreCtx : Mono.Btls.Interface.BtlsObject
    {
        internal BtlsX509StoreCtx() { }
        public Mono.Btls.Interface.BtlsX509Chain GetChain() { throw null; }
        public Mono.Btls.Interface.BtlsX509Error GetError() { throw null; }
        public System.Exception GetException() { throw null; }
        public void Initialize(Mono.Btls.Interface.BtlsX509Store store, Mono.Btls.Interface.BtlsX509Chain chain) { }
        public void SetVerifyParam(Mono.Btls.Interface.BtlsX509VerifyParam param) { }
        public int Verify() { throw null; }
    }
    public static partial class BtlsX509StoreManager
    {
        public static string GetStorePath(Mono.Btls.Interface.BtlsX509StoreType type) { throw null; }
        public static bool HasStore(Mono.Btls.Interface.BtlsX509StoreType type) { throw null; }
    }
    public enum BtlsX509StoreType
    {
        Custom = 0,
        MachineIntermediateCA = 2,
        MachineTrustedRoots = 1,
        MachineUntrusted = 3,
        UserIntermediateCA = 5,
        UserTrustedRoots = 4,
        UserUntrusted = 6,
    }
    [System.FlagsAttribute]
    public enum BtlsX509TrustKind
    {
        DEFAULT = 0,
        REJECT_ALL = 128,
        REJECT_CLIENT = 32,
        REJECT_SERVER = 64,
        TRUST_ALL = 4,
        TRUST_CLIENT = 1,
        TRUST_SERVER = 2,
    }
    public enum BtlsX509VerifyFlags
    {
        CRL_CHECK = 1,
        CRL_CHECK_ALL = 2,
        DEFAULT = 0,
        X509_STRIC = 4,
    }
    public partial class BtlsX509VerifyParam : Mono.Btls.Interface.BtlsObject
    {
        internal BtlsX509VerifyParam() { }
        public void AddHost(string name) { }
        public Mono.Btls.Interface.BtlsX509VerifyParam Copy() { throw null; }
        public int GetDepth() { throw null; }
        public Mono.Btls.Interface.BtlsX509VerifyFlags GetFlags() { throw null; }
        public void SetDepth(int depth) { }
        public void SetFlags(Mono.Btls.Interface.BtlsX509VerifyFlags flags) { }
        public void SetHost(string name) { }
        public void SetName(string name) { }
        public void SetPurpose(Mono.Btls.Interface.BtlsX509Purpose purpose) { }
        public void SetTime(System.DateTime time) { }
    }
    public static partial class VersionInfo
    {
        public const string Version = "1.0.0";
    }
}
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
