// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

[assembly:System.Reflection.AssemblyVersionAttribute("4.0.0.0")]
[assembly:System.CLSCompliantAttribute(true)]
[assembly:System.Diagnostics.DebuggableAttribute((System.Diagnostics.DebuggableAttribute.DebuggingModes)(258))]
[assembly:System.Reflection.AssemblyCompanyAttribute("Mono development team")]
[assembly:System.Reflection.AssemblyCopyrightAttribute("(c) Various Mono authors")]
[assembly:System.Reflection.AssemblyDefaultAliasAttribute("System.Web.Extensions.Design.dll")]
[assembly:System.Reflection.AssemblyDescriptionAttribute("System.Web.Extensions.Design.dll")]
[assembly:System.Reflection.AssemblyFileVersionAttribute("4.0.30319.17020")]
[assembly:System.Reflection.AssemblyInformationalVersionAttribute("4.0.30319.17020")]
[assembly:System.Reflection.AssemblyProductAttribute("Mono Common Language Infrastructure")]
[assembly:System.Reflection.AssemblyTitleAttribute("System.Web.Extensions.Design.dll")]
[assembly:System.Resources.NeutralResourcesLanguageAttribute("en-US")]
[assembly:System.Resources.SatelliteContractVersionAttribute("4.0.0.0")]
[assembly:System.Runtime.CompilerServices.CompilationRelaxationsAttribute((System.Runtime.CompilerServices.CompilationRelaxations)(8))]
[assembly:System.Runtime.CompilerServices.ReferenceAssemblyAttribute]
[assembly:System.Runtime.CompilerServices.RuntimeCompatibilityAttribute(WrapNonExceptionThrows=true)]
[assembly:System.Runtime.InteropServices.ComVisibleAttribute(false)]
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
namespace System.Web.UI.Design
{
    public partial class AsyncPostBackTriggerControlIDConverter : System.ComponentModel.StringConverter
    {
        [System.MonoNotSupportedAttribute("")]
        public AsyncPostBackTriggerControlIDConverter() { }
        [System.MonoNotSupportedAttribute("")]
        public override System.ComponentModel.TypeConverter.StandardValuesCollection GetStandardValues(System.ComponentModel.ITypeDescriptorContext context) { throw null; }
        [System.MonoNotSupportedAttribute("")]
        public override bool GetStandardValuesExclusive(System.ComponentModel.ITypeDescriptorContext context) { throw null; }
        [System.MonoNotSupportedAttribute("")]
        public override bool GetStandardValuesSupported(System.ComponentModel.ITypeDescriptorContext context) { throw null; }
    }
    public partial class AsyncPostBackTriggerEventNameConverter : System.ComponentModel.StringConverter
    {
        [System.MonoNotSupportedAttribute("")]
        public AsyncPostBackTriggerEventNameConverter() { }
        [System.MonoNotSupportedAttribute("")]
        public override System.ComponentModel.TypeConverter.StandardValuesCollection GetStandardValues(System.ComponentModel.ITypeDescriptorContext context) { throw null; }
        [System.MonoNotSupportedAttribute("")]
        public override bool GetStandardValuesExclusive(System.ComponentModel.ITypeDescriptorContext context) { throw null; }
        [System.MonoNotSupportedAttribute("")]
        public override bool GetStandardValuesSupported(System.ComponentModel.ITypeDescriptorContext context) { throw null; }
    }
    public partial class CollectionEditorBase : System.ComponentModel.Design.CollectionEditor
    {
        [System.MonoNotSupportedAttribute("")]
        public CollectionEditorBase(System.Type type) : base (default(System.Type)) { }
        [System.MonoNotSupportedAttribute("")]
        protected override System.ComponentModel.Design.CollectionEditor.CollectionForm CreateCollectionForm() { throw null; }
    }
    public partial class ExtenderControlDesigner : System.Web.UI.Design.ControlDesigner
    {
        [System.MonoNotSupportedAttribute("")]
        public ExtenderControlDesigner() { }
        protected override bool Visible { get { throw null; } }
        protected override void Dispose(bool disposing) { }
        [System.MonoNotSupportedAttribute("")]
        public override string GetDesignTimeHtml() { throw null; }
        public override void Initialize(System.ComponentModel.IComponent component) { }
        protected override void PreFilterProperties(System.Collections.IDictionary properties) { }
    }
    public partial class ExtenderControlToolboxItem : System.Web.UI.Design.WebControlToolboxItem
    {
        public ExtenderControlToolboxItem() { }
        protected ExtenderControlToolboxItem(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
        public ExtenderControlToolboxItem(System.Type type) { }
        public System.Collections.ObjectModel.ReadOnlyCollection<System.Type> GetTargetControlTypes(System.ComponentModel.Design.IDesignerHost host) { throw null; }
        public override void Initialize(System.Type type) { }
    }
    public partial class PostBackTriggerControlIDConverter : System.ComponentModel.StringConverter
    {
        [System.MonoNotSupportedAttribute("")]
        public PostBackTriggerControlIDConverter() { }
        [System.MonoNotSupportedAttribute("")]
        public override System.ComponentModel.TypeConverter.StandardValuesCollection GetStandardValues(System.ComponentModel.ITypeDescriptorContext context) { throw null; }
        [System.MonoNotSupportedAttribute("")]
        public override bool GetStandardValuesExclusive(System.ComponentModel.ITypeDescriptorContext context) { throw null; }
        [System.MonoNotSupportedAttribute("")]
        public override bool GetStandardValuesSupported(System.ComponentModel.ITypeDescriptorContext context) { throw null; }
    }
    public partial class QueryExtenderDesigner : System.Web.UI.Design.ControlDesigner
    {
        public QueryExtenderDesigner() { }
        public override string GetDesignTimeHtml() { throw null; }
    }
    public partial class ScriptManagerDesigner : System.Web.UI.Design.ControlDesigner
    {
        [System.MonoNotSupportedAttribute("")]
        public ScriptManagerDesigner() { }
        public static string GetApplicationServices(System.Web.UI.ScriptManager scriptManager, System.Collections.Generic.IEnumerable<System.Web.UI.ScriptManagerProxy> proxies) { throw null; }
        [System.MonoNotSupportedAttribute("")]
        public override string GetDesignTimeHtml() { throw null; }
        public static string GetProxyScript(System.Web.UI.ScriptManager scriptManager, System.Web.UI.ServiceReference serviceReference) { throw null; }
        public static string GetProxyUrl(System.Web.UI.ScriptManager scriptManager, System.Web.UI.ServiceReference serviceReference) { throw null; }
        public static string GetScriptFromWebResource(System.Reflection.Assembly assembly, string resourceName, System.Globalization.CultureInfo culture) { throw null; }
        public static System.Collections.ObjectModel.ReadOnlyCollection<System.Web.UI.ScriptReference> GetScriptReferences(System.Web.UI.ScriptManager scriptManager, System.Collections.Generic.IEnumerable<System.Web.UI.ScriptManagerProxy> proxies) { throw null; }
        public static System.Collections.ObjectModel.ReadOnlyCollection<System.Web.UI.ServiceReference> GetServiceReferences(System.Web.UI.ScriptManager scriptManager, System.Collections.Generic.IEnumerable<System.Web.UI.ScriptManagerProxy> proxies) { throw null; }
        public override void Initialize(System.ComponentModel.IComponent component) { }
    }
    public partial class ScriptManagerProxyDesigner : System.Web.UI.Design.ControlDesigner
    {
        [System.MonoNotSupportedAttribute("")]
        public ScriptManagerProxyDesigner() { }
        [System.MonoNotSupportedAttribute("")]
        public override string GetDesignTimeHtml() { throw null; }
        public override void Initialize(System.ComponentModel.IComponent component) { }
    }
    public partial class ServiceReferenceCollectionEditor : System.Web.UI.Design.CollectionEditorBase
    {
        public ServiceReferenceCollectionEditor(System.Type type) : base (default(System.Type)) { }
        protected override bool CanSelectMultipleInstances() { throw null; }
        protected override System.Type[] CreateNewItemTypes() { throw null; }
    }
    public partial class TimerDesigner : System.Web.UI.Design.ControlDesigner
    {
        [System.MonoNotSupportedAttribute("")]
        public TimerDesigner() { }
        [System.MonoNotSupportedAttribute("")]
        public override string GetDesignTimeHtml() { throw null; }
    }
    public partial class UpdatePanelDesigner : System.Web.UI.Design.ControlDesigner
    {
        [System.MonoNotSupportedAttribute("")]
        public UpdatePanelDesigner() { }
        [System.MonoNotSupportedAttribute("")]
        protected override bool UsePreviewControl { get { throw null; } }
        [System.MonoNotSupportedAttribute("")]
        public override string GetDesignTimeHtml(System.Web.UI.Design.DesignerRegionCollection regions) { throw null; }
        [System.MonoNotSupportedAttribute("")]
        public override string GetEditableDesignerRegionContent(System.Web.UI.Design.EditableDesignerRegion region) { throw null; }
        public override void Initialize(System.ComponentModel.IComponent component) { }
        [System.MonoNotSupportedAttribute("")]
        public override void OnComponentChanged(object sender, System.ComponentModel.Design.ComponentChangedEventArgs ce) { }
        [System.MonoNotSupportedAttribute("")]
        public override void SetEditableDesignerRegionContent(System.Web.UI.Design.EditableDesignerRegion region, string content) { }
    }
    public partial class UpdatePanelTriggerCollectionEditor : System.Web.UI.Design.CollectionEditorBase
    {
        [System.MonoNotSupportedAttribute("")]
        public UpdatePanelTriggerCollectionEditor(System.Type type) : base (default(System.Type)) { }
        [System.MonoNotSupportedAttribute("")]
        protected override bool CanSelectMultipleInstances() { throw null; }
        [System.MonoNotSupportedAttribute("")]
        protected override System.Type CreateCollectionItemType() { throw null; }
        [System.MonoNotSupportedAttribute("")]
        protected override System.Type[] CreateNewItemTypes() { throw null; }
        [System.MonoNotSupportedAttribute("")]
        public override object EditValue(System.ComponentModel.ITypeDescriptorContext context, System.IServiceProvider provider, object value) { throw null; }
    }
    public partial class UpdateProgressAssociatedUpdatePanelIDConverter : System.ComponentModel.StringConverter
    {
        [System.MonoNotSupportedAttribute("")]
        public UpdateProgressAssociatedUpdatePanelIDConverter() { }
        [System.MonoNotSupportedAttribute("")]
        public override System.ComponentModel.TypeConverter.StandardValuesCollection GetStandardValues(System.ComponentModel.ITypeDescriptorContext context) { throw null; }
        [System.MonoNotSupportedAttribute("")]
        public override bool GetStandardValuesExclusive(System.ComponentModel.ITypeDescriptorContext context) { throw null; }
        [System.MonoNotSupportedAttribute("")]
        public override bool GetStandardValuesSupported(System.ComponentModel.ITypeDescriptorContext context) { throw null; }
    }
    public partial class UpdateProgressDesigner : System.Web.UI.Design.ControlDesigner
    {
        [System.MonoNotSupportedAttribute("")]
        public UpdateProgressDesigner() { }
        [System.MonoNotSupportedAttribute("")]
        protected override bool UsePreviewControl { get { throw null; } }
        [System.MonoNotSupportedAttribute("")]
        public override string GetDesignTimeHtml(System.Web.UI.Design.DesignerRegionCollection regions) { throw null; }
        [System.MonoNotSupportedAttribute("")]
        public override string GetEditableDesignerRegionContent(System.Web.UI.Design.EditableDesignerRegion region) { throw null; }
        [System.MonoNotSupportedAttribute("")]
        public override void SetEditableDesignerRegionContent(System.Web.UI.Design.EditableDesignerRegion region, string content) { }
    }
}
namespace System.Web.UI.Design.WebControls
{
    public partial class DataPagerDesigner : System.Web.UI.Design.ControlDesigner
    {
        public DataPagerDesigner() { }
        public override System.ComponentModel.Design.DesignerActionListCollection ActionLists { get { throw null; } }
        public string PagedControlID { get { throw null; } set { } }
        public override System.Web.UI.Design.TemplateGroupCollection TemplateGroups { get { throw null; } }
        protected override bool UsePreviewControl { get { throw null; } }
        public override string GetDesignTimeHtml() { throw null; }
        protected override string GetEmptyDesignTimeHtml() { throw null; }
        public override void Initialize(System.ComponentModel.IComponent component) { }
        protected override void PreFilterProperties(System.Collections.IDictionary properties) { }
    }
    public partial class DataPagerFieldTypeEditor : System.Drawing.Design.UITypeEditor
    {
        public DataPagerFieldTypeEditor() { }
        public override object EditValue(System.ComponentModel.ITypeDescriptorContext context, System.IServiceProvider provider, object value) { throw null; }
        public override System.Drawing.Design.UITypeEditorEditStyle GetEditStyle(System.ComponentModel.ITypeDescriptorContext context) { throw null; }
    }
    public partial class LinqDataSourceDesigner : System.Web.UI.Design.DataSourceDesigner
    {
        public LinqDataSourceDesigner() { }
        public override System.ComponentModel.Design.DesignerActionListCollection ActionLists { get { throw null; } }
        public override bool CanConfigure { get { throw null; } }
        public override bool CanRefreshSchema { get { throw null; } }
        public string ContextTypeName { get { throw null; } set { } }
        public string Delete { get { throw null; } set { } }
        public bool EnableDelete { get { throw null; } set { } }
        public bool EnableInsert { get { throw null; } set { } }
        public bool EnableUpdate { get { throw null; } set { } }
        public string GroupBy { get { throw null; } set { } }
        public string Insert { get { throw null; } set { } }
        public string OrderBy { get { throw null; } set { } }
        public string OrderGroupsBy { get { throw null; } set { } }
        public string Select { get { throw null; } set { } }
        public System.IServiceProvider ServiceProvider { get { throw null; } }
        public string TableName { get { throw null; } set { } }
        public string Update { get { throw null; } set { } }
        public string Where { get { throw null; } set { } }
        public override void Configure() { }
        public override System.Web.UI.Design.DesignerDataSourceView GetView(string viewName) { throw null; }
        public override string[] GetViewNames() { throw null; }
        public override void Initialize(System.ComponentModel.IComponent component) { }
        protected override void PreFilterProperties(System.Collections.IDictionary properties) { }
        public override void RefreshSchema(bool preferSilent) { }
    }
    public partial class LinqDesignerDataSourceView : System.Web.UI.Design.DesignerDataSourceView
    {
        public LinqDesignerDataSourceView(System.Web.UI.Design.WebControls.LinqDataSourceDesigner owner) : base (default(System.Web.UI.Design.IDataSourceDesigner), default(string)) { }
        public override bool CanDelete { get { throw null; } }
        public override bool CanInsert { get { throw null; } }
        public override bool CanPage { get { throw null; } }
        public override bool CanSort { get { throw null; } }
        public override bool CanUpdate { get { throw null; } }
        public bool IsDataContext { get { throw null; } }
        public bool IsTableTypeTable { get { throw null; } }
        public override System.Web.UI.Design.IDataSourceViewSchema Schema { get { throw null; } }
        public override System.Collections.IEnumerable GetDesignTimeData(int minimumRows, out bool isSampleData) { isSampleData = default(bool); throw null; }
    }
    public partial class ListViewDesigner : System.Web.UI.Design.WebControls.DataBoundControlDesigner
    {
        public ListViewDesigner() { }
        public override System.ComponentModel.Design.DesignerActionListCollection ActionLists { get { throw null; } }
        protected override int SampleRowCount { get { throw null; } }
        protected override bool UsePreviewControl { get { throw null; } }
        public override string GetDesignTimeHtml() { throw null; }
        public override string GetDesignTimeHtml(System.Web.UI.Design.DesignerRegionCollection regions) { throw null; }
        public override string GetEditableDesignerRegionContent(System.Web.UI.Design.EditableDesignerRegion region) { throw null; }
        protected override string GetEmptyDesignTimeHtml() { throw null; }
        public override void Initialize(System.ComponentModel.IComponent component) { }
        public override void OnComponentChanged(object sender, System.ComponentModel.Design.ComponentChangedEventArgs ce) { }
        protected override void OnSchemaRefreshed() { }
        public override void SetEditableDesignerRegionContent(System.Web.UI.Design.EditableDesignerRegion region, string content) { }
    }
}
