// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

[assembly:System.Reflection.AssemblyVersionAttribute("4.0.0.0")]
[assembly:System.CLSCompliantAttribute(true)]
[assembly:System.Diagnostics.DebuggableAttribute(System.Diagnostics.DebuggableAttribute.DebuggingModes.IgnoreSymbolStoreSequencePoints)]
[assembly:System.Reflection.AssemblyCompanyAttribute("Mono development team")]
[assembly:System.Reflection.AssemblyCopyrightAttribute("(c) Various Mono authors")]
[assembly:System.Reflection.AssemblyDefaultAliasAttribute("System.Messaging.dll")]
[assembly:System.Reflection.AssemblyDescriptionAttribute("System.Messaging.dll")]
[assembly:System.Reflection.AssemblyFileVersionAttribute("4.6.57.0")]
[assembly:System.Reflection.AssemblyInformationalVersionAttribute("4.6.57.0")]
[assembly:System.Reflection.AssemblyProductAttribute("Mono Common Language Infrastructure")]
[assembly:System.Reflection.AssemblyTitleAttribute("System.Messaging.dll")]
[assembly:System.Resources.NeutralResourcesLanguageAttribute("en-US")]
[assembly:System.Resources.SatelliteContractVersionAttribute("4.0.0.0")]
[assembly:System.Runtime.CompilerServices.CompilationRelaxationsAttribute(System.Runtime.CompilerServices.CompilationRelaxations.NoStringInterning)]
[assembly:System.Runtime.CompilerServices.RuntimeCompatibilityAttribute(WrapNonExceptionThrows=true)]
[assembly:System.Runtime.InteropServices.ComVisibleAttribute(false)]
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
namespace System.Messaging
{
    public partial class AccessControlEntry
    {
        [System.MonoTODOAttribute]
        public AccessControlEntry() { }
        [System.MonoTODOAttribute]
        public AccessControlEntry(System.Messaging.Trustee trustee) { }
        [System.MonoTODOAttribute]
        public AccessControlEntry(System.Messaging.Trustee trustee, System.Messaging.GenericAccessRights genericAccessRights, System.Messaging.StandardAccessRights standardAccessRights, System.Messaging.AccessControlEntryType entryType) { }
        protected int CustomAccessRights { [System.MonoTODOAttribute]get { throw null; } [System.MonoTODOAttribute]set { } }
        public System.Messaging.AccessControlEntryType EntryType { [System.MonoTODOAttribute]get { throw null; } [System.MonoTODOAttribute]set { } }
        public System.Messaging.GenericAccessRights GenericAccessRights { [System.MonoTODOAttribute]get { throw null; } [System.MonoTODOAttribute]set { } }
        public System.Messaging.StandardAccessRights StandardAccessRights { [System.MonoTODOAttribute]get { throw null; } [System.MonoTODOAttribute]set { } }
        public System.Messaging.Trustee Trustee { [System.MonoTODOAttribute]get { throw null; } [System.MonoTODOAttribute]set { } }
    }
    [System.SerializableAttribute]
    public enum AccessControlEntryType
    {
        Allow = 1,
        Deny = 3,
        Revoke = 4,
        Set = 2,
    }
    public partial class AccessControlList : System.Collections.CollectionBase
    {
        [System.MonoTODOAttribute]
        public AccessControlList() { }
        [System.MonoTODOAttribute]
        public int Add(System.Messaging.AccessControlEntry entry) { throw null; }
        [System.MonoTODOAttribute]
        public bool Contains(System.Messaging.AccessControlEntry entry) { throw null; }
        [System.MonoTODOAttribute]
        public void CopyTo(System.Messaging.AccessControlEntry[] array, int index) { }
        [System.MonoTODOAttribute]
        public int IndexOf(System.Messaging.AccessControlEntry entry) { throw null; }
        [System.MonoTODOAttribute]
        public void Insert(int index, System.Messaging.AccessControlEntry entry) { }
        [System.MonoTODOAttribute]
        public void Remove(System.Messaging.AccessControlEntry entry) { }
    }
    [System.FlagsAttribute]
    [System.SerializableAttribute]
    public enum AcknowledgeTypes
    {
        FullReachQueue = 5,
        FullReceive = 14,
        NegativeReceive = 8,
        None = 0,
        NotAcknowledgeReachQueue = 4,
        NotAcknowledgeReceive = 12,
        PositiveArrival = 1,
        PositiveReceive = 2,
    }
    [System.SerializableAttribute]
    public enum Acknowledgment
    {
        AccessDenied = 32772,
        BadDestinationQueue = 32768,
        BadEncryption = 32775,
        BadSignature = 32774,
        CouldNotEncrypt = 32776,
        HopCountExceeded = 32773,
        None = 0,
        NotTransactionalMessage = 32778,
        NotTransactionalQueue = 32777,
        Purged = 32769,
        QueueDeleted = 49152,
        QueueExceedMaximumSize = 32771,
        QueuePurged = 49153,
        ReachQueue = 2,
        ReachQueueTimeout = 32770,
        Receive = 16384,
        ReceiveTimeout = 49154,
    }
    public partial class ActiveXMessageFormatter : System.ICloneable, System.Messaging.IMessageFormatter
    {
        [System.MonoTODOAttribute]
        public ActiveXMessageFormatter() { }
        [System.MonoTODOAttribute]
        public bool CanRead(System.Messaging.Message message) { throw null; }
        [System.MonoTODOAttribute]
        public object Clone() { throw null; }
        [System.MonoTODOAttribute]
        public static void InitStreamedObject(object streamedObject) { }
        [System.MonoTODOAttribute]
        public object Read(System.Messaging.Message message) { throw null; }
        [System.MonoTODOAttribute]
        public void Write(System.Messaging.Message message, object obj) { }
    }
    public partial class BinaryMessageFormatter : System.ICloneable, System.Messaging.IMessageFormatter
    {
        public BinaryMessageFormatter() { }
        public BinaryMessageFormatter(System.Runtime.Serialization.Formatters.FormatterAssemblyStyle topObjectFormat, System.Runtime.Serialization.Formatters.FormatterTypeStyle typeFormat) { }
        [System.ComponentModel.DefaultValueAttribute(0)]
        [System.Messaging.MessagingDescriptionAttribute("MsgTopObjectFormat")]
        public System.Runtime.Serialization.Formatters.FormatterAssemblyStyle TopObjectFormat { get { throw null; } set { } }
        [System.ComponentModel.DefaultValueAttribute(0)]
        [System.Messaging.MessagingDescriptionAttribute("MsgTypeFormat")]
        public System.Runtime.Serialization.Formatters.FormatterTypeStyle TypeFormat { get { throw null; } set { } }
        [System.MonoTODOAttribute("only return true if body type is binary")]
        public bool CanRead(System.Messaging.Message message) { throw null; }
        public object Clone() { throw null; }
        [System.MonoTODOAttribute("throw InvalidOperationException if message body is not binary")]
        public object Read(System.Messaging.Message message) { throw null; }
        [System.MonoTODOAttribute("throw InvalidOperationException if message body is not binary")]
        public void Write(System.Messaging.Message message, object obj) { }
    }
    [System.SerializableAttribute]
    public enum CryptographicProviderType
    {
        Dss = 3,
        Fortezza = 4,
        MicrosoftExchange = 5,
        None = 0,
        RsaFull = 1,
        RsqSig = 2,
        Ssl = 6,
        SttAcq = 8,
        SttBrnd = 9,
        SttIss = 11,
        SttMer = 7,
        SttRoot = 10,
    }
    [System.ComponentModel.TypeConverterAttribute(typeof(System.ComponentModel.ExpandableObjectConverter))]
    public partial class DefaultPropertiesToSend
    {
        [System.MonoTODOAttribute]
        public DefaultPropertiesToSend() { }
        [System.ComponentModel.DefaultValueAttribute(System.Messaging.AcknowledgeTypes.None)]
        [System.Messaging.MessagingDescriptionAttribute("MsgAcknowledgeType")]
        public System.Messaging.AcknowledgeTypes AcknowledgeType { [System.MonoTODOAttribute]get { throw null; } [System.MonoTODOAttribute]set { } }
        [System.ComponentModel.DefaultValueAttribute(null)]
        [System.Messaging.MessagingDescriptionAttribute("MsgAdministrationQueue")]
        public System.Messaging.MessageQueue AdministrationQueue { [System.MonoTODOAttribute]get { throw null; } [System.MonoTODOAttribute]set { } }
        [System.ComponentModel.DefaultValueAttribute(0)]
        [System.Messaging.MessagingDescriptionAttribute("MsgAppSpecific")]
        public int AppSpecific { [System.MonoTODOAttribute]get { throw null; } [System.MonoTODOAttribute]set { } }
        [System.ComponentModel.DefaultValueAttribute(true)]
        [System.Messaging.MessagingDescriptionAttribute("MsgAttachSenderId")]
        public bool AttachSenderId { [System.MonoTODOAttribute]get { throw null; } [System.MonoTODOAttribute]set { } }
        [System.ComponentModel.DefaultValueAttribute(System.Messaging.EncryptionAlgorithm.Rc2)]
        [System.Messaging.MessagingDescriptionAttribute("MsgEncryptionAlgorithm")]
        public System.Messaging.EncryptionAlgorithm EncryptionAlgorithm { [System.MonoTODOAttribute]get { throw null; } [System.MonoTODOAttribute]set { } }
        [System.ComponentModel.EditorAttribute("System.ComponentModel.Design.ArrayEditor, System.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor, System.Drawing, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
        [System.Messaging.MessagingDescriptionAttribute("MsgExtension")]
        public byte[] Extension { [System.MonoTODOAttribute]get { throw null; } [System.MonoTODOAttribute]set { } }
        [System.ComponentModel.DefaultValueAttribute(System.Messaging.HashAlgorithm.Md5)]
        [System.Messaging.MessagingDescriptionAttribute("MsgHashAlgorithm")]
        public System.Messaging.HashAlgorithm HashAlgorithm { [System.MonoTODOAttribute]get { throw null; } [System.MonoTODOAttribute]set { } }
        [System.ComponentModel.DefaultValueAttribute("")]
        [System.Messaging.MessagingDescriptionAttribute("MsgLabel")]
        public string Label { [System.MonoTODOAttribute]get { throw null; } [System.MonoTODOAttribute]set { } }
        [System.ComponentModel.DefaultValueAttribute(System.Messaging.MessagePriority.Normal)]
        [System.Messaging.MessagingDescriptionAttribute("MsgPriority")]
        public System.Messaging.MessagePriority Priority { [System.MonoTODOAttribute]get { throw null; } [System.MonoTODOAttribute]set { } }
        [System.ComponentModel.DefaultValueAttribute(false)]
        [System.Messaging.MessagingDescriptionAttribute("MsgRecoverable")]
        public bool Recoverable { [System.MonoTODOAttribute]get { throw null; } [System.MonoTODOAttribute]set { } }
        [System.ComponentModel.DefaultValueAttribute(null)]
        [System.Messaging.MessagingDescriptionAttribute("MsgResponseQueue")]
        public System.Messaging.MessageQueue ResponseQueue { [System.MonoTODOAttribute]get { throw null; } [System.MonoTODOAttribute]set { } }
        [System.ComponentModel.TypeConverterAttribute("System.Messaging.TimeoutConverter")]
        [System.Messaging.MessagingDescriptionAttribute("MsgTimeToBeReceived")]
        public System.TimeSpan TimeToBeReceived { [System.MonoTODOAttribute]get { throw null; } [System.MonoTODOAttribute]set { } }
        [System.ComponentModel.TypeConverterAttribute("System.Messaging.TimeoutConverter")]
        [System.Messaging.MessagingDescriptionAttribute("MsgTimeToReachQueue")]
        public System.TimeSpan TimeToReachQueue { [System.MonoTODOAttribute]get { throw null; } [System.MonoTODOAttribute]set { } }
        [System.ComponentModel.DefaultValueAttribute(null)]
        [System.Messaging.MessagingDescriptionAttribute("MsgTransactionStatusQueue")]
        public System.Messaging.MessageQueue TransactionStatusQueue { [System.MonoTODOAttribute]get { throw null; } [System.MonoTODOAttribute]set { } }
        [System.ComponentModel.DefaultValueAttribute(false)]
        [System.Messaging.MessagingDescriptionAttribute("MsgUseAuthentication")]
        public bool UseAuthentication { [System.MonoTODOAttribute]get { throw null; } [System.MonoTODOAttribute]set { } }
        [System.ComponentModel.DefaultValueAttribute(false)]
        [System.Messaging.MessagingDescriptionAttribute("MsgUseDeadLetterQueue")]
        public bool UseDeadLetterQueue { [System.MonoTODOAttribute]get { throw null; } [System.MonoTODOAttribute]set { } }
        [System.ComponentModel.DefaultValueAttribute(false)]
        [System.Messaging.MessagingDescriptionAttribute("MsgUseEncryption")]
        public bool UseEncryption { [System.MonoTODOAttribute]get { throw null; } [System.MonoTODOAttribute]set { } }
        [System.ComponentModel.DefaultValueAttribute(false)]
        [System.Messaging.MessagingDescriptionAttribute("MsgUseJournalQueue")]
        public bool UseJournalQueue { [System.MonoTODOAttribute]get { throw null; } [System.MonoTODOAttribute]set { } }
        [System.ComponentModel.DefaultValueAttribute(false)]
        [System.Messaging.MessagingDescriptionAttribute("MsgUseTracing")]
        public bool UseTracing { [System.MonoTODOAttribute]get { throw null; } [System.MonoTODOAttribute]set { } }
    }
    [System.SerializableAttribute]
    public enum EncryptionAlgorithm
    {
        None = 0,
        Rc2 = 26114,
        Rc4 = 26625,
    }
    [System.SerializableAttribute]
    public enum EncryptionRequired
    {
        Body = 2,
        None = 0,
        Optional = 1,
    }
    [System.FlagsAttribute]
    [System.SerializableAttribute]
    public enum GenericAccessRights
    {
        All = 268435456,
        Execute = 536870912,
        None = 0,
        Read = -2147483648,
        Write = 1073741824,
    }
    [System.SerializableAttribute]
    public enum HashAlgorithm
    {
        Mac = 32773,
        Md2 = 32769,
        Md4 = 32770,
        Md5 = 32771,
        None = 0,
        Sha = 32772,
    }
    [System.ComponentModel.TypeConverterAttribute("System.Messaging.Design.MessageFormatterConverter")]
    public partial interface IMessageFormatter : System.ICloneable
    {
        bool CanRead(System.Messaging.Message message);
        object Read(System.Messaging.Message message);
        void Write(System.Messaging.Message message, object obj);
    }
    [System.ComponentModel.DesignerAttribute("System.Messaging.Design.MessageDesigner, System.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
    public partial class Message : System.ComponentModel.Component
    {
        [System.MonoTODOAttribute]
        public static readonly System.TimeSpan InfiniteTimeout;
        public Message() { }
        public Message(object body) { }
        public Message(object body, System.Messaging.IMessageFormatter formatter) { }
        [System.ComponentModel.DesignerSerializationVisibilityAttribute(System.ComponentModel.DesignerSerializationVisibility.Hidden)]
        [System.ComponentModel.ReadOnlyAttribute(true)]
        [System.Messaging.MessagingDescriptionAttribute("MsgAcknowledgeType")]
        public System.Messaging.AcknowledgeTypes AcknowledgeType { get { throw null; } set { } }
        [System.ComponentModel.DesignerSerializationVisibilityAttribute(System.ComponentModel.DesignerSerializationVisibility.Hidden)]
        [System.ComponentModel.ReadOnlyAttribute(true)]
        [System.Messaging.MessagingDescriptionAttribute("MsgAcknowledgement")]
        public System.Messaging.Acknowledgment Acknowledgment { get { throw null; } }
        [System.ComponentModel.DesignerSerializationVisibilityAttribute(System.ComponentModel.DesignerSerializationVisibility.Hidden)]
        [System.ComponentModel.ReadOnlyAttribute(true)]
        [System.Messaging.MessagingDescriptionAttribute("MsgAdministrationQueue")]
        public System.Messaging.MessageQueue AdministrationQueue { get { throw null; } set { } }
        [System.ComponentModel.DesignerSerializationVisibilityAttribute(System.ComponentModel.DesignerSerializationVisibility.Hidden)]
        [System.ComponentModel.ReadOnlyAttribute(true)]
        [System.Messaging.MessagingDescriptionAttribute("MsgAppSpecific")]
        public int AppSpecific { get { throw null; } set { } }
        [System.ComponentModel.DesignerSerializationVisibilityAttribute(System.ComponentModel.DesignerSerializationVisibility.Hidden)]
        [System.Messaging.MessagingDescriptionAttribute("MsgArrivedTime")]
        public System.DateTime ArrivedTime { get { throw null; } }
        [System.ComponentModel.DesignerSerializationVisibilityAttribute(System.ComponentModel.DesignerSerializationVisibility.Hidden)]
        [System.ComponentModel.ReadOnlyAttribute(true)]
        [System.Messaging.MessagingDescriptionAttribute("MsgAttachSenderId")]
        public bool AttachSenderId { get { throw null; } set { } }
        [System.ComponentModel.DesignerSerializationVisibilityAttribute(System.ComponentModel.DesignerSerializationVisibility.Hidden)]
        [System.Messaging.MessagingDescriptionAttribute("MsgAuthenticated")]
        public bool Authenticated { get { throw null; } }
        [System.ComponentModel.DesignerSerializationVisibilityAttribute(System.ComponentModel.DesignerSerializationVisibility.Hidden)]
        [System.ComponentModel.ReadOnlyAttribute(true)]
        [System.Messaging.MessagingDescriptionAttribute("MsgAuthenticationProviderName")]
        public string AuthenticationProviderName { get { throw null; } set { } }
        [System.ComponentModel.DesignerSerializationVisibilityAttribute(System.ComponentModel.DesignerSerializationVisibility.Hidden)]
        [System.ComponentModel.ReadOnlyAttribute(true)]
        [System.Messaging.MessagingDescriptionAttribute("MsgAuthenticationProviderType")]
        public System.Messaging.CryptographicProviderType AuthenticationProviderType { get { throw null; } set { } }
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.DesignerSerializationVisibilityAttribute(System.ComponentModel.DesignerSerializationVisibility.Hidden)]
        public object Body { get { throw null; } set { } }
        [System.ComponentModel.DesignerSerializationVisibilityAttribute(System.ComponentModel.DesignerSerializationVisibility.Hidden)]
        [System.ComponentModel.EditorAttribute("System.ComponentModel.Design.BinaryEditor, System.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor, System.Drawing, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
        [System.ComponentModel.ReadOnlyAttribute(true)]
        [System.Messaging.MessagingDescriptionAttribute("MsgBodyStream")]
        public System.IO.Stream BodyStream { get { throw null; } set { } }
        [System.ComponentModel.DesignerSerializationVisibilityAttribute(System.ComponentModel.DesignerSerializationVisibility.Hidden)]
        [System.ComponentModel.ReadOnlyAttribute(true)]
        [System.Messaging.MessagingDescriptionAttribute("MsgBodyType")]
        public int BodyType { get { throw null; } set { } }
        [System.ComponentModel.DesignerSerializationVisibilityAttribute(System.ComponentModel.DesignerSerializationVisibility.Hidden)]
        [System.ComponentModel.ReadOnlyAttribute(true)]
        [System.Messaging.MessagingDescriptionAttribute("MsgConnectorType")]
        public System.Guid ConnectorType { get { throw null; } set { } }
        [System.ComponentModel.DesignerSerializationVisibilityAttribute(System.ComponentModel.DesignerSerializationVisibility.Hidden)]
        [System.ComponentModel.ReadOnlyAttribute(true)]
        [System.Messaging.MessagingDescriptionAttribute("MsgCorrelationId")]
        public string CorrelationId { get { throw null; } set { } }
        [System.ComponentModel.DesignerSerializationVisibilityAttribute(System.ComponentModel.DesignerSerializationVisibility.Hidden)]
        [System.Messaging.MessagingDescriptionAttribute("MsgDestinationQueue")]
        public System.Messaging.MessageQueue DestinationQueue { get { throw null; } }
        [System.ComponentModel.DesignerSerializationVisibilityAttribute(System.ComponentModel.DesignerSerializationVisibility.Hidden)]
        [System.ComponentModel.ReadOnlyAttribute(true)]
        [System.Messaging.MessagingDescriptionAttribute("MsgDestinationSymmetricKey")]
        public byte[] DestinationSymmetricKey { get { throw null; } set { } }
        [System.ComponentModel.DesignerSerializationVisibilityAttribute(System.ComponentModel.DesignerSerializationVisibility.Hidden)]
        [System.ComponentModel.ReadOnlyAttribute(true)]
        [System.Messaging.MessagingDescriptionAttribute("MsgDigitalSignature")]
        public byte[] DigitalSignature { get { throw null; } set { } }
        [System.ComponentModel.DesignerSerializationVisibilityAttribute(System.ComponentModel.DesignerSerializationVisibility.Hidden)]
        [System.ComponentModel.ReadOnlyAttribute(true)]
        [System.Messaging.MessagingDescriptionAttribute("MsgEncryptionAlgorithm")]
        public System.Messaging.EncryptionAlgorithm EncryptionAlgorithm { get { throw null; } set { } }
        [System.ComponentModel.DesignerSerializationVisibilityAttribute(System.ComponentModel.DesignerSerializationVisibility.Hidden)]
        [System.ComponentModel.ReadOnlyAttribute(true)]
        [System.Messaging.MessagingDescriptionAttribute("MsgExtension")]
        public byte[] Extension { get { throw null; } set { } }
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.DesignerSerializationVisibilityAttribute(System.ComponentModel.DesignerSerializationVisibility.Hidden)]
        public System.Messaging.IMessageFormatter Formatter { get { throw null; } set { } }
        [System.ComponentModel.DesignerSerializationVisibilityAttribute(System.ComponentModel.DesignerSerializationVisibility.Hidden)]
        [System.ComponentModel.ReadOnlyAttribute(true)]
        [System.Messaging.MessagingDescriptionAttribute("MsgHashAlgorithm")]
        public System.Messaging.HashAlgorithm HashAlgorithm { get { throw null; } set { } }
        [System.ComponentModel.DesignerSerializationVisibilityAttribute(System.ComponentModel.DesignerSerializationVisibility.Hidden)]
        [System.ComponentModel.ReadOnlyAttribute(true)]
        [System.Messaging.MessagingDescriptionAttribute("MsgId")]
        public string Id { get { throw null; } }
        [System.ComponentModel.DesignerSerializationVisibilityAttribute(System.ComponentModel.DesignerSerializationVisibility.Hidden)]
        [System.Messaging.MessagingDescriptionAttribute("MsgIsFirstInTransaction")]
        public bool IsFirstInTransaction { get { throw null; } }
        [System.ComponentModel.DesignerSerializationVisibilityAttribute(System.ComponentModel.DesignerSerializationVisibility.Hidden)]
        [System.Messaging.MessagingDescriptionAttribute("MsgIsLastInTransaction")]
        public bool IsLastInTransaction { get { throw null; } }
        [System.ComponentModel.DesignerSerializationVisibilityAttribute(System.ComponentModel.DesignerSerializationVisibility.Hidden)]
        [System.ComponentModel.ReadOnlyAttribute(true)]
        [System.Messaging.MessagingDescriptionAttribute("MsgLabel")]
        public string Label { get { throw null; } set { } }
        [System.ComponentModel.DesignerSerializationVisibilityAttribute(System.ComponentModel.DesignerSerializationVisibility.Hidden)]
        [System.Messaging.MessagingDescriptionAttribute("MsgMessageType")]
        public System.Messaging.MessageType MessageType { get { throw null; } }
        [System.ComponentModel.DesignerSerializationVisibilityAttribute(System.ComponentModel.DesignerSerializationVisibility.Hidden)]
        [System.ComponentModel.ReadOnlyAttribute(true)]
        [System.Messaging.MessagingDescriptionAttribute("MsgPriority")]
        public System.Messaging.MessagePriority Priority { get { throw null; } set { } }
        [System.ComponentModel.DesignerSerializationVisibilityAttribute(System.ComponentModel.DesignerSerializationVisibility.Hidden)]
        [System.ComponentModel.ReadOnlyAttribute(true)]
        [System.Messaging.MessagingDescriptionAttribute("MsgRecoverable")]
        public bool Recoverable { get { throw null; } set { } }
        [System.ComponentModel.DesignerSerializationVisibilityAttribute(System.ComponentModel.DesignerSerializationVisibility.Hidden)]
        [System.ComponentModel.ReadOnlyAttribute(true)]
        [System.Messaging.MessagingDescriptionAttribute("MsgResponseQueue")]
        public System.Messaging.MessageQueue ResponseQueue { get { throw null; } set { } }
        [System.ComponentModel.DesignerSerializationVisibilityAttribute(System.ComponentModel.DesignerSerializationVisibility.Hidden)]
        [System.ComponentModel.ReadOnlyAttribute(true)]
        [System.Messaging.MessagingDescriptionAttribute("MsgSenderCertificate")]
        public byte[] SenderCertificate { get { throw null; } set { } }
        [System.ComponentModel.DesignerSerializationVisibilityAttribute(System.ComponentModel.DesignerSerializationVisibility.Hidden)]
        [System.Messaging.MessagingDescriptionAttribute("MsgSenderId")]
        public byte[] SenderId { get { throw null; } }
        [System.ComponentModel.DesignerSerializationVisibilityAttribute(System.ComponentModel.DesignerSerializationVisibility.Hidden)]
        [System.ComponentModel.ReadOnlyAttribute(true)]
        [System.Messaging.MessagingDescriptionAttribute("MsgSenderVersion")]
        public long SenderVersion { get { throw null; } }
        [System.ComponentModel.DesignerSerializationVisibilityAttribute(System.ComponentModel.DesignerSerializationVisibility.Hidden)]
        [System.ComponentModel.ReadOnlyAttribute(true)]
        [System.Messaging.MessagingDescriptionAttribute("MsgSentTime")]
        public System.DateTime SentTime { get { throw null; } }
        [System.ComponentModel.DesignerSerializationVisibilityAttribute(System.ComponentModel.DesignerSerializationVisibility.Hidden)]
        [System.Messaging.MessagingDescriptionAttribute("MsgSourceMachine")]
        public string SourceMachine { get { throw null; } }
        [System.ComponentModel.DesignerSerializationVisibilityAttribute(System.ComponentModel.DesignerSerializationVisibility.Hidden)]
        [System.ComponentModel.ReadOnlyAttribute(true)]
        [System.ComponentModel.TypeConverterAttribute("System.Messaging.TimeoutConverter")]
        [System.Messaging.MessagingDescriptionAttribute("MsgTimeToBeReceived")]
        public System.TimeSpan TimeToBeReceived { get { throw null; } set { } }
        [System.ComponentModel.DesignerSerializationVisibilityAttribute(System.ComponentModel.DesignerSerializationVisibility.Hidden)]
        [System.ComponentModel.ReadOnlyAttribute(true)]
        [System.ComponentModel.TypeConverterAttribute("System.Messaging.TimeoutConverter")]
        [System.Messaging.MessagingDescriptionAttribute("MsgTimeToReachQueue")]
        public System.TimeSpan TimeToReachQueue { get { throw null; } set { } }
        [System.ComponentModel.DesignerSerializationVisibilityAttribute(System.ComponentModel.DesignerSerializationVisibility.Hidden)]
        [System.Messaging.MessagingDescriptionAttribute("MsgTransactionId")]
        public string TransactionId { get { throw null; } }
        [System.ComponentModel.DesignerSerializationVisibilityAttribute(System.ComponentModel.DesignerSerializationVisibility.Hidden)]
        [System.ComponentModel.ReadOnlyAttribute(true)]
        [System.Messaging.MessagingDescriptionAttribute("MsgTransactionStatusQueue")]
        public System.Messaging.MessageQueue TransactionStatusQueue { get { throw null; } set { } }
        [System.ComponentModel.DesignerSerializationVisibilityAttribute(System.ComponentModel.DesignerSerializationVisibility.Hidden)]
        [System.ComponentModel.ReadOnlyAttribute(true)]
        [System.Messaging.MessagingDescriptionAttribute("MsgUseAuthentication")]
        public bool UseAuthentication { get { throw null; } set { } }
        [System.ComponentModel.DesignerSerializationVisibilityAttribute(System.ComponentModel.DesignerSerializationVisibility.Hidden)]
        [System.ComponentModel.ReadOnlyAttribute(true)]
        [System.Messaging.MessagingDescriptionAttribute("MsgUseDeadLetterQueue")]
        public bool UseDeadLetterQueue { get { throw null; } set { } }
        [System.ComponentModel.DesignerSerializationVisibilityAttribute(System.ComponentModel.DesignerSerializationVisibility.Hidden)]
        [System.ComponentModel.ReadOnlyAttribute(true)]
        [System.Messaging.MessagingDescriptionAttribute("MsgUseEncryption")]
        public bool UseEncryption { get { throw null; } set { } }
        [System.ComponentModel.DesignerSerializationVisibilityAttribute(System.ComponentModel.DesignerSerializationVisibility.Hidden)]
        [System.ComponentModel.ReadOnlyAttribute(true)]
        [System.Messaging.MessagingDescriptionAttribute("MsgUseJournalQueue")]
        public bool UseJournalQueue { get { throw null; } set { } }
        [System.ComponentModel.DesignerSerializationVisibilityAttribute(System.ComponentModel.DesignerSerializationVisibility.Hidden)]
        [System.ComponentModel.ReadOnlyAttribute(true)]
        [System.Messaging.MessagingDescriptionAttribute("MsgUseTracing")]
        public bool UseTracing { get { throw null; } set { } }
    }
    public partial class MessageEnumerator : System.MarshalByRefObject, System.Collections.IEnumerator, System.IDisposable
    {
        internal MessageEnumerator() { }
        public System.Messaging.Message Current { get { throw null; } }
        public System.IntPtr CursorHandle { get { throw null; } }
        object System.Collections.IEnumerator.Current { get { throw null; } }
        public void Close() { }
        public void Dispose() { }
        protected virtual void Dispose(bool disposing) { }
        ~MessageEnumerator() { }
        public bool MoveNext() { throw null; }
        public bool MoveNext(System.TimeSpan timeout) { throw null; }
        public System.Messaging.Message RemoveCurrent() { throw null; }
        public System.Messaging.Message RemoveCurrent(System.Messaging.MessageQueueTransaction transaction) { throw null; }
        public System.Messaging.Message RemoveCurrent(System.Messaging.MessageQueueTransactionType transactionType) { throw null; }
        public System.Messaging.Message RemoveCurrent(System.TimeSpan timeout) { throw null; }
        public System.Messaging.Message RemoveCurrent(System.TimeSpan timeout, System.Messaging.MessageQueueTransaction transaction) { throw null; }
        public System.Messaging.Message RemoveCurrent(System.TimeSpan timeout, System.Messaging.MessageQueueTransactionType transactionType) { throw null; }
        public void Reset() { }
    }
    [System.SerializableAttribute]
    public enum MessagePriority
    {
        AboveNormal = 4,
        High = 5,
        Highest = 7,
        Low = 2,
        Lowest = 0,
        Normal = 3,
        VeryHigh = 6,
        VeryLow = 1,
    }
    [System.ComponentModel.TypeConverterAttribute(typeof(System.ComponentModel.ExpandableObjectConverter))]
    public partial class MessagePropertyFilter
    {
        [System.MonoTODOAttribute]
        public MessagePropertyFilter() { }
        [System.ComponentModel.DefaultValueAttribute(true)]
        [System.Messaging.MessagingDescriptionAttribute("MsgAcknowledgeType")]
        public bool AcknowledgeType { get { throw null; } set { } }
        [System.ComponentModel.DefaultValueAttribute(true)]
        [System.Messaging.MessagingDescriptionAttribute("MsgAcknowledgement")]
        public bool Acknowledgment { get { throw null; } set { } }
        [System.ComponentModel.DefaultValueAttribute(true)]
        [System.Messaging.MessagingDescriptionAttribute("MsgAdministrationQueue")]
        public bool AdministrationQueue { get { throw null; } set { } }
        [System.ComponentModel.DefaultValueAttribute(false)]
        [System.Messaging.MessagingDescriptionAttribute("MsgAppSpecific")]
        public bool AppSpecific { get { throw null; } set { } }
        [System.ComponentModel.DefaultValueAttribute(false)]
        [System.Messaging.MessagingDescriptionAttribute("MsgArrivedTime")]
        public bool ArrivedTime { get { throw null; } set { } }
        [System.ComponentModel.DefaultValueAttribute(false)]
        [System.Messaging.MessagingDescriptionAttribute("MsgAttachSenderId")]
        public bool AttachSenderId { get { throw null; } set { } }
        [System.ComponentModel.DefaultValueAttribute(false)]
        [System.Messaging.MessagingDescriptionAttribute("MsgAuthenticated")]
        public bool Authenticated { get { throw null; } set { } }
        [System.ComponentModel.DefaultValueAttribute(false)]
        [System.Messaging.MessagingDescriptionAttribute("MsgAuthenticationProviderName")]
        public bool AuthenticationProviderName { get { throw null; } set { } }
        [System.ComponentModel.DefaultValueAttribute(false)]
        [System.Messaging.MessagingDescriptionAttribute("MsgAuthenticationProviderType")]
        public bool AuthenticationProviderType { get { throw null; } set { } }
        [System.ComponentModel.DefaultValueAttribute(true)]
        [System.Messaging.MessagingDescriptionAttribute("MsgBody")]
        public bool Body { get { throw null; } set { } }
        [System.ComponentModel.DefaultValueAttribute(false)]
        [System.Messaging.MessagingDescriptionAttribute("MsgConnectorType")]
        public bool ConnectorType { get { throw null; } set { } }
        [System.ComponentModel.DefaultValueAttribute(false)]
        [System.Messaging.MessagingDescriptionAttribute("MsgCorrelationId")]
        public bool CorrelationId { get { throw null; } set { } }
        [System.ComponentModel.DefaultValueAttribute(1024)]
        [System.Messaging.MessagingDescriptionAttribute("MsgDefaultBodySize")]
        public int DefaultBodySize { get { throw null; } set { } }
        [System.ComponentModel.DefaultValueAttribute(255)]
        [System.Messaging.MessagingDescriptionAttribute("MsgDefaultExtensionSize")]
        public int DefaultExtensionSize { get { throw null; } set { } }
        [System.ComponentModel.DefaultValueAttribute(255)]
        [System.Messaging.MessagingDescriptionAttribute("MsgDefaultLabelSize")]
        public int DefaultLabelSize { get { throw null; } set { } }
        [System.ComponentModel.DefaultValueAttribute(false)]
        [System.Messaging.MessagingDescriptionAttribute("MsgDestinationQueue")]
        public bool DestinationQueue { get { throw null; } set { } }
        [System.ComponentModel.DefaultValueAttribute(false)]
        [System.Messaging.MessagingDescriptionAttribute("MsgDestinationSymmetricKey")]
        public bool DestinationSymmetricKey { get { throw null; } set { } }
        [System.ComponentModel.DefaultValueAttribute(false)]
        [System.Messaging.MessagingDescriptionAttribute("MsgDigitalSignature")]
        public bool DigitalSignature { get { throw null; } set { } }
        [System.ComponentModel.DefaultValueAttribute(false)]
        [System.Messaging.MessagingDescriptionAttribute("MsgEncryptionAlgorithm")]
        public bool EncryptionAlgorithm { get { throw null; } set { } }
        [System.ComponentModel.DefaultValueAttribute(false)]
        [System.Messaging.MessagingDescriptionAttribute("MsgExtension")]
        public bool Extension { get { throw null; } set { } }
        [System.ComponentModel.DefaultValueAttribute(false)]
        [System.Messaging.MessagingDescriptionAttribute("MsgHashAlgorithm")]
        public bool HashAlgorithm { get { throw null; } set { } }
        [System.ComponentModel.DefaultValueAttribute(false)]
        [System.Messaging.MessagingDescriptionAttribute("MsgId")]
        public bool Id { get { throw null; } set { } }
        [System.ComponentModel.DefaultValueAttribute(false)]
        [System.Messaging.MessagingDescriptionAttribute("MsgIsFirstInTransaction")]
        public bool IsFirstInTransaction { get { throw null; } set { } }
        [System.ComponentModel.DefaultValueAttribute(false)]
        [System.Messaging.MessagingDescriptionAttribute("MsgIsLastInTransaction")]
        public bool IsLastInTransaction { get { throw null; } set { } }
        [System.ComponentModel.DefaultValueAttribute(true)]
        [System.Messaging.MessagingDescriptionAttribute("MsgLabel")]
        public bool Label { get { throw null; } set { } }
        [System.ComponentModel.DefaultValueAttribute(true)]
        [System.Messaging.MessagingDescriptionAttribute("MsgMessageType")]
        public bool MessageType { get { throw null; } set { } }
        [System.ComponentModel.DefaultValueAttribute(false)]
        [System.Messaging.MessagingDescriptionAttribute("MsgPriority")]
        public bool Priority { get { throw null; } set { } }
        [System.ComponentModel.DefaultValueAttribute(false)]
        [System.Messaging.MessagingDescriptionAttribute("MsgRecoverable")]
        public bool Recoverable { get { throw null; } set { } }
        [System.ComponentModel.DefaultValueAttribute(true)]
        [System.Messaging.MessagingDescriptionAttribute("MsgResponseQueue")]
        public bool ResponseQueue { get { throw null; } set { } }
        [System.ComponentModel.DefaultValueAttribute(false)]
        [System.Messaging.MessagingDescriptionAttribute("MsgSenderCertificate")]
        public bool SenderCertificate { get { throw null; } set { } }
        [System.ComponentModel.DefaultValueAttribute(false)]
        [System.Messaging.MessagingDescriptionAttribute("MsgSenderId")]
        public bool SenderId { get { throw null; } set { } }
        [System.ComponentModel.DefaultValueAttribute(false)]
        [System.Messaging.MessagingDescriptionAttribute("MsgSenderVersion")]
        public bool SenderVersion { get { throw null; } set { } }
        [System.ComponentModel.DefaultValueAttribute(false)]
        [System.Messaging.MessagingDescriptionAttribute("MsgSentTime")]
        public bool SentTime { get { throw null; } set { } }
        [System.ComponentModel.DefaultValueAttribute(false)]
        [System.Messaging.MessagingDescriptionAttribute("MsgSourceMachine")]
        public bool SourceMachine { get { throw null; } set { } }
        [System.ComponentModel.DefaultValueAttribute(false)]
        [System.Messaging.MessagingDescriptionAttribute("MsgTimeToBeReceived")]
        public bool TimeToBeReceived { get { throw null; } set { } }
        [System.ComponentModel.DefaultValueAttribute(false)]
        [System.Messaging.MessagingDescriptionAttribute("MsgTimeToReachQueue")]
        public bool TimeToReachQueue { get { throw null; } set { } }
        [System.ComponentModel.DefaultValueAttribute(false)]
        [System.Messaging.MessagingDescriptionAttribute("MsgTransactionId")]
        public bool TransactionId { get { throw null; } set { } }
        [System.ComponentModel.DefaultValueAttribute(false)]
        [System.Messaging.MessagingDescriptionAttribute("MsgTransactionStatusQueue")]
        public bool TransactionStatusQueue { get { throw null; } set { } }
        [System.ComponentModel.DefaultValueAttribute(false)]
        [System.Messaging.MessagingDescriptionAttribute("MsgUseAuthentication")]
        public bool UseAuthentication { get { throw null; } set { } }
        [System.ComponentModel.DefaultValueAttribute(true)]
        [System.Messaging.MessagingDescriptionAttribute("MsgUseDeadLetterQueue")]
        public bool UseDeadLetterQueue { get { throw null; } set { } }
        [System.ComponentModel.DefaultValueAttribute(false)]
        [System.Messaging.MessagingDescriptionAttribute("MsgUseEncryption")]
        public bool UseEncryption { get { throw null; } set { } }
        [System.ComponentModel.DefaultValueAttribute(true)]
        [System.Messaging.MessagingDescriptionAttribute("MsgUseJournalQueue")]
        public bool UseJournalQueue { get { throw null; } set { } }
        [System.ComponentModel.DefaultValueAttribute(false)]
        [System.Messaging.MessagingDescriptionAttribute("MsgUseTracing")]
        public bool UseTracing { get { throw null; } set { } }
        public void ClearAll() { }
        public void SetAll() { }
        [System.MonoTODOAttribute]
        public void SetDefaults() { }
    }
    [System.ComponentModel.DefaultEventAttribute("ReceiveCompleted")]
    [System.ComponentModel.EditorAttribute("System.Messaging.Design.QueuePathEditor", "System.Drawing.Design.UITypeEditor, System.Drawing, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
    [System.ComponentModel.InstallerTypeAttribute(typeof(System.Messaging.MessageQueueInstaller))]
    [System.ComponentModel.TypeConverterAttribute("System.Messaging.Design.MessageQueueConverter")]
    public partial class MessageQueue : System.ComponentModel.Component, System.Collections.IEnumerable
    {
        public static readonly long InfiniteQueueSize;
        public static readonly System.TimeSpan InfiniteTimeout;
        public MessageQueue() { }
        public MessageQueue(string path) { }
        public MessageQueue(string path, bool sharedModeDenyReceive) { }
        public MessageQueue(string path, System.Messaging.QueueAccessMode accessMode) { }
        [System.ComponentModel.DesignerSerializationVisibilityAttribute(System.ComponentModel.DesignerSerializationVisibility.Hidden)]
        [System.Messaging.MessagingDescriptionAttribute("MQ_Authenticate")]
        public bool Authenticate { get { throw null; } set { } }
        [System.ComponentModel.DesignerSerializationVisibilityAttribute(System.ComponentModel.DesignerSerializationVisibility.Hidden)]
        [System.Messaging.MessagingDescriptionAttribute("MQ_BasePriority")]
        public short BasePriority { get { throw null; } set { } }
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.DesignerSerializationVisibilityAttribute(System.ComponentModel.DesignerSerializationVisibility.Hidden)]
        [System.Messaging.MessagingDescriptionAttribute("MQ_CanRead")]
        public bool CanRead { get { throw null; } }
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.DesignerSerializationVisibilityAttribute(System.ComponentModel.DesignerSerializationVisibility.Hidden)]
        [System.Messaging.MessagingDescriptionAttribute("MQ_CanWrite")]
        public bool CanWrite { get { throw null; } }
        [System.ComponentModel.DesignerSerializationVisibilityAttribute(System.ComponentModel.DesignerSerializationVisibility.Hidden)]
        [System.Messaging.MessagingDescriptionAttribute("MQ_Category")]
        public System.Guid Category { get { throw null; } set { } }
        [System.ComponentModel.DesignerSerializationVisibilityAttribute(System.ComponentModel.DesignerSerializationVisibility.Hidden)]
        [System.Messaging.MessagingDescriptionAttribute("MQ_CreateTime")]
        public System.DateTime CreateTime { get { throw null; } }
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.DesignerSerializationVisibilityAttribute(System.ComponentModel.DesignerSerializationVisibility.Content)]
        [System.Messaging.MessagingDescriptionAttribute("MQ_DefaultPropertiesToSend")]
        public System.Messaging.DefaultPropertiesToSend DefaultPropertiesToSend { get { throw null; } set { } }
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.DefaultValueAttribute(false)]
        [System.Messaging.MessagingDescriptionAttribute("MQ_DenySharedReceive")]
        public bool DenySharedReceive { get { throw null; } set { } }
        [System.ComponentModel.BrowsableAttribute(false)]
        public static bool EnableConnectionCache { get { throw null; } set { } }
        [System.ComponentModel.DesignerSerializationVisibilityAttribute(System.ComponentModel.DesignerSerializationVisibility.Hidden)]
        [System.Messaging.MessagingDescriptionAttribute("MQ_EncryptionRequired")]
        public System.Messaging.EncryptionRequired EncryptionRequired { get { throw null; } set { } }
        [System.ComponentModel.DesignerSerializationVisibilityAttribute(System.ComponentModel.DesignerSerializationVisibility.Hidden)]
        [System.Messaging.MessagingDescriptionAttribute("MQ_FormatName")]
        public string FormatName { get { throw null; } }
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.DefaultValueAttribute(null)]
        [System.ComponentModel.TypeConverterAttribute("System.Messaging.Design.MessageFormatterConverter")]
        [System.Messaging.MessagingDescriptionAttribute("MQ_Formatter")]
        public System.Messaging.IMessageFormatter Formatter { get { throw null; } set { } }
        [System.ComponentModel.DesignerSerializationVisibilityAttribute(System.ComponentModel.DesignerSerializationVisibility.Hidden)]
        [System.Messaging.MessagingDescriptionAttribute("MQ_GuidId")]
        public System.Guid Id { get { throw null; } }
        [System.ComponentModel.DesignerSerializationVisibilityAttribute(System.ComponentModel.DesignerSerializationVisibility.Hidden)]
        [System.Messaging.MessagingDescriptionAttribute("MQ_Label")]
        public string Label { [System.MonoTODOAttribute]get { throw null; } [System.MonoTODOAttribute]set { } }
        [System.ComponentModel.DesignerSerializationVisibilityAttribute(System.ComponentModel.DesignerSerializationVisibility.Hidden)]
        [System.Messaging.MessagingDescriptionAttribute("MQ_LastModifyTime")]
        public System.DateTime LastModifyTime { get { throw null; } }
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.DesignerSerializationVisibilityAttribute(System.ComponentModel.DesignerSerializationVisibility.Hidden)]
        [System.Messaging.MessagingDescriptionAttribute("MQ_MachineName")]
        public string MachineName { get { throw null; } set { } }
        [System.ComponentModel.DesignerSerializationVisibilityAttribute(System.ComponentModel.DesignerSerializationVisibility.Hidden)]
        [System.ComponentModel.TypeConverterAttribute(typeof(System.Drawing.SizeConverter))]
        [System.Messaging.MessagingDescriptionAttribute("MQ_MaximumJournalSize")]
        public long MaximumJournalSize { get { throw null; } set { } }
        [System.ComponentModel.DesignerSerializationVisibilityAttribute(System.ComponentModel.DesignerSerializationVisibility.Hidden)]
        [System.ComponentModel.TypeConverterAttribute(typeof(System.Drawing.SizeConverter))]
        [System.Messaging.MessagingDescriptionAttribute("MQ_MaximumQueueSize")]
        public long MaximumQueueSize { get { throw null; } set { } }
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.DesignerSerializationVisibilityAttribute(System.ComponentModel.DesignerSerializationVisibility.Content)]
        [System.Messaging.MessagingDescriptionAttribute("MQ_MessageReadPropertyFilter")]
        public System.Messaging.MessagePropertyFilter MessageReadPropertyFilter { get { throw null; } set { } }
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.DefaultValueAttribute("")]
        [System.ComponentModel.EditorAttribute("System.Messaging.Design.QueuePathEditor", "System.Drawing.Design.UITypeEditor, System.Drawing, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
        [System.ComponentModel.TypeConverterAttribute("System.Diagnostics.Design.StringValueConverter, System.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
        [System.Messaging.MessagingDescriptionAttribute("MQ_Path")]
        public string Path { get { throw null; } set { } }
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.DesignerSerializationVisibilityAttribute(System.ComponentModel.DesignerSerializationVisibility.Hidden)]
        [System.Messaging.MessagingDescriptionAttribute("MQ_QueueName")]
        public string QueueName { get { throw null; } set { } }
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.DesignerSerializationVisibilityAttribute(System.ComponentModel.DesignerSerializationVisibility.Hidden)]
        [System.Messaging.MessagingDescriptionAttribute("MQ_ReadHandle")]
        public System.IntPtr ReadHandle { get { throw null; } }
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.DefaultValueAttribute(null)]
        [System.Messaging.MessagingDescriptionAttribute("MQ_SynchronizingObject")]
        public System.ComponentModel.ISynchronizeInvoke SynchronizingObject { get { throw null; } set { } }
        [System.ComponentModel.DesignerSerializationVisibilityAttribute(System.ComponentModel.DesignerSerializationVisibility.Hidden)]
        [System.Messaging.MessagingDescriptionAttribute("MQ_Transactional")]
        public bool Transactional { get { throw null; } }
        [System.ComponentModel.DesignerSerializationVisibilityAttribute(System.ComponentModel.DesignerSerializationVisibility.Hidden)]
        [System.Messaging.MessagingDescriptionAttribute("MQ_WriteHandle")]
        public bool UseJournalQueue { get { throw null; } set { } }
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.DesignerSerializationVisibilityAttribute(System.ComponentModel.DesignerSerializationVisibility.Hidden)]
        [System.Messaging.MessagingDescriptionAttribute("MQ_WriteHandle")]
        public System.IntPtr WriteHandle { get { throw null; } }
        [System.Messaging.MessagingDescriptionAttribute("MQ_PeekCompleted")]
        public event System.Messaging.PeekCompletedEventHandler PeekCompleted { add { } remove { } }
        [System.Messaging.MessagingDescriptionAttribute("MQ_ReceiveCompleted")]
        public event System.Messaging.ReceiveCompletedEventHandler ReceiveCompleted { add { } remove { } }
        public System.IAsyncResult BeginPeek() { throw null; }
        public System.IAsyncResult BeginPeek(System.TimeSpan timeout) { throw null; }
        public System.IAsyncResult BeginPeek(System.TimeSpan timeout, object stateObject) { throw null; }
        public System.IAsyncResult BeginPeek(System.TimeSpan timeout, object stateObject, System.AsyncCallback callback) { throw null; }
        public System.IAsyncResult BeginReceive() { throw null; }
        public System.IAsyncResult BeginReceive(System.TimeSpan timeout) { throw null; }
        public System.IAsyncResult BeginReceive(System.TimeSpan timeout, object stateObject) { throw null; }
        public System.IAsyncResult BeginReceive(System.TimeSpan timeout, object stateObject, System.AsyncCallback callback) { throw null; }
        [System.MonoTODOAttribute]
        public static void ClearConnectionCache() { }
        public void Close() { }
        public static System.Messaging.MessageQueue Create(string path) { throw null; }
        public static System.Messaging.MessageQueue Create(string path, bool transactional) { throw null; }
        public static void Delete(string path) { }
        protected override void Dispose(bool disposing) { }
        public System.Messaging.Message EndPeek(System.IAsyncResult asyncResult) { throw null; }
        public System.Messaging.Message EndReceive(System.IAsyncResult asyncResult) { throw null; }
        public static bool Exists(string path) { throw null; }
        [System.MonoTODOAttribute]
        public System.Messaging.Message[] GetAllMessages() { throw null; }
        [System.ObsoleteAttribute]
        public System.Collections.IEnumerator GetEnumerator() { throw null; }
        [System.MonoTODOAttribute]
        public static System.Guid GetMachineId(string machineName) { throw null; }
        [System.ObsoleteAttribute]
        public System.Messaging.MessageEnumerator GetMessageEnumerator() { throw null; }
        [System.MonoTODOAttribute]
        public System.Messaging.MessageEnumerator GetMessageEnumerator2() { throw null; }
        [System.MonoTODOAttribute]
        public static System.Messaging.MessageQueueEnumerator GetMessageQueueEnumerator() { throw null; }
        [System.MonoTODOAttribute]
        public static System.Messaging.MessageQueueEnumerator GetMessageQueueEnumerator(System.Messaging.MessageQueueCriteria criteria) { throw null; }
        [System.MonoTODOAttribute]
        public static System.Messaging.MessageQueue[] GetPrivateQueuesByMachine(string machineName) { throw null; }
        public static System.Messaging.MessageQueue[] GetPublicQueues() { throw null; }
        [System.MonoTODOAttribute]
        public static System.Messaging.MessageQueue[] GetPublicQueues(System.Messaging.MessageQueueCriteria criteria) { throw null; }
        [System.MonoTODOAttribute]
        public static System.Messaging.MessageQueue[] GetPublicQueuesByCategory(System.Guid category) { throw null; }
        [System.MonoTODOAttribute]
        public static System.Messaging.MessageQueue[] GetPublicQueuesByLabel(string label) { throw null; }
        [System.MonoTODOAttribute]
        public static System.Messaging.MessageQueue[] GetPublicQueuesByMachine(string machineName) { throw null; }
        public System.Messaging.Message Peek() { throw null; }
        public System.Messaging.Message Peek(System.TimeSpan timeout) { throw null; }
        public System.Messaging.Message PeekByCorrelationId(string correlationId) { throw null; }
        public System.Messaging.Message PeekByCorrelationId(string correlationId, System.TimeSpan timeout) { throw null; }
        public System.Messaging.Message PeekById(string id) { throw null; }
        public System.Messaging.Message PeekById(string id, System.TimeSpan timeout) { throw null; }
        public void Purge() { }
        public System.Messaging.Message Receive() { throw null; }
        public System.Messaging.Message Receive(System.Messaging.MessageQueueTransaction transaction) { throw null; }
        public System.Messaging.Message Receive(System.Messaging.MessageQueueTransactionType transactionType) { throw null; }
        public System.Messaging.Message Receive(System.TimeSpan timeout) { throw null; }
        public System.Messaging.Message Receive(System.TimeSpan timeout, System.Messaging.MessageQueueTransaction transaction) { throw null; }
        public System.Messaging.Message Receive(System.TimeSpan timeout, System.Messaging.MessageQueueTransactionType transactionType) { throw null; }
        public System.Messaging.Message ReceiveByCorrelationId(string correlationId) { throw null; }
        public System.Messaging.Message ReceiveByCorrelationId(string correlationId, System.Messaging.MessageQueueTransaction transaction) { throw null; }
        public System.Messaging.Message ReceiveByCorrelationId(string correlationId, System.Messaging.MessageQueueTransactionType transactionType) { throw null; }
        public System.Messaging.Message ReceiveByCorrelationId(string correlationId, System.TimeSpan timeout) { throw null; }
        public System.Messaging.Message ReceiveByCorrelationId(string correlationId, System.TimeSpan timeout, System.Messaging.MessageQueueTransaction transaction) { throw null; }
        public System.Messaging.Message ReceiveByCorrelationId(string correlationId, System.TimeSpan timeout, System.Messaging.MessageQueueTransactionType transactionType) { throw null; }
        public System.Messaging.Message ReceiveById(string id) { throw null; }
        public System.Messaging.Message ReceiveById(string id, System.Messaging.MessageQueueTransaction transaction) { throw null; }
        public System.Messaging.Message ReceiveById(string id, System.Messaging.MessageQueueTransactionType transactionType) { throw null; }
        public System.Messaging.Message ReceiveById(string id, System.TimeSpan timeout) { throw null; }
        public System.Messaging.Message ReceiveById(string id, System.TimeSpan timeout, System.Messaging.MessageQueueTransaction transaction) { throw null; }
        public System.Messaging.Message ReceiveById(string id, System.TimeSpan timeout, System.Messaging.MessageQueueTransactionType transactionType) { throw null; }
        [System.MonoTODOAttribute]
        public void Refresh() { }
        [System.MonoTODOAttribute]
        public void ResetPermissions() { }
        public void Send(object obj) { }
        public void Send(object obj, System.Messaging.MessageQueueTransaction transaction) { }
        public void Send(object obj, System.Messaging.MessageQueueTransactionType transactionType) { }
        public void Send(object obj, string label) { }
        public void Send(object obj, string label, System.Messaging.MessageQueueTransaction transaction) { }
        public void Send(object obj, string label, System.Messaging.MessageQueueTransactionType transactionType) { }
        [System.MonoTODOAttribute]
        public void SetPermissions(System.Messaging.AccessControlList dacl) { }
        [System.MonoTODOAttribute]
        public void SetPermissions(System.Messaging.MessageQueueAccessControlEntry ace) { }
        [System.MonoTODOAttribute]
        public void SetPermissions(string user, System.Messaging.MessageQueueAccessRights rights) { }
        [System.MonoTODOAttribute]
        public void SetPermissions(string user, System.Messaging.MessageQueueAccessRights rights, System.Messaging.AccessControlEntryType entryType) { }
    }
    public partial class MessageQueueAccessControlEntry : System.Messaging.AccessControlEntry
    {
        [System.MonoTODOAttribute]
        public MessageQueueAccessControlEntry(System.Messaging.Trustee trustee, System.Messaging.MessageQueueAccessRights rights) { }
        [System.MonoTODOAttribute]
        public MessageQueueAccessControlEntry(System.Messaging.Trustee trustee, System.Messaging.MessageQueueAccessRights rights, System.Messaging.AccessControlEntryType entryType) { }
        public System.Messaging.MessageQueueAccessRights MessageQueueAccessRights { [System.MonoTODOAttribute]get { throw null; } [System.MonoTODOAttribute]set { } }
    }
    [System.FlagsAttribute]
    [System.SerializableAttribute]
    public enum MessageQueueAccessRights
    {
        ChangeQueuePermissions = 262144,
        DeleteJournalMessage = 8,
        DeleteMessage = 1,
        DeleteQueue = 65536,
        FullControl = 983103,
        GenericRead = 131115,
        GenericWrite = 131108,
        GetQueuePermissions = 131072,
        GetQueueProperties = 32,
        PeekMessage = 2,
        ReceiveJournalMessage = 10,
        ReceiveMessage = 3,
        SetQueueProperties = 16,
        TakeQueueOwnership = 524288,
        WriteMessage = 4,
    }
    public partial class MessageQueueCriteria
    {
        public MessageQueueCriteria() { }
        public System.Guid Category { get { throw null; } set { } }
        public System.DateTime CreatedAfter { get { throw null; } set { } }
        public System.DateTime CreatedBefore { get { throw null; } set { } }
        public string Label { get { throw null; } set { } }
        public string MachineName { get { throw null; } set { } }
        public System.DateTime ModifiedAfter { get { throw null; } set { } }
        public System.DateTime ModifiedBefore { get { throw null; } set { } }
        public void ClearAll() { }
    }
    public partial class MessageQueueEnumerator : System.MarshalByRefObject, System.Collections.IEnumerator, System.IDisposable
    {
        internal MessageQueueEnumerator() { }
        public System.Messaging.MessageQueue Current { get { throw null; } }
        public System.IntPtr LocatorHandle { [System.MonoTODOAttribute]get { throw null; } }
        object System.Collections.IEnumerator.Current { get { throw null; } }
        [System.MonoTODOAttribute]
        public void Close() { }
        public void Dispose() { }
        protected virtual void Dispose(bool disposing) { }
        ~MessageQueueEnumerator() { }
        public bool MoveNext() { throw null; }
        public void Reset() { }
    }
    [System.SerializableAttribute]
    public enum MessageQueueErrorCode
    {
        AccessDenied = -1072824283,
        BadSecurityContext = -1072824267,
        Base = -1072824320,
        BufferOverflow = -1072824294,
        CannotCreateCertificateStore = -1072824209,
        CannotCreateHashEx = -1072824191,
        CannotCreateOnGlobalCatalog = -1072824201,
        CannotGetDistinguishedName = -1072824194,
        CannotGrantAddGuid = -1072824206,
        CannotHashDataEx = -1072824193,
        CannotImpersonateClient = -1072824284,
        CannotJoinDomain = -1072824202,
        CannotLoadMsmqOcm = -1072824205,
        CannotOpenCertificateStore = -1072824208,
        CannotSetCryptographicSecurityDescriptor = -1072824212,
        CannotSignDataEx = -1072824192,
        CertificateNotProvided = -1072824211,
        ComputerDoesNotSupportEncryption = -1072824269,
        CorruptedInternalCertificate = -1072824275,
        CorruptedPersonalCertStore = -1072824271,
        CorruptedQueueWasDeleted = -1072824216,
        CorruptedSecurityData = -1072824272,
        CouldNotGetAccountInfo = -1072824265,
        CouldNotGetUserSid = -1072824266,
        DeleteConnectedNetworkInUse = -1072824248,
        DependentClientLicenseOverflow = -1072824217,
        DsError = -1072824253,
        DsIsFull = -1072824254,
        DtcConnect = -1072824244,
        EncryptionProviderNotSupported = -1072824213,
        FailVerifySignatureEx = -1072824190,
        FormatNameBufferTooSmall = -1072824289,
        Generic = -1072824319,
        GuidNotMatching = -1072824200,
        IllegalContext = -1072824229,
        IllegalCriteriaColumns = -1072824264,
        IllegalCursorAction = -1072824292,
        IllegalEnterpriseOperation = -1072824207,
        IllegalFormatName = -1072824290,
        IllegalMessageProperties = -1072824255,
        IllegalOperation = -1072824220,
        IllegalPrivateProperties = -1072824197,
        IllegalPropertyId = -1072824263,
        IllegalPropertySize = -1072824261,
        IllegalPropertyValue = -1072824296,
        IllegalPropertyVt = -1072824295,
        IllegalQueuePathName = -1072824300,
        IllegalQueueProperties = -1072824259,
        IllegalRelation = -1072824262,
        IllegalRestrictionPropertyId = -1072824260,
        IllegalSecurityDescriptor = -1072824287,
        IllegalSort = -1072824304,
        IllegalSortPropertyId = -1072824228,
        IllegalUser = -1072824303,
        InsufficientProperties = -1072824257,
        InsufficientResources = -1072824281,
        InvalidCertificate = -1072824276,
        InvalidHandle = -1072824313,
        InvalidOwner = -1072824252,
        InvalidParameter = -1072824314,
        IOTimeout = -1072824293,
        LabelBufferTooSmall = -1072824226,
        MachineExists = -1072824256,
        MachineNotFound = -1072824307,
        MessageAlreadyReceived = -1072824291,
        MessageStorageFailed = -1072824278,
        MissingConnectorType = -1072824235,
        MqisReadOnlyMode = -1072824224,
        MqisServerEmpty = -1072824225,
        NoDs = -1072824301,
        NoEntryPointMsmqOcm = -1072824204,
        NoGlobalCatalogInDomain = -1072824196,
        NoInternalUserCertificate = -1072824273,
        NoMsmqServersOnDc = -1072824203,
        NoMsmqServersOnGlobalCatalog = -1072824195,
        NoResponseFromObjectServer = -1072824247,
        ObjectServerNotAvailable = -1072824246,
        OperationCanceled = -1072824312,
        PrivilegeNotHeld = -1072824282,
        Property = -1072824318,
        PropertyNotAllowed = -1072824258,
        ProviderNameBufferTooSmall = -1072824221,
        PublicKeyDoesNotExist = -1072824198,
        PublicKeyNotFound = -1072824199,
        QDnsPropertyNotSupported = -1072824210,
        QueueDeleted = -1072824230,
        QueueExists = -1072824315,
        QueueNotAvailable = -1072824245,
        QueueNotFound = -1072824317,
        RemoteMachineNotAvailable = -1072824215,
        ResultBufferTooSmall = -1072824250,
        SecurityDescriptorBufferTooSmall = -1072824285,
        SenderCertificateBufferTooSmall = -1072824277,
        SenderIdBufferTooSmall = -1072824286,
        ServiceNotAvailable = -1072824309,
        SharingViolation = -1072824311,
        SignatureBufferTooSmall = -1072824222,
        StaleHandle = -1072824234,
        SymmetricKeyBufferTooSmall = -1072824223,
        TransactionEnlist = -1072824232,
        TransactionImport = -1072824242,
        TransactionSequence = -1072824239,
        TransactionUsage = -1072824240,
        UnsupportedAccessMode = -1072824251,
        UnsupportedFormatNameOperation = -1072824288,
        UnsupportedOperation = -1072824214,
        UserBufferTooSmall = -1072824280,
        WksCantServeClient = -1072824218,
        WriteNotAllowed = -1072824219,
    }
    [System.SerializableAttribute]
    public partial class MessageQueueException : System.Runtime.InteropServices.ExternalException
    {
        protected MessageQueueException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
        public override string Message { get { throw null; } }
        public System.Messaging.MessageQueueErrorCode MessageQueueErrorCode { get { throw null; } }
        public override void GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
    }
    public partial class MessageQueueInstaller : System.Configuration.Install.ComponentInstaller
    {
        [System.MonoTODOAttribute]
        public MessageQueueInstaller() { }
        [System.MonoTODOAttribute]
        public MessageQueueInstaller(System.Messaging.MessageQueue componentToCopy) { }
        [System.ComponentModel.DefaultValueAttribute(false)]
        public bool Authenticate { [System.MonoTODOAttribute]get { throw null; } [System.MonoTODOAttribute]set { } }
        [System.ComponentModel.DefaultValueAttribute(0)]
        public short BasePriority { [System.MonoTODOAttribute]get { throw null; } [System.MonoTODOAttribute]set { } }
        [System.ComponentModel.TypeConverterAttribute(typeof(System.ComponentModel.GuidConverter))]
        public System.Guid Category { [System.MonoTODOAttribute]get { throw null; } [System.MonoTODOAttribute]set { } }
        [System.ComponentModel.DefaultValueAttribute(System.Messaging.EncryptionRequired.None)]
        public System.Messaging.EncryptionRequired EncryptionRequired { [System.MonoTODOAttribute]get { throw null; } [System.MonoTODOAttribute]set { } }
        [System.ComponentModel.DefaultValueAttribute("")]
        public string Label { [System.MonoTODOAttribute]get { throw null; } [System.MonoTODOAttribute]set { } }
        [System.ComponentModel.TypeConverterAttribute(typeof(System.Drawing.SizeConverter))]
        public long MaximumJournalSize { [System.MonoTODOAttribute]get { throw null; } [System.MonoTODOAttribute]set { } }
        [System.ComponentModel.TypeConverterAttribute(typeof(System.Drawing.SizeConverter))]
        public long MaximumQueueSize { [System.MonoTODOAttribute]get { throw null; } [System.MonoTODOAttribute]set { } }
        [System.ComponentModel.DefaultValueAttribute("")]
        [System.ComponentModel.EditorAttribute("System.Messaging.Design.QueuePathEditor", "System.Drawing.Design.UITypeEditor, System.Drawing, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
        [System.ComponentModel.TypeConverterAttribute("System.Diagnostics.Design.StringValueConverter, System.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
        public string Path { [System.MonoTODOAttribute]get { throw null; } [System.MonoTODOAttribute]set { } }
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.DesignerSerializationVisibilityAttribute(System.ComponentModel.DesignerSerializationVisibility.Hidden)]
        public System.Messaging.AccessControlList Permissions { [System.MonoTODOAttribute]get { throw null; } [System.MonoTODOAttribute]set { } }
        [System.ComponentModel.DefaultValueAttribute(false)]
        public bool Transactional { [System.MonoTODOAttribute]get { throw null; } [System.MonoTODOAttribute]set { } }
        [System.ComponentModel.DefaultValueAttribute(System.Configuration.Install.UninstallAction.Remove)]
        public System.Configuration.Install.UninstallAction UninstallAction { [System.MonoTODOAttribute]get { throw null; } [System.MonoTODOAttribute]set { } }
        [System.ComponentModel.DefaultValueAttribute(false)]
        public bool UseJournalQueue { [System.MonoTODOAttribute]get { throw null; } [System.MonoTODOAttribute]set { } }
        [System.MonoTODOAttribute]
        public override void Commit(System.Collections.IDictionary savedState) { }
        [System.MonoTODOAttribute]
        public override void CopyFromComponent(System.ComponentModel.IComponent component) { }
        [System.MonoTODOAttribute]
        public override void Install(System.Collections.IDictionary stateSaver) { }
        [System.MonoTODOAttribute]
        public override bool IsEquivalentInstaller(System.Configuration.Install.ComponentInstaller otherInstaller) { throw null; }
        [System.MonoTODOAttribute]
        public override void Rollback(System.Collections.IDictionary savedState) { }
        [System.MonoTODOAttribute]
        public override void Uninstall(System.Collections.IDictionary savedState) { }
    }
    [System.SerializableAttribute]
    public sealed partial class MessageQueuePermission : System.Security.CodeAccessPermission, System.Security.Permissions.IUnrestrictedPermission
    {
        public MessageQueuePermission() { }
        public MessageQueuePermission(System.Messaging.MessageQueuePermissionAccess permissionAccess, string path) { }
        public MessageQueuePermission(System.Messaging.MessageQueuePermissionAccess permissionAccess, string machineName, string label, string category) { }
        public MessageQueuePermission(System.Messaging.MessageQueuePermissionEntry[] permissionAccessEntries) { }
        public MessageQueuePermission(System.Security.Permissions.PermissionState state) { }
        public System.Messaging.MessageQueuePermissionEntryCollection PermissionEntries { get { throw null; } }
        public override System.Security.IPermission Copy() { throw null; }
        [System.MonoTODOAttribute]
        public override void FromXml(System.Security.SecurityElement securityElement) { }
        [System.MonoTODOAttribute]
        public override System.Security.IPermission Intersect(System.Security.IPermission target) { throw null; }
        [System.MonoTODOAttribute]
        public override bool IsSubsetOf(System.Security.IPermission target) { throw null; }
        public bool IsUnrestricted() { throw null; }
        [System.MonoTODOAttribute]
        public override System.Security.SecurityElement ToXml() { throw null; }
        [System.MonoTODOAttribute]
        public override System.Security.IPermission Union(System.Security.IPermission target) { throw null; }
    }
    [System.FlagsAttribute]
    [System.SerializableAttribute]
    public enum MessageQueuePermissionAccess
    {
        Administer = 62,
        Browse = 2,
        None = 0,
        Peek = 10,
        Receive = 26,
        Send = 6,
    }
    [System.AttributeUsageAttribute(System.AttributeTargets.Assembly | System.AttributeTargets.Class | System.AttributeTargets.Constructor | System.AttributeTargets.Event | System.AttributeTargets.Method | System.AttributeTargets.Struct, AllowMultiple=true, Inherited=false)]
    [System.SerializableAttribute]
    public partial class MessageQueuePermissionAttribute : System.Security.Permissions.CodeAccessSecurityAttribute
    {
        public MessageQueuePermissionAttribute(System.Security.Permissions.SecurityAction action) : base (default(System.Security.Permissions.SecurityAction)) { }
        public string Category { get { throw null; } set { } }
        public string Label { get { throw null; } set { } }
        public string MachineName { get { throw null; } set { } }
        public string Path { get { throw null; } set { } }
        public System.Messaging.MessageQueuePermissionAccess PermissionAccess { get { throw null; } set { } }
        public override System.Security.IPermission CreatePermission() { throw null; }
    }
    [System.SerializableAttribute]
    public partial class MessageQueuePermissionEntry
    {
        public MessageQueuePermissionEntry(System.Messaging.MessageQueuePermissionAccess permissionAccess, string path) { }
        public MessageQueuePermissionEntry(System.Messaging.MessageQueuePermissionAccess permissionAccess, string machineName, string label, string category) { }
        public string Category { get { throw null; } }
        public string Label { get { throw null; } }
        public string MachineName { get { throw null; } }
        public string Path { get { throw null; } }
        public System.Messaging.MessageQueuePermissionAccess PermissionAccess { get { throw null; } }
    }
    [System.SerializableAttribute]
    public partial class MessageQueuePermissionEntryCollection : System.Collections.CollectionBase
    {
        internal MessageQueuePermissionEntryCollection() { }
        public System.Messaging.MessageQueuePermissionEntry this[int index] { get { throw null; } set { } }
        public int Add(System.Messaging.MessageQueuePermissionEntry value) { throw null; }
        public void AddRange(System.Messaging.MessageQueuePermissionEntryCollection value) { }
        public void AddRange(System.Messaging.MessageQueuePermissionEntry[] value) { }
        public bool Contains(System.Messaging.MessageQueuePermissionEntry value) { throw null; }
        public void CopyTo(System.Messaging.MessageQueuePermissionEntry[] array, int index) { }
        [System.MonoTODOAttribute]
        public int IndexOf(System.Messaging.MessageQueuePermissionEntry value) { throw null; }
        public void Insert(int index, System.Messaging.MessageQueuePermissionEntry value) { }
        [System.MonoTODOAttribute]
        protected override void OnClear() { }
        [System.MonoTODOAttribute]
        protected override void OnInsert(int index, object value) { }
        [System.MonoTODOAttribute]
        protected override void OnRemove(int index, object value) { }
        [System.MonoTODOAttribute]
        protected override void OnSet(int index, object oldValue, object newValue) { }
        public void Remove(System.Messaging.MessageQueuePermissionEntry value) { }
    }
    public partial class MessageQueueTransaction : System.IDisposable
    {
        public MessageQueueTransaction() { }
        public System.Messaging.MessageQueueTransactionStatus Status { get { throw null; } }
        public void Abort() { }
        public void Begin() { }
        public void Commit() { }
        public void Dispose() { }
        protected virtual void Dispose(bool disposing) { }
        ~MessageQueueTransaction() { }
    }
    [System.SerializableAttribute]
    public enum MessageQueueTransactionStatus
    {
        Aborted = 0,
        Committed = 1,
        Initialized = 2,
        Pending = 3,
    }
    [System.SerializableAttribute]
    public enum MessageQueueTransactionType
    {
        Automatic = 1,
        None = 0,
        Single = 3,
    }
    [System.SerializableAttribute]
    public enum MessageType
    {
        Acknowledgment = 1,
        Normal = 2,
        Report = 3,
    }
    [System.AttributeUsageAttribute(System.AttributeTargets.All)]
    public partial class MessagingDescriptionAttribute : System.ComponentModel.DescriptionAttribute
    {
        [System.MonoTODOAttribute("localization")]
        public MessagingDescriptionAttribute(string description) { }
        [System.MonoTODOAttribute("localization")]
        public override string Description { get { throw null; } }
    }
    public partial class PeekCompletedEventArgs : System.EventArgs
    {
        internal PeekCompletedEventArgs() { }
        public System.IAsyncResult AsyncResult { get { throw null; } set { } }
        public System.Messaging.Message Message { get { throw null; } }
    }
    [System.SerializableAttribute]
    public delegate void PeekCompletedEventHandler(object sender, System.Messaging.PeekCompletedEventArgs e);
    public enum QueueAccessMode
    {
        Peek = 32,
        PeekAndAdmin = 160,
        Receive = 1,
        ReceiveAndAdmin = 129,
        Send = 2,
        SendAndReceive = 3,
    }
    public partial class ReceiveCompletedEventArgs : System.EventArgs
    {
        internal ReceiveCompletedEventArgs() { }
        public System.IAsyncResult AsyncResult { get { throw null; } set { } }
        public System.Messaging.Message Message { get { throw null; } }
    }
    [System.SerializableAttribute]
    public delegate void ReceiveCompletedEventHandler(object sender, System.Messaging.ReceiveCompletedEventArgs e);
    [System.FlagsAttribute]
    [System.SerializableAttribute]
    public enum StandardAccessRights
    {
        All = 2031616,
        Delete = 65536,
        Execute = 131072,
        ModifyOwner = 524288,
        None = 0,
        Read = 131072,
        ReadSecurity = 131072,
        Required = 851968,
        Synchronize = 1048576,
        Write = 131072,
        WriteSecurity = 262144,
    }
    public partial class Trustee
    {
        [System.MonoTODOAttribute]
        public Trustee() { }
        [System.MonoTODOAttribute("What about systemName?")]
        public Trustee(string name) { }
        public Trustee(string name, string systemName) { }
        public Trustee(string name, string systemName, System.Messaging.TrusteeType trusteeType) { }
        public string Name { get { throw null; } set { } }
        public string SystemName { get { throw null; } set { } }
        public System.Messaging.TrusteeType TrusteeType { get { throw null; } set { } }
    }
    [System.SerializableAttribute]
    public enum TrusteeType
    {
        Alias = 4,
        Computer = 5,
        Domain = 3,
        Group = 2,
        Unknown = 0,
        User = 1,
    }
    public partial class XmlMessageFormatter : System.ICloneable, System.Messaging.IMessageFormatter
    {
        public XmlMessageFormatter() { }
        public XmlMessageFormatter(string[] targetTypeNames) { }
        public XmlMessageFormatter(System.Type[] targetTypes) { }
        [System.Messaging.MessagingDescriptionAttribute("XmlMsgTargetTypeNames")]
        public string[] TargetTypeNames { get { throw null; } set { } }
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.DesignerSerializationVisibilityAttribute(System.ComponentModel.DesignerSerializationVisibility.Hidden)]
        [System.Messaging.MessagingDescriptionAttribute("XmlMsgTargetTypes")]
        public System.Type[] TargetTypes { get { throw null; } set { } }
        [System.MonoTODOAttribute]
        public bool CanRead(System.Messaging.Message message) { throw null; }
        public object Clone() { throw null; }
        public object Read(System.Messaging.Message message) { throw null; }
        public void Write(System.Messaging.Message message, object obj) { }
    }
}
namespace System.Messaging.Design
{
    [System.MonoTODOAttribute]
    public partial class QueuePathDialog : System.Windows.Forms.Form
    {
        [System.MonoTODOAttribute]
        public QueuePathDialog(System.IServiceProvider provider) { }
        [System.MonoTODOAttribute]
        public QueuePathDialog(System.Windows.Forms.Design.IUIService uiService) { }
        [System.MonoTODOAttribute]
        public string Path { get { throw null; } }
        [System.MonoTODOAttribute]
        public void ChoosePath() { }
        [System.MonoTODOAttribute]
        public void DoubleClicked(object source, System.EventArgs e) { }
        [System.MonoTODOAttribute]
        public void SelectQueue(System.Messaging.MessageQueue queue) { }
    }
    public partial class QueuePathEditor : System.Drawing.Design.UITypeEditor
    {
        [System.MonoTODOAttribute]
        public QueuePathEditor() { }
        [System.MonoTODOAttribute]
        public override object EditValue(System.ComponentModel.ITypeDescriptorContext context, System.IServiceProvider provider, object value) { throw null; }
        [System.MonoTODOAttribute]
        public override System.Drawing.Design.UITypeEditorEditStyle GetEditStyle(System.ComponentModel.ITypeDescriptorContext context) { throw null; }
    }
}
