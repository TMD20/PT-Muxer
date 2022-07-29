// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

[assembly:System.Reflection.AssemblyVersionAttribute("4.0.0.0")]
[assembly:System.CLSCompliantAttribute(true)]
[assembly:System.Diagnostics.DebuggableAttribute((System.Diagnostics.DebuggableAttribute.DebuggingModes)(2))]
[assembly:System.Reflection.AssemblyCompanyAttribute("MONO development team")]
[assembly:System.Reflection.AssemblyCopyrightAttribute("(c) 2003-2004 Various Authors")]
[assembly:System.Reflection.AssemblyDescriptionAttribute("Mono.Security.Win32.dll")]
[assembly:System.Reflection.AssemblyProductAttribute("MONO CLI")]
[assembly:System.Reflection.AssemblyTitleAttribute("Mono.Security.Win32.dll")]
[assembly:System.Resources.NeutralResourcesLanguageAttribute("en-US")]
[assembly:System.Runtime.CompilerServices.CompilationRelaxationsAttribute(8)]
[assembly:System.Runtime.CompilerServices.ReferenceAssemblyAttribute]
[assembly:System.Runtime.CompilerServices.RuntimeCompatibilityAttribute(WrapNonExceptionThrows=true)]
[assembly:System.Runtime.InteropServices.ComVisibleAttribute(false)]
[assembly:System.Security.Permissions.SecurityPermissionAttribute(System.Security.Permissions.SecurityAction.RequestMinimum, SkipVerification=true)]
namespace Mono.Security.Cryptography
{
    public partial class CapiContext : System.IDisposable
    {
        public CapiContext() { }
        public CapiContext(System.Security.Cryptography.CspParameters csp) { }
        public int Error { get { throw null; } }
        public System.IntPtr Handle { get { throw null; } }
        public bool Result { get { throw null; } }
        public void Dispose() { }
        ~CapiContext() { }
    }
    public partial class CapiHash : System.IDisposable
    {
        public CapiHash(Mono.Security.Cryptography.CapiContext ctx, int hashAlgorithm) { }
        public CapiHash(int hashAlgorithm) { }
        public CapiHash(System.Security.Cryptography.CspParameters cspParams, int hashAlgorithm) { }
        public System.IntPtr Handle { get { throw null; } }
        public int HashSize { get { throw null; } }
        public void Dispose() { }
        ~CapiHash() { }
        public void HashCore(byte[] data, int start, int length) { }
        public byte[] HashFinal() { throw null; }
        public void Initialize(int algo) { }
    }
    public abstract partial class MD2 : System.Security.Cryptography.HashAlgorithm
    {
        protected MD2() { }
        public static new Mono.Security.Cryptography.MD2 Create() { throw null; }
        public static new Mono.Security.Cryptography.MD2 Create(string hashName) { throw null; }
    }
    public partial class MD2CryptoServiceProvider : Mono.Security.Cryptography.MD2
    {
        public MD2CryptoServiceProvider() { }
        protected override void Dispose(bool disposing) { }
        ~MD2CryptoServiceProvider() { }
        protected override void HashCore(byte[] rgb, int ibStart, int cbSize) { }
        protected override byte[] HashFinal() { throw null; }
        public override void Initialize() { }
    }
    public abstract partial class MD4 : System.Security.Cryptography.HashAlgorithm
    {
        protected MD4() { }
        public static new Mono.Security.Cryptography.MD4 Create() { throw null; }
        public static new Mono.Security.Cryptography.MD4 Create(string hashName) { throw null; }
    }
    public partial class MD4CryptoServiceProvider : Mono.Security.Cryptography.MD4
    {
        public MD4CryptoServiceProvider() { }
        protected override void Dispose(bool disposing) { }
        ~MD4CryptoServiceProvider() { }
        protected override void HashCore(byte[] rgb, int ibStart, int cbSize) { }
        protected override byte[] HashFinal() { throw null; }
        public override void Initialize() { }
    }
    public partial class MD5CryptoServiceProvider : System.Security.Cryptography.MD5
    {
        public MD5CryptoServiceProvider() { }
        protected override void Dispose(bool disposing) { }
        ~MD5CryptoServiceProvider() { }
        protected override void HashCore(byte[] rgb, int ibStart, int cbSize) { }
        protected override byte[] HashFinal() { throw null; }
        public override void Initialize() { }
    }
    public partial class RNGCryptoServiceProvider : System.Security.Cryptography.RandomNumberGenerator
    {
        public RNGCryptoServiceProvider() { }
        public RNGCryptoServiceProvider(byte[] rgb) { }
        public RNGCryptoServiceProvider(System.Security.Cryptography.CspParameters cspParams) { }
        public RNGCryptoServiceProvider(string str) { }
        ~RNGCryptoServiceProvider() { }
        public override void GetBytes(byte[] data) { }
        public override void GetNonZeroBytes(byte[] data) { }
    }
    public partial class SHA1CryptoServiceProvider : System.Security.Cryptography.SHA1
    {
        public SHA1CryptoServiceProvider() { }
        protected override void Dispose(bool disposing) { }
        ~SHA1CryptoServiceProvider() { }
        protected override void HashCore(byte[] rgb, int ibStart, int cbSize) { }
        protected override byte[] HashFinal() { throw null; }
        public override void Initialize() { }
    }
}
