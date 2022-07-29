// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

[assembly:System.Reflection.AssemblyVersionAttribute("4.0.0.0")]
[assembly:System.CLSCompliantAttribute(true)]
[assembly:System.Diagnostics.DebuggableAttribute(System.Diagnostics.DebuggableAttribute.DebuggingModes.IgnoreSymbolStoreSequencePoints)]
[assembly:System.Drawing.BitmapSuffixInSatelliteAssemblyAttribute]
[assembly:System.Reflection.AssemblyCompanyAttribute("Mono development team")]
[assembly:System.Reflection.AssemblyCopyrightAttribute("(c) Various Mono authors")]
[assembly:System.Reflection.AssemblyDefaultAliasAttribute("System.Design.dll")]
[assembly:System.Reflection.AssemblyDescriptionAttribute("System.Design.dll")]
[assembly:System.Reflection.AssemblyFileVersionAttribute("4.8.3761.0")]
[assembly:System.Reflection.AssemblyInformationalVersionAttribute("4.8.3761.0")]
[assembly:System.Reflection.AssemblyProductAttribute("Mono Common Language Infrastructure")]
[assembly:System.Reflection.AssemblyTitleAttribute("System.Design.dll")]
[assembly:System.Resources.NeutralResourcesLanguageAttribute("en-US")]
[assembly:System.Resources.SatelliteContractVersionAttribute("4.0.0.0")]
[assembly:System.Runtime.CompilerServices.CompilationRelaxationsAttribute(8)]
[assembly:System.Runtime.CompilerServices.ReferenceAssemblyAttribute]
[assembly:System.Runtime.CompilerServices.RuntimeCompatibilityAttribute(WrapNonExceptionThrows=true)]
[assembly:System.Runtime.InteropServices.ComCompatibleVersionAttribute(1, 0, 3300, 0)]
[assembly:System.Runtime.InteropServices.ComVisibleAttribute(false)]
[assembly:System.Runtime.InteropServices.DefaultDllImportSearchPathsAttribute(System.Runtime.InteropServices.DllImportSearchPath.AssemblyDirectory | System.Runtime.InteropServices.DllImportSearchPath.System32)]
[assembly:System.Security.Permissions.SecurityPermissionAttribute(System.Security.Permissions.SecurityAction.RequestMinimum, SkipVerification=true)]
namespace System.ComponentModel.Design
{
    public partial class ActiveDesignSurfaceChangedEventArgs : System.EventArgs
    {
        public ActiveDesignSurfaceChangedEventArgs(System.ComponentModel.Design.DesignSurface oldSurface, System.ComponentModel.Design.DesignSurface newSurface) { }
        public System.ComponentModel.Design.DesignSurface NewSurface { get { throw null; } }
        public System.ComponentModel.Design.DesignSurface OldSurface { get { throw null; } }
    }
    public delegate void ActiveDesignSurfaceChangedEventHandler(object sender, System.ComponentModel.Design.ActiveDesignSurfaceChangedEventArgs e);
    public partial class ArrayEditor : System.ComponentModel.Design.CollectionEditor
    {
        public ArrayEditor(System.Type type) : base (default(System.Type)) { }
        protected override System.Type CreateCollectionItemType() { throw null; }
        protected override object[] GetItems(object editValue) { throw null; }
        protected override object SetItems(object editValue, object[] value) { throw null; }
    }
    public sealed partial class BinaryEditor : System.Drawing.Design.UITypeEditor
    {
        public BinaryEditor() { }
        public override object EditValue(System.ComponentModel.ITypeDescriptorContext context, System.IServiceProvider provider, object value) { throw null; }
        public override System.Drawing.Design.UITypeEditorEditStyle GetEditStyle(System.ComponentModel.ITypeDescriptorContext context) { throw null; }
    }
    [System.ComponentModel.DesignTimeVisibleAttribute(false)]
    [System.ComponentModel.ToolboxItemAttribute(false)]
    public partial class ByteViewer : System.Windows.Forms.TableLayoutPanel
    {
        public ByteViewer() { }
        public virtual byte[] GetBytes() { throw null; }
        public virtual System.ComponentModel.Design.DisplayMode GetDisplayMode() { throw null; }
        protected override void OnKeyDown(System.Windows.Forms.KeyEventArgs e) { }
        protected override void OnLayout(System.Windows.Forms.LayoutEventArgs e) { }
        protected override void OnPaint(System.Windows.Forms.PaintEventArgs e) { }
        public virtual void SaveToFile(string path) { }
        protected virtual void ScrollChanged(object source, System.EventArgs e) { }
        public virtual void SetBytes(byte[] bytes) { }
        public virtual void SetDisplayMode(System.ComponentModel.Design.DisplayMode mode) { }
        public virtual void SetFile(string path) { }
        public virtual void SetStartLine(int line) { }
    }
    public partial class CollectionEditor : System.Drawing.Design.UITypeEditor
    {
        public CollectionEditor(System.Type type) { }
        protected System.Type CollectionItemType { get { throw null; } }
        protected System.Type CollectionType { get { throw null; } }
        protected System.ComponentModel.ITypeDescriptorContext Context { get { throw null; } }
        protected virtual string HelpTopic { get { throw null; } }
        protected System.Type[] NewItemTypes { get { throw null; } }
        protected virtual void CancelChanges() { }
        protected virtual bool CanRemoveInstance(object value) { throw null; }
        protected virtual bool CanSelectMultipleInstances() { throw null; }
        protected virtual System.ComponentModel.Design.CollectionEditor.CollectionForm CreateCollectionForm() { throw null; }
        protected virtual System.Type CreateCollectionItemType() { throw null; }
        protected virtual object CreateInstance(System.Type itemType) { throw null; }
        protected virtual System.Type[] CreateNewItemTypes() { throw null; }
        protected virtual void DestroyInstance(object instance) { }
        public override object EditValue(System.ComponentModel.ITypeDescriptorContext context, System.IServiceProvider provider, object value) { throw null; }
        protected virtual string GetDisplayText(object value) { throw null; }
        public override System.Drawing.Design.UITypeEditorEditStyle GetEditStyle(System.ComponentModel.ITypeDescriptorContext context) { throw null; }
        protected virtual object[] GetItems(object editValue) { throw null; }
        protected virtual System.Collections.IList GetObjectsFromInstance(object instance) { throw null; }
        protected object GetService(System.Type serviceType) { throw null; }
        protected virtual object SetItems(object editValue, object[] value) { throw null; }
        protected virtual void ShowHelp() { }
        protected abstract partial class CollectionForm : System.Windows.Forms.Form
        {
            public CollectionForm(System.ComponentModel.Design.CollectionEditor editor) { }
            protected System.Type CollectionItemType { get { throw null; } }
            protected System.Type CollectionType { get { throw null; } }
            protected System.ComponentModel.ITypeDescriptorContext Context { get { throw null; } }
            public object EditValue { get { throw null; } set { } }
            protected object[] Items { get { throw null; } set { } }
            protected System.Type[] NewItemTypes { get { throw null; } }
            protected bool CanRemoveInstance(object value) { throw null; }
            protected virtual bool CanSelectMultipleInstances() { throw null; }
            protected object CreateInstance(System.Type itemType) { throw null; }
            protected void DestroyInstance(object instance) { }
            protected virtual void DisplayError(System.Exception e) { }
            protected override object GetService(System.Type serviceType) { throw null; }
            protected abstract void OnEditValueChanged();
            protected internal virtual System.Windows.Forms.DialogResult ShowEditorDialog(System.Windows.Forms.Design.IWindowsFormsEditorService edSvc) { throw null; }
        }
    }
    public enum ComponentActionsType
    {
        All = 0,
        Component = 1,
        Service = 2,
    }
    public partial class ComponentDesigner : System.ComponentModel.Design.IComponentInitializer, System.ComponentModel.Design.IDesigner, System.ComponentModel.Design.IDesignerFilter, System.ComponentModel.Design.ITreeDesigner, System.IDisposable
    {
        public ComponentDesigner() { }
        public virtual System.ComponentModel.Design.DesignerActionListCollection ActionLists { get { throw null; } }
        public virtual System.Collections.ICollection AssociatedComponents { get { throw null; } }
        public System.ComponentModel.IComponent Component { get { throw null; } }
        protected virtual System.ComponentModel.InheritanceAttribute InheritanceAttribute { get { throw null; } }
        protected bool Inherited { get { throw null; } }
        protected virtual System.ComponentModel.IComponent ParentComponent { get { throw null; } }
        protected System.ComponentModel.Design.ComponentDesigner.ShadowPropertyCollection ShadowProperties { get { throw null; } }
        System.Collections.ICollection System.ComponentModel.Design.ITreeDesigner.Children { get { throw null; } }
        System.ComponentModel.Design.IDesigner System.ComponentModel.Design.ITreeDesigner.Parent { get { throw null; } }
        public virtual System.ComponentModel.Design.DesignerVerbCollection Verbs { get { throw null; } }
        public void Dispose() { }
        protected virtual void Dispose(bool disposing) { }
        public virtual void DoDefaultAction() { }
        ~ComponentDesigner() { }
        protected virtual object GetService(System.Type serviceType) { throw null; }
        public virtual void Initialize(System.ComponentModel.IComponent component) { }
        public virtual void InitializeExistingComponent(System.Collections.IDictionary defaultValues) { }
        public virtual void InitializeNewComponent(System.Collections.IDictionary defaultValues) { }
        [System.ObsoleteAttribute("This method has been deprecated. Use InitializeExistingComponent instead.  http://go.microsoft.com/fwlink/?linkid=14202")]
        public virtual void InitializeNonDefault() { }
        protected System.ComponentModel.InheritanceAttribute InvokeGetInheritanceAttribute(System.ComponentModel.Design.ComponentDesigner toInvoke) { throw null; }
        [System.ObsoleteAttribute("This method has been deprecated. Use InitializeNewComponent instead.  http://go.microsoft.com/fwlink/?linkid=14202")]
        public virtual void OnSetComponentDefaults() { }
        protected virtual void PostFilterAttributes(System.Collections.IDictionary attributes) { }
        protected virtual void PostFilterEvents(System.Collections.IDictionary events) { }
        protected virtual void PostFilterProperties(System.Collections.IDictionary properties) { }
        protected virtual void PreFilterAttributes(System.Collections.IDictionary attributes) { }
        protected virtual void PreFilterEvents(System.Collections.IDictionary events) { }
        protected virtual void PreFilterProperties(System.Collections.IDictionary properties) { }
        protected void RaiseComponentChanged(System.ComponentModel.MemberDescriptor member, object oldValue, object newValue) { }
        protected void RaiseComponentChanging(System.ComponentModel.MemberDescriptor member) { }
        void System.ComponentModel.Design.IDesignerFilter.PostFilterAttributes(System.Collections.IDictionary attributes) { }
        void System.ComponentModel.Design.IDesignerFilter.PostFilterEvents(System.Collections.IDictionary events) { }
        void System.ComponentModel.Design.IDesignerFilter.PostFilterProperties(System.Collections.IDictionary properties) { }
        void System.ComponentModel.Design.IDesignerFilter.PreFilterAttributes(System.Collections.IDictionary attributes) { }
        void System.ComponentModel.Design.IDesignerFilter.PreFilterEvents(System.Collections.IDictionary events) { }
        void System.ComponentModel.Design.IDesignerFilter.PreFilterProperties(System.Collections.IDictionary properties) { }
        protected sealed partial class ShadowPropertyCollection
        {
            internal ShadowPropertyCollection() { }
            public object this[string propertyName] { get { throw null; } set { } }
            public bool Contains(string propertyName) { throw null; }
        }
    }
    public partial class DateTimeEditor : System.Drawing.Design.UITypeEditor
    {
        public DateTimeEditor() { }
        public override object EditValue(System.ComponentModel.ITypeDescriptorContext context, System.IServiceProvider provider, object value) { throw null; }
        public override System.Drawing.Design.UITypeEditorEditStyle GetEditStyle(System.ComponentModel.ITypeDescriptorContext context) { throw null; }
    }
    public sealed partial class DesignerActionHeaderItem : System.ComponentModel.Design.DesignerActionTextItem
    {
        public DesignerActionHeaderItem(string displayName) : base (default(string), default(string)) { }
        public DesignerActionHeaderItem(string displayName, string category) : base (default(string), default(string)) { }
    }
    public abstract partial class DesignerActionItem
    {
        public DesignerActionItem(string displayName, string category, string description) { }
        public bool AllowAssociate { get { throw null; } set { } }
        public virtual string Category { get { throw null; } }
        public virtual string Description { get { throw null; } }
        public virtual string DisplayName { get { throw null; } }
        public System.Collections.IDictionary Properties { get { throw null; } }
        public bool ShowInSourceView { get { throw null; } set { } }
    }
    public partial class DesignerActionItemCollection : System.Collections.CollectionBase
    {
        public DesignerActionItemCollection() { }
        public System.ComponentModel.Design.DesignerActionItem this[int index] { get { throw null; } set { } }
        public int Add(System.ComponentModel.Design.DesignerActionItem value) { throw null; }
        public bool Contains(System.ComponentModel.Design.DesignerActionItem value) { throw null; }
        public void CopyTo(System.ComponentModel.Design.DesignerActionItem[] array, int index) { }
        public int IndexOf(System.ComponentModel.Design.DesignerActionItem value) { throw null; }
        public void Insert(int index, System.ComponentModel.Design.DesignerActionItem value) { }
        public void Remove(System.ComponentModel.Design.DesignerActionItem value) { }
    }
    public partial class DesignerActionList
    {
        public DesignerActionList(System.ComponentModel.IComponent component) { }
        public virtual bool AutoShow { get { throw null; } set { } }
        public System.ComponentModel.IComponent Component { get { throw null; } }
        public object GetService(System.Type serviceType) { throw null; }
        public virtual System.ComponentModel.Design.DesignerActionItemCollection GetSortedActionItems() { throw null; }
    }
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    [System.Security.SecurityCriticalAttribute]
    [System.Security.Permissions.PermissionSetAttribute(System.Security.Permissions.SecurityAction.InheritanceDemand, Name="FullTrust")]
    public partial class DesignerActionListCollection : System.Collections.CollectionBase
    {
        public DesignerActionListCollection() { }
        public DesignerActionListCollection(System.ComponentModel.Design.DesignerActionList[] value) { }
        public System.ComponentModel.Design.DesignerActionList this[int index] { get { throw null; } set { } }
        public int Add(System.ComponentModel.Design.DesignerActionList value) { throw null; }
        public void AddRange(System.ComponentModel.Design.DesignerActionListCollection value) { }
        public void AddRange(System.ComponentModel.Design.DesignerActionList[] value) { }
        public bool Contains(System.ComponentModel.Design.DesignerActionList value) { throw null; }
        public void CopyTo(System.ComponentModel.Design.DesignerActionList[] array, int index) { }
        public int IndexOf(System.ComponentModel.Design.DesignerActionList value) { throw null; }
        public void Insert(int index, System.ComponentModel.Design.DesignerActionList value) { }
        protected override void OnClear() { }
        protected override void OnInsert(int index, object value) { }
        protected override void OnRemove(int index, object value) { }
        protected override void OnSet(int index, object oldValue, object newValue) { }
        protected override void OnValidate(object value) { }
        public void Remove(System.ComponentModel.Design.DesignerActionList value) { }
    }
    public partial class DesignerActionListsChangedEventArgs : System.EventArgs
    {
        public DesignerActionListsChangedEventArgs(object relatedObject, System.ComponentModel.Design.DesignerActionListsChangedType changeType, System.ComponentModel.Design.DesignerActionListCollection actionLists) { }
        public System.ComponentModel.Design.DesignerActionListCollection ActionLists { get { throw null; } }
        public System.ComponentModel.Design.DesignerActionListsChangedType ChangeType { get { throw null; } }
        public object RelatedObject { get { throw null; } }
    }
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public delegate void DesignerActionListsChangedEventHandler(object sender, System.ComponentModel.Design.DesignerActionListsChangedEventArgs e);
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public enum DesignerActionListsChangedType
    {
        ActionListsAdded = 0,
        ActionListsRemoved = 1,
    }
    public partial class DesignerActionMethodItem : System.ComponentModel.Design.DesignerActionItem
    {
        public DesignerActionMethodItem(System.ComponentModel.Design.DesignerActionList actionList, string memberName, string displayName) : base (default(string), default(string), default(string)) { }
        public DesignerActionMethodItem(System.ComponentModel.Design.DesignerActionList actionList, string memberName, string displayName, bool includeAsDesignerVerb) : base (default(string), default(string), default(string)) { }
        public DesignerActionMethodItem(System.ComponentModel.Design.DesignerActionList actionList, string memberName, string displayName, string category) : base (default(string), default(string), default(string)) { }
        public DesignerActionMethodItem(System.ComponentModel.Design.DesignerActionList actionList, string memberName, string displayName, string category, bool includeAsDesignerVerb) : base (default(string), default(string), default(string)) { }
        public DesignerActionMethodItem(System.ComponentModel.Design.DesignerActionList actionList, string memberName, string displayName, string category, string description) : base (default(string), default(string), default(string)) { }
        public DesignerActionMethodItem(System.ComponentModel.Design.DesignerActionList actionList, string memberName, string displayName, string category, string description, bool includeAsDesignerVerb) : base (default(string), default(string), default(string)) { }
        public virtual bool IncludeAsDesignerVerb { get { throw null; } }
        public virtual string MemberName { get { throw null; } }
        public System.ComponentModel.IComponent RelatedComponent { get { throw null; } set { } }
        public virtual void Invoke() { }
    }
    public sealed partial class DesignerActionPropertyItem : System.ComponentModel.Design.DesignerActionItem
    {
        public DesignerActionPropertyItem(string memberName, string displayName) : base (default(string), default(string), default(string)) { }
        public DesignerActionPropertyItem(string memberName, string displayName, string category) : base (default(string), default(string), default(string)) { }
        public DesignerActionPropertyItem(string memberName, string displayName, string category, string description) : base (default(string), default(string), default(string)) { }
        public string MemberName { get { throw null; } }
        public System.ComponentModel.IComponent RelatedComponent { get { throw null; } set { } }
    }
    public partial class DesignerActionService : System.IDisposable
    {
        public DesignerActionService(System.IServiceProvider serviceProvider) { }
        public event System.ComponentModel.Design.DesignerActionListsChangedEventHandler DesignerActionListsChanged { add { } remove { } }
        public void Add(System.ComponentModel.IComponent comp, System.ComponentModel.Design.DesignerActionList actionList) { }
        public void Add(System.ComponentModel.IComponent comp, System.ComponentModel.Design.DesignerActionListCollection designerActionListCollection) { }
        public void Clear() { }
        public bool Contains(System.ComponentModel.IComponent comp) { throw null; }
        public void Dispose() { }
        protected virtual void Dispose(bool disposing) { }
        public System.ComponentModel.Design.DesignerActionListCollection GetComponentActions(System.ComponentModel.IComponent component) { throw null; }
        public virtual System.ComponentModel.Design.DesignerActionListCollection GetComponentActions(System.ComponentModel.IComponent component, System.ComponentModel.Design.ComponentActionsType type) { throw null; }
        protected virtual void GetComponentDesignerActions(System.ComponentModel.IComponent component, System.ComponentModel.Design.DesignerActionListCollection actionLists) { }
        protected virtual void GetComponentServiceActions(System.ComponentModel.IComponent component, System.ComponentModel.Design.DesignerActionListCollection actionLists) { }
        public void Remove(System.ComponentModel.Design.DesignerActionList actionList) { }
        public void Remove(System.ComponentModel.IComponent comp) { }
        public void Remove(System.ComponentModel.IComponent comp, System.ComponentModel.Design.DesignerActionList actionList) { }
    }
    public partial class DesignerActionTextItem : System.ComponentModel.Design.DesignerActionItem
    {
        public DesignerActionTextItem(string displayName, string category) : base (default(string), default(string), default(string)) { }
    }
    public sealed partial class DesignerActionUIService : System.IDisposable
    {
        internal DesignerActionUIService() { }
        public event System.ComponentModel.Design.DesignerActionUIStateChangeEventHandler DesignerActionUIStateChange { add { } remove { } }
        public void Dispose() { }
        public void HideUI(System.ComponentModel.IComponent component) { }
        public void Refresh(System.ComponentModel.IComponent component) { }
        public bool ShouldAutoShow(System.ComponentModel.IComponent component) { throw null; }
        public void ShowUI(System.ComponentModel.IComponent component) { }
    }
    public partial class DesignerActionUIStateChangeEventArgs : System.EventArgs
    {
        public DesignerActionUIStateChangeEventArgs(object relatedObject, System.ComponentModel.Design.DesignerActionUIStateChangeType changeType) { }
        public System.ComponentModel.Design.DesignerActionUIStateChangeType ChangeType { get { throw null; } }
        public object RelatedObject { get { throw null; } }
    }
    public delegate void DesignerActionUIStateChangeEventHandler(object sender, System.ComponentModel.Design.DesignerActionUIStateChangeEventArgs e);
    public enum DesignerActionUIStateChangeType
    {
        Hide = 1,
        Refresh = 2,
        Show = 0,
    }
    public partial class DesignerCommandSet
    {
        public DesignerCommandSet() { }
        public System.ComponentModel.Design.DesignerActionListCollection ActionLists { get { throw null; } }
        public System.ComponentModel.Design.DesignerVerbCollection Verbs { get { throw null; } }
        public virtual System.Collections.ICollection GetCommands(string name) { throw null; }
    }
    [System.Security.SecurityCriticalAttribute]
    [System.Security.Permissions.PermissionSetAttribute(System.Security.Permissions.SecurityAction.InheritanceDemand, Name="FullTrust")]
    public partial class DesignSurface : System.IDisposable, System.IServiceProvider
    {
        public DesignSurface() { }
        public DesignSurface(System.IServiceProvider parentProvider) { }
        public DesignSurface(System.IServiceProvider parentProvider, System.Type rootComponentType) { }
        public DesignSurface(System.Type rootComponentType) { }
        public System.ComponentModel.IContainer ComponentContainer { get { throw null; } }
        public bool DtelLoading { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public bool IsLoaded { get { throw null; } }
        public System.Collections.ICollection LoadErrors { get { throw null; } }
        protected System.ComponentModel.Design.ServiceContainer ServiceContainer { get { throw null; } }
        public object View { get { throw null; } }
        public event System.EventHandler Disposed { add { } remove { } }
        public event System.EventHandler Flushed { add { } remove { } }
        public event System.ComponentModel.Design.LoadedEventHandler Loaded { add { } remove { } }
        public event System.EventHandler Loading { add { } remove { } }
        public event System.EventHandler Unloaded { add { } remove { } }
        public event System.EventHandler Unloading { add { } remove { } }
        public event System.EventHandler ViewActivated { add { } remove { } }
        public void BeginLoad(System.ComponentModel.Design.Serialization.DesignerLoader loader) { }
        public void BeginLoad(System.Type rootComponentType) { }
        [System.ObsoleteAttribute("CreateComponent has been replaced by CreateInstance and will be removed after Beta2")]
        protected internal virtual System.ComponentModel.IComponent CreateComponent(System.Type componentType) { throw null; }
        protected internal virtual System.ComponentModel.Design.IDesigner CreateDesigner(System.ComponentModel.IComponent component, bool rootDesigner) { throw null; }
        protected internal virtual object CreateInstance(System.Type type) { throw null; }
        public System.ComponentModel.INestedContainer CreateNestedContainer(System.ComponentModel.IComponent owningComponent) { throw null; }
        public System.ComponentModel.INestedContainer CreateNestedContainer(System.ComponentModel.IComponent owningComponent, string containerName) { throw null; }
        public void Dispose() { }
        protected virtual void Dispose(bool disposing) { }
        public void Flush() { }
        public object GetService(System.Type serviceType) { throw null; }
        protected virtual void OnLoaded(System.ComponentModel.Design.LoadedEventArgs e) { }
        protected virtual void OnLoading(System.EventArgs e) { }
        protected virtual void OnUnloaded(System.EventArgs e) { }
        protected virtual void OnUnloading(System.EventArgs e) { }
        protected virtual void OnViewActivate(System.EventArgs e) { }
    }
    public sealed partial class DesignSurfaceCollection : System.Collections.ICollection, System.Collections.IEnumerable
    {
        internal DesignSurfaceCollection() { }
        public int Count { get { throw null; } }
        public System.ComponentModel.Design.DesignSurface this[int index] { get { throw null; } }
        int System.Collections.ICollection.Count { get { throw null; } }
        bool System.Collections.ICollection.IsSynchronized { get { throw null; } }
        object System.Collections.ICollection.SyncRoot { get { throw null; } }
        public void CopyTo(System.ComponentModel.Design.DesignSurface[] array, int index) { }
        public System.Collections.IEnumerator GetEnumerator() { throw null; }
        void System.Collections.ICollection.CopyTo(System.Array array, int index) { }
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { throw null; }
    }
    public partial class DesignSurfaceEventArgs : System.EventArgs
    {
        public DesignSurfaceEventArgs(System.ComponentModel.Design.DesignSurface surface) { }
        public System.ComponentModel.Design.DesignSurface Surface { get { throw null; } }
    }
    public delegate void DesignSurfaceEventHandler(object sender, System.ComponentModel.Design.DesignSurfaceEventArgs e);
    [System.Security.SecurityCriticalAttribute]
    [System.Security.Permissions.PermissionSetAttribute(System.Security.Permissions.SecurityAction.InheritanceDemand, Name="FullTrust")]
    public partial class DesignSurfaceManager : System.IDisposable, System.IServiceProvider
    {
        public DesignSurfaceManager() { }
        public DesignSurfaceManager(System.IServiceProvider parentProvider) { }
        public virtual System.ComponentModel.Design.DesignSurface ActiveDesignSurface { get { throw null; } set { } }
        public System.ComponentModel.Design.DesignSurfaceCollection DesignSurfaces { get { throw null; } }
        protected System.ComponentModel.Design.ServiceContainer ServiceContainer { get { throw null; } }
        public event System.ComponentModel.Design.ActiveDesignSurfaceChangedEventHandler ActiveDesignSurfaceChanged { add { } remove { } }
        public event System.ComponentModel.Design.DesignSurfaceEventHandler DesignSurfaceCreated { add { } remove { } }
        public event System.ComponentModel.Design.DesignSurfaceEventHandler DesignSurfaceDisposed { add { } remove { } }
        public event System.EventHandler SelectionChanged { add { } remove { } }
        public System.ComponentModel.Design.DesignSurface CreateDesignSurface() { throw null; }
        public System.ComponentModel.Design.DesignSurface CreateDesignSurface(System.IServiceProvider parentProvider) { throw null; }
        protected virtual System.ComponentModel.Design.DesignSurface CreateDesignSurfaceCore(System.IServiceProvider parentProvider) { throw null; }
        public void Dispose() { }
        protected virtual void Dispose(bool disposing) { }
        public object GetService(System.Type serviceType) { throw null; }
    }
    public enum DisplayMode
    {
        Ansi = 2,
        Auto = 4,
        Hexdump = 1,
        Unicode = 3,
    }
    [System.Security.SecurityCriticalAttribute]
    [System.Security.Permissions.PermissionSetAttribute(System.Security.Permissions.SecurityAction.InheritanceDemand, Name="FullTrust")]
    public abstract partial class EventBindingService : System.ComponentModel.Design.IEventBindingService
    {
        protected EventBindingService(System.IServiceProvider provider) { }
        protected abstract string CreateUniqueMethodName(System.ComponentModel.IComponent component, System.ComponentModel.EventDescriptor e);
        protected virtual void FreeMethod(System.ComponentModel.IComponent component, System.ComponentModel.EventDescriptor e, string methodName) { }
        protected abstract System.Collections.ICollection GetCompatibleMethods(System.ComponentModel.EventDescriptor e);
        protected object GetService(System.Type serviceType) { throw null; }
        protected abstract bool ShowCode();
        protected abstract bool ShowCode(System.ComponentModel.IComponent component, System.ComponentModel.EventDescriptor e, string methodName);
        protected abstract bool ShowCode(int lineNumber);
        string System.ComponentModel.Design.IEventBindingService.CreateUniqueMethodName(System.ComponentModel.IComponent component, System.ComponentModel.EventDescriptor e) { throw null; }
        System.Collections.ICollection System.ComponentModel.Design.IEventBindingService.GetCompatibleMethods(System.ComponentModel.EventDescriptor e) { throw null; }
        System.ComponentModel.EventDescriptor System.ComponentModel.Design.IEventBindingService.GetEvent(System.ComponentModel.PropertyDescriptor property) { throw null; }
        System.ComponentModel.PropertyDescriptorCollection System.ComponentModel.Design.IEventBindingService.GetEventProperties(System.ComponentModel.EventDescriptorCollection events) { throw null; }
        System.ComponentModel.PropertyDescriptor System.ComponentModel.Design.IEventBindingService.GetEventProperty(System.ComponentModel.EventDescriptor e) { throw null; }
        bool System.ComponentModel.Design.IEventBindingService.ShowCode() { throw null; }
        bool System.ComponentModel.Design.IEventBindingService.ShowCode(System.ComponentModel.IComponent component, System.ComponentModel.EventDescriptor e) { throw null; }
        bool System.ComponentModel.Design.IEventBindingService.ShowCode(int lineNumber) { throw null; }
        protected virtual void UseMethod(System.ComponentModel.IComponent component, System.ComponentModel.EventDescriptor e, string methodName) { }
        protected virtual void ValidateMethodName(string methodName) { }
    }
    [System.SerializableAttribute]
    public sealed partial class ExceptionCollection : System.Exception
    {
        public ExceptionCollection(System.Collections.ArrayList exceptions) { }
        public System.Collections.ArrayList Exceptions { get { throw null; } }
        [System.Security.SecurityCriticalAttribute]
        public override void GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
    }
    public partial interface IComponentDesignerDebugService
    {
        int IndentLevel { get; set; }
        System.Diagnostics.TraceListenerCollection Listeners { get; }
        void Assert(bool condition, string message);
        void Fail(string message);
        void Trace(string message, string category);
    }
    public partial interface IComponentDesignerStateService
    {
        object GetState(System.ComponentModel.IComponent component, string key);
        void SetState(System.ComponentModel.IComponent component, string key, object value);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute(false)]
    [System.Runtime.InteropServices.GuidAttribute("665f0ba5-ce72-4e87-9ba0-3c461de74d0b")]
    [System.Runtime.InteropServices.InterfaceTypeAttribute(System.Runtime.InteropServices.ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IDesignTimeAssemblyLoader
    {
        string GetTargetAssemblyPath(System.Reflection.AssemblyName runtimeOrTargetAssemblyName, string suggestedAssemblyPath, System.Runtime.Versioning.FrameworkName targetFramework);
        System.Reflection.Assembly LoadRuntimeAssembly(System.Reflection.AssemblyName targetAssemblyName);
    }
    public partial interface IMultitargetHelperService
    {
        string GetAssemblyQualifiedName(System.Type type);
    }
    public partial class InheritanceService : System.ComponentModel.Design.IInheritanceService, System.IDisposable
    {
        public InheritanceService() { }
        public void AddInheritedComponents(System.ComponentModel.IComponent component, System.ComponentModel.IContainer container) { }
        protected virtual void AddInheritedComponents(System.Type type, System.ComponentModel.IComponent component, System.ComponentModel.IContainer container) { }
        public void Dispose() { }
        protected virtual void Dispose(bool disposing) { }
        public System.ComponentModel.InheritanceAttribute GetInheritanceAttribute(System.ComponentModel.IComponent component) { throw null; }
        protected virtual bool IgnoreInheritedMember(System.Reflection.MemberInfo member, System.ComponentModel.IComponent component) { throw null; }
    }
    public sealed partial class LoadedEventArgs : System.EventArgs
    {
        public LoadedEventArgs(bool succeeded, System.Collections.ICollection errors) { }
        public System.Collections.ICollection Errors { get { throw null; } }
        public bool HasSucceeded { get { throw null; } }
    }
    public delegate void LoadedEventHandler(object sender, System.ComponentModel.Design.LoadedEventArgs e);
    [System.ComponentModel.ProvidePropertyAttribute("Language", typeof(object))]
    [System.ComponentModel.ProvidePropertyAttribute("LoadLanguage", typeof(object))]
    [System.ComponentModel.ProvidePropertyAttribute("Localizable", typeof(object))]
    [System.ObsoleteAttribute("This class has been deprecated. Use CodeDomLocalizationProvider instead.  http://go.microsoft.com/fwlink/?linkid=14202")]
    public partial class LocalizationExtenderProvider : System.ComponentModel.IExtenderProvider, System.IDisposable
    {
        public LocalizationExtenderProvider(System.ComponentModel.ISite serviceProvider, System.ComponentModel.IComponent baseComponent) { }
        public bool CanExtend(object o) { throw null; }
        public void Dispose() { }
        protected virtual void Dispose(bool disposing) { }
        [System.ComponentModel.DesignOnlyAttribute(true)]
        [System.ComponentModel.LocalizableAttribute(true)]
        public System.Globalization.CultureInfo GetLanguage(object o) { throw null; }
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.DesignerSerializationVisibilityAttribute(System.ComponentModel.DesignerSerializationVisibility.Hidden)]
        [System.ComponentModel.DesignOnlyAttribute(true)]
        public System.Globalization.CultureInfo GetLoadLanguage(object o) { throw null; }
        [System.ComponentModel.DesignOnlyAttribute(true)]
        [System.ComponentModel.LocalizableAttribute(true)]
        public bool GetLocalizable(object o) { throw null; }
        public void ResetLanguage(object o) { }
        public void SetLanguage(object o, System.Globalization.CultureInfo language) { }
        public void SetLocalizable(object o, bool localizable) { }
        public bool ShouldSerializeLanguage(object o) { throw null; }
    }
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial class MenuCommandsChangedEventArgs : System.EventArgs
    {
        public MenuCommandsChangedEventArgs(System.ComponentModel.Design.MenuCommandsChangedType changeType, System.ComponentModel.Design.MenuCommand command) { }
        public System.ComponentModel.Design.MenuCommandsChangedType ChangeType { get { throw null; } }
        public System.ComponentModel.Design.MenuCommand Command { get { throw null; } }
    }
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public delegate void MenuCommandsChangedEventHandler(object sender, System.ComponentModel.Design.MenuCommandsChangedEventArgs e);
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public enum MenuCommandsChangedType
    {
        CommandAdded = 0,
        CommandChanged = 2,
        CommandRemoved = 1,
    }
    public partial class MenuCommandService : System.ComponentModel.Design.IMenuCommandService, System.IDisposable
    {
        public MenuCommandService(System.IServiceProvider serviceProvider) { }
        public virtual System.ComponentModel.Design.DesignerVerbCollection Verbs { get { throw null; } }
        public event System.ComponentModel.Design.MenuCommandsChangedEventHandler MenuCommandsChanged { add { } remove { } }
        public virtual void AddCommand(System.ComponentModel.Design.MenuCommand command) { }
        public virtual void AddVerb(System.ComponentModel.Design.DesignerVerb verb) { }
        public void Dispose() { }
        protected virtual void Dispose(bool disposing) { }
        protected void EnsureVerbs() { }
        public System.ComponentModel.Design.MenuCommand FindCommand(System.ComponentModel.Design.CommandID commandID) { throw null; }
        protected System.ComponentModel.Design.MenuCommand FindCommand(System.Guid guid, int id) { throw null; }
        protected System.Collections.ICollection GetCommandList(System.Guid guid) { throw null; }
        protected object GetService(System.Type serviceType) { throw null; }
        public virtual bool GlobalInvoke(System.ComponentModel.Design.CommandID commandID) { throw null; }
        public virtual bool GlobalInvoke(System.ComponentModel.Design.CommandID commandId, object arg) { throw null; }
        protected virtual void OnCommandsChanged(System.ComponentModel.Design.MenuCommandsChangedEventArgs e) { }
        public virtual void RemoveCommand(System.ComponentModel.Design.MenuCommand command) { }
        public virtual void RemoveVerb(System.ComponentModel.Design.DesignerVerb verb) { }
        public virtual void ShowContextMenu(System.ComponentModel.Design.CommandID menuID, int x, int y) { }
    }
    public sealed partial class MultilineStringEditor : System.Drawing.Design.UITypeEditor
    {
        public MultilineStringEditor() { }
        public override object EditValue(System.ComponentModel.ITypeDescriptorContext context, System.IServiceProvider provider, object value) { throw null; }
        public override System.Drawing.Design.UITypeEditorEditStyle GetEditStyle(System.ComponentModel.ITypeDescriptorContext context) { throw null; }
        public override bool GetPaintValueSupported(System.ComponentModel.ITypeDescriptorContext context) { throw null; }
    }
    public abstract partial class ObjectSelectorEditor : System.Drawing.Design.UITypeEditor
    {
        protected object currValue;
        protected object prevValue;
        public bool SubObjectSelector;
        public ObjectSelectorEditor() { }
        public ObjectSelectorEditor(bool subObjectSelector) { }
        public override object EditValue(System.ComponentModel.ITypeDescriptorContext context, System.IServiceProvider provider, object value) { throw null; }
        public bool EqualsToValue(object value) { throw null; }
        protected virtual void FillTreeWithData(System.ComponentModel.Design.ObjectSelectorEditor.Selector selector, System.ComponentModel.ITypeDescriptorContext context, System.IServiceProvider provider) { }
        public override System.Drawing.Design.UITypeEditorEditStyle GetEditStyle(System.ComponentModel.ITypeDescriptorContext context) { throw null; }
        public virtual void SetValue(object value) { }
        public partial class Selector : System.Windows.Forms.TreeView
        {
            public bool clickSeen;
            public Selector(System.ComponentModel.Design.ObjectSelectorEditor editor) { }
            public System.ComponentModel.Design.ObjectSelectorEditor.SelectorNode AddNode(string label, object value, System.ComponentModel.Design.ObjectSelectorEditor.SelectorNode parent) { throw null; }
            public void Clear() { }
            protected void OnAfterSelect(object sender, System.Windows.Forms.TreeViewEventArgs e) { }
            protected override void OnKeyDown(System.Windows.Forms.KeyEventArgs e) { }
            protected override void OnKeyPress(System.Windows.Forms.KeyPressEventArgs e) { }
            protected override void OnNodeMouseClick(System.Windows.Forms.TreeNodeMouseClickEventArgs e) { }
            public bool SetSelection(object value, System.Windows.Forms.TreeNodeCollection nodes) { throw null; }
            public void Start(System.Windows.Forms.Design.IWindowsFormsEditorService edSvc, object value) { }
            public void Stop() { }
            protected override void WndProc(ref System.Windows.Forms.Message m) { }
        }
        public partial class SelectorNode : System.Windows.Forms.TreeNode
        {
            public object value;
            public SelectorNode(string label, object value) { }
        }
    }
    [System.AttributeUsageAttribute(System.AttributeTargets.Class | System.AttributeTargets.Interface | System.AttributeTargets.Struct)]
    public sealed partial class ProjectTargetFrameworkAttribute : System.Attribute
    {
        public ProjectTargetFrameworkAttribute(string targetFrameworkMoniker) { }
        public string TargetFrameworkMoniker { get { throw null; } }
    }
    public abstract partial class UndoEngine : System.IDisposable
    {
        protected UndoEngine(System.IServiceProvider provider) { }
        public bool Enabled { get { throw null; } set { } }
        public bool UndoInProgress { get { throw null; } }
        public event System.EventHandler Undoing { add { } remove { } }
        public event System.EventHandler Undone { add { } remove { } }
        protected abstract void AddUndoUnit(System.ComponentModel.Design.UndoEngine.UndoUnit unit);
        protected virtual System.ComponentModel.Design.UndoEngine.UndoUnit CreateUndoUnit(string name, bool primary) { throw null; }
        protected virtual void DiscardUndoUnit(System.ComponentModel.Design.UndoEngine.UndoUnit unit) { }
        public void Dispose() { }
        protected virtual void Dispose(bool disposing) { }
        protected object GetRequiredService(System.Type serviceType) { throw null; }
        protected object GetService(System.Type serviceType) { throw null; }
        protected virtual void OnUndoing(System.EventArgs e) { }
        protected virtual void OnUndone(System.EventArgs e) { }
        protected partial class UndoUnit
        {
            public UndoUnit(System.ComponentModel.Design.UndoEngine engine, string name) { }
            public virtual bool IsEmpty { get { throw null; } }
            public string Name { get { throw null; } }
            protected System.ComponentModel.Design.UndoEngine UndoEngine { get { throw null; } }
            public virtual void Close() { }
            public virtual void ComponentAdded(System.ComponentModel.Design.ComponentEventArgs e) { }
            public virtual void ComponentAdding(System.ComponentModel.Design.ComponentEventArgs e) { }
            public virtual void ComponentChanged(System.ComponentModel.Design.ComponentChangedEventArgs e) { }
            public virtual void ComponentChanging(System.ComponentModel.Design.ComponentChangingEventArgs e) { }
            public virtual void ComponentRemoved(System.ComponentModel.Design.ComponentEventArgs e) { }
            public virtual void ComponentRemoving(System.ComponentModel.Design.ComponentEventArgs e) { }
            public virtual void ComponentRename(System.ComponentModel.Design.ComponentRenameEventArgs e) { }
            protected object GetService(System.Type serviceType) { throw null; }
            public override string ToString() { throw null; }
            public void Undo() { }
            protected virtual void UndoCore() { }
        }
    }
}
namespace System.ComponentModel.Design.Data
{
    public abstract partial class DataSourceDescriptor
    {
        protected DataSourceDescriptor() { }
        public abstract System.Drawing.Bitmap Image { get; }
        public abstract bool IsDesignable { get; }
        public abstract string Name { get; }
        public abstract string TypeName { get; }
    }
    public partial class DataSourceDescriptorCollection : System.Collections.CollectionBase
    {
        public DataSourceDescriptorCollection() { }
        public System.ComponentModel.Design.Data.DataSourceDescriptor this[int index] { get { throw null; } set { } }
        public int Add(System.ComponentModel.Design.Data.DataSourceDescriptor value) { throw null; }
        public bool Contains(System.ComponentModel.Design.Data.DataSourceDescriptor value) { throw null; }
        public void CopyTo(System.ComponentModel.Design.Data.DataSourceDescriptor[] array, int index) { }
        public int IndexOf(System.ComponentModel.Design.Data.DataSourceDescriptor value) { throw null; }
        public void Insert(int index, System.ComponentModel.Design.Data.DataSourceDescriptor value) { }
        public void Remove(System.ComponentModel.Design.Data.DataSourceDescriptor value) { }
    }
    public abstract partial class DataSourceGroup
    {
        protected DataSourceGroup() { }
        public abstract System.ComponentModel.Design.Data.DataSourceDescriptorCollection DataSources { get; }
        public abstract System.Drawing.Bitmap Image { get; }
        public abstract bool IsDefault { get; }
        public abstract string Name { get; }
    }
    public partial class DataSourceGroupCollection : System.Collections.CollectionBase
    {
        public DataSourceGroupCollection() { }
        public System.ComponentModel.Design.Data.DataSourceGroup this[int index] { get { throw null; } set { } }
        public int Add(System.ComponentModel.Design.Data.DataSourceGroup value) { throw null; }
        public bool Contains(System.ComponentModel.Design.Data.DataSourceGroup value) { throw null; }
        public void CopyTo(System.ComponentModel.Design.Data.DataSourceGroup[] array, int index) { }
        public int IndexOf(System.ComponentModel.Design.Data.DataSourceGroup value) { throw null; }
        public void Insert(int index, System.ComponentModel.Design.Data.DataSourceGroup value) { }
        public void Remove(System.ComponentModel.Design.Data.DataSourceGroup value) { }
    }
    [System.Runtime.InteropServices.GuidAttribute("ABE5C1F0-C96E-40c4-A22D-4A5CEC899BDC")]
    public abstract partial class DataSourceProviderService
    {
        protected DataSourceProviderService() { }
        public abstract bool SupportsAddNewDataSource { get; }
        public abstract bool SupportsConfigureDataSource { get; }
        public abstract object AddDataSourceInstance(System.ComponentModel.Design.IDesignerHost host, System.ComponentModel.Design.Data.DataSourceDescriptor dataSourceDescriptor);
        public abstract System.ComponentModel.Design.Data.DataSourceGroupCollection GetDataSources();
        public abstract System.ComponentModel.Design.Data.DataSourceGroup InvokeAddNewDataSource(System.Windows.Forms.IWin32Window parentWindow, System.Windows.Forms.FormStartPosition startPosition);
        public abstract bool InvokeConfigureDataSource(System.Windows.Forms.IWin32Window parentWindow, System.Windows.Forms.FormStartPosition startPosition, System.ComponentModel.Design.Data.DataSourceDescriptor dataSourceDescriptor);
        public abstract void NotifyDataSourceComponentAdded(object dsc);
    }
    public sealed partial class DesignerDataColumn
    {
        public DesignerDataColumn(string name, System.Data.DbType dataType) { }
        public DesignerDataColumn(string name, System.Data.DbType dataType, object defaultValue) { }
        public DesignerDataColumn(string name, System.Data.DbType dataType, object defaultValue, bool identity, bool nullable, bool primaryKey, int precision, int scale, int length) { }
        public System.Data.DbType DataType { get { throw null; } }
        public object DefaultValue { get { throw null; } }
        public bool Identity { get { throw null; } }
        public int Length { get { throw null; } }
        public string Name { get { throw null; } }
        public bool Nullable { get { throw null; } }
        public int Precision { get { throw null; } }
        public bool PrimaryKey { get { throw null; } }
        public int Scale { get { throw null; } }
    }
    public sealed partial class DesignerDataConnection
    {
        public DesignerDataConnection(string name, string providerName, string connectionString) { }
        public DesignerDataConnection(string name, string providerName, string connectionString, bool isConfigured) { }
        public string ConnectionString { get { throw null; } }
        public bool IsConfigured { get { throw null; } }
        public string Name { get { throw null; } }
        public string ProviderName { get { throw null; } }
    }
    public sealed partial class DesignerDataParameter
    {
        public DesignerDataParameter(string name, System.Data.DbType dataType, System.Data.ParameterDirection direction) { }
        public System.Data.DbType DataType { get { throw null; } }
        public System.Data.ParameterDirection Direction { get { throw null; } }
        public string Name { get { throw null; } }
    }
    public sealed partial class DesignerDataRelationship
    {
        public DesignerDataRelationship(string name, System.Collections.ICollection parentColumns, System.ComponentModel.Design.Data.DesignerDataTable childTable, System.Collections.ICollection childColumns) { }
        public System.Collections.ICollection ChildColumns { get { throw null; } }
        public System.ComponentModel.Design.Data.DesignerDataTable ChildTable { get { throw null; } }
        public string Name { get { throw null; } }
        public System.Collections.ICollection ParentColumns { get { throw null; } }
    }
    public sealed partial class DesignerDataSchemaClass
    {
        internal DesignerDataSchemaClass() { }
        public static readonly System.ComponentModel.Design.Data.DesignerDataSchemaClass StoredProcedures;
        public static readonly System.ComponentModel.Design.Data.DesignerDataSchemaClass Tables;
        public static readonly System.ComponentModel.Design.Data.DesignerDataSchemaClass Views;
    }
    public abstract partial class DesignerDataStoredProcedure
    {
        protected DesignerDataStoredProcedure(string name) { }
        protected DesignerDataStoredProcedure(string name, string owner) { }
        public string Name { get { throw null; } }
        public string Owner { get { throw null; } }
        public System.Collections.ICollection Parameters { get { throw null; } }
        protected abstract System.Collections.ICollection CreateParameters();
    }
    public abstract partial class DesignerDataTable : System.ComponentModel.Design.Data.DesignerDataTableBase
    {
        protected DesignerDataTable(string name) : base (default(string)) { }
        protected DesignerDataTable(string name, string owner) : base (default(string)) { }
        public System.Collections.ICollection Relationships { get { throw null; } }
        protected abstract System.Collections.ICollection CreateRelationships();
    }
    public abstract partial class DesignerDataTableBase
    {
        protected DesignerDataTableBase(string name) { }
        protected DesignerDataTableBase(string name, string owner) { }
        public System.Collections.ICollection Columns { get { throw null; } }
        public string Name { get { throw null; } }
        public string Owner { get { throw null; } }
        protected abstract System.Collections.ICollection CreateColumns();
    }
    public abstract partial class DesignerDataView : System.ComponentModel.Design.Data.DesignerDataTableBase
    {
        protected DesignerDataView(string name) : base (default(string)) { }
        protected DesignerDataView(string name, string owner) : base (default(string)) { }
    }
    public partial interface IDataEnvironment
    {
        System.Collections.ICollection Connections { get; }
        System.ComponentModel.Design.Data.DesignerDataConnection BuildConnection(System.Windows.Forms.IWin32Window owner, System.ComponentModel.Design.Data.DesignerDataConnection initialConnection);
        string BuildQuery(System.Windows.Forms.IWin32Window owner, System.ComponentModel.Design.Data.DesignerDataConnection connection, System.ComponentModel.Design.Data.QueryBuilderMode mode, string initialQueryText);
        System.ComponentModel.Design.Data.DesignerDataConnection ConfigureConnection(System.Windows.Forms.IWin32Window owner, System.ComponentModel.Design.Data.DesignerDataConnection connection, string name);
        System.CodeDom.CodeExpression GetCodeExpression(System.ComponentModel.Design.Data.DesignerDataConnection connection);
        System.ComponentModel.Design.Data.IDesignerDataSchema GetConnectionSchema(System.ComponentModel.Design.Data.DesignerDataConnection connection);
        System.Data.Common.DbConnection GetDesignTimeConnection(System.ComponentModel.Design.Data.DesignerDataConnection connection);
    }
    public partial interface IDesignerDataSchema
    {
        System.Collections.ICollection GetSchemaItems(System.ComponentModel.Design.Data.DesignerDataSchemaClass schemaClass);
        bool SupportsSchemaClass(System.ComponentModel.Design.Data.DesignerDataSchemaClass schemaClass);
    }
    public enum QueryBuilderMode
    {
        Delete = 3,
        Insert = 2,
        Select = 0,
        Update = 1,
    }
}
namespace System.ComponentModel.Design.Serialization
{
    [System.Security.SecurityCriticalAttribute]
    [System.Security.Permissions.PermissionSetAttribute(System.Security.Permissions.SecurityAction.InheritanceDemand, Name="FullTrust")]
    public abstract partial class BasicDesignerLoader : System.ComponentModel.Design.Serialization.DesignerLoader, System.ComponentModel.Design.Serialization.IDesignerLoaderService
    {
        protected BasicDesignerLoader() { }
        protected System.ComponentModel.Design.Serialization.IDesignerLoaderHost LoaderHost { get { throw null; } }
        public override bool Loading { get { throw null; } }
        protected virtual bool Modified { get { throw null; } set { } }
        protected object PropertyProvider { get { throw null; } set { } }
        protected bool ReloadPending { get { throw null; } }
        public override void BeginLoad(System.ComponentModel.Design.Serialization.IDesignerLoaderHost host) { }
        public override void Dispose() { }
        protected virtual bool EnableComponentNotification(bool enable) { throw null; }
        public override void Flush() { }
        protected object GetService(System.Type serviceType) { throw null; }
        protected virtual void Initialize() { }
        protected virtual bool IsReloadNeeded() { throw null; }
        protected virtual void OnBeginLoad() { }
        protected virtual void OnBeginUnload() { }
        protected virtual void OnEndLoad(bool successful, System.Collections.ICollection errors) { }
        protected virtual void OnModifying() { }
        protected abstract void PerformFlush(System.ComponentModel.Design.Serialization.IDesignerSerializationManager serializationManager);
        protected abstract void PerformLoad(System.ComponentModel.Design.Serialization.IDesignerSerializationManager serializationManager);
        protected void Reload(System.ComponentModel.Design.Serialization.BasicDesignerLoader.ReloadOptions flags) { }
        protected virtual void ReportFlushErrors(System.Collections.ICollection errors) { }
        protected void SetBaseComponentClassName(string name) { }
        void System.ComponentModel.Design.Serialization.IDesignerLoaderService.AddLoadDependency() { }
        void System.ComponentModel.Design.Serialization.IDesignerLoaderService.DependentLoadComplete(bool successful, System.Collections.ICollection errorCollection) { }
        bool System.ComponentModel.Design.Serialization.IDesignerLoaderService.Reload() { throw null; }
        [System.FlagsAttribute]
        protected enum ReloadOptions
        {
            Default = 0,
            Force = 2,
            ModifyOnError = 1,
            NoFlush = 4,
        }
    }
    public sealed partial class CodeDomComponentSerializationService : System.ComponentModel.Design.Serialization.ComponentSerializationService
    {
        public CodeDomComponentSerializationService() { }
        public CodeDomComponentSerializationService(System.IServiceProvider provider) { }
        public override System.ComponentModel.Design.Serialization.SerializationStore CreateStore() { throw null; }
        public override System.Collections.ICollection Deserialize(System.ComponentModel.Design.Serialization.SerializationStore store) { throw null; }
        public override System.Collections.ICollection Deserialize(System.ComponentModel.Design.Serialization.SerializationStore store, System.ComponentModel.IContainer container) { throw null; }
        public override void DeserializeTo(System.ComponentModel.Design.Serialization.SerializationStore store, System.ComponentModel.IContainer container, bool validateRecycledTypes, bool applyDefaults) { }
        public override System.ComponentModel.Design.Serialization.SerializationStore LoadStore(System.IO.Stream stream) { throw null; }
        public override void Serialize(System.ComponentModel.Design.Serialization.SerializationStore store, object value) { }
        public override void SerializeAbsolute(System.ComponentModel.Design.Serialization.SerializationStore store, object value) { }
        public override void SerializeMember(System.ComponentModel.Design.Serialization.SerializationStore store, object owningObject, System.ComponentModel.MemberDescriptor member) { }
        public override void SerializeMemberAbsolute(System.ComponentModel.Design.Serialization.SerializationStore store, object owningObject, System.ComponentModel.MemberDescriptor member) { }
    }
    [System.Security.SecurityCriticalAttribute]
    [System.Security.Permissions.PermissionSetAttribute(System.Security.Permissions.SecurityAction.InheritanceDemand, Name="FullTrust")]
    public abstract partial class CodeDomDesignerLoader : System.ComponentModel.Design.Serialization.BasicDesignerLoader, System.ComponentModel.Design.Serialization.IDesignerSerializationService, System.ComponentModel.Design.Serialization.INameCreationService
    {
        protected CodeDomDesignerLoader() { }
        protected abstract System.CodeDom.Compiler.CodeDomProvider CodeDomProvider { get; }
        protected abstract System.ComponentModel.Design.ITypeResolutionService TypeResolutionService { get; }
        public override void Dispose() { }
        protected override void Initialize() { }
        protected override bool IsReloadNeeded() { throw null; }
        protected override void OnBeginLoad() { }
        protected override void OnBeginUnload() { }
        protected virtual void OnComponentRename(object component, string oldName, string newName) { }
        protected override void OnEndLoad(bool successful, System.Collections.ICollection errors) { }
        protected abstract System.CodeDom.CodeCompileUnit Parse();
        protected override void PerformFlush(System.ComponentModel.Design.Serialization.IDesignerSerializationManager manager) { }
        protected override void PerformLoad(System.ComponentModel.Design.Serialization.IDesignerSerializationManager manager) { }
        System.Collections.ICollection System.ComponentModel.Design.Serialization.IDesignerSerializationService.Deserialize(object serializationData) { throw null; }
        object System.ComponentModel.Design.Serialization.IDesignerSerializationService.Serialize(System.Collections.ICollection objects) { throw null; }
        string System.ComponentModel.Design.Serialization.INameCreationService.CreateName(System.ComponentModel.IContainer container, System.Type dataType) { throw null; }
        bool System.ComponentModel.Design.Serialization.INameCreationService.IsValidName(string name) { throw null; }
        void System.ComponentModel.Design.Serialization.INameCreationService.ValidateName(string name) { }
        protected abstract void Write(System.CodeDom.CodeCompileUnit unit);
    }
    public enum CodeDomLocalizationModel
    {
        None = 0,
        PropertyAssignment = 1,
        PropertyReflection = 2,
    }
    public sealed partial class CodeDomLocalizationProvider : System.ComponentModel.Design.Serialization.IDesignerSerializationProvider, System.IDisposable
    {
        public CodeDomLocalizationProvider(System.IServiceProvider provider, System.ComponentModel.Design.Serialization.CodeDomLocalizationModel model) { }
        public CodeDomLocalizationProvider(System.IServiceProvider provider, System.ComponentModel.Design.Serialization.CodeDomLocalizationModel model, System.Globalization.CultureInfo[] supportedCultures) { }
        public void Dispose() { }
        object System.ComponentModel.Design.Serialization.IDesignerSerializationProvider.GetSerializer(System.ComponentModel.Design.Serialization.IDesignerSerializationManager manager, object currentSerializer, System.Type objectType, System.Type serializerType) { throw null; }
    }
    public partial class CodeDomSerializer : System.ComponentModel.Design.Serialization.CodeDomSerializerBase
    {
        public CodeDomSerializer() { }
        public virtual object Deserialize(System.ComponentModel.Design.Serialization.IDesignerSerializationManager manager, object codeObject) { throw null; }
        protected object DeserializeStatementToInstance(System.ComponentModel.Design.Serialization.IDesignerSerializationManager manager, System.CodeDom.CodeStatement statement) { throw null; }
        public virtual string GetTargetComponentName(System.CodeDom.CodeStatement statement, System.CodeDom.CodeExpression expression, System.Type targetType) { throw null; }
        public virtual object Serialize(System.ComponentModel.Design.Serialization.IDesignerSerializationManager manager, object value) { throw null; }
        public virtual object SerializeAbsolute(System.ComponentModel.Design.Serialization.IDesignerSerializationManager manager, object value) { throw null; }
        public virtual System.CodeDom.CodeStatementCollection SerializeMember(System.ComponentModel.Design.Serialization.IDesignerSerializationManager manager, object owningObject, System.ComponentModel.MemberDescriptor member) { throw null; }
        public virtual System.CodeDom.CodeStatementCollection SerializeMemberAbsolute(System.ComponentModel.Design.Serialization.IDesignerSerializationManager manager, object owningObject, System.ComponentModel.MemberDescriptor member) { throw null; }
        [System.ObsoleteAttribute("This method has been deprecated. Use SerializeToExpression or GetExpression instead.  http://go.microsoft.com/fwlink/?linkid=14202")]
        protected System.CodeDom.CodeExpression SerializeToReferenceExpression(System.ComponentModel.Design.Serialization.IDesignerSerializationManager manager, object value) { throw null; }
    }
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
    public abstract partial class CodeDomSerializerBase
    {
        internal CodeDomSerializerBase() { }
        protected object DeserializeExpression(System.ComponentModel.Design.Serialization.IDesignerSerializationManager manager, string name, System.CodeDom.CodeExpression expression) { throw null; }
        protected virtual object DeserializeInstance(System.ComponentModel.Design.Serialization.IDesignerSerializationManager manager, System.Type type, object[] parameters, string name, bool addToContainer) { throw null; }
        protected void DeserializePropertiesFromResources(System.ComponentModel.Design.Serialization.IDesignerSerializationManager manager, object value, System.Attribute[] filter) { }
        protected void DeserializeStatement(System.ComponentModel.Design.Serialization.IDesignerSerializationManager manager, System.CodeDom.CodeStatement statement) { }
        protected static System.ComponentModel.AttributeCollection GetAttributesFromTypeHelper(System.ComponentModel.Design.Serialization.IDesignerSerializationManager manager, System.Type type) { throw null; }
        protected static System.ComponentModel.AttributeCollection GetAttributesHelper(System.ComponentModel.Design.Serialization.IDesignerSerializationManager manager, object instance) { throw null; }
        protected static System.ComponentModel.EventDescriptorCollection GetEventsHelper(System.ComponentModel.Design.Serialization.IDesignerSerializationManager manager, object instance, System.Attribute[] attributes) { throw null; }
        protected System.CodeDom.CodeExpression GetExpression(System.ComponentModel.Design.Serialization.IDesignerSerializationManager manager, object value) { throw null; }
        protected static System.ComponentModel.PropertyDescriptorCollection GetPropertiesHelper(System.ComponentModel.Design.Serialization.IDesignerSerializationManager manager, object instance, System.Attribute[] attributes) { throw null; }
        protected static System.Type GetReflectionTypeFromTypeHelper(System.ComponentModel.Design.Serialization.IDesignerSerializationManager manager, System.Type type) { throw null; }
        protected static System.Type GetReflectionTypeHelper(System.ComponentModel.Design.Serialization.IDesignerSerializationManager manager, object instance) { throw null; }
        protected System.ComponentModel.Design.Serialization.CodeDomSerializer GetSerializer(System.ComponentModel.Design.Serialization.IDesignerSerializationManager manager, object value) { throw null; }
        protected System.ComponentModel.Design.Serialization.CodeDomSerializer GetSerializer(System.ComponentModel.Design.Serialization.IDesignerSerializationManager manager, System.Type valueType) { throw null; }
        protected static System.ComponentModel.TypeDescriptionProvider GetTargetFrameworkProvider(System.IServiceProvider provider, object instance) { throw null; }
        protected string GetUniqueName(System.ComponentModel.Design.Serialization.IDesignerSerializationManager manager, object value) { throw null; }
        protected bool IsSerialized(System.ComponentModel.Design.Serialization.IDesignerSerializationManager manager, object value) { throw null; }
        protected bool IsSerialized(System.ComponentModel.Design.Serialization.IDesignerSerializationManager manager, object value, bool honorPreset) { throw null; }
        protected System.CodeDom.CodeExpression SerializeCreationExpression(System.ComponentModel.Design.Serialization.IDesignerSerializationManager manager, object value, out bool isComplete) { throw null; }
        protected void SerializeEvent(System.ComponentModel.Design.Serialization.IDesignerSerializationManager manager, System.CodeDom.CodeStatementCollection statements, object value, System.ComponentModel.EventDescriptor descriptor) { }
        protected void SerializeEvents(System.ComponentModel.Design.Serialization.IDesignerSerializationManager manager, System.CodeDom.CodeStatementCollection statements, object value, params System.Attribute[] filter) { }
        protected void SerializeProperties(System.ComponentModel.Design.Serialization.IDesignerSerializationManager manager, System.CodeDom.CodeStatementCollection statements, object value, System.Attribute[] filter) { }
        protected void SerializePropertiesToResources(System.ComponentModel.Design.Serialization.IDesignerSerializationManager manager, System.CodeDom.CodeStatementCollection statements, object value, System.Attribute[] filter) { }
        protected void SerializeProperty(System.ComponentModel.Design.Serialization.IDesignerSerializationManager manager, System.CodeDom.CodeStatementCollection statements, object value, System.ComponentModel.PropertyDescriptor propertyToSerialize) { }
        protected void SerializeResource(System.ComponentModel.Design.Serialization.IDesignerSerializationManager manager, string resourceName, object value) { }
        protected void SerializeResourceInvariant(System.ComponentModel.Design.Serialization.IDesignerSerializationManager manager, string resourceName, object value) { }
        protected System.CodeDom.CodeExpression SerializeToExpression(System.ComponentModel.Design.Serialization.IDesignerSerializationManager manager, object value) { throw null; }
        protected System.CodeDom.CodeExpression SerializeToResourceExpression(System.ComponentModel.Design.Serialization.IDesignerSerializationManager manager, object value) { throw null; }
        protected System.CodeDom.CodeExpression SerializeToResourceExpression(System.ComponentModel.Design.Serialization.IDesignerSerializationManager manager, object value, bool ensureInvariant) { throw null; }
        protected void SetExpression(System.ComponentModel.Design.Serialization.IDesignerSerializationManager manager, object value, System.CodeDom.CodeExpression expression) { }
        protected void SetExpression(System.ComponentModel.Design.Serialization.IDesignerSerializationManager manager, object value, System.CodeDom.CodeExpression expression, bool isPreset) { }
    }
    [System.SerializableAttribute]
    public partial class CodeDomSerializerException : System.SystemException
    {
        public CodeDomSerializerException(System.Exception ex, System.CodeDom.CodeLinePragma linePragma) { }
        public CodeDomSerializerException(System.Exception ex, System.ComponentModel.Design.Serialization.IDesignerSerializationManager manager) { }
        protected CodeDomSerializerException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
        public CodeDomSerializerException(string message, System.CodeDom.CodeLinePragma linePragma) { }
        public CodeDomSerializerException(string message, System.ComponentModel.Design.Serialization.IDesignerSerializationManager manager) { }
        public System.CodeDom.CodeLinePragma LinePragma { get { throw null; } }
        public override void GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
    }
    public partial class CollectionCodeDomSerializer : System.ComponentModel.Design.Serialization.CodeDomSerializer
    {
        public CollectionCodeDomSerializer() { }
        protected bool MethodSupportsSerialization(System.Reflection.MethodInfo method) { throw null; }
        public override object Serialize(System.ComponentModel.Design.Serialization.IDesignerSerializationManager manager, object value) { throw null; }
        protected virtual object SerializeCollection(System.ComponentModel.Design.Serialization.IDesignerSerializationManager manager, System.CodeDom.CodeExpression targetExpression, System.Type targetType, System.Collections.ICollection originalCollection, System.Collections.ICollection valuesToSerialize) { throw null; }
    }
    public partial class DesignerSerializationManager : System.ComponentModel.Design.Serialization.IDesignerSerializationManager, System.IServiceProvider
    {
        public DesignerSerializationManager() { }
        public DesignerSerializationManager(System.IServiceProvider provider) { }
        public System.ComponentModel.IContainer Container { get { throw null; } set { } }
        public System.Collections.IList Errors { get { throw null; } }
        public bool PreserveNames { get { throw null; } set { } }
        public object PropertyProvider { get { throw null; } set { } }
        public bool RecycleInstances { get { throw null; } set { } }
        System.ComponentModel.Design.Serialization.ContextStack System.ComponentModel.Design.Serialization.IDesignerSerializationManager.Context { get { throw null; } }
        System.ComponentModel.PropertyDescriptorCollection System.ComponentModel.Design.Serialization.IDesignerSerializationManager.Properties { get { throw null; } }
        public bool ValidateRecycledTypes { get { throw null; } set { } }
        public event System.EventHandler SessionCreated { add { } remove { } }
        public event System.EventHandler SessionDisposed { add { } remove { } }
        event System.ComponentModel.Design.Serialization.ResolveNameEventHandler System.ComponentModel.Design.Serialization.IDesignerSerializationManager.ResolveName { add { } remove { } }
        event System.EventHandler System.ComponentModel.Design.Serialization.IDesignerSerializationManager.SerializationComplete { add { } remove { } }
        protected virtual object CreateInstance(System.Type type, System.Collections.ICollection arguments, string name, bool addToContainer) { throw null; }
        public System.IDisposable CreateSession() { throw null; }
        public System.Type GetRuntimeType(string typeName) { throw null; }
        public object GetSerializer(System.Type objectType, System.Type serializerType) { throw null; }
        protected virtual object GetService(System.Type serviceType) { throw null; }
        protected virtual System.Type GetType(string typeName) { throw null; }
        protected virtual void OnResolveName(System.ComponentModel.Design.Serialization.ResolveNameEventArgs e) { }
        protected virtual void OnSessionCreated(System.EventArgs e) { }
        protected virtual void OnSessionDisposed(System.EventArgs e) { }
        void System.ComponentModel.Design.Serialization.IDesignerSerializationManager.AddSerializationProvider(System.ComponentModel.Design.Serialization.IDesignerSerializationProvider provider) { }
        object System.ComponentModel.Design.Serialization.IDesignerSerializationManager.CreateInstance(System.Type type, System.Collections.ICollection arguments, string name, bool addToContainer) { throw null; }
        object System.ComponentModel.Design.Serialization.IDesignerSerializationManager.GetInstance(string name) { throw null; }
        string System.ComponentModel.Design.Serialization.IDesignerSerializationManager.GetName(object value) { throw null; }
        object System.ComponentModel.Design.Serialization.IDesignerSerializationManager.GetSerializer(System.Type objectType, System.Type serializerType) { throw null; }
        System.Type System.ComponentModel.Design.Serialization.IDesignerSerializationManager.GetType(string typeName) { throw null; }
        void System.ComponentModel.Design.Serialization.IDesignerSerializationManager.RemoveSerializationProvider(System.ComponentModel.Design.Serialization.IDesignerSerializationProvider provider) { }
        void System.ComponentModel.Design.Serialization.IDesignerSerializationManager.ReportError(object errorInformation) { }
        void System.ComponentModel.Design.Serialization.IDesignerSerializationManager.SetName(object instance, string name) { }
        object System.IServiceProvider.GetService(System.Type serviceType) { throw null; }
    }
    public sealed partial class ExpressionContext
    {
        public ExpressionContext(System.CodeDom.CodeExpression expression, System.Type expressionType, object owner) { }
        public ExpressionContext(System.CodeDom.CodeExpression expression, System.Type expressionType, object owner, object presetValue) { }
        public System.CodeDom.CodeExpression Expression { get { throw null; } }
        public System.Type ExpressionType { get { throw null; } }
        public object Owner { get { throw null; } }
        public object PresetValue { get { throw null; } }
    }
    public partial interface ICodeDomDesignerReload
    {
        bool ShouldReloadDesigner(System.CodeDom.CodeCompileUnit newTree);
    }
    public abstract partial class MemberCodeDomSerializer : System.ComponentModel.Design.Serialization.CodeDomSerializerBase
    {
        protected MemberCodeDomSerializer() { }
        public abstract void Serialize(System.ComponentModel.Design.Serialization.IDesignerSerializationManager manager, object value, System.ComponentModel.MemberDescriptor descriptor, System.CodeDom.CodeStatementCollection statements);
        public abstract bool ShouldSerialize(System.ComponentModel.Design.Serialization.IDesignerSerializationManager manager, object value, System.ComponentModel.MemberDescriptor descriptor);
    }
    public sealed partial class ObjectStatementCollection : System.Collections.IEnumerable
    {
        internal ObjectStatementCollection() { }
        public System.CodeDom.CodeStatementCollection this[object statementOwner] { get { throw null; } }
        public bool ContainsKey(object statementOwner) { throw null; }
        public System.Collections.IDictionaryEnumerator GetEnumerator() { throw null; }
        public void Populate(System.Collections.ICollection statementOwners) { }
        public void Populate(object owner) { }
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { throw null; }
    }
    public sealed partial class RootContext
    {
        public RootContext(System.CodeDom.CodeExpression expression, object value) { }
        public System.CodeDom.CodeExpression Expression { get { throw null; } }
        public object Value { get { throw null; } }
    }
    public sealed partial class SerializeAbsoluteContext
    {
        public SerializeAbsoluteContext() { }
        public SerializeAbsoluteContext(System.ComponentModel.MemberDescriptor member) { }
        public System.ComponentModel.MemberDescriptor Member { get { throw null; } }
        public bool ShouldSerialize(System.ComponentModel.MemberDescriptor member) { throw null; }
    }
    public sealed partial class StatementContext
    {
        public StatementContext() { }
        public System.ComponentModel.Design.Serialization.ObjectStatementCollection StatementCollection { get { throw null; } }
    }
    public partial class TypeCodeDomSerializer : System.ComponentModel.Design.Serialization.CodeDomSerializerBase
    {
        public TypeCodeDomSerializer() { }
        public virtual object Deserialize(System.ComponentModel.Design.Serialization.IDesignerSerializationManager manager, System.CodeDom.CodeTypeDeclaration declaration) { throw null; }
        protected virtual System.CodeDom.CodeMemberMethod GetInitializeMethod(System.ComponentModel.Design.Serialization.IDesignerSerializationManager manager, System.CodeDom.CodeTypeDeclaration declaration, object value) { throw null; }
        protected virtual System.CodeDom.CodeMemberMethod[] GetInitializeMethods(System.ComponentModel.Design.Serialization.IDesignerSerializationManager manager, System.CodeDom.CodeTypeDeclaration declaration) { throw null; }
        public virtual System.CodeDom.CodeTypeDeclaration Serialize(System.ComponentModel.Design.Serialization.IDesignerSerializationManager manager, object root, System.Collections.ICollection members) { throw null; }
    }
}
namespace System.Data.Design
{
    public partial class MethodSignatureGenerator
    {
        public MethodSignatureGenerator() { }
        public System.CodeDom.Compiler.CodeDomProvider CodeProvider { get { throw null; } set { } }
        public System.Type ContainerParameterType { get { throw null; } set { } }
        public string DataSetClassName { get { throw null; } set { } }
        public bool IsGetMethod { get { throw null; } set { } }
        public bool PagingMethod { get { throw null; } set { } }
        public System.Data.Design.ParameterGenerationOption ParameterOption { get { throw null; } set { } }
        public string TableClassName { get { throw null; } set { } }
        public System.CodeDom.CodeMemberMethod GenerateMethod() { throw null; }
        public string GenerateMethodSignature() { throw null; }
        public System.CodeDom.CodeTypeDeclaration GenerateUpdatingMethods() { throw null; }
        public void SetDesignTableContent(string designTableContent) { }
        public void SetMethodSourceContent(string methodSourceContent) { }
    }
    public enum ParameterGenerationOption
    {
        ClrTypes = 0,
        Objects = 2,
        SqlTypes = 1,
    }
    public sealed partial class TypedDataSetGenerator
    {
        internal TypedDataSetGenerator() { }
        public static System.Collections.Generic.ICollection<System.Reflection.Assembly> ReferencedAssemblies { get { throw null; } }
        public static string Generate(System.Data.DataSet dataSet, System.CodeDom.CodeNamespace codeNamespace, System.CodeDom.Compiler.CodeDomProvider codeProvider) { throw null; }
        public static string Generate(string inputFileContent, System.CodeDom.CodeCompileUnit compileUnit, System.CodeDom.CodeNamespace mainNamespace, System.CodeDom.Compiler.CodeDomProvider codeProvider) { throw null; }
        public static void Generate(string inputFileContent, System.CodeDom.CodeCompileUnit compileUnit, System.CodeDom.CodeNamespace mainNamespace, System.CodeDom.Compiler.CodeDomProvider codeProvider, System.Collections.Hashtable customDBProviders) { }
        public static void Generate(string inputFileContent, System.CodeDom.CodeCompileUnit compileUnit, System.CodeDom.CodeNamespace mainNamespace, System.CodeDom.Compiler.CodeDomProvider codeProvider, System.Collections.Hashtable customDBProviders, System.Data.Design.TypedDataSetGenerator.GenerateOption option) { }
        public static void Generate(string inputFileContent, System.CodeDom.CodeCompileUnit compileUnit, System.CodeDom.CodeNamespace mainNamespace, System.CodeDom.Compiler.CodeDomProvider codeProvider, System.Collections.Hashtable customDBProviders, System.Data.Design.TypedDataSetGenerator.GenerateOption option, string dataSetNamespace) { }
        public static void Generate(string inputFileContent, System.CodeDom.CodeCompileUnit compileUnit, System.CodeDom.CodeNamespace mainNamespace, System.CodeDom.Compiler.CodeDomProvider codeProvider, System.Collections.Hashtable customDBProviders, System.Data.Design.TypedDataSetGenerator.GenerateOption option, string dataSetNamespace, string basePath) { }
        public static void Generate(string inputFileContent, System.CodeDom.CodeCompileUnit compileUnit, System.CodeDom.CodeNamespace mainNamespace, System.CodeDom.Compiler.CodeDomProvider codeProvider, System.Data.Common.DbProviderFactory specifiedFactory) { }
        public static string Generate(string inputFileContent, System.CodeDom.CodeCompileUnit compileUnit, System.CodeDom.CodeNamespace mainNamespace, System.CodeDom.Compiler.CodeDomProvider codeProvider, System.Data.Design.TypedDataSetGenerator.GenerateOption option) { throw null; }
        public static string Generate(string inputFileContent, System.CodeDom.CodeCompileUnit compileUnit, System.CodeDom.CodeNamespace mainNamespace, System.CodeDom.Compiler.CodeDomProvider codeProvider, System.Data.Design.TypedDataSetGenerator.GenerateOption option, string dataSetNamespace) { throw null; }
        public static string Generate(string inputFileContent, System.CodeDom.CodeCompileUnit compileUnit, System.CodeDom.CodeNamespace mainNamespace, System.CodeDom.Compiler.CodeDomProvider codeProvider, System.Data.Design.TypedDataSetGenerator.GenerateOption option, string dataSetNamespace, string basePath) { throw null; }
        public static string GetProviderName(string inputFileContent) { throw null; }
        public static string GetProviderName(string inputFileContent, string tableName) { throw null; }
        [System.FlagsAttribute]
        public enum GenerateOption
        {
            HierarchicalUpdate = 1,
            LinqOverTypedDatasets = 2,
            None = 0,
        }
    }
    [System.SerializableAttribute]
    public partial class TypedDataSetGeneratorException : System.Data.DataException
    {
        public TypedDataSetGeneratorException() { }
        public TypedDataSetGeneratorException(System.Collections.IList list) { }
        protected TypedDataSetGeneratorException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
        public TypedDataSetGeneratorException(string message) { }
        public TypedDataSetGeneratorException(string message, System.Exception innerException) { }
        public System.Collections.IList ErrorList { get { throw null; } }
        [System.Security.Permissions.SecurityPermissionAttribute(System.Security.Permissions.SecurityAction.Demand, SerializationFormatter=true)]
        public override void GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
    }
    public partial class TypedDataSetSchemaImporterExtension : System.Xml.Serialization.Advanced.SchemaImporterExtension
    {
        public TypedDataSetSchemaImporterExtension() { }
        protected TypedDataSetSchemaImporterExtension(System.Data.Design.TypedDataSetGenerator.GenerateOption dataSetGenerateOptions) { }
        public override string ImportSchemaType(string name, string namespaceName, System.Xml.Schema.XmlSchemaObject context, System.Xml.Serialization.XmlSchemas schemas, System.Xml.Serialization.XmlSchemaImporter importer, System.CodeDom.CodeCompileUnit compileUnit, System.CodeDom.CodeNamespace mainNamespace, System.Xml.Serialization.CodeGenerationOptions options, System.CodeDom.Compiler.CodeDomProvider codeProvider) { throw null; }
        public override string ImportSchemaType(System.Xml.Schema.XmlSchemaType type, System.Xml.Schema.XmlSchemaObject context, System.Xml.Serialization.XmlSchemas schemas, System.Xml.Serialization.XmlSchemaImporter importer, System.CodeDom.CodeCompileUnit compileUnit, System.CodeDom.CodeNamespace mainNamespace, System.Xml.Serialization.CodeGenerationOptions options, System.CodeDom.Compiler.CodeDomProvider codeProvider) { throw null; }
    }
    public partial class TypedDataSetSchemaImporterExtensionFx35 : System.Data.Design.TypedDataSetSchemaImporterExtension
    {
        public TypedDataSetSchemaImporterExtensionFx35() { }
    }
}
namespace System.Diagnostics.Design
{
    [System.Security.Permissions.SecurityPermissionAttribute(System.Security.Permissions.SecurityAction.Demand, Flags=System.Security.Permissions.SecurityPermissionFlag.UnmanagedCode)]
    public partial class LogConverter : System.ComponentModel.TypeConverter
    {
        public LogConverter() { }
        public override bool CanConvertFrom(System.ComponentModel.ITypeDescriptorContext context, System.Type sourceType) { throw null; }
        public override object ConvertFrom(System.ComponentModel.ITypeDescriptorContext context, System.Globalization.CultureInfo culture, object value) { throw null; }
        public override System.ComponentModel.TypeConverter.StandardValuesCollection GetStandardValues(System.ComponentModel.ITypeDescriptorContext context) { throw null; }
        public override bool GetStandardValuesSupported(System.ComponentModel.ITypeDescriptorContext context) { throw null; }
    }
    [System.Security.Permissions.SecurityPermissionAttribute(System.Security.Permissions.SecurityAction.Demand, Flags=System.Security.Permissions.SecurityPermissionFlag.UnmanagedCode)]
    public partial class ProcessDesigner : System.ComponentModel.Design.ComponentDesigner
    {
        public ProcessDesigner() { }
        protected override void PreFilterProperties(System.Collections.IDictionary properties) { }
    }
    [System.Security.Permissions.SecurityPermissionAttribute(System.Security.Permissions.SecurityAction.Demand, Flags=System.Security.Permissions.SecurityPermissionFlag.UnmanagedCode)]
    public partial class ProcessModuleDesigner : System.ComponentModel.Design.ComponentDesigner
    {
        public ProcessModuleDesigner() { }
        protected override void PreFilterProperties(System.Collections.IDictionary properties) { }
    }
    [System.Security.Permissions.SecurityPermissionAttribute(System.Security.Permissions.SecurityAction.Demand, Flags=System.Security.Permissions.SecurityPermissionFlag.UnmanagedCode)]
    public partial class ProcessThreadDesigner : System.ComponentModel.Design.ComponentDesigner
    {
        public ProcessThreadDesigner() { }
        protected override void PreFilterProperties(System.Collections.IDictionary properties) { }
    }
}
namespace System.Messaging.Design
{
    [System.Security.Permissions.SecurityPermissionAttribute(System.Security.Permissions.SecurityAction.Demand, Flags=System.Security.Permissions.SecurityPermissionFlag.UnmanagedCode)]
    public partial class MessageDesigner : System.ComponentModel.Design.ComponentDesigner
    {
        public MessageDesigner() { }
        protected override void PreFilterProperties(System.Collections.IDictionary properties) { }
    }
}
namespace System.Resources.Tools
{
    public partial interface ITargetAwareCodeDomProvider
    {
        bool SupportsProperty(System.Type type, string propertyName, bool isWritable);
    }
    public static partial class StronglyTypedResourceBuilder
    {
        public static System.CodeDom.CodeCompileUnit Create(System.Collections.IDictionary resourceList, string baseName, string generatedCodeNamespace, System.CodeDom.Compiler.CodeDomProvider codeProvider, bool internalClass, out string[] unmatchable) { throw null; }
        public static System.CodeDom.CodeCompileUnit Create(System.Collections.IDictionary resourceList, string baseName, string generatedCodeNamespace, string resourcesNamespace, System.CodeDom.Compiler.CodeDomProvider codeProvider, bool internalClass, out string[] unmatchable) { throw null; }
        public static System.CodeDom.CodeCompileUnit Create(string resxFile, string baseName, string generatedCodeNamespace, System.CodeDom.Compiler.CodeDomProvider codeProvider, bool internalClass, out string[] unmatchable) { throw null; }
        public static System.CodeDom.CodeCompileUnit Create(string resxFile, string baseName, string generatedCodeNamespace, string resourcesNamespace, System.CodeDom.Compiler.CodeDomProvider codeProvider, bool internalClass, out string[] unmatchable) { throw null; }
        public static string VerifyResourceName(string key, System.CodeDom.Compiler.CodeDomProvider provider) { throw null; }
    }
}
namespace System.ServiceProcess.Design
{
    [System.Security.Permissions.SecurityPermissionAttribute(System.Security.Permissions.SecurityAction.Demand, Flags=System.Security.Permissions.SecurityPermissionFlag.UnmanagedCode)]
    public partial class ServiceControllerDesigner : System.ComponentModel.Design.ComponentDesigner
    {
        public ServiceControllerDesigner() { }
        protected override void PreFilterProperties(System.Collections.IDictionary properties) { }
    }
}
namespace System.Web.UI.Design
{
    public partial class AppSettingsExpressionEditor : System.Web.UI.Design.ExpressionEditor
    {
        public AppSettingsExpressionEditor() { }
        public override object EvaluateExpression(string expression, object parseTimeData, System.Type propertyType, System.IServiceProvider serviceProvider) { throw null; }
        public override System.Web.UI.Design.ExpressionEditorSheet GetExpressionEditorSheet(string expression, System.IServiceProvider serviceProvider) { throw null; }
    }
    [System.Security.Permissions.SecurityPermissionAttribute(System.Security.Permissions.SecurityAction.Demand, Flags=System.Security.Permissions.SecurityPermissionFlag.UnmanagedCode)]
    public partial class CalendarDataBindingHandler : System.Web.UI.Design.DataBindingHandler
    {
        public CalendarDataBindingHandler() { }
        public override void DataBindControl(System.ComponentModel.Design.IDesignerHost designerHost, System.Web.UI.Control control) { }
    }
    public sealed partial class ClientScriptItem
    {
        public ClientScriptItem(string text, string source, string language, string type, string id) { }
        public string Id { get { throw null; } }
        public string Language { get { throw null; } }
        public string Source { get { throw null; } }
        public string Text { get { throw null; } }
        public string Type { get { throw null; } }
    }
    public sealed partial class ClientScriptItemCollection : System.Collections.ReadOnlyCollectionBase
    {
        public ClientScriptItemCollection(System.Web.UI.Design.ClientScriptItem[] clientScriptItems) { }
    }
    [System.Security.Permissions.SecurityPermissionAttribute(System.Security.Permissions.SecurityAction.Demand, Flags=System.Security.Permissions.SecurityPermissionFlag.UnmanagedCode)]
    public sealed partial class ColorBuilder
    {
        internal ColorBuilder() { }
        public static string BuildColor(System.ComponentModel.IComponent component, System.Windows.Forms.Control owner, string initialColor) { throw null; }
    }
    [System.Security.Permissions.SecurityPermissionAttribute(System.Security.Permissions.SecurityAction.Demand, Flags=System.Security.Permissions.SecurityPermissionFlag.UnmanagedCode)]
    public partial class ConnectionStringEditor : System.Drawing.Design.UITypeEditor
    {
        public ConnectionStringEditor() { }
        public override object EditValue(System.ComponentModel.ITypeDescriptorContext context, System.IServiceProvider provider, object value) { throw null; }
        public override System.Drawing.Design.UITypeEditorEditStyle GetEditStyle(System.ComponentModel.ITypeDescriptorContext context) { throw null; }
        protected virtual string GetProviderName(object instance) { throw null; }
        protected virtual void SetProviderName(object instance, System.ComponentModel.Design.Data.DesignerDataConnection connection) { }
    }
    public partial class ConnectionStringsExpressionEditor : System.Web.UI.Design.ExpressionEditor
    {
        public ConnectionStringsExpressionEditor() { }
        public override object EvaluateExpression(string expression, object parseTimeData, System.Type propertyType, System.IServiceProvider serviceProvider) { throw null; }
        public override System.Web.UI.Design.ExpressionEditorSheet GetExpressionEditorSheet(string expression, System.IServiceProvider serviceProvider) { throw null; }
    }
    [System.Security.Permissions.SecurityPermissionAttribute(System.Security.Permissions.SecurityAction.Demand, Flags=System.Security.Permissions.SecurityPermissionFlag.UnmanagedCode)]
    public partial class ContainerControlDesigner : System.Web.UI.Design.ControlDesigner
    {
        public ContainerControlDesigner() { }
        public override bool AllowResize { get { throw null; } }
        public virtual string FrameCaption { get { throw null; } }
        public virtual System.Web.UI.WebControls.Style FrameStyle { get { throw null; } }
        protected virtual bool NoWrap { get { throw null; } }
        protected virtual void AddDesignTimeCssAttributes(System.Collections.IDictionary styleAttributes) { }
        public virtual System.Collections.IDictionary GetDesignTimeCssAttributes() { throw null; }
        public override string GetDesignTimeHtml(System.Web.UI.Design.DesignerRegionCollection regions) { throw null; }
        public override string GetEditableDesignerRegionContent(System.Web.UI.Design.EditableDesignerRegion region) { throw null; }
        public override string GetPersistenceContent() { throw null; }
        public override void SetEditableDesignerRegionContent(System.Web.UI.Design.EditableDesignerRegion region, string content) { }
    }
    public partial class ContentDefinition
    {
        public ContentDefinition(string id, string content, string designTimeHtml) { }
        public string ContentPlaceHolderID { get { throw null; } }
        public string DefaultContent { get { throw null; } }
        public string DefaultDesignTimeHtml { get { throw null; } }
    }
    public enum ContentDesignerState
    {
        ShowDefaultContent = 0,
        ShowUserContent = 1,
    }
    [System.Security.Permissions.SecurityPermissionAttribute(System.Security.Permissions.SecurityAction.Demand, Flags=System.Security.Permissions.SecurityPermissionFlag.UnmanagedCode)]
    public partial class ControlDesigner : System.Web.UI.Design.HtmlControlDesigner
    {
        public ControlDesigner() { }
        public override System.ComponentModel.Design.DesignerActionListCollection ActionLists { get { throw null; } }
        public virtual bool AllowResize { get { throw null; } }
        public virtual System.Web.UI.Design.DesignerAutoFormatCollection AutoFormats { get { throw null; } }
        protected virtual bool DataBindingsEnabled { get { throw null; } }
        protected System.Web.UI.Design.ControlDesignerState DesignerState { get { throw null; } }
        [System.ObsoleteAttribute("Error: This property can no longer be referenced, and is included to support existing compiled applications. The design-time element view architecture is no longer used. http://go.microsoft.com/fwlink/?linkid=14202", true)]
        protected object DesignTimeElementView { get { throw null; } }
        [System.ObsoleteAttribute("The recommended alternative is SetViewFlags(ViewFlags.DesignTimeHtmlRequiresLoadComplete, true). http://go.microsoft.com/fwlink/?linkid=14202")]
        public virtual bool DesignTimeHtmlRequiresLoadComplete { get { throw null; } }
        protected internal virtual bool HidePropertiesInTemplateMode { get { throw null; } }
        public virtual string ID { get { throw null; } set { } }
        protected bool InTemplateMode { get { throw null; } }
        [System.ObsoleteAttribute("The recommended alternative is to use Tag.SetDirty() and Tag.IsDirty. http://go.microsoft.com/fwlink/?linkid=14202")]
        public bool IsDirty { get { throw null; } set { } }
        [System.ObsoleteAttribute("The recommended alternative is to inherit from ContainerControlDesigner instead and to use an EditableDesignerRegion. Regions allow for better control of the content in the designer. http://go.microsoft.com/fwlink/?linkid=14202")]
        public bool ReadOnly { get { throw null; } set { } }
        protected System.Web.UI.Design.WebFormsRootDesigner RootDesigner { get { throw null; } }
        protected System.Web.UI.Design.IControlDesignerTag Tag { get { throw null; } }
        public virtual System.Web.UI.Design.TemplateGroupCollection TemplateGroups { get { throw null; } }
        protected virtual bool UsePreviewControl { get { throw null; } }
        public System.Web.UI.Control ViewControl { get { throw null; } set { } }
        public virtual bool ViewControlCreated { get { throw null; } set { } }
        protected virtual bool Visible { get { throw null; } }
        protected string CreateErrorDesignTimeHtml(string errorMessage) { throw null; }
        protected string CreateErrorDesignTimeHtml(string errorMessage, System.Exception e) { throw null; }
        protected string CreatePlaceHolderDesignTimeHtml() { throw null; }
        protected string CreatePlaceHolderDesignTimeHtml(string instruction) { throw null; }
        protected virtual System.Web.UI.Control CreateViewControl() { throw null; }
        public System.Drawing.Rectangle GetBounds() { throw null; }
        public virtual string GetDesignTimeHtml() { throw null; }
        public virtual string GetDesignTimeHtml(System.Web.UI.Design.DesignerRegionCollection regions) { throw null; }
        public static System.Web.UI.Design.DesignTimeResourceProviderFactory GetDesignTimeResourceProviderFactory(System.IServiceProvider serviceProvider) { throw null; }
        public virtual string GetEditableDesignerRegionContent(System.Web.UI.Design.EditableDesignerRegion region) { throw null; }
        protected virtual string GetEmptyDesignTimeHtml() { throw null; }
        protected virtual string GetErrorDesignTimeHtml(System.Exception e) { throw null; }
        public virtual string GetPersistenceContent() { throw null; }
        [System.ObsoleteAttribute("The recommended alternative is GetPersistenceContent(). http://go.microsoft.com/fwlink/?linkid=14202")]
        public virtual string GetPersistInnerHtml() { throw null; }
        public System.Web.UI.Design.ViewRendering GetViewRendering() { throw null; }
        public static System.Web.UI.Design.ViewRendering GetViewRendering(System.Web.UI.Control control) { throw null; }
        public static System.Web.UI.Design.ViewRendering GetViewRendering(System.Web.UI.Design.ControlDesigner designer) { throw null; }
        public override void Initialize(System.ComponentModel.IComponent component) { }
        public void Invalidate() { }
        public void Invalidate(System.Drawing.Rectangle rectangle) { }
        public static void InvokeTransactedChange(System.ComponentModel.IComponent component, System.Web.UI.Design.TransactedChangeCallback callback, object context, string description) { }
        public static void InvokeTransactedChange(System.ComponentModel.IComponent component, System.Web.UI.Design.TransactedChangeCallback callback, object context, string description, System.ComponentModel.MemberDescriptor member) { }
        public static void InvokeTransactedChange(System.IServiceProvider serviceProvider, System.ComponentModel.IComponent component, System.Web.UI.Design.TransactedChangeCallback callback, object context, string description, System.ComponentModel.MemberDescriptor member) { }
        [System.ObsoleteAttribute("The recommended alternative is DataBindings.Contains(string). The DataBindings collection allows more control of the databindings associated with the control. http://go.microsoft.com/fwlink/?linkid=14202")]
        public bool IsPropertyBound(string propName) { throw null; }
        public void Localize(System.Web.UI.Design.IDesignTimeResourceWriter resourceWriter) { }
        public virtual void OnAutoFormatApplied(System.Web.UI.Design.DesignerAutoFormat appliedAutoFormat) { }
        [System.ObsoleteAttribute("The recommended alternative is to handle the Changed event on the DataBindings collection. The DataBindings collection allows more control of the databindings associated with the control. http://go.microsoft.com/fwlink/?linkid=14202")]
        protected override void OnBindingsCollectionChanged(string propName) { }
        protected virtual void OnClick(System.Web.UI.Design.DesignerRegionMouseEventArgs e) { }
        public virtual void OnComponentChanged(object sender, System.ComponentModel.Design.ComponentChangedEventArgs ce) { }
        public virtual void OnComponentChanging(object sender, System.ComponentModel.Design.ComponentChangingEventArgs ce) { }
        [System.ObsoleteAttribute("The recommended alternative is OnComponentChanged(). OnComponentChanged is called when any property of the control is changed. http://go.microsoft.com/fwlink/?linkid=14202")]
        protected virtual void OnControlResize() { }
        protected virtual void OnPaint(System.Windows.Forms.PaintEventArgs e) { }
        protected override void PreFilterProperties(System.Collections.IDictionary properties) { }
        [System.ObsoleteAttribute("Use of this method is not recommended because resizing is handled by the OnComponentChanged() method. http://go.microsoft.com/fwlink/?linkid=14202")]
        public void RaiseResizeEvent() { }
        public void RegisterClone(object original, object clone) { }
        public virtual void SetEditableDesignerRegionContent(System.Web.UI.Design.EditableDesignerRegion region, string content) { }
        protected void SetRegionContent(System.Web.UI.Design.EditableDesignerRegion region, string content) { }
        protected void SetViewFlags(System.Web.UI.Design.ViewFlags viewFlags, bool setFlag) { }
        public virtual void UpdateDesignTimeHtml() { }
    }
    [System.Security.Permissions.SecurityPermissionAttribute(System.Security.Permissions.SecurityAction.Demand, Flags=System.Security.Permissions.SecurityPermissionFlag.UnmanagedCode)]
    public sealed partial class ControlDesignerState
    {
        internal ControlDesignerState() { }
        public object this[string key] { get { throw null; } set { } }
    }
    public enum ControlLocation
    {
        After = 1,
        Before = 0,
        First = 2,
        FirstChild = 4,
        Last = 3,
        LastChild = 5,
    }
    [System.Security.Permissions.SecurityPermissionAttribute(System.Security.Permissions.SecurityAction.Demand, Flags=System.Security.Permissions.SecurityPermissionFlag.UnmanagedCode)]
    public sealed partial class ControlParser
    {
        internal ControlParser() { }
        public static System.Web.UI.Control ParseControl(System.ComponentModel.Design.IDesignerHost designerHost, string controlText) { throw null; }
        public static System.Web.UI.Control ParseControl(System.ComponentModel.Design.IDesignerHost designerHost, string controlText, string directives) { throw null; }
        public static System.Web.UI.Control[] ParseControls(System.ComponentModel.Design.IDesignerHost designerHost, string controlText) { throw null; }
        public static System.Web.UI.ITemplate ParseTemplate(System.ComponentModel.Design.IDesignerHost designerHost, string templateText) { throw null; }
        public static System.Web.UI.ITemplate ParseTemplate(System.ComponentModel.Design.IDesignerHost designerHost, string templateText, string directives) { throw null; }
    }
    [System.Security.Permissions.SecurityPermissionAttribute(System.Security.Permissions.SecurityAction.Demand, Flags=System.Security.Permissions.SecurityPermissionFlag.UnmanagedCode)]
    public sealed partial class ControlPersister
    {
        internal ControlPersister() { }
        public static void PersistControl(System.IO.TextWriter sw, System.Web.UI.Control control) { }
        public static void PersistControl(System.IO.TextWriter sw, System.Web.UI.Control control, System.ComponentModel.Design.IDesignerHost host) { }
        public static string PersistControl(System.Web.UI.Control control) { throw null; }
        public static string PersistControl(System.Web.UI.Control control, System.ComponentModel.Design.IDesignerHost host) { throw null; }
        public static void PersistInnerProperties(System.IO.TextWriter sw, object component, System.ComponentModel.Design.IDesignerHost host) { }
        public static string PersistInnerProperties(object component, System.ComponentModel.Design.IDesignerHost host) { throw null; }
        public static void PersistTemplate(System.IO.TextWriter writer, System.Web.UI.ITemplate template, System.ComponentModel.Design.IDesignerHost host) { }
        public static string PersistTemplate(System.Web.UI.ITemplate template, System.ComponentModel.Design.IDesignerHost host) { throw null; }
    }
    [System.ObsoleteAttribute("Use of this type is not recommended because DataBindings editing is launched via a DesignerActionList instead of the property grid. http://go.microsoft.com/fwlink/?linkid=14202")]
    [System.Security.Permissions.SecurityPermissionAttribute(System.Security.Permissions.SecurityAction.Demand, Flags=System.Security.Permissions.SecurityPermissionFlag.UnmanagedCode)]
    public partial class DataBindingCollectionConverter : System.ComponentModel.TypeConverter
    {
        public DataBindingCollectionConverter() { }
        public override object ConvertTo(System.ComponentModel.ITypeDescriptorContext context, System.Globalization.CultureInfo culture, object value, System.Type destinationType) { throw null; }
    }
    [System.ObsoleteAttribute("Use of this type is not recommended because DataBindings editing is launched via a DesignerActionList instead of the property grid. http://go.microsoft.com/fwlink/?linkid=14202")]
    [System.Security.Permissions.SecurityPermissionAttribute(System.Security.Permissions.SecurityAction.Demand, Flags=System.Security.Permissions.SecurityPermissionFlag.UnmanagedCode)]
    public partial class DataBindingCollectionEditor : System.Drawing.Design.UITypeEditor
    {
        public DataBindingCollectionEditor() { }
        public override object EditValue(System.ComponentModel.ITypeDescriptorContext context, System.IServiceProvider provider, object value) { throw null; }
        public override System.Drawing.Design.UITypeEditorEditStyle GetEditStyle(System.ComponentModel.ITypeDescriptorContext context) { throw null; }
    }
    [System.Security.Permissions.SecurityPermissionAttribute(System.Security.Permissions.SecurityAction.Demand, Flags=System.Security.Permissions.SecurityPermissionFlag.UnmanagedCode)]
    public abstract partial class DataBindingHandler
    {
        protected DataBindingHandler() { }
        public abstract void DataBindControl(System.ComponentModel.Design.IDesignerHost designerHost, System.Web.UI.Control control);
    }
    [System.Security.Permissions.SecurityPermissionAttribute(System.Security.Permissions.SecurityAction.Demand, Flags=System.Security.Permissions.SecurityPermissionFlag.UnmanagedCode)]
    public partial class DataBindingValueUIHandler
    {
        public DataBindingValueUIHandler() { }
        public void OnGetUIValueItem(System.ComponentModel.ITypeDescriptorContext context, System.ComponentModel.PropertyDescriptor propDesc, System.Collections.ArrayList valueUIItemList) { }
    }
    [System.Security.Permissions.SecurityPermissionAttribute(System.Security.Permissions.SecurityAction.Demand, Flags=System.Security.Permissions.SecurityPermissionFlag.UnmanagedCode)]
    public partial class DataColumnSelectionConverter : System.ComponentModel.TypeConverter
    {
        public DataColumnSelectionConverter() { }
        public override bool CanConvertFrom(System.ComponentModel.ITypeDescriptorContext context, System.Type sourceType) { throw null; }
        public override object ConvertFrom(System.ComponentModel.ITypeDescriptorContext context, System.Globalization.CultureInfo culture, object value) { throw null; }
        public override System.ComponentModel.TypeConverter.StandardValuesCollection GetStandardValues(System.ComponentModel.ITypeDescriptorContext context) { throw null; }
        public override bool GetStandardValuesExclusive(System.ComponentModel.ITypeDescriptorContext context) { throw null; }
        public override bool GetStandardValuesSupported(System.ComponentModel.ITypeDescriptorContext context) { throw null; }
    }
    [System.Security.Permissions.SecurityPermissionAttribute(System.Security.Permissions.SecurityAction.Demand, Flags=System.Security.Permissions.SecurityPermissionFlag.UnmanagedCode)]
    public partial class DataFieldConverter : System.ComponentModel.TypeConverter
    {
        public DataFieldConverter() { }
        public override bool CanConvertFrom(System.ComponentModel.ITypeDescriptorContext context, System.Type sourceType) { throw null; }
        public override object ConvertFrom(System.ComponentModel.ITypeDescriptorContext context, System.Globalization.CultureInfo culture, object value) { throw null; }
        public override System.ComponentModel.TypeConverter.StandardValuesCollection GetStandardValues(System.ComponentModel.ITypeDescriptorContext context) { throw null; }
        public override bool GetStandardValuesExclusive(System.ComponentModel.ITypeDescriptorContext context) { throw null; }
        public override bool GetStandardValuesSupported(System.ComponentModel.ITypeDescriptorContext context) { throw null; }
    }
    [System.Security.Permissions.SecurityPermissionAttribute(System.Security.Permissions.SecurityAction.Demand, Flags=System.Security.Permissions.SecurityPermissionFlag.UnmanagedCode)]
    public partial class DataMemberConverter : System.ComponentModel.TypeConverter
    {
        public DataMemberConverter() { }
        public override bool CanConvertFrom(System.ComponentModel.ITypeDescriptorContext context, System.Type sourceType) { throw null; }
        public override object ConvertFrom(System.ComponentModel.ITypeDescriptorContext context, System.Globalization.CultureInfo culture, object value) { throw null; }
        public override System.ComponentModel.TypeConverter.StandardValuesCollection GetStandardValues(System.ComponentModel.ITypeDescriptorContext context) { throw null; }
        public override bool GetStandardValuesExclusive(System.ComponentModel.ITypeDescriptorContext context) { throw null; }
        public override bool GetStandardValuesSupported(System.ComponentModel.ITypeDescriptorContext context) { throw null; }
    }
    public sealed partial class DataSetFieldSchema : System.Web.UI.Design.IDataSourceFieldSchema
    {
        public DataSetFieldSchema(System.Data.DataColumn column) { }
        public System.Type DataType { get { throw null; } }
        public bool Identity { get { throw null; } }
        public bool IsReadOnly { get { throw null; } }
        public bool IsUnique { get { throw null; } }
        public int Length { get { throw null; } }
        public string Name { get { throw null; } }
        public bool Nullable { get { throw null; } }
        public int Precision { get { throw null; } }
        public bool PrimaryKey { get { throw null; } }
        public int Scale { get { throw null; } }
    }
    public sealed partial class DataSetSchema : System.Web.UI.Design.IDataSourceSchema
    {
        public DataSetSchema(System.Data.DataSet dataSet) { }
        public System.Web.UI.Design.IDataSourceViewSchema[] GetViews() { throw null; }
    }
    public sealed partial class DataSetViewSchema : System.Web.UI.Design.IDataSourceViewSchema
    {
        public DataSetViewSchema(System.Data.DataTable dataTable) { }
        public string Name { get { throw null; } }
        public System.Web.UI.Design.IDataSourceViewSchema[] GetChildren() { throw null; }
        public System.Web.UI.Design.IDataSourceFieldSchema[] GetFields() { throw null; }
    }
    [System.Security.Permissions.SecurityPermissionAttribute(System.Security.Permissions.SecurityAction.Demand, Flags=System.Security.Permissions.SecurityPermissionFlag.UnmanagedCode)]
    public partial class DataSourceBooleanViewSchemaConverter : System.Web.UI.Design.DataSourceViewSchemaConverter
    {
        public DataSourceBooleanViewSchemaConverter() { }
        public override System.ComponentModel.TypeConverter.StandardValuesCollection GetStandardValues(System.ComponentModel.ITypeDescriptorContext context) { throw null; }
    }
    [System.Security.Permissions.SecurityPermissionAttribute(System.Security.Permissions.SecurityAction.Demand, Flags=System.Security.Permissions.SecurityPermissionFlag.UnmanagedCode)]
    public partial class DataSourceConverter : System.ComponentModel.TypeConverter
    {
        public DataSourceConverter() { }
        public override bool CanConvertFrom(System.ComponentModel.ITypeDescriptorContext context, System.Type sourceType) { throw null; }
        public override object ConvertFrom(System.ComponentModel.ITypeDescriptorContext context, System.Globalization.CultureInfo culture, object value) { throw null; }
        public override System.ComponentModel.TypeConverter.StandardValuesCollection GetStandardValues(System.ComponentModel.ITypeDescriptorContext context) { throw null; }
        public override bool GetStandardValuesExclusive(System.ComponentModel.ITypeDescriptorContext context) { throw null; }
        public override bool GetStandardValuesSupported(System.ComponentModel.ITypeDescriptorContext context) { throw null; }
        protected virtual bool IsValidDataSource(System.ComponentModel.IComponent component) { throw null; }
    }
    [System.Security.Permissions.SecurityPermissionAttribute(System.Security.Permissions.SecurityAction.Demand, Flags=System.Security.Permissions.SecurityPermissionFlag.UnmanagedCode)]
    public partial class DataSourceDesigner : System.Web.UI.Design.ControlDesigner, System.Web.UI.Design.IDataSourceDesigner
    {
        public DataSourceDesigner() { }
        public override System.ComponentModel.Design.DesignerActionListCollection ActionLists { get { throw null; } }
        public virtual bool CanConfigure { get { throw null; } }
        public virtual bool CanRefreshSchema { get { throw null; } }
        protected bool SuppressingDataSourceEvents { get { throw null; } }
        public event System.EventHandler DataSourceChanged { add { } remove { } }
        public event System.EventHandler SchemaRefreshed { add { } remove { } }
        public virtual void Configure() { }
        public override string GetDesignTimeHtml() { throw null; }
        public virtual System.Web.UI.Design.DesignerDataSourceView GetView(string viewName) { throw null; }
        public virtual string[] GetViewNames() { throw null; }
        protected virtual void OnDataSourceChanged(System.EventArgs e) { }
        protected virtual void OnSchemaRefreshed(System.EventArgs e) { }
        public virtual void RefreshSchema(bool preferSilent) { }
        public virtual void ResumeDataSourceEvents() { }
        public static bool SchemasEquivalent(System.Web.UI.Design.IDataSourceSchema schema1, System.Web.UI.Design.IDataSourceSchema schema2) { throw null; }
        public virtual void SuppressDataSourceEvents() { }
        public static bool ViewSchemasEquivalent(System.Web.UI.Design.IDataSourceViewSchema viewSchema1, System.Web.UI.Design.IDataSourceViewSchema viewSchema2) { throw null; }
    }
    [System.Security.Permissions.SecurityPermissionAttribute(System.Security.Permissions.SecurityAction.Demand, Flags=System.Security.Permissions.SecurityPermissionFlag.UnmanagedCode)]
    public partial class DataSourceViewSchemaConverter : System.ComponentModel.TypeConverter
    {
        public DataSourceViewSchemaConverter() { }
        public override bool CanConvertFrom(System.ComponentModel.ITypeDescriptorContext context, System.Type sourceType) { throw null; }
        public override object ConvertFrom(System.ComponentModel.ITypeDescriptorContext context, System.Globalization.CultureInfo culture, object value) { throw null; }
        public override System.ComponentModel.TypeConverter.StandardValuesCollection GetStandardValues(System.ComponentModel.ITypeDescriptorContext context) { throw null; }
        public virtual System.ComponentModel.TypeConverter.StandardValuesCollection GetStandardValues(System.ComponentModel.ITypeDescriptorContext context, System.Type typeFilter) { throw null; }
        public override bool GetStandardValuesExclusive(System.ComponentModel.ITypeDescriptorContext context) { throw null; }
        public override bool GetStandardValuesSupported(System.ComponentModel.ITypeDescriptorContext context) { throw null; }
    }
    public abstract partial class DesignerAutoFormat
    {
        protected DesignerAutoFormat(string name) { }
        public string Name { get { throw null; } }
        public System.Web.UI.Design.DesignerAutoFormatStyle Style { get { throw null; } }
        public abstract void Apply(System.Web.UI.Control control);
        public virtual System.Web.UI.Control GetPreviewControl(System.Web.UI.Control runtimeControl) { throw null; }
        public override string ToString() { throw null; }
    }
    public sealed partial class DesignerAutoFormatCollection : System.Collections.ICollection, System.Collections.IEnumerable, System.Collections.IList
    {
        public DesignerAutoFormatCollection() { }
        public int Count { get { throw null; } }
        public System.Web.UI.Design.DesignerAutoFormat this[int index] { get { throw null; } }
        public System.Drawing.Size PreviewSize { get { throw null; } }
        public object SyncRoot { get { throw null; } }
        int System.Collections.ICollection.Count { get { throw null; } }
        bool System.Collections.ICollection.IsSynchronized { get { throw null; } }
        bool System.Collections.IList.IsFixedSize { get { throw null; } }
        bool System.Collections.IList.IsReadOnly { get { throw null; } }
        object System.Collections.IList.this[int index] { get { throw null; } set { } }
        public int Add(System.Web.UI.Design.DesignerAutoFormat format) { throw null; }
        public void Clear() { }
        public bool Contains(System.Web.UI.Design.DesignerAutoFormat format) { throw null; }
        public int IndexOf(System.Web.UI.Design.DesignerAutoFormat format) { throw null; }
        public void Insert(int index, System.Web.UI.Design.DesignerAutoFormat format) { }
        public void Remove(System.Web.UI.Design.DesignerAutoFormat format) { }
        public void RemoveAt(int index) { }
        void System.Collections.ICollection.CopyTo(System.Array array, int index) { }
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { throw null; }
        int System.Collections.IList.Add(object value) { throw null; }
        bool System.Collections.IList.Contains(object value) { throw null; }
        int System.Collections.IList.IndexOf(object value) { throw null; }
        void System.Collections.IList.Insert(int index, object value) { }
        void System.Collections.IList.Remove(object value) { }
        void System.Collections.IList.RemoveAt(int index) { }
    }
    public partial class DesignerAutoFormatStyle : System.Web.UI.WebControls.Style
    {
        public DesignerAutoFormatStyle() { }
        public System.Web.UI.WebControls.VerticalAlign VerticalAlign { get { throw null; } set { } }
    }
    public abstract partial class DesignerDataSourceView
    {
        protected DesignerDataSourceView(System.Web.UI.Design.IDataSourceDesigner owner, string viewName) { }
        public virtual bool CanDelete { get { throw null; } }
        public virtual bool CanInsert { get { throw null; } }
        public virtual bool CanPage { get { throw null; } }
        public virtual bool CanRetrieveTotalRowCount { get { throw null; } }
        public virtual bool CanSort { get { throw null; } }
        public virtual bool CanUpdate { get { throw null; } }
        public System.Web.UI.Design.IDataSourceDesigner DataSourceDesigner { get { throw null; } }
        public string Name { get { throw null; } }
        public virtual System.Web.UI.Design.IDataSourceViewSchema Schema { get { throw null; } }
        public virtual System.Collections.IEnumerable GetDesignTimeData(int minimumRows, out bool isSampleData) { throw null; }
    }
    public abstract partial class DesignerHierarchicalDataSourceView
    {
        protected DesignerHierarchicalDataSourceView(System.Web.UI.Design.IHierarchicalDataSourceDesigner owner, string viewPath) { }
        public System.Web.UI.Design.IHierarchicalDataSourceDesigner DataSourceDesigner { get { throw null; } }
        public string Path { get { throw null; } }
        public virtual System.Web.UI.Design.IDataSourceSchema Schema { get { throw null; } }
        public virtual System.Web.UI.IHierarchicalEnumerable GetDesignTimeData(out bool isSampleData) { throw null; }
    }
    public abstract partial class DesignerObject : System.IServiceProvider
    {
        protected DesignerObject(System.Web.UI.Design.ControlDesigner designer, string name) { }
        public System.Web.UI.Design.ControlDesigner Designer { get { throw null; } }
        public string Name { get { throw null; } }
        public System.Collections.IDictionary Properties { get { throw null; } }
        protected object GetService(System.Type serviceType) { throw null; }
        object System.IServiceProvider.GetService(System.Type serviceType) { throw null; }
    }
    public partial class DesignerRegion : System.Web.UI.Design.DesignerObject
    {
        public static readonly string DesignerRegionAttributeName;
        public DesignerRegion(System.Web.UI.Design.ControlDesigner designer, string name) : base (default(System.Web.UI.Design.ControlDesigner), default(string)) { }
        public DesignerRegion(System.Web.UI.Design.ControlDesigner designer, string name, bool selectable) : base (default(System.Web.UI.Design.ControlDesigner), default(string)) { }
        public virtual string Description { get { throw null; } set { } }
        public virtual string DisplayName { get { throw null; } set { } }
        public bool EnsureSize { get { throw null; } set { } }
        public virtual bool Highlight { get { throw null; } set { } }
        public virtual bool Selectable { get { throw null; } set { } }
        public virtual bool Selected { get { throw null; } set { } }
        public object UserData { get { throw null; } set { } }
        public System.Drawing.Rectangle GetBounds() { throw null; }
    }
    public partial class DesignerRegionCollection : System.Collections.ICollection, System.Collections.IEnumerable, System.Collections.IList
    {
        public DesignerRegionCollection() { }
        public DesignerRegionCollection(System.Web.UI.Design.ControlDesigner owner) { }
        public int Count { get { throw null; } }
        public bool IsFixedSize { get { throw null; } }
        public bool IsReadOnly { get { throw null; } }
        public bool IsSynchronized { get { throw null; } }
        public System.Web.UI.Design.DesignerRegion this[int index] { get { throw null; } set { } }
        public System.Web.UI.Design.ControlDesigner Owner { get { throw null; } }
        public object SyncRoot { get { throw null; } }
        int System.Collections.ICollection.Count { get { throw null; } }
        bool System.Collections.ICollection.IsSynchronized { get { throw null; } }
        object System.Collections.ICollection.SyncRoot { get { throw null; } }
        bool System.Collections.IList.IsFixedSize { get { throw null; } }
        bool System.Collections.IList.IsReadOnly { get { throw null; } }
        object System.Collections.IList.this[int index] { get { throw null; } set { } }
        public int Add(System.Web.UI.Design.DesignerRegion region) { throw null; }
        public void Clear() { }
        public bool Contains(System.Web.UI.Design.DesignerRegion region) { throw null; }
        public void CopyTo(System.Array array, int index) { }
        public System.Collections.IEnumerator GetEnumerator() { throw null; }
        public int IndexOf(System.Web.UI.Design.DesignerRegion region) { throw null; }
        public void Insert(int index, System.Web.UI.Design.DesignerRegion region) { }
        public void Remove(System.Web.UI.Design.DesignerRegion region) { }
        public void RemoveAt(int index) { }
        void System.Collections.ICollection.CopyTo(System.Array array, int index) { }
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { throw null; }
        int System.Collections.IList.Add(object o) { throw null; }
        void System.Collections.IList.Clear() { }
        bool System.Collections.IList.Contains(object o) { throw null; }
        int System.Collections.IList.IndexOf(object o) { throw null; }
        void System.Collections.IList.Insert(int index, object o) { }
        void System.Collections.IList.Remove(object o) { }
        void System.Collections.IList.RemoveAt(int index) { }
    }
    public sealed partial class DesignerRegionMouseEventArgs : System.EventArgs
    {
        public DesignerRegionMouseEventArgs(System.Web.UI.Design.DesignerRegion region, System.Drawing.Point location) { }
        public System.Drawing.Point Location { get { throw null; } }
        public System.Web.UI.Design.DesignerRegion Region { get { throw null; } }
    }
    [System.Security.Permissions.SecurityPermissionAttribute(System.Security.Permissions.SecurityAction.Demand, Flags=System.Security.Permissions.SecurityPermissionFlag.UnmanagedCode)]
    public sealed partial class DesignTimeData
    {
        internal DesignTimeData() { }
        public static readonly System.EventHandler DataBindingHandler;
        public static System.Data.DataTable CreateDummyDataBoundDataTable() { throw null; }
        public static System.Data.DataTable CreateDummyDataTable() { throw null; }
        public static System.Data.DataTable CreateSampleDataTable(System.Collections.IEnumerable referenceData) { throw null; }
        public static System.Data.DataTable CreateSampleDataTable(System.Collections.IEnumerable referenceData, bool useDataBoundData) { throw null; }
        public static System.ComponentModel.PropertyDescriptorCollection GetDataFields(System.Collections.IEnumerable dataSource) { throw null; }
        public static System.Collections.IEnumerable GetDataMember(System.ComponentModel.IListSource dataSource, string dataMember) { throw null; }
        public static string[] GetDataMembers(object dataSource) { throw null; }
        public static System.Collections.IEnumerable GetDesignTimeDataSource(System.Data.DataTable dataTable, int minimumRows) { throw null; }
        public static object GetSelectedDataSource(System.ComponentModel.IComponent component, string dataSource) { throw null; }
        public static System.Collections.IEnumerable GetSelectedDataSource(System.ComponentModel.IComponent component, string dataSource, string dataMember) { throw null; }
    }
    public abstract partial class DesignTimeResourceProviderFactory
    {
        protected DesignTimeResourceProviderFactory() { }
        public abstract System.Web.Compilation.IResourceProvider CreateDesignTimeGlobalResourceProvider(System.IServiceProvider serviceProvider, string classKey);
        public abstract System.Web.Compilation.IResourceProvider CreateDesignTimeLocalResourceProvider(System.IServiceProvider serviceProvider);
        public abstract System.Web.UI.Design.IDesignTimeResourceWriter CreateDesignTimeLocalResourceWriter(System.IServiceProvider serviceProvider);
    }
    public partial class EditableDesignerRegion : System.Web.UI.Design.DesignerRegion
    {
        public EditableDesignerRegion(System.Web.UI.Design.ControlDesigner owner, string name) : base (default(System.Web.UI.Design.ControlDesigner), default(string)) { }
        public EditableDesignerRegion(System.Web.UI.Design.ControlDesigner owner, string name, bool serverControlsOnly) : base (default(System.Web.UI.Design.ControlDesigner), default(string)) { }
        public virtual string Content { get { throw null; } set { } }
        public bool ServerControlsOnly { get { throw null; } set { } }
        public virtual bool SupportsDataBinding { get { throw null; } set { } }
        public virtual System.Web.UI.Design.ViewRendering GetChildViewRendering(System.Web.UI.Control control) { throw null; }
    }
    public abstract partial class ExpressionEditor
    {
        protected ExpressionEditor() { }
        public string ExpressionPrefix { get { throw null; } }
        public abstract object EvaluateExpression(string expression, object parseTimeData, System.Type propertyType, System.IServiceProvider serviceProvider);
        public static System.Web.UI.Design.ExpressionEditor GetExpressionEditor(string expressionPrefix, System.IServiceProvider serviceProvider) { throw null; }
        public static System.Web.UI.Design.ExpressionEditor GetExpressionEditor(System.Type expressionBuilderType, System.IServiceProvider serviceProvider) { throw null; }
        public virtual System.Web.UI.Design.ExpressionEditorSheet GetExpressionEditorSheet(string expression, System.IServiceProvider serviceProvider) { throw null; }
    }
    public abstract partial class ExpressionEditorSheet
    {
        protected ExpressionEditorSheet(System.IServiceProvider serviceProvider) { }
        [System.ComponentModel.BrowsableAttribute(false)]
        public virtual bool IsValid { get { throw null; } }
        [System.ComponentModel.BrowsableAttribute(false)]
        public System.IServiceProvider ServiceProvider { get { throw null; } }
        public abstract string GetExpression();
    }
    [System.Security.Permissions.SecurityPermissionAttribute(System.Security.Permissions.SecurityAction.Demand, Flags=System.Security.Permissions.SecurityPermissionFlag.UnmanagedCode)]
    public partial class ExpressionsCollectionConverter : System.ComponentModel.TypeConverter
    {
        public ExpressionsCollectionConverter() { }
        public override object ConvertTo(System.ComponentModel.ITypeDescriptorContext context, System.Globalization.CultureInfo culture, object value, System.Type destinationType) { throw null; }
    }
    [System.Security.Permissions.SecurityPermissionAttribute(System.Security.Permissions.SecurityAction.Demand, Flags=System.Security.Permissions.SecurityPermissionFlag.UnmanagedCode)]
    public partial class ExpressionsCollectionEditor : System.Drawing.Design.UITypeEditor
    {
        public ExpressionsCollectionEditor() { }
        public override object EditValue(System.ComponentModel.ITypeDescriptorContext context, System.IServiceProvider provider, object value) { throw null; }
        public override System.Drawing.Design.UITypeEditorEditStyle GetEditStyle(System.ComponentModel.ITypeDescriptorContext context) { throw null; }
    }
    [System.Security.Permissions.SecurityPermissionAttribute(System.Security.Permissions.SecurityAction.Demand, Flags=System.Security.Permissions.SecurityPermissionFlag.UnmanagedCode)]
    public partial class HierarchicalDataSourceConverter : System.Web.UI.Design.DataSourceConverter
    {
        public HierarchicalDataSourceConverter() { }
        protected override bool IsValidDataSource(System.ComponentModel.IComponent component) { throw null; }
    }
    [System.Security.Permissions.SecurityPermissionAttribute(System.Security.Permissions.SecurityAction.Demand, Flags=System.Security.Permissions.SecurityPermissionFlag.UnmanagedCode)]
    public partial class HierarchicalDataSourceDesigner : System.Web.UI.Design.ControlDesigner, System.Web.UI.Design.IHierarchicalDataSourceDesigner
    {
        public HierarchicalDataSourceDesigner() { }
        public override System.ComponentModel.Design.DesignerActionListCollection ActionLists { get { throw null; } }
        public virtual bool CanConfigure { get { throw null; } }
        public virtual bool CanRefreshSchema { get { throw null; } }
        protected bool SuppressingDataSourceEvents { get { throw null; } }
        public event System.EventHandler DataSourceChanged { add { } remove { } }
        public event System.EventHandler SchemaRefreshed { add { } remove { } }
        public virtual void Configure() { }
        public override string GetDesignTimeHtml() { throw null; }
        public virtual System.Web.UI.Design.DesignerHierarchicalDataSourceView GetView(string viewPath) { throw null; }
        protected virtual void OnDataSourceChanged(System.EventArgs e) { }
        protected virtual void OnSchemaRefreshed(System.EventArgs e) { }
        public virtual void RefreshSchema(bool preferSilent) { }
        public virtual void ResumeDataSourceEvents() { }
        public virtual void SuppressDataSourceEvents() { }
    }
    [System.Security.Permissions.SecurityPermissionAttribute(System.Security.Permissions.SecurityAction.Demand, Flags=System.Security.Permissions.SecurityPermissionFlag.UnmanagedCode)]
    public partial class HtmlControlDesigner : System.ComponentModel.Design.ComponentDesigner
    {
        public HtmlControlDesigner() { }
        [System.ObsoleteAttribute("The recommended alternative is ControlDesigner.Tag. http://go.microsoft.com/fwlink/?linkid=14202")]
        public System.Web.UI.Design.IHtmlControlDesignerBehavior Behavior { get { throw null; } set { } }
        public System.Web.UI.DataBindingCollection DataBindings { get { throw null; } }
        [System.ObsoleteAttribute("Error: This property can no longer be referenced, and is included to support existing compiled applications. The design-time element may not always provide access to the element in the markup. There are alternate methods on WebFormsRootDesigner for handling client script and controls. http://go.microsoft.com/fwlink/?linkid=14202", true)]
        protected object DesignTimeElement { get { throw null; } }
        public System.Web.UI.ExpressionBindingCollection Expressions { get { throw null; } }
        [System.ObsoleteAttribute("Use of this property is not recommended because code serialization is not supported. http://go.microsoft.com/fwlink/?linkid=14202")]
        public virtual bool ShouldCodeSerialize { get { throw null; } set { } }
        protected override void Dispose(bool disposing) { }
        public override void Initialize(System.ComponentModel.IComponent component) { }
        [System.ObsoleteAttribute("The recommended alternative is ControlDesigner.Tag. http://go.microsoft.com/fwlink/?linkid=14202")]
        protected virtual void OnBehaviorAttached() { }
        [System.ObsoleteAttribute("The recommended alternative is ControlDesigner.Tag. http://go.microsoft.com/fwlink/?linkid=14202")]
        protected virtual void OnBehaviorDetaching() { }
        [System.ObsoleteAttribute("The recommended alternative is to handle the Changed event on the DataBindings collection. The DataBindings collection allows more control of the databindings associated with the control. http://go.microsoft.com/fwlink/?linkid=14202")]
        protected virtual void OnBindingsCollectionChanged(string propName) { }
        public virtual void OnSetParent() { }
        protected override void PreFilterEvents(System.Collections.IDictionary events) { }
        protected override void PreFilterProperties(System.Collections.IDictionary properties) { }
    }
    [System.Security.Permissions.SecurityPermissionAttribute(System.Security.Permissions.SecurityAction.Demand, Flags=System.Security.Permissions.SecurityPermissionFlag.UnmanagedCode)]
    public partial class HtmlIntrinsicControlDesigner : System.Web.UI.Design.HtmlControlDesigner
    {
        public HtmlIntrinsicControlDesigner() { }
    }
    [System.Security.Permissions.SecurityPermissionAttribute(System.Security.Permissions.SecurityAction.Demand, Flags=System.Security.Permissions.SecurityPermissionFlag.UnmanagedCode)]
    public partial class HyperLinkDataBindingHandler : System.Web.UI.Design.DataBindingHandler
    {
        public HyperLinkDataBindingHandler() { }
        public override void DataBindControl(System.ComponentModel.Design.IDesignerHost designerHost, System.Web.UI.Control control) { }
    }
    public partial interface IContentResolutionService
    {
        System.Collections.IDictionary ContentDefinitions { get; }
        System.Web.UI.Design.ContentDesignerState GetContentDesignerState(string identifier);
        void SetContentDesignerState(string identifier, System.Web.UI.Design.ContentDesignerState state);
    }
    [System.ObsoleteAttribute("The recommended alternative is System.Web.UI.Design.IControlDesignerTag and System.Web.UI.Design.IControlDesignerView. http://go.microsoft.com/fwlink/?linkid=14202")]
    public partial interface IControlDesignerBehavior
    {
        object DesignTimeElementView { get; }
        string DesignTimeHtml { get; set; }
        void OnTemplateModeChanged();
    }
    public partial interface IControlDesignerTag
    {
        bool IsDirty { get; }
        string GetAttribute(string name);
        string GetContent();
        string GetOuterContent();
        void RemoveAttribute(string name);
        void SetAttribute(string name, string value);
        void SetContent(string content);
        void SetDirty(bool dirty);
    }
    public partial interface IControlDesignerView
    {
        System.Web.UI.Design.DesignerRegion ContainingRegion { get; }
        System.ComponentModel.Design.IDesigner NamingContainerDesigner { get; }
        bool SupportsRegions { get; }
        event System.Web.UI.Design.ViewEventHandler ViewEvent;
        System.Drawing.Rectangle GetBounds(System.Web.UI.Design.DesignerRegion region);
        void Invalidate(System.Drawing.Rectangle rectangle);
        void SetFlags(System.Web.UI.Design.ViewFlags viewFlags, bool setFlag);
        void SetRegionContent(System.Web.UI.Design.EditableDesignerRegion region, string content);
        void Update();
    }
    public partial interface IDataBindingSchemaProvider
    {
        bool CanRefreshSchema { get; }
        System.Web.UI.Design.IDataSourceViewSchema Schema { get; }
        void RefreshSchema(bool preferSilent);
    }
    public partial interface IDataSourceDesigner
    {
        bool CanConfigure { get; }
        bool CanRefreshSchema { get; }
        event System.EventHandler DataSourceChanged;
        event System.EventHandler SchemaRefreshed;
        void Configure();
        System.Web.UI.Design.DesignerDataSourceView GetView(string viewName);
        string[] GetViewNames();
        void RefreshSchema(bool preferSilent);
        void ResumeDataSourceEvents();
        void SuppressDataSourceEvents();
    }
    public partial interface IDataSourceFieldSchema
    {
        System.Type DataType { get; }
        bool Identity { get; }
        bool IsReadOnly { get; }
        bool IsUnique { get; }
        int Length { get; }
        string Name { get; }
        bool Nullable { get; }
        int Precision { get; }
        bool PrimaryKey { get; }
        int Scale { get; }
    }
    public partial interface IDataSourceProvider
    {
        System.Collections.IEnumerable GetResolvedSelectedDataSource();
        object GetSelectedDataSource();
    }
    public partial interface IDataSourceSchema
    {
        System.Web.UI.Design.IDataSourceViewSchema[] GetViews();
    }
    public partial interface IDataSourceViewSchema
    {
        string Name { get; }
        System.Web.UI.Design.IDataSourceViewSchema[] GetChildren();
        System.Web.UI.Design.IDataSourceFieldSchema[] GetFields();
    }
    public partial interface IDesignTimeResourceProviderFactoryService
    {
        System.Web.UI.Design.DesignTimeResourceProviderFactory GetFactory();
    }
    public partial interface IDesignTimeResourceWriter : System.IDisposable, System.Resources.IResourceWriter
    {
        string CreateResourceKey(string resourceName, object obj);
    }
    public partial interface IDocumentProjectItem
    {
        System.IO.Stream GetContents();
        void Open();
    }
    public partial interface IFolderProjectItem
    {
        System.Collections.ICollection Children { get; }
        System.Web.UI.Design.IDocumentProjectItem AddDocument(string name, byte[] content);
        System.Web.UI.Design.IFolderProjectItem AddFolder(string name);
    }
    public partial interface IHierarchicalDataSourceDesigner
    {
        bool CanConfigure { get; }
        bool CanRefreshSchema { get; }
        event System.EventHandler DataSourceChanged;
        event System.EventHandler SchemaRefreshed;
        void Configure();
        System.Web.UI.Design.DesignerHierarchicalDataSourceView GetView(string viewPath);
        void RefreshSchema(bool preferSilent);
        void ResumeDataSourceEvents();
        void SuppressDataSourceEvents();
    }
    [System.ObsoleteAttribute("The recommended alternative is System.Web.UI.Design.IControlDesignerTag and System.Web.UI.Design.IControlDesignerView. http://go.microsoft.com/fwlink/?linkid=14202")]
    public partial interface IHtmlControlDesignerBehavior
    {
        System.Web.UI.Design.HtmlControlDesigner Designer { get; set; }
        object DesignTimeElement { get; }
        object GetAttribute(string attribute, bool ignoreCase);
        object GetStyleAttribute(string attribute, bool designTimeOnly, bool ignoreCase);
        void RemoveAttribute(string attribute, bool ignoreCase);
        void RemoveStyleAttribute(string attribute, bool designTimeOnly, bool ignoreCase);
        void SetAttribute(string attribute, object value, bool ignoreCase);
        void SetStyleAttribute(string attribute, bool designTimeOnly, object value, bool ignoreCase);
    }
    [System.Security.Permissions.SecurityPermissionAttribute(System.Security.Permissions.SecurityAction.Demand, Flags=System.Security.Permissions.SecurityPermissionFlag.UnmanagedCode)]
    public partial class ImageUrlEditor : System.Web.UI.Design.UrlEditor
    {
        public ImageUrlEditor() { }
        protected override string Caption { get { throw null; } }
        protected override string Filter { get { throw null; } }
    }
    public partial interface IProjectItem
    {
        string AppRelativeUrl { get; }
        string Name { get; }
        System.Web.UI.Design.IProjectItem Parent { get; }
        string PhysicalPath { get; }
    }
    [System.ObsoleteAttribute("Use of this type is not recommended because template editing is handled in ControlDesigner. To support template editing expose template data in the TemplateGroups property and call SetViewFlags(ViewFlags.TemplateEditing, true). http://go.microsoft.com/fwlink/?linkid=14202")]
    public partial interface ITemplateEditingFrame : System.IDisposable
    {
        System.Web.UI.WebControls.Style ControlStyle { get; }
        int InitialHeight { get; set; }
        int InitialWidth { get; set; }
        string Name { get; }
        string[] TemplateNames { get; }
        System.Web.UI.WebControls.Style[] TemplateStyles { get; }
        System.Web.UI.Design.TemplateEditingVerb Verb { get; set; }
        void Close(bool saveChanges);
        void Open();
        void Resize(int width, int height);
        void Save();
        void UpdateControlName(string newName);
    }
    [System.ObsoleteAttribute("Use of this type is not recommended because template editing is handled in ControlDesigner. To support template editing expose template data in the TemplateGroups property and call SetViewFlags(ViewFlags.TemplateEditing, true). http://go.microsoft.com/fwlink/?linkid=14202")]
    public partial interface ITemplateEditingService
    {
        bool SupportsNestedTemplateEditing { get; }
        System.Web.UI.Design.ITemplateEditingFrame CreateFrame(System.Web.UI.Design.TemplatedControlDesigner designer, string frameName, string[] templateNames);
        System.Web.UI.Design.ITemplateEditingFrame CreateFrame(System.Web.UI.Design.TemplatedControlDesigner designer, string frameName, string[] templateNames, System.Web.UI.WebControls.Style controlStyle, System.Web.UI.WebControls.Style[] templateStyles);
        string GetContainingTemplateName(System.Web.UI.Control control);
    }
    public partial interface IWebAdministrationService
    {
        void Start(System.Collections.IDictionary arguments);
    }
    [System.Runtime.InteropServices.GuidAttribute("cff39fa8-5607-4b6d-86f3-cc80b3cfe2dd")]
    public partial interface IWebApplication : System.IServiceProvider
    {
        System.Web.UI.Design.IProjectItem RootProjectItem { get; }
        System.Web.UI.Design.IProjectItem GetProjectItemFromUrl(string appRelativeUrl);
        System.Configuration.Configuration OpenWebConfiguration(bool isReadOnly);
    }
    [System.ObsoleteAttribute("The recommended alternative is System.Web.UI.Design.WebFormsReferenceManager. The WebFormsReferenceManager contains additional functionality and allows for more extensibility. To get the WebFormsReferenceManager use the RootDesigner.ReferenceManager property from your ControlDesigner. http://go.microsoft.com/fwlink/?linkid=14202")]
    public partial interface IWebFormReferenceManager
    {
        System.Type GetObjectType(string tagPrefix, string typeName);
        string GetRegisterDirectives();
        string GetTagPrefix(System.Type objectType);
    }
    public partial interface IWebFormsBuilderUIService
    {
        string BuildColor(System.Windows.Forms.Control owner, string initialColor);
        string BuildUrl(System.Windows.Forms.Control owner, string initialUrl, string baseUrl, string caption, string filter, System.Web.UI.Design.UrlBuilderOptions options);
    }
    [System.ObsoleteAttribute("The recommended alternative is System.Web.UI.Design.WebFormsRootDesigner. The WebFormsRootDesigner contains additional functionality and allows for more extensibility. To get the WebFormsRootDesigner use the RootDesigner property from your ControlDesigner. http://go.microsoft.com/fwlink/?linkid=14202")]
    public partial interface IWebFormsDocumentService
    {
        string DocumentUrl { get; }
        bool IsLoading { get; }
        event System.EventHandler LoadComplete;
        object CreateDiscardableUndoUnit();
        void DiscardUndoUnit(object discardableUndoUnit);
        void EnableUndo(bool enable);
        void UpdateSelection();
    }
    [System.Security.Permissions.SecurityPermissionAttribute(System.Security.Permissions.SecurityAction.Demand, Flags=System.Security.Permissions.SecurityPermissionFlag.UnmanagedCode)]
    public partial class MailFileEditor : System.Web.UI.Design.UrlEditor
    {
        public MailFileEditor() { }
        protected override string Caption { get { throw null; } }
        protected override string Filter { get { throw null; } }
    }
    [System.Security.Permissions.SecurityPermissionAttribute(System.Security.Permissions.SecurityAction.Demand, Flags=System.Security.Permissions.SecurityPermissionFlag.UnmanagedCode)]
    public partial class MdbDataFileEditor : System.Web.UI.Design.UrlEditor
    {
        public MdbDataFileEditor() { }
        protected override string Caption { get { throw null; } }
        protected override string Filter { get { throw null; } }
    }
    [System.ObsoleteAttribute("The recommended alternative is ContainerControlDesigner because it uses an EditableDesignerRegion for editing the content. Designer regions allow for better control of the content being edited. http://go.microsoft.com/fwlink/?linkid=14202")]
    [System.Security.Permissions.SecurityPermissionAttribute(System.Security.Permissions.SecurityAction.Demand, Flags=System.Security.Permissions.SecurityPermissionFlag.UnmanagedCode)]
    public partial class ReadWriteControlDesigner : System.Web.UI.Design.ControlDesigner
    {
        public ReadWriteControlDesigner() { }
        public override string GetDesignTimeHtml() { throw null; }
        protected virtual void MapPropertyToStyle(string propName, object varPropValue) { }
        [System.ObsoleteAttribute("The recommended alternative is ControlDesigner.Tag. http://go.microsoft.com/fwlink/?linkid=14202")]
        protected override void OnBehaviorAttached() { }
        public override void OnComponentChanged(object sender, System.ComponentModel.Design.ComponentChangedEventArgs ce) { }
        public override void UpdateDesignTimeHtml() { }
    }
    public partial class ResourceExpressionEditor : System.Web.UI.Design.ExpressionEditor
    {
        public ResourceExpressionEditor() { }
        public override object EvaluateExpression(string expression, object parseTimeData, System.Type propertyType, System.IServiceProvider serviceProvider) { throw null; }
        public override System.Web.UI.Design.ExpressionEditorSheet GetExpressionEditorSheet(string expression, System.IServiceProvider serviceProvider) { throw null; }
    }
    public partial class ResourceExpressionEditorSheet : System.Web.UI.Design.ExpressionEditorSheet
    {
        public ResourceExpressionEditorSheet(string expression, System.IServiceProvider serviceProvider) : base (default(System.IServiceProvider)) { }
        [System.ComponentModel.DefaultValueAttribute("")]
        public string ClassKey { get { throw null; } set { } }
        public override bool IsValid { get { throw null; } }
        [System.ComponentModel.DefaultValueAttribute("")]
        [System.ComponentModel.TypeConverterAttribute("System.Web.UI.Design.ResourceExpressionEditorSheet.ResourceKeyTypeConverter")]
        public string ResourceKey { get { throw null; } set { } }
        public override string GetExpression() { throw null; }
    }
    public partial class RouteUrlExpressionEditor : System.Web.UI.Design.ExpressionEditor
    {
        public RouteUrlExpressionEditor() { }
        public override object EvaluateExpression(string expression, object parseTimeData, System.Type propertyType, System.IServiceProvider serviceProvider) { throw null; }
        public override System.Web.UI.Design.ExpressionEditorSheet GetExpressionEditorSheet(string expression, System.IServiceProvider serviceProvider) { throw null; }
    }
    public partial class RouteUrlExpressionEditorSheet : System.Web.UI.Design.ExpressionEditorSheet
    {
        public RouteUrlExpressionEditorSheet(string expression, System.IServiceProvider serviceProvider) : base (default(System.IServiceProvider)) { }
        public override bool IsValid { get { throw null; } }
        [System.ComponentModel.DefaultValueAttribute("")]
        public string RouteName { get { throw null; } set { } }
        [System.ComponentModel.DefaultValueAttribute("")]
        public string RouteValues { get { throw null; } set { } }
        public override string GetExpression() { throw null; }
    }
    public partial class RouteValueExpressionEditor : System.Web.UI.Design.ExpressionEditor
    {
        public RouteValueExpressionEditor() { }
        public override object EvaluateExpression(string expression, object parseTimeData, System.Type propertyType, System.IServiceProvider serviceProvider) { throw null; }
        public override System.Web.UI.Design.ExpressionEditorSheet GetExpressionEditorSheet(string expression, System.IServiceProvider serviceProvider) { throw null; }
    }
    public partial class RouteValueExpressionEditorSheet : System.Web.UI.Design.ExpressionEditorSheet
    {
        public RouteValueExpressionEditorSheet(string expression, System.IServiceProvider serviceProvider) : base (default(System.IServiceProvider)) { }
        public override bool IsValid { get { throw null; } }
        [System.ComponentModel.DefaultValueAttribute("")]
        public string RouteValue { get { throw null; } set { } }
        public override string GetExpression() { throw null; }
    }
    public partial class SkinIDTypeConverter : System.ComponentModel.TypeConverter
    {
        public SkinIDTypeConverter() { }
        public override bool CanConvertFrom(System.ComponentModel.ITypeDescriptorContext context, System.Type sourceType) { throw null; }
        public override bool CanConvertTo(System.ComponentModel.ITypeDescriptorContext context, System.Type destType) { throw null; }
        public override object ConvertFrom(System.ComponentModel.ITypeDescriptorContext context, System.Globalization.CultureInfo culture, object value) { throw null; }
        public override object ConvertTo(System.ComponentModel.ITypeDescriptorContext context, System.Globalization.CultureInfo culture, object value, System.Type destinationType) { throw null; }
        public override System.ComponentModel.TypeConverter.StandardValuesCollection GetStandardValues(System.ComponentModel.ITypeDescriptorContext context) { throw null; }
        public override bool GetStandardValuesSupported(System.ComponentModel.ITypeDescriptorContext context) { throw null; }
    }
    [System.AttributeUsageAttribute(System.AttributeTargets.Class)]
    public sealed partial class SupportsPreviewControlAttribute : System.Attribute
    {
        public static readonly System.Web.UI.Design.SupportsPreviewControlAttribute Default;
        public SupportsPreviewControlAttribute(bool supportsPreviewControl) { }
        public bool SupportsPreviewControl { get { throw null; } }
        public override bool Equals(object obj) { throw null; }
        public override int GetHashCode() { throw null; }
        public override bool IsDefaultAttribute() { throw null; }
    }
    [System.Security.Permissions.SecurityPermissionAttribute(System.Security.Permissions.SecurityAction.Demand, Flags=System.Security.Permissions.SecurityPermissionFlag.UnmanagedCode)]
    public abstract partial class TemplatedControlDesigner : System.Web.UI.Design.ControlDesigner
    {
        public TemplatedControlDesigner() { }
        [System.ObsoleteAttribute("Use of this property is not recommended because template editing is handled in ControlDesigner. To support template editing expose template data in the TemplateGroups property and call SetViewFlags(ViewFlags.TemplateEditing, true). http://go.microsoft.com/fwlink/?linkid=14202")]
        public System.Web.UI.Design.ITemplateEditingFrame ActiveTemplateEditingFrame { get { throw null; } }
        public bool CanEnterTemplateMode { get { throw null; } }
        protected override bool DataBindingsEnabled { get { throw null; } }
        [System.ObsoleteAttribute("The recommended alternative is System.Web.UI.Design.ControlDesigner.InTemplateMode. http://go.microsoft.com/fwlink/?linkid=14202")]
        public new bool InTemplateMode { get { throw null; } }
        public override System.Web.UI.Design.TemplateGroupCollection TemplateGroups { get { throw null; } }
        [System.ObsoleteAttribute("Use of this method is not recommended because template editing is handled in ControlDesigner. To support template editing expose template data in the TemplateGroups property and call SetViewFlags(ViewFlags.TemplateEditing, true). http://go.microsoft.com/fwlink/?linkid=14202")]
        protected abstract System.Web.UI.Design.ITemplateEditingFrame CreateTemplateEditingFrame(System.Web.UI.Design.TemplateEditingVerb verb);
        [System.ObsoleteAttribute("Use of this method is not recommended because template editing is handled in ControlDesigner. To support template editing expose template data in the TemplateGroups property and call SetViewFlags(ViewFlags.TemplateEditing, true). http://go.microsoft.com/fwlink/?linkid=14202")]
        public void EnterTemplateMode(System.Web.UI.Design.ITemplateEditingFrame newTemplateEditingFrame) { }
        [System.ObsoleteAttribute("Use of this method is not recommended because template editing is handled in ControlDesigner. To support template editing expose template data in the TemplateGroups property and call SetViewFlags(ViewFlags.TemplateEditing, true). http://go.microsoft.com/fwlink/?linkid=14202")]
        public void ExitTemplateMode(bool fSwitchingTemplates, bool fNested, bool fSave) { }
        [System.ObsoleteAttribute("Use of this method is not recommended because template editing is handled in ControlDesigner. To support template editing expose template data in the TemplateGroups property and call SetViewFlags(ViewFlags.TemplateEditing, true). http://go.microsoft.com/fwlink/?linkid=14202")]
        protected abstract System.Web.UI.Design.TemplateEditingVerb[] GetCachedTemplateEditingVerbs();
        [System.ObsoleteAttribute("Use of this method is not recommended because template editing is handled in ControlDesigner. To support template editing expose template data in the TemplateGroups property and call SetViewFlags(ViewFlags.TemplateEditing, true). http://go.microsoft.com/fwlink/?linkid=14202")]
        public virtual string GetTemplateContainerDataItemProperty(string templateName) { throw null; }
        [System.ObsoleteAttribute("Use of this method is not recommended because template editing is handled in ControlDesigner. To support template editing expose template data in the TemplateGroups property and call SetViewFlags(ViewFlags.TemplateEditing, true). http://go.microsoft.com/fwlink/?linkid=14202")]
        public virtual System.Collections.IEnumerable GetTemplateContainerDataSource(string templateName) { throw null; }
        [System.ObsoleteAttribute("Use of this method is not recommended because template editing is handled in ControlDesigner. To support template editing expose template data in the TemplateGroups property and call SetViewFlags(ViewFlags.TemplateEditing, true). http://go.microsoft.com/fwlink/?linkid=14202")]
        public abstract string GetTemplateContent(System.Web.UI.Design.ITemplateEditingFrame editingFrame, string templateName, out bool allowEditing);
        [System.ObsoleteAttribute("Use of this method is not recommended because template editing is handled in ControlDesigner. To support template editing expose template data in the TemplateGroups property and call SetViewFlags(ViewFlags.TemplateEditing, true). http://go.microsoft.com/fwlink/?linkid=14202")]
        public System.Web.UI.Design.TemplateEditingVerb[] GetTemplateEditingVerbs() { throw null; }
        protected System.Web.UI.ITemplate GetTemplateFromText(string text) { throw null; }
        [System.ObsoleteAttribute("Use of this method is not recommended because template editing is handled in ControlDesigner. To support template editing expose template data in the TemplateGroups property and call SetViewFlags(ViewFlags.TemplateEditing, true). http://go.microsoft.com/fwlink/?linkid=14202")]
        public virtual System.Type GetTemplatePropertyParentType(string templateName) { throw null; }
        protected string GetTextFromTemplate(System.Web.UI.ITemplate template) { throw null; }
        public override void Initialize(System.ComponentModel.IComponent component) { }
        [System.ObsoleteAttribute("The recommended alternative is ControlDesigner.Tag. http://go.microsoft.com/fwlink/?linkid=14202")]
        protected override void OnBehaviorAttached() { }
        public override void OnComponentChanged(object sender, System.ComponentModel.Design.ComponentChangedEventArgs ce) { }
        public override void OnSetParent() { }
        protected virtual void OnTemplateModeChanged() { }
        protected void SaveActiveTemplateEditingFrame() { }
        [System.ObsoleteAttribute("Use of this method is not recommended because template editing is handled in ControlDesigner. To support template editing expose template data in the TemplateGroups property and call SetViewFlags(ViewFlags.TemplateEditing, true). http://go.microsoft.com/fwlink/?linkid=14202")]
        public abstract void SetTemplateContent(System.Web.UI.Design.ITemplateEditingFrame editingFrame, string templateName, string templateContent);
        public override void UpdateDesignTimeHtml() { }
    }
    public partial class TemplatedEditableDesignerRegion : System.Web.UI.Design.EditableDesignerRegion
    {
        public TemplatedEditableDesignerRegion(System.Web.UI.Design.TemplateDefinition templateDefinition) : base (default(System.Web.UI.Design.ControlDesigner), default(string)) { }
        public virtual bool IsSingleInstanceTemplate { get { throw null; } set { } }
        public override bool SupportsDataBinding { get { throw null; } set { } }
        public System.Web.UI.Design.TemplateDefinition TemplateDefinition { get { throw null; } }
    }
    public partial class TemplateDefinition : System.Web.UI.Design.DesignerObject
    {
        public TemplateDefinition(System.Web.UI.Design.ControlDesigner designer, string name, object templatedObject, string templatePropertyName) : base (default(System.Web.UI.Design.ControlDesigner), default(string)) { }
        public TemplateDefinition(System.Web.UI.Design.ControlDesigner designer, string name, object templatedObject, string templatePropertyName, bool serverControlsOnly) : base (default(System.Web.UI.Design.ControlDesigner), default(string)) { }
        public TemplateDefinition(System.Web.UI.Design.ControlDesigner designer, string name, object templatedObject, string templatePropertyName, System.Web.UI.WebControls.Style style) : base (default(System.Web.UI.Design.ControlDesigner), default(string)) { }
        public TemplateDefinition(System.Web.UI.Design.ControlDesigner designer, string name, object templatedObject, string templatePropertyName, System.Web.UI.WebControls.Style style, bool serverControlsOnly) : base (default(System.Web.UI.Design.ControlDesigner), default(string)) { }
        public virtual bool AllowEditing { get { throw null; } }
        public virtual string Content { get { throw null; } set { } }
        public bool ServerControlsOnly { get { throw null; } }
        public System.Web.UI.WebControls.Style Style { get { throw null; } }
        public bool SupportsDataBinding { get { throw null; } set { } }
        public object TemplatedObject { get { throw null; } }
        public string TemplatePropertyName { get { throw null; } }
    }
    [System.ObsoleteAttribute("Use of this type is not recommended because template editing is handled in ControlDesigner. To support template editing expose template data in the TemplateGroups property and call SetViewFlags(ViewFlags.TemplateEditing, true). http://go.microsoft.com/fwlink/?linkid=14202")]
    [System.Security.Permissions.SecurityPermissionAttribute(System.Security.Permissions.SecurityAction.Demand, Flags=System.Security.Permissions.SecurityPermissionFlag.UnmanagedCode)]
    public sealed partial class TemplateEditingService : System.IDisposable, System.Web.UI.Design.ITemplateEditingService
    {
        public TemplateEditingService(System.ComponentModel.Design.IDesignerHost designerHost) { }
        public bool SupportsNestedTemplateEditing { get { throw null; } }
        public System.Web.UI.Design.ITemplateEditingFrame CreateFrame(System.Web.UI.Design.TemplatedControlDesigner designer, string frameName, string[] templateNames) { throw null; }
        public System.Web.UI.Design.ITemplateEditingFrame CreateFrame(System.Web.UI.Design.TemplatedControlDesigner designer, string frameName, string[] templateNames, System.Web.UI.WebControls.Style controlStyle, System.Web.UI.WebControls.Style[] templateStyles) { throw null; }
        public void Dispose() { }
        ~TemplateEditingService() { }
        public string GetContainingTemplateName(System.Web.UI.Control control) { throw null; }
    }
    [System.ObsoleteAttribute("Use of this type is not recommended because template editing is handled in ControlDesigner. To support template editing expose template data in the TemplateGroups property and call SetViewFlags(ViewFlags.TemplateEditing, true). http://go.microsoft.com/fwlink/?linkid=14202")]
    [System.Security.Permissions.SecurityPermissionAttribute(System.Security.Permissions.SecurityAction.Demand, Flags=System.Security.Permissions.SecurityPermissionFlag.UnmanagedCode)]
    public partial class TemplateEditingVerb : System.ComponentModel.Design.DesignerVerb, System.IDisposable
    {
        public TemplateEditingVerb(string text, int index) : base (default(string), default(System.EventHandler)) { }
        public TemplateEditingVerb(string text, int index, System.Web.UI.Design.TemplatedControlDesigner designer) : base (default(string), default(System.EventHandler)) { }
        public int Index { get { throw null; } }
        public void Dispose() { }
        protected virtual void Dispose(bool disposing) { }
        ~TemplateEditingVerb() { }
    }
    public partial class TemplateGroup
    {
        public TemplateGroup(string groupName) { }
        public TemplateGroup(string groupName, System.Web.UI.WebControls.Style groupStyle) { }
        public string GroupName { get { throw null; } }
        public System.Web.UI.WebControls.Style GroupStyle { get { throw null; } }
        public bool IsEmpty { get { throw null; } }
        public System.Web.UI.Design.TemplateDefinition[] Templates { get { throw null; } }
        public void AddTemplateDefinition(System.Web.UI.Design.TemplateDefinition templateDefinition) { }
    }
    public sealed partial class TemplateGroupCollection : System.Collections.ICollection, System.Collections.IEnumerable, System.Collections.IList
    {
        public TemplateGroupCollection() { }
        public int Count { get { throw null; } }
        public System.Web.UI.Design.TemplateGroup this[int index] { get { throw null; } set { } }
        int System.Collections.ICollection.Count { get { throw null; } }
        bool System.Collections.ICollection.IsSynchronized { get { throw null; } }
        object System.Collections.ICollection.SyncRoot { get { throw null; } }
        bool System.Collections.IList.IsFixedSize { get { throw null; } }
        bool System.Collections.IList.IsReadOnly { get { throw null; } }
        object System.Collections.IList.this[int index] { get { throw null; } set { } }
        public int Add(System.Web.UI.Design.TemplateGroup group) { throw null; }
        public void AddRange(System.Web.UI.Design.TemplateGroupCollection groups) { }
        public void Clear() { }
        public bool Contains(System.Web.UI.Design.TemplateGroup group) { throw null; }
        public void CopyTo(System.Web.UI.Design.TemplateGroup[] array, int index) { }
        public int IndexOf(System.Web.UI.Design.TemplateGroup group) { throw null; }
        public void Insert(int index, System.Web.UI.Design.TemplateGroup group) { }
        public void Remove(System.Web.UI.Design.TemplateGroup group) { }
        public void RemoveAt(int index) { }
        void System.Collections.ICollection.CopyTo(System.Array array, int index) { }
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { throw null; }
        int System.Collections.IList.Add(object o) { throw null; }
        void System.Collections.IList.Clear() { }
        bool System.Collections.IList.Contains(object o) { throw null; }
        int System.Collections.IList.IndexOf(object o) { throw null; }
        void System.Collections.IList.Insert(int index, object o) { }
        void System.Collections.IList.Remove(object o) { }
        void System.Collections.IList.RemoveAt(int index) { }
    }
    public partial class TemplateModeChangedEventArgs : System.EventArgs
    {
        public TemplateModeChangedEventArgs(System.Web.UI.Design.TemplateGroup newTemplateGroup) { }
        public System.Web.UI.Design.TemplateGroup NewTemplateGroup { get { throw null; } }
    }
    [System.Security.Permissions.SecurityPermissionAttribute(System.Security.Permissions.SecurityAction.Demand, Flags=System.Security.Permissions.SecurityPermissionFlag.UnmanagedCode)]
    public partial class TextControlDesigner : System.Web.UI.Design.ControlDesigner
    {
        public TextControlDesigner() { }
        public override string GetDesignTimeHtml() { throw null; }
    }
    [System.Security.Permissions.SecurityPermissionAttribute(System.Security.Permissions.SecurityAction.Demand, Flags=System.Security.Permissions.SecurityPermissionFlag.UnmanagedCode)]
    public partial class TextDataBindingHandler : System.Web.UI.Design.DataBindingHandler
    {
        public TextDataBindingHandler() { }
        public override void DataBindControl(System.ComponentModel.Design.IDesignerHost designerHost, System.Web.UI.Control control) { }
    }
    public delegate bool TransactedChangeCallback(object context);
    [System.Security.Permissions.SecurityPermissionAttribute(System.Security.Permissions.SecurityAction.Demand, Flags=System.Security.Permissions.SecurityPermissionFlag.UnmanagedCode)]
    public sealed partial class TypeSchema : System.Web.UI.Design.IDataSourceSchema
    {
        public TypeSchema(System.Type type) { }
        public System.Web.UI.Design.IDataSourceViewSchema[] GetViews() { throw null; }
    }
    [System.Security.Permissions.SecurityPermissionAttribute(System.Security.Permissions.SecurityAction.Demand, Flags=System.Security.Permissions.SecurityPermissionFlag.UnmanagedCode)]
    public sealed partial class UrlBuilder
    {
        internal UrlBuilder() { }
        public static string BuildUrl(System.ComponentModel.IComponent component, System.Windows.Forms.Control owner, string initialUrl, string caption, string filter) { throw null; }
        public static string BuildUrl(System.ComponentModel.IComponent component, System.Windows.Forms.Control owner, string initialUrl, string caption, string filter, System.Web.UI.Design.UrlBuilderOptions options) { throw null; }
        public static string BuildUrl(System.IServiceProvider serviceProvider, System.Windows.Forms.Control owner, string initialUrl, string caption, string filter, System.Web.UI.Design.UrlBuilderOptions options) { throw null; }
    }
    [System.FlagsAttribute]
    public enum UrlBuilderOptions
    {
        NoAbsolute = 1,
        None = 0,
    }
    [System.Security.Permissions.SecurityPermissionAttribute(System.Security.Permissions.SecurityAction.Demand, Flags=System.Security.Permissions.SecurityPermissionFlag.UnmanagedCode)]
    public partial class UrlEditor : System.Drawing.Design.UITypeEditor
    {
        public UrlEditor() { }
        protected virtual string Caption { get { throw null; } }
        protected virtual string Filter { get { throw null; } }
        protected virtual System.Web.UI.Design.UrlBuilderOptions Options { get { throw null; } }
        public override object EditValue(System.ComponentModel.ITypeDescriptorContext context, System.IServiceProvider provider, object value) { throw null; }
        public override System.Drawing.Design.UITypeEditorEditStyle GetEditStyle(System.ComponentModel.ITypeDescriptorContext context) { throw null; }
    }
    [System.Security.Permissions.SecurityPermissionAttribute(System.Security.Permissions.SecurityAction.Demand, Flags=System.Security.Permissions.SecurityPermissionFlag.UnmanagedCode)]
    public partial class UserControlDesigner : System.Web.UI.Design.ControlDesigner
    {
        public UserControlDesigner() { }
        public override System.ComponentModel.Design.DesignerActionListCollection ActionLists { get { throw null; } }
        public override bool AllowResize { get { throw null; } }
        public override string GetDesignTimeHtml() { throw null; }
    }
    [System.Security.Permissions.SecurityPermissionAttribute(System.Security.Permissions.SecurityAction.Demand, Flags=System.Security.Permissions.SecurityPermissionFlag.UnmanagedCode)]
    public partial class UserControlFileEditor : System.Web.UI.Design.UrlEditor
    {
        public UserControlFileEditor() { }
        protected override string Caption { get { throw null; } }
        protected override string Filter { get { throw null; } }
    }
    public sealed partial class ViewEvent
    {
        internal ViewEvent() { }
        public static readonly System.Web.UI.Design.ViewEvent Click;
        public static readonly System.Web.UI.Design.ViewEvent Paint;
        public static readonly System.Web.UI.Design.ViewEvent TemplateModeChanged;
    }
    public partial class ViewEventArgs : System.EventArgs
    {
        public ViewEventArgs(System.Web.UI.Design.ViewEvent eventType, System.Web.UI.Design.DesignerRegion region, System.EventArgs eventArgs) { }
        public System.EventArgs EventArgs { get { throw null; } }
        public System.Web.UI.Design.ViewEvent EventType { get { throw null; } }
        public System.Web.UI.Design.DesignerRegion Region { get { throw null; } }
    }
    public delegate void ViewEventHandler(object sender, System.Web.UI.Design.ViewEventArgs e);
    [System.FlagsAttribute]
    public enum ViewFlags
    {
        CustomPaint = 1,
        DesignTimeHtmlRequiresLoadComplete = 2,
        TemplateEditing = 4,
    }
    public partial class ViewRendering
    {
        public ViewRendering(string content, System.Web.UI.Design.DesignerRegionCollection regions) { }
        public ViewRendering(string content, System.Web.UI.Design.DesignerRegionCollection regions, bool visible) { }
        public string Content { get { throw null; } }
        public System.Web.UI.Design.DesignerRegionCollection Regions { get { throw null; } }
        public bool Visible { get { throw null; } }
    }
    [System.Security.Permissions.SecurityPermissionAttribute(System.Security.Permissions.SecurityAction.Demand, Flags=System.Security.Permissions.SecurityPermissionFlag.UnmanagedCode)]
    [System.SerializableAttribute]
    public partial class WebControlToolboxItem : System.Drawing.Design.ToolboxItem
    {
        public WebControlToolboxItem() { }
        protected WebControlToolboxItem(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
        public WebControlToolboxItem(System.Type type) { }
        protected override System.ComponentModel.IComponent[] CreateComponentsCore(System.ComponentModel.Design.IDesignerHost host) { throw null; }
        protected override void Deserialize(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
        public object GetToolAttributeValue(System.ComponentModel.Design.IDesignerHost host, System.Type attributeType) { throw null; }
        public string GetToolHtml(System.ComponentModel.Design.IDesignerHost host) { throw null; }
        public System.Type GetToolType(System.ComponentModel.Design.IDesignerHost host) { throw null; }
        public override void Initialize(System.Type type) { }
        protected override void Serialize(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
    }
    public partial class WebFormsDesignerActionService : System.ComponentModel.Design.DesignerActionService
    {
        public WebFormsDesignerActionService(System.IServiceProvider serviceProvider) : base (default(System.IServiceProvider)) { }
        protected override void GetComponentDesignerActions(System.ComponentModel.IComponent component, System.ComponentModel.Design.DesignerActionListCollection actionLists) { }
    }
    public abstract partial class WebFormsReferenceManager
    {
        protected WebFormsReferenceManager() { }
        public abstract System.Collections.ICollection GetRegisterDirectives();
        public abstract string GetTagPrefix(System.Type objectType);
        public abstract System.Type GetType(string tagPrefix, string tagName);
        public abstract string GetUserControlPath(string tagPrefix, string tagName);
        public abstract string RegisterTagPrefix(System.Type objectType);
    }
    public abstract partial class WebFormsRootDesigner : System.ComponentModel.Design.IDesigner, System.ComponentModel.Design.IDesignerFilter, System.ComponentModel.Design.IRootDesigner, System.IDisposable
    {
        protected WebFormsRootDesigner() { }
        public virtual System.ComponentModel.IComponent Component { get { throw null; } set { } }
        public System.Globalization.CultureInfo CurrentCulture { get { throw null; } }
        public abstract string DocumentUrl { get; }
        public abstract bool IsDesignerViewLocked { get; }
        public abstract bool IsLoading { get; }
        public abstract System.Web.UI.Design.WebFormsReferenceManager ReferenceManager { get; }
        protected System.ComponentModel.Design.ViewTechnology[] SupportedTechnologies { get { throw null; } }
        System.ComponentModel.Design.DesignerVerbCollection System.ComponentModel.Design.IDesigner.Verbs { get { throw null; } }
        System.ComponentModel.Design.ViewTechnology[] System.ComponentModel.Design.IRootDesigner.SupportedTechnologies { get { throw null; } }
        protected System.ComponentModel.Design.DesignerVerbCollection Verbs { get { throw null; } }
        public event System.EventHandler LoadComplete { add { } remove { } }
        public abstract void AddClientScriptToDocument(System.Web.UI.Design.ClientScriptItem scriptItem);
        public abstract string AddControlToDocument(System.Web.UI.Control newControl, System.Web.UI.Control referenceControl, System.Web.UI.Design.ControlLocation location);
        protected virtual System.ComponentModel.Design.DesignerActionService CreateDesignerActionService(System.IServiceProvider serviceProvider) { throw null; }
        protected virtual System.Web.UI.IUrlResolutionService CreateUrlResolutionService() { throw null; }
        protected virtual void Dispose(bool disposing) { }
        ~WebFormsRootDesigner() { }
        public virtual string GenerateEmptyDesignTimeHtml(System.Web.UI.Control control) { throw null; }
        public virtual string GenerateErrorDesignTimeHtml(System.Web.UI.Control control, System.Exception e, string errorMessage) { throw null; }
        public abstract System.Web.UI.Design.ClientScriptItemCollection GetClientScriptsInDocument();
        protected internal abstract void GetControlViewAndTag(System.Web.UI.Control control, out System.Web.UI.Design.IControlDesignerView view, out System.Web.UI.Design.IControlDesignerTag tag);
        protected internal virtual object GetService(System.Type serviceType) { throw null; }
        protected object GetView(System.ComponentModel.Design.ViewTechnology viewTechnology) { throw null; }
        public virtual void Initialize(System.ComponentModel.IComponent component) { }
        protected virtual void OnLoadComplete(System.EventArgs e) { }
        protected virtual void PostFilterAttributes(System.Collections.IDictionary attributes) { }
        protected virtual void PostFilterEvents(System.Collections.IDictionary events) { }
        protected virtual void PostFilterProperties(System.Collections.IDictionary properties) { }
        protected virtual void PreFilterAttributes(System.Collections.IDictionary attributes) { }
        protected virtual void PreFilterEvents(System.Collections.IDictionary events) { }
        protected virtual void PreFilterProperties(System.Collections.IDictionary properties) { }
        public abstract void RemoveClientScriptFromDocument(string clientScriptId);
        public abstract void RemoveControlFromDocument(System.Web.UI.Control control);
        public string ResolveUrl(string relativeUrl) { throw null; }
        public virtual void SetControlID(System.Web.UI.Control control, string id) { }
        void System.ComponentModel.Design.IDesigner.DoDefaultAction() { }
        void System.ComponentModel.Design.IDesignerFilter.PostFilterAttributes(System.Collections.IDictionary attributes) { }
        void System.ComponentModel.Design.IDesignerFilter.PostFilterEvents(System.Collections.IDictionary events) { }
        void System.ComponentModel.Design.IDesignerFilter.PostFilterProperties(System.Collections.IDictionary properties) { }
        void System.ComponentModel.Design.IDesignerFilter.PreFilterAttributes(System.Collections.IDictionary attributes) { }
        void System.ComponentModel.Design.IDesignerFilter.PreFilterEvents(System.Collections.IDictionary events) { }
        void System.ComponentModel.Design.IDesignerFilter.PreFilterProperties(System.Collections.IDictionary properties) { }
        object System.ComponentModel.Design.IRootDesigner.GetView(System.ComponentModel.Design.ViewTechnology viewTechnology) { throw null; }
        void System.IDisposable.Dispose() { }
    }
    [System.Security.Permissions.SecurityPermissionAttribute(System.Security.Permissions.SecurityAction.Demand, Flags=System.Security.Permissions.SecurityPermissionFlag.UnmanagedCode)]
    public partial class XmlDataFileEditor : System.Web.UI.Design.UrlEditor
    {
        public XmlDataFileEditor() { }
        protected override string Caption { get { throw null; } }
        protected override string Filter { get { throw null; } }
    }
    [System.Security.Permissions.SecurityPermissionAttribute(System.Security.Permissions.SecurityAction.Demand, Flags=System.Security.Permissions.SecurityPermissionFlag.UnmanagedCode)]
    public sealed partial class XmlDocumentSchema : System.Web.UI.Design.IDataSourceSchema
    {
        public XmlDocumentSchema(System.Xml.XmlDocument xmlDocument, string xPath) { }
        public System.Web.UI.Design.IDataSourceViewSchema[] GetViews() { throw null; }
    }
    [System.Security.Permissions.SecurityPermissionAttribute(System.Security.Permissions.SecurityAction.Demand, Flags=System.Security.Permissions.SecurityPermissionFlag.UnmanagedCode)]
    public partial class XmlFileEditor : System.Drawing.Design.UITypeEditor
    {
        public XmlFileEditor() { }
        public override object EditValue(System.ComponentModel.ITypeDescriptorContext context, System.IServiceProvider provider, object value) { throw null; }
        public override System.Drawing.Design.UITypeEditorEditStyle GetEditStyle(System.ComponentModel.ITypeDescriptorContext context) { throw null; }
    }
    [System.Security.Permissions.SecurityPermissionAttribute(System.Security.Permissions.SecurityAction.Demand, Flags=System.Security.Permissions.SecurityPermissionFlag.UnmanagedCode)]
    public partial class XmlUrlEditor : System.Web.UI.Design.UrlEditor
    {
        public XmlUrlEditor() { }
        protected override string Caption { get { throw null; } }
        protected override string Filter { get { throw null; } }
        protected override System.Web.UI.Design.UrlBuilderOptions Options { get { throw null; } }
    }
    [System.Security.Permissions.SecurityPermissionAttribute(System.Security.Permissions.SecurityAction.Demand, Flags=System.Security.Permissions.SecurityPermissionFlag.UnmanagedCode)]
    public partial class XsdSchemaFileEditor : System.Web.UI.Design.UrlEditor
    {
        public XsdSchemaFileEditor() { }
        protected override string Caption { get { throw null; } }
        protected override string Filter { get { throw null; } }
    }
    [System.Security.Permissions.SecurityPermissionAttribute(System.Security.Permissions.SecurityAction.Demand, Flags=System.Security.Permissions.SecurityPermissionFlag.UnmanagedCode)]
    public partial class XslTransformFileEditor : System.Web.UI.Design.UrlEditor
    {
        public XslTransformFileEditor() { }
        protected override string Caption { get { throw null; } }
        protected override string Filter { get { throw null; } }
    }
    [System.Security.Permissions.SecurityPermissionAttribute(System.Security.Permissions.SecurityAction.Demand, Flags=System.Security.Permissions.SecurityPermissionFlag.UnmanagedCode)]
    public partial class XslUrlEditor : System.Web.UI.Design.UrlEditor
    {
        public XslUrlEditor() { }
        protected override string Caption { get { throw null; } }
        protected override string Filter { get { throw null; } }
        protected override System.Web.UI.Design.UrlBuilderOptions Options { get { throw null; } }
    }
}
namespace System.Web.UI.Design.Directives
{
    [System.AttributeUsageAttribute(System.AttributeTargets.All, AllowMultiple=false, Inherited=true)]
    public sealed partial class DirectiveAttribute : System.Attribute
    {
        public DirectiveAttribute() { }
        public bool AllowedOnMobilePages { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public string BuilderType { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public bool Culture { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public string RenameType { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public bool ServerLanguageExtensions { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public bool ServerLanguageNames { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    }
    public static partial class DirectiveRegistry
    {
        public static System.Collections.ObjectModel.ReadOnlyCollection<System.Type> GetDirectives(System.Version frameworkVersion, string extension) { throw null; }
    }
    [System.AttributeUsageAttribute(System.AttributeTargets.Class)]
    public sealed partial class SchemaElementNameAttribute : System.Attribute
    {
        public SchemaElementNameAttribute(string value) { }
        public string Value { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
    }
}
namespace System.Web.UI.Design.WebControls
{
    [System.Security.Permissions.SecurityPermissionAttribute(System.Security.Permissions.SecurityAction.Demand, Flags=System.Security.Permissions.SecurityPermissionFlag.UnmanagedCode)]
    public partial class AccessDataSourceDesigner : System.Web.UI.Design.WebControls.SqlDataSourceDesigner
    {
        public AccessDataSourceDesigner() { }
        public string DataFile { get { throw null; } set { } }
        protected override string GetConnectionString() { throw null; }
        protected override void PreFilterProperties(System.Collections.IDictionary properties) { }
    }
    [System.Web.UI.Design.SupportsPreviewControlAttribute(true)]
    [System.Security.Permissions.SecurityPermissionAttribute(System.Security.Permissions.SecurityAction.Demand, Flags=System.Security.Permissions.SecurityPermissionFlag.UnmanagedCode)]
    public partial class AdRotatorDesigner : System.Web.UI.Design.WebControls.DataBoundControlDesigner
    {
        public AdRotatorDesigner() { }
        public override string GetDesignTimeHtml() { throw null; }
    }
    public abstract partial class BaseDataBoundControlDesigner : System.Web.UI.Design.ControlDesigner
    {
        protected BaseDataBoundControlDesigner() { }
        public string DataSource { get { throw null; } set { } }
        public string DataSourceID { get { throw null; } set { } }
        protected abstract bool ConnectToDataSource();
        protected abstract void CreateDataSource();
        protected abstract void DataBind(System.Web.UI.WebControls.BaseDataBoundControl dataBoundControl);
        protected abstract void DisconnectFromDataSource();
        protected override void Dispose(bool disposing) { }
        public override string GetDesignTimeHtml() { throw null; }
        protected override string GetEmptyDesignTimeHtml() { throw null; }
        protected override string GetErrorDesignTimeHtml(System.Exception e) { throw null; }
        public override void Initialize(System.ComponentModel.IComponent component) { }
        protected virtual void OnDataSourceChanged(bool forceUpdateView) { }
        protected virtual void OnSchemaRefreshed() { }
        protected override void PreFilterProperties(System.Collections.IDictionary properties) { }
        public static System.Windows.Forms.DialogResult ShowCreateDataSourceDialog(System.Web.UI.Design.ControlDesigner controlDesigner, System.Type dataSourceType, bool configure, out string dataSourceID) { throw null; }
    }
    [System.Security.Permissions.SecurityPermissionAttribute(System.Security.Permissions.SecurityAction.Demand, Flags=System.Security.Permissions.SecurityPermissionFlag.UnmanagedCode)]
    public abstract partial class BaseDataListComponentEditor : System.Windows.Forms.Design.WindowsFormsComponentEditor
    {
        public BaseDataListComponentEditor(int initialPage) { }
        public override bool EditComponent(System.ComponentModel.ITypeDescriptorContext context, object obj, System.Windows.Forms.IWin32Window parent) { throw null; }
        protected override int GetInitialComponentEditorPageIndex() { throw null; }
    }
    [System.Security.Permissions.SecurityPermissionAttribute(System.Security.Permissions.SecurityAction.Demand, Flags=System.Security.Permissions.SecurityPermissionFlag.UnmanagedCode)]
    public abstract partial class BaseDataListDesigner : System.Web.UI.Design.TemplatedControlDesigner, System.Web.UI.Design.IDataBindingSchemaProvider, System.Web.UI.Design.IDataSourceProvider
    {
        protected BaseDataListDesigner() { }
        public override System.ComponentModel.Design.DesignerActionListCollection ActionLists { get { throw null; } }
        public string DataKeyField { get { throw null; } set { } }
        public string DataMember { get { throw null; } set { } }
        public string DataSource { get { throw null; } set { } }
        public System.Web.UI.Design.IDataSourceDesigner DataSourceDesigner { get { throw null; } }
        public string DataSourceID { get { throw null; } set { } }
        public System.Web.UI.Design.DesignerDataSourceView DesignerView { get { throw null; } }
        bool System.Web.UI.Design.IDataBindingSchemaProvider.CanRefreshSchema { get { throw null; } }
        System.Web.UI.Design.IDataSourceViewSchema System.Web.UI.Design.IDataBindingSchemaProvider.Schema { get { throw null; } }
        protected override void Dispose(bool disposing) { }
        protected System.Collections.IEnumerable GetDesignTimeDataSource(System.Collections.IEnumerable selectedDataSource, int minimumRows, out bool dummyDataSource) { throw null; }
        protected System.Collections.IEnumerable GetDesignTimeDataSource(int minimumRows, out bool dummyDataSource) { throw null; }
        public System.Collections.IEnumerable GetResolvedSelectedDataSource() { throw null; }
        public object GetSelectedDataSource() { throw null; }
        [System.ObsoleteAttribute("Use of this method is not recommended because template editing is handled in ControlDesigner. To support template editing expose template data in the TemplateGroups property and call SetViewFlags(ViewFlags.TemplateEditing, true). http://go.microsoft.com/fwlink/?linkid=14202")]
        public override System.Collections.IEnumerable GetTemplateContainerDataSource(string templateName) { throw null; }
        public override void Initialize(System.ComponentModel.IComponent component) { }
        protected internal void InvokePropertyBuilder(int initialPage) { }
        [System.ObsoleteAttribute("Use of this method is not recommended because the AutoFormat dialog is launched by the designer host. The list of available AutoFormats is exposed on the ControlDesigner in the AutoFormats property. http://go.microsoft.com/fwlink/?linkid=14202")]
        protected void OnAutoFormat(object sender, System.EventArgs e) { }
        public override void OnAutoFormatApplied(System.Web.UI.Design.DesignerAutoFormat appliedAutoFormat) { }
        public override void OnComponentChanged(object sender, System.ComponentModel.Design.ComponentChangedEventArgs e) { }
        protected internal virtual void OnDataSourceChanged() { }
        protected void OnPropertyBuilder(object sender, System.EventArgs e) { }
        protected virtual void OnSchemaRefreshed() { }
        protected internal void OnStylesChanged() { }
        protected abstract void OnTemplateEditingVerbsChanged();
        protected override void PreFilterProperties(System.Collections.IDictionary properties) { }
        void System.Web.UI.Design.IDataBindingSchemaProvider.RefreshSchema(bool preferSilent) { }
    }
    [System.Web.UI.Design.SupportsPreviewControlAttribute(true)]
    [System.Security.Permissions.SecurityPermissionAttribute(System.Security.Permissions.SecurityAction.Demand, Flags=System.Security.Permissions.SecurityPermissionFlag.UnmanagedCode)]
    public partial class BaseValidatorDesigner : System.Web.UI.Design.WebControls.PreviewControlDesigner
    {
        public BaseValidatorDesigner() { }
        protected override System.Web.UI.Control CreateViewControl() { throw null; }
        public override string GetDesignTimeHtml() { throw null; }
        protected override void PreFilterProperties(System.Collections.IDictionary properties) { }
    }
    public partial class BulletedListDesigner : System.Web.UI.Design.WebControls.ListControlDesigner
    {
        public BulletedListDesigner() { }
        protected override bool UsePreviewControl { get { throw null; } }
        protected override void PostFilterEvents(System.Collections.IDictionary events) { }
    }
    [System.Web.UI.Design.SupportsPreviewControlAttribute(true)]
    [System.Security.Permissions.SecurityPermissionAttribute(System.Security.Permissions.SecurityAction.Demand, Flags=System.Security.Permissions.SecurityPermissionFlag.UnmanagedCode)]
    public partial class ButtonDesigner : System.Web.UI.Design.ControlDesigner
    {
        public ButtonDesigner() { }
        public override string GetDesignTimeHtml() { throw null; }
    }
    [System.ComponentModel.ToolboxItemAttribute(false)]
    [System.ObsoleteAttribute("Use of this type is not recommended because the AutoFormat dialog is launched by the designer host. The list of available AutoFormats is exposed on the ControlDesigner in the AutoFormats property. http://go.microsoft.com/fwlink/?linkid=14202")]
    [System.Security.Permissions.SecurityPermissionAttribute(System.Security.Permissions.SecurityAction.Demand, Flags=System.Security.Permissions.SecurityPermissionFlag.UnmanagedCode)]
    public partial class CalendarAutoFormatDialog : System.Windows.Forms.Form
    {
        public CalendarAutoFormatDialog(System.Web.UI.WebControls.Calendar calendar) { }
        protected void DoDelayLoadActions() { }
        protected void OnActivated(object source, System.EventArgs e) { }
        protected void OnOKClicked(object source, System.EventArgs e) { }
        protected void OnSelChangedScheme(object source, System.EventArgs e) { }
        protected void SaveComponent() { }
    }
    [System.Web.UI.Design.SupportsPreviewControlAttribute(true)]
    [System.Security.Permissions.SecurityPermissionAttribute(System.Security.Permissions.SecurityAction.Demand, Flags=System.Security.Permissions.SecurityPermissionFlag.UnmanagedCode)]
    public partial class CalendarDesigner : System.Web.UI.Design.ControlDesigner
    {
        public CalendarDesigner() { }
        public override System.Web.UI.Design.DesignerAutoFormatCollection AutoFormats { get { throw null; } }
        public override void Initialize(System.ComponentModel.IComponent component) { }
        protected void OnAutoFormat(object sender, System.EventArgs e) { }
    }
    [System.Security.Permissions.SecurityPermissionAttribute(System.Security.Permissions.SecurityAction.Demand, Flags=System.Security.Permissions.SecurityPermissionFlag.UnmanagedCode)]
    public partial class ChangePasswordDesigner : System.Web.UI.Design.ControlDesigner
    {
        public ChangePasswordDesigner() { }
        public override System.ComponentModel.Design.DesignerActionListCollection ActionLists { get { throw null; } }
        public override bool AllowResize { get { throw null; } }
        public override System.Web.UI.Design.DesignerAutoFormatCollection AutoFormats { get { throw null; } }
        public bool RenderOuterTable { get { throw null; } set { } }
        public override System.Web.UI.Design.TemplateGroupCollection TemplateGroups { get { throw null; } }
        protected override bool UsePreviewControl { get { throw null; } }
        public override string GetDesignTimeHtml() { throw null; }
        public override string GetDesignTimeHtml(System.Web.UI.Design.DesignerRegionCollection regions) { throw null; }
        public override string GetEditableDesignerRegionContent(System.Web.UI.Design.EditableDesignerRegion region) { throw null; }
        protected override string GetErrorDesignTimeHtml(System.Exception e) { throw null; }
        public override void Initialize(System.ComponentModel.IComponent component) { }
        protected override void PreFilterProperties(System.Collections.IDictionary properties) { }
        public override void SetEditableDesignerRegionContent(System.Web.UI.Design.EditableDesignerRegion region, string content) { }
    }
    [System.Web.UI.Design.SupportsPreviewControlAttribute(true)]
    [System.Security.Permissions.SecurityPermissionAttribute(System.Security.Permissions.SecurityAction.Demand, Flags=System.Security.Permissions.SecurityPermissionFlag.UnmanagedCode)]
    public partial class CheckBoxDesigner : System.Web.UI.Design.ControlDesigner
    {
        public CheckBoxDesigner() { }
        public override string GetDesignTimeHtml() { throw null; }
    }
    [System.Security.Permissions.SecurityPermissionAttribute(System.Security.Permissions.SecurityAction.Demand, Flags=System.Security.Permissions.SecurityPermissionFlag.UnmanagedCode)]
    public partial class CompositeControlDesigner : System.Web.UI.Design.ControlDesigner
    {
        public CompositeControlDesigner() { }
        protected virtual void CreateChildControls() { }
        public override string GetDesignTimeHtml() { throw null; }
        public override void Initialize(System.ComponentModel.IComponent component) { }
    }
    [System.Security.Permissions.SecurityPermissionAttribute(System.Security.Permissions.SecurityAction.Demand, Flags=System.Security.Permissions.SecurityPermissionFlag.UnmanagedCode)]
    public partial class ContentDesigner : System.Web.UI.Design.ControlDesigner
    {
        public ContentDesigner() { }
        public override System.ComponentModel.Design.DesignerActionListCollection ActionLists { get { throw null; } }
        public override bool AllowResize { get { throw null; } }
        public override string GetDesignTimeHtml(System.Web.UI.Design.DesignerRegionCollection regions) { throw null; }
        public override string GetEditableDesignerRegionContent(System.Web.UI.Design.EditableDesignerRegion region) { throw null; }
        public override string GetPersistenceContent() { throw null; }
        protected override void PostFilterProperties(System.Collections.IDictionary properties) { }
        protected override void PreFilterEvents(System.Collections.IDictionary events) { }
        public override void SetEditableDesignerRegionContent(System.Web.UI.Design.EditableDesignerRegion region, string content) { }
    }
    [System.Security.Permissions.SecurityPermissionAttribute(System.Security.Permissions.SecurityAction.Demand, Flags=System.Security.Permissions.SecurityPermissionFlag.UnmanagedCode)]
    public partial class ContentPlaceHolderDesigner : System.Web.UI.Design.ControlDesigner
    {
        public ContentPlaceHolderDesigner() { }
        public override bool AllowResize { get { throw null; } }
        public override string GetDesignTimeHtml() { throw null; }
        public override string GetDesignTimeHtml(System.Web.UI.Design.DesignerRegionCollection regions) { throw null; }
        public override string GetEditableDesignerRegionContent(System.Web.UI.Design.EditableDesignerRegion region) { throw null; }
        public override string GetPersistenceContent() { throw null; }
        public override void SetEditableDesignerRegionContent(System.Web.UI.Design.EditableDesignerRegion region, string content) { }
    }
    [System.Security.Permissions.SecurityPermissionAttribute(System.Security.Permissions.SecurityAction.Demand, Flags=System.Security.Permissions.SecurityPermissionFlag.UnmanagedCode)]
    public partial class CreateUserWizardDesigner : System.Web.UI.Design.WebControls.WizardDesigner
    {
        public CreateUserWizardDesigner() { }
        public override System.ComponentModel.Design.DesignerActionListCollection ActionLists { get { throw null; } }
        public override System.Web.UI.Design.DesignerAutoFormatCollection AutoFormats { get { throw null; } }
        protected override bool UsePreviewControl { get { throw null; } }
        protected override void AddDesignerRegions(System.Web.UI.Design.DesignerRegionCollection regions) { }
        protected override void ConvertToCustomNavigationTemplate() { }
        protected override string GetErrorDesignTimeHtml(System.Exception e) { throw null; }
        public override void Initialize(System.ComponentModel.IComponent component) { }
        protected override void PreFilterProperties(System.Collections.IDictionary properties) { }
    }
    [System.Security.Permissions.SecurityPermissionAttribute(System.Security.Permissions.SecurityAction.Demand, Flags=System.Security.Permissions.SecurityPermissionFlag.UnmanagedCode)]
    public partial class CreateUserWizardStepCollectionEditor : System.Web.UI.Design.WebControls.WizardStepCollectionEditor
    {
        public CreateUserWizardStepCollectionEditor(System.Type type) : base (default(System.Type)) { }
        protected override string HelpTopic { get { throw null; } }
        protected override bool CanRemoveInstance(object value) { throw null; }
        protected override System.ComponentModel.Design.CollectionEditor.CollectionForm CreateCollectionForm() { throw null; }
    }
    public partial class DataBoundControlDesigner : System.Web.UI.Design.WebControls.BaseDataBoundControlDesigner, System.Web.UI.Design.IDataBindingSchemaProvider, System.Web.UI.Design.IDataSourceProvider
    {
        public DataBoundControlDesigner() { }
        public override System.ComponentModel.Design.DesignerActionListCollection ActionLists { get { throw null; } }
        public string DataMember { get { throw null; } set { } }
        public System.Web.UI.Design.IDataSourceDesigner DataSourceDesigner { get { throw null; } }
        public System.Web.UI.Design.DesignerDataSourceView DesignerView { get { throw null; } }
        protected virtual int SampleRowCount { get { throw null; } }
        bool System.Web.UI.Design.IDataBindingSchemaProvider.CanRefreshSchema { get { throw null; } }
        System.Web.UI.Design.IDataSourceViewSchema System.Web.UI.Design.IDataBindingSchemaProvider.Schema { get { throw null; } }
        protected virtual bool UseDataSourcePickerActionList { get { throw null; } }
        protected override bool ConnectToDataSource() { throw null; }
        protected override void CreateDataSource() { }
        protected override void DataBind(System.Web.UI.WebControls.BaseDataBoundControl dataBoundControl) { }
        protected override void DisconnectFromDataSource() { }
        protected override void Dispose(bool disposing) { }
        protected virtual System.Collections.IEnumerable GetDesignTimeDataSource() { throw null; }
        protected virtual System.Collections.IEnumerable GetSampleDataSource() { throw null; }
        protected override void PreFilterProperties(System.Collections.IDictionary properties) { }
        void System.Web.UI.Design.IDataBindingSchemaProvider.RefreshSchema(bool preferSilent) { }
        System.Collections.IEnumerable System.Web.UI.Design.IDataSourceProvider.GetResolvedSelectedDataSource() { throw null; }
        object System.Web.UI.Design.IDataSourceProvider.GetSelectedDataSource() { throw null; }
    }
    public abstract partial class DataControlFieldDesigner
    {
        protected DataControlFieldDesigner() { }
        public abstract string DefaultNodeText { get; }
        protected System.IServiceProvider ServiceProvider { get { throw null; } }
        public abstract bool UsesSchema { get; }
        public abstract System.Web.UI.WebControls.DataControlField CreateField();
        public abstract System.Web.UI.WebControls.DataControlField CreateField(System.Web.UI.Design.IDataSourceFieldSchema fieldSchema);
        public abstract System.Web.UI.WebControls.TemplateField CreateTemplateField(System.Web.UI.WebControls.DataControlField dataControlField, System.Web.UI.WebControls.DataBoundControl dataBoundControl);
        protected string GetNewDataSourceName(System.Type controlType, System.Web.UI.WebControls.DataBoundControlMode mode) { throw null; }
        public abstract string GetNodeText(System.Web.UI.WebControls.DataControlField dataControlField);
        protected object GetService(System.Type serviceType) { throw null; }
        protected System.Web.UI.ITemplate GetTemplate(System.Web.UI.WebControls.DataBoundControl control, string templateContent) { throw null; }
        protected System.Web.UI.WebControls.TemplateField GetTemplateField(System.Web.UI.WebControls.DataControlField dataControlField, System.Web.UI.WebControls.DataBoundControl dataBoundControl) { throw null; }
        public abstract bool IsEnabled(System.Web.UI.WebControls.DataBoundControl parent);
    }
    public partial class DataControlFieldTypeEditor : System.Drawing.Design.UITypeEditor
    {
        public DataControlFieldTypeEditor() { }
        public override object EditValue(System.ComponentModel.ITypeDescriptorContext context, System.IServiceProvider provider, object value) { throw null; }
        public override System.Drawing.Design.UITypeEditorEditStyle GetEditStyle(System.ComponentModel.ITypeDescriptorContext context) { throw null; }
    }
    [System.Security.Permissions.SecurityPermissionAttribute(System.Security.Permissions.SecurityAction.Demand, Flags=System.Security.Permissions.SecurityPermissionFlag.UnmanagedCode)]
    public partial class DataGridColumnCollectionEditor : System.Drawing.Design.UITypeEditor
    {
        public DataGridColumnCollectionEditor() { }
        public override object EditValue(System.ComponentModel.ITypeDescriptorContext context, System.IServiceProvider provider, object value) { throw null; }
        public override System.Drawing.Design.UITypeEditorEditStyle GetEditStyle(System.ComponentModel.ITypeDescriptorContext context) { throw null; }
    }
    [System.Security.Permissions.SecurityPermissionAttribute(System.Security.Permissions.SecurityAction.Demand, Flags=System.Security.Permissions.SecurityPermissionFlag.UnmanagedCode)]
    public partial class DataGridComponentEditor : System.Web.UI.Design.WebControls.BaseDataListComponentEditor
    {
        public DataGridComponentEditor() : base (default(int)) { }
        public DataGridComponentEditor(int initialPage) : base (default(int)) { }
        protected override System.Type[] GetComponentEditorPages() { throw null; }
    }
    [System.Web.UI.Design.SupportsPreviewControlAttribute(true)]
    [System.Security.Permissions.SecurityPermissionAttribute(System.Security.Permissions.SecurityAction.Demand, Flags=System.Security.Permissions.SecurityPermissionFlag.UnmanagedCode)]
    public partial class DataGridDesigner : System.Web.UI.Design.WebControls.BaseDataListDesigner
    {
        public DataGridDesigner() { }
        public override System.Web.UI.Design.DesignerAutoFormatCollection AutoFormats { get { throw null; } }
        [System.ObsoleteAttribute("Use of this method is not recommended because template editing is handled in ControlDesigner. To support template editing expose template data in the TemplateGroups property and call SetViewFlags(ViewFlags.TemplateEditing, true). http://go.microsoft.com/fwlink/?linkid=14202")]
        protected override System.Web.UI.Design.ITemplateEditingFrame CreateTemplateEditingFrame(System.Web.UI.Design.TemplateEditingVerb verb) { throw null; }
        protected override void Dispose(bool disposing) { }
        [System.ObsoleteAttribute("Use of this method is not recommended because template editing is handled in ControlDesigner. To support template editing expose template data in the TemplateGroups property and call SetViewFlags(ViewFlags.TemplateEditing, true). http://go.microsoft.com/fwlink/?linkid=14202")]
        protected override System.Web.UI.Design.TemplateEditingVerb[] GetCachedTemplateEditingVerbs() { throw null; }
        public override string GetDesignTimeHtml() { throw null; }
        protected override string GetEmptyDesignTimeHtml() { throw null; }
        protected override string GetErrorDesignTimeHtml(System.Exception e) { throw null; }
        [System.ObsoleteAttribute("Use of this method is not recommended because template editing is handled in ControlDesigner. To support template editing expose template data in the TemplateGroups property and call SetViewFlags(ViewFlags.TemplateEditing, true). http://go.microsoft.com/fwlink/?linkid=14202")]
        public override string GetTemplateContainerDataItemProperty(string templateName) { throw null; }
        [System.ObsoleteAttribute("Use of this method is not recommended because template editing is handled in ControlDesigner. To support template editing expose template data in the TemplateGroups property and call SetViewFlags(ViewFlags.TemplateEditing, true). http://go.microsoft.com/fwlink/?linkid=14202")]
        public override string GetTemplateContent(System.Web.UI.Design.ITemplateEditingFrame editingFrame, string templateName, out bool allowEditing) { throw null; }
        [System.ObsoleteAttribute("Use of this method is not recommended because template editing is handled in ControlDesigner. To support template editing expose template data in the TemplateGroups property and call SetViewFlags(ViewFlags.TemplateEditing, true). http://go.microsoft.com/fwlink/?linkid=14202")]
        public override System.Type GetTemplatePropertyParentType(string templateName) { throw null; }
        public override void Initialize(System.ComponentModel.IComponent component) { }
        public virtual void OnColumnsChanged() { }
        protected override void OnTemplateEditingVerbsChanged() { }
        [System.ObsoleteAttribute("Use of this method is not recommended because template editing is handled in ControlDesigner. To support template editing expose template data in the TemplateGroups property and call SetViewFlags(ViewFlags.TemplateEditing, true). http://go.microsoft.com/fwlink/?linkid=14202")]
        public override void SetTemplateContent(System.Web.UI.Design.ITemplateEditingFrame editingFrame, string templateName, string templateContent) { }
    }
    [System.Security.Permissions.SecurityPermissionAttribute(System.Security.Permissions.SecurityAction.Demand, Flags=System.Security.Permissions.SecurityPermissionFlag.UnmanagedCode)]
    public partial class DataListComponentEditor : System.Web.UI.Design.WebControls.BaseDataListComponentEditor
    {
        public DataListComponentEditor() : base (default(int)) { }
        public DataListComponentEditor(int initialPage) : base (default(int)) { }
        protected override System.Type[] GetComponentEditorPages() { throw null; }
    }
    [System.Web.UI.Design.SupportsPreviewControlAttribute(true)]
    [System.Security.Permissions.SecurityPermissionAttribute(System.Security.Permissions.SecurityAction.Demand, Flags=System.Security.Permissions.SecurityPermissionFlag.UnmanagedCode)]
    public partial class DataListDesigner : System.Web.UI.Design.WebControls.BaseDataListDesigner
    {
        public DataListDesigner() { }
        public override bool AllowResize { get { throw null; } }
        public override System.Web.UI.Design.DesignerAutoFormatCollection AutoFormats { get { throw null; } }
        protected bool TemplatesExist { get { throw null; } }
        [System.ObsoleteAttribute("Use of this method is not recommended because template editing is handled in ControlDesigner. To support template editing expose template data in the TemplateGroups property and call SetViewFlags(ViewFlags.TemplateEditing, true). http://go.microsoft.com/fwlink/?linkid=14202")]
        protected override System.Web.UI.Design.ITemplateEditingFrame CreateTemplateEditingFrame(System.Web.UI.Design.TemplateEditingVerb verb) { throw null; }
        protected override void Dispose(bool disposing) { }
        [System.ObsoleteAttribute("Use of this method is not recommended because template editing is handled in ControlDesigner. To support template editing expose template data in the TemplateGroups property and call SetViewFlags(ViewFlags.TemplateEditing, true). http://go.microsoft.com/fwlink/?linkid=14202")]
        protected override System.Web.UI.Design.TemplateEditingVerb[] GetCachedTemplateEditingVerbs() { throw null; }
        public override string GetDesignTimeHtml() { throw null; }
        protected override string GetEmptyDesignTimeHtml() { throw null; }
        protected override string GetErrorDesignTimeHtml(System.Exception e) { throw null; }
        [System.ObsoleteAttribute("Use of this method is not recommended because template editing is handled in ControlDesigner. To support template editing expose template data in the TemplateGroups property and call SetViewFlags(ViewFlags.TemplateEditing, true). http://go.microsoft.com/fwlink/?linkid=14202")]
        public override string GetTemplateContainerDataItemProperty(string templateName) { throw null; }
        [System.ObsoleteAttribute("Use of this method is not recommended because template editing is handled in ControlDesigner. To support template editing expose template data in the TemplateGroups property and call SetViewFlags(ViewFlags.TemplateEditing, true). http://go.microsoft.com/fwlink/?linkid=14202")]
        public override string GetTemplateContent(System.Web.UI.Design.ITemplateEditingFrame editingFrame, string templateName, out bool allowEditing) { throw null; }
        public override void Initialize(System.ComponentModel.IComponent component) { }
        protected override void OnSchemaRefreshed() { }
        protected override void OnTemplateEditingVerbsChanged() { }
        [System.ObsoleteAttribute("Use of this method is not recommended because template editing is handled in ControlDesigner. To support template editing expose template data in the TemplateGroups property and call SetViewFlags(ViewFlags.TemplateEditing, true). http://go.microsoft.com/fwlink/?linkid=14202")]
        public override void SetTemplateContent(System.Web.UI.Design.ITemplateEditingFrame editingFrame, string templateName, string templateContent) { }
    }
    public partial class DataProviderNameConverter : System.ComponentModel.StringConverter
    {
        public DataProviderNameConverter() { }
        public override System.ComponentModel.TypeConverter.StandardValuesCollection GetStandardValues(System.ComponentModel.ITypeDescriptorContext context) { throw null; }
        public override bool GetStandardValuesExclusive(System.ComponentModel.ITypeDescriptorContext context) { throw null; }
        public override bool GetStandardValuesSupported(System.ComponentModel.ITypeDescriptorContext context) { throw null; }
    }
    public partial class DataSourceIDConverter : System.ComponentModel.TypeConverter
    {
        public DataSourceIDConverter() { }
        public override bool CanConvertFrom(System.ComponentModel.ITypeDescriptorContext context, System.Type sourceType) { throw null; }
        public override object ConvertFrom(System.ComponentModel.ITypeDescriptorContext context, System.Globalization.CultureInfo culture, object value) { throw null; }
        public override System.ComponentModel.TypeConverter.StandardValuesCollection GetStandardValues(System.ComponentModel.ITypeDescriptorContext context) { throw null; }
        public override bool GetStandardValuesExclusive(System.ComponentModel.ITypeDescriptorContext context) { throw null; }
        public override bool GetStandardValuesSupported(System.ComponentModel.ITypeDescriptorContext context) { throw null; }
        protected virtual bool IsValidDataSource(System.ComponentModel.IComponent component) { throw null; }
    }
    public partial class DetailsViewDesigner : System.Web.UI.Design.WebControls.DataBoundControlDesigner
    {
        public DetailsViewDesigner() { }
        public override System.ComponentModel.Design.DesignerActionListCollection ActionLists { get { throw null; } }
        public override System.Web.UI.Design.DesignerAutoFormatCollection AutoFormats { get { throw null; } }
        protected override int SampleRowCount { get { throw null; } }
        public override System.Web.UI.Design.TemplateGroupCollection TemplateGroups { get { throw null; } }
        protected override bool UsePreviewControl { get { throw null; } }
        protected override void DataBind(System.Web.UI.WebControls.BaseDataBoundControl dataBoundControl) { }
        public override string GetDesignTimeHtml() { throw null; }
        public override string GetDesignTimeHtml(System.Web.UI.Design.DesignerRegionCollection regions) { throw null; }
        public override string GetEditableDesignerRegionContent(System.Web.UI.Design.EditableDesignerRegion region) { throw null; }
        public override void Initialize(System.ComponentModel.IComponent component) { }
        protected override void OnClick(System.Web.UI.Design.DesignerRegionMouseEventArgs e) { }
        protected override void OnSchemaRefreshed() { }
        protected override void PreFilterProperties(System.Collections.IDictionary properties) { }
        public override void SetEditableDesignerRegionContent(System.Web.UI.Design.EditableDesignerRegion region, string content) { }
    }
    [System.Security.Permissions.SecurityPermissionAttribute(System.Security.Permissions.SecurityAction.Demand, Flags=System.Security.Permissions.SecurityPermissionFlag.UnmanagedCode)]
    public partial class EmbeddedMailObjectCollectionEditor : System.ComponentModel.Design.CollectionEditor
    {
        public EmbeddedMailObjectCollectionEditor(System.Type type) : base (default(System.Type)) { }
        public override object EditValue(System.ComponentModel.ITypeDescriptorContext context, System.IServiceProvider provider, object value) { throw null; }
    }
    public partial class FormViewDesigner : System.Web.UI.Design.WebControls.DataBoundControlDesigner
    {
        public FormViewDesigner() { }
        public override System.ComponentModel.Design.DesignerActionListCollection ActionLists { get { throw null; } }
        public override System.Web.UI.Design.DesignerAutoFormatCollection AutoFormats { get { throw null; } }
        public bool RenderOuterTable { get { throw null; } set { } }
        protected override int SampleRowCount { get { throw null; } }
        public override System.Web.UI.Design.TemplateGroupCollection TemplateGroups { get { throw null; } }
        protected override bool UsePreviewControl { get { throw null; } }
        public override string GetDesignTimeHtml() { throw null; }
        protected override string GetEmptyDesignTimeHtml() { throw null; }
        public override void Initialize(System.ComponentModel.IComponent component) { }
        protected override void OnSchemaRefreshed() { }
        protected override void PreFilterProperties(System.Collections.IDictionary properties) { }
    }
    public partial class GridViewDesigner : System.Web.UI.Design.WebControls.DataBoundControlDesigner
    {
        public GridViewDesigner() { }
        public override System.ComponentModel.Design.DesignerActionListCollection ActionLists { get { throw null; } }
        public override System.Web.UI.Design.DesignerAutoFormatCollection AutoFormats { get { throw null; } }
        protected override int SampleRowCount { get { throw null; } }
        public override System.Web.UI.Design.TemplateGroupCollection TemplateGroups { get { throw null; } }
        protected override bool UsePreviewControl { get { throw null; } }
        protected override void DataBind(System.Web.UI.WebControls.BaseDataBoundControl dataBoundControl) { }
        public override string GetDesignTimeHtml() { throw null; }
        public override string GetDesignTimeHtml(System.Web.UI.Design.DesignerRegionCollection regions) { throw null; }
        public override string GetEditableDesignerRegionContent(System.Web.UI.Design.EditableDesignerRegion region) { throw null; }
        public override void Initialize(System.ComponentModel.IComponent component) { }
        protected override void OnClick(System.Web.UI.Design.DesignerRegionMouseEventArgs e) { }
        protected override void OnSchemaRefreshed() { }
        protected override void PreFilterProperties(System.Collections.IDictionary properties) { }
        public override void SetEditableDesignerRegionContent(System.Web.UI.Design.EditableDesignerRegion region, string content) { }
    }
    [System.Security.Permissions.SecurityPermissionAttribute(System.Security.Permissions.SecurityAction.Demand, Flags=System.Security.Permissions.SecurityPermissionFlag.UnmanagedCode)]
    public partial class HiddenFieldDesigner : System.Web.UI.Design.ControlDesigner
    {
        public HiddenFieldDesigner() { }
        public override string GetDesignTimeHtml() { throw null; }
        public override void Initialize(System.ComponentModel.IComponent component) { }
    }
    public partial class HierarchicalDataBoundControlDesigner : System.Web.UI.Design.WebControls.BaseDataBoundControlDesigner
    {
        public HierarchicalDataBoundControlDesigner() { }
        public override System.ComponentModel.Design.DesignerActionListCollection ActionLists { get { throw null; } }
        public System.Web.UI.Design.IHierarchicalDataSourceDesigner DataSourceDesigner { get { throw null; } }
        public System.Web.UI.Design.DesignerHierarchicalDataSourceView DesignerView { get { throw null; } }
        protected virtual bool UseDataSourcePickerActionList { get { throw null; } }
        protected override bool ConnectToDataSource() { throw null; }
        protected override void CreateDataSource() { }
        protected override void DataBind(System.Web.UI.WebControls.BaseDataBoundControl dataBoundControl) { }
        protected override void DisconnectFromDataSource() { }
        protected virtual System.Web.UI.IHierarchicalEnumerable GetDesignTimeDataSource() { throw null; }
        protected virtual System.Web.UI.IHierarchicalEnumerable GetSampleDataSource() { throw null; }
        protected override void PreFilterProperties(System.Collections.IDictionary properties) { }
    }
    public partial class HierarchicalDataSourceIDConverter : System.Web.UI.Design.WebControls.DataSourceIDConverter
    {
        public HierarchicalDataSourceIDConverter() { }
        protected override bool IsValidDataSource(System.ComponentModel.IComponent component) { throw null; }
    }
    public partial class HotSpotCollectionEditor : System.ComponentModel.Design.CollectionEditor
    {
        public HotSpotCollectionEditor(System.Type type) : base (default(System.Type)) { }
        protected override string HelpTopic { get { throw null; } }
        protected override bool CanSelectMultipleInstances() { throw null; }
        protected override System.Type[] CreateNewItemTypes() { throw null; }
    }
    [System.Web.UI.Design.SupportsPreviewControlAttribute(true)]
    [System.Security.Permissions.SecurityPermissionAttribute(System.Security.Permissions.SecurityAction.Demand, Flags=System.Security.Permissions.SecurityPermissionFlag.UnmanagedCode)]
    public partial class HyperLinkDesigner : System.Web.UI.Design.TextControlDesigner
    {
        public HyperLinkDesigner() { }
        public override string GetDesignTimeHtml() { throw null; }
        public override void OnComponentChanged(object sender, System.ComponentModel.Design.ComponentChangedEventArgs ce) { }
    }
    [System.Web.UI.Design.SupportsPreviewControlAttribute(true)]
    [System.Security.Permissions.SecurityPermissionAttribute(System.Security.Permissions.SecurityAction.Demand, Flags=System.Security.Permissions.SecurityPermissionFlag.UnmanagedCode)]
    public partial class LabelDesigner : System.Web.UI.Design.TextControlDesigner
    {
        public LabelDesigner() { }
        public override void OnComponentChanged(object sender, System.ComponentModel.Design.ComponentChangedEventArgs ce) { }
    }
    [System.Web.UI.Design.SupportsPreviewControlAttribute(true)]
    [System.Security.Permissions.SecurityPermissionAttribute(System.Security.Permissions.SecurityAction.Demand, Flags=System.Security.Permissions.SecurityPermissionFlag.UnmanagedCode)]
    public partial class LinkButtonDesigner : System.Web.UI.Design.TextControlDesigner
    {
        public LinkButtonDesigner() { }
    }
    [System.Security.Permissions.SecurityPermissionAttribute(System.Security.Permissions.SecurityAction.Demand, Flags=System.Security.Permissions.SecurityPermissionFlag.UnmanagedCode)]
    public partial class ListControlDataBindingHandler : System.Web.UI.Design.DataBindingHandler
    {
        public ListControlDataBindingHandler() { }
        public override void DataBindControl(System.ComponentModel.Design.IDesignerHost designerHost, System.Web.UI.Control control) { }
    }
    [System.Web.UI.Design.SupportsPreviewControlAttribute(true)]
    [System.Security.Permissions.SecurityPermissionAttribute(System.Security.Permissions.SecurityAction.Demand, Flags=System.Security.Permissions.SecurityPermissionFlag.UnmanagedCode)]
    public partial class ListControlDesigner : System.Web.UI.Design.WebControls.DataBoundControlDesigner
    {
        public ListControlDesigner() { }
        public override System.ComponentModel.Design.DesignerActionListCollection ActionLists { get { throw null; } }
        public string DataTextField { get { throw null; } set { } }
        public string DataValueField { get { throw null; } set { } }
        protected override bool UseDataSourcePickerActionList { get { throw null; } }
        protected override void DataBind(System.Web.UI.WebControls.BaseDataBoundControl dataBoundControl) { }
        public override string GetDesignTimeHtml() { throw null; }
        public System.Collections.IEnumerable GetResolvedSelectedDataSource() { throw null; }
        public object GetSelectedDataSource() { throw null; }
        public override void Initialize(System.ComponentModel.IComponent component) { }
        public virtual void OnDataSourceChanged() { }
        protected override void OnDataSourceChanged(bool forceUpdateView) { }
        protected override void PreFilterProperties(System.Collections.IDictionary properties) { }
    }
    [System.Security.Permissions.SecurityPermissionAttribute(System.Security.Permissions.SecurityAction.Demand, Flags=System.Security.Permissions.SecurityPermissionFlag.UnmanagedCode)]
    public partial class ListItemsCollectionEditor : System.ComponentModel.Design.CollectionEditor
    {
        public ListItemsCollectionEditor(System.Type type) : base (default(System.Type)) { }
        protected override string HelpTopic { get { throw null; } }
        protected override bool CanSelectMultipleInstances() { throw null; }
    }
    [System.Web.UI.Design.SupportsPreviewControlAttribute(true)]
    [System.Security.Permissions.SecurityPermissionAttribute(System.Security.Permissions.SecurityAction.Demand, Flags=System.Security.Permissions.SecurityPermissionFlag.UnmanagedCode)]
    public partial class LiteralDesigner : System.Web.UI.Design.ControlDesigner
    {
        public LiteralDesigner() { }
        public override void OnComponentChanged(object sender, System.ComponentModel.Design.ComponentChangedEventArgs ce) { }
    }
    [System.Security.Permissions.SecurityPermissionAttribute(System.Security.Permissions.SecurityAction.Demand, Flags=System.Security.Permissions.SecurityPermissionFlag.UnmanagedCode)]
    public partial class LoginDesigner : System.Web.UI.Design.WebControls.CompositeControlDesigner
    {
        public LoginDesigner() { }
        public override System.ComponentModel.Design.DesignerActionListCollection ActionLists { get { throw null; } }
        public override bool AllowResize { get { throw null; } }
        public override System.Web.UI.Design.DesignerAutoFormatCollection AutoFormats { get { throw null; } }
        public bool RenderOuterTable { get { throw null; } set { } }
        public override System.Web.UI.Design.TemplateGroupCollection TemplateGroups { get { throw null; } }
        protected override bool UsePreviewControl { get { throw null; } }
        public override string GetDesignTimeHtml(System.Web.UI.Design.DesignerRegionCollection regions) { throw null; }
        public override string GetEditableDesignerRegionContent(System.Web.UI.Design.EditableDesignerRegion region) { throw null; }
        protected override string GetErrorDesignTimeHtml(System.Exception e) { throw null; }
        public override void Initialize(System.ComponentModel.IComponent component) { }
        protected override void PreFilterProperties(System.Collections.IDictionary properties) { }
        public override void SetEditableDesignerRegionContent(System.Web.UI.Design.EditableDesignerRegion region, string content) { }
    }
    [System.Security.Permissions.SecurityPermissionAttribute(System.Security.Permissions.SecurityAction.Demand, Flags=System.Security.Permissions.SecurityPermissionFlag.UnmanagedCode)]
    public partial class LoginNameDesigner : System.Web.UI.Design.ControlDesigner
    {
        public LoginNameDesigner() { }
        protected override bool UsePreviewControl { get { throw null; } }
        protected override string GetErrorDesignTimeHtml(System.Exception e) { throw null; }
    }
    [System.Security.Permissions.SecurityPermissionAttribute(System.Security.Permissions.SecurityAction.Demand, Flags=System.Security.Permissions.SecurityPermissionFlag.UnmanagedCode)]
    public partial class LoginStatusDesigner : System.Web.UI.Design.WebControls.CompositeControlDesigner
    {
        public LoginStatusDesigner() { }
        public override System.ComponentModel.Design.DesignerActionListCollection ActionLists { get { throw null; } }
        protected override bool UsePreviewControl { get { throw null; } }
        public override string GetDesignTimeHtml() { throw null; }
        public override void Initialize(System.ComponentModel.IComponent component) { }
    }
    [System.Security.Permissions.SecurityPermissionAttribute(System.Security.Permissions.SecurityAction.Demand, Flags=System.Security.Permissions.SecurityPermissionFlag.UnmanagedCode)]
    public partial class LoginViewDesigner : System.Web.UI.Design.ControlDesigner
    {
        public LoginViewDesigner() { }
        public override System.ComponentModel.Design.DesignerActionListCollection ActionLists { get { throw null; } }
        public override System.Web.UI.Design.TemplateGroupCollection TemplateGroups { get { throw null; } }
        protected override bool UsePreviewControl { get { throw null; } }
        public override string GetDesignTimeHtml() { throw null; }
        public override string GetDesignTimeHtml(System.Web.UI.Design.DesignerRegionCollection regions) { throw null; }
        public override string GetEditableDesignerRegionContent(System.Web.UI.Design.EditableDesignerRegion region) { throw null; }
        protected override string GetEmptyDesignTimeHtml() { throw null; }
        protected override string GetErrorDesignTimeHtml(System.Exception e) { throw null; }
        public override void Initialize(System.ComponentModel.IComponent component) { }
        public override void OnComponentChanged(object sender, System.ComponentModel.Design.ComponentChangedEventArgs e) { }
        protected override void PreFilterProperties(System.Collections.IDictionary properties) { }
        public override void SetEditableDesignerRegionContent(System.Web.UI.Design.EditableDesignerRegion region, string content) { }
    }
    [System.Security.Permissions.SecurityPermissionAttribute(System.Security.Permissions.SecurityAction.Demand, Flags=System.Security.Permissions.SecurityPermissionFlag.UnmanagedCode)]
    public partial class MailDefinitionBodyFileNameEditor : System.Web.UI.Design.UrlEditor
    {
        public MailDefinitionBodyFileNameEditor() { }
        protected override string Caption { get { throw null; } }
        protected override string Filter { get { throw null; } }
    }
    public partial class MenuBindingsEditor : System.Drawing.Design.UITypeEditor
    {
        public MenuBindingsEditor() { }
        public override object EditValue(System.ComponentModel.ITypeDescriptorContext context, System.IServiceProvider provider, object value) { throw null; }
        public override System.Drawing.Design.UITypeEditorEditStyle GetEditStyle(System.ComponentModel.ITypeDescriptorContext context) { throw null; }
    }
    public partial class MenuDesigner : System.Web.UI.Design.WebControls.HierarchicalDataBoundControlDesigner, System.Web.UI.Design.IDataBindingSchemaProvider
    {
        public MenuDesigner() { }
        public override System.ComponentModel.Design.DesignerActionListCollection ActionLists { get { throw null; } }
        public override System.Web.UI.Design.DesignerAutoFormatCollection AutoFormats { get { throw null; } }
        protected bool CanRefreshSchema { get { throw null; } }
        protected System.Web.UI.Design.IDataSourceViewSchema Schema { get { throw null; } }
        bool System.Web.UI.Design.IDataBindingSchemaProvider.CanRefreshSchema { get { throw null; } }
        System.Web.UI.Design.IDataSourceViewSchema System.Web.UI.Design.IDataBindingSchemaProvider.Schema { get { throw null; } }
        public override System.Web.UI.Design.TemplateGroupCollection TemplateGroups { get { throw null; } }
        protected override bool UsePreviewControl { get { throw null; } }
        protected override void DataBind(System.Web.UI.WebControls.BaseDataBoundControl dataBoundControl) { }
        public override string GetDesignTimeHtml() { throw null; }
        protected override string GetEmptyDesignTimeHtml() { throw null; }
        protected override string GetErrorDesignTimeHtml(System.Exception e) { throw null; }
        protected override System.Web.UI.IHierarchicalEnumerable GetSampleDataSource() { throw null; }
        public override void Initialize(System.ComponentModel.IComponent component) { }
        protected void RefreshSchema(bool preferSilent) { }
        void System.Web.UI.Design.IDataBindingSchemaProvider.RefreshSchema(bool preferSilent) { }
    }
    public partial class MenuItemCollectionEditor : System.Drawing.Design.UITypeEditor
    {
        public MenuItemCollectionEditor() { }
        public override object EditValue(System.ComponentModel.ITypeDescriptorContext context, System.IServiceProvider provider, object value) { throw null; }
        public override System.Drawing.Design.UITypeEditorEditStyle GetEditStyle(System.ComponentModel.ITypeDescriptorContext context) { throw null; }
    }
    [System.Security.Permissions.SecurityPermissionAttribute(System.Security.Permissions.SecurityAction.Demand, Flags=System.Security.Permissions.SecurityPermissionFlag.UnmanagedCode)]
    public partial class MenuItemStyleCollectionEditor : System.ComponentModel.Design.CollectionEditor
    {
        public MenuItemStyleCollectionEditor(System.Type type) : base (default(System.Type)) { }
        protected override bool CanSelectMultipleInstances() { throw null; }
        protected override System.ComponentModel.Design.CollectionEditor.CollectionForm CreateCollectionForm() { throw null; }
        protected override object CreateInstance(System.Type itemType) { throw null; }
        protected override System.Type[] CreateNewItemTypes() { throw null; }
    }
    [System.Security.Permissions.SecurityPermissionAttribute(System.Security.Permissions.SecurityAction.Demand, Flags=System.Security.Permissions.SecurityPermissionFlag.UnmanagedCode)]
    public partial class MultiViewDesigner : System.Web.UI.Design.ContainerControlDesigner
    {
        public MultiViewDesigner() { }
        protected override bool NoWrap { get { throw null; } }
    }
    [System.Security.Permissions.SecurityPermissionAttribute(System.Security.Permissions.SecurityAction.Demand, Flags=System.Security.Permissions.SecurityPermissionFlag.UnmanagedCode)]
    public partial class ObjectDataSourceDesigner : System.Web.UI.Design.DataSourceDesigner
    {
        public ObjectDataSourceDesigner() { }
        public override bool CanConfigure { get { throw null; } }
        public override bool CanRefreshSchema { get { throw null; } }
        public string SelectMethod { get { throw null; } set { } }
        public string TypeName { get { throw null; } set { } }
        public override void Configure() { }
        public override System.Web.UI.Design.DesignerDataSourceView GetView(string viewName) { throw null; }
        public override string[] GetViewNames() { throw null; }
        protected override void PreFilterProperties(System.Collections.IDictionary properties) { }
        public override void RefreshSchema(bool preferSilent) { }
    }
    [System.Security.Permissions.SecurityPermissionAttribute(System.Security.Permissions.SecurityAction.Demand, Flags=System.Security.Permissions.SecurityPermissionFlag.UnmanagedCode)]
    public partial class ObjectDesignerDataSourceView : System.Web.UI.Design.DesignerDataSourceView
    {
        public ObjectDesignerDataSourceView(System.Web.UI.Design.WebControls.ObjectDataSourceDesigner owner, string viewName) : base (default(System.Web.UI.Design.IDataSourceDesigner), default(string)) { }
        public override bool CanDelete { get { throw null; } }
        public override bool CanInsert { get { throw null; } }
        public override bool CanPage { get { throw null; } }
        public override bool CanRetrieveTotalRowCount { get { throw null; } }
        public override bool CanSort { get { throw null; } }
        public override bool CanUpdate { get { throw null; } }
        public override System.Web.UI.Design.IDataSourceViewSchema Schema { get { throw null; } }
        public override System.Collections.IEnumerable GetDesignTimeData(int minimumRows, out bool isSampleData) { throw null; }
    }
    public partial class PanelContainerDesigner : System.Web.UI.Design.ContainerControlDesigner
    {
        public PanelContainerDesigner() { }
        public override string FrameCaption { get { throw null; } }
        public override System.Web.UI.WebControls.Style FrameStyle { get { throw null; } }
        protected override bool UsePreviewControl { get { throw null; } }
        protected override void AddDesignTimeCssAttributes(System.Collections.IDictionary styleAttributes) { }
        public override void Initialize(System.ComponentModel.IComponent component) { }
    }
    [System.ObsoleteAttribute("The recommended alternative is PanelContainerDesigner because it uses an EditableDesignerRegion for editing the content. Designer regions allow for better control of the content being edited. http://go.microsoft.com/fwlink/?linkid=14202")]
    [System.Security.Permissions.SecurityPermissionAttribute(System.Security.Permissions.SecurityAction.Demand, Flags=System.Security.Permissions.SecurityPermissionFlag.UnmanagedCode)]
    public partial class PanelDesigner : System.Web.UI.Design.ReadWriteControlDesigner
    {
        public PanelDesigner() { }
        protected override void MapPropertyToStyle(string propName, object varPropValue) { }
        [System.ObsoleteAttribute("The recommended alternative is ControlDesigner.Tag. http://go.microsoft.com/fwlink/?linkid=14202")]
        protected override void OnBehaviorAttached() { }
    }
    public partial class ParameterCollectionEditor : System.Drawing.Design.UITypeEditor
    {
        public ParameterCollectionEditor() { }
        public override object EditValue(System.ComponentModel.ITypeDescriptorContext context, System.IServiceProvider provider, object value) { throw null; }
        public override System.Drawing.Design.UITypeEditorEditStyle GetEditStyle(System.ComponentModel.ITypeDescriptorContext context) { throw null; }
    }
    public partial class ParameterEditorUserControl : System.Windows.Forms.UserControl
    {
        public ParameterEditorUserControl(System.IServiceProvider serviceProvider) { }
        public bool ParametersConfigured { get { throw null; } }
        public System.ComponentModel.TypeDescriptionProvider TypeDescriptionProvider { get { throw null; } }
        public event System.EventHandler ParametersChanged { add { } remove { } }
        public void AddParameters(System.Web.UI.WebControls.Parameter[] parameters) { }
        public void ClearParameters() { }
        public System.Web.UI.WebControls.Parameter[] GetParameters() { throw null; }
        protected virtual void OnParametersChanged(object sender, System.EventArgs e) { }
        public void SetAllowCollectionChanges(bool allowChanges) { }
    }
    [System.Security.Permissions.SecurityPermissionAttribute(System.Security.Permissions.SecurityAction.Demand, Flags=System.Security.Permissions.SecurityPermissionFlag.UnmanagedCode)]
    public partial class PasswordRecoveryDesigner : System.Web.UI.Design.ControlDesigner
    {
        public PasswordRecoveryDesigner() { }
        public override System.ComponentModel.Design.DesignerActionListCollection ActionLists { get { throw null; } }
        public override bool AllowResize { get { throw null; } }
        public override System.Web.UI.Design.DesignerAutoFormatCollection AutoFormats { get { throw null; } }
        public bool RenderOuterTable { get { throw null; } set { } }
        public override System.Web.UI.Design.TemplateGroupCollection TemplateGroups { get { throw null; } }
        protected override bool UsePreviewControl { get { throw null; } }
        public override string GetDesignTimeHtml() { throw null; }
        public override string GetDesignTimeHtml(System.Web.UI.Design.DesignerRegionCollection regions) { throw null; }
        public override string GetEditableDesignerRegionContent(System.Web.UI.Design.EditableDesignerRegion region) { throw null; }
        protected override string GetErrorDesignTimeHtml(System.Exception e) { throw null; }
        public override void Initialize(System.ComponentModel.IComponent component) { }
        protected override void PreFilterProperties(System.Collections.IDictionary properties) { }
        public override void SetEditableDesignerRegionContent(System.Web.UI.Design.EditableDesignerRegion region, string content) { }
    }
    [System.Web.UI.Design.SupportsPreviewControlAttribute(true)]
    [System.Security.Permissions.SecurityPermissionAttribute(System.Security.Permissions.SecurityAction.Demand, Flags=System.Security.Permissions.SecurityPermissionFlag.UnmanagedCode)]
    public partial class PreviewControlDesigner : System.Web.UI.Design.ControlDesigner
    {
        public PreviewControlDesigner() { }
        protected override bool UsePreviewControl { get { throw null; } }
    }
    [System.ComponentModel.ToolboxItemAttribute(false)]
    [System.Security.Permissions.SecurityPermissionAttribute(System.Security.Permissions.SecurityAction.Demand, Flags=System.Security.Permissions.SecurityPermissionFlag.UnmanagedCode)]
    public partial class RegexEditorDialog : System.Windows.Forms.Form
    {
        public RegexEditorDialog(System.ComponentModel.ISite site) { }
        public string RegularExpression { get { throw null; } set { } }
        protected void cmdHelp_Click(object sender, System.EventArgs e) { }
        protected void cmdOK_Click(object sender, System.EventArgs e) { }
        protected void cmdTestValidate_Click(object sender, System.EventArgs args) { }
        protected override void Dispose(bool disposing) { }
        protected void lstStandardExpressions_SelectedIndexChanged(object sender, System.EventArgs e) { }
        protected void RegexTypeEditor_Activated(object sender, System.EventArgs e) { }
        protected void txtExpression_TextChanged(object sender, System.EventArgs e) { }
    }
    [System.Security.Permissions.SecurityPermissionAttribute(System.Security.Permissions.SecurityAction.Demand, Flags=System.Security.Permissions.SecurityPermissionFlag.UnmanagedCode)]
    public partial class RegexTypeEditor : System.Drawing.Design.UITypeEditor
    {
        public RegexTypeEditor() { }
        public override object EditValue(System.ComponentModel.ITypeDescriptorContext context, System.IServiceProvider provider, object value) { throw null; }
        public override System.Drawing.Design.UITypeEditorEditStyle GetEditStyle(System.ComponentModel.ITypeDescriptorContext context) { throw null; }
    }
    [System.Security.Permissions.SecurityPermissionAttribute(System.Security.Permissions.SecurityAction.Demand, Flags=System.Security.Permissions.SecurityPermissionFlag.UnmanagedCode)]
    public partial class RepeaterDesigner : System.Web.UI.Design.ControlDesigner, System.Web.UI.Design.IDataSourceProvider
    {
        public RepeaterDesigner() { }
        public override System.ComponentModel.Design.DesignerActionListCollection ActionLists { get { throw null; } }
        public string DataMember { get { throw null; } set { } }
        public string DataSource { get { throw null; } set { } }
        public System.Web.UI.Design.IDataSourceDesigner DataSourceDesigner { get { throw null; } }
        public string DataSourceID { get { throw null; } set { } }
        public System.Web.UI.Design.DesignerDataSourceView DesignerView { get { throw null; } }
        protected bool TemplatesExist { get { throw null; } }
        protected override void Dispose(bool disposing) { }
        protected virtual void ExecuteChooseDataSourcePostSteps() { }
        protected System.Collections.IEnumerable GetDesignTimeDataSource(System.Collections.IEnumerable selectedDataSource, int minimumRows) { throw null; }
        protected System.Collections.IEnumerable GetDesignTimeDataSource(int minimumRows) { throw null; }
        public override string GetDesignTimeHtml() { throw null; }
        protected override string GetEmptyDesignTimeHtml() { throw null; }
        protected override string GetErrorDesignTimeHtml(System.Exception e) { throw null; }
        public System.Collections.IEnumerable GetResolvedSelectedDataSource() { throw null; }
        public object GetSelectedDataSource() { throw null; }
        public override void Initialize(System.ComponentModel.IComponent component) { }
        public override void OnComponentChanged(object source, System.ComponentModel.Design.ComponentChangedEventArgs ce) { }
        public virtual void OnDataSourceChanged() { }
        protected override void PreFilterProperties(System.Collections.IDictionary properties) { }
    }
    [System.Security.Permissions.SecurityPermissionAttribute(System.Security.Permissions.SecurityAction.Demand, Flags=System.Security.Permissions.SecurityPermissionFlag.UnmanagedCode)]
    public partial class RoleGroupCollectionEditor : System.ComponentModel.Design.CollectionEditor
    {
        public RoleGroupCollectionEditor(System.Type type) : base (default(System.Type)) { }
        protected override bool CanSelectMultipleInstances() { throw null; }
    }
    [System.Security.Permissions.SecurityPermissionAttribute(System.Security.Permissions.SecurityAction.Demand, Flags=System.Security.Permissions.SecurityPermissionFlag.UnmanagedCode)]
    public partial class SiteMapDataSourceDesigner : System.Web.UI.Design.HierarchicalDataSourceDesigner, System.Web.UI.Design.IDataSourceDesigner
    {
        public SiteMapDataSourceDesigner() { }
        public override bool CanRefreshSchema { get { throw null; } }
        bool System.Web.UI.Design.IDataSourceDesigner.CanConfigure { get { throw null; } }
        bool System.Web.UI.Design.IDataSourceDesigner.CanRefreshSchema { get { throw null; } }
        event System.EventHandler System.Web.UI.Design.IDataSourceDesigner.DataSourceChanged { add { } remove { } }
        event System.EventHandler System.Web.UI.Design.IDataSourceDesigner.SchemaRefreshed { add { } remove { } }
        public override System.Web.UI.Design.DesignerHierarchicalDataSourceView GetView(string viewPath) { throw null; }
        public virtual string[] GetViewNames() { throw null; }
        public override void Initialize(System.ComponentModel.IComponent component) { }
        public override void OnComponentChanged(object sender, System.ComponentModel.Design.ComponentChangedEventArgs e) { }
        public override void RefreshSchema(bool preferSilent) { }
        void System.Web.UI.Design.IDataSourceDesigner.Configure() { }
        System.Web.UI.Design.DesignerDataSourceView System.Web.UI.Design.IDataSourceDesigner.GetView(string viewName) { throw null; }
        string[] System.Web.UI.Design.IDataSourceDesigner.GetViewNames() { throw null; }
        void System.Web.UI.Design.IDataSourceDesigner.RefreshSchema(bool preferSilent) { }
        void System.Web.UI.Design.IDataSourceDesigner.ResumeDataSourceEvents() { }
        void System.Web.UI.Design.IDataSourceDesigner.SuppressDataSourceEvents() { }
    }
    [System.Security.Permissions.SecurityPermissionAttribute(System.Security.Permissions.SecurityAction.Demand, Flags=System.Security.Permissions.SecurityPermissionFlag.UnmanagedCode)]
    public partial class SiteMapDesignerDataSourceView : System.Web.UI.Design.DesignerDataSourceView
    {
        public SiteMapDesignerDataSourceView(System.Web.UI.Design.WebControls.SiteMapDataSourceDesigner owner, string viewName) : base (default(System.Web.UI.Design.IDataSourceDesigner), default(string)) { }
        public override System.Web.UI.Design.IDataSourceViewSchema Schema { get { throw null; } }
        public override System.Collections.IEnumerable GetDesignTimeData(int minimumRows, out bool isSampleData) { throw null; }
    }
    [System.Security.Permissions.SecurityPermissionAttribute(System.Security.Permissions.SecurityAction.Demand, Flags=System.Security.Permissions.SecurityPermissionFlag.UnmanagedCode)]
    public partial class SiteMapDesignerHierarchicalDataSourceView : System.Web.UI.Design.DesignerHierarchicalDataSourceView
    {
        public SiteMapDesignerHierarchicalDataSourceView(System.Web.UI.Design.WebControls.SiteMapDataSourceDesigner owner, string viewPath) : base (default(System.Web.UI.Design.IHierarchicalDataSourceDesigner), default(string)) { }
        public override System.Web.UI.Design.IDataSourceSchema Schema { get { throw null; } }
        public override System.Web.UI.IHierarchicalEnumerable GetDesignTimeData(out bool isSampleData) { throw null; }
    }
    [System.Security.Permissions.SecurityPermissionAttribute(System.Security.Permissions.SecurityAction.Demand, Flags=System.Security.Permissions.SecurityPermissionFlag.UnmanagedCode)]
    public partial class SiteMapPathDesigner : System.Web.UI.Design.ControlDesigner
    {
        public SiteMapPathDesigner() { }
        public override System.Web.UI.Design.DesignerAutoFormatCollection AutoFormats { get { throw null; } }
        public override System.Web.UI.Design.TemplateGroupCollection TemplateGroups { get { throw null; } }
        protected override bool UsePreviewControl { get { throw null; } }
        public override string GetDesignTimeHtml() { throw null; }
        protected override string GetErrorDesignTimeHtml(System.Exception e) { throw null; }
        public override void Initialize(System.ComponentModel.IComponent component) { }
    }
    [System.Security.Permissions.SecurityPermissionAttribute(System.Security.Permissions.SecurityAction.Demand, Flags=System.Security.Permissions.SecurityPermissionFlag.UnmanagedCode)]
    public partial class SqlDataSourceConnectionStringEditor : System.Web.UI.Design.ConnectionStringEditor
    {
        public SqlDataSourceConnectionStringEditor() { }
        protected override string GetProviderName(object instance) { throw null; }
        protected override void SetProviderName(object instance, System.ComponentModel.Design.Data.DesignerDataConnection connection) { }
    }
    [System.Security.Permissions.SecurityPermissionAttribute(System.Security.Permissions.SecurityAction.Demand, Flags=System.Security.Permissions.SecurityPermissionFlag.UnmanagedCode)]
    public partial class SqlDataSourceDesigner : System.Web.UI.Design.DataSourceDesigner
    {
        public SqlDataSourceDesigner() { }
        public override bool CanConfigure { get { throw null; } }
        public override bool CanRefreshSchema { get { throw null; } }
        public string ConnectionString { get { throw null; } set { } }
        [System.ComponentModel.CategoryAttribute("Data")]
        [System.ComponentModel.DefaultValueAttribute(System.Web.UI.DataSourceOperation.Delete)]
        [System.ComponentModel.DesignerSerializationVisibilityAttribute(System.ComponentModel.DesignerSerializationVisibility.Hidden)]
        [System.ComponentModel.MergablePropertyAttribute(false)]
        [System.ComponentModel.TypeConverterAttribute("System.Web.UI.Design.WebControls.SqlDataSourceQueryConverter")]
        public System.Web.UI.DataSourceOperation DeleteQuery { get { throw null; } set { } }
        [System.ComponentModel.CategoryAttribute("Data")]
        [System.ComponentModel.DefaultValueAttribute(System.Web.UI.DataSourceOperation.Insert)]
        [System.ComponentModel.DesignerSerializationVisibilityAttribute(System.ComponentModel.DesignerSerializationVisibility.Hidden)]
        [System.ComponentModel.MergablePropertyAttribute(false)]
        [System.ComponentModel.TypeConverterAttribute("System.Web.UI.Design.WebControls.SqlDataSourceQueryConverter")]
        public System.Web.UI.DataSourceOperation InsertQuery { get { throw null; } set { } }
        public string ProviderName { get { throw null; } set { } }
        public string SelectCommand { get { throw null; } set { } }
        [System.ComponentModel.CategoryAttribute("Data")]
        [System.ComponentModel.DefaultValueAttribute(System.Web.UI.DataSourceOperation.Select)]
        [System.ComponentModel.DesignerSerializationVisibilityAttribute(System.ComponentModel.DesignerSerializationVisibility.Hidden)]
        [System.ComponentModel.MergablePropertyAttribute(false)]
        [System.ComponentModel.TypeConverterAttribute("System.Web.UI.Design.WebControls.SqlDataSourceQueryConverter")]
        public System.Web.UI.DataSourceOperation SelectQuery { get { throw null; } set { } }
        [System.ComponentModel.CategoryAttribute("Data")]
        [System.ComponentModel.DefaultValueAttribute(System.Web.UI.DataSourceOperation.Update)]
        [System.ComponentModel.DesignerSerializationVisibilityAttribute(System.ComponentModel.DesignerSerializationVisibility.Hidden)]
        [System.ComponentModel.MergablePropertyAttribute(false)]
        [System.ComponentModel.TypeConverterAttribute("System.Web.UI.Design.WebControls.SqlDataSourceQueryConverter")]
        public System.Web.UI.DataSourceOperation UpdateQuery { get { throw null; } set { } }
        public override void Configure() { }
        protected virtual System.Web.UI.Design.WebControls.SqlDesignerDataSourceView CreateView(string viewName) { throw null; }
        protected virtual void DeriveParameters(string providerName, System.Data.Common.DbCommand command) { }
        protected virtual string GetConnectionString() { throw null; }
        public override System.Web.UI.Design.DesignerDataSourceView GetView(string viewName) { throw null; }
        public override string[] GetViewNames() { throw null; }
        protected internal virtual System.Web.UI.WebControls.Parameter[] InferParameterNames(System.ComponentModel.Design.Data.DesignerDataConnection connection, string commandText, System.Web.UI.WebControls.SqlDataSourceCommandType commandType) { throw null; }
        protected override void PreFilterProperties(System.Collections.IDictionary properties) { }
        public override void RefreshSchema(bool preferSilent) { }
    }
    [System.Security.Permissions.SecurityPermissionAttribute(System.Security.Permissions.SecurityAction.Demand, Flags=System.Security.Permissions.SecurityPermissionFlag.UnmanagedCode)]
    public partial class SqlDesignerDataSourceView : System.Web.UI.Design.DesignerDataSourceView
    {
        public SqlDesignerDataSourceView(System.Web.UI.Design.WebControls.SqlDataSourceDesigner owner, string viewName) : base (default(System.Web.UI.Design.IDataSourceDesigner), default(string)) { }
        public override bool CanDelete { get { throw null; } }
        public override bool CanInsert { get { throw null; } }
        public override bool CanPage { get { throw null; } }
        public override bool CanRetrieveTotalRowCount { get { throw null; } }
        public override bool CanSort { get { throw null; } }
        public override bool CanUpdate { get { throw null; } }
        public override System.Web.UI.Design.IDataSourceViewSchema Schema { get { throw null; } }
        public override System.Collections.IEnumerable GetDesignTimeData(int minimumRows, out bool isSampleData) { throw null; }
    }
    [System.Security.Permissions.SecurityPermissionAttribute(System.Security.Permissions.SecurityAction.Demand, Flags=System.Security.Permissions.SecurityPermissionFlag.UnmanagedCode)]
    public partial class StyleCollectionEditor : System.ComponentModel.Design.CollectionEditor
    {
        public StyleCollectionEditor(System.Type type) : base (default(System.Type)) { }
        protected override object CreateInstance(System.Type itemType) { throw null; }
    }
    [System.Security.Permissions.SecurityPermissionAttribute(System.Security.Permissions.SecurityAction.Demand, Flags=System.Security.Permissions.SecurityPermissionFlag.UnmanagedCode)]
    public partial class SubMenuStyleCollectionEditor : System.ComponentModel.Design.CollectionEditor
    {
        public SubMenuStyleCollectionEditor(System.Type type) : base (default(System.Type)) { }
        protected override bool CanSelectMultipleInstances() { throw null; }
        protected override System.ComponentModel.Design.CollectionEditor.CollectionForm CreateCollectionForm() { throw null; }
        protected override object CreateInstance(System.Type itemType) { throw null; }
        protected override System.Type[] CreateNewItemTypes() { throw null; }
    }
    [System.Web.UI.Design.SupportsPreviewControlAttribute(true)]
    [System.Security.Permissions.SecurityPermissionAttribute(System.Security.Permissions.SecurityAction.Demand, Flags=System.Security.Permissions.SecurityPermissionFlag.UnmanagedCode)]
    public partial class SubstitutionDesigner : System.Web.UI.Design.ControlDesigner
    {
        public SubstitutionDesigner() { }
        public override string GetDesignTimeHtml() { throw null; }
    }
    [System.Security.Permissions.SecurityPermissionAttribute(System.Security.Permissions.SecurityAction.Demand, Flags=System.Security.Permissions.SecurityPermissionFlag.UnmanagedCode)]
    public partial class TableCellsCollectionEditor : System.ComponentModel.Design.CollectionEditor
    {
        public TableCellsCollectionEditor(System.Type type) : base (default(System.Type)) { }
        protected override bool CanSelectMultipleInstances() { throw null; }
        protected override object CreateInstance(System.Type itemType) { throw null; }
    }
    [System.Web.UI.Design.SupportsPreviewControlAttribute(true)]
    [System.Security.Permissions.SecurityPermissionAttribute(System.Security.Permissions.SecurityAction.Demand, Flags=System.Security.Permissions.SecurityPermissionFlag.UnmanagedCode)]
    public partial class TableDesigner : System.Web.UI.Design.ControlDesigner
    {
        public TableDesigner() { }
        public override string GetDesignTimeHtml() { throw null; }
    }
    [System.Security.Permissions.SecurityPermissionAttribute(System.Security.Permissions.SecurityAction.Demand, Flags=System.Security.Permissions.SecurityPermissionFlag.UnmanagedCode)]
    public partial class TableRowsCollectionEditor : System.ComponentModel.Design.CollectionEditor
    {
        public TableRowsCollectionEditor(System.Type type) : base (default(System.Type)) { }
        protected override bool CanSelectMultipleInstances() { throw null; }
        protected override object CreateInstance(System.Type itemType) { throw null; }
    }
    public partial class TreeNodeBindingDepthConverter : System.ComponentModel.Int32Converter
    {
        public TreeNodeBindingDepthConverter() { }
        public override object ConvertFrom(System.ComponentModel.ITypeDescriptorContext context, System.Globalization.CultureInfo culture, object value) { throw null; }
        public override object ConvertTo(System.ComponentModel.ITypeDescriptorContext context, System.Globalization.CultureInfo culture, object value, System.Type destinationType) { throw null; }
    }
    public partial class TreeNodeCollectionEditor : System.Drawing.Design.UITypeEditor
    {
        public TreeNodeCollectionEditor() { }
        public override object EditValue(System.ComponentModel.ITypeDescriptorContext context, System.IServiceProvider provider, object value) { throw null; }
        public override System.Drawing.Design.UITypeEditorEditStyle GetEditStyle(System.ComponentModel.ITypeDescriptorContext context) { throw null; }
    }
    [System.Security.Permissions.SecurityPermissionAttribute(System.Security.Permissions.SecurityAction.Demand, Flags=System.Security.Permissions.SecurityPermissionFlag.UnmanagedCode)]
    public partial class TreeNodeStyleCollectionEditor : System.Web.UI.Design.WebControls.StyleCollectionEditor
    {
        public TreeNodeStyleCollectionEditor(System.Type type) : base (default(System.Type)) { }
        protected override System.Type CreateCollectionItemType() { throw null; }
    }
    public partial class TreeViewBindingsEditor : System.Drawing.Design.UITypeEditor
    {
        public TreeViewBindingsEditor() { }
        public override object EditValue(System.ComponentModel.ITypeDescriptorContext context, System.IServiceProvider provider, object value) { throw null; }
        public override System.Drawing.Design.UITypeEditorEditStyle GetEditStyle(System.ComponentModel.ITypeDescriptorContext context) { throw null; }
    }
    public partial class TreeViewDesigner : System.Web.UI.Design.WebControls.HierarchicalDataBoundControlDesigner
    {
        public TreeViewDesigner() { }
        public override System.ComponentModel.Design.DesignerActionListCollection ActionLists { get { throw null; } }
        public override System.Web.UI.Design.DesignerAutoFormatCollection AutoFormats { get { throw null; } }
        protected override bool UsePreviewControl { get { throw null; } }
        protected void CreateLineImages() { }
        protected override void DataBind(System.Web.UI.WebControls.BaseDataBoundControl dataBoundControl) { }
        protected void EditBindings() { }
        protected void EditNodes() { }
        public override string GetDesignTimeHtml() { throw null; }
        protected override string GetEmptyDesignTimeHtml() { throw null; }
        protected override string GetErrorDesignTimeHtml(System.Exception e) { throw null; }
        protected override System.Web.UI.IHierarchicalEnumerable GetSampleDataSource() { throw null; }
        public override void Initialize(System.ComponentModel.IComponent component) { }
    }
    [System.Web.UI.Design.SupportsPreviewControlAttribute(true)]
    [System.Security.Permissions.SecurityPermissionAttribute(System.Security.Permissions.SecurityAction.Demand, Flags=System.Security.Permissions.SecurityPermissionFlag.UnmanagedCode)]
    public partial class ValidationSummaryDesigner : System.Web.UI.Design.WebControls.PreviewControlDesigner
    {
        public ValidationSummaryDesigner() { }
        protected override System.Web.UI.Control CreateViewControl() { throw null; }
        protected override void PreFilterProperties(System.Collections.IDictionary properties) { }
    }
    [System.Security.Permissions.SecurityPermissionAttribute(System.Security.Permissions.SecurityAction.Demand, Flags=System.Security.Permissions.SecurityPermissionFlag.UnmanagedCode)]
    public partial class ViewDesigner : System.Web.UI.Design.ContainerControlDesigner
    {
        public ViewDesigner() { }
        protected override bool NoWrap { get { throw null; } }
        public override string GetDesignTimeHtml() { throw null; }
        public override string GetDesignTimeHtml(System.Web.UI.Design.DesignerRegionCollection regions) { throw null; }
        public override void Initialize(System.ComponentModel.IComponent component) { }
    }
    [System.Security.Permissions.SecurityPermissionAttribute(System.Security.Permissions.SecurityAction.Demand, Flags=System.Security.Permissions.SecurityPermissionFlag.UnmanagedCode)]
    public partial class WizardDesigner : System.Web.UI.Design.WebControls.CompositeControlDesigner
    {
        public WizardDesigner() { }
        public override System.ComponentModel.Design.DesignerActionListCollection ActionLists { get { throw null; } }
        public override System.Web.UI.Design.DesignerAutoFormatCollection AutoFormats { get { throw null; } }
        protected bool DisplaySideBar { get { throw null; } set { } }
        public override System.Web.UI.Design.TemplateGroupCollection TemplateGroups { get { throw null; } }
        protected override bool UsePreviewControl { get { throw null; } }
        protected virtual void AddDesignerRegions(System.Web.UI.Design.DesignerRegionCollection regions) { }
        protected virtual void ConvertToCustomNavigationTemplate() { }
        protected void ConvertToTemplate(string description, System.ComponentModel.IComponent component, string templateName, string[] keys) { }
        protected override void CreateChildControls() { }
        public override string GetDesignTimeHtml() { throw null; }
        public override string GetDesignTimeHtml(System.Web.UI.Design.DesignerRegionCollection regions) { throw null; }
        public override string GetEditableDesignerRegionContent(System.Web.UI.Design.EditableDesignerRegion region) { throw null; }
        public override void Initialize(System.ComponentModel.IComponent component) { }
        protected override void OnClick(System.Web.UI.Design.DesignerRegionMouseEventArgs e) { }
        public override void OnComponentChanged(object sender, System.ComponentModel.Design.ComponentChangedEventArgs ce) { }
        protected override void PreFilterProperties(System.Collections.IDictionary properties) { }
        protected void ResetTemplate(string description, System.ComponentModel.IComponent component, string templateName) { }
        public override void SetEditableDesignerRegionContent(System.Web.UI.Design.EditableDesignerRegion region, string content) { }
    }
    [System.Security.Permissions.SecurityPermissionAttribute(System.Security.Permissions.SecurityAction.Demand, Flags=System.Security.Permissions.SecurityPermissionFlag.UnmanagedCode)]
    public partial class WizardStepCollectionEditor : System.ComponentModel.Design.CollectionEditor
    {
        public WizardStepCollectionEditor(System.Type type) : base (default(System.Type)) { }
        protected override bool CanSelectMultipleInstances() { throw null; }
        protected override System.ComponentModel.Design.CollectionEditor.CollectionForm CreateCollectionForm() { throw null; }
        protected override object CreateInstance(System.Type itemType) { throw null; }
        protected override System.Type[] CreateNewItemTypes() { throw null; }
    }
    public partial class WizardStepEditableRegion : System.Web.UI.Design.EditableDesignerRegion
    {
        public WizardStepEditableRegion(System.Web.UI.Design.WebControls.WizardDesigner designer, System.Web.UI.WebControls.WizardStepBase wizardStep) : base (default(System.Web.UI.Design.ControlDesigner), default(string)) { }
        public System.Web.UI.WebControls.WizardStepBase Step { get { throw null; } }
    }
    public partial class WizardStepTemplatedEditableRegion : System.Web.UI.Design.TemplatedEditableDesignerRegion
    {
        public WizardStepTemplatedEditableRegion(System.Web.UI.Design.TemplateDefinition templateDefinition, System.Web.UI.WebControls.WizardStepBase wizardStep) : base (default(System.Web.UI.Design.TemplateDefinition)) { }
        public System.Web.UI.WebControls.WizardStepBase Step { get { throw null; } }
    }
    [System.Security.Permissions.SecurityPermissionAttribute(System.Security.Permissions.SecurityAction.Demand, Flags=System.Security.Permissions.SecurityPermissionFlag.UnmanagedCode)]
    public partial class XmlDataSourceDesigner : System.Web.UI.Design.HierarchicalDataSourceDesigner, System.Web.UI.Design.IDataSourceDesigner
    {
        public XmlDataSourceDesigner() { }
        public override bool CanConfigure { get { throw null; } }
        public override bool CanRefreshSchema { get { throw null; } }
        public string Data { get { throw null; } set { } }
        public string DataFile { get { throw null; } set { } }
        bool System.Web.UI.Design.IDataSourceDesigner.CanConfigure { get { throw null; } }
        bool System.Web.UI.Design.IDataSourceDesigner.CanRefreshSchema { get { throw null; } }
        public string Transform { get { throw null; } set { } }
        public string TransformFile { get { throw null; } set { } }
        public string XPath { get { throw null; } set { } }
        event System.EventHandler System.Web.UI.Design.IDataSourceDesigner.DataSourceChanged { add { } remove { } }
        event System.EventHandler System.Web.UI.Design.IDataSourceDesigner.SchemaRefreshed { add { } remove { } }
        public override void Configure() { }
        public override System.Web.UI.Design.DesignerHierarchicalDataSourceView GetView(string viewPath) { throw null; }
        public override void Initialize(System.ComponentModel.IComponent component) { }
        protected override void PreFilterProperties(System.Collections.IDictionary properties) { }
        public override void RefreshSchema(bool preferSilent) { }
        void System.Web.UI.Design.IDataSourceDesigner.Configure() { }
        System.Web.UI.Design.DesignerDataSourceView System.Web.UI.Design.IDataSourceDesigner.GetView(string viewName) { throw null; }
        string[] System.Web.UI.Design.IDataSourceDesigner.GetViewNames() { throw null; }
        void System.Web.UI.Design.IDataSourceDesigner.RefreshSchema(bool preferSilent) { }
        void System.Web.UI.Design.IDataSourceDesigner.ResumeDataSourceEvents() { }
        void System.Web.UI.Design.IDataSourceDesigner.SuppressDataSourceEvents() { }
    }
    [System.Security.Permissions.SecurityPermissionAttribute(System.Security.Permissions.SecurityAction.Demand, Flags=System.Security.Permissions.SecurityPermissionFlag.UnmanagedCode)]
    public partial class XmlDesigner : System.Web.UI.Design.ControlDesigner
    {
        public XmlDesigner() { }
        protected override void Dispose(bool disposing) { }
        public override string GetDesignTimeHtml() { throw null; }
        protected override string GetEmptyDesignTimeHtml() { throw null; }
        public override void Initialize(System.ComponentModel.IComponent component) { }
    }
    [System.Security.Permissions.SecurityPermissionAttribute(System.Security.Permissions.SecurityAction.Demand, Flags=System.Security.Permissions.SecurityPermissionFlag.UnmanagedCode)]
    public partial class XmlDesignerDataSourceView : System.Web.UI.Design.DesignerDataSourceView
    {
        public XmlDesignerDataSourceView(System.Web.UI.Design.WebControls.XmlDataSourceDesigner owner, string viewName) : base (default(System.Web.UI.Design.IDataSourceDesigner), default(string)) { }
        public override System.Web.UI.Design.IDataSourceViewSchema Schema { get { throw null; } }
        public override System.Collections.IEnumerable GetDesignTimeData(int minimumRows, out bool isSampleData) { throw null; }
    }
    [System.Security.Permissions.SecurityPermissionAttribute(System.Security.Permissions.SecurityAction.Demand, Flags=System.Security.Permissions.SecurityPermissionFlag.UnmanagedCode)]
    public partial class XmlDesignerHierarchicalDataSourceView : System.Web.UI.Design.DesignerHierarchicalDataSourceView
    {
        public XmlDesignerHierarchicalDataSourceView(System.Web.UI.Design.WebControls.XmlDataSourceDesigner owner, string viewPath) : base (default(System.Web.UI.Design.IHierarchicalDataSourceDesigner), default(string)) { }
        public override System.Web.UI.Design.IDataSourceSchema Schema { get { throw null; } }
        public override System.Web.UI.IHierarchicalEnumerable GetDesignTimeData(out bool isSampleData) { throw null; }
    }
}
namespace System.Web.UI.Design.WebControls.WebParts
{
    [System.Security.Permissions.SecurityPermissionAttribute(System.Security.Permissions.SecurityAction.Demand, Flags=System.Security.Permissions.SecurityPermissionFlag.UnmanagedCode)]
    public partial class CatalogPartDesigner : System.Web.UI.Design.WebControls.WebParts.PartDesigner
    {
        public CatalogPartDesigner() { }
        protected override System.Web.UI.Control CreateViewControl() { throw null; }
        public override string GetDesignTimeHtml() { throw null; }
        public override void Initialize(System.ComponentModel.IComponent component) { }
    }
    [System.Security.Permissions.SecurityPermissionAttribute(System.Security.Permissions.SecurityAction.Demand, Flags=System.Security.Permissions.SecurityPermissionFlag.UnmanagedCode)]
    public partial class CatalogZoneDesigner : System.Web.UI.Design.WebControls.WebParts.ToolZoneDesigner
    {
        public CatalogZoneDesigner() { }
        public override System.Web.UI.Design.DesignerAutoFormatCollection AutoFormats { get { throw null; } }
        public override System.Web.UI.Design.TemplateGroupCollection TemplateGroups { get { throw null; } }
        public override string GetDesignTimeHtml() { throw null; }
        public override string GetDesignTimeHtml(System.Web.UI.Design.DesignerRegionCollection regions) { throw null; }
        public override string GetEditableDesignerRegionContent(System.Web.UI.Design.EditableDesignerRegion region) { throw null; }
        protected override string GetEmptyDesignTimeHtml() { throw null; }
        public override void Initialize(System.ComponentModel.IComponent component) { }
        public override void SetEditableDesignerRegionContent(System.Web.UI.Design.EditableDesignerRegion region, string content) { }
    }
    [System.Security.Permissions.SecurityPermissionAttribute(System.Security.Permissions.SecurityAction.Demand, Flags=System.Security.Permissions.SecurityPermissionFlag.UnmanagedCode)]
    public partial class ConnectionsZoneDesigner : System.Web.UI.Design.WebControls.WebParts.ToolZoneDesigner
    {
        public ConnectionsZoneDesigner() { }
        public override System.Web.UI.Design.DesignerAutoFormatCollection AutoFormats { get { throw null; } }
        public override string GetDesignTimeHtml() { throw null; }
        public override void Initialize(System.ComponentModel.IComponent component) { }
        protected override void PreFilterProperties(System.Collections.IDictionary properties) { }
    }
    [System.Security.Permissions.SecurityPermissionAttribute(System.Security.Permissions.SecurityAction.Demand, Flags=System.Security.Permissions.SecurityPermissionFlag.UnmanagedCode)]
    public partial class DeclarativeCatalogPartDesigner : System.Web.UI.Design.WebControls.WebParts.CatalogPartDesigner
    {
        public DeclarativeCatalogPartDesigner() { }
        public override System.Web.UI.Design.TemplateGroupCollection TemplateGroups { get { throw null; } }
        public override string GetDesignTimeHtml() { throw null; }
        protected override string GetEmptyDesignTimeHtml() { throw null; }
        public override void Initialize(System.ComponentModel.IComponent component) { }
    }
    [System.Security.Permissions.SecurityPermissionAttribute(System.Security.Permissions.SecurityAction.Demand, Flags=System.Security.Permissions.SecurityPermissionFlag.UnmanagedCode)]
    public partial class EditorPartDesigner : System.Web.UI.Design.WebControls.WebParts.PartDesigner
    {
        public EditorPartDesigner() { }
        protected override System.Web.UI.Control CreateViewControl() { throw null; }
        public override string GetDesignTimeHtml() { throw null; }
        public override void Initialize(System.ComponentModel.IComponent component) { }
    }
    [System.Security.Permissions.SecurityPermissionAttribute(System.Security.Permissions.SecurityAction.Demand, Flags=System.Security.Permissions.SecurityPermissionFlag.UnmanagedCode)]
    public partial class EditorZoneDesigner : System.Web.UI.Design.WebControls.WebParts.ToolZoneDesigner
    {
        public EditorZoneDesigner() { }
        public override System.Web.UI.Design.DesignerAutoFormatCollection AutoFormats { get { throw null; } }
        public override System.Web.UI.Design.TemplateGroupCollection TemplateGroups { get { throw null; } }
        public override string GetDesignTimeHtml() { throw null; }
        public override string GetDesignTimeHtml(System.Web.UI.Design.DesignerRegionCollection regions) { throw null; }
        public override string GetEditableDesignerRegionContent(System.Web.UI.Design.EditableDesignerRegion region) { throw null; }
        protected override string GetEmptyDesignTimeHtml() { throw null; }
        public override void Initialize(System.ComponentModel.IComponent component) { }
        public override void SetEditableDesignerRegionContent(System.Web.UI.Design.EditableDesignerRegion region, string content) { }
    }
    [System.Security.Permissions.SecurityPermissionAttribute(System.Security.Permissions.SecurityAction.Demand, Flags=System.Security.Permissions.SecurityPermissionFlag.UnmanagedCode)]
    public partial class PageCatalogPartDesigner : System.Web.UI.Design.WebControls.WebParts.CatalogPartDesigner
    {
        public PageCatalogPartDesigner() { }
        public override string GetDesignTimeHtml() { throw null; }
        public override void Initialize(System.ComponentModel.IComponent component) { }
    }
    [System.Security.Permissions.SecurityPermissionAttribute(System.Security.Permissions.SecurityAction.Demand, Flags=System.Security.Permissions.SecurityPermissionFlag.UnmanagedCode)]
    public abstract partial class PartDesigner : System.Web.UI.Design.WebControls.CompositeControlDesigner
    {
        internal PartDesigner() { }
        protected override bool UsePreviewControl { get { throw null; } }
        public override void Initialize(System.ComponentModel.IComponent component) { }
    }
    [System.Security.Permissions.SecurityPermissionAttribute(System.Security.Permissions.SecurityAction.Demand, Flags=System.Security.Permissions.SecurityPermissionFlag.UnmanagedCode)]
    public partial class ProxyWebPartManagerDesigner : System.Web.UI.Design.ControlDesigner
    {
        public ProxyWebPartManagerDesigner() { }
        protected override bool UsePreviewControl { get { throw null; } }
        public override string GetDesignTimeHtml() { throw null; }
        public override void Initialize(System.ComponentModel.IComponent component) { }
    }
    [System.Security.Permissions.SecurityPermissionAttribute(System.Security.Permissions.SecurityAction.Demand, Flags=System.Security.Permissions.SecurityPermissionFlag.UnmanagedCode)]
    public partial class ToolZoneDesigner : System.Web.UI.Design.WebControls.WebParts.WebZoneDesigner
    {
        public ToolZoneDesigner() { }
        public override System.ComponentModel.Design.DesignerActionListCollection ActionLists { get { throw null; } }
        protected bool ViewInBrowseMode { get { throw null; } }
        public override void Initialize(System.ComponentModel.IComponent component) { }
    }
    [System.Security.Permissions.SecurityPermissionAttribute(System.Security.Permissions.SecurityAction.Demand, Flags=System.Security.Permissions.SecurityPermissionFlag.UnmanagedCode)]
    public partial class WebPartDesigner : System.Web.UI.Design.WebControls.WebParts.PartDesigner
    {
        public WebPartDesigner() { }
        public override void Initialize(System.ComponentModel.IComponent component) { }
    }
    [System.Security.Permissions.SecurityPermissionAttribute(System.Security.Permissions.SecurityAction.Demand, Flags=System.Security.Permissions.SecurityPermissionFlag.UnmanagedCode)]
    public partial class WebPartManagerDesigner : System.Web.UI.Design.ControlDesigner
    {
        public WebPartManagerDesigner() { }
        protected override bool UsePreviewControl { get { throw null; } }
        public override string GetDesignTimeHtml() { throw null; }
        public override void Initialize(System.ComponentModel.IComponent component) { }
    }
    [System.Security.Permissions.SecurityPermissionAttribute(System.Security.Permissions.SecurityAction.Demand, Flags=System.Security.Permissions.SecurityPermissionFlag.UnmanagedCode)]
    public partial class WebPartZoneBaseDesigner : System.Web.UI.Design.WebControls.WebParts.WebZoneDesigner
    {
        public WebPartZoneBaseDesigner() { }
        public override void Initialize(System.ComponentModel.IComponent component) { }
        protected override void PreFilterProperties(System.Collections.IDictionary properties) { }
    }
    [System.Security.Permissions.SecurityPermissionAttribute(System.Security.Permissions.SecurityAction.Demand, Flags=System.Security.Permissions.SecurityPermissionFlag.UnmanagedCode)]
    public partial class WebPartZoneDesigner : System.Web.UI.Design.WebControls.WebParts.WebPartZoneBaseDesigner
    {
        public WebPartZoneDesigner() { }
        public override System.Web.UI.Design.DesignerAutoFormatCollection AutoFormats { get { throw null; } }
        public override System.Web.UI.Design.TemplateGroupCollection TemplateGroups { get { throw null; } }
        public override string GetDesignTimeHtml() { throw null; }
        public override string GetDesignTimeHtml(System.Web.UI.Design.DesignerRegionCollection regions) { throw null; }
        public override string GetEditableDesignerRegionContent(System.Web.UI.Design.EditableDesignerRegion region) { throw null; }
        protected override string GetEmptyDesignTimeHtml() { throw null; }
        public override void Initialize(System.ComponentModel.IComponent component) { }
        public override void SetEditableDesignerRegionContent(System.Web.UI.Design.EditableDesignerRegion region, string content) { }
    }
    [System.Security.Permissions.SecurityPermissionAttribute(System.Security.Permissions.SecurityAction.Demand, Flags=System.Security.Permissions.SecurityPermissionFlag.UnmanagedCode)]
    public abstract partial class WebZoneDesigner : System.Web.UI.Design.ControlDesigner
    {
        internal WebZoneDesigner() { }
        protected override bool UsePreviewControl { get { throw null; } }
        public override void Initialize(System.ComponentModel.IComponent component) { }
    }
}
namespace System.Windows.Forms.Design
{
    public sealed partial class AnchorEditor : System.Drawing.Design.UITypeEditor
    {
        public AnchorEditor() { }
        public override object EditValue(System.ComponentModel.ITypeDescriptorContext context, System.IServiceProvider provider, object value) { throw null; }
        public override System.Drawing.Design.UITypeEditorEditStyle GetEditStyle(System.ComponentModel.ITypeDescriptorContext context) { throw null; }
    }
    public partial class AxImporter
    {
        public AxImporter(System.Windows.Forms.Design.AxImporter.Options options) { }
        public string[] GeneratedAssemblies { get { throw null; } }
        public string[] GeneratedSources { get { throw null; } }
        public System.Runtime.InteropServices.TYPELIBATTR[] GeneratedTypeLibAttributes { get { throw null; } }
        public string GenerateFromFile(System.IO.FileInfo file) { throw null; }
        public string GenerateFromTypeLibrary(System.Runtime.InteropServices.UCOMITypeLib typeLib) { throw null; }
        public string GenerateFromTypeLibrary(System.Runtime.InteropServices.UCOMITypeLib typeLib, System.Guid clsid) { throw null; }
        public static string GetFileOfTypeLib(ref System.Runtime.InteropServices.TYPELIBATTR tlibattr) { throw null; }
        public partial interface IReferenceResolver
        {
            string ResolveActiveXReference(System.Runtime.InteropServices.UCOMITypeLib typeLib);
            string ResolveComReference(System.Reflection.AssemblyName name);
            string ResolveComReference(System.Runtime.InteropServices.UCOMITypeLib typeLib);
            string ResolveManagedReference(string assemName);
        }
        public sealed partial class Options
        {
            public bool delaySign;
            public bool genSources;
            public bool ignoreRegisteredOcx;
            public string keyContainer;
            public string keyFile;
            public System.Reflection.StrongNameKeyPair keyPair;
            public bool msBuildErrors;
            public bool noLogo;
            public string outputDirectory;
            public string outputName;
            public bool overwriteRCW;
            public byte[] publicKey;
            public System.Windows.Forms.Design.AxImporter.IReferenceResolver references;
            public bool silentMode;
            public bool verboseMode;
            public Options() { }
        }
    }
    public partial class AxParameterData
    {
        public AxParameterData(System.Reflection.ParameterInfo info) { }
        public AxParameterData(System.Reflection.ParameterInfo info, bool ignoreByRefs) { }
        public AxParameterData(string inname, string typeName) { }
        public AxParameterData(string inname, System.Type type) { }
        public System.CodeDom.FieldDirection Direction { get { throw null; } }
        public bool IsByRef { get { throw null; } }
        public bool IsIn { get { throw null; } }
        public bool IsOptional { get { throw null; } }
        public bool IsOut { get { throw null; } }
        public string Name { get { throw null; } set { } }
        public System.Type ParameterType { get { throw null; } }
        public string TypeName { get { throw null; } }
        public static System.Windows.Forms.Design.AxParameterData[] Convert(System.Reflection.ParameterInfo[] infos) { throw null; }
        public static System.Windows.Forms.Design.AxParameterData[] Convert(System.Reflection.ParameterInfo[] infos, bool ignoreByRefs) { throw null; }
    }
    public partial class AxWrapperGen
    {
        public static System.Collections.ArrayList GeneratedSources;
        public AxWrapperGen(System.Type axType) { }
    }
    [System.Security.Permissions.SecurityPermissionAttribute(System.Security.Permissions.SecurityAction.Demand, Flags=System.Security.Permissions.SecurityPermissionFlag.UnmanagedCode)]
    public partial class BorderSidesEditor : System.Drawing.Design.UITypeEditor
    {
        public BorderSidesEditor() { }
        public override object EditValue(System.ComponentModel.ITypeDescriptorContext context, System.IServiceProvider provider, object value) { throw null; }
        public override System.Drawing.Design.UITypeEditorEditStyle GetEditStyle(System.ComponentModel.ITypeDescriptorContext context) { throw null; }
    }
    public partial class ComponentDocumentDesigner : System.ComponentModel.Design.ComponentDesigner, System.ComponentModel.Design.IDesigner, System.ComponentModel.Design.IRootDesigner, System.ComponentModel.Design.ITypeDescriptorFilterService, System.Drawing.Design.IToolboxUser, System.IDisposable
    {
        public ComponentDocumentDesigner() { }
        public System.Windows.Forms.Control Control { get { throw null; } }
        System.ComponentModel.Design.ViewTechnology[] System.ComponentModel.Design.IRootDesigner.SupportedTechnologies { get { throw null; } }
        public bool TrayAutoArrange { get { throw null; } set { } }
        public bool TrayLargeIcon { get { throw null; } set { } }
        protected override void Dispose(bool disposing) { }
        protected virtual bool GetToolSupported(System.Drawing.Design.ToolboxItem tool) { throw null; }
        public override void Initialize(System.ComponentModel.IComponent component) { }
        protected override void PreFilterProperties(System.Collections.IDictionary properties) { }
        object System.ComponentModel.Design.IRootDesigner.GetView(System.ComponentModel.Design.ViewTechnology technology) { throw null; }
        bool System.ComponentModel.Design.ITypeDescriptorFilterService.FilterAttributes(System.ComponentModel.IComponent component, System.Collections.IDictionary attributes) { throw null; }
        bool System.ComponentModel.Design.ITypeDescriptorFilterService.FilterEvents(System.ComponentModel.IComponent component, System.Collections.IDictionary events) { throw null; }
        bool System.ComponentModel.Design.ITypeDescriptorFilterService.FilterProperties(System.ComponentModel.IComponent component, System.Collections.IDictionary properties) { throw null; }
        bool System.Drawing.Design.IToolboxUser.GetToolSupported(System.Drawing.Design.ToolboxItem tool) { throw null; }
        void System.Drawing.Design.IToolboxUser.ToolPicked(System.Drawing.Design.ToolboxItem tool) { }
    }
    [System.ComponentModel.DesignTimeVisibleAttribute(false)]
    [System.ComponentModel.ProvidePropertyAttribute("Location", typeof(System.ComponentModel.IComponent))]
    [System.ComponentModel.ProvidePropertyAttribute("TrayLocation", typeof(System.ComponentModel.IComponent))]
    [System.ComponentModel.ToolboxItemAttribute(false)]
    public partial class ComponentTray : System.Windows.Forms.ScrollableControl, System.ComponentModel.IExtenderProvider
    {
        public ComponentTray(System.ComponentModel.Design.IDesigner mainDesigner, System.IServiceProvider serviceProvider) { }
        public bool AutoArrange { get { throw null; } set { } }
        public int ComponentCount { get { throw null; } }
        public bool ShowLargeIcons { get { throw null; } set { } }
        public virtual void AddComponent(System.ComponentModel.IComponent component) { }
        protected virtual bool CanCreateComponentFromTool(System.Drawing.Design.ToolboxItem tool) { throw null; }
        protected virtual bool CanDisplayComponent(System.ComponentModel.IComponent component) { throw null; }
        public void CreateComponentFromTool(System.Drawing.Design.ToolboxItem tool) { }
        protected void DisplayError(System.Exception e) { }
        protected override void Dispose(bool disposing) { }
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.CategoryAttribute("Layout")]
        [System.ComponentModel.DesignerSerializationVisibilityAttribute(System.ComponentModel.DesignerSerializationVisibility.Hidden)]
        [System.ComponentModel.DesignOnlyAttribute(true)]
        [System.ComponentModel.LocalizableAttribute(false)]
        public System.Drawing.Point GetLocation(System.ComponentModel.IComponent receiver) { throw null; }
        public System.ComponentModel.IComponent GetNextComponent(System.ComponentModel.IComponent component, bool forward) { throw null; }
        protected override object GetService(System.Type serviceType) { throw null; }
        [System.ComponentModel.BrowsableAttribute(false)]
        [System.ComponentModel.CategoryAttribute("Layout")]
        [System.ComponentModel.DesignOnlyAttribute(true)]
        [System.ComponentModel.LocalizableAttribute(false)]
        public System.Drawing.Point GetTrayLocation(System.ComponentModel.IComponent receiver) { throw null; }
        public bool IsTrayComponent(System.ComponentModel.IComponent comp) { throw null; }
        protected override void OnDragDrop(System.Windows.Forms.DragEventArgs de) { }
        protected override void OnDragEnter(System.Windows.Forms.DragEventArgs de) { }
        protected override void OnDragLeave(System.EventArgs e) { }
        protected override void OnDragOver(System.Windows.Forms.DragEventArgs de) { }
        protected override void OnGiveFeedback(System.Windows.Forms.GiveFeedbackEventArgs gfevent) { }
        protected override void OnLayout(System.Windows.Forms.LayoutEventArgs levent) { }
        protected virtual void OnLostCapture() { }
        protected override void OnMouseDoubleClick(System.Windows.Forms.MouseEventArgs e) { }
        protected override void OnMouseDown(System.Windows.Forms.MouseEventArgs e) { }
        protected override void OnMouseMove(System.Windows.Forms.MouseEventArgs e) { }
        protected override void OnMouseUp(System.Windows.Forms.MouseEventArgs e) { }
        protected override void OnPaint(System.Windows.Forms.PaintEventArgs pe) { }
        protected virtual void OnSetCursor() { }
        public virtual void RemoveComponent(System.ComponentModel.IComponent component) { }
        public void SetLocation(System.ComponentModel.IComponent receiver, System.Drawing.Point location) { }
        public void SetTrayLocation(System.ComponentModel.IComponent receiver, System.Drawing.Point location) { }
        bool System.ComponentModel.IExtenderProvider.CanExtend(object component) { throw null; }
        protected override void WndProc(ref System.Windows.Forms.Message m) { }
    }
    public partial class ControlDesigner : System.ComponentModel.Design.ComponentDesigner
    {
        protected System.Windows.Forms.AccessibleObject accessibilityObj;
        protected static readonly System.Drawing.Point InvalidPoint;
        public ControlDesigner() { }
        public virtual System.Windows.Forms.AccessibleObject AccessibilityObject { get { throw null; } }
        public override System.Collections.ICollection AssociatedComponents { get { throw null; } }
        public bool AutoResizeHandles { get { throw null; } set { } }
        protected System.Windows.Forms.Design.Behavior.BehaviorService BehaviorService { get { throw null; } }
        public virtual System.Windows.Forms.Control Control { get { throw null; } }
        protected virtual bool EnableDragRect { get { throw null; } }
        protected override System.ComponentModel.InheritanceAttribute InheritanceAttribute { get { throw null; } }
        protected override System.ComponentModel.IComponent ParentComponent { get { throw null; } }
        public virtual bool ParticipatesWithSnapLines { get { throw null; } }
        public virtual System.Windows.Forms.Design.SelectionRules SelectionRules { get { throw null; } }
        public virtual System.Collections.IList SnapLines { get { throw null; } }
        protected void BaseWndProc(ref System.Windows.Forms.Message m) { }
        public virtual bool CanBeParentedTo(System.ComponentModel.Design.IDesigner parentDesigner) { throw null; }
        protected void DefWndProc(ref System.Windows.Forms.Message m) { }
        protected void DisplayError(System.Exception e) { }
        protected override void Dispose(bool disposing) { }
        protected bool EnableDesignMode(System.Windows.Forms.Control child, string name) { throw null; }
        protected void EnableDragDrop(bool value) { }
        protected virtual System.Windows.Forms.Design.Behavior.ControlBodyGlyph GetControlGlyph(System.Windows.Forms.Design.Behavior.GlyphSelectionType selectionType) { throw null; }
        public virtual System.Windows.Forms.Design.Behavior.GlyphCollection GetGlyphs(System.Windows.Forms.Design.Behavior.GlyphSelectionType selectionType) { throw null; }
        protected virtual bool GetHitTest(System.Drawing.Point point) { throw null; }
        protected void HookChildControls(System.Windows.Forms.Control firstChild) { }
        public override void Initialize(System.ComponentModel.IComponent component) { }
        public override void InitializeExistingComponent(System.Collections.IDictionary defaultValues) { }
        public override void InitializeNewComponent(System.Collections.IDictionary defaultValues) { }
        public virtual System.Windows.Forms.Design.ControlDesigner InternalControlDesigner(int internalControlIndex) { throw null; }
        public virtual int NumberOfInternalControlDesigners() { throw null; }
        protected virtual void OnContextMenu(int x, int y) { }
        protected virtual void OnCreateHandle() { }
        protected virtual void OnDragComplete(System.Windows.Forms.DragEventArgs de) { }
        protected virtual void OnDragDrop(System.Windows.Forms.DragEventArgs de) { }
        protected virtual void OnDragEnter(System.Windows.Forms.DragEventArgs de) { }
        protected virtual void OnDragLeave(System.EventArgs e) { }
        protected virtual void OnDragOver(System.Windows.Forms.DragEventArgs de) { }
        protected virtual void OnGiveFeedback(System.Windows.Forms.GiveFeedbackEventArgs e) { }
        protected virtual void OnMouseDragBegin(int x, int y) { }
        protected virtual void OnMouseDragEnd(bool cancel) { }
        protected virtual void OnMouseDragMove(int x, int y) { }
        protected virtual void OnMouseEnter() { }
        protected virtual void OnMouseHover() { }
        protected virtual void OnMouseLeave() { }
        protected virtual void OnPaintAdornments(System.Windows.Forms.PaintEventArgs pe) { }
        [System.ObsoleteAttribute("This method has been deprecated. Use InitializeNewComponent instead.  http://go.microsoft.com/fwlink/?linkid=14202")]
        public override void OnSetComponentDefaults() { }
        protected virtual void OnSetCursor() { }
        protected override void PreFilterProperties(System.Collections.IDictionary properties) { }
        protected void UnhookChildControls(System.Windows.Forms.Control firstChild) { }
        protected virtual void WndProc(ref System.Windows.Forms.Message m) { }
        [System.Runtime.InteropServices.ComVisibleAttribute(true)]
        public partial class ControlDesignerAccessibleObject : System.Windows.Forms.AccessibleObject
        {
            public ControlDesignerAccessibleObject(System.Windows.Forms.Design.ControlDesigner designer, System.Windows.Forms.Control control) { }
            public override System.Drawing.Rectangle Bounds { get { throw null; } }
            public override string DefaultAction { get { throw null; } }
            public override string Description { get { throw null; } }
            public override string Name { get { throw null; } }
            public override System.Windows.Forms.AccessibleObject Parent { get { throw null; } }
            public override System.Windows.Forms.AccessibleRole Role { get { throw null; } }
            public override System.Windows.Forms.AccessibleStates State { get { throw null; } }
            public override string Value { get { throw null; } }
            public override System.Windows.Forms.AccessibleObject GetChild(int index) { throw null; }
            public override int GetChildCount() { throw null; }
            public override System.Windows.Forms.AccessibleObject GetFocused() { throw null; }
            public override System.Windows.Forms.AccessibleObject GetSelected() { throw null; }
            public override System.Windows.Forms.AccessibleObject HitTest(int x, int y) { throw null; }
        }
    }
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    public partial class DesignerOptions
    {
        public DesignerOptions() { }
        [System.ComponentModel.BrowsableAttribute(false)]
        public virtual bool EnableInSituEditing { get { throw null; } set { } }
        public virtual System.Drawing.Size GridSize { get { throw null; } set { } }
        public virtual bool ObjectBoundSmartTagAutoShow { get { throw null; } set { } }
        public virtual bool ShowGrid { get { throw null; } set { } }
        public virtual bool SnapToGrid { get { throw null; } set { } }
        public virtual bool UseOptimizedCodeGeneration { get { throw null; } set { } }
        public virtual bool UseSmartTags { get { throw null; } set { } }
        public virtual bool UseSnapLines { get { throw null; } set { } }
    }
    public sealed partial class DockEditor : System.Drawing.Design.UITypeEditor
    {
        public DockEditor() { }
        public override object EditValue(System.ComponentModel.ITypeDescriptorContext context, System.IServiceProvider provider, object value) { throw null; }
        public override System.Drawing.Design.UITypeEditorEditStyle GetEditStyle(System.ComponentModel.ITypeDescriptorContext context) { throw null; }
    }
    [System.ComponentModel.ToolboxItemFilterAttribute("System.Windows.Forms")]
    public partial class DocumentDesigner : System.Windows.Forms.Design.ScrollableControlDesigner, System.ComponentModel.Design.IDesigner, System.ComponentModel.Design.IRootDesigner, System.Drawing.Design.IToolboxUser, System.IDisposable
    {
        protected System.Windows.Forms.Design.IMenuEditorService menuEditorService;
        public DocumentDesigner() { }
        public override System.Windows.Forms.Design.SelectionRules SelectionRules { get { throw null; } }
        System.ComponentModel.Design.ViewTechnology[] System.ComponentModel.Design.IRootDesigner.SupportedTechnologies { get { throw null; } }
        protected override void Dispose(bool disposing) { }
        protected virtual void EnsureMenuEditorService(System.ComponentModel.IComponent c) { }
        public override System.Windows.Forms.Design.Behavior.GlyphCollection GetGlyphs(System.Windows.Forms.Design.Behavior.GlyphSelectionType selectionType) { throw null; }
        protected virtual bool GetToolSupported(System.Drawing.Design.ToolboxItem tool) { throw null; }
        public override void Initialize(System.ComponentModel.IComponent component) { }
        protected override void OnContextMenu(int x, int y) { }
        protected override void OnCreateHandle() { }
        protected override void PreFilterProperties(System.Collections.IDictionary properties) { }
        object System.ComponentModel.Design.IRootDesigner.GetView(System.ComponentModel.Design.ViewTechnology technology) { throw null; }
        bool System.Drawing.Design.IToolboxUser.GetToolSupported(System.Drawing.Design.ToolboxItem tool) { throw null; }
        void System.Drawing.Design.IToolboxUser.ToolPicked(System.Drawing.Design.ToolboxItem tool) { }
        protected virtual void ToolPicked(System.Drawing.Design.ToolboxItem tool) { }
        protected override void WndProc(ref System.Windows.Forms.Message m) { }
    }
    public sealed partial class EventHandlerService
    {
        public EventHandlerService(System.Windows.Forms.Control focusWnd) { }
        public System.Windows.Forms.Control FocusWindow { get { throw null; } }
        public event System.EventHandler EventHandlerChanged { add { } remove { } }
        public object GetHandler(System.Type handlerType) { throw null; }
        public void PopHandler(object handler) { }
        public void PushHandler(object handler) { }
    }
    public partial class FileNameEditor : System.Drawing.Design.UITypeEditor
    {
        public FileNameEditor() { }
        public override object EditValue(System.ComponentModel.ITypeDescriptorContext context, System.IServiceProvider provider, object value) { throw null; }
        public override System.Drawing.Design.UITypeEditorEditStyle GetEditStyle(System.ComponentModel.ITypeDescriptorContext context) { throw null; }
        protected virtual void InitializeDialog(System.Windows.Forms.OpenFileDialog openFileDialog) { }
    }
    public partial class FolderNameEditor : System.Drawing.Design.UITypeEditor
    {
        public FolderNameEditor() { }
        public override object EditValue(System.ComponentModel.ITypeDescriptorContext context, System.IServiceProvider provider, object value) { throw null; }
        public override System.Drawing.Design.UITypeEditorEditStyle GetEditStyle(System.ComponentModel.ITypeDescriptorContext context) { throw null; }
        protected virtual void InitializeDialog(System.Windows.Forms.Design.FolderNameEditor.FolderBrowser folderBrowser) { }
        protected sealed partial class FolderBrowser : System.ComponentModel.Component
        {
            public FolderBrowser() { }
            public string Description { get { throw null; } set { } }
            public string DirectoryPath { get { throw null; } }
            public System.Windows.Forms.Design.FolderNameEditor.FolderBrowserFolder StartLocation { get { throw null; } set { } }
            public System.Windows.Forms.Design.FolderNameEditor.FolderBrowserStyles Style { get { throw null; } set { } }
            public System.Windows.Forms.DialogResult ShowDialog() { throw null; }
            public System.Windows.Forms.DialogResult ShowDialog(System.Windows.Forms.IWin32Window owner) { throw null; }
        }
        protected enum FolderBrowserFolder
        {
            Desktop = 0,
            Favorites = 6,
            MyComputer = 17,
            MyDocuments = 5,
            MyPictures = 39,
            NetAndDialUpConnections = 49,
            NetworkNeighborhood = 18,
            Printers = 4,
            Recent = 8,
            SendTo = 9,
            StartMenu = 11,
            Templates = 21,
        }
        [System.FlagsAttribute]
        protected enum FolderBrowserStyles
        {
            BrowseForComputer = 4096,
            BrowseForEverything = 16384,
            BrowseForPrinter = 8192,
            RestrictToDomain = 2,
            RestrictToFilesystem = 1,
            RestrictToSubfolders = 8,
            ShowTextBox = 16,
        }
    }
    public partial interface IContainsThemedScrollbarWindows
    {
        System.Collections.IEnumerable ThemedScrollbarWindows();
    }
    public partial class ImageListCodeDomSerializer : System.ComponentModel.Design.Serialization.CodeDomSerializer
    {
        public ImageListCodeDomSerializer() { }
        public override object Deserialize(System.ComponentModel.Design.Serialization.IDesignerSerializationManager manager, object codeObject) { throw null; }
        public override object Serialize(System.ComponentModel.Design.Serialization.IDesignerSerializationManager manager, object value) { throw null; }
    }
    public partial class ImageListImageEditor : System.Drawing.Design.ImageEditor
    {
        public ImageListImageEditor() { }
        public override object EditValue(System.ComponentModel.ITypeDescriptorContext context, System.IServiceProvider provider, object value) { throw null; }
        protected override string GetFileDialogDescription() { throw null; }
        protected override System.Type[] GetImageExtenders() { throw null; }
        public override bool GetPaintValueSupported(System.ComponentModel.ITypeDescriptorContext context) { throw null; }
        public override void PaintValue(System.Drawing.Design.PaintValueEventArgs e) { }
    }
    public partial interface IMenuEditorService
    {
        System.Windows.Forms.Menu GetMenu();
        bool IsActive();
        bool MessageFilter(ref System.Windows.Forms.Message m);
        void SetMenu(System.Windows.Forms.Menu menu);
        void SetSelection(System.Windows.Forms.MenuItem item);
    }
    public abstract partial class MaskDescriptor
    {
        protected MaskDescriptor() { }
        public virtual System.Globalization.CultureInfo Culture { get { throw null; } }
        public abstract string Mask { get; }
        public abstract string Name { get; }
        public abstract string Sample { get; }
        public abstract System.Type ValidatingType { get; }
        public override bool Equals(object maskDescriptor) { throw null; }
        public override int GetHashCode() { throw null; }
        public static bool IsValidMaskDescriptor(System.Windows.Forms.Design.MaskDescriptor maskDescriptor) { throw null; }
        public static bool IsValidMaskDescriptor(System.Windows.Forms.Design.MaskDescriptor maskDescriptor, out string validationErrorDescription) { throw null; }
        public override string ToString() { throw null; }
    }
    public sealed partial class MenuCommands : System.ComponentModel.Design.StandardCommands
    {
        public static readonly System.ComponentModel.Design.CommandID ComponentTrayMenu;
        public static readonly System.ComponentModel.Design.CommandID ContainerMenu;
        public static readonly System.ComponentModel.Design.CommandID DesignerProperties;
        public static readonly System.ComponentModel.Design.CommandID EditLabel;
        public static readonly System.ComponentModel.Design.CommandID KeyCancel;
        public static readonly System.ComponentModel.Design.CommandID KeyDefaultAction;
        public static readonly System.ComponentModel.Design.CommandID KeyEnd;
        public static readonly System.ComponentModel.Design.CommandID KeyHome;
        public static readonly System.ComponentModel.Design.CommandID KeyInvokeSmartTag;
        public static readonly System.ComponentModel.Design.CommandID KeyMoveDown;
        public static readonly System.ComponentModel.Design.CommandID KeyMoveLeft;
        public static readonly System.ComponentModel.Design.CommandID KeyMoveRight;
        public static readonly System.ComponentModel.Design.CommandID KeyMoveUp;
        public static readonly System.ComponentModel.Design.CommandID KeyNudgeDown;
        public static readonly System.ComponentModel.Design.CommandID KeyNudgeHeightDecrease;
        public static readonly System.ComponentModel.Design.CommandID KeyNudgeHeightIncrease;
        public static readonly System.ComponentModel.Design.CommandID KeyNudgeLeft;
        public static readonly System.ComponentModel.Design.CommandID KeyNudgeRight;
        public static readonly System.ComponentModel.Design.CommandID KeyNudgeUp;
        public static readonly System.ComponentModel.Design.CommandID KeyNudgeWidthDecrease;
        public static readonly System.ComponentModel.Design.CommandID KeyNudgeWidthIncrease;
        public static readonly System.ComponentModel.Design.CommandID KeyReverseCancel;
        public static readonly System.ComponentModel.Design.CommandID KeySelectNext;
        public static readonly System.ComponentModel.Design.CommandID KeySelectPrevious;
        public static readonly System.ComponentModel.Design.CommandID KeyShiftEnd;
        public static readonly System.ComponentModel.Design.CommandID KeyShiftHome;
        public static readonly System.ComponentModel.Design.CommandID KeySizeHeightDecrease;
        public static readonly System.ComponentModel.Design.CommandID KeySizeHeightIncrease;
        public static readonly System.ComponentModel.Design.CommandID KeySizeWidthDecrease;
        public static readonly System.ComponentModel.Design.CommandID KeySizeWidthIncrease;
        public static readonly System.ComponentModel.Design.CommandID KeyTabOrderSelect;
        public static readonly System.ComponentModel.Design.CommandID SelectionMenu;
        public static readonly System.ComponentModel.Design.CommandID SetStatusRectangle;
        public static readonly System.ComponentModel.Design.CommandID SetStatusText;
        public static readonly System.ComponentModel.Design.CommandID TraySelectionMenu;
        public MenuCommands() { }
    }
    public partial class ParentControlDesigner : System.Windows.Forms.Design.ControlDesigner
    {
        public ParentControlDesigner() { }
        protected virtual bool AllowControlLasso { get { throw null; } }
        protected virtual bool AllowGenericDragBox { get { throw null; } }
        protected internal virtual bool AllowSetChildIndexOnDrop { get { throw null; } }
        protected virtual System.Drawing.Point DefaultControlLocation { get { throw null; } }
        protected virtual bool DrawGrid { get { throw null; } set { } }
        protected override bool EnableDragRect { get { throw null; } }
        protected System.Drawing.Size GridSize { get { throw null; } set { } }
        protected System.Drawing.Design.ToolboxItem MouseDragTool { get { throw null; } }
        public override System.Collections.IList SnapLines { get { throw null; } }
        protected void AddPaddingSnapLines(ref System.Collections.ArrayList snapLines) { }
        protected internal virtual bool CanAddComponent(System.ComponentModel.IComponent component) { throw null; }
        public virtual bool CanParent(System.Windows.Forms.Control control) { throw null; }
        public virtual bool CanParent(System.Windows.Forms.Design.ControlDesigner controlDesigner) { throw null; }
        protected void CreateTool(System.Drawing.Design.ToolboxItem tool) { }
        protected void CreateTool(System.Drawing.Design.ToolboxItem tool, System.Drawing.Point location) { }
        protected void CreateTool(System.Drawing.Design.ToolboxItem tool, System.Drawing.Rectangle bounds) { }
        protected virtual System.ComponentModel.IComponent[] CreateToolCore(System.Drawing.Design.ToolboxItem tool, int x, int y, int width, int height, bool hasLocation, bool hasSize) { throw null; }
        protected override void Dispose(bool disposing) { }
        protected System.Windows.Forms.Control GetControl(object component) { throw null; }
        protected override System.Windows.Forms.Design.Behavior.ControlBodyGlyph GetControlGlyph(System.Windows.Forms.Design.Behavior.GlyphSelectionType selectionType) { throw null; }
        public override System.Windows.Forms.Design.Behavior.GlyphCollection GetGlyphs(System.Windows.Forms.Design.Behavior.GlyphSelectionType selectionType) { throw null; }
        protected virtual System.Windows.Forms.Control GetParentForComponent(System.ComponentModel.IComponent component) { throw null; }
        protected System.Drawing.Rectangle GetUpdatedRect(System.Drawing.Rectangle originalRect, System.Drawing.Rectangle dragRect, bool updateSize) { throw null; }
        public override void Initialize(System.ComponentModel.IComponent component) { }
        public override void InitializeNewComponent(System.Collections.IDictionary defaultValues) { }
        protected static void InvokeCreateTool(System.Windows.Forms.Design.ParentControlDesigner toInvoke, System.Drawing.Design.ToolboxItem tool) { }
        protected override void OnDragComplete(System.Windows.Forms.DragEventArgs de) { }
        protected override void OnDragDrop(System.Windows.Forms.DragEventArgs de) { }
        protected override void OnDragEnter(System.Windows.Forms.DragEventArgs de) { }
        protected override void OnDragLeave(System.EventArgs e) { }
        protected override void OnDragOver(System.Windows.Forms.DragEventArgs de) { }
        protected override void OnMouseDragBegin(int x, int y) { }
        protected override void OnMouseDragEnd(bool cancel) { }
        protected override void OnMouseDragMove(int x, int y) { }
        protected override void OnPaintAdornments(System.Windows.Forms.PaintEventArgs pe) { }
        protected override void OnSetCursor() { }
        protected override void PreFilterProperties(System.Collections.IDictionary properties) { }
    }
    public partial class ScrollableControlDesigner : System.Windows.Forms.Design.ParentControlDesigner
    {
        public ScrollableControlDesigner() { }
        protected override bool GetHitTest(System.Drawing.Point pt) { throw null; }
        protected override void WndProc(ref System.Windows.Forms.Message m) { }
    }
    [System.FlagsAttribute]
    public enum SelectionRules
    {
        AllSizeable = 15,
        BottomSizeable = 2,
        LeftSizeable = 4,
        Locked = -2147483648,
        Moveable = 268435456,
        None = 0,
        RightSizeable = 8,
        TopSizeable = 1,
        Visible = 1073741824,
    }
    [System.Security.SecurityCriticalAttribute]
    [System.Security.Permissions.SecurityPermissionAttribute(System.Security.Permissions.SecurityAction.Demand, Flags=System.Security.Permissions.SecurityPermissionFlag.UnmanagedCode)]
    public partial class ShortcutKeysEditor : System.Drawing.Design.UITypeEditor
    {
        public ShortcutKeysEditor() { }
        public override object EditValue(System.ComponentModel.ITypeDescriptorContext context, System.IServiceProvider provider, object value) { throw null; }
        public override System.Drawing.Design.UITypeEditorEditStyle GetEditStyle(System.ComponentModel.ITypeDescriptorContext context) { throw null; }
    }
    public enum ThemedScrollbarMode
    {
        All = 1,
        None = 2,
        OnlyTopLevel = 3,
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public partial struct ThemedScrollbarWindow
    {
        public System.IntPtr Handle;
        public System.Windows.Forms.Design.ThemedScrollbarMode Mode;
    }
    public partial class WindowsFormsDesignerOptionService : System.ComponentModel.Design.DesignerOptionService
    {
        public WindowsFormsDesignerOptionService() { }
        public virtual System.Windows.Forms.Design.DesignerOptions CompatibilityOptions { get { throw null; } }
        protected override void PopulateOptionCollection(System.ComponentModel.Design.DesignerOptionService.DesignerOptionCollection options) { }
    }
}
namespace System.Windows.Forms.Design.Behavior
{
    public sealed partial class Adorner
    {
        public Adorner() { }
        public System.Windows.Forms.Design.Behavior.BehaviorService BehaviorService { get { throw null; } set { } }
        public bool Enabled { get { throw null; } set { } }
        public System.Windows.Forms.Design.Behavior.GlyphCollection Glyphs { get { throw null; } }
        public void Invalidate() { }
        public void Invalidate(System.Drawing.Rectangle rectangle) { }
        public void Invalidate(System.Drawing.Region region) { }
    }
    public abstract partial class Behavior
    {
        protected Behavior() { }
        protected Behavior(bool callParentBehavior, System.Windows.Forms.Design.Behavior.BehaviorService behaviorService) { }
        public virtual System.Windows.Forms.Cursor Cursor { get { throw null; } }
        public virtual bool DisableAllCommands { get { throw null; } }
        public virtual System.ComponentModel.Design.MenuCommand FindCommand(System.ComponentModel.Design.CommandID commandId) { throw null; }
        public virtual void OnDragDrop(System.Windows.Forms.Design.Behavior.Glyph g, System.Windows.Forms.DragEventArgs e) { }
        public virtual void OnDragEnter(System.Windows.Forms.Design.Behavior.Glyph g, System.Windows.Forms.DragEventArgs e) { }
        public virtual void OnDragLeave(System.Windows.Forms.Design.Behavior.Glyph g, System.EventArgs e) { }
        public virtual void OnDragOver(System.Windows.Forms.Design.Behavior.Glyph g, System.Windows.Forms.DragEventArgs e) { }
        public virtual void OnGiveFeedback(System.Windows.Forms.Design.Behavior.Glyph g, System.Windows.Forms.GiveFeedbackEventArgs e) { }
        public virtual void OnLoseCapture(System.Windows.Forms.Design.Behavior.Glyph g, System.EventArgs e) { }
        public virtual bool OnMouseDoubleClick(System.Windows.Forms.Design.Behavior.Glyph g, System.Windows.Forms.MouseButtons button, System.Drawing.Point mouseLoc) { throw null; }
        public virtual bool OnMouseDown(System.Windows.Forms.Design.Behavior.Glyph g, System.Windows.Forms.MouseButtons button, System.Drawing.Point mouseLoc) { throw null; }
        public virtual bool OnMouseEnter(System.Windows.Forms.Design.Behavior.Glyph g) { throw null; }
        public virtual bool OnMouseHover(System.Windows.Forms.Design.Behavior.Glyph g, System.Drawing.Point mouseLoc) { throw null; }
        public virtual bool OnMouseLeave(System.Windows.Forms.Design.Behavior.Glyph g) { throw null; }
        public virtual bool OnMouseMove(System.Windows.Forms.Design.Behavior.Glyph g, System.Windows.Forms.MouseButtons button, System.Drawing.Point mouseLoc) { throw null; }
        public virtual bool OnMouseUp(System.Windows.Forms.Design.Behavior.Glyph g, System.Windows.Forms.MouseButtons button) { throw null; }
        public virtual void OnQueryContinueDrag(System.Windows.Forms.Design.Behavior.Glyph g, System.Windows.Forms.QueryContinueDragEventArgs e) { }
    }
    public partial class BehaviorDragDropEventArgs : System.EventArgs
    {
        public BehaviorDragDropEventArgs(System.Collections.ICollection dragComponents) { }
        public System.Collections.ICollection DragComponents { get { throw null; } }
    }
    public delegate void BehaviorDragDropEventHandler(object sender, System.Windows.Forms.Design.Behavior.BehaviorDragDropEventArgs e);
    public sealed partial class BehaviorService : System.IDisposable
    {
        internal BehaviorService() { }
        public System.Windows.Forms.Design.Behavior.BehaviorServiceAdornerCollection Adorners { get { throw null; } }
        public System.Drawing.Graphics AdornerWindowGraphics { get { throw null; } }
        public System.Windows.Forms.Design.Behavior.Behavior CurrentBehavior { get { throw null; } }
        public event System.Windows.Forms.Design.Behavior.BehaviorDragDropEventHandler BeginDrag { add { } remove { } }
        public event System.Windows.Forms.Design.Behavior.BehaviorDragDropEventHandler EndDrag { add { } remove { } }
        public event System.EventHandler Synchronize { add { } remove { } }
        public System.Drawing.Point AdornerWindowPointToScreen(System.Drawing.Point p) { throw null; }
        public System.Drawing.Point AdornerWindowToScreen() { throw null; }
        public System.Drawing.Rectangle ControlRectInAdornerWindow(System.Windows.Forms.Control c) { throw null; }
        public System.Drawing.Point ControlToAdornerWindow(System.Windows.Forms.Control c) { throw null; }
        public void Dispose() { }
        public System.Windows.Forms.Design.Behavior.Behavior GetNextBehavior(System.Windows.Forms.Design.Behavior.Behavior behavior) { throw null; }
        public void Invalidate() { }
        public void Invalidate(System.Drawing.Rectangle rect) { }
        public void Invalidate(System.Drawing.Region r) { }
        public System.Drawing.Point MapAdornerWindowPoint(System.IntPtr handle, System.Drawing.Point pt) { throw null; }
        public System.Windows.Forms.Design.Behavior.Behavior PopBehavior(System.Windows.Forms.Design.Behavior.Behavior behavior) { throw null; }
        public void PushBehavior(System.Windows.Forms.Design.Behavior.Behavior behavior) { }
        public void PushCaptureBehavior(System.Windows.Forms.Design.Behavior.Behavior behavior) { }
        public System.Drawing.Point ScreenToAdornerWindow(System.Drawing.Point p) { throw null; }
        public void SyncSelection() { }
    }
    public sealed partial class BehaviorServiceAdornerCollection : System.Collections.CollectionBase
    {
        public BehaviorServiceAdornerCollection(System.Windows.Forms.Design.Behavior.Adorner[] value) { }
        public BehaviorServiceAdornerCollection(System.Windows.Forms.Design.Behavior.BehaviorService behaviorService) { }
        public BehaviorServiceAdornerCollection(System.Windows.Forms.Design.Behavior.BehaviorServiceAdornerCollection value) { }
        public System.Windows.Forms.Design.Behavior.Adorner this[int index] { get { throw null; } set { } }
        public int Add(System.Windows.Forms.Design.Behavior.Adorner value) { throw null; }
        public void AddRange(System.Windows.Forms.Design.Behavior.Adorner[] value) { }
        public void AddRange(System.Windows.Forms.Design.Behavior.BehaviorServiceAdornerCollection value) { }
        public bool Contains(System.Windows.Forms.Design.Behavior.Adorner value) { throw null; }
        public void CopyTo(System.Windows.Forms.Design.Behavior.Adorner[] array, int index) { }
        public new System.Windows.Forms.Design.Behavior.BehaviorServiceAdornerCollectionEnumerator GetEnumerator() { throw null; }
        public int IndexOf(System.Windows.Forms.Design.Behavior.Adorner value) { throw null; }
        public void Insert(int index, System.Windows.Forms.Design.Behavior.Adorner value) { }
        public void Remove(System.Windows.Forms.Design.Behavior.Adorner value) { }
    }
    public partial class BehaviorServiceAdornerCollectionEnumerator : System.Collections.IEnumerator
    {
        public BehaviorServiceAdornerCollectionEnumerator(System.Windows.Forms.Design.Behavior.BehaviorServiceAdornerCollection mappings) { }
        public System.Windows.Forms.Design.Behavior.Adorner Current { get { throw null; } }
        object System.Collections.IEnumerator.Current { get { throw null; } }
        public bool MoveNext() { throw null; }
        public void Reset() { }
        bool System.Collections.IEnumerator.MoveNext() { throw null; }
        void System.Collections.IEnumerator.Reset() { }
    }
    public partial class ComponentGlyph : System.Windows.Forms.Design.Behavior.Glyph
    {
        public ComponentGlyph(System.ComponentModel.IComponent relatedComponent) : base (default(System.Windows.Forms.Design.Behavior.Behavior)) { }
        public ComponentGlyph(System.ComponentModel.IComponent relatedComponent, System.Windows.Forms.Design.Behavior.Behavior behavior) : base (default(System.Windows.Forms.Design.Behavior.Behavior)) { }
        public System.ComponentModel.IComponent RelatedComponent { get { throw null; } }
        public override System.Windows.Forms.Cursor GetHitTest(System.Drawing.Point p) { throw null; }
        public override void Paint(System.Windows.Forms.PaintEventArgs pe) { }
    }
    public partial class ControlBodyGlyph : System.Windows.Forms.Design.Behavior.ComponentGlyph
    {
        public ControlBodyGlyph(System.Drawing.Rectangle bounds, System.Windows.Forms.Cursor cursor, System.ComponentModel.IComponent relatedComponent, System.Windows.Forms.Design.Behavior.Behavior behavior) : base (default(System.ComponentModel.IComponent), default(System.Windows.Forms.Design.Behavior.Behavior)) { }
        public ControlBodyGlyph(System.Drawing.Rectangle bounds, System.Windows.Forms.Cursor cursor, System.ComponentModel.IComponent relatedComponent, System.Windows.Forms.Design.ControlDesigner designer) : base (default(System.ComponentModel.IComponent), default(System.Windows.Forms.Design.Behavior.Behavior)) { }
        public override System.Drawing.Rectangle Bounds { get { throw null; } }
        public override System.Windows.Forms.Cursor GetHitTest(System.Drawing.Point p) { throw null; }
    }
    public abstract partial class Glyph
    {
        protected Glyph(System.Windows.Forms.Design.Behavior.Behavior behavior) { }
        public virtual System.Windows.Forms.Design.Behavior.Behavior Behavior { get { throw null; } }
        public virtual System.Drawing.Rectangle Bounds { get { throw null; } }
        public abstract System.Windows.Forms.Cursor GetHitTest(System.Drawing.Point p);
        public abstract void Paint(System.Windows.Forms.PaintEventArgs pe);
        protected void SetBehavior(System.Windows.Forms.Design.Behavior.Behavior behavior) { }
    }
    public partial class GlyphCollection : System.Collections.CollectionBase
    {
        public GlyphCollection() { }
        public GlyphCollection(System.Windows.Forms.Design.Behavior.GlyphCollection value) { }
        public GlyphCollection(System.Windows.Forms.Design.Behavior.Glyph[] value) { }
        public System.Windows.Forms.Design.Behavior.Glyph this[int index] { get { throw null; } set { } }
        public int Add(System.Windows.Forms.Design.Behavior.Glyph value) { throw null; }
        public void AddRange(System.Windows.Forms.Design.Behavior.GlyphCollection value) { }
        public void AddRange(System.Windows.Forms.Design.Behavior.Glyph[] value) { }
        public bool Contains(System.Windows.Forms.Design.Behavior.Glyph value) { throw null; }
        public void CopyTo(System.Windows.Forms.Design.Behavior.Glyph[] array, int index) { }
        public int IndexOf(System.Windows.Forms.Design.Behavior.Glyph value) { throw null; }
        public void Insert(int index, System.Windows.Forms.Design.Behavior.Glyph value) { }
        public void Remove(System.Windows.Forms.Design.Behavior.Glyph value) { }
    }
    public enum GlyphSelectionType
    {
        NotSelected = 0,
        Selected = 1,
        SelectedPrimary = 2,
    }
    public sealed partial class SnapLine
    {
        public SnapLine(System.Windows.Forms.Design.Behavior.SnapLineType type, int offset) { }
        public SnapLine(System.Windows.Forms.Design.Behavior.SnapLineType type, int offset, string filter) { }
        public SnapLine(System.Windows.Forms.Design.Behavior.SnapLineType type, int offset, string filter, System.Windows.Forms.Design.Behavior.SnapLinePriority priority) { }
        public SnapLine(System.Windows.Forms.Design.Behavior.SnapLineType type, int offset, System.Windows.Forms.Design.Behavior.SnapLinePriority priority) { }
        public string Filter { get { throw null; } }
        public bool IsHorizontal { get { throw null; } }
        public bool IsVertical { get { throw null; } }
        public int Offset { get { throw null; } }
        public System.Windows.Forms.Design.Behavior.SnapLinePriority Priority { get { throw null; } }
        public System.Windows.Forms.Design.Behavior.SnapLineType SnapLineType { get { throw null; } }
        public void AdjustOffset(int adjustment) { }
        public static bool ShouldSnap(System.Windows.Forms.Design.Behavior.SnapLine line1, System.Windows.Forms.Design.Behavior.SnapLine line2) { throw null; }
        public override string ToString() { throw null; }
    }
    public enum SnapLinePriority
    {
        Always = 4,
        High = 3,
        Low = 1,
        Medium = 2,
    }
    public enum SnapLineType
    {
        Baseline = 6,
        Bottom = 1,
        Horizontal = 4,
        Left = 2,
        Right = 3,
        Top = 0,
        Vertical = 5,
    }
}
