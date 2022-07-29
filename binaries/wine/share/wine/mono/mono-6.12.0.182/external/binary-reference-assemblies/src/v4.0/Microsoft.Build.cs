// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

[assembly:System.Reflection.AssemblyVersionAttribute("4.0.0.0")]
[assembly:System.CLSCompliantAttribute(true)]
[assembly:System.Reflection.AssemblyCompanyAttribute("Mono development team")]
[assembly:System.Reflection.AssemblyCopyrightAttribute("(c) Various Mono authors")]
[assembly:System.Reflection.AssemblyDefaultAliasAttribute("Microsoft.Build.dll")]
[assembly:System.Reflection.AssemblyDescriptionAttribute("Microsoft.Build.dll")]
[assembly:System.Reflection.AssemblyFileVersionAttribute("4.0.30319.1")]
[assembly:System.Reflection.AssemblyInformationalVersionAttribute("4.0.30319.1")]
[assembly:System.Reflection.AssemblyProductAttribute("Mono Common Language Infrastructure")]
[assembly:System.Reflection.AssemblyTitleAttribute("Microsoft.Build.dll")]
[assembly:System.Resources.NeutralResourcesLanguageAttribute("en-US")]
[assembly:System.Resources.SatelliteContractVersionAttribute("4.0.0.0")]
[assembly:System.Runtime.CompilerServices.CompilationRelaxationsAttribute((System.Runtime.CompilerServices.CompilationRelaxations)(8))]
[assembly:System.Runtime.CompilerServices.ReferenceAssemblyAttribute]
[assembly:System.Runtime.CompilerServices.RuntimeCompatibilityAttribute(WrapNonExceptionThrows=true)]
[assembly:System.Runtime.InteropServices.ComVisibleAttribute(false)]
namespace Microsoft.Build.Construction
{
    [System.Diagnostics.DebuggerDisplayAttribute("ProjectChooseElement (#Children={Count} HasOtherwise={OtherwiseElement != null})")]
    public partial class ProjectChooseElement : Microsoft.Build.Construction.ProjectElementContainer
    {
        internal ProjectChooseElement() { }
        public override string Condition { get { throw null; } set { } }
        public Microsoft.Build.Construction.ProjectOtherwiseElement OtherwiseElement { get { throw null; } }
        public System.Collections.Generic.ICollection<Microsoft.Build.Construction.ProjectWhenElement> WhenElements { get { throw null; } }
    }
    public abstract partial class ProjectElement
    {
        internal ProjectElement() { }
        public System.Collections.Generic.IEnumerable<Microsoft.Build.Construction.ProjectElementContainer> AllParents { get { throw null; } }
        public virtual string Condition { get { throw null; } set { } }
        public Microsoft.Build.Construction.ProjectRootElement ContainingProject { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        public string Label { get { throw null; } set { } }
        public Microsoft.Build.Construction.ProjectElement NextSibling { get { throw null; } }
        public Microsoft.Build.Construction.ProjectElementContainer Parent { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        public Microsoft.Build.Construction.ProjectElement PreviousSibling { get { throw null; } }
    }
    public abstract partial class ProjectElementContainer : Microsoft.Build.Construction.ProjectElement
    {
        internal ProjectElementContainer() { }
        public System.Collections.Generic.IEnumerable<Microsoft.Build.Construction.ProjectElement> AllChildren { get { throw null; } }
        public System.Collections.Generic.ICollection<Microsoft.Build.Construction.ProjectElement> Children { get { throw null; } }
        public System.Collections.Generic.ICollection<Microsoft.Build.Construction.ProjectElement> ChildrenReversed { get { throw null; } }
        public int Count { get { throw null; } }
        public Microsoft.Build.Construction.ProjectElement FirstChild { get { throw null; } }
        public Microsoft.Build.Construction.ProjectElement LastChild { get { throw null; } }
        public void AppendChild(Microsoft.Build.Construction.ProjectElement child) { }
        public void InsertAfterChild(Microsoft.Build.Construction.ProjectElement child, Microsoft.Build.Construction.ProjectElement reference) { }
        public void InsertBeforeChild(Microsoft.Build.Construction.ProjectElement child, Microsoft.Build.Construction.ProjectElement reference) { }
        public void PrependChild(Microsoft.Build.Construction.ProjectElement child) { }
        public void RemoveAllChildren() { }
        public void RemoveChild(Microsoft.Build.Construction.ProjectElement child) { }
    }
    public partial class ProjectExtensionsElement : Microsoft.Build.Construction.ProjectElement
    {
        internal ProjectExtensionsElement() { }
        public override string Condition { get { throw null; } set { } }
        public string Content { get { throw null; } set { } }
        public string this[string name] { get { throw null; } set { } }
    }
    [System.Diagnostics.DebuggerDisplayAttribute("Project={Project} Condition={Condition}")]
    public partial class ProjectImportElement : Microsoft.Build.Construction.ProjectElement
    {
        internal ProjectImportElement() { }
        public string Project { get { throw null; } set { } }
    }
    [System.Diagnostics.DebuggerDisplayAttribute("#Imports={Count} Condition={Condition} Label={Label}")]
    public partial class ProjectImportGroupElement : Microsoft.Build.Construction.ProjectElementContainer
    {
        internal ProjectImportGroupElement() { }
        public System.Collections.Generic.ICollection<Microsoft.Build.Construction.ProjectImportElement> Imports { get { throw null; } }
        public Microsoft.Build.Construction.ProjectImportElement AddImport(string project) { throw null; }
    }
    [System.Diagnostics.DebuggerDisplayAttribute("{ItemType} #Metadata={Count} Condition={Condition}")]
    public partial class ProjectItemDefinitionElement : Microsoft.Build.Construction.ProjectElementContainer
    {
        internal ProjectItemDefinitionElement() { }
        public string ItemType { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        public System.Collections.Generic.ICollection<Microsoft.Build.Construction.ProjectMetadataElement> Metadata { get { throw null; } }
        public Microsoft.Build.Construction.ProjectMetadataElement AddMetadata(string name, string unevaluatedValue) { throw null; }
    }
    [System.Diagnostics.DebuggerDisplayAttribute("#ItemDefinitions={Count} Condition={Condition} Label={Label}")]
    public partial class ProjectItemDefinitionGroupElement : Microsoft.Build.Construction.ProjectElementContainer
    {
        internal ProjectItemDefinitionGroupElement() { }
        public System.Collections.Generic.ICollection<Microsoft.Build.Construction.ProjectItemDefinitionElement> ItemDefinitions { get { throw null; } }
        public Microsoft.Build.Construction.ProjectItemDefinitionElement AddItemDefinition(string itemType) { throw null; }
    }
    [System.Diagnostics.DebuggerDisplayAttribute("{ItemType} Include={Include} Exclude={Exclude} #Metadata={Count} Condition={Condition}")]
    public partial class ProjectItemElement : Microsoft.Build.Construction.ProjectElementContainer
    {
        internal ProjectItemElement() { }
        public string Exclude { get { throw null; } set { } }
        public bool HasMetadata { get { throw null; } }
        public string Include { get { throw null; } set { } }
        public string ItemType { get { throw null; } set { } }
        public System.Collections.Generic.ICollection<Microsoft.Build.Construction.ProjectMetadataElement> Metadata { get { throw null; } }
        public string Remove { get { throw null; } set { } }
        public Microsoft.Build.Construction.ProjectMetadataElement AddMetadata(string name, string unevaluatedValue) { throw null; }
    }
    [System.Diagnostics.DebuggerDisplayAttribute("#Items={Count} Condition={Condition} Label={Label}")]
    public partial class ProjectItemGroupElement : Microsoft.Build.Construction.ProjectElementContainer
    {
        internal ProjectItemGroupElement() { }
        public System.Collections.Generic.ICollection<Microsoft.Build.Construction.ProjectItemElement> Items { get { throw null; } }
        public Microsoft.Build.Construction.ProjectItemElement AddItem(string itemType, string include) { throw null; }
        public Microsoft.Build.Construction.ProjectItemElement AddItem(string itemType, string include, System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<string, string>> metadata) { throw null; }
    }
    [System.Diagnostics.DebuggerDisplayAttribute("{Name} Value={Value} Condition={Condition}")]
    public partial class ProjectMetadataElement : Microsoft.Build.Construction.ProjectElement
    {
        internal ProjectMetadataElement() { }
        public string Name { get { throw null; } set { } }
        public string Value { get { throw null; } set { } }
    }
    [System.Diagnostics.DebuggerDisplayAttribute("ExecuteTargets={ExecuteTargets}")]
    public partial class ProjectOnErrorElement : Microsoft.Build.Construction.ProjectElement
    {
        internal ProjectOnErrorElement() { }
        public string ExecuteTargetsAttribute { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    }
    [System.Diagnostics.DebuggerDisplayAttribute("#Children={Count}")]
    public partial class ProjectOtherwiseElement : Microsoft.Build.Construction.ProjectElementContainer
    {
        internal ProjectOtherwiseElement() { }
        public System.Collections.Generic.ICollection<Microsoft.Build.Construction.ProjectChooseElement> ChooseElements { get { throw null; } }
        public override string Condition { get { throw null; } set { } }
        public System.Collections.Generic.ICollection<Microsoft.Build.Construction.ProjectItemGroupElement> ItemGroups { get { throw null; } }
        public System.Collections.Generic.ICollection<Microsoft.Build.Construction.ProjectPropertyGroupElement> PropertyGroups { get { throw null; } }
    }
    [System.Diagnostics.DebuggerDisplayAttribute("Name={Name} TaskParameter={TaskParameter} ItemName={ItemName} PropertyName={PropertyName} Condition={Condition}")]
    public partial class ProjectOutputElement : Microsoft.Build.Construction.ProjectElement
    {
        internal ProjectOutputElement() { }
        public bool IsOutputItem { get { throw null; } }
        public bool IsOutputProperty { get { throw null; } }
        public string ItemType { get { throw null; } set { } }
        public string PropertyName { get { throw null; } set { } }
        public string TaskParameter { get { throw null; } set { } }
    }
    [System.Diagnostics.DebuggerDisplayAttribute("{Name} Value={Value} Condition={Condition}")]
    public partial class ProjectPropertyElement : Microsoft.Build.Construction.ProjectElement
    {
        internal ProjectPropertyElement() { }
        public string Name { get { throw null; } set { } }
        public string Value { get { throw null; } set { } }
    }
    [System.Diagnostics.DebuggerDisplayAttribute("#Properties={Count} Condition={Condition} Label={Label}")]
    public partial class ProjectPropertyGroupElement : Microsoft.Build.Construction.ProjectElementContainer
    {
        internal ProjectPropertyGroupElement() { }
        public System.Collections.Generic.ICollection<Microsoft.Build.Construction.ProjectPropertyElement> Properties { get { throw null; } }
        public System.Collections.Generic.ICollection<Microsoft.Build.Construction.ProjectPropertyElement> PropertiesReversed { get { throw null; } }
        public Microsoft.Build.Construction.ProjectPropertyElement AddProperty(string name, string unevaluatedValue) { throw null; }
        public Microsoft.Build.Construction.ProjectPropertyElement SetProperty(string name, string unevaluatedValue) { throw null; }
    }
    [System.Diagnostics.DebuggerDisplayAttribute("{FullPath} #Children={Count} DefaultTargets={DefaultTargets} ToolsVersion={ToolsVersion} InitialTargets={InitialTargets}")]
    public partial class ProjectRootElement : Microsoft.Build.Construction.ProjectElementContainer
    {
        internal ProjectRootElement() { }
        public System.Collections.Generic.ICollection<Microsoft.Build.Construction.ProjectChooseElement> ChooseElements { get { throw null; } }
        public override string Condition { get { throw null; } set { } }
        public string DefaultTargets { get { throw null; } set { } }
        public string DirectoryPath { get { throw null; } set { } }
        public System.Text.Encoding Encoding { get { throw null; } }
        public string FullPath { get { throw null; } set { } }
        public bool HasUnsavedChanges { get { throw null; } }
        public System.Collections.Generic.ICollection<Microsoft.Build.Construction.ProjectImportGroupElement> ImportGroups { get { throw null; } }
        public System.Collections.Generic.ICollection<Microsoft.Build.Construction.ProjectImportGroupElement> ImportGroupsReversed { get { throw null; } }
        public System.Collections.Generic.ICollection<Microsoft.Build.Construction.ProjectImportElement> Imports { get { throw null; } }
        public string InitialTargets { get { throw null; } set { } }
        public System.Collections.Generic.ICollection<Microsoft.Build.Construction.ProjectItemDefinitionGroupElement> ItemDefinitionGroups { get { throw null; } }
        public System.Collections.Generic.ICollection<Microsoft.Build.Construction.ProjectItemDefinitionGroupElement> ItemDefinitionGroupsReversed { get { throw null; } }
        public System.Collections.Generic.ICollection<Microsoft.Build.Construction.ProjectItemDefinitionElement> ItemDefinitions { get { throw null; } }
        public System.Collections.Generic.ICollection<Microsoft.Build.Construction.ProjectItemGroupElement> ItemGroups { get { throw null; } }
        public System.Collections.Generic.ICollection<Microsoft.Build.Construction.ProjectItemGroupElement> ItemGroupsReversed { get { throw null; } }
        public System.Collections.Generic.ICollection<Microsoft.Build.Construction.ProjectItemElement> Items { get { throw null; } }
        public System.DateTime LastWriteTimeWhenRead { get { throw null; } }
        public System.Collections.Generic.ICollection<Microsoft.Build.Construction.ProjectPropertyElement> Properties { get { throw null; } }
        public System.Collections.Generic.ICollection<Microsoft.Build.Construction.ProjectPropertyGroupElement> PropertyGroups { get { throw null; } }
        public System.Collections.Generic.ICollection<Microsoft.Build.Construction.ProjectPropertyGroupElement> PropertyGroupsReversed { get { throw null; } }
        public string RawXml { get { throw null; } }
        public System.Collections.Generic.ICollection<Microsoft.Build.Construction.ProjectTargetElement> Targets { get { throw null; } }
        public System.DateTime TimeLastChanged { get { throw null; } }
        public string ToolsVersion { get { throw null; } set { } }
        public System.Collections.Generic.ICollection<Microsoft.Build.Construction.ProjectUsingTaskElement> UsingTasks { get { throw null; } }
        public int Version { get { throw null; } }
        public Microsoft.Build.Construction.ProjectImportElement AddImport(string project) { throw null; }
        public Microsoft.Build.Construction.ProjectImportGroupElement AddImportGroup() { throw null; }
        public Microsoft.Build.Construction.ProjectItemElement AddItem(string itemType, string include) { throw null; }
        public Microsoft.Build.Construction.ProjectItemElement AddItem(string itemType, string include, System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<string, string>> metadata) { throw null; }
        public Microsoft.Build.Construction.ProjectItemDefinitionElement AddItemDefinition(string itemType) { throw null; }
        public Microsoft.Build.Construction.ProjectItemDefinitionGroupElement AddItemDefinitionGroup() { throw null; }
        public Microsoft.Build.Construction.ProjectItemGroupElement AddItemGroup() { throw null; }
        public Microsoft.Build.Construction.ProjectPropertyElement AddProperty(string name, string value) { throw null; }
        public Microsoft.Build.Construction.ProjectPropertyGroupElement AddPropertyGroup() { throw null; }
        public Microsoft.Build.Construction.ProjectTargetElement AddTarget(string name) { throw null; }
        public Microsoft.Build.Construction.ProjectUsingTaskElement AddUsingTask(string name, string assemblyFile, string assemblyName) { throw null; }
        public static Microsoft.Build.Construction.ProjectRootElement Create() { throw null; }
        public static Microsoft.Build.Construction.ProjectRootElement Create(Microsoft.Build.Evaluation.ProjectCollection projectCollection) { throw null; }
        public static Microsoft.Build.Construction.ProjectRootElement Create(string path) { throw null; }
        public static Microsoft.Build.Construction.ProjectRootElement Create(string path, Microsoft.Build.Evaluation.ProjectCollection projectCollection) { throw null; }
        public static Microsoft.Build.Construction.ProjectRootElement Create(System.Xml.XmlReader xmlReader) { throw null; }
        public static Microsoft.Build.Construction.ProjectRootElement Create(System.Xml.XmlReader xmlReader, Microsoft.Build.Evaluation.ProjectCollection projectCollection) { throw null; }
        public Microsoft.Build.Construction.ProjectChooseElement CreateChooseElement() { throw null; }
        public Microsoft.Build.Construction.ProjectImportElement CreateImportElement(string project) { throw null; }
        public Microsoft.Build.Construction.ProjectImportGroupElement CreateImportGroupElement() { throw null; }
        public Microsoft.Build.Construction.ProjectItemDefinitionElement CreateItemDefinitionElement(string itemType) { throw null; }
        public Microsoft.Build.Construction.ProjectItemDefinitionGroupElement CreateItemDefinitionGroupElement() { throw null; }
        public Microsoft.Build.Construction.ProjectItemElement CreateItemElement(string itemType) { throw null; }
        public Microsoft.Build.Construction.ProjectItemElement CreateItemElement(string itemType, string include) { throw null; }
        public Microsoft.Build.Construction.ProjectItemGroupElement CreateItemGroupElement() { throw null; }
        public Microsoft.Build.Construction.ProjectMetadataElement CreateMetadataElement(string name) { throw null; }
        public Microsoft.Build.Construction.ProjectMetadataElement CreateMetadataElement(string name, string unevaluatedValue) { throw null; }
        public Microsoft.Build.Construction.ProjectOnErrorElement CreateOnErrorElement(string executeTargets) { throw null; }
        public Microsoft.Build.Construction.ProjectOtherwiseElement CreateOtherwiseElement() { throw null; }
        public Microsoft.Build.Construction.ProjectOutputElement CreateOutputElement(string taskParameter, string itemType, string propertyName) { throw null; }
        public Microsoft.Build.Construction.ProjectExtensionsElement CreateProjectExtensionsElement() { throw null; }
        public Microsoft.Build.Construction.ProjectPropertyElement CreatePropertyElement(string name) { throw null; }
        public Microsoft.Build.Construction.ProjectPropertyGroupElement CreatePropertyGroupElement() { throw null; }
        public Microsoft.Build.Construction.ProjectTargetElement CreateTargetElement(string name) { throw null; }
        public Microsoft.Build.Construction.ProjectTaskElement CreateTaskElement(string name) { throw null; }
        public Microsoft.Build.Construction.ProjectUsingTaskBodyElement CreateUsingTaskBodyElement(string evaluate, string body) { throw null; }
        public Microsoft.Build.Construction.ProjectUsingTaskElement CreateUsingTaskElement(string taskName, string assemblyFile, string assemblyName) { throw null; }
        public Microsoft.Build.Construction.ProjectUsingTaskParameterElement CreateUsingTaskParameterElement(string name, string output, string required, string parameterType) { throw null; }
        public Microsoft.Build.Construction.UsingTaskParameterGroupElement CreateUsingTaskParameterGroupElement() { throw null; }
        public Microsoft.Build.Construction.ProjectWhenElement CreateWhenElement(string condition) { throw null; }
        public static Microsoft.Build.Construction.ProjectRootElement Open(string path) { throw null; }
        public static Microsoft.Build.Construction.ProjectRootElement Open(string path, Microsoft.Build.Evaluation.ProjectCollection projectCollection) { throw null; }
        public void Save() { }
        public void Save(System.IO.TextWriter writer) { }
        public void Save(string path) { }
        public void Save(string path, System.Text.Encoding encoding) { }
        public void Save(System.Text.Encoding saveEncoding) { }
        public static Microsoft.Build.Construction.ProjectRootElement TryOpen(string path) { throw null; }
        public static Microsoft.Build.Construction.ProjectRootElement TryOpen(string path, Microsoft.Build.Evaluation.ProjectCollection projectCollection) { throw null; }
    }
    [System.Diagnostics.DebuggerDisplayAttribute("Name={Name} #Children={Count} Condition={Condition}")]
    public partial class ProjectTargetElement : Microsoft.Build.Construction.ProjectElementContainer
    {
        internal ProjectTargetElement() { }
        public string AfterTargets { get { throw null; } set { } }
        public string BeforeTargets { get { throw null; } set { } }
        public string DependsOnTargets { get { throw null; } set { } }
        public string Inputs { get { throw null; } set { } }
        public System.Collections.Generic.ICollection<Microsoft.Build.Construction.ProjectItemGroupElement> ItemGroups { get { throw null; } }
        public string KeepDuplicateOutputs { get { throw null; } set { } }
        public string Name { get { throw null; } set { } }
        public System.Collections.Generic.ICollection<Microsoft.Build.Construction.ProjectOnErrorElement> OnErrors { get { throw null; } }
        public string Outputs { get { throw null; } set { } }
        public System.Collections.Generic.ICollection<Microsoft.Build.Construction.ProjectPropertyGroupElement> PropertyGroups { get { throw null; } }
        public string Returns { get { throw null; } set { } }
        public System.Collections.Generic.ICollection<Microsoft.Build.Construction.ProjectTaskElement> Tasks { get { throw null; } }
        public Microsoft.Build.Construction.ProjectItemGroupElement AddItemGroup() { throw null; }
        public Microsoft.Build.Construction.ProjectPropertyGroupElement AddPropertyGroup() { throw null; }
        public Microsoft.Build.Construction.ProjectTaskElement AddTask(string taskName) { throw null; }
    }
    [System.Diagnostics.DebuggerDisplayAttribute("{Name} Condition={Condition} ContinueOnError={ContinueOnError} #Outputs={Count}")]
    public partial class ProjectTaskElement : Microsoft.Build.Construction.ProjectElementContainer
    {
        internal ProjectTaskElement() { }
        public string ContinueOnError { get { throw null; } set { } }
        public string ExecuteTargets { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public string Name { get { throw null; } }
        public System.Collections.Generic.ICollection<Microsoft.Build.Construction.ProjectOutputElement> Outputs { get { throw null; } }
        public System.Collections.Generic.IDictionary<string, string> Parameters { get { throw null; } }
        public Microsoft.Build.Construction.ProjectOutputElement AddOutputItem(string taskParameter, string itemType) { throw null; }
        public Microsoft.Build.Construction.ProjectOutputElement AddOutputItem(string taskParameter, string itemType, string condition) { throw null; }
        public Microsoft.Build.Construction.ProjectOutputElement AddOutputProperty(string taskParameter, string propertyName) { throw null; }
        public Microsoft.Build.Construction.ProjectOutputElement AddOutputProperty(string taskParameter, string propertyName, string condition) { throw null; }
        public string GetParameter(string name) { throw null; }
        public void RemoveAllParameters() { }
        public void RemoveParameter(string name) { }
        public void SetParameter(string name, string unevaluatedValue) { }
    }
    [System.Diagnostics.DebuggerDisplayAttribute("Evaluate={Evaluate} TaskBody={TaskBody}")]
    public partial class ProjectUsingTaskBodyElement : Microsoft.Build.Construction.ProjectElement
    {
        internal ProjectUsingTaskBodyElement() { }
        public override string Condition { get { throw null; } set { } }
        public string Evaluate { get { throw null; } set { } }
        public string TaskBody { get { throw null; } set { } }
    }
    [System.Diagnostics.DebuggerDisplayAttribute("TaskName={TaskName} AssemblyName={AssemblyName} AssemblyFile={AssemblyFile} Condition={Condition} Runtime={RequiredRuntime} Platform={RequiredPlatform}")]
    public partial class ProjectUsingTaskElement : Microsoft.Build.Construction.ProjectElementContainer
    {
        internal ProjectUsingTaskElement() { }
        public string AssemblyFile { get { throw null; } set { } }
        public string AssemblyName { get { throw null; } set { } }
        public Microsoft.Build.Construction.UsingTaskParameterGroupElement ParameterGroup { get { throw null; } }
        public Microsoft.Build.Construction.ProjectUsingTaskBodyElement TaskBody { get { throw null; } }
        public string TaskFactory { get { throw null; } set { } }
        public string TaskName { get { throw null; } set { } }
        public Microsoft.Build.Construction.UsingTaskParameterGroupElement AddParameterGroup() { throw null; }
        public Microsoft.Build.Construction.ProjectUsingTaskBodyElement AddUsingTaskBody(string evaluate, string taskBody) { throw null; }
    }
    [System.Diagnostics.DebuggerDisplayAttribute("Name={Name} ParameterType={ParameterType} Output={Output}")]
    public partial class ProjectUsingTaskParameterElement : Microsoft.Build.Construction.ProjectElement
    {
        internal ProjectUsingTaskParameterElement() { }
        public override string Condition { get { throw null; } set { } }
        public string Name { get { throw null; } set { } }
        public string Output { get { throw null; } set { } }
        public string ParameterType { get { throw null; } set { } }
        public string Required { get { throw null; } set { } }
    }
    [System.Diagnostics.DebuggerDisplayAttribute("#Children={Count} Condition={Condition}")]
    public partial class ProjectWhenElement : Microsoft.Build.Construction.ProjectElementContainer
    {
        internal ProjectWhenElement() { }
        public System.Collections.Generic.ICollection<Microsoft.Build.Construction.ProjectChooseElement> ChooseElements { get { throw null; } }
        public System.Collections.Generic.ICollection<Microsoft.Build.Construction.ProjectItemGroupElement> ItemGroups { get { throw null; } }
        public System.Collections.Generic.ICollection<Microsoft.Build.Construction.ProjectPropertyGroupElement> PropertyGroups { get { throw null; } }
    }
    [System.Diagnostics.DebuggerDisplayAttribute("#Parameters={Count}")]
    public partial class UsingTaskParameterGroupElement : Microsoft.Build.Construction.ProjectElementContainer
    {
        internal UsingTaskParameterGroupElement() { }
        public override string Condition { get { throw null; } set { } }
        public System.Collections.Generic.ICollection<Microsoft.Build.Construction.ProjectUsingTaskParameterElement> Parameters { get { throw null; } }
        public Microsoft.Build.Construction.ProjectUsingTaskParameterElement AddParameter(string name) { throw null; }
        public Microsoft.Build.Construction.ProjectUsingTaskParameterElement AddParameter(string name, string output, string required, string parameterType) { throw null; }
    }
}
namespace Microsoft.Build.Evaluation
{
    [System.Diagnostics.DebuggerDisplayAttribute("{FullPath} EffectiveToolsVersion={ToolsVersion} #GlobalProperties={data.globalProperties.Count} #Properties={data.Properties.Count} #ItemTypes={data.ItemTypes.Count} #ItemDefinitions={data.ItemDefinitions.Count} #Items={data.Items.Count} #Targets={data.Targets.Count}")]
    public partial class Project
    {
        public Project(Microsoft.Build.Construction.ProjectRootElement xml) { }
        public Project(Microsoft.Build.Construction.ProjectRootElement xml, System.Collections.Generic.IDictionary<string, string> globalProperties, string toolsVersion) { }
        public Project(Microsoft.Build.Construction.ProjectRootElement xml, System.Collections.Generic.IDictionary<string, string> globalProperties, string toolsVersion, Microsoft.Build.Evaluation.ProjectCollection projectCollection) { }
        public Project(Microsoft.Build.Construction.ProjectRootElement xml, System.Collections.Generic.IDictionary<string, string> globalProperties, string toolsVersion, Microsoft.Build.Evaluation.ProjectCollection projectCollection, Microsoft.Build.Evaluation.ProjectLoadSettings loadSettings) { }
        public Project(string projectFile) { }
        public Project(string projectFile, System.Collections.Generic.IDictionary<string, string> globalProperties, string toolsVersion) { }
        public Project(string projectFile, System.Collections.Generic.IDictionary<string, string> globalProperties, string toolsVersion, Microsoft.Build.Evaluation.ProjectCollection projectCollection) { }
        public Project(string projectFile, System.Collections.Generic.IDictionary<string, string> globalProperties, string toolsVersion, Microsoft.Build.Evaluation.ProjectCollection projectCollection, Microsoft.Build.Evaluation.ProjectLoadSettings loadSettings) { }
        public Project(System.Xml.XmlReader xml) { }
        public Project(System.Xml.XmlReader xml, System.Collections.Generic.IDictionary<string, string> globalProperties, string toolsVersion) { }
        public Project(System.Xml.XmlReader xml, System.Collections.Generic.IDictionary<string, string> globalProperties, string toolsVersion, Microsoft.Build.Evaluation.ProjectCollection projectCollection) { }
        public Project(System.Xml.XmlReader xml, System.Collections.Generic.IDictionary<string, string> globalProperties, string toolsVersion, Microsoft.Build.Evaluation.ProjectCollection projectCollection, Microsoft.Build.Evaluation.ProjectLoadSettings loadSettings) { }
        public System.Collections.Generic.ICollection<Microsoft.Build.Evaluation.ProjectMetadata> AllEvaluatedItemDefinitionMetadata { get { throw null; } }
        public System.Collections.Generic.ICollection<Microsoft.Build.Evaluation.ProjectItem> AllEvaluatedItems { get { throw null; } }
        public System.Collections.Generic.ICollection<Microsoft.Build.Evaluation.ProjectProperty> AllEvaluatedProperties { get { throw null; } }
        public System.Collections.Generic.IDictionary<string, System.Collections.Generic.List<string>> ConditionedProperties { get { throw null; } }
        public string DirectoryPath { get { throw null; } }
        public bool DisableMarkDirty { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public int EvaluationCounter { get { throw null; } }
        public string FullPath { get { throw null; } set { } }
        public System.Collections.Generic.IDictionary<string, string> GlobalProperties { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        public System.Collections.Generic.IList<Microsoft.Build.Evaluation.ResolvedImport> Imports { get { throw null; } }
        public System.Collections.Generic.IList<Microsoft.Build.Evaluation.ResolvedImport> ImportsIncludingDuplicates { get { throw null; } }
        public bool IsBuildEnabled { get { throw null; } }
        public bool IsDirty { get { throw null; } }
        public System.Collections.Generic.IDictionary<string, Microsoft.Build.Evaluation.ProjectItemDefinition> ItemDefinitions { get { throw null; } }
        [System.MonoTODOAttribute("should be different from AllEvaluatedItems")]
        public System.Collections.Generic.ICollection<Microsoft.Build.Evaluation.ProjectItem> Items { get { throw null; } }
        public System.Collections.Generic.ICollection<Microsoft.Build.Evaluation.ProjectItem> ItemsIgnoringCondition { get { throw null; } }
        public System.Collections.Generic.ICollection<string> ItemTypes { get { throw null; } }
        public Microsoft.Build.Evaluation.ProjectCollection ProjectCollection { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        [System.MonoTODOAttribute("should be different from AllEvaluatedProperties")]
        public System.Collections.Generic.ICollection<Microsoft.Build.Evaluation.ProjectProperty> Properties { get { throw null; } }
        public bool SkipEvaluation { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public string ToolsVersion { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        public Microsoft.Build.Construction.ProjectRootElement Xml { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        public System.Collections.Generic.IList<Microsoft.Build.Evaluation.ProjectItem> AddItem(string itemType, string unevaluatedInclude) { throw null; }
        public System.Collections.Generic.IList<Microsoft.Build.Evaluation.ProjectItem> AddItem(string itemType, string unevaluatedInclude, System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<string, string>> metadata) { throw null; }
        public System.Collections.Generic.IList<Microsoft.Build.Evaluation.ProjectItem> AddItemFast(string itemType, string unevaluatedInclude) { throw null; }
        public System.Collections.Generic.IList<Microsoft.Build.Evaluation.ProjectItem> AddItemFast(string itemType, string unevaluatedInclude, System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<string, string>> metadata) { throw null; }
        public bool Build() { throw null; }
        public bool Build(Microsoft.Build.Framework.ILogger logger) { throw null; }
        public bool Build(System.Collections.Generic.IEnumerable<Microsoft.Build.Framework.ILogger> loggers) { throw null; }
        public bool Build(System.Collections.Generic.IEnumerable<Microsoft.Build.Framework.ILogger> loggers, System.Collections.Generic.IEnumerable<Microsoft.Build.Logging.ForwardingLoggerRecord> remoteLoggers) { throw null; }
        public bool Build(string target) { throw null; }
        public bool Build(string target, System.Collections.Generic.IEnumerable<Microsoft.Build.Framework.ILogger> loggers) { throw null; }
        public bool Build(string target, System.Collections.Generic.IEnumerable<Microsoft.Build.Framework.ILogger> loggers, System.Collections.Generic.IEnumerable<Microsoft.Build.Logging.ForwardingLoggerRecord> remoteLoggers) { throw null; }
        public bool Build(string[] targets) { throw null; }
        public bool Build(string[] targets, System.Collections.Generic.IEnumerable<Microsoft.Build.Framework.ILogger> loggers) { throw null; }
        public bool Build(string[] targets, System.Collections.Generic.IEnumerable<Microsoft.Build.Framework.ILogger> loggers, System.Collections.Generic.IEnumerable<Microsoft.Build.Logging.ForwardingLoggerRecord> remoteLoggers) { throw null; }
        public Microsoft.Build.Execution.ProjectInstance CreateProjectInstance() { throw null; }
        public string ExpandString(string unexpandedValue) { throw null; }
        public static string GetEvaluatedItemIncludeEscaped(Microsoft.Build.Evaluation.ProjectItem item) { throw null; }
        public static string GetEvaluatedItemIncludeEscaped(Microsoft.Build.Evaluation.ProjectItemDefinition item) { throw null; }
        public System.Collections.Generic.ICollection<Microsoft.Build.Evaluation.ProjectItem> GetItems(string itemType) { throw null; }
        public System.Collections.Generic.ICollection<Microsoft.Build.Evaluation.ProjectItem> GetItemsByEvaluatedInclude(string evaluatedInclude) { throw null; }
        public System.Collections.Generic.ICollection<Microsoft.Build.Evaluation.ProjectItem> GetItemsIgnoringCondition(string itemType) { throw null; }
        public System.Collections.Generic.IEnumerable<Microsoft.Build.Construction.ProjectElement> GetLogicalProject() { throw null; }
        public static string GetMetadataValueEscaped(Microsoft.Build.Evaluation.ProjectItem item, string name) { throw null; }
        public static string GetMetadataValueEscaped(Microsoft.Build.Evaluation.ProjectItemDefinition item, string name) { throw null; }
        public static string GetMetadataValueEscaped(Microsoft.Build.Evaluation.ProjectMetadata metadatum) { throw null; }
        public Microsoft.Build.Evaluation.ProjectProperty GetProperty(string name) { throw null; }
        public string GetPropertyValue(string name) { throw null; }
        public static string GetPropertyValueEscaped(Microsoft.Build.Evaluation.ProjectProperty property) { throw null; }
        public void MarkDirty() { }
        public void ReevaluateIfNecessary() { }
        public bool RemoveGlobalProperty(string name) { throw null; }
        public bool RemoveItem(Microsoft.Build.Evaluation.ProjectItem item) { throw null; }
        public void RemoveItems(System.Collections.Generic.IEnumerable<Microsoft.Build.Evaluation.ProjectItem> items) { }
        public bool RemoveProperty(Microsoft.Build.Evaluation.ProjectProperty property) { throw null; }
        public void Save() { }
        public void Save(System.IO.TextWriter writer) { }
        public void Save(string path) { }
        public void Save(string path, System.Text.Encoding encoding) { }
        public void Save(System.Text.Encoding encoding) { }
        public void SaveLogicalProject(System.IO.TextWriter writer) { }
        public bool SetGlobalProperty(string name, string escapedValue) { throw null; }
        public Microsoft.Build.Evaluation.ProjectProperty SetProperty(string name, string unevaluatedValue) { throw null; }
    }
    public partial class ProjectChangedEventArgs : System.EventArgs
    {
        internal ProjectChangedEventArgs() { }
        public Microsoft.Build.Evaluation.Project Project { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
    }
    public partial class ProjectCollection : System.IDisposable
    {
        public ProjectCollection() { }
        public ProjectCollection(Microsoft.Build.Evaluation.ToolsetDefinitionLocations toolsetDefinitionLocations) { }
        public ProjectCollection(System.Collections.Generic.IDictionary<string, string> globalProperties) { }
        public ProjectCollection(System.Collections.Generic.IDictionary<string, string> globalProperties, System.Collections.Generic.IEnumerable<Microsoft.Build.Framework.ILogger> loggers, Microsoft.Build.Evaluation.ToolsetDefinitionLocations toolsetDefinitionLocations) { }
        public ProjectCollection(System.Collections.Generic.IDictionary<string, string> globalProperties, System.Collections.Generic.IEnumerable<Microsoft.Build.Framework.ILogger> loggers, System.Collections.Generic.IEnumerable<Microsoft.Build.Logging.ForwardingLoggerRecord> remoteLoggers, Microsoft.Build.Evaluation.ToolsetDefinitionLocations toolsetDefinitionLocations, int maxNodeCount, bool onlyLogCriticalEvents) { }
        public int Count { get { throw null; } }
        public string DefaultToolsVersion { get { throw null; } set { } }
        [System.MonoTODOAttribute]
        public bool DisableMarkDirty { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public static Microsoft.Build.Evaluation.ProjectCollection GlobalProjectCollection { get { throw null; } }
        public System.Collections.Generic.IDictionary<string, string> GlobalProperties { get { throw null; } }
        [System.MonoTODOAttribute]
        public Microsoft.Build.Execution.HostServices HostServices { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        [System.MonoTODOAttribute]
        public bool IsBuildEnabled { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public System.Collections.Generic.ICollection<Microsoft.Build.Evaluation.Project> LoadedProjects { get { throw null; } }
        public System.Collections.Generic.ICollection<Microsoft.Build.Framework.ILogger> Loggers { get { throw null; } }
        [System.MonoTODOAttribute]
        public bool OnlyLogCriticalEvents { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        [System.MonoTODOAttribute]
        public bool SkipEvaluation { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public Microsoft.Build.Evaluation.ToolsetDefinitionLocations ToolsetLocations { get { throw null; } }
        public System.Collections.Generic.ICollection<Microsoft.Build.Evaluation.Toolset> Toolsets { get { throw null; } }
        public static System.Version Version { get { throw null; } }
        [System.MonoTODOAttribute("not fired yet")]
        public event Microsoft.Build.Evaluation.ProjectCollection.ProjectAddedEventHandler ProjectAdded { add { } remove { } }
        [System.MonoTODOAttribute("not fired yet")]
        public event System.EventHandler<Microsoft.Build.Evaluation.ProjectChangedEventArgs> ProjectChanged { add { } remove { } }
        [System.MonoTODOAttribute("not fired yet")]
        public event System.EventHandler<Microsoft.Build.Evaluation.ProjectCollectionChangedEventArgs> ProjectCollectionChanged { add { } remove { } }
        [System.MonoTODOAttribute("not fired yet")]
        public event System.EventHandler<Microsoft.Build.Evaluation.ProjectXmlChangedEventArgs> ProjectXmlChanged { add { } remove { } }
        public void AddProject(Microsoft.Build.Evaluation.Project project) { }
        [System.MonoTODOAttribute("not verified at all")]
        public void AddToolset(Microsoft.Build.Evaluation.Toolset toolset) { }
        public void Dispose() { }
        protected virtual void Dispose(bool disposing) { }
        public static string Escape(string unescapedString) { throw null; }
        public System.Collections.Generic.ICollection<Microsoft.Build.Evaluation.Project> GetLoadedProjects(string fullPath) { throw null; }
        public Microsoft.Build.Evaluation.Toolset GetToolset(string toolsVersion) { throw null; }
        public Microsoft.Build.Evaluation.Project LoadProject(string fileName) { throw null; }
        public Microsoft.Build.Evaluation.Project LoadProject(string fileName, System.Collections.Generic.IDictionary<string, string> globalProperties, string toolsVersion) { throw null; }
        public Microsoft.Build.Evaluation.Project LoadProject(string fileName, string toolsVersion) { throw null; }
        public Microsoft.Build.Evaluation.Project LoadProject(System.Xml.XmlReader xmlReader) { throw null; }
        public Microsoft.Build.Evaluation.Project LoadProject(System.Xml.XmlReader xmlReader, System.Collections.Generic.IDictionary<string, string> globalProperties, string toolsVersion) { throw null; }
        public Microsoft.Build.Evaluation.Project LoadProject(System.Xml.XmlReader xmlReader, string toolsVersion) { throw null; }
        public void RegisterLogger(Microsoft.Build.Framework.ILogger logger) { }
        public void RegisterLoggers(System.Collections.Generic.IEnumerable<Microsoft.Build.Framework.ILogger> loggers) { }
        [System.MonoTODOAttribute("not verified at all")]
        public void RemoveAllToolsets() { }
        public static string Unescape(string escapedString) { throw null; }
        public void UnloadAllProjects() { }
        [System.MonoTODOAttribute("Not verified at all")]
        public void UnloadProject(Microsoft.Build.Construction.ProjectRootElement projectRootElement) { }
        [System.MonoTODOAttribute("Not verified at all")]
        public void UnloadProject(Microsoft.Build.Evaluation.Project project) { }
        public delegate void ProjectAddedEventHandler(object target, Microsoft.Build.Evaluation.ProjectCollection.ProjectAddedToProjectCollectionEventArgs args);
        public partial class ProjectAddedToProjectCollectionEventArgs : System.EventArgs
        {
            public ProjectAddedToProjectCollectionEventArgs(Microsoft.Build.Construction.ProjectRootElement project) { }
            public Microsoft.Build.Construction.ProjectRootElement ProjectRootElement { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        }
    }
    public partial class ProjectCollectionChangedEventArgs : System.EventArgs
    {
        public ProjectCollectionChangedEventArgs(Microsoft.Build.Evaluation.ProjectCollectionChangedState state) { }
        public Microsoft.Build.Evaluation.ProjectCollectionChangedState State { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
    }
    public enum ProjectCollectionChangedState
    {
        DefaultToolsVersion = 0,
        DisableMarkDirty = 1,
        GlobalProperties = 2,
        HostServices = 3,
        IsBuildEnabled = 4,
        Loggers = 5,
        OnlyLogCriticalEvents = 6,
        SkipEvaluation = 7,
        Toolsets = 8,
    }
    [System.Diagnostics.DebuggerDisplayAttribute("{ItemType}={EvaluatedInclude} [{UnevaluatedInclude}] #DirectMetadata={DirectMetadataCount}")]
    public partial class ProjectItem
    {
        internal ProjectItem() { }
        public System.Collections.Generic.IEnumerable<Microsoft.Build.Evaluation.ProjectMetadata> DirectMetadata { get { throw null; } }
        public int DirectMetadataCount { get { throw null; } }
        public string EvaluatedInclude { get { throw null; } }
        public bool IsImported { get { throw null; } }
        public string ItemType { get { throw null; } set { } }
        public System.Collections.Generic.ICollection<Microsoft.Build.Evaluation.ProjectMetadata> Metadata { get { throw null; } }
        public int MetadataCount { get { throw null; } }
        public Microsoft.Build.Evaluation.Project Project { get { throw null; } }
        public string UnevaluatedInclude { get { throw null; } set { } }
        public Microsoft.Build.Construction.ProjectItemElement Xml { get { throw null; } }
        public Microsoft.Build.Evaluation.ProjectMetadata GetMetadata(string name) { throw null; }
        public string GetMetadataValue(string name) { throw null; }
        public bool HasMetadata(string name) { throw null; }
        public bool RemoveMetadata(string name) { throw null; }
        public void Rename(string name) { }
        public Microsoft.Build.Evaluation.ProjectMetadata SetMetadataValue(string name, string unevaluatedValue) { throw null; }
    }
    public partial class ProjectItemDefinition
    {
        internal ProjectItemDefinition() { }
        public string ItemType { get { throw null; } }
        public System.Collections.Generic.IEnumerable<Microsoft.Build.Evaluation.ProjectMetadata> Metadata { get { throw null; } }
        public int MetadataCount { get { throw null; } }
        public Microsoft.Build.Evaluation.Project Project { get { throw null; } }
    }
    [System.FlagsAttribute]
    public enum ProjectLoadSettings
    {
        Default = 0,
        IgnoreMissingImports = 1,
        RecordDuplicateButNotCircularImports = 2,
        RejectCircularImports = 4,
    }
    public partial class ProjectMetadata
    {
        internal ProjectMetadata() { }
        public string EvaluatedValue { get { throw null; } }
        public bool IsImported { get { throw null; } }
        public string ItemType { get { throw null; } }
        public string Name { get { throw null; } }
        public Microsoft.Build.Evaluation.ProjectMetadata Predecessor { get { throw null; } }
        public Microsoft.Build.Evaluation.Project Project { get { throw null; } }
        public string UnevaluatedValue { get { throw null; } }
        public Microsoft.Build.Construction.ProjectMetadataElement Xml { get { throw null; } }
    }
    public abstract partial class ProjectProperty
    {
        internal ProjectProperty() { }
        public string EvaluatedValue { get { throw null; } }
        public abstract bool IsEnvironmentProperty { get; }
        public abstract bool IsGlobalProperty { get; }
        [System.MonoTODOAttribute]
        public abstract bool IsImported { get; }
        public abstract bool IsReservedProperty { get; }
        public abstract string Name { get; }
        public abstract Microsoft.Build.Evaluation.ProjectProperty Predecessor { get; }
        public Microsoft.Build.Evaluation.Project Project { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        public abstract string UnevaluatedValue { get; set; }
        public abstract Microsoft.Build.Construction.ProjectPropertyElement Xml { get; }
    }
    public partial class ProjectXmlChangedEventArgs : System.EventArgs
    {
        internal ProjectXmlChangedEventArgs() { }
        public Microsoft.Build.Construction.ProjectRootElement ProjectXml { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        public string Reason { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public partial struct ResolvedImport
    {
        public Microsoft.Build.Construction.ProjectRootElement ImportedProject { get { throw null; } }
        public Microsoft.Build.Construction.ProjectImportElement ImportingElement { get { throw null; } }
        public bool IsImported { get { throw null; } }
    }
    public partial class Toolset
    {
        public Toolset(string toolsVersion, string toolsPath, Microsoft.Build.Evaluation.ProjectCollection projectCollection, string msbuildOverrideTasksPath) { }
        public Toolset(string toolsVersion, string toolsPath, System.Collections.Generic.IDictionary<string, string> buildProperties, Microsoft.Build.Evaluation.ProjectCollection projectCollection, string msbuildOverrideTasksPath) { }
        public System.Collections.Generic.IDictionary<string, Microsoft.Build.Execution.ProjectPropertyInstance> Properties { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        public string ToolsPath { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        public string ToolsVersion { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
    }
    [System.FlagsAttribute]
    public enum ToolsetDefinitionLocations
    {
        ConfigurationFile = 1,
        None = 0,
        Registry = 2,
    }
}
namespace Microsoft.Build.Exceptions
{
    public partial class BuildAbortedException : System.Exception
    {
        public BuildAbortedException() { }
        protected BuildAbortedException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
        public BuildAbortedException(string message) { }
        public BuildAbortedException(string message, System.Exception innerException) { }
        public string ErrorCode { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        public override void GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
    }
    public partial class InternalLoggerException : System.Exception
    {
        public InternalLoggerException() { }
        public InternalLoggerException(string message) { }
        public InternalLoggerException(string message, System.Exception innerException) { }
        public Microsoft.Build.Framework.BuildEventArgs BuildEventArgs { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        public string ErrorCode { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        public string HelpKeyword { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        public bool InitializationException { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        public override void GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
    }
    [System.SerializableAttribute]
    public sealed partial class InvalidProjectFileException : System.Exception
    {
        public InvalidProjectFileException() { }
        public InvalidProjectFileException(string message) { }
        public InvalidProjectFileException(string message, System.Exception innerException) { }
        public InvalidProjectFileException(string projectFile, int lineNumber, int columnNumber, int endLineNumber, int endColumnNumber, string message, string errorSubcategory, string errorCode, string helpKeyword) { }
        public string BaseMessage { get { throw null; } }
        public int ColumnNumber { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        public int EndColumnNumber { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        public int EndLineNumber { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        public string ErrorCode { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        public string ErrorSubcategory { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        public bool HasBeenLogged { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        public string HelpKeyword { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        public int LineNumber { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        public override string Message { get { throw null; } }
        public string ProjectFile { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        public override void GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
    }
    public partial class InvalidToolsetDefinitionException : System.Exception
    {
        public InvalidToolsetDefinitionException() { }
        protected InvalidToolsetDefinitionException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
        public InvalidToolsetDefinitionException(string message) { }
        public InvalidToolsetDefinitionException(string message, System.Exception innerException) { }
        public string ErrorCode { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        public override void GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
    }
}
namespace Microsoft.Build.Execution
{
    public partial class BuildManager
    {
        public BuildManager() { }
        public BuildManager(string hostName) { }
        public static Microsoft.Build.Execution.BuildManager DefaultBuildManager { get { throw null; } }
        public void BeginBuild(Microsoft.Build.Execution.BuildParameters parameters) { }
        public Microsoft.Build.Execution.BuildResult Build(Microsoft.Build.Execution.BuildParameters parameters, Microsoft.Build.Execution.BuildRequestData requestData) { throw null; }
        public Microsoft.Build.Execution.BuildResult BuildRequest(Microsoft.Build.Execution.BuildRequestData requestData) { throw null; }
        public void CancelAllSubmissions() { }
        public void Dispose() { }
        public void EndBuild() { }
        ~BuildManager() { }
        public Microsoft.Build.Execution.ProjectInstance GetProjectInstanceForBuild(Microsoft.Build.Evaluation.Project project) { throw null; }
        public Microsoft.Build.Execution.BuildSubmission PendBuildRequest(Microsoft.Build.Execution.BuildRequestData requestData) { throw null; }
        public void ResetCaches() { }
    }
    public partial class BuildParameters
    {
        public BuildParameters() { }
        public BuildParameters(Microsoft.Build.Evaluation.ProjectCollection projectCollection) { }
        [System.MonoTODOAttribute]
        public System.Threading.ThreadPriority BuildThreadPriority { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        [System.MonoTODOAttribute]
        public System.Globalization.CultureInfo Culture { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public string DefaultToolsVersion { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        [System.MonoTODOAttribute]
        public bool DetailedSummary { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public bool EnableNodeReuse { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        [System.MonoTODOAttribute]
        public System.Collections.Generic.IDictionary<string, string> EnvironmentProperties { get { throw null; } }
        [System.MonoTODOAttribute]
        public System.Collections.Generic.IEnumerable<Microsoft.Build.Logging.ForwardingLoggerRecord> ForwardingLoggers { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        [System.MonoTODOAttribute]
        public System.Collections.Generic.IDictionary<string, string> GlobalProperties { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public Microsoft.Build.Execution.HostServices HostServices { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        [System.MonoTODOAttribute]
        public bool LegacyThreadingSemantics { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        [System.MonoTODOAttribute]
        public System.Collections.Generic.IEnumerable<Microsoft.Build.Framework.ILogger> Loggers { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        [System.MonoTODOAttribute]
        public int MaxNodeCount { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        [System.MonoTODOAttribute]
        public int MemoryUseLimit { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        [System.MonoTODOAttribute]
        public string NodeExeLocation { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        [System.MonoTODOAttribute]
        public bool OnlyLogCriticalEvents { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        [System.MonoTODOAttribute]
        public bool ResetCaches { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        [System.MonoTODOAttribute]
        public bool SaveOperatingEnvironment { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        [System.MonoTODOAttribute]
        public Microsoft.Build.Evaluation.ToolsetDefinitionLocations ToolsetDefinitionLocations { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        [System.MonoTODOAttribute]
        public System.Collections.Generic.ICollection<Microsoft.Build.Evaluation.Toolset> Toolsets { get { throw null; } }
        [System.MonoTODOAttribute]
        public System.Globalization.CultureInfo UICulture { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        [System.MonoTODOAttribute]
        public bool UseSynchronousLogging { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public Microsoft.Build.Execution.BuildParameters Clone() { throw null; }
        public Microsoft.Build.Evaluation.Toolset GetToolset(string toolsVersion) { throw null; }
    }
    public partial class BuildRequestData
    {
        public BuildRequestData(Microsoft.Build.Execution.ProjectInstance projectInstance, string[] targetsToBuild) { }
        public BuildRequestData(Microsoft.Build.Execution.ProjectInstance projectInstance, string[] targetsToBuild, Microsoft.Build.Execution.HostServices hostServices) { }
        public BuildRequestData(Microsoft.Build.Execution.ProjectInstance projectInstance, string[] targetsToBuild, Microsoft.Build.Execution.HostServices hostServices, Microsoft.Build.Execution.BuildRequestDataFlags flags) { }
        public BuildRequestData(string projectFullPath, System.Collections.Generic.IDictionary<string, string> globalProperties, string toolsVersion, string[] targetsToBuild, Microsoft.Build.Execution.HostServices hostServices) { }
        public BuildRequestData(string projectFullPath, System.Collections.Generic.IDictionary<string, string> globalProperties, string toolsVersion, string[] targetsToBuild, Microsoft.Build.Execution.HostServices hostServices, Microsoft.Build.Execution.BuildRequestDataFlags flags) { }
        public string ExplicitlySpecifiedToolsVersion { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        [System.MonoTODOAttribute("unused")]
        public Microsoft.Build.Execution.BuildRequestDataFlags Flags { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        [System.MonoTODOAttribute("unused")]
        public Microsoft.Build.Execution.HostServices HostServices { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        public string ProjectFullPath { get { throw null; } }
        [System.MonoTODOAttribute("unused")]
        public Microsoft.Build.Execution.ProjectInstance ProjectInstance { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        [System.MonoTODOAttribute]
        public System.Collections.Generic.IEnumerable<string> PropertiesToTransfer { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        [System.MonoTODOAttribute]
        public System.Collections.Generic.ICollection<string> TargetNames { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
    }
    [System.FlagsAttribute]
    public enum BuildRequestDataFlags
    {
        None = 0,
        ReplaceExistingProjectInstance = 1,
    }
    public partial class BuildResult
    {
        public BuildResult() { }
        public bool CircularDependency { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        public int ConfigurationId { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        public System.Exception Exception { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public int GlobalRequestId { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        public Microsoft.Build.Execution.ITargetResult this[string target] { get { throw null; } }
        public int NodeRequestId { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        public Microsoft.Build.Execution.BuildResultCode OverallResult { get { throw null; } }
        public int ParentGlobalRequestId { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        public System.Collections.Generic.IDictionary<string, Microsoft.Build.Execution.TargetResult> ResultsByTarget { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        public int SubmissionId { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        public void AddResultsForTarget(string target, Microsoft.Build.Execution.TargetResult result) { }
        public bool HasResultsForTarget(string target) { throw null; }
        public void MergeResults(Microsoft.Build.Execution.BuildResult results) { }
    }
    public enum BuildResultCode
    {
        Failure = 1,
        Success = 0,
    }
    public partial class BuildSubmission
    {
        internal BuildSubmission() { }
        public object AsyncContext { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        public Microsoft.Build.Execution.BuildManager BuildManager { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        public Microsoft.Build.Execution.BuildResult BuildResult { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public bool IsCompleted { get { throw null; } }
        public int SubmissionId { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        public System.Threading.WaitHandle WaitHandle { get { throw null; } }
        public Microsoft.Build.Execution.BuildResult Execute() { throw null; }
        public void ExecuteAsync(Microsoft.Build.Execution.BuildSubmissionCompleteCallback callback, object context) { }
    }
    public delegate void BuildSubmissionCompleteCallback(Microsoft.Build.Execution.BuildSubmission submission);
    public partial class HostServices
    {
        public HostServices() { }
        public Microsoft.Build.Framework.ITaskHost GetHostObject(string projectFile, string targetName, string taskName) { throw null; }
        public Microsoft.Build.Execution.NodeAffinity GetNodeAffinity(string projectFile) { throw null; }
        public void OnRenameProject(string oldFullPath, string newFullPath) { }
        public void RegisterHostObject(string projectFile, string targetName, string taskName, Microsoft.Build.Framework.ITaskHost hostObject) { }
        public void SetNodeAffinity(string projectFile, Microsoft.Build.Execution.NodeAffinity nodeAffinity) { }
        public void UnregisterProject(string projectFullPath) { }
    }
    public partial interface ITargetResult
    {
        System.Exception Exception { get; }
        Microsoft.Build.Framework.ITaskItem[] Items { get; }
        Microsoft.Build.Execution.TargetResultCode ResultCode { get; }
    }
    public enum NodeAffinity
    {
        Any = 2,
        InProc = 0,
        OutOfProc = 1,
    }
    public partial class ProjectInstance
    {
        public ProjectInstance(Microsoft.Build.Construction.ProjectRootElement xml) { }
        public ProjectInstance(Microsoft.Build.Construction.ProjectRootElement xml, System.Collections.Generic.IDictionary<string, string> globalProperties, string toolsVersion, Microsoft.Build.Evaluation.ProjectCollection projectCollection) { }
        public ProjectInstance(string projectFile) { }
        public ProjectInstance(string projectFile, System.Collections.Generic.IDictionary<string, string> globalProperties, string toolsVersion) { }
        public ProjectInstance(string projectFile, System.Collections.Generic.IDictionary<string, string> globalProperties, string toolsVersion, Microsoft.Build.Evaluation.ProjectCollection projectCollection) { }
        public System.Collections.Generic.List<string> DefaultTargets { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        public string Directory { get { throw null; } }
        public string FullPath { get { throw null; } }
        public System.Collections.Generic.IDictionary<string, string> GlobalProperties { get { throw null; } }
        public System.Collections.Generic.List<string> InitialTargets { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        public System.Collections.Generic.IDictionary<string, Microsoft.Build.Execution.ProjectItemDefinitionInstance> ItemDefinitions { get { throw null; } }
        public System.Collections.Generic.ICollection<Microsoft.Build.Execution.ProjectItemInstance> Items { get { throw null; } }
        public System.Collections.Generic.ICollection<string> ItemTypes { get { throw null; } }
        public System.Collections.Generic.ICollection<Microsoft.Build.Execution.ProjectPropertyInstance> Properties { get { throw null; } }
        public string ToolsVersion { get { throw null; } }
        public Microsoft.Build.Execution.ProjectItemInstance AddItem(string itemType, string evaluatedInclude) { throw null; }
        public Microsoft.Build.Execution.ProjectItemInstance AddItem(string itemType, string evaluatedInclude, System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<string, string>> metadata) { throw null; }
        public bool Build() { throw null; }
        public bool Build(System.Collections.Generic.IEnumerable<Microsoft.Build.Framework.ILogger> loggers) { throw null; }
        public bool Build(System.Collections.Generic.IEnumerable<Microsoft.Build.Framework.ILogger> loggers, System.Collections.Generic.IEnumerable<Microsoft.Build.Logging.ForwardingLoggerRecord> remoteLoggers) { throw null; }
        public bool Build(string target, System.Collections.Generic.IEnumerable<Microsoft.Build.Framework.ILogger> loggers) { throw null; }
        public bool Build(string target, System.Collections.Generic.IEnumerable<Microsoft.Build.Framework.ILogger> loggers, System.Collections.Generic.IEnumerable<Microsoft.Build.Logging.ForwardingLoggerRecord> remoteLoggers) { throw null; }
        public bool Build(string[] targets, System.Collections.Generic.IEnumerable<Microsoft.Build.Framework.ILogger> loggers) { throw null; }
        public bool Build(string[] targets, System.Collections.Generic.IEnumerable<Microsoft.Build.Framework.ILogger> loggers, out System.Collections.Generic.IDictionary<string, Microsoft.Build.Execution.TargetResult> targetOutputs) { targetOutputs = default(System.Collections.Generic.IDictionary<string, Microsoft.Build.Execution.TargetResult>); throw null; }
        public bool Build(string[] targets, System.Collections.Generic.IEnumerable<Microsoft.Build.Framework.ILogger> loggers, System.Collections.Generic.IEnumerable<Microsoft.Build.Logging.ForwardingLoggerRecord> remoteLoggers) { throw null; }
        public bool Build(string[] targets, System.Collections.Generic.IEnumerable<Microsoft.Build.Framework.ILogger> loggers, System.Collections.Generic.IEnumerable<Microsoft.Build.Logging.ForwardingLoggerRecord> remoteLoggers, out System.Collections.Generic.IDictionary<string, Microsoft.Build.Execution.TargetResult> targetOutputs) { targetOutputs = default(System.Collections.Generic.IDictionary<string, Microsoft.Build.Execution.TargetResult>); throw null; }
        public Microsoft.Build.Execution.ProjectInstance DeepCopy() { throw null; }
        public Microsoft.Build.Execution.ProjectInstance DeepCopy(bool isImmutable) { throw null; }
        public bool EvaluateCondition(string condition) { throw null; }
        public string ExpandString(string unexpandedValue) { throw null; }
        public static string GetEvaluatedItemIncludeEscaped(Microsoft.Build.Execution.ProjectItemDefinitionInstance item) { throw null; }
        public static string GetEvaluatedItemIncludeEscaped(Microsoft.Build.Execution.ProjectItemInstance item) { throw null; }
        public System.Collections.Generic.ICollection<Microsoft.Build.Execution.ProjectItemInstance> GetItems(string itemType) { throw null; }
        public System.Collections.Generic.IEnumerable<Microsoft.Build.Execution.ProjectItemInstance> GetItemsByItemTypeAndEvaluatedInclude(string itemType, string evaluatedInclude) { throw null; }
        public static string GetMetadataValueEscaped(Microsoft.Build.Execution.ProjectItemDefinitionInstance item, string name) { throw null; }
        public static string GetMetadataValueEscaped(Microsoft.Build.Execution.ProjectItemInstance item, string name) { throw null; }
        public static string GetMetadataValueEscaped(Microsoft.Build.Execution.ProjectMetadataInstance metadatum) { throw null; }
        public Microsoft.Build.Execution.ProjectPropertyInstance GetProperty(string name) { throw null; }
        public string GetPropertyValue(string name) { throw null; }
        public static string GetPropertyValueEscaped(Microsoft.Build.Execution.ProjectPropertyInstance property) { throw null; }
        public bool RemoveItem(Microsoft.Build.Execution.ProjectItemInstance item) { throw null; }
        public bool RemoveProperty(string name) { throw null; }
        public Microsoft.Build.Execution.ProjectPropertyInstance SetProperty(string name, string evaluatedValue) { throw null; }
        public Microsoft.Build.Construction.ProjectRootElement ToProjectRootElement() { throw null; }
    }
    public partial class ProjectItemDefinitionInstance
    {
        internal ProjectItemDefinitionInstance() { }
        public string ItemType { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        public System.Collections.Generic.ICollection<Microsoft.Build.Execution.ProjectMetadataInstance> Metadata { get { throw null; } }
        public int MetadataCount { get { throw null; } }
        public System.Collections.Generic.IEnumerable<string> MetadataNames { get { throw null; } }
    }
    public sealed partial class ProjectItemGroupTaskInstance : Microsoft.Build.Execution.ProjectTargetInstanceChild
    {
        internal ProjectItemGroupTaskInstance() { }
        public override string Condition { get { throw null; } }
        public System.Collections.Generic.ICollection<Microsoft.Build.Execution.ProjectItemGroupTaskItemInstance> Items { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
    }
    public partial class ProjectItemGroupTaskItemInstance
    {
        internal ProjectItemGroupTaskItemInstance() { }
        public string Condition { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        public string Exclude { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        public string Include { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        public string ItemType { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        public string KeepDuplicates { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        public string KeepMetadata { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        public System.Collections.Generic.ICollection<Microsoft.Build.Execution.ProjectItemGroupTaskMetadataInstance> Metadata { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        public string Remove { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        public string RemoveMetadata { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
    }
    public sealed partial class ProjectItemGroupTaskMetadataInstance
    {
        internal ProjectItemGroupTaskMetadataInstance() { }
        public string Condition { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        public string Name { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        public string Value { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
    }
    public partial class ProjectItemInstance : Microsoft.Build.Framework.ITaskItem, Microsoft.Build.Framework.ITaskItem2
    {
        internal ProjectItemInstance() { }
        public int DirectMetadataCount { get { throw null; } }
        public string EvaluatedInclude { get { throw null; } set { } }
        public string ItemType { get { throw null; } }
        public System.Collections.Generic.IEnumerable<Microsoft.Build.Execution.ProjectMetadataInstance> Metadata { get { throw null; } }
        public int MetadataCount { get { throw null; } }
        public System.Collections.Generic.ICollection<string> MetadataNames { get { throw null; } }
        string Microsoft.Build.Framework.ITaskItem.ItemSpec { get { throw null; } set { } }
        int Microsoft.Build.Framework.ITaskItem.MetadataCount { get { throw null; } }
        System.Collections.ICollection Microsoft.Build.Framework.ITaskItem.MetadataNames { get { throw null; } }
        string Microsoft.Build.Framework.ITaskItem2.EvaluatedIncludeEscaped { get { throw null; } set { } }
        public Microsoft.Build.Execution.ProjectInstance Project { get { throw null; } }
        public Microsoft.Build.Execution.ProjectMetadataInstance GetMetadata(string name) { throw null; }
        public string GetMetadataValue(string name) { throw null; }
        public bool HasMetadata(string name) { throw null; }
        System.Collections.IDictionary Microsoft.Build.Framework.ITaskItem.CloneCustomMetadata() { throw null; }
        void Microsoft.Build.Framework.ITaskItem.CopyMetadataTo(Microsoft.Build.Framework.ITaskItem destinationItem) { }
        string Microsoft.Build.Framework.ITaskItem.GetMetadata(string metadataName) { throw null; }
        void Microsoft.Build.Framework.ITaskItem.RemoveMetadata(string metadataName) { }
        void Microsoft.Build.Framework.ITaskItem.SetMetadata(string metadataName, string metadataValue) { }
        System.Collections.IDictionary Microsoft.Build.Framework.ITaskItem2.CloneCustomMetadataEscaped() { throw null; }
        string Microsoft.Build.Framework.ITaskItem2.GetMetadataValueEscaped(string metadataName) { throw null; }
        void Microsoft.Build.Framework.ITaskItem2.SetMetadataValueLiteral(string metadataName, string metadataValue) { }
        public void RemoveMetadata(string metadataName) { }
        public void SetMetadata(System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<string, string>> metadataDictionary) { }
        public Microsoft.Build.Execution.ProjectMetadataInstance SetMetadata(string name, string evaluatedValue) { throw null; }
    }
    public partial class ProjectMetadataInstance
    {
        internal ProjectMetadataInstance() { }
        public string EvaluatedValue { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        public string Name { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        public Microsoft.Build.Execution.ProjectMetadataInstance DeepClone() { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class ProjectOnErrorInstance : Microsoft.Build.Execution.ProjectTargetInstanceChild
    {
        internal ProjectOnErrorInstance() { }
        public override string Condition { get { throw null; } }
        public string ExecuteTargets { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
    }
    public sealed partial class ProjectPropertyGroupTaskInstance : Microsoft.Build.Execution.ProjectTargetInstanceChild
    {
        internal ProjectPropertyGroupTaskInstance() { }
        public override string Condition { get { throw null; } }
        public System.Collections.Generic.ICollection<Microsoft.Build.Execution.ProjectPropertyGroupTaskPropertyInstance> Properties { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
    }
    public partial class ProjectPropertyGroupTaskPropertyInstance
    {
        internal ProjectPropertyGroupTaskPropertyInstance() { }
        public string Condition { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        public string Name { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        public string Value { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
    }
    public partial class ProjectPropertyInstance
    {
        internal ProjectPropertyInstance() { }
        public string EvaluatedValue { get { throw null; } set { } }
        public virtual bool IsImmutable { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        public string Name { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        public override string ToString() { throw null; }
    }
    public abstract partial class ProjectTargetInstanceChild
    {
        protected ProjectTargetInstanceChild() { }
        public abstract string Condition { get; }
        public string FullPath { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
    }
    public sealed partial class ProjectTaskInstance : Microsoft.Build.Execution.ProjectTargetInstanceChild
    {
        internal ProjectTaskInstance() { }
        public override string Condition { get { throw null; } }
        public string ContinueOnError { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        public string Name { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        public System.Collections.Generic.IList<Microsoft.Build.Execution.ProjectTaskInstanceChild> Outputs { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        public System.Collections.Generic.IDictionary<string, string> Parameters { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
    }
    public abstract partial class ProjectTaskInstanceChild
    {
        protected ProjectTaskInstanceChild() { }
        public abstract string Condition { get; }
    }
    public partial class ProjectTaskOutputItemInstance : Microsoft.Build.Execution.ProjectTaskInstanceChild
    {
        internal ProjectTaskOutputItemInstance() { }
        public override string Condition { get { throw null; } }
        public string ItemType { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        public string TaskParameter { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
    }
    public partial class ProjectTaskOutputPropertyInstance : Microsoft.Build.Execution.ProjectTaskInstanceChild
    {
        internal ProjectTaskOutputPropertyInstance() { }
        public override string Condition { get { throw null; } }
        public string PropertyName { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        public string TaskParameter { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
    }
    public partial class TargetResult : Microsoft.Build.Execution.ITargetResult
    {
        internal TargetResult() { }
        public System.Exception Exception { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        public Microsoft.Build.Framework.ITaskItem[] Items { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        public Microsoft.Build.Execution.TargetResultCode ResultCode { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
    }
    public enum TargetResultCode : byte
    {
        Failure = (byte)2,
        Skipped = (byte)0,
        Success = (byte)1,
    }
}
namespace Microsoft.Build.Internal
{
    public enum NodeEngineShutdownReason
    {
        BuildComplete = 0,
        BuildCompleteReuse = 1,
        ConnectionFailed = 2,
        Error = 3,
    }
    public partial class OutOfProcNode
    {
        public OutOfProcNode() { }
        public Microsoft.Build.Internal.NodeEngineShutdownReason Run(out System.Exception shutdownException) { shutdownException = default(System.Exception); throw null; }
    }
}
namespace Microsoft.Build.Logging
{
    public delegate void ColorResetter();
    public delegate void ColorSetter(System.ConsoleColor color);
    public partial class ConfigurableForwardingLogger : Microsoft.Build.Framework.IForwardingLogger, Microsoft.Build.Framework.ILogger, Microsoft.Build.Framework.INodeLogger
    {
        public ConfigurableForwardingLogger() { }
        public Microsoft.Build.Framework.IEventRedirector BuildEventRedirector { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public int NodeId { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public string Parameters { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public Microsoft.Build.Framework.LoggerVerbosity Verbosity { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public void Initialize(Microsoft.Build.Framework.IEventSource eventSource) { }
        public void Initialize(Microsoft.Build.Framework.IEventSource eventSource, int nodeCount) { }
        public void Shutdown() { }
    }
    public partial class ConsoleLogger : Microsoft.Build.Framework.ILogger
    {
        public ConsoleLogger() { }
        public ConsoleLogger(Microsoft.Build.Framework.LoggerVerbosity verbosity) { }
        public ConsoleLogger(Microsoft.Build.Framework.LoggerVerbosity verbosity, Microsoft.Build.Logging.WriteHandler write, Microsoft.Build.Logging.ColorSetter colorSet, Microsoft.Build.Logging.ColorResetter colorReset) { }
        public string Parameters { get { throw null; } set { } }
        public bool ShowSummary { get { throw null; } set { } }
        public bool SkipProjectStartedText { get { throw null; } set { } }
        public Microsoft.Build.Framework.LoggerVerbosity Verbosity { get { throw null; } set { } }
        protected Microsoft.Build.Logging.WriteHandler WriteHandler { get { throw null; } set { } }
        public void ApplyParameter(string parameterName, string parameterValue) { }
        public void BuildFinishedHandler(object sender, Microsoft.Build.Framework.BuildFinishedEventArgs args) { }
        public void BuildStartedHandler(object sender, Microsoft.Build.Framework.BuildStartedEventArgs args) { }
        [System.MonoTODOAttribute]
        public void CustomEventHandler(object sender, Microsoft.Build.Framework.CustomBuildEventArgs args) { }
        public void ErrorHandler(object sender, Microsoft.Build.Framework.BuildErrorEventArgs args) { }
        public virtual void Initialize(Microsoft.Build.Framework.IEventSource eventSource) { }
        public void MessageHandler(object sender, Microsoft.Build.Framework.BuildMessageEventArgs args) { }
        public void ProjectFinishedHandler(object sender, Microsoft.Build.Framework.ProjectFinishedEventArgs args) { }
        public void ProjectStartedHandler(object sender, Microsoft.Build.Framework.ProjectStartedEventArgs args) { }
        public virtual void Shutdown() { }
        public void TargetFinishedHandler(object sender, Microsoft.Build.Framework.TargetFinishedEventArgs args) { }
        public void TargetStartedHandler(object sender, Microsoft.Build.Framework.TargetStartedEventArgs args) { }
        public void TaskFinishedHandler(object sender, Microsoft.Build.Framework.TaskFinishedEventArgs args) { }
        public void TaskStartedHandler(object sender, Microsoft.Build.Framework.TaskStartedEventArgs args) { }
        public void WarningHandler(object sender, Microsoft.Build.Framework.BuildWarningEventArgs args) { }
    }
    public partial class FileLogger : Microsoft.Build.Logging.ConsoleLogger
    {
        public FileLogger() { }
        public override void Initialize(Microsoft.Build.Framework.IEventSource eventSource) { }
        public override void Shutdown() { }
    }
    public partial class ForwardingLoggerRecord
    {
        public ForwardingLoggerRecord(Microsoft.Build.Framework.ILogger centralLogger, Microsoft.Build.Logging.LoggerDescription forwardingLoggerDescription) { }
        public Microsoft.Build.Framework.ILogger CentralLogger { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        public Microsoft.Build.Logging.LoggerDescription ForwardingLoggerDescription { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
    }
    public partial class LoggerDescription
    {
        public LoggerDescription(string loggerClassName, string loggerAssemblyName, string loggerAssemblyFile, string loggerSwitchParameters, Microsoft.Build.Framework.LoggerVerbosity verbosity) { }
        public string LoggerSwitchParameters { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        public Microsoft.Build.Framework.LoggerVerbosity Verbosity { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        public Microsoft.Build.Framework.ILogger CreateLogger() { throw null; }
    }
    public delegate void WriteHandler(string message);
}
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
