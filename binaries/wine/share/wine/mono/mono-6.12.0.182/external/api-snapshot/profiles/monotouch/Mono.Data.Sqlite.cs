// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

[assembly:System.Reflection.AssemblyVersionAttribute("2.0.5.0")]
[assembly:System.CLSCompliantAttribute(true)]
[assembly:System.Diagnostics.DebuggableAttribute(System.Diagnostics.DebuggableAttribute.DebuggingModes.IgnoreSymbolStoreSequencePoints)]
[assembly:System.Reflection.AssemblyCompanyAttribute("http://sqlite.phxsoftware.com")]
[assembly:System.Reflection.AssemblyConfigurationAttribute("")]
[assembly:System.Reflection.AssemblyCopyrightAttribute("Public Domain")]
[assembly:System.Reflection.AssemblyDescriptionAttribute("ADO.NET 2.0 Data Provider for SQLite")]
[assembly:System.Reflection.AssemblyFileVersionAttribute("1.0.61.0")]
[assembly:System.Reflection.AssemblyProductAttribute("System.Data.SQLite")]
[assembly:System.Reflection.AssemblyTitleAttribute("System.Data.SQLite")]
[assembly:System.Reflection.AssemblyTrademarkAttribute("")]
[assembly:System.Runtime.CompilerServices.CompilationRelaxationsAttribute(8)]
[assembly:System.Runtime.CompilerServices.RuntimeCompatibilityAttribute(WrapNonExceptionThrows=true)]
[assembly:System.Runtime.ConstrainedExecution.ReliabilityContractAttribute(System.Runtime.ConstrainedExecution.Consistency.WillNotCorruptState, System.Runtime.ConstrainedExecution.Cer.Success)]
[assembly:System.Runtime.InteropServices.ComVisibleAttribute(false)]
[assembly:System.Security.AllowPartiallyTrustedCallersAttribute]
[assembly:System.Security.SecurityRulesAttribute(System.Security.SecurityRuleSet.Level1)]
[assembly:System.Security.Permissions.SecurityPermissionAttribute(System.Security.Permissions.SecurityAction.RequestMinimum, SkipVerification=true)]
namespace Mono.Data.Sqlite
{
    public enum CollationEncodingEnum
    {
        UTF16BE = 3,
        UTF16LE = 2,
        UTF8 = 1,
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public partial struct CollationSequence
    {
        private object _dummy;
        public Mono.Data.Sqlite.CollationEncodingEnum Encoding;
        public string Name;
        public Mono.Data.Sqlite.CollationTypeEnum Type;
        public int Compare(char[] c1, char[] c2) { throw null; }
        public int Compare(string s1, string s2) { throw null; }
    }
    public enum CollationTypeEnum
    {
        Binary = 1,
        Custom = 0,
        NoCase = 2,
        Reverse = 3,
    }
    public partial class CommitEventArgs : System.EventArgs
    {
        internal CommitEventArgs() { }
        public bool AbortTransaction;
    }
    public enum FunctionType
    {
        Aggregate = 1,
        Collation = 2,
        Scalar = 0,
    }
    [System.ComponentModel.ToolboxItemAttribute(true)]
    public sealed partial class SqliteCommand : System.Data.Common.DbCommand, System.ICloneable
    {
        public SqliteCommand() { }
        public SqliteCommand(Mono.Data.Sqlite.SqliteConnection connection) { }
        public SqliteCommand(string commandText) { }
        public SqliteCommand(string commandText, Mono.Data.Sqlite.SqliteConnection connection) { }
        public SqliteCommand(string commandText, Mono.Data.Sqlite.SqliteConnection connection, Mono.Data.Sqlite.SqliteTransaction transaction) { }
        [System.ComponentModel.DefaultValueAttribute("")]
        [System.ComponentModel.EditorAttribute("Microsoft.VSDesigner.Data.SQL.Design.SqlCommandTextEditor, Microsoft.VSDesigner, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor, System.Drawing, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
        [System.ComponentModel.RefreshPropertiesAttribute(System.ComponentModel.RefreshProperties.All)]
        public override string CommandText { get { throw null; } set { } }
        [System.ComponentModel.DefaultValueAttribute(30)]
        public override int CommandTimeout { get { throw null; } set { } }
        [System.ComponentModel.DefaultValueAttribute(System.Data.CommandType.Text)]
        [System.ComponentModel.RefreshPropertiesAttribute(System.ComponentModel.RefreshProperties.All)]
        public override System.Data.CommandType CommandType { get { throw null; } set { } }
        [System.ComponentModel.DefaultValueAttribute(null)]
        [System.ComponentModel.EditorAttribute("Microsoft.VSDesigner.Data.Design.DbConnectionEditor, Microsoft.VSDesigner, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor, System.Drawing, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
        public new Mono.Data.Sqlite.SqliteConnection Connection { get { throw null; } set { } }
        protected override System.Data.Common.DbConnection DbConnection { get { throw null; } set { } }
        protected override System.Data.Common.DbParameterCollection DbParameterCollection { get { throw null; } }
        protected override System.Data.Common.DbTransaction DbTransaction { get { throw null; } set { } }
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.DefaultValueAttribute(true)]
        [System.ComponentModel.DesignOnlyAttribute(true)]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool DesignTimeVisible { get { throw null; } set { } }
        [System.ComponentModel.DesignerSerializationVisibilityAttribute(System.ComponentModel.DesignerSerializationVisibility.Content)]
        public new Mono.Data.Sqlite.SqliteParameterCollection Parameters { get { throw null; } }
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.DesignerSerializationVisibilityAttribute(System.ComponentModel.DesignerSerializationVisibility.Hidden)]
        public new Mono.Data.Sqlite.SqliteTransaction Transaction { get { throw null; } set { } }
        [System.ComponentModel.DefaultValueAttribute(System.Data.UpdateRowSource.None)]
        public override System.Data.UpdateRowSource UpdatedRowSource { get { throw null; } set { } }
        public override void Cancel() { }
        public object Clone() { throw null; }
        protected override System.Data.Common.DbParameter CreateDbParameter() { throw null; }
        public new Mono.Data.Sqlite.SqliteParameter CreateParameter() { throw null; }
        protected override void Dispose(bool disposing) { }
        protected override System.Data.Common.DbDataReader ExecuteDbDataReader(System.Data.CommandBehavior behavior) { throw null; }
        public override int ExecuteNonQuery() { throw null; }
        public new Mono.Data.Sqlite.SqliteDataReader ExecuteReader() { throw null; }
        public new Mono.Data.Sqlite.SqliteDataReader ExecuteReader(System.Data.CommandBehavior behavior) { throw null; }
        public override object ExecuteScalar() { throw null; }
        public override void Prepare() { }
    }
    public sealed partial class SqliteCommandBuilder : System.Data.Common.DbCommandBuilder
    {
        public SqliteCommandBuilder() { }
        public SqliteCommandBuilder(Mono.Data.Sqlite.SqliteDataAdapter adp) { }
        [System.ComponentModel.BrowsableAttribute(false)]
        public override System.Data.Common.CatalogLocation CatalogLocation { get { throw null; } set { } }
        [System.ComponentModel.BrowsableAttribute(false)]
        public override string CatalogSeparator { get { throw null; } set { } }
        public new Mono.Data.Sqlite.SqliteDataAdapter DataAdapter { get { throw null; } set { } }
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.DefaultValueAttribute("[")]
        public override string QuotePrefix { get { throw null; } set { } }
        [System.ComponentModel.BrowsableAttribute(false)]
        public override string QuoteSuffix { get { throw null; } set { } }
        [System.ComponentModel.BrowsableAttribute(false)]
        public override string SchemaSeparator { get { throw null; } set { } }
        protected override void ApplyParameterInfo(System.Data.Common.DbParameter parameter, System.Data.DataRow row, System.Data.StatementType statementType, bool whereClause) { }
        public new Mono.Data.Sqlite.SqliteCommand GetDeleteCommand() { throw null; }
        public new Mono.Data.Sqlite.SqliteCommand GetDeleteCommand(bool useColumnsForParameterNames) { throw null; }
        public new Mono.Data.Sqlite.SqliteCommand GetInsertCommand() { throw null; }
        public new Mono.Data.Sqlite.SqliteCommand GetInsertCommand(bool useColumnsForParameterNames) { throw null; }
        protected override string GetParameterName(int parameterOrdinal) { throw null; }
        protected override string GetParameterName(string parameterName) { throw null; }
        protected override string GetParameterPlaceholder(int parameterOrdinal) { throw null; }
        protected override System.Data.DataTable GetSchemaTable(System.Data.Common.DbCommand sourceCommand) { throw null; }
        public new Mono.Data.Sqlite.SqliteCommand GetUpdateCommand() { throw null; }
        public new Mono.Data.Sqlite.SqliteCommand GetUpdateCommand(bool useColumnsForParameterNames) { throw null; }
        public override string QuoteIdentifier(string unquotedIdentifier) { throw null; }
        protected override void SetRowUpdatingHandler(System.Data.Common.DbDataAdapter adapter) { }
        public override string UnquoteIdentifier(string quotedIdentifier) { throw null; }
    }
    public delegate void SQLiteCommitHandler(object sender, Mono.Data.Sqlite.CommitEventArgs e);
    public enum SQLiteConfig
    {
        MultiThread = 2,
        Serialized = 3,
        SingleThread = 1,
    }
    public sealed partial class SqliteConnection : System.Data.Common.DbConnection, System.ICloneable
    {
        public SqliteConnection() { }
        public SqliteConnection(Mono.Data.Sqlite.SqliteConnection connection) { }
        public SqliteConnection(string connectionString) { }
        [System.ComponentModel.DefaultValueAttribute("")]
        [System.ComponentModel.EditorAttribute("SQLite.Designer.SqliteConnectionStringEditor, SQLite.Designer, Version=1.0.36.0, Culture=neutral, PublicKeyToken=db937bc2d44ff139", "System.Drawing.Design.UITypeEditor, System.Drawing, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
        [System.ComponentModel.RefreshPropertiesAttribute(System.ComponentModel.RefreshProperties.All)]
        public override string ConnectionString { get { throw null; } set { } }
        [System.ComponentModel.DesignerSerializationVisibilityAttribute(System.ComponentModel.DesignerSerializationVisibility.Hidden)]
        public override string Database { get { throw null; } }
        [System.ComponentModel.DesignerSerializationVisibilityAttribute(System.ComponentModel.DesignerSerializationVisibility.Hidden)]
        public override string DataSource { get { throw null; } }
        protected override System.Data.Common.DbProviderFactory DbProviderFactory { get { throw null; } }
        public int DefaultTimeout { get { throw null; } set { } }
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.DesignerSerializationVisibilityAttribute(System.ComponentModel.DesignerSerializationVisibility.Hidden)]
        public override string ServerVersion { get { throw null; } }
        public static string SQLiteVersion { get { throw null; } }
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.DesignerSerializationVisibilityAttribute(System.ComponentModel.DesignerSerializationVisibility.Hidden)]
        public override System.Data.ConnectionState State { get { throw null; } }
        public event Mono.Data.Sqlite.SQLiteCommitHandler Commit { add { } remove { } }
        public event System.EventHandler RollBack { add { } remove { } }
        public override event System.Data.StateChangeEventHandler StateChange { add { } remove { } }
        public event Mono.Data.Sqlite.SQLiteUpdateEventHandler Update { add { } remove { } }
        protected override System.Data.Common.DbTransaction BeginDbTransaction(System.Data.IsolationLevel isolationLevel) { throw null; }
        public new Mono.Data.Sqlite.SqliteTransaction BeginTransaction() { throw null; }
        [System.ObsoleteAttribute("Use one of the standard BeginTransaction methods, this one will be removed soon")]
        public Mono.Data.Sqlite.SqliteTransaction BeginTransaction(bool deferredLock) { throw null; }
        public new Mono.Data.Sqlite.SqliteTransaction BeginTransaction(System.Data.IsolationLevel isolationLevel) { throw null; }
        [System.ObsoleteAttribute("Use one of the standard BeginTransaction methods, this one will be removed soon")]
        public Mono.Data.Sqlite.SqliteTransaction BeginTransaction(System.Data.IsolationLevel isolationLevel, bool deferredLock) { throw null; }
        public override void ChangeDatabase(string databaseName) { }
        public void ChangePassword(byte[] newPassword) { }
        public void ChangePassword(string newPassword) { }
        public static void ClearAllPools() { }
        public static void ClearPool(Mono.Data.Sqlite.SqliteConnection connection) { }
        public object Clone() { throw null; }
        public override void Close() { }
        public new Mono.Data.Sqlite.SqliteCommand CreateCommand() { throw null; }
        protected override System.Data.Common.DbCommand CreateDbCommand() { throw null; }
        public static void CreateFile(string databaseFileName) { }
        protected override void Dispose(bool disposing) { }
        public override void EnlistTransaction(System.Transactions.Transaction transaction) { }
        public override System.Data.DataTable GetSchema() { throw null; }
        public override System.Data.DataTable GetSchema(string collectionName) { throw null; }
        public override System.Data.DataTable GetSchema(string collectionName, string[] restrictionValues) { throw null; }
        public override void Open() { }
        public static void SetConfig(Mono.Data.Sqlite.SQLiteConfig config) { }
        public void SetPassword(byte[] databasePassword) { }
        public void SetPassword(string databasePassword) { }
    }
    [System.ComponentModel.DefaultPropertyAttribute("DataSource")]
    public sealed partial class SqliteConnectionStringBuilder : System.Data.Common.DbConnectionStringBuilder
    {
        public SqliteConnectionStringBuilder() { }
        public SqliteConnectionStringBuilder(string connectionString) { }
        [System.ComponentModel.BrowsableAttribute(true)]
        [System.ComponentModel.DefaultValueAttribute(true)]
        public bool BinaryGUID { get { throw null; } set { } }
        [System.ComponentModel.BrowsableAttribute(true)]
        [System.ComponentModel.DefaultValueAttribute(2000)]
        [System.ComponentModel.DisplayNameAttribute("Cache Size")]
        public int CacheSize { get { throw null; } set { } }
        [System.ComponentModel.BrowsableAttribute(true)]
        [System.ComponentModel.DefaultValueAttribute("")]
        [System.ComponentModel.DisplayNameAttribute("Data Source")]
        public string DataSource { get { throw null; } set { } }
        [System.ComponentModel.BrowsableAttribute(true)]
        [System.ComponentModel.DefaultValueAttribute(Mono.Data.Sqlite.SQLiteDateFormats.ISO8601)]
        public Mono.Data.Sqlite.SQLiteDateFormats DateTimeFormat { get { throw null; } set { } }
        [System.ComponentModel.BrowsableAttribute(true)]
        [System.ComponentModel.DefaultValueAttribute(System.Data.IsolationLevel.Serializable)]
        [System.ComponentModel.DisplayNameAttribute("Default Isolation Level")]
        public System.Data.IsolationLevel DefaultIsolationLevel { get { throw null; } set { } }
        [System.ComponentModel.BrowsableAttribute(true)]
        [System.ComponentModel.DefaultValueAttribute(30)]
        [System.ComponentModel.DisplayNameAttribute("Default Timeout")]
        public int DefaultTimeout { get { throw null; } set { } }
        [System.ComponentModel.BrowsableAttribute(true)]
        [System.ComponentModel.DefaultValueAttribute(true)]
        public bool Enlist { get { throw null; } set { } }
        [System.ComponentModel.BrowsableAttribute(true)]
        [System.ComponentModel.DefaultValueAttribute(false)]
        public bool FailIfMissing { get { throw null; } set { } }
        [System.ComponentModel.BrowsableAttribute(true)]
        [System.ComponentModel.DefaultValueAttribute(Mono.Data.Sqlite.SQLiteJournalModeEnum.Delete)]
        [System.ComponentModel.DisplayNameAttribute("Journal Mode")]
        public Mono.Data.Sqlite.SQLiteJournalModeEnum JournalMode { get { throw null; } set { } }
        [System.ComponentModel.BrowsableAttribute(true)]
        [System.ComponentModel.DefaultValueAttribute(false)]
        [System.ComponentModel.DisplayNameAttribute("Legacy Format")]
        public bool LegacyFormat { get { throw null; } set { } }
        [System.ComponentModel.BrowsableAttribute(true)]
        [System.ComponentModel.DefaultValueAttribute(0)]
        [System.ComponentModel.DisplayNameAttribute("Max Page Count")]
        public int MaxPageCount { get { throw null; } set { } }
        [System.ComponentModel.BrowsableAttribute(true)]
        [System.ComponentModel.DefaultValueAttribute(1024)]
        [System.ComponentModel.DisplayNameAttribute("Page Size")]
        public int PageSize { get { throw null; } set { } }
        [System.ComponentModel.BrowsableAttribute(true)]
        [System.ComponentModel.DefaultValueAttribute("")]
        [System.ComponentModel.PasswordPropertyTextAttribute(true)]
        public string Password { get { throw null; } set { } }
        [System.ComponentModel.BrowsableAttribute(true)]
        [System.ComponentModel.DefaultValueAttribute(false)]
        public bool Pooling { get { throw null; } set { } }
        [System.ComponentModel.BrowsableAttribute(true)]
        [System.ComponentModel.DefaultValueAttribute(false)]
        [System.ComponentModel.DisplayNameAttribute("Read Only")]
        public bool ReadOnly { get { throw null; } set { } }
        [System.ComponentModel.BrowsableAttribute(true)]
        [System.ComponentModel.DefaultValueAttribute(Mono.Data.Sqlite.SynchronizationModes.Normal)]
        [System.ComponentModel.DisplayNameAttribute("Synchronous")]
        public Mono.Data.Sqlite.SynchronizationModes SyncMode { get { throw null; } set { } }
        [System.ComponentModel.BrowsableAttribute(false)]
        public string Uri { get { throw null; } set { } }
        [System.ComponentModel.BrowsableAttribute(true)]
        [System.ComponentModel.DefaultValueAttribute(false)]
        public bool UseUTF16Encoding { get { throw null; } set { } }
        [System.ComponentModel.BrowsableAttribute(true)]
        [System.ComponentModel.DefaultValueAttribute(3)]
        public int Version { get { throw null; } set { } }
        public override bool TryGetValue(string keyword, out object value) { throw null; }
    }
    public abstract partial class SqliteConvert
    {
        internal SqliteConvert() { }
        protected static readonly System.DateTime UnixEpoch;
        public static string[] Split(string source, char separator) { throw null; }
        public static bool ToBoolean(object source) { throw null; }
        public static bool ToBoolean(string source) { throw null; }
        public System.DateTime ToDateTime(double julianDay) { throw null; }
        public System.DateTime ToDateTime(string dateText) { throw null; }
        public double ToJulianDay(System.DateTime value) { throw null; }
        public string ToString(System.DateTime dateValue) { throw null; }
        public virtual string ToString(System.IntPtr nativestring, int nativestringlen) { throw null; }
        public byte[] ToUTF8(System.DateTime dateTimeValue) { throw null; }
        public static byte[] ToUTF8(string sourceText) { throw null; }
        public static string UTF8ToString(System.IntPtr nativestring, int nativestringlen) { throw null; }
    }
    [System.ComponentModel.DefaultEventAttribute("RowUpdated")]
    [System.ComponentModel.ToolboxItemAttribute("SQLite.Designer.SqliteDataAdapterToolboxItem, SQLite.Designer, Version=1.0.36.0, Culture=neutral, PublicKeyToken=db937bc2d44ff139")]
    public sealed partial class SqliteDataAdapter : System.Data.Common.DbDataAdapter
    {
        public SqliteDataAdapter() { }
        public SqliteDataAdapter(Mono.Data.Sqlite.SqliteCommand cmd) { }
        public SqliteDataAdapter(string commandText, Mono.Data.Sqlite.SqliteConnection connection) { }
        public SqliteDataAdapter(string commandText, string connectionString) { }
        [System.ComponentModel.DefaultValueAttribute(null)]
        [System.ComponentModel.EditorAttribute("Microsoft.VSDesigner.Data.Design.DBCommandEditor, Microsoft.VSDesigner, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor, System.Drawing, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
        public new Mono.Data.Sqlite.SqliteCommand DeleteCommand { get { throw null; } set { } }
        [System.ComponentModel.DefaultValueAttribute(null)]
        [System.ComponentModel.EditorAttribute("Microsoft.VSDesigner.Data.Design.DBCommandEditor, Microsoft.VSDesigner, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor, System.Drawing, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
        public new Mono.Data.Sqlite.SqliteCommand InsertCommand { get { throw null; } set { } }
        [System.ComponentModel.DefaultValueAttribute(null)]
        [System.ComponentModel.EditorAttribute("Microsoft.VSDesigner.Data.Design.DBCommandEditor, Microsoft.VSDesigner, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor, System.Drawing, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
        public new Mono.Data.Sqlite.SqliteCommand SelectCommand { get { throw null; } set { } }
        [System.ComponentModel.DefaultValueAttribute(null)]
        [System.ComponentModel.EditorAttribute("Microsoft.VSDesigner.Data.Design.DBCommandEditor, Microsoft.VSDesigner, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor, System.Drawing, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
        public new Mono.Data.Sqlite.SqliteCommand UpdateCommand { get { throw null; } set { } }
        public event System.EventHandler<System.Data.Common.RowUpdatedEventArgs> RowUpdated { add { } remove { } }
        public event System.EventHandler<System.Data.Common.RowUpdatingEventArgs> RowUpdating { add { } remove { } }
        protected override void OnRowUpdated(System.Data.Common.RowUpdatedEventArgs value) { }
        protected override void OnRowUpdating(System.Data.Common.RowUpdatingEventArgs value) { }
    }
    public sealed partial class SqliteDataReader : System.Data.Common.DbDataReader
    {
        internal SqliteDataReader() { }
        public override int Depth { get { throw null; } }
        public override int FieldCount { get { throw null; } }
        public override bool HasRows { get { throw null; } }
        public override bool IsClosed { get { throw null; } }
        public override object this[int i] { get { throw null; } }
        public override object this[string name] { get { throw null; } }
        public override int RecordsAffected { get { throw null; } }
        public override int VisibleFieldCount { get { throw null; } }
        public override void Close() { }
        public override bool GetBoolean(int i) { throw null; }
        public override byte GetByte(int i) { throw null; }
        public override long GetBytes(int i, long fieldOffset, byte[] buffer, int bufferoffset, int length) { throw null; }
        public override char GetChar(int i) { throw null; }
        public override long GetChars(int i, long fieldoffset, char[] buffer, int bufferoffset, int length) { throw null; }
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
        public override int GetOrdinal(string name) { throw null; }
        public override System.Data.DataTable GetSchemaTable() { throw null; }
        public override string GetString(int i) { throw null; }
        public override object GetValue(int i) { throw null; }
        public override int GetValues(object[] values) { throw null; }
        public override bool IsDBNull(int i) { throw null; }
        public override bool NextResult() { throw null; }
        public override bool Read() { throw null; }
    }
    public partial class SqliteDataSourceEnumerator : System.Data.Common.DbDataSourceEnumerator
    {
        public SqliteDataSourceEnumerator() { }
        public override System.Data.DataTable GetDataSources() { throw null; }
    }
    public enum SQLiteDateFormats
    {
        ISO8601 = 1,
        JulianDay = 2,
        Ticks = 0,
        UnixEpoch = 3,
    }
    public enum SQLiteErrorCode
    {
        Abort = 4,
        Auth = 23,
        Busy = 5,
        CantOpen = 14,
        Constraint = 19,
        Corrupt = 11,
        Done = 101,
        Empty = 16,
        Error = 1,
        Format = 24,
        Full = 13,
        Internal = 2,
        Interrupt = 9,
        IOErr = 10,
        Locked = 6,
        Mismatch = 20,
        Misuse = 21,
        NOLFS = 22,
        NoMem = 7,
        NotADatabase = 26,
        NotFound = 12,
        Ok = 0,
        Perm = 3,
        Protocol = 15,
        Range = 25,
        ReadOnly = 8,
        Row = 100,
        Schema = 17,
        TooBig = 18,
    }
    [System.SerializableAttribute]
    public sealed partial class SqliteException : System.Data.Common.DbException
    {
        public SqliteException() { }
        public SqliteException(int errorCode, string extendedInformation) { }
        public SqliteException(string message) { }
        public SqliteException(string message, System.Exception innerException) { }
        public new Mono.Data.Sqlite.SQLiteErrorCode ErrorCode { get { throw null; } }
    }
    public sealed partial class SqliteFactory : System.Data.Common.DbProviderFactory, System.IServiceProvider
    {
        public static readonly Mono.Data.Sqlite.SqliteFactory Instance;
        public SqliteFactory() { }
        public override System.Data.Common.DbCommand CreateCommand() { throw null; }
        public override System.Data.Common.DbCommandBuilder CreateCommandBuilder() { throw null; }
        public override System.Data.Common.DbConnection CreateConnection() { throw null; }
        public override System.Data.Common.DbConnectionStringBuilder CreateConnectionStringBuilder() { throw null; }
        public override System.Data.Common.DbDataAdapter CreateDataAdapter() { throw null; }
        public override System.Data.Common.DbParameter CreateParameter() { throw null; }
        object System.IServiceProvider.GetService(System.Type serviceType) { throw null; }
    }
    public abstract partial class SqliteFunction : System.IDisposable
    {
        protected SqliteFunction() { }
        public Mono.Data.Sqlite.SqliteConvert SqliteConvert { get { throw null; } }
        public virtual int Compare(string param1, string param2) { throw null; }
        public void Dispose() { }
        protected virtual void Dispose(bool disposing) { }
        public virtual object Final(object contextData) { throw null; }
        public virtual object Invoke(object[] args) { throw null; }
        public static void RegisterFunction(System.Type typ) { }
        public virtual void Step(object[] args, int stepNumber, ref object contextData) { }
    }
    [System.AttributeUsageAttribute(System.AttributeTargets.Class, Inherited=false, AllowMultiple=true)]
    public sealed partial class SqliteFunctionAttribute : System.Attribute
    {
        public SqliteFunctionAttribute() { }
        public int Arguments { get { throw null; } set { } }
        public Mono.Data.Sqlite.FunctionType FuncType { get { throw null; } set { } }
        public string Name { get { throw null; } set { } }
    }
    public partial class SqliteFunctionEx : Mono.Data.Sqlite.SqliteFunction
    {
        public SqliteFunctionEx() { }
        protected Mono.Data.Sqlite.CollationSequence GetCollationSequence() { throw null; }
    }
    public enum SQLiteJournalModeEnum
    {
        Delete = 0,
        Off = 2,
        Persist = 1,
    }
    public static partial class SqliteMetaDataCollectionNames
    {
        public static readonly string Catalogs;
        public static readonly string Columns;
        public static readonly string ForeignKeys;
        public static readonly string IndexColumns;
        public static readonly string Indexes;
        public static readonly string Tables;
        public static readonly string Triggers;
        public static readonly string ViewColumns;
        public static readonly string Views;
    }
    public sealed partial class SqliteParameter : System.Data.Common.DbParameter, System.ICloneable
    {
        public SqliteParameter() { }
        public SqliteParameter(System.Data.DbType dbType) { }
        public SqliteParameter(System.Data.DbType parameterType, int parameterSize) { }
        public SqliteParameter(System.Data.DbType parameterType, int parameterSize, string sourceColumn) { }
        public SqliteParameter(System.Data.DbType parameterType, int parameterSize, string sourceColumn, System.Data.DataRowVersion rowVersion) { }
        public SqliteParameter(System.Data.DbType dbType, object value) { }
        public SqliteParameter(System.Data.DbType dbType, string sourceColumn) { }
        public SqliteParameter(System.Data.DbType dbType, string sourceColumn, System.Data.DataRowVersion rowVersion) { }
        public SqliteParameter(string parameterName) { }
        public SqliteParameter(string parameterName, System.Data.DbType dbType) { }
        public SqliteParameter(string parameterName, System.Data.DbType parameterType, int parameterSize) { }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        public SqliteParameter(string parameterName, System.Data.DbType parameterType, int parameterSize, System.Data.ParameterDirection direction, bool isNullable, byte precision, byte scale, string sourceColumn, System.Data.DataRowVersion rowVersion, object value) { }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        public SqliteParameter(string parameterName, System.Data.DbType parameterType, int parameterSize, System.Data.ParameterDirection direction, byte precision, byte scale, string sourceColumn, System.Data.DataRowVersion rowVersion, bool sourceColumnNullMapping, object value) { }
        public SqliteParameter(string parameterName, System.Data.DbType parameterType, int parameterSize, string sourceColumn) { }
        public SqliteParameter(string parameterName, System.Data.DbType parameterType, int parameterSize, string sourceColumn, System.Data.DataRowVersion rowVersion) { }
        public SqliteParameter(string parameterName, System.Data.DbType dbType, string sourceColumn) { }
        public SqliteParameter(string parameterName, System.Data.DbType dbType, string sourceColumn, System.Data.DataRowVersion rowVersion) { }
        public SqliteParameter(string parameterName, object value) { }
        [System.ComponentModel.RefreshPropertiesAttribute(System.ComponentModel.RefreshProperties.All)]
        [System.Data.Common.DbProviderSpecificTypePropertyAttribute(true)]
        public override System.Data.DbType DbType { get { throw null; } set { } }
        public override System.Data.ParameterDirection Direction { get { throw null; } set { } }
        public override bool IsNullable { get { throw null; } set { } }
        public override string ParameterName { get { throw null; } set { } }
        [System.ComponentModel.DefaultValueAttribute(0)]
        public override int Size { get { throw null; } set { } }
        public override string SourceColumn { get { throw null; } set { } }
        public override bool SourceColumnNullMapping { get { throw null; } set { } }
        public override System.Data.DataRowVersion SourceVersion { get { throw null; } set { } }
        [System.ComponentModel.RefreshPropertiesAttribute(System.ComponentModel.RefreshProperties.All)]
        [System.ComponentModel.TypeConverterAttribute(typeof(System.ComponentModel.StringConverter))]
        public override object Value { get { throw null; } set { } }
        public object Clone() { throw null; }
        public override void ResetDbType() { }
    }
    [System.ComponentModel.EditorAttribute("Microsoft.VSDesigner.Data.Design.DBParametersEditor, Microsoft.VSDesigner, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor, System.Drawing, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
    [System.ComponentModel.ListBindableAttribute(false)]
    public sealed partial class SqliteParameterCollection : System.Data.Common.DbParameterCollection
    {
        internal SqliteParameterCollection() { }
        public override int Count { get { throw null; } }
        public override bool IsFixedSize { get { throw null; } }
        public override bool IsReadOnly { get { throw null; } }
        public override bool IsSynchronized { get { throw null; } }
        public new Mono.Data.Sqlite.SqliteParameter this[int index] { get { throw null; } set { } }
        public new Mono.Data.Sqlite.SqliteParameter this[string parameterName] { get { throw null; } set { } }
        public override object SyncRoot { get { throw null; } }
        public int Add(Mono.Data.Sqlite.SqliteParameter parameter) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int Add(object value) { throw null; }
        public Mono.Data.Sqlite.SqliteParameter Add(string parameterName, System.Data.DbType parameterType) { throw null; }
        public Mono.Data.Sqlite.SqliteParameter Add(string parameterName, System.Data.DbType parameterType, int parameterSize) { throw null; }
        public Mono.Data.Sqlite.SqliteParameter Add(string parameterName, System.Data.DbType parameterType, int parameterSize, string sourceColumn) { throw null; }
        public void AddRange(Mono.Data.Sqlite.SqliteParameter[] values) { }
        public override void AddRange(System.Array values) { }
        public Mono.Data.Sqlite.SqliteParameter AddWithValue(string parameterName, object value) { throw null; }
        public override void Clear() { }
        public override bool Contains(object value) { throw null; }
        public override bool Contains(string parameterName) { throw null; }
        public override void CopyTo(System.Array array, int index) { }
        public override System.Collections.IEnumerator GetEnumerator() { throw null; }
        protected override System.Data.Common.DbParameter GetParameter(int index) { throw null; }
        protected override System.Data.Common.DbParameter GetParameter(string parameterName) { throw null; }
        public override int IndexOf(object value) { throw null; }
        public override int IndexOf(string parameterName) { throw null; }
        public override void Insert(int index, object value) { }
        public override void Remove(object value) { }
        public override void RemoveAt(int index) { }
        public override void RemoveAt(string parameterName) { }
        protected override void SetParameter(int index, System.Data.Common.DbParameter value) { }
        protected override void SetParameter(string parameterName, System.Data.Common.DbParameter value) { }
    }
    public sealed partial class SqliteTransaction : System.Data.Common.DbTransaction
    {
        internal SqliteTransaction() { }
        public new Mono.Data.Sqlite.SqliteConnection Connection { get { throw null; } }
        protected override System.Data.Common.DbConnection DbConnection { get { throw null; } }
        public override System.Data.IsolationLevel IsolationLevel { get { throw null; } }
        public override void Commit() { }
        protected override void Dispose(bool disposing) { }
        public override void Rollback() { }
    }
    public delegate void SQLiteUpdateEventHandler(object sender, Mono.Data.Sqlite.UpdateEventArgs e);
    public enum SynchronizationModes
    {
        Full = 1,
        Normal = 0,
        Off = 2,
    }
    public enum TypeAffinity
    {
        Blob = 4,
        DateTime = 10,
        Double = 2,
        Int64 = 1,
        None = 11,
        Null = 5,
        Text = 3,
        Uninitialized = 0,
    }
    public partial class UpdateEventArgs : System.EventArgs
    {
        internal UpdateEventArgs() { }
        public readonly string Database;
        public readonly Mono.Data.Sqlite.UpdateEventType Event;
        public readonly long RowId;
        public readonly string Table;
    }
    public enum UpdateEventType
    {
        Delete = 9,
        Insert = 18,
        Update = 23,
    }
}
