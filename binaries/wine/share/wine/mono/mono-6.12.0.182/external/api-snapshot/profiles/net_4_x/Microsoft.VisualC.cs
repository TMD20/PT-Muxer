// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

[assembly:System.Reflection.AssemblyVersionAttribute("10.0.0.0")]
[assembly:System.Diagnostics.DebuggableAttribute(System.Diagnostics.DebuggableAttribute.DebuggingModes.IgnoreSymbolStoreSequencePoints)]
[assembly:System.Runtime.CompilerServices.CompilationRelaxationsAttribute(8)]
[assembly:System.Runtime.CompilerServices.RuntimeCompatibilityAttribute(WrapNonExceptionThrows=true)]
namespace Microsoft.VisualC
{
    public sealed partial class DebugInfoInPDBAttribute : System.Attribute
    {
        public DebugInfoInPDBAttribute() { }
    }
    public sealed partial class DecoratedNameAttribute : System.Attribute
    {
        public DecoratedNameAttribute() { }
    }
    public sealed partial class IsConstModifier : System.Attribute
    {
        public IsConstModifier() { }
    }
    public sealed partial class IsCXXReferenceModifier : System.Attribute
    {
        public IsCXXReferenceModifier() { }
    }
    public sealed partial class IsLongModifier : System.Attribute
    {
        public IsLongModifier() { }
    }
    public sealed partial class IsSignedModifier : System.Attribute
    {
        public IsSignedModifier() { }
    }
    public sealed partial class IsVolatileModifier : System.Attribute
    {
        public IsVolatileModifier() { }
    }
    public sealed partial class MiscellaneousBitsAttribute : System.Attribute
    {
        public int m_dwAttrs;
        public MiscellaneousBitsAttribute(int miscellaneousBits) { }
    }
    public sealed partial class NeedsCopyConstructorModifier : System.Attribute
    {
        public NeedsCopyConstructorModifier() { }
    }
    public sealed partial class NoSignSpecifiedModifier : System.Attribute
    {
        public NoSignSpecifiedModifier() { }
    }
}
