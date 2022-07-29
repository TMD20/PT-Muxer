// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

[assembly:System.Reflection.AssemblyVersionAttribute("4.0.0.0")]
[assembly:System.CLSCompliantAttribute(true)]
[assembly:System.Diagnostics.DebuggableAttribute((System.Diagnostics.DebuggableAttribute.DebuggingModes)(2))]
[assembly:System.Reflection.AssemblyCompanyAttribute("Mono development team")]
[assembly:System.Reflection.AssemblyCopyrightAttribute("(c) Various Mono authors")]
[assembly:System.Reflection.AssemblyDefaultAliasAttribute("System.DirectoryServices.Protocols.dll")]
[assembly:System.Reflection.AssemblyDescriptionAttribute("System.DirectoryServices.Protocols.dll")]
[assembly:System.Reflection.AssemblyFileVersionAttribute("4.7.2046.0")]
[assembly:System.Reflection.AssemblyInformationalVersionAttribute("4.7.2046.0")]
[assembly:System.Reflection.AssemblyProductAttribute("Mono Common Language Infrastructure")]
[assembly:System.Reflection.AssemblyTitleAttribute("System.DirectoryServices.Protocols.dll")]
[assembly:System.Resources.NeutralResourcesLanguageAttribute("en-US")]
[assembly:System.Resources.SatelliteContractVersionAttribute("4.0.0.0")]
[assembly:System.Runtime.CompilerServices.CompilationRelaxationsAttribute(8)]
[assembly:System.Runtime.CompilerServices.ReferenceAssemblyAttribute]
[assembly:System.Runtime.CompilerServices.RuntimeCompatibilityAttribute(WrapNonExceptionThrows=true)]
[assembly:System.Runtime.InteropServices.ComVisibleAttribute(false)]
[assembly:System.Runtime.InteropServices.DefaultDllImportSearchPathsAttribute((System.Runtime.InteropServices.DllImportSearchPath)(2050))]
[assembly:System.Security.AllowPartiallyTrustedCallersAttribute]
[assembly:System.Security.SecurityRulesAttribute((System.Security.SecurityRuleSet)(1), SkipVerificationInFullTrust=true)]
[assembly:System.Net.WebPermissionAttribute(System.Security.Permissions.SecurityAction.RequestMinimum, Unrestricted=true)]
[assembly:System.Security.Permissions.SecurityPermissionAttribute(System.Security.Permissions.SecurityAction.RequestMinimum, UnmanagedCode=true)]
[assembly:System.Security.Permissions.SecurityPermissionAttribute(System.Security.Permissions.SecurityAction.RequestMinimum, SkipVerification=true)]
[assembly:System.Security.Permissions.EnvironmentPermissionAttribute(System.Security.Permissions.SecurityAction.RequestMinimum, Unrestricted=true)]
[assembly:System.Net.NetworkInformation.NetworkInformationPermissionAttribute(System.Security.Permissions.SecurityAction.RequestMinimum, Unrestricted=true)]
[assembly:System.Security.Permissions.SecurityPermissionAttribute(System.Security.Permissions.SecurityAction.RequestMinimum, SkipVerification=true)]
namespace System.DirectoryServices.Protocols
{
    public partial class AddRequest : System.DirectoryServices.Protocols.DirectoryRequest
    {
        public AddRequest() { }
        public AddRequest(string distinguishedName, params System.DirectoryServices.Protocols.DirectoryAttribute[] attributes) { }
        public AddRequest(string distinguishedName, string objectClass) { }
        public System.DirectoryServices.Protocols.DirectoryAttributeCollection Attributes { get { throw null; } }
        public string DistinguishedName { get { throw null; } set { } }
        protected override System.Xml.XmlElement ToXmlNode(System.Xml.XmlDocument doc) { throw null; }
    }
    public partial class AddResponse : System.DirectoryServices.Protocols.DirectoryResponse
    {
        internal AddResponse() { }
    }
    public partial class AsqRequestControl : System.DirectoryServices.Protocols.DirectoryControl
    {
        public AsqRequestControl() : base (default(string), default(byte[]), default(bool), default(bool)) { }
        public AsqRequestControl(string attributeName) : base (default(string), default(byte[]), default(bool), default(bool)) { }
        public string AttributeName { get { throw null; } set { } }
        public override byte[] GetValue() { throw null; }
    }
    public partial class AsqResponseControl : System.DirectoryServices.Protocols.DirectoryControl
    {
        internal AsqResponseControl() : base (default(string), default(byte[]), default(bool), default(bool)) { }
        public System.DirectoryServices.Protocols.ResultCode Result { get { throw null; } }
    }
    public enum AuthType
    {
        Anonymous = 0,
        Basic = 1,
        Digest = 4,
        Dpa = 6,
        External = 8,
        Kerberos = 9,
        Msn = 7,
        Negotiate = 2,
        Ntlm = 3,
        Sicily = 5,
    }
    [System.SerializableAttribute]
    public partial class BerConversionException : System.DirectoryServices.Protocols.DirectoryException
    {
        public BerConversionException() { }
        protected BerConversionException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
        public BerConversionException(string message) { }
        public BerConversionException(string message, System.Exception inner) { }
    }
    public sealed partial class BerConverter
    {
        internal BerConverter() { }
        public static object[] Decode(string format, byte[] value) { throw null; }
        public static byte[] Encode(string format, params object[] value) { throw null; }
    }
    public partial class CompareRequest : System.DirectoryServices.Protocols.DirectoryRequest
    {
        public CompareRequest() { }
        public CompareRequest(string distinguishedName, System.DirectoryServices.Protocols.DirectoryAttribute assertion) { }
        public CompareRequest(string distinguishedName, string attributeName, byte[] value) { }
        public CompareRequest(string distinguishedName, string attributeName, string value) { }
        public CompareRequest(string distinguishedName, string attributeName, System.Uri value) { }
        public System.DirectoryServices.Protocols.DirectoryAttribute Assertion { get { throw null; } }
        public string DistinguishedName { get { throw null; } set { } }
        protected override System.Xml.XmlElement ToXmlNode(System.Xml.XmlDocument doc) { throw null; }
    }
    public partial class CompareResponse : System.DirectoryServices.Protocols.DirectoryResponse
    {
        internal CompareResponse() { }
    }
    public partial class CrossDomainMoveControl : System.DirectoryServices.Protocols.DirectoryControl
    {
        public CrossDomainMoveControl() : base (default(string), default(byte[]), default(bool), default(bool)) { }
        public CrossDomainMoveControl(string targetDomainController) : base (default(string), default(byte[]), default(bool), default(bool)) { }
        public string TargetDomainController { get { throw null; } set { } }
        public override byte[] GetValue() { throw null; }
    }
    public partial class DeleteRequest : System.DirectoryServices.Protocols.DirectoryRequest
    {
        public DeleteRequest() { }
        public DeleteRequest(string distinguishedName) { }
        public string DistinguishedName { get { throw null; } set { } }
        protected override System.Xml.XmlElement ToXmlNode(System.Xml.XmlDocument doc) { throw null; }
    }
    public partial class DeleteResponse : System.DirectoryServices.Protocols.DirectoryResponse
    {
        internal DeleteResponse() { }
    }
    public enum DereferenceAlias
    {
        Always = 3,
        FindingBaseObject = 2,
        InSearching = 1,
        Never = 0,
    }
    public delegate void DereferenceConnectionCallback(System.DirectoryServices.Protocols.LdapConnection primaryConnection, System.DirectoryServices.Protocols.LdapConnection connectionToDereference);
    public partial class DirectoryAttribute : System.Collections.CollectionBase
    {
        public DirectoryAttribute() { }
        public DirectoryAttribute(string name, byte[] value) { }
        public DirectoryAttribute(string name, params object[] values) { }
        public DirectoryAttribute(string name, string value) { }
        public DirectoryAttribute(string name, System.Uri value) { }
        public object this[int index] { get { throw null; } set { } }
        public string Name { get { throw null; } set { } }
        public int Add(byte[] value) { throw null; }
        public int Add(string value) { throw null; }
        public int Add(System.Uri value) { throw null; }
        public void AddRange(object[] values) { }
        public bool Contains(object value) { throw null; }
        public void CopyTo(object[] array, int index) { }
        public object[] GetValues(System.Type valuesType) { throw null; }
        public int IndexOf(object value) { throw null; }
        public void Insert(int index, byte[] value) { }
        public void Insert(int index, string value) { }
        public void Insert(int index, System.Uri value) { }
        protected override void OnValidate(object value) { }
        public void Remove(object value) { }
    }
    public partial class DirectoryAttributeCollection : System.Collections.CollectionBase
    {
        public DirectoryAttributeCollection() { }
        public System.DirectoryServices.Protocols.DirectoryAttribute this[int index] { get { throw null; } set { } }
        public int Add(System.DirectoryServices.Protocols.DirectoryAttribute attribute) { throw null; }
        public void AddRange(System.DirectoryServices.Protocols.DirectoryAttributeCollection attributeCollection) { }
        public void AddRange(System.DirectoryServices.Protocols.DirectoryAttribute[] attributes) { }
        public bool Contains(System.DirectoryServices.Protocols.DirectoryAttribute value) { throw null; }
        public void CopyTo(System.DirectoryServices.Protocols.DirectoryAttribute[] array, int index) { }
        public int IndexOf(System.DirectoryServices.Protocols.DirectoryAttribute value) { throw null; }
        public void Insert(int index, System.DirectoryServices.Protocols.DirectoryAttribute value) { }
        protected override void OnValidate(object value) { }
        public void Remove(System.DirectoryServices.Protocols.DirectoryAttribute value) { }
    }
    public partial class DirectoryAttributeModification : System.DirectoryServices.Protocols.DirectoryAttribute
    {
        public DirectoryAttributeModification() { }
        public System.DirectoryServices.Protocols.DirectoryAttributeOperation Operation { get { throw null; } set { } }
    }
    public partial class DirectoryAttributeModificationCollection : System.Collections.CollectionBase
    {
        public DirectoryAttributeModificationCollection() { }
        public System.DirectoryServices.Protocols.DirectoryAttributeModification this[int index] { get { throw null; } set { } }
        public int Add(System.DirectoryServices.Protocols.DirectoryAttributeModification attribute) { throw null; }
        public void AddRange(System.DirectoryServices.Protocols.DirectoryAttributeModificationCollection attributeCollection) { }
        public void AddRange(System.DirectoryServices.Protocols.DirectoryAttributeModification[] attributes) { }
        public bool Contains(System.DirectoryServices.Protocols.DirectoryAttributeModification value) { throw null; }
        public void CopyTo(System.DirectoryServices.Protocols.DirectoryAttributeModification[] array, int index) { }
        public int IndexOf(System.DirectoryServices.Protocols.DirectoryAttributeModification value) { throw null; }
        public void Insert(int index, System.DirectoryServices.Protocols.DirectoryAttributeModification value) { }
        protected override void OnValidate(object value) { }
        public void Remove(System.DirectoryServices.Protocols.DirectoryAttributeModification value) { }
    }
    public enum DirectoryAttributeOperation
    {
        Add = 0,
        Delete = 1,
        Replace = 2,
    }
    public abstract partial class DirectoryConnection
    {
        protected DirectoryConnection() { }
        public System.Security.Cryptography.X509Certificates.X509CertificateCollection ClientCertificates { get { throw null; } }
        public virtual System.Net.NetworkCredential Credential { [System.Security.Permissions.EnvironmentPermissionAttribute(System.Security.Permissions.SecurityAction.Assert, Unrestricted=true), System.Security.Permissions.SecurityPermissionAttribute(System.Security.Permissions.SecurityAction.Assert, Flags=(System.Security.Permissions.SecurityPermissionFlag)(2)), System.DirectoryServices.DirectoryServicesPermissionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Unrestricted=true)]set { } }
        public virtual System.DirectoryServices.Protocols.DirectoryIdentifier Directory { get { throw null; } }
        public virtual System.TimeSpan Timeout { get { throw null; } set { } }
        [System.DirectoryServices.DirectoryServicesPermissionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Unrestricted=true)]
        public abstract System.DirectoryServices.Protocols.DirectoryResponse SendRequest(System.DirectoryServices.Protocols.DirectoryRequest request);
    }
    public partial class DirectoryControl
    {
        public DirectoryControl(string type, byte[] value, bool isCritical, bool serverSide) { }
        public bool IsCritical { get { throw null; } set { } }
        public bool ServerSide { get { throw null; } set { } }
        public string Type { get { throw null; } }
        public virtual byte[] GetValue() { throw null; }
    }
    public partial class DirectoryControlCollection : System.Collections.CollectionBase
    {
        public DirectoryControlCollection() { }
        public System.DirectoryServices.Protocols.DirectoryControl this[int index] { get { throw null; } set { } }
        public int Add(System.DirectoryServices.Protocols.DirectoryControl control) { throw null; }
        public void AddRange(System.DirectoryServices.Protocols.DirectoryControlCollection controlCollection) { }
        public void AddRange(System.DirectoryServices.Protocols.DirectoryControl[] controls) { }
        public bool Contains(System.DirectoryServices.Protocols.DirectoryControl value) { throw null; }
        public void CopyTo(System.DirectoryServices.Protocols.DirectoryControl[] array, int index) { }
        public int IndexOf(System.DirectoryServices.Protocols.DirectoryControl value) { throw null; }
        public void Insert(int index, System.DirectoryServices.Protocols.DirectoryControl value) { }
        protected override void OnValidate(object value) { }
        public void Remove(System.DirectoryServices.Protocols.DirectoryControl value) { }
    }
    [System.SerializableAttribute]
    public partial class DirectoryException : System.Exception
    {
        public DirectoryException() { }
        protected DirectoryException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
        public DirectoryException(string message) { }
        public DirectoryException(string message, System.Exception inner) { }
    }
    public abstract partial class DirectoryIdentifier
    {
        protected DirectoryIdentifier() { }
    }
    public partial class DirectoryNotificationControl : System.DirectoryServices.Protocols.DirectoryControl
    {
        public DirectoryNotificationControl() : base (default(string), default(byte[]), default(bool), default(bool)) { }
    }
    public abstract partial class DirectoryOperation
    {
        protected DirectoryOperation() { }
    }
    [System.SerializableAttribute]
    public partial class DirectoryOperationException : System.DirectoryServices.Protocols.DirectoryException, System.Runtime.Serialization.ISerializable
    {
        public DirectoryOperationException() { }
        public DirectoryOperationException(System.DirectoryServices.Protocols.DirectoryResponse response) { }
        public DirectoryOperationException(System.DirectoryServices.Protocols.DirectoryResponse response, string message) { }
        public DirectoryOperationException(System.DirectoryServices.Protocols.DirectoryResponse response, string message, System.Exception inner) { }
        protected DirectoryOperationException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
        public DirectoryOperationException(string message) { }
        public DirectoryOperationException(string message, System.Exception inner) { }
        public System.DirectoryServices.Protocols.DirectoryResponse Response { get { throw null; } }
        [System.Security.Permissions.SecurityPermissionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, SerializationFormatter=true)]
        public override void GetObjectData(System.Runtime.Serialization.SerializationInfo serializationInfo, System.Runtime.Serialization.StreamingContext streamingContext) { }
    }
    public abstract partial class DirectoryRequest : System.DirectoryServices.Protocols.DirectoryOperation
    {
        internal DirectoryRequest() { }
        public System.DirectoryServices.Protocols.DirectoryControlCollection Controls { get { throw null; } }
        public string RequestId { get { throw null; } set { } }
        protected abstract System.Xml.XmlElement ToXmlNode(System.Xml.XmlDocument doc);
    }
    public abstract partial class DirectoryResponse : System.DirectoryServices.Protocols.DirectoryOperation
    {
        internal DirectoryResponse() { }
        public virtual System.DirectoryServices.Protocols.DirectoryControl[] Controls { get { throw null; } }
        public virtual string ErrorMessage { get { throw null; } }
        public virtual string MatchedDN { get { throw null; } }
        public virtual System.Uri[] Referral { get { throw null; } }
        public string RequestId { get { throw null; } }
        public virtual System.DirectoryServices.Protocols.ResultCode ResultCode { get { throw null; } }
    }
    [System.FlagsAttribute]
    public enum DirectorySynchronizationOptions : long
    {
        IncrementalValues = (long)2147483648,
        None = (long)0,
        ObjectSecurity = (long)1,
        ParentsFirst = (long)2048,
        PublicDataOnly = (long)8192,
    }
    public partial class DirSyncRequestControl : System.DirectoryServices.Protocols.DirectoryControl
    {
        public DirSyncRequestControl() : base (default(string), default(byte[]), default(bool), default(bool)) { }
        public DirSyncRequestControl(byte[] cookie) : base (default(string), default(byte[]), default(bool), default(bool)) { }
        public DirSyncRequestControl(byte[] cookie, System.DirectoryServices.Protocols.DirectorySynchronizationOptions option) : base (default(string), default(byte[]), default(bool), default(bool)) { }
        public DirSyncRequestControl(byte[] cookie, System.DirectoryServices.Protocols.DirectorySynchronizationOptions option, int attributeCount) : base (default(string), default(byte[]), default(bool), default(bool)) { }
        public int AttributeCount { get { throw null; } set { } }
        public byte[] Cookie { get { throw null; } set { } }
        public System.DirectoryServices.Protocols.DirectorySynchronizationOptions Option { get { throw null; } set { } }
        public override byte[] GetValue() { throw null; }
    }
    public partial class DirSyncResponseControl : System.DirectoryServices.Protocols.DirectoryControl
    {
        internal DirSyncResponseControl() : base (default(string), default(byte[]), default(bool), default(bool)) { }
        public byte[] Cookie { get { throw null; } }
        public bool MoreData { get { throw null; } }
        public int ResultSize { get { throw null; } }
    }
    public partial class DomainScopeControl : System.DirectoryServices.Protocols.DirectoryControl
    {
        public DomainScopeControl() : base (default(string), default(byte[]), default(bool), default(bool)) { }
    }
    public partial class DsmlAuthRequest : System.DirectoryServices.Protocols.DirectoryRequest
    {
        public DsmlAuthRequest() { }
        public DsmlAuthRequest(string principal) { }
        public string Principal { get { throw null; } set { } }
        protected override System.Xml.XmlElement ToXmlNode(System.Xml.XmlDocument doc) { throw null; }
    }
    public partial class DsmlAuthResponse : System.DirectoryServices.Protocols.DirectoryResponse
    {
        internal DsmlAuthResponse() { }
    }
    public partial class DsmlDirectoryIdentifier : System.DirectoryServices.Protocols.DirectoryIdentifier
    {
        public DsmlDirectoryIdentifier(System.Uri serverUri) { }
        public System.Uri ServerUri { get { throw null; } }
    }
    public abstract partial class DsmlDocument
    {
        protected DsmlDocument() { }
        public abstract System.Xml.XmlDocument ToXml();
    }
    public enum DsmlDocumentProcessing
    {
        Parallel = 1,
        Sequential = 0,
    }
    public enum DsmlErrorProcessing
    {
        Exit = 1,
        Resume = 0,
    }
    public partial class DsmlErrorResponse : System.DirectoryServices.Protocols.DirectoryResponse
    {
        internal DsmlErrorResponse() { }
        public override System.DirectoryServices.Protocols.DirectoryControl[] Controls { get { throw null; } }
        public string Detail { get { throw null; } }
        public override string ErrorMessage { get { throw null; } }
        public override string MatchedDN { get { throw null; } }
        public string Message { get { throw null; } }
        public override System.Uri[] Referral { get { throw null; } }
        public override System.DirectoryServices.Protocols.ResultCode ResultCode { get { throw null; } }
        public System.DirectoryServices.Protocols.ErrorResponseCategory Type { get { throw null; } }
    }
    [System.SerializableAttribute]
    public partial class DsmlInvalidDocumentException : System.DirectoryServices.Protocols.DirectoryException
    {
        public DsmlInvalidDocumentException() { }
        protected DsmlInvalidDocumentException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
        public DsmlInvalidDocumentException(string message) { }
        public DsmlInvalidDocumentException(string message, System.Exception inner) { }
    }
    public partial class DsmlRequestDocument : System.DirectoryServices.Protocols.DsmlDocument, System.Collections.ICollection, System.Collections.IEnumerable, System.Collections.IList
    {
        public DsmlRequestDocument() { }
        public int Count { get { throw null; } }
        public System.DirectoryServices.Protocols.DsmlDocumentProcessing DocumentProcessing { get { throw null; } set { } }
        public System.DirectoryServices.Protocols.DsmlErrorProcessing ErrorProcessing { get { throw null; } set { } }
        protected bool IsFixedSize { get { throw null; } }
        protected bool IsReadOnly { get { throw null; } }
        protected bool IsSynchronized { get { throw null; } }
        public System.DirectoryServices.Protocols.DirectoryRequest this[int index] { get { throw null; } set { } }
        public string RequestId { get { throw null; } set { } }
        public System.DirectoryServices.Protocols.DsmlResponseOrder ResponseOrder { get { throw null; } set { } }
        protected object SyncRoot { get { throw null; } }
        int System.Collections.ICollection.Count { get { throw null; } }
        bool System.Collections.ICollection.IsSynchronized { get { throw null; } }
        object System.Collections.ICollection.SyncRoot { get { throw null; } }
        bool System.Collections.IList.IsFixedSize { get { throw null; } }
        bool System.Collections.IList.IsReadOnly { get { throw null; } }
        object System.Collections.IList.this[int index] { get { throw null; } set { } }
        public int Add(System.DirectoryServices.Protocols.DirectoryRequest request) { throw null; }
        public void Clear() { }
        public bool Contains(System.DirectoryServices.Protocols.DirectoryRequest value) { throw null; }
        public void CopyTo(System.DirectoryServices.Protocols.DirectoryRequest[] value, int i) { }
        public System.Collections.IEnumerator GetEnumerator() { throw null; }
        public int IndexOf(System.DirectoryServices.Protocols.DirectoryRequest value) { throw null; }
        public void Insert(int index, System.DirectoryServices.Protocols.DirectoryRequest value) { }
        public void Remove(System.DirectoryServices.Protocols.DirectoryRequest value) { }
        public void RemoveAt(int index) { }
        void System.Collections.ICollection.CopyTo(System.Array value, int i) { }
        int System.Collections.IList.Add(object request) { throw null; }
        void System.Collections.IList.Clear() { }
        bool System.Collections.IList.Contains(object value) { throw null; }
        int System.Collections.IList.IndexOf(object value) { throw null; }
        void System.Collections.IList.Insert(int index, object value) { }
        void System.Collections.IList.Remove(object value) { }
        void System.Collections.IList.RemoveAt(int index) { }
        public override System.Xml.XmlDocument ToXml() { throw null; }
    }
    public partial class DsmlResponseDocument : System.DirectoryServices.Protocols.DsmlDocument, System.Collections.ICollection, System.Collections.IEnumerable
    {
        internal DsmlResponseDocument() { }
        public int Count { get { throw null; } }
        public bool IsErrorResponse { get { throw null; } }
        public bool IsOperationError { get { throw null; } }
        protected bool IsSynchronized { get { throw null; } }
        public System.DirectoryServices.Protocols.DirectoryResponse this[int index] { get { throw null; } }
        public string RequestId { get { throw null; } }
        protected object SyncRoot { get { throw null; } }
        int System.Collections.ICollection.Count { get { throw null; } }
        bool System.Collections.ICollection.IsSynchronized { get { throw null; } }
        object System.Collections.ICollection.SyncRoot { get { throw null; } }
        public void CopyTo(System.DirectoryServices.Protocols.DirectoryResponse[] value, int i) { }
        public System.Collections.IEnumerator GetEnumerator() { throw null; }
        void System.Collections.ICollection.CopyTo(System.Array value, int i) { }
        public override System.Xml.XmlDocument ToXml() { throw null; }
    }
    public enum DsmlResponseOrder
    {
        Sequential = 0,
        Unordered = 1,
    }
    public abstract partial class DsmlSoapConnection : System.DirectoryServices.Protocols.DirectoryConnection
    {
        protected DsmlSoapConnection() { }
        public abstract string SessionId { get; }
        public System.Xml.XmlNode SoapRequestHeader { get { throw null; } set { } }
        [System.DirectoryServices.DirectoryServicesPermissionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Unrestricted=true)]
        public abstract void BeginSession();
        [System.DirectoryServices.DirectoryServicesPermissionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Unrestricted=true)]
        public abstract void EndSession();
    }
    public partial class DsmlSoapHttpConnection : System.DirectoryServices.Protocols.DsmlSoapConnection
    {
        [System.Net.WebPermissionAttribute(System.Security.Permissions.SecurityAction.Assert, Unrestricted=true)]
        [System.DirectoryServices.DirectoryServicesPermissionAttribute(System.Security.Permissions.SecurityAction.Demand, Unrestricted=true)]
        public DsmlSoapHttpConnection(System.DirectoryServices.Protocols.DsmlDirectoryIdentifier identifier) { }
        [System.Security.Permissions.EnvironmentPermissionAttribute(System.Security.Permissions.SecurityAction.Assert, Unrestricted=true)]
        [System.Security.Permissions.SecurityPermissionAttribute(System.Security.Permissions.SecurityAction.Assert, Flags=(System.Security.Permissions.SecurityPermissionFlag)(2))]
        [System.DirectoryServices.DirectoryServicesPermissionAttribute(System.Security.Permissions.SecurityAction.Demand, Unrestricted=true)]
        public DsmlSoapHttpConnection(System.DirectoryServices.Protocols.DsmlDirectoryIdentifier identifier, System.Net.NetworkCredential credential) { }
        [System.DirectoryServices.DirectoryServicesPermissionAttribute(System.Security.Permissions.SecurityAction.Demand, Unrestricted=true)]
        public DsmlSoapHttpConnection(System.DirectoryServices.Protocols.DsmlDirectoryIdentifier identifier, System.Net.NetworkCredential credential, System.DirectoryServices.Protocols.AuthType authType) { }
        [System.DirectoryServices.DirectoryServicesPermissionAttribute(System.Security.Permissions.SecurityAction.Demand, Unrestricted=true)]
        public DsmlSoapHttpConnection(System.Uri uri) { }
        public System.DirectoryServices.Protocols.AuthType AuthType { get { throw null; } set { } }
        public override string SessionId { get { throw null; } }
        public string SoapActionHeader { get { throw null; } set { } }
        public override System.TimeSpan Timeout { get { throw null; } set { } }
        [System.DirectoryServices.DirectoryServicesPermissionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Unrestricted=true)]
        public void Abort(System.IAsyncResult asyncResult) { }
        [System.Net.WebPermissionAttribute(System.Security.Permissions.SecurityAction.Assert, Unrestricted=true)]
        [System.Net.NetworkInformation.NetworkInformationPermissionAttribute(System.Security.Permissions.SecurityAction.Assert, Unrestricted=true)]
        [System.DirectoryServices.DirectoryServicesPermissionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Unrestricted=true)]
        public System.IAsyncResult BeginSendRequest(System.DirectoryServices.Protocols.DsmlRequestDocument request, System.AsyncCallback callback, object state) { throw null; }
        [System.Net.WebPermissionAttribute(System.Security.Permissions.SecurityAction.Assert, Unrestricted=true)]
        [System.Net.NetworkInformation.NetworkInformationPermissionAttribute(System.Security.Permissions.SecurityAction.Assert, Unrestricted=true)]
        [System.DirectoryServices.DirectoryServicesPermissionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Unrestricted=true)]
        public override void BeginSession() { }
        public System.DirectoryServices.Protocols.DsmlResponseDocument EndSendRequest(System.IAsyncResult asyncResult) { throw null; }
        [System.Net.WebPermissionAttribute(System.Security.Permissions.SecurityAction.Assert, Unrestricted=true)]
        [System.Net.NetworkInformation.NetworkInformationPermissionAttribute(System.Security.Permissions.SecurityAction.Assert, Unrestricted=true)]
        [System.DirectoryServices.DirectoryServicesPermissionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Unrestricted=true)]
        public override void EndSession() { }
        [System.DirectoryServices.DirectoryServicesPermissionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Unrestricted=true)]
        public override System.DirectoryServices.Protocols.DirectoryResponse SendRequest(System.DirectoryServices.Protocols.DirectoryRequest request) { throw null; }
        [System.DirectoryServices.DirectoryServicesPermissionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Unrestricted=true)]
        public System.DirectoryServices.Protocols.DsmlResponseDocument SendRequest(System.DirectoryServices.Protocols.DsmlRequestDocument request) { throw null; }
    }
    public enum ErrorResponseCategory
    {
        AuthenticationFailed = 5,
        ConnectionClosed = 2,
        CouldNotConnect = 1,
        GatewayInternalError = 4,
        MalformedRequest = 3,
        NotAttempted = 0,
        Other = 7,
        UnresolvableUri = 6,
    }
    [System.SerializableAttribute]
    public partial class ErrorResponseException : System.DirectoryServices.Protocols.DirectoryException, System.Runtime.Serialization.ISerializable
    {
        public ErrorResponseException() { }
        public ErrorResponseException(System.DirectoryServices.Protocols.DsmlErrorResponse response) { }
        public ErrorResponseException(System.DirectoryServices.Protocols.DsmlErrorResponse response, string message) { }
        public ErrorResponseException(System.DirectoryServices.Protocols.DsmlErrorResponse response, string message, System.Exception inner) { }
        protected ErrorResponseException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
        public ErrorResponseException(string message) { }
        public ErrorResponseException(string message, System.Exception inner) { }
        public System.DirectoryServices.Protocols.DsmlErrorResponse Response { get { throw null; } }
        [System.Security.Permissions.SecurityPermissionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, SerializationFormatter=true)]
        public override void GetObjectData(System.Runtime.Serialization.SerializationInfo serializationInfo, System.Runtime.Serialization.StreamingContext streamingContext) { }
    }
    public partial class ExtendedDNControl : System.DirectoryServices.Protocols.DirectoryControl
    {
        public ExtendedDNControl() : base (default(string), default(byte[]), default(bool), default(bool)) { }
        public ExtendedDNControl(System.DirectoryServices.Protocols.ExtendedDNFlag flag) : base (default(string), default(byte[]), default(bool), default(bool)) { }
        public System.DirectoryServices.Protocols.ExtendedDNFlag Flag { get { throw null; } set { } }
        public override byte[] GetValue() { throw null; }
    }
    public enum ExtendedDNFlag
    {
        HexString = 0,
        StandardString = 1,
    }
    public partial class ExtendedRequest : System.DirectoryServices.Protocols.DirectoryRequest
    {
        public ExtendedRequest() { }
        public ExtendedRequest(string requestName) { }
        public ExtendedRequest(string requestName, byte[] requestValue) { }
        public string RequestName { get { throw null; } set { } }
        public byte[] RequestValue { get { throw null; } set { } }
        protected override System.Xml.XmlElement ToXmlNode(System.Xml.XmlDocument doc) { throw null; }
    }
    public partial class ExtendedResponse : System.DirectoryServices.Protocols.DirectoryResponse
    {
        internal ExtendedResponse() { }
        public string ResponseName { get { throw null; } }
        public byte[] ResponseValue { get { throw null; } }
    }
    public partial class LazyCommitControl : System.DirectoryServices.Protocols.DirectoryControl
    {
        public LazyCommitControl() : base (default(string), default(byte[]), default(bool), default(bool)) { }
    }
    public partial class LdapConnection : System.DirectoryServices.Protocols.DirectoryConnection, System.IDisposable
    {
        [System.DirectoryServices.DirectoryServicesPermissionAttribute(System.Security.Permissions.SecurityAction.Demand, Unrestricted=true)]
        public LdapConnection(System.DirectoryServices.Protocols.LdapDirectoryIdentifier identifier) { }
        [System.DirectoryServices.DirectoryServicesPermissionAttribute(System.Security.Permissions.SecurityAction.Demand, Unrestricted=true)]
        public LdapConnection(System.DirectoryServices.Protocols.LdapDirectoryIdentifier identifier, System.Net.NetworkCredential credential) { }
        [System.Security.Permissions.EnvironmentPermissionAttribute(System.Security.Permissions.SecurityAction.Assert, Unrestricted=true)]
        [System.Security.Permissions.SecurityPermissionAttribute(System.Security.Permissions.SecurityAction.Assert, Flags=(System.Security.Permissions.SecurityPermissionFlag)(2))]
        [System.DirectoryServices.DirectoryServicesPermissionAttribute(System.Security.Permissions.SecurityAction.Demand, Unrestricted=true)]
        public LdapConnection(System.DirectoryServices.Protocols.LdapDirectoryIdentifier identifier, System.Net.NetworkCredential credential, System.DirectoryServices.Protocols.AuthType authType) { }
        [System.DirectoryServices.DirectoryServicesPermissionAttribute(System.Security.Permissions.SecurityAction.Demand, Unrestricted=true)]
        public LdapConnection(string server) { }
        public System.DirectoryServices.Protocols.AuthType AuthType { get { throw null; } set { } }
        public bool AutoBind { get { throw null; } set { } }
        public override System.Net.NetworkCredential Credential { [System.Security.Permissions.EnvironmentPermissionAttribute(System.Security.Permissions.SecurityAction.Assert, Unrestricted=true), System.Security.Permissions.SecurityPermissionAttribute(System.Security.Permissions.SecurityAction.Assert, Flags=(System.Security.Permissions.SecurityPermissionFlag)(2)), System.DirectoryServices.DirectoryServicesPermissionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Unrestricted=true)]set { } }
        public System.DirectoryServices.Protocols.LdapSessionOptions SessionOptions { get { throw null; } }
        public override System.TimeSpan Timeout { get { throw null; } set { } }
        [System.DirectoryServices.DirectoryServicesPermissionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Unrestricted=true)]
        public void Abort(System.IAsyncResult asyncResult) { }
        [System.DirectoryServices.DirectoryServicesPermissionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Unrestricted=true)]
        public System.IAsyncResult BeginSendRequest(System.DirectoryServices.Protocols.DirectoryRequest request, System.DirectoryServices.Protocols.PartialResultProcessing partialMode, System.AsyncCallback callback, object state) { throw null; }
        [System.DirectoryServices.DirectoryServicesPermissionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Unrestricted=true)]
        public System.IAsyncResult BeginSendRequest(System.DirectoryServices.Protocols.DirectoryRequest request, System.TimeSpan requestTimeout, System.DirectoryServices.Protocols.PartialResultProcessing partialMode, System.AsyncCallback callback, object state) { throw null; }
        [System.DirectoryServices.DirectoryServicesPermissionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Unrestricted=true)]
        public void Bind() { }
        [System.DirectoryServices.DirectoryServicesPermissionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Unrestricted=true)]
        public void Bind(System.Net.NetworkCredential newCredential) { }
        public void Dispose() { }
        protected virtual void Dispose(bool disposing) { }
        public System.DirectoryServices.Protocols.DirectoryResponse EndSendRequest(System.IAsyncResult asyncResult) { throw null; }
        ~LdapConnection() { }
        public System.DirectoryServices.Protocols.PartialResultsCollection GetPartialResults(System.IAsyncResult asyncResult) { throw null; }
        [System.DirectoryServices.DirectoryServicesPermissionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Unrestricted=true)]
        public override System.DirectoryServices.Protocols.DirectoryResponse SendRequest(System.DirectoryServices.Protocols.DirectoryRequest request) { throw null; }
        [System.DirectoryServices.DirectoryServicesPermissionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Unrestricted=true)]
        public System.DirectoryServices.Protocols.DirectoryResponse SendRequest(System.DirectoryServices.Protocols.DirectoryRequest request, System.TimeSpan requestTimeout) { throw null; }
    }
    public partial class LdapDirectoryIdentifier : System.DirectoryServices.Protocols.DirectoryIdentifier
    {
        public LdapDirectoryIdentifier(string server) { }
        public LdapDirectoryIdentifier(string server, bool fullyQualifiedDnsHostName, bool connectionless) { }
        public LdapDirectoryIdentifier(string server, int portNumber) { }
        public LdapDirectoryIdentifier(string server, int portNumber, bool fullyQualifiedDnsHostName, bool connectionless) { }
        public LdapDirectoryIdentifier(string[] servers, bool fullyQualifiedDnsHostName, bool connectionless) { }
        public LdapDirectoryIdentifier(string[] servers, int portNumber, bool fullyQualifiedDnsHostName, bool connectionless) { }
        public bool Connectionless { get { throw null; } }
        public bool FullyQualifiedDnsHostName { get { throw null; } }
        public int PortNumber { get { throw null; } }
        public string[] Servers { get { throw null; } }
    }
    [System.SerializableAttribute]
    public partial class LdapException : System.DirectoryServices.Protocols.DirectoryException, System.Runtime.Serialization.ISerializable
    {
        public LdapException() { }
        public LdapException(int errorCode) { }
        public LdapException(int errorCode, string message) { }
        public LdapException(int errorCode, string message, System.Exception inner) { }
        public LdapException(int errorCode, string message, string serverErrorMessage) { }
        protected LdapException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
        public LdapException(string message) { }
        public LdapException(string message, System.Exception inner) { }
        public int ErrorCode { get { throw null; } }
        public System.DirectoryServices.Protocols.PartialResultsCollection PartialResults { get { throw null; } }
        public string ServerErrorMessage { get { throw null; } }
        [System.Security.Permissions.SecurityPermissionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, SerializationFormatter=true)]
        public override void GetObjectData(System.Runtime.Serialization.SerializationInfo serializationInfo, System.Runtime.Serialization.StreamingContext streamingContext) { }
    }
    public partial class LdapSessionOptions
    {
        internal LdapSessionOptions() { }
        public bool AutoReconnect { get { throw null; } set { } }
        public string DomainName { get { throw null; } set { } }
        public string HostName { get { throw null; } set { } }
        public bool HostReachable { get { throw null; } }
        public System.DirectoryServices.Protocols.LocatorFlags LocatorFlag { get { throw null; } set { } }
        public System.TimeSpan PingKeepAliveTimeout { get { throw null; } set { } }
        public int PingLimit { get { throw null; } set { } }
        public System.TimeSpan PingWaitTimeout { get { throw null; } set { } }
        public int ProtocolVersion { get { throw null; } set { } }
        public System.DirectoryServices.Protocols.QueryClientCertificateCallback QueryClientCertificate { get { throw null; } set { } }
        public System.DirectoryServices.Protocols.ReferralCallback ReferralCallback { get { throw null; } set { } }
        public System.DirectoryServices.Protocols.ReferralChasingOptions ReferralChasing { get { throw null; } set { } }
        public int ReferralHopLimit { get { throw null; } set { } }
        public bool RootDseCache { get { throw null; } set { } }
        public string SaslMethod { get { throw null; } set { } }
        public bool Sealing { get { throw null; } set { } }
        public bool SecureSocketLayer { get { throw null; } set { } }
        public object SecurityContext { get { throw null; } }
        public System.TimeSpan SendTimeout { get { throw null; } set { } }
        public bool Signing { get { throw null; } set { } }
        public System.DirectoryServices.Protocols.SecurityPackageContextConnectionInformation SslInformation { get { throw null; } }
        public int SspiFlag { get { throw null; } set { } }
        public bool TcpKeepAlive { get { throw null; } set { } }
        public System.DirectoryServices.Protocols.VerifyServerCertificateCallback VerifyServerCertificate { get { throw null; } set { } }
        public void FastConcurrentBind() { }
        public void StartTransportLayerSecurity(System.DirectoryServices.Protocols.DirectoryControlCollection controls) { }
        public void StopTransportLayerSecurity() { }
    }
    [System.FlagsAttribute]
    public enum LocatorFlags : long
    {
        AvoidSelf = (long)16384,
        DirectoryServicesPreferred = (long)32,
        DirectoryServicesRequired = (long)16,
        ForceRediscovery = (long)1,
        GCRequired = (long)64,
        GoodTimeServerPreferred = (long)8192,
        IPRequired = (long)512,
        IsDnsName = (long)131072,
        IsFlatName = (long)65536,
        KdcRequired = (long)1024,
        None = (long)0,
        OnlyLdapNeeded = (long)32768,
        PdcRequired = (long)128,
        ReturnDnsName = (long)1073741824,
        ReturnFlatName = (long)2147483648,
        TimeServerRequired = (long)2048,
        WriteableRequired = (long)4096,
    }
    public partial class ModifyDNRequest : System.DirectoryServices.Protocols.DirectoryRequest
    {
        public ModifyDNRequest() { }
        public ModifyDNRequest(string distinguishedName, string newParentDistinguishedName, string newName) { }
        public bool DeleteOldRdn { get { throw null; } set { } }
        public string DistinguishedName { get { throw null; } set { } }
        public string NewName { get { throw null; } set { } }
        public string NewParentDistinguishedName { get { throw null; } set { } }
        protected override System.Xml.XmlElement ToXmlNode(System.Xml.XmlDocument doc) { throw null; }
    }
    public partial class ModifyDNResponse : System.DirectoryServices.Protocols.DirectoryResponse
    {
        internal ModifyDNResponse() { }
    }
    public partial class ModifyRequest : System.DirectoryServices.Protocols.DirectoryRequest
    {
        public ModifyRequest() { }
        public ModifyRequest(string distinguishedName, params System.DirectoryServices.Protocols.DirectoryAttributeModification[] modifications) { }
        public ModifyRequest(string distinguishedName, System.DirectoryServices.Protocols.DirectoryAttributeOperation operation, string attributeName, params object[] values) { }
        public string DistinguishedName { get { throw null; } set { } }
        public System.DirectoryServices.Protocols.DirectoryAttributeModificationCollection Modifications { get { throw null; } }
        protected override System.Xml.XmlElement ToXmlNode(System.Xml.XmlDocument doc) { throw null; }
    }
    public partial class ModifyResponse : System.DirectoryServices.Protocols.DirectoryResponse
    {
        internal ModifyResponse() { }
    }
    public delegate bool NotifyOfNewConnectionCallback(System.DirectoryServices.Protocols.LdapConnection primaryConnection, System.DirectoryServices.Protocols.LdapConnection referralFromConnection, string newDistinguishedName, System.DirectoryServices.Protocols.LdapDirectoryIdentifier identifier, System.DirectoryServices.Protocols.LdapConnection newConnection, System.Net.NetworkCredential credential, long currentUserToken, int errorCodeFromBind);
    public partial class PageResultRequestControl : System.DirectoryServices.Protocols.DirectoryControl
    {
        public PageResultRequestControl() : base (default(string), default(byte[]), default(bool), default(bool)) { }
        public PageResultRequestControl(byte[] cookie) : base (default(string), default(byte[]), default(bool), default(bool)) { }
        public PageResultRequestControl(int pageSize) : base (default(string), default(byte[]), default(bool), default(bool)) { }
        public byte[] Cookie { get { throw null; } set { } }
        public int PageSize { get { throw null; } set { } }
        public override byte[] GetValue() { throw null; }
    }
    public partial class PageResultResponseControl : System.DirectoryServices.Protocols.DirectoryControl
    {
        internal PageResultResponseControl() : base (default(string), default(byte[]), default(bool), default(bool)) { }
        public byte[] Cookie { get { throw null; } }
        public int TotalCount { get { throw null; } }
    }
    public enum PartialResultProcessing
    {
        NoPartialResultSupport = 0,
        ReturnPartialResults = 1,
        ReturnPartialResultsAndNotifyCallback = 2,
    }
    public partial class PartialResultsCollection : System.Collections.ReadOnlyCollectionBase
    {
        internal PartialResultsCollection() { }
        public object this[int index] { get { throw null; } }
        public bool Contains(object value) { throw null; }
        public void CopyTo(object[] values, int index) { }
        public int IndexOf(object value) { throw null; }
    }
    public partial class PermissiveModifyControl : System.DirectoryServices.Protocols.DirectoryControl
    {
        public PermissiveModifyControl() : base (default(string), default(byte[]), default(bool), default(bool)) { }
    }
    public delegate System.Security.Cryptography.X509Certificates.X509Certificate QueryClientCertificateCallback(System.DirectoryServices.Protocols.LdapConnection connection, byte[][] trustedCAs);
    public delegate System.DirectoryServices.Protocols.LdapConnection QueryForConnectionCallback(System.DirectoryServices.Protocols.LdapConnection primaryConnection, System.DirectoryServices.Protocols.LdapConnection referralFromConnection, string newDistinguishedName, System.DirectoryServices.Protocols.LdapDirectoryIdentifier identifier, System.Net.NetworkCredential credential, long currentUserToken);
    public partial class QuotaControl : System.DirectoryServices.Protocols.DirectoryControl
    {
        public QuotaControl() : base (default(string), default(byte[]), default(bool), default(bool)) { }
        public QuotaControl(System.Security.Principal.SecurityIdentifier querySid) : base (default(string), default(byte[]), default(bool), default(bool)) { }
        public System.Security.Principal.SecurityIdentifier QuerySid { get { throw null; } set { } }
        public override byte[] GetValue() { throw null; }
    }
    public sealed partial class ReferralCallback
    {
        public ReferralCallback() { }
        public System.DirectoryServices.Protocols.DereferenceConnectionCallback DereferenceConnection { get { throw null; } set { } }
        public System.DirectoryServices.Protocols.NotifyOfNewConnectionCallback NotifyNewConnection { get { throw null; } set { } }
        public System.DirectoryServices.Protocols.QueryForConnectionCallback QueryForConnection { get { throw null; } set { } }
    }
    [System.FlagsAttribute]
    public enum ReferralChasingOptions
    {
        All = 96,
        External = 64,
        None = 0,
        Subordinate = 32,
    }
    public enum ResultCode
    {
        AdminLimitExceeded = 11,
        AffectsMultipleDsas = 71,
        AliasDereferencingProblem = 36,
        AliasProblem = 33,
        AttributeOrValueExists = 20,
        AuthMethodNotSupported = 7,
        Busy = 51,
        CompareFalse = 5,
        CompareTrue = 6,
        ConfidentialityRequired = 13,
        ConstraintViolation = 19,
        EntryAlreadyExists = 68,
        InappropriateAuthentication = 48,
        InappropriateMatching = 18,
        InsufficientAccessRights = 50,
        InvalidAttributeSyntax = 21,
        InvalidDNSyntax = 34,
        LoopDetect = 54,
        NamingViolation = 64,
        NoSuchAttribute = 16,
        NoSuchObject = 32,
        NotAllowedOnNonLeaf = 66,
        NotAllowedOnRdn = 67,
        ObjectClassModificationsProhibited = 69,
        ObjectClassViolation = 65,
        OffsetRangeError = 61,
        OperationsError = 1,
        Other = 80,
        ProtocolError = 2,
        Referral = 10,
        ReferralV2 = 9,
        ResultsTooLarge = 70,
        SaslBindInProgress = 14,
        SizeLimitExceeded = 4,
        SortControlMissing = 60,
        StrongAuthRequired = 8,
        Success = 0,
        TimeLimitExceeded = 3,
        Unavailable = 52,
        UnavailableCriticalExtension = 12,
        UndefinedAttributeType = 17,
        UnwillingToPerform = 53,
        VirtualListViewError = 76,
    }
    public enum SearchOption
    {
        DomainScope = 1,
        PhantomRoot = 2,
    }
    public partial class SearchOptionsControl : System.DirectoryServices.Protocols.DirectoryControl
    {
        public SearchOptionsControl() : base (default(string), default(byte[]), default(bool), default(bool)) { }
        public SearchOptionsControl(System.DirectoryServices.Protocols.SearchOption flags) : base (default(string), default(byte[]), default(bool), default(bool)) { }
        public System.DirectoryServices.Protocols.SearchOption SearchOption { get { throw null; } set { } }
        public override byte[] GetValue() { throw null; }
    }
    public partial class SearchRequest : System.DirectoryServices.Protocols.DirectoryRequest
    {
        public SearchRequest() { }
        public SearchRequest(string distinguishedName, string ldapFilter, System.DirectoryServices.Protocols.SearchScope searchScope, params string[] attributeList) { }
        public SearchRequest(string distinguishedName, System.Xml.XmlDocument filter, System.DirectoryServices.Protocols.SearchScope searchScope, params string[] attributeList) { }
        public System.DirectoryServices.Protocols.DereferenceAlias Aliases { get { throw null; } set { } }
        public System.Collections.Specialized.StringCollection Attributes { get { throw null; } }
        public string DistinguishedName { get { throw null; } set { } }
        public object Filter { get { throw null; } set { } }
        public System.DirectoryServices.Protocols.SearchScope Scope { get { throw null; } set { } }
        public int SizeLimit { get { throw null; } set { } }
        public System.TimeSpan TimeLimit { get { throw null; } set { } }
        public bool TypesOnly { get { throw null; } set { } }
        protected override System.Xml.XmlElement ToXmlNode(System.Xml.XmlDocument doc) { throw null; }
    }
    public partial class SearchResponse : System.DirectoryServices.Protocols.DirectoryResponse
    {
        internal SearchResponse() { }
        public override System.DirectoryServices.Protocols.DirectoryControl[] Controls { get { throw null; } }
        public System.DirectoryServices.Protocols.SearchResultEntryCollection Entries { get { throw null; } }
        public override string ErrorMessage { get { throw null; } }
        public override string MatchedDN { get { throw null; } }
        public System.DirectoryServices.Protocols.SearchResultReferenceCollection References { get { throw null; } }
        public override System.Uri[] Referral { get { throw null; } }
        public override System.DirectoryServices.Protocols.ResultCode ResultCode { get { throw null; } }
    }
    public partial class SearchResultAttributeCollection : System.Collections.DictionaryBase
    {
        internal SearchResultAttributeCollection() { }
        public System.Collections.ICollection AttributeNames { get { throw null; } }
        public System.DirectoryServices.Protocols.DirectoryAttribute this[string attributeName] { get { throw null; } }
        public System.Collections.ICollection Values { get { throw null; } }
        public bool Contains(string attributeName) { throw null; }
        public void CopyTo(System.DirectoryServices.Protocols.DirectoryAttribute[] array, int index) { }
    }
    public partial class SearchResultEntry
    {
        internal SearchResultEntry() { }
        public System.DirectoryServices.Protocols.SearchResultAttributeCollection Attributes { get { throw null; } }
        public System.DirectoryServices.Protocols.DirectoryControl[] Controls { get { throw null; } }
        public string DistinguishedName { get { throw null; } }
    }
    public partial class SearchResultEntryCollection : System.Collections.ReadOnlyCollectionBase
    {
        internal SearchResultEntryCollection() { }
        public System.DirectoryServices.Protocols.SearchResultEntry this[int index] { get { throw null; } }
        public bool Contains(System.DirectoryServices.Protocols.SearchResultEntry value) { throw null; }
        public void CopyTo(System.DirectoryServices.Protocols.SearchResultEntry[] values, int index) { }
        public int IndexOf(System.DirectoryServices.Protocols.SearchResultEntry value) { throw null; }
    }
    public partial class SearchResultReference
    {
        internal SearchResultReference() { }
        public System.DirectoryServices.Protocols.DirectoryControl[] Controls { get { throw null; } }
        public System.Uri[] Reference { get { throw null; } }
    }
    public partial class SearchResultReferenceCollection : System.Collections.ReadOnlyCollectionBase
    {
        internal SearchResultReferenceCollection() { }
        public System.DirectoryServices.Protocols.SearchResultReference this[int index] { get { throw null; } }
        public bool Contains(System.DirectoryServices.Protocols.SearchResultReference value) { throw null; }
        public void CopyTo(System.DirectoryServices.Protocols.SearchResultReference[] values, int index) { }
        public int IndexOf(System.DirectoryServices.Protocols.SearchResultReference value) { throw null; }
    }
    public enum SearchScope
    {
        Base = 0,
        OneLevel = 1,
        Subtree = 2,
    }
    public partial class SecurityDescriptorFlagControl : System.DirectoryServices.Protocols.DirectoryControl
    {
        public SecurityDescriptorFlagControl() : base (default(string), default(byte[]), default(bool), default(bool)) { }
        public SecurityDescriptorFlagControl(System.DirectoryServices.Protocols.SecurityMasks masks) : base (default(string), default(byte[]), default(bool), default(bool)) { }
        public System.DirectoryServices.Protocols.SecurityMasks SecurityMasks { get { throw null; } set { } }
        public override byte[] GetValue() { throw null; }
    }
    [System.FlagsAttribute]
    public enum SecurityMasks
    {
        Dacl = 4,
        Group = 2,
        None = 0,
        Owner = 1,
        Sacl = 8,
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential, CharSet=System.Runtime.InteropServices.CharSet.Unicode)]
    public partial class SecurityPackageContextConnectionInformation
    {
        internal SecurityPackageContextConnectionInformation() { }
        public System.Security.Authentication.CipherAlgorithmType AlgorithmIdentifier { get { throw null; } }
        public int CipherStrength { get { throw null; } }
        public int ExchangeStrength { get { throw null; } }
        public System.Security.Authentication.HashAlgorithmType Hash { get { throw null; } }
        public int HashStrength { get { throw null; } }
        public int KeyExchangeAlgorithm { get { throw null; } }
        public System.DirectoryServices.Protocols.SecurityProtocol Protocol { get { throw null; } }
    }
    public enum SecurityProtocol
    {
        Pct1Client = 2,
        Pct1Server = 1,
        Ssl2Client = 8,
        Ssl2Server = 4,
        Ssl3Client = 32,
        Ssl3Server = 16,
        Tls1Client = 128,
        Tls1Server = 64,
    }
    public partial class ShowDeletedControl : System.DirectoryServices.Protocols.DirectoryControl
    {
        public ShowDeletedControl() : base (default(string), default(byte[]), default(bool), default(bool)) { }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential, CharSet=System.Runtime.InteropServices.CharSet.Unicode)]
    public partial class SortKey
    {
        public SortKey() { }
        public SortKey(string attributeName, string matchingRule, bool reverseOrder) { }
        public string AttributeName { get { throw null; } set { } }
        public string MatchingRule { get { throw null; } set { } }
        public bool ReverseOrder { get { throw null; } set { } }
    }
    public partial class SortRequestControl : System.DirectoryServices.Protocols.DirectoryControl
    {
        public SortRequestControl(params System.DirectoryServices.Protocols.SortKey[] sortKeys) : base (default(string), default(byte[]), default(bool), default(bool)) { }
        public SortRequestControl(string attributeName, bool reverseOrder) : base (default(string), default(byte[]), default(bool), default(bool)) { }
        public SortRequestControl(string attributeName, string matchingRule, bool reverseOrder) : base (default(string), default(byte[]), default(bool), default(bool)) { }
        public System.DirectoryServices.Protocols.SortKey[] SortKeys { get { throw null; } set { } }
        public override byte[] GetValue() { throw null; }
    }
    public partial class SortResponseControl : System.DirectoryServices.Protocols.DirectoryControl
    {
        internal SortResponseControl() : base (default(string), default(byte[]), default(bool), default(bool)) { }
        public string AttributeName { get { throw null; } }
        public System.DirectoryServices.Protocols.ResultCode Result { get { throw null; } }
    }
    [System.SerializableAttribute]
    public partial class TlsOperationException : System.DirectoryServices.Protocols.DirectoryOperationException
    {
        public TlsOperationException() { }
        public TlsOperationException(System.DirectoryServices.Protocols.DirectoryResponse response) { }
        public TlsOperationException(System.DirectoryServices.Protocols.DirectoryResponse response, string message) { }
        public TlsOperationException(System.DirectoryServices.Protocols.DirectoryResponse response, string message, System.Exception inner) { }
        protected TlsOperationException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
        public TlsOperationException(string message) { }
        public TlsOperationException(string message, System.Exception inner) { }
    }
    public partial class TreeDeleteControl : System.DirectoryServices.Protocols.DirectoryControl
    {
        public TreeDeleteControl() : base (default(string), default(byte[]), default(bool), default(bool)) { }
    }
    public partial class VerifyNameControl : System.DirectoryServices.Protocols.DirectoryControl
    {
        public VerifyNameControl() : base (default(string), default(byte[]), default(bool), default(bool)) { }
        public VerifyNameControl(string serverName) : base (default(string), default(byte[]), default(bool), default(bool)) { }
        public VerifyNameControl(string serverName, int flag) : base (default(string), default(byte[]), default(bool), default(bool)) { }
        public int Flag { get { throw null; } set { } }
        public string ServerName { get { throw null; } set { } }
        public override byte[] GetValue() { throw null; }
    }
    public delegate bool VerifyServerCertificateCallback(System.DirectoryServices.Protocols.LdapConnection connection, System.Security.Cryptography.X509Certificates.X509Certificate certificate);
    public partial class VlvRequestControl : System.DirectoryServices.Protocols.DirectoryControl
    {
        public VlvRequestControl() : base (default(string), default(byte[]), default(bool), default(bool)) { }
        public VlvRequestControl(int beforeCount, int afterCount, byte[] target) : base (default(string), default(byte[]), default(bool), default(bool)) { }
        public VlvRequestControl(int beforeCount, int afterCount, int offset) : base (default(string), default(byte[]), default(bool), default(bool)) { }
        public VlvRequestControl(int beforeCount, int afterCount, string target) : base (default(string), default(byte[]), default(bool), default(bool)) { }
        public int AfterCount { get { throw null; } set { } }
        public int BeforeCount { get { throw null; } set { } }
        public byte[] ContextId { get { throw null; } set { } }
        public int EstimateCount { get { throw null; } set { } }
        public int Offset { get { throw null; } set { } }
        public byte[] Target { get { throw null; } set { } }
        public override byte[] GetValue() { throw null; }
    }
    public partial class VlvResponseControl : System.DirectoryServices.Protocols.DirectoryControl
    {
        internal VlvResponseControl() : base (default(string), default(byte[]), default(bool), default(bool)) { }
        public int ContentCount { get { throw null; } }
        public byte[] ContextId { get { throw null; } }
        public System.DirectoryServices.Protocols.ResultCode Result { get { throw null; } }
        public int TargetPosition { get { throw null; } }
    }
}
