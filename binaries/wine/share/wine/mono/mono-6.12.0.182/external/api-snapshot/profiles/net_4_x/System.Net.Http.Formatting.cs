// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

[assembly:System.Reflection.AssemblyVersionAttribute("4.0.0.0")]
[assembly:System.CLSCompliantAttribute(true)]
[assembly:System.Diagnostics.DebuggableAttribute(System.Diagnostics.DebuggableAttribute.DebuggingModes.IgnoreSymbolStoreSequencePoints)]
[assembly:System.Reflection.AssemblyCompanyAttribute("Microsoft Corporation")]
[assembly:System.Reflection.AssemblyConfigurationAttribute("")]
[assembly:System.Reflection.AssemblyCopyrightAttribute("© Microsoft Corporation. All rights reserved.")]
[assembly:System.Reflection.AssemblyDescriptionAttribute("")]
[assembly:System.Reflection.AssemblyFileVersionAttribute("4.0.0.0")]
[assembly:System.Reflection.AssemblyProductAttribute("Microsoft ASP.NET MVC")]
[assembly:System.Reflection.AssemblyTitleAttribute("System.Net.Http.Formatting")]
[assembly:System.Reflection.AssemblyTrademarkAttribute("")]
[assembly:System.Resources.NeutralResourcesLanguageAttribute("en-US")]
[assembly:System.Runtime.CompilerServices.CompilationRelaxationsAttribute(8)]
[assembly:System.Runtime.CompilerServices.InternalsVisibleToAttribute("System.Net.Http.Formatting.OData.Test.Unit, PublicKey=0024000004800000940000000602000000240000525341310004000001000100b5fc90e7027f67871e773a8fde8938c81dd402ba65b9201d60593e96c492651e889cc13f1415ebb53fac1131ae0bd333c5ee6021672d9718ea31a8aebd0da0072f25d87dba6fc90ffd598ed4da35e44c398c454307e8e33b8426143daec9f596836f97c8f74750e5975c64e2189f45def46b2a2b1247adc3652bf5c308055da9")]
[assembly:System.Runtime.CompilerServices.InternalsVisibleToAttribute("System.Net.Http.Formatting.Test, PublicKey=0024000004800000940000000602000000240000525341310004000001000100b5fc90e7027f67871e773a8fde8938c81dd402ba65b9201d60593e96c492651e889cc13f1415ebb53fac1131ae0bd333c5ee6021672d9718ea31a8aebd0da0072f25d87dba6fc90ffd598ed4da35e44c398c454307e8e33b8426143daec9f596836f97c8f74750e5975c64e2189f45def46b2a2b1247adc3652bf5c308055da9")]
[assembly:System.Runtime.CompilerServices.InternalsVisibleToAttribute("System.Net.Http.Formatting.Test.Integration, PublicKey=0024000004800000940000000602000000240000525341310004000001000100b5fc90e7027f67871e773a8fde8938c81dd402ba65b9201d60593e96c492651e889cc13f1415ebb53fac1131ae0bd333c5ee6021672d9718ea31a8aebd0da0072f25d87dba6fc90ffd598ed4da35e44c398c454307e8e33b8426143daec9f596836f97c8f74750e5975c64e2189f45def46b2a2b1247adc3652bf5c308055da9")]
[assembly:System.Runtime.CompilerServices.RuntimeCompatibilityAttribute(WrapNonExceptionThrows=true)]
[assembly:System.Runtime.InteropServices.ComVisibleAttribute(false)]
[assembly:System.Runtime.InteropServices.GuidAttribute("7fa1ae84-36e2-46b6-812c-c985a8e65e9a")]
[assembly:System.Security.SecurityTransparentAttribute]
namespace Newtonsoft.Json
{
    public enum ConstructorHandling
    {
        AllowNonPublicDefaultConstructor = 1,
        Default = 0,
    }
    public enum DateFormatHandling
    {
        IsoDateFormat = 0,
        MicrosoftDateFormat = 1,
    }
    public enum DateTimeZoneHandling
    {
        Local = 0,
        RoundtripKind = 3,
        Unspecified = 2,
        Utc = 1,
    }
    [System.FlagsAttribute]
    public enum DefaultValueHandling
    {
        Ignore = 1,
        IgnoreAndPopulate = 3,
        Include = 0,
        Populate = 2,
    }
    public enum Formatting
    {
        Indented = 1,
        None = 0,
    }
    public partial interface IJsonLineInfo
    {
        int LineNumber { get; }
        int LinePosition { get; }
        bool HasLineInfo();
    }
    [System.AttributeUsageAttribute(System.AttributeTargets.Class | System.AttributeTargets.Interface, AllowMultiple=false)]
    public sealed partial class JsonArrayAttribute : Newtonsoft.Json.JsonContainerAttribute
    {
        public JsonArrayAttribute() { }
        public JsonArrayAttribute(bool allowNullItems) { }
        public JsonArrayAttribute(string id) { }
        public bool AllowNullItems { get { throw null; } set { } }
    }
    [System.AttributeUsageAttribute(System.AttributeTargets.Constructor, AllowMultiple=false)]
    public sealed partial class JsonConstructorAttribute : System.Attribute
    {
        public JsonConstructorAttribute() { }
    }
    [System.AttributeUsageAttribute(System.AttributeTargets.Class | System.AttributeTargets.Interface, AllowMultiple=false)]
    public abstract partial class JsonContainerAttribute : System.Attribute
    {
        protected JsonContainerAttribute() { }
        protected JsonContainerAttribute(string id) { }
        public string Description { get { throw null; } set { } }
        public string Id { get { throw null; } set { } }
        public bool IsReference { get { throw null; } set { } }
        public string Title { get { throw null; } set { } }
    }
    public static partial class JsonConvert
    {
        public static readonly string False;
        public static readonly string NaN;
        public static readonly string NegativeInfinity;
        public static readonly string Null;
        public static readonly string PositiveInfinity;
        public static readonly string True;
        public static readonly string Undefined;
        public static T DeserializeAnonymousType<T>(string value, T anonymousTypeObject) { throw null; }
        public static object DeserializeObject(string value) { throw null; }
        public static object DeserializeObject(string value, Newtonsoft.Json.JsonSerializerSettings settings) { throw null; }
        public static object DeserializeObject(string value, System.Type type) { throw null; }
        public static object DeserializeObject(string value, System.Type type, params Newtonsoft.Json.JsonConverter[] converters) { throw null; }
        public static object DeserializeObject(string value, System.Type type, Newtonsoft.Json.JsonSerializerSettings settings) { throw null; }
        public static System.Threading.Tasks.Task<object> DeserializeObjectAsync(string value) { throw null; }
        public static System.Threading.Tasks.Task<object> DeserializeObjectAsync(string value, System.Type type, Newtonsoft.Json.JsonSerializerSettings settings) { throw null; }
        public static System.Threading.Tasks.Task<T> DeserializeObjectAsync<T>(string value) { throw null; }
        public static System.Threading.Tasks.Task<T> DeserializeObjectAsync<T>(string value, Newtonsoft.Json.JsonSerializerSettings settings) { throw null; }
        public static T DeserializeObject<T>(string value) { throw null; }
        public static T DeserializeObject<T>(string value, params Newtonsoft.Json.JsonConverter[] converters) { throw null; }
        public static T DeserializeObject<T>(string value, Newtonsoft.Json.JsonSerializerSettings settings) { throw null; }
        public static System.Xml.XmlDocument DeserializeXmlNode(string value) { throw null; }
        public static System.Xml.XmlDocument DeserializeXmlNode(string value, string deserializeRootElementName) { throw null; }
        public static System.Xml.XmlDocument DeserializeXmlNode(string value, string deserializeRootElementName, bool writeArrayAttribute) { throw null; }
        public static System.Xml.Linq.XDocument DeserializeXNode(string value) { throw null; }
        public static System.Xml.Linq.XDocument DeserializeXNode(string value, string deserializeRootElementName) { throw null; }
        public static System.Xml.Linq.XDocument DeserializeXNode(string value, string deserializeRootElementName, bool writeArrayAttribute) { throw null; }
        public static void PopulateObject(string value, object target) { }
        public static void PopulateObject(string value, object target, Newtonsoft.Json.JsonSerializerSettings settings) { }
        public static System.Threading.Tasks.Task PopulateObjectAsync(string value, object target, Newtonsoft.Json.JsonSerializerSettings settings) { throw null; }
        public static string SerializeObject(object value) { throw null; }
        public static string SerializeObject(object value, Newtonsoft.Json.Formatting formatting) { throw null; }
        public static string SerializeObject(object value, Newtonsoft.Json.Formatting formatting, params Newtonsoft.Json.JsonConverter[] converters) { throw null; }
        public static string SerializeObject(object value, Newtonsoft.Json.Formatting formatting, Newtonsoft.Json.JsonSerializerSettings settings) { throw null; }
        public static string SerializeObject(object value, params Newtonsoft.Json.JsonConverter[] converters) { throw null; }
        public static string SerializeObject(object value, Newtonsoft.Json.JsonSerializerSettings settings) { throw null; }
        public static System.Threading.Tasks.Task<string> SerializeObjectAsync(object value) { throw null; }
        public static System.Threading.Tasks.Task<string> SerializeObjectAsync(object value, Newtonsoft.Json.Formatting formatting) { throw null; }
        public static System.Threading.Tasks.Task<string> SerializeObjectAsync(object value, Newtonsoft.Json.Formatting formatting, Newtonsoft.Json.JsonSerializerSettings settings) { throw null; }
        public static string SerializeXmlNode(System.Xml.XmlNode node) { throw null; }
        public static string SerializeXmlNode(System.Xml.XmlNode node, Newtonsoft.Json.Formatting formatting) { throw null; }
        public static string SerializeXmlNode(System.Xml.XmlNode node, Newtonsoft.Json.Formatting formatting, bool omitRootObject) { throw null; }
        public static string SerializeXNode(System.Xml.Linq.XObject node) { throw null; }
        public static string SerializeXNode(System.Xml.Linq.XObject node, Newtonsoft.Json.Formatting formatting) { throw null; }
        public static string SerializeXNode(System.Xml.Linq.XObject node, Newtonsoft.Json.Formatting formatting, bool omitRootObject) { throw null; }
        public static string ToString(bool value) { throw null; }
        public static string ToString(byte value) { throw null; }
        public static string ToString(char value) { throw null; }
        public static string ToString(System.DateTime value) { throw null; }
        public static string ToString(System.DateTime value, Newtonsoft.Json.DateFormatHandling format, Newtonsoft.Json.DateTimeZoneHandling timeZoneHandling) { throw null; }
        public static string ToString(System.DateTimeOffset value) { throw null; }
        public static string ToString(System.DateTimeOffset value, Newtonsoft.Json.DateFormatHandling format) { throw null; }
        public static string ToString(decimal value) { throw null; }
        public static string ToString(double value) { throw null; }
        public static string ToString(System.Enum value) { throw null; }
        public static string ToString(System.Guid value) { throw null; }
        public static string ToString(short value) { throw null; }
        public static string ToString(int value) { throw null; }
        public static string ToString(long value) { throw null; }
        public static string ToString(object value) { throw null; }
        [System.CLSCompliantAttribute(false)]
        public static string ToString(sbyte value) { throw null; }
        public static string ToString(float value) { throw null; }
        public static string ToString(string value) { throw null; }
        public static string ToString(string value, char delimter) { throw null; }
        public static string ToString(System.TimeSpan value) { throw null; }
        [System.CLSCompliantAttribute(false)]
        public static string ToString(ushort value) { throw null; }
        [System.CLSCompliantAttribute(false)]
        public static string ToString(uint value) { throw null; }
        [System.CLSCompliantAttribute(false)]
        public static string ToString(ulong value) { throw null; }
        public static string ToString(System.Uri value) { throw null; }
    }
    public abstract partial class JsonConverter
    {
        protected JsonConverter() { }
        public virtual bool CanRead { get { throw null; } }
        public virtual bool CanWrite { get { throw null; } }
        public abstract bool CanConvert(System.Type objectType);
        public virtual Newtonsoft.Json.Schema.JsonSchema GetSchema() { throw null; }
        public abstract object ReadJson(Newtonsoft.Json.JsonReader reader, System.Type objectType, object existingValue, Newtonsoft.Json.JsonSerializer serializer);
        public abstract void WriteJson(Newtonsoft.Json.JsonWriter writer, object value, Newtonsoft.Json.JsonSerializer serializer);
    }
    [System.AttributeUsageAttribute(System.AttributeTargets.Class | System.AttributeTargets.Enum | System.AttributeTargets.Field | System.AttributeTargets.Interface | System.AttributeTargets.Parameter | System.AttributeTargets.Property | System.AttributeTargets.Struct, AllowMultiple=false)]
    public sealed partial class JsonConverterAttribute : System.Attribute
    {
        public JsonConverterAttribute(System.Type converterType) { }
        public System.Type ConverterType { get { throw null; } }
    }
    public partial class JsonConverterCollection : System.Collections.ObjectModel.Collection<Newtonsoft.Json.JsonConverter>
    {
        public JsonConverterCollection() { }
    }
    [System.AttributeUsageAttribute(System.AttributeTargets.Field | System.AttributeTargets.Property, AllowMultiple=false)]
    public sealed partial class JsonIgnoreAttribute : System.Attribute
    {
        public JsonIgnoreAttribute() { }
    }
    [System.AttributeUsageAttribute(System.AttributeTargets.Class | System.AttributeTargets.Interface | System.AttributeTargets.Struct, AllowMultiple=false)]
    public sealed partial class JsonObjectAttribute : Newtonsoft.Json.JsonContainerAttribute
    {
        public JsonObjectAttribute() { }
        public JsonObjectAttribute(Newtonsoft.Json.MemberSerialization memberSerialization) { }
        public JsonObjectAttribute(string id) { }
        public Newtonsoft.Json.MemberSerialization MemberSerialization { get { throw null; } set { } }
    }
    [System.AttributeUsageAttribute(System.AttributeTargets.Field | System.AttributeTargets.Parameter | System.AttributeTargets.Property, AllowMultiple=false)]
    public sealed partial class JsonPropertyAttribute : System.Attribute
    {
        public JsonPropertyAttribute() { }
        public JsonPropertyAttribute(string propertyName) { }
        public Newtonsoft.Json.DefaultValueHandling DefaultValueHandling { get { throw null; } set { } }
        public bool IsReference { get { throw null; } set { } }
        public Newtonsoft.Json.NullValueHandling NullValueHandling { get { throw null; } set { } }
        public Newtonsoft.Json.ObjectCreationHandling ObjectCreationHandling { get { throw null; } set { } }
        public int Order { get { throw null; } set { } }
        public string PropertyName { get { throw null; } set { } }
        public Newtonsoft.Json.ReferenceLoopHandling ReferenceLoopHandling { get { throw null; } set { } }
        public Newtonsoft.Json.Required Required { get { throw null; } set { } }
        public Newtonsoft.Json.TypeNameHandling TypeNameHandling { get { throw null; } set { } }
    }
    public abstract partial class JsonReader : System.IDisposable
    {
        protected JsonReader() { }
        public bool CloseInput { get { throw null; } set { } }
        public System.Globalization.CultureInfo Culture { get { throw null; } set { } }
        protected Newtonsoft.Json.JsonReader.State CurrentState { get { throw null; } }
        public Newtonsoft.Json.DateTimeZoneHandling DateTimeZoneHandling { get { throw null; } set { } }
        public virtual int Depth { get { throw null; } }
        public virtual string Path { get { throw null; } }
        public virtual char QuoteChar { get { throw null; } protected internal set { } }
        public virtual Newtonsoft.Json.JsonToken TokenType { get { throw null; } }
        public virtual object Value { get { throw null; } }
        public virtual System.Type ValueType { get { throw null; } }
        public virtual void Close() { }
        protected virtual void Dispose(bool disposing) { }
        public abstract bool Read();
        public abstract byte[] ReadAsBytes();
        public abstract System.Nullable<System.DateTime> ReadAsDateTime();
        public abstract System.Nullable<System.DateTimeOffset> ReadAsDateTimeOffset();
        public abstract System.Nullable<decimal> ReadAsDecimal();
        public abstract System.Nullable<int> ReadAsInt32();
        public abstract string ReadAsString();
        protected void SetStateBasedOnCurrent() { }
        protected void SetToken(Newtonsoft.Json.JsonToken newToken) { }
        protected void SetToken(Newtonsoft.Json.JsonToken newToken, object value) { }
        public void Skip() { }
        void System.IDisposable.Dispose() { }
        protected internal enum State
        {
            Array = 6,
            ArrayStart = 5,
            Closed = 7,
            Complete = 1,
            Constructor = 10,
            ConstructorStart = 9,
            Error = 11,
            Finished = 12,
            Object = 4,
            ObjectStart = 3,
            PostValue = 8,
            Property = 2,
            Start = 0,
        }
    }
    [System.SerializableAttribute]
    public partial class JsonReaderException : System.Exception
    {
        public JsonReaderException() { }
        public JsonReaderException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
        public JsonReaderException(string message) { }
        public JsonReaderException(string message, System.Exception innerException) { }
        public int LineNumber { get { throw null; } }
        public int LinePosition { get { throw null; } }
        public string Path { get { throw null; } }
    }
    [System.SerializableAttribute]
    public partial class JsonSerializationException : System.Exception
    {
        public JsonSerializationException() { }
        public JsonSerializationException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
        public JsonSerializationException(string message) { }
        public JsonSerializationException(string message, System.Exception innerException) { }
    }
    public partial class JsonSerializer
    {
        public JsonSerializer() { }
        public virtual System.Runtime.Serialization.SerializationBinder Binder { get { throw null; } set { } }
        public virtual Newtonsoft.Json.ConstructorHandling ConstructorHandling { get { throw null; } set { } }
        public virtual System.Runtime.Serialization.StreamingContext Context { get { throw null; } set { } }
        public virtual Newtonsoft.Json.Serialization.IContractResolver ContractResolver { get { throw null; } set { } }
        public virtual Newtonsoft.Json.JsonConverterCollection Converters { get { throw null; } }
        public virtual System.Globalization.CultureInfo Culture { get { throw null; } set { } }
        public virtual Newtonsoft.Json.DateFormatHandling DateFormatHandling { get { throw null; } set { } }
        public virtual Newtonsoft.Json.DateTimeZoneHandling DateTimeZoneHandling { get { throw null; } set { } }
        public virtual Newtonsoft.Json.DefaultValueHandling DefaultValueHandling { get { throw null; } set { } }
        public virtual Newtonsoft.Json.Formatting Formatting { get { throw null; } set { } }
        public virtual Newtonsoft.Json.MissingMemberHandling MissingMemberHandling { get { throw null; } set { } }
        public virtual Newtonsoft.Json.NullValueHandling NullValueHandling { get { throw null; } set { } }
        public virtual Newtonsoft.Json.ObjectCreationHandling ObjectCreationHandling { get { throw null; } set { } }
        public virtual Newtonsoft.Json.PreserveReferencesHandling PreserveReferencesHandling { get { throw null; } set { } }
        public virtual Newtonsoft.Json.ReferenceLoopHandling ReferenceLoopHandling { get { throw null; } set { } }
        public virtual Newtonsoft.Json.Serialization.IReferenceResolver ReferenceResolver { get { throw null; } set { } }
        public virtual System.Runtime.Serialization.Formatters.FormatterAssemblyStyle TypeNameAssemblyFormat { get { throw null; } set { } }
        public virtual Newtonsoft.Json.TypeNameHandling TypeNameHandling { get { throw null; } set { } }
        public virtual event System.EventHandler<Newtonsoft.Json.Serialization.ErrorEventArgs> Error { add { } remove { } }
        public static Newtonsoft.Json.JsonSerializer Create(Newtonsoft.Json.JsonSerializerSettings settings) { throw null; }
        public object Deserialize(Newtonsoft.Json.JsonReader reader) { throw null; }
        public object Deserialize(Newtonsoft.Json.JsonReader reader, System.Type objectType) { throw null; }
        public object Deserialize(System.IO.TextReader reader, System.Type objectType) { throw null; }
        public T Deserialize<T>(Newtonsoft.Json.JsonReader reader) { throw null; }
        public void Populate(Newtonsoft.Json.JsonReader reader, object target) { }
        public void Populate(System.IO.TextReader reader, object target) { }
        public void Serialize(Newtonsoft.Json.JsonWriter jsonWriter, object value) { }
        public void Serialize(System.IO.TextWriter textWriter, object value) { }
    }
    public partial class JsonSerializerSettings
    {
        public JsonSerializerSettings() { }
        public System.Runtime.Serialization.SerializationBinder Binder { get { throw null; } set { } }
        public Newtonsoft.Json.ConstructorHandling ConstructorHandling { get { throw null; } set { } }
        public System.Runtime.Serialization.StreamingContext Context { get { throw null; } set { } }
        public Newtonsoft.Json.Serialization.IContractResolver ContractResolver { get { throw null; } set { } }
        public System.Collections.Generic.IList<Newtonsoft.Json.JsonConverter> Converters { get { throw null; } set { } }
        public System.Globalization.CultureInfo Culture { get { throw null; } set { } }
        public Newtonsoft.Json.DateFormatHandling DateFormatHandling { get { throw null; } set { } }
        public Newtonsoft.Json.DateTimeZoneHandling DateTimeZoneHandling { get { throw null; } set { } }
        public Newtonsoft.Json.DefaultValueHandling DefaultValueHandling { get { throw null; } set { } }
        public System.EventHandler<Newtonsoft.Json.Serialization.ErrorEventArgs> Error { get { throw null; } set { } }
        public Newtonsoft.Json.Formatting Formatting { get { throw null; } set { } }
        public Newtonsoft.Json.MissingMemberHandling MissingMemberHandling { get { throw null; } set { } }
        public Newtonsoft.Json.NullValueHandling NullValueHandling { get { throw null; } set { } }
        public Newtonsoft.Json.ObjectCreationHandling ObjectCreationHandling { get { throw null; } set { } }
        public Newtonsoft.Json.PreserveReferencesHandling PreserveReferencesHandling { get { throw null; } set { } }
        public Newtonsoft.Json.ReferenceLoopHandling ReferenceLoopHandling { get { throw null; } set { } }
        public Newtonsoft.Json.Serialization.IReferenceResolver ReferenceResolver { get { throw null; } set { } }
        public System.Runtime.Serialization.Formatters.FormatterAssemblyStyle TypeNameAssemblyFormat { get { throw null; } set { } }
        public Newtonsoft.Json.TypeNameHandling TypeNameHandling { get { throw null; } set { } }
    }
    public partial class JsonTextReader : Newtonsoft.Json.JsonReader, Newtonsoft.Json.IJsonLineInfo
    {
        public JsonTextReader(System.IO.TextReader reader) { }
        public int LineNumber { get { throw null; } }
        public int LinePosition { get { throw null; } }
        public override void Close() { }
        public bool HasLineInfo() { throw null; }
        [System.Diagnostics.DebuggerStepThroughAttribute]
        public override bool Read() { throw null; }
        public override byte[] ReadAsBytes() { throw null; }
        public override System.Nullable<System.DateTime> ReadAsDateTime() { throw null; }
        public override System.Nullable<System.DateTimeOffset> ReadAsDateTimeOffset() { throw null; }
        public override System.Nullable<decimal> ReadAsDecimal() { throw null; }
        public override System.Nullable<int> ReadAsInt32() { throw null; }
        public override string ReadAsString() { throw null; }
    }
    public partial class JsonTextWriter : Newtonsoft.Json.JsonWriter
    {
        public JsonTextWriter(System.IO.TextWriter textWriter) { }
        public int Indentation { get { throw null; } set { } }
        public char IndentChar { get { throw null; } set { } }
        public char QuoteChar { get { throw null; } set { } }
        public bool QuoteName { get { throw null; } set { } }
        public override void Close() { }
        public override void Flush() { }
        public override void WriteComment(string text) { }
        protected override void WriteEnd(Newtonsoft.Json.JsonToken token) { }
        protected override void WriteIndent() { }
        protected override void WriteIndentSpace() { }
        public override void WriteNull() { }
        public override void WritePropertyName(string name) { }
        public override void WriteRaw(string json) { }
        public override void WriteStartArray() { }
        public override void WriteStartConstructor(string name) { }
        public override void WriteStartObject() { }
        public override void WriteUndefined() { }
        public override void WriteValue(bool value) { }
        public override void WriteValue(byte value) { }
        public override void WriteValue(byte[] value) { }
        public override void WriteValue(char value) { }
        public override void WriteValue(System.DateTime value) { }
        public override void WriteValue(System.DateTimeOffset value) { }
        public override void WriteValue(decimal value) { }
        public override void WriteValue(double value) { }
        public override void WriteValue(System.Guid value) { }
        public override void WriteValue(short value) { }
        public override void WriteValue(int value) { }
        public override void WriteValue(long value) { }
        [System.CLSCompliantAttribute(false)]
        public override void WriteValue(sbyte value) { }
        public override void WriteValue(float value) { }
        public override void WriteValue(string value) { }
        public override void WriteValue(System.TimeSpan value) { }
        [System.CLSCompliantAttribute(false)]
        public override void WriteValue(ushort value) { }
        [System.CLSCompliantAttribute(false)]
        public override void WriteValue(uint value) { }
        [System.CLSCompliantAttribute(false)]
        public override void WriteValue(ulong value) { }
        public override void WriteValue(System.Uri value) { }
        protected override void WriteValueDelimiter() { }
        public override void WriteWhitespace(string ws) { }
    }
    public enum JsonToken
    {
        Boolean = 10,
        Bytes = 17,
        Comment = 5,
        Date = 16,
        EndArray = 14,
        EndConstructor = 15,
        EndObject = 13,
        Float = 8,
        Integer = 7,
        None = 0,
        Null = 11,
        PropertyName = 4,
        Raw = 6,
        StartArray = 2,
        StartConstructor = 3,
        StartObject = 1,
        String = 9,
        Undefined = 12,
    }
    public partial class JsonValidatingReader : Newtonsoft.Json.JsonReader, Newtonsoft.Json.IJsonLineInfo
    {
        public JsonValidatingReader(Newtonsoft.Json.JsonReader reader) { }
        public override int Depth { get { throw null; } }
        int Newtonsoft.Json.IJsonLineInfo.LineNumber { get { throw null; } }
        int Newtonsoft.Json.IJsonLineInfo.LinePosition { get { throw null; } }
        public override string Path { get { throw null; } }
        public override char QuoteChar { get { throw null; } protected internal set { } }
        public Newtonsoft.Json.JsonReader Reader { get { throw null; } }
        public Newtonsoft.Json.Schema.JsonSchema Schema { get { throw null; } set { } }
        public override Newtonsoft.Json.JsonToken TokenType { get { throw null; } }
        public override object Value { get { throw null; } }
        public override System.Type ValueType { get { throw null; } }
        public event Newtonsoft.Json.Schema.ValidationEventHandler ValidationEventHandler { add { } remove { } }
        bool Newtonsoft.Json.IJsonLineInfo.HasLineInfo() { throw null; }
        public override bool Read() { throw null; }
        public override byte[] ReadAsBytes() { throw null; }
        public override System.Nullable<System.DateTime> ReadAsDateTime() { throw null; }
        public override System.Nullable<System.DateTimeOffset> ReadAsDateTimeOffset() { throw null; }
        public override System.Nullable<decimal> ReadAsDecimal() { throw null; }
        public override System.Nullable<int> ReadAsInt32() { throw null; }
        public override string ReadAsString() { throw null; }
    }
    public abstract partial class JsonWriter : System.IDisposable
    {
        protected JsonWriter() { }
        public bool CloseOutput { get { throw null; } set { } }
        public Newtonsoft.Json.DateFormatHandling DateFormatHandling { get { throw null; } set { } }
        public Newtonsoft.Json.DateTimeZoneHandling DateTimeZoneHandling { get { throw null; } set { } }
        public Newtonsoft.Json.Formatting Formatting { get { throw null; } set { } }
        public string Path { get { throw null; } }
        protected internal int Top { get { throw null; } }
        public Newtonsoft.Json.WriteState WriteState { get { throw null; } }
        public virtual void Close() { }
        public abstract void Flush();
        void System.IDisposable.Dispose() { }
        public virtual void WriteComment(string text) { }
        public virtual void WriteEnd() { }
        protected virtual void WriteEnd(Newtonsoft.Json.JsonToken token) { }
        public virtual void WriteEndArray() { }
        public virtual void WriteEndConstructor() { }
        public virtual void WriteEndObject() { }
        protected virtual void WriteIndent() { }
        protected virtual void WriteIndentSpace() { }
        public virtual void WriteNull() { }
        public virtual void WritePropertyName(string name) { }
        public virtual void WriteRaw(string json) { }
        public virtual void WriteRawValue(string json) { }
        public virtual void WriteStartArray() { }
        public virtual void WriteStartConstructor(string name) { }
        public virtual void WriteStartObject() { }
        public void WriteToken(Newtonsoft.Json.JsonReader reader) { }
        public virtual void WriteUndefined() { }
        public virtual void WriteValue(bool value) { }
        public virtual void WriteValue(byte value) { }
        public virtual void WriteValue(byte[] value) { }
        public virtual void WriteValue(char value) { }
        public virtual void WriteValue(System.DateTime value) { }
        public virtual void WriteValue(System.DateTimeOffset value) { }
        public virtual void WriteValue(decimal value) { }
        public virtual void WriteValue(double value) { }
        public virtual void WriteValue(System.Guid value) { }
        public virtual void WriteValue(short value) { }
        public virtual void WriteValue(int value) { }
        public virtual void WriteValue(long value) { }
        public virtual void WriteValue(System.Nullable<bool> value) { }
        public virtual void WriteValue(System.Nullable<byte> value) { }
        public virtual void WriteValue(System.Nullable<char> value) { }
        public virtual void WriteValue(System.Nullable<System.DateTimeOffset> value) { }
        public virtual void WriteValue(System.Nullable<System.DateTime> value) { }
        public virtual void WriteValue(System.Nullable<decimal> value) { }
        public virtual void WriteValue(System.Nullable<double> value) { }
        public virtual void WriteValue(System.Nullable<System.Guid> value) { }
        public virtual void WriteValue(System.Nullable<short> value) { }
        public virtual void WriteValue(System.Nullable<int> value) { }
        public virtual void WriteValue(System.Nullable<long> value) { }
        [System.CLSCompliantAttribute(false)]
        public virtual void WriteValue(System.Nullable<sbyte> value) { }
        public virtual void WriteValue(System.Nullable<float> value) { }
        public virtual void WriteValue(System.Nullable<System.TimeSpan> value) { }
        [System.CLSCompliantAttribute(false)]
        public virtual void WriteValue(System.Nullable<ushort> value) { }
        [System.CLSCompliantAttribute(false)]
        public virtual void WriteValue(System.Nullable<uint> value) { }
        [System.CLSCompliantAttribute(false)]
        public virtual void WriteValue(System.Nullable<ulong> value) { }
        public virtual void WriteValue(object value) { }
        [System.CLSCompliantAttribute(false)]
        public virtual void WriteValue(sbyte value) { }
        public virtual void WriteValue(float value) { }
        public virtual void WriteValue(string value) { }
        public virtual void WriteValue(System.TimeSpan value) { }
        [System.CLSCompliantAttribute(false)]
        public virtual void WriteValue(ushort value) { }
        [System.CLSCompliantAttribute(false)]
        public virtual void WriteValue(uint value) { }
        [System.CLSCompliantAttribute(false)]
        public virtual void WriteValue(ulong value) { }
        public virtual void WriteValue(System.Uri value) { }
        protected virtual void WriteValueDelimiter() { }
        public virtual void WriteWhitespace(string ws) { }
    }
    [System.SerializableAttribute]
    public partial class JsonWriterException : System.Exception
    {
        public JsonWriterException() { }
        public JsonWriterException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
        public JsonWriterException(string message) { }
        public JsonWriterException(string message, System.Exception innerException) { }
    }
    public enum MemberSerialization
    {
        OptIn = 1,
        OptOut = 0,
    }
    public enum MissingMemberHandling
    {
        Error = 1,
        Ignore = 0,
    }
    public enum NullValueHandling
    {
        Ignore = 1,
        Include = 0,
    }
    public enum ObjectCreationHandling
    {
        Auto = 0,
        Replace = 2,
        Reuse = 1,
    }
    [System.FlagsAttribute]
    public enum PreserveReferencesHandling
    {
        All = 3,
        Arrays = 2,
        None = 0,
        Objects = 1,
    }
    public enum ReferenceLoopHandling
    {
        Error = 0,
        Ignore = 1,
        Serialize = 2,
    }
    public enum Required
    {
        AllowNull = 1,
        Always = 2,
        Default = 0,
    }
    [System.FlagsAttribute]
    public enum TypeNameHandling
    {
        All = 3,
        Arrays = 2,
        Auto = 4,
        None = 0,
        Objects = 1,
    }
    public enum WriteState
    {
        Array = 3,
        Closed = 1,
        Constructor = 4,
        Error = 0,
        Object = 2,
        Property = 5,
        Start = 6,
    }
}
namespace Newtonsoft.Json.Bson
{
    public partial class BsonObjectId
    {
        public BsonObjectId(byte[] value) { }
        public byte[] Value { get { throw null; } }
    }
    public partial class BsonReader : Newtonsoft.Json.JsonReader
    {
        public BsonReader(System.IO.BinaryReader reader) { }
        public BsonReader(System.IO.BinaryReader reader, bool readRootValueAsArray, System.DateTimeKind dateTimeKindHandling) { }
        public BsonReader(System.IO.Stream stream) { }
        public BsonReader(System.IO.Stream stream, bool readRootValueAsArray, System.DateTimeKind dateTimeKindHandling) { }
        public System.DateTimeKind DateTimeKindHandling { get { throw null; } set { } }
        public bool JsonNet35BinaryCompatibility { get { throw null; } set { } }
        public bool ReadRootValueAsArray { get { throw null; } set { } }
        public override void Close() { }
        public override bool Read() { throw null; }
        public override byte[] ReadAsBytes() { throw null; }
        public override System.Nullable<System.DateTime> ReadAsDateTime() { throw null; }
        public override System.Nullable<System.DateTimeOffset> ReadAsDateTimeOffset() { throw null; }
        public override System.Nullable<decimal> ReadAsDecimal() { throw null; }
        public override System.Nullable<int> ReadAsInt32() { throw null; }
        public override string ReadAsString() { throw null; }
    }
    public partial class BsonWriter : Newtonsoft.Json.JsonWriter
    {
        public BsonWriter(System.IO.BinaryWriter writer) { }
        public BsonWriter(System.IO.Stream stream) { }
        public System.DateTimeKind DateTimeKindHandling { get { throw null; } set { } }
        public override void Close() { }
        public override void Flush() { }
        public override void WriteComment(string text) { }
        protected override void WriteEnd(Newtonsoft.Json.JsonToken token) { }
        public override void WriteNull() { }
        public void WriteObjectId(byte[] value) { }
        public override void WritePropertyName(string name) { }
        public override void WriteRaw(string json) { }
        public override void WriteRawValue(string json) { }
        public void WriteRegex(string pattern, string options) { }
        public override void WriteStartArray() { }
        public override void WriteStartConstructor(string name) { }
        public override void WriteStartObject() { }
        public override void WriteUndefined() { }
        public override void WriteValue(bool value) { }
        public override void WriteValue(byte value) { }
        public override void WriteValue(byte[] value) { }
        public override void WriteValue(char value) { }
        public override void WriteValue(System.DateTime value) { }
        public override void WriteValue(System.DateTimeOffset value) { }
        public override void WriteValue(decimal value) { }
        public override void WriteValue(double value) { }
        public override void WriteValue(System.Guid value) { }
        public override void WriteValue(short value) { }
        public override void WriteValue(int value) { }
        public override void WriteValue(long value) { }
        [System.CLSCompliantAttribute(false)]
        public override void WriteValue(sbyte value) { }
        public override void WriteValue(float value) { }
        public override void WriteValue(string value) { }
        public override void WriteValue(System.TimeSpan value) { }
        [System.CLSCompliantAttribute(false)]
        public override void WriteValue(ushort value) { }
        [System.CLSCompliantAttribute(false)]
        public override void WriteValue(uint value) { }
        [System.CLSCompliantAttribute(false)]
        public override void WriteValue(ulong value) { }
        public override void WriteValue(System.Uri value) { }
    }
}
namespace Newtonsoft.Json.Converters
{
    public partial class BinaryConverter : Newtonsoft.Json.JsonConverter
    {
        public BinaryConverter() { }
        public override bool CanConvert(System.Type objectType) { throw null; }
        public override object ReadJson(Newtonsoft.Json.JsonReader reader, System.Type objectType, object existingValue, Newtonsoft.Json.JsonSerializer serializer) { throw null; }
        public override void WriteJson(Newtonsoft.Json.JsonWriter writer, object value, Newtonsoft.Json.JsonSerializer serializer) { }
    }
    public partial class BsonObjectIdConverter : Newtonsoft.Json.JsonConverter
    {
        public BsonObjectIdConverter() { }
        public override bool CanConvert(System.Type objectType) { throw null; }
        public override object ReadJson(Newtonsoft.Json.JsonReader reader, System.Type objectType, object existingValue, Newtonsoft.Json.JsonSerializer serializer) { throw null; }
        public override void WriteJson(Newtonsoft.Json.JsonWriter writer, object value, Newtonsoft.Json.JsonSerializer serializer) { }
    }
    public abstract partial class CustomCreationConverter<T> : Newtonsoft.Json.JsonConverter
    {
        protected CustomCreationConverter() { }
        public override bool CanWrite { get { throw null; } }
        public override bool CanConvert(System.Type objectType) { throw null; }
        public abstract T Create(System.Type objectType);
        public override object ReadJson(Newtonsoft.Json.JsonReader reader, System.Type objectType, object existingValue, Newtonsoft.Json.JsonSerializer serializer) { throw null; }
        public override void WriteJson(Newtonsoft.Json.JsonWriter writer, object value, Newtonsoft.Json.JsonSerializer serializer) { }
    }
    public partial class DataSetConverter : Newtonsoft.Json.JsonConverter
    {
        public DataSetConverter() { }
        public override bool CanConvert(System.Type valueType) { throw null; }
        public override object ReadJson(Newtonsoft.Json.JsonReader reader, System.Type objectType, object existingValue, Newtonsoft.Json.JsonSerializer serializer) { throw null; }
        public override void WriteJson(Newtonsoft.Json.JsonWriter writer, object value, Newtonsoft.Json.JsonSerializer serializer) { }
    }
    public partial class DataTableConverter : Newtonsoft.Json.JsonConverter
    {
        public DataTableConverter() { }
        public override bool CanConvert(System.Type valueType) { throw null; }
        public override object ReadJson(Newtonsoft.Json.JsonReader reader, System.Type objectType, object existingValue, Newtonsoft.Json.JsonSerializer serializer) { throw null; }
        public override void WriteJson(Newtonsoft.Json.JsonWriter writer, object value, Newtonsoft.Json.JsonSerializer serializer) { }
    }
    public abstract partial class DateTimeConverterBase : Newtonsoft.Json.JsonConverter
    {
        protected DateTimeConverterBase() { }
        public override bool CanConvert(System.Type objectType) { throw null; }
    }
    public partial class EntityKeyMemberConverter : Newtonsoft.Json.JsonConverter
    {
        public EntityKeyMemberConverter() { }
        public override bool CanConvert(System.Type objectType) { throw null; }
        public override object ReadJson(Newtonsoft.Json.JsonReader reader, System.Type objectType, object existingValue, Newtonsoft.Json.JsonSerializer serializer) { throw null; }
        public override void WriteJson(Newtonsoft.Json.JsonWriter writer, object value, Newtonsoft.Json.JsonSerializer serializer) { }
    }
    public partial class ExpandoObjectConverter : Newtonsoft.Json.JsonConverter
    {
        public ExpandoObjectConverter() { }
        public override bool CanWrite { get { throw null; } }
        public override bool CanConvert(System.Type objectType) { throw null; }
        public override object ReadJson(Newtonsoft.Json.JsonReader reader, System.Type objectType, object existingValue, Newtonsoft.Json.JsonSerializer serializer) { throw null; }
        public override void WriteJson(Newtonsoft.Json.JsonWriter writer, object value, Newtonsoft.Json.JsonSerializer serializer) { }
    }
    public partial class IsoDateTimeConverter : Newtonsoft.Json.Converters.DateTimeConverterBase
    {
        public IsoDateTimeConverter() { }
        public System.Globalization.CultureInfo Culture { get { throw null; } set { } }
        public string DateTimeFormat { get { throw null; } set { } }
        public System.Globalization.DateTimeStyles DateTimeStyles { get { throw null; } set { } }
        public override object ReadJson(Newtonsoft.Json.JsonReader reader, System.Type objectType, object existingValue, Newtonsoft.Json.JsonSerializer serializer) { throw null; }
        public override void WriteJson(Newtonsoft.Json.JsonWriter writer, object value, Newtonsoft.Json.JsonSerializer serializer) { }
    }
    public partial class JavaScriptDateTimeConverter : Newtonsoft.Json.Converters.DateTimeConverterBase
    {
        public JavaScriptDateTimeConverter() { }
        public override object ReadJson(Newtonsoft.Json.JsonReader reader, System.Type objectType, object existingValue, Newtonsoft.Json.JsonSerializer serializer) { throw null; }
        public override void WriteJson(Newtonsoft.Json.JsonWriter writer, object value, Newtonsoft.Json.JsonSerializer serializer) { }
    }
    public partial class KeyValuePairConverter : Newtonsoft.Json.JsonConverter
    {
        public KeyValuePairConverter() { }
        public override bool CanConvert(System.Type objectType) { throw null; }
        public override object ReadJson(Newtonsoft.Json.JsonReader reader, System.Type objectType, object existingValue, Newtonsoft.Json.JsonSerializer serializer) { throw null; }
        public override void WriteJson(Newtonsoft.Json.JsonWriter writer, object value, Newtonsoft.Json.JsonSerializer serializer) { }
    }
    public partial class RegexConverter : Newtonsoft.Json.JsonConverter
    {
        public RegexConverter() { }
        public override bool CanConvert(System.Type objectType) { throw null; }
        public override object ReadJson(Newtonsoft.Json.JsonReader reader, System.Type objectType, object existingValue, Newtonsoft.Json.JsonSerializer serializer) { throw null; }
        public override void WriteJson(Newtonsoft.Json.JsonWriter writer, object value, Newtonsoft.Json.JsonSerializer serializer) { }
    }
    public partial class StringEnumConverter : Newtonsoft.Json.JsonConverter
    {
        public StringEnumConverter() { }
        public bool CamelCaseText { get { throw null; } set { } }
        public override bool CanConvert(System.Type objectType) { throw null; }
        public override object ReadJson(Newtonsoft.Json.JsonReader reader, System.Type objectType, object existingValue, Newtonsoft.Json.JsonSerializer serializer) { throw null; }
        public override void WriteJson(Newtonsoft.Json.JsonWriter writer, object value, Newtonsoft.Json.JsonSerializer serializer) { }
    }
    public partial class VersionConverter : Newtonsoft.Json.JsonConverter
    {
        public VersionConverter() { }
        public override bool CanConvert(System.Type objectType) { throw null; }
        public override object ReadJson(Newtonsoft.Json.JsonReader reader, System.Type objectType, object existingValue, Newtonsoft.Json.JsonSerializer serializer) { throw null; }
        public override void WriteJson(Newtonsoft.Json.JsonWriter writer, object value, Newtonsoft.Json.JsonSerializer serializer) { }
    }
    public partial class XmlNodeConverter : Newtonsoft.Json.JsonConverter
    {
        public XmlNodeConverter() { }
        public string DeserializeRootElementName { get { throw null; } set { } }
        public bool OmitRootObject { get { throw null; } set { } }
        public bool WriteArrayAttribute { get { throw null; } set { } }
        public override bool CanConvert(System.Type valueType) { throw null; }
        public override object ReadJson(Newtonsoft.Json.JsonReader reader, System.Type objectType, object existingValue, Newtonsoft.Json.JsonSerializer serializer) { throw null; }
        public override void WriteJson(Newtonsoft.Json.JsonWriter writer, object value, Newtonsoft.Json.JsonSerializer serializer) { }
    }
}
namespace Newtonsoft.Json.Linq
{
    public static partial class Extensions
    {
        public static Newtonsoft.Json.Linq.IJEnumerable<Newtonsoft.Json.Linq.JToken> Ancestors<T>(this System.Collections.Generic.IEnumerable<T> source) where T : Newtonsoft.Json.Linq.JToken { throw null; }
        public static Newtonsoft.Json.Linq.IJEnumerable<Newtonsoft.Json.Linq.JToken> AsJEnumerable(this System.Collections.Generic.IEnumerable<Newtonsoft.Json.Linq.JToken> source) { throw null; }
        public static Newtonsoft.Json.Linq.IJEnumerable<T> AsJEnumerable<T>(this System.Collections.Generic.IEnumerable<T> source) where T : Newtonsoft.Json.Linq.JToken { throw null; }
        public static Newtonsoft.Json.Linq.IJEnumerable<Newtonsoft.Json.Linq.JToken> Children<T>(this System.Collections.Generic.IEnumerable<T> source) where T : Newtonsoft.Json.Linq.JToken { throw null; }
        public static System.Collections.Generic.IEnumerable<U> Children<T, U>(this System.Collections.Generic.IEnumerable<T> source) where T : Newtonsoft.Json.Linq.JToken { throw null; }
        public static Newtonsoft.Json.Linq.IJEnumerable<Newtonsoft.Json.Linq.JToken> Descendants<T>(this System.Collections.Generic.IEnumerable<T> source) where T : Newtonsoft.Json.Linq.JContainer { throw null; }
        public static Newtonsoft.Json.Linq.IJEnumerable<Newtonsoft.Json.Linq.JProperty> Properties(this System.Collections.Generic.IEnumerable<Newtonsoft.Json.Linq.JObject> source) { throw null; }
        public static Newtonsoft.Json.Linq.IJEnumerable<Newtonsoft.Json.Linq.JToken> Values(this System.Collections.Generic.IEnumerable<Newtonsoft.Json.Linq.JToken> source) { throw null; }
        public static Newtonsoft.Json.Linq.IJEnumerable<Newtonsoft.Json.Linq.JToken> Values(this System.Collections.Generic.IEnumerable<Newtonsoft.Json.Linq.JToken> source, object key) { throw null; }
        public static System.Collections.Generic.IEnumerable<U> Values<U>(this System.Collections.Generic.IEnumerable<Newtonsoft.Json.Linq.JToken> source) { throw null; }
        public static System.Collections.Generic.IEnumerable<U> Values<U>(this System.Collections.Generic.IEnumerable<Newtonsoft.Json.Linq.JToken> source, object key) { throw null; }
        public static U Value<U>(this System.Collections.Generic.IEnumerable<Newtonsoft.Json.Linq.JToken> value) { throw null; }
        public static U Value<T, U>(this System.Collections.Generic.IEnumerable<T> value) where T : Newtonsoft.Json.Linq.JToken { throw null; }
    }
    public partial interface IJEnumerable<out T> : System.Collections.Generic.IEnumerable<T>, System.Collections.IEnumerable where T : Newtonsoft.Json.Linq.JToken
    {
        Newtonsoft.Json.Linq.IJEnumerable<Newtonsoft.Json.Linq.JToken> this[object key] { get; }
    }
    public partial class JArray : Newtonsoft.Json.Linq.JContainer, System.Collections.Generic.ICollection<Newtonsoft.Json.Linq.JToken>, System.Collections.Generic.IEnumerable<Newtonsoft.Json.Linq.JToken>, System.Collections.Generic.IList<Newtonsoft.Json.Linq.JToken>, System.Collections.IEnumerable
    {
        public JArray() { }
        public JArray(Newtonsoft.Json.Linq.JArray other) { }
        public JArray(object content) { }
        public JArray(params object[] content) { }
        protected override System.Collections.Generic.IList<Newtonsoft.Json.Linq.JToken> ChildrenTokens { get { throw null; } }
        public Newtonsoft.Json.Linq.JToken this[int index] { get { throw null; } set { } }
        public override Newtonsoft.Json.Linq.JToken this[object key] { get { throw null; } set { } }
        bool System.Collections.Generic.ICollection<Newtonsoft.Json.Linq.JToken>.IsReadOnly { get { throw null; } }
        public override Newtonsoft.Json.Linq.JTokenType Type { get { throw null; } }
        public void Add(Newtonsoft.Json.Linq.JToken item) { }
        public void Clear() { }
        public bool Contains(Newtonsoft.Json.Linq.JToken item) { throw null; }
        public static new Newtonsoft.Json.Linq.JArray FromObject(object o) { throw null; }
        public static new Newtonsoft.Json.Linq.JArray FromObject(object o, Newtonsoft.Json.JsonSerializer jsonSerializer) { throw null; }
        public int IndexOf(Newtonsoft.Json.Linq.JToken item) { throw null; }
        public void Insert(int index, Newtonsoft.Json.Linq.JToken item) { }
        public static new Newtonsoft.Json.Linq.JArray Load(Newtonsoft.Json.JsonReader reader) { throw null; }
        public static new Newtonsoft.Json.Linq.JArray Parse(string json) { throw null; }
        public bool Remove(Newtonsoft.Json.Linq.JToken item) { throw null; }
        public void RemoveAt(int index) { }
        void System.Collections.Generic.ICollection<Newtonsoft.Json.Linq.JToken>.CopyTo(Newtonsoft.Json.Linq.JToken[] array, int arrayIndex) { }
        public override void WriteTo(Newtonsoft.Json.JsonWriter writer, params Newtonsoft.Json.JsonConverter[] converters) { }
    }
    public partial class JConstructor : Newtonsoft.Json.Linq.JContainer
    {
        public JConstructor() { }
        public JConstructor(Newtonsoft.Json.Linq.JConstructor other) { }
        public JConstructor(string name) { }
        public JConstructor(string name, object content) { }
        public JConstructor(string name, params object[] content) { }
        protected override System.Collections.Generic.IList<Newtonsoft.Json.Linq.JToken> ChildrenTokens { get { throw null; } }
        public override Newtonsoft.Json.Linq.JToken this[object key] { get { throw null; } set { } }
        public string Name { get { throw null; } set { } }
        public override Newtonsoft.Json.Linq.JTokenType Type { get { throw null; } }
        public static new Newtonsoft.Json.Linq.JConstructor Load(Newtonsoft.Json.JsonReader reader) { throw null; }
        public override void WriteTo(Newtonsoft.Json.JsonWriter writer, params Newtonsoft.Json.JsonConverter[] converters) { }
    }
    public abstract partial class JContainer : Newtonsoft.Json.Linq.JToken, System.Collections.Generic.ICollection<Newtonsoft.Json.Linq.JToken>, System.Collections.Generic.IEnumerable<Newtonsoft.Json.Linq.JToken>, System.Collections.Generic.IList<Newtonsoft.Json.Linq.JToken>, System.Collections.ICollection, System.Collections.IEnumerable, System.Collections.IList, System.Collections.Specialized.INotifyCollectionChanged, System.ComponentModel.IBindingList, System.ComponentModel.ITypedList
    {
        internal JContainer() { }
        protected abstract System.Collections.Generic.IList<Newtonsoft.Json.Linq.JToken> ChildrenTokens { get; }
        public int Count { get { throw null; } }
        public override Newtonsoft.Json.Linq.JToken First { get { throw null; } }
        public override bool HasValues { get { throw null; } }
        public override Newtonsoft.Json.Linq.JToken Last { get { throw null; } }
        bool System.Collections.Generic.ICollection<Newtonsoft.Json.Linq.JToken>.IsReadOnly { get { throw null; } }
        Newtonsoft.Json.Linq.JToken System.Collections.Generic.IList<Newtonsoft.Json.Linq.JToken>.this[int index] { get { throw null; } set { } }
        bool System.Collections.ICollection.IsSynchronized { get { throw null; } }
        object System.Collections.ICollection.SyncRoot { get { throw null; } }
        bool System.Collections.IList.IsFixedSize { get { throw null; } }
        bool System.Collections.IList.IsReadOnly { get { throw null; } }
        object System.Collections.IList.this[int index] { get { throw null; } set { } }
        bool System.ComponentModel.IBindingList.AllowEdit { get { throw null; } }
        bool System.ComponentModel.IBindingList.AllowNew { get { throw null; } }
        bool System.ComponentModel.IBindingList.AllowRemove { get { throw null; } }
        bool System.ComponentModel.IBindingList.IsSorted { get { throw null; } }
        System.ComponentModel.ListSortDirection System.ComponentModel.IBindingList.SortDirection { get { throw null; } }
        System.ComponentModel.PropertyDescriptor System.ComponentModel.IBindingList.SortProperty { get { throw null; } }
        bool System.ComponentModel.IBindingList.SupportsChangeNotification { get { throw null; } }
        bool System.ComponentModel.IBindingList.SupportsSearching { get { throw null; } }
        bool System.ComponentModel.IBindingList.SupportsSorting { get { throw null; } }
        public event System.ComponentModel.AddingNewEventHandler AddingNew { add { } remove { } }
        public event System.Collections.Specialized.NotifyCollectionChangedEventHandler CollectionChanged { add { } remove { } }
        public event System.ComponentModel.ListChangedEventHandler ListChanged { add { } remove { } }
        public virtual void Add(object content) { }
        public void AddFirst(object content) { }
        public override Newtonsoft.Json.Linq.JEnumerable<Newtonsoft.Json.Linq.JToken> Children() { throw null; }
        public Newtonsoft.Json.JsonWriter CreateWriter() { throw null; }
        public System.Collections.Generic.IEnumerable<Newtonsoft.Json.Linq.JToken> Descendants() { throw null; }
        protected virtual void OnAddingNew(System.ComponentModel.AddingNewEventArgs e) { }
        protected virtual void OnCollectionChanged(System.Collections.Specialized.NotifyCollectionChangedEventArgs e) { }
        protected virtual void OnListChanged(System.ComponentModel.ListChangedEventArgs e) { }
        public void RemoveAll() { }
        public void ReplaceAll(object content) { }
        void System.Collections.Generic.ICollection<Newtonsoft.Json.Linq.JToken>.Add(Newtonsoft.Json.Linq.JToken item) { }
        void System.Collections.Generic.ICollection<Newtonsoft.Json.Linq.JToken>.Clear() { }
        bool System.Collections.Generic.ICollection<Newtonsoft.Json.Linq.JToken>.Contains(Newtonsoft.Json.Linq.JToken item) { throw null; }
        void System.Collections.Generic.ICollection<Newtonsoft.Json.Linq.JToken>.CopyTo(Newtonsoft.Json.Linq.JToken[] array, int arrayIndex) { }
        bool System.Collections.Generic.ICollection<Newtonsoft.Json.Linq.JToken>.Remove(Newtonsoft.Json.Linq.JToken item) { throw null; }
        int System.Collections.Generic.IList<Newtonsoft.Json.Linq.JToken>.IndexOf(Newtonsoft.Json.Linq.JToken item) { throw null; }
        void System.Collections.Generic.IList<Newtonsoft.Json.Linq.JToken>.Insert(int index, Newtonsoft.Json.Linq.JToken item) { }
        void System.Collections.Generic.IList<Newtonsoft.Json.Linq.JToken>.RemoveAt(int index) { }
        void System.Collections.ICollection.CopyTo(System.Array array, int index) { }
        int System.Collections.IList.Add(object value) { throw null; }
        void System.Collections.IList.Clear() { }
        bool System.Collections.IList.Contains(object value) { throw null; }
        int System.Collections.IList.IndexOf(object value) { throw null; }
        void System.Collections.IList.Insert(int index, object value) { }
        void System.Collections.IList.Remove(object value) { }
        void System.Collections.IList.RemoveAt(int index) { }
        void System.ComponentModel.IBindingList.AddIndex(System.ComponentModel.PropertyDescriptor property) { }
        object System.ComponentModel.IBindingList.AddNew() { throw null; }
        void System.ComponentModel.IBindingList.ApplySort(System.ComponentModel.PropertyDescriptor property, System.ComponentModel.ListSortDirection direction) { }
        int System.ComponentModel.IBindingList.Find(System.ComponentModel.PropertyDescriptor property, object key) { throw null; }
        void System.ComponentModel.IBindingList.RemoveIndex(System.ComponentModel.PropertyDescriptor property) { }
        void System.ComponentModel.IBindingList.RemoveSort() { }
        System.ComponentModel.PropertyDescriptorCollection System.ComponentModel.ITypedList.GetItemProperties(System.ComponentModel.PropertyDescriptor[] listAccessors) { throw null; }
        string System.ComponentModel.ITypedList.GetListName(System.ComponentModel.PropertyDescriptor[] listAccessors) { throw null; }
        public override System.Collections.Generic.IEnumerable<T> Values<T>() { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public partial struct JEnumerable<T> : Newtonsoft.Json.Linq.IJEnumerable<T>, System.Collections.Generic.IEnumerable<T>, System.Collections.IEnumerable where T : Newtonsoft.Json.Linq.JToken
    {
        private object _dummy;
        public static readonly Newtonsoft.Json.Linq.JEnumerable<T> Empty;
        public JEnumerable(System.Collections.Generic.IEnumerable<T> enumerable) { throw null; }
        public Newtonsoft.Json.Linq.IJEnumerable<Newtonsoft.Json.Linq.JToken> this[object key] { get { throw null; } }
        public override bool Equals(object obj) { throw null; }
        public System.Collections.Generic.IEnumerator<T> GetEnumerator() { throw null; }
        public override int GetHashCode() { throw null; }
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { throw null; }
    }
    public partial class JObject : Newtonsoft.Json.Linq.JContainer, System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<string, Newtonsoft.Json.Linq.JToken>>, System.Collections.Generic.IDictionary<string, Newtonsoft.Json.Linq.JToken>, System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<string, Newtonsoft.Json.Linq.JToken>>, System.Collections.IEnumerable, System.ComponentModel.ICustomTypeDescriptor, System.ComponentModel.INotifyPropertyChanged, System.ComponentModel.INotifyPropertyChanging
    {
        public JObject() { }
        public JObject(Newtonsoft.Json.Linq.JObject other) { }
        public JObject(object content) { }
        public JObject(params object[] content) { }
        protected override System.Collections.Generic.IList<Newtonsoft.Json.Linq.JToken> ChildrenTokens { get { throw null; } }
        public override Newtonsoft.Json.Linq.JToken this[object key] { get { throw null; } set { } }
        public Newtonsoft.Json.Linq.JToken this[string propertyName] { get { throw null; } set { } }
        bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,Newtonsoft.Json.Linq.JToken>>.IsReadOnly { get { throw null; } }
        System.Collections.Generic.ICollection<string> System.Collections.Generic.IDictionary<System.String,Newtonsoft.Json.Linq.JToken>.Keys { get { throw null; } }
        System.Collections.Generic.ICollection<Newtonsoft.Json.Linq.JToken> System.Collections.Generic.IDictionary<System.String,Newtonsoft.Json.Linq.JToken>.Values { get { throw null; } }
        public override Newtonsoft.Json.Linq.JTokenType Type { get { throw null; } }
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged { add { } remove { } }
        public event System.ComponentModel.PropertyChangingEventHandler PropertyChanging { add { } remove { } }
        public void Add(string propertyName, Newtonsoft.Json.Linq.JToken value) { }
        public static new Newtonsoft.Json.Linq.JObject FromObject(object o) { throw null; }
        public static new Newtonsoft.Json.Linq.JObject FromObject(object o, Newtonsoft.Json.JsonSerializer jsonSerializer) { throw null; }
        public System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<string, Newtonsoft.Json.Linq.JToken>> GetEnumerator() { throw null; }
        protected override System.Dynamic.DynamicMetaObject GetMetaObject(System.Linq.Expressions.Expression parameter) { throw null; }
        public static new Newtonsoft.Json.Linq.JObject Load(Newtonsoft.Json.JsonReader reader) { throw null; }
        protected virtual void OnPropertyChanged(string propertyName) { }
        protected virtual void OnPropertyChanging(string propertyName) { }
        public static new Newtonsoft.Json.Linq.JObject Parse(string json) { throw null; }
        public System.Collections.Generic.IEnumerable<Newtonsoft.Json.Linq.JProperty> Properties() { throw null; }
        public Newtonsoft.Json.Linq.JProperty Property(string name) { throw null; }
        public Newtonsoft.Json.Linq.JEnumerable<Newtonsoft.Json.Linq.JToken> PropertyValues() { throw null; }
        public bool Remove(string propertyName) { throw null; }
        void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,Newtonsoft.Json.Linq.JToken>>.Add(System.Collections.Generic.KeyValuePair<string, Newtonsoft.Json.Linq.JToken> item) { }
        void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,Newtonsoft.Json.Linq.JToken>>.Clear() { }
        bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,Newtonsoft.Json.Linq.JToken>>.Contains(System.Collections.Generic.KeyValuePair<string, Newtonsoft.Json.Linq.JToken> item) { throw null; }
        void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,Newtonsoft.Json.Linq.JToken>>.CopyTo(System.Collections.Generic.KeyValuePair<string, Newtonsoft.Json.Linq.JToken>[] array, int arrayIndex) { }
        bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,Newtonsoft.Json.Linq.JToken>>.Remove(System.Collections.Generic.KeyValuePair<string, Newtonsoft.Json.Linq.JToken> item) { throw null; }
        bool System.Collections.Generic.IDictionary<System.String,Newtonsoft.Json.Linq.JToken>.ContainsKey(string key) { throw null; }
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
        public bool TryGetValue(string propertyName, out Newtonsoft.Json.Linq.JToken value) { throw null; }
        public override void WriteTo(Newtonsoft.Json.JsonWriter writer, params Newtonsoft.Json.JsonConverter[] converters) { }
    }
    public partial class JProperty : Newtonsoft.Json.Linq.JContainer
    {
        public JProperty(Newtonsoft.Json.Linq.JProperty other) { }
        public JProperty(string name, object content) { }
        public JProperty(string name, params object[] content) { }
        protected override System.Collections.Generic.IList<Newtonsoft.Json.Linq.JToken> ChildrenTokens { get { throw null; } }
        public string Name { [System.Diagnostics.DebuggerStepThroughAttribute]get { throw null; } }
        public override Newtonsoft.Json.Linq.JTokenType Type { [System.Diagnostics.DebuggerStepThroughAttribute]get { throw null; } }
        public Newtonsoft.Json.Linq.JToken Value { [System.Diagnostics.DebuggerStepThroughAttribute]get { throw null; } set { } }
        public static new Newtonsoft.Json.Linq.JProperty Load(Newtonsoft.Json.JsonReader reader) { throw null; }
        public override void WriteTo(Newtonsoft.Json.JsonWriter writer, params Newtonsoft.Json.JsonConverter[] converters) { }
    }
    public partial class JPropertyDescriptor : System.ComponentModel.PropertyDescriptor
    {
        public JPropertyDescriptor(string name, System.Type propertyType) : base (default(string), default(System.Attribute[])) { }
        public override System.Type ComponentType { get { throw null; } }
        public override bool IsReadOnly { get { throw null; } }
        protected override int NameHashCode { get { throw null; } }
        public override System.Type PropertyType { get { throw null; } }
        public override bool CanResetValue(object component) { throw null; }
        public override object GetValue(object component) { throw null; }
        public override void ResetValue(object component) { }
        public override void SetValue(object component, object value) { }
        public override bool ShouldSerializeValue(object component) { throw null; }
    }
    public partial class JRaw : Newtonsoft.Json.Linq.JValue
    {
        public JRaw(Newtonsoft.Json.Linq.JRaw other) : base (default(Newtonsoft.Json.Linq.JValue)) { }
        public JRaw(object rawJson) : base (default(Newtonsoft.Json.Linq.JValue)) { }
        public static Newtonsoft.Json.Linq.JRaw Create(Newtonsoft.Json.JsonReader reader) { throw null; }
    }
    public abstract partial class JToken : Newtonsoft.Json.IJsonLineInfo, Newtonsoft.Json.Linq.IJEnumerable<Newtonsoft.Json.Linq.JToken>, System.Collections.Generic.IEnumerable<Newtonsoft.Json.Linq.JToken>, System.Collections.IEnumerable, System.Dynamic.IDynamicMetaObjectProvider, System.ICloneable
    {
        internal JToken() { }
        public static Newtonsoft.Json.Linq.JTokenEqualityComparer EqualityComparer { get { throw null; } }
        public virtual Newtonsoft.Json.Linq.JToken First { get { throw null; } }
        public abstract bool HasValues { get; }
        public virtual Newtonsoft.Json.Linq.JToken this[object key] { get { throw null; } set { } }
        public virtual Newtonsoft.Json.Linq.JToken Last { get { throw null; } }
        int Newtonsoft.Json.IJsonLineInfo.LineNumber { get { throw null; } }
        int Newtonsoft.Json.IJsonLineInfo.LinePosition { get { throw null; } }
        Newtonsoft.Json.Linq.IJEnumerable<Newtonsoft.Json.Linq.JToken> Newtonsoft.Json.Linq.IJEnumerable<Newtonsoft.Json.Linq.JToken>.this[object key] { get { throw null; } }
        public Newtonsoft.Json.Linq.JToken Next { get { throw null; } }
        public Newtonsoft.Json.Linq.JContainer Parent { [System.Diagnostics.DebuggerStepThroughAttribute]get { throw null; } }
        public Newtonsoft.Json.Linq.JToken Previous { get { throw null; } }
        public Newtonsoft.Json.Linq.JToken Root { get { throw null; } }
        public abstract Newtonsoft.Json.Linq.JTokenType Type { get; }
        public void AddAfterSelf(object content) { }
        public void AddBeforeSelf(object content) { }
        public System.Collections.Generic.IEnumerable<Newtonsoft.Json.Linq.JToken> AfterSelf() { throw null; }
        public System.Collections.Generic.IEnumerable<Newtonsoft.Json.Linq.JToken> Ancestors() { throw null; }
        public System.Collections.Generic.IEnumerable<Newtonsoft.Json.Linq.JToken> BeforeSelf() { throw null; }
        public virtual Newtonsoft.Json.Linq.JEnumerable<Newtonsoft.Json.Linq.JToken> Children() { throw null; }
        public Newtonsoft.Json.Linq.JEnumerable<T> Children<T>() where T : Newtonsoft.Json.Linq.JToken { throw null; }
        public Newtonsoft.Json.JsonReader CreateReader() { throw null; }
        public Newtonsoft.Json.Linq.JToken DeepClone() { throw null; }
        public static bool DeepEquals(Newtonsoft.Json.Linq.JToken t1, Newtonsoft.Json.Linq.JToken t2) { throw null; }
        public static Newtonsoft.Json.Linq.JToken FromObject(object o) { throw null; }
        public static Newtonsoft.Json.Linq.JToken FromObject(object o, Newtonsoft.Json.JsonSerializer jsonSerializer) { throw null; }
        protected virtual System.Dynamic.DynamicMetaObject GetMetaObject(System.Linq.Expressions.Expression parameter) { throw null; }
        public static Newtonsoft.Json.Linq.JToken Load(Newtonsoft.Json.JsonReader reader) { throw null; }
        bool Newtonsoft.Json.IJsonLineInfo.HasLineInfo() { throw null; }
        public static explicit operator bool (Newtonsoft.Json.Linq.JToken value) { throw null; }
        public static explicit operator byte[] (Newtonsoft.Json.Linq.JToken value) { throw null; }
        public static explicit operator System.DateTime (Newtonsoft.Json.Linq.JToken value) { throw null; }
        public static explicit operator System.DateTimeOffset (Newtonsoft.Json.Linq.JToken value) { throw null; }
        public static explicit operator decimal (Newtonsoft.Json.Linq.JToken value) { throw null; }
        public static explicit operator double (Newtonsoft.Json.Linq.JToken value) { throw null; }
        public static explicit operator short (Newtonsoft.Json.Linq.JToken value) { throw null; }
        public static explicit operator int (Newtonsoft.Json.Linq.JToken value) { throw null; }
        public static explicit operator long (Newtonsoft.Json.Linq.JToken value) { throw null; }
        public static explicit operator System.Nullable<bool> (Newtonsoft.Json.Linq.JToken value) { throw null; }
        public static explicit operator System.Nullable<System.DateTimeOffset> (Newtonsoft.Json.Linq.JToken value) { throw null; }
        public static explicit operator System.Nullable<System.DateTime> (Newtonsoft.Json.Linq.JToken value) { throw null; }
        public static explicit operator System.Nullable<decimal> (Newtonsoft.Json.Linq.JToken value) { throw null; }
        public static explicit operator System.Nullable<double> (Newtonsoft.Json.Linq.JToken value) { throw null; }
        public static explicit operator System.Nullable<short> (Newtonsoft.Json.Linq.JToken value) { throw null; }
        public static explicit operator System.Nullable<int> (Newtonsoft.Json.Linq.JToken value) { throw null; }
        public static explicit operator System.Nullable<long> (Newtonsoft.Json.Linq.JToken value) { throw null; }
        public static explicit operator System.Nullable<float> (Newtonsoft.Json.Linq.JToken value) { throw null; }
        [System.CLSCompliantAttribute(false)]
        public static explicit operator System.Nullable<ushort> (Newtonsoft.Json.Linq.JToken value) { throw null; }
        [System.CLSCompliantAttribute(false)]
        public static explicit operator System.Nullable<uint> (Newtonsoft.Json.Linq.JToken value) { throw null; }
        [System.CLSCompliantAttribute(false)]
        public static explicit operator System.Nullable<ulong> (Newtonsoft.Json.Linq.JToken value) { throw null; }
        public static explicit operator float (Newtonsoft.Json.Linq.JToken value) { throw null; }
        public static explicit operator string (Newtonsoft.Json.Linq.JToken value) { throw null; }
        [System.CLSCompliantAttribute(false)]
        public static explicit operator ushort (Newtonsoft.Json.Linq.JToken value) { throw null; }
        [System.CLSCompliantAttribute(false)]
        public static explicit operator uint (Newtonsoft.Json.Linq.JToken value) { throw null; }
        [System.CLSCompliantAttribute(false)]
        public static explicit operator ulong (Newtonsoft.Json.Linq.JToken value) { throw null; }
        public static implicit operator Newtonsoft.Json.Linq.JToken (bool value) { throw null; }
        public static implicit operator Newtonsoft.Json.Linq.JToken (byte[] value) { throw null; }
        public static implicit operator Newtonsoft.Json.Linq.JToken (System.DateTime value) { throw null; }
        public static implicit operator Newtonsoft.Json.Linq.JToken (System.DateTimeOffset value) { throw null; }
        public static implicit operator Newtonsoft.Json.Linq.JToken (decimal value) { throw null; }
        public static implicit operator Newtonsoft.Json.Linq.JToken (double value) { throw null; }
        [System.CLSCompliantAttribute(false)]
        public static implicit operator Newtonsoft.Json.Linq.JToken (short value) { throw null; }
        public static implicit operator Newtonsoft.Json.Linq.JToken (int value) { throw null; }
        public static implicit operator Newtonsoft.Json.Linq.JToken (long value) { throw null; }
        public static implicit operator Newtonsoft.Json.Linq.JToken (System.Nullable<bool> value) { throw null; }
        public static implicit operator Newtonsoft.Json.Linq.JToken (System.Nullable<System.DateTimeOffset> value) { throw null; }
        public static implicit operator Newtonsoft.Json.Linq.JToken (System.Nullable<System.DateTime> value) { throw null; }
        public static implicit operator Newtonsoft.Json.Linq.JToken (System.Nullable<decimal> value) { throw null; }
        public static implicit operator Newtonsoft.Json.Linq.JToken (System.Nullable<double> value) { throw null; }
        [System.CLSCompliantAttribute(false)]
        public static implicit operator Newtonsoft.Json.Linq.JToken (System.Nullable<short> value) { throw null; }
        public static implicit operator Newtonsoft.Json.Linq.JToken (System.Nullable<int> value) { throw null; }
        public static implicit operator Newtonsoft.Json.Linq.JToken (System.Nullable<long> value) { throw null; }
        public static implicit operator Newtonsoft.Json.Linq.JToken (System.Nullable<float> value) { throw null; }
        [System.CLSCompliantAttribute(false)]
        public static implicit operator Newtonsoft.Json.Linq.JToken (System.Nullable<ushort> value) { throw null; }
        [System.CLSCompliantAttribute(false)]
        public static implicit operator Newtonsoft.Json.Linq.JToken (System.Nullable<uint> value) { throw null; }
        [System.CLSCompliantAttribute(false)]
        public static implicit operator Newtonsoft.Json.Linq.JToken (System.Nullable<ulong> value) { throw null; }
        public static implicit operator Newtonsoft.Json.Linq.JToken (float value) { throw null; }
        public static implicit operator Newtonsoft.Json.Linq.JToken (string value) { throw null; }
        [System.CLSCompliantAttribute(false)]
        public static implicit operator Newtonsoft.Json.Linq.JToken (ushort value) { throw null; }
        [System.CLSCompliantAttribute(false)]
        public static implicit operator Newtonsoft.Json.Linq.JToken (uint value) { throw null; }
        [System.CLSCompliantAttribute(false)]
        public static implicit operator Newtonsoft.Json.Linq.JToken (ulong value) { throw null; }
        public static Newtonsoft.Json.Linq.JToken Parse(string json) { throw null; }
        public static Newtonsoft.Json.Linq.JToken ReadFrom(Newtonsoft.Json.JsonReader reader) { throw null; }
        public void Remove() { }
        public void Replace(Newtonsoft.Json.Linq.JToken value) { }
        public Newtonsoft.Json.Linq.JToken SelectToken(string path) { throw null; }
        public Newtonsoft.Json.Linq.JToken SelectToken(string path, bool errorWhenNoMatch) { throw null; }
        System.Collections.Generic.IEnumerator<Newtonsoft.Json.Linq.JToken> System.Collections.Generic.IEnumerable<Newtonsoft.Json.Linq.JToken>.GetEnumerator() { throw null; }
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { throw null; }
        System.Dynamic.DynamicMetaObject System.Dynamic.IDynamicMetaObjectProvider.GetMetaObject(System.Linq.Expressions.Expression parameter) { throw null; }
        object System.ICloneable.Clone() { throw null; }
        public T ToObject<T>() { throw null; }
        public T ToObject<T>(Newtonsoft.Json.JsonSerializer jsonSerializer) { throw null; }
        public override string ToString() { throw null; }
        public string ToString(Newtonsoft.Json.Formatting formatting, params Newtonsoft.Json.JsonConverter[] converters) { throw null; }
        public virtual System.Collections.Generic.IEnumerable<T> Values<T>() { throw null; }
        public virtual T Value<T>(object key) { throw null; }
        public abstract void WriteTo(Newtonsoft.Json.JsonWriter writer, params Newtonsoft.Json.JsonConverter[] converters);
    }
    public partial class JTokenEqualityComparer : System.Collections.Generic.IEqualityComparer<Newtonsoft.Json.Linq.JToken>
    {
        public JTokenEqualityComparer() { }
        public bool Equals(Newtonsoft.Json.Linq.JToken x, Newtonsoft.Json.Linq.JToken y) { throw null; }
        public int GetHashCode(Newtonsoft.Json.Linq.JToken obj) { throw null; }
    }
    public partial class JTokenReader : Newtonsoft.Json.JsonReader, Newtonsoft.Json.IJsonLineInfo
    {
        public JTokenReader(Newtonsoft.Json.Linq.JToken token) { }
        int Newtonsoft.Json.IJsonLineInfo.LineNumber { get { throw null; } }
        int Newtonsoft.Json.IJsonLineInfo.LinePosition { get { throw null; } }
        bool Newtonsoft.Json.IJsonLineInfo.HasLineInfo() { throw null; }
        public override bool Read() { throw null; }
        public override byte[] ReadAsBytes() { throw null; }
        public override System.Nullable<System.DateTime> ReadAsDateTime() { throw null; }
        public override System.Nullable<System.DateTimeOffset> ReadAsDateTimeOffset() { throw null; }
        public override System.Nullable<decimal> ReadAsDecimal() { throw null; }
        public override System.Nullable<int> ReadAsInt32() { throw null; }
        public override string ReadAsString() { throw null; }
    }
    public enum JTokenType
    {
        Array = 2,
        Boolean = 9,
        Bytes = 14,
        Comment = 5,
        Constructor = 3,
        Date = 12,
        Float = 7,
        Guid = 15,
        Integer = 6,
        None = 0,
        Null = 10,
        Object = 1,
        Property = 4,
        Raw = 13,
        String = 8,
        TimeSpan = 17,
        Undefined = 11,
        Uri = 16,
    }
    public partial class JTokenWriter : Newtonsoft.Json.JsonWriter
    {
        public JTokenWriter() { }
        public JTokenWriter(Newtonsoft.Json.Linq.JContainer container) { }
        public Newtonsoft.Json.Linq.JToken Token { get { throw null; } }
        public override void Close() { }
        public override void Flush() { }
        public override void WriteComment(string text) { }
        protected override void WriteEnd(Newtonsoft.Json.JsonToken token) { }
        public override void WriteNull() { }
        public override void WritePropertyName(string name) { }
        public override void WriteRaw(string json) { }
        public override void WriteStartArray() { }
        public override void WriteStartConstructor(string name) { }
        public override void WriteStartObject() { }
        public override void WriteUndefined() { }
        public override void WriteValue(bool value) { }
        public override void WriteValue(byte value) { }
        public override void WriteValue(byte[] value) { }
        public override void WriteValue(char value) { }
        public override void WriteValue(System.DateTime value) { }
        public override void WriteValue(System.DateTimeOffset value) { }
        public override void WriteValue(decimal value) { }
        public override void WriteValue(double value) { }
        public override void WriteValue(System.Guid value) { }
        public override void WriteValue(short value) { }
        public override void WriteValue(int value) { }
        public override void WriteValue(long value) { }
        [System.CLSCompliantAttribute(false)]
        public override void WriteValue(sbyte value) { }
        public override void WriteValue(float value) { }
        public override void WriteValue(string value) { }
        public override void WriteValue(System.TimeSpan value) { }
        [System.CLSCompliantAttribute(false)]
        public override void WriteValue(ushort value) { }
        [System.CLSCompliantAttribute(false)]
        public override void WriteValue(uint value) { }
        [System.CLSCompliantAttribute(false)]
        public override void WriteValue(ulong value) { }
        public override void WriteValue(System.Uri value) { }
    }
    public partial class JValue : Newtonsoft.Json.Linq.JToken, System.IComparable, System.IComparable<Newtonsoft.Json.Linq.JValue>, System.IEquatable<Newtonsoft.Json.Linq.JValue>, System.IFormattable
    {
        public JValue(Newtonsoft.Json.Linq.JValue other) { }
        public JValue(bool value) { }
        public JValue(System.DateTime value) { }
        public JValue(double value) { }
        public JValue(System.Guid value) { }
        public JValue(long value) { }
        public JValue(object value) { }
        public JValue(string value) { }
        public JValue(System.TimeSpan value) { }
        [System.CLSCompliantAttribute(false)]
        public JValue(ulong value) { }
        public JValue(System.Uri value) { }
        public override bool HasValues { get { throw null; } }
        public override Newtonsoft.Json.Linq.JTokenType Type { get { throw null; } }
        public object Value { get { throw null; } set { } }
        public int CompareTo(Newtonsoft.Json.Linq.JValue obj) { throw null; }
        public static Newtonsoft.Json.Linq.JValue CreateComment(string value) { throw null; }
        public static Newtonsoft.Json.Linq.JValue CreateString(string value) { throw null; }
        public bool Equals(Newtonsoft.Json.Linq.JValue other) { throw null; }
        public override bool Equals(object obj) { throw null; }
        public override int GetHashCode() { throw null; }
        protected override System.Dynamic.DynamicMetaObject GetMetaObject(System.Linq.Expressions.Expression parameter) { throw null; }
        int System.IComparable.CompareTo(object obj) { throw null; }
        public override string ToString() { throw null; }
        public string ToString(System.IFormatProvider formatProvider) { throw null; }
        public string ToString(string format) { throw null; }
        public string ToString(string format, System.IFormatProvider formatProvider) { throw null; }
        public override void WriteTo(Newtonsoft.Json.JsonWriter writer, params Newtonsoft.Json.JsonConverter[] converters) { }
    }
}
namespace Newtonsoft.Json.Schema
{
    public static partial class Extensions
    {
        public static bool IsValid(this Newtonsoft.Json.Linq.JToken source, Newtonsoft.Json.Schema.JsonSchema schema) { throw null; }
        public static bool IsValid(this Newtonsoft.Json.Linq.JToken source, Newtonsoft.Json.Schema.JsonSchema schema, out System.Collections.Generic.IList<string> errorMessages) { throw null; }
        public static void Validate(this Newtonsoft.Json.Linq.JToken source, Newtonsoft.Json.Schema.JsonSchema schema) { }
        public static void Validate(this Newtonsoft.Json.Linq.JToken source, Newtonsoft.Json.Schema.JsonSchema schema, Newtonsoft.Json.Schema.ValidationEventHandler validationEventHandler) { }
    }
    public partial class JsonSchema
    {
        public JsonSchema() { }
        public Newtonsoft.Json.Schema.JsonSchema AdditionalProperties { get { throw null; } set { } }
        public bool AllowAdditionalProperties { get { throw null; } set { } }
        public Newtonsoft.Json.Linq.JToken Default { get { throw null; } set { } }
        public string Description { get { throw null; } set { } }
        public System.Nullable<Newtonsoft.Json.Schema.JsonSchemaType> Disallow { get { throw null; } set { } }
        public System.Nullable<double> DivisibleBy { get { throw null; } set { } }
        public System.Collections.Generic.IList<Newtonsoft.Json.Linq.JToken> Enum { get { throw null; } set { } }
        public System.Nullable<bool> ExclusiveMaximum { get { throw null; } set { } }
        public System.Nullable<bool> ExclusiveMinimum { get { throw null; } set { } }
        public Newtonsoft.Json.Schema.JsonSchema Extends { get { throw null; } set { } }
        public string Format { get { throw null; } set { } }
        public System.Nullable<bool> Hidden { get { throw null; } set { } }
        public string Id { get { throw null; } set { } }
        public System.Collections.Generic.IList<string> Identity { get { throw null; } set { } }
        public System.Collections.Generic.IList<Newtonsoft.Json.Schema.JsonSchema> Items { get { throw null; } set { } }
        public System.Nullable<double> Maximum { get { throw null; } set { } }
        public System.Nullable<int> MaximumItems { get { throw null; } set { } }
        public System.Nullable<int> MaximumLength { get { throw null; } set { } }
        public System.Nullable<double> Minimum { get { throw null; } set { } }
        public System.Nullable<int> MinimumItems { get { throw null; } set { } }
        public System.Nullable<int> MinimumLength { get { throw null; } set { } }
        public System.Collections.Generic.IDictionary<Newtonsoft.Json.Linq.JToken, string> Options { get { throw null; } set { } }
        public string Pattern { get { throw null; } set { } }
        public System.Collections.Generic.IDictionary<string, Newtonsoft.Json.Schema.JsonSchema> PatternProperties { get { throw null; } set { } }
        public System.Collections.Generic.IDictionary<string, Newtonsoft.Json.Schema.JsonSchema> Properties { get { throw null; } set { } }
        public System.Nullable<bool> ReadOnly { get { throw null; } set { } }
        public System.Nullable<bool> Required { get { throw null; } set { } }
        public string Requires { get { throw null; } set { } }
        public string Title { get { throw null; } set { } }
        public System.Nullable<bool> Transient { get { throw null; } set { } }
        public System.Nullable<Newtonsoft.Json.Schema.JsonSchemaType> Type { get { throw null; } set { } }
        public static Newtonsoft.Json.Schema.JsonSchema Parse(string json) { throw null; }
        public static Newtonsoft.Json.Schema.JsonSchema Parse(string json, Newtonsoft.Json.Schema.JsonSchemaResolver resolver) { throw null; }
        public static Newtonsoft.Json.Schema.JsonSchema Read(Newtonsoft.Json.JsonReader reader) { throw null; }
        public static Newtonsoft.Json.Schema.JsonSchema Read(Newtonsoft.Json.JsonReader reader, Newtonsoft.Json.Schema.JsonSchemaResolver resolver) { throw null; }
        public override string ToString() { throw null; }
        public void WriteTo(Newtonsoft.Json.JsonWriter writer) { }
        public void WriteTo(Newtonsoft.Json.JsonWriter writer, Newtonsoft.Json.Schema.JsonSchemaResolver resolver) { }
    }
    [System.SerializableAttribute]
    public partial class JsonSchemaException : System.Exception
    {
        public JsonSchemaException() { }
        public JsonSchemaException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
        public JsonSchemaException(string message) { }
        public JsonSchemaException(string message, System.Exception innerException) { }
        public int LineNumber { get { throw null; } }
        public int LinePosition { get { throw null; } }
        public string Path { get { throw null; } }
    }
    public partial class JsonSchemaGenerator
    {
        public JsonSchemaGenerator() { }
        public Newtonsoft.Json.Serialization.IContractResolver ContractResolver { get { throw null; } set { } }
        public Newtonsoft.Json.Schema.UndefinedSchemaIdHandling UndefinedSchemaIdHandling { get { throw null; } set { } }
        public Newtonsoft.Json.Schema.JsonSchema Generate(System.Type type) { throw null; }
        public Newtonsoft.Json.Schema.JsonSchema Generate(System.Type type, Newtonsoft.Json.Schema.JsonSchemaResolver resolver) { throw null; }
        public Newtonsoft.Json.Schema.JsonSchema Generate(System.Type type, Newtonsoft.Json.Schema.JsonSchemaResolver resolver, bool rootSchemaNullable) { throw null; }
        public Newtonsoft.Json.Schema.JsonSchema Generate(System.Type type, bool rootSchemaNullable) { throw null; }
    }
    public partial class JsonSchemaResolver
    {
        public JsonSchemaResolver() { }
        public System.Collections.Generic.IList<Newtonsoft.Json.Schema.JsonSchema> LoadedSchemas { get { throw null; } protected set { } }
        public virtual Newtonsoft.Json.Schema.JsonSchema GetSchema(string id) { throw null; }
    }
    [System.FlagsAttribute]
    public enum JsonSchemaType
    {
        Any = 127,
        Array = 32,
        Boolean = 8,
        Float = 2,
        Integer = 4,
        None = 0,
        Null = 64,
        Object = 16,
        String = 1,
    }
    public enum UndefinedSchemaIdHandling
    {
        None = 0,
        UseAssemblyQualifiedName = 2,
        UseTypeName = 1,
    }
    public partial class ValidationEventArgs : System.EventArgs
    {
        internal ValidationEventArgs() { }
        public Newtonsoft.Json.Schema.JsonSchemaException Exception { get { throw null; } }
        public string Message { get { throw null; } }
        public string Path { get { throw null; } }
    }
    public delegate void ValidationEventHandler(object sender, Newtonsoft.Json.Schema.ValidationEventArgs e);
}
namespace Newtonsoft.Json.Serialization
{
    public partial class CamelCasePropertyNamesContractResolver : Newtonsoft.Json.Serialization.DefaultContractResolver
    {
        public CamelCasePropertyNamesContractResolver() { }
        protected internal override string ResolvePropertyName(string propertyName) { throw null; }
    }
    public partial class DefaultContractResolver : Newtonsoft.Json.Serialization.IContractResolver
    {
        public DefaultContractResolver() { }
        public DefaultContractResolver(bool shareCache) { }
        public System.Reflection.BindingFlags DefaultMembersSearchFlags { get { throw null; } set { } }
        public bool DynamicCodeGeneration { get { throw null; } }
        public bool IgnoreSerializableInterface { get { throw null; } set { } }
        public bool SerializeCompilerGeneratedMembers { get { throw null; } set { } }
        protected virtual Newtonsoft.Json.Serialization.JsonArrayContract CreateArrayContract(System.Type objectType) { throw null; }
        protected virtual System.Collections.Generic.IList<Newtonsoft.Json.Serialization.JsonProperty> CreateConstructorParameters(System.Reflection.ConstructorInfo constructor, Newtonsoft.Json.Serialization.JsonPropertyCollection memberProperties) { throw null; }
        protected virtual Newtonsoft.Json.Serialization.JsonContract CreateContract(System.Type objectType) { throw null; }
        protected virtual Newtonsoft.Json.Serialization.JsonDictionaryContract CreateDictionaryContract(System.Type objectType) { throw null; }
        protected virtual Newtonsoft.Json.Serialization.JsonDynamicContract CreateDynamicContract(System.Type objectType) { throw null; }
        protected virtual Newtonsoft.Json.Serialization.JsonISerializableContract CreateISerializableContract(System.Type objectType) { throw null; }
        protected virtual Newtonsoft.Json.Serialization.JsonLinqContract CreateLinqContract(System.Type objectType) { throw null; }
        protected virtual Newtonsoft.Json.Serialization.IValueProvider CreateMemberValueProvider(System.Reflection.MemberInfo member) { throw null; }
        protected virtual Newtonsoft.Json.Serialization.JsonObjectContract CreateObjectContract(System.Type objectType) { throw null; }
        protected virtual Newtonsoft.Json.Serialization.JsonPrimitiveContract CreatePrimitiveContract(System.Type objectType) { throw null; }
        protected virtual System.Collections.Generic.IList<Newtonsoft.Json.Serialization.JsonProperty> CreateProperties(System.Type type, Newtonsoft.Json.MemberSerialization memberSerialization) { throw null; }
        protected virtual Newtonsoft.Json.Serialization.JsonProperty CreateProperty(System.Reflection.MemberInfo member, Newtonsoft.Json.MemberSerialization memberSerialization) { throw null; }
        protected virtual Newtonsoft.Json.Serialization.JsonProperty CreatePropertyFromConstructorParameter(Newtonsoft.Json.Serialization.JsonProperty matchingMemberProperty, System.Reflection.ParameterInfo parameterInfo) { throw null; }
        protected virtual Newtonsoft.Json.Serialization.JsonStringContract CreateStringContract(System.Type objectType) { throw null; }
        protected virtual System.Collections.Generic.List<System.Reflection.MemberInfo> GetSerializableMembers(System.Type objectType) { throw null; }
        public virtual Newtonsoft.Json.Serialization.JsonContract ResolveContract(System.Type type) { throw null; }
        protected virtual Newtonsoft.Json.JsonConverter ResolveContractConverter(System.Type objectType) { throw null; }
        protected internal virtual string ResolvePropertyName(string propertyName) { throw null; }
    }
    public partial class DefaultSerializationBinder : System.Runtime.Serialization.SerializationBinder
    {
        public DefaultSerializationBinder() { }
        public override void BindToName(System.Type serializedType, out string assemblyName, out string typeName) { throw null; }
        public override System.Type BindToType(string assemblyName, string typeName) { throw null; }
    }
    public partial class DynamicValueProvider : Newtonsoft.Json.Serialization.IValueProvider
    {
        public DynamicValueProvider(System.Reflection.MemberInfo memberInfo) { }
        public object GetValue(object target) { throw null; }
        public void SetValue(object target, object value) { }
    }
    public partial class ErrorContext
    {
        internal ErrorContext() { }
        public System.Exception Error { get { throw null; } }
        public bool Handled { get { throw null; } set { } }
        public object Member { get { throw null; } }
        public object OriginalObject { get { throw null; } }
        public string Path { get { throw null; } }
    }
    public partial class ErrorEventArgs : System.EventArgs
    {
        public ErrorEventArgs(object currentObject, Newtonsoft.Json.Serialization.ErrorContext errorContext) { }
        public object CurrentObject { get { throw null; } }
        public Newtonsoft.Json.Serialization.ErrorContext ErrorContext { get { throw null; } }
    }
    public partial interface IContractResolver
    {
        Newtonsoft.Json.Serialization.JsonContract ResolveContract(System.Type type);
    }
    public partial interface IReferenceResolver
    {
        void AddReference(object context, string reference, object value);
        string GetReference(object context, object value);
        bool IsReferenced(object context, object value);
        object ResolveReference(object context, string reference);
    }
    public partial interface IValueProvider
    {
        object GetValue(object target);
        void SetValue(object target, object value);
    }
    public partial class JsonArrayContract : Newtonsoft.Json.Serialization.JsonContract
    {
        public JsonArrayContract(System.Type underlyingType) { }
        public System.Type CollectionItemType { get { throw null; } }
    }
    public abstract partial class JsonContract
    {
        internal JsonContract() { }
        public Newtonsoft.Json.JsonConverter Converter { get { throw null; } set { } }
        public System.Type CreatedType { get { throw null; } set { } }
        public System.Func<object> DefaultCreator { get { throw null; } set { } }
        public bool DefaultCreatorNonPublic { get { throw null; } set { } }
        public System.Nullable<bool> IsReference { get { throw null; } set { } }
        public System.Reflection.MethodInfo OnDeserialized { get { throw null; } set { } }
        public System.Reflection.MethodInfo OnDeserializing { get { throw null; } set { } }
        public System.Reflection.MethodInfo OnError { get { throw null; } set { } }
        public System.Reflection.MethodInfo OnSerialized { get { throw null; } set { } }
        public System.Reflection.MethodInfo OnSerializing { get { throw null; } set { } }
        public System.Type UnderlyingType { get { throw null; } }
    }
    public partial class JsonDictionaryContract : Newtonsoft.Json.Serialization.JsonContract
    {
        public JsonDictionaryContract(System.Type underlyingType) { }
        public System.Type DictionaryKeyType { get { throw null; } }
        public System.Type DictionaryValueType { get { throw null; } }
        public System.Func<string, string> PropertyNameResolver { get { throw null; } set { } }
    }
    public partial class JsonDynamicContract : Newtonsoft.Json.Serialization.JsonContract
    {
        public JsonDynamicContract(System.Type underlyingType) { }
        public Newtonsoft.Json.Serialization.JsonPropertyCollection Properties { get { throw null; } }
        public System.Func<string, string> PropertyNameResolver { get { throw null; } set { } }
    }
    public partial class JsonISerializableContract : Newtonsoft.Json.Serialization.JsonContract
    {
        public JsonISerializableContract(System.Type underlyingType) { }
        public Newtonsoft.Json.Serialization.ObjectConstructor<object> ISerializableCreator { get { throw null; } set { } }
    }
    public partial class JsonLinqContract : Newtonsoft.Json.Serialization.JsonContract
    {
        public JsonLinqContract(System.Type underlyingType) { }
    }
    public partial class JsonObjectContract : Newtonsoft.Json.Serialization.JsonContract
    {
        public JsonObjectContract(System.Type underlyingType) { }
        public Newtonsoft.Json.Serialization.JsonPropertyCollection ConstructorParameters { get { throw null; } }
        public Newtonsoft.Json.MemberSerialization MemberSerialization { get { throw null; } set { } }
        public System.Reflection.ConstructorInfo OverrideConstructor { get { throw null; } set { } }
        public System.Reflection.ConstructorInfo ParametrizedConstructor { get { throw null; } set { } }
        public Newtonsoft.Json.Serialization.JsonPropertyCollection Properties { get { throw null; } }
    }
    public partial class JsonPrimitiveContract : Newtonsoft.Json.Serialization.JsonContract
    {
        public JsonPrimitiveContract(System.Type underlyingType) { }
    }
    public partial class JsonProperty
    {
        public JsonProperty() { }
        public Newtonsoft.Json.JsonConverter Converter { get { throw null; } set { } }
        public System.Type DeclaringType { get { throw null; } set { } }
        public object DefaultValue { get { throw null; } set { } }
        public System.Nullable<Newtonsoft.Json.DefaultValueHandling> DefaultValueHandling { get { throw null; } set { } }
        public System.Predicate<object> GetIsSpecified { get { throw null; } set { } }
        public bool Ignored { get { throw null; } set { } }
        public System.Nullable<bool> IsReference { get { throw null; } set { } }
        public Newtonsoft.Json.JsonConverter MemberConverter { get { throw null; } set { } }
        public System.Nullable<Newtonsoft.Json.NullValueHandling> NullValueHandling { get { throw null; } set { } }
        public System.Nullable<Newtonsoft.Json.ObjectCreationHandling> ObjectCreationHandling { get { throw null; } set { } }
        public System.Nullable<int> Order { get { throw null; } set { } }
        public string PropertyName { get { throw null; } set { } }
        public System.Type PropertyType { get { throw null; } set { } }
        public bool Readable { get { throw null; } set { } }
        public System.Nullable<Newtonsoft.Json.ReferenceLoopHandling> ReferenceLoopHandling { get { throw null; } set { } }
        public Newtonsoft.Json.Required Required { get { throw null; } set { } }
        public System.Action<object, object> SetIsSpecified { get { throw null; } set { } }
        public System.Predicate<object> ShouldSerialize { get { throw null; } set { } }
        public System.Nullable<Newtonsoft.Json.TypeNameHandling> TypeNameHandling { get { throw null; } set { } }
        public string UnderlyingName { get { throw null; } set { } }
        public Newtonsoft.Json.Serialization.IValueProvider ValueProvider { get { throw null; } set { } }
        public bool Writable { get { throw null; } set { } }
        public override string ToString() { throw null; }
    }
    public partial class JsonPropertyCollection : System.Collections.ObjectModel.KeyedCollection<string, Newtonsoft.Json.Serialization.JsonProperty>
    {
        public JsonPropertyCollection(System.Type type) { }
        public void AddProperty(Newtonsoft.Json.Serialization.JsonProperty property) { }
        public Newtonsoft.Json.Serialization.JsonProperty GetClosestMatchProperty(string propertyName) { throw null; }
        protected override string GetKeyForItem(Newtonsoft.Json.Serialization.JsonProperty item) { throw null; }
        public Newtonsoft.Json.Serialization.JsonProperty GetProperty(string propertyName, System.StringComparison comparisonType) { throw null; }
    }
    public partial class JsonStringContract : Newtonsoft.Json.Serialization.JsonPrimitiveContract
    {
        public JsonStringContract(System.Type underlyingType) : base (default(System.Type)) { }
    }
    public delegate object ObjectConstructor<T>(params object[] args);
    [System.AttributeUsageAttribute(System.AttributeTargets.Method, Inherited=false)]
    public sealed partial class OnErrorAttribute : System.Attribute
    {
        public OnErrorAttribute() { }
    }
    public partial class ReflectionValueProvider : Newtonsoft.Json.Serialization.IValueProvider
    {
        public ReflectionValueProvider(System.Reflection.MemberInfo memberInfo) { }
        public object GetValue(object target) { throw null; }
        public void SetValue(object target, object value) { }
    }
}
namespace System.Net.Http
{
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    public static partial class HttpClientExtensions
    {
        public static System.Threading.Tasks.Task<System.Net.Http.HttpResponseMessage> PostAsJsonAsync<T>(this System.Net.Http.HttpClient client, string requestUri, T value) { throw null; }
        public static System.Threading.Tasks.Task<System.Net.Http.HttpResponseMessage> PostAsJsonAsync<T>(this System.Net.Http.HttpClient client, string requestUri, T value, System.Threading.CancellationToken cancellationToken) { throw null; }
        public static System.Threading.Tasks.Task<System.Net.Http.HttpResponseMessage> PostAsXmlAsync<T>(this System.Net.Http.HttpClient client, string requestUri, T value) { throw null; }
        public static System.Threading.Tasks.Task<System.Net.Http.HttpResponseMessage> PostAsXmlAsync<T>(this System.Net.Http.HttpClient client, string requestUri, T value, System.Threading.CancellationToken cancellationToken) { throw null; }
        public static System.Threading.Tasks.Task<System.Net.Http.HttpResponseMessage> PostAsync<T>(this System.Net.Http.HttpClient client, string requestUri, T value, System.Net.Http.Formatting.MediaTypeFormatter formatter) { throw null; }
        public static System.Threading.Tasks.Task<System.Net.Http.HttpResponseMessage> PostAsync<T>(this System.Net.Http.HttpClient client, string requestUri, T value, System.Net.Http.Formatting.MediaTypeFormatter formatter, string mediaType) { throw null; }
        public static System.Threading.Tasks.Task<System.Net.Http.HttpResponseMessage> PostAsync<T>(this System.Net.Http.HttpClient client, string requestUri, T value, System.Net.Http.Formatting.MediaTypeFormatter formatter, string mediaType, System.Threading.CancellationToken cancellationToken) { throw null; }
        public static System.Threading.Tasks.Task<System.Net.Http.HttpResponseMessage> PostAsync<T>(this System.Net.Http.HttpClient client, string requestUri, T value, System.Net.Http.Formatting.MediaTypeFormatter formatter, System.Threading.CancellationToken cancellationToken) { throw null; }
        public static System.Threading.Tasks.Task<System.Net.Http.HttpResponseMessage> PutAsJsonAsync<T>(this System.Net.Http.HttpClient client, string requestUri, T value) { throw null; }
        public static System.Threading.Tasks.Task<System.Net.Http.HttpResponseMessage> PutAsJsonAsync<T>(this System.Net.Http.HttpClient client, string requestUri, T value, System.Threading.CancellationToken cancellationToken) { throw null; }
        public static System.Threading.Tasks.Task<System.Net.Http.HttpResponseMessage> PutAsXmlAsync<T>(this System.Net.Http.HttpClient client, string requestUri, T value) { throw null; }
        public static System.Threading.Tasks.Task<System.Net.Http.HttpResponseMessage> PutAsXmlAsync<T>(this System.Net.Http.HttpClient client, string requestUri, T value, System.Threading.CancellationToken cancellationToken) { throw null; }
        public static System.Threading.Tasks.Task<System.Net.Http.HttpResponseMessage> PutAsync<T>(this System.Net.Http.HttpClient client, string requestUri, T value, System.Net.Http.Formatting.MediaTypeFormatter formatter) { throw null; }
        public static System.Threading.Tasks.Task<System.Net.Http.HttpResponseMessage> PutAsync<T>(this System.Net.Http.HttpClient client, string requestUri, T value, System.Net.Http.Formatting.MediaTypeFormatter formatter, string mediaType) { throw null; }
        public static System.Threading.Tasks.Task<System.Net.Http.HttpResponseMessage> PutAsync<T>(this System.Net.Http.HttpClient client, string requestUri, T value, System.Net.Http.Formatting.MediaTypeFormatter formatter, string mediaType, System.Threading.CancellationToken cancellationToken) { throw null; }
        public static System.Threading.Tasks.Task<System.Net.Http.HttpResponseMessage> PutAsync<T>(this System.Net.Http.HttpClient client, string requestUri, T value, System.Net.Http.Formatting.MediaTypeFormatter formatter, System.Threading.CancellationToken cancellationToken) { throw null; }
    }
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    public static partial class HttpContentCollectionExtensions
    {
        public static System.Collections.Generic.IEnumerable<System.Net.Http.HttpContent> FindAllContentType(this System.Collections.Generic.IEnumerable<System.Net.Http.HttpContent> contents, System.Net.Http.Headers.MediaTypeHeaderValue contentType) { throw null; }
        public static System.Collections.Generic.IEnumerable<System.Net.Http.HttpContent> FindAllContentType(this System.Collections.Generic.IEnumerable<System.Net.Http.HttpContent> contents, string contentType) { throw null; }
        public static System.Net.Http.HttpContent FirstDispositionName(this System.Collections.Generic.IEnumerable<System.Net.Http.HttpContent> contents, string dispositionName) { throw null; }
        public static System.Net.Http.HttpContent FirstDispositionNameOrDefault(this System.Collections.Generic.IEnumerable<System.Net.Http.HttpContent> contents, string dispositionName) { throw null; }
        public static System.Net.Http.HttpContent FirstDispositionType(this System.Collections.Generic.IEnumerable<System.Net.Http.HttpContent> contents, string dispositionType) { throw null; }
        public static System.Net.Http.HttpContent FirstDispositionTypeOrDefault(this System.Collections.Generic.IEnumerable<System.Net.Http.HttpContent> contents, string dispositionType) { throw null; }
        public static System.Net.Http.HttpContent FirstStart(this System.Collections.Generic.IEnumerable<System.Net.Http.HttpContent> contents, string start) { throw null; }
        public static System.Net.Http.HttpContent FirstStartOrDefault(this System.Collections.Generic.IEnumerable<System.Net.Http.HttpContent> contents, string start) { throw null; }
    }
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    public static partial class HttpContentExtensions
    {
        public static System.Threading.Tasks.Task<object> ReadAsAsync(this System.Net.Http.HttpContent content, System.Type type) { throw null; }
        public static System.Threading.Tasks.Task<object> ReadAsAsync(this System.Net.Http.HttpContent content, System.Type type, System.Collections.Generic.IEnumerable<System.Net.Http.Formatting.MediaTypeFormatter> formatters) { throw null; }
        public static System.Threading.Tasks.Task<object> ReadAsAsync(this System.Net.Http.HttpContent content, System.Type type, System.Collections.Generic.IEnumerable<System.Net.Http.Formatting.MediaTypeFormatter> formatters, System.Net.Http.Formatting.IFormatterLogger formatterLogger) { throw null; }
        public static System.Threading.Tasks.Task<T> ReadAsAsync<T>(this System.Net.Http.HttpContent content) { throw null; }
        public static System.Threading.Tasks.Task<T> ReadAsAsync<T>(this System.Net.Http.HttpContent content, System.Collections.Generic.IEnumerable<System.Net.Http.Formatting.MediaTypeFormatter> formatters) { throw null; }
        public static System.Threading.Tasks.Task<T> ReadAsAsync<T>(this System.Net.Http.HttpContent content, System.Collections.Generic.IEnumerable<System.Net.Http.Formatting.MediaTypeFormatter> formatters, System.Net.Http.Formatting.IFormatterLogger formatterLogger) { throw null; }
    }
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    public static partial class HttpContentMessageExtensions
    {
        public static bool IsHttpRequestMessageContent(this System.Net.Http.HttpContent content) { throw null; }
        public static bool IsHttpResponseMessageContent(this System.Net.Http.HttpContent content) { throw null; }
        public static System.Threading.Tasks.Task<System.Net.Http.HttpRequestMessage> ReadAsHttpRequestMessageAsync(this System.Net.Http.HttpContent content) { throw null; }
        public static System.Threading.Tasks.Task<System.Net.Http.HttpRequestMessage> ReadAsHttpRequestMessageAsync(this System.Net.Http.HttpContent content, string uriScheme) { throw null; }
        public static System.Threading.Tasks.Task<System.Net.Http.HttpRequestMessage> ReadAsHttpRequestMessageAsync(this System.Net.Http.HttpContent content, string uriScheme, int bufferSize) { throw null; }
        public static System.Threading.Tasks.Task<System.Net.Http.HttpResponseMessage> ReadAsHttpResponseMessageAsync(this System.Net.Http.HttpContent content) { throw null; }
        public static System.Threading.Tasks.Task<System.Net.Http.HttpResponseMessage> ReadAsHttpResponseMessageAsync(this System.Net.Http.HttpContent content, int bufferSize) { throw null; }
    }
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    public static partial class HttpContentMultipartExtensions
    {
        public static bool IsMimeMultipartContent(this System.Net.Http.HttpContent content) { throw null; }
        public static bool IsMimeMultipartContent(this System.Net.Http.HttpContent content, string subtype) { throw null; }
        public static System.Threading.Tasks.Task<System.Collections.Generic.IEnumerable<System.Net.Http.HttpContent>> ReadAsMultipartAsync(this System.Net.Http.HttpContent content) { throw null; }
        public static System.Threading.Tasks.Task<System.Collections.Generic.IEnumerable<System.Net.Http.HttpContent>> ReadAsMultipartAsync(this System.Net.Http.HttpContent content, System.Net.Http.IMultipartStreamProvider streamProvider) { throw null; }
        public static System.Threading.Tasks.Task<System.Collections.Generic.IEnumerable<System.Net.Http.HttpContent>> ReadAsMultipartAsync(this System.Net.Http.HttpContent content, System.Net.Http.IMultipartStreamProvider streamProvider, int bufferSize) { throw null; }
    }
    public partial class HttpMessageContent : System.Net.Http.HttpContent
    {
        public HttpMessageContent(System.Net.Http.HttpRequestMessage httpRequest) { }
        public HttpMessageContent(System.Net.Http.HttpResponseMessage httpResponse) { }
        public System.Net.Http.HttpRequestMessage HttpRequestMessage { get { throw null; } }
        public System.Net.Http.HttpResponseMessage HttpResponseMessage { get { throw null; } }
        protected override void Dispose(bool disposing) { }
        protected override System.Threading.Tasks.Task SerializeToStreamAsync(System.IO.Stream stream, System.Net.TransportContext context) { throw null; }
        protected override bool TryComputeLength(out long length) { throw null; }
    }
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    public static partial class HttpRequestHeadersExtensions
    {
        public static System.Collections.ObjectModel.Collection<System.Net.Http.Headers.CookieHeaderValue> GetCookies(this System.Net.Http.Headers.HttpRequestHeaders headers) { throw null; }
    }
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    public static partial class HttpRequestMessageExtensions
    {
        public static System.Net.Http.HttpResponseMessage CreateResponse(this System.Net.Http.HttpRequestMessage request) { throw null; }
        public static System.Net.Http.HttpResponseMessage CreateResponse(this System.Net.Http.HttpRequestMessage request, System.Net.HttpStatusCode statusCode) { throw null; }
    }
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    public static partial class HttpResponseHeadersExtensions
    {
        public static void AddCookies(this System.Net.Http.Headers.HttpResponseHeaders headers, System.Collections.Generic.IEnumerable<System.Net.Http.Headers.CookieHeaderValue> cookies) { }
    }
    public partial interface IMultipartStreamProvider
    {
        System.IO.Stream GetStream(System.Net.Http.Headers.HttpContentHeaders headers);
    }
    public partial class MultipartFileStreamProvider : System.Net.Http.IMultipartStreamProvider
    {
        public MultipartFileStreamProvider(string rootPath) { }
        public MultipartFileStreamProvider(string rootPath, int bufferSize) { }
        public System.Collections.ObjectModel.Collection<string> BodyPartFileNames { get { throw null; } }
        public virtual string GetLocalFileName(System.Net.Http.Headers.HttpContentHeaders headers) { throw null; }
        public virtual System.IO.Stream GetStream(System.Net.Http.Headers.HttpContentHeaders headers) { throw null; }
    }
    public partial class MultipartFormDataStreamProvider : System.Net.Http.IMultipartStreamProvider
    {
        public MultipartFormDataStreamProvider(string rootPath) { }
        public MultipartFormDataStreamProvider(string rootPath, int bufferSize) { }
        public System.Collections.Generic.IDictionary<string, string> BodyPartFileNames { get { throw null; } }
        public virtual string GetLocalFileName(System.Net.Http.Headers.HttpContentHeaders headers) { throw null; }
        public virtual System.IO.Stream GetStream(System.Net.Http.Headers.HttpContentHeaders headers) { throw null; }
    }
    public partial class ObjectContent : System.Net.Http.HttpContent
    {
        public ObjectContent(System.Type type, object value, System.Net.Http.Formatting.MediaTypeFormatter formatter) { }
        public ObjectContent(System.Type type, object value, System.Net.Http.Formatting.MediaTypeFormatter formatter, string mediaType) { }
        public System.Net.Http.Formatting.MediaTypeFormatter Formatter { get { throw null; } }
        public System.Type ObjectType { get { throw null; } }
        public object Value { get { throw null; } set { } }
        protected override System.Threading.Tasks.Task SerializeToStreamAsync(System.IO.Stream stream, System.Net.TransportContext context) { throw null; }
        protected override bool TryComputeLength(out long length) { throw null; }
    }
    public partial class ObjectContent<T> : System.Net.Http.ObjectContent
    {
        public ObjectContent(T value, System.Net.Http.Formatting.MediaTypeFormatter formatter) : base (default(System.Type), default(object), default(System.Net.Http.Formatting.MediaTypeFormatter)) { }
        public ObjectContent(T value, System.Net.Http.Formatting.MediaTypeFormatter formatter, string mediaType) : base (default(System.Type), default(object), default(System.Net.Http.Formatting.MediaTypeFormatter)) { }
    }
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    public static partial class UriExtensions
    {
        public static System.Collections.Specialized.NameValueCollection ParseQueryString(this System.Uri address) { throw null; }
        public static bool TryReadQueryAs(this System.Uri address, System.Type type, out object value) { throw null; }
        public static bool TryReadQueryAsJson(this System.Uri address, out Newtonsoft.Json.Linq.JObject value) { throw null; }
        public static bool TryReadQueryAs<T>(this System.Uri address, out T value) { throw null; }
    }
}
namespace System.Net.Http.Formatting
{
    public abstract partial class BufferedMediaTypeFormatter : System.Net.Http.Formatting.MediaTypeFormatter
    {
        protected BufferedMediaTypeFormatter() { }
        public int BufferSize { get { throw null; } set { } }
        public virtual object ReadFromStream(System.Type type, System.IO.Stream stream, System.Net.Http.Headers.HttpContentHeaders contentHeaders, System.Net.Http.Formatting.IFormatterLogger formatterLogger) { throw null; }
        public sealed override System.Threading.Tasks.Task<object> ReadFromStreamAsync(System.Type type, System.IO.Stream stream, System.Net.Http.Headers.HttpContentHeaders contentHeaders, System.Net.Http.Formatting.IFormatterLogger formatterLogger) { throw null; }
        public virtual void WriteToStream(System.Type type, object value, System.IO.Stream stream, System.Net.Http.Headers.HttpContentHeaders contentHeaders) { }
        public sealed override System.Threading.Tasks.Task WriteToStreamAsync(System.Type type, object value, System.IO.Stream stream, System.Net.Http.Headers.HttpContentHeaders contentHeaders, System.Net.TransportContext transportContext) { throw null; }
    }
    public partial class ContentNegotiationResult
    {
        public ContentNegotiationResult(System.Net.Http.Formatting.MediaTypeFormatter formatter, System.Net.Http.Headers.MediaTypeHeaderValue mediaType) { }
        public System.Net.Http.Formatting.MediaTypeFormatter Formatter { get { throw null; } set { } }
        public System.Net.Http.Headers.MediaTypeHeaderValue MediaType { get { throw null; } set { } }
    }
    public partial class DefaultContentNegotiator : System.Net.Http.Formatting.IContentNegotiator
    {
        public DefaultContentNegotiator() { }
        public virtual System.Net.Http.Formatting.ContentNegotiationResult Negotiate(System.Type type, System.Net.Http.HttpRequestMessage request, System.Collections.Generic.IEnumerable<System.Net.Http.Formatting.MediaTypeFormatter> formatters) { throw null; }
    }
    public sealed partial class DelegatingEnumerable<T> : System.Collections.Generic.IEnumerable<T>, System.Collections.IEnumerable
    {
        public DelegatingEnumerable() { }
        public DelegatingEnumerable(System.Collections.Generic.IEnumerable<T> source) { }
        public void Add(object item) { }
        public System.Collections.Generic.IEnumerator<T> GetEnumerator() { throw null; }
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { throw null; }
    }
    public partial class FormDataCollection : System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<string, string>>, System.Collections.IEnumerable
    {
        public FormDataCollection(System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<string, string>> pairs) { }
        public FormDataCollection(string query) { }
        public FormDataCollection(System.Uri uri) { }
        public string Get(string key) { throw null; }
        public System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<string, string>> GetEnumerator() { throw null; }
        public string[] GetValues(string key) { throw null; }
        public System.Collections.Specialized.NameValueCollection ReadAsNameValueCollection() { throw null; }
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { throw null; }
    }
    public partial class FormUrlEncodedMediaTypeFormatter : System.Net.Http.Formatting.MediaTypeFormatter
    {
        public FormUrlEncodedMediaTypeFormatter() { }
        public static System.Net.Http.Headers.MediaTypeHeaderValue DefaultMediaType { get { throw null; } }
        public int MaxDepth { get { throw null; } set { } }
        public int ReadBufferSize { get { throw null; } set { } }
        public override bool CanReadType(System.Type type) { throw null; }
        public override bool CanWriteType(System.Type type) { throw null; }
        public override System.Threading.Tasks.Task<object> ReadFromStreamAsync(System.Type type, System.IO.Stream stream, System.Net.Http.Headers.HttpContentHeaders contentHeaders, System.Net.Http.Formatting.IFormatterLogger formatterLogger) { throw null; }
    }
    public partial interface IContentNegotiator
    {
        System.Net.Http.Formatting.ContentNegotiationResult Negotiate(System.Type type, System.Net.Http.HttpRequestMessage request, System.Collections.Generic.IEnumerable<System.Net.Http.Formatting.MediaTypeFormatter> formatters);
    }
    public partial interface IFormatterLogger
    {
        void LogError(string errorPath, string errorMessage);
    }
    public partial interface IRequiredMemberSelector
    {
        bool IsRequiredMember(System.Reflection.MemberInfo member);
    }
    public partial class JsonMediaTypeFormatter : System.Net.Http.Formatting.MediaTypeFormatter
    {
        public JsonMediaTypeFormatter() { }
        public static System.Net.Http.Headers.MediaTypeHeaderValue DefaultMediaType { get { throw null; } }
        public bool Indent { get { throw null; } set { } }
        public int MaxDepth { get { throw null; } set { } }
        public Newtonsoft.Json.JsonSerializerSettings SerializerSettings { get { throw null; } set { } }
        public bool UseDataContractJsonSerializer { get { throw null; } set { } }
        public override bool CanReadType(System.Type type) { throw null; }
        public override bool CanWriteType(System.Type type) { throw null; }
        public Newtonsoft.Json.JsonSerializerSettings CreateDefaultSerializerSettings() { throw null; }
        public override System.Threading.Tasks.Task<object> ReadFromStreamAsync(System.Type type, System.IO.Stream stream, System.Net.Http.Headers.HttpContentHeaders contentHeaders, System.Net.Http.Formatting.IFormatterLogger formatterLogger) { throw null; }
        public override System.Threading.Tasks.Task WriteToStreamAsync(System.Type type, object value, System.IO.Stream stream, System.Net.Http.Headers.HttpContentHeaders contentHeaders, System.Net.TransportContext transportContext) { throw null; }
    }
    public partial class MediaRangeMapping : System.Net.Http.Formatting.MediaTypeMapping
    {
        public MediaRangeMapping(System.Net.Http.Headers.MediaTypeHeaderValue mediaRange, System.Net.Http.Headers.MediaTypeHeaderValue mediaType) : base (default(System.Net.Http.Headers.MediaTypeHeaderValue)) { }
        public MediaRangeMapping(string mediaRange, string mediaType) : base (default(System.Net.Http.Headers.MediaTypeHeaderValue)) { }
        public System.Net.Http.Headers.MediaTypeHeaderValue MediaRange { get { throw null; } }
        public override double TryMatchMediaType(System.Net.Http.HttpRequestMessage request) { throw null; }
    }
    public abstract partial class MediaTypeFormatter
    {
        protected MediaTypeFormatter() { }
        public static int MaxHttpCollectionKeys { get { throw null; } set { } }
        public System.Collections.ObjectModel.Collection<System.Net.Http.Formatting.MediaTypeMapping> MediaTypeMappings { get { throw null; } }
        public System.Net.Http.Formatting.IRequiredMemberSelector RequiredMemberSelector { get { throw null; } set { } }
        public System.Collections.ObjectModel.Collection<System.Text.Encoding> SupportedEncodings { get { throw null; } }
        public System.Collections.ObjectModel.Collection<System.Net.Http.Headers.MediaTypeHeaderValue> SupportedMediaTypes { get { throw null; } }
        public abstract bool CanReadType(System.Type type);
        public abstract bool CanWriteType(System.Type type);
        protected internal static object GetDefaultValueForType(System.Type type) { throw null; }
        public virtual System.Net.Http.Formatting.MediaTypeFormatter GetPerRequestFormatterInstance(System.Type type, System.Net.Http.HttpRequestMessage request, System.Net.Http.Headers.MediaTypeHeaderValue mediaType) { throw null; }
        public virtual System.Threading.Tasks.Task<object> ReadFromStreamAsync(System.Type type, System.IO.Stream stream, System.Net.Http.Headers.HttpContentHeaders contentHeaders, System.Net.Http.Formatting.IFormatterLogger formatterLogger) { throw null; }
        protected System.Text.Encoding SelectCharacterEncoding(System.Net.Http.Headers.HttpContentHeaders contentHeaders) { throw null; }
        public virtual void SetDefaultContentHeaders(System.Type type, System.Net.Http.Headers.HttpContentHeaders headers, string mediaType) { }
        public virtual System.Threading.Tasks.Task WriteToStreamAsync(System.Type type, object value, System.IO.Stream stream, System.Net.Http.Headers.HttpContentHeaders contentHeaders, System.Net.TransportContext transportContext) { throw null; }
    }
    public partial class MediaTypeFormatterCollection : System.Collections.ObjectModel.Collection<System.Net.Http.Formatting.MediaTypeFormatter>
    {
        public MediaTypeFormatterCollection() { }
        public MediaTypeFormatterCollection(System.Collections.Generic.IEnumerable<System.Net.Http.Formatting.MediaTypeFormatter> formatters) { }
        public System.Net.Http.Formatting.FormUrlEncodedMediaTypeFormatter FormUrlEncodedFormatter { get { throw null; } }
        public System.Net.Http.Formatting.JsonMediaTypeFormatter JsonFormatter { get { throw null; } }
        public System.Net.Http.Formatting.XmlMediaTypeFormatter XmlFormatter { get { throw null; } }
        public System.Net.Http.Formatting.MediaTypeFormatter FindReader(System.Type type, System.Net.Http.Headers.MediaTypeHeaderValue mediaType) { throw null; }
        public System.Net.Http.Formatting.MediaTypeFormatter FindWriter(System.Type type, System.Net.Http.Headers.MediaTypeHeaderValue mediaType) { throw null; }
        public static bool IsTypeExcludedFromValidation(System.Type type) { throw null; }
    }
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    public static partial class MediaTypeFormatterExtensions
    {
        public static void AddMediaRangeMapping(this System.Net.Http.Formatting.MediaTypeFormatter formatter, System.Net.Http.Headers.MediaTypeHeaderValue mediaRange, System.Net.Http.Headers.MediaTypeHeaderValue mediaType) { }
        public static void AddMediaRangeMapping(this System.Net.Http.Formatting.MediaTypeFormatter formatter, string mediaRange, string mediaType) { }
        public static void AddQueryStringMapping(this System.Net.Http.Formatting.MediaTypeFormatter formatter, string queryStringParameterName, string queryStringParameterValue, System.Net.Http.Headers.MediaTypeHeaderValue mediaType) { }
        public static void AddQueryStringMapping(this System.Net.Http.Formatting.MediaTypeFormatter formatter, string queryStringParameterName, string queryStringParameterValue, string mediaType) { }
        public static void AddRequestHeaderMapping(this System.Net.Http.Formatting.MediaTypeFormatter formatter, string headerName, string headerValue, System.StringComparison valueComparison, bool isValueSubstring, System.Net.Http.Headers.MediaTypeHeaderValue mediaType) { }
        public static void AddRequestHeaderMapping(this System.Net.Http.Formatting.MediaTypeFormatter formatter, string headerName, string headerValue, System.StringComparison valueComparison, bool isValueSubstring, string mediaType) { }
    }
    public abstract partial class MediaTypeMapping
    {
        protected MediaTypeMapping(System.Net.Http.Headers.MediaTypeHeaderValue mediaType) { }
        protected MediaTypeMapping(string mediaType) { }
        public System.Net.Http.Headers.MediaTypeHeaderValue MediaType { get { throw null; } }
        public abstract double TryMatchMediaType(System.Net.Http.HttpRequestMessage request);
    }
    public partial class QueryStringMapping : System.Net.Http.Formatting.MediaTypeMapping
    {
        public QueryStringMapping(string queryStringParameterName, string queryStringParameterValue, System.Net.Http.Headers.MediaTypeHeaderValue mediaType) : base (default(System.Net.Http.Headers.MediaTypeHeaderValue)) { }
        public QueryStringMapping(string queryStringParameterName, string queryStringParameterValue, string mediaType) : base (default(System.Net.Http.Headers.MediaTypeHeaderValue)) { }
        public string QueryStringParameterName { get { throw null; } }
        public string QueryStringParameterValue { get { throw null; } }
        public override double TryMatchMediaType(System.Net.Http.HttpRequestMessage request) { throw null; }
    }
    public partial class RequestHeaderMapping : System.Net.Http.Formatting.MediaTypeMapping
    {
        public RequestHeaderMapping(string headerName, string headerValue, System.StringComparison valueComparison, bool isValueSubstring, System.Net.Http.Headers.MediaTypeHeaderValue mediaType) : base (default(System.Net.Http.Headers.MediaTypeHeaderValue)) { }
        public RequestHeaderMapping(string headerName, string headerValue, System.StringComparison valueComparison, bool isValueSubstring, string mediaType) : base (default(System.Net.Http.Headers.MediaTypeHeaderValue)) { }
        public string HeaderName { get { throw null; } }
        public string HeaderValue { get { throw null; } }
        public System.StringComparison HeaderValueComparison { get { throw null; } }
        public bool IsValueSubstring { get { throw null; } }
        public override double TryMatchMediaType(System.Net.Http.HttpRequestMessage request) { throw null; }
    }
    public partial class XmlMediaTypeFormatter : System.Net.Http.Formatting.MediaTypeFormatter
    {
        public XmlMediaTypeFormatter() { }
        public static System.Net.Http.Headers.MediaTypeHeaderValue DefaultMediaType { get { throw null; } }
        public bool Indent { get { throw null; } set { } }
        public int MaxDepth { get { throw null; } set { } }
        [System.ComponentModel.DefaultValueAttribute(false)]
        public bool UseXmlSerializer { get { throw null; } set { } }
        public override bool CanReadType(System.Type type) { throw null; }
        public override bool CanWriteType(System.Type type) { throw null; }
        public override System.Threading.Tasks.Task<object> ReadFromStreamAsync(System.Type type, System.IO.Stream stream, System.Net.Http.Headers.HttpContentHeaders contentHeaders, System.Net.Http.Formatting.IFormatterLogger formatterLogger) { throw null; }
        public bool RemoveSerializer(System.Type type) { throw null; }
        public void SetSerializer(System.Type type, System.Runtime.Serialization.XmlObjectSerializer serializer) { }
        public void SetSerializer(System.Type type, System.Xml.Serialization.XmlSerializer serializer) { }
        public void SetSerializer<T>(System.Runtime.Serialization.XmlObjectSerializer serializer) { }
        public void SetSerializer<T>(System.Xml.Serialization.XmlSerializer serializer) { }
        public override System.Threading.Tasks.Task WriteToStreamAsync(System.Type type, object value, System.IO.Stream stream, System.Net.Http.Headers.HttpContentHeaders contentHeaders, System.Net.TransportContext transportContext) { throw null; }
    }
}
namespace System.Net.Http.Headers
{
    public partial class CookieHeaderValue : System.ICloneable
    {
        protected CookieHeaderValue() { }
        public CookieHeaderValue(string name, System.Collections.Specialized.NameValueCollection values) { }
        public CookieHeaderValue(string name, string value) { }
        public System.Collections.ObjectModel.Collection<System.Net.Http.Headers.CookieState> Cookies { get { throw null; } }
        public string Domain { get { throw null; } set { } }
        public System.Nullable<System.DateTimeOffset> Expires { get { throw null; } set { } }
        public bool HttpOnly { get { throw null; } set { } }
        public System.Net.Http.Headers.CookieState this[string name] { get { throw null; } }
        public System.Nullable<System.TimeSpan> MaxAge { get { throw null; } set { } }
        public string Path { get { throw null; } set { } }
        public bool Secure { get { throw null; } set { } }
        public object Clone() { throw null; }
        public override string ToString() { throw null; }
        public static bool TryParse(string input, out System.Net.Http.Headers.CookieHeaderValue parsedValue) { throw null; }
    }
    public partial class CookieState : System.ICloneable
    {
        public CookieState(string name) { }
        public CookieState(string name, System.Collections.Specialized.NameValueCollection values) { }
        public CookieState(string name, string value) { }
        public string this[string name] { get { throw null; } set { } }
        public string Name { get { throw null; } set { } }
        public string Value { get { throw null; } set { } }
        public System.Collections.Specialized.NameValueCollection Values { get { throw null; } }
        public object Clone() { throw null; }
        public override string ToString() { throw null; }
    }
}
