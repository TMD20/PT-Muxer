// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

[assembly:System.Reflection.AssemblyVersionAttribute("4.2.0.0")]
[assembly:System.CLSCompliantAttribute(true)]
[assembly:System.Diagnostics.DebuggableAttribute(System.Diagnostics.DebuggableAttribute.DebuggingModes.IgnoreSymbolStoreSequencePoints)]
[assembly:System.Reflection.AssemblyCompanyAttribute("Mono development team")]
[assembly:System.Reflection.AssemblyCopyrightAttribute("(c) Various Mono authors")]
[assembly:System.Reflection.AssemblyDefaultAliasAttribute("System.Diagnostics.Tracing.dll")]
[assembly:System.Reflection.AssemblyDescriptionAttribute("System.Diagnostics.Tracing.dll")]
[assembly:System.Reflection.AssemblyFileVersionAttribute("4.8.3761.0")]
[assembly:System.Reflection.AssemblyInformationalVersionAttribute("4.8.3761.0")]
[assembly:System.Reflection.AssemblyProductAttribute("Mono Common Language Infrastructure")]
[assembly:System.Reflection.AssemblyTitleAttribute("System.Diagnostics.Tracing.dll")]
[assembly:System.Resources.NeutralResourcesLanguageAttribute("en-US")]
[assembly:System.Resources.SatelliteContractVersionAttribute("4.0.0.0")]
[assembly:System.Runtime.CompilerServices.CompilationRelaxationsAttribute(8)]
[assembly:System.Runtime.CompilerServices.ReferenceAssemblyAttribute]
[assembly:System.Runtime.CompilerServices.RuntimeCompatibilityAttribute(WrapNonExceptionThrows=true)]
[assembly:System.Runtime.InteropServices.ComVisibleAttribute(false)]
[assembly:System.Runtime.InteropServices.DefaultDllImportSearchPathsAttribute(System.Runtime.InteropServices.DllImportSearchPath.AssemblyDirectory | System.Runtime.InteropServices.DllImportSearchPath.System32)]
[assembly:System.Runtime.CompilerServices.TypeForwardedToAttribute(typeof(System.Diagnostics.Tracing.EventActivityOptions))]
[assembly:System.Runtime.CompilerServices.TypeForwardedToAttribute(typeof(System.Diagnostics.Tracing.EventAttribute))]
[assembly:System.Runtime.CompilerServices.TypeForwardedToAttribute(typeof(System.Diagnostics.Tracing.EventChannel))]
[assembly:System.Runtime.CompilerServices.TypeForwardedToAttribute(typeof(System.Diagnostics.Tracing.EventCommand))]
[assembly:System.Runtime.CompilerServices.TypeForwardedToAttribute(typeof(System.Diagnostics.Tracing.EventCommandEventArgs))]
[assembly:System.Runtime.CompilerServices.TypeForwardedToAttribute(typeof(System.Diagnostics.Tracing.EventDataAttribute))]
[assembly:System.Runtime.CompilerServices.TypeForwardedToAttribute(typeof(System.Diagnostics.Tracing.EventFieldAttribute))]
[assembly:System.Runtime.CompilerServices.TypeForwardedToAttribute(typeof(System.Diagnostics.Tracing.EventFieldFormat))]
[assembly:System.Runtime.CompilerServices.TypeForwardedToAttribute(typeof(System.Diagnostics.Tracing.EventFieldTags))]
[assembly:System.Runtime.CompilerServices.TypeForwardedToAttribute(typeof(System.Diagnostics.Tracing.EventIgnoreAttribute))]
[assembly:System.Runtime.CompilerServices.TypeForwardedToAttribute(typeof(System.Diagnostics.Tracing.EventKeywords))]
[assembly:System.Runtime.CompilerServices.TypeForwardedToAttribute(typeof(System.Diagnostics.Tracing.EventLevel))]
[assembly:System.Runtime.CompilerServices.TypeForwardedToAttribute(typeof(System.Diagnostics.Tracing.EventListener))]
[assembly:System.Runtime.CompilerServices.TypeForwardedToAttribute(typeof(System.Diagnostics.Tracing.EventManifestOptions))]
[assembly:System.Runtime.CompilerServices.TypeForwardedToAttribute(typeof(System.Diagnostics.Tracing.EventOpcode))]
[assembly:System.Runtime.CompilerServices.TypeForwardedToAttribute(typeof(System.Diagnostics.Tracing.EventSource))]
[assembly:System.Runtime.CompilerServices.TypeForwardedToAttribute(typeof(System.Diagnostics.Tracing.EventSourceAttribute))]
[assembly:System.Runtime.CompilerServices.TypeForwardedToAttribute(typeof(System.Diagnostics.Tracing.EventSourceException))]
[assembly:System.Runtime.CompilerServices.TypeForwardedToAttribute(typeof(System.Diagnostics.Tracing.EventSourceOptions))]
[assembly:System.Runtime.CompilerServices.TypeForwardedToAttribute(typeof(System.Diagnostics.Tracing.EventSourceSettings))]
[assembly:System.Runtime.CompilerServices.TypeForwardedToAttribute(typeof(System.Diagnostics.Tracing.EventTags))]
[assembly:System.Runtime.CompilerServices.TypeForwardedToAttribute(typeof(System.Diagnostics.Tracing.EventTask))]
[assembly:System.Runtime.CompilerServices.TypeForwardedToAttribute(typeof(System.Diagnostics.Tracing.EventWrittenEventArgs))]
[assembly:System.Runtime.CompilerServices.TypeForwardedToAttribute(typeof(System.Diagnostics.Tracing.NonEventAttribute))]
namespace System.Diagnostics.Tracing
{
    public partial class EventCounter
    {
        public EventCounter(string name, System.Diagnostics.Tracing.EventSource eventSource) { }
        public void WriteMetric(float value) { }
    }
}
