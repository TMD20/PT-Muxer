// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

[assembly:System.Reflection.AssemblyVersionAttribute("4.0.0.0")]
[assembly:System.CLSCompliantAttribute(true)]
[assembly:System.Diagnostics.DebuggableAttribute((System.Diagnostics.DebuggableAttribute.DebuggingModes)(2))]
[assembly:System.Reflection.AssemblyCompanyAttribute("Mono development team")]
[assembly:System.Reflection.AssemblyCopyrightAttribute("(c) Various Mono authors")]
[assembly:System.Reflection.AssemblyDefaultAliasAttribute("System.Reflection.Context.dll")]
[assembly:System.Reflection.AssemblyDescriptionAttribute("System.Reflection.Context.dll")]
[assembly:System.Reflection.AssemblyFileVersionAttribute("4.7.2558.0")]
[assembly:System.Reflection.AssemblyInformationalVersionAttribute("4.7.2558.0")]
[assembly:System.Reflection.AssemblyProductAttribute("Mono Common Language Infrastructure")]
[assembly:System.Reflection.AssemblyTitleAttribute("System.Reflection.Context.dll")]
[assembly:System.Resources.NeutralResourcesLanguageAttribute("en-US")]
[assembly:System.Resources.SatelliteContractVersionAttribute("4.0.0.0")]
[assembly:System.Runtime.CompilerServices.CompilationRelaxationsAttribute(8)]
[assembly:System.Runtime.CompilerServices.ReferenceAssemblyAttribute]
[assembly:System.Runtime.CompilerServices.RuntimeCompatibilityAttribute(WrapNonExceptionThrows=true)]
[assembly:System.Runtime.InteropServices.ComVisibleAttribute(false)]
[assembly:System.Runtime.InteropServices.DefaultDllImportSearchPathsAttribute((System.Runtime.InteropServices.DllImportSearchPath)(2050))]
[assembly:System.Security.SecurityRulesAttribute((System.Security.SecurityRuleSet)(2), SkipVerificationInFullTrust=true)]
[assembly:System.Security.SecurityTransparentAttribute]
namespace System.Reflection.Context
{
    public abstract partial class CustomReflectionContext : System.Reflection.ReflectionContext
    {
        protected CustomReflectionContext() { }
        protected CustomReflectionContext(System.Reflection.ReflectionContext source) { }
        protected virtual System.Collections.Generic.IEnumerable<System.Reflection.PropertyInfo> AddProperties(System.Type type) { throw null; }
        protected System.Reflection.PropertyInfo CreateProperty(System.Type propertyType, string name, System.Func<object, object> getter, System.Action<object, object> setter) { throw null; }
        protected System.Reflection.PropertyInfo CreateProperty(System.Type propertyType, string name, System.Func<object, object> getter, System.Action<object, object> setter, System.Collections.Generic.IEnumerable<System.Attribute> propertyCustomAttributes, System.Collections.Generic.IEnumerable<System.Attribute> getterCustomAttributes, System.Collections.Generic.IEnumerable<System.Attribute> setterCustomAttributes) { throw null; }
        protected virtual System.Collections.Generic.IEnumerable<object> GetCustomAttributes(System.Reflection.MemberInfo member, System.Collections.Generic.IEnumerable<object> declaredAttributes) { throw null; }
        protected virtual System.Collections.Generic.IEnumerable<object> GetCustomAttributes(System.Reflection.ParameterInfo parameter, System.Collections.Generic.IEnumerable<object> declaredAttributes) { throw null; }
        public override System.Reflection.Assembly MapAssembly(System.Reflection.Assembly assembly) { throw null; }
        public override System.Reflection.TypeInfo MapType(System.Reflection.TypeInfo type) { throw null; }
    }
}
