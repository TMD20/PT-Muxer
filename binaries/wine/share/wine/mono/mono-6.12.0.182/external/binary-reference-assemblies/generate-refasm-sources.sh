#!/bin/bash -e

REPODIR=$( cd "$(dirname "${BASH_SOURCE[0]}")" && pwd )
NETFXPROFILE=$1
NETFXSOURCE=$( cd "$2" && pwd )

if [ "x$NETFXPROFILE" = "x" ]; then echo "No profile specified."; exit 1; fi
if [ ! -d "$NETFXSOURCE" ]; then echo "Reference assemblies folder doesn't exist."; exit 1; fi

rm -f "$REPODIR/src/$NETFXPROFILE"/*.cs
rm -f "$REPODIR/src/$NETFXPROFILE/Facades"/*.cs

cd "$NETFXSOURCE"
for i in *.dll Facades/*.dll; do
    if [ "$i" = "System.EnterpriseServices.Thunk.dll" ] || [ "$i" = "System.EnterpriseServices.Wrapper.dll" ]; then continue; fi;

    outpath="$REPODIR/src/$NETFXPROFILE"
    if [[ "$i" = "Facades"* ]]; then outpath="$outpath/Facades"; fi

    echo "Processing $i"
    mono "$REPODIR/../api-snapshot/tools/genapi/Microsoft.DotNet.GenAPI.exe" -assembly:"$i" -out:"$outpath" -typeforwardedTo -assemblyVersion -assemblyAttributes -headerFile:"$REPODIR/../api-snapshot/profiles/license-header.txt" -libPath:"$NETFXSOURCE"
done

cd "$REPODIR/src/$NETFXPROFILE"
for i in *.cs Facades/*.cs; do sed -i'' -e 's/AssemblyCompanyAttribute("Microsoft Corporation")/AssemblyCompanyAttribute("Mono development team")/g' "$i"; done
for i in *.cs Facades/*.cs; do sed -i'' -e 's/AssemblyCopyrightAttribute("© Microsoft Corporation.  All rights reserved.")/AssemblyCopyrightAttribute("(c) Various Mono authors")/g' "$i"; done
for i in *.cs Facades/*.cs; do sed -i'' -e 's/AssemblyProductAttribute("Microsoft® .NET Framework")/AssemblyProductAttribute("Mono Common Language Infrastructure")/g' "$i"; done
for i in *.cs Facades/*.cs; do sed -i'' -e '/.*AssemblySignatureKeyAttribute(.*]/d' "$i"; done
for i in *.cs Facades/*.cs; do sed -i'' -e '/.*InternalsVisibleToAttribute(.*]/d' "$i"; done
for i in *.cs Facades/*.cs; do sed -i'' -e '/.*DependencyAttribute(.*]/d' "$i"; done

# remove assembly that we don't have in Mono
rm ISymWrapper.cs Microsoft.Activities.Build.cs Microsoft.Build.Conversion.v4.0.cs Microsoft.JScript.cs Microsoft.VisualBasic.Compatibility.cs Microsoft.VisualBasic.Compatibility.Data.cs Microsoft.VisualC.STLCLR.cs PresentationBuildTasks.cs PresentationCore.cs PresentationFramework.Aero.cs PresentationFramework.Aero2.cs PresentationFramework.AeroLite.cs PresentationFramework.Classic.cs PresentationFramework.cs PresentationFramework.Luna.cs PresentationFramework.Royale.cs ReachFramework.cs sysglobl.cs System.Activities.Core.Presentation.cs System.Activities.cs System.Activities.DurableInstancing.cs System.Activities.Presentation.cs System.AddIn.Contract.cs System.AddIn.cs System.ComponentModel.Composition.Registration.cs System.Data.Entity.Design.cs System.Data.Services.Design.cs System.Data.SqlXml.cs System.Device.cs System.DirectoryServices.AccountManagement.cs System.IdentityModel.Services.cs System.IO.Log.cs System.Management.Instrumentation.cs System.Printing.cs System.ServiceModel.Activities.cs System.ServiceModel.Channels.cs System.Speech.cs System.Web.DataVisualization.cs System.Web.DataVisualization.Design.cs System.Web.DynamicData.Design.cs System.Web.Entity.cs System.Web.Entity.Design.cs System.Windows.Controls.Ribbon.cs System.Windows.Forms.DataVisualization.Design.cs System.Windows.Input.Manipulations.cs System.Windows.Presentation.cs System.WorkflowServices.cs UIAutomationClient.cs UIAutomationClientsideProviders.cs UIAutomationProvider.cs UIAutomationTypes.cs WindowsFormsIntegration.cs XamlBuildTask.cs
