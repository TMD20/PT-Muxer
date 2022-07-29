// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

[assembly:System.Reflection.AssemblyVersionAttribute("4.0.0.0")]
[assembly:System.CLSCompliantAttribute(true)]
[assembly:System.Diagnostics.DebuggableAttribute((System.Diagnostics.DebuggableAttribute.DebuggingModes)(2))]
[assembly:System.Reflection.AssemblyCompanyAttribute("Mono development team")]
[assembly:System.Reflection.AssemblyCopyrightAttribute("(c) Various Mono authors")]
[assembly:System.Reflection.AssemblyDefaultAliasAttribute("System.Data.Linq.dll")]
[assembly:System.Reflection.AssemblyDescriptionAttribute("System.Data.Linq.dll")]
[assembly:System.Reflection.AssemblyFileVersionAttribute("4.6.57.0")]
[assembly:System.Reflection.AssemblyInformationalVersionAttribute("4.6.57.0")]
[assembly:System.Reflection.AssemblyProductAttribute("Mono Common Language Infrastructure")]
[assembly:System.Reflection.AssemblyTitleAttribute("System.Data.Linq.dll")]
[assembly:System.Resources.NeutralResourcesLanguageAttribute("en-US")]
[assembly:System.Resources.SatelliteContractVersionAttribute("4.0.0.0")]
[assembly:System.Runtime.CompilerServices.CompilationRelaxationsAttribute(8)]
[assembly:System.Runtime.CompilerServices.InternalsVisibleToAttribute("sqlmetal, PublicKey=0024000004800000940000000602000000240000525341310004000001000100c5753d8c47f40083f549016a5711238ac8ec297605abccd3dc4b6d0f280b4764eb2cc58ec4e37831edad7e7a07b8fe4a9cbb059374c0cc047aa28839fed7176761813caf6a2ffa0bff9afb50ead56dd3f56186a663962a12b830c2a70eb70ec77823eb5750e5bdef9e01d097c30b5c5463c3d07d3472b58e4c02f2792309259f")]
[assembly:System.Runtime.CompilerServices.InternalsVisibleToAttribute("sqlmetal_test_net_2_0, PublicKey=0024000004800000940000000602000000240000525341310004000001000100c5753d8c47f40083f549016a5711238ac8ec297605abccd3dc4b6d0f280b4764eb2cc58ec4e37831edad7e7a07b8fe4a9cbb059374c0cc047aa28839fed7176761813caf6a2ffa0bff9afb50ead56dd3f56186a663962a12b830c2a70eb70ec77823eb5750e5bdef9e01d097c30b5c5463c3d07d3472b58e4c02f2792309259f")]
[assembly:System.Runtime.CompilerServices.InternalsVisibleToAttribute("sqlmetal_test_net_4_0, PublicKey=0024000004800000940000000602000000240000525341310004000001000100c5753d8c47f40083f549016a5711238ac8ec297605abccd3dc4b6d0f280b4764eb2cc58ec4e37831edad7e7a07b8fe4a9cbb059374c0cc047aa28839fed7176761813caf6a2ffa0bff9afb50ead56dd3f56186a663962a12b830c2a70eb70ec77823eb5750e5bdef9e01d097c30b5c5463c3d07d3472b58e4c02f2792309259f")]
[assembly:System.Runtime.CompilerServices.ReferenceAssemblyAttribute]
[assembly:System.Runtime.CompilerServices.RuntimeCompatibilityAttribute(WrapNonExceptionThrows=true)]
[assembly:System.Runtime.InteropServices.ComVisibleAttribute(false)]
[assembly:System.Security.AllowPartiallyTrustedCallersAttribute]
namespace DbLinq.Util
{
    public abstract partial class BaseLock : System.IDisposable
    {
        protected System.Threading.ReaderWriterLockSlim _Locks;
        public BaseLock(System.Threading.ReaderWriterLockSlim locks) { }
        public abstract void Dispose();
    }
    public static partial class Locks
    {
        public static System.Threading.ReaderWriterLockSlim GetLockInstance() { throw null; }
        public static System.Threading.ReaderWriterLockSlim GetLockInstance(System.Threading.LockRecursionPolicy recursionPolicy) { throw null; }
        public static void GetReadLock(System.Threading.ReaderWriterLockSlim locks) { }
        public static void GetReadOnlyLock(System.Threading.ReaderWriterLockSlim locks) { }
        public static void GetWriteLock(System.Threading.ReaderWriterLockSlim locks) { }
        public static void ReleaseLock(System.Threading.ReaderWriterLockSlim locks) { }
        public static void ReleaseReadLock(System.Threading.ReaderWriterLockSlim locks) { }
        public static void ReleaseReadOnlyLock(System.Threading.ReaderWriterLockSlim locks) { }
        public static void ReleaseWriteLock(System.Threading.ReaderWriterLockSlim locks) { }
    }
    public partial class ReadLock : DbLinq.Util.BaseLock
    {
        public ReadLock(System.Threading.ReaderWriterLockSlim locks) : base (default(System.Threading.ReaderWriterLockSlim)) { }
        public override void Dispose() { }
    }
    public partial class ReadOnlyLock : DbLinq.Util.BaseLock
    {
        public ReadOnlyLock(System.Threading.ReaderWriterLockSlim locks) : base (default(System.Threading.ReaderWriterLockSlim)) { }
        public override void Dispose() { }
    }
    public partial class WriteLock : DbLinq.Util.BaseLock
    {
        public WriteLock(System.Threading.ReaderWriterLockSlim locks) : base (default(System.Threading.ReaderWriterLockSlim)) { }
        public override void Dispose() { }
    }
}
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
namespace System.Data.Linq
{
    [System.Runtime.Serialization.DataContractAttribute]
    [System.SerializableAttribute]
    public sealed partial class Binary : System.IEquatable<System.Data.Linq.Binary>
    {
        public Binary(byte[] value) { }
        public int Length { get { throw null; } }
        public bool Equals(System.Data.Linq.Binary other) { throw null; }
        public override bool Equals(object obj) { throw null; }
        public override int GetHashCode() { throw null; }
        public static bool operator ==(System.Data.Linq.Binary binary1, System.Data.Linq.Binary binary2) { throw null; }
        public static implicit operator System.Data.Linq.Binary (byte[] value) { throw null; }
        public static bool operator !=(System.Data.Linq.Binary binary1, System.Data.Linq.Binary binary2) { throw null; }
        public byte[] ToArray() { throw null; }
        public override string ToString() { throw null; }
    }
    public enum ChangeAction
    {
        Delete = 1,
        Insert = 2,
        None = 0,
        Update = 3,
    }
    public sealed partial class ChangeConflictCollection : System.Collections.Generic.ICollection<System.Data.Linq.ObjectChangeConflict>, System.Collections.Generic.IEnumerable<System.Data.Linq.ObjectChangeConflict>, System.Collections.ICollection, System.Collections.IEnumerable
    {
        internal ChangeConflictCollection() { }
        [System.MonoTODOAttribute]
        public int Count { get { throw null; } }
        [System.MonoTODOAttribute]
        public System.Data.Linq.ObjectChangeConflict this[int index] { get { throw null; } }
        [System.MonoTODOAttribute]
        bool System.Collections.Generic.ICollection<System.Data.Linq.ObjectChangeConflict>.IsReadOnly { get { throw null; } }
        [System.MonoTODOAttribute]
        bool System.Collections.ICollection.IsSynchronized { get { throw null; } }
        [System.MonoTODOAttribute]
        object System.Collections.ICollection.SyncRoot { get { throw null; } }
        [System.MonoTODOAttribute]
        public void Clear() { }
        [System.MonoTODOAttribute]
        public bool Contains(System.Data.Linq.ObjectChangeConflict item) { throw null; }
        [System.MonoTODOAttribute]
        public void CopyTo(System.Data.Linq.ObjectChangeConflict[] array, int arrayIndex) { }
        [System.MonoTODOAttribute]
        public System.Collections.Generic.IEnumerator<System.Data.Linq.ObjectChangeConflict> GetEnumerator() { throw null; }
        [System.MonoTODOAttribute]
        public bool Remove(System.Data.Linq.ObjectChangeConflict item) { throw null; }
        [System.MonoTODOAttribute]
        public void ResolveAll(System.Data.Linq.RefreshMode mode) { }
        [System.MonoTODOAttribute]
        public void ResolveAll(System.Data.Linq.RefreshMode mode, bool autoResolveDeletes) { }
        [System.MonoTODOAttribute]
        void System.Collections.Generic.ICollection<System.Data.Linq.ObjectChangeConflict>.Add(System.Data.Linq.ObjectChangeConflict item) { }
        [System.MonoTODOAttribute]
        void System.Collections.ICollection.CopyTo(System.Array array, int index) { }
        [System.MonoTODOAttribute]
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { throw null; }
    }
    public partial class ChangeConflictException : System.Exception
    {
        public ChangeConflictException() { }
        public ChangeConflictException(string message) { }
        public ChangeConflictException(string message, System.Exception innerException) { }
    }
    public sealed partial class ChangeSet
    {
        internal ChangeSet() { }
        public System.Collections.Generic.IList<object> Deletes { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        public System.Collections.Generic.IList<object> Inserts { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        public System.Collections.Generic.IList<object> Updates { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        public override string ToString() { throw null; }
    }
    public sealed partial class CompiledQuery
    {
        internal CompiledQuery() { }
        [System.MonoTODOAttribute]
        public System.Linq.Expressions.LambdaExpression Expression { get { throw null; } }
        public static System.Func<TArg0, TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TResult> Compile<TArg0, TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TResult>(System.Linq.Expressions.Expression<System.Func<TArg0, TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TResult>> query) where TArg0 : System.Data.Linq.DataContext { throw null; }
        public static System.Func<TArg0, TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TResult> Compile<TArg0, TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TResult>(System.Linq.Expressions.Expression<System.Func<TArg0, TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TResult>> query) where TArg0 : System.Data.Linq.DataContext { throw null; }
        public static System.Func<TArg0, TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TResult> Compile<TArg0, TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TResult>(System.Linq.Expressions.Expression<System.Func<TArg0, TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TResult>> query) where TArg0 : System.Data.Linq.DataContext { throw null; }
        public static System.Func<TArg0, TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TResult> Compile<TArg0, TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TResult>(System.Linq.Expressions.Expression<System.Func<TArg0, TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TResult>> query) where TArg0 : System.Data.Linq.DataContext { throw null; }
        public static System.Func<TArg0, TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TResult> Compile<TArg0, TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TResult>(System.Linq.Expressions.Expression<System.Func<TArg0, TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TResult>> query) where TArg0 : System.Data.Linq.DataContext { throw null; }
        public static System.Func<TArg0, TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TResult> Compile<TArg0, TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TResult>(System.Linq.Expressions.Expression<System.Func<TArg0, TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TResult>> query) where TArg0 : System.Data.Linq.DataContext { throw null; }
        public static System.Func<TArg0, TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TResult> Compile<TArg0, TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TResult>(System.Linq.Expressions.Expression<System.Func<TArg0, TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TResult>> query) where TArg0 : System.Data.Linq.DataContext { throw null; }
        public static System.Func<TArg0, TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TResult> Compile<TArg0, TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TResult>(System.Linq.Expressions.Expression<System.Func<TArg0, TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TResult>> query) where TArg0 : System.Data.Linq.DataContext { throw null; }
        [System.MonoTODOAttribute]
        public static System.Func<TArg0, TResult> Compile<TArg0, TResult>(System.Linq.Expressions.Expression<System.Func<TArg0, TResult>> query) where TArg0 : System.Data.Linq.DataContext { throw null; }
        [System.MonoTODOAttribute]
        public static System.Func<TArg0, TArg1, TResult> Compile<TArg0, TArg1, TResult>(System.Linq.Expressions.Expression<System.Func<TArg0, TArg1, TResult>> query) where TArg0 : System.Data.Linq.DataContext { throw null; }
        [System.MonoTODOAttribute]
        public static System.Func<TArg0, TArg1, TArg2, TResult> Compile<TArg0, TArg1, TArg2, TResult>(System.Linq.Expressions.Expression<System.Func<TArg0, TArg1, TArg2, TResult>> query) where TArg0 : System.Data.Linq.DataContext { throw null; }
        [System.MonoTODOAttribute]
        public static System.Func<TArg0, TArg1, TArg2, TArg3, TResult> Compile<TArg0, TArg1, TArg2, TArg3, TResult>(System.Linq.Expressions.Expression<System.Func<TArg0, TArg1, TArg2, TArg3, TResult>> query) where TArg0 : System.Data.Linq.DataContext { throw null; }
        public static System.Func<TArg0, TArg1, TArg2, TArg3, TArg4, TResult> Compile<TArg0, TArg1, TArg2, TArg3, TArg4, TResult>(System.Linq.Expressions.Expression<System.Func<TArg0, TArg1, TArg2, TArg3, TArg4, TResult>> query) where TArg0 : System.Data.Linq.DataContext { throw null; }
        public static System.Func<TArg0, TArg1, TArg2, TArg3, TArg4, TArg5, TResult> Compile<TArg0, TArg1, TArg2, TArg3, TArg4, TArg5, TResult>(System.Linq.Expressions.Expression<System.Func<TArg0, TArg1, TArg2, TArg3, TArg4, TArg5, TResult>> query) where TArg0 : System.Data.Linq.DataContext { throw null; }
        public static System.Func<TArg0, TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TResult> Compile<TArg0, TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TResult>(System.Linq.Expressions.Expression<System.Func<TArg0, TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TResult>> query) where TArg0 : System.Data.Linq.DataContext { throw null; }
        public static System.Func<TArg0, TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TResult> Compile<TArg0, TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TResult>(System.Linq.Expressions.Expression<System.Func<TArg0, TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TResult>> query) where TArg0 : System.Data.Linq.DataContext { throw null; }
    }
    public enum ConflictMode
    {
        ContinueOnConflict = 1,
        FailOnFirstConflict = 0,
    }
    public partial class DataContext : System.IDisposable
    {
        public DataContext(System.Data.IDbConnection connection) { }
        public DataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mapping) { }
        public DataContext(string fileOrServerOrConnection) { }
        public DataContext(string fileOrServerOrConnection, System.Data.Linq.Mapping.MappingSource mapping) { }
        public System.Data.Linq.ChangeConflictCollection ChangeConflicts { get { throw null; } }
        public int CommandTimeout { get { throw null; } set { } }
        public System.Data.Common.DbConnection Connection { get { throw null; } }
        public bool DeferredLoadingEnabled { get { throw null; } set { } }
        public System.Data.Linq.DataLoadOptions LoadOptions { get { throw null; } set { } }
        public System.IO.TextWriter Log { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public System.Data.Linq.Mapping.MetaModel Mapping { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        public bool ObjectTrackingEnabled { get { throw null; } set { } }
        public System.Data.Common.DbTransaction Transaction { get { throw null; } set { } }
        public void CreateDatabase() { }
        protected internal System.Linq.IQueryable<TResult> CreateMethodCallQuery<TResult>(object instance, System.Reflection.MethodInfo methodInfo, params object[] parameters) { throw null; }
        public bool DatabaseExists() { throw null; }
        public void DeleteDatabase() { }
        public void Dispose() { }
        protected virtual void Dispose(bool disposing) { }
        public int ExecuteCommand(string command, params object[] parameters) { throw null; }
        protected internal void ExecuteDynamicDelete(object entity) { }
        protected internal void ExecuteDynamicInsert(object entity) { }
        protected internal void ExecuteDynamicUpdate(object entity) { }
        protected internal System.Data.Linq.IExecuteResult ExecuteMethodCall(object instance, System.Reflection.MethodInfo methodInfo, params object[] parameters) { throw null; }
        public System.Collections.IEnumerable ExecuteQuery(System.Type elementType, string query, params object[] parameters) { throw null; }
        public System.Collections.Generic.IEnumerable<TResult> ExecuteQuery<TResult>(string query, params object[] parameters) { throw null; }
        public System.Data.Linq.ChangeSet GetChangeSet() { throw null; }
        public System.Data.Common.DbCommand GetCommand(System.Linq.IQueryable query) { throw null; }
        public System.Data.Linq.ITable GetTable(System.Type type) { throw null; }
        public System.Data.Linq.Table<TEntity> GetTable<TEntity>() where TEntity : class { throw null; }
        public void Refresh(System.Data.Linq.RefreshMode mode, System.Collections.IEnumerable entities) { }
        public void Refresh(System.Data.Linq.RefreshMode mode, object entity) { }
        public void Refresh(System.Data.Linq.RefreshMode mode, params object[] entities) { }
        public void SubmitChanges() { }
        public virtual void SubmitChanges(System.Data.Linq.ConflictMode failureMode) { }
        public System.Data.Linq.IMultipleResults Translate(System.Data.Common.DbDataReader reader) { throw null; }
        public System.Collections.IEnumerable Translate(System.Type elementType, System.Data.Common.DbDataReader reader) { throw null; }
        public System.Collections.Generic.IEnumerable<TResult> Translate<TResult>(System.Data.Common.DbDataReader reader) { throw null; }
    }
    public sealed partial class DataLoadOptions
    {
        public DataLoadOptions() { }
        public void AssociateWith(System.Linq.Expressions.LambdaExpression expression) { }
        public void AssociateWith<T>(System.Linq.Expressions.Expression<System.Func<T, object>> expression) { }
        public void LoadWith(System.Linq.Expressions.LambdaExpression expression) { }
        public void LoadWith<T>(System.Linq.Expressions.Expression<System.Func<T, object>> expression) { }
    }
    public static partial class DBConvert
    {
        [System.MonoTODOAttribute]
        public static object ChangeType(object value, System.Type type) { throw null; }
        [System.MonoTODOAttribute]
        public static T ChangeType<T>(object value) { throw null; }
    }
    public partial class DuplicateKeyException : System.InvalidOperationException
    {
        public DuplicateKeyException(object duplicate) { }
        public DuplicateKeyException(object duplicate, string message) { }
        public DuplicateKeyException(object duplicate, string message, System.Exception innerException) { }
        public object Object { get { throw null; } }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public partial struct EntityRef<TEntity> where TEntity : class
    {
        private TEntity entity;
        private object _dummy;
        public EntityRef(System.Collections.Generic.IEnumerable<TEntity> source) { throw null;}
        public EntityRef(System.Data.Linq.EntityRef<TEntity> entityRef) { throw null;}
        public EntityRef(TEntity entity) { throw null;}
        public TEntity Entity { get { throw null; } set { } }
        public bool HasLoadedOrAssignedValue { get { throw null; } }
    }
    public sealed partial class EntitySet<TEntity> : System.Collections.Generic.ICollection<TEntity>, System.Collections.Generic.IEnumerable<TEntity>, System.Collections.Generic.IList<TEntity>, System.Collections.ICollection, System.Collections.IEnumerable, System.Collections.IList, System.ComponentModel.IListSource where TEntity : class
    {
        public EntitySet() { }
        public EntitySet(System.Action<TEntity> onAdd, System.Action<TEntity> onRemove) { }
        public int Count { get { throw null; } }
        public bool HasLoadedOrAssignedValues { get { throw null; } }
        public bool IsDeferred { get { throw null; } }
        public TEntity this[int index] { get { throw null; } set { } }
        bool System.Collections.Generic.ICollection<TEntity>.IsReadOnly { get { throw null; } }
        bool System.Collections.ICollection.IsSynchronized { get { throw null; } }
        object System.Collections.ICollection.SyncRoot { get { throw null; } }
        bool System.Collections.IList.IsFixedSize { get { throw null; } }
        bool System.Collections.IList.IsReadOnly { get { throw null; } }
        object System.Collections.IList.this[int index] { get { throw null; } set { } }
        bool System.ComponentModel.IListSource.ContainsListCollection { get { throw null; } }
        public event System.ComponentModel.ListChangedEventHandler ListChanged { add { } remove { } }
        public void Add(TEntity entity) { }
        public void AddRange(System.Collections.Generic.IEnumerable<TEntity> collection) { }
        public void Assign(System.Collections.Generic.IEnumerable<TEntity> entitySource) { }
        public void Clear() { }
        public bool Contains(TEntity entity) { throw null; }
        public void CopyTo(TEntity[] array, int arrayIndex) { }
        public System.Collections.Generic.IEnumerator<TEntity> GetEnumerator() { throw null; }
        public System.ComponentModel.IBindingList GetNewBindingList() { throw null; }
        public int IndexOf(TEntity entity) { throw null; }
        public void Insert(int index, TEntity entity) { }
        public void Load() { }
        public bool Remove(TEntity entity) { throw null; }
        public void RemoveAt(int index) { }
        public void SetSource(System.Collections.Generic.IEnumerable<TEntity> entitySource) { }
        void System.Collections.ICollection.CopyTo(System.Array array, int index) { }
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { throw null; }
        int System.Collections.IList.Add(object value) { throw null; }
        bool System.Collections.IList.Contains(object value) { throw null; }
        int System.Collections.IList.IndexOf(object value) { throw null; }
        void System.Collections.IList.Insert(int index, object value) { }
        void System.Collections.IList.Remove(object value) { }
        System.Collections.IList System.ComponentModel.IListSource.GetList() { throw null; }
    }
    public partial class ForeignKeyReferenceAlreadyHasValueException : System.InvalidOperationException
    {
        public ForeignKeyReferenceAlreadyHasValueException() { }
        public ForeignKeyReferenceAlreadyHasValueException(string message) { }
        public ForeignKeyReferenceAlreadyHasValueException(string message, System.Exception innerException) { }
    }
    public partial interface IExecuteResult : System.IDisposable
    {
        object ReturnValue { get; }
        object GetParameterValue(int parameterIndex);
    }
    public partial interface IFunctionResult
    {
        object ReturnValue { get; }
    }
    public partial interface IMultipleResults : System.Data.Linq.IFunctionResult, System.IDisposable
    {
        System.Collections.Generic.IEnumerable<TElement> GetResult<TElement>();
    }
    public partial interface ISingleResult<T> : System.Collections.Generic.IEnumerable<T>, System.Collections.IEnumerable, System.Data.Linq.IFunctionResult, System.IDisposable
    {
    }
    public partial interface ITable : System.Collections.IEnumerable, System.Linq.IQueryable
    {
        System.Data.Linq.DataContext Context { get; }
        bool IsReadOnly { get; }
        void Attach(object entity);
        void Attach(object entity, bool asModified);
        void Attach(object entity, object original);
        void AttachAll(System.Collections.IEnumerable entities);
        void AttachAll(System.Collections.IEnumerable entities, bool asModified);
        void DeleteAllOnSubmit(System.Collections.IEnumerable entities);
        void DeleteOnSubmit(object entity);
        System.Data.Linq.ModifiedMemberInfo[] GetModifiedMembers(object entity);
        object GetOriginalEntityState(object entity);
        void InsertAllOnSubmit(System.Collections.IEnumerable entities);
        void InsertOnSubmit(object entity);
    }
    public partial interface ITable<TEntity> : System.Collections.Generic.IEnumerable<TEntity>, System.Collections.IEnumerable, System.Linq.IQueryable, System.Linq.IQueryable<TEntity> where TEntity : class
    {
        void Attach(TEntity entity);
        void DeleteOnSubmit(TEntity entity);
        void InsertOnSubmit(TEntity entity);
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential, Size=1)]
    public partial struct Link<T>
    {
        private T underlyingValue;
        private object _dummy;
        private int _dummyPrimitive;
        [System.MonoTODOAttribute]
        public Link(System.Collections.Generic.IEnumerable<T> source) { throw null;}
        [System.MonoTODOAttribute]
        public Link(System.Data.Linq.Link<T> link) { throw null;}
        [System.MonoTODOAttribute]
        public Link(T value) { throw null;}
        [System.MonoTODOAttribute]
        public bool HasLoadedOrAssignedValue { get { throw null; } }
        [System.MonoTODOAttribute]
        public bool HasValue { get { throw null; } }
        [System.MonoTODOAttribute]
        public T Value { get { throw null; } set { } }
    }
    public sealed partial class MemberChangeConflict
    {
        internal MemberChangeConflict() { }
        [System.MonoTODOAttribute]
        public object CurrentValue { get { throw null; } }
        [System.MonoTODOAttribute]
        public object DatabaseValue { get { throw null; } }
        [System.MonoTODOAttribute]
        public bool IsModified { get { throw null; } }
        [System.MonoTODOAttribute]
        public bool IsResolved { get { throw null; } }
        [System.MonoTODOAttribute]
        public System.Reflection.MemberInfo Member { get { throw null; } }
        [System.MonoTODOAttribute]
        public object OriginalValue { get { throw null; } }
        [System.MonoTODOAttribute]
        public void Resolve(System.Data.Linq.RefreshMode refreshMode) { }
        [System.MonoTODOAttribute]
        public void Resolve(object value) { }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential, Size=1)]
    public partial struct ModifiedMemberInfo
    {
        private object _dummy;
        [System.MonoTODOAttribute]
        public object CurrentValue { get { throw null; } }
        [System.MonoTODOAttribute]
        public System.Reflection.MemberInfo Member { get { throw null; } }
        [System.MonoTODOAttribute]
        public object OriginalValue { get { throw null; } }
    }
    public sealed partial class ObjectChangeConflict
    {
        internal ObjectChangeConflict() { }
        [System.MonoTODOAttribute]
        public bool IsDeleted { get { throw null; } }
        [System.MonoTODOAttribute]
        public bool IsResolved { get { throw null; } }
        [System.MonoTODOAttribute]
        public System.Collections.ObjectModel.ReadOnlyCollection<System.Data.Linq.MemberChangeConflict> MemberConflicts { get { throw null; } }
        [System.MonoTODOAttribute]
        public object Object { get { throw null; } }
        [System.MonoTODOAttribute]
        public void Resolve() { }
        [System.MonoTODOAttribute]
        public void Resolve(System.Data.Linq.RefreshMode refreshMode) { }
        [System.MonoTODOAttribute]
        public void Resolve(System.Data.Linq.RefreshMode refreshMode, bool autoResolveDeletes) { }
    }
    public enum RefreshMode
    {
        KeepChanges = 1,
        KeepCurrentValues = 0,
        OverwriteCurrentValues = 2,
    }
    public sealed partial class Table<TEntity> : System.Collections.Generic.IEnumerable<TEntity>, System.Collections.IEnumerable, System.ComponentModel.IListSource, System.Data.Linq.ITable, System.Data.Linq.ITable<TEntity>, System.Linq.IQueryable, System.Linq.IQueryable<TEntity>, System.Linq.IQueryProvider where TEntity : class
    {
        internal Table() { }
        public System.Data.Linq.DataContext Context { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        public bool IsReadOnly { get { throw null; } }
        bool System.ComponentModel.IListSource.ContainsListCollection { get { throw null; } }
        System.Type System.Linq.IQueryable.ElementType { get { throw null; } }
        System.Linq.Expressions.Expression System.Linq.IQueryable.Expression { get { throw null; } }
        System.Linq.IQueryProvider System.Linq.IQueryable.Provider { get { throw null; } }
        public void Attach(TEntity entity) { }
        public void Attach(TEntity entity, bool asModified) { }
        public void Attach(TEntity entity, TEntity original) { }
        public void AttachAll<TSubEntity>(System.Collections.Generic.IEnumerable<TSubEntity> entities) where TSubEntity : TEntity { }
        public void AttachAll<TSubEntity>(System.Collections.Generic.IEnumerable<TSubEntity> entities, bool asModified) where TSubEntity : TEntity { }
        public void DeleteAllOnSubmit<TSubEntity>(System.Collections.Generic.IEnumerable<TSubEntity> entities) where TSubEntity : TEntity { }
        public void DeleteOnSubmit(TEntity entity) { }
        public System.Collections.Generic.IEnumerator<TEntity> GetEnumerator() { throw null; }
        public System.Data.Linq.ModifiedMemberInfo[] GetModifiedMembers(TEntity entity) { throw null; }
        public System.ComponentModel.IBindingList GetNewBindingList() { throw null; }
        public TEntity GetOriginalEntityState(TEntity entity) { throw null; }
        public void InsertAllOnSubmit<TSubEntity>(System.Collections.Generic.IEnumerable<TSubEntity> entities) where TSubEntity : TEntity { }
        public void InsertOnSubmit(TEntity entity) { }
        System.Collections.Generic.IEnumerator<TEntity> System.Collections.Generic.IEnumerable<TEntity>.GetEnumerator() { throw null; }
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { throw null; }
        System.Collections.IList System.ComponentModel.IListSource.GetList() { throw null; }
        void System.Data.Linq.ITable.Attach(object entity) { }
        void System.Data.Linq.ITable.Attach(object entity, bool asModified) { }
        void System.Data.Linq.ITable.Attach(object entity, object original) { }
        void System.Data.Linq.ITable.AttachAll(System.Collections.IEnumerable entities) { }
        void System.Data.Linq.ITable.AttachAll(System.Collections.IEnumerable entities, bool asModified) { }
        void System.Data.Linq.ITable.DeleteAllOnSubmit(System.Collections.IEnumerable entities) { }
        void System.Data.Linq.ITable.DeleteOnSubmit(object entity) { }
        [System.ObsoleteAttribute("NOT IMPLEMENTED YET")]
        System.Data.Linq.ModifiedMemberInfo[] System.Data.Linq.ITable.GetModifiedMembers(object entity) { throw null; }
        [System.ObsoleteAttribute("NOT IMPLEMENTED YET")]
        object System.Data.Linq.ITable.GetOriginalEntityState(object entity) { throw null; }
        void System.Data.Linq.ITable.InsertAllOnSubmit(System.Collections.IEnumerable entities) { }
        void System.Data.Linq.ITable.InsertOnSubmit(object entity) { }
        System.Linq.IQueryable System.Linq.IQueryProvider.CreateQuery(System.Linq.Expressions.Expression expression) { throw null; }
        System.Linq.IQueryable<TResult> System.Linq.IQueryProvider.CreateQuery<TResult>(System.Linq.Expressions.Expression expression) { throw null; }
        object System.Linq.IQueryProvider.Execute(System.Linq.Expressions.Expression expression) { throw null; }
        TResult System.Linq.IQueryProvider.Execute<TResult>(System.Linq.Expressions.Expression expression) { throw null; }
        public override string ToString() { throw null; }
    }
}
namespace System.Data.Linq.Mapping
{
    [System.AttributeUsageAttribute((System.AttributeTargets)(384), AllowMultiple=false)]
    public sealed partial class AssociationAttribute : System.Data.Linq.Mapping.DataAttribute
    {
        public AssociationAttribute() { }
        public bool DeleteOnNull { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public string DeleteRule { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public bool IsForeignKey { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public bool IsUnique { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public string OtherKey { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public string ThisKey { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    }
    public sealed partial class AttributeMappingSource : System.Data.Linq.Mapping.MappingSource
    {
        public AttributeMappingSource() { }
        protected override System.Data.Linq.Mapping.MetaModel CreateModel(System.Type dataContextType) { throw null; }
    }
    public enum AutoSync
    {
        Always = 1,
        Default = 0,
        Never = 2,
        OnInsert = 3,
        OnUpdate = 4,
    }
    [System.AttributeUsageAttribute((System.AttributeTargets)(384), AllowMultiple=false)]
    public sealed partial class ColumnAttribute : System.Data.Linq.Mapping.DataAttribute
    {
        public ColumnAttribute() { }
        public System.Data.Linq.Mapping.AutoSync AutoSync { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public bool CanBeNull { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public string DbType { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public string Expression { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public bool IsDbGenerated { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public bool IsDiscriminator { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public bool IsPrimaryKey { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public bool IsVersion { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public System.Data.Linq.Mapping.UpdateCheck UpdateCheck { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    }
    public abstract partial class DataAttribute : System.Attribute
    {
        protected DataAttribute() { }
        public string Name { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public string Storage { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    }
    [System.AttributeUsageAttribute((System.AttributeTargets)(4), AllowMultiple=false)]
    public sealed partial class DatabaseAttribute : System.Attribute
    {
        public DatabaseAttribute() { }
        public string Name { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    }
    [System.AttributeUsageAttribute((System.AttributeTargets)(64), AllowMultiple=false)]
    public sealed partial class FunctionAttribute : System.Attribute
    {
        public FunctionAttribute() { }
        public bool IsComposable { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public string Name { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    }
    [System.AttributeUsageAttribute((System.AttributeTargets)(4), AllowMultiple=true, Inherited=false)]
    public sealed partial class InheritanceMappingAttribute : System.Attribute
    {
        public InheritanceMappingAttribute() { }
        public object Code { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public bool IsDefault { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public System.Type Type { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    }
    public abstract partial class MappingSource
    {
        protected MappingSource() { }
        protected abstract System.Data.Linq.Mapping.MetaModel CreateModel(System.Type dataContextType);
        public System.Data.Linq.Mapping.MetaModel GetModel(System.Type dataContextType) { throw null; }
    }
    public abstract partial class MetaAccessor
    {
        protected MetaAccessor() { }
        public abstract System.Type Type { get; }
        public abstract object GetBoxedValue(object instance);
        [System.MonoTODOAttribute]
        public virtual bool HasAssignedValue(object instance) { throw null; }
        [System.MonoTODOAttribute]
        public virtual bool HasLoadedValue(object instance) { throw null; }
        [System.MonoTODOAttribute]
        public virtual bool HasValue(object instance) { throw null; }
        public abstract void SetBoxedValue(ref object instance, object value);
    }
    public abstract partial class MetaAccessor<TEntity, TMember> : System.Data.Linq.Mapping.MetaAccessor
    {
        protected MetaAccessor() { }
        public override System.Type Type { get { throw null; } }
        public override object GetBoxedValue(object instance) { throw null; }
        public abstract TMember GetValue(TEntity instance);
        public override void SetBoxedValue(ref object instance, object value) { }
        public abstract void SetValue(ref TEntity instance, TMember value);
    }
    public abstract partial class MetaAssociation
    {
        protected MetaAssociation() { }
        public abstract bool DeleteOnNull { get; }
        public abstract string DeleteRule { get; }
        public abstract bool IsForeignKey { get; }
        public abstract bool IsMany { get; }
        public abstract bool IsNullable { get; }
        public abstract bool IsUnique { get; }
        public abstract System.Collections.ObjectModel.ReadOnlyCollection<System.Data.Linq.Mapping.MetaDataMember> OtherKey { get; }
        public abstract bool OtherKeyIsPrimaryKey { get; }
        public abstract System.Data.Linq.Mapping.MetaDataMember OtherMember { get; }
        public abstract System.Data.Linq.Mapping.MetaType OtherType { get; }
        public abstract System.Collections.ObjectModel.ReadOnlyCollection<System.Data.Linq.Mapping.MetaDataMember> ThisKey { get; }
        public abstract bool ThisKeyIsPrimaryKey { get; }
        public abstract System.Data.Linq.Mapping.MetaDataMember ThisMember { get; }
    }
    public abstract partial class MetaDataMember
    {
        protected MetaDataMember() { }
        public abstract System.Data.Linq.Mapping.MetaAssociation Association { get; }
        public abstract System.Data.Linq.Mapping.AutoSync AutoSync { get; }
        public abstract bool CanBeNull { get; }
        public abstract string DbType { get; }
        public abstract System.Data.Linq.Mapping.MetaType DeclaringType { get; }
        public abstract System.Data.Linq.Mapping.MetaAccessor DeferredSourceAccessor { get; }
        public abstract System.Data.Linq.Mapping.MetaAccessor DeferredValueAccessor { get; }
        public abstract string Expression { get; }
        public abstract bool IsAssociation { get; }
        public abstract bool IsDbGenerated { get; }
        public abstract bool IsDeferred { get; }
        public abstract bool IsDiscriminator { get; }
        public abstract bool IsPersistent { get; }
        public abstract bool IsPrimaryKey { get; }
        public abstract bool IsVersion { get; }
        public abstract System.Reflection.MethodInfo LoadMethod { get; }
        public abstract string MappedName { get; }
        public abstract System.Reflection.MemberInfo Member { get; }
        public abstract System.Data.Linq.Mapping.MetaAccessor MemberAccessor { get; }
        public abstract string Name { get; }
        public abstract int Ordinal { get; }
        public abstract System.Data.Linq.Mapping.MetaAccessor StorageAccessor { get; }
        public abstract System.Reflection.MemberInfo StorageMember { get; }
        public abstract System.Type Type { get; }
        public abstract System.Data.Linq.Mapping.UpdateCheck UpdateCheck { get; }
        public abstract bool IsDeclaredBy(System.Data.Linq.Mapping.MetaType type);
    }
    public abstract partial class MetaFunction
    {
        protected MetaFunction() { }
        public abstract bool HasMultipleResults { get; }
        public abstract bool IsComposable { get; }
        public abstract string MappedName { get; }
        public abstract System.Reflection.MethodInfo Method { get; }
        public abstract System.Data.Linq.Mapping.MetaModel Model { get; }
        public abstract string Name { get; }
        public abstract System.Collections.ObjectModel.ReadOnlyCollection<System.Data.Linq.Mapping.MetaParameter> Parameters { get; }
        public abstract System.Collections.ObjectModel.ReadOnlyCollection<System.Data.Linq.Mapping.MetaType> ResultRowTypes { get; }
        public abstract System.Data.Linq.Mapping.MetaParameter ReturnParameter { get; }
    }
    public abstract partial class MetaModel
    {
        protected MetaModel() { }
        public abstract System.Type ContextType { get; }
        public abstract string DatabaseName { get; }
        public abstract System.Data.Linq.Mapping.MappingSource MappingSource { get; }
        public abstract System.Type ProviderType { get; }
        public abstract System.Data.Linq.Mapping.MetaFunction GetFunction(System.Reflection.MethodInfo method);
        public abstract System.Collections.Generic.IEnumerable<System.Data.Linq.Mapping.MetaFunction> GetFunctions();
        public abstract System.Data.Linq.Mapping.MetaType GetMetaType(System.Type type);
        public abstract System.Data.Linq.Mapping.MetaTable GetTable(System.Type rowType);
        public abstract System.Collections.Generic.IEnumerable<System.Data.Linq.Mapping.MetaTable> GetTables();
    }
    public abstract partial class MetaParameter
    {
        protected MetaParameter() { }
        public abstract string DbType { get; }
        public abstract string MappedName { get; }
        public abstract string Name { get; }
        public abstract System.Reflection.ParameterInfo Parameter { get; }
        public abstract System.Type ParameterType { get; }
    }
    public abstract partial class MetaTable
    {
        protected MetaTable() { }
        public abstract System.Reflection.MethodInfo DeleteMethod { get; }
        public abstract System.Reflection.MethodInfo InsertMethod { get; }
        public abstract System.Data.Linq.Mapping.MetaModel Model { get; }
        public abstract System.Data.Linq.Mapping.MetaType RowType { get; }
        public abstract string TableName { get; }
        public abstract System.Reflection.MethodInfo UpdateMethod { get; }
    }
    public abstract partial class MetaType
    {
        protected MetaType() { }
        public abstract System.Collections.ObjectModel.ReadOnlyCollection<System.Data.Linq.Mapping.MetaAssociation> Associations { get; }
        public abstract bool CanInstantiate { get; }
        public abstract System.Collections.ObjectModel.ReadOnlyCollection<System.Data.Linq.Mapping.MetaDataMember> DataMembers { get; }
        public abstract System.Data.Linq.Mapping.MetaDataMember DBGeneratedIdentityMember { get; }
        public abstract System.Collections.ObjectModel.ReadOnlyCollection<System.Data.Linq.Mapping.MetaType> DerivedTypes { get; }
        public abstract System.Data.Linq.Mapping.MetaDataMember Discriminator { get; }
        public abstract bool HasAnyLoadMethod { get; }
        public abstract bool HasAnyValidateMethod { get; }
        public abstract bool HasInheritance { get; }
        public abstract bool HasInheritanceCode { get; }
        public abstract bool HasUpdateCheck { get; }
        public abstract System.Collections.ObjectModel.ReadOnlyCollection<System.Data.Linq.Mapping.MetaDataMember> IdentityMembers { get; }
        public abstract System.Data.Linq.Mapping.MetaType InheritanceBase { get; }
        public abstract object InheritanceCode { get; }
        public abstract System.Data.Linq.Mapping.MetaType InheritanceDefault { get; }
        public abstract System.Data.Linq.Mapping.MetaType InheritanceRoot { get; }
        public abstract System.Collections.ObjectModel.ReadOnlyCollection<System.Data.Linq.Mapping.MetaType> InheritanceTypes { get; }
        public abstract bool IsEntity { get; }
        public abstract bool IsInheritanceDefault { get; }
        public abstract System.Data.Linq.Mapping.MetaModel Model { get; }
        public abstract string Name { get; }
        public abstract System.Reflection.MethodInfo OnLoadedMethod { get; }
        public abstract System.Reflection.MethodInfo OnValidateMethod { get; }
        public abstract System.Collections.ObjectModel.ReadOnlyCollection<System.Data.Linq.Mapping.MetaDataMember> PersistentDataMembers { get; }
        public abstract System.Data.Linq.Mapping.MetaTable Table { get; }
        public abstract System.Type Type { get; }
        public abstract System.Data.Linq.Mapping.MetaDataMember VersionMember { get; }
        public abstract System.Data.Linq.Mapping.MetaDataMember GetDataMember(System.Reflection.MemberInfo member);
        public abstract System.Data.Linq.Mapping.MetaType GetInheritanceType(System.Type type);
        public abstract System.Data.Linq.Mapping.MetaType GetTypeForInheritanceCode(object code);
    }
    [System.AttributeUsageAttribute((System.AttributeTargets)(10240), AllowMultiple=false)]
    public sealed partial class ParameterAttribute : System.Attribute
    {
        public ParameterAttribute() { }
        public string DbType { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public string Name { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    }
    [System.AttributeUsageAttribute((System.AttributeTargets)(4), AllowMultiple=false)]
    public sealed partial class ProviderAttribute : System.Attribute
    {
        public ProviderAttribute() { }
        public ProviderAttribute(System.Type type) { }
        public System.Type Type { get { throw null; } }
    }
    [System.AttributeUsageAttribute((System.AttributeTargets)(64), AllowMultiple=true)]
    public sealed partial class ResultTypeAttribute : System.Attribute
    {
        public ResultTypeAttribute(System.Type type) { }
        public System.Type Type { get { throw null; } }
    }
    [System.AttributeUsageAttribute((System.AttributeTargets)(4), AllowMultiple=false, Inherited=false)]
    public sealed partial class TableAttribute : System.Attribute
    {
        public TableAttribute() { }
        public string Name { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    }
    public enum UpdateCheck
    {
        Always = 0,
        Never = 1,
        WhenChanged = 2,
    }
    public sealed partial class XmlMappingSource : System.Data.Linq.Mapping.MappingSource
    {
        internal XmlMappingSource() { }
        protected override System.Data.Linq.Mapping.MetaModel CreateModel(System.Type dataContextType) { throw null; }
        public static System.Data.Linq.Mapping.XmlMappingSource FromReader(System.Xml.XmlReader reader) { throw null; }
        public static System.Data.Linq.Mapping.XmlMappingSource FromStream(System.IO.Stream stream) { throw null; }
        public static System.Data.Linq.Mapping.XmlMappingSource FromUrl(string url) { throw null; }
        public static System.Data.Linq.Mapping.XmlMappingSource FromXml(string xml) { throw null; }
    }
}
namespace System.Data.Linq.SqlClient
{
    public sealed partial class Sql2000Provider : System.Data.Linq.SqlClient.SqlProvider
    {
        public Sql2000Provider() { }
    }
    public sealed partial class Sql2005Provider : System.Data.Linq.SqlClient.SqlProvider
    {
        public Sql2005Provider() { }
    }
    public sealed partial class Sql2008Provider : System.Data.Linq.SqlClient.SqlProvider
    {
        public Sql2008Provider() { }
    }
    public static partial class SqlHelpers
    {
        [System.MonoTODOAttribute]
        public static string GetStringContainsPattern(string text, char escape) { throw null; }
        [System.MonoTODOAttribute]
        public static string GetStringEndsWithPattern(string text, char escape) { throw null; }
        [System.MonoTODOAttribute]
        public static string GetStringStartsWithPattern(string text, char escape) { throw null; }
        [System.MonoTODOAttribute]
        public static string TranslateVBLikePattern(string pattern, char escape) { throw null; }
    }
    public static partial class SqlMethods
    {
        [System.MonoTODOAttribute]
        public static int DateDiffDay(System.DateTime startDate, System.DateTime endDate) { throw null; }
        [System.MonoTODOAttribute]
        public static int DateDiffDay(System.DateTimeOffset startDate, System.DateTimeOffset endDate) { throw null; }
        [System.MonoTODOAttribute]
        public static System.Nullable<int> DateDiffDay(System.Nullable<System.DateTimeOffset> startDate, System.Nullable<System.DateTimeOffset> endDate) { throw null; }
        [System.MonoTODOAttribute]
        public static System.Nullable<int> DateDiffDay(System.Nullable<System.DateTime> startDate, System.Nullable<System.DateTime> endDate) { throw null; }
        [System.MonoTODOAttribute]
        public static int DateDiffHour(System.DateTime startDate, System.DateTime endDate) { throw null; }
        [System.MonoTODOAttribute]
        public static int DateDiffHour(System.DateTimeOffset startDate, System.DateTimeOffset endDate) { throw null; }
        [System.MonoTODOAttribute]
        public static System.Nullable<int> DateDiffHour(System.Nullable<System.DateTimeOffset> startDate, System.Nullable<System.DateTimeOffset> endDate) { throw null; }
        [System.MonoTODOAttribute]
        public static System.Nullable<int> DateDiffHour(System.Nullable<System.DateTime> startDate, System.Nullable<System.DateTime> endDate) { throw null; }
        [System.MonoTODOAttribute]
        public static int DateDiffMicrosecond(System.DateTime startDate, System.DateTime endDate) { throw null; }
        [System.MonoTODOAttribute]
        public static int DateDiffMicrosecond(System.DateTimeOffset startDate, System.DateTimeOffset endDate) { throw null; }
        [System.MonoTODOAttribute]
        public static System.Nullable<int> DateDiffMicrosecond(System.Nullable<System.DateTimeOffset> startDate, System.Nullable<System.DateTimeOffset> endDate) { throw null; }
        [System.MonoTODOAttribute]
        public static System.Nullable<int> DateDiffMicrosecond(System.Nullable<System.DateTime> startDate, System.Nullable<System.DateTime> endDate) { throw null; }
        [System.MonoTODOAttribute]
        public static int DateDiffMillisecond(System.DateTime startDate, System.DateTime endDate) { throw null; }
        [System.MonoTODOAttribute]
        public static int DateDiffMillisecond(System.DateTimeOffset startDate, System.DateTimeOffset endDate) { throw null; }
        [System.MonoTODOAttribute]
        public static System.Nullable<int> DateDiffMillisecond(System.Nullable<System.DateTimeOffset> startDate, System.Nullable<System.DateTimeOffset> endDate) { throw null; }
        [System.MonoTODOAttribute]
        public static System.Nullable<int> DateDiffMillisecond(System.Nullable<System.DateTime> startDate, System.Nullable<System.DateTime> endDate) { throw null; }
        [System.MonoTODOAttribute]
        public static int DateDiffMinute(System.DateTime startDate, System.DateTime endDate) { throw null; }
        [System.MonoTODOAttribute]
        public static int DateDiffMinute(System.DateTimeOffset startDate, System.DateTimeOffset endDate) { throw null; }
        [System.MonoTODOAttribute]
        public static System.Nullable<int> DateDiffMinute(System.Nullable<System.DateTimeOffset> startDate, System.Nullable<System.DateTimeOffset> endDate) { throw null; }
        [System.MonoTODOAttribute]
        public static System.Nullable<int> DateDiffMinute(System.Nullable<System.DateTime> startDate, System.Nullable<System.DateTime> endDate) { throw null; }
        [System.MonoTODOAttribute]
        public static int DateDiffMonth(System.DateTime startDate, System.DateTime endDate) { throw null; }
        [System.MonoTODOAttribute]
        public static int DateDiffMonth(System.DateTimeOffset startDate, System.DateTimeOffset endDate) { throw null; }
        [System.MonoTODOAttribute]
        public static System.Nullable<int> DateDiffMonth(System.Nullable<System.DateTimeOffset> startDate, System.Nullable<System.DateTimeOffset> endDate) { throw null; }
        [System.MonoTODOAttribute]
        public static System.Nullable<int> DateDiffMonth(System.Nullable<System.DateTime> startDate, System.Nullable<System.DateTime> endDate) { throw null; }
        [System.MonoTODOAttribute]
        public static int DateDiffNanosecond(System.DateTime startDate, System.DateTime endDate) { throw null; }
        [System.MonoTODOAttribute]
        public static int DateDiffNanosecond(System.DateTimeOffset startDate, System.DateTimeOffset endDate) { throw null; }
        [System.MonoTODOAttribute]
        public static System.Nullable<int> DateDiffNanosecond(System.Nullable<System.DateTimeOffset> startDate, System.Nullable<System.DateTimeOffset> endDate) { throw null; }
        [System.MonoTODOAttribute]
        public static System.Nullable<int> DateDiffNanosecond(System.Nullable<System.DateTime> startDate, System.Nullable<System.DateTime> endDate) { throw null; }
        [System.MonoTODOAttribute]
        public static int DateDiffSecond(System.DateTime startDate, System.DateTime endDate) { throw null; }
        [System.MonoTODOAttribute]
        public static int DateDiffSecond(System.DateTimeOffset startDate, System.DateTimeOffset endDate) { throw null; }
        [System.MonoTODOAttribute]
        public static System.Nullable<int> DateDiffSecond(System.Nullable<System.DateTimeOffset> startDate, System.Nullable<System.DateTimeOffset> endDate) { throw null; }
        [System.MonoTODOAttribute]
        public static System.Nullable<int> DateDiffSecond(System.Nullable<System.DateTime> startDate, System.Nullable<System.DateTime> endDate) { throw null; }
        [System.MonoTODOAttribute]
        public static int DateDiffYear(System.DateTime startDate, System.DateTime endDate) { throw null; }
        [System.MonoTODOAttribute]
        public static int DateDiffYear(System.DateTimeOffset startDate, System.DateTimeOffset endDate) { throw null; }
        [System.MonoTODOAttribute]
        public static System.Nullable<int> DateDiffYear(System.Nullable<System.DateTimeOffset> startDate, System.Nullable<System.DateTimeOffset> endDate) { throw null; }
        [System.MonoTODOAttribute]
        public static System.Nullable<int> DateDiffYear(System.Nullable<System.DateTime> startDate, System.Nullable<System.DateTime> endDate) { throw null; }
        [System.MonoTODOAttribute]
        public static bool Like(string matchExpression, string pattern) { throw null; }
        [System.MonoTODOAttribute]
        public static bool Like(string matchExpression, string pattern, char escapeCharacter) { throw null; }
    }
    [System.MonoTODOAttribute]
    public partial class SqlProvider : System.IDisposable
    {
        public SqlProvider() { }
        public void Dispose() { }
        protected virtual void Dispose(bool disposing) { }
    }
}
namespace System.Data.Linq.SqlClient.Implementation
{
    public abstract partial class ObjectMaterializer<TDataReader> where TDataReader : System.Data.Common.DbDataReader
    {
        [System.MonoTODOAttribute]
        public object[] Arguments;
        [System.MonoTODOAttribute]
        public System.Data.Common.DbDataReader BufferReader;
        [System.MonoTODOAttribute]
        public TDataReader DataReader;
        [System.MonoTODOAttribute]
        public object[] Globals;
        [System.MonoTODOAttribute]
        public object[] Locals;
        [System.MonoTODOAttribute]
        public int[] Ordinals;
        [System.MonoTODOAttribute]
        public ObjectMaterializer() { }
        [System.MonoTODOAttribute]
        public abstract bool CanDeferLoad { get; }
        [System.MonoTODOAttribute]
        public static System.Collections.Generic.IEnumerable<TOutput> Convert<TOutput>(System.Collections.IEnumerable source) { throw null; }
        [System.MonoTODOAttribute]
        public static System.Linq.IGrouping<TKey, TElement> CreateGroup<TKey, TElement>(TKey key, System.Collections.Generic.IEnumerable<TElement> items) { throw null; }
        [System.MonoTODOAttribute]
        public static System.Linq.IOrderedEnumerable<TElement> CreateOrderedEnumerable<TElement>(System.Collections.Generic.IEnumerable<TElement> items) { throw null; }
        [System.MonoTODOAttribute]
        public static System.Exception ErrorAssignmentToNull(System.Type type) { throw null; }
        public abstract System.Collections.IEnumerable ExecuteSubQuery(int iSubQuery, object[] args);
        public abstract System.Collections.Generic.IEnumerable<T> GetLinkSource<T>(int globalLink, int localFactory, object[] keyValues);
        public abstract System.Collections.Generic.IEnumerable<T> GetNestedLinkSource<T>(int globalLink, int localFactory, object instance);
        public abstract object InsertLookup(int globalMetaType, object instance);
        public abstract bool Read();
        public abstract void SendEntityMaterialized(int globalMetaType, object instance);
    }
}
