// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

[assembly:System.Reflection.AssemblyVersionAttribute("4.0.0.0")]
[assembly:System.CLSCompliantAttribute(true)]
[assembly:System.Diagnostics.DebuggableAttribute((System.Diagnostics.DebuggableAttribute.DebuggingModes)(258))]
[assembly:System.Reflection.AssemblyCompanyAttribute("Mono development team")]
[assembly:System.Reflection.AssemblyCopyrightAttribute("(c) Various Mono authors")]
[assembly:System.Reflection.AssemblyDefaultAliasAttribute("System.Transactions.dll")]
[assembly:System.Reflection.AssemblyDescriptionAttribute("System.Transactions.dll")]
[assembly:System.Reflection.AssemblyFileVersionAttribute("4.0.30319.17020")]
[assembly:System.Reflection.AssemblyInformationalVersionAttribute("4.0.30319.17020")]
[assembly:System.Reflection.AssemblyProductAttribute("Mono Common Language Infrastructure")]
[assembly:System.Reflection.AssemblyTitleAttribute("System.Transactions.dll")]
[assembly:System.Resources.NeutralResourcesLanguageAttribute("en-US")]
[assembly:System.Resources.SatelliteContractVersionAttribute("4.0.0.0")]
[assembly:System.Runtime.CompilerServices.ReferenceAssemblyAttribute]
[assembly:System.Runtime.CompilerServices.RuntimeCompatibilityAttribute(WrapNonExceptionThrows=true)]
[assembly:System.Runtime.InteropServices.BestFitMappingAttribute(false)]
[assembly:System.Runtime.InteropServices.ComVisibleAttribute(false)]
[assembly:System.Security.AllowPartiallyTrustedCallersAttribute]
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
namespace System.Transactions
{
    [System.SerializableAttribute]
    public sealed partial class CommittableTransaction : System.Transactions.Transaction, System.IAsyncResult
    {
        public CommittableTransaction() { }
        public CommittableTransaction(System.TimeSpan timeout) { }
        public CommittableTransaction(System.Transactions.TransactionOptions options) { }
        object System.IAsyncResult.AsyncState { get { throw null; } }
        System.Threading.WaitHandle System.IAsyncResult.AsyncWaitHandle { get { throw null; } }
        bool System.IAsyncResult.CompletedSynchronously { get { throw null; } }
        bool System.IAsyncResult.IsCompleted { get { throw null; } }
        public System.IAsyncResult BeginCommit(System.AsyncCallback asyncCallback, object asyncState) { throw null; }
        public void Commit() { }
        public void EndCommit(System.IAsyncResult asyncResult) { }
    }
    public enum DependentCloneOption
    {
        BlockCommitUntilComplete = 0,
        RollbackIfNotComplete = 1,
    }
    [System.MonoTODOAttribute("Not supported yet")]
    [System.SerializableAttribute]
    public sealed partial class DependentTransaction : System.Transactions.Transaction
    {
        internal DependentTransaction() { }
        [System.MonoTODOAttribute]
        public void Complete() { }
    }
    public sealed partial class DistributedTransactionPermission : System.Security.CodeAccessPermission, System.Security.Permissions.IUnrestrictedPermission
    {
        public DistributedTransactionPermission(System.Security.Permissions.PermissionState state) { }
        public override System.Security.IPermission Copy() { throw null; }
        public override void FromXml(System.Security.SecurityElement securityElement) { }
        public override System.Security.IPermission Intersect(System.Security.IPermission target) { throw null; }
        public override bool IsSubsetOf(System.Security.IPermission target) { throw null; }
        public bool IsUnrestricted() { throw null; }
        public override System.Security.SecurityElement ToXml() { throw null; }
        public override System.Security.IPermission Union(System.Security.IPermission target) { throw null; }
    }
    public sealed partial class DistributedTransactionPermissionAttribute : System.Security.Permissions.CodeAccessSecurityAttribute
    {
        public DistributedTransactionPermissionAttribute(System.Security.Permissions.SecurityAction action) : base (default(System.Security.Permissions.SecurityAction)) { }
        public new bool Unrestricted { get { throw null; } set { } }
        public override System.Security.IPermission CreatePermission() { throw null; }
    }
    public partial class Enlistment
    {
        internal Enlistment() { }
        public void Done() { }
    }
    [System.FlagsAttribute]
    public enum EnlistmentOptions
    {
        EnlistDuringPrepareRequired = 1,
        None = 0,
    }
    public enum EnterpriseServicesInteropOption
    {
        Automatic = 1,
        Full = 2,
        None = 0,
    }
    public delegate System.Transactions.Transaction HostCurrentTransactionCallback();
    [System.Runtime.InteropServices.InterfaceTypeAttribute((System.Runtime.InteropServices.ComInterfaceType)(1))]
    public partial interface IDtcTransaction
    {
        void Abort(System.IntPtr reason, int retaining, int async);
        void Commit(int retaining, [System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.I4)]int commitType, int reserved);
        void GetTransactionInfo(System.IntPtr transactionInformation);
    }
    public partial interface IEnlistmentNotification
    {
        void Commit(System.Transactions.Enlistment enlistment);
        void InDoubt(System.Transactions.Enlistment enlistment);
        void Prepare(System.Transactions.PreparingEnlistment preparingEnlistment);
        void Rollback(System.Transactions.Enlistment enlistment);
    }
    public partial interface IPromotableSinglePhaseNotification : System.Transactions.ITransactionPromoter
    {
        void Initialize();
        void Rollback(System.Transactions.SinglePhaseEnlistment singlePhaseEnlistment);
        void SinglePhaseCommit(System.Transactions.SinglePhaseEnlistment singlePhaseEnlistment);
    }
    public partial interface ISimpleTransactionSuperior : System.Transactions.ITransactionPromoter
    {
        void Rollback();
    }
    public partial interface ISinglePhaseNotification : System.Transactions.IEnlistmentNotification
    {
        void SinglePhaseCommit(System.Transactions.SinglePhaseEnlistment singlePhaseEnlistment);
    }
    public enum IsolationLevel
    {
        Chaos = 5,
        ReadCommitted = 2,
        ReadUncommitted = 3,
        RepeatableRead = 1,
        Serializable = 0,
        Snapshot = 4,
        Unspecified = 6,
    }
    public partial interface ITransactionPromoter
    {
        byte[] Promote();
    }
    public partial class PreparingEnlistment : System.Transactions.Enlistment
    {
        internal PreparingEnlistment() { }
        public void ForceRollback() { }
        [System.MonoTODOAttribute]
        public void ForceRollback(System.Exception e) { }
        [System.MonoTODOAttribute]
        public void Prepared() { }
        [System.MonoTODOAttribute]
        public byte[] RecoveryInformation() { throw null; }
    }
    public partial class SinglePhaseEnlistment : System.Transactions.Enlistment
    {
        internal SinglePhaseEnlistment() { }
        public void Aborted() { }
        public void Aborted(System.Exception e) { }
        [System.MonoTODOAttribute]
        public void Committed() { }
        [System.MonoTODOAttribute("Not implemented")]
        public void InDoubt() { }
        [System.MonoTODOAttribute("Not implemented")]
        public void InDoubt(System.Exception e) { }
    }
    [System.SerializableAttribute]
    public sealed partial class SubordinateTransaction : System.Transactions.Transaction
    {
        public SubordinateTransaction(System.Transactions.IsolationLevel isoLevel, System.Transactions.ISimpleTransactionSuperior superior) { }
    }
    [System.SerializableAttribute]
    public partial class Transaction : System.IDisposable, System.Runtime.Serialization.ISerializable
    {
        internal Transaction() { }
        public static System.Transactions.Transaction Current { get { throw null; } set { } }
        public System.Transactions.IsolationLevel IsolationLevel { get { throw null; } }
        public System.Transactions.TransactionInformation TransactionInformation { get { throw null; } }
        public event System.Transactions.TransactionCompletedEventHandler TransactionCompleted { add { } remove { } }
        public System.Transactions.Transaction Clone() { throw null; }
        [System.MonoTODOAttribute]
        public System.Transactions.DependentTransaction DependentClone(System.Transactions.DependentCloneOption cloneOption) { throw null; }
        public void Dispose() { }
        [System.MonoTODOAttribute("Only SinglePhase commit supported for durable resource managers.")]
        [System.Security.Permissions.PermissionSetAttribute(System.Security.Permissions.SecurityAction.LinkDemand)]
        public System.Transactions.Enlistment EnlistDurable(System.Guid resourceManagerIdentifier, System.Transactions.IEnlistmentNotification enlistmentNotification, System.Transactions.EnlistmentOptions enlistmentOptions) { throw null; }
        [System.MonoTODOAttribute("Only Local Transaction Manager supported. Cannot have more than 1 durable resource per transaction. Only EnlistmentOptions.None supported yet.")]
        [System.Security.Permissions.PermissionSetAttribute(System.Security.Permissions.SecurityAction.LinkDemand)]
        public System.Transactions.Enlistment EnlistDurable(System.Guid resourceManagerIdentifier, System.Transactions.ISinglePhaseNotification singlePhaseNotification, System.Transactions.EnlistmentOptions enlistmentOptions) { throw null; }
        public bool EnlistPromotableSinglePhase(System.Transactions.IPromotableSinglePhaseNotification promotableSinglePhaseNotification) { throw null; }
        [System.MonoTODOAttribute("EnlistmentOptions being ignored")]
        public System.Transactions.Enlistment EnlistVolatile(System.Transactions.IEnlistmentNotification enlistmentNotification, System.Transactions.EnlistmentOptions enlistmentOptions) { throw null; }
        [System.MonoTODOAttribute("EnlistmentOptions being ignored")]
        public System.Transactions.Enlistment EnlistVolatile(System.Transactions.ISinglePhaseNotification singlePhaseNotification, System.Transactions.EnlistmentOptions enlistmentOptions) { throw null; }
        public override bool Equals(object obj) { throw null; }
        public override int GetHashCode() { throw null; }
        public static bool operator ==(System.Transactions.Transaction x, System.Transactions.Transaction y) { throw null; }
        public static bool operator !=(System.Transactions.Transaction x, System.Transactions.Transaction y) { throw null; }
        public void Rollback() { }
        public void Rollback(System.Exception e) { }
        [System.MonoTODOAttribute]
        void System.Runtime.Serialization.ISerializable.GetObjectData(System.Runtime.Serialization.SerializationInfo serializationInfo, System.Runtime.Serialization.StreamingContext context) { }
    }
    [System.SerializableAttribute]
    public partial class TransactionAbortedException : System.Transactions.TransactionException
    {
        public TransactionAbortedException() { }
        protected TransactionAbortedException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
        public TransactionAbortedException(string message) { }
        public TransactionAbortedException(string message, System.Exception innerException) { }
    }
    public delegate void TransactionCompletedEventHandler(object sender, System.Transactions.TransactionEventArgs e);
    public partial class TransactionEventArgs : System.EventArgs
    {
        public TransactionEventArgs() { }
        public System.Transactions.Transaction Transaction { get { throw null; } }
    }
    [System.SerializableAttribute]
    public partial class TransactionException : System.SystemException
    {
        public TransactionException() { }
        protected TransactionException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
        public TransactionException(string message) { }
        public TransactionException(string message, System.Exception innerException) { }
    }
    [System.SerializableAttribute]
    public partial class TransactionInDoubtException : System.Transactions.TransactionException
    {
        public TransactionInDoubtException() { }
        protected TransactionInDoubtException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
        public TransactionInDoubtException(string message) { }
        public TransactionInDoubtException(string message, System.Exception innerException) { }
    }
    public partial class TransactionInformation
    {
        internal TransactionInformation() { }
        public System.DateTime CreationTime { get { throw null; } }
        public System.Guid DistributedIdentifier { get { throw null; } }
        public string LocalIdentifier { get { throw null; } }
        public System.Transactions.TransactionStatus Status { get { throw null; } }
    }
    [System.MonoTODOAttribute]
    public static partial class TransactionInterop
    {
        [System.MonoTODOAttribute]
        public static System.Transactions.IDtcTransaction GetDtcTransaction(System.Transactions.Transaction transaction) { throw null; }
        [System.MonoTODOAttribute]
        public static byte[] GetExportCookie(System.Transactions.Transaction transaction, byte[] whereabouts) { throw null; }
        [System.MonoTODOAttribute]
        public static System.Transactions.Transaction GetTransactionFromDtcTransaction(System.Transactions.IDtcTransaction transactionNative) { throw null; }
        [System.MonoTODOAttribute]
        public static System.Transactions.Transaction GetTransactionFromExportCookie(byte[] cookie) { throw null; }
        [System.MonoTODOAttribute]
        public static System.Transactions.Transaction GetTransactionFromTransmitterPropagationToken(byte[] propagationToken) { throw null; }
        [System.MonoTODOAttribute]
        public static byte[] GetTransmitterPropagationToken(System.Transactions.Transaction transaction) { throw null; }
        [System.MonoTODOAttribute]
        public static byte[] GetWhereabouts() { throw null; }
    }
    public static partial class TransactionManager
    {
        public static System.TimeSpan DefaultTimeout { get { throw null; } }
        [System.MonoTODOAttribute("Not implemented")]
        public static System.Transactions.HostCurrentTransactionCallback HostCurrentCallback { get { throw null; } set { } }
        public static System.TimeSpan MaximumTimeout { get { throw null; } }
        public static event System.Transactions.TransactionStartedEventHandler DistributedTransactionStarted { add { } remove { } }
        [System.MonoTODOAttribute("Not implemented")]
        public static void RecoveryComplete(System.Guid resourceManagerIdentifier) { }
        [System.MonoTODOAttribute("Not implemented")]
        public static System.Transactions.Enlistment Reenlist(System.Guid resourceManagerIdentifier, byte[] recoveryInformation, System.Transactions.IEnlistmentNotification enlistmentNotification) { throw null; }
    }
    [System.SerializableAttribute]
    public partial class TransactionManagerCommunicationException : System.Transactions.TransactionException
    {
        public TransactionManagerCommunicationException() { }
        protected TransactionManagerCommunicationException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
        public TransactionManagerCommunicationException(string message) { }
        public TransactionManagerCommunicationException(string message, System.Exception innerException) { }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public partial struct TransactionOptions
    {
        private int _dummyPrimitive;
        public System.Transactions.IsolationLevel IsolationLevel { get { throw null; } set { } }
        public System.TimeSpan Timeout { get { throw null; } set { } }
        public override bool Equals(object obj) { throw null; }
        public override int GetHashCode() { throw null; }
        public static bool operator ==(System.Transactions.TransactionOptions x, System.Transactions.TransactionOptions y) { throw null; }
        public static bool operator !=(System.Transactions.TransactionOptions x, System.Transactions.TransactionOptions y) { throw null; }
    }
    [System.SerializableAttribute]
    public partial class TransactionPromotionException : System.Transactions.TransactionException
    {
        public TransactionPromotionException() { }
        protected TransactionPromotionException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
        public TransactionPromotionException(string message) { }
        public TransactionPromotionException(string message, System.Exception innerException) { }
    }
    public sealed partial class TransactionScope : System.IDisposable
    {
        public TransactionScope() { }
        public TransactionScope(System.Transactions.Transaction transactionToUse) { }
        public TransactionScope(System.Transactions.Transaction transactionToUse, System.TimeSpan scopeTimeout) { }
        [System.MonoTODOAttribute("EnterpriseServicesInteropOption not supported.")]
        public TransactionScope(System.Transactions.Transaction transactionToUse, System.TimeSpan scopeTimeout, System.Transactions.EnterpriseServicesInteropOption interopOption) { }
        public TransactionScope(System.Transactions.Transaction transactionToUse, System.TimeSpan scopeTimeout, System.Transactions.TransactionScopeAsyncFlowOption asyncFlowOption) { }
        public TransactionScope(System.Transactions.Transaction transactionToUse, System.Transactions.TransactionScopeAsyncFlowOption asyncFlowOption) { }
        public TransactionScope(System.Transactions.TransactionScopeAsyncFlowOption asyncFlowOption) { }
        public TransactionScope(System.Transactions.TransactionScopeOption scopeOption) { }
        public TransactionScope(System.Transactions.TransactionScopeOption scopeOption, System.TimeSpan scopeTimeout) { }
        public TransactionScope(System.Transactions.TransactionScopeOption scopeOption, System.TimeSpan scopeTimeout, System.Transactions.TransactionScopeAsyncFlowOption asyncFlowOption) { }
        public TransactionScope(System.Transactions.TransactionScopeOption scopeOption, System.Transactions.TransactionOptions transactionOptions) { }
        [System.MonoTODOAttribute("EnterpriseServicesInteropOption not supported")]
        public TransactionScope(System.Transactions.TransactionScopeOption scopeOption, System.Transactions.TransactionOptions transactionOptions, System.Transactions.EnterpriseServicesInteropOption interopOption) { }
        public TransactionScope(System.Transactions.TransactionScopeOption scopeOption, System.Transactions.TransactionOptions transactionOptions, System.Transactions.TransactionScopeAsyncFlowOption asyncFlowOption) { }
        public TransactionScope(System.Transactions.TransactionScopeOption scopeOption, System.Transactions.TransactionScopeAsyncFlowOption asyncFlowOption) { }
        public void Complete() { }
        public void Dispose() { }
    }
    public enum TransactionScopeAsyncFlowOption
    {
        Enabled = 1,
        Suppress = 0,
    }
    public enum TransactionScopeOption
    {
        Required = 0,
        RequiresNew = 1,
        Suppress = 2,
    }
    public delegate void TransactionStartedEventHandler(object sender, System.Transactions.TransactionEventArgs e);
    public enum TransactionStatus
    {
        Aborted = 2,
        Active = 0,
        Committed = 1,
        InDoubt = 3,
    }
}
namespace System.Transactions.Configuration
{
    public sealed partial class DefaultSettingsSection : System.Configuration.ConfigurationSection
    {
        public DefaultSettingsSection() { }
        [System.Configuration.ConfigurationPropertyAttribute("distributedTransactionManagerName", DefaultValue="")]
        public string DistributedTransactionManagerName { get { throw null; } set { } }
        protected override System.Configuration.ConfigurationPropertyCollection Properties { get { throw null; } }
        [System.Configuration.ConfigurationPropertyAttribute("timeout", DefaultValue="00:01:00")]
        [System.Configuration.TimeSpanValidatorAttribute(MinValueString="00:00:00", MaxValueString="10675199.02:48:05.4775807")]
        public System.TimeSpan Timeout { get { throw null; } set { } }
    }
    public sealed partial class MachineSettingsSection : System.Configuration.ConfigurationSection
    {
        public MachineSettingsSection() { }
        [System.Configuration.ConfigurationPropertyAttribute("maxTimeout", DefaultValue="00:10:00")]
        [System.Configuration.TimeSpanValidatorAttribute(MinValueString="00:00:00", MaxValueString="10675199.02:48:05.4775807")]
        public System.TimeSpan MaxTimeout { get { throw null; } set { } }
        protected override System.Configuration.ConfigurationPropertyCollection Properties { get { throw null; } }
    }
    public sealed partial class TransactionsSectionGroup : System.Configuration.ConfigurationSectionGroup
    {
        public TransactionsSectionGroup() { }
        [System.Configuration.ConfigurationPropertyAttribute("defaultSettings")]
        public System.Transactions.Configuration.DefaultSettingsSection DefaultSettings { get { throw null; } }
        [System.Configuration.ConfigurationPropertyAttribute("machineSettings")]
        public System.Transactions.Configuration.MachineSettingsSection MachineSettings { get { throw null; } }
        public static System.Transactions.Configuration.TransactionsSectionGroup GetSectionGroup(System.Configuration.Configuration config) { throw null; }
    }
}
