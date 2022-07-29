// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

[assembly:System.Reflection.AssemblyVersionAttribute("3.5.0.0")]
[assembly:System.CLSCompliantAttribute(true)]
[assembly:System.Diagnostics.DebuggableAttribute((System.Diagnostics.DebuggableAttribute.DebuggingModes)(2))]
[assembly:System.Reflection.AssemblyCompanyAttribute("Mono development team")]
[assembly:System.Reflection.AssemblyCopyrightAttribute("(c) Various Mono authors")]
[assembly:System.Reflection.AssemblyDefaultAliasAttribute("System.Web.Abstractions.dll")]
[assembly:System.Reflection.AssemblyDescriptionAttribute("System.Web.Abstractions.dll")]
[assembly:System.Reflection.AssemblyFileVersionAttribute("3.5.21022.8")]
[assembly:System.Reflection.AssemblyInformationalVersionAttribute("3.5.21022.8")]
[assembly:System.Reflection.AssemblyProductAttribute("Mono Common Language Infrastructure")]
[assembly:System.Reflection.AssemblyTitleAttribute("System.Web.Abstractions.dll")]
[assembly:System.Resources.NeutralResourcesLanguageAttribute("en-US")]
[assembly:System.Resources.SatelliteContractVersionAttribute("3.5.0.0")]
[assembly:System.Runtime.CompilerServices.RuntimeCompatibilityAttribute(WrapNonExceptionThrows=true)]
[assembly:System.Runtime.InteropServices.ComCompatibleVersionAttribute(1, 0, 3300, 0)]
[assembly:System.Runtime.InteropServices.ComVisibleAttribute(false)]
[assembly:System.Security.AllowPartiallyTrustedCallersAttribute]
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
namespace System.Web
{
    [System.Web.AspNetHostingPermissionAttribute(System.Security.Permissions.SecurityAction.InheritanceDemand, Level=(System.Web.AspNetHostingPermissionLevel)(200))]
    [System.Web.AspNetHostingPermissionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Level=(System.Web.AspNetHostingPermissionLevel)(200))]
    public abstract partial class HttpApplicationStateBase : System.Collections.Specialized.NameObjectCollectionBase, System.Collections.ICollection, System.Collections.IEnumerable
    {
        protected HttpApplicationStateBase() { }
        public virtual string[] AllKeys { get { throw null; } }
        public virtual System.Web.HttpApplicationStateBase Contents { get { throw null; } }
        public override int Count { get { throw null; } }
        public virtual bool IsSynchronized { get { throw null; } }
        public virtual object this[int index] { get { throw null; } }
        public virtual object this[string name] { get { throw null; } set { } }
        public virtual System.Web.HttpStaticObjectsCollectionBase StaticObjects { get { throw null; } }
        public virtual object SyncRoot { get { throw null; } }
        public virtual void Add(string name, object value) { }
        public virtual void Clear() { }
        public virtual void CopyTo(System.Array array, int index) { }
        public virtual object Get(int index) { throw null; }
        public virtual object Get(string name) { throw null; }
        public override System.Collections.IEnumerator GetEnumerator() { throw null; }
        public virtual string GetKey(int index) { throw null; }
        public virtual void Lock() { }
        public virtual void Remove(string name) { }
        public virtual void RemoveAll() { }
        public virtual void RemoveAt(int index) { }
        public virtual void Set(string name, object value) { }
        public virtual void UnLock() { }
    }
    [System.Web.AspNetHostingPermissionAttribute(System.Security.Permissions.SecurityAction.InheritanceDemand, Level=(System.Web.AspNetHostingPermissionLevel)(200))]
    [System.Web.AspNetHostingPermissionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Level=(System.Web.AspNetHostingPermissionLevel)(200))]
    public partial class HttpApplicationStateWrapper : System.Web.HttpApplicationStateBase
    {
        public HttpApplicationStateWrapper(System.Web.HttpApplicationState httpApplicationState) { }
        public override string[] AllKeys { get { throw null; } }
        public override System.Web.HttpApplicationStateBase Contents { get { throw null; } }
        public override int Count { get { throw null; } }
        public override bool IsSynchronized { get { throw null; } }
        public override object this[int index] { get { throw null; } }
        public override object this[string name] { get { throw null; } set { } }
        public override System.Collections.Specialized.NameObjectCollectionBase.KeysCollection Keys { get { throw null; } }
        public override System.Web.HttpStaticObjectsCollectionBase StaticObjects { get { throw null; } }
        public override object SyncRoot { get { throw null; } }
        public override void Add(string name, object value) { }
        public override void Clear() { }
        public override void CopyTo(System.Array array, int index) { }
        public override object Get(int index) { throw null; }
        public override object Get(string name) { throw null; }
        public override System.Collections.IEnumerator GetEnumerator() { throw null; }
        public override string GetKey(int index) { throw null; }
        [System.MonoTODOAttribute]
        public override void GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
        public override void Lock() { }
        public override void OnDeserialization(object sender) { }
        public override void Remove(string name) { }
        public override void RemoveAll() { }
        public override void RemoveAt(int index) { }
        public override void Set(string name, object value) { }
        public override void UnLock() { }
    }
    [System.Web.AspNetHostingPermissionAttribute(System.Security.Permissions.SecurityAction.InheritanceDemand, Level=(System.Web.AspNetHostingPermissionLevel)(200))]
    [System.Web.AspNetHostingPermissionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Level=(System.Web.AspNetHostingPermissionLevel)(200))]
    public abstract partial class HttpBrowserCapabilitiesBase : System.Web.UI.IFilterResolutionService
    {
        protected HttpBrowserCapabilitiesBase() { }
        public virtual bool ActiveXControls { get { throw null; } }
        public virtual System.Collections.IDictionary Adapters { get { throw null; } }
        public virtual bool AOL { get { throw null; } }
        public virtual bool BackgroundSounds { get { throw null; } }
        public virtual bool Beta { get { throw null; } }
        public virtual string Browser { get { throw null; } }
        public virtual System.Collections.ArrayList Browsers { get { throw null; } }
        public virtual bool CanCombineFormsInDeck { get { throw null; } }
        public virtual bool CanInitiateVoiceCall { get { throw null; } }
        public virtual bool CanRenderAfterInputOrSelectElement { get { throw null; } }
        public virtual bool CanRenderEmptySelects { get { throw null; } }
        public virtual bool CanRenderInputAndSelectElementsTogether { get { throw null; } }
        public virtual bool CanRenderMixedSelects { get { throw null; } }
        public virtual bool CanRenderOneventAndPrevElementsTogether { get { throw null; } }
        public virtual bool CanRenderPostBackCards { get { throw null; } }
        public virtual bool CanRenderSetvarZeroWithMultiSelectionList { get { throw null; } }
        public virtual bool CanSendMail { get { throw null; } }
        public virtual System.Collections.IDictionary Capabilities { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public virtual bool CDF { get { throw null; } }
        public virtual System.Version ClrVersion { get { throw null; } }
        public virtual bool Cookies { get { throw null; } }
        public virtual bool Crawler { get { throw null; } }
        public virtual int DefaultSubmitButtonLimit { get { throw null; } }
        public virtual System.Version EcmaScriptVersion { get { throw null; } }
        public virtual bool Frames { get { throw null; } }
        public virtual int GatewayMajorVersion { get { throw null; } }
        public virtual double GatewayMinorVersion { get { throw null; } }
        public virtual string GatewayVersion { get { throw null; } }
        public virtual bool HasBackButton { get { throw null; } }
        public virtual bool HidesRightAlignedMultiselectScrollbars { get { throw null; } }
        public virtual string HtmlTextWriter { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public virtual string Id { get { throw null; } }
        public virtual string InputType { get { throw null; } }
        public virtual bool IsColor { get { throw null; } }
        public virtual bool IsMobileDevice { get { throw null; } }
        public virtual string this[string key] { get { throw null; } }
        public virtual bool JavaApplets { get { throw null; } }
        public virtual System.Version JScriptVersion { get { throw null; } }
        public virtual int MajorVersion { get { throw null; } }
        public virtual int MaximumHrefLength { get { throw null; } }
        public virtual int MaximumRenderedPageSize { get { throw null; } }
        public virtual int MaximumSoftkeyLabelLength { get { throw null; } }
        public virtual double MinorVersion { get { throw null; } }
        public virtual string MinorVersionString { get { throw null; } }
        public virtual string MobileDeviceManufacturer { get { throw null; } }
        public virtual string MobileDeviceModel { get { throw null; } }
        public virtual System.Version MSDomVersion { get { throw null; } }
        public virtual int NumberOfSoftkeys { get { throw null; } }
        public virtual string Platform { get { throw null; } }
        public virtual string PreferredImageMime { get { throw null; } }
        public virtual string PreferredRenderingMime { get { throw null; } }
        public virtual string PreferredRenderingType { get { throw null; } }
        public virtual string PreferredRequestEncoding { get { throw null; } }
        public virtual string PreferredResponseEncoding { get { throw null; } }
        public virtual bool RendersBreakBeforeWmlSelectAndInput { get { throw null; } }
        public virtual bool RendersBreaksAfterHtmlLists { get { throw null; } }
        public virtual bool RendersBreaksAfterWmlAnchor { get { throw null; } }
        public virtual bool RendersBreaksAfterWmlInput { get { throw null; } }
        public virtual bool RendersWmlDoAcceptsInline { get { throw null; } }
        public virtual bool RendersWmlSelectsAsMenuCards { get { throw null; } }
        public virtual string RequiredMetaTagNameValue { get { throw null; } }
        public virtual bool RequiresAttributeColonSubstitution { get { throw null; } }
        public virtual bool RequiresContentTypeMetaTag { get { throw null; } }
        public virtual bool RequiresControlStateInSession { get { throw null; } }
        public virtual bool RequiresDBCSCharacter { get { throw null; } }
        public virtual bool RequiresHtmlAdaptiveErrorReporting { get { throw null; } }
        public virtual bool RequiresLeadingPageBreak { get { throw null; } }
        public virtual bool RequiresNoBreakInFormatting { get { throw null; } }
        public virtual bool RequiresOutputOptimization { get { throw null; } }
        public virtual bool RequiresPhoneNumbersAsPlainText { get { throw null; } }
        public virtual bool RequiresSpecialViewStateEncoding { get { throw null; } }
        public virtual bool RequiresUniqueFilePathSuffix { get { throw null; } }
        public virtual bool RequiresUniqueHtmlCheckboxNames { get { throw null; } }
        public virtual bool RequiresUniqueHtmlInputNames { get { throw null; } }
        public virtual bool RequiresUrlEncodedPostfieldValues { get { throw null; } }
        public virtual int ScreenBitDepth { get { throw null; } }
        public virtual int ScreenCharactersHeight { get { throw null; } }
        public virtual int ScreenCharactersWidth { get { throw null; } }
        public virtual int ScreenPixelsHeight { get { throw null; } }
        public virtual int ScreenPixelsWidth { get { throw null; } }
        public virtual bool SupportsAccesskeyAttribute { get { throw null; } }
        public virtual bool SupportsBodyColor { get { throw null; } }
        public virtual bool SupportsBold { get { throw null; } }
        public virtual bool SupportsCacheControlMetaTag { get { throw null; } }
        public virtual bool SupportsCallback { get { throw null; } }
        public virtual bool SupportsCss { get { throw null; } }
        public virtual bool SupportsDivAlign { get { throw null; } }
        public virtual bool SupportsDivNoWrap { get { throw null; } }
        public virtual bool SupportsEmptyStringInCookieValue { get { throw null; } }
        public virtual bool SupportsFontColor { get { throw null; } }
        public virtual bool SupportsFontName { get { throw null; } }
        public virtual bool SupportsFontSize { get { throw null; } }
        public virtual bool SupportsImageSubmit { get { throw null; } }
        public virtual bool SupportsIModeSymbols { get { throw null; } }
        public virtual bool SupportsInputIStyle { get { throw null; } }
        public virtual bool SupportsInputMode { get { throw null; } }
        public virtual bool SupportsItalic { get { throw null; } }
        public virtual bool SupportsJPhoneMultiMediaAttributes { get { throw null; } }
        public virtual bool SupportsJPhoneSymbols { get { throw null; } }
        public virtual bool SupportsQueryStringInFormAction { get { throw null; } }
        public virtual bool SupportsRedirectWithCookie { get { throw null; } }
        public virtual bool SupportsSelectMultiple { get { throw null; } }
        public virtual bool SupportsUncheck { get { throw null; } }
        public virtual bool SupportsXmlHttp { get { throw null; } }
        public virtual bool Tables { get { throw null; } }
        public virtual System.Type TagWriter { get { throw null; } }
        public virtual string Type { get { throw null; } }
        public virtual bool UseOptimizedCacheKey { get { throw null; } }
        public virtual bool VBScript { get { throw null; } }
        public virtual string Version { get { throw null; } }
        public virtual System.Version W3CDomVersion { get { throw null; } }
        public virtual bool Win16 { get { throw null; } }
        public virtual bool Win32 { get { throw null; } }
        public virtual void AddBrowser(string browserName) { }
        public virtual int CompareFilters(string filter1, string filter2) { throw null; }
        public virtual System.Web.UI.HtmlTextWriter CreateHtmlTextWriter(System.IO.TextWriter w) { throw null; }
        public virtual void DisableOptimizedCacheKey() { }
        public virtual bool EvaluateFilter(string filterName) { throw null; }
        public virtual System.Version[] GetClrVersions() { throw null; }
        public virtual bool IsBrowser(string browserName) { throw null; }
    }
    [System.Web.AspNetHostingPermissionAttribute(System.Security.Permissions.SecurityAction.InheritanceDemand, Level=(System.Web.AspNetHostingPermissionLevel)(200))]
    [System.Web.AspNetHostingPermissionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Level=(System.Web.AspNetHostingPermissionLevel)(200))]
    public partial class HttpBrowserCapabilitiesWrapper : System.Web.HttpBrowserCapabilitiesBase
    {
        public HttpBrowserCapabilitiesWrapper(System.Web.HttpBrowserCapabilities httpBrowserCapabilities) { }
        public override bool ActiveXControls { get { throw null; } }
        public override System.Collections.IDictionary Adapters { get { throw null; } }
        public override bool AOL { get { throw null; } }
        public override bool BackgroundSounds { get { throw null; } }
        public override bool Beta { get { throw null; } }
        public override string Browser { get { throw null; } }
        public override System.Collections.ArrayList Browsers { get { throw null; } }
        public override bool CanCombineFormsInDeck { get { throw null; } }
        public override bool CanInitiateVoiceCall { get { throw null; } }
        public override bool CanRenderAfterInputOrSelectElement { get { throw null; } }
        public override bool CanRenderEmptySelects { get { throw null; } }
        public override bool CanRenderInputAndSelectElementsTogether { get { throw null; } }
        public override bool CanRenderMixedSelects { get { throw null; } }
        public override bool CanRenderOneventAndPrevElementsTogether { get { throw null; } }
        public override bool CanRenderPostBackCards { get { throw null; } }
        public override bool CanRenderSetvarZeroWithMultiSelectionList { get { throw null; } }
        public override bool CanSendMail { get { throw null; } }
        public override System.Collections.IDictionary Capabilities { get { throw null; } set { } }
        public override bool CDF { get { throw null; } }
        public override System.Version ClrVersion { get { throw null; } }
        public override bool Cookies { get { throw null; } }
        public override bool Crawler { get { throw null; } }
        public override int DefaultSubmitButtonLimit { get { throw null; } }
        public override System.Version EcmaScriptVersion { get { throw null; } }
        public override bool Frames { get { throw null; } }
        public override int GatewayMajorVersion { get { throw null; } }
        public override double GatewayMinorVersion { get { throw null; } }
        public override string GatewayVersion { get { throw null; } }
        public override bool HasBackButton { get { throw null; } }
        public override bool HidesRightAlignedMultiselectScrollbars { get { throw null; } }
        public override string HtmlTextWriter { get { throw null; } set { } }
        public override string Id { get { throw null; } }
        public override string InputType { get { throw null; } }
        public override bool IsColor { get { throw null; } }
        public override bool IsMobileDevice { get { throw null; } }
        public override string this[string key] { get { throw null; } }
        public override bool JavaApplets { get { throw null; } }
        public override System.Version JScriptVersion { get { throw null; } }
        public override int MajorVersion { get { throw null; } }
        public override int MaximumHrefLength { get { throw null; } }
        public override int MaximumRenderedPageSize { get { throw null; } }
        public override int MaximumSoftkeyLabelLength { get { throw null; } }
        public override double MinorVersion { get { throw null; } }
        public override string MinorVersionString { get { throw null; } }
        public override string MobileDeviceManufacturer { get { throw null; } }
        public override string MobileDeviceModel { get { throw null; } }
        public override System.Version MSDomVersion { get { throw null; } }
        public override int NumberOfSoftkeys { get { throw null; } }
        public override string Platform { get { throw null; } }
        public override string PreferredImageMime { get { throw null; } }
        public override string PreferredRenderingMime { get { throw null; } }
        public override string PreferredRenderingType { get { throw null; } }
        public override string PreferredRequestEncoding { get { throw null; } }
        public override string PreferredResponseEncoding { get { throw null; } }
        public override bool RendersBreakBeforeWmlSelectAndInput { get { throw null; } }
        public override bool RendersBreaksAfterHtmlLists { get { throw null; } }
        public override bool RendersBreaksAfterWmlAnchor { get { throw null; } }
        public override bool RendersBreaksAfterWmlInput { get { throw null; } }
        public override bool RendersWmlDoAcceptsInline { get { throw null; } }
        public override bool RendersWmlSelectsAsMenuCards { get { throw null; } }
        public override string RequiredMetaTagNameValue { get { throw null; } }
        public override bool RequiresAttributeColonSubstitution { get { throw null; } }
        public override bool RequiresContentTypeMetaTag { get { throw null; } }
        public override bool RequiresControlStateInSession { get { throw null; } }
        public override bool RequiresDBCSCharacter { get { throw null; } }
        public override bool RequiresHtmlAdaptiveErrorReporting { get { throw null; } }
        public override bool RequiresLeadingPageBreak { get { throw null; } }
        public override bool RequiresNoBreakInFormatting { get { throw null; } }
        public override bool RequiresOutputOptimization { get { throw null; } }
        public override bool RequiresPhoneNumbersAsPlainText { get { throw null; } }
        public override bool RequiresSpecialViewStateEncoding { get { throw null; } }
        public override bool RequiresUniqueFilePathSuffix { get { throw null; } }
        public override bool RequiresUniqueHtmlCheckboxNames { get { throw null; } }
        public override bool RequiresUniqueHtmlInputNames { get { throw null; } }
        public override bool RequiresUrlEncodedPostfieldValues { get { throw null; } }
        public override int ScreenBitDepth { get { throw null; } }
        public override int ScreenCharactersHeight { get { throw null; } }
        public override int ScreenCharactersWidth { get { throw null; } }
        public override int ScreenPixelsHeight { get { throw null; } }
        public override int ScreenPixelsWidth { get { throw null; } }
        public override bool SupportsAccesskeyAttribute { get { throw null; } }
        public override bool SupportsBodyColor { get { throw null; } }
        public override bool SupportsBold { get { throw null; } }
        public override bool SupportsCacheControlMetaTag { get { throw null; } }
        public override bool SupportsCallback { get { throw null; } }
        public override bool SupportsCss { get { throw null; } }
        public override bool SupportsDivAlign { get { throw null; } }
        public override bool SupportsDivNoWrap { get { throw null; } }
        public override bool SupportsEmptyStringInCookieValue { get { throw null; } }
        public override bool SupportsFontColor { get { throw null; } }
        public override bool SupportsFontName { get { throw null; } }
        public override bool SupportsFontSize { get { throw null; } }
        public override bool SupportsImageSubmit { get { throw null; } }
        public override bool SupportsIModeSymbols { get { throw null; } }
        public override bool SupportsInputIStyle { get { throw null; } }
        public override bool SupportsInputMode { get { throw null; } }
        public override bool SupportsItalic { get { throw null; } }
        public override bool SupportsJPhoneMultiMediaAttributes { get { throw null; } }
        public override bool SupportsJPhoneSymbols { get { throw null; } }
        public override bool SupportsQueryStringInFormAction { get { throw null; } }
        public override bool SupportsRedirectWithCookie { get { throw null; } }
        public override bool SupportsSelectMultiple { get { throw null; } }
        public override bool SupportsUncheck { get { throw null; } }
        public override bool SupportsXmlHttp { get { throw null; } }
        public override bool Tables { get { throw null; } }
        public override System.Type TagWriter { get { throw null; } }
        public override string Type { get { throw null; } }
        public override bool UseOptimizedCacheKey { get { throw null; } }
        public override bool VBScript { get { throw null; } }
        public override string Version { get { throw null; } }
        public override System.Version W3CDomVersion { get { throw null; } }
        public override bool Win16 { get { throw null; } }
        public override bool Win32 { get { throw null; } }
        public override void AddBrowser(string browserName) { }
        [System.MonoTODOAttribute]
        public override int CompareFilters(string filter1, string filter2) { throw null; }
        [System.MonoTODOAttribute]
        public override System.Web.UI.HtmlTextWriter CreateHtmlTextWriter(System.IO.TextWriter w) { throw null; }
        public override void DisableOptimizedCacheKey() { }
        [System.MonoTODOAttribute]
        public override bool EvaluateFilter(string filterName) { throw null; }
        public override System.Version[] GetClrVersions() { throw null; }
        public override bool IsBrowser(string browserName) { throw null; }
    }
    [System.Web.AspNetHostingPermissionAttribute(System.Security.Permissions.SecurityAction.InheritanceDemand, Level=(System.Web.AspNetHostingPermissionLevel)(200))]
    [System.Web.AspNetHostingPermissionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Level=(System.Web.AspNetHostingPermissionLevel)(200))]
    public abstract partial class HttpCachePolicyBase
    {
        protected HttpCachePolicyBase() { }
        public virtual System.Web.HttpCacheVaryByContentEncodings VaryByContentEncodings { get { throw null; } }
        public virtual System.Web.HttpCacheVaryByHeaders VaryByHeaders { get { throw null; } }
        public virtual System.Web.HttpCacheVaryByParams VaryByParams { get { throw null; } }
        public virtual void AddValidationCallback(System.Web.HttpCacheValidateHandler handler, object data) { }
        public virtual void AppendCacheExtension(string extension) { }
        public virtual void SetAllowResponseInBrowserHistory(bool allow) { }
        public virtual void SetCacheability(System.Web.HttpCacheability cacheability) { }
        public virtual void SetCacheability(System.Web.HttpCacheability cacheability, string field) { }
        public virtual void SetETag(string etag) { }
        public virtual void SetETagFromFileDependencies() { }
        public virtual void SetExpires(System.DateTime date) { }
        public virtual void SetLastModified(System.DateTime date) { }
        public virtual void SetLastModifiedFromFileDependencies() { }
        public virtual void SetMaxAge(System.TimeSpan delta) { }
        public virtual void SetNoServerCaching() { }
        public virtual void SetNoStore() { }
        public virtual void SetNoTransforms() { }
        public virtual void SetOmitVaryStar(bool omit) { }
        public virtual void SetProxyMaxAge(System.TimeSpan delta) { }
        public virtual void SetRevalidation(System.Web.HttpCacheRevalidation revalidation) { }
        public virtual void SetSlidingExpiration(bool slide) { }
        public virtual void SetValidUntilExpires(bool validUntilExpires) { }
        public virtual void SetVaryByCustom(string custom) { }
    }
    [System.Web.AspNetHostingPermissionAttribute(System.Security.Permissions.SecurityAction.InheritanceDemand, Level=(System.Web.AspNetHostingPermissionLevel)(200))]
    [System.Web.AspNetHostingPermissionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Level=(System.Web.AspNetHostingPermissionLevel)(200))]
    public partial class HttpCachePolicyWrapper : System.Web.HttpCachePolicyBase
    {
        public HttpCachePolicyWrapper(System.Web.HttpCachePolicy httpCachePolicy) { }
        public override System.Web.HttpCacheVaryByContentEncodings VaryByContentEncodings { get { throw null; } }
        public override System.Web.HttpCacheVaryByHeaders VaryByHeaders { get { throw null; } }
        public override System.Web.HttpCacheVaryByParams VaryByParams { get { throw null; } }
        public override void AddValidationCallback(System.Web.HttpCacheValidateHandler handler, object data) { }
        public override void AppendCacheExtension(string extension) { }
        public override void SetAllowResponseInBrowserHistory(bool allow) { }
        public override void SetCacheability(System.Web.HttpCacheability cacheability) { }
        public override void SetCacheability(System.Web.HttpCacheability cacheability, string field) { }
        public override void SetETag(string etag) { }
        public override void SetETagFromFileDependencies() { }
        public override void SetExpires(System.DateTime date) { }
        public override void SetLastModified(System.DateTime date) { }
        public override void SetLastModifiedFromFileDependencies() { }
        public override void SetMaxAge(System.TimeSpan delta) { }
        public override void SetNoServerCaching() { }
        public override void SetNoStore() { }
        public override void SetNoTransforms() { }
        public override void SetOmitVaryStar(bool omit) { }
        public override void SetProxyMaxAge(System.TimeSpan delta) { }
        public override void SetRevalidation(System.Web.HttpCacheRevalidation revalidation) { }
        public override void SetSlidingExpiration(bool slide) { }
        public override void SetValidUntilExpires(bool validUntilExpires) { }
        public override void SetVaryByCustom(string custom) { }
    }
    [System.Web.AspNetHostingPermissionAttribute(System.Security.Permissions.SecurityAction.InheritanceDemand, Level=(System.Web.AspNetHostingPermissionLevel)(200))]
    [System.Web.AspNetHostingPermissionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Level=(System.Web.AspNetHostingPermissionLevel)(200))]
    public abstract partial class HttpContextBase : System.IServiceProvider
    {
        protected HttpContextBase() { }
        public virtual System.Exception[] AllErrors { get { throw null; } }
        public virtual System.Web.HttpApplicationStateBase Application { get { throw null; } }
        public virtual System.Web.HttpApplication ApplicationInstance { get { throw null; } set { } }
        public virtual System.Web.Caching.Cache Cache { get { throw null; } }
        public virtual System.Web.IHttpHandler CurrentHandler { get { throw null; } }
        public virtual System.Web.RequestNotification CurrentNotification { get { throw null; } }
        public virtual System.Exception Error { get { throw null; } }
        public virtual System.Web.IHttpHandler Handler { get { throw null; } set { } }
        public virtual bool IsCustomErrorEnabled { get { throw null; } }
        public virtual bool IsDebuggingEnabled { get { throw null; } }
        public virtual bool IsPostNotification { get { throw null; } }
        public virtual System.Collections.IDictionary Items { get { throw null; } }
        public virtual System.Web.IHttpHandler PreviousHandler { get { throw null; } }
        public virtual System.Web.Profile.ProfileBase Profile { get { throw null; } }
        public virtual System.Web.HttpRequestBase Request { get { throw null; } }
        public virtual System.Web.HttpResponseBase Response { get { throw null; } }
        public virtual System.Web.HttpServerUtilityBase Server { get { throw null; } }
        public virtual System.Web.HttpSessionStateBase Session { get { throw null; } }
        public virtual bool SkipAuthorization { get { throw null; } set { } }
        public virtual System.DateTime Timestamp { get { throw null; } }
        public virtual System.Web.TraceContext Trace { get { throw null; } }
        public virtual System.Security.Principal.IPrincipal User { get { throw null; } set { } }
        public virtual void AddError(System.Exception errorInfo) { }
        public virtual void ClearError() { }
        public virtual object GetGlobalResourceObject(string classKey, string resourceKey) { throw null; }
        public virtual object GetGlobalResourceObject(string classKey, string resourceKey, System.Globalization.CultureInfo culture) { throw null; }
        public virtual object GetLocalResourceObject(string virtualPath, string resourceKey) { throw null; }
        public virtual object GetLocalResourceObject(string virtualPath, string resourceKey, System.Globalization.CultureInfo culture) { throw null; }
        public virtual object GetSection(string sectionName) { throw null; }
        public virtual object GetService(System.Type serviceType) { throw null; }
        public virtual void RewritePath(string path) { }
        public virtual void RewritePath(string path, bool rebaseClientPath) { }
        public virtual void RewritePath(string filePath, string pathInfo, string queryString) { }
        public virtual void RewritePath(string filePath, string pathInfo, string queryString, bool setClientFilePath) { }
    }
    [System.Web.AspNetHostingPermissionAttribute(System.Security.Permissions.SecurityAction.InheritanceDemand, Level=(System.Web.AspNetHostingPermissionLevel)(200))]
    [System.Web.AspNetHostingPermissionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Level=(System.Web.AspNetHostingPermissionLevel)(200))]
    public partial class HttpContextWrapper : System.Web.HttpContextBase
    {
        public HttpContextWrapper(System.Web.HttpContext httpContext) { }
        public override System.Exception[] AllErrors { get { throw null; } }
        public override System.Web.HttpApplicationStateBase Application { get { throw null; } }
        public override System.Web.HttpApplication ApplicationInstance { get { throw null; } set { } }
        public override System.Web.Caching.Cache Cache { get { throw null; } }
        public override System.Web.IHttpHandler CurrentHandler { get { throw null; } }
        public override System.Web.RequestNotification CurrentNotification { get { throw null; } }
        public override System.Exception Error { get { throw null; } }
        public override System.Web.IHttpHandler Handler { get { throw null; } set { } }
        public override bool IsCustomErrorEnabled { get { throw null; } }
        public override bool IsDebuggingEnabled { get { throw null; } }
        public override bool IsPostNotification { get { throw null; } }
        public override System.Collections.IDictionary Items { get { throw null; } }
        public override System.Web.IHttpHandler PreviousHandler { get { throw null; } }
        public override System.Web.Profile.ProfileBase Profile { get { throw null; } }
        public override System.Web.HttpRequestBase Request { get { throw null; } }
        public override System.Web.HttpResponseBase Response { get { throw null; } }
        public override System.Web.HttpServerUtilityBase Server { get { throw null; } }
        public override System.Web.HttpSessionStateBase Session { get { throw null; } }
        public override bool SkipAuthorization { get { throw null; } set { } }
        public override System.DateTime Timestamp { get { throw null; } }
        public override System.Web.TraceContext Trace { get { throw null; } }
        public override System.Security.Principal.IPrincipal User { get { throw null; } set { } }
        public override void AddError(System.Exception errorInfo) { }
        public override void ClearError() { }
        public override object GetGlobalResourceObject(string classKey, string resourceKey) { throw null; }
        public override object GetGlobalResourceObject(string classKey, string resourceKey, System.Globalization.CultureInfo culture) { throw null; }
        public override object GetLocalResourceObject(string overridePath, string resourceKey) { throw null; }
        public override object GetLocalResourceObject(string overridePath, string resourceKey, System.Globalization.CultureInfo culture) { throw null; }
        public override object GetSection(string sectionName) { throw null; }
        [System.MonoTODOAttribute]
        public override object GetService(System.Type serviceType) { throw null; }
        public override void RewritePath(string path) { }
        public override void RewritePath(string path, bool rebaseClientPath) { }
        public override void RewritePath(string filePath, string pathInfo, string queryString) { }
        public override void RewritePath(string filePath, string pathInfo, string queryString, bool setClientFilePath) { }
    }
    [System.Web.AspNetHostingPermissionAttribute(System.Security.Permissions.SecurityAction.InheritanceDemand, Level=(System.Web.AspNetHostingPermissionLevel)(200))]
    [System.Web.AspNetHostingPermissionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Level=(System.Web.AspNetHostingPermissionLevel)(200))]
    public abstract partial class HttpFileCollectionBase : System.Collections.Specialized.NameObjectCollectionBase, System.Collections.ICollection, System.Collections.IEnumerable
    {
        protected HttpFileCollectionBase() { }
        public virtual string[] AllKeys { get { throw null; } }
        public override int Count { get { throw null; } }
        public virtual bool IsSynchronized { get { throw null; } }
        public virtual System.Web.HttpPostedFileBase this[int index] { get { throw null; } }
        public virtual System.Web.HttpPostedFileBase this[string name] { get { throw null; } }
        public virtual object SyncRoot { get { throw null; } }
        public virtual void CopyTo(System.Array dest, int index) { }
        public virtual System.Web.HttpPostedFileBase Get(int index) { throw null; }
        public virtual System.Web.HttpPostedFileBase Get(string name) { throw null; }
        public override System.Collections.IEnumerator GetEnumerator() { throw null; }
        public virtual string GetKey(int index) { throw null; }
    }
    [System.Web.AspNetHostingPermissionAttribute(System.Security.Permissions.SecurityAction.InheritanceDemand, Level=(System.Web.AspNetHostingPermissionLevel)(200))]
    [System.Web.AspNetHostingPermissionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Level=(System.Web.AspNetHostingPermissionLevel)(200))]
    public partial class HttpFileCollectionWrapper : System.Web.HttpFileCollectionBase
    {
        public HttpFileCollectionWrapper(System.Web.HttpFileCollection httpFileCollection) { }
        public override string[] AllKeys { get { throw null; } }
        public override int Count { get { throw null; } }
        public override bool IsSynchronized { get { throw null; } }
        public override System.Web.HttpPostedFileBase this[int index] { get { throw null; } }
        public override System.Web.HttpPostedFileBase this[string name] { get { throw null; } }
        public override System.Collections.Specialized.NameObjectCollectionBase.KeysCollection Keys { get { throw null; } }
        public override object SyncRoot { get { throw null; } }
        public override void CopyTo(System.Array dest, int index) { }
        public override System.Web.HttpPostedFileBase Get(int index) { throw null; }
        public override System.Web.HttpPostedFileBase Get(string name) { throw null; }
        public override System.Collections.IEnumerator GetEnumerator() { throw null; }
        public override string GetKey(int index) { throw null; }
        public override void GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
        public override void OnDeserialization(object sender) { }
    }
    [System.Web.AspNetHostingPermissionAttribute(System.Security.Permissions.SecurityAction.InheritanceDemand, Level=(System.Web.AspNetHostingPermissionLevel)(200))]
    [System.Web.AspNetHostingPermissionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Level=(System.Web.AspNetHostingPermissionLevel)(200))]
    public abstract partial class HttpPostedFileBase
    {
        protected HttpPostedFileBase() { }
        public virtual int ContentLength { get { throw null; } }
        public virtual string ContentType { get { throw null; } }
        public virtual string FileName { get { throw null; } }
        public virtual System.IO.Stream InputStream { get { throw null; } }
        public virtual void SaveAs(string filename) { }
    }
    [System.Web.AspNetHostingPermissionAttribute(System.Security.Permissions.SecurityAction.InheritanceDemand, Level=(System.Web.AspNetHostingPermissionLevel)(200))]
    [System.Web.AspNetHostingPermissionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Level=(System.Web.AspNetHostingPermissionLevel)(200))]
    public partial class HttpPostedFileWrapper : System.Web.HttpPostedFileBase
    {
        public HttpPostedFileWrapper(System.Web.HttpPostedFile httpPostedFile) { }
        public override int ContentLength { get { throw null; } }
        public override string ContentType { get { throw null; } }
        public override string FileName { get { throw null; } }
        public override System.IO.Stream InputStream { get { throw null; } }
        public override void SaveAs(string filename) { }
    }
    [System.Web.AspNetHostingPermissionAttribute(System.Security.Permissions.SecurityAction.InheritanceDemand, Level=(System.Web.AspNetHostingPermissionLevel)(200))]
    [System.Web.AspNetHostingPermissionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Level=(System.Web.AspNetHostingPermissionLevel)(200))]
    public abstract partial class HttpRequestBase
    {
        protected HttpRequestBase() { }
        public virtual string[] AcceptTypes { get { throw null; } }
        public virtual string AnonymousID { get { throw null; } }
        public virtual string ApplicationPath { get { throw null; } }
        public virtual string AppRelativeCurrentExecutionFilePath { get { throw null; } }
        public virtual System.Web.HttpBrowserCapabilitiesBase Browser { get { throw null; } }
        public virtual System.Web.HttpClientCertificate ClientCertificate { get { throw null; } }
        public virtual System.Text.Encoding ContentEncoding { get { throw null; } set { } }
        public virtual int ContentLength { get { throw null; } }
        public virtual string ContentType { get { throw null; } set { } }
        public virtual System.Web.HttpCookieCollection Cookies { get { throw null; } }
        public virtual string CurrentExecutionFilePath { get { throw null; } }
        public virtual string FilePath { get { throw null; } }
        public virtual System.Web.HttpFileCollectionBase Files { get { throw null; } }
        public virtual System.IO.Stream Filter { get { throw null; } set { } }
        public virtual System.Collections.Specialized.NameValueCollection Form { get { throw null; } }
        public virtual System.Collections.Specialized.NameValueCollection Headers { get { throw null; } }
        public virtual string HttpMethod { get { throw null; } }
        public virtual System.IO.Stream InputStream { get { throw null; } }
        public virtual bool IsAuthenticated { get { throw null; } }
        public virtual bool IsLocal { get { throw null; } }
        public virtual bool IsSecureConnection { get { throw null; } }
        public virtual string this[string key] { get { throw null; } }
        public virtual System.Security.Principal.WindowsIdentity LogonUserIdentity { get { throw null; } }
        public virtual System.Collections.Specialized.NameValueCollection Params { get { throw null; } }
        public virtual string Path { get { throw null; } }
        public virtual string PathInfo { get { throw null; } }
        public virtual string PhysicalApplicationPath { get { throw null; } }
        public virtual string PhysicalPath { get { throw null; } }
        public virtual System.Collections.Specialized.NameValueCollection QueryString { get { throw null; } }
        public virtual string RawUrl { get { throw null; } }
        public virtual string RequestType { get { throw null; } set { } }
        public virtual System.Collections.Specialized.NameValueCollection ServerVariables { get { throw null; } }
        public virtual int TotalBytes { get { throw null; } }
        public virtual System.Uri Url { get { throw null; } }
        public virtual System.Uri UrlReferrer { get { throw null; } }
        public virtual string UserAgent { get { throw null; } }
        public virtual string UserHostAddress { get { throw null; } }
        public virtual string UserHostName { get { throw null; } }
        public virtual string[] UserLanguages { get { throw null; } }
        public virtual byte[] BinaryRead(int count) { throw null; }
        public virtual int[] MapImageCoordinates(string imageFieldName) { throw null; }
        public virtual string MapPath(string virtualPath) { throw null; }
        public virtual string MapPath(string virtualPath, string baseVirtualDir, bool allowCrossAppMapping) { throw null; }
        public virtual void SaveAs(string filename, bool includeHeaders) { }
        public virtual void ValidateInput() { }
    }
    [System.Web.AspNetHostingPermissionAttribute(System.Security.Permissions.SecurityAction.InheritanceDemand, Level=(System.Web.AspNetHostingPermissionLevel)(200))]
    [System.Web.AspNetHostingPermissionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Level=(System.Web.AspNetHostingPermissionLevel)(200))]
    public partial class HttpRequestWrapper : System.Web.HttpRequestBase
    {
        public HttpRequestWrapper(System.Web.HttpRequest httpRequest) { }
        public override string[] AcceptTypes { get { throw null; } }
        public override string AnonymousID { get { throw null; } }
        public override string ApplicationPath { get { throw null; } }
        public override string AppRelativeCurrentExecutionFilePath { get { throw null; } }
        public override System.Web.HttpBrowserCapabilitiesBase Browser { get { throw null; } }
        public override System.Web.HttpClientCertificate ClientCertificate { get { throw null; } }
        public override System.Text.Encoding ContentEncoding { get { throw null; } set { } }
        public override int ContentLength { get { throw null; } }
        public override string ContentType { get { throw null; } set { } }
        public override System.Web.HttpCookieCollection Cookies { get { throw null; } }
        public override string CurrentExecutionFilePath { get { throw null; } }
        public override string FilePath { get { throw null; } }
        public override System.Web.HttpFileCollectionBase Files { get { throw null; } }
        public override System.IO.Stream Filter { get { throw null; } set { } }
        public override System.Collections.Specialized.NameValueCollection Form { get { throw null; } }
        public override System.Collections.Specialized.NameValueCollection Headers { get { throw null; } }
        public override string HttpMethod { get { throw null; } }
        public override System.IO.Stream InputStream { get { throw null; } }
        public override bool IsAuthenticated { get { throw null; } }
        public override bool IsLocal { get { throw null; } }
        public override bool IsSecureConnection { get { throw null; } }
        public override string this[string key] { get { throw null; } }
        public override System.Security.Principal.WindowsIdentity LogonUserIdentity { get { throw null; } }
        public override System.Collections.Specialized.NameValueCollection Params { get { throw null; } }
        public override string Path { get { throw null; } }
        public override string PathInfo { get { throw null; } }
        public override string PhysicalApplicationPath { get { throw null; } }
        public override string PhysicalPath { get { throw null; } }
        public override System.Collections.Specialized.NameValueCollection QueryString { get { throw null; } }
        public override string RawUrl { get { throw null; } }
        public override string RequestType { get { throw null; } set { } }
        public override System.Collections.Specialized.NameValueCollection ServerVariables { get { throw null; } }
        public override int TotalBytes { get { throw null; } }
        public override System.Uri Url { get { throw null; } }
        public override System.Uri UrlReferrer { get { throw null; } }
        public override string UserAgent { get { throw null; } }
        public override string UserHostAddress { get { throw null; } }
        public override string UserHostName { get { throw null; } }
        public override string[] UserLanguages { get { throw null; } }
        public override byte[] BinaryRead(int count) { throw null; }
        public override int[] MapImageCoordinates(string imageFieldName) { throw null; }
        public override string MapPath(string overridePath) { throw null; }
        public override string MapPath(string overridePath, string baseVirtualDir, bool allowCrossAppMapping) { throw null; }
        public override void SaveAs(string filename, bool includeHeaders) { }
        public override void ValidateInput() { }
    }
    [System.Web.AspNetHostingPermissionAttribute(System.Security.Permissions.SecurityAction.InheritanceDemand, Level=(System.Web.AspNetHostingPermissionLevel)(200))]
    [System.Web.AspNetHostingPermissionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Level=(System.Web.AspNetHostingPermissionLevel)(200))]
    public abstract partial class HttpResponseBase
    {
        protected HttpResponseBase() { }
        public virtual bool Buffer { get { throw null; } set { } }
        public virtual bool BufferOutput { get { throw null; } set { } }
        public virtual System.Web.HttpCachePolicyBase Cache { get { throw null; } }
        public virtual string CacheControl { get { throw null; } set { } }
        public virtual string Charset { get { throw null; } set { } }
        public virtual System.Text.Encoding ContentEncoding { get { throw null; } set { } }
        public virtual string ContentType { get { throw null; } set { } }
        public virtual System.Web.HttpCookieCollection Cookies { get { throw null; } }
        public virtual int Expires { get { throw null; } set { } }
        public virtual System.DateTime ExpiresAbsolute { get { throw null; } set { } }
        public virtual System.IO.Stream Filter { get { throw null; } set { } }
        public virtual System.Text.Encoding HeaderEncoding { get { throw null; } set { } }
        public virtual System.Collections.Specialized.NameValueCollection Headers { get { throw null; } }
        public virtual bool IsClientConnected { get { throw null; } }
        public virtual bool IsRequestBeingRedirected { get { throw null; } }
        public virtual System.IO.TextWriter Output { get { throw null; } set { } }
        public virtual System.IO.Stream OutputStream { get { throw null; } }
        public virtual string RedirectLocation { get { throw null; } set { } }
        public virtual string Status { get { throw null; } set { } }
        public virtual int StatusCode { get { throw null; } set { } }
        public virtual string StatusDescription { get { throw null; } set { } }
        public virtual int SubStatusCode { get { throw null; } set { } }
        public virtual bool SuppressContent { get { throw null; } set { } }
        public virtual bool TrySkipIisCustomErrors { get { throw null; } set { } }
        public virtual void AddCacheDependency(params System.Web.Caching.CacheDependency[] dependencies) { }
        public virtual void AddCacheItemDependencies(System.Collections.ArrayList cacheKeys) { }
        public virtual void AddCacheItemDependencies(string[] cacheKeys) { }
        public virtual void AddCacheItemDependency(string cacheKey) { }
        public virtual void AddFileDependencies(System.Collections.ArrayList filenames) { }
        public virtual void AddFileDependencies(string[] filenames) { }
        public virtual void AddFileDependency(string filename) { }
        public virtual void AddHeader(string name, string value) { }
        public virtual void AppendCookie(System.Web.HttpCookie cookie) { }
        public virtual void AppendHeader(string name, string value) { }
        public virtual void AppendToLog(string param) { }
        public virtual string ApplyAppPathModifier(string virtualPath) { throw null; }
        public virtual void BinaryWrite(byte[] buffer) { }
        public virtual void Clear() { }
        public virtual void ClearContent() { }
        public virtual void ClearHeaders() { }
        public virtual void Close() { }
        public virtual void DisableKernelCache() { }
        public virtual void End() { }
        public virtual void Flush() { }
        public virtual void Pics(string value) { }
        public virtual void Redirect(string url) { }
        public virtual void Redirect(string url, bool endResponse) { }
        public virtual void RemoveOutputCacheItem(string path) { }
        public virtual void SetCookie(System.Web.HttpCookie cookie) { }
        public virtual void TransmitFile(string filename) { }
        public virtual void TransmitFile(string filename, long offset, long length) { }
        public virtual void Write(char ch) { }
        public virtual void Write(char[] buffer, int index, int count) { }
        public virtual void Write(object obj) { }
        public virtual void Write(string s) { }
        public virtual void WriteFile(System.IntPtr fileHandle, long offset, long size) { }
        public virtual void WriteFile(string filename) { }
        public virtual void WriteFile(string filename, bool readIntoMemory) { }
        public virtual void WriteFile(string filename, long offset, long size) { }
        public virtual void WriteSubstitution(System.Web.HttpResponseSubstitutionCallback callback) { }
    }
    [System.Web.AspNetHostingPermissionAttribute(System.Security.Permissions.SecurityAction.InheritanceDemand, Level=(System.Web.AspNetHostingPermissionLevel)(200))]
    [System.Web.AspNetHostingPermissionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Level=(System.Web.AspNetHostingPermissionLevel)(200))]
    public partial class HttpResponseWrapper : System.Web.HttpResponseBase
    {
        public HttpResponseWrapper(System.Web.HttpResponse httpResponse) { }
        public override bool Buffer { get { throw null; } set { } }
        public override bool BufferOutput { get { throw null; } set { } }
        public override System.Web.HttpCachePolicyBase Cache { get { throw null; } }
        public override string CacheControl { get { throw null; } set { } }
        public override string Charset { get { throw null; } set { } }
        public override System.Text.Encoding ContentEncoding { get { throw null; } set { } }
        public override string ContentType { get { throw null; } set { } }
        public override System.Web.HttpCookieCollection Cookies { get { throw null; } }
        public override int Expires { get { throw null; } set { } }
        public override System.DateTime ExpiresAbsolute { get { throw null; } set { } }
        public override System.IO.Stream Filter { get { throw null; } set { } }
        public override System.Text.Encoding HeaderEncoding { get { throw null; } set { } }
        public override System.Collections.Specialized.NameValueCollection Headers { get { throw null; } }
        public override bool IsClientConnected { get { throw null; } }
        public override bool IsRequestBeingRedirected { get { throw null; } }
        public override System.IO.TextWriter Output { get { throw null; } }
        public override System.IO.Stream OutputStream { get { throw null; } }
        public override string RedirectLocation { get { throw null; } set { } }
        public override string Status { get { throw null; } set { } }
        public override int StatusCode { get { throw null; } set { } }
        public override string StatusDescription { get { throw null; } set { } }
        public override int SubStatusCode { get { throw null; } set { } }
        public override bool SuppressContent { get { throw null; } set { } }
        public override bool TrySkipIisCustomErrors { get { throw null; } set { } }
        public override void AddCacheDependency(params System.Web.Caching.CacheDependency[] dependencies) { }
        public override void AddCacheItemDependencies(System.Collections.ArrayList cacheKeys) { }
        public override void AddCacheItemDependencies(string[] cacheKeys) { }
        public override void AddCacheItemDependency(string cacheKey) { }
        public override void AddFileDependencies(System.Collections.ArrayList filenames) { }
        public override void AddFileDependencies(string[] filenames) { }
        public override void AddFileDependency(string filename) { }
        public override void AddHeader(string name, string value) { }
        public override void AppendCookie(System.Web.HttpCookie cookie) { }
        public override void AppendHeader(string name, string value) { }
        public override void AppendToLog(string param) { }
        public override string ApplyAppPathModifier(string overridePath) { throw null; }
        public override void BinaryWrite(byte[] buffer) { }
        public override void Clear() { }
        public override void ClearContent() { }
        public override void ClearHeaders() { }
        public override void Close() { }
        public override void DisableKernelCache() { }
        public override void End() { }
        public override void Flush() { }
        public override void Pics(string value) { }
        public override void Redirect(string url) { }
        public override void Redirect(string url, bool endResponse) { }
        public override void RemoveOutputCacheItem(string path) { }
        public override void SetCookie(System.Web.HttpCookie cookie) { }
        public override void TransmitFile(string filename) { }
        public override void TransmitFile(string filename, long offset, long length) { }
        public override void Write(char ch) { }
        public override void Write(char[] buffer, int index, int count) { }
        public override void Write(object obj) { }
        public override void Write(string s) { }
        public override void WriteFile(System.IntPtr fileHandle, long offset, long size) { }
        public override void WriteFile(string filename) { }
        public override void WriteFile(string filename, bool readIntoMemory) { }
        public override void WriteFile(string filename, long offset, long size) { }
        public override void WriteSubstitution(System.Web.HttpResponseSubstitutionCallback callback) { }
    }
    [System.Web.AspNetHostingPermissionAttribute(System.Security.Permissions.SecurityAction.InheritanceDemand, Level=(System.Web.AspNetHostingPermissionLevel)(200))]
    [System.Web.AspNetHostingPermissionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Level=(System.Web.AspNetHostingPermissionLevel)(200))]
    public abstract partial class HttpServerUtilityBase
    {
        protected HttpServerUtilityBase() { }
        public virtual string MachineName { get { throw null; } }
        public virtual int ScriptTimeout { get { throw null; } set { } }
        public virtual void ClearError() { }
        public virtual object CreateObject(string progID) { throw null; }
        public virtual object CreateObject(System.Type type) { throw null; }
        public virtual object CreateObjectFromClsid(string clsid) { throw null; }
        public virtual void Execute(string path) { }
        public virtual void Execute(string path, bool preserveForm) { }
        public virtual void Execute(string path, System.IO.TextWriter writer) { }
        public virtual void Execute(string path, System.IO.TextWriter writer, bool preserveForm) { }
        public virtual void Execute(System.Web.IHttpHandler handler, System.IO.TextWriter writer, bool preserveForm) { }
        public virtual System.Exception GetLastError() { throw null; }
        public virtual string HtmlDecode(string s) { throw null; }
        public virtual void HtmlDecode(string s, System.IO.TextWriter output) { }
        public virtual string HtmlEncode(string s) { throw null; }
        public virtual void HtmlEncode(string s, System.IO.TextWriter output) { }
        public virtual string MapPath(string path) { throw null; }
        public virtual void Transfer(string path) { }
        public virtual void Transfer(string path, bool preserveForm) { }
        public virtual void Transfer(System.Web.IHttpHandler handler, bool preserveForm) { }
        public virtual void TransferRequest(string path) { }
        public virtual void TransferRequest(string path, bool preserveForm) { }
        public virtual void TransferRequest(string path, bool preserveForm, string method, System.Collections.Specialized.NameValueCollection headers) { }
        public virtual string UrlDecode(string s) { throw null; }
        public virtual void UrlDecode(string s, System.IO.TextWriter output) { }
        public virtual string UrlEncode(string s) { throw null; }
        public virtual void UrlEncode(string s, System.IO.TextWriter output) { }
        public virtual string UrlPathEncode(string s) { throw null; }
        public virtual byte[] UrlTokenDecode(string input) { throw null; }
        public virtual string UrlTokenEncode(byte[] input) { throw null; }
    }
    [System.Web.AspNetHostingPermissionAttribute(System.Security.Permissions.SecurityAction.InheritanceDemand, Level=(System.Web.AspNetHostingPermissionLevel)(200))]
    [System.Web.AspNetHostingPermissionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Level=(System.Web.AspNetHostingPermissionLevel)(200))]
    public partial class HttpServerUtilityWrapper : System.Web.HttpServerUtilityBase
    {
        public HttpServerUtilityWrapper(System.Web.HttpServerUtility httpServerUtility) { }
        public override string MachineName { get { throw null; } }
        public override int ScriptTimeout { get { throw null; } set { } }
        public override void ClearError() { }
        public override object CreateObject(string progID) { throw null; }
        public override object CreateObject(System.Type type) { throw null; }
        public override object CreateObjectFromClsid(string clsid) { throw null; }
        public override void Execute(string path) { }
        public override void Execute(string path, bool preserveForm) { }
        public override void Execute(string path, System.IO.TextWriter writer) { }
        public override void Execute(string path, System.IO.TextWriter writer, bool preserveForm) { }
        public override void Execute(System.Web.IHttpHandler handler, System.IO.TextWriter writer, bool preserveForm) { }
        public override System.Exception GetLastError() { throw null; }
        public override string HtmlDecode(string s) { throw null; }
        public override void HtmlDecode(string s, System.IO.TextWriter output) { }
        public override string HtmlEncode(string s) { throw null; }
        public override void HtmlEncode(string s, System.IO.TextWriter output) { }
        public override string MapPath(string path) { throw null; }
        public override void Transfer(string path) { }
        public override void Transfer(string path, bool preserveForm) { }
        public override void Transfer(System.Web.IHttpHandler handler, bool preserveForm) { }
        [System.MonoTODOAttribute]
        public override void TransferRequest(string path) { }
        [System.MonoTODOAttribute]
        public override void TransferRequest(string path, bool preserveForm) { }
        [System.MonoTODOAttribute]
        public override void TransferRequest(string path, bool preserveForm, string method, System.Collections.Specialized.NameValueCollection headers) { }
        public override string UrlDecode(string s) { throw null; }
        public override void UrlDecode(string s, System.IO.TextWriter output) { }
        public override string UrlEncode(string s) { throw null; }
        public override void UrlEncode(string s, System.IO.TextWriter output) { }
        public override string UrlPathEncode(string s) { throw null; }
        [System.MonoTODOAttribute]
        public override byte[] UrlTokenDecode(string input) { throw null; }
        [System.MonoTODOAttribute]
        public override string UrlTokenEncode(byte[] input) { throw null; }
    }
    [System.Web.AspNetHostingPermissionAttribute(System.Security.Permissions.SecurityAction.InheritanceDemand, Level=(System.Web.AspNetHostingPermissionLevel)(200))]
    [System.Web.AspNetHostingPermissionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Level=(System.Web.AspNetHostingPermissionLevel)(200))]
    public abstract partial class HttpSessionStateBase : System.Collections.ICollection, System.Collections.IEnumerable
    {
        protected HttpSessionStateBase() { }
        public virtual int CodePage { get { throw null; } set { } }
        public virtual System.Web.HttpSessionStateBase Contents { get { throw null; } }
        public virtual System.Web.HttpCookieMode CookieMode { get { throw null; } }
        public virtual int Count { get { throw null; } }
        public virtual bool IsCookieless { get { throw null; } }
        public virtual bool IsNewSession { get { throw null; } }
        public virtual bool IsReadOnly { get { throw null; } }
        public virtual bool IsSynchronized { get { throw null; } }
        public virtual object this[int index] { get { throw null; } set { } }
        public virtual object this[string name] { get { throw null; } set { } }
        public virtual System.Collections.Specialized.NameObjectCollectionBase.KeysCollection Keys { get { throw null; } }
        public virtual int LCID { get { throw null; } set { } }
        public virtual System.Web.SessionState.SessionStateMode Mode { get { throw null; } }
        public virtual string SessionID { get { throw null; } }
        public virtual System.Web.HttpStaticObjectsCollectionBase StaticObjects { get { throw null; } }
        public virtual object SyncRoot { get { throw null; } }
        public virtual int Timeout { get { throw null; } set { } }
        public virtual void Abandon() { }
        public virtual void Add(string name, object value) { }
        public virtual void Clear() { }
        public virtual void CopyTo(System.Array array, int index) { }
        public virtual System.Collections.IEnumerator GetEnumerator() { throw null; }
        public virtual void Remove(string name) { }
        public virtual void RemoveAll() { }
        public virtual void RemoveAt(int index) { }
    }
    [System.Web.AspNetHostingPermissionAttribute(System.Security.Permissions.SecurityAction.InheritanceDemand, Level=(System.Web.AspNetHostingPermissionLevel)(200))]
    [System.Web.AspNetHostingPermissionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Level=(System.Web.AspNetHostingPermissionLevel)(200))]
    public partial class HttpSessionStateWrapper : System.Web.HttpSessionStateBase
    {
        public HttpSessionStateWrapper(System.Web.SessionState.HttpSessionState httpSessionState) { }
        public override int CodePage { get { throw null; } set { } }
        public override System.Web.HttpSessionStateBase Contents { get { throw null; } }
        [System.MonoTODOAttribute]
        public override System.Web.HttpCookieMode CookieMode { get { throw null; } }
        public override int Count { get { throw null; } }
        public override bool IsCookieless { get { throw null; } }
        public override bool IsNewSession { get { throw null; } }
        public override bool IsReadOnly { get { throw null; } }
        public override bool IsSynchronized { get { throw null; } }
        public override object this[int index] { get { throw null; } set { } }
        public override object this[string name] { get { throw null; } set { } }
        public override System.Collections.Specialized.NameObjectCollectionBase.KeysCollection Keys { get { throw null; } }
        public override int LCID { get { throw null; } set { } }
        public override System.Web.SessionState.SessionStateMode Mode { get { throw null; } }
        public override string SessionID { get { throw null; } }
        public override System.Web.HttpStaticObjectsCollectionBase StaticObjects { get { throw null; } }
        public override object SyncRoot { get { throw null; } }
        public override int Timeout { get { throw null; } set { } }
        public override void Abandon() { }
        public override void Add(string name, object value) { }
        public override void Clear() { }
        public override void CopyTo(System.Array array, int index) { }
        public override System.Collections.IEnumerator GetEnumerator() { throw null; }
        public override void Remove(string name) { }
        public override void RemoveAll() { }
        public override void RemoveAt(int index) { }
    }
    [System.Web.AspNetHostingPermissionAttribute(System.Security.Permissions.SecurityAction.InheritanceDemand, Level=(System.Web.AspNetHostingPermissionLevel)(200))]
    [System.Web.AspNetHostingPermissionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Level=(System.Web.AspNetHostingPermissionLevel)(200))]
    public abstract partial class HttpStaticObjectsCollectionBase : System.Collections.ICollection, System.Collections.IEnumerable
    {
        protected HttpStaticObjectsCollectionBase() { }
        public virtual int Count { get { throw null; } }
        public virtual bool IsReadOnly { get { throw null; } }
        public virtual bool IsSynchronized { get { throw null; } }
        public virtual object this[string name] { get { throw null; } }
        public virtual bool NeverAccessed { get { throw null; } }
        public virtual object SyncRoot { get { throw null; } }
        public virtual void CopyTo(System.Array array, int index) { }
        public virtual System.Collections.IEnumerator GetEnumerator() { throw null; }
        public virtual object GetObject(string name) { throw null; }
        public virtual void Serialize(System.IO.BinaryWriter writer) { }
    }
    [System.Web.AspNetHostingPermissionAttribute(System.Security.Permissions.SecurityAction.InheritanceDemand, Level=(System.Web.AspNetHostingPermissionLevel)(200))]
    [System.Web.AspNetHostingPermissionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Level=(System.Web.AspNetHostingPermissionLevel)(200))]
    public partial class HttpStaticObjectsCollectionWrapper : System.Web.HttpStaticObjectsCollectionBase
    {
        public HttpStaticObjectsCollectionWrapper(System.Web.HttpStaticObjectsCollection httpStaticObjectsCollection) { }
        public override int Count { get { throw null; } }
        public override bool IsReadOnly { get { throw null; } }
        public override bool IsSynchronized { get { throw null; } }
        public override object this[string name] { get { throw null; } }
        public override bool NeverAccessed { get { throw null; } }
        public override object SyncRoot { get { throw null; } }
        public override void CopyTo(System.Array array, int index) { }
        public override System.Collections.IEnumerator GetEnumerator() { throw null; }
        public override object GetObject(string name) { throw null; }
        public override void Serialize(System.IO.BinaryWriter writer) { }
    }
}
