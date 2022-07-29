// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

[assembly:System.Reflection.AssemblyVersionAttribute("3.5.0.0")]
[assembly:System.CLSCompliantAttribute(true)]
[assembly:System.Diagnostics.DebuggableAttribute((System.Diagnostics.DebuggableAttribute.DebuggingModes)(2))]
[assembly:System.Reflection.AssemblyCompanyAttribute("Mono development team")]
[assembly:System.Reflection.AssemblyCopyrightAttribute("(c) Various Mono authors")]
[assembly:System.Reflection.AssemblyDefaultAliasAttribute("System.ComponentModel.DataAnnotations.dll")]
[assembly:System.Reflection.AssemblyDescriptionAttribute("System.ComponentModel.DataAnnotations.dll")]
[assembly:System.Reflection.AssemblyFileVersionAttribute("3.5.21022.8")]
[assembly:System.Reflection.AssemblyInformationalVersionAttribute("3.5.21022.8")]
[assembly:System.Reflection.AssemblyProductAttribute("Mono Common Language Infrastructure")]
[assembly:System.Reflection.AssemblyTitleAttribute("System.ComponentModel.DataAnnotations.dll")]
[assembly:System.Resources.NeutralResourcesLanguageAttribute("en-US")]
[assembly:System.Resources.SatelliteContractVersionAttribute("3.5.0.0")]
[assembly:System.Runtime.CompilerServices.RuntimeCompatibilityAttribute(WrapNonExceptionThrows=true)]
[assembly:System.Runtime.InteropServices.ComVisibleAttribute(false)]
[assembly:System.Security.AllowPartiallyTrustedCallersAttribute]
namespace System
{
    [System.AttributeUsageAttribute((System.AttributeTargets)(32767), AllowMultiple=true)]
    internal partial class MonoDocumentationNoteAttribute : System.MonoTODOAttribute
    {
        public MonoDocumentationNoteAttribute(string comment) { }
    }
    [System.AttributeUsageAttribute((System.AttributeTargets)(32767), AllowMultiple=true)]
    internal partial class MonoExtensionAttribute : System.MonoTODOAttribute
    {
        public MonoExtensionAttribute(string comment) { }
    }
    [System.AttributeUsageAttribute((System.AttributeTargets)(32767), AllowMultiple=true)]
    internal partial class MonoInternalNoteAttribute : System.MonoTODOAttribute
    {
        public MonoInternalNoteAttribute(string comment) { }
    }
    [System.AttributeUsageAttribute((System.AttributeTargets)(32767), AllowMultiple=true)]
    internal partial class MonoLimitationAttribute : System.MonoTODOAttribute
    {
        public MonoLimitationAttribute(string comment) { }
    }
    [System.AttributeUsageAttribute((System.AttributeTargets)(32767), AllowMultiple=true)]
    internal partial class MonoNotSupportedAttribute : System.MonoTODOAttribute
    {
        public MonoNotSupportedAttribute(string comment) { }
    }
    [System.AttributeUsageAttribute((System.AttributeTargets)(32767), AllowMultiple=true)]
    internal partial class MonoTODOAttribute : System.Attribute
    {
        public MonoTODOAttribute() { }
        public MonoTODOAttribute(string comment) { }
        public string Comment { get { throw null; } }
    }
}
namespace System.ComponentModel.DataAnnotations
{
    public partial class AssociatedMetadataTypeTypeDescriptionProvider : System.ComponentModel.TypeDescriptionProvider
    {
        public AssociatedMetadataTypeTypeDescriptionProvider(System.Type type) { }
        public AssociatedMetadataTypeTypeDescriptionProvider(System.Type type, System.Type associatedMetadataType) { }
        public override System.ComponentModel.ICustomTypeDescriptor GetTypeDescriptor(System.Type objectType, object instance) { throw null; }
    }
    public enum DataType
    {
        Currency = 6,
        Custom = 0,
        Date = 2,
        DateTime = 1,
        Duration = 4,
        EmailAddress = 10,
        Html = 8,
        MultilineText = 9,
        Password = 11,
        PhoneNumber = 5,
        Text = 7,
        Time = 3,
        Url = 12,
    }
    [System.AttributeUsageAttribute((System.AttributeTargets)(384), AllowMultiple=false)]
    public partial class DataTypeAttribute : System.ComponentModel.DataAnnotations.ValidationAttribute
    {
        public DataTypeAttribute(System.ComponentModel.DataAnnotations.DataType dataType) { }
        public DataTypeAttribute(string customDataType) { }
        public string CustomDataType { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        public System.ComponentModel.DataAnnotations.DataType DataType { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        public System.ComponentModel.DataAnnotations.DisplayFormatAttribute DisplayFormat { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]protected set { } }
        public virtual string GetDataTypeName() { throw null; }
        public override bool IsValid(object value) { throw null; }
    }
    [System.AttributeUsageAttribute((System.AttributeTargets)(4), Inherited=true, AllowMultiple=false)]
    public partial class DisplayColumnAttribute : System.Attribute
    {
        public DisplayColumnAttribute(string displayColumn) { }
        public DisplayColumnAttribute(string displayColumn, string sortColumn) { }
        public DisplayColumnAttribute(string displayColumn, string sortColumn, bool sortDescending) { }
        public string DisplayColumn { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        public string SortColumn { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        public bool SortDescending { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
    }
    [System.AttributeUsageAttribute((System.AttributeTargets)(384), AllowMultiple=false)]
    public partial class DisplayFormatAttribute : System.Attribute
    {
        public DisplayFormatAttribute() { }
        public bool ApplyFormatInEditMode { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public bool ConvertEmptyStringToNull { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public string DataFormatString { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public string NullDisplayText { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    }
    [System.AttributeUsageAttribute((System.AttributeTargets)(4), AllowMultiple=false)]
    public sealed partial class MetadataTypeAttribute : System.Attribute
    {
        public MetadataTypeAttribute(System.Type metadataClassType) { }
        public System.Type MetadataClassType { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
    }
    [System.AttributeUsageAttribute((System.AttributeTargets)(384), AllowMultiple=false)]
    public partial class RangeAttribute : System.ComponentModel.DataAnnotations.ValidationAttribute
    {
        public RangeAttribute(double minimum, double maximum) { }
        public RangeAttribute(int minimum, int maximum) { }
        public RangeAttribute(System.Type type, string minimum, string maximum) { }
        public object Maximum { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        public object Minimum { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        public System.Type OperandType { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        public override string FormatErrorMessage(string name) { throw null; }
        public override bool IsValid(object value) { throw null; }
    }
    [System.AttributeUsageAttribute((System.AttributeTargets)(384), AllowMultiple=false)]
    public partial class RegularExpressionAttribute : System.ComponentModel.DataAnnotations.ValidationAttribute
    {
        public RegularExpressionAttribute(string pattern) { }
        public string Pattern { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        public override string FormatErrorMessage(string name) { throw null; }
        public override bool IsValid(object value) { throw null; }
    }
    [System.AttributeUsageAttribute((System.AttributeTargets)(384), AllowMultiple=false)]
    public partial class RequiredAttribute : System.ComponentModel.DataAnnotations.ValidationAttribute
    {
        public RequiredAttribute() { }
        public override bool IsValid(object value) { throw null; }
    }
    [System.AttributeUsageAttribute((System.AttributeTargets)(384), AllowMultiple=false)]
    public partial class ScaffoldColumnAttribute : System.Attribute
    {
        public ScaffoldColumnAttribute(bool scaffold) { }
        [System.MonoTODOAttribute]
        public bool Scaffold { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
    }
    [System.AttributeUsageAttribute((System.AttributeTargets)(4), AllowMultiple=false)]
    public partial class ScaffoldTableAttribute : System.Attribute
    {
        public ScaffoldTableAttribute(bool scaffold) { }
        [System.MonoTODOAttribute]
        public bool Scaffold { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
    }
    [System.AttributeUsageAttribute((System.AttributeTargets)(384), AllowMultiple=false)]
    public partial class StringLengthAttribute : System.ComponentModel.DataAnnotations.ValidationAttribute
    {
        public StringLengthAttribute(int maximumLength) { }
        public int MaximumLength { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        public override string FormatErrorMessage(string name) { throw null; }
        public override bool IsValid(object value) { throw null; }
    }
    [System.AttributeUsageAttribute((System.AttributeTargets)(384), AllowMultiple=true)]
    public partial class UIHintAttribute : System.Attribute
    {
        public UIHintAttribute(string uiHint) { }
        public UIHintAttribute(string uiHint, string presentationLayer) { }
        public UIHintAttribute(string uiHint, string presentationLayer, params object[] controlParameters) { }
        public System.Collections.Generic.IDictionary<string, object> ControlParameters { get { throw null; } }
        public string PresentationLayer { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        public string UIHint { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        public override bool Equals(object obj) { throw null; }
        public override int GetHashCode() { throw null; }
    }
    public abstract partial class ValidationAttribute : System.Attribute
    {
        protected ValidationAttribute() { }
        protected ValidationAttribute(System.Func<string> errorMessageAccessor) { }
        protected ValidationAttribute(string errorMessage) { }
        public string ErrorMessage { get { throw null; } set { } }
        public string ErrorMessageResourceName { get { throw null; } set { } }
        public System.Type ErrorMessageResourceType { get { throw null; } set { } }
        protected string ErrorMessageString { get { throw null; } }
        public virtual string FormatErrorMessage(string name) { throw null; }
        public abstract bool IsValid(object value);
        public void Validate(object value, string name) { }
    }
    [System.SerializableAttribute]
    public partial class ValidationException : System.Exception
    {
        public ValidationException() { }
        protected ValidationException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
        public ValidationException(string message) { }
        public ValidationException(string errorMessage, System.ComponentModel.DataAnnotations.ValidationAttribute validatingAttribute, object value) { }
        public ValidationException(string message, System.Exception innerException) { }
        public System.ComponentModel.DataAnnotations.ValidationAttribute ValidationAttribute { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        public object Value { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        [System.Security.Permissions.SecurityPermissionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Flags=(System.Security.Permissions.SecurityPermissionFlag)(128))]
        public override void GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
    }
}
