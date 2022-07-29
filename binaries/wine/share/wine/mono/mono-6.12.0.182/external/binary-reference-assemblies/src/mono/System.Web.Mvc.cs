// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

[assembly:System.Reflection.AssemblyVersionAttribute("3.0.0.0")]
[assembly:System.CLSCompliantAttribute(true)]
[assembly:System.Diagnostics.DebuggableAttribute((System.Diagnostics.DebuggableAttribute.DebuggingModes)(2))]
[assembly:System.Reflection.AssemblyCompanyAttribute("Microsoft Corporation")]
[assembly:System.Reflection.AssemblyConfigurationAttribute("")]
[assembly:System.Reflection.AssemblyCopyrightAttribute("© Microsoft Corporation. All rights reserved.")]
[assembly:System.Reflection.AssemblyDescriptionAttribute("System.Web.Mvc.dll")]
[assembly:System.Reflection.AssemblyFileVersionAttribute("3.0.20107.0")]
[assembly:System.Reflection.AssemblyProductAttribute("Microsoft® .NET Framework")]
[assembly:System.Reflection.AssemblyTitleAttribute("System.Web.Mvc.dll")]
[assembly:System.Reflection.AssemblyTrademarkAttribute("")]
[assembly:System.Resources.NeutralResourcesLanguageAttribute("en-US")]
[assembly:System.Runtime.CompilerServices.CompilationRelaxationsAttribute(8)]
[assembly:System.Runtime.CompilerServices.ReferenceAssemblyAttribute]
[assembly:System.Runtime.CompilerServices.RuntimeCompatibilityAttribute(WrapNonExceptionThrows=true)]
[assembly:System.Runtime.InteropServices.ComVisibleAttribute(false)]
[assembly:System.Runtime.InteropServices.GuidAttribute("4b5f4208-c6b0-4c37-9a41-63325ffa52ad")]
[assembly:System.Security.AllowPartiallyTrustedCallersAttribute]
[assembly:System.Security.SecurityTransparentAttribute]
[assembly:System.Web.PreApplicationStartMethodAttribute(typeof(System.Web.Mvc.PreApplicationStartCode), "Start")]
[assembly:System.Runtime.CompilerServices.TypeForwardedToAttribute(typeof(System.Web.Mvc.HttpAntiForgeryException))]
[assembly:System.Runtime.CompilerServices.TypeForwardedToAttribute(typeof(System.Web.Mvc.TagBuilder))]
[assembly:System.Runtime.CompilerServices.TypeForwardedToAttribute(typeof(System.Web.Mvc.TagRenderMode))]
namespace System.Web.Mvc
{
    [System.AttributeUsageAttribute((System.AttributeTargets)(64), AllowMultiple=false, Inherited=true)]
    public sealed partial class AcceptVerbsAttribute : System.Web.Mvc.ActionMethodSelectorAttribute
    {
        public AcceptVerbsAttribute(params string[] verbs) { }
        public AcceptVerbsAttribute(System.Web.Mvc.HttpVerbs verbs) { }
        public System.Collections.Generic.ICollection<string> Verbs { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        public override bool IsValidForRequest(System.Web.Mvc.ControllerContext controllerContext, System.Reflection.MethodInfo methodInfo) { throw null; }
    }
    public abstract partial class ActionDescriptor : System.Reflection.ICustomAttributeProvider
    {
        protected ActionDescriptor() { }
        public abstract string ActionName { get; }
        public abstract System.Web.Mvc.ControllerDescriptor ControllerDescriptor { get; }
        public virtual string UniqueId { get { throw null; } }
        public abstract object Execute(System.Web.Mvc.ControllerContext controllerContext, System.Collections.Generic.IDictionary<string, object> parameters);
        public virtual object[] GetCustomAttributes(bool inherit) { throw null; }
        public virtual object[] GetCustomAttributes(System.Type attributeType, bool inherit) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
        [System.ObsoleteAttribute("Please call System.Web.Mvc.FilterProviders.Providers.GetFilters() now.", true)]
        public virtual System.Web.Mvc.FilterInfo GetFilters() { throw null; }
        public abstract System.Web.Mvc.ParameterDescriptor[] GetParameters();
        public virtual System.Collections.Generic.ICollection<System.Web.Mvc.ActionSelector> GetSelectors() { throw null; }
        public virtual bool IsDefined(System.Type attributeType, bool inherit) { throw null; }
    }
    public partial class ActionExecutedContext : System.Web.Mvc.ControllerContext
    {
        public ActionExecutedContext() { }
        public ActionExecutedContext(System.Web.Mvc.ControllerContext controllerContext, System.Web.Mvc.ActionDescriptor actionDescriptor, bool canceled, System.Exception exception) { }
        public virtual System.Web.Mvc.ActionDescriptor ActionDescriptor { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public virtual bool Canceled { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public virtual System.Exception Exception { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public bool ExceptionHandled { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public System.Web.Mvc.ActionResult Result { get { throw null; } set { } }
    }
    public partial class ActionExecutingContext : System.Web.Mvc.ControllerContext
    {
        public ActionExecutingContext() { }
        public ActionExecutingContext(System.Web.Mvc.ControllerContext controllerContext, System.Web.Mvc.ActionDescriptor actionDescriptor, System.Collections.Generic.IDictionary<string, object> actionParameters) { }
        public virtual System.Web.Mvc.ActionDescriptor ActionDescriptor { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public virtual System.Collections.Generic.IDictionary<string, object> ActionParameters { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public System.Web.Mvc.ActionResult Result { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    }
    [System.AttributeUsageAttribute((System.AttributeTargets)(68), Inherited=true, AllowMultiple=false)]
    public abstract partial class ActionFilterAttribute : System.Web.Mvc.FilterAttribute, System.Web.Mvc.IActionFilter, System.Web.Mvc.IResultFilter
    {
        protected ActionFilterAttribute() { }
        public virtual void OnActionExecuted(System.Web.Mvc.ActionExecutedContext filterContext) { }
        public virtual void OnActionExecuting(System.Web.Mvc.ActionExecutingContext filterContext) { }
        public virtual void OnResultExecuted(System.Web.Mvc.ResultExecutedContext filterContext) { }
        public virtual void OnResultExecuting(System.Web.Mvc.ResultExecutingContext filterContext) { }
    }
    [System.AttributeUsageAttribute((System.AttributeTargets)(64), AllowMultiple=false, Inherited=true)]
    public abstract partial class ActionMethodSelectorAttribute : System.Attribute
    {
        protected ActionMethodSelectorAttribute() { }
        public abstract bool IsValidForRequest(System.Web.Mvc.ControllerContext controllerContext, System.Reflection.MethodInfo methodInfo);
    }
    [System.AttributeUsageAttribute((System.AttributeTargets)(64), AllowMultiple=false, Inherited=true)]
    public sealed partial class ActionNameAttribute : System.Web.Mvc.ActionNameSelectorAttribute
    {
        public ActionNameAttribute(string name) { }
        public string Name { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        public override bool IsValidName(System.Web.Mvc.ControllerContext controllerContext, string actionName, System.Reflection.MethodInfo methodInfo) { throw null; }
    }
    [System.AttributeUsageAttribute((System.AttributeTargets)(64), AllowMultiple=false, Inherited=true)]
    public abstract partial class ActionNameSelectorAttribute : System.Attribute
    {
        protected ActionNameSelectorAttribute() { }
        public abstract bool IsValidName(System.Web.Mvc.ControllerContext controllerContext, string actionName, System.Reflection.MethodInfo methodInfo);
    }
    public abstract partial class ActionResult
    {
        protected ActionResult() { }
        public abstract void ExecuteResult(System.Web.Mvc.ControllerContext context);
    }
    public delegate bool ActionSelector(System.Web.Mvc.ControllerContext controllerContext);
    [System.AttributeUsageAttribute((System.AttributeTargets)(1156), AllowMultiple=true)]
    public sealed partial class AdditionalMetadataAttribute : System.Attribute, System.Web.Mvc.IMetadataAware
    {
        public AdditionalMetadataAttribute(string name, object value) { }
        public string Name { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        public override object TypeId { get { throw null; } }
        public object Value { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        public void OnMetadataCreated(System.Web.Mvc.ModelMetadata metadata) { }
    }
    public partial class AjaxHelper
    {
        public AjaxHelper(System.Web.Mvc.ViewContext viewContext, System.Web.Mvc.IViewDataContainer viewDataContainer) { }
        public AjaxHelper(System.Web.Mvc.ViewContext viewContext, System.Web.Mvc.IViewDataContainer viewDataContainer, System.Web.Routing.RouteCollection routeCollection) { }
        public static string GlobalizationScriptPath { get { throw null; } set { } }
        public System.Web.Routing.RouteCollection RouteCollection { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        public System.Web.Mvc.ViewContext ViewContext { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        public System.Web.Mvc.ViewDataDictionary ViewData { get { throw null; } }
        public System.Web.Mvc.IViewDataContainer ViewDataContainer { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        public string JavaScriptStringEncode(string message) { throw null; }
    }
    public partial class AjaxHelper<TModel> : System.Web.Mvc.AjaxHelper
    {
        public AjaxHelper(System.Web.Mvc.ViewContext viewContext, System.Web.Mvc.IViewDataContainer viewDataContainer) : base (default(System.Web.Mvc.ViewContext), default(System.Web.Mvc.IViewDataContainer)) { }
        public AjaxHelper(System.Web.Mvc.ViewContext viewContext, System.Web.Mvc.IViewDataContainer viewDataContainer, System.Web.Routing.RouteCollection routeCollection) : base (default(System.Web.Mvc.ViewContext), default(System.Web.Mvc.IViewDataContainer)) { }
        public new System.Web.Mvc.ViewDataDictionary<TModel> ViewData { get { throw null; } }
    }
    public static partial class AjaxRequestExtensions
    {
        public static bool IsAjaxRequest(this System.Web.HttpRequestBase request) { throw null; }
    }
    [System.AttributeUsageAttribute((System.AttributeTargets)(128), AllowMultiple=false, Inherited=true)]
    public sealed partial class AllowHtmlAttribute : System.Attribute, System.Web.Mvc.IMetadataAware
    {
        public AllowHtmlAttribute() { }
        public void OnMetadataCreated(System.Web.Mvc.ModelMetadata metadata) { }
    }
    public abstract partial class AreaRegistration
    {
        protected AreaRegistration() { }
        public abstract string AreaName { get; }
        public static void RegisterAllAreas() { }
        public static void RegisterAllAreas(object state) { }
        public abstract void RegisterArea(System.Web.Mvc.AreaRegistrationContext context);
    }
    public partial class AreaRegistrationContext
    {
        public AreaRegistrationContext(string areaName, System.Web.Routing.RouteCollection routes) { }
        public AreaRegistrationContext(string areaName, System.Web.Routing.RouteCollection routes, object state) { }
        public string AreaName { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        public System.Collections.Generic.ICollection<string> Namespaces { get { throw null; } }
        public System.Web.Routing.RouteCollection Routes { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        public object State { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        public System.Web.Routing.Route MapRoute(string name, string url) { throw null; }
        public System.Web.Routing.Route MapRoute(string name, string url, object defaults) { throw null; }
        public System.Web.Routing.Route MapRoute(string name, string url, object defaults, object constraints) { throw null; }
        public System.Web.Routing.Route MapRoute(string name, string url, object defaults, object constraints, string[] namespaces) { throw null; }
        public System.Web.Routing.Route MapRoute(string name, string url, object defaults, string[] namespaces) { throw null; }
        public System.Web.Routing.Route MapRoute(string name, string url, string[] namespaces) { throw null; }
    }
    public abstract partial class AssociatedMetadataProvider : System.Web.Mvc.ModelMetadataProvider
    {
        protected AssociatedMetadataProvider() { }
        protected abstract System.Web.Mvc.ModelMetadata CreateMetadata(System.Collections.Generic.IEnumerable<System.Attribute> attributes, System.Type containerType, System.Func<object> modelAccessor, System.Type modelType, string propertyName);
        protected virtual System.Collections.Generic.IEnumerable<System.Attribute> FilterAttributes(System.Type containerType, System.ComponentModel.PropertyDescriptor propertyDescriptor, System.Collections.Generic.IEnumerable<System.Attribute> attributes) { throw null; }
        public override System.Collections.Generic.IEnumerable<System.Web.Mvc.ModelMetadata> GetMetadataForProperties(object container, System.Type containerType) { throw null; }
        protected virtual System.Web.Mvc.ModelMetadata GetMetadataForProperty(System.Func<object> modelAccessor, System.Type containerType, System.ComponentModel.PropertyDescriptor propertyDescriptor) { throw null; }
        public override System.Web.Mvc.ModelMetadata GetMetadataForProperty(System.Func<object> modelAccessor, System.Type containerType, string propertyName) { throw null; }
        public override System.Web.Mvc.ModelMetadata GetMetadataForType(System.Func<object> modelAccessor, System.Type modelType) { throw null; }
        protected virtual System.ComponentModel.ICustomTypeDescriptor GetTypeDescriptor(System.Type type) { throw null; }
    }
    public abstract partial class AssociatedValidatorProvider : System.Web.Mvc.ModelValidatorProvider
    {
        protected AssociatedValidatorProvider() { }
        protected virtual System.ComponentModel.ICustomTypeDescriptor GetTypeDescriptor(System.Type type) { throw null; }
        public sealed override System.Collections.Generic.IEnumerable<System.Web.Mvc.ModelValidator> GetValidators(System.Web.Mvc.ModelMetadata metadata, System.Web.Mvc.ControllerContext context) { throw null; }
        protected abstract System.Collections.Generic.IEnumerable<System.Web.Mvc.ModelValidator> GetValidators(System.Web.Mvc.ModelMetadata metadata, System.Web.Mvc.ControllerContext context, System.Collections.Generic.IEnumerable<System.Attribute> attributes);
    }
    public abstract partial class AsyncController : System.Web.Mvc.Controller, System.Web.Mvc.Async.IAsyncController, System.Web.Mvc.Async.IAsyncManagerContainer, System.Web.Mvc.IController
    {
        protected AsyncController() { }
        public System.Web.Mvc.Async.AsyncManager AsyncManager { get { throw null; } }
        protected virtual System.IAsyncResult BeginExecute(System.Web.Routing.RequestContext requestContext, System.AsyncCallback callback, object state) { throw null; }
        protected virtual System.IAsyncResult BeginExecuteCore(System.AsyncCallback callback, object state) { throw null; }
        protected override System.Web.Mvc.IActionInvoker CreateActionInvoker() { throw null; }
        protected virtual void EndExecute(System.IAsyncResult asyncResult) { }
        protected virtual void EndExecuteCore(System.IAsyncResult asyncResult) { }
        System.IAsyncResult System.Web.Mvc.Async.IAsyncController.BeginExecute(System.Web.Routing.RequestContext requestContext, System.AsyncCallback callback, object state) { throw null; }
        void System.Web.Mvc.Async.IAsyncController.EndExecute(System.IAsyncResult asyncResult) { }
    }
    [System.AttributeUsageAttribute((System.AttributeTargets)(68), Inherited=true, AllowMultiple=false)]
    public partial class AsyncTimeoutAttribute : System.Web.Mvc.ActionFilterAttribute
    {
        public AsyncTimeoutAttribute(int duration) { }
        public int Duration { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        public override void OnActionExecuting(System.Web.Mvc.ActionExecutingContext filterContext) { }
    }
    public partial class AuthorizationContext : System.Web.Mvc.ControllerContext
    {
        public AuthorizationContext() { }
        [System.ObsoleteAttribute("The recommended alternative is the constructor AuthorizationContext(ControllerContext controllerContext, ActionDescriptor actionDescriptor).")]
        public AuthorizationContext(System.Web.Mvc.ControllerContext controllerContext) { }
        public AuthorizationContext(System.Web.Mvc.ControllerContext controllerContext, System.Web.Mvc.ActionDescriptor actionDescriptor) { }
        public virtual System.Web.Mvc.ActionDescriptor ActionDescriptor { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public System.Web.Mvc.ActionResult Result { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    }
    [System.AttributeUsageAttribute((System.AttributeTargets)(68), Inherited=true, AllowMultiple=true)]
    public partial class AuthorizeAttribute : System.Web.Mvc.FilterAttribute, System.Web.Mvc.IAuthorizationFilter
    {
        public AuthorizeAttribute() { }
        public string Roles { get { throw null; } set { } }
        public override object TypeId { get { throw null; } }
        public string Users { get { throw null; } set { } }
        protected virtual bool AuthorizeCore(System.Web.HttpContextBase httpContext) { throw null; }
        protected virtual void HandleUnauthorizedRequest(System.Web.Mvc.AuthorizationContext filterContext) { }
        public virtual void OnAuthorization(System.Web.Mvc.AuthorizationContext filterContext) { }
        protected virtual System.Web.HttpValidationStatus OnCacheAuthorization(System.Web.HttpContextBase httpContext) { throw null; }
    }
    [System.AttributeUsageAttribute((System.AttributeTargets)(2052), AllowMultiple=false, Inherited=true)]
    public sealed partial class BindAttribute : System.Attribute
    {
        public BindAttribute() { }
        public string Exclude { get { throw null; } set { } }
        public string Include { get { throw null; } set { } }
        public string Prefix { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public bool IsPropertyAllowed(string propertyName) { throw null; }
    }
    public abstract partial class BuildManagerCompiledView : System.Web.Mvc.IView
    {
        protected BuildManagerCompiledView(System.Web.Mvc.ControllerContext controllerContext, string viewPath) { }
        protected BuildManagerCompiledView(System.Web.Mvc.ControllerContext controllerContext, string viewPath, System.Web.Mvc.IViewPageActivator viewPageActivator) { }
        public string ViewPath { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]protected set { } }
        public void Render(System.Web.Mvc.ViewContext viewContext, System.IO.TextWriter writer) { }
        protected abstract void RenderView(System.Web.Mvc.ViewContext viewContext, System.IO.TextWriter writer, object instance);
    }
    public abstract partial class BuildManagerViewEngine : System.Web.Mvc.VirtualPathProviderViewEngine
    {
        protected BuildManagerViewEngine() { }
        protected BuildManagerViewEngine(System.Web.Mvc.IViewPageActivator viewPageActivator) { }
        protected System.Web.Mvc.IViewPageActivator ViewPageActivator { get { throw null; } }
        protected override bool FileExists(System.Web.Mvc.ControllerContext controllerContext, string virtualPath) { throw null; }
    }
    public partial class ByteArrayModelBinder : System.Web.Mvc.IModelBinder
    {
        public ByteArrayModelBinder() { }
        public virtual object BindModel(System.Web.Mvc.ControllerContext controllerContext, System.Web.Mvc.ModelBindingContext bindingContext) { throw null; }
    }
    [System.AttributeUsageAttribute((System.AttributeTargets)(68), AllowMultiple=false, Inherited=true)]
    public sealed partial class ChildActionOnlyAttribute : System.Web.Mvc.FilterAttribute, System.Web.Mvc.IAuthorizationFilter
    {
        public ChildActionOnlyAttribute() { }
        public void OnAuthorization(System.Web.Mvc.AuthorizationContext filterContext) { }
    }
    public sealed partial class ChildActionValueProvider : System.Web.Mvc.DictionaryValueProvider<object>
    {
        public ChildActionValueProvider(System.Web.Mvc.ControllerContext controllerContext) : base (default(System.Collections.Generic.IDictionary<string, object>), default(System.Globalization.CultureInfo)) { }
        public override System.Web.Mvc.ValueProviderResult GetValue(string key) { throw null; }
    }
    public sealed partial class ChildActionValueProviderFactory : System.Web.Mvc.ValueProviderFactory
    {
        public ChildActionValueProviderFactory() { }
        public override System.Web.Mvc.IValueProvider GetValueProvider(System.Web.Mvc.ControllerContext controllerContext) { throw null; }
    }
    public partial class ClientDataTypeModelValidatorProvider : System.Web.Mvc.ModelValidatorProvider
    {
        public ClientDataTypeModelValidatorProvider() { }
        public override System.Collections.Generic.IEnumerable<System.Web.Mvc.ModelValidator> GetValidators(System.Web.Mvc.ModelMetadata metadata, System.Web.Mvc.ControllerContext context) { throw null; }
    }
    [System.AttributeUsageAttribute((System.AttributeTargets)(128))]
    public partial class CompareAttribute : System.ComponentModel.DataAnnotations.ValidationAttribute, System.Web.Mvc.IClientValidatable
    {
        public CompareAttribute(string otherProperty) { }
        public string OtherProperty { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        public override string FormatErrorMessage(string name) { throw null; }
        public static string FormatPropertyForClientValidation(string property) { throw null; }
        public System.Collections.Generic.IEnumerable<System.Web.Mvc.ModelClientValidationRule> GetClientValidationRules(System.Web.Mvc.ModelMetadata metadata, System.Web.Mvc.ControllerContext context) { throw null; }
        protected override System.ComponentModel.DataAnnotations.ValidationResult IsValid(object value, System.ComponentModel.DataAnnotations.ValidationContext validationContext) { throw null; }
    }
    public partial class ContentResult : System.Web.Mvc.ActionResult
    {
        public ContentResult() { }
        public string Content { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public System.Text.Encoding ContentEncoding { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public string ContentType { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public override void ExecuteResult(System.Web.Mvc.ControllerContext context) { }
    }
    public abstract partial class Controller : System.Web.Mvc.ControllerBase, System.IDisposable, System.Web.Mvc.IActionFilter, System.Web.Mvc.IAuthorizationFilter, System.Web.Mvc.IExceptionFilter, System.Web.Mvc.IResultFilter
    {
        protected Controller() { }
        public System.Web.Mvc.IActionInvoker ActionInvoker { get { throw null; } set { } }
        protected internal System.Web.Mvc.ModelBinderDictionary Binders { get { throw null; } set { } }
        public System.Web.HttpContextBase HttpContext { get { throw null; } }
        public System.Web.Mvc.ModelStateDictionary ModelState { get { throw null; } }
        public System.Web.HttpRequestBase Request { get { throw null; } }
        public System.Web.HttpResponseBase Response { get { throw null; } }
        public System.Web.Routing.RouteData RouteData { get { throw null; } }
        public System.Web.HttpServerUtilityBase Server { get { throw null; } }
        public System.Web.HttpSessionStateBase Session { get { throw null; } }
        public System.Web.Mvc.ITempDataProvider TempDataProvider { get { throw null; } set { } }
        public System.Web.Mvc.UrlHelper Url { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public System.Security.Principal.IPrincipal User { get { throw null; } }
        protected internal System.Web.Mvc.ContentResult Content(string content) { throw null; }
        protected internal System.Web.Mvc.ContentResult Content(string content, string contentType) { throw null; }
        protected internal virtual System.Web.Mvc.ContentResult Content(string content, string contentType, System.Text.Encoding contentEncoding) { throw null; }
        protected virtual System.Web.Mvc.IActionInvoker CreateActionInvoker() { throw null; }
        protected virtual System.Web.Mvc.ITempDataProvider CreateTempDataProvider() { throw null; }
        public void Dispose() { }
        protected virtual void Dispose(bool disposing) { }
        protected override void ExecuteCore() { }
        protected internal System.Web.Mvc.FileContentResult File(byte[] fileContents, string contentType) { throw null; }
        protected internal virtual System.Web.Mvc.FileContentResult File(byte[] fileContents, string contentType, string fileDownloadName) { throw null; }
        protected internal System.Web.Mvc.FileStreamResult File(System.IO.Stream fileStream, string contentType) { throw null; }
        protected internal virtual System.Web.Mvc.FileStreamResult File(System.IO.Stream fileStream, string contentType, string fileDownloadName) { throw null; }
        protected internal System.Web.Mvc.FilePathResult File(string fileName, string contentType) { throw null; }
        protected internal virtual System.Web.Mvc.FilePathResult File(string fileName, string contentType, string fileDownloadName) { throw null; }
        protected virtual void HandleUnknownAction(string actionName) { }
        protected internal System.Web.Mvc.HttpNotFoundResult HttpNotFound() { throw null; }
        protected internal virtual System.Web.Mvc.HttpNotFoundResult HttpNotFound(string statusDescription) { throw null; }
        protected override void Initialize(System.Web.Routing.RequestContext requestContext) { }
        protected internal virtual System.Web.Mvc.JavaScriptResult JavaScript(string script) { throw null; }
        protected internal System.Web.Mvc.JsonResult Json(object data) { throw null; }
        protected internal System.Web.Mvc.JsonResult Json(object data, string contentType) { throw null; }
        protected internal virtual System.Web.Mvc.JsonResult Json(object data, string contentType, System.Text.Encoding contentEncoding) { throw null; }
        protected internal virtual System.Web.Mvc.JsonResult Json(object data, string contentType, System.Text.Encoding contentEncoding, System.Web.Mvc.JsonRequestBehavior behavior) { throw null; }
        protected internal System.Web.Mvc.JsonResult Json(object data, string contentType, System.Web.Mvc.JsonRequestBehavior behavior) { throw null; }
        protected internal System.Web.Mvc.JsonResult Json(object data, System.Web.Mvc.JsonRequestBehavior behavior) { throw null; }
        protected virtual void OnActionExecuted(System.Web.Mvc.ActionExecutedContext filterContext) { }
        protected virtual void OnActionExecuting(System.Web.Mvc.ActionExecutingContext filterContext) { }
        protected virtual void OnAuthorization(System.Web.Mvc.AuthorizationContext filterContext) { }
        protected virtual void OnException(System.Web.Mvc.ExceptionContext filterContext) { }
        protected virtual void OnResultExecuted(System.Web.Mvc.ResultExecutedContext filterContext) { }
        protected virtual void OnResultExecuting(System.Web.Mvc.ResultExecutingContext filterContext) { }
        protected internal System.Web.Mvc.PartialViewResult PartialView() { throw null; }
        protected internal System.Web.Mvc.PartialViewResult PartialView(object model) { throw null; }
        protected internal System.Web.Mvc.PartialViewResult PartialView(string viewName) { throw null; }
        protected internal virtual System.Web.Mvc.PartialViewResult PartialView(string viewName, object model) { throw null; }
        protected internal virtual System.Web.Mvc.RedirectResult Redirect(string url) { throw null; }
        protected internal virtual System.Web.Mvc.RedirectResult RedirectPermanent(string url) { throw null; }
        protected internal System.Web.Mvc.RedirectToRouteResult RedirectToAction(string actionName) { throw null; }
        protected internal System.Web.Mvc.RedirectToRouteResult RedirectToAction(string actionName, object routeValues) { throw null; }
        protected internal System.Web.Mvc.RedirectToRouteResult RedirectToAction(string actionName, string controllerName) { throw null; }
        protected internal System.Web.Mvc.RedirectToRouteResult RedirectToAction(string actionName, string controllerName, object routeValues) { throw null; }
        protected internal virtual System.Web.Mvc.RedirectToRouteResult RedirectToAction(string actionName, string controllerName, System.Web.Routing.RouteValueDictionary routeValues) { throw null; }
        protected internal System.Web.Mvc.RedirectToRouteResult RedirectToAction(string actionName, System.Web.Routing.RouteValueDictionary routeValues) { throw null; }
        protected internal System.Web.Mvc.RedirectToRouteResult RedirectToActionPermanent(string actionName) { throw null; }
        protected internal System.Web.Mvc.RedirectToRouteResult RedirectToActionPermanent(string actionName, object routeValues) { throw null; }
        protected internal System.Web.Mvc.RedirectToRouteResult RedirectToActionPermanent(string actionName, string controllerName) { throw null; }
        protected internal System.Web.Mvc.RedirectToRouteResult RedirectToActionPermanent(string actionName, string controllerName, object routeValues) { throw null; }
        protected internal virtual System.Web.Mvc.RedirectToRouteResult RedirectToActionPermanent(string actionName, string controllerName, System.Web.Routing.RouteValueDictionary routeValues) { throw null; }
        protected internal System.Web.Mvc.RedirectToRouteResult RedirectToActionPermanent(string actionName, System.Web.Routing.RouteValueDictionary routeValues) { throw null; }
        protected internal System.Web.Mvc.RedirectToRouteResult RedirectToRoute(object routeValues) { throw null; }
        protected internal System.Web.Mvc.RedirectToRouteResult RedirectToRoute(string routeName) { throw null; }
        protected internal System.Web.Mvc.RedirectToRouteResult RedirectToRoute(string routeName, object routeValues) { throw null; }
        protected internal virtual System.Web.Mvc.RedirectToRouteResult RedirectToRoute(string routeName, System.Web.Routing.RouteValueDictionary routeValues) { throw null; }
        protected internal System.Web.Mvc.RedirectToRouteResult RedirectToRoute(System.Web.Routing.RouteValueDictionary routeValues) { throw null; }
        protected internal System.Web.Mvc.RedirectToRouteResult RedirectToRoutePermanent(object routeValues) { throw null; }
        protected internal System.Web.Mvc.RedirectToRouteResult RedirectToRoutePermanent(string routeName) { throw null; }
        protected internal System.Web.Mvc.RedirectToRouteResult RedirectToRoutePermanent(string routeName, object routeValues) { throw null; }
        protected internal virtual System.Web.Mvc.RedirectToRouteResult RedirectToRoutePermanent(string routeName, System.Web.Routing.RouteValueDictionary routeValues) { throw null; }
        protected internal System.Web.Mvc.RedirectToRouteResult RedirectToRoutePermanent(System.Web.Routing.RouteValueDictionary routeValues) { throw null; }
        void System.Web.Mvc.IActionFilter.OnActionExecuted(System.Web.Mvc.ActionExecutedContext filterContext) { }
        void System.Web.Mvc.IActionFilter.OnActionExecuting(System.Web.Mvc.ActionExecutingContext filterContext) { }
        void System.Web.Mvc.IAuthorizationFilter.OnAuthorization(System.Web.Mvc.AuthorizationContext filterContext) { }
        void System.Web.Mvc.IExceptionFilter.OnException(System.Web.Mvc.ExceptionContext filterContext) { }
        void System.Web.Mvc.IResultFilter.OnResultExecuted(System.Web.Mvc.ResultExecutedContext filterContext) { }
        void System.Web.Mvc.IResultFilter.OnResultExecuting(System.Web.Mvc.ResultExecutingContext filterContext) { }
        protected internal bool TryUpdateModel<TModel>(TModel model) where TModel : class { throw null; }
        protected internal bool TryUpdateModel<TModel>(TModel model, string prefix) where TModel : class { throw null; }
        protected internal bool TryUpdateModel<TModel>(TModel model, string prefix, string[] includeProperties) where TModel : class { throw null; }
        protected internal bool TryUpdateModel<TModel>(TModel model, string prefix, string[] includeProperties, string[] excludeProperties) where TModel : class { throw null; }
        protected internal bool TryUpdateModel<TModel>(TModel model, string prefix, string[] includeProperties, string[] excludeProperties, System.Web.Mvc.IValueProvider valueProvider) where TModel : class { throw null; }
        protected internal bool TryUpdateModel<TModel>(TModel model, string prefix, string[] includeProperties, System.Web.Mvc.IValueProvider valueProvider) where TModel : class { throw null; }
        protected internal bool TryUpdateModel<TModel>(TModel model, string prefix, System.Web.Mvc.IValueProvider valueProvider) where TModel : class { throw null; }
        protected internal bool TryUpdateModel<TModel>(TModel model, string[] includeProperties) where TModel : class { throw null; }
        protected internal bool TryUpdateModel<TModel>(TModel model, string[] includeProperties, System.Web.Mvc.IValueProvider valueProvider) where TModel : class { throw null; }
        protected internal bool TryUpdateModel<TModel>(TModel model, System.Web.Mvc.IValueProvider valueProvider) where TModel : class { throw null; }
        protected internal bool TryValidateModel(object model) { throw null; }
        protected internal bool TryValidateModel(object model, string prefix) { throw null; }
        protected internal void UpdateModel<TModel>(TModel model) where TModel : class { }
        protected internal void UpdateModel<TModel>(TModel model, string prefix) where TModel : class { }
        protected internal void UpdateModel<TModel>(TModel model, string prefix, string[] includeProperties) where TModel : class { }
        protected internal void UpdateModel<TModel>(TModel model, string prefix, string[] includeProperties, string[] excludeProperties) where TModel : class { }
        protected internal void UpdateModel<TModel>(TModel model, string prefix, string[] includeProperties, string[] excludeProperties, System.Web.Mvc.IValueProvider valueProvider) where TModel : class { }
        protected internal void UpdateModel<TModel>(TModel model, string prefix, string[] includeProperties, System.Web.Mvc.IValueProvider valueProvider) where TModel : class { }
        protected internal void UpdateModel<TModel>(TModel model, string prefix, System.Web.Mvc.IValueProvider valueProvider) where TModel : class { }
        protected internal void UpdateModel<TModel>(TModel model, string[] includeProperties) where TModel : class { }
        protected internal void UpdateModel<TModel>(TModel model, string[] includeProperties, System.Web.Mvc.IValueProvider valueProvider) where TModel : class { }
        protected internal void UpdateModel<TModel>(TModel model, System.Web.Mvc.IValueProvider valueProvider) where TModel : class { }
        protected internal void ValidateModel(object model) { }
        protected internal void ValidateModel(object model, string prefix) { }
        protected internal System.Web.Mvc.ViewResult View() { throw null; }
        protected internal System.Web.Mvc.ViewResult View(object model) { throw null; }
        protected internal System.Web.Mvc.ViewResult View(string viewName) { throw null; }
        protected internal System.Web.Mvc.ViewResult View(string viewName, object model) { throw null; }
        protected internal System.Web.Mvc.ViewResult View(string viewName, string masterName) { throw null; }
        protected internal virtual System.Web.Mvc.ViewResult View(string viewName, string masterName, object model) { throw null; }
        protected internal System.Web.Mvc.ViewResult View(System.Web.Mvc.IView view) { throw null; }
        protected internal virtual System.Web.Mvc.ViewResult View(System.Web.Mvc.IView view, object model) { throw null; }
    }
    public partial class ControllerActionInvoker : System.Web.Mvc.IActionInvoker
    {
        public ControllerActionInvoker() { }
        protected internal System.Web.Mvc.ModelBinderDictionary Binders { get { throw null; } set { } }
        protected virtual System.Web.Mvc.ActionResult CreateActionResult(System.Web.Mvc.ControllerContext controllerContext, System.Web.Mvc.ActionDescriptor actionDescriptor, object actionReturnValue) { throw null; }
        protected virtual System.Web.Mvc.ActionDescriptor FindAction(System.Web.Mvc.ControllerContext controllerContext, System.Web.Mvc.ControllerDescriptor controllerDescriptor, string actionName) { throw null; }
        protected virtual System.Web.Mvc.ControllerDescriptor GetControllerDescriptor(System.Web.Mvc.ControllerContext controllerContext) { throw null; }
        protected virtual System.Web.Mvc.FilterInfo GetFilters(System.Web.Mvc.ControllerContext controllerContext, System.Web.Mvc.ActionDescriptor actionDescriptor) { throw null; }
        protected virtual object GetParameterValue(System.Web.Mvc.ControllerContext controllerContext, System.Web.Mvc.ParameterDescriptor parameterDescriptor) { throw null; }
        protected virtual System.Collections.Generic.IDictionary<string, object> GetParameterValues(System.Web.Mvc.ControllerContext controllerContext, System.Web.Mvc.ActionDescriptor actionDescriptor) { throw null; }
        public virtual bool InvokeAction(System.Web.Mvc.ControllerContext controllerContext, string actionName) { throw null; }
        protected virtual System.Web.Mvc.ActionResult InvokeActionMethod(System.Web.Mvc.ControllerContext controllerContext, System.Web.Mvc.ActionDescriptor actionDescriptor, System.Collections.Generic.IDictionary<string, object> parameters) { throw null; }
        protected virtual System.Web.Mvc.ActionExecutedContext InvokeActionMethodWithFilters(System.Web.Mvc.ControllerContext controllerContext, System.Collections.Generic.IList<System.Web.Mvc.IActionFilter> filters, System.Web.Mvc.ActionDescriptor actionDescriptor, System.Collections.Generic.IDictionary<string, object> parameters) { throw null; }
        protected virtual void InvokeActionResult(System.Web.Mvc.ControllerContext controllerContext, System.Web.Mvc.ActionResult actionResult) { }
        protected virtual System.Web.Mvc.ResultExecutedContext InvokeActionResultWithFilters(System.Web.Mvc.ControllerContext controllerContext, System.Collections.Generic.IList<System.Web.Mvc.IResultFilter> filters, System.Web.Mvc.ActionResult actionResult) { throw null; }
        protected virtual System.Web.Mvc.AuthorizationContext InvokeAuthorizationFilters(System.Web.Mvc.ControllerContext controllerContext, System.Collections.Generic.IList<System.Web.Mvc.IAuthorizationFilter> filters, System.Web.Mvc.ActionDescriptor actionDescriptor) { throw null; }
        protected virtual System.Web.Mvc.ExceptionContext InvokeExceptionFilters(System.Web.Mvc.ControllerContext controllerContext, System.Collections.Generic.IList<System.Web.Mvc.IExceptionFilter> filters, System.Exception exception) { throw null; }
    }
    public abstract partial class ControllerBase : System.Web.Mvc.IController
    {
        protected ControllerBase() { }
        public System.Web.Mvc.ControllerContext ControllerContext { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public System.Web.Mvc.TempDataDictionary TempData { get { throw null; } set { } }
        public bool ValidateRequest { get { throw null; } set { } }
        public System.Web.Mvc.IValueProvider ValueProvider { get { throw null; } set { } }
        public dynamic ViewBag { get { throw null; } }
        public System.Web.Mvc.ViewDataDictionary ViewData { get { throw null; } set { } }
        protected virtual void Execute(System.Web.Routing.RequestContext requestContext) { }
        protected abstract void ExecuteCore();
        protected virtual void Initialize(System.Web.Routing.RequestContext requestContext) { }
        void System.Web.Mvc.IController.Execute(System.Web.Routing.RequestContext requestContext) { }
    }
    public partial class ControllerBuilder
    {
        public ControllerBuilder() { }
        public static System.Web.Mvc.ControllerBuilder Current { get { throw null; } }
        public System.Collections.Generic.HashSet<string> DefaultNamespaces { get { throw null; } }
        public System.Web.Mvc.IControllerFactory GetControllerFactory() { throw null; }
        public void SetControllerFactory(System.Type controllerFactoryType) { }
        public void SetControllerFactory(System.Web.Mvc.IControllerFactory controllerFactory) { }
    }
    public partial class ControllerContext
    {
        public ControllerContext() { }
        public ControllerContext(System.Web.HttpContextBase httpContext, System.Web.Routing.RouteData routeData, System.Web.Mvc.ControllerBase controller) { }
        protected ControllerContext(System.Web.Mvc.ControllerContext controllerContext) { }
        public ControllerContext(System.Web.Routing.RequestContext requestContext, System.Web.Mvc.ControllerBase controller) { }
        public virtual System.Web.Mvc.ControllerBase Controller { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public virtual System.Web.HttpContextBase HttpContext { get { throw null; } set { } }
        public virtual bool IsChildAction { get { throw null; } }
        public System.Web.Mvc.ViewContext ParentActionViewContext { get { throw null; } }
        public System.Web.Routing.RequestContext RequestContext { get { throw null; } set { } }
        public virtual System.Web.Routing.RouteData RouteData { get { throw null; } set { } }
    }
    public abstract partial class ControllerDescriptor : System.Reflection.ICustomAttributeProvider
    {
        protected ControllerDescriptor() { }
        public virtual string ControllerName { get { throw null; } }
        public abstract System.Type ControllerType { get; }
        public virtual string UniqueId { get { throw null; } }
        public abstract System.Web.Mvc.ActionDescriptor FindAction(System.Web.Mvc.ControllerContext controllerContext, string actionName);
        public abstract System.Web.Mvc.ActionDescriptor[] GetCanonicalActions();
        public virtual object[] GetCustomAttributes(bool inherit) { throw null; }
        public virtual object[] GetCustomAttributes(System.Type attributeType, bool inherit) { throw null; }
        public virtual bool IsDefined(System.Type attributeType, bool inherit) { throw null; }
    }
    public partial class ControllerInstanceFilterProvider : System.Web.Mvc.IFilterProvider
    {
        public ControllerInstanceFilterProvider() { }
        public System.Collections.Generic.IEnumerable<System.Web.Mvc.Filter> GetFilters(System.Web.Mvc.ControllerContext controllerContext, System.Web.Mvc.ActionDescriptor actionDescriptor) { throw null; }
    }
    [System.AttributeUsageAttribute((System.AttributeTargets)(3100), AllowMultiple=false, Inherited=false)]
    public abstract partial class CustomModelBinderAttribute : System.Attribute
    {
        protected CustomModelBinderAttribute() { }
        public abstract System.Web.Mvc.IModelBinder GetBinder();
    }
    public partial class DataAnnotationsModelMetadata : System.Web.Mvc.ModelMetadata
    {
        public DataAnnotationsModelMetadata(System.Web.Mvc.DataAnnotationsModelMetadataProvider provider, System.Type containerType, System.Func<object> modelAccessor, System.Type modelType, string propertyName, System.ComponentModel.DataAnnotations.DisplayColumnAttribute displayColumnAttribute) : base (default(System.Web.Mvc.ModelMetadataProvider), default(System.Type), default(System.Func<object>), default(System.Type), default(string)) { }
        protected override string GetSimpleDisplayText() { throw null; }
    }
    public partial class DataAnnotationsModelMetadataProvider : System.Web.Mvc.AssociatedMetadataProvider
    {
        public DataAnnotationsModelMetadataProvider() { }
        protected override System.Web.Mvc.ModelMetadata CreateMetadata(System.Collections.Generic.IEnumerable<System.Attribute> attributes, System.Type containerType, System.Func<object> modelAccessor, System.Type modelType, string propertyName) { throw null; }
    }
    public delegate System.Web.Mvc.ModelValidator DataAnnotationsModelValidationFactory(System.Web.Mvc.ModelMetadata metadata, System.Web.Mvc.ControllerContext context, System.ComponentModel.DataAnnotations.ValidationAttribute attribute);
    public partial class DataAnnotationsModelValidator : System.Web.Mvc.ModelValidator
    {
        public DataAnnotationsModelValidator(System.Web.Mvc.ModelMetadata metadata, System.Web.Mvc.ControllerContext context, System.ComponentModel.DataAnnotations.ValidationAttribute attribute) : base (default(System.Web.Mvc.ModelMetadata), default(System.Web.Mvc.ControllerContext)) { }
        protected internal System.ComponentModel.DataAnnotations.ValidationAttribute Attribute { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        protected internal string ErrorMessage { get { throw null; } }
        public override bool IsRequired { get { throw null; } }
        public override System.Collections.Generic.IEnumerable<System.Web.Mvc.ModelClientValidationRule> GetClientValidationRules() { throw null; }
        public override System.Collections.Generic.IEnumerable<System.Web.Mvc.ModelValidationResult> Validate(object container) { throw null; }
    }
    public partial class DataAnnotationsModelValidatorProvider : System.Web.Mvc.AssociatedValidatorProvider
    {
        public DataAnnotationsModelValidatorProvider() { }
        public static bool AddImplicitRequiredAttributeForValueTypes { get { throw null; } set { } }
        protected override System.Collections.Generic.IEnumerable<System.Web.Mvc.ModelValidator> GetValidators(System.Web.Mvc.ModelMetadata metadata, System.Web.Mvc.ControllerContext context, System.Collections.Generic.IEnumerable<System.Attribute> attributes) { throw null; }
        public static void RegisterAdapter(System.Type attributeType, System.Type adapterType) { }
        public static void RegisterAdapterFactory(System.Type attributeType, System.Web.Mvc.DataAnnotationsModelValidationFactory factory) { }
        public static void RegisterDefaultAdapter(System.Type adapterType) { }
        public static void RegisterDefaultAdapterFactory(System.Web.Mvc.DataAnnotationsModelValidationFactory factory) { }
        public static void RegisterDefaultValidatableObjectAdapter(System.Type adapterType) { }
        public static void RegisterDefaultValidatableObjectAdapterFactory(System.Web.Mvc.DataAnnotationsValidatableObjectAdapterFactory factory) { }
        public static void RegisterValidatableObjectAdapter(System.Type modelType, System.Type adapterType) { }
        public static void RegisterValidatableObjectAdapterFactory(System.Type modelType, System.Web.Mvc.DataAnnotationsValidatableObjectAdapterFactory factory) { }
    }
    public partial class DataAnnotationsModelValidator<TAttribute> : System.Web.Mvc.DataAnnotationsModelValidator where TAttribute : System.ComponentModel.DataAnnotations.ValidationAttribute
    {
        public DataAnnotationsModelValidator(System.Web.Mvc.ModelMetadata metadata, System.Web.Mvc.ControllerContext context, TAttribute attribute) : base (default(System.Web.Mvc.ModelMetadata), default(System.Web.Mvc.ControllerContext), default(System.ComponentModel.DataAnnotations.ValidationAttribute)) { }
        protected new TAttribute Attribute { get { throw null; } }
    }
    public delegate System.Web.Mvc.ModelValidator DataAnnotationsValidatableObjectAdapterFactory(System.Web.Mvc.ModelMetadata metadata, System.Web.Mvc.ControllerContext context);
    public partial class DataErrorInfoModelValidatorProvider : System.Web.Mvc.ModelValidatorProvider
    {
        public DataErrorInfoModelValidatorProvider() { }
        public override System.Collections.Generic.IEnumerable<System.Web.Mvc.ModelValidator> GetValidators(System.Web.Mvc.ModelMetadata metadata, System.Web.Mvc.ControllerContext context) { throw null; }
    }
    public partial class DefaultControllerFactory : System.Web.Mvc.IControllerFactory
    {
        public DefaultControllerFactory() { }
        public DefaultControllerFactory(System.Web.Mvc.IControllerActivator controllerActivator) { }
        public virtual System.Web.Mvc.IController CreateController(System.Web.Routing.RequestContext requestContext, string controllerName) { throw null; }
        protected internal virtual System.Web.Mvc.IController GetControllerInstance(System.Web.Routing.RequestContext requestContext, System.Type controllerType) { throw null; }
        protected internal virtual System.Web.SessionState.SessionStateBehavior GetControllerSessionBehavior(System.Web.Routing.RequestContext requestContext, System.Type controllerType) { throw null; }
        protected internal virtual System.Type GetControllerType(System.Web.Routing.RequestContext requestContext, string controllerName) { throw null; }
        public virtual void ReleaseController(System.Web.Mvc.IController controller) { }
        System.Web.SessionState.SessionStateBehavior System.Web.Mvc.IControllerFactory.GetControllerSessionBehavior(System.Web.Routing.RequestContext requestContext, string controllerName) { throw null; }
    }
    public partial class DefaultModelBinder : System.Web.Mvc.IModelBinder
    {
        public DefaultModelBinder() { }
        protected internal System.Web.Mvc.ModelBinderDictionary Binders { get { throw null; } set { } }
        public static string ResourceClassKey { get { throw null; } set { } }
        public virtual object BindModel(System.Web.Mvc.ControllerContext controllerContext, System.Web.Mvc.ModelBindingContext bindingContext) { throw null; }
        protected virtual void BindProperty(System.Web.Mvc.ControllerContext controllerContext, System.Web.Mvc.ModelBindingContext bindingContext, System.ComponentModel.PropertyDescriptor propertyDescriptor) { }
        protected virtual object CreateModel(System.Web.Mvc.ControllerContext controllerContext, System.Web.Mvc.ModelBindingContext bindingContext, System.Type modelType) { throw null; }
        protected static string CreateSubIndexName(string prefix, int index) { throw null; }
        protected static string CreateSubIndexName(string prefix, string index) { throw null; }
        protected internal static string CreateSubPropertyName(string prefix, string propertyName) { throw null; }
        protected System.Collections.Generic.IEnumerable<System.ComponentModel.PropertyDescriptor> GetFilteredModelProperties(System.Web.Mvc.ControllerContext controllerContext, System.Web.Mvc.ModelBindingContext bindingContext) { throw null; }
        protected virtual System.ComponentModel.PropertyDescriptorCollection GetModelProperties(System.Web.Mvc.ControllerContext controllerContext, System.Web.Mvc.ModelBindingContext bindingContext) { throw null; }
        protected virtual object GetPropertyValue(System.Web.Mvc.ControllerContext controllerContext, System.Web.Mvc.ModelBindingContext bindingContext, System.ComponentModel.PropertyDescriptor propertyDescriptor, System.Web.Mvc.IModelBinder propertyBinder) { throw null; }
        protected virtual System.ComponentModel.ICustomTypeDescriptor GetTypeDescriptor(System.Web.Mvc.ControllerContext controllerContext, System.Web.Mvc.ModelBindingContext bindingContext) { throw null; }
        protected static bool IsModelValid(System.Web.Mvc.ModelBindingContext bindingContext) { throw null; }
        protected virtual void OnModelUpdated(System.Web.Mvc.ControllerContext controllerContext, System.Web.Mvc.ModelBindingContext bindingContext) { }
        protected virtual bool OnModelUpdating(System.Web.Mvc.ControllerContext controllerContext, System.Web.Mvc.ModelBindingContext bindingContext) { throw null; }
        protected virtual void OnPropertyValidated(System.Web.Mvc.ControllerContext controllerContext, System.Web.Mvc.ModelBindingContext bindingContext, System.ComponentModel.PropertyDescriptor propertyDescriptor, object value) { }
        protected virtual bool OnPropertyValidating(System.Web.Mvc.ControllerContext controllerContext, System.Web.Mvc.ModelBindingContext bindingContext, System.ComponentModel.PropertyDescriptor propertyDescriptor, object value) { throw null; }
        protected virtual void SetProperty(System.Web.Mvc.ControllerContext controllerContext, System.Web.Mvc.ModelBindingContext bindingContext, System.ComponentModel.PropertyDescriptor propertyDescriptor, object value) { }
    }
    public partial class DefaultViewLocationCache : System.Web.Mvc.IViewLocationCache
    {
        public static readonly System.Web.Mvc.IViewLocationCache Null;
        public DefaultViewLocationCache() { }
        public DefaultViewLocationCache(System.TimeSpan timeSpan) { }
        public System.TimeSpan TimeSpan { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        public string GetViewLocation(System.Web.HttpContextBase httpContext, string key) { throw null; }
        public void InsertViewLocation(System.Web.HttpContextBase httpContext, string key, string virtualPath) { }
    }
    public partial class DependencyResolver
    {
        public DependencyResolver() { }
        public static System.Web.Mvc.IDependencyResolver Current { get { throw null; } }
        public System.Web.Mvc.IDependencyResolver InnerCurrent { get { throw null; } }
        public void InnerSetResolver(System.Func<System.Type, object> getService, System.Func<System.Type, System.Collections.Generic.IEnumerable<object>> getServices) { }
        public void InnerSetResolver(object commonServiceLocator) { }
        public void InnerSetResolver(System.Web.Mvc.IDependencyResolver resolver) { }
        public static void SetResolver(System.Func<System.Type, object> getService, System.Func<System.Type, System.Collections.Generic.IEnumerable<object>> getServices) { }
        public static void SetResolver(object commonServiceLocator) { }
        public static void SetResolver(System.Web.Mvc.IDependencyResolver resolver) { }
    }
    public static partial class DependencyResolverExtensions
    {
        public static System.Collections.Generic.IEnumerable<TService> GetServices<TService>(this System.Web.Mvc.IDependencyResolver resolver) { throw null; }
        public static TService GetService<TService>(this System.Web.Mvc.IDependencyResolver resolver) { throw null; }
    }
    public partial class DictionaryValueProvider<TValue> : System.Web.Mvc.IValueProvider
    {
        public DictionaryValueProvider(System.Collections.Generic.IDictionary<string, TValue> dictionary, System.Globalization.CultureInfo culture) { }
        public virtual bool ContainsPrefix(string prefix) { throw null; }
        public virtual System.Web.Mvc.ValueProviderResult GetValue(string key) { throw null; }
    }
    public partial class EmptyModelMetadataProvider : System.Web.Mvc.AssociatedMetadataProvider
    {
        public EmptyModelMetadataProvider() { }
        protected override System.Web.Mvc.ModelMetadata CreateMetadata(System.Collections.Generic.IEnumerable<System.Attribute> attributes, System.Type containerType, System.Func<object> modelAccessor, System.Type modelType, string propertyName) { throw null; }
    }
    public partial class EmptyModelValidatorProvider : System.Web.Mvc.ModelValidatorProvider
    {
        public EmptyModelValidatorProvider() { }
        public override System.Collections.Generic.IEnumerable<System.Web.Mvc.ModelValidator> GetValidators(System.Web.Mvc.ModelMetadata metadata, System.Web.Mvc.ControllerContext context) { throw null; }
    }
    public partial class EmptyResult : System.Web.Mvc.ActionResult
    {
        public EmptyResult() { }
        public override void ExecuteResult(System.Web.Mvc.ControllerContext context) { }
    }
    public partial class ExceptionContext : System.Web.Mvc.ControllerContext
    {
        public ExceptionContext() { }
        public ExceptionContext(System.Web.Mvc.ControllerContext controllerContext, System.Exception exception) { }
        public virtual System.Exception Exception { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public bool ExceptionHandled { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public System.Web.Mvc.ActionResult Result { get { throw null; } set { } }
    }
    public static partial class ExpressionHelper
    {
        public static string GetExpressionText(System.Linq.Expressions.LambdaExpression expression) { throw null; }
        public static string GetExpressionText(string expression) { throw null; }
    }
    public partial class FieldValidationMetadata
    {
        public FieldValidationMetadata() { }
        public string FieldName { get { throw null; } set { } }
        public bool ReplaceValidationMessageContents { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public string ValidationMessageId { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public System.Collections.Generic.ICollection<System.Web.Mvc.ModelClientValidationRule> ValidationRules { get { throw null; } }
    }
    public partial class FileContentResult : System.Web.Mvc.FileResult
    {
        public FileContentResult(byte[] fileContents, string contentType) : base (default(string)) { }
        public byte[] FileContents { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        protected override void WriteFile(System.Web.HttpResponseBase response) { }
    }
    public partial class FilePathResult : System.Web.Mvc.FileResult
    {
        public FilePathResult(string fileName, string contentType) : base (default(string)) { }
        public string FileName { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        protected override void WriteFile(System.Web.HttpResponseBase response) { }
    }
    public abstract partial class FileResult : System.Web.Mvc.ActionResult
    {
        protected FileResult(string contentType) { }
        public string ContentType { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        public string FileDownloadName { get { throw null; } set { } }
        public override void ExecuteResult(System.Web.Mvc.ControllerContext context) { }
        protected abstract void WriteFile(System.Web.HttpResponseBase response);
    }
    public partial class FileStreamResult : System.Web.Mvc.FileResult
    {
        public FileStreamResult(System.IO.Stream fileStream, string contentType) : base (default(string)) { }
        public System.IO.Stream FileStream { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        protected override void WriteFile(System.Web.HttpResponseBase response) { }
    }
    public partial class Filter
    {
        public const int DefaultOrder = -1;
        public Filter(object instance, System.Web.Mvc.FilterScope scope, System.Nullable<int> order) { }
        public object Instance { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]protected set { } }
        public int Order { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]protected set { } }
        public System.Web.Mvc.FilterScope Scope { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]protected set { } }
    }
    [System.AttributeUsageAttribute((System.AttributeTargets)(68), Inherited=true, AllowMultiple=false)]
    public abstract partial class FilterAttribute : System.Attribute, System.Web.Mvc.IMvcFilter
    {
        protected FilterAttribute() { }
        public bool AllowMultiple { get { throw null; } }
        public int Order { get { throw null; } set { } }
    }
    public partial class FilterAttributeFilterProvider : System.Web.Mvc.IFilterProvider
    {
        public FilterAttributeFilterProvider() { }
        public FilterAttributeFilterProvider(bool cacheAttributeInstances) { }
        protected virtual System.Collections.Generic.IEnumerable<System.Web.Mvc.FilterAttribute> GetActionAttributes(System.Web.Mvc.ControllerContext controllerContext, System.Web.Mvc.ActionDescriptor actionDescriptor) { throw null; }
        protected virtual System.Collections.Generic.IEnumerable<System.Web.Mvc.FilterAttribute> GetControllerAttributes(System.Web.Mvc.ControllerContext controllerContext, System.Web.Mvc.ActionDescriptor actionDescriptor) { throw null; }
        public virtual System.Collections.Generic.IEnumerable<System.Web.Mvc.Filter> GetFilters(System.Web.Mvc.ControllerContext controllerContext, System.Web.Mvc.ActionDescriptor actionDescriptor) { throw null; }
    }
    public partial class FilterInfo
    {
        public FilterInfo() { }
        public FilterInfo(System.Collections.Generic.IEnumerable<System.Web.Mvc.Filter> filters) { }
        public System.Collections.Generic.IList<System.Web.Mvc.IActionFilter> ActionFilters { get { throw null; } }
        public System.Collections.Generic.IList<System.Web.Mvc.IAuthorizationFilter> AuthorizationFilters { get { throw null; } }
        public System.Collections.Generic.IList<System.Web.Mvc.IExceptionFilter> ExceptionFilters { get { throw null; } }
        public System.Collections.Generic.IList<System.Web.Mvc.IResultFilter> ResultFilters { get { throw null; } }
    }
    public partial class FilterProviderCollection : System.Collections.ObjectModel.Collection<System.Web.Mvc.IFilterProvider>
    {
        public FilterProviderCollection() { }
        public FilterProviderCollection(System.Collections.Generic.IList<System.Web.Mvc.IFilterProvider> providers) { }
        public System.Collections.Generic.IEnumerable<System.Web.Mvc.Filter> GetFilters(System.Web.Mvc.ControllerContext controllerContext, System.Web.Mvc.ActionDescriptor actionDescriptor) { throw null; }
    }
    public static partial class FilterProviders
    {
        public static System.Web.Mvc.FilterProviderCollection Providers { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
    }
    public enum FilterScope
    {
        Action = 30,
        Controller = 20,
        First = 0,
        Global = 10,
        Last = 100,
    }
    public sealed partial class FormCollection : System.Collections.Specialized.NameValueCollection, System.Web.Mvc.IValueProvider
    {
        public FormCollection() { }
        public FormCollection(System.Collections.Specialized.NameValueCollection collection) { }
        public System.Web.Mvc.ValueProviderResult GetValue(string name) { throw null; }
        bool System.Web.Mvc.IValueProvider.ContainsPrefix(string prefix) { throw null; }
        System.Web.Mvc.ValueProviderResult System.Web.Mvc.IValueProvider.GetValue(string key) { throw null; }
        public System.Web.Mvc.IValueProvider ToValueProvider() { throw null; }
    }
    public partial class FormContext
    {
        public FormContext() { }
        public System.Collections.Generic.IDictionary<string, System.Web.Mvc.FieldValidationMetadata> FieldValidators { get { throw null; } }
        public string FormId { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public bool ReplaceValidationSummary { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public string ValidationSummaryId { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public string GetJsonValidationMetadata() { throw null; }
        public System.Web.Mvc.FieldValidationMetadata GetValidationMetadataForField(string fieldName) { throw null; }
        public System.Web.Mvc.FieldValidationMetadata GetValidationMetadataForField(string fieldName, bool createIfNotFound) { throw null; }
        public bool RenderedField(string fieldName) { throw null; }
        public void RenderedField(string fieldName, bool value) { }
    }
    public enum FormMethod
    {
        Get = 0,
        Post = 1,
    }
    public sealed partial class FormValueProvider : System.Web.Mvc.NameValueCollectionValueProvider
    {
        public FormValueProvider(System.Web.Mvc.ControllerContext controllerContext) : base (default(System.Collections.Specialized.NameValueCollection), default(System.Globalization.CultureInfo)) { }
    }
    public sealed partial class FormValueProviderFactory : System.Web.Mvc.ValueProviderFactory
    {
        public FormValueProviderFactory() { }
        public override System.Web.Mvc.IValueProvider GetValueProvider(System.Web.Mvc.ControllerContext controllerContext) { throw null; }
    }
    public sealed partial class GlobalFilterCollection : System.Collections.Generic.IEnumerable<System.Web.Mvc.Filter>, System.Collections.IEnumerable, System.Web.Mvc.IFilterProvider
    {
        public GlobalFilterCollection() { }
        public int Count { get { throw null; } }
        public void Add(object filter) { }
        public void Add(object filter, int order) { }
        public void Clear() { }
        public bool Contains(object filter) { throw null; }
        public System.Collections.Generic.IEnumerator<System.Web.Mvc.Filter> GetEnumerator() { throw null; }
        public void Remove(object filter) { }
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { throw null; }
        System.Collections.Generic.IEnumerable<System.Web.Mvc.Filter> System.Web.Mvc.IFilterProvider.GetFilters(System.Web.Mvc.ControllerContext controllerContext, System.Web.Mvc.ActionDescriptor actionDescriptor) { throw null; }
    }
    public static partial class GlobalFilters
    {
        public static System.Web.Mvc.GlobalFilterCollection Filters { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
    }
    [System.AttributeUsageAttribute((System.AttributeTargets)(68), Inherited=true, AllowMultiple=true)]
    public partial class HandleErrorAttribute : System.Web.Mvc.FilterAttribute, System.Web.Mvc.IExceptionFilter
    {
        public HandleErrorAttribute() { }
        public System.Type ExceptionType { get { throw null; } set { } }
        public string Master { get { throw null; } set { } }
        public override object TypeId { get { throw null; } }
        public string View { get { throw null; } set { } }
        public virtual void OnException(System.Web.Mvc.ExceptionContext filterContext) { }
    }
    public partial class HandleErrorInfo
    {
        public HandleErrorInfo(System.Exception exception, string controllerName, string actionName) { }
        public string ActionName { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        public string ControllerName { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        public System.Exception Exception { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
    }
    [System.AttributeUsageAttribute((System.AttributeTargets)(132), AllowMultiple=false, Inherited=true)]
    public sealed partial class HiddenInputAttribute : System.Attribute
    {
        public HiddenInputAttribute() { }
        public bool DisplayValue { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    }
    public partial class HtmlHelper
    {
        public static readonly string ValidationInputCssClassName;
        public static readonly string ValidationInputValidCssClassName;
        public static readonly string ValidationMessageCssClassName;
        public static readonly string ValidationMessageValidCssClassName;
        public static readonly string ValidationSummaryCssClassName;
        public static readonly string ValidationSummaryValidCssClassName;
        public HtmlHelper(System.Web.Mvc.ViewContext viewContext, System.Web.Mvc.IViewDataContainer viewDataContainer) { }
        public HtmlHelper(System.Web.Mvc.ViewContext viewContext, System.Web.Mvc.IViewDataContainer viewDataContainer, System.Web.Routing.RouteCollection routeCollection) { }
        public static bool ClientValidationEnabled { get { throw null; } set { } }
        public static string IdAttributeDotReplacement { get { throw null; } set { } }
        public System.Web.Routing.RouteCollection RouteCollection { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        public static bool UnobtrusiveJavaScriptEnabled { get { throw null; } set { } }
        public System.Web.Mvc.ViewContext ViewContext { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        public System.Web.Mvc.ViewDataDictionary ViewData { get { throw null; } }
        public System.Web.Mvc.IViewDataContainer ViewDataContainer { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        public static System.Web.Routing.RouteValueDictionary AnonymousObjectToHtmlAttributes(object htmlAttributes) { throw null; }
        public System.Web.Mvc.MvcHtmlString AntiForgeryToken() { throw null; }
        public System.Web.Mvc.MvcHtmlString AntiForgeryToken(string salt) { throw null; }
        public System.Web.Mvc.MvcHtmlString AntiForgeryToken(string salt, string domain, string path) { throw null; }
        public string AttributeEncode(object value) { throw null; }
        public string AttributeEncode(string value) { throw null; }
        public void EnableClientValidation() { }
        public void EnableClientValidation(bool enabled) { }
        public void EnableUnobtrusiveJavaScript() { }
        public void EnableUnobtrusiveJavaScript(bool enabled) { }
        public string Encode(object value) { throw null; }
        public string Encode(string value) { throw null; }
        public static string GenerateIdFromName(string name) { throw null; }
        public static string GenerateIdFromName(string name, string idAttributeDotReplacement) { throw null; }
        public static string GenerateLink(System.Web.Routing.RequestContext requestContext, System.Web.Routing.RouteCollection routeCollection, string linkText, string routeName, string actionName, string controllerName, string protocol, string hostName, string fragment, System.Web.Routing.RouteValueDictionary routeValues, System.Collections.Generic.IDictionary<string, object> htmlAttributes) { throw null; }
        public static string GenerateLink(System.Web.Routing.RequestContext requestContext, System.Web.Routing.RouteCollection routeCollection, string linkText, string routeName, string actionName, string controllerName, System.Web.Routing.RouteValueDictionary routeValues, System.Collections.Generic.IDictionary<string, object> htmlAttributes) { throw null; }
        public static string GenerateRouteLink(System.Web.Routing.RequestContext requestContext, System.Web.Routing.RouteCollection routeCollection, string linkText, string routeName, string protocol, string hostName, string fragment, System.Web.Routing.RouteValueDictionary routeValues, System.Collections.Generic.IDictionary<string, object> htmlAttributes) { throw null; }
        public static string GenerateRouteLink(System.Web.Routing.RequestContext requestContext, System.Web.Routing.RouteCollection routeCollection, string linkText, string routeName, System.Web.Routing.RouteValueDictionary routeValues, System.Collections.Generic.IDictionary<string, object> htmlAttributes) { throw null; }
        public static string GetFormMethodString(System.Web.Mvc.FormMethod method) { throw null; }
        public static string GetInputTypeString(System.Web.Mvc.InputType inputType) { throw null; }
        public System.Collections.Generic.IDictionary<string, object> GetUnobtrusiveValidationAttributes(string name) { throw null; }
        public System.Collections.Generic.IDictionary<string, object> GetUnobtrusiveValidationAttributes(string name, System.Web.Mvc.ModelMetadata metadata) { throw null; }
        public System.Web.Mvc.MvcHtmlString HttpMethodOverride(string httpMethod) { throw null; }
        public System.Web.Mvc.MvcHtmlString HttpMethodOverride(System.Web.Mvc.HttpVerbs httpVerb) { throw null; }
        public System.Web.IHtmlString Raw(string value) { throw null; }
    }
    public partial class HtmlHelper<TModel> : System.Web.Mvc.HtmlHelper
    {
        public HtmlHelper(System.Web.Mvc.ViewContext viewContext, System.Web.Mvc.IViewDataContainer viewDataContainer) : base (default(System.Web.Mvc.ViewContext), default(System.Web.Mvc.IViewDataContainer)) { }
        public HtmlHelper(System.Web.Mvc.ViewContext viewContext, System.Web.Mvc.IViewDataContainer viewDataContainer, System.Web.Routing.RouteCollection routeCollection) : base (default(System.Web.Mvc.ViewContext), default(System.Web.Mvc.IViewDataContainer)) { }
        public new System.Web.Mvc.ViewDataDictionary<TModel> ViewData { get { throw null; } }
    }
    [System.AttributeUsageAttribute((System.AttributeTargets)(64), AllowMultiple=false, Inherited=true)]
    public sealed partial class HttpDeleteAttribute : System.Web.Mvc.ActionMethodSelectorAttribute
    {
        public HttpDeleteAttribute() { }
        public override bool IsValidForRequest(System.Web.Mvc.ControllerContext controllerContext, System.Reflection.MethodInfo methodInfo) { throw null; }
    }
    public sealed partial class HttpFileCollectionValueProvider : System.Web.Mvc.DictionaryValueProvider<System.Web.HttpPostedFileBase[]>
    {
        public HttpFileCollectionValueProvider(System.Web.Mvc.ControllerContext controllerContext) : base (default(System.Collections.Generic.IDictionary<string, System.Web.HttpPostedFileBase[]>), default(System.Globalization.CultureInfo)) { }
    }
    public sealed partial class HttpFileCollectionValueProviderFactory : System.Web.Mvc.ValueProviderFactory
    {
        public HttpFileCollectionValueProviderFactory() { }
        public override System.Web.Mvc.IValueProvider GetValueProvider(System.Web.Mvc.ControllerContext controllerContext) { throw null; }
    }
    [System.AttributeUsageAttribute((System.AttributeTargets)(64), AllowMultiple=false, Inherited=true)]
    public sealed partial class HttpGetAttribute : System.Web.Mvc.ActionMethodSelectorAttribute
    {
        public HttpGetAttribute() { }
        public override bool IsValidForRequest(System.Web.Mvc.ControllerContext controllerContext, System.Reflection.MethodInfo methodInfo) { throw null; }
    }
    public partial class HttpNotFoundResult : System.Web.Mvc.HttpStatusCodeResult
    {
        public HttpNotFoundResult() : base (default(int)) { }
        public HttpNotFoundResult(string statusDescription) : base (default(int)) { }
    }
    [System.AttributeUsageAttribute((System.AttributeTargets)(64), AllowMultiple=false, Inherited=true)]
    public sealed partial class HttpPostAttribute : System.Web.Mvc.ActionMethodSelectorAttribute
    {
        public HttpPostAttribute() { }
        public override bool IsValidForRequest(System.Web.Mvc.ControllerContext controllerContext, System.Reflection.MethodInfo methodInfo) { throw null; }
    }
    public partial class HttpPostedFileBaseModelBinder : System.Web.Mvc.IModelBinder
    {
        public HttpPostedFileBaseModelBinder() { }
        public object BindModel(System.Web.Mvc.ControllerContext controllerContext, System.Web.Mvc.ModelBindingContext bindingContext) { throw null; }
    }
    [System.AttributeUsageAttribute((System.AttributeTargets)(64), AllowMultiple=false, Inherited=true)]
    public sealed partial class HttpPutAttribute : System.Web.Mvc.ActionMethodSelectorAttribute
    {
        public HttpPutAttribute() { }
        public override bool IsValidForRequest(System.Web.Mvc.ControllerContext controllerContext, System.Reflection.MethodInfo methodInfo) { throw null; }
    }
    public static partial class HttpRequestExtensions
    {
        public static string GetHttpMethodOverride(this System.Web.HttpRequestBase request) { throw null; }
    }
    public partial class HttpStatusCodeResult : System.Web.Mvc.ActionResult
    {
        public HttpStatusCodeResult(int statusCode) { }
        public HttpStatusCodeResult(int statusCode, string statusDescription) { }
        public int StatusCode { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        public string StatusDescription { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        public override void ExecuteResult(System.Web.Mvc.ControllerContext context) { }
    }
    public partial class HttpUnauthorizedResult : System.Web.Mvc.HttpStatusCodeResult
    {
        public HttpUnauthorizedResult() : base (default(int)) { }
        public HttpUnauthorizedResult(string statusDescription) : base (default(int)) { }
    }
    [System.FlagsAttribute]
    public enum HttpVerbs
    {
        Delete = 8,
        Get = 1,
        Head = 16,
        Post = 2,
        Put = 4,
    }
    public partial interface IActionFilter
    {
        void OnActionExecuted(System.Web.Mvc.ActionExecutedContext filterContext);
        void OnActionExecuting(System.Web.Mvc.ActionExecutingContext filterContext);
    }
    public partial interface IActionInvoker
    {
        bool InvokeAction(System.Web.Mvc.ControllerContext controllerContext, string actionName);
    }
    public partial interface IAuthorizationFilter
    {
        void OnAuthorization(System.Web.Mvc.AuthorizationContext filterContext);
    }
    public partial interface IClientValidatable
    {
        System.Collections.Generic.IEnumerable<System.Web.Mvc.ModelClientValidationRule> GetClientValidationRules(System.Web.Mvc.ModelMetadata metadata, System.Web.Mvc.ControllerContext context);
    }
    public partial interface IController
    {
        void Execute(System.Web.Routing.RequestContext requestContext);
    }
    public partial interface IControllerActivator
    {
        System.Web.Mvc.IController Create(System.Web.Routing.RequestContext requestContext, System.Type controllerType);
    }
    public partial interface IControllerFactory
    {
        System.Web.Mvc.IController CreateController(System.Web.Routing.RequestContext requestContext, string controllerName);
        System.Web.SessionState.SessionStateBehavior GetControllerSessionBehavior(System.Web.Routing.RequestContext requestContext, string controllerName);
        void ReleaseController(System.Web.Mvc.IController controller);
    }
    public partial interface IDependencyResolver
    {
        object GetService(System.Type serviceType);
        System.Collections.Generic.IEnumerable<object> GetServices(System.Type serviceType);
    }
    public partial interface IExceptionFilter
    {
        void OnException(System.Web.Mvc.ExceptionContext filterContext);
    }
    public partial interface IFilterProvider
    {
        System.Collections.Generic.IEnumerable<System.Web.Mvc.Filter> GetFilters(System.Web.Mvc.ControllerContext controllerContext, System.Web.Mvc.ActionDescriptor actionDescriptor);
    }
    public partial interface IMetadataAware
    {
        void OnMetadataCreated(System.Web.Mvc.ModelMetadata metadata);
    }
    public partial interface IModelBinder
    {
        object BindModel(System.Web.Mvc.ControllerContext controllerContext, System.Web.Mvc.ModelBindingContext bindingContext);
    }
    public partial interface IModelBinderProvider
    {
        System.Web.Mvc.IModelBinder GetBinder(System.Type modelType);
    }
    public partial interface IMvcFilter
    {
        bool AllowMultiple { get; }
        int Order { get; }
    }
    public enum InputType
    {
        CheckBox = 0,
        Hidden = 1,
        Password = 2,
        Radio = 3,
        Text = 4,
    }
    public partial interface IResultFilter
    {
        void OnResultExecuted(System.Web.Mvc.ResultExecutedContext filterContext);
        void OnResultExecuting(System.Web.Mvc.ResultExecutingContext filterContext);
    }
    public partial interface IRouteWithArea
    {
        string Area { get; }
    }
    public partial interface ITempDataProvider
    {
        System.Collections.Generic.IDictionary<string, object> LoadTempData(System.Web.Mvc.ControllerContext controllerContext);
        void SaveTempData(System.Web.Mvc.ControllerContext controllerContext, System.Collections.Generic.IDictionary<string, object> values);
    }
    public partial interface IUnvalidatedValueProvider : System.Web.Mvc.IValueProvider
    {
        System.Web.Mvc.ValueProviderResult GetValue(string key, bool skipValidation);
    }
    public partial interface IValueProvider
    {
        bool ContainsPrefix(string prefix);
        System.Web.Mvc.ValueProviderResult GetValue(string key);
    }
    public partial interface IView
    {
        void Render(System.Web.Mvc.ViewContext viewContext, System.IO.TextWriter writer);
    }
    public partial interface IViewDataContainer
    {
        System.Web.Mvc.ViewDataDictionary ViewData { get; set; }
    }
    public partial interface IViewEngine
    {
        System.Web.Mvc.ViewEngineResult FindPartialView(System.Web.Mvc.ControllerContext controllerContext, string partialViewName, bool useCache);
        System.Web.Mvc.ViewEngineResult FindView(System.Web.Mvc.ControllerContext controllerContext, string viewName, string masterName, bool useCache);
        void ReleaseView(System.Web.Mvc.ControllerContext controllerContext, System.Web.Mvc.IView view);
    }
    public partial interface IViewLocationCache
    {
        string GetViewLocation(System.Web.HttpContextBase httpContext, string key);
        void InsertViewLocation(System.Web.HttpContextBase httpContext, string key, string virtualPath);
    }
    public partial interface IViewPageActivator
    {
        object Create(System.Web.Mvc.ControllerContext controllerContext, System.Type type);
    }
    public partial class JavaScriptResult : System.Web.Mvc.ActionResult
    {
        public JavaScriptResult() { }
        public string Script { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public override void ExecuteResult(System.Web.Mvc.ControllerContext context) { }
    }
    public enum JsonRequestBehavior
    {
        AllowGet = 0,
        DenyGet = 1,
    }
    public partial class JsonResult : System.Web.Mvc.ActionResult
    {
        public JsonResult() { }
        public System.Text.Encoding ContentEncoding { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public string ContentType { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public object Data { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public System.Web.Mvc.JsonRequestBehavior JsonRequestBehavior { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public override void ExecuteResult(System.Web.Mvc.ControllerContext context) { }
    }
    public sealed partial class JsonValueProviderFactory : System.Web.Mvc.ValueProviderFactory
    {
        public JsonValueProviderFactory() { }
        public override System.Web.Mvc.IValueProvider GetValueProvider(System.Web.Mvc.ControllerContext controllerContext) { throw null; }
    }
    public partial class LinqBinaryModelBinder : System.Web.Mvc.ByteArrayModelBinder
    {
        public LinqBinaryModelBinder() { }
        public override object BindModel(System.Web.Mvc.ControllerContext controllerContext, System.Web.Mvc.ModelBindingContext bindingContext) { throw null; }
    }
    [System.AttributeUsageAttribute((System.AttributeTargets)(3100), AllowMultiple=false, Inherited=false)]
    public sealed partial class ModelBinderAttribute : System.Web.Mvc.CustomModelBinderAttribute
    {
        public ModelBinderAttribute(System.Type binderType) { }
        public System.Type BinderType { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        public override System.Web.Mvc.IModelBinder GetBinder() { throw null; }
    }
    public partial class ModelBinderDictionary : System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.Type, System.Web.Mvc.IModelBinder>>, System.Collections.Generic.IDictionary<System.Type, System.Web.Mvc.IModelBinder>, System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<System.Type, System.Web.Mvc.IModelBinder>>, System.Collections.IEnumerable
    {
        public ModelBinderDictionary() { }
        public int Count { get { throw null; } }
        public System.Web.Mvc.IModelBinder DefaultBinder { get { throw null; } set { } }
        public bool IsReadOnly { get { throw null; } }
        public System.Web.Mvc.IModelBinder this[System.Type key] { get { throw null; } set { } }
        public System.Collections.Generic.ICollection<System.Type> Keys { get { throw null; } }
        public System.Collections.Generic.ICollection<System.Web.Mvc.IModelBinder> Values { get { throw null; } }
        public void Add(System.Collections.Generic.KeyValuePair<System.Type, System.Web.Mvc.IModelBinder> item) { }
        public void Add(System.Type key, System.Web.Mvc.IModelBinder value) { }
        public void Clear() { }
        public bool Contains(System.Collections.Generic.KeyValuePair<System.Type, System.Web.Mvc.IModelBinder> item) { throw null; }
        public bool ContainsKey(System.Type key) { throw null; }
        public void CopyTo(System.Collections.Generic.KeyValuePair<System.Type, System.Web.Mvc.IModelBinder>[] array, int arrayIndex) { }
        public System.Web.Mvc.IModelBinder GetBinder(System.Type modelType) { throw null; }
        public virtual System.Web.Mvc.IModelBinder GetBinder(System.Type modelType, bool fallbackToDefault) { throw null; }
        public System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<System.Type, System.Web.Mvc.IModelBinder>> GetEnumerator() { throw null; }
        public bool Remove(System.Collections.Generic.KeyValuePair<System.Type, System.Web.Mvc.IModelBinder> item) { throw null; }
        public bool Remove(System.Type key) { throw null; }
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { throw null; }
        public bool TryGetValue(System.Type key, out System.Web.Mvc.IModelBinder value) { value = default(System.Web.Mvc.IModelBinder); throw null; }
    }
    public partial class ModelBinderProviderCollection : System.Collections.ObjectModel.Collection<System.Web.Mvc.IModelBinderProvider>
    {
        public ModelBinderProviderCollection() { }
        public ModelBinderProviderCollection(System.Collections.Generic.IList<System.Web.Mvc.IModelBinderProvider> list) { }
        public System.Web.Mvc.IModelBinder GetBinder(System.Type modelType) { throw null; }
        protected override void InsertItem(int index, System.Web.Mvc.IModelBinderProvider item) { }
        protected override void SetItem(int index, System.Web.Mvc.IModelBinderProvider item) { }
    }
    public static partial class ModelBinderProviders
    {
        public static System.Web.Mvc.ModelBinderProviderCollection BinderProviders { get { throw null; } }
    }
    public static partial class ModelBinders
    {
        public static System.Web.Mvc.ModelBinderDictionary Binders { get { throw null; } }
    }
    public partial class ModelBindingContext
    {
        public ModelBindingContext() { }
        public ModelBindingContext(System.Web.Mvc.ModelBindingContext bindingContext) { }
        public bool FallbackToEmptyPrefix { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public object Model { get { throw null; } set { } }
        public System.Web.Mvc.ModelMetadata ModelMetadata { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public string ModelName { get { throw null; } set { } }
        public System.Web.Mvc.ModelStateDictionary ModelState { get { throw null; } set { } }
        public System.Type ModelType { get { throw null; } set { } }
        public System.Predicate<string> PropertyFilter { get { throw null; } set { } }
        public System.Collections.Generic.IDictionary<string, System.Web.Mvc.ModelMetadata> PropertyMetadata { get { throw null; } }
        public System.Web.Mvc.IValueProvider ValueProvider { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    }
    public partial class ModelClientValidationEqualToRule : System.Web.Mvc.ModelClientValidationRule
    {
        public ModelClientValidationEqualToRule(string errorMessage, object other) { }
    }
    public partial class ModelClientValidationRangeRule : System.Web.Mvc.ModelClientValidationRule
    {
        public ModelClientValidationRangeRule(string errorMessage, object minValue, object maxValue) { }
    }
    public partial class ModelClientValidationRegexRule : System.Web.Mvc.ModelClientValidationRule
    {
        public ModelClientValidationRegexRule(string errorMessage, string pattern) { }
    }
    public partial class ModelClientValidationRemoteRule : System.Web.Mvc.ModelClientValidationRule
    {
        public ModelClientValidationRemoteRule(string errorMessage, string url, string httpMethod, string additionalFields) { }
    }
    public partial class ModelClientValidationRequiredRule : System.Web.Mvc.ModelClientValidationRule
    {
        public ModelClientValidationRequiredRule(string errorMessage) { }
    }
    public partial class ModelClientValidationRule
    {
        public ModelClientValidationRule() { }
        public string ErrorMessage { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public System.Collections.Generic.IDictionary<string, object> ValidationParameters { get { throw null; } }
        public string ValidationType { get { throw null; } set { } }
    }
    public partial class ModelClientValidationStringLengthRule : System.Web.Mvc.ModelClientValidationRule
    {
        public ModelClientValidationStringLengthRule(string errorMessage, int minimumLength, int maximumLength) { }
    }
    [System.SerializableAttribute]
    public partial class ModelError
    {
        public ModelError(System.Exception exception) { }
        public ModelError(System.Exception exception, string errorMessage) { }
        public ModelError(string errorMessage) { }
        public string ErrorMessage { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        public System.Exception Exception { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
    }
    [System.SerializableAttribute]
    public partial class ModelErrorCollection : System.Collections.ObjectModel.Collection<System.Web.Mvc.ModelError>
    {
        public ModelErrorCollection() { }
        public void Add(System.Exception exception) { }
        public void Add(string errorMessage) { }
    }
    public partial class ModelMetadata
    {
        public const int DefaultOrder = 10000;
        public ModelMetadata(System.Web.Mvc.ModelMetadataProvider provider, System.Type containerType, System.Func<object> modelAccessor, System.Type modelType, string propertyName) { }
        public virtual System.Collections.Generic.Dictionary<string, object> AdditionalValues { get { throw null; } }
        public System.Type ContainerType { get { throw null; } }
        public virtual bool ConvertEmptyStringToNull { get { throw null; } set { } }
        public virtual string DataTypeName { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public virtual string Description { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public virtual string DisplayFormatString { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public virtual string DisplayName { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public virtual string EditFormatString { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public virtual bool HideSurroundingHtml { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public virtual bool IsComplexType { get { throw null; } }
        public bool IsNullableValueType { get { throw null; } }
        public virtual bool IsReadOnly { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public virtual bool IsRequired { get { throw null; } set { } }
        public object Model { get { throw null; } set { } }
        public System.Type ModelType { get { throw null; } }
        public virtual string NullDisplayText { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public virtual int Order { get { throw null; } set { } }
        public virtual System.Collections.Generic.IEnumerable<System.Web.Mvc.ModelMetadata> Properties { get { throw null; } }
        public string PropertyName { get { throw null; } }
        protected System.Web.Mvc.ModelMetadataProvider Provider { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public virtual bool RequestValidationEnabled { get { throw null; } set { } }
        public virtual string ShortDisplayName { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public virtual bool ShowForDisplay { get { throw null; } set { } }
        public virtual bool ShowForEdit { get { throw null; } set { } }
        public virtual string SimpleDisplayText { get { throw null; } set { } }
        public virtual string TemplateHint { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public virtual string Watermark { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public static System.Web.Mvc.ModelMetadata FromLambdaExpression<TParameter, TValue>(System.Linq.Expressions.Expression<System.Func<TParameter, TValue>> expression, System.Web.Mvc.ViewDataDictionary<TParameter> viewData) { throw null; }
        public static System.Web.Mvc.ModelMetadata FromStringExpression(string expression, System.Web.Mvc.ViewDataDictionary viewData) { throw null; }
        public string GetDisplayName() { throw null; }
        protected virtual string GetSimpleDisplayText() { throw null; }
        public virtual System.Collections.Generic.IEnumerable<System.Web.Mvc.ModelValidator> GetValidators(System.Web.Mvc.ControllerContext context) { throw null; }
    }
    public abstract partial class ModelMetadataProvider
    {
        protected ModelMetadataProvider() { }
        public abstract System.Collections.Generic.IEnumerable<System.Web.Mvc.ModelMetadata> GetMetadataForProperties(object container, System.Type containerType);
        public abstract System.Web.Mvc.ModelMetadata GetMetadataForProperty(System.Func<object> modelAccessor, System.Type containerType, string propertyName);
        public abstract System.Web.Mvc.ModelMetadata GetMetadataForType(System.Func<object> modelAccessor, System.Type modelType);
    }
    public partial class ModelMetadataProviders
    {
        internal ModelMetadataProviders() { }
        public static System.Web.Mvc.ModelMetadataProvider Current { get { throw null; } set { } }
    }
    [System.SerializableAttribute]
    public partial class ModelState
    {
        public ModelState() { }
        public System.Web.Mvc.ModelErrorCollection Errors { get { throw null; } }
        public System.Web.Mvc.ValueProviderResult Value { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    }
    [System.SerializableAttribute]
    public partial class ModelStateDictionary : System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<string, System.Web.Mvc.ModelState>>, System.Collections.Generic.IDictionary<string, System.Web.Mvc.ModelState>, System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<string, System.Web.Mvc.ModelState>>, System.Collections.IEnumerable
    {
        public ModelStateDictionary() { }
        public ModelStateDictionary(System.Web.Mvc.ModelStateDictionary dictionary) { }
        public int Count { get { throw null; } }
        public bool IsReadOnly { get { throw null; } }
        public bool IsValid { get { throw null; } }
        public System.Web.Mvc.ModelState this[string key] { get { throw null; } set { } }
        public System.Collections.Generic.ICollection<string> Keys { get { throw null; } }
        public System.Collections.Generic.ICollection<System.Web.Mvc.ModelState> Values { get { throw null; } }
        public void Add(System.Collections.Generic.KeyValuePair<string, System.Web.Mvc.ModelState> item) { }
        public void Add(string key, System.Web.Mvc.ModelState value) { }
        public void AddModelError(string key, System.Exception exception) { }
        public void AddModelError(string key, string errorMessage) { }
        public void Clear() { }
        public bool Contains(System.Collections.Generic.KeyValuePair<string, System.Web.Mvc.ModelState> item) { throw null; }
        public bool ContainsKey(string key) { throw null; }
        public void CopyTo(System.Collections.Generic.KeyValuePair<string, System.Web.Mvc.ModelState>[] array, int arrayIndex) { }
        public System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<string, System.Web.Mvc.ModelState>> GetEnumerator() { throw null; }
        public bool IsValidField(string key) { throw null; }
        public void Merge(System.Web.Mvc.ModelStateDictionary dictionary) { }
        public bool Remove(System.Collections.Generic.KeyValuePair<string, System.Web.Mvc.ModelState> item) { throw null; }
        public bool Remove(string key) { throw null; }
        public void SetModelValue(string key, System.Web.Mvc.ValueProviderResult value) { }
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { throw null; }
        public bool TryGetValue(string key, out System.Web.Mvc.ModelState value) { value = default(System.Web.Mvc.ModelState); throw null; }
    }
    public partial class ModelValidationResult
    {
        public ModelValidationResult() { }
        public string MemberName { get { throw null; } set { } }
        public string Message { get { throw null; } set { } }
    }
    public abstract partial class ModelValidator
    {
        protected ModelValidator(System.Web.Mvc.ModelMetadata metadata, System.Web.Mvc.ControllerContext controllerContext) { }
        protected internal System.Web.Mvc.ControllerContext ControllerContext { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        public virtual bool IsRequired { get { throw null; } }
        protected internal System.Web.Mvc.ModelMetadata Metadata { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        public virtual System.Collections.Generic.IEnumerable<System.Web.Mvc.ModelClientValidationRule> GetClientValidationRules() { throw null; }
        public static System.Web.Mvc.ModelValidator GetModelValidator(System.Web.Mvc.ModelMetadata metadata, System.Web.Mvc.ControllerContext context) { throw null; }
        public abstract System.Collections.Generic.IEnumerable<System.Web.Mvc.ModelValidationResult> Validate(object container);
    }
    public abstract partial class ModelValidatorProvider
    {
        protected ModelValidatorProvider() { }
        public abstract System.Collections.Generic.IEnumerable<System.Web.Mvc.ModelValidator> GetValidators(System.Web.Mvc.ModelMetadata metadata, System.Web.Mvc.ControllerContext context);
    }
    public partial class ModelValidatorProviderCollection : System.Collections.ObjectModel.Collection<System.Web.Mvc.ModelValidatorProvider>
    {
        public ModelValidatorProviderCollection() { }
        public ModelValidatorProviderCollection(System.Collections.Generic.IList<System.Web.Mvc.ModelValidatorProvider> list) { }
        public System.Collections.Generic.IEnumerable<System.Web.Mvc.ModelValidator> GetValidators(System.Web.Mvc.ModelMetadata metadata, System.Web.Mvc.ControllerContext context) { throw null; }
        protected override void InsertItem(int index, System.Web.Mvc.ModelValidatorProvider item) { }
        protected override void SetItem(int index, System.Web.Mvc.ModelValidatorProvider item) { }
    }
    public static partial class ModelValidatorProviders
    {
        public static System.Web.Mvc.ModelValidatorProviderCollection Providers { get { throw null; } }
    }
    public partial class MultiSelectList : System.Collections.Generic.IEnumerable<System.Web.Mvc.SelectListItem>, System.Collections.IEnumerable
    {
        public MultiSelectList(System.Collections.IEnumerable items) { }
        public MultiSelectList(System.Collections.IEnumerable items, System.Collections.IEnumerable selectedValues) { }
        public MultiSelectList(System.Collections.IEnumerable items, string dataValueField, string dataTextField) { }
        public MultiSelectList(System.Collections.IEnumerable items, string dataValueField, string dataTextField, System.Collections.IEnumerable selectedValues) { }
        public string DataTextField { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        public string DataValueField { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        public System.Collections.IEnumerable Items { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        public System.Collections.IEnumerable SelectedValues { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        public virtual System.Collections.Generic.IEnumerator<System.Web.Mvc.SelectListItem> GetEnumerator() { throw null; }
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { throw null; }
    }
    public abstract partial class MvcFilter : System.Web.Mvc.IMvcFilter
    {
        protected MvcFilter() { }
        protected MvcFilter(bool allowMultiple, int order) { }
        public bool AllowMultiple { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        public int Order { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
    }
    public partial class MvcHandler : System.Web.IHttpAsyncHandler, System.Web.IHttpHandler, System.Web.SessionState.IRequiresSessionState
    {
        public static readonly string MvcVersionHeaderName;
        public MvcHandler(System.Web.Routing.RequestContext requestContext) { }
        public static bool DisableMvcResponseHeader { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        protected virtual bool IsReusable { get { throw null; } }
        public System.Web.Routing.RequestContext RequestContext { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        bool System.Web.IHttpHandler.IsReusable { get { throw null; } }
        protected internal virtual void AddVersionHeader(System.Web.HttpContextBase httpContext) { }
        protected virtual System.IAsyncResult BeginProcessRequest(System.Web.HttpContext httpContext, System.AsyncCallback callback, object state) { throw null; }
        protected internal virtual System.IAsyncResult BeginProcessRequest(System.Web.HttpContextBase httpContext, System.AsyncCallback callback, object state) { throw null; }
        protected internal virtual void EndProcessRequest(System.IAsyncResult asyncResult) { }
        protected virtual void ProcessRequest(System.Web.HttpContext httpContext) { }
        protected internal virtual void ProcessRequest(System.Web.HttpContextBase httpContext) { }
        System.IAsyncResult System.Web.IHttpAsyncHandler.BeginProcessRequest(System.Web.HttpContext context, System.AsyncCallback cb, object extraData) { throw null; }
        void System.Web.IHttpAsyncHandler.EndProcessRequest(System.IAsyncResult result) { }
        void System.Web.IHttpHandler.ProcessRequest(System.Web.HttpContext httpContext) { }
    }
    public sealed partial class MvcHtmlString : System.Web.HtmlString
    {
        public static readonly System.Web.Mvc.MvcHtmlString Empty;
        public MvcHtmlString(string value) : base (default(string)) { }
        public static System.Web.Mvc.MvcHtmlString Create(string value) { throw null; }
        public static bool IsNullOrEmpty(System.Web.Mvc.MvcHtmlString value) { throw null; }
    }
    public partial class MvcHttpHandler : System.Web.Routing.UrlRoutingHandler, System.Web.IHttpAsyncHandler, System.Web.IHttpHandler, System.Web.SessionState.IRequiresSessionState
    {
        public MvcHttpHandler() { }
        protected virtual System.IAsyncResult BeginProcessRequest(System.Web.HttpContext httpContext, System.AsyncCallback callback, object state) { throw null; }
        protected internal virtual System.IAsyncResult BeginProcessRequest(System.Web.HttpContextBase httpContext, System.AsyncCallback callback, object state) { throw null; }
        protected internal virtual void EndProcessRequest(System.IAsyncResult asyncResult) { }
        System.IAsyncResult System.Web.IHttpAsyncHandler.BeginProcessRequest(System.Web.HttpContext context, System.AsyncCallback cb, object extraData) { throw null; }
        void System.Web.IHttpAsyncHandler.EndProcessRequest(System.IAsyncResult result) { }
        protected override void VerifyAndProcessRequest(System.Web.IHttpHandler httpHandler, System.Web.HttpContextBase httpContext) { }
    }
    public partial class MvcRouteHandler : System.Web.Routing.IRouteHandler
    {
        public MvcRouteHandler() { }
        public MvcRouteHandler(System.Web.Mvc.IControllerFactory controllerFactory) { }
        protected virtual System.Web.IHttpHandler GetHttpHandler(System.Web.Routing.RequestContext requestContext) { throw null; }
        protected virtual System.Web.SessionState.SessionStateBehavior GetSessionStateBehavior(System.Web.Routing.RequestContext requestContext) { throw null; }
        System.Web.IHttpHandler System.Web.Routing.IRouteHandler.GetHttpHandler(System.Web.Routing.RequestContext requestContext) { throw null; }
    }
    public partial class MvcWebRazorHostFactory : System.Web.WebPages.Razor.WebRazorHostFactory
    {
        public MvcWebRazorHostFactory() { }
        public override System.Web.WebPages.Razor.WebPageRazorHost CreateHost(string virtualPath, string physicalPath) { throw null; }
    }
    public static partial class NameValueCollectionExtensions
    {
        public static void CopyTo(this System.Collections.Specialized.NameValueCollection collection, System.Collections.Generic.IDictionary<string, object> destination) { }
        public static void CopyTo(this System.Collections.Specialized.NameValueCollection collection, System.Collections.Generic.IDictionary<string, object> destination, bool replaceEntries) { }
    }
    public partial class NameValueCollectionValueProvider : System.Web.Mvc.IUnvalidatedValueProvider, System.Web.Mvc.IValueProvider
    {
        public NameValueCollectionValueProvider(System.Collections.Specialized.NameValueCollection collection, System.Collections.Specialized.NameValueCollection unvalidatedCollection, System.Globalization.CultureInfo culture) { }
        public NameValueCollectionValueProvider(System.Collections.Specialized.NameValueCollection collection, System.Globalization.CultureInfo culture) { }
        public virtual bool ContainsPrefix(string prefix) { throw null; }
        public virtual System.Web.Mvc.ValueProviderResult GetValue(string key) { throw null; }
        public virtual System.Web.Mvc.ValueProviderResult GetValue(string key, bool skipValidation) { throw null; }
    }
    [System.AttributeUsageAttribute((System.AttributeTargets)(68), Inherited=true, AllowMultiple=false)]
    public sealed partial class NoAsyncTimeoutAttribute : System.Web.Mvc.AsyncTimeoutAttribute
    {
        public NoAsyncTimeoutAttribute() : base (default(int)) { }
    }
    [System.AttributeUsageAttribute((System.AttributeTargets)(64), AllowMultiple=false, Inherited=true)]
    public sealed partial class NonActionAttribute : System.Web.Mvc.ActionMethodSelectorAttribute
    {
        public NonActionAttribute() { }
        public override bool IsValidForRequest(System.Web.Mvc.ControllerContext controllerContext, System.Reflection.MethodInfo methodInfo) { throw null; }
    }
    [System.AttributeUsageAttribute((System.AttributeTargets)(68), Inherited=true, AllowMultiple=false)]
    public partial class OutputCacheAttribute : System.Web.Mvc.ActionFilterAttribute, System.Web.Mvc.IExceptionFilter
    {
        public OutputCacheAttribute() { }
        public string CacheProfile { get { throw null; } set { } }
        public static System.Runtime.Caching.ObjectCache ChildActionCache { get { throw null; } set { } }
        public int Duration { get { throw null; } set { } }
        public System.Web.UI.OutputCacheLocation Location { get { throw null; } set { } }
        public bool NoStore { get { throw null; } set { } }
        public string SqlDependency { get { throw null; } set { } }
        public string VaryByContentEncoding { get { throw null; } set { } }
        public string VaryByCustom { get { throw null; } set { } }
        public string VaryByHeader { get { throw null; } set { } }
        public string VaryByParam { get { throw null; } set { } }
        public static bool IsChildActionCacheActive(System.Web.Mvc.ControllerContext controllerContext) { throw null; }
        public override void OnActionExecuted(System.Web.Mvc.ActionExecutedContext filterContext) { }
        public override void OnActionExecuting(System.Web.Mvc.ActionExecutingContext filterContext) { }
        public void OnException(System.Web.Mvc.ExceptionContext filterContext) { }
        public override void OnResultExecuted(System.Web.Mvc.ResultExecutedContext filterContext) { }
        public override void OnResultExecuting(System.Web.Mvc.ResultExecutingContext filterContext) { }
    }
    public abstract partial class ParameterBindingInfo
    {
        protected ParameterBindingInfo() { }
        public virtual System.Web.Mvc.IModelBinder Binder { get { throw null; } }
        public virtual System.Collections.Generic.ICollection<string> Exclude { get { throw null; } }
        public virtual System.Collections.Generic.ICollection<string> Include { get { throw null; } }
        public virtual string Prefix { get { throw null; } }
    }
    public abstract partial class ParameterDescriptor : System.Reflection.ICustomAttributeProvider
    {
        protected ParameterDescriptor() { }
        public abstract System.Web.Mvc.ActionDescriptor ActionDescriptor { get; }
        public virtual System.Web.Mvc.ParameterBindingInfo BindingInfo { get { throw null; } }
        public virtual object DefaultValue { get { throw null; } }
        public abstract string ParameterName { get; }
        public abstract System.Type ParameterType { get; }
        public virtual object[] GetCustomAttributes(bool inherit) { throw null; }
        public virtual object[] GetCustomAttributes(System.Type attributeType, bool inherit) { throw null; }
        public virtual bool IsDefined(System.Type attributeType, bool inherit) { throw null; }
    }
    public partial class PartialViewResult : System.Web.Mvc.ViewResultBase
    {
        public PartialViewResult() { }
        protected override System.Web.Mvc.ViewEngineResult FindView(System.Web.Mvc.ControllerContext context) { throw null; }
    }
    [System.ComponentModel.EditorBrowsableAttribute((System.ComponentModel.EditorBrowsableState)(1))]
    public static partial class PreApplicationStartCode
    {
        public static void Start() { }
    }
    public sealed partial class QueryStringValueProvider : System.Web.Mvc.NameValueCollectionValueProvider
    {
        public QueryStringValueProvider(System.Web.Mvc.ControllerContext controllerContext) : base (default(System.Collections.Specialized.NameValueCollection), default(System.Globalization.CultureInfo)) { }
    }
    public sealed partial class QueryStringValueProviderFactory : System.Web.Mvc.ValueProviderFactory
    {
        public QueryStringValueProviderFactory() { }
        public override System.Web.Mvc.IValueProvider GetValueProvider(System.Web.Mvc.ControllerContext controllerContext) { throw null; }
    }
    public partial class RangeAttributeAdapter : System.Web.Mvc.DataAnnotationsModelValidator<System.ComponentModel.DataAnnotations.RangeAttribute>
    {
        public RangeAttributeAdapter(System.Web.Mvc.ModelMetadata metadata, System.Web.Mvc.ControllerContext context, System.ComponentModel.DataAnnotations.RangeAttribute attribute) : base (default(System.Web.Mvc.ModelMetadata), default(System.Web.Mvc.ControllerContext), default(System.ComponentModel.DataAnnotations.RangeAttribute)) { }
        public override System.Collections.Generic.IEnumerable<System.Web.Mvc.ModelClientValidationRule> GetClientValidationRules() { throw null; }
    }
    public partial class RazorView : System.Web.Mvc.BuildManagerCompiledView
    {
        public RazorView(System.Web.Mvc.ControllerContext controllerContext, string viewPath, string layoutPath, bool runViewStartPages, System.Collections.Generic.IEnumerable<string> viewStartFileExtensions) : base (default(System.Web.Mvc.ControllerContext), default(string)) { }
        public RazorView(System.Web.Mvc.ControllerContext controllerContext, string viewPath, string layoutPath, bool runViewStartPages, System.Collections.Generic.IEnumerable<string> viewStartFileExtensions, System.Web.Mvc.IViewPageActivator viewPageActivator) : base (default(System.Web.Mvc.ControllerContext), default(string)) { }
        public string LayoutPath { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        public bool RunViewStartPages { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        public System.Collections.Generic.IEnumerable<string> ViewStartFileExtensions { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        protected override void RenderView(System.Web.Mvc.ViewContext viewContext, System.IO.TextWriter writer, object instance) { }
    }
    public partial class RazorViewEngine : System.Web.Mvc.BuildManagerViewEngine
    {
        public RazorViewEngine() { }
        public RazorViewEngine(System.Web.Mvc.IViewPageActivator viewPageActivator) { }
        protected override System.Web.Mvc.IView CreatePartialView(System.Web.Mvc.ControllerContext controllerContext, string partialPath) { throw null; }
        protected override System.Web.Mvc.IView CreateView(System.Web.Mvc.ControllerContext controllerContext, string viewPath, string masterPath) { throw null; }
    }
    public partial class RedirectResult : System.Web.Mvc.ActionResult
    {
        public RedirectResult(string url) { }
        public RedirectResult(string url, bool permanent) { }
        public bool Permanent { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        public string Url { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        public override void ExecuteResult(System.Web.Mvc.ControllerContext context) { }
    }
    public partial class RedirectToRouteResult : System.Web.Mvc.ActionResult
    {
        public RedirectToRouteResult(string routeName, System.Web.Routing.RouteValueDictionary routeValues) { }
        public RedirectToRouteResult(string routeName, System.Web.Routing.RouteValueDictionary routeValues, bool permanent) { }
        public RedirectToRouteResult(System.Web.Routing.RouteValueDictionary routeValues) { }
        public bool Permanent { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        public string RouteName { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        public System.Web.Routing.RouteValueDictionary RouteValues { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        public override void ExecuteResult(System.Web.Mvc.ControllerContext context) { }
    }
    public partial class ReflectedActionDescriptor : System.Web.Mvc.ActionDescriptor
    {
        public ReflectedActionDescriptor(System.Reflection.MethodInfo methodInfo, string actionName, System.Web.Mvc.ControllerDescriptor controllerDescriptor) { }
        public override string ActionName { get { throw null; } }
        public override System.Web.Mvc.ControllerDescriptor ControllerDescriptor { get { throw null; } }
        public System.Reflection.MethodInfo MethodInfo { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        public override string UniqueId { get { throw null; } }
        public override object Execute(System.Web.Mvc.ControllerContext controllerContext, System.Collections.Generic.IDictionary<string, object> parameters) { throw null; }
        public override object[] GetCustomAttributes(bool inherit) { throw null; }
        public override object[] GetCustomAttributes(System.Type attributeType, bool inherit) { throw null; }
        public override System.Web.Mvc.ParameterDescriptor[] GetParameters() { throw null; }
        public override System.Collections.Generic.ICollection<System.Web.Mvc.ActionSelector> GetSelectors() { throw null; }
        public override bool IsDefined(System.Type attributeType, bool inherit) { throw null; }
    }
    public partial class ReflectedControllerDescriptor : System.Web.Mvc.ControllerDescriptor
    {
        public ReflectedControllerDescriptor(System.Type controllerType) { }
        public sealed override System.Type ControllerType { get { throw null; } }
        public override System.Web.Mvc.ActionDescriptor FindAction(System.Web.Mvc.ControllerContext controllerContext, string actionName) { throw null; }
        public override System.Web.Mvc.ActionDescriptor[] GetCanonicalActions() { throw null; }
        public override object[] GetCustomAttributes(bool inherit) { throw null; }
        public override object[] GetCustomAttributes(System.Type attributeType, bool inherit) { throw null; }
        public override bool IsDefined(System.Type attributeType, bool inherit) { throw null; }
    }
    public partial class ReflectedParameterDescriptor : System.Web.Mvc.ParameterDescriptor
    {
        public ReflectedParameterDescriptor(System.Reflection.ParameterInfo parameterInfo, System.Web.Mvc.ActionDescriptor actionDescriptor) { }
        public override System.Web.Mvc.ActionDescriptor ActionDescriptor { get { throw null; } }
        public override System.Web.Mvc.ParameterBindingInfo BindingInfo { get { throw null; } }
        public override object DefaultValue { get { throw null; } }
        public System.Reflection.ParameterInfo ParameterInfo { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        public override string ParameterName { get { throw null; } }
        public override System.Type ParameterType { get { throw null; } }
        public override object[] GetCustomAttributes(bool inherit) { throw null; }
        public override object[] GetCustomAttributes(System.Type attributeType, bool inherit) { throw null; }
        public override bool IsDefined(System.Type attributeType, bool inherit) { throw null; }
    }
    public partial class RegularExpressionAttributeAdapter : System.Web.Mvc.DataAnnotationsModelValidator<System.ComponentModel.DataAnnotations.RegularExpressionAttribute>
    {
        public RegularExpressionAttributeAdapter(System.Web.Mvc.ModelMetadata metadata, System.Web.Mvc.ControllerContext context, System.ComponentModel.DataAnnotations.RegularExpressionAttribute attribute) : base (default(System.Web.Mvc.ModelMetadata), default(System.Web.Mvc.ControllerContext), default(System.ComponentModel.DataAnnotations.RegularExpressionAttribute)) { }
        public override System.Collections.Generic.IEnumerable<System.Web.Mvc.ModelClientValidationRule> GetClientValidationRules() { throw null; }
    }
    [System.AttributeUsageAttribute((System.AttributeTargets)(128))]
    public partial class RemoteAttribute : System.ComponentModel.DataAnnotations.ValidationAttribute, System.Web.Mvc.IClientValidatable
    {
        protected RemoteAttribute() { }
        public RemoteAttribute(string routeName) { }
        public RemoteAttribute(string action, string controller) { }
        public RemoteAttribute(string action, string controller, string areaName) { }
        public string AdditionalFields { get { throw null; } set { } }
        public string HttpMethod { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        protected System.Web.Routing.RouteValueDictionary RouteData { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        protected string RouteName { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        protected virtual System.Web.Routing.RouteCollection Routes { get { throw null; } }
        public string FormatAdditionalFieldsForClientValidation(string property) { throw null; }
        public override string FormatErrorMessage(string name) { throw null; }
        public static string FormatPropertyForClientValidation(string property) { throw null; }
        public System.Collections.Generic.IEnumerable<System.Web.Mvc.ModelClientValidationRule> GetClientValidationRules(System.Web.Mvc.ModelMetadata metadata, System.Web.Mvc.ControllerContext context) { throw null; }
        protected virtual string GetUrl(System.Web.Mvc.ControllerContext controllerContext) { throw null; }
        public override bool IsValid(object value) { throw null; }
    }
    public partial class RequiredAttributeAdapter : System.Web.Mvc.DataAnnotationsModelValidator<System.ComponentModel.DataAnnotations.RequiredAttribute>
    {
        public RequiredAttributeAdapter(System.Web.Mvc.ModelMetadata metadata, System.Web.Mvc.ControllerContext context, System.ComponentModel.DataAnnotations.RequiredAttribute attribute) : base (default(System.Web.Mvc.ModelMetadata), default(System.Web.Mvc.ControllerContext), default(System.ComponentModel.DataAnnotations.RequiredAttribute)) { }
        public override System.Collections.Generic.IEnumerable<System.Web.Mvc.ModelClientValidationRule> GetClientValidationRules() { throw null; }
    }
    [System.AttributeUsageAttribute((System.AttributeTargets)(68), Inherited=true, AllowMultiple=false)]
    public partial class RequireHttpsAttribute : System.Web.Mvc.FilterAttribute, System.Web.Mvc.IAuthorizationFilter
    {
        public RequireHttpsAttribute() { }
        protected virtual void HandleNonHttpsRequest(System.Web.Mvc.AuthorizationContext filterContext) { }
        public virtual void OnAuthorization(System.Web.Mvc.AuthorizationContext filterContext) { }
    }
    public partial class ResultExecutedContext : System.Web.Mvc.ControllerContext
    {
        public ResultExecutedContext() { }
        public ResultExecutedContext(System.Web.Mvc.ControllerContext controllerContext, System.Web.Mvc.ActionResult result, bool canceled, System.Exception exception) { }
        public virtual bool Canceled { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public virtual System.Exception Exception { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public bool ExceptionHandled { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public virtual System.Web.Mvc.ActionResult Result { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    }
    public partial class ResultExecutingContext : System.Web.Mvc.ControllerContext
    {
        public ResultExecutingContext() { }
        public ResultExecutingContext(System.Web.Mvc.ControllerContext controllerContext, System.Web.Mvc.ActionResult result) { }
        public bool Cancel { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public virtual System.Web.Mvc.ActionResult Result { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    }
    public static partial class RouteCollectionExtensions
    {
        public static System.Web.Routing.VirtualPathData GetVirtualPathForArea(this System.Web.Routing.RouteCollection routes, System.Web.Routing.RequestContext requestContext, string name, System.Web.Routing.RouteValueDictionary values) { throw null; }
        public static System.Web.Routing.VirtualPathData GetVirtualPathForArea(this System.Web.Routing.RouteCollection routes, System.Web.Routing.RequestContext requestContext, System.Web.Routing.RouteValueDictionary values) { throw null; }
        public static void IgnoreRoute(this System.Web.Routing.RouteCollection routes, string url) { }
        public static void IgnoreRoute(this System.Web.Routing.RouteCollection routes, string url, object constraints) { }
        public static System.Web.Routing.Route MapRoute(this System.Web.Routing.RouteCollection routes, string name, string url) { throw null; }
        public static System.Web.Routing.Route MapRoute(this System.Web.Routing.RouteCollection routes, string name, string url, object defaults) { throw null; }
        public static System.Web.Routing.Route MapRoute(this System.Web.Routing.RouteCollection routes, string name, string url, object defaults, object constraints) { throw null; }
        public static System.Web.Routing.Route MapRoute(this System.Web.Routing.RouteCollection routes, string name, string url, object defaults, object constraints, string[] namespaces) { throw null; }
        public static System.Web.Routing.Route MapRoute(this System.Web.Routing.RouteCollection routes, string name, string url, object defaults, string[] namespaces) { throw null; }
        public static System.Web.Routing.Route MapRoute(this System.Web.Routing.RouteCollection routes, string name, string url, string[] namespaces) { throw null; }
    }
    public sealed partial class RouteDataValueProvider : System.Web.Mvc.DictionaryValueProvider<object>
    {
        public RouteDataValueProvider(System.Web.Mvc.ControllerContext controllerContext) : base (default(System.Collections.Generic.IDictionary<string, object>), default(System.Globalization.CultureInfo)) { }
    }
    public sealed partial class RouteDataValueProviderFactory : System.Web.Mvc.ValueProviderFactory
    {
        public RouteDataValueProviderFactory() { }
        public override System.Web.Mvc.IValueProvider GetValueProvider(System.Web.Mvc.ControllerContext controllerContext) { throw null; }
    }
    public partial class SelectList : System.Web.Mvc.MultiSelectList
    {
        public SelectList(System.Collections.IEnumerable items) : base (default(System.Collections.IEnumerable)) { }
        public SelectList(System.Collections.IEnumerable items, object selectedValue) : base (default(System.Collections.IEnumerable)) { }
        public SelectList(System.Collections.IEnumerable items, string dataValueField, string dataTextField) : base (default(System.Collections.IEnumerable)) { }
        public SelectList(System.Collections.IEnumerable items, string dataValueField, string dataTextField, object selectedValue) : base (default(System.Collections.IEnumerable)) { }
        public object SelectedValue { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
    }
    public partial class SelectListItem
    {
        public SelectListItem() { }
        public bool Selected { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public string Text { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public string Value { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    }
    [System.AttributeUsageAttribute((System.AttributeTargets)(4), AllowMultiple=false, Inherited=true)]
    public sealed partial class SessionStateAttribute : System.Attribute
    {
        public SessionStateAttribute(System.Web.SessionState.SessionStateBehavior behavior) { }
        public System.Web.SessionState.SessionStateBehavior Behavior { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
    }
    public partial class SessionStateTempDataProvider : System.Web.Mvc.ITempDataProvider
    {
        public SessionStateTempDataProvider() { }
        public virtual System.Collections.Generic.IDictionary<string, object> LoadTempData(System.Web.Mvc.ControllerContext controllerContext) { throw null; }
        public virtual void SaveTempData(System.Web.Mvc.ControllerContext controllerContext, System.Collections.Generic.IDictionary<string, object> values) { }
    }
    public partial class StringLengthAttributeAdapter : System.Web.Mvc.DataAnnotationsModelValidator<System.ComponentModel.DataAnnotations.StringLengthAttribute>
    {
        public StringLengthAttributeAdapter(System.Web.Mvc.ModelMetadata metadata, System.Web.Mvc.ControllerContext context, System.ComponentModel.DataAnnotations.StringLengthAttribute attribute) : base (default(System.Web.Mvc.ModelMetadata), default(System.Web.Mvc.ControllerContext), default(System.ComponentModel.DataAnnotations.StringLengthAttribute)) { }
        public override System.Collections.Generic.IEnumerable<System.Web.Mvc.ModelClientValidationRule> GetClientValidationRules() { throw null; }
    }
    public partial class TempDataDictionary : System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<string, object>>, System.Collections.Generic.IDictionary<string, object>, System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<string, object>>, System.Collections.IEnumerable
    {
        public TempDataDictionary() { }
        public int Count { get { throw null; } }
        public object this[string key] { get { throw null; } set { } }
        public System.Collections.Generic.ICollection<string> Keys { get { throw null; } }
        bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,System.Object>>.IsReadOnly { get { throw null; } }
        public System.Collections.Generic.ICollection<object> Values { get { throw null; } }
        public void Add(string key, object value) { }
        public void Clear() { }
        public bool ContainsKey(string key) { throw null; }
        public bool ContainsValue(object value) { throw null; }
        public System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<string, object>> GetEnumerator() { throw null; }
        public void Keep() { }
        public void Keep(string key) { }
        public void Load(System.Web.Mvc.ControllerContext controllerContext, System.Web.Mvc.ITempDataProvider tempDataProvider) { }
        public object Peek(string key) { throw null; }
        public bool Remove(string key) { throw null; }
        public void Save(System.Web.Mvc.ControllerContext controllerContext, System.Web.Mvc.ITempDataProvider tempDataProvider) { }
        void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,System.Object>>.Add(System.Collections.Generic.KeyValuePair<string, object> keyValuePair) { }
        bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,System.Object>>.Contains(System.Collections.Generic.KeyValuePair<string, object> keyValuePair) { throw null; }
        void System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,System.Object>>.CopyTo(System.Collections.Generic.KeyValuePair<string, object>[] array, int index) { }
        bool System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<System.String,System.Object>>.Remove(System.Collections.Generic.KeyValuePair<string, object> keyValuePair) { throw null; }
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { throw null; }
        public bool TryGetValue(string key, out object value) { value = default(object); throw null; }
    }
    public partial class TemplateInfo
    {
        public TemplateInfo() { }
        public object FormattedModelValue { get { throw null; } set { } }
        public string HtmlFieldPrefix { get { throw null; } set { } }
        public int TemplateDepth { get { throw null; } }
        public string GetFullHtmlFieldId(string partialFieldName) { throw null; }
        public string GetFullHtmlFieldName(string partialFieldName) { throw null; }
        public bool Visited(System.Web.Mvc.ModelMetadata metadata) { throw null; }
    }
    public partial class UrlHelper
    {
        public UrlHelper(System.Web.Routing.RequestContext requestContext) { }
        public UrlHelper(System.Web.Routing.RequestContext requestContext, System.Web.Routing.RouteCollection routeCollection) { }
        public System.Web.Routing.RequestContext RequestContext { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        public System.Web.Routing.RouteCollection RouteCollection { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        public string Action(string actionName) { throw null; }
        public string Action(string actionName, object routeValues) { throw null; }
        public string Action(string actionName, string controllerName) { throw null; }
        public string Action(string actionName, string controllerName, object routeValues) { throw null; }
        public string Action(string actionName, string controllerName, object routeValues, string protocol) { throw null; }
        public string Action(string actionName, string controllerName, System.Web.Routing.RouteValueDictionary routeValues) { throw null; }
        public string Action(string actionName, string controllerName, System.Web.Routing.RouteValueDictionary routeValues, string protocol, string hostName) { throw null; }
        public string Action(string actionName, System.Web.Routing.RouteValueDictionary routeValues) { throw null; }
        public string Content(string contentPath) { throw null; }
        public string Encode(string url) { throw null; }
        public static string GenerateContentUrl(string contentPath, System.Web.HttpContextBase httpContext) { throw null; }
        public static string GenerateUrl(string routeName, string actionName, string controllerName, string protocol, string hostName, string fragment, System.Web.Routing.RouteValueDictionary routeValues, System.Web.Routing.RouteCollection routeCollection, System.Web.Routing.RequestContext requestContext, bool includeImplicitMvcValues) { throw null; }
        public static string GenerateUrl(string routeName, string actionName, string controllerName, System.Web.Routing.RouteValueDictionary routeValues, System.Web.Routing.RouteCollection routeCollection, System.Web.Routing.RequestContext requestContext, bool includeImplicitMvcValues) { throw null; }
        public bool IsLocalUrl(string url) { throw null; }
        public string RouteUrl(object routeValues) { throw null; }
        public string RouteUrl(string routeName) { throw null; }
        public string RouteUrl(string routeName, object routeValues) { throw null; }
        public string RouteUrl(string routeName, object routeValues, string protocol) { throw null; }
        public string RouteUrl(string routeName, System.Web.Routing.RouteValueDictionary routeValues) { throw null; }
        public string RouteUrl(string routeName, System.Web.Routing.RouteValueDictionary routeValues, string protocol, string hostName) { throw null; }
        public string RouteUrl(System.Web.Routing.RouteValueDictionary routeValues) { throw null; }
    }
    public sealed partial class UrlParameter
    {
        internal UrlParameter() { }
        public static readonly System.Web.Mvc.UrlParameter Optional;
        public override string ToString() { throw null; }
    }
    public partial class ValidatableObjectAdapter : System.Web.Mvc.ModelValidator
    {
        public ValidatableObjectAdapter(System.Web.Mvc.ModelMetadata metadata, System.Web.Mvc.ControllerContext context) : base (default(System.Web.Mvc.ModelMetadata), default(System.Web.Mvc.ControllerContext)) { }
        public override System.Collections.Generic.IEnumerable<System.Web.Mvc.ModelValidationResult> Validate(object container) { throw null; }
    }
    [System.AttributeUsageAttribute((System.AttributeTargets)(68), AllowMultiple=false, Inherited=true)]
    public sealed partial class ValidateAntiForgeryTokenAttribute : System.Web.Mvc.FilterAttribute, System.Web.Mvc.IAuthorizationFilter
    {
        public ValidateAntiForgeryTokenAttribute() { }
        public string Salt { get { throw null; } set { } }
        public void OnAuthorization(System.Web.Mvc.AuthorizationContext filterContext) { }
    }
    [System.AttributeUsageAttribute((System.AttributeTargets)(68), Inherited=true, AllowMultiple=false)]
    public partial class ValidateInputAttribute : System.Web.Mvc.FilterAttribute, System.Web.Mvc.IAuthorizationFilter
    {
        public ValidateInputAttribute(bool enableValidation) { }
        public bool EnableValidation { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        public virtual void OnAuthorization(System.Web.Mvc.AuthorizationContext filterContext) { }
    }
    public partial class ValueProviderCollection : System.Collections.ObjectModel.Collection<System.Web.Mvc.IValueProvider>, System.Web.Mvc.IUnvalidatedValueProvider, System.Web.Mvc.IValueProvider
    {
        public ValueProviderCollection() { }
        public ValueProviderCollection(System.Collections.Generic.IList<System.Web.Mvc.IValueProvider> list) { }
        public virtual bool ContainsPrefix(string prefix) { throw null; }
        public virtual System.Web.Mvc.ValueProviderResult GetValue(string key) { throw null; }
        public virtual System.Web.Mvc.ValueProviderResult GetValue(string key, bool skipValidation) { throw null; }
        protected override void InsertItem(int index, System.Web.Mvc.IValueProvider item) { }
        protected override void SetItem(int index, System.Web.Mvc.IValueProvider item) { }
    }
    [System.ObsoleteAttribute("The recommended alternative is to use one of the specific ValueProvider types, such as FormValueProvider.")]
    public partial class ValueProviderDictionary : System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<string, System.Web.Mvc.ValueProviderResult>>, System.Collections.Generic.IDictionary<string, System.Web.Mvc.ValueProviderResult>, System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<string, System.Web.Mvc.ValueProviderResult>>, System.Collections.IEnumerable, System.Web.Mvc.IValueProvider
    {
        public ValueProviderDictionary(System.Web.Mvc.ControllerContext controllerContext) { }
        public System.Web.Mvc.ControllerContext ControllerContext { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        public int Count { get { throw null; } }
        public bool IsReadOnly { get { throw null; } }
        public System.Web.Mvc.ValueProviderResult this[string key] { get { throw null; } set { } }
        public System.Collections.Generic.ICollection<string> Keys { get { throw null; } }
        public System.Collections.Generic.ICollection<System.Web.Mvc.ValueProviderResult> Values { get { throw null; } }
        public void Add(System.Collections.Generic.KeyValuePair<string, System.Web.Mvc.ValueProviderResult> item) { }
        public void Add(string key, object value) { }
        public void Add(string key, System.Web.Mvc.ValueProviderResult value) { }
        public void Clear() { }
        public bool Contains(System.Collections.Generic.KeyValuePair<string, System.Web.Mvc.ValueProviderResult> item) { throw null; }
        public bool ContainsKey(string key) { throw null; }
        public void CopyTo(System.Collections.Generic.KeyValuePair<string, System.Web.Mvc.ValueProviderResult>[] array, int arrayIndex) { }
        public System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<string, System.Web.Mvc.ValueProviderResult>> GetEnumerator() { throw null; }
        public bool Remove(System.Collections.Generic.KeyValuePair<string, System.Web.Mvc.ValueProviderResult> item) { throw null; }
        public bool Remove(string key) { throw null; }
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { throw null; }
        bool System.Web.Mvc.IValueProvider.ContainsPrefix(string prefix) { throw null; }
        System.Web.Mvc.ValueProviderResult System.Web.Mvc.IValueProvider.GetValue(string key) { throw null; }
        public bool TryGetValue(string key, out System.Web.Mvc.ValueProviderResult value) { value = default(System.Web.Mvc.ValueProviderResult); throw null; }
    }
    public static partial class ValueProviderFactories
    {
        public static System.Web.Mvc.ValueProviderFactoryCollection Factories { get { throw null; } }
    }
    public abstract partial class ValueProviderFactory
    {
        protected ValueProviderFactory() { }
        public abstract System.Web.Mvc.IValueProvider GetValueProvider(System.Web.Mvc.ControllerContext controllerContext);
    }
    public partial class ValueProviderFactoryCollection : System.Collections.ObjectModel.Collection<System.Web.Mvc.ValueProviderFactory>
    {
        public ValueProviderFactoryCollection() { }
        public ValueProviderFactoryCollection(System.Collections.Generic.IList<System.Web.Mvc.ValueProviderFactory> list) { }
        public System.Web.Mvc.IValueProvider GetValueProvider(System.Web.Mvc.ControllerContext controllerContext) { throw null; }
        protected override void InsertItem(int index, System.Web.Mvc.ValueProviderFactory item) { }
        protected override void SetItem(int index, System.Web.Mvc.ValueProviderFactory item) { }
    }
    [System.SerializableAttribute]
    public partial class ValueProviderResult
    {
        protected ValueProviderResult() { }
        public ValueProviderResult(object rawValue, string attemptedValue, System.Globalization.CultureInfo culture) { }
        public string AttemptedValue { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]protected set { } }
        public System.Globalization.CultureInfo Culture { get { throw null; } protected set { } }
        public object RawValue { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]protected set { } }
        public object ConvertTo(System.Type type) { throw null; }
        public virtual object ConvertTo(System.Type type, System.Globalization.CultureInfo culture) { throw null; }
    }
    public partial class ViewContext : System.Web.Mvc.ControllerContext
    {
        public ViewContext() { }
        public ViewContext(System.Web.Mvc.ControllerContext controllerContext, System.Web.Mvc.IView view, System.Web.Mvc.ViewDataDictionary viewData, System.Web.Mvc.TempDataDictionary tempData, System.IO.TextWriter writer) { }
        public virtual bool ClientValidationEnabled { get { throw null; } set { } }
        public virtual System.Web.Mvc.FormContext FormContext { get { throw null; } set { } }
        public virtual System.Web.Mvc.TempDataDictionary TempData { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public virtual bool UnobtrusiveJavaScriptEnabled { get { throw null; } set { } }
        public virtual System.Web.Mvc.IView View { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public virtual System.Web.Mvc.ViewDataDictionary ViewData { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public virtual System.IO.TextWriter Writer { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public void OutputClientValidation() { }
    }
    public partial class ViewDataDictionary : System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<string, object>>, System.Collections.Generic.IDictionary<string, object>, System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<string, object>>, System.Collections.IEnumerable
    {
        public ViewDataDictionary() { }
        public ViewDataDictionary(object model) { }
        public ViewDataDictionary(System.Web.Mvc.ViewDataDictionary dictionary) { }
        public int Count { get { throw null; } }
        public bool IsReadOnly { get { throw null; } }
        public object this[string key] { get { throw null; } set { } }
        public System.Collections.Generic.ICollection<string> Keys { get { throw null; } }
        public object Model { get { throw null; } set { } }
        public virtual System.Web.Mvc.ModelMetadata ModelMetadata { get { throw null; } set { } }
        public System.Web.Mvc.ModelStateDictionary ModelState { get { throw null; } }
        public System.Web.Mvc.TemplateInfo TemplateInfo { get { throw null; } set { } }
        public System.Collections.Generic.ICollection<object> Values { get { throw null; } }
        public void Add(System.Collections.Generic.KeyValuePair<string, object> item) { }
        public void Add(string key, object value) { }
        public void Clear() { }
        public bool Contains(System.Collections.Generic.KeyValuePair<string, object> item) { throw null; }
        public bool ContainsKey(string key) { throw null; }
        public void CopyTo(System.Collections.Generic.KeyValuePair<string, object>[] array, int arrayIndex) { }
        public object Eval(string expression) { throw null; }
        public string Eval(string expression, string format) { throw null; }
        public System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<string, object>> GetEnumerator() { throw null; }
        public System.Web.Mvc.ViewDataInfo GetViewDataInfo(string expression) { throw null; }
        public bool Remove(System.Collections.Generic.KeyValuePair<string, object> item) { throw null; }
        public bool Remove(string key) { throw null; }
        protected virtual void SetModel(object value) { }
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { throw null; }
        public bool TryGetValue(string key, out object value) { value = default(object); throw null; }
    }
    public partial class ViewDataDictionary<TModel> : System.Web.Mvc.ViewDataDictionary
    {
        public ViewDataDictionary() { }
        public ViewDataDictionary(System.Web.Mvc.ViewDataDictionary viewDataDictionary) { }
        public ViewDataDictionary(TModel model) { }
        public new TModel Model { get { throw null; } set { } }
        public override System.Web.Mvc.ModelMetadata ModelMetadata { get { throw null; } set { } }
        protected override void SetModel(object value) { }
    }
    public partial class ViewDataInfo
    {
        public ViewDataInfo() { }
        public ViewDataInfo(System.Func<object> valueAccessor) { }
        public object Container { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public System.ComponentModel.PropertyDescriptor PropertyDescriptor { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public object Value { get { throw null; } set { } }
    }
    public partial class ViewEngineCollection : System.Collections.ObjectModel.Collection<System.Web.Mvc.IViewEngine>
    {
        public ViewEngineCollection() { }
        public ViewEngineCollection(System.Collections.Generic.IList<System.Web.Mvc.IViewEngine> list) { }
        public virtual System.Web.Mvc.ViewEngineResult FindPartialView(System.Web.Mvc.ControllerContext controllerContext, string partialViewName) { throw null; }
        public virtual System.Web.Mvc.ViewEngineResult FindView(System.Web.Mvc.ControllerContext controllerContext, string viewName, string masterName) { throw null; }
        protected override void InsertItem(int index, System.Web.Mvc.IViewEngine item) { }
        protected override void SetItem(int index, System.Web.Mvc.IViewEngine item) { }
    }
    public partial class ViewEngineResult
    {
        public ViewEngineResult(System.Collections.Generic.IEnumerable<string> searchedLocations) { }
        public ViewEngineResult(System.Web.Mvc.IView view, System.Web.Mvc.IViewEngine viewEngine) { }
        public System.Collections.Generic.IEnumerable<string> SearchedLocations { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        public System.Web.Mvc.IView View { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        public System.Web.Mvc.IViewEngine ViewEngine { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
    }
    public static partial class ViewEngines
    {
        public static System.Web.Mvc.ViewEngineCollection Engines { get { throw null; } }
    }
    public partial class ViewMasterPage : System.Web.UI.MasterPage
    {
        public ViewMasterPage() { }
        public System.Web.Mvc.AjaxHelper<object> Ajax { get { throw null; } }
        public System.Web.Mvc.HtmlHelper<object> Html { get { throw null; } }
        public object Model { get { throw null; } }
        public System.Web.Mvc.TempDataDictionary TempData { get { throw null; } }
        public System.Web.Mvc.UrlHelper Url { get { throw null; } }
        public dynamic ViewBag { get { throw null; } }
        public System.Web.Mvc.ViewContext ViewContext { get { throw null; } }
        public System.Web.Mvc.ViewDataDictionary ViewData { get { throw null; } }
        public System.Web.UI.HtmlTextWriter Writer { get { throw null; } }
    }
    public partial class ViewMasterPage<TModel> : System.Web.Mvc.ViewMasterPage
    {
        public ViewMasterPage() { }
        public new System.Web.Mvc.AjaxHelper<TModel> Ajax { get { throw null; } }
        public new System.Web.Mvc.HtmlHelper<TModel> Html { get { throw null; } }
        public new TModel Model { get { throw null; } }
        public new System.Web.Mvc.ViewDataDictionary<TModel> ViewData { get { throw null; } }
    }
    public partial class ViewPage : System.Web.UI.Page, System.Web.Mvc.IViewDataContainer
    {
        public ViewPage() { }
        public System.Web.Mvc.AjaxHelper<object> Ajax { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public System.Web.Mvc.HtmlHelper<object> Html { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public string MasterLocation { get { throw null; } set { } }
        public object Model { get { throw null; } }
        public System.Web.Mvc.TempDataDictionary TempData { get { throw null; } }
        public System.Web.Mvc.UrlHelper Url { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public dynamic ViewBag { get { throw null; } }
        public System.Web.Mvc.ViewContext ViewContext { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public System.Web.Mvc.ViewDataDictionary ViewData { get { throw null; } set { } }
        public System.Web.UI.HtmlTextWriter Writer { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        public virtual void InitHelpers() { }
        protected override void OnPreInit(System.EventArgs e) { }
        public override void ProcessRequest(System.Web.HttpContext context) { }
        protected override void Render(System.Web.UI.HtmlTextWriter writer) { }
        public virtual void RenderView(System.Web.Mvc.ViewContext viewContext) { }
        [System.ObsoleteAttribute("The TextWriter is now provided by the ViewContext object passed to the RenderView method.", true)]
        public void SetTextWriter(System.IO.TextWriter textWriter) { }
        protected virtual void SetViewData(System.Web.Mvc.ViewDataDictionary viewData) { }
    }
    public partial class ViewPage<TModel> : System.Web.Mvc.ViewPage
    {
        public ViewPage() { }
        public new System.Web.Mvc.AjaxHelper<TModel> Ajax { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public new System.Web.Mvc.HtmlHelper<TModel> Html { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public new TModel Model { get { throw null; } }
        public new System.Web.Mvc.ViewDataDictionary<TModel> ViewData { get { throw null; } set { } }
        public override void InitHelpers() { }
        protected override void SetViewData(System.Web.Mvc.ViewDataDictionary viewData) { }
    }
    public partial class ViewResult : System.Web.Mvc.ViewResultBase
    {
        public ViewResult() { }
        public string MasterName { get { throw null; } set { } }
        protected override System.Web.Mvc.ViewEngineResult FindView(System.Web.Mvc.ControllerContext context) { throw null; }
    }
    public abstract partial class ViewResultBase : System.Web.Mvc.ActionResult
    {
        protected ViewResultBase() { }
        public object Model { get { throw null; } }
        public System.Web.Mvc.TempDataDictionary TempData { get { throw null; } set { } }
        public System.Web.Mvc.IView View { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public dynamic ViewBag { get { throw null; } }
        public System.Web.Mvc.ViewDataDictionary ViewData { get { throw null; } set { } }
        public System.Web.Mvc.ViewEngineCollection ViewEngineCollection { get { throw null; } set { } }
        public string ViewName { get { throw null; } set { } }
        public override void ExecuteResult(System.Web.Mvc.ControllerContext context) { }
        protected abstract System.Web.Mvc.ViewEngineResult FindView(System.Web.Mvc.ControllerContext context);
    }
    public abstract partial class ViewStartPage : System.Web.WebPages.StartPage
    {
        protected ViewStartPage() { }
        public System.Web.Mvc.HtmlHelper<object> Html { get { throw null; } }
        public System.Web.Mvc.UrlHelper Url { get { throw null; } }
        public System.Web.Mvc.ViewContext ViewContext { get { throw null; } }
    }
    public partial class ViewTemplateUserControl : System.Web.Mvc.ViewTemplateUserControl<object>
    {
        public ViewTemplateUserControl() { }
    }
    public partial class ViewTemplateUserControl<TModel> : System.Web.Mvc.ViewUserControl<TModel>
    {
        public ViewTemplateUserControl() { }
        protected string FormattedModelValue { get { throw null; } }
    }
    [System.Web.UI.NonVisualControlAttribute]
    public partial class ViewType : System.Web.UI.Control
    {
        public ViewType() { }
        [System.ComponentModel.DefaultValueAttribute("")]
        public string TypeName { get { throw null; } set { } }
    }
    public partial class ViewUserControl : System.Web.UI.UserControl, System.Web.Mvc.IViewDataContainer
    {
        public ViewUserControl() { }
        public System.Web.Mvc.AjaxHelper<object> Ajax { get { throw null; } }
        public System.Web.Mvc.HtmlHelper<object> Html { get { throw null; } }
        public object Model { get { throw null; } }
        public System.Web.Mvc.TempDataDictionary TempData { get { throw null; } }
        public System.Web.Mvc.UrlHelper Url { get { throw null; } }
        public dynamic ViewBag { get { throw null; } }
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(0))]
        public System.Web.Mvc.ViewContext ViewContext { get { throw null; } set { } }
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.DesignerSerializationVisibilityAttribute((System.ComponentModel.DesignerSerializationVisibility)(0))]
        public System.Web.Mvc.ViewDataDictionary ViewData { get { throw null; } set { } }
        [System.ComponentModel.DefaultValueAttribute("")]
        public string ViewDataKey { get { throw null; } set { } }
        public System.Web.UI.HtmlTextWriter Writer { get { throw null; } }
        protected void EnsureViewData() { }
        public virtual void RenderView(System.Web.Mvc.ViewContext viewContext) { }
        [System.ObsoleteAttribute("The TextWriter is now provided by the ViewContext object passed to the RenderView method.", true)]
        public void SetTextWriter(System.IO.TextWriter textWriter) { }
        protected virtual void SetViewData(System.Web.Mvc.ViewDataDictionary viewData) { }
    }
    public partial class ViewUserControl<TModel> : System.Web.Mvc.ViewUserControl
    {
        public ViewUserControl() { }
        public new System.Web.Mvc.AjaxHelper<TModel> Ajax { get { throw null; } }
        public new System.Web.Mvc.HtmlHelper<TModel> Html { get { throw null; } }
        public new TModel Model { get { throw null; } }
        public new System.Web.Mvc.ViewDataDictionary<TModel> ViewData { get { throw null; } set { } }
        protected override void SetViewData(System.Web.Mvc.ViewDataDictionary viewData) { }
    }
    public abstract partial class VirtualPathProviderViewEngine : System.Web.Mvc.IViewEngine
    {
        protected VirtualPathProviderViewEngine() { }
        public string[] AreaMasterLocationFormats { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public string[] AreaPartialViewLocationFormats { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public string[] AreaViewLocationFormats { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public string[] FileExtensions { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public string[] MasterLocationFormats { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public string[] PartialViewLocationFormats { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public System.Web.Mvc.IViewLocationCache ViewLocationCache { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public string[] ViewLocationFormats { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        protected System.Web.Hosting.VirtualPathProvider VirtualPathProvider { get { throw null; } set { } }
        protected abstract System.Web.Mvc.IView CreatePartialView(System.Web.Mvc.ControllerContext controllerContext, string partialPath);
        protected abstract System.Web.Mvc.IView CreateView(System.Web.Mvc.ControllerContext controllerContext, string viewPath, string masterPath);
        protected virtual bool FileExists(System.Web.Mvc.ControllerContext controllerContext, string virtualPath) { throw null; }
        public virtual System.Web.Mvc.ViewEngineResult FindPartialView(System.Web.Mvc.ControllerContext controllerContext, string partialViewName, bool useCache) { throw null; }
        public virtual System.Web.Mvc.ViewEngineResult FindView(System.Web.Mvc.ControllerContext controllerContext, string viewName, string masterName, bool useCache) { throw null; }
        public virtual void ReleaseView(System.Web.Mvc.ControllerContext controllerContext, System.Web.Mvc.IView view) { }
    }
    public partial class WebFormView : System.Web.Mvc.BuildManagerCompiledView
    {
        public WebFormView(System.Web.Mvc.ControllerContext controllerContext, string viewPath) : base (default(System.Web.Mvc.ControllerContext), default(string)) { }
        public WebFormView(System.Web.Mvc.ControllerContext controllerContext, string viewPath, string masterPath) : base (default(System.Web.Mvc.ControllerContext), default(string)) { }
        public WebFormView(System.Web.Mvc.ControllerContext controllerContext, string viewPath, string masterPath, System.Web.Mvc.IViewPageActivator viewPageActivator) : base (default(System.Web.Mvc.ControllerContext), default(string)) { }
        public string MasterPath { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        protected override void RenderView(System.Web.Mvc.ViewContext viewContext, System.IO.TextWriter writer, object instance) { }
    }
    public partial class WebFormViewEngine : System.Web.Mvc.BuildManagerViewEngine
    {
        public WebFormViewEngine() { }
        public WebFormViewEngine(System.Web.Mvc.IViewPageActivator viewPageActivator) { }
        protected override System.Web.Mvc.IView CreatePartialView(System.Web.Mvc.ControllerContext controllerContext, string partialPath) { throw null; }
        protected override System.Web.Mvc.IView CreateView(System.Web.Mvc.ControllerContext controllerContext, string viewPath, string masterPath) { throw null; }
    }
    public abstract partial class WebViewPage : System.Web.WebPages.WebPageBase, System.Web.Mvc.IViewDataContainer
    {
        protected WebViewPage() { }
        public System.Web.Mvc.AjaxHelper<object> Ajax { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public override System.Web.HttpContextBase Context { get { throw null; } set { } }
        public System.Web.Mvc.HtmlHelper<object> Html { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public object Model { get { throw null; } }
        public System.Web.Mvc.TempDataDictionary TempData { get { throw null; } }
        public System.Web.Mvc.UrlHelper Url { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public dynamic ViewBag { get { throw null; } }
        public System.Web.Mvc.ViewContext ViewContext { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public System.Web.Mvc.ViewDataDictionary ViewData { get { throw null; } set { } }
        protected override void ConfigurePage(System.Web.WebPages.WebPageBase parentPage) { }
        public override void ExecutePageHierarchy() { }
        public virtual void InitHelpers() { }
        protected virtual void SetViewData(System.Web.Mvc.ViewDataDictionary viewData) { }
    }
    public abstract partial class WebViewPage<TModel> : System.Web.Mvc.WebViewPage
    {
        protected WebViewPage() { }
        public new System.Web.Mvc.AjaxHelper<TModel> Ajax { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public new System.Web.Mvc.HtmlHelper<TModel> Html { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public new TModel Model { get { throw null; } }
        public new System.Web.Mvc.ViewDataDictionary<TModel> ViewData { get { throw null; } set { } }
        public override void InitHelpers() { }
        protected override void SetViewData(System.Web.Mvc.ViewDataDictionary viewData) { }
    }
}
namespace System.Web.Mvc.Ajax
{
    public static partial class AjaxExtensions
    {
        public static System.Web.Mvc.MvcHtmlString ActionLink(this System.Web.Mvc.AjaxHelper ajaxHelper, string linkText, string actionName, object routeValues, System.Web.Mvc.Ajax.AjaxOptions ajaxOptions) { throw null; }
        public static System.Web.Mvc.MvcHtmlString ActionLink(this System.Web.Mvc.AjaxHelper ajaxHelper, string linkText, string actionName, object routeValues, System.Web.Mvc.Ajax.AjaxOptions ajaxOptions, object htmlAttributes) { throw null; }
        public static System.Web.Mvc.MvcHtmlString ActionLink(this System.Web.Mvc.AjaxHelper ajaxHelper, string linkText, string actionName, string controllerName, object routeValues, System.Web.Mvc.Ajax.AjaxOptions ajaxOptions) { throw null; }
        public static System.Web.Mvc.MvcHtmlString ActionLink(this System.Web.Mvc.AjaxHelper ajaxHelper, string linkText, string actionName, string controllerName, object routeValues, System.Web.Mvc.Ajax.AjaxOptions ajaxOptions, object htmlAttributes) { throw null; }
        public static System.Web.Mvc.MvcHtmlString ActionLink(this System.Web.Mvc.AjaxHelper ajaxHelper, string linkText, string actionName, string controllerName, string protocol, string hostName, string fragment, object routeValues, System.Web.Mvc.Ajax.AjaxOptions ajaxOptions, object htmlAttributes) { throw null; }
        public static System.Web.Mvc.MvcHtmlString ActionLink(this System.Web.Mvc.AjaxHelper ajaxHelper, string linkText, string actionName, string controllerName, string protocol, string hostName, string fragment, System.Web.Routing.RouteValueDictionary routeValues, System.Web.Mvc.Ajax.AjaxOptions ajaxOptions, System.Collections.Generic.IDictionary<string, object> htmlAttributes) { throw null; }
        public static System.Web.Mvc.MvcHtmlString ActionLink(this System.Web.Mvc.AjaxHelper ajaxHelper, string linkText, string actionName, string controllerName, System.Web.Mvc.Ajax.AjaxOptions ajaxOptions) { throw null; }
        public static System.Web.Mvc.MvcHtmlString ActionLink(this System.Web.Mvc.AjaxHelper ajaxHelper, string linkText, string actionName, string controllerName, System.Web.Routing.RouteValueDictionary routeValues, System.Web.Mvc.Ajax.AjaxOptions ajaxOptions) { throw null; }
        public static System.Web.Mvc.MvcHtmlString ActionLink(this System.Web.Mvc.AjaxHelper ajaxHelper, string linkText, string actionName, string controllerName, System.Web.Routing.RouteValueDictionary routeValues, System.Web.Mvc.Ajax.AjaxOptions ajaxOptions, System.Collections.Generic.IDictionary<string, object> htmlAttributes) { throw null; }
        public static System.Web.Mvc.MvcHtmlString ActionLink(this System.Web.Mvc.AjaxHelper ajaxHelper, string linkText, string actionName, System.Web.Mvc.Ajax.AjaxOptions ajaxOptions) { throw null; }
        public static System.Web.Mvc.MvcHtmlString ActionLink(this System.Web.Mvc.AjaxHelper ajaxHelper, string linkText, string actionName, System.Web.Routing.RouteValueDictionary routeValues, System.Web.Mvc.Ajax.AjaxOptions ajaxOptions) { throw null; }
        public static System.Web.Mvc.MvcHtmlString ActionLink(this System.Web.Mvc.AjaxHelper ajaxHelper, string linkText, string actionName, System.Web.Routing.RouteValueDictionary routeValues, System.Web.Mvc.Ajax.AjaxOptions ajaxOptions, System.Collections.Generic.IDictionary<string, object> htmlAttributes) { throw null; }
        public static System.Web.Mvc.Html.MvcForm BeginForm(this System.Web.Mvc.AjaxHelper ajaxHelper, string actionName, object routeValues, System.Web.Mvc.Ajax.AjaxOptions ajaxOptions) { throw null; }
        public static System.Web.Mvc.Html.MvcForm BeginForm(this System.Web.Mvc.AjaxHelper ajaxHelper, string actionName, object routeValues, System.Web.Mvc.Ajax.AjaxOptions ajaxOptions, object htmlAttributes) { throw null; }
        public static System.Web.Mvc.Html.MvcForm BeginForm(this System.Web.Mvc.AjaxHelper ajaxHelper, string actionName, string controllerName, object routeValues, System.Web.Mvc.Ajax.AjaxOptions ajaxOptions) { throw null; }
        public static System.Web.Mvc.Html.MvcForm BeginForm(this System.Web.Mvc.AjaxHelper ajaxHelper, string actionName, string controllerName, object routeValues, System.Web.Mvc.Ajax.AjaxOptions ajaxOptions, object htmlAttributes) { throw null; }
        public static System.Web.Mvc.Html.MvcForm BeginForm(this System.Web.Mvc.AjaxHelper ajaxHelper, string actionName, string controllerName, System.Web.Mvc.Ajax.AjaxOptions ajaxOptions) { throw null; }
        public static System.Web.Mvc.Html.MvcForm BeginForm(this System.Web.Mvc.AjaxHelper ajaxHelper, string actionName, string controllerName, System.Web.Routing.RouteValueDictionary routeValues, System.Web.Mvc.Ajax.AjaxOptions ajaxOptions) { throw null; }
        public static System.Web.Mvc.Html.MvcForm BeginForm(this System.Web.Mvc.AjaxHelper ajaxHelper, string actionName, string controllerName, System.Web.Routing.RouteValueDictionary routeValues, System.Web.Mvc.Ajax.AjaxOptions ajaxOptions, System.Collections.Generic.IDictionary<string, object> htmlAttributes) { throw null; }
        public static System.Web.Mvc.Html.MvcForm BeginForm(this System.Web.Mvc.AjaxHelper ajaxHelper, string actionName, System.Web.Mvc.Ajax.AjaxOptions ajaxOptions) { throw null; }
        public static System.Web.Mvc.Html.MvcForm BeginForm(this System.Web.Mvc.AjaxHelper ajaxHelper, string actionName, System.Web.Routing.RouteValueDictionary routeValues, System.Web.Mvc.Ajax.AjaxOptions ajaxOptions) { throw null; }
        public static System.Web.Mvc.Html.MvcForm BeginForm(this System.Web.Mvc.AjaxHelper ajaxHelper, string actionName, System.Web.Routing.RouteValueDictionary routeValues, System.Web.Mvc.Ajax.AjaxOptions ajaxOptions, System.Collections.Generic.IDictionary<string, object> htmlAttributes) { throw null; }
        public static System.Web.Mvc.Html.MvcForm BeginForm(this System.Web.Mvc.AjaxHelper ajaxHelper, System.Web.Mvc.Ajax.AjaxOptions ajaxOptions) { throw null; }
        public static System.Web.Mvc.Html.MvcForm BeginRouteForm(this System.Web.Mvc.AjaxHelper ajaxHelper, string routeName, object routeValues, System.Web.Mvc.Ajax.AjaxOptions ajaxOptions) { throw null; }
        public static System.Web.Mvc.Html.MvcForm BeginRouteForm(this System.Web.Mvc.AjaxHelper ajaxHelper, string routeName, object routeValues, System.Web.Mvc.Ajax.AjaxOptions ajaxOptions, object htmlAttributes) { throw null; }
        public static System.Web.Mvc.Html.MvcForm BeginRouteForm(this System.Web.Mvc.AjaxHelper ajaxHelper, string routeName, System.Web.Mvc.Ajax.AjaxOptions ajaxOptions) { throw null; }
        public static System.Web.Mvc.Html.MvcForm BeginRouteForm(this System.Web.Mvc.AjaxHelper ajaxHelper, string routeName, System.Web.Routing.RouteValueDictionary routeValues, System.Web.Mvc.Ajax.AjaxOptions ajaxOptions) { throw null; }
        public static System.Web.Mvc.Html.MvcForm BeginRouteForm(this System.Web.Mvc.AjaxHelper ajaxHelper, string routeName, System.Web.Routing.RouteValueDictionary routeValues, System.Web.Mvc.Ajax.AjaxOptions ajaxOptions, System.Collections.Generic.IDictionary<string, object> htmlAttributes) { throw null; }
        public static System.Web.Mvc.MvcHtmlString GlobalizationScript(this System.Web.Mvc.AjaxHelper ajaxHelper) { throw null; }
        public static System.Web.Mvc.MvcHtmlString GlobalizationScript(this System.Web.Mvc.AjaxHelper ajaxHelper, System.Globalization.CultureInfo cultureInfo) { throw null; }
        public static System.Web.Mvc.MvcHtmlString RouteLink(this System.Web.Mvc.AjaxHelper ajaxHelper, string linkText, object routeValues, System.Web.Mvc.Ajax.AjaxOptions ajaxOptions) { throw null; }
        public static System.Web.Mvc.MvcHtmlString RouteLink(this System.Web.Mvc.AjaxHelper ajaxHelper, string linkText, object routeValues, System.Web.Mvc.Ajax.AjaxOptions ajaxOptions, object htmlAttributes) { throw null; }
        public static System.Web.Mvc.MvcHtmlString RouteLink(this System.Web.Mvc.AjaxHelper ajaxHelper, string linkText, string routeName, object routeValues, System.Web.Mvc.Ajax.AjaxOptions ajaxOptions) { throw null; }
        public static System.Web.Mvc.MvcHtmlString RouteLink(this System.Web.Mvc.AjaxHelper ajaxHelper, string linkText, string routeName, object routeValues, System.Web.Mvc.Ajax.AjaxOptions ajaxOptions, object htmlAttributes) { throw null; }
        public static System.Web.Mvc.MvcHtmlString RouteLink(this System.Web.Mvc.AjaxHelper ajaxHelper, string linkText, string routeName, string protocol, string hostName, string fragment, System.Web.Routing.RouteValueDictionary routeValues, System.Web.Mvc.Ajax.AjaxOptions ajaxOptions, System.Collections.Generic.IDictionary<string, object> htmlAttributes) { throw null; }
        public static System.Web.Mvc.MvcHtmlString RouteLink(this System.Web.Mvc.AjaxHelper ajaxHelper, string linkText, string routeName, System.Web.Mvc.Ajax.AjaxOptions ajaxOptions) { throw null; }
        public static System.Web.Mvc.MvcHtmlString RouteLink(this System.Web.Mvc.AjaxHelper ajaxHelper, string linkText, string routeName, System.Web.Mvc.Ajax.AjaxOptions ajaxOptions, System.Collections.Generic.IDictionary<string, object> htmlAttributes) { throw null; }
        public static System.Web.Mvc.MvcHtmlString RouteLink(this System.Web.Mvc.AjaxHelper ajaxHelper, string linkText, string routeName, System.Web.Mvc.Ajax.AjaxOptions ajaxOptions, object htmlAttributes) { throw null; }
        public static System.Web.Mvc.MvcHtmlString RouteLink(this System.Web.Mvc.AjaxHelper ajaxHelper, string linkText, string routeName, System.Web.Routing.RouteValueDictionary routeValues, System.Web.Mvc.Ajax.AjaxOptions ajaxOptions) { throw null; }
        public static System.Web.Mvc.MvcHtmlString RouteLink(this System.Web.Mvc.AjaxHelper ajaxHelper, string linkText, string routeName, System.Web.Routing.RouteValueDictionary routeValues, System.Web.Mvc.Ajax.AjaxOptions ajaxOptions, System.Collections.Generic.IDictionary<string, object> htmlAttributes) { throw null; }
        public static System.Web.Mvc.MvcHtmlString RouteLink(this System.Web.Mvc.AjaxHelper ajaxHelper, string linkText, System.Web.Routing.RouteValueDictionary routeValues, System.Web.Mvc.Ajax.AjaxOptions ajaxOptions) { throw null; }
        public static System.Web.Mvc.MvcHtmlString RouteLink(this System.Web.Mvc.AjaxHelper ajaxHelper, string linkText, System.Web.Routing.RouteValueDictionary routeValues, System.Web.Mvc.Ajax.AjaxOptions ajaxOptions, System.Collections.Generic.IDictionary<string, object> htmlAttributes) { throw null; }
    }
    public partial class AjaxOptions
    {
        public AjaxOptions() { }
        public string Confirm { get { throw null; } set { } }
        public string HttpMethod { get { throw null; } set { } }
        public System.Web.Mvc.Ajax.InsertionMode InsertionMode { get { throw null; } set { } }
        public int LoadingElementDuration { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public string LoadingElementId { get { throw null; } set { } }
        public string OnBegin { get { throw null; } set { } }
        public string OnComplete { get { throw null; } set { } }
        public string OnFailure { get { throw null; } set { } }
        public string OnSuccess { get { throw null; } set { } }
        public string UpdateTargetId { get { throw null; } set { } }
        public string Url { get { throw null; } set { } }
        public System.Collections.Generic.IDictionary<string, object> ToUnobtrusiveHtmlAttributes() { throw null; }
    }
    public enum InsertionMode
    {
        InsertAfter = 2,
        InsertBefore = 1,
        Replace = 0,
    }
}
namespace System.Web.Mvc.Async
{
    public abstract partial class AsyncActionDescriptor : System.Web.Mvc.ActionDescriptor
    {
        protected AsyncActionDescriptor() { }
        public abstract System.IAsyncResult BeginExecute(System.Web.Mvc.ControllerContext controllerContext, System.Collections.Generic.IDictionary<string, object> parameters, System.AsyncCallback callback, object state);
        public abstract object EndExecute(System.IAsyncResult asyncResult);
        public override object Execute(System.Web.Mvc.ControllerContext controllerContext, System.Collections.Generic.IDictionary<string, object> parameters) { throw null; }
    }
    public partial class AsyncControllerActionInvoker : System.Web.Mvc.ControllerActionInvoker, System.Web.Mvc.Async.IAsyncActionInvoker, System.Web.Mvc.IActionInvoker
    {
        public AsyncControllerActionInvoker() { }
        public virtual System.IAsyncResult BeginInvokeAction(System.Web.Mvc.ControllerContext controllerContext, string actionName, System.AsyncCallback callback, object state) { throw null; }
        protected internal virtual System.IAsyncResult BeginInvokeActionMethod(System.Web.Mvc.ControllerContext controllerContext, System.Web.Mvc.ActionDescriptor actionDescriptor, System.Collections.Generic.IDictionary<string, object> parameters, System.AsyncCallback callback, object state) { throw null; }
        protected internal virtual System.IAsyncResult BeginInvokeActionMethodWithFilters(System.Web.Mvc.ControllerContext controllerContext, System.Collections.Generic.IList<System.Web.Mvc.IActionFilter> filters, System.Web.Mvc.ActionDescriptor actionDescriptor, System.Collections.Generic.IDictionary<string, object> parameters, System.AsyncCallback callback, object state) { throw null; }
        public virtual bool EndInvokeAction(System.IAsyncResult asyncResult) { throw null; }
        protected internal virtual System.Web.Mvc.ActionResult EndInvokeActionMethod(System.IAsyncResult asyncResult) { throw null; }
        protected internal virtual System.Web.Mvc.ActionExecutedContext EndInvokeActionMethodWithFilters(System.IAsyncResult asyncResult) { throw null; }
        protected override System.Web.Mvc.ControllerDescriptor GetControllerDescriptor(System.Web.Mvc.ControllerContext controllerContext) { throw null; }
    }
    public partial class AsyncManager
    {
        public AsyncManager() { }
        public AsyncManager(System.Threading.SynchronizationContext syncContext) { }
        public System.Web.Mvc.Async.OperationCounter OutstandingOperations { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        public System.Collections.Generic.IDictionary<string, object> Parameters { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        public int Timeout { get { throw null; } set { } }
        public event System.EventHandler Finished { add { } remove { } }
        public virtual void Finish() { }
        public virtual void Sync(System.Action action) { }
    }
    public partial interface IAsyncActionInvoker : System.Web.Mvc.IActionInvoker
    {
        System.IAsyncResult BeginInvokeAction(System.Web.Mvc.ControllerContext controllerContext, string actionName, System.AsyncCallback callback, object state);
        bool EndInvokeAction(System.IAsyncResult asyncResult);
    }
    public partial interface IAsyncController : System.Web.Mvc.IController
    {
        System.IAsyncResult BeginExecute(System.Web.Routing.RequestContext requestContext, System.AsyncCallback callback, object state);
        void EndExecute(System.IAsyncResult asyncResult);
    }
    public partial interface IAsyncManagerContainer
    {
        System.Web.Mvc.Async.AsyncManager AsyncManager { get; }
    }
    public sealed partial class OperationCounter
    {
        public OperationCounter() { }
        public int Count { get { throw null; } }
        public event System.EventHandler Completed { add { } remove { } }
        public int Decrement() { throw null; }
        public int Decrement(int value) { throw null; }
        public int Increment() { throw null; }
        public int Increment(int value) { throw null; }
    }
    public partial class ReflectedAsyncActionDescriptor : System.Web.Mvc.Async.AsyncActionDescriptor
    {
        public ReflectedAsyncActionDescriptor(System.Reflection.MethodInfo asyncMethodInfo, System.Reflection.MethodInfo completedMethodInfo, string actionName, System.Web.Mvc.ControllerDescriptor controllerDescriptor) { }
        public override string ActionName { get { throw null; } }
        public System.Reflection.MethodInfo AsyncMethodInfo { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        public System.Reflection.MethodInfo CompletedMethodInfo { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        public override System.Web.Mvc.ControllerDescriptor ControllerDescriptor { get { throw null; } }
        public override string UniqueId { get { throw null; } }
        public override System.IAsyncResult BeginExecute(System.Web.Mvc.ControllerContext controllerContext, System.Collections.Generic.IDictionary<string, object> parameters, System.AsyncCallback callback, object state) { throw null; }
        public override object EndExecute(System.IAsyncResult asyncResult) { throw null; }
        public override object[] GetCustomAttributes(bool inherit) { throw null; }
        public override object[] GetCustomAttributes(System.Type attributeType, bool inherit) { throw null; }
        public override System.Web.Mvc.ParameterDescriptor[] GetParameters() { throw null; }
        public override System.Collections.Generic.ICollection<System.Web.Mvc.ActionSelector> GetSelectors() { throw null; }
        public override bool IsDefined(System.Type attributeType, bool inherit) { throw null; }
    }
    public partial class ReflectedAsyncControllerDescriptor : System.Web.Mvc.ControllerDescriptor
    {
        public ReflectedAsyncControllerDescriptor(System.Type controllerType) { }
        public sealed override System.Type ControllerType { get { throw null; } }
        public override System.Web.Mvc.ActionDescriptor FindAction(System.Web.Mvc.ControllerContext controllerContext, string actionName) { throw null; }
        public override System.Web.Mvc.ActionDescriptor[] GetCanonicalActions() { throw null; }
        public override object[] GetCustomAttributes(bool inherit) { throw null; }
        public override object[] GetCustomAttributes(System.Type attributeType, bool inherit) { throw null; }
        public override bool IsDefined(System.Type attributeType, bool inherit) { throw null; }
    }
    [System.SerializableAttribute]
    public sealed partial class SynchronousOperationException : System.Web.HttpException
    {
        public SynchronousOperationException() { }
        public SynchronousOperationException(string message) { }
        public SynchronousOperationException(string message, System.Exception innerException) { }
    }
}
namespace System.Web.Mvc.Html
{
    public static partial class ChildActionExtensions
    {
        public static System.Web.Mvc.MvcHtmlString Action(this System.Web.Mvc.HtmlHelper htmlHelper, string actionName) { throw null; }
        public static System.Web.Mvc.MvcHtmlString Action(this System.Web.Mvc.HtmlHelper htmlHelper, string actionName, object routeValues) { throw null; }
        public static System.Web.Mvc.MvcHtmlString Action(this System.Web.Mvc.HtmlHelper htmlHelper, string actionName, string controllerName) { throw null; }
        public static System.Web.Mvc.MvcHtmlString Action(this System.Web.Mvc.HtmlHelper htmlHelper, string actionName, string controllerName, object routeValues) { throw null; }
        public static System.Web.Mvc.MvcHtmlString Action(this System.Web.Mvc.HtmlHelper htmlHelper, string actionName, string controllerName, System.Web.Routing.RouteValueDictionary routeValues) { throw null; }
        public static System.Web.Mvc.MvcHtmlString Action(this System.Web.Mvc.HtmlHelper htmlHelper, string actionName, System.Web.Routing.RouteValueDictionary routeValues) { throw null; }
        public static void RenderAction(this System.Web.Mvc.HtmlHelper htmlHelper, string actionName) { }
        public static void RenderAction(this System.Web.Mvc.HtmlHelper htmlHelper, string actionName, object routeValues) { }
        public static void RenderAction(this System.Web.Mvc.HtmlHelper htmlHelper, string actionName, string controllerName) { }
        public static void RenderAction(this System.Web.Mvc.HtmlHelper htmlHelper, string actionName, string controllerName, object routeValues) { }
        public static void RenderAction(this System.Web.Mvc.HtmlHelper htmlHelper, string actionName, string controllerName, System.Web.Routing.RouteValueDictionary routeValues) { }
        public static void RenderAction(this System.Web.Mvc.HtmlHelper htmlHelper, string actionName, System.Web.Routing.RouteValueDictionary routeValues) { }
    }
    public static partial class DisplayExtensions
    {
        public static System.Web.Mvc.MvcHtmlString Display(this System.Web.Mvc.HtmlHelper html, string expression) { throw null; }
        public static System.Web.Mvc.MvcHtmlString Display(this System.Web.Mvc.HtmlHelper html, string expression, object additionalViewData) { throw null; }
        public static System.Web.Mvc.MvcHtmlString Display(this System.Web.Mvc.HtmlHelper html, string expression, string templateName) { throw null; }
        public static System.Web.Mvc.MvcHtmlString Display(this System.Web.Mvc.HtmlHelper html, string expression, string templateName, object additionalViewData) { throw null; }
        public static System.Web.Mvc.MvcHtmlString Display(this System.Web.Mvc.HtmlHelper html, string expression, string templateName, string htmlFieldName) { throw null; }
        public static System.Web.Mvc.MvcHtmlString Display(this System.Web.Mvc.HtmlHelper html, string expression, string templateName, string htmlFieldName, object additionalViewData) { throw null; }
        public static System.Web.Mvc.MvcHtmlString DisplayForModel(this System.Web.Mvc.HtmlHelper html) { throw null; }
        public static System.Web.Mvc.MvcHtmlString DisplayForModel(this System.Web.Mvc.HtmlHelper html, object additionalViewData) { throw null; }
        public static System.Web.Mvc.MvcHtmlString DisplayForModel(this System.Web.Mvc.HtmlHelper html, string templateName) { throw null; }
        public static System.Web.Mvc.MvcHtmlString DisplayForModel(this System.Web.Mvc.HtmlHelper html, string templateName, object additionalViewData) { throw null; }
        public static System.Web.Mvc.MvcHtmlString DisplayForModel(this System.Web.Mvc.HtmlHelper html, string templateName, string htmlFieldName) { throw null; }
        public static System.Web.Mvc.MvcHtmlString DisplayForModel(this System.Web.Mvc.HtmlHelper html, string templateName, string htmlFieldName, object additionalViewData) { throw null; }
        public static System.Web.Mvc.MvcHtmlString DisplayFor<TModel, TValue>(this System.Web.Mvc.HtmlHelper<TModel> html, System.Linq.Expressions.Expression<System.Func<TModel, TValue>> expression) { throw null; }
        public static System.Web.Mvc.MvcHtmlString DisplayFor<TModel, TValue>(this System.Web.Mvc.HtmlHelper<TModel> html, System.Linq.Expressions.Expression<System.Func<TModel, TValue>> expression, object additionalViewData) { throw null; }
        public static System.Web.Mvc.MvcHtmlString DisplayFor<TModel, TValue>(this System.Web.Mvc.HtmlHelper<TModel> html, System.Linq.Expressions.Expression<System.Func<TModel, TValue>> expression, string templateName) { throw null; }
        public static System.Web.Mvc.MvcHtmlString DisplayFor<TModel, TValue>(this System.Web.Mvc.HtmlHelper<TModel> html, System.Linq.Expressions.Expression<System.Func<TModel, TValue>> expression, string templateName, object additionalViewData) { throw null; }
        public static System.Web.Mvc.MvcHtmlString DisplayFor<TModel, TValue>(this System.Web.Mvc.HtmlHelper<TModel> html, System.Linq.Expressions.Expression<System.Func<TModel, TValue>> expression, string templateName, string htmlFieldName) { throw null; }
        public static System.Web.Mvc.MvcHtmlString DisplayFor<TModel, TValue>(this System.Web.Mvc.HtmlHelper<TModel> html, System.Linq.Expressions.Expression<System.Func<TModel, TValue>> expression, string templateName, string htmlFieldName, object additionalViewData) { throw null; }
    }
    public static partial class DisplayTextExtensions
    {
        public static System.Web.Mvc.MvcHtmlString DisplayText(this System.Web.Mvc.HtmlHelper html, string name) { throw null; }
        public static System.Web.Mvc.MvcHtmlString DisplayTextFor<TModel, TResult>(this System.Web.Mvc.HtmlHelper<TModel> html, System.Linq.Expressions.Expression<System.Func<TModel, TResult>> expression) { throw null; }
    }
    public static partial class EditorExtensions
    {
        public static System.Web.Mvc.MvcHtmlString Editor(this System.Web.Mvc.HtmlHelper html, string expression) { throw null; }
        public static System.Web.Mvc.MvcHtmlString Editor(this System.Web.Mvc.HtmlHelper html, string expression, object additionalViewData) { throw null; }
        public static System.Web.Mvc.MvcHtmlString Editor(this System.Web.Mvc.HtmlHelper html, string expression, string templateName) { throw null; }
        public static System.Web.Mvc.MvcHtmlString Editor(this System.Web.Mvc.HtmlHelper html, string expression, string templateName, object additionalViewData) { throw null; }
        public static System.Web.Mvc.MvcHtmlString Editor(this System.Web.Mvc.HtmlHelper html, string expression, string templateName, string htmlFieldName) { throw null; }
        public static System.Web.Mvc.MvcHtmlString Editor(this System.Web.Mvc.HtmlHelper html, string expression, string templateName, string htmlFieldName, object additionalViewData) { throw null; }
        public static System.Web.Mvc.MvcHtmlString EditorForModel(this System.Web.Mvc.HtmlHelper html) { throw null; }
        public static System.Web.Mvc.MvcHtmlString EditorForModel(this System.Web.Mvc.HtmlHelper html, object additionalViewData) { throw null; }
        public static System.Web.Mvc.MvcHtmlString EditorForModel(this System.Web.Mvc.HtmlHelper html, string templateName) { throw null; }
        public static System.Web.Mvc.MvcHtmlString EditorForModel(this System.Web.Mvc.HtmlHelper html, string templateName, object additionalViewData) { throw null; }
        public static System.Web.Mvc.MvcHtmlString EditorForModel(this System.Web.Mvc.HtmlHelper html, string templateName, string htmlFieldName) { throw null; }
        public static System.Web.Mvc.MvcHtmlString EditorForModel(this System.Web.Mvc.HtmlHelper html, string templateName, string htmlFieldName, object additionalViewData) { throw null; }
        public static System.Web.Mvc.MvcHtmlString EditorFor<TModel, TValue>(this System.Web.Mvc.HtmlHelper<TModel> html, System.Linq.Expressions.Expression<System.Func<TModel, TValue>> expression) { throw null; }
        public static System.Web.Mvc.MvcHtmlString EditorFor<TModel, TValue>(this System.Web.Mvc.HtmlHelper<TModel> html, System.Linq.Expressions.Expression<System.Func<TModel, TValue>> expression, object additionalViewData) { throw null; }
        public static System.Web.Mvc.MvcHtmlString EditorFor<TModel, TValue>(this System.Web.Mvc.HtmlHelper<TModel> html, System.Linq.Expressions.Expression<System.Func<TModel, TValue>> expression, string templateName) { throw null; }
        public static System.Web.Mvc.MvcHtmlString EditorFor<TModel, TValue>(this System.Web.Mvc.HtmlHelper<TModel> html, System.Linq.Expressions.Expression<System.Func<TModel, TValue>> expression, string templateName, object additionalViewData) { throw null; }
        public static System.Web.Mvc.MvcHtmlString EditorFor<TModel, TValue>(this System.Web.Mvc.HtmlHelper<TModel> html, System.Linq.Expressions.Expression<System.Func<TModel, TValue>> expression, string templateName, string htmlFieldName) { throw null; }
        public static System.Web.Mvc.MvcHtmlString EditorFor<TModel, TValue>(this System.Web.Mvc.HtmlHelper<TModel> html, System.Linq.Expressions.Expression<System.Func<TModel, TValue>> expression, string templateName, string htmlFieldName, object additionalViewData) { throw null; }
    }
    public static partial class FormExtensions
    {
        public static System.Web.Mvc.Html.MvcForm BeginForm(this System.Web.Mvc.HtmlHelper htmlHelper) { throw null; }
        public static System.Web.Mvc.Html.MvcForm BeginForm(this System.Web.Mvc.HtmlHelper htmlHelper, object routeValues) { throw null; }
        public static System.Web.Mvc.Html.MvcForm BeginForm(this System.Web.Mvc.HtmlHelper htmlHelper, string actionName, string controllerName) { throw null; }
        public static System.Web.Mvc.Html.MvcForm BeginForm(this System.Web.Mvc.HtmlHelper htmlHelper, string actionName, string controllerName, object routeValues) { throw null; }
        public static System.Web.Mvc.Html.MvcForm BeginForm(this System.Web.Mvc.HtmlHelper htmlHelper, string actionName, string controllerName, object routeValues, System.Web.Mvc.FormMethod method) { throw null; }
        public static System.Web.Mvc.Html.MvcForm BeginForm(this System.Web.Mvc.HtmlHelper htmlHelper, string actionName, string controllerName, object routeValues, System.Web.Mvc.FormMethod method, object htmlAttributes) { throw null; }
        public static System.Web.Mvc.Html.MvcForm BeginForm(this System.Web.Mvc.HtmlHelper htmlHelper, string actionName, string controllerName, System.Web.Mvc.FormMethod method) { throw null; }
        public static System.Web.Mvc.Html.MvcForm BeginForm(this System.Web.Mvc.HtmlHelper htmlHelper, string actionName, string controllerName, System.Web.Mvc.FormMethod method, System.Collections.Generic.IDictionary<string, object> htmlAttributes) { throw null; }
        public static System.Web.Mvc.Html.MvcForm BeginForm(this System.Web.Mvc.HtmlHelper htmlHelper, string actionName, string controllerName, System.Web.Mvc.FormMethod method, object htmlAttributes) { throw null; }
        public static System.Web.Mvc.Html.MvcForm BeginForm(this System.Web.Mvc.HtmlHelper htmlHelper, string actionName, string controllerName, System.Web.Routing.RouteValueDictionary routeValues) { throw null; }
        public static System.Web.Mvc.Html.MvcForm BeginForm(this System.Web.Mvc.HtmlHelper htmlHelper, string actionName, string controllerName, System.Web.Routing.RouteValueDictionary routeValues, System.Web.Mvc.FormMethod method) { throw null; }
        public static System.Web.Mvc.Html.MvcForm BeginForm(this System.Web.Mvc.HtmlHelper htmlHelper, string actionName, string controllerName, System.Web.Routing.RouteValueDictionary routeValues, System.Web.Mvc.FormMethod method, System.Collections.Generic.IDictionary<string, object> htmlAttributes) { throw null; }
        public static System.Web.Mvc.Html.MvcForm BeginForm(this System.Web.Mvc.HtmlHelper htmlHelper, System.Web.Routing.RouteValueDictionary routeValues) { throw null; }
        public static System.Web.Mvc.Html.MvcForm BeginRouteForm(this System.Web.Mvc.HtmlHelper htmlHelper, object routeValues) { throw null; }
        public static System.Web.Mvc.Html.MvcForm BeginRouteForm(this System.Web.Mvc.HtmlHelper htmlHelper, string routeName) { throw null; }
        public static System.Web.Mvc.Html.MvcForm BeginRouteForm(this System.Web.Mvc.HtmlHelper htmlHelper, string routeName, object routeValues) { throw null; }
        public static System.Web.Mvc.Html.MvcForm BeginRouteForm(this System.Web.Mvc.HtmlHelper htmlHelper, string routeName, object routeValues, System.Web.Mvc.FormMethod method) { throw null; }
        public static System.Web.Mvc.Html.MvcForm BeginRouteForm(this System.Web.Mvc.HtmlHelper htmlHelper, string routeName, object routeValues, System.Web.Mvc.FormMethod method, object htmlAttributes) { throw null; }
        public static System.Web.Mvc.Html.MvcForm BeginRouteForm(this System.Web.Mvc.HtmlHelper htmlHelper, string routeName, System.Web.Mvc.FormMethod method) { throw null; }
        public static System.Web.Mvc.Html.MvcForm BeginRouteForm(this System.Web.Mvc.HtmlHelper htmlHelper, string routeName, System.Web.Mvc.FormMethod method, System.Collections.Generic.IDictionary<string, object> htmlAttributes) { throw null; }
        public static System.Web.Mvc.Html.MvcForm BeginRouteForm(this System.Web.Mvc.HtmlHelper htmlHelper, string routeName, System.Web.Mvc.FormMethod method, object htmlAttributes) { throw null; }
        public static System.Web.Mvc.Html.MvcForm BeginRouteForm(this System.Web.Mvc.HtmlHelper htmlHelper, string routeName, System.Web.Routing.RouteValueDictionary routeValues) { throw null; }
        public static System.Web.Mvc.Html.MvcForm BeginRouteForm(this System.Web.Mvc.HtmlHelper htmlHelper, string routeName, System.Web.Routing.RouteValueDictionary routeValues, System.Web.Mvc.FormMethod method) { throw null; }
        public static System.Web.Mvc.Html.MvcForm BeginRouteForm(this System.Web.Mvc.HtmlHelper htmlHelper, string routeName, System.Web.Routing.RouteValueDictionary routeValues, System.Web.Mvc.FormMethod method, System.Collections.Generic.IDictionary<string, object> htmlAttributes) { throw null; }
        public static System.Web.Mvc.Html.MvcForm BeginRouteForm(this System.Web.Mvc.HtmlHelper htmlHelper, System.Web.Routing.RouteValueDictionary routeValues) { throw null; }
        public static void EndForm(this System.Web.Mvc.HtmlHelper htmlHelper) { }
    }
    public static partial class InputExtensions
    {
        public static System.Web.Mvc.MvcHtmlString CheckBox(this System.Web.Mvc.HtmlHelper htmlHelper, string name) { throw null; }
        public static System.Web.Mvc.MvcHtmlString CheckBox(this System.Web.Mvc.HtmlHelper htmlHelper, string name, bool isChecked) { throw null; }
        public static System.Web.Mvc.MvcHtmlString CheckBox(this System.Web.Mvc.HtmlHelper htmlHelper, string name, bool isChecked, System.Collections.Generic.IDictionary<string, object> htmlAttributes) { throw null; }
        public static System.Web.Mvc.MvcHtmlString CheckBox(this System.Web.Mvc.HtmlHelper htmlHelper, string name, bool isChecked, object htmlAttributes) { throw null; }
        public static System.Web.Mvc.MvcHtmlString CheckBox(this System.Web.Mvc.HtmlHelper htmlHelper, string name, System.Collections.Generic.IDictionary<string, object> htmlAttributes) { throw null; }
        public static System.Web.Mvc.MvcHtmlString CheckBox(this System.Web.Mvc.HtmlHelper htmlHelper, string name, object htmlAttributes) { throw null; }
        public static System.Web.Mvc.MvcHtmlString CheckBoxFor<TModel>(this System.Web.Mvc.HtmlHelper<TModel> htmlHelper, System.Linq.Expressions.Expression<System.Func<TModel, bool>> expression) { throw null; }
        public static System.Web.Mvc.MvcHtmlString CheckBoxFor<TModel>(this System.Web.Mvc.HtmlHelper<TModel> htmlHelper, System.Linq.Expressions.Expression<System.Func<TModel, bool>> expression, System.Collections.Generic.IDictionary<string, object> htmlAttributes) { throw null; }
        public static System.Web.Mvc.MvcHtmlString CheckBoxFor<TModel>(this System.Web.Mvc.HtmlHelper<TModel> htmlHelper, System.Linq.Expressions.Expression<System.Func<TModel, bool>> expression, object htmlAttributes) { throw null; }
        public static System.Web.Mvc.MvcHtmlString Hidden(this System.Web.Mvc.HtmlHelper htmlHelper, string name) { throw null; }
        public static System.Web.Mvc.MvcHtmlString Hidden(this System.Web.Mvc.HtmlHelper htmlHelper, string name, object value) { throw null; }
        public static System.Web.Mvc.MvcHtmlString Hidden(this System.Web.Mvc.HtmlHelper htmlHelper, string name, object value, System.Collections.Generic.IDictionary<string, object> htmlAttributes) { throw null; }
        public static System.Web.Mvc.MvcHtmlString Hidden(this System.Web.Mvc.HtmlHelper htmlHelper, string name, object value, object htmlAttributes) { throw null; }
        public static System.Web.Mvc.MvcHtmlString HiddenFor<TModel, TProperty>(this System.Web.Mvc.HtmlHelper<TModel> htmlHelper, System.Linq.Expressions.Expression<System.Func<TModel, TProperty>> expression) { throw null; }
        public static System.Web.Mvc.MvcHtmlString HiddenFor<TModel, TProperty>(this System.Web.Mvc.HtmlHelper<TModel> htmlHelper, System.Linq.Expressions.Expression<System.Func<TModel, TProperty>> expression, System.Collections.Generic.IDictionary<string, object> htmlAttributes) { throw null; }
        public static System.Web.Mvc.MvcHtmlString HiddenFor<TModel, TProperty>(this System.Web.Mvc.HtmlHelper<TModel> htmlHelper, System.Linq.Expressions.Expression<System.Func<TModel, TProperty>> expression, object htmlAttributes) { throw null; }
        public static System.Web.Mvc.MvcHtmlString Password(this System.Web.Mvc.HtmlHelper htmlHelper, string name) { throw null; }
        public static System.Web.Mvc.MvcHtmlString Password(this System.Web.Mvc.HtmlHelper htmlHelper, string name, object value) { throw null; }
        public static System.Web.Mvc.MvcHtmlString Password(this System.Web.Mvc.HtmlHelper htmlHelper, string name, object value, System.Collections.Generic.IDictionary<string, object> htmlAttributes) { throw null; }
        public static System.Web.Mvc.MvcHtmlString Password(this System.Web.Mvc.HtmlHelper htmlHelper, string name, object value, object htmlAttributes) { throw null; }
        public static System.Web.Mvc.MvcHtmlString PasswordFor<TModel, TProperty>(this System.Web.Mvc.HtmlHelper<TModel> htmlHelper, System.Linq.Expressions.Expression<System.Func<TModel, TProperty>> expression) { throw null; }
        public static System.Web.Mvc.MvcHtmlString PasswordFor<TModel, TProperty>(this System.Web.Mvc.HtmlHelper<TModel> htmlHelper, System.Linq.Expressions.Expression<System.Func<TModel, TProperty>> expression, System.Collections.Generic.IDictionary<string, object> htmlAttributes) { throw null; }
        public static System.Web.Mvc.MvcHtmlString PasswordFor<TModel, TProperty>(this System.Web.Mvc.HtmlHelper<TModel> htmlHelper, System.Linq.Expressions.Expression<System.Func<TModel, TProperty>> expression, object htmlAttributes) { throw null; }
        public static System.Web.Mvc.MvcHtmlString RadioButton(this System.Web.Mvc.HtmlHelper htmlHelper, string name, object value) { throw null; }
        public static System.Web.Mvc.MvcHtmlString RadioButton(this System.Web.Mvc.HtmlHelper htmlHelper, string name, object value, bool isChecked) { throw null; }
        public static System.Web.Mvc.MvcHtmlString RadioButton(this System.Web.Mvc.HtmlHelper htmlHelper, string name, object value, bool isChecked, System.Collections.Generic.IDictionary<string, object> htmlAttributes) { throw null; }
        public static System.Web.Mvc.MvcHtmlString RadioButton(this System.Web.Mvc.HtmlHelper htmlHelper, string name, object value, bool isChecked, object htmlAttributes) { throw null; }
        public static System.Web.Mvc.MvcHtmlString RadioButton(this System.Web.Mvc.HtmlHelper htmlHelper, string name, object value, System.Collections.Generic.IDictionary<string, object> htmlAttributes) { throw null; }
        public static System.Web.Mvc.MvcHtmlString RadioButton(this System.Web.Mvc.HtmlHelper htmlHelper, string name, object value, object htmlAttributes) { throw null; }
        public static System.Web.Mvc.MvcHtmlString RadioButtonFor<TModel, TProperty>(this System.Web.Mvc.HtmlHelper<TModel> htmlHelper, System.Linq.Expressions.Expression<System.Func<TModel, TProperty>> expression, object value) { throw null; }
        public static System.Web.Mvc.MvcHtmlString RadioButtonFor<TModel, TProperty>(this System.Web.Mvc.HtmlHelper<TModel> htmlHelper, System.Linq.Expressions.Expression<System.Func<TModel, TProperty>> expression, object value, System.Collections.Generic.IDictionary<string, object> htmlAttributes) { throw null; }
        public static System.Web.Mvc.MvcHtmlString RadioButtonFor<TModel, TProperty>(this System.Web.Mvc.HtmlHelper<TModel> htmlHelper, System.Linq.Expressions.Expression<System.Func<TModel, TProperty>> expression, object value, object htmlAttributes) { throw null; }
        public static System.Web.Mvc.MvcHtmlString TextBox(this System.Web.Mvc.HtmlHelper htmlHelper, string name) { throw null; }
        public static System.Web.Mvc.MvcHtmlString TextBox(this System.Web.Mvc.HtmlHelper htmlHelper, string name, object value) { throw null; }
        public static System.Web.Mvc.MvcHtmlString TextBox(this System.Web.Mvc.HtmlHelper htmlHelper, string name, object value, System.Collections.Generic.IDictionary<string, object> htmlAttributes) { throw null; }
        public static System.Web.Mvc.MvcHtmlString TextBox(this System.Web.Mvc.HtmlHelper htmlHelper, string name, object value, object htmlAttributes) { throw null; }
        public static System.Web.Mvc.MvcHtmlString TextBoxFor<TModel, TProperty>(this System.Web.Mvc.HtmlHelper<TModel> htmlHelper, System.Linq.Expressions.Expression<System.Func<TModel, TProperty>> expression) { throw null; }
        public static System.Web.Mvc.MvcHtmlString TextBoxFor<TModel, TProperty>(this System.Web.Mvc.HtmlHelper<TModel> htmlHelper, System.Linq.Expressions.Expression<System.Func<TModel, TProperty>> expression, System.Collections.Generic.IDictionary<string, object> htmlAttributes) { throw null; }
        public static System.Web.Mvc.MvcHtmlString TextBoxFor<TModel, TProperty>(this System.Web.Mvc.HtmlHelper<TModel> htmlHelper, System.Linq.Expressions.Expression<System.Func<TModel, TProperty>> expression, object htmlAttributes) { throw null; }
    }
    public static partial class LabelExtensions
    {
        public static System.Web.Mvc.MvcHtmlString Label(this System.Web.Mvc.HtmlHelper html, string expression) { throw null; }
        public static System.Web.Mvc.MvcHtmlString Label(this System.Web.Mvc.HtmlHelper html, string expression, string labelText) { throw null; }
        public static System.Web.Mvc.MvcHtmlString LabelForModel(this System.Web.Mvc.HtmlHelper html) { throw null; }
        public static System.Web.Mvc.MvcHtmlString LabelForModel(this System.Web.Mvc.HtmlHelper html, string labelText) { throw null; }
        public static System.Web.Mvc.MvcHtmlString LabelFor<TModel, TValue>(this System.Web.Mvc.HtmlHelper<TModel> html, System.Linq.Expressions.Expression<System.Func<TModel, TValue>> expression) { throw null; }
        public static System.Web.Mvc.MvcHtmlString LabelFor<TModel, TValue>(this System.Web.Mvc.HtmlHelper<TModel> html, System.Linq.Expressions.Expression<System.Func<TModel, TValue>> expression, string labelText) { throw null; }
    }
    public static partial class LinkExtensions
    {
        public static System.Web.Mvc.MvcHtmlString ActionLink(this System.Web.Mvc.HtmlHelper htmlHelper, string linkText, string actionName) { throw null; }
        public static System.Web.Mvc.MvcHtmlString ActionLink(this System.Web.Mvc.HtmlHelper htmlHelper, string linkText, string actionName, object routeValues) { throw null; }
        public static System.Web.Mvc.MvcHtmlString ActionLink(this System.Web.Mvc.HtmlHelper htmlHelper, string linkText, string actionName, object routeValues, object htmlAttributes) { throw null; }
        public static System.Web.Mvc.MvcHtmlString ActionLink(this System.Web.Mvc.HtmlHelper htmlHelper, string linkText, string actionName, string controllerName) { throw null; }
        public static System.Web.Mvc.MvcHtmlString ActionLink(this System.Web.Mvc.HtmlHelper htmlHelper, string linkText, string actionName, string controllerName, object routeValues, object htmlAttributes) { throw null; }
        public static System.Web.Mvc.MvcHtmlString ActionLink(this System.Web.Mvc.HtmlHelper htmlHelper, string linkText, string actionName, string controllerName, string protocol, string hostName, string fragment, object routeValues, object htmlAttributes) { throw null; }
        public static System.Web.Mvc.MvcHtmlString ActionLink(this System.Web.Mvc.HtmlHelper htmlHelper, string linkText, string actionName, string controllerName, string protocol, string hostName, string fragment, System.Web.Routing.RouteValueDictionary routeValues, System.Collections.Generic.IDictionary<string, object> htmlAttributes) { throw null; }
        public static System.Web.Mvc.MvcHtmlString ActionLink(this System.Web.Mvc.HtmlHelper htmlHelper, string linkText, string actionName, string controllerName, System.Web.Routing.RouteValueDictionary routeValues, System.Collections.Generic.IDictionary<string, object> htmlAttributes) { throw null; }
        public static System.Web.Mvc.MvcHtmlString ActionLink(this System.Web.Mvc.HtmlHelper htmlHelper, string linkText, string actionName, System.Web.Routing.RouteValueDictionary routeValues) { throw null; }
        public static System.Web.Mvc.MvcHtmlString ActionLink(this System.Web.Mvc.HtmlHelper htmlHelper, string linkText, string actionName, System.Web.Routing.RouteValueDictionary routeValues, System.Collections.Generic.IDictionary<string, object> htmlAttributes) { throw null; }
        public static System.Web.Mvc.MvcHtmlString RouteLink(this System.Web.Mvc.HtmlHelper htmlHelper, string linkText, object routeValues) { throw null; }
        public static System.Web.Mvc.MvcHtmlString RouteLink(this System.Web.Mvc.HtmlHelper htmlHelper, string linkText, object routeValues, object htmlAttributes) { throw null; }
        public static System.Web.Mvc.MvcHtmlString RouteLink(this System.Web.Mvc.HtmlHelper htmlHelper, string linkText, string routeName) { throw null; }
        public static System.Web.Mvc.MvcHtmlString RouteLink(this System.Web.Mvc.HtmlHelper htmlHelper, string linkText, string routeName, object routeValues) { throw null; }
        public static System.Web.Mvc.MvcHtmlString RouteLink(this System.Web.Mvc.HtmlHelper htmlHelper, string linkText, string routeName, object routeValues, object htmlAttributes) { throw null; }
        public static System.Web.Mvc.MvcHtmlString RouteLink(this System.Web.Mvc.HtmlHelper htmlHelper, string linkText, string routeName, string protocol, string hostName, string fragment, object routeValues, object htmlAttributes) { throw null; }
        public static System.Web.Mvc.MvcHtmlString RouteLink(this System.Web.Mvc.HtmlHelper htmlHelper, string linkText, string routeName, string protocol, string hostName, string fragment, System.Web.Routing.RouteValueDictionary routeValues, System.Collections.Generic.IDictionary<string, object> htmlAttributes) { throw null; }
        public static System.Web.Mvc.MvcHtmlString RouteLink(this System.Web.Mvc.HtmlHelper htmlHelper, string linkText, string routeName, System.Web.Routing.RouteValueDictionary routeValues) { throw null; }
        public static System.Web.Mvc.MvcHtmlString RouteLink(this System.Web.Mvc.HtmlHelper htmlHelper, string linkText, string routeName, System.Web.Routing.RouteValueDictionary routeValues, System.Collections.Generic.IDictionary<string, object> htmlAttributes) { throw null; }
        public static System.Web.Mvc.MvcHtmlString RouteLink(this System.Web.Mvc.HtmlHelper htmlHelper, string linkText, System.Web.Routing.RouteValueDictionary routeValues) { throw null; }
        public static System.Web.Mvc.MvcHtmlString RouteLink(this System.Web.Mvc.HtmlHelper htmlHelper, string linkText, System.Web.Routing.RouteValueDictionary routeValues, System.Collections.Generic.IDictionary<string, object> htmlAttributes) { throw null; }
    }
    public partial class MvcForm : System.IDisposable
    {
        [System.ObsoleteAttribute("The recommended alternative is the constructor MvcForm(ViewContext viewContext).", true)]
        public MvcForm(System.Web.HttpResponseBase httpResponse) { }
        public MvcForm(System.Web.Mvc.ViewContext viewContext) { }
        public void Dispose() { }
        protected virtual void Dispose(bool disposing) { }
        public void EndForm() { }
    }
    public static partial class PartialExtensions
    {
        public static System.Web.Mvc.MvcHtmlString Partial(this System.Web.Mvc.HtmlHelper htmlHelper, string partialViewName) { throw null; }
        public static System.Web.Mvc.MvcHtmlString Partial(this System.Web.Mvc.HtmlHelper htmlHelper, string partialViewName, object model) { throw null; }
        public static System.Web.Mvc.MvcHtmlString Partial(this System.Web.Mvc.HtmlHelper htmlHelper, string partialViewName, object model, System.Web.Mvc.ViewDataDictionary viewData) { throw null; }
        public static System.Web.Mvc.MvcHtmlString Partial(this System.Web.Mvc.HtmlHelper htmlHelper, string partialViewName, System.Web.Mvc.ViewDataDictionary viewData) { throw null; }
    }
    public static partial class RenderPartialExtensions
    {
        public static void RenderPartial(this System.Web.Mvc.HtmlHelper htmlHelper, string partialViewName) { }
        public static void RenderPartial(this System.Web.Mvc.HtmlHelper htmlHelper, string partialViewName, object model) { }
        public static void RenderPartial(this System.Web.Mvc.HtmlHelper htmlHelper, string partialViewName, object model, System.Web.Mvc.ViewDataDictionary viewData) { }
        public static void RenderPartial(this System.Web.Mvc.HtmlHelper htmlHelper, string partialViewName, System.Web.Mvc.ViewDataDictionary viewData) { }
    }
    public static partial class SelectExtensions
    {
        public static System.Web.Mvc.MvcHtmlString DropDownList(this System.Web.Mvc.HtmlHelper htmlHelper, string name) { throw null; }
        public static System.Web.Mvc.MvcHtmlString DropDownList(this System.Web.Mvc.HtmlHelper htmlHelper, string name, System.Collections.Generic.IEnumerable<System.Web.Mvc.SelectListItem> selectList) { throw null; }
        public static System.Web.Mvc.MvcHtmlString DropDownList(this System.Web.Mvc.HtmlHelper htmlHelper, string name, System.Collections.Generic.IEnumerable<System.Web.Mvc.SelectListItem> selectList, System.Collections.Generic.IDictionary<string, object> htmlAttributes) { throw null; }
        public static System.Web.Mvc.MvcHtmlString DropDownList(this System.Web.Mvc.HtmlHelper htmlHelper, string name, System.Collections.Generic.IEnumerable<System.Web.Mvc.SelectListItem> selectList, object htmlAttributes) { throw null; }
        public static System.Web.Mvc.MvcHtmlString DropDownList(this System.Web.Mvc.HtmlHelper htmlHelper, string name, System.Collections.Generic.IEnumerable<System.Web.Mvc.SelectListItem> selectList, string optionLabel) { throw null; }
        public static System.Web.Mvc.MvcHtmlString DropDownList(this System.Web.Mvc.HtmlHelper htmlHelper, string name, System.Collections.Generic.IEnumerable<System.Web.Mvc.SelectListItem> selectList, string optionLabel, System.Collections.Generic.IDictionary<string, object> htmlAttributes) { throw null; }
        public static System.Web.Mvc.MvcHtmlString DropDownList(this System.Web.Mvc.HtmlHelper htmlHelper, string name, System.Collections.Generic.IEnumerable<System.Web.Mvc.SelectListItem> selectList, string optionLabel, object htmlAttributes) { throw null; }
        public static System.Web.Mvc.MvcHtmlString DropDownList(this System.Web.Mvc.HtmlHelper htmlHelper, string name, string optionLabel) { throw null; }
        public static System.Web.Mvc.MvcHtmlString DropDownListFor<TModel, TProperty>(this System.Web.Mvc.HtmlHelper<TModel> htmlHelper, System.Linq.Expressions.Expression<System.Func<TModel, TProperty>> expression, System.Collections.Generic.IEnumerable<System.Web.Mvc.SelectListItem> selectList) { throw null; }
        public static System.Web.Mvc.MvcHtmlString DropDownListFor<TModel, TProperty>(this System.Web.Mvc.HtmlHelper<TModel> htmlHelper, System.Linq.Expressions.Expression<System.Func<TModel, TProperty>> expression, System.Collections.Generic.IEnumerable<System.Web.Mvc.SelectListItem> selectList, System.Collections.Generic.IDictionary<string, object> htmlAttributes) { throw null; }
        public static System.Web.Mvc.MvcHtmlString DropDownListFor<TModel, TProperty>(this System.Web.Mvc.HtmlHelper<TModel> htmlHelper, System.Linq.Expressions.Expression<System.Func<TModel, TProperty>> expression, System.Collections.Generic.IEnumerable<System.Web.Mvc.SelectListItem> selectList, object htmlAttributes) { throw null; }
        public static System.Web.Mvc.MvcHtmlString DropDownListFor<TModel, TProperty>(this System.Web.Mvc.HtmlHelper<TModel> htmlHelper, System.Linq.Expressions.Expression<System.Func<TModel, TProperty>> expression, System.Collections.Generic.IEnumerable<System.Web.Mvc.SelectListItem> selectList, string optionLabel) { throw null; }
        public static System.Web.Mvc.MvcHtmlString DropDownListFor<TModel, TProperty>(this System.Web.Mvc.HtmlHelper<TModel> htmlHelper, System.Linq.Expressions.Expression<System.Func<TModel, TProperty>> expression, System.Collections.Generic.IEnumerable<System.Web.Mvc.SelectListItem> selectList, string optionLabel, System.Collections.Generic.IDictionary<string, object> htmlAttributes) { throw null; }
        public static System.Web.Mvc.MvcHtmlString DropDownListFor<TModel, TProperty>(this System.Web.Mvc.HtmlHelper<TModel> htmlHelper, System.Linq.Expressions.Expression<System.Func<TModel, TProperty>> expression, System.Collections.Generic.IEnumerable<System.Web.Mvc.SelectListItem> selectList, string optionLabel, object htmlAttributes) { throw null; }
        public static System.Web.Mvc.MvcHtmlString ListBox(this System.Web.Mvc.HtmlHelper htmlHelper, string name) { throw null; }
        public static System.Web.Mvc.MvcHtmlString ListBox(this System.Web.Mvc.HtmlHelper htmlHelper, string name, System.Collections.Generic.IEnumerable<System.Web.Mvc.SelectListItem> selectList) { throw null; }
        public static System.Web.Mvc.MvcHtmlString ListBox(this System.Web.Mvc.HtmlHelper htmlHelper, string name, System.Collections.Generic.IEnumerable<System.Web.Mvc.SelectListItem> selectList, System.Collections.Generic.IDictionary<string, object> htmlAttributes) { throw null; }
        public static System.Web.Mvc.MvcHtmlString ListBox(this System.Web.Mvc.HtmlHelper htmlHelper, string name, System.Collections.Generic.IEnumerable<System.Web.Mvc.SelectListItem> selectList, object htmlAttributes) { throw null; }
        public static System.Web.Mvc.MvcHtmlString ListBoxFor<TModel, TProperty>(this System.Web.Mvc.HtmlHelper<TModel> htmlHelper, System.Linq.Expressions.Expression<System.Func<TModel, TProperty>> expression, System.Collections.Generic.IEnumerable<System.Web.Mvc.SelectListItem> selectList) { throw null; }
        public static System.Web.Mvc.MvcHtmlString ListBoxFor<TModel, TProperty>(this System.Web.Mvc.HtmlHelper<TModel> htmlHelper, System.Linq.Expressions.Expression<System.Func<TModel, TProperty>> expression, System.Collections.Generic.IEnumerable<System.Web.Mvc.SelectListItem> selectList, System.Collections.Generic.IDictionary<string, object> htmlAttributes) { throw null; }
        public static System.Web.Mvc.MvcHtmlString ListBoxFor<TModel, TProperty>(this System.Web.Mvc.HtmlHelper<TModel> htmlHelper, System.Linq.Expressions.Expression<System.Func<TModel, TProperty>> expression, System.Collections.Generic.IEnumerable<System.Web.Mvc.SelectListItem> selectList, object htmlAttributes) { throw null; }
    }
    public static partial class TextAreaExtensions
    {
        public static System.Web.Mvc.MvcHtmlString TextArea(this System.Web.Mvc.HtmlHelper htmlHelper, string name) { throw null; }
        public static System.Web.Mvc.MvcHtmlString TextArea(this System.Web.Mvc.HtmlHelper htmlHelper, string name, System.Collections.Generic.IDictionary<string, object> htmlAttributes) { throw null; }
        public static System.Web.Mvc.MvcHtmlString TextArea(this System.Web.Mvc.HtmlHelper htmlHelper, string name, object htmlAttributes) { throw null; }
        public static System.Web.Mvc.MvcHtmlString TextArea(this System.Web.Mvc.HtmlHelper htmlHelper, string name, string value) { throw null; }
        public static System.Web.Mvc.MvcHtmlString TextArea(this System.Web.Mvc.HtmlHelper htmlHelper, string name, string value, System.Collections.Generic.IDictionary<string, object> htmlAttributes) { throw null; }
        public static System.Web.Mvc.MvcHtmlString TextArea(this System.Web.Mvc.HtmlHelper htmlHelper, string name, string value, int rows, int columns, System.Collections.Generic.IDictionary<string, object> htmlAttributes) { throw null; }
        public static System.Web.Mvc.MvcHtmlString TextArea(this System.Web.Mvc.HtmlHelper htmlHelper, string name, string value, int rows, int columns, object htmlAttributes) { throw null; }
        public static System.Web.Mvc.MvcHtmlString TextArea(this System.Web.Mvc.HtmlHelper htmlHelper, string name, string value, object htmlAttributes) { throw null; }
        public static System.Web.Mvc.MvcHtmlString TextAreaFor<TModel, TProperty>(this System.Web.Mvc.HtmlHelper<TModel> htmlHelper, System.Linq.Expressions.Expression<System.Func<TModel, TProperty>> expression) { throw null; }
        public static System.Web.Mvc.MvcHtmlString TextAreaFor<TModel, TProperty>(this System.Web.Mvc.HtmlHelper<TModel> htmlHelper, System.Linq.Expressions.Expression<System.Func<TModel, TProperty>> expression, System.Collections.Generic.IDictionary<string, object> htmlAttributes) { throw null; }
        public static System.Web.Mvc.MvcHtmlString TextAreaFor<TModel, TProperty>(this System.Web.Mvc.HtmlHelper<TModel> htmlHelper, System.Linq.Expressions.Expression<System.Func<TModel, TProperty>> expression, int rows, int columns, System.Collections.Generic.IDictionary<string, object> htmlAttributes) { throw null; }
        public static System.Web.Mvc.MvcHtmlString TextAreaFor<TModel, TProperty>(this System.Web.Mvc.HtmlHelper<TModel> htmlHelper, System.Linq.Expressions.Expression<System.Func<TModel, TProperty>> expression, int rows, int columns, object htmlAttributes) { throw null; }
        public static System.Web.Mvc.MvcHtmlString TextAreaFor<TModel, TProperty>(this System.Web.Mvc.HtmlHelper<TModel> htmlHelper, System.Linq.Expressions.Expression<System.Func<TModel, TProperty>> expression, object htmlAttributes) { throw null; }
    }
    public static partial class ValidationExtensions
    {
        public static string ResourceClassKey { get { throw null; } set { } }
        public static void Validate(this System.Web.Mvc.HtmlHelper htmlHelper, string modelName) { }
        public static void ValidateFor<TModel, TProperty>(this System.Web.Mvc.HtmlHelper<TModel> htmlHelper, System.Linq.Expressions.Expression<System.Func<TModel, TProperty>> expression) { }
        public static System.Web.Mvc.MvcHtmlString ValidationMessage(this System.Web.Mvc.HtmlHelper htmlHelper, string modelName) { throw null; }
        public static System.Web.Mvc.MvcHtmlString ValidationMessage(this System.Web.Mvc.HtmlHelper htmlHelper, string modelName, System.Collections.Generic.IDictionary<string, object> htmlAttributes) { throw null; }
        public static System.Web.Mvc.MvcHtmlString ValidationMessage(this System.Web.Mvc.HtmlHelper htmlHelper, string modelName, object htmlAttributes) { throw null; }
        public static System.Web.Mvc.MvcHtmlString ValidationMessage(this System.Web.Mvc.HtmlHelper htmlHelper, string modelName, string validationMessage) { throw null; }
        public static System.Web.Mvc.MvcHtmlString ValidationMessage(this System.Web.Mvc.HtmlHelper htmlHelper, string modelName, string validationMessage, System.Collections.Generic.IDictionary<string, object> htmlAttributes) { throw null; }
        public static System.Web.Mvc.MvcHtmlString ValidationMessage(this System.Web.Mvc.HtmlHelper htmlHelper, string modelName, string validationMessage, object htmlAttributes) { throw null; }
        public static System.Web.Mvc.MvcHtmlString ValidationMessageFor<TModel, TProperty>(this System.Web.Mvc.HtmlHelper<TModel> htmlHelper, System.Linq.Expressions.Expression<System.Func<TModel, TProperty>> expression) { throw null; }
        public static System.Web.Mvc.MvcHtmlString ValidationMessageFor<TModel, TProperty>(this System.Web.Mvc.HtmlHelper<TModel> htmlHelper, System.Linq.Expressions.Expression<System.Func<TModel, TProperty>> expression, string validationMessage) { throw null; }
        public static System.Web.Mvc.MvcHtmlString ValidationMessageFor<TModel, TProperty>(this System.Web.Mvc.HtmlHelper<TModel> htmlHelper, System.Linq.Expressions.Expression<System.Func<TModel, TProperty>> expression, string validationMessage, System.Collections.Generic.IDictionary<string, object> htmlAttributes) { throw null; }
        public static System.Web.Mvc.MvcHtmlString ValidationMessageFor<TModel, TProperty>(this System.Web.Mvc.HtmlHelper<TModel> htmlHelper, System.Linq.Expressions.Expression<System.Func<TModel, TProperty>> expression, string validationMessage, object htmlAttributes) { throw null; }
        public static System.Web.Mvc.MvcHtmlString ValidationSummary(this System.Web.Mvc.HtmlHelper htmlHelper) { throw null; }
        public static System.Web.Mvc.MvcHtmlString ValidationSummary(this System.Web.Mvc.HtmlHelper htmlHelper, bool excludePropertyErrors) { throw null; }
        public static System.Web.Mvc.MvcHtmlString ValidationSummary(this System.Web.Mvc.HtmlHelper htmlHelper, bool excludePropertyErrors, string message) { throw null; }
        public static System.Web.Mvc.MvcHtmlString ValidationSummary(this System.Web.Mvc.HtmlHelper htmlHelper, bool excludePropertyErrors, string message, System.Collections.Generic.IDictionary<string, object> htmlAttributes) { throw null; }
        public static System.Web.Mvc.MvcHtmlString ValidationSummary(this System.Web.Mvc.HtmlHelper htmlHelper, bool excludePropertyErrors, string message, object htmlAttributes) { throw null; }
        public static System.Web.Mvc.MvcHtmlString ValidationSummary(this System.Web.Mvc.HtmlHelper htmlHelper, string message) { throw null; }
        public static System.Web.Mvc.MvcHtmlString ValidationSummary(this System.Web.Mvc.HtmlHelper htmlHelper, string message, System.Collections.Generic.IDictionary<string, object> htmlAttributes) { throw null; }
        public static System.Web.Mvc.MvcHtmlString ValidationSummary(this System.Web.Mvc.HtmlHelper htmlHelper, string message, object htmlAttributes) { throw null; }
    }
}
namespace System.Web.Mvc.Razor
{
    public partial class MvcCSharpRazorCodeParser : System.Web.Razor.Parser.CSharpCodeParser
    {
        public MvcCSharpRazorCodeParser() { }
        protected override void InheritsDirective() { }
        protected virtual void ModelDirective() { }
    }
    public partial class MvcVBRazorCodeParser : System.Web.Razor.Parser.VBCodeParser
    {
        public MvcVBRazorCodeParser() { }
        protected override bool InheritsStatement() { throw null; }
        protected virtual bool ModelTypeDirective() { throw null; }
    }
    public partial class MvcWebPageRazorHost : System.Web.WebPages.Razor.WebPageRazorHost
    {
        public MvcWebPageRazorHost(string virtualPath, string physicalPath) : base (default(string)) { }
        public override System.Web.Razor.Generator.RazorCodeGenerator DecorateCodeGenerator(System.Web.Razor.Generator.RazorCodeGenerator incomingCodeGenerator) { throw null; }
        public override System.Web.Razor.Parser.ParserBase DecorateCodeParser(System.Web.Razor.Parser.ParserBase incomingCodeParser) { throw null; }
    }
}
