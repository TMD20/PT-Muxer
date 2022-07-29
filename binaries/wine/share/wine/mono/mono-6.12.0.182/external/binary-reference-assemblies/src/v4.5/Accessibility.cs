// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

[assembly:System.Reflection.AssemblyVersionAttribute("4.0.0.0")]
[assembly:System.CLSCompliantAttribute(true)]
[assembly:System.Diagnostics.DebuggableAttribute((System.Diagnostics.DebuggableAttribute.DebuggingModes)(258))]
[assembly:System.Reflection.AssemblyCompanyAttribute("Mono development team")]
[assembly:System.Reflection.AssemblyCopyrightAttribute("(c) Various Mono authors")]
[assembly:System.Reflection.AssemblyDefaultAliasAttribute("Accessibility.dll")]
[assembly:System.Reflection.AssemblyDescriptionAttribute("Accessibility.dll")]
[assembly:System.Reflection.AssemblyFileVersionAttribute("4.0.30319.17020")]
[assembly:System.Reflection.AssemblyInformationalVersionAttribute("4.0.30319.17020")]
[assembly:System.Reflection.AssemblyProductAttribute("Mono Common Language Infrastructure")]
[assembly:System.Reflection.AssemblyTitleAttribute("Accessibility.dll")]
[assembly:System.Resources.NeutralResourcesLanguageAttribute("en-US")]
[assembly:System.Resources.SatelliteContractVersionAttribute("4.0.0.0")]
[assembly:System.Runtime.CompilerServices.CompilationRelaxationsAttribute((System.Runtime.CompilerServices.CompilationRelaxations)(8))]
[assembly:System.Runtime.CompilerServices.ReferenceAssemblyAttribute]
[assembly:System.Runtime.CompilerServices.RuntimeCompatibilityAttribute(WrapNonExceptionThrows=true)]
[assembly:System.Runtime.InteropServices.ComVisibleAttribute(true)]
[assembly:System.Runtime.InteropServices.GuidAttribute("1ea4dbf0-3c3b-11cf-810c-00aa00389b71")]
[assembly:System.Runtime.InteropServices.ImportedFromTypeLibAttribute("Accessibility")]
[assembly:System.Runtime.InteropServices.TypeLibVersionAttribute(1, 1)]
[assembly:System.Security.AllowPartiallyTrustedCallersAttribute]
namespace Accessibility
{
    public enum AnnoScope
    {
        ANNO_CONTAINER = 1,
        ANNO_THIS = 0,
    }
    public partial interface CAccPropServices : Accessibility.IAccPropServices
    {
    }
    public partial class CAccPropServicesClass : Accessibility.CAccPropServices, Accessibility.IAccPropServices
    {
        public CAccPropServicesClass() { }
        public virtual void ClearHmenuProps([System.Runtime.InteropServices.In]ref Accessibility._RemotableHandle hmenu, [System.Runtime.InteropServices.In]uint idChild, [System.Runtime.InteropServices.In]ref System.Guid paProps, [System.Runtime.InteropServices.In]int cProps) { }
        public virtual void ClearHwndProps([System.Runtime.InteropServices.In]ref Accessibility._RemotableHandle hwnd, [System.Runtime.InteropServices.In]uint idObject, [System.Runtime.InteropServices.In]uint idChild, [System.Runtime.InteropServices.In]ref System.Guid paProps, [System.Runtime.InteropServices.In]int cProps) { }
        public virtual void ClearProps([System.Runtime.InteropServices.In]ref byte pIDString, [System.Runtime.InteropServices.In]uint dwIDStringLen, [System.Runtime.InteropServices.In]ref System.Guid paProps, [System.Runtime.InteropServices.In]int cProps) { }
        public virtual void ComposeHmenuIdentityString([System.Runtime.InteropServices.In]ref Accessibility._RemotableHandle hmenu, [System.Runtime.InteropServices.In]uint idChild, [System.Runtime.InteropServices.Out]System.IntPtr ppIDString, out uint pdwIDStringLen) { ppIDString = default(System.IntPtr); pdwIDStringLen = default(uint); }
        public virtual void ComposeHwndIdentityString([System.Runtime.InteropServices.In]ref Accessibility._RemotableHandle hwnd, [System.Runtime.InteropServices.In]uint idObject, [System.Runtime.InteropServices.In]uint idChild, [System.Runtime.InteropServices.Out]System.IntPtr ppIDString, out uint pdwIDStringLen) { ppIDString = default(System.IntPtr); pdwIDStringLen = default(uint); }
        public virtual void DecomposeHmenuIdentityString([System.Runtime.InteropServices.In]ref byte pIDString, [System.Runtime.InteropServices.In]uint dwIDStringLen, [System.Runtime.InteropServices.Out]System.IntPtr phmenu, out uint pidChild) { phmenu = default(System.IntPtr); pidChild = default(uint); }
        public virtual void DecomposeHwndIdentityString([System.Runtime.InteropServices.In]ref byte pIDString, [System.Runtime.InteropServices.In]uint dwIDStringLen, [System.Runtime.InteropServices.Out]System.IntPtr phwnd, out uint pidObject, out uint pidChild) { phwnd = default(System.IntPtr); pidObject = default(uint); pidChild = default(uint); }
        public virtual void SetHmenuProp([System.Runtime.InteropServices.In]ref Accessibility._RemotableHandle hmenu, [System.Runtime.InteropServices.In]uint idChild, [System.Runtime.InteropServices.In]System.Guid idProp, [System.Runtime.InteropServices.In][System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.Struct)]object var) { }
        public virtual void SetHmenuPropServer([System.Runtime.InteropServices.In]ref Accessibility._RemotableHandle hmenu, [System.Runtime.InteropServices.In]uint idChild, [System.Runtime.InteropServices.In]ref System.Guid paProps, [System.Runtime.InteropServices.In]int cProps, [System.Runtime.InteropServices.In][System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.Interface)]Accessibility.IAccPropServer pServer, [System.Runtime.InteropServices.In]Accessibility.AnnoScope AnnoScope) { }
        public virtual void SetHmenuPropStr([System.Runtime.InteropServices.In]ref Accessibility._RemotableHandle hmenu, [System.Runtime.InteropServices.In]uint idChild, [System.Runtime.InteropServices.In]System.Guid idProp, [System.Runtime.InteropServices.In][System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.LPWStr)]string str) { }
        public virtual void SetHwndProp([System.Runtime.InteropServices.In]ref Accessibility._RemotableHandle hwnd, [System.Runtime.InteropServices.In]uint idObject, [System.Runtime.InteropServices.In]uint idChild, [System.Runtime.InteropServices.In]System.Guid idProp, [System.Runtime.InteropServices.In][System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.Struct)]object var) { }
        public virtual void SetHwndPropServer([System.Runtime.InteropServices.In]ref Accessibility._RemotableHandle hwnd, [System.Runtime.InteropServices.In]uint idObject, [System.Runtime.InteropServices.In]uint idChild, [System.Runtime.InteropServices.In]ref System.Guid paProps, [System.Runtime.InteropServices.In]int cProps, [System.Runtime.InteropServices.In][System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.Interface)]Accessibility.IAccPropServer pServer, [System.Runtime.InteropServices.In]Accessibility.AnnoScope AnnoScope) { }
        public virtual void SetHwndPropStr([System.Runtime.InteropServices.In]ref Accessibility._RemotableHandle hwnd, [System.Runtime.InteropServices.In]uint idObject, [System.Runtime.InteropServices.In]uint idChild, [System.Runtime.InteropServices.In]System.Guid idProp, [System.Runtime.InteropServices.In][System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.LPWStr)]string str) { }
        public virtual void SetPropServer([System.Runtime.InteropServices.In]ref byte pIDString, [System.Runtime.InteropServices.In]uint dwIDStringLen, [System.Runtime.InteropServices.In]ref System.Guid paProps, [System.Runtime.InteropServices.In]int cProps, [System.Runtime.InteropServices.In][System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.Interface)]Accessibility.IAccPropServer pServer, [System.Runtime.InteropServices.In]Accessibility.AnnoScope AnnoScope) { }
        public virtual void SetPropValue([System.Runtime.InteropServices.In]ref byte pIDString, [System.Runtime.InteropServices.In]uint dwIDStringLen, [System.Runtime.InteropServices.In]System.Guid idProp, [System.Runtime.InteropServices.In][System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.Struct)]object var) { }
    }
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
    public partial interface IAccessibleHandler
    {
        void AccessibleObjectFromID([System.Runtime.InteropServices.In]int hwnd, [System.Runtime.InteropServices.In]int lObjectID, [System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.Interface)]out Accessibility.IAccessible pIAccessible);
    }
    public partial interface IAccIdentity
    {
        void GetIdentityString([System.Runtime.InteropServices.In]uint dwIDChild, [System.Runtime.InteropServices.Out]System.IntPtr ppIDString, out uint pdwIDStringLen);
    }
    public partial interface IAccPropServer
    {
        void GetPropValue([System.Runtime.InteropServices.In]ref byte pIDString, [System.Runtime.InteropServices.In]uint dwIDStringLen, [System.Runtime.InteropServices.In]System.Guid idProp, [System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.Struct)]out object pvarValue, out int pfHasProp);
    }
    public partial interface IAccPropServices
    {
        void ClearHmenuProps([System.Runtime.InteropServices.In]ref Accessibility._RemotableHandle hmenu, [System.Runtime.InteropServices.In]uint idChild, [System.Runtime.InteropServices.In]ref System.Guid paProps, [System.Runtime.InteropServices.In]int cProps);
        void ClearHwndProps([System.Runtime.InteropServices.In]ref Accessibility._RemotableHandle hwnd, [System.Runtime.InteropServices.In]uint idObject, [System.Runtime.InteropServices.In]uint idChild, [System.Runtime.InteropServices.In]ref System.Guid paProps, [System.Runtime.InteropServices.In]int cProps);
        void ClearProps([System.Runtime.InteropServices.In]ref byte pIDString, [System.Runtime.InteropServices.In]uint dwIDStringLen, [System.Runtime.InteropServices.In]ref System.Guid paProps, [System.Runtime.InteropServices.In]int cProps);
        void ComposeHmenuIdentityString([System.Runtime.InteropServices.In]ref Accessibility._RemotableHandle hmenu, [System.Runtime.InteropServices.In]uint idChild, [System.Runtime.InteropServices.Out]System.IntPtr ppIDString, out uint pdwIDStringLen);
        void ComposeHwndIdentityString([System.Runtime.InteropServices.In]ref Accessibility._RemotableHandle hwnd, [System.Runtime.InteropServices.In]uint idObject, [System.Runtime.InteropServices.In]uint idChild, [System.Runtime.InteropServices.Out]System.IntPtr ppIDString, out uint pdwIDStringLen);
        void DecomposeHmenuIdentityString([System.Runtime.InteropServices.In]ref byte pIDString, [System.Runtime.InteropServices.In]uint dwIDStringLen, [System.Runtime.InteropServices.Out]System.IntPtr phmenu, out uint pidChild);
        void DecomposeHwndIdentityString([System.Runtime.InteropServices.In]ref byte pIDString, [System.Runtime.InteropServices.In]uint dwIDStringLen, [System.Runtime.InteropServices.Out]System.IntPtr phwnd, out uint pidObject, out uint pidChild);
        void SetHmenuProp([System.Runtime.InteropServices.In]ref Accessibility._RemotableHandle hmenu, [System.Runtime.InteropServices.In]uint idChild, [System.Runtime.InteropServices.In]System.Guid idProp, [System.Runtime.InteropServices.In][System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.Struct)]object var);
        void SetHmenuPropServer([System.Runtime.InteropServices.In]ref Accessibility._RemotableHandle hmenu, [System.Runtime.InteropServices.In]uint idChild, [System.Runtime.InteropServices.In]ref System.Guid paProps, [System.Runtime.InteropServices.In]int cProps, [System.Runtime.InteropServices.In][System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.Interface)]Accessibility.IAccPropServer pServer, [System.Runtime.InteropServices.In]Accessibility.AnnoScope AnnoScope);
        void SetHmenuPropStr([System.Runtime.InteropServices.In]ref Accessibility._RemotableHandle hmenu, [System.Runtime.InteropServices.In]uint idChild, [System.Runtime.InteropServices.In]System.Guid idProp, [System.Runtime.InteropServices.In][System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.LPWStr)]string str);
        void SetHwndProp([System.Runtime.InteropServices.In]ref Accessibility._RemotableHandle hwnd, [System.Runtime.InteropServices.In]uint idObject, [System.Runtime.InteropServices.In]uint idChild, [System.Runtime.InteropServices.In]System.Guid idProp, [System.Runtime.InteropServices.In][System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.Struct)]object var);
        void SetHwndPropServer([System.Runtime.InteropServices.In]ref Accessibility._RemotableHandle hwnd, [System.Runtime.InteropServices.In]uint idObject, [System.Runtime.InteropServices.In]uint idChild, [System.Runtime.InteropServices.In]ref System.Guid paProps, [System.Runtime.InteropServices.In]int cProps, [System.Runtime.InteropServices.In][System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.Interface)]Accessibility.IAccPropServer pServer, [System.Runtime.InteropServices.In]Accessibility.AnnoScope AnnoScope);
        void SetHwndPropStr([System.Runtime.InteropServices.In]ref Accessibility._RemotableHandle hwnd, [System.Runtime.InteropServices.In]uint idObject, [System.Runtime.InteropServices.In]uint idChild, [System.Runtime.InteropServices.In]System.Guid idProp, [System.Runtime.InteropServices.In][System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.LPWStr)]string str);
        void SetPropServer([System.Runtime.InteropServices.In]ref byte pIDString, [System.Runtime.InteropServices.In]uint dwIDStringLen, [System.Runtime.InteropServices.In]ref System.Guid paProps, [System.Runtime.InteropServices.In]int cProps, [System.Runtime.InteropServices.In][System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.Interface)]Accessibility.IAccPropServer pServer, [System.Runtime.InteropServices.In]Accessibility.AnnoScope AnnoScope);
        void SetPropValue([System.Runtime.InteropServices.In]ref byte pIDString, [System.Runtime.InteropServices.In]uint dwIDStringLen, [System.Runtime.InteropServices.In]System.Guid idProp, [System.Runtime.InteropServices.In][System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.Struct)]object var);
    }
    public partial struct _RemotableHandle
    {
        public int fContext;
        public Accessibility.__MIDL_IWinTypes_0009 u;
    }
    public partial struct __MIDL_IWinTypes_0009
    {
        public int hInproc;
        public int hRemote;
    }
}
