// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

[assembly:System.Reflection.AssemblyVersionAttribute("4.0.0.0")]
[assembly:System.Diagnostics.DebuggableAttribute(System.Diagnostics.DebuggableAttribute.DebuggingModes.IgnoreSymbolStoreSequencePoints)]
[assembly:System.Reflection.AssemblyCompanyAttribute("Mono development team")]
[assembly:System.Reflection.AssemblyCopyrightAttribute("(c) Various Mono authors")]
[assembly:System.Reflection.AssemblyDefaultAliasAttribute("System.Json.dll")]
[assembly:System.Reflection.AssemblyDescriptionAttribute("System.Json.dll")]
[assembly:System.Reflection.AssemblyFileVersionAttribute("4.6.57.0")]
[assembly:System.Reflection.AssemblyInformationalVersionAttribute("4.6.57.0")]
[assembly:System.Reflection.AssemblyProductAttribute("Mono Common Language Infrastructure")]
[assembly:System.Reflection.AssemblyTitleAttribute("System.Json.dll")]
[assembly:System.Resources.NeutralResourcesLanguageAttribute("en-US")]
[assembly:System.Resources.SatelliteContractVersionAttribute("4.0.0.0")]
[assembly:System.Runtime.CompilerServices.CompilationRelaxationsAttribute(8)]
[assembly:System.Runtime.CompilerServices.RuntimeCompatibilityAttribute(WrapNonExceptionThrows=true)]
[assembly:System.Runtime.InteropServices.ComVisibleAttribute(false)]
[assembly:System.Security.SecurityCriticalAttribute]
namespace System.Json
{
    public partial class JsonArray : System.Json.JsonValue, System.Collections.Generic.ICollection<System.Json.JsonValue>, System.Collections.Generic.IEnumerable<System.Json.JsonValue>, System.Collections.Generic.IList<System.Json.JsonValue>, System.Collections.IEnumerable
    {
        public JsonArray(System.Collections.Generic.IEnumerable<System.Json.JsonValue> items) { }
        public JsonArray(params System.Json.JsonValue[] items) { }
        public override int Count { get { throw null; } }
        public bool IsReadOnly { get { throw null; } }
        public sealed override System.Json.JsonValue this[int index] { get { throw null; } set { } }
        public override System.Json.JsonType JsonType { get { throw null; } }
        public void Add(System.Json.JsonValue item) { }
        public void AddRange(System.Collections.Generic.IEnumerable<System.Json.JsonValue> items) { }
        public void AddRange(params System.Json.JsonValue[] items) { }
        public void Clear() { }
        public bool Contains(System.Json.JsonValue item) { throw null; }
        public void CopyTo(System.Json.JsonValue[] array, int arrayIndex) { }
        public int IndexOf(System.Json.JsonValue item) { throw null; }
        public void Insert(int index, System.Json.JsonValue item) { }
        public bool Remove(System.Json.JsonValue item) { throw null; }
        public void RemoveAt(int index) { }
        public override void Save(System.IO.Stream stream) { }
        System.Collections.Generic.IEnumerator<System.Json.JsonValue> System.Collections.Generic.IEnumerable<System.Json.JsonValue>.GetEnumerator() { throw null; }
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { throw null; }
    }
    public partial class JsonObject : System.Json.JsonValue, System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<string, System.Json.JsonValue>>, System.Collections.Generic.IDictionary<string, System.Json.JsonValue>, System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<string, System.Json.JsonValue>>, System.Collections.IEnumerable
    {
        public JsonObject(System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<string, System.Json.JsonValue>> items) { }
        public JsonObject(params System.Collections.Generic.KeyValuePair<string, System.Json.JsonValue>[] items) { }
        public override int Count { get { throw null; } }
        public sealed override System.Json.JsonValue this[string key] { get { throw null; } set { } }
        public override System.Json.JsonType JsonType { get { throw null; } }
        public System.Collections.Generic.ICollection<string> Keys { get { throw null; } }
        bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,System.Json.JsonValue>>.IsReadOnly { get { throw null; } }
        public System.Collections.Generic.ICollection<System.Json.JsonValue> Values { get { throw null; } }
        public void Add(System.Collections.Generic.KeyValuePair<string, System.Json.JsonValue> pair) { }
        public void Add(string key, System.Json.JsonValue value) { }
        public void AddRange(System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<string, System.Json.JsonValue>> items) { }
        public void AddRange(params System.Collections.Generic.KeyValuePair<string, System.Json.JsonValue>[] items) { }
        public void Clear() { }
        public override bool ContainsKey(string key) { throw null; }
        public void CopyTo(System.Collections.Generic.KeyValuePair<string, System.Json.JsonValue>[] array, int arrayIndex) { }
        public System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<string, System.Json.JsonValue>> GetEnumerator() { throw null; }
        public bool Remove(string key) { throw null; }
        public override void Save(System.IO.Stream stream) { }
        bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,System.Json.JsonValue>>.Contains(System.Collections.Generic.KeyValuePair<string, System.Json.JsonValue> item) { throw null; }
        bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,System.Json.JsonValue>>.Remove(System.Collections.Generic.KeyValuePair<string, System.Json.JsonValue> item) { throw null; }
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { throw null; }
        public bool TryGetValue(string key, out System.Json.JsonValue value) { throw null; }
    }
    public partial class JsonPrimitive : System.Json.JsonValue
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
        public JsonPrimitive(System.TimeSpan value) { }
        [System.CLSCompliantAttribute(false)]
        public JsonPrimitive(ushort value) { }
        [System.CLSCompliantAttribute(false)]
        public JsonPrimitive(uint value) { }
        [System.CLSCompliantAttribute(false)]
        public JsonPrimitive(ulong value) { }
        public JsonPrimitive(System.Uri value) { }
        public override System.Json.JsonType JsonType { get { throw null; } }
        public override void Save(System.IO.Stream stream) { }
    }
    public enum JsonType
    {
        Array = 3,
        Boolean = 4,
        Number = 1,
        Object = 2,
        String = 0,
    }
    public abstract partial class JsonValue : System.Collections.IEnumerable
    {
        protected JsonValue() { }
        public virtual int Count { get { throw null; } }
        public virtual System.Json.JsonValue this[int index] { get { throw null; } set { } }
        public virtual System.Json.JsonValue this[string key] { get { throw null; } set { } }
        public abstract System.Json.JsonType JsonType { get; }
        public virtual bool ContainsKey(string key) { throw null; }
        public static System.Json.JsonValue Load(System.IO.Stream stream) { throw null; }
        public static System.Json.JsonValue Load(System.IO.TextReader textReader) { throw null; }
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
        public static implicit operator bool (System.Json.JsonValue value) { throw null; }
        public static implicit operator byte (System.Json.JsonValue value) { throw null; }
        public static implicit operator char (System.Json.JsonValue value) { throw null; }
        public static implicit operator System.DateTime (System.Json.JsonValue value) { throw null; }
        public static implicit operator System.DateTimeOffset (System.Json.JsonValue value) { throw null; }
        public static implicit operator decimal (System.Json.JsonValue value) { throw null; }
        public static implicit operator double (System.Json.JsonValue value) { throw null; }
        public static implicit operator System.Guid (System.Json.JsonValue value) { throw null; }
        public static implicit operator short (System.Json.JsonValue value) { throw null; }
        public static implicit operator int (System.Json.JsonValue value) { throw null; }
        public static implicit operator long (System.Json.JsonValue value) { throw null; }
        [System.CLSCompliantAttribute(false)]
        public static implicit operator sbyte (System.Json.JsonValue value) { throw null; }
        public static implicit operator float (System.Json.JsonValue value) { throw null; }
        public static implicit operator string (System.Json.JsonValue value) { throw null; }
        public static implicit operator System.TimeSpan (System.Json.JsonValue value) { throw null; }
        [System.CLSCompliantAttribute(false)]
        public static implicit operator ushort (System.Json.JsonValue value) { throw null; }
        [System.CLSCompliantAttribute(false)]
        public static implicit operator uint (System.Json.JsonValue value) { throw null; }
        [System.CLSCompliantAttribute(false)]
        public static implicit operator ulong (System.Json.JsonValue value) { throw null; }
        public static implicit operator System.Uri (System.Json.JsonValue value) { throw null; }
        [System.CLSCompliantAttribute(false)]
        public static implicit operator System.Json.JsonValue (sbyte value) { throw null; }
        public static implicit operator System.Json.JsonValue (float value) { throw null; }
        public static implicit operator System.Json.JsonValue (string value) { throw null; }
        public static implicit operator System.Json.JsonValue (System.TimeSpan value) { throw null; }
        [System.CLSCompliantAttribute(false)]
        public static implicit operator System.Json.JsonValue (ushort value) { throw null; }
        [System.CLSCompliantAttribute(false)]
        public static implicit operator System.Json.JsonValue (uint value) { throw null; }
        [System.CLSCompliantAttribute(false)]
        public static implicit operator System.Json.JsonValue (ulong value) { throw null; }
        public static implicit operator System.Json.JsonValue (System.Uri value) { throw null; }
        public static System.Json.JsonValue Parse(string jsonString) { throw null; }
        public virtual void Save(System.IO.Stream stream) { }
        public virtual void Save(System.IO.TextWriter textWriter) { }
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { throw null; }
        public override string ToString() { throw null; }
    }
}
