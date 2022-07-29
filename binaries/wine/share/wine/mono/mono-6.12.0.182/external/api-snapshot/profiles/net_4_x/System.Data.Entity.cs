// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

[assembly:System.Reflection.AssemblyVersionAttribute("4.0.0.0")]
[assembly:System.CLSCompliantAttribute(true)]
[assembly:System.Diagnostics.DebuggableAttribute(System.Diagnostics.DebuggableAttribute.DebuggingModes.IgnoreSymbolStoreSequencePoints)]
[assembly:System.Reflection.AssemblyCompanyAttribute("Mono development team")]
[assembly:System.Reflection.AssemblyCopyrightAttribute("(c) Various Mono authors")]
[assembly:System.Reflection.AssemblyDefaultAliasAttribute("System.Data.Entity.dll")]
[assembly:System.Reflection.AssemblyDescriptionAttribute("System.Data.Entity.dll")]
[assembly:System.Reflection.AssemblyFileVersionAttribute("4.6.57.0")]
[assembly:System.Reflection.AssemblyInformationalVersionAttribute("4.6.57.0")]
[assembly:System.Reflection.AssemblyProductAttribute("Mono Common Language Infrastructure")]
[assembly:System.Reflection.AssemblyTitleAttribute("System.Data.Entity.dll")]
[assembly:System.Resources.NeutralResourcesLanguageAttribute("en-US")]
[assembly:System.Resources.SatelliteContractVersionAttribute("4.0.0.0")]
[assembly:System.Runtime.CompilerServices.CompilationRelaxationsAttribute(8)]
[assembly:System.Runtime.CompilerServices.RuntimeCompatibilityAttribute(WrapNonExceptionThrows=true)]
[assembly:System.Runtime.InteropServices.ComVisibleAttribute(false)]
namespace System.Data
{
    [System.SerializableAttribute]
    public sealed partial class EntityCommandCompilationException : System.Data.EntityException
    {
        public EntityCommandCompilationException() { }
        public EntityCommandCompilationException(string message) { }
        public EntityCommandCompilationException(string message, System.Exception innerException) { }
    }
    [System.SerializableAttribute]
    public sealed partial class EntityCommandExecutionException : System.Data.EntityException
    {
        public EntityCommandExecutionException() { }
        public EntityCommandExecutionException(string message) { }
        public EntityCommandExecutionException(string message, System.Exception innerException) { }
    }
    [System.SerializableAttribute]
    public partial class EntityException : System.Data.DataException
    {
        public EntityException() { }
        protected EntityException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
        public EntityException(string message) { }
        public EntityException(string message, System.Exception innerException) { }
    }
    [System.Diagnostics.DebuggerDisplayAttribute("{ConcatKeyValue()}")]
    [System.Runtime.Serialization.DataContractAttribute(IsReference=true)]
    [System.SerializableAttribute]
    public sealed partial class EntityKey : System.IEquatable<System.Data.EntityKey>
    {
        public static readonly System.Data.EntityKey EntityNotValidKey;
        public static readonly System.Data.EntityKey NoEntitySetKey;
        public EntityKey() { }
        public EntityKey(string qualifiedEntitySetName, System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<string, object>> entityKeyValues) { }
        public EntityKey(string qualifiedEntitySetName, System.Collections.Generic.IEnumerable<System.Data.EntityKeyMember> entityKeyValues) { }
        public EntityKey(string qualifiedEntitySetName, string keyName, object keyValue) { }
        [System.Runtime.Serialization.DataMemberAttribute]
        public string EntityContainerName { get { throw null; } set { } }
        [System.Runtime.Serialization.DataMemberAttribute]
        public System.Data.EntityKeyMember[] EntityKeyValues { get { throw null; } set { } }
        [System.Runtime.Serialization.DataMemberAttribute]
        public string EntitySetName { get { throw null; } set { } }
        public bool IsTemporary { get { throw null; } }
        public bool Equals(System.Data.EntityKey other) { throw null; }
        public override bool Equals(object obj) { throw null; }
        public System.Data.Metadata.Edm.EntitySet GetEntitySet(System.Data.Metadata.Edm.MetadataWorkspace metadataWorkspace) { throw null; }
        public override int GetHashCode() { throw null; }
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Runtime.Serialization.OnDeserializedAttribute]
        public void OnDeserialized(System.Runtime.Serialization.StreamingContext context) { }
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Runtime.Serialization.OnDeserializingAttribute]
        public void OnDeserializing(System.Runtime.Serialization.StreamingContext context) { }
        public static bool operator ==(System.Data.EntityKey key1, System.Data.EntityKey key2) { throw null; }
        public static bool operator !=(System.Data.EntityKey key1, System.Data.EntityKey key2) { throw null; }
    }
    [System.Runtime.Serialization.DataContractAttribute]
    [System.SerializableAttribute]
    public partial class EntityKeyMember
    {
        public EntityKeyMember() { }
        public EntityKeyMember(string keyName, object keyValue) { }
        [System.Runtime.Serialization.DataMemberAttribute]
        public string Key { get { throw null; } set { } }
        [System.Runtime.Serialization.DataMemberAttribute]
        public object Value { get { throw null; } set { } }
        public override string ToString() { throw null; }
    }
    [System.SerializableAttribute]
    public sealed partial class EntitySqlException : System.Data.EntityException
    {
        public EntitySqlException() { }
        public EntitySqlException(string message) { }
        public EntitySqlException(string message, System.Exception innerException) { }
        public int Column { get { throw null; } }
        public string ErrorContext { get { throw null; } }
        public string ErrorDescription { get { throw null; } }
        public int Line { get { throw null; } }
        [System.Security.SecurityCriticalAttribute]
        [System.Security.Permissions.PermissionSetAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Unrestricted=true)]
        public override void GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
    }
    [System.ComponentModel.DataAnnotations.BindableTypeAttribute(IsBindable=false)]
    [System.FlagsAttribute]
    public enum EntityState
    {
        Added = 4,
        Deleted = 8,
        Detached = 1,
        Modified = 16,
        Unchanged = 2,
    }
    public partial interface IExtendedDataRecord : System.Data.IDataRecord
    {
        System.Data.Common.DataRecordInfo DataRecordInfo { get; }
        System.Data.Common.DbDataReader GetDataReader(int i);
        System.Data.Common.DbDataRecord GetDataRecord(int i);
    }
    [System.SerializableAttribute]
    public sealed partial class InvalidCommandTreeException : System.Data.DataException
    {
        public InvalidCommandTreeException() { }
        public InvalidCommandTreeException(string message) { }
        public InvalidCommandTreeException(string message, System.Exception innerException) { }
    }
    [System.SerializableAttribute]
    public sealed partial class MappingException : System.Data.EntityException
    {
        public MappingException() { }
        public MappingException(string message) { }
        public MappingException(string message, System.Exception innerException) { }
    }
    [System.SerializableAttribute]
    public sealed partial class MetadataException : System.Data.EntityException
    {
        public MetadataException() { }
        public MetadataException(string message) { }
        public MetadataException(string message, System.Exception innerException) { }
    }
    [System.SerializableAttribute]
    public sealed partial class ObjectNotFoundException : System.Data.DataException
    {
        public ObjectNotFoundException() { }
        public ObjectNotFoundException(string message) { }
        public ObjectNotFoundException(string message, System.Exception innerException) { }
    }
    [System.SerializableAttribute]
    public sealed partial class OptimisticConcurrencyException : System.Data.UpdateException
    {
        public OptimisticConcurrencyException() { }
        public OptimisticConcurrencyException(string message) { }
        public OptimisticConcurrencyException(string message, System.Exception innerException) { }
        public OptimisticConcurrencyException(string message, System.Exception innerException, System.Collections.Generic.IEnumerable<System.Data.Objects.ObjectStateEntry> stateEntries) { }
    }
    [System.SerializableAttribute]
    public sealed partial class PropertyConstraintException : System.Data.ConstraintException
    {
        public PropertyConstraintException() { }
        public PropertyConstraintException(string message) { }
        public PropertyConstraintException(string message, System.Exception innerException) { }
        public PropertyConstraintException(string message, string propertyName) { }
        public PropertyConstraintException(string message, string propertyName, System.Exception innerException) { }
        public string PropertyName { get { throw null; } }
        [System.Security.SecurityCriticalAttribute]
        [System.Security.Permissions.PermissionSetAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Unrestricted=true)]
        public override void GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
    }
    [System.SerializableAttribute]
    public sealed partial class ProviderIncompatibleException : System.Data.EntityException
    {
        public ProviderIncompatibleException() { }
        public ProviderIncompatibleException(string message) { }
        public ProviderIncompatibleException(string message, System.Exception innerException) { }
    }
    [System.SerializableAttribute]
    public partial class UpdateException : System.Data.DataException
    {
        public UpdateException() { }
        protected UpdateException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
        public UpdateException(string message) { }
        public UpdateException(string message, System.Exception innerException) { }
        public UpdateException(string message, System.Exception innerException, System.Collections.Generic.IEnumerable<System.Data.Objects.ObjectStateEntry> stateEntries) { }
        public System.Collections.ObjectModel.ReadOnlyCollection<System.Data.Objects.ObjectStateEntry> StateEntries { get { throw null; } }
    }
}
namespace System.Data.Common
{
    public partial class DataRecordInfo
    {
        public DataRecordInfo(System.Data.Metadata.Edm.TypeUsage metadata, System.Collections.Generic.IEnumerable<System.Data.Metadata.Edm.EdmMember> memberInfo) { }
        public System.Collections.ObjectModel.ReadOnlyCollection<System.Data.Common.FieldMetadata> FieldMetadata { get { throw null; } }
        public System.Data.Metadata.Edm.TypeUsage RecordType { get { throw null; } }
    }
    public partial class DbCommandDefinition
    {
        protected DbCommandDefinition() { }
        protected DbCommandDefinition(System.Data.Common.DbCommand prototype) { }
        public virtual System.Data.Common.DbCommand CreateCommand() { throw null; }
    }
    public abstract partial class DbProviderManifest
    {
        public static readonly string ConceptualSchemaDefinition;
        public static readonly string ConceptualSchemaDefinitionVersion3;
        public static readonly string StoreSchemaDefinition;
        public static readonly string StoreSchemaDefinitionVersion3;
        public static readonly string StoreSchemaMapping;
        public static readonly string StoreSchemaMappingVersion3;
        protected DbProviderManifest() { }
        public abstract string NamespaceName { get; }
        public virtual string EscapeLikeArgument(string argument) { throw null; }
        protected abstract System.Xml.XmlReader GetDbInformation(string informationType);
        public abstract System.Data.Metadata.Edm.TypeUsage GetEdmType(System.Data.Metadata.Edm.TypeUsage storeType);
        public abstract System.Collections.ObjectModel.ReadOnlyCollection<System.Data.Metadata.Edm.FacetDescription> GetFacetDescriptions(System.Data.Metadata.Edm.EdmType edmType);
        public System.Xml.XmlReader GetInformation(string informationType) { throw null; }
        public abstract System.Collections.ObjectModel.ReadOnlyCollection<System.Data.Metadata.Edm.EdmFunction> GetStoreFunctions();
        public abstract System.Data.Metadata.Edm.TypeUsage GetStoreType(System.Data.Metadata.Edm.TypeUsage edmType);
        public abstract System.Collections.ObjectModel.ReadOnlyCollection<System.Data.Metadata.Edm.PrimitiveType> GetStoreTypes();
        public virtual bool SupportsEscapingLikeArgument(out char escapeCharacter) { throw null; }
    }
    [System.CLSCompliantAttribute(false)]
    public abstract partial class DbProviderServices
    {
        protected DbProviderServices() { }
        public System.Data.Common.DbCommandDefinition CreateCommandDefinition(System.Data.Common.CommandTrees.DbCommandTree commandTree) { throw null; }
        public virtual System.Data.Common.DbCommandDefinition CreateCommandDefinition(System.Data.Common.DbCommand prototype) { throw null; }
        public System.Data.Common.DbCommandDefinition CreateCommandDefinition(System.Data.Common.DbProviderManifest providerManifest, System.Data.Common.CommandTrees.DbCommandTree commandTree) { throw null; }
        public void CreateDatabase(System.Data.Common.DbConnection connection, System.Nullable<int> commandTimeout, System.Data.Metadata.Edm.StoreItemCollection storeItemCollection) { }
        public string CreateDatabaseScript(string providerManifestToken, System.Data.Metadata.Edm.StoreItemCollection storeItemCollection) { throw null; }
        protected abstract System.Data.Common.DbCommandDefinition CreateDbCommandDefinition(System.Data.Common.DbProviderManifest providerManifest, System.Data.Common.CommandTrees.DbCommandTree commandTree);
        public bool DatabaseExists(System.Data.Common.DbConnection connection, System.Nullable<int> commandTimeout, System.Data.Metadata.Edm.StoreItemCollection storeItemCollection) { throw null; }
        protected virtual void DbCreateDatabase(System.Data.Common.DbConnection connection, System.Nullable<int> commandTimeout, System.Data.Metadata.Edm.StoreItemCollection storeItemCollection) { }
        protected virtual string DbCreateDatabaseScript(string providerManifestToken, System.Data.Metadata.Edm.StoreItemCollection storeItemCollection) { throw null; }
        protected virtual bool DbDatabaseExists(System.Data.Common.DbConnection connection, System.Nullable<int> commandTimeout, System.Data.Metadata.Edm.StoreItemCollection storeItemCollection) { throw null; }
        protected virtual void DbDeleteDatabase(System.Data.Common.DbConnection connection, System.Nullable<int> commandTimeout, System.Data.Metadata.Edm.StoreItemCollection storeItemCollection) { }
        protected virtual System.Data.Spatial.DbSpatialServices DbGetSpatialServices(string manifestToken) { throw null; }
        public void DeleteDatabase(System.Data.Common.DbConnection connection, System.Nullable<int> commandTimeout, System.Data.Metadata.Edm.StoreItemCollection storeItemCollection) { }
        protected abstract System.Data.Common.DbProviderManifest GetDbProviderManifest(string manifestToken);
        protected abstract string GetDbProviderManifestToken(System.Data.Common.DbConnection connection);
        protected virtual System.Data.Spatial.DbSpatialDataReader GetDbSpatialDataReader(System.Data.Common.DbDataReader fromReader, string manifestToken) { throw null; }
        public static System.Data.Common.DbProviderFactory GetProviderFactory(System.Data.Common.DbConnection connection) { throw null; }
        public System.Data.Common.DbProviderManifest GetProviderManifest(string manifestToken) { throw null; }
        public string GetProviderManifestToken(System.Data.Common.DbConnection connection) { throw null; }
        public static System.Data.Common.DbProviderServices GetProviderServices(System.Data.Common.DbConnection connection) { throw null; }
        public System.Data.Spatial.DbSpatialDataReader GetSpatialDataReader(System.Data.Common.DbDataReader fromReader, string manifestToken) { throw null; }
        public System.Data.Spatial.DbSpatialServices GetSpatialServices(string manifestToken) { throw null; }
        protected virtual void SetDbParameterValue(System.Data.Common.DbParameter parameter, System.Data.Metadata.Edm.TypeUsage parameterType, object value) { }
    }
    public abstract partial class DbXmlEnabledProviderManifest : System.Data.Common.DbProviderManifest
    {
        protected DbXmlEnabledProviderManifest(System.Xml.XmlReader reader) { }
        public override string NamespaceName { get { throw null; } }
        protected System.Collections.Generic.Dictionary<string, System.Data.Metadata.Edm.PrimitiveType> StoreTypeNameToEdmPrimitiveType { get { throw null; } }
        protected System.Collections.Generic.Dictionary<string, System.Data.Metadata.Edm.PrimitiveType> StoreTypeNameToStorePrimitiveType { get { throw null; } }
        public override System.Collections.ObjectModel.ReadOnlyCollection<System.Data.Metadata.Edm.FacetDescription> GetFacetDescriptions(System.Data.Metadata.Edm.EdmType type) { throw null; }
        public override System.Collections.ObjectModel.ReadOnlyCollection<System.Data.Metadata.Edm.EdmFunction> GetStoreFunctions() { throw null; }
        public override System.Collections.ObjectModel.ReadOnlyCollection<System.Data.Metadata.Edm.PrimitiveType> GetStoreTypes() { throw null; }
    }
    public partial class EntityRecordInfo : System.Data.Common.DataRecordInfo
    {
        public EntityRecordInfo(System.Data.Metadata.Edm.EntityType metadata, System.Collections.Generic.IEnumerable<System.Data.Metadata.Edm.EdmMember> memberInfo, System.Data.EntityKey entityKey, System.Data.Metadata.Edm.EntitySet entitySet) : base (default(System.Data.Metadata.Edm.TypeUsage), default(System.Collections.Generic.IEnumerable<System.Data.Metadata.Edm.EdmMember>)) { }
        public System.Data.EntityKey EntityKey { get { throw null; } }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public partial struct FieldMetadata
    {
        private object _dummy;
        private int _dummyPrimitive;
        public FieldMetadata(int ordinal, System.Data.Metadata.Edm.EdmMember fieldType) { throw null; }
        public System.Data.Metadata.Edm.EdmMember FieldType { get { throw null; } }
        public int Ordinal { get { throw null; } }
    }
}
namespace System.Data.Common.CommandTrees
{
    public abstract partial class DbAggregate
    {
        internal DbAggregate() { }
        public System.Collections.Generic.IList<System.Data.Common.CommandTrees.DbExpression> Arguments { get { throw null; } }
        public System.Data.Metadata.Edm.TypeUsage ResultType { get { throw null; } }
    }
    public sealed partial class DbAndExpression : System.Data.Common.CommandTrees.DbBinaryExpression
    {
        internal DbAndExpression() { }
        public override void Accept(System.Data.Common.CommandTrees.DbExpressionVisitor visitor) { }
        public override TResultType Accept<TResultType>(System.Data.Common.CommandTrees.DbExpressionVisitor<TResultType> visitor) { throw null; }
    }
    public sealed partial class DbApplyExpression : System.Data.Common.CommandTrees.DbExpression
    {
        internal DbApplyExpression() { }
        public System.Data.Common.CommandTrees.DbExpressionBinding Apply { get { throw null; } }
        public System.Data.Common.CommandTrees.DbExpressionBinding Input { get { throw null; } }
        public override void Accept(System.Data.Common.CommandTrees.DbExpressionVisitor visitor) { }
        public override TResultType Accept<TResultType>(System.Data.Common.CommandTrees.DbExpressionVisitor<TResultType> visitor) { throw null; }
    }
    public sealed partial class DbArithmeticExpression : System.Data.Common.CommandTrees.DbExpression
    {
        internal DbArithmeticExpression() { }
        public System.Collections.Generic.IList<System.Data.Common.CommandTrees.DbExpression> Arguments { get { throw null; } }
        public override void Accept(System.Data.Common.CommandTrees.DbExpressionVisitor visitor) { }
        public override TResultType Accept<TResultType>(System.Data.Common.CommandTrees.DbExpressionVisitor<TResultType> visitor) { throw null; }
    }
    public abstract partial class DbBinaryExpression : System.Data.Common.CommandTrees.DbExpression
    {
        internal DbBinaryExpression() { }
        public System.Data.Common.CommandTrees.DbExpression Left { get { throw null; } }
        public System.Data.Common.CommandTrees.DbExpression Right { get { throw null; } }
    }
    public sealed partial class DbCaseExpression : System.Data.Common.CommandTrees.DbExpression
    {
        internal DbCaseExpression() { }
        public System.Data.Common.CommandTrees.DbExpression Else { get { throw null; } }
        public System.Collections.Generic.IList<System.Data.Common.CommandTrees.DbExpression> Then { get { throw null; } }
        public System.Collections.Generic.IList<System.Data.Common.CommandTrees.DbExpression> When { get { throw null; } }
        public override void Accept(System.Data.Common.CommandTrees.DbExpressionVisitor visitor) { }
        public override TResultType Accept<TResultType>(System.Data.Common.CommandTrees.DbExpressionVisitor<TResultType> visitor) { throw null; }
    }
    public sealed partial class DbCastExpression : System.Data.Common.CommandTrees.DbUnaryExpression
    {
        internal DbCastExpression() { }
        public override void Accept(System.Data.Common.CommandTrees.DbExpressionVisitor visitor) { }
        public override TResultType Accept<TResultType>(System.Data.Common.CommandTrees.DbExpressionVisitor<TResultType> visitor) { throw null; }
    }
    public abstract partial class DbCommandTree
    {
        internal DbCommandTree() { }
        public System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<string, System.Data.Metadata.Edm.TypeUsage>> Parameters { get { throw null; } }
    }
    public sealed partial class DbComparisonExpression : System.Data.Common.CommandTrees.DbBinaryExpression
    {
        internal DbComparisonExpression() { }
        public override void Accept(System.Data.Common.CommandTrees.DbExpressionVisitor visitor) { }
        public override TResultType Accept<TResultType>(System.Data.Common.CommandTrees.DbExpressionVisitor<TResultType> visitor) { throw null; }
    }
    public sealed partial class DbConstantExpression : System.Data.Common.CommandTrees.DbExpression
    {
        internal DbConstantExpression() { }
        public object Value { get { throw null; } }
        public override void Accept(System.Data.Common.CommandTrees.DbExpressionVisitor visitor) { }
        public override TResultType Accept<TResultType>(System.Data.Common.CommandTrees.DbExpressionVisitor<TResultType> visitor) { throw null; }
    }
    public sealed partial class DbCrossJoinExpression : System.Data.Common.CommandTrees.DbExpression
    {
        internal DbCrossJoinExpression() { }
        public System.Collections.Generic.IList<System.Data.Common.CommandTrees.DbExpressionBinding> Inputs { get { throw null; } }
        public override void Accept(System.Data.Common.CommandTrees.DbExpressionVisitor visitor) { }
        public override TResultType Accept<TResultType>(System.Data.Common.CommandTrees.DbExpressionVisitor<TResultType> visitor) { throw null; }
    }
    public sealed partial class DbDeleteCommandTree : System.Data.Common.CommandTrees.DbModificationCommandTree
    {
        internal DbDeleteCommandTree() { }
        public System.Data.Common.CommandTrees.DbExpression Predicate { get { throw null; } }
    }
    public sealed partial class DbDerefExpression : System.Data.Common.CommandTrees.DbUnaryExpression
    {
        internal DbDerefExpression() { }
        public override void Accept(System.Data.Common.CommandTrees.DbExpressionVisitor visitor) { }
        public override TResultType Accept<TResultType>(System.Data.Common.CommandTrees.DbExpressionVisitor<TResultType> visitor) { throw null; }
    }
    public sealed partial class DbDistinctExpression : System.Data.Common.CommandTrees.DbUnaryExpression
    {
        internal DbDistinctExpression() { }
        public override void Accept(System.Data.Common.CommandTrees.DbExpressionVisitor visitor) { }
        public override TResultType Accept<TResultType>(System.Data.Common.CommandTrees.DbExpressionVisitor<TResultType> visitor) { throw null; }
    }
    public sealed partial class DbElementExpression : System.Data.Common.CommandTrees.DbUnaryExpression
    {
        internal DbElementExpression() { }
        public override void Accept(System.Data.Common.CommandTrees.DbExpressionVisitor visitor) { }
        public override TResultType Accept<TResultType>(System.Data.Common.CommandTrees.DbExpressionVisitor<TResultType> visitor) { throw null; }
    }
    public sealed partial class DbEntityRefExpression : System.Data.Common.CommandTrees.DbUnaryExpression
    {
        internal DbEntityRefExpression() { }
        public override void Accept(System.Data.Common.CommandTrees.DbExpressionVisitor visitor) { }
        public override TResultType Accept<TResultType>(System.Data.Common.CommandTrees.DbExpressionVisitor<TResultType> visitor) { throw null; }
    }
    public sealed partial class DbExceptExpression : System.Data.Common.CommandTrees.DbBinaryExpression
    {
        internal DbExceptExpression() { }
        public override void Accept(System.Data.Common.CommandTrees.DbExpressionVisitor visitor) { }
        public override TResultType Accept<TResultType>(System.Data.Common.CommandTrees.DbExpressionVisitor<TResultType> visitor) { throw null; }
    }
    public abstract partial class DbExpression
    {
        internal DbExpression() { }
        public System.Data.Common.CommandTrees.DbExpressionKind ExpressionKind { get { throw null; } }
        public System.Data.Metadata.Edm.TypeUsage ResultType { get { throw null; } }
        public abstract void Accept(System.Data.Common.CommandTrees.DbExpressionVisitor visitor);
        public abstract TResultType Accept<TResultType>(System.Data.Common.CommandTrees.DbExpressionVisitor<TResultType> visitor);
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        public static System.Data.Common.CommandTrees.DbExpression FromBinary(byte[] value) { throw null; }
        public static System.Data.Common.CommandTrees.DbExpression FromBoolean(System.Nullable<bool> value) { throw null; }
        public static System.Data.Common.CommandTrees.DbExpression FromByte(System.Nullable<byte> value) { throw null; }
        public static System.Data.Common.CommandTrees.DbExpression FromDateTime(System.Nullable<System.DateTime> value) { throw null; }
        public static System.Data.Common.CommandTrees.DbExpression FromDateTimeOffset(System.Nullable<System.DateTimeOffset> value) { throw null; }
        public static System.Data.Common.CommandTrees.DbExpression FromDecimal(System.Nullable<decimal> value) { throw null; }
        public static System.Data.Common.CommandTrees.DbExpression FromDouble(System.Nullable<double> value) { throw null; }
        public static System.Data.Common.CommandTrees.DbExpression FromGeography(System.Data.Spatial.DbGeography value) { throw null; }
        public static System.Data.Common.CommandTrees.DbExpression FromGeometry(System.Data.Spatial.DbGeometry value) { throw null; }
        public static System.Data.Common.CommandTrees.DbExpression FromGuid(System.Nullable<System.Guid> value) { throw null; }
        public static System.Data.Common.CommandTrees.DbExpression FromInt16(System.Nullable<short> value) { throw null; }
        public static System.Data.Common.CommandTrees.DbExpression FromInt32(System.Nullable<int> value) { throw null; }
        public static System.Data.Common.CommandTrees.DbExpression FromInt64(System.Nullable<long> value) { throw null; }
        public static System.Data.Common.CommandTrees.DbExpression FromSingle(System.Nullable<float> value) { throw null; }
        public static System.Data.Common.CommandTrees.DbExpression FromString(string value) { throw null; }
        public override int GetHashCode() { throw null; }
        public static implicit operator System.Data.Common.CommandTrees.DbExpression (byte[] value) { throw null; }
        public static implicit operator System.Data.Common.CommandTrees.DbExpression (System.Data.Spatial.DbGeography value) { throw null; }
        public static implicit operator System.Data.Common.CommandTrees.DbExpression (System.Data.Spatial.DbGeometry value) { throw null; }
        public static implicit operator System.Data.Common.CommandTrees.DbExpression (System.Nullable<bool> value) { throw null; }
        public static implicit operator System.Data.Common.CommandTrees.DbExpression (System.Nullable<byte> value) { throw null; }
        public static implicit operator System.Data.Common.CommandTrees.DbExpression (System.Nullable<System.DateTimeOffset> value) { throw null; }
        public static implicit operator System.Data.Common.CommandTrees.DbExpression (System.Nullable<System.DateTime> value) { throw null; }
        public static implicit operator System.Data.Common.CommandTrees.DbExpression (System.Nullable<decimal> value) { throw null; }
        public static implicit operator System.Data.Common.CommandTrees.DbExpression (System.Nullable<double> value) { throw null; }
        public static implicit operator System.Data.Common.CommandTrees.DbExpression (System.Nullable<System.Guid> value) { throw null; }
        public static implicit operator System.Data.Common.CommandTrees.DbExpression (System.Nullable<short> value) { throw null; }
        public static implicit operator System.Data.Common.CommandTrees.DbExpression (System.Nullable<int> value) { throw null; }
        public static implicit operator System.Data.Common.CommandTrees.DbExpression (System.Nullable<long> value) { throw null; }
        public static implicit operator System.Data.Common.CommandTrees.DbExpression (System.Nullable<float> value) { throw null; }
        public static implicit operator System.Data.Common.CommandTrees.DbExpression (string value) { throw null; }
    }
    public sealed partial class DbExpressionBinding
    {
        internal DbExpressionBinding() { }
        public System.Data.Common.CommandTrees.DbExpression Expression { get { throw null; } }
        public System.Data.Common.CommandTrees.DbVariableReferenceExpression Variable { get { throw null; } }
        public string VariableName { get { throw null; } }
        public System.Data.Metadata.Edm.TypeUsage VariableType { get { throw null; } }
    }
    public enum DbExpressionKind
    {
        All = 0,
        And = 1,
        Any = 2,
        Case = 3,
        Cast = 4,
        Constant = 5,
        CrossApply = 6,
        CrossJoin = 7,
        Deref = 8,
        Distinct = 9,
        Divide = 10,
        Element = 11,
        EntityRef = 12,
        Equals = 13,
        Except = 14,
        Filter = 15,
        FullOuterJoin = 16,
        Function = 17,
        GreaterThan = 18,
        GreaterThanOrEquals = 19,
        GroupBy = 20,
        InnerJoin = 21,
        Intersect = 22,
        IsEmpty = 23,
        IsNull = 24,
        IsOf = 25,
        IsOfOnly = 26,
        Lambda = 57,
        LeftOuterJoin = 27,
        LessThan = 28,
        LessThanOrEquals = 29,
        Like = 30,
        Limit = 31,
        Minus = 32,
        Modulo = 33,
        Multiply = 34,
        NewInstance = 35,
        Not = 36,
        NotEquals = 37,
        Null = 38,
        OfType = 39,
        OfTypeOnly = 40,
        Or = 41,
        OuterApply = 42,
        ParameterReference = 43,
        Plus = 44,
        Project = 45,
        Property = 46,
        Ref = 47,
        RefKey = 48,
        RelationshipNavigation = 49,
        Scan = 50,
        Skip = 51,
        Sort = 52,
        Treat = 53,
        UnaryMinus = 54,
        UnionAll = 55,
        VariableReference = 56,
    }
    public abstract partial class DbExpressionVisitor
    {
        protected DbExpressionVisitor() { }
        public abstract void Visit(System.Data.Common.CommandTrees.DbAndExpression expression);
        public abstract void Visit(System.Data.Common.CommandTrees.DbApplyExpression expression);
        public abstract void Visit(System.Data.Common.CommandTrees.DbArithmeticExpression expression);
        public abstract void Visit(System.Data.Common.CommandTrees.DbCaseExpression expression);
        public abstract void Visit(System.Data.Common.CommandTrees.DbCastExpression expression);
        public abstract void Visit(System.Data.Common.CommandTrees.DbComparisonExpression expression);
        public abstract void Visit(System.Data.Common.CommandTrees.DbConstantExpression expression);
        public abstract void Visit(System.Data.Common.CommandTrees.DbCrossJoinExpression expression);
        public abstract void Visit(System.Data.Common.CommandTrees.DbDerefExpression expression);
        public abstract void Visit(System.Data.Common.CommandTrees.DbDistinctExpression expression);
        public abstract void Visit(System.Data.Common.CommandTrees.DbElementExpression expression);
        public abstract void Visit(System.Data.Common.CommandTrees.DbEntityRefExpression expression);
        public abstract void Visit(System.Data.Common.CommandTrees.DbExceptExpression expression);
        public abstract void Visit(System.Data.Common.CommandTrees.DbExpression expression);
        public abstract void Visit(System.Data.Common.CommandTrees.DbFilterExpression expression);
        public abstract void Visit(System.Data.Common.CommandTrees.DbFunctionExpression expression);
        public abstract void Visit(System.Data.Common.CommandTrees.DbGroupByExpression expression);
        public abstract void Visit(System.Data.Common.CommandTrees.DbIntersectExpression expression);
        public abstract void Visit(System.Data.Common.CommandTrees.DbIsEmptyExpression expression);
        public abstract void Visit(System.Data.Common.CommandTrees.DbIsNullExpression expression);
        public abstract void Visit(System.Data.Common.CommandTrees.DbIsOfExpression expression);
        public abstract void Visit(System.Data.Common.CommandTrees.DbJoinExpression expression);
        public virtual void Visit(System.Data.Common.CommandTrees.DbLambdaExpression expression) { }
        public abstract void Visit(System.Data.Common.CommandTrees.DbLikeExpression expression);
        public abstract void Visit(System.Data.Common.CommandTrees.DbLimitExpression expression);
        public abstract void Visit(System.Data.Common.CommandTrees.DbNewInstanceExpression expression);
        public abstract void Visit(System.Data.Common.CommandTrees.DbNotExpression expression);
        public abstract void Visit(System.Data.Common.CommandTrees.DbNullExpression expression);
        public abstract void Visit(System.Data.Common.CommandTrees.DbOfTypeExpression expression);
        public abstract void Visit(System.Data.Common.CommandTrees.DbOrExpression expression);
        public abstract void Visit(System.Data.Common.CommandTrees.DbParameterReferenceExpression expression);
        public abstract void Visit(System.Data.Common.CommandTrees.DbProjectExpression expression);
        public abstract void Visit(System.Data.Common.CommandTrees.DbPropertyExpression expression);
        public abstract void Visit(System.Data.Common.CommandTrees.DbQuantifierExpression expression);
        public abstract void Visit(System.Data.Common.CommandTrees.DbRefExpression expression);
        public abstract void Visit(System.Data.Common.CommandTrees.DbRefKeyExpression expression);
        public abstract void Visit(System.Data.Common.CommandTrees.DbRelationshipNavigationExpression expression);
        public abstract void Visit(System.Data.Common.CommandTrees.DbScanExpression expression);
        public abstract void Visit(System.Data.Common.CommandTrees.DbSkipExpression expression);
        public abstract void Visit(System.Data.Common.CommandTrees.DbSortExpression expression);
        public abstract void Visit(System.Data.Common.CommandTrees.DbTreatExpression expression);
        public abstract void Visit(System.Data.Common.CommandTrees.DbUnionAllExpression expression);
        public abstract void Visit(System.Data.Common.CommandTrees.DbVariableReferenceExpression expression);
    }
    public abstract partial class DbExpressionVisitor<TResultType>
    {
        protected DbExpressionVisitor() { }
        public abstract TResultType Visit(System.Data.Common.CommandTrees.DbAndExpression expression);
        public abstract TResultType Visit(System.Data.Common.CommandTrees.DbApplyExpression expression);
        public abstract TResultType Visit(System.Data.Common.CommandTrees.DbArithmeticExpression expression);
        public abstract TResultType Visit(System.Data.Common.CommandTrees.DbCaseExpression expression);
        public abstract TResultType Visit(System.Data.Common.CommandTrees.DbCastExpression expression);
        public abstract TResultType Visit(System.Data.Common.CommandTrees.DbComparisonExpression expression);
        public abstract TResultType Visit(System.Data.Common.CommandTrees.DbConstantExpression expression);
        public abstract TResultType Visit(System.Data.Common.CommandTrees.DbCrossJoinExpression expression);
        public abstract TResultType Visit(System.Data.Common.CommandTrees.DbDerefExpression expression);
        public abstract TResultType Visit(System.Data.Common.CommandTrees.DbDistinctExpression expression);
        public abstract TResultType Visit(System.Data.Common.CommandTrees.DbElementExpression expression);
        public abstract TResultType Visit(System.Data.Common.CommandTrees.DbEntityRefExpression expression);
        public abstract TResultType Visit(System.Data.Common.CommandTrees.DbExceptExpression expression);
        public abstract TResultType Visit(System.Data.Common.CommandTrees.DbExpression expression);
        public abstract TResultType Visit(System.Data.Common.CommandTrees.DbFilterExpression expression);
        public abstract TResultType Visit(System.Data.Common.CommandTrees.DbFunctionExpression expression);
        public abstract TResultType Visit(System.Data.Common.CommandTrees.DbGroupByExpression expression);
        public abstract TResultType Visit(System.Data.Common.CommandTrees.DbIntersectExpression expression);
        public abstract TResultType Visit(System.Data.Common.CommandTrees.DbIsEmptyExpression expression);
        public abstract TResultType Visit(System.Data.Common.CommandTrees.DbIsNullExpression expression);
        public abstract TResultType Visit(System.Data.Common.CommandTrees.DbIsOfExpression expression);
        public abstract TResultType Visit(System.Data.Common.CommandTrees.DbJoinExpression expression);
        public virtual TResultType Visit(System.Data.Common.CommandTrees.DbLambdaExpression expression) { throw null; }
        public abstract TResultType Visit(System.Data.Common.CommandTrees.DbLikeExpression expression);
        public abstract TResultType Visit(System.Data.Common.CommandTrees.DbLimitExpression expression);
        public abstract TResultType Visit(System.Data.Common.CommandTrees.DbNewInstanceExpression expression);
        public abstract TResultType Visit(System.Data.Common.CommandTrees.DbNotExpression expression);
        public abstract TResultType Visit(System.Data.Common.CommandTrees.DbNullExpression expression);
        public abstract TResultType Visit(System.Data.Common.CommandTrees.DbOfTypeExpression expression);
        public abstract TResultType Visit(System.Data.Common.CommandTrees.DbOrExpression expression);
        public abstract TResultType Visit(System.Data.Common.CommandTrees.DbParameterReferenceExpression expression);
        public abstract TResultType Visit(System.Data.Common.CommandTrees.DbProjectExpression expression);
        public abstract TResultType Visit(System.Data.Common.CommandTrees.DbPropertyExpression expression);
        public abstract TResultType Visit(System.Data.Common.CommandTrees.DbQuantifierExpression expression);
        public abstract TResultType Visit(System.Data.Common.CommandTrees.DbRefExpression expression);
        public abstract TResultType Visit(System.Data.Common.CommandTrees.DbRefKeyExpression expression);
        public abstract TResultType Visit(System.Data.Common.CommandTrees.DbRelationshipNavigationExpression expression);
        public abstract TResultType Visit(System.Data.Common.CommandTrees.DbScanExpression expression);
        public abstract TResultType Visit(System.Data.Common.CommandTrees.DbSkipExpression expression);
        public abstract TResultType Visit(System.Data.Common.CommandTrees.DbSortExpression expression);
        public abstract TResultType Visit(System.Data.Common.CommandTrees.DbTreatExpression expression);
        public abstract TResultType Visit(System.Data.Common.CommandTrees.DbUnionAllExpression expression);
        public abstract TResultType Visit(System.Data.Common.CommandTrees.DbVariableReferenceExpression expression);
    }
    public sealed partial class DbFilterExpression : System.Data.Common.CommandTrees.DbExpression
    {
        internal DbFilterExpression() { }
        public System.Data.Common.CommandTrees.DbExpressionBinding Input { get { throw null; } }
        public System.Data.Common.CommandTrees.DbExpression Predicate { get { throw null; } }
        public override void Accept(System.Data.Common.CommandTrees.DbExpressionVisitor visitor) { }
        public override TResultType Accept<TResultType>(System.Data.Common.CommandTrees.DbExpressionVisitor<TResultType> visitor) { throw null; }
    }
    public sealed partial class DbFunctionAggregate : System.Data.Common.CommandTrees.DbAggregate
    {
        internal DbFunctionAggregate() { }
        public bool Distinct { get { throw null; } }
        public System.Data.Metadata.Edm.EdmFunction Function { get { throw null; } }
    }
    public sealed partial class DbFunctionCommandTree : System.Data.Common.CommandTrees.DbCommandTree
    {
        internal DbFunctionCommandTree() { }
        public System.Data.Metadata.Edm.EdmFunction EdmFunction { get { throw null; } }
        public System.Data.Metadata.Edm.TypeUsage ResultType { get { throw null; } }
    }
    public sealed partial class DbFunctionExpression : System.Data.Common.CommandTrees.DbExpression
    {
        internal DbFunctionExpression() { }
        public System.Collections.Generic.IList<System.Data.Common.CommandTrees.DbExpression> Arguments { get { throw null; } }
        public System.Data.Metadata.Edm.EdmFunction Function { get { throw null; } }
        public override void Accept(System.Data.Common.CommandTrees.DbExpressionVisitor visitor) { }
        public override TResultType Accept<TResultType>(System.Data.Common.CommandTrees.DbExpressionVisitor<TResultType> visitor) { throw null; }
    }
    public sealed partial class DbGroupAggregate : System.Data.Common.CommandTrees.DbAggregate
    {
        internal DbGroupAggregate() { }
    }
    public sealed partial class DbGroupByExpression : System.Data.Common.CommandTrees.DbExpression
    {
        internal DbGroupByExpression() { }
        public System.Collections.Generic.IList<System.Data.Common.CommandTrees.DbAggregate> Aggregates { get { throw null; } }
        public System.Data.Common.CommandTrees.DbGroupExpressionBinding Input { get { throw null; } }
        public System.Collections.Generic.IList<System.Data.Common.CommandTrees.DbExpression> Keys { get { throw null; } }
        public override void Accept(System.Data.Common.CommandTrees.DbExpressionVisitor visitor) { }
        public override TResultType Accept<TResultType>(System.Data.Common.CommandTrees.DbExpressionVisitor<TResultType> visitor) { throw null; }
    }
    public sealed partial class DbGroupExpressionBinding
    {
        internal DbGroupExpressionBinding() { }
        public System.Data.Common.CommandTrees.DbExpression Expression { get { throw null; } }
        public System.Data.Common.CommandTrees.DbGroupAggregate GroupAggregate { get { throw null; } }
        public System.Data.Common.CommandTrees.DbVariableReferenceExpression GroupVariable { get { throw null; } }
        public string GroupVariableName { get { throw null; } }
        public System.Data.Metadata.Edm.TypeUsage GroupVariableType { get { throw null; } }
        public System.Data.Common.CommandTrees.DbVariableReferenceExpression Variable { get { throw null; } }
        public string VariableName { get { throw null; } }
        public System.Data.Metadata.Edm.TypeUsage VariableType { get { throw null; } }
    }
    public sealed partial class DbInsertCommandTree : System.Data.Common.CommandTrees.DbModificationCommandTree
    {
        internal DbInsertCommandTree() { }
        public System.Data.Common.CommandTrees.DbExpression Returning { get { throw null; } }
        public System.Collections.Generic.IList<System.Data.Common.CommandTrees.DbModificationClause> SetClauses { get { throw null; } }
    }
    public sealed partial class DbIntersectExpression : System.Data.Common.CommandTrees.DbBinaryExpression
    {
        internal DbIntersectExpression() { }
        public override void Accept(System.Data.Common.CommandTrees.DbExpressionVisitor visitor) { }
        public override TResultType Accept<TResultType>(System.Data.Common.CommandTrees.DbExpressionVisitor<TResultType> visitor) { throw null; }
    }
    public sealed partial class DbIsEmptyExpression : System.Data.Common.CommandTrees.DbUnaryExpression
    {
        internal DbIsEmptyExpression() { }
        public override void Accept(System.Data.Common.CommandTrees.DbExpressionVisitor visitor) { }
        public override TResultType Accept<TResultType>(System.Data.Common.CommandTrees.DbExpressionVisitor<TResultType> visitor) { throw null; }
    }
    public sealed partial class DbIsNullExpression : System.Data.Common.CommandTrees.DbUnaryExpression
    {
        internal DbIsNullExpression() { }
        public override void Accept(System.Data.Common.CommandTrees.DbExpressionVisitor visitor) { }
        public override TResultType Accept<TResultType>(System.Data.Common.CommandTrees.DbExpressionVisitor<TResultType> visitor) { throw null; }
    }
    public sealed partial class DbIsOfExpression : System.Data.Common.CommandTrees.DbUnaryExpression
    {
        internal DbIsOfExpression() { }
        public System.Data.Metadata.Edm.TypeUsage OfType { get { throw null; } }
        public override void Accept(System.Data.Common.CommandTrees.DbExpressionVisitor visitor) { }
        public override TResultType Accept<TResultType>(System.Data.Common.CommandTrees.DbExpressionVisitor<TResultType> visitor) { throw null; }
    }
    public sealed partial class DbJoinExpression : System.Data.Common.CommandTrees.DbExpression
    {
        internal DbJoinExpression() { }
        public System.Data.Common.CommandTrees.DbExpression JoinCondition { get { throw null; } }
        public System.Data.Common.CommandTrees.DbExpressionBinding Left { get { throw null; } }
        public System.Data.Common.CommandTrees.DbExpressionBinding Right { get { throw null; } }
        public override void Accept(System.Data.Common.CommandTrees.DbExpressionVisitor visitor) { }
        public override TResultType Accept<TResultType>(System.Data.Common.CommandTrees.DbExpressionVisitor<TResultType> visitor) { throw null; }
    }
    public sealed partial class DbLambda
    {
        internal DbLambda() { }
        public System.Data.Common.CommandTrees.DbExpression Body { get { throw null; } }
        public System.Collections.Generic.IList<System.Data.Common.CommandTrees.DbVariableReferenceExpression> Variables { get { throw null; } }
        public static System.Data.Common.CommandTrees.DbLambda Create(System.Data.Common.CommandTrees.DbExpression body, System.Collections.Generic.IEnumerable<System.Data.Common.CommandTrees.DbVariableReferenceExpression> variables) { throw null; }
        public static System.Data.Common.CommandTrees.DbLambda Create(System.Data.Common.CommandTrees.DbExpression body, params System.Data.Common.CommandTrees.DbVariableReferenceExpression[] variables) { throw null; }
        public static System.Data.Common.CommandTrees.DbLambda Create(System.Data.Metadata.Edm.TypeUsage argument1Type, System.Data.Metadata.Edm.TypeUsage argument2Type, System.Data.Metadata.Edm.TypeUsage argument3Type, System.Data.Metadata.Edm.TypeUsage argument4Type, System.Data.Metadata.Edm.TypeUsage argument5Type, System.Data.Metadata.Edm.TypeUsage argument6Type, System.Data.Metadata.Edm.TypeUsage argument7Type, System.Data.Metadata.Edm.TypeUsage argument8Type, System.Data.Metadata.Edm.TypeUsage argument9Type, System.Data.Metadata.Edm.TypeUsage argument10Type, System.Data.Metadata.Edm.TypeUsage argument11Type, System.Data.Metadata.Edm.TypeUsage argument12Type, System.Data.Metadata.Edm.TypeUsage argument13Type, System.Data.Metadata.Edm.TypeUsage argument14Type, System.Data.Metadata.Edm.TypeUsage argument15Type, System.Data.Metadata.Edm.TypeUsage argument16Type, System.Func<System.Data.Common.CommandTrees.DbExpression, System.Data.Common.CommandTrees.DbExpression, System.Data.Common.CommandTrees.DbExpression, System.Data.Common.CommandTrees.DbExpression, System.Data.Common.CommandTrees.DbExpression, System.Data.Common.CommandTrees.DbExpression, System.Data.Common.CommandTrees.DbExpression, System.Data.Common.CommandTrees.DbExpression, System.Data.Common.CommandTrees.DbExpression, System.Data.Common.CommandTrees.DbExpression, System.Data.Common.CommandTrees.DbExpression, System.Data.Common.CommandTrees.DbExpression, System.Data.Common.CommandTrees.DbExpression, System.Data.Common.CommandTrees.DbExpression, System.Data.Common.CommandTrees.DbExpression, System.Data.Common.CommandTrees.DbExpression, System.Data.Common.CommandTrees.DbExpression> lambdaFunction) { throw null; }
        public static System.Data.Common.CommandTrees.DbLambda Create(System.Data.Metadata.Edm.TypeUsage argument1Type, System.Data.Metadata.Edm.TypeUsage argument2Type, System.Data.Metadata.Edm.TypeUsage argument3Type, System.Data.Metadata.Edm.TypeUsage argument4Type, System.Data.Metadata.Edm.TypeUsage argument5Type, System.Data.Metadata.Edm.TypeUsage argument6Type, System.Data.Metadata.Edm.TypeUsage argument7Type, System.Data.Metadata.Edm.TypeUsage argument8Type, System.Data.Metadata.Edm.TypeUsage argument9Type, System.Data.Metadata.Edm.TypeUsage argument10Type, System.Data.Metadata.Edm.TypeUsage argument11Type, System.Data.Metadata.Edm.TypeUsage argument12Type, System.Data.Metadata.Edm.TypeUsage argument13Type, System.Data.Metadata.Edm.TypeUsage argument14Type, System.Data.Metadata.Edm.TypeUsage argument15Type, System.Func<System.Data.Common.CommandTrees.DbExpression, System.Data.Common.CommandTrees.DbExpression, System.Data.Common.CommandTrees.DbExpression, System.Data.Common.CommandTrees.DbExpression, System.Data.Common.CommandTrees.DbExpression, System.Data.Common.CommandTrees.DbExpression, System.Data.Common.CommandTrees.DbExpression, System.Data.Common.CommandTrees.DbExpression, System.Data.Common.CommandTrees.DbExpression, System.Data.Common.CommandTrees.DbExpression, System.Data.Common.CommandTrees.DbExpression, System.Data.Common.CommandTrees.DbExpression, System.Data.Common.CommandTrees.DbExpression, System.Data.Common.CommandTrees.DbExpression, System.Data.Common.CommandTrees.DbExpression, System.Data.Common.CommandTrees.DbExpression> lambdaFunction) { throw null; }
        public static System.Data.Common.CommandTrees.DbLambda Create(System.Data.Metadata.Edm.TypeUsage argument1Type, System.Data.Metadata.Edm.TypeUsage argument2Type, System.Data.Metadata.Edm.TypeUsage argument3Type, System.Data.Metadata.Edm.TypeUsage argument4Type, System.Data.Metadata.Edm.TypeUsage argument5Type, System.Data.Metadata.Edm.TypeUsage argument6Type, System.Data.Metadata.Edm.TypeUsage argument7Type, System.Data.Metadata.Edm.TypeUsage argument8Type, System.Data.Metadata.Edm.TypeUsage argument9Type, System.Data.Metadata.Edm.TypeUsage argument10Type, System.Data.Metadata.Edm.TypeUsage argument11Type, System.Data.Metadata.Edm.TypeUsage argument12Type, System.Data.Metadata.Edm.TypeUsage argument13Type, System.Data.Metadata.Edm.TypeUsage argument14Type, System.Func<System.Data.Common.CommandTrees.DbExpression, System.Data.Common.CommandTrees.DbExpression, System.Data.Common.CommandTrees.DbExpression, System.Data.Common.CommandTrees.DbExpression, System.Data.Common.CommandTrees.DbExpression, System.Data.Common.CommandTrees.DbExpression, System.Data.Common.CommandTrees.DbExpression, System.Data.Common.CommandTrees.DbExpression, System.Data.Common.CommandTrees.DbExpression, System.Data.Common.CommandTrees.DbExpression, System.Data.Common.CommandTrees.DbExpression, System.Data.Common.CommandTrees.DbExpression, System.Data.Common.CommandTrees.DbExpression, System.Data.Common.CommandTrees.DbExpression, System.Data.Common.CommandTrees.DbExpression> lambdaFunction) { throw null; }
        public static System.Data.Common.CommandTrees.DbLambda Create(System.Data.Metadata.Edm.TypeUsage argument1Type, System.Data.Metadata.Edm.TypeUsage argument2Type, System.Data.Metadata.Edm.TypeUsage argument3Type, System.Data.Metadata.Edm.TypeUsage argument4Type, System.Data.Metadata.Edm.TypeUsage argument5Type, System.Data.Metadata.Edm.TypeUsage argument6Type, System.Data.Metadata.Edm.TypeUsage argument7Type, System.Data.Metadata.Edm.TypeUsage argument8Type, System.Data.Metadata.Edm.TypeUsage argument9Type, System.Data.Metadata.Edm.TypeUsage argument10Type, System.Data.Metadata.Edm.TypeUsage argument11Type, System.Data.Metadata.Edm.TypeUsage argument12Type, System.Data.Metadata.Edm.TypeUsage argument13Type, System.Func<System.Data.Common.CommandTrees.DbExpression, System.Data.Common.CommandTrees.DbExpression, System.Data.Common.CommandTrees.DbExpression, System.Data.Common.CommandTrees.DbExpression, System.Data.Common.CommandTrees.DbExpression, System.Data.Common.CommandTrees.DbExpression, System.Data.Common.CommandTrees.DbExpression, System.Data.Common.CommandTrees.DbExpression, System.Data.Common.CommandTrees.DbExpression, System.Data.Common.CommandTrees.DbExpression, System.Data.Common.CommandTrees.DbExpression, System.Data.Common.CommandTrees.DbExpression, System.Data.Common.CommandTrees.DbExpression, System.Data.Common.CommandTrees.DbExpression> lambdaFunction) { throw null; }
        public static System.Data.Common.CommandTrees.DbLambda Create(System.Data.Metadata.Edm.TypeUsage argument1Type, System.Data.Metadata.Edm.TypeUsage argument2Type, System.Data.Metadata.Edm.TypeUsage argument3Type, System.Data.Metadata.Edm.TypeUsage argument4Type, System.Data.Metadata.Edm.TypeUsage argument5Type, System.Data.Metadata.Edm.TypeUsage argument6Type, System.Data.Metadata.Edm.TypeUsage argument7Type, System.Data.Metadata.Edm.TypeUsage argument8Type, System.Data.Metadata.Edm.TypeUsage argument9Type, System.Data.Metadata.Edm.TypeUsage argument10Type, System.Data.Metadata.Edm.TypeUsage argument11Type, System.Data.Metadata.Edm.TypeUsage argument12Type, System.Func<System.Data.Common.CommandTrees.DbExpression, System.Data.Common.CommandTrees.DbExpression, System.Data.Common.CommandTrees.DbExpression, System.Data.Common.CommandTrees.DbExpression, System.Data.Common.CommandTrees.DbExpression, System.Data.Common.CommandTrees.DbExpression, System.Data.Common.CommandTrees.DbExpression, System.Data.Common.CommandTrees.DbExpression, System.Data.Common.CommandTrees.DbExpression, System.Data.Common.CommandTrees.DbExpression, System.Data.Common.CommandTrees.DbExpression, System.Data.Common.CommandTrees.DbExpression, System.Data.Common.CommandTrees.DbExpression> lambdaFunction) { throw null; }
        public static System.Data.Common.CommandTrees.DbLambda Create(System.Data.Metadata.Edm.TypeUsage argument1Type, System.Data.Metadata.Edm.TypeUsage argument2Type, System.Data.Metadata.Edm.TypeUsage argument3Type, System.Data.Metadata.Edm.TypeUsage argument4Type, System.Data.Metadata.Edm.TypeUsage argument5Type, System.Data.Metadata.Edm.TypeUsage argument6Type, System.Data.Metadata.Edm.TypeUsage argument7Type, System.Data.Metadata.Edm.TypeUsage argument8Type, System.Data.Metadata.Edm.TypeUsage argument9Type, System.Data.Metadata.Edm.TypeUsage argument10Type, System.Data.Metadata.Edm.TypeUsage argument11Type, System.Func<System.Data.Common.CommandTrees.DbExpression, System.Data.Common.CommandTrees.DbExpression, System.Data.Common.CommandTrees.DbExpression, System.Data.Common.CommandTrees.DbExpression, System.Data.Common.CommandTrees.DbExpression, System.Data.Common.CommandTrees.DbExpression, System.Data.Common.CommandTrees.DbExpression, System.Data.Common.CommandTrees.DbExpression, System.Data.Common.CommandTrees.DbExpression, System.Data.Common.CommandTrees.DbExpression, System.Data.Common.CommandTrees.DbExpression, System.Data.Common.CommandTrees.DbExpression> lambdaFunction) { throw null; }
        public static System.Data.Common.CommandTrees.DbLambda Create(System.Data.Metadata.Edm.TypeUsage argument1Type, System.Data.Metadata.Edm.TypeUsage argument2Type, System.Data.Metadata.Edm.TypeUsage argument3Type, System.Data.Metadata.Edm.TypeUsage argument4Type, System.Data.Metadata.Edm.TypeUsage argument5Type, System.Data.Metadata.Edm.TypeUsage argument6Type, System.Data.Metadata.Edm.TypeUsage argument7Type, System.Data.Metadata.Edm.TypeUsage argument8Type, System.Data.Metadata.Edm.TypeUsage argument9Type, System.Data.Metadata.Edm.TypeUsage argument10Type, System.Func<System.Data.Common.CommandTrees.DbExpression, System.Data.Common.CommandTrees.DbExpression, System.Data.Common.CommandTrees.DbExpression, System.Data.Common.CommandTrees.DbExpression, System.Data.Common.CommandTrees.DbExpression, System.Data.Common.CommandTrees.DbExpression, System.Data.Common.CommandTrees.DbExpression, System.Data.Common.CommandTrees.DbExpression, System.Data.Common.CommandTrees.DbExpression, System.Data.Common.CommandTrees.DbExpression, System.Data.Common.CommandTrees.DbExpression> lambdaFunction) { throw null; }
        public static System.Data.Common.CommandTrees.DbLambda Create(System.Data.Metadata.Edm.TypeUsage argument1Type, System.Data.Metadata.Edm.TypeUsage argument2Type, System.Data.Metadata.Edm.TypeUsage argument3Type, System.Data.Metadata.Edm.TypeUsage argument4Type, System.Data.Metadata.Edm.TypeUsage argument5Type, System.Data.Metadata.Edm.TypeUsage argument6Type, System.Data.Metadata.Edm.TypeUsage argument7Type, System.Data.Metadata.Edm.TypeUsage argument8Type, System.Data.Metadata.Edm.TypeUsage argument9Type, System.Func<System.Data.Common.CommandTrees.DbExpression, System.Data.Common.CommandTrees.DbExpression, System.Data.Common.CommandTrees.DbExpression, System.Data.Common.CommandTrees.DbExpression, System.Data.Common.CommandTrees.DbExpression, System.Data.Common.CommandTrees.DbExpression, System.Data.Common.CommandTrees.DbExpression, System.Data.Common.CommandTrees.DbExpression, System.Data.Common.CommandTrees.DbExpression, System.Data.Common.CommandTrees.DbExpression> lambdaFunction) { throw null; }
        public static System.Data.Common.CommandTrees.DbLambda Create(System.Data.Metadata.Edm.TypeUsage argument1Type, System.Data.Metadata.Edm.TypeUsage argument2Type, System.Data.Metadata.Edm.TypeUsage argument3Type, System.Data.Metadata.Edm.TypeUsage argument4Type, System.Data.Metadata.Edm.TypeUsage argument5Type, System.Data.Metadata.Edm.TypeUsage argument6Type, System.Data.Metadata.Edm.TypeUsage argument7Type, System.Data.Metadata.Edm.TypeUsage argument8Type, System.Func<System.Data.Common.CommandTrees.DbExpression, System.Data.Common.CommandTrees.DbExpression, System.Data.Common.CommandTrees.DbExpression, System.Data.Common.CommandTrees.DbExpression, System.Data.Common.CommandTrees.DbExpression, System.Data.Common.CommandTrees.DbExpression, System.Data.Common.CommandTrees.DbExpression, System.Data.Common.CommandTrees.DbExpression, System.Data.Common.CommandTrees.DbExpression> lambdaFunction) { throw null; }
        public static System.Data.Common.CommandTrees.DbLambda Create(System.Data.Metadata.Edm.TypeUsage argument1Type, System.Data.Metadata.Edm.TypeUsage argument2Type, System.Data.Metadata.Edm.TypeUsage argument3Type, System.Data.Metadata.Edm.TypeUsage argument4Type, System.Data.Metadata.Edm.TypeUsage argument5Type, System.Data.Metadata.Edm.TypeUsage argument6Type, System.Data.Metadata.Edm.TypeUsage argument7Type, System.Func<System.Data.Common.CommandTrees.DbExpression, System.Data.Common.CommandTrees.DbExpression, System.Data.Common.CommandTrees.DbExpression, System.Data.Common.CommandTrees.DbExpression, System.Data.Common.CommandTrees.DbExpression, System.Data.Common.CommandTrees.DbExpression, System.Data.Common.CommandTrees.DbExpression, System.Data.Common.CommandTrees.DbExpression> lambdaFunction) { throw null; }
        public static System.Data.Common.CommandTrees.DbLambda Create(System.Data.Metadata.Edm.TypeUsage argument1Type, System.Data.Metadata.Edm.TypeUsage argument2Type, System.Data.Metadata.Edm.TypeUsage argument3Type, System.Data.Metadata.Edm.TypeUsage argument4Type, System.Data.Metadata.Edm.TypeUsage argument5Type, System.Data.Metadata.Edm.TypeUsage argument6Type, System.Func<System.Data.Common.CommandTrees.DbExpression, System.Data.Common.CommandTrees.DbExpression, System.Data.Common.CommandTrees.DbExpression, System.Data.Common.CommandTrees.DbExpression, System.Data.Common.CommandTrees.DbExpression, System.Data.Common.CommandTrees.DbExpression, System.Data.Common.CommandTrees.DbExpression> lambdaFunction) { throw null; }
        public static System.Data.Common.CommandTrees.DbLambda Create(System.Data.Metadata.Edm.TypeUsage argument1Type, System.Data.Metadata.Edm.TypeUsage argument2Type, System.Data.Metadata.Edm.TypeUsage argument3Type, System.Data.Metadata.Edm.TypeUsage argument4Type, System.Data.Metadata.Edm.TypeUsage argument5Type, System.Func<System.Data.Common.CommandTrees.DbExpression, System.Data.Common.CommandTrees.DbExpression, System.Data.Common.CommandTrees.DbExpression, System.Data.Common.CommandTrees.DbExpression, System.Data.Common.CommandTrees.DbExpression, System.Data.Common.CommandTrees.DbExpression> lambdaFunction) { throw null; }
        public static System.Data.Common.CommandTrees.DbLambda Create(System.Data.Metadata.Edm.TypeUsage argument1Type, System.Data.Metadata.Edm.TypeUsage argument2Type, System.Data.Metadata.Edm.TypeUsage argument3Type, System.Data.Metadata.Edm.TypeUsage argument4Type, System.Func<System.Data.Common.CommandTrees.DbExpression, System.Data.Common.CommandTrees.DbExpression, System.Data.Common.CommandTrees.DbExpression, System.Data.Common.CommandTrees.DbExpression, System.Data.Common.CommandTrees.DbExpression> lambdaFunction) { throw null; }
        public static System.Data.Common.CommandTrees.DbLambda Create(System.Data.Metadata.Edm.TypeUsage argument1Type, System.Data.Metadata.Edm.TypeUsage argument2Type, System.Data.Metadata.Edm.TypeUsage argument3Type, System.Func<System.Data.Common.CommandTrees.DbExpression, System.Data.Common.CommandTrees.DbExpression, System.Data.Common.CommandTrees.DbExpression, System.Data.Common.CommandTrees.DbExpression> lambdaFunction) { throw null; }
        public static System.Data.Common.CommandTrees.DbLambda Create(System.Data.Metadata.Edm.TypeUsage argument1Type, System.Data.Metadata.Edm.TypeUsage argument2Type, System.Func<System.Data.Common.CommandTrees.DbExpression, System.Data.Common.CommandTrees.DbExpression, System.Data.Common.CommandTrees.DbExpression> lambdaFunction) { throw null; }
        public static System.Data.Common.CommandTrees.DbLambda Create(System.Data.Metadata.Edm.TypeUsage argument1Type, System.Func<System.Data.Common.CommandTrees.DbExpression, System.Data.Common.CommandTrees.DbExpression> lambdaFunction) { throw null; }
    }
    public sealed partial class DbLambdaExpression : System.Data.Common.CommandTrees.DbExpression
    {
        internal DbLambdaExpression() { }
        public System.Collections.Generic.IList<System.Data.Common.CommandTrees.DbExpression> Arguments { get { throw null; } }
        public System.Data.Common.CommandTrees.DbLambda Lambda { get { throw null; } }
        public override void Accept(System.Data.Common.CommandTrees.DbExpressionVisitor visitor) { }
        public override TResultType Accept<TResultType>(System.Data.Common.CommandTrees.DbExpressionVisitor<TResultType> visitor) { throw null; }
    }
    public sealed partial class DbLikeExpression : System.Data.Common.CommandTrees.DbExpression
    {
        internal DbLikeExpression() { }
        public System.Data.Common.CommandTrees.DbExpression Argument { get { throw null; } }
        public System.Data.Common.CommandTrees.DbExpression Escape { get { throw null; } }
        public System.Data.Common.CommandTrees.DbExpression Pattern { get { throw null; } }
        public override void Accept(System.Data.Common.CommandTrees.DbExpressionVisitor visitor) { }
        public override TResultType Accept<TResultType>(System.Data.Common.CommandTrees.DbExpressionVisitor<TResultType> visitor) { throw null; }
    }
    public sealed partial class DbLimitExpression : System.Data.Common.CommandTrees.DbExpression
    {
        internal DbLimitExpression() { }
        public System.Data.Common.CommandTrees.DbExpression Argument { get { throw null; } }
        public System.Data.Common.CommandTrees.DbExpression Limit { get { throw null; } }
        public bool WithTies { get { throw null; } }
        public override void Accept(System.Data.Common.CommandTrees.DbExpressionVisitor visitor) { }
        public override TResultType Accept<TResultType>(System.Data.Common.CommandTrees.DbExpressionVisitor<TResultType> visitor) { throw null; }
    }
    public abstract partial class DbModificationClause
    {
        internal DbModificationClause() { }
    }
    public abstract partial class DbModificationCommandTree : System.Data.Common.CommandTrees.DbCommandTree
    {
        internal DbModificationCommandTree() { }
        public System.Data.Common.CommandTrees.DbExpressionBinding Target { get { throw null; } }
    }
    public sealed partial class DbNewInstanceExpression : System.Data.Common.CommandTrees.DbExpression
    {
        internal DbNewInstanceExpression() { }
        public System.Collections.Generic.IList<System.Data.Common.CommandTrees.DbExpression> Arguments { get { throw null; } }
        public override void Accept(System.Data.Common.CommandTrees.DbExpressionVisitor visitor) { }
        public override TResultType Accept<TResultType>(System.Data.Common.CommandTrees.DbExpressionVisitor<TResultType> visitor) { throw null; }
    }
    public sealed partial class DbNotExpression : System.Data.Common.CommandTrees.DbUnaryExpression
    {
        internal DbNotExpression() { }
        public override void Accept(System.Data.Common.CommandTrees.DbExpressionVisitor visitor) { }
        public override TResultType Accept<TResultType>(System.Data.Common.CommandTrees.DbExpressionVisitor<TResultType> visitor) { throw null; }
    }
    public sealed partial class DbNullExpression : System.Data.Common.CommandTrees.DbExpression
    {
        internal DbNullExpression() { }
        public override void Accept(System.Data.Common.CommandTrees.DbExpressionVisitor visitor) { }
        public override TResultType Accept<TResultType>(System.Data.Common.CommandTrees.DbExpressionVisitor<TResultType> visitor) { throw null; }
    }
    public sealed partial class DbOfTypeExpression : System.Data.Common.CommandTrees.DbUnaryExpression
    {
        internal DbOfTypeExpression() { }
        public System.Data.Metadata.Edm.TypeUsage OfType { get { throw null; } }
        public override void Accept(System.Data.Common.CommandTrees.DbExpressionVisitor visitor) { }
        public override TResultType Accept<TResultType>(System.Data.Common.CommandTrees.DbExpressionVisitor<TResultType> visitor) { throw null; }
    }
    public sealed partial class DbOrExpression : System.Data.Common.CommandTrees.DbBinaryExpression
    {
        internal DbOrExpression() { }
        public override void Accept(System.Data.Common.CommandTrees.DbExpressionVisitor visitor) { }
        public override TResultType Accept<TResultType>(System.Data.Common.CommandTrees.DbExpressionVisitor<TResultType> visitor) { throw null; }
    }
    public sealed partial class DbParameterReferenceExpression : System.Data.Common.CommandTrees.DbExpression
    {
        internal DbParameterReferenceExpression() { }
        public string ParameterName { get { throw null; } }
        public override void Accept(System.Data.Common.CommandTrees.DbExpressionVisitor visitor) { }
        public override TResultType Accept<TResultType>(System.Data.Common.CommandTrees.DbExpressionVisitor<TResultType> visitor) { throw null; }
    }
    public sealed partial class DbProjectExpression : System.Data.Common.CommandTrees.DbExpression
    {
        internal DbProjectExpression() { }
        public System.Data.Common.CommandTrees.DbExpressionBinding Input { get { throw null; } }
        public System.Data.Common.CommandTrees.DbExpression Projection { get { throw null; } }
        public override void Accept(System.Data.Common.CommandTrees.DbExpressionVisitor visitor) { }
        public override TResultType Accept<TResultType>(System.Data.Common.CommandTrees.DbExpressionVisitor<TResultType> visitor) { throw null; }
    }
    public sealed partial class DbPropertyExpression : System.Data.Common.CommandTrees.DbExpression
    {
        internal DbPropertyExpression() { }
        public System.Data.Common.CommandTrees.DbExpression Instance { get { throw null; } }
        public System.Data.Metadata.Edm.EdmMember Property { get { throw null; } }
        public override void Accept(System.Data.Common.CommandTrees.DbExpressionVisitor visitor) { }
        public override TResultType Accept<TResultType>(System.Data.Common.CommandTrees.DbExpressionVisitor<TResultType> visitor) { throw null; }
        public static implicit operator System.Collections.Generic.KeyValuePair<string, System.Data.Common.CommandTrees.DbExpression> (System.Data.Common.CommandTrees.DbPropertyExpression value) { throw null; }
        public System.Collections.Generic.KeyValuePair<string, System.Data.Common.CommandTrees.DbExpression> ToKeyValuePair() { throw null; }
    }
    public sealed partial class DbQuantifierExpression : System.Data.Common.CommandTrees.DbExpression
    {
        internal DbQuantifierExpression() { }
        public System.Data.Common.CommandTrees.DbExpressionBinding Input { get { throw null; } }
        public System.Data.Common.CommandTrees.DbExpression Predicate { get { throw null; } }
        public override void Accept(System.Data.Common.CommandTrees.DbExpressionVisitor visitor) { }
        public override TResultType Accept<TResultType>(System.Data.Common.CommandTrees.DbExpressionVisitor<TResultType> visitor) { throw null; }
    }
    public sealed partial class DbQueryCommandTree : System.Data.Common.CommandTrees.DbCommandTree
    {
        internal DbQueryCommandTree() { }
        public System.Data.Common.CommandTrees.DbExpression Query { get { throw null; } }
    }
    public sealed partial class DbRefExpression : System.Data.Common.CommandTrees.DbUnaryExpression
    {
        internal DbRefExpression() { }
        public System.Data.Metadata.Edm.EntitySet EntitySet { get { throw null; } }
        public override void Accept(System.Data.Common.CommandTrees.DbExpressionVisitor visitor) { }
        public override TResultType Accept<TResultType>(System.Data.Common.CommandTrees.DbExpressionVisitor<TResultType> visitor) { throw null; }
    }
    public sealed partial class DbRefKeyExpression : System.Data.Common.CommandTrees.DbUnaryExpression
    {
        internal DbRefKeyExpression() { }
        public override void Accept(System.Data.Common.CommandTrees.DbExpressionVisitor visitor) { }
        public override TResultType Accept<TResultType>(System.Data.Common.CommandTrees.DbExpressionVisitor<TResultType> visitor) { throw null; }
    }
    public sealed partial class DbRelationshipNavigationExpression : System.Data.Common.CommandTrees.DbExpression
    {
        internal DbRelationshipNavigationExpression() { }
        public System.Data.Metadata.Edm.RelationshipEndMember NavigateFrom { get { throw null; } }
        public System.Data.Metadata.Edm.RelationshipEndMember NavigateTo { get { throw null; } }
        public System.Data.Common.CommandTrees.DbExpression NavigationSource { get { throw null; } }
        public System.Data.Metadata.Edm.RelationshipType Relationship { get { throw null; } }
        public override void Accept(System.Data.Common.CommandTrees.DbExpressionVisitor visitor) { }
        public override TResultType Accept<TResultType>(System.Data.Common.CommandTrees.DbExpressionVisitor<TResultType> visitor) { throw null; }
    }
    public sealed partial class DbScanExpression : System.Data.Common.CommandTrees.DbExpression
    {
        internal DbScanExpression() { }
        public System.Data.Metadata.Edm.EntitySetBase Target { get { throw null; } }
        public override void Accept(System.Data.Common.CommandTrees.DbExpressionVisitor visitor) { }
        public override TResultType Accept<TResultType>(System.Data.Common.CommandTrees.DbExpressionVisitor<TResultType> visitor) { throw null; }
    }
    public sealed partial class DbSetClause : System.Data.Common.CommandTrees.DbModificationClause
    {
        internal DbSetClause() { }
        public System.Data.Common.CommandTrees.DbExpression Property { get { throw null; } }
        public System.Data.Common.CommandTrees.DbExpression Value { get { throw null; } }
    }
    public sealed partial class DbSkipExpression : System.Data.Common.CommandTrees.DbExpression
    {
        internal DbSkipExpression() { }
        public System.Data.Common.CommandTrees.DbExpression Count { get { throw null; } }
        public System.Data.Common.CommandTrees.DbExpressionBinding Input { get { throw null; } }
        public System.Collections.Generic.IList<System.Data.Common.CommandTrees.DbSortClause> SortOrder { get { throw null; } }
        public override void Accept(System.Data.Common.CommandTrees.DbExpressionVisitor visitor) { }
        public override TResultType Accept<TResultType>(System.Data.Common.CommandTrees.DbExpressionVisitor<TResultType> visitor) { throw null; }
    }
    public sealed partial class DbSortClause
    {
        internal DbSortClause() { }
        public bool Ascending { get { throw null; } }
        public string Collation { get { throw null; } }
        public System.Data.Common.CommandTrees.DbExpression Expression { get { throw null; } }
    }
    public sealed partial class DbSortExpression : System.Data.Common.CommandTrees.DbExpression
    {
        internal DbSortExpression() { }
        public System.Data.Common.CommandTrees.DbExpressionBinding Input { get { throw null; } }
        public System.Collections.Generic.IList<System.Data.Common.CommandTrees.DbSortClause> SortOrder { get { throw null; } }
        public override void Accept(System.Data.Common.CommandTrees.DbExpressionVisitor visitor) { }
        public override TResultType Accept<TResultType>(System.Data.Common.CommandTrees.DbExpressionVisitor<TResultType> visitor) { throw null; }
    }
    public sealed partial class DbTreatExpression : System.Data.Common.CommandTrees.DbUnaryExpression
    {
        internal DbTreatExpression() { }
        public override void Accept(System.Data.Common.CommandTrees.DbExpressionVisitor visitor) { }
        public override TResultType Accept<TResultType>(System.Data.Common.CommandTrees.DbExpressionVisitor<TResultType> visitor) { throw null; }
    }
    public abstract partial class DbUnaryExpression : System.Data.Common.CommandTrees.DbExpression
    {
        internal DbUnaryExpression() { }
        public System.Data.Common.CommandTrees.DbExpression Argument { get { throw null; } }
    }
    public sealed partial class DbUnionAllExpression : System.Data.Common.CommandTrees.DbBinaryExpression
    {
        internal DbUnionAllExpression() { }
        public override void Accept(System.Data.Common.CommandTrees.DbExpressionVisitor visitor) { }
        public override TResultType Accept<TResultType>(System.Data.Common.CommandTrees.DbExpressionVisitor<TResultType> visitor) { throw null; }
    }
    public sealed partial class DbUpdateCommandTree : System.Data.Common.CommandTrees.DbModificationCommandTree
    {
        internal DbUpdateCommandTree() { }
        public System.Data.Common.CommandTrees.DbExpression Predicate { get { throw null; } }
        public System.Data.Common.CommandTrees.DbExpression Returning { get { throw null; } }
        public System.Collections.Generic.IList<System.Data.Common.CommandTrees.DbModificationClause> SetClauses { get { throw null; } }
    }
    public sealed partial class DbVariableReferenceExpression : System.Data.Common.CommandTrees.DbExpression
    {
        internal DbVariableReferenceExpression() { }
        public string VariableName { get { throw null; } }
        public override void Accept(System.Data.Common.CommandTrees.DbExpressionVisitor visitor) { }
        public override TResultType Accept<TResultType>(System.Data.Common.CommandTrees.DbExpressionVisitor<TResultType> visitor) { throw null; }
    }
    public partial class DefaultExpressionVisitor : System.Data.Common.CommandTrees.DbExpressionVisitor<System.Data.Common.CommandTrees.DbExpression>
    {
        protected DefaultExpressionVisitor() { }
        protected virtual void OnEnterScope(System.Collections.Generic.IEnumerable<System.Data.Common.CommandTrees.DbVariableReferenceExpression> scopeVariables) { }
        protected virtual void OnExitScope() { }
        protected virtual void OnExpressionReplaced(System.Data.Common.CommandTrees.DbExpression oldExpression, System.Data.Common.CommandTrees.DbExpression newExpression) { }
        protected virtual void OnVariableRebound(System.Data.Common.CommandTrees.DbVariableReferenceExpression fromVarRef, System.Data.Common.CommandTrees.DbVariableReferenceExpression toVarRef) { }
        public override System.Data.Common.CommandTrees.DbExpression Visit(System.Data.Common.CommandTrees.DbAndExpression expression) { throw null; }
        public override System.Data.Common.CommandTrees.DbExpression Visit(System.Data.Common.CommandTrees.DbApplyExpression expression) { throw null; }
        public override System.Data.Common.CommandTrees.DbExpression Visit(System.Data.Common.CommandTrees.DbArithmeticExpression expression) { throw null; }
        public override System.Data.Common.CommandTrees.DbExpression Visit(System.Data.Common.CommandTrees.DbCaseExpression expression) { throw null; }
        public override System.Data.Common.CommandTrees.DbExpression Visit(System.Data.Common.CommandTrees.DbCastExpression expression) { throw null; }
        public override System.Data.Common.CommandTrees.DbExpression Visit(System.Data.Common.CommandTrees.DbComparisonExpression expression) { throw null; }
        public override System.Data.Common.CommandTrees.DbExpression Visit(System.Data.Common.CommandTrees.DbConstantExpression expression) { throw null; }
        public override System.Data.Common.CommandTrees.DbExpression Visit(System.Data.Common.CommandTrees.DbCrossJoinExpression expression) { throw null; }
        public override System.Data.Common.CommandTrees.DbExpression Visit(System.Data.Common.CommandTrees.DbDerefExpression expression) { throw null; }
        public override System.Data.Common.CommandTrees.DbExpression Visit(System.Data.Common.CommandTrees.DbDistinctExpression expression) { throw null; }
        public override System.Data.Common.CommandTrees.DbExpression Visit(System.Data.Common.CommandTrees.DbElementExpression expression) { throw null; }
        public override System.Data.Common.CommandTrees.DbExpression Visit(System.Data.Common.CommandTrees.DbEntityRefExpression expression) { throw null; }
        public override System.Data.Common.CommandTrees.DbExpression Visit(System.Data.Common.CommandTrees.DbExceptExpression expression) { throw null; }
        public override System.Data.Common.CommandTrees.DbExpression Visit(System.Data.Common.CommandTrees.DbExpression expression) { throw null; }
        public override System.Data.Common.CommandTrees.DbExpression Visit(System.Data.Common.CommandTrees.DbFilterExpression expression) { throw null; }
        public override System.Data.Common.CommandTrees.DbExpression Visit(System.Data.Common.CommandTrees.DbFunctionExpression expression) { throw null; }
        public override System.Data.Common.CommandTrees.DbExpression Visit(System.Data.Common.CommandTrees.DbGroupByExpression expression) { throw null; }
        public override System.Data.Common.CommandTrees.DbExpression Visit(System.Data.Common.CommandTrees.DbIntersectExpression expression) { throw null; }
        public override System.Data.Common.CommandTrees.DbExpression Visit(System.Data.Common.CommandTrees.DbIsEmptyExpression expression) { throw null; }
        public override System.Data.Common.CommandTrees.DbExpression Visit(System.Data.Common.CommandTrees.DbIsNullExpression expression) { throw null; }
        public override System.Data.Common.CommandTrees.DbExpression Visit(System.Data.Common.CommandTrees.DbIsOfExpression expression) { throw null; }
        public override System.Data.Common.CommandTrees.DbExpression Visit(System.Data.Common.CommandTrees.DbJoinExpression expression) { throw null; }
        public override System.Data.Common.CommandTrees.DbExpression Visit(System.Data.Common.CommandTrees.DbLambdaExpression expression) { throw null; }
        public override System.Data.Common.CommandTrees.DbExpression Visit(System.Data.Common.CommandTrees.DbLikeExpression expression) { throw null; }
        public override System.Data.Common.CommandTrees.DbExpression Visit(System.Data.Common.CommandTrees.DbLimitExpression expression) { throw null; }
        public override System.Data.Common.CommandTrees.DbExpression Visit(System.Data.Common.CommandTrees.DbNewInstanceExpression expression) { throw null; }
        public override System.Data.Common.CommandTrees.DbExpression Visit(System.Data.Common.CommandTrees.DbNotExpression expression) { throw null; }
        public override System.Data.Common.CommandTrees.DbExpression Visit(System.Data.Common.CommandTrees.DbNullExpression expression) { throw null; }
        public override System.Data.Common.CommandTrees.DbExpression Visit(System.Data.Common.CommandTrees.DbOfTypeExpression expression) { throw null; }
        public override System.Data.Common.CommandTrees.DbExpression Visit(System.Data.Common.CommandTrees.DbOrExpression expression) { throw null; }
        public override System.Data.Common.CommandTrees.DbExpression Visit(System.Data.Common.CommandTrees.DbParameterReferenceExpression expression) { throw null; }
        public override System.Data.Common.CommandTrees.DbExpression Visit(System.Data.Common.CommandTrees.DbProjectExpression expression) { throw null; }
        public override System.Data.Common.CommandTrees.DbExpression Visit(System.Data.Common.CommandTrees.DbPropertyExpression expression) { throw null; }
        public override System.Data.Common.CommandTrees.DbExpression Visit(System.Data.Common.CommandTrees.DbQuantifierExpression expression) { throw null; }
        public override System.Data.Common.CommandTrees.DbExpression Visit(System.Data.Common.CommandTrees.DbRefExpression expression) { throw null; }
        public override System.Data.Common.CommandTrees.DbExpression Visit(System.Data.Common.CommandTrees.DbRefKeyExpression expression) { throw null; }
        public override System.Data.Common.CommandTrees.DbExpression Visit(System.Data.Common.CommandTrees.DbRelationshipNavigationExpression expression) { throw null; }
        public override System.Data.Common.CommandTrees.DbExpression Visit(System.Data.Common.CommandTrees.DbScanExpression expression) { throw null; }
        public override System.Data.Common.CommandTrees.DbExpression Visit(System.Data.Common.CommandTrees.DbSkipExpression expression) { throw null; }
        public override System.Data.Common.CommandTrees.DbExpression Visit(System.Data.Common.CommandTrees.DbSortExpression expression) { throw null; }
        public override System.Data.Common.CommandTrees.DbExpression Visit(System.Data.Common.CommandTrees.DbTreatExpression expression) { throw null; }
        public override System.Data.Common.CommandTrees.DbExpression Visit(System.Data.Common.CommandTrees.DbUnionAllExpression expression) { throw null; }
        public override System.Data.Common.CommandTrees.DbExpression Visit(System.Data.Common.CommandTrees.DbVariableReferenceExpression expression) { throw null; }
        protected virtual System.Data.Common.CommandTrees.DbAggregate VisitAggregate(System.Data.Common.CommandTrees.DbAggregate aggregate) { throw null; }
        protected virtual System.Data.Metadata.Edm.EntitySetBase VisitEntitySet(System.Data.Metadata.Edm.EntitySetBase entitySet) { throw null; }
        protected virtual System.Data.Common.CommandTrees.DbExpression VisitExpression(System.Data.Common.CommandTrees.DbExpression expression) { throw null; }
        protected virtual System.Data.Common.CommandTrees.DbExpressionBinding VisitExpressionBinding(System.Data.Common.CommandTrees.DbExpressionBinding binding) { throw null; }
        protected virtual System.Collections.Generic.IList<System.Data.Common.CommandTrees.DbExpressionBinding> VisitExpressionBindingList(System.Collections.Generic.IList<System.Data.Common.CommandTrees.DbExpressionBinding> list) { throw null; }
        protected virtual System.Collections.Generic.IList<System.Data.Common.CommandTrees.DbExpression> VisitExpressionList(System.Collections.Generic.IList<System.Data.Common.CommandTrees.DbExpression> list) { throw null; }
        protected virtual System.Data.Metadata.Edm.EdmFunction VisitFunction(System.Data.Metadata.Edm.EdmFunction functionMetadata) { throw null; }
        protected virtual System.Data.Common.CommandTrees.DbFunctionAggregate VisitFunctionAggregate(System.Data.Common.CommandTrees.DbFunctionAggregate aggregate) { throw null; }
        protected virtual System.Data.Common.CommandTrees.DbGroupAggregate VisitGroupAggregate(System.Data.Common.CommandTrees.DbGroupAggregate aggregate) { throw null; }
        protected virtual System.Data.Common.CommandTrees.DbGroupExpressionBinding VisitGroupExpressionBinding(System.Data.Common.CommandTrees.DbGroupExpressionBinding binding) { throw null; }
        protected virtual System.Data.Common.CommandTrees.DbLambda VisitLambda(System.Data.Common.CommandTrees.DbLambda lambda) { throw null; }
        protected virtual System.Data.Common.CommandTrees.DbSortClause VisitSortClause(System.Data.Common.CommandTrees.DbSortClause clause) { throw null; }
        protected virtual System.Collections.Generic.IList<System.Data.Common.CommandTrees.DbSortClause> VisitSortOrder(System.Collections.Generic.IList<System.Data.Common.CommandTrees.DbSortClause> sortOrder) { throw null; }
        protected virtual System.Data.Metadata.Edm.EdmType VisitType(System.Data.Metadata.Edm.EdmType type) { throw null; }
        protected virtual System.Data.Metadata.Edm.TypeUsage VisitTypeUsage(System.Data.Metadata.Edm.TypeUsage type) { throw null; }
    }
}
namespace System.Data.Common.CommandTrees.ExpressionBuilder
{
    public static partial class DbExpressionBuilder
    {
        public static System.Data.Common.CommandTrees.DbConstantExpression False { get { throw null; } }
        public static System.Data.Common.CommandTrees.DbConstantExpression True { get { throw null; } }
        public static System.Data.Common.CommandTrees.DbFunctionAggregate Aggregate(this System.Data.Metadata.Edm.EdmFunction function, System.Data.Common.CommandTrees.DbExpression argument) { throw null; }
        public static System.Data.Common.CommandTrees.DbFunctionAggregate AggregateDistinct(this System.Data.Metadata.Edm.EdmFunction function, System.Data.Common.CommandTrees.DbExpression argument) { throw null; }
        public static System.Data.Common.CommandTrees.DbQuantifierExpression All(this System.Data.Common.CommandTrees.DbExpression source, System.Func<System.Data.Common.CommandTrees.DbExpression, System.Data.Common.CommandTrees.DbExpression> predicate) { throw null; }
        public static System.Data.Common.CommandTrees.DbQuantifierExpression All(this System.Data.Common.CommandTrees.DbExpressionBinding input, System.Data.Common.CommandTrees.DbExpression predicate) { throw null; }
        public static System.Data.Common.CommandTrees.DbAndExpression And(this System.Data.Common.CommandTrees.DbExpression left, System.Data.Common.CommandTrees.DbExpression right) { throw null; }
        public static System.Data.Common.CommandTrees.DbExpression Any(this System.Data.Common.CommandTrees.DbExpression source) { throw null; }
        public static System.Data.Common.CommandTrees.DbQuantifierExpression Any(this System.Data.Common.CommandTrees.DbExpression source, System.Func<System.Data.Common.CommandTrees.DbExpression, System.Data.Common.CommandTrees.DbExpression> predicate) { throw null; }
        public static System.Data.Common.CommandTrees.DbQuantifierExpression Any(this System.Data.Common.CommandTrees.DbExpressionBinding input, System.Data.Common.CommandTrees.DbExpression predicate) { throw null; }
        public static System.Collections.Generic.KeyValuePair<string, System.Data.Common.CommandTrees.DbAggregate> As(this System.Data.Common.CommandTrees.DbAggregate value, string alias) { throw null; }
        public static System.Collections.Generic.KeyValuePair<string, System.Data.Common.CommandTrees.DbExpression> As(this System.Data.Common.CommandTrees.DbExpression value, string alias) { throw null; }
        public static System.Data.Common.CommandTrees.DbExpressionBinding Bind(this System.Data.Common.CommandTrees.DbExpression input) { throw null; }
        public static System.Data.Common.CommandTrees.DbExpressionBinding BindAs(this System.Data.Common.CommandTrees.DbExpression input, string varName) { throw null; }
        public static System.Data.Common.CommandTrees.DbCaseExpression Case(System.Collections.Generic.IEnumerable<System.Data.Common.CommandTrees.DbExpression> whenExpressions, System.Collections.Generic.IEnumerable<System.Data.Common.CommandTrees.DbExpression> thenExpressions, System.Data.Common.CommandTrees.DbExpression elseExpression) { throw null; }
        public static System.Data.Common.CommandTrees.DbCastExpression CastTo(this System.Data.Common.CommandTrees.DbExpression argument, System.Data.Metadata.Edm.TypeUsage toType) { throw null; }
        public static System.Data.Common.CommandTrees.DbConstantExpression Constant(this System.Data.Metadata.Edm.TypeUsage constantType, object value) { throw null; }
        public static System.Data.Common.CommandTrees.DbConstantExpression Constant(object value) { throw null; }
        public static System.Data.Common.CommandTrees.DbRefExpression CreateRef(this System.Data.Metadata.Edm.EntitySet entitySet, System.Collections.Generic.IEnumerable<System.Data.Common.CommandTrees.DbExpression> keyValues) { throw null; }
        public static System.Data.Common.CommandTrees.DbRefExpression CreateRef(this System.Data.Metadata.Edm.EntitySet entitySet, params System.Data.Common.CommandTrees.DbExpression[] keyValues) { throw null; }
        public static System.Data.Common.CommandTrees.DbRefExpression CreateRef(this System.Data.Metadata.Edm.EntitySet entitySet, System.Data.Metadata.Edm.EntityType entityType, System.Collections.Generic.IEnumerable<System.Data.Common.CommandTrees.DbExpression> keyValues) { throw null; }
        public static System.Data.Common.CommandTrees.DbRefExpression CreateRef(this System.Data.Metadata.Edm.EntitySet entitySet, System.Data.Metadata.Edm.EntityType entityType, params System.Data.Common.CommandTrees.DbExpression[] keyValues) { throw null; }
        public static System.Data.Common.CommandTrees.DbApplyExpression CrossApply(this System.Data.Common.CommandTrees.DbExpression source, System.Func<System.Data.Common.CommandTrees.DbExpression, System.Collections.Generic.KeyValuePair<string, System.Data.Common.CommandTrees.DbExpression>> apply) { throw null; }
        public static System.Data.Common.CommandTrees.DbApplyExpression CrossApply(this System.Data.Common.CommandTrees.DbExpressionBinding input, System.Data.Common.CommandTrees.DbExpressionBinding apply) { throw null; }
        public static System.Data.Common.CommandTrees.DbCrossJoinExpression CrossJoin(System.Collections.Generic.IEnumerable<System.Data.Common.CommandTrees.DbExpressionBinding> inputs) { throw null; }
        public static System.Data.Common.CommandTrees.DbDerefExpression Deref(this System.Data.Common.CommandTrees.DbExpression argument) { throw null; }
        public static System.Data.Common.CommandTrees.DbDistinctExpression Distinct(this System.Data.Common.CommandTrees.DbExpression argument) { throw null; }
        public static System.Data.Common.CommandTrees.DbArithmeticExpression Divide(this System.Data.Common.CommandTrees.DbExpression left, System.Data.Common.CommandTrees.DbExpression right) { throw null; }
        public static System.Data.Common.CommandTrees.DbElementExpression Element(this System.Data.Common.CommandTrees.DbExpression argument) { throw null; }
        public static System.Data.Common.CommandTrees.DbComparisonExpression Equal(this System.Data.Common.CommandTrees.DbExpression left, System.Data.Common.CommandTrees.DbExpression right) { throw null; }
        public static System.Data.Common.CommandTrees.DbExceptExpression Except(this System.Data.Common.CommandTrees.DbExpression left, System.Data.Common.CommandTrees.DbExpression right) { throw null; }
        public static System.Data.Common.CommandTrees.DbExpression Exists(this System.Data.Common.CommandTrees.DbExpression argument) { throw null; }
        public static System.Data.Common.CommandTrees.DbFilterExpression Filter(this System.Data.Common.CommandTrees.DbExpressionBinding input, System.Data.Common.CommandTrees.DbExpression predicate) { throw null; }
        public static System.Data.Common.CommandTrees.DbJoinExpression FullOuterJoin(this System.Data.Common.CommandTrees.DbExpression left, System.Data.Common.CommandTrees.DbExpression right, System.Func<System.Data.Common.CommandTrees.DbExpression, System.Data.Common.CommandTrees.DbExpression, System.Data.Common.CommandTrees.DbExpression> joinCondition) { throw null; }
        public static System.Data.Common.CommandTrees.DbJoinExpression FullOuterJoin(this System.Data.Common.CommandTrees.DbExpressionBinding left, System.Data.Common.CommandTrees.DbExpressionBinding right, System.Data.Common.CommandTrees.DbExpression joinCondition) { throw null; }
        public static System.Data.Common.CommandTrees.DbEntityRefExpression GetEntityRef(this System.Data.Common.CommandTrees.DbExpression argument) { throw null; }
        public static System.Data.Common.CommandTrees.DbRefKeyExpression GetRefKey(this System.Data.Common.CommandTrees.DbExpression argument) { throw null; }
        public static System.Data.Common.CommandTrees.DbComparisonExpression GreaterThan(this System.Data.Common.CommandTrees.DbExpression left, System.Data.Common.CommandTrees.DbExpression right) { throw null; }
        public static System.Data.Common.CommandTrees.DbComparisonExpression GreaterThanOrEqual(this System.Data.Common.CommandTrees.DbExpression left, System.Data.Common.CommandTrees.DbExpression right) { throw null; }
        public static System.Data.Common.CommandTrees.DbGroupExpressionBinding GroupBind(this System.Data.Common.CommandTrees.DbExpression input) { throw null; }
        public static System.Data.Common.CommandTrees.DbGroupExpressionBinding GroupBindAs(this System.Data.Common.CommandTrees.DbExpression input, string varName, string groupVarName) { throw null; }
        public static System.Data.Common.CommandTrees.DbGroupByExpression GroupBy(this System.Data.Common.CommandTrees.DbGroupExpressionBinding input, System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<string, System.Data.Common.CommandTrees.DbExpression>> keys, System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<string, System.Data.Common.CommandTrees.DbAggregate>> aggregates) { throw null; }
        public static System.Data.Common.CommandTrees.DbJoinExpression InnerJoin(this System.Data.Common.CommandTrees.DbExpression left, System.Data.Common.CommandTrees.DbExpression right, System.Func<System.Data.Common.CommandTrees.DbExpression, System.Data.Common.CommandTrees.DbExpression, System.Data.Common.CommandTrees.DbExpression> joinCondition) { throw null; }
        public static System.Data.Common.CommandTrees.DbJoinExpression InnerJoin(this System.Data.Common.CommandTrees.DbExpressionBinding left, System.Data.Common.CommandTrees.DbExpressionBinding right, System.Data.Common.CommandTrees.DbExpression joinCondition) { throw null; }
        public static System.Data.Common.CommandTrees.DbIntersectExpression Intersect(this System.Data.Common.CommandTrees.DbExpression left, System.Data.Common.CommandTrees.DbExpression right) { throw null; }
        public static System.Data.Common.CommandTrees.DbLambdaExpression Invoke(this System.Data.Common.CommandTrees.DbLambda lambda, System.Collections.Generic.IEnumerable<System.Data.Common.CommandTrees.DbExpression> arguments) { throw null; }
        public static System.Data.Common.CommandTrees.DbLambdaExpression Invoke(this System.Data.Common.CommandTrees.DbLambda lambda, params System.Data.Common.CommandTrees.DbExpression[] arguments) { throw null; }
        public static System.Data.Common.CommandTrees.DbFunctionExpression Invoke(this System.Data.Metadata.Edm.EdmFunction function, System.Collections.Generic.IEnumerable<System.Data.Common.CommandTrees.DbExpression> arguments) { throw null; }
        public static System.Data.Common.CommandTrees.DbFunctionExpression Invoke(this System.Data.Metadata.Edm.EdmFunction function, params System.Data.Common.CommandTrees.DbExpression[] arguments) { throw null; }
        public static System.Data.Common.CommandTrees.DbIsEmptyExpression IsEmpty(this System.Data.Common.CommandTrees.DbExpression argument) { throw null; }
        public static System.Data.Common.CommandTrees.DbIsNullExpression IsNull(this System.Data.Common.CommandTrees.DbExpression argument) { throw null; }
        public static System.Data.Common.CommandTrees.DbIsOfExpression IsOf(this System.Data.Common.CommandTrees.DbExpression argument, System.Data.Metadata.Edm.TypeUsage type) { throw null; }
        public static System.Data.Common.CommandTrees.DbIsOfExpression IsOfOnly(this System.Data.Common.CommandTrees.DbExpression argument, System.Data.Metadata.Edm.TypeUsage type) { throw null; }
        public static System.Data.Common.CommandTrees.DbJoinExpression Join(this System.Data.Common.CommandTrees.DbExpression outer, System.Data.Common.CommandTrees.DbExpression inner, System.Func<System.Data.Common.CommandTrees.DbExpression, System.Data.Common.CommandTrees.DbExpression> outerKey, System.Func<System.Data.Common.CommandTrees.DbExpression, System.Data.Common.CommandTrees.DbExpression> innerKey) { throw null; }
        public static System.Data.Common.CommandTrees.DbProjectExpression Join<TSelector>(this System.Data.Common.CommandTrees.DbExpression outer, System.Data.Common.CommandTrees.DbExpression inner, System.Func<System.Data.Common.CommandTrees.DbExpression, System.Data.Common.CommandTrees.DbExpression> outerKey, System.Func<System.Data.Common.CommandTrees.DbExpression, System.Data.Common.CommandTrees.DbExpression> innerKey, System.Func<System.Data.Common.CommandTrees.DbExpression, System.Data.Common.CommandTrees.DbExpression, TSelector> selector) { throw null; }
        public static System.Data.Common.CommandTrees.DbLambda Lambda(System.Data.Common.CommandTrees.DbExpression body, System.Collections.Generic.IEnumerable<System.Data.Common.CommandTrees.DbVariableReferenceExpression> variables) { throw null; }
        public static System.Data.Common.CommandTrees.DbLambda Lambda(System.Data.Common.CommandTrees.DbExpression body, params System.Data.Common.CommandTrees.DbVariableReferenceExpression[] variables) { throw null; }
        public static System.Data.Common.CommandTrees.DbJoinExpression LeftOuterJoin(this System.Data.Common.CommandTrees.DbExpression left, System.Data.Common.CommandTrees.DbExpression right, System.Func<System.Data.Common.CommandTrees.DbExpression, System.Data.Common.CommandTrees.DbExpression, System.Data.Common.CommandTrees.DbExpression> joinCondition) { throw null; }
        public static System.Data.Common.CommandTrees.DbJoinExpression LeftOuterJoin(this System.Data.Common.CommandTrees.DbExpressionBinding left, System.Data.Common.CommandTrees.DbExpressionBinding right, System.Data.Common.CommandTrees.DbExpression joinCondition) { throw null; }
        public static System.Data.Common.CommandTrees.DbComparisonExpression LessThan(this System.Data.Common.CommandTrees.DbExpression left, System.Data.Common.CommandTrees.DbExpression right) { throw null; }
        public static System.Data.Common.CommandTrees.DbComparisonExpression LessThanOrEqual(this System.Data.Common.CommandTrees.DbExpression left, System.Data.Common.CommandTrees.DbExpression right) { throw null; }
        public static System.Data.Common.CommandTrees.DbLikeExpression Like(this System.Data.Common.CommandTrees.DbExpression argument, System.Data.Common.CommandTrees.DbExpression pattern) { throw null; }
        public static System.Data.Common.CommandTrees.DbLikeExpression Like(this System.Data.Common.CommandTrees.DbExpression argument, System.Data.Common.CommandTrees.DbExpression pattern, System.Data.Common.CommandTrees.DbExpression escape) { throw null; }
        public static System.Data.Common.CommandTrees.DbLimitExpression Limit(this System.Data.Common.CommandTrees.DbExpression argument, System.Data.Common.CommandTrees.DbExpression count) { throw null; }
        public static System.Data.Common.CommandTrees.DbArithmeticExpression Minus(this System.Data.Common.CommandTrees.DbExpression left, System.Data.Common.CommandTrees.DbExpression right) { throw null; }
        public static System.Data.Common.CommandTrees.DbArithmeticExpression Modulo(this System.Data.Common.CommandTrees.DbExpression left, System.Data.Common.CommandTrees.DbExpression right) { throw null; }
        public static System.Data.Common.CommandTrees.DbArithmeticExpression Multiply(this System.Data.Common.CommandTrees.DbExpression left, System.Data.Common.CommandTrees.DbExpression right) { throw null; }
        public static System.Data.Common.CommandTrees.DbRelationshipNavigationExpression Navigate(this System.Data.Common.CommandTrees.DbExpression navigateFrom, System.Data.Metadata.Edm.RelationshipEndMember fromEnd, System.Data.Metadata.Edm.RelationshipEndMember toEnd) { throw null; }
        public static System.Data.Common.CommandTrees.DbRelationshipNavigationExpression Navigate(this System.Data.Metadata.Edm.RelationshipType type, string fromEndName, string toEndName, System.Data.Common.CommandTrees.DbExpression navigateFrom) { throw null; }
        public static System.Data.Common.CommandTrees.DbArithmeticExpression Negate(this System.Data.Common.CommandTrees.DbExpression argument) { throw null; }
        public static System.Data.Common.CommandTrees.DbNewInstanceExpression New(this System.Data.Metadata.Edm.TypeUsage instanceType, System.Collections.Generic.IEnumerable<System.Data.Common.CommandTrees.DbExpression> arguments) { throw null; }
        public static System.Data.Common.CommandTrees.DbNewInstanceExpression New(this System.Data.Metadata.Edm.TypeUsage instanceType, params System.Data.Common.CommandTrees.DbExpression[] arguments) { throw null; }
        public static System.Data.Common.CommandTrees.DbNewInstanceExpression NewCollection(System.Collections.Generic.IEnumerable<System.Data.Common.CommandTrees.DbExpression> elements) { throw null; }
        public static System.Data.Common.CommandTrees.DbNewInstanceExpression NewCollection(params System.Data.Common.CommandTrees.DbExpression[] elements) { throw null; }
        public static System.Data.Common.CommandTrees.DbNewInstanceExpression NewEmptyCollection(this System.Data.Metadata.Edm.TypeUsage collectionType) { throw null; }
        public static System.Data.Common.CommandTrees.DbNewInstanceExpression NewRow(System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<string, System.Data.Common.CommandTrees.DbExpression>> columnValues) { throw null; }
        public static System.Data.Common.CommandTrees.DbNotExpression Not(this System.Data.Common.CommandTrees.DbExpression argument) { throw null; }
        public static System.Data.Common.CommandTrees.DbComparisonExpression NotEqual(this System.Data.Common.CommandTrees.DbExpression left, System.Data.Common.CommandTrees.DbExpression right) { throw null; }
        public static System.Data.Common.CommandTrees.DbNullExpression Null(this System.Data.Metadata.Edm.TypeUsage nullType) { throw null; }
        public static System.Data.Common.CommandTrees.DbOfTypeExpression OfType(this System.Data.Common.CommandTrees.DbExpression argument, System.Data.Metadata.Edm.TypeUsage type) { throw null; }
        public static System.Data.Common.CommandTrees.DbOfTypeExpression OfTypeOnly(this System.Data.Common.CommandTrees.DbExpression argument, System.Data.Metadata.Edm.TypeUsage type) { throw null; }
        public static System.Data.Common.CommandTrees.DbOrExpression Or(this System.Data.Common.CommandTrees.DbExpression left, System.Data.Common.CommandTrees.DbExpression right) { throw null; }
        public static System.Data.Common.CommandTrees.DbSortExpression OrderBy(this System.Data.Common.CommandTrees.DbExpression source, System.Func<System.Data.Common.CommandTrees.DbExpression, System.Data.Common.CommandTrees.DbExpression> sortKey) { throw null; }
        public static System.Data.Common.CommandTrees.DbSortExpression OrderBy(this System.Data.Common.CommandTrees.DbExpression source, System.Func<System.Data.Common.CommandTrees.DbExpression, System.Data.Common.CommandTrees.DbExpression> sortKey, string collation) { throw null; }
        public static System.Data.Common.CommandTrees.DbSortExpression OrderByDescending(this System.Data.Common.CommandTrees.DbExpression source, System.Func<System.Data.Common.CommandTrees.DbExpression, System.Data.Common.CommandTrees.DbExpression> sortKey) { throw null; }
        public static System.Data.Common.CommandTrees.DbSortExpression OrderByDescending(this System.Data.Common.CommandTrees.DbExpression source, System.Func<System.Data.Common.CommandTrees.DbExpression, System.Data.Common.CommandTrees.DbExpression> sortKey, string collation) { throw null; }
        public static System.Data.Common.CommandTrees.DbApplyExpression OuterApply(this System.Data.Common.CommandTrees.DbExpression source, System.Func<System.Data.Common.CommandTrees.DbExpression, System.Collections.Generic.KeyValuePair<string, System.Data.Common.CommandTrees.DbExpression>> apply) { throw null; }
        public static System.Data.Common.CommandTrees.DbApplyExpression OuterApply(this System.Data.Common.CommandTrees.DbExpressionBinding input, System.Data.Common.CommandTrees.DbExpressionBinding apply) { throw null; }
        public static System.Data.Common.CommandTrees.DbParameterReferenceExpression Parameter(this System.Data.Metadata.Edm.TypeUsage type, string name) { throw null; }
        public static System.Data.Common.CommandTrees.DbArithmeticExpression Plus(this System.Data.Common.CommandTrees.DbExpression left, System.Data.Common.CommandTrees.DbExpression right) { throw null; }
        public static System.Data.Common.CommandTrees.DbProjectExpression Project(this System.Data.Common.CommandTrees.DbExpressionBinding input, System.Data.Common.CommandTrees.DbExpression projection) { throw null; }
        public static System.Data.Common.CommandTrees.DbPropertyExpression Property(this System.Data.Common.CommandTrees.DbExpression instance, System.Data.Metadata.Edm.EdmProperty propertyMetadata) { throw null; }
        public static System.Data.Common.CommandTrees.DbPropertyExpression Property(this System.Data.Common.CommandTrees.DbExpression instance, System.Data.Metadata.Edm.NavigationProperty navigationProperty) { throw null; }
        public static System.Data.Common.CommandTrees.DbPropertyExpression Property(this System.Data.Common.CommandTrees.DbExpression instance, System.Data.Metadata.Edm.RelationshipEndMember relationshipEnd) { throw null; }
        public static System.Data.Common.CommandTrees.DbPropertyExpression Property(this System.Data.Common.CommandTrees.DbExpression instance, string propertyName) { throw null; }
        public static System.Data.Common.CommandTrees.DbRefExpression RefFromKey(this System.Data.Metadata.Edm.EntitySet entitySet, System.Data.Common.CommandTrees.DbExpression keyRow) { throw null; }
        public static System.Data.Common.CommandTrees.DbRefExpression RefFromKey(this System.Data.Metadata.Edm.EntitySet entitySet, System.Data.Common.CommandTrees.DbExpression keyRow, System.Data.Metadata.Edm.EntityType entityType) { throw null; }
        public static System.Data.Common.CommandTrees.DbScanExpression Scan(this System.Data.Metadata.Edm.EntitySetBase targetSet) { throw null; }
        public static System.Data.Common.CommandTrees.DbProjectExpression SelectMany(this System.Data.Common.CommandTrees.DbExpression source, System.Func<System.Data.Common.CommandTrees.DbExpression, System.Data.Common.CommandTrees.DbExpression> apply) { throw null; }
        public static System.Data.Common.CommandTrees.DbProjectExpression SelectMany<TSelector>(this System.Data.Common.CommandTrees.DbExpression source, System.Func<System.Data.Common.CommandTrees.DbExpression, System.Data.Common.CommandTrees.DbExpression> apply, System.Func<System.Data.Common.CommandTrees.DbExpression, System.Data.Common.CommandTrees.DbExpression, TSelector> selector) { throw null; }
        public static System.Data.Common.CommandTrees.DbProjectExpression Select<TProjection>(this System.Data.Common.CommandTrees.DbExpression source, System.Func<System.Data.Common.CommandTrees.DbExpression, TProjection> projection) { throw null; }
        public static System.Data.Common.CommandTrees.DbSkipExpression Skip(this System.Data.Common.CommandTrees.DbExpressionBinding input, System.Collections.Generic.IEnumerable<System.Data.Common.CommandTrees.DbSortClause> sortOrder, System.Data.Common.CommandTrees.DbExpression count) { throw null; }
        public static System.Data.Common.CommandTrees.DbSkipExpression Skip(this System.Data.Common.CommandTrees.DbSortExpression argument, System.Data.Common.CommandTrees.DbExpression count) { throw null; }
        public static System.Data.Common.CommandTrees.DbSortExpression Sort(this System.Data.Common.CommandTrees.DbExpressionBinding input, System.Collections.Generic.IEnumerable<System.Data.Common.CommandTrees.DbSortClause> sortOrder) { throw null; }
        public static System.Data.Common.CommandTrees.DbLimitExpression Take(this System.Data.Common.CommandTrees.DbExpression argument, System.Data.Common.CommandTrees.DbExpression count) { throw null; }
        public static System.Data.Common.CommandTrees.DbSortExpression ThenBy(this System.Data.Common.CommandTrees.DbSortExpression source, System.Func<System.Data.Common.CommandTrees.DbExpression, System.Data.Common.CommandTrees.DbExpression> sortKey) { throw null; }
        public static System.Data.Common.CommandTrees.DbSortExpression ThenBy(this System.Data.Common.CommandTrees.DbSortExpression source, System.Func<System.Data.Common.CommandTrees.DbExpression, System.Data.Common.CommandTrees.DbExpression> sortKey, string collation) { throw null; }
        public static System.Data.Common.CommandTrees.DbSortExpression ThenByDescending(this System.Data.Common.CommandTrees.DbSortExpression source, System.Func<System.Data.Common.CommandTrees.DbExpression, System.Data.Common.CommandTrees.DbExpression> sortKey) { throw null; }
        public static System.Data.Common.CommandTrees.DbSortExpression ThenByDescending(this System.Data.Common.CommandTrees.DbSortExpression source, System.Func<System.Data.Common.CommandTrees.DbExpression, System.Data.Common.CommandTrees.DbExpression> sortKey, string collation) { throw null; }
        public static System.Data.Common.CommandTrees.DbSortClause ToSortClause(this System.Data.Common.CommandTrees.DbExpression key) { throw null; }
        public static System.Data.Common.CommandTrees.DbSortClause ToSortClause(this System.Data.Common.CommandTrees.DbExpression key, string collation) { throw null; }
        public static System.Data.Common.CommandTrees.DbSortClause ToSortClauseDescending(this System.Data.Common.CommandTrees.DbExpression key) { throw null; }
        public static System.Data.Common.CommandTrees.DbSortClause ToSortClauseDescending(this System.Data.Common.CommandTrees.DbExpression key, string collation) { throw null; }
        public static System.Data.Common.CommandTrees.DbTreatExpression TreatAs(this System.Data.Common.CommandTrees.DbExpression argument, System.Data.Metadata.Edm.TypeUsage treatType) { throw null; }
        public static System.Data.Common.CommandTrees.DbArithmeticExpression UnaryMinus(this System.Data.Common.CommandTrees.DbExpression argument) { throw null; }
        public static System.Data.Common.CommandTrees.DbExpression Union(this System.Data.Common.CommandTrees.DbExpression left, System.Data.Common.CommandTrees.DbExpression right) { throw null; }
        public static System.Data.Common.CommandTrees.DbUnionAllExpression UnionAll(this System.Data.Common.CommandTrees.DbExpression left, System.Data.Common.CommandTrees.DbExpression right) { throw null; }
        public static System.Data.Common.CommandTrees.DbVariableReferenceExpression Variable(this System.Data.Metadata.Edm.TypeUsage type, string name) { throw null; }
        public static System.Data.Common.CommandTrees.DbFilterExpression Where(this System.Data.Common.CommandTrees.DbExpression source, System.Func<System.Data.Common.CommandTrees.DbExpression, System.Data.Common.CommandTrees.DbExpression> predicate) { throw null; }
    }
    public static partial class EdmFunctions
    {
        public static System.Data.Common.CommandTrees.DbFunctionExpression Abs(this System.Data.Common.CommandTrees.DbExpression value) { throw null; }
        public static System.Data.Common.CommandTrees.DbFunctionExpression AddDays(this System.Data.Common.CommandTrees.DbExpression dateValue, System.Data.Common.CommandTrees.DbExpression addValue) { throw null; }
        public static System.Data.Common.CommandTrees.DbFunctionExpression AddHours(this System.Data.Common.CommandTrees.DbExpression timeValue, System.Data.Common.CommandTrees.DbExpression addValue) { throw null; }
        public static System.Data.Common.CommandTrees.DbFunctionExpression AddMicroseconds(this System.Data.Common.CommandTrees.DbExpression timeValue, System.Data.Common.CommandTrees.DbExpression addValue) { throw null; }
        public static System.Data.Common.CommandTrees.DbFunctionExpression AddMilliseconds(this System.Data.Common.CommandTrees.DbExpression timeValue, System.Data.Common.CommandTrees.DbExpression addValue) { throw null; }
        public static System.Data.Common.CommandTrees.DbFunctionExpression AddMinutes(this System.Data.Common.CommandTrees.DbExpression timeValue, System.Data.Common.CommandTrees.DbExpression addValue) { throw null; }
        public static System.Data.Common.CommandTrees.DbFunctionExpression AddMonths(this System.Data.Common.CommandTrees.DbExpression dateValue, System.Data.Common.CommandTrees.DbExpression addValue) { throw null; }
        public static System.Data.Common.CommandTrees.DbFunctionExpression AddNanoseconds(this System.Data.Common.CommandTrees.DbExpression timeValue, System.Data.Common.CommandTrees.DbExpression addValue) { throw null; }
        public static System.Data.Common.CommandTrees.DbFunctionExpression AddSeconds(this System.Data.Common.CommandTrees.DbExpression timeValue, System.Data.Common.CommandTrees.DbExpression addValue) { throw null; }
        public static System.Data.Common.CommandTrees.DbFunctionExpression AddYears(this System.Data.Common.CommandTrees.DbExpression dateValue, System.Data.Common.CommandTrees.DbExpression addValue) { throw null; }
        public static System.Data.Common.CommandTrees.DbFunctionExpression Average(this System.Data.Common.CommandTrees.DbExpression collection) { throw null; }
        public static System.Data.Common.CommandTrees.DbFunctionExpression BitwiseAnd(this System.Data.Common.CommandTrees.DbExpression value1, System.Data.Common.CommandTrees.DbExpression value2) { throw null; }
        public static System.Data.Common.CommandTrees.DbFunctionExpression BitwiseNot(this System.Data.Common.CommandTrees.DbExpression value) { throw null; }
        public static System.Data.Common.CommandTrees.DbFunctionExpression BitwiseOr(this System.Data.Common.CommandTrees.DbExpression value1, System.Data.Common.CommandTrees.DbExpression value2) { throw null; }
        public static System.Data.Common.CommandTrees.DbFunctionExpression BitwiseXor(this System.Data.Common.CommandTrees.DbExpression value1, System.Data.Common.CommandTrees.DbExpression value2) { throw null; }
        public static System.Data.Common.CommandTrees.DbFunctionExpression Ceiling(this System.Data.Common.CommandTrees.DbExpression value) { throw null; }
        public static System.Data.Common.CommandTrees.DbFunctionExpression Concat(this System.Data.Common.CommandTrees.DbExpression string1, System.Data.Common.CommandTrees.DbExpression string2) { throw null; }
        public static System.Data.Common.CommandTrees.DbExpression Contains(this System.Data.Common.CommandTrees.DbExpression searchedString, System.Data.Common.CommandTrees.DbExpression searchedForString) { throw null; }
        public static System.Data.Common.CommandTrees.DbFunctionExpression Count(this System.Data.Common.CommandTrees.DbExpression collection) { throw null; }
        public static System.Data.Common.CommandTrees.DbFunctionExpression CreateDateTime(System.Data.Common.CommandTrees.DbExpression year, System.Data.Common.CommandTrees.DbExpression month, System.Data.Common.CommandTrees.DbExpression day, System.Data.Common.CommandTrees.DbExpression hour, System.Data.Common.CommandTrees.DbExpression minute, System.Data.Common.CommandTrees.DbExpression second) { throw null; }
        public static System.Data.Common.CommandTrees.DbFunctionExpression CreateDateTimeOffset(System.Data.Common.CommandTrees.DbExpression year, System.Data.Common.CommandTrees.DbExpression month, System.Data.Common.CommandTrees.DbExpression day, System.Data.Common.CommandTrees.DbExpression hour, System.Data.Common.CommandTrees.DbExpression minute, System.Data.Common.CommandTrees.DbExpression second, System.Data.Common.CommandTrees.DbExpression timeZoneOffset) { throw null; }
        public static System.Data.Common.CommandTrees.DbFunctionExpression CreateTime(System.Data.Common.CommandTrees.DbExpression hour, System.Data.Common.CommandTrees.DbExpression minute, System.Data.Common.CommandTrees.DbExpression second) { throw null; }
        public static System.Data.Common.CommandTrees.DbFunctionExpression CurrentDateTime() { throw null; }
        public static System.Data.Common.CommandTrees.DbFunctionExpression CurrentDateTimeOffset() { throw null; }
        public static System.Data.Common.CommandTrees.DbFunctionExpression CurrentUtcDateTime() { throw null; }
        public static System.Data.Common.CommandTrees.DbFunctionExpression Day(this System.Data.Common.CommandTrees.DbExpression dateValue) { throw null; }
        public static System.Data.Common.CommandTrees.DbFunctionExpression DayOfYear(this System.Data.Common.CommandTrees.DbExpression dateValue) { throw null; }
        public static System.Data.Common.CommandTrees.DbFunctionExpression DiffDays(this System.Data.Common.CommandTrees.DbExpression dateValue1, System.Data.Common.CommandTrees.DbExpression dateValue2) { throw null; }
        public static System.Data.Common.CommandTrees.DbFunctionExpression DiffHours(this System.Data.Common.CommandTrees.DbExpression timeValue1, System.Data.Common.CommandTrees.DbExpression timeValue2) { throw null; }
        public static System.Data.Common.CommandTrees.DbFunctionExpression DiffMicroseconds(this System.Data.Common.CommandTrees.DbExpression timeValue1, System.Data.Common.CommandTrees.DbExpression timeValue2) { throw null; }
        public static System.Data.Common.CommandTrees.DbFunctionExpression DiffMilliseconds(this System.Data.Common.CommandTrees.DbExpression timeValue1, System.Data.Common.CommandTrees.DbExpression timeValue2) { throw null; }
        public static System.Data.Common.CommandTrees.DbFunctionExpression DiffMinutes(this System.Data.Common.CommandTrees.DbExpression timeValue1, System.Data.Common.CommandTrees.DbExpression timeValue2) { throw null; }
        public static System.Data.Common.CommandTrees.DbFunctionExpression DiffMonths(this System.Data.Common.CommandTrees.DbExpression dateValue1, System.Data.Common.CommandTrees.DbExpression dateValue2) { throw null; }
        public static System.Data.Common.CommandTrees.DbFunctionExpression DiffNanoseconds(this System.Data.Common.CommandTrees.DbExpression timeValue1, System.Data.Common.CommandTrees.DbExpression timeValue2) { throw null; }
        public static System.Data.Common.CommandTrees.DbFunctionExpression DiffSeconds(this System.Data.Common.CommandTrees.DbExpression timeValue1, System.Data.Common.CommandTrees.DbExpression timeValue2) { throw null; }
        public static System.Data.Common.CommandTrees.DbFunctionExpression DiffYears(this System.Data.Common.CommandTrees.DbExpression dateValue1, System.Data.Common.CommandTrees.DbExpression dateValue2) { throw null; }
        public static System.Data.Common.CommandTrees.DbFunctionExpression EndsWith(this System.Data.Common.CommandTrees.DbExpression stringArgument, System.Data.Common.CommandTrees.DbExpression suffix) { throw null; }
        public static System.Data.Common.CommandTrees.DbFunctionExpression Floor(this System.Data.Common.CommandTrees.DbExpression value) { throw null; }
        public static System.Data.Common.CommandTrees.DbFunctionExpression GetTotalOffsetMinutes(this System.Data.Common.CommandTrees.DbExpression dateTimeOffsetArgument) { throw null; }
        public static System.Data.Common.CommandTrees.DbFunctionExpression Hour(this System.Data.Common.CommandTrees.DbExpression timeValue) { throw null; }
        public static System.Data.Common.CommandTrees.DbFunctionExpression IndexOf(this System.Data.Common.CommandTrees.DbExpression searchString, System.Data.Common.CommandTrees.DbExpression stringToFind) { throw null; }
        public static System.Data.Common.CommandTrees.DbFunctionExpression Left(this System.Data.Common.CommandTrees.DbExpression stringArgument, System.Data.Common.CommandTrees.DbExpression length) { throw null; }
        public static System.Data.Common.CommandTrees.DbFunctionExpression Length(this System.Data.Common.CommandTrees.DbExpression stringArgument) { throw null; }
        public static System.Data.Common.CommandTrees.DbFunctionExpression LongCount(this System.Data.Common.CommandTrees.DbExpression collection) { throw null; }
        public static System.Data.Common.CommandTrees.DbFunctionExpression Max(this System.Data.Common.CommandTrees.DbExpression collection) { throw null; }
        public static System.Data.Common.CommandTrees.DbFunctionExpression Millisecond(this System.Data.Common.CommandTrees.DbExpression timeValue) { throw null; }
        public static System.Data.Common.CommandTrees.DbFunctionExpression Min(this System.Data.Common.CommandTrees.DbExpression collection) { throw null; }
        public static System.Data.Common.CommandTrees.DbFunctionExpression Minute(this System.Data.Common.CommandTrees.DbExpression timeValue) { throw null; }
        public static System.Data.Common.CommandTrees.DbFunctionExpression Month(this System.Data.Common.CommandTrees.DbExpression dateValue) { throw null; }
        public static System.Data.Common.CommandTrees.DbFunctionExpression NewGuid() { throw null; }
        public static System.Data.Common.CommandTrees.DbFunctionExpression Power(this System.Data.Common.CommandTrees.DbExpression baseArgument, System.Data.Common.CommandTrees.DbExpression exponent) { throw null; }
        public static System.Data.Common.CommandTrees.DbFunctionExpression Replace(this System.Data.Common.CommandTrees.DbExpression stringArgument, System.Data.Common.CommandTrees.DbExpression toReplace, System.Data.Common.CommandTrees.DbExpression replacement) { throw null; }
        public static System.Data.Common.CommandTrees.DbFunctionExpression Reverse(this System.Data.Common.CommandTrees.DbExpression stringArgument) { throw null; }
        public static System.Data.Common.CommandTrees.DbFunctionExpression Right(this System.Data.Common.CommandTrees.DbExpression stringArgument, System.Data.Common.CommandTrees.DbExpression length) { throw null; }
        public static System.Data.Common.CommandTrees.DbFunctionExpression Round(this System.Data.Common.CommandTrees.DbExpression value) { throw null; }
        public static System.Data.Common.CommandTrees.DbFunctionExpression Round(this System.Data.Common.CommandTrees.DbExpression value, System.Data.Common.CommandTrees.DbExpression digits) { throw null; }
        public static System.Data.Common.CommandTrees.DbFunctionExpression Second(this System.Data.Common.CommandTrees.DbExpression timeValue) { throw null; }
        public static System.Data.Common.CommandTrees.DbFunctionExpression StartsWith(this System.Data.Common.CommandTrees.DbExpression stringArgument, System.Data.Common.CommandTrees.DbExpression prefix) { throw null; }
        public static System.Data.Common.CommandTrees.DbFunctionExpression StDev(this System.Data.Common.CommandTrees.DbExpression collection) { throw null; }
        public static System.Data.Common.CommandTrees.DbFunctionExpression StDevP(this System.Data.Common.CommandTrees.DbExpression collection) { throw null; }
        public static System.Data.Common.CommandTrees.DbFunctionExpression Substring(this System.Data.Common.CommandTrees.DbExpression stringArgument, System.Data.Common.CommandTrees.DbExpression start, System.Data.Common.CommandTrees.DbExpression length) { throw null; }
        public static System.Data.Common.CommandTrees.DbFunctionExpression Sum(this System.Data.Common.CommandTrees.DbExpression collection) { throw null; }
        public static System.Data.Common.CommandTrees.DbFunctionExpression ToLower(this System.Data.Common.CommandTrees.DbExpression stringArgument) { throw null; }
        public static System.Data.Common.CommandTrees.DbFunctionExpression ToUpper(this System.Data.Common.CommandTrees.DbExpression stringArgument) { throw null; }
        public static System.Data.Common.CommandTrees.DbFunctionExpression Trim(this System.Data.Common.CommandTrees.DbExpression stringArgument) { throw null; }
        public static System.Data.Common.CommandTrees.DbFunctionExpression TrimEnd(this System.Data.Common.CommandTrees.DbExpression stringArgument) { throw null; }
        public static System.Data.Common.CommandTrees.DbFunctionExpression TrimStart(this System.Data.Common.CommandTrees.DbExpression stringArgument) { throw null; }
        public static System.Data.Common.CommandTrees.DbFunctionExpression Truncate(this System.Data.Common.CommandTrees.DbExpression value, System.Data.Common.CommandTrees.DbExpression digits) { throw null; }
        public static System.Data.Common.CommandTrees.DbFunctionExpression TruncateTime(this System.Data.Common.CommandTrees.DbExpression dateValue) { throw null; }
        public static System.Data.Common.CommandTrees.DbFunctionExpression Var(this System.Data.Common.CommandTrees.DbExpression collection) { throw null; }
        public static System.Data.Common.CommandTrees.DbFunctionExpression VarP(this System.Data.Common.CommandTrees.DbExpression collection) { throw null; }
        public static System.Data.Common.CommandTrees.DbFunctionExpression Year(this System.Data.Common.CommandTrees.DbExpression dateValue) { throw null; }
    }
    public sealed partial class Row
    {
        public Row(System.Collections.Generic.KeyValuePair<string, System.Data.Common.CommandTrees.DbExpression> columnValue, params System.Collections.Generic.KeyValuePair<string, System.Data.Common.CommandTrees.DbExpression>[] columnValues) { }
        public static implicit operator System.Data.Common.CommandTrees.DbExpression (System.Data.Common.CommandTrees.ExpressionBuilder.Row row) { throw null; }
        public System.Data.Common.CommandTrees.DbNewInstanceExpression ToExpression() { throw null; }
    }
}
namespace System.Data.Common.CommandTrees.ExpressionBuilder.Spatial
{
    public static partial class SpatialEdmFunctions
    {
        public static System.Data.Common.CommandTrees.DbFunctionExpression Area(this System.Data.Common.CommandTrees.DbExpression spatialValue) { throw null; }
        public static System.Data.Common.CommandTrees.DbFunctionExpression AsBinary(this System.Data.Common.CommandTrees.DbExpression spatialValue) { throw null; }
        public static System.Data.Common.CommandTrees.DbFunctionExpression AsGml(this System.Data.Common.CommandTrees.DbExpression spatialValue) { throw null; }
        public static System.Data.Common.CommandTrees.DbFunctionExpression AsText(this System.Data.Common.CommandTrees.DbExpression spatialValue) { throw null; }
        public static System.Data.Common.CommandTrees.DbFunctionExpression Centroid(this System.Data.Common.CommandTrees.DbExpression geometryValue) { throw null; }
        public static System.Data.Common.CommandTrees.DbFunctionExpression CoordinateSystemId(this System.Data.Common.CommandTrees.DbExpression spatialValue) { throw null; }
        public static System.Data.Common.CommandTrees.DbFunctionExpression Distance(this System.Data.Common.CommandTrees.DbExpression spatialValue1, System.Data.Common.CommandTrees.DbExpression spatialValue2) { throw null; }
        public static System.Data.Common.CommandTrees.DbFunctionExpression Elevation(this System.Data.Common.CommandTrees.DbExpression spatialValue) { throw null; }
        public static System.Data.Common.CommandTrees.DbFunctionExpression EndPoint(this System.Data.Common.CommandTrees.DbExpression spatialValue) { throw null; }
        public static System.Data.Common.CommandTrees.DbFunctionExpression ExteriorRing(this System.Data.Common.CommandTrees.DbExpression geometryValue) { throw null; }
        public static System.Data.Common.CommandTrees.DbFunctionExpression GeographyCollectionFromBinary(System.Data.Common.CommandTrees.DbExpression geographyCollectionWellKnownBinaryValue, System.Data.Common.CommandTrees.DbExpression coordinateSystemId) { throw null; }
        public static System.Data.Common.CommandTrees.DbFunctionExpression GeographyCollectionFromText(System.Data.Common.CommandTrees.DbExpression geographyCollectionWellKnownText, System.Data.Common.CommandTrees.DbExpression coordinateSystemId) { throw null; }
        public static System.Data.Common.CommandTrees.DbFunctionExpression GeographyFromBinary(System.Data.Common.CommandTrees.DbExpression wellKnownBinaryValue) { throw null; }
        public static System.Data.Common.CommandTrees.DbFunctionExpression GeographyFromBinary(System.Data.Common.CommandTrees.DbExpression wellKnownBinaryValue, System.Data.Common.CommandTrees.DbExpression coordinateSystemId) { throw null; }
        public static System.Data.Common.CommandTrees.DbFunctionExpression GeographyFromGml(System.Data.Common.CommandTrees.DbExpression geographyMarkup) { throw null; }
        public static System.Data.Common.CommandTrees.DbFunctionExpression GeographyFromGml(System.Data.Common.CommandTrees.DbExpression geographyMarkup, System.Data.Common.CommandTrees.DbExpression coordinateSystemId) { throw null; }
        public static System.Data.Common.CommandTrees.DbFunctionExpression GeographyFromText(System.Data.Common.CommandTrees.DbExpression wellKnownText) { throw null; }
        public static System.Data.Common.CommandTrees.DbFunctionExpression GeographyFromText(System.Data.Common.CommandTrees.DbExpression wellKnownText, System.Data.Common.CommandTrees.DbExpression coordinateSystemId) { throw null; }
        public static System.Data.Common.CommandTrees.DbFunctionExpression GeographyLineFromBinary(System.Data.Common.CommandTrees.DbExpression lineWellKnownBinaryValue, System.Data.Common.CommandTrees.DbExpression coordinateSystemId) { throw null; }
        public static System.Data.Common.CommandTrees.DbFunctionExpression GeographyLineFromText(System.Data.Common.CommandTrees.DbExpression lineWellKnownText, System.Data.Common.CommandTrees.DbExpression coordinateSystemId) { throw null; }
        public static System.Data.Common.CommandTrees.DbFunctionExpression GeographyMultiLineFromBinary(System.Data.Common.CommandTrees.DbExpression multiLineWellKnownBinaryValue, System.Data.Common.CommandTrees.DbExpression coordinateSystemId) { throw null; }
        public static System.Data.Common.CommandTrees.DbFunctionExpression GeographyMultiLineFromText(System.Data.Common.CommandTrees.DbExpression multiLineWellKnownText, System.Data.Common.CommandTrees.DbExpression coordinateSystemId) { throw null; }
        public static System.Data.Common.CommandTrees.DbFunctionExpression GeographyMultiPointFromBinary(System.Data.Common.CommandTrees.DbExpression multiPointWellKnownBinaryValue, System.Data.Common.CommandTrees.DbExpression coordinateSystemId) { throw null; }
        public static System.Data.Common.CommandTrees.DbFunctionExpression GeographyMultiPointFromText(System.Data.Common.CommandTrees.DbExpression multiPointWellKnownText, System.Data.Common.CommandTrees.DbExpression coordinateSystemId) { throw null; }
        public static System.Data.Common.CommandTrees.DbFunctionExpression GeographyMultiPolygonFromBinary(System.Data.Common.CommandTrees.DbExpression multiPolygonWellKnownBinaryValue, System.Data.Common.CommandTrees.DbExpression coordinateSystemId) { throw null; }
        public static System.Data.Common.CommandTrees.DbFunctionExpression GeographyMultiPolygonFromText(System.Data.Common.CommandTrees.DbExpression multiPolygonWellKnownText, System.Data.Common.CommandTrees.DbExpression coordinateSystemId) { throw null; }
        public static System.Data.Common.CommandTrees.DbFunctionExpression GeographyPointFromBinary(System.Data.Common.CommandTrees.DbExpression pointWellKnownBinaryValue, System.Data.Common.CommandTrees.DbExpression coordinateSystemId) { throw null; }
        public static System.Data.Common.CommandTrees.DbFunctionExpression GeographyPointFromText(System.Data.Common.CommandTrees.DbExpression pointWellKnownText, System.Data.Common.CommandTrees.DbExpression coordinateSystemId) { throw null; }
        public static System.Data.Common.CommandTrees.DbFunctionExpression GeographyPolygonFromBinary(System.Data.Common.CommandTrees.DbExpression polygonWellKnownBinaryValue, System.Data.Common.CommandTrees.DbExpression coordinateSystemId) { throw null; }
        public static System.Data.Common.CommandTrees.DbFunctionExpression GeographyPolygonFromText(System.Data.Common.CommandTrees.DbExpression polygonWellKnownText, System.Data.Common.CommandTrees.DbExpression coordinateSystemId) { throw null; }
        public static System.Data.Common.CommandTrees.DbFunctionExpression GeometryCollectionFromBinary(System.Data.Common.CommandTrees.DbExpression geometryCollectionWellKnownBinaryValue, System.Data.Common.CommandTrees.DbExpression coordinateSystemId) { throw null; }
        public static System.Data.Common.CommandTrees.DbFunctionExpression GeometryCollectionFromText(System.Data.Common.CommandTrees.DbExpression geometryCollectionWellKnownText, System.Data.Common.CommandTrees.DbExpression coordinateSystemId) { throw null; }
        public static System.Data.Common.CommandTrees.DbFunctionExpression GeometryFromBinary(System.Data.Common.CommandTrees.DbExpression wellKnownBinaryValue) { throw null; }
        public static System.Data.Common.CommandTrees.DbFunctionExpression GeometryFromBinary(System.Data.Common.CommandTrees.DbExpression wellKnownBinaryValue, System.Data.Common.CommandTrees.DbExpression coordinateSystemId) { throw null; }
        public static System.Data.Common.CommandTrees.DbFunctionExpression GeometryFromGml(System.Data.Common.CommandTrees.DbExpression geometryMarkup) { throw null; }
        public static System.Data.Common.CommandTrees.DbFunctionExpression GeometryFromGml(System.Data.Common.CommandTrees.DbExpression geometryMarkup, System.Data.Common.CommandTrees.DbExpression coordinateSystemId) { throw null; }
        public static System.Data.Common.CommandTrees.DbFunctionExpression GeometryFromText(System.Data.Common.CommandTrees.DbExpression wellKnownText) { throw null; }
        public static System.Data.Common.CommandTrees.DbFunctionExpression GeometryFromText(System.Data.Common.CommandTrees.DbExpression wellKnownText, System.Data.Common.CommandTrees.DbExpression coordinateSystemId) { throw null; }
        public static System.Data.Common.CommandTrees.DbFunctionExpression GeometryLineFromBinary(System.Data.Common.CommandTrees.DbExpression lineWellKnownBinaryValue, System.Data.Common.CommandTrees.DbExpression coordinateSystemId) { throw null; }
        public static System.Data.Common.CommandTrees.DbFunctionExpression GeometryLineFromText(System.Data.Common.CommandTrees.DbExpression lineWellKnownText, System.Data.Common.CommandTrees.DbExpression coordinateSystemId) { throw null; }
        public static System.Data.Common.CommandTrees.DbFunctionExpression GeometryMultiLineFromBinary(System.Data.Common.CommandTrees.DbExpression multiLineWellKnownBinaryValue, System.Data.Common.CommandTrees.DbExpression coordinateSystemId) { throw null; }
        public static System.Data.Common.CommandTrees.DbFunctionExpression GeometryMultiLineFromText(System.Data.Common.CommandTrees.DbExpression multiLineWellKnownText, System.Data.Common.CommandTrees.DbExpression coordinateSystemId) { throw null; }
        public static System.Data.Common.CommandTrees.DbFunctionExpression GeometryMultiPointFromBinary(System.Data.Common.CommandTrees.DbExpression multiPointWellKnownBinaryValue, System.Data.Common.CommandTrees.DbExpression coordinateSystemId) { throw null; }
        public static System.Data.Common.CommandTrees.DbFunctionExpression GeometryMultiPointFromText(System.Data.Common.CommandTrees.DbExpression multiPointWellKnownText, System.Data.Common.CommandTrees.DbExpression coordinateSystemId) { throw null; }
        public static System.Data.Common.CommandTrees.DbFunctionExpression GeometryMultiPolygonFromBinary(System.Data.Common.CommandTrees.DbExpression multiPolygonWellKnownBinaryValue, System.Data.Common.CommandTrees.DbExpression coordinateSystemId) { throw null; }
        public static System.Data.Common.CommandTrees.DbFunctionExpression GeometryMultiPolygonFromText(System.Data.Common.CommandTrees.DbExpression multiPolygonWellKnownText, System.Data.Common.CommandTrees.DbExpression coordinateSystemId) { throw null; }
        public static System.Data.Common.CommandTrees.DbFunctionExpression GeometryPointFromBinary(System.Data.Common.CommandTrees.DbExpression pointWellKnownBinaryValue, System.Data.Common.CommandTrees.DbExpression coordinateSystemId) { throw null; }
        public static System.Data.Common.CommandTrees.DbFunctionExpression GeometryPointFromText(System.Data.Common.CommandTrees.DbExpression pointWellKnownText, System.Data.Common.CommandTrees.DbExpression coordinateSystemId) { throw null; }
        public static System.Data.Common.CommandTrees.DbFunctionExpression GeometryPolygonFromBinary(System.Data.Common.CommandTrees.DbExpression polygonWellKnownBinaryValue, System.Data.Common.CommandTrees.DbExpression coordinateSystemId) { throw null; }
        public static System.Data.Common.CommandTrees.DbFunctionExpression GeometryPolygonFromText(System.Data.Common.CommandTrees.DbExpression polygonWellKnownText, System.Data.Common.CommandTrees.DbExpression coordinateSystemId) { throw null; }
        public static System.Data.Common.CommandTrees.DbFunctionExpression InteriorRingAt(this System.Data.Common.CommandTrees.DbExpression geometryValue, System.Data.Common.CommandTrees.DbExpression indexValue) { throw null; }
        public static System.Data.Common.CommandTrees.DbFunctionExpression InteriorRingCount(this System.Data.Common.CommandTrees.DbExpression geometryValue) { throw null; }
        public static System.Data.Common.CommandTrees.DbFunctionExpression IsClosedSpatial(this System.Data.Common.CommandTrees.DbExpression spatialValue) { throw null; }
        public static System.Data.Common.CommandTrees.DbFunctionExpression IsEmptySpatial(this System.Data.Common.CommandTrees.DbExpression spatialValue) { throw null; }
        public static System.Data.Common.CommandTrees.DbFunctionExpression IsRing(this System.Data.Common.CommandTrees.DbExpression geometryValue) { throw null; }
        public static System.Data.Common.CommandTrees.DbFunctionExpression IsSimpleGeometry(this System.Data.Common.CommandTrees.DbExpression geometryValue) { throw null; }
        public static System.Data.Common.CommandTrees.DbFunctionExpression IsValidGeometry(this System.Data.Common.CommandTrees.DbExpression geometryValue) { throw null; }
        public static System.Data.Common.CommandTrees.DbFunctionExpression Latitude(this System.Data.Common.CommandTrees.DbExpression geographyValue) { throw null; }
        public static System.Data.Common.CommandTrees.DbFunctionExpression Longitude(this System.Data.Common.CommandTrees.DbExpression geographyValue) { throw null; }
        public static System.Data.Common.CommandTrees.DbFunctionExpression Measure(this System.Data.Common.CommandTrees.DbExpression spatialValue) { throw null; }
        public static System.Data.Common.CommandTrees.DbFunctionExpression PointAt(this System.Data.Common.CommandTrees.DbExpression spatialValue, System.Data.Common.CommandTrees.DbExpression indexValue) { throw null; }
        public static System.Data.Common.CommandTrees.DbFunctionExpression PointCount(this System.Data.Common.CommandTrees.DbExpression spatialValue) { throw null; }
        public static System.Data.Common.CommandTrees.DbFunctionExpression PointOnSurface(this System.Data.Common.CommandTrees.DbExpression geometryValue) { throw null; }
        public static System.Data.Common.CommandTrees.DbFunctionExpression SpatialBoundary(this System.Data.Common.CommandTrees.DbExpression geometryValue) { throw null; }
        public static System.Data.Common.CommandTrees.DbFunctionExpression SpatialBuffer(this System.Data.Common.CommandTrees.DbExpression spatialValue, System.Data.Common.CommandTrees.DbExpression distance) { throw null; }
        public static System.Data.Common.CommandTrees.DbFunctionExpression SpatialContains(this System.Data.Common.CommandTrees.DbExpression geometryValue1, System.Data.Common.CommandTrees.DbExpression geometryValue2) { throw null; }
        public static System.Data.Common.CommandTrees.DbFunctionExpression SpatialConvexHull(this System.Data.Common.CommandTrees.DbExpression geometryValue) { throw null; }
        public static System.Data.Common.CommandTrees.DbFunctionExpression SpatialCrosses(this System.Data.Common.CommandTrees.DbExpression geometryValue1, System.Data.Common.CommandTrees.DbExpression geometryValue2) { throw null; }
        public static System.Data.Common.CommandTrees.DbFunctionExpression SpatialDifference(this System.Data.Common.CommandTrees.DbExpression spatialValue1, System.Data.Common.CommandTrees.DbExpression spatialValue2) { throw null; }
        public static System.Data.Common.CommandTrees.DbFunctionExpression SpatialDimension(this System.Data.Common.CommandTrees.DbExpression spatialValue) { throw null; }
        public static System.Data.Common.CommandTrees.DbFunctionExpression SpatialDisjoint(this System.Data.Common.CommandTrees.DbExpression spatialValue1, System.Data.Common.CommandTrees.DbExpression spatialValue2) { throw null; }
        public static System.Data.Common.CommandTrees.DbFunctionExpression SpatialElementAt(this System.Data.Common.CommandTrees.DbExpression spatialValue, System.Data.Common.CommandTrees.DbExpression indexValue) { throw null; }
        public static System.Data.Common.CommandTrees.DbFunctionExpression SpatialElementCount(this System.Data.Common.CommandTrees.DbExpression spatialValue) { throw null; }
        public static System.Data.Common.CommandTrees.DbFunctionExpression SpatialEnvelope(this System.Data.Common.CommandTrees.DbExpression geometryValue) { throw null; }
        public static System.Data.Common.CommandTrees.DbFunctionExpression SpatialEquals(this System.Data.Common.CommandTrees.DbExpression spatialValue1, System.Data.Common.CommandTrees.DbExpression spatialValue2) { throw null; }
        public static System.Data.Common.CommandTrees.DbFunctionExpression SpatialIntersection(this System.Data.Common.CommandTrees.DbExpression spatialValue1, System.Data.Common.CommandTrees.DbExpression spatialValue2) { throw null; }
        public static System.Data.Common.CommandTrees.DbFunctionExpression SpatialIntersects(this System.Data.Common.CommandTrees.DbExpression spatialValue1, System.Data.Common.CommandTrees.DbExpression spatialValue2) { throw null; }
        public static System.Data.Common.CommandTrees.DbFunctionExpression SpatialLength(this System.Data.Common.CommandTrees.DbExpression spatialValue) { throw null; }
        public static System.Data.Common.CommandTrees.DbFunctionExpression SpatialOverlaps(this System.Data.Common.CommandTrees.DbExpression geometryValue1, System.Data.Common.CommandTrees.DbExpression geometryValue2) { throw null; }
        public static System.Data.Common.CommandTrees.DbFunctionExpression SpatialRelate(this System.Data.Common.CommandTrees.DbExpression geometryValue1, System.Data.Common.CommandTrees.DbExpression geometryValue2, System.Data.Common.CommandTrees.DbExpression intersectionPatternMatrix) { throw null; }
        public static System.Data.Common.CommandTrees.DbFunctionExpression SpatialSymmetricDifference(this System.Data.Common.CommandTrees.DbExpression spatialValue1, System.Data.Common.CommandTrees.DbExpression spatialValue2) { throw null; }
        public static System.Data.Common.CommandTrees.DbFunctionExpression SpatialTouches(this System.Data.Common.CommandTrees.DbExpression geometryValue1, System.Data.Common.CommandTrees.DbExpression geometryValue2) { throw null; }
        public static System.Data.Common.CommandTrees.DbFunctionExpression SpatialTypeName(this System.Data.Common.CommandTrees.DbExpression spatialValue) { throw null; }
        public static System.Data.Common.CommandTrees.DbFunctionExpression SpatialUnion(this System.Data.Common.CommandTrees.DbExpression spatialValue1, System.Data.Common.CommandTrees.DbExpression spatialValue2) { throw null; }
        public static System.Data.Common.CommandTrees.DbFunctionExpression SpatialWithin(this System.Data.Common.CommandTrees.DbExpression geometryValue1, System.Data.Common.CommandTrees.DbExpression geometryValue2) { throw null; }
        public static System.Data.Common.CommandTrees.DbFunctionExpression StartPoint(this System.Data.Common.CommandTrees.DbExpression spatialValue) { throw null; }
        public static System.Data.Common.CommandTrees.DbFunctionExpression XCoordinate(this System.Data.Common.CommandTrees.DbExpression geometryValue) { throw null; }
        public static System.Data.Common.CommandTrees.DbFunctionExpression YCoordinate(this System.Data.Common.CommandTrees.DbExpression geometryValue) { throw null; }
    }
}
namespace System.Data.Common.EntitySql
{
    public sealed partial class EntitySqlParser
    {
        internal EntitySqlParser() { }
        public System.Data.Common.EntitySql.ParseResult Parse(string query, params System.Data.Common.CommandTrees.DbParameterReferenceExpression[] parameters) { throw null; }
        public System.Data.Common.CommandTrees.DbLambda ParseLambda(string query, params System.Data.Common.CommandTrees.DbVariableReferenceExpression[] variables) { throw null; }
    }
    public sealed partial class FunctionDefinition
    {
        internal FunctionDefinition() { }
        public int EndPosition { get { throw null; } }
        public System.Data.Common.CommandTrees.DbLambda Lambda { get { throw null; } }
        public string Name { get { throw null; } }
        public int StartPosition { get { throw null; } }
    }
    public sealed partial class ParseResult
    {
        internal ParseResult() { }
        public System.Data.Common.CommandTrees.DbCommandTree CommandTree { get { throw null; } }
        public System.Collections.ObjectModel.ReadOnlyCollection<System.Data.Common.EntitySql.FunctionDefinition> FunctionDefinitions { get { throw null; } }
    }
}
namespace System.Data.Entity
{
    public static partial class Strings
    {
        public static string ADP_ClosedDataReaderError { get { throw null; } }
        public static string ADP_GetSchemaTableIsNotSupported { get { throw null; } }
        public static string ADP_ImplicitlyClosedDataReaderError { get { throw null; } }
        public static string ADP_InvalidDataDirectory { get { throw null; } }
        public static string ADP_InvalidDataReaderFieldCountForScalarType { get { throw null; } }
        public static string ADP_InvalidDataReaderUnableToDetermineType { get { throw null; } }
        public static string ADP_InvalidMultipartNameDelimiterUsage { get { throw null; } }
        public static string ADP_KeysRequiredForNesting { get { throw null; } }
        public static string ADP_MustUseSequentialAccess { get { throw null; } }
        public static string ADP_NoData { get { throw null; } }
        public static string ADP_ProviderDoesNotSupportCommandTrees { get { throw null; } }
        public static string AllElementsMustBeInSchema { get { throw null; } }
        public static string AmbiguousFunctionArguments { get { throw null; } }
        public static string ArgumentMustBeCSpaceType { get { throw null; } }
        public static string ArgumentMustBeOSpaceType { get { throw null; } }
        public static string ArrayTooSmall { get { throw null; } }
        public static string AtleastOneSSDLNeeded { get { throw null; } }
        public static string BadNavigationPropertyRolesCannotBeTheSame { get { throw null; } }
        public static string BetweenLimitsCannotBeUntypedNulls { get { throw null; } }
        public static string CalculatedEnumValueOutOfRange { get { throw null; } }
        public static string CannotCreateEmptyMultiset { get { throw null; } }
        public static string CannotCreateMultisetofNulls { get { throw null; } }
        public static string CannotLoadDifferentVersionOfSchemaInTheSameItemCollection { get { throw null; } }
        public static string CodeGen_PropertyDeclaringTypeIsValueType { get { throw null; } }
        public static string CodeGen_PropertyIsIndexed { get { throw null; } }
        public static string CodeGen_PropertyIsStatic { get { throw null; } }
        public static string CodeGen_PropertyNoGetter { get { throw null; } }
        public static string CodeGen_PropertyNoSetter { get { throw null; } }
        public static string CodeGen_PropertyStrongNameIdentity { get { throw null; } }
        public static string CodeGen_PropertyUnsupportedForm { get { throw null; } }
        public static string CodeGen_PropertyUnsupportedType { get { throw null; } }
        public static string Collections_InvalidEntityStateSource { get { throw null; } }
        public static string Collections_UnableToMergeCollections { get { throw null; } }
        public static string CommandTextFunctionsCannotDeclareStoreFunctionName { get { throw null; } }
        public static string CommandTextFunctionsNotComposable { get { throw null; } }
        public static string ComplexObject_ComplexObjectAlreadyAttachedToParent { get { throw null; } }
        public static string ComposableFunctionOrFunctionImportMustDeclareReturnType { get { throw null; } }
        public static string ConcatBuiltinNotSupported { get { throw null; } }
        public static string Cqt_Aggregate_InvalidFunction { get { throw null; } }
        public static string Cqt_And_BooleanArgumentsRequired { get { throw null; } }
        public static string Cqt_Apply_DuplicateVariableNames { get { throw null; } }
        public static string Cqt_Arithmetic_NumericCommonType { get { throw null; } }
        public static string Cqt_Binding_CollectionRequired { get { throw null; } }
        public static string Cqt_Binding_VariableNameNotValid { get { throw null; } }
        public static string Cqt_Case_InvalidResultType { get { throw null; } }
        public static string Cqt_Case_WhensMustEqualThens { get { throw null; } }
        public static string Cqt_CommandTree_InvalidDataSpace { get { throw null; } }
        public static string Cqt_Comparison_ComparableRequired { get { throw null; } }
        public static string Cqt_Constant_InvalidType { get { throw null; } }
        public static string Cqt_CrossJoin_AtLeastTwoInputs { get { throw null; } }
        public static string Cqt_DeRef_RefRequired { get { throw null; } }
        public static string Cqt_Distinct_InvalidCollection { get { throw null; } }
        public static string Cqt_Element_InvalidArgumentForUnwrapSingleProperty { get { throw null; } }
        public static string Cqt_Exceptions_InvalidCommandTree { get { throw null; } }
        public static string Cqt_ExpressionList_IncorrectElementCount { get { throw null; } }
        public static string Cqt_Factory_IncompatibleRelationEnds { get { throw null; } }
        public static string Cqt_Factory_NewCollectionInvalidCommonType { get { throw null; } }
        public static string Cqt_Factory_NoSuchRelationEnd { get { throw null; } }
        public static string Cqt_Function_CommandTextInExpression { get { throw null; } }
        public static string Cqt_Function_NonComposableInExpression { get { throw null; } }
        public static string Cqt_Function_VoidResultInvalid { get { throw null; } }
        public static string Cqt_General_MetadataNotReadOnly { get { throw null; } }
        public static string Cqt_General_NoProviderBooleanType { get { throw null; } }
        public static string Cqt_General_NoProviderIntegerType { get { throw null; } }
        public static string Cqt_General_NoProviderStringType { get { throw null; } }
        public static string Cqt_GetEntityRef_EntityRequired { get { throw null; } }
        public static string Cqt_GetRefKey_RefRequired { get { throw null; } }
        public static string Cqt_GroupBinding_CollectionRequired { get { throw null; } }
        public static string Cqt_GroupBinding_GroupVariableNameNotValid { get { throw null; } }
        public static string Cqt_GroupBy_AtLeastOneKeyOrAggregate { get { throw null; } }
        public static string Cqt_GroupBy_MoreThanOneGroupAggregate { get { throw null; } }
        public static string Cqt_IsNull_CollectionNotAllowed { get { throw null; } }
        public static string Cqt_IsNull_InvalidType { get { throw null; } }
        public static string Cqt_Join_DuplicateVariableNames { get { throw null; } }
        public static string Cqt_Limit_ConstantOrParameterRefRequired { get { throw null; } }
        public static string Cqt_Limit_IntegerRequired { get { throw null; } }
        public static string Cqt_Limit_NonNegativeLimitRequired { get { throw null; } }
        public static string Cqt_Metadata_EdmMemberIncorrectSpace { get { throw null; } }
        public static string Cqt_Metadata_EntitySetEntityContainerNull { get { throw null; } }
        public static string Cqt_Metadata_EntitySetIncorrectSpace { get { throw null; } }
        public static string Cqt_Metadata_EntityTypeEmptyKeyMembersInvalid { get { throw null; } }
        public static string Cqt_Metadata_EntityTypeNullKeyMembersInvalid { get { throw null; } }
        public static string Cqt_Metadata_FunctionIncorrectSpace { get { throw null; } }
        public static string Cqt_Metadata_FunctionParameterIncorrectSpace { get { throw null; } }
        public static string Cqt_Metadata_FunctionReturnParameterNull { get { throw null; } }
        public static string Cqt_Metadata_TypeUsageIncorrectSpace { get { throw null; } }
        public static string Cqt_NewInstance_CollectionTypeRequired { get { throw null; } }
        public static string Cqt_NewInstance_IncompatibleRelatedEntity_SourceTypeNotValid { get { throw null; } }
        public static string Cqt_NewInstance_StructuralTypeRequired { get { throw null; } }
        public static string Cqt_Not_BooleanArgumentRequired { get { throw null; } }
        public static string Cqt_Or_BooleanArgumentsRequired { get { throw null; } }
        public static string Cqt_Property_InstanceRequiredForInstance { get { throw null; } }
        public static string Cqt_Ref_PolymorphicArgRequired { get { throw null; } }
        public static string Cqt_RelatedEntityRef_TargetEndFromDifferentRelationship { get { throw null; } }
        public static string Cqt_RelatedEntityRef_TargetEndMustBeAtMostOne { get { throw null; } }
        public static string Cqt_RelatedEntityRef_TargetEndSameAsSourceEnd { get { throw null; } }
        public static string Cqt_RelatedEntityRef_TargetEntityNotCompatible { get { throw null; } }
        public static string Cqt_RelatedEntityRef_TargetEntityNotRef { get { throw null; } }
        public static string Cqt_RelNav_NoCompositions { get { throw null; } }
        public static string Cqt_Skip_ConstantOrParameterRefRequired { get { throw null; } }
        public static string Cqt_Skip_IntegerRequired { get { throw null; } }
        public static string Cqt_Skip_NonNegativeCountRequired { get { throw null; } }
        public static string Cqt_Sort_EmptyCollationInvalid { get { throw null; } }
        public static string Cqt_Sort_NonStringCollationInvalid { get { throw null; } }
        public static string Cqt_Sort_OrderComparable { get { throw null; } }
        public static string Cqt_Util_CheckListEmptyInvalid { get { throw null; } }
        public static string CtxAlias { get { throw null; } }
        public static string CtxAliasedNamespaceImport { get { throw null; } }
        public static string CtxAnd { get { throw null; } }
        public static string CtxAnyElement { get { throw null; } }
        public static string CtxApplyClause { get { throw null; } }
        public static string CtxBetween { get { throw null; } }
        public static string CtxCase { get { throw null; } }
        public static string CtxCaseElse { get { throw null; } }
        public static string CtxCaseWhenThen { get { throw null; } }
        public static string CtxCast { get { throw null; } }
        public static string CtxCollatedOrderByClauseItem { get { throw null; } }
        public static string CtxCollectionTypeDefinition { get { throw null; } }
        public static string CtxCommandExpression { get { throw null; } }
        public static string CtxCreateRef { get { throw null; } }
        public static string CtxDeref { get { throw null; } }
        public static string CtxDivide { get { throw null; } }
        public static string CtxElement { get { throw null; } }
        public static string CtxEquals { get { throw null; } }
        public static string CtxEscapedIdentifier { get { throw null; } }
        public static string CtxExcept { get { throw null; } }
        public static string CtxExists { get { throw null; } }
        public static string CtxExpressionList { get { throw null; } }
        public static string CtxFlatten { get { throw null; } }
        public static string CtxFromApplyClause { get { throw null; } }
        public static string CtxFromClause { get { throw null; } }
        public static string CtxFromClauseItem { get { throw null; } }
        public static string CtxFromClauseList { get { throw null; } }
        public static string CtxFromJoinClause { get { throw null; } }
        public static string CtxFunctionDefinition { get { throw null; } }
        public static string CtxGreaterThan { get { throw null; } }
        public static string CtxGreaterThanEqual { get { throw null; } }
        public static string CtxGroupByClause { get { throw null; } }
        public static string CtxGroupPartition { get { throw null; } }
        public static string CtxHavingClause { get { throw null; } }
        public static string CtxIdentifier { get { throw null; } }
        public static string CtxIn { get { throw null; } }
        public static string CtxIntersect { get { throw null; } }
        public static string CtxIsNotNull { get { throw null; } }
        public static string CtxIsNotOf { get { throw null; } }
        public static string CtxIsNull { get { throw null; } }
        public static string CtxIsOf { get { throw null; } }
        public static string CtxJoinClause { get { throw null; } }
        public static string CtxJoinOnClause { get { throw null; } }
        public static string CtxKey { get { throw null; } }
        public static string CtxLessThan { get { throw null; } }
        public static string CtxLessThanEqual { get { throw null; } }
        public static string CtxLike { get { throw null; } }
        public static string CtxLimitSubClause { get { throw null; } }
        public static string CtxLiteral { get { throw null; } }
        public static string CtxMemberAccess { get { throw null; } }
        public static string CtxMethod { get { throw null; } }
        public static string CtxMinus { get { throw null; } }
        public static string CtxModulus { get { throw null; } }
        public static string CtxMultiply { get { throw null; } }
        public static string CtxMultisetCtor { get { throw null; } }
        public static string CtxNamespaceImport { get { throw null; } }
        public static string CtxNamespaceImportList { get { throw null; } }
        public static string CtxNavigate { get { throw null; } }
        public static string CtxNot { get { throw null; } }
        public static string CtxNotBetween { get { throw null; } }
        public static string CtxNotEqual { get { throw null; } }
        public static string CtxNotIn { get { throw null; } }
        public static string CtxNotLike { get { throw null; } }
        public static string CtxNullLiteral { get { throw null; } }
        public static string CtxOfType { get { throw null; } }
        public static string CtxOfTypeOnly { get { throw null; } }
        public static string CtxOr { get { throw null; } }
        public static string CtxOrderByClause { get { throw null; } }
        public static string CtxOrderByClauseItem { get { throw null; } }
        public static string CtxOverlaps { get { throw null; } }
        public static string CtxParen { get { throw null; } }
        public static string CtxPlus { get { throw null; } }
        public static string CtxQueryExpression { get { throw null; } }
        public static string CtxQueryStatement { get { throw null; } }
        public static string CtxRef { get { throw null; } }
        public static string CtxRefTypeDefinition { get { throw null; } }
        public static string CtxRelationship { get { throw null; } }
        public static string CtxRelationshipList { get { throw null; } }
        public static string CtxRowCtor { get { throw null; } }
        public static string CtxRowTypeDefinition { get { throw null; } }
        public static string CtxSelectRowClause { get { throw null; } }
        public static string CtxSelectValueClause { get { throw null; } }
        public static string CtxSet { get { throw null; } }
        public static string CtxSimpleIdentifier { get { throw null; } }
        public static string CtxSkipSubClause { get { throw null; } }
        public static string CtxTopSubClause { get { throw null; } }
        public static string CtxTreat { get { throw null; } }
        public static string CtxTypeName { get { throw null; } }
        public static string CtxTypeNameWithTypeSpec { get { throw null; } }
        public static string CtxUnaryMinus { get { throw null; } }
        public static string CtxUnaryPlus { get { throw null; } }
        public static string CtxUnion { get { throw null; } }
        public static string CtxUnionAll { get { throw null; } }
        public static string CtxWhereClause { get { throw null; } }
        public static string DefaultNotAllowed { get { throw null; } }
        public static string DuplicateEnumMember { get { throw null; } }
        public static string EdmMembersDefiningTypeDoNotAgreeWithMetadataType { get { throw null; } }
        public static string ElementOperatorIsNotSupported { get { throw null; } }
        public static string ELinq_AnonymousType { get { throw null; } }
        public static string ELinq_ClosureType { get { throw null; } }
        public static string ELinq_CreateOrderedEnumerableNotSupported { get { throw null; } }
        public static string ELinq_CycleDetected { get { throw null; } }
        public static string ELinq_EdmFunctionDirectCall { get { throw null; } }
        public static string ELinq_ExpressionMustBeIQueryable { get { throw null; } }
        public static string ELinq_MethodNotDirectlyCallable { get { throw null; } }
        public static string ELinq_PropertyIndexNotSupported { get { throw null; } }
        public static string ELinq_SkipWithoutOrder { get { throw null; } }
        public static string ELinq_ThenByDoesNotFollowOrderBy { get { throw null; } }
        public static string ELinq_UnsupportedBinding { get { throw null; } }
        public static string ELinq_UnsupportedCastToDecimal { get { throw null; } }
        public static string ELinq_UnsupportedConstructor { get { throw null; } }
        public static string ELinq_UnsupportedDifferentContexts { get { throw null; } }
        public static string ELinq_UnsupportedInclude { get { throw null; } }
        public static string ELinq_UnsupportedInitializers { get { throw null; } }
        public static string ELinq_UnsupportedMergeAs { get { throw null; } }
        public static string ELinq_UnsupportedNestedFirst { get { throw null; } }
        public static string ELinq_UnsupportedNestedSingle { get { throw null; } }
        public static string ELinq_UnsupportedQueryableMethod { get { throw null; } }
        public static string EmptyCommandText { get { throw null; } }
        public static string EmptyDefiningQuery { get { throw null; } }
        public static string EmptySchemaTextReader { get { throw null; } }
        public static string EntityClient_CannotCloneStoreProvider { get { throw null; } }
        public static string EntityClient_CannotDeduceDbType { get { throw null; } }
        public static string EntityClient_CannotGetCommandText { get { throw null; } }
        public static string EntityClient_CannotGetCommandTree { get { throw null; } }
        public static string EntityClient_CannotReopenConnection { get { throw null; } }
        public static string EntityClient_CannotReprepareCommandDefinitionBasedCommand { get { throw null; } }
        public static string EntityClient_CannotSetCommandText { get { throw null; } }
        public static string EntityClient_CannotSetCommandTree { get { throw null; } }
        public static string EntityClient_ClosedConnectionForUpdate { get { throw null; } }
        public static string EntityClient_CommandDefinitionExecutionFailed { get { throw null; } }
        public static string EntityClient_CommandDefinitionPreparationFailed { get { throw null; } }
        public static string EntityClient_CommandExecutionFailed { get { throw null; } }
        public static string EntityClient_CommandTreeMetadataIncompatible { get { throw null; } }
        public static string EntityClient_ConnectionMustBeClosed { get { throw null; } }
        public static string EntityClient_ConnectionNotOpen { get { throw null; } }
        public static string EntityClient_ConnectionStateBroken { get { throw null; } }
        public static string EntityClient_ConnectionStateClosed { get { throw null; } }
        public static string EntityClient_ConnectionStringNeededBeforeOperation { get { throw null; } }
        public static string EntityClient_DataReaderIsStillOpen { get { throw null; } }
        public static string EntityClient_EmptyParameterName { get { throw null; } }
        public static string EntityClient_ErrorInBeginningTransaction { get { throw null; } }
        public static string EntityClient_ErrorInClosingConnection { get { throw null; } }
        public static string EntityClient_ExtraParametersWithNamedConnection { get { throw null; } }
        public static string EntityClient_FunctionImportEmptyCommandText { get { throw null; } }
        public static string EntityClient_InvalidNamedConnection { get { throw null; } }
        public static string EntityClient_InvalidStoredProcedureCommandText { get { throw null; } }
        public static string EntityClient_InvalidStoreProvider { get { throw null; } }
        public static string EntityClient_InvalidTransactionForCommand { get { throw null; } }
        public static string EntityClient_NoCommandText { get { throw null; } }
        public static string EntityClient_NoConnectionForAdapter { get { throw null; } }
        public static string EntityClient_NoConnectionForCommand { get { throw null; } }
        public static string EntityClient_NoStoreConnectionForUpdate { get { throw null; } }
        public static string EntityClient_ProviderGeneralError { get { throw null; } }
        public static string EntityClient_RequiresNonStoreCommandTree { get { throw null; } }
        public static string EntityClient_SettingsCannotBeChangedOnOpenConnection { get { throw null; } }
        public static string EntityClient_StoreReaderFailed { get { throw null; } }
        public static string EntityClient_TooFewColumns { get { throw null; } }
        public static string EntityClient_TransactionAlreadyStarted { get { throw null; } }
        public static string EntityClient_UnsupportedCommandType { get { throw null; } }
        public static string EntityClient_ValueNotString { get { throw null; } }
        public static string EntityKey_CannotChangeKey { get { throw null; } }
        public static string EntityKey_DataRecordMustBeEntity { get { throw null; } }
        public static string EntityKey_EntityKeyMustHaveValues { get { throw null; } }
        public static string EntityKey_InvalidQualifiedEntitySetName { get { throw null; } }
        public static string EntityKey_MissingEntitySetName { get { throw null; } }
        public static string EntityKey_NoNullsAllowedInKeyValuePairs { get { throw null; } }
        public static string EntityKey_UnexpectedNull { get { throw null; } }
        public static string EntityParameterCollectionRemoveInvalidObject { get { throw null; } }
        public static string EntityParameterContainedByAnotherCollection { get { throw null; } }
        public static string EntityParameterNull { get { throw null; } }
        public static string EntityProxyTypeInfo_ProxyHasWrongWrapper { get { throw null; } }
        public static string EntityReference_CannotChangeReferentialConstraintProperty { get { throw null; } }
        public static string EntityReference_CannotSetSpecialKeys { get { throw null; } }
        public static string EntityReference_EntityKeyValueMismatch { get { throw null; } }
        public static string EntityReference_LessThanExpectedRelatedEntitiesFound { get { throw null; } }
        public static string EntityReference_MoreThanExpectedRelatedEntitiesFound { get { throw null; } }
        public static string EntitySetInAnotherContainer { get { throw null; } }
        public static string EntityTypesDoNotAgree { get { throw null; } }
        public static string Entity_EntityCantHaveMultipleChangeTrackers { get { throw null; } }
        public static string ExpressionCannotBeNull { get { throw null; } }
        public static string ExpressionMustBeCollection { get { throw null; } }
        public static string ExpressionMustBeNumericType { get { throw null; } }
        public static string ExpressionTypeMustBeBoolean { get { throw null; } }
        public static string ExpressionTypeMustBeEqualComparable { get { throw null; } }
        public static string ExpressionTypeMustNotBeCollection { get { throw null; } }
        public static string ExprIsNotValidEntitySetForCreateRef { get { throw null; } }
        public static string ExtraInfo { get { throw null; } }
        public static string FacetDeclarationRequiresTypeAttribute { get { throw null; } }
        public static string FailedToRetrieveProviderManifest { get { throw null; } }
        public static string GeneralQueryError { get { throw null; } }
        public static string Generated_Views_Changed { get { throw null; } }
        public static string GeneratorErrorSeverityError { get { throw null; } }
        public static string GeneratorErrorSeverityUnknown { get { throw null; } }
        public static string GeneratorErrorSeverityWarning { get { throw null; } }
        public static string GenericSyntaxError { get { throw null; } }
        public static string GroupingKeysMustBeEqualComparable { get { throw null; } }
        public static string GroupPartitionOutOfContext { get { throw null; } }
        public static string GroupVarNotFoundInScope { get { throw null; } }
        public static string HavingRequiresGroupClause { get { throw null; } }
        public static string ImcompatibleCreateRefKeyElementType { get { throw null; } }
        public static string ImcompatibleCreateRefKeyType { get { throw null; } }
        public static string IncorrectProviderManifest { get { throw null; } }
        public static string InFromClause { get { throw null; } }
        public static string InGroupClause { get { throw null; } }
        public static string InnerJoinMustHaveOnPredicate { get { throw null; } }
        public static string InRowCtor { get { throw null; } }
        public static string InSelectProjectionList { get { throw null; } }
        public static string InvalidArgumentTypeForAggregateFunction { get { throw null; } }
        public static string InvalidCaseResultTypes { get { throw null; } }
        public static string InvalidCaseWhenThenNullType { get { throw null; } }
        public static string InvalidCastExpressionType { get { throw null; } }
        public static string InvalidCastType { get { throw null; } }
        public static string InvalidCreateRefKeyType { get { throw null; } }
        public static string InvalidDistinctArgumentInCtor { get { throw null; } }
        public static string InvalidDistinctArgumentInNonAggFunction { get { throw null; } }
        public static string InvalidDocumentationBothTextAndStructure { get { throw null; } }
        public static string InvalidEmptyIdentifier { get { throw null; } }
        public static string InvalidEmptyQuery { get { throw null; } }
        public static string InvalidEmptyQueryTextArgument { get { throw null; } }
        public static string InvalidEnumUnderlyingType { get { throw null; } }
        public static string InvalidFlattenArgument { get { throw null; } }
        public static string InvalidJoinLeftCorrelation { get { throw null; } }
        public static string InvalidMaxLengthSize { get { throw null; } }
        public static string InvalidMetadataMemberName { get { throw null; } }
        public static string InvalidMetadataPath { get { throw null; } }
        public static string InvalidModeForWithRelationshipClause { get { throw null; } }
        public static string InvalidNamespaceAlias { get { throw null; } }
        public static string InvalidNullArithmetic { get { throw null; } }
        public static string InvalidNullComparison { get { throw null; } }
        public static string InvalidOperationMultipleEndsInAssociation { get { throw null; } }
        public static string InvalidOperatorSymbol { get { throw null; } }
        public static string InvalidPredicateForCrossJoin { get { throw null; } }
        public static string InvalidPunctuatorSymbol { get { throw null; } }
        public static string InvalidSavePoint { get { throw null; } }
        public static string InvalidScopeIndex { get { throw null; } }
        public static string InvalidSelectValueAliasedExpression { get { throw null; } }
        public static string InvalidSelectValueList { get { throw null; } }
        public static string InvalidTypeForWithRelationshipClause { get { throw null; } }
        public static string Iqt_CTGen_UnexpectedAggregate { get { throw null; } }
        public static string Iqt_CTGen_UnexpectedVarDef { get { throw null; } }
        public static string Iqt_CTGen_UnexpectedVarDefList { get { throw null; } }
        public static string IsNullInvalidType { get { throw null; } }
        public static string LeftSetExpressionArgsMustBeCollection { get { throw null; } }
        public static string LikeArgMustBeStringType { get { throw null; } }
        public static string LocalizedCollection { get { throw null; } }
        public static string LocalizedColumn { get { throw null; } }
        public static string LocalizedComplex { get { throw null; } }
        public static string LocalizedEntity { get { throw null; } }
        public static string LocalizedEntityContainerExpression { get { throw null; } }
        public static string LocalizedEnumMember { get { throw null; } }
        public static string LocalizedFunction { get { throw null; } }
        public static string LocalizedInlineFunction { get { throw null; } }
        public static string LocalizedKeyword { get { throw null; } }
        public static string LocalizedLeft { get { throw null; } }
        public static string LocalizedLine { get { throw null; } }
        public static string LocalizedMetadataMemberExpression { get { throw null; } }
        public static string LocalizedNamespace { get { throw null; } }
        public static string LocalizedNear { get { throw null; } }
        public static string LocalizedPrimitive { get { throw null; } }
        public static string LocalizedReference { get { throw null; } }
        public static string LocalizedRight { get { throw null; } }
        public static string LocalizedRow { get { throw null; } }
        public static string LocalizedTerm { get { throw null; } }
        public static string LocalizedType { get { throw null; } }
        public static string LocalizedValueExpression { get { throw null; } }
        public static string MalformedSingleQuotePayload { get { throw null; } }
        public static string MalformedStringLiteralPayload { get { throw null; } }
        public static string Mapping_ConditionValueTypeMismatch { get { throw null; } }
        public static string Mapping_DifferentEdmStoreVersion { get { throw null; } }
        public static string Mapping_DifferentMappingEdmStoreVersion { get { throw null; } }
        public static string Mapping_DistinctFlagInReadWriteContainer { get { throw null; } }
        public static string Mapping_General_Error { get { throw null; } }
        public static string Mapping_InvalidContent_Association_Type_Empty { get { throw null; } }
        public static string Mapping_InvalidContent_ConditionMapping_Both_Members { get { throw null; } }
        public static string Mapping_InvalidContent_ConditionMapping_Both_Values { get { throw null; } }
        public static string Mapping_InvalidContent_ConditionMapping_Either_Members { get { throw null; } }
        public static string Mapping_InvalidContent_ConditionMapping_Either_Values { get { throw null; } }
        public static string Mapping_InvalidContent_ConditionMapping_NonScalar { get { throw null; } }
        public static string Mapping_InvalidContent_Container_SubElement { get { throw null; } }
        public static string Mapping_InvalidContent_General { get { throw null; } }
        public static string Mapping_InvalidContent_IsTypeOfNotTerminated { get { throw null; } }
        public static string Mapping_InvalidContent_Table_Expected { get { throw null; } }
        public static string Mapping_InvalidContent_TypeMapping_QueryView { get { throw null; } }
        public static string Mapping_ModificationFunction_In_Table_Context { get { throw null; } }
        public static string Mapping_ModificationFunction_MissingVersion { get { throw null; } }
        public static string Mapping_ModificationFunction_Multiple_Types { get { throw null; } }
        public static string Mapping_ModificationFunction_VersionMustBeCurrent { get { throw null; } }
        public static string Mapping_ModificationFunction_VersionMustBeOriginal { get { throw null; } }
        public static string Mapping_TypeName_For_First_QueryView { get { throw null; } }
        public static string Materializer_CannotReEnumerateQueryResults { get { throw null; } }
        public static string Materializer_PropertyIsNotNullable { get { throw null; } }
        public static string Materializer_UnsupportedType { get { throw null; } }
        public static string Metadata_General_Error { get { throw null; } }
        public static string MethodInvocationNotSupported { get { throw null; } }
        public static string MismatchNumberOfPropertiesinRelationshipConstraint { get { throw null; } }
        public static string MissingName { get { throw null; } }
        public static string MissingNamespaceAttribute { get { throw null; } }
        public static string MultisetElemsAreNotTypeCompatible { get { throw null; } }
        public static string NonComposableFunctionHasDisallowedAttribute { get { throw null; } }
        public static string NonComposableFunctionMustNotDeclareReturnType { get { throw null; } }
        public static string NotBinaryTypeForTypeUsage { get { throw null; } }
        public static string NotDateTimeOffsetTypeForTypeUsage { get { throw null; } }
        public static string NotDateTimeTypeForTypeUsage { get { throw null; } }
        public static string NotDecimalTypeForTypeUsage { get { throw null; } }
        public static string NotStringTypeForTypeUsage { get { throw null; } }
        public static string NotTimeTypeForTypeUsage { get { throw null; } }
        public static string NotValidInputPath { get { throw null; } }
        public static string NullLiteralCannotBePromotedToCollectionOfNulls { get { throw null; } }
        public static string ObjectContext_CannotAttachEntityWithoutKey { get { throw null; } }
        public static string ObjectContext_CannotAttachEntityWithTemporaryKey { get { throw null; } }
        public static string ObjectContext_CannotDeleteEntityNotInObjectStateManager { get { throw null; } }
        public static string ObjectContext_CannotDetachEntityNotInObjectStateManager { get { throw null; } }
        public static string ObjectContext_CannotSetDefaultContainerName { get { throw null; } }
        public static string ObjectContext_CommitWithConceptualNull { get { throw null; } }
        public static string ObjectContext_ContainerQualifiedEntitySetNameRequired { get { throw null; } }
        public static string ObjectContext_EntityAlreadyExistsInObjectStateManager { get { throw null; } }
        public static string ObjectContext_EntityNotTrackedOrHasTempKey { get { throw null; } }
        public static string ObjectContext_EntitySetNameOrEntityKeyRequired { get { throw null; } }
        public static string ObjectContext_ExecuteCommandWithMixOfDbParameterAndValues { get { throw null; } }
        public static string ObjectContext_InvalidCommandTimeout { get { throw null; } }
        public static string ObjectContext_InvalidConnection { get { throw null; } }
        public static string ObjectContext_InvalidConnectionString { get { throw null; } }
        public static string ObjectContext_InvalidDataAdapter { get { throw null; } }
        public static string ObjectContext_InvalidEntityState { get { throw null; } }
        public static string ObjectContext_InvalidRelationshipState { get { throw null; } }
        public static string ObjectContext_MetadataHasChanged { get { throw null; } }
        public static string ObjectContext_ObjectDisposed { get { throw null; } }
        public static string ObjectContext_ObjectNotFound { get { throw null; } }
        public static string ObjectContext_QualfiedEntitySetName { get { throw null; } }
        public static string ObjectContext_RequiredMetadataNotAvailble { get { throw null; } }
        public static string ObjectContext_SelectorExpressionMustBeMemberAccess { get { throw null; } }
        public static string ObjectContext_StoreEntityNotPresentInClient { get { throw null; } }
        public static string ObjectParameterCollection_ParametersLocked { get { throw null; } }
        public static string ObjectQuery_InvalidConnection { get { throw null; } }
        public static string ObjectQuery_InvalidEmptyQuery { get { throw null; } }
        public static string ObjectQuery_QueryBuilder_InvalidFilterPredicate { get { throw null; } }
        public static string ObjectQuery_QueryBuilder_InvalidGroupKeyList { get { throw null; } }
        public static string ObjectQuery_QueryBuilder_InvalidProjectionList { get { throw null; } }
        public static string ObjectQuery_QueryBuilder_InvalidQueryArgument { get { throw null; } }
        public static string ObjectQuery_QueryBuilder_InvalidSkipCount { get { throw null; } }
        public static string ObjectQuery_QueryBuilder_InvalidSortKeyList { get { throw null; } }
        public static string ObjectQuery_QueryBuilder_InvalidTopCount { get { throw null; } }
        public static string ObjectQuery_QueryBuilder_NotSupportedLinqSource { get { throw null; } }
        public static string ObjectQuery_Span_IncludeRequiresEntityOrEntityCollection { get { throw null; } }
        public static string ObjectQuery_Span_SpanPathSyntaxError { get { throw null; } }
        public static string ObjectQuery_Span_WhiteSpacePath { get { throw null; } }
        public static string ObjectQuery_UnableToMapResultType { get { throw null; } }
        public static string ObjectStateEntry_CannotAccessKeyEntryValues { get { throw null; } }
        public static string ObjectStateEntry_CannotDeleteOnKeyEntry { get { throw null; } }
        public static string ObjectStateEntry_CannotModifyKeyEntryState { get { throw null; } }
        public static string ObjectStateEntry_CantModifyDetachedDeletedEntries { get { throw null; } }
        public static string ObjectStateEntry_CantModifyRelationState { get { throw null; } }
        public static string ObjectStateEntry_CantModifyRelationValues { get { throw null; } }
        public static string ObjectStateEntry_CantSetEntityKey { get { throw null; } }
        public static string ObjectStateEntry_CurrentValuesDoesNotExist { get { throw null; } }
        public static string ObjectStateEntry_EntityMemberChangedWithoutEntityMemberChanging { get { throw null; } }
        public static string ObjectStateEntry_InvalidState { get { throw null; } }
        public static string ObjectStateEntry_InvalidTypeForComplexTypeProperty { get { throw null; } }
        public static string ObjectStateEntry_OriginalValuesDoesNotExist { get { throw null; } }
        public static string ObjectStateEntry_RelationshipAndKeyEntriesDoNotHaveRelationshipManagers { get { throw null; } }
        public static string ObjectStateManager_AcceptChangesEntityKeyIsNotValid { get { throw null; } }
        public static string ObjectStateManager_CannotChangeRelationshipStateEntityAdded { get { throw null; } }
        public static string ObjectStateManager_CannotChangeRelationshipStateEntityDeleted { get { throw null; } }
        public static string ObjectStateManager_CannotChangeRelationshipStateKeyEntry { get { throw null; } }
        public static string ObjectStateManager_CannotFixUpKeyToExistingValues { get { throw null; } }
        public static string ObjectStateManager_CannotGetRelationshipManagerForDetachedPocoEntity { get { throw null; } }
        public static string ObjectStateManager_ChangeRelationshipStateNotSupportedForForeignKeyAssociations { get { throw null; } }
        public static string ObjectStateManager_ChangeStateFromAddedWithNullKeyIsInvalid { get { throw null; } }
        public static string ObjectStateManager_DetachedObjectStateEntriesDoesNotExistInObjectStateManager { get { throw null; } }
        public static string ObjectStateManager_EntityConflictsWithKeyEntry { get { throw null; } }
        public static string ObjectStateManager_EntityNotTracked { get { throw null; } }
        public static string ObjectStateManager_InvalidKey { get { throw null; } }
        public static string ObjectStateManager_KeyPropertyDoesntMatchValueInKey { get { throw null; } }
        public static string ObjectStateManager_KeyPropertyDoesntMatchValueInKeyForAttach { get { throw null; } }
        public static string ObjectStateManager_NoEntryExistForEntityKey { get { throw null; } }
        public static string ObjectStateManager_ObjectStateManagerContainsThisEntityKey { get { throw null; } }
        public static string ObjectView_AddNewOperationNotAllowedOnAbstractBindingList { get { throw null; } }
        public static string ObjectView_CannotReplacetheEntityorRow { get { throw null; } }
        public static string ObjectView_IncompatibleArgument { get { throw null; } }
        public static string ObjectView_IndexBasedInsertIsNotSupported { get { throw null; } }
        public static string ObjectView_WriteOperationNotAllowedOnReadOnlyBindingList { get { throw null; } }
        public static string OnlyStoreConnectionsSupported { get { throw null; } }
        public static string OperationOnReadOnlyCollection { get { throw null; } }
        public static string OperationOnReadOnlyItem { get { throw null; } }
        public static string OrderByKeyIsNotOrderComparable { get { throw null; } }
        public static string PlusLeftExpressionInvalidType { get { throw null; } }
        public static string PlusRightExpressionInvalidType { get { throw null; } }
        public static string ProviderDidNotCreateACommandDefinition { get { throw null; } }
        public static string ProviderDidNotReturnAProviderManifest { get { throw null; } }
        public static string ProviderDidNotReturnAProviderManifestToken { get { throw null; } }
        public static string ProviderDidNotReturnSpatialServices { get { throw null; } }
        public static string ProviderDoesNotSupportCreateDatabase { get { throw null; } }
        public static string ProviderDoesNotSupportCreateDatabaseScript { get { throw null; } }
        public static string ProviderDoesNotSupportDatabaseExists { get { throw null; } }
        public static string ProviderDoesNotSupportDeleteDatabase { get { throw null; } }
        public static string ProviderEscapeLikeArgumentReturnedNull { get { throw null; } }
        public static string ProviderManifestTokenNotFound { get { throw null; } }
        public static string ProviderRequiresStoreCommandTree { get { throw null; } }
        public static string ProviderReturnedNullForCreateCommandDefinition { get { throw null; } }
        public static string ProviderShouldOverrideEscapeLikeArgument { get { throw null; } }
        public static string RelatedEndExprTypeMustBeReference { get { throw null; } }
        public static string RelatedEnd_CannotCreateRelationshipEntitiesInDifferentContexts { get { throw null; } }
        public static string RelatedEnd_ConflictingChangeOfRelationshipDetected { get { throw null; } }
        public static string RelatedEnd_InvalidEntityContextForAttach { get { throw null; } }
        public static string RelatedEnd_InvalidEntityStateForAttach { get { throw null; } }
        public static string RelatedEnd_InvalidOwnerStateForAttach { get { throw null; } }
        public static string RelatedEnd_LoadCalledOnAlreadyLoadedNoTrackedRelatedEnd { get { throw null; } }
        public static string RelatedEnd_LoadCalledOnNonEmptyNoTrackedRelatedEnd { get { throw null; } }
        public static string RelatedEnd_OwnerIsNull { get { throw null; } }
        public static string RelatedEnd_RelatedEndNotFound { get { throw null; } }
        public static string RelatedEnd_UnableToAddEntity { get { throw null; } }
        public static string RelatedEnd_UnableToAddRelationshipWithDeletedEntity { get { throw null; } }
        public static string RelatedEnd_UnableToRemoveEntity { get { throw null; } }
        public static string RelationshipFromEndIsAmbiguos { get { throw null; } }
        public static string RelationshipManager_CannotGetRelatEndForDetachedPocoEntity { get { throw null; } }
        public static string RelationshipManager_CircularRelationshipsWithReferentialConstraints { get { throw null; } }
        public static string RelationshipManager_CollectionInitializeIsForDeserialization { get { throw null; } }
        public static string RelationshipManager_InconsistentReferentialConstraintProperties { get { throw null; } }
        public static string RelationshipManager_InitializeIsForDeserialization { get { throw null; } }
        public static string RelationshipManager_InvalidRelationshipManagerOwner { get { throw null; } }
        public static string RelationshipManager_UnableToRetrieveReferentialConstraintProperties { get { throw null; } }
        public static string RelationshipManager_UnexpectedNull { get { throw null; } }
        public static string RelationshipManager_UnexpectedNullContext { get { throw null; } }
        public static string RelationshipToEndIsAmbiguos { get { throw null; } }
        public static string ResultingExpressionTypeCannotBeNull { get { throw null; } }
        public static string RightSetExpressionArgsMustBeCollection { get { throw null; } }
        public static string RowCtorElementCannotBeNull { get { throw null; } }
        public static string RowTypeWithoutProperty { get { throw null; } }
        public static string SelectDistinctMustBeEqualComparable { get { throw null; } }
        public static string SourceUriUnknown { get { throw null; } }
        public static string SpatialWithUseStrongSpatialTypesFalse { get { throw null; } }
        public static string Spatial_GeographyValueNotCompatibleWithSpatialServices { get { throw null; } }
        public static string Spatial_GeometryValueNotCompatibleWithSpatialServices { get { throw null; } }
        public static string Spatial_ProviderValueNotCompatibleWithSpatialServices { get { throw null; } }
        public static string Spatial_WellKnownGeographyValueNotValid { get { throw null; } }
        public static string Spatial_WellKnownGeometryValueNotValid { get { throw null; } }
        public static string Spatial_WellKnownValueSerializationPropertyNotDirectlySettable { get { throw null; } }
        public static string SqlGen_ApplyNotSupportedOnSql8 { get { throw null; } }
        public static string SqlGen_NiladicFunctionsCannotHaveParameters { get { throw null; } }
        public static string SqlGen_ParameterForLimitNotSupportedOnSql8 { get { throw null; } }
        public static string SqlGen_ParameterForSkipNotSupportedOnSql8 { get { throw null; } }
        public static string SqlProvider_CredentialsMissingForMasterConnection { get { throw null; } }
        public static string SqlProvider_DdlGeneration_CannotDeleteDatabaseNoInitialCatalog { get { throw null; } }
        public static string SqlProvider_DdlGeneration_CannotTellIfDatabaseExists { get { throw null; } }
        public static string SqlProvider_DdlGeneration_MissingInitialCatalog { get { throw null; } }
        public static string SqlProvider_GeographyValueNotSqlCompatible { get { throw null; } }
        public static string SqlProvider_GeometryValueNotSqlCompatible { get { throw null; } }
        public static string SqlProvider_IncompleteCreateDatabase { get { throw null; } }
        public static string SqlProvider_IncompleteCreateDatabaseAggregate { get { throw null; } }
        public static string SqlProvider_Sql2008RequiredForSpatial { get { throw null; } }
        public static string SqlProvider_SqlTypesAssemblyNotFound { get { throw null; } }
        public static string SqlSpatialservices_CouldNotCreateWellKnownGeographyValueNoSrid { get { throw null; } }
        public static string SqlSpatialservices_CouldNotCreateWellKnownGeographyValueNoWkbOrWkt { get { throw null; } }
        public static string SqlSpatialservices_CouldNotCreateWellKnownGeometryValueNoSrid { get { throw null; } }
        public static string SqlSpatialservices_CouldNotCreateWellKnownGeometryValueNoWkbOrWkt { get { throw null; } }
        public static string StackOverflowInParser { get { throw null; } }
        public static string TopAndLimitCannotCoexist { get { throw null; } }
        public static string TopAndSkipCannotCoexist { get { throw null; } }
        public static string TVFReturnTypeRowHasNonScalarProperty { get { throw null; } }
        public static string TypeArgumentIsNotValid { get { throw null; } }
        public static string TypeArgumentMustBeLiteral { get { throw null; } }
        public static string TypeDeclaredAsAttributeAndElement { get { throw null; } }
        public static string TypeMustBeDeclared { get { throw null; } }
        public static string TypeMustBeInheritableType { get { throw null; } }
        public static string UnableToDetermineApplicationContext { get { throw null; } }
        public static string UnableToDetermineStoreVersion { get { throw null; } }
        public static string UnableToLoadResource { get { throw null; } }
        public static string UnknownAstCommandExpression { get { throw null; } }
        public static string UnknownAstExpressionType { get { throw null; } }
        public static string UnknownBuiltInAstExpressionType { get { throw null; } }
        public static string Update_AmbiguousServerGenIdentifier { get { throw null; } }
        public static string Update_CircularRelationships { get { throw null; } }
        public static string Update_ConstraintCycle { get { throw null; } }
        public static string Update_DuplicateKeys { get { throw null; } }
        public static string Update_ErrorLoadingRecord { get { throw null; } }
        public static string Update_GeneralExecutionException { get { throw null; } }
        public static string Update_InvalidChanges { get { throw null; } }
        public static string Update_ReferentialConstraintIntegrityViolation { get { throw null; } }
        public static string Update_WorkspaceMismatch { get { throw null; } }
        public static string Validator_BaseTypeHasMemberOfSameName { get { throw null; } }
        public static string Validator_CollectionHasNoTypeUsage { get { throw null; } }
        public static string Validator_CollectionTypesCannotHaveBaseType { get { throw null; } }
        public static string Validator_EmptyIdentity { get { throw null; } }
        public static string Validator_FacetHasNoName { get { throw null; } }
        public static string Validator_FacetTypeIsNull { get { throw null; } }
        public static string Validator_ItemAttributeHasNullTypeUsage { get { throw null; } }
        public static string Validator_MemberHasNoName { get { throw null; } }
        public static string Validator_MemberHasNullDeclaringType { get { throw null; } }
        public static string Validator_MemberHasNullTypeUsage { get { throw null; } }
        public static string Validator_MetadataPropertyHasNoName { get { throw null; } }
        public static string Validator_OSpace_Convention_NonMatchingUnderlyingTypes { get { throw null; } }
        public static string Validator_RefTypeHasNullEntityType { get { throw null; } }
        public static string Validator_RefTypesCannotHaveBaseType { get { throw null; } }
        public static string Validator_TypeHasNoName { get { throw null; } }
        public static string Validator_TypeHasNoNamespace { get { throw null; } }
        public static string Validator_TypeUsageHasNullEdmType { get { throw null; } }
        public static string ViewGen_AND { get { throw null; } }
        public static string ViewGen_CommaBlank { get { throw null; } }
        public static string ViewGen_Entities { get { throw null; } }
        public static string ViewGen_EntityInstanceToken { get { throw null; } }
        public static string ViewGen_Error { get { throw null; } }
        public static string Viewgen_ErrorPattern_Partition_Disj_Eq { get { throw null; } }
        public static string Viewgen_ErrorPattern_Partition_Disj_Subs { get { throw null; } }
        public static string Viewgen_ErrorPattern_Partition_Disj_Subs_Ref { get { throw null; } }
        public static string Viewgen_ErrorPattern_Partition_Disj_Unk { get { throw null; } }
        public static string Viewgen_ErrorPattern_Partition_Eq_Disj { get { throw null; } }
        public static string Viewgen_ErrorPattern_Partition_Eq_Subs { get { throw null; } }
        public static string Viewgen_ErrorPattern_Partition_Eq_Subs_Ref { get { throw null; } }
        public static string Viewgen_ErrorPattern_Partition_Eq_Unk { get { throw null; } }
        public static string Viewgen_ErrorPattern_Partition_Eq_Unk_Association { get { throw null; } }
        public static string Viewgen_ErrorPattern_Partition_Sub_Disj { get { throw null; } }
        public static string Viewgen_ErrorPattern_Partition_Sub_Eq { get { throw null; } }
        public static string Viewgen_ErrorPattern_Partition_Sub_Eq_Ref { get { throw null; } }
        public static string Viewgen_ErrorPattern_Partition_Sub_Unk { get { throw null; } }
        public static string ViewGen_Extent { get { throw null; } }
        public static string Viewgen_NoJoinKeyOrFK { get { throw null; } }
        public static string ViewGen_NotNull { get { throw null; } }
        public static string ViewGen_Null { get { throw null; } }
        public static string ViewGen_Tuples { get { throw null; } }
        public static string WildcardEnumeratorReturnedNull { get { throw null; } }
        public static string ADP_CollectionParameterElementIsNull(object p0) { throw null; }
        public static string ADP_CollectionParameterElementIsNullOrEmpty(object p0) { throw null; }
        public static string ADP_ConnectionStringSyntax(object p0) { throw null; }
        public static string ADP_DataReaderClosed(object p0) { throw null; }
        public static string ADP_InternalProviderError(object p0) { throw null; }
        public static string ADP_InvalidBufferSizeOrIndex(object p0, object p1) { throw null; }
        public static string ADP_InvalidConnectionOptionValue(object p0) { throw null; }
        public static string ADP_InvalidDataLength(object p0) { throw null; }
        public static string ADP_InvalidDataReaderMissingColumnForType(object p0, object p1) { throw null; }
        public static string ADP_InvalidDataReaderMissingDiscriminatorColumn(object p0, object p1) { throw null; }
        public static string ADP_InvalidDataReaderUnableToMaterializeNonScalarType(object p0, object p1) { throw null; }
        public static string ADP_InvalidDataType(object p0) { throw null; }
        public static string ADP_InvalidDestinationBufferIndex(object p0, object p1) { throw null; }
        public static string ADP_InvalidEnumerationValue(object p0, object p1) { throw null; }
        public static string ADP_InvalidSizeValue(object p0) { throw null; }
        public static string ADP_InvalidSourceBufferIndex(object p0, object p1) { throw null; }
        public static string ADP_KeysRequiredForJoinOverNest(object p0) { throw null; }
        public static string ADP_KeywordNotSupported(object p0) { throw null; }
        public static string ADP_NestingNotSupported(object p0, object p1) { throw null; }
        public static string ADP_NonSequentialChunkAccess(object p0, object p1, object p2) { throw null; }
        public static string ADP_NonSequentialColumnAccess(object p0, object p1) { throw null; }
        public static string ADP_NoQueryMappingView(object p0, object p1) { throw null; }
        public static string ADP_UnknownDataTypeCode(object p0, object p1) { throw null; }
        public static string AliasNameAlreadyUsed(object p0) { throw null; }
        public static string AliasNameIsAlreadyDefined(object p0) { throw null; }
        public static string AllArtifactsMustTargetSameProvider_InvariantName(object p0, object p1) { throw null; }
        public static string AllArtifactsMustTargetSameProvider_ManifestToken(object p0, object p1) { throw null; }
        public static string AmbiguousEntityContainerEnd(object p0, object p1) { throw null; }
        public static string AmbiguousFunctionAndType(object p0, object p1) { throw null; }
        public static string AmbiguousFunctionOverload(object p0, object p1) { throw null; }
        public static string AmbiguousMetadataMemberName(object p0, object p1, object p2) { throw null; }
        public static string ArgumentOutOfRange(object p0) { throw null; }
        public static string ArgumentOutOfRangeExpectedPostiveNumber(object p0) { throw null; }
        public static string ArgumentTypesAreIncompatible(object p0, object p1) { throw null; }
        public static string AssemblyMissingFromAssembliesToConsider(object p0) { throw null; }
        public static string BadNamespaceOrAlias(object p0) { throw null; }
        public static string BadNavigationPropertyBadFromRoleType(object p0, object p1, object p2, object p3, object p4) { throw null; }
        public static string BadNavigationPropertyRelationshipNotRelationship(object p0) { throw null; }
        public static string BadNavigationPropertyUndefinedRole(object p0, object p1) { throw null; }
        public static string BadParameterDirection(object p0, object p1, object p2, object p3) { throw null; }
        public static string BadParameterDirectionForComposableFunctions(object p0, object p1, object p2, object p3) { throw null; }
        public static string BadPrecisionAndScale(object p0, object p1) { throw null; }
        public static string BetweenLimitsTypesAreNotCompatible(object p0, object p1) { throw null; }
        public static string BetweenLimitsTypesAreNotOrderComparable(object p0, object p1) { throw null; }
        public static string BetweenValueIsNotOrderComparable(object p0, object p1) { throw null; }
        public static string BothMinAndMaxValueMustBeSpecifiedForNonConstantFacet(object p0, object p1) { throw null; }
        public static string CannotCallNoncomposableFunction(object p0) { throw null; }
        public static string CannotConvertNumericLiteral(object p0, object p1) { throw null; }
        public static string CannotInstantiateAbstractType(object p0) { throw null; }
        public static string CannotResolveNameToTypeOrFunction(object p0) { throw null; }
        public static string CannotUseSystemNamespaceAsAlias(object p0) { throw null; }
        public static string CheckArgumentContainsNullFailed(object p0) { throw null; }
        public static string CodeGen_ConstructorNoParameterless(object p0) { throw null; }
        public static string Collections_CannotFillTryDifferentMergeOption(object p0, object p1) { throw null; }
        public static string Collections_ExpectedCollectionGotReference(object p0, object p1, object p2) { throw null; }
        public static string Collections_InvalidEntityStateLoad(object p0) { throw null; }
        public static string Collections_NoRelationshipSetMatched(object p0) { throw null; }
        public static string CompiledELinq_UnsupportedNamedParameterType(object p0, object p1) { throw null; }
        public static string CompiledELinq_UnsupportedNamedParameterUseAsType(object p0, object p1) { throw null; }
        public static string CompiledELinq_UnsupportedParameterTypes(object p0) { throw null; }
        public static string ComplexObject_ComplexChangeRequestedOnScalarProperty(object p0) { throw null; }
        public static string ComplexObject_NullableComplexTypesNotSupported(object p0) { throw null; }
        public static string ComplexTypeAsReturnTypeAndDefinedEntitySet(object p0, object p1) { throw null; }
        public static string ComplexTypeAsReturnTypeAndNestedComplexProperty(object p0, object p1, object p2) { throw null; }
        public static string ConcurrencyRedefinedOnSubTypeOfEntitySetType(object p0, object p1, object p2) { throw null; }
        public static string ConstantFacetSpecifiedInSchema(object p0, object p1) { throw null; }
        public static string CouldNotResolveIdentifier(object p0) { throw null; }
        public static string Cqt_Arithmetic_InvalidUnsignedTypeForUnaryMinus(object p0) { throw null; }
        public static string Cqt_Binary_CollectionsRequired(object p0) { throw null; }
        public static string Cqt_Cast_InvalidCast(object p0, object p1) { throw null; }
        public static string Cqt_CommandTree_InvalidParameterName(object p0) { throw null; }
        public static string Cqt_Constant_ClrEnumTypeDoesNotMatchEdmEnumType(object p0, object p1, object p2) { throw null; }
        public static string Cqt_Constant_InvalidConstantType(object p0) { throw null; }
        public static string Cqt_Constant_InvalidValueForType(object p0) { throw null; }
        public static string Cqt_Copier_EndNotFound(object p0, object p1) { throw null; }
        public static string Cqt_Copier_EntityContainerNotFound(object p0) { throw null; }
        public static string Cqt_Copier_EntitySetNotFound(object p0, object p1) { throw null; }
        public static string Cqt_Copier_FunctionNotFound(object p0) { throw null; }
        public static string Cqt_Copier_NavPropertyNotFound(object p0, object p1) { throw null; }
        public static string Cqt_Copier_PropertyNotFound(object p0, object p1) { throw null; }
        public static string Cqt_Copier_TypeNotFound(object p0) { throw null; }
        public static string Cqt_CrossJoin_DuplicateVariableNames(object p0, object p1, object p2) { throw null; }
        public static string Cqt_ExpressionLink_TypeMismatch(object p0, object p1) { throw null; }
        public static string Cqt_Factory_MethodResultTypeNotSupported(object p0) { throw null; }
        public static string Cqt_Factory_NoSuchProperty(object p0, object p1) { throw null; }
        public static string Cqt_Function_CanonicalFunction_AmbiguousMatch(object p0) { throw null; }
        public static string Cqt_Function_CanonicalFunction_NotFound(object p0) { throw null; }
        public static string Cqt_General_PolymorphicArgRequired(object p0) { throw null; }
        public static string Cqt_General_PolymorphicTypeRequired(object p0) { throw null; }
        public static string Cqt_General_UnsupportedExpression(object p0) { throw null; }
        public static string Cqt_GroupBy_AggregateColumnExistsAsGroupColumn(object p0) { throw null; }
        public static string Cqt_GroupBy_KeyNotEqualityComparable(object p0) { throw null; }
        public static string Cqt_InvalidTypeForSetOperation(object p0, object p1) { throw null; }
        public static string Cqt_NewInstance_CannotInstantiateAbstractType(object p0) { throw null; }
        public static string Cqt_NewInstance_CannotInstantiateMemberlessType(object p0) { throw null; }
        public static string Cqt_RelNav_WrongSourceType(object p0) { throw null; }
        public static string Cqt_UDF_FunctionDefinitionGenerationFailed(object p0) { throw null; }
        public static string Cqt_UDF_FunctionDefinitionResultTypeMismatch(object p0, object p1, object p2) { throw null; }
        public static string Cqt_UDF_FunctionDefinitionWithCircularReference(object p0) { throw null; }
        public static string Cqt_UDF_FunctionHasNoDefinition(object p0) { throw null; }
        public static string Cqt_Unary_CollectionRequired(object p0) { throw null; }
        public static string Cqt_Util_CheckListDuplicateName(object p0, object p1, object p2) { throw null; }
        public static string Cqt_Validator_InvalidIncompatibleParameterReferences(object p0) { throw null; }
        public static string Cqt_Validator_InvalidIncorrectDataSpaceMetadata(object p0, object p1) { throw null; }
        public static string Cqt_Validator_InvalidOtherWorkspaceMetadata(object p0) { throw null; }
        public static string Cqt_Validator_VarRefInvalid(object p0) { throw null; }
        public static string Cqt_Validator_VarRefTypeMismatch(object p0) { throw null; }
        public static string CreateRefTypeIdentifierMustBeASubOrSuperType(object p0, object p1) { throw null; }
        public static string CreateRefTypeIdentifierMustSpecifyAnEntityType(object p0, object p1) { throw null; }
        public static string CtxFunction(object p0) { throw null; }
        public static string CtxTypeCtor(object p0) { throw null; }
        public static string CycleInTypeHierarchy(object p0) { throw null; }
        public static string DeRefArgIsNotOfRefType(object p0) { throw null; }
        public static string DifferentSchemaVersionInCollection(object p0, object p1, object p2) { throw null; }
        public static string DuplicateAnnotation(object p0, object p1) { throw null; }
        public static string DuplicatedFunctionoverloads(object p0, object p1) { throw null; }
        public static string DuplicatedInlineFunctionOverload(object p0) { throw null; }
        public static string DuplicateEndName(object p0) { throw null; }
        public static string DuplicateEntityContainerMemberName(object p0) { throw null; }
        public static string DuplicateEntitySetTable(object p0, object p1, object p2) { throw null; }
        public static string DuplicateMemberName(object p0, object p1, object p2) { throw null; }
        public static string DuplicateMemberNameInExtendedEntityContainer(object p0, object p1, object p2) { throw null; }
        public static string DuplicatePropertyNameSpecifiedInEntityKey(object p0, object p1) { throw null; }
        public static string DuplicationOperation(object p0) { throw null; }
        public static string EdmVersionNotSupportedByRuntime(object p0, object p1) { throw null; }
        public static string ELinq_EdmFunctionAttributedFunctionWithWrongReturnType(object p0, object p1) { throw null; }
        public static string ELinq_EdmFunctionAttributeParameterNameNotValid(object p0, object p1, object p2) { throw null; }
        public static string ELinq_InvalidOfTypeResult(object p0) { throw null; }
        public static string ELinq_NotPropertyOrField(object p0) { throw null; }
        public static string ELinq_UnboundParameterExpression(object p0) { throw null; }
        public static string ELinq_UnexpectedTypeForNavigationProperty(object p0, object p1, object p2, object p3) { throw null; }
        public static string ELinq_UnhandledBindingType(object p0) { throw null; }
        public static string ELinq_UnhandledExpressionType(object p0) { throw null; }
        public static string ELinq_UnrecognizedMember(object p0) { throw null; }
        public static string ELinq_UnresolvableFunctionForExpression(object p0) { throw null; }
        public static string ELinq_UnresolvableFunctionForMember(object p0, object p1) { throw null; }
        public static string ELinq_UnresolvableFunctionForMethod(object p0, object p1) { throw null; }
        public static string ELinq_UnresolvableFunctionForMethodAmbiguousMatch(object p0, object p1) { throw null; }
        public static string ELinq_UnresolvableFunctionForMethodNotFound(object p0, object p1) { throw null; }
        public static string ELinq_UnresolvableStoreFunctionForExpression(object p0) { throw null; }
        public static string ELinq_UnresolvableStoreFunctionForMember(object p0, object p1) { throw null; }
        public static string ELinq_UnsupportedAsUnicodeAndAsNonUnicode(object p0) { throw null; }
        public static string ELinq_UnsupportedCast(object p0, object p1) { throw null; }
        public static string ELinq_UnsupportedComparison(object p0) { throw null; }
        public static string ELinq_UnsupportedConstant(object p0) { throw null; }
        public static string ELinq_UnsupportedEnumerableType(object p0) { throw null; }
        public static string ELinq_UnsupportedExpressionType(object p0) { throw null; }
        public static string ELinq_UnsupportedHeterogeneousInitializers(object p0) { throw null; }
        public static string ELinq_UnsupportedIsOrAs(object p0, object p1, object p2) { throw null; }
        public static string ELinq_UnsupportedKeySelector(object p0) { throw null; }
        public static string ELinq_UnsupportedMethod(object p0) { throw null; }
        public static string ELinq_UnsupportedMethodSuggestedAlternative(object p0, object p1) { throw null; }
        public static string ELinq_UnsupportedNominalType(object p0) { throw null; }
        public static string ELinq_UnsupportedNullConstant(object p0) { throw null; }
        public static string ELinq_UnsupportedPassthrough(object p0, object p1) { throw null; }
        public static string ELinq_UnsupportedRefComparison(object p0, object p1) { throw null; }
        public static string ELinq_UnsupportedRowComparison(object p0) { throw null; }
        public static string ELinq_UnsupportedRowMemberComparison(object p0) { throw null; }
        public static string ELinq_UnsupportedRowTypeComparison(object p0) { throw null; }
        public static string ELinq_UnsupportedStringRemoveCase(object p0, object p1) { throw null; }
        public static string ELinq_UnsupportedTrimStartTrimEndCase(object p0) { throw null; }
        public static string ELinq_UnsupportedType(object p0) { throw null; }
        public static string ELinq_UnsupportedUseOfContextParameter(object p0) { throw null; }
        public static string ELinq_UnsupportedVBDatePartInvalidInterval(object p0, object p1, object p2) { throw null; }
        public static string ELinq_UnsupportedVBDatePartNonConstantInterval(object p0, object p1) { throw null; }
        public static string EmptyFile(object p0) { throw null; }
        public static string EmptyName(object p0) { throw null; }
        public static string EndNameAlreadyDefinedDuplicate(object p0) { throw null; }
        public static string EndWithManyMultiplicityCannotHaveOperationsSpecified(object p0, object p1) { throw null; }
        public static string EndWithoutMultiplicity(object p0, object p1) { throw null; }
        public static string EntityClient_ConnectionStringMissingInfo(object p0) { throw null; }
        public static string EntityClient_DbConnectionHasNoProvider(object p0) { throw null; }
        public static string EntityClient_DoesNotImplementIServiceProvider(object p0) { throw null; }
        public static string EntityClient_DuplicateParameterNames(object p0) { throw null; }
        public static string EntityClient_EntityParameterEdmTypeNotScalar(object p0) { throw null; }
        public static string EntityClient_EntityParameterInconsistentEdmType(object p0, object p1) { throw null; }
        public static string EntityClient_ExecutingOnClosedConnection(object p0) { throw null; }
        public static string EntityClient_FailedToGetInformation(object p0) { throw null; }
        public static string EntityClient_FunctionImportMustBeNonComposable(object p0) { throw null; }
        public static string EntityClient_IncompatibleNavigationPropertyResult(object p0, object p1) { throw null; }
        public static string EntityClient_InvalidParameterDirection(object p0) { throw null; }
        public static string EntityClient_InvalidParameterName(object p0) { throw null; }
        public static string EntityClient_ItemCollectionsNotRegisteredInWorkspace(object p0) { throw null; }
        public static string EntityClient_KeywordNotSupported(object p0) { throw null; }
        public static string EntityClient_NestedNamedConnection(object p0) { throw null; }
        public static string EntityClient_ProviderSpecificError(object p0) { throw null; }
        public static string EntityClient_ReturnedNullOnProviderMethod(object p0, object p1) { throw null; }
        public static string EntityClient_UnableToFindFunctionImport(object p0, object p1) { throw null; }
        public static string EntityClient_UnableToFindFunctionImportContainer(object p0) { throw null; }
        public static string EntityClient_UnknownParameterType(object p0) { throw null; }
        public static string EntityClient_UnmappedFunctionImport(object p0) { throw null; }
        public static string EntityClient_UnsupportedDbType(object p0, object p1) { throw null; }
        public static string EntityContainerAlreadyExists(object p0) { throw null; }
        public static string EntityContainerCannotExtendItself(object p0) { throw null; }
        public static string EntityKeyMustBeScalar(object p0, object p1) { throw null; }
        public static string EntityKeyTypeCurrentlyNotSupported(object p0, object p1, object p2) { throw null; }
        public static string EntityKeyTypeCurrentlyNotSupportedInSSDL(object p0, object p1, object p2, object p3, object p4) { throw null; }
        public static string EntityKey_DoesntMatchKeyOnEntity(object p0) { throw null; }
        public static string EntityKey_EntitySetDoesNotMatch(object p0) { throw null; }
        public static string EntityKey_EntityTypesDoNotMatch(object p0, object p1) { throw null; }
        public static string EntityKey_IncorrectNumberOfKeyValuePairs(object p0, object p1, object p2) { throw null; }
        public static string EntityKey_IncorrectValueType(object p0, object p1, object p2) { throw null; }
        public static string EntityKey_InvalidName(object p0) { throw null; }
        public static string EntityKey_MissingKeyValue(object p0, object p1) { throw null; }
        public static string EntityKey_NoCorrespondingOSpaceTypeForEnumKeyMember(object p0, object p1) { throw null; }
        public static string EntityKey_NullKeyValue(object p0, object p1) { throw null; }
        public static string EntityParameterCollectionInvalidIndex(object p0, object p1) { throw null; }
        public static string EntityParameterCollectionInvalidParameterName(object p0) { throw null; }
        public static string EntityProxyTypeInfo_CannotSetEntityCollectionProperty(object p0, object p1) { throw null; }
        public static string EntityProxyTypeInfo_DuplicateOSpaceType(object p0) { throw null; }
        public static string EntityProxyTypeInfo_ProxyMetadataIsUnavailable(object p0) { throw null; }
        public static string EntityReference_CannotAddMoreThanOneEntityToEntityReference(object p0, object p1) { throw null; }
        public static string EntityReference_ExpectedReferenceGotCollection(object p0, object p1, object p2) { throw null; }
        public static string EntitySetNotInCSPace(object p0) { throw null; }
        public static string EntitySetTypeHasNoKeys(object p0, object p1) { throw null; }
        public static string EnumMemberValueOutOfItsUnderylingTypeRange(object p0, object p1, object p2) { throw null; }
        public static string ExpressionTypeMustBeEntityType(object p0, object p1, object p2) { throw null; }
        public static string ExpressionTypeMustBeNominalType(object p0, object p1, object p2) { throw null; }
        public static string FacetNotAllowed(object p0, object p1) { throw null; }
        public static string FacetsOnNonScalarType(object p0) { throw null; }
        public static string FailedToFindClrTypeMapping(object p0) { throw null; }
        public static string FailedToFindCSpaceTypeMapping(object p0) { throw null; }
        public static string FailedToFindOSpaceTypeMapping(object p0) { throw null; }
        public static string FailedToResolveAggregateFunction(object p0) { throw null; }
        public static string FunctionImportCollectionAndRefParametersNotAllowed(object p0) { throw null; }
        public static string FunctionImportComposableAndSideEffectingNotAllowed(object p0) { throw null; }
        public static string FunctionImportEntitySetAndEntitySetPathDeclared(object p0) { throw null; }
        public static string FunctionImportEntityTypeDoesNotMatchEntitySet(object p0, object p1, object p2) { throw null; }
        public static string FunctionImportNonNullableParametersNotAllowed(object p0) { throw null; }
        public static string FunctionImportReturnEntitiesButDoesNotSpecifyEntitySet(object p0) { throw null; }
        public static string FunctionImportSpecifiesEntitySetButNotEntityType(object p0) { throw null; }
        public static string FunctionImportUnknownEntitySet(object p0, object p1) { throw null; }
        public static string FunctionImportWithUnsupportedReturnTypeV1(object p0) { throw null; }
        public static string FunctionImportWithUnsupportedReturnTypeV1_1(object p0) { throw null; }
        public static string FunctionImportWithUnsupportedReturnTypeV2(object p0) { throw null; }
        public static string FunctionWithNonEdmPrimitiveTypeNotSupported(object p0, object p1) { throw null; }
        public static string FunctionWithNonPrimitiveTypeNotSupported(object p0, object p1) { throw null; }
        public static string GeneralExceptionAsQueryInnerException(object p0) { throw null; }
        public static string Generated_Views_Invalid_Extent(object p0) { throw null; }
        public static string Generated_View_Type_Super_Class(object p0) { throw null; }
        public static string GenericTypeNotSupported(object p0) { throw null; }
        public static string InferRelationshipEndAmbiguous(object p0, object p1, object p2, object p3, object p4) { throw null; }
        public static string InferRelationshipEndFailedNoEntitySetMatch(object p0, object p1, object p2, object p3, object p4) { throw null; }
        public static string InferRelationshipEndGivesAlreadyDefinedEnd(object p0, object p1) { throw null; }
        public static string InvalidAction(object p0, object p1) { throw null; }
        public static string InvalidAliasName(object p0) { throw null; }
        public static string InvalidAssociationTypeForUnion(object p0) { throw null; }
        public static string InvalidBaseTypeForItemType(object p0, object p1) { throw null; }
        public static string InvalidBaseTypeForNestedType(object p0, object p1) { throw null; }
        public static string InvalidBaseTypeForStructuredType(object p0, object p1) { throw null; }
        public static string InvalidCast(object p0, object p1) { throw null; }
        public static string InvalidCollectionForMapping(object p0) { throw null; }
        public static string InvalidCollectionSpecified(object p0) { throw null; }
        public static string InvalidComplexType(object p0, object p1, object p2, object p3) { throw null; }
        public static string InvalidCtorArgumentType(object p0, object p1, object p2) { throw null; }
        public static string InvalidCtorUseOnType(object p0) { throw null; }
        public static string InvalidDateTimeOffsetLiteral(object p0) { throw null; }
        public static string InvalidDay(object p0, object p1) { throw null; }
        public static string InvalidDayInMonth(object p0, object p1, object p2) { throw null; }
        public static string InvalidDefaultBinaryWithNoMaxLength(object p0) { throw null; }
        public static string InvalidDefaultBoolean(object p0) { throw null; }
        public static string InvalidDefaultDateTime(object p0, object p1) { throw null; }
        public static string InvalidDefaultDateTimeOffset(object p0, object p1) { throw null; }
        public static string InvalidDefaultDecimal(object p0, object p1, object p2) { throw null; }
        public static string InvalidDefaultFloatingPoint(object p0, object p1, object p2) { throw null; }
        public static string InvalidDefaultGuid(object p0) { throw null; }
        public static string InvalidDefaultIntegral(object p0, object p1, object p2) { throw null; }
        public static string InvalidDefaultTime(object p0, object p1) { throw null; }
        public static string InvalidDeRefProperty(object p0, object p1, object p2) { throw null; }
        public static string InvalidEDMVersion(object p0) { throw null; }
        public static string InvalidEndEntitySetTypeMismatch(object p0) { throw null; }
        public static string InvalidEndRoleInRelationshipConstraint(object p0, object p1) { throw null; }
        public static string InvalidEntityContainerNameInExtends(object p0) { throw null; }
        public static string InvalidEntityEndName(object p0, object p1) { throw null; }
        public static string InvalidEntityParameterType(object p0) { throw null; }
        public static string InvalidEntityRootTypeArgument(object p0, object p1) { throw null; }
        public static string InvalidEntitySetName(object p0) { throw null; }
        public static string InvalidEntitySetNameReference(object p0, object p1) { throw null; }
        public static string InvalidEntitySetType(object p0) { throw null; }
        public static string InvalidEntityTypeArgument(object p0, object p1, object p2, object p3) { throw null; }
        public static string InvalidEscapedIdentifier(object p0) { throw null; }
        public static string InvalidEscapedIdentifierUnbalanced(object p0) { throw null; }
        public static string InvalidExpressionResolutionClass(object p0, object p1) { throw null; }
        public static string InvalidFileExtension(object p0, object p1, object p2) { throw null; }
        public static string InvalidFromPropertyInRelationshipConstraint(object p0, object p1, object p2) { throw null; }
        public static string InvalidGroupIdentifierReference(object p0) { throw null; }
        public static string InvalidHour(object p0, object p1) { throw null; }
        public static string InvalidImplicitRelationshipFromEnd(object p0) { throw null; }
        public static string InvalidImplicitRelationshipToEnd(object p0) { throw null; }
        public static string InvalidInExprArgs(object p0, object p1) { throw null; }
        public static string InvalidKeyArgument(object p0) { throw null; }
        public static string InvalidKeyKeyDefinedInBaseClass(object p0, object p1) { throw null; }
        public static string InvalidKeyMember(object p0) { throw null; }
        public static string InvalidKeyNoProperty(object p0, object p1) { throw null; }
        public static string InvalidKeyNullablePart(object p0, object p1) { throw null; }
        public static string InvalidKeyTypeForCollation(object p0) { throw null; }
        public static string InvalidLiteralFormat(object p0, object p1) { throw null; }
        public static string InvalidMemberNameMatchesTypeName(object p0, object p1) { throw null; }
        public static string InvalidMetadataMemberClassResolution(object p0, object p1, object p2) { throw null; }
        public static string InvalidMinute(object p0, object p1) { throw null; }
        public static string InvalidMonth(object p0, object p1) { throw null; }
        public static string InvalidMultiplicityFromRoleToPropertyNonNullableV1(object p0, object p1) { throw null; }
        public static string InvalidMultiplicityFromRoleToPropertyNonNullableV2(object p0, object p1) { throw null; }
        public static string InvalidMultiplicityFromRoleToPropertyNullableV1(object p0, object p1) { throw null; }
        public static string InvalidMultiplicityFromRoleUpperBoundMustBeOne(object p0, object p1) { throw null; }
        public static string InvalidMultiplicityToRoleLowerBoundMustBeZero(object p0, object p1) { throw null; }
        public static string InvalidMultiplicityToRoleUpperBoundMustBeMany(object p0, object p1) { throw null; }
        public static string InvalidMultiplicityToRoleUpperBoundMustBeOne(object p0, object p1) { throw null; }
        public static string InvalidName(object p0, object p1) { throw null; }
        public static string InvalidNamespaceInUsing(object p0) { throw null; }
        public static string InvalidNamespaceOrAliasSpecified(object p0) { throw null; }
        public static string InvalidNullLiteralForNonNullableMember(object p0, object p1) { throw null; }
        public static string InvalidNumberOfParametersForAggregateFunction(object p0) { throw null; }
        public static string InvalidParameterFormat(object p0) { throw null; }
        public static string InvalidParameterTypeForAggregateFunction(object p0, object p1) { throw null; }
        public static string InvalidPlaceholderRootTypeArgument(object p0, object p1, object p2, object p3) { throw null; }
        public static string InvalidPlaceholderTypeArgument(object p0, object p1, object p2, object p3, object p4, object p5) { throw null; }
        public static string InvalidPrimitiveTypeKind(object p0) { throw null; }
        public static string InvalidPropertyInRelationshipConstraint(object p0, object p1) { throw null; }
        public static string InvalidPropertyType(object p0) { throw null; }
        public static string InvalidQueryResultType(object p0) { throw null; }
        public static string InvalidRelationshipEndMultiplicity(object p0, object p1) { throw null; }
        public static string InvalidRelationshipEndType(object p0, object p1) { throw null; }
        public static string InvalidRelationshipMember(object p0, object p1) { throw null; }
        public static string InvalidRelationshipSetName(object p0) { throw null; }
        public static string InvalidRelationshipSetType(object p0) { throw null; }
        public static string InvalidRootComplexType(object p0, object p1) { throw null; }
        public static string InvalidRootRowType(object p0, object p1) { throw null; }
        public static string InvalidRowType(object p0, object p1, object p2, object p3) { throw null; }
        public static string InvalidSchemaEncountered(object p0) { throw null; }
        public static string InvalidSecond(object p0, object p1) { throw null; }
        public static string InvalidSimpleIdentifier(object p0) { throw null; }
        public static string InvalidSimpleIdentifierNonASCII(object p0) { throw null; }
        public static string InvalidSize(object p0, object p1, object p2, object p3) { throw null; }
        public static string InvalidStringArgument(object p0) { throw null; }
        public static string InvalidSystemReferenceId(object p0, object p1, object p2, object p3) { throw null; }
        public static string InvalidToPropertyInRelationshipConstraint(object p0, object p1, object p2) { throw null; }
        public static string InvalidUnarySetOpArgument(object p0) { throw null; }
        public static string InvalidUnsignedTypeForUnaryMinusOperation(object p0) { throw null; }
        public static string InvalidUseOfWebPath(object p0) { throw null; }
        public static string InvalidValueForParameterTypeSemanticsAttribute(object p0) { throw null; }
        public static string InvalidWithRelationshipTargetEndMultiplicity(object p0, object p1) { throw null; }
        public static string InvalidYear(object p0, object p1) { throw null; }
        public static string Iqt_General_UnsupportedOp(object p0) { throw null; }
        public static string ItemCollectionAlreadyRegistered(object p0) { throw null; }
        public static string ItemDuplicateIdentity(object p0) { throw null; }
        public static string ItemInvalidIdentity(object p0) { throw null; }
        public static string KeyMissingOnEntityType(object p0) { throw null; }
        public static string KeyMustBeCorrelated(object p0) { throw null; }
        public static string LiteralTypeNotFoundInMetadata(object p0) { throw null; }
        public static string LiteralTypeNotSupported(object p0) { throw null; }
        public static string MalformedXml(object p0, object p1) { throw null; }
        public static string Mapping_AbstractTypeMappingToNonAbstractType(object p0, object p1) { throw null; }
        public static string Mapping_AllQueryViewAtCompileTime(object p0) { throw null; }
        public static string Mapping_AlreadyMapped_StorageEntityContainer(object p0) { throw null; }
        public static string Mapping_CannotMapCLRTypeMultipleTimes(object p0) { throw null; }
        public static string Mapping_Default_OCMapping_Clr_Member(object p0, object p1, object p2) { throw null; }
        public static string Mapping_Default_OCMapping_Clr_Member2(object p0, object p1, object p2) { throw null; }
        public static string Mapping_Default_OCMapping_Invalid_MemberType(object p0, object p1, object p2, object p3, object p4, object p5) { throw null; }
        public static string Mapping_Default_OCMapping_MemberKind_Mismatch(object p0, object p1, object p2, object p3, object p4, object p5) { throw null; }
        public static string Mapping_Default_OCMapping_Member_Count_Mismatch(object p0, object p1) { throw null; }
        public static string Mapping_Default_OCMapping_MultiplicityMismatch(object p0, object p1, object p2, object p3, object p4, object p5) { throw null; }
        public static string Mapping_Duplicate_CdmAssociationSet_StorageMap(object p0) { throw null; }
        public static string Mapping_Duplicate_PropertyMap_CaseInsensitive(object p0) { throw null; }
        public static string Mapping_Duplicate_Type(object p0) { throw null; }
        public static string Mapping_Empty_QueryView(object p0) { throw null; }
        public static string Mapping_Empty_QueryView_OfType(object p0, object p1) { throw null; }
        public static string Mapping_Empty_QueryView_OfTypeOnly(object p0, object p1) { throw null; }
        public static string Mapping_EntitySetMismatchOnAssociationSetEnd_QueryView(object p0, object p1, object p2, object p3) { throw null; }
        public static string Mapping_EnumTypeMappingToNonEnumType(object p0, object p1) { throw null; }
        public static string Mapping_Enum_EmptyValue(object p0) { throw null; }
        public static string Mapping_Enum_InvalidValue(object p0) { throw null; }
        public static string Mapping_Enum_OCMapping_MemberMismatch(object p0, object p1, object p2, object p3) { throw null; }
        public static string Mapping_Enum_OCMapping_UnderlyingTypesMismatch(object p0, object p1, object p2, object p3) { throw null; }
        public static string Mapping_FunctionImport_CannotInferTargetFunctionKeys(object p0) { throw null; }
        public static string Mapping_FunctionImport_ConditionValueTypeMismatch(object p0, object p1, object p2) { throw null; }
        public static string Mapping_FunctionImport_EntityTypeMappingForFunctionNotReturningEntitySet(object p0, object p1) { throw null; }
        public static string Mapping_FunctionImport_FunctionAmbiguous(object p0) { throw null; }
        public static string Mapping_FunctionImport_FunctionImportDoesNotExist(object p0, object p1) { throw null; }
        public static string Mapping_FunctionImport_FunctionImportMappedMultipleTimes(object p0) { throw null; }
        public static string Mapping_FunctionImport_ImplicitMappingForAbstractReturnType(object p0, object p1) { throw null; }
        public static string Mapping_FunctionImport_ImportParameterHasNoCorrespondingTargetParameter(object p0) { throw null; }
        public static string Mapping_FunctionImport_IncompatibleEnumParameterType(object p0, object p1, object p2, object p3) { throw null; }
        public static string Mapping_FunctionImport_IncompatibleParameterMode(object p0, object p1, object p2) { throw null; }
        public static string Mapping_FunctionImport_IncompatibleParameterType(object p0, object p1, object p2) { throw null; }
        public static string Mapping_FunctionImport_InvalidContentEntityTypeForEntitySet(object p0, object p1, object p2, object p3) { throw null; }
        public static string Mapping_FunctionImport_PropertyNotMapped(object p0, object p1, object p2) { throw null; }
        public static string Mapping_FunctionImport_ResultMappingCountDoesNotMatchResultCount(object p0) { throw null; }
        public static string Mapping_FunctionImport_ResultMapping_InvalidCTypeCTExpected(object p0) { throw null; }
        public static string Mapping_FunctionImport_ResultMapping_InvalidCTypeETExpected(object p0) { throw null; }
        public static string Mapping_FunctionImport_ResultMapping_InvalidSType(object p0) { throw null; }
        public static string Mapping_FunctionImport_ResultMapping_MappedTypeDoesNotMatchReturnType(object p0, object p1) { throw null; }
        public static string Mapping_FunctionImport_RowsAffectedParameterDoesNotExist(object p0, object p1) { throw null; }
        public static string Mapping_FunctionImport_RowsAffectedParameterHasWrongMode(object p0, object p1, object p2, object p3) { throw null; }
        public static string Mapping_FunctionImport_RowsAffectedParameterHasWrongType(object p0, object p1) { throw null; }
        public static string Mapping_FunctionImport_ScalarMappingToMulticolumnTVF(object p0, object p1) { throw null; }
        public static string Mapping_FunctionImport_ScalarMappingTypeMismatch(object p0, object p1, object p2, object p3) { throw null; }
        public static string Mapping_FunctionImport_StoreFunctionDoesNotExist(object p0) { throw null; }
        public static string Mapping_FunctionImport_TargetFunctionMustBeComposable(object p0, object p1) { throw null; }
        public static string Mapping_FunctionImport_TargetFunctionMustBeNonComposable(object p0, object p1) { throw null; }
        public static string Mapping_FunctionImport_TargetParameterHasNoCorrespondingImportParameter(object p0) { throw null; }
        public static string Mapping_FunctionImport_UnreachableIsTypeOf(object p0, object p1) { throw null; }
        public static string Mapping_FunctionImport_UnreachableType(object p0, object p1) { throw null; }
        public static string Mapping_FunctionImport_UnsupportedType(object p0, object p1) { throw null; }
        public static string Mapping_InvalidContent_AbstractEntity_FunctionMapping(object p0) { throw null; }
        public static string Mapping_InvalidContent_AbstractEntity_IsOfType(object p0) { throw null; }
        public static string Mapping_InvalidContent_AbstractEntity_Type(object p0) { throw null; }
        public static string Mapping_InvalidContent_AssociationSet_Condition(object p0) { throw null; }
        public static string Mapping_InvalidContent_Association_Set(object p0) { throw null; }
        public static string Mapping_InvalidContent_Association_Type(object p0) { throw null; }
        public static string Mapping_InvalidContent_Cdm_Member(object p0) { throw null; }
        public static string Mapping_InvalidContent_Column(object p0) { throw null; }
        public static string Mapping_InvalidContent_Complex_Type(object p0) { throw null; }
        public static string Mapping_InvalidContent_ConditionMapping_Computed(object p0) { throw null; }
        public static string Mapping_InvalidContent_ConditionMapping_InvalidMember(object p0) { throw null; }
        public static string Mapping_InvalidContent_ConditionMapping_InvalidPrimitiveTypeKind(object p0, object p1) { throw null; }
        public static string Mapping_InvalidContent_Duplicate_Cdm_Member(object p0) { throw null; }
        public static string Mapping_InvalidContent_Duplicate_Condition_Member(object p0) { throw null; }
        public static string Mapping_InvalidContent_Emtpty_SetMap(object p0) { throw null; }
        public static string Mapping_InvalidContent_End(object p0) { throw null; }
        public static string Mapping_InvalidContent_EndProperty(object p0) { throw null; }
        public static string Mapping_InvalidContent_EntityContainer(object p0) { throw null; }
        public static string Mapping_InvalidContent_Entity_Set(object p0) { throw null; }
        public static string Mapping_InvalidContent_Entity_Type(object p0) { throw null; }
        public static string Mapping_InvalidContent_Entity_Type_For_Entity_Set(object p0, object p1, object p2) { throw null; }
        public static string Mapping_InvalidContent_ForeignKey_Association_Set(object p0) { throw null; }
        public static string Mapping_InvalidContent_ForeignKey_Association_Set_PKtoPK(object p0) { throw null; }
        public static string Mapping_InvalidContent_StorageEntityContainer(object p0) { throw null; }
        public static string Mapping_InvalidContent_Table(object p0) { throw null; }
        public static string Mapping_InvalidMappingSchema_Parsing(object p0) { throw null; }
        public static string Mapping_InvalidMappingSchema_validation(object p0) { throw null; }
        public static string Mapping_Invalid_Association_Type_For_Association_Set(object p0, object p1, object p2) { throw null; }
        public static string Mapping_Invalid_CSide_ScalarProperty(object p0) { throw null; }
        public static string Mapping_Invalid_CSRootElementMissing(object p0, object p1, object p2) { throw null; }
        public static string Mapping_Invalid_Member_Mapping(object p0, object p1, object p2, object p3, object p4, object p5) { throw null; }
        public static string Mapping_Invalid_QueryView(object p0, object p1) { throw null; }
        public static string Mapping_Invalid_QueryView2(object p0, object p1) { throw null; }
        public static string Mapping_Invalid_QueryView_Type(object p0) { throw null; }
        public static string Mapping_Invalid_Query_Views_MissingSetClosure(object p0) { throw null; }
        public static string Mapping_ItemWithSameNameExistsBothInCSpaceAndSSpace(object p0) { throw null; }
        public static string Mapping_ModificationFunction_AmbiguousFunction(object p0) { throw null; }
        public static string Mapping_ModificationFunction_AmbiguousResultBinding(object p0, object p1) { throw null; }
        public static string Mapping_ModificationFunction_AssociationEndMappingForeignKeyAssociation(object p0) { throw null; }
        public static string Mapping_ModificationFunction_AssociationEndMappingInvalidForEntityType(object p0, object p1, object p2) { throw null; }
        public static string Mapping_ModificationFunction_AssociationSetAmbiguous(object p0) { throw null; }
        public static string Mapping_ModificationFunction_AssociationSetCardinality(object p0) { throw null; }
        public static string Mapping_ModificationFunction_AssociationSetDoesNotExist(object p0) { throw null; }
        public static string Mapping_ModificationFunction_AssociationSetFromRoleIsNotEntitySet(object p0) { throw null; }
        public static string Mapping_ModificationFunction_AssociationSetNotMappedForOperation(object p0, object p1, object p2, object p3) { throw null; }
        public static string Mapping_ModificationFunction_AssociationSetRoleDoesNotExist(object p0) { throw null; }
        public static string Mapping_ModificationFunction_ComplexTypeNotFound(object p0) { throw null; }
        public static string Mapping_ModificationFunction_MissingEntityType(object p0) { throw null; }
        public static string Mapping_ModificationFunction_MissingParameter(object p0, object p1) { throw null; }
        public static string Mapping_ModificationFunction_MissingSetClosure(object p0) { throw null; }
        public static string Mapping_ModificationFunction_MultipleEndsOfAssociationMapped(object p0, object p1, object p2) { throw null; }
        public static string Mapping_ModificationFunction_NotValidFunction(object p0) { throw null; }
        public static string Mapping_ModificationFunction_NotValidFunctionParameter(object p0, object p1, object p2) { throw null; }
        public static string Mapping_ModificationFunction_ParameterBoundTwice(object p0) { throw null; }
        public static string Mapping_ModificationFunction_ParameterNotFound(object p0, object p1) { throw null; }
        public static string Mapping_ModificationFunction_PropertyNotFound(object p0, object p1) { throw null; }
        public static string Mapping_ModificationFunction_PropertyNotKey(object p0, object p1) { throw null; }
        public static string Mapping_ModificationFunction_PropertyParameterTypeMismatch(object p0, object p1, object p2, object p3, object p4, object p5) { throw null; }
        public static string Mapping_ModificationFunction_RedundantEntityTypeMapping(object p0) { throw null; }
        public static string Mapping_ModificationFunction_UnknownFunction(object p0) { throw null; }
        public static string Mapping_ModificationFunction_WrongComplexType(object p0, object p1) { throw null; }
        public static string Mapping_NotFound_EntityContainer(object p0) { throw null; }
        public static string Mapping_Object_InvalidType(object p0) { throw null; }
        public static string Mapping_ProviderReturnsNullType(object p0) { throw null; }
        public static string Mapping_Provider_WrongConnectionType(object p0) { throw null; }
        public static string Mapping_Provider_WrongManifestType(object p0) { throw null; }
        public static string Mapping_QueryViewMultipleTypeInTypeName(object p0) { throw null; }
        public static string Mapping_QueryView_Duplicate_OfType(object p0, object p1) { throw null; }
        public static string Mapping_QueryView_Duplicate_OfTypeOnly(object p0, object p1) { throw null; }
        public static string Mapping_QueryView_For_Base_Type(object p0, object p1) { throw null; }
        public static string Mapping_QueryView_PropertyMaps(object p0) { throw null; }
        public static string Mapping_QueryView_TypeName_Not_Defined(object p0) { throw null; }
        public static string Mapping_Storage_InvalidSpace(object p0) { throw null; }
        public static string Mapping_StoreTypeMismatch_ScalarPropertyMapping(object p0, object p1) { throw null; }
        public static string Mapping_TableName_QueryView(object p0) { throw null; }
        public static string Mapping_UnsupportedExpressionKind_QueryView(object p0, object p1, object p2) { throw null; }
        public static string Mapping_UnsupportedFunctionCall_QueryView(object p0, object p1) { throw null; }
        public static string Mapping_UnsupportedInitialization_QueryView(object p0, object p1) { throw null; }
        public static string Mapping_UnsupportedPropertyKind_QueryView(object p0, object p1, object p2) { throw null; }
        public static string Mapping_UnsupportedScanTarget_QueryView(object p0, object p1) { throw null; }
        public static string Mapping_Views_For_Extent_Not_Generated(object p0, object p1) { throw null; }
        public static string Materializer_AddedEntityAlreadyExists(object p0) { throw null; }
        public static string Materializer_InvalidCastNullable(object p0, object p1) { throw null; }
        public static string Materializer_InvalidCastReference(object p0, object p1) { throw null; }
        public static string Materializer_NullReferenceCast(object p0) { throw null; }
        public static string Materializer_PropertyIsNotNullableWithName(object p0) { throw null; }
        public static string Materializer_RecyclingEntity(object p0, object p1, object p2, object p3) { throw null; }
        public static string Materializer_SetInvalidValue(object p0, object p1, object p2, object p3) { throw null; }
        public static string MemberDoesNotBelongToEntityContainer(object p0, object p1) { throw null; }
        public static string MemberInvalidIdentity(object p0) { throw null; }
        public static string MinAndMaxMustBePositive(object p0, object p1) { throw null; }
        public static string MinAndMaxValueMustBeDifferentForNonConstantFacet(object p0, object p1) { throw null; }
        public static string MinAndMaxValueMustBeSameForConstantFacet(object p0, object p1) { throw null; }
        public static string MinMustBeLessThanMax(object p0, object p1, object p2) { throw null; }
        public static string MissingConstraintOnRelationshipType(object p0) { throw null; }
        public static string MissingDefaultValueForConstantFacet(object p0, object p1) { throw null; }
        public static string MissingEntityContainerEnd(object p0, object p1) { throw null; }
        public static string MissingFacetDescription(object p0, object p1, object p2) { throw null; }
        public static string MoreThanOneItemMatchesIdentity(object p0) { throw null; }
        public static string MultipleDefinitionsOfParameter(object p0) { throw null; }
        public static string MultipleDefinitionsOfVariable(object p0) { throw null; }
        public static string NamespaceAliasAlreadyUsed(object p0) { throw null; }
        public static string NamespaceAlreadyImported(object p0) { throw null; }
        public static string NavigationPropertyRelationshipEndTypeMismatch(object p0, object p1, object p2, object p3, object p4) { throw null; }
        public static string NeedNotUseSystemNamespaceInUsing(object p0) { throw null; }
        public static string NestedAggregateCannotBeUsedInAggregate(object p0, object p1) { throw null; }
        public static string NestedClassNotSupported(object p0, object p1) { throw null; }
        public static string NewTypeConflictsWithExistingType(object p0, object p1) { throw null; }
        public static string NoAggrFunctionOverloadMatch(object p0, object p1, object p2) { throw null; }
        public static string NoCanonicalAggrFunctionOverloadMatch(object p0, object p1, object p2) { throw null; }
        public static string NoCanonicalFunctionOverloadMatch(object p0, object p1, object p2) { throw null; }
        public static string NoCodeGenNamespaceInStructuralAnnotation(object p0) { throw null; }
        public static string NoCollectionForSpace(object p0) { throw null; }
        public static string NoFunctionOverloadMatch(object p0, object p1, object p2) { throw null; }
        public static string NoStoreTypeForEdmType(object p0, object p1) { throw null; }
        public static string NotAMemberOfCollection(object p0, object p1) { throw null; }
        public static string NotAMemberOfType(object p0, object p1) { throw null; }
        public static string NotASuperOrSubType(object p0, object p1) { throw null; }
        public static string NotInNamespaceAlias(object p0, object p1, object p2) { throw null; }
        public static string NotInNamespaceNoAlias(object p0, object p1) { throw null; }
        public static string NotNamespaceQualified(object p0) { throw null; }
        public static string NullParameterForEdmRelationshipAttribute(object p0, object p1) { throw null; }
        public static string NullRelationshipNameforEdmRelationshipAttribute(object p0) { throw null; }
        public static string NumberOfTypeCtorIsLessThenFormalSpec(object p0) { throw null; }
        public static string NumberOfTypeCtorIsMoreThenFormalSpec(object p0) { throw null; }
        public static string ObjectContext_AcceptAllChangesFailure(object p0) { throw null; }
        public static string ObjectContext_CannotExplicitlyLoadDetachedRelationships(object p0) { throw null; }
        public static string ObjectContext_CannotLoadReferencesUsingDifferentContext(object p0) { throw null; }
        public static string ObjectContext_ClientEntityRemovedFromStore(object p0) { throw null; }
        public static string ObjectContext_EntitiesHaveDifferentType(object p0, object p1) { throw null; }
        public static string ObjectContext_EntityContainerNotFoundForName(object p0) { throw null; }
        public static string ObjectContext_EntityMustBeUnchangedOrModified(object p0) { throw null; }
        public static string ObjectContext_EntityMustBeUnchangedOrModifiedOrDeleted(object p0) { throw null; }
        public static string ObjectContext_EntityNotInObjectSet_Delete(object p0, object p1, object p2, object p3) { throw null; }
        public static string ObjectContext_EntityNotInObjectSet_Detach(object p0, object p1, object p2, object p3) { throw null; }
        public static string ObjectContext_EntitySetNotFoundForName(object p0) { throw null; }
        public static string ObjectContext_ExecuteFunctionCalledWithNonQueryFunction(object p0) { throw null; }
        public static string ObjectContext_ExecuteFunctionCalledWithNullParameter(object p0) { throw null; }
        public static string ObjectContext_ExecuteFunctionCalledWithScalarFunction(object p0, object p1) { throw null; }
        public static string ObjectContext_ExecuteFunctionTypeMismatch(object p0, object p1) { throw null; }
        public static string ObjectContext_InvalidDefaultContainerName(object p0) { throw null; }
        public static string ObjectContext_InvalidEntitySetForStoreQuery(object p0, object p1, object p2) { throw null; }
        public static string ObjectContext_InvalidEntitySetInKey(object p0, object p1, object p2, object p3) { throw null; }
        public static string ObjectContext_InvalidEntitySetInKeyFromName(object p0, object p1, object p2, object p3, object p4) { throw null; }
        public static string ObjectContext_InvalidEntitySetOnEntity(object p0, object p1) { throw null; }
        public static string ObjectContext_InvalidObjectSetTypeForEntitySet(object p0, object p1, object p2) { throw null; }
        public static string ObjectContext_InvalidTypeForStoreQuery(object p0) { throw null; }
        public static string ObjectContext_MultipleEntitySetsFoundInAllContainers(object p0) { throw null; }
        public static string ObjectContext_MultipleEntitySetsFoundInSingleContainer(object p0, object p1) { throw null; }
        public static string ObjectContext_NoEntitySetFoundForType(object p0) { throw null; }
        public static string ObjectContext_NoMappingForEntityType(object p0) { throw null; }
        public static string ObjectContext_NthElementInAddedState(object p0) { throw null; }
        public static string ObjectContext_NthElementIsDuplicate(object p0) { throw null; }
        public static string ObjectContext_NthElementIsNull(object p0) { throw null; }
        public static string ObjectContext_NthElementNotInObjectStateManager(object p0) { throw null; }
        public static string ObjectContext_TwoPropertiesMappedToSameColumn(object p0, object p1) { throw null; }
        public static string ObjectParameterCollection_DuplicateParameterName(object p0) { throw null; }
        public static string ObjectParameterCollection_ParameterAlreadyExists(object p0) { throw null; }
        public static string ObjectParameterCollection_ParameterNameNotFound(object p0) { throw null; }
        public static string ObjectParameter_InvalidParameterName(object p0) { throw null; }
        public static string ObjectParameter_InvalidParameterType(object p0) { throw null; }
        public static string ObjectQuery_InvalidQueryName(object p0) { throw null; }
        public static string ObjectQuery_QueryBuilder_InvalidResultType(object p0) { throw null; }
        public static string ObjectQuery_Span_NoNavProp(object p0, object p1) { throw null; }
        public static string ObjectQuery_UnableToMaterializeArbitaryProjectionType(object p0) { throw null; }
        public static string ObjectQuery_UnableToMaterializeArray(object p0, object p1) { throw null; }
        public static string ObjectStateEntry_CannotModifyKeyProperty(object p0) { throw null; }
        public static string ObjectStateEntry_ChangedInDifferentStateFromChanging(object p0, object p1) { throw null; }
        public static string ObjectStateEntry_ChangeOnUnmappedComplexProperty(object p0) { throw null; }
        public static string ObjectStateEntry_ChangeOnUnmappedProperty(object p0) { throw null; }
        public static string ObjectStateEntry_ComplexObjectUsedMultipleTimes(object p0, object p1) { throw null; }
        public static string ObjectStateEntry_NullOriginalValueForNonNullableProperty(object p0, object p1, object p2) { throw null; }
        public static string ObjectStateEntry_SetModifiedOnInvalidProperty(object p0) { throw null; }
        public static string ObjectStateEntry_SetModifiedStates(object p0) { throw null; }
        public static string ObjectStateEntry_SetOriginalComplexProperties(object p0) { throw null; }
        public static string ObjectStateEntry_SetOriginalPrimaryKey(object p0) { throw null; }
        public static string ObjectStateEntry_UnableToEnumerateCollection(object p0, object p1) { throw null; }
        public static string ObjectStateManager_ConflictingChangesOfRelationshipDetected(object p0, object p1) { throw null; }
        public static string ObjectStateManager_DoesnotAllowToReAddUnchangedOrModifiedOrDeletedEntity(object p0) { throw null; }
        public static string ObjectStateManager_EntityTypeDoesnotMatchtoEntitySetType(object p0, object p1) { throw null; }
        public static string ObjectStateManager_GetEntityKeyRequiresObjectToHaveAKey(object p0) { throw null; }
        public static string ObjectStateManager_NoEntryExistsForObject(object p0) { throw null; }
        public static string ObjectView_CannotResolveTheEntitySet(object p0) { throw null; }
        public static string OfTypeExpressionElementTypeMustBeEntityType(object p0, object p1) { throw null; }
        public static string OfTypeExpressionElementTypeMustBeNominalType(object p0, object p1) { throw null; }
        public static string OfTypeOnlyTypeArgumentCannotBeAbstract(object p0) { throw null; }
        public static string ParameterNameAlreadyDefinedDuplicate(object p0) { throw null; }
        public static string ParameterTypeNotSupported(object p0, object p1) { throw null; }
        public static string ParameterWasNotDefined(object p0) { throw null; }
        public static string PlaceholderExpressionMustBeCompatibleWithEdm64(object p0, object p1) { throw null; }
        public static string PlaceholderExpressionMustBeConstant(object p0) { throw null; }
        public static string PlaceholderExpressionMustBeGreaterThanOrEqualToZero(object p0) { throw null; }
        public static string PlaceholderSetArgTypeIsNotEqualComparable(object p0, object p1, object p2) { throw null; }
        public static string PocoEntityWrapper_UnableToMaterializeArbitaryNavPropType(object p0, object p1) { throw null; }
        public static string PocoEntityWrapper_UnableToSetFieldOrProperty(object p0, object p1) { throw null; }
        public static string PocoEntityWrapper_UnexpectedTypeForNavigationProperty(object p0, object p1) { throw null; }
        public static string PrecisionMustBeGreaterThanScale(object p0, object p1) { throw null; }
        public static string PrecisionOutOfRange(object p0, object p1, object p2, object p3) { throw null; }
        public static string PropertyNameAlreadyDefinedDuplicate(object p0) { throw null; }
        public static string PropertyTypeAlreadyDefined(object p0) { throw null; }
        public static string ProviderDoesNotSupportType(object p0) { throw null; }
        public static string ProviderReturnedNullForGetDbInformation(object p0) { throw null; }
        public static string RefArgIsNotOfEntityType(object p0) { throw null; }
        public static string ReferenceToNonEntityType(object p0) { throw null; }
        public static string RefTypeIdentifierMustSpecifyAnEntityType(object p0, object p1) { throw null; }
        public static string RelatedEndExprTypeMustBePromotoableToToEnd(object p0, object p1) { throw null; }
        public static string RelatedEnd_CannotAddToFixedSizeArray(object p0) { throw null; }
        public static string RelatedEnd_CannotCreateRelationshipBetweenTrackedAndNoTrackedEntities(object p0) { throw null; }
        public static string RelatedEnd_CannotRemoveFromFixedSizeArray(object p0) { throw null; }
        public static string RelatedEnd_CannotSerialize(object p0) { throw null; }
        public static string RelatedEnd_EntitySetIsNotValidForRelationship(object p0, object p1, object p2, object p3, object p4) { throw null; }
        public static string RelatedEnd_InvalidContainedType_Collection(object p0, object p1) { throw null; }
        public static string RelatedEnd_InvalidContainedType_Reference(object p0, object p1) { throw null; }
        public static string RelatedEnd_InvalidNthElementContextForAttach(object p0) { throw null; }
        public static string RelatedEnd_InvalidNthElementNullForAttach(object p0) { throw null; }
        public static string RelatedEnd_InvalidNthElementStateForAttach(object p0) { throw null; }
        public static string RelatedEnd_InvalidRelationshipFixupDetected(object p0, object p1) { throw null; }
        public static string RelatedEnd_MismatchedMergeOptionOnLoad(object p0) { throw null; }
        public static string RelatedEnd_RelatedEndNotAttachedToContext(object p0) { throw null; }
        public static string RelationshipManager_CollectionAlreadyInitialized(object p0) { throw null; }
        public static string RelationshipManager_CollectionRelationshipManagerAttached(object p0) { throw null; }
        public static string RelationshipManager_InvalidTargetRole(object p0, object p1) { throw null; }
        public static string RelationshipManager_NavigationPropertyNotFound(object p0) { throw null; }
        public static string RelationshipManager_OwnerIsNotSourceType(object p0, object p1, object p2, object p3) { throw null; }
        public static string RelationshipManager_ReferenceAlreadyInitialized(object p0) { throw null; }
        public static string RelationshipManager_RelationshipManagerAttached(object p0) { throw null; }
        public static string RelationshipManager_UnableToFindRelationshipTypeInMetadata(object p0) { throw null; }
        public static string RelationshipNameInNavigationPropertyNotValid(object p0, object p1, object p2) { throw null; }
        public static string RelationshipTargetMustBeUnique(object p0) { throw null; }
        public static string RelationshipTypeExpected(object p0) { throw null; }
        public static string RequiredFacetMissing(object p0, object p1) { throw null; }
        public static string RoleTypeInEdmRelationshipAttributeIsInvalidType(object p0, object p1, object p2) { throw null; }
        public static string SameRoleNameOnRelationshipAttribute(object p0, object p1) { throw null; }
        public static string SameRoleReferredInReferentialConstraint(object p0) { throw null; }
        public static string ScaleOutOfRange(object p0, object p1, object p2, object p3) { throw null; }
        public static string SimilarRelationshipEnd(object p0, object p1, object p2, object p3, object p4) { throw null; }
        public static string SourceTypeMustBePromotoableToFromEndRelationType(object p0, object p1) { throw null; }
        public static string SqlGen_CanonicalFunctionNotSupportedPriorSql10(object p0) { throw null; }
        public static string SqlGen_InvalidDatePartArgumentExpression(object p0, object p1) { throw null; }
        public static string SqlGen_InvalidDatePartArgumentValue(object p0, object p1, object p2) { throw null; }
        public static string SqlGen_PrimitiveTypeNotSupportedPriorSql10(object p0) { throw null; }
        public static string SqlGen_TypedNaNNotSupported(object p0) { throw null; }
        public static string SqlGen_TypedNegativeInfinityNotSupported(object p0, object p1) { throw null; }
        public static string SqlGen_TypedPositiveInfinityNotSupported(object p0, object p1) { throw null; }
        public static string SqlProvider_InvalidGeographyColumn(object p0) { throw null; }
        public static string SqlProvider_InvalidGeometryColumn(object p0) { throw null; }
        public static string SqlProvider_NeedSqlDataReader(object p0) { throw null; }
        public static string SqlSpatialServices_ProviderValueNotSqlType(object p0) { throw null; }
        public static string StorageEntityContainerNameMismatchWhileSpecifyingPartialMapping(object p0, object p1, object p2) { throw null; }
        public static string StoreItemCollectionMustHaveOneArtifact(object p0) { throw null; }
        public static string SystemNamespaceEncountered(object p0) { throw null; }
        public static string TableAndSchemaAreMutuallyExclusiveWithDefiningQuery(object p0) { throw null; }
        public static string TargetRoleNameInNavigationPropertyNotValid(object p0, object p1, object p2, object p3) { throw null; }
        public static string TextNotAllowed(object p0) { throw null; }
        public static string TooManyAssociationEnds(object p0) { throw null; }
        public static string TypeArgumentBelowMin(object p0) { throw null; }
        public static string TypeArgumentCountMismatch(object p0, object p1) { throw null; }
        public static string TypeArgumentExceedsMax(object p0) { throw null; }
        public static string TypeDoesNotSupportFacet(object p0, object p1) { throw null; }
        public static string TypeDoesNotSupportSpec(object p0) { throw null; }
        public static string TypeKindMismatch(object p0, object p1, object p2, object p3) { throw null; }
        public static string TypeMismatchRelationshipConstaint(object p0, object p1, object p2, object p3, object p4) { throw null; }
        public static string TypeMustBeEntityType(object p0, object p1, object p2) { throw null; }
        public static string TypeMustBeNominalType(object p0, object p1, object p2) { throw null; }
        public static string TypeNameAlreadyDefinedDuplicate(object p0) { throw null; }
        public static string TypeNameNotFound(object p0) { throw null; }
        public static string TypeNotInAssociationSet(object p0, object p1, object p2) { throw null; }
        public static string TypeNotInEntitySet(object p0, object p1, object p2) { throw null; }
        public static string UnableToFindReflectedType(object p0, object p1) { throw null; }
        public static string UnableToResolveAssembly(object p0) { throw null; }
        public static string UnacceptableUri(object p0) { throw null; }
        public static string UnexpectedRootElement(object p0, object p1, object p2) { throw null; }
        public static string UnexpectedRootElementNoNamespace(object p0, object p1, object p2) { throw null; }
        public static string UnexpectedTypeInCollection(object p0, object p1) { throw null; }
        public static string UnexpectedXmlAttribute(object p0) { throw null; }
        public static string UnexpectedXmlElement(object p0) { throw null; }
        public static string UnexpectedXmlNodeType(object p0) { throw null; }
        public static string UnknownExpressionResolutionClass(object p0) { throw null; }
        public static string Update_AmbiguousForeignKey(object p0) { throw null; }
        public static string Update_ConcurrencyError(object p0) { throw null; }
        public static string Update_GeneratedDependent(object p0) { throw null; }
        public static string Update_InsertingOrUpdatingReferenceToDeletedEntity(object p0) { throw null; }
        public static string Update_MappingNotFound(object p0) { throw null; }
        public static string Update_MissingEntity(object p0, object p1) { throw null; }
        public static string Update_MissingFunctionMapping(object p0, object p1, object p2) { throw null; }
        public static string Update_MissingRequiredEntity(object p0, object p1, object p2) { throw null; }
        public static string Update_MissingRequiredRelationshipValue(object p0, object p1) { throw null; }
        public static string Update_MissingResultColumn(object p0) { throw null; }
        public static string Update_ModifyingIdentityColumn(object p0, object p1, object p2) { throw null; }
        public static string Update_NotSupportedComputedKeyColumn(object p0, object p1, object p2, object p3, object p4) { throw null; }
        public static string Update_NotSupportedIdentityType(object p0, object p1) { throw null; }
        public static string Update_NotSupportedServerGenKey(object p0) { throw null; }
        public static string Update_NullReturnValueForNonNullableMember(object p0, object p1) { throw null; }
        public static string Update_NullValue(object p0) { throw null; }
        public static string Update_RelationshipCardinalityConstraintViolation(object p0, object p1, object p2, object p3, object p4, object p5) { throw null; }
        public static string Update_RelationshipCardinalityConstraintViolationSingleValue(object p0, object p1, object p2, object p3, object p4) { throw null; }
        public static string Update_RelationshipCardinalityViolation(object p0, object p1, object p2, object p3, object p4, object p5) { throw null; }
        public static string Update_ReturnValueHasUnexpectedType(object p0, object p1, object p2, object p3) { throw null; }
        public static string Update_SqlEntitySetWithoutDmlFunctions(object p0, object p1, object p2) { throw null; }
        public static string Update_UnableToConvertRowsAffectedParameterToInt32(object p0, object p1) { throw null; }
        public static string Update_UnsupportedCastArgument(object p0) { throw null; }
        public static string Update_UnsupportedExpressionKind(object p0, object p1) { throw null; }
        public static string Update_UnsupportedExtentType(object p0, object p1) { throw null; }
        public static string Update_UnsupportedJoinType(object p0) { throw null; }
        public static string Update_UnsupportedProjection(object p0) { throw null; }
        public static string Validator_NoKeyMembers(object p0) { throw null; }
        public static string Validator_NullableEntityKeyProperty(object p0, object p1) { throw null; }
        public static string Validator_OSpace_ComplexPropertyNotComplex(object p0, object p1, object p2) { throw null; }
        public static string Validator_OSpace_Convention_AmbiguousClrType(object p0, object p1, object p2) { throw null; }
        public static string Validator_OSpace_Convention_AttributeAssemblyReferenced(object p0) { throw null; }
        public static string Validator_OSpace_Convention_BaseTypeIncompatible(object p0, object p1, object p2) { throw null; }
        public static string Validator_OSpace_Convention_BaseTypeNotLoaded(object p0, object p1) { throw null; }
        public static string Validator_OSpace_Convention_MissingOSpaceType(object p0) { throw null; }
        public static string Validator_OSpace_Convention_MissingRequiredProperty(object p0, object p1) { throw null; }
        public static string Validator_OSpace_Convention_MultipleTypesWithSameName(object p0) { throw null; }
        public static string Validator_OSpace_Convention_NonPrimitiveTypeProperty(object p0, object p1, object p2) { throw null; }
        public static string Validator_OSpace_Convention_RelationshipNotLoaded(object p0, object p1) { throw null; }
        public static string Validator_OSpace_Convention_ScalarPropertyMissginGetterOrSetter(object p0, object p1, object p2) { throw null; }
        public static string Validator_OSpace_Convention_SSpaceOSpaceTypeMismatch(object p0, object p1) { throw null; }
        public static string Validator_OSpace_Convention_Struct(object p0, object p1) { throw null; }
        public static string Validator_OSpace_InvalidNavPropReturnType(object p0, object p1, object p2) { throw null; }
        public static string Validator_OSpace_ScalarPropertyNotPrimitive(object p0, object p1, object p2) { throw null; }
        public static string Validator_UnsupportedEnumUnderlyingType(object p0) { throw null; }
        public static string ValueNotUnderstood(object p0, object p1) { throw null; }
        public static string ViewGen_AssociationEndShouldBeMappedToKey(object p0, object p1) { throw null; }
        public static string ViewGen_AssociationSetKey_Missing(object p0, object p1, object p2) { throw null; }
        public static string ViewGen_AssociationSet_AsUserString(object p0, object p1, object p2) { throw null; }
        public static string ViewGen_AssociationSet_AsUserString_Negated(object p0, object p1, object p2) { throw null; }
        public static string Viewgen_CannotGenerateQueryViewUnderNoValidation(object p0) { throw null; }
        public static string ViewGen_Cannot_Disambiguate_MultiConstant(object p0, object p1) { throw null; }
        public static string ViewGen_Cannot_Recover_Attributes(object p0, object p1, object p2) { throw null; }
        public static string ViewGen_Cannot_Recover_Types(object p0, object p1) { throw null; }
        public static string ViewGen_Concurrency_Derived_Class(object p0, object p1, object p2) { throw null; }
        public static string ViewGen_Concurrency_Invalid_Condition(object p0, object p1) { throw null; }
        public static string Viewgen_ConfigurationErrorMsg(object p0) { throw null; }
        public static string ViewGen_CQ_DomainConstraint(object p0) { throw null; }
        public static string ViewGen_CQ_PartitionConstraint(object p0) { throw null; }
        public static string ViewGen_Duplicate_CProperties(object p0) { throw null; }
        public static string ViewGen_Duplicate_CProperties_IsMapped(object p0, object p1) { throw null; }
        public static string ViewGen_EntitySetKey_Missing(object p0, object p1) { throw null; }
        public static string ViewGen_EntitySet_AsUserString(object p0, object p1) { throw null; }
        public static string ViewGen_EntitySet_AsUserString_Negated(object p0, object p1) { throw null; }
        public static string ViewGen_ErrorLog(object p0) { throw null; }
        public static string ViewGen_ErrorLog2(object p0) { throw null; }
        public static string Viewgen_ErrorPattern_ConditionMemberIsMapped(object p0) { throw null; }
        public static string Viewgen_ErrorPattern_DuplicateConditionValue(object p0) { throw null; }
        public static string Viewgen_ErrorPattern_NotNullConditionMappedToNullableMember(object p0, object p1) { throw null; }
        public static string Viewgen_ErrorPattern_Partition_MultipleTypesMappedToSameTable_WithoutCondition(object p0, object p1) { throw null; }
        public static string Viewgen_ErrorPattern_TableMappedToMultipleES(object p0, object p1, object p2) { throw null; }
        public static string ViewGen_Foreign_Key(object p0, object p1, object p2, object p3, object p4) { throw null; }
        public static string ViewGen_Foreign_Key_LowerBound_MustBeOne(object p0, object p1, object p2) { throw null; }
        public static string ViewGen_Foreign_Key_Missing_Relationship_Mapping(object p0) { throw null; }
        public static string ViewGen_Foreign_Key_Missing_Table_Mapping(object p0, object p1) { throw null; }
        public static string ViewGen_Foreign_Key_Not_Guaranteed_InCSpace(object p0) { throw null; }
        public static string ViewGen_Foreign_Key_ParentTable_NotMappedToEnd(object p0, object p1, object p2, object p3, object p4, object p5) { throw null; }
        public static string ViewGen_Foreign_Key_UpperBound_MustBeOne(object p0, object p1, object p2) { throw null; }
        public static string ViewGen_HashOnMappingClosure_Not_Matching(object p0) { throw null; }
        public static string ViewGen_InvalidCondition(object p0) { throw null; }
        public static string ViewGen_KeyConstraint_Update_Violation_AssociationSet(object p0, object p1, object p2) { throw null; }
        public static string ViewGen_KeyConstraint_Update_Violation_EntitySet(object p0, object p1, object p2, object p3) { throw null; }
        public static string ViewGen_KeyConstraint_Violation(object p0, object p1, object p2, object p3, object p4, object p5) { throw null; }
        public static string ViewGen_Missing_Sets_Mapping(object p0) { throw null; }
        public static string ViewGen_Missing_Set_Mapping(object p0) { throw null; }
        public static string ViewGen_Missing_Type_Mapping(object p0) { throw null; }
        public static string Viewgen_MultipleFragmentsBetweenCandSExtentWithDistinct(object p0, object p1) { throw null; }
        public static string ViewGen_NegatedCellConstant(object p0) { throw null; }
        public static string ViewGen_NonKeyProjectedWithOverlappingPartitions(object p0) { throw null; }
        public static string ViewGen_NotNull_No_Projected_Slot(object p0) { throw null; }
        public static string ViewGen_No_Default_Value(object p0, object p1) { throw null; }
        public static string ViewGen_No_Default_Value_For_Configuration(object p0) { throw null; }
        public static string Viewgen_NullableMappingForNonNullableColumn(object p0, object p1) { throw null; }
        public static string ViewGen_OneOfConst_IsEqualTo(object p0, object p1) { throw null; }
        public static string ViewGen_OneOfConst_IsNonNullable(object p0) { throw null; }
        public static string ViewGen_OneOfConst_IsNotEqualTo(object p0, object p1) { throw null; }
        public static string ViewGen_OneOfConst_IsNotOneOf(object p0, object p1) { throw null; }
        public static string ViewGen_OneOfConst_IsOneOf(object p0, object p1) { throw null; }
        public static string ViewGen_OneOfConst_IsOneOfTypes(object p0) { throw null; }
        public static string ViewGen_OneOfConst_MustBeEqualTo(object p0, object p1) { throw null; }
        public static string ViewGen_OneOfConst_MustBeNonNullable(object p0) { throw null; }
        public static string ViewGen_OneOfConst_MustBeNull(object p0) { throw null; }
        public static string ViewGen_OneOfConst_MustBeOneOf(object p0, object p1) { throw null; }
        public static string ViewGen_OneOfConst_MustNotBeEqualTo(object p0, object p1) { throw null; }
        public static string ViewGen_OneOfConst_MustNotBeOneOf(object p0, object p1) { throw null; }
        public static string Viewgen_QV_RewritingNotFound(object p0) { throw null; }
        public static string Viewgen_RightSideNotDisjoint(object p0) { throw null; }
        public static string ViewGen_TableKey_Missing(object p0, object p1) { throw null; }
    }
}
namespace System.Data.EntityClient
{
    public sealed partial class EntityCommand : System.Data.Common.DbCommand
    {
        public EntityCommand() { }
        public EntityCommand(string statement) { }
        public EntityCommand(string statement, System.Data.EntityClient.EntityConnection connection) { }
        public EntityCommand(string statement, System.Data.EntityClient.EntityConnection connection, System.Data.EntityClient.EntityTransaction transaction) { }
        public override string CommandText { get { throw null; } set { } }
        public override int CommandTimeout { get { throw null; } set { } }
        public System.Data.Common.CommandTrees.DbCommandTree CommandTree { get { throw null; } set { } }
        public override System.Data.CommandType CommandType { get { throw null; } set { } }
        public new System.Data.EntityClient.EntityConnection Connection { get { throw null; } set { } }
        protected override System.Data.Common.DbConnection DbConnection { get { throw null; } set { } }
        protected override System.Data.Common.DbParameterCollection DbParameterCollection { get { throw null; } }
        protected override System.Data.Common.DbTransaction DbTransaction { get { throw null; } set { } }
        public override bool DesignTimeVisible { get { throw null; } set { } }
        public bool EnablePlanCaching { get { throw null; } set { } }
        public new System.Data.EntityClient.EntityParameterCollection Parameters { get { throw null; } }
        public new System.Data.EntityClient.EntityTransaction Transaction { get { throw null; } set { } }
        public override System.Data.UpdateRowSource UpdatedRowSource { get { throw null; } set { } }
        public override void Cancel() { }
        protected override System.Data.Common.DbParameter CreateDbParameter() { throw null; }
        public new System.Data.EntityClient.EntityParameter CreateParameter() { throw null; }
        protected override System.Data.Common.DbDataReader ExecuteDbDataReader(System.Data.CommandBehavior behavior) { throw null; }
        public override int ExecuteNonQuery() { throw null; }
        public new System.Data.EntityClient.EntityDataReader ExecuteReader() { throw null; }
        public new System.Data.EntityClient.EntityDataReader ExecuteReader(System.Data.CommandBehavior behavior) { throw null; }
        public override object ExecuteScalar() { throw null; }
        public override void Prepare() { }
        [System.ComponentModel.BrowsableAttribute(false)]
        public string ToTraceString() { throw null; }
    }
    public sealed partial class EntityConnection : System.Data.Common.DbConnection
    {
        public EntityConnection() { }
        public EntityConnection(System.Data.Metadata.Edm.MetadataWorkspace workspace, System.Data.Common.DbConnection connection) { }
        public EntityConnection(string connectionString) { }
        public override string ConnectionString { get { throw null; } set { } }
        public override int ConnectionTimeout { get { throw null; } }
        public override string Database { get { throw null; } }
        public override string DataSource { get { throw null; } }
        protected override System.Data.Common.DbProviderFactory DbProviderFactory { get { throw null; } }
        public override string ServerVersion { get { throw null; } }
        public override System.Data.ConnectionState State { get { throw null; } }
        public System.Data.Common.DbConnection StoreConnection { get { throw null; } }
        protected override System.Data.Common.DbTransaction BeginDbTransaction(System.Data.IsolationLevel isolationLevel) { throw null; }
        public new System.Data.EntityClient.EntityTransaction BeginTransaction() { throw null; }
        public new System.Data.EntityClient.EntityTransaction BeginTransaction(System.Data.IsolationLevel isolationLevel) { throw null; }
        public override void ChangeDatabase(string databaseName) { }
        public override void Close() { }
        public new System.Data.EntityClient.EntityCommand CreateCommand() { throw null; }
        protected override System.Data.Common.DbCommand CreateDbCommand() { throw null; }
        protected override void Dispose(bool disposing) { }
        public override void EnlistTransaction(System.Transactions.Transaction transaction) { }
        [System.CLSCompliantAttribute(false)]
        public System.Data.Metadata.Edm.MetadataWorkspace GetMetadataWorkspace() { throw null; }
        public override void Open() { }
    }
    public sealed partial class EntityConnectionStringBuilder : System.Data.Common.DbConnectionStringBuilder
    {
        public EntityConnectionStringBuilder() { }
        public EntityConnectionStringBuilder(string connectionString) { }
        public override bool IsFixedSize { get { throw null; } }
        public override object this[string keyword] { get { throw null; } set { } }
        public override System.Collections.ICollection Keys { get { throw null; } }
        [System.ComponentModel.DisplayNameAttribute("Metadata")]
        [System.ComponentModel.RefreshPropertiesAttribute(System.ComponentModel.RefreshProperties.All)]
        public string Metadata { get { throw null; } set { } }
        [System.ComponentModel.DisplayNameAttribute("Name")]
        [System.ComponentModel.RefreshPropertiesAttribute(System.ComponentModel.RefreshProperties.All)]
        public string Name { get { throw null; } set { } }
        [System.ComponentModel.DisplayNameAttribute("Provider")]
        [System.ComponentModel.RefreshPropertiesAttribute(System.ComponentModel.RefreshProperties.All)]
        public string Provider { get { throw null; } set { } }
        [System.ComponentModel.DisplayNameAttribute("Provider Connection String")]
        [System.ComponentModel.RefreshPropertiesAttribute(System.ComponentModel.RefreshProperties.All)]
        public string ProviderConnectionString { get { throw null; } set { } }
        public override void Clear() { }
        public override bool ContainsKey(string keyword) { throw null; }
        public override bool Remove(string keyword) { throw null; }
        public override bool TryGetValue(string keyword, out object value) { throw null; }
    }
    public partial class EntityDataReader : System.Data.Common.DbDataReader, System.Data.IDataRecord, System.Data.IExtendedDataRecord
    {
        internal EntityDataReader() { }
        public System.Data.Common.DataRecordInfo DataRecordInfo { get { throw null; } }
        public override int Depth { get { throw null; } }
        public override int FieldCount { get { throw null; } }
        public override bool HasRows { get { throw null; } }
        public override bool IsClosed { get { throw null; } }
        public override object this[int ordinal] { get { throw null; } }
        public override object this[string name] { get { throw null; } }
        public override int RecordsAffected { get { throw null; } }
        public override int VisibleFieldCount { get { throw null; } }
        public override void Close() { }
        protected override void Dispose(bool disposing) { }
        public override bool GetBoolean(int ordinal) { throw null; }
        public override byte GetByte(int ordinal) { throw null; }
        public override long GetBytes(int ordinal, long dataOffset, byte[] buffer, int bufferOffset, int length) { throw null; }
        public override char GetChar(int ordinal) { throw null; }
        public override long GetChars(int ordinal, long dataOffset, char[] buffer, int bufferOffset, int length) { throw null; }
        public System.Data.Common.DbDataReader GetDataReader(int i) { throw null; }
        public System.Data.Common.DbDataRecord GetDataRecord(int i) { throw null; }
        public override string GetDataTypeName(int ordinal) { throw null; }
        public override System.DateTime GetDateTime(int ordinal) { throw null; }
        protected override System.Data.Common.DbDataReader GetDbDataReader(int ordinal) { throw null; }
        public override decimal GetDecimal(int ordinal) { throw null; }
        public override double GetDouble(int ordinal) { throw null; }
        public override System.Collections.IEnumerator GetEnumerator() { throw null; }
        public override System.Type GetFieldType(int ordinal) { throw null; }
        public override float GetFloat(int ordinal) { throw null; }
        public override System.Guid GetGuid(int ordinal) { throw null; }
        public override short GetInt16(int ordinal) { throw null; }
        public override int GetInt32(int ordinal) { throw null; }
        public override long GetInt64(int ordinal) { throw null; }
        public override string GetName(int ordinal) { throw null; }
        public override int GetOrdinal(string name) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override System.Type GetProviderSpecificFieldType(int ordinal) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override object GetProviderSpecificValue(int ordinal) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetProviderSpecificValues(object[] values) { throw null; }
        public override System.Data.DataTable GetSchemaTable() { throw null; }
        public override string GetString(int ordinal) { throw null; }
        public override object GetValue(int ordinal) { throw null; }
        public override int GetValues(object[] values) { throw null; }
        public override bool IsDBNull(int ordinal) { throw null; }
        public override bool NextResult() { throw null; }
        public override bool Read() { throw null; }
    }
    public sealed partial class EntityParameter : System.Data.Common.DbParameter, System.Data.IDataParameter, System.Data.IDbDataParameter
    {
        public EntityParameter() { }
        public EntityParameter(string parameterName, System.Data.DbType dbType) { }
        public EntityParameter(string parameterName, System.Data.DbType dbType, int size) { }
        public EntityParameter(string parameterName, System.Data.DbType dbType, int size, System.Data.ParameterDirection direction, bool isNullable, byte precision, byte scale, string sourceColumn, System.Data.DataRowVersion sourceVersion, object value) { }
        public EntityParameter(string parameterName, System.Data.DbType dbType, int size, string sourceColumn) { }
        public override System.Data.DbType DbType { get { throw null; } set { } }
        [System.ComponentModel.RefreshPropertiesAttribute(System.ComponentModel.RefreshProperties.All)]
        public override System.Data.ParameterDirection Direction { get { throw null; } set { } }
        public System.Data.Metadata.Edm.EdmType EdmType { get { throw null; } set { } }
        public override bool IsNullable { get { throw null; } set { } }
        public override string ParameterName { get { throw null; } set { } }
        public new byte Precision { get { throw null; } set { } }
        public new byte Scale { get { throw null; } set { } }
        public override int Size { get { throw null; } set { } }
        public override string SourceColumn { get { throw null; } set { } }
        public override bool SourceColumnNullMapping { get { throw null; } set { } }
        public override System.Data.DataRowVersion SourceVersion { get { throw null; } set { } }
        public override object Value { get { throw null; } set { } }
        public override void ResetDbType() { }
        public override string ToString() { throw null; }
    }
    public sealed partial class EntityParameterCollection : System.Data.Common.DbParameterCollection
    {
        internal EntityParameterCollection() { }
        public override int Count { get { throw null; } }
        public override bool IsFixedSize { get { throw null; } }
        public override bool IsReadOnly { get { throw null; } }
        public override bool IsSynchronized { get { throw null; } }
        public new System.Data.EntityClient.EntityParameter this[int index] { get { throw null; } set { } }
        public new System.Data.EntityClient.EntityParameter this[string parameterName] { get { throw null; } set { } }
        public override object SyncRoot { get { throw null; } }
        public System.Data.EntityClient.EntityParameter Add(System.Data.EntityClient.EntityParameter value) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int Add(object value) { throw null; }
        public System.Data.EntityClient.EntityParameter Add(string parameterName, System.Data.DbType dbType) { throw null; }
        public System.Data.EntityClient.EntityParameter Add(string parameterName, System.Data.DbType dbType, int size) { throw null; }
        public override void AddRange(System.Array values) { }
        public void AddRange(System.Data.EntityClient.EntityParameter[] values) { }
        public System.Data.EntityClient.EntityParameter AddWithValue(string parameterName, object value) { throw null; }
        public override void Clear() { }
        public override bool Contains(object value) { throw null; }
        public override bool Contains(string parameterName) { throw null; }
        public override void CopyTo(System.Array array, int index) { }
        public void CopyTo(System.Data.EntityClient.EntityParameter[] array, int index) { }
        public override System.Collections.IEnumerator GetEnumerator() { throw null; }
        protected override System.Data.Common.DbParameter GetParameter(int index) { throw null; }
        protected override System.Data.Common.DbParameter GetParameter(string parameterName) { throw null; }
        public int IndexOf(System.Data.EntityClient.EntityParameter value) { throw null; }
        public override int IndexOf(object value) { throw null; }
        public override int IndexOf(string parameterName) { throw null; }
        public void Insert(int index, System.Data.EntityClient.EntityParameter value) { }
        public override void Insert(int index, object value) { }
        public void Remove(System.Data.EntityClient.EntityParameter value) { }
        public override void Remove(object value) { }
        public override void RemoveAt(int index) { }
        public override void RemoveAt(string parameterName) { }
        protected override void SetParameter(int index, System.Data.Common.DbParameter value) { }
        protected override void SetParameter(string parameterName, System.Data.Common.DbParameter value) { }
    }
    public sealed partial class EntityProviderFactory : System.Data.Common.DbProviderFactory, System.IServiceProvider
    {
        internal EntityProviderFactory() { }
        public static readonly System.Data.EntityClient.EntityProviderFactory Instance;
        public override System.Data.Common.DbCommand CreateCommand() { throw null; }
        public override System.Data.Common.DbCommandBuilder CreateCommandBuilder() { throw null; }
        public override System.Data.Common.DbConnection CreateConnection() { throw null; }
        public override System.Data.Common.DbConnectionStringBuilder CreateConnectionStringBuilder() { throw null; }
        public override System.Data.Common.DbDataAdapter CreateDataAdapter() { throw null; }
        public override System.Data.Common.DbParameter CreateParameter() { throw null; }
        public override System.Security.CodeAccessPermission CreatePermission(System.Security.Permissions.PermissionState state) { throw null; }
        object System.IServiceProvider.GetService(System.Type serviceType) { throw null; }
    }
    public sealed partial class EntityTransaction : System.Data.Common.DbTransaction
    {
        internal EntityTransaction() { }
        public new System.Data.EntityClient.EntityConnection Connection { get { throw null; } }
        protected override System.Data.Common.DbConnection DbConnection { get { throw null; } }
        public override System.Data.IsolationLevel IsolationLevel { get { throw null; } }
        public override void Commit() { }
        protected override void Dispose(bool disposing) { }
        public override void Rollback() { }
    }
}
namespace System.Data.Mapping
{
    public abstract partial class EntityViewContainer
    {
        protected EntityViewContainer() { }
        public string EdmEntityContainerName { get { throw null; } set { } }
        public string HashOverAllExtentViews { get { throw null; } set { } }
        public string HashOverMappingClosure { get { throw null; } set { } }
        public string StoreEntityContainerName { get { throw null; } set { } }
        public int ViewCount { get { throw null; } protected set { } }
        protected abstract System.Collections.Generic.KeyValuePair<string, string> GetViewAt(int index);
    }
    [System.AttributeUsageAttribute(System.AttributeTargets.Assembly, AllowMultiple=true)]
    public sealed partial class EntityViewGenerationAttribute : System.Attribute
    {
        public EntityViewGenerationAttribute(System.Type viewGenerationType) { }
        public System.Type ViewGenerationType { get { throw null; } }
    }
    [System.CLSCompliantAttribute(false)]
    public abstract partial class MappingItemCollection : System.Data.Metadata.Edm.ItemCollection
    {
        internal MappingItemCollection() { }
    }
    [System.CLSCompliantAttribute(false)]
    public partial class StorageMappingItemCollection : System.Data.Mapping.MappingItemCollection
    {
        public StorageMappingItemCollection(System.Data.Metadata.Edm.EdmItemCollection edmCollection, System.Data.Metadata.Edm.StoreItemCollection storeCollection, System.Collections.Generic.IEnumerable<System.Xml.XmlReader> xmlReaders) { }
        public StorageMappingItemCollection(System.Data.Metadata.Edm.EdmItemCollection edmCollection, System.Data.Metadata.Edm.StoreItemCollection storeCollection, params string[] filePaths) { }
        public double MappingVersion { get { throw null; } }
    }
}
namespace System.Data.Metadata.Edm
{
    public sealed partial class AssociationEndMember : System.Data.Metadata.Edm.RelationshipEndMember
    {
        internal AssociationEndMember() { }
        public override System.Data.Metadata.Edm.BuiltInTypeKind BuiltInTypeKind { get { throw null; } }
    }
    public sealed partial class AssociationSet : System.Data.Metadata.Edm.RelationshipSet
    {
        internal AssociationSet() { }
        public System.Data.Metadata.Edm.ReadOnlyMetadataCollection<System.Data.Metadata.Edm.AssociationSetEnd> AssociationSetEnds { get { throw null; } }
        public override System.Data.Metadata.Edm.BuiltInTypeKind BuiltInTypeKind { get { throw null; } }
        public new System.Data.Metadata.Edm.AssociationType ElementType { get { throw null; } }
    }
    public sealed partial class AssociationSetEnd : System.Data.Metadata.Edm.MetadataItem
    {
        internal AssociationSetEnd() { }
        public override System.Data.Metadata.Edm.BuiltInTypeKind BuiltInTypeKind { get { throw null; } }
        public System.Data.Metadata.Edm.AssociationEndMember CorrespondingAssociationEndMember { get { throw null; } }
        public System.Data.Metadata.Edm.EntitySet EntitySet { get { throw null; } }
        public string Name { get { throw null; } }
        public System.Data.Metadata.Edm.AssociationSet ParentAssociationSet { get { throw null; } }
        [System.ObsoleteAttribute("This property is going away, please use the Name property instead")]
        public string Role { get { throw null; } }
        public override string ToString() { throw null; }
    }
    public sealed partial class AssociationType : System.Data.Metadata.Edm.RelationshipType
    {
        internal AssociationType() { }
        public System.Data.Metadata.Edm.ReadOnlyMetadataCollection<System.Data.Metadata.Edm.AssociationEndMember> AssociationEndMembers { get { throw null; } }
        public override System.Data.Metadata.Edm.BuiltInTypeKind BuiltInTypeKind { get { throw null; } }
        public bool IsForeignKey { get { throw null; } }
        public System.Data.Metadata.Edm.ReadOnlyMetadataCollection<System.Data.Metadata.Edm.ReferentialConstraint> ReferentialConstraints { get { throw null; } }
    }
    public enum BuiltInTypeKind
    {
        AssociationEndMember = 0,
        AssociationSet = 2,
        AssociationSetEnd = 1,
        AssociationType = 3,
        CollectionKind = 7,
        CollectionType = 6,
        ComplexType = 8,
        Documentation = 9,
        EdmFunction = 18,
        EdmMember = 24,
        EdmProperty = 28,
        EdmType = 11,
        EntityContainer = 12,
        EntitySet = 13,
        EntitySetBase = 4,
        EntityType = 14,
        EntityTypeBase = 5,
        EnumMember = 16,
        EnumType = 15,
        Facet = 17,
        FunctionParameter = 19,
        GlobalItem = 20,
        MetadataItem = 23,
        MetadataProperty = 21,
        NavigationProperty = 22,
        OperationAction = 10,
        ParameterMode = 25,
        PrimitiveType = 26,
        PrimitiveTypeKind = 27,
        ProviderManifest = 29,
        ReferentialConstraint = 30,
        RefType = 31,
        RelationshipEndMember = 32,
        RelationshipMultiplicity = 33,
        RelationshipSet = 34,
        RelationshipType = 35,
        RowType = 36,
        SimpleType = 37,
        StructuralType = 38,
        TypeUsage = 39,
    }
    public enum CollectionKind
    {
        Bag = 1,
        List = 2,
        None = 0,
    }
    public sealed partial class CollectionType : System.Data.Metadata.Edm.EdmType
    {
        internal CollectionType() { }
        public override System.Data.Metadata.Edm.BuiltInTypeKind BuiltInTypeKind { get { throw null; } }
        public System.Data.Metadata.Edm.TypeUsage TypeUsage { get { throw null; } }
    }
    public partial class ComplexType : System.Data.Metadata.Edm.StructuralType
    {
        internal ComplexType() { }
        public override System.Data.Metadata.Edm.BuiltInTypeKind BuiltInTypeKind { get { throw null; } }
        public System.Data.Metadata.Edm.ReadOnlyMetadataCollection<System.Data.Metadata.Edm.EdmProperty> Properties { get { throw null; } }
    }
    public enum ConcurrencyMode
    {
        Fixed = 1,
        None = 0,
    }
    public enum DataSpace
    {
        CSpace = 1,
        CSSpace = 4,
        OCSpace = 3,
        OSpace = 0,
        SSpace = 2,
    }
    public sealed partial class Documentation : System.Data.Metadata.Edm.MetadataItem
    {
        internal Documentation() { }
        public override System.Data.Metadata.Edm.BuiltInTypeKind BuiltInTypeKind { get { throw null; } }
        public bool IsEmpty { get { throw null; } }
        public string LongDescription { get { throw null; } }
        public string Summary { get { throw null; } }
        public override string ToString() { throw null; }
    }
    [System.SerializableAttribute]
    public abstract partial class EdmError
    {
        internal EdmError() { }
        public string Message { get { throw null; } }
    }
    public sealed partial class EdmFunction : System.Data.Metadata.Edm.EdmType
    {
        internal EdmFunction() { }
        public override System.Data.Metadata.Edm.BuiltInTypeKind BuiltInTypeKind { get { throw null; } }
        public string CommandTextAttribute { get { throw null; } }
        public override string FullName { get { throw null; } }
        public bool IsComposableAttribute { get { throw null; } }
        public System.Data.Metadata.Edm.ReadOnlyMetadataCollection<System.Data.Metadata.Edm.FunctionParameter> Parameters { get { throw null; } }
        public System.Data.Metadata.Edm.FunctionParameter ReturnParameter { get { throw null; } }
        public System.Data.Metadata.Edm.ReadOnlyMetadataCollection<System.Data.Metadata.Edm.FunctionParameter> ReturnParameters { get { throw null; } }
    }
    [System.CLSCompliantAttribute(false)]
    public sealed partial class EdmItemCollection : System.Data.Metadata.Edm.ItemCollection
    {
        public EdmItemCollection(System.Collections.Generic.IEnumerable<System.Xml.XmlReader> xmlReaders) { }
        public EdmItemCollection(params string[] filePaths) { }
        public double EdmVersion { get { throw null; } }
        public System.Collections.ObjectModel.ReadOnlyCollection<System.Data.Metadata.Edm.PrimitiveType> GetPrimitiveTypes() { throw null; }
        public System.Collections.ObjectModel.ReadOnlyCollection<System.Data.Metadata.Edm.PrimitiveType> GetPrimitiveTypes(double edmVersion) { throw null; }
    }
    public abstract partial class EdmMember : System.Data.Metadata.Edm.MetadataItem
    {
        internal EdmMember() { }
        public System.Data.Metadata.Edm.StructuralType DeclaringType { get { throw null; } }
        public string Name { get { throw null; } }
        public System.Data.Metadata.Edm.TypeUsage TypeUsage { get { throw null; } }
        public override string ToString() { throw null; }
    }
    public sealed partial class EdmProperty : System.Data.Metadata.Edm.EdmMember
    {
        internal EdmProperty() { }
        public override System.Data.Metadata.Edm.BuiltInTypeKind BuiltInTypeKind { get { throw null; } }
        public object DefaultValue { get { throw null; } }
        public bool Nullable { get { throw null; } }
    }
    [System.SerializableAttribute]
    public sealed partial class EdmSchemaError : System.Data.Metadata.Edm.EdmError
    {
        internal EdmSchemaError() { }
        public int Column { get { throw null; } }
        public int ErrorCode { get { throw null; } }
        public int Line { get { throw null; } }
        public string SchemaLocation { get { throw null; } }
        public string SchemaName { get { throw null; } }
        public System.Data.Metadata.Edm.EdmSchemaErrorSeverity Severity { get { throw null; } set { } }
        public string StackTrace { get { throw null; } }
        public override string ToString() { throw null; }
    }
    public enum EdmSchemaErrorSeverity
    {
        Error = 1,
        Warning = 0,
    }
    public abstract partial class EdmType : System.Data.Metadata.Edm.GlobalItem
    {
        internal EdmType() { }
        public bool Abstract { get { throw null; } }
        public System.Data.Metadata.Edm.EdmType BaseType { get { throw null; } }
        public virtual string FullName { get { throw null; } }
        public string Name { get { throw null; } }
        public string NamespaceName { get { throw null; } }
        public System.Data.Metadata.Edm.CollectionType GetCollectionType() { throw null; }
        public override string ToString() { throw null; }
    }
    public sealed partial class EntityContainer : System.Data.Metadata.Edm.GlobalItem
    {
        internal EntityContainer() { }
        public System.Data.Metadata.Edm.ReadOnlyMetadataCollection<System.Data.Metadata.Edm.EntitySetBase> BaseEntitySets { get { throw null; } }
        public override System.Data.Metadata.Edm.BuiltInTypeKind BuiltInTypeKind { get { throw null; } }
        public System.Data.Metadata.Edm.ReadOnlyMetadataCollection<System.Data.Metadata.Edm.EdmFunction> FunctionImports { get { throw null; } }
        public string Name { get { throw null; } }
        public System.Data.Metadata.Edm.EntitySet GetEntitySetByName(string name, bool ignoreCase) { throw null; }
        public System.Data.Metadata.Edm.RelationshipSet GetRelationshipSetByName(string name, bool ignoreCase) { throw null; }
        public override string ToString() { throw null; }
        public bool TryGetEntitySetByName(string name, bool ignoreCase, out System.Data.Metadata.Edm.EntitySet entitySet) { throw null; }
        public bool TryGetRelationshipSetByName(string name, bool ignoreCase, out System.Data.Metadata.Edm.RelationshipSet relationshipSet) { throw null; }
    }
    public partial class EntitySet : System.Data.Metadata.Edm.EntitySetBase
    {
        internal EntitySet() { }
        public override System.Data.Metadata.Edm.BuiltInTypeKind BuiltInTypeKind { get { throw null; } }
        public new System.Data.Metadata.Edm.EntityType ElementType { get { throw null; } }
    }
    public abstract partial class EntitySetBase : System.Data.Metadata.Edm.MetadataItem
    {
        internal EntitySetBase() { }
        public override System.Data.Metadata.Edm.BuiltInTypeKind BuiltInTypeKind { get { throw null; } }
        public System.Data.Metadata.Edm.EntityTypeBase ElementType { get { throw null; } }
        public System.Data.Metadata.Edm.EntityContainer EntityContainer { get { throw null; } }
        public string Name { get { throw null; } }
        public override string ToString() { throw null; }
    }
    public partial class EntityType : System.Data.Metadata.Edm.EntityTypeBase
    {
        internal EntityType() { }
        public override System.Data.Metadata.Edm.BuiltInTypeKind BuiltInTypeKind { get { throw null; } }
        public System.Data.Metadata.Edm.ReadOnlyMetadataCollection<System.Data.Metadata.Edm.NavigationProperty> NavigationProperties { get { throw null; } }
        public System.Data.Metadata.Edm.ReadOnlyMetadataCollection<System.Data.Metadata.Edm.EdmProperty> Properties { get { throw null; } }
        public System.Data.Metadata.Edm.RefType GetReferenceType() { throw null; }
    }
    public abstract partial class EntityTypeBase : System.Data.Metadata.Edm.StructuralType
    {
        internal EntityTypeBase() { }
        public System.Data.Metadata.Edm.ReadOnlyMetadataCollection<System.Data.Metadata.Edm.EdmMember> KeyMembers { get { throw null; } }
    }
    public sealed partial class EnumMember : System.Data.Metadata.Edm.MetadataItem
    {
        internal EnumMember() { }
        public override System.Data.Metadata.Edm.BuiltInTypeKind BuiltInTypeKind { get { throw null; } }
        public string Name { get { throw null; } }
        public object Value { get { throw null; } }
        public override string ToString() { throw null; }
    }
    public partial class EnumType : System.Data.Metadata.Edm.SimpleType
    {
        internal EnumType() { }
        public override System.Data.Metadata.Edm.BuiltInTypeKind BuiltInTypeKind { get { throw null; } }
        public bool IsFlags { get { throw null; } }
        public System.Data.Metadata.Edm.ReadOnlyMetadataCollection<System.Data.Metadata.Edm.EnumMember> Members { get { throw null; } }
        public System.Data.Metadata.Edm.PrimitiveType UnderlyingType { get { throw null; } }
    }
    [System.Diagnostics.DebuggerDisplayAttribute("{Name,nq}={Value}")]
    public sealed partial class Facet : System.Data.Metadata.Edm.MetadataItem
    {
        internal Facet() { }
        public override System.Data.Metadata.Edm.BuiltInTypeKind BuiltInTypeKind { get { throw null; } }
        public System.Data.Metadata.Edm.FacetDescription Description { get { throw null; } }
        public System.Data.Metadata.Edm.EdmType FacetType { get { throw null; } }
        public bool IsUnbounded { get { throw null; } }
        public string Name { get { throw null; } }
        public object Value { get { throw null; } }
        public override string ToString() { throw null; }
    }
    public sealed partial class FacetDescription
    {
        internal FacetDescription() { }
        public object DefaultValue { get { throw null; } }
        public string FacetName { get { throw null; } }
        public System.Data.Metadata.Edm.EdmType FacetType { get { throw null; } }
        public bool IsConstant { get { throw null; } }
        public bool IsRequired { get { throw null; } }
        public System.Nullable<int> MaxValue { get { throw null; } }
        public System.Nullable<int> MinValue { get { throw null; } }
        public override string ToString() { throw null; }
    }
    public sealed partial class FunctionParameter : System.Data.Metadata.Edm.MetadataItem
    {
        internal FunctionParameter() { }
        public override System.Data.Metadata.Edm.BuiltInTypeKind BuiltInTypeKind { get { throw null; } }
        public System.Data.Metadata.Edm.EdmFunction DeclaringFunction { get { throw null; } }
        public System.Data.Metadata.Edm.ParameterMode Mode { get { throw null; } }
        public string Name { get { throw null; } }
        public System.Data.Metadata.Edm.TypeUsage TypeUsage { get { throw null; } }
        public override string ToString() { throw null; }
    }
    public abstract partial class GlobalItem : System.Data.Metadata.Edm.MetadataItem
    {
        internal GlobalItem() { }
    }
    [System.CLSCompliantAttribute(false)]
    public abstract partial class ItemCollection : System.Data.Metadata.Edm.ReadOnlyMetadataCollection<System.Data.Metadata.Edm.GlobalItem>
    {
        internal ItemCollection() { }
        public System.Data.Metadata.Edm.DataSpace DataSpace { get { throw null; } }
        public System.Data.Metadata.Edm.EntityContainer GetEntityContainer(string name) { throw null; }
        public System.Data.Metadata.Edm.EntityContainer GetEntityContainer(string name, bool ignoreCase) { throw null; }
        protected static System.Collections.ObjectModel.ReadOnlyCollection<System.Data.Metadata.Edm.EdmFunction> GetFunctions(System.Collections.Generic.Dictionary<string, System.Collections.ObjectModel.ReadOnlyCollection<System.Data.Metadata.Edm.EdmFunction>> functionCollection, string functionName, bool ignoreCase) { throw null; }
        public System.Collections.ObjectModel.ReadOnlyCollection<System.Data.Metadata.Edm.EdmFunction> GetFunctions(string functionName) { throw null; }
        public System.Collections.ObjectModel.ReadOnlyCollection<System.Data.Metadata.Edm.EdmFunction> GetFunctions(string functionName, bool ignoreCase) { throw null; }
        public virtual System.Collections.ObjectModel.ReadOnlyCollection<T> GetItems<T>() where T : System.Data.Metadata.Edm.GlobalItem { throw null; }
        public T GetItem<T>(string identity) where T : System.Data.Metadata.Edm.GlobalItem { throw null; }
        public T GetItem<T>(string identity, bool ignoreCase) where T : System.Data.Metadata.Edm.GlobalItem { throw null; }
        public System.Data.Metadata.Edm.EdmType GetType(string name, string namespaceName) { throw null; }
        public System.Data.Metadata.Edm.EdmType GetType(string name, string namespaceName, bool ignoreCase) { throw null; }
        public bool TryGetEntityContainer(string name, bool ignoreCase, out System.Data.Metadata.Edm.EntityContainer entityContainer) { throw null; }
        public bool TryGetEntityContainer(string name, out System.Data.Metadata.Edm.EntityContainer entityContainer) { throw null; }
        public bool TryGetItem<T>(string identity, bool ignoreCase, out T item) where T : System.Data.Metadata.Edm.GlobalItem { throw null; }
        public bool TryGetItem<T>(string identity, out T item) where T : System.Data.Metadata.Edm.GlobalItem { throw null; }
        public bool TryGetType(string name, string namespaceName, bool ignoreCase, out System.Data.Metadata.Edm.EdmType type) { throw null; }
        public bool TryGetType(string name, string namespaceName, out System.Data.Metadata.Edm.EdmType type) { throw null; }
    }
    public abstract partial class MetadataItem
    {
        internal MetadataItem() { }
        public abstract System.Data.Metadata.Edm.BuiltInTypeKind BuiltInTypeKind { get; }
        public System.Data.Metadata.Edm.Documentation Documentation { get { throw null; } set { } }
        public System.Data.Metadata.Edm.ReadOnlyMetadataCollection<System.Data.Metadata.Edm.MetadataProperty> MetadataProperties { get { throw null; } }
        public static System.Data.Metadata.Edm.EdmType GetBuiltInType(System.Data.Metadata.Edm.BuiltInTypeKind builtInTypeKind) { throw null; }
        public static System.Collections.ObjectModel.ReadOnlyCollection<System.Data.Metadata.Edm.FacetDescription> GetGeneralFacetDescriptions() { throw null; }
    }
    public sealed partial class MetadataProperty : System.Data.Metadata.Edm.MetadataItem
    {
        internal MetadataProperty() { }
        public override System.Data.Metadata.Edm.BuiltInTypeKind BuiltInTypeKind { get { throw null; } }
        public string Name { get { throw null; } }
        public System.Data.Metadata.Edm.PropertyKind PropertyKind { get { throw null; } }
        public System.Data.Metadata.Edm.TypeUsage TypeUsage { get { throw null; } }
        public object Value { get { throw null; } }
    }
    public sealed partial class MetadataWorkspace
    {
        public static readonly double MaximumEdmVersionSupported;
        public MetadataWorkspace() { }
        public MetadataWorkspace(System.Collections.Generic.IEnumerable<string> paths, System.Collections.Generic.IEnumerable<System.Reflection.Assembly> assembliesToConsider) { }
        public static void ClearCache() { }
        public System.Data.Common.EntitySql.EntitySqlParser CreateEntitySqlParser() { throw null; }
        public System.Data.Common.CommandTrees.DbQueryCommandTree CreateQueryCommandTree(System.Data.Common.CommandTrees.DbExpression query) { throw null; }
        public System.Data.Metadata.Edm.EnumType GetEdmSpaceType(System.Data.Metadata.Edm.EnumType objectSpaceType) { throw null; }
        public System.Data.Metadata.Edm.StructuralType GetEdmSpaceType(System.Data.Metadata.Edm.StructuralType objectSpaceType) { throw null; }
        public System.Data.Metadata.Edm.EntityContainer GetEntityContainer(string name, bool ignoreCase, System.Data.Metadata.Edm.DataSpace dataSpace) { throw null; }
        public System.Data.Metadata.Edm.EntityContainer GetEntityContainer(string name, System.Data.Metadata.Edm.DataSpace dataSpace) { throw null; }
        public System.Collections.ObjectModel.ReadOnlyCollection<System.Data.Metadata.Edm.EdmFunction> GetFunctions(string name, string namespaceName, System.Data.Metadata.Edm.DataSpace dataSpace) { throw null; }
        public System.Collections.ObjectModel.ReadOnlyCollection<System.Data.Metadata.Edm.EdmFunction> GetFunctions(string name, string namespaceName, System.Data.Metadata.Edm.DataSpace dataSpace, bool ignoreCase) { throw null; }
        [System.CLSCompliantAttribute(false)]
        public System.Data.Metadata.Edm.ItemCollection GetItemCollection(System.Data.Metadata.Edm.DataSpace dataSpace) { throw null; }
        public System.Collections.ObjectModel.ReadOnlyCollection<System.Data.Metadata.Edm.GlobalItem> GetItems(System.Data.Metadata.Edm.DataSpace dataSpace) { throw null; }
        public System.Collections.ObjectModel.ReadOnlyCollection<T> GetItems<T>(System.Data.Metadata.Edm.DataSpace dataSpace) where T : System.Data.Metadata.Edm.GlobalItem { throw null; }
        public T GetItem<T>(string identity, bool ignoreCase, System.Data.Metadata.Edm.DataSpace dataSpace) where T : System.Data.Metadata.Edm.GlobalItem { throw null; }
        public T GetItem<T>(string identity, System.Data.Metadata.Edm.DataSpace dataSpace) where T : System.Data.Metadata.Edm.GlobalItem { throw null; }
        public System.Data.Metadata.Edm.EnumType GetObjectSpaceType(System.Data.Metadata.Edm.EnumType edmSpaceType) { throw null; }
        public System.Data.Metadata.Edm.StructuralType GetObjectSpaceType(System.Data.Metadata.Edm.StructuralType edmSpaceType) { throw null; }
        public System.Collections.ObjectModel.ReadOnlyCollection<System.Data.Metadata.Edm.PrimitiveType> GetPrimitiveTypes(System.Data.Metadata.Edm.DataSpace dataSpace) { throw null; }
        public System.Collections.ObjectModel.ReadOnlyCollection<System.Data.Metadata.Edm.EdmMember> GetRelevantMembersForUpdate(System.Data.Metadata.Edm.EntitySetBase entitySet, System.Data.Metadata.Edm.EntityTypeBase entityType, bool partialUpdateSupported) { throw null; }
        [System.ObsoleteAttribute("Use MetadataWorkspace.GetRelevantMembersForUpdate(EntitySetBase, EntityTypeBase, bool) instead")]
        public System.Collections.Generic.IEnumerable<System.Data.Metadata.Edm.EdmMember> GetRequiredOriginalValueMembers(System.Data.Metadata.Edm.EntitySetBase entitySet, System.Data.Metadata.Edm.EntityTypeBase entityType) { throw null; }
        public System.Data.Metadata.Edm.EdmType GetType(string name, string namespaceName, bool ignoreCase, System.Data.Metadata.Edm.DataSpace dataSpace) { throw null; }
        public System.Data.Metadata.Edm.EdmType GetType(string name, string namespaceName, System.Data.Metadata.Edm.DataSpace dataSpace) { throw null; }
        public void LoadFromAssembly(System.Reflection.Assembly assembly) { }
        public void LoadFromAssembly(System.Reflection.Assembly assembly, System.Action<string> logLoadMessage) { }
        [System.CLSCompliantAttribute(false)]
        public void RegisterItemCollection(System.Data.Metadata.Edm.ItemCollection collection) { }
        public bool TryGetEdmSpaceType(System.Data.Metadata.Edm.EnumType objectSpaceType, out System.Data.Metadata.Edm.EnumType edmSpaceType) { throw null; }
        public bool TryGetEdmSpaceType(System.Data.Metadata.Edm.StructuralType objectSpaceType, out System.Data.Metadata.Edm.StructuralType edmSpaceType) { throw null; }
        public bool TryGetEntityContainer(string name, bool ignoreCase, System.Data.Metadata.Edm.DataSpace dataSpace, out System.Data.Metadata.Edm.EntityContainer entityContainer) { throw null; }
        public bool TryGetEntityContainer(string name, System.Data.Metadata.Edm.DataSpace dataSpace, out System.Data.Metadata.Edm.EntityContainer entityContainer) { throw null; }
        [System.CLSCompliantAttribute(false)]
        public bool TryGetItemCollection(System.Data.Metadata.Edm.DataSpace dataSpace, out System.Data.Metadata.Edm.ItemCollection collection) { throw null; }
        public bool TryGetItem<T>(string identity, bool ignoreCase, System.Data.Metadata.Edm.DataSpace dataSpace, out T item) where T : System.Data.Metadata.Edm.GlobalItem { throw null; }
        public bool TryGetItem<T>(string identity, System.Data.Metadata.Edm.DataSpace space, out T item) where T : System.Data.Metadata.Edm.GlobalItem { throw null; }
        public bool TryGetObjectSpaceType(System.Data.Metadata.Edm.EnumType edmSpaceType, out System.Data.Metadata.Edm.EnumType objectSpaceType) { throw null; }
        public bool TryGetObjectSpaceType(System.Data.Metadata.Edm.StructuralType edmSpaceType, out System.Data.Metadata.Edm.StructuralType objectSpaceType) { throw null; }
        public bool TryGetType(string name, string namespaceName, bool ignoreCase, System.Data.Metadata.Edm.DataSpace dataSpace, out System.Data.Metadata.Edm.EdmType type) { throw null; }
        public bool TryGetType(string name, string namespaceName, System.Data.Metadata.Edm.DataSpace dataSpace, out System.Data.Metadata.Edm.EdmType type) { throw null; }
    }
    public sealed partial class NavigationProperty : System.Data.Metadata.Edm.EdmMember
    {
        internal NavigationProperty() { }
        public override System.Data.Metadata.Edm.BuiltInTypeKind BuiltInTypeKind { get { throw null; } }
        public System.Data.Metadata.Edm.RelationshipEndMember FromEndMember { get { throw null; } }
        public System.Data.Metadata.Edm.RelationshipType RelationshipType { get { throw null; } }
        public System.Data.Metadata.Edm.RelationshipEndMember ToEndMember { get { throw null; } }
        public System.Collections.Generic.IEnumerable<System.Data.Metadata.Edm.EdmProperty> GetDependentProperties() { throw null; }
    }
    [System.CLSCompliantAttribute(false)]
    public sealed partial class ObjectItemCollection : System.Data.Metadata.Edm.ItemCollection
    {
        public ObjectItemCollection() { }
        public System.Type GetClrType(System.Data.Metadata.Edm.EnumType objectSpaceType) { throw null; }
        public System.Type GetClrType(System.Data.Metadata.Edm.StructuralType objectSpaceType) { throw null; }
        public override System.Collections.ObjectModel.ReadOnlyCollection<T> GetItems<T>() { throw null; }
        public System.Collections.Generic.IEnumerable<System.Data.Metadata.Edm.PrimitiveType> GetPrimitiveTypes() { throw null; }
        public void LoadFromAssembly(System.Reflection.Assembly assembly) { }
        public void LoadFromAssembly(System.Reflection.Assembly assembly, System.Data.Metadata.Edm.EdmItemCollection edmItemCollection) { }
        public void LoadFromAssembly(System.Reflection.Assembly assembly, System.Data.Metadata.Edm.EdmItemCollection edmItemCollection, System.Action<string> logLoadMessage) { }
        public bool TryGetClrType(System.Data.Metadata.Edm.EnumType objectSpaceType, out System.Type clrType) { throw null; }
        public bool TryGetClrType(System.Data.Metadata.Edm.StructuralType objectSpaceType, out System.Type clrType) { throw null; }
    }
    public enum OperationAction
    {
        Cascade = 1,
        None = 0,
        Restrict = 2,
    }
    public enum ParameterMode
    {
        In = 0,
        InOut = 2,
        Out = 1,
        ReturnValue = 3,
    }
    public enum ParameterTypeSemantics
    {
        AllowImplicitConversion = 0,
        AllowImplicitPromotion = 1,
        ExactMatchOnly = 2,
    }
    public sealed partial class PrimitiveType : System.Data.Metadata.Edm.SimpleType
    {
        internal PrimitiveType() { }
        public override System.Data.Metadata.Edm.BuiltInTypeKind BuiltInTypeKind { get { throw null; } }
        public System.Type ClrEquivalentType { get { throw null; } }
        public System.Collections.ObjectModel.ReadOnlyCollection<System.Data.Metadata.Edm.FacetDescription> FacetDescriptions { get { throw null; } }
        public System.Data.Metadata.Edm.PrimitiveTypeKind PrimitiveTypeKind { get { throw null; } }
        public System.Data.Metadata.Edm.EdmType GetEdmPrimitiveType() { throw null; }
        public static System.Data.Metadata.Edm.PrimitiveType GetEdmPrimitiveType(System.Data.Metadata.Edm.PrimitiveTypeKind primitiveTypeKind) { throw null; }
        public static System.Collections.ObjectModel.ReadOnlyCollection<System.Data.Metadata.Edm.PrimitiveType> GetEdmPrimitiveTypes() { throw null; }
    }
    public enum PrimitiveTypeKind
    {
        Binary = 0,
        Boolean = 1,
        Byte = 2,
        DateTime = 3,
        DateTimeOffset = 14,
        Decimal = 4,
        Double = 5,
        Geography = 16,
        GeographyCollection = 30,
        GeographyLineString = 25,
        GeographyMultiLineString = 28,
        GeographyMultiPoint = 27,
        GeographyMultiPolygon = 29,
        GeographyPoint = 24,
        GeographyPolygon = 26,
        Geometry = 15,
        GeometryCollection = 23,
        GeometryLineString = 18,
        GeometryMultiLineString = 21,
        GeometryMultiPoint = 20,
        GeometryMultiPolygon = 22,
        GeometryPoint = 17,
        GeometryPolygon = 19,
        Guid = 6,
        Int16 = 9,
        Int32 = 10,
        Int64 = 11,
        SByte = 8,
        Single = 7,
        String = 12,
        Time = 13,
    }
    public enum PropertyKind
    {
        Extended = 1,
        System = 0,
    }
    public partial class ReadOnlyMetadataCollection<T> : System.Collections.ObjectModel.ReadOnlyCollection<T> where T : System.Data.Metadata.Edm.MetadataItem
    {
        internal ReadOnlyMetadataCollection() : base (default(System.Collections.Generic.IList<T>)) { }
        public bool IsReadOnly { get { throw null; } }
        public virtual T this[string identity] { get { throw null; } }
        public virtual bool Contains(string identity) { throw null; }
        public new System.Data.Metadata.Edm.ReadOnlyMetadataCollection<T>.Enumerator GetEnumerator() { throw null; }
        public virtual T GetValue(string identity, bool ignoreCase) { throw null; }
        public virtual new int IndexOf(T value) { throw null; }
        public virtual bool TryGetValue(string identity, bool ignoreCase, out T item) { throw null; }
        [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
        public partial struct Enumerator : System.Collections.Generic.IEnumerator<T>, System.Collections.IEnumerator, System.IDisposable
        {
            private T _current;
            private object _dummy;
            private int _dummyPrimitive;
            public T Current { get { throw null; } }
            object System.Collections.IEnumerator.Current { get { throw null; } }
            public void Dispose() { }
            public bool MoveNext() { throw null; }
            public void Reset() { }
        }
    }
    public sealed partial class ReferentialConstraint : System.Data.Metadata.Edm.MetadataItem
    {
        internal ReferentialConstraint() { }
        public override System.Data.Metadata.Edm.BuiltInTypeKind BuiltInTypeKind { get { throw null; } }
        public System.Data.Metadata.Edm.ReadOnlyMetadataCollection<System.Data.Metadata.Edm.EdmProperty> FromProperties { get { throw null; } }
        public System.Data.Metadata.Edm.RelationshipEndMember FromRole { get { throw null; } }
        public System.Data.Metadata.Edm.ReadOnlyMetadataCollection<System.Data.Metadata.Edm.EdmProperty> ToProperties { get { throw null; } }
        public System.Data.Metadata.Edm.RelationshipEndMember ToRole { get { throw null; } }
        public override string ToString() { throw null; }
    }
    public sealed partial class RefType : System.Data.Metadata.Edm.EdmType
    {
        internal RefType() { }
        public override System.Data.Metadata.Edm.BuiltInTypeKind BuiltInTypeKind { get { throw null; } }
        public System.Data.Metadata.Edm.EntityTypeBase ElementType { get { throw null; } }
    }
    public abstract partial class RelationshipEndMember : System.Data.Metadata.Edm.EdmMember
    {
        internal RelationshipEndMember() { }
        public System.Data.Metadata.Edm.OperationAction DeleteBehavior { get { throw null; } }
        public System.Data.Metadata.Edm.RelationshipMultiplicity RelationshipMultiplicity { get { throw null; } }
        public System.Data.Metadata.Edm.EntityType GetEntityType() { throw null; }
    }
    public enum RelationshipMultiplicity
    {
        Many = 2,
        One = 1,
        ZeroOrOne = 0,
    }
    public abstract partial class RelationshipSet : System.Data.Metadata.Edm.EntitySetBase
    {
        internal RelationshipSet() { }
        public override System.Data.Metadata.Edm.BuiltInTypeKind BuiltInTypeKind { get { throw null; } }
        public new System.Data.Metadata.Edm.RelationshipType ElementType { get { throw null; } }
    }
    public abstract partial class RelationshipType : System.Data.Metadata.Edm.EntityTypeBase
    {
        internal RelationshipType() { }
        public System.Data.Metadata.Edm.ReadOnlyMetadataCollection<System.Data.Metadata.Edm.RelationshipEndMember> RelationshipEndMembers { get { throw null; } }
    }
    public sealed partial class RowType : System.Data.Metadata.Edm.StructuralType
    {
        internal RowType() { }
        public override System.Data.Metadata.Edm.BuiltInTypeKind BuiltInTypeKind { get { throw null; } }
        public System.Data.Metadata.Edm.ReadOnlyMetadataCollection<System.Data.Metadata.Edm.EdmProperty> Properties { get { throw null; } }
    }
    public abstract partial class SimpleType : System.Data.Metadata.Edm.EdmType
    {
        internal SimpleType() { }
    }
    public enum StoreGeneratedPattern
    {
        Computed = 2,
        Identity = 1,
        None = 0,
    }
    [System.CLSCompliantAttribute(false)]
    public sealed partial class StoreItemCollection : System.Data.Metadata.Edm.ItemCollection
    {
        public StoreItemCollection(System.Collections.Generic.IEnumerable<System.Xml.XmlReader> xmlReaders) { }
        public StoreItemCollection(params string[] filePaths) { }
        public double StoreSchemaVersion { get { throw null; } }
        public System.Collections.ObjectModel.ReadOnlyCollection<System.Data.Metadata.Edm.PrimitiveType> GetPrimitiveTypes() { throw null; }
    }
    public abstract partial class StructuralType : System.Data.Metadata.Edm.EdmType
    {
        internal StructuralType() { }
        public System.Data.Metadata.Edm.ReadOnlyMetadataCollection<System.Data.Metadata.Edm.EdmMember> Members { get { throw null; } }
    }
    [System.Diagnostics.DebuggerDisplayAttribute("EdmType={EdmType}, Facets.Count={Facets.Count}")]
    public sealed partial class TypeUsage : System.Data.Metadata.Edm.MetadataItem
    {
        internal TypeUsage() { }
        public override System.Data.Metadata.Edm.BuiltInTypeKind BuiltInTypeKind { get { throw null; } }
        public System.Data.Metadata.Edm.EdmType EdmType { get { throw null; } }
        public System.Data.Metadata.Edm.ReadOnlyMetadataCollection<System.Data.Metadata.Edm.Facet> Facets { get { throw null; } }
        public static System.Data.Metadata.Edm.TypeUsage CreateBinaryTypeUsage(System.Data.Metadata.Edm.PrimitiveType primitiveType, bool isFixedLength) { throw null; }
        public static System.Data.Metadata.Edm.TypeUsage CreateBinaryTypeUsage(System.Data.Metadata.Edm.PrimitiveType primitiveType, bool isFixedLength, int maxLength) { throw null; }
        public static System.Data.Metadata.Edm.TypeUsage CreateDateTimeOffsetTypeUsage(System.Data.Metadata.Edm.PrimitiveType primitiveType, System.Nullable<byte> precision) { throw null; }
        public static System.Data.Metadata.Edm.TypeUsage CreateDateTimeTypeUsage(System.Data.Metadata.Edm.PrimitiveType primitiveType, System.Nullable<byte> precision) { throw null; }
        public static System.Data.Metadata.Edm.TypeUsage CreateDecimalTypeUsage(System.Data.Metadata.Edm.PrimitiveType primitiveType) { throw null; }
        public static System.Data.Metadata.Edm.TypeUsage CreateDecimalTypeUsage(System.Data.Metadata.Edm.PrimitiveType primitiveType, byte precision, byte scale) { throw null; }
        public static System.Data.Metadata.Edm.TypeUsage CreateDefaultTypeUsage(System.Data.Metadata.Edm.EdmType edmType) { throw null; }
        public static System.Data.Metadata.Edm.TypeUsage CreateStringTypeUsage(System.Data.Metadata.Edm.PrimitiveType primitiveType, bool isUnicode, bool isFixedLength) { throw null; }
        public static System.Data.Metadata.Edm.TypeUsage CreateStringTypeUsage(System.Data.Metadata.Edm.PrimitiveType primitiveType, bool isUnicode, bool isFixedLength, int maxLength) { throw null; }
        public static System.Data.Metadata.Edm.TypeUsage CreateTimeTypeUsage(System.Data.Metadata.Edm.PrimitiveType primitiveType, System.Nullable<byte> precision) { throw null; }
        public bool IsSubtypeOf(System.Data.Metadata.Edm.TypeUsage typeUsage) { throw null; }
        public override string ToString() { throw null; }
    }
}
namespace System.Data.Objects
{
    public sealed partial class CompiledQuery
    {
        internal CompiledQuery() { }
        public static System.Func<TArg0, TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TResult> Compile<TArg0, TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TResult>(System.Linq.Expressions.Expression<System.Func<TArg0, TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TResult>> query) where TArg0 : System.Data.Objects.ObjectContext { throw null; }
        public static System.Func<TArg0, TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TResult> Compile<TArg0, TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TResult>(System.Linq.Expressions.Expression<System.Func<TArg0, TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TResult>> query) where TArg0 : System.Data.Objects.ObjectContext { throw null; }
        public static System.Func<TArg0, TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TResult> Compile<TArg0, TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TResult>(System.Linq.Expressions.Expression<System.Func<TArg0, TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TResult>> query) where TArg0 : System.Data.Objects.ObjectContext { throw null; }
        public static System.Func<TArg0, TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TResult> Compile<TArg0, TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TResult>(System.Linq.Expressions.Expression<System.Func<TArg0, TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TResult>> query) where TArg0 : System.Data.Objects.ObjectContext { throw null; }
        public static System.Func<TArg0, TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TResult> Compile<TArg0, TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TResult>(System.Linq.Expressions.Expression<System.Func<TArg0, TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TResult>> query) where TArg0 : System.Data.Objects.ObjectContext { throw null; }
        public static System.Func<TArg0, TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TResult> Compile<TArg0, TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TResult>(System.Linq.Expressions.Expression<System.Func<TArg0, TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TResult>> query) where TArg0 : System.Data.Objects.ObjectContext { throw null; }
        public static System.Func<TArg0, TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TResult> Compile<TArg0, TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TResult>(System.Linq.Expressions.Expression<System.Func<TArg0, TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TResult>> query) where TArg0 : System.Data.Objects.ObjectContext { throw null; }
        public static System.Func<TArg0, TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TResult> Compile<TArg0, TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TResult>(System.Linq.Expressions.Expression<System.Func<TArg0, TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TResult>> query) where TArg0 : System.Data.Objects.ObjectContext { throw null; }
        public static System.Func<TArg0, TResult> Compile<TArg0, TResult>(System.Linq.Expressions.Expression<System.Func<TArg0, TResult>> query) where TArg0 : System.Data.Objects.ObjectContext { throw null; }
        public static System.Func<TArg0, TArg1, TResult> Compile<TArg0, TArg1, TResult>(System.Linq.Expressions.Expression<System.Func<TArg0, TArg1, TResult>> query) where TArg0 : System.Data.Objects.ObjectContext { throw null; }
        public static System.Func<TArg0, TArg1, TArg2, TResult> Compile<TArg0, TArg1, TArg2, TResult>(System.Linq.Expressions.Expression<System.Func<TArg0, TArg1, TArg2, TResult>> query) where TArg0 : System.Data.Objects.ObjectContext { throw null; }
        public static System.Func<TArg0, TArg1, TArg2, TArg3, TResult> Compile<TArg0, TArg1, TArg2, TArg3, TResult>(System.Linq.Expressions.Expression<System.Func<TArg0, TArg1, TArg2, TArg3, TResult>> query) where TArg0 : System.Data.Objects.ObjectContext { throw null; }
        public static System.Func<TArg0, TArg1, TArg2, TArg3, TArg4, TResult> Compile<TArg0, TArg1, TArg2, TArg3, TArg4, TResult>(System.Linq.Expressions.Expression<System.Func<TArg0, TArg1, TArg2, TArg3, TArg4, TResult>> query) where TArg0 : System.Data.Objects.ObjectContext { throw null; }
        public static System.Func<TArg0, TArg1, TArg2, TArg3, TArg4, TArg5, TResult> Compile<TArg0, TArg1, TArg2, TArg3, TArg4, TArg5, TResult>(System.Linq.Expressions.Expression<System.Func<TArg0, TArg1, TArg2, TArg3, TArg4, TArg5, TResult>> query) where TArg0 : System.Data.Objects.ObjectContext { throw null; }
        public static System.Func<TArg0, TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TResult> Compile<TArg0, TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TResult>(System.Linq.Expressions.Expression<System.Func<TArg0, TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TResult>> query) where TArg0 : System.Data.Objects.ObjectContext { throw null; }
        public static System.Func<TArg0, TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TResult> Compile<TArg0, TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TResult>(System.Linq.Expressions.Expression<System.Func<TArg0, TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TResult>> query) where TArg0 : System.Data.Objects.ObjectContext { throw null; }
    }
    public abstract partial class CurrentValueRecord : System.Data.Objects.DbUpdatableDataRecord
    {
        internal CurrentValueRecord() { }
    }
    public abstract partial class DbUpdatableDataRecord : System.Data.Common.DbDataRecord, System.Data.IDataRecord, System.Data.IExtendedDataRecord
    {
        internal DbUpdatableDataRecord() { }
        public virtual System.Data.Common.DataRecordInfo DataRecordInfo { get { throw null; } }
        public override int FieldCount { get { throw null; } }
        public override object this[int ordinal] { get { throw null; } }
        public override object this[string name] { get { throw null; } }
        public override bool GetBoolean(int ordinal) { throw null; }
        public override byte GetByte(int ordinal) { throw null; }
        public override long GetBytes(int ordinal, long dataIndex, byte[] buffer, int bufferIndex, int length) { throw null; }
        public override char GetChar(int ordinal) { throw null; }
        public override long GetChars(int ordinal, long dataIndex, char[] buffer, int bufferIndex, int length) { throw null; }
        public System.Data.Common.DbDataReader GetDataReader(int i) { throw null; }
        public System.Data.Common.DbDataRecord GetDataRecord(int ordinal) { throw null; }
        public override string GetDataTypeName(int ordinal) { throw null; }
        public override System.DateTime GetDateTime(int ordinal) { throw null; }
        protected override System.Data.Common.DbDataReader GetDbDataReader(int ordinal) { throw null; }
        public override decimal GetDecimal(int ordinal) { throw null; }
        public override double GetDouble(int ordinal) { throw null; }
        public override System.Type GetFieldType(int ordinal) { throw null; }
        public override float GetFloat(int ordinal) { throw null; }
        public override System.Guid GetGuid(int ordinal) { throw null; }
        public override short GetInt16(int ordinal) { throw null; }
        public override int GetInt32(int ordinal) { throw null; }
        public override long GetInt64(int ordinal) { throw null; }
        public override string GetName(int ordinal) { throw null; }
        public override int GetOrdinal(string name) { throw null; }
        protected abstract object GetRecordValue(int ordinal);
        public override string GetString(int ordinal) { throw null; }
        public override object GetValue(int ordinal) { throw null; }
        public override int GetValues(object[] values) { throw null; }
        public override bool IsDBNull(int ordinal) { throw null; }
        public void SetBoolean(int ordinal, bool value) { }
        public void SetByte(int ordinal, byte value) { }
        public void SetChar(int ordinal, char value) { }
        public void SetDataRecord(int ordinal, System.Data.IDataRecord value) { }
        public void SetDateTime(int ordinal, System.DateTime value) { }
        public void SetDBNull(int ordinal) { }
        public void SetDecimal(int ordinal, decimal value) { }
        public void SetDouble(int ordinal, double value) { }
        public void SetFloat(int ordinal, float value) { }
        public void SetGuid(int ordinal, System.Guid value) { }
        public void SetInt16(int ordinal, short value) { }
        public void SetInt32(int ordinal, int value) { }
        public void SetInt64(int ordinal, long value) { }
        protected abstract void SetRecordValue(int ordinal, object value);
        public void SetString(int ordinal, string value) { }
        public void SetValue(int ordinal, object value) { }
        public int SetValues(params object[] values) { throw null; }
        System.Data.IDataReader System.Data.IDataRecord.GetData(int ordinal) { throw null; }
    }
    public static partial class EntityFunctions
    {
        [System.Data.Objects.DataClasses.EdmFunctionAttribute("Edm", "AddDays")]
        public static System.Nullable<System.DateTimeOffset> AddDays(System.Nullable<System.DateTimeOffset> dateValue, System.Nullable<int> addValue) { throw null; }
        [System.Data.Objects.DataClasses.EdmFunctionAttribute("Edm", "AddDays")]
        public static System.Nullable<System.DateTime> AddDays(System.Nullable<System.DateTime> dateValue, System.Nullable<int> addValue) { throw null; }
        [System.Data.Objects.DataClasses.EdmFunctionAttribute("Edm", "AddHours")]
        public static System.Nullable<System.DateTimeOffset> AddHours(System.Nullable<System.DateTimeOffset> timeValue, System.Nullable<int> addValue) { throw null; }
        [System.Data.Objects.DataClasses.EdmFunctionAttribute("Edm", "AddHours")]
        public static System.Nullable<System.DateTime> AddHours(System.Nullable<System.DateTime> timeValue, System.Nullable<int> addValue) { throw null; }
        [System.Data.Objects.DataClasses.EdmFunctionAttribute("Edm", "AddHours")]
        public static System.Nullable<System.TimeSpan> AddHours(System.Nullable<System.TimeSpan> timeValue, System.Nullable<int> addValue) { throw null; }
        [System.Data.Objects.DataClasses.EdmFunctionAttribute("Edm", "AddMicroseconds")]
        public static System.Nullable<System.DateTimeOffset> AddMicroseconds(System.Nullable<System.DateTimeOffset> timeValue, System.Nullable<int> addValue) { throw null; }
        [System.Data.Objects.DataClasses.EdmFunctionAttribute("Edm", "AddMicroseconds")]
        public static System.Nullable<System.DateTime> AddMicroseconds(System.Nullable<System.DateTime> timeValue, System.Nullable<int> addValue) { throw null; }
        [System.Data.Objects.DataClasses.EdmFunctionAttribute("Edm", "AddMicroseconds")]
        public static System.Nullable<System.TimeSpan> AddMicroseconds(System.Nullable<System.TimeSpan> timeValue, System.Nullable<int> addValue) { throw null; }
        [System.Data.Objects.DataClasses.EdmFunctionAttribute("Edm", "AddMilliseconds")]
        public static System.Nullable<System.DateTimeOffset> AddMilliseconds(System.Nullable<System.DateTimeOffset> timeValue, System.Nullable<int> addValue) { throw null; }
        [System.Data.Objects.DataClasses.EdmFunctionAttribute("Edm", "AddMilliseconds")]
        public static System.Nullable<System.DateTime> AddMilliseconds(System.Nullable<System.DateTime> timeValue, System.Nullable<int> addValue) { throw null; }
        [System.Data.Objects.DataClasses.EdmFunctionAttribute("Edm", "AddMilliseconds")]
        public static System.Nullable<System.TimeSpan> AddMilliseconds(System.Nullable<System.TimeSpan> timeValue, System.Nullable<int> addValue) { throw null; }
        [System.Data.Objects.DataClasses.EdmFunctionAttribute("Edm", "AddMinutes")]
        public static System.Nullable<System.DateTimeOffset> AddMinutes(System.Nullable<System.DateTimeOffset> timeValue, System.Nullable<int> addValue) { throw null; }
        [System.Data.Objects.DataClasses.EdmFunctionAttribute("Edm", "AddMinutes")]
        public static System.Nullable<System.DateTime> AddMinutes(System.Nullable<System.DateTime> timeValue, System.Nullable<int> addValue) { throw null; }
        [System.Data.Objects.DataClasses.EdmFunctionAttribute("Edm", "AddMinutes")]
        public static System.Nullable<System.TimeSpan> AddMinutes(System.Nullable<System.TimeSpan> timeValue, System.Nullable<int> addValue) { throw null; }
        [System.Data.Objects.DataClasses.EdmFunctionAttribute("Edm", "AddMonths")]
        public static System.Nullable<System.DateTimeOffset> AddMonths(System.Nullable<System.DateTimeOffset> dateValue, System.Nullable<int> addValue) { throw null; }
        [System.Data.Objects.DataClasses.EdmFunctionAttribute("Edm", "AddMonths")]
        public static System.Nullable<System.DateTime> AddMonths(System.Nullable<System.DateTime> dateValue, System.Nullable<int> addValue) { throw null; }
        [System.Data.Objects.DataClasses.EdmFunctionAttribute("Edm", "AddNanoseconds")]
        public static System.Nullable<System.DateTimeOffset> AddNanoseconds(System.Nullable<System.DateTimeOffset> timeValue, System.Nullable<int> addValue) { throw null; }
        [System.Data.Objects.DataClasses.EdmFunctionAttribute("Edm", "AddNanoseconds")]
        public static System.Nullable<System.DateTime> AddNanoseconds(System.Nullable<System.DateTime> timeValue, System.Nullable<int> addValue) { throw null; }
        [System.Data.Objects.DataClasses.EdmFunctionAttribute("Edm", "AddNanoseconds")]
        public static System.Nullable<System.TimeSpan> AddNanoseconds(System.Nullable<System.TimeSpan> timeValue, System.Nullable<int> addValue) { throw null; }
        [System.Data.Objects.DataClasses.EdmFunctionAttribute("Edm", "AddSeconds")]
        public static System.Nullable<System.DateTimeOffset> AddSeconds(System.Nullable<System.DateTimeOffset> timeValue, System.Nullable<int> addValue) { throw null; }
        [System.Data.Objects.DataClasses.EdmFunctionAttribute("Edm", "AddSeconds")]
        public static System.Nullable<System.DateTime> AddSeconds(System.Nullable<System.DateTime> timeValue, System.Nullable<int> addValue) { throw null; }
        [System.Data.Objects.DataClasses.EdmFunctionAttribute("Edm", "AddSeconds")]
        public static System.Nullable<System.TimeSpan> AddSeconds(System.Nullable<System.TimeSpan> timeValue, System.Nullable<int> addValue) { throw null; }
        [System.Data.Objects.DataClasses.EdmFunctionAttribute("Edm", "AddYears")]
        public static System.Nullable<System.DateTimeOffset> AddYears(System.Nullable<System.DateTimeOffset> dateValue, System.Nullable<int> addValue) { throw null; }
        [System.Data.Objects.DataClasses.EdmFunctionAttribute("Edm", "AddYears")]
        public static System.Nullable<System.DateTime> AddYears(System.Nullable<System.DateTime> dateValue, System.Nullable<int> addValue) { throw null; }
        public static string AsNonUnicode(string value) { throw null; }
        public static string AsUnicode(string value) { throw null; }
        [System.Data.Objects.DataClasses.EdmFunctionAttribute("Edm", "CreateDateTime")]
        public static System.Nullable<System.DateTime> CreateDateTime(System.Nullable<int> year, System.Nullable<int> month, System.Nullable<int> day, System.Nullable<int> hour, System.Nullable<int> minute, System.Nullable<double> second) { throw null; }
        [System.Data.Objects.DataClasses.EdmFunctionAttribute("Edm", "CreateDateTimeOffset")]
        public static System.Nullable<System.DateTimeOffset> CreateDateTimeOffset(System.Nullable<int> year, System.Nullable<int> month, System.Nullable<int> day, System.Nullable<int> hour, System.Nullable<int> minute, System.Nullable<double> second, System.Nullable<int> timeZoneOffset) { throw null; }
        [System.Data.Objects.DataClasses.EdmFunctionAttribute("Edm", "CreateTime")]
        public static System.Nullable<System.TimeSpan> CreateTime(System.Nullable<int> hour, System.Nullable<int> minute, System.Nullable<double> second) { throw null; }
        [System.Data.Objects.DataClasses.EdmFunctionAttribute("Edm", "DiffDays")]
        public static System.Nullable<int> DiffDays(System.Nullable<System.DateTimeOffset> dateValue1, System.Nullable<System.DateTimeOffset> dateValue2) { throw null; }
        [System.Data.Objects.DataClasses.EdmFunctionAttribute("Edm", "DiffDays")]
        public static System.Nullable<int> DiffDays(System.Nullable<System.DateTime> dateValue1, System.Nullable<System.DateTime> dateValue2) { throw null; }
        [System.Data.Objects.DataClasses.EdmFunctionAttribute("Edm", "DiffHours")]
        public static System.Nullable<int> DiffHours(System.Nullable<System.DateTimeOffset> timeValue1, System.Nullable<System.DateTimeOffset> timeValue2) { throw null; }
        [System.Data.Objects.DataClasses.EdmFunctionAttribute("Edm", "DiffHours")]
        public static System.Nullable<int> DiffHours(System.Nullable<System.DateTime> timeValue1, System.Nullable<System.DateTime> timeValue2) { throw null; }
        [System.Data.Objects.DataClasses.EdmFunctionAttribute("Edm", "DiffHours")]
        public static System.Nullable<int> DiffHours(System.Nullable<System.TimeSpan> timeValue1, System.Nullable<System.TimeSpan> timeValue2) { throw null; }
        [System.Data.Objects.DataClasses.EdmFunctionAttribute("Edm", "DiffMicroseconds")]
        public static System.Nullable<int> DiffMicroseconds(System.Nullable<System.DateTimeOffset> timeValue1, System.Nullable<System.DateTimeOffset> timeValue2) { throw null; }
        [System.Data.Objects.DataClasses.EdmFunctionAttribute("Edm", "DiffMicroseconds")]
        public static System.Nullable<int> DiffMicroseconds(System.Nullable<System.DateTime> timeValue1, System.Nullable<System.DateTime> timeValue2) { throw null; }
        [System.Data.Objects.DataClasses.EdmFunctionAttribute("Edm", "DiffMicroseconds")]
        public static System.Nullable<int> DiffMicroseconds(System.Nullable<System.TimeSpan> timeValue1, System.Nullable<System.TimeSpan> timeValue2) { throw null; }
        [System.Data.Objects.DataClasses.EdmFunctionAttribute("Edm", "DiffMilliseconds")]
        public static System.Nullable<int> DiffMilliseconds(System.Nullable<System.DateTimeOffset> timeValue1, System.Nullable<System.DateTimeOffset> timeValue2) { throw null; }
        [System.Data.Objects.DataClasses.EdmFunctionAttribute("Edm", "DiffMilliseconds")]
        public static System.Nullable<int> DiffMilliseconds(System.Nullable<System.DateTime> timeValue1, System.Nullable<System.DateTime> timeValue2) { throw null; }
        [System.Data.Objects.DataClasses.EdmFunctionAttribute("Edm", "DiffMilliseconds")]
        public static System.Nullable<int> DiffMilliseconds(System.Nullable<System.TimeSpan> timeValue1, System.Nullable<System.TimeSpan> timeValue2) { throw null; }
        [System.Data.Objects.DataClasses.EdmFunctionAttribute("Edm", "DiffMinutes")]
        public static System.Nullable<int> DiffMinutes(System.Nullable<System.DateTimeOffset> timeValue1, System.Nullable<System.DateTimeOffset> timeValue2) { throw null; }
        [System.Data.Objects.DataClasses.EdmFunctionAttribute("Edm", "DiffMinutes")]
        public static System.Nullable<int> DiffMinutes(System.Nullable<System.DateTime> timeValue1, System.Nullable<System.DateTime> timeValue2) { throw null; }
        [System.Data.Objects.DataClasses.EdmFunctionAttribute("Edm", "DiffMinutes")]
        public static System.Nullable<int> DiffMinutes(System.Nullable<System.TimeSpan> timeValue1, System.Nullable<System.TimeSpan> timeValue2) { throw null; }
        [System.Data.Objects.DataClasses.EdmFunctionAttribute("Edm", "DiffMonths")]
        public static System.Nullable<int> DiffMonths(System.Nullable<System.DateTimeOffset> dateValue1, System.Nullable<System.DateTimeOffset> dateValue2) { throw null; }
        [System.Data.Objects.DataClasses.EdmFunctionAttribute("Edm", "DiffMonths")]
        public static System.Nullable<int> DiffMonths(System.Nullable<System.DateTime> dateValue1, System.Nullable<System.DateTime> dateValue2) { throw null; }
        [System.Data.Objects.DataClasses.EdmFunctionAttribute("Edm", "DiffNanoseconds")]
        public static System.Nullable<int> DiffNanoseconds(System.Nullable<System.DateTimeOffset> timeValue1, System.Nullable<System.DateTimeOffset> timeValue2) { throw null; }
        [System.Data.Objects.DataClasses.EdmFunctionAttribute("Edm", "DiffNanoseconds")]
        public static System.Nullable<int> DiffNanoseconds(System.Nullable<System.DateTime> timeValue1, System.Nullable<System.DateTime> timeValue2) { throw null; }
        [System.Data.Objects.DataClasses.EdmFunctionAttribute("Edm", "DiffNanoseconds")]
        public static System.Nullable<int> DiffNanoseconds(System.Nullable<System.TimeSpan> timeValue1, System.Nullable<System.TimeSpan> timeValue2) { throw null; }
        [System.Data.Objects.DataClasses.EdmFunctionAttribute("Edm", "DiffSeconds")]
        public static System.Nullable<int> DiffSeconds(System.Nullable<System.DateTimeOffset> timeValue1, System.Nullable<System.DateTimeOffset> timeValue2) { throw null; }
        [System.Data.Objects.DataClasses.EdmFunctionAttribute("Edm", "DiffSeconds")]
        public static System.Nullable<int> DiffSeconds(System.Nullable<System.DateTime> timeValue1, System.Nullable<System.DateTime> timeValue2) { throw null; }
        [System.Data.Objects.DataClasses.EdmFunctionAttribute("Edm", "DiffSeconds")]
        public static System.Nullable<int> DiffSeconds(System.Nullable<System.TimeSpan> timeValue1, System.Nullable<System.TimeSpan> timeValue2) { throw null; }
        [System.Data.Objects.DataClasses.EdmFunctionAttribute("Edm", "DiffYears")]
        public static System.Nullable<int> DiffYears(System.Nullable<System.DateTimeOffset> dateValue1, System.Nullable<System.DateTimeOffset> dateValue2) { throw null; }
        [System.Data.Objects.DataClasses.EdmFunctionAttribute("Edm", "DiffYears")]
        public static System.Nullable<int> DiffYears(System.Nullable<System.DateTime> dateValue1, System.Nullable<System.DateTime> dateValue2) { throw null; }
        [System.Data.Objects.DataClasses.EdmFunctionAttribute("Edm", "GetTotalOffsetMinutes")]
        public static System.Nullable<int> GetTotalOffsetMinutes(System.Nullable<System.DateTimeOffset> dateTimeOffsetArgument) { throw null; }
        [System.Data.Objects.DataClasses.EdmFunctionAttribute("Edm", "Left")]
        public static string Left(string stringArgument, System.Nullable<long> length) { throw null; }
        [System.Data.Objects.DataClasses.EdmFunctionAttribute("Edm", "Reverse")]
        public static string Reverse(string stringArgument) { throw null; }
        [System.Data.Objects.DataClasses.EdmFunctionAttribute("Edm", "Right")]
        public static string Right(string stringArgument, System.Nullable<long> length) { throw null; }
        [System.Data.Objects.DataClasses.EdmFunctionAttribute("Edm", "StDev")]
        public static System.Nullable<double> StandardDeviation(System.Collections.Generic.IEnumerable<decimal> collection) { throw null; }
        [System.Data.Objects.DataClasses.EdmFunctionAttribute("Edm", "StDev")]
        public static System.Nullable<double> StandardDeviation(System.Collections.Generic.IEnumerable<double> collection) { throw null; }
        [System.Data.Objects.DataClasses.EdmFunctionAttribute("Edm", "StDev")]
        public static System.Nullable<double> StandardDeviation(System.Collections.Generic.IEnumerable<int> collection) { throw null; }
        [System.Data.Objects.DataClasses.EdmFunctionAttribute("Edm", "StDev")]
        public static System.Nullable<double> StandardDeviation(System.Collections.Generic.IEnumerable<long> collection) { throw null; }
        [System.Data.Objects.DataClasses.EdmFunctionAttribute("Edm", "StDev")]
        public static System.Nullable<double> StandardDeviation(System.Collections.Generic.IEnumerable<System.Nullable<decimal>> collection) { throw null; }
        [System.Data.Objects.DataClasses.EdmFunctionAttribute("Edm", "StDev")]
        public static System.Nullable<double> StandardDeviation(System.Collections.Generic.IEnumerable<System.Nullable<double>> collection) { throw null; }
        [System.Data.Objects.DataClasses.EdmFunctionAttribute("Edm", "StDev")]
        public static System.Nullable<double> StandardDeviation(System.Collections.Generic.IEnumerable<System.Nullable<int>> collection) { throw null; }
        [System.Data.Objects.DataClasses.EdmFunctionAttribute("Edm", "StDev")]
        public static System.Nullable<double> StandardDeviation(System.Collections.Generic.IEnumerable<System.Nullable<long>> collection) { throw null; }
        [System.Data.Objects.DataClasses.EdmFunctionAttribute("Edm", "StDevP")]
        public static System.Nullable<double> StandardDeviationP(System.Collections.Generic.IEnumerable<decimal> collection) { throw null; }
        [System.Data.Objects.DataClasses.EdmFunctionAttribute("Edm", "StDevP")]
        public static System.Nullable<double> StandardDeviationP(System.Collections.Generic.IEnumerable<double> collection) { throw null; }
        [System.Data.Objects.DataClasses.EdmFunctionAttribute("Edm", "StDevP")]
        public static System.Nullable<double> StandardDeviationP(System.Collections.Generic.IEnumerable<int> collection) { throw null; }
        [System.Data.Objects.DataClasses.EdmFunctionAttribute("Edm", "StDevP")]
        public static System.Nullable<double> StandardDeviationP(System.Collections.Generic.IEnumerable<long> collection) { throw null; }
        [System.Data.Objects.DataClasses.EdmFunctionAttribute("Edm", "StDevP")]
        public static System.Nullable<double> StandardDeviationP(System.Collections.Generic.IEnumerable<System.Nullable<decimal>> collection) { throw null; }
        [System.Data.Objects.DataClasses.EdmFunctionAttribute("Edm", "StDevP")]
        public static System.Nullable<double> StandardDeviationP(System.Collections.Generic.IEnumerable<System.Nullable<double>> collection) { throw null; }
        [System.Data.Objects.DataClasses.EdmFunctionAttribute("Edm", "StDevP")]
        public static System.Nullable<double> StandardDeviationP(System.Collections.Generic.IEnumerable<System.Nullable<int>> collection) { throw null; }
        [System.Data.Objects.DataClasses.EdmFunctionAttribute("Edm", "StDevP")]
        public static System.Nullable<double> StandardDeviationP(System.Collections.Generic.IEnumerable<System.Nullable<long>> collection) { throw null; }
        [System.Data.Objects.DataClasses.EdmFunctionAttribute("Edm", "Truncate")]
        public static System.Nullable<decimal> Truncate(System.Nullable<decimal> value, System.Nullable<int> digits) { throw null; }
        [System.Data.Objects.DataClasses.EdmFunctionAttribute("Edm", "Truncate")]
        public static System.Nullable<double> Truncate(System.Nullable<double> value, System.Nullable<int> digits) { throw null; }
        [System.Data.Objects.DataClasses.EdmFunctionAttribute("Edm", "TruncateTime")]
        public static System.Nullable<System.DateTimeOffset> TruncateTime(System.Nullable<System.DateTimeOffset> dateValue) { throw null; }
        [System.Data.Objects.DataClasses.EdmFunctionAttribute("Edm", "TruncateTime")]
        public static System.Nullable<System.DateTime> TruncateTime(System.Nullable<System.DateTime> dateValue) { throw null; }
        [System.Data.Objects.DataClasses.EdmFunctionAttribute("Edm", "Var")]
        public static System.Nullable<double> Var(System.Collections.Generic.IEnumerable<decimal> collection) { throw null; }
        [System.Data.Objects.DataClasses.EdmFunctionAttribute("Edm", "Var")]
        public static System.Nullable<double> Var(System.Collections.Generic.IEnumerable<double> collection) { throw null; }
        [System.Data.Objects.DataClasses.EdmFunctionAttribute("Edm", "Var")]
        public static System.Nullable<double> Var(System.Collections.Generic.IEnumerable<int> collection) { throw null; }
        [System.Data.Objects.DataClasses.EdmFunctionAttribute("Edm", "Var")]
        public static System.Nullable<double> Var(System.Collections.Generic.IEnumerable<long> collection) { throw null; }
        [System.Data.Objects.DataClasses.EdmFunctionAttribute("Edm", "Var")]
        public static System.Nullable<double> Var(System.Collections.Generic.IEnumerable<System.Nullable<decimal>> collection) { throw null; }
        [System.Data.Objects.DataClasses.EdmFunctionAttribute("Edm", "Var")]
        public static System.Nullable<double> Var(System.Collections.Generic.IEnumerable<System.Nullable<double>> collection) { throw null; }
        [System.Data.Objects.DataClasses.EdmFunctionAttribute("Edm", "Var")]
        public static System.Nullable<double> Var(System.Collections.Generic.IEnumerable<System.Nullable<int>> collection) { throw null; }
        [System.Data.Objects.DataClasses.EdmFunctionAttribute("Edm", "Var")]
        public static System.Nullable<double> Var(System.Collections.Generic.IEnumerable<System.Nullable<long>> collection) { throw null; }
        [System.Data.Objects.DataClasses.EdmFunctionAttribute("Edm", "VarP")]
        public static System.Nullable<double> VarP(System.Collections.Generic.IEnumerable<decimal> collection) { throw null; }
        [System.Data.Objects.DataClasses.EdmFunctionAttribute("Edm", "VarP")]
        public static System.Nullable<double> VarP(System.Collections.Generic.IEnumerable<double> collection) { throw null; }
        [System.Data.Objects.DataClasses.EdmFunctionAttribute("Edm", "VarP")]
        public static System.Nullable<double> VarP(System.Collections.Generic.IEnumerable<int> collection) { throw null; }
        [System.Data.Objects.DataClasses.EdmFunctionAttribute("Edm", "VarP")]
        public static System.Nullable<double> VarP(System.Collections.Generic.IEnumerable<long> collection) { throw null; }
        [System.Data.Objects.DataClasses.EdmFunctionAttribute("Edm", "VarP")]
        public static System.Nullable<double> VarP(System.Collections.Generic.IEnumerable<System.Nullable<decimal>> collection) { throw null; }
        [System.Data.Objects.DataClasses.EdmFunctionAttribute("Edm", "VarP")]
        public static System.Nullable<double> VarP(System.Collections.Generic.IEnumerable<System.Nullable<double>> collection) { throw null; }
        [System.Data.Objects.DataClasses.EdmFunctionAttribute("Edm", "VarP")]
        public static System.Nullable<double> VarP(System.Collections.Generic.IEnumerable<System.Nullable<int>> collection) { throw null; }
        [System.Data.Objects.DataClasses.EdmFunctionAttribute("Edm", "VarP")]
        public static System.Nullable<double> VarP(System.Collections.Generic.IEnumerable<System.Nullable<long>> collection) { throw null; }
    }
    public partial interface IObjectSet<TEntity> : System.Collections.Generic.IEnumerable<TEntity>, System.Collections.IEnumerable, System.Linq.IQueryable, System.Linq.IQueryable<TEntity> where TEntity : class
    {
        void AddObject(TEntity entity);
        void Attach(TEntity entity);
        void DeleteObject(TEntity entity);
        void Detach(TEntity entity);
    }
    public enum MergeOption
    {
        AppendOnly = 0,
        NoTracking = 3,
        OverwriteChanges = 1,
        PreserveChanges = 2,
    }
    public partial class ObjectContext : System.IDisposable
    {
        public ObjectContext(System.Data.EntityClient.EntityConnection connection) { }
        protected ObjectContext(System.Data.EntityClient.EntityConnection connection, string defaultContainerName) { }
        public ObjectContext(string connectionString) { }
        protected ObjectContext(string connectionString, string defaultContainerName) { }
        public System.Nullable<int> CommandTimeout { get { throw null; } set { } }
        public System.Data.Common.DbConnection Connection { get { throw null; } }
        public System.Data.Objects.ObjectContextOptions ContextOptions { get { throw null; } }
        public string DefaultContainerName { get { throw null; } set { } }
        [System.CLSCompliantAttribute(false)]
        public System.Data.Metadata.Edm.MetadataWorkspace MetadataWorkspace { get { throw null; } }
        public System.Data.Objects.ObjectStateManager ObjectStateManager { get { throw null; } }
        protected internal System.Linq.IQueryProvider QueryProvider { get { throw null; } }
        public event System.Data.Objects.ObjectMaterializedEventHandler ObjectMaterialized { add { } remove { } }
        public event System.EventHandler SavingChanges { add { } remove { } }
        public void AcceptAllChanges() { }
        public void AddObject(string entitySetName, object entity) { }
        public TEntity ApplyCurrentValues<TEntity>(string entitySetName, TEntity currentEntity) where TEntity : class { throw null; }
        public TEntity ApplyOriginalValues<TEntity>(string entitySetName, TEntity originalEntity) where TEntity : class { throw null; }
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.ObsoleteAttribute("Use ApplyCurrentValues instead")]
        public void ApplyPropertyChanges(string entitySetName, object changed) { }
        public void Attach(System.Data.Objects.DataClasses.IEntityWithKey entity) { }
        public void AttachTo(string entitySetName, object entity) { }
        public void CreateDatabase() { }
        public string CreateDatabaseScript() { throw null; }
        public System.Data.EntityKey CreateEntityKey(string entitySetName, object entity) { throw null; }
        public System.Data.Objects.ObjectSet<TEntity> CreateObjectSet<TEntity>() where TEntity : class { throw null; }
        public System.Data.Objects.ObjectSet<TEntity> CreateObjectSet<TEntity>(string entitySetName) where TEntity : class { throw null; }
        public T CreateObject<T>() where T : class { throw null; }
        public void CreateProxyTypes(System.Collections.Generic.IEnumerable<System.Type> types) { }
        public System.Data.Objects.ObjectQuery<T> CreateQuery<T>(string queryString, params System.Data.Objects.ObjectParameter[] parameters) { throw null; }
        public bool DatabaseExists() { throw null; }
        public void DeleteDatabase() { }
        public void DeleteObject(object entity) { }
        public void Detach(object entity) { }
        public void DetectChanges() { }
        public void Dispose() { }
        protected virtual void Dispose(bool disposing) { }
        public int ExecuteFunction(string functionName, params System.Data.Objects.ObjectParameter[] parameters) { throw null; }
        public System.Data.Objects.ObjectResult<TElement> ExecuteFunction<TElement>(string functionName, System.Data.Objects.MergeOption mergeOption, params System.Data.Objects.ObjectParameter[] parameters) { throw null; }
        public System.Data.Objects.ObjectResult<TElement> ExecuteFunction<TElement>(string functionName, params System.Data.Objects.ObjectParameter[] parameters) { throw null; }
        public int ExecuteStoreCommand(string commandText, params object[] parameters) { throw null; }
        public System.Data.Objects.ObjectResult<TElement> ExecuteStoreQuery<TElement>(string commandText, params object[] parameters) { throw null; }
        public System.Data.Objects.ObjectResult<TEntity> ExecuteStoreQuery<TEntity>(string commandText, string entitySetName, System.Data.Objects.MergeOption mergeOption, params object[] parameters) { throw null; }
        public static System.Collections.Generic.IEnumerable<System.Type> GetKnownProxyTypes() { throw null; }
        public object GetObjectByKey(System.Data.EntityKey key) { throw null; }
        public static System.Type GetObjectType(System.Type type) { throw null; }
        public void LoadProperty(object entity, string navigationProperty) { }
        public void LoadProperty(object entity, string navigationProperty, System.Data.Objects.MergeOption mergeOption) { }
        public void LoadProperty<TEntity>(TEntity entity, System.Linq.Expressions.Expression<System.Func<TEntity, object>> selector) { }
        public void LoadProperty<TEntity>(TEntity entity, System.Linq.Expressions.Expression<System.Func<TEntity, object>> selector, System.Data.Objects.MergeOption mergeOption) { }
        public void Refresh(System.Data.Objects.RefreshMode refreshMode, System.Collections.IEnumerable collection) { }
        public void Refresh(System.Data.Objects.RefreshMode refreshMode, object entity) { }
        public int SaveChanges() { throw null; }
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.ObsoleteAttribute("Use SaveChanges(SaveOptions options) instead.")]
        public int SaveChanges(bool acceptChangesDuringSave) { throw null; }
        public virtual int SaveChanges(System.Data.Objects.SaveOptions options) { throw null; }
        public System.Data.Objects.ObjectResult<TElement> Translate<TElement>(System.Data.Common.DbDataReader reader) { throw null; }
        public System.Data.Objects.ObjectResult<TEntity> Translate<TEntity>(System.Data.Common.DbDataReader reader, string entitySetName, System.Data.Objects.MergeOption mergeOption) { throw null; }
        public bool TryGetObjectByKey(System.Data.EntityKey key, out object value) { throw null; }
    }
    public sealed partial class ObjectContextOptions
    {
        internal ObjectContextOptions() { }
        public bool LazyLoadingEnabled { get { throw null; } set { } }
        public bool ProxyCreationEnabled { get { throw null; } set { } }
        public bool UseConsistentNullReferenceBehavior { get { throw null; } set { } }
        public bool UseCSharpNullComparisonBehavior { get { throw null; } set { } }
        public bool UseLegacyPreserveChangesBehavior { get { throw null; } set { } }
    }
    public partial class ObjectMaterializedEventArgs : System.EventArgs
    {
        internal ObjectMaterializedEventArgs() { }
        public object Entity { get { throw null; } }
    }
    public delegate void ObjectMaterializedEventHandler(object sender, System.Data.Objects.ObjectMaterializedEventArgs e);
    public sealed partial class ObjectParameter
    {
        public ObjectParameter(string name, object value) { }
        public ObjectParameter(string name, System.Type type) { }
        public string Name { get { throw null; } }
        public System.Type ParameterType { get { throw null; } }
        public object Value { get { throw null; } set { } }
    }
    public sealed partial class ObjectParameterCollection : System.Collections.Generic.ICollection<System.Data.Objects.ObjectParameter>, System.Collections.Generic.IEnumerable<System.Data.Objects.ObjectParameter>, System.Collections.IEnumerable
    {
        internal ObjectParameterCollection() { }
        public int Count { get { throw null; } }
        public System.Data.Objects.ObjectParameter this[string name] { get { throw null; } }
        bool System.Collections.Generic.ICollection<System.Data.Objects.ObjectParameter>.IsReadOnly { get { throw null; } }
        public void Add(System.Data.Objects.ObjectParameter parameter) { }
        public void Clear() { }
        public bool Contains(System.Data.Objects.ObjectParameter parameter) { throw null; }
        public bool Contains(string name) { throw null; }
        public void CopyTo(System.Data.Objects.ObjectParameter[] array, int index) { }
        public bool Remove(System.Data.Objects.ObjectParameter parameter) { throw null; }
        System.Collections.Generic.IEnumerator<System.Data.Objects.ObjectParameter> System.Collections.Generic.IEnumerable<System.Data.Objects.ObjectParameter>.GetEnumerator() { throw null; }
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { throw null; }
    }
    public abstract partial class ObjectQuery : System.Collections.IEnumerable, System.ComponentModel.IListSource, System.Linq.IOrderedQueryable, System.Linq.IQueryable
    {
        internal ObjectQuery() { }
        public string CommandText { get { throw null; } }
        public System.Data.Objects.ObjectContext Context { get { throw null; } }
        public bool EnablePlanCaching { get { throw null; } set { } }
        public System.Data.Objects.MergeOption MergeOption { get { throw null; } set { } }
        public System.Data.Objects.ObjectParameterCollection Parameters { get { throw null; } }
        bool System.ComponentModel.IListSource.ContainsListCollection { get { throw null; } }
        System.Type System.Linq.IQueryable.ElementType { get { throw null; } }
        System.Linq.Expressions.Expression System.Linq.IQueryable.Expression { get { throw null; } }
        System.Linq.IQueryProvider System.Linq.IQueryable.Provider { get { throw null; } }
        public System.Data.Objects.ObjectResult Execute(System.Data.Objects.MergeOption mergeOption) { throw null; }
        public System.Data.Metadata.Edm.TypeUsage GetResultType() { throw null; }
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { throw null; }
        System.Collections.IList System.ComponentModel.IListSource.GetList() { throw null; }
        [System.ComponentModel.BrowsableAttribute(false)]
        public string ToTraceString() { throw null; }
    }
    public partial class ObjectQuery<T> : System.Data.Objects.ObjectQuery, System.Collections.Generic.IEnumerable<T>, System.Collections.IEnumerable, System.ComponentModel.IListSource, System.Linq.IOrderedQueryable, System.Linq.IOrderedQueryable<T>, System.Linq.IQueryable, System.Linq.IQueryable<T>
    {
        public ObjectQuery(string commandText, System.Data.Objects.ObjectContext context) { }
        public ObjectQuery(string commandText, System.Data.Objects.ObjectContext context, System.Data.Objects.MergeOption mergeOption) { }
        public string Name { get { throw null; } set { } }
        public System.Data.Objects.ObjectQuery<T> Distinct() { throw null; }
        public System.Data.Objects.ObjectQuery<T> Except(System.Data.Objects.ObjectQuery<T> query) { throw null; }
        public new System.Data.Objects.ObjectResult<T> Execute(System.Data.Objects.MergeOption mergeOption) { throw null; }
        public System.Data.Objects.ObjectQuery<System.Data.Common.DbDataRecord> GroupBy(string keys, string projection, params System.Data.Objects.ObjectParameter[] parameters) { throw null; }
        public System.Data.Objects.ObjectQuery<T> Include(string path) { throw null; }
        public System.Data.Objects.ObjectQuery<T> Intersect(System.Data.Objects.ObjectQuery<T> query) { throw null; }
        public System.Data.Objects.ObjectQuery<TResultType> OfType<TResultType>() { throw null; }
        public System.Data.Objects.ObjectQuery<T> OrderBy(string keys, params System.Data.Objects.ObjectParameter[] parameters) { throw null; }
        public System.Data.Objects.ObjectQuery<System.Data.Common.DbDataRecord> Select(string projection, params System.Data.Objects.ObjectParameter[] parameters) { throw null; }
        public System.Data.Objects.ObjectQuery<TResultType> SelectValue<TResultType>(string projection, params System.Data.Objects.ObjectParameter[] parameters) { throw null; }
        public System.Data.Objects.ObjectQuery<T> Skip(string keys, string count, params System.Data.Objects.ObjectParameter[] parameters) { throw null; }
        System.Collections.Generic.IEnumerator<T> System.Collections.Generic.IEnumerable<T>.GetEnumerator() { throw null; }
        public System.Data.Objects.ObjectQuery<T> Top(string count, params System.Data.Objects.ObjectParameter[] parameters) { throw null; }
        public System.Data.Objects.ObjectQuery<T> Union(System.Data.Objects.ObjectQuery<T> query) { throw null; }
        public System.Data.Objects.ObjectQuery<T> UnionAll(System.Data.Objects.ObjectQuery<T> query) { throw null; }
        public System.Data.Objects.ObjectQuery<T> Where(string predicate, params System.Data.Objects.ObjectParameter[] parameters) { throw null; }
    }
    public abstract partial class ObjectResult : System.Collections.IEnumerable, System.ComponentModel.IListSource, System.IDisposable
    {
        internal ObjectResult() { }
        public abstract System.Type ElementType { get; }
        bool System.ComponentModel.IListSource.ContainsListCollection { get { throw null; } }
        public abstract void Dispose();
        public System.Data.Objects.ObjectResult<TElement> GetNextResult<TElement>() { throw null; }
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { throw null; }
        System.Collections.IList System.ComponentModel.IListSource.GetList() { throw null; }
    }
    public sealed partial class ObjectResult<T> : System.Data.Objects.ObjectResult, System.Collections.Generic.IEnumerable<T>, System.Collections.IEnumerable
    {
        internal ObjectResult() { }
        public override System.Type ElementType { get { throw null; } }
        public override void Dispose() { }
        public System.Collections.Generic.IEnumerator<T> GetEnumerator() { throw null; }
    }
    public partial class ObjectSet<TEntity> : System.Data.Objects.ObjectQuery<TEntity>, System.Collections.Generic.IEnumerable<TEntity>, System.Collections.IEnumerable, System.Data.Objects.IObjectSet<TEntity>, System.Linq.IQueryable, System.Linq.IQueryable<TEntity> where TEntity : class
    {
        internal ObjectSet() : base (default(string), default(System.Data.Objects.ObjectContext)) { }
        public System.Data.Metadata.Edm.EntitySet EntitySet { get { throw null; } }
        public void AddObject(TEntity entity) { }
        public TEntity ApplyCurrentValues(TEntity currentEntity) { throw null; }
        public TEntity ApplyOriginalValues(TEntity originalEntity) { throw null; }
        public void Attach(TEntity entity) { }
        public TEntity CreateObject() { throw null; }
        public T CreateObject<T>() where T : class, TEntity { throw null; }
        public void DeleteObject(TEntity entity) { }
        public void Detach(TEntity entity) { }
    }
    public abstract partial class ObjectStateEntry : System.Data.Objects.DataClasses.IEntityChangeTracker
    {
        internal ObjectStateEntry() { }
        [System.Diagnostics.DebuggerBrowsableAttribute(System.Diagnostics.DebuggerBrowsableState.Never)]
        public abstract System.Data.Objects.CurrentValueRecord CurrentValues { get; }
        public abstract object Entity { get; }
        public abstract System.Data.EntityKey EntityKey { get; }
        public System.Data.Metadata.Edm.EntitySetBase EntitySet { get { throw null; } }
        public abstract bool IsRelationship { get; }
        public System.Data.Objects.ObjectStateManager ObjectStateManager { get { throw null; } }
        [System.Diagnostics.DebuggerBrowsableAttribute(System.Diagnostics.DebuggerBrowsableState.Never)]
        public abstract System.Data.Common.DbDataRecord OriginalValues { get; }
        public abstract System.Data.Objects.DataClasses.RelationshipManager RelationshipManager { get; }
        public System.Data.EntityState State { get { throw null; } }
        System.Data.EntityState System.Data.Objects.DataClasses.IEntityChangeTracker.EntityState { get { throw null; } }
        public abstract void AcceptChanges();
        public abstract void ApplyCurrentValues(object currentEntity);
        public abstract void ApplyOriginalValues(object originalEntity);
        public abstract void ChangeState(System.Data.EntityState state);
        public abstract void Delete();
        public abstract System.Collections.Generic.IEnumerable<string> GetModifiedProperties();
        public abstract System.Data.Objects.OriginalValueRecord GetUpdatableOriginalValues();
        public abstract bool IsPropertyChanged(string propertyName);
        public abstract void RejectPropertyChanges(string propertyName);
        public abstract void SetModified();
        public abstract void SetModifiedProperty(string propertyName);
        void System.Data.Objects.DataClasses.IEntityChangeTracker.EntityComplexMemberChanged(string entityMemberName, object complexObject, string complexObjectMemberName) { }
        void System.Data.Objects.DataClasses.IEntityChangeTracker.EntityComplexMemberChanging(string entityMemberName, object complexObject, string complexObjectMemberName) { }
        void System.Data.Objects.DataClasses.IEntityChangeTracker.EntityMemberChanged(string entityMemberName) { }
        void System.Data.Objects.DataClasses.IEntityChangeTracker.EntityMemberChanging(string entityMemberName) { }
    }
    public partial class ObjectStateManager
    {
        [System.CLSCompliantAttribute(false)]
        public ObjectStateManager(System.Data.Metadata.Edm.MetadataWorkspace metadataWorkspace) { }
        [System.CLSCompliantAttribute(false)]
        public System.Data.Metadata.Edm.MetadataWorkspace MetadataWorkspace { get { throw null; } }
        public event System.ComponentModel.CollectionChangeEventHandler ObjectStateManagerChanged { add { } remove { } }
        public System.Data.Objects.ObjectStateEntry ChangeObjectState(object entity, System.Data.EntityState entityState) { throw null; }
        public System.Data.Objects.ObjectStateEntry ChangeRelationshipState(object sourceEntity, object targetEntity, string navigationProperty, System.Data.EntityState relationshipState) { throw null; }
        public System.Data.Objects.ObjectStateEntry ChangeRelationshipState(object sourceEntity, object targetEntity, string relationshipName, string targetRoleName, System.Data.EntityState relationshipState) { throw null; }
        public System.Data.Objects.ObjectStateEntry ChangeRelationshipState<TEntity>(TEntity sourceEntity, object targetEntity, System.Linq.Expressions.Expression<System.Func<TEntity, object>> navigationPropertySelector, System.Data.EntityState relationshipState) where TEntity : class { throw null; }
        public System.Collections.Generic.IEnumerable<System.Data.Objects.ObjectStateEntry> GetObjectStateEntries(System.Data.EntityState state) { throw null; }
        public System.Data.Objects.ObjectStateEntry GetObjectStateEntry(System.Data.EntityKey key) { throw null; }
        public System.Data.Objects.ObjectStateEntry GetObjectStateEntry(object entity) { throw null; }
        public System.Data.Objects.DataClasses.RelationshipManager GetRelationshipManager(object entity) { throw null; }
        public bool TryGetObjectStateEntry(System.Data.EntityKey key, out System.Data.Objects.ObjectStateEntry entry) { throw null; }
        public bool TryGetObjectStateEntry(object entity, out System.Data.Objects.ObjectStateEntry entry) { throw null; }
        public bool TryGetRelationshipManager(object entity, out System.Data.Objects.DataClasses.RelationshipManager relationshipManager) { throw null; }
    }
    public abstract partial class OriginalValueRecord : System.Data.Objects.DbUpdatableDataRecord
    {
        internal OriginalValueRecord() { }
    }
    public partial class ProxyDataContractResolver : System.Runtime.Serialization.DataContractResolver
    {
        public ProxyDataContractResolver() { }
        public override System.Type ResolveName(string typeName, string typeNamespace, System.Type declaredType, System.Runtime.Serialization.DataContractResolver knownTypeResolver) { throw null; }
        public override bool TryResolveType(System.Type dataContractType, System.Type declaredType, System.Runtime.Serialization.DataContractResolver knownTypeResolver, out System.Xml.XmlDictionaryString typeName, out System.Xml.XmlDictionaryString typeNamespace) { throw null; }
    }
    public enum RefreshMode
    {
        ClientWins = 2,
        StoreWins = 1,
    }
    [System.FlagsAttribute]
    public enum SaveOptions
    {
        AcceptAllChangesAfterSave = 1,
        DetectChangesBeforeSave = 2,
        None = 0,
    }
}
namespace System.Data.Objects.DataClasses
{
    [System.Runtime.Serialization.DataContractAttribute(IsReference=true)]
    [System.SerializableAttribute]
    public abstract partial class ComplexObject : System.Data.Objects.DataClasses.StructuralObject
    {
        protected ComplexObject() { }
        protected sealed override void ReportPropertyChanged(string property) { }
        protected sealed override void ReportPropertyChanging(string property) { }
    }
    [System.AttributeUsageAttribute(System.AttributeTargets.Property)]
    public sealed partial class EdmComplexPropertyAttribute : System.Data.Objects.DataClasses.EdmPropertyAttribute
    {
        public EdmComplexPropertyAttribute() { }
    }
    [System.AttributeUsageAttribute(System.AttributeTargets.Class)]
    public sealed partial class EdmComplexTypeAttribute : System.Data.Objects.DataClasses.EdmTypeAttribute
    {
        public EdmComplexTypeAttribute() { }
    }
    [System.AttributeUsageAttribute(System.AttributeTargets.Class, AllowMultiple=false)]
    public sealed partial class EdmEntityTypeAttribute : System.Data.Objects.DataClasses.EdmTypeAttribute
    {
        public EdmEntityTypeAttribute() { }
    }
    [System.AttributeUsageAttribute(System.AttributeTargets.Enum)]
    public sealed partial class EdmEnumTypeAttribute : System.Data.Objects.DataClasses.EdmTypeAttribute
    {
        public EdmEnumTypeAttribute() { }
    }
    [System.AttributeUsageAttribute(System.AttributeTargets.Method, Inherited=false, AllowMultiple=false)]
    public sealed partial class EdmFunctionAttribute : System.Attribute
    {
        public EdmFunctionAttribute(string namespaceName, string functionName) { }
        public string FunctionName { get { throw null; } }
        public string NamespaceName { get { throw null; } }
    }
    [System.AttributeUsageAttribute(System.AttributeTargets.Property)]
    public abstract partial class EdmPropertyAttribute : System.Attribute
    {
        internal EdmPropertyAttribute() { }
    }
    [System.AttributeUsageAttribute(System.AttributeTargets.Assembly, AllowMultiple=true)]
    public sealed partial class EdmRelationshipAttribute : System.Attribute
    {
        public EdmRelationshipAttribute(string relationshipNamespaceName, string relationshipName, string role1Name, System.Data.Metadata.Edm.RelationshipMultiplicity role1Multiplicity, System.Type role1Type, string role2Name, System.Data.Metadata.Edm.RelationshipMultiplicity role2Multiplicity, System.Type role2Type) { }
        public EdmRelationshipAttribute(string relationshipNamespaceName, string relationshipName, string role1Name, System.Data.Metadata.Edm.RelationshipMultiplicity role1Multiplicity, System.Type role1Type, string role2Name, System.Data.Metadata.Edm.RelationshipMultiplicity role2Multiplicity, System.Type role2Type, bool isForeignKey) { }
        public bool IsForeignKey { get { throw null; } }
        public string RelationshipName { get { throw null; } }
        public string RelationshipNamespaceName { get { throw null; } }
        public System.Data.Metadata.Edm.RelationshipMultiplicity Role1Multiplicity { get { throw null; } }
        public string Role1Name { get { throw null; } }
        public System.Type Role1Type { get { throw null; } }
        public System.Data.Metadata.Edm.RelationshipMultiplicity Role2Multiplicity { get { throw null; } }
        public string Role2Name { get { throw null; } }
        public System.Type Role2Type { get { throw null; } }
    }
    [System.AttributeUsageAttribute(System.AttributeTargets.Property)]
    public sealed partial class EdmRelationshipNavigationPropertyAttribute : System.Data.Objects.DataClasses.EdmPropertyAttribute
    {
        public EdmRelationshipNavigationPropertyAttribute(string relationshipNamespaceName, string relationshipName, string targetRoleName) { }
        public string RelationshipName { get { throw null; } }
        public string RelationshipNamespaceName { get { throw null; } }
        public string TargetRoleName { get { throw null; } }
    }
    [System.AttributeUsageAttribute(System.AttributeTargets.Property)]
    public sealed partial class EdmScalarPropertyAttribute : System.Data.Objects.DataClasses.EdmPropertyAttribute
    {
        public EdmScalarPropertyAttribute() { }
        public bool EntityKeyProperty { get { throw null; } set { } }
        public bool IsNullable { get { throw null; } set { } }
    }
    [System.AttributeUsageAttribute(System.AttributeTargets.Assembly | System.AttributeTargets.Class, AllowMultiple=true)]
    public sealed partial class EdmSchemaAttribute : System.Attribute
    {
        public EdmSchemaAttribute() { }
        public EdmSchemaAttribute(string assemblyGuid) { }
    }
    public abstract partial class EdmTypeAttribute : System.Attribute
    {
        internal EdmTypeAttribute() { }
        public string Name { get { throw null; } set { } }
        public string NamespaceName { get { throw null; } set { } }
    }
    [System.SerializableAttribute]
    public sealed partial class EntityCollection<TEntity> : System.Data.Objects.DataClasses.RelatedEnd, System.Collections.Generic.ICollection<TEntity>, System.Collections.Generic.IEnumerable<TEntity>, System.Collections.IEnumerable, System.ComponentModel.IListSource where TEntity : class
    {
        public EntityCollection() { }
        public int Count { get { throw null; } }
        public bool IsReadOnly { get { throw null; } }
        bool System.ComponentModel.IListSource.ContainsListCollection { get { throw null; } }
        public void Add(TEntity entity) { }
        public void Attach(System.Collections.Generic.IEnumerable<TEntity> entities) { }
        public void Attach(TEntity entity) { }
        public void Clear() { }
        public bool Contains(TEntity entity) { throw null; }
        public void CopyTo(TEntity[] array, int arrayIndex) { }
        public System.Data.Objects.ObjectQuery<TEntity> CreateSourceQuery() { throw null; }
        public new System.Collections.Generic.IEnumerator<TEntity> GetEnumerator() { throw null; }
        public override void Load(System.Data.Objects.MergeOption mergeOption) { }
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Runtime.Serialization.OnDeserializedAttribute]
        public void OnCollectionDeserialized(System.Runtime.Serialization.StreamingContext context) { }
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Runtime.Serialization.OnSerializingAttribute]
        public void OnSerializing(System.Runtime.Serialization.StreamingContext context) { }
        public bool Remove(TEntity entity) { throw null; }
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { throw null; }
        System.Collections.IList System.ComponentModel.IListSource.GetList() { throw null; }
    }
    [System.Runtime.Serialization.DataContractAttribute(IsReference=true)]
    [System.SerializableAttribute]
    public abstract partial class EntityObject : System.Data.Objects.DataClasses.StructuralObject, System.Data.Objects.DataClasses.IEntityWithChangeTracker, System.Data.Objects.DataClasses.IEntityWithKey, System.Data.Objects.DataClasses.IEntityWithRelationships
    {
        protected EntityObject() { }
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.Runtime.Serialization.DataMemberAttribute]
        public System.Data.EntityKey EntityKey { get { throw null; } set { } }
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.Xml.Serialization.XmlIgnoreAttribute]
        public System.Data.EntityState EntityState { get { throw null; } }
        System.Data.Objects.DataClasses.RelationshipManager System.Data.Objects.DataClasses.IEntityWithRelationships.RelationshipManager { get { throw null; } }
        protected sealed override void ReportPropertyChanged(string property) { }
        protected sealed override void ReportPropertyChanging(string property) { }
        void System.Data.Objects.DataClasses.IEntityWithChangeTracker.SetChangeTracker(System.Data.Objects.DataClasses.IEntityChangeTracker changeTracker) { }
    }
    [System.Runtime.Serialization.DataContractAttribute]
    [System.SerializableAttribute]
    public abstract partial class EntityReference : System.Data.Objects.DataClasses.RelatedEnd
    {
        internal EntityReference() { }
        [System.Runtime.Serialization.DataMemberAttribute]
        public System.Data.EntityKey EntityKey { get { throw null; } set { } }
    }
    [System.Runtime.Serialization.DataContractAttribute]
    [System.SerializableAttribute]
    public sealed partial class EntityReference<TEntity> : System.Data.Objects.DataClasses.EntityReference where TEntity : class
    {
        public EntityReference() { }
        [System.Xml.Serialization.SoapIgnoreAttribute]
        [System.Xml.Serialization.XmlIgnoreAttribute]
        public TEntity Value { get { throw null; } set { } }
        public void Attach(TEntity entity) { }
        public System.Data.Objects.ObjectQuery<TEntity> CreateSourceQuery() { throw null; }
        public override void Load(System.Data.Objects.MergeOption mergeOption) { }
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Runtime.Serialization.OnDeserializedAttribute]
        public void OnRefDeserialized(System.Runtime.Serialization.StreamingContext context) { }
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Runtime.Serialization.OnSerializingAttribute]
        public void OnSerializing(System.Runtime.Serialization.StreamingContext context) { }
    }
    public partial interface IEntityChangeTracker
    {
        System.Data.EntityState EntityState { get; }
        void EntityComplexMemberChanged(string entityMemberName, object complexObject, string complexObjectMemberName);
        void EntityComplexMemberChanging(string entityMemberName, object complexObject, string complexObjectMemberName);
        void EntityMemberChanged(string entityMemberName);
        void EntityMemberChanging(string entityMemberName);
    }
    public partial interface IEntityWithChangeTracker
    {
        void SetChangeTracker(System.Data.Objects.DataClasses.IEntityChangeTracker changeTracker);
    }
    public partial interface IEntityWithKey
    {
        System.Data.EntityKey EntityKey { get; set; }
    }
    public partial interface IEntityWithRelationships
    {
        System.Data.Objects.DataClasses.RelationshipManager RelationshipManager { get; }
    }
    public partial interface IRelatedEnd
    {
        bool IsLoaded { get; }
        string RelationshipName { get; }
        System.Data.Metadata.Edm.RelationshipSet RelationshipSet { get; }
        string SourceRoleName { get; }
        string TargetRoleName { get; }
        void Add(System.Data.Objects.DataClasses.IEntityWithRelationships entity);
        void Add(object entity);
        void Attach(System.Data.Objects.DataClasses.IEntityWithRelationships entity);
        void Attach(object entity);
        System.Collections.IEnumerable CreateSourceQuery();
        System.Collections.IEnumerator GetEnumerator();
        void Load();
        void Load(System.Data.Objects.MergeOption mergeOption);
        bool Remove(System.Data.Objects.DataClasses.IEntityWithRelationships entity);
        bool Remove(object entity);
    }
    [System.Runtime.Serialization.DataContractAttribute]
    [System.SerializableAttribute]
    public abstract partial class RelatedEnd : System.Data.Objects.DataClasses.IRelatedEnd
    {
        internal RelatedEnd() { }
        [System.Xml.Serialization.SoapIgnoreAttribute]
        [System.Xml.Serialization.XmlIgnoreAttribute]
        public bool IsLoaded { get { throw null; } }
        [System.Xml.Serialization.SoapIgnoreAttribute]
        [System.Xml.Serialization.XmlIgnoreAttribute]
        public string RelationshipName { get { throw null; } }
        [System.Xml.Serialization.SoapIgnoreAttribute]
        [System.Xml.Serialization.XmlIgnoreAttribute]
        public System.Data.Metadata.Edm.RelationshipSet RelationshipSet { get { throw null; } }
        [System.Xml.Serialization.SoapIgnoreAttribute]
        [System.Xml.Serialization.XmlIgnoreAttribute]
        public string SourceRoleName { get { throw null; } }
        [System.Xml.Serialization.SoapIgnoreAttribute]
        [System.Xml.Serialization.XmlIgnoreAttribute]
        public string TargetRoleName { get { throw null; } }
        public event System.ComponentModel.CollectionChangeEventHandler AssociationChanged { add { } remove { } }
        public System.Collections.IEnumerator GetEnumerator() { throw null; }
        public void Load() { }
        public abstract void Load(System.Data.Objects.MergeOption mergeOption);
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Runtime.Serialization.OnDeserializedAttribute]
        public void OnDeserialized(System.Runtime.Serialization.StreamingContext context) { }
        void System.Data.Objects.DataClasses.IRelatedEnd.Add(System.Data.Objects.DataClasses.IEntityWithRelationships entity) { }
        void System.Data.Objects.DataClasses.IRelatedEnd.Add(object entity) { }
        void System.Data.Objects.DataClasses.IRelatedEnd.Attach(System.Data.Objects.DataClasses.IEntityWithRelationships entity) { }
        void System.Data.Objects.DataClasses.IRelatedEnd.Attach(object entity) { }
        System.Collections.IEnumerable System.Data.Objects.DataClasses.IRelatedEnd.CreateSourceQuery() { throw null; }
        bool System.Data.Objects.DataClasses.IRelatedEnd.Remove(System.Data.Objects.DataClasses.IEntityWithRelationships entity) { throw null; }
        bool System.Data.Objects.DataClasses.IRelatedEnd.Remove(object entity) { throw null; }
    }
    public enum RelationshipKind
    {
        Association = 0,
    }
    [System.SerializableAttribute]
    public partial class RelationshipManager
    {
        internal RelationshipManager() { }
        public static System.Data.Objects.DataClasses.RelationshipManager Create(System.Data.Objects.DataClasses.IEntityWithRelationships owner) { throw null; }
        public System.Collections.Generic.IEnumerable<System.Data.Objects.DataClasses.IRelatedEnd> GetAllRelatedEnds() { throw null; }
        public System.Data.Objects.DataClasses.EntityCollection<TTargetEntity> GetRelatedCollection<TTargetEntity>(string relationshipName, string targetRoleName) where TTargetEntity : class { throw null; }
        public System.Data.Objects.DataClasses.IRelatedEnd GetRelatedEnd(string relationshipName, string targetRoleName) { throw null; }
        public System.Data.Objects.DataClasses.EntityReference<TTargetEntity> GetRelatedReference<TTargetEntity>(string relationshipName, string targetRoleName) where TTargetEntity : class { throw null; }
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public void InitializeRelatedCollection<TTargetEntity>(string relationshipName, string targetRoleName, System.Data.Objects.DataClasses.EntityCollection<TTargetEntity> entityCollection) where TTargetEntity : class { }
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public void InitializeRelatedReference<TTargetEntity>(string relationshipName, string targetRoleName, System.Data.Objects.DataClasses.EntityReference<TTargetEntity> entityReference) where TTargetEntity : class { }
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Runtime.Serialization.OnDeserializedAttribute]
        public void OnDeserialized(System.Runtime.Serialization.StreamingContext context) { }
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Runtime.Serialization.OnSerializingAttribute]
        public void OnSerializing(System.Runtime.Serialization.StreamingContext context) { }
    }
    [System.Runtime.Serialization.DataContractAttribute(IsReference=true)]
    [System.SerializableAttribute]
    public abstract partial class StructuralObject : System.ComponentModel.INotifyPropertyChanged, System.ComponentModel.INotifyPropertyChanging
    {
        public static readonly string EntityKeyPropertyName;
        protected StructuralObject() { }
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged { add { } remove { } }
        public event System.ComponentModel.PropertyChangingEventHandler PropertyChanging { add { } remove { } }
        protected internal static bool BinaryEquals(byte[] first, byte[] second) { throw null; }
        protected static System.DateTime DefaultDateTimeValue() { throw null; }
        protected internal static byte[] GetValidValue(byte[] currentValue) { throw null; }
        protected internal T GetValidValue<T>(T currentValue, string property, bool isNullable, bool isInitialized) where T : System.Data.Objects.DataClasses.ComplexObject, new() { throw null; }
        protected virtual void OnPropertyChanged(string property) { }
        protected virtual void OnPropertyChanging(string property) { }
        protected virtual void ReportPropertyChanged(string property) { }
        protected virtual void ReportPropertyChanging(string property) { }
        protected internal static bool SetValidValue(bool value) { throw null; }
        protected internal static bool SetValidValue(bool value, string propertyName) { throw null; }
        protected internal static byte SetValidValue(byte value) { throw null; }
        protected internal static byte SetValidValue(byte value, string propertyName) { throw null; }
        protected internal static byte[] SetValidValue(byte[] value, bool isNullable) { throw null; }
        protected internal static byte[] SetValidValue(byte[] value, bool isNullable, string propertyName) { throw null; }
        protected internal static System.Data.Spatial.DbGeography SetValidValue(System.Data.Spatial.DbGeography value, bool isNullable) { throw null; }
        protected internal static System.Data.Spatial.DbGeography SetValidValue(System.Data.Spatial.DbGeography value, bool isNullable, string propertyName) { throw null; }
        protected internal static System.Data.Spatial.DbGeometry SetValidValue(System.Data.Spatial.DbGeometry value, bool isNullable) { throw null; }
        protected internal static System.Data.Spatial.DbGeometry SetValidValue(System.Data.Spatial.DbGeometry value, bool isNullable, string propertyName) { throw null; }
        protected internal static System.DateTime SetValidValue(System.DateTime value) { throw null; }
        protected internal static System.DateTime SetValidValue(System.DateTime value, string propertyName) { throw null; }
        protected internal static System.DateTimeOffset SetValidValue(System.DateTimeOffset value) { throw null; }
        protected internal static System.DateTimeOffset SetValidValue(System.DateTimeOffset value, string propertyName) { throw null; }
        protected internal static decimal SetValidValue(decimal value) { throw null; }
        protected internal static decimal SetValidValue(decimal value, string propertyName) { throw null; }
        protected internal static double SetValidValue(double value) { throw null; }
        protected internal static double SetValidValue(double value, string propertyName) { throw null; }
        protected internal static System.Guid SetValidValue(System.Guid value) { throw null; }
        protected internal static System.Guid SetValidValue(System.Guid value, string propertyName) { throw null; }
        protected internal static short SetValidValue(short value) { throw null; }
        protected internal static short SetValidValue(short value, string propertyName) { throw null; }
        protected internal static int SetValidValue(int value) { throw null; }
        protected internal static int SetValidValue(int value, string propertyName) { throw null; }
        protected internal static long SetValidValue(long value) { throw null; }
        protected internal static long SetValidValue(long value, string propertyName) { throw null; }
        protected internal static System.Nullable<bool> SetValidValue(System.Nullable<bool> value) { throw null; }
        protected internal static System.Nullable<bool> SetValidValue(System.Nullable<bool> value, string propertyName) { throw null; }
        protected internal static System.Nullable<byte> SetValidValue(System.Nullable<byte> value) { throw null; }
        protected internal static System.Nullable<byte> SetValidValue(System.Nullable<byte> value, string propertyName) { throw null; }
        protected internal static System.Nullable<System.DateTimeOffset> SetValidValue(System.Nullable<System.DateTimeOffset> value) { throw null; }
        protected internal static System.Nullable<System.DateTimeOffset> SetValidValue(System.Nullable<System.DateTimeOffset> value, string propertyName) { throw null; }
        protected internal static System.Nullable<System.DateTime> SetValidValue(System.Nullable<System.DateTime> value) { throw null; }
        protected internal static System.Nullable<System.DateTime> SetValidValue(System.Nullable<System.DateTime> value, string propertyName) { throw null; }
        protected internal static System.Nullable<decimal> SetValidValue(System.Nullable<decimal> value) { throw null; }
        protected internal static System.Nullable<decimal> SetValidValue(System.Nullable<decimal> value, string propertyName) { throw null; }
        protected internal static System.Nullable<double> SetValidValue(System.Nullable<double> value) { throw null; }
        protected internal static System.Nullable<double> SetValidValue(System.Nullable<double> value, string propertyName) { throw null; }
        protected internal static System.Nullable<System.Guid> SetValidValue(System.Nullable<System.Guid> value) { throw null; }
        protected internal static System.Nullable<System.Guid> SetValidValue(System.Nullable<System.Guid> value, string propertyName) { throw null; }
        protected internal static System.Nullable<short> SetValidValue(System.Nullable<short> value) { throw null; }
        protected internal static System.Nullable<short> SetValidValue(System.Nullable<short> value, string propertyName) { throw null; }
        protected internal static System.Nullable<int> SetValidValue(System.Nullable<int> value) { throw null; }
        protected internal static System.Nullable<int> SetValidValue(System.Nullable<int> value, string propertyName) { throw null; }
        protected internal static System.Nullable<long> SetValidValue(System.Nullable<long> value) { throw null; }
        protected internal static System.Nullable<long> SetValidValue(System.Nullable<long> value, string propertyName) { throw null; }
        [System.CLSCompliantAttribute(false)]
        protected internal static System.Nullable<sbyte> SetValidValue(System.Nullable<sbyte> value) { throw null; }
        [System.CLSCompliantAttribute(false)]
        protected internal static System.Nullable<sbyte> SetValidValue(System.Nullable<sbyte> value, string propertyName) { throw null; }
        protected internal static System.Nullable<float> SetValidValue(System.Nullable<float> value) { throw null; }
        protected internal static System.Nullable<float> SetValidValue(System.Nullable<float> value, string propertyName) { throw null; }
        protected internal static System.Nullable<System.TimeSpan> SetValidValue(System.Nullable<System.TimeSpan> value) { throw null; }
        protected internal static System.Nullable<System.TimeSpan> SetValidValue(System.Nullable<System.TimeSpan> value, string propertyName) { throw null; }
        [System.CLSCompliantAttribute(false)]
        protected internal static System.Nullable<ushort> SetValidValue(System.Nullable<ushort> value) { throw null; }
        [System.CLSCompliantAttribute(false)]
        protected internal static System.Nullable<ushort> SetValidValue(System.Nullable<ushort> value, string propertyName) { throw null; }
        [System.CLSCompliantAttribute(false)]
        protected internal static System.Nullable<uint> SetValidValue(System.Nullable<uint> value) { throw null; }
        [System.CLSCompliantAttribute(false)]
        protected internal static System.Nullable<uint> SetValidValue(System.Nullable<uint> value, string propertyName) { throw null; }
        [System.CLSCompliantAttribute(false)]
        protected internal static System.Nullable<ulong> SetValidValue(System.Nullable<ulong> value) { throw null; }
        [System.CLSCompliantAttribute(false)]
        protected internal static System.Nullable<ulong> SetValidValue(System.Nullable<ulong> value, string propertyName) { throw null; }
        [System.CLSCompliantAttribute(false)]
        protected internal static sbyte SetValidValue(sbyte value) { throw null; }
        [System.CLSCompliantAttribute(false)]
        protected internal static sbyte SetValidValue(sbyte value, string propertyName) { throw null; }
        protected internal static float SetValidValue(float value) { throw null; }
        protected internal static float SetValidValue(float value, string propertyName) { throw null; }
        protected internal static string SetValidValue(string value, bool isNullable) { throw null; }
        protected internal static string SetValidValue(string value, bool isNullable, string propertyName) { throw null; }
        protected internal static System.TimeSpan SetValidValue(System.TimeSpan value) { throw null; }
        protected internal static System.TimeSpan SetValidValue(System.TimeSpan value, string propertyName) { throw null; }
        [System.CLSCompliantAttribute(false)]
        protected internal static ushort SetValidValue(ushort value) { throw null; }
        [System.CLSCompliantAttribute(false)]
        protected internal static ushort SetValidValue(ushort value, string propertyName) { throw null; }
        [System.CLSCompliantAttribute(false)]
        protected internal static uint SetValidValue(uint value) { throw null; }
        [System.CLSCompliantAttribute(false)]
        protected internal static uint SetValidValue(uint value, string propertyName) { throw null; }
        [System.CLSCompliantAttribute(false)]
        protected internal static ulong SetValidValue(ulong value) { throw null; }
        [System.CLSCompliantAttribute(false)]
        protected internal static ulong SetValidValue(ulong value, string propertyName) { throw null; }
        protected internal T SetValidValue<T>(T oldValue, T newValue, string property) where T : System.Data.Objects.DataClasses.ComplexObject { throw null; }
        protected internal static TComplex VerifyComplexObjectIsNotNull<TComplex>(TComplex complexObject, string propertyName) where TComplex : System.Data.Objects.DataClasses.ComplexObject { throw null; }
    }
}
namespace System.Data.Objects.SqlClient
{
    public static partial class SqlFunctions
    {
        [System.Data.Objects.DataClasses.EdmFunctionAttribute("SqlServer", "ACOS")]
        public static System.Nullable<double> Acos(System.Nullable<decimal> arg1) { throw null; }
        [System.Data.Objects.DataClasses.EdmFunctionAttribute("SqlServer", "ACOS")]
        public static System.Nullable<double> Acos(System.Nullable<double> arg1) { throw null; }
        [System.Data.Objects.DataClasses.EdmFunctionAttribute("SqlServer", "ASCII")]
        public static System.Nullable<int> Ascii(string arg) { throw null; }
        [System.Data.Objects.DataClasses.EdmFunctionAttribute("SqlServer", "ASIN")]
        public static System.Nullable<double> Asin(System.Nullable<decimal> arg) { throw null; }
        [System.Data.Objects.DataClasses.EdmFunctionAttribute("SqlServer", "ASIN")]
        public static System.Nullable<double> Asin(System.Nullable<double> arg) { throw null; }
        [System.Data.Objects.DataClasses.EdmFunctionAttribute("SqlServer", "ATAN")]
        public static System.Nullable<double> Atan(System.Nullable<decimal> arg) { throw null; }
        [System.Data.Objects.DataClasses.EdmFunctionAttribute("SqlServer", "ATAN")]
        public static System.Nullable<double> Atan(System.Nullable<double> arg) { throw null; }
        [System.Data.Objects.DataClasses.EdmFunctionAttribute("SqlServer", "ATN2")]
        public static System.Nullable<double> Atan2(System.Nullable<decimal> arg1, System.Nullable<decimal> arg2) { throw null; }
        [System.Data.Objects.DataClasses.EdmFunctionAttribute("SqlServer", "ATN2")]
        public static System.Nullable<double> Atan2(System.Nullable<double> arg1, System.Nullable<double> arg2) { throw null; }
        [System.Data.Objects.DataClasses.EdmFunctionAttribute("SqlServer", "CHAR")]
        public static string Char(System.Nullable<int> arg) { throw null; }
        [System.Data.Objects.DataClasses.EdmFunctionAttribute("SqlServer", "CHARINDEX")]
        public static System.Nullable<int> CharIndex(byte[] toSearch, byte[] target) { throw null; }
        [System.Data.Objects.DataClasses.EdmFunctionAttribute("SqlServer", "CHARINDEX")]
        public static System.Nullable<int> CharIndex(byte[] toSearch, byte[] target, System.Nullable<int> startLocation) { throw null; }
        [System.Data.Objects.DataClasses.EdmFunctionAttribute("SqlServer", "CHARINDEX")]
        public static System.Nullable<long> CharIndex(byte[] toSearch, byte[] target, System.Nullable<long> startLocation) { throw null; }
        [System.Data.Objects.DataClasses.EdmFunctionAttribute("SqlServer", "CHARINDEX")]
        public static System.Nullable<int> CharIndex(string toSearch, string target) { throw null; }
        [System.Data.Objects.DataClasses.EdmFunctionAttribute("SqlServer", "CHARINDEX")]
        public static System.Nullable<int> CharIndex(string toSearch, string target, System.Nullable<int> startLocation) { throw null; }
        [System.Data.Objects.DataClasses.EdmFunctionAttribute("SqlServer", "CHARINDEX")]
        public static System.Nullable<long> CharIndex(string toSearch, string target, System.Nullable<long> startLocation) { throw null; }
        [System.Data.Objects.DataClasses.EdmFunctionAttribute("SqlServer", "CHECKSUM")]
        public static System.Nullable<int> Checksum(byte[] arg1) { throw null; }
        [System.Data.Objects.DataClasses.EdmFunctionAttribute("SqlServer", "CHECKSUM")]
        public static System.Nullable<int> Checksum(byte[] arg1, byte[] arg2) { throw null; }
        [System.Data.Objects.DataClasses.EdmFunctionAttribute("SqlServer", "CHECKSUM")]
        public static System.Nullable<int> Checksum(byte[] arg1, byte[] arg2, byte[] arg3) { throw null; }
        [System.Data.Objects.DataClasses.EdmFunctionAttribute("SqlServer", "CHECKSUM")]
        public static System.Nullable<int> Checksum(System.Nullable<bool> arg1) { throw null; }
        [System.Data.Objects.DataClasses.EdmFunctionAttribute("SqlServer", "CHECKSUM")]
        public static System.Nullable<int> Checksum(System.Nullable<bool> arg1, System.Nullable<bool> arg2) { throw null; }
        [System.Data.Objects.DataClasses.EdmFunctionAttribute("SqlServer", "CHECKSUM")]
        public static System.Nullable<int> Checksum(System.Nullable<bool> arg1, System.Nullable<bool> arg2, System.Nullable<bool> arg3) { throw null; }
        [System.Data.Objects.DataClasses.EdmFunctionAttribute("SqlServer", "CHECKSUM")]
        public static System.Nullable<int> Checksum(System.Nullable<System.DateTimeOffset> arg1) { throw null; }
        [System.Data.Objects.DataClasses.EdmFunctionAttribute("SqlServer", "CHECKSUM")]
        public static System.Nullable<int> Checksum(System.Nullable<System.DateTimeOffset> arg1, System.Nullable<System.DateTimeOffset> arg2) { throw null; }
        [System.Data.Objects.DataClasses.EdmFunctionAttribute("SqlServer", "CHECKSUM")]
        public static System.Nullable<int> Checksum(System.Nullable<System.DateTimeOffset> arg1, System.Nullable<System.DateTimeOffset> arg2, System.Nullable<System.DateTimeOffset> arg3) { throw null; }
        [System.Data.Objects.DataClasses.EdmFunctionAttribute("SqlServer", "CHECKSUM")]
        public static System.Nullable<int> Checksum(System.Nullable<System.DateTime> arg1) { throw null; }
        [System.Data.Objects.DataClasses.EdmFunctionAttribute("SqlServer", "CHECKSUM")]
        public static System.Nullable<int> Checksum(System.Nullable<System.DateTime> arg1, System.Nullable<System.DateTime> arg2) { throw null; }
        [System.Data.Objects.DataClasses.EdmFunctionAttribute("SqlServer", "CHECKSUM")]
        public static System.Nullable<int> Checksum(System.Nullable<System.DateTime> arg1, System.Nullable<System.DateTime> arg2, System.Nullable<System.DateTime> arg3) { throw null; }
        [System.Data.Objects.DataClasses.EdmFunctionAttribute("SqlServer", "CHECKSUM")]
        public static System.Nullable<int> Checksum(System.Nullable<decimal> arg1) { throw null; }
        [System.Data.Objects.DataClasses.EdmFunctionAttribute("SqlServer", "CHECKSUM")]
        public static System.Nullable<int> Checksum(System.Nullable<decimal> arg1, System.Nullable<decimal> arg2) { throw null; }
        [System.Data.Objects.DataClasses.EdmFunctionAttribute("SqlServer", "CHECKSUM")]
        public static System.Nullable<int> Checksum(System.Nullable<decimal> arg1, System.Nullable<decimal> arg2, System.Nullable<decimal> arg3) { throw null; }
        [System.Data.Objects.DataClasses.EdmFunctionAttribute("SqlServer", "CHECKSUM")]
        public static System.Nullable<int> Checksum(System.Nullable<double> arg1) { throw null; }
        [System.Data.Objects.DataClasses.EdmFunctionAttribute("SqlServer", "CHECKSUM")]
        public static System.Nullable<int> Checksum(System.Nullable<double> arg1, System.Nullable<double> arg2) { throw null; }
        [System.Data.Objects.DataClasses.EdmFunctionAttribute("SqlServer", "CHECKSUM")]
        public static System.Nullable<int> Checksum(System.Nullable<double> arg1, System.Nullable<double> arg2, System.Nullable<double> arg3) { throw null; }
        [System.Data.Objects.DataClasses.EdmFunctionAttribute("SqlServer", "CHECKSUM")]
        public static System.Nullable<int> Checksum(System.Nullable<System.Guid> arg1) { throw null; }
        [System.Data.Objects.DataClasses.EdmFunctionAttribute("SqlServer", "CHECKSUM")]
        public static System.Nullable<int> Checksum(System.Nullable<System.Guid> arg1, System.Nullable<System.Guid> arg2) { throw null; }
        [System.Data.Objects.DataClasses.EdmFunctionAttribute("SqlServer", "CHECKSUM")]
        public static System.Nullable<int> Checksum(System.Nullable<System.Guid> arg1, System.Nullable<System.Guid> arg2, System.Nullable<System.Guid> arg3) { throw null; }
        [System.Data.Objects.DataClasses.EdmFunctionAttribute("SqlServer", "CHECKSUM")]
        public static System.Nullable<int> Checksum(System.Nullable<System.TimeSpan> arg1) { throw null; }
        [System.Data.Objects.DataClasses.EdmFunctionAttribute("SqlServer", "CHECKSUM")]
        public static System.Nullable<int> Checksum(System.Nullable<System.TimeSpan> arg1, System.Nullable<System.TimeSpan> arg2) { throw null; }
        [System.Data.Objects.DataClasses.EdmFunctionAttribute("SqlServer", "CHECKSUM")]
        public static System.Nullable<int> Checksum(System.Nullable<System.TimeSpan> arg1, System.Nullable<System.TimeSpan> arg2, System.Nullable<System.TimeSpan> arg3) { throw null; }
        [System.Data.Objects.DataClasses.EdmFunctionAttribute("SqlServer", "CHECKSUM")]
        public static System.Nullable<int> Checksum(string arg1) { throw null; }
        [System.Data.Objects.DataClasses.EdmFunctionAttribute("SqlServer", "CHECKSUM")]
        public static System.Nullable<int> Checksum(string arg1, string arg2) { throw null; }
        [System.Data.Objects.DataClasses.EdmFunctionAttribute("SqlServer", "CHECKSUM")]
        public static System.Nullable<int> Checksum(string arg1, string arg2, string arg3) { throw null; }
        [System.Data.Objects.DataClasses.EdmFunctionAttribute("SqlServer", "CHECKSUM_AGG")]
        public static System.Nullable<int> ChecksumAggregate(System.Collections.Generic.IEnumerable<int> arg) { throw null; }
        [System.Data.Objects.DataClasses.EdmFunctionAttribute("SqlServer", "CHECKSUM_AGG")]
        public static System.Nullable<int> ChecksumAggregate(System.Collections.Generic.IEnumerable<System.Nullable<int>> arg) { throw null; }
        [System.Data.Objects.DataClasses.EdmFunctionAttribute("SqlServer", "COS")]
        public static System.Nullable<double> Cos(System.Nullable<decimal> arg) { throw null; }
        [System.Data.Objects.DataClasses.EdmFunctionAttribute("SqlServer", "COS")]
        public static System.Nullable<double> Cos(System.Nullable<double> arg) { throw null; }
        [System.Data.Objects.DataClasses.EdmFunctionAttribute("SqlServer", "COT")]
        public static System.Nullable<double> Cot(System.Nullable<decimal> arg) { throw null; }
        [System.Data.Objects.DataClasses.EdmFunctionAttribute("SqlServer", "COT")]
        public static System.Nullable<double> Cot(System.Nullable<double> arg) { throw null; }
        [System.Data.Objects.DataClasses.EdmFunctionAttribute("SqlServer", "CURRENT_TIMESTAMP")]
        public static System.Nullable<System.DateTime> CurrentTimestamp() { throw null; }
        [System.Data.Objects.DataClasses.EdmFunctionAttribute("SqlServer", "CURRENT_USER")]
        public static string CurrentUser() { throw null; }
        [System.Data.Objects.DataClasses.EdmFunctionAttribute("SqlServer", "DATALENGTH")]
        public static System.Nullable<int> DataLength(byte[] arg) { throw null; }
        [System.Data.Objects.DataClasses.EdmFunctionAttribute("SqlServer", "DATALENGTH")]
        public static System.Nullable<int> DataLength(System.Nullable<bool> arg) { throw null; }
        [System.Data.Objects.DataClasses.EdmFunctionAttribute("SqlServer", "DATALENGTH")]
        public static System.Nullable<int> DataLength(System.Nullable<System.DateTimeOffset> arg) { throw null; }
        [System.Data.Objects.DataClasses.EdmFunctionAttribute("SqlServer", "DATALENGTH")]
        public static System.Nullable<int> DataLength(System.Nullable<System.DateTime> arg) { throw null; }
        [System.Data.Objects.DataClasses.EdmFunctionAttribute("SqlServer", "DATALENGTH")]
        public static System.Nullable<int> DataLength(System.Nullable<decimal> arg) { throw null; }
        [System.Data.Objects.DataClasses.EdmFunctionAttribute("SqlServer", "DATALENGTH")]
        public static System.Nullable<int> DataLength(System.Nullable<double> arg) { throw null; }
        [System.Data.Objects.DataClasses.EdmFunctionAttribute("SqlServer", "DATALENGTH")]
        public static System.Nullable<int> DataLength(System.Nullable<System.Guid> arg) { throw null; }
        [System.Data.Objects.DataClasses.EdmFunctionAttribute("SqlServer", "DATALENGTH")]
        public static System.Nullable<int> DataLength(System.Nullable<System.TimeSpan> arg) { throw null; }
        [System.Data.Objects.DataClasses.EdmFunctionAttribute("SqlServer", "DATALENGTH")]
        public static System.Nullable<int> DataLength(string arg) { throw null; }
        [System.Data.Objects.DataClasses.EdmFunctionAttribute("SqlServer", "DATEADD")]
        public static System.Nullable<System.DateTimeOffset> DateAdd(string datePartArg, System.Nullable<double> number, System.Nullable<System.DateTimeOffset> dateTimeOffsetArg) { throw null; }
        [System.Data.Objects.DataClasses.EdmFunctionAttribute("SqlServer", "DATEADD")]
        public static System.Nullable<System.DateTime> DateAdd(string datePartArg, System.Nullable<double> number, System.Nullable<System.DateTime> date) { throw null; }
        [System.Data.Objects.DataClasses.EdmFunctionAttribute("SqlServer", "DATEADD")]
        public static System.Nullable<System.TimeSpan> DateAdd(string datePartArg, System.Nullable<double> number, System.Nullable<System.TimeSpan> time) { throw null; }
        [System.Data.Objects.DataClasses.EdmFunctionAttribute("SqlServer", "DATEADD")]
        public static System.Nullable<System.DateTime> DateAdd(string datePartArg, System.Nullable<double> number, string date) { throw null; }
        [System.Data.Objects.DataClasses.EdmFunctionAttribute("SqlServer", "DATEDIFF")]
        public static System.Nullable<int> DateDiff(string datePartArg, System.Nullable<System.DateTimeOffset> startDate, System.Nullable<System.DateTimeOffset> endDate) { throw null; }
        [System.Data.Objects.DataClasses.EdmFunctionAttribute("SqlServer", "DATEDIFF")]
        public static System.Nullable<int> DateDiff(string datePartArg, System.Nullable<System.DateTimeOffset> startDate, System.Nullable<System.DateTime> endDate) { throw null; }
        [System.Data.Objects.DataClasses.EdmFunctionAttribute("SqlServer", "DATEDIFF")]
        public static System.Nullable<int> DateDiff(string datePartArg, System.Nullable<System.DateTimeOffset> startDate, System.Nullable<System.TimeSpan> endDate) { throw null; }
        [System.Data.Objects.DataClasses.EdmFunctionAttribute("SqlServer", "DATEDIFF")]
        public static System.Nullable<int> DateDiff(string datePartArg, System.Nullable<System.DateTimeOffset> startDate, string endDate) { throw null; }
        [System.Data.Objects.DataClasses.EdmFunctionAttribute("SqlServer", "DATEDIFF")]
        public static System.Nullable<int> DateDiff(string datePartArg, System.Nullable<System.DateTime> startDate, System.Nullable<System.DateTimeOffset> endDate) { throw null; }
        [System.Data.Objects.DataClasses.EdmFunctionAttribute("SqlServer", "DATEDIFF")]
        public static System.Nullable<int> DateDiff(string datePartArg, System.Nullable<System.DateTime> startDate, System.Nullable<System.DateTime> endDate) { throw null; }
        [System.Data.Objects.DataClasses.EdmFunctionAttribute("SqlServer", "DATEDIFF")]
        public static System.Nullable<int> DateDiff(string datePartArg, System.Nullable<System.DateTime> startDate, System.Nullable<System.TimeSpan> endDate) { throw null; }
        [System.Data.Objects.DataClasses.EdmFunctionAttribute("SqlServer", "DATEDIFF")]
        public static System.Nullable<int> DateDiff(string datePartArg, System.Nullable<System.DateTime> startDate, string endDate) { throw null; }
        [System.Data.Objects.DataClasses.EdmFunctionAttribute("SqlServer", "DATEDIFF")]
        public static System.Nullable<int> DateDiff(string datePartArg, System.Nullable<System.TimeSpan> startDate, System.Nullable<System.DateTimeOffset> endDate) { throw null; }
        [System.Data.Objects.DataClasses.EdmFunctionAttribute("SqlServer", "DATEDIFF")]
        public static System.Nullable<int> DateDiff(string datePartArg, System.Nullable<System.TimeSpan> startDate, System.Nullable<System.DateTime> endDate) { throw null; }
        [System.Data.Objects.DataClasses.EdmFunctionAttribute("SqlServer", "DATEDIFF")]
        public static System.Nullable<int> DateDiff(string datePartArg, System.Nullable<System.TimeSpan> startDate, System.Nullable<System.TimeSpan> endDate) { throw null; }
        [System.Data.Objects.DataClasses.EdmFunctionAttribute("SqlServer", "DATEDIFF")]
        public static System.Nullable<int> DateDiff(string datePartArg, System.Nullable<System.TimeSpan> startDate, string endDate) { throw null; }
        [System.Data.Objects.DataClasses.EdmFunctionAttribute("SqlServer", "DATEDIFF")]
        public static System.Nullable<int> DateDiff(string datePartArg, string startDate, System.Nullable<System.DateTimeOffset> endDate) { throw null; }
        [System.Data.Objects.DataClasses.EdmFunctionAttribute("SqlServer", "DATEDIFF")]
        public static System.Nullable<int> DateDiff(string datePartArg, string startDate, System.Nullable<System.DateTime> endDate) { throw null; }
        [System.Data.Objects.DataClasses.EdmFunctionAttribute("SqlServer", "DATEDIFF")]
        public static System.Nullable<int> DateDiff(string datePartArg, string startDate, System.Nullable<System.TimeSpan> endDate) { throw null; }
        [System.Data.Objects.DataClasses.EdmFunctionAttribute("SqlServer", "DATEDIFF")]
        public static System.Nullable<int> DateDiff(string datePartArg, string startDate, string endDate) { throw null; }
        [System.Data.Objects.DataClasses.EdmFunctionAttribute("SqlServer", "DATENAME")]
        public static string DateName(string datePartArg, System.Nullable<System.DateTimeOffset> date) { throw null; }
        [System.Data.Objects.DataClasses.EdmFunctionAttribute("SqlServer", "DATENAME")]
        public static string DateName(string datePartArg, System.Nullable<System.DateTime> date) { throw null; }
        [System.Data.Objects.DataClasses.EdmFunctionAttribute("SqlServer", "DATENAME")]
        public static string DateName(string datePartArg, System.Nullable<System.TimeSpan> date) { throw null; }
        [System.Data.Objects.DataClasses.EdmFunctionAttribute("SqlServer", "DATENAME")]
        public static string DateName(string datePartArg, string date) { throw null; }
        [System.Data.Objects.DataClasses.EdmFunctionAttribute("SqlServer", "DATEPART")]
        public static System.Nullable<int> DatePart(string datePartArg, System.Nullable<System.DateTimeOffset> date) { throw null; }
        [System.Data.Objects.DataClasses.EdmFunctionAttribute("SqlServer", "DATEPART")]
        public static System.Nullable<int> DatePart(string datePartArg, System.Nullable<System.DateTime> date) { throw null; }
        [System.Data.Objects.DataClasses.EdmFunctionAttribute("SqlServer", "DATEPART")]
        public static System.Nullable<int> DatePart(string datePartArg, System.Nullable<System.TimeSpan> date) { throw null; }
        [System.Data.Objects.DataClasses.EdmFunctionAttribute("SqlServer", "DATEPART")]
        public static System.Nullable<int> DatePart(string datePartArg, string date) { throw null; }
        [System.Data.Objects.DataClasses.EdmFunctionAttribute("SqlServer", "DEGREES")]
        public static System.Nullable<decimal> Degrees(System.Nullable<decimal> arg1) { throw null; }
        [System.Data.Objects.DataClasses.EdmFunctionAttribute("SqlServer", "DEGREES")]
        public static System.Nullable<double> Degrees(System.Nullable<double> arg1) { throw null; }
        [System.Data.Objects.DataClasses.EdmFunctionAttribute("SqlServer", "DEGREES")]
        public static System.Nullable<int> Degrees(System.Nullable<int> arg1) { throw null; }
        [System.Data.Objects.DataClasses.EdmFunctionAttribute("SqlServer", "DEGREES")]
        public static System.Nullable<long> Degrees(System.Nullable<long> arg1) { throw null; }
        [System.Data.Objects.DataClasses.EdmFunctionAttribute("SqlServer", "DIFFERENCE")]
        public static System.Nullable<int> Difference(string string1, string string2) { throw null; }
        [System.Data.Objects.DataClasses.EdmFunctionAttribute("SqlServer", "EXP")]
        public static System.Nullable<double> Exp(System.Nullable<decimal> arg) { throw null; }
        [System.Data.Objects.DataClasses.EdmFunctionAttribute("SqlServer", "EXP")]
        public static System.Nullable<double> Exp(System.Nullable<double> arg) { throw null; }
        [System.Data.Objects.DataClasses.EdmFunctionAttribute("SqlServer", "GETDATE")]
        public static System.Nullable<System.DateTime> GetDate() { throw null; }
        [System.Data.Objects.DataClasses.EdmFunctionAttribute("SqlServer", "GETUTCDATE")]
        public static System.Nullable<System.DateTime> GetUtcDate() { throw null; }
        [System.Data.Objects.DataClasses.EdmFunctionAttribute("SqlServer", "HOST_NAME")]
        public static string HostName() { throw null; }
        [System.Data.Objects.DataClasses.EdmFunctionAttribute("SqlServer", "ISDATE")]
        public static System.Nullable<int> IsDate(string arg) { throw null; }
        [System.Data.Objects.DataClasses.EdmFunctionAttribute("SqlServer", "ISNUMERIC")]
        public static System.Nullable<int> IsNumeric(string arg) { throw null; }
        [System.Data.Objects.DataClasses.EdmFunctionAttribute("SqlServer", "LOG")]
        public static System.Nullable<double> Log(System.Nullable<decimal> arg) { throw null; }
        [System.Data.Objects.DataClasses.EdmFunctionAttribute("SqlServer", "LOG")]
        public static System.Nullable<double> Log(System.Nullable<double> arg) { throw null; }
        [System.Data.Objects.DataClasses.EdmFunctionAttribute("SqlServer", "LOG10")]
        public static System.Nullable<double> Log10(System.Nullable<decimal> arg) { throw null; }
        [System.Data.Objects.DataClasses.EdmFunctionAttribute("SqlServer", "LOG10")]
        public static System.Nullable<double> Log10(System.Nullable<double> arg) { throw null; }
        [System.Data.Objects.DataClasses.EdmFunctionAttribute("SqlServer", "NCHAR")]
        public static string NChar(System.Nullable<int> arg) { throw null; }
        [System.Data.Objects.DataClasses.EdmFunctionAttribute("SqlServer", "PATINDEX")]
        public static System.Nullable<int> PatIndex(string stringPattern, string target) { throw null; }
        [System.Data.Objects.DataClasses.EdmFunctionAttribute("SqlServer", "PI")]
        public static System.Nullable<double> Pi() { throw null; }
        [System.Data.Objects.DataClasses.EdmFunctionAttribute("SqlServer", "QUOTENAME")]
        public static string QuoteName(string stringArg) { throw null; }
        [System.Data.Objects.DataClasses.EdmFunctionAttribute("SqlServer", "QUOTENAME")]
        public static string QuoteName(string stringArg, string quoteCharacter) { throw null; }
        [System.Data.Objects.DataClasses.EdmFunctionAttribute("SqlServer", "RADIANS")]
        public static System.Nullable<decimal> Radians(System.Nullable<decimal> arg) { throw null; }
        [System.Data.Objects.DataClasses.EdmFunctionAttribute("SqlServer", "RADIANS")]
        public static System.Nullable<double> Radians(System.Nullable<double> arg) { throw null; }
        [System.Data.Objects.DataClasses.EdmFunctionAttribute("SqlServer", "RADIANS")]
        public static System.Nullable<int> Radians(System.Nullable<int> arg) { throw null; }
        [System.Data.Objects.DataClasses.EdmFunctionAttribute("SqlServer", "RADIANS")]
        public static System.Nullable<long> Radians(System.Nullable<long> arg) { throw null; }
        [System.Data.Objects.DataClasses.EdmFunctionAttribute("SqlServer", "RAND")]
        public static System.Nullable<double> Rand() { throw null; }
        [System.Data.Objects.DataClasses.EdmFunctionAttribute("SqlServer", "RAND")]
        public static System.Nullable<double> Rand(System.Nullable<int> seed) { throw null; }
        [System.Data.Objects.DataClasses.EdmFunctionAttribute("SqlServer", "REPLICATE")]
        public static string Replicate(string target, System.Nullable<int> count) { throw null; }
        [System.Data.Objects.DataClasses.EdmFunctionAttribute("SqlServer", "SIGN")]
        public static System.Nullable<decimal> Sign(System.Nullable<decimal> arg) { throw null; }
        [System.Data.Objects.DataClasses.EdmFunctionAttribute("SqlServer", "SIGN")]
        public static System.Nullable<double> Sign(System.Nullable<double> arg) { throw null; }
        [System.Data.Objects.DataClasses.EdmFunctionAttribute("SqlServer", "SIGN")]
        public static System.Nullable<int> Sign(System.Nullable<int> arg) { throw null; }
        [System.Data.Objects.DataClasses.EdmFunctionAttribute("SqlServer", "SIGN")]
        public static System.Nullable<long> Sign(System.Nullable<long> arg) { throw null; }
        [System.Data.Objects.DataClasses.EdmFunctionAttribute("SqlServer", "SIN")]
        public static System.Nullable<double> Sin(System.Nullable<decimal> arg) { throw null; }
        [System.Data.Objects.DataClasses.EdmFunctionAttribute("SqlServer", "SIN")]
        public static System.Nullable<double> Sin(System.Nullable<double> arg) { throw null; }
        [System.Data.Objects.DataClasses.EdmFunctionAttribute("SqlServer", "SOUNDEX")]
        public static string SoundCode(string arg) { throw null; }
        [System.Data.Objects.DataClasses.EdmFunctionAttribute("SqlServer", "SPACE")]
        public static string Space(System.Nullable<int> arg1) { throw null; }
        [System.Data.Objects.DataClasses.EdmFunctionAttribute("SqlServer", "SQUARE")]
        public static System.Nullable<double> Square(System.Nullable<decimal> arg1) { throw null; }
        [System.Data.Objects.DataClasses.EdmFunctionAttribute("SqlServer", "SQUARE")]
        public static System.Nullable<double> Square(System.Nullable<double> arg1) { throw null; }
        [System.Data.Objects.DataClasses.EdmFunctionAttribute("SqlServer", "SQRT")]
        public static System.Nullable<double> SquareRoot(System.Nullable<decimal> arg) { throw null; }
        [System.Data.Objects.DataClasses.EdmFunctionAttribute("SqlServer", "SQRT")]
        public static System.Nullable<double> SquareRoot(System.Nullable<double> arg) { throw null; }
        [System.Data.Objects.DataClasses.EdmFunctionAttribute("SqlServer", "STR")]
        public static string StringConvert(System.Nullable<decimal> number) { throw null; }
        [System.Data.Objects.DataClasses.EdmFunctionAttribute("SqlServer", "STR")]
        public static string StringConvert(System.Nullable<decimal> number, System.Nullable<int> length) { throw null; }
        [System.Data.Objects.DataClasses.EdmFunctionAttribute("SqlServer", "STR")]
        public static string StringConvert(System.Nullable<decimal> number, System.Nullable<int> length, System.Nullable<int> decimalArg) { throw null; }
        [System.Data.Objects.DataClasses.EdmFunctionAttribute("SqlServer", "STR")]
        public static string StringConvert(System.Nullable<double> number) { throw null; }
        [System.Data.Objects.DataClasses.EdmFunctionAttribute("SqlServer", "STR")]
        public static string StringConvert(System.Nullable<double> number, System.Nullable<int> length) { throw null; }
        [System.Data.Objects.DataClasses.EdmFunctionAttribute("SqlServer", "STR")]
        public static string StringConvert(System.Nullable<double> number, System.Nullable<int> length, System.Nullable<int> decimalArg) { throw null; }
        [System.Data.Objects.DataClasses.EdmFunctionAttribute("SqlServer", "STUFF")]
        public static string Stuff(string stringInput, System.Nullable<int> start, System.Nullable<int> length, string stringReplacement) { throw null; }
        [System.Data.Objects.DataClasses.EdmFunctionAttribute("SqlServer", "TAN")]
        public static System.Nullable<double> Tan(System.Nullable<decimal> arg) { throw null; }
        [System.Data.Objects.DataClasses.EdmFunctionAttribute("SqlServer", "TAN")]
        public static System.Nullable<double> Tan(System.Nullable<double> arg) { throw null; }
        [System.Data.Objects.DataClasses.EdmFunctionAttribute("SqlServer", "UNICODE")]
        public static System.Nullable<int> Unicode(string arg) { throw null; }
        [System.Data.Objects.DataClasses.EdmFunctionAttribute("SqlServer", "USER_NAME")]
        public static string UserName() { throw null; }
        [System.Data.Objects.DataClasses.EdmFunctionAttribute("SqlServer", "USER_NAME")]
        public static string UserName(System.Nullable<int> arg) { throw null; }
    }
    public static partial class SqlSpatialFunctions
    {
        [System.Data.Objects.DataClasses.EdmFunctionAttribute("SqlServer", "ASTEXTZM")]
        public static string AsTextZM(System.Data.Spatial.DbGeography geographyValue) { throw null; }
        [System.Data.Objects.DataClasses.EdmFunctionAttribute("SqlServer", "ASTEXTZM")]
        public static string AsTextZM(System.Data.Spatial.DbGeometry geometryValue) { throw null; }
        [System.Data.Objects.DataClasses.EdmFunctionAttribute("SqlServer", "BUFFERWITHTOLERANCE")]
        public static System.Data.Spatial.DbGeography BufferWithTolerance(System.Data.Spatial.DbGeography geographyValue, System.Nullable<double> distance, System.Nullable<double> tolerance, System.Nullable<bool> relative) { throw null; }
        [System.Data.Objects.DataClasses.EdmFunctionAttribute("SqlServer", "BUFFERWITHTOLERANCE")]
        public static System.Data.Spatial.DbGeometry BufferWithTolerance(System.Data.Spatial.DbGeometry geometryValue, System.Nullable<double> distance, System.Nullable<double> tolerance, System.Nullable<bool> relative) { throw null; }
        [System.Data.Objects.DataClasses.EdmFunctionAttribute("SqlServer", "ENVELOPEANGLE")]
        public static System.Nullable<double> EnvelopeAngle(System.Data.Spatial.DbGeography geographyValue) { throw null; }
        [System.Data.Objects.DataClasses.EdmFunctionAttribute("SqlServer", "ENVELOPECENTER")]
        public static System.Data.Spatial.DbGeography EnvelopeCenter(System.Data.Spatial.DbGeography geographyValue) { throw null; }
        [System.Data.Objects.DataClasses.EdmFunctionAttribute("SqlServer", "FILTER")]
        public static System.Nullable<bool> Filter(System.Data.Spatial.DbGeography geographyValue, System.Data.Spatial.DbGeography geographyOther) { throw null; }
        [System.Data.Objects.DataClasses.EdmFunctionAttribute("SqlServer", "FILTER")]
        public static System.Nullable<bool> Filter(System.Data.Spatial.DbGeometry geometryValue, System.Data.Spatial.DbGeometry geometryOther) { throw null; }
        [System.Data.Objects.DataClasses.EdmFunctionAttribute("SqlServer", "INSTANCEOF")]
        public static System.Nullable<bool> InstanceOf(System.Data.Spatial.DbGeography geographyValue, string geometryTypeName) { throw null; }
        [System.Data.Objects.DataClasses.EdmFunctionAttribute("SqlServer", "INSTANCEOF")]
        public static System.Nullable<bool> InstanceOf(System.Data.Spatial.DbGeometry geometryValue, string geometryTypeName) { throw null; }
        [System.Data.Objects.DataClasses.EdmFunctionAttribute("SqlServer", "MAKEVALID")]
        public static System.Data.Spatial.DbGeometry MakeValid(System.Data.Spatial.DbGeometry geometryValue) { throw null; }
        [System.Data.Objects.DataClasses.EdmFunctionAttribute("SqlServer", "NUMRINGS")]
        public static System.Nullable<int> NumRings(System.Data.Spatial.DbGeography geographyValue) { throw null; }
        [System.Data.Objects.DataClasses.EdmFunctionAttribute("SqlServer", "POINTGEOGRAPHY")]
        public static System.Data.Spatial.DbGeography PointGeography(System.Nullable<double> latitude, System.Nullable<double> longitude, System.Nullable<int> spatialReferenceId) { throw null; }
        [System.Data.Objects.DataClasses.EdmFunctionAttribute("SqlServer", "POINTGEOMETRY")]
        public static System.Data.Spatial.DbGeometry PointGeometry(System.Nullable<double> xCoordinate, System.Nullable<double> yCoordinate, System.Nullable<int> spatialReferenceId) { throw null; }
        [System.Data.Objects.DataClasses.EdmFunctionAttribute("SqlServer", "REDUCE")]
        public static System.Data.Spatial.DbGeography Reduce(System.Data.Spatial.DbGeography geographyValue, System.Nullable<double> tolerance) { throw null; }
        [System.Data.Objects.DataClasses.EdmFunctionAttribute("SqlServer", "REDUCE")]
        public static System.Data.Spatial.DbGeometry Reduce(System.Data.Spatial.DbGeometry geometryValue, System.Nullable<double> tolerance) { throw null; }
        [System.Data.Objects.DataClasses.EdmFunctionAttribute("SqlServer", "RINGN")]
        public static System.Data.Spatial.DbGeography RingN(System.Data.Spatial.DbGeography geographyValue, System.Nullable<int> index) { throw null; }
    }
}
namespace System.Data.Spatial
{
    [System.ComponentModel.DataAnnotations.BindableTypeAttribute]
    [System.Runtime.Serialization.DataContractAttribute]
    [System.SerializableAttribute]
    public partial class DbGeography
    {
        internal DbGeography() { }
        public System.Nullable<double> Area { get { throw null; } }
        public int CoordinateSystemId { get { throw null; } }
        public static int DefaultCoordinateSystemId { get { throw null; } }
        public int Dimension { get { throw null; } }
        public System.Nullable<int> ElementCount { get { throw null; } }
        public System.Nullable<double> Elevation { get { throw null; } }
        public System.Data.Spatial.DbGeography EndPoint { get { throw null; } }
        public System.Nullable<bool> IsClosed { get { throw null; } }
        public bool IsEmpty { get { throw null; } }
        public System.Nullable<double> Latitude { get { throw null; } }
        public System.Nullable<double> Length { get { throw null; } }
        public System.Nullable<double> Longitude { get { throw null; } }
        public System.Nullable<double> Measure { get { throw null; } }
        public System.Nullable<int> PointCount { get { throw null; } }
        public object ProviderValue { get { throw null; } }
        public string SpatialTypeName { get { throw null; } }
        public System.Data.Spatial.DbGeography StartPoint { get { throw null; } }
        [System.Runtime.Serialization.DataMemberAttribute(Name="Geography")]
        public System.Data.Spatial.DbGeographyWellKnownValue WellKnownValue { get { throw null; } set { } }
        public byte[] AsBinary() { throw null; }
        public string AsGml() { throw null; }
        public string AsText() { throw null; }
        public System.Data.Spatial.DbGeography Buffer(System.Nullable<double> distance) { throw null; }
        public System.Data.Spatial.DbGeography Difference(System.Data.Spatial.DbGeography other) { throw null; }
        public bool Disjoint(System.Data.Spatial.DbGeography other) { throw null; }
        public System.Nullable<double> Distance(System.Data.Spatial.DbGeography other) { throw null; }
        public System.Data.Spatial.DbGeography ElementAt(int index) { throw null; }
        public static System.Data.Spatial.DbGeography FromBinary(byte[] wellKnownBinary) { throw null; }
        public static System.Data.Spatial.DbGeography FromBinary(byte[] wellKnownBinary, int coordinateSystemId) { throw null; }
        public static System.Data.Spatial.DbGeography FromGml(string geographyMarkup) { throw null; }
        public static System.Data.Spatial.DbGeography FromGml(string geographyMarkup, int coordinateSystemId) { throw null; }
        public static System.Data.Spatial.DbGeography FromText(string wellKnownText) { throw null; }
        public static System.Data.Spatial.DbGeography FromText(string wellKnownText, int coordinateSystemId) { throw null; }
        public static System.Data.Spatial.DbGeography GeographyCollectionFromBinary(byte[] geographyCollectionWellKnownBinary, int coordinateSystemId) { throw null; }
        public static System.Data.Spatial.DbGeography GeographyCollectionFromText(string geographyCollectionWellKnownText, int coordinateSystemId) { throw null; }
        public System.Data.Spatial.DbGeography Intersection(System.Data.Spatial.DbGeography other) { throw null; }
        public bool Intersects(System.Data.Spatial.DbGeography other) { throw null; }
        public static System.Data.Spatial.DbGeography LineFromBinary(byte[] lineWellKnownBinary, int coordinateSystemId) { throw null; }
        public static System.Data.Spatial.DbGeography LineFromText(string lineWellKnownText, int coordinateSystemId) { throw null; }
        public static System.Data.Spatial.DbGeography MultiLineFromBinary(byte[] multiLineWellKnownBinary, int coordinateSystemId) { throw null; }
        public static System.Data.Spatial.DbGeography MultiLineFromText(string multiLineWellKnownText, int coordinateSystemId) { throw null; }
        public static System.Data.Spatial.DbGeography MultiPointFromBinary(byte[] multiPointWellKnownBinary, int coordinateSystemId) { throw null; }
        public static System.Data.Spatial.DbGeography MultiPointFromText(string multiPointWellKnownText, int coordinateSystemId) { throw null; }
        public static System.Data.Spatial.DbGeography MultiPolygonFromBinary(byte[] multiPolygonWellKnownBinary, int coordinateSystemId) { throw null; }
        public static System.Data.Spatial.DbGeography MultiPolygonFromText(string multiPolygonWellKnownText, int coordinateSystemId) { throw null; }
        public System.Data.Spatial.DbGeography PointAt(int index) { throw null; }
        public static System.Data.Spatial.DbGeography PointFromBinary(byte[] pointWellKnownBinary, int coordinateSystemId) { throw null; }
        public static System.Data.Spatial.DbGeography PointFromText(string pointWellKnownText, int coordinateSystemId) { throw null; }
        public static System.Data.Spatial.DbGeography PolygonFromBinary(byte[] polygonWellKnownBinary, int coordinateSystemId) { throw null; }
        public static System.Data.Spatial.DbGeography PolygonFromText(string polygonWellKnownText, int coordinateSystemId) { throw null; }
        public bool SpatialEquals(System.Data.Spatial.DbGeography other) { throw null; }
        public System.Data.Spatial.DbGeography SymmetricDifference(System.Data.Spatial.DbGeography other) { throw null; }
        public override string ToString() { throw null; }
        public System.Data.Spatial.DbGeography Union(System.Data.Spatial.DbGeography other) { throw null; }
    }
    [System.Runtime.Serialization.DataContractAttribute]
    public sealed partial class DbGeographyWellKnownValue
    {
        public DbGeographyWellKnownValue() { }
        [System.Runtime.Serialization.DataMemberAttribute(Order=1, IsRequired=false, EmitDefaultValue=false)]
        public int CoordinateSystemId { get { throw null; } set { } }
        [System.Runtime.Serialization.DataMemberAttribute(Order=3, IsRequired=false, EmitDefaultValue=false)]
        public byte[] WellKnownBinary { get { throw null; } set { } }
        [System.Runtime.Serialization.DataMemberAttribute(Order=2, IsRequired=false, EmitDefaultValue=false)]
        public string WellKnownText { get { throw null; } set { } }
    }
    [System.ComponentModel.DataAnnotations.BindableTypeAttribute]
    [System.Runtime.Serialization.DataContractAttribute]
    [System.SerializableAttribute]
    public partial class DbGeometry
    {
        internal DbGeometry() { }
        public System.Nullable<double> Area { get { throw null; } }
        public System.Data.Spatial.DbGeometry Boundary { get { throw null; } }
        public System.Data.Spatial.DbGeometry Centroid { get { throw null; } }
        public System.Data.Spatial.DbGeometry ConvexHull { get { throw null; } }
        public int CoordinateSystemId { get { throw null; } }
        public static int DefaultCoordinateSystemId { get { throw null; } }
        public int Dimension { get { throw null; } }
        public System.Nullable<int> ElementCount { get { throw null; } }
        public System.Nullable<double> Elevation { get { throw null; } }
        public System.Data.Spatial.DbGeometry EndPoint { get { throw null; } }
        public System.Data.Spatial.DbGeometry Envelope { get { throw null; } }
        public System.Data.Spatial.DbGeometry ExteriorRing { get { throw null; } }
        public System.Nullable<int> InteriorRingCount { get { throw null; } }
        public System.Nullable<bool> IsClosed { get { throw null; } }
        public bool IsEmpty { get { throw null; } }
        public System.Nullable<bool> IsRing { get { throw null; } }
        public bool IsSimple { get { throw null; } }
        public bool IsValid { get { throw null; } }
        public System.Nullable<double> Length { get { throw null; } }
        public System.Nullable<double> Measure { get { throw null; } }
        public System.Nullable<int> PointCount { get { throw null; } }
        public System.Data.Spatial.DbGeometry PointOnSurface { get { throw null; } }
        public object ProviderValue { get { throw null; } }
        public string SpatialTypeName { get { throw null; } }
        public System.Data.Spatial.DbGeometry StartPoint { get { throw null; } }
        [System.Runtime.Serialization.DataMemberAttribute(Name="Geometry")]
        public System.Data.Spatial.DbGeometryWellKnownValue WellKnownValue { get { throw null; } set { } }
        public System.Nullable<double> XCoordinate { get { throw null; } }
        public System.Nullable<double> YCoordinate { get { throw null; } }
        public byte[] AsBinary() { throw null; }
        public string AsGml() { throw null; }
        public string AsText() { throw null; }
        public System.Data.Spatial.DbGeometry Buffer(System.Nullable<double> distance) { throw null; }
        public bool Contains(System.Data.Spatial.DbGeometry other) { throw null; }
        public bool Crosses(System.Data.Spatial.DbGeometry other) { throw null; }
        public System.Data.Spatial.DbGeometry Difference(System.Data.Spatial.DbGeometry other) { throw null; }
        public bool Disjoint(System.Data.Spatial.DbGeometry other) { throw null; }
        public System.Nullable<double> Distance(System.Data.Spatial.DbGeometry other) { throw null; }
        public System.Data.Spatial.DbGeometry ElementAt(int index) { throw null; }
        public static System.Data.Spatial.DbGeometry FromBinary(byte[] wellKnownBinary) { throw null; }
        public static System.Data.Spatial.DbGeometry FromBinary(byte[] wellKnownBinary, int coordinateSystemId) { throw null; }
        public static System.Data.Spatial.DbGeometry FromGml(string geometryMarkup) { throw null; }
        public static System.Data.Spatial.DbGeometry FromGml(string geometryMarkup, int coordinateSystemId) { throw null; }
        public static System.Data.Spatial.DbGeometry FromText(string wellKnownText) { throw null; }
        public static System.Data.Spatial.DbGeometry FromText(string wellKnownText, int coordinateSystemId) { throw null; }
        public static System.Data.Spatial.DbGeometry GeometryCollectionFromBinary(byte[] geometryCollectionWellKnownBinary, int coordinateSystemId) { throw null; }
        public static System.Data.Spatial.DbGeometry GeometryCollectionFromText(string geometryCollectionWellKnownText, int coordinateSystemId) { throw null; }
        public System.Data.Spatial.DbGeometry InteriorRingAt(int index) { throw null; }
        public System.Data.Spatial.DbGeometry Intersection(System.Data.Spatial.DbGeometry other) { throw null; }
        public bool Intersects(System.Data.Spatial.DbGeometry other) { throw null; }
        public static System.Data.Spatial.DbGeometry LineFromBinary(byte[] lineWellKnownBinary, int coordinateSystemId) { throw null; }
        public static System.Data.Spatial.DbGeometry LineFromText(string lineWellKnownText, int coordinateSystemId) { throw null; }
        public static System.Data.Spatial.DbGeometry MultiLineFromBinary(byte[] multiLineWellKnownBinary, int coordinateSystemId) { throw null; }
        public static System.Data.Spatial.DbGeometry MultiLineFromText(string multiLineWellKnownText, int coordinateSystemId) { throw null; }
        public static System.Data.Spatial.DbGeometry MultiPointFromBinary(byte[] multiPointWellKnownBinary, int coordinateSystemId) { throw null; }
        public static System.Data.Spatial.DbGeometry MultiPointFromText(string multiPointWellKnownText, int coordinateSystemId) { throw null; }
        public static System.Data.Spatial.DbGeometry MultiPolygonFromBinary(byte[] multiPolygonWellKnownBinary, int coordinateSystemId) { throw null; }
        public static System.Data.Spatial.DbGeometry MultiPolygonFromText(string multiPolygonWellKnownText, int coordinateSystemId) { throw null; }
        public bool Overlaps(System.Data.Spatial.DbGeometry other) { throw null; }
        public System.Data.Spatial.DbGeometry PointAt(int index) { throw null; }
        public static System.Data.Spatial.DbGeometry PointFromBinary(byte[] pointWellKnownBinary, int coordinateSystemId) { throw null; }
        public static System.Data.Spatial.DbGeometry PointFromText(string pointWellKnownText, int coordinateSystemId) { throw null; }
        public static System.Data.Spatial.DbGeometry PolygonFromBinary(byte[] polygonWellKnownBinary, int coordinateSystemId) { throw null; }
        public static System.Data.Spatial.DbGeometry PolygonFromText(string polygonWellKnownText, int coordinateSystemId) { throw null; }
        public bool Relate(System.Data.Spatial.DbGeometry other, string matrix) { throw null; }
        public bool SpatialEquals(System.Data.Spatial.DbGeometry other) { throw null; }
        public System.Data.Spatial.DbGeometry SymmetricDifference(System.Data.Spatial.DbGeometry other) { throw null; }
        public override string ToString() { throw null; }
        public bool Touches(System.Data.Spatial.DbGeometry other) { throw null; }
        public System.Data.Spatial.DbGeometry Union(System.Data.Spatial.DbGeometry other) { throw null; }
        public bool Within(System.Data.Spatial.DbGeometry other) { throw null; }
    }
    [System.Runtime.Serialization.DataContractAttribute]
    public sealed partial class DbGeometryWellKnownValue
    {
        public DbGeometryWellKnownValue() { }
        [System.Runtime.Serialization.DataMemberAttribute(Order=1, IsRequired=false, EmitDefaultValue=false)]
        public int CoordinateSystemId { get { throw null; } set { } }
        [System.Runtime.Serialization.DataMemberAttribute(Order=3, IsRequired=false, EmitDefaultValue=false)]
        public byte[] WellKnownBinary { get { throw null; } set { } }
        [System.Runtime.Serialization.DataMemberAttribute(Order=2, IsRequired=false, EmitDefaultValue=false)]
        public string WellKnownText { get { throw null; } set { } }
    }
    public abstract partial class DbSpatialDataReader
    {
        protected DbSpatialDataReader() { }
        public abstract System.Data.Spatial.DbGeography GetGeography(int ordinal);
        public abstract System.Data.Spatial.DbGeometry GetGeometry(int ordinal);
    }
    [System.SerializableAttribute]
    public abstract partial class DbSpatialServices
    {
        protected DbSpatialServices() { }
        public static System.Data.Spatial.DbSpatialServices Default { get { throw null; } }
        public abstract byte[] AsBinary(System.Data.Spatial.DbGeography geographyValue);
        public abstract byte[] AsBinary(System.Data.Spatial.DbGeometry geometryValue);
        public abstract string AsGml(System.Data.Spatial.DbGeography geographyValue);
        public abstract string AsGml(System.Data.Spatial.DbGeometry geometryValue);
        public abstract string AsText(System.Data.Spatial.DbGeography geographyValue);
        public abstract string AsText(System.Data.Spatial.DbGeometry geometryValue);
        public virtual string AsTextIncludingElevationAndMeasure(System.Data.Spatial.DbGeography geographyValue) { throw null; }
        public virtual string AsTextIncludingElevationAndMeasure(System.Data.Spatial.DbGeometry geometryValue) { throw null; }
        public abstract System.Data.Spatial.DbGeography Buffer(System.Data.Spatial.DbGeography geographyValue, double distance);
        public abstract System.Data.Spatial.DbGeometry Buffer(System.Data.Spatial.DbGeometry geometryValue, double distance);
        public abstract bool Contains(System.Data.Spatial.DbGeometry geometryValue, System.Data.Spatial.DbGeometry otherGeometry);
        protected static System.Data.Spatial.DbGeography CreateGeography(System.Data.Spatial.DbSpatialServices spatialServices, object providerValue) { throw null; }
        protected static System.Data.Spatial.DbGeometry CreateGeometry(System.Data.Spatial.DbSpatialServices spatialServices, object providerValue) { throw null; }
        public abstract object CreateProviderValue(System.Data.Spatial.DbGeographyWellKnownValue wellKnownValue);
        public abstract object CreateProviderValue(System.Data.Spatial.DbGeometryWellKnownValue wellKnownValue);
        public abstract System.Data.Spatial.DbGeographyWellKnownValue CreateWellKnownValue(System.Data.Spatial.DbGeography geographyValue);
        public abstract System.Data.Spatial.DbGeometryWellKnownValue CreateWellKnownValue(System.Data.Spatial.DbGeometry geometryValue);
        public abstract bool Crosses(System.Data.Spatial.DbGeometry geometryValue, System.Data.Spatial.DbGeometry otherGeometry);
        public abstract System.Data.Spatial.DbGeography Difference(System.Data.Spatial.DbGeography geographyValue, System.Data.Spatial.DbGeography otherGeography);
        public abstract System.Data.Spatial.DbGeometry Difference(System.Data.Spatial.DbGeometry geometryValue, System.Data.Spatial.DbGeometry otherGeometry);
        public abstract bool Disjoint(System.Data.Spatial.DbGeography geographyValue, System.Data.Spatial.DbGeography otherGeography);
        public abstract bool Disjoint(System.Data.Spatial.DbGeometry geometryValue, System.Data.Spatial.DbGeometry otherGeometry);
        public abstract double Distance(System.Data.Spatial.DbGeography geographyValue, System.Data.Spatial.DbGeography otherGeography);
        public abstract double Distance(System.Data.Spatial.DbGeometry geometryValue, System.Data.Spatial.DbGeometry otherGeometry);
        public abstract System.Data.Spatial.DbGeography ElementAt(System.Data.Spatial.DbGeography geographyValue, int index);
        public abstract System.Data.Spatial.DbGeometry ElementAt(System.Data.Spatial.DbGeometry geometryValue, int index);
        public abstract System.Data.Spatial.DbGeography GeographyCollectionFromBinary(byte[] geographyCollectionWellKnownBinary, int coordinateSystemId);
        public abstract System.Data.Spatial.DbGeography GeographyCollectionFromText(string geographyCollectionWellKnownText, int coordinateSystemId);
        public abstract System.Data.Spatial.DbGeography GeographyFromBinary(byte[] wellKnownBinary);
        public abstract System.Data.Spatial.DbGeography GeographyFromBinary(byte[] wellKnownBinary, int coordinateSystemId);
        public abstract System.Data.Spatial.DbGeography GeographyFromGml(string geographyMarkup);
        public abstract System.Data.Spatial.DbGeography GeographyFromGml(string geographyMarkup, int coordinateSystemId);
        public abstract System.Data.Spatial.DbGeography GeographyFromProviderValue(object providerValue);
        public abstract System.Data.Spatial.DbGeography GeographyFromText(string wellKnownText);
        public abstract System.Data.Spatial.DbGeography GeographyFromText(string wellKnownText, int coordinateSystemId);
        public abstract System.Data.Spatial.DbGeography GeographyLineFromBinary(byte[] lineWellKnownBinary, int coordinateSystemId);
        public abstract System.Data.Spatial.DbGeography GeographyLineFromText(string lineWellKnownText, int coordinateSystemId);
        public abstract System.Data.Spatial.DbGeography GeographyMultiLineFromBinary(byte[] multiLineWellKnownBinary, int coordinateSystemId);
        public abstract System.Data.Spatial.DbGeography GeographyMultiLineFromText(string multiLineWellKnownText, int coordinateSystemId);
        public abstract System.Data.Spatial.DbGeography GeographyMultiPointFromBinary(byte[] multiPointWellKnownBinary, int coordinateSystemId);
        public abstract System.Data.Spatial.DbGeography GeographyMultiPointFromText(string multiPointWellKnownText, int coordinateSystemId);
        public abstract System.Data.Spatial.DbGeography GeographyMultiPolygonFromBinary(byte[] multiPolygonWellKnownBinary, int coordinateSystemId);
        public abstract System.Data.Spatial.DbGeography GeographyMultiPolygonFromText(string multiPolygonWellKnownText, int coordinateSystemId);
        public abstract System.Data.Spatial.DbGeography GeographyPointFromBinary(byte[] pointWellKnownBinary, int coordinateSystemId);
        public abstract System.Data.Spatial.DbGeography GeographyPointFromText(string pointWellKnownText, int coordinateSystemId);
        public abstract System.Data.Spatial.DbGeography GeographyPolygonFromBinary(byte[] polygonWellKnownBinary, int coordinateSystemId);
        public abstract System.Data.Spatial.DbGeography GeographyPolygonFromText(string polygonWellKnownText, int coordinateSystemId);
        public abstract System.Data.Spatial.DbGeometry GeometryCollectionFromBinary(byte[] geometryCollectionWellKnownBinary, int coordinateSystemId);
        public abstract System.Data.Spatial.DbGeometry GeometryCollectionFromText(string geometryCollectionWellKnownText, int coordinateSystemId);
        public abstract System.Data.Spatial.DbGeometry GeometryFromBinary(byte[] wellKnownBinary);
        public abstract System.Data.Spatial.DbGeometry GeometryFromBinary(byte[] wellKnownBinary, int coordinateSystemId);
        public abstract System.Data.Spatial.DbGeometry GeometryFromGml(string geometryMarkup);
        public abstract System.Data.Spatial.DbGeometry GeometryFromGml(string geometryMarkup, int coordinateSystemId);
        public abstract System.Data.Spatial.DbGeometry GeometryFromProviderValue(object providerValue);
        public abstract System.Data.Spatial.DbGeometry GeometryFromText(string wellKnownText);
        public abstract System.Data.Spatial.DbGeometry GeometryFromText(string wellKnownText, int coordinateSystemId);
        public abstract System.Data.Spatial.DbGeometry GeometryLineFromBinary(byte[] lineWellKnownBinary, int coordinateSystemId);
        public abstract System.Data.Spatial.DbGeometry GeometryLineFromText(string lineWellKnownText, int coordinateSystemId);
        public abstract System.Data.Spatial.DbGeometry GeometryMultiLineFromBinary(byte[] multiLineWellKnownBinary, int coordinateSystemId);
        public abstract System.Data.Spatial.DbGeometry GeometryMultiLineFromText(string multiLineWellKnownText, int coordinateSystemId);
        public abstract System.Data.Spatial.DbGeometry GeometryMultiPointFromBinary(byte[] multiPointWellKnownBinary, int coordinateSystemId);
        public abstract System.Data.Spatial.DbGeometry GeometryMultiPointFromText(string multiPointWellKnownText, int coordinateSystemId);
        public abstract System.Data.Spatial.DbGeometry GeometryMultiPolygonFromBinary(byte[] multiPolygonWellKnownBinary, int coordinateSystemId);
        public abstract System.Data.Spatial.DbGeometry GeometryMultiPolygonFromText(string multiPolygonKnownText, int coordinateSystemId);
        public abstract System.Data.Spatial.DbGeometry GeometryPointFromBinary(byte[] pointWellKnownBinary, int coordinateSystemId);
        public abstract System.Data.Spatial.DbGeometry GeometryPointFromText(string pointWellKnownText, int coordinateSystemId);
        public abstract System.Data.Spatial.DbGeometry GeometryPolygonFromBinary(byte[] polygonWellKnownBinary, int coordinateSystemId);
        public abstract System.Data.Spatial.DbGeometry GeometryPolygonFromText(string polygonWellKnownText, int coordinateSystemId);
        public abstract System.Nullable<double> GetArea(System.Data.Spatial.DbGeography geographyValue);
        public abstract System.Nullable<double> GetArea(System.Data.Spatial.DbGeometry geometryValue);
        public abstract System.Data.Spatial.DbGeometry GetBoundary(System.Data.Spatial.DbGeometry geometryValue);
        public abstract System.Data.Spatial.DbGeometry GetCentroid(System.Data.Spatial.DbGeometry geometryValue);
        public abstract System.Data.Spatial.DbGeometry GetConvexHull(System.Data.Spatial.DbGeometry geometryValue);
        public abstract int GetCoordinateSystemId(System.Data.Spatial.DbGeography geographyValue);
        public abstract int GetCoordinateSystemId(System.Data.Spatial.DbGeometry geometryValue);
        public abstract int GetDimension(System.Data.Spatial.DbGeography geographyValue);
        public abstract int GetDimension(System.Data.Spatial.DbGeometry geometryValue);
        public abstract System.Nullable<int> GetElementCount(System.Data.Spatial.DbGeography geographyValue);
        public abstract System.Nullable<int> GetElementCount(System.Data.Spatial.DbGeometry geometryValue);
        public abstract System.Nullable<double> GetElevation(System.Data.Spatial.DbGeography geographyValue);
        public abstract System.Nullable<double> GetElevation(System.Data.Spatial.DbGeometry geometryValue);
        public abstract System.Data.Spatial.DbGeography GetEndPoint(System.Data.Spatial.DbGeography geographyValue);
        public abstract System.Data.Spatial.DbGeometry GetEndPoint(System.Data.Spatial.DbGeometry geometryValue);
        public abstract System.Data.Spatial.DbGeometry GetEnvelope(System.Data.Spatial.DbGeometry geometryValue);
        public abstract System.Data.Spatial.DbGeometry GetExteriorRing(System.Data.Spatial.DbGeometry geometryValue);
        public abstract System.Nullable<int> GetInteriorRingCount(System.Data.Spatial.DbGeometry geometryValue);
        public abstract System.Nullable<bool> GetIsClosed(System.Data.Spatial.DbGeography geographyValue);
        public abstract System.Nullable<bool> GetIsClosed(System.Data.Spatial.DbGeometry geometryValue);
        public abstract bool GetIsEmpty(System.Data.Spatial.DbGeography geographyValue);
        public abstract bool GetIsEmpty(System.Data.Spatial.DbGeometry geometryValue);
        public abstract System.Nullable<bool> GetIsRing(System.Data.Spatial.DbGeometry geometryValue);
        public abstract bool GetIsSimple(System.Data.Spatial.DbGeometry geometryValue);
        public abstract bool GetIsValid(System.Data.Spatial.DbGeometry geometryValue);
        public abstract System.Nullable<double> GetLatitude(System.Data.Spatial.DbGeography geographyValue);
        public abstract System.Nullable<double> GetLength(System.Data.Spatial.DbGeography geographyValue);
        public abstract System.Nullable<double> GetLength(System.Data.Spatial.DbGeometry geometryValue);
        public abstract System.Nullable<double> GetLongitude(System.Data.Spatial.DbGeography geographyValue);
        public abstract System.Nullable<double> GetMeasure(System.Data.Spatial.DbGeography geographyValue);
        public abstract System.Nullable<double> GetMeasure(System.Data.Spatial.DbGeometry geometryValue);
        public abstract System.Nullable<int> GetPointCount(System.Data.Spatial.DbGeography geographyValue);
        public abstract System.Nullable<int> GetPointCount(System.Data.Spatial.DbGeometry geometryValue);
        public abstract System.Data.Spatial.DbGeometry GetPointOnSurface(System.Data.Spatial.DbGeometry geometryValue);
        public abstract string GetSpatialTypeName(System.Data.Spatial.DbGeography geographyValue);
        public abstract string GetSpatialTypeName(System.Data.Spatial.DbGeometry geometryValue);
        public abstract System.Data.Spatial.DbGeography GetStartPoint(System.Data.Spatial.DbGeography geographyValue);
        public abstract System.Data.Spatial.DbGeometry GetStartPoint(System.Data.Spatial.DbGeometry geometryValue);
        public abstract System.Nullable<double> GetXCoordinate(System.Data.Spatial.DbGeometry geometryValue);
        public abstract System.Nullable<double> GetYCoordinate(System.Data.Spatial.DbGeometry geometryValue);
        public abstract System.Data.Spatial.DbGeometry InteriorRingAt(System.Data.Spatial.DbGeometry geometryValue, int index);
        public abstract System.Data.Spatial.DbGeography Intersection(System.Data.Spatial.DbGeography geographyValue, System.Data.Spatial.DbGeography otherGeography);
        public abstract System.Data.Spatial.DbGeometry Intersection(System.Data.Spatial.DbGeometry geometryValue, System.Data.Spatial.DbGeometry otherGeometry);
        public abstract bool Intersects(System.Data.Spatial.DbGeography geographyValue, System.Data.Spatial.DbGeography otherGeography);
        public abstract bool Intersects(System.Data.Spatial.DbGeometry geometryValue, System.Data.Spatial.DbGeometry otherGeometry);
        public abstract bool Overlaps(System.Data.Spatial.DbGeometry geometryValue, System.Data.Spatial.DbGeometry otherGeometry);
        public abstract System.Data.Spatial.DbGeography PointAt(System.Data.Spatial.DbGeography geographyValue, int index);
        public abstract System.Data.Spatial.DbGeometry PointAt(System.Data.Spatial.DbGeometry geometryValue, int index);
        public abstract bool Relate(System.Data.Spatial.DbGeometry geometryValue, System.Data.Spatial.DbGeometry otherGeometry, string matrix);
        public abstract bool SpatialEquals(System.Data.Spatial.DbGeography geographyValue, System.Data.Spatial.DbGeography otherGeography);
        public abstract bool SpatialEquals(System.Data.Spatial.DbGeometry geometryValue, System.Data.Spatial.DbGeometry otherGeometry);
        public abstract System.Data.Spatial.DbGeography SymmetricDifference(System.Data.Spatial.DbGeography geographyValue, System.Data.Spatial.DbGeography otherGeography);
        public abstract System.Data.Spatial.DbGeometry SymmetricDifference(System.Data.Spatial.DbGeometry geometryValue, System.Data.Spatial.DbGeometry otherGeometry);
        public abstract bool Touches(System.Data.Spatial.DbGeometry geometryValue, System.Data.Spatial.DbGeometry otherGeometry);
        public abstract System.Data.Spatial.DbGeography Union(System.Data.Spatial.DbGeography geographyValue, System.Data.Spatial.DbGeography otherGeography);
        public abstract System.Data.Spatial.DbGeometry Union(System.Data.Spatial.DbGeometry geometryValue, System.Data.Spatial.DbGeometry otherGeometry);
        public abstract bool Within(System.Data.Spatial.DbGeometry geometryValue, System.Data.Spatial.DbGeometry otherGeometry);
    }
}
namespace System.Data.SqlClient
{
    [System.CLSCompliantAttribute(false)]
    public sealed partial class SqlProviderServices : System.Data.Common.DbProviderServices
    {
        internal SqlProviderServices() { }
        public static System.Data.SqlClient.SqlProviderServices SingletonInstance { get { throw null; } }
        protected override System.Data.Common.DbCommandDefinition CreateDbCommandDefinition(System.Data.Common.DbProviderManifest providerManifest, System.Data.Common.CommandTrees.DbCommandTree commandTree) { throw null; }
        protected override void DbCreateDatabase(System.Data.Common.DbConnection connection, System.Nullable<int> commandTimeout, System.Data.Metadata.Edm.StoreItemCollection storeItemCollection) { }
        protected override string DbCreateDatabaseScript(string providerManifestToken, System.Data.Metadata.Edm.StoreItemCollection storeItemCollection) { throw null; }
        protected override bool DbDatabaseExists(System.Data.Common.DbConnection connection, System.Nullable<int> commandTimeout, System.Data.Metadata.Edm.StoreItemCollection storeItemCollection) { throw null; }
        protected override void DbDeleteDatabase(System.Data.Common.DbConnection connection, System.Nullable<int> commandTimeout, System.Data.Metadata.Edm.StoreItemCollection storeItemCollection) { }
        protected override System.Data.Spatial.DbSpatialServices DbGetSpatialServices(string versionHint) { throw null; }
        protected override System.Data.Common.DbProviderManifest GetDbProviderManifest(string versionHint) { throw null; }
        protected override string GetDbProviderManifestToken(System.Data.Common.DbConnection connection) { throw null; }
        protected override System.Data.Spatial.DbSpatialDataReader GetDbSpatialDataReader(System.Data.Common.DbDataReader fromReader, string versionHint) { throw null; }
        protected override void SetDbParameterValue(System.Data.Common.DbParameter parameter, System.Data.Metadata.Edm.TypeUsage parameterType, object value) { }
    }
}
