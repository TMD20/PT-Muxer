// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

[assembly:System.Reflection.AssemblyVersionAttribute("4.0.0.0")]
[assembly:System.CLSCompliantAttribute(true)]
[assembly:System.Diagnostics.DebuggableAttribute((System.Diagnostics.DebuggableAttribute.DebuggingModes)(2))]
[assembly:System.Reflection.AssemblyCompanyAttribute("Mono development team")]
[assembly:System.Reflection.AssemblyCopyrightAttribute("(c) Various Mono authors")]
[assembly:System.Reflection.AssemblyDefaultAliasAttribute("System.Drawing.Design.dll")]
[assembly:System.Reflection.AssemblyDescriptionAttribute("System.Drawing.Design.dll")]
[assembly:System.Reflection.AssemblyFileVersionAttribute("4.7.2046.0")]
[assembly:System.Reflection.AssemblyInformationalVersionAttribute("4.7.2046.0")]
[assembly:System.Reflection.AssemblyProductAttribute("Mono Common Language Infrastructure")]
[assembly:System.Reflection.AssemblyTitleAttribute("System.Drawing.Design.dll")]
[assembly:System.Resources.NeutralResourcesLanguageAttribute("en-US")]
[assembly:System.Resources.SatelliteContractVersionAttribute("4.0.0.0")]
[assembly:System.Runtime.CompilerServices.CompilationRelaxationsAttribute(8)]
[assembly:System.Runtime.CompilerServices.ReferenceAssemblyAttribute]
[assembly:System.Runtime.CompilerServices.RuntimeCompatibilityAttribute(WrapNonExceptionThrows=true)]
[assembly:System.Runtime.InteropServices.ComVisibleAttribute(false)]
[assembly:System.Runtime.InteropServices.DefaultDllImportSearchPathsAttribute((System.Runtime.InteropServices.DllImportSearchPath)(2050))]
namespace System.Drawing.Design
{
    [System.Security.SecurityCriticalAttribute]
    [System.Security.Permissions.SecurityPermissionAttribute(System.Security.Permissions.SecurityAction.Demand, Flags=(System.Security.Permissions.SecurityPermissionFlag)(2))]
    [System.Security.Permissions.PermissionSetAttribute(System.Security.Permissions.SecurityAction.InheritanceDemand, Name="FullTrust")]
    public partial class BitmapEditor : System.Drawing.Design.ImageEditor
    {
        public BitmapEditor() { }
        protected override string[] GetExtensions() { throw null; }
        protected override string GetFileDialogDescription() { throw null; }
        protected override System.Drawing.Image LoadFromStream(System.IO.Stream stream) { throw null; }
    }
    [System.Security.Permissions.SecurityPermissionAttribute(System.Security.Permissions.SecurityAction.Demand, Flags=(System.Security.Permissions.SecurityPermissionFlag)(2))]
    public partial class ColorEditor : System.Drawing.Design.UITypeEditor
    {
        public ColorEditor() { }
        public override object EditValue(System.ComponentModel.ITypeDescriptorContext context, System.IServiceProvider provider, object value) { throw null; }
        public override System.Drawing.Design.UITypeEditorEditStyle GetEditStyle(System.ComponentModel.ITypeDescriptorContext context) { throw null; }
        public override bool GetPaintValueSupported(System.ComponentModel.ITypeDescriptorContext context) { throw null; }
        public override void PaintValue(System.Drawing.Design.PaintValueEventArgs e) { }
    }
    [System.Security.SecurityCriticalAttribute]
    [System.Security.Permissions.SecurityPermissionAttribute(System.Security.Permissions.SecurityAction.Demand, Flags=(System.Security.Permissions.SecurityPermissionFlag)(2))]
    [System.Security.Permissions.PermissionSetAttribute(System.Security.Permissions.SecurityAction.InheritanceDemand, Name="FullTrust")]
    public partial class ContentAlignmentEditor : System.Drawing.Design.UITypeEditor
    {
        public ContentAlignmentEditor() { }
        public override object EditValue(System.ComponentModel.ITypeDescriptorContext context, System.IServiceProvider provider, object value) { throw null; }
        public override System.Drawing.Design.UITypeEditorEditStyle GetEditStyle(System.ComponentModel.ITypeDescriptorContext context) { throw null; }
    }
    [System.Security.SecurityCriticalAttribute]
    [System.Security.Permissions.SecurityPermissionAttribute(System.Security.Permissions.SecurityAction.Demand, Flags=(System.Security.Permissions.SecurityPermissionFlag)(2))]
    [System.Security.Permissions.PermissionSetAttribute(System.Security.Permissions.SecurityAction.InheritanceDemand, Name="FullTrust")]
    public partial class CursorEditor : System.Drawing.Design.UITypeEditor
    {
        public CursorEditor() { }
        public override bool IsDropDownResizable { get { throw null; } }
        public override object EditValue(System.ComponentModel.ITypeDescriptorContext context, System.IServiceProvider provider, object value) { throw null; }
        public override System.Drawing.Design.UITypeEditorEditStyle GetEditStyle(System.ComponentModel.ITypeDescriptorContext context) { throw null; }
    }
    [System.Security.SecurityCriticalAttribute]
    [System.Security.Permissions.SecurityPermissionAttribute(System.Security.Permissions.SecurityAction.Demand, Flags=(System.Security.Permissions.SecurityPermissionFlag)(2))]
    [System.Security.Permissions.PermissionSetAttribute(System.Security.Permissions.SecurityAction.InheritanceDemand, Name="FullTrust")]
    public partial class FontEditor : System.Drawing.Design.UITypeEditor
    {
        public FontEditor() { }
        public override object EditValue(System.ComponentModel.ITypeDescriptorContext context, System.IServiceProvider provider, object value) { throw null; }
        public override System.Drawing.Design.UITypeEditorEditStyle GetEditStyle(System.ComponentModel.ITypeDescriptorContext context) { throw null; }
    }
    [System.Security.SecurityCriticalAttribute]
    [System.Security.Permissions.PermissionSetAttribute(System.Security.Permissions.SecurityAction.InheritanceDemand, Name="FullTrust")]
    public partial class FontNameEditor : System.Drawing.Design.UITypeEditor
    {
        public FontNameEditor() { }
        public override bool GetPaintValueSupported(System.ComponentModel.ITypeDescriptorContext context) { throw null; }
        public override void PaintValue(System.Drawing.Design.PaintValueEventArgs e) { }
    }
    [System.Security.Permissions.SecurityPermissionAttribute(System.Security.Permissions.SecurityAction.Demand, Flags=(System.Security.Permissions.SecurityPermissionFlag)(2))]
    public partial class IconEditor : System.Drawing.Design.UITypeEditor
    {
        public IconEditor() { }
        protected static string CreateExtensionsString(string[] extensions, string sep) { throw null; }
        protected static string CreateFilterEntry(System.Drawing.Design.IconEditor e) { throw null; }
        public override object EditValue(System.ComponentModel.ITypeDescriptorContext context, System.IServiceProvider provider, object value) { throw null; }
        public override System.Drawing.Design.UITypeEditorEditStyle GetEditStyle(System.ComponentModel.ITypeDescriptorContext context) { throw null; }
        protected virtual string[] GetExtensions() { throw null; }
        protected virtual string GetFileDialogDescription() { throw null; }
        public override bool GetPaintValueSupported(System.ComponentModel.ITypeDescriptorContext context) { throw null; }
        protected virtual System.Drawing.Icon LoadFromStream(System.IO.Stream stream) { throw null; }
        public override void PaintValue(System.Drawing.Design.PaintValueEventArgs e) { }
    }
    [System.Security.Permissions.SecurityPermissionAttribute(System.Security.Permissions.SecurityAction.Demand, Flags=(System.Security.Permissions.SecurityPermissionFlag)(2))]
    public partial class ImageEditor : System.Drawing.Design.UITypeEditor
    {
        public ImageEditor() { }
        protected static string CreateExtensionsString(string[] extensions, string sep) { throw null; }
        protected static string CreateFilterEntry(System.Drawing.Design.ImageEditor e) { throw null; }
        public override object EditValue(System.ComponentModel.ITypeDescriptorContext context, System.IServiceProvider provider, object value) { throw null; }
        public override System.Drawing.Design.UITypeEditorEditStyle GetEditStyle(System.ComponentModel.ITypeDescriptorContext context) { throw null; }
        protected virtual string[] GetExtensions() { throw null; }
        protected virtual string GetFileDialogDescription() { throw null; }
        protected virtual System.Type[] GetImageExtenders() { throw null; }
        public override bool GetPaintValueSupported(System.ComponentModel.ITypeDescriptorContext context) { throw null; }
        protected virtual System.Drawing.Image LoadFromStream(System.IO.Stream stream) { throw null; }
        public override void PaintValue(System.Drawing.Design.PaintValueEventArgs e) { }
    }
    [System.Security.SecurityCriticalAttribute]
    [System.Security.Permissions.SecurityPermissionAttribute(System.Security.Permissions.SecurityAction.Demand, Flags=(System.Security.Permissions.SecurityPermissionFlag)(2))]
    [System.Security.Permissions.PermissionSetAttribute(System.Security.Permissions.SecurityAction.InheritanceDemand, Name="FullTrust")]
    public partial class MetafileEditor : System.Drawing.Design.ImageEditor
    {
        public MetafileEditor() { }
        protected override string[] GetExtensions() { throw null; }
        protected override string GetFileDialogDescription() { throw null; }
        protected override System.Drawing.Image LoadFromStream(System.IO.Stream stream) { throw null; }
    }
    [System.SerializableAttribute]
    public partial class ToolboxItemContainer : System.Runtime.Serialization.ISerializable
    {
        public ToolboxItemContainer(System.Drawing.Design.ToolboxItem item) { }
        protected ToolboxItemContainer(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
        public ToolboxItemContainer(System.Windows.Forms.IDataObject data) { }
        public bool IsCreated { get { throw null; } }
        public bool IsTransient { get { throw null; } }
        public virtual System.Windows.Forms.IDataObject ToolboxData { get { throw null; } }
        public override bool Equals(object obj) { throw null; }
        public virtual System.Collections.ICollection GetFilter(System.Collections.ICollection creators) { throw null; }
        public override int GetHashCode() { throw null; }
        [System.Security.SecurityCriticalAttribute]
        protected virtual void GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
        public virtual System.Drawing.Design.ToolboxItem GetToolboxItem(System.Collections.ICollection creators) { throw null; }
        [System.Security.SecurityCriticalAttribute]
        void System.Runtime.Serialization.ISerializable.GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
        public void UpdateFilter(System.Drawing.Design.ToolboxItem item) { }
    }
    public sealed partial class ToolboxItemCreator
    {
        internal ToolboxItemCreator() { }
        public string Format { get { throw null; } }
        public System.Drawing.Design.ToolboxItem Create(System.Windows.Forms.IDataObject data) { throw null; }
    }
    [System.Security.SecurityCriticalAttribute]
    public abstract partial class ToolboxService : System.ComponentModel.Design.IComponentDiscoveryService, System.Drawing.Design.IToolboxService
    {
        protected ToolboxService() { }
        protected abstract System.Drawing.Design.CategoryNameCollection CategoryNames { get; }
        protected abstract string SelectedCategory { get; set; }
        protected abstract System.Drawing.Design.ToolboxItemContainer SelectedItemContainer { get; set; }
        System.Drawing.Design.CategoryNameCollection System.Drawing.Design.IToolboxService.CategoryNames { get { throw null; } }
        string System.Drawing.Design.IToolboxService.SelectedCategory { get { throw null; } set { } }
        protected virtual System.Drawing.Design.ToolboxItemContainer CreateItemContainer(System.Drawing.Design.ToolboxItem item, System.ComponentModel.Design.IDesignerHost link) { throw null; }
        protected virtual System.Drawing.Design.ToolboxItemContainer CreateItemContainer(System.Windows.Forms.IDataObject dataObject) { throw null; }
        protected virtual void FilterChanged() { }
        protected abstract System.Collections.IList GetItemContainers();
        protected abstract System.Collections.IList GetItemContainers(string categoryName);
        public static System.Drawing.Design.ToolboxItem GetToolboxItem(System.Type toolType) { throw null; }
        public static System.Drawing.Design.ToolboxItem GetToolboxItem(System.Type toolType, bool nonPublic) { throw null; }
        public static System.Collections.ICollection GetToolboxItems(System.Reflection.Assembly a, string newCodeBase) { throw null; }
        public static System.Collections.ICollection GetToolboxItems(System.Reflection.Assembly a, string newCodeBase, bool throwOnError) { throw null; }
        public static System.Collections.ICollection GetToolboxItems(System.Reflection.AssemblyName an) { throw null; }
        public static System.Collections.ICollection GetToolboxItems(System.Reflection.AssemblyName an, bool throwOnError) { throw null; }
        protected virtual bool IsItemContainer(System.Windows.Forms.IDataObject dataObject, System.ComponentModel.Design.IDesignerHost host) { throw null; }
        protected bool IsItemContainerSupported(System.Drawing.Design.ToolboxItemContainer container, System.ComponentModel.Design.IDesignerHost host) { throw null; }
        protected abstract void Refresh();
        protected virtual void SelectedItemContainerUsed() { }
        protected virtual bool SetCursor() { throw null; }
        System.Collections.ICollection System.ComponentModel.Design.IComponentDiscoveryService.GetComponentTypes(System.ComponentModel.Design.IDesignerHost designerHost, System.Type baseType) { throw null; }
        void System.Drawing.Design.IToolboxService.AddCreator(System.Drawing.Design.ToolboxItemCreatorCallback creator, string format) { }
        void System.Drawing.Design.IToolboxService.AddCreator(System.Drawing.Design.ToolboxItemCreatorCallback creator, string format, System.ComponentModel.Design.IDesignerHost host) { }
        void System.Drawing.Design.IToolboxService.AddLinkedToolboxItem(System.Drawing.Design.ToolboxItem toolboxItem, System.ComponentModel.Design.IDesignerHost host) { }
        void System.Drawing.Design.IToolboxService.AddLinkedToolboxItem(System.Drawing.Design.ToolboxItem toolboxItem, string category, System.ComponentModel.Design.IDesignerHost host) { }
        void System.Drawing.Design.IToolboxService.AddToolboxItem(System.Drawing.Design.ToolboxItem toolboxItem) { }
        void System.Drawing.Design.IToolboxService.AddToolboxItem(System.Drawing.Design.ToolboxItem toolboxItem, string category) { }
        System.Drawing.Design.ToolboxItem System.Drawing.Design.IToolboxService.DeserializeToolboxItem(object serializedObject) { throw null; }
        System.Drawing.Design.ToolboxItem System.Drawing.Design.IToolboxService.DeserializeToolboxItem(object serializedObject, System.ComponentModel.Design.IDesignerHost host) { throw null; }
        System.Drawing.Design.ToolboxItem System.Drawing.Design.IToolboxService.GetSelectedToolboxItem() { throw null; }
        System.Drawing.Design.ToolboxItem System.Drawing.Design.IToolboxService.GetSelectedToolboxItem(System.ComponentModel.Design.IDesignerHost host) { throw null; }
        System.Drawing.Design.ToolboxItemCollection System.Drawing.Design.IToolboxService.GetToolboxItems() { throw null; }
        System.Drawing.Design.ToolboxItemCollection System.Drawing.Design.IToolboxService.GetToolboxItems(System.ComponentModel.Design.IDesignerHost host) { throw null; }
        System.Drawing.Design.ToolboxItemCollection System.Drawing.Design.IToolboxService.GetToolboxItems(string category) { throw null; }
        System.Drawing.Design.ToolboxItemCollection System.Drawing.Design.IToolboxService.GetToolboxItems(string category, System.ComponentModel.Design.IDesignerHost host) { throw null; }
        bool System.Drawing.Design.IToolboxService.IsSupported(object serializedObject, System.Collections.ICollection filterAttributes) { throw null; }
        bool System.Drawing.Design.IToolboxService.IsSupported(object serializedObject, System.ComponentModel.Design.IDesignerHost host) { throw null; }
        bool System.Drawing.Design.IToolboxService.IsToolboxItem(object serializedObject) { throw null; }
        bool System.Drawing.Design.IToolboxService.IsToolboxItem(object serializedObject, System.ComponentModel.Design.IDesignerHost host) { throw null; }
        void System.Drawing.Design.IToolboxService.Refresh() { }
        void System.Drawing.Design.IToolboxService.RemoveCreator(string format) { }
        void System.Drawing.Design.IToolboxService.RemoveCreator(string format, System.ComponentModel.Design.IDesignerHost host) { }
        void System.Drawing.Design.IToolboxService.RemoveToolboxItem(System.Drawing.Design.ToolboxItem toolboxItem) { }
        void System.Drawing.Design.IToolboxService.RemoveToolboxItem(System.Drawing.Design.ToolboxItem toolboxItem, string category) { }
        void System.Drawing.Design.IToolboxService.SelectedToolboxItemUsed() { }
        object System.Drawing.Design.IToolboxService.SerializeToolboxItem(System.Drawing.Design.ToolboxItem toolboxItem) { throw null; }
        bool System.Drawing.Design.IToolboxService.SetCursor() { throw null; }
        void System.Drawing.Design.IToolboxService.SetSelectedToolboxItem(System.Drawing.Design.ToolboxItem toolboxItem) { }
        public static void UnloadToolboxItems() { }
    }
}
