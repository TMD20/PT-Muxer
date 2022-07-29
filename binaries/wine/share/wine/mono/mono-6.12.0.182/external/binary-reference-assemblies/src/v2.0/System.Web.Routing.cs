// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

[assembly:System.Reflection.AssemblyVersionAttribute("3.5.0.0")]
[assembly:System.CLSCompliantAttribute(true)]
[assembly:System.Diagnostics.DebuggableAttribute((System.Diagnostics.DebuggableAttribute.DebuggingModes)(2))]
[assembly:System.Reflection.AssemblyCompanyAttribute("Mono development team")]
[assembly:System.Reflection.AssemblyCopyrightAttribute("(c) Various Mono authors")]
[assembly:System.Reflection.AssemblyDefaultAliasAttribute("System.Web.Routing.dll")]
[assembly:System.Reflection.AssemblyDescriptionAttribute("System.Web.Routing.dll")]
[assembly:System.Reflection.AssemblyFileVersionAttribute("3.5.21022.8")]
[assembly:System.Reflection.AssemblyInformationalVersionAttribute("3.5.21022.8")]
[assembly:System.Reflection.AssemblyProductAttribute("Mono Common Language Infrastructure")]
[assembly:System.Reflection.AssemblyTitleAttribute("System.Web.Routing.dll")]
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
namespace System.Web.Routing
{
    [System.Web.AspNetHostingPermissionAttribute(System.Security.Permissions.SecurityAction.InheritanceDemand, Level=(System.Web.AspNetHostingPermissionLevel)(200))]
    [System.Web.AspNetHostingPermissionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Level=(System.Web.AspNetHostingPermissionLevel)(200))]
    public partial class HttpMethodConstraint : System.Web.Routing.IRouteConstraint
    {
        public HttpMethodConstraint(params string[] allowedMethods) { }
        public System.Collections.Generic.ICollection<string> AllowedMethods { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        protected virtual bool Match(System.Web.HttpContextBase httpContext, System.Web.Routing.Route route, string parameterName, System.Web.Routing.RouteValueDictionary values, System.Web.Routing.RouteDirection routeDirection) { throw null; }
        bool System.Web.Routing.IRouteConstraint.Match(System.Web.HttpContextBase httpContext, System.Web.Routing.Route route, string parameterName, System.Web.Routing.RouteValueDictionary values, System.Web.Routing.RouteDirection routeDirection) { throw null; }
    }
    [System.Web.AspNetHostingPermissionAttribute((System.Security.Permissions.SecurityAction)(6), Level=(System.Web.AspNetHostingPermissionLevel)(200))]
    [System.Web.AspNetHostingPermissionAttribute((System.Security.Permissions.SecurityAction)(7), Level=(System.Web.AspNetHostingPermissionLevel)(200))]
    public partial interface IRouteConstraint
    {
        bool Match(System.Web.HttpContextBase httpContext, System.Web.Routing.Route route, string parameterName, System.Web.Routing.RouteValueDictionary values, System.Web.Routing.RouteDirection routeDirection);
    }
    [System.Web.AspNetHostingPermissionAttribute((System.Security.Permissions.SecurityAction)(6), Level=(System.Web.AspNetHostingPermissionLevel)(200))]
    [System.Web.AspNetHostingPermissionAttribute((System.Security.Permissions.SecurityAction)(7), Level=(System.Web.AspNetHostingPermissionLevel)(200))]
    public partial interface IRouteHandler
    {
        System.Web.IHttpHandler GetHttpHandler(System.Web.Routing.RequestContext requestContext);
    }
    [System.Web.AspNetHostingPermissionAttribute(System.Security.Permissions.SecurityAction.InheritanceDemand, Level=(System.Web.AspNetHostingPermissionLevel)(200))]
    [System.Web.AspNetHostingPermissionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Level=(System.Web.AspNetHostingPermissionLevel)(200))]
    public partial class RequestContext
    {
        public RequestContext(System.Web.HttpContextBase httpContext, System.Web.Routing.RouteData routeData) { }
        public System.Web.HttpContextBase HttpContext { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        public System.Web.Routing.RouteData RouteData { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
    }
    [System.Web.AspNetHostingPermissionAttribute(System.Security.Permissions.SecurityAction.InheritanceDemand, Level=(System.Web.AspNetHostingPermissionLevel)(200))]
    [System.Web.AspNetHostingPermissionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Level=(System.Web.AspNetHostingPermissionLevel)(200))]
    public partial class Route : System.Web.Routing.RouteBase
    {
        public Route(string url, System.Web.Routing.IRouteHandler routeHandler) { }
        public Route(string url, System.Web.Routing.RouteValueDictionary defaults, System.Web.Routing.IRouteHandler routeHandler) { }
        public Route(string url, System.Web.Routing.RouteValueDictionary defaults, System.Web.Routing.RouteValueDictionary constraints, System.Web.Routing.IRouteHandler routeHandler) { }
        public Route(string url, System.Web.Routing.RouteValueDictionary defaults, System.Web.Routing.RouteValueDictionary constraints, System.Web.Routing.RouteValueDictionary dataTokens, System.Web.Routing.IRouteHandler routeHandler) { }
        public System.Web.Routing.RouteValueDictionary Constraints { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public System.Web.Routing.RouteValueDictionary DataTokens { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public System.Web.Routing.RouteValueDictionary Defaults { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public System.Web.Routing.IRouteHandler RouteHandler { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public string Url { get { throw null; } set { } }
        public override System.Web.Routing.RouteData GetRouteData(System.Web.HttpContextBase httpContext) { throw null; }
        public override System.Web.Routing.VirtualPathData GetVirtualPath(System.Web.Routing.RequestContext requestContext, System.Web.Routing.RouteValueDictionary values) { throw null; }
        protected virtual bool ProcessConstraint(System.Web.HttpContextBase httpContext, object constraint, string parameterName, System.Web.Routing.RouteValueDictionary values, System.Web.Routing.RouteDirection routeDirection) { throw null; }
    }
    [System.Web.AspNetHostingPermissionAttribute(System.Security.Permissions.SecurityAction.InheritanceDemand, Level=(System.Web.AspNetHostingPermissionLevel)(200))]
    [System.Web.AspNetHostingPermissionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Level=(System.Web.AspNetHostingPermissionLevel)(200))]
    public abstract partial class RouteBase
    {
        protected RouteBase() { }
        public abstract System.Web.Routing.RouteData GetRouteData(System.Web.HttpContextBase httpContext);
        public abstract System.Web.Routing.VirtualPathData GetVirtualPath(System.Web.Routing.RequestContext requestContext, System.Web.Routing.RouteValueDictionary values);
    }
    [System.Web.AspNetHostingPermissionAttribute(System.Security.Permissions.SecurityAction.InheritanceDemand, Level=(System.Web.AspNetHostingPermissionLevel)(200))]
    [System.Web.AspNetHostingPermissionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Level=(System.Web.AspNetHostingPermissionLevel)(200))]
    public partial class RouteCollection : System.Collections.ObjectModel.Collection<System.Web.Routing.RouteBase>
    {
        public RouteCollection() { }
        public RouteCollection(System.Web.Hosting.VirtualPathProvider virtualPathProvider) { }
        public System.Web.Routing.RouteBase this[string name] { get { throw null; } }
        public bool RouteExistingFiles { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public void Add(string name, System.Web.Routing.RouteBase item) { }
        protected override void ClearItems() { }
        public System.IDisposable GetReadLock() { throw null; }
        public System.Web.Routing.RouteData GetRouteData(System.Web.HttpContextBase httpContext) { throw null; }
        public System.Web.Routing.VirtualPathData GetVirtualPath(System.Web.Routing.RequestContext requestContext, string name, System.Web.Routing.RouteValueDictionary values) { throw null; }
        public System.Web.Routing.VirtualPathData GetVirtualPath(System.Web.Routing.RequestContext requestContext, System.Web.Routing.RouteValueDictionary values) { throw null; }
        public System.IDisposable GetWriteLock() { throw null; }
        protected override void InsertItem(int index, System.Web.Routing.RouteBase item) { }
        protected override void RemoveItem(int index) { }
        protected override void SetItem(int index, System.Web.Routing.RouteBase item) { }
    }
    [System.Web.AspNetHostingPermissionAttribute(System.Security.Permissions.SecurityAction.InheritanceDemand, Level=(System.Web.AspNetHostingPermissionLevel)(200))]
    [System.Web.AspNetHostingPermissionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Level=(System.Web.AspNetHostingPermissionLevel)(200))]
    public partial class RouteData
    {
        public RouteData() { }
        public RouteData(System.Web.Routing.RouteBase route, System.Web.Routing.IRouteHandler routeHandler) { }
        public System.Web.Routing.RouteValueDictionary DataTokens { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        public System.Web.Routing.RouteBase Route { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public System.Web.Routing.IRouteHandler RouteHandler { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public System.Web.Routing.RouteValueDictionary Values { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        public string GetRequiredString(string valueName) { throw null; }
    }
    public enum RouteDirection
    {
        IncomingRequest = 0,
        UrlGeneration = 1,
    }
    [System.Web.AspNetHostingPermissionAttribute(System.Security.Permissions.SecurityAction.InheritanceDemand, Level=(System.Web.AspNetHostingPermissionLevel)(200))]
    [System.Web.AspNetHostingPermissionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Level=(System.Web.AspNetHostingPermissionLevel)(200))]
    public partial class RouteTable
    {
        public RouteTable() { }
        public static System.Web.Routing.RouteCollection Routes { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
    }
    [System.Web.AspNetHostingPermissionAttribute(System.Security.Permissions.SecurityAction.InheritanceDemand, Level=(System.Web.AspNetHostingPermissionLevel)(200))]
    [System.Web.AspNetHostingPermissionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Level=(System.Web.AspNetHostingPermissionLevel)(200))]
    public partial class RouteValueDictionary : System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<string, object>>, System.Collections.Generic.IDictionary<string, object>, System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<string, object>>, System.Collections.IEnumerable
    {
        public RouteValueDictionary() { }
        public RouteValueDictionary(System.Collections.Generic.IDictionary<string, object> dictionary) { }
        public RouteValueDictionary(object values) { }
        public int Count { get { throw null; } }
        public object this[string key] { get { throw null; } set { } }
        public System.Collections.Generic.Dictionary<string, object>.KeyCollection Keys { get { throw null; } }
        bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<string,object>>.IsReadOnly { get { throw null; } }
        System.Collections.Generic.ICollection<string> System.Collections.Generic.IDictionary<string,object>.Keys { get { throw null; } }
        System.Collections.Generic.ICollection<object> System.Collections.Generic.IDictionary<string,object>.Values { get { throw null; } }
        public System.Collections.Generic.Dictionary<string, object>.ValueCollection Values { get { throw null; } }
        public void Add(string key, object value) { }
        public void Clear() { }
        public bool ContainsKey(string key) { throw null; }
        public bool ContainsValue(object value) { throw null; }
        public System.Collections.Generic.Dictionary<string, object>.Enumerator GetEnumerator() { throw null; }
        public bool Remove(string key) { throw null; }
        void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<string,object>>.Add(System.Collections.Generic.KeyValuePair<string, object> item) { }
        bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<string,object>>.Contains(System.Collections.Generic.KeyValuePair<string, object> item) { throw null; }
        void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<string,object>>.CopyTo(System.Collections.Generic.KeyValuePair<string, object>[] array, int arrayIndex) { }
        bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<string,object>>.Remove(System.Collections.Generic.KeyValuePair<string, object> item) { throw null; }
        System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<string, object>> System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<string,object>>.GetEnumerator() { throw null; }
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { throw null; }
        public bool TryGetValue(string key, out object value) { value = default(object); throw null; }
    }
    [System.Web.AspNetHostingPermissionAttribute(System.Security.Permissions.SecurityAction.InheritanceDemand, Level=(System.Web.AspNetHostingPermissionLevel)(200))]
    [System.Web.AspNetHostingPermissionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Level=(System.Web.AspNetHostingPermissionLevel)(200))]
    public partial class StopRoutingHandler : System.Web.Routing.IRouteHandler
    {
        public StopRoutingHandler() { }
        protected virtual System.Web.IHttpHandler GetHttpHandler(System.Web.Routing.RequestContext requestContext) { throw null; }
        System.Web.IHttpHandler System.Web.Routing.IRouteHandler.GetHttpHandler(System.Web.Routing.RequestContext requestContext) { throw null; }
    }
    [System.Web.AspNetHostingPermissionAttribute(System.Security.Permissions.SecurityAction.InheritanceDemand, Level=(System.Web.AspNetHostingPermissionLevel)(200))]
    [System.Web.AspNetHostingPermissionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Level=(System.Web.AspNetHostingPermissionLevel)(200))]
    public abstract partial class UrlRoutingHandler : System.Web.IHttpHandler
    {
        protected UrlRoutingHandler() { }
        protected virtual bool IsReusable { get { throw null; } }
        public System.Web.Routing.RouteCollection RouteCollection { get { throw null; } set { } }
        bool System.Web.IHttpHandler.IsReusable { get { throw null; } }
        protected virtual void ProcessRequest(System.Web.HttpContext httpContext) { }
        protected virtual void ProcessRequest(System.Web.HttpContextBase httpContext) { }
        void System.Web.IHttpHandler.ProcessRequest(System.Web.HttpContext context) { }
        protected abstract void VerifyAndProcessRequest(System.Web.IHttpHandler httpHandler, System.Web.HttpContextBase httpContext);
    }
    [System.Web.AspNetHostingPermissionAttribute(System.Security.Permissions.SecurityAction.InheritanceDemand, Level=(System.Web.AspNetHostingPermissionLevel)(200))]
    [System.Web.AspNetHostingPermissionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Level=(System.Web.AspNetHostingPermissionLevel)(200))]
    public partial class UrlRoutingModule : System.Web.IHttpModule
    {
        public UrlRoutingModule() { }
        public System.Web.Routing.RouteCollection RouteCollection { get { throw null; } set { } }
        protected virtual void Dispose() { }
        protected virtual void Init(System.Web.HttpApplication application) { }
        public virtual void PostMapRequestHandler(System.Web.HttpContextBase context) { }
        [System.MonoTODOAttribute]
        public virtual void PostResolveRequestCache(System.Web.HttpContextBase context) { }
        void System.Web.IHttpModule.Dispose() { }
        void System.Web.IHttpModule.Init(System.Web.HttpApplication application) { }
    }
    [System.Web.AspNetHostingPermissionAttribute(System.Security.Permissions.SecurityAction.InheritanceDemand, Level=(System.Web.AspNetHostingPermissionLevel)(200))]
    [System.Web.AspNetHostingPermissionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Level=(System.Web.AspNetHostingPermissionLevel)(200))]
    public partial class VirtualPathData
    {
        public VirtualPathData(System.Web.Routing.RouteBase route, string virtualPath) { }
        public System.Web.Routing.RouteValueDictionary DataTokens { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        public System.Web.Routing.RouteBase Route { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public string VirtualPath { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    }
}
