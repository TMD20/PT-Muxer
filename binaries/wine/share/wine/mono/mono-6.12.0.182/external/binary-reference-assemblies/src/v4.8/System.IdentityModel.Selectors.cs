// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

[assembly:System.Reflection.AssemblyVersionAttribute("4.0.0.0")]
[assembly:System.CLSCompliantAttribute(true)]
[assembly:System.Diagnostics.DebuggableAttribute(System.Diagnostics.DebuggableAttribute.DebuggingModes.IgnoreSymbolStoreSequencePoints)]
[assembly:System.Reflection.AssemblyCompanyAttribute("Mono development team")]
[assembly:System.Reflection.AssemblyCopyrightAttribute("(c) Various Mono authors")]
[assembly:System.Reflection.AssemblyDefaultAliasAttribute("System.IdentityModel.Selectors.dll")]
[assembly:System.Reflection.AssemblyDescriptionAttribute("System.IdentityModel.Selectors.dll")]
[assembly:System.Reflection.AssemblyFileVersionAttribute("4.8.3761.0")]
[assembly:System.Reflection.AssemblyInformationalVersionAttribute("4.8.3761.0")]
[assembly:System.Reflection.AssemblyProductAttribute("Mono Common Language Infrastructure")]
[assembly:System.Reflection.AssemblyTitleAttribute("System.IdentityModel.Selectors.dll")]
[assembly:System.Resources.NeutralResourcesLanguageAttribute("en-US")]
[assembly:System.Resources.SatelliteContractVersionAttribute("4.0.0.0")]
[assembly:System.Runtime.CompilerServices.CompilationRelaxationsAttribute(8)]
[assembly:System.Runtime.CompilerServices.ReferenceAssemblyAttribute]
[assembly:System.Runtime.CompilerServices.RuntimeCompatibilityAttribute(WrapNonExceptionThrows=true)]
[assembly:System.Runtime.InteropServices.ComVisibleAttribute(false)]
[assembly:System.Runtime.InteropServices.DefaultDllImportSearchPathsAttribute(System.Runtime.InteropServices.DllImportSearchPath.AssemblyDirectory | System.Runtime.InteropServices.DllImportSearchPath.System32)]
[assembly:System.Security.Permissions.SecurityPermissionAttribute(System.Security.Permissions.SecurityAction.RequestMinimum, SkipVerification=true)]
namespace System.IdentityModel.Selectors
{
    [System.SerializableAttribute]
    public partial class CardSpaceException : System.Exception
    {
        public CardSpaceException() { }
        protected CardSpaceException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
        public CardSpaceException(string message) { }
        public CardSpaceException(string message, System.Exception innerException) { }
    }
    public partial class CardSpacePolicyElement
    {
        public CardSpacePolicyElement(System.Xml.XmlElement target, System.Xml.XmlElement issuer, System.Collections.ObjectModel.Collection<System.Xml.XmlElement> parameters, System.Uri privacyNoticeLink, int privacyNoticeVersion, bool isManagedIssuer) { }
        public bool IsManagedIssuer { get { throw null; } set { } }
        public System.Xml.XmlElement Issuer { get { throw null; } set { } }
        public System.Collections.ObjectModel.Collection<System.Xml.XmlElement> Parameters { get { throw null; } }
        public System.Uri PolicyNoticeLink { get { throw null; } set { } }
        public int PolicyNoticeVersion { get { throw null; } set { } }
        public System.Xml.XmlElement Target { get { throw null; } set { } }
    }
    public static partial class CardSpaceSelector
    {
        public static System.IdentityModel.Tokens.GenericXmlSecurityToken GetToken(System.IdentityModel.Selectors.CardSpacePolicyElement[] policyChain, System.IdentityModel.Selectors.SecurityTokenSerializer tokenSerializer) { throw null; }
        public static System.IdentityModel.Tokens.GenericXmlSecurityToken GetToken(System.Xml.XmlElement endpoint, System.Collections.Generic.IEnumerable<System.Xml.XmlElement> policy, System.Xml.XmlElement requiredRemoteTokenIssuer, System.IdentityModel.Selectors.SecurityTokenSerializer tokenSerializer) { throw null; }
        public static void Import(string fileName) { }
        public static void Manage() { }
    }
    [System.SerializableAttribute]
    public partial class IdentityValidationException : System.Exception
    {
        public IdentityValidationException() { }
        protected IdentityValidationException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
        public IdentityValidationException(string message) { }
        public IdentityValidationException(string message, System.Exception innerException) { }
    }
    [System.SerializableAttribute]
    public partial class PolicyValidationException : System.Exception
    {
        public PolicyValidationException() { }
        protected PolicyValidationException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
        public PolicyValidationException(string message) { }
        public PolicyValidationException(string message, System.Exception innerException) { }
    }
    [System.SerializableAttribute]
    public partial class ServiceBusyException : System.Exception
    {
        public ServiceBusyException() { }
        protected ServiceBusyException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
        public ServiceBusyException(string message) { }
        public ServiceBusyException(string message, System.Exception innerException) { }
    }
    [System.SerializableAttribute]
    public partial class ServiceNotStartedException : System.Exception
    {
        public ServiceNotStartedException() { }
        protected ServiceNotStartedException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
        public ServiceNotStartedException(string message) { }
        public ServiceNotStartedException(string message, System.Exception innerException) { }
    }
    [System.SerializableAttribute]
    public partial class StsCommunicationException : System.Exception
    {
        public StsCommunicationException() { }
        protected StsCommunicationException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
        public StsCommunicationException(string message) { }
        public StsCommunicationException(string message, System.Exception innerException) { }
    }
    [System.SerializableAttribute]
    public partial class UnsupportedPolicyOptionsException : System.Exception
    {
        public UnsupportedPolicyOptionsException() { }
        protected UnsupportedPolicyOptionsException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
        public UnsupportedPolicyOptionsException(string message) { }
        public UnsupportedPolicyOptionsException(string message, System.Exception innerException) { }
    }
    [System.SerializableAttribute]
    public partial class UntrustedRecipientException : System.Exception
    {
        public UntrustedRecipientException() { }
        protected UntrustedRecipientException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
        public UntrustedRecipientException(string message) { }
        public UntrustedRecipientException(string message, System.Exception innerException) { }
    }
    [System.SerializableAttribute]
    public partial class UserCancellationException : System.Exception
    {
        public UserCancellationException() { }
        protected UserCancellationException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
        public UserCancellationException(string message) { }
        public UserCancellationException(string message, System.Exception innerException) { }
    }
}
