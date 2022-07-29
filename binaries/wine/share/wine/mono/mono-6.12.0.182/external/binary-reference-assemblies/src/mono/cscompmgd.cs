// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

[assembly:System.Reflection.AssemblyVersionAttribute("0.0.0.0")]
[assembly:System.CLSCompliantAttribute(true)]
[assembly:System.Diagnostics.DebuggableAttribute((System.Diagnostics.DebuggableAttribute.DebuggingModes)(2))]
[assembly:System.Reflection.AssemblyCompanyAttribute("Mono development team")]
[assembly:System.Reflection.AssemblyCopyrightAttribute("(c) Various Mono authors")]
[assembly:System.Reflection.AssemblyDefaultAliasAttribute("cscompmgd.dll")]
[assembly:System.Reflection.AssemblyDescriptionAttribute("cscompmgd.dll")]
[assembly:System.Reflection.AssemblyFileVersionAttribute("11.0.0.0")]
[assembly:System.Reflection.AssemblyInformationalVersionAttribute("11.0.0.0")]
[assembly:System.Reflection.AssemblyProductAttribute("Mono Common Language Infrastructure")]
[assembly:System.Reflection.AssemblyTitleAttribute("cscompmgd.dll")]
[assembly:System.Resources.NeutralResourcesLanguageAttribute("en-US")]
[assembly:System.Resources.SatelliteContractVersionAttribute("0.0.0.0")]
[assembly:System.Runtime.CompilerServices.CompilationRelaxationsAttribute((System.Runtime.CompilerServices.CompilationRelaxations)(8))]
[assembly:System.Runtime.CompilerServices.ReferenceAssemblyAttribute]
[assembly:System.Runtime.CompilerServices.RuntimeCompatibilityAttribute(WrapNonExceptionThrows=true)]
[assembly:System.Runtime.ConstrainedExecution.ReliabilityContractAttribute((System.Runtime.ConstrainedExecution.Consistency)(0), (System.Runtime.ConstrainedExecution.Cer)(0))]
[assembly:System.Runtime.InteropServices.ComVisibleAttribute(false)]
namespace Microsoft.CSharp
{
    [System.ObsoleteAttribute]
    public partial class Compiler
    {
        internal Compiler() { }
        [System.MonoTODOAttribute("Have not implemented bugreports")]
        public static Microsoft.CSharp.CompilerError[] Compile(string[] sourceTexts, string[] sourceTextNames, string target, string[] imports, System.Collections.IDictionary options) { throw null; }
    }
    [System.ObsoleteAttribute]
    public partial class CompilerError
    {
        public Microsoft.CSharp.ErrorLevel ErrorLevel;
        public string ErrorMessage;
        public int ErrorNumber;
        public int SourceColumn;
        public string SourceFile;
        public int SourceLine;
        public CompilerError() { }
        public override string ToString() { throw null; }
    }
    [System.ObsoleteAttribute]
    public enum ErrorLevel
    {
        Error = 2,
        FatalError = 3,
        None = 0,
        Warning = 1,
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
