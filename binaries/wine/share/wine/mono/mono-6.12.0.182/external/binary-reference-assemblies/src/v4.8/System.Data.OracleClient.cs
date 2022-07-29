// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

[assembly:System.Reflection.AssemblyVersionAttribute("4.0.0.0")]
[assembly:System.CLSCompliantAttribute(true)]
[assembly:System.Reflection.AssemblyCompanyAttribute("Mono development team")]
[assembly:System.Reflection.AssemblyCopyrightAttribute("(c) Various Mono authors")]
[assembly:System.Reflection.AssemblyDefaultAliasAttribute("System.Data.OracleClient.dll")]
[assembly:System.Reflection.AssemblyDescriptionAttribute("System.Data.OracleClient.dll")]
[assembly:System.Reflection.AssemblyFileVersionAttribute("4.8.3761.0")]
[assembly:System.Reflection.AssemblyInformationalVersionAttribute("4.8.3761.0")]
[assembly:System.Reflection.AssemblyProductAttribute("Mono Common Language Infrastructure")]
[assembly:System.Reflection.AssemblyTitleAttribute("System.Data.OracleClient.dll")]
[assembly:System.Resources.NeutralResourcesLanguageAttribute("en-US")]
[assembly:System.Resources.SatelliteContractVersionAttribute("4.0.0.0")]
[assembly:System.Runtime.CompilerServices.ReferenceAssemblyAttribute]
[assembly:System.Runtime.InteropServices.ComCompatibleVersionAttribute(1, 0, 3300, 0)]
[assembly:System.Runtime.InteropServices.ComVisibleAttribute(false)]
[assembly:System.Runtime.InteropServices.DefaultDllImportSearchPathsAttribute(System.Runtime.InteropServices.DllImportSearchPath.AssemblyDirectory | System.Runtime.InteropServices.DllImportSearchPath.System32)]
[assembly:System.Security.AllowPartiallyTrustedCallersAttribute]
[assembly:System.Security.SecurityRulesAttribute(System.Security.SecurityRuleSet.Level1, SkipVerificationInFullTrust=true)]
[assembly:System.Security.Permissions.SecurityPermissionAttribute(System.Security.Permissions.SecurityAction.RequestMinimum, SkipVerification=true)]
namespace System.Data.OracleClient
{
    public sealed partial class OracleBFile : System.IO.Stream, System.Data.SqlTypes.INullable, System.ICloneable, System.IDisposable
    {
        internal OracleBFile() { }
        public static readonly new System.Data.OracleClient.OracleBFile Null;
        public override bool CanRead { get { throw null; } }
        public override bool CanSeek { get { throw null; } }
        public override bool CanWrite { get { throw null; } }
        public System.Data.OracleClient.OracleConnection Connection { get { throw null; } }
        public string DirectoryName { get { throw null; } }
        public bool FileExists { get { throw null; } }
        public string FileName { get { throw null; } }
        public bool IsNull { get { throw null; } }
        public override long Length { get { throw null; } }
        public override long Position { get { throw null; } set { } }
        public object Value { get { throw null; } }
        public object Clone() { throw null; }
        public long CopyTo(System.Data.OracleClient.OracleLob destination) { throw null; }
        public long CopyTo(System.Data.OracleClient.OracleLob destination, long destinationOffset) { throw null; }
        public long CopyTo(long sourceOffset, System.Data.OracleClient.OracleLob destination, long destinationOffset, long amount) { throw null; }
        protected override void Dispose(bool disposing) { }
        public override void Flush() { }
        public override int Read(byte[] buffer, int offset, int count) { throw null; }
        public override long Seek(long offset, System.IO.SeekOrigin origin) { throw null; }
        public void SetFileName(string directory, string file) { }
        public override void SetLength(long value) { }
        public override void Write(byte[] buffer, int offset, int count) { }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public partial struct OracleBinary : System.Data.SqlTypes.INullable, System.IComparable
    {
        private object _dummy;
        public static readonly System.Data.OracleClient.OracleBinary Null;
        public OracleBinary(byte[] b) { throw null; }
        public bool IsNull { get { throw null; } }
        public byte this[int index] { get { throw null; } }
        public int Length { get { throw null; } }
        public byte[] Value { get { throw null; } }
        public int CompareTo(object obj) { throw null; }
        public static System.Data.OracleClient.OracleBinary Concat(System.Data.OracleClient.OracleBinary x, System.Data.OracleClient.OracleBinary y) { throw null; }
        public static System.Data.OracleClient.OracleBoolean Equals(System.Data.OracleClient.OracleBinary x, System.Data.OracleClient.OracleBinary y) { throw null; }
        public override bool Equals(object value) { throw null; }
        public override int GetHashCode() { throw null; }
        public static System.Data.OracleClient.OracleBoolean GreaterThan(System.Data.OracleClient.OracleBinary x, System.Data.OracleClient.OracleBinary y) { throw null; }
        public static System.Data.OracleClient.OracleBoolean GreaterThanOrEqual(System.Data.OracleClient.OracleBinary x, System.Data.OracleClient.OracleBinary y) { throw null; }
        public static System.Data.OracleClient.OracleBoolean LessThan(System.Data.OracleClient.OracleBinary x, System.Data.OracleClient.OracleBinary y) { throw null; }
        public static System.Data.OracleClient.OracleBoolean LessThanOrEqual(System.Data.OracleClient.OracleBinary x, System.Data.OracleClient.OracleBinary y) { throw null; }
        public static System.Data.OracleClient.OracleBoolean NotEquals(System.Data.OracleClient.OracleBinary x, System.Data.OracleClient.OracleBinary y) { throw null; }
        public static System.Data.OracleClient.OracleBinary operator +(System.Data.OracleClient.OracleBinary x, System.Data.OracleClient.OracleBinary y) { throw null; }
        public static System.Data.OracleClient.OracleBoolean operator ==(System.Data.OracleClient.OracleBinary x, System.Data.OracleClient.OracleBinary y) { throw null; }
        public static explicit operator byte[] (System.Data.OracleClient.OracleBinary x) { throw null; }
        public static System.Data.OracleClient.OracleBoolean operator >(System.Data.OracleClient.OracleBinary x, System.Data.OracleClient.OracleBinary y) { throw null; }
        public static System.Data.OracleClient.OracleBoolean operator >=(System.Data.OracleClient.OracleBinary x, System.Data.OracleClient.OracleBinary y) { throw null; }
        public static implicit operator System.Data.OracleClient.OracleBinary (byte[] b) { throw null; }
        public static System.Data.OracleClient.OracleBoolean operator !=(System.Data.OracleClient.OracleBinary x, System.Data.OracleClient.OracleBinary y) { throw null; }
        public static System.Data.OracleClient.OracleBoolean operator <(System.Data.OracleClient.OracleBinary x, System.Data.OracleClient.OracleBinary y) { throw null; }
        public static System.Data.OracleClient.OracleBoolean operator <=(System.Data.OracleClient.OracleBinary x, System.Data.OracleClient.OracleBinary y) { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public partial struct OracleBoolean : System.IComparable
    {
        private int _dummyPrimitive;
        public static readonly System.Data.OracleClient.OracleBoolean False;
        public static readonly System.Data.OracleClient.OracleBoolean Null;
        public static readonly System.Data.OracleClient.OracleBoolean One;
        public static readonly System.Data.OracleClient.OracleBoolean True;
        public static readonly System.Data.OracleClient.OracleBoolean Zero;
        public OracleBoolean(bool value) { throw null; }
        public OracleBoolean(int value) { throw null; }
        public bool IsFalse { get { throw null; } }
        public bool IsNull { get { throw null; } }
        public bool IsTrue { get { throw null; } }
        public bool Value { get { throw null; } }
        public static System.Data.OracleClient.OracleBoolean And(System.Data.OracleClient.OracleBoolean x, System.Data.OracleClient.OracleBoolean y) { throw null; }
        public int CompareTo(object obj) { throw null; }
        public static System.Data.OracleClient.OracleBoolean Equals(System.Data.OracleClient.OracleBoolean x, System.Data.OracleClient.OracleBoolean y) { throw null; }
        public override bool Equals(object value) { throw null; }
        public override int GetHashCode() { throw null; }
        public static System.Data.OracleClient.OracleBoolean NotEquals(System.Data.OracleClient.OracleBoolean x, System.Data.OracleClient.OracleBoolean y) { throw null; }
        public static System.Data.OracleClient.OracleBoolean OnesComplement(System.Data.OracleClient.OracleBoolean x) { throw null; }
        public static System.Data.OracleClient.OracleBoolean operator &(System.Data.OracleClient.OracleBoolean x, System.Data.OracleClient.OracleBoolean y) { throw null; }
        public static System.Data.OracleClient.OracleBoolean operator |(System.Data.OracleClient.OracleBoolean x, System.Data.OracleClient.OracleBoolean y) { throw null; }
        public static System.Data.OracleClient.OracleBoolean operator ==(System.Data.OracleClient.OracleBoolean x, System.Data.OracleClient.OracleBoolean y) { throw null; }
        public static System.Data.OracleClient.OracleBoolean operator ^(System.Data.OracleClient.OracleBoolean x, System.Data.OracleClient.OracleBoolean y) { throw null; }
        public static explicit operator bool (System.Data.OracleClient.OracleBoolean x) { throw null; }
        public static explicit operator System.Data.OracleClient.OracleBoolean (System.Data.OracleClient.OracleNumber x) { throw null; }
        public static explicit operator System.Data.OracleClient.OracleBoolean (string x) { throw null; }
        public static bool operator false(System.Data.OracleClient.OracleBoolean x) { throw null; }
        public static implicit operator System.Data.OracleClient.OracleBoolean (bool x) { throw null; }
        public static System.Data.OracleClient.OracleBoolean operator !=(System.Data.OracleClient.OracleBoolean x, System.Data.OracleClient.OracleBoolean y) { throw null; }
        public static System.Data.OracleClient.OracleBoolean operator !(System.Data.OracleClient.OracleBoolean x) { throw null; }
        public static System.Data.OracleClient.OracleBoolean operator ~(System.Data.OracleClient.OracleBoolean x) { throw null; }
        public static bool operator true(System.Data.OracleClient.OracleBoolean x) { throw null; }
        public static System.Data.OracleClient.OracleBoolean Or(System.Data.OracleClient.OracleBoolean x, System.Data.OracleClient.OracleBoolean y) { throw null; }
        public static System.Data.OracleClient.OracleBoolean Parse(string s) { throw null; }
        public override string ToString() { throw null; }
        public static System.Data.OracleClient.OracleBoolean Xor(System.Data.OracleClient.OracleBoolean x, System.Data.OracleClient.OracleBoolean y) { throw null; }
    }
    [System.ObsoleteAttribute("OracleClientFactory has been deprecated. http://go.microsoft.com/fwlink/?LinkID=144260", false)]
    public sealed partial class OracleClientFactory : System.Data.Common.DbProviderFactory
    {
        internal OracleClientFactory() { }
        public static readonly System.Data.OracleClient.OracleClientFactory Instance;
        public override System.Data.Common.DbCommand CreateCommand() { throw null; }
        public override System.Data.Common.DbCommandBuilder CreateCommandBuilder() { throw null; }
        public override System.Data.Common.DbConnection CreateConnection() { throw null; }
        public override System.Data.Common.DbConnectionStringBuilder CreateConnectionStringBuilder() { throw null; }
        public override System.Data.Common.DbDataAdapter CreateDataAdapter() { throw null; }
        public override System.Data.Common.DbParameter CreateParameter() { throw null; }
        public override System.Security.CodeAccessPermission CreatePermission(System.Security.Permissions.PermissionState state) { throw null; }
    }
    [System.ComponentModel.DefaultEventAttribute("RecordsAffected")]
    [System.ComponentModel.DesignerAttribute("Microsoft.VSDesigner.Data.VS.OracleCommandDesigner, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
    [System.ComponentModel.ToolboxItemAttribute(true)]
    [System.ObsoleteAttribute("OracleCommand has been deprecated. http://go.microsoft.com/fwlink/?LinkID=144260", false)]
    public sealed partial class OracleCommand : System.Data.Common.DbCommand, System.ICloneable
    {
        public OracleCommand() { }
        public OracleCommand(string commandText) { }
        public OracleCommand(string commandText, System.Data.OracleClient.OracleConnection connection) { }
        public OracleCommand(string commandText, System.Data.OracleClient.OracleConnection connection, System.Data.OracleClient.OracleTransaction tx) { }
        [System.ComponentModel.DefaultValueAttribute("")]
        [System.ComponentModel.EditorAttribute("Microsoft.VSDesigner.Data.Oracle.Design.OracleCommandTextEditor, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor, System.Drawing, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
        [System.ComponentModel.RefreshPropertiesAttribute(System.ComponentModel.RefreshProperties.All)]
        public override string CommandText { get { throw null; } set { } }
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.DesignerSerializationVisibilityAttribute(System.ComponentModel.DesignerSerializationVisibility.Hidden)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int CommandTimeout { get { throw null; } set { } }
        [System.ComponentModel.DefaultValueAttribute(System.Data.CommandType.Text)]
        [System.ComponentModel.RefreshPropertiesAttribute(System.ComponentModel.RefreshProperties.All)]
        public override System.Data.CommandType CommandType { get { throw null; } set { } }
        [System.ComponentModel.DefaultValueAttribute(null)]
        [System.ComponentModel.EditorAttribute("Microsoft.VSDesigner.Data.Design.DbConnectionEditor, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor, System.Drawing, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
        public new System.Data.OracleClient.OracleConnection Connection { get { throw null; } set { } }
        protected override System.Data.Common.DbConnection DbConnection { get { throw null; } set { } }
        protected override System.Data.Common.DbParameterCollection DbParameterCollection { get { throw null; } }
        protected override System.Data.Common.DbTransaction DbTransaction { get { throw null; } set { } }
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.DefaultValueAttribute(true)]
        [System.ComponentModel.DesignOnlyAttribute(true)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool DesignTimeVisible { get { throw null; } set { } }
        [System.ComponentModel.DesignerSerializationVisibilityAttribute(System.ComponentModel.DesignerSerializationVisibility.Content)]
        public new System.Data.OracleClient.OracleParameterCollection Parameters { get { throw null; } }
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.DesignerSerializationVisibilityAttribute(System.ComponentModel.DesignerSerializationVisibility.Hidden)]
        public new System.Data.OracleClient.OracleTransaction Transaction { get { throw null; } set { } }
        [System.ComponentModel.DefaultValueAttribute(System.Data.UpdateRowSource.Both)]
        public override System.Data.UpdateRowSource UpdatedRowSource { get { throw null; } set { } }
        public override void Cancel() { }
        public object Clone() { throw null; }
        protected override System.Data.Common.DbParameter CreateDbParameter() { throw null; }
        public new System.Data.OracleClient.OracleParameter CreateParameter() { throw null; }
        protected override System.Data.Common.DbDataReader ExecuteDbDataReader(System.Data.CommandBehavior behavior) { throw null; }
        public override int ExecuteNonQuery() { throw null; }
        public int ExecuteOracleNonQuery(out System.Data.OracleClient.OracleString rowid) { throw null; }
        public object ExecuteOracleScalar() { throw null; }
        public new System.Data.OracleClient.OracleDataReader ExecuteReader() { throw null; }
        public new System.Data.OracleClient.OracleDataReader ExecuteReader(System.Data.CommandBehavior behavior) { throw null; }
        public override object ExecuteScalar() { throw null; }
        public override void Prepare() { }
        public void ResetCommandTimeout() { }
    }
    [System.ObsoleteAttribute("OracleCommandBuilder has been deprecated. http://go.microsoft.com/fwlink/?LinkID=144260", false)]
    public sealed partial class OracleCommandBuilder : System.Data.Common.DbCommandBuilder
    {
        public OracleCommandBuilder() { }
        public OracleCommandBuilder(System.Data.OracleClient.OracleDataAdapter adapter) { }
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.DesignerSerializationVisibilityAttribute(System.ComponentModel.DesignerSerializationVisibility.Hidden)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override System.Data.Common.CatalogLocation CatalogLocation { get { throw null; } set { } }
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.DesignerSerializationVisibilityAttribute(System.ComponentModel.DesignerSerializationVisibility.Hidden)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override string CatalogSeparator { get { throw null; } set { } }
        [System.ComponentModel.DefaultValueAttribute(null)]
        public new System.Data.OracleClient.OracleDataAdapter DataAdapter { get { throw null; } set { } }
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.DesignerSerializationVisibilityAttribute(System.ComponentModel.DesignerSerializationVisibility.Hidden)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override string SchemaSeparator { get { throw null; } set { } }
        protected override void ApplyParameterInfo(System.Data.Common.DbParameter parameter, System.Data.DataRow datarow, System.Data.StatementType statementType, bool whereClause) { }
        public static void DeriveParameters(System.Data.OracleClient.OracleCommand command) { }
        public new System.Data.OracleClient.OracleCommand GetDeleteCommand() { throw null; }
        public new System.Data.OracleClient.OracleCommand GetDeleteCommand(bool useColumnsForParameterNames) { throw null; }
        public new System.Data.OracleClient.OracleCommand GetInsertCommand() { throw null; }
        public new System.Data.OracleClient.OracleCommand GetInsertCommand(bool useColumnsForParameterNames) { throw null; }
        protected override string GetParameterName(int parameterOrdinal) { throw null; }
        protected override string GetParameterName(string parameterName) { throw null; }
        protected override string GetParameterPlaceholder(int parameterOrdinal) { throw null; }
        public new System.Data.OracleClient.OracleCommand GetUpdateCommand() { throw null; }
        public new System.Data.OracleClient.OracleCommand GetUpdateCommand(bool useColumnsForParameterNames) { throw null; }
        public override string QuoteIdentifier(string unquotedIdentifier) { throw null; }
        protected override void SetRowUpdatingHandler(System.Data.Common.DbDataAdapter adapter) { }
        public override string UnquoteIdentifier(string quotedIdentifier) { throw null; }
    }
    [System.ComponentModel.DefaultEventAttribute("InfoMessage")]
    [System.ObsoleteAttribute("OracleConnection has been deprecated. http://go.microsoft.com/fwlink/?LinkID=144260", false)]
    public sealed partial class OracleConnection : System.Data.Common.DbConnection, System.ICloneable
    {
        public OracleConnection() { }
        public OracleConnection(string connectionString) { }
        [System.ComponentModel.DefaultValueAttribute("")]
        [System.ComponentModel.EditorAttribute("Microsoft.VSDesigner.Data.Oracle.Design.OracleConnectionStringEditor, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor, System.Drawing, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
        [System.ComponentModel.RecommendedAsConfigurableAttribute(true)]
        [System.ComponentModel.RefreshPropertiesAttribute(System.ComponentModel.RefreshProperties.All)]
        [System.ComponentModel.SettingsBindableAttribute(true)]
        public override string ConnectionString { get { throw null; } set { } }
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int ConnectionTimeout { get { throw null; } }
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override string Database { get { throw null; } }
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.DesignerSerializationVisibilityAttribute(System.ComponentModel.DesignerSerializationVisibility.Hidden)]
        public override string DataSource { get { throw null; } }
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.DesignerSerializationVisibilityAttribute(System.ComponentModel.DesignerSerializationVisibility.Hidden)]
        public override string ServerVersion { get { throw null; } }
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.DesignerSerializationVisibilityAttribute(System.ComponentModel.DesignerSerializationVisibility.Hidden)]
        public override System.Data.ConnectionState State { get { throw null; } }
        public event System.Data.OracleClient.OracleInfoMessageEventHandler InfoMessage { add { } remove { } }
        protected override System.Data.Common.DbTransaction BeginDbTransaction(System.Data.IsolationLevel isolationLevel) { throw null; }
        public new System.Data.OracleClient.OracleTransaction BeginTransaction() { throw null; }
        public new System.Data.OracleClient.OracleTransaction BeginTransaction(System.Data.IsolationLevel il) { throw null; }
        public override void ChangeDatabase(string value) { }
        public static void ClearAllPools() { }
        public static void ClearPool(System.Data.OracleClient.OracleConnection connection) { }
        public override void Close() { }
        public new System.Data.OracleClient.OracleCommand CreateCommand() { throw null; }
        protected override System.Data.Common.DbCommand CreateDbCommand() { throw null; }
        protected override void Dispose(bool disposing) { }
        public void EnlistDistributedTransaction(System.EnterpriseServices.ITransaction distributedTransaction) { }
        public override void EnlistTransaction(System.Transactions.Transaction transaction) { }
        public override System.Data.DataTable GetSchema() { throw null; }
        public override System.Data.DataTable GetSchema(string collectionName) { throw null; }
        public override System.Data.DataTable GetSchema(string collectionName, string[] restrictionValues) { throw null; }
        public override void Open() { }
        object System.ICloneable.Clone() { throw null; }
    }
    [System.ComponentModel.DefaultPropertyAttribute("DataSource")]
    [System.ComponentModel.TypeConverterAttribute("System.Data.OracleClient.OracleConnectionStringBuilder.OracleConnectionStringBuilderConverter")]
    [System.ObsoleteAttribute("OracleConnectionStringBuilder has been deprecated. http://go.microsoft.com/fwlink/?LinkID=144260", false)]
    public sealed partial class OracleConnectionStringBuilder : System.Data.Common.DbConnectionStringBuilder
    {
        public OracleConnectionStringBuilder() { }
        public OracleConnectionStringBuilder(string connectionString) { }
        [System.ComponentModel.DisplayNameAttribute("Data Source")]
        [System.ComponentModel.RefreshPropertiesAttribute(System.ComponentModel.RefreshProperties.All)]
        public string DataSource { get { throw null; } set { } }
        [System.ComponentModel.DisplayNameAttribute("Enlist")]
        [System.ComponentModel.RefreshPropertiesAttribute(System.ComponentModel.RefreshProperties.All)]
        public bool Enlist { get { throw null; } set { } }
        [System.ComponentModel.DisplayNameAttribute("Integrated Security")]
        [System.ComponentModel.RefreshPropertiesAttribute(System.ComponentModel.RefreshProperties.All)]
        public bool IntegratedSecurity { get { throw null; } set { } }
        public override bool IsFixedSize { get { throw null; } }
        public override object this[string keyword] { get { throw null; } set { } }
        public override System.Collections.ICollection Keys { get { throw null; } }
        [System.ComponentModel.DisplayNameAttribute("Load Balance Timeout")]
        [System.ComponentModel.RefreshPropertiesAttribute(System.ComponentModel.RefreshProperties.All)]
        public int LoadBalanceTimeout { get { throw null; } set { } }
        [System.ComponentModel.DisplayNameAttribute("Max Pool Size")]
        [System.ComponentModel.RefreshPropertiesAttribute(System.ComponentModel.RefreshProperties.All)]
        public int MaxPoolSize { get { throw null; } set { } }
        [System.ComponentModel.DisplayNameAttribute("Min Pool Size")]
        [System.ComponentModel.RefreshPropertiesAttribute(System.ComponentModel.RefreshProperties.All)]
        public int MinPoolSize { get { throw null; } set { } }
        [System.ComponentModel.DisplayNameAttribute("Omit Oracle Connection Name")]
        [System.ComponentModel.RefreshPropertiesAttribute(System.ComponentModel.RefreshProperties.All)]
        public bool OmitOracleConnectionName { get { throw null; } set { } }
        [System.ComponentModel.DisplayNameAttribute("Password")]
        [System.ComponentModel.PasswordPropertyTextAttribute(true)]
        [System.ComponentModel.RefreshPropertiesAttribute(System.ComponentModel.RefreshProperties.All)]
        public string Password { get { throw null; } set { } }
        [System.ComponentModel.DisplayNameAttribute("Persist Security Info")]
        [System.ComponentModel.RefreshPropertiesAttribute(System.ComponentModel.RefreshProperties.All)]
        public bool PersistSecurityInfo { get { throw null; } set { } }
        [System.ComponentModel.DisplayNameAttribute("Pooling")]
        [System.ComponentModel.RefreshPropertiesAttribute(System.ComponentModel.RefreshProperties.All)]
        public bool Pooling { get { throw null; } set { } }
        [System.ComponentModel.DisplayNameAttribute("Unicode")]
        [System.ComponentModel.RefreshPropertiesAttribute(System.ComponentModel.RefreshProperties.All)]
        public bool Unicode { get { throw null; } set { } }
        [System.ComponentModel.DisplayNameAttribute("User ID")]
        [System.ComponentModel.RefreshPropertiesAttribute(System.ComponentModel.RefreshProperties.All)]
        public string UserID { get { throw null; } set { } }
        public override System.Collections.ICollection Values { get { throw null; } }
        public override void Clear() { }
        public override bool ContainsKey(string keyword) { throw null; }
        protected override void GetProperties(System.Collections.Hashtable propertyDescriptors) { }
        public override bool Remove(string keyword) { throw null; }
        public override bool ShouldSerialize(string keyword) { throw null; }
        public override bool TryGetValue(string keyword, out object value) { throw null; }
    }
    [System.ComponentModel.DefaultEventAttribute("RowUpdated")]
    [System.ComponentModel.DesignerAttribute("Microsoft.VSDesigner.Data.VS.OracleDataAdapterDesigner, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
    [System.ComponentModel.ToolboxItemAttribute("Microsoft.VSDesigner.Data.VS.OracleDataAdapterToolboxItem, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
    [System.ObsoleteAttribute("OracleDataAdapter has been deprecated. http://go.microsoft.com/fwlink/?LinkID=144260", false)]
    public sealed partial class OracleDataAdapter : System.Data.Common.DbDataAdapter, System.Data.IDataAdapter, System.Data.IDbDataAdapter, System.ICloneable
    {
        public OracleDataAdapter() { }
        public OracleDataAdapter(System.Data.OracleClient.OracleCommand selectCommand) { }
        public OracleDataAdapter(string selectCommandText, System.Data.OracleClient.OracleConnection selectConnection) { }
        public OracleDataAdapter(string selectCommandText, string selectConnectionString) { }
        [System.ComponentModel.DefaultValueAttribute(null)]
        [System.ComponentModel.EditorAttribute("Microsoft.VSDesigner.Data.Design.DBCommandEditor, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor, System.Drawing, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
        public new System.Data.OracleClient.OracleCommand DeleteCommand { get { throw null; } set { } }
        [System.ComponentModel.DefaultValueAttribute(null)]
        [System.ComponentModel.EditorAttribute("Microsoft.VSDesigner.Data.Design.DBCommandEditor, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor, System.Drawing, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
        public new System.Data.OracleClient.OracleCommand InsertCommand { get { throw null; } set { } }
        [System.ComponentModel.DefaultValueAttribute(null)]
        [System.ComponentModel.EditorAttribute("Microsoft.VSDesigner.Data.Design.DBCommandEditor, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor, System.Drawing, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
        public new System.Data.OracleClient.OracleCommand SelectCommand { get { throw null; } set { } }
        System.Data.IDbCommand System.Data.IDbDataAdapter.DeleteCommand { get { throw null; } set { } }
        System.Data.IDbCommand System.Data.IDbDataAdapter.InsertCommand { get { throw null; } set { } }
        System.Data.IDbCommand System.Data.IDbDataAdapter.SelectCommand { get { throw null; } set { } }
        System.Data.IDbCommand System.Data.IDbDataAdapter.UpdateCommand { get { throw null; } set { } }
        public override int UpdateBatchSize { get { throw null; } set { } }
        [System.ComponentModel.DefaultValueAttribute(null)]
        [System.ComponentModel.EditorAttribute("Microsoft.VSDesigner.Data.Design.DBCommandEditor, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor, System.Drawing, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
        public new System.Data.OracleClient.OracleCommand UpdateCommand { get { throw null; } set { } }
        public event System.Data.OracleClient.OracleRowUpdatedEventHandler RowUpdated { add { } remove { } }
        public event System.Data.OracleClient.OracleRowUpdatingEventHandler RowUpdating { add { } remove { } }
        protected override int AddToBatch(System.Data.IDbCommand command) { throw null; }
        protected override void ClearBatch() { }
        protected override System.Data.Common.RowUpdatedEventArgs CreateRowUpdatedEvent(System.Data.DataRow dataRow, System.Data.IDbCommand command, System.Data.StatementType statementType, System.Data.Common.DataTableMapping tableMapping) { throw null; }
        protected override System.Data.Common.RowUpdatingEventArgs CreateRowUpdatingEvent(System.Data.DataRow dataRow, System.Data.IDbCommand command, System.Data.StatementType statementType, System.Data.Common.DataTableMapping tableMapping) { throw null; }
        protected override int ExecuteBatch() { throw null; }
        protected override System.Data.IDataParameter GetBatchedParameter(int commandIdentifier, int parameterIndex) { throw null; }
        protected override bool GetBatchedRecordsAffected(int commandIdentifier, out int recordsAffected, out System.Exception error) { throw null; }
        protected override void InitializeBatching() { }
        protected override void OnRowUpdated(System.Data.Common.RowUpdatedEventArgs value) { }
        protected override void OnRowUpdating(System.Data.Common.RowUpdatingEventArgs value) { }
        object System.ICloneable.Clone() { throw null; }
        protected override void TerminateBatching() { }
    }
    public sealed partial class OracleDataReader : System.Data.Common.DbDataReader
    {
        internal OracleDataReader() { }
        public override int Depth { get { throw null; } }
        public override int FieldCount { get { throw null; } }
        public override bool HasRows { get { throw null; } }
        public override bool IsClosed { get { throw null; } }
        public override object this[int i] { get { throw null; } }
        public override object this[string name] { get { throw null; } }
        public override int RecordsAffected { get { throw null; } }
        public override void Close() { }
        public override bool GetBoolean(int i) { throw null; }
        public override byte GetByte(int i) { throw null; }
        public override long GetBytes(int i, long fieldOffset, byte[] buffer2, int bufferoffset, int length) { throw null; }
        public override char GetChar(int i) { throw null; }
        public override long GetChars(int i, long fieldOffset, char[] buffer2, int bufferoffset, int length) { throw null; }
        public override string GetDataTypeName(int i) { throw null; }
        public override System.DateTime GetDateTime(int i) { throw null; }
        public override decimal GetDecimal(int i) { throw null; }
        public override double GetDouble(int i) { throw null; }
        public override System.Collections.IEnumerator GetEnumerator() { throw null; }
        public override System.Type GetFieldType(int i) { throw null; }
        public override float GetFloat(int i) { throw null; }
        public override System.Guid GetGuid(int i) { throw null; }
        public override short GetInt16(int i) { throw null; }
        public override int GetInt32(int i) { throw null; }
        public override long GetInt64(int i) { throw null; }
        public override string GetName(int i) { throw null; }
        public System.Data.OracleClient.OracleBFile GetOracleBFile(int i) { throw null; }
        public System.Data.OracleClient.OracleBinary GetOracleBinary(int i) { throw null; }
        public System.Data.OracleClient.OracleDateTime GetOracleDateTime(int i) { throw null; }
        public System.Data.OracleClient.OracleLob GetOracleLob(int i) { throw null; }
        public System.Data.OracleClient.OracleMonthSpan GetOracleMonthSpan(int i) { throw null; }
        public System.Data.OracleClient.OracleNumber GetOracleNumber(int i) { throw null; }
        public System.Data.OracleClient.OracleString GetOracleString(int i) { throw null; }
        public System.Data.OracleClient.OracleTimeSpan GetOracleTimeSpan(int i) { throw null; }
        public object GetOracleValue(int i) { throw null; }
        public int GetOracleValues(object[] values) { throw null; }
        public override int GetOrdinal(string name) { throw null; }
        public override System.Type GetProviderSpecificFieldType(int i) { throw null; }
        public override object GetProviderSpecificValue(int i) { throw null; }
        public override int GetProviderSpecificValues(object[] values) { throw null; }
        public override System.Data.DataTable GetSchemaTable() { throw null; }
        public override string GetString(int i) { throw null; }
        public System.TimeSpan GetTimeSpan(int i) { throw null; }
        public override object GetValue(int i) { throw null; }
        public override int GetValues(object[] values) { throw null; }
        public override bool IsDBNull(int i) { throw null; }
        public override bool NextResult() { throw null; }
        public override bool Read() { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential, Pack=1)]
    public partial struct OracleDateTime : System.Data.SqlTypes.INullable, System.IComparable
    {
        private object _dummy;
        public static readonly System.Data.OracleClient.OracleDateTime MaxValue;
        public static readonly System.Data.OracleClient.OracleDateTime MinValue;
        public static readonly System.Data.OracleClient.OracleDateTime Null;
        public OracleDateTime(System.Data.OracleClient.OracleDateTime from) { throw null; }
        public OracleDateTime(System.DateTime dt) { throw null; }
        public OracleDateTime(int year, int month, int day) { throw null; }
        public OracleDateTime(int year, int month, int day, System.Globalization.Calendar calendar) { throw null; }
        public OracleDateTime(int year, int month, int day, int hour, int minute, int second) { throw null; }
        public OracleDateTime(int year, int month, int day, int hour, int minute, int second, System.Globalization.Calendar calendar) { throw null; }
        public OracleDateTime(int year, int month, int day, int hour, int minute, int second, int millisecond) { throw null; }
        public OracleDateTime(int year, int month, int day, int hour, int minute, int second, int millisecond, System.Globalization.Calendar calendar) { throw null; }
        public OracleDateTime(long ticks) { throw null; }
        public int Day { get { throw null; } }
        public int Hour { get { throw null; } }
        public bool IsNull { get { throw null; } }
        public int Millisecond { get { throw null; } }
        public int Minute { get { throw null; } }
        public int Month { get { throw null; } }
        public int Second { get { throw null; } }
        public System.DateTime Value { get { throw null; } }
        public int Year { get { throw null; } }
        public int CompareTo(object obj) { throw null; }
        public static System.Data.OracleClient.OracleBoolean Equals(System.Data.OracleClient.OracleDateTime x, System.Data.OracleClient.OracleDateTime y) { throw null; }
        public override bool Equals(object value) { throw null; }
        public override int GetHashCode() { throw null; }
        public static System.Data.OracleClient.OracleBoolean GreaterThan(System.Data.OracleClient.OracleDateTime x, System.Data.OracleClient.OracleDateTime y) { throw null; }
        public static System.Data.OracleClient.OracleBoolean GreaterThanOrEqual(System.Data.OracleClient.OracleDateTime x, System.Data.OracleClient.OracleDateTime y) { throw null; }
        public static System.Data.OracleClient.OracleBoolean LessThan(System.Data.OracleClient.OracleDateTime x, System.Data.OracleClient.OracleDateTime y) { throw null; }
        public static System.Data.OracleClient.OracleBoolean LessThanOrEqual(System.Data.OracleClient.OracleDateTime x, System.Data.OracleClient.OracleDateTime y) { throw null; }
        public static System.Data.OracleClient.OracleBoolean NotEquals(System.Data.OracleClient.OracleDateTime x, System.Data.OracleClient.OracleDateTime y) { throw null; }
        public static System.Data.OracleClient.OracleBoolean operator ==(System.Data.OracleClient.OracleDateTime x, System.Data.OracleClient.OracleDateTime y) { throw null; }
        public static explicit operator System.DateTime (System.Data.OracleClient.OracleDateTime x) { throw null; }
        public static explicit operator System.Data.OracleClient.OracleDateTime (string x) { throw null; }
        public static System.Data.OracleClient.OracleBoolean operator >(System.Data.OracleClient.OracleDateTime x, System.Data.OracleClient.OracleDateTime y) { throw null; }
        public static System.Data.OracleClient.OracleBoolean operator >=(System.Data.OracleClient.OracleDateTime x, System.Data.OracleClient.OracleDateTime y) { throw null; }
        public static System.Data.OracleClient.OracleBoolean operator !=(System.Data.OracleClient.OracleDateTime x, System.Data.OracleClient.OracleDateTime y) { throw null; }
        public static System.Data.OracleClient.OracleBoolean operator <(System.Data.OracleClient.OracleDateTime x, System.Data.OracleClient.OracleDateTime y) { throw null; }
        public static System.Data.OracleClient.OracleBoolean operator <=(System.Data.OracleClient.OracleDateTime x, System.Data.OracleClient.OracleDateTime y) { throw null; }
        public static System.Data.OracleClient.OracleDateTime Parse(string s) { throw null; }
        public override string ToString() { throw null; }
    }
    [System.SerializableAttribute]
    public sealed partial class OracleException : System.Data.Common.DbException
    {
        internal OracleException() { }
        public int Code { get { throw null; } }
        [System.Security.Permissions.SecurityPermissionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Flags=System.Security.Permissions.SecurityPermissionFlag.SerializationFormatter)]
        public override void GetObjectData(System.Runtime.Serialization.SerializationInfo si, System.Runtime.Serialization.StreamingContext context) { }
    }
    public sealed partial class OracleInfoMessageEventArgs : System.EventArgs
    {
        internal OracleInfoMessageEventArgs() { }
        public int Code { get { throw null; } }
        public string Message { get { throw null; } }
        public string Source { get { throw null; } }
        public override string ToString() { throw null; }
    }
    public delegate void OracleInfoMessageEventHandler(object sender, System.Data.OracleClient.OracleInfoMessageEventArgs e);
    public sealed partial class OracleLob : System.IO.Stream, System.Data.SqlTypes.INullable, System.ICloneable, System.IDisposable
    {
        internal OracleLob() { }
        public static readonly new System.Data.OracleClient.OracleLob Null;
        public override bool CanRead { get { throw null; } }
        public override bool CanSeek { get { throw null; } }
        public override bool CanWrite { get { throw null; } }
        public int ChunkSize { get { throw null; } }
        public System.Data.OracleClient.OracleConnection Connection { get { throw null; } }
        public bool IsBatched { get { throw null; } }
        public bool IsNull { get { throw null; } }
        public bool IsTemporary { get { throw null; } }
        public override long Length { get { throw null; } }
        public System.Data.OracleClient.OracleType LobType { get { throw null; } }
        public override long Position { get { throw null; } set { } }
        public object Value { get { throw null; } }
        public void Append(System.Data.OracleClient.OracleLob source) { }
        public void BeginBatch() { }
        public void BeginBatch(System.Data.OracleClient.OracleLobOpenMode mode) { }
        public object Clone() { throw null; }
        public long CopyTo(System.Data.OracleClient.OracleLob destination) { throw null; }
        public long CopyTo(System.Data.OracleClient.OracleLob destination, long destinationOffset) { throw null; }
        public long CopyTo(long sourceOffset, System.Data.OracleClient.OracleLob destination, long destinationOffset, long amount) { throw null; }
        protected override void Dispose(bool disposing) { }
        public void EndBatch() { }
        public long Erase() { throw null; }
        public long Erase(long offset, long amount) { throw null; }
        public override void Flush() { }
        public override int Read(byte[] buffer, int offset, int count) { throw null; }
        public override long Seek(long offset, System.IO.SeekOrigin origin) { throw null; }
        public override void SetLength(long value) { }
        public override void Write(byte[] buffer, int offset, int count) { }
        public override void WriteByte(byte value) { }
    }
    public enum OracleLobOpenMode
    {
        ReadOnly = 1,
        ReadWrite = 2,
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential, Pack=1)]
    public partial struct OracleMonthSpan : System.Data.SqlTypes.INullable, System.IComparable
    {
        private int _dummyPrimitive;
        public static readonly System.Data.OracleClient.OracleMonthSpan MaxValue;
        public static readonly System.Data.OracleClient.OracleMonthSpan MinValue;
        public static readonly System.Data.OracleClient.OracleMonthSpan Null;
        public OracleMonthSpan(System.Data.OracleClient.OracleMonthSpan from) { throw null; }
        public OracleMonthSpan(int months) { throw null; }
        public OracleMonthSpan(int years, int months) { throw null; }
        public bool IsNull { get { throw null; } }
        public int Value { get { throw null; } }
        public int CompareTo(object obj) { throw null; }
        public static System.Data.OracleClient.OracleBoolean Equals(System.Data.OracleClient.OracleMonthSpan x, System.Data.OracleClient.OracleMonthSpan y) { throw null; }
        public override bool Equals(object value) { throw null; }
        public override int GetHashCode() { throw null; }
        public static System.Data.OracleClient.OracleBoolean GreaterThan(System.Data.OracleClient.OracleMonthSpan x, System.Data.OracleClient.OracleMonthSpan y) { throw null; }
        public static System.Data.OracleClient.OracleBoolean GreaterThanOrEqual(System.Data.OracleClient.OracleMonthSpan x, System.Data.OracleClient.OracleMonthSpan y) { throw null; }
        public static System.Data.OracleClient.OracleBoolean LessThan(System.Data.OracleClient.OracleMonthSpan x, System.Data.OracleClient.OracleMonthSpan y) { throw null; }
        public static System.Data.OracleClient.OracleBoolean LessThanOrEqual(System.Data.OracleClient.OracleMonthSpan x, System.Data.OracleClient.OracleMonthSpan y) { throw null; }
        public static System.Data.OracleClient.OracleBoolean NotEquals(System.Data.OracleClient.OracleMonthSpan x, System.Data.OracleClient.OracleMonthSpan y) { throw null; }
        public static System.Data.OracleClient.OracleBoolean operator ==(System.Data.OracleClient.OracleMonthSpan x, System.Data.OracleClient.OracleMonthSpan y) { throw null; }
        public static explicit operator int (System.Data.OracleClient.OracleMonthSpan x) { throw null; }
        public static explicit operator System.Data.OracleClient.OracleMonthSpan (string x) { throw null; }
        public static System.Data.OracleClient.OracleBoolean operator >(System.Data.OracleClient.OracleMonthSpan x, System.Data.OracleClient.OracleMonthSpan y) { throw null; }
        public static System.Data.OracleClient.OracleBoolean operator >=(System.Data.OracleClient.OracleMonthSpan x, System.Data.OracleClient.OracleMonthSpan y) { throw null; }
        public static System.Data.OracleClient.OracleBoolean operator !=(System.Data.OracleClient.OracleMonthSpan x, System.Data.OracleClient.OracleMonthSpan y) { throw null; }
        public static System.Data.OracleClient.OracleBoolean operator <(System.Data.OracleClient.OracleMonthSpan x, System.Data.OracleClient.OracleMonthSpan y) { throw null; }
        public static System.Data.OracleClient.OracleBoolean operator <=(System.Data.OracleClient.OracleMonthSpan x, System.Data.OracleClient.OracleMonthSpan y) { throw null; }
        public static System.Data.OracleClient.OracleMonthSpan Parse(string s) { throw null; }
        public override string ToString() { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential, Pack=1)]
    public partial struct OracleNumber : System.Data.SqlTypes.INullable, System.IComparable
    {
        private object _dummy;
        public static readonly System.Data.OracleClient.OracleNumber E;
        public static readonly int MaxPrecision;
        public static readonly int MaxScale;
        public static readonly System.Data.OracleClient.OracleNumber MaxValue;
        public static readonly int MinScale;
        public static readonly System.Data.OracleClient.OracleNumber MinusOne;
        public static readonly System.Data.OracleClient.OracleNumber MinValue;
        public static readonly System.Data.OracleClient.OracleNumber Null;
        public static readonly System.Data.OracleClient.OracleNumber One;
        public static readonly System.Data.OracleClient.OracleNumber PI;
        public static readonly System.Data.OracleClient.OracleNumber Zero;
        public OracleNumber(System.Data.OracleClient.OracleNumber from) { throw null; }
        public OracleNumber(decimal decValue) { throw null; }
        public OracleNumber(double dblValue) { throw null; }
        public OracleNumber(int intValue) { throw null; }
        public OracleNumber(long longValue) { throw null; }
        public bool IsNull { get { throw null; } }
        public decimal Value { get { throw null; } }
        public static System.Data.OracleClient.OracleNumber Abs(System.Data.OracleClient.OracleNumber n) { throw null; }
        public static System.Data.OracleClient.OracleNumber Acos(System.Data.OracleClient.OracleNumber n) { throw null; }
        public static System.Data.OracleClient.OracleNumber Add(System.Data.OracleClient.OracleNumber x, System.Data.OracleClient.OracleNumber y) { throw null; }
        public static System.Data.OracleClient.OracleNumber Asin(System.Data.OracleClient.OracleNumber n) { throw null; }
        public static System.Data.OracleClient.OracleNumber Atan(System.Data.OracleClient.OracleNumber n) { throw null; }
        public static System.Data.OracleClient.OracleNumber Atan2(System.Data.OracleClient.OracleNumber y, System.Data.OracleClient.OracleNumber x) { throw null; }
        public static System.Data.OracleClient.OracleNumber Ceiling(System.Data.OracleClient.OracleNumber n) { throw null; }
        public int CompareTo(object obj) { throw null; }
        public static System.Data.OracleClient.OracleNumber Cos(System.Data.OracleClient.OracleNumber n) { throw null; }
        public static System.Data.OracleClient.OracleNumber Cosh(System.Data.OracleClient.OracleNumber n) { throw null; }
        public static System.Data.OracleClient.OracleNumber Divide(System.Data.OracleClient.OracleNumber x, System.Data.OracleClient.OracleNumber y) { throw null; }
        public static System.Data.OracleClient.OracleBoolean Equals(System.Data.OracleClient.OracleNumber x, System.Data.OracleClient.OracleNumber y) { throw null; }
        public override bool Equals(object value) { throw null; }
        public static System.Data.OracleClient.OracleNumber Exp(System.Data.OracleClient.OracleNumber p) { throw null; }
        public static System.Data.OracleClient.OracleNumber Floor(System.Data.OracleClient.OracleNumber n) { throw null; }
        public override int GetHashCode() { throw null; }
        public static System.Data.OracleClient.OracleBoolean GreaterThan(System.Data.OracleClient.OracleNumber x, System.Data.OracleClient.OracleNumber y) { throw null; }
        public static System.Data.OracleClient.OracleBoolean GreaterThanOrEqual(System.Data.OracleClient.OracleNumber x, System.Data.OracleClient.OracleNumber y) { throw null; }
        public static System.Data.OracleClient.OracleBoolean LessThan(System.Data.OracleClient.OracleNumber x, System.Data.OracleClient.OracleNumber y) { throw null; }
        public static System.Data.OracleClient.OracleBoolean LessThanOrEqual(System.Data.OracleClient.OracleNumber x, System.Data.OracleClient.OracleNumber y) { throw null; }
        public static System.Data.OracleClient.OracleNumber Log(System.Data.OracleClient.OracleNumber n) { throw null; }
        public static System.Data.OracleClient.OracleNumber Log(System.Data.OracleClient.OracleNumber n, System.Data.OracleClient.OracleNumber newBase) { throw null; }
        public static System.Data.OracleClient.OracleNumber Log(System.Data.OracleClient.OracleNumber n, int newBase) { throw null; }
        public static System.Data.OracleClient.OracleNumber Log10(System.Data.OracleClient.OracleNumber n) { throw null; }
        public static System.Data.OracleClient.OracleNumber Max(System.Data.OracleClient.OracleNumber x, System.Data.OracleClient.OracleNumber y) { throw null; }
        public static System.Data.OracleClient.OracleNumber Min(System.Data.OracleClient.OracleNumber x, System.Data.OracleClient.OracleNumber y) { throw null; }
        public static System.Data.OracleClient.OracleNumber Modulo(System.Data.OracleClient.OracleNumber x, System.Data.OracleClient.OracleNumber y) { throw null; }
        public static System.Data.OracleClient.OracleNumber Multiply(System.Data.OracleClient.OracleNumber x, System.Data.OracleClient.OracleNumber y) { throw null; }
        public static System.Data.OracleClient.OracleNumber Negate(System.Data.OracleClient.OracleNumber x) { throw null; }
        public static System.Data.OracleClient.OracleBoolean NotEquals(System.Data.OracleClient.OracleNumber x, System.Data.OracleClient.OracleNumber y) { throw null; }
        public static System.Data.OracleClient.OracleNumber operator +(System.Data.OracleClient.OracleNumber x, System.Data.OracleClient.OracleNumber y) { throw null; }
        public static System.Data.OracleClient.OracleNumber operator /(System.Data.OracleClient.OracleNumber x, System.Data.OracleClient.OracleNumber y) { throw null; }
        public static System.Data.OracleClient.OracleBoolean operator ==(System.Data.OracleClient.OracleNumber x, System.Data.OracleClient.OracleNumber y) { throw null; }
        public static explicit operator decimal (System.Data.OracleClient.OracleNumber x) { throw null; }
        public static explicit operator double (System.Data.OracleClient.OracleNumber x) { throw null; }
        public static explicit operator int (System.Data.OracleClient.OracleNumber x) { throw null; }
        public static explicit operator long (System.Data.OracleClient.OracleNumber x) { throw null; }
        public static explicit operator System.Data.OracleClient.OracleNumber (decimal x) { throw null; }
        public static explicit operator System.Data.OracleClient.OracleNumber (double x) { throw null; }
        public static explicit operator System.Data.OracleClient.OracleNumber (int x) { throw null; }
        public static explicit operator System.Data.OracleClient.OracleNumber (long x) { throw null; }
        public static explicit operator System.Data.OracleClient.OracleNumber (string x) { throw null; }
        public static System.Data.OracleClient.OracleBoolean operator >(System.Data.OracleClient.OracleNumber x, System.Data.OracleClient.OracleNumber y) { throw null; }
        public static System.Data.OracleClient.OracleBoolean operator >=(System.Data.OracleClient.OracleNumber x, System.Data.OracleClient.OracleNumber y) { throw null; }
        public static System.Data.OracleClient.OracleBoolean operator !=(System.Data.OracleClient.OracleNumber x, System.Data.OracleClient.OracleNumber y) { throw null; }
        public static System.Data.OracleClient.OracleBoolean operator <(System.Data.OracleClient.OracleNumber x, System.Data.OracleClient.OracleNumber y) { throw null; }
        public static System.Data.OracleClient.OracleBoolean operator <=(System.Data.OracleClient.OracleNumber x, System.Data.OracleClient.OracleNumber y) { throw null; }
        public static System.Data.OracleClient.OracleNumber operator %(System.Data.OracleClient.OracleNumber x, System.Data.OracleClient.OracleNumber y) { throw null; }
        public static System.Data.OracleClient.OracleNumber operator *(System.Data.OracleClient.OracleNumber x, System.Data.OracleClient.OracleNumber y) { throw null; }
        public static System.Data.OracleClient.OracleNumber operator -(System.Data.OracleClient.OracleNumber x, System.Data.OracleClient.OracleNumber y) { throw null; }
        public static System.Data.OracleClient.OracleNumber operator -(System.Data.OracleClient.OracleNumber x) { throw null; }
        public static System.Data.OracleClient.OracleNumber Parse(string s) { throw null; }
        public static System.Data.OracleClient.OracleNumber Pow(System.Data.OracleClient.OracleNumber x, System.Data.OracleClient.OracleNumber y) { throw null; }
        public static System.Data.OracleClient.OracleNumber Pow(System.Data.OracleClient.OracleNumber x, int y) { throw null; }
        public static System.Data.OracleClient.OracleNumber Round(System.Data.OracleClient.OracleNumber n, int position) { throw null; }
        public static System.Data.OracleClient.OracleNumber Shift(System.Data.OracleClient.OracleNumber n, int digits) { throw null; }
        public static System.Data.OracleClient.OracleNumber Sign(System.Data.OracleClient.OracleNumber n) { throw null; }
        public static System.Data.OracleClient.OracleNumber Sin(System.Data.OracleClient.OracleNumber n) { throw null; }
        public static System.Data.OracleClient.OracleNumber Sinh(System.Data.OracleClient.OracleNumber n) { throw null; }
        public static System.Data.OracleClient.OracleNumber Sqrt(System.Data.OracleClient.OracleNumber n) { throw null; }
        public static System.Data.OracleClient.OracleNumber Subtract(System.Data.OracleClient.OracleNumber x, System.Data.OracleClient.OracleNumber y) { throw null; }
        public static System.Data.OracleClient.OracleNumber Tan(System.Data.OracleClient.OracleNumber n) { throw null; }
        public static System.Data.OracleClient.OracleNumber Tanh(System.Data.OracleClient.OracleNumber n) { throw null; }
        public override string ToString() { throw null; }
        public static System.Data.OracleClient.OracleNumber Truncate(System.Data.OracleClient.OracleNumber n, int position) { throw null; }
    }
    [System.ComponentModel.TypeConverterAttribute("System.Data.OracleClient.OracleParameter.OracleParameterConverter")]
    public sealed partial class OracleParameter : System.Data.Common.DbParameter, System.Data.IDataParameter, System.Data.IDbDataParameter, System.ICloneable
    {
        public OracleParameter() { }
        public OracleParameter(string name, System.Data.OracleClient.OracleType oracleType) { }
        public OracleParameter(string name, System.Data.OracleClient.OracleType oracleType, int size) { }
        public OracleParameter(string name, System.Data.OracleClient.OracleType oracleType, int size, System.Data.ParameterDirection direction, bool isNullable, byte precision, byte scale, string srcColumn, System.Data.DataRowVersion srcVersion, object value) { }
        public OracleParameter(string name, System.Data.OracleClient.OracleType oracleType, int size, System.Data.ParameterDirection direction, string sourceColumn, System.Data.DataRowVersion sourceVersion, bool sourceColumnNullMapping, object value) { }
        public OracleParameter(string name, System.Data.OracleClient.OracleType oracleType, int size, string srcColumn) { }
        public OracleParameter(string name, object value) { }
        public override System.Data.DbType DbType { get { throw null; } set { } }
        [System.ComponentModel.RefreshPropertiesAttribute(System.ComponentModel.RefreshProperties.All)]
        public override System.Data.ParameterDirection Direction { get { throw null; } set { } }
        public override bool IsNullable { get { throw null; } set { } }
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        public int Offset { get { throw null; } set { } }
        [System.ComponentModel.DefaultValueAttribute(System.Data.OracleClient.OracleType.VarChar)]
        [System.ComponentModel.RefreshPropertiesAttribute(System.ComponentModel.RefreshProperties.All)]
        [System.Data.Common.DbProviderSpecificTypePropertyAttribute(true)]
        public System.Data.OracleClient.OracleType OracleType { get { throw null; } set { } }
        public override string ParameterName { get { throw null; } set { } }
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.ObsoleteAttribute("Precision has been deprecated.  Use the Math classes to explicitly set the precision of a decimal.  http://go.microsoft.com/fwlink/?linkid=14202")]
        public new byte Precision { get { throw null; } set { } }
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.ObsoleteAttribute("Scale has been deprecated.  Use the Math classes to explicitly set the scale of a decimal.  http://go.microsoft.com/fwlink/?linkid=14202")]
        public new byte Scale { get { throw null; } set { } }
        public override int Size { get { throw null; } set { } }
        public override string SourceColumn { get { throw null; } set { } }
        public override bool SourceColumnNullMapping { get { throw null; } set { } }
        public override System.Data.DataRowVersion SourceVersion { get { throw null; } set { } }
        [System.ComponentModel.RefreshPropertiesAttribute(System.ComponentModel.RefreshProperties.All)]
        [System.ComponentModel.TypeConverterAttribute(typeof(System.ComponentModel.StringConverter))]
        public override object Value { get { throw null; } set { } }
        public override void ResetDbType() { }
        public void ResetOracleType() { }
        object System.ICloneable.Clone() { throw null; }
        public override string ToString() { throw null; }
    }
    [System.ComponentModel.EditorAttribute("Microsoft.VSDesigner.Data.Design.DBParametersEditor, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor, System.Drawing, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
    [System.ComponentModel.ListBindableAttribute(false)]
    public sealed partial class OracleParameterCollection : System.Data.Common.DbParameterCollection
    {
        public OracleParameterCollection() { }
        public override int Count { get { throw null; } }
        public override bool IsFixedSize { get { throw null; } }
        public override bool IsReadOnly { get { throw null; } }
        public override bool IsSynchronized { get { throw null; } }
        public new System.Data.OracleClient.OracleParameter this[int index] { get { throw null; } set { } }
        public new System.Data.OracleClient.OracleParameter this[string parameterName] { get { throw null; } set { } }
        public override object SyncRoot { get { throw null; } }
        public System.Data.OracleClient.OracleParameter Add(System.Data.OracleClient.OracleParameter value) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int Add(object value) { throw null; }
        public System.Data.OracleClient.OracleParameter Add(string parameterName, System.Data.OracleClient.OracleType dataType) { throw null; }
        public System.Data.OracleClient.OracleParameter Add(string parameterName, System.Data.OracleClient.OracleType dataType, int size) { throw null; }
        public System.Data.OracleClient.OracleParameter Add(string parameterName, System.Data.OracleClient.OracleType dataType, int size, string srcColumn) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.ObsoleteAttribute("Add(String parameterName, Object value) has been deprecated.  Use AddWithValue(String parameterName, Object value).  http://go.microsoft.com/fwlink/?linkid=14202", false)]
        public System.Data.OracleClient.OracleParameter Add(string parameterName, object value) { throw null; }
        public override void AddRange(System.Array values) { }
        public void AddRange(System.Data.OracleClient.OracleParameter[] values) { }
        public System.Data.OracleClient.OracleParameter AddWithValue(string parameterName, object value) { throw null; }
        public override void Clear() { }
        public bool Contains(System.Data.OracleClient.OracleParameter value) { throw null; }
        public override bool Contains(object value) { throw null; }
        public override bool Contains(string parameterName) { throw null; }
        public override void CopyTo(System.Array array, int index) { }
        public void CopyTo(System.Data.OracleClient.OracleParameter[] array, int index) { }
        public override System.Collections.IEnumerator GetEnumerator() { throw null; }
        protected override System.Data.Common.DbParameter GetParameter(int index) { throw null; }
        protected override System.Data.Common.DbParameter GetParameter(string parameterName) { throw null; }
        public int IndexOf(System.Data.OracleClient.OracleParameter value) { throw null; }
        public override int IndexOf(object value) { throw null; }
        public override int IndexOf(string parameterName) { throw null; }
        public void Insert(int index, System.Data.OracleClient.OracleParameter value) { }
        public override void Insert(int index, object value) { }
        public void Remove(System.Data.OracleClient.OracleParameter value) { }
        public override void Remove(object value) { }
        public override void RemoveAt(int index) { }
        public override void RemoveAt(string parameterName) { }
        protected override void SetParameter(int index, System.Data.Common.DbParameter value) { }
        protected override void SetParameter(string parameterName, System.Data.Common.DbParameter value) { }
    }
    [System.ObsoleteAttribute("OraclePermission has been deprecated. http://go.microsoft.com/fwlink/?LinkID=144260", false)]
    [System.SerializableAttribute]
    public sealed partial class OraclePermission : System.Security.CodeAccessPermission, System.Security.Permissions.IUnrestrictedPermission
    {
        public OraclePermission(System.Security.Permissions.PermissionState state) { }
        public bool AllowBlankPassword { get { throw null; } set { } }
        public void Add(string connectionString, string restrictions, System.Data.KeyRestrictionBehavior behavior) { }
        public override System.Security.IPermission Copy() { throw null; }
        public override void FromXml(System.Security.SecurityElement securityElement) { }
        public override System.Security.IPermission Intersect(System.Security.IPermission target) { throw null; }
        public override bool IsSubsetOf(System.Security.IPermission target) { throw null; }
        public bool IsUnrestricted() { throw null; }
        public override System.Security.SecurityElement ToXml() { throw null; }
        public override System.Security.IPermission Union(System.Security.IPermission target) { throw null; }
    }
    [System.AttributeUsageAttribute(System.AttributeTargets.Assembly | System.AttributeTargets.Class | System.AttributeTargets.Constructor | System.AttributeTargets.Method | System.AttributeTargets.Struct, AllowMultiple=true, Inherited=false)]
    [System.ObsoleteAttribute("OraclePermissionAttribute has been deprecated. http://go.microsoft.com/fwlink/?LinkID=144260", false)]
    [System.SerializableAttribute]
    public sealed partial class OraclePermissionAttribute : System.Security.Permissions.CodeAccessSecurityAttribute
    {
        public OraclePermissionAttribute(System.Security.Permissions.SecurityAction action) : base (default(System.Security.Permissions.SecurityAction)) { }
        public bool AllowBlankPassword { get { throw null; } set { } }
        public string ConnectionString { get { throw null; } set { } }
        public System.Data.KeyRestrictionBehavior KeyRestrictionBehavior { get { throw null; } set { } }
        public string KeyRestrictions { get { throw null; } set { } }
        public override System.Security.IPermission CreatePermission() { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public bool ShouldSerializeConnectionString() { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public bool ShouldSerializeKeyRestrictions() { throw null; }
    }
    public sealed partial class OracleRowUpdatedEventArgs : System.Data.Common.RowUpdatedEventArgs
    {
        public OracleRowUpdatedEventArgs(System.Data.DataRow row, System.Data.IDbCommand command, System.Data.StatementType statementType, System.Data.Common.DataTableMapping tableMapping) : base (default(System.Data.DataRow), default(System.Data.IDbCommand), default(System.Data.StatementType), default(System.Data.Common.DataTableMapping)) { }
        public new System.Data.OracleClient.OracleCommand Command { get { throw null; } }
    }
    public delegate void OracleRowUpdatedEventHandler(object sender, System.Data.OracleClient.OracleRowUpdatedEventArgs e);
    public sealed partial class OracleRowUpdatingEventArgs : System.Data.Common.RowUpdatingEventArgs
    {
        public OracleRowUpdatingEventArgs(System.Data.DataRow row, System.Data.IDbCommand command, System.Data.StatementType statementType, System.Data.Common.DataTableMapping tableMapping) : base (default(System.Data.DataRow), default(System.Data.IDbCommand), default(System.Data.StatementType), default(System.Data.Common.DataTableMapping)) { }
        protected override System.Data.IDbCommand BaseCommand { get { throw null; } set { } }
        public new System.Data.OracleClient.OracleCommand Command { get { throw null; } set { } }
    }
    public delegate void OracleRowUpdatingEventHandler(object sender, System.Data.OracleClient.OracleRowUpdatingEventArgs e);
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public partial struct OracleString : System.Data.SqlTypes.INullable, System.IComparable
    {
        private object _dummy;
        public static readonly System.Data.OracleClient.OracleString Empty;
        public static readonly System.Data.OracleClient.OracleString Null;
        public OracleString(string s) { throw null; }
        public bool IsNull { get { throw null; } }
        public char this[int index] { get { throw null; } }
        public int Length { get { throw null; } }
        public string Value { get { throw null; } }
        public int CompareTo(object obj) { throw null; }
        public static System.Data.OracleClient.OracleString Concat(System.Data.OracleClient.OracleString x, System.Data.OracleClient.OracleString y) { throw null; }
        public static System.Data.OracleClient.OracleBoolean Equals(System.Data.OracleClient.OracleString x, System.Data.OracleClient.OracleString y) { throw null; }
        public override bool Equals(object value) { throw null; }
        public override int GetHashCode() { throw null; }
        public static System.Data.OracleClient.OracleBoolean GreaterThan(System.Data.OracleClient.OracleString x, System.Data.OracleClient.OracleString y) { throw null; }
        public static System.Data.OracleClient.OracleBoolean GreaterThanOrEqual(System.Data.OracleClient.OracleString x, System.Data.OracleClient.OracleString y) { throw null; }
        public static System.Data.OracleClient.OracleBoolean LessThan(System.Data.OracleClient.OracleString x, System.Data.OracleClient.OracleString y) { throw null; }
        public static System.Data.OracleClient.OracleBoolean LessThanOrEqual(System.Data.OracleClient.OracleString x, System.Data.OracleClient.OracleString y) { throw null; }
        public static System.Data.OracleClient.OracleBoolean NotEquals(System.Data.OracleClient.OracleString x, System.Data.OracleClient.OracleString y) { throw null; }
        public static System.Data.OracleClient.OracleString operator +(System.Data.OracleClient.OracleString x, System.Data.OracleClient.OracleString y) { throw null; }
        public static System.Data.OracleClient.OracleBoolean operator ==(System.Data.OracleClient.OracleString x, System.Data.OracleClient.OracleString y) { throw null; }
        public static explicit operator string (System.Data.OracleClient.OracleString x) { throw null; }
        public static System.Data.OracleClient.OracleBoolean operator >(System.Data.OracleClient.OracleString x, System.Data.OracleClient.OracleString y) { throw null; }
        public static System.Data.OracleClient.OracleBoolean operator >=(System.Data.OracleClient.OracleString x, System.Data.OracleClient.OracleString y) { throw null; }
        public static implicit operator System.Data.OracleClient.OracleString (string s) { throw null; }
        public static System.Data.OracleClient.OracleBoolean operator !=(System.Data.OracleClient.OracleString x, System.Data.OracleClient.OracleString y) { throw null; }
        public static System.Data.OracleClient.OracleBoolean operator <(System.Data.OracleClient.OracleString x, System.Data.OracleClient.OracleString y) { throw null; }
        public static System.Data.OracleClient.OracleBoolean operator <=(System.Data.OracleClient.OracleString x, System.Data.OracleClient.OracleString y) { throw null; }
        public override string ToString() { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential, Pack=1)]
    public partial struct OracleTimeSpan : System.Data.SqlTypes.INullable, System.IComparable
    {
        private object _dummy;
        public static readonly System.Data.OracleClient.OracleTimeSpan MaxValue;
        public static readonly System.Data.OracleClient.OracleTimeSpan MinValue;
        public static readonly System.Data.OracleClient.OracleTimeSpan Null;
        public OracleTimeSpan(System.Data.OracleClient.OracleTimeSpan from) { throw null; }
        public OracleTimeSpan(int hours, int minutes, int seconds) { throw null; }
        public OracleTimeSpan(int days, int hours, int minutes, int seconds) { throw null; }
        public OracleTimeSpan(int days, int hours, int minutes, int seconds, int milliseconds) { throw null; }
        public OracleTimeSpan(long ticks) { throw null; }
        public OracleTimeSpan(System.TimeSpan ts) { throw null; }
        public int Days { get { throw null; } }
        public int Hours { get { throw null; } }
        public bool IsNull { get { throw null; } }
        public int Milliseconds { get { throw null; } }
        public int Minutes { get { throw null; } }
        public int Seconds { get { throw null; } }
        public System.TimeSpan Value { get { throw null; } }
        public int CompareTo(object obj) { throw null; }
        public static System.Data.OracleClient.OracleBoolean Equals(System.Data.OracleClient.OracleTimeSpan x, System.Data.OracleClient.OracleTimeSpan y) { throw null; }
        public override bool Equals(object value) { throw null; }
        public override int GetHashCode() { throw null; }
        public static System.Data.OracleClient.OracleBoolean GreaterThan(System.Data.OracleClient.OracleTimeSpan x, System.Data.OracleClient.OracleTimeSpan y) { throw null; }
        public static System.Data.OracleClient.OracleBoolean GreaterThanOrEqual(System.Data.OracleClient.OracleTimeSpan x, System.Data.OracleClient.OracleTimeSpan y) { throw null; }
        public static System.Data.OracleClient.OracleBoolean LessThan(System.Data.OracleClient.OracleTimeSpan x, System.Data.OracleClient.OracleTimeSpan y) { throw null; }
        public static System.Data.OracleClient.OracleBoolean LessThanOrEqual(System.Data.OracleClient.OracleTimeSpan x, System.Data.OracleClient.OracleTimeSpan y) { throw null; }
        public static System.Data.OracleClient.OracleBoolean NotEquals(System.Data.OracleClient.OracleTimeSpan x, System.Data.OracleClient.OracleTimeSpan y) { throw null; }
        public static System.Data.OracleClient.OracleBoolean operator ==(System.Data.OracleClient.OracleTimeSpan x, System.Data.OracleClient.OracleTimeSpan y) { throw null; }
        public static explicit operator System.TimeSpan (System.Data.OracleClient.OracleTimeSpan x) { throw null; }
        public static explicit operator System.Data.OracleClient.OracleTimeSpan (string x) { throw null; }
        public static System.Data.OracleClient.OracleBoolean operator >(System.Data.OracleClient.OracleTimeSpan x, System.Data.OracleClient.OracleTimeSpan y) { throw null; }
        public static System.Data.OracleClient.OracleBoolean operator >=(System.Data.OracleClient.OracleTimeSpan x, System.Data.OracleClient.OracleTimeSpan y) { throw null; }
        public static System.Data.OracleClient.OracleBoolean operator !=(System.Data.OracleClient.OracleTimeSpan x, System.Data.OracleClient.OracleTimeSpan y) { throw null; }
        public static System.Data.OracleClient.OracleBoolean operator <(System.Data.OracleClient.OracleTimeSpan x, System.Data.OracleClient.OracleTimeSpan y) { throw null; }
        public static System.Data.OracleClient.OracleBoolean operator <=(System.Data.OracleClient.OracleTimeSpan x, System.Data.OracleClient.OracleTimeSpan y) { throw null; }
        public static System.Data.OracleClient.OracleTimeSpan Parse(string s) { throw null; }
        public override string ToString() { throw null; }
    }
    public sealed partial class OracleTransaction : System.Data.Common.DbTransaction
    {
        internal OracleTransaction() { }
        public new System.Data.OracleClient.OracleConnection Connection { get { throw null; } }
        protected override System.Data.Common.DbConnection DbConnection { get { throw null; } }
        public override System.Data.IsolationLevel IsolationLevel { get { throw null; } }
        public override void Commit() { }
        protected override void Dispose(bool disposing) { }
        public override void Rollback() { }
    }
    public enum OracleType
    {
        BFile = 1,
        Blob = 2,
        Byte = 23,
        Char = 3,
        Clob = 4,
        Cursor = 5,
        DateTime = 6,
        Double = 30,
        Float = 29,
        Int16 = 27,
        Int32 = 28,
        IntervalDayToSecond = 7,
        IntervalYearToMonth = 8,
        LongRaw = 9,
        LongVarChar = 10,
        NChar = 11,
        NClob = 12,
        Number = 13,
        NVarChar = 14,
        Raw = 15,
        RowId = 16,
        SByte = 26,
        Timestamp = 18,
        TimestampLocal = 19,
        TimestampWithTZ = 20,
        UInt16 = 24,
        UInt32 = 25,
        VarChar = 22,
    }
}
