// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

[assembly:System.Reflection.AssemblyVersionAttribute("4.0.0.0")]
[assembly:System.CLSCompliantAttribute(true)]
[assembly:System.Diagnostics.DebuggableAttribute(System.Diagnostics.DebuggableAttribute.DebuggingModes.IgnoreSymbolStoreSequencePoints)]
[assembly:System.Reflection.AssemblyCompanyAttribute("Mono development team")]
[assembly:System.Reflection.AssemblyCopyrightAttribute("(c) Various Mono authors")]
[assembly:System.Reflection.AssemblyDefaultAliasAttribute("System.Runtime.Serialization.Formatters.Soap.dll")]
[assembly:System.Reflection.AssemblyDescriptionAttribute("System.Runtime.Serialization.Formatters.Soap.dll")]
[assembly:System.Reflection.AssemblyFileVersionAttribute("4.7.3062.0")]
[assembly:System.Reflection.AssemblyInformationalVersionAttribute("4.7.3062.0")]
[assembly:System.Reflection.AssemblyProductAttribute("Mono Common Language Infrastructure")]
[assembly:System.Reflection.AssemblyTitleAttribute("System.Runtime.Serialization.Formatters.Soap.dll")]
[assembly:System.Resources.NeutralResourcesLanguageAttribute("en-US")]
[assembly:System.Resources.SatelliteContractVersionAttribute("4.0.0.0")]
[assembly:System.Runtime.CompilerServices.CompilationRelaxationsAttribute(8)]
[assembly:System.Runtime.CompilerServices.ReferenceAssemblyAttribute]
[assembly:System.Runtime.CompilerServices.RuntimeCompatibilityAttribute(WrapNonExceptionThrows=true)]
[assembly:System.Runtime.InteropServices.ComCompatibleVersionAttribute(1, 0, 3300, 0)]
[assembly:System.Runtime.InteropServices.ComVisibleAttribute(true)]
[assembly:System.Runtime.InteropServices.DefaultDllImportSearchPathsAttribute(System.Runtime.InteropServices.DllImportSearchPath.AssemblyDirectory | System.Runtime.InteropServices.DllImportSearchPath.System32)]
namespace System.Runtime.Serialization.Formatters.Soap
{
    public sealed partial class SoapFormatter : System.Runtime.Remoting.Messaging.IRemotingFormatter, System.Runtime.Serialization.IFormatter
    {
        public SoapFormatter() { }
        public SoapFormatter(System.Runtime.Serialization.ISurrogateSelector selector, System.Runtime.Serialization.StreamingContext context) { }
        public System.Runtime.Serialization.Formatters.FormatterAssemblyStyle AssemblyFormat { get { throw null; } set { } }
        public System.Runtime.Serialization.SerializationBinder Binder { get { throw null; } set { } }
        public System.Runtime.Serialization.StreamingContext Context { get { throw null; } set { } }
        public System.Runtime.Serialization.Formatters.TypeFilterLevel FilterLevel { get { throw null; } set { } }
        public System.Runtime.Serialization.ISurrogateSelector SurrogateSelector { get { throw null; } set { } }
        public System.Runtime.Serialization.Formatters.ISoapMessage TopObject { get { throw null; } set { } }
        public System.Runtime.Serialization.Formatters.FormatterTypeStyle TypeFormat { get { throw null; } set { } }
        public object Deserialize(System.IO.Stream serializationStream) { throw null; }
        public object Deserialize(System.IO.Stream serializationStream, System.Runtime.Remoting.Messaging.HeaderHandler handler) { throw null; }
        public void Serialize(System.IO.Stream serializationStream, object graph) { }
        public void Serialize(System.IO.Stream serializationStream, object graph, System.Runtime.Remoting.Messaging.Header[] headers) { }
    }
}
