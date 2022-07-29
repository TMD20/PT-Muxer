// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

[assembly:System.Reflection.AssemblyVersionAttribute("4.0.0.0")]
[assembly:System.CLSCompliantAttribute(true)]
[assembly:System.Reflection.AssemblyCompanyAttribute("Mono development team")]
[assembly:System.Reflection.AssemblyCopyrightAttribute("(c) Various Mono authors")]
[assembly:System.Reflection.AssemblyDefaultAliasAttribute("System.ComponentModel.DataAnnotations.dll")]
[assembly:System.Reflection.AssemblyDescriptionAttribute("System.ComponentModel.DataAnnotations.dll")]
[assembly:System.Reflection.AssemblyFileVersionAttribute("4.0.30319.1")]
[assembly:System.Reflection.AssemblyInformationalVersionAttribute("4.0.30319.1")]
[assembly:System.Reflection.AssemblyProductAttribute("Mono Common Language Infrastructure")]
[assembly:System.Reflection.AssemblyTitleAttribute("System.ComponentModel.DataAnnotations.dll")]
[assembly:System.Resources.NeutralResourcesLanguageAttribute("en-US")]
[assembly:System.Resources.SatelliteContractVersionAttribute("4.0.0.0")]
[assembly:System.Runtime.CompilerServices.ReferenceAssemblyAttribute]
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
    [System.AttributeUsageAttribute((System.AttributeTargets)(384), AllowMultiple=false, Inherited=true)]
    public sealed partial class AssociationAttribute : System.Attribute
    {
        public AssociationAttribute(string name, string thisKey, string otherKey) { }
        public bool IsForeignKey { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public string Name { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        public string OtherKey { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        public System.Collections.Generic.IEnumerable<string> OtherKeyMembers { get { throw null; } }
        public string ThisKey { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        public System.Collections.Generic.IEnumerable<string> ThisKeyMembers { get { throw null; } }
    }
    [System.AttributeUsageAttribute((System.AttributeTargets)(384), AllowMultiple=false, Inherited=true)]
    public sealed partial class ConcurrencyCheckAttribute : System.Attribute
    {
        public ConcurrencyCheckAttribute() { }
    }
    [System.AttributeUsageAttribute((System.AttributeTargets)(2500), AllowMultiple=true)]
    public sealed partial class CustomValidationAttribute : System.ComponentModel.DataAnnotations.ValidationAttribute
    {
        public CustomValidationAttribute(System.Type validatorType, string method) { }
        public string Method { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        public override object TypeId { get { throw null; } }
        public System.Type ValidatorType { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        public override string FormatErrorMessage(string name) { throw null; }
        protected override System.ComponentModel.DataAnnotations.ValidationResult IsValid(object value, System.ComponentModel.DataAnnotations.ValidationContext validationContext) { throw null; }
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
        ImageUrl = 13,
        MultilineText = 9,
        Password = 11,
        PhoneNumber = 5,
        Text = 7,
        Time = 3,
        Url = 12,
    }
    [System.AttributeUsageAttribute((System.AttributeTargets)(2496), AllowMultiple=false)]
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
    [System.AttributeUsageAttribute((System.AttributeTargets)(2496), AllowMultiple=false)]
    public sealed partial class DisplayAttribute : System.Attribute
    {
        public DisplayAttribute() { }
        public bool AutoGenerateField { get { throw null; } set { } }
        public bool AutoGenerateFilter { get { throw null; } set { } }
        public string Description { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public string GroupName { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public string Name { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public int Order { get { throw null; } set { } }
        public string Prompt { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public System.Type ResourceType { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public string ShortName { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public System.Nullable<bool> GetAutoGenerateField() { throw null; }
        public System.Nullable<bool> GetAutoGenerateFilter() { throw null; }
        public string GetDescription() { throw null; }
        public string GetGroupName() { throw null; }
        public string GetName() { throw null; }
        public System.Nullable<int> GetOrder() { throw null; }
        public string GetPrompt() { throw null; }
        public string GetShortName() { throw null; }
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
        public bool HtmlEncode { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public string NullDisplayText { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    }
    [System.AttributeUsageAttribute((System.AttributeTargets)(384), AllowMultiple=false, Inherited=true)]
    public sealed partial class EditableAttribute : System.Attribute
    {
        public EditableAttribute(bool allowEdit) { }
        public bool AllowEdit { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        public bool AllowInitialValue { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    }
    [System.AttributeUsageAttribute((System.AttributeTargets)(2496), AllowMultiple=false)]
    public sealed partial class EnumDataTypeAttribute : System.ComponentModel.DataAnnotations.DataTypeAttribute
    {
        public EnumDataTypeAttribute(System.Type enumType) : base (default(System.ComponentModel.DataAnnotations.DataType)) { }
        public System.Type EnumType { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        public override bool IsValid(object value) { throw null; }
    }
    [System.AttributeUsageAttribute((System.AttributeTargets)(384), AllowMultiple=false)]
    public sealed partial class FilterUIHintAttribute : System.Attribute
    {
        public FilterUIHintAttribute(string filterUIHint) { }
        public FilterUIHintAttribute(string filterUIHint, string presentationLayer) { }
        public FilterUIHintAttribute(string filterUIHint, string presentationLayer, params object[] controlParameters) { }
        public System.Collections.Generic.IDictionary<string, object> ControlParameters { get { throw null; } }
        public string FilterUIHint { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        public string PresentationLayer { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        public override object TypeId { get { throw null; } }
        public override bool Equals(object obj) { throw null; }
        public override int GetHashCode() { throw null; }
    }
    public partial interface IValidatableObject
    {
        System.Collections.Generic.IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> Validate(System.ComponentModel.DataAnnotations.ValidationContext validationContext);
    }
    [System.AttributeUsageAttribute((System.AttributeTargets)(384), AllowMultiple=false, Inherited=true)]
    public sealed partial class KeyAttribute : System.Attribute
    {
        public KeyAttribute() { }
    }
    [System.AttributeUsageAttribute((System.AttributeTargets)(4), AllowMultiple=false)]
    public sealed partial class MetadataTypeAttribute : System.Attribute
    {
        public MetadataTypeAttribute(System.Type metadataClassType) { }
        public System.Type MetadataClassType { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
    }
    [System.AttributeUsageAttribute((System.AttributeTargets)(2432), AllowMultiple=false)]
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
    [System.AttributeUsageAttribute((System.AttributeTargets)(2432), AllowMultiple=false)]
    public partial class RegularExpressionAttribute : System.ComponentModel.DataAnnotations.ValidationAttribute
    {
        public RegularExpressionAttribute(string pattern) { }
        public string Pattern { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        public override string FormatErrorMessage(string name) { throw null; }
        public override bool IsValid(object value) { throw null; }
    }
    [System.AttributeUsageAttribute((System.AttributeTargets)(2432), AllowMultiple=false)]
    public partial class RequiredAttribute : System.ComponentModel.DataAnnotations.ValidationAttribute
    {
        public RequiredAttribute() { }
        public bool AllowEmptyStrings { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
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
    [System.AttributeUsageAttribute((System.AttributeTargets)(2432), AllowMultiple=false)]
    public partial class StringLengthAttribute : System.ComponentModel.DataAnnotations.ValidationAttribute
    {
        public StringLengthAttribute(int maximumLength) { }
        public int MaximumLength { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        public int MinimumLength { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public override string FormatErrorMessage(string name) { throw null; }
        public override bool IsValid(object value) { throw null; }
    }
    [System.AttributeUsageAttribute((System.AttributeTargets)(2432), AllowMultiple=false)]
    public partial class TimestampAttribute : System.Attribute
    {
        public TimestampAttribute() { }
    }
    [System.AttributeUsageAttribute((System.AttributeTargets)(384), AllowMultiple=true)]
    public partial class UIHintAttribute : System.Attribute
    {
        public UIHintAttribute(string uiHint) { }
        public UIHintAttribute(string uiHint, string presentationLayer) { }
        public UIHintAttribute(string uiHint, string presentationLayer, params object[] controlParameters) { }
        public System.Collections.Generic.IDictionary<string, object> ControlParameters { get { throw null; } }
        public string PresentationLayer { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        public override object TypeId { get { throw null; } }
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
        public string ErrorMessageResourceName { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public System.Type ErrorMessageResourceType { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        protected string ErrorMessageString { get { throw null; } }
        public virtual string FormatErrorMessage(string name) { throw null; }
        public System.ComponentModel.DataAnnotations.ValidationResult GetValidationResult(object value, System.ComponentModel.DataAnnotations.ValidationContext validationContext) { throw null; }
        public virtual bool IsValid(object value) { throw null; }
        protected virtual System.ComponentModel.DataAnnotations.ValidationResult IsValid(object value, System.ComponentModel.DataAnnotations.ValidationContext validationContext) { throw null; }
        public void Validate(object value, System.ComponentModel.DataAnnotations.ValidationContext validationContext) { }
        public void Validate(object value, string name) { }
    }
    public sealed partial class ValidationContext : System.IServiceProvider
    {
        public ValidationContext(object instance, System.IServiceProvider serviceProvider, System.Collections.Generic.IDictionary<object, object> items) { }
        public string DisplayName { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public System.Collections.Generic.IDictionary<object, object> Items { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        public string MemberName { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public object ObjectInstance { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        public System.Type ObjectType { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        public System.ComponentModel.Design.IServiceContainer ServiceContainer { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        public object GetService(System.Type serviceType) { throw null; }
    }
    [System.SerializableAttribute]
    public partial class ValidationException : System.Exception
    {
        public ValidationException() { }
        public ValidationException(System.ComponentModel.DataAnnotations.ValidationResult validationResult, System.ComponentModel.DataAnnotations.ValidationAttribute validatingAttribute, object value) { }
        protected ValidationException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
        public ValidationException(string message) { }
        public ValidationException(string errorMessage, System.ComponentModel.DataAnnotations.ValidationAttribute validatingAttribute, object value) { }
        public ValidationException(string message, System.Exception innerException) { }
        public System.ComponentModel.DataAnnotations.ValidationAttribute ValidationAttribute { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        public System.ComponentModel.DataAnnotations.ValidationResult ValidationResult { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        public object Value { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        [System.Security.Permissions.SecurityPermissionAttribute(System.Security.Permissions.SecurityAction.LinkDemand, Flags=(System.Security.Permissions.SecurityPermissionFlag)(128))]
        public override void GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
    }
    public partial class ValidationResult
    {
        public static readonly System.ComponentModel.DataAnnotations.ValidationResult Success;
        protected ValidationResult(System.ComponentModel.DataAnnotations.ValidationResult validationResult) { }
        public ValidationResult(string errorMessage) { }
        public ValidationResult(string errorMessage, System.Collections.Generic.IEnumerable<string> memberNames) { }
        public string ErrorMessage { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public System.Collections.Generic.IEnumerable<string> MemberNames { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
    }
    public static partial class Validator
    {
        public static bool TryValidateObject(object instance, System.ComponentModel.DataAnnotations.ValidationContext validationContext, System.Collections.Generic.ICollection<System.ComponentModel.DataAnnotations.ValidationResult> validationResults) { throw null; }
        public static bool TryValidateObject(object instance, System.ComponentModel.DataAnnotations.ValidationContext validationContext, System.Collections.Generic.ICollection<System.ComponentModel.DataAnnotations.ValidationResult> validationResults, bool validateAllProperties) { throw null; }
        public static bool TryValidateProperty(object value, System.ComponentModel.DataAnnotations.ValidationContext validationContext, System.Collections.Generic.ICollection<System.ComponentModel.DataAnnotations.ValidationResult> validationResults) { throw null; }
        public static bool TryValidateValue(object value, System.ComponentModel.DataAnnotations.ValidationContext validationContext, System.Collections.Generic.ICollection<System.ComponentModel.DataAnnotations.ValidationResult> validationResults, System.Collections.Generic.IEnumerable<System.ComponentModel.DataAnnotations.ValidationAttribute> validationAttributes) { throw null; }
        public static void ValidateObject(object instance, System.ComponentModel.DataAnnotations.ValidationContext validationContext) { }
        public static void ValidateObject(object instance, System.ComponentModel.DataAnnotations.ValidationContext validationContext, bool validateAllProperties) { }
        public static void ValidateProperty(object value, System.ComponentModel.DataAnnotations.ValidationContext validationContext) { }
        public static void ValidateValue(object value, System.ComponentModel.DataAnnotations.ValidationContext validationContext, System.Collections.Generic.IEnumerable<System.ComponentModel.DataAnnotations.ValidationAttribute> validationAttributes) { }
    }
}
