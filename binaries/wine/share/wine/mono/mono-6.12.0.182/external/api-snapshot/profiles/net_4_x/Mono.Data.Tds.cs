// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

[assembly:System.Reflection.AssemblyVersionAttribute("4.0.0.0")]
[assembly:System.Diagnostics.DebuggableAttribute(System.Diagnostics.DebuggableAttribute.DebuggingModes.IgnoreSymbolStoreSequencePoints)]
[assembly:System.Runtime.CompilerServices.CompilationRelaxationsAttribute(8)]
[assembly:System.Runtime.CompilerServices.RuntimeCompatibilityAttribute(WrapNonExceptionThrows=true)]
namespace Mono.Data.Tds
{
    public delegate object FrameworkValueGetter(object rawValue, ref bool updated);
    public partial class TdsMetaParameter
    {
        public const int maxNVarCharCharacters = 1073741823;
        public const int maxVarCharCharacters = 2147483647;
        public TdsMetaParameter(string name, Mono.Data.Tds.FrameworkValueGetter valueGetter) { }
        public TdsMetaParameter(string name, int size, bool isNullable, byte precision, byte scale, Mono.Data.Tds.FrameworkValueGetter valueGetter) { }
        public TdsMetaParameter(string name, int size, bool isNullable, byte precision, byte scale, object value) { }
        public TdsMetaParameter(string name, object value) { }
        public TdsMetaParameter(string name, string typeName, object value) { }
        public Mono.Data.Tds.TdsParameterDirection Direction { get { throw null; } set { } }
        public bool IsAnyVarCharMax { get { throw null; } }
        public bool IsDateTimeType { get { throw null; } }
        public bool IsDecimalType { get { throw null; } }
        public bool IsMoneyType { get { throw null; } }
        public bool IsNonUnicodeText { get { throw null; } }
        public bool IsNullable { get { throw null; } set { } }
        public bool IsTextType { get { throw null; } }
        public bool IsVarCharMax { get { throw null; } }
        public bool IsVariableSizeType { get { throw null; } set { } }
        public bool IsVarNVarCharMax { get { throw null; } }
        public string ParameterName { get { throw null; } set { } }
        public byte Precision { get { throw null; } set { } }
        public object RawValue { get { throw null; } set { } }
        public byte Scale { get { throw null; } set { } }
        public int Size { get { throw null; } set { } }
        public string TypeName { get { throw null; } set { } }
        public object Value { get { throw null; } set { } }
        public void CalculateIsVariableType() { }
        public void Validate(int index) { }
    }
    public partial class TdsMetaParameterCollection : System.Collections.ICollection, System.Collections.IEnumerable
    {
        public TdsMetaParameterCollection() { }
        public int Count { get { throw null; } }
        public bool IsSynchronized { get { throw null; } }
        public Mono.Data.Tds.TdsMetaParameter this[int index] { get { throw null; } }
        public Mono.Data.Tds.TdsMetaParameter this[string name] { get { throw null; } }
        public object SyncRoot { get { throw null; } }
        public int Add(Mono.Data.Tds.TdsMetaParameter value) { throw null; }
        public void Clear() { }
        public bool Contains(Mono.Data.Tds.TdsMetaParameter value) { throw null; }
        public void CopyTo(System.Array array, int index) { }
        public int IndexOf(Mono.Data.Tds.TdsMetaParameter value) { throw null; }
        public int IndexOf(string name) { throw null; }
        public void Insert(int index, Mono.Data.Tds.TdsMetaParameter value) { }
        public void Remove(Mono.Data.Tds.TdsMetaParameter value) { }
        public void Remove(string name) { }
        public void RemoveAt(int index) { }
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { throw null; }
    }
    [System.SerializableAttribute]
    public enum TdsParameterDirection
    {
        Input = 0,
        InputOutput = 2,
        Output = 1,
        ReturnValue = 3,
    }
}
namespace Mono.Data.Tds.Protocol
{
    public abstract partial class Tds
    {
        protected internal Mono.Data.Tds.Protocol.TdsConnectionParameters connectionParms;
        protected Mono.Data.Tds.Protocol.TdsInternalErrorCollection messages;
        protected readonly byte[] NTLMSSP_ID;
        public Tds(string dataSource, int port, int packetSize, int timeout, Mono.Data.Tds.Protocol.TdsVersion tdsVersion) { }
        public Tds(string dataSource, int port, int packetSize, int timeout, int lifeTime, Mono.Data.Tds.Protocol.TdsVersion tdsVersion) { }
        protected string Charset { get { throw null; } }
        public byte[] Collation { get { throw null; } }
        protected System.Collections.ArrayList ColumnNames { get { throw null; } }
        public Mono.Data.Tds.Protocol.TdsDataColumnCollection Columns { get { throw null; } }
        public Mono.Data.Tds.Protocol.TdsDataRow ColumnValues { get { throw null; } }
        public string Database { get { throw null; } }
        public string DataSource { get { throw null; } }
        public bool DoneProc { get { throw null; } }
        public virtual bool IsConnected { get { throw null; } set { } }
        protected string Language { get { throw null; } }
        protected System.Globalization.CultureInfo Locale { get { throw null; } }
        public bool MoreResults { get { throw null; } set { } }
        public System.Collections.ArrayList OutputParameters { get { throw null; } set { } }
        public int PacketSize { get { throw null; } }
        protected Mono.Data.Tds.TdsMetaParameterCollection Parameters { get { throw null; } set { } }
        public bool Pooling { get { throw null; } set { } }
        public int RecordsAffected { get { throw null; } set { } }
        public bool SequentialAccess { get { throw null; } set { } }
        public Mono.Data.Tds.Protocol.TdsVersion ServerTdsVersion { get { throw null; } }
        public string ServerVersion { get { throw null; } }
        public Mono.Data.Tds.Protocol.TdsVersion TdsVersion { get { throw null; } }
        public event Mono.Data.Tds.Protocol.TdsInternalErrorMessageEventHandler TdsErrorMessage { add { } remove { } }
        public event Mono.Data.Tds.Protocol.TdsInternalInfoMessageEventHandler TdsInfoMessage { add { } remove { } }
        public virtual System.IAsyncResult BeginExecuteNonQuery(string sql, Mono.Data.Tds.TdsMetaParameterCollection parameters, System.AsyncCallback callback, object state) { throw null; }
        public virtual System.IAsyncResult BeginExecuteProcedure(string prolog, string epilog, string cmdText, bool IsNonQuery, Mono.Data.Tds.TdsMetaParameterCollection parameters, System.AsyncCallback callback, object state) { throw null; }
        public virtual System.IAsyncResult BeginExecuteQuery(string sql, Mono.Data.Tds.TdsMetaParameterCollection parameters, System.AsyncCallback callback, object state) { throw null; }
        protected System.IAsyncResult BeginExecuteQueryInternal(string sql, bool wantResults, System.AsyncCallback callback, object state) { throw null; }
        public void Cancel() { }
        public void CheckAndThrowException(System.IAsyncResult ar) { }
        [System.MonoTODOAttribute("Is cancel enough, or do we need to drop the connection?")]
        protected void CheckForData(int timeout) { }
        public abstract bool Connect(Mono.Data.Tds.Protocol.TdsConnectionParameters connectionParameters);
        protected Mono.Data.Tds.Protocol.TdsInternalErrorMessageEventArgs CreateTdsErrorMessageEvent(byte theClass, int lineNumber, string message, int number, string procedure, string server, string source, byte state) { throw null; }
        protected Mono.Data.Tds.Protocol.TdsInternalInfoMessageEventArgs CreateTdsInfoMessageEvent(Mono.Data.Tds.Protocol.TdsInternalErrorCollection errors) { throw null; }
        public static Mono.Data.Tds.Protocol.TdsTimeoutException CreateTimeoutException(string dataSource, string method) { throw null; }
        public virtual void Disconnect() { }
        public virtual void EndExecuteNonQuery(System.IAsyncResult ar) { }
        public virtual void EndExecuteProcedure(System.IAsyncResult ar) { }
        public virtual void EndExecuteQuery(System.IAsyncResult ar) { }
        protected void EndExecuteQueryInternal(System.IAsyncResult ar) { }
        public virtual void ExecPrepared(string sql, Mono.Data.Tds.TdsMetaParameterCollection parameters, int timeout, bool wantResults) { }
        public void ExecProc(string sql) { }
        public virtual void ExecProc(string sql, Mono.Data.Tds.TdsMetaParameterCollection parameters, int timeout, bool wantResults) { }
        protected virtual void ExecRPC(string rpcName, Mono.Data.Tds.TdsMetaParameterCollection parameters, int timeout, bool wantResults) { }
        public void Execute(string sql) { }
        public virtual void Execute(string sql, Mono.Data.Tds.TdsMetaParameterCollection parameters, int timeout, bool wantResults) { }
        protected void ExecuteQuery(string sql, int timeout, bool wantResults) { }
        protected object GetColumnValue(System.Nullable<Mono.Data.Tds.Protocol.TdsColumnType> colType, bool outParam) { throw null; }
        public static string GetPlainPassword(System.Security.SecureString secPass) { throw null; }
        public object GetSequentialColumnValue(int colIndex) { throw null; }
        public long GetSequentialColumnValue(int colIndex, long fieldIndex, byte[] buffer, int bufferIndex, int size) { throw null; }
        protected object GetStringValue(bool wideChars, int len, System.Text.Encoding enc) { throw null; }
        protected object GetStringValue(System.Nullable<Mono.Data.Tds.Protocol.TdsColumnType> colType, bool wideChars, bool outputParam, System.Text.Encoding encoder) { throw null; }
        protected int GetSubPacketLength() { throw null; }
        protected virtual void InitComm(int port, int timeout) { }
        protected internal void InitExec() { }
        protected virtual bool IsValidRowCount(byte status, byte op) { throw null; }
        protected bool IsWideType(Mono.Data.Tds.Protocol.TdsColumnType columnType) { throw null; }
        protected void LoadRow() { }
        public bool NextResult() { throw null; }
        public bool NextRow() { throw null; }
        protected void OnBeginExecuteQueryCallback(System.IAsyncResult ar) { }
        protected void OnTdsErrorMessage(Mono.Data.Tds.Protocol.TdsInternalErrorMessageEventArgs e) { }
        protected void OnTdsInfoMessage(Mono.Data.Tds.Protocol.TdsInternalInfoMessageEventArgs e) { }
        public virtual string Prepare(string sql, Mono.Data.Tds.TdsMetaParameterCollection parameters) { throw null; }
        protected internal int ProcessAuthentication() { throw null; }
        protected void ProcessColumnDetail() { }
        protected abstract void ProcessColumnInfo();
        protected void ProcessColumnNames() { }
        protected void ProcessDynamic() { }
        [System.MonoTODOAttribute("Make sure counting works right, especially with multiple resultsets.")]
        protected void ProcessEndToken(Mono.Data.Tds.Protocol.TdsPacketSubType type) { }
        protected void ProcessEnvironmentChange() { }
        protected void ProcessLoginAck() { }
        protected void ProcessMessage(Mono.Data.Tds.Protocol.TdsPacketSubType subType) { }
        protected virtual void ProcessOutputParam() { }
        protected virtual void ProcessReturnStatus() { }
        protected virtual Mono.Data.Tds.Protocol.TdsPacketSubType ProcessSubPacket() { throw null; }
        protected void ProcessTableName() { }
        public virtual bool Reset() { throw null; }
        protected void SetCharset(string charset) { }
        protected void SetCharset(System.Text.Encoding encoder) { }
        protected void SetLanguage(string language) { }
        public void SkipToEnd() { }
        public virtual void Unprepare(string statementId) { }
        public void WaitFor(System.IAsyncResult ar) { }
    }
    public sealed partial class Tds42 : Mono.Data.Tds.Protocol.Tds
    {
        public static readonly Mono.Data.Tds.Protocol.TdsVersion Version;
        public Tds42(string server, int port) : base (default(string), default(int), default(int), default(int), default(Mono.Data.Tds.Protocol.TdsVersion)) { }
        public Tds42(string server, int port, int packetSize, int timeout) : base (default(string), default(int), default(int), default(int), default(Mono.Data.Tds.Protocol.TdsVersion)) { }
        public override bool Connect(Mono.Data.Tds.Protocol.TdsConnectionParameters connectionParameters) { throw null; }
        protected override void ProcessColumnInfo() { }
    }
    [System.MonoTODOAttribute("FIXME: Can packetsize be anything other than 512?")]
    public sealed partial class Tds50 : Mono.Data.Tds.Protocol.Tds
    {
        public static readonly Mono.Data.Tds.Protocol.TdsVersion Version;
        public Tds50(string server, int port) : base (default(string), default(int), default(int), default(int), default(Mono.Data.Tds.Protocol.TdsVersion)) { }
        public Tds50(string server, int port, int packetSize, int timeout) : base (default(string), default(int), default(int), default(int), default(Mono.Data.Tds.Protocol.TdsVersion)) { }
        public string BuildExec(string sql) { throw null; }
        public override bool Connect(Mono.Data.Tds.Protocol.TdsConnectionParameters connectionParameters) { throw null; }
        public override void ExecPrepared(string id, Mono.Data.Tds.TdsMetaParameterCollection parameters, int timeout, bool wantResults) { }
        public override void ExecProc(string commandText, Mono.Data.Tds.TdsMetaParameterCollection parameters, int timeout, bool wantResults) { }
        public override void Execute(string sql, Mono.Data.Tds.TdsMetaParameterCollection parameters, int timeout, bool wantResults) { }
        protected override bool IsValidRowCount(byte status, byte op) { throw null; }
        public override string Prepare(string sql, Mono.Data.Tds.TdsMetaParameterCollection parameters) { throw null; }
        protected override void ProcessColumnInfo() { }
        public override void Unprepare(string statementId) { }
    }
    public partial class Tds70 : Mono.Data.Tds.Protocol.Tds
    {
        [System.ObsoleteAttribute("Use the constructor that receives a lifetime parameter")]
        public Tds70(string server, int port) : base (default(string), default(int), default(int), default(int), default(Mono.Data.Tds.Protocol.TdsVersion)) { }
        public Tds70(string server, int port, int lifetime) : base (default(string), default(int), default(int), default(int), default(Mono.Data.Tds.Protocol.TdsVersion)) { }
        [System.ObsoleteAttribute("Use the constructor that receives a lifetime parameter")]
        public Tds70(string server, int port, int packetSize, int timeout) : base (default(string), default(int), default(int), default(int), default(Mono.Data.Tds.Protocol.TdsVersion)) { }
        [System.ObsoleteAttribute("Use the constructor that receives a lifetime parameter")]
        public Tds70(string server, int port, int packetSize, int timeout, Mono.Data.Tds.Protocol.TdsVersion version) : base (default(string), default(int), default(int), default(int), default(Mono.Data.Tds.Protocol.TdsVersion)) { }
        public Tds70(string server, int port, int packetSize, int timeout, int lifeTime) : base (default(string), default(int), default(int), default(int), default(Mono.Data.Tds.Protocol.TdsVersion)) { }
        public Tds70(string server, int port, int packetSize, int timeout, int lifeTime, Mono.Data.Tds.Protocol.TdsVersion version) : base (default(string), default(int), default(int), default(int), default(Mono.Data.Tds.Protocol.TdsVersion)) { }
        protected virtual byte[] ClientVersion { get { throw null; } }
        protected virtual byte Precision { get { throw null; } }
        public override System.IAsyncResult BeginExecuteNonQuery(string cmdText, Mono.Data.Tds.TdsMetaParameterCollection parameters, System.AsyncCallback callback, object state) { throw null; }
        public override System.IAsyncResult BeginExecuteProcedure(string prolog, string epilog, string cmdText, bool IsNonQuery, Mono.Data.Tds.TdsMetaParameterCollection parameters, System.AsyncCallback callback, object state) { throw null; }
        public override System.IAsyncResult BeginExecuteQuery(string cmdText, Mono.Data.Tds.TdsMetaParameterCollection parameters, System.AsyncCallback callback, object state) { throw null; }
        protected string BuildExec(string sql) { throw null; }
        public override bool Connect(Mono.Data.Tds.Protocol.TdsConnectionParameters connectionParameters) { throw null; }
        public override void EndExecuteNonQuery(System.IAsyncResult ar) { }
        public override void EndExecuteProcedure(System.IAsyncResult ar) { }
        public override void EndExecuteQuery(System.IAsyncResult ar) { }
        public override void ExecPrepared(string commandText, Mono.Data.Tds.TdsMetaParameterCollection parameters, int timeout, bool wantResults) { }
        public override void ExecProc(string commandText, Mono.Data.Tds.TdsMetaParameterCollection parameters, int timeout, bool wantResults) { }
        protected void ExecRPC(Mono.Data.Tds.Protocol.TdsRpcProcId rpcId, string sql, Mono.Data.Tds.TdsMetaParameterCollection parameters, int timeout, bool wantResults) { }
        protected override void ExecRPC(string rpcName, Mono.Data.Tds.TdsMetaParameterCollection parameters, int timeout, bool wantResults) { }
        public override void Execute(string commandText, Mono.Data.Tds.TdsMetaParameterCollection parameters, int timeout, bool wantResults) { }
        protected override bool IsValidRowCount(byte status, byte op) { throw null; }
        public override string Prepare(string commandText, Mono.Data.Tds.TdsMetaParameterCollection parameters) { throw null; }
        protected override void ProcessColumnInfo() { }
        protected override void ProcessReturnStatus() { }
        public override bool Reset() { throw null; }
        public override void Unprepare(string statementId) { }
    }
    public partial class Tds80 : Mono.Data.Tds.Protocol.Tds70
    {
        public static readonly Mono.Data.Tds.Protocol.TdsVersion Version;
        [System.ObsoleteAttribute("Use the constructor that receives a lifetime parameter")]
        public Tds80(string server, int port) : base (default(string), default(int)) { }
        public Tds80(string server, int port, int lifetime) : base (default(string), default(int)) { }
        [System.ObsoleteAttribute("Use the constructor that receives a lifetime parameter")]
        public Tds80(string server, int port, int packetSize, int timeout) : base (default(string), default(int)) { }
        public Tds80(string server, int port, int packetSize, int timeout, int lifeTime) : base (default(string), default(int)) { }
        protected override byte[] ClientVersion { get { throw null; } }
        protected override byte Precision { get { throw null; } }
        public override bool Connect(Mono.Data.Tds.Protocol.TdsConnectionParameters connectionParameters) { throw null; }
        public override void ExecPrepared(string commandText, Mono.Data.Tds.TdsMetaParameterCollection parameters, int timeout, bool wantResults) { }
        public override void Execute(string commandText, Mono.Data.Tds.TdsMetaParameterCollection parameters, int timeout, bool wantResults) { }
        protected override void ProcessColumnInfo() { }
        protected override void ProcessOutputParam() { }
    }
    public partial class TdsBigDecimal
    {
        public TdsBigDecimal(byte precision, byte scale, bool isNegative, int[] data) { }
        public int[] Data { get { throw null; } }
        public bool IsNegative { get { throw null; } }
        public byte Precision { get { throw null; } }
        public byte Scale { get { throw null; } }
    }
    public partial class TdsBulkCopy
    {
        public TdsBulkCopy(Mono.Data.Tds.Protocol.Tds tds) { }
        public bool BulkCopyData(object o, bool isNewRow, int size, Mono.Data.Tds.TdsMetaParameter parameter) { throw null; }
        public bool BulkCopyEnd() { throw null; }
        public bool BulkCopyStart(Mono.Data.Tds.TdsMetaParameterCollection parameters) { throw null; }
        public bool SendColumnMetaData(string colMetaData) { throw null; }
    }
    public enum TdsColumnStatus
    {
        Hidden = 16,
        IsExpression = 4,
        IsKey = 8,
        Rename = 32,
    }
    public enum TdsColumnType
    {
        BigBinary = 173,
        BigChar = 175,
        BigInt = 127,
        BigNVarChar = 231,
        BigVarBinary = 165,
        BigVarChar = 167,
        Binary = 45,
        Bit = 50,
        BitN = 104,
        Char = 47,
        DateTime = 61,
        DateTime2 = 42,
        DateTime4 = 58,
        DateTimeN = 111,
        DateTimeOffset = 43,
        Decimal = 106,
        Float8 = 62,
        FloatN = 109,
        Image = 34,
        Int1 = 48,
        Int2 = 52,
        Int4 = 56,
        IntN = 38,
        Money = 60,
        Money4 = 112,
        MoneyN = 110,
        NChar = 239,
        NText = 99,
        Numeric = 108,
        NVarChar = 103,
        Real = 59,
        SmallMoney = 122,
        Text = 35,
        UniqueIdentifier = 36,
        VarBinary = 37,
        VarChar = 39,
        Variant = 98,
        Void = 31,
    }
    public partial class TdsConnectionInfo
    {
        public string DataSource;
        public int LifeTime;
        public int PacketSize;
        public int PoolMaxSize;
        public int PoolMinSize;
        public int Port;
        public int Timeout;
        [System.ObsoleteAttribute("Use the constructor that receives a lifetime parameter")]
        public TdsConnectionInfo(string dataSource, int port, int packetSize, int timeout, int minSize, int maxSize) { }
        public TdsConnectionInfo(string dataSource, int port, int packetSize, int timeout, int minSize, int maxSize, int lifeTime) { }
        public override string ToString() { throw null; }
    }
    public partial class TdsConnectionParameters
    {
        public string ApplicationName;
        public string AttachDBFileName;
        public string Charset;
        public string Database;
        public string DefaultDomain;
        public bool DomainLogin;
        public string Hostname;
        public string Language;
        public string LibraryName;
        public System.Security.SecureString Password;
        public bool PasswordSet;
        public string ProgName;
        public string User;
        public TdsConnectionParameters() { }
        public void Reset() { }
    }
    public partial class TdsConnectionPool
    {
        public TdsConnectionPool(Mono.Data.Tds.Protocol.TdsConnectionPoolManager manager, Mono.Data.Tds.Protocol.TdsConnectionInfo info) { }
        public bool Pooling { get { throw null; } set { } }
        public Mono.Data.Tds.Protocol.Tds GetConnection() { throw null; }
        public void ReleaseConnection(Mono.Data.Tds.Protocol.Tds connection) { }
        public void ResetConnectionPool() { }
    }
    public partial class TdsConnectionPoolManager
    {
        public TdsConnectionPoolManager(Mono.Data.Tds.Protocol.TdsVersion version) { }
        public virtual Mono.Data.Tds.Protocol.Tds CreateConnection(Mono.Data.Tds.Protocol.TdsConnectionInfo info) { throw null; }
        public System.Collections.IDictionary GetConnectionPool() { throw null; }
        public Mono.Data.Tds.Protocol.TdsConnectionPool GetConnectionPool(string connectionString) { throw null; }
        public Mono.Data.Tds.Protocol.TdsConnectionPool GetConnectionPool(string connectionString, Mono.Data.Tds.Protocol.TdsConnectionInfo info) { throw null; }
    }
    public partial class TdsDataColumn
    {
        public TdsDataColumn() { }
        public System.Nullable<bool> AllowDBNull { get { throw null; } set { } }
        public string BaseCatalogName { get { throw null; } set { } }
        public string BaseColumnName { get { throw null; } set { } }
        public string BaseSchemaName { get { throw null; } set { } }
        public string BaseServerName { get { throw null; } set { } }
        public string BaseTableName { get { throw null; } set { } }
        public string ColumnName { get { throw null; } set { } }
        public System.Nullable<int> ColumnOrdinal { get { throw null; } set { } }
        public System.Nullable<int> ColumnSize { get { throw null; } set { } }
        public System.Nullable<Mono.Data.Tds.Protocol.TdsColumnType> ColumnType { get { throw null; } set { } }
        public string DataTypeName { get { throw null; } set { } }
        public System.Nullable<bool> IsAliased { get { throw null; } set { } }
        public System.Nullable<bool> IsAutoIncrement { get { throw null; } set { } }
        public System.Nullable<bool> IsExpression { get { throw null; } set { } }
        public System.Nullable<bool> IsHidden { get { throw null; } set { } }
        public System.Nullable<bool> IsIdentity { get { throw null; } set { } }
        public System.Nullable<bool> IsKey { get { throw null; } set { } }
        public System.Nullable<bool> IsReadOnly { get { throw null; } set { } }
        public System.Nullable<bool> IsRowVersion { get { throw null; } set { } }
        public System.Nullable<bool> IsUnique { get { throw null; } set { } }
        public object this[string key] { get { throw null; } set { } }
        public System.Nullable<int> LCID { get { throw null; } set { } }
        public System.Nullable<short> NumericPrecision { get { throw null; } set { } }
        public System.Nullable<short> NumericScale { get { throw null; } set { } }
        public System.Nullable<int> SortOrder { get { throw null; } set { } }
    }
    public partial class TdsDataColumnCollection : System.Collections.IEnumerable
    {
        public TdsDataColumnCollection() { }
        public int Count { get { throw null; } }
        public Mono.Data.Tds.Protocol.TdsDataColumn this[int index] { get { throw null; } set { } }
        public int Add(Mono.Data.Tds.Protocol.TdsDataColumn schema) { throw null; }
        public void Add(Mono.Data.Tds.Protocol.TdsDataColumnCollection columns) { }
        public void Clear() { }
        public System.Collections.IEnumerator GetEnumerator() { throw null; }
    }
    public partial class TdsDataRow : System.Collections.ICollection, System.Collections.IEnumerable, System.Collections.IList
    {
        public TdsDataRow() { }
        public int BigDecimalIndex { get { throw null; } set { } }
        public int Count { get { throw null; } }
        public bool IsFixedSize { get { throw null; } }
        public bool IsReadOnly { get { throw null; } }
        public bool IsSynchronized { get { throw null; } }
        public object this[int index] { get { throw null; } set { } }
        public object SyncRoot { get { throw null; } }
        public int Add(object value) { throw null; }
        public void Clear() { }
        public bool Contains(object value) { throw null; }
        public void CopyTo(System.Array array, int index) { }
        public void CopyTo(int index, System.Array array, int arrayIndex, int count) { }
        public System.Collections.IEnumerator GetEnumerator() { throw null; }
        public int IndexOf(object value) { throw null; }
        public void Insert(int index, object value) { }
        public void Remove(object value) { }
        public void RemoveAt(int index) { }
    }
    public enum TdsEnvPacketSubType
    {
        BlockSize = 4,
        CharSet = 3,
        CollationInfo = 7,
        Database = 1,
        Locale = 5,
    }
    public sealed partial class TdsInternalError
    {
        public TdsInternalError(byte theClass, int lineNumber, string message, int number, string procedure, string server, string source, byte state) { }
        public byte Class { get { throw null; } set { } }
        public int LineNumber { get { throw null; } set { } }
        public string Message { get { throw null; } set { } }
        public int Number { get { throw null; } set { } }
        public string Procedure { get { throw null; } set { } }
        public string Server { get { throw null; } set { } }
        public string Source { get { throw null; } set { } }
        public byte State { get { throw null; } set { } }
    }
    public sealed partial class TdsInternalErrorCollection : System.Collections.IEnumerable
    {
        public TdsInternalErrorCollection() { }
        public int Count { get { throw null; } }
        public Mono.Data.Tds.Protocol.TdsInternalError this[int index] { get { throw null; } set { } }
        public int Add(Mono.Data.Tds.Protocol.TdsInternalError error) { throw null; }
        public void Clear() { }
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { throw null; }
    }
    public sealed partial class TdsInternalErrorMessageEventArgs : Mono.Data.Tds.Protocol.TdsInternalInfoMessageEventArgs
    {
        public TdsInternalErrorMessageEventArgs(Mono.Data.Tds.Protocol.TdsInternalError error) : base (default(Mono.Data.Tds.Protocol.TdsInternalErrorCollection)) { }
    }
    public delegate void TdsInternalErrorMessageEventHandler(object sender, Mono.Data.Tds.Protocol.TdsInternalErrorMessageEventArgs e);
    public partial class TdsInternalException : System.SystemException
    {
        internal TdsInternalException() { }
        public byte Class { get { throw null; } }
        public int LineNumber { get { throw null; } }
        public override string Message { get { throw null; } }
        public int Number { get { throw null; } }
        public string Procedure { get { throw null; } }
        public string Server { get { throw null; } }
        public override string Source { get { throw null; } }
        public byte State { get { throw null; } }
        [System.MonoTODOAttribute]
        public override void GetObjectData(System.Runtime.Serialization.SerializationInfo si, System.Runtime.Serialization.StreamingContext context) { }
    }
    public partial class TdsInternalInfoMessageEventArgs : System.EventArgs
    {
        public TdsInternalInfoMessageEventArgs(Mono.Data.Tds.Protocol.TdsInternalError error) { }
        public TdsInternalInfoMessageEventArgs(Mono.Data.Tds.Protocol.TdsInternalErrorCollection errors) { }
        public byte Class { get { throw null; } }
        public Mono.Data.Tds.Protocol.TdsInternalErrorCollection Errors { get { throw null; } }
        public int LineNumber { get { throw null; } }
        public string Message { get { throw null; } }
        public int Number { get { throw null; } }
        public string Procedure { get { throw null; } }
        public string Server { get { throw null; } }
        public string Source { get { throw null; } }
        public byte State { get { throw null; } }
        public int Add(byte theClass, int lineNumber, string message, int number, string procedure, string server, string source, byte state) { throw null; }
    }
    public delegate void TdsInternalInfoMessageEventHandler(object sender, Mono.Data.Tds.Protocol.TdsInternalInfoMessageEventArgs e);
    public enum TdsPacketSubType
    {
        AltFormat = 168,
        AltName = 167,
        Authentication = 237,
        Capability = 226,
        ColumnDetail = 165,
        ColumnInfo = 161,
        ColumnMetadata = 129,
        ColumnName = 160,
        ColumnOrder = 169,
        Control = 174,
        Done = 253,
        DoneInProc = 255,
        DoneProc = 254,
        Dynamic = 231,
        Dynamic2 = 163,
        EED = 229,
        EnvironmentChange = 227,
        Error = 170,
        Info = 171,
        LoginAck = 173,
        Param = 172,
        Parameters = 215,
        ParamFormat = 236,
        ProcId = 124,
        ReturnStatus = 121,
        Row = 209,
        RowFormat = 238,
        TableName = 164,
    }
    public enum TdsPacketType
    {
        Bulk = 7,
        Cancel = 6,
        DBRPC = 230,
        Logoff = 113,
        Logon = 2,
        Logon70 = 16,
        None = 0,
        Normal = 15,
        Proc = 3,
        Query = 1,
        Reply = 4,
        RPC = 3,
        SspAuth = 17,
    }
    public enum TdsRpcProcId
    {
        Cursor = 1,
        CursorClose = 9,
        CursorExecute = 4,
        CursorFetch = 7,
        CursorOpen = 2,
        CursorOption = 8,
        CursorPrepare = 3,
        CursorPrepExec = 5,
        CursorUnprepare = 6,
        Execute = 12,
        ExecuteSql = 10,
        Prepare = 11,
        PrepExec = 13,
        PrepExecRpc = 14,
        Unprepare = 15,
    }
    public partial class TdsTimeoutException : Mono.Data.Tds.Protocol.TdsInternalException
    {
        internal TdsTimeoutException() { }
    }
    public enum TdsVersion
    {
        tds100 = 100,
        tds42 = 42,
        tds50 = 50,
        tds70 = 70,
        tds80 = 80,
        tds81 = 81,
        tds90 = 90,
    }
}
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
