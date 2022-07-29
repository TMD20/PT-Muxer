// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

[assembly:System.Reflection.AssemblyVersionAttribute("4.0.0.0")]
[assembly:System.CLSCompliantAttribute(true)]
[assembly:System.Reflection.AssemblyCompanyAttribute("Mono development team")]
[assembly:System.Reflection.AssemblyCopyrightAttribute("(c) Various Mono authors")]
[assembly:System.Reflection.AssemblyDefaultAliasAttribute("System.Web.Extensions.Design.dll")]
[assembly:System.Reflection.AssemblyDescriptionAttribute("System.Web.Extensions.Design.dll")]
[assembly:System.Reflection.AssemblyFileVersionAttribute("4.0.30319.1")]
[assembly:System.Reflection.AssemblyInformationalVersionAttribute("4.0.30319.1")]
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
        [System.MonoNotSupportedAttribute("")]
        public override string GetDesignTimeHtml() { throw null; }
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
    public partial class ScriptManagerDesigner : System.Web.UI.Design.ControlDesigner
    {
        [System.MonoNotSupportedAttribute("")]
        public ScriptManagerDesigner() { }
        [System.MonoNotSupportedAttribute("")]
        public override string GetDesignTimeHtml() { throw null; }
    }
    public partial class ScriptManagerProxyDesigner : System.Web.UI.Design.ControlDesigner
    {
        [System.MonoNotSupportedAttribute("")]
        public ScriptManagerProxyDesigner() { }
        [System.MonoNotSupportedAttribute("")]
        public override string GetDesignTimeHtml() { throw null; }
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
