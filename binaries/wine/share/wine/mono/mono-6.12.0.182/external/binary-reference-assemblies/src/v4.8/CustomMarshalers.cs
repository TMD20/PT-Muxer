// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

[assembly:System.Reflection.AssemblyVersionAttribute("4.0.0.0")]
[assembly:System.CLSCompliantAttribute(true)]
[assembly:System.Reflection.AssemblyCompanyAttribute("Mono development team")]
[assembly:System.Reflection.AssemblyCopyrightAttribute("(c) Various Mono authors")]
[assembly:System.Reflection.AssemblyDefaultAliasAttribute("CustomMarshalers.dll")]
[assembly:System.Reflection.AssemblyDescriptionAttribute("CustomMarshalers.dll")]
[assembly:System.Reflection.AssemblyFileVersionAttribute("4.8.3761.0")]
[assembly:System.Reflection.AssemblyInformationalVersionAttribute("4.0.30319.0")]
[assembly:System.Reflection.AssemblyProductAttribute("Mono Common Language Infrastructure")]
[assembly:System.Reflection.AssemblyTitleAttribute("CustomMarshalers.dll")]
[assembly:System.Resources.NeutralResourcesLanguageAttribute("en-US")]
[assembly:System.Resources.SatelliteContractVersionAttribute("4.0.0.0")]
[assembly:System.Runtime.CompilerServices.ReferenceAssemblyAttribute]
[assembly:System.Runtime.CompilerServices.RuntimeCompatibilityAttribute(WrapNonExceptionThrows=true)]
[assembly:System.Runtime.InteropServices.ComVisibleAttribute(false)]
[assembly:System.Runtime.InteropServices.DefaultDllImportSearchPathsAttribute(System.Runtime.InteropServices.DllImportSearchPath.AssemblyDirectory | System.Runtime.InteropServices.DllImportSearchPath.System32)]
[assembly:System.Security.SecurityRulesAttribute(System.Security.SecurityRuleSet.Level1)]
[assembly:System.Security.Permissions.SecurityPermissionAttribute(System.Security.Permissions.SecurityAction.RequestMinimum, SkipVerification=true)]
namespace System.Runtime.InteropServices.CustomMarshalers
{
    public partial class EnumerableToDispatchMarshaler : System.Runtime.InteropServices.ICustomMarshaler
    {
        internal EnumerableToDispatchMarshaler() { }
        public virtual void CleanUpManagedData(object pManagedObj) { }
        public virtual void CleanUpNativeData(System.IntPtr pNativeData) { }
        public static System.Runtime.InteropServices.ICustomMarshaler GetInstance(string pstrCookie) { throw null; }
        public virtual int GetNativeDataSize() { throw null; }
        public virtual System.IntPtr MarshalManagedToNative(object pManagedObj) { throw null; }
        public virtual object MarshalNativeToManaged(System.IntPtr pNativeData) { throw null; }
    }
    public partial class EnumeratorToEnumVariantMarshaler : System.Runtime.InteropServices.ICustomMarshaler
    {
        internal EnumeratorToEnumVariantMarshaler() { }
        public virtual void CleanUpManagedData(object pManagedObj) { }
        public virtual void CleanUpNativeData(System.IntPtr pNativeData) { }
        public static System.Runtime.InteropServices.ICustomMarshaler GetInstance(string pstrCookie) { throw null; }
        public virtual int GetNativeDataSize() { throw null; }
        public virtual System.IntPtr MarshalManagedToNative(object pManagedObj) { throw null; }
        public virtual object MarshalNativeToManaged(System.IntPtr pNativeData) { throw null; }
    }
    public partial class ExpandoToDispatchExMarshaler : System.Runtime.InteropServices.ICustomMarshaler
    {
        internal ExpandoToDispatchExMarshaler() { }
        public virtual void CleanUpManagedData(object pManagedObj) { }
        public virtual void CleanUpNativeData(System.IntPtr pNativeData) { }
        public static System.Runtime.InteropServices.ICustomMarshaler GetInstance(string pstrCookie) { throw null; }
        public virtual int GetNativeDataSize() { throw null; }
        public virtual System.IntPtr MarshalManagedToNative(object pManagedObj) { throw null; }
        public virtual object MarshalNativeToManaged(System.IntPtr pNativeData) { throw null; }
    }
    public partial class TypeToTypeInfoMarshaler : System.Runtime.InteropServices.ICustomMarshaler
    {
        internal TypeToTypeInfoMarshaler() { }
        public virtual void CleanUpManagedData(object pManagedObj) { }
        public virtual void CleanUpNativeData(System.IntPtr pNativeData) { }
        public static System.Runtime.InteropServices.ICustomMarshaler GetInstance(string pstrCookie) { throw null; }
        public virtual int GetNativeDataSize() { throw null; }
        public virtual System.IntPtr MarshalManagedToNative(object pManagedObj) { throw null; }
        public virtual object MarshalNativeToManaged(System.IntPtr pNativeData) { throw null; }
    }
}
