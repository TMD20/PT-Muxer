// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

[assembly:System.Reflection.AssemblyVersionAttribute("1.0.0.0")]
[assembly:System.Diagnostics.DebuggableAttribute(System.Diagnostics.DebuggableAttribute.DebuggingModes.IgnoreSymbolStoreSequencePoints)]
[assembly:System.Reflection.AssemblyCompanyAttribute("")]
[assembly:System.Reflection.AssemblyConfigurationAttribute("")]
[assembly:System.Reflection.AssemblyCopyrightAttribute("")]
[assembly:System.Reflection.AssemblyDescriptionAttribute("")]
[assembly:System.Reflection.AssemblyProductAttribute("")]
[assembly:System.Reflection.AssemblyTitleAttribute("")]
[assembly:System.Reflection.AssemblyTrademarkAttribute("")]
[assembly:System.Runtime.CompilerServices.CompilationRelaxationsAttribute(8)]
[assembly:System.Runtime.CompilerServices.RuntimeCompatibilityAttribute(WrapNonExceptionThrows=true)]
[assembly:System.Security.Permissions.SecurityPermissionAttribute(System.Security.Permissions.SecurityAction.RequestMinimum, SkipVerification=true)]
namespace IBM.Data.DB2
{
    public partial class DB2ClientUtils
    {
        public DB2ClientUtils() { }
        public static void DB2CheckReturn(short sqlRet, short handleType, System.IntPtr handle, string message) { }
        public static void DB2CheckReturn(short sqlRet, short handleType, System.IntPtr handle, string message, IBM.Data.DB2.DB2Connection connection) { }
    }
    public partial class DB2Command : System.ComponentModel.Component, System.Data.IDbCommand, System.ICloneable, System.IDisposable
    {
        public DB2Command() { }
        public DB2Command(string commandStr) { }
        public DB2Command(string commandStr, IBM.Data.DB2.DB2Connection con) { }
        public DB2Command(string commandStr, IBM.Data.DB2.DB2Connection con, IBM.Data.DB2.DB2Transaction trans) { }
        public string CommandText { get { throw null; } set { } }
        public int CommandTimeout { get { throw null; } set { } }
        public System.Data.CommandType CommandType { get { throw null; } set { } }
        public IBM.Data.DB2.DB2Connection Connection { get { throw null; } set { } }
        public IBM.Data.DB2.DB2ParameterCollection Parameters { get { throw null; } }
        public bool SelfDescribe { get { throw null; } set { } }
        public System.IntPtr statementHandle { get { throw null; } }
        System.Data.IDbConnection System.Data.IDbCommand.Connection { get { throw null; } set { } }
        System.Data.IDataParameterCollection System.Data.IDbCommand.Parameters { get { throw null; } }
        System.Data.IDbTransaction System.Data.IDbCommand.Transaction { get { throw null; } set { } }
        public IBM.Data.DB2.DB2Transaction Transaction { get { throw null; } set { } }
        public System.Data.UpdateRowSource UpdatedRowSource { get { throw null; } set { } }
        public void Cancel() { }
        public System.Data.IDbDataParameter CreateParameter() { throw null; }
        public new void Dispose() { }
        protected override void Dispose(bool disposing) { }
        public int ExecuteNonQuery() { throw null; }
        public void ExecuteNonQueryInternal(System.Data.CommandBehavior behavior) { }
        public IBM.Data.DB2.DB2DataReader ExecuteReader() { throw null; }
        public IBM.Data.DB2.DB2DataReader ExecuteReader(System.Data.CommandBehavior behavior) { throw null; }
        public object ExecuteScalar() { throw null; }
        ~DB2Command() { }
        public void Prepare() { }
        System.Data.IDataReader System.Data.IDbCommand.ExecuteReader() { throw null; }
        System.Data.IDataReader System.Data.IDbCommand.ExecuteReader(System.Data.CommandBehavior behavior) { throw null; }
        object System.ICloneable.Clone() { throw null; }
    }
    public sealed partial class DB2CommandBuilder : System.ComponentModel.Component
    {
        public DB2CommandBuilder() { }
        public DB2CommandBuilder(IBM.Data.DB2.DB2DataAdapter adapter) { }
        public IBM.Data.DB2.DB2DataAdapter DataAdapter { get { throw null; } set { } }
        public string QuotePrefix { get { throw null; } set { } }
        public string QuoteSuffix { get { throw null; } set { } }
        public static void DeriveParameters(IBM.Data.DB2.DB2Command command) { }
        protected override void Dispose(bool disposing) { }
        public IBM.Data.DB2.DB2Command GetDeleteCommand() { throw null; }
        public IBM.Data.DB2.DB2Command GetInsertCommand() { throw null; }
        public IBM.Data.DB2.DB2Command GetUpdateCommand() { throw null; }
        public void RefreshSchema() { }
    }
    public partial class DB2Connection : System.ComponentModel.Component, System.Data.IDbConnection, System.ICloneable, System.IDisposable
    {
        public DB2Connection() { }
        public DB2Connection(string conString) { }
        public string ConnectionString { get { throw null; } set { } }
        public int ConnectionTimeout { get { throw null; } set { } }
        public string Database { get { throw null; } }
        public System.Data.ConnectionState State { get { throw null; } }
        public event IBM.Data.DB2.DB2InfoMessageEventHandler InfoMessage { add { } remove { } }
        public event System.Data.StateChangeEventHandler StateChange { add { } remove { } }
        public IBM.Data.DB2.DB2Transaction BeginTransaction() { throw null; }
        public IBM.Data.DB2.DB2Transaction BeginTransaction(System.Data.IsolationLevel isolationL) { throw null; }
        public void ChangeDatabase(string newDBName) { }
        public void Close() { }
        public IBM.Data.DB2.DB2Command CreateCommand() { throw null; }
        public new void Dispose() { }
        protected override void Dispose(bool disposing) { }
        ~DB2Connection() { }
        public void Open() { }
        public static void ReleaseObjectPool() { }
        System.Data.IDbTransaction System.Data.IDbConnection.BeginTransaction() { throw null; }
        System.Data.IDbTransaction System.Data.IDbConnection.BeginTransaction(System.Data.IsolationLevel isolationL) { throw null; }
        System.Data.IDbCommand System.Data.IDbConnection.CreateCommand() { throw null; }
        object System.ICloneable.Clone() { throw null; }
    }
    public sealed partial class DB2DataAdapter : System.Data.Common.DbDataAdapter, System.Data.IDataAdapter, System.Data.IDbDataAdapter
    {
        public DB2DataAdapter() { }
        public DB2DataAdapter(IBM.Data.DB2.DB2Command selectCommand) { }
        public DB2DataAdapter(string selectCommandText, IBM.Data.DB2.DB2Connection selectConnection) { }
        public DB2DataAdapter(string selectCommandText, string selectConnectionString) { }
        public new IBM.Data.DB2.DB2Command DeleteCommand { get { throw null; } set { } }
        public new IBM.Data.DB2.DB2Command InsertCommand { get { throw null; } set { } }
        public new IBM.Data.DB2.DB2Command SelectCommand { get { throw null; } set { } }
        System.Data.ITableMappingCollection System.Data.IDataAdapter.TableMappings { get { throw null; } }
        System.Data.IDbCommand System.Data.IDbDataAdapter.DeleteCommand { get { throw null; } set { } }
        System.Data.IDbCommand System.Data.IDbDataAdapter.InsertCommand { get { throw null; } set { } }
        System.Data.IDbCommand System.Data.IDbDataAdapter.SelectCommand { get { throw null; } set { } }
        System.Data.IDbCommand System.Data.IDbDataAdapter.UpdateCommand { get { throw null; } set { } }
        public new IBM.Data.DB2.DB2Command UpdateCommand { get { throw null; } set { } }
        public event IBM.Data.DB2.DB2RowUpdatedEventHandler RowUpdated { add { } remove { } }
        public event IBM.Data.DB2.DB2RowUpdatingEventHandler RowUpdating { add { } remove { } }
        protected override System.Data.Common.RowUpdatedEventArgs CreateRowUpdatedEvent(System.Data.DataRow dataRow, System.Data.IDbCommand command, System.Data.StatementType statementType, System.Data.Common.DataTableMapping tableMapping) { throw null; }
        protected override System.Data.Common.RowUpdatingEventArgs CreateRowUpdatingEvent(System.Data.DataRow dataRow, System.Data.IDbCommand command, System.Data.StatementType statementType, System.Data.Common.DataTableMapping tableMapping) { throw null; }
        protected override void Dispose(bool disposing) { }
        protected override void OnRowUpdated(System.Data.Common.RowUpdatedEventArgs value) { }
        protected override void OnRowUpdating(System.Data.Common.RowUpdatingEventArgs value) { }
    }
    public sealed partial class DB2DataReader : System.MarshalByRefObject, System.Data.IDataReader, System.Data.IDataRecord, System.IDisposable
    {
        internal DB2DataReader() { }
        public int Depth { get { throw null; } }
        public int FieldCount { get { throw null; } }
        public bool HasRows { get { throw null; } }
        public bool IsClosed { get { throw null; } }
        public object this[int col] { get { throw null; } }
        public object this[string name] { get { throw null; } }
        public int RecordsAffected { get { throw null; } }
        public void Close() { }
        public void Dispose() { }
        ~DB2DataReader() { }
        public bool GetBoolean(int col) { throw null; }
        public byte GetByte(int col) { throw null; }
        public long GetBytes(int col, long fieldOffset, byte[] buffer, int bufferOffset, int length) { throw null; }
        public char GetChar(int col) { throw null; }
        public long GetChars(int col, long fieldOffset, char[] buffer, int bufferOffset, int length) { throw null; }
        public System.Data.IDataReader GetData(int col) { throw null; }
        public string GetDataTypeName(int col) { throw null; }
        public System.DateTime GetDate(int col) { throw null; }
        public System.DateTime GetDateTime(int col) { throw null; }
        public decimal GetDecimal(int col) { throw null; }
        public double GetDouble(int col) { throw null; }
        public System.Type GetFieldType(int col) { throw null; }
        public float GetFloat(int col) { throw null; }
        public System.Guid GetGuid(int col) { throw null; }
        public short GetInt16(int col) { throw null; }
        public int GetInt32(int col) { throw null; }
        public long GetInt64(int col) { throw null; }
        public string GetName(int col) { throw null; }
        public int GetOrdinal(string name) { throw null; }
        public System.Data.DataTable GetSchemaTable() { throw null; }
        public string GetString(int col) { throw null; }
        public object GetStringInternal(int col) { throw null; }
        public System.TimeSpan GetTime(int col) { throw null; }
        public System.TimeSpan GetTimeSpan(int col) { throw null; }
        public object GetValue(int col) { throw null; }
        public int GetValues(object[] values) { throw null; }
        public bool IsDBNull(int col) { throw null; }
        public bool NextResult() { throw null; }
        public bool Read() { throw null; }
    }
    public sealed partial class DB2Error
    {
        internal DB2Error() { }
        public string Message { get { throw null; } }
        public int NativeError { get { throw null; } }
        public string Source { get { throw null; } }
        public string SQLState { get { throw null; } }
        public override string ToString() { throw null; }
    }
    [System.SerializableAttribute]
    public partial class DB2ErrorCollection : System.Collections.CollectionBase
    {
        public DB2ErrorCollection(short sqlHandleType, System.IntPtr sqlHandle) { }
        public IBM.Data.DB2.DB2Error this[int index] { get { throw null; } }
        public void CopyTo(IBM.Data.DB2.DB2Error[] array, int index) { }
        public new IBM.Data.DB2.DB2ErrorCollection.DB2ErrorEnumerator GetEnumerator() { throw null; }
        public partial class DB2ErrorEnumerator : System.Collections.IEnumerator
        {
            public DB2ErrorEnumerator(IBM.Data.DB2.DB2ErrorCollection mappings) { }
            public IBM.Data.DB2.DB2Error Current { get { throw null; } }
            object System.Collections.IEnumerator.Current { get { throw null; } }
            public bool MoveNext() { throw null; }
            public void Reset() { }
            bool System.Collections.IEnumerator.MoveNext() { throw null; }
            void System.Collections.IEnumerator.Reset() { }
        }
    }
    [System.SerializableAttribute]
    public sealed partial class DB2Exception : System.Exception
    {
        internal DB2Exception() { }
        public IBM.Data.DB2.DB2ErrorCollection Errors { get { throw null; } }
        public override string Message { get { throw null; } }
        public override void GetObjectData(System.Runtime.Serialization.SerializationInfo si, System.Runtime.Serialization.StreamingContext context) { }
    }
    public sealed partial class DB2InfoMessageEventArgs : System.EventArgs
    {
        public DB2InfoMessageEventArgs(IBM.Data.DB2.DB2ErrorCollection errors) { }
        public IBM.Data.DB2.DB2ErrorCollection Errors { get { throw null; } }
        public string Message { get { throw null; } }
    }
    public delegate void DB2InfoMessageEventHandler(object sender, IBM.Data.DB2.DB2InfoMessageEventArgs e);
    public sealed partial class DB2Parameter : System.MarshalByRefObject, System.Data.IDataParameter, System.Data.IDbDataParameter, System.ICloneable
    {
        public DB2Parameter() { }
        public DB2Parameter(string name, IBM.Data.DB2.DB2Type type) { }
        public DB2Parameter(string name, IBM.Data.DB2.DB2Type type, int size) { }
        public DB2Parameter(string parameterName, IBM.Data.DB2.DB2Type db2Type, int size, System.Data.ParameterDirection parameterDirection, bool isNullable, byte precision, byte scale, string srcColumn, System.Data.DataRowVersion srcVersion, object value) { }
        public DB2Parameter(string name, IBM.Data.DB2.DB2Type type, int size, string sourceColumn) { }
        public DB2Parameter(string parameterName, object value) { }
        public IBM.Data.DB2.DB2Type DB2Type { get { throw null; } set { } }
        public System.Data.DbType DbType { get { throw null; } set { } }
        public System.Data.ParameterDirection Direction { get { throw null; } set { } }
        public bool IsNullable { get { throw null; } set { } }
        public string ParameterName { get { throw null; } set { } }
        public byte Precision { get { throw null; } set { } }
        public byte Scale { get { throw null; } set { } }
        public int Size { get { throw null; } set { } }
        public string SourceColumn { get { throw null; } set { } }
        public System.Data.DataRowVersion SourceVersion { get { throw null; } set { } }
        public object Value { get { throw null; } set { } }
        object System.ICloneable.Clone() { throw null; }
    }
    public partial class DB2ParameterCollection : System.Collections.ArrayList, System.Collections.ICollection, System.Collections.IEnumerable, System.Collections.IList, System.Data.IDataParameterCollection
    {
        public DB2ParameterCollection() { }
        public new IBM.Data.DB2.DB2Parameter this[int index] { get { throw null; } set { } }
        public IBM.Data.DB2.DB2Parameter this[string index] { get { throw null; } set { } }
        object System.Data.IDataParameterCollection.this[string index] { get { throw null; } set { } }
        public IBM.Data.DB2.DB2Parameter Add(IBM.Data.DB2.DB2Parameter value) { throw null; }
        public override int Add(object obj) { throw null; }
        public IBM.Data.DB2.DB2Parameter Add(string paramName, IBM.Data.DB2.DB2Type type) { throw null; }
        public IBM.Data.DB2.DB2Parameter Add(string paramName, IBM.Data.DB2.DB2Type dbType, int size) { throw null; }
        public IBM.Data.DB2.DB2Parameter Add(string paramName, IBM.Data.DB2.DB2Type dbType, int size, string sourceColumn) { throw null; }
        public IBM.Data.DB2.DB2Parameter Add(string paramName, object value) { throw null; }
        public bool Contains(string paramName) { throw null; }
        public int IndexOf(string paramName) { throw null; }
        public void RemoveAt(string paramName) { }
    }
    public sealed partial class DB2RowUpdatedEventArgs : System.Data.Common.RowUpdatedEventArgs
    {
        public DB2RowUpdatedEventArgs(System.Data.DataRow row, System.Data.IDbCommand command, System.Data.StatementType statementType, System.Data.Common.DataTableMapping tableMapping) : base (default(System.Data.DataRow), default(System.Data.IDbCommand), default(System.Data.StatementType), default(System.Data.Common.DataTableMapping)) { }
        public new IBM.Data.DB2.DB2Command Command { get { throw null; } }
    }
    public delegate void DB2RowUpdatedEventHandler(object sender, IBM.Data.DB2.DB2RowUpdatedEventArgs e);
    public sealed partial class DB2RowUpdatingEventArgs : System.Data.Common.RowUpdatingEventArgs
    {
        public DB2RowUpdatingEventArgs(System.Data.DataRow row, System.Data.IDbCommand command, System.Data.StatementType statementType, System.Data.Common.DataTableMapping tableMapping) : base (default(System.Data.DataRow), default(System.Data.IDbCommand), default(System.Data.StatementType), default(System.Data.Common.DataTableMapping)) { }
        public new IBM.Data.DB2.DB2Command Command { get { throw null; } set { } }
    }
    public delegate void DB2RowUpdatingEventHandler(object sender, IBM.Data.DB2.DB2RowUpdatingEventArgs e);
    public sealed partial class DB2Transaction : System.MarshalByRefObject, System.Data.IDbTransaction, System.IDisposable
    {
        internal DB2Transaction() { }
        public System.Data.IDbConnection Connection { get { throw null; } }
        public System.Data.IsolationLevel IsolationLevel { get { throw null; } }
        public void Commit() { }
        public void Dispose() { }
        public void Rollback() { }
    }
    public enum DB2Type
    {
        BigInt = 3,
        Binary = 15,
        Blob = 22,
        Char = 12,
        Clob = 21,
        Datalink = 24,
        Date = 9,
        DbClob = 23,
        Decimal = 7,
        Double = 5,
        Float = 6,
        Graphic = 18,
        Integer = 2,
        Invalid = 0,
        LongVarBinary = 17,
        LongVarChar = 14,
        LongVarGraphic = 20,
        Numeric = 8,
        Real = 4,
        RowId = 25,
        SmallInt = 1,
        Time = 10,
        Timestamp = 11,
        VarBinary = 16,
        VarChar = 13,
        VarGraphic = 19,
        XmlReader = 26,
    }
    public partial class DB2TypeConverter
    {
        public DB2TypeConverter() { }
        public static System.Type GetManagedType(int sql_type) { throw null; }
    }
}
