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
[assembly:System.Reflection.AssemblyTitleAttribute("System.Web.Http.WebHost")]
[assembly:System.Reflection.AssemblyTrademarkAttribute("")]
[assembly:System.Resources.NeutralResourcesLanguageAttribute("en-US")]
[assembly:System.Runtime.CompilerServices.CompilationRelaxationsAttribute(8)]
[assembly:System.Runtime.CompilerServices.InternalsVisibleToAttribute("System.Web.Http.WebHost.Test, PublicKey=0024000004800000940000000602000000240000525341310004000001000100b5fc90e7027f67871e773a8fde8938c81dd402ba65b9201d60593e96c492651e889cc13f1415ebb53fac1131ae0bd333c5ee6021672d9718ea31a8aebd0da0072f25d87dba6fc90ffd598ed4da35e44c398c454307e8e33b8426143daec9f596836f97c8f74750e5975c64e2189f45def46b2a2b1247adc3652bf5c308055da9")]
[assembly:System.Runtime.CompilerServices.RuntimeCompatibilityAttribute(WrapNonExceptionThrows=true)]
[assembly:System.Runtime.InteropServices.ComVisibleAttribute(false)]
[assembly:System.Security.SecurityTransparentAttribute]
[assembly:System.Web.PreApplicationStartMethodAttribute(typeof(System.Web.Http.WebHost.PreApplicationStartCode), "Start")]
namespace System.Web.Http
{
    public static partial class GlobalConfiguration
    {
        public static System.Web.Http.HttpConfiguration Configuration { get { throw null; } }
        public static System.Web.Http.Dispatcher.HttpControllerDispatcher Dispatcher { get { throw null; } }
    }
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    public static partial class RouteCollectionExtensions
    {
        public static System.Web.Routing.Route MapHttpRoute(this System.Web.Routing.RouteCollection routes, string name, string routeTemplate) { throw null; }
        public static System.Web.Routing.Route MapHttpRoute(this System.Web.Routing.RouteCollection routes, string name, string routeTemplate, object defaults) { throw null; }
        public static System.Web.Routing.Route MapHttpRoute(this System.Web.Routing.RouteCollection routes, string name, string routeTemplate, object defaults, object constraints) { throw null; }
    }
}
namespace System.Web.Http.WebHost
{
    public partial class HttpControllerHandler : System.Web.IHttpAsyncHandler, System.Web.IHttpHandler
    {
        public HttpControllerHandler(System.Web.Routing.RouteData routeData) { }
        protected virtual bool IsReusable { get { throw null; } }
        bool System.Web.IHttpHandler.IsReusable { get { throw null; } }
        protected virtual System.IAsyncResult BeginProcessRequest(System.Web.HttpContextBase httpContextBase, System.AsyncCallback callback, object state) { throw null; }
        protected virtual void EndProcessRequest(System.IAsyncResult result) { }
        protected virtual void ProcessRequest(System.Web.HttpContextBase httpContextBase) { }
        System.IAsyncResult System.Web.IHttpAsyncHandler.BeginProcessRequest(System.Web.HttpContext httpContext, System.AsyncCallback callback, object state) { throw null; }
        void System.Web.IHttpAsyncHandler.EndProcessRequest(System.IAsyncResult result) { }
        void System.Web.IHttpHandler.ProcessRequest(System.Web.HttpContext httpContext) { }
    }
    public partial class HttpControllerRouteHandler : System.Web.Routing.IRouteHandler
    {
        protected HttpControllerRouteHandler() { }
        public static System.Web.Http.WebHost.HttpControllerRouteHandler Instance { get { throw null; } }
        protected virtual System.Web.IHttpHandler GetHttpHandler(System.Web.Routing.RequestContext requestContext) { throw null; }
        System.Web.IHttpHandler System.Web.Routing.IRouteHandler.GetHttpHandler(System.Web.Routing.RequestContext requestContext) { throw null; }
    }
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    public static partial class PreApplicationStartCode
    {
        public static void Start() { }
    }
}
namespace System.Web.Http.WebHost.Routing
{
    public partial class HttpWebRoute : System.Web.Routing.Route
    {
        public HttpWebRoute(string url, System.Web.Routing.IRouteHandler routeHandler) : base (default(string), default(System.Web.Routing.IRouteHandler)) { }
        public HttpWebRoute(string url, System.Web.Routing.RouteValueDictionary defaults, System.Web.Routing.IRouteHandler routeHandler) : base (default(string), default(System.Web.Routing.IRouteHandler)) { }
        public HttpWebRoute(string url, System.Web.Routing.RouteValueDictionary defaults, System.Web.Routing.RouteValueDictionary constraints, System.Web.Routing.IRouteHandler routeHandler) : base (default(string), default(System.Web.Routing.IRouteHandler)) { }
        public HttpWebRoute(string url, System.Web.Routing.RouteValueDictionary defaults, System.Web.Routing.RouteValueDictionary constraints, System.Web.Routing.RouteValueDictionary dataTokens, System.Web.Routing.IRouteHandler routeHandler) : base (default(string), default(System.Web.Routing.IRouteHandler)) { }
        public override System.Web.Routing.VirtualPathData GetVirtualPath(System.Web.Routing.RequestContext requestContext, System.Web.Routing.RouteValueDictionary values) { throw null; }
        protected override bool ProcessConstraint(System.Web.HttpContextBase httpContext, object constraint, string parameterName, System.Web.Routing.RouteValueDictionary values, System.Web.Routing.RouteDirection routeDirection) { throw null; }
    }
}
