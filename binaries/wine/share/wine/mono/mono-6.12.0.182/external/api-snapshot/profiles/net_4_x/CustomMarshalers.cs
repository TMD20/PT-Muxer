// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

[assembly:System.Reflection.AssemblyVersionAttribute("4.0.0.0")]
[assembly:System.CLSCompliantAttribute(true)]
[assembly:System.Diagnostics.DebuggableAttribute(System.Diagnostics.DebuggableAttribute.DebuggingModes.IgnoreSymbolStoreSequencePoints)]
[assembly:System.Reflection.AssemblyCompanyAttribute("Mono development team")]
[assembly:System.Reflection.AssemblyCopyrightAttribute("(c) Various Mono authors")]
[assembly:System.Reflection.AssemblyDefaultAliasAttribute("CustomMarshalers.dll")]
[assembly:System.Reflection.AssemblyDescriptionAttribute("CustomMarshalers.dll")]
[assembly:System.Reflection.AssemblyFileVersionAttribute("4.6.57.0")]
[assembly:System.Reflection.AssemblyInformationalVersionAttribute("4.6.57.0")]
[assembly:System.Reflection.AssemblyProductAttribute("Mono Common Language Infrastructure")]
[assembly:System.Reflection.AssemblyTitleAttribute("CustomMarshalers.dll")]
[assembly:System.Resources.NeutralResourcesLanguageAttribute("en-US")]
[assembly:System.Resources.SatelliteContractVersionAttribute("4.0.0.0")]
[assembly:System.Runtime.CompilerServices.CompilationRelaxationsAttribute(8)]
[assembly:System.Runtime.CompilerServices.RuntimeCompatibilityAttribute(WrapNonExceptionThrows=true)]
[assembly:System.Runtime.InteropServices.ComVisibleAttribute(false)]
namespace System
{
    [System.AttributeUsageAttribute(System.AttributeTargets.All, AllowMultiple=true)]
    internal partial class MonoDocumentationNoteAttribute : System.MonoTODOAttribute
    {
        public MonoDocumentationNoteAttribute(string comment) { }
    }
    [System.AttributeUsageAttribute(System.AttributeTargets.All, AllowMultiple=true)]
    internal partial class MonoExtensionAttribute : System.MonoTODOAttribute
    {
        public MonoExtensionAttribute(string comment) { }
    }
    [System.AttributeUsageAttribute(System.AttributeTargets.All, AllowMultiple=true)]
    internal partial class MonoInternalNoteAttribute : System.MonoTODOAttribute
    {
        public MonoInternalNoteAttribute(string comment) { }
    }
    [System.AttributeUsageAttribute(System.AttributeTargets.All, AllowMultiple=true)]
    internal partial class MonoLimitationAttribute : System.MonoTODOAttribute
    {
        public MonoLimitationAttribute(string comment) { }
    }
    [System.AttributeUsageAttribute(System.AttributeTargets.All, AllowMultiple=true)]
    internal partial class MonoNotSupportedAttribute : System.MonoTODOAttribute
    {
        public MonoNotSupportedAttribute(string comment) { }
    }
    [System.AttributeUsageAttribute(System.AttributeTargets.All, AllowMultiple=true)]
    internal partial class MonoTODOAttribute : System.Attribute
    {
        public MonoTODOAttribute() { }
        public MonoTODOAttribute(string comment) { }
        public string Comment { get { throw null; } }
    }
}
namespace System.Runtime.InteropServices.CustomMarshalers
{
    public partial class EnumerableToDispatchMarshaler : System.Runtime.InteropServices.ICustomMarshaler
    {
        public EnumerableToDispatchMarshaler() { }
        [System.MonoTODOAttribute]
        public void CleanUpManagedData(object pManagedObj) { }
        [System.MonoTODOAttribute]
        public void CleanUpNativeData(System.IntPtr pNativeData) { }
        [System.MonoTODOAttribute]
        public static System.Runtime.InteropServices.ICustomMarshaler GetInstance(string pstrCookie) { throw null; }
        [System.MonoTODOAttribute]
        public int GetNativeDataSize() { throw null; }
        [System.MonoTODOAttribute]
        public System.IntPtr MarshalManagedToNative(object pManagedObj) { throw null; }
        [System.MonoTODOAttribute]
        public object MarshalNativeToManaged(System.IntPtr pNativeData) { throw null; }
    }
    public partial class EnumeratorToEnumVariantMarshaler : System.Runtime.InteropServices.ICustomMarshaler
    {
        public EnumeratorToEnumVariantMarshaler() { }
        public void CleanUpManagedData(object pManagedObj) { }
        public void CleanUpNativeData(System.IntPtr pNativeData) { }
        public static System.Runtime.InteropServices.ICustomMarshaler GetInstance(string pstrCookie) { throw null; }
        public int GetNativeDataSize() { throw null; }
        public System.IntPtr MarshalManagedToNative(object pManagedObj) { throw null; }
        public object MarshalNativeToManaged(System.IntPtr pNativeData) { throw null; }
    }
    public partial class ExpandoToDispatchExMarshaler : System.Runtime.InteropServices.ICustomMarshaler
    {
        public ExpandoToDispatchExMarshaler() { }
        [System.MonoTODOAttribute]
        public void CleanUpManagedData(object pManagedObj) { }
        [System.MonoTODOAttribute]
        public void CleanUpNativeData(System.IntPtr pNativeData) { }
        [System.MonoTODOAttribute]
        public static System.Runtime.InteropServices.ICustomMarshaler GetInstance(string pstrCookie) { throw null; }
        [System.MonoTODOAttribute]
        public int GetNativeDataSize() { throw null; }
        [System.MonoTODOAttribute]
        public System.IntPtr MarshalManagedToNative(object pManagedObj) { throw null; }
        [System.MonoTODOAttribute]
        public object MarshalNativeToManaged(System.IntPtr pNativeData) { throw null; }
    }
    public partial class TypeToTypeInfoMarshaler : System.Runtime.InteropServices.ICustomMarshaler
    {
        public TypeToTypeInfoMarshaler() { }
        [System.MonoTODOAttribute]
        public void CleanUpManagedData(object pManagedObj) { }
        [System.MonoTODOAttribute]
        public void CleanUpNativeData(System.IntPtr pNativeData) { }
        [System.MonoTODOAttribute]
        public static System.Runtime.InteropServices.ICustomMarshaler GetInstance(string pstrCookie) { throw null; }
        [System.MonoTODOAttribute]
        public int GetNativeDataSize() { throw null; }
        [System.MonoTODOAttribute]
        public System.IntPtr MarshalManagedToNative(object pManagedObj) { throw null; }
        [System.MonoTODOAttribute]
        public object MarshalNativeToManaged(System.IntPtr pNativeData) { throw null; }
    }
}
