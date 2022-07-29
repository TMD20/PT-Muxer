// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

[assembly:System.Reflection.AssemblyVersionAttribute("4.0.0.0")]
[assembly:System.Diagnostics.DebuggableAttribute(System.Diagnostics.DebuggableAttribute.DebuggingModes.IgnoreSymbolStoreSequencePoints)]
[assembly:System.Runtime.CompilerServices.CompilationRelaxationsAttribute(8)]
[assembly:System.Runtime.CompilerServices.RuntimeCompatibilityAttribute(WrapNonExceptionThrows=true)]
namespace WebMatrix.Data
{
    public partial class ConnectionEventArgs : System.EventArgs
    {
        public ConnectionEventArgs(System.Data.Common.DbConnection connection) { }
        public System.Data.Common.DbConnection Connection { get { throw null; } }
    }
    public partial class Database : System.IDisposable
    {
        internal Database() { }
        public System.Data.Common.DbConnection Connection { get { throw null; } }
        public static event System.EventHandler<WebMatrix.Data.ConnectionEventArgs> ConnectionOpened { add { } remove { } }
        public void Close() { }
        public void Dispose() { }
        protected virtual void Dispose(bool disposing) { }
        public int Execute(string commandText, params object[] args) { throw null; }
        public object GetLastInsertId() { throw null; }
        public static WebMatrix.Data.Database Open(string name) { throw null; }
        public static WebMatrix.Data.Database OpenConnectionString(string connectionString) { throw null; }
        public static WebMatrix.Data.Database OpenConnectionString(string connectionString, string providerName) { throw null; }
        public System.Collections.Generic.IEnumerable<dynamic> Query(string commandText, params object[] args) { throw null; }
        public dynamic QuerySingle(string commandText, params object[] args) { throw null; }
        public object QueryValue(string commandText, params object[] args) { throw null; }
    }
    public sealed partial class DynamicRecord : System.Dynamic.DynamicObject, System.ComponentModel.ICustomTypeDescriptor
    {
        internal DynamicRecord() { }
        public System.Collections.Generic.IList<string> Columns { get { throw null; } }
        public object this[int index] { get { throw null; } }
        public object this[string name] { get { throw null; } }
        public override System.Collections.Generic.IEnumerable<string> GetDynamicMemberNames() { throw null; }
        System.ComponentModel.AttributeCollection System.ComponentModel.ICustomTypeDescriptor.GetAttributes() { throw null; }
        string System.ComponentModel.ICustomTypeDescriptor.GetClassName() { throw null; }
        string System.ComponentModel.ICustomTypeDescriptor.GetComponentName() { throw null; }
        System.ComponentModel.TypeConverter System.ComponentModel.ICustomTypeDescriptor.GetConverter() { throw null; }
        System.ComponentModel.EventDescriptor System.ComponentModel.ICustomTypeDescriptor.GetDefaultEvent() { throw null; }
        System.ComponentModel.PropertyDescriptor System.ComponentModel.ICustomTypeDescriptor.GetDefaultProperty() { throw null; }
        object System.ComponentModel.ICustomTypeDescriptor.GetEditor(System.Type editorBaseType) { throw null; }
        System.ComponentModel.EventDescriptorCollection System.ComponentModel.ICustomTypeDescriptor.GetEvents() { throw null; }
        System.ComponentModel.EventDescriptorCollection System.ComponentModel.ICustomTypeDescriptor.GetEvents(System.Attribute[] attributes) { throw null; }
        System.ComponentModel.PropertyDescriptorCollection System.ComponentModel.ICustomTypeDescriptor.GetProperties() { throw null; }
        System.ComponentModel.PropertyDescriptorCollection System.ComponentModel.ICustomTypeDescriptor.GetProperties(System.Attribute[] attributes) { throw null; }
        object System.ComponentModel.ICustomTypeDescriptor.GetPropertyOwner(System.ComponentModel.PropertyDescriptor pd) { throw null; }
        public override bool TryGetMember(System.Dynamic.GetMemberBinder binder, out object result) { throw null; }
    }
}
