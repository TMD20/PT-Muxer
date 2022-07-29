// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

[assembly:System.Reflection.AssemblyVersionAttribute("4.0.0.0")]
[assembly:System.CLSCompliantAttribute(true)]
[assembly:System.Diagnostics.DebuggableAttribute((System.Diagnostics.DebuggableAttribute.DebuggingModes)(2))]
[assembly:System.Reflection.AssemblyCompanyAttribute("Mono development team")]
[assembly:System.Reflection.AssemblyCopyrightAttribute("(c) Various Mono authors")]
[assembly:System.Reflection.AssemblyDefaultAliasAttribute("System.Web.DynamicData.dll")]
[assembly:System.Reflection.AssemblyDescriptionAttribute("System.Web.DynamicData.dll")]
[assembly:System.Reflection.AssemblyFileVersionAttribute("4.6.57.0")]
[assembly:System.Reflection.AssemblyInformationalVersionAttribute("4.6.57.0")]
[assembly:System.Reflection.AssemblyProductAttribute("Mono Common Language Infrastructure")]
[assembly:System.Reflection.AssemblyTitleAttribute("System.Web.DynamicData.dll")]
[assembly:System.Resources.NeutralResourcesLanguageAttribute("en-US")]
[assembly:System.Resources.SatelliteContractVersionAttribute("4.0.0.0")]
[assembly:System.Runtime.CompilerServices.CompilationRelaxationsAttribute(8)]
[assembly:System.Runtime.CompilerServices.ReferenceAssemblyAttribute]
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
namespace System.Web.DynamicData
{
    public enum ContainerType
    {
        Item = 1,
        List = 0,
    }
    [System.Web.AspNetHostingPermissionAttribute(System.Security.Permissions.SecurityAction.InheritanceDemand, Level=(System.Web.AspNetHostingPermissionLevel)(200))]
    [System.Web.AspNetHostingPermissionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Level=(System.Web.AspNetHostingPermissionLevel)(200))]
    public partial class ContextConfiguration
    {
        public ContextConfiguration() { }
        public System.Func<System.Type, System.ComponentModel.TypeDescriptionProvider> MetadataProviderFactory { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public bool ScaffoldAllTables { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    }
    public partial class ControlFilterExpression : System.Web.UI.WebControls.Expressions.DataSourceExpression
    {
        public ControlFilterExpression() { }
        public string Column { get { throw null; } set { } }
        public string ControlID { get { throw null; } set { } }
        public override System.Linq.IQueryable GetQueryable(System.Linq.IQueryable source) { throw null; }
        protected override void LoadViewState(object savedState) { }
        protected override object SaveViewState() { throw null; }
        public override void SetContext(System.Web.UI.Control owner, System.Web.HttpContext context, System.Web.UI.WebControls.IQueryableDataSource dataSource) { }
        protected override void TrackViewState() { }
    }
    public partial class DataControlReference
    {
        public DataControlReference() { }
        public string ControlID { get { throw null; } set { } }
        public System.Web.DynamicData.DynamicDataManager Owner { get { throw null; } }
        public override string ToString() { throw null; }
    }
    public partial class DataControlReferenceCollection : System.Collections.ObjectModel.Collection<System.Web.DynamicData.DataControlReference>
    {
        public DataControlReferenceCollection(System.Web.DynamicData.DynamicDataManager owner) { }
        public System.Web.DynamicData.DynamicDataManager Owner { get { throw null; } }
        protected override void InsertItem(int index, System.Web.DynamicData.DataControlReference item) { }
        protected override void RemoveItem(int index) { }
        protected override void SetItem(int index, System.Web.DynamicData.DataControlReference item) { }
    }
    public partial class DefaultAutoFieldGenerator : System.Web.UI.IAutoFieldGenerator
    {
        public DefaultAutoFieldGenerator(System.Web.DynamicData.MetaTable table) { }
        protected virtual System.Web.DynamicData.DynamicField CreateField(System.Web.DynamicData.MetaColumn column, System.Web.DynamicData.ContainerType containerType, System.Web.UI.WebControls.DataBoundControlMode mode) { throw null; }
        public System.Collections.ICollection GenerateFields(System.Web.UI.Control control) { throw null; }
    }
    [System.Drawing.ToolboxBitmapAttribute(typeof(System.Web.DynamicData.DynamicControl), "DynamicControl.ico")]
    [System.Web.AspNetHostingPermissionAttribute(System.Security.Permissions.SecurityAction.InheritanceDemand, Level=(System.Web.AspNetHostingPermissionLevel)(200))]
    [System.Web.AspNetHostingPermissionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Level=(System.Web.AspNetHostingPermissionLevel)(200))]
    public partial class DynamicControl : System.Web.UI.Control, System.Web.DynamicData.IFieldFormattingOptions, System.Web.DynamicData.IFieldTemplateHost, System.Web.UI.IAttributeAccessor
    {
        public DynamicControl() { }
        public DynamicControl(System.Web.UI.WebControls.DataBoundControlMode mode) { }
        [System.ComponentModel.CategoryAttribute("Behavior")]
        [System.ComponentModel.DefaultValueAttribute(false)]
        public bool ApplyFormatInEditMode { get { throw null; } set { } }
        [System.ComponentModel.BrowsableAttribute(false)]
        public System.Web.DynamicData.MetaColumn Column { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        [System.ComponentModel.CategoryAttribute("Behavior")]
        [System.ComponentModel.DefaultValueAttribute(false)]
        public bool ConvertEmptyStringToNull { get { throw null; } set { } }
        [System.ComponentModel.CategoryAttribute("Appearance")]
        [System.ComponentModel.DefaultValueAttribute("")]
        [System.MonoTODOAttribute]
        [System.Web.UI.CssClassPropertyAttribute]
        public virtual string CssClass { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        [System.ComponentModel.CategoryAttribute("Data")]
        [System.ComponentModel.DefaultValueAttribute("")]
        public string DataField { get { throw null; } set { } }
        [System.ComponentModel.CategoryAttribute("Data")]
        [System.ComponentModel.DefaultValueAttribute("")]
        public string DataFormatString { get { throw null; } set { } }
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.MonoTODOAttribute]
        public System.Web.UI.Control FieldTemplate { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        [System.ComponentModel.CategoryAttribute("Behavior")]
        [System.ComponentModel.DefaultValueAttribute(true)]
        public bool HtmlEncode { get { throw null; } set { } }
        [System.MonoTODOAttribute]
        public System.Web.UI.WebControls.DataBoundControlMode Mode { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        [System.ComponentModel.CategoryAttribute("Behavior")]
        [System.ComponentModel.DefaultValueAttribute("")]
        public string NullDisplayText { get { throw null; } set { } }
        System.Web.DynamicData.IFieldFormattingOptions System.Web.DynamicData.IFieldTemplateHost.FormattingOptions { get { throw null; } }
        [System.ComponentModel.BrowsableAttribute(false)]
        public virtual System.Web.DynamicData.MetaTable Table { get { throw null; } }
        [System.ComponentModel.CategoryAttribute("Behavior")]
        [System.ComponentModel.DefaultValueAttribute("")]
        public virtual string UIHint { get { throw null; } set { } }
        [System.ComponentModel.CategoryAttribute("Behavior")]
        [System.ComponentModel.DefaultValueAttribute("")]
        [System.Web.UI.ThemeableAttribute(false)]
        public virtual string ValidationGroup { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public string GetAttribute(string key) { throw null; }
        protected override void OnInit(System.EventArgs e) { }
        protected override void Render(System.Web.UI.HtmlTextWriter writer) { }
        public void SetAttribute(string key, string value) { }
    }
    [System.Web.AspNetHostingPermissionAttribute(System.Security.Permissions.SecurityAction.InheritanceDemand, Level=(System.Web.AspNetHostingPermissionLevel)(200))]
    [System.Web.AspNetHostingPermissionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Level=(System.Web.AspNetHostingPermissionLevel)(200))]
    public partial class DynamicControlParameter : System.Web.UI.WebControls.Parameter, System.Web.DynamicData.IWhereParametersProvider
    {
        [System.MonoTODOAttribute]
        public DynamicControlParameter() { }
        [System.MonoTODOAttribute]
        public DynamicControlParameter(string controlId) { }
        [System.MonoTODOAttribute]
        public string ControlId { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        [System.MonoTODOAttribute]
        protected override object Evaluate(System.Web.HttpContext context, System.Web.UI.Control control) { throw null; }
        [System.MonoTODOAttribute]
        public virtual System.Collections.Generic.IEnumerable<System.Web.UI.WebControls.Parameter> GetWhereParameters(System.Web.DynamicData.IDynamicDataSource dataSource) { throw null; }
    }
    [System.Web.AspNetHostingPermissionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Level=(System.Web.AspNetHostingPermissionLevel)(200))]
    public static partial class DynamicDataExtensions
    {
        public static object ConvertEditedValue(this System.Web.DynamicData.IFieldFormattingOptions formattingOptions, string value) { throw null; }
        [System.MonoTODOAttribute]
        public static void EnablePersistedSelection(this System.Web.UI.WebControls.BaseDataBoundControl dataBoundControl) { }
        [System.MonoTODOAttribute]
        public static void ExpandDynamicWhereParameters(this System.Web.DynamicData.IDynamicDataSource dataSource) { }
        [System.MonoTODOAttribute]
        public static System.Web.DynamicData.IDynamicDataSource FindDataSourceControl(this System.Web.UI.Control current) { throw null; }
        [System.MonoTODOAttribute]
        public static System.Web.UI.Control FindFieldTemplate(this System.Web.UI.Control control, string columnName) { throw null; }
        public static System.Web.DynamicData.MetaTable FindMetaTable(this System.Web.UI.Control current) { throw null; }
        [System.MonoTODOAttribute]
        public static string FormatEditValue(this System.Web.DynamicData.IFieldFormattingOptions formattingOptions, object fieldValue) { throw null; }
        [System.MonoTODOAttribute]
        public static string FormatValue(this System.Web.DynamicData.IFieldFormattingOptions formattingOptions, object fieldValue) { throw null; }
        public static System.Collections.Generic.IDictionary<string, object> GetDefaultValues(this System.Web.UI.IDataSource dataSource) { throw null; }
        public static System.Collections.Generic.IDictionary<string, object> GetDefaultValues(this System.Web.UI.INamingContainer control) { throw null; }
        public static System.Type GetEnumType(this System.Web.DynamicData.MetaColumn column) { throw null; }
        public static System.Web.DynamicData.MetaTable GetMetaTable(this System.Web.UI.IDataSource dataSource) { throw null; }
        public static System.Web.DynamicData.MetaTable GetMetaTable(this System.Web.UI.INamingContainer control) { throw null; }
        public static System.Web.DynamicData.MetaTable GetTable(this System.Web.DynamicData.IDynamicDataSource dataSource) { throw null; }
        [System.MonoTODOAttribute]
        public static void LoadWithForeignKeys(this System.Web.UI.WebControls.LinqDataSource dataSource, System.Type rowType) { }
        public static void LoadWith<TEntity>(this System.Web.UI.WebControls.LinqDataSource dataSource) { }
        public static void SetMetaTable(this System.Web.UI.INamingContainer control, System.Web.DynamicData.MetaTable table) { }
        public static void SetMetaTable(this System.Web.UI.INamingContainer control, System.Web.DynamicData.MetaTable table, System.Collections.Generic.IDictionary<string, object> defaultValues) { }
        public static void SetMetaTable(this System.Web.UI.INamingContainer control, System.Web.DynamicData.MetaTable table, object defaultValues) { }
        public static bool TryGetMetaTable(this System.Web.UI.IDataSource dataSource, out System.Web.DynamicData.MetaTable table) { table = default(System.Web.DynamicData.MetaTable); throw null; }
        public static bool TryGetMetaTable(this System.Web.UI.INamingContainer control, out System.Web.DynamicData.MetaTable table) { table = default(System.Web.DynamicData.MetaTable); throw null; }
    }
    [System.Drawing.ToolboxBitmapAttribute(typeof(System.Web.DynamicData.DynamicDataManager), "DynamicDataManager.ico")]
    [System.Web.UI.NonVisualControlAttribute]
    [System.Web.UI.ParseChildrenAttribute(true)]
    [System.Web.UI.PersistChildrenAttribute(false)]
    [System.Web.AspNetHostingPermissionAttribute(System.Security.Permissions.SecurityAction.InheritanceDemand, Level=(System.Web.AspNetHostingPermissionLevel)(200))]
    [System.Web.AspNetHostingPermissionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Level=(System.Web.AspNetHostingPermissionLevel)(200))]
    public partial class DynamicDataManager : System.Web.UI.Control
    {
        public DynamicDataManager() { }
        public bool AutoLoadForeignKeys { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public override string ClientID { get { throw null; } }
        public override System.Web.UI.ClientIDMode ClientIDMode { get { throw null; } set { } }
        public System.Web.DynamicData.DataControlReferenceCollection DataControls { get { throw null; } }
        [System.ComponentModel.BrowsableAttribute(false)]
        public override bool Visible { get { throw null; } set { } }
        protected override void OnInit(System.EventArgs e) { }
        protected override void OnLoad(System.EventArgs e) { }
        public void RegisterControl(System.Web.UI.Control control) { }
        public void RegisterControl(System.Web.UI.Control control, bool setSelectionFromUrl) { }
    }
    [System.Web.AspNetHostingPermissionAttribute(System.Security.Permissions.SecurityAction.InheritanceDemand, Level=(System.Web.AspNetHostingPermissionLevel)(200))]
    [System.Web.AspNetHostingPermissionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Level=(System.Web.AspNetHostingPermissionLevel)(200))]
    public partial class DynamicDataRoute : System.Web.Routing.Route
    {
        public DynamicDataRoute(string url) : base (default(string), default(System.Web.Routing.IRouteHandler)) { }
        public string Action { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public System.Web.DynamicData.MetaModel Model { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public new System.Web.DynamicData.DynamicDataRouteHandler RouteHandler { get { throw null; } set { } }
        public string Table { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public string ViewName { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public string GetActionFromRouteData(System.Web.Routing.RouteData routeData) { throw null; }
        public override System.Web.Routing.RouteData GetRouteData(System.Web.HttpContextBase httpContext) { throw null; }
        public System.Web.DynamicData.MetaTable GetTableFromRouteData(System.Web.Routing.RouteData routeData) { throw null; }
        public override System.Web.Routing.VirtualPathData GetVirtualPath(System.Web.Routing.RequestContext requestContext, System.Web.Routing.RouteValueDictionary values) { throw null; }
    }
    [System.Web.AspNetHostingPermissionAttribute(System.Security.Permissions.SecurityAction.InheritanceDemand, Level=(System.Web.AspNetHostingPermissionLevel)(200))]
    [System.Web.AspNetHostingPermissionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Level=(System.Web.AspNetHostingPermissionLevel)(200))]
    public partial class DynamicDataRouteHandler : System.Web.Routing.IRouteHandler
    {
        public DynamicDataRouteHandler() { }
        public System.Web.DynamicData.MetaModel Model { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        [System.MonoTODOAttribute("Needs a working test")]
        public virtual System.Web.IHttpHandler CreateHandler(System.Web.DynamicData.DynamicDataRoute route, System.Web.DynamicData.MetaTable table, string action) { throw null; }
        protected virtual string GetCustomPageVirtualPath(System.Web.DynamicData.MetaTable table, string viewName) { throw null; }
        public static System.Web.Routing.RequestContext GetRequestContext(System.Web.HttpContext httpContext) { throw null; }
        public static System.Web.DynamicData.MetaTable GetRequestMetaTable(System.Web.HttpContext httpContext) { throw null; }
        protected virtual string GetScaffoldPageVirtualPath(System.Web.DynamicData.MetaTable table, string viewName) { throw null; }
        public static void SetRequestMetaTable(System.Web.HttpContext httpContext, System.Web.DynamicData.MetaTable table) { }
        System.Web.IHttpHandler System.Web.Routing.IRouteHandler.GetHttpHandler(System.Web.Routing.RequestContext requestContext) { throw null; }
    }
    public partial class DynamicEntity : System.Web.UI.Control
    {
        public DynamicEntity() { }
        public System.Web.UI.WebControls.DataBoundControlMode Mode { get { throw null; } set { } }
        public string UIHint { get { throw null; } set { } }
        public string ValidationGroup { get { throw null; } set { } }
        protected override void OnLoad(System.EventArgs e) { }
        protected override void Render(System.Web.UI.HtmlTextWriter writer) { }
    }
    [System.Web.AspNetHostingPermissionAttribute(System.Security.Permissions.SecurityAction.InheritanceDemand, Level=(System.Web.AspNetHostingPermissionLevel)(200))]
    [System.Web.AspNetHostingPermissionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Level=(System.Web.AspNetHostingPermissionLevel)(200))]
    public partial class DynamicField : System.Web.UI.WebControls.DataControlField, System.Web.DynamicData.IFieldFormattingOptions, System.Web.UI.IAttributeAccessor
    {
        public DynamicField() { }
        public bool ApplyFormatInEditMode { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        protected System.Web.DynamicData.MetaColumn Column { get { throw null; } }
        public bool ConvertEmptyStringToNull { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public virtual string DataField { get { throw null; } set { } }
        public string DataFormatString { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public override string HeaderText { get { throw null; } set { } }
        public bool HtmlEncode { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public string NullDisplayText { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public virtual bool ReadOnly { get { throw null; } set { } }
        public override string SortExpression { get { throw null; } set { } }
        public virtual string UIHint { get { throw null; } set { } }
        public new System.Web.UI.ValidateRequestMode ValidateRequestMode { get { throw null; } set { } }
        public virtual string ValidationGroup { get { throw null; } set { } }
        protected virtual void ConfigureDynamicControl(System.Web.DynamicData.DynamicControl control) { }
        [System.MonoTODOAttribute]
        protected override void CopyProperties(System.Web.UI.WebControls.DataControlField newField) { }
        protected virtual System.Web.DynamicData.DynamicControl CreateDynamicControl() { throw null; }
        [System.MonoTODOAttribute]
        protected override System.Web.UI.WebControls.DataControlField CreateField() { throw null; }
        [System.MonoTODOAttribute]
        public override void ExtractValuesFromCell(System.Collections.Specialized.IOrderedDictionary dictionary, System.Web.UI.WebControls.DataControlFieldCell cell, System.Web.UI.WebControls.DataControlRowState rowState, bool includeReadOnly) { }
        public string GetAttribute(string key) { throw null; }
        public override void InitializeCell(System.Web.UI.WebControls.DataControlFieldCell cell, System.Web.UI.WebControls.DataControlCellType cellType, System.Web.UI.WebControls.DataControlRowState rowState, int rowIndex) { }
        public void SetAttribute(string key, string value) { }
    }
    public partial class DynamicFilter : System.Web.UI.Control, System.Web.DynamicData.IFilterExpressionProvider
    {
        public DynamicFilter() { }
        protected internal System.Web.DynamicData.MetaColumn Column { get { throw null; } }
        public string DataField { get { throw null; } set { } }
        public System.Web.UI.Control FilterTemplate { get { throw null; } }
        public string FilterUIHint { get { throw null; } set { } }
        public event System.EventHandler FilterChanged { add { } remove { } }
        protected override void Render(System.Web.UI.HtmlTextWriter writer) { }
        System.Linq.IQueryable System.Web.DynamicData.IFilterExpressionProvider.GetQueryable(System.Linq.IQueryable source) { throw null; }
        void System.Web.DynamicData.IFilterExpressionProvider.Initialize(System.Web.UI.WebControls.IQueryableDataSource dataSource) { }
    }
    public partial class DynamicFilterExpression : System.Web.UI.WebControls.Expressions.DataSourceExpression
    {
        public DynamicFilterExpression() { }
        public string ControlID { get { throw null; } set { } }
        public override System.Linq.IQueryable GetQueryable(System.Linq.IQueryable source) { throw null; }
        public override void SetContext(System.Web.UI.Control owner, System.Web.HttpContext context, System.Web.UI.WebControls.IQueryableDataSource dataSource) { }
    }
    public partial class DynamicHyperLink : System.Web.UI.WebControls.HyperLink, System.Web.UI.IAttributeAccessor
    {
        public DynamicHyperLink() { }
        public string Action { get { throw null; } set { } }
        public string ContextTypeName { get { throw null; } set { } }
        public string DataField { get { throw null; } set { } }
        public string TableName { get { throw null; } set { } }
        protected override void OnDataBinding(System.EventArgs e) { }
        protected override void OnPreRender(System.EventArgs e) { }
        string System.Web.UI.IAttributeAccessor.GetAttribute(string key) { throw null; }
        void System.Web.UI.IAttributeAccessor.SetAttribute(string key, string value) { }
    }
    [System.Web.AspNetHostingPermissionAttribute(System.Security.Permissions.SecurityAction.InheritanceDemand, Level=(System.Web.AspNetHostingPermissionLevel)(200))]
    [System.Web.AspNetHostingPermissionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Level=(System.Web.AspNetHostingPermissionLevel)(200))]
    public partial class DynamicQueryStringParameter : System.Web.UI.WebControls.Parameter, System.Web.DynamicData.IWhereParametersProvider
    {
        public DynamicQueryStringParameter() { }
        [System.MonoTODOAttribute]
        protected override object Evaluate(System.Web.HttpContext context, System.Web.UI.Control control) { throw null; }
        [System.MonoTODOAttribute]
        public virtual System.Collections.Generic.IEnumerable<System.Web.UI.WebControls.Parameter> GetWhereParameters(System.Web.DynamicData.IDynamicDataSource dataSource) { throw null; }
    }
    public partial class DynamicRouteExpression : System.Web.UI.WebControls.Expressions.DataSourceExpression
    {
        public DynamicRouteExpression() { }
        public string ColumnName { get { throw null; } set { } }
        public override System.Linq.IQueryable GetQueryable(System.Linq.IQueryable source) { throw null; }
        public override void SetContext(System.Web.UI.Control owner, System.Web.HttpContext context, System.Web.UI.WebControls.IQueryableDataSource dataSource) { }
    }
    [System.Drawing.ToolboxBitmapAttribute(typeof(System.Web.DynamicData.DynamicValidator), "DynamicValidator.ico")]
    [System.Web.AspNetHostingPermissionAttribute(System.Security.Permissions.SecurityAction.InheritanceDemand, Level=(System.Web.AspNetHostingPermissionLevel)(200))]
    [System.Web.AspNetHostingPermissionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Level=(System.Web.AspNetHostingPermissionLevel)(200))]
    public partial class DynamicValidator : System.Web.UI.WebControls.BaseValidator
    {
        public DynamicValidator() { }
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.Web.UI.ThemeableAttribute(false)]
        public System.Web.DynamicData.MetaColumn Column { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.Web.UI.ThemeableAttribute(false)]
        public string ColumnName { get { throw null; } }
        protected virtual System.Exception ValidationException { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        protected override bool ControlPropertiesValid() { throw null; }
        [System.MonoTODOAttribute]
        protected override bool EvaluateIsValid() { throw null; }
        protected override void OnInit(System.EventArgs e) { }
        [System.MonoTODOAttribute]
        protected virtual void ValidateException(System.Exception exception) { }
    }
    public partial class EntityTemplate : System.Web.UI.Control
    {
        public EntityTemplate() { }
        public virtual System.Web.UI.ITemplate ItemTemplate { get { throw null; } set { } }
    }
    public partial class EntityTemplateFactory
    {
        public EntityTemplateFactory() { }
        public virtual string BuildEntityTemplateVirtualPath(string templateName, System.Web.UI.WebControls.DataBoundControlMode mode) { throw null; }
        public virtual System.Web.DynamicData.EntityTemplateUserControl CreateEntityTemplate(System.Web.DynamicData.MetaTable table, System.Web.UI.WebControls.DataBoundControlMode mode, string uiHint) { throw null; }
        public virtual string GetEntityTemplateVirtualPath(System.Web.DynamicData.MetaTable table, System.Web.UI.WebControls.DataBoundControlMode mode, string uiHint) { throw null; }
    }
    public partial class EntityTemplateUserControl : System.Web.UI.UserControl
    {
        public EntityTemplateUserControl() { }
        public virtual System.Web.DynamicData.ContainerType ContainerType { get { throw null; } }
        public System.Web.UI.WebControls.DataBoundControlMode Mode { get { throw null; } }
        public System.Web.DynamicData.MetaTable Table { get { throw null; } }
        public string ValidationGroup { get { throw null; } }
    }
    [System.Web.AspNetHostingPermissionAttribute(System.Security.Permissions.SecurityAction.InheritanceDemand, Level=(System.Web.AspNetHostingPermissionLevel)(200))]
    [System.Web.AspNetHostingPermissionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Level=(System.Web.AspNetHostingPermissionLevel)(200))]
    public partial class FieldTemplateFactory : System.Web.DynamicData.IFieldTemplateFactory
    {
        public FieldTemplateFactory() { }
        public System.Web.DynamicData.MetaModel Model { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        public string TemplateFolderVirtualPath { get { throw null; } set { } }
        public virtual string BuildVirtualPath(string templateName, System.Web.DynamicData.MetaColumn column, System.Web.UI.WebControls.DataBoundControlMode mode) { throw null; }
        public virtual System.Web.DynamicData.IFieldTemplate CreateFieldTemplate(System.Web.DynamicData.MetaColumn column, System.Web.UI.WebControls.DataBoundControlMode mode, string uiHint) { throw null; }
        public virtual string GetFieldTemplateVirtualPath(System.Web.DynamicData.MetaColumn column, System.Web.UI.WebControls.DataBoundControlMode mode, string uiHint) { throw null; }
        public virtual void Initialize(System.Web.DynamicData.MetaModel model) { }
        public virtual System.Web.UI.WebControls.DataBoundControlMode PreprocessMode(System.Web.DynamicData.MetaColumn column, System.Web.UI.WebControls.DataBoundControlMode mode) { throw null; }
    }
    [System.Web.AspNetHostingPermissionAttribute(System.Security.Permissions.SecurityAction.InheritanceDemand, Level=(System.Web.AspNetHostingPermissionLevel)(200))]
    [System.Web.AspNetHostingPermissionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Level=(System.Web.AspNetHostingPermissionLevel)(200))]
    public partial class FieldTemplateUserControl : System.Web.UI.UserControl, System.Web.DynamicData.IFieldTemplate, System.Web.UI.IBindableControl
    {
        public FieldTemplateUserControl() { }
        public System.Web.DynamicData.MetaChildrenColumn ChildrenColumn { get { throw null; } }
        [System.MonoTODOAttribute]
        protected string ChildrenPath { get { throw null; } }
        public System.Web.DynamicData.MetaColumn Column { get { throw null; } }
        public virtual System.Web.DynamicData.ContainerType ContainerType { get { throw null; } }
        [System.MonoTODOAttribute]
        public virtual System.Web.UI.Control DataControl { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        [System.MonoTODOAttribute]
        public virtual object FieldValue { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        [System.MonoTODOAttribute]
        public virtual string FieldValueEditString { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        [System.MonoTODOAttribute]
        public virtual string FieldValueString { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        [System.MonoTODOAttribute]
        public System.Web.DynamicData.MetaForeignKeyColumn ForeignKeyColumn { get { throw null; } }
        [System.MonoTODOAttribute]
        protected string ForeignKeyPath { get { throw null; } }
        [System.MonoTODOAttribute]
        public System.Web.DynamicData.IFieldFormattingOptions FormattingOptions { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        public System.Web.DynamicData.IFieldTemplateHost Host { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        [System.MonoTODOAttribute]
        public System.ComponentModel.AttributeCollection MetadataAttributes { get { throw null; } }
        [System.MonoTODOAttribute]
        public System.Web.UI.WebControls.DataBoundControlMode Mode { get { throw null; } }
        [System.MonoTODOAttribute]
        public virtual object Row { get { throw null; } }
        [System.MonoTODOAttribute]
        public System.Web.DynamicData.MetaTable Table { get { throw null; } }
        [System.MonoTODOAttribute]
        protected string BuildChildrenPath(string path) { throw null; }
        [System.MonoTODOAttribute]
        protected string BuildForeignKeyPath(string path) { throw null; }
        [System.MonoTODOAttribute]
        protected virtual object ConvertEditedValue(string value) { throw null; }
        [System.MonoTODOAttribute]
        protected virtual void ExtractForeignKey(System.Collections.IDictionary dictionary, string selectedValue) { }
        [System.MonoTODOAttribute]
        protected virtual void ExtractValues(System.Collections.Specialized.IOrderedDictionary dictionary) { }
        [System.MonoTODOAttribute]
        protected System.Web.DynamicData.FieldTemplateUserControl FindOtherFieldTemplate(string columnName) { throw null; }
        [System.MonoTODOAttribute]
        public virtual string FormatFieldValue(object fieldValue) { throw null; }
        [System.MonoTODOAttribute]
        protected virtual object GetColumnValue(System.Web.DynamicData.MetaColumn column) { throw null; }
        protected string GetSelectedValueString() { throw null; }
        [System.MonoTODOAttribute]
        protected void IgnoreModelValidationAttribute(System.Type attributeType) { }
        [System.MonoTODOAttribute]
        protected void PopulateListControl(System.Web.UI.WebControls.ListControl listControl) { }
        [System.MonoTODOAttribute]
        protected virtual void SetUpValidator(System.Web.UI.WebControls.BaseValidator validator) { }
        [System.MonoTODOAttribute]
        protected virtual void SetUpValidator(System.Web.UI.WebControls.BaseValidator validator, System.Web.DynamicData.MetaColumn column) { }
        void System.Web.DynamicData.IFieldTemplate.SetHost(System.Web.DynamicData.IFieldTemplateHost host) { }
        [System.MonoTODOAttribute]
        void System.Web.UI.IBindableControl.ExtractValues(System.Collections.Specialized.IOrderedDictionary dictionary) { }
    }
    public partial class FilterFactory
    {
        public FilterFactory() { }
        public virtual System.Web.DynamicData.QueryableFilterUserControl CreateFilterControl(System.Web.DynamicData.MetaColumn column, string filterUIHint) { throw null; }
        public virtual string GetFilterVirtualPath(System.Web.DynamicData.MetaColumn column, string filterUIHint) { throw null; }
    }
    [System.Web.UI.ParseChildrenAttribute(true)]
    [System.Web.AspNetHostingPermissionAttribute(System.Security.Permissions.SecurityAction.InheritanceDemand, Level=(System.Web.AspNetHostingPermissionLevel)(200))]
    [System.Web.AspNetHostingPermissionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Level=(System.Web.AspNetHostingPermissionLevel)(200))]
    public partial class FilterRepeater : System.Web.UI.WebControls.Repeater, System.Web.DynamicData.IWhereParametersProvider
    {
        public FilterRepeater() { }
        [System.ComponentModel.CategoryAttribute("Data")]
        [System.ComponentModel.DefaultValueAttribute(null)]
        [System.MonoTODOAttribute]
        [System.Web.UI.ThemeableAttribute(false)]
        public string ContextTypeName { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        [System.ComponentModel.CategoryAttribute("Behavior")]
        [System.ComponentModel.DefaultValueAttribute("DynamicFilter")]
        [System.MonoTODOAttribute]
        [System.Web.UI.IDReferencePropertyAttribute(typeof(System.Web.DynamicData.FilterUserControlBase))]
        [System.Web.UI.ThemeableAttribute(false)]
        public string DynamicFilterContainerId { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        [System.MonoTODOAttribute]
        public System.Web.DynamicData.MetaTable Table { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        [System.ComponentModel.CategoryAttribute("Data")]
        [System.ComponentModel.DefaultValueAttribute(null)]
        [System.MonoTODOAttribute]
        [System.Web.UI.ThemeableAttribute(false)]
        public string TableName { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        [System.MonoTODOAttribute]
        public override bool Visible { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        [System.MonoTODOAttribute]
        public override void DataBind() { }
        [System.MonoTODOAttribute]
        protected internal virtual System.Collections.Generic.IEnumerable<System.Web.DynamicData.MetaColumn> GetFilteredColumns() { throw null; }
        [System.MonoTODOAttribute]
        public virtual System.Collections.Generic.IEnumerable<System.Web.UI.WebControls.Parameter> GetWhereParameters(System.Web.DynamicData.IDynamicDataSource dataSource) { throw null; }
        [System.MonoTODOAttribute]
        protected virtual void OnFilterItemCreated(System.Web.UI.WebControls.RepeaterItem item) { }
        [System.MonoTODOAttribute]
        protected override void OnInit(System.EventArgs e) { }
        [System.MonoTODOAttribute]
        protected override void OnItemCreated(System.Web.UI.WebControls.RepeaterItemEventArgs e) { }
    }
    [System.Web.AspNetHostingPermissionAttribute(System.Security.Permissions.SecurityAction.InheritanceDemand, Level=(System.Web.AspNetHostingPermissionLevel)(200))]
    [System.Web.AspNetHostingPermissionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Level=(System.Web.AspNetHostingPermissionLevel)(200))]
    public partial class FilterUserControlBase : System.Web.UI.UserControl, System.Web.DynamicData.IControlParameterTarget
    {
        public FilterUserControlBase() { }
        [System.MonoTODOAttribute]
        public System.Web.DynamicData.MetaColumn Column { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        [System.MonoTODOAttribute]
        public string ContextTypeName { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        [System.MonoTODOAttribute]
        public string DataField { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        [System.MonoTODOAttribute]
        public string InitialValue { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        [System.MonoTODOAttribute]
        public virtual System.Web.UI.WebControls.DataKey SelectedDataKey { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        [System.MonoTODOAttribute]
        public virtual string SelectedValue { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        [System.MonoTODOAttribute]
        System.Web.DynamicData.MetaColumn System.Web.DynamicData.IControlParameterTarget.FilteredColumn { get { throw null; } }
        [System.MonoTODOAttribute]
        System.Web.DynamicData.MetaTable System.Web.DynamicData.IControlParameterTarget.Table { get { throw null; } }
        [System.MonoTODOAttribute]
        public string TableName { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        [System.MonoTODOAttribute]
        public void PopulateListControl(System.Web.UI.WebControls.ListControl listControl) { }
        [System.MonoTODOAttribute]
        string System.Web.DynamicData.IControlParameterTarget.GetPropertyNameExpression(string columnName) { throw null; }
    }
    [System.Web.AspNetHostingPermissionAttribute(System.Security.Permissions.SecurityAction.InheritanceDemand, Level=(System.Web.AspNetHostingPermissionLevel)(200))]
    [System.Web.AspNetHostingPermissionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Level=(System.Web.AspNetHostingPermissionLevel)(200))]
    public partial interface IControlParameterTarget
    {
        System.Web.DynamicData.MetaColumn FilteredColumn { get; }
        System.Web.DynamicData.MetaTable Table { get; }
        string GetPropertyNameExpression(string columnName);
    }
    [System.Web.AspNetHostingPermissionAttribute(System.Security.Permissions.SecurityAction.InheritanceDemand, Level=(System.Web.AspNetHostingPermissionLevel)(200))]
    [System.Web.AspNetHostingPermissionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Level=(System.Web.AspNetHostingPermissionLevel)(200))]
    public partial interface IFieldFormattingOptions
    {
        bool ApplyFormatInEditMode { get; }
        bool ConvertEmptyStringToNull { get; }
        string DataFormatString { get; }
        bool HtmlEncode { get; }
        string NullDisplayText { get; }
    }
    [System.Web.AspNetHostingPermissionAttribute(System.Security.Permissions.SecurityAction.InheritanceDemand, Level=(System.Web.AspNetHostingPermissionLevel)(200))]
    [System.Web.AspNetHostingPermissionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Level=(System.Web.AspNetHostingPermissionLevel)(200))]
    public partial interface IFieldTemplate
    {
        void SetHost(System.Web.DynamicData.IFieldTemplateHost host);
    }
    [System.Web.AspNetHostingPermissionAttribute(System.Security.Permissions.SecurityAction.InheritanceDemand, Level=(System.Web.AspNetHostingPermissionLevel)(200))]
    [System.Web.AspNetHostingPermissionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Level=(System.Web.AspNetHostingPermissionLevel)(200))]
    public partial interface IFieldTemplateFactory
    {
        System.Web.DynamicData.IFieldTemplate CreateFieldTemplate(System.Web.DynamicData.MetaColumn column, System.Web.UI.WebControls.DataBoundControlMode mode, string uiHint);
        void Initialize(System.Web.DynamicData.MetaModel model);
    }
    [System.Web.AspNetHostingPermissionAttribute(System.Security.Permissions.SecurityAction.InheritanceDemand, Level=(System.Web.AspNetHostingPermissionLevel)(200))]
    [System.Web.AspNetHostingPermissionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Level=(System.Web.AspNetHostingPermissionLevel)(200))]
    public partial interface IFieldTemplateHost
    {
        System.Web.DynamicData.MetaColumn Column { get; }
        System.Web.DynamicData.IFieldFormattingOptions FormattingOptions { get; }
        System.Web.UI.WebControls.DataBoundControlMode Mode { get; }
        string ValidationGroup { get; }
    }
    public partial interface IFilterExpressionProvider
    {
        System.Linq.IQueryable GetQueryable(System.Linq.IQueryable source);
        void Initialize(System.Web.UI.WebControls.IQueryableDataSource dataSource);
    }
    [System.Web.AspNetHostingPermissionAttribute(System.Security.Permissions.SecurityAction.InheritanceDemand, Level=(System.Web.AspNetHostingPermissionLevel)(200))]
    [System.Web.AspNetHostingPermissionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Level=(System.Web.AspNetHostingPermissionLevel)(200))]
    public partial interface IWhereParametersProvider
    {
        System.Collections.Generic.IEnumerable<System.Web.UI.WebControls.Parameter> GetWhereParameters(System.Web.DynamicData.IDynamicDataSource dataSource);
    }
    [System.Web.AspNetHostingPermissionAttribute(System.Security.Permissions.SecurityAction.InheritanceDemand, Level=(System.Web.AspNetHostingPermissionLevel)(200))]
    [System.Web.AspNetHostingPermissionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Level=(System.Web.AspNetHostingPermissionLevel)(200))]
    public partial class MetaChildrenColumn : System.Web.DynamicData.MetaColumn
    {
        public MetaChildrenColumn(System.Web.DynamicData.MetaTable table, System.Web.DynamicData.ModelProviders.ColumnProvider entityMember) : base (default(System.Web.DynamicData.MetaTable), default(System.Web.DynamicData.ModelProviders.ColumnProvider)) { }
        [System.MonoTODOAttribute]
        public System.Web.DynamicData.MetaTable ChildTable { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        [System.MonoTODOAttribute]
        public System.Web.DynamicData.MetaColumn ColumnInOtherTable { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        public bool IsManyToMany { get { throw null; } }
        [System.MonoTODOAttribute]
        public string GetChildrenListPath(object row) { throw null; }
        [System.MonoTODOAttribute]
        public string GetChildrenPath(string action, object row) { throw null; }
        [System.MonoTODOAttribute]
        public string GetChildrenPath(string action, object row, string path) { throw null; }
        protected internal override void Initialize() { }
    }
    [System.Web.AspNetHostingPermissionAttribute(System.Security.Permissions.SecurityAction.InheritanceDemand, Level=(System.Web.AspNetHostingPermissionLevel)(200))]
    [System.Web.AspNetHostingPermissionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Level=(System.Web.AspNetHostingPermissionLevel)(200))]
    public partial class MetaColumn : System.Web.DynamicData.IFieldFormattingOptions
    {
        public MetaColumn(System.Web.DynamicData.MetaTable table, System.Web.DynamicData.ModelProviders.ColumnProvider columnProvider) { }
        public bool AllowInitialValue { get { throw null; } }
        public bool ApplyFormatInEditMode { get { throw null; } }
        public System.ComponentModel.AttributeCollection Attributes { get { throw null; } }
        public System.Type ColumnType { get { throw null; } }
        public bool ConvertEmptyStringToNull { get { throw null; } }
        public string DataFormatString { get { throw null; } }
        public System.ComponentModel.DataAnnotations.DataTypeAttribute DataTypeAttribute { get { throw null; } }
        public object DefaultValue { get { throw null; } }
        public virtual string Description { get { throw null; } }
        public virtual string DisplayName { get { throw null; } }
        public System.Reflection.PropertyInfo EntityTypeProperty { get { throw null; } }
        public string FilterUIHint { get { throw null; } }
        public bool HtmlEncode { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        public bool IsBinaryData { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        public bool IsCustomProperty { get { throw null; } }
        public bool IsFloatingPoint { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        public bool IsForeignKeyComponent { get { throw null; } }
        public bool IsGenerated { get { throw null; } }
        public bool IsInteger { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        public bool IsLongString { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        public bool IsPrimaryKey { get { throw null; } }
        public virtual bool IsReadOnly { get { throw null; } }
        public bool IsRequired { get { throw null; } }
        public bool IsString { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        public int MaxLength { get { throw null; } }
        public System.Web.DynamicData.MetaModel Model { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        public string Name { get { throw null; } }
        public string NullDisplayText { get { throw null; } }
        public virtual string Prompt { get { throw null; } }
        public System.Web.DynamicData.ModelProviders.ColumnProvider Provider { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        public string RequiredErrorMessage { get { throw null; } }
        public virtual bool Scaffold { get { throw null; } set { } }
        public virtual string ShortDisplayName { get { throw null; } }
        public string SortExpression { get { throw null; } }
        public System.Web.DynamicData.MetaTable Table { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        public System.TypeCode TypeCode { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        public virtual string UIHint { get { throw null; } }
        protected virtual System.ComponentModel.AttributeCollection BuildAttributeCollection() { throw null; }
        protected internal virtual void Initialize() { }
        public void ResetMetadata() { }
        public override string ToString() { throw null; }
    }
    [System.Web.AspNetHostingPermissionAttribute(System.Security.Permissions.SecurityAction.InheritanceDemand, Level=(System.Web.AspNetHostingPermissionLevel)(200))]
    [System.Web.AspNetHostingPermissionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Level=(System.Web.AspNetHostingPermissionLevel)(200))]
    public partial class MetaForeignKeyColumn : System.Web.DynamicData.MetaColumn
    {
        public MetaForeignKeyColumn(System.Web.DynamicData.MetaTable table, System.Web.DynamicData.ModelProviders.ColumnProvider entityMember) : base (default(System.Web.DynamicData.MetaTable), default(System.Web.DynamicData.ModelProviders.ColumnProvider)) { }
        [System.MonoTODOAttribute]
        public System.Collections.ObjectModel.ReadOnlyCollection<string> ForeignKeyNames { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        [System.MonoTODOAttribute]
        public bool IsPrimaryKeyInThisTable { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        [System.MonoTODOAttribute]
        public System.Web.DynamicData.MetaTable ParentTable { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        [System.MonoTODOAttribute]
        public void ExtractForeignKey(System.Collections.IDictionary dictionary, string value) { }
        public string GetFilterExpression(string foreignKeyName) { throw null; }
        [System.MonoTODOAttribute]
        public string GetForeignKeyDetailsPath(object row) { throw null; }
        [System.MonoTODOAttribute]
        public string GetForeignKeyPath(string action, object row) { throw null; }
        [System.MonoTODOAttribute]
        public string GetForeignKeyPath(string action, object row, string path) { throw null; }
        [System.MonoTODOAttribute]
        public string GetForeignKeyString(object row) { throw null; }
        [System.MonoTODOAttribute]
        public System.Collections.Generic.IList<object> GetForeignKeyValues(object row) { throw null; }
        protected internal override void Initialize() { }
    }
    [System.Web.AspNetHostingPermissionAttribute(System.Security.Permissions.SecurityAction.InheritanceDemand, Level=(System.Web.AspNetHostingPermissionLevel)(200))]
    [System.Web.AspNetHostingPermissionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Level=(System.Web.AspNetHostingPermissionLevel)(200))]
    public partial class MetaModel
    {
        public MetaModel() { }
        public MetaModel(bool registerGlobally) { }
        public static System.Web.DynamicData.MetaModel Default { get { throw null; } }
        public string DynamicDataFolderVirtualPath { get { throw null; } set { } }
        public System.Web.DynamicData.EntityTemplateFactory EntityTemplateFactory { get { throw null; } set { } }
        public System.Web.DynamicData.IFieldTemplateFactory FieldTemplateFactory { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public System.Web.DynamicData.FilterFactory FilterFactory { get { throw null; } set { } }
        public System.Collections.ObjectModel.ReadOnlyCollection<System.Web.DynamicData.MetaTable> Tables { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        public System.Collections.Generic.List<System.Web.DynamicData.MetaTable> VisibleTables { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        protected virtual System.Web.DynamicData.MetaTable CreateTable(System.Web.DynamicData.ModelProviders.TableProvider provider) { throw null; }
        public string GetActionPath(string tableName, string action, object row) { throw null; }
        public static System.Web.DynamicData.MetaModel GetModel(System.Type contextType) { throw null; }
        public System.Web.DynamicData.MetaTable GetTable(string uniqueTableName) { throw null; }
        public System.Web.DynamicData.MetaTable GetTable(string tableName, System.Type contextType) { throw null; }
        public System.Web.DynamicData.MetaTable GetTable(System.Type entityType) { throw null; }
        public void RegisterContext(System.Func<object> contextFactory) { }
        public void RegisterContext(System.Func<object> contextFactory, System.Web.DynamicData.ContextConfiguration configuration) { }
        public void RegisterContext(System.Type contextType) { }
        public void RegisterContext(System.Type contextType, System.Web.DynamicData.ContextConfiguration configuration) { }
        public void RegisterContext(System.Web.DynamicData.ModelProviders.DataModelProvider dataModelProvider) { }
        public virtual void RegisterContext(System.Web.DynamicData.ModelProviders.DataModelProvider dataModelProvider, System.Web.DynamicData.ContextConfiguration configuration) { }
        public static void ResetRegistrationException() { }
        public bool TryGetTable(string uniqueTableName, out System.Web.DynamicData.MetaTable table) { table = default(System.Web.DynamicData.MetaTable); throw null; }
        public bool TryGetTable(System.Type entityType, out System.Web.DynamicData.MetaTable table) { table = default(System.Web.DynamicData.MetaTable); throw null; }
    }
    [System.Web.AspNetHostingPermissionAttribute(System.Security.Permissions.SecurityAction.InheritanceDemand, Level=(System.Web.AspNetHostingPermissionLevel)(200))]
    [System.Web.AspNetHostingPermissionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Level=(System.Web.AspNetHostingPermissionLevel)(200))]
    public partial class MetaTable
    {
        public MetaTable(System.Web.DynamicData.MetaModel metaModel, System.Web.DynamicData.ModelProviders.TableProvider tableProvider) { }
        public System.ComponentModel.AttributeCollection Attributes { get { throw null; } }
        public System.Collections.ObjectModel.ReadOnlyCollection<System.Web.DynamicData.MetaColumn> Columns { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        public string DataContextPropertyName { get { throw null; } }
        public System.Type DataContextType { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        public virtual System.Web.DynamicData.MetaColumn DisplayColumn { get { throw null; } }
        public virtual string DisplayName { get { throw null; } }
        public System.Type EntityType { get { throw null; } }
        public string ForeignKeyColumnsNames { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        public bool HasPrimaryKey { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        public virtual bool IsReadOnly { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        public string ListActionPath { get { throw null; } }
        public System.Web.DynamicData.MetaModel Model { get { throw null; } }
        public string Name { get { throw null; } }
        public System.Collections.ObjectModel.ReadOnlyCollection<System.Web.DynamicData.MetaColumn> PrimaryKeyColumns { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        public System.Web.DynamicData.ModelProviders.TableProvider Provider { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        public System.Type RootEntityType { get { throw null; } }
        public virtual bool Scaffold { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        public virtual System.Web.DynamicData.MetaColumn SortColumn { get { throw null; } }
        public virtual bool SortDescending { get { throw null; } }
        protected virtual System.ComponentModel.AttributeCollection BuildAttributeCollection() { throw null; }
        public virtual bool CanDelete(System.Security.Principal.IPrincipal principal) { throw null; }
        public virtual bool CanInsert(System.Security.Principal.IPrincipal principal) { throw null; }
        public virtual bool CanRead(System.Security.Principal.IPrincipal principal) { throw null; }
        public virtual bool CanUpdate(System.Security.Principal.IPrincipal principal) { throw null; }
        protected virtual System.Web.DynamicData.MetaChildrenColumn CreateChildrenColumn(System.Web.DynamicData.ModelProviders.ColumnProvider columnProvider) { throw null; }
        protected virtual System.Web.DynamicData.MetaColumn CreateColumn(System.Web.DynamicData.ModelProviders.ColumnProvider columnProvider) { throw null; }
        public virtual object CreateContext() { throw null; }
        protected virtual System.Web.DynamicData.MetaForeignKeyColumn CreateForeignKeyColumn(System.Web.DynamicData.ModelProviders.ColumnProvider columnProvider) { throw null; }
        public static System.Web.DynamicData.MetaTable CreateTable(System.ComponentModel.ICustomTypeDescriptor typeDescriptor) { throw null; }
        public static System.Web.DynamicData.MetaTable CreateTable(System.Type entityType) { throw null; }
        public string GetActionPath(string action) { throw null; }
        public string GetActionPath(string action, System.Collections.Generic.IList<object> primaryKeyValues) { throw null; }
        public string GetActionPath(string action, System.Collections.Generic.IList<object> primaryKeyValues, string path) { throw null; }
        public string GetActionPath(string action, object row) { throw null; }
        public string GetActionPath(string action, object row, string path) { throw null; }
        public string GetActionPath(string action, System.Web.Routing.RouteValueDictionary routeValues) { throw null; }
        public System.Web.DynamicData.MetaColumn GetColumn(string columnName) { throw null; }
        public System.Collections.Generic.IDictionary<string, object> GetColumnValuesFromRoute(System.Web.HttpContext context) { throw null; }
        public System.Web.UI.WebControls.DataKey GetDataKeyFromRoute() { throw null; }
        public virtual string GetDisplayString(object row) { throw null; }
        public virtual System.Collections.Generic.IEnumerable<System.Web.DynamicData.MetaColumn> GetFilteredColumns() { throw null; }
        public System.Collections.Generic.IDictionary<string, object> GetPrimaryKeyDictionary(object row) { throw null; }
        public string GetPrimaryKeyString(System.Collections.Generic.IList<object> primaryKeyValues) { throw null; }
        public string GetPrimaryKeyString(object row) { throw null; }
        public System.Collections.Generic.IList<object> GetPrimaryKeyValues(object row) { throw null; }
        public System.Linq.IQueryable GetQuery() { throw null; }
        public virtual System.Linq.IQueryable GetQuery(object context) { throw null; }
        public virtual System.Collections.Generic.IEnumerable<System.Web.DynamicData.MetaColumn> GetScaffoldColumns(System.Web.UI.WebControls.DataBoundControlMode mode, System.Web.DynamicData.ContainerType containerType) { throw null; }
        public static System.Web.DynamicData.MetaTable GetTable(System.Type entityType) { throw null; }
        protected internal virtual void Initialize() { }
        public void ResetMetadata() { }
        public override string ToString() { throw null; }
        public bool TryGetColumn(string columnName, out System.Web.DynamicData.MetaColumn column) { column = default(System.Web.DynamicData.MetaColumn); throw null; }
        public static bool TryGetTable(System.Type entityType, out System.Web.DynamicData.MetaTable table) { table = default(System.Web.DynamicData.MetaTable); throw null; }
    }
    [System.Web.AspNetHostingPermissionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Level=(System.Web.AspNetHostingPermissionLevel)(200))]
    public static partial class PageAction
    {
        public static string Details { get { throw null; } }
        public static string Edit { get { throw null; } }
        public static string Insert { get { throw null; } }
        public static string List { get { throw null; } }
    }
    public partial class QueryableFilterRepeater : System.Web.UI.Control, System.Web.DynamicData.IFilterExpressionProvider
    {
        public QueryableFilterRepeater() { }
        public string DynamicFilterContainerId { get { throw null; } set { } }
        public virtual System.Web.UI.ITemplate ItemTemplate { get { throw null; } set { } }
        protected override void OnPreRender(System.EventArgs e) { }
        System.Linq.IQueryable System.Web.DynamicData.IFilterExpressionProvider.GetQueryable(System.Linq.IQueryable source) { throw null; }
        void System.Web.DynamicData.IFilterExpressionProvider.Initialize(System.Web.UI.WebControls.IQueryableDataSource dataSource) { }
    }
    public abstract partial class QueryableFilterUserControl : System.Web.UI.UserControl
    {
        protected QueryableFilterUserControl() { }
        protected internal System.Web.DynamicData.MetaColumn Column { get { throw null; } }
        public string DefaultValue { get { throw null; } }
        public System.Collections.Generic.IDictionary<string, object> DefaultValues { get { throw null; } }
        public virtual System.Web.UI.Control FilterControl { get { throw null; } }
        public event System.EventHandler FilterChanged { add { } remove { } }
        public static System.Linq.IQueryable ApplyEqualityFilter(System.Linq.IQueryable source, string propertyName, object value) { throw null; }
        public abstract System.Linq.IQueryable GetQueryable(System.Linq.IQueryable source);
        protected void OnFilterChanged() { }
        public void PopulateListControl(System.Web.UI.WebControls.ListControl listControl) { }
    }
    [System.AttributeUsageAttribute((System.AttributeTargets)(4), AllowMultiple=false)]
    [System.Web.AspNetHostingPermissionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Level=(System.Web.AspNetHostingPermissionLevel)(200))]
    public sealed partial class TableNameAttribute : System.Attribute
    {
        public TableNameAttribute(string name) { }
        public string Name { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
    }
}
namespace System.Web.DynamicData.ModelProviders
{
    public enum AssociationDirection
    {
        ManyToMany = 3,
        ManyToOne = 2,
        OneToMany = 1,
        OneToOne = 0,
    }
    [System.Web.AspNetHostingPermissionAttribute(System.Security.Permissions.SecurityAction.InheritanceDemand, Level=(System.Web.AspNetHostingPermissionLevel)(200))]
    [System.Web.AspNetHostingPermissionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Level=(System.Web.AspNetHostingPermissionLevel)(200))]
    public abstract partial class AssociationProvider
    {
        protected AssociationProvider() { }
        [System.MonoTODOAttribute]
        public virtual System.Web.DynamicData.ModelProviders.AssociationDirection Direction { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]protected set { } }
        [System.MonoTODOAttribute]
        public virtual System.Collections.ObjectModel.ReadOnlyCollection<string> ForeignKeyNames { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]protected set { } }
        [System.MonoTODOAttribute]
        public virtual System.Web.DynamicData.ModelProviders.ColumnProvider FromColumn { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]protected set { } }
        [System.MonoTODOAttribute]
        public virtual bool IsPrimaryKeyInThisTable { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]protected set { } }
        [System.MonoTODOAttribute]
        public virtual System.Web.DynamicData.ModelProviders.ColumnProvider ToColumn { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]protected set { } }
        [System.MonoTODOAttribute]
        public virtual System.Web.DynamicData.ModelProviders.TableProvider ToTable { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]protected set { } }
        [System.MonoTODOAttribute]
        public virtual string GetSortExpression(System.Web.DynamicData.ModelProviders.ColumnProvider sortColumn) { throw null; }
    }
    [System.Web.AspNetHostingPermissionAttribute(System.Security.Permissions.SecurityAction.InheritanceDemand, Level=(System.Web.AspNetHostingPermissionLevel)(200))]
    [System.Web.AspNetHostingPermissionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Level=(System.Web.AspNetHostingPermissionLevel)(200))]
    public abstract partial class ColumnProvider
    {
        protected ColumnProvider(System.Web.DynamicData.ModelProviders.TableProvider table) { }
        [System.MonoTODOAttribute]
        public virtual System.Web.DynamicData.ModelProviders.AssociationProvider Association { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]protected set { } }
        public virtual System.ComponentModel.AttributeCollection Attributes { get { throw null; } }
        [System.MonoTODOAttribute]
        public virtual System.Type ColumnType { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]protected set { } }
        [System.MonoTODOAttribute]
        public virtual System.Reflection.PropertyInfo EntityTypeProperty { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]protected set { } }
        [System.MonoTODOAttribute]
        public virtual bool IsCustomProperty { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]protected set { } }
        [System.MonoTODOAttribute]
        public virtual bool IsForeignKeyComponent { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]protected set { } }
        [System.MonoTODOAttribute]
        public virtual bool IsGenerated { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]protected set { } }
        [System.MonoTODOAttribute]
        public virtual bool IsPrimaryKey { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]protected set { } }
        public virtual bool IsReadOnly { get { throw null; } protected set { } }
        [System.MonoTODOAttribute]
        public virtual bool IsSortable { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]protected set { } }
        [System.MonoTODOAttribute]
        public virtual int MaxLength { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]protected set { } }
        [System.MonoTODOAttribute]
        public virtual string Name { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]protected set { } }
        [System.MonoTODOAttribute]
        public virtual bool Nullable { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]protected set { } }
        [System.MonoTODOAttribute]
        public System.Web.DynamicData.ModelProviders.TableProvider Table { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        protected static System.ComponentModel.AttributeCollection AddDefaultAttributes(System.Web.DynamicData.ModelProviders.ColumnProvider columnProvider, System.ComponentModel.AttributeCollection attributes) { throw null; }
        [System.MonoTODOAttribute]
        public override string ToString() { throw null; }
    }
    [System.Web.AspNetHostingPermissionAttribute(System.Security.Permissions.SecurityAction.InheritanceDemand, Level=(System.Web.AspNetHostingPermissionLevel)(200))]
    [System.Web.AspNetHostingPermissionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Level=(System.Web.AspNetHostingPermissionLevel)(200))]
    public abstract partial class DataModelProvider
    {
        protected DataModelProvider() { }
        [System.MonoTODOAttribute]
        public virtual System.Type ContextType { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]protected set { } }
        public abstract System.Collections.ObjectModel.ReadOnlyCollection<System.Web.DynamicData.ModelProviders.TableProvider> Tables { get; }
        public abstract object CreateContext();
    }
    [System.Web.AspNetHostingPermissionAttribute(System.Security.Permissions.SecurityAction.InheritanceDemand, Level=(System.Web.AspNetHostingPermissionLevel)(200))]
    [System.Web.AspNetHostingPermissionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Level=(System.Web.AspNetHostingPermissionLevel)(200))]
    public abstract partial class TableProvider
    {
        protected TableProvider(System.Web.DynamicData.ModelProviders.DataModelProvider model) { }
        public virtual System.ComponentModel.AttributeCollection Attributes { get { throw null; } }
        public abstract System.Collections.ObjectModel.ReadOnlyCollection<System.Web.DynamicData.ModelProviders.ColumnProvider> Columns { get; }
        public virtual string DataContextPropertyName { get { throw null; } protected set { } }
        public System.Web.DynamicData.ModelProviders.DataModelProvider DataModel { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        public virtual System.Type EntityType { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]protected set { } }
        public virtual string Name { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]protected set { } }
        public virtual System.Type ParentEntityType { get { throw null; } protected set { } }
        public virtual System.Type RootEntityType { get { throw null; } protected set { } }
        public virtual bool CanDelete(System.Security.Principal.IPrincipal principal) { throw null; }
        public virtual bool CanInsert(System.Security.Principal.IPrincipal principal) { throw null; }
        public virtual bool CanRead(System.Security.Principal.IPrincipal principal) { throw null; }
        public virtual bool CanUpdate(System.Security.Principal.IPrincipal principal) { throw null; }
        public virtual object EvaluateForeignKey(object row, string foreignKeyName) { throw null; }
        public abstract System.Linq.IQueryable GetQuery(object context);
        public virtual System.ComponentModel.ICustomTypeDescriptor GetTypeDescriptor() { throw null; }
        public override string ToString() { throw null; }
    }
}
namespace System.Web.UI
{
    public static partial class DataControlExtensions
    {
        public static void EnableDynamicData(this System.Web.UI.INamingContainer control, System.Type entityType) { }
        public static void EnableDynamicData(this System.Web.UI.INamingContainer control, System.Type entityType, System.Collections.Generic.IDictionary<string, object> defaultValues) { }
        public static void EnableDynamicData(this System.Web.UI.INamingContainer control, System.Type entityType, object defaults) { }
    }
}
