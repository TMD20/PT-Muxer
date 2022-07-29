// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

[assembly:System.Reflection.AssemblyVersionAttribute("4.0.0.0")]
[assembly:System.CLSCompliantAttribute(true)]
[assembly:System.Diagnostics.DebuggableAttribute((System.Diagnostics.DebuggableAttribute.DebuggingModes)(2))]
[assembly:System.Reflection.AssemblyCompanyAttribute("Microsoft Corporation")]
[assembly:System.Reflection.AssemblyConfigurationAttribute("")]
[assembly:System.Reflection.AssemblyCopyrightAttribute("© Microsoft Corporation. All rights reserved.")]
[assembly:System.Reflection.AssemblyDefaultAliasAttribute("System.Json.Microsoft.dll")]
[assembly:System.Reflection.AssemblyDescriptionAttribute("")]
[assembly:System.Reflection.AssemblyFileVersionAttribute("4.0.0.0")]
[assembly:System.Reflection.AssemblyInformationalVersionAttribute("4.7.2046.0")]
[assembly:System.Reflection.AssemblyProductAttribute("Microsoft ASP.NET MVC")]
[assembly:System.Reflection.AssemblyTitleAttribute("System.Json")]
[assembly:System.Reflection.AssemblyTrademarkAttribute("")]
[assembly:System.Resources.NeutralResourcesLanguageAttribute("en-US")]
[assembly:System.Runtime.CompilerServices.CompilationRelaxationsAttribute(8)]
[assembly:System.Runtime.CompilerServices.ReferenceAssemblyAttribute]
[assembly:System.Runtime.CompilerServices.RuntimeCompatibilityAttribute(WrapNonExceptionThrows=true)]
[assembly:System.Runtime.InteropServices.ComVisibleAttribute(false)]
[assembly:System.Runtime.InteropServices.GuidAttribute("6fd72360-ebfc-4097-96fa-2ee418c04f7b")]
[assembly:System.Security.SecurityTransparentAttribute]
namespace System.Json
{
    [System.Runtime.Serialization.DataContractAttribute]
    public sealed partial class JsonArray : System.Json.JsonValue, System.Collections.Generic.ICollection<System.Json.JsonValue>, System.Collections.Generic.IEnumerable<System.Json.JsonValue>, System.Collections.Generic.IList<System.Json.JsonValue>, System.Collections.IEnumerable
    {
        public JsonArray(System.Collections.Generic.IEnumerable<System.Json.JsonValue> items) { }
        public JsonArray(params System.Json.JsonValue[] items) { }
        public override int Count { get { throw null; } }
        public bool IsReadOnly { get { throw null; } }
        public override System.Json.JsonValue this[int index] { get { throw null; } set { } }
        public override System.Json.JsonType JsonType { get { throw null; } }
        public void Add(System.Json.JsonValue item) { }
        public void AddRange(System.Collections.Generic.IEnumerable<System.Json.JsonValue> items) { }
        public void AddRange(params System.Json.JsonValue[] items) { }
        public void Clear() { }
        public bool Contains(System.Json.JsonValue item) { throw null; }
        public void CopyTo(System.Json.JsonValue[] array, int arrayIndex) { }
        public new System.Collections.Generic.IEnumerator<System.Json.JsonValue> GetEnumerator() { throw null; }
        protected override System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<string, System.Json.JsonValue>> GetKeyValuePairEnumerator() { throw null; }
        public int IndexOf(System.Json.JsonValue item) { throw null; }
        public void Insert(int index, System.Json.JsonValue item) { }
        public bool Remove(System.Json.JsonValue item) { throw null; }
        public void RemoveAt(int index) { }
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { throw null; }
        public override System.Json.JsonValue ValueOrDefault(int index) { throw null; }
    }
    [System.Runtime.Serialization.DataContractAttribute]
    public sealed partial class JsonObject : System.Json.JsonValue, System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<string, System.Json.JsonValue>>, System.Collections.Generic.IDictionary<string, System.Json.JsonValue>, System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<string, System.Json.JsonValue>>, System.Collections.IEnumerable
    {
        public JsonObject(System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<string, System.Json.JsonValue>> items) { }
        public JsonObject(params System.Collections.Generic.KeyValuePair<string, System.Json.JsonValue>[] items) { }
        public override int Count { get { throw null; } }
        public override System.Json.JsonValue this[string key] { get { throw null; } set { } }
        public override System.Json.JsonType JsonType { get { throw null; } }
        public System.Collections.Generic.ICollection<string> Keys { get { throw null; } }
        bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,System.Json.JsonValue>>.IsReadOnly { get { throw null; } }
        public System.Collections.Generic.ICollection<System.Json.JsonValue> Values { get { throw null; } }
        public void Add(System.Collections.Generic.KeyValuePair<string, System.Json.JsonValue> item) { }
        public void Add(string key, System.Json.JsonValue value) { }
        public void AddRange(System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<string, System.Json.JsonValue>> items) { }
        public void AddRange(params System.Collections.Generic.KeyValuePair<string, System.Json.JsonValue>[] items) { }
        public void Clear() { }
        public override bool ContainsKey(string key) { throw null; }
        public void CopyTo(System.Collections.Generic.KeyValuePair<string, System.Json.JsonValue>[] array, int arrayIndex) { }
        protected override System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<string, System.Json.JsonValue>> GetKeyValuePairEnumerator() { throw null; }
        protected override void OnSaveEnded() { }
        protected override void OnSaveStarted() { }
        public bool Remove(string key) { throw null; }
        bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,System.Json.JsonValue>>.Contains(System.Collections.Generic.KeyValuePair<string, System.Json.JsonValue> item) { throw null; }
        bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,System.Json.JsonValue>>.Remove(System.Collections.Generic.KeyValuePair<string, System.Json.JsonValue> item) { throw null; }
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { throw null; }
        public bool TryGetValue(string key, out System.Json.JsonValue value) { value = default(System.Json.JsonValue); throw null; }
        public override System.Json.JsonValue ValueOrDefault(string key) { throw null; }
    }
    [System.Runtime.Serialization.DataContractAttribute]
    public sealed partial class JsonPrimitive : System.Json.JsonValue
    {
        public JsonPrimitive(bool value) { }
        public JsonPrimitive(byte value) { }
        public JsonPrimitive(char value) { }
        public JsonPrimitive(System.DateTime value) { }
        public JsonPrimitive(System.DateTimeOffset value) { }
        public JsonPrimitive(decimal value) { }
        public JsonPrimitive(double value) { }
        public JsonPrimitive(System.Guid value) { }
        public JsonPrimitive(short value) { }
        public JsonPrimitive(int value) { }
        public JsonPrimitive(long value) { }
        [System.CLSCompliantAttribute(false)]
        public JsonPrimitive(sbyte value) { }
        public JsonPrimitive(float value) { }
        public JsonPrimitive(string value) { }
        [System.CLSCompliantAttribute(false)]
        public JsonPrimitive(ushort value) { }
        [System.CLSCompliantAttribute(false)]
        public JsonPrimitive(uint value) { }
        [System.CLSCompliantAttribute(false)]
        public JsonPrimitive(ulong value) { }
        public JsonPrimitive(System.Uri value) { }
        public override System.Json.JsonType JsonType { get { throw null; } }
        public object Value { get { throw null; } }
        public override object ReadAs(System.Type type) { throw null; }
        public static bool TryCreate(object value, out System.Json.JsonPrimitive result) { result = default(System.Json.JsonPrimitive); throw null; }
        public override bool TryReadAs(System.Type type, out object value) { value = default(object); throw null; }
    }
    public enum JsonType
    {
        Array = 3,
        Boolean = 4,
        Default = 5,
        Number = 1,
        Object = 2,
        String = 0,
    }
    [System.Runtime.Serialization.DataContractAttribute]
    public partial class JsonValue : System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<string, System.Json.JsonValue>>, System.Collections.IEnumerable, System.Dynamic.IDynamicMetaObjectProvider
    {
        internal JsonValue() { }
        protected int ChangedListenersCount { get { throw null; } }
        protected int ChangingListenersCount { get { throw null; } }
        public virtual int Count { get { throw null; } }
        public virtual System.Json.JsonValue this[int index] { get { throw null; } set { } }
        public virtual System.Json.JsonValue this[string key] { get { throw null; } set { } }
        public virtual System.Json.JsonType JsonType { get { throw null; } }
        public event System.EventHandler<System.Json.JsonValueChangeEventArgs> Changed { add { } remove { } }
        public event System.EventHandler<System.Json.JsonValueChangeEventArgs> Changing { add { } remove { } }
        public dynamic AsDynamic() { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
        public static T CastValue<T>(System.Json.JsonValue value) { throw null; }
        public virtual bool ContainsKey(string key) { throw null; }
        public System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<string, System.Json.JsonValue>> GetEnumerator() { throw null; }
        protected virtual System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<string, System.Json.JsonValue>> GetKeyValuePairEnumerator() { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
        public virtual System.Json.JsonValue GetValue(int index) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
        public virtual System.Json.JsonValue GetValue(string key) { throw null; }
        public static System.Json.JsonValue Load(System.IO.Stream stream) { throw null; }
        public static System.Json.JsonValue Load(System.IO.TextReader textReader) { throw null; }
        protected virtual void OnSaveEnded() { }
        protected virtual void OnSaveStarted() { }
        public static explicit operator bool (System.Json.JsonValue value) { throw null; }
        public static explicit operator byte (System.Json.JsonValue value) { throw null; }
        public static explicit operator char (System.Json.JsonValue value) { throw null; }
        public static explicit operator System.DateTime (System.Json.JsonValue value) { throw null; }
        public static explicit operator System.DateTimeOffset (System.Json.JsonValue value) { throw null; }
        public static explicit operator decimal (System.Json.JsonValue value) { throw null; }
        public static explicit operator double (System.Json.JsonValue value) { throw null; }
        public static explicit operator System.Guid (System.Json.JsonValue value) { throw null; }
        public static explicit operator short (System.Json.JsonValue value) { throw null; }
        public static explicit operator int (System.Json.JsonValue value) { throw null; }
        public static explicit operator long (System.Json.JsonValue value) { throw null; }
        [System.CLSCompliantAttribute(false)]
        public static explicit operator sbyte (System.Json.JsonValue value) { throw null; }
        public static explicit operator float (System.Json.JsonValue value) { throw null; }
        public static explicit operator string (System.Json.JsonValue value) { throw null; }
        [System.CLSCompliantAttribute(false)]
        public static explicit operator ushort (System.Json.JsonValue value) { throw null; }
        [System.CLSCompliantAttribute(false)]
        public static explicit operator uint (System.Json.JsonValue value) { throw null; }
        [System.CLSCompliantAttribute(false)]
        public static explicit operator ulong (System.Json.JsonValue value) { throw null; }
        public static explicit operator System.Uri (System.Json.JsonValue value) { throw null; }
        public static implicit operator System.Json.JsonValue (bool value) { throw null; }
        public static implicit operator System.Json.JsonValue (byte value) { throw null; }
        public static implicit operator System.Json.JsonValue (char value) { throw null; }
        public static implicit operator System.Json.JsonValue (System.DateTime value) { throw null; }
        public static implicit operator System.Json.JsonValue (System.DateTimeOffset value) { throw null; }
        public static implicit operator System.Json.JsonValue (decimal value) { throw null; }
        public static implicit operator System.Json.JsonValue (double value) { throw null; }
        public static implicit operator System.Json.JsonValue (System.Guid value) { throw null; }
        public static implicit operator System.Json.JsonValue (short value) { throw null; }
        public static implicit operator System.Json.JsonValue (int value) { throw null; }
        public static implicit operator System.Json.JsonValue (long value) { throw null; }
        [System.CLSCompliantAttribute(false)]
        public static implicit operator System.Json.JsonValue (sbyte value) { throw null; }
        public static implicit operator System.Json.JsonValue (float value) { throw null; }
        public static implicit operator System.Json.JsonValue (string value) { throw null; }
        [System.CLSCompliantAttribute(false)]
        public static implicit operator System.Json.JsonValue (ushort value) { throw null; }
        [System.CLSCompliantAttribute(false)]
        public static implicit operator System.Json.JsonValue (uint value) { throw null; }
        [System.CLSCompliantAttribute(false)]
        public static implicit operator System.Json.JsonValue (ulong value) { throw null; }
        public static implicit operator System.Json.JsonValue (System.Uri value) { throw null; }
        public static System.Json.JsonValue Parse(string json) { throw null; }
        protected void RaiseChangedEvent(object sender, System.Json.JsonValueChangeEventArgs eventArgs) { }
        protected void RaiseChangingEvent(object sender, System.Json.JsonValueChangeEventArgs eventArgs) { }
        public virtual object ReadAs(System.Type type) { throw null; }
        public object ReadAs(System.Type type, object fallback) { throw null; }
        public T ReadAs<T>() { throw null; }
        public T ReadAs<T>(T fallback) { throw null; }
        public void Save(System.IO.Stream stream) { }
        public void Save(System.IO.TextWriter textWriter) { }
        [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
        public virtual System.Json.JsonValue SetValue(int index, object value) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
        public virtual System.Json.JsonValue SetValue(string key, object value) { throw null; }
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { throw null; }
        System.Dynamic.DynamicMetaObject System.Dynamic.IDynamicMetaObjectProvider.GetMetaObject(System.Linq.Expressions.Expression parameter) { throw null; }
        public override string ToString() { throw null; }
        public virtual bool TryReadAs(System.Type type, out object value) { value = default(object); throw null; }
        public bool TryReadAs<T>(out T valueOfT) { valueOfT = default(T); throw null; }
        public virtual System.Json.JsonValue ValueOrDefault(int index) { throw null; }
        public System.Json.JsonValue ValueOrDefault(params object[] indexes) { throw null; }
        public virtual System.Json.JsonValue ValueOrDefault(string key) { throw null; }
    }
    public enum JsonValueChange
    {
        Add = 0,
        Clear = 3,
        Remove = 1,
        Replace = 2,
    }
    public partial class JsonValueChangeEventArgs : System.EventArgs
    {
        public JsonValueChangeEventArgs(System.Json.JsonValue child, System.Json.JsonValueChange change, int index) { }
        public JsonValueChangeEventArgs(System.Json.JsonValue child, System.Json.JsonValueChange change, string key) { }
        public System.Json.JsonValueChange Change { get { throw null; } }
        public System.Json.JsonValue Child { get { throw null; } }
        public int Index { get { throw null; } }
        public string Key { get { throw null; } }
    }
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    public static partial class JsonValueLinqExtensions
    {
        public static System.Json.JsonArray ToJsonArray(this System.Collections.Generic.IEnumerable<System.Json.JsonValue> items) { throw null; }
        public static System.Json.JsonObject ToJsonObject(this System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<string, System.Json.JsonValue>> items) { throw null; }
    }
}
namespace System.Runtime.Serialization.Json
{
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    public static partial class JsonValueExtensions
    {
        public static System.Json.JsonValue CreateFrom(object value) { throw null; }
        public static object ReadAsType(this System.Json.JsonValue jsonValue, System.Type type) { throw null; }
        public static T ReadAsType<T>(this System.Json.JsonValue jsonValue) { throw null; }
        public static T ReadAsType<T>(this System.Json.JsonValue jsonValue, T fallback) { throw null; }
        public static bool TryReadAsType(this System.Json.JsonValue jsonValue, System.Type type, out object value) { value = default(object); throw null; }
        public static bool TryReadAsType<T>(this System.Json.JsonValue jsonValue, out T valueOfT) { valueOfT = default(T); throw null; }
    }
}
