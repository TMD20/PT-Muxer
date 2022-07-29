// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

[assembly:System.Reflection.AssemblyVersionAttribute("2.0.5.0")]
[assembly:System.CLSCompliantAttribute(true)]
[assembly:System.Diagnostics.DebuggableAttribute(System.Diagnostics.DebuggableAttribute.DebuggingModes.IgnoreSymbolStoreSequencePoints)]
[assembly:System.Reflection.AssemblyCompanyAttribute("Mono development team")]
[assembly:System.Reflection.AssemblyCopyrightAttribute("(c) Various Mono authors")]
[assembly:System.Reflection.AssemblyDefaultAliasAttribute("System.IdentityModel.dll")]
[assembly:System.Reflection.AssemblyDescriptionAttribute("System.IdentityModel.dll")]
[assembly:System.Reflection.AssemblyFileVersionAttribute("4.0.50524.0")]
[assembly:System.Reflection.AssemblyInformationalVersionAttribute("4.0.50524.0")]
[assembly:System.Reflection.AssemblyProductAttribute("Mono Common Language Infrastructure")]
[assembly:System.Reflection.AssemblyTitleAttribute("System.IdentityModel.dll")]
[assembly:System.Resources.NeutralResourcesLanguageAttribute("en-US")]
[assembly:System.Resources.SatelliteContractVersionAttribute("2.0.5.0")]
[assembly:System.Runtime.CompilerServices.CompilationRelaxationsAttribute(8)]
[assembly:System.Runtime.CompilerServices.RuntimeCompatibilityAttribute(WrapNonExceptionThrows=true)]
[assembly:System.Runtime.InteropServices.ComCompatibleVersionAttribute(1, 0, 3300, 0)]
[assembly:System.Runtime.InteropServices.ComVisibleAttribute(false)]
[assembly:System.Security.AllowPartiallyTrustedCallersAttribute]
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
namespace System.IdentityModel.Selectors
{
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
}
namespace System.ServiceModel.Security
{
    public enum X509CertificateValidationMode
    {
        ChainTrust = 2,
        Custom = 4,
        None = 0,
        PeerOrChainTrust = 3,
        PeerTrust = 1,
    }
}
