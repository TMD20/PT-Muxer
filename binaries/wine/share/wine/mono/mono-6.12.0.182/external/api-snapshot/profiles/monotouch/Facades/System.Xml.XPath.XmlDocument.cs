// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

[assembly:System.Reflection.AssemblyVersionAttribute("4.0.2.0")]
[assembly:System.Diagnostics.DebuggableAttribute(System.Diagnostics.DebuggableAttribute.DebuggingModes.IgnoreSymbolStoreSequencePoints)]
[assembly:System.Reflection.AssemblyCompanyAttribute("Mono development team")]
[assembly:System.Reflection.AssemblyCopyrightAttribute("(c) Various Mono authors")]
[assembly:System.Reflection.AssemblyDefaultAliasAttribute("System.Xml.XPath.XmlDocument")]
[assembly:System.Reflection.AssemblyDescriptionAttribute("System.Xml.XPath.XmlDocument")]
[assembly:System.Reflection.AssemblyFileVersionAttribute("4.0.0.0")]
[assembly:System.Reflection.AssemblyInformationalVersionAttribute("4.0.0.0")]
[assembly:System.Reflection.AssemblyProductAttribute("Mono Common Language Infrastructure")]
[assembly:System.Reflection.AssemblyTitleAttribute("System.Xml.XPath.XmlDocument")]
[assembly:System.Runtime.CompilerServices.CompilationRelaxationsAttribute(8)]
[assembly:System.Runtime.CompilerServices.RuntimeCompatibilityAttribute(WrapNonExceptionThrows=true)]
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
namespace System.Xml
{
    public static partial class XmlDocumentXPathExtensions
    {
        [System.MonoTODOAttribute]
        public static System.Xml.XPath.XPathNavigator CreateNavigator(this System.Xml.XmlDocument document) { throw null; }
        [System.MonoTODOAttribute]
        public static System.Xml.XPath.XPathNavigator CreateNavigator(this System.Xml.XmlDocument document, System.Xml.XmlNode node) { throw null; }
        [System.MonoTODOAttribute]
        public static System.Xml.XPath.XPathNavigator CreateNavigator(this System.Xml.XmlNode node) { throw null; }
        [System.MonoTODOAttribute]
        public static System.Xml.XmlNodeList SelectNodes(this System.Xml.XmlNode node, string xpath) { throw null; }
        [System.MonoTODOAttribute]
        public static System.Xml.XmlNodeList SelectNodes(this System.Xml.XmlNode node, string xpath, System.Xml.XmlNamespaceManager nsmgr) { throw null; }
        [System.MonoTODOAttribute]
        public static System.Xml.XmlNode SelectSingleNode(this System.Xml.XmlNode node, string xpath) { throw null; }
        [System.MonoTODOAttribute]
        public static System.Xml.XmlNode SelectSingleNode(this System.Xml.XmlNode node, string xpath, System.Xml.XmlNamespaceManager nsmgr) { throw null; }
        [System.MonoTODOAttribute]
        public static System.Xml.XPath.IXPathNavigable ToXPathNavigable(this System.Xml.XmlNode node) { throw null; }
    }
}
