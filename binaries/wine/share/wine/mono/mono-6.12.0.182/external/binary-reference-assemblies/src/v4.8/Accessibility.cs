// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

[assembly:System.Reflection.AssemblyVersionAttribute("4.0.0.0")]
[assembly:System.CLSCompliantAttribute(true)]
[assembly:System.Diagnostics.DebuggableAttribute(System.Diagnostics.DebuggableAttribute.DebuggingModes.Default | System.Diagnostics.DebuggableAttribute.DebuggingModes.DisableOptimizations)]
[assembly:System.Reflection.AssemblyCompanyAttribute("Mono development team")]
[assembly:System.Reflection.AssemblyCopyrightAttribute("(c) Various Mono authors")]
[assembly:System.Reflection.AssemblyDefaultAliasAttribute("Accessibility.dll")]
[assembly:System.Reflection.AssemblyDescriptionAttribute("Accessibility.dll")]
[assembly:System.Reflection.AssemblyFileVersionAttribute("4.8.3761.0")]
[assembly:System.Reflection.AssemblyInformationalVersionAttribute("4.8.3761.0")]
[assembly:System.Reflection.AssemblyProductAttribute("Mono Common Language Infrastructure")]
[assembly:System.Reflection.AssemblyTitleAttribute("Accessibility.dll")]
[assembly:System.Resources.NeutralResourcesLanguageAttribute("en-US")]
[assembly:System.Resources.SatelliteContractVersionAttribute("4.0.0.0")]
[assembly:System.Runtime.CompilerServices.CompilationRelaxationsAttribute(8)]
[assembly:System.Runtime.CompilerServices.ReferenceAssemblyAttribute]
[assembly:System.Runtime.CompilerServices.RuntimeCompatibilityAttribute(WrapNonExceptionThrows=true)]
[assembly:System.Runtime.InteropServices.ComVisibleAttribute(true)]
[assembly:System.Runtime.InteropServices.DefaultDllImportSearchPathsAttribute(System.Runtime.InteropServices.DllImportSearchPath.AssemblyDirectory | System.Runtime.InteropServices.DllImportSearchPath.System32)]
[assembly:System.Runtime.InteropServices.GuidAttribute("1EA4DBF0-3C3B-11CF-810C-00AA00389B71")]
[assembly:System.Runtime.InteropServices.ImportedFromTypeLibAttribute("Accessibility")]
[assembly:System.Runtime.InteropServices.TypeLibVersionAttribute(1, 1)]
[assembly:System.Security.AllowPartiallyTrustedCallersAttribute]
[assembly:System.Security.SecurityRulesAttribute(System.Security.SecurityRuleSet.Level2, SkipVerificationInFullTrust=true)]
namespace Accessibility
{
    public enum AnnoScope
    {
        ANNO_CONTAINER = 1,
        ANNO_THIS = 0,
    }
    [System.Runtime.InteropServices.CoClassAttribute(typeof(Accessibility.CAccPropServicesClass))]
    [System.Runtime.InteropServices.GuidAttribute("6E26E776-04F0-495D-80E4-3330352E3169")]
    public partial interface CAccPropServices : Accessibility.IAccPropServices
    {
    }
    [System.Runtime.InteropServices.ClassInterfaceAttribute(System.Runtime.InteropServices.ClassInterfaceType.None)]
    [System.Runtime.InteropServices.ComConversionLossAttribute]
    [System.Runtime.InteropServices.GuidAttribute("B5F8350B-0548-48B1-A6EE-88BD00B4A5E7")]
    [System.Runtime.InteropServices.TypeLibTypeAttribute(System.Runtime.InteropServices.TypeLibTypeFlags.FCanCreate)]
    public partial class CAccPropServicesClass : Accessibility.CAccPropServices, Accessibility.IAccPropServices
    {
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]public CAccPropServicesClass() { }
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]public virtual void ClearHmenuProps([System.Runtime.InteropServices.ComAliasNameAttribute("Accessibility.wireHMENU")][System.Runtime.InteropServices.In]ref Accessibility._RemotableHandle hmenu, [System.Runtime.InteropServices.In]uint idChild, [System.Runtime.InteropServices.In]ref System.Guid paProps, [System.Runtime.InteropServices.In]int cProps) { }
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]public virtual void ClearHwndProps([System.Runtime.InteropServices.ComAliasNameAttribute("Accessibility.wireHWND")][System.Runtime.InteropServices.In]ref Accessibility._RemotableHandle hwnd, [System.Runtime.InteropServices.In]uint idObject, [System.Runtime.InteropServices.In]uint idChild, [System.Runtime.InteropServices.In]ref System.Guid paProps, [System.Runtime.InteropServices.In]int cProps) { }
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]public virtual void ClearProps([System.Runtime.InteropServices.In]ref byte pIDString, [System.Runtime.InteropServices.In]uint dwIDStringLen, [System.Runtime.InteropServices.In]ref System.Guid paProps, [System.Runtime.InteropServices.In]int cProps) { }
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]public virtual void ComposeHmenuIdentityString([System.Runtime.InteropServices.ComAliasNameAttribute("Accessibility.wireHMENU")][System.Runtime.InteropServices.In]ref Accessibility._RemotableHandle hmenu, [System.Runtime.InteropServices.In]uint idChild, [System.Runtime.InteropServices.Out]System.IntPtr ppIDString, out uint pdwIDStringLen) { ppIDString = default(System.IntPtr); pdwIDStringLen = default(uint); }
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]public virtual void ComposeHwndIdentityString([System.Runtime.InteropServices.ComAliasNameAttribute("Accessibility.wireHWND")][System.Runtime.InteropServices.In]ref Accessibility._RemotableHandle hwnd, [System.Runtime.InteropServices.In]uint idObject, [System.Runtime.InteropServices.In]uint idChild, [System.Runtime.InteropServices.Out]System.IntPtr ppIDString, out uint pdwIDStringLen) { ppIDString = default(System.IntPtr); pdwIDStringLen = default(uint); }
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]public virtual void DecomposeHmenuIdentityString([System.Runtime.InteropServices.In]ref byte pIDString, [System.Runtime.InteropServices.In]uint dwIDStringLen, [System.Runtime.InteropServices.ComAliasNameAttribute("Accessibility.wireHMENU")][System.Runtime.InteropServices.Out]System.IntPtr phmenu, out uint pidChild) { phmenu = default(System.IntPtr); pidChild = default(uint); }
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]public virtual void DecomposeHwndIdentityString([System.Runtime.InteropServices.In]ref byte pIDString, [System.Runtime.InteropServices.In]uint dwIDStringLen, [System.Runtime.InteropServices.ComAliasNameAttribute("Accessibility.wireHWND")][System.Runtime.InteropServices.Out]System.IntPtr phwnd, out uint pidObject, out uint pidChild) { phwnd = default(System.IntPtr); pidObject = default(uint); pidChild = default(uint); }
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]public virtual void SetHmenuProp([System.Runtime.InteropServices.ComAliasNameAttribute("Accessibility.wireHMENU")][System.Runtime.InteropServices.In]ref Accessibility._RemotableHandle hmenu, [System.Runtime.InteropServices.In]uint idChild, [System.Runtime.InteropServices.In]System.Guid idProp, [System.Runtime.InteropServices.In][System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.Struct)]object var) { }
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]public virtual void SetHmenuPropServer([System.Runtime.InteropServices.ComAliasNameAttribute("Accessibility.wireHMENU")][System.Runtime.InteropServices.In]ref Accessibility._RemotableHandle hmenu, [System.Runtime.InteropServices.In]uint idChild, [System.Runtime.InteropServices.In]ref System.Guid paProps, [System.Runtime.InteropServices.In]int cProps, [System.Runtime.InteropServices.In][System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.Interface)]Accessibility.IAccPropServer pServer, [System.Runtime.InteropServices.In]Accessibility.AnnoScope AnnoScope) { }
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]public virtual void SetHmenuPropStr([System.Runtime.InteropServices.ComAliasNameAttribute("Accessibility.wireHMENU")][System.Runtime.InteropServices.In]ref Accessibility._RemotableHandle hmenu, [System.Runtime.InteropServices.In]uint idChild, [System.Runtime.InteropServices.In]System.Guid idProp, [System.Runtime.InteropServices.In][System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.LPWStr)]string str) { }
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]public virtual void SetHwndProp([System.Runtime.InteropServices.ComAliasNameAttribute("Accessibility.wireHWND")][System.Runtime.InteropServices.In]ref Accessibility._RemotableHandle hwnd, [System.Runtime.InteropServices.In]uint idObject, [System.Runtime.InteropServices.In]uint idChild, [System.Runtime.InteropServices.In]System.Guid idProp, [System.Runtime.InteropServices.In][System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.Struct)]object var) { }
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]public virtual void SetHwndPropServer([System.Runtime.InteropServices.ComAliasNameAttribute("Accessibility.wireHWND")][System.Runtime.InteropServices.In]ref Accessibility._RemotableHandle hwnd, [System.Runtime.InteropServices.In]uint idObject, [System.Runtime.InteropServices.In]uint idChild, [System.Runtime.InteropServices.In]ref System.Guid paProps, [System.Runtime.InteropServices.In]int cProps, [System.Runtime.InteropServices.In][System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.Interface)]Accessibility.IAccPropServer pServer, [System.Runtime.InteropServices.In]Accessibility.AnnoScope AnnoScope) { }
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]public virtual void SetHwndPropStr([System.Runtime.InteropServices.ComAliasNameAttribute("Accessibility.wireHWND")][System.Runtime.InteropServices.In]ref Accessibility._RemotableHandle hwnd, [System.Runtime.InteropServices.In]uint idObject, [System.Runtime.InteropServices.In]uint idChild, [System.Runtime.InteropServices.In]System.Guid idProp, [System.Runtime.InteropServices.In][System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.LPWStr)]string str) { }
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]public virtual void SetPropServer([System.Runtime.InteropServices.In]ref byte pIDString, [System.Runtime.InteropServices.In]uint dwIDStringLen, [System.Runtime.InteropServices.In]ref System.Guid paProps, [System.Runtime.InteropServices.In]int cProps, [System.Runtime.InteropServices.In][System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.Interface)]Accessibility.IAccPropServer pServer, [System.Runtime.InteropServices.In]Accessibility.AnnoScope AnnoScope) { }
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]public virtual void SetPropValue([System.Runtime.InteropServices.In]ref byte pIDString, [System.Runtime.InteropServices.In]uint dwIDStringLen, [System.Runtime.InteropServices.In]System.Guid idProp, [System.Runtime.InteropServices.In][System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.Struct)]object var) { }
    }
    [System.Runtime.InteropServices.GuidAttribute("618736E0-3C3D-11CF-810C-00AA00389B71")]
    [System.Runtime.InteropServices.TypeLibTypeAttribute(System.Runtime.InteropServices.TypeLibTypeFlags.FDispatchable | System.Runtime.InteropServices.TypeLibTypeFlags.FDual | System.Runtime.InteropServices.TypeLibTypeFlags.FHidden)]
    public partial interface IAccessible
    {
        int accChildCount { get; }
        object accFocus { get; }
        object accParent { get; }
        object accSelection { get; }
        void accDoDefaultAction(object childID);
        object accHitTest(int xLeft, int yTop);
        void accLocation(out int pxLeft, out int pyTop, out int pcxWidth, out int pcyHeight, object childID);
        object accNavigate(int navDir, object childID);
        void accSelect(int flagsSelect, object childID);
        object get_accChild(object childID);
        string get_accDefaultAction(object childID);
        string get_accDescription(object childID);
        string get_accHelp(object childID);
        int get_accHelpTopic(out string pszHelpFile, object childID);
        string get_accKeyboardShortcut(object childID);
        string get_accName(object childID);
        object get_accRole(object childID);
        object get_accState(object childID);
        string get_accValue(object childID);
        void set_accName(object childID, string newName);
        void set_accValue(object childID, string newValue);
    }
    [System.Runtime.InteropServices.GuidAttribute("03022430-ABC4-11D0-BDE2-00AA001A1953")]
    [System.Runtime.InteropServices.InterfaceTypeAttribute(System.Runtime.InteropServices.ComInterfaceType.InterfaceIsIUnknown)]
    [System.Runtime.InteropServices.TypeLibTypeAttribute(System.Runtime.InteropServices.TypeLibTypeFlags.FHidden | System.Runtime.InteropServices.TypeLibTypeFlags.FOleAutomation)]
    public partial interface IAccessibleHandler
    {
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]void AccessibleObjectFromID([System.Runtime.InteropServices.In]int hwnd, [System.Runtime.InteropServices.In]int lObjectID, [System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.Interface)]out Accessibility.IAccessible pIAccessible);
    }
    [System.Runtime.InteropServices.ComConversionLossAttribute]
    [System.Runtime.InteropServices.GuidAttribute("7852B78D-1CFD-41C1-A615-9C0C85960B5F")]
    [System.Runtime.InteropServices.InterfaceTypeAttribute(System.Runtime.InteropServices.ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IAccIdentity
    {
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]void GetIdentityString([System.Runtime.InteropServices.In]uint dwIDChild, [System.Runtime.InteropServices.Out]System.IntPtr ppIDString, out uint pdwIDStringLen);
    }
    [System.Runtime.InteropServices.GuidAttribute("76C0DBBB-15E0-4E7B-B61B-20EEEA2001E0")]
    [System.Runtime.InteropServices.InterfaceTypeAttribute(System.Runtime.InteropServices.ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IAccPropServer
    {
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]void GetPropValue([System.Runtime.InteropServices.In]ref byte pIDString, [System.Runtime.InteropServices.In]uint dwIDStringLen, [System.Runtime.InteropServices.In]System.Guid idProp, [System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.Struct)]out object pvarValue, out int pfHasProp);
    }
    [System.Runtime.InteropServices.ComConversionLossAttribute]
    [System.Runtime.InteropServices.GuidAttribute("6E26E776-04F0-495D-80E4-3330352E3169")]
    [System.Runtime.InteropServices.InterfaceTypeAttribute(System.Runtime.InteropServices.ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IAccPropServices
    {
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]void ClearHmenuProps([System.Runtime.InteropServices.ComAliasNameAttribute("Accessibility.wireHMENU")][System.Runtime.InteropServices.In]ref Accessibility._RemotableHandle hmenu, [System.Runtime.InteropServices.In]uint idChild, [System.Runtime.InteropServices.In]ref System.Guid paProps, [System.Runtime.InteropServices.In]int cProps);
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]void ClearHwndProps([System.Runtime.InteropServices.ComAliasNameAttribute("Accessibility.wireHWND")][System.Runtime.InteropServices.In]ref Accessibility._RemotableHandle hwnd, [System.Runtime.InteropServices.In]uint idObject, [System.Runtime.InteropServices.In]uint idChild, [System.Runtime.InteropServices.In]ref System.Guid paProps, [System.Runtime.InteropServices.In]int cProps);
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]void ClearProps([System.Runtime.InteropServices.In]ref byte pIDString, [System.Runtime.InteropServices.In]uint dwIDStringLen, [System.Runtime.InteropServices.In]ref System.Guid paProps, [System.Runtime.InteropServices.In]int cProps);
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]void ComposeHmenuIdentityString([System.Runtime.InteropServices.ComAliasNameAttribute("Accessibility.wireHMENU")][System.Runtime.InteropServices.In]ref Accessibility._RemotableHandle hmenu, [System.Runtime.InteropServices.In]uint idChild, [System.Runtime.InteropServices.Out]System.IntPtr ppIDString, out uint pdwIDStringLen);
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]void ComposeHwndIdentityString([System.Runtime.InteropServices.ComAliasNameAttribute("Accessibility.wireHWND")][System.Runtime.InteropServices.In]ref Accessibility._RemotableHandle hwnd, [System.Runtime.InteropServices.In]uint idObject, [System.Runtime.InteropServices.In]uint idChild, [System.Runtime.InteropServices.Out]System.IntPtr ppIDString, out uint pdwIDStringLen);
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]void DecomposeHmenuIdentityString([System.Runtime.InteropServices.In]ref byte pIDString, [System.Runtime.InteropServices.In]uint dwIDStringLen, [System.Runtime.InteropServices.ComAliasNameAttribute("Accessibility.wireHMENU")][System.Runtime.InteropServices.Out]System.IntPtr phmenu, out uint pidChild);
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]void DecomposeHwndIdentityString([System.Runtime.InteropServices.In]ref byte pIDString, [System.Runtime.InteropServices.In]uint dwIDStringLen, [System.Runtime.InteropServices.ComAliasNameAttribute("Accessibility.wireHWND")][System.Runtime.InteropServices.Out]System.IntPtr phwnd, out uint pidObject, out uint pidChild);
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]void SetHmenuProp([System.Runtime.InteropServices.ComAliasNameAttribute("Accessibility.wireHMENU")][System.Runtime.InteropServices.In]ref Accessibility._RemotableHandle hmenu, [System.Runtime.InteropServices.In]uint idChild, [System.Runtime.InteropServices.In]System.Guid idProp, [System.Runtime.InteropServices.In][System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.Struct)]object var);
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]void SetHmenuPropServer([System.Runtime.InteropServices.ComAliasNameAttribute("Accessibility.wireHMENU")][System.Runtime.InteropServices.In]ref Accessibility._RemotableHandle hmenu, [System.Runtime.InteropServices.In]uint idChild, [System.Runtime.InteropServices.In]ref System.Guid paProps, [System.Runtime.InteropServices.In]int cProps, [System.Runtime.InteropServices.In][System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.Interface)]Accessibility.IAccPropServer pServer, [System.Runtime.InteropServices.In]Accessibility.AnnoScope AnnoScope);
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]void SetHmenuPropStr([System.Runtime.InteropServices.ComAliasNameAttribute("Accessibility.wireHMENU")][System.Runtime.InteropServices.In]ref Accessibility._RemotableHandle hmenu, [System.Runtime.InteropServices.In]uint idChild, [System.Runtime.InteropServices.In]System.Guid idProp, [System.Runtime.InteropServices.In][System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.LPWStr)]string str);
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]void SetHwndProp([System.Runtime.InteropServices.ComAliasNameAttribute("Accessibility.wireHWND")][System.Runtime.InteropServices.In]ref Accessibility._RemotableHandle hwnd, [System.Runtime.InteropServices.In]uint idObject, [System.Runtime.InteropServices.In]uint idChild, [System.Runtime.InteropServices.In]System.Guid idProp, [System.Runtime.InteropServices.In][System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.Struct)]object var);
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]void SetHwndPropServer([System.Runtime.InteropServices.ComAliasNameAttribute("Accessibility.wireHWND")][System.Runtime.InteropServices.In]ref Accessibility._RemotableHandle hwnd, [System.Runtime.InteropServices.In]uint idObject, [System.Runtime.InteropServices.In]uint idChild, [System.Runtime.InteropServices.In]ref System.Guid paProps, [System.Runtime.InteropServices.In]int cProps, [System.Runtime.InteropServices.In][System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.Interface)]Accessibility.IAccPropServer pServer, [System.Runtime.InteropServices.In]Accessibility.AnnoScope AnnoScope);
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]void SetHwndPropStr([System.Runtime.InteropServices.ComAliasNameAttribute("Accessibility.wireHWND")][System.Runtime.InteropServices.In]ref Accessibility._RemotableHandle hwnd, [System.Runtime.InteropServices.In]uint idObject, [System.Runtime.InteropServices.In]uint idChild, [System.Runtime.InteropServices.In]System.Guid idProp, [System.Runtime.InteropServices.In][System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.LPWStr)]string str);
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]void SetPropServer([System.Runtime.InteropServices.In]ref byte pIDString, [System.Runtime.InteropServices.In]uint dwIDStringLen, [System.Runtime.InteropServices.In]ref System.Guid paProps, [System.Runtime.InteropServices.In]int cProps, [System.Runtime.InteropServices.In][System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.Interface)]Accessibility.IAccPropServer pServer, [System.Runtime.InteropServices.In]Accessibility.AnnoScope AnnoScope);
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]void SetPropValue([System.Runtime.InteropServices.In]ref byte pIDString, [System.Runtime.InteropServices.In]uint dwIDStringLen, [System.Runtime.InteropServices.In]System.Guid idProp, [System.Runtime.InteropServices.In][System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.Struct)]object var);
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential, Pack=4)]
    public partial struct _RemotableHandle
    {
        public int fContext;
        public Accessibility.__MIDL_IWinTypes_0009 u;
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Explicit, Size=4, Pack=4)]
    public partial struct __MIDL_IWinTypes_0009
    {
        [System.Runtime.InteropServices.FieldOffsetAttribute(0)]
        public int hInproc;
        [System.Runtime.InteropServices.FieldOffsetAttribute(0)]
        public int hRemote;
    }
}
