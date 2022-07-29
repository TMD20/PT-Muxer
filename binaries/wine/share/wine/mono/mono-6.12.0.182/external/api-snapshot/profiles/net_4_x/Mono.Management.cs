// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

[assembly:System.Reflection.AssemblyVersionAttribute("4.0.0.0")]
[assembly:System.Diagnostics.DebuggableAttribute(System.Diagnostics.DebuggableAttribute.DebuggingModes.IgnoreSymbolStoreSequencePoints)]
[assembly:System.Runtime.CompilerServices.CompilationRelaxationsAttribute(8)]
[assembly:System.Runtime.CompilerServices.RuntimeCompatibilityAttribute(WrapNonExceptionThrows=true)]
namespace Mono.Attach
{
    public partial class VirtualMachine
    {
        public VirtualMachine(long pid) { }
        public bool IsCurrent { get { throw null; } }
        public long Pid { get { throw null; } }
        public void Attach(string agent, string args) { }
        public string[] GetCommandLine() { throw null; }
        public static System.Collections.Generic.List<Mono.Attach.VirtualMachine> GetVirtualMachines() { throw null; }
        public string GetWorkingDirectory() { throw null; }
        public override string ToString() { throw null; }
    }
}
