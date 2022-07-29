// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

[assembly:System.Reflection.AssemblyVersionAttribute("4.0.0.0")]
[assembly:System.Diagnostics.DebuggableAttribute(System.Diagnostics.DebuggableAttribute.DebuggingModes.IgnoreSymbolStoreSequencePoints)]
[assembly:System.Reflection.AssemblyCompanyAttribute("Mono development team")]
[assembly:System.Reflection.AssemblyCopyrightAttribute("(c) Various Mono authors")]
[assembly:System.Reflection.AssemblyDefaultAliasAttribute("System.Security.Cryptography.OpenSsl")]
[assembly:System.Reflection.AssemblyDescriptionAttribute("System.Security.Cryptography.OpenSsl")]
[assembly:System.Reflection.AssemblyFileVersionAttribute("4.0.0.0")]
[assembly:System.Reflection.AssemblyInformationalVersionAttribute("4.0.0.0")]
[assembly:System.Reflection.AssemblyProductAttribute("Mono Common Language Infrastructure")]
[assembly:System.Reflection.AssemblyTitleAttribute("System.Security.Cryptography.OpenSsl")]
[assembly:System.Runtime.CompilerServices.CompilationRelaxationsAttribute(8)]
[assembly:System.Runtime.CompilerServices.RuntimeCompatibilityAttribute(WrapNonExceptionThrows=true)]
namespace System.Security.Cryptography
{
    public sealed partial class ECDsaOpenSsl : System.Security.Cryptography.ECDsa
    {
        public ECDsaOpenSsl() { }
        public ECDsaOpenSsl(int keySize) { }
        public ECDsaOpenSsl(System.IntPtr handle) { }
        public ECDsaOpenSsl(System.Security.Cryptography.ECCurve curve) { }
        public ECDsaOpenSsl(System.Security.Cryptography.SafeEvpPKeyHandle pkeyHandle) { }
        public System.Security.Cryptography.SafeEvpPKeyHandle DuplicateKeyHandle() { throw null; }
        public override byte[] SignHash(byte[] hash) { throw null; }
        public override bool VerifyHash(byte[] hash, byte[] signature) { throw null; }
    }
    public sealed partial class RSAOpenSsl : System.Security.Cryptography.RSA
    {
        public RSAOpenSsl() { }
        public RSAOpenSsl(int keySize) { }
        public RSAOpenSsl(System.IntPtr handle) { }
        public RSAOpenSsl(System.Security.Cryptography.ECCurve curve) { }
        public RSAOpenSsl(System.Security.Cryptography.RSAParameters parameters) { }
        public RSAOpenSsl(System.Security.Cryptography.SafeEvpPKeyHandle pkeyHandle) { }
        public System.Security.Cryptography.SafeEvpPKeyHandle DuplicateKeyHandle() { throw null; }
        public override System.Security.Cryptography.RSAParameters ExportParameters(bool includePrivateParameters) { throw null; }
        public override void ImportParameters(System.Security.Cryptography.RSAParameters parameters) { }
        public override byte[] SignHash(byte[] hash, System.Security.Cryptography.HashAlgorithmName hashAlgorithm, System.Security.Cryptography.RSASignaturePadding padding) { throw null; }
        public override bool VerifyHash(byte[] hash, byte[] signature, System.Security.Cryptography.HashAlgorithmName hashAlgorithm, System.Security.Cryptography.RSASignaturePadding padding) { throw null; }
    }
    public sealed partial class SafeEvpPKeyHandle : System.Runtime.InteropServices.SafeHandle
    {
        public SafeEvpPKeyHandle(System.IntPtr handle, bool ownsHandle) { }
        public override bool IsInvalid { get { throw null; } }
        public System.Security.Cryptography.SafeEvpPKeyHandle DuplicateHandle() { throw null; }
        protected override bool ReleaseHandle() { throw null; }
    }
}
