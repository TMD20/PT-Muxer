// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

[assembly:System.Reflection.AssemblyVersionAttribute("2.0.0.0")]
[assembly:System.CLSCompliantAttribute(true)]
[assembly:System.Diagnostics.DebuggableAttribute((System.Diagnostics.DebuggableAttribute.DebuggingModes)(2))]
[assembly:System.Reflection.AssemblyCompanyAttribute("Microsoft Corporation")]
[assembly:System.Reflection.AssemblyConfigurationAttribute("")]
[assembly:System.Reflection.AssemblyCopyrightAttribute("© Microsoft Corporation. All rights reserved.")]
[assembly:System.Reflection.AssemblyDefaultAliasAttribute("System.Web.WebPages.dll")]
[assembly:System.Reflection.AssemblyDescriptionAttribute("")]
[assembly:System.Reflection.AssemblyFileVersionAttribute("2.0.0.0")]
[assembly:System.Reflection.AssemblyInformationalVersionAttribute("4.7.2046.0")]
[assembly:System.Reflection.AssemblyProductAttribute("Microsoft ASP.NET Web Pages")]
[assembly:System.Reflection.AssemblyTitleAttribute("System.Web.WebPages")]
[assembly:System.Reflection.AssemblyTrademarkAttribute("")]
[assembly:System.Resources.NeutralResourcesLanguageAttribute("en-US")]
[assembly:System.Resources.SatelliteContractVersionAttribute("4.0.0.0")]
[assembly:System.Runtime.CompilerServices.CompilationRelaxationsAttribute(8)]
[assembly:System.Runtime.CompilerServices.ReferenceAssemblyAttribute]
[assembly:System.Runtime.CompilerServices.RuntimeCompatibilityAttribute(WrapNonExceptionThrows=true)]
[assembly:System.Runtime.InteropServices.ComVisibleAttribute(false)]
[assembly:System.Security.SecurityTransparentAttribute]
[assembly:System.Web.PreApplicationStartMethodAttribute(typeof(System.Web.WebPages.PreApplicationStartCode), "Start")]
namespace System.Web.Helpers
{
    public static partial class AntiForgery
    {
        public static System.Web.HtmlString GetHtml() { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
        [System.ObsoleteAttribute("This method is deprecated. Use the GetHtml() method instead. To specify a custom domain for the generated cookie, use the <httpCookies> configuration element. To specify custom data to be embedded within the token, use the static AntiForgeryConfig.AdditionalDataProvider property.", true)]
        public static System.Web.HtmlString GetHtml(System.Web.HttpContextBase httpContext, string salt, string domain, string path) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(2))]
        public static void GetTokens(string oldCookieToken, out string newCookieToken, out string formToken) { newCookieToken = default(string); formToken = default(string); }
        public static void Validate() { }
        [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(2))]
        public static void Validate(string cookieToken, string formToken) { }
        [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
        [System.ObsoleteAttribute("This method is deprecated. Use the Validate() method instead.", true)]
        public static void Validate(System.Web.HttpContextBase httpContext, string salt) { }
    }
    public static partial class AntiForgeryConfig
    {
        public static System.Web.Helpers.IAntiForgeryAdditionalDataProvider AdditionalDataProvider { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public static string CookieName { get { throw null; } set { } }
        public static bool RequireSsl { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
        public static bool SuppressIdentityHeuristicChecks { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public static string UniqueClaimTypeIdentifier { get { throw null; } set { } }
    }
    public partial interface IAntiForgeryAdditionalDataProvider
    {
        string GetAdditionalData(System.Web.HttpContextBase context);
        bool ValidateAdditionalData(System.Web.HttpContextBase context, string additionalData);
    }
    public sealed partial class UnvalidatedRequestValues
    {
        internal UnvalidatedRequestValues() { }
        public System.Collections.Specialized.NameValueCollection Form { get { throw null; } }
        public string this[string key] { get { throw null; } }
        public System.Collections.Specialized.NameValueCollection QueryString { get { throw null; } }
    }
    public static partial class Validation
    {
        public static System.Web.Helpers.UnvalidatedRequestValues Unvalidated(this System.Web.HttpRequest request) { throw null; }
        public static string Unvalidated(this System.Web.HttpRequest request, string key) { throw null; }
        public static System.Web.Helpers.UnvalidatedRequestValues Unvalidated(this System.Web.HttpRequestBase request) { throw null; }
        public static string Unvalidated(this System.Web.HttpRequestBase request, string key) { throw null; }
    }
}
namespace System.Web.Mvc
{
    [System.Runtime.CompilerServices.TypeForwardedFromAttribute("System.Web.Mvc, Version=2.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35")]
    [System.SerializableAttribute]
    public sealed partial class HttpAntiForgeryException : System.Web.HttpException
    {
        public HttpAntiForgeryException() { }
        public HttpAntiForgeryException(string message) { }
        public HttpAntiForgeryException(string message, System.Exception innerException) { }
    }
    [System.Runtime.CompilerServices.TypeForwardedFromAttribute("System.Web.Mvc, Version=3.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35")]
    public partial class ModelClientValidationEqualToRule : System.Web.Mvc.ModelClientValidationRule
    {
        public ModelClientValidationEqualToRule(string errorMessage, object other) { }
    }
    [System.Runtime.CompilerServices.TypeForwardedFromAttribute("System.Web.Mvc, Version=3.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35")]
    public partial class ModelClientValidationRangeRule : System.Web.Mvc.ModelClientValidationRule
    {
        public ModelClientValidationRangeRule(string errorMessage, object minValue, object maxValue) { }
    }
    [System.Runtime.CompilerServices.TypeForwardedFromAttribute("System.Web.Mvc, Version=3.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35")]
    public partial class ModelClientValidationRegexRule : System.Web.Mvc.ModelClientValidationRule
    {
        public ModelClientValidationRegexRule(string errorMessage, string pattern) { }
    }
    [System.Runtime.CompilerServices.TypeForwardedFromAttribute("System.Web.Mvc, Version=3.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35")]
    public partial class ModelClientValidationRemoteRule : System.Web.Mvc.ModelClientValidationRule
    {
        public ModelClientValidationRemoteRule(string errorMessage, string url, string httpMethod, string additionalFields) { }
    }
    [System.Runtime.CompilerServices.TypeForwardedFromAttribute("System.Web.Mvc, Version=3.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35")]
    public partial class ModelClientValidationRequiredRule : System.Web.Mvc.ModelClientValidationRule
    {
        public ModelClientValidationRequiredRule(string errorMessage) { }
    }
    [System.Runtime.CompilerServices.TypeForwardedFromAttribute("System.Web.Mvc, Version=3.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35")]
    public partial class ModelClientValidationRule
    {
        public ModelClientValidationRule() { }
        public string ErrorMessage { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public System.Collections.Generic.IDictionary<string, object> ValidationParameters { get { throw null; } }
        public string ValidationType { get { throw null; } set { } }
    }
    [System.Runtime.CompilerServices.TypeForwardedFromAttribute("System.Web.Mvc, Version=3.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35")]
    public partial class ModelClientValidationStringLengthRule : System.Web.Mvc.ModelClientValidationRule
    {
        public ModelClientValidationStringLengthRule(string errorMessage, int minimumLength, int maximumLength) { }
    }
    [System.Runtime.CompilerServices.TypeForwardedFromAttribute("System.Web.Mvc, Version=2.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35")]
    public partial class TagBuilder
    {
        public TagBuilder(string tagName) { }
        public System.Collections.Generic.IDictionary<string, string> Attributes { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        public string IdAttributeDotReplacement { get { throw null; } set { } }
        public string InnerHtml { get { throw null; } set { } }
        public string TagName { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        public void AddCssClass(string value) { }
        public static string CreateSanitizedId(string originalId) { throw null; }
        public static string CreateSanitizedId(string originalId, string invalidCharReplacement) { throw null; }
        public void GenerateId(string name) { }
        public void MergeAttribute(string key, string value) { }
        public void MergeAttribute(string key, string value, bool replaceExisting) { }
        public void MergeAttributes<TKey, TValue>(System.Collections.Generic.IDictionary<TKey, TValue> attributes) { }
        public void MergeAttributes<TKey, TValue>(System.Collections.Generic.IDictionary<TKey, TValue> attributes, bool replaceExisting) { }
        public void SetInnerText(string innerText) { }
        public override string ToString() { throw null; }
        public string ToString(System.Web.Mvc.TagRenderMode renderMode) { throw null; }
    }
    [System.Runtime.CompilerServices.TypeForwardedFromAttribute("System.Web.Mvc, Version=2.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35")]
    public enum TagRenderMode
    {
        EndTag = 2,
        Normal = 0,
        SelfClosing = 3,
        StartTag = 1,
    }
    public static partial class UnobtrusiveValidationAttributesGenerator
    {
        public static void GetValidationAttributes(System.Collections.Generic.IEnumerable<System.Web.Mvc.ModelClientValidationRule> clientRules, System.Collections.Generic.IDictionary<string, object> results) { }
    }
}
namespace System.Web.WebPages
{
    public partial class ApplicationPart
    {
        public ApplicationPart(System.Reflection.Assembly assembly, string rootVirtualPath) { }
        public static string ProcessVirtualPath(System.Reflection.Assembly assembly, string baseVirtualPath, string virtualPath) { throw null; }
        public static void Register(System.Web.WebPages.ApplicationPart applicationPart) { }
    }
    public abstract partial class ApplicationStartPage : System.Web.WebPages.WebPageExecutingBase
    {
        public static readonly string CacheKeyPrefix;
        public static readonly string StartPageVirtualPath;
        protected ApplicationStartPage() { }
        public System.Web.HttpApplication Application { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        public override System.Web.HttpContextBase Context { get { throw null; } }
        public static System.Web.HtmlString Markup { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        public System.IO.TextWriter Output { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        public override string VirtualPath { get { throw null; } set { } }
        protected internal override System.IO.TextWriter GetOutputWriter() { throw null; }
        public override void Write(object value) { }
        public override void Write(System.Web.WebPages.HelperResult result) { }
        public override void WriteLiteral(object value) { }
    }
    public partial class AttributeValue
    {
        public AttributeValue(System.Web.WebPages.Instrumentation.PositionTagged<string> prefix, System.Web.WebPages.Instrumentation.PositionTagged<object> value, bool literal) { }
        public bool Literal { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        public System.Web.WebPages.Instrumentation.PositionTagged<string> Prefix { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        public System.Web.WebPages.Instrumentation.PositionTagged<object> Value { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        public static System.Web.WebPages.AttributeValue FromTuple(System.Tuple<System.Tuple<string, int>, System.Tuple<object, int>, bool> value) { throw null; }
        public static System.Web.WebPages.AttributeValue FromTuple(System.Tuple<System.Tuple<string, int>, System.Tuple<string, int>, bool> value) { throw null; }
        public static implicit operator System.Web.WebPages.AttributeValue (System.Tuple<System.Tuple<string, int>, System.Tuple<object, int>, bool> value) { throw null; }
        public static implicit operator System.Web.WebPages.AttributeValue (System.Tuple<System.Tuple<string, int>, System.Tuple<string, int>, bool> value) { throw null; }
    }
    public static partial class BrowserHelpers
    {
        public static void ClearOverriddenBrowser(this System.Web.HttpContextBase httpContext) { }
        public static System.Web.HttpBrowserCapabilitiesBase GetOverriddenBrowser(this System.Web.HttpContextBase httpContext) { throw null; }
        public static string GetOverriddenUserAgent(this System.Web.HttpContextBase httpContext) { throw null; }
        public static string GetVaryByCustomStringForOverriddenBrowser(this System.Web.HttpContext httpContext) { throw null; }
        public static string GetVaryByCustomStringForOverriddenBrowser(this System.Web.HttpContextBase httpContext) { throw null; }
        public static void SetOverriddenBrowser(this System.Web.HttpContextBase httpContext, string userAgent) { }
        public static void SetOverriddenBrowser(this System.Web.HttpContextBase httpContext, System.Web.WebPages.BrowserOverride browserOverride) { }
    }
    public enum BrowserOverride
    {
        Desktop = 0,
        Mobile = 1,
    }
    public abstract partial class BrowserOverrideStore
    {
        protected BrowserOverrideStore() { }
        public abstract string GetOverriddenUserAgent(System.Web.HttpContextBase httpContext);
        public abstract void SetOverriddenUserAgent(System.Web.HttpContextBase httpContext, string userAgent);
    }
    public partial class BrowserOverrideStores
    {
        public BrowserOverrideStores() { }
        public static System.Web.WebPages.BrowserOverrideStore Current { get { throw null; } set { } }
    }
    public partial class CookieBrowserOverrideStore : System.Web.WebPages.BrowserOverrideStore
    {
        public CookieBrowserOverrideStore() { }
        public CookieBrowserOverrideStore(int daysToExpire) { }
        public override string GetOverriddenUserAgent(System.Web.HttpContextBase httpContext) { throw null; }
        public override void SetOverriddenUserAgent(System.Web.HttpContextBase httpContext, string userAgent) { }
    }
    public partial class DefaultDisplayMode : System.Web.WebPages.IDisplayMode
    {
        public DefaultDisplayMode() { }
        public DefaultDisplayMode(string suffix) { }
        public System.Func<System.Web.HttpContextBase, bool> ContextCondition { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public virtual string DisplayModeId { get { throw null; } }
        public bool CanHandleContext(System.Web.HttpContextBase httpContext) { throw null; }
        public virtual System.Web.WebPages.DisplayInfo GetDisplayInfo(System.Web.HttpContextBase httpContext, string virtualPath, System.Func<string, bool> virtualPathExists) { throw null; }
        protected virtual string TransformPath(string virtualPath, string suffix) { throw null; }
    }
    public partial class DisplayInfo
    {
        public DisplayInfo(string filePath, System.Web.WebPages.IDisplayMode displayMode) { }
        public System.Web.WebPages.IDisplayMode DisplayMode { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        public string FilePath { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
    }
    public sealed partial class DisplayModeProvider
    {
        internal DisplayModeProvider() { }
        public static readonly string DefaultDisplayModeId;
        public static readonly string MobileDisplayModeId;
        public static System.Web.WebPages.DisplayModeProvider Instance { get { throw null; } }
        public System.Collections.Generic.IList<System.Web.WebPages.IDisplayMode> Modes { get { throw null; } }
        public bool RequireConsistentDisplayMode { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public System.Collections.Generic.IEnumerable<System.Web.WebPages.IDisplayMode> GetAvailableDisplayModesForContext(System.Web.HttpContextBase httpContext, System.Web.WebPages.IDisplayMode currentDisplayMode) { throw null; }
        public System.Web.WebPages.DisplayInfo GetDisplayInfoForVirtualPath(string virtualPath, System.Web.HttpContextBase httpContext, System.Func<string, bool> virtualPathExists, System.Web.WebPages.IDisplayMode currentDisplayMode) { throw null; }
    }
    public partial class HelperPage
    {
        public HelperPage() { }
        public static dynamic App { get { throw null; } }
        public static System.Web.HttpApplicationStateBase AppState { get { throw null; } }
        public static System.Web.Caching.Cache Cache { get { throw null; } }
        public static System.Web.HttpContextBase Context { get { throw null; } }
        public static System.Web.WebPages.WebPageRenderingBase CurrentPage { get { throw null; } }
        protected static string HelperVirtualPath { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public static System.Web.WebPages.Html.HtmlHelper Html { get { throw null; } }
        public static bool IsAjax { get { throw null; } }
        public static bool IsPost { get { throw null; } }
        public static dynamic Model { get { throw null; } }
        public static System.Web.WebPages.Html.ModelStateDictionary ModelState { get { throw null; } }
        public static dynamic Page { get { throw null; } }
        public static System.Web.WebPages.WebPageContext PageContext { get { throw null; } set { } }
        public static System.Collections.Generic.IDictionary<object,dynamic> PageData { get { throw null; } }
        public static System.Web.HttpRequestBase Request { get { throw null; } }
        public static System.Web.HttpResponseBase Response { get { throw null; } }
        public static System.Web.HttpServerUtilityBase Server { get { throw null; } }
        public static System.Web.HttpSessionStateBase Session { get { throw null; } }
        public static System.Collections.Generic.IList<string> UrlData { get { throw null; } }
        public static System.Security.Principal.IPrincipal User { get { throw null; } }
        public static string VirtualPath { get { throw null; } }
        public static void BeginContext(System.IO.TextWriter writer, string virtualPath, int startPosition, int length, bool isLiteral) { }
        public static void BeginContext(string virtualPath, int startPosition, int length, bool isLiteral) { }
        public static void EndContext(System.IO.TextWriter writer, string virtualPath, int startPosition, int length, bool isLiteral) { }
        public static void EndContext(string virtualPath, int startPosition, int length, bool isLiteral) { }
        public static string Href(string path, params object[] pathParts) { throw null; }
        public static void WriteAttributeTo(System.IO.TextWriter writer, string name, System.Web.WebPages.Instrumentation.PositionTagged<string> prefix, System.Web.WebPages.Instrumentation.PositionTagged<string> suffix, params System.Web.WebPages.AttributeValue[] values) { }
        public static void WriteLiteralTo(System.IO.TextWriter writer, object value) { }
        public static void WriteLiteralTo(System.IO.TextWriter writer, System.Web.WebPages.HelperResult value) { }
        public static void WriteTo(System.IO.TextWriter writer, object value) { }
        public static void WriteTo(System.IO.TextWriter writer, System.Web.WebPages.HelperResult value) { }
    }
    public partial class HelperResult : System.Web.IHtmlString
    {
        public HelperResult(System.Action<System.IO.TextWriter> action) { }
        public string ToHtmlString() { throw null; }
        public override string ToString() { throw null; }
        public void WriteTo(System.IO.TextWriter writer) { }
    }
    public static partial class HttpContextExtensions
    {
        public static void RedirectLocal(this System.Web.HttpContextBase context, string url) { }
        public static void RegisterForDispose(this System.Web.HttpContextBase context, System.IDisposable resource) { }
    }
    public partial interface IDisplayMode
    {
        string DisplayModeId { get; }
        bool CanHandleContext(System.Web.HttpContextBase httpContext);
        System.Web.WebPages.DisplayInfo GetDisplayInfo(System.Web.HttpContextBase httpContext, string virtualPath, System.Func<string, bool> virtualPathExists);
    }
    public partial interface ITemplateFile
    {
        System.Web.WebPages.TemplateFileInfo TemplateInfo { get; }
    }
    public partial interface IValidator
    {
        System.Web.Mvc.ModelClientValidationRule ClientValidationRule { get; }
        System.ComponentModel.DataAnnotations.ValidationResult Validate(System.ComponentModel.DataAnnotations.ValidationContext validationContext);
    }
    public partial interface IVirtualPathFactory
    {
        object CreateInstance(string virtualPath);
        bool Exists(string virtualPath);
    }
    public partial interface IWebPageRequestExecutor
    {
        bool Execute(System.Web.WebPages.WebPage page);
    }
    [System.AttributeUsageAttribute((System.AttributeTargets)(4), AllowMultiple=false, Inherited=true)]
    public sealed partial class PageVirtualPathAttribute : System.Attribute
    {
        public PageVirtualPathAttribute(string virtualPath) { }
        public string VirtualPath { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
    }
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    public static partial class PreApplicationStartCode
    {
        public static void Start() { }
    }
    public static partial class RequestExtensions
    {
        public static bool IsUrlLocalToHost(this System.Web.HttpRequestBase request, string url) { throw null; }
    }
    public abstract partial class RequestFieldValidatorBase : System.Web.WebPages.IValidator
    {
        protected RequestFieldValidatorBase(string errorMessage) { }
        protected RequestFieldValidatorBase(string errorMessage, bool useUnvalidatedValues) { }
        public virtual System.Web.Mvc.ModelClientValidationRule ClientValidationRule { get { throw null; } }
        protected static System.Web.HttpContextBase GetHttpContext(System.ComponentModel.DataAnnotations.ValidationContext validationContext) { throw null; }
        protected string GetRequestValue(System.Web.HttpRequestBase request, string field) { throw null; }
        protected abstract bool IsValid(System.Web.HttpContextBase httpContext, string value);
        public virtual System.ComponentModel.DataAnnotations.ValidationResult Validate(System.ComponentModel.DataAnnotations.ValidationContext validationContext) { throw null; }
    }
    public static partial class ResponseExtensions
    {
        public static void OutputCache(this System.Web.HttpResponseBase response, int numberOfSeconds, bool sliding=false, System.Collections.Generic.IEnumerable<string> varyByParams=null, System.Collections.Generic.IEnumerable<string> varyByHeaders=null, System.Collections.Generic.IEnumerable<string> varyByContentEncodings=null, System.Web.HttpCacheability cacheability=(System.Web.HttpCacheability)(4)) { }
        public static void SetStatus(this System.Web.HttpResponseBase response, int httpStatusCode) { }
        public static void SetStatus(this System.Web.HttpResponseBase response, System.Net.HttpStatusCode httpStatusCode) { }
        public static void WriteBinary(this System.Web.HttpResponseBase response, byte[] data) { }
        public static void WriteBinary(this System.Web.HttpResponseBase response, byte[] data, string mimeType) { }
    }
    public delegate void SectionWriter();
    public abstract partial class StartPage : System.Web.WebPages.WebPageRenderingBase
    {
        protected StartPage() { }
        public System.Web.WebPages.WebPageRenderingBase ChildPage { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public override System.Web.HttpContextBase Context { get { throw null; } set { } }
        public override string Layout { get { throw null; } set { } }
        public override dynamic Page { get { throw null; } }
        public override System.Collections.Generic.IDictionary<object,dynamic> PageData { get { throw null; } }
        public override void ExecutePageHierarchy() { }
        protected internal override System.IO.TextWriter GetOutputWriter() { throw null; }
        public static System.Web.WebPages.WebPageRenderingBase GetStartPage(System.Web.WebPages.WebPageRenderingBase page, string fileName, System.Collections.Generic.IEnumerable<string> supportedExtensions) { throw null; }
        public override System.Web.WebPages.HelperResult RenderPage(string path, params object[] data) { throw null; }
        public void RunPage() { }
        public override void Write(object value) { }
        public override void Write(System.Web.WebPages.HelperResult result) { }
        public override void WriteLiteral(object value) { }
    }
    public static partial class StringExtensions
    {
        public static bool AsBool(this string value) { throw null; }
        public static bool AsBool(this string value, bool defaultValue) { throw null; }
        public static System.DateTime AsDateTime(this string value) { throw null; }
        public static System.DateTime AsDateTime(this string value, System.DateTime defaultValue) { throw null; }
        public static decimal AsDecimal(this string value) { throw null; }
        public static decimal AsDecimal(this string value, decimal defaultValue) { throw null; }
        public static float AsFloat(this string value) { throw null; }
        public static float AsFloat(this string value, float defaultValue) { throw null; }
        public static int AsInt(this string value) { throw null; }
        public static int AsInt(this string value, int defaultValue) { throw null; }
        public static TValue As<TValue>(this string value) { throw null; }
        public static TValue As<TValue>(this string value, TValue defaultValue) { throw null; }
        public static bool IsBool(this string value) { throw null; }
        public static bool IsDateTime(this string value) { throw null; }
        public static bool IsDecimal(this string value) { throw null; }
        public static bool IsEmpty(this string value) { throw null; }
        public static bool IsFloat(this string value) { throw null; }
        public static bool IsInt(this string value) { throw null; }
        public static bool Is<TValue>(this string value) { throw null; }
    }
    public partial class TemplateFileInfo
    {
        public TemplateFileInfo(string virtualPath) { }
        public string VirtualPath { get { throw null; } }
    }
    public static partial class TemplateStack
    {
        public static System.Web.WebPages.ITemplateFile GetCurrentTemplate(System.Web.HttpContextBase httpContext) { throw null; }
        public static System.Web.WebPages.ITemplateFile Pop(System.Web.HttpContextBase httpContext) { throw null; }
        public static void Push(System.Web.HttpContextBase httpContext, System.Web.WebPages.ITemplateFile templateFile) { }
    }
    public sealed partial class ValidationHelper
    {
        internal ValidationHelper() { }
        public string FormField { get { throw null; } }
        public static string InvalidCssClass { get { throw null; } set { } }
        public static string ValidCssClass { get { throw null; } set { } }
        public void Add(System.Collections.Generic.IEnumerable<string> fields, params System.Web.WebPages.IValidator[] validators) { }
        public void Add(string field, params System.Web.WebPages.IValidator[] validators) { }
        public void AddFormError(string errorMessage) { }
        public System.Web.HtmlString ClassFor(string field) { throw null; }
        public System.Web.HtmlString For(string field) { throw null; }
        public System.Collections.Generic.IEnumerable<string> GetErrors(params string[] fields) { throw null; }
        public bool IsValid(params string[] fields) { throw null; }
        public void RequireField(string field) { }
        public void RequireField(string field, string errorMessage) { }
        public void RequireFields(params string[] fields) { }
        public System.Collections.Generic.IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> Validate(params string[] fields) { throw null; }
    }
    public abstract partial class Validator
    {
        protected Validator() { }
        public static System.Web.WebPages.IValidator DateTime(string errorMessage=null) { throw null; }
        public static System.Web.WebPages.IValidator Decimal(string errorMessage=null) { throw null; }
        public static System.Web.WebPages.IValidator EqualsTo(string otherFieldName, string errorMessage=null) { throw null; }
        public static System.Web.WebPages.IValidator Float(string errorMessage=null) { throw null; }
        public static System.Web.WebPages.IValidator Integer(string errorMessage=null) { throw null; }
        public static System.Web.WebPages.IValidator Range(double minValue, double maxValue, string errorMessage=null) { throw null; }
        public static System.Web.WebPages.IValidator Range(int minValue, int maxValue, string errorMessage=null) { throw null; }
        public static System.Web.WebPages.IValidator Regex(string pattern, string errorMessage=null) { throw null; }
        public static System.Web.WebPages.IValidator Required(string errorMessage=null) { throw null; }
        public static System.Web.WebPages.IValidator StringLength(int maxLength, int minLength=0, string errorMessage=null) { throw null; }
        public static System.Web.WebPages.IValidator Url(string errorMessage=null) { throw null; }
    }
    public partial class VirtualPathFactoryManager : System.Web.WebPages.IVirtualPathFactory
    {
        internal VirtualPathFactoryManager() { }
        public object CreateInstance(string virtualPath) { throw null; }
        public bool Exists(string virtualPath) { throw null; }
        public static void RegisterVirtualPathFactory(System.Web.WebPages.IVirtualPathFactory virtualPathFactory) { }
    }
    public abstract partial class WebPage : System.Web.WebPages.WebPageBase
    {
        protected WebPage() { }
        public override System.Web.HttpContextBase Context { get { throw null; } set { } }
        public System.Web.WebPages.Html.HtmlHelper Html { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        public dynamic Model { get { throw null; } }
        public System.Web.WebPages.Html.ModelStateDictionary ModelState { get { throw null; } }
        public System.Web.WebPages.ValidationHelper Validation { get { throw null; } }
        public override void ExecutePageHierarchy() { }
        protected override void InitializePage() { }
        public static void RegisterPageExecutor(System.Web.WebPages.IWebPageRequestExecutor executor) { }
        public override System.Web.WebPages.HelperResult RenderPage(string path, params object[] data) { throw null; }
    }
    public abstract partial class WebPageBase : System.Web.WebPages.WebPageRenderingBase
    {
        protected WebPageBase() { }
        public override string Layout { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public System.IO.TextWriter Output { get { throw null; } }
        public System.Collections.Generic.Stack<System.IO.TextWriter> OutputStack { get { throw null; } }
        public override dynamic Page { get { throw null; } }
        public override System.Collections.Generic.IDictionary<object,dynamic> PageData { get { throw null; } }
        protected virtual void ConfigurePage(System.Web.WebPages.WebPageBase parentPage) { }
        public static System.Web.WebPages.WebPageBase CreateInstanceFromVirtualPath(string virtualPath) { throw null; }
        public void DefineSection(string name, System.Web.WebPages.SectionWriter action) { }
        public override void ExecutePageHierarchy() { }
        public void ExecutePageHierarchy(System.Web.WebPages.WebPageContext pageContext, System.IO.TextWriter writer) { }
        public void ExecutePageHierarchy(System.Web.WebPages.WebPageContext pageContext, System.IO.TextWriter writer, System.Web.WebPages.WebPageRenderingBase startPage) { }
        protected internal override System.IO.TextWriter GetOutputWriter() { throw null; }
        protected virtual void InitializePage() { }
        public bool IsSectionDefined(string name) { throw null; }
        public void PopContext() { }
        public void PushContext(System.Web.WebPages.WebPageContext pageContext, System.IO.TextWriter writer) { }
        public System.Web.WebPages.HelperResult RenderBody() { throw null; }
        public override System.Web.WebPages.HelperResult RenderPage(string path, params object[] data) { throw null; }
        public System.Web.WebPages.HelperResult RenderSection(string name) { throw null; }
        public System.Web.WebPages.HelperResult RenderSection(string name, bool required) { throw null; }
        public override void Write(object value) { }
        public override void Write(System.Web.WebPages.HelperResult result) { }
        public override void WriteLiteral(object value) { }
    }
    public partial class WebPageContext
    {
        public WebPageContext() { }
        public WebPageContext(System.Web.HttpContextBase context, System.Web.WebPages.WebPageRenderingBase page, object model) { }
        public static System.Web.WebPages.WebPageContext Current { get { throw null; } }
        public object Model { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        public System.Web.WebPages.WebPageRenderingBase Page { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        public System.Collections.Generic.IDictionary<object,dynamic> PageData { get { throw null; } }
    }
    public abstract partial class WebPageExecutingBase
    {
        protected WebPageExecutingBase() { }
        public virtual dynamic App { get { throw null; } }
        public virtual System.Web.HttpApplicationStateBase AppState { get { throw null; } }
        public virtual System.Web.HttpContextBase Context { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public virtual string VirtualPath { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
        public virtual System.Web.WebPages.IVirtualPathFactory VirtualPathFactory { get { throw null; } set { } }
        protected internal void BeginContext(int startPosition, int length, bool isLiteral) { }
        protected internal void BeginContext(System.IO.TextWriter writer, int startPosition, int length, bool isLiteral) { }
        protected internal void BeginContext(System.IO.TextWriter writer, string virtualPath, int startPosition, int length, bool isLiteral) { }
        protected internal void BeginContext(string virtualPath, int startPosition, int length, bool isLiteral) { }
        protected internal void EndContext(int startPosition, int length, bool isLiteral) { }
        protected internal void EndContext(System.IO.TextWriter writer, int startPosition, int length, bool isLiteral) { }
        protected internal void EndContext(System.IO.TextWriter writer, string virtualPath, int startPosition, int length, bool isLiteral) { }
        protected internal void EndContext(string virtualPath, int startPosition, int length, bool isLiteral) { }
        [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
        public abstract void Execute();
        protected internal virtual System.IO.TextWriter GetOutputWriter() { throw null; }
        public virtual string Href(string path, params object[] pathParts) { throw null; }
        public virtual string NormalizePath(string path) { throw null; }
        public abstract void Write(object value);
        public abstract void Write(System.Web.WebPages.HelperResult result);
        public virtual void WriteAttribute(string name, System.Web.WebPages.Instrumentation.PositionTagged<string> prefix, System.Web.WebPages.Instrumentation.PositionTagged<string> suffix, params System.Web.WebPages.AttributeValue[] values) { }
        public virtual void WriteAttributeTo(System.IO.TextWriter writer, string name, System.Web.WebPages.Instrumentation.PositionTagged<string> prefix, System.Web.WebPages.Instrumentation.PositionTagged<string> suffix, params System.Web.WebPages.AttributeValue[] values) { }
        protected internal virtual void WriteAttributeTo(string pageVirtualPath, System.IO.TextWriter writer, string name, System.Web.WebPages.Instrumentation.PositionTagged<string> prefix, System.Web.WebPages.Instrumentation.PositionTagged<string> suffix, params System.Web.WebPages.AttributeValue[] values) { }
        public abstract void WriteLiteral(object value);
        public static void WriteLiteralTo(System.IO.TextWriter writer, object content) { }
        public static void WriteTo(System.IO.TextWriter writer, object content) { }
        public static void WriteTo(System.IO.TextWriter writer, System.Web.WebPages.HelperResult content) { }
    }
    public partial class WebPageHttpHandler : System.Web.IHttpHandler, System.Web.SessionState.IRequiresSessionState
    {
        public static readonly string WebPagesVersionHeaderName;
        public WebPageHttpHandler(System.Web.WebPages.WebPage webPage) { }
        public static bool DisableWebPagesResponseHeader { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public virtual bool IsReusable { get { throw null; } }
        public static System.Web.IHttpHandler CreateFromVirtualPath(string virtualPath) { throw null; }
        public static System.Collections.ObjectModel.ReadOnlyCollection<string> GetRegisteredExtensions() { throw null; }
        public virtual void ProcessRequest(System.Web.HttpContext context) { }
        public static void RegisterExtension(string extension) { }
    }
    public abstract partial class WebPageRenderingBase : System.Web.WebPages.WebPageExecutingBase, System.Web.WebPages.ITemplateFile
    {
        protected WebPageRenderingBase() { }
        public virtual System.Web.Caching.Cache Cache { get { throw null; } }
        public string Culture { get { throw null; } set { } }
        protected internal System.Web.WebPages.IDisplayMode DisplayMode { get { throw null; } }
        public virtual bool IsAjax { get { throw null; } }
        public virtual bool IsPost { get { throw null; } }
        public abstract string Layout { get; set; }
        public abstract dynamic Page { get; }
        public System.Web.WebPages.WebPageContext PageContext { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        public abstract System.Collections.Generic.IDictionary<object,dynamic> PageData { get; }
        public System.Web.Profile.ProfileBase Profile { get { throw null; } }
        public virtual System.Web.HttpRequestBase Request { get { throw null; } }
        public virtual System.Web.HttpResponseBase Response { get { throw null; } }
        public virtual System.Web.HttpServerUtilityBase Server { get { throw null; } }
        public virtual System.Web.HttpSessionStateBase Session { get { throw null; } }
        public virtual System.Web.WebPages.TemplateFileInfo TemplateInfo { get { throw null; } }
        public string UICulture { get { throw null; } set { } }
        public virtual System.Collections.Generic.IList<string> UrlData { get { throw null; } }
        public virtual System.Security.Principal.IPrincipal User { get { throw null; } }
        public abstract void ExecutePageHierarchy();
        public abstract System.Web.WebPages.HelperResult RenderPage(string path, params object[] data);
    }
}
namespace System.Web.WebPages.Html
{
    public partial class HtmlHelper
    {
        internal HtmlHelper() { }
        public static string IdAttributeDotReplacement { get { throw null; } set { } }
        public static bool UnobtrusiveJavaScriptEnabled { get { throw null; } set { } }
        public static string ValidationInputCssClassName { get { throw null; } set { } }
        public static string ValidationInputValidCssClassName { get { throw null; } set { } }
        public static string ValidationMessageCssClassName { get { throw null; } set { } }
        public static string ValidationMessageValidCssClassName { get { throw null; } set { } }
        public static string ValidationSummaryClass { get { throw null; } set { } }
        public static string ValidationSummaryValidClass { get { throw null; } set { } }
        public string AttributeEncode(object value) { throw null; }
        public string AttributeEncode(string value) { throw null; }
        public System.Web.IHtmlString CheckBox(string name) { throw null; }
        public System.Web.IHtmlString CheckBox(string name, bool isChecked) { throw null; }
        public System.Web.IHtmlString CheckBox(string name, bool isChecked, System.Collections.Generic.IDictionary<string, object> htmlAttributes) { throw null; }
        public System.Web.IHtmlString CheckBox(string name, bool isChecked, object htmlAttributes) { throw null; }
        public System.Web.IHtmlString CheckBox(string name, System.Collections.Generic.IDictionary<string, object> htmlAttributes) { throw null; }
        public System.Web.IHtmlString CheckBox(string name, object htmlAttributes) { throw null; }
        public System.Web.IHtmlString DropDownList(string name, System.Collections.Generic.IEnumerable<System.Web.WebPages.Html.SelectListItem> selectList) { throw null; }
        public System.Web.IHtmlString DropDownList(string name, System.Collections.Generic.IEnumerable<System.Web.WebPages.Html.SelectListItem> selectList, System.Collections.Generic.IDictionary<string, object> htmlAttributes) { throw null; }
        public System.Web.IHtmlString DropDownList(string name, System.Collections.Generic.IEnumerable<System.Web.WebPages.Html.SelectListItem> selectList, object htmlAttributes) { throw null; }
        public System.Web.IHtmlString DropDownList(string name, string defaultOption, System.Collections.Generic.IEnumerable<System.Web.WebPages.Html.SelectListItem> selectList) { throw null; }
        public System.Web.IHtmlString DropDownList(string name, string defaultOption, System.Collections.Generic.IEnumerable<System.Web.WebPages.Html.SelectListItem> selectList, System.Collections.Generic.IDictionary<string, object> htmlAttributes) { throw null; }
        public System.Web.IHtmlString DropDownList(string name, string defaultOption, System.Collections.Generic.IEnumerable<System.Web.WebPages.Html.SelectListItem> selectList, object htmlAttributes) { throw null; }
        public System.Web.IHtmlString DropDownList(string name, string defaultOption, System.Collections.Generic.IEnumerable<System.Web.WebPages.Html.SelectListItem> selectList, object selectedValue, System.Collections.Generic.IDictionary<string, object> htmlAttributes) { throw null; }
        public System.Web.IHtmlString DropDownList(string name, string defaultOption, System.Collections.Generic.IEnumerable<System.Web.WebPages.Html.SelectListItem> selectList, object selectedValue, object htmlAttributes) { throw null; }
        public string Encode(object value) { throw null; }
        public string Encode(string value) { throw null; }
        public System.Web.IHtmlString Hidden(string name) { throw null; }
        public System.Web.IHtmlString Hidden(string name, object value) { throw null; }
        public System.Web.IHtmlString Hidden(string name, object value, System.Collections.Generic.IDictionary<string, object> htmlAttributes) { throw null; }
        public System.Web.IHtmlString Hidden(string name, object value, object htmlAttributes) { throw null; }
        public System.Web.IHtmlString Label(string labelText) { throw null; }
        public System.Web.IHtmlString Label(string labelText, object attributes) { throw null; }
        public System.Web.IHtmlString Label(string labelText, string labelFor) { throw null; }
        public System.Web.IHtmlString Label(string labelText, string labelFor, System.Collections.Generic.IDictionary<string, object> attributes) { throw null; }
        public System.Web.IHtmlString Label(string labelText, string labelFor, object attributes) { throw null; }
        public System.Web.IHtmlString ListBox(string name, System.Collections.Generic.IEnumerable<System.Web.WebPages.Html.SelectListItem> selectList) { throw null; }
        public System.Web.IHtmlString ListBox(string name, System.Collections.Generic.IEnumerable<System.Web.WebPages.Html.SelectListItem> selectList, System.Collections.Generic.IDictionary<string, object> htmlAttributes) { throw null; }
        public System.Web.IHtmlString ListBox(string name, System.Collections.Generic.IEnumerable<System.Web.WebPages.Html.SelectListItem> selectList, object htmlAttributes) { throw null; }
        public System.Web.IHtmlString ListBox(string name, System.Collections.Generic.IEnumerable<System.Web.WebPages.Html.SelectListItem> selectList, object selectedValues, int size, bool allowMultiple) { throw null; }
        public System.Web.IHtmlString ListBox(string name, string defaultOption, System.Collections.Generic.IEnumerable<System.Web.WebPages.Html.SelectListItem> selectList) { throw null; }
        public System.Web.IHtmlString ListBox(string name, string defaultOption, System.Collections.Generic.IEnumerable<System.Web.WebPages.Html.SelectListItem> selectList, System.Collections.Generic.IDictionary<string, object> htmlAttributes) { throw null; }
        public System.Web.IHtmlString ListBox(string name, string defaultOption, System.Collections.Generic.IEnumerable<System.Web.WebPages.Html.SelectListItem> selectList, object htmlAttributes) { throw null; }
        public System.Web.IHtmlString ListBox(string name, string defaultOption, System.Collections.Generic.IEnumerable<System.Web.WebPages.Html.SelectListItem> selectList, object selectedValues, System.Collections.Generic.IDictionary<string, object> htmlAttributes) { throw null; }
        public System.Web.IHtmlString ListBox(string name, string defaultOption, System.Collections.Generic.IEnumerable<System.Web.WebPages.Html.SelectListItem> selectList, object selectedValues, int size, bool allowMultiple) { throw null; }
        public System.Web.IHtmlString ListBox(string name, string defaultOption, System.Collections.Generic.IEnumerable<System.Web.WebPages.Html.SelectListItem> selectList, object selectedValues, int size, bool allowMultiple, System.Collections.Generic.IDictionary<string, object> htmlAttributes) { throw null; }
        public System.Web.IHtmlString ListBox(string name, string defaultOption, System.Collections.Generic.IEnumerable<System.Web.WebPages.Html.SelectListItem> selectList, object selectedValues, int size, bool allowMultiple, object htmlAttributes) { throw null; }
        public System.Web.IHtmlString ListBox(string name, string defaultOption, System.Collections.Generic.IEnumerable<System.Web.WebPages.Html.SelectListItem> selectList, object selectedValues, object htmlAttributes) { throw null; }
        public System.Web.IHtmlString Password(string name) { throw null; }
        public System.Web.IHtmlString Password(string name, object value) { throw null; }
        public System.Web.IHtmlString Password(string name, object value, System.Collections.Generic.IDictionary<string, object> htmlAttributes) { throw null; }
        public System.Web.IHtmlString Password(string name, object value, object htmlAttributes) { throw null; }
        public System.Web.IHtmlString RadioButton(string name, object value) { throw null; }
        public System.Web.IHtmlString RadioButton(string name, object value, bool isChecked) { throw null; }
        public System.Web.IHtmlString RadioButton(string name, object value, bool isChecked, System.Collections.Generic.IDictionary<string, object> htmlAttributes) { throw null; }
        public System.Web.IHtmlString RadioButton(string name, object value, bool isChecked, object htmlAttributes) { throw null; }
        public System.Web.IHtmlString RadioButton(string name, object value, System.Collections.Generic.IDictionary<string, object> htmlAttributes) { throw null; }
        public System.Web.IHtmlString RadioButton(string name, object value, object htmlAttributes) { throw null; }
        public System.Web.IHtmlString Raw(object value) { throw null; }
        public System.Web.IHtmlString Raw(string value) { throw null; }
        public System.Web.IHtmlString TextArea(string name) { throw null; }
        public System.Web.IHtmlString TextArea(string name, System.Collections.Generic.IDictionary<string, object> htmlAttributes) { throw null; }
        public System.Web.IHtmlString TextArea(string name, object htmlAttributes) { throw null; }
        public System.Web.IHtmlString TextArea(string name, string value) { throw null; }
        public System.Web.IHtmlString TextArea(string name, string value, System.Collections.Generic.IDictionary<string, object> htmlAttributes) { throw null; }
        public System.Web.IHtmlString TextArea(string name, string value, int rows, int columns, System.Collections.Generic.IDictionary<string, object> htmlAttributes) { throw null; }
        public System.Web.IHtmlString TextArea(string name, string value, int rows, int columns, object htmlAttributes) { throw null; }
        public System.Web.IHtmlString TextArea(string name, string value, object htmlAttributes) { throw null; }
        public System.Web.IHtmlString TextBox(string name) { throw null; }
        public System.Web.IHtmlString TextBox(string name, object value) { throw null; }
        public System.Web.IHtmlString TextBox(string name, object value, System.Collections.Generic.IDictionary<string, object> htmlAttributes) { throw null; }
        public System.Web.IHtmlString TextBox(string name, object value, object htmlAttributes) { throw null; }
        public System.Web.IHtmlString ValidationMessage(string name) { throw null; }
        public System.Web.IHtmlString ValidationMessage(string name, System.Collections.Generic.IDictionary<string, object> htmlAttributes) { throw null; }
        public System.Web.IHtmlString ValidationMessage(string name, object htmlAttributes) { throw null; }
        public System.Web.IHtmlString ValidationMessage(string name, string message) { throw null; }
        public System.Web.IHtmlString ValidationMessage(string name, string message, System.Collections.Generic.IDictionary<string, object> htmlAttributes) { throw null; }
        public System.Web.IHtmlString ValidationMessage(string name, string message, object htmlAttributes) { throw null; }
        public System.Web.IHtmlString ValidationSummary() { throw null; }
        public System.Web.IHtmlString ValidationSummary(bool excludeFieldErrors) { throw null; }
        public System.Web.IHtmlString ValidationSummary(System.Collections.Generic.IDictionary<string, object> htmlAttributes) { throw null; }
        public System.Web.IHtmlString ValidationSummary(object htmlAttributes) { throw null; }
        public System.Web.IHtmlString ValidationSummary(string message) { throw null; }
        public System.Web.IHtmlString ValidationSummary(string message, bool excludeFieldErrors, System.Collections.Generic.IDictionary<string, object> htmlAttributes) { throw null; }
        public System.Web.IHtmlString ValidationSummary(string message, bool excludeFieldErrors, object htmlAttributes) { throw null; }
        public System.Web.IHtmlString ValidationSummary(string message, System.Collections.Generic.IDictionary<string, object> htmlAttributes) { throw null; }
        public System.Web.IHtmlString ValidationSummary(string message, object htmlAttributes) { throw null; }
    }
    public partial class ModelState
    {
        public ModelState() { }
        public System.Collections.Generic.IList<string> Errors { get { throw null; } }
        public object Value { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    }
    public partial class ModelStateDictionary : System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<string, System.Web.WebPages.Html.ModelState>>, System.Collections.Generic.IDictionary<string, System.Web.WebPages.Html.ModelState>, System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<string, System.Web.WebPages.Html.ModelState>>, System.Collections.IEnumerable
    {
        public ModelStateDictionary() { }
        public ModelStateDictionary(System.Web.WebPages.Html.ModelStateDictionary dictionary) { }
        public int Count { get { throw null; } }
        public bool IsReadOnly { get { throw null; } }
        public bool IsValid { get { throw null; } }
        public System.Web.WebPages.Html.ModelState this[string key] { get { throw null; } set { } }
        public System.Collections.Generic.ICollection<string> Keys { get { throw null; } }
        public System.Collections.Generic.ICollection<System.Web.WebPages.Html.ModelState> Values { get { throw null; } }
        public void Add(System.Collections.Generic.KeyValuePair<string, System.Web.WebPages.Html.ModelState> item) { }
        public void Add(string key, System.Web.WebPages.Html.ModelState value) { }
        public void AddError(string key, string errorMessage) { }
        public void AddFormError(string errorMessage) { }
        public void Clear() { }
        public bool Contains(System.Collections.Generic.KeyValuePair<string, System.Web.WebPages.Html.ModelState> item) { throw null; }
        public bool ContainsKey(string key) { throw null; }
        public void CopyTo(System.Collections.Generic.KeyValuePair<string, System.Web.WebPages.Html.ModelState>[] array, int arrayIndex) { }
        public System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<string, System.Web.WebPages.Html.ModelState>> GetEnumerator() { throw null; }
        public bool IsValidField(string key) { throw null; }
        public void Merge(System.Web.WebPages.Html.ModelStateDictionary dictionary) { }
        public bool Remove(System.Collections.Generic.KeyValuePair<string, System.Web.WebPages.Html.ModelState> item) { throw null; }
        public bool Remove(string key) { throw null; }
        public void SetModelValue(string key, object value) { }
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { throw null; }
        public bool TryGetValue(string key, out System.Web.WebPages.Html.ModelState value) { value = default(System.Web.WebPages.Html.ModelState); throw null; }
    }
    public partial class SelectListItem
    {
        public SelectListItem() { }
        public SelectListItem(System.Web.WebPages.Html.SelectListItem item) { }
        public bool Selected { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public string Text { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public string Value { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    }
}
namespace System.Web.WebPages.Instrumentation
{
    public partial class InstrumentationService
    {
        public InstrumentationService() { }
        public bool IsAvailable { get { throw null; } }
        public void BeginContext(System.Web.HttpContextBase context, string virtualPath, System.IO.TextWriter writer, int startPosition, int length, bool isLiteral) { }
        public void EndContext(System.Web.HttpContextBase context, string virtualPath, System.IO.TextWriter writer, int startPosition, int length, bool isLiteral) { }
    }
    [System.Diagnostics.DebuggerDisplayAttribute("({Position})\"{Value}\"")]
    public partial class PositionTagged<T>
    {
        public PositionTagged(T value, int offset) { }
        public int Position { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        public T Value { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        public override bool Equals(object obj) { throw null; }
        public override int GetHashCode() { throw null; }
        public static bool operator ==(System.Web.WebPages.Instrumentation.PositionTagged<T> left, System.Web.WebPages.Instrumentation.PositionTagged<T> right) { throw null; }
        public static implicit operator System.Web.WebPages.Instrumentation.PositionTagged<T> (System.Tuple<T, int> value) { throw null; }
        public static implicit operator T (System.Web.WebPages.Instrumentation.PositionTagged<T> value) { throw null; }
        public static bool operator !=(System.Web.WebPages.Instrumentation.PositionTagged<T> left, System.Web.WebPages.Instrumentation.PositionTagged<T> right) { throw null; }
        public override string ToString() { throw null; }
    }
}
namespace System.Web.WebPages.Scope
{
    public partial class AspNetRequestScopeStorageProvider : System.Web.WebPages.Scope.IScopeStorageProvider
    {
        public AspNetRequestScopeStorageProvider() { }
        public System.Collections.Generic.IDictionary<object, object> ApplicationScope { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        public System.Collections.Generic.IDictionary<object, object> CurrentScope { get { throw null; } set { } }
        public System.Collections.Generic.IDictionary<object, object> GlobalScope { get { throw null; } }
        public System.Collections.Generic.IDictionary<object, object> RequestScope { get { throw null; } }
    }
    public partial interface IScopeStorageProvider
    {
        System.Collections.Generic.IDictionary<object, object> CurrentScope { get; set; }
        System.Collections.Generic.IDictionary<object, object> GlobalScope { get; }
    }
    public static partial class ScopeStorage
    {
        public static System.Web.WebPages.Scope.IScopeStorageProvider CurrentProvider { get { throw null; } set { } }
        public static System.Collections.Generic.IDictionary<object, object> CurrentScope { get { throw null; } }
        public static System.Collections.Generic.IDictionary<object, object> GlobalScope { get { throw null; } }
        public static System.IDisposable CreateTransientScope() { throw null; }
        public static System.IDisposable CreateTransientScope(System.Collections.Generic.IDictionary<object, object> context) { throw null; }
    }
    public partial class ScopeStorageDictionary : System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<object, object>>, System.Collections.Generic.IDictionary<object, object>, System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<object, object>>, System.Collections.IEnumerable
    {
        public ScopeStorageDictionary() { }
        public ScopeStorageDictionary(System.Collections.Generic.IDictionary<object, object> baseScope) { }
        protected System.Collections.Generic.IDictionary<object, object> BackingStore { get { throw null; } }
        protected System.Collections.Generic.IDictionary<object, object> BaseScope { get { throw null; } }
        public virtual int Count { get { throw null; } }
        public virtual bool IsReadOnly { get { throw null; } }
        public object this[object key] { get { throw null; } set { } }
        public virtual System.Collections.Generic.ICollection<object> Keys { get { throw null; } }
        public virtual System.Collections.Generic.ICollection<object> Values { get { throw null; } }
        public virtual void Add(System.Collections.Generic.KeyValuePair<object, object> item) { }
        public virtual void Add(object key, object value) { }
        public virtual void Clear() { }
        public virtual bool Contains(System.Collections.Generic.KeyValuePair<object, object> item) { throw null; }
        public virtual bool ContainsKey(object key) { throw null; }
        public virtual void CopyTo(System.Collections.Generic.KeyValuePair<object, object>[] array, int arrayIndex) { }
        public virtual System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<object, object>> GetEnumerator() { throw null; }
        protected virtual System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<object, object>> GetItems() { throw null; }
        public virtual bool Remove(System.Collections.Generic.KeyValuePair<object, object> item) { throw null; }
        public virtual bool Remove(object key) { throw null; }
        public virtual void SetValue(object key, object value) { }
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { throw null; }
        public virtual bool TryGetValue(object key, out object value) { value = default(object); throw null; }
    }
    public partial class StaticScopeStorageProvider : System.Web.WebPages.Scope.IScopeStorageProvider
    {
        public StaticScopeStorageProvider() { }
        public System.Collections.Generic.IDictionary<object, object> CurrentScope { get { throw null; } set { } }
        public System.Collections.Generic.IDictionary<object, object> GlobalScope { get { throw null; } }
    }
}
