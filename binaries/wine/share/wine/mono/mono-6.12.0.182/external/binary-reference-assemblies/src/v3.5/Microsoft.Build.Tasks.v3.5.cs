// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

[assembly:System.Reflection.AssemblyVersionAttribute("3.5.0.0")]
[assembly:System.CLSCompliantAttribute(true)]
[assembly:System.Diagnostics.DebuggableAttribute((System.Diagnostics.DebuggableAttribute.DebuggingModes)(2))]
[assembly:System.Reflection.AssemblyCompanyAttribute("Mono development team")]
[assembly:System.Reflection.AssemblyCopyrightAttribute("(c) Various Mono authors")]
[assembly:System.Reflection.AssemblyDefaultAliasAttribute("Microsoft.Build.Tasks.dll")]
[assembly:System.Reflection.AssemblyDescriptionAttribute("Microsoft.Build.Tasks.dll")]
[assembly:System.Reflection.AssemblyFileVersionAttribute("3.5.21022.8")]
[assembly:System.Reflection.AssemblyInformationalVersionAttribute("3.5.21022.8")]
[assembly:System.Reflection.AssemblyProductAttribute("Mono Common Language Infrastructure")]
[assembly:System.Reflection.AssemblyTitleAttribute("Microsoft.Build.Tasks.dll")]
[assembly:System.Resources.NeutralResourcesLanguageAttribute("en-US")]
[assembly:System.Resources.SatelliteContractVersionAttribute("3.5.0.0")]
[assembly:System.Runtime.CompilerServices.RuntimeCompatibilityAttribute(WrapNonExceptionThrows=true)]
[assembly:System.Runtime.InteropServices.ComVisibleAttribute(false)]
[assembly:System.Runtime.InteropServices.GuidAttribute("E3D4D3B9-944C-407b-A82E-B19719EA7FB3")]
namespace Microsoft.Build.Tasks
{
    public partial class AL : Microsoft.Build.Tasks.ToolTaskExtension
    {
        public AL() { }
        public string AlgorithmId { get { throw null; } set { } }
        public string BaseAddress { get { throw null; } set { } }
        public string CompanyName { get { throw null; } set { } }
        public string Configuration { get { throw null; } set { } }
        public string Copyright { get { throw null; } set { } }
        public string Culture { get { throw null; } set { } }
        public bool DelaySign { get { throw null; } set { } }
        public string Description { get { throw null; } set { } }
        public Microsoft.Build.Framework.ITaskItem[] EmbedResources { get { throw null; } set { } }
        public string EvidenceFile { get { throw null; } set { } }
        public string FileVersion { get { throw null; } set { } }
        public string Flags { get { throw null; } set { } }
        public bool GenerateFullPaths { get { throw null; } set { } }
        public string KeyContainer { get { throw null; } set { } }
        public string KeyFile { get { throw null; } set { } }
        public Microsoft.Build.Framework.ITaskItem[] LinkResources { get { throw null; } set { } }
        public string MainEntryPoint { get { throw null; } set { } }
        [Microsoft.Build.Framework.OutputAttribute]
        [Microsoft.Build.Framework.RequiredAttribute]
        public Microsoft.Build.Framework.ITaskItem OutputAssembly { get { throw null; } set { } }
        public string Platform { get { throw null; } set { } }
        public string ProductName { get { throw null; } set { } }
        public string ProductVersion { get { throw null; } set { } }
        public string[] ResponseFiles { get { throw null; } set { } }
        public Microsoft.Build.Framework.ITaskItem[] SourceModules { get { throw null; } set { } }
        public string TargetType { get { throw null; } set { } }
        public string TemplateFile { get { throw null; } set { } }
        public string Title { get { throw null; } set { } }
        protected override string ToolName { get { throw null; } }
        public string Trademark { get { throw null; } set { } }
        public string Version { get { throw null; } set { } }
        public string Win32Icon { get { throw null; } set { } }
        public string Win32Resource { get { throw null; } set { } }
        [System.MonoTODOAttribute]
        protected internal override void AddResponseFileCommands(Microsoft.Build.Tasks.CommandLineBuilderExtension commandLine) { }
        public override bool Execute() { throw null; }
        protected override string GenerateFullPathToTool() { throw null; }
    }
    [Microsoft.Build.Framework.LoadInSeparateAppDomainAttribute]
    public abstract partial class AppDomainIsolatedTaskExtension : Microsoft.Build.Utilities.AppDomainIsolatedTask
    {
        internal AppDomainIsolatedTaskExtension() { }
        public Microsoft.Build.Utilities.TaskLoggingHelper Log { get { throw null; } }
    }
    public partial class AspNetCompiler : Microsoft.Build.Tasks.ToolTaskExtension
    {
        public AspNetCompiler() { }
        public bool AllowPartiallyTrustedCallers { get { throw null; } set { } }
        public bool Clean { get { throw null; } set { } }
        public bool Debug { get { throw null; } set { } }
        public bool DelaySign { get { throw null; } set { } }
        public bool FixedNames { get { throw null; } set { } }
        public bool Force { get { throw null; } set { } }
        public string KeyContainer { get { throw null; } set { } }
        public string KeyFile { get { throw null; } set { } }
        public string MetabasePath { get { throw null; } set { } }
        public string PhysicalPath { get { throw null; } set { } }
        public string TargetPath { get { throw null; } set { } }
        protected override string ToolName { get { throw null; } }
        public bool Updateable { get { throw null; } set { } }
        public string VirtualPath { get { throw null; } set { } }
        [System.MonoTODOAttribute]
        protected internal override void AddCommandLineCommands(Microsoft.Build.Tasks.CommandLineBuilderExtension commandLine) { }
        [System.MonoTODOAttribute]
        public override bool Execute() { throw null; }
        [System.MonoTODOAttribute]
        protected override string GenerateFullPathToTool() { throw null; }
        [System.MonoTODOAttribute]
        protected override bool ValidateParameters() { throw null; }
    }
    public partial class AssignCulture : Microsoft.Build.Tasks.TaskExtension
    {
        public AssignCulture() { }
        [Microsoft.Build.Framework.OutputAttribute]
        public Microsoft.Build.Framework.ITaskItem[] AssignedFiles { get { throw null; } }
        [Microsoft.Build.Framework.OutputAttribute]
        public Microsoft.Build.Framework.ITaskItem[] AssignedFilesWithCulture { get { throw null; } }
        [Microsoft.Build.Framework.OutputAttribute]
        public Microsoft.Build.Framework.ITaskItem[] AssignedFilesWithNoCulture { get { throw null; } }
        [Microsoft.Build.Framework.OutputAttribute]
        public Microsoft.Build.Framework.ITaskItem[] CultureNeutralAssignedFiles { get { throw null; } }
        [Microsoft.Build.Framework.RequiredAttribute]
        public Microsoft.Build.Framework.ITaskItem[] Files { get { throw null; } set { } }
        public override bool Execute() { throw null; }
    }
    public partial class AssignProjectConfiguration : Microsoft.Build.Tasks.ResolveProjectBase
    {
        public AssignProjectConfiguration() { }
        [Microsoft.Build.Framework.OutputAttribute]
        public Microsoft.Build.Framework.ITaskItem[] AssignedProjects { get { throw null; } set { } }
        public string SolutionConfigurationContents { get { throw null; } set { } }
        [Microsoft.Build.Framework.OutputAttribute]
        public Microsoft.Build.Framework.ITaskItem[] UnassignedProjects { get { throw null; } set { } }
        [System.MonoTODOAttribute]
        public override bool Execute() { throw null; }
    }
    public partial class AssignTargetPath : Microsoft.Build.Tasks.TaskExtension
    {
        public AssignTargetPath() { }
        [Microsoft.Build.Framework.OutputAttribute]
        public Microsoft.Build.Framework.ITaskItem[] AssignedFiles { get { throw null; } }
        public Microsoft.Build.Framework.ITaskItem[] Files { get { throw null; } set { } }
        [Microsoft.Build.Framework.RequiredAttribute]
        public string RootFolder { get { throw null; } set { } }
        public override bool Execute() { throw null; }
    }
    public partial class CallTarget : Microsoft.Build.Tasks.TaskExtension
    {
        public CallTarget() { }
        public bool RunEachTargetSeparately { get { throw null; } set { } }
        [Microsoft.Build.Framework.OutputAttribute]
        public Microsoft.Build.Framework.ITaskItem[] TargetOutputs { get { throw null; } }
        public string[] Targets { get { throw null; } set { } }
        public override bool Execute() { throw null; }
    }
    [System.MonoTODOAttribute]
    public partial class CombinePath : Microsoft.Build.Tasks.TaskExtension
    {
        public CombinePath() { }
        public string BasePath { get { throw null; } set { } }
        [Microsoft.Build.Framework.OutputAttribute]
        public Microsoft.Build.Framework.ITaskItem[] CombinedPaths { get { throw null; } set { } }
        [Microsoft.Build.Framework.RequiredAttribute]
        public Microsoft.Build.Framework.ITaskItem[] Paths { get { throw null; } set { } }
        public override bool Execute() { throw null; }
    }
    public partial class CommandLineBuilderExtension : Microsoft.Build.Utilities.CommandLineBuilder
    {
        public CommandLineBuilderExtension() { }
    }
    public partial class Copy : Microsoft.Build.Tasks.TaskExtension
    {
        public Copy() { }
        [Microsoft.Build.Framework.OutputAttribute]
        public Microsoft.Build.Framework.ITaskItem[] CopiedFiles { get { throw null; } }
        [Microsoft.Build.Framework.OutputAttribute]
        public Microsoft.Build.Framework.ITaskItem[] DestinationFiles { get { throw null; } set { } }
        public Microsoft.Build.Framework.ITaskItem DestinationFolder { get { throw null; } set { } }
        public bool OverwriteReadOnlyFiles { get { throw null; } set { } }
        public bool SkipUnchangedFiles { get { throw null; } set { } }
        [Microsoft.Build.Framework.RequiredAttribute]
        public Microsoft.Build.Framework.ITaskItem[] SourceFiles { get { throw null; } set { } }
        public override bool Execute() { throw null; }
    }
    public partial class CreateCSharpManifestResourceName : Microsoft.Build.Tasks.CreateManifestResourceName
    {
        public CreateCSharpManifestResourceName() { }
        protected override string CreateManifestName(string fileName, string linkFileName, string rootNamespace, string dependentUponFileName, System.IO.Stream binaryStream) { throw null; }
        protected override bool IsSourceFile(string fileName) { throw null; }
    }
    public partial class CreateItem : Microsoft.Build.Tasks.TaskExtension
    {
        public CreateItem() { }
        public string[] AdditionalMetadata { get { throw null; } set { } }
        public Microsoft.Build.Framework.ITaskItem[] Exclude { get { throw null; } set { } }
        [Microsoft.Build.Framework.OutputAttribute]
        public Microsoft.Build.Framework.ITaskItem[] Include { get { throw null; } set { } }
        public bool PreserveExistingMetadata { get { throw null; } set { } }
        public override bool Execute() { throw null; }
    }
    public abstract partial class CreateManifestResourceName : Microsoft.Build.Tasks.TaskExtension
    {
        protected CreateManifestResourceName() { }
        [Microsoft.Build.Framework.OutputAttribute]
        public Microsoft.Build.Framework.ITaskItem[] ManifestResourceNames { get { throw null; } }
        [Microsoft.Build.Framework.RequiredAttribute]
        public Microsoft.Build.Framework.ITaskItem[] ResourceFiles { get { throw null; } set { } }
        public string RootNamespace { get { throw null; } set { } }
        protected abstract string CreateManifestName(string fileName, string linkFileName, string rootNamespaceName, string dependentUponFileName, System.IO.Stream binaryStream);
        public override bool Execute() { throw null; }
        protected abstract bool IsSourceFile(string fileName);
        [System.MonoTODOAttribute]
        public static string MakeValidEverettIdentifier(string name) { throw null; }
    }
    public partial class CreateProperty : Microsoft.Build.Tasks.TaskExtension
    {
        public CreateProperty() { }
        [Microsoft.Build.Framework.OutputAttribute]
        public string[] Value { get { throw null; } set { } }
        [Microsoft.Build.Framework.OutputAttribute]
        [System.MonoTODOAttribute]
        public string[] ValueSetByTask { get { throw null; } }
        public override bool Execute() { throw null; }
    }
    public partial class CreateTemporaryVCProject : Microsoft.Build.Tasks.TaskExtension
    {
        [System.MonoTODOAttribute]
        public CreateTemporaryVCProject() { }
        [Microsoft.Build.Framework.RequiredAttribute]
        [System.MonoTODOAttribute]
        public string Configuration { get { throw null; } set { } }
        [Microsoft.Build.Framework.RequiredAttribute]
        [System.MonoTODOAttribute]
        public Microsoft.Build.Framework.ITaskItem OutputProjectFile { get { throw null; } set { } }
        [Microsoft.Build.Framework.RequiredAttribute]
        [System.MonoTODOAttribute]
        public Microsoft.Build.Framework.ITaskItem ProjectFile { get { throw null; } set { } }
        [System.MonoTODOAttribute]
        public Microsoft.Build.Framework.ITaskItem[] ReferenceAssemblies { get { throw null; } set { } }
        [Microsoft.Build.Framework.RequiredAttribute]
        [System.MonoTODOAttribute]
        public Microsoft.Build.Framework.ITaskItem[] ReferenceGuids { get { throw null; } set { } }
        [System.MonoTODOAttribute]
        public Microsoft.Build.Framework.ITaskItem[] ReferenceImportLibraries { get { throw null; } set { } }
        [System.MonoTODOAttribute]
        public override bool Execute() { throw null; }
    }
    public partial class CreateVisualBasicManifestResourceName : Microsoft.Build.Tasks.CreateManifestResourceName
    {
        public CreateVisualBasicManifestResourceName() { }
        protected override string CreateManifestName(string fileName, string linkFileName, string rootNamespace, string dependentUponFileName, System.IO.Stream binaryStream) { throw null; }
        protected override bool IsSourceFile(string fileName) { throw null; }
    }
    public partial class Csc : Microsoft.Build.Tasks.ManagedCompiler
    {
        public Csc() { }
        public bool AllowUnsafeBlocks { get { throw null; } set { } }
        public string BaseAddress { get { throw null; } set { } }
        public bool CheckForOverflowUnderflow { get { throw null; } set { } }
        public string DisabledWarnings { get { throw null; } set { } }
        public string DocumentationFile { get { throw null; } set { } }
        public string ErrorReport { get { throw null; } set { } }
        public bool GenerateFullPaths { get { throw null; } set { } }
        public string LangVersion { get { throw null; } set { } }
        public string ModuleAssemblyName { get { throw null; } set { } }
        public bool NoStandardLib { get { throw null; } set { } }
        public string PdbFile { get { throw null; } set { } }
        public string Platform { get { throw null; } set { } }
        protected override string ToolName { get { throw null; } }
        public bool UseHostCompilerIfAvailable { get { throw null; } set { } }
        public int WarningLevel { get { throw null; } set { } }
        public string WarningsAsErrors { get { throw null; } set { } }
        public string WarningsNotAsErrors { get { throw null; } set { } }
        protected internal override void AddResponseFileCommands(Microsoft.Build.Tasks.CommandLineBuilderExtension commandLine) { }
        [System.MonoTODOAttribute]
        protected override bool CallHostObjectToExecute() { throw null; }
        protected override string GenerateFullPathToTool() { throw null; }
        [System.MonoTODOAttribute]
        protected override Microsoft.Build.Utilities.HostObjectInitializationStatus InitializeHostObject() { throw null; }
    }
    public sealed partial class Delete : Microsoft.Build.Tasks.TaskExtension
    {
        public Delete() { }
        [Microsoft.Build.Framework.OutputAttribute]
        public Microsoft.Build.Framework.ITaskItem[] DeletedFiles { get { throw null; } set { } }
        [Microsoft.Build.Framework.RequiredAttribute]
        public Microsoft.Build.Framework.ITaskItem[] Files { get { throw null; } set { } }
        public bool TreatErrorsAsWarnings { get { throw null; } set { } }
        public override bool Execute() { throw null; }
    }
    public sealed partial class Error : Microsoft.Build.Tasks.TaskExtension
    {
        public Error() { }
        public string Code { get { throw null; } set { } }
        public string File { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public string HelpKeyword { get { throw null; } set { } }
        public string Text { get { throw null; } set { } }
        public override bool Execute() { throw null; }
    }
    public partial class Exec : Microsoft.Build.Tasks.ToolTaskExtension
    {
        public Exec() { }
        [Microsoft.Build.Framework.RequiredAttribute]
        public string Command { get { throw null; } set { } }
        public bool IgnoreExitCode { get { throw null; } set { } }
        [Microsoft.Build.Framework.OutputAttribute]
        public Microsoft.Build.Framework.ITaskItem[] Outputs { get { throw null; } set { } }
        protected override System.Text.Encoding StandardErrorEncoding { get { throw null; } }
        protected override Microsoft.Build.Framework.MessageImportance StandardErrorLoggingImportance { get { throw null; } }
        protected override System.Text.Encoding StandardOutputEncoding { get { throw null; } }
        protected override Microsoft.Build.Framework.MessageImportance StandardOutputLoggingImportance { get { throw null; } }
        [Microsoft.Build.Framework.OutputAttribute]
        [System.MonoTODOAttribute]
        public string StdErrEncoding { get { throw null; } set { } }
        [Microsoft.Build.Framework.OutputAttribute]
        [System.MonoTODOAttribute]
        public string StdOutEncoding { get { throw null; } set { } }
        [System.MonoTODOAttribute]
        protected override string ToolName { get { throw null; } }
        public string WorkingDirectory { get { throw null; } set { } }
        protected internal override void AddCommandLineCommands(Microsoft.Build.Tasks.CommandLineBuilderExtension commandLine) { }
        protected override int ExecuteTool(string pathToTool, string responseFileCommands, string commandLineCommands) { throw null; }
        [System.MonoTODOAttribute]
        protected override string GenerateFullPathToTool() { throw null; }
        protected override string GetWorkingDirectory() { throw null; }
        protected override bool HandleTaskExecutionErrors() { throw null; }
        protected override void LogEventsFromTextOutput(string singleLine, Microsoft.Build.Framework.MessageImportance messageImportance) { }
        [System.MonoTODOAttribute]
        protected override void LogPathToTool(string toolName, string pathToTool) { }
        [System.MonoTODOAttribute]
        protected override void LogToolCommand(string message) { }
        [System.MonoTODOAttribute]
        protected override bool ValidateParameters() { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public partial struct ExtractedClassName
    {
        public bool IsInsideConditionalBlock { get { throw null; } set { } }
        public string Name { get { throw null; } set { } }
    }
    public partial class FindAppConfigFile : Microsoft.Build.Tasks.TaskExtension
    {
        public FindAppConfigFile() { }
        [Microsoft.Build.Framework.OutputAttribute]
        public Microsoft.Build.Framework.ITaskItem AppConfigFile { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        [Microsoft.Build.Framework.RequiredAttribute]
        public Microsoft.Build.Framework.ITaskItem[] PrimaryList { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        [Microsoft.Build.Framework.RequiredAttribute]
        public Microsoft.Build.Framework.ITaskItem[] SecondaryList { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        [Microsoft.Build.Framework.RequiredAttribute]
        public string TargetPath { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public override bool Execute() { throw null; }
    }
    public partial class FindUnderPath : Microsoft.Build.Tasks.TaskExtension
    {
        public FindUnderPath() { }
        public Microsoft.Build.Framework.ITaskItem[] Files { get { throw null; } set { } }
        [Microsoft.Build.Framework.OutputAttribute]
        public Microsoft.Build.Framework.ITaskItem[] InPath { get { throw null; } set { } }
        [Microsoft.Build.Framework.OutputAttribute]
        public Microsoft.Build.Framework.ITaskItem[] OutOfPath { get { throw null; } set { } }
        [Microsoft.Build.Framework.RequiredAttribute]
        public Microsoft.Build.Framework.ITaskItem Path { get { throw null; } set { } }
        public override bool Execute() { throw null; }
    }
    public sealed partial class FormatUrl : Microsoft.Build.Tasks.TaskExtension
    {
        public FormatUrl() { }
        public string InputUrl { get { throw null; } set { } }
        [Microsoft.Build.Framework.OutputAttribute]
        public string OutputUrl { get { throw null; } set { } }
        [System.MonoTODOAttribute]
        public override bool Execute() { throw null; }
    }
    public sealed partial class FormatVersion : Microsoft.Build.Tasks.TaskExtension
    {
        public FormatVersion() { }
        public string FormatType { get { throw null; } set { } }
        [Microsoft.Build.Framework.OutputAttribute]
        public string OutputVersion { get { throw null; } set { } }
        public int Revision { get { throw null; } set { } }
        public string Version { get { throw null; } set { } }
        public override bool Execute() { throw null; }
    }
    public sealed partial class GenerateApplicationManifest : Microsoft.Build.Tasks.GenerateManifestBase
    {
        public GenerateApplicationManifest() { }
        public string ClrVersion { get { throw null; } set { } }
        public Microsoft.Build.Framework.ITaskItem ConfigFile { get { throw null; } set { } }
        public Microsoft.Build.Framework.ITaskItem[] Dependencies { get { throw null; } set { } }
        public Microsoft.Build.Framework.ITaskItem[] Files { get { throw null; } set { } }
        public Microsoft.Build.Framework.ITaskItem IconFile { get { throw null; } set { } }
        public Microsoft.Build.Framework.ITaskItem[] IsolatedComReferences { get { throw null; } set { } }
        public string ManifestType { get { throw null; } set { } }
        public string OSVersion { get { throw null; } set { } }
        public Microsoft.Build.Framework.ITaskItem TrustInfoFile { get { throw null; } set { } }
        [System.MonoTODOAttribute]
        protected override System.Type GetObjectType() { throw null; }
        [System.MonoTODOAttribute]
        protected override bool OnManifestLoaded(Microsoft.Build.Tasks.Deployment.ManifestUtilities.Manifest manifest) { throw null; }
        [System.MonoTODOAttribute]
        protected override bool OnManifestResolved(Microsoft.Build.Tasks.Deployment.ManifestUtilities.Manifest manifest) { throw null; }
        [System.MonoTODOAttribute]
        protected internal override bool ValidateInputs() { throw null; }
    }
    public sealed partial class GenerateBootstrapper : Microsoft.Build.Tasks.TaskExtension
    {
        public GenerateBootstrapper() { }
        public string ApplicationFile { get { throw null; } set { } }
        public string ApplicationName { get { throw null; } set { } }
        public string ApplicationUrl { get { throw null; } set { } }
        [Microsoft.Build.Framework.OutputAttribute]
        public string[] BootstrapperComponentFiles { get { throw null; } set { } }
        public Microsoft.Build.Framework.ITaskItem[] BootstrapperItems { get { throw null; } set { } }
        [Microsoft.Build.Framework.OutputAttribute]
        public string BootstrapperKeyFile { get { throw null; } set { } }
        public string ComponentsLocation { get { throw null; } set { } }
        public string ComponentsUrl { get { throw null; } set { } }
        public bool CopyComponents { get { throw null; } set { } }
        public string Culture { get { throw null; } set { } }
        public string FallbackCulture { get { throw null; } set { } }
        public string OutputPath { get { throw null; } set { } }
        public string Path { get { throw null; } set { } }
        public string SupportUrl { get { throw null; } set { } }
        public bool Validate { get { throw null; } set { } }
        public override bool Execute() { throw null; }
    }
    public sealed partial class GenerateDeploymentManifest : Microsoft.Build.Tasks.GenerateManifestBase
    {
        [System.MonoTODOAttribute]
        public GenerateDeploymentManifest() { }
        [System.MonoTODOAttribute]
        public string DeploymentUrl { get { throw null; } set { } }
        [System.MonoTODOAttribute]
        public bool DisallowUrlActivation { get { throw null; } set { } }
        [System.MonoTODOAttribute]
        public bool Install { get { throw null; } set { } }
        [System.MonoTODOAttribute]
        public bool MapFileExtensions { get { throw null; } set { } }
        [System.MonoTODOAttribute]
        public string MinimumRequiredVersion { get { throw null; } set { } }
        [System.MonoTODOAttribute]
        public string Product { get { throw null; } set { } }
        [System.MonoTODOAttribute]
        public string Publisher { get { throw null; } set { } }
        [System.MonoTODOAttribute]
        public string SupportUrl { get { throw null; } set { } }
        [System.MonoTODOAttribute]
        public bool TrustUrlParameters { get { throw null; } set { } }
        [System.MonoTODOAttribute]
        public bool UpdateEnabled { get { throw null; } set { } }
        [System.MonoTODOAttribute]
        public int UpdateInterval { get { throw null; } set { } }
        [System.MonoTODOAttribute]
        public string UpdateMode { get { throw null; } set { } }
        [System.MonoTODOAttribute]
        public string UpdateUnit { get { throw null; } set { } }
        protected override System.Type GetObjectType() { throw null; }
        protected override bool OnManifestLoaded(Microsoft.Build.Tasks.Deployment.ManifestUtilities.Manifest manifest) { throw null; }
        protected override bool OnManifestResolved(Microsoft.Build.Tasks.Deployment.ManifestUtilities.Manifest manifest) { throw null; }
        protected internal override bool ValidateInputs() { throw null; }
    }
    public abstract partial class GenerateManifestBase : Microsoft.Build.Utilities.Task
    {
        protected GenerateManifestBase() { }
        public string AssemblyName { get { throw null; } set { } }
        public string AssemblyVersion { get { throw null; } set { } }
        public string Description { get { throw null; } set { } }
        public Microsoft.Build.Framework.ITaskItem EntryPoint { get { throw null; } set { } }
        public Microsoft.Build.Framework.ITaskItem InputManifest { get { throw null; } set { } }
        public int MaxTargetPath { get { throw null; } set { } }
        [Microsoft.Build.Framework.OutputAttribute]
        public Microsoft.Build.Framework.ITaskItem OutputManifest { get { throw null; } set { } }
        public string Platform { get { throw null; } set { } }
        public string TargetCulture { get { throw null; } set { } }
        [System.MonoTODOAttribute]
        protected internal Microsoft.Build.Tasks.Deployment.ManifestUtilities.AssemblyReference AddAssemblyFromItem(Microsoft.Build.Framework.ITaskItem item) { throw null; }
        [System.MonoTODOAttribute]
        protected internal Microsoft.Build.Tasks.Deployment.ManifestUtilities.AssemblyReference AddAssemblyNameFromItem(Microsoft.Build.Framework.ITaskItem item, Microsoft.Build.Tasks.Deployment.ManifestUtilities.AssemblyReferenceType referenceType) { throw null; }
        [System.MonoTODOAttribute]
        protected internal Microsoft.Build.Tasks.Deployment.ManifestUtilities.AssemblyReference AddEntryPointFromItem(Microsoft.Build.Framework.ITaskItem item, Microsoft.Build.Tasks.Deployment.ManifestUtilities.AssemblyReferenceType referenceType) { throw null; }
        [System.MonoTODOAttribute]
        protected internal Microsoft.Build.Tasks.Deployment.ManifestUtilities.FileReference AddFileFromItem(Microsoft.Build.Framework.ITaskItem item) { throw null; }
        [System.MonoTODOAttribute]
        public override bool Execute() { throw null; }
        [System.MonoTODOAttribute]
        protected internal Microsoft.Build.Tasks.Deployment.ManifestUtilities.FileReference FindFileFromItem(Microsoft.Build.Framework.ITaskItem item) { throw null; }
        [System.MonoTODOAttribute]
        protected abstract System.Type GetObjectType();
        [System.MonoTODOAttribute]
        protected abstract bool OnManifestLoaded(Microsoft.Build.Tasks.Deployment.ManifestUtilities.Manifest manifest);
        [System.MonoTODOAttribute]
        protected abstract bool OnManifestResolved(Microsoft.Build.Tasks.Deployment.ManifestUtilities.Manifest manifest);
        [System.MonoTODOAttribute]
        protected internal virtual bool ValidateInputs() { throw null; }
        [System.MonoTODOAttribute]
        protected internal virtual bool ValidateOutput() { throw null; }
    }
    public sealed partial class GenerateResource : Microsoft.Build.Tasks.TaskExtension
    {
        public GenerateResource() { }
        [Microsoft.Build.Framework.OutputAttribute]
        public Microsoft.Build.Framework.ITaskItem[] FilesWritten { get { throw null; } }
        [System.MonoTODOAttribute]
        public bool NeverLockTypeAssemblies { get { throw null; } set { } }
        [Microsoft.Build.Framework.OutputAttribute]
        public Microsoft.Build.Framework.ITaskItem[] OutputResources { get { throw null; } set { } }
        public bool PublicClass { get { throw null; } set { } }
        public Microsoft.Build.Framework.ITaskItem[] References { get { throw null; } set { } }
        [Microsoft.Build.Framework.RequiredAttribute]
        public Microsoft.Build.Framework.ITaskItem[] Sources { get { throw null; } set { } }
        public Microsoft.Build.Framework.ITaskItem StateFile { get { throw null; } set { } }
        [Microsoft.Build.Framework.OutputAttribute]
        public string StronglyTypedClassName { get { throw null; } set { } }
        [Microsoft.Build.Framework.OutputAttribute]
        public string StronglyTypedFileName { get { throw null; } set { } }
        public string StronglyTypedLanguage { get { throw null; } set { } }
        public string StronglyTypedNamespace { get { throw null; } set { } }
        public bool UseSourcePath { get { throw null; } set { } }
        public override bool Execute() { throw null; }
    }
    public sealed partial class GenerateTrustInfo : Microsoft.Build.Tasks.TaskExtension
    {
        public GenerateTrustInfo() { }
        public Microsoft.Build.Framework.ITaskItem BaseManifest { get { throw null; } set { } }
        public string ExcludedPermissions { get { throw null; } set { } }
        public string TargetZone { get { throw null; } set { } }
        [Microsoft.Build.Framework.OutputAttribute]
        [Microsoft.Build.Framework.RequiredAttribute]
        public Microsoft.Build.Framework.ITaskItem TrustInfoFile { get { throw null; } set { } }
        public override bool Execute() { throw null; }
    }
    public partial class GetAssemblyIdentity : Microsoft.Build.Tasks.TaskExtension
    {
        public GetAssemblyIdentity() { }
        [Microsoft.Build.Framework.OutputAttribute]
        public Microsoft.Build.Framework.ITaskItem[] Assemblies { get { throw null; } set { } }
        [Microsoft.Build.Framework.RequiredAttribute]
        public Microsoft.Build.Framework.ITaskItem[] AssemblyFiles { get { throw null; } set { } }
        [System.MonoTODOAttribute("Error handling")]
        public override bool Execute() { throw null; }
    }
    public partial class GetFrameworkPath : Microsoft.Build.Tasks.TaskExtension
    {
        public GetFrameworkPath() { }
        [Microsoft.Build.Framework.OutputAttribute]
        public string FrameworkVersion11Path { get { throw null; } }
        [Microsoft.Build.Framework.OutputAttribute]
        public string FrameworkVersion20Path { get { throw null; } }
        [Microsoft.Build.Framework.OutputAttribute]
        public string FrameworkVersion30Path { get { throw null; } }
        [Microsoft.Build.Framework.OutputAttribute]
        public string FrameworkVersion35Path { get { throw null; } }
        [Microsoft.Build.Framework.OutputAttribute]
        public string Path { get { throw null; } set { } }
        public override bool Execute() { throw null; }
    }
    public partial class GetFrameworkSdkPath : Microsoft.Build.Tasks.TaskExtension
    {
        public GetFrameworkSdkPath() { }
        [Microsoft.Build.Framework.OutputAttribute]
        public string Path { get { throw null; } set { } }
        public override bool Execute() { throw null; }
    }
    public partial class LC : Microsoft.Build.Tasks.ToolTaskExtension
    {
        public LC() { }
        [Microsoft.Build.Framework.RequiredAttribute]
        public Microsoft.Build.Framework.ITaskItem LicenseTarget { get { throw null; } set { } }
        public bool NoLogo { get { throw null; } set { } }
        public string OutputDirectory { get { throw null; } set { } }
        [Microsoft.Build.Framework.OutputAttribute]
        public Microsoft.Build.Framework.ITaskItem OutputLicense { get { throw null; } set { } }
        public Microsoft.Build.Framework.ITaskItem[] ReferencedAssemblies { get { throw null; } set { } }
        [Microsoft.Build.Framework.RequiredAttribute]
        public Microsoft.Build.Framework.ITaskItem[] Sources { get { throw null; } set { } }
        protected override string ToolName { get { throw null; } }
        protected internal override void AddCommandLineCommands(Microsoft.Build.Tasks.CommandLineBuilderExtension commandLine) { }
        protected override string GenerateFullPathToTool() { throw null; }
        protected override bool ValidateParameters() { throw null; }
    }
    public partial class MakeDir : Microsoft.Build.Tasks.TaskExtension
    {
        public MakeDir() { }
        [Microsoft.Build.Framework.RequiredAttribute]
        public Microsoft.Build.Framework.ITaskItem[] Directories { get { throw null; } set { } }
        [Microsoft.Build.Framework.OutputAttribute]
        public Microsoft.Build.Framework.ITaskItem[] DirectoriesCreated { get { throw null; } }
        public override bool Execute() { throw null; }
    }
    public abstract partial class ManagedCompiler : Microsoft.Build.Tasks.ToolTaskExtension
    {
        protected ManagedCompiler() { }
        public string[] AdditionalLibPaths { get { throw null; } set { } }
        public string[] AddModules { get { throw null; } set { } }
        public int CodePage { get { throw null; } set { } }
        public string DebugType { get { throw null; } set { } }
        public string DefineConstants { get { throw null; } set { } }
        public bool DelaySign { get { throw null; } set { } }
        public bool EmitDebugInformation { get { throw null; } set { } }
        public int FileAlignment { get { throw null; } set { } }
        protected bool HostCompilerSupportsAllParameters { get { throw null; } set { } }
        public string KeyContainer { get { throw null; } set { } }
        public string KeyFile { get { throw null; } set { } }
        public Microsoft.Build.Framework.ITaskItem[] LinkResources { get { throw null; } set { } }
        public string MainEntryPoint { get { throw null; } set { } }
        public bool NoConfig { get { throw null; } set { } }
        public bool NoLogo { get { throw null; } set { } }
        public bool Optimize { get { throw null; } set { } }
        [Microsoft.Build.Framework.OutputAttribute]
        public Microsoft.Build.Framework.ITaskItem OutputAssembly { get { throw null; } set { } }
        public Microsoft.Build.Framework.ITaskItem[] References { get { throw null; } set { } }
        public Microsoft.Build.Framework.ITaskItem[] Resources { get { throw null; } set { } }
        public Microsoft.Build.Framework.ITaskItem[] ResponseFiles { get { throw null; } set { } }
        public Microsoft.Build.Framework.ITaskItem[] Sources { get { throw null; } set { } }
        protected override System.Text.Encoding StandardOutputEncoding { get { throw null; } }
        public string TargetType { get { throw null; } set { } }
        public bool TreatWarningsAsErrors { get { throw null; } set { } }
        public bool Utf8Output { get { throw null; } set { } }
        public string Win32Icon { get { throw null; } set { } }
        public string Win32Resource { get { throw null; } set { } }
        [System.MonoTODOAttribute]
        protected internal override void AddCommandLineCommands(Microsoft.Build.Tasks.CommandLineBuilderExtension commandLine) { }
        [System.MonoTODOAttribute]
        protected internal override void AddResponseFileCommands(Microsoft.Build.Tasks.CommandLineBuilderExtension commandLine) { }
        [System.MonoTODOAttribute]
        protected bool CheckAllReferencesExistOnDisk() { throw null; }
        [System.MonoTODOAttribute]
        protected void CheckHostObjectSupport(string parameterName, bool resultFromHostObjectSetOperation) { }
        [System.MonoTODOAttribute]
        protected override bool HandleTaskExecutionErrors() { throw null; }
        [System.MonoTODOAttribute]
        protected bool ListHasNoDuplicateItems(Microsoft.Build.Framework.ITaskItem[] itemList, string parameterName) { throw null; }
        protected internal virtual bool UseAlternateCommandLineToolToExecute() { throw null; }
        [System.MonoTODOAttribute]
        protected override bool ValidateParameters() { throw null; }
    }
    public sealed partial class Message : Microsoft.Build.Tasks.TaskExtension
    {
        public Message() { }
        public string Importance { get { throw null; } set { } }
        public string Text { get { throw null; } set { } }
        public override bool Execute() { throw null; }
    }
    [System.MonoTODOAttribute]
    public partial class MSBuild : Microsoft.Build.Tasks.TaskExtension
    {
        public MSBuild() { }
        public bool BuildInParallel { get { throw null; } set { } }
        [Microsoft.Build.Framework.RequiredAttribute]
        public Microsoft.Build.Framework.ITaskItem[] Projects { get { throw null; } set { } }
        [System.MonoTODOAttribute]
        public string[] Properties { get { throw null; } set { } }
        public bool RebaseOutputs { get { throw null; } set { } }
        [System.MonoTODOAttribute]
        public bool RunEachTargetSeparately { get { throw null; } set { } }
        public bool StopOnFirstFailure { get { throw null; } set { } }
        [Microsoft.Build.Framework.OutputAttribute]
        public Microsoft.Build.Framework.ITaskItem[] TargetOutputs { get { throw null; } }
        public string[] Targets { get { throw null; } set { } }
        public string ToolsVersion { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public override bool Execute() { throw null; }
    }
    public partial class ReadLinesFromFile : Microsoft.Build.Tasks.TaskExtension
    {
        public ReadLinesFromFile() { }
        [Microsoft.Build.Framework.RequiredAttribute]
        public Microsoft.Build.Framework.ITaskItem File { get { throw null; } set { } }
        [Microsoft.Build.Framework.OutputAttribute]
        public Microsoft.Build.Framework.ITaskItem[] Lines { get { throw null; } set { } }
        public override bool Execute() { throw null; }
    }
    public partial class RegisterAssembly : Microsoft.Build.Tasks.AppDomainIsolatedTaskExtension, System.Runtime.InteropServices.ITypeLibExporterNotifySink
    {
        public RegisterAssembly() { }
        [Microsoft.Build.Framework.RequiredAttribute]
        public Microsoft.Build.Framework.ITaskItem[] Assemblies { get { throw null; } set { } }
        public Microsoft.Build.Framework.ITaskItem AssemblyListFile { get { throw null; } set { } }
        public bool CreateCodeBase { get { throw null; } set { } }
        [Microsoft.Build.Framework.OutputAttribute]
        public Microsoft.Build.Framework.ITaskItem[] TypeLibFiles { get { throw null; } set { } }
        public override bool Execute() { throw null; }
        public void ReportEvent(System.Runtime.InteropServices.ExporterEventKind kind, int code, string msg) { }
        public object ResolveRef(System.Reflection.Assembly assemblyToResolve) { throw null; }
    }
    public partial class RemoveDir : Microsoft.Build.Tasks.TaskExtension
    {
        public RemoveDir() { }
        [Microsoft.Build.Framework.RequiredAttribute]
        public Microsoft.Build.Framework.ITaskItem[] Directories { get { throw null; } set { } }
        [Microsoft.Build.Framework.OutputAttribute]
        public Microsoft.Build.Framework.ITaskItem[] RemovedDirectories { get { throw null; } set { } }
        public override bool Execute() { throw null; }
    }
    public partial class RemoveDuplicates : Microsoft.Build.Tasks.TaskExtension
    {
        public RemoveDuplicates() { }
        [Microsoft.Build.Framework.OutputAttribute]
        public Microsoft.Build.Framework.ITaskItem[] Filtered { get { throw null; } set { } }
        public Microsoft.Build.Framework.ITaskItem[] Inputs { get { throw null; } set { } }
        [System.MonoTODOAttribute]
        public override bool Execute() { throw null; }
    }
    public partial class ResolveAssemblyReference : Microsoft.Build.Tasks.TaskExtension
    {
        public ResolveAssemblyReference() { }
        public string[] AllowedAssemblyExtensions { get { throw null; } set { } }
        public string[] AllowedRelatedFileExtensions { get { throw null; } set { } }
        public string AppConfigFile { get { throw null; } set { } }
        public Microsoft.Build.Framework.ITaskItem[] Assemblies { get { throw null; } set { } }
        public Microsoft.Build.Framework.ITaskItem[] AssemblyFiles { get { throw null; } set { } }
        public bool AutoUnify { get { throw null; } set { } }
        public string[] CandidateAssemblyFiles { get { throw null; } set { } }
        [Microsoft.Build.Framework.OutputAttribute]
        public Microsoft.Build.Framework.ITaskItem[] CopyLocalFiles { get { throw null; } }
        [Microsoft.Build.Framework.OutputAttribute]
        public Microsoft.Build.Framework.ITaskItem[] FilesWritten { get { throw null; } set { } }
        public bool FindDependencies { get { throw null; } set { } }
        public bool FindRelatedFiles { get { throw null; } set { } }
        public bool FindSatellites { get { throw null; } set { } }
        public bool FindSerializationAssemblies { get { throw null; } set { } }
        public string[] InstalledAssemblyTables { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        [Microsoft.Build.Framework.OutputAttribute]
        public Microsoft.Build.Framework.ITaskItem[] RelatedFiles { get { throw null; } }
        [Microsoft.Build.Framework.OutputAttribute]
        public Microsoft.Build.Framework.ITaskItem[] ResolvedDependencyFiles { get { throw null; } }
        [Microsoft.Build.Framework.OutputAttribute]
        public Microsoft.Build.Framework.ITaskItem[] ResolvedFiles { get { throw null; } }
        [Microsoft.Build.Framework.OutputAttribute]
        public Microsoft.Build.Framework.ITaskItem[] SatelliteFiles { get { throw null; } }
        [Microsoft.Build.Framework.OutputAttribute]
        public Microsoft.Build.Framework.ITaskItem[] ScatterFiles { get { throw null; } }
        [Microsoft.Build.Framework.RequiredAttribute]
        public string[] SearchPaths { get { throw null; } set { } }
        [Microsoft.Build.Framework.OutputAttribute]
        public Microsoft.Build.Framework.ITaskItem[] SerializationAssemblyFiles { get { throw null; } }
        public bool Silent { get { throw null; } set { } }
        public string StateFile { get { throw null; } set { } }
        [Microsoft.Build.Framework.OutputAttribute]
        public Microsoft.Build.Framework.ITaskItem[] SuggestedRedirects { get { throw null; } }
        public string[] TargetFrameworkDirectories { get { throw null; } set { } }
        public string TargetFrameworkVersion { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public string TargetProcessorArchitecture { get { throw null; } set { } }
        public override bool Execute() { throw null; }
    }
    public sealed partial class ResolveManifestFiles : Microsoft.Build.Tasks.TaskExtension
    {
        public ResolveManifestFiles() { }
        public Microsoft.Build.Framework.ITaskItem EntryPoint { get { throw null; } set { } }
        public Microsoft.Build.Framework.ITaskItem[] ExtraFiles { get { throw null; } set { } }
        public Microsoft.Build.Framework.ITaskItem[] Files { get { throw null; } set { } }
        public Microsoft.Build.Framework.ITaskItem[] ManagedAssemblies { get { throw null; } set { } }
        public Microsoft.Build.Framework.ITaskItem[] NativeAssemblies { get { throw null; } set { } }
        public Microsoft.Build.Framework.ITaskItem[] OutputAssemblies { get { throw null; } set { } }
        public Microsoft.Build.Framework.ITaskItem[] OutputFiles { get { throw null; } set { } }
        public Microsoft.Build.Framework.ITaskItem[] PublishFiles { get { throw null; } set { } }
        public Microsoft.Build.Framework.ITaskItem[] SatelliteAssemblies { get { throw null; } set { } }
        public string TargetCulture { get { throw null; } set { } }
        [System.MonoTODOAttribute]
        public override bool Execute() { throw null; }
    }
    public abstract partial class ResolveProjectBase : Microsoft.Build.Tasks.TaskExtension
    {
        [System.MonoTODOAttribute]
        protected ResolveProjectBase() { }
        [Microsoft.Build.Framework.RequiredAttribute]
        public Microsoft.Build.Framework.ITaskItem[] ProjectReferences { get { throw null; } set { } }
        [System.MonoTODOAttribute]
        protected string GetProjectItem(Microsoft.Build.Framework.ITaskItem projectRef) { throw null; }
    }
    public partial class SGen : Microsoft.Build.Tasks.ToolTaskExtension
    {
        public SGen() { }
        [Microsoft.Build.Framework.RequiredAttribute]
        [System.MonoTODOAttribute]
        public string BuildAssemblyName { get { throw null; } set { } }
        [Microsoft.Build.Framework.RequiredAttribute]
        [System.MonoTODOAttribute]
        public string BuildAssemblyPath { get { throw null; } set { } }
        [System.MonoTODOAttribute]
        public bool DelaySign { get { throw null; } set { } }
        [System.MonoTODOAttribute]
        public string KeyContainer { get { throw null; } set { } }
        [System.MonoTODOAttribute]
        public string KeyFile { get { throw null; } set { } }
        [System.MonoTODOAttribute]
        public string[] References { get { throw null; } set { } }
        [Microsoft.Build.Framework.OutputAttribute]
        [System.MonoTODOAttribute]
        public Microsoft.Build.Framework.ITaskItem[] SerializationAssembly { get { throw null; } set { } }
        [System.MonoTODOAttribute]
        public string SerializationAssemblyName { get { throw null; } }
        [Microsoft.Build.Framework.RequiredAttribute]
        [System.MonoTODOAttribute]
        public bool ShouldGenerateSerializer { get { throw null; } set { } }
        [System.MonoTODOAttribute]
        protected override string ToolName { get { throw null; } }
        [Microsoft.Build.Framework.RequiredAttribute]
        [System.MonoTODOAttribute]
        public bool UseProxyTypes { get { throw null; } set { } }
        [System.MonoTODOAttribute]
        protected override string GenerateCommandLineCommands() { throw null; }
        [System.MonoTODOAttribute]
        protected override string GenerateFullPathToTool() { throw null; }
        [System.MonoTODOAttribute]
        protected override bool SkipTaskExecution() { throw null; }
        [System.MonoTODOAttribute]
        protected override bool ValidateParameters() { throw null; }
    }
    public sealed partial class SignFile : Microsoft.Build.Utilities.Task
    {
        public SignFile() { }
        [Microsoft.Build.Framework.RequiredAttribute]
        public string CertificateThumbprint { get { throw null; } set { } }
        [Microsoft.Build.Framework.RequiredAttribute]
        public Microsoft.Build.Framework.ITaskItem SigningTarget { get { throw null; } set { } }
        public string TimestampUrl { get { throw null; } set { } }
        [System.MonoTODOAttribute]
        public override bool Execute() { throw null; }
    }
    public abstract partial class TaskExtension : Microsoft.Build.Utilities.Task
    {
        internal TaskExtension() { }
        public Microsoft.Build.Utilities.TaskLoggingHelper Log { get { throw null; } }
    }
    public partial class TaskLoggingHelperExtension : Microsoft.Build.Utilities.TaskLoggingHelper
    {
        internal TaskLoggingHelperExtension() : base(null) { }
        [System.MonoTODOAttribute]
        public System.Resources.ResourceManager TaskSharedResources { get { throw null; } set { } }
        [System.MonoTODOAttribute]
        public override string FormatResourceString(string resourceName, params object[] args) { throw null; }
    }
    public abstract partial class ToolTaskExtension : Microsoft.Build.Utilities.ToolTask
    {
        internal ToolTaskExtension() { }
        protected internal System.Collections.Hashtable Bag { get { throw null; } }
        protected override bool HasLoggedErrors { get { throw null; } }
        public Microsoft.Build.Utilities.TaskLoggingHelper Log { get { throw null; } }
        protected internal virtual void AddCommandLineCommands(Microsoft.Build.Tasks.CommandLineBuilderExtension commandLine) { }
        protected internal virtual void AddResponseFileCommands(Microsoft.Build.Tasks.CommandLineBuilderExtension commandLine) { }
        protected override string GenerateCommandLineCommands() { throw null; }
        protected override string GenerateResponseFileCommands() { throw null; }
        protected internal bool GetBoolParameterWithDefault(string parameterName, bool defaultValue) { throw null; }
        protected internal int GetIntParameterWithDefault(string parameterName, int defaultValue) { throw null; }
    }
    public partial class Touch : Microsoft.Build.Tasks.TaskExtension
    {
        public Touch() { }
        public bool AlwaysCreate { get { throw null; } set { } }
        [Microsoft.Build.Framework.RequiredAttribute]
        public Microsoft.Build.Framework.ITaskItem[] Files { get { throw null; } set { } }
        public bool ForceTouch { get { throw null; } set { } }
        public string Time { get { throw null; } set { } }
        [Microsoft.Build.Framework.OutputAttribute]
        public Microsoft.Build.Framework.ITaskItem[] TouchedFiles { get { throw null; } set { } }
        public override bool Execute() { throw null; }
    }
    public partial class UnregisterAssembly : Microsoft.Build.Tasks.AppDomainIsolatedTaskExtension
    {
        public UnregisterAssembly() { }
        public Microsoft.Build.Framework.ITaskItem[] Assemblies { get { throw null; } set { } }
        public Microsoft.Build.Framework.ITaskItem AssemblyListFile { get { throw null; } set { } }
        public Microsoft.Build.Framework.ITaskItem[] TypeLibFiles { get { throw null; } set { } }
        public override bool Execute() { throw null; }
    }
    public partial class UpdateManifest : Microsoft.Build.Utilities.Task
    {
        [System.MonoTODOAttribute]
        public UpdateManifest() { }
        [Microsoft.Build.Framework.RequiredAttribute]
        [System.MonoTODOAttribute]
        public Microsoft.Build.Framework.ITaskItem ApplicationManifest { get { throw null; } set { } }
        [Microsoft.Build.Framework.RequiredAttribute]
        [System.MonoTODOAttribute]
        public string ApplicationPath { get { throw null; } set { } }
        [Microsoft.Build.Framework.RequiredAttribute]
        [System.MonoTODOAttribute]
        public Microsoft.Build.Framework.ITaskItem InputManifest { get { throw null; } set { } }
        [Microsoft.Build.Framework.OutputAttribute]
        [System.MonoTODOAttribute]
        public Microsoft.Build.Framework.ITaskItem OutputManifest { get { throw null; } set { } }
        [System.MonoTODOAttribute]
        public override bool Execute() { throw null; }
    }
    public partial class Vbc : Microsoft.Build.Tasks.ManagedCompiler
    {
        public Vbc() { }
        [System.MonoTODOAttribute]
        public string BaseAddress { get { throw null; } set { } }
        [System.MonoTODOAttribute]
        public string DisabledWarnings { get { throw null; } set { } }
        [System.MonoTODOAttribute]
        public string DocumentationFile { get { throw null; } set { } }
        [System.MonoTODOAttribute]
        public string ErrorReport { get { throw null; } set { } }
        [System.MonoTODOAttribute]
        public bool GenerateDocumentation { get { throw null; } set { } }
        [System.MonoTODOAttribute]
        public Microsoft.Build.Framework.ITaskItem[] Imports { get { throw null; } set { } }
        [System.MonoTODOAttribute]
        public bool NoStandardLib { get { throw null; } set { } }
        [System.MonoTODOAttribute]
        public bool NoWarnings { get { throw null; } set { } }
        [System.MonoTODOAttribute]
        public string OptionCompare { get { throw null; } set { } }
        [System.MonoTODOAttribute]
        public bool OptionExplicit { get { throw null; } set { } }
        [System.MonoTODOAttribute]
        public bool OptionStrict { get { throw null; } set { } }
        [System.MonoTODOAttribute]
        public string OptionStrictType { get { throw null; } set { } }
        [System.MonoTODOAttribute]
        public string Platform { get { throw null; } set { } }
        [System.MonoTODOAttribute]
        public bool RemoveIntegerChecks { get { throw null; } set { } }
        [System.MonoTODOAttribute]
        public string RootNamespace { get { throw null; } set { } }
        [System.MonoTODOAttribute]
        public string SdkPath { get { throw null; } set { } }
        [System.MonoTODOAttribute]
        public bool TargetCompactFramework { get { throw null; } set { } }
        [System.MonoTODOAttribute]
        protected override string ToolName { get { throw null; } }
        [System.MonoTODOAttribute]
        public bool UseHostCompilerIfAvailable { get { throw null; } set { } }
        [System.MonoTODOAttribute]
        public string Verbosity { get { throw null; } set { } }
        [System.MonoTODOAttribute]
        public string WarningsAsErrors { get { throw null; } set { } }
        [System.MonoTODOAttribute]
        public string WarningsNotAsErrors { get { throw null; } set { } }
        [System.MonoTODOAttribute]
        protected internal override void AddResponseFileCommands(Microsoft.Build.Tasks.CommandLineBuilderExtension commandLine) { }
        [System.MonoTODOAttribute]
        protected override bool CallHostObjectToExecute() { throw null; }
        [System.MonoTODOAttribute]
        protected override string GenerateFullPathToTool() { throw null; }
        [System.MonoTODOAttribute]
        protected override Microsoft.Build.Utilities.HostObjectInitializationStatus InitializeHostObject() { throw null; }
        protected override void LogEventsFromTextOutput(string singleLine, Microsoft.Build.Framework.MessageImportance messageImportance) { }
        [System.MonoTODOAttribute]
        protected override bool ValidateParameters() { throw null; }
    }
    [System.MonoTODOAttribute]
    public partial class VCBuild : Microsoft.Build.Tasks.ToolTaskExtension
    {
        [System.MonoTODOAttribute]
        public VCBuild() { }
        [System.MonoTODOAttribute]
        public Microsoft.Build.Framework.ITaskItem[] AdditionalLibPaths { get { throw null; } set { } }
        [System.MonoTODOAttribute]
        public string AdditionalOptions { get { throw null; } set { } }
        [System.MonoTODOAttribute]
        public bool Clean { get { throw null; } set { } }
        [System.MonoTODOAttribute]
        public string Configuration { get { throw null; } set { } }
        [System.MonoTODOAttribute]
        protected override System.Collections.Specialized.StringDictionary EnvironmentOverride { get { throw null; } }
        [System.MonoTODOAttribute]
        public Microsoft.Build.Framework.ITaskItem Override { get { throw null; } set { } }
        [System.MonoTODOAttribute]
        public string Platform { get { throw null; } set { } }
        [Microsoft.Build.Framework.RequiredAttribute]
        [System.MonoTODOAttribute]
        public Microsoft.Build.Framework.ITaskItem[] Projects { get { throw null; } set { } }
        [System.MonoTODOAttribute]
        public bool Rebuild { get { throw null; } set { } }
        [System.MonoTODOAttribute]
        public Microsoft.Build.Framework.ITaskItem SolutionFile { get { throw null; } set { } }
        [System.MonoTODOAttribute]
        protected override string ToolName { get { throw null; } }
        [System.MonoTODOAttribute]
        public bool UserEnvironment { get { throw null; } set { } }
        [System.MonoTODOAttribute]
        protected internal override void AddCommandLineCommands(Microsoft.Build.Tasks.CommandLineBuilderExtension commandLine) { }
        [System.MonoTODOAttribute]
        public override bool Execute() { throw null; }
        [System.MonoTODOAttribute]
        protected override string GenerateFullPathToTool() { throw null; }
        [System.MonoTODOAttribute]
        protected override bool ValidateParameters() { throw null; }
    }
    public sealed partial class Warning : Microsoft.Build.Tasks.TaskExtension
    {
        public Warning() { }
        public string Code { get { throw null; } set { } }
        public string File { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public string HelpKeyword { get { throw null; } set { } }
        public string Text { get { throw null; } set { } }
        public override bool Execute() { throw null; }
    }
    public partial class WriteLinesToFile : Microsoft.Build.Tasks.TaskExtension
    {
        public WriteLinesToFile() { }
        [Microsoft.Build.Framework.RequiredAttribute]
        public Microsoft.Build.Framework.ITaskItem File { get { throw null; } set { } }
        public Microsoft.Build.Framework.ITaskItem[] Lines { get { throw null; } set { } }
        public bool Overwrite { get { throw null; } set { } }
        public override bool Execute() { throw null; }
    }
}
namespace Microsoft.Build.Tasks.Deployment.Bootstrapper
{
    [System.Runtime.InteropServices.ClassInterfaceAttribute((System.Runtime.InteropServices.ClassInterfaceType)(0))]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    [System.Runtime.InteropServices.GuidAttribute("1D9FE38A-0226-4b95-9C6B-6DFFA2236270")]
    public partial class BootstrapperBuilder : Microsoft.Build.Tasks.Deployment.Bootstrapper.IBootstrapperBuilder
    {
        public BootstrapperBuilder() { }
        public string Path { get { throw null; } set { } }
        public Microsoft.Build.Tasks.Deployment.Bootstrapper.ProductCollection Products { get { throw null; } }
        [System.MonoTODOAttribute]
        public Microsoft.Build.Tasks.Deployment.Bootstrapper.BuildResults Build(Microsoft.Build.Tasks.Deployment.Bootstrapper.BuildSettings settings) { throw null; }
        [System.MonoTODOAttribute]
        public string[] GetOutputFolders(string[] productCodes, string culture, string fallbackCulture, Microsoft.Build.Tasks.Deployment.Bootstrapper.ComponentsLocation componentsLocation) { throw null; }
    }
    public partial class BuildMessage : Microsoft.Build.Tasks.Deployment.Bootstrapper.IBuildMessage
    {
        internal BuildMessage() { }
        public int HelpId { get { throw null; } }
        public string HelpKeyword { get { throw null; } }
        public string Message { get { throw null; } }
        public Microsoft.Build.Tasks.Deployment.Bootstrapper.BuildMessageSeverity Severity { get { throw null; } }
    }
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    [System.Runtime.InteropServices.GuidAttribute("936D32F9-1A68-4d5e-98EA-044AC9A1AADA")]
    public enum BuildMessageSeverity
    {
        Error = 2,
        Info = 0,
        Warning = 1,
    }
    [System.Runtime.InteropServices.ClassInterfaceAttribute((System.Runtime.InteropServices.ClassInterfaceType)(0))]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    [System.Runtime.InteropServices.GuidAttribute("FAD7BA7C-CA00-41e0-A5EF-2DA9A74E58E6")]
    public partial class BuildResults : Microsoft.Build.Tasks.Deployment.Bootstrapper.IBuildResults
    {
        internal BuildResults() { }
        public string[] ComponentFiles { get { throw null; } }
        public string KeyFile { get { throw null; } }
        public Microsoft.Build.Tasks.Deployment.Bootstrapper.BuildMessage[] Messages { get { throw null; } }
        public bool Succeeded { get { throw null; } }
    }
    [System.Runtime.InteropServices.ClassInterfaceAttribute((System.Runtime.InteropServices.ClassInterfaceType)(0))]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    [System.Runtime.InteropServices.GuidAttribute("5D13802C-C830-4b41-8E7A-F69D9DD6A095")]
    public partial class BuildSettings : Microsoft.Build.Tasks.Deployment.Bootstrapper.IBuildSettings
    {
        public BuildSettings() { }
        public string ApplicationFile { get { throw null; } set { } }
        public string ApplicationName { get { throw null; } set { } }
        public string ApplicationUrl { get { throw null; } set { } }
        public Microsoft.Build.Tasks.Deployment.Bootstrapper.ComponentsLocation ComponentsLocation { get { throw null; } set { } }
        public string ComponentsUrl { get { throw null; } set { } }
        public bool CopyComponents { get { throw null; } set { } }
        public int FallbackLCID { get { throw null; } set { } }
        public int LCID { get { throw null; } set { } }
        public string OutputPath { get { throw null; } set { } }
        public Microsoft.Build.Tasks.Deployment.Bootstrapper.ProductBuilderCollection ProductBuilders { get { throw null; } }
        public string SupportUrl { get { throw null; } set { } }
        public bool Validate { get { throw null; } set { } }
    }
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    [System.Runtime.InteropServices.GuidAttribute("12F49949-7B60-49CD-B6A0-2B5E4A638AAF")]
    public enum ComponentsLocation
    {
        Absolute = 2,
        HomeSite = 0,
        Relative = 1,
    }
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    [System.Runtime.InteropServices.GuidAttribute("1D202366-5EEA-4379-9255-6F8CDB8587C9")]
    [System.Runtime.InteropServices.InterfaceTypeAttribute((System.Runtime.InteropServices.ComInterfaceType)(0))]
    public partial interface IBootstrapperBuilder
    {
        string Path { get; set; }
        Microsoft.Build.Tasks.Deployment.Bootstrapper.ProductCollection Products { get; }
        Microsoft.Build.Tasks.Deployment.Bootstrapper.BuildResults Build(Microsoft.Build.Tasks.Deployment.Bootstrapper.BuildSettings settings);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    [System.Runtime.InteropServices.GuidAttribute("E3C981EA-99E6-4f48-8955-1AAFDFB5ACE4")]
    [System.Runtime.InteropServices.InterfaceTypeAttribute((System.Runtime.InteropServices.ComInterfaceType)(0))]
    public partial interface IBuildMessage
    {
        int HelpId { get; }
        string HelpKeyword { get; }
        string Message { get; }
        Microsoft.Build.Tasks.Deployment.Bootstrapper.BuildMessageSeverity Severity { get; }
    }
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    [System.Runtime.InteropServices.GuidAttribute("586B842C-D9C7-43b8-84E4-9CFC3AF9F13B")]
    [System.Runtime.InteropServices.InterfaceTypeAttribute((System.Runtime.InteropServices.ComInterfaceType)(0))]
    public partial interface IBuildResults
    {
        string[] ComponentFiles { get; }
        string KeyFile { get; }
        Microsoft.Build.Tasks.Deployment.Bootstrapper.BuildMessage[] Messages { get; }
        bool Succeeded { get; }
    }
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    [System.Runtime.InteropServices.GuidAttribute("87EEBC69-0948-4ce6-A2DE-819162B87CC6")]
    [System.Runtime.InteropServices.InterfaceTypeAttribute((System.Runtime.InteropServices.ComInterfaceType)(0))]
    public partial interface IBuildSettings
    {
        string ApplicationFile { get; set; }
        string ApplicationName { get; set; }
        string ApplicationUrl { get; set; }
        Microsoft.Build.Tasks.Deployment.Bootstrapper.ComponentsLocation ComponentsLocation { get; set; }
        string ComponentsUrl { get; set; }
        bool CopyComponents { get; set; }
        int FallbackLCID { get; set; }
        int LCID { get; set; }
        string OutputPath { get; set; }
        Microsoft.Build.Tasks.Deployment.Bootstrapper.ProductBuilderCollection ProductBuilders { get; }
        string SupportUrl { get; set; }
        bool Validate { get; set; }
    }
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    [System.Runtime.InteropServices.GuidAttribute("9E81BE3D-530F-4a10-8349-5D5947BA59AD")]
    [System.Runtime.InteropServices.InterfaceTypeAttribute((System.Runtime.InteropServices.ComInterfaceType)(0))]
    public partial interface IProduct
    {
        Microsoft.Build.Tasks.Deployment.Bootstrapper.ProductCollection Includes { get; }
        string Name { get; }
        Microsoft.Build.Tasks.Deployment.Bootstrapper.ProductBuilder ProductBuilder { get; }
        string ProductCode { get; }
    }
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    [System.Runtime.InteropServices.GuidAttribute("0777432F-A60D-48b3-83DB-90326FE8C96E")]
    [System.Runtime.InteropServices.InterfaceTypeAttribute((System.Runtime.InteropServices.ComInterfaceType)(0))]
    public partial interface IProductBuilder
    {
        Microsoft.Build.Tasks.Deployment.Bootstrapper.Product Product { get; }
    }
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    [System.Runtime.InteropServices.GuidAttribute("0D593FC0-E3F1-4dad-A674-7EA4D327F79B")]
    [System.Runtime.InteropServices.InterfaceTypeAttribute((System.Runtime.InteropServices.ComInterfaceType)(0))]
    public partial interface IProductBuilderCollection
    {
        void Add(Microsoft.Build.Tasks.Deployment.Bootstrapper.ProductBuilder builder);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    [System.Runtime.InteropServices.GuidAttribute("63F63663-8503-4875-814C-09168E595367")]
    [System.Runtime.InteropServices.InterfaceTypeAttribute((System.Runtime.InteropServices.ComInterfaceType)(0))]
    public partial interface IProductCollection
    {
        int Count { get; }
        Microsoft.Build.Tasks.Deployment.Bootstrapper.Product Item(int index);
        Microsoft.Build.Tasks.Deployment.Bootstrapper.Product Product(string productCode);
    }
    [System.Runtime.InteropServices.ClassInterfaceAttribute((System.Runtime.InteropServices.ClassInterfaceType)(0))]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    [System.Runtime.InteropServices.GuidAttribute("532BF563-A85D-4088-8048-41F51AC5239F")]
    public partial class Product : Microsoft.Build.Tasks.Deployment.Bootstrapper.IProduct
    {
        public Product() { }
        public Microsoft.Build.Tasks.Deployment.Bootstrapper.ProductCollection Includes { get { throw null; } }
        public string Name { get { throw null; } }
        public Microsoft.Build.Tasks.Deployment.Bootstrapper.ProductBuilder ProductBuilder { get { throw null; } }
        public string ProductCode { get { throw null; } }
    }
    public partial class ProductBuilder : Microsoft.Build.Tasks.Deployment.Bootstrapper.IProductBuilder
    {
        internal ProductBuilder() { }
        public Microsoft.Build.Tasks.Deployment.Bootstrapper.Product Product { get { throw null; } }
    }
    [System.Runtime.InteropServices.ClassInterfaceAttribute((System.Runtime.InteropServices.ClassInterfaceType)(0))]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    [System.Runtime.InteropServices.GuidAttribute("D25C0741-99CA-49f7-9460-95E5F25EEF43")]
    public partial class ProductBuilderCollection : Microsoft.Build.Tasks.Deployment.Bootstrapper.IProductBuilderCollection, System.Collections.IEnumerable
    {
        internal ProductBuilderCollection() { }
        [System.MonoTODOAttribute]
        public void Add(Microsoft.Build.Tasks.Deployment.Bootstrapper.ProductBuilder builder) { }
        [System.MonoTODOAttribute]
        public System.Collections.IEnumerator GetEnumerator() { throw null; }
    }
    [System.Runtime.InteropServices.ClassInterfaceAttribute((System.Runtime.InteropServices.ClassInterfaceType)(0))]
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    [System.Runtime.InteropServices.GuidAttribute("EFFA164B-3E87-4195-88DB-8AC004DDFE2A")]
    public partial class ProductCollection : Microsoft.Build.Tasks.Deployment.Bootstrapper.IProductCollection, System.Collections.IEnumerable
    {
        internal ProductCollection() { }
        [System.MonoTODOAttribute]
        public int Count { get { throw null; } }
        [System.MonoTODOAttribute]
        public System.Collections.IEnumerator GetEnumerator() { throw null; }
        [System.MonoTODOAttribute]
        public Microsoft.Build.Tasks.Deployment.Bootstrapper.Product Item(int index) { throw null; }
        [System.MonoTODOAttribute]
        public Microsoft.Build.Tasks.Deployment.Bootstrapper.Product Product(string productCode) { throw null; }
    }
}
namespace Microsoft.Build.Tasks.Deployment.ManifestUtilities
{
    [System.Runtime.InteropServices.ComVisibleAttribute(false)]
    public sealed partial class ApplicationIdentity
    {
        public ApplicationIdentity(string url, Microsoft.Build.Tasks.Deployment.ManifestUtilities.AssemblyIdentity deployManifestIdentity, Microsoft.Build.Tasks.Deployment.ManifestUtilities.AssemblyIdentity applicationManifestIdentity) { }
        public ApplicationIdentity(string url, string deployManifestPath, string applicationManifestPath) { }
        public override string ToString() { throw null; }
    }
    [System.Runtime.InteropServices.ComVisibleAttribute(false)]
    public sealed partial class ApplicationManifest : Microsoft.Build.Tasks.Deployment.ManifestUtilities.AssemblyManifest
    {
        [System.MonoTODOAttribute]
        public ApplicationManifest() { }
        [System.MonoTODOAttribute]
        public string ConfigFile { get { throw null; } set { } }
        [System.MonoTODOAttribute]
        public override Microsoft.Build.Tasks.Deployment.ManifestUtilities.AssemblyReference EntryPoint { get { throw null; } set { } }
        [System.MonoTODOAttribute]
        public string IconFile { get { throw null; } set { } }
        [System.MonoTODOAttribute]
        public bool IsClickOnceManifest { get { throw null; } set { } }
        [System.MonoTODOAttribute]
        public int MaxTargetPath { get { throw null; } set { } }
        [System.MonoTODOAttribute]
        public string OSDescription { get { throw null; } set { } }
        [System.MonoTODOAttribute]
        public string OSSupportUrl { get { throw null; } set { } }
        [System.MonoTODOAttribute]
        public string OSVersion { get { throw null; } set { } }
        [System.MonoTODOAttribute]
        public Microsoft.Build.Tasks.Deployment.ManifestUtilities.TrustInfo TrustInfo { get { throw null; } set { } }
        [System.MonoTODOAttribute]
        public string XmlConfigFile { get { throw null; } set { } }
        [System.MonoTODOAttribute]
        public Microsoft.Build.Tasks.Deployment.ManifestUtilities.AssemblyIdentity XmlEntryPointIdentity { get { throw null; } set { } }
        [System.MonoTODOAttribute]
        public string XmlEntryPointParameters { get { throw null; } set { } }
        [System.MonoTODOAttribute]
        public string XmlEntryPointPath { get { throw null; } set { } }
        [System.MonoTODOAttribute]
        public string XmlIconFile { get { throw null; } set { } }
        [System.MonoTODOAttribute]
        public string XmlIsClickOnceManifest { get { throw null; } set { } }
        [System.MonoTODOAttribute]
        public string XmlOSBuild { get { throw null; } set { } }
        [System.MonoTODOAttribute]
        public string XmlOSDescription { get { throw null; } set { } }
        [System.MonoTODOAttribute]
        public string XmlOSMajor { get { throw null; } set { } }
        [System.MonoTODOAttribute]
        public string XmlOSMinor { get { throw null; } set { } }
        [System.MonoTODOAttribute]
        public string XmlOSRevision { get { throw null; } set { } }
        [System.MonoTODOAttribute]
        public string XmlOSSupportUrl { get { throw null; } set { } }
    }
    [System.Runtime.InteropServices.ComVisibleAttribute(false)]
    public sealed partial class AssemblyIdentity
    {
        [System.MonoTODOAttribute]
        public AssemblyIdentity() { }
        [System.MonoTODOAttribute]
        public AssemblyIdentity(Microsoft.Build.Tasks.Deployment.ManifestUtilities.AssemblyIdentity identity) { }
        [System.MonoTODOAttribute]
        public AssemblyIdentity(string name) { }
        [System.MonoTODOAttribute]
        public AssemblyIdentity(string name, string version) { }
        [System.MonoTODOAttribute]
        public AssemblyIdentity(string name, string version, string publicKeyToken, string culture) { }
        [System.MonoTODOAttribute]
        public AssemblyIdentity(string name, string version, string publicKeyToken, string culture, string processorArchitecture) { }
        [System.MonoTODOAttribute]
        public AssemblyIdentity(string name, string version, string publicKeyToken, string culture, string processorArchitecture, string type) { }
        [System.MonoTODOAttribute]
        public string Culture { get { throw null; } set { } }
        [System.MonoTODOAttribute]
        public bool IsFrameworkAssembly { get { throw null; } }
        [System.MonoTODOAttribute]
        public bool IsNeutralPlatform { get { throw null; } }
        [System.MonoTODOAttribute]
        public bool IsStrongName { get { throw null; } }
        [System.MonoTODOAttribute]
        public string Name { get { throw null; } set { } }
        [System.MonoTODOAttribute]
        public string ProcessorArchitecture { get { throw null; } set { } }
        [System.MonoTODOAttribute]
        public string PublicKeyToken { get { throw null; } set { } }
        [System.MonoTODOAttribute]
        public string Type { get { throw null; } set { } }
        [System.MonoTODOAttribute]
        public string Version { get { throw null; } set { } }
        [System.MonoTODOAttribute]
        public string XmlCulture { get { throw null; } set { } }
        [System.MonoTODOAttribute]
        public string XmlName { get { throw null; } set { } }
        [System.MonoTODOAttribute]
        public string XmlProcessorArchitecture { get { throw null; } set { } }
        [System.MonoTODOAttribute]
        public string XmlPublicKeyToken { get { throw null; } set { } }
        [System.MonoTODOAttribute]
        public string XmlType { get { throw null; } set { } }
        [System.MonoTODOAttribute]
        public string XmlVersion { get { throw null; } set { } }
        [System.MonoTODOAttribute]
        public static Microsoft.Build.Tasks.Deployment.ManifestUtilities.AssemblyIdentity FromAssemblyName(string assemblyName) { throw null; }
        [System.MonoTODOAttribute]
        public static Microsoft.Build.Tasks.Deployment.ManifestUtilities.AssemblyIdentity FromFile(string path) { throw null; }
        [System.MonoTODOAttribute]
        public static Microsoft.Build.Tasks.Deployment.ManifestUtilities.AssemblyIdentity FromManagedAssembly(string path) { throw null; }
        [System.MonoTODOAttribute]
        public static Microsoft.Build.Tasks.Deployment.ManifestUtilities.AssemblyIdentity FromManifest(string path) { throw null; }
        [System.MonoTODOAttribute]
        public static Microsoft.Build.Tasks.Deployment.ManifestUtilities.AssemblyIdentity FromNativeAssembly(string path) { throw null; }
        [System.MonoTODOAttribute]
        public string GetFullName(Microsoft.Build.Tasks.Deployment.ManifestUtilities.AssemblyIdentity.FullNameFlags flags) { throw null; }
        [System.MonoTODOAttribute]
        public override string ToString() { throw null; }
        [System.FlagsAttribute]
        public enum FullNameFlags
        {
            All = 3,
            Default = 0,
            ProcessorArchitecture = 1,
            Type = 2,
        }
    }
    [System.Runtime.InteropServices.ComVisibleAttribute(false)]
    public partial class AssemblyManifest : Microsoft.Build.Tasks.Deployment.ManifestUtilities.Manifest
    {
        [System.MonoTODOAttribute]
        public AssemblyManifest() { }
        public Microsoft.Build.Tasks.Deployment.ManifestUtilities.ProxyStub[] ExternalProxyStubs { get { throw null; } }
        public Microsoft.Build.Tasks.Deployment.ManifestUtilities.ProxyStub[] XmlExternalProxyStubs { get { throw null; } set { } }
    }
    [System.Runtime.InteropServices.ComVisibleAttribute(false)]
    public sealed partial class AssemblyReference : Microsoft.Build.Tasks.Deployment.ManifestUtilities.BaseReference
    {
        [System.MonoTODOAttribute]
        public AssemblyReference() { }
        [System.MonoTODOAttribute]
        public AssemblyReference(string path) { }
        public Microsoft.Build.Tasks.Deployment.ManifestUtilities.AssemblyIdentity AssemblyIdentity { get { throw null; } set { } }
        public bool IsPrerequisite { get { throw null; } set { } }
        public Microsoft.Build.Tasks.Deployment.ManifestUtilities.AssemblyReferenceType ReferenceType { get { throw null; } set { } }
        protected internal override string SortName { get { throw null; } }
        public Microsoft.Build.Tasks.Deployment.ManifestUtilities.AssemblyIdentity XmlAssemblyIdentity { get { throw null; } set { } }
        public string XmlIsNative { get { throw null; } set { } }
        public string XmlIsPrerequisite { get { throw null; } set { } }
        public override string ToString() { throw null; }
    }
    [System.Runtime.InteropServices.ComVisibleAttribute(false)]
    public sealed partial class AssemblyReferenceCollection : System.Collections.IEnumerable
    {
        internal AssemblyReferenceCollection() { }
        public int Count { get { throw null; } }
        public Microsoft.Build.Tasks.Deployment.ManifestUtilities.AssemblyReference this[int index] { get { throw null; } }
        public Microsoft.Build.Tasks.Deployment.ManifestUtilities.AssemblyReference Add(Microsoft.Build.Tasks.Deployment.ManifestUtilities.AssemblyReference assembly) { throw null; }
        public Microsoft.Build.Tasks.Deployment.ManifestUtilities.AssemblyReference Add(string path) { throw null; }
        public void Clear() { }
        public Microsoft.Build.Tasks.Deployment.ManifestUtilities.AssemblyReference Find(Microsoft.Build.Tasks.Deployment.ManifestUtilities.AssemblyIdentity identity) { throw null; }
        public Microsoft.Build.Tasks.Deployment.ManifestUtilities.AssemblyReference Find(string name) { throw null; }
        public Microsoft.Build.Tasks.Deployment.ManifestUtilities.AssemblyReference FindTargetPath(string targetPath) { throw null; }
        public System.Collections.IEnumerator GetEnumerator() { throw null; }
        public void Remove(Microsoft.Build.Tasks.Deployment.ManifestUtilities.AssemblyReference assemblyReference) { }
    }
    public enum AssemblyReferenceType
    {
        ClickOnceManifest = 1,
        ManagedAssembly = 2,
        NativeAssembly = 3,
        Unspecified = 0,
    }
    [System.Runtime.InteropServices.ComVisibleAttribute(false)]
    public abstract partial class BaseReference
    {
        [System.MonoTODOAttribute]
        protected internal BaseReference() { }
        [System.MonoTODOAttribute]
        protected internal BaseReference(string path) { }
        [System.MonoTODOAttribute]
        public string Group { get { throw null; } set { } }
        [System.MonoTODOAttribute]
        public string Hash { get { throw null; } set { } }
        [System.MonoTODOAttribute]
        public bool IsOptional { get { throw null; } set { } }
        [System.MonoTODOAttribute]
        public string ResolvedPath { get { throw null; } set { } }
        [System.MonoTODOAttribute]
        public long Size { get { throw null; } set { } }
        [System.MonoTODOAttribute]
        protected internal abstract string SortName { get; }
        [System.MonoTODOAttribute]
        public string SourcePath { get { throw null; } set { } }
        [System.MonoTODOAttribute]
        public string TargetPath { get { throw null; } set { } }
        [System.MonoTODOAttribute]
        public string XmlGroup { get { throw null; } set { } }
        [System.MonoTODOAttribute]
        public string XmlHash { get { throw null; } set { } }
        [System.MonoTODOAttribute]
        public string XmlHashAlgorithm { get { throw null; } set { } }
        [System.MonoTODOAttribute]
        public string XmlIsOptional { get { throw null; } set { } }
        [System.MonoTODOAttribute]
        public string XmlPath { get { throw null; } set { } }
        [System.MonoTODOAttribute]
        public string XmlSize { get { throw null; } set { } }
        [System.MonoTODOAttribute]
        public override string ToString() { throw null; }
    }
    [System.Runtime.InteropServices.ComVisibleAttribute(false)]
    public partial class ComClass
    {
        [System.MonoTODOAttribute]
        public ComClass() { }
        [System.MonoTODOAttribute]
        public string ClsId { get { throw null; } }
        [System.MonoTODOAttribute]
        public string Description { get { throw null; } }
        [System.MonoTODOAttribute]
        public string ProgId { get { throw null; } }
        [System.MonoTODOAttribute]
        public string ThreadingModel { get { throw null; } }
        [System.MonoTODOAttribute]
        public string TlbId { get { throw null; } }
        [System.MonoTODOAttribute]
        public string XmlClsId { get { throw null; } set { } }
        [System.MonoTODOAttribute]
        public string XmlDescription { get { throw null; } set { } }
        [System.MonoTODOAttribute]
        public string XmlProgId { get { throw null; } set { } }
        [System.MonoTODOAttribute]
        public string XmlThreadingModel { get { throw null; } set { } }
        [System.MonoTODOAttribute]
        public string XmlTlbId { get { throw null; } set { } }
    }
    [System.Runtime.InteropServices.ComVisibleAttribute(false)]
    public sealed partial class DeployManifest : Microsoft.Build.Tasks.Deployment.ManifestUtilities.Manifest
    {
        [System.MonoTODOAttribute]
        public DeployManifest() { }
        [System.MonoTODOAttribute]
        public string DeploymentUrl { get { throw null; } set { } }
        [System.MonoTODOAttribute]
        public bool DisallowUrlActivation { get { throw null; } set { } }
        [System.MonoTODOAttribute]
        public override Microsoft.Build.Tasks.Deployment.ManifestUtilities.AssemblyReference EntryPoint { get { throw null; } set { } }
        [System.MonoTODOAttribute]
        public bool Install { get { throw null; } set { } }
        [System.MonoTODOAttribute]
        public bool MapFileExtensions { get { throw null; } set { } }
        [System.MonoTODOAttribute]
        public string MinimumRequiredVersion { get { throw null; } set { } }
        [System.MonoTODOAttribute]
        public string Product { get { throw null; } set { } }
        [System.MonoTODOAttribute]
        public string Publisher { get { throw null; } set { } }
        [System.MonoTODOAttribute]
        public string SupportUrl { get { throw null; } set { } }
        [System.MonoTODOAttribute]
        public bool TrustUrlParameters { get { throw null; } set { } }
        [System.MonoTODOAttribute]
        public bool UpdateEnabled { get { throw null; } set { } }
        [System.MonoTODOAttribute]
        public int UpdateInterval { get { throw null; } set { } }
        [System.MonoTODOAttribute]
        public Microsoft.Build.Tasks.Deployment.ManifestUtilities.UpdateMode UpdateMode { get { throw null; } set { } }
        [System.MonoTODOAttribute]
        public Microsoft.Build.Tasks.Deployment.ManifestUtilities.UpdateUnit UpdateUnit { get { throw null; } set { } }
        [System.MonoTODOAttribute]
        public string XmlDeploymentUrl { get { throw null; } set { } }
        [System.MonoTODOAttribute]
        public string XmlDisallowUrlActivation { get { throw null; } set { } }
        [System.MonoTODOAttribute]
        public string XmlInstall { get { throw null; } set { } }
        [System.MonoTODOAttribute]
        public string XmlMapFileExtensions { get { throw null; } set { } }
        [System.MonoTODOAttribute]
        public string XmlMinimumRequiredVersion { get { throw null; } set { } }
        [System.MonoTODOAttribute]
        public string XmlProduct { get { throw null; } set { } }
        [System.MonoTODOAttribute]
        public string XmlPublisher { get { throw null; } set { } }
        [System.MonoTODOAttribute]
        public string XmlSupportUrl { get { throw null; } set { } }
        [System.MonoTODOAttribute]
        public string XmlTrustUrlParameters { get { throw null; } set { } }
        [System.MonoTODOAttribute]
        public string XmlUpdateEnabled { get { throw null; } set { } }
        [System.MonoTODOAttribute]
        public string XmlUpdateInterval { get { throw null; } set { } }
        [System.MonoTODOAttribute]
        public string XmlUpdateMode { get { throw null; } set { } }
        [System.MonoTODOAttribute]
        public string XmlUpdateUnit { get { throw null; } set { } }
        [System.MonoTODOAttribute]
        public override void Validate() { }
    }
    [System.Runtime.InteropServices.ComVisibleAttribute(false)]
    public sealed partial class FileReference : Microsoft.Build.Tasks.Deployment.ManifestUtilities.BaseReference
    {
        [System.MonoTODOAttribute]
        public FileReference() { }
        [System.MonoTODOAttribute]
        public FileReference(string path) { }
        public Microsoft.Build.Tasks.Deployment.ManifestUtilities.ComClass[] ComClasses { get { throw null; } }
        public bool IsDataFile { get { throw null; } set { } }
        public Microsoft.Build.Tasks.Deployment.ManifestUtilities.ProxyStub[] ProxyStubs { get { throw null; } }
        protected internal override string SortName { get { throw null; } }
        public Microsoft.Build.Tasks.Deployment.ManifestUtilities.TypeLib[] TypeLibs { get { throw null; } }
        public Microsoft.Build.Tasks.Deployment.ManifestUtilities.ComClass[] XmlComClasses { get { throw null; } set { } }
        public Microsoft.Build.Tasks.Deployment.ManifestUtilities.ProxyStub[] XmlProxyStubs { get { throw null; } set { } }
        public Microsoft.Build.Tasks.Deployment.ManifestUtilities.TypeLib[] XmlTypeLibs { get { throw null; } set { } }
        public string XmlWriteableType { get { throw null; } set { } }
    }
    [System.Runtime.InteropServices.ComVisibleAttribute(false)]
    public sealed partial class FileReferenceCollection : System.Collections.IEnumerable
    {
        internal FileReferenceCollection() { }
        [System.MonoTODOAttribute]
        public int Count { get { throw null; } }
        [System.MonoTODOAttribute]
        public Microsoft.Build.Tasks.Deployment.ManifestUtilities.FileReference this[int index] { get { throw null; } }
        [System.MonoTODOAttribute]
        public Microsoft.Build.Tasks.Deployment.ManifestUtilities.FileReference Add(Microsoft.Build.Tasks.Deployment.ManifestUtilities.FileReference file) { throw null; }
        [System.MonoTODOAttribute]
        public Microsoft.Build.Tasks.Deployment.ManifestUtilities.FileReference Add(string path) { throw null; }
        [System.MonoTODOAttribute]
        public void Clear() { }
        [System.MonoTODOAttribute]
        public Microsoft.Build.Tasks.Deployment.ManifestUtilities.FileReference FindTargetPath(string targetPath) { throw null; }
        [System.MonoTODOAttribute]
        public System.Collections.IEnumerator GetEnumerator() { throw null; }
        [System.MonoTODOAttribute]
        public void Remove(Microsoft.Build.Tasks.Deployment.ManifestUtilities.FileReference file) { }
    }
    [System.Runtime.InteropServices.ComVisibleAttribute(false)]
    public abstract partial class Manifest
    {
        [System.MonoTODOAttribute]
        protected internal Manifest() { }
        [System.MonoTODOAttribute]
        public Microsoft.Build.Tasks.Deployment.ManifestUtilities.AssemblyIdentity AssemblyIdentity { get { throw null; } set { } }
        [System.MonoTODOAttribute]
        public Microsoft.Build.Tasks.Deployment.ManifestUtilities.AssemblyReferenceCollection AssemblyReferences { get { throw null; } }
        [System.MonoTODOAttribute]
        public string Description { get { throw null; } set { } }
        [System.MonoTODOAttribute]
        public virtual Microsoft.Build.Tasks.Deployment.ManifestUtilities.AssemblyReference EntryPoint { get { throw null; } set { } }
        [System.MonoTODOAttribute]
        public Microsoft.Build.Tasks.Deployment.ManifestUtilities.FileReferenceCollection FileReferences { get { throw null; } }
        [System.MonoTODOAttribute]
        public System.IO.Stream InputStream { get { throw null; } set { } }
        [System.MonoTODOAttribute]
        public Microsoft.Build.Tasks.Deployment.ManifestUtilities.OutputMessageCollection OutputMessages { get { throw null; } }
        [System.MonoTODOAttribute]
        public bool ReadOnly { get { throw null; } set { } }
        [System.MonoTODOAttribute]
        public string SourcePath { get { throw null; } set { } }
        [System.MonoTODOAttribute]
        public Microsoft.Build.Tasks.Deployment.ManifestUtilities.AssemblyIdentity XmlAssemblyIdentity { get { throw null; } set { } }
        [System.MonoTODOAttribute]
        public Microsoft.Build.Tasks.Deployment.ManifestUtilities.AssemblyReference[] XmlAssemblyReferences { get { throw null; } set { } }
        [System.MonoTODOAttribute]
        public string XmlDescription { get { throw null; } set { } }
        [System.MonoTODOAttribute]
        public Microsoft.Build.Tasks.Deployment.ManifestUtilities.FileReference[] XmlFileReferences { get { throw null; } set { } }
        [System.MonoTODOAttribute]
        public string XmlSchema { get { throw null; } set { } }
        [System.MonoTODOAttribute]
        public void ResolveFiles() { }
        [System.MonoTODOAttribute]
        public void ResolveFiles(string[] searchPaths) { }
        [System.MonoTODOAttribute]
        public override string ToString() { throw null; }
        [System.MonoTODOAttribute]
        public void UpdateFileInfo() { }
        [System.MonoTODOAttribute]
        public virtual void Validate() { }
        [System.MonoTODOAttribute]
        protected void ValidatePlatform() { }
    }
    [System.Runtime.InteropServices.ComVisibleAttribute(false)]
    public static partial class ManifestReader
    {
        [System.MonoTODOAttribute]
        public static Microsoft.Build.Tasks.Deployment.ManifestUtilities.Manifest ReadManifest(System.IO.Stream input, bool preserveStream) { throw null; }
        [System.MonoTODOAttribute]
        public static Microsoft.Build.Tasks.Deployment.ManifestUtilities.Manifest ReadManifest(string path, bool preserveStream) { throw null; }
        [System.MonoTODOAttribute]
        public static Microsoft.Build.Tasks.Deployment.ManifestUtilities.Manifest ReadManifest(string manifestType, System.IO.Stream input, bool preserveStream) { throw null; }
        [System.MonoTODOAttribute]
        public static Microsoft.Build.Tasks.Deployment.ManifestUtilities.Manifest ReadManifest(string manifestType, string path, bool preserveStream) { throw null; }
    }
    [System.Runtime.InteropServices.ComVisibleAttribute(false)]
    public static partial class ManifestWriter
    {
        [System.MonoTODOAttribute]
        public static void WriteManifest(Microsoft.Build.Tasks.Deployment.ManifestUtilities.Manifest manifest) { }
        [System.MonoTODOAttribute]
        public static void WriteManifest(Microsoft.Build.Tasks.Deployment.ManifestUtilities.Manifest manifest, System.IO.Stream output) { }
        [System.MonoTODOAttribute]
        public static void WriteManifest(Microsoft.Build.Tasks.Deployment.ManifestUtilities.Manifest manifest, string path) { }
    }
    [System.Runtime.InteropServices.ComVisibleAttribute(false)]
    public sealed partial class OutputMessage
    {
        internal OutputMessage() { }
        public string Name { get { throw null; } }
        public string Text { get { throw null; } }
        public Microsoft.Build.Tasks.Deployment.ManifestUtilities.OutputMessageType Type { get { throw null; } }
        [System.MonoTODOAttribute]
        public string[] GetArguments() { throw null; }
    }
    [System.Runtime.InteropServices.ComVisibleAttribute(false)]
    public sealed partial class OutputMessageCollection : System.Collections.IEnumerable
    {
        internal OutputMessageCollection() { }
        [System.MonoTODOAttribute]
        public int ErrorCount { get { throw null; } }
        [System.MonoTODOAttribute]
        public Microsoft.Build.Tasks.Deployment.ManifestUtilities.OutputMessage this[int index] { get { throw null; } }
        [System.MonoTODOAttribute]
        public int WarningCount { get { throw null; } }
        [System.MonoTODOAttribute]
        public void Clear() { }
        [System.MonoTODOAttribute]
        public System.Collections.IEnumerator GetEnumerator() { throw null; }
    }
    [System.Runtime.InteropServices.ComVisibleAttribute(false)]
    public enum OutputMessageType
    {
        Error = 2,
        Info = 0,
        Warning = 1,
    }
    [System.Runtime.InteropServices.ComVisibleAttribute(false)]
    public partial class ProxyStub
    {
        [System.MonoTODOAttribute]
        public ProxyStub() { }
        public string BaseInterface { get { throw null; } }
        public string IID { get { throw null; } }
        public string Name { get { throw null; } }
        public string NumMethods { get { throw null; } }
        public string TlbId { get { throw null; } }
        public string XmlBaseInterface { get { throw null; } set { } }
        public string XmlIID { get { throw null; } set { } }
        public string XmlName { get { throw null; } set { } }
        public string XmlNumMethods { get { throw null; } set { } }
        public string XmlTlbId { get { throw null; } set { } }
    }
    [System.Runtime.InteropServices.ComVisibleAttribute(false)]
    public static partial class SecurityUtilities
    {
        [System.MonoTODOAttribute]
        public static System.Security.PermissionSet ComputeZonePermissionSet(string targetZone, System.Security.PermissionSet includedPermissionSet, string[] excludedPermissions) { throw null; }
        [System.MonoTODOAttribute]
        public static System.Security.PermissionSet IdentityListToPermissionSet(string[] ids) { throw null; }
        [System.MonoTODOAttribute]
        public static string[] PermissionSetToIdentityList(System.Security.PermissionSet permissionSet) { throw null; }
        [System.MonoTODOAttribute]
        public static void SignFile(System.Security.Cryptography.X509Certificates.X509Certificate2 cert, System.Uri timestampUrl, string path) { }
        [System.MonoTODOAttribute]
        public static void SignFile(string certPath, System.Security.SecureString certPassword, System.Uri timestampUrl, string path) { }
        [System.MonoTODOAttribute]
        public static void SignFile(string certThumbprint, System.Uri timestampUrl, string path) { }
        [System.MonoTODOAttribute]
        public static System.Security.PermissionSet XmlToPermissionSet(System.Xml.XmlElement element) { throw null; }
    }
    [System.Runtime.InteropServices.ComVisibleAttribute(false)]
    public sealed partial class TrustInfo
    {
        [System.MonoTODOAttribute]
        public TrustInfo() { }
        [System.MonoTODOAttribute]
        public bool HasUnmanagedCodePermission { get { throw null; } }
        [System.MonoTODOAttribute]
        public bool IsFullTrust { get { throw null; } set { } }
        [System.MonoTODOAttribute]
        public System.Security.PermissionSet PermissionSet { get { throw null; } set { } }
        [System.MonoTODOAttribute]
        public bool PreserveFullTrustPermissionSet { get { throw null; } set { } }
        [System.MonoTODOAttribute]
        public string SameSiteAccess { get { throw null; } set { } }
        [System.MonoTODOAttribute]
        public void Clear() { }
        [System.MonoTODOAttribute]
        public void Read(System.IO.Stream input) { }
        [System.MonoTODOAttribute]
        public void Read(string path) { }
        [System.MonoTODOAttribute]
        public void ReadManifest(System.IO.Stream input) { }
        [System.MonoTODOAttribute]
        public void ReadManifest(string path) { }
        [System.MonoTODOAttribute]
        public override string ToString() { throw null; }
        [System.MonoTODOAttribute]
        public void Write(System.IO.Stream output) { }
        [System.MonoTODOAttribute]
        public void Write(string path) { }
        [System.MonoTODOAttribute]
        public void WriteManifest(System.IO.Stream output) { }
        [System.MonoTODOAttribute]
        public void WriteManifest(System.IO.Stream input, System.IO.Stream output) { }
        [System.MonoTODOAttribute]
        public void WriteManifest(string path) { }
    }
    [System.Runtime.InteropServices.ComVisibleAttribute(false)]
    public partial class TypeLib
    {
        [System.MonoTODOAttribute]
        public TypeLib() { }
        public string Flags { get { throw null; } }
        public string HelpDirectory { get { throw null; } }
        public string ResourceId { get { throw null; } }
        public string TlbId { get { throw null; } }
        public string Version { get { throw null; } }
        public string XmlFlags { get { throw null; } set { } }
        public string XmlHelpDirectory { get { throw null; } set { } }
        public string XmlResourceId { get { throw null; } set { } }
        public string XmlTlbId { get { throw null; } set { } }
        public string XmlVersion { get { throw null; } set { } }
    }
    [System.Runtime.InteropServices.ComVisibleAttribute(false)]
    public enum UpdateMode
    {
        Background = 0,
        Foreground = 1,
    }
    [System.Runtime.InteropServices.ComVisibleAttribute(false)]
    public enum UpdateUnit
    {
        Days = 1,
        Hours = 0,
        Weeks = 2,
    }
    [System.Runtime.InteropServices.ComVisibleAttribute(false)]
    public partial class WindowClass
    {
        [System.MonoTODOAttribute]
        public WindowClass() { }
        [System.MonoTODOAttribute]
        public WindowClass(string name, bool versioned) { }
        public string Name { get { throw null; } }
        public bool Versioned { get { throw null; } }
        public string XmlName { get { throw null; } set { } }
        public string XmlVersioned { get { throw null; } set { } }
    }
}
namespace Microsoft.Build.Tasks.Hosting
{
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    [System.Runtime.InteropServices.GuidAttribute("8520CC4D-64DC-4855-BE3F-4C28CCE048EE")]
    [System.Runtime.InteropServices.InterfaceTypeAttribute((System.Runtime.InteropServices.ComInterfaceType)(1))]
    public partial interface ICscHostObject : Microsoft.Build.Framework.ITaskHost
    {
        void BeginInitialization();
        bool Compile();
        bool EndInitialization(out string errorMessage, out int errorCode);
        bool IsDesignTime();
        bool IsUpToDate();
        bool SetAdditionalLibPaths(string[] additionalLibPaths);
        bool SetAddModules(string[] addModules);
        bool SetAllowUnsafeBlocks(bool allowUnsafeBlocks);
        bool SetBaseAddress(string baseAddress);
        bool SetCheckForOverflowUnderflow(bool checkForOverflowUnderflow);
        bool SetCodePage(int codePage);
        bool SetDebugType(string debugType);
        bool SetDefineConstants(string defineConstants);
        bool SetDelaySign(bool delaySignExplicitlySet, bool delaySign);
        bool SetDisabledWarnings(string disabledWarnings);
        bool SetDocumentationFile(string documentationFile);
        bool SetEmitDebugInformation(bool emitDebugInformation);
        bool SetErrorReport(string errorReport);
        bool SetFileAlignment(int fileAlignment);
        bool SetGenerateFullPaths(bool generateFullPaths);
        bool SetKeyContainer(string keyContainer);
        bool SetKeyFile(string keyFile);
        bool SetLangVersion(string langVersion);
        bool SetLinkResources(Microsoft.Build.Framework.ITaskItem[] linkResources);
        bool SetMainEntryPoint(string targetType, string mainEntryPoint);
        bool SetModuleAssemblyName(string moduleAssemblyName);
        bool SetNoConfig(bool noConfig);
        bool SetNoStandardLib(bool noStandardLib);
        bool SetOptimize(bool optimize);
        bool SetOutputAssembly(string outputAssembly);
        bool SetPdbFile(string pdbFile);
        bool SetPlatform(string platform);
        bool SetReferences(Microsoft.Build.Framework.ITaskItem[] references);
        bool SetResources(Microsoft.Build.Framework.ITaskItem[] resources);
        bool SetResponseFiles(Microsoft.Build.Framework.ITaskItem[] responseFiles);
        bool SetSources(Microsoft.Build.Framework.ITaskItem[] sources);
        bool SetTargetType(string targetType);
        bool SetTreatWarningsAsErrors(bool treatWarningsAsErrors);
        bool SetWarningLevel(int warningLevel);
        bool SetWarningsAsErrors(string warningsAsErrors);
        bool SetWarningsNotAsErrors(string warningsNotAsErrors);
        bool SetWin32Icon(string win32Icon);
        bool SetWin32Resource(string win32Resource);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute(true)]
    [System.Runtime.InteropServices.GuidAttribute("7D7AC3BE-253A-40e8-A3FF-357D0DA7C47A")]
    [System.Runtime.InteropServices.InterfaceTypeAttribute((System.Runtime.InteropServices.ComInterfaceType)(1))]
    public partial interface IVbcHostObject : Microsoft.Build.Framework.ITaskHost
    {
        void BeginInitialization();
        bool Compile();
        void EndInitialization();
        bool IsDesignTime();
        bool IsUpToDate();
        bool SetAdditionalLibPaths(string[] additionalLibPaths);
        bool SetAddModules(string[] addModules);
        bool SetBaseAddress(string targetType, string baseAddress);
        bool SetCodePage(int codePage);
        bool SetDebugType(bool emitDebugInformation, string debugType);
        bool SetDefineConstants(string defineConstants);
        bool SetDelaySign(bool delaySign);
        bool SetDisabledWarnings(string disabledWarnings);
        bool SetDocumentationFile(string documentationFile);
        bool SetErrorReport(string errorReport);
        bool SetFileAlignment(int fileAlignment);
        bool SetGenerateDocumentation(bool generateDocumentation);
        bool SetImports(Microsoft.Build.Framework.ITaskItem[] importsList);
        bool SetKeyContainer(string keyContainer);
        bool SetKeyFile(string keyFile);
        bool SetLinkResources(Microsoft.Build.Framework.ITaskItem[] linkResources);
        bool SetMainEntryPoint(string mainEntryPoint);
        bool SetNoConfig(bool noConfig);
        bool SetNoStandardLib(bool noStandardLib);
        bool SetNoWarnings(bool noWarnings);
        bool SetOptimize(bool optimize);
        bool SetOptionCompare(string optionCompare);
        bool SetOptionExplicit(bool optionExplicit);
        bool SetOptionStrict(bool optionStrict);
        bool SetOptionStrictType(string optionStrictType);
        bool SetOutputAssembly(string outputAssembly);
        bool SetPlatform(string platform);
        bool SetReferences(Microsoft.Build.Framework.ITaskItem[] references);
        bool SetRemoveIntegerChecks(bool removeIntegerChecks);
        bool SetResources(Microsoft.Build.Framework.ITaskItem[] resources);
        bool SetResponseFiles(Microsoft.Build.Framework.ITaskItem[] responseFiles);
        bool SetRootNamespace(string rootNamespace);
        bool SetSdkPath(string sdkPath);
        bool SetSources(Microsoft.Build.Framework.ITaskItem[] sources);
        bool SetTargetCompactFramework(bool targetCompactFramework);
        bool SetTargetType(string targetType);
        bool SetTreatWarningsAsErrors(bool treatWarningsAsErrors);
        bool SetWarningsAsErrors(string warningsAsErrors);
        bool SetWarningsNotAsErrors(string warningsNotAsErrors);
        bool SetWin32Icon(string win32Icon);
        bool SetWin32Resource(string win32Resource);
    }
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
