// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

[assembly:System.Reflection.AssemblyVersionAttribute("4.0.0.0")]
[assembly:System.CLSCompliantAttribute(true)]
[assembly:System.Diagnostics.DebuggableAttribute((System.Diagnostics.DebuggableAttribute.DebuggingModes)(2))]
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
[assembly:System.Runtime.CompilerServices.ReferenceAssemblyAttribute]
[assembly:System.Runtime.CompilerServices.RuntimeCompatibilityAttribute(WrapNonExceptionThrows=true)]
[assembly:System.Runtime.InteropServices.ComVisibleAttribute(false)]
[assembly:System.Runtime.InteropServices.GuidAttribute("7fa1ae84-36e2-46b6-812c-c985a8e65e9a")]
[assembly:System.Security.SecurityTransparentAttribute]
namespace System.Net.Http
{
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
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
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
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
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    public static partial class HttpContentExtensions
    {
        public static System.Threading.Tasks.Task<object> ReadAsAsync(this System.Net.Http.HttpContent content, System.Type type) { throw null; }
        public static System.Threading.Tasks.Task<object> ReadAsAsync(this System.Net.Http.HttpContent content, System.Type type, System.Collections.Generic.IEnumerable<System.Net.Http.Formatting.MediaTypeFormatter> formatters) { throw null; }
        public static System.Threading.Tasks.Task<object> ReadAsAsync(this System.Net.Http.HttpContent content, System.Type type, System.Collections.Generic.IEnumerable<System.Net.Http.Formatting.MediaTypeFormatter> formatters, System.Net.Http.Formatting.IFormatterLogger formatterLogger) { throw null; }
        public static System.Threading.Tasks.Task<T> ReadAsAsync<T>(this System.Net.Http.HttpContent content) { throw null; }
        public static System.Threading.Tasks.Task<T> ReadAsAsync<T>(this System.Net.Http.HttpContent content, System.Collections.Generic.IEnumerable<System.Net.Http.Formatting.MediaTypeFormatter> formatters) { throw null; }
        public static System.Threading.Tasks.Task<T> ReadAsAsync<T>(this System.Net.Http.HttpContent content, System.Collections.Generic.IEnumerable<System.Net.Http.Formatting.MediaTypeFormatter> formatters, System.Net.Http.Formatting.IFormatterLogger formatterLogger) { throw null; }
    }
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
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
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
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
        public System.Net.Http.HttpRequestMessage HttpRequestMessage { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        public System.Net.Http.HttpResponseMessage HttpResponseMessage { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        protected override void Dispose(bool disposing) { }
        protected override System.Threading.Tasks.Task SerializeToStreamAsync(System.IO.Stream stream, System.Net.TransportContext context) { throw null; }
        protected override bool TryComputeLength(out long length) { length = default(long); throw null; }
    }
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    public static partial class HttpRequestHeadersExtensions
    {
        public static System.Collections.ObjectModel.Collection<System.Net.Http.Headers.CookieHeaderValue> GetCookies(this System.Net.Http.Headers.HttpRequestHeaders headers) { throw null; }
    }
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    public static partial class HttpRequestMessageExtensions
    {
        public static System.Net.Http.HttpResponseMessage CreateResponse(this System.Net.Http.HttpRequestMessage request) { throw null; }
        public static System.Net.Http.HttpResponseMessage CreateResponse(this System.Net.Http.HttpRequestMessage request, System.Net.HttpStatusCode statusCode) { throw null; }
    }
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
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
        public System.Type ObjectType { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        public object Value { get { throw null; } set { } }
        protected override System.Threading.Tasks.Task SerializeToStreamAsync(System.IO.Stream stream, System.Net.TransportContext context) { throw null; }
        protected override bool TryComputeLength(out long length) { length = default(long); throw null; }
    }
    public partial class ObjectContent<T> : System.Net.Http.ObjectContent
    {
        public ObjectContent(T value, System.Net.Http.Formatting.MediaTypeFormatter formatter) : base (default(System.Type), default(object), default(System.Net.Http.Formatting.MediaTypeFormatter)) { }
        public ObjectContent(T value, System.Net.Http.Formatting.MediaTypeFormatter formatter, string mediaType) : base (default(System.Type), default(object), default(System.Net.Http.Formatting.MediaTypeFormatter)) { }
    }
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    public static partial class UriExtensions
    {
        public static System.Collections.Specialized.NameValueCollection ParseQueryString(this System.Uri address) { throw null; }
        public static bool TryReadQueryAs(this System.Uri address, System.Type type, out object value) { value = default(object); throw null; }
        public static bool TryReadQueryAs<T>(this System.Uri address, out T value) { value = default(T); throw null; }
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
        public System.Net.Http.Headers.MediaTypeHeaderValue MediaType { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
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
        public bool Indent { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public int MaxDepth { get { throw null; } set { } }
        public bool UseDataContractJsonSerializer { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public override bool CanReadType(System.Type type) { throw null; }
        public override bool CanWriteType(System.Type type) { throw null; }
        public override System.Threading.Tasks.Task<object> ReadFromStreamAsync(System.Type type, System.IO.Stream stream, System.Net.Http.Headers.HttpContentHeaders contentHeaders, System.Net.Http.Formatting.IFormatterLogger formatterLogger) { throw null; }
        public override System.Threading.Tasks.Task WriteToStreamAsync(System.Type type, object value, System.IO.Stream stream, System.Net.Http.Headers.HttpContentHeaders contentHeaders, System.Net.TransportContext transportContext) { throw null; }
    }
    public partial class MediaRangeMapping : System.Net.Http.Formatting.MediaTypeMapping
    {
        public MediaRangeMapping(System.Net.Http.Headers.MediaTypeHeaderValue mediaRange, System.Net.Http.Headers.MediaTypeHeaderValue mediaType) : base (default(System.Net.Http.Headers.MediaTypeHeaderValue)) { }
        public MediaRangeMapping(string mediaRange, string mediaType) : base (default(System.Net.Http.Headers.MediaTypeHeaderValue)) { }
        public System.Net.Http.Headers.MediaTypeHeaderValue MediaRange { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        public override double TryMatchMediaType(System.Net.Http.HttpRequestMessage request) { throw null; }
    }
    public abstract partial class MediaTypeFormatter
    {
        protected MediaTypeFormatter() { }
        public static int MaxHttpCollectionKeys { get { throw null; } set { } }
        public System.Collections.ObjectModel.Collection<System.Net.Http.Formatting.MediaTypeMapping> MediaTypeMappings { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        public System.Net.Http.Formatting.IRequiredMemberSelector RequiredMemberSelector { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public System.Collections.ObjectModel.Collection<System.Text.Encoding> SupportedEncodings { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        public System.Collections.ObjectModel.Collection<System.Net.Http.Headers.MediaTypeHeaderValue> SupportedMediaTypes { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
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
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
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
        public System.Net.Http.Headers.MediaTypeHeaderValue MediaType { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        public abstract double TryMatchMediaType(System.Net.Http.HttpRequestMessage request);
    }
    public partial class QueryStringMapping : System.Net.Http.Formatting.MediaTypeMapping
    {
        public QueryStringMapping(string queryStringParameterName, string queryStringParameterValue, System.Net.Http.Headers.MediaTypeHeaderValue mediaType) : base (default(System.Net.Http.Headers.MediaTypeHeaderValue)) { }
        public QueryStringMapping(string queryStringParameterName, string queryStringParameterValue, string mediaType) : base (default(System.Net.Http.Headers.MediaTypeHeaderValue)) { }
        public string QueryStringParameterName { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        public string QueryStringParameterValue { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        public override double TryMatchMediaType(System.Net.Http.HttpRequestMessage request) { throw null; }
    }
    public partial class RequestHeaderMapping : System.Net.Http.Formatting.MediaTypeMapping
    {
        public RequestHeaderMapping(string headerName, string headerValue, System.StringComparison valueComparison, bool isValueSubstring, System.Net.Http.Headers.MediaTypeHeaderValue mediaType) : base (default(System.Net.Http.Headers.MediaTypeHeaderValue)) { }
        public RequestHeaderMapping(string headerName, string headerValue, System.StringComparison valueComparison, bool isValueSubstring, string mediaType) : base (default(System.Net.Http.Headers.MediaTypeHeaderValue)) { }
        public string HeaderName { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        public string HeaderValue { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        public System.StringComparison HeaderValueComparison { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        public bool IsValueSubstring { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        public override double TryMatchMediaType(System.Net.Http.HttpRequestMessage request) { throw null; }
    }
    public partial class XmlMediaTypeFormatter : System.Net.Http.Formatting.MediaTypeFormatter
    {
        public XmlMediaTypeFormatter() { }
        public static System.Net.Http.Headers.MediaTypeHeaderValue DefaultMediaType { get { throw null; } }
        public bool Indent { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public int MaxDepth { get { throw null; } set { } }
        [System.ComponentModel.DefaultValueAttribute(false)]
        public bool UseXmlSerializer { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
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
        public string Domain { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public System.Nullable<System.DateTimeOffset> Expires { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public bool HttpOnly { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public System.Net.Http.Headers.CookieState this[string name] { get { throw null; } }
        public System.Nullable<System.TimeSpan> MaxAge { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public string Path { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public bool Secure { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public object Clone() { throw null; }
        public override string ToString() { throw null; }
        public static bool TryParse(string input, out System.Net.Http.Headers.CookieHeaderValue parsedValue) { parsedValue = default(System.Net.Http.Headers.CookieHeaderValue); throw null; }
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
