// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

[assembly:System.Reflection.AssemblyVersionAttribute("2.0.0.0")]
[assembly:System.CLSCompliantAttribute(true)]
[assembly:System.Diagnostics.DebuggableAttribute((System.Diagnostics.DebuggableAttribute.DebuggingModes)(2))]
[assembly:System.Reflection.AssemblyCompanyAttribute("Mono development team")]
[assembly:System.Reflection.AssemblyCopyrightAttribute("(c) Various Mono authors")]
[assembly:System.Reflection.AssemblyDefaultAliasAttribute("Accessibility.dll")]
[assembly:System.Reflection.AssemblyDescriptionAttribute("Accessibility.dll")]
[assembly:System.Reflection.AssemblyFileVersionAttribute("2.0.50727.1433")]
[assembly:System.Reflection.AssemblyInformationalVersionAttribute("2.0.50727.1433")]
[assembly:System.Reflection.AssemblyProductAttribute("Mono Common Language Infrastructure")]
[assembly:System.Reflection.AssemblyTitleAttribute("Accessibility.dll")]
[assembly:System.Resources.NeutralResourcesLanguageAttribute("en-US")]
[assembly:System.Resources.SatelliteContractVersionAttribute("2.0.0.0")]
[assembly:System.Runtime.CompilerServices.CompilationRelaxationsAttribute((System.Runtime.CompilerServices.CompilationRelaxations)(8))]
[assembly:System.Runtime.CompilerServices.RuntimeCompatibilityAttribute(WrapNonExceptionThrows=true)]
[assembly:System.Runtime.InteropServices.ComVisibleAttribute(true)]
[assembly:System.Runtime.InteropServices.GuidAttribute("1ea4dbf0-3c3b-11cf-810c-00aa00389b71")]
[assembly:System.Runtime.InteropServices.ImportedFromTypeLibAttribute("Accessibility")]
[assembly:System.Runtime.InteropServices.TypeLibVersionAttribute(1, 1)]
[assembly:System.Security.AllowPartiallyTrustedCallersAttribute]
namespace Accessibility
{
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
}
